Imports MySql.Data.MySqlClient

Public Class frm_warehouse_delivery_logs

    ReadOnly conn As New MySqlConnection(str)


    '--- ONLOAD ----
    Private Sub frm_delivery_logs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dt_start.Value = Date.Today.AddDays(-7)
        dt_end.Value = Date.Now
        LoadDelivered(dt_start.Value, dt_end.Value)
    End Sub




    '---- FUNCTIONS ----

    'Load Delivery Logs
    Private Sub LoadDelivered(startDate As Date, endDate As Date)

        Dim query = "SELECT ims_inventory.winmodel, ims_inventory.description, qty, ims_deliveries.cost, date_received, CONCAT('PO', LPAD(ims_deliveries.purchase_id,5,0)) AS poid,
                    (SELECT supplier FROM ims_suppliers WHERE id=ims_purchase.supplier) AS supplier, ims_users.first_name, ims_stores.store_name FROM `ims_deliveries`
                    INNER JOIN ims_inventory ON ims_inventory.pid=ims_deliveries.item
                    INNER JOIN ims_users ON ims_users.usr_id=ims_deliveries.receiver
                    INNER JOIN ims_stores ON ims_stores.store_id=ims_deliveries.store_id
                    INNER JOIN ims_purchase ON ims_purchase.purchase_id=ims_deliveries.purchase_id
                    WHERE date_received BETWEEN CAST(@startDate AS DATE) AND CAST(@endDate AS DATE) 
                    ORDER BY date_received DESC"
        Try
            conn.Open()
            Dim cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@startDate", startDate.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("@endDate", endDate.AddHours(23).AddMinutes(59).AddSeconds(59).ToString("yyyy-MM-dd HH:mm:ss"))
            cmd.ExecuteNonQuery()

            Dim dt = New DataTable
            Dim da = New MySqlDataAdapter(cmd)
            da.Fill(dt)

            grid_delivered.DataSource = dt
            DeliveryView.ClearSelection()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btn_view_Click(sender As Object, e As EventArgs) Handles btn_view.Click
        LoadDelivered(dt_start.Value, dt_end.Value)
    End Sub

    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click
        grid_delivered.ShowRibbonPrintPreview()
    End Sub
End Class