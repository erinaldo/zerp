﻿Imports DevExpress.Data.Mask
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraSpreadsheet
Imports Guna.UI.WinForms
Imports System.ComponentModel

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_sales_customers_new
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_sales_customers_new))
        Me.lbl_title = New Guna.UI.WinForms.GunaLabel()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_fname = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_contact = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_address = New DevExpress.XtraEditors.MemoEdit()
        Me.btn_apply = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_cancel = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.num_terms = New Guna.UI.WinForms.GunaNumeric()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.cbb_account_type = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_trucking = New DevExpress.XtraEditors.MemoEdit()
        Me.cbb_shipping = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_customer_id = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_credit_limit = New DevExpress.XtraEditors.LabelControl()
        Me.txt_credit_limit = New DevExpress.XtraEditors.TextEdit()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.cbb_agents = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.panel_admin = New System.Windows.Forms.Panel()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_contact_person = New DevExpress.XtraEditors.TextEdit()
        Me.sheet_customer = New DevExpress.XtraSpreadsheet.SpreadsheetControl()
        Me.btn_delete_customer = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.grid_bank = New System.Windows.Forms.DataGridView()
        Me.col_bank = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_bank_acc_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_bank_acc_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.txt_fname.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_contact.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_address.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.cbb_account_type.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_trucking.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbb_shipping.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_credit_limit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.cbb_agents.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_admin.SuspendLayout()
        CType(Me.txt_contact_person.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.grid_bank, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lbl_title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.lbl_title.Location = New System.Drawing.Point(12, 15)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(194, 31)
        Me.lbl_title.TabIndex = 2
        Me.lbl_title.Text = "New Customer"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.749999!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.LineVisible = True
        Me.LabelControl1.Location = New System.Drawing.Point(17, 46)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(95, 16)
        Me.LabelControl1.TabIndex = 11
        Me.LabelControl1.Text = "Company Name:"
        '
        'txt_fname
        '
        Me.txt_fname.Location = New System.Drawing.Point(123, 42)
        Me.txt_fname.Name = "txt_fname"
        Me.txt_fname.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.749999!)
        Me.txt_fname.Properties.Appearance.Options.UseFont = True
        Me.txt_fname.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.txt_fname.Size = New System.Drawing.Size(306, 24)
        Me.txt_fname.TabIndex = 0
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.749999!)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.LineVisible = True
        Me.LabelControl3.Location = New System.Drawing.Point(16, 108)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(97, 16)
        Me.LabelControl3.TabIndex = 15
        Me.LabelControl3.Text = "Contact Number:"
        '
        'txt_contact
        '
        Me.txt_contact.Location = New System.Drawing.Point(123, 102)
        Me.txt_contact.Name = "txt_contact"
        Me.txt_contact.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.749999!)
        Me.txt_contact.Properties.Appearance.Options.UseFont = True
        Me.txt_contact.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.txt_contact.Size = New System.Drawing.Size(200, 24)
        Me.txt_contact.TabIndex = 2
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 9.749999!)
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.LineVisible = True
        Me.LabelControl4.Location = New System.Drawing.Point(16, 134)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(51, 16)
        Me.LabelControl4.TabIndex = 17
        Me.LabelControl4.Text = "Address:"
        '
        'txt_address
        '
        Me.txt_address.Location = New System.Drawing.Point(123, 132)
        Me.txt_address.Name = "txt_address"
        Me.txt_address.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.749999!)
        Me.txt_address.Properties.Appearance.Options.UseFont = True
        Me.txt_address.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.txt_address.Size = New System.Drawing.Size(306, 43)
        Me.txt_address.TabIndex = 3
        '
        'btn_apply
        '
        Me.btn_apply.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_apply.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_apply.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.btn_apply.Appearance.Options.UseBackColor = True
        Me.btn_apply.Appearance.Options.UseFont = True
        Me.btn_apply.Location = New System.Drawing.Point(928, 613)
        Me.btn_apply.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_apply.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_apply.Name = "btn_apply"
        Me.btn_apply.Size = New System.Drawing.Size(90, 33)
        Me.btn_apply.TabIndex = 10
        Me.btn_apply.Text = "Save"
        '
        'btn_cancel
        '
        Me.btn_cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_cancel.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.btn_cancel.Appearance.Options.UseFont = True
        Me.btn_cancel.Location = New System.Drawing.Point(832, 613)
        Me.btn_cancel.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_cancel.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(90, 33)
        Me.btn_cancel.TabIndex = 11
        Me.btn_cancel.Text = "Cancel"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.GhostWhite
        Me.Panel1.Controls.Add(Me.lbl_title)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1030, 60)
        Me.Panel1.TabIndex = 23
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.LineVisible = True
        Me.LabelControl2.Location = New System.Drawing.Point(252, 8)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(83, 16)
        Me.LabelControl2.TabIndex = 24
        Me.LabelControl2.Text = "Terms (days):"
        '
        'num_terms
        '
        Me.num_terms.BaseColor = System.Drawing.Color.White
        Me.num_terms.BorderColor = System.Drawing.Color.Silver
        Me.num_terms.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.num_terms.ButtonForeColor = System.Drawing.Color.White
        Me.num_terms.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.num_terms.ForeColor = System.Drawing.Color.Black
        Me.num_terms.Location = New System.Drawing.Point(357, 3)
        Me.num_terms.Maximum = CType(9999999, Long)
        Me.num_terms.Minimum = CType(0, Long)
        Me.num_terms.Name = "num_terms"
        Me.num_terms.Size = New System.Drawing.Size(65, 30)
        Me.num_terms.TabIndex = 8
        Me.num_terms.Text = "GunaNumeric1"
        Me.num_terms.Value = CType(0, Long)
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 9.749999!)
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.LineVisible = True
        Me.LabelControl5.Location = New System.Drawing.Point(16, 196)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(82, 16)
        Me.LabelControl5.TabIndex = 26
        Me.LabelControl5.Text = "Account Type:"
        '
        'cbb_account_type
        '
        Me.cbb_account_type.EditValue = "Regular"
        Me.cbb_account_type.Enabled = False
        Me.cbb_account_type.Location = New System.Drawing.Point(123, 191)
        Me.cbb_account_type.Name = "cbb_account_type"
        Me.cbb_account_type.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.749999!)
        Me.cbb_account_type.Properties.Appearance.Options.UseFont = True
        Me.cbb_account_type.Properties.AutoHeight = False
        Me.cbb_account_type.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_account_type.Properties.Items.AddRange(New Object() {"Regular", "Dealer", "VIP", "Sister Company"})
        Me.cbb_account_type.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cbb_account_type.Size = New System.Drawing.Size(128, 30)
        Me.cbb_account_type.TabIndex = 4
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 9.749999!)
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.LineVisible = True
        Me.LabelControl6.Location = New System.Drawing.Point(17, 264)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(84, 16)
        Me.LabelControl6.TabIndex = 28
        Me.LabelControl6.Text = "Trucking Note:"
        '
        'txt_trucking
        '
        Me.txt_trucking.Location = New System.Drawing.Point(123, 263)
        Me.txt_trucking.Name = "txt_trucking"
        Me.txt_trucking.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.749999!)
        Me.txt_trucking.Properties.Appearance.Options.UseFont = True
        Me.txt_trucking.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.txt_trucking.Size = New System.Drawing.Size(306, 45)
        Me.txt_trucking.TabIndex = 6
        '
        'cbb_shipping
        '
        Me.cbb_shipping.Location = New System.Drawing.Point(123, 227)
        Me.cbb_shipping.Name = "cbb_shipping"
        Me.cbb_shipping.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.749999!)
        Me.cbb_shipping.Properties.Appearance.Options.UseFont = True
        Me.cbb_shipping.Properties.AutoHeight = False
        Me.cbb_shipping.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_shipping.Properties.Items.AddRange(New Object() {"Pickup", "Delivery"})
        Me.cbb_shipping.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cbb_shipping.Size = New System.Drawing.Size(128, 30)
        Me.cbb_shipping.TabIndex = 5
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 9.749999!)
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.LineVisible = True
        Me.LabelControl7.Location = New System.Drawing.Point(16, 234)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(54, 16)
        Me.LabelControl7.TabIndex = 30
        Me.LabelControl7.Text = "Shipping:"
        '
        'lbl_customer_id
        '
        Me.lbl_customer_id.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.lbl_customer_id.Appearance.Options.UseFont = True
        Me.lbl_customer_id.LineVisible = True
        Me.lbl_customer_id.Location = New System.Drawing.Point(16, 31)
        Me.lbl_customer_id.Name = "lbl_customer_id"
        Me.lbl_customer_id.Size = New System.Drawing.Size(0, 16)
        Me.lbl_customer_id.TabIndex = 32
        Me.lbl_customer_id.Visible = False
        '
        'lbl_credit_limit
        '
        Me.lbl_credit_limit.Appearance.Font = New System.Drawing.Font("Tahoma", 9.749999!)
        Me.lbl_credit_limit.Appearance.Options.UseFont = True
        Me.lbl_credit_limit.LineVisible = True
        Me.lbl_credit_limit.Location = New System.Drawing.Point(3, 7)
        Me.lbl_credit_limit.Name = "lbl_credit_limit"
        Me.lbl_credit_limit.Size = New System.Drawing.Size(70, 16)
        Me.lbl_credit_limit.TabIndex = 33
        Me.lbl_credit_limit.Text = "Credit Limit:"
        '
        'txt_credit_limit
        '
        Me.txt_credit_limit.EditValue = "0.00"
        Me.txt_credit_limit.Location = New System.Drawing.Point(107, 4)
        Me.txt_credit_limit.Name = "txt_credit_limit"
        Me.txt_credit_limit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.749999!)
        Me.txt_credit_limit.Properties.Appearance.Options.UseFont = True
        Me.txt_credit_limit.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_credit_limit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_credit_limit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.txt_credit_limit.Properties.DisplayFormat.FormatString = "n2"
        Me.txt_credit_limit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_credit_limit.Properties.EditFormat.FormatString = "n2"
        Me.txt_credit_limit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_credit_limit.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txt_credit_limit.Properties.MaskSettings.Set("mask", "c")
        Me.txt_credit_limit.Size = New System.Drawing.Size(128, 24)
        Me.txt_credit_limit.TabIndex = 7
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.cbb_agents)
        Me.GroupControl1.Controls.Add(Me.LabelControl9)
        Me.GroupControl1.Controls.Add(Me.panel_admin)
        Me.GroupControl1.Controls.Add(Me.LabelControl8)
        Me.GroupControl1.Controls.Add(Me.txt_contact_person)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.txt_fname)
        Me.GroupControl1.Controls.Add(Me.txt_contact)
        Me.GroupControl1.Controls.Add(Me.lbl_customer_id)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.cbb_shipping)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.LabelControl7)
        Me.GroupControl1.Controls.Add(Me.txt_address)
        Me.GroupControl1.Controls.Add(Me.txt_trucking)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.cbb_account_type)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 71)
        Me.GroupControl1.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.GroupControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(452, 418)
        Me.GroupControl1.TabIndex = 35
        Me.GroupControl1.Text = "Customer Details"
        '
        'cbb_agents
        '
        Me.cbb_agents.EditValue = "Unassigned"
        Me.cbb_agents.Location = New System.Drawing.Point(126, 366)
        Me.cbb_agents.Name = "cbb_agents"
        Me.cbb_agents.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.749999!)
        Me.cbb_agents.Properties.Appearance.Options.UseFont = True
        Me.cbb_agents.Properties.AutoHeight = False
        Me.cbb_agents.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_agents.Properties.Items.AddRange(New Object() {"Unassigned"})
        Me.cbb_agents.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cbb_agents.Size = New System.Drawing.Size(170, 23)
        Me.cbb_agents.TabIndex = 38
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 9.749999!)
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.LineVisible = True
        Me.LabelControl9.Location = New System.Drawing.Point(19, 369)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(93, 16)
        Me.LabelControl9.TabIndex = 39
        Me.LabelControl9.Text = "Assigned Agent:"
        '
        'panel_admin
        '
        Me.panel_admin.Controls.Add(Me.txt_credit_limit)
        Me.panel_admin.Controls.Add(Me.num_terms)
        Me.panel_admin.Controls.Add(Me.LabelControl2)
        Me.panel_admin.Controls.Add(Me.lbl_credit_limit)
        Me.panel_admin.Location = New System.Drawing.Point(16, 318)
        Me.panel_admin.Name = "panel_admin"
        Me.panel_admin.Size = New System.Drawing.Size(431, 41)
        Me.panel_admin.TabIndex = 37
        Me.panel_admin.Visible = False
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Tahoma", 9.749999!)
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.LineVisible = True
        Me.LabelControl8.Location = New System.Drawing.Point(17, 76)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(91, 16)
        Me.LabelControl8.TabIndex = 35
        Me.LabelControl8.Text = "Contact Person:"
        '
        'txt_contact_person
        '
        Me.txt_contact_person.Location = New System.Drawing.Point(123, 72)
        Me.txt_contact_person.Name = "txt_contact_person"
        Me.txt_contact_person.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.749999!)
        Me.txt_contact_person.Properties.Appearance.Options.UseFont = True
        Me.txt_contact_person.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.txt_contact_person.Size = New System.Drawing.Size(200, 24)
        Me.txt_contact_person.TabIndex = 1
        '
        'sheet_customer
        '
        Me.sheet_customer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sheet_customer.Location = New System.Drawing.Point(475, 71)
        Me.sheet_customer.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.sheet_customer.LookAndFeel.UseDefaultLookAndFeel = False
        Me.sheet_customer.Name = "sheet_customer"
        Me.sheet_customer.Options.Behavior.Column.AutoFit = DevExpress.XtraSpreadsheet.DocumentCapability.Enabled
        Me.sheet_customer.Options.Behavior.Column.Resize = DevExpress.XtraSpreadsheet.DocumentCapability.Enabled
        Me.sheet_customer.Options.Behavior.Row.AutoFit = DevExpress.XtraSpreadsheet.DocumentCapability.Disabled
        Me.sheet_customer.Options.Behavior.Worksheet.Delete = DevExpress.XtraSpreadsheet.DocumentCapability.Disabled
        Me.sheet_customer.Options.Behavior.Worksheet.Hide = DevExpress.XtraSpreadsheet.DocumentCapability.Disabled
        Me.sheet_customer.Options.Behavior.Worksheet.Insert = DevExpress.XtraSpreadsheet.DocumentCapability.Disabled
        Me.sheet_customer.Options.Behavior.Worksheet.Rename = DevExpress.XtraSpreadsheet.DocumentCapability.Disabled
        Me.sheet_customer.Options.Behavior.Worksheet.Unhide = DevExpress.XtraSpreadsheet.DocumentCapability.Disabled
        Me.sheet_customer.Size = New System.Drawing.Size(543, 530)
        Me.sheet_customer.TabIndex = 9
        Me.sheet_customer.Text = "SpreadsheetControl1"
        '
        'btn_delete_customer
        '
        Me.btn_delete_customer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_delete_customer.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger
        Me.btn_delete_customer.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.btn_delete_customer.Appearance.Options.UseBackColor = True
        Me.btn_delete_customer.Appearance.Options.UseFont = True
        Me.btn_delete_customer.Location = New System.Drawing.Point(475, 613)
        Me.btn_delete_customer.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_delete_customer.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_delete_customer.Name = "btn_delete_customer"
        Me.btn_delete_customer.Size = New System.Drawing.Size(134, 33)
        Me.btn_delete_customer.TabIndex = 36
        Me.btn_delete_customer.Text = "Delete Customer"
        Me.btn_delete_customer.Visible = False
        '
        'GroupControl2
        '
        Me.GroupControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.Controls.Add(Me.grid_bank)
        Me.GroupControl2.Location = New System.Drawing.Point(12, 495)
        Me.GroupControl2.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.GroupControl2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(452, 151)
        Me.GroupControl2.TabIndex = 37
        Me.GroupControl2.Text = "Bank Details"
        '
        'grid_bank
        '
        Me.grid_bank.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_bank.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grid_bank.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_bank.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_bank, Me.col_bank_acc_no, Me.col_bank_acc_name})
        Me.grid_bank.Location = New System.Drawing.Point(11, 41)
        Me.grid_bank.Name = "grid_bank"
        Me.grid_bank.Size = New System.Drawing.Size(427, 95)
        Me.grid_bank.TabIndex = 0
        '
        'col_bank
        '
        Me.col_bank.HeaderText = "Bank"
        Me.col_bank.Name = "col_bank"
        '
        'col_bank_acc_no
        '
        Me.col_bank_acc_no.HeaderText = "Account No."
        Me.col_bank_acc_no.Name = "col_bank_acc_no"
        '
        'col_bank_acc_name
        '
        Me.col_bank_acc_name.HeaderText = "Account Name"
        Me.col_bank_acc_name.Name = "col_bank_acc_name"
        '
        'frm_sales_customers_new
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(1030, 658)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.btn_delete_customer)
        Me.Controls.Add(Me.sheet_customer)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_apply)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_sales_customers_new"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Customer"
        CType(Me.txt_fname.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_contact.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_address.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.cbb_account_type.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_trucking.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbb_shipping.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_credit_limit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.cbb_agents.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_admin.ResumeLayout(False)
        Me.panel_admin.PerformLayout()
        CType(Me.txt_contact_person.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.grid_bank, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbl_title As Guna.UI.WinForms.GunaLabel
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_fname As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_contact As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_address As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents btn_apply As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_cancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents num_terms As Guna.UI.WinForms.GunaNumeric
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbb_account_type As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_trucking As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents cbb_shipping As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_customer_id As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_credit_limit As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_credit_limit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_contact_person As DevExpress.XtraEditors.TextEdit
    Friend WithEvents sheet_customer As DevExpress.XtraSpreadsheet.SpreadsheetControl
    Friend WithEvents panel_admin As Panel
    Friend WithEvents cbb_agents As ComboBoxEdit
    Friend WithEvents LabelControl9 As LabelControl
    Friend WithEvents btn_delete_customer As SimpleButton
    Friend WithEvents GroupControl2 As GroupControl
    Friend WithEvents grid_bank As DataGridView
    Friend WithEvents col_bank As DataGridViewTextBoxColumn
    Friend WithEvents col_bank_acc_no As DataGridViewTextBoxColumn
    Friend WithEvents col_bank_acc_name As DataGridViewTextBoxColumn
End Class