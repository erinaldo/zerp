<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_warehouse_stock_transfer_report
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_warehouse_stock_transfer_report))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_title = New Guna.UI.WinForms.GunaLabel()
        Me.txt_stock_transfer_id = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_report_notes = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_cancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_submit = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel1.SuspendLayout()
        CType(Me.txt_stock_transfer_id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_report_notes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.lbl_title)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(400, 64)
        Me.Panel1.TabIndex = 5
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lbl_title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.lbl_title.Location = New System.Drawing.Point(58, 21)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(281, 31)
        Me.lbl_title.TabIndex = 2
        Me.lbl_title.Text = "Stock Transfer Report"
        '
        'txt_stock_transfer_id
        '
        Me.txt_stock_transfer_id.Enabled = False
        Me.txt_stock_transfer_id.EnterMoveNextControl = True
        Me.txt_stock_transfer_id.Location = New System.Drawing.Point(15, 103)
        Me.txt_stock_transfer_id.Name = "txt_stock_transfer_id"
        Me.txt_stock_transfer_id.Properties.Appearance.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold)
        Me.txt_stock_transfer_id.Properties.Appearance.Options.UseFont = True
        Me.txt_stock_transfer_id.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_stock_transfer_id.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txt_stock_transfer_id.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_stock_transfer_id.Size = New System.Drawing.Size(159, 30)
        Me.txt_stock_transfer_id.TabIndex = 6
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(15, 82)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(94, 15)
        Me.LabelControl1.TabIndex = 7
        Me.LabelControl1.Text = "Stock Transfer ID"
        '
        'txt_report_notes
        '
        Me.txt_report_notes.EditValue = ""
        Me.txt_report_notes.Location = New System.Drawing.Point(15, 164)
        Me.txt_report_notes.Name = "txt_report_notes"
        Me.txt_report_notes.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.txt_report_notes.Properties.Appearance.Options.UseFont = True
        Me.txt_report_notes.Size = New System.Drawing.Size(370, 96)
        Me.txt_report_notes.TabIndex = 8
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(15, 143)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(135, 15)
        Me.LabelControl2.TabIndex = 9
        Me.LabelControl2.Text = "Transfer Incident Report "
        '
        'btn_cancel
        '
        Me.btn_cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_cancel.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.Appearance.Options.UseFont = True
        Me.btn_cancel.Appearance.Options.UseTextOptions = True
        Me.btn_cancel.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btn_cancel.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_cancel.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_cancel.ImageOptions.ImageToTextIndent = 8
        Me.btn_cancel.Location = New System.Drawing.Point(41, 272)
        Me.btn_cancel.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_cancel.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(154, 32)
        Me.btn_cancel.TabIndex = 86
        Me.btn_cancel.Text = "Cancel"
        '
        'btn_submit
        '
        Me.btn_submit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_submit.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary
        Me.btn_submit.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_submit.Appearance.Options.UseBackColor = True
        Me.btn_submit.Appearance.Options.UseFont = True
        Me.btn_submit.Appearance.Options.UseTextOptions = True
        Me.btn_submit.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btn_submit.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btn_submit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_submit.ImageOptions.ImageToTextIndent = 8
        Me.btn_submit.Location = New System.Drawing.Point(201, 272)
        Me.btn_submit.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_submit.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_submit.Name = "btn_submit"
        Me.btn_submit.Size = New System.Drawing.Size(154, 32)
        Me.btn_submit.TabIndex = 85
        Me.btn_submit.Text = "Submit"
        '
        'frm_warehouse_stock_transfer_report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(400, 316)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_submit)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txt_report_notes)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txt_stock_transfer_id)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_warehouse_stock_transfer_report"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stock Transfer Report"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.txt_stock_transfer_id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_report_notes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_title As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_stock_transfer_id As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_report_notes As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_cancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_submit As DevExpress.XtraEditors.SimpleButton
End Class
