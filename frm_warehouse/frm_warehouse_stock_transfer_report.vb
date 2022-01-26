Imports MySql.Data.MySqlClient

Public Class frm_warehouse_stock_transfer_report

    ReadOnly conn As New MySqlConnection(str)


    Private Sub btn_submit_Click(sender As Object, e As EventArgs) Handles btn_submit.Click

        'Validation
        If String.IsNullOrWhiteSpace(txt_report_notes.Text) Then
            MsgBox("Oops! Incident report MUST have value.", vbCritical, "Required")
            Exit Sub
        End If

        Try
            Using conn
                conn.Open()
                Dim cmd = New MySqlCommand("UPDATE ims_transferred_stocks SET report_notes=@notes WHERE id=@id", conn)
                cmd.Parameters.AddWithValue("@notes", txt_report_notes.Text.Trim)
                cmd.Parameters.AddWithValue("@id", CInt(txt_stock_transfer_id.Text.Replace("ST", "")))
                cmd.ExecuteNonQuery()

                MsgBox("Incident Report has been submitted!", vbInformation, "Information")
                Me.Close()
                frm_main.LoadFrm(New frm_warehouse_stock_transfer)
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            conn.Close()
        End Try

    End Sub

End Class