Imports DevExpress.LookAndFeel
Imports DevExpress.XtraReports.UI
Imports MySql.Data.MySqlClient

Public Class frm_accounting_generate_voucher

    ReadOnly conn As New MySqlConnection(str)



    '--- ONLOAD -----
    Private Sub frm_accounting_generate_voucher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_suppliers()
        col_cashid.Visible = False
    End Sub







    '--- FUNCTIONS ----

    'Load Supplier List
    Private Sub load_suppliers()

        Try
            conn.Open()
            Dim cmd = New MySqlCommand("SELECT supplier FROM ims_suppliers", conn)
            Dim rdr = cmd.ExecuteReader

            While rdr.Read
                cbb_suppliers.Properties.Items.Add(rdr("supplier"))
            End While

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            conn.Close()
        End Try

    End Sub

    'Get Payment Voucher Count
    Private Function get_count(connection As MySqlConnection)

        Dim get_cmd = New MySqlCommand("SELECT COUNT(*) FROM ims_payment_vouchers", connection)
        Return get_cmd.ExecuteScalar

    End Function

    'Print Voucher
    Private Sub print_voucher(id As Integer)
        Dim report = New doc_payment_voucher()
        Dim printTool = New ReportPrintTool(report)
        Dim table = New PrintData

        Dim conn As New MySqlConnection(str)
        Dim supplier = "", collection_ref = "", generated_by = "", voucher_date = New Date, receipts() As String = {}, store_name = "", store_info = "", payment_type = String.Empty, contact_person = String.Empty

        Try

            conn.Open()

            'GET VOUCHER DETAILS
            Dim query = "SELECT payment_type, receipts, collection_ref, creation_date, receipts, ims_users.first_name, ims_suppliers.supplier, ims_suppliers.contact_person,
                        (SELECT VALUE FROM ims_settings WHERE NAME='store_name') AS store_name, (SELECT value FROM ims_settings WHERE name='store_info') as store_info 
                        FROM ims_payment_vouchers
                        INNER JOIN ims_suppliers ON ims_suppliers.id=ims_payment_vouchers.supplier
                        INNER JOIN ims_users ON ims_users.usr_id=ims_payment_vouchers.generated_by
                        WHERE payment_id=@payment_id"
            Using cmd = New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@payment_id", id)
                Using rdr_details = cmd.ExecuteReader
                    While rdr_details.Read
                        store_name = rdr_details("store_name")
                        contact_person = rdr_details("contact_person")
                        payment_type = rdr_details("payment_type")
                        voucher_date = rdr_details("creation_date")
                        collection_ref = rdr_details("collection_ref")
                        supplier = rdr_details("supplier")
                        collection_ref = rdr_details("collection_ref")
                        generated_by = rdr_details("first_name")
                        store_info = rdr_details("store_info")

                        receipts = rdr_details("receipts").ToString.Split(",")

                    End While
                End Using
            End Using


            'GET RECEIPTS DATA
            Using get_receipt = New MySqlCommand("SELECT CONCAT('PO', LPAD(ims_delivery_receipts.purchase_id, 5, 0)) as purchase_id, receipt_type, receipt_ref, received_date, ims_purchase.terms,
                                    payment_cheque, payment_dates, ims_delivery_receipts.amount, ims_generated_cheques.bank,
                                    DATE_ADD(received_date, INTERVAL ims_purchase.terms DAY) as due_date FROM ims_delivery_receipts 
                                    INNER JOIN ims_purchase ON ims_purchase.purchase_id=ims_delivery_receipts.purchase_id
                                    LEFT JOIN ims_generated_cheques ON ims_generated_cheques.id=ims_delivery_receipts.cheque_id 
                                    WHERE payment_ref=@ref ORDER BY receipt_ref ASC", conn)
                get_receipt.Parameters.AddWithValue("@ref", id)
                Using reader = get_receipt.ExecuteReader
                    While reader.Read
                        table.payment_voucher.Rows.Add(reader("purchase_id"),
                                                   reader("received_date"),
                                                   reader("terms"),
                                                   reader("payment_cheque"),
                                                   reader("payment_dates"),
                                                   reader("amount"),
                                                   reader("bank"),
                                                   reader("due_date"),
                                                   reader("receipt_type"),
                                                   reader("receipt_ref"))
                    End While
                End Using
            End Using

            Dim cheque_no As String = "0"

            Select Case payment_type
                Case "cheque"
                    'Get Cheque Total No. and Details
                    Using get_cheque = New MySqlCommand("SELECT bank, cheque_no, cheque_date, ims_generated_cheques.amount FROM ims_generated_cheques 
                            INNER JOIN ims_delivery_receipts ON ims_delivery_receipts.payment_cheque=cheque_no
                            WHERE payment_ref=@ref GROUP BY cheque_no, bank, ims_generated_cheques.amount, cheque_date", conn)
                        get_cheque.Parameters.AddWithValue("@ref", id)
                        Using rdr_cheque = get_cheque.ExecuteReader
                            While rdr_cheque.Read
                                table.payment_voucher_cheque.Rows.Add(rdr_cheque("bank"), rdr_cheque("cheque_date"), rdr_cheque("cheque_no"), rdr_cheque("amount"))
                                cheque_no = rdr_cheque("cheque_no")
                            End While
                        End Using
                    End Using

                Case "cash"
                    'Get Cash Details
                    Using get_cheque = New MySqlCommand("SELECT ims_generated_cash.id, ims_generated_cash.payment_date, ims_generated_cash.amount 
                                            FROM ims_delivery_receipts  
                                            INNER JOIN ims_generated_cash ON ims_generated_cash.id=cash_id
                                            WHERE payable_id=@pid GROUP BY id", conn)
                        get_cheque.Parameters.AddWithValue("@pid", receipts(0))
                        Using rdr_cheque = get_cheque.ExecuteReader
                            While rdr_cheque.Read
                                table.payment_voucher_cheque.Rows.Add(rdr_cheque("id"), rdr_cheque("payment_date"), Nothing, rdr_cheque("amount"))
                            End While
                        End Using
                        'get_cheque.Prepare()

                        'For i = 0 To receipts.Length - 1
                        '    get_cheque.Parameters(0).Value = receipts(i)
                        '    Using rdr_cheque = get_cheque.ExecuteReader
                        '        While rdr_cheque.Read
                        '            table.payment_voucher_cheque.Rows.Add(rdr_cheque("id"), rdr_cheque("payment_date"), Nothing, rdr_cheque("amount"))
                        '        End While
                        '    End Using
                        'Next
                    End Using

            End Select


            'GET PURCHASE RETURNS
            Using get_returns = New MySqlCommand("SELECT po_return_id, ims_suppliers.supplier, total_cost FROM ims_purchase_returns 
                                LEFT JOIN ims_suppliers ON ims_suppliers.id=ims_purchase_returns.supplier_id
                                WHERE cheque_no=" & cheque_no, conn)
                Using reader = get_returns.ExecuteReader
                    While reader.Read
                        table.purchase_returns.Rows.Add(reader("po_return_id"), reader("supplier"), reader("total_cost"))
                    End While
                End Using
            End Using

            report.Parameters("store_name").Value = store_name
            report.Parameters("store_info").Value = store_info
            report.Parameters("voucher_id").Value = "PV" & id.ToString.PadLeft(5, "0"c)
            report.Parameters("voucher_date").Value = voucher_date
            report.Parameters("supplier").Value = supplier
            report.Parameters("collection_ref").Value = collection_ref
            report.Parameters("generated_by").Value = generated_by
            report.Parameters("payment_type").Value = payment_type
            report.Parameters("contact_person").Value = contact_person
            report.RequestParameters = False


            report.DataSource = table
            report.ShowRibbonPreviewDialog()

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            conn.Close()
        End Try
    End Sub

    'Load Payments
    Private Sub Load_Payments()

        If Not String.IsNullOrWhiteSpace(cbb_suppliers.Text) Then
            Try
                Using connection = New MySqlConnection(str)
                    connection.Open()

                    Dim payment_type = String.Empty
                    If rb_cheque.Checked = True Then
                        payment_type = "payment_type='cheque'"
                    ElseIf rb_cash.Checked = True Then
                        payment_type = "payment_type='cash'"
                    End If

                    Dim cmd = New MySqlCommand("SELECT payable_id, CONCAT('PO',LPAD(purchase_id, 5, 0)) as purchase_id, receipt_type, cash_id,
                                receipt_ref, ims_delivery_receipts.amount, payment_cheque, payment_dates, ims_generated_cheques.bank FROM `ims_delivery_receipts`
                                LEFT JOIN ims_generated_cheques ON ims_generated_cheques.id=ims_delivery_receipts.cheque_id 
                                LEFT JOIN ims_generated_cash ON ims_generated_cash.id=ims_delivery_receipts.cash_id 
                                WHERE supplier_id=(SELECT id FROM ims_suppliers WHERE supplier=@supplier) AND ims_delivery_receipts.status='ISSUED' AND " & payment_type & "", connection)
                    cmd.Parameters.AddWithValue("@supplier", cbb_suppliers.Text)
                    cmd.ExecuteNonQuery()

                    Dim dt = New DataTable
                    Dim da = New MySqlDataAdapter(cmd)
                    da.Fill(dt)

                    grid_receipts_cheque.DataSource = dt
                End Using

            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try

        End If

    End Sub







    '--- CONTROLS -----

    'Changed Supplier
    Private Sub cbb_suppliers_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbb_suppliers.Properties.SelectedValueChanged
        Load_Payments()
    End Sub

    'Row Click
    Private Sub grid_receipts_view_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles grid_receipts_view.RowClick

        If rb_cheque.Checked = True Then
            Dim current_row_handle = grid_receipts_view.FocusedRowHandle
            Dim cheque_value = grid_receipts_view.GetFocusedRowCellValue(col_cheque_no)
            Dim selected_rows = grid_receipts_view.GetSelectedRows

            If Not selected_rows.Length = 0 Then
                If Not cheque_value = grid_receipts_view.GetRowCellValue(selected_rows(0), col_cheque_no) Then
                    MsgBox("Oops! One (1) cheque only." & vbCrLf & "Unselect other first!", vbInformation, "Information")
                    Return
                End If
            End If

            For i = 0 To grid_receipts_view.RowCount - 1
                If Equals(grid_receipts_view.GetRowCellValue(i, col_cheque_no), cheque_value) Then

                    If current_row_handle = i Then Continue For

                    If grid_receipts_view.IsRowSelected(current_row_handle) Then
                        grid_receipts_view.UnselectRow(i)
                    Else
                        grid_receipts_view.SelectRow(i)
                    End If

                End If
            Next

        ElseIf rb_cash.Checked = True Then
            Dim current_row_handle = grid_receipts_view.FocusedRowHandle
            Dim cheque_value = grid_receipts_view.GetFocusedRowCellValue(col_cashid)
            Dim selected_rows = grid_receipts_view.GetSelectedRows

            If Not selected_rows.Length = 0 Then
                If Not cheque_value = grid_receipts_view.GetRowCellValue(selected_rows(0), col_cashid) Then
                    MsgBox("Oops! One (1) cash only." & vbCrLf & "Unselect other first!", vbInformation, "Information")
                    Return
                End If
            End If

            For i = 0 To grid_receipts_view.RowCount - 1
                If Equals(grid_receipts_view.GetRowCellValue(i, col_cashid), cheque_value) Then

                    If current_row_handle = i Then Continue For

                    If grid_receipts_view.IsRowSelected(current_row_handle) Then
                        grid_receipts_view.UnselectRow(i)
                    Else
                        grid_receipts_view.SelectRow(i)
                    End If

                End If
            Next
        End If

    End Sub

    'Selection Changed
    Private Sub grid_receipts_view_SelectionChanged(sender As Object, e As DevExpress.Data.SelectionChangedEventArgs) Handles grid_receipts_view.SelectionChanged

        Dim total_amount As Decimal = 0.00
        Dim SelectedRows = grid_receipts_view.GetSelectedRows

        For i = 0 To grid_receipts_view.GetSelectedRows.Length - 1
            total_amount += CDec(grid_receipts_view.GetRowCellValue(grid_receipts_view.GetSelectedRows(i), col_amount))
        Next

        txt_total_view.Text = FormatCurrency(total_amount)

        If SelectedRows.Length = 0 Then
            panel_generate.Visible = False
        Else
            panel_generate.Visible = True
        End If

    End Sub

    'btn_generate
    Private Sub btn_generate_Click(sender As Object, e As EventArgs) Handles btn_generate.Click
        If MsgBox("Generate Payment Voucher?" & vbCrLf & vbCrLf & "Press 'Yes' to continue", vbQuestion + vbYesNo, "Confirmation") = vbYes Then

            Try
                conn.Open()

                Dim SelectedRows = grid_receipts_view.GetSelectedRows
                Dim selected_receipts = ""

                'GET RECEIPTS ID
                For i = 0 To SelectedRows.Length - 1
                    'If last
                    If i = SelectedRows.Length - 1 Then
                        selected_receipts += grid_receipts_view.GetRowCellValue(SelectedRows(i), col_id).ToString
                        Continue For
                    End If
                    selected_receipts += grid_receipts_view.GetRowCellValue(SelectedRows(i), col_id) & ", "
                Next

                'GET payment_type
                Dim payment_type = String.Empty
                If rb_cheque.Checked = True Then payment_type = "cheque"
                If rb_cash.Checked = True Then payment_type = "cash"

                'GENERATE NEW VOUCHER
                Using cmd = New MySqlCommand("INSERT INTO ims_payment_vouchers (payment_type, receipts, creation_date, collection_ref, supplier, generated_by)
                                VALUES (@payment_type, @receipts, CURRENT_TIMESTAMP, @collection_ref, (SELECT id FROM ims_suppliers WHERE supplier=@supplier), @generated_by)", conn)
                    cmd.Parameters.AddWithValue("receipts", selected_receipts)
                    cmd.Parameters.AddWithValue("payment_type", payment_type)
                    cmd.Parameters.AddWithValue("collection_ref", txt_collection_ref.Text.Trim)
                    cmd.Parameters.AddWithValue("supplier", cbb_suppliers.Text.Trim)
                    cmd.Parameters.AddWithValue("generated_by", frm_main.user_id.Text)
                    cmd.ExecuteNonQuery()
                End Using

                'GET LAST VOUCHER ID
                Dim voucher_id = get_count(conn)

                'UPDATE RECEIPTS
                Using update_cmd = New MySqlCommand("UPDATE ims_delivery_receipts SET payment_ref=@ref, status='PAID' WHERE payable_id=@id", conn)
                    update_cmd.Parameters.AddWithValue("@id", 0)
                    update_cmd.Parameters.AddWithValue("@ref", voucher_id)
                    update_cmd.Prepare()

                    For i = 0 To SelectedRows.Length - 1
                        update_cmd.Parameters(0).Value = grid_receipts_view.GetRowCellValue(SelectedRows(i), col_id)
                        update_cmd.ExecuteNonQuery()
                    Next
                End Using

                'Print Voucher
                print_voucher(voucher_id)

                txt_collection_ref.Text = ""
                Dim SelectedIndex = cbb_suppliers.SelectedIndex
                Dim frm = New frm_accounting_generate_voucher
                frm_main.LoadFrm(frm)
                MsgBox("Generated Successfully!", vbInformation, "Success")

            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            Finally
                conn.Close()
            End Try

        End If

    End Sub

    'RADIO BUTTONS
    Private Sub rb_cheque_Click(sender As Object, e As EventArgs) Handles rb_cheque.Click
        col_cheque_no.Visible = True
        col_cheque_date.Visible = True
        col_bank.Visible = True
        col_cashid.Visible = False
        Load_Payments()
    End Sub
    Private Sub rb_cash_Click(sender As Object, e As EventArgs) Handles rb_cash.Click
        col_cheque_no.Visible = False
        col_cheque_date.Visible = False
        col_bank.Visible = False
        col_cashid.Visible = True
        Load_Payments()
    End Sub

End Class