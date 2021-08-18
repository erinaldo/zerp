<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_collection_refund
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_collection_refund))
        Me.lbl_amount_due = New DevExpress.XtraEditors.LabelControl()
        Me.btn_paid = New DevExpress.XtraEditors.SimpleButton()
        Me.lbl_orderid = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_customer = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.SuspendLayout()
        '
        'lbl_amount_due
        '
        Me.lbl_amount_due.Appearance.BackColor = System.Drawing.Color.White
        Me.lbl_amount_due.Appearance.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold)
        Me.lbl_amount_due.Appearance.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbl_amount_due.Appearance.Options.UseBackColor = True
        Me.lbl_amount_due.Appearance.Options.UseFont = True
        Me.lbl_amount_due.Appearance.Options.UseForeColor = True
        Me.lbl_amount_due.Appearance.Options.UseTextOptions = True
        Me.lbl_amount_due.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lbl_amount_due.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lbl_amount_due.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_amount_due.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.lbl_amount_due.Location = New System.Drawing.Point(18, 90)
        Me.lbl_amount_due.Name = "lbl_amount_due"
        Me.lbl_amount_due.Size = New System.Drawing.Size(221, 38)
        Me.lbl_amount_due.TabIndex = 21
        Me.lbl_amount_due.Text = "P0.00"
        '
        'btn_paid
        '
        Me.btn_paid.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success
        Me.btn_paid.Appearance.Options.UseBackColor = True
        Me.btn_paid.Location = New System.Drawing.Point(18, 161)
        Me.btn_paid.Name = "btn_paid"
        Me.btn_paid.Size = New System.Drawing.Size(221, 37)
        Me.btn_paid.TabIndex = 22
        Me.btn_paid.Text = "Yes! Refunded"
        '
        'lbl_orderid
        '
        Me.lbl_orderid.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_orderid.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.lbl_orderid.Appearance.Options.UseFont = True
        Me.lbl_orderid.Appearance.Options.UseForeColor = True
        Me.lbl_orderid.Location = New System.Drawing.Point(96, 21)
        Me.lbl_orderid.Name = "lbl_orderid"
        Me.lbl_orderid.Size = New System.Drawing.Size(7, 14)
        Me.lbl_orderid.TabIndex = 24
        Me.lbl_orderid.Text = "0"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Appearance.Options.UseForeColor = True
        Me.LabelControl3.Location = New System.Drawing.Point(18, 21)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(56, 14)
        Me.LabelControl3.TabIndex = 23
        Me.LabelControl3.Text = "Order ID:"
        '
        'lbl_customer
        '
        Me.lbl_customer.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_customer.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.lbl_customer.Appearance.Options.UseFont = True
        Me.lbl_customer.Appearance.Options.UseForeColor = True
        Me.lbl_customer.Appearance.Options.UseTextOptions = True
        Me.lbl_customer.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.lbl_customer.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_customer.Location = New System.Drawing.Point(96, 41)
        Me.lbl_customer.Name = "lbl_customer"
        Me.lbl_customer.Size = New System.Drawing.Size(161, 14)
        Me.lbl_customer.TabIndex = 26
        Me.lbl_customer.Text = "Customer Name"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Appearance.Options.UseForeColor = True
        Me.LabelControl2.Location = New System.Drawing.Point(18, 41)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(63, 14)
        Me.LabelControl2.TabIndex = 25
        Me.LabelControl2.Text = "Customer:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseTextOptions = True
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.Location = New System.Drawing.Point(19, 141)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(221, 14)
        Me.LabelControl1.TabIndex = 27
        Me.LabelControl1.Text = "Did you Refund?"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Appearance.Options.UseForeColor = True
        Me.LabelControl4.Location = New System.Drawing.Point(72, 70)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(117, 14)
        Me.LabelControl4.TabIndex = 28
        Me.LabelControl4.Text = "Amount to Refund"
        '
        'frm_collection_refund
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(258, 216)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.lbl_customer)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.lbl_orderid)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.btn_paid)
        Me.Controls.Add(Me.lbl_amount_due)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_collection_refund"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Refund"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_amount_due As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_paid As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lbl_orderid As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_customer As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
End Class
