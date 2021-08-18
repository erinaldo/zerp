<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_collection_cash
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_collection_cash))
        Me.GunaPanel2 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_title = New Guna.UI.WinForms.GunaLabel()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_paid = New DevExpress.XtraEditors.SimpleButton()
        Me.lbl_amount_due = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_orderid = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_customer = New DevExpress.XtraEditors.LabelControl()
        Me.btn_hold = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_ref = New DevExpress.XtraEditors.TextEdit()
        Me.cbb_bank_option = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.rb_bank = New System.Windows.Forms.RadioButton()
        Me.rb_cash = New System.Windows.Forms.RadioButton()
        Me.GunaPanel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txt_ref.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbb_bank_option.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GunaPanel2.TabIndex = 14
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lbl_title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.lbl_title.Location = New System.Drawing.Point(14, 13)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(192, 31)
        Me.lbl_title.TabIndex = 1
        Me.lbl_title.Text = "Cash Payment"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(20, 97)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(63, 14)
        Me.LabelControl2.TabIndex = 16
        Me.LabelControl2.Text = "Customer:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(20, 77)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(56, 14)
        Me.LabelControl3.TabIndex = 17
        Me.LabelControl3.Text = "Order ID:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(12, 204)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(117, 14)
        Me.LabelControl4.TabIndex = 18
        Me.LabelControl4.Text = "Total Amount Due:"
        '
        'btn_paid
        '
        Me.btn_paid.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success
        Me.btn_paid.Appearance.Options.UseBackColor = True
        Me.btn_paid.Location = New System.Drawing.Point(248, 275)
        Me.btn_paid.Name = "btn_paid"
        Me.btn_paid.Size = New System.Drawing.Size(139, 31)
        Me.btn_paid.TabIndex = 19
        Me.btn_paid.Text = "Mark as PAID"
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
        Me.lbl_amount_due.Location = New System.Drawing.Point(72, 224)
        Me.lbl_amount_due.Name = "lbl_amount_due"
        Me.lbl_amount_due.Size = New System.Drawing.Size(277, 42)
        Me.lbl_amount_due.TabIndex = 20
        Me.lbl_amount_due.Text = "P0.00"
        '
        'lbl_orderid
        '
        Me.lbl_orderid.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_orderid.Appearance.Options.UseFont = True
        Me.lbl_orderid.Location = New System.Drawing.Point(98, 77)
        Me.lbl_orderid.Name = "lbl_orderid"
        Me.lbl_orderid.Size = New System.Drawing.Size(7, 14)
        Me.lbl_orderid.TabIndex = 21
        Me.lbl_orderid.Text = "0"
        '
        'lbl_customer
        '
        Me.lbl_customer.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_customer.Appearance.Options.UseFont = True
        Me.lbl_customer.Location = New System.Drawing.Point(48, 118)
        Me.lbl_customer.Name = "lbl_customer"
        Me.lbl_customer.Size = New System.Drawing.Size(87, 14)
        Me.lbl_customer.TabIndex = 22
        Me.lbl_customer.Text = "Customer Name"
        '
        'btn_hold
        '
        Me.btn_hold.Location = New System.Drawing.Point(18, 274)
        Me.btn_hold.Name = "btn_hold"
        Me.btn_hold.Size = New System.Drawing.Size(87, 31)
        Me.btn_hold.TabIndex = 24
        Me.btn_hold.Text = "HOLD"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LabelControl5)
        Me.GroupBox1.Controls.Add(Me.LabelControl1)
        Me.GroupBox1.Controls.Add(Me.txt_ref)
        Me.GroupBox1.Controls.Add(Me.cbb_bank_option)
        Me.GroupBox1.Controls.Add(Me.rb_bank)
        Me.GroupBox1.Controls.Add(Me.rb_cash)
        Me.GroupBox1.Location = New System.Drawing.Point(162, 77)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(225, 126)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Payment Mode"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(23, 74)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(32, 14)
        Me.LabelControl5.TabIndex = 29
        Me.LabelControl5.Text = "Type:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(23, 97)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(60, 14)
        Me.LabelControl1.TabIndex = 26
        Me.LabelControl1.Text = "Reference:"
        '
        'txt_ref
        '
        Me.txt_ref.Location = New System.Drawing.Point(96, 94)
        Me.txt_ref.Name = "txt_ref"
        Me.txt_ref.Size = New System.Drawing.Size(100, 20)
        Me.txt_ref.TabIndex = 27
        '
        'cbb_bank_option
        '
        Me.cbb_bank_option.Enabled = False
        Me.cbb_bank_option.Location = New System.Drawing.Point(96, 70)
        Me.cbb_bank_option.Name = "cbb_bank_option"
        Me.cbb_bank_option.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_bank_option.Properties.Items.AddRange(New Object() {"GCash", "BDO", "Metrobank", "PBCom"})
        Me.cbb_bank_option.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cbb_bank_option.Size = New System.Drawing.Size(100, 20)
        Me.cbb_bank_option.TabIndex = 28
        '
        'rb_bank
        '
        Me.rb_bank.AutoSize = True
        Me.rb_bank.Location = New System.Drawing.Point(23, 47)
        Me.rb_bank.Name = "rb_bank"
        Me.rb_bank.Size = New System.Drawing.Size(92, 17)
        Me.rb_bank.TabIndex = 1
        Me.rb_bank.TabStop = True
        Me.rb_bank.Text = "Bank Transfer"
        Me.rb_bank.UseVisualStyleBackColor = True
        '
        'rb_cash
        '
        Me.rb_cash.AutoSize = True
        Me.rb_cash.Checked = True
        Me.rb_cash.Location = New System.Drawing.Point(23, 24)
        Me.rb_cash.Name = "rb_cash"
        Me.rb_cash.Size = New System.Drawing.Size(49, 17)
        Me.rb_cash.TabIndex = 0
        Me.rb_cash.TabStop = True
        Me.rb_cash.Text = "Cash"
        Me.rb_cash.UseVisualStyleBackColor = True
        '
        'frm_collection_cash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(406, 316)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_hold)
        Me.Controls.Add(Me.lbl_customer)
        Me.Controls.Add(Me.lbl_orderid)
        Me.Controls.Add(Me.lbl_amount_due)
        Me.Controls.Add(Me.btn_paid)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.GunaPanel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_collection_cash"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cash Payment"
        Me.GunaPanel2.ResumeLayout(False)
        Me.GunaPanel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txt_ref.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbb_bank_option.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaPanel2 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents lbl_title As Guna.UI.WinForms.GunaLabel
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_paid As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lbl_amount_due As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_orderid As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_customer As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_hold As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rb_bank As RadioButton
    Friend WithEvents rb_cash As RadioButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_ref As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cbb_bank_option As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
End Class
