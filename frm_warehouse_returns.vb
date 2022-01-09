Imports MySql.Data.MySqlClient

Public Class frm_warehouse_returns


    Private Sub frm_warehouse_returns_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadReturns()
    End Sub



    '--- FUNCTIONS ----

    'Load Returns
    Private Sub LoadReturns()
        Try
            Using conn = New MySqlConnection(str)
                conn.Open()
                Using cmd = New MySqlCommand("SELECT id, ims_inventory.pid, qty, ims_inventory.winmodel, ims_inventory.description, ims_stores.store_name, concat('SR',LPAD(ims_sales_approved_returns.sr_id,5,0)) srid FROM ims_sales_approved_returns
                                        INNER JOIN ims_stores ON ims_stores.store_id=ims_sales_approved_returns.store_id
                                        INNER JOIN ims_inventory ON ims_inventory.pid=ims_sales_approved_returns.pid
                                        WHERE ims_sales_approved_returns.status='Pending'", conn)
                    Dim dt = New DataTable
                    dt.Columns.Add("id", GetType(String))
                    dt.Columns.Add("pid", GetType(String))
                    dt.Columns.Add("qty", GetType(Integer))
                    dt.Columns.Add("winmodel", GetType(String))
                    dt.Columns.Add("description", GetType(String))
                    dt.Columns.Add("store_name", GetType(String))
                    dt.Columns.Add("srid", GetType(String))

                    Using rdr = cmd.ExecuteReader
                        While rdr.Read
                            dt.Rows.Add(rdr("id"), rdr("pid"), rdr("qty"), rdr("winmodel"), rdr("description"), rdr("store_name"), rdr("srid"))
                        End While
                    End Using

                    grid_returns.DataSource = dt

                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub btn_update_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btn_update.ButtonClick
        Dim frm = New frm_warehouse_returns_dialog
        frm.lbl_srid.Text = grid_returns_view.GetFocusedRowCellValue(col_srid)
        frm.lbl_winmodel.Text = grid_returns_view.GetFocusedRowCellValue(col_winmodel)
        frm.lbl_qty.Text = grid_returns_view.GetFocusedRowCellValue(col_qty)
        frm.hidden_id.Text = grid_returns_view.GetFocusedRowCellValue(col_id)
        frm.hidden_store.Text = grid_returns_view.GetFocusedRowCellValue(col_store)
        frm.hidden_pid.Text = grid_returns_view.GetFocusedRowCellValue(col_pid)
        frm.ShowDialog()
        LoadReturns()
    End Sub
End Class