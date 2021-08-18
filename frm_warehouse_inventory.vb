Imports MySql.Data.MySqlClient

Public Class frm_warehouse_inventory

    ReadOnly conn As New MySqlConnection(str)


    '--- On LOAD ----
    Private Sub frm_stock_inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadInventory()
    End Sub




    '--- FUNCTIONS ----

    'Load Inventory
    Private Sub LoadInventory()

        Dim STORE = "ims_" & frm_main.user_store.Text.Replace(" ", "_").ToLower

        Try
            conn.Open()
            Dim query = "SELECT LPAD(" & STORE & ".pid, 6, '0') as product_id, winmodel, description, " & STORE & ".qty, " & STORE & ".on_hold, " & STORE & ".location FROM `ims_inventory`
                        RIGHT JOIN " & STORE & " ON ims_inventory.pid=" & STORE & ".pid"
            Dim cmd = New MySqlCommand(query, conn)
            cmd.ExecuteNonQuery()

            Dim dt = New DataTable
            Dim da = New MySqlDataAdapter(cmd)
            da.Fill(dt)

            ims_inventory.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub ims_InventoryView_RowUpdated(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles ims_InventoryView.RowUpdated
        Dim rowView As DataRowView = TryCast(e.Row, DataRowView)
        Dim row As DataRow = rowView.Row

        Dim STORE = "ims_" & frm_main.user_store.Text.Replace(" ", "_").ToLower
        Dim location = row("Location").ToString.ToUpper
        Dim pid = CInt(row("Product_ID"))

        Try
            conn.Open()
            Dim query = "UPDATE " & STORE & " SET location=@location WHERE pid=@pid"
            Dim cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@location", location)
            cmd.Parameters.AddWithValue("@pid", pid)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            conn.Close()
        End Try

        ims_InventoryView.SetRowCellValue(e.RowHandle, col_location, location)
        'Dim id = ims_InventoryView.GetFocusedRowCellValue(col_pid)
        'Dim location = ims_InventoryView.GetFocusedRowCellValue(col_location).ToString.ToUpper

    End Sub

    Private Sub ims_InventoryView_EditFormPrepared(sender As Object, e As DevExpress.XtraGrid.Views.Grid.EditFormPreparedEventArgs) Handles ims_InventoryView.EditFormPrepared
        e.BindableControls("product_id").Enabled = False
        e.BindableControls("winmodel").Enabled = False
        e.BindableControls("description").Enabled = False
        e.BindableControls("qty").Enabled = False
    End Sub

    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click
        ims_inventory.ShowRibbonPrintPreview()
    End Sub
End Class