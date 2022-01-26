Imports System.ComponentModel
Imports System.Drawing.Drawing2D
Imports DevExpress.LookAndFeel
Imports DevExpress.Utils
Imports DevExpress.Utils.Layout
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports Guna.UI.WinForms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_admin_approval
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
        Me.panel_top = New Guna.UI.WinForms.GunaLinePanel()
        Me.GunaPanel5 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaPanel2 = New Guna.UI.WinForms.GunaPanel()
        Me.link_po_list = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.link_home = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.TablePanel2 = New DevExpress.Utils.Layout.TablePanel()
        Me.grid_quotation = New DevExpress.XtraGrid.GridControl()
        Me.grid_quotation_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_quotation_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_company = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.grid_stock_reconcilation = New DevExpress.XtraGrid.GridControl()
        Me.grid_stock_reconcilation_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_reconcile_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_reconcile_store = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_reconcile_item = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_reconcile_qty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_reconcile_type = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_reconcile_notes = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_reconcile_request_by = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btn_edit = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.btn_delete = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.grid_transfer = New DevExpress.XtraGrid.GridControl()
        Me.grid_transfer_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_transfer_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_transfer_from = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_transfer_status = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_transfer_to = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.grid_po = New DevExpress.XtraGrid.GridControl()
        Me.grid_po_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_poid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_date_generated = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_supplier = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_po_status = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TablePanel1 = New DevExpress.Utils.Layout.TablePanel()
        Me.grid_sales_returns = New DevExpress.XtraGrid.GridControl()
        Me.grid_sales_returns_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_srid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_customer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_amount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.grid_approval_units = New DevExpress.XtraGrid.GridControl()
        Me.grid_approval_units_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_pid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_model = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_description = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_status = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.panel_top.SuspendLayout()
        Me.GunaPanel5.SuspendLayout()
        Me.GunaPanel2.SuspendLayout()
        CType(Me.TablePanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TablePanel2.SuspendLayout()
        CType(Me.grid_quotation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_quotation_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_stock_reconcilation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_stock_reconcilation_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_edit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_delete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_transfer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_transfer_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_po, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_po_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TablePanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TablePanel1.SuspendLayout()
        CType(Me.grid_sales_returns, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_sales_returns_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_approval_units, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_approval_units_view, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel_top
        '
        Me.panel_top.BackColor = System.Drawing.Color.GhostWhite
        Me.panel_top.Controls.Add(Me.GunaPanel5)
        Me.panel_top.Controls.Add(Me.GunaLabel1)
        Me.panel_top.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_top.LineColor = System.Drawing.SystemColors.ControlLight
        Me.panel_top.LineStyle = System.Windows.Forms.BorderStyle.None
        Me.panel_top.Location = New System.Drawing.Point(0, 0)
        Me.panel_top.Name = "panel_top"
        Me.panel_top.Size = New System.Drawing.Size(1228, 78)
        Me.panel_top.TabIndex = 7
        '
        'GunaPanel5
        '
        Me.GunaPanel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaPanel5.BackColor = System.Drawing.Color.Transparent
        Me.GunaPanel5.Controls.Add(Me.GunaPanel2)
        Me.GunaPanel5.Location = New System.Drawing.Point(12, 44)
        Me.GunaPanel5.Name = "GunaPanel5"
        Me.GunaPanel5.Size = New System.Drawing.Size(1055, 27)
        Me.GunaPanel5.TabIndex = 6
        '
        'GunaPanel2
        '
        Me.GunaPanel2.Controls.Add(Me.link_po_list)
        Me.GunaPanel2.Controls.Add(Me.LabelControl7)
        Me.GunaPanel2.Controls.Add(Me.link_home)
        Me.GunaPanel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.GunaPanel2.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel2.Name = "GunaPanel2"
        Me.GunaPanel2.Size = New System.Drawing.Size(435, 27)
        Me.GunaPanel2.TabIndex = 1
        '
        'link_po_list
        '
        Me.link_po_list.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.link_po_list.Appearance.LinkColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.link_po_list.Appearance.Options.UseFont = True
        Me.link_po_list.Appearance.Options.UseLinkColor = True
        Me.link_po_list.AppearanceHovered.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.link_po_list.AppearanceHovered.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.link_po_list.AppearanceHovered.Options.UseForeColor = True
        Me.link_po_list.AppearanceHovered.Options.UseLinkColor = True
        Me.link_po_list.AppearancePressed.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.link_po_list.AppearancePressed.Options.UseLinkColor = True
        Me.link_po_list.Enabled = False
        Me.link_po_list.LineStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.link_po_list.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.link_po_list.Location = New System.Drawing.Point(70, 5)
        Me.link_po_list.Name = "link_po_list"
        Me.link_po_list.ShowLineShadow = False
        Me.link_po_list.Size = New System.Drawing.Size(62, 18)
        Me.link_po_list.TabIndex = 7
        Me.link_po_list.Text = "Approvals"
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
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.GunaLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.GunaLabel1.Location = New System.Drawing.Point(14, 10)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(135, 31)
        Me.GunaLabel1.TabIndex = 1
        Me.GunaLabel1.Text = "Approvals"
        '
        'TablePanel2
        '
        Me.TablePanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TablePanel2.Columns.AddRange(New DevExpress.Utils.Layout.TablePanelColumn() {New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 55.0!)})
        Me.TablePanel2.Controls.Add(Me.grid_quotation)
        Me.TablePanel2.Controls.Add(Me.LabelControl5)
        Me.TablePanel2.Controls.Add(Me.LabelControl3)
        Me.TablePanel2.Controls.Add(Me.grid_stock_reconcilation)
        Me.TablePanel2.Controls.Add(Me.LabelControl4)
        Me.TablePanel2.Controls.Add(Me.grid_transfer)
        Me.TablePanel2.Location = New System.Drawing.Point(12, 93)
        Me.TablePanel2.Name = "TablePanel2"
        Me.TablePanel2.Rows.AddRange(New DevExpress.Utils.Layout.TablePanelRow() {New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 25.0!), New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 171.0!), New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 51.0!), New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 255.0!), New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 116.0!), New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26.0!)})
        Me.TablePanel2.Size = New System.Drawing.Size(613, 657)
        Me.TablePanel2.TabIndex = 0
        '
        'grid_quotation
        '
        Me.TablePanel2.SetColumn(Me.grid_quotation, 0)
        Me.grid_quotation.Location = New System.Drawing.Point(3, 29)
        Me.grid_quotation.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grid_quotation.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grid_quotation.MainView = Me.grid_quotation_view
        Me.grid_quotation.Name = "grid_quotation"
        Me.TablePanel2.SetRow(Me.grid_quotation, 1)
        Me.grid_quotation.Size = New System.Drawing.Size(607, 215)
        Me.grid_quotation.TabIndex = 16
        Me.grid_quotation.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_quotation_view})
        '
        'grid_quotation_view
        '
        Me.grid_quotation_view.Appearance.HeaderPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.grid_quotation_view.Appearance.HeaderPanel.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.grid_quotation_view.Appearance.HeaderPanel.Options.UseFont = True
        Me.grid_quotation_view.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grid_quotation_view.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.grid_quotation_view.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grid_quotation_view.Appearance.Row.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.grid_quotation_view.Appearance.Row.Options.UseFont = True
        Me.grid_quotation_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_quotation_id, Me.col_company})
        Me.grid_quotation_view.GridControl = Me.grid_quotation
        Me.grid_quotation_view.Name = "grid_quotation_view"
        Me.grid_quotation_view.OptionsBehavior.Editable = False
        '
        'col_quotation_id
        '
        Me.col_quotation_id.AppearanceCell.ForeColor = System.Drawing.Color.SlateBlue
        Me.col_quotation_id.AppearanceCell.Options.UseForeColor = True
        Me.col_quotation_id.AppearanceCell.Options.UseTextOptions = True
        Me.col_quotation_id.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_quotation_id.AppearanceHeader.Options.UseTextOptions = True
        Me.col_quotation_id.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_quotation_id.Caption = "Quote ID"
        Me.col_quotation_id.FieldName = "quotation_id"
        Me.col_quotation_id.Name = "col_quotation_id"
        Me.col_quotation_id.Visible = True
        Me.col_quotation_id.VisibleIndex = 0
        Me.col_quotation_id.Width = 92
        '
        'col_company
        '
        Me.col_company.Caption = "Company"
        Me.col_company.FieldName = "company"
        Me.col_company.Name = "col_company"
        Me.col_company.Visible = True
        Me.col_company.VisibleIndex = 1
        Me.col_company.Width = 473
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl5.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Appearance.Options.UseForeColor = True
        Me.LabelControl5.Appearance.Options.UseTextOptions = True
        Me.LabelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.TablePanel2.SetColumn(Me.LabelControl5, 0)
        Me.LabelControl5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelControl5.Location = New System.Drawing.Point(3, 3)
        Me.LabelControl5.Name = "LabelControl5"
        Me.TablePanel2.SetRow(Me.LabelControl5, 0)
        Me.LabelControl5.Size = New System.Drawing.Size(607, 20)
        Me.LabelControl5.TabIndex = 15
        Me.LabelControl5.Text = "Quotation Approvals"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Appearance.Options.UseForeColor = True
        Me.LabelControl3.Appearance.Options.UseTextOptions = True
        Me.LabelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.TablePanel2.SetColumn(Me.LabelControl3, 0)
        Me.LabelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelControl3.Location = New System.Drawing.Point(3, 250)
        Me.LabelControl3.Name = "LabelControl3"
        Me.TablePanel2.SetRow(Me.LabelControl3, 2)
        Me.LabelControl3.Size = New System.Drawing.Size(607, 20)
        Me.LabelControl3.TabIndex = 4
        Me.LabelControl3.Text = "Stock Transfers"
        '
        'grid_stock_reconcilation
        '
        Me.TablePanel2.SetColumn(Me.grid_stock_reconcilation, 0)
        Me.grid_stock_reconcilation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid_stock_reconcilation.Location = New System.Drawing.Point(3, 496)
        Me.grid_stock_reconcilation.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grid_stock_reconcilation.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grid_stock_reconcilation.MainView = Me.grid_stock_reconcilation_view
        Me.grid_stock_reconcilation.Name = "grid_stock_reconcilation"
        Me.grid_stock_reconcilation.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.btn_edit, Me.btn_delete})
        Me.TablePanel2.SetRow(Me.grid_stock_reconcilation, 5)
        Me.grid_stock_reconcilation.Size = New System.Drawing.Size(607, 158)
        Me.grid_stock_reconcilation.TabIndex = 14
        Me.grid_stock_reconcilation.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_stock_reconcilation_view})
        '
        'grid_stock_reconcilation_view
        '
        Me.grid_stock_reconcilation_view.Appearance.HeaderPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.grid_stock_reconcilation_view.Appearance.HeaderPanel.Options.UseFont = True
        Me.grid_stock_reconcilation_view.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.grid_stock_reconcilation_view.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grid_stock_reconcilation_view.Appearance.Row.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_stock_reconcilation_view.Appearance.Row.Options.UseFont = True
        Me.grid_stock_reconcilation_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_reconcile_id, Me.GridColumn1, Me.col_reconcile_store, Me.col_reconcile_item, Me.col_reconcile_qty, Me.col_reconcile_type, Me.col_reconcile_notes, Me.col_reconcile_request_by})
        Me.grid_stock_reconcilation_view.GridControl = Me.grid_stock_reconcilation
        Me.grid_stock_reconcilation_view.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.grid_stock_reconcilation_view.Name = "grid_stock_reconcilation_view"
        Me.grid_stock_reconcilation_view.OptionsBehavior.Editable = False
        Me.grid_stock_reconcilation_view.OptionsView.AutoCalcPreviewLineCount = True
        Me.grid_stock_reconcilation_view.OptionsView.ColumnAutoWidth = False
        Me.grid_stock_reconcilation_view.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.[True]
        '
        'col_reconcile_id
        '
        Me.col_reconcile_id.AppearanceCell.ForeColor = System.Drawing.Color.SlateBlue
        Me.col_reconcile_id.AppearanceCell.Options.UseForeColor = True
        Me.col_reconcile_id.AppearanceCell.Options.UseTextOptions = True
        Me.col_reconcile_id.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_reconcile_id.Caption = "ID"
        Me.col_reconcile_id.FieldName = "id"
        Me.col_reconcile_id.Name = "col_reconcile_id"
        Me.col_reconcile_id.Visible = True
        Me.col_reconcile_id.VisibleIndex = 0
        Me.col_reconcile_id.Width = 78
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Status"
        Me.GridColumn1.FieldName = "status"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 5
        Me.GridColumn1.Width = 146
        '
        'col_reconcile_store
        '
        Me.col_reconcile_store.Caption = "Store / Warehouse"
        Me.col_reconcile_store.FieldName = "store_name"
        Me.col_reconcile_store.Name = "col_reconcile_store"
        Me.col_reconcile_store.Visible = True
        Me.col_reconcile_store.VisibleIndex = 4
        Me.col_reconcile_store.Width = 162
        '
        'col_reconcile_item
        '
        Me.col_reconcile_item.Caption = "Item"
        Me.col_reconcile_item.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.col_reconcile_item.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col_reconcile_item.FieldName = "winmodel"
        Me.col_reconcile_item.Name = "col_reconcile_item"
        Me.col_reconcile_item.Visible = True
        Me.col_reconcile_item.VisibleIndex = 3
        Me.col_reconcile_item.Width = 92
        '
        'col_reconcile_qty
        '
        Me.col_reconcile_qty.Caption = "Quantity"
        Me.col_reconcile_qty.FieldName = "qty"
        Me.col_reconcile_qty.Name = "col_reconcile_qty"
        Me.col_reconcile_qty.Visible = True
        Me.col_reconcile_qty.VisibleIndex = 2
        Me.col_reconcile_qty.Width = 56
        '
        'col_reconcile_type
        '
        Me.col_reconcile_type.AppearanceCell.Options.UseTextOptions = True
        Me.col_reconcile_type.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_reconcile_type.Caption = "Type"
        Me.col_reconcile_type.FieldName = "reconciled_type"
        Me.col_reconcile_type.Name = "col_reconcile_type"
        Me.col_reconcile_type.Visible = True
        Me.col_reconcile_type.VisibleIndex = 1
        Me.col_reconcile_type.Width = 80
        '
        'col_reconcile_notes
        '
        Me.col_reconcile_notes.Caption = "Notes"
        Me.col_reconcile_notes.FieldName = "notes"
        Me.col_reconcile_notes.Name = "col_reconcile_notes"
        Me.col_reconcile_notes.Visible = True
        Me.col_reconcile_notes.VisibleIndex = 6
        '
        'col_reconcile_request_by
        '
        Me.col_reconcile_request_by.Caption = "Request By"
        Me.col_reconcile_request_by.FieldName = "requested_by"
        Me.col_reconcile_request_by.Name = "col_reconcile_request_by"
        Me.col_reconcile_request_by.Visible = True
        Me.col_reconcile_request_by.VisibleIndex = 7
        '
        'btn_edit
        '
        Me.btn_edit.AutoHeight = False
        Me.btn_edit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)})
        Me.btn_edit.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'btn_delete
        '
        Me.btn_delete.AutoHeight = False
        Me.btn_delete.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)})
        Me.btn_delete.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl4.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Appearance.Options.UseForeColor = True
        Me.LabelControl4.Appearance.Options.UseTextOptions = True
        Me.LabelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.TablePanel2.SetColumn(Me.LabelControl4, 0)
        Me.LabelControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelControl4.Location = New System.Drawing.Point(3, 470)
        Me.LabelControl4.Name = "LabelControl4"
        Me.TablePanel2.SetRow(Me.LabelControl4, 4)
        Me.LabelControl4.Size = New System.Drawing.Size(607, 20)
        Me.LabelControl4.TabIndex = 6
        Me.LabelControl4.Text = "Reconcilations"
        '
        'grid_transfer
        '
        Me.TablePanel2.SetColumn(Me.grid_transfer, 0)
        Me.grid_transfer.Location = New System.Drawing.Point(3, 276)
        Me.grid_transfer.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grid_transfer.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grid_transfer.MainView = Me.grid_transfer_view
        Me.grid_transfer.Name = "grid_transfer"
        Me.TablePanel2.SetRow(Me.grid_transfer, 3)
        Me.grid_transfer.Size = New System.Drawing.Size(607, 188)
        Me.grid_transfer.TabIndex = 5
        Me.grid_transfer.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_transfer_view})
        '
        'grid_transfer_view
        '
        Me.grid_transfer_view.Appearance.HeaderPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.grid_transfer_view.Appearance.HeaderPanel.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.grid_transfer_view.Appearance.HeaderPanel.Options.UseFont = True
        Me.grid_transfer_view.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grid_transfer_view.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.grid_transfer_view.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grid_transfer_view.Appearance.Row.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.grid_transfer_view.Appearance.Row.Options.UseFont = True
        Me.grid_transfer_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_transfer_id, Me.col_transfer_from, Me.col_transfer_status, Me.col_transfer_to})
        Me.grid_transfer_view.GridControl = Me.grid_transfer
        Me.grid_transfer_view.Name = "grid_transfer_view"
        Me.grid_transfer_view.OptionsBehavior.Editable = False
        '
        'col_transfer_id
        '
        Me.col_transfer_id.AppearanceCell.ForeColor = System.Drawing.Color.SlateBlue
        Me.col_transfer_id.AppearanceCell.Options.UseForeColor = True
        Me.col_transfer_id.AppearanceCell.Options.UseTextOptions = True
        Me.col_transfer_id.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_transfer_id.AppearanceHeader.Options.UseTextOptions = True
        Me.col_transfer_id.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_transfer_id.Caption = "Transfer ID"
        Me.col_transfer_id.FieldName = "transfer_id"
        Me.col_transfer_id.Name = "col_transfer_id"
        Me.col_transfer_id.Visible = True
        Me.col_transfer_id.VisibleIndex = 0
        Me.col_transfer_id.Width = 82
        '
        'col_transfer_from
        '
        Me.col_transfer_from.Caption = "From"
        Me.col_transfer_from.FieldName = "transfer_from"
        Me.col_transfer_from.Name = "col_transfer_from"
        Me.col_transfer_from.Visible = True
        Me.col_transfer_from.VisibleIndex = 1
        Me.col_transfer_from.Width = 169
        '
        'col_transfer_status
        '
        Me.col_transfer_status.Caption = "Status"
        Me.col_transfer_status.FieldName = "status"
        Me.col_transfer_status.Name = "col_transfer_status"
        Me.col_transfer_status.Visible = True
        Me.col_transfer_status.VisibleIndex = 3
        Me.col_transfer_status.Width = 96
        '
        'col_transfer_to
        '
        Me.col_transfer_to.Caption = "To"
        Me.col_transfer_to.FieldName = "transfer_to"
        Me.col_transfer_to.Name = "col_transfer_to"
        Me.col_transfer_to.Visible = True
        Me.col_transfer_to.VisibleIndex = 2
        Me.col_transfer_to.Width = 132
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Appearance.Options.UseTextOptions = True
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.TablePanel1.SetColumn(Me.LabelControl1, 0)
        Me.LabelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelControl1.Location = New System.Drawing.Point(3, 471)
        Me.LabelControl1.Name = "LabelControl1"
        Me.TablePanel1.SetRow(Me.LabelControl1, 4)
        Me.LabelControl1.Size = New System.Drawing.Size(579, 20)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Inactive Units"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Appearance.Options.UseForeColor = True
        Me.LabelControl2.Appearance.Options.UseTextOptions = True
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.TablePanel1.SetColumn(Me.LabelControl2, 0)
        Me.LabelControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelControl2.Location = New System.Drawing.Point(3, 3)
        Me.LabelControl2.Name = "LabelControl2"
        Me.TablePanel1.SetRow(Me.LabelControl2, 0)
        Me.LabelControl2.Size = New System.Drawing.Size(579, 21)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "Purchase Orders"
        '
        'grid_po
        '
        Me.TablePanel1.SetColumn(Me.grid_po, 0)
        Me.grid_po.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid_po.Location = New System.Drawing.Point(3, 30)
        Me.grid_po.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grid_po.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grid_po.MainView = Me.grid_po_view
        Me.grid_po.Name = "grid_po"
        Me.TablePanel1.SetRow(Me.grid_po, 1)
        Me.grid_po.Size = New System.Drawing.Size(579, 215)
        Me.grid_po.TabIndex = 2
        Me.grid_po.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_po_view})
        '
        'grid_po_view
        '
        Me.grid_po_view.Appearance.HeaderPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.grid_po_view.Appearance.HeaderPanel.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.grid_po_view.Appearance.HeaderPanel.Options.UseFont = True
        Me.grid_po_view.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grid_po_view.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.grid_po_view.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grid_po_view.Appearance.Row.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.grid_po_view.Appearance.Row.Options.UseFont = True
        Me.grid_po_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_poid, Me.col_date_generated, Me.col_supplier, Me.col_po_status})
        Me.grid_po_view.GridControl = Me.grid_po
        Me.grid_po_view.Name = "grid_po_view"
        Me.grid_po_view.OptionsBehavior.Editable = False
        '
        'col_poid
        '
        Me.col_poid.AppearanceCell.ForeColor = System.Drawing.Color.SlateBlue
        Me.col_poid.AppearanceCell.Options.UseForeColor = True
        Me.col_poid.AppearanceCell.Options.UseTextOptions = True
        Me.col_poid.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_poid.AppearanceHeader.Options.UseTextOptions = True
        Me.col_poid.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_poid.Caption = "Purchase ID"
        Me.col_poid.FieldName = "purchase_id"
        Me.col_poid.Name = "col_poid"
        Me.col_poid.Visible = True
        Me.col_poid.VisibleIndex = 0
        Me.col_poid.Width = 121
        '
        'col_date_generated
        '
        Me.col_date_generated.AppearanceCell.Options.UseTextOptions = True
        Me.col_date_generated.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_date_generated.Caption = "Date Generated"
        Me.col_date_generated.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.col_date_generated.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col_date_generated.FieldName = "date_generated"
        Me.col_date_generated.Name = "col_date_generated"
        Me.col_date_generated.Visible = True
        Me.col_date_generated.VisibleIndex = 1
        Me.col_date_generated.Width = 119
        '
        'col_supplier
        '
        Me.col_supplier.Caption = "Supplier"
        Me.col_supplier.FieldName = "supplier"
        Me.col_supplier.Name = "col_supplier"
        Me.col_supplier.Visible = True
        Me.col_supplier.VisibleIndex = 2
        Me.col_supplier.Width = 222
        '
        'col_po_status
        '
        Me.col_po_status.Caption = "Status"
        Me.col_po_status.FieldName = "status"
        Me.col_po_status.Name = "col_po_status"
        Me.col_po_status.Visible = True
        Me.col_po_status.VisibleIndex = 3
        Me.col_po_status.Width = 94
        '
        'TablePanel1
        '
        Me.TablePanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TablePanel1.Appearance.BackColor = System.Drawing.Color.White
        Me.TablePanel1.Appearance.Options.UseBackColor = True
        Me.TablePanel1.Columns.AddRange(New DevExpress.Utils.Layout.TablePanelColumn() {New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 30.04!)})
        Me.TablePanel1.Controls.Add(Me.grid_sales_returns)
        Me.TablePanel1.Controls.Add(Me.LabelControl6)
        Me.TablePanel1.Controls.Add(Me.grid_approval_units)
        Me.TablePanel1.Controls.Add(Me.LabelControl1)
        Me.TablePanel1.Controls.Add(Me.grid_po)
        Me.TablePanel1.Controls.Add(Me.LabelControl2)
        Me.TablePanel1.Location = New System.Drawing.Point(631, 93)
        Me.TablePanel1.Name = "TablePanel1"
        Me.TablePanel1.Rows.AddRange(New DevExpress.Utils.Layout.TablePanelRow() {New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 27.0!), New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 221.0!), New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26.0!), New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 194.0!), New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26.0!), New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26.0!)})
        Me.TablePanel1.Size = New System.Drawing.Size(585, 657)
        Me.TablePanel1.TabIndex = 8
        '
        'grid_sales_returns
        '
        Me.TablePanel1.SetColumn(Me.grid_sales_returns, 0)
        Me.grid_sales_returns.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid_sales_returns.Location = New System.Drawing.Point(3, 277)
        Me.grid_sales_returns.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grid_sales_returns.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grid_sales_returns.MainView = Me.grid_sales_returns_view
        Me.grid_sales_returns.Name = "grid_sales_returns"
        Me.TablePanel1.SetRow(Me.grid_sales_returns, 3)
        Me.grid_sales_returns.Size = New System.Drawing.Size(579, 188)
        Me.grid_sales_returns.TabIndex = 5
        Me.grid_sales_returns.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_sales_returns_view})
        '
        'grid_sales_returns_view
        '
        Me.grid_sales_returns_view.Appearance.HeaderPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.grid_sales_returns_view.Appearance.HeaderPanel.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.grid_sales_returns_view.Appearance.HeaderPanel.Options.UseFont = True
        Me.grid_sales_returns_view.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grid_sales_returns_view.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.grid_sales_returns_view.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grid_sales_returns_view.Appearance.Row.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.grid_sales_returns_view.Appearance.Row.Options.UseFont = True
        Me.grid_sales_returns_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_srid, Me.col_customer, Me.col_amount})
        Me.grid_sales_returns_view.GridControl = Me.grid_sales_returns
        Me.grid_sales_returns_view.Name = "grid_sales_returns_view"
        Me.grid_sales_returns_view.OptionsBehavior.Editable = False
        '
        'col_srid
        '
        Me.col_srid.AppearanceCell.ForeColor = System.Drawing.Color.SlateBlue
        Me.col_srid.AppearanceCell.Options.UseForeColor = True
        Me.col_srid.AppearanceCell.Options.UseTextOptions = True
        Me.col_srid.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_srid.AppearanceHeader.Options.UseTextOptions = True
        Me.col_srid.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_srid.Caption = "SRID"
        Me.col_srid.FieldName = "srid"
        Me.col_srid.Name = "col_srid"
        Me.col_srid.Visible = True
        Me.col_srid.VisibleIndex = 0
        Me.col_srid.Width = 83
        '
        'col_customer
        '
        Me.col_customer.Caption = "Customer"
        Me.col_customer.FieldName = "customer"
        Me.col_customer.Name = "col_customer"
        Me.col_customer.Visible = True
        Me.col_customer.VisibleIndex = 1
        Me.col_customer.Width = 244
        '
        'col_amount
        '
        Me.col_amount.Caption = "Amount"
        Me.col_amount.FieldName = "amount"
        Me.col_amount.Name = "col_amount"
        Me.col_amount.Visible = True
        Me.col_amount.VisibleIndex = 2
        Me.col_amount.Width = 104
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl6.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Appearance.Options.UseForeColor = True
        Me.LabelControl6.Appearance.Options.UseTextOptions = True
        Me.LabelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.LabelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.TablePanel1.SetColumn(Me.LabelControl6, 0)
        Me.LabelControl6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelControl6.Location = New System.Drawing.Point(3, 251)
        Me.LabelControl6.Name = "LabelControl6"
        Me.TablePanel1.SetRow(Me.LabelControl6, 2)
        Me.LabelControl6.Size = New System.Drawing.Size(579, 20)
        Me.LabelControl6.TabIndex = 4
        Me.LabelControl6.Text = "Sales Returns"
        '
        'grid_approval_units
        '
        Me.TablePanel1.SetColumn(Me.grid_approval_units, 0)
        Me.grid_approval_units.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid_approval_units.Location = New System.Drawing.Point(3, 497)
        Me.grid_approval_units.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grid_approval_units.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grid_approval_units.MainView = Me.grid_approval_units_view
        Me.grid_approval_units.Name = "grid_approval_units"
        Me.TablePanel1.SetRow(Me.grid_approval_units, 5)
        Me.grid_approval_units.Size = New System.Drawing.Size(579, 157)
        Me.grid_approval_units.TabIndex = 0
        Me.grid_approval_units.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_approval_units_view})
        '
        'grid_approval_units_view
        '
        Me.grid_approval_units_view.Appearance.HeaderPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.grid_approval_units_view.Appearance.HeaderPanel.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.grid_approval_units_view.Appearance.HeaderPanel.Options.UseFont = True
        Me.grid_approval_units_view.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grid_approval_units_view.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.grid_approval_units_view.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grid_approval_units_view.Appearance.Row.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.grid_approval_units_view.Appearance.Row.Options.UseFont = True
        Me.grid_approval_units_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_pid, Me.col_model, Me.col_description, Me.col_status})
        Me.grid_approval_units_view.GridControl = Me.grid_approval_units
        Me.grid_approval_units_view.Name = "grid_approval_units_view"
        Me.grid_approval_units_view.OptionsBehavior.Editable = False
        '
        'col_pid
        '
        Me.col_pid.AppearanceCell.ForeColor = System.Drawing.Color.SlateBlue
        Me.col_pid.AppearanceCell.Options.UseForeColor = True
        Me.col_pid.AppearanceCell.Options.UseTextOptions = True
        Me.col_pid.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_pid.AppearanceHeader.Options.UseTextOptions = True
        Me.col_pid.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_pid.Caption = "Product No."
        Me.col_pid.FieldName = "pid"
        Me.col_pid.Name = "col_pid"
        Me.col_pid.Visible = True
        Me.col_pid.VisibleIndex = 0
        Me.col_pid.Width = 83
        '
        'col_model
        '
        Me.col_model.Caption = "Model"
        Me.col_model.FieldName = "winmodel"
        Me.col_model.Name = "col_model"
        Me.col_model.Visible = True
        Me.col_model.VisibleIndex = 1
        Me.col_model.Width = 123
        '
        'col_description
        '
        Me.col_description.Caption = "Description"
        Me.col_description.FieldName = "description"
        Me.col_description.Name = "col_description"
        Me.col_description.Visible = True
        Me.col_description.VisibleIndex = 2
        Me.col_description.Width = 244
        '
        'col_status
        '
        Me.col_status.Caption = "Status"
        Me.col_status.FieldName = "status"
        Me.col_status.Name = "col_status"
        Me.col_status.Visible = True
        Me.col_status.VisibleIndex = 3
        Me.col_status.Width = 104
        '
        'frm_admin_approval
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1228, 762)
        Me.Controls.Add(Me.TablePanel2)
        Me.Controls.Add(Me.TablePanel1)
        Me.Controls.Add(Me.panel_top)
        Me.Name = "frm_admin_approval"
        Me.Text = "frm_admin_approval"
        Me.panel_top.ResumeLayout(False)
        Me.panel_top.PerformLayout()
        Me.GunaPanel5.ResumeLayout(False)
        Me.GunaPanel2.ResumeLayout(False)
        Me.GunaPanel2.PerformLayout()
        CType(Me.TablePanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TablePanel2.ResumeLayout(False)
        Me.TablePanel2.PerformLayout()
        CType(Me.grid_quotation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_quotation_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_stock_reconcilation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_stock_reconcilation_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_edit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_delete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_transfer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_transfer_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_po, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_po_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TablePanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TablePanel1.ResumeLayout(False)
        Me.TablePanel1.PerformLayout()
        CType(Me.grid_sales_returns, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_sales_returns_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_approval_units, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_approval_units_view, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panel_top As Guna.UI.WinForms.GunaLinePanel
    Friend WithEvents GunaPanel5 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPanel2 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents link_po_list As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents link_home As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents TablePanel1 As DevExpress.Utils.Layout.TablePanel
    Friend WithEvents TablePanel2 As DevExpress.Utils.Layout.TablePanel
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grid_approval_units As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_approval_units_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_model As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_description As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_pid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grid_po As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_po_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents grid_quotation As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_quotation_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_poid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_quotation_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_supplier As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_company As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_po_status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grid_transfer As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_transfer_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_transfer_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_transfer_from As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_transfer_status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents col_transfer_to As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_date_generated As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grid_stock_reconcilation As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_stock_reconcilation_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_reconcile_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_reconcile_store As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_reconcile_item As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_edit As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents btn_delete As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents col_reconcile_qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_reconcile_type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_reconcile_notes As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_reconcile_request_by As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grid_sales_returns As GridControl
    Friend WithEvents grid_sales_returns_view As GridView
    Friend WithEvents col_srid As GridColumn
    Friend WithEvents col_customer As GridColumn
    Friend WithEvents col_amount As GridColumn
    Friend WithEvents LabelControl6 As LabelControl

End Class
