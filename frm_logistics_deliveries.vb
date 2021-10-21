Imports System.Text.RegularExpressions
Imports DevExpress.XtraReports.UI
Imports MySql.Data.MySqlClient

Public Class frm_logistics_deliveries


    ReadOnly conn As New MySqlConnection(str)


    '---- ONLOAD ----
    Private Sub frm_logistics_deliveries_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDeliveries()
        start_timer()
    End Sub







    '--- FUNCTIONS ----

    'Load Deliveries
    Private Sub LoadDeliveries()

        Try
            conn.Open()
            Dim cmd = New MySqlCommand("SELECT order_id, date_ordered, ims_users.first_name as agent, ims_customers.first_name, payment_type, IFNULL(payment_status, 'UNPAID') as payment_status, ship_to, trucking, status, amount_due, shipping_method FROM `ims_orders` 
                                INNER JOIN ims_customers on ims_orders.customer=ims_customers.customer_id
                                INNER JOIN ims_users on ims_orders.agent=ims_users.usr_id
                                WHERE (status='Packed' OR status='Released') AND ims_orders.deleted=0
                                ORDER BY order_id DESC", conn)
            cmd.ExecuteNonQuery()

            Dim dt = New DataTable
            Dim da = New MySqlDataAdapter(cmd)
            da.Fill(dt)

            grid_deliveries.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            conn.Close()
        End Try

    End Sub

    'Set data to Table
    Public Sub data_to_grid(orders As String, GridOrTable As Object)

        Dim comma(), equal() As String
        Dim piece As String
        Dim i As Integer
        Dim colonseparator As New Regex("\b;\b")
        Dim equalseparator As New Regex("\b=\b")

        If GridOrTable.Rows.Count > 0 Then GridOrTable.Rows.Clear()

        If Not String.IsNullOrEmpty(orders) Then

            comma = colonseparator.Split(orders)

            For i = 0 To comma.Length - 1
                piece = comma(i).Trim
                equal = piece.Split("=")

                GridOrTable.Rows.Add(equal(0), equal(1), equal(2), equal(3), equal(4), equal(5).Replace(";", ""))

            Next

            GridOrTable.DefaultView.Sort = "model ASC"

        End If

    End Sub

    'Print Invoice Receipt
    Private Sub PrintInvoice(orderid As String)
        Dim report = New doc_sales_order_receipt()
        Dim printTool = New ReportPrintTool(report)
        Dim rdr As MySqlDataReader
        Dim table = New PrintData

        Try
            Using connection = New MySqlConnection(str)
                connection.Open()

                Dim cmd = New MySqlCommand("SELECT order_id, ims_customers.first_name, ims_customers.contact_person, address, ship_to, order_item, pub_note, payment_type, payment_status, DATE_ADD(date_released, INTERVAL ims_customers.terms DAY) AS due_date,
                        ims_customers.terms, amount_due, shipping_method, trucking, date_released, delivery_fee, (SELECT VALUE FROM ims_settings WHERE NAME='store_info') AS store_info,
                        is_vatable, is_withholding_tax_applied, withholding_tax_percentage, withholding_tax_amount, discount_type, discount_val,
                        no_of_box, no_of_plastic, no_of_rolls,
                        agent.first_name AS prepared_by, packer.first_name AS arranged_by, releaser.first_name AS released_by, sales_agent.first_name AS sales_agent FROM `ims_orders`
                        INNER JOIN ims_customers ON ims_customers.customer_id=ims_orders.customer
                        INNER JOIN ims_users AS agent ON agent.usr_id=agent
                        LEFT JOIN ims_users AS sales_agent ON sales_agent.usr_id=sales_agent
                        INNER JOIN ims_users AS packer ON packer.usr_id=packed_by
                        INNER JOIN ims_users AS releaser ON releaser.usr_id=released_by WHERE order_id=@id", connection)
                cmd.Parameters.AddWithValue("@id", orderid)
                rdr = cmd.ExecuteReader

                While rdr.Read
                    report.Parameters("store_info").Value = rdr("store_info")
                    report.Parameters("orderid").Value = String.Concat("SO", rdr("order_id").ToString().PadLeft(5, "0"c))
                    report.Parameters("customer").Value = rdr("first_name")
                    report.Parameters("contact_person").Value = rdr("contact_person")
                    report.Parameters("customer_addr").Value = rdr("address")
                    report.Parameters("shipping_addr").Value = rdr("ship_to")
                    report.Parameters("shipping_method").Value = rdr("shipping_method")
                    report.Parameters("trucking").Value = rdr("trucking")
                    report.Parameters("amount_due").Value = rdr("amount_due")
                    report.Parameters("pub_notes").Value = rdr("pub_note")
                    report.Parameters("date_released").Value = rdr("date_released")
                    report.Parameters("due_date").Value = rdr("due_date")
                    report.Parameters("payment").Value = rdr("payment_type").ToString().ToUpper()
                    report.Parameters("terms").Value = rdr("terms")
                    report.Parameters("delivery_charge").Value = rdr("delivery_fee")
                    report.Parameters("discount_type").Value = rdr("discount_type")
                    report.Parameters("discount_val").Value = rdr("discount_val")
                    report.Parameters("is_vatable").Value = rdr("is_vatable")
                    report.Parameters("is_withholding_tax_applied").Value = rdr("is_withholding_tax_applied")
                    report.Parameters("withholding_tax_percentage").Value = rdr("withholding_tax_percentage")
                    report.Parameters("withholding_tax_amount").Value = rdr("withholding_tax_amount")
                    report.Parameters("no_of_box").Value = rdr("no_of_box")
                    report.Parameters("no_of_plastic").Value = rdr("no_of_plastic")
                    report.Parameters("no_of_rolls").Value = rdr("no_of_rolls")
                    data_to_grid(rdr("order_item"), table.invoice_data)
                    report.Parameters("prepared_by").Value = rdr("prepared_by")
                    report.Parameters("arranged_by").Value = rdr("arranged_by")
                    report.Parameters("released_by").Value = rdr("released_by")
                    report.Parameters("sales_agent").Value = rdr("sales_agent")

                    'ADD PAID WATERMARK WHEN PAID
                    If rdr("payment_status").Equals("PAID") Then
                        report.Watermark.Text = "PAID"
                    End If

                End While

                report.RequestParameters = False
                report.DataSource = table
                report.ShowRibbonPreviewDialog()
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'Set Deduct to Stocks
    Private Sub deduct_to_stocks(orderid As String, customer As String)

        Try
            conn.Open()
            Dim cmd = New MySqlCommand("SELECT order_item FROM ims_orders WHERE order_id=" & orderid, conn)
            Dim orders = cmd.ExecuteScalar

            Dim comma(), equal() As String
            Dim piece As String
            Dim i As Integer
            Dim colonseparator As New Regex("\b;\b")
            Dim equalseparator As New Regex("\b=\b")

            If Not String.IsNullOrEmpty(orders) Then

                Dim my_store = "ims_" & frm_main.user_store.Text.Replace(" ", "_").ToLower

                comma = colonseparator.Split(orders)

                For i = 0 To comma.Length - 1
                    piece = comma(i).Trim
                    equal = piece.Split("=")

                    Dim query = "UPDATE " & my_store & " SET on_hold=IFNULL(on_hold,0)-@qty
                                        WHERE pid=(SELECT pid FROM ims_inventory WHERE winmodel=@winmodel);
                                        INSERT INTO ims_sales (item, qty, price, cost, purchase_date, customer, order_id)
                                        VALUES ((SELECT pid FROM ims_inventory WHERE winmodel=@winmodel), @qty, @price, (SELECT cost FROM ims_inventory WHERE winmodel=@winmodel),  
                                        @purchase_date, (SELECT customer_id FROM ims_customers WHERE first_name=@customer), @order_id)"
                    Dim update_cmd = New MySqlCommand(query, conn)
                    update_cmd.Parameters.AddWithValue("@winmodel", equal(1))
                    update_cmd.Parameters.AddWithValue("@qty", equal(0))
                    update_cmd.Parameters.AddWithValue("@price", CDec(equal(5).Replace(";", "")))
                    update_cmd.Parameters.AddWithValue("@purchase_date", Date.Now)
                    update_cmd.Parameters.AddWithValue("@customer", customer)
                    update_cmd.Parameters.AddWithValue("@order_id", orderid)
                    update_cmd.ExecuteNonQuery()
                Next

            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try

    End Sub

    'Start Timer
    Private Sub start_timer()

        Select Case cbb_timer.SelectedIndex
            Case 0 : timer.Interval = 60000
            Case 1 : timer.Interval = 300000
            Case 2 : timer.Interval = 600000
            Case 3 : timer.Interval = 1800000
        End Select

        timer.Stop()
        timer.Start()

    End Sub

    'Timer
    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        LoadDeliveries()
    End Sub

    'Timer Selection
    Private Sub cbb_timer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbb_timer.SelectedIndexChanged
        start_timer()
    End Sub



    '----- CONTROLS ----

    'Print
    Private Sub btn_print_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btn_print.ButtonClick

        Dim orderid = grid_deliveries_view.GetFocusedRowCellValue(col_id)
        Dim shipping_method = grid_deliveries_view.GetFocusedRowCellValue(col_shipping_method)
        Dim payment_status = grid_deliveries_view.GetFocusedRowCellValue(col_payment_status)
        Dim payment_type = grid_deliveries_view.GetFocusedRowCellValue(col_payment_type)
        Dim customer = grid_deliveries_view.GetFocusedRowCellValue(col_customer)
        Dim amount = CDec(grid_deliveries_view.GetFocusedRowCellValue(col_amount))

        Select Case shipping_method

            'FOR PICKUP
            Case "Pickup"

                'Validation: SKIP IF TERMS
                If payment_type.Equals("Cash") Or payment_type.Equals("Cheque") Then
                    If payment_status.Equals("UNPAID") Or
                        payment_status.Equals("OVERPAID") Or
                        payment_status.Equals("PARTIAL") Then
                        MsgBox("Oops! Settle the payment first." & vbCrLf & vbCrLf & "Reason: UNPAID/PARTIAL/OVERPAID", vbCritical, "Payment Error")
                        Exit Sub
                    End If
                End If

                Dim ans = MsgBox("Release this Order?" & vbCrLf & vbCrLf & "Press 'Yes' to Continue.", vbQuestion + vbYesNo, "Confirmation")
                If ans = vbYes Then

                    Try

                        'Deduct To Stocks
                        deduct_to_stocks(orderid, customer)

                        'If PAID
                        conn.Open()
                        Dim cmd = New MySqlCommand("UPDATE ims_orders SET status='Completed', date_released=@date, released_by=@released_by WHERE order_id=" & orderid, conn)
                        cmd.Parameters.AddWithValue("@date", Date.Now)
                        cmd.Parameters.AddWithValue("@released_by", frm_main.user_id.Text)
                        cmd.ExecuteNonQuery()

                        'Deduct to Credit
                        If payment_type.Equals("Terms") Then
                            Dim credit_cmd = New MySqlCommand("UPDATE ims_customers SET used_credit=used_credit+@amount WHERE first_name=@fname", conn)
                            credit_cmd.Parameters.AddWithValue("@amount", amount)
                            credit_cmd.Parameters.AddWithValue("@fname", customer)
                            credit_cmd.ExecuteNonQuery()
                        End If

                        conn.Close()

                        PrintInvoice(orderid)

                        MsgBox("Successfully Released!", vbInformation, "Released")
                        frm_main.LoadFrm(New frm_logistics_deliveries)

                    Catch ex As Exception
                        MsgBox(ex.Message, vbCritical, "Error")
                    Finally
                        If conn.State = ConnectionState.Open Then conn.Close()
                    End Try

                End If


            'FOR DELIVERY
            Case "Deliver"

                If grid_deliveries_view.GetFocusedRowCellValue(col_status).Equals("Released") Then
                    MsgBox("Oops! Package was 'Already Released'.", vbExclamation, "Forbidden")
                    Exit Sub
                End If

                Dim ans = MsgBox("Ready for Delivery?" & vbCrLf & vbCrLf & "This will tag as RELEASED. Continue?", vbQuestion + vbYesNo, "Confirmation")
                If ans = vbYes Then

                    Dim status = ""
                    Select Case payment_status
                        Case "UNPAID" : status = "Released"
                        Case "PAID" : status = "Completed"
                    End Select

                    If payment_type.Equals("Terms") Then
                        status = "Completed"
                    End If

                    Try

                        'Deduct To Stocks
                        deduct_to_stocks(orderid, customer)

                        conn.Open()
                        Dim cmd = New MySqlCommand("UPDATE ims_orders SET status=@status, date_released=@date, released_by=@released_by WHERE order_id=" & orderid, conn)
                        cmd.Parameters.AddWithValue("@date", Date.Now)
                        cmd.Parameters.AddWithValue("@released_by", frm_main.user_id.Text)
                        cmd.Parameters.AddWithValue("@status", status)
                        cmd.ExecuteNonQuery()
                        conn.Close()

                        PrintInvoice(orderid)

                        Dim msg = ""
                        Select Case payment_status
                            Case "UNPAID" : msg = "Successfully tag as '" & status.ToUpper & "'" & vbCrLf & vbCrLf & "Please return the payment after Delivery!"
                            Case "PAID" : msg = "Successfully tag as '" & status.ToUpper & "'"
                        End Select


                        If payment_type.Equals("Terms") Then
                            conn.Open()
                            Dim credit_cmd = New MySqlCommand("UPDATE ims_customers SET used_credit=used_credit+@amount WHERE first_name=@fname", conn)
                            credit_cmd.Parameters.AddWithValue("@amount", amount)
                            credit_cmd.Parameters.AddWithValue("@fname", customer)
                            credit_cmd.ExecuteNonQuery()
                            conn.Close()

                            msg = "Successfully tag as '" & status.ToUpper & "'"
                        End If

                        MsgBox(msg, vbInformation, "Success")
                        frm_main.LoadFrm(New frm_logistics_deliveries)

                    Catch ex As Exception
                        MsgBox(ex.Message, vbCritical, "Error")
                    Finally
                        If conn.State = ConnectionState.Open Then conn.Close()
                    End Try

                End If


        End Select

    End Sub

End Class