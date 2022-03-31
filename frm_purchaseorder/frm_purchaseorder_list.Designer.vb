
Imports DevExpress.XtraGrid.Columns

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_purchaseorder_list
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_purchaseorder_list))
        Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.panel_top = New Guna.UI.WinForms.GunaPanel()
        Me.GunaPanel5 = New Guna.UI.WinForms.GunaPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.cbb_timer = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.link_po_list = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.link_home = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.btn_new = New DevExpress.XtraEditors.SimpleButton()
        Me.grid_po = New DevExpress.XtraGrid.GridControl()
        Me.grid_po_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_view = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btn_view = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.col_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_lead_time_status = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_edd = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_date_generated = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_created_by = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_terms = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btn_fulfilled = New DevExpress.XtraEditors.SimpleButton()
        Me.GunaPanel2 = New Guna.UI.WinForms.GunaPanel()
        Me.btn_ordered_items = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_obsolete = New DevExpress.XtraEditors.SimpleButton()
        Me.panel_sub_content = New Guna.UI.WinForms.GunaPanel()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.timer = New System.Windows.Forms.Timer(Me.components)
        Me.panel_top.SuspendLayout()
        Me.GunaPanel5.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbb_timer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaPanel1.SuspendLayout()
        CType(Me.grid_po, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_po_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaPanel2.SuspendLayout()
        Me.panel_sub_content.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel_top
        '
        Me.panel_top.BackColor = System.Drawing.Color.GhostWhite
        Me.panel_top.Controls.Add(Me.GunaPanel5)
        Me.panel_top.Controls.Add(Me.GunaLabel2)
        Me.panel_top.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_top.Location = New System.Drawing.Point(0, 0)
        Me.panel_top.Name = "panel_top"
        Me.panel_top.Size = New System.Drawing.Size(1367, 78)
        Me.panel_top.TabIndex = 7
        '
        'GunaPanel5
        '
        Me.GunaPanel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaPanel5.BackColor = System.Drawing.Color.Transparent
        Me.GunaPanel5.Controls.Add(Me.Panel2)
        Me.GunaPanel5.Controls.Add(Me.GunaPanel1)
        Me.GunaPanel5.Location = New System.Drawing.Point(19, 44)
        Me.GunaPanel5.Name = "GunaPanel5"
        Me.GunaPanel5.Size = New System.Drawing.Size(1330, 27)
        Me.GunaPanel5.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.PictureEdit1)
        Me.Panel2.Controls.Add(Me.cbb_timer)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(1218, 0)
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
        Me.link_po_list.Size = New System.Drawing.Size(91, 18)
        Me.link_po_list.TabIndex = 7
        Me.link_po_list.Text = "Purchasing List"
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
        Me.GunaLabel2.Size = New System.Drawing.Size(219, 31)
        Me.GunaLabel2.TabIndex = 1
        Me.GunaLabel2.Text = "Purchase Orders"
        '
        'btn_new
        '
        Me.btn_new.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btn_new.Appearance.Options.UseFont = True
        Me.btn_new.Appearance.Options.UseTextOptions = True
        Me.btn_new.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btn_new.ImageOptions.Image = CType(resources.GetObject("btn_new.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_new.ImageOptions.ImageIndex = 5
        Me.btn_new.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_new.ImageOptions.ImageToTextIndent = 8
        Me.btn_new.ImageOptions.SvgImageSize = New System.Drawing.Size(20, 20)
        Me.btn_new.Location = New System.Drawing.Point(12, 15)
        Me.btn_new.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_new.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(160, 46)
        Me.btn_new.TabIndex = 0
        Me.btn_new.Text = "New Purchase"
        '
        'grid_po
        '
        Me.grid_po.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_po.Location = New System.Drawing.Point(12, 72)
        Me.grid_po.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grid_po.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grid_po.MainView = Me.grid_po_view
        Me.grid_po.Name = "grid_po"
        Me.grid_po.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit1, Me.btn_view})
        Me.grid_po.Size = New System.Drawing.Size(1343, 554)
        Me.grid_po.TabIndex = 8
        Me.grid_po.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_po_view})
        '
        'grid_po_view
        '
        Me.grid_po_view.Appearance.HeaderPanel.BackColor = System.Drawing.Color.White
        Me.grid_po_view.Appearance.HeaderPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.grid_po_view.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grid_po_view.Appearance.HeaderPanel.Options.UseFont = True
        Me.grid_po_view.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.grid_po_view.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grid_po_view.Appearance.Row.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.grid_po_view.Appearance.Row.Options.UseFont = True
        Me.grid_po_view.Appearance.SelectedRow.BackColor = System.Drawing.Color.White
        Me.grid_po_view.Appearance.SelectedRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.grid_po_view.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grid_po_view.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grid_po_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_view, Me.col_id, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn6, Me.GridColumn7, Me.col_lead_time_status, Me.col_edd, Me.col_date_generated, Me.col_created_by, Me.col_terms})
        Me.grid_po_view.GridControl = Me.grid_po
        Me.grid_po_view.Name = "grid_po_view"
        Me.grid_po_view.OptionsBehavior.ReadOnly = True
        Me.grid_po_view.OptionsSelection.ResetSelectionClickOutsideCheckboxSelector = True
        '
        'col_view
        '
        Me.col_view.Caption = "Action"
        Me.col_view.ColumnEdit = Me.btn_view
        Me.col_view.Name = "col_view"
        Me.col_view.Visible = True
        Me.col_view.VisibleIndex = 0
        Me.col_view.Width = 54
        '
        'btn_view
        '
        Me.btn_view.AutoHeight = False
        Me.btn_view.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        EditorButtonImageOptions1.Image = Global.Inventory_Management.My.Resources.Resources.snapmodifytablecellstyle_16x16
        Me.btn_view.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.btn_view.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_view.Name = "btn_view"
        Me.btn_view.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'col_id
        '
        Me.col_id.AppearanceCell.Options.UseTextOptions = True
        Me.col_id.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_id.AppearanceHeader.Options.UseTextOptions = True
        Me.col_id.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_id.FieldName = "ID"
        Me.col_id.MaxWidth = 80
        Me.col_id.MinWidth = 50
        Me.col_id.Name = "col_id"
        Me.col_id.Visible = True
        Me.col_id.VisibleIndex = 1
        Me.col_id.Width = 80
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.Caption = "Delivery Site"
        Me.GridColumn2.FieldName = "deliver_to"
        Me.GridColumn2.MaxWidth = 300
        Me.GridColumn2.MinWidth = 50
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 3
        Me.GridColumn2.Width = 186
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.Caption = "Supplier"
        Me.GridColumn3.FieldName = "supplier"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 238
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn4.Caption = "Amount (PHP)"
        Me.GridColumn4.DisplayFormat.FormatString = "n2"
        Me.GridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.GridColumn4.FieldName = "total"
        Me.GridColumn4.MaxWidth = 100
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 4
        Me.GridColumn4.Width = 100
        '
        'GridColumn6
        '
        Me.GridColumn6.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn6.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn6.Caption = "Date of Sent"
        Me.GridColumn6.ColumnEdit = Me.RepositoryItemDateEdit1
        Me.GridColumn6.DisplayFormat.FormatString = "MMMM dd, yyyy"
        Me.GridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn6.FieldName = "date_sent"
        Me.GridColumn6.MaxWidth = 150
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 8
        Me.GridColumn6.Width = 114
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'GridColumn7
        '
        Me.GridColumn7.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn7.Caption = "Status"
        Me.GridColumn7.FieldName = "status"
        Me.GridColumn7.MinWidth = 120
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 6
        Me.GridColumn7.Width = 125
        '
        'col_lead_time_status
        '
        Me.col_lead_time_status.AppearanceCell.Options.UseTextOptions = True
        Me.col_lead_time_status.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_lead_time_status.Caption = "Validity Status"
        Me.col_lead_time_status.FieldName = "lead_time_status"
        Me.col_lead_time_status.Name = "col_lead_time_status"
        Me.col_lead_time_status.Visible = True
        Me.col_lead_time_status.VisibleIndex = 10
        Me.col_lead_time_status.Width = 105
        '
        'col_edd
        '
        Me.col_edd.AppearanceCell.Options.UseTextOptions = True
        Me.col_edd.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_edd.Caption = "EDD"
        Me.col_edd.ColumnEdit = Me.RepositoryItemDateEdit1
        Me.col_edd.DisplayFormat.FormatString = "MMMM dd, yyyy"
        Me.col_edd.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col_edd.FieldName = "edd"
        Me.col_edd.Name = "col_edd"
        Me.col_edd.Visible = True
        Me.col_edd.VisibleIndex = 9
        Me.col_edd.Width = 97
        '
        'col_date_generated
        '
        Me.col_date_generated.AppearanceCell.Options.UseTextOptions = True
        Me.col_date_generated.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_date_generated.Caption = "Date Generated"
        Me.col_date_generated.DisplayFormat.FormatString = "MMMM dd, yyyy"
        Me.col_date_generated.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col_date_generated.FieldName = "date_generated"
        Me.col_date_generated.Name = "col_date_generated"
        Me.col_date_generated.Visible = True
        Me.col_date_generated.VisibleIndex = 7
        Me.col_date_generated.Width = 98
        '
        'col_created_by
        '
        Me.col_created_by.Caption = "Created By"
        Me.col_created_by.FieldName = "created_by"
        Me.col_created_by.Name = "col_created_by"
        Me.col_created_by.Visible = True
        Me.col_created_by.VisibleIndex = 11
        Me.col_created_by.Width = 115
        '
        'col_terms
        '
        Me.col_terms.AppearanceCell.Options.UseTextOptions = True
        Me.col_terms.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_terms.Caption = "Terms"
        Me.col_terms.FieldName = "terms"
        Me.col_terms.Name = "col_terms"
        Me.col_terms.Visible = True
        Me.col_terms.VisibleIndex = 5
        '
        'btn_fulfilled
        '
        Me.btn_fulfilled.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btn_fulfilled.Appearance.Options.UseFont = True
        Me.btn_fulfilled.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.historyitem_32x32
        Me.btn_fulfilled.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_fulfilled.ImageOptions.ImageToTextIndent = 5
        Me.btn_fulfilled.Location = New System.Drawing.Point(178, 15)
        Me.btn_fulfilled.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_fulfilled.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_fulfilled.Name = "btn_fulfilled"
        Me.btn_fulfilled.Size = New System.Drawing.Size(160, 46)
        Me.btn_fulfilled.TabIndex = 9
        Me.btn_fulfilled.Text = "Fulfilled Orders"
        '
        'GunaPanel2
        '
        Me.GunaPanel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaPanel2.Controls.Add(Me.btn_ordered_items)
        Me.GunaPanel2.Controls.Add(Me.btn_obsolete)
        Me.GunaPanel2.Controls.Add(Me.btn_new)
        Me.GunaPanel2.Controls.Add(Me.grid_po)
        Me.GunaPanel2.Controls.Add(Me.btn_fulfilled)
        Me.GunaPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GunaPanel2.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel2.Name = "GunaPanel2"
        Me.GunaPanel2.Size = New System.Drawing.Size(1367, 638)
        Me.GunaPanel2.TabIndex = 10
        '
        'btn_ordered_items
        '
        Me.btn_ordered_items.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_ordered_items.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btn_ordered_items.Appearance.Options.UseFont = True
        Me.btn_ordered_items.ImageOptions.Image = CType(resources.GetObject("btn_ordered_items.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_ordered_items.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_ordered_items.Location = New System.Drawing.Point(1195, 15)
        Me.btn_ordered_items.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_ordered_items.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_ordered_items.Name = "btn_ordered_items"
        Me.btn_ordered_items.Size = New System.Drawing.Size(160, 46)
        Me.btn_ordered_items.TabIndex = 99
        Me.btn_ordered_items.Text = "Ordered Items"
        '
        'btn_obsolete
        '
        Me.btn_obsolete.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btn_obsolete.Appearance.Options.UseFont = True
        Me.btn_obsolete.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.switchtimescalesto_32x32
        Me.btn_obsolete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_obsolete.ImageOptions.ImageToTextIndent = 5
        Me.btn_obsolete.Location = New System.Drawing.Point(344, 15)
        Me.btn_obsolete.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_obsolete.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_obsolete.Name = "btn_obsolete"
        Me.btn_obsolete.Size = New System.Drawing.Size(160, 46)
        Me.btn_obsolete.TabIndex = 10
        Me.btn_obsolete.Text = "Obsolete Orders"
        '
        'panel_sub_content
        '
        Me.panel_sub_content.BackColor = System.Drawing.Color.White
        Me.panel_sub_content.Controls.Add(Me.GunaPanel2)
        Me.panel_sub_content.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_sub_content.Location = New System.Drawing.Point(0, 78)
        Me.panel_sub_content.Name = "panel_sub_content"
        Me.panel_sub_content.Size = New System.Drawing.Size(1367, 638)
        Me.panel_sub_content.TabIndex = 11
        '
        'GridColumn5
        '
        Me.GridColumn5.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn5.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn5.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.GridColumn5.AppearanceHeader.Options.UseFont = True
        Me.GridColumn5.AppearanceHeader.Options.UseForeColor = True
        Me.GridColumn5.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn5.FieldName = "Status"
        Me.GridColumn5.MaxWidth = 100
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 4
        Me.GridColumn5.Width = 100
        '
        'GridColumn8
        '
        Me.GridColumn8.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn8.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn8.Caption = "Due Date Status"
        Me.GridColumn8.FieldName = "lead_time_status"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 6
        '
        'timer
        '
        '
        'frm_purchaseorder_list
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1367, 716)
        Me.Controls.Add(Me.panel_sub_content)
        Me.Controls.Add(Me.panel_top)
        Me.KeyPreview = True
        Me.Name = "frm_purchaseorder_list"
        Me.Text = "frm_purchaseorder_list"
        Me.panel_top.ResumeLayout(False)
        Me.panel_top.PerformLayout()
        Me.GunaPanel5.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbb_timer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaPanel1.ResumeLayout(False)
        Me.GunaPanel1.PerformLayout()
        CType(Me.grid_po, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_po_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaPanel2.ResumeLayout(False)
        Me.panel_sub_content.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panel_top As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPanel5 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents grid_po As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_po_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btn_new As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_ordered_items As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_id As DevExpress.XtraGrid.Columns.GridColumn

    Friend WithEvents col_created_by As GridColumn
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents link_po_list As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents link_home As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents btn_fulfilled As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GunaPanel2 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents panel_sub_content As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_lead_time_status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_edd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_obsolete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents cbb_timer As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents timer As Timer
    Friend WithEvents col_date_generated As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_active_orders As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents col_purchaser As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_view As GridColumn
    Friend WithEvents btn_view As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents col_terms As GridColumn
End Class
