<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_sales_logistics_new
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_sales_logistics_new))
        Me.panel_top = New Guna.UI.WinForms.GunaLinePanel()
        Me.title = New Guna.UI.WinForms.GunaLabel()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_name = New DevExpress.XtraEditors.TextEdit()
        Me.txt_contact = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_contact_no = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_nearest = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_destinations = New DevExpress.XtraEditors.MemoEdit()
        Me.btn_new = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_cancel = New DevExpress.XtraEditors.SimpleButton()
        Me.id = New DevExpress.XtraEditors.LabelControl()
        Me.panel_top.SuspendLayout()
        CType(Me.txt_name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_contact.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_contact_no.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_nearest.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_destinations.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel_top
        '
        Me.panel_top.BackColor = System.Drawing.Color.GhostWhite
        Me.panel_top.Controls.Add(Me.title)
        Me.panel_top.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_top.LineColor = System.Drawing.SystemColors.ControlLight
        Me.panel_top.LineStyle = System.Windows.Forms.BorderStyle.None
        Me.panel_top.Location = New System.Drawing.Point(0, 0)
        Me.panel_top.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.panel_top.Name = "panel_top"
        Me.panel_top.Size = New System.Drawing.Size(594, 66)
        Me.panel_top.TabIndex = 9
        '
        'title
        '
        Me.title.AutoSize = True
        Me.title.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.title.Location = New System.Drawing.Point(14, 16)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(199, 37)
        Me.title.TabIndex = 1
        Me.title.Text = "New Logistic"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(18, 104)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(83, 17)
        Me.LabelControl1.TabIndex = 10
        Me.LabelControl1.Text = "Logistic Name"
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(121, 101)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_name.Properties.Appearance.Options.UseFont = True
        Me.txt_name.Size = New System.Drawing.Size(224, 24)
        Me.txt_name.TabIndex = 11
        '
        'txt_contact
        '
        Me.txt_contact.Location = New System.Drawing.Point(121, 131)
        Me.txt_contact.Name = "txt_contact"
        Me.txt_contact.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_contact.Properties.Appearance.Options.UseFont = True
        Me.txt_contact.Size = New System.Drawing.Size(224, 24)
        Me.txt_contact.TabIndex = 13
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(18, 134)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(88, 17)
        Me.LabelControl2.TabIndex = 12
        Me.LabelControl2.Text = "Contact Person"
        '
        'txt_contact_no
        '
        Me.txt_contact_no.Location = New System.Drawing.Point(121, 161)
        Me.txt_contact_no.Name = "txt_contact_no"
        Me.txt_contact_no.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_contact_no.Properties.Appearance.Options.UseFont = True
        Me.txt_contact_no.Size = New System.Drawing.Size(224, 24)
        Me.txt_contact_no.TabIndex = 15
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(18, 164)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(69, 17)
        Me.LabelControl3.TabIndex = 14
        Me.LabelControl3.Text = "Contact No."
        '
        'txt_nearest
        '
        Me.txt_nearest.Location = New System.Drawing.Point(121, 207)
        Me.txt_nearest.Name = "txt_nearest"
        Me.txt_nearest.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nearest.Properties.Appearance.Options.UseFont = True
        Me.txt_nearest.Size = New System.Drawing.Size(445, 49)
        Me.txt_nearest.TabIndex = 16
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(18, 208)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(89, 17)
        Me.LabelControl4.TabIndex = 17
        Me.LabelControl4.Text = "Nearest Branch"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(18, 272)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(71, 17)
        Me.LabelControl5.TabIndex = 19
        Me.LabelControl5.Text = "Destinations"
        '
        'txt_destinations
        '
        Me.txt_destinations.Location = New System.Drawing.Point(121, 271)
        Me.txt_destinations.Name = "txt_destinations"
        Me.txt_destinations.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_destinations.Properties.Appearance.Options.UseFont = True
        Me.txt_destinations.Size = New System.Drawing.Size(445, 139)
        Me.txt_destinations.TabIndex = 18
        '
        'btn_new
        '
        Me.btn_new.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_new.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question
        Me.btn_new.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_new.Appearance.Options.UseBackColor = True
        Me.btn_new.Appearance.Options.UseFont = True
        Me.btn_new.Appearance.Options.UseTextOptions = True
        Me.btn_new.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btn_new.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btn_new.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_new.ImageOptions.ImageToTextIndent = 5
        Me.btn_new.Location = New System.Drawing.Point(406, 428)
        Me.btn_new.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_new.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(160, 47)
        Me.btn_new.TabIndex = 20
        Me.btn_new.Text = "Save Record"
        '
        'btn_cancel
        '
        Me.btn_cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_cancel.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.Appearance.Options.UseFont = True
        Me.btn_cancel.Appearance.Options.UseTextOptions = True
        Me.btn_cancel.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btn_cancel.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_cancel.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_cancel.ImageOptions.ImageToTextIndent = 5
        Me.btn_cancel.Location = New System.Drawing.Point(240, 428)
        Me.btn_cancel.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_cancel.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(160, 47)
        Me.btn_cancel.TabIndex = 21
        Me.btn_cancel.Text = "Cancel"
        '
        'id
        '
        Me.id.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id.Appearance.Options.UseFont = True
        Me.id.Location = New System.Drawing.Point(18, 81)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(11, 17)
        Me.id.TabIndex = 22
        Me.id.Text = "id"
        Me.id.Visible = False
        '
        'frm_sales_logistics_new
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(594, 489)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_new)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.txt_destinations)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.txt_nearest)
        Me.Controls.Add(Me.txt_contact_no)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txt_contact)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.panel_top)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_sales_logistics_new"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Logisctic"
        Me.panel_top.ResumeLayout(False)
        Me.panel_top.PerformLayout()
        CType(Me.txt_name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_contact.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_contact_no.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_nearest.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_destinations.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents panel_top As Guna.UI.WinForms.GunaLinePanel
    Friend WithEvents title As Guna.UI.WinForms.GunaLabel
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_name As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_contact As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_contact_no As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_nearest As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_destinations As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents btn_new As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_cancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents id As DevExpress.XtraEditors.LabelControl
End Class
