Imports MySql.Data.MySqlClient
Imports Newtonsoft.Json

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
                Using cmd = New MySqlCommand("SELECT concat('SR',LPAD(sales_return_id,5,0)) srid, units, ims_stores.store_name FROM ims_sales_returns
                                        INNER JOIN ims_stores ON ims_stores.store_id=ims_sales_returns.store_id
                                        WHERE status='Approved' AND is_deleted=0", conn)
                    Dim dt = New DataTable
                    dt.Columns.Add("pid", GetType(String))
                    dt.Columns.Add("qty", GetType(Integer))
                    dt.Columns.Add("winmodel", GetType(String))
                    dt.Columns.Add("description", GetType(String))
                    dt.Columns.Add("store_name", GetType(String))

                    Using rdr = cmd.ExecuteReader
                        While rdr.Read
                            Dim itemsObject = JsonConvert.DeserializeObject(Of List(Of SalesReturnClass))(rdr("units"))
                            For Each item In itemsObject
                                dt.Rows.Add(item.pid, item.qty, item.model, item.description, rdr("store_name"), rdr("srid"))
                            Next
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
        frm.lbl_srid.Text =
        frm.ShowDialog()
    End Sub
End Class