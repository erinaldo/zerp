<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_purchaseorder_return_list
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
        Dim EditorButtonImageOptions2 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject5 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject6 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject7 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject8 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.panel_top = New Guna.UI.WinForms.GunaPanel()
        Me.GunaPanel5 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.link_po_list = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.link_home = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.lbl_title = New Guna.UI.WinForms.GunaLabel()
        Me.grid_returns = New DevExpress.XtraGrid.GridControl()
        Me.grid_returns_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_view = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btn_view_order = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.col_rid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_supplier = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_total_cost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_createdat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_batchno = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_status = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btn_new_return = New DevExpress.XtraEditors.SimpleButton()
        Me.panel_top.SuspendLayout()
        Me.GunaPanel5.SuspendLayout()
        Me.GunaPanel1.SuspendLayout()
        CType(Me.grid_returns, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_returns_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_view_order, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.panel_top.Size = New System.Drawing.Size(1224, 78)
        Me.panel_top.TabIndex = 12
        '
        'GunaPanel5
        '
        Me.GunaPanel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaPanel5.BackColor = System.Drawing.Color.Transparent
        Me.GunaPanel5.Controls.Add(Me.GunaPanel1)
        Me.GunaPanel5.Location = New System.Drawing.Point(19, 44)
        Me.GunaPanel5.Name = "GunaPanel5"
        Me.GunaPanel5.Size = New System.Drawing.Size(1202, 27)
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
        Me.link_po_list.Size = New System.Drawing.Size(101, 18)
        Me.link_po_list.TabIndex = 7
        Me.link_po_list.Text = "Purchase Return"
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
        Me.lbl_title.Size = New System.Drawing.Size(232, 31)
        Me.lbl_title.TabIndex = 1
        Me.lbl_title.Text = "Purchase Returns"
        '
        'grid_returns
        '
        Me.grid_returns.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_returns.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_returns.Location = New System.Drawing.Point(19, 150)
        Me.grid_returns.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grid_returns.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grid_returns.MainView = Me.grid_returns_view
        Me.grid_returns.Name = "grid_returns"
        Me.grid_returns.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.btn_view_order})
        Me.grid_returns.Size = New System.Drawing.Size(1187, 554)
        Me.grid_returns.TabIndex = 13
        Me.grid_returns.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_returns_view})
        '
        'grid_returns_view
        '
        Me.grid_returns_view.Appearance.HeaderPanel.BackColor = System.Drawing.Color.White
        Me.grid_returns_view.Appearance.HeaderPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.grid_returns_view.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grid_returns_view.Appearance.HeaderPanel.Options.UseFont = True
        Me.grid_returns_view.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.grid_returns_view.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grid_returns_view.Appearance.Row.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_returns_view.Appearance.Row.Options.UseFont = True
        Me.grid_returns_view.Appearance.SelectedRow.BackColor = System.Drawing.Color.White
        Me.grid_returns_view.Appearance.SelectedRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.grid_returns_view.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grid_returns_view.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grid_returns_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_view, Me.col_rid, Me.col_supplier, Me.col_total_cost, Me.col_createdat, Me.col_batchno, Me.col_status})
        Me.grid_returns_view.GridControl = Me.grid_returns
        Me.grid_returns_view.Name = "grid_returns_view"
        Me.grid_returns_view.OptionsBehavior.ReadOnly = True
        Me.grid_returns_view.OptionsSelection.ResetSelectionClickOutsideCheckboxSelector = True
        Me.grid_returns_view.OptionsView.ShowFooter = True
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
        EditorButtonImageOptions2.Image = Global.Inventory_Management.My.Resources.Resources.snapmodifytablecellstyle_16x16
        Me.btn_view_order.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions2, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, SerializableAppearanceObject6, SerializableAppearanceObject7, SerializableAppearanceObject8, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.btn_view_order.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_view_order.Name = "btn_view_order"
        Me.btn_view_order.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'col_rid
        '
        Me.col_rid.AppearanceCell.Options.UseTextOptions = True
        Me.col_rid.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_rid.AppearanceHeader.Options.UseTextOptions = True
        Me.col_rid.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_rid.Caption = "Return ID"
        Me.col_rid.FieldName = "po_return_id"
        Me.col_rid.MaxWidth = 100
        Me.col_rid.MinWidth = 100
        Me.col_rid.Name = "col_rid"
        Me.col_rid.Visible = True
        Me.col_rid.VisibleIndex = 1
        Me.col_rid.Width = 100
        '
        'col_supplier
        '
        Me.col_supplier.AppearanceHeader.Options.UseTextOptions = True
        Me.col_supplier.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_supplier.Caption = "Supplier"
        Me.col_supplier.FieldName = "supplier"
        Me.col_supplier.MaxWidth = 250
        Me.col_supplier.MinWidth = 250
        Me.col_supplier.Name = "col_supplier"
        Me.col_supplier.Visible = True
        Me.col_supplier.VisibleIndex = 2
        Me.col_supplier.Width = 250
        '
        'col_total_cost
        '
        Me.col_total_cost.AppearanceCell.Options.UseTextOptions = True
        Me.col_total_cost.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_total_cost.AppearanceHeader.Options.UseTextOptions = True
        Me.col_total_cost.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_total_cost.Caption = "Total Cost"
        Me.col_total_cost.DisplayFormat.FormatString = "c2"
        Me.col_total_cost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_total_cost.FieldName = "total_cost"
        Me.col_total_cost.MaxWidth = 150
        Me.col_total_cost.MinWidth = 100
        Me.col_total_cost.Name = "col_total_cost"
        Me.col_total_cost.Visible = True
        Me.col_total_cost.VisibleIndex = 4
        Me.col_total_cost.Width = 100
        '
        'col_createdat
        '
        Me.col_createdat.AppearanceCell.Options.UseTextOptions = True
        Me.col_createdat.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_createdat.AppearanceHeader.Options.UseTextOptions = True
        Me.col_createdat.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_createdat.Caption = "Created At"
        Me.col_createdat.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.col_createdat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col_createdat.FieldName = "created_at"
        Me.col_createdat.MaxWidth = 120
        Me.col_createdat.MinWidth = 120
        Me.col_createdat.Name = "col_createdat"
        Me.col_createdat.Visible = True
        Me.col_createdat.VisibleIndex = 5
        Me.col_createdat.Width = 120
        '
        'col_batchno
        '
        Me.col_batchno.AppearanceCell.Options.UseTextOptions = True
        Me.col_batchno.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_batchno.AppearanceHeader.Options.UseTextOptions = True
        Me.col_batchno.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_batchno.Caption = "Batch No."
        Me.col_batchno.FieldName = "batch_no"
        Me.col_batchno.MaxWidth = 100
        Me.col_batchno.MinWidth = 100
        Me.col_batchno.Name = "col_batchno"
        Me.col_batchno.Visible = True
        Me.col_batchno.VisibleIndex = 3
        Me.col_batchno.Width = 100
        '
        'col_status
        '
        Me.col_status.AppearanceCell.Options.UseTextOptions = True
        Me.col_status.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_status.Caption = "Status"
        Me.col_status.FieldName = "status"
        Me.col_status.MaxWidth = 150
        Me.col_status.Name = "col_status"
        Me.col_status.Visible = True
        Me.col_status.VisibleIndex = 6
        '
        'btn_new_return
        '
        Me.btn_new_return.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_new_return.Appearance.Options.UseFont = True
        Me.btn_new_return.Appearance.Options.UseTextOptions = True
        Me.btn_new_return.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btn_new_return.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btn_new_return.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.newsales_32x32
        Me.btn_new_return.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_new_return.ImageOptions.ImageToTextIndent = 5
        Me.btn_new_return.Location = New System.Drawing.Point(19, 95)
        Me.btn_new_return.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_new_return.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_new_return.Name = "btn_new_return"
        Me.btn_new_return.Size = New System.Drawing.Size(160, 46)
        Me.btn_new_return.TabIndex = 14
        Me.btn_new_return.Text = "New Return"
        '
        'frm_purchaseorder_return_list
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1224, 716)
        Me.Controls.Add(Me.grid_returns)
        Me.Controls.Add(Me.btn_new_return)
        Me.Controls.Add(Me.panel_top)
        Me.Name = "frm_purchaseorder_return_list"
        Me.Text = "frm_purchaseorder_return"
        Me.panel_top.ResumeLayout(False)
        Me.panel_top.PerformLayout()
        Me.GunaPanel5.ResumeLayout(False)
        Me.GunaPanel1.ResumeLayout(False)
        Me.GunaPanel1.PerformLayout()
        CType(Me.grid_returns, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_returns_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_view_order, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panel_top As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPanel5 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents link_po_list As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents link_home As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents lbl_title As Guna.UI.WinForms.GunaLabel
    Friend WithEvents grid_returns As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_returns_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_view As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_view_order As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents col_supplier As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_rid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_total_cost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_createdat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_batchno As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_new_return As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents col_status As DevExpress.XtraGrid.Columns.GridColumn
End Class
