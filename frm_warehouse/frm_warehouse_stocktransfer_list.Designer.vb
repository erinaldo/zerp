<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_warehouse_stocktransfer_list
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
        Me.components = New System.ComponentModel.Container()
        Dim EditorButtonImageOptions3 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject9 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject10 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject11 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject12 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim EditorButtonImageOptions4 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject13 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject14 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject15 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject16 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.GunaPanel2 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaPanel3 = New Guna.UI.WinForms.GunaPanel()
        Me.HyperlinkLabelControl1 = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.HyperlinkLabelControl2 = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.lbl_title = New Guna.UI.WinForms.GunaLabel()
        Me.btn_new_stockTransfer = New DevExpress.XtraEditors.SimpleButton()
        Me.grid_stock_transfers = New DevExpress.XtraGrid.GridControl()
        Me.grid_stock_transfers_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_view = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btn_view_order = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.col_transfer_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_src_warehouse = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_transfer_type = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_status = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_created_by = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_created_at = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_total_cbm = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_total_kgs = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_linked_warehouse = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.newTransfer_contextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.stripMenu_distribute = New System.Windows.Forms.ToolStripMenuItem()
        Me.RequestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_refresh = New DevExpress.XtraEditors.SimpleButton()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tab_stock_transfer = New System.Windows.Forms.TabPage()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.tab_sub_transfer = New System.Windows.Forms.TabPage()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.grid_sub_transfer = New DevExpress.XtraGrid.GridControl()
        Me.grid_sub_transfer_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btn_cancel = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.col_root_transfer_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_from = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_sub_transfer_type = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_sub_transfer_status = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_sub_transfer_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_driver = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_to = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GunaPanel2.SuspendLayout()
        Me.GunaPanel3.SuspendLayout()
        CType(Me.grid_stock_transfers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_stock_transfers_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_view_order, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.newTransfer_contextMenu.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tab_stock_transfer.SuspendLayout()
        Me.tab_sub_transfer.SuspendLayout()
        CType(Me.grid_sub_transfer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_sub_transfer_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_cancel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaPanel2
        '
        Me.GunaPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaPanel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaPanel2.Controls.Add(Me.GunaPanel3)
        Me.GunaPanel2.Location = New System.Drawing.Point(17, 60)
        Me.GunaPanel2.Name = "GunaPanel2"
        Me.GunaPanel2.Size = New System.Drawing.Size(763, 27)
        Me.GunaPanel2.TabIndex = 8
        '
        'GunaPanel3
        '
        Me.GunaPanel3.Controls.Add(Me.HyperlinkLabelControl1)
        Me.GunaPanel3.Controls.Add(Me.LabelControl1)
        Me.GunaPanel3.Controls.Add(Me.HyperlinkLabelControl2)
        Me.GunaPanel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.GunaPanel3.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel3.Name = "GunaPanel3"
        Me.GunaPanel3.Size = New System.Drawing.Size(435, 27)
        Me.GunaPanel3.TabIndex = 1
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
        Me.HyperlinkLabelControl1.Size = New System.Drawing.Size(87, 18)
        Me.HyperlinkLabelControl1.TabIndex = 7
        Me.HyperlinkLabelControl1.Text = "Stock Transfer"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(55, 7)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(9, 14)
        Me.LabelControl1.TabIndex = 6
        Me.LabelControl1.Text = ">"
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
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lbl_title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.lbl_title.Location = New System.Drawing.Point(12, 26)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(192, 31)
        Me.lbl_title.TabIndex = 7
        Me.lbl_title.Text = "Stock Transfer"
        '
        'btn_new_stockTransfer
        '
        Me.btn_new_stockTransfer.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_new_stockTransfer.Appearance.Options.UseFont = True
        Me.btn_new_stockTransfer.Appearance.Options.UseTextOptions = True
        Me.btn_new_stockTransfer.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btn_new_stockTransfer.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btn_new_stockTransfer.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.packageproduct_32x32
        Me.btn_new_stockTransfer.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_new_stockTransfer.ImageOptions.ImageToTextIndent = 5
        Me.btn_new_stockTransfer.Location = New System.Drawing.Point(18, 117)
        Me.btn_new_stockTransfer.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_new_stockTransfer.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_new_stockTransfer.Name = "btn_new_stockTransfer"
        Me.btn_new_stockTransfer.Size = New System.Drawing.Size(160, 46)
        Me.btn_new_stockTransfer.TabIndex = 11
        Me.btn_new_stockTransfer.Text = "New Transfer"
        '
        'grid_stock_transfers
        '
        Me.grid_stock_transfers.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_stock_transfers.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_stock_transfers.Location = New System.Drawing.Point(8, 50)
        Me.grid_stock_transfers.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grid_stock_transfers.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grid_stock_transfers.MainView = Me.grid_stock_transfers_view
        Me.grid_stock_transfers.Name = "grid_stock_transfers"
        Me.grid_stock_transfers.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.btn_view_order})
        Me.grid_stock_transfers.Size = New System.Drawing.Size(1143, 427)
        Me.grid_stock_transfers.TabIndex = 12
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
        Me.grid_stock_transfers_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_view, Me.col_transfer_id, Me.col_src_warehouse, Me.col_transfer_type, Me.col_status, Me.col_created_by, Me.col_created_at, Me.col_total_cbm, Me.col_total_kgs, Me.col_linked_warehouse})
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
        'btn_view_order
        '
        Me.btn_view_order.AutoHeight = False
        EditorButtonImageOptions3.Image = Global.Inventory_Management.My.Resources.Resources.snapmodifytablecellstyle_16x16
        Me.btn_view_order.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions3, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject9, SerializableAppearanceObject10, SerializableAppearanceObject11, SerializableAppearanceObject12, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.btn_view_order.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_view_order.Name = "btn_view_order"
        Me.btn_view_order.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'col_transfer_id
        '
        Me.col_transfer_id.AppearanceCell.Options.UseTextOptions = True
        Me.col_transfer_id.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_transfer_id.AppearanceHeader.Options.UseTextOptions = True
        Me.col_transfer_id.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_transfer_id.Caption = "Transfer ID"
        Me.col_transfer_id.FieldName = "transfer_id"
        Me.col_transfer_id.MaxWidth = 70
        Me.col_transfer_id.MinWidth = 70
        Me.col_transfer_id.Name = "col_transfer_id"
        Me.col_transfer_id.Visible = True
        Me.col_transfer_id.VisibleIndex = 1
        Me.col_transfer_id.Width = 70
        '
        'col_src_warehouse
        '
        Me.col_src_warehouse.AppearanceHeader.Options.UseTextOptions = True
        Me.col_src_warehouse.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_src_warehouse.Caption = "Source/Requesting Warehouse"
        Me.col_src_warehouse.FieldName = "src_warehouse"
        Me.col_src_warehouse.MaxWidth = 200
        Me.col_src_warehouse.MinWidth = 150
        Me.col_src_warehouse.Name = "col_src_warehouse"
        Me.col_src_warehouse.Visible = True
        Me.col_src_warehouse.VisibleIndex = 2
        Me.col_src_warehouse.Width = 150
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
        Me.col_transfer_type.VisibleIndex = 4
        Me.col_transfer_type.Width = 130
        '
        'col_status
        '
        Me.col_status.AppearanceCell.Options.UseTextOptions = True
        Me.col_status.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.col_status.AppearanceHeader.Options.UseTextOptions = True
        Me.col_status.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_status.Caption = "Status"
        Me.col_status.FieldName = "status"
        Me.col_status.MaxWidth = 180
        Me.col_status.MinWidth = 100
        Me.col_status.Name = "col_status"
        Me.col_status.Visible = True
        Me.col_status.VisibleIndex = 5
        Me.col_status.Width = 100
        '
        'col_created_by
        '
        Me.col_created_by.AppearanceCell.Options.UseTextOptions = True
        Me.col_created_by.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_created_by.AppearanceHeader.Options.UseTextOptions = True
        Me.col_created_by.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_created_by.Caption = "Created by"
        Me.col_created_by.FieldName = "created_by"
        Me.col_created_by.MaxWidth = 100
        Me.col_created_by.MinWidth = 100
        Me.col_created_by.Name = "col_created_by"
        Me.col_created_by.Visible = True
        Me.col_created_by.VisibleIndex = 6
        Me.col_created_by.Width = 100
        '
        'col_created_at
        '
        Me.col_created_at.AppearanceCell.Options.UseTextOptions = True
        Me.col_created_at.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_created_at.AppearanceHeader.Options.UseTextOptions = True
        Me.col_created_at.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_created_at.Caption = "Date Created"
        Me.col_created_at.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.col_created_at.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col_created_at.FieldName = "created_at"
        Me.col_created_at.MaxWidth = 120
        Me.col_created_at.MinWidth = 120
        Me.col_created_at.Name = "col_created_at"
        Me.col_created_at.Visible = True
        Me.col_created_at.VisibleIndex = 7
        Me.col_created_at.Width = 120
        '
        'col_total_cbm
        '
        Me.col_total_cbm.Caption = "Total mᶟ"
        Me.col_total_cbm.FieldName = "total_cbm"
        Me.col_total_cbm.MaxWidth = 80
        Me.col_total_cbm.Name = "col_total_cbm"
        Me.col_total_cbm.Visible = True
        Me.col_total_cbm.VisibleIndex = 8
        '
        'col_total_kgs
        '
        Me.col_total_kgs.Caption = "Total Kg"
        Me.col_total_kgs.FieldName = "total_kgs"
        Me.col_total_kgs.MaxWidth = 80
        Me.col_total_kgs.Name = "col_total_kgs"
        Me.col_total_kgs.Visible = True
        Me.col_total_kgs.VisibleIndex = 9
        Me.col_total_kgs.Width = 50
        '
        'col_linked_warehouse
        '
        Me.col_linked_warehouse.Caption = "Affected Warehouse"
        Me.col_linked_warehouse.FieldName = "linked_warehouse"
        Me.col_linked_warehouse.Name = "col_linked_warehouse"
        Me.col_linked_warehouse.Visible = True
        Me.col_linked_warehouse.VisibleIndex = 3
        '
        'newTransfer_contextMenu
        '
        Me.newTransfer_contextMenu.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.newTransfer_contextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stripMenu_distribute, Me.RequestToolStripMenuItem})
        Me.newTransfer_contextMenu.Name = "newTransfer_contextMenu"
        Me.newTransfer_contextMenu.Size = New System.Drawing.Size(137, 48)
        '
        'stripMenu_distribute
        '
        Me.stripMenu_distribute.Name = "stripMenu_distribute"
        Me.stripMenu_distribute.Size = New System.Drawing.Size(136, 22)
        Me.stripMenu_distribute.Text = "Distribute"
        '
        'RequestToolStripMenuItem
        '
        Me.RequestToolStripMenuItem.Name = "RequestToolStripMenuItem"
        Me.RequestToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.RequestToolStripMenuItem.Text = "Request"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.GhostWhite
        Me.Panel1.Controls.Add(Me.GunaPanel2)
        Me.Panel1.Controls.Add(Me.lbl_title)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1196, 100)
        Me.Panel1.TabIndex = 13
        '
        'btn_refresh
        '
        Me.btn_refresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_refresh.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_refresh.Appearance.Options.UseFont = True
        Me.btn_refresh.Appearance.Options.UseTextOptions = True
        Me.btn_refresh.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btn_refresh.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btn_refresh.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.refresh_32x32
        Me.btn_refresh.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_refresh.ImageOptions.ImageToTextIndent = 5
        Me.btn_refresh.Location = New System.Drawing.Point(1022, 120)
        Me.btn_refresh.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_refresh.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(160, 46)
        Me.btn_refresh.TabIndex = 14
        Me.btn_refresh.Text = "Refresh"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.tab_stock_transfer)
        Me.TabControl1.Controls.Add(Me.tab_sub_transfer)
        Me.TabControl1.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.TabControl1.Location = New System.Drawing.Point(18, 172)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1166, 513)
        Me.TabControl1.TabIndex = 15
        '
        'tab_stock_transfer
        '
        Me.tab_stock_transfer.Controls.Add(Me.GunaLabel1)
        Me.tab_stock_transfer.Controls.Add(Me.grid_stock_transfers)
        Me.tab_stock_transfer.Location = New System.Drawing.Point(4, 26)
        Me.tab_stock_transfer.Name = "tab_stock_transfer"
        Me.tab_stock_transfer.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_stock_transfer.Size = New System.Drawing.Size(1158, 483)
        Me.tab_stock_transfer.TabIndex = 0
        Me.tab_stock_transfer.Text = "Stock Transfers"
        Me.tab_stock_transfer.UseVisualStyleBackColor = True
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.GunaLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.GunaLabel1.Location = New System.Drawing.Point(4, 11)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(206, 31)
        Me.GunaLabel1.TabIndex = 13
        Me.GunaLabel1.Text = "Stock Transfers"
        '
        'tab_sub_transfer
        '
        Me.tab_sub_transfer.Controls.Add(Me.GunaLabel2)
        Me.tab_sub_transfer.Controls.Add(Me.grid_sub_transfer)
        Me.tab_sub_transfer.Location = New System.Drawing.Point(4, 26)
        Me.tab_sub_transfer.Name = "tab_sub_transfer"
        Me.tab_sub_transfer.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_sub_transfer.Size = New System.Drawing.Size(1158, 483)
        Me.tab_sub_transfer.TabIndex = 1
        Me.tab_sub_transfer.Text = "Sub Transfers"
        Me.tab_sub_transfer.UseVisualStyleBackColor = True
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.GunaLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.GunaLabel2.Location = New System.Drawing.Point(4, 11)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(185, 31)
        Me.GunaLabel2.TabIndex = 14
        Me.GunaLabel2.Text = "Sub Transfers"
        '
        'grid_sub_transfer
        '
        Me.grid_sub_transfer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_sub_transfer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_sub_transfer.Location = New System.Drawing.Point(8, 50)
        Me.grid_sub_transfer.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grid_sub_transfer.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grid_sub_transfer.MainView = Me.grid_sub_transfer_view
        Me.grid_sub_transfer.Name = "grid_sub_transfer"
        Me.grid_sub_transfer.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.btn_cancel})
        Me.grid_sub_transfer.Size = New System.Drawing.Size(1143, 427)
        Me.grid_sub_transfer.TabIndex = 13
        Me.grid_sub_transfer.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_sub_transfer_view})
        '
        'grid_sub_transfer_view
        '
        Me.grid_sub_transfer_view.Appearance.HeaderPanel.BackColor = System.Drawing.Color.White
        Me.grid_sub_transfer_view.Appearance.HeaderPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.grid_sub_transfer_view.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grid_sub_transfer_view.Appearance.HeaderPanel.Options.UseFont = True
        Me.grid_sub_transfer_view.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.grid_sub_transfer_view.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grid_sub_transfer_view.Appearance.Row.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_sub_transfer_view.Appearance.Row.Options.UseFont = True
        Me.grid_sub_transfer_view.Appearance.SelectedRow.BackColor = System.Drawing.Color.White
        Me.grid_sub_transfer_view.Appearance.SelectedRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.grid_sub_transfer_view.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grid_sub_transfer_view.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grid_sub_transfer_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.col_root_transfer_id, Me.col_from, Me.col_sub_transfer_type, Me.col_sub_transfer_status, Me.col_sub_transfer_id, Me.col_driver, Me.col_to})
        Me.grid_sub_transfer_view.GridControl = Me.grid_sub_transfer
        Me.grid_sub_transfer_view.Name = "grid_sub_transfer_view"
        Me.grid_sub_transfer_view.OptionsBehavior.ReadOnly = True
        Me.grid_sub_transfer_view.OptionsSelection.ResetSelectionClickOutsideCheckboxSelector = True
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Action"
        Me.GridColumn1.ColumnEdit = Me.btn_cancel
        Me.GridColumn1.MaxWidth = 50
        Me.GridColumn1.MinWidth = 50
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 7
        Me.GridColumn1.Width = 50
        '
        'btn_cancel
        '
        Me.btn_cancel.AutoHeight = False
        EditorButtonImageOptions4.Image = Global.Inventory_Management.My.Resources.Resources.cancel_16x16
        Me.btn_cancel.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions4, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject13, SerializableAppearanceObject14, SerializableAppearanceObject15, SerializableAppearanceObject16, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.btn_cancel.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'col_root_transfer_id
        '
        Me.col_root_transfer_id.AppearanceCell.Options.UseTextOptions = True
        Me.col_root_transfer_id.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_root_transfer_id.AppearanceHeader.Options.UseTextOptions = True
        Me.col_root_transfer_id.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_root_transfer_id.Caption = "Root Transfer ID"
        Me.col_root_transfer_id.FieldName = "root_transfer_id"
        Me.col_root_transfer_id.MaxWidth = 120
        Me.col_root_transfer_id.MinWidth = 120
        Me.col_root_transfer_id.Name = "col_root_transfer_id"
        Me.col_root_transfer_id.Visible = True
        Me.col_root_transfer_id.VisibleIndex = 0
        Me.col_root_transfer_id.Width = 120
        '
        'col_from
        '
        Me.col_from.AppearanceHeader.Options.UseTextOptions = True
        Me.col_from.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_from.Caption = "FROM"
        Me.col_from.FieldName = "from_warehouse"
        Me.col_from.Name = "col_from"
        Me.col_from.Visible = True
        Me.col_from.VisibleIndex = 2
        Me.col_from.Width = 200
        '
        'col_sub_transfer_type
        '
        Me.col_sub_transfer_type.AppearanceCell.Options.UseTextOptions = True
        Me.col_sub_transfer_type.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_sub_transfer_type.AppearanceHeader.Options.UseTextOptions = True
        Me.col_sub_transfer_type.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_sub_transfer_type.Caption = "Transfer Type"
        Me.col_sub_transfer_type.FieldName = "transfer_type"
        Me.col_sub_transfer_type.MaxWidth = 130
        Me.col_sub_transfer_type.MinWidth = 130
        Me.col_sub_transfer_type.Name = "col_sub_transfer_type"
        Me.col_sub_transfer_type.Visible = True
        Me.col_sub_transfer_type.VisibleIndex = 4
        Me.col_sub_transfer_type.Width = 130
        '
        'col_sub_transfer_status
        '
        Me.col_sub_transfer_status.AppearanceCell.Options.UseTextOptions = True
        Me.col_sub_transfer_status.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_sub_transfer_status.AppearanceHeader.Options.UseTextOptions = True
        Me.col_sub_transfer_status.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_sub_transfer_status.Caption = "Status"
        Me.col_sub_transfer_status.FieldName = "status"
        Me.col_sub_transfer_status.MaxWidth = 180
        Me.col_sub_transfer_status.MinWidth = 100
        Me.col_sub_transfer_status.Name = "col_sub_transfer_status"
        Me.col_sub_transfer_status.Visible = True
        Me.col_sub_transfer_status.VisibleIndex = 5
        Me.col_sub_transfer_status.Width = 180
        '
        'col_sub_transfer_id
        '
        Me.col_sub_transfer_id.AppearanceCell.Options.UseTextOptions = True
        Me.col_sub_transfer_id.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_sub_transfer_id.AppearanceHeader.Options.UseTextOptions = True
        Me.col_sub_transfer_id.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_sub_transfer_id.Caption = "Sub Transfer ID"
        Me.col_sub_transfer_id.FieldName = "sub_transfer_id"
        Me.col_sub_transfer_id.MaxWidth = 120
        Me.col_sub_transfer_id.MinWidth = 120
        Me.col_sub_transfer_id.Name = "col_sub_transfer_id"
        Me.col_sub_transfer_id.Visible = True
        Me.col_sub_transfer_id.VisibleIndex = 1
        Me.col_sub_transfer_id.Width = 120
        '
        'col_driver
        '
        Me.col_driver.AppearanceHeader.Options.UseTextOptions = True
        Me.col_driver.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_driver.Caption = "Driver"
        Me.col_driver.FieldName = "delivered_by"
        Me.col_driver.MaxWidth = 120
        Me.col_driver.MinWidth = 120
        Me.col_driver.Name = "col_driver"
        Me.col_driver.Visible = True
        Me.col_driver.VisibleIndex = 6
        Me.col_driver.Width = 120
        '
        'col_to
        '
        Me.col_to.Caption = "TO"
        Me.col_to.FieldName = "to_warehouse"
        Me.col_to.Name = "col_to"
        Me.col_to.Visible = True
        Me.col_to.VisibleIndex = 3
        Me.col_to.Width = 200
        '
        'frm_warehouse_stocktransfer_list
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1196, 697)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btn_refresh)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btn_new_stockTransfer)
        Me.Name = "frm_warehouse_stocktransfer_list"
        Me.Text = "frm_warehouse_stocktransfer_list"
        Me.GunaPanel2.ResumeLayout(False)
        Me.GunaPanel3.ResumeLayout(False)
        Me.GunaPanel3.PerformLayout()
        CType(Me.grid_stock_transfers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_stock_transfers_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_view_order, System.ComponentModel.ISupportInitialize).EndInit()
        Me.newTransfer_contextMenu.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.tab_stock_transfer.ResumeLayout(False)
        Me.tab_stock_transfer.PerformLayout()
        Me.tab_sub_transfer.ResumeLayout(False)
        Me.tab_sub_transfer.PerformLayout()
        CType(Me.grid_sub_transfer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_sub_transfer_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_cancel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GunaPanel2 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPanel3 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents HyperlinkLabelControl1 As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents HyperlinkLabelControl2 As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents lbl_title As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btn_new_stockTransfer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grid_stock_transfers As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_stock_transfers_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_view As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_view_order As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents col_transfer_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_src_warehouse As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_transfer_type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_created_by As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_created_at As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents newTransfer_contextMenu As ContextMenuStrip
    Friend WithEvents stripMenu_distribute As ToolStripMenuItem
    Friend WithEvents RequestToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_refresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents col_total_cbm As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_total_kgs As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_linked_warehouse As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tab_stock_transfer As TabPage
    Friend WithEvents tab_sub_transfer As TabPage
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents grid_sub_transfer As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_sub_transfer_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_cancel As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents col_root_transfer_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_from As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_sub_transfer_type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_sub_transfer_status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_sub_transfer_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_driver As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_to As DevExpress.XtraGrid.Columns.GridColumn
End Class
