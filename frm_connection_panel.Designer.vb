Imports DevExpress.XtraEditors

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_connection_panel
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txt_port = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_database = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_server = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_ftp_password = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_ftp_username = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.txt_ftp_productF = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_ftp_server = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_ftp_userF = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_ftp_port = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_port
        '
        Me.txt_port.Location = New System.Drawing.Point(159, 29)
        Me.txt_port.Name = "txt_port"
        Me.txt_port.Size = New System.Drawing.Size(77, 20)
        Me.txt_port.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(156, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Port:"
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(12, 374)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(226, 33)
        Me.btn_save.TabIndex = 19
        Me.btn_save.Text = "Save and Restart"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'txt_password
        '
        Me.txt_password.Location = New System.Drawing.Point(76, 114)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_password.Size = New System.Drawing.Size(160, 20)
        Me.txt_password.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Password:"
        '
        'txt_username
        '
        Me.txt_username.Location = New System.Drawing.Point(76, 88)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(160, 20)
        Me.txt_username.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Username:"
        '
        'txt_database
        '
        Me.txt_database.Location = New System.Drawing.Point(76, 62)
        Me.txt_database.Name = "txt_database"
        Me.txt_database.Size = New System.Drawing.Size(160, 20)
        Me.txt_database.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Database:"
        '
        'txt_server
        '
        Me.txt_server.Location = New System.Drawing.Point(17, 29)
        Me.txt_server.Name = "txt_server"
        Me.txt_server.Size = New System.Drawing.Size(138, 20)
        Me.txt_server.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Server Address:"
        '
        'txt_ftp_password
        '
        Me.txt_ftp_password.Location = New System.Drawing.Point(72, 119)
        Me.txt_ftp_password.Name = "txt_ftp_password"
        Me.txt_ftp_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_ftp_password.Size = New System.Drawing.Size(144, 21)
        Me.txt_ftp_password.TabIndex = 25
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 122)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Password"
        '
        'txt_ftp_username
        '
        Me.txt_ftp_username.Location = New System.Drawing.Point(72, 93)
        Me.txt_ftp_username.Name = "txt_ftp_username"
        Me.txt_ftp_username.Size = New System.Drawing.Size(144, 21)
        Me.txt_ftp_username.TabIndex = 23
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 96)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Username"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.txt_ftp_productF)
        Me.GroupControl1.Controls.Add(Me.Label11)
        Me.GroupControl1.Controls.Add(Me.txt_ftp_server)
        Me.GroupControl1.Controls.Add(Me.Label9)
        Me.GroupControl1.Controls.Add(Me.txt_ftp_userF)
        Me.GroupControl1.Controls.Add(Me.Label10)
        Me.GroupControl1.Controls.Add(Me.txt_ftp_port)
        Me.GroupControl1.Controls.Add(Me.Label8)
        Me.GroupControl1.Controls.Add(Me.txt_ftp_username)
        Me.GroupControl1.Controls.Add(Me.txt_ftp_password)
        Me.GroupControl1.Controls.Add(Me.Label7)
        Me.GroupControl1.Controls.Add(Me.Label6)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 150)
        Me.GroupControl1.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.GroupControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(226, 218)
        Me.GroupControl1.TabIndex = 26
        Me.GroupControl1.Text = "FTP Credentials"
        '
        'txt_ftp_productF
        '
        Me.txt_ftp_productF.Location = New System.Drawing.Point(86, 185)
        Me.txt_ftp_productF.Name = "txt_ftp_productF"
        Me.txt_ftp_productF.Size = New System.Drawing.Size(130, 21)
        Me.txt_ftp_productF.TabIndex = 35
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(10, 188)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 13)
        Me.Label11.TabIndex = 34
        Me.Label11.Text = "Product Folder"
        '
        'txt_ftp_server
        '
        Me.txt_ftp_server.Location = New System.Drawing.Point(72, 40)
        Me.txt_ftp_server.Name = "txt_ftp_server"
        Me.txt_ftp_server.Size = New System.Drawing.Size(144, 21)
        Me.txt_ftp_server.TabIndex = 33
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(10, 43)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 13)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "Server"
        '
        'txt_ftp_userF
        '
        Me.txt_ftp_userF.Location = New System.Drawing.Point(86, 158)
        Me.txt_ftp_userF.Name = "txt_ftp_userF"
        Me.txt_ftp_userF.Size = New System.Drawing.Size(130, 21)
        Me.txt_ftp_userF.TabIndex = 31
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(10, 161)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 13)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "User Folder"
        '
        'txt_ftp_port
        '
        Me.txt_ftp_port.Location = New System.Drawing.Point(72, 67)
        Me.txt_ftp_port.Name = "txt_ftp_port"
        Me.txt_ftp_port.Size = New System.Drawing.Size(71, 21)
        Me.txt_ftp_port.TabIndex = 27
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 69)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(27, 13)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Port"
        '
        'frm_connection_panel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(250, 419)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.txt_port)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_username)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_database)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_server)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_connection_panel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Connection"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupControl1 As GroupControl
    Friend WithEvents Label1 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btn_save As Button
    Friend WithEvents txt_database As TextBox
    Friend WithEvents txt_ftp_password As TextBox
    Friend WithEvents txt_ftp_port As TextBox
    Friend WithEvents txt_ftp_productF As TextBox
    Friend WithEvents txt_ftp_server As TextBox
    Friend WithEvents txt_ftp_userF As TextBox
    Friend WithEvents txt_ftp_username As TextBox
    Friend WithEvents txt_password As TextBox
    Friend WithEvents txt_port As TextBox
    Friend WithEvents txt_server As TextBox
    Friend WithEvents txt_username As TextBox

End Class
