Imports DevExpress.LookAndFeel
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports Guna.UI.WinForms
Imports System.ComponentModel
Imports System.Drawing.Drawing2D
Imports System.Runtime.CompilerServices

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_logistics_deliveries
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_logistics_deliveries))
		Dim editorButtonImageOption As EditorButtonImageOptions = New EditorButtonImageOptions()
		Dim serializableAppearanceObject As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
		Dim serializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
		Dim serializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
		Dim serializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
		Me.panel_top = New GunaPanel()
		Me.GunaPanel5 = New GunaPanel()
		Me.Panel2 = New Panel()
		Me.PictureEdit1 = New PictureEdit()
		Me.cbb_timer = New ComboBoxEdit()
		Me.GunaPanel1 = New GunaPanel()
		Me.link_po_list = New HyperlinkLabelControl()
		Me.LabelControl7 = New LabelControl()
		Me.link_home = New HyperlinkLabelControl()
		Me.lbl_title = New GunaLabel()
		Me.grid_deliveries = New GridControl()
		Me.grid_deliveries_view = New GridView()
		Me.col_id = New GridColumn()
		Me.GridColumn4 = New GridColumn()
		Me.col_shipping_method = New GridColumn()
		Me.col_status = New GridColumn()
		Me.col_payment_type = New GridColumn()
		Me.col_payment_status = New GridColumn()
		Me.col_amount = New GridColumn()
		Me.col_customer = New GridColumn()
		Me.GridColumn3 = New GridColumn()
		Me.GridColumn7 = New GridColumn()
		Me.GridColumn9 = New GridColumn()
		Me.col_release = New GridColumn()
		Me.btn_print = New RepositoryItemButtonEdit()
		Me.timer = New System.Windows.Forms.Timer(Me.components)
		Me.panel_top.SuspendLayout()
		Me.GunaPanel5.SuspendLayout()
		Me.Panel2.SuspendLayout()
		DirectCast(Me.PictureEdit1.Properties, ISupportInitialize).BeginInit()
		DirectCast(Me.cbb_timer.Properties, ISupportInitialize).BeginInit()
		Me.GunaPanel1.SuspendLayout()
		DirectCast(Me.grid_deliveries, ISupportInitialize).BeginInit()
		DirectCast(Me.grid_deliveries_view, ISupportInitialize).BeginInit()
		DirectCast(Me.btn_print, ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		Me.panel_top.BackColor = Color.GhostWhite
		Me.panel_top.Controls.Add(Me.GunaPanel5)
		Me.panel_top.Controls.Add(Me.lbl_title)
		Me.panel_top.Dock = DockStyle.Top
		Me.panel_top.Location = New Point(0, 0)
		Me.panel_top.Name = "panel_top"
		Me.panel_top.Size = New System.Drawing.Size(1094, 78)
		Me.panel_top.TabIndex = 12
		Me.GunaPanel5.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
		Me.GunaPanel5.BackColor = Color.Transparent
		Me.GunaPanel5.Controls.Add(Me.Panel2)
		Me.GunaPanel5.Controls.Add(Me.GunaPanel1)
		Me.GunaPanel5.Location = New Point(19, 44)
		Me.GunaPanel5.Name = "GunaPanel5"
		Me.GunaPanel5.Size = New System.Drawing.Size(1075, 27)
		Me.GunaPanel5.TabIndex = 5
		Me.Panel2.Controls.Add(Me.PictureEdit1)
		Me.Panel2.Controls.Add(Me.cbb_timer)
		Me.Panel2.Dock = DockStyle.Right
		Me.Panel2.Location = New Point(963, 0)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(112, 27)
		Me.Panel2.TabIndex = 9
		Me.PictureEdit1.EditValue = RuntimeHelpers.GetObjectValue(resources.GetObject("PictureEdit1.EditValue"))
		Me.PictureEdit1.Location = New Point(13, 4)
		Me.PictureEdit1.Name = "PictureEdit1"
		Me.PictureEdit1.Properties.Appearance.BackColor = Color.Transparent
		Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
		Me.PictureEdit1.Properties.BorderStyle = BorderStyles.NoBorder
		Me.PictureEdit1.Properties.ShowCameraMenuItem = CameraMenuItemVisibility.Auto
		Me.PictureEdit1.Properties.SizeMode = PictureSizeMode.Zoom
		Me.PictureEdit1.Size = New System.Drawing.Size(20, 20)
		Me.PictureEdit1.TabIndex = 6
		Me.cbb_timer.Anchor = AnchorStyles.Top Or AnchorStyles.Right
		Me.cbb_timer.EditValue = "1 min"
		Me.cbb_timer.Location = New Point(37, 4)
		Me.cbb_timer.Name = "cbb_timer"
		Me.cbb_timer.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
		Me.cbb_timer.Properties.Appearance.Options.UseFont = True
		Me.cbb_timer.Properties.Buttons.AddRange(New EditorButton() {New EditorButton(ButtonPredefines.Combo)})
		Me.cbb_timer.Properties.Items.AddRange(New Object() {"1 min", "5 min", "10 min", "30 min"})
		Me.cbb_timer.Properties.TextEditStyle = TextEditStyles.DisableTextEditor
		Me.cbb_timer.Size = New System.Drawing.Size(65, 20)
		Me.cbb_timer.TabIndex = 4
		Me.GunaPanel1.Controls.Add(Me.link_po_list)
		Me.GunaPanel1.Controls.Add(Me.LabelControl7)
		Me.GunaPanel1.Controls.Add(Me.link_home)
		Me.GunaPanel1.Dock = DockStyle.Left
		Me.GunaPanel1.Location = New Point(0, 0)
		Me.GunaPanel1.Name = "GunaPanel1"
		Me.GunaPanel1.Size = New System.Drawing.Size(435, 27)
		Me.GunaPanel1.TabIndex = 1
		Me.link_po_list.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, FontStyle.Bold, GraphicsUnit.Point, 0)
		Me.link_po_list.Appearance.LinkColor = DXSkinColors.ForeColors.ControlText
		Me.link_po_list.Appearance.Options.UseFont = True
		Me.link_po_list.Appearance.Options.UseLinkColor = True
		Me.link_po_list.AppearanceHovered.ForeColor = Color.FromArgb(0, 122, 204)
		Me.link_po_list.AppearanceHovered.LinkColor = Color.FromArgb(0, 122, 204)
		Me.link_po_list.AppearanceHovered.Options.UseForeColor = True
		Me.link_po_list.AppearanceHovered.Options.UseLinkColor = True
		Me.link_po_list.AppearancePressed.LinkColor = Color.FromArgb(0, 122, 204)
		Me.link_po_list.AppearancePressed.Options.UseLinkColor = True
		Me.link_po_list.Enabled = False
		Me.link_po_list.LineStyle = DashStyle.Custom
		Me.link_po_list.LinkBehavior = LinkBehavior.NeverUnderline
		Me.link_po_list.Location = New Point(70, 5)
		Me.link_po_list.Name = "link_po_list"
		Me.link_po_list.ShowLineShadow = False
		Me.link_po_list.Size = New System.Drawing.Size(121, 18)
		Me.link_po_list.TabIndex = 7
		Me.link_po_list.Text = "Deliveries && Pickup"
		Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
		Me.LabelControl7.Appearance.Options.UseFont = True
		Me.LabelControl7.Location = New Point(55, 7)
		Me.LabelControl7.Name = "LabelControl7"
		Me.LabelControl7.Size = New System.Drawing.Size(9, 14)
		Me.LabelControl7.TabIndex = 6
		Me.LabelControl7.Text = ">"
		Me.link_home.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, FontStyle.Regular, GraphicsUnit.Point, 0)
		Me.link_home.Appearance.LinkColor = DXSkinColors.ForeColors.ControlText
		Me.link_home.Appearance.Options.UseFont = True
		Me.link_home.Appearance.Options.UseLinkColor = True
		Me.link_home.AppearanceDisabled.LinkColor = Color.FromArgb(0, 122, 204)
		Me.link_home.AppearanceDisabled.Options.UseLinkColor = True
		Me.link_home.AppearanceHovered.ForeColor = Color.FromArgb(0, 122, 204)
		Me.link_home.AppearanceHovered.LinkColor = Color.FromArgb(0, 122, 204)
		Me.link_home.AppearanceHovered.Options.UseForeColor = True
		Me.link_home.AppearanceHovered.Options.UseLinkColor = True
		Me.link_home.AppearancePressed.LinkColor = Color.FromArgb(0, 122, 204)
		Me.link_home.AppearancePressed.Options.UseLinkColor = True
		Me.link_home.LineStyle = DashStyle.Custom
		Me.link_home.LinkBehavior = LinkBehavior.NeverUnderline
		Me.link_home.Location = New Point(13, 5)
		Me.link_home.Name = "link_home"
		Me.link_home.ShowLineShadow = False
		Me.link_home.Size = New System.Drawing.Size(37, 18)
		Me.link_home.TabIndex = 5
		Me.link_home.Text = "Home"
		Me.lbl_title.AutoSize = True
		Me.lbl_title.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
		Me.lbl_title.ForeColor = Color.FromArgb(213, 115, 45)
		Me.lbl_title.Location = New Point(14, 10)
		Me.lbl_title.Name = "lbl_title"
		Me.lbl_title.Size = New System.Drawing.Size(248, 31)
		Me.lbl_title.TabIndex = 1
		Me.lbl_title.Text = "Deliveries && Pickup"
		Me.grid_deliveries.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
		Me.grid_deliveries.Location = New Point(20, 100)
		Me.grid_deliveries.LookAndFeel.SkinName = "Office 2010 Blue"
		Me.grid_deliveries.LookAndFeel.UseDefaultLookAndFeel = False
		Me.grid_deliveries.MainView = Me.grid_deliveries_view
		Me.grid_deliveries.Name = "grid_deliveries"
		Me.grid_deliveries.RepositoryItems.AddRange(New RepositoryItem() {Me.btn_print})
		Me.grid_deliveries.Size = New System.Drawing.Size(1056, 562)
		Me.grid_deliveries.TabIndex = 13
		Me.grid_deliveries.ViewCollection.AddRange(New BaseView() {Me.grid_deliveries_view})
		Me.grid_deliveries_view.Appearance.HeaderPanel.BackColor = Color.White
		Me.grid_deliveries_view.Appearance.HeaderPanel.Font = New System.Drawing.Font("Nunito", 9.749999!)
		Me.grid_deliveries_view.Appearance.HeaderPanel.Options.UseBackColor = True
		Me.grid_deliveries_view.Appearance.HeaderPanel.Options.UseFont = True
		Me.grid_deliveries_view.Appearance.Row.Font = New System.Drawing.Font("Nunito", 9.749999!)
		Me.grid_deliveries_view.Appearance.Row.Options.UseFont = True
		Me.grid_deliveries_view.Appearance.SelectedRow.BackColor = Color.White
		Me.grid_deliveries_view.Appearance.SelectedRow.ForeColor = Color.FromArgb(0, 122, 204)
		Me.grid_deliveries_view.Appearance.SelectedRow.Options.UseBackColor = True
		Me.grid_deliveries_view.Appearance.SelectedRow.Options.UseForeColor = True
		Me.grid_deliveries_view.Columns.AddRange(New GridColumn() {Me.col_id, Me.GridColumn4, Me.col_shipping_method, Me.col_status, Me.col_payment_type, Me.col_payment_status, Me.col_amount, Me.col_customer, Me.GridColumn3, Me.GridColumn7, Me.GridColumn9, Me.col_release})
		Me.grid_deliveries_view.GridControl = Me.grid_deliveries
		Me.grid_deliveries_view.Name = "grid_deliveries_view"
		Me.grid_deliveries_view.OptionsBehavior.[ReadOnly] = True
		Me.grid_deliveries_view.OptionsSelection.ResetSelectionClickOutsideCheckboxSelector = True
		Me.grid_deliveries_view.OptionsView.ShowFooter = True
		Me.grid_deliveries_view.OptionsView.ShowHorizontalLines = DefaultBoolean.[False]
		Me.col_id.AppearanceCell.ForeColor = Color.FromArgb(0, 122, 204)
		Me.col_id.AppearanceCell.Options.UseForeColor = True
		Me.col_id.AppearanceCell.Options.UseTextOptions = True
		Me.col_id.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center
		Me.col_id.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, FontStyle.Bold)
		Me.col_id.AppearanceHeader.ForeColor = DXSkinColors.ForeColors.ControlText
		Me.col_id.AppearanceHeader.Options.UseFont = True
		Me.col_id.AppearanceHeader.Options.UseForeColor = True
		Me.col_id.AppearanceHeader.Options.UseTextOptions = True
		Me.col_id.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center
		Me.col_id.Caption = "Order ID"
		Me.col_id.FieldName = "order_id"
		Me.col_id.MaxWidth = 100
		Me.col_id.MinWidth = 50
		Me.col_id.Name = "col_id"
		Me.col_id.OptionsColumn.AllowEdit = False
		Me.col_id.OptionsColumn.[ReadOnly] = True
		Me.col_id.Visible = True
		Me.col_id.VisibleIndex = 0
		Me.col_id.Width = 62
		Me.GridColumn4.AppearanceCell.Options.UseTextOptions = True
		Me.GridColumn4.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center
		Me.GridColumn4.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, FontStyle.Bold, GraphicsUnit.Point, 0)
		Me.GridColumn4.AppearanceHeader.ForeColor = DXSkinColors.ForeColors.ControlText
		Me.GridColumn4.AppearanceHeader.Options.UseFont = True
		Me.GridColumn4.AppearanceHeader.Options.UseForeColor = True
		Me.GridColumn4.AppearanceHeader.Options.UseTextOptions = True
		Me.GridColumn4.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center
		Me.GridColumn4.Caption = "Order Date"
		Me.GridColumn4.DisplayFormat.FormatString = "MMM dd, yyyy"
		Me.GridColumn4.DisplayFormat.FormatType = FormatType.DateTime
		Me.GridColumn4.FieldName = "date_ordered"
		Me.GridColumn4.Name = "GridColumn4"
		Me.GridColumn4.OptionsColumn.AllowEdit = False
		Me.GridColumn4.OptionsColumn.[ReadOnly] = True
		Me.GridColumn4.Visible = True
		Me.GridColumn4.VisibleIndex = 7
		Me.GridColumn4.Width = 67
		Me.col_shipping_method.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, FontStyle.Bold, GraphicsUnit.Point, 0)
		Me.col_shipping_method.AppearanceHeader.ForeColor = DXSkinColors.ForeColors.ControlText
		Me.col_shipping_method.AppearanceHeader.Options.UseFont = True
		Me.col_shipping_method.AppearanceHeader.Options.UseForeColor = True
		Me.col_shipping_method.AppearanceHeader.Options.UseTextOptions = True
		Me.col_shipping_method.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center
		Me.col_shipping_method.Caption = "Ship Type"
		Me.col_shipping_method.FieldName = "shipping_method"
		Me.col_shipping_method.Name = "col_shipping_method"
		Me.col_shipping_method.Visible = True
		Me.col_shipping_method.VisibleIndex = 2
		Me.col_shipping_method.Width = 59
		Me.col_status.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, FontStyle.Bold, GraphicsUnit.Point, 0)
		Me.col_status.AppearanceHeader.ForeColor = DXSkinColors.ForeColors.ControlText
		Me.col_status.AppearanceHeader.Options.UseFont = True
		Me.col_status.AppearanceHeader.Options.UseForeColor = True
		Me.col_status.AppearanceHeader.Options.UseTextOptions = True
		Me.col_status.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center
		Me.col_status.Caption = "Status"
		Me.col_status.FieldName = "status"
		Me.col_status.Name = "col_status"
		Me.col_status.Visible = True
		Me.col_status.VisibleIndex = 10
		Me.col_status.Width = 73
		Me.col_payment_type.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, FontStyle.Bold, GraphicsUnit.Point, 0)
		Me.col_payment_type.AppearanceHeader.ForeColor = DXSkinColors.ForeColors.ControlText
		Me.col_payment_type.AppearanceHeader.Options.UseFont = True
		Me.col_payment_type.AppearanceHeader.Options.UseForeColor = True
		Me.col_payment_type.AppearanceHeader.Options.UseTextOptions = True
		Me.col_payment_type.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center
		Me.col_payment_type.Caption = "Payment Type"
		Me.col_payment_type.FieldName = "payment_type"
		Me.col_payment_type.Name = "col_payment_type"
		Me.col_payment_type.Visible = True
		Me.col_payment_type.VisibleIndex = 3
		Me.col_payment_type.Width = 81
		Me.col_payment_status.AppearanceCell.Options.UseTextOptions = True
		Me.col_payment_status.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center
		Me.col_payment_status.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, FontStyle.Bold, GraphicsUnit.Point, 0)
		Me.col_payment_status.AppearanceHeader.ForeColor = DXSkinColors.ForeColors.ControlText
		Me.col_payment_status.AppearanceHeader.Options.UseFont = True
		Me.col_payment_status.AppearanceHeader.Options.UseForeColor = True
		Me.col_payment_status.AppearanceHeader.Options.UseTextOptions = True
		Me.col_payment_status.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center
		Me.col_payment_status.Caption = "Payment Status"
		Me.col_payment_status.FieldName = "payment_status"
		Me.col_payment_status.Name = "col_payment_status"
		Me.col_payment_status.OptionsColumn.AllowEdit = False
		Me.col_payment_status.OptionsColumn.[ReadOnly] = True
		Me.col_payment_status.Visible = True
		Me.col_payment_status.VisibleIndex = 4
		Me.col_payment_status.Width = 88
		Me.col_amount.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, FontStyle.Bold, GraphicsUnit.Point, 0)
		Me.col_amount.AppearanceHeader.Options.UseFont = True
		Me.col_amount.AppearanceHeader.Options.UseTextOptions = True
		Me.col_amount.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center
		Me.col_amount.Caption = "Amount"
		Me.col_amount.DisplayFormat.FormatString = "c2"
		Me.col_amount.DisplayFormat.FormatType = FormatType.Numeric
		Me.col_amount.FieldName = "amount_due"
		Me.col_amount.Name = "col_amount"
		Me.col_amount.Visible = True
		Me.col_amount.VisibleIndex = 5
		Me.col_amount.Width = 80
		Me.col_customer.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, FontStyle.Bold)
		Me.col_customer.AppearanceHeader.ForeColor = DXSkinColors.ForeColors.ControlText
		Me.col_customer.AppearanceHeader.Options.UseFont = True
		Me.col_customer.AppearanceHeader.Options.UseForeColor = True
		Me.col_customer.AppearanceHeader.Options.UseTextOptions = True
		Me.col_customer.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center
		Me.col_customer.Caption = "Customer"
		Me.col_customer.FieldName = "first_name"
		Me.col_customer.MinWidth = 50
		Me.col_customer.Name = "col_customer"
		Me.col_customer.OptionsColumn.AllowEdit = False
		Me.col_customer.OptionsColumn.[ReadOnly] = True
		Me.col_customer.Visible = True
		Me.col_customer.VisibleIndex = 1
		Me.col_customer.Width = 151
		Me.GridColumn3.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, FontStyle.Bold)
		Me.GridColumn3.AppearanceHeader.ForeColor = DXSkinColors.ForeColors.ControlText
		Me.GridColumn3.AppearanceHeader.Options.UseFont = True
		Me.GridColumn3.AppearanceHeader.Options.UseForeColor = True
		Me.GridColumn3.AppearanceHeader.Options.UseTextOptions = True
		Me.GridColumn3.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center
		Me.GridColumn3.Caption = "Agent"
		Me.GridColumn3.FieldName = "agent"
		Me.GridColumn3.Name = "GridColumn3"
		Me.GridColumn3.OptionsColumn.AllowEdit = False
		Me.GridColumn3.OptionsColumn.[ReadOnly] = True
		Me.GridColumn3.Visible = True
		Me.GridColumn3.VisibleIndex = 6
		Me.GridColumn3.Width = 79
		Me.GridColumn7.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, FontStyle.Bold)
		Me.GridColumn7.AppearanceHeader.ForeColor = DXSkinColors.ForeColors.ControlText
		Me.GridColumn7.AppearanceHeader.Options.UseFont = True
		Me.GridColumn7.AppearanceHeader.Options.UseForeColor = True
		Me.GridColumn7.AppearanceHeader.Options.UseTextOptions = True
		Me.GridColumn7.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center
		Me.GridColumn7.Caption = "Trucking"
		Me.GridColumn7.FieldName = "trucking"
		Me.GridColumn7.Name = "GridColumn7"
		Me.GridColumn7.OptionsColumn.AllowEdit = False
		Me.GridColumn7.OptionsColumn.[ReadOnly] = True
		Me.GridColumn7.Visible = True
		Me.GridColumn7.VisibleIndex = 8
		Me.GridColumn7.Width = 83
		Me.GridColumn9.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, FontStyle.Bold, GraphicsUnit.Point, 0)
		Me.GridColumn9.AppearanceHeader.ForeColor = DXSkinColors.ForeColors.ControlText
		Me.GridColumn9.AppearanceHeader.Options.UseFont = True
		Me.GridColumn9.AppearanceHeader.Options.UseForeColor = True
		Me.GridColumn9.AppearanceHeader.Options.UseTextOptions = True
		Me.GridColumn9.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center
		Me.GridColumn9.Caption = "Ship To"
		Me.GridColumn9.FieldName = "ship_to"
		Me.GridColumn9.Name = "GridColumn9"
		Me.GridColumn9.OptionsColumn.AllowEdit = False
		Me.GridColumn9.OptionsColumn.[ReadOnly] = True
		Me.GridColumn9.Visible = True
		Me.GridColumn9.VisibleIndex = 9
		Me.GridColumn9.Width = 173
		Me.col_release.AppearanceCell.Options.UseTextOptions = True
		Me.col_release.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center
		Me.col_release.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, FontStyle.Bold, GraphicsUnit.Point, 0)
		Me.col_release.AppearanceHeader.ForeColor = DXSkinColors.ForeColors.ControlText
		Me.col_release.AppearanceHeader.Options.UseFont = True
		Me.col_release.AppearanceHeader.Options.UseForeColor = True
		Me.col_release.AppearanceHeader.Options.UseTextOptions = True
		Me.col_release.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center
		Me.col_release.Caption = "Release"
		Me.col_release.ColumnEdit = Me.btn_print
		Me.col_release.MaxWidth = 70
		Me.col_release.Name = "col_release"
		Me.col_release.OptionsColumn.[ReadOnly] = True
		Me.col_release.Visible = True
		Me.col_release.VisibleIndex = 11
		Me.col_release.Width = 70
		Me.btn_print.AutoHeight = False
		Me.btn_print.BorderStyle = BorderStyles.NoBorder
		editorButtonImageOption.Image = My.Resources.deliver
		Me.btn_print.Buttons.AddRange(New EditorButton() {New EditorButton(ButtonPredefines.Glyph, "", -1, True, True, False, editorButtonImageOption, New KeyShortcut(Keys.None), serializableAppearanceObject, serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, "", Nothing, Nothing, ToolTipAnchor.[Default])})
		Me.btn_print.ButtonsStyle = BorderStyles.UltraFlat
		Me.btn_print.Name = "btn_print"
		Me.btn_print.TextEditStyle = TextEditStyles.HideTextEditor
		Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = Color.White
		Me.ClientSize = New System.Drawing.Size(1094, 674)
		Me.Controls.Add(Me.grid_deliveries)
		Me.Controls.Add(Me.panel_top)
		Me.Name = "frm_logistics_deliveries"
		Me.Text = "frm_logistics_deliveries"
		Me.panel_top.ResumeLayout(False)
		Me.panel_top.PerformLayout()
		Me.GunaPanel5.ResumeLayout(False)
		Me.Panel2.ResumeLayout(False)
		DirectCast(Me.PictureEdit1.Properties, ISupportInitialize).EndInit()
		DirectCast(Me.cbb_timer.Properties, ISupportInitialize).EndInit()
		Me.GunaPanel1.ResumeLayout(False)
		Me.GunaPanel1.PerformLayout()
		DirectCast(Me.grid_deliveries, ISupportInitialize).EndInit()
		DirectCast(Me.grid_deliveries_view, ISupportInitialize).EndInit()
		DirectCast(Me.btn_print, ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

    Friend WithEvents panel_top As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPanel5 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents link_po_list As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents link_home As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents lbl_title As Guna.UI.WinForms.GunaLabel
    Friend WithEvents grid_deliveries As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_deliveries_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_customer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_payment_status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_release As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_print As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents col_status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_payment_type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_shipping_method As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_amount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents cbb_timer As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents timer As Timer
End Class
