Imports System.ComponentModel
Imports System.Drawing.Drawing2D
Imports DevExpress.Data.Mask
Imports DevExpress.LookAndFeel
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports Guna.UI.WinForms
Imports Guna.UI2.WinForms
Imports Inventory_Management.My
Imports Inventory_Management.My.Resources

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_sales_create_quotation
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_sales_create_quotation))
        Me.grid_quotation = New System.Windows.Forms.DataGridView()
        Me.col_qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_model = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_cost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_sku = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.HyperlinkLabelControl1 = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.GunaPanel4 = New Guna.UI.WinForms.GunaPanel()
        Me.HyperlinkLabelControl2 = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.GunaPanel3 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaPanel2 = New Guna.UI.WinForms.GunaPanel()
        Me.btn_clear = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_create = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.cb_apply_terms = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.txt_terms = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_account_type = New DevExpress.XtraEditors.LabelControl()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_delivery_fee = New System.Windows.Forms.LinkLabel()
        Me.cbb_discount = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txt_delivery_fee = New DevExpress.XtraEditors.TextEdit()
        Me.cb_vatable = New System.Windows.Forms.CheckBox()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_withholding_tax_amount = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_discount = New DevExpress.XtraEditors.TextEdit()
        Me.lbl_withholding_tax_percentage = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_total = New DevExpress.XtraEditors.LabelControl()
        Me.cb_tax_applied = New System.Windows.Forms.CheckBox()
        Me.txt_delivery_address = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_address = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_no = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.radio_existing = New System.Windows.Forms.RadioButton()
        Me.radio_new = New System.Windows.Forms.RadioButton()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.cbb_customer = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.grid_remaining = New System.Windows.Forms.DataGridView()
        Me.col_other = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_on_hold = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_contact_person = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_priv_notes = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_pub_notes = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_customer = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.cbb_validity = New DevExpress.XtraEditors.ComboBoxEdit()
        CType(Me.grid_quotation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaPanel4.SuspendLayout()
        Me.GunaPanel3.SuspendLayout()
        Me.GunaPanel2.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txt_terms.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.cbb_discount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_delivery_fee.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_discount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_delivery_address.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_address.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_no.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbb_customer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_remaining, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_contact_person.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_priv_notes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_pub_notes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_customer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbb_validity.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grid_quotation
        '
        Me.grid_quotation.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_quotation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.grid_quotation.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.grid_quotation.BackgroundColor = System.Drawing.Color.GhostWhite
        Me.grid_quotation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.grid_quotation.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_quotation.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grid_quotation.ColumnHeadersHeight = 28
        Me.grid_quotation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.grid_quotation.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_qty, Me.col_model, Me.col_description, Me.col_cost, Me.col_sku, Me.col_total})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Tahoma", 8.25!)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(78, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grid_quotation.DefaultCellStyle = DataGridViewCellStyle7
        Me.grid_quotation.EnableHeadersVisualStyles = False
        Me.grid_quotation.Location = New System.Drawing.Point(153, 181)
        Me.grid_quotation.Name = "grid_quotation"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Tahoma", 8.25!)
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_quotation.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.grid_quotation.Size = New System.Drawing.Size(968, 299)
        Me.grid_quotation.TabIndex = 8
        '
        'col_qty
        '
        Me.col_qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Format = "N0"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.col_qty.DefaultCellStyle = DataGridViewCellStyle2
        Me.col_qty.FillWeight = 80.0!
        Me.col_qty.HeaderText = "Qty"
        Me.col_qty.Name = "col_qty"
        Me.col_qty.Width = 80
        '
        'col_model
        '
        Me.col_model.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.col_model.DefaultCellStyle = DataGridViewCellStyle3
        Me.col_model.FillWeight = 73.71088!
        Me.col_model.HeaderText = "Model"
        Me.col_model.Name = "col_model"
        Me.col_model.Width = 150
        '
        'col_description
        '
        Me.col_description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.col_description.FillWeight = 137.4594!
        Me.col_description.HeaderText = "Description"
        Me.col_description.Name = "col_description"
        '
        'col_cost
        '
        Me.col_cost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.col_cost.DefaultCellStyle = DataGridViewCellStyle4
        Me.col_cost.FillWeight = 102.6804!
        Me.col_cost.HeaderText = "Price"
        Me.col_cost.Name = "col_cost"
        Me.col_cost.ReadOnly = True
        Me.col_cost.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'col_sku
        '
        Me.col_sku.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.col_sku.DefaultCellStyle = DataGridViewCellStyle5
        Me.col_sku.FillWeight = 80.0!
        Me.col_sku.HeaderText = "DISCOUNT"
        Me.col_sku.Name = "col_sku"
        '
        'col_total
        '
        Me.col_total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N2"
        Me.col_total.DefaultCellStyle = DataGridViewCellStyle6
        Me.col_total.FillWeight = 125.5929!
        Me.col_total.HeaderText = "Total"
        Me.col_total.Name = "col_total"
        Me.col_total.ReadOnly = True
        Me.col_total.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(20, 55)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(55, 16)
        Me.LabelControl1.TabIndex = 71
        Me.LabelControl1.Text = "Company"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.GunaLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.GunaLabel1.Location = New System.Drawing.Point(14, 10)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(194, 31)
        Me.GunaLabel1.TabIndex = 1
        Me.GunaLabel1.Text = "New Quotation"
        '
        'HyperlinkLabelControl1
        '
        Me.HyperlinkLabelControl1.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HyperlinkLabelControl1.Appearance.LinkColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.HyperlinkLabelControl1.Appearance.Options.UseFont = True
        Me.HyperlinkLabelControl1.Appearance.Options.UseLinkColor = True
        Me.HyperlinkLabelControl1.AppearanceHovered.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.HyperlinkLabelControl1.AppearanceHovered.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.HyperlinkLabelControl1.AppearanceHovered.Options.UseForeColor = True
        Me.HyperlinkLabelControl1.AppearanceHovered.Options.UseLinkColor = True
        Me.HyperlinkLabelControl1.AppearancePressed.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.HyperlinkLabelControl1.AppearancePressed.Options.UseLinkColor = True
        Me.HyperlinkLabelControl1.Enabled = False
        Me.HyperlinkLabelControl1.LineStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.HyperlinkLabelControl1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.HyperlinkLabelControl1.Location = New System.Drawing.Point(70, 5)
        Me.HyperlinkLabelControl1.Name = "HyperlinkLabelControl1"
        Me.HyperlinkLabelControl1.ShowLineShadow = False
        Me.HyperlinkLabelControl1.Size = New System.Drawing.Size(95, 18)
        Me.HyperlinkLabelControl1.TabIndex = 7
        Me.HyperlinkLabelControl1.Text = "New Quotation"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(55, 7)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(9, 14)
        Me.LabelControl6.TabIndex = 6
        Me.LabelControl6.Text = ">"
        '
        'GunaPanel4
        '
        Me.GunaPanel4.Controls.Add(Me.HyperlinkLabelControl1)
        Me.GunaPanel4.Controls.Add(Me.LabelControl6)
        Me.GunaPanel4.Controls.Add(Me.HyperlinkLabelControl2)
        Me.GunaPanel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.GunaPanel4.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel4.Name = "GunaPanel4"
        Me.GunaPanel4.Size = New System.Drawing.Size(435, 27)
        Me.GunaPanel4.TabIndex = 1
        '
        'HyperlinkLabelControl2
        '
        Me.HyperlinkLabelControl2.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HyperlinkLabelControl2.Appearance.LinkColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.HyperlinkLabelControl2.Appearance.Options.UseFont = True
        Me.HyperlinkLabelControl2.Appearance.Options.UseLinkColor = True
        Me.HyperlinkLabelControl2.AppearanceDisabled.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.HyperlinkLabelControl2.AppearanceDisabled.Options.UseLinkColor = True
        Me.HyperlinkLabelControl2.AppearanceHovered.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.HyperlinkLabelControl2.AppearanceHovered.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.HyperlinkLabelControl2.AppearanceHovered.Options.UseForeColor = True
        Me.HyperlinkLabelControl2.AppearanceHovered.Options.UseLinkColor = True
        Me.HyperlinkLabelControl2.AppearancePressed.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.HyperlinkLabelControl2.AppearancePressed.Options.UseLinkColor = True
        Me.HyperlinkLabelControl2.LineStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.HyperlinkLabelControl2.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.HyperlinkLabelControl2.Location = New System.Drawing.Point(13, 5)
        Me.HyperlinkLabelControl2.Name = "HyperlinkLabelControl2"
        Me.HyperlinkLabelControl2.ShowLineShadow = False
        Me.HyperlinkLabelControl2.Size = New System.Drawing.Size(37, 18)
        Me.HyperlinkLabelControl2.TabIndex = 5
        Me.HyperlinkLabelControl2.Text = "Home"
        '
        'GunaPanel3
        '
        Me.GunaPanel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaPanel3.BackColor = System.Drawing.Color.Transparent
        Me.GunaPanel3.Controls.Add(Me.GunaPanel4)
        Me.GunaPanel3.Location = New System.Drawing.Point(19, 44)
        Me.GunaPanel3.Name = "GunaPanel3"
        Me.GunaPanel3.Size = New System.Drawing.Size(1125, 27)
        Me.GunaPanel3.TabIndex = 5
        '
        'GunaPanel2
        '
        Me.GunaPanel2.BackColor = System.Drawing.Color.GhostWhite
        Me.GunaPanel2.Controls.Add(Me.GunaPanel3)
        Me.GunaPanel2.Controls.Add(Me.GunaLabel1)
        Me.GunaPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel2.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel2.Name = "GunaPanel2"
        Me.GunaPanel2.Size = New System.Drawing.Size(1165, 78)
        Me.GunaPanel2.TabIndex = 53
        '
        'btn_clear
        '
        Me.btn_clear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_clear.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.btn_clear.Appearance.Options.UseFont = True
        Me.btn_clear.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.clearall_32x32
        Me.btn_clear.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter
        Me.btn_clear.Location = New System.Drawing.Point(994, 14)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(60, 60)
        Me.btn_clear.TabIndex = 11
        Me.btn_clear.Text = "Clear"
        '
        'btn_create
        '
        Me.btn_create.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_create.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.btn_create.Appearance.Options.UseFont = True
        Me.btn_create.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.boorderitem_32x32
        Me.btn_create.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter
        Me.btn_create.Location = New System.Drawing.Point(1060, 14)
        Me.btn_create.Name = "btn_create"
        Me.btn_create.Size = New System.Drawing.Size(60, 60)
        Me.btn_create.TabIndex = 12
        Me.btn_create.Text = "Create"
        '
        'PanelControl1
        '
        Me.PanelControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl1.Controls.Add(Me.LabelControl13)
        Me.PanelControl1.Controls.Add(Me.cbb_validity)
        Me.PanelControl1.Controls.Add(Me.cb_apply_terms)
        Me.PanelControl1.Controls.Add(Me.txt_terms)
        Me.PanelControl1.Controls.Add(Me.LabelControl12)
        Me.PanelControl1.Controls.Add(Me.lbl_account_type)
        Me.PanelControl1.Controls.Add(Me.Panel1)
        Me.PanelControl1.Controls.Add(Me.txt_delivery_address)
        Me.PanelControl1.Controls.Add(Me.LabelControl10)
        Me.PanelControl1.Controls.Add(Me.txt_address)
        Me.PanelControl1.Controls.Add(Me.LabelControl8)
        Me.PanelControl1.Controls.Add(Me.txt_no)
        Me.PanelControl1.Controls.Add(Me.LabelControl7)
        Me.PanelControl1.Controls.Add(Me.radio_existing)
        Me.PanelControl1.Controls.Add(Me.radio_new)
        Me.PanelControl1.Controls.Add(Me.LabelControl3)
        Me.PanelControl1.Controls.Add(Me.cbb_customer)
        Me.PanelControl1.Controls.Add(Me.grid_quotation)
        Me.PanelControl1.Controls.Add(Me.grid_remaining)
        Me.PanelControl1.Controls.Add(Me.txt_contact_person)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.txt_priv_notes)
        Me.PanelControl1.Controls.Add(Me.LabelControl5)
        Me.PanelControl1.Controls.Add(Me.txt_pub_notes)
        Me.PanelControl1.Controls.Add(Me.LabelControl4)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.btn_clear)
        Me.PanelControl1.Controls.Add(Me.btn_create)
        Me.PanelControl1.Controls.Add(Me.txt_customer)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 102)
        Me.PanelControl1.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.PanelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1141, 626)
        Me.PanelControl1.TabIndex = 54
        '
        'cb_apply_terms
        '
        Me.cb_apply_terms.AutoSize = True
        Me.cb_apply_terms.CheckedState.BorderColor = System.Drawing.Color.Red
        Me.cb_apply_terms.CheckedState.BorderRadius = 2
        Me.cb_apply_terms.CheckedState.BorderThickness = 0
        Me.cb_apply_terms.CheckedState.FillColor = System.Drawing.Color.Red
        Me.cb_apply_terms.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.cb_apply_terms.ForeColor = System.Drawing.Color.Black
        Me.cb_apply_terms.Location = New System.Drawing.Point(970, 127)
        Me.cb_apply_terms.Name = "cb_apply_terms"
        Me.cb_apply_terms.Size = New System.Drawing.Size(99, 20)
        Me.cb_apply_terms.TabIndex = 122
        Me.cb_apply_terms.Text = "Apply Terms"
        Me.cb_apply_terms.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.cb_apply_terms.UncheckedState.BorderRadius = 2
        Me.cb_apply_terms.UncheckedState.BorderThickness = 0
        Me.cb_apply_terms.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.cb_apply_terms.UseVisualStyleBackColor = True
        '
        'txt_terms
        '
        Me.txt_terms.Location = New System.Drawing.Point(1071, 127)
        Me.txt_terms.Name = "txt_terms"
        Me.txt_terms.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_terms.Properties.Appearance.Options.UseFont = True
        Me.txt_terms.Size = New System.Drawing.Size(50, 22)
        Me.txt_terms.TabIndex = 120
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl12.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl12.Appearance.Options.UseFont = True
        Me.LabelControl12.Appearance.Options.UseForeColor = True
        Me.LabelControl12.Location = New System.Drawing.Point(20, 139)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(84, 16)
        Me.LabelControl12.TabIndex = 119
        Me.LabelControl12.Text = "Account Type:"
        '
        'lbl_account_type
        '
        Me.lbl_account_type.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_account_type.Appearance.ForeColor = System.Drawing.Color.Black
        Me.lbl_account_type.Appearance.Options.UseFont = True
        Me.lbl_account_type.Appearance.Options.UseForeColor = True
        Me.lbl_account_type.Location = New System.Drawing.Point(153, 139)
        Me.lbl_account_type.Name = "lbl_account_type"
        Me.lbl_account_type.Size = New System.Drawing.Size(23, 16)
        Me.lbl_account_type.TabIndex = 118
        Me.lbl_account_type.Text = "N/A"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.lbl_delivery_fee)
        Me.Panel1.Controls.Add(Me.cbb_discount)
        Me.Panel1.Controls.Add(Me.txt_delivery_fee)
        Me.Panel1.Controls.Add(Me.cb_vatable)
        Me.Panel1.Controls.Add(Me.LabelControl11)
        Me.Panel1.Controls.Add(Me.lbl_withholding_tax_amount)
        Me.Panel1.Controls.Add(Me.LabelControl9)
        Me.Panel1.Controls.Add(Me.LabelControl14)
        Me.Panel1.Controls.Add(Me.txt_discount)
        Me.Panel1.Controls.Add(Me.lbl_withholding_tax_percentage)
        Me.Panel1.Controls.Add(Me.lbl_total)
        Me.Panel1.Controls.Add(Me.cb_tax_applied)
        Me.Panel1.Location = New System.Drawing.Point(671, 485)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(449, 136)
        Me.Panel1.TabIndex = 117
        '
        'lbl_delivery_fee
        '
        Me.lbl_delivery_fee.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_delivery_fee.BackColor = System.Drawing.Color.Transparent
        Me.lbl_delivery_fee.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.lbl_delivery_fee.Location = New System.Drawing.Point(3, 14)
        Me.lbl_delivery_fee.Name = "lbl_delivery_fee"
        Me.lbl_delivery_fee.Size = New System.Drawing.Size(130, 18)
        Me.lbl_delivery_fee.TabIndex = 121
        Me.lbl_delivery_fee.TabStop = True
        Me.lbl_delivery_fee.Text = "Add Delivery Fee"
        Me.lbl_delivery_fee.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbb_discount
        '
        Me.cbb_discount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbb_discount.Location = New System.Drawing.Point(384, 13)
        Me.cbb_discount.Name = "cbb_discount"
        Me.cbb_discount.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.cbb_discount.Properties.Appearance.Options.UseFont = True
        Me.cbb_discount.Properties.Appearance.Options.UseTextOptions = True
        Me.cbb_discount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.cbb_discount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_discount.Properties.Items.AddRange(New Object() {"peso", "%"})
        Me.cbb_discount.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cbb_discount.Size = New System.Drawing.Size(62, 22)
        Me.cbb_discount.TabIndex = 107
        '
        'txt_delivery_fee
        '
        Me.txt_delivery_fee.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_delivery_fee.EditValue = ""
        Me.txt_delivery_fee.Enabled = False
        Me.txt_delivery_fee.Location = New System.Drawing.Point(137, 13)
        Me.txt_delivery_fee.Name = "txt_delivery_fee"
        Me.txt_delivery_fee.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.txt_delivery_fee.Properties.Appearance.Options.UseFont = True
        Me.txt_delivery_fee.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_delivery_fee.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_delivery_fee.Properties.BeepOnError = False
        Me.txt_delivery_fee.Size = New System.Drawing.Size(93, 22)
        Me.txt_delivery_fee.TabIndex = 120
        '
        'cb_vatable
        '
        Me.cb_vatable.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_vatable.AutoSize = True
        Me.cb_vatable.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cb_vatable.Location = New System.Drawing.Point(122, 44)
        Me.cb_vatable.Name = "cb_vatable"
        Me.cb_vatable.Size = New System.Drawing.Size(98, 18)
        Me.cb_vatable.TabIndex = 116
        Me.cb_vatable.Text = "Vatable Sales"
        Me.cb_vatable.UseVisualStyleBackColor = True
        '
        'LabelControl11
        '
        Me.LabelControl11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Consolas", 14.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl11.Appearance.Options.UseFont = True
        Me.LabelControl11.Location = New System.Drawing.Point(149, 101)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(120, 22)
        Me.LabelControl11.TabIndex = 109
        Me.LabelControl11.Text = "Total Amount"
        '
        'lbl_withholding_tax_amount
        '
        Me.lbl_withholding_tax_amount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_withholding_tax_amount.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lbl_withholding_tax_amount.Appearance.Options.UseFont = True
        Me.lbl_withholding_tax_amount.Appearance.Options.UseTextOptions = True
        Me.lbl_withholding_tax_amount.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_withholding_tax_amount.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_withholding_tax_amount.Location = New System.Drawing.Point(336, 66)
        Me.lbl_withholding_tax_amount.Name = "lbl_withholding_tax_amount"
        Me.lbl_withholding_tax_amount.Size = New System.Drawing.Size(111, 14)
        Me.lbl_withholding_tax_amount.TabIndex = 115
        Me.lbl_withholding_tax_amount.Text = "₱0.00"
        '
        'LabelControl9
        '
        Me.LabelControl9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Location = New System.Drawing.Point(245, 18)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(51, 14)
        Me.LabelControl9.TabIndex = 110
        Me.LabelControl9.Text = "Discount:"
        '
        'LabelControl14
        '
        Me.LabelControl14.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl14.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LabelControl14.Appearance.Options.UseFont = True
        Me.LabelControl14.Location = New System.Drawing.Point(246, 68)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(84, 14)
        Me.LabelControl14.TabIndex = 114
        Me.LabelControl14.Text = "WT Deduction:"
        '
        'txt_discount
        '
        Me.txt_discount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_discount.Enabled = False
        Me.txt_discount.Location = New System.Drawing.Point(320, 13)
        Me.txt_discount.Name = "txt_discount"
        Me.txt_discount.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.txt_discount.Properties.Appearance.Options.UseFont = True
        Me.txt_discount.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_discount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txt_discount.Properties.Mask.BeepOnError = True
        Me.txt_discount.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txt_discount.Properties.MaskSettings.Set("mask", "n")
        Me.txt_discount.Size = New System.Drawing.Size(68, 22)
        Me.txt_discount.TabIndex = 108
        '
        'lbl_withholding_tax_percentage
        '
        Me.lbl_withholding_tax_percentage.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_withholding_tax_percentage.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lbl_withholding_tax_percentage.Appearance.Options.UseFont = True
        Me.lbl_withholding_tax_percentage.Appearance.Options.UseTextOptions = True
        Me.lbl_withholding_tax_percentage.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_withholding_tax_percentage.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_withholding_tax_percentage.Location = New System.Drawing.Point(374, 48)
        Me.lbl_withholding_tax_percentage.Name = "lbl_withholding_tax_percentage"
        Me.lbl_withholding_tax_percentage.Size = New System.Drawing.Size(73, 14)
        Me.lbl_withholding_tax_percentage.TabIndex = 113
        Me.lbl_withholding_tax_percentage.Text = "1.00%"
        '
        'lbl_total
        '
        Me.lbl_total.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_total.Appearance.BackColor = System.Drawing.Color.White
        Me.lbl_total.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbl_total.Appearance.Font = New System.Drawing.Font("Consolas", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_total.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.lbl_total.Appearance.Options.UseBackColor = True
        Me.lbl_total.Appearance.Options.UseBorderColor = True
        Me.lbl_total.Appearance.Options.UseFont = True
        Me.lbl_total.Appearance.Options.UseForeColor = True
        Me.lbl_total.Appearance.Options.UseTextOptions = True
        Me.lbl_total.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_total.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_total.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.lbl_total.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.lbl_total.Location = New System.Drawing.Point(275, 98)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.lbl_total.Size = New System.Drawing.Size(171, 29)
        Me.lbl_total.TabIndex = 111
        Me.lbl_total.Text = "₱0.00"
        '
        'cb_tax_applied
        '
        Me.cb_tax_applied.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_tax_applied.AutoSize = True
        Me.cb_tax_applied.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cb_tax_applied.Location = New System.Drawing.Point(226, 44)
        Me.cb_tax_applied.Name = "cb_tax_applied"
        Me.cb_tax_applied.Size = New System.Drawing.Size(142, 18)
        Me.cb_tax_applied.TabIndex = 112
        Me.cb_tax_applied.Text = "Apply Witholding Tax"
        Me.cb_tax_applied.UseVisualStyleBackColor = True
        '
        'txt_delivery_address
        '
        Me.txt_delivery_address.Location = New System.Drawing.Point(509, 102)
        Me.txt_delivery_address.Name = "txt_delivery_address"
        Me.txt_delivery_address.Size = New System.Drawing.Size(318, 53)
        Me.txt_delivery_address.TabIndex = 7
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl10.Appearance.Options.UseFont = True
        Me.LabelControl10.Appearance.Options.UseForeColor = True
        Me.LabelControl10.Location = New System.Drawing.Point(509, 80)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(101, 16)
        Me.LabelControl10.TabIndex = 103
        Me.LabelControl10.Text = "Delivery Address:"
        '
        'txt_address
        '
        Me.txt_address.Location = New System.Drawing.Point(509, 52)
        Me.txt_address.Name = "txt_address"
        Me.txt_address.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_address.Properties.Appearance.Options.UseFont = True
        Me.txt_address.Size = New System.Drawing.Size(318, 22)
        Me.txt_address.TabIndex = 6
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Appearance.Options.UseForeColor = True
        Me.LabelControl8.Location = New System.Drawing.Point(509, 30)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(85, 16)
        Me.LabelControl8.TabIndex = 101
        Me.LabelControl8.Text = "Office Address"
        '
        'txt_no
        '
        Me.txt_no.Location = New System.Drawing.Point(153, 108)
        Me.txt_no.Name = "txt_no"
        Me.txt_no.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_no.Properties.Appearance.Options.UseFont = True
        Me.txt_no.Size = New System.Drawing.Size(200, 22)
        Me.txt_no.TabIndex = 5
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Appearance.Options.UseForeColor = True
        Me.LabelControl7.Location = New System.Drawing.Point(20, 111)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(73, 16)
        Me.LabelControl7.TabIndex = 99
        Me.LabelControl7.Text = "Contact No.:"
        '
        'radio_existing
        '
        Me.radio_existing.AutoSize = True
        Me.radio_existing.Font = New System.Drawing.Font("Arial", 9.7!)
        Me.radio_existing.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.radio_existing.Location = New System.Drawing.Point(225, 24)
        Me.radio_existing.Name = "radio_existing"
        Me.radio_existing.Size = New System.Drawing.Size(73, 20)
        Me.radio_existing.TabIndex = 1
        Me.radio_existing.Text = "Existing"
        Me.radio_existing.UseVisualStyleBackColor = True
        '
        'radio_new
        '
        Me.radio_new.AutoSize = True
        Me.radio_new.Checked = True
        Me.radio_new.Font = New System.Drawing.Font("Arial", 9.7!)
        Me.radio_new.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.radio_new.Location = New System.Drawing.Point(153, 24)
        Me.radio_new.Name = "radio_new"
        Me.radio_new.Size = New System.Drawing.Size(51, 20)
        Me.radio_new.TabIndex = 0
        Me.radio_new.TabStop = True
        Me.radio_new.Text = "New"
        Me.radio_new.UseVisualStyleBackColor = True
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Appearance.Options.UseForeColor = True
        Me.LabelControl3.Location = New System.Drawing.Point(20, 26)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(88, 16)
        Me.LabelControl3.TabIndex = 96
        Me.LabelControl3.Text = "Customer Type"
        '
        'cbb_customer
        '
        Me.cbb_customer.Location = New System.Drawing.Point(153, 52)
        Me.cbb_customer.Name = "cbb_customer"
        Me.cbb_customer.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.cbb_customer.Properties.Appearance.Options.UseFont = True
        Me.cbb_customer.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_customer.Size = New System.Drawing.Size(200, 22)
        Me.cbb_customer.TabIndex = 2
        '
        'grid_remaining
        '
        Me.grid_remaining.AllowUserToAddRows = False
        Me.grid_remaining.AllowUserToDeleteRows = False
        Me.grid_remaining.AllowUserToResizeColumns = False
        Me.grid_remaining.AllowUserToResizeRows = False
        Me.grid_remaining.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grid_remaining.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.grid_remaining.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.grid_remaining.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.grid_remaining.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grid_remaining.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.grid_remaining.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Tahoma", 8.25!)
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_remaining.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.grid_remaining.ColumnHeadersHeight = 28
        Me.grid_remaining.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.grid_remaining.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_other, Me.DataGridViewTextBoxColumn1, Me.col_on_hold})
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Tahoma", 8.25!)
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(78, Byte), Integer))
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grid_remaining.DefaultCellStyle = DataGridViewCellStyle13
        Me.grid_remaining.Enabled = False
        Me.grid_remaining.EnableHeadersVisualStyles = False
        Me.grid_remaining.Location = New System.Drawing.Point(7, 181)
        Me.grid_remaining.MultiSelect = False
        Me.grid_remaining.Name = "grid_remaining"
        Me.grid_remaining.ReadOnly = True
        Me.grid_remaining.RowHeadersVisible = False
        Me.grid_remaining.RowTemplate.Height = 23
        Me.grid_remaining.Size = New System.Drawing.Size(162, 299)
        Me.grid_remaining.TabIndex = 94
        '
        'col_other
        '
        Me.col_other.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.col_other.DefaultCellStyle = DataGridViewCellStyle10
        Me.col_other.HeaderText = "Others Stocks"
        Me.col_other.Name = "col_other"
        Me.col_other.ReadOnly = True
        Me.col_other.Width = 50
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.NullValue = Nothing
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridViewTextBoxColumn1.FillWeight = 80.0!
        Me.DataGridViewTextBoxColumn1.HeaderText = "My Stocks"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'col_on_hold
        '
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.col_on_hold.DefaultCellStyle = DataGridViewCellStyle12
        Me.col_on_hold.HeaderText = "On Hold"
        Me.col_on_hold.Name = "col_on_hold"
        Me.col_on_hold.ReadOnly = True
        Me.col_on_hold.Width = 63
        '
        'txt_contact_person
        '
        Me.txt_contact_person.Location = New System.Drawing.Point(153, 80)
        Me.txt_contact_person.Name = "txt_contact_person"
        Me.txt_contact_person.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_contact_person.Properties.Appearance.Options.UseFont = True
        Me.txt_contact_person.Size = New System.Drawing.Size(200, 22)
        Me.txt_contact_person.TabIndex = 4
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Appearance.Options.UseForeColor = True
        Me.LabelControl2.Location = New System.Drawing.Point(20, 83)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(90, 16)
        Me.LabelControl2.TabIndex = 92
        Me.LabelControl2.Text = "Contact Person"
        '
        'txt_priv_notes
        '
        Me.txt_priv_notes.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_priv_notes.Location = New System.Drawing.Point(333, 544)
        Me.txt_priv_notes.Name = "txt_priv_notes"
        Me.txt_priv_notes.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.txt_priv_notes.Properties.Appearance.Options.UseFont = True
        Me.txt_priv_notes.Size = New System.Drawing.Size(307, 71)
        Me.txt_priv_notes.TabIndex = 10
        '
        'LabelControl5
        '
        Me.LabelControl5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.LabelControl5.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Appearance.Options.UseForeColor = True
        Me.LabelControl5.Location = New System.Drawing.Point(333, 519)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(110, 16)
        Me.LabelControl5.TabIndex = 75
        Me.LabelControl5.Text = "Private Comments:"
        '
        'txt_pub_notes
        '
        Me.txt_pub_notes.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_pub_notes.Location = New System.Drawing.Point(9, 544)
        Me.txt_pub_notes.Name = "txt_pub_notes"
        Me.txt_pub_notes.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.txt_pub_notes.Properties.Appearance.Options.UseFont = True
        Me.txt_pub_notes.Size = New System.Drawing.Size(307, 71)
        Me.txt_pub_notes.TabIndex = 9
        '
        'LabelControl4
        '
        Me.LabelControl4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.LabelControl4.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Appearance.Options.UseForeColor = True
        Me.LabelControl4.Location = New System.Drawing.Point(9, 519)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(107, 16)
        Me.LabelControl4.TabIndex = 67
        Me.LabelControl4.Text = "Public Comments:"
        '
        'txt_customer
        '
        Me.txt_customer.Location = New System.Drawing.Point(153, 52)
        Me.txt_customer.Name = "txt_customer"
        Me.txt_customer.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_customer.Properties.Appearance.Options.UseFont = True
        Me.txt_customer.Size = New System.Drawing.Size(339, 22)
        Me.txt_customer.TabIndex = 3
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl13.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl13.Appearance.Options.UseFont = True
        Me.LabelControl13.Appearance.Options.UseForeColor = True
        Me.LabelControl13.Location = New System.Drawing.Point(1006, 156)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(43, 16)
        Me.LabelControl13.TabIndex = 128
        Me.LabelControl13.Text = "Validity"
        '
        'cbb_validity
        '
        Me.cbb_validity.Location = New System.Drawing.Point(1071, 153)
        Me.cbb_validity.Name = "cbb_validity"
        Me.cbb_validity.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.cbb_validity.Properties.Appearance.Options.UseFont = True
        Me.cbb_validity.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_validity.Properties.Items.AddRange(New Object() {"7", "15", "30"})
        Me.cbb_validity.Size = New System.Drawing.Size(50, 22)
        Me.cbb_validity.TabIndex = 127
        '
        'frm_sales_create_quotation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1165, 737)
        Me.Controls.Add(Me.GunaPanel2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_sales_create_quotation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Quotation"
        CType(Me.grid_quotation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaPanel4.ResumeLayout(False)
        Me.GunaPanel4.PerformLayout()
        Me.GunaPanel3.ResumeLayout(False)
        Me.GunaPanel2.ResumeLayout(False)
        Me.GunaPanel2.PerformLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.txt_terms.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.cbb_discount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_delivery_fee.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_discount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_delivery_address.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_address.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_no.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbb_customer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_remaining, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_contact_person.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_priv_notes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_pub_notes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_customer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbb_validity.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents col_qty As DataGridViewTextBoxColumn
    Friend WithEvents col_model As DataGridViewTextBoxColumn
    Friend WithEvents col_description As DataGridViewTextBoxColumn
    Friend WithEvents col_cost As DataGridViewTextBoxColumn
    Friend WithEvents col_sku As DataGridViewTextBoxColumn
    Friend WithEvents col_total As DataGridViewTextBoxColumn
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents HyperlinkLabelControl1 As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GunaPanel4 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents HyperlinkLabelControl2 As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents GunaPanel3 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPanel2 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents btn_clear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_create As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txt_priv_notes As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_pub_notes As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_customer As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_contact_person As DevExpress.XtraEditors.TextEdit
    Friend WithEvents grid_remaining As DataGridView
    Friend WithEvents col_other As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents col_on_hold As DataGridViewTextBoxColumn
    Friend WithEvents cbb_customer As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents radio_existing As RadioButton
    Friend WithEvents radio_new As RadioButton
    Friend WithEvents txt_delivery_address As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_address As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_no As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cb_vatable As CheckBox
    Friend WithEvents lbl_withholding_tax_amount As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_withholding_tax_percentage As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cb_tax_applied As CheckBox
    Friend WithEvents lbl_total As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_discount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbb_discount As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel1 As Panel
    Friend WithEvents grid_quotation As DataGridView
    Friend WithEvents btn_approved As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_account_type As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_delivery_fee As LinkLabel
    Friend WithEvents txt_delivery_fee As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cb_apply_terms As Guna2CheckBox
    Friend WithEvents txt_terms As TextEdit
    Friend WithEvents LabelControl13 As LabelControl
    Friend WithEvents cbb_validity As ComboBoxEdit
End Class
