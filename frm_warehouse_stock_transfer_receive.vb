Imports MySql.Data.MySqlClient

Public Class frm_warehouse_stock_transfer_receive

    ReadOnly conn As New MySqlConnection(str)

    '--- FUNCTIONS ---

    Private Function transfer_func()

        Dim to_receive_count = 0
        Dim received_count = 0
        Dim source_store = "ims_" & cbb_source.Text.Trim.ToLower.Replace(" ", "_")
        Dim destination_store = "ims_" & cbb_destination.Text.Trim.ToLower.Replace(" ", "_")

        Using conn
            Try
                conn.Open()

                'Check Stocks Availabilty in ON_HOLD
                If check_stocks(source_store, grid_receiver) Then Return "Failed"

                'Update Source table and Set to destination table
                Dim cmd_deduct = New MySqlCommand("UPDATE " & source_store & " SET on_hold=on_hold-@qty WHERE pid=@pid and on_hold>=@qty", conn)
                cmd_deduct.Parameters.AddWithValue("@pid", Nothing)
                cmd_deduct.Parameters.AddWithValue("@qty", Nothing)
                cmd_deduct.Prepare()

                For i = 0 To grid_receiver.Rows.Count - 1
                    to_receive_count += CInt(grid_receiver.Rows(i).Cells(3).Value)
                    received_count += CInt(grid_receiver.Rows(i).Cells(4).Value)
                Next

                If Not to_receive_count = received_count Then
                    Dim ans = MsgBox("'To Receive' IS NOT EQUAL to 'Received Units'" & vbCrLf & vbCrLf & "Continue anyway?", vbYesNo + vbExclamation, "Confirmation")
                    If Not ans = vbYes Then Return "Failed"
                End If

                For i = 0 To grid_receiver.Rows.Count - 1

                    cmd_deduct.Parameters(0).Value = grid_receiver.Rows(i).Cells(0).Value
                    cmd_deduct.Parameters(1).Value = grid_receiver.Rows(i).Cells(4).Value
                    Dim inserted = cmd_deduct.ExecuteNonQuery

                    If inserted > 0 Then
                        Dim cmd_add = New MySqlCommand("INSERT INTO " & destination_store & " (`pid`, `qty`) VALUES (@pid,@qty) ON DUPLICATE KEY UPDATE qty=qty+@qty", conn)
                        cmd_add.Parameters.AddWithValue("@pid", grid_receiver.Rows(i).Cells(0).Value)
                        cmd_add.Parameters.AddWithValue("@qty", grid_receiver.Rows(i).Cells(4).Value)
                        cmd_add.ExecuteNonQuery()
                    End If
                Next

            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            Finally
                conn.Close()
            End Try

            If to_receive_count = received_count Then Return "Complete"
            If Not to_receive_count = received_count Then Return "Incomplete"

        End Using

        Return "Failed"

    End Function

    'Check Stock's Availability
    Private Function check_stocks(source_store As String, grid As DataGridView)

        Dim low_stocks_level = ""
        Dim cmd_check = New MySqlCommand("SELECT IFNULL(on_hold, 0) FROM " & source_store & " WHERE pid=@pid", conn)
        cmd_check.Parameters.AddWithValue("@pid", Nothing)
        cmd_check.Prepare()

        For i = 0 To grid.Rows.Count - 1

            cmd_check.Parameters(0).Value = grid.Rows(i).Cells(0).Value
            Dim qty_result As Integer = cmd_check.ExecuteScalar

            If CInt(grid.Rows(i).Cells(4).Value) > qty_result Then
                If i = grid.Rows.Count - 1 Then
                    low_stocks_level += grid.Rows(i).Cells(0).Value
                Else
                    low_stocks_level += grid.Rows(i).Cells(0).Value & vbCrLf
                End If
            End If

        Next

        If Not String.IsNullOrEmpty(low_stocks_level) Then
            MsgBox("Couldn't proceed!" & vbCrLf & vbCrLf & "Low On-Hold stock level items:" & vbCrLf & low_stocks_level, vbCritical, "Low Level")
            Return True
        End If

        Return False

    End Function

    'Get SKU & Qty Received
    Private Function get_received_units()

        Dim units = ""
        For i = 0 To grid_receiver.Rows.Count - 1
            If i = grid_receiver.Rows.Count - 1 Then
                units += grid_receiver.Rows(i).Cells(0).Value & "=" & grid_receiver.Rows(i).Cells(4).Value
                Continue For
            End If
            units += grid_receiver.Rows(i).Cells(0).Value & "=" & grid_receiver.Rows(i).Cells(4).Value & ";"
        Next

        Return units

    End Function



    '--- CONTROLS ---

    'btn_save
    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click

        For i = 0 To grid_receiver.Rows.Count - 1
            If String.IsNullOrWhiteSpace(grid_receiver.Rows(i).Cells(4).Value) Then
                MsgBox("Incomplete Records!", vbCritical, "No Quantity")
                Exit Sub
            End If
        Next

        Dim msg As String
        'Start Transfering
        Select Case transfer_func()
            Case "Complete"
                msg = "All units has been transferred! Thank you."
                Dim ans = MsgBox("Press 'YES' to confirm.", vbYesNo + vbInformation, "Confirmation")
                If ans = vbYes Then

                    Try
                        Using conn
                            conn.Open()
                            Dim cmd = New MySqlCommand("UPDATE ims_transferred_stocks SET status='Completed', received_units=@units, received_by=@received_by WHERE id=@id", conn)
                            cmd.Parameters.AddWithValue("@id", CInt(lbl_transfer_id.Text.Remove(0, 2)))
                            cmd.Parameters.AddWithValue("@units", get_received_units())
                            cmd.Parameters.AddWithValue("@received_by", frm_main.user_id.Text)
                            cmd.ExecuteNonQuery()

                            MsgBox(msg, vbInformation, "Information")
                            Me.Close()
                            frm_main.LoadFrm(New frm_warehouse_stock_transfer)
                        End Using

                    Catch ex As Exception
                        MsgBox(ex.Message, vbCritical, "Error")
                    Finally
                        conn.Close()
                    End Try

                End If

            Case "Incomplete"
                msg = "Some units has been transferred!" & vbCrLf & "Please submit report for investigation."
                Dim ans = MsgBox("Press 'YES' to confirm.", vbYesNo + vbInformation, "Confirmation")
                If ans = vbYes Then

                    Try
                        Using conn
                            conn.Open()
                            Dim cmd = New MySqlCommand("UPDATE ims_transferred_stocks SET status='Reported', received_units=@units, received_by=@received_by WHERE id=@id", conn)
                            cmd.Parameters.AddWithValue("@id", CInt(lbl_transfer_id.Text.Remove(0, 2)))
                            cmd.Parameters.AddWithValue("@units", get_received_units())
                            cmd.Parameters.AddWithValue("@received_by", frm_main.user_id.Text)
                            cmd.ExecuteNonQuery()

                            MsgBox(msg, vbInformation, "Information")

                            Dim frm = New frm_warehouse_stock_transfer_report
                            frm.ControlBox = False
                            frm.btn_cancel.Enabled = False
                            frm.txt_stock_transfer_id.Text = lbl_transfer_id.Text
                            frm.ShowDialog()

                            Me.Close()
                            frm_main.LoadFrm(New frm_warehouse_stock_transfer)
                        End Using

                    Catch ex As Exception
                        MsgBox(ex.Message, vbCritical, "Error")
                    Finally
                        conn.Close()
                    End Try

                End If

            Case "Failed" : Exit Sub

        End Select

    End Sub

    'grid_receiver.CellEndEdit
    Private Sub grid_receiver_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles grid_receiver.CellEndEdit

        Dim cell_value = grid_receiver.CurrentCell.Value

        If Not String.IsNullOrWhiteSpace(cell_value) Then
            If Not IsNumeric(cell_value) Then
                MsgBox("Input numbers only!", vbCritical, "Number Format Exception")
                grid_receiver.CurrentCell.Value = ""
            End If

            If cell_value.Contains(".") Then
                MsgBox("Whole numbers only!", vbCritical, "Number Format Exception")
                grid_receiver.CurrentCell.Value = ""
            End If

            If CInt(cell_value) > CInt(grid_receiver.CurrentRow.Cells(3).Value) Or CInt(cell_value) < 0 Then
                MsgBox("Invalid Quantity.", vbCritical, "Invalid")
                grid_receiver.CurrentCell.Value = ""
            End If
        End If

    End Sub

End Class