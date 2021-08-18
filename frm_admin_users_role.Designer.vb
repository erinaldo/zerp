Imports DevExpress.LookAndFeel
Imports DevExpress.XtraEditors
Imports Guna.UI.WinForms
Imports System.ComponentModel
Imports System.Drawing.Drawing2D

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_admin_users_role
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_admin_users_role))
		Me.GunaPanel2 = New GunaPanel()
		Me.GunaPanel3 = New GunaPanel()
		Me.GunaPanel4 = New GunaPanel()
		Me.HyperlinkLabelControl1 = New HyperlinkLabelControl()
		Me.LabelControl6 = New LabelControl()
		Me.HyperlinkLabelControl2 = New HyperlinkLabelControl()
		Me.GunaLabel1 = New GunaLabel()
		Me.Panel1 = New Panel()
		Me.Panel2 = New Panel()
		Me.GroupControl2 = New GroupControl()
		Me.acc_username = New LabelControl()
		Me.LabelControl3 = New LabelControl()
		Me.acc_id = New LabelControl()
		Me.LabelControl5 = New LabelControl()
		Me.acc_role = New LabelControl()
		Me.acc_name = New LabelControl()
		Me.LabelControl2 = New LabelControl()
		Me.LabelControl1 = New LabelControl()
		Me.btn_save = New SimpleButton()
		Me.btn_close = New SimpleButton()
		Me.GroupControl1 = New GroupControl()
		Me.GroupControl7 = New GroupControl()
		Me.cb_stores = New CheckBox()
		Me.cb_suppliers = New CheckBox()
		Me.cb_settings = New CheckBox()
		Me.cb_user_accounts = New CheckBox()
		Me.cb_approvals = New CheckBox()
		Me.cb_price_book = New CheckBox()
		Me.GroupControl6 = New GroupControl()
		Me.cb_soa = New CheckBox()
		Me.cb_order_payments = New CheckBox()
		Me.cb_new_cheque_payment = New CheckBox()
		Me.cb_cheque_book = New CheckBox()
		Me.GroupControl8 = New GroupControl()
		Me.cb_account_payables = New CheckBox()
		Me.cb_generate = New CheckBox()
		Me.cb_payment_vouchers = New CheckBox()
		Me.cb_payment_cheques = New CheckBox()
		Me.GroupControl5 = New GroupControl()
		Me.cb_daily_delivery = New CheckBox()
		Me.cb_delivery_logs = New CheckBox()
		Me.cb_stock_management = New CheckBox()
		Me.cb_stock_inventory = New CheckBox()
		Me.GroupControl9 = New GroupControl()
		Me.cb_new_purchase = New CheckBox()
		Me.cb_purchase_orders = New CheckBox()
		Me.GroupControl4 = New GroupControl()
		Me.cb_orders = New CheckBox()
		Me.cb_transaction_invoice = New CheckBox()
		Me.cb_create_order = New CheckBox()
		Me.cb_customers = New CheckBox()
		Me.cb_packing_list = New CheckBox()
		Me.GroupControl10 = New GroupControl()
		Me.cb_pickup_deliveries = New CheckBox()
		Me.GroupControl3 = New GroupControl()
		Me.cb_catalogue = New CheckBox()
		Me.cb_inventory = New CheckBox()
		Me.cb_new_item = New CheckBox()
		Me.cb_import_catalogue = New CheckBox()
		Me.cb_export_catalogue = New CheckBox()
		Me.cb_logistics = New CheckBox()
		Me.GunaPanel2.SuspendLayout()
		Me.GunaPanel3.SuspendLayout()
		Me.GunaPanel4.SuspendLayout()
		Me.Panel1.SuspendLayout()
		Me.Panel2.SuspendLayout()
		DirectCast(Me.GroupControl2, ISupportInitialize).BeginInit()
		Me.GroupControl2.SuspendLayout()
		DirectCast(Me.GroupControl1, ISupportInitialize).BeginInit()
		Me.GroupControl1.SuspendLayout()
		DirectCast(Me.GroupControl7, ISupportInitialize).BeginInit()
		Me.GroupControl7.SuspendLayout()
		DirectCast(Me.GroupControl6, ISupportInitialize).BeginInit()
		Me.GroupControl6.SuspendLayout()
		DirectCast(Me.GroupControl8, ISupportInitialize).BeginInit()
		Me.GroupControl8.SuspendLayout()
		DirectCast(Me.GroupControl5, ISupportInitialize).BeginInit()
		Me.GroupControl5.SuspendLayout()
		DirectCast(Me.GroupControl9, ISupportInitialize).BeginInit()
		Me.GroupControl9.SuspendLayout()
		DirectCast(Me.GroupControl4, ISupportInitialize).BeginInit()
		Me.GroupControl4.SuspendLayout()
		DirectCast(Me.GroupControl10, ISupportInitialize).BeginInit()
		Me.GroupControl10.SuspendLayout()
		DirectCast(Me.GroupControl3, ISupportInitialize).BeginInit()
		Me.GroupControl3.SuspendLayout()
		Me.SuspendLayout()
		Me.GunaPanel2.BackColor = Color.GhostWhite
		Me.GunaPanel2.Controls.Add(Me.GunaPanel3)
		Me.GunaPanel2.Controls.Add(Me.GunaLabel1)
		Me.GunaPanel2.Dock = DockStyle.Top
		Me.GunaPanel2.Location = New Point(0, 0)
		Me.GunaPanel2.Name = "GunaPanel2"
		Me.GunaPanel2.Size = New System.Drawing.Size(1060, 78)
		Me.GunaPanel2.TabIndex = 14
		Me.GunaPanel3.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
		Me.GunaPanel3.BackColor = Color.Transparent
		Me.GunaPanel3.Controls.Add(Me.GunaPanel4)
		Me.GunaPanel3.Location = New Point(19, 44)
		Me.GunaPanel3.Name = "GunaPanel3"
		Me.GunaPanel3.Size = New System.Drawing.Size(1024, 27)
		Me.GunaPanel3.TabIndex = 5
		Me.GunaPanel4.Controls.Add(Me.HyperlinkLabelControl1)
		Me.GunaPanel4.Controls.Add(Me.LabelControl6)
		Me.GunaPanel4.Controls.Add(Me.HyperlinkLabelControl2)
		Me.GunaPanel4.Dock = DockStyle.Left
		Me.GunaPanel4.Location = New Point(0, 0)
		Me.GunaPanel4.Name = "GunaPanel4"
		Me.GunaPanel4.Size = New System.Drawing.Size(435, 27)
		Me.GunaPanel4.TabIndex = 1
		Me.HyperlinkLabelControl1.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, FontStyle.Bold, GraphicsUnit.Point, 0)
		Me.HyperlinkLabelControl1.Appearance.LinkColor = DXSkinColors.ForeColors.ControlText
		Me.HyperlinkLabelControl1.Appearance.Options.UseFont = True
		Me.HyperlinkLabelControl1.Appearance.Options.UseLinkColor = True
		Me.HyperlinkLabelControl1.AppearanceHovered.ForeColor = Color.FromArgb(0, 122, 204)
		Me.HyperlinkLabelControl1.AppearanceHovered.LinkColor = Color.FromArgb(0, 122, 204)
		Me.HyperlinkLabelControl1.AppearanceHovered.Options.UseForeColor = True
		Me.HyperlinkLabelControl1.AppearanceHovered.Options.UseLinkColor = True
		Me.HyperlinkLabelControl1.AppearancePressed.LinkColor = Color.FromArgb(0, 122, 204)
		Me.HyperlinkLabelControl1.AppearancePressed.Options.UseLinkColor = True
		Me.HyperlinkLabelControl1.Enabled = False
		Me.HyperlinkLabelControl1.LineStyle = DashStyle.Custom
		Me.HyperlinkLabelControl1.LinkBehavior = LinkBehavior.NeverUnderline
		Me.HyperlinkLabelControl1.Location = New Point(70, 5)
		Me.HyperlinkLabelControl1.Name = "HyperlinkLabelControl1"
		Me.HyperlinkLabelControl1.ShowLineShadow = False
		Me.HyperlinkLabelControl1.Size = New System.Drawing.Size(113, 18)
		Me.HyperlinkLabelControl1.TabIndex = 7
		Me.HyperlinkLabelControl1.Text = " Roles Assignment"
		Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
		Me.LabelControl6.Appearance.Options.UseFont = True
		Me.LabelControl6.Location = New Point(55, 7)
		Me.LabelControl6.Name = "LabelControl6"
		Me.LabelControl6.Size = New System.Drawing.Size(9, 14)
		Me.LabelControl6.TabIndex = 6
		Me.LabelControl6.Text = ">"
		Me.HyperlinkLabelControl2.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, FontStyle.Regular, GraphicsUnit.Point, 0)
		Me.HyperlinkLabelControl2.Appearance.LinkColor = DXSkinColors.ForeColors.ControlText
		Me.HyperlinkLabelControl2.Appearance.Options.UseFont = True
		Me.HyperlinkLabelControl2.Appearance.Options.UseLinkColor = True
		Me.HyperlinkLabelControl2.AppearanceDisabled.LinkColor = Color.FromArgb(0, 122, 204)
		Me.HyperlinkLabelControl2.AppearanceDisabled.Options.UseLinkColor = True
		Me.HyperlinkLabelControl2.AppearanceHovered.ForeColor = Color.FromArgb(0, 122, 204)
		Me.HyperlinkLabelControl2.AppearanceHovered.LinkColor = Color.FromArgb(0, 122, 204)
		Me.HyperlinkLabelControl2.AppearanceHovered.Options.UseForeColor = True
		Me.HyperlinkLabelControl2.AppearanceHovered.Options.UseLinkColor = True
		Me.HyperlinkLabelControl2.AppearancePressed.LinkColor = Color.FromArgb(0, 122, 204)
		Me.HyperlinkLabelControl2.AppearancePressed.Options.UseLinkColor = True
		Me.HyperlinkLabelControl2.LineStyle = DashStyle.Custom
		Me.HyperlinkLabelControl2.LinkBehavior = LinkBehavior.NeverUnderline
		Me.HyperlinkLabelControl2.Location = New Point(13, 5)
		Me.HyperlinkLabelControl2.Name = "HyperlinkLabelControl2"
		Me.HyperlinkLabelControl2.ShowLineShadow = False
		Me.HyperlinkLabelControl2.Size = New System.Drawing.Size(37, 18)
		Me.HyperlinkLabelControl2.TabIndex = 5
		Me.HyperlinkLabelControl2.Text = "Home"
		Me.GunaLabel1.AutoSize = True
		Me.GunaLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
		Me.GunaLabel1.ForeColor = Color.FromArgb(213, 115, 45)
		Me.GunaLabel1.Location = New Point(14, 10)
		Me.GunaLabel1.Name = "GunaLabel1"
		Me.GunaLabel1.Size = New System.Drawing.Size(233, 31)
		Me.GunaLabel1.TabIndex = 1
		Me.GunaLabel1.Text = "Roles Assignment"
		Me.Panel1.AutoScroll = True
		Me.Panel1.Controls.Add(Me.Panel2)
		Me.Panel1.Dock = DockStyle.Fill
		Me.Panel1.Location = New Point(0, 78)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(1060, 532)
		Me.Panel1.TabIndex = 0
		Me.Panel2.Anchor = AnchorStyles.Top
		Me.Panel2.BackColor = Color.White
		Me.Panel2.Controls.Add(Me.GroupControl2)
		Me.Panel2.Controls.Add(Me.btn_save)
		Me.Panel2.Controls.Add(Me.btn_close)
		Me.Panel2.Controls.Add(Me.GroupControl1)
		Me.Panel2.Location = New Point(12, 16)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(1036, 504)
		Me.Panel2.TabIndex = 32
		Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 10.0!, FontStyle.Bold)
		Me.GroupControl2.AppearanceCaption.Options.UseFont = True
		Me.GroupControl2.Controls.Add(Me.acc_username)
		Me.GroupControl2.Controls.Add(Me.LabelControl3)
		Me.GroupControl2.Controls.Add(Me.acc_id)
		Me.GroupControl2.Controls.Add(Me.LabelControl5)
		Me.GroupControl2.Controls.Add(Me.acc_role)
		Me.GroupControl2.Controls.Add(Me.acc_name)
		Me.GroupControl2.Controls.Add(Me.LabelControl2)
		Me.GroupControl2.Controls.Add(Me.LabelControl1)
		Me.GroupControl2.Location = New Point(20, 29)
		Me.GroupControl2.LookAndFeel.SkinName = "DevExpress Style"
		Me.GroupControl2.LookAndFeel.UseDefaultLookAndFeel = False
		Me.GroupControl2.Name = "GroupControl2"
		Me.GroupControl2.Size = New System.Drawing.Size(244, 198)
		Me.GroupControl2.TabIndex = 1
		Me.GroupControl2.Text = "User Details"
		Me.acc_username.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
		Me.acc_username.Appearance.Options.UseFont = True
		Me.acc_username.Location = New Point(119, 71)
		Me.acc_username.Name = "acc_username"
		Me.acc_username.Size = New System.Drawing.Size(42, 16)
		Me.acc_username.TabIndex = 7
		Me.acc_username.Text = "jzenery"
		Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, FontStyle.Bold)
		Me.LabelControl3.Appearance.Options.UseFont = True
		Me.LabelControl3.Location = New Point(25, 93)
		Me.LabelControl3.Name = "LabelControl3"
		Me.LabelControl3.Size = New System.Drawing.Size(40, 16)
		Me.LabelControl3.TabIndex = 6
		Me.LabelControl3.Text = "Name:"
		Me.acc_id.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
		Me.acc_id.Appearance.Options.UseFont = True
		Me.acc_id.Location = New Point(119, 49)
		Me.acc_id.Name = "acc_id"
		Me.acc_id.Size = New System.Drawing.Size(56, 16)
		Me.acc_id.TabIndex = 5
		Me.acc_id.Text = "00000001"
		Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, FontStyle.Bold)
		Me.LabelControl5.Appearance.Options.UseFont = True
		Me.LabelControl5.Location = New Point(23, 49)
		Me.LabelControl5.Name = "LabelControl5"
		Me.LabelControl5.Size = New System.Drawing.Size(77, 16)
		Me.LabelControl5.TabIndex = 4
		Me.LabelControl5.Text = "Account ID:"
		Me.acc_role.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
		Me.acc_role.Appearance.Options.UseFont = True
		Me.acc_role.Location = New Point(119, 135)
		Me.acc_role.Name = "acc_role"
		Me.acc_role.Size = New System.Drawing.Size(77, 16)
		Me.acc_role.TabIndex = 3
		Me.acc_role.Text = "Administrator"
		Me.acc_name.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
		Me.acc_name.Appearance.Options.UseFont = True
		Me.acc_name.Location = New Point(119, 93)
		Me.acc_name.Name = "acc_name"
		Me.acc_name.Size = New System.Drawing.Size(100, 16)
		Me.acc_name.TabIndex = 2
		Me.acc_name.Text = "John Zenery Bullo"
		Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, FontStyle.Bold)
		Me.LabelControl2.Appearance.Options.UseFont = True
		Me.LabelControl2.Location = New Point(25, 134)
		Me.LabelControl2.Name = "LabelControl2"
		Me.LabelControl2.Size = New System.Drawing.Size(33, 16)
		Me.LabelControl2.TabIndex = 1
		Me.LabelControl2.Text = "Role:"
		Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, FontStyle.Bold)
		Me.LabelControl1.Appearance.Options.UseFont = True
		Me.LabelControl1.Location = New Point(23, 71)
		Me.LabelControl1.Name = "LabelControl1"
		Me.LabelControl1.Size = New System.Drawing.Size(64, 16)
		Me.LabelControl1.TabIndex = 0
		Me.LabelControl1.Text = "Username"
		Me.btn_save.Appearance.BackColor = Color.DarkTurquoise
		Me.btn_save.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
		Me.btn_save.Appearance.Options.UseBackColor = True
		Me.btn_save.Appearance.Options.UseFont = True
		Me.btn_save.Location = New Point(139, 233)
		Me.btn_save.LookAndFeel.SkinName = "Office 2010 Blue"
		Me.btn_save.LookAndFeel.UseDefaultLookAndFeel = False
		Me.btn_save.Name = "btn_save"
		Me.btn_save.Size = New System.Drawing.Size(125, 33)
		Me.btn_save.TabIndex = 31
		Me.btn_save.Text = "Apply"
		Me.btn_close.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
		Me.btn_close.Appearance.Options.UseFont = True
		Me.btn_close.Location = New Point(20, 233)
		Me.btn_close.LookAndFeel.SkinName = "Office 2010 Blue"
		Me.btn_close.LookAndFeel.UseDefaultLookAndFeel = False
		Me.btn_close.Name = "btn_close"
		Me.btn_close.Size = New System.Drawing.Size(113, 33)
		Me.btn_close.TabIndex = 30
		Me.btn_close.Text = "Close"
		Me.GroupControl1.Appearance.BackColor = Color.White
		Me.GroupControl1.Appearance.Options.UseBackColor = True
		Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 10.0!, FontStyle.Bold)
		Me.GroupControl1.AppearanceCaption.Options.UseFont = True
		Me.GroupControl1.Controls.Add(Me.GroupControl7)
		Me.GroupControl1.Controls.Add(Me.GroupControl6)
		Me.GroupControl1.Controls.Add(Me.GroupControl8)
		Me.GroupControl1.Controls.Add(Me.GroupControl5)
		Me.GroupControl1.Controls.Add(Me.GroupControl9)
		Me.GroupControl1.Controls.Add(Me.GroupControl4)
		Me.GroupControl1.Controls.Add(Me.GroupControl10)
		Me.GroupControl1.Controls.Add(Me.GroupControl3)
		Me.GroupControl1.Location = New Point(280, 29)
		Me.GroupControl1.LookAndFeel.SkinName = "DevExpress Style"
		Me.GroupControl1.LookAndFeel.UseDefaultLookAndFeel = False
		Me.GroupControl1.Name = "GroupControl1"
		Me.GroupControl1.Size = New System.Drawing.Size(754, 438)
		Me.GroupControl1.TabIndex = 0
		Me.GroupControl1.Text = "Account Roles"
		Me.GroupControl7.Controls.Add(Me.cb_stores)
		Me.GroupControl7.Controls.Add(Me.cb_suppliers)
		Me.GroupControl7.Controls.Add(Me.cb_settings)
		Me.GroupControl7.Controls.Add(Me.cb_user_accounts)
		Me.GroupControl7.Controls.Add(Me.cb_approvals)
		Me.GroupControl7.Controls.Add(Me.cb_price_book)
		Me.GroupControl7.Location = New Point(556, 233)
		Me.GroupControl7.Name = "GroupControl7"
		Me.GroupControl7.Size = New System.Drawing.Size(169, 178)
		Me.GroupControl7.TabIndex = 25
		Me.GroupControl7.Text = "Administration"
		Me.cb_stores.AutoSize = True
		Me.cb_stores.Location = New Point(23, 109)
		Me.cb_stores.Name = "cb_stores"
		Me.cb_stores.Size = New System.Drawing.Size(57, 17)
		Me.cb_stores.TabIndex = 16
		Me.cb_stores.Text = "Stores"
		Me.cb_stores.UseVisualStyleBackColor = True
		Me.cb_suppliers.AutoSize = True
		Me.cb_suppliers.Location = New Point(23, 131)
		Me.cb_suppliers.Name = "cb_suppliers"
		Me.cb_suppliers.Size = New System.Drawing.Size(69, 17)
		Me.cb_suppliers.TabIndex = 17
		Me.cb_suppliers.Text = "Suppliers"
		Me.cb_suppliers.UseVisualStyleBackColor = True
		Me.cb_settings.AutoSize = True
		Me.cb_settings.Location = New Point(23, 152)
		Me.cb_settings.Name = "cb_settings"
		Me.cb_settings.Size = New System.Drawing.Size(65, 17)
		Me.cb_settings.TabIndex = 18
		Me.cb_settings.Text = "Settings"
		Me.cb_settings.UseVisualStyleBackColor = True
		Me.cb_user_accounts.AutoSize = True
		Me.cb_user_accounts.Location = New Point(23, 40)
		Me.cb_user_accounts.Name = "cb_user_accounts"
		Me.cb_user_accounts.Size = New System.Drawing.Size(95, 17)
		Me.cb_user_accounts.TabIndex = 13
		Me.cb_user_accounts.Text = "User Accounts"
		Me.cb_user_accounts.UseVisualStyleBackColor = True
		Me.cb_approvals.AutoSize = True
		Me.cb_approvals.Location = New Point(23, 63)
		Me.cb_approvals.Name = "cb_approvals"
		Me.cb_approvals.Size = New System.Drawing.Size(74, 17)
		Me.cb_approvals.TabIndex = 14
		Me.cb_approvals.Text = "Approvals"
		Me.cb_approvals.UseVisualStyleBackColor = True
		Me.cb_price_book.AutoSize = True
		Me.cb_price_book.Location = New Point(23, 86)
		Me.cb_price_book.Name = "cb_price_book"
		Me.cb_price_book.Size = New System.Drawing.Size(75, 17)
		Me.cb_price_book.TabIndex = 15
		Me.cb_price_book.Text = "Price Book"
		Me.cb_price_book.UseVisualStyleBackColor = True
		Me.GroupControl6.Controls.Add(Me.cb_soa)
		Me.GroupControl6.Controls.Add(Me.cb_order_payments)
		Me.GroupControl6.Controls.Add(Me.cb_new_cheque_payment)
		Me.GroupControl6.Controls.Add(Me.cb_cheque_book)
		Me.GroupControl6.Location = New Point(556, 49)
		Me.GroupControl6.Name = "GroupControl6"
		Me.GroupControl6.Size = New System.Drawing.Size(169, 178)
		Me.GroupControl6.TabIndex = 21
		Me.GroupControl6.Text = "Collections"
		Me.cb_soa.AutoSize = True
		Me.cb_soa.Location = New Point(23, 109)
		Me.cb_soa.Name = "cb_soa"
		Me.cb_soa.Size = New System.Drawing.Size(131, 17)
		Me.cb_soa.TabIndex = 16
		Me.cb_soa.Text = "Statement of Account"
		Me.cb_soa.UseVisualStyleBackColor = True
		Me.cb_order_payments.AutoSize = True
		Me.cb_order_payments.Location = New Point(23, 40)
		Me.cb_order_payments.Name = "cb_order_payments"
		Me.cb_order_payments.Size = New System.Drawing.Size(104, 17)
		Me.cb_order_payments.TabIndex = 13
		Me.cb_order_payments.Text = "Order Payments"
		Me.cb_order_payments.UseVisualStyleBackColor = True
		Me.cb_new_cheque_payment.AutoSize = True
		Me.cb_new_cheque_payment.Location = New Point(23, 63)
		Me.cb_new_cheque_payment.Name = "cb_new_cheque_payment"
		Me.cb_new_cheque_payment.Size = New System.Drawing.Size(132, 17)
		Me.cb_new_cheque_payment.TabIndex = 14
		Me.cb_new_cheque_payment.Text = "New Cheque Payment"
		Me.cb_new_cheque_payment.UseVisualStyleBackColor = True
		Me.cb_cheque_book.AutoSize = True
		Me.cb_cheque_book.Location = New Point(23, 86)
		Me.cb_cheque_book.Name = "cb_cheque_book"
		Me.cb_cheque_book.Size = New System.Drawing.Size(89, 17)
		Me.cb_cheque_book.TabIndex = 15
		Me.cb_cheque_book.Text = "Cheque Book"
		Me.cb_cheque_book.UseVisualStyleBackColor = True
		Me.GroupControl8.Controls.Add(Me.cb_account_payables)
		Me.GroupControl8.Controls.Add(Me.cb_generate)
		Me.GroupControl8.Controls.Add(Me.cb_payment_vouchers)
		Me.GroupControl8.Controls.Add(Me.cb_payment_cheques)
		Me.GroupControl8.Location = New Point(381, 233)
		Me.GroupControl8.Name = "GroupControl8"
		Me.GroupControl8.Size = New System.Drawing.Size(169, 178)
		Me.GroupControl8.TabIndex = 24
		Me.GroupControl8.Text = "Accounting"
		Me.cb_account_payables.AutoSize = True
		Me.cb_account_payables.Location = New Point(23, 40)
		Me.cb_account_payables.Name = "cb_account_payables"
		Me.cb_account_payables.Size = New System.Drawing.Size(111, 17)
		Me.cb_account_payables.TabIndex = 13
		Me.cb_account_payables.Text = "Account Payables"
		Me.cb_account_payables.UseVisualStyleBackColor = True
		Me.cb_generate.AutoSize = True
		Me.cb_generate.Location = New Point(23, 63)
		Me.cb_generate.Name = "cb_generate"
		Me.cb_generate.Size = New System.Drawing.Size(71, 17)
		Me.cb_generate.TabIndex = 14
		Me.cb_generate.Text = "Generate"
		Me.cb_generate.UseVisualStyleBackColor = True
		Me.cb_payment_vouchers.AutoSize = True
		Me.cb_payment_vouchers.Location = New Point(23, 86)
		Me.cb_payment_vouchers.Name = "cb_payment_vouchers"
		Me.cb_payment_vouchers.Size = New System.Drawing.Size(115, 17)
		Me.cb_payment_vouchers.TabIndex = 15
		Me.cb_payment_vouchers.Text = "Payment Vouchers"
		Me.cb_payment_vouchers.UseVisualStyleBackColor = True
		Me.cb_payment_cheques.AutoSize = True
		Me.cb_payment_cheques.Location = New Point(23, 109)
		Me.cb_payment_cheques.Name = "cb_payment_cheques"
		Me.cb_payment_cheques.Size = New System.Drawing.Size(113, 17)
		Me.cb_payment_cheques.TabIndex = 16
		Me.cb_payment_cheques.Text = "Payment Cheques"
		Me.cb_payment_cheques.UseVisualStyleBackColor = True
		Me.GroupControl5.Controls.Add(Me.cb_daily_delivery)
		Me.GroupControl5.Controls.Add(Me.cb_delivery_logs)
		Me.GroupControl5.Controls.Add(Me.cb_stock_management)
		Me.GroupControl5.Controls.Add(Me.cb_stock_inventory)
		Me.GroupControl5.Location = New Point(381, 49)
		Me.GroupControl5.Name = "GroupControl5"
		Me.GroupControl5.Size = New System.Drawing.Size(169, 178)
		Me.GroupControl5.TabIndex = 20
		Me.GroupControl5.Text = "Warehouse"
		Me.cb_daily_delivery.AutoSize = True
		Me.cb_daily_delivery.Location = New Point(23, 40)
		Me.cb_daily_delivery.Name = "cb_daily_delivery"
		Me.cb_daily_delivery.Size = New System.Drawing.Size(91, 17)
		Me.cb_daily_delivery.TabIndex = 13
		Me.cb_daily_delivery.Text = "Daily Delivery"
		Me.cb_daily_delivery.UseVisualStyleBackColor = True
		Me.cb_delivery_logs.AutoSize = True
		Me.cb_delivery_logs.Location = New Point(23, 63)
		Me.cb_delivery_logs.Name = "cb_delivery_logs"
		Me.cb_delivery_logs.Size = New System.Drawing.Size(90, 17)
		Me.cb_delivery_logs.TabIndex = 14
		Me.cb_delivery_logs.Text = "Delivery Logs"
		Me.cb_delivery_logs.UseVisualStyleBackColor = True
		Me.cb_stock_management.AutoSize = True
		Me.cb_stock_management.Location = New Point(23, 86)
		Me.cb_stock_management.Name = "cb_stock_management"
		Me.cb_stock_management.Size = New System.Drawing.Size(117, 17)
		Me.cb_stock_management.TabIndex = 15
		Me.cb_stock_management.Text = "Stock Management"
		Me.cb_stock_management.UseVisualStyleBackColor = True
		Me.cb_stock_inventory.AutoSize = True
		Me.cb_stock_inventory.Location = New Point(23, 109)
		Me.cb_stock_inventory.Name = "cb_stock_inventory"
		Me.cb_stock_inventory.Size = New System.Drawing.Size(103, 17)
		Me.cb_stock_inventory.TabIndex = 16
		Me.cb_stock_inventory.Text = "Stock Inventory"
		Me.cb_stock_inventory.UseVisualStyleBackColor = True
		Me.GroupControl9.Controls.Add(Me.cb_new_purchase)
		Me.GroupControl9.Controls.Add(Me.cb_purchase_orders)
		Me.GroupControl9.Location = New Point(206, 233)
		Me.GroupControl9.Name = "GroupControl9"
		Me.GroupControl9.Size = New System.Drawing.Size(169, 178)
		Me.GroupControl9.TabIndex = 23
		Me.GroupControl9.Text = "Purchasing"
		Me.cb_new_purchase.AutoSize = True
		Me.cb_new_purchase.Location = New Point(23, 40)
		Me.cb_new_purchase.Name = "cb_new_purchase"
		Me.cb_new_purchase.Size = New System.Drawing.Size(94, 17)
		Me.cb_new_purchase.TabIndex = 7
		Me.cb_new_purchase.Text = "New Purchase"
		Me.cb_new_purchase.UseVisualStyleBackColor = True
		Me.cb_purchase_orders.AutoSize = True
		Me.cb_purchase_orders.Location = New Point(23, 63)
		Me.cb_purchase_orders.Name = "cb_purchase_orders"
		Me.cb_purchase_orders.Size = New System.Drawing.Size(106, 17)
		Me.cb_purchase_orders.TabIndex = 8
		Me.cb_purchase_orders.Text = "Purchase Orders"
		Me.cb_purchase_orders.UseVisualStyleBackColor = True
		Me.GroupControl4.Controls.Add(Me.cb_logistics)
		Me.GroupControl4.Controls.Add(Me.cb_orders)
		Me.GroupControl4.Controls.Add(Me.cb_transaction_invoice)
		Me.GroupControl4.Controls.Add(Me.cb_create_order)
		Me.GroupControl4.Controls.Add(Me.cb_customers)
		Me.GroupControl4.Controls.Add(Me.cb_packing_list)
		Me.GroupControl4.Location = New Point(206, 49)
		Me.GroupControl4.Name = "GroupControl4"
		Me.GroupControl4.Size = New System.Drawing.Size(169, 178)
		Me.GroupControl4.TabIndex = 19
		Me.GroupControl4.Text = "Sales"
		Me.cb_orders.AutoSize = True
		Me.cb_orders.Location = New Point(23, 40)
		Me.cb_orders.Name = "cb_orders"
		Me.cb_orders.Size = New System.Drawing.Size(59, 17)
		Me.cb_orders.TabIndex = 7
		Me.cb_orders.Text = "Orders"
		Me.cb_orders.UseVisualStyleBackColor = True
		Me.cb_transaction_invoice.AutoSize = True
		Me.cb_transaction_invoice.Location = New Point(23, 132)
		Me.cb_transaction_invoice.Name = "cb_transaction_invoice"
		Me.cb_transaction_invoice.Size = New System.Drawing.Size(120, 17)
		Me.cb_transaction_invoice.TabIndex = 1
		Me.cb_transaction_invoice.Text = "Transaction Invoice"
		Me.cb_transaction_invoice.UseVisualStyleBackColor = True
		Me.cb_create_order.AutoSize = True
		Me.cb_create_order.Location = New Point(23, 63)
		Me.cb_create_order.Name = "cb_create_order"
		Me.cb_create_order.Size = New System.Drawing.Size(90, 17)
		Me.cb_create_order.TabIndex = 8
		Me.cb_create_order.Text = "Create Order"
		Me.cb_create_order.UseVisualStyleBackColor = True
		Me.cb_customers.AutoSize = True
		Me.cb_customers.Location = New Point(23, 86)
		Me.cb_customers.Name = "cb_customers"
		Me.cb_customers.Size = New System.Drawing.Size(77, 17)
		Me.cb_customers.TabIndex = 9
		Me.cb_customers.Text = "Customers"
		Me.cb_customers.UseVisualStyleBackColor = True
		Me.cb_packing_list.AutoSize = True
		Me.cb_packing_list.Location = New Point(23, 109)
		Me.cb_packing_list.Name = "cb_packing_list"
		Me.cb_packing_list.Size = New System.Drawing.Size(81, 17)
		Me.cb_packing_list.TabIndex = 10
		Me.cb_packing_list.Text = "Packing List"
		Me.cb_packing_list.UseVisualStyleBackColor = True
		Me.GroupControl10.Controls.Add(Me.cb_pickup_deliveries)
		Me.GroupControl10.Location = New Point(31, 233)
		Me.GroupControl10.Name = "GroupControl10"
		Me.GroupControl10.Size = New System.Drawing.Size(169, 178)
		Me.GroupControl10.TabIndex = 22
		Me.GroupControl10.Text = "Logistics"
		Me.cb_pickup_deliveries.AutoSize = True
		Me.cb_pickup_deliveries.Location = New Point(23, 40)
		Me.cb_pickup_deliveries.Name = "cb_pickup_deliveries"
		Me.cb_pickup_deliveries.Size = New System.Drawing.Size(126, 17)
		Me.cb_pickup_deliveries.TabIndex = 0
		Me.cb_pickup_deliveries.Text = "Pickup and Deliveries"
		Me.cb_pickup_deliveries.UseVisualStyleBackColor = True
		Me.GroupControl3.Controls.Add(Me.cb_catalogue)
		Me.GroupControl3.Controls.Add(Me.cb_inventory)
		Me.GroupControl3.Controls.Add(Me.cb_new_item)
		Me.GroupControl3.Controls.Add(Me.cb_import_catalogue)
		Me.GroupControl3.Controls.Add(Me.cb_export_catalogue)
		Me.GroupControl3.Location = New Point(31, 49)
		Me.GroupControl3.Name = "GroupControl3"
		Me.GroupControl3.Size = New System.Drawing.Size(169, 178)
		Me.GroupControl3.TabIndex = 18
		Me.GroupControl3.Text = "Products"
		Me.cb_catalogue.AutoSize = True
		Me.cb_catalogue.Location = New Point(23, 40)
		Me.cb_catalogue.Name = "cb_catalogue"
		Me.cb_catalogue.Size = New System.Drawing.Size(75, 17)
		Me.cb_catalogue.TabIndex = 0
		Me.cb_catalogue.Text = "Catalogue"
		Me.cb_catalogue.UseVisualStyleBackColor = True
		Me.cb_inventory.AutoSize = True
		Me.cb_inventory.Location = New Point(23, 63)
		Me.cb_inventory.Name = "cb_inventory"
		Me.cb_inventory.Size = New System.Drawing.Size(74, 17)
		Me.cb_inventory.TabIndex = 1
		Me.cb_inventory.Text = "Inventory"
		Me.cb_inventory.UseVisualStyleBackColor = True
		Me.cb_new_item.AutoSize = True
		Me.cb_new_item.Location = New Point(23, 86)
		Me.cb_new_item.Name = "cb_new_item"
		Me.cb_new_item.Size = New System.Drawing.Size(72, 17)
		Me.cb_new_item.TabIndex = 2
		Me.cb_new_item.Text = "New Item"
		Me.cb_new_item.UseVisualStyleBackColor = True
		Me.cb_import_catalogue.AutoSize = True
		Me.cb_import_catalogue.Location = New Point(23, 109)
		Me.cb_import_catalogue.Name = "cb_import_catalogue"
		Me.cb_import_catalogue.Size = New System.Drawing.Size(110, 17)
		Me.cb_import_catalogue.TabIndex = 3
		Me.cb_import_catalogue.Text = "Import Catalogue"
		Me.cb_import_catalogue.UseVisualStyleBackColor = True
		Me.cb_export_catalogue.AutoSize = True
		Me.cb_export_catalogue.Location = New Point(23, 132)
		Me.cb_export_catalogue.Name = "cb_export_catalogue"
		Me.cb_export_catalogue.Size = New System.Drawing.Size(110, 17)
		Me.cb_export_catalogue.TabIndex = 4
		Me.cb_export_catalogue.Text = "Export Catalogue"
		Me.cb_export_catalogue.UseVisualStyleBackColor = True
		Me.cb_logistics.AutoSize = True
		Me.cb_logistics.Location = New Point(23, 155)
		Me.cb_logistics.Name = "cb_logistics"
		Me.cb_logistics.Size = New System.Drawing.Size(66, 17)
		Me.cb_logistics.TabIndex = 11
		Me.cb_logistics.Text = "Logistics"
		Me.cb_logistics.UseVisualStyleBackColor = True
		Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = Color.White
		Me.ClientSize = New System.Drawing.Size(1060, 610)
		Me.Controls.Add(Me.Panel1)
		Me.Controls.Add(Me.GunaPanel2)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Icon = DirectCast(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "frm_admin_users_role"
		Me.StartPosition = FormStartPosition.CenterScreen
		Me.Text = "User Access Assignment"
		Me.GunaPanel2.ResumeLayout(False)
		Me.GunaPanel2.PerformLayout()
		Me.GunaPanel3.ResumeLayout(False)
		Me.GunaPanel4.ResumeLayout(False)
		Me.GunaPanel4.PerformLayout()
		Me.Panel1.ResumeLayout(False)
		Me.Panel2.ResumeLayout(False)
		DirectCast(Me.GroupControl2, ISupportInitialize).EndInit()
		Me.GroupControl2.ResumeLayout(False)
		Me.GroupControl2.PerformLayout()
		DirectCast(Me.GroupControl1, ISupportInitialize).EndInit()
		Me.GroupControl1.ResumeLayout(False)
		DirectCast(Me.GroupControl7, ISupportInitialize).EndInit()
		Me.GroupControl7.ResumeLayout(False)
		Me.GroupControl7.PerformLayout()
		DirectCast(Me.GroupControl6, ISupportInitialize).EndInit()
		Me.GroupControl6.ResumeLayout(False)
		Me.GroupControl6.PerformLayout()
		DirectCast(Me.GroupControl8, ISupportInitialize).EndInit()
		Me.GroupControl8.ResumeLayout(False)
		Me.GroupControl8.PerformLayout()
		DirectCast(Me.GroupControl5, ISupportInitialize).EndInit()
		Me.GroupControl5.ResumeLayout(False)
		Me.GroupControl5.PerformLayout()
		DirectCast(Me.GroupControl9, ISupportInitialize).EndInit()
		Me.GroupControl9.ResumeLayout(False)
		Me.GroupControl9.PerformLayout()
		DirectCast(Me.GroupControl4, ISupportInitialize).EndInit()
		Me.GroupControl4.ResumeLayout(False)
		Me.GroupControl4.PerformLayout()
		DirectCast(Me.GroupControl10, ISupportInitialize).EndInit()
		Me.GroupControl10.ResumeLayout(False)
		Me.GroupControl10.PerformLayout()
		DirectCast(Me.GroupControl3, ISupportInitialize).EndInit()
		Me.GroupControl3.ResumeLayout(False)
		Me.GroupControl3.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents GunaPanel2 As Guna.UI.WinForms.GunaPanel
	Friend WithEvents GunaPanel3 As Guna.UI.WinForms.GunaPanel
	Friend WithEvents GunaPanel4 As Guna.UI.WinForms.GunaPanel
	Friend WithEvents HyperlinkLabelControl1 As DevExpress.XtraEditors.HyperlinkLabelControl
	Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
	Friend WithEvents HyperlinkLabelControl2 As DevExpress.XtraEditors.HyperlinkLabelControl
	Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
	Friend WithEvents Panel1 As Panel
	Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
	Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
	Friend WithEvents acc_role As DevExpress.XtraEditors.LabelControl
	Friend WithEvents acc_name As DevExpress.XtraEditors.LabelControl
	Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
	Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
	Friend WithEvents acc_id As DevExpress.XtraEditors.LabelControl
	Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
	Friend WithEvents cb_catalogue As CheckBox
	Friend WithEvents cb_import_catalogue As CheckBox
	Friend WithEvents cb_new_item As CheckBox
	Friend WithEvents cb_inventory As CheckBox
	Friend WithEvents cb_export_catalogue As CheckBox
	Friend WithEvents btn_save As DevExpress.XtraEditors.SimpleButton
	Friend WithEvents btn_close As DevExpress.XtraEditors.SimpleButton
	Friend WithEvents cb_packing_list As CheckBox
	Friend WithEvents cb_customers As CheckBox
	Friend WithEvents cb_create_order As CheckBox
	Friend WithEvents cb_orders As CheckBox
	Friend WithEvents GroupControl5 As DevExpress.XtraEditors.GroupControl
	Friend WithEvents cb_daily_delivery As CheckBox
	Friend WithEvents cb_delivery_logs As CheckBox
	Friend WithEvents cb_stock_management As CheckBox
	Friend WithEvents cb_stock_inventory As CheckBox
	Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
	Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
	Friend WithEvents GroupControl6 As DevExpress.XtraEditors.GroupControl
	Friend WithEvents cb_order_payments As CheckBox
	Friend WithEvents cb_new_cheque_payment As CheckBox
	Friend WithEvents cb_cheque_book As CheckBox
	Friend WithEvents GroupControl7 As DevExpress.XtraEditors.GroupControl
	Friend WithEvents cb_user_accounts As CheckBox
	Friend WithEvents cb_approvals As CheckBox
	Friend WithEvents cb_price_book As CheckBox
	Friend WithEvents GroupControl8 As DevExpress.XtraEditors.GroupControl
	Friend WithEvents cb_account_payables As CheckBox
	Friend WithEvents cb_generate As CheckBox
	Friend WithEvents cb_payment_vouchers As CheckBox
	Friend WithEvents cb_payment_cheques As CheckBox
	Friend WithEvents GroupControl9 As DevExpress.XtraEditors.GroupControl
	Friend WithEvents cb_new_purchase As CheckBox
	Friend WithEvents cb_purchase_orders As CheckBox
	Friend WithEvents GroupControl10 As DevExpress.XtraEditors.GroupControl
	Friend WithEvents cb_pickup_deliveries As CheckBox
	Friend WithEvents cb_transaction_invoice As CheckBox
	Friend WithEvents cb_stores As CheckBox
	Friend WithEvents cb_suppliers As CheckBox
	Friend WithEvents cb_settings As CheckBox
	Friend WithEvents cb_logistics As CheckBox
	Friend WithEvents acc_username As DevExpress.XtraEditors.LabelControl
	Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
	Friend WithEvents Panel2 As Panel
	Friend WithEvents cb_soa As CheckBox
End Class
