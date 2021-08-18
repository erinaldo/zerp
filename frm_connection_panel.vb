Public Class frm_connection_panel

    '--- ONLOAD ---
    Private Sub frm_connection_panel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_server.Text = My.Settings.server
        txt_database.Text = My.Settings.database
        txt_username.Text = My.Settings.username
        txt_password.Text = My.Settings.password
        txt_port.Text = My.Settings.port

        txt_ftp_server.Text = My.Settings.FTPserver
        txt_ftp_port.Text = My.Settings.FTPport
        txt_ftp_username.Text = My.Settings.FTPusername
        txt_ftp_password.Text = My.Settings.FTPpass

        txt_ftp_userF.Text = My.Settings.UserFolder
        txt_ftp_productF.Text = My.Settings.folder_product
    End Sub

    'btn_save
    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        My.Settings.server = txt_server.Text
        My.Settings.database = txt_database.Text
        My.Settings.username = txt_username.Text
        My.Settings.password = txt_password.Text
        My.Settings.port = txt_port.Text

        My.Settings.FTPserver = txt_ftp_server.Text
        My.Settings.FTPport = txt_ftp_port.Text
        My.Settings.FTPusername = txt_ftp_username.Text
        My.Settings.FTPpass = txt_ftp_password.Text

        My.Settings.UserFolder = txt_ftp_userF.Text
        My.Settings.folder_product = txt_ftp_productF.Text

        My.Settings.Save()
        Application.Restart()
    End Sub

End Class