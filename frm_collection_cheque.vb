Imports System.Globalization
Imports DevExpress.XtraReports.UI
Imports MySql.Data.MySqlClient
Imports Newtonsoft.Json

Public Class frm_collection_cheque

    ReadOnly conn As New MySqlConnection(str)
    Public Property customer_id = 0
    Public Property customer_name = ""
    Dim dt_cheque As New DataTable
    Dim ListOfItem As List(Of cheques) = New List(Of cheques)

    '--- ONLOAD ---
    Private Sub frm_accounting_cheque_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dt_cheque.Columns.Add("cheque_no")
        dt_cheque.Columns.Add("cheque_date")
        dt_cheque.Columns.Add("cheque_amount")
        dt_cheque.Columns.Add("acc_no")
        dt_cheque.Columns.Add("acc_name")
        dt_cheque.Columns.Add("payee")
        dt_cheque.Columns.Add("bank")
        grid_cheque.DataSource = dt_cheque
        LoadBank()

    End Sub



    '--- FUNCTIONS ---

    'Load Banks
    Private Sub LoadBank()
        Using conn
            conn.Open()
            Using mySqlCommand = New MySqlCommand("SELECT bank FROM ims_cheque_collections GROUP BY bank", conn)
                Using rdr As MySqlDataReader = mySqlCommand.ExecuteReader()
                    While rdr.Read()
                        cbb_bank.Properties.Items.Add(rdr("bank"))
                    End While
                End Using
            End Using
        End Using
    End Sub

    'Load Transactions
    Private Sub LoadTransactions(cid As Integer)


        Try
            conn.Open()
            Dim cmd = New MySqlCommand("SELECT order_id, date_ordered, amount_due, payment_type FROM ims_orders 
                            WHERE (payment_type='cheque' OR payment_type='terms') AND payment_status='UNPAID' AND customer='" & cid & "' AND deleted=0", conn)
            cmd.ExecuteNonQuery()

            Dim dt = New DataTable
            Dim da = New MySqlDataAdapter(cmd)
            da.Fill(dt)

            grid_transaction.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            conn.Close()
        End Try

    End Sub

    'Grid Transaction Selection
    Private Sub grid_transaction_view_SelectionChanged(sender As Object, e As DevExpress.Data.SelectionChangedEventArgs) Handles grid_transaction_view.SelectionChanged

        Dim selectedRowHandles = grid_transaction_view.GetSelectedRows
        Dim amount = 0.00

        For i = 0 To selectedRowHandles.Length - 1
            amount += grid_transaction_view.GetRowCellValue(selectedRowHandles(i), col_amount)
            txt_total.Text = FormatCurrency(amount, 2)
        Next

        If selectedRowHandles.Length = 0 Then txt_total.Text = ""

    End Sub

    'Print Collection Receipt
    Private Sub Print_Collection_Receipt(collection_id As Integer)
        Try
            Dim report = New doc_collection_receipt()
            Dim printTool = New ReportPrintTool(report)
            Dim table = New PrintData

            Using connection = New MySqlConnection(str)
                connection.Open()

                Dim so_nos = String.Empty
                Using cmd = New MySqlCommand("SELECT collection_id, so_nos, cheques, date_generated, ims_users.first_name AS collected_by, ims_customers.first_name AS c_name, ims_customers.address,
                                (SELECT value FROM ims_settings WHERE name='store_info') as store_info
                                FROM ims_collection_receipts 
                                INNER JOIN ims_customers ON ims_customers.customer_id=ims_collection_receipts.customer_id
                                INNER JOIN ims_users ON ims_users.usr_id=ims_collection_receipts.collected_by
                                WHERE collection_id=" & collection_id, connection)
                    Using rdr = cmd.ExecuteReader
                        While rdr.Read
                            report.Parameters("store_info").Value = rdr("store_info")
                            report.Parameters("collection_id").Value = "CR" & rdr("collection_id").ToString.PadLeft(5, "0"c)
                            report.Parameters("collection_date").Value = rdr("date_generated")
                            report.Parameters("customer").Value = rdr("c_name")
                            report.Parameters("address").Value = rdr("address")
                            report.Parameters("collected_by").Value = rdr("collected_by")
                            report.Parameters("encoded_by").Value = rdr("collected_by")
                            so_nos = rdr("so_nos")

                            Dim itemsObject = JsonConvert.DeserializeObject(Of List(Of cheques))(rdr("cheques"))
                            For Each item In itemsObject
                                table.payment_voucher_cheque.Rows.Add(item.bank, item.cheque_date, item.cheque_no, item.amount)
                            Next

                        End While
                    End Using
                End Using

                Dim so_nos_array = so_nos.Split(",")
                    For i = 0 To so_nos_array.Length - 1
                    Using cmd = New MySqlCommand("SELECT order_id, date_released, DATE_ADD(date_released, INTERVAL terms DAY) AS due_date, amount_due FROM ims_orders WHERE order_id=" & so_nos_array(i), connection)
                        Using rdr = cmd.ExecuteReader
                            While rdr.Read
                                table.collection_receipt.Rows.Add("SO" & rdr("order_id").ToString.PadLeft(5, "0"c), rdr("date_released"), rdr("due_date"), rdr("amount_due"))
                            End While
                        End Using
                    End Using
                Next

                report.RequestParameters = False
                report.DataSource = table
                report.ShowRibbonPreviewDialog()


            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub




    '--- CONTROLS ---

    'btn_select
    Private Sub btn_select_Click(sender As Object, e As EventArgs) Handles btn_select.Click
        customer_id = 0
        txt_total.Text = ""
        frm_collection_cheque_customer.ShowDialog()

        If Not IsNothing(grid_cheque.DataSource) Then
            Dim dt = TryCast(grid_cheque.DataSource, DataTable)
            dt.Rows.Clear()
            grid_cheque.DataSource = dt
        End If


        lbl_customer_id.Text = customer_id
        txt_customer_name.Text = customer_name
        LoadTransactions(customer_id)
    End Sub


    'btn_close
    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub

    'btn_apply
    Private Sub btn_apply_Click(sender As Object, e As EventArgs) Handles btn_apply.Click

        'Customer Validation
        If String.IsNullOrWhiteSpace(txt_customer_name.Text) Then
            MsgBox("Select Customer first!", vbCritical, "Required")
            Exit Sub
        End If

        ':Transactions
        If grid_transaction_view.GetSelectedRows.Length <= 0 Then
            MsgBox("No Selected Transaction Found!", vbCritical, "No Transaction")
            Exit Sub
        ElseIf grid_cheque_view.RowCount <= 0 Then
            MsgBox("No Cheque Details Found!", vbCritical, "No Cheque")
            Exit Sub
        End If

        'Get total
        Dim total As Decimal = 0.00
        For i = 0 To grid_cheque_view.RowCount - 1
            total += CDec(grid_cheque_view.GetRowCellValue(i, col_cheque_amount))
        Next

        'If not Tally | 1 peso 
        If Math.Abs(total) < Math.Abs(txt_total.Text - 1) Or Math.Abs(total) > Math.Abs(txt_total.Text + 1) Then
            MsgBox("Total amount of Cheque(s) is NOT equal to Transaction(s) total." & vbCrLf & vbCrLf _
                   & "Total Cheque(s) Amount: " & total & vbCrLf _
                   & "Total Transaction(s) Amount: " & CDec(txt_total.Text), vbCritical, "Not Equal")
            Exit Sub
        End If

        'After Validation
        If MsgBox("Proceed to Create Cheque Payment?", vbQuestion + vbYesNo, "Confirmation") = vbYes Then

            Try
                Dim orders = "", cheque_number = "", cheque_date = ""
                Dim selectedRowHandles = grid_transaction_view.GetSelectedRows

                For i = 0 To selectedRowHandles.Length - 1
                    If i = selectedRowHandles.Length - 1 Then
                        orders = String.Concat(orders, grid_transaction_view.GetRowCellValue(selectedRowHandles(i), col_id))
                    Else
                        orders = String.Concat(orders, grid_transaction_view.GetRowCellValue(selectedRowHandles(i), col_id), ",")
                    End If
                Next


                Using connection = New MySqlConnection(str)
                    connection.Open()

                    'INSERT CHEQUE
                    Dim cheque_cmd = New MySqlCommand("INSERT INTO ims_cheque_collections (cheque_date, cheque_no, amount, acc_name, acc_no, payee_name, customer_id, orders, bank, status, entry_date) 
                                            VALUES (@cheque_date, @cheque_no, @amount, @acc_name, @acc_no, @payee_name, @customer_id, @orders, @bank, @status, @entry_date)", connection)
                    cheque_cmd.Parameters.AddWithValue("@cheque_no", String.Empty)
                    cheque_cmd.Parameters.AddWithValue("@cheque_date", String.Empty)
                    cheque_cmd.Parameters.AddWithValue("@amount", String.Empty)
                    cheque_cmd.Parameters.AddWithValue("@bank", String.Empty)
                    cheque_cmd.Parameters.AddWithValue("@acc_no", String.Empty)
                    cheque_cmd.Parameters.AddWithValue("@acc_name", String.Empty)
                    cheque_cmd.Parameters.AddWithValue("@payee_name", String.Empty)
                    cheque_cmd.Parameters.AddWithValue("@orders", orders)
                    cheque_cmd.Parameters.AddWithValue("@customer_id", lbl_customer_id.Text)
                    cheque_cmd.Parameters.AddWithValue("@entry_date", Date.Today)
                    cheque_cmd.Parameters.AddWithValue("@status", "RECEIVED")
                    cheque_cmd.Prepare()

                    For i = 0 To grid_cheque_view.RowCount - 1
                        Dim intRow = grid_cheque_view.GetVisibleRowHandle(i)
                        cheque_cmd.Parameters(0).Value = grid_cheque_view.GetRowCellValue(intRow, col_cheque_no)
                        cheque_cmd.Parameters(1).Value = Date.ParseExact(grid_cheque_view.GetRowCellValue(0, col_cheque_date), "MM/dd/yyyy", CultureInfo.InvariantCulture).ToString("yyyy/MM/dd")
                        cheque_cmd.Parameters(2).Value = CDec(grid_cheque_view.GetRowCellValue(intRow, col_cheque_amount))
                        cheque_cmd.Parameters(3).Value = grid_cheque_view.GetRowCellValue(intRow, col_bank)
                        cheque_cmd.Parameters(4).Value = grid_cheque_view.GetRowCellValue(intRow, col_acc_no)
                        cheque_cmd.Parameters(5).Value = grid_cheque_view.GetRowCellValue(intRow, col_acc_name)
                        cheque_cmd.Parameters(6).Value = grid_cheque_view.GetRowCellValue(intRow, col_payee)
                        cheque_cmd.Parameters(7).Value = orders
                        cheque_cmd.Parameters(8).Value = lbl_customer_id.Text
                        cheque_cmd.ExecuteScalar()

                        If i = grid_cheque_view.RowCount - 1 Then
                            cheque_number += grid_cheque_view.GetRowCellValue(intRow, col_cheque_no)
                        Else
                            cheque_number += grid_cheque_view.GetRowCellValue(intRow, col_cheque_no) & ", "
                        End If

                    Next


                    'UPDATE ORDERS
                    For i = 0 To selectedRowHandles.Length - 1
                        Dim id = grid_transaction_view.GetRowCellValue(selectedRowHandles(i), col_id)
                        Dim amount As Decimal = grid_transaction_view.GetRowCellValue(selectedRowHandles(i), col_amount)

                        Dim order_cmd = New MySqlCommand("UPDATE ims_orders SET paid_amount=@amount, payment_option=@option, payment_details=@details, 
                                            status=IF((status='Released' AND shipping_method='Deliver'), 'Completed', status) , payment_status='PAID' WHERE order_id=" & id, connection)
                        order_cmd.Parameters.AddWithValue("@option", "Cheque")
                        order_cmd.Parameters.AddWithValue("@amount", amount)
                        order_cmd.Parameters.AddWithValue("@details", Date.Today & " - " & cheque_number)
                        order_cmd.ExecuteNonQuery()
                    Next

                    'INSERT TO IMS_COLLECTION_RECEIPT
                    Using cmd_collection = New MySqlCommand("INSERT INTO ims_collection_receipts (customer_id, so_nos, cheques, date_generated, collected_by) 
                                            VALUES (@customer_id, @so_nos, @cheques, NOW(), @collected_by); SELECT LAST_INSERT_ID()", connection)

                        For i = 0 To grid_cheque_view.RowCount - 1
                            ListOfItem.Add(New cheques With {
                                .cheque_no = grid_cheque_view.GetRowCellValue(i, col_cheque_no),
                                .cheque_date = Date.ParseExact(grid_cheque_view.GetRowCellValue(i, col_cheque_date), "MM/dd/yyyy", CultureInfo.InvariantCulture),
                                .bank = grid_cheque_view.GetRowCellValue(i, col_bank),
                                .amount = grid_cheque_view.GetRowCellValue(i, col_cheque_amount)
                            })
                        Next

                        cmd_collection.Parameters.AddWithValue("@customer_id", lbl_customer_id.Text)
                        cmd_collection.Parameters.AddWithValue("@so_nos", orders)
                        cmd_collection.Parameters.AddWithValue("@cheques", JsonConvert.SerializeObject(ListOfItem))
                        cmd_collection.Parameters.AddWithValue("@collected_by", frm_main.user_id.Text)

                        'PRINT COLLECTION RECEIPT
                        Print_Collection_Receipt(cmd_collection.ExecuteScalar())

                    End Using


                    MsgBox("Order(s) has been marked as PAID.", vbInformation, "Success")
                    frm_main.LoadFrm(New frm_collection_payments)
                    Me.Close()

                End Using

            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try

        End If

    End Sub

    'btn_add
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click

        'Validate
        If String.IsNullOrWhiteSpace(txt_no.Text) Or String.IsNullOrWhiteSpace(txt_amount.Text) Or String.IsNullOrWhiteSpace(dt_date.Text) Or String.IsNullOrWhiteSpace(cbb_bank.Text) Then
            MsgBox("Incomplete cheque details!", vbCritical, "Required")
            Exit Sub
        End If

        Dim dataSource As DataTable = TryCast(grid_cheque.DataSource, DataTable)
        dataSource.Rows.Add(New Object() {txt_no.Text, dt_date.Text, FormatCurrency(CDec(txt_amount.Text)), txt_acc_no.Text, txt_acc_name.Text, txt_payee.Text, cbb_bank.Text})
        grid_cheque.DataSource = dataSource
        txt_no.Text = String.Empty
        txt_amount.Text = String.Empty
        dt_date.Text = String.Empty
        txt_acc_no.Text = String.Empty
        txt_acc_name.Text = String.Empty
        txt_payee.Text = String.Empty
        cbb_bank.Text = String.Empty
        ComputeTotal()

    End Sub

    'Compute Total
    Private Sub ComputeTotal()
        Dim total As Decimal = 0.00
        For i = 0 To grid_cheque_view.RowCount - 1
            total = Decimal.Add(total, grid_cheque_view.GetRowCellValue(i, col_cheque_amount))
        Next

        lbl_total_amount_cheques.Text = FormatCurrency(total, 2)

    End Sub

    'btn_delete
    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

        If grid_cheque_view.RowCount > 0 Then
            grid_cheque_view.DeleteSelectedRows()
            ComputeTotal()
        End If

    End Sub

End Class

