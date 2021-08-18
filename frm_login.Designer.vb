<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_login))
        Me.txt_username = New Guna.UI.WinForms.GunaTextBox()
        Me.txt_password = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.GunaControlBox2 = New Guna.UI.WinForms.GunaControlBox()
        Me.GunaControlBox1 = New Guna.UI.WinForms.GunaControlBox()
        Me.lbl_username = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_pass = New DevExpress.XtraEditors.LabelControl()
        Me.GunaDragControl1 = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.btn_login = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Err = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.err_lbl = New DevExpress.XtraEditors.LabelControl()
        Me.GunaPanel1.SuspendLayout()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Err, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_username
        '
        Me.txt_username.BackColor = System.Drawing.Color.Transparent
        Me.txt_username.BaseColor = System.Drawing.Color.White
        Me.txt_username.BorderColor = System.Drawing.Color.Silver
        Me.txt_username.BorderSize = 1
        Me.txt_username.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_username.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_username.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_username.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_username.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_username.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txt_username.Location = New System.Drawing.Point(162, 89)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_username.Radius = 3
        Me.txt_username.SelectedText = ""
        Me.txt_username.Size = New System.Drawing.Size(196, 38)
        Me.txt_username.TabIndex = 2
        Me.txt_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_username.TextOffsetX = 10
        '
        'txt_password
        '
        Me.txt_password.BackColor = System.Drawing.Color.Transparent
        Me.txt_password.BaseColor = System.Drawing.Color.White
        Me.txt_password.BorderColor = System.Drawing.Color.Silver
        Me.txt_password.BorderSize = 1
        Me.txt_password.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_password.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_password.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_password.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_password.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_password.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txt_password.Location = New System.Drawing.Point(162, 150)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txt_password.Radius = 3
        Me.txt_password.SelectedText = ""
        Me.txt_password.Size = New System.Drawing.Size(196, 38)
        Me.txt_password.TabIndex = 3
        Me.txt_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_password.TextOffsetX = 10
        Me.txt_password.UseSystemPasswordChar = True
        '
        'GunaPanel1
        '
        Me.GunaPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.GunaPanel1.Controls.Add(Me.LabelControl4)
        Me.GunaPanel1.Controls.Add(Me.GunaControlBox2)
        Me.GunaPanel1.Controls.Add(Me.GunaControlBox1)
        Me.GunaPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(375, 32)
        Me.GunaPanel1.TabIndex = 4
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Appearance.Options.UseForeColor = True
        Me.LabelControl4.Location = New System.Drawing.Point(12, 5)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(39, 21)
        Me.LabelControl4.TabIndex = 9
        Me.LabelControl4.Text = "Login"
        '
        'GunaControlBox2
        '
        Me.GunaControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaControlBox2.AnimationHoverSpeed = 0.07!
        Me.GunaControlBox2.AnimationSpeed = 0.03!
        Me.GunaControlBox2.BackColor = System.Drawing.Color.Transparent
        Me.GunaControlBox2.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox
        Me.GunaControlBox2.IconColor = System.Drawing.Color.White
        Me.GunaControlBox2.IconSize = 15.0!
        Me.GunaControlBox2.Location = New System.Drawing.Point(319, 5)
        Me.GunaControlBox2.Name = "GunaControlBox2"
        Me.GunaControlBox2.OnHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.GunaControlBox2.OnHoverIconColor = System.Drawing.Color.White
        Me.GunaControlBox2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaControlBox2.Size = New System.Drawing.Size(25, 25)
        Me.GunaControlBox2.TabIndex = 8
        '
        'GunaControlBox1
        '
        Me.GunaControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaControlBox1.AnimationHoverSpeed = 0.07!
        Me.GunaControlBox1.AnimationSpeed = 0.03!
        Me.GunaControlBox1.BackColor = System.Drawing.Color.Red
        Me.GunaControlBox1.IconColor = System.Drawing.Color.White
        Me.GunaControlBox1.IconSize = 15.0!
        Me.GunaControlBox1.Location = New System.Drawing.Point(343, 5)
        Me.GunaControlBox1.Name = "GunaControlBox1"
        Me.GunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.GunaControlBox1.OnHoverIconColor = System.Drawing.Color.White
        Me.GunaControlBox1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaControlBox1.Size = New System.Drawing.Size(25, 22)
        Me.GunaControlBox1.TabIndex = 7
        '
        'lbl_username
        '
        Me.lbl_username.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_username.Appearance.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbl_username.Appearance.Options.UseFont = True
        Me.lbl_username.Appearance.Options.UseForeColor = True
        Me.lbl_username.Location = New System.Drawing.Point(164, 66)
        Me.lbl_username.Name = "lbl_username"
        Me.lbl_username.Size = New System.Drawing.Size(59, 17)
        Me.lbl_username.TabIndex = 5
        Me.lbl_username.Text = "Username"
        '
        'lbl_pass
        '
        Me.lbl_pass.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pass.Appearance.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbl_pass.Appearance.Options.UseFont = True
        Me.lbl_pass.Appearance.Options.UseForeColor = True
        Me.lbl_pass.Location = New System.Drawing.Point(162, 130)
        Me.lbl_pass.Name = "lbl_pass"
        Me.lbl_pass.Size = New System.Drawing.Size(56, 17)
        Me.lbl_pass.TabIndex = 6
        Me.lbl_pass.Text = "Password"
        '
        'GunaDragControl1
        '
        Me.GunaDragControl1.TargetControl = Me.GunaPanel1
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Appearance.Options.UseForeColor = True
        Me.LabelControl3.Appearance.Options.UseTextOptions = True
        Me.LabelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.LabelControl3.LineLocation = DevExpress.XtraEditors.LineLocation.Top
        Me.LabelControl3.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.LabelControl3.LineVisible = True
        Me.LabelControl3.Location = New System.Drawing.Point(23, 162)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(123, 37)
        Me.LabelControl3.TabIndex = 8
        Me.LabelControl3.Text = "Please login with the" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "provided credentials."
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Image = Global.Inventory_Management.My.Resources.Resources.man_key
        Me.GunaPictureBox1.Location = New System.Drawing.Point(39, 78)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(87, 78)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GunaPictureBox1.TabIndex = 7
        Me.GunaPictureBox1.TabStop = False
        '
        'btn_login
        '
        Me.btn_login.AnimationHoverSpeed = 0.07!
        Me.btn_login.AnimationSpeed = 0.03!
        Me.btn_login.BackColor = System.Drawing.Color.Transparent
        Me.btn_login.BaseColor = System.Drawing.Color.White
        Me.btn_login.BorderColor = System.Drawing.Color.Silver
        Me.btn_login.BorderSize = 1
        Me.btn_login.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btn_login.CheckedBorderColor = System.Drawing.Color.Black
        Me.btn_login.CheckedForeColor = System.Drawing.Color.White
        Me.btn_login.CheckedImage = CType(resources.GetObject("btn_login.CheckedImage"), System.Drawing.Image)
        Me.btn_login.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btn_login.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_login.FocusedColor = System.Drawing.Color.Empty
        Me.btn_login.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_login.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btn_login.Image = Nothing
        Me.btn_login.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_login.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_login.Location = New System.Drawing.Point(162, 203)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_login.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_login.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_login.OnHoverImage = Nothing
        Me.btn_login.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_login.OnPressedColor = System.Drawing.Color.Black
        Me.btn_login.Radius = 3
        Me.btn_login.Size = New System.Drawing.Size(196, 40)
        Me.btn_login.TabIndex = 1
        Me.btn_login.Text = "Login"
        Me.btn_login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Err
        '
        Me.Err.ContainerControl = Me
        '
        'err_lbl
        '
        Me.err_lbl.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.err_lbl.Appearance.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Critical
        Me.err_lbl.Appearance.Options.UseFont = True
        Me.err_lbl.Appearance.Options.UseForeColor = True
        Me.err_lbl.Appearance.Options.UseTextOptions = True
        Me.err_lbl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.err_lbl.Location = New System.Drawing.Point(127, 43)
        Me.err_lbl.Name = "err_lbl"
        Me.err_lbl.Size = New System.Drawing.Size(126, 17)
        Me.err_lbl.TabIndex = 9
        Me.err_lbl.Text = "*Incorrect credentials."
        Me.err_lbl.Visible = False
        '
        'frm_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(375, 276)
        Me.Controls.Add(Me.err_lbl)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.GunaPictureBox1)
        Me.Controls.Add(Me.lbl_pass)
        Me.Controls.Add(Me.lbl_username)
        Me.Controls.Add(Me.GunaPanel1)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.txt_username)
        Me.Controls.Add(Me.btn_login)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frm_login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.GunaPanel1.ResumeLayout(False)
        Me.GunaPanel1.PerformLayout()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Err, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_login As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents txt_password As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txt_username As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents lbl_username As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_pass As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GunaDragControl1 As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents GunaControlBox1 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents GunaControlBox2 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Err As ErrorProvider
    Friend WithEvents err_lbl As DevExpress.XtraEditors.LabelControl
End Class
