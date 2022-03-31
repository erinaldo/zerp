<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_logistics_StockTransferDispatching
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_logistics_StockTransferDispatching))
        Dim EditorButtonImageOptions2 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject5 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject6 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject7 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject8 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaPanel2 = New Guna.UI.WinForms.GunaPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.cbb_timer = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.GunaPanel3 = New Guna.UI.WinForms.GunaPanel()
        Me.HyperlinkLabelControl1 = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.HyperlinkLabelControl2 = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.grid_stock_transfers = New DevExpress.XtraGrid.GridControl()
        Me.grid_stock_transfers_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_root_stid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_sub_stid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_transfer_type = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_customer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_cbm = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_status = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_dispatch = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btn_dispatch = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.Panel1.SuspendLayout()
        Me.GunaPanel2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbb_timer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaPanel3.SuspendLayout()
        CType(Me.grid_stock_transfers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_stock_transfers_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_dispatch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.GhostWhite
        Me.Panel1.Controls.Add(Me.GunaLabel2)
        Me.Panel1.Controls.Add(Me.GunaPanel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1204, 78)
        Me.Panel1.TabIndex = 57
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.GunaLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.GunaLabel2.Location = New System.Drawing.Point(14, 10)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(342, 31)
        Me.GunaLabel2.TabIndex = 1
        Me.GunaLabel2.Text = "Stock Transfer Dispatching"
        '
        'GunaPanel2
        '
        Me.GunaPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaPanel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaPanel2.Controls.Add(Me.Panel2)
        Me.GunaPanel2.Controls.Add(Me.GunaPanel3)
        Me.GunaPanel2.Location = New System.Drawing.Point(19, 44)
        Me.GunaPanel2.Name = "GunaPanel2"
        Me.GunaPanel2.Size = New System.Drawing.Size(1173, 27)
        Me.GunaPanel2.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.PictureEdit1)
        Me.Panel2.Controls.Add(Me.cbb_timer)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(1061, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(112, 27)
        Me.Panel2.TabIndex = 9
        '
        'PictureEdit1
        '
        Me.PictureEdit1.EditValue = CType(resources.GetObject("PictureEdit1.EditValue"), Object)
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
        'GunaPanel3
        '
        Me.GunaPanel3.Controls.Add(Me.HyperlinkLabelControl1)
        Me.GunaPanel3.Controls.Add(Me.LabelControl1)
        Me.GunaPanel3.Controls.Add(Me.HyperlinkLabelControl2)
        Me.GunaPanel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.GunaPanel3.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel3.Name = "GunaPanel3"
        Me.GunaPanel3.Size = New System.Drawing.Size(435, 27)
        Me.GunaPanel3.TabIndex = 0
        '
        'HyperlinkLabelControl1
        '
        Me.HyperlinkLabelControl1.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold)
        Me.HyperlinkLabelControl1.Appearance.LinkColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.HyperlinkLabelControl1.Appearance.Options.UseFont = True
        Me.HyperlinkLabelControl1.Appearance.Options.UseLinkColor = True
        Me.HyperlinkLabelControl1.AppearanceHovered.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.HyperlinkLabelControl1.AppearanceHovered.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.HyperlinkLabelControl1.AppearanceHovered.Options.UseForeColor = True
        Me.HyperlinkLabelControl1.AppearanceHovered.Options.UseLinkColor = True
        Me.HyperlinkLabelControl1.AppearancePressed.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.HyperlinkLabelControl1.AppearancePressed.Options.UseLinkColor = True
        Me.HyperlinkLabelControl1.LineStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.HyperlinkLabelControl1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.HyperlinkLabelControl1.Location = New System.Drawing.Point(70, 5)
        Me.HyperlinkLabelControl1.Name = "HyperlinkLabelControl1"
        Me.HyperlinkLabelControl1.ShowLineShadow = False
        Me.HyperlinkLabelControl1.Size = New System.Drawing.Size(162, 18)
        Me.HyperlinkLabelControl1.TabIndex = 7
        Me.HyperlinkLabelControl1.Text = "Stock Transfer Dispatching"
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
        'grid_stock_transfers
        '
        Me.grid_stock_transfers.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_stock_transfers.Location = New System.Drawing.Point(12, 100)
        Me.grid_stock_transfers.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grid_stock_transfers.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grid_stock_transfers.MainView = Me.grid_stock_transfers_view
        Me.grid_stock_transfers.Name = "grid_stock_transfers"
        Me.grid_stock_transfers.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.btn_dispatch})
        Me.grid_stock_transfers.Size = New System.Drawing.Size(1180, 562)
        Me.grid_stock_transfers.TabIndex = 58
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
        Me.grid_stock_transfers_view.Appearance.Row.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.grid_stock_transfers_view.Appearance.Row.Options.UseFont = True
        Me.grid_stock_transfers_view.Appearance.SelectedRow.BackColor = System.Drawing.Color.White
        Me.grid_stock_transfers_view.Appearance.SelectedRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.grid_stock_transfers_view.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grid_stock_transfers_view.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grid_stock_transfers_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_root_stid, Me.col_sub_stid, Me.col_transfer_type, Me.col_customer, Me.GridColumn9, Me.col_cbm, Me.GridColumn4, Me.col_status, Me.col_dispatch})
        Me.grid_stock_transfers_view.GridControl = Me.grid_stock_transfers
        Me.grid_stock_transfers_view.Name = "grid_stock_transfers_view"
        Me.grid_stock_transfers_view.OptionsBehavior.ReadOnly = True
        Me.grid_stock_transfers_view.OptionsSelection.ResetSelectionClickOutsideCheckboxSelector = True
        Me.grid_stock_transfers_view.OptionsView.ShowFooter = True
        Me.grid_stock_transfers_view.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.[False]
        '
        'col_root_stid
        '
        Me.col_root_stid.AppearanceCell.Options.UseTextOptions = True
        Me.col_root_stid.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_root_stid.Caption = "Root STID"
        Me.col_root_stid.FieldName = "root_transfer_id"
        Me.col_root_stid.MaxWidth = 80
        Me.col_root_stid.MinWidth = 80
        Me.col_root_stid.Name = "col_root_stid"
        Me.col_root_stid.Visible = True
        Me.col_root_stid.VisibleIndex = 1
        Me.col_root_stid.Width = 80
        '
        'col_sub_stid
        '
        Me.col_sub_stid.AppearanceCell.Options.UseTextOptions = True
        Me.col_sub_stid.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_sub_stid.AppearanceHeader.Options.UseTextOptions = True
        Me.col_sub_stid.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_sub_stid.Caption = "Sub STID"
        Me.col_sub_stid.FieldName = "sub_transfer_id"
        Me.col_sub_stid.MaxWidth = 80
        Me.col_sub_stid.MinWidth = 80
        Me.col_sub_stid.Name = "col_sub_stid"
        Me.col_sub_stid.OptionsColumn.AllowEdit = False
        Me.col_sub_stid.OptionsColumn.ReadOnly = True
        Me.col_sub_stid.Visible = True
        Me.col_sub_stid.VisibleIndex = 0
        Me.col_sub_stid.Width = 80
        '
        'col_transfer_type
        '
        Me.col_transfer_type.AppearanceCell.Options.UseTextOptions = True
        Me.col_transfer_type.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_transfer_type.AppearanceHeader.Options.UseTextOptions = True
        Me.col_transfer_type.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_transfer_type.Caption = "Transfer Type"
        Me.col_transfer_type.FieldName = "transfer_type"
        Me.col_transfer_type.MaxWidth = 100
        Me.col_transfer_type.MinWidth = 100
        Me.col_transfer_type.Name = "col_transfer_type"
        Me.col_transfer_type.Visible = True
        Me.col_transfer_type.VisibleIndex = 2
        Me.col_transfer_type.Width = 100
        '
        'col_customer
        '
        Me.col_customer.AppearanceHeader.Options.UseTextOptions = True
        Me.col_customer.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_customer.Caption = "FROM"
        Me.col_customer.FieldName = "from_store"
        Me.col_customer.MinWidth = 150
        Me.col_customer.Name = "col_customer"
        Me.col_customer.OptionsColumn.AllowEdit = False
        Me.col_customer.OptionsColumn.ReadOnly = True
        Me.col_customer.Visible = True
        Me.col_customer.VisibleIndex = 3
        Me.col_customer.Width = 196
        '
        'GridColumn9
        '
        Me.GridColumn9.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn9.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn9.Caption = "TO"
        Me.GridColumn9.FieldName = "to_store"
        Me.GridColumn9.MinWidth = 150
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.AllowEdit = False
        Me.GridColumn9.OptionsColumn.ReadOnly = True
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 4
        Me.GridColumn9.Width = 175
        '
        'col_cbm
        '
        Me.col_cbm.AppearanceCell.Options.UseTextOptions = True
        Me.col_cbm.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_cbm.AppearanceHeader.Options.UseTextOptions = True
        Me.col_cbm.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_cbm.Caption = "CBM (mᶟ)"
        Me.col_cbm.DisplayFormat.FormatString = "n2"
        Me.col_cbm.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_cbm.FieldName = "total_cbm"
        Me.col_cbm.MaxWidth = 100
        Me.col_cbm.MinWidth = 80
        Me.col_cbm.Name = "col_cbm"
        Me.col_cbm.Visible = True
        Me.col_cbm.VisibleIndex = 5
        Me.col_cbm.Width = 100
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn4.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn4.Caption = "Weight (Kgs)"
        Me.GridColumn4.DisplayFormat.FormatString = "n2"
        Me.GridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn4.FieldName = "total_kgs"
        Me.GridColumn4.MaxWidth = 100
        Me.GridColumn4.MinWidth = 80
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.AllowEdit = False
        Me.GridColumn4.OptionsColumn.ReadOnly = True
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 6
        Me.GridColumn4.Width = 95
        '
        'col_status
        '
        Me.col_status.AppearanceHeader.Options.UseTextOptions = True
        Me.col_status.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_status.Caption = "Status"
        Me.col_status.FieldName = "STATUS"
        Me.col_status.Name = "col_status"
        Me.col_status.Visible = True
        Me.col_status.VisibleIndex = 7
        Me.col_status.Width = 87
        '
        'col_dispatch
        '
        Me.col_dispatch.AppearanceCell.Options.UseTextOptions = True
        Me.col_dispatch.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_dispatch.AppearanceHeader.Options.UseTextOptions = True
        Me.col_dispatch.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_dispatch.Caption = "Dispatch"
        Me.col_dispatch.ColumnEdit = Me.btn_dispatch
        Me.col_dispatch.MaxWidth = 70
        Me.col_dispatch.Name = "col_dispatch"
        Me.col_dispatch.OptionsColumn.ReadOnly = True
        Me.col_dispatch.Visible = True
        Me.col_dispatch.VisibleIndex = 8
        Me.col_dispatch.Width = 64
        '
        'btn_dispatch
        '
        Me.btn_dispatch.AutoHeight = False
        EditorButtonImageOptions2.SvgImage = Global.Inventory_Management.My.Resources.Resources.shopping_delivery
        EditorButtonImageOptions2.SvgImageSize = New System.Drawing.Size(20, 20)
        Me.btn_dispatch.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions2, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, SerializableAppearanceObject6, SerializableAppearanceObject7, SerializableAppearanceObject8, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.btn_dispatch.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_dispatch.Name = "btn_dispatch"
        Me.btn_dispatch.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'frm_logistics_StockTransferDispatching
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1204, 674)
        Me.Controls.Add(Me.grid_stock_transfers)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frm_logistics_StockTransferDispatching"
        Me.Text = "Stock Transfer Dispatching"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GunaPanel2.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbb_timer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaPanel3.ResumeLayout(False)
        Me.GunaPanel3.PerformLayout()
        CType(Me.grid_stock_transfers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_stock_transfers_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_dispatch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaPanel2 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents cbb_timer As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents GunaPanel3 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents HyperlinkLabelControl1 As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents HyperlinkLabelControl2 As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents grid_stock_transfers As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_stock_transfers_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_sub_stid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_transfer_type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_cbm As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_customer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_dispatch As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_dispatch As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents col_root_stid As DevExpress.XtraGrid.Columns.GridColumn
End Class
