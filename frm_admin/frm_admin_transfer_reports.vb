Imports MySql.Data.MySqlClient


Public Class frm_admin_transfer_reports

    ReadOnly conn As New MySqlConnection(str)


    '--- FUNCTIONS ----

    'For Receiving
    Private Sub set_data_to_grid(units As String, received_units As String, grid As DataGridView)
        Try
            Using conn
                conn.Open()
                Dim cmd = New MySqlCommand("SELECT pid, winmodel, description FROM ims_inventory WHERE pid=@pid", conn)
                cmd.Parameters.AddWithValue("@pid", Nothing)
                cmd.Prepare()

                Dim units_arr = units.Split(";")
                Dim received_units_arr = received_units.Split(";")

                For i = 0 To units_arr.Length - 1

                    Dim items = units_arr(i).Split("=")
                    Dim received_items = received_units_arr(i).Split("=")

                    cmd.Parameters(0).Value = items(0)
                    Using rdr = cmd.ExecuteReader
                        While rdr.Read
                            grid.Rows.Add(rdr("pid"), rdr("winmodel"), rdr("description"), items(1), received_items(1), CInt(items(1)) - CInt(received_items(1)))
                        End While
                    End Using
                    If grid.Rows(i).Cells(5).Value > 0 Then grid.Rows(i).Cells(5).Style.BackColor = Color.IndianRed
                    If grid.Rows(i).Cells(5).Value > 0 Then grid.Rows(i).Cells(5).Style.ForeColor = Color.White
                Next

            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            conn.Close()
        End Try
    End Sub







    Public Sub load_report(id As Integer)
        Try
            Dim units = "", received_units = ""
            Using conn
                conn.Open()
                Dim cmd = New MySqlCommand("SELECT src.store_name AS src, dest.store_name AS dest, units, received_units, report_notes FROM ims_transferred_stocks
                        INNER JOIN ims_stores AS src ON src.store_id=src_store
                        INNER JOIN ims_stores AS dest ON dest.store_id=receiver_store WHERE id=" & id, conn)

                Using rdr = cmd.ExecuteReader
                    rdr.Read()
                    txt_transfer_id.Text = "ST" & id.ToString.PadLeft(5, "0"c)
                    txt_source.Text = rdr("src")
                    txt_destination.Text = rdr("dest")
                    txt_report.EditValue = rdr("report_notes")
                    units = rdr("units")
                    received_units = rdr("received_units")
                    rb_src.Text += " " & rdr("src")
                    rb_dest.Text += " " & rdr("dest")
                End Using
            End Using

            set_data_to_grid(units, received_units, grid_receiver)

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            conn.Close()
        End Try
    End Sub

    'btn_apply
    Private Sub btn_apply_Click(sender As Object, e As EventArgs) Handles btn_apply.Click
        If rb_src.Checked = False And rb_dest.Checked = False And rb_zero.Checked = False Then
            MsgBox("Select Action to Resolve to continue.", vbCritical, "Required")
            Exit Sub
        End If

        Dim ans = MsgBox("Press 'YES' to continue.", vbYesNo + vbInformation, "Confirmation")
        If Not ans = vbYes Then Exit Sub

        Try
            Using conn
                conn.Open()
                Dim src_store = "ims_" & txt_source.Text.Trim.ToLower.Replace(" ", "_")
                Dim des_store = "ims_" & txt_destination.Text.Trim.ToLower.Replace(" ", "_")

                Dim reconcile_to_src = "UPDATE " & src_store & " SET qty=qty+@qty, on_hold=IFNULL(on_hold, 0)-@qty WHERE pid=@pid"
                Dim reconcile_to_destination = "INSERT INTO " & des_store & " (pid, qty) VALUES (@pid, @qty) ON DUPLICATE KEY UPDATE qty=qty+@qty; UPDATE " & src_store & " SET on_hold=IFNULL(on_hold, 0)-@qty WHERE pid=@pid"
                Dim reconcile_to_none = "UPDATE " & src_store & " SET on_hold=IFNULL(on_hold, 0)-@qty WHERE pid=@pid"
                Dim query = ""

                If rb_src.Checked = True Then query = reconcile_to_src
                If rb_dest.Checked = True Then query = reconcile_to_destination
                If rb_zero.Checked = True Then query = reconcile_to_none

                Using cmd = New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@pid", Nothing)
                    cmd.Parameters.AddWithValue("@qty", Nothing)
                    cmd.Prepare()

                    For i = 0 To grid_receiver.Rows.Count - 1
                        If grid_receiver.Rows(i).Cells(5).Value > 0 Then
                            cmd.Parameters(0).Value = grid_receiver.Rows(i).Cells(0).Value
                            cmd.Parameters(1).Value = grid_receiver.Rows(i).Cells(5).Value
                            cmd.ExecuteNonQuery()
                        End If
                    Next
                End Using

                Using cmd = New MySqlCommand("UPDATE ims_transferred_stocks SET status='Resolved' WHERE id=@id", conn)
                    cmd.Parameters.AddWithValue("@id", CInt(txt_transfer_id.Text.Replace("ST", "")))
                    cmd.ExecuteNonQuery()
                End Using

            End Using

            MsgBox("Successfully Resolve!", vbInformation, "Information")
            frm_main.LoadFrm(New frm_admin_approval)
            Me.Close()

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            conn.Close()
        End Try

    End Sub

End Class