<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_homepage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_homepage))
        Me.txt_welcome = New DevExpress.XtraEditors.LabelControl()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.GunaGradientPanel1 = New Guna.UI.WinForms.GunaGradientPanel()
        Me.txt_end = New DevExpress.XtraEditors.TextEdit()
        Me.txt_begin = New DevExpress.XtraEditors.TextEdit()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txt_quotes = New DevExpress.XtraEditors.LabelControl()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaGradientPanel1.SuspendLayout()
        CType(Me.txt_end.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_begin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaPanel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_welcome
        '
        Me.txt_welcome.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_welcome.Appearance.Font = New System.Drawing.Font("Calibri Light", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_welcome.Appearance.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txt_welcome.Appearance.Options.UseFont = True
        Me.txt_welcome.Appearance.Options.UseForeColor = True
        Me.txt_welcome.Appearance.Options.UseTextOptions = True
        Me.txt_welcome.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txt_welcome.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.txt_welcome.Location = New System.Drawing.Point(3, 365)
        Me.txt_welcome.Name = "txt_welcome"
        Me.txt_welcome.Size = New System.Drawing.Size(860, 45)
        Me.txt_welcome.TabIndex = 0
        Me.txt_welcome.Text = "Yehey! Welcome Back John Zenery"
        '
        'PictureEdit1
        '
        Me.PictureEdit1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureEdit1.EditValue = CType(resources.GetObject("PictureEdit1.EditValue"), Object)
        Me.PictureEdit1.Location = New System.Drawing.Point(203, 15)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.PictureEdit1.Size = New System.Drawing.Size(450, 338)
        Me.PictureEdit1.TabIndex = 1
        '
        'GunaGradientPanel1
        '
        Me.GunaGradientPanel1.BackgroundImage = CType(resources.GetObject("GunaGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.GunaGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GunaGradientPanel1.Controls.Add(Me.DataGridView1)
        Me.GunaGradientPanel1.Controls.Add(Me.txt_end)
        Me.GunaGradientPanel1.Controls.Add(Me.txt_begin)
        Me.GunaGradientPanel1.Controls.Add(Me.SimpleButton1)
        Me.GunaGradientPanel1.Controls.Add(Me.GunaPanel1)
        Me.GunaGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GunaGradientPanel1.GradientColor1 = System.Drawing.Color.White
        Me.GunaGradientPanel1.GradientColor2 = System.Drawing.Color.GhostWhite
        Me.GunaGradientPanel1.GradientColor3 = System.Drawing.Color.White
        Me.GunaGradientPanel1.GradientColor4 = System.Drawing.Color.White
        Me.GunaGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaGradientPanel1.Name = "GunaGradientPanel1"
        Me.GunaGradientPanel1.Size = New System.Drawing.Size(1134, 710)
        Me.GunaGradientPanel1.TabIndex = 3
        Me.GunaGradientPanel1.Text = "GunaGradientPanel1"
        '
        'txt_end
        '
        Me.txt_end.Location = New System.Drawing.Point(12, 62)
        Me.txt_end.Name = "txt_end"
        Me.txt_end.Size = New System.Drawing.Size(81, 20)
        Me.txt_end.TabIndex = 3
        Me.txt_end.Visible = False
        '
        'txt_begin
        '
        Me.txt_begin.Location = New System.Drawing.Point(12, 36)
        Me.txt_begin.Name = "txt_begin"
        Me.txt_begin.Size = New System.Drawing.Size(81, 20)
        Me.txt_begin.TabIndex = 2
        Me.txt_begin.Visible = False
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(12, 96)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(108, 46)
        Me.SimpleButton1.TabIndex = 1
        Me.SimpleButton1.Text = "Convert"
        Me.SimpleButton1.Visible = False
        '
        'GunaPanel1
        '
        Me.GunaPanel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaPanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaPanel1.Controls.Add(Me.txt_quotes)
        Me.GunaPanel1.Controls.Add(Me.PictureEdit1)
        Me.GunaPanel1.Controls.Add(Me.txt_welcome)
        Me.GunaPanel1.Location = New System.Drawing.Point(139, 122)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(866, 510)
        Me.GunaPanel1.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 148)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(108, 128)
        Me.DataGridView1.TabIndex = 2
        Me.DataGridView1.Visible = False
        '
        'txt_quotes
        '
        Me.txt_quotes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_quotes.Appearance.Font = New System.Drawing.Font("Calibri Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_quotes.Appearance.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txt_quotes.Appearance.Options.UseFont = True
        Me.txt_quotes.Appearance.Options.UseForeColor = True
        Me.txt_quotes.Appearance.Options.UseTextOptions = True
        Me.txt_quotes.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txt_quotes.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.txt_quotes.Location = New System.Drawing.Point(3, 437)
        Me.txt_quotes.Name = "txt_quotes"
        Me.txt_quotes.Size = New System.Drawing.Size(860, 45)
        Me.txt_quotes.TabIndex = 2
        Me.txt_quotes.Text = "Just one small positive thought in the morning can change your whole day." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- Dala" &
    "i Lama"
        '
        'frm_homepage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(1134, 710)
        Me.Controls.Add(Me.GunaGradientPanel1)
        Me.Name = "frm_homepage"
        Me.Text = "frm_homepage"
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaGradientPanel1.ResumeLayout(False)
        CType(Me.txt_end.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_begin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaPanel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txt_welcome As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents GunaGradientPanel1 As Guna.UI.WinForms.GunaGradientPanel
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents txt_quotes As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txt_end As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_begin As DevExpress.XtraEditors.TextEdit
End Class
