<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_collection_hold
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
        Me.GunaPanel2 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_title = New Guna.UI.WinForms.GunaLabel()
        Me.txt_notes = New DevExpress.XtraEditors.MemoEdit()
        Me.btn_hold = New DevExpress.XtraEditors.SimpleButton()
        Me.lbl_orderid = New DevExpress.XtraEditors.LabelControl()
        Me.btn_cancel = New DevExpress.XtraEditors.SimpleButton()
        Me.GunaPanel2.SuspendLayout()
        CType(Me.txt_notes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaPanel2
        '
        Me.GunaPanel2.BackColor = System.Drawing.Color.White
        Me.GunaPanel2.Controls.Add(Me.lbl_title)
        Me.GunaPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel2.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel2.Name = "GunaPanel2"
        Me.GunaPanel2.Size = New System.Drawing.Size(406, 56)
        Me.GunaPanel2.TabIndex = 15
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lbl_title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.lbl_title.Location = New System.Drawing.Point(14, 13)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(194, 31)
        Me.lbl_title.TabIndex = 1
        Me.lbl_title.Text = "On-Hold Notes"
        '
        'txt_notes
        '
        Me.txt_notes.Location = New System.Drawing.Point(20, 76)
        Me.txt_notes.Name = "txt_notes"
        Me.txt_notes.Size = New System.Drawing.Size(374, 86)
        Me.txt_notes.TabIndex = 27
        '
        'btn_hold
        '
        Me.btn_hold.Location = New System.Drawing.Point(307, 171)
        Me.btn_hold.Name = "btn_hold"
        Me.btn_hold.Size = New System.Drawing.Size(87, 31)
        Me.btn_hold.TabIndex = 29
        Me.btn_hold.Text = "Apply"
        '
        'lbl_orderid
        '
        Me.lbl_orderid.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_orderid.Appearance.Options.UseFont = True
        Me.lbl_orderid.Location = New System.Drawing.Point(47, 260)
        Me.lbl_orderid.Name = "lbl_orderid"
        Me.lbl_orderid.Size = New System.Drawing.Size(7, 14)
        Me.lbl_orderid.TabIndex = 25
        Me.lbl_orderid.Text = "0"
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(214, 171)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(87, 31)
        Me.btn_cancel.TabIndex = 30
        Me.btn_cancel.Text = "Cancel"
        '
        'frm_accounting_hold
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(406, 214)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_hold)
        Me.Controls.Add(Me.txt_notes)
        Me.Controls.Add(Me.lbl_orderid)
        Me.Controls.Add(Me.GunaPanel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_accounting_hold"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "On-Hold"
        Me.GunaPanel2.ResumeLayout(False)
        Me.GunaPanel2.PerformLayout()
        CType(Me.txt_notes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaPanel2 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents lbl_title As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_notes As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents btn_hold As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lbl_orderid As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_cancel As DevExpress.XtraEditors.SimpleButton
End Class
