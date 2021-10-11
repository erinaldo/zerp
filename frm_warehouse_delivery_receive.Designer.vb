Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports Guna.UI.WinForms
Imports Inventory_Management.My
Imports Inventory_Management.My.Resources
Imports System.ComponentModel

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_warehouse_delivery_receive
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GunaPanel4 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_head = New Guna.UI.WinForms.GunaLabel()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_search = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.withholding_tax_percentage = New DevExpress.XtraEditors.LabelControl()
        Me.withholding_tax_amount = New DevExpress.XtraEditors.LabelControl()
        Me.is_withholding_tax_applied = New System.Windows.Forms.CheckBox()
        Me.cbb_discount = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_return_credit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_discount = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_count_by = New DevExpress.XtraEditors.TextEdit()
        Me.btn_print = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_supid = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_amount = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_ref = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.cbb_receipt = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.btn_mark = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_save = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_poid = New DevExpress.XtraEditors.TextEdit()
        Me.cbb_deliver = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.grid_order = New System.Windows.Forms.DataGridView()
        Me.cbb_supplier = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.col_pid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_model = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_total_received = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_qty_received = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_remaining = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_unit_price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GunaPanel4.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txt_search.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbb_discount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_return_credit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_discount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_count_by.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_amount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ref.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbb_receipt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_poid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbb_deliver.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_order, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbb_supplier.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaPanel4
        '
        Me.GunaPanel4.BackColor = System.Drawing.Color.Lavender
        Me.GunaPanel4.Controls.Add(Me.lbl_head)
        Me.GunaPanel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel4.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel4.Name = "GunaPanel4"
        Me.GunaPanel4.Size = New System.Drawing.Size(1073, 42)
        Me.GunaPanel4.TabIndex = 10
        '
        'lbl_head
        '
        Me.lbl_head.AutoSize = True
        Me.lbl_head.Font = New System.Drawing.Font("Tahoma", 16.0!)
        Me.lbl_head.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.lbl_head.Location = New System.Drawing.Point(12, 9)
        Me.lbl_head.Name = "lbl_head"
        Me.lbl_head.Size = New System.Drawing.Size(174, 27)
        Me.lbl_head.TabIndex = 1
        Me.lbl_head.Text = "Receive Delivery"
        '
        'PanelControl1
        '
        Me.PanelControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.PanelControl1.Controls.Add(Me.LabelControl16)
        Me.PanelControl1.Controls.Add(Me.txt_search)
        Me.PanelControl1.Controls.Add(Me.LabelControl10)
        Me.PanelControl1.Controls.Add(Me.withholding_tax_percentage)
        Me.PanelControl1.Controls.Add(Me.withholding_tax_amount)
        Me.PanelControl1.Controls.Add(Me.is_withholding_tax_applied)
        Me.PanelControl1.Controls.Add(Me.cbb_discount)
        Me.PanelControl1.Controls.Add(Me.LabelControl8)
        Me.PanelControl1.Controls.Add(Me.txt_return_credit)
        Me.PanelControl1.Controls.Add(Me.LabelControl9)
        Me.PanelControl1.Controls.Add(Me.txt_discount)
        Me.PanelControl1.Controls.Add(Me.LabelControl7)
        Me.PanelControl1.Controls.Add(Me.txt_count_by)
        Me.PanelControl1.Controls.Add(Me.btn_print)
        Me.PanelControl1.Controls.Add(Me.txt_supid)
        Me.PanelControl1.Controls.Add(Me.LabelControl4)
        Me.PanelControl1.Controls.Add(Me.txt_amount)
        Me.PanelControl1.Controls.Add(Me.LabelControl3)
        Me.PanelControl1.Controls.Add(Me.txt_ref)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.cbb_receipt)
        Me.PanelControl1.Controls.Add(Me.btn_mark)
        Me.PanelControl1.Controls.Add(Me.btn_save)
        Me.PanelControl1.Controls.Add(Me.LabelControl5)
        Me.PanelControl1.Controls.Add(Me.txt_poid)
        Me.PanelControl1.Controls.Add(Me.cbb_deliver)
        Me.PanelControl1.Controls.Add(Me.grid_order)
        Me.PanelControl1.Controls.Add(Me.cbb_supplier)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.LabelControl6)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 63)
        Me.PanelControl1.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.PanelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1033, 570)
        Me.PanelControl1.TabIndex = 53
        '
        'LabelControl16
        '
        Me.LabelControl16.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl16.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.LabelControl16.Appearance.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelControl16.Appearance.Options.UseFont = True
        Me.LabelControl16.Appearance.Options.UseForeColor = True
        Me.LabelControl16.Location = New System.Drawing.Point(787, 147)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(43, 16)
        Me.LabelControl16.TabIndex = 120
        Me.LabelControl16.Text = "Search"
        '
        'txt_search
        '
        Me.txt_search.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_search.Location = New System.Drawing.Point(836, 142)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txt_search.Properties.Appearance.Options.UseFont = True
        Me.txt_search.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_search.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txt_search.Size = New System.Drawing.Size(171, 24)
        Me.txt_search.TabIndex = 119
        Me.txt_search.TabStop = False
        '
        'LabelControl10
        '
        Me.LabelControl10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LabelControl10.Appearance.Options.UseFont = True
        Me.LabelControl10.Location = New System.Drawing.Point(986, 541)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(21, 14)
        Me.LabelControl10.TabIndex = 104
        Me.LabelControl10.Text = "Php"
        '
        'withholding_tax_percentage
        '
        Me.withholding_tax_percentage.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.withholding_tax_percentage.Appearance.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.withholding_tax_percentage.Appearance.Options.UseFont = True
        Me.withholding_tax_percentage.Location = New System.Drawing.Point(619, 548)
        Me.withholding_tax_percentage.Name = "withholding_tax_percentage"
        Me.withholding_tax_percentage.Size = New System.Drawing.Size(137, 13)
        Me.withholding_tax_percentage.TabIndex = 103
        Me.withholding_tax_percentage.Text = "withholding_tax_percentage"
        Me.withholding_tax_percentage.Visible = False
        '
        'withholding_tax_amount
        '
        Me.withholding_tax_amount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.withholding_tax_amount.Appearance.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.withholding_tax_amount.Appearance.Options.UseFont = True
        Me.withholding_tax_amount.Location = New System.Drawing.Point(619, 532)
        Me.withholding_tax_amount.Name = "withholding_tax_amount"
        Me.withholding_tax_amount.Size = New System.Drawing.Size(118, 13)
        Me.withholding_tax_amount.TabIndex = 102
        Me.withholding_tax_amount.Text = "withholding_tax_amount"
        Me.withholding_tax_amount.Visible = False
        '
        'is_withholding_tax_applied
        '
        Me.is_withholding_tax_applied.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.is_withholding_tax_applied.AutoSize = True
        Me.is_withholding_tax_applied.Location = New System.Drawing.Point(601, 514)
        Me.is_withholding_tax_applied.Name = "is_withholding_tax_applied"
        Me.is_withholding_tax_applied.Size = New System.Drawing.Size(155, 17)
        Me.is_withholding_tax_applied.TabIndex = 101
        Me.is_withholding_tax_applied.Text = "is_withholding_tax_applied"
        Me.is_withholding_tax_applied.UseVisualStyleBackColor = True
        Me.is_withholding_tax_applied.Visible = False
        '
        'cbb_discount
        '
        Me.cbb_discount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbb_discount.Location = New System.Drawing.Point(956, 509)
        Me.cbb_discount.Name = "cbb_discount"
        Me.cbb_discount.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.cbb_discount.Properties.Appearance.Options.UseFont = True
        Me.cbb_discount.Properties.Appearance.Options.UseTextOptions = True
        Me.cbb_discount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.cbb_discount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_discount.Properties.Items.AddRange(New Object() {"Php", "%"})
        Me.cbb_discount.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cbb_discount.Size = New System.Drawing.Size(51, 22)
        Me.cbb_discount.TabIndex = 100
        '
        'LabelControl8
        '
        Me.LabelControl8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Location = New System.Drawing.Point(799, 540)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(77, 14)
        Me.LabelControl8.TabIndex = 98
        Me.LabelControl8.Text = "Return Credit:"
        '
        'txt_return_credit
        '
        Me.txt_return_credit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_return_credit.EditValue = "0.00"
        Me.txt_return_credit.Location = New System.Drawing.Point(881, 538)
        Me.txt_return_credit.Name = "txt_return_credit"
        Me.txt_return_credit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_return_credit.Properties.Appearance.Options.UseFont = True
        Me.txt_return_credit.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_return_credit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txt_return_credit.Size = New System.Drawing.Size(101, 20)
        Me.txt_return_credit.TabIndex = 99
        '
        'LabelControl9
        '
        Me.LabelControl9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Location = New System.Drawing.Point(799, 513)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(51, 14)
        Me.LabelControl9.TabIndex = 97
        Me.LabelControl9.Text = "Discount:"
        '
        'txt_discount
        '
        Me.txt_discount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_discount.EditValue = "0.00"
        Me.txt_discount.Location = New System.Drawing.Point(881, 509)
        Me.txt_discount.Name = "txt_discount"
        Me.txt_discount.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_discount.Properties.Appearance.Options.UseFont = True
        Me.txt_discount.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_discount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txt_discount.Properties.AutoHeight = False
        Me.txt_discount.Size = New System.Drawing.Size(76, 22)
        Me.txt_discount.TabIndex = 96
        '
        'LabelControl7
        '
        Me.LabelControl7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Location = New System.Drawing.Point(683, 107)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(68, 14)
        Me.LabelControl7.TabIndex = 94
        Me.LabelControl7.Text = "Counted By:"
        '
        'txt_count_by
        '
        Me.txt_count_by.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_count_by.Location = New System.Drawing.Point(766, 104)
        Me.txt_count_by.Name = "txt_count_by"
        Me.txt_count_by.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_count_by.Properties.Appearance.Options.UseFont = True
        Me.txt_count_by.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_count_by.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txt_count_by.Size = New System.Drawing.Size(86, 20)
        Me.txt_count_by.TabIndex = 93
        '
        'btn_print
        '
        Me.btn_print.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_print.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_print.Appearance.Options.UseFont = True
        Me.btn_print.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.print_32x321
        Me.btn_print.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter
        Me.btn_print.Location = New System.Drawing.Point(881, 18)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(60, 60)
        Me.btn_print.TabIndex = 95
        Me.btn_print.Text = "Print"
        '
        'txt_supid
        '
        Me.txt_supid.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_supid.Appearance.Options.UseFont = True
        Me.txt_supid.Location = New System.Drawing.Point(427, 56)
        Me.txt_supid.Name = "txt_supid"
        Me.txt_supid.Size = New System.Drawing.Size(28, 14)
        Me.txt_supid.TabIndex = 92
        Me.txt_supid.Text = "supid"
        Me.txt_supid.Visible = False
        '
        'LabelControl4
        '
        Me.LabelControl4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(683, 80)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(48, 14)
        Me.LabelControl4.TabIndex = 91
        Me.LabelControl4.Text = "Amount:"
        '
        'txt_amount
        '
        Me.txt_amount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_amount.Location = New System.Drawing.Point(766, 77)
        Me.txt_amount.Name = "txt_amount"
        Me.txt_amount.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_amount.Properties.Appearance.Options.UseFont = True
        Me.txt_amount.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_amount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.txt_amount.Properties.AutoHeight = False
        Me.txt_amount.Size = New System.Drawing.Size(87, 21)
        Me.txt_amount.TabIndex = 90
        '
        'LabelControl3
        '
        Me.LabelControl3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(683, 53)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(73, 14)
        Me.LabelControl3.TabIndex = 89
        Me.LabelControl3.Text = "Reference #:"
        '
        'txt_ref
        '
        Me.txt_ref.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_ref.Location = New System.Drawing.Point(766, 50)
        Me.txt_ref.Name = "txt_ref"
        Me.txt_ref.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_ref.Properties.Appearance.Options.UseFont = True
        Me.txt_ref.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_ref.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.txt_ref.Properties.AutoHeight = False
        Me.txt_ref.Size = New System.Drawing.Size(87, 21)
        Me.txt_ref.TabIndex = 88
        '
        'LabelControl2
        '
        Me.LabelControl2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(683, 26)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(77, 14)
        Me.LabelControl2.TabIndex = 87
        Me.LabelControl2.Text = "Receipt Type:"
        '
        'cbb_receipt
        '
        Me.cbb_receipt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbb_receipt.Location = New System.Drawing.Point(766, 23)
        Me.cbb_receipt.Name = "cbb_receipt"
        Me.cbb_receipt.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cbb_receipt.Properties.Appearance.Options.UseFont = True
        Me.cbb_receipt.Properties.AutoHeight = False
        Me.cbb_receipt.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_receipt.Properties.Items.AddRange(New Object() {"DR", "SI-NV", "SI-VAT", "OR-NV", "OR-VAT"})
        Me.cbb_receipt.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cbb_receipt.Size = New System.Drawing.Size(87, 21)
        Me.cbb_receipt.TabIndex = 86
        '
        'btn_mark
        '
        Me.btn_mark.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_mark.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_mark.Appearance.Options.UseFont = True
        Me.btn_mark.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.checkbox_16x161
        Me.btn_mark.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_mark.Location = New System.Drawing.Point(20, 529)
        Me.btn_mark.Name = "btn_mark"
        Me.btn_mark.Size = New System.Drawing.Size(162, 32)
        Me.btn_mark.TabIndex = 85
        Me.btn_mark.Text = "Mark as Completed"
        '
        'btn_save
        '
        Me.btn_save.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_save.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.Appearance.Options.UseFont = True
        Me.btn_save.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.saveto_32x32
        Me.btn_save.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter
        Me.btn_save.Location = New System.Drawing.Point(947, 18)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(60, 60)
        Me.btn_save.TabIndex = 72
        Me.btn_save.Text = "Save"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(20, 30)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(69, 14)
        Me.LabelControl5.TabIndex = 69
        Me.LabelControl5.Text = "Purchase ID:"
        '
        'txt_poid
        '
        Me.txt_poid.Location = New System.Drawing.Point(96, 27)
        Me.txt_poid.Name = "txt_poid"
        Me.txt_poid.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_poid.Properties.Appearance.Options.UseFont = True
        Me.txt_poid.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_poid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txt_poid.Properties.ReadOnly = True
        Me.txt_poid.Size = New System.Drawing.Size(86, 20)
        Me.txt_poid.TabIndex = 70
        '
        'cbb_deliver
        '
        Me.cbb_deliver.Location = New System.Drawing.Point(96, 79)
        Me.cbb_deliver.Name = "cbb_deliver"
        Me.cbb_deliver.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cbb_deliver.Properties.Appearance.Options.UseFont = True
        Me.cbb_deliver.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_deliver.Properties.ReadOnly = True
        Me.cbb_deliver.Properties.UseReadOnlyAppearance = False
        Me.cbb_deliver.Size = New System.Drawing.Size(325, 20)
        Me.cbb_deliver.TabIndex = 65
        '
        'grid_order
        '
        Me.grid_order.AllowUserToAddRows = False
        Me.grid_order.AllowUserToDeleteRows = False
        Me.grid_order.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_order.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.grid_order.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.grid_order.BackgroundColor = System.Drawing.Color.GhostWhite
        Me.grid_order.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_order.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grid_order.ColumnHeadersHeight = 35
        Me.grid_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.grid_order.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_pid, Me.col_qty, Me.col_model, Me.col_description, Me.col_total_received, Me.col_qty_received, Me.col_remaining, Me.col_unit_price})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Tahoma", 8.25!)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(78, Byte), Integer))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grid_order.DefaultCellStyle = DataGridViewCellStyle8
        Me.grid_order.EnableHeadersVisualStyles = False
        Me.grid_order.Location = New System.Drawing.Point(20, 175)
        Me.grid_order.MultiSelect = False
        Me.grid_order.Name = "grid_order"
        Me.grid_order.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid_order.Size = New System.Drawing.Size(987, 324)
        Me.grid_order.TabIndex = 58
        '
        'cbb_supplier
        '
        Me.cbb_supplier.Location = New System.Drawing.Point(96, 53)
        Me.cbb_supplier.Name = "cbb_supplier"
        Me.cbb_supplier.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cbb_supplier.Properties.Appearance.Options.UseFont = True
        Me.cbb_supplier.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_supplier.Properties.ReadOnly = True
        Me.cbb_supplier.Properties.UseReadOnlyAppearance = False
        Me.cbb_supplier.Size = New System.Drawing.Size(325, 20)
        Me.cbb_supplier.TabIndex = 43
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(22, 59)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(47, 14)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Supplier:"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(21, 85)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(56, 14)
        Me.LabelControl6.TabIndex = 49
        Me.LabelControl6.Text = "Deliver to:"
        '
        'col_pid
        '
        Me.col_pid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.col_pid.DataPropertyName = "col_pid"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.col_pid.DefaultCellStyle = DataGridViewCellStyle2
        Me.col_pid.FillWeight = 80.0!
        Me.col_pid.HeaderText = "SKU"
        Me.col_pid.Name = "col_pid"
        Me.col_pid.ReadOnly = True
        Me.col_pid.Width = 80
        '
        'col_qty
        '
        Me.col_qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.col_qty.DataPropertyName = "col_qty"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle3.NullValue = Nothing
        Me.col_qty.DefaultCellStyle = DataGridViewCellStyle3
        Me.col_qty.FillWeight = 80.0!
        Me.col_qty.HeaderText = "QTY. Order"
        Me.col_qty.Name = "col_qty"
        Me.col_qty.ReadOnly = True
        Me.col_qty.Width = 80
        '
        'col_model
        '
        Me.col_model.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.col_model.DataPropertyName = "col_model"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.col_model.DefaultCellStyle = DataGridViewCellStyle4
        Me.col_model.FillWeight = 73.71088!
        Me.col_model.HeaderText = "Model"
        Me.col_model.Name = "col_model"
        Me.col_model.ReadOnly = True
        Me.col_model.Width = 125
        '
        'col_description
        '
        Me.col_description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.col_description.DataPropertyName = "col_description"
        Me.col_description.HeaderText = "Description"
        Me.col_description.Name = "col_description"
        Me.col_description.ReadOnly = True
        '
        'col_total_received
        '
        Me.col_total_received.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.col_total_received.DataPropertyName = "col_total_received"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.col_total_received.DefaultCellStyle = DataGridViewCellStyle5
        Me.col_total_received.HeaderText = "Total Qty Received"
        Me.col_total_received.Name = "col_total_received"
        Me.col_total_received.ReadOnly = True
        Me.col_total_received.Width = 80
        '
        'col_qty_received
        '
        Me.col_qty_received.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.col_qty_received.DataPropertyName = "col_qty_received"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.col_qty_received.DefaultCellStyle = DataGridViewCellStyle6
        Me.col_qty_received.FillWeight = 125.0!
        Me.col_qty_received.HeaderText = "QTY. Received"
        Me.col_qty_received.Name = "col_qty_received"
        Me.col_qty_received.Width = 80
        '
        'col_remaining
        '
        Me.col_remaining.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.col_remaining.DataPropertyName = "col_remaining"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.col_remaining.DefaultCellStyle = DataGridViewCellStyle7
        Me.col_remaining.FillWeight = 125.0!
        Me.col_remaining.HeaderText = "Remaining"
        Me.col_remaining.Name = "col_remaining"
        Me.col_remaining.ReadOnly = True
        Me.col_remaining.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.col_remaining.Width = 80
        '
        'col_unit_price
        '
        Me.col_unit_price.DataPropertyName = "col_unit_price"
        Me.col_unit_price.HeaderText = "Price"
        Me.col_unit_price.Name = "col_unit_price"
        Me.col_unit_price.Visible = False
        Me.col_unit_price.Width = 55
        '
        'frm_warehouse_delivery_receive
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(1073, 644)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.GunaPanel4)
        Me.Name = "frm_warehouse_delivery_receive"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frm_warehouse_delivery_receive"
        Me.GunaPanel4.ResumeLayout(False)
        Me.GunaPanel4.PerformLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.txt_search.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbb_discount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_return_credit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_discount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_count_by.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_amount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ref.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbb_receipt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_poid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbb_deliver.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_order, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbb_supplier.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaPanel4 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents lbl_head As Guna.UI.WinForms.GunaLabel
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_poid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cbb_deliver As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents grid_order As DataGridView
    Friend WithEvents cbb_supplier As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_save As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_mark As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbb_receipt As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_ref As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_amount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_supid As DevExpress.XtraEditors.LabelControl
	Friend WithEvents btn_print As DevExpress.XtraEditors.SimpleButton
	Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
	Friend WithEvents txt_count_by As DevExpress.XtraEditors.TextEdit
	Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
	Friend WithEvents txt_return_credit As DevExpress.XtraEditors.TextEdit
	Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
	Friend WithEvents txt_discount As DevExpress.XtraEditors.TextEdit
	Friend WithEvents cbb_discount As DevExpress.XtraEditors.ComboBoxEdit
	Friend WithEvents withholding_tax_percentage As DevExpress.XtraEditors.LabelControl
	Friend WithEvents withholding_tax_amount As DevExpress.XtraEditors.LabelControl
	Friend WithEvents is_withholding_tax_applied As CheckBox
	Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
	Friend WithEvents LabelControl16 As LabelControl
	Friend WithEvents txt_search As TextEdit
    Friend WithEvents col_pid As DataGridViewTextBoxColumn
    Friend WithEvents col_qty As DataGridViewTextBoxColumn
    Friend WithEvents col_model As DataGridViewTextBoxColumn
    Friend WithEvents col_description As DataGridViewTextBoxColumn
    Friend WithEvents col_total_received As DataGridViewTextBoxColumn
    Friend WithEvents col_qty_received As DataGridViewTextBoxColumn
    Friend WithEvents col_remaining As DataGridViewTextBoxColumn
    Friend WithEvents col_unit_price As DataGridViewTextBoxColumn
End Class
