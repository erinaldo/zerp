Imports MySql.Data.MySqlClient

Public Class frm_collection_epayment


    ReadOnly conn As New MySqlConnection(str)


    '--- ONLOAD ---
    Private Sub frm_collection_epayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    '--- FUNCTIONS ----

    'Load Data
    Public Sub LoadData(orderid As Integer, customer As String, amountdue As String)
        lbl_orderid.Text = orderid
        lbl_customer.Text = customer
        lbl_amount_due.Text = FormatCurrency(amountdue)
        lbl_balance.Text = FormatCurrency(amountdue)
        txt_amount_tendered.Select()
    End Sub




    '--- CONTROLS ----

    'btn_paid
    Private Sub btn_paid_Click(sender As Object, e As EventArgs) Handles btn_paid.Click

        'Validation
        If String.IsNullOrWhiteSpace(txt_amount_tendered.Text) Then
            MsgBox("Enter amount tendered to proceed!", vbCritical, "Invalid Amount")
            Exit Sub
        End If

        If cbb_bank_option.SelectedIndex = -1 Then
            MsgBox("E-Payment type is required!" & vbCrLf & " Choose one to continue.", vbCritical, "Reference Not Found")
            Exit Sub
        End If

        If String.IsNullOrEmpty(txt_ref.Text) Then
            MsgBox("Reference field is required to continue!", vbCritical, "Reference Not Found")
            Exit Sub
        End If

        'Confirmation
        Dim ans = MsgBox("Press 'Yes' to Continue.", vbQuestion + vbYesNo, "Confirmation")
        If Not ans = vbYes Then Exit Sub

        Dim reference = txt_ref.Text.Trim
        Dim payment_option = cbb_bank_option.Text

        Try
            Using conn
                conn.Open()
                Dim cmd = New MySqlCommand("UPDATE ims_orders SET payment_option=@option, payment_details=@details,
                                payment_status = If(amount_due = IFNULL(paid_amount, 0) + @paid_amount, 'PAID',
                                                 If(amount_due < IFNULL(paid_amount, 0) + @paid_amount, 'OVERPAID',
                                                 If(amount_due > IFNULL(paid_amount, 0) + @paid_amount, 'PARTIAL',''))), 
                                paid_amount=IFNULL(paid_amount,0)+@paid_amount,
                                status=IF((status='Released' AND shipping_method='Deliver'), 'Completed', status) 
                                WHERE order_id=@order_id; 
                                INSERT INTO ims_orders_payment (order_id, amount_tendered, payment_option, reference, created_at) 
                                VALUES (@order_id, @paid_amount, @option, @details, CURRENT_TIMESTAMP)", conn)
                cmd.Parameters.AddWithValue("@order_id", lbl_orderid.Text)
                cmd.Parameters.AddWithValue("@option", payment_option)
                cmd.Parameters.AddWithValue("@paid_amount", CDec(txt_amount_tendered.Text))
                cmd.Parameters.AddWithValue("@details", reference)
                cmd.ExecuteNonQuery()

                MsgBox("Successful Transaction!", vbInformation, "Information")

                frm_main.LoadFrm(New frm_collection_payments)
                Me.Close()
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    'btn_attachments
    Private Sub btn_btn_attachments_Click(sender As Object, e As EventArgs) Handles btn_attachments.Click
        Dim frm = New frm_sales_order_epayment_proofs
        frm.lbl_order_id.Text = lbl_orderid.Text.Replace("Order #", "SO")
        frm.Size = New Point(513, 319)
        frm.btn_add.Visible = False
        frm.btn_save.Visible = False
        frm.LoadData()
        frm.Show()
    End Sub

    'txt_amount_tendered.KeyPress
    Private Sub txt_amount_tendered_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_amount_tendered.KeyPress
        'Only Numbers, backspace, decimal
        If (e.KeyChar.ToString = ".") And (txt_amount_tendered.Text.Contains(e.KeyChar.ToString)) Then
            e.Handled = True
            Exit Sub
        End If

        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Or Char.IsControl(e.KeyChar))
    End Sub

    'txt_amount_tendered.KeyUp
    Private Sub txt_amount_tendered_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_amount_tendered.KeyUp
        If Not String.IsNullOrWhiteSpace(txt_amount_tendered.Text) Then
            Dim amount_tendered As Decimal = txt_amount_tendered.Text.Trim
            Dim amount_to_pay As Decimal = lbl_amount_due.Text.Trim
            lbl_balance.Text = FormatCurrency(amount_to_pay - amount_tendered)
        Else
            lbl_balance.Text = lbl_amount_due.Text
        End If
    End Sub

    'btn_epayment
    Private Sub btn_epayment_Click(sender As Object, e As EventArgs)
        Dim frm = New frm_sales_order_epayment_proofs
        frm.lbl_order_id.Text = lbl_orderid.Text.Replace("Order #", "SO")
        frm.Size = New Point(513, 319)
        frm.btn_add.Visible = False
        frm.btn_save.Visible = False
        frm.LoadData()
        frm.Show()
    End Sub

End Class