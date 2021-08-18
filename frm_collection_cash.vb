Imports MySql.Data.MySqlClient

Public Class frm_collection_cash

    ReadOnly conn As New MySqlConnection(str)

    '--- ONLOAD ----
    Private Sub frm_accounting_update_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_ref.Select()
    End Sub





    '--- FUNCTIONS ----

    'Load Data
    Public Sub LoadData(orderid As Integer, customer As String, amountdue As String)
        lbl_orderid.Text = orderid
        lbl_customer.Text = customer
        lbl_amount_due.Text = FormatCurrency(amountdue)

    End Sub





    '--- CONTROLS ----

    'Radio (CASH)
    Private Sub rb_cash_CheckedChanged(sender As Object, e As EventArgs) Handles rb_cash.CheckedChanged

        If rb_cash.Checked Then
            cbb_bank_option.Enabled = False
            txt_ref.Enabled = False
        ElseIf rb_bank.Checked Then
            cbb_bank_option.Enabled = True
            txt_ref.Enabled = True
        End If

    End Sub

    'Radio (BANK)
    Private Sub rb_bank_CheckedChanged(sender As Object, e As EventArgs) Handles rb_bank.CheckedChanged

        If rb_cash.Checked Then
            cbb_bank_option.Enabled = False
            txt_ref.Enabled = False
        ElseIf rb_bank.Checked Then
            cbb_bank_option.Enabled = True
            txt_ref.Enabled = True
        End If

    End Sub

    'btn_paid
    Private Sub btn_paid_Click(sender As Object, e As EventArgs) Handles btn_paid.Click

        If rb_bank.Checked Then
            If cbb_bank_option.SelectedIndex = -1 Then
                MsgBox("Bank option is required! Choose one to continue.", vbCritical, "Reference Not Found")
                Exit Sub
            End If
            If String.IsNullOrEmpty(txt_ref.Text) Then
                MsgBox("Reference field is required to continue!", vbCritical, "Reference Not Found")
                Exit Sub
            End If
        End If

        Dim ans = MsgBox("Mark it as PAID?" & vbCrLf & "Press 'Yes' to Continue.", vbQuestion + vbYesNo, "Confirmation")

        If ans = vbYes Then
            Dim reference = txt_ref.Text.Trim
            Dim payment_option = ""

            If rb_cash.Checked Then
                payment_option = "CASH"
            ElseIf rb_bank.Checked Then
                payment_option = cbb_bank_option.Text
            End If

            Try
                conn.Open()
                Dim cmd = New MySqlCommand("UPDATE ims_orders SET payment_option=@option, payment_details=@details, paid_amount=IFNULL(paid_amount,0)+@paid_amount,
                                payment_status='PAID',
                                status=IF((status='Released' AND shipping_method='Deliver'), 'Cleared', status) 
                                WHERE order_id=" & lbl_orderid.Text, conn)
                cmd.Parameters.AddWithValue("@option", payment_option)
                cmd.Parameters.AddWithValue("@paid_amount", CDec(lbl_amount_due.Text))
                cmd.Parameters.AddWithValue("@details", reference)
                cmd.ExecuteNonQuery()

                MsgBox("Successful Transaction!", vbInformation, "Information")

                frm_main.LoadFrm(New frm_collection_payments)
                Me.Close()

                'payment_status = If(IFNULL(paid_amount, 0) = @paid_amount, 'PAID',
                '                               If(IFNULL(paid_amount, 0) > @paid_amount, 'OVERPAID',
                '                               If(IFNULL(paid_amount, 0) < @paid_amount, 'PARTIAL',''))),
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            Finally
                conn.Close()
            End Try

        End If

    End Sub

    'btn_hold
    Private Sub btn_hold_Click(sender As Object, e As EventArgs) Handles btn_hold.Click
        frm_collection_hold.LoadData(lbl_orderid.Text)
    End Sub


End Class