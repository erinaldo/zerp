Imports MySql.Data.MySqlClient

Public Class frm_login

    ReadOnly conn As New MySqlConnection(str)


    'On Load
    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
        txt_username.Select()
        txt_username.Focus()
    End Sub


    'Close
    Private Sub GunaControlBox1_Click(sender As Object, e As EventArgs) Handles GunaControlBox1.Click
        Application.Exit()
    End Sub


    'Login
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click

        Err.Clear()
        err_lbl.Visible = False

        If String.IsNullOrEmpty(txt_username.Text) Then
            Err.SetError(lbl_username, "Input the provided username.")
            Exit Sub
        End If

        If String.IsNullOrEmpty(txt_password.Text) Then
            Err.SetError(lbl_pass, "Input your password.")
            Exit Sub
        End If

        Dim username = txt_username.Text.Trim
        Dim pass = txt_password.Text.Trim

        Dim ok_username = False
        Dim ok_pass = False

        Try
            conn.Open()
            Dim cmd = New MySqlCommand("SELECT * FROM ims_users WHERE deleted=0", conn)
            Dim rdr As MySqlDataReader = cmd.ExecuteReader


            If rdr.HasRows Then
                While rdr.Read
                    If Equals(rdr("username"), username) Then ok_username = True
                    If Equals(Decrypt(rdr("pass")), pass) Then ok_pass = True
                End While
            End If


            If ok_username Then
                If ok_pass Then

                    'WHEN IT PASS THE VERIFICATION

                    'frm_main.Show()
                    My.Settings.login = True
                    My.Settings.login_user = username
                    My.Settings.Save()
                    'frm_main.LogIn(username)

                    'Application.Restart()
                    frm_main.Initialize_zerp()
                    Me.Close()

                Else
                    err_lbl.Text = "Incorrect password."
                    err_lbl.Visible = True
                End If
            Else
                err_lbl.Text = "Incorrect username."
                err_lbl.Visible = True
            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            conn.Close()
        End Try

    End Sub

    'keypress on Enter
    Private Sub txt_password_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_password.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_login.PerformClick()
        End If
    End Sub

    'Press CTRL + F1 to show Connection Settings
    Private Sub frm_login_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F1 And e.Modifiers = Keys.Control Then
            frm_connection_panel.ShowDialog()
        End If
        If e.Modifiers = Keys.Shift And e.KeyCode = Keys.Z Then
            MsgBox("Developed by John Zenery", vbInformation, "Who is my Creator")
        End If
    End Sub

End Class
