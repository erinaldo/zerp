Imports System.Text.RegularExpressions
Imports DevExpress.XtraReports.UI
Imports MySql.Data.MySqlClient

Public Class frm_warehouse_delivery_receive

    ReadOnly conn As New MySqlConnection(str)


    '--- ON LOAD ---
    Private Sub frm_purchaseorder_receive_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = txt_poid.Text
    End Sub



    '--- FUNCTIONS ---

    'Not Payment First
    Private Sub not_payment_first()

        'Validate Receive Counts
        Dim received = 0
        Dim TotalAmount As Decimal = 0.00

        For Each row As DataRow In DirectCast(grid_order.DataSource, DataTable).Rows
            received += row.Item(4) + row.Item(5)
            If CInt(row.Item(5)) > 0 Then
                TotalAmount += CInt(row.Item(5)) * CDec(row.Item(7))
            End If
        Next


        'If No Value Detected
        If received = 0 Then
            MsgBox("Can't saved! No values detected.", vbCritical, "Error")
            Exit Sub
        End If

        Try
            'Deduct Discount to TotalAmount
            If Not cbb_discount.SelectedIndex = -1 And Not String.IsNullOrWhiteSpace(txt_discount.Text) Then
                Select Case cbb_discount.SelectedIndex
                    Case 0 : TotalAmount -= CDec(txt_discount.Text)
                    Case 1 : TotalAmount -= (TotalAmount * (CDec(txt_discount.Text) / 100))
                End Select
            End If

            Dim less_wt As Decimal = 0.00
            'Withholding Tax Deduction
            If is_withholding_tax_applied.Checked = True Then
                Dim less_vat_subtotal As Decimal = TotalAmount / 1.12
                Dim withholding_tax As Decimal = less_vat_subtotal * CDec(withholding_tax_percentage.Text / 100)
                TotalAmount -= withholding_tax
                less_wt = withholding_tax
            End If

            'Deduct Return Credit to TotalAmount
            If Not String.IsNullOrWhiteSpace(txt_return_credit.Text) Then
                TotalAmount -= CDec(txt_return_credit.Text)
            End If

            'Receipt Amount Validation
            Dim system_total = TotalAmount
            Dim input_total = Math.Round(CDec(txt_amount.Text.Trim) - less_wt, 2)
            If Math.Abs(input_total) < Math.Abs(system_total - 1) Or Math.Abs(input_total) > Math.Abs(system_total + 1) Then
                MsgBox("Receipt amount value is doesn't match!", vbCritical, "Invalid Amount")
                Exit Sub
            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Number Format Exception")
            Exit Sub
        End Try


        If MsgBox("Press 'YES' to Continue.", vbQuestion + vbYesNo, "Submit") = vbYes Then

            'Declaration of Values
            Dim supplier_id = txt_supid.Text
            Dim purchaseID As Integer = txt_poid.Text.Replace("PO", "")
            Dim receipt_type = cbb_receipt.SelectedItem
            Dim receipt_ref = txt_ref.Text.Trim
            Dim amount = CDec(txt_amount.Text)
            Dim store = "ims_" & cbb_deliver.Text.Replace(" ", "_").ToLower
            Dim str_qtyReceived = ""
            Dim date_receieved = Date.Now

            Dim qtyRemaining = 0, qtyRecieved = 0
            Dim product_ID(500) As Integer, qty_received(500) As Integer
            Dim discount As String

            Select Case cbb_discount.SelectedIndex
                Case 0 : discount = txt_discount.Text & " Pesos OFF"
                Case 1 : discount = txt_discount.Text & "% OFF"
                Case Else : discount = ""
            End Select

            'Get Values From Grid 
            Dim datatable = DirectCast(grid_order.DataSource, DataTable)

            For i = 0 To datatable.Rows.Count - 1
                product_ID(i) = CInt(datatable.Rows(i).Item(0)) 'SKU FOR INSERT TO STORE'S INVENTORY
                qty_received(i) = CInt(datatable.Rows(i).Item(5)) 'RECEIVED FOR INSERT TO STORE'S INVENTORY

                qtyRemaining += datatable.Rows(i).Item(6) 'REMAINING COUNTS
                qtyRecieved += datatable.Rows(i).Item(5) 'RECEIVED COUNTS

                str_qtyReceived += CInt(datatable.Rows(i).Item(4)) + qty_received(i) & ";" 'TOTAL RECEIVED to be inserted to IMS_PURCHASE
            Next

            'For i = 0 To datatable.Rows.Count - 1
            '    product_ID(i) = CInt(grid_order.Rows(i).Cells(0).Value) 'SKU FOR INSERT TO STORE'S INVENTORY
            '    qty_received(i) = CInt(grid_order.Rows(i).Cells(5).Value) 'RECEIVED FOR INSERT TO STORE'S INVENTORY

            '    qtyRemaining += grid_order.Rows(i).Cells(6).Value 'REMAINING COUNTS
            '    qtyRecieved += grid_order.Rows(i).Cells(5).Value 'RECEIVED COUNTS

            '    str_qtyReceived += CInt(grid_order.Rows(i).Cells(4).Value) + qty_received(i) & ";" 'TOTAL RECEIVED to be inserted to IMS_PURCHASE
            'Next


            Try
                conn.Open()

                'Insert to Store's Inventory    
                For i = 0 To datatable.Rows.Count - 1

                    Dim count_cmd = New MySqlCommand("SELECT COUNT(*) FROM " & store & " WHERE pid='" & product_ID(i) & "'", conn)
                    Dim rdr As MySqlDataReader = count_cmd.ExecuteReader
                    Dim result = 0

                    While rdr.Read
                        result = rdr("COUNT(*)")
                    End While
                    rdr.Close()

                    If result = 0 Then
                        Dim new_cmd = New MySqlCommand("INSERT INTO " & store & " (pid, qty) VALUES (@pid, @qty) ", conn)
                        new_cmd.Parameters.AddWithValue("@pid", product_ID(i))
                        new_cmd.Parameters.AddWithValue("@qty", qty_received(i))
                        new_cmd.ExecuteNonQuery()
                    Else
                        Dim update_cmd = New MySqlCommand("UPDATE " & store & " SET qty=qty+@qty WHERE pid=@pid", conn)
                        update_cmd.Parameters.AddWithValue("@qty", qty_received(i))
                        update_cmd.Parameters.AddWithValue("@pid", product_ID(i))
                        update_cmd.ExecuteNonQuery()
                    End If
                Next

                'Insert to Merchandice Payables Table
                Dim payables_cmd = New MySqlCommand("INSERT INTO ims_delivery_receipts (supplier_id, receipt_ref, receipt_type, amount, discount, return_credit, status, received_date, store_id, purchase_id, count_by)
		                VALUES (@supplier_id, @receipt_ref, @receipt_type, @amount, @discount, @return_credit, @status, @received_date, (SELECT store_id FROM ims_stores WHERE store_name=@store_name), @purchase_id, @count_by)", conn)
                payables_cmd.Parameters.AddWithValue("@supplier_id", supplier_id)
                payables_cmd.Parameters.AddWithValue("@receipt_ref", receipt_ref)
                payables_cmd.Parameters.AddWithValue("@receipt_type", receipt_type)
                payables_cmd.Parameters.AddWithValue("@amount", TotalAmount) 'NONE
                payables_cmd.Parameters.AddWithValue("@discount", IIf(String.IsNullOrEmpty(discount), Nothing, discount))
                payables_cmd.Parameters.AddWithValue("@return_credit", IIf(String.IsNullOrWhiteSpace(txt_return_credit.Text), 0, txt_return_credit.Text))
                payables_cmd.Parameters.AddWithValue("@status", "UNPAID")
                payables_cmd.Parameters.AddWithValue("@received_date", date_receieved)
                payables_cmd.Parameters.AddWithValue("@store_name", frm_main.user_store.Text)
                payables_cmd.Parameters.AddWithValue("@purchase_id", purchaseID)
                payables_cmd.Parameters.AddWithValue("@count_by", txt_count_by.Text.ToLower.Trim)
                payables_cmd.ExecuteNonQuery()

                'Get Count of ims_delivery_receipts
                Dim get_count = New MySqlCommand("SELECT COUNT(*) FROM ims_delivery_receipts", conn)
                Dim receipt_id = get_count.ExecuteScalar

                'Insert to Deliveries Table
                Dim deliveries_cmd = New MySqlCommand("INSERT INTO ims_deliveries (item, qty, date_received, purchase_id, receiver, store_id, receipt_id, cost) 
                        VALUES (@item, @qty, @date_received, @purchase_id, @userid, (SELECT store_id FROM ims_stores WHERE store_name=@store), @receipt_id, @cost)", conn)
                deliveries_cmd.Parameters.AddWithValue("@item", 1)
                deliveries_cmd.Parameters.AddWithValue("@qty", 1)
                deliveries_cmd.Parameters.AddWithValue("@purchase_id", purchaseID)
                deliveries_cmd.Parameters.AddWithValue("@userid", frm_main.user_id.Text)
                deliveries_cmd.Parameters.AddWithValue("@date_received", date_receieved)
                deliveries_cmd.Parameters.AddWithValue("@store", cbb_deliver.Text)
                deliveries_cmd.Parameters.AddWithValue("@receipt_id", receipt_id)
                deliveries_cmd.Parameters.AddWithValue("@cost", 0.00)
                deliveries_cmd.Prepare()

                For i = 0 To datatable.Rows.Count - 1
                    If Not datatable.Rows(i).Item(5) = 0 Then
                        deliveries_cmd.Parameters(0).Value = product_ID(i)
                        deliveries_cmd.Parameters(1).Value = qty_received(i)
                        deliveries_cmd.Parameters(7).Value = CDec(datatable.Rows(i).Item(7))
                        deliveries_cmd.ExecuteNonQuery()
                    Else
                        Continue For
                    End If
                Next


                'Update ims_purchase
                Dim cmd = New MySqlCommand("UPDATE ims_purchase SET qty_received=@qty_received, date_completed=@date_completed, status=@status WHERE purchase_id=@purchase_id", conn)
                cmd.Parameters.AddWithValue("@qty_received", str_qtyReceived)
                cmd.Parameters.AddWithValue("@purchase_id", purchaseID)

                If qtyRemaining = qtyRecieved Then
                    cmd.Parameters.AddWithValue("@status", "Completed")
                    cmd.Parameters.AddWithValue("@date_completed", Date.Now)
                    cmd.ExecuteNonQuery()
                    MsgBox("Successfull!", vbInformation + vbOKOnly, "Information")

                    'Load Deliveries
                    frm_main.LoadFrm(New frm_warehouse_deliveries)

                Else
                    cmd.Parameters.AddWithValue("@status", "Partial")
                    cmd.Parameters.AddWithValue("@date_completed", "")
                    cmd.ExecuteNonQuery()
                    MsgBox("Successfull!", vbInformation + vbOKOnly, "Information")

                    'Refresh Current
                    Dim frm = New frm_warehouse_delivery_receive
                    frm_warehouse_deliveries.LoadFrm(frm)
                    Load_Orders(purchaseID)

                End If
                cbb_receipt.SelectedIndex = -1
                txt_ref.Text = String.Empty
                txt_amount.Text = String.Empty
                txt_count_by.Text = String.Empty
                txt_discount.Text = String.Empty
                txt_return_credit.Text = String.Empty
                cbb_discount.SelectedIndex = -1
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            Finally
                conn.Close()
            End Try

        End If

    End Sub

    'Payment First
    Private Sub payment_first()

        'Validate Receive Counts
        Dim received = 0
        Dim TotalAmount As Decimal = 0.00

        'GET TOTAL
        For Each row As DataRow In DirectCast(grid_order.DataSource, DataTable).Rows
            received += row.Item(4) + row.Item(5)
            If CInt(row.Item(5)) > 0 Then
                TotalAmount += CInt(row.Item(5)) * CDec(row.Item(7))
            End If
        Next


        'If No Value Detected
        If received = 0 Then
            MsgBox("Can't saved! No values detected.", vbCritical, "Error")
            Exit Sub
        End If


        Try
            'Deduct Discount to TotalAmount
            If Not cbb_discount.SelectedIndex = -1 And Not String.IsNullOrWhiteSpace(txt_discount.Text) Then
                Select Case cbb_discount.SelectedIndex
                    Case 0 : TotalAmount -= CDec(txt_discount.Text)
                    Case 1 : TotalAmount -= (TotalAmount * (CDec(txt_discount.Text) / 100))
                End Select
            End If

            Dim less_wt As Decimal = 0.00
            'Withholding Tax Deduction
            If is_withholding_tax_applied.Checked = True Then
                Dim less_vat_subtotal As Decimal = TotalAmount / 1.12
                Dim withholding_tax As Decimal = less_vat_subtotal * CDec(withholding_tax_percentage.Text / 100)
                TotalAmount -= withholding_tax
                less_wt = withholding_tax
            End If

            'Deduct Return Credit to TotalAmount
            If Not String.IsNullOrWhiteSpace(txt_return_credit.Text) Then
                TotalAmount -= CDec(txt_return_credit.Text)
            End If

            'Receipt Amount Validation
            Dim system_total = TotalAmount
            Dim input_total = Math.Round(CDec(txt_amount.Text.Trim) - less_wt, 2)
            If Math.Abs(input_total) < Math.Abs(system_total - 1) Or Math.Abs(input_total) > Math.Abs(system_total + 1) Then
                MsgBox("Receipt amount value is doesn't match!", vbCritical, "Invalid Amount")
                Exit Sub
            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Number Format Exception")
            Exit Sub
        End Try




        If MsgBox("Press 'YES' to Continue.", vbQuestion + vbYesNo, "Submit") = vbYes Then

            'Declaration of Values
            Dim supplier_id = txt_supid.Text
            Dim purchaseID As Integer = txt_poid.Text.Replace("PO", "")
            Dim receipt_type = cbb_receipt.SelectedItem
            Dim receipt_ref = txt_ref.Text.Trim
            Dim amount = CDec(txt_amount.Text)
            Dim store = "ims_" & cbb_deliver.Text.Replace(" ", "_").ToLower
            Dim str_qtyReceived = ""
            Dim date_receieved = Date.Now

            Dim qtyRemaining = 0, qtyRecieved = 0
            Dim product_ID(500) As Integer, qty_received(500) As Integer
            Dim discount As String

            Select Case cbb_discount.SelectedIndex
                Case 0 : discount = txt_discount.Text & "Pesos OFF"
                Case 1 : discount = txt_discount.Text & "% OFF"
                Case Else : discount = String.Empty
            End Select

            'Get Values From Grid
            Dim datatable = DirectCast(grid_order.DataSource, DataTable)

            For i = 0 To datatable.Rows.Count - 1
                product_ID(i) = CInt(datatable.Rows(i).Item(0)) 'SKU FOR INSERT TO STORE'S INVENTORY
                qty_received(i) = CInt(datatable.Rows(i).Item(5)) 'RECEIVED FOR INSERT TO STORE'S INVENTORY

                qtyRemaining += datatable.Rows(i).Item(6) 'REMAINING COUNTS
                qtyRecieved += datatable.Rows(i).Item(5) 'RECEIVED COUNTS

                str_qtyReceived += CInt(datatable.Rows(i).Item(4)) + qty_received(i) & ";" 'TOTAL RECEIVED to be inserted to IMS_PURCHASE
            Next

            'For i = 0 To datatable.Rows.Count - 1
            '    product_ID(i) = CInt(grid_order.Rows(i).Cells(0).Value) 'SKU FOR INSERT TO STORE'S INVENTORY
            '    qty_received(i) = CInt(grid_order.Rows(i).Cells(5).Value) 'RECEIVED FOR INSERT TO STORE'S INVENTORY

            '    qtyRemaining += grid_order.Rows(i).Cells(6).Value 'REMAINING COUNTS
            '    qtyRecieved += grid_order.Rows(i).Cells(5).Value 'RECEIVED COUNTS

            '    str_qtyReceived += CInt(grid_order.Rows(i).Cells(4).Value) + qty_received(i) & ";" 'TOTAL RECEIVED to be inserted to IMS_PURCHASE
            'Next


            Try
                conn.Open()

                'Insert to Store's Inventory    
                For i = 0 To datatable.Rows.Count - 1

                    Dim count_cmd = New MySqlCommand("SELECT COUNT(*) FROM " & store & " WHERE pid='" & product_ID(i) & "'", conn)
                    Dim rdr As MySqlDataReader = count_cmd.ExecuteReader
                    Dim result = 0

                    While rdr.Read
                        result = rdr("COUNT(*)")
                    End While
                    rdr.Close()

                    If result = 0 Then
                        Dim new_cmd = New MySqlCommand("INSERT INTO " & store & " (pid, qty) VALUES (@pid, @qty) ", conn)
                        new_cmd.Parameters.AddWithValue("@pid", product_ID(i))
                        new_cmd.Parameters.AddWithValue("@qty", qty_received(i))
                        new_cmd.ExecuteNonQuery()
                    Else
                        Dim update_cmd = New MySqlCommand("UPDATE " & store & " SET qty=qty+@qty WHERE pid=@pid", conn)
                        update_cmd.Parameters.AddWithValue("@qty", qty_received(i))
                        update_cmd.Parameters.AddWithValue("@pid", product_ID(i))
                        update_cmd.ExecuteNonQuery()
                    End If
                Next

                'Get Payable ID
                Dim get_payable_id = New MySqlCommand("SELECT payable_id FROM ims_delivery_receipts WHERE receipt_ref=@ref", conn)
                get_payable_id.Parameters.AddWithValue("@ref", txt_poid.Text)
                Dim receipt_id = get_payable_id.ExecuteScalar()

                'Insert to Deliveries Table
                Dim deliveries_cmd = New MySqlCommand("INSERT INTO ims_deliveries (item, qty, date_received, purchase_id, receiver, store_id, receipt_id, cost) 
                        VALUES (@item, @qty, @date_received, @purchase_id, @userid, (SELECT store_id FROM ims_stores WHERE store_name=@store), @receipt_id, @cost)", conn)
                deliveries_cmd.Parameters.AddWithValue("@item", 1)
                deliveries_cmd.Parameters.AddWithValue("@qty", 1)
                deliveries_cmd.Parameters.AddWithValue("@purchase_id", purchaseID)
                deliveries_cmd.Parameters.AddWithValue("@userid", frm_main.user_id.Text)
                deliveries_cmd.Parameters.AddWithValue("@date_received", date_receieved)
                deliveries_cmd.Parameters.AddWithValue("@store", frm_main.user_store.Text)
                deliveries_cmd.Parameters.AddWithValue("@receipt_id", receipt_id)
                deliveries_cmd.Parameters.AddWithValue("@cost", 0.00)
                deliveries_cmd.Prepare()

                For i = 0 To datatable.Rows.Count - 1
                    If Not datatable.Rows(i).Item(5) = 0 Then
                        deliveries_cmd.Parameters(0).Value = product_ID(i)
                        deliveries_cmd.Parameters(1).Value = qty_received(i)
                        deliveries_cmd.Parameters(7).Value = CDec(datatable.Rows(i).Item(7))
                        deliveries_cmd.ExecuteNonQuery()
                    Else
                        Continue For
                    End If
                Next


                'Update ims_purchase
                Dim cmd = New MySqlCommand("UPDATE ims_purchase SET qty_received=@qty_received, date_completed=@date_completed, status=@status WHERE purchase_id=@purchase_id", conn)
                cmd.Parameters.AddWithValue("@qty_received", str_qtyReceived)
                cmd.Parameters.AddWithValue("@purchase_id", purchaseID)

                If qtyRemaining = qtyRecieved Then
                    cmd.Parameters.AddWithValue("@status", "Completed")
                    cmd.Parameters.AddWithValue("@date_completed", Date.Now)
                    cmd.ExecuteNonQuery()
                    MsgBox("Successfull!", vbInformation + vbOKOnly, "Information")

                    'Load Deliveries
                    frm_main.LoadFrm(New frm_warehouse_deliveries)

                Else
                    cmd.Parameters.AddWithValue("@status", "Partial")
                    cmd.Parameters.AddWithValue("@date_completed", "")
                    cmd.ExecuteNonQuery()
                    MsgBox("Successfull!", vbInformation + vbOKOnly, "Information")

                    'Refresh Current
                    Dim frm = New frm_warehouse_delivery_receive
                    frm_warehouse_deliveries.LoadFrm(frm)
                    Load_Orders(purchaseID)

                End If
                cbb_receipt.SelectedIndex = -1
                txt_ref.Text = String.Empty
                txt_amount.Text = String.Empty
                txt_count_by.Text = String.Empty
                txt_discount.Text = String.Empty
                txt_return_credit.Text = String.Empty
                cbb_discount.SelectedIndex = -1
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            Finally
                conn.Close()
            End Try

        End If

    End Sub




    '--- CONTROLS AND EVENTS ---

    'btn_apply
    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click

        'Validate Receipt Info
        If Not (cbb_receipt.SelectedIndex = -1 Or
            String.IsNullOrWhiteSpace(txt_ref.Text) Or
            String.IsNullOrWhiteSpace(txt_amount.Text) Or
            String.IsNullOrWhiteSpace(txt_count_by.Text)) Then

            'Number Formatting
            Try
                Dim a = CDec(txt_amount.Text)
                Dim b = CDec(txt_discount.Text)
                Dim c = CDec(txt_return_credit.Text)
            Catch ex As Exception
                MsgBox("Incorrect Number! Check all fields.", vbCritical, "Number Format Exception")
                Exit Sub
            End Try

            Dim result As Boolean = False
            Using conn
                conn.Open()
                Using cmd = New MySqlCommand("SELECT * FROM ims_purchase WHERE purchase_id=@id", conn)
                    cmd.Parameters.AddWithValue("@id", CInt(txt_poid.Text.Replace("PO", "")))
                    Dim rdr = cmd.ExecuteReader()
                    rdr.Read()
                    result = CBool(rdr("is_payment_first"))
                End Using
            End Using
            If Not result Then
                not_payment_first()
            Else
                payment_first()
            End If

        Else
            MsgBox("Can't saved! No receipt info detected.", vbCritical, "Error")
        End If

    End Sub

    'btn_mark
    Private Sub btn_mark_Click(sender As Object, e As EventArgs) Handles btn_mark.Click

        Dim ans = MsgBox("Mark as 'Completed'? It cannot be undone.", vbQuestion + vbYesNo, "Mark Completed")
        If ans = vbYes Then

            Try

                Dim id As Integer = txt_poid.Text.Replace("PO", "")

                conn.Open()
                Dim cmd = New MySqlCommand("UPDATE ims_purchase SET status='Completed', date_completed=@date_completed WHERE purchase_id=" & id, conn)
                cmd.Parameters.AddWithValue("@date_completed", Date.Now)
                cmd.ExecuteNonQuery()

                MsgBox("Success! Transaction has been completed.", vbInformation, "Transaction Complete")
                frm_main.LoadFrm(New frm_warehouse_deliveries)

            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            Finally
                conn.Close()
            End Try

        End If

    End Sub




    '--- FUNCTIONS ----

    'LOAD THE ORDERS 
    Public Sub Load_Orders(poid As Integer)

        If conn.State = ConnectionState.Open Then conn.Close()

        Try
            conn.Open()
            Dim cmd = New MySqlCommand("SELECT orders, ims_purchase.supplier as supid, ims_suppliers.supplier, (SELECT store_name FROM ims_stores WHERE store_id=deliver_to) as deliver_to, 
                                        is_withholding_tax_applied, withholding_tax_amount, withholding_tax_percentage, ims_purchase.status, qty_received, is_payment_first, ims_delivery_receipts.receipt_type FROM `ims_purchase`
                                        LEFT JOIN ims_delivery_receipts ON ims_delivery_receipts.receipt_ref=CONCAT('PO',LPAD(ims_purchase.purchase_id, 5, '0'))                        
                                        LEFT JOIN ims_suppliers ON ims_purchase.supplier=ims_suppliers.id WHERE ims_purchase.purchase_id='" & poid & "'", conn)
            Dim rdr As MySqlDataReader = cmd.ExecuteReader

            While rdr.Read
                If rdr("is_payment_first") = True Then
                    cbb_receipt.Text = rdr("receipt_type")
                    txt_ref.Text = String.Concat("PO", poid.ToString().PadLeft(5, "0"c))
                    txt_ref.Enabled = False
                End If
                cbb_supplier.Text = rdr("supplier")
                cbb_deliver.Text = rdr("deliver_to")
                txt_supid.Text = rdr("supid")
                set_PurchaseOrder_DataTable(rdr("orders"), rdr("status"), rdr("qty_received"))
                is_withholding_tax_applied.Checked = rdr("is_withholding_tax_applied")
                withholding_tax_amount.Text = rdr("withholding_tax_amount")
                withholding_tax_percentage.Text = rdr("withholding_tax_percentage")
            End While

            grid_order.ClearSelection()
            ColorIndicator()

            txt_poid.Text = "PO" & poid.ToString.PadLeft(5, "0"c)
            lbl_head.Text = txt_poid.Text & " - " & cbb_supplier.Text

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            conn.Close()
        End Try
    End Sub

    'Set Units to Grid
    Sub set_PurchaseOrder_DataTable(units As String, status As String, received As String)
        Dim no = 0
        Try
            Dim comma(), equal() As String
            Dim piece As String
            Dim i As Integer
            Dim colonseparator As New Regex("\b;\b")
            Dim equalseparator As New Regex("\b=\b")

            Dim dataTable = New DataTable()
            dataTable.Columns.Add("col_pid")
            dataTable.Columns.Add("col_qty")
            dataTable.Columns.Add("col_model")
            dataTable.Columns.Add("col_description")
            dataTable.Columns.Add("col_total_received")
            dataTable.Columns.Add("col_qty_received")
            dataTable.Columns.Add("col_remaining")
            dataTable.Columns.Add("col_unit_price")

            If Not String.IsNullOrEmpty(units) Then

                comma = colonseparator.Split(units)
                Dim qty_received = received.Split(";")

                For i = 0 To comma.Length - 1
                    piece = comma(i).Trim
                    equal = piece.Split("=")

                    If status.Equals("Sent") Then
                        no += 1
                        dataTable.Rows.Add(equal(0), equal(1), equal(2), equal(4), 0, 0, equal(1), equal(5))
                    ElseIf status.Equals("Partial") Then
                        no += 1
                        dataTable.Rows.Add(equal(0), equal(1), equal(2), equal(4), qty_received(i), 0, equal(1) - qty_received(i), equal(5))
                    End If

                Next

                grid_order.DataSource = dataTable

            End If
        Catch ex As Exception
            MsgBox("Error in line " & no, vbCritical, "Error")
        End Try


    End Sub

    'Color Indicator
    Private Sub ColorIndicator()

        For Each row As DataGridViewRow In grid_order.Rows
            If row.Cells(6).Value = 0 Then
                row.Cells(6).Style.BackColor = Color.FromArgb(224, 224, 224)
                row.Cells(6).Style.ForeColor = Color.Black

                row.Cells(5).Style.BackColor = Color.FromArgb(224, 224, 224)
                row.Cells(5).Style.ForeColor = Color.Black

                row.Cells(5).ReadOnly = True
                row.Cells(6).ReadOnly = True
            Else
                row.Cells(6).Style.BackColor = Color.IndianRed
                row.Cells(6).Style.ForeColor = Color.White
            End If

        Next

    End Sub

    'Restriction on Cell Edit
    Private Sub grid_order_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles grid_order.CellEndEdit

        If Not IsNumeric(grid_order.CurrentCell.Value) Then
            grid_order.CurrentCell.Value = 0
            MsgBox("Number are only allowed!", vbCritical, "Forbidden")
            Exit Sub
        End If

        If CInt(grid_order.CurrentCell.Value) > CInt(grid_order.CurrentRow.Cells(6).Value) Then
            grid_order.CurrentCell.Value = 0
            MsgBox("Value is greater than of the remaining.", vbCritical, "Forbidden")
        ElseIf grid_order.CurrentCell.Value < 0 Then
            grid_order.CurrentCell.Value = 0
            MsgBox("Value is less than of the Zero.", vbCritical, "Forbidden")
        End If
    End Sub

    'btn_print | Print Receiving List
    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click

        Try
            Dim report = New doc_delivery_list()
            Dim printTool = New ReportPrintTool(report)
            Dim table = New PrintData

            Dim deliver_to = "", supplier = "", orders = "", received = ""

            conn.Open()
            Dim cmd = New MySqlCommand("SELECT orders, ims_suppliers.supplier, (SELECT store_name FROM ims_stores WHERE store_id=deliver_to) as deliver_to, qty_received FROM `ims_purchase`
                                        LEFT JOIN ims_suppliers ON ims_purchase.supplier=ims_suppliers.id
                                        WHERE purchase_id='" & CInt(txt_poid.Text.Replace("PO", "")) & "'", conn)
            Using rdr As MySqlDataReader = cmd.ExecuteReader
                While rdr.Read
                    supplier = rdr("supplier")
                    deliver_to = rdr("deliver_to")
                    orders = rdr("orders")
                    received = rdr("qty_received")
                End While
            End Using

            'Decode Order String to Table
            Dim comma(), equal() As String
            Dim piece As String
            Dim i As Integer
            Dim colonseparator As New Regex("\b;\b")
            Dim equalseparator As New Regex("\b=\b")
            Dim store = String.Concat("ims_", deliver_to.ToLower().Replace(" ", "_"))

            If Not String.IsNullOrEmpty(orders) Then

                comma = colonseparator.Split(orders)
                Dim qty_received = received.Split(";")

                For i = 0 To comma.Length - 1
                    piece = comma(i).Trim
                    equal = piece.Split("=")

                    Using get_loc_cmd = New MySqlCommand("SELECT location FROM " & store & " WHERE pid=@pid", conn)
                        get_loc_cmd.Parameters.AddWithValue("@pid", equal(0))
                        table.delivery_list.Rows.Add(String.Empty, equal(2), equal(3), equal(4), get_loc_cmd.ExecuteScalar())
                    End Using

                Next

                table.delivery_list.DefaultView.Sort = "supmodel ASC"

            End If

            report.Parameters("pid").Value = txt_poid.Text
            report.Parameters("deliver_to").Value = deliver_to
            report.Parameters("supplier").Value = supplier

            report.DataSource = table
            report.ShowRibbonPreviewDialog()

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            conn.Close()
        End Try

    End Sub

    'txt_amount | Allow Numbers Only
    Private Sub txt_amount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_amount.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".") And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    'txt_discount | Allow Numbers Only
    Private Sub txt_discount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_discount.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".") And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    'txt_return_credit | Allow Numbers Only
    Private Sub txt_return_credit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_return_credit.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".") And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    'Grid Order Sorted
    Private Sub grid_order_Sorted(sender As Object, e As EventArgs) Handles grid_order.Sorted
        ColorIndicator()
    End Sub

    'Search
    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        Dim dataSource = DirectCast(grid_order.DataSource, DataTable)
        Dim dataViews As DataView = New DataView(dataSource)
        dataSource.DefaultView.RowFilter = String.Concat(New String() {"col_model LIKE '%", txt_search.Text.Trim(), "%' OR col_description LIKE '%", txt_search.Text.Trim(), "%'"})
        grid_order.DataSource = dataSource
        ColorIndicator()
    End Sub

End Class