<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_sales_start_packing
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_sales_start_packing))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_yes = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_no = New DevExpress.XtraEditors.SimpleButton()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Start to arrange this order?"
        '
        'btn_yes
        '
        Me.btn_yes.Appearance.BackColor = System.Drawing.Color.SlateBlue
        Me.btn_yes.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_yes.Appearance.Options.UseBackColor = True
        Me.btn_yes.Appearance.Options.UseFont = True
        Me.btn_yes.Location = New System.Drawing.Point(137, 122)
        Me.btn_yes.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_yes.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_yes.Name = "btn_yes"
        Me.btn_yes.Size = New System.Drawing.Size(119, 43)
        Me.btn_yes.TabIndex = 1
        Me.btn_yes.Text = "Yes"
        '
        'btn_no
        '
        Me.btn_no.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_no.Appearance.Options.UseFont = True
        Me.btn_no.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_no.Location = New System.Drawing.Point(12, 122)
        Me.btn_no.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_no.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_no.Name = "btn_no"
        Me.btn_no.Size = New System.Drawing.Size(119, 43)
        Me.btn_no.TabIndex = 2
        Me.btn_no.Text = "No"
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id.Location = New System.Drawing.Point(67, 27)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(140, 40)
        Me.lbl_id.TabIndex = 3
        Me.lbl_id.Text = "SO00025"
        '
        'frm_sales_start_packing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(269, 181)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.btn_no)
        Me.Controls.Add(Me.btn_yes)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_sales_start_packing"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Arrange Order"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btn_yes As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_no As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lbl_id As Label
End Class
