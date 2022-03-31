<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_warehouse_PackageManagement_packed
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_warehouse_PackageManagement_packed))
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_checked_by = New DevExpress.XtraEditors.LabelControl()
        Me.cbb_packer = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.btn_packed = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_print = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_transfer_type = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_prepared_by = New DevExpress.XtraEditors.TextEdit()
        Me.lbl_prepared_by = New DevExpress.XtraEditors.LabelControl()
        Me.txt_sub_transfer_id = New System.Windows.Forms.TextBox()
        Me.txt_transfer_id = New System.Windows.Forms.TextBox()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_status = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.cbb_packer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_transfer_type.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_prepared_by.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_status.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.749999!)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(16, 23)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(95, 16)
        Me.LabelControl3.TabIndex = 51
        Me.LabelControl3.Text = "Root Transfer ID"
        '
        'lbl_checked_by
        '
        Me.lbl_checked_by.Appearance.Font = New System.Drawing.Font("Tahoma", 9.749999!)
        Me.lbl_checked_by.Appearance.Options.UseFont = True
        Me.lbl_checked_by.Location = New System.Drawing.Point(16, 162)
        Me.lbl_checked_by.Name = "lbl_checked_by"
        Me.lbl_checked_by.Size = New System.Drawing.Size(65, 16)
        Me.lbl_checked_by.TabIndex = 68
        Me.lbl_checked_by.Text = "Checked by"
        '
        'cbb_packer
        '
        Me.cbb_packer.Location = New System.Drawing.Point(106, 162)
        Me.cbb_packer.Name = "cbb_packer"
        Me.cbb_packer.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.cbb_packer.Properties.Appearance.Options.UseFont = True
        Me.cbb_packer.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_packer.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cbb_packer.Size = New System.Drawing.Size(122, 22)
        Me.cbb_packer.TabIndex = 67
        '
        'btn_packed
        '
        Me.btn_packed.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.apply_16x16
        Me.btn_packed.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_packed.Location = New System.Drawing.Point(119, 199)
        Me.btn_packed.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_packed.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_packed.Name = "btn_packed"
        Me.btn_packed.Size = New System.Drawing.Size(109, 49)
        Me.btn_packed.TabIndex = 66
        Me.btn_packed.Text = "Mark as Packed"
        '
        'btn_print
        '
        Me.btn_print.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.print_32x322
        Me.btn_print.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_print.ImageOptions.ImageToTextIndent = 5
        Me.btn_print.Location = New System.Drawing.Point(12, 199)
        Me.btn_print.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_print.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(101, 49)
        Me.btn_print.TabIndex = 75
        Me.btn_print.Text = "Print List"
        '
        'txt_transfer_type
        '
        Me.txt_transfer_type.Location = New System.Drawing.Point(106, 79)
        Me.txt_transfer_type.Name = "txt_transfer_type"
        Me.txt_transfer_type.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.txt_transfer_type.Properties.Appearance.Options.UseFont = True
        Me.txt_transfer_type.Properties.ReadOnly = True
        Me.txt_transfer_type.Properties.UseReadOnlyAppearance = False
        Me.txt_transfer_type.Size = New System.Drawing.Size(122, 22)
        Me.txt_transfer_type.TabIndex = 77
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.749999!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(16, 82)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(81, 16)
        Me.LabelControl1.TabIndex = 76
        Me.LabelControl1.Text = "Transfer Type"
        '
        'txt_prepared_by
        '
        Me.txt_prepared_by.Location = New System.Drawing.Point(106, 134)
        Me.txt_prepared_by.Name = "txt_prepared_by"
        Me.txt_prepared_by.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.txt_prepared_by.Properties.Appearance.Options.UseFont = True
        Me.txt_prepared_by.Size = New System.Drawing.Size(122, 22)
        Me.txt_prepared_by.TabIndex = 78
        '
        'lbl_prepared_by
        '
        Me.lbl_prepared_by.Appearance.Font = New System.Drawing.Font("Tahoma", 9.749999!)
        Me.lbl_prepared_by.Appearance.Options.UseFont = True
        Me.lbl_prepared_by.Location = New System.Drawing.Point(16, 137)
        Me.lbl_prepared_by.Name = "lbl_prepared_by"
        Me.lbl_prepared_by.Size = New System.Drawing.Size(69, 16)
        Me.lbl_prepared_by.TabIndex = 79
        Me.lbl_prepared_by.Text = "Prepared by"
        '
        'txt_sub_transfer_id
        '
        Me.txt_sub_transfer_id.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txt_sub_transfer_id.Location = New System.Drawing.Point(133, 48)
        Me.txt_sub_transfer_id.Name = "txt_sub_transfer_id"
        Me.txt_sub_transfer_id.ReadOnly = True
        Me.txt_sub_transfer_id.Size = New System.Drawing.Size(91, 20)
        Me.txt_sub_transfer_id.TabIndex = 80
        Me.txt_sub_transfer_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_transfer_id
        '
        Me.txt_transfer_id.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txt_transfer_id.Location = New System.Drawing.Point(16, 48)
        Me.txt_transfer_id.Name = "txt_transfer_id"
        Me.txt_transfer_id.ReadOnly = True
        Me.txt_transfer_id.Size = New System.Drawing.Size(111, 20)
        Me.txt_transfer_id.TabIndex = 81
        Me.txt_transfer_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 9.749999!)
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(133, 23)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(91, 16)
        Me.LabelControl4.TabIndex = 82
        Me.LabelControl4.Text = "Sub Transfer ID"
        '
        'txt_status
        '
        Me.txt_status.Location = New System.Drawing.Point(106, 107)
        Me.txt_status.Name = "txt_status"
        Me.txt_status.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.txt_status.Properties.Appearance.Options.UseFont = True
        Me.txt_status.Properties.ReadOnly = True
        Me.txt_status.Properties.UseReadOnlyAppearance = False
        Me.txt_status.Size = New System.Drawing.Size(122, 22)
        Me.txt_status.TabIndex = 84
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 9.749999!)
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(16, 110)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(36, 16)
        Me.LabelControl5.TabIndex = 83
        Me.LabelControl5.Text = "Status"
        '
        'frm_warehouse_PackageManagement_packed
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(243, 269)
        Me.Controls.Add(Me.txt_status)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.txt_transfer_id)
        Me.Controls.Add(Me.txt_sub_transfer_id)
        Me.Controls.Add(Me.lbl_prepared_by)
        Me.Controls.Add(Me.txt_prepared_by)
        Me.Controls.Add(Me.txt_transfer_type)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.btn_print)
        Me.Controls.Add(Me.lbl_checked_by)
        Me.Controls.Add(Me.cbb_packer)
        Me.Controls.Add(Me.btn_packed)
        Me.Controls.Add(Me.LabelControl3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_warehouse_PackageManagement_packed"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Arrangement Dialog"
        CType(Me.cbb_packer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_transfer_type.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_prepared_by.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_status.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_checked_by As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbb_packer As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents btn_packed As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_print As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_transfer_type As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_prepared_by As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbl_prepared_by As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_sub_transfer_id As TextBox
    Friend WithEvents txt_transfer_id As TextBox
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_status As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
End Class
