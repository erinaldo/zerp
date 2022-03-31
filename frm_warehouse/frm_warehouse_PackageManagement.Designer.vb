Imports DevExpress.LookAndFeel
Imports DevExpress.Utils
Imports DevExpress.XtraBars.Navigation
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports Guna.UI.WinForms
Imports System.ComponentModel
Imports System.Drawing.Drawing2D
Imports System.Runtime.CompilerServices

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_warehouse_PackageManagement
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
        Me.components = New System.ComponentModel.Container()
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
        Me.panel_top = New Guna.UI.WinForms.GunaPanel()
        Me.GunaPanel5 = New Guna.UI.WinForms.GunaPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.cbb_timer = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.link_po_list = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.link_home = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.lbl_title = New Guna.UI.WinForms.GunaLabel()
        Me.grid_orders = New DevExpress.XtraGrid.GridControl()
        Me.grid_orders_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_SalesOrder_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_order_status = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_sales_order_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btn_view_order = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.timer = New System.Windows.Forms.Timer(Me.components)
        Me.tabpanel_orders = New DevExpress.XtraBars.Navigation.TabPane()
        Me.tab_order_pending = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.tab_order_ongoing = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.tab_order_completed = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.tab_order_cancelled = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.grid_stock_transfers = New DevExpress.XtraGrid.GridControl()
        Me.grid_stock_transfers_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_view = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btn_view_transfer = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.col_transfer_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_transfer_type = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_from = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_to = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_transfer_status = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_sub_transfer_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tabpanel_transfer = New DevExpress.XtraBars.Navigation.TabPane()
        Me.tab_transfer_pending = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.tab_transfer_ongoing = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.tab_transfer_completed = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tab_transfer_cancellation = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.panel_top.SuspendLayout()
        Me.GunaPanel5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbb_timer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaPanel1.SuspendLayout()
        CType(Me.grid_orders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_orders_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_view_order, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabpanel_orders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabpanel_orders.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.grid_stock_transfers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_stock_transfers_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_view_transfer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabpanel_transfer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabpanel_transfer.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel_top
        '
        Me.panel_top.BackColor = System.Drawing.Color.GhostWhite
        Me.panel_top.Controls.Add(Me.GunaPanel5)
        Me.panel_top.Controls.Add(Me.lbl_title)
        Me.panel_top.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_top.Location = New System.Drawing.Point(0, 0)
        Me.panel_top.Name = "panel_top"
        Me.panel_top.Size = New System.Drawing.Size(1143, 78)
        Me.panel_top.TabIndex = 12
        '
        'GunaPanel5
        '
        Me.GunaPanel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaPanel5.BackColor = System.Drawing.Color.Transparent
        Me.GunaPanel5.Controls.Add(Me.Panel1)
        Me.GunaPanel5.Controls.Add(Me.GunaPanel1)
        Me.GunaPanel5.Location = New System.Drawing.Point(19, 44)
        Me.GunaPanel5.Name = "GunaPanel5"
        Me.GunaPanel5.Size = New System.Drawing.Size(1121, 27)
        Me.GunaPanel5.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureEdit1)
        Me.Panel1.Controls.Add(Me.cbb_timer)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(1009, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(112, 27)
        Me.Panel1.TabIndex = 8
        '
        'PictureEdit1
        '
        Me.PictureEdit1.EditValue = Global.Inventory_Management.My.Resources.Resources.time_16x16
        Me.PictureEdit1.Location = New System.Drawing.Point(13, 4)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.PictureEdit1.Size = New System.Drawing.Size(20, 20)
        Me.PictureEdit1.TabIndex = 6
        '
        'cbb_timer
        '
        Me.cbb_timer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbb_timer.EditValue = "1 min"
        Me.cbb_timer.Location = New System.Drawing.Point(37, 4)
        Me.cbb_timer.Name = "cbb_timer"
        Me.cbb_timer.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cbb_timer.Properties.Appearance.Options.UseFont = True
        Me.cbb_timer.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_timer.Properties.Items.AddRange(New Object() {"1 min", "5 min", "10 min", "30 min"})
        Me.cbb_timer.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cbb_timer.Size = New System.Drawing.Size(65, 20)
        Me.cbb_timer.TabIndex = 4
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
        Me.GunaPanel1.TabIndex = 1
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
        Me.link_po_list.Size = New System.Drawing.Size(136, 18)
        Me.link_po_list.TabIndex = 7
        Me.link_po_list.Text = "Package Management"
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
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lbl_title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.lbl_title.Location = New System.Drawing.Point(14, 10)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(284, 31)
        Me.lbl_title.TabIndex = 1
        Me.lbl_title.Text = "Package Management"
        '
        'grid_orders
        '
        Me.grid_orders.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_orders.Location = New System.Drawing.Point(6, 92)
        Me.grid_orders.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grid_orders.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grid_orders.MainView = Me.grid_orders_view
        Me.grid_orders.Name = "grid_orders"
        Me.grid_orders.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.btn_view_order})
        Me.grid_orders.Size = New System.Drawing.Size(1099, 409)
        Me.grid_orders.TabIndex = 8
        Me.grid_orders.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_orders_view})
        '
        'grid_orders_view
        '
        Me.grid_orders_view.Appearance.HeaderPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.grid_orders_view.Appearance.HeaderPanel.Options.UseFont = True
        Me.grid_orders_view.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.grid_orders_view.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grid_orders_view.Appearance.Row.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.grid_orders_view.Appearance.Row.Options.UseFont = True
        Me.grid_orders_view.Appearance.SelectedRow.BackColor = System.Drawing.Color.White
        Me.grid_orders_view.Appearance.SelectedRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.grid_orders_view.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grid_orders_view.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grid_orders_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_SalesOrder_id, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.col_order_status, Me.col_sales_order_id})
        Me.grid_orders_view.GridControl = Me.grid_orders
        Me.grid_orders_view.Name = "grid_orders_view"
        Me.grid_orders_view.OptionsBehavior.ReadOnly = True
        Me.grid_orders_view.OptionsSelection.ResetSelectionClickOutsideCheckboxSelector = True
        Me.grid_orders_view.OptionsView.ShowGroupPanel = False
        Me.grid_orders_view.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.[True]
        '
        'col_SalesOrder_id
        '
        Me.col_SalesOrder_id.AppearanceCell.Options.UseTextOptions = True
        Me.col_SalesOrder_id.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_SalesOrder_id.Caption = "Order ID"
        Me.col_SalesOrder_id.FieldName = "order_id"
        Me.col_SalesOrder_id.MaxWidth = 100
        Me.col_SalesOrder_id.MinWidth = 50
        Me.col_SalesOrder_id.Name = "col_SalesOrder_id"
        Me.col_SalesOrder_id.OptionsColumn.FixedWidth = True
        Me.col_SalesOrder_id.Visible = True
        Me.col_SalesOrder_id.VisibleIndex = 1
        Me.col_SalesOrder_id.Width = 100
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.GridColumn2.AppearanceHeader.Options.UseForeColor = True
        Me.GridColumn2.Caption = "Customer"
        Me.GridColumn2.FieldName = "first_name"
        Me.GridColumn2.MaxWidth = 250
        Me.GridColumn2.MinWidth = 50
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.FixedWidth = True
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 2
        Me.GridColumn2.Width = 150
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.GridColumn3.AppearanceHeader.Options.UseForeColor = True
        Me.GridColumn3.Caption = "Agent"
        Me.GridColumn3.FieldName = "agent"
        Me.GridColumn3.MaxWidth = 250
        Me.GridColumn3.MinWidth = 50
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.FixedWidth = True
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 3
        Me.GridColumn3.Width = 150
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn4.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.GridColumn4.AppearanceHeader.Options.UseForeColor = True
        Me.GridColumn4.Caption = "Entry Date"
        Me.GridColumn4.FieldName = "date_ordered"
        Me.GridColumn4.MaxWidth = 100
        Me.GridColumn4.MinWidth = 50
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.FixedWidth = True
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 4
        Me.GridColumn4.Width = 100
        '
        'col_order_status
        '
        Me.col_order_status.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.col_order_status.AppearanceCell.Options.UseBackColor = True
        Me.col_order_status.AppearanceCell.Options.UseTextOptions = True
        Me.col_order_status.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_order_status.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.col_order_status.AppearanceHeader.Options.UseForeColor = True
        Me.col_order_status.Caption = "Status"
        Me.col_order_status.FieldName = "status"
        Me.col_order_status.MaxWidth = 250
        Me.col_order_status.Name = "col_order_status"
        Me.col_order_status.OptionsColumn.FixedWidth = True
        Me.col_order_status.Visible = True
        Me.col_order_status.VisibleIndex = 5
        Me.col_order_status.Width = 120
        '
        'col_sales_order_id
        '
        Me.col_sales_order_id.Caption = "Action"
        Me.col_sales_order_id.ColumnEdit = Me.btn_view_order
        Me.col_sales_order_id.MaxWidth = 50
        Me.col_sales_order_id.Name = "col_sales_order_id"
        Me.col_sales_order_id.Visible = True
        Me.col_sales_order_id.VisibleIndex = 0
        Me.col_sales_order_id.Width = 50
        '
        'btn_view_order
        '
        Me.btn_view_order.AutoHeight = False
        EditorButtonImageOptions1.Image = Global.Inventory_Management.My.Resources.Resources.up_16x16
        Me.btn_view_order.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.btn_view_order.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_view_order.Name = "btn_view_order"
        Me.btn_view_order.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'timer
        '
        '
        'tabpanel_orders
        '
        Me.tabpanel_orders.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabpanel_orders.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.tabpanel_orders.Appearance.Options.UseBackColor = True
        Me.tabpanel_orders.AppearanceButton.Hovered.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.tabpanel_orders.AppearanceButton.Hovered.Options.UseFont = True
        Me.tabpanel_orders.AppearanceButton.Normal.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.tabpanel_orders.AppearanceButton.Normal.Options.UseFont = True
        Me.tabpanel_orders.AppearanceButton.Pressed.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tabpanel_orders.AppearanceButton.Pressed.ForeColor = System.Drawing.Color.Red
        Me.tabpanel_orders.AppearanceButton.Pressed.Options.UseFont = True
        Me.tabpanel_orders.AppearanceButton.Pressed.Options.UseForeColor = True
        Me.tabpanel_orders.Controls.Add(Me.tab_order_pending)
        Me.tabpanel_orders.Controls.Add(Me.tab_order_ongoing)
        Me.tabpanel_orders.Controls.Add(Me.tab_order_completed)
        Me.tabpanel_orders.Controls.Add(Me.tab_order_cancelled)
        Me.tabpanel_orders.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabpanel_orders.Location = New System.Drawing.Point(6, 58)
        Me.tabpanel_orders.LookAndFeel.SkinName = "Office 2013"
        Me.tabpanel_orders.LookAndFeel.UseDefaultLookAndFeel = False
        Me.tabpanel_orders.Name = "tabpanel_orders"
        Me.tabpanel_orders.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.tab_order_pending, Me.tab_order_ongoing, Me.tab_order_completed, Me.tab_order_cancelled})
        Me.tabpanel_orders.RegularSize = New System.Drawing.Size(1099, 36)
        Me.tabpanel_orders.SelectedPage = Me.tab_order_pending
        Me.tabpanel_orders.Size = New System.Drawing.Size(1099, 36)
        Me.tabpanel_orders.TabIndex = 15
        Me.tabpanel_orders.Text = "Pending Arrangements"
        '
        'tab_order_pending
        '
        Me.tab_order_pending.Caption = "Pending Arrangements"
        Me.tab_order_pending.Name = "tab_order_pending"
        Me.tab_order_pending.Size = New System.Drawing.Size(1099, 1)
        '
        'tab_order_ongoing
        '
        Me.tab_order_ongoing.Caption = "On-Going"
        Me.tab_order_ongoing.Name = "tab_order_ongoing"
        Me.tab_order_ongoing.Size = New System.Drawing.Size(1099, 36)
        '
        'tab_order_completed
        '
        Me.tab_order_completed.Caption = "Completed"
        Me.tab_order_completed.Name = "tab_order_completed"
        Me.tab_order_completed.Size = New System.Drawing.Size(1099, 36)
        '
        'tab_order_cancelled
        '
        Me.tab_order_cancelled.Caption = "For Unpacking"
        Me.tab_order_cancelled.Name = "tab_order_cancelled"
        Me.tab_order_cancelled.Size = New System.Drawing.Size(1099, 36)
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.TabControl1.Location = New System.Drawing.Point(12, 97)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1119, 540)
        Me.TabControl1.TabIndex = 16
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.grid_orders)
        Me.TabPage1.Controls.Add(Me.tabpanel_orders)
        Me.TabPage1.Location = New System.Drawing.Point(4, 28)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1111, 508)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Package Orders"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 16.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(11, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 27)
        Me.Label1.TabIndex = 85
        Me.Label1.Text = "Package Order"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.grid_stock_transfers)
        Me.TabPage2.Controls.Add(Me.tabpanel_transfer)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 28)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1111, 508)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Package Transfers"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'grid_stock_transfers
        '
        Me.grid_stock_transfers.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_stock_transfers.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_stock_transfers.Location = New System.Drawing.Point(6, 92)
        Me.grid_stock_transfers.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grid_stock_transfers.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grid_stock_transfers.MainView = Me.grid_stock_transfers_view
        Me.grid_stock_transfers.Name = "grid_stock_transfers"
        Me.grid_stock_transfers.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.btn_view_transfer})
        Me.grid_stock_transfers.Size = New System.Drawing.Size(1099, 409)
        Me.grid_stock_transfers.TabIndex = 14
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
        Me.grid_stock_transfers_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_view, Me.col_transfer_id, Me.col_transfer_type, Me.col_from, Me.col_to, Me.col_transfer_status, Me.col_sub_transfer_id})
        Me.grid_stock_transfers_view.GridControl = Me.grid_stock_transfers
        Me.grid_stock_transfers_view.Name = "grid_stock_transfers_view"
        Me.grid_stock_transfers_view.OptionsBehavior.ReadOnly = True
        Me.grid_stock_transfers_view.OptionsSelection.ResetSelectionClickOutsideCheckboxSelector = True
        Me.grid_stock_transfers_view.OptionsView.ShowGroupPanel = False
        '
        'col_view
        '
        Me.col_view.Caption = "Action"
        Me.col_view.ColumnEdit = Me.btn_view_transfer
        Me.col_view.MaxWidth = 50
        Me.col_view.MinWidth = 50
        Me.col_view.Name = "col_view"
        Me.col_view.Visible = True
        Me.col_view.VisibleIndex = 0
        Me.col_view.Width = 50
        '
        'btn_view_transfer
        '
        Me.btn_view_transfer.AutoHeight = False
        EditorButtonImageOptions2.Image = Global.Inventory_Management.My.Resources.Resources.up_16x16
        Me.btn_view_transfer.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions2, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, SerializableAppearanceObject6, SerializableAppearanceObject7, SerializableAppearanceObject8, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.btn_view_transfer.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_view_transfer.Name = "btn_view_transfer"
        Me.btn_view_transfer.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'col_transfer_id
        '
        Me.col_transfer_id.AppearanceCell.Options.UseTextOptions = True
        Me.col_transfer_id.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_transfer_id.AppearanceHeader.Options.UseTextOptions = True
        Me.col_transfer_id.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_transfer_id.Caption = "Root Transfer ID"
        Me.col_transfer_id.FieldName = "transfer_id"
        Me.col_transfer_id.MaxWidth = 120
        Me.col_transfer_id.MinWidth = 80
        Me.col_transfer_id.Name = "col_transfer_id"
        Me.col_transfer_id.Visible = True
        Me.col_transfer_id.VisibleIndex = 2
        Me.col_transfer_id.Width = 110
        '
        'col_transfer_type
        '
        Me.col_transfer_type.AppearanceHeader.Options.UseTextOptions = True
        Me.col_transfer_type.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_transfer_type.Caption = "Transfer Type"
        Me.col_transfer_type.FieldName = "transfer_type"
        Me.col_transfer_type.MaxWidth = 130
        Me.col_transfer_type.MinWidth = 130
        Me.col_transfer_type.Name = "col_transfer_type"
        Me.col_transfer_type.Visible = True
        Me.col_transfer_type.VisibleIndex = 3
        Me.col_transfer_type.Width = 130
        '
        'col_from
        '
        Me.col_from.AppearanceHeader.Options.UseTextOptions = True
        Me.col_from.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_from.Caption = "FROM"
        Me.col_from.FieldName = "source_warehouse"
        Me.col_from.MaxWidth = 200
        Me.col_from.MinWidth = 200
        Me.col_from.Name = "col_from"
        Me.col_from.Visible = True
        Me.col_from.VisibleIndex = 5
        Me.col_from.Width = 200
        '
        'col_to
        '
        Me.col_to.Caption = "TO"
        Me.col_to.FieldName = "receiver_warehouse"
        Me.col_to.MaxWidth = 200
        Me.col_to.MinWidth = 250
        Me.col_to.Name = "col_to"
        Me.col_to.Visible = True
        Me.col_to.VisibleIndex = 6
        Me.col_to.Width = 250
        '
        'col_transfer_status
        '
        Me.col_transfer_status.AppearanceHeader.Options.UseTextOptions = True
        Me.col_transfer_status.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_transfer_status.Caption = "Status"
        Me.col_transfer_status.FieldName = "status"
        Me.col_transfer_status.MaxWidth = 150
        Me.col_transfer_status.MinWidth = 80
        Me.col_transfer_status.Name = "col_transfer_status"
        Me.col_transfer_status.Visible = True
        Me.col_transfer_status.VisibleIndex = 4
        Me.col_transfer_status.Width = 80
        '
        'col_sub_transfer_id
        '
        Me.col_sub_transfer_id.AppearanceCell.Options.UseTextOptions = True
        Me.col_sub_transfer_id.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_sub_transfer_id.Caption = "Sub Transfer ID"
        Me.col_sub_transfer_id.FieldName = "sub_transfer_id"
        Me.col_sub_transfer_id.MaxWidth = 120
        Me.col_sub_transfer_id.Name = "col_sub_transfer_id"
        Me.col_sub_transfer_id.Visible = True
        Me.col_sub_transfer_id.VisibleIndex = 1
        Me.col_sub_transfer_id.Width = 91
        '
        'tabpanel_transfer
        '
        Me.tabpanel_transfer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabpanel_transfer.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.tabpanel_transfer.Appearance.Options.UseBackColor = True
        Me.tabpanel_transfer.AppearanceButton.Hovered.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.tabpanel_transfer.AppearanceButton.Hovered.Options.UseFont = True
        Me.tabpanel_transfer.AppearanceButton.Normal.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.tabpanel_transfer.AppearanceButton.Normal.Options.UseFont = True
        Me.tabpanel_transfer.AppearanceButton.Pressed.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tabpanel_transfer.AppearanceButton.Pressed.ForeColor = System.Drawing.Color.Red
        Me.tabpanel_transfer.AppearanceButton.Pressed.Options.UseFont = True
        Me.tabpanel_transfer.AppearanceButton.Pressed.Options.UseForeColor = True
        Me.tabpanel_transfer.Controls.Add(Me.tab_transfer_pending)
        Me.tabpanel_transfer.Controls.Add(Me.tab_transfer_completed)
        Me.tabpanel_transfer.Controls.Add(Me.tab_transfer_ongoing)
        Me.tabpanel_transfer.Controls.Add(Me.tab_transfer_cancellation)
        Me.tabpanel_transfer.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabpanel_transfer.Location = New System.Drawing.Point(5, 58)
        Me.tabpanel_transfer.LookAndFeel.SkinName = "Office 2013"
        Me.tabpanel_transfer.LookAndFeel.UseDefaultLookAndFeel = False
        Me.tabpanel_transfer.Name = "tabpanel_transfer"
        Me.tabpanel_transfer.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.tab_transfer_pending, Me.tab_transfer_ongoing, Me.tab_transfer_completed, Me.tab_transfer_cancellation})
        Me.tabpanel_transfer.RegularSize = New System.Drawing.Size(1099, 36)
        Me.tabpanel_transfer.SelectedPage = Me.tab_transfer_pending
        Me.tabpanel_transfer.Size = New System.Drawing.Size(1099, 36)
        Me.tabpanel_transfer.TabIndex = 85
        Me.tabpanel_transfer.Text = "Pending"
        '
        'tab_transfer_pending
        '
        Me.tab_transfer_pending.Caption = "Pending Arrangements"
        Me.tab_transfer_pending.Name = "tab_transfer_pending"
        Me.tab_transfer_pending.Size = New System.Drawing.Size(1099, 1)
        '
        'tab_transfer_ongoing
        '
        Me.tab_transfer_ongoing.Caption = "On-Going Arrangements"
        Me.tab_transfer_ongoing.Name = "tab_transfer_ongoing"
        Me.tab_transfer_ongoing.Size = New System.Drawing.Size(1099, 1)
        '
        'tab_transfer_completed
        '
        Me.tab_transfer_completed.Caption = "Completed"
        Me.tab_transfer_completed.Name = "tab_transfer_completed"
        Me.tab_transfer_completed.Size = New System.Drawing.Size(1099, 36)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 16.0!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(11, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(182, 27)
        Me.Label3.TabIndex = 84
        Me.Label3.Text = "Package Tranfers"
        '
        'tab_transfer_cancellation
        '
        Me.tab_transfer_cancellation.Caption = "For Unpacking"
        Me.tab_transfer_cancellation.Name = "tab_transfer_cancellation"
        Me.tab_transfer_cancellation.Size = New System.Drawing.Size(1099, 36)
        '
        'frm_warehouse_PackageManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1143, 649)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.panel_top)
        Me.KeyPreview = True
        Me.Name = "frm_warehouse_PackageManagement"
        Me.Text = "frm_production_list"
        Me.panel_top.ResumeLayout(False)
        Me.panel_top.PerformLayout()
        Me.GunaPanel5.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbb_timer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaPanel1.ResumeLayout(False)
        Me.GunaPanel1.PerformLayout()
        CType(Me.grid_orders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_orders_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_view_order, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabpanel_orders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabpanel_orders.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.grid_stock_transfers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_stock_transfers_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_view_transfer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabpanel_transfer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabpanel_transfer.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panel_top As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPanel5 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents link_po_list As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents link_home As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents lbl_title As Guna.UI.WinForms.GunaLabel
    Friend WithEvents grid_orders As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_orders_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_SalesOrder_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_order_status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents cbb_timer As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents timer As Timer
    Friend WithEvents tabpanel_orders As DevExpress.XtraBars.Navigation.TabPane
    Friend WithEvents tab_order_pending As TabNavigationPage
    Friend WithEvents tab_order_ongoing As TabNavigationPage
    Friend WithEvents tab_order_completed As TabNavigationPage
    Friend WithEvents tab_order_cancelled As TabNavigationPage
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents grid_stock_transfers As GridControl
    Friend WithEvents grid_stock_transfers_view As GridView
    Friend WithEvents col_view As GridColumn
    Friend WithEvents col_transfer_id As GridColumn
    Friend WithEvents col_transfer_type As GridColumn
    Friend WithEvents col_from As GridColumn
    Friend WithEvents col_to As GridColumn
    Friend WithEvents col_transfer_status As GridColumn
    Friend WithEvents btn_view_transfer As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents tabpanel_transfer As TabPane
    Friend WithEvents tab_transfer_pending As TabNavigationPage
    Friend WithEvents tab_transfer_ongoing As TabNavigationPage
    Friend WithEvents tab_transfer_completed As TabNavigationPage
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents col_sales_order_id As GridColumn
    Friend WithEvents btn_view_order As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents col_sub_transfer_id As GridColumn
    Friend WithEvents tab_transfer_cancellation As TabNavigationPage
End Class
