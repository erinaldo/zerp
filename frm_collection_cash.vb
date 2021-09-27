Imports MySql.Data.MySqlClient

Public Class frm_collection_cash

    ReadOnly conn As New MySqlConnection(str)

    '--- ONLOAD ----


    '--- FUNCTIONS ----

    'Load Data
    Public Sub LoadData(orderid As Integer, customer As String, amountdue As String)
        lbl_orderid.Text = orderid
        lbl_customer.Text = customer
        lbl_amount_due.Text = FormatCurrency(amountdue)

    End Sub





    '--- CONTROLS ----

    'btn_paid
    Private Sub btn_paid_Click(sender As Object, e As EventArgs) Handles btn_paid.Click

        Dim ans = MsgBox("Mark it as PAID?" & vbCrLf & "Press 'Yes' to Continue.", vbQuestion + vbYesNo, "Confirmation")

        If ans = vbYes Then

            Try
                conn.Open()
                Dim cmd = New MySqlCommand("UPDATE ims_orders SET payment_option=@option, paid_amount=IFNULL(paid_amount,0)+@paid_amount,
                                payment_status='PAID',
                                status=IF((status='Released' AND shipping_method='Deliver'), 'Cleared', status) 
                                WHERE order_id=" & lbl_orderid.Text, conn)
                cmd.Parameters.AddWithValue("@option", "CASH")
                cmd.Parameters.AddWithValue("@paid_amount", CDec(lbl_amount_due.Text))
                cmd.ExecuteNonQuery()

                'INSERT TO PAYMENT LOGS
                Insert_PaymentLog(conn, Date.Now, lbl_orderid.Text, lbl_customer.Text, lbl_amount_due.Text, lbl_amount_due.Text, 0.00, "CASH", Nothing)

                MsgBox("Successful Transaction!", vbInformation, "Information")

                frm_main.LoadFrm(New frm_collection_payments)
                Me.Close()

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