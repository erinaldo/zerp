Imports MySql.Data.MySqlClient

Public Class frm_warehouse_returns_list


    Private Sub frm_warehouse_returns_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_data()
    End Sub



    '--- FUNCTIONS ----

    'Load Data
    Private Sub load_data()
        Try
            Using conn = New MySqlConnection(str)
                conn.Open()
                Using cmd = New MySqlCommand("SELECT id, tbl.pid, qty, inv.winmodel, inv.description
                                       FROM ims_sales_approved_returns tbl
                                       INNER JOIN ims_inventory inv ON inv.pid=tbl.pid
                                       WHERE sr_id=@srid", conn)
                    cmd.Parameters.AddWithValue("@srid", CInt(txt_srid.Text.Replace("SR", String.Empty)))

                    Dim dt = New DataTable
                    Dim da = New MySqlDataAdapter(cmd)
                    da.Fill(dt)

                    grid_returns.DataSource = dt

                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub



    '--- CONTROLS ---

    Private Sub btn_received_Click(sender As Object, e As EventArgs) Handles btn_received.Click

        If MsgBox("You are about the receive these items." & vbNewLine & "Press 'YES' to confirm.", vbInformation + vbYesNo, "Confirmation") = vbYes Then

            Try
                Using conn = New MySqlConnection(str)
                    conn.Open()

                    Dim counter = 0
                    For i = 0 To grid_returns_view.RowCount - 1
                        'INSERT/UPDATE TO SOURCE STORE
                        Dim destination_store = "ims_" & txt_warehouse.Text.ToLower.Replace(" ", "_")
                        Using cmd_add_to_qty = New MySqlCommand("INSERT INTO " & destination_store & " (`pid`, `qty`) VALUES (@pid,@qty) ON DUPLICATE KEY UPDATE qty=qty+@qty", conn)
                            cmd_add_to_qty.Parameters.AddWithValue("@pid", grid_returns_view.GetRowCellValue(i, col_pid))
                            cmd_add_to_qty.Parameters.AddWithValue("@qty", grid_returns_view.GetRowCellValue(i, col_qty))

                            'Update sales return item
                            If cmd_add_to_qty.ExecuteNonQuery() > 0 Then
                                Using cmd = New MySqlCommand("UPDATE ims_sales_approved_returns SET status='Received', received_by=@user WHERE id=@id", conn)
                                    cmd.Parameters.AddWithValue("@user", frm_main.user_id.Text)
                                    cmd.Parameters.AddWithValue("@id", grid_returns_view.GetFocusedRowCellValue(col_id))
                                    cmd.ExecuteNonQuery()
                                End Using
                            End If

                        End Using
                    Next

                    'Update Sales Return ID
                    Using cmd_update_sr = New MySqlCommand("UPDATE ims_sales_returns SET receiving_status='Received' WHERE sales_return_id=@srid", conn)
                        cmd_update_sr.Parameters.AddWithValue("@srid", CInt(txt_srid.Text.Replace("SR", String.Empty)))
                        If cmd_update_sr.ExecuteNonQuery > 0 Then
                            MsgBox("Submitted!" & vbNewLine & "Handover the stock to " & txt_warehouse.Text & ".", vbInformation, "Information")
                            Me.Close()

                            Dim frm = New frm_warehouse_receivingManagement
                            frm_main.LoadFrm(frm)
                            frm.tabcontrol.SelectedTab = frm.tab_sales_returns
                            frm.load_sales_returns()
                        End If
                    End Using

                End Using

            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try
        End If

    End Sub

End Class