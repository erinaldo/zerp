Imports MySql.Data.MySqlClient

Public Class frm_collection_order_history

    ReadOnly conn As New MySqlConnection(str)


    Private Sub frm_collection_order_history_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_orders()
    End Sub


    Public Sub load_orders()

        Try
            conn.Open()
            Dim query = "SELECT status, order_id, date_ordered, ims_customers.first_name as customer, ims_users.first_name as agent, shipping_method, amount_due, payment_type, IFNULL(payment_status, 'UNPAID') as payment_status FROM ims_orders
                        INNER JOIN ims_customers ON ims_orders.customer=ims_customers.customer_id
                        INNER JOIN ims_users ON ims_orders.agent=ims_users.usr_id
                        WHERE payment_status = 'PAID' AND status='Completed' AND ims_orders.deleted='0'"
            Dim cmd = New MySqlCommand(query, conn)
            cmd.ExecuteNonQuery()

            Dim dt = New DataTable
            Dim da = New MySqlDataAdapter(cmd)
            da.Fill(dt)

            grid_cash.DataSource = dt

            Compute()

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            conn.Close()
        End Try

    End Sub

    Private Sub Compute()

        Dim total_amount As Decimal = 0.00

        For i = 0 To grid_cash_view.RowCount - 1
            total_amount += CDec(grid_cash_view.GetRowCellValue(i, col_amount_due))
        Next

        txt_total.Text = FormatCurrency(total_amount)

    End Sub

    Private Sub grid_cash_view_ColumnFilterChanged(sender As Object, e As EventArgs) Handles grid_cash_view.ColumnFilterChanged
        Compute()
    End Sub
End Class