<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_accounting_generate_cheque
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
        Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_accounting_generate_cheque))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.GunaPanel4 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaPanel5 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.link_po_list = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.link_home = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.grid_receipts = New DevExpress.XtraGrid.GridControl()
        Me.grid_receipts_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_po_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_receipt_ref = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_amount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_date_received = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_purchase_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_terms = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_due_date = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.btn_generate = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.cb_crossed_check = New System.Windows.Forms.CheckBox()
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit()
        Me.txt_acc_name = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_acc_no = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.cbb_banks = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_payee = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_cheque_date = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_cheque_no = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.cbb_suppliers = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_total_view = New DevExpress.XtraEditors.TextEdit()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.GunaPanel4.SuspendLayout()
        Me.GunaPanel5.SuspendLayout()
        Me.GunaPanel1.SuspendLayout()
        CType(Me.grid_receipts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_receipts_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.DateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_acc_name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_acc_no.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbb_banks.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_payee.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_cheque_date.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_cheque_no.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbb_suppliers.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_total_view.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
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
        Me.GunaPanel4.Size = New System.Drawing.Size(1188, 78)
        Me.GunaPanel4.TabIndex = 12
        '
        'GunaPanel5
        '
        Me.GunaPanel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaPanel5.BackColor = System.Drawing.Color.Transparent
        Me.GunaPanel5.Controls.Add(Me.GunaPanel1)
        Me.GunaPanel5.Location = New System.Drawing.Point(19, 44)
        Me.GunaPanel5.Name = "GunaPanel5"
        Me.GunaPanel5.Size = New System.Drawing.Size(1153, 27)
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
        Me.link_po_list.Size = New System.Drawing.Size(109, 18)
        Me.link_po_list.TabIndex = 7
        Me.link_po_list.Text = "Generate Cheque"
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
        Me.GunaLabel2.Size = New System.Drawing.Size(229, 31)
        Me.GunaLabel2.TabIndex = 1
        Me.GunaLabel2.Text = "Generate Cheque"
        '
        'grid_receipts
        '
        Me.grid_receipts.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_receipts.Location = New System.Drawing.Point(315, 144)
        Me.grid_receipts.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grid_receipts.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grid_receipts.MainView = Me.grid_receipts_view
        Me.grid_receipts.Name = "grid_receipts"
        Me.grid_receipts.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoEdit1})
        Me.grid_receipts.Size = New System.Drawing.Size(855, 379)
        Me.grid_receipts.TabIndex = 13
        Me.grid_receipts.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_receipts_view})
        '
        'grid_receipts_view
        '
        Me.grid_receipts_view.Appearance.HeaderPanel.Font = New System.Drawing.Font("Nunito", 9.749999!)
        Me.grid_receipts_view.Appearance.HeaderPanel.Options.UseFont = True
        Me.grid_receipts_view.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.grid_receipts_view.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grid_receipts_view.Appearance.Row.Font = New System.Drawing.Font("Nunito", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_receipts_view.Appearance.Row.Options.UseFont = True
        Me.grid_receipts_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_id, Me.col_po_id, Me.col_receipt_ref, Me.col_amount, Me.col_date_received, Me.col_purchase_id, Me.col_terms, Me.col_due_date})
        Me.grid_receipts_view.GridControl = Me.grid_receipts
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
        Me.col_id.Caption = "ID"
        Me.col_id.FieldName = "payable_id"
        Me.col_id.Name = "col_id"
        Me.col_id.Visible = True
        Me.col_id.VisibleIndex = 1
        Me.col_id.Width = 46
        '
        'col_po_id
        '
        Me.col_po_id.AppearanceCell.Options.UseTextOptions = True
        Me.col_po_id.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_po_id.Caption = "Purchase ID"
        Me.col_po_id.FieldName = "purchase_id"
        Me.col_po_id.Name = "col_po_id"
        Me.col_po_id.Visible = True
        Me.col_po_id.VisibleIndex = 4
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
        Me.col_receipt_ref.VisibleIndex = 6
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
        Me.col_amount.VisibleIndex = 7
        Me.col_amount.Width = 118
        '
        'col_date_received
        '
        Me.col_date_received.AppearanceCell.Options.UseTextOptions = True
        Me.col_date_received.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_date_received.Caption = "Date Received"
        Me.col_date_received.DisplayFormat.FormatString = "MMMM dd, yyyy"
        Me.col_date_received.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col_date_received.FieldName = "received_date"
        Me.col_date_received.Name = "col_date_received"
        Me.col_date_received.Visible = True
        Me.col_date_received.VisibleIndex = 3
        Me.col_date_received.Width = 149
        '
        'col_purchase_id
        '
        Me.col_purchase_id.AppearanceCell.Options.UseTextOptions = True
        Me.col_purchase_id.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_purchase_id.Caption = "Receipt Type"
        Me.col_purchase_id.FieldName = "receipt_type"
        Me.col_purchase_id.Name = "col_purchase_id"
        Me.col_purchase_id.Visible = True
        Me.col_purchase_id.VisibleIndex = 5
        Me.col_purchase_id.Width = 90
        '
        'col_terms
        '
        Me.col_terms.AppearanceCell.Options.UseTextOptions = True
        Me.col_terms.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_terms.Caption = "Terms"
        Me.col_terms.FieldName = "terms"
        Me.col_terms.Name = "col_terms"
        Me.col_terms.Visible = True
        Me.col_terms.VisibleIndex = 8
        '
        'col_due_date
        '
        Me.col_due_date.AppearanceCell.Options.UseTextOptions = True
        Me.col_due_date.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_due_date.Caption = "Due Date"
        Me.col_due_date.DisplayFormat.FormatString = "MMMM dd, yyyy"
        Me.col_due_date.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col_due_date.FieldName = "due_date"
        Me.col_due_date.Name = "col_due_date"
        Me.col_due_date.Visible = True
        Me.col_due_date.VisibleIndex = 2
        Me.col_due_date.Width = 143
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        '
        'btn_generate
        '
        Me.btn_generate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_generate.Appearance.BackColor = System.Drawing.Color.DarkKhaki
        Me.btn_generate.Appearance.Options.UseBackColor = True
        Me.btn_generate.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.createmodeldifferences_16x16
        Me.btn_generate.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_generate.Location = New System.Drawing.Point(155, 263)
        Me.btn_generate.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_generate.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_generate.Name = "btn_generate"
        Me.btn_generate.Size = New System.Drawing.Size(118, 30)
        Me.btn_generate.TabIndex = 8
        Me.btn_generate.Text = "Generate Cheque"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.cb_crossed_check)
        Me.PanelControl1.Controls.Add(Me.DateEdit1)
        Me.PanelControl1.Controls.Add(Me.txt_acc_name)
        Me.PanelControl1.Controls.Add(Me.LabelControl11)
        Me.PanelControl1.Controls.Add(Me.LabelControl10)
        Me.PanelControl1.Controls.Add(Me.txt_acc_no)
        Me.PanelControl1.Controls.Add(Me.LabelControl6)
        Me.PanelControl1.Controls.Add(Me.LabelControl5)
        Me.PanelControl1.Controls.Add(Me.cbb_banks)
        Me.PanelControl1.Controls.Add(Me.LabelControl4)
        Me.PanelControl1.Controls.Add(Me.txt_payee)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.txt_cheque_date)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.txt_cheque_no)
        Me.PanelControl1.Controls.Add(Me.btn_generate)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 104)
        Me.PanelControl1.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.PanelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(290, 307)
        Me.PanelControl1.TabIndex = 14
        '
        'cb_crossed_check
        '
        Me.cb_crossed_check.AutoSize = True
        Me.cb_crossed_check.Checked = True
        Me.cb_crossed_check.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cb_crossed_check.Location = New System.Drawing.Point(16, 251)
        Me.cb_crossed_check.Name = "cb_crossed_check"
        Me.cb_crossed_check.Size = New System.Drawing.Size(127, 17)
        Me.cb_crossed_check.TabIndex = 20
        Me.cb_crossed_check.Text = "Apply Crossed Check"
        Me.cb_crossed_check.UseVisualStyleBackColor = True
        '
        'DateEdit1
        '
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.Location = New System.Drawing.Point(224, 79)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.DateEdit1.Properties.Appearance.Options.UseFont = True
        EditorButtonImageOptions1.Image = CType(resources.GetObject("EditorButtonImageOptions1.Image"), System.Drawing.Image)
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.DateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.ClassicNew
        Me.DateEdit1.Properties.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.DateEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.DateEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        Me.DateEdit1.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[False]
        Me.DateEdit1.Size = New System.Drawing.Size(28, 22)
        Me.DateEdit1.TabIndex = 19
        '
        'txt_acc_name
        '
        Me.txt_acc_name.Location = New System.Drawing.Point(122, 213)
        Me.txt_acc_name.Name = "txt_acc_name"
        Me.txt_acc_name.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.txt_acc_name.Properties.Appearance.Options.UseFont = True
        Me.txt_acc_name.Size = New System.Drawing.Size(149, 22)
        Me.txt_acc_name.TabIndex = 6
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl11.Appearance.Options.UseFont = True
        Me.LabelControl11.Location = New System.Drawing.Point(16, 216)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(87, 16)
        Me.LabelControl11.TabIndex = 18
        Me.LabelControl11.Text = "Account Name:"
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl10.Appearance.Options.UseBackColor = True
        Me.LabelControl10.Appearance.Options.UseFont = True
        Me.LabelControl10.Appearance.Options.UseForeColor = True
        Me.LabelControl10.Appearance.Options.UseTextOptions = True
        Me.LabelControl10.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.LabelControl10.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl10.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelControl10.Location = New System.Drawing.Point(2, 2)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.LabelControl10.Size = New System.Drawing.Size(286, 25)
        Me.LabelControl10.TabIndex = 16
        Me.LabelControl10.Text = "Cheque Details"
        '
        'txt_acc_no
        '
        Me.txt_acc_no.Location = New System.Drawing.Point(122, 183)
        Me.txt_acc_no.Name = "txt_acc_no"
        Me.txt_acc_no.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.txt_acc_no.Properties.Appearance.Options.UseFont = True
        Me.txt_acc_no.Size = New System.Drawing.Size(149, 22)
        Me.txt_acc_no.TabIndex = 5
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(16, 186)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(73, 16)
        Me.LabelControl6.TabIndex = 9
        Me.LabelControl6.Text = "Account No.:"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(16, 156)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(76, 16)
        Me.LabelControl5.TabIndex = 8
        Me.LabelControl5.Text = "Payee Name:"
        '
        'cbb_banks
        '
        Me.cbb_banks.Location = New System.Drawing.Point(122, 109)
        Me.cbb_banks.Name = "cbb_banks"
        Me.cbb_banks.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.cbb_banks.Properties.Appearance.Options.UseFont = True
        Me.cbb_banks.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_banks.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cbb_banks.Size = New System.Drawing.Size(151, 22)
        Me.cbb_banks.TabIndex = 3
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(19, 112)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(72, 16)
        Me.LabelControl4.TabIndex = 6
        Me.LabelControl4.Text = "*Bank Type:"
        '
        'txt_payee
        '
        Me.txt_payee.Location = New System.Drawing.Point(122, 153)
        Me.txt_payee.Name = "txt_payee"
        Me.txt_payee.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.txt_payee.Properties.Appearance.Options.UseFont = True
        Me.txt_payee.Size = New System.Drawing.Size(149, 22)
        Me.txt_payee.TabIndex = 4
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(19, 82)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(86, 16)
        Me.LabelControl2.TabIndex = 4
        Me.LabelControl2.Text = "*Cheque Date:"
        '
        'txt_cheque_date
        '
        Me.txt_cheque_date.Location = New System.Drawing.Point(122, 79)
        Me.txt_cheque_date.Name = "txt_cheque_date"
        Me.txt_cheque_date.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.txt_cheque_date.Properties.Appearance.Options.UseFont = True
        Me.txt_cheque_date.Size = New System.Drawing.Size(100, 22)
        Me.txt_cheque_date.TabIndex = 2
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(19, 52)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(79, 16)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "*Cheque No.:"
        '
        'txt_cheque_no
        '
        Me.txt_cheque_no.Location = New System.Drawing.Point(122, 49)
        Me.txt_cheque_no.Name = "txt_cheque_no"
        Me.txt_cheque_no.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.txt_cheque_no.Properties.Appearance.Options.UseFont = True
        Me.txt_cheque_no.Size = New System.Drawing.Size(100, 22)
        Me.txt_cheque_no.TabIndex = 1
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(9, 11)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(42, 13)
        Me.LabelControl3.TabIndex = 5
        Me.LabelControl3.Text = "Supplier:"
        '
        'cbb_suppliers
        '
        Me.cbb_suppliers.Location = New System.Drawing.Point(63, 8)
        Me.cbb_suppliers.Name = "cbb_suppliers"
        Me.cbb_suppliers.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_suppliers.Size = New System.Drawing.Size(182, 20)
        Me.cbb_suppliers.TabIndex = 0
        '
        'LabelControl9
        '
        Me.LabelControl9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl9.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Appearance.Options.UseForeColor = True
        Me.LabelControl9.Location = New System.Drawing.Point(844, 538)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(131, 22)
        Me.LabelControl9.TabIndex = 15
        Me.LabelControl9.Text = "Total Amount:"
        '
        'txt_total_view
        '
        Me.txt_total_view.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_total_view.EditValue = ""
        Me.txt_total_view.Location = New System.Drawing.Point(991, 535)
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
        Me.txt_total_view.TabIndex = 17
        '
        'PanelControl2
        '
        Me.PanelControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl2.Controls.Add(Me.LabelControl3)
        Me.PanelControl2.Controls.Add(Me.cbb_suppliers)
        Me.PanelControl2.Location = New System.Drawing.Point(315, 104)
        Me.PanelControl2.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.PanelControl2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(855, 34)
        Me.PanelControl2.TabIndex = 18
        '
        'frm_accounting_generate_cheque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1188, 578)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.txt_total_view)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.grid_receipts)
        Me.Controls.Add(Me.GunaPanel4)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_accounting_generate_cheque"
        Me.Text = "frm_accounting_generate_cheque"
        Me.GunaPanel4.ResumeLayout(False)
        Me.GunaPanel4.PerformLayout()
        Me.GunaPanel5.ResumeLayout(False)
        Me.GunaPanel1.ResumeLayout(False)
        Me.GunaPanel1.PerformLayout()
        CType(Me.grid_receipts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_receipts_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.DateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_acc_name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_acc_no.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbb_banks.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_payee.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_cheque_date.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_cheque_no.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbb_suppliers.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_total_view.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
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
    Friend WithEvents grid_receipts As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_receipts_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_receipt_ref As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_amount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_date_received As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_purchase_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents btn_generate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cbb_suppliers As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_cheque_date As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_cheque_no As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_acc_no As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbb_banks As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_payee As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_total_view As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents col_terms As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_due_date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_po_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txt_acc_name As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cb_crossed_check As CheckBox
End Class
