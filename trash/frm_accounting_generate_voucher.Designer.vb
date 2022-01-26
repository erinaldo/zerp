<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_accounting_generate_voucher
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
        Me.GunaPanel4 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaPanel5 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.link_po_list = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.link_home = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.rb_cash = New System.Windows.Forms.RadioButton()
        Me.rb_cheque = New System.Windows.Forms.RadioButton()
        Me.panel_generate = New DevExpress.XtraEditors.PanelControl()
        Me.btn_generate = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_collection_ref = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.cbb_suppliers = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.grid_receipts_cheque = New DevExpress.XtraGrid.GridControl()
        Me.grid_receipts_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_po_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_receipt_ref = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_amount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_purchase_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_bank = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_cheque_no = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_cheque_date = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_cashid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txt_total_view = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.GunaPanel4.SuspendLayout()
        Me.GunaPanel5.SuspendLayout()
        Me.GunaPanel1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.panel_generate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_generate.SuspendLayout()
        CType(Me.txt_collection_ref.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbb_suppliers.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_receipts_cheque, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_receipts_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_total_view.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaPanel4
        '
        Me.GunaPanel4.BackColor = System.Drawing.Color.GhostWhite
        Me.GunaPanel4.Controls.Add(Me.GunaPanel5)
        Me.GunaPanel4.Controls.Add(Me.GunaLabel2)
        Me.GunaPanel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel4.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel4.Name = "GunaPanel4"
        Me.GunaPanel4.Size = New System.Drawing.Size(1068, 78)
        Me.GunaPanel4.TabIndex = 13
        '
        'GunaPanel5
        '
        Me.GunaPanel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaPanel5.BackColor = System.Drawing.Color.Transparent
        Me.GunaPanel5.Controls.Add(Me.GunaPanel1)
        Me.GunaPanel5.Location = New System.Drawing.Point(12, 44)
        Me.GunaPanel5.Name = "GunaPanel5"
        Me.GunaPanel5.Size = New System.Drawing.Size(1040, 27)
        Me.GunaPanel5.TabIndex = 5
        '
        'GunaPanel1
        '
        Me.GunaPanel1.Controls.Add(Me.link_po_list)
        Me.GunaPanel1.Controls.Add(Me.LabelControl7)
        Me.GunaPanel1.Controls.Add(Me.link_home)
        Me.GunaPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GunaPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(435, 27)
        Me.GunaPanel1.TabIndex = 0
        '
        'link_po_list
        '
        Me.link_po_list.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.link_po_list.Appearance.LinkColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.link_po_list.Appearance.Options.UseFont = True
        Me.link_po_list.Appearance.Options.UseLinkColor = True
        Me.link_po_list.AppearanceHovered.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.link_po_list.AppearanceHovered.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.link_po_list.AppearanceHovered.Options.UseForeColor = True
        Me.link_po_list.AppearanceHovered.Options.UseLinkColor = True
        Me.link_po_list.AppearancePressed.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.link_po_list.AppearancePressed.Options.UseLinkColor = True
        Me.link_po_list.LineStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.link_po_list.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.link_po_list.Location = New System.Drawing.Point(70, 5)
        Me.link_po_list.Name = "link_po_list"
        Me.link_po_list.ShowLineShadow = False
        Me.link_po_list.Size = New System.Drawing.Size(113, 18)
        Me.link_po_list.TabIndex = 7
        Me.link_po_list.Text = "Generate Voucher"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Location = New System.Drawing.Point(55, 7)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(9, 14)
        Me.LabelControl7.TabIndex = 6
        Me.LabelControl7.Text = ">"
        '
        'link_home
        '
        Me.link_home.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.link_home.Appearance.LinkColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.link_home.Appearance.Options.UseFont = True
        Me.link_home.Appearance.Options.UseLinkColor = True
        Me.link_home.AppearanceDisabled.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.link_home.AppearanceDisabled.Options.UseLinkColor = True
        Me.link_home.AppearanceHovered.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.link_home.AppearanceHovered.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.link_home.AppearanceHovered.Options.UseForeColor = True
        Me.link_home.AppearanceHovered.Options.UseLinkColor = True
        Me.link_home.AppearancePressed.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.link_home.AppearancePressed.Options.UseLinkColor = True
        Me.link_home.LineStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.link_home.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.link_home.Location = New System.Drawing.Point(13, 5)
        Me.link_home.Name = "link_home"
        Me.link_home.ShowLineShadow = False
        Me.link_home.Size = New System.Drawing.Size(37, 18)
        Me.link_home.TabIndex = 5
        Me.link_home.Text = "Home"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.GunaLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.GunaLabel2.Location = New System.Drawing.Point(14, 10)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(235, 31)
        Me.GunaLabel2.TabIndex = 1
        Me.GunaLabel2.Text = "Generate Voucher"
        '
        'PanelControl2
        '
        Me.PanelControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl2.Controls.Add(Me.Panel1)
        Me.PanelControl2.Controls.Add(Me.panel_generate)
        Me.PanelControl2.Controls.Add(Me.LabelControl3)
        Me.PanelControl2.Controls.Add(Me.cbb_suppliers)
        Me.PanelControl2.Location = New System.Drawing.Point(12, 97)
        Me.PanelControl2.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.PanelControl2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(1040, 52)
        Me.PanelControl2.TabIndex = 20
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.LabelControl12)
        Me.Panel1.Controls.Add(Me.rb_cash)
        Me.Panel1.Controls.Add(Me.rb_cheque)
        Me.Panel1.Location = New System.Drawing.Point(318, 11)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(290, 34)
        Me.Panel1.TabIndex = 26
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.LabelControl12.Appearance.Options.UseFont = True
        Me.LabelControl12.Location = New System.Drawing.Point(3, 7)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(102, 18)
        Me.LabelControl12.TabIndex = 2
        Me.LabelControl12.Text = "Payment Type:"
        '
        'rb_cash
        '
        Me.rb_cash.AutoSize = True
        Me.rb_cash.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.rb_cash.Location = New System.Drawing.Point(200, 7)
        Me.rb_cash.Name = "rb_cash"
        Me.rb_cash.Size = New System.Drawing.Size(56, 21)
        Me.rb_cash.TabIndex = 1
        Me.rb_cash.Text = "Cash"
        Me.rb_cash.UseVisualStyleBackColor = True
        '
        'rb_cheque
        '
        Me.rb_cheque.AutoSize = True
        Me.rb_cheque.Checked = True
        Me.rb_cheque.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.rb_cheque.Location = New System.Drawing.Point(122, 7)
        Me.rb_cheque.Name = "rb_cheque"
        Me.rb_cheque.Size = New System.Drawing.Size(73, 21)
        Me.rb_cheque.TabIndex = 0
        Me.rb_cheque.TabStop = True
        Me.rb_cheque.Text = "Cheque"
        Me.rb_cheque.UseVisualStyleBackColor = True
        '
        'panel_generate
        '
        Me.panel_generate.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.panel_generate.Controls.Add(Me.btn_generate)
        Me.panel_generate.Controls.Add(Me.LabelControl1)
        Me.panel_generate.Controls.Add(Me.txt_collection_ref)
        Me.panel_generate.Dock = System.Windows.Forms.DockStyle.Right
        Me.panel_generate.Location = New System.Drawing.Point(634, 2)
        Me.panel_generate.Name = "panel_generate"
        Me.panel_generate.Size = New System.Drawing.Size(404, 48)
        Me.panel_generate.TabIndex = 25
        Me.panel_generate.Visible = False
        '
        'btn_generate
        '
        Me.btn_generate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_generate.Appearance.BackColor = System.Drawing.Color.DarkKhaki
        Me.btn_generate.Appearance.Options.UseBackColor = True
        Me.btn_generate.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.createmodeldifferences_16x16
        Me.btn_generate.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_generate.Location = New System.Drawing.Point(274, 9)
        Me.btn_generate.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_generate.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_generate.Name = "btn_generate"
        Me.btn_generate.Size = New System.Drawing.Size(118, 30)
        Me.btn_generate.TabIndex = 9
        Me.btn_generate.Text = "Generate Voucher"
        '
        'LabelControl1
        '
        Me.LabelControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(32, 18)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(85, 15)
        Me.LabelControl1.TabIndex = 23
        Me.LabelControl1.Text = "Collection Ref.:"
        '
        'txt_collection_ref
        '
        Me.txt_collection_ref.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_collection_ref.EditValue = ""
        Me.txt_collection_ref.Location = New System.Drawing.Point(128, 13)
        Me.txt_collection_ref.Name = "txt_collection_ref"
        Me.txt_collection_ref.Properties.Appearance.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_collection_ref.Properties.Appearance.Options.UseFont = True
        Me.txt_collection_ref.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_collection_ref.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_collection_ref.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_collection_ref.Size = New System.Drawing.Size(123, 24)
        Me.txt_collection_ref.TabIndex = 24
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(16, 21)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(42, 13)
        Me.LabelControl3.TabIndex = 5
        Me.LabelControl3.Text = "Supplier:"
        '
        'cbb_suppliers
        '
        Me.cbb_suppliers.Location = New System.Drawing.Point(70, 18)
        Me.cbb_suppliers.Name = "cbb_suppliers"
        Me.cbb_suppliers.Properties.AutoHeight = False
        Me.cbb_suppliers.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_suppliers.Size = New System.Drawing.Size(242, 20)
        Me.cbb_suppliers.TabIndex = 0
        '
        'grid_receipts_cheque
        '
        Me.grid_receipts_cheque.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_receipts_cheque.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_receipts_cheque.Location = New System.Drawing.Point(12, 159)
        Me.grid_receipts_cheque.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grid_receipts_cheque.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grid_receipts_cheque.MainView = Me.grid_receipts_view
        Me.grid_receipts_cheque.Name = "grid_receipts_cheque"
        Me.grid_receipts_cheque.Size = New System.Drawing.Size(1040, 367)
        Me.grid_receipts_cheque.TabIndex = 19
        Me.grid_receipts_cheque.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_receipts_view})
        '
        'grid_receipts_view
        '
        Me.grid_receipts_view.Appearance.HeaderPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.grid_receipts_view.Appearance.HeaderPanel.Options.UseFont = True
        Me.grid_receipts_view.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.grid_receipts_view.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grid_receipts_view.Appearance.Row.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_receipts_view.Appearance.Row.Options.UseFont = True
        Me.grid_receipts_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_id, Me.col_po_id, Me.col_receipt_ref, Me.col_amount, Me.col_purchase_id, Me.col_bank, Me.col_cheque_no, Me.col_cheque_date, Me.col_cashid})
        Me.grid_receipts_view.GridControl = Me.grid_receipts_cheque
        Me.grid_receipts_view.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.grid_receipts_view.Name = "grid_receipts_view"
        Me.grid_receipts_view.OptionsBehavior.ReadOnly = True
        Me.grid_receipts_view.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.grid_receipts_view.OptionsSelection.MultiSelect = True
        Me.grid_receipts_view.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.grid_receipts_view.OptionsView.AutoCalcPreviewLineCount = True
        Me.grid_receipts_view.OptionsView.ColumnAutoWidth = False
        Me.grid_receipts_view.OptionsView.RowAutoHeight = True
        '
        'col_id
        '
        Me.col_id.AppearanceCell.Options.UseTextOptions = True
        Me.col_id.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_id.Caption = "Payable ID"
        Me.col_id.FieldName = "payable_id"
        Me.col_id.Name = "col_id"
        Me.col_id.Visible = True
        Me.col_id.VisibleIndex = 1
        Me.col_id.Width = 77
        '
        'col_po_id
        '
        Me.col_po_id.AppearanceCell.Options.UseTextOptions = True
        Me.col_po_id.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_po_id.Caption = "Purchase ID"
        Me.col_po_id.FieldName = "purchase_id"
        Me.col_po_id.Name = "col_po_id"
        Me.col_po_id.Visible = True
        Me.col_po_id.VisibleIndex = 2
        Me.col_po_id.Width = 96
        '
        'col_receipt_ref
        '
        Me.col_receipt_ref.AppearanceCell.Options.UseTextOptions = True
        Me.col_receipt_ref.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_receipt_ref.Caption = "Receipt Ref"
        Me.col_receipt_ref.FieldName = "receipt_ref"
        Me.col_receipt_ref.Name = "col_receipt_ref"
        Me.col_receipt_ref.Visible = True
        Me.col_receipt_ref.VisibleIndex = 5
        Me.col_receipt_ref.Width = 104
        '
        'col_amount
        '
        Me.col_amount.AppearanceCell.Options.UseTextOptions = True
        Me.col_amount.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_amount.Caption = "Amount"
        Me.col_amount.DisplayFormat.FormatString = "c2"
        Me.col_amount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_amount.FieldName = "amount"
        Me.col_amount.Name = "col_amount"
        Me.col_amount.Visible = True
        Me.col_amount.VisibleIndex = 3
        Me.col_amount.Width = 118
        '
        'col_purchase_id
        '
        Me.col_purchase_id.AppearanceCell.Options.UseTextOptions = True
        Me.col_purchase_id.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_purchase_id.Caption = "Receipt Type"
        Me.col_purchase_id.FieldName = "receipt_type"
        Me.col_purchase_id.Name = "col_purchase_id"
        Me.col_purchase_id.Visible = True
        Me.col_purchase_id.VisibleIndex = 4
        Me.col_purchase_id.Width = 90
        '
        'col_bank
        '
        Me.col_bank.Caption = "Bank"
        Me.col_bank.FieldName = "bank"
        Me.col_bank.Name = "col_bank"
        Me.col_bank.Visible = True
        Me.col_bank.VisibleIndex = 6
        Me.col_bank.Width = 159
        '
        'col_cheque_no
        '
        Me.col_cheque_no.AppearanceCell.Options.UseTextOptions = True
        Me.col_cheque_no.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_cheque_no.Caption = "Cheque No"
        Me.col_cheque_no.FieldName = "payment_cheque"
        Me.col_cheque_no.Name = "col_cheque_no"
        Me.col_cheque_no.Visible = True
        Me.col_cheque_no.VisibleIndex = 7
        Me.col_cheque_no.Width = 96
        '
        'col_cheque_date
        '
        Me.col_cheque_date.AppearanceCell.Options.UseTextOptions = True
        Me.col_cheque_date.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_cheque_date.Caption = "Cheque Date"
        Me.col_cheque_date.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.col_cheque_date.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col_cheque_date.FieldName = "payment_dates"
        Me.col_cheque_date.Name = "col_cheque_date"
        Me.col_cheque_date.Visible = True
        Me.col_cheque_date.VisibleIndex = 8
        Me.col_cheque_date.Width = 149
        '
        'col_cashid
        '
        Me.col_cashid.AppearanceCell.Options.UseTextOptions = True
        Me.col_cashid.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_cashid.Caption = "Cash ID"
        Me.col_cashid.FieldName = "cash_id"
        Me.col_cashid.Name = "col_cashid"
        Me.col_cashid.Visible = True
        Me.col_cashid.VisibleIndex = 9
        '
        'txt_total_view
        '
        Me.txt_total_view.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_total_view.EditValue = ""
        Me.txt_total_view.Location = New System.Drawing.Point(873, 540)
        Me.txt_total_view.Name = "txt_total_view"
        Me.txt_total_view.Properties.Appearance.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold)
        Me.txt_total_view.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.txt_total_view.Properties.Appearance.Options.UseFont = True
        Me.txt_total_view.Properties.Appearance.Options.UseForeColor = True
        Me.txt_total_view.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_total_view.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_total_view.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.txt_total_view.Properties.ReadOnly = True
        Me.txt_total_view.Properties.UseReadOnlyAppearance = False
        Me.txt_total_view.Size = New System.Drawing.Size(179, 30)
        Me.txt_total_view.TabIndex = 22
        '
        'LabelControl9
        '
        Me.LabelControl9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl9.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Appearance.Options.UseForeColor = True
        Me.LabelControl9.Location = New System.Drawing.Point(726, 543)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(131, 22)
        Me.LabelControl9.TabIndex = 21
        Me.LabelControl9.Text = "Total Amount:"
        '
        'frm_accounting_generate_voucher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(1068, 582)
        Me.Controls.Add(Me.txt_total_view)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.grid_receipts_cheque)
        Me.Controls.Add(Me.GunaPanel4)
        Me.Name = "frm_accounting_generate_voucher"
        Me.Text = "frm_accounting_generate_voucher"
        Me.GunaPanel4.ResumeLayout(False)
        Me.GunaPanel4.PerformLayout()
        Me.GunaPanel5.ResumeLayout(False)
        Me.GunaPanel1.ResumeLayout(False)
        Me.GunaPanel1.PerformLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.panel_generate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_generate.ResumeLayout(False)
        Me.panel_generate.PerformLayout()
        CType(Me.txt_collection_ref.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbb_suppliers.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_receipts_cheque, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_receipts_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_total_view.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaPanel4 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPanel5 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents link_po_list As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents link_home As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbb_suppliers As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents grid_receipts_cheque As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_receipts_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_po_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_receipt_ref As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_amount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_cheque_date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_purchase_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_cheque_no As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_generate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_collection_ref As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents panel_generate As DevExpress.XtraEditors.PanelControl
    Friend WithEvents col_bank As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txt_total_view As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents rb_cash As RadioButton
    Friend WithEvents rb_cheque As RadioButton
    Friend WithEvents col_cashid As DevExpress.XtraGrid.Columns.GridColumn
End Class
