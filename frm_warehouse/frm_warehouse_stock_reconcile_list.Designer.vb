<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_warehouse_stock_reconcile_list
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_warehouse_stock_reconcile_list))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btn_refresh = New DevExpress.XtraEditors.SimpleButton()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_completed = New System.Windows.Forms.LinkLabel()
        Me.btn_completed = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_request_transfer = New DevExpress.XtraEditors.SimpleButton()
        Me.grid_stock_transferred = New DevExpress.XtraGrid.GridControl()
        Me.grid_stock_transferred_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_status = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_store = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_item = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_delete = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btn_delete = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.col_qty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_type = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btn_reconcile = New DevExpress.XtraEditors.SimpleButton()
        Me.GunaLabel11 = New Guna.UI.WinForms.GunaLabel()
        Me.HyperlinkLabelControl1 = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.HyperlinkLabelControl2 = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.GunaPanel3 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaPanel2 = New Guna.UI.WinForms.GunaPanel()
        Me.panel_top = New Guna.UI.WinForms.GunaLinePanel()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.grid_stock_transferred, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_stock_transferred_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_delete, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaPanel3.SuspendLayout()
        Me.GunaPanel2.SuspendLayout()
        Me.panel_top.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel2.CustomBorderColor = System.Drawing.Color.Silver
        Me.Guna2Panel2.CustomBorderThickness = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(973, 10)
        Me.Guna2Panel2.TabIndex = 19
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
        Me.btn_refresh.Location = New System.Drawing.Point(942, 15)
        Me.btn_refresh.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_refresh.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(160, 46)
        Me.btn_refresh.TabIndex = 17
        Me.btn_refresh.Text = "Refresh"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.White
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.Controls.Add(Me.lbl_completed)
        Me.Guna2Panel1.Controls.Add(Me.btn_completed)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Panel2)
        Me.Guna2Panel1.Controls.Add(Me.btn_refresh)
        Me.Guna2Panel1.Controls.Add(Me.btn_request_transfer)
        Me.Guna2Panel1.Controls.Add(Me.grid_stock_transferred)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 78)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(1120, 588)
        Me.Guna2Panel1.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(16, 560)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 15)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Load:"
        '
        'lbl_completed
        '
        Me.lbl_completed.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_completed.AutoSize = True
        Me.lbl_completed.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lbl_completed.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lbl_completed.Location = New System.Drawing.Point(60, 560)
        Me.lbl_completed.Name = "lbl_completed"
        Me.lbl_completed.Size = New System.Drawing.Size(68, 15)
        Me.lbl_completed.TabIndex = 24
        Me.lbl_completed.TabStop = True
        Me.lbl_completed.Text = "Completed"
        '
        'btn_completed
        '
        Me.btn_completed.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_completed.Appearance.Options.UseFont = True
        Me.btn_completed.Appearance.Options.UseTextOptions = True
        Me.btn_completed.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btn_completed.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btn_completed.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.apply_32x32
        Me.btn_completed.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_completed.ImageOptions.ImageToTextIndent = 5
        Me.btn_completed.Location = New System.Drawing.Point(186, 15)
        Me.btn_completed.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_completed.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_completed.Name = "btn_completed"
        Me.btn_completed.Size = New System.Drawing.Size(171, 46)
        Me.btn_completed.TabIndex = 20
        Me.btn_completed.Text = "Mark as Completed"
        '
        'btn_request_transfer
        '
        Me.btn_request_transfer.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_request_transfer.Appearance.Options.UseFont = True
        Me.btn_request_transfer.Appearance.Options.UseTextOptions = True
        Me.btn_request_transfer.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btn_request_transfer.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btn_request_transfer.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.newtask_32x321
        Me.btn_request_transfer.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_request_transfer.ImageOptions.ImageToTextIndent = 5
        Me.btn_request_transfer.Location = New System.Drawing.Point(20, 15)
        Me.btn_request_transfer.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_request_transfer.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_request_transfer.Name = "btn_request_transfer"
        Me.btn_request_transfer.Size = New System.Drawing.Size(160, 46)
        Me.btn_request_transfer.TabIndex = 14
        Me.btn_request_transfer.Text = "New Reconcile"
        '
        'grid_stock_transferred
        '
        Me.grid_stock_transferred.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_stock_transferred.Location = New System.Drawing.Point(20, 72)
        Me.grid_stock_transferred.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grid_stock_transferred.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grid_stock_transferred.MainView = Me.grid_stock_transferred_view
        Me.grid_stock_transferred.Name = "grid_stock_transferred"
        Me.grid_stock_transferred.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.btn_delete})
        Me.grid_stock_transferred.Size = New System.Drawing.Size(1082, 479)
        Me.grid_stock_transferred.TabIndex = 13
        Me.grid_stock_transferred.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_stock_transferred_view})
        '
        'grid_stock_transferred_view
        '
        Me.grid_stock_transferred_view.Appearance.HeaderPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.grid_stock_transferred_view.Appearance.HeaderPanel.Options.UseFont = True
        Me.grid_stock_transferred_view.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.grid_stock_transferred_view.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grid_stock_transferred_view.Appearance.Row.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_stock_transferred_view.Appearance.Row.Options.UseFont = True
        Me.grid_stock_transferred_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_id, Me.col_status, Me.col_store, Me.col_item, Me.col_delete, Me.col_qty, Me.col_type})
        Me.grid_stock_transferred_view.GridControl = Me.grid_stock_transferred
        Me.grid_stock_transferred_view.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.grid_stock_transferred_view.Name = "grid_stock_transferred_view"
        Me.grid_stock_transferred_view.OptionsBehavior.ReadOnly = True
        Me.grid_stock_transferred_view.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.grid_stock_transferred_view.OptionsView.AutoCalcPreviewLineCount = True
        Me.grid_stock_transferred_view.OptionsView.ColumnAutoWidth = False
        Me.grid_stock_transferred_view.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.[False]
        '
        'col_id
        '
        Me.col_id.AppearanceCell.Options.UseTextOptions = True
        Me.col_id.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_id.Caption = "ID"
        Me.col_id.FieldName = "id"
        Me.col_id.Name = "col_id"
        Me.col_id.Visible = True
        Me.col_id.VisibleIndex = 0
        Me.col_id.Width = 103
        '
        'col_status
        '
        Me.col_status.Caption = "Status"
        Me.col_status.FieldName = "status"
        Me.col_status.Name = "col_status"
        Me.col_status.Visible = True
        Me.col_status.VisibleIndex = 5
        Me.col_status.Width = 93
        '
        'col_store
        '
        Me.col_store.Caption = "Store / Warehouse"
        Me.col_store.FieldName = "store_name"
        Me.col_store.Name = "col_store"
        Me.col_store.Visible = True
        Me.col_store.VisibleIndex = 4
        Me.col_store.Width = 238
        '
        'col_item
        '
        Me.col_item.Caption = "Item"
        Me.col_item.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.col_item.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col_item.FieldName = "winmodel"
        Me.col_item.Name = "col_item"
        Me.col_item.Visible = True
        Me.col_item.VisibleIndex = 3
        Me.col_item.Width = 159
        '
        'col_delete
        '
        Me.col_delete.Caption = "Delete"
        Me.col_delete.ColumnEdit = Me.btn_delete
        Me.col_delete.Name = "col_delete"
        Me.col_delete.Visible = True
        Me.col_delete.VisibleIndex = 6
        '
        'btn_delete
        '
        Me.btn_delete.AutoHeight = False
        EditorButtonImageOptions1.Image = CType(resources.GetObject("EditorButtonImageOptions1.Image"), System.Drawing.Image)
        Me.btn_delete.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.btn_delete.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'col_qty
        '
        Me.col_qty.Caption = "Quantity"
        Me.col_qty.FieldName = "qty"
        Me.col_qty.Name = "col_qty"
        Me.col_qty.Visible = True
        Me.col_qty.VisibleIndex = 2
        '
        'col_type
        '
        Me.col_type.AppearanceCell.Options.UseTextOptions = True
        Me.col_type.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_type.Caption = "Type"
        Me.col_type.FieldName = "reconciled_type"
        Me.col_type.Name = "col_type"
        Me.col_type.Visible = True
        Me.col_type.VisibleIndex = 1
        Me.col_type.Width = 85
        '
        'btn_reconcile
        '
        Me.btn_reconcile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_reconcile.Appearance.BackColor = System.Drawing.Color.White
        Me.btn_reconcile.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.btn_reconcile.Appearance.Options.UseBackColor = True
        Me.btn_reconcile.Appearance.Options.UseFont = True
        Me.btn_reconcile.Enabled = False
        Me.btn_reconcile.Location = New System.Drawing.Point(972, 37)
        Me.btn_reconcile.Name = "btn_reconcile"
        Me.btn_reconcile.Size = New System.Drawing.Size(130, 45)
        Me.btn_reconcile.TabIndex = 9
        Me.btn_reconcile.Text = "Reconcile"
        '
        'GunaLabel11
        '
        Me.GunaLabel11.AutoSize = True
        Me.GunaLabel11.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.GunaLabel11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.GunaLabel11.Location = New System.Drawing.Point(14, 10)
        Me.GunaLabel11.Name = "GunaLabel11"
        Me.GunaLabel11.Size = New System.Drawing.Size(134, 31)
        Me.GunaLabel11.TabIndex = 1
        Me.GunaLabel11.Text = "Reconcile"
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
        Me.HyperlinkLabelControl1.Size = New System.Drawing.Size(60, 18)
        Me.HyperlinkLabelControl1.TabIndex = 7
        Me.HyperlinkLabelControl1.Text = "Reconcile"
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
        'GunaPanel2
        '
        Me.GunaPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaPanel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaPanel2.Controls.Add(Me.GunaPanel3)
        Me.GunaPanel2.Location = New System.Drawing.Point(19, 44)
        Me.GunaPanel2.Name = "GunaPanel2"
        Me.GunaPanel2.Size = New System.Drawing.Size(584, 27)
        Me.GunaPanel2.TabIndex = 6
        '
        'panel_top
        '
        Me.panel_top.BackColor = System.Drawing.Color.GhostWhite
        Me.panel_top.Controls.Add(Me.btn_reconcile)
        Me.panel_top.Controls.Add(Me.GunaPanel2)
        Me.panel_top.Controls.Add(Me.GunaLabel11)
        Me.panel_top.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_top.LineColor = System.Drawing.SystemColors.ControlLight
        Me.panel_top.LineStyle = System.Windows.Forms.BorderStyle.None
        Me.panel_top.Location = New System.Drawing.Point(0, 0)
        Me.panel_top.Name = "panel_top"
        Me.panel_top.Size = New System.Drawing.Size(1120, 78)
        Me.panel_top.TabIndex = 16
        '
        'frm_warehouse_stock_reconcile_list
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1120, 666)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.panel_top)
        Me.Name = "frm_warehouse_stock_reconcile_list"
        Me.Text = "frm_warehouse_stock_reconcile"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.grid_stock_transferred, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_stock_transferred_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_delete, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaPanel3.ResumeLayout(False)
        Me.GunaPanel3.PerformLayout()
        Me.GunaPanel2.ResumeLayout(False)
        Me.panel_top.ResumeLayout(False)
        Me.panel_top.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btn_refresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btn_request_transfer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grid_stock_transferred As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_stock_transferred_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_store As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_item As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_delete As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_delete As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents btn_reconcile As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GunaLabel11 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents HyperlinkLabelControl1 As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents HyperlinkLabelControl2 As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents GunaPanel3 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPanel2 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents panel_top As Guna.UI.WinForms.GunaLinePanel
    Friend WithEvents col_qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_completed As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_completed As LinkLabel
End Class
