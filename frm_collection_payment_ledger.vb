Imports MySql.Data.MySqlClient

Public Class frm_collection_payment_ledger

    ReadOnly conn As New MySqlConnection(str)


    Private Sub frm_collection_order_history_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPaymentLogs()
    End Sub


    Public Sub LoadPaymentLogs()

        Try
            conn.Open()
            Dim query = "SELECT *  FROM ims_payment_logs INNER JOIN ims_customers ON ims_customers.customer_id=ims_payment_logs.customer_id ORDER BY payment_id DESC"
            Dim cmd = New MySqlCommand(query, conn)
            cmd.ExecuteNonQuery()

            Dim dt = New DataTable
            Dim da = New MySqlDataAdapter(cmd)
            da.Fill(dt)

            grid_cash.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            conn.Close()
        End Try

    End Sub

End Class