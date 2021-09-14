<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_admin_banks_new
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_admin_banks_new))
        Me.txt_bank_no = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_bank_name = New DevExpress.XtraEditors.TextEdit()
        Me.btn_save = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_cancel = New DevExpress.XtraEditors.SimpleButton()
        Me.lbl_title = New DevExpress.XtraEditors.LabelControl()
        Me.toggle_status = New DevExpress.XtraEditors.ToggleSwitch()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_id = New DevExpress.XtraEditors.LabelControl()
        CType(Me.txt_bank_no.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_bank_name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.toggle_status.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_bank_no
        '
        Me.txt_bank_no.Location = New System.Drawing.Point(23, 78)
        Me.txt_bank_no.Name = "txt_bank_no"
        Me.txt_bank_no.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_bank_no.Properties.Appearance.Options.UseFont = True
        Me.txt_bank_no.Size = New System.Drawing.Size(161, 22)
        Me.txt_bank_no.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(23, 56)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(55, 16)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Bank No."
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(23, 106)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(71, 16)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "Bank Name"
        '
        'txt_bank_name
        '
        Me.txt_bank_name.Location = New System.Drawing.Point(23, 128)
        Me.txt_bank_name.Name = "txt_bank_name"
        Me.txt_bank_name.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_bank_name.Properties.Appearance.Options.UseFont = True
        Me.txt_bank_name.Size = New System.Drawing.Size(218, 22)
        Me.txt_bank_name.TabIndex = 2
        '
        'btn_save
        '
        Me.btn_save.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btn_save.Location = New System.Drawing.Point(135, 191)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(106, 37)
        Me.btn_save.TabIndex = 4
        Me.btn_save.Text = "Save"
        '
        'btn_cancel
        '
        Me.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_cancel.Location = New System.Drawing.Point(23, 191)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(106, 37)
        Me.btn_cancel.TabIndex = 5
        Me.btn_cancel.Text = "Cancel"
        '
        'lbl_title
        '
        Me.lbl_title.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.lbl_title.Appearance.Options.UseFont = True
        Me.lbl_title.Appearance.Options.UseForeColor = True
        Me.lbl_title.Location = New System.Drawing.Point(23, 18)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(154, 25)
        Me.lbl_title.TabIndex = 6
        Me.lbl_title.Text = "Add New Bank"
        '
        'toggle_status
        '
        Me.toggle_status.Location = New System.Drawing.Point(71, 160)
        Me.toggle_status.Name = "toggle_status"
        Me.toggle_status.Properties.OffText = "Disabled"
        Me.toggle_status.Properties.OnText = "Enabled"
        Me.toggle_status.Size = New System.Drawing.Size(113, 20)
        Me.toggle_status.TabIndex = 7
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(23, 161)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(37, 16)
        Me.LabelControl4.TabIndex = 8
        Me.LabelControl4.Text = "Status"
        '
        'lbl_id
        '
        Me.lbl_id.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id.Appearance.Options.UseFont = True
        Me.lbl_id.Location = New System.Drawing.Point(190, 81)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(11, 16)
        Me.lbl_id.TabIndex = 9
        Me.lbl_id.Text = "id"
        Me.lbl_id.Visible = False
        '
        'frm_admin_banks_new
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(268, 240)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.toggle_status)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txt_bank_name)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txt_bank_no)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_admin_banks_new"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Bank"
        CType(Me.txt_bank_no.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_bank_name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.toggle_status.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_bank_no As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_bank_name As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btn_save As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_cancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lbl_title As DevExpress.XtraEditors.LabelControl
    Friend WithEvents toggle_status As DevExpress.XtraEditors.ToggleSwitch
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_id As DevExpress.XtraEditors.LabelControl
End Class
