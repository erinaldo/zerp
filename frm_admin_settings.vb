Imports MySql.Data.MySqlClient

Public Class frm_admin_settings

    ReadOnly conn As New MySqlConnection(str)

    '--- ONLOAD ----
    Private Sub frm_settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub





    '--- FUNCTIONS ----
    Private Sub load_store_info()

        Try
            conn.Open()
            Dim cmd = New MySqlCommand("SELECT value FROM ims_settings WHERE name='store_info'", conn)
            Dim result = cmd.ExecuteScalar

            txt_storeinfo.Text = result

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            conn.Close()
        End Try

    End Sub



    'btn_save
    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click

        Try
            conn.Open()
            Dim cmd = New MySqlCommand("UPDATE ims_settings SET value=@info WHERE name='store_info'", conn)
            cmd.Parameters.AddWithValue("@info", txt_storeinfo.Text.Trim)
            cmd.ExecuteNonQuery()

            MsgBox("Updated Successfullly!", vbInformation, "Success")

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            conn.Close()
        End Try

    End Sub

    Private Sub nav_documents_SelectedPageChanged(sender As Object, e As DevExpress.XtraBars.Navigation.SelectedPageChangedEventArgs) Handles nav_documents.SelectedPageChanged
        If e.Page.Caption = nav_documents.Text Then
            load_store_info()
        End If
    End Sub
End Class