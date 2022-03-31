Imports DevExpress.LookAndFeel
Imports DevExpress.XtraEditors
Imports Guna.UI.WinForms
Imports System.ComponentModel
Imports System.Drawing.Drawing2D


<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_warehouse_receivingManagement
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
        Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim EditorButtonImageOptions2 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject5 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject6 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject7 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject8 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim EditorButtonImageOptions3 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject9 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject10 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject11 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject12 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.btn_view_order = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.link_po_list = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.link_home = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.lbl_ClicktoView_1 = New System.Windows.Forms.Label()
        Me.grid_delivery = New DevExpress.XtraGrid.GridControl()
        Me.grid_delivery_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_lead_time = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_purchase_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_supplier = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_status = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_action = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btn_view = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.tabcontrol = New System.Windows.Forms.TabControl()
        Me.tab_supplierDeliveries = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.panel_supplierDeliveries = New DevExpress.XtraEditors.PanelControl()
        Me.tab_stockTransfer = New System.Windows.Forms.TabPage()
        Me.grid_stock_transfers = New DevExpress.XtraGrid.GridControl()
        Me.grid_stock_transfers_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_view = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_transfer_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_transfer_type = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_src_warehouse = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_linked_warehouse = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.panel_stockTransfers = New DevExpress.XtraEditors.PanelControl()
        Me.lbl_ClicktoView_2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tab_sales_returns = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.panel_sales_return = New DevExpress.XtraEditors.PanelControl()
        Me.lbl_sales_return = New System.Windows.Forms.Label()
        Me.grid_sales_returns = New DevExpress.XtraGrid.GridControl()
        Me.grid_sales_returns_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_srid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_customer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_sales_return_action = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btn_view_srid = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.col_created_by = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbl_head = New System.Windows.Forms.Label()
        Me.col_warehouse = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.btn_view_order, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_delivery, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_delivery_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_view, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabcontrol.SuspendLayout()
        Me.tab_supplierDeliveries.SuspendLayout()
        CType(Me.panel_supplierDeliveries, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_supplierDeliveries.SuspendLayout()
        Me.tab_stockTransfer.SuspendLayout()
        CType(Me.grid_stock_transfers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_stock_transfers_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panel_stockTransfers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_stockTransfers.SuspendLayout()
        Me.tab_sales_returns.SuspendLayout()
        CType(Me.panel_sales_return, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_sales_return.SuspendLayout()
        CType(Me.grid_sales_returns, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_sales_returns_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_view_srid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_view_order
        '
        Me.btn_view_order.AutoHeight = False
        EditorButtonImageOptions1.Image = Global.Inventory_Management.My.Resources.Resources.snapmodifytablecellstyle_16x16
        Me.btn_view_order.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.btn_view_order.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_view_order.Name = "btn_view_order"
        Me.btn_view_order.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
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
        Me.link_po_list.Location = New System.Drawing.Point(68, 5)
        Me.link_po_list.Name = "link_po_list"
        Me.link_po_list.ShowLineShadow = False
        Me.link_po_list.Size = New System.Drawing.Size(146, 18)
        Me.link_po_list.TabIndex = 7
        Me.link_po_list.Text = "Receiving Management"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Location = New System.Drawing.Point(53, 7)
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
        Me.link_home.Location = New System.Drawing.Point(11, 5)
        Me.link_home.Name = "link_home"
        Me.link_home.ShowLineShadow = False
        Me.link_home.Size = New System.Drawing.Size(37, 18)
        Me.link_home.TabIndex = 5
        Me.link_home.Text = "Home"
        '
        'lbl_ClicktoView_1
        '
        Me.lbl_ClicktoView_1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_ClicktoView_1.AutoSize = True
        Me.lbl_ClicktoView_1.BackColor = System.Drawing.Color.Transparent
        Me.lbl_ClicktoView_1.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.lbl_ClicktoView_1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbl_ClicktoView_1.Location = New System.Drawing.Point(341, 267)
        Me.lbl_ClicktoView_1.Name = "lbl_ClicktoView_1"
        Me.lbl_ClicktoView_1.Size = New System.Drawing.Size(199, 23)
        Me.lbl_ClicktoView_1.TabIndex = 0
        Me.lbl_ClicktoView_1.Text = "Click Deliveries to View"
        '
        'grid_delivery
        '
        Me.grid_delivery.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grid_delivery.Location = New System.Drawing.Point(6, 55)
        Me.grid_delivery.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grid_delivery.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grid_delivery.MainView = Me.grid_delivery_view
        Me.grid_delivery.Name = "grid_delivery"
        Me.grid_delivery.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.btn_view})
        Me.grid_delivery.Size = New System.Drawing.Size(414, 534)
        Me.grid_delivery.TabIndex = 1
        Me.grid_delivery.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_delivery_view})
        '
        'grid_delivery_view
        '
        Me.grid_delivery_view.Appearance.HeaderPanel.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.grid_delivery_view.Appearance.HeaderPanel.Options.UseFont = True
        Me.grid_delivery_view.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.grid_delivery_view.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grid_delivery_view.Appearance.Row.Font = New System.Drawing.Font("Arial", 9.5!)
        Me.grid_delivery_view.Appearance.Row.Options.UseFont = True
        Me.grid_delivery_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_lead_time, Me.col_purchase_id, Me.col_supplier, Me.col_status, Me.col_action})
        Me.grid_delivery_view.GridControl = Me.grid_delivery
        Me.grid_delivery_view.Name = "grid_delivery_view"
        Me.grid_delivery_view.OptionsBehavior.ReadOnly = True
        Me.grid_delivery_view.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.[False]
        '
        'col_lead_time
        '
        Me.col_lead_time.Caption = "EDD"
        Me.col_lead_time.DisplayFormat.FormatString = "dd MMM"
        Me.col_lead_time.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col_lead_time.FieldName = "lead_time"
        Me.col_lead_time.MaxWidth = 70
        Me.col_lead_time.Name = "col_lead_time"
        Me.col_lead_time.OptionsColumn.AllowEdit = False
        Me.col_lead_time.Visible = True
        Me.col_lead_time.VisibleIndex = 1
        Me.col_lead_time.Width = 62
        '
        'col_purchase_id
        '
        Me.col_purchase_id.Caption = "Purchase ID"
        Me.col_purchase_id.FieldName = "poid"
        Me.col_purchase_id.MaxWidth = 90
        Me.col_purchase_id.Name = "col_purchase_id"
        Me.col_purchase_id.Visible = True
        Me.col_purchase_id.VisibleIndex = 2
        Me.col_purchase_id.Width = 79
        '
        'col_supplier
        '
        Me.col_supplier.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col_supplier.AppearanceCell.Options.UseFont = True
        Me.col_supplier.Caption = "Supplier"
        Me.col_supplier.FieldName = "supplier"
        Me.col_supplier.Name = "col_supplier"
        Me.col_supplier.Visible = True
        Me.col_supplier.VisibleIndex = 3
        Me.col_supplier.Width = 222
        '
        'col_status
        '
        Me.col_status.Caption = "Status"
        Me.col_status.FieldName = "lead_time_status"
        Me.col_status.Name = "col_status"
        '
        'col_action
        '
        Me.col_action.ColumnEdit = Me.btn_view
        Me.col_action.Name = "col_action"
        Me.col_action.Visible = True
        Me.col_action.VisibleIndex = 0
        Me.col_action.Width = 40
        '
        'btn_view
        '
        Me.btn_view.AutoHeight = False
        EditorButtonImageOptions2.Image = Global.Inventory_Management.My.Resources.Resources.up_16x16
        Me.btn_view.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions2, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, SerializableAppearanceObject6, SerializableAppearanceObject7, SerializableAppearanceObject8, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.btn_view.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_view.Name = "btn_view"
        Me.btn_view.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'tabcontrol
        '
        Me.tabcontrol.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabcontrol.Controls.Add(Me.tab_supplierDeliveries)
        Me.tabcontrol.Controls.Add(Me.tab_stockTransfer)
        Me.tabcontrol.Controls.Add(Me.tab_sales_returns)
        Me.tabcontrol.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.tabcontrol.Location = New System.Drawing.Point(6, 93)
        Me.tabcontrol.Name = "tabcontrol"
        Me.tabcontrol.SelectedIndex = 0
        Me.tabcontrol.Size = New System.Drawing.Size(1244, 627)
        Me.tabcontrol.TabIndex = 61
        '
        'tab_supplierDeliveries
        '
        Me.tab_supplierDeliveries.Controls.Add(Me.Label2)
        Me.tab_supplierDeliveries.Controls.Add(Me.grid_delivery)
        Me.tab_supplierDeliveries.Controls.Add(Me.panel_supplierDeliveries)
        Me.tab_supplierDeliveries.Location = New System.Drawing.Point(4, 28)
        Me.tab_supplierDeliveries.Name = "tab_supplierDeliveries"
        Me.tab_supplierDeliveries.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_supplierDeliveries.Size = New System.Drawing.Size(1236, 595)
        Me.tab_supplierDeliveries.TabIndex = 0
        Me.tab_supplierDeliveries.Text = "Supplier Deliveries"
        Me.tab_supplierDeliveries.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 16.0!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(6, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(192, 27)
        Me.Label2.TabIndex = 82
        Me.Label2.Text = "Supplier Deliveries"
        '
        'panel_supplierDeliveries
        '
        Me.panel_supplierDeliveries.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panel_supplierDeliveries.Appearance.BackColor = System.Drawing.Color.GhostWhite
        Me.panel_supplierDeliveries.Appearance.Options.UseBackColor = True
        Me.panel_supplierDeliveries.Controls.Add(Me.lbl_ClicktoView_1)
        Me.panel_supplierDeliveries.Location = New System.Drawing.Point(426, 6)
        Me.panel_supplierDeliveries.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.panel_supplierDeliveries.LookAndFeel.UseDefaultLookAndFeel = False
        Me.panel_supplierDeliveries.Name = "panel_supplierDeliveries"
        Me.panel_supplierDeliveries.Size = New System.Drawing.Size(804, 583)
        Me.panel_supplierDeliveries.TabIndex = 83
        '
        'tab_stockTransfer
        '
        Me.tab_stockTransfer.Controls.Add(Me.grid_stock_transfers)
        Me.tab_stockTransfer.Controls.Add(Me.panel_stockTransfers)
        Me.tab_stockTransfer.Controls.Add(Me.Label3)
        Me.tab_stockTransfer.Location = New System.Drawing.Point(4, 28)
        Me.tab_stockTransfer.Name = "tab_stockTransfer"
        Me.tab_stockTransfer.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_stockTransfer.Size = New System.Drawing.Size(1236, 595)
        Me.tab_stockTransfer.TabIndex = 1
        Me.tab_stockTransfer.Text = "Stock Transfers"
        Me.tab_stockTransfer.UseVisualStyleBackColor = True
        '
        'grid_stock_transfers
        '
        Me.grid_stock_transfers.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grid_stock_transfers.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_stock_transfers.Location = New System.Drawing.Point(11, 56)
        Me.grid_stock_transfers.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grid_stock_transfers.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grid_stock_transfers.MainView = Me.grid_stock_transfers_view
        Me.grid_stock_transfers.Name = "grid_stock_transfers"
        Me.grid_stock_transfers.Size = New System.Drawing.Size(642, 533)
        Me.grid_stock_transfers.TabIndex = 13
        Me.grid_stock_transfers.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_stock_transfers_view})
        '
        'grid_stock_transfers_view
        '
        Me.grid_stock_transfers_view.Appearance.HeaderPanel.BackColor = System.Drawing.Color.White
        Me.grid_stock_transfers_view.Appearance.HeaderPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.grid_stock_transfers_view.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grid_stock_transfers_view.Appearance.HeaderPanel.Options.UseFont = True
        Me.grid_stock_transfers_view.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.grid_stock_transfers_view.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grid_stock_transfers_view.Appearance.Row.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_stock_transfers_view.Appearance.Row.Options.UseFont = True
        Me.grid_stock_transfers_view.Appearance.SelectedRow.BackColor = System.Drawing.Color.White
        Me.grid_stock_transfers_view.Appearance.SelectedRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.grid_stock_transfers_view.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grid_stock_transfers_view.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grid_stock_transfers_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_view, Me.col_transfer_id, Me.col_transfer_type, Me.col_src_warehouse, Me.col_linked_warehouse, Me.GridColumn1})
        Me.grid_stock_transfers_view.GridControl = Me.grid_stock_transfers
        Me.grid_stock_transfers_view.Name = "grid_stock_transfers_view"
        Me.grid_stock_transfers_view.OptionsBehavior.ReadOnly = True
        Me.grid_stock_transfers_view.OptionsSelection.ResetSelectionClickOutsideCheckboxSelector = True
        '
        'col_view
        '
        Me.col_view.Caption = "Action"
        Me.col_view.ColumnEdit = Me.btn_view_order
        Me.col_view.MaxWidth = 50
        Me.col_view.MinWidth = 50
        Me.col_view.Name = "col_view"
        Me.col_view.Visible = True
        Me.col_view.VisibleIndex = 0
        Me.col_view.Width = 50
        '
        'col_transfer_id
        '
        Me.col_transfer_id.AppearanceCell.Options.UseTextOptions = True
        Me.col_transfer_id.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_transfer_id.AppearanceHeader.Options.UseTextOptions = True
        Me.col_transfer_id.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_transfer_id.Caption = "Sub Transfer ID"
        Me.col_transfer_id.FieldName = "sub_transfer_id"
        Me.col_transfer_id.MaxWidth = 110
        Me.col_transfer_id.MinWidth = 110
        Me.col_transfer_id.Name = "col_transfer_id"
        Me.col_transfer_id.Visible = True
        Me.col_transfer_id.VisibleIndex = 1
        Me.col_transfer_id.Width = 110
        '
        'col_transfer_type
        '
        Me.col_transfer_type.AppearanceHeader.Options.UseTextOptions = True
        Me.col_transfer_type.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_transfer_type.Caption = "Transfer Type"
        Me.col_transfer_type.FieldName = "transfer_type"
        Me.col_transfer_type.MaxWidth = 120
        Me.col_transfer_type.MinWidth = 120
        Me.col_transfer_type.Name = "col_transfer_type"
        Me.col_transfer_type.Visible = True
        Me.col_transfer_type.VisibleIndex = 2
        Me.col_transfer_type.Width = 120
        '
        'col_src_warehouse
        '
        Me.col_src_warehouse.AppearanceHeader.Options.UseTextOptions = True
        Me.col_src_warehouse.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_src_warehouse.Caption = "FROM"
        Me.col_src_warehouse.FieldName = "src_warehouse"
        Me.col_src_warehouse.MinWidth = 200
        Me.col_src_warehouse.Name = "col_src_warehouse"
        Me.col_src_warehouse.Visible = True
        Me.col_src_warehouse.VisibleIndex = 3
        Me.col_src_warehouse.Width = 200
        '
        'col_linked_warehouse
        '
        Me.col_linked_warehouse.Caption = "TO"
        Me.col_linked_warehouse.FieldName = "recvr_warehouse"
        Me.col_linked_warehouse.MinWidth = 250
        Me.col_linked_warehouse.Name = "col_linked_warehouse"
        Me.col_linked_warehouse.Visible = True
        Me.col_linked_warehouse.VisibleIndex = 4
        Me.col_linked_warehouse.Width = 250
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.Caption = "Status"
        Me.GridColumn1.FieldName = "status"
        Me.GridColumn1.MaxWidth = 100
        Me.GridColumn1.MinWidth = 100
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Width = 100
        '
        'panel_stockTransfers
        '
        Me.panel_stockTransfers.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panel_stockTransfers.Appearance.BackColor = System.Drawing.Color.GhostWhite
        Me.panel_stockTransfers.Appearance.Options.UseBackColor = True
        Me.panel_stockTransfers.Controls.Add(Me.lbl_ClicktoView_2)
        Me.panel_stockTransfers.Location = New System.Drawing.Point(659, 6)
        Me.panel_stockTransfers.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.panel_stockTransfers.LookAndFeel.UseDefaultLookAndFeel = False
        Me.panel_stockTransfers.Name = "panel_stockTransfers"
        Me.panel_stockTransfers.Size = New System.Drawing.Size(571, 583)
        Me.panel_stockTransfers.TabIndex = 84
        '
        'lbl_ClicktoView_2
        '
        Me.lbl_ClicktoView_2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_ClicktoView_2.AutoSize = True
        Me.lbl_ClicktoView_2.BackColor = System.Drawing.Color.Transparent
        Me.lbl_ClicktoView_2.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.lbl_ClicktoView_2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbl_ClicktoView_2.Location = New System.Drawing.Point(194, 266)
        Me.lbl_ClicktoView_2.Name = "lbl_ClicktoView_2"
        Me.lbl_ClicktoView_2.Size = New System.Drawing.Size(249, 23)
        Me.lbl_ClicktoView_2.TabIndex = 0
        Me.lbl_ClicktoView_2.Text = "Click Stock Transfers to View"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 16.0!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(6, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(153, 27)
        Me.Label3.TabIndex = 83
        Me.Label3.Text = "Stock Tranfers"
        '
        'tab_sales_returns
        '
        Me.tab_sales_returns.Controls.Add(Me.Label4)
        Me.tab_sales_returns.Controls.Add(Me.panel_sales_return)
        Me.tab_sales_returns.Controls.Add(Me.grid_sales_returns)
        Me.tab_sales_returns.Location = New System.Drawing.Point(4, 28)
        Me.tab_sales_returns.Name = "tab_sales_returns"
        Me.tab_sales_returns.Size = New System.Drawing.Size(1236, 595)
        Me.tab_sales_returns.TabIndex = 2
        Me.tab_sales_returns.Text = "Sales Returns"
        Me.tab_sales_returns.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 16.0!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(6, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(145, 27)
        Me.Label4.TabIndex = 85
        Me.Label4.Text = "Sales Returns"
        Me.Label4.UseMnemonic = False
        '
        'panel_sales_return
        '
        Me.panel_sales_return.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panel_sales_return.Appearance.BackColor = System.Drawing.Color.GhostWhite
        Me.panel_sales_return.Appearance.Options.UseBackColor = True
        Me.panel_sales_return.Controls.Add(Me.lbl_sales_return)
        Me.panel_sales_return.Location = New System.Drawing.Point(426, 6)
        Me.panel_sales_return.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.panel_sales_return.LookAndFeel.UseDefaultLookAndFeel = False
        Me.panel_sales_return.Name = "panel_sales_return"
        Me.panel_sales_return.Size = New System.Drawing.Size(804, 583)
        Me.panel_sales_return.TabIndex = 84
        '
        'lbl_sales_return
        '
        Me.lbl_sales_return.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_sales_return.AutoSize = True
        Me.lbl_sales_return.BackColor = System.Drawing.Color.Transparent
        Me.lbl_sales_return.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.lbl_sales_return.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbl_sales_return.Location = New System.Drawing.Point(341, 267)
        Me.lbl_sales_return.Name = "lbl_sales_return"
        Me.lbl_sales_return.Size = New System.Drawing.Size(226, 23)
        Me.lbl_sales_return.TabIndex = 0
        Me.lbl_sales_return.Text = "Click Sales Return to View"
        '
        'grid_sales_returns
        '
        Me.grid_sales_returns.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grid_sales_returns.Location = New System.Drawing.Point(6, 55)
        Me.grid_sales_returns.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grid_sales_returns.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grid_sales_returns.MainView = Me.grid_sales_returns_view
        Me.grid_sales_returns.Name = "grid_sales_returns"
        Me.grid_sales_returns.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.btn_view_srid})
        Me.grid_sales_returns.Size = New System.Drawing.Size(414, 534)
        Me.grid_sales_returns.TabIndex = 2
        Me.grid_sales_returns.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_sales_returns_view})
        '
        'grid_sales_returns_view
        '
        Me.grid_sales_returns_view.Appearance.HeaderPanel.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.grid_sales_returns_view.Appearance.HeaderPanel.Options.UseFont = True
        Me.grid_sales_returns_view.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.grid_sales_returns_view.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grid_sales_returns_view.Appearance.Row.Font = New System.Drawing.Font("Arial", 9.5!)
        Me.grid_sales_returns_view.Appearance.Row.Options.UseFont = True
        Me.grid_sales_returns_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_srid, Me.col_customer, Me.col_sales_return_action, Me.col_created_by, Me.col_warehouse})
        Me.grid_sales_returns_view.GridControl = Me.grid_sales_returns
        Me.grid_sales_returns_view.Name = "grid_sales_returns_view"
        Me.grid_sales_returns_view.OptionsBehavior.ReadOnly = True
        Me.grid_sales_returns_view.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.[False]
        '
        'col_srid
        '
        Me.col_srid.AppearanceCell.Options.UseTextOptions = True
        Me.col_srid.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_srid.Caption = "SRID"
        Me.col_srid.DisplayFormat.FormatString = "dd MMM"
        Me.col_srid.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col_srid.FieldName = "srid"
        Me.col_srid.MaxWidth = 70
        Me.col_srid.Name = "col_srid"
        Me.col_srid.OptionsColumn.AllowEdit = False
        Me.col_srid.Visible = True
        Me.col_srid.VisibleIndex = 1
        Me.col_srid.Width = 62
        '
        'col_customer
        '
        Me.col_customer.Caption = "Customer"
        Me.col_customer.FieldName = "customer"
        Me.col_customer.Name = "col_customer"
        Me.col_customer.Visible = True
        Me.col_customer.VisibleIndex = 2
        Me.col_customer.Width = 79
        '
        'col_sales_return_action
        '
        Me.col_sales_return_action.ColumnEdit = Me.btn_view_srid
        Me.col_sales_return_action.MaxWidth = 40
        Me.col_sales_return_action.Name = "col_sales_return_action"
        Me.col_sales_return_action.Visible = True
        Me.col_sales_return_action.VisibleIndex = 0
        Me.col_sales_return_action.Width = 40
        '
        'btn_view_srid
        '
        Me.btn_view_srid.AutoHeight = False
        EditorButtonImageOptions3.Image = Global.Inventory_Management.My.Resources.Resources.up_16x16
        Me.btn_view_srid.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions3, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject9, SerializableAppearanceObject10, SerializableAppearanceObject11, SerializableAppearanceObject12, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.btn_view_srid.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_view_srid.Name = "btn_view_srid"
        Me.btn_view_srid.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'col_created_by
        '
        Me.col_created_by.Caption = "Created_by"
        Me.col_created_by.FieldName = "created_by"
        Me.col_created_by.Name = "col_created_by"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.GhostWhite
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.lbl_head)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1256, 78)
        Me.Panel1.TabIndex = 72
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.link_po_list)
        Me.Panel2.Controls.Add(Me.LabelControl7)
        Me.Panel2.Controls.Add(Me.link_home)
        Me.Panel2.Location = New System.Drawing.Point(19, 44)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(435, 27)
        Me.Panel2.TabIndex = 82
        '
        'lbl_head
        '
        Me.lbl_head.AutoSize = True
        Me.lbl_head.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lbl_head.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.lbl_head.Location = New System.Drawing.Point(14, 10)
        Me.lbl_head.Name = "lbl_head"
        Me.lbl_head.Size = New System.Drawing.Size(298, 31)
        Me.lbl_head.TabIndex = 81
        Me.lbl_head.Text = "Receiving Management"
        '
        'col_warehouse
        '
        Me.col_warehouse.Caption = "Submit to"
        Me.col_warehouse.FieldName = "store_name"
        Me.col_warehouse.Name = "col_warehouse"
        '
        'frm_warehouse_receivingManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1256, 727)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.tabcontrol)
        Me.Name = "frm_warehouse_receivingManagement"
        Me.Text = "frm_deliveries"
        CType(Me.btn_view_order, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_delivery, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_delivery_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_view, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabcontrol.ResumeLayout(False)
        Me.tab_supplierDeliveries.ResumeLayout(False)
        Me.tab_supplierDeliveries.PerformLayout()
        CType(Me.panel_supplierDeliveries, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_supplierDeliveries.ResumeLayout(False)
        Me.panel_supplierDeliveries.PerformLayout()
        Me.tab_stockTransfer.ResumeLayout(False)
        Me.tab_stockTransfer.PerformLayout()
        CType(Me.grid_stock_transfers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_stock_transfers_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panel_stockTransfers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_stockTransfers.ResumeLayout(False)
        Me.panel_stockTransfers.PerformLayout()
        Me.tab_sales_returns.ResumeLayout(False)
        Me.tab_sales_returns.PerformLayout()
        CType(Me.panel_sales_return, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_sales_return.ResumeLayout(False)
        Me.panel_sales_return.PerformLayout()
        CType(Me.grid_sales_returns, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_sales_returns_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_view_srid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents link_po_list As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents link_home As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents lbl_ClicktoView_1 As Label
    Friend WithEvents grid_delivery As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_delivery_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_lead_time As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_purchase_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_supplier As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_action As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_view As Repository.RepositoryItemButtonEdit
    Friend WithEvents tabcontrol As TabControl
    Friend WithEvents tab_supplierDeliveries As TabPage
    Friend WithEvents tab_stockTransfer As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lbl_head As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents grid_stock_transfers As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_stock_transfers_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_view As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_transfer_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_src_warehouse As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_transfer_type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_linked_warehouse As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents panel_supplierDeliveries As PanelControl
    Friend WithEvents panel_stockTransfers As PanelControl
    Friend WithEvents lbl_ClicktoView_2 As Label
    Friend WithEvents btn_view_order As Repository.RepositoryItemButtonEdit
    Friend WithEvents tab_sales_returns As TabPage
    Friend WithEvents Label4 As Label
    Friend WithEvents panel_sales_return As PanelControl
    Friend WithEvents lbl_sales_return As Label
    Friend WithEvents grid_sales_returns As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_sales_returns_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_srid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_customer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_sales_return_action As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_view_srid As Repository.RepositoryItemButtonEdit
    Friend WithEvents col_created_by As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_warehouse As DevExpress.XtraGrid.Columns.GridColumn
End Class
