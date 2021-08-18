
Imports DevExpress.LookAndFeel
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraTab
Imports Guna.UI.WinForms
Imports Inventory_Management.My
Imports Inventory_Management.My.Resources
Imports System.ComponentModel
Imports System.Drawing.Drawing2D


<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_product_catalogue
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
        Me.panel_content = New Guna.UI.WinForms.GunaPanel()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.sw_view_stocks = New DevExpress.XtraEditors.ToggleSwitch()
        Me.grid_catalogue = New DevExpress.XtraGrid.GridControl()
        Me.grid_catalogue_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_pid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_price = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_dealer_price = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_vip_price = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_main_category = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_sub_category = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_brand = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_my_qty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_onhold_qty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_other_qty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btn_print = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_details = New DevExpress.XtraEditors.SimpleButton()
        Me.panel_side = New Guna.UI.WinForms.GunaLinePanel()
        Me.panel_side_inner = New DevExpress.XtraEditors.XtraScrollableControl()
        Me.GunaLinePanel1 = New Guna.UI.WinForms.GunaLinePanel()
        Me.lbl_view_more = New System.Windows.Forms.LinkLabel()
        Me.txt_warranty = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl22 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_brand = New DevExpress.XtraEditors.TextEdit()
        Me.txt_sub_category = New DevExpress.XtraEditors.TextEdit()
        Me.txt_main_category = New DevExpress.XtraEditors.TextEdit()
        Me.txt_status = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_hazards = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_tags = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_update = New DevExpress.XtraEditors.SimpleButton()
        Me.GunaGroupBox2 = New Guna.UI.WinForms.GunaGroupBox()
        Me.txt_weight = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_height = New DevExpress.XtraEditors.TextEdit()
        Me.txt_width = New DevExpress.XtraEditors.TextEdit()
        Me.txt_length = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_retail_price = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_description = New DevExpress.XtraEditors.MemoEdit()
        Me.txt_winmodel = New DevExpress.XtraEditors.TextEdit()
        Me.txt_barcode = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_pid = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.pb_product = New DevExpress.XtraEditors.PictureEdit()
        Me.GunaLinePanel2 = New Guna.UI.WinForms.GunaLinePanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.panel_top = New Guna.UI.WinForms.GunaLinePanel()
        Me.GunaPanel5 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaPanel2 = New Guna.UI.WinForms.GunaPanel()
        Me.link_po_list = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.link_home = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.bgw_load_catalogue = New System.ComponentModel.BackgroundWorker()
        Me.panel_content.SuspendLayout()
        CType(Me.sw_view_stocks.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_catalogue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_catalogue_view, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_side.SuspendLayout()
        Me.panel_side_inner.SuspendLayout()
        Me.GunaLinePanel1.SuspendLayout()
        CType(Me.txt_warranty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_brand.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sub_category.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_main_category.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_hazards.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_tags.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaGroupBox2.SuspendLayout()
        CType(Me.txt_weight.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_height.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_width.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_length.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_retail_price.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_description.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_winmodel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_barcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_product.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaLinePanel2.SuspendLayout()
        Me.panel_top.SuspendLayout()
        Me.GunaPanel5.SuspendLayout()
        Me.GunaPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel_content
        '
        Me.panel_content.BackColor = System.Drawing.Color.White
        Me.panel_content.Controls.Add(Me.LabelControl1)
        Me.panel_content.Controls.Add(Me.sw_view_stocks)
        Me.panel_content.Controls.Add(Me.grid_catalogue)
        Me.panel_content.Controls.Add(Me.btn_print)
        Me.panel_content.Controls.Add(Me.btn_details)
        Me.panel_content.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_content.Location = New System.Drawing.Point(0, 78)
        Me.panel_content.Name = "panel_content"
        Me.panel_content.Size = New System.Drawing.Size(1082, 610)
        Me.panel_content.TabIndex = 2
        '
        'LabelControl1
        '
        Me.LabelControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseTextOptions = True
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl1.Location = New System.Drawing.Point(979, 21)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(73, 16)
        Me.LabelControl1.TabIndex = 71
        Me.LabelControl1.Text = "View Stocks"
        '
        'sw_view_stocks
        '
        Me.sw_view_stocks.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sw_view_stocks.Location = New System.Drawing.Point(979, 43)
        Me.sw_view_stocks.Name = "sw_view_stocks"
        Me.sw_view_stocks.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.sw_view_stocks.Properties.LookAndFeel.SkinName = "The Bezier"
        Me.sw_view_stocks.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.sw_view_stocks.Properties.OffText = "Hide"
        Me.sw_view_stocks.Properties.OnText = "Show"
        Me.sw_view_stocks.Size = New System.Drawing.Size(95, 20)
        Me.sw_view_stocks.TabIndex = 5
        '
        'grid_catalogue
        '
        Me.grid_catalogue.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_catalogue.Location = New System.Drawing.Point(20, 72)
        Me.grid_catalogue.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grid_catalogue.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grid_catalogue.MainView = Me.grid_catalogue_view
        Me.grid_catalogue.Name = "grid_catalogue"
        Me.grid_catalogue.Size = New System.Drawing.Size(1054, 530)
        Me.grid_catalogue.TabIndex = 4
        Me.grid_catalogue.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_catalogue_view})
        '
        'grid_catalogue_view
        '
        Me.grid_catalogue_view.Appearance.HeaderPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.grid_catalogue_view.Appearance.HeaderPanel.Options.UseFont = True
        Me.grid_catalogue_view.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.grid_catalogue_view.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grid_catalogue_view.Appearance.Row.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.grid_catalogue_view.Appearance.Row.Options.UseFont = True
        Me.grid_catalogue_view.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.grid_catalogue_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_pid, Me.GridColumn3, Me.GridColumn4, Me.col_price, Me.GridColumn6, Me.col_dealer_price, Me.col_vip_price, Me.col_main_category, Me.col_sub_category, Me.col_brand, Me.col_my_qty, Me.col_onhold_qty, Me.col_other_qty})
        Me.grid_catalogue_view.GridControl = Me.grid_catalogue
        Me.grid_catalogue_view.Name = "grid_catalogue_view"
        Me.grid_catalogue_view.OptionsBehavior.ReadOnly = True
        Me.grid_catalogue_view.OptionsClipboard.CopyColumnHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.grid_catalogue_view.OptionsLayout.Columns.AddNewColumns = False
        Me.grid_catalogue_view.OptionsLayout.Columns.RemoveOldColumns = False
        Me.grid_catalogue_view.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.[False]
        '
        'col_pid
        '
        Me.col_pid.AppearanceCell.Options.UseTextOptions = True
        Me.col_pid.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_pid.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.col_pid.AppearanceHeader.Options.UseForeColor = True
        Me.col_pid.Caption = "Product ID"
        Me.col_pid.FieldName = "pid"
        Me.col_pid.MaxWidth = 120
        Me.col_pid.Name = "col_pid"
        Me.col_pid.Visible = True
        Me.col_pid.VisibleIndex = 0
        Me.col_pid.Width = 59
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.GridColumn3.AppearanceHeader.Options.UseForeColor = True
        Me.GridColumn3.Caption = "Model"
        Me.GridColumn3.FieldName = "winmodel"
        Me.GridColumn3.MaxWidth = 200
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 1
        Me.GridColumn3.Width = 118
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.GridColumn4.AppearanceHeader.Options.UseForeColor = True
        Me.GridColumn4.Caption = "Description"
        Me.GridColumn4.FieldName = "description"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 2
        Me.GridColumn4.Width = 178
        '
        'col_price
        '
        Me.col_price.AppearanceCell.Options.UseTextOptions = True
        Me.col_price.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_price.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.col_price.AppearanceHeader.Options.UseForeColor = True
        Me.col_price.Caption = "SRP"
        Me.col_price.DisplayFormat.FormatString = "n2"
        Me.col_price.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_price.FieldName = "regular_price"
        Me.col_price.MaxWidth = 100
        Me.col_price.Name = "col_price"
        Me.col_price.Visible = True
        Me.col_price.VisibleIndex = 6
        Me.col_price.Width = 67
        '
        'GridColumn6
        '
        Me.GridColumn6.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn6.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.GridColumn6.AppearanceHeader.Options.UseForeColor = True
        Me.GridColumn6.Caption = "Status"
        Me.GridColumn6.FieldName = "status"
        Me.GridColumn6.MaxWidth = 100
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 9
        Me.GridColumn6.Width = 77
        '
        'col_dealer_price
        '
        Me.col_dealer_price.AppearanceCell.Options.UseTextOptions = True
        Me.col_dealer_price.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_dealer_price.Caption = "Dealer"
        Me.col_dealer_price.DisplayFormat.FormatString = "n2"
        Me.col_dealer_price.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_dealer_price.FieldName = "dealer_price"
        Me.col_dealer_price.Name = "col_dealer_price"
        Me.col_dealer_price.Visible = True
        Me.col_dealer_price.VisibleIndex = 7
        Me.col_dealer_price.Width = 63
        '
        'col_vip_price
        '
        Me.col_vip_price.AppearanceCell.Options.UseTextOptions = True
        Me.col_vip_price.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_vip_price.Caption = "VIP"
        Me.col_vip_price.DisplayFormat.FormatString = "n2"
        Me.col_vip_price.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_vip_price.FieldName = "vip_price"
        Me.col_vip_price.Name = "col_vip_price"
        Me.col_vip_price.Visible = True
        Me.col_vip_price.VisibleIndex = 8
        Me.col_vip_price.Width = 63
        '
        'col_main_category
        '
        Me.col_main_category.Caption = "Main Category"
        Me.col_main_category.FieldName = "main_category"
        Me.col_main_category.Name = "col_main_category"
        Me.col_main_category.Visible = True
        Me.col_main_category.VisibleIndex = 3
        Me.col_main_category.Width = 118
        '
        'col_sub_category
        '
        Me.col_sub_category.Caption = "Sub Category"
        Me.col_sub_category.FieldName = "sub_category"
        Me.col_sub_category.Name = "col_sub_category"
        Me.col_sub_category.Visible = True
        Me.col_sub_category.VisibleIndex = 4
        Me.col_sub_category.Width = 81
        '
        'col_brand
        '
        Me.col_brand.Caption = "Brand"
        Me.col_brand.FieldName = "brand"
        Me.col_brand.Name = "col_brand"
        Me.col_brand.Visible = True
        Me.col_brand.VisibleIndex = 5
        Me.col_brand.Width = 74
        '
        'col_my_qty
        '
        Me.col_my_qty.Caption = "MyStocks"
        Me.col_my_qty.FieldName = "qty"
        Me.col_my_qty.MaxWidth = 70
        Me.col_my_qty.MinWidth = 70
        Me.col_my_qty.Name = "col_my_qty"
        Me.col_my_qty.Visible = True
        Me.col_my_qty.VisibleIndex = 10
        Me.col_my_qty.Width = 70
        '
        'col_onhold_qty
        '
        Me.col_onhold_qty.Caption = "On-hold"
        Me.col_onhold_qty.FieldName = "onhold"
        Me.col_onhold_qty.MaxWidth = 70
        Me.col_onhold_qty.MinWidth = 70
        Me.col_onhold_qty.Name = "col_onhold_qty"
        Me.col_onhold_qty.Visible = True
        Me.col_onhold_qty.VisibleIndex = 11
        Me.col_onhold_qty.Width = 70
        '
        'col_other_qty
        '
        Me.col_other_qty.Caption = "Others"
        Me.col_other_qty.FieldName = "other_qty"
        Me.col_other_qty.MaxWidth = 70
        Me.col_other_qty.MinWidth = 70
        Me.col_other_qty.Name = "col_other_qty"
        Me.col_other_qty.Visible = True
        Me.col_other_qty.VisibleIndex = 12
        Me.col_other_qty.Width = 70
        '
        'btn_print
        '
        Me.btn_print.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_print.Appearance.Options.UseFont = True
        Me.btn_print.Appearance.Options.UseTextOptions = True
        Me.btn_print.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btn_print.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btn_print.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.print_32x32
        Me.btn_print.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_print.ImageOptions.ImageToTextIndent = 5
        Me.btn_print.Location = New System.Drawing.Point(20, 18)
        Me.btn_print.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_print.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(160, 46)
        Me.btn_print.TabIndex = 2
        Me.btn_print.Text = "Print"
        '
        'btn_details
        '
        Me.btn_details.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_details.Appearance.Options.UseFont = True
        Me.btn_details.Appearance.Options.UseTextOptions = True
        Me.btn_details.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btn_details.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btn_details.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.info_32x32
        Me.btn_details.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_details.ImageOptions.ImageToTextIndent = 5
        Me.btn_details.Location = New System.Drawing.Point(186, 18)
        Me.btn_details.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_details.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_details.Name = "btn_details"
        Me.btn_details.Size = New System.Drawing.Size(160, 46)
        Me.btn_details.TabIndex = 3
        Me.btn_details.Text = "Details"
        '
        'panel_side
        '
        Me.panel_side.AutoScroll = True
        Me.panel_side.BackColor = System.Drawing.Color.White
        Me.panel_side.Controls.Add(Me.panel_side_inner)
        Me.panel_side.Dock = System.Windows.Forms.DockStyle.Right
        Me.panel_side.LineBottom = 1
        Me.panel_side.LineColor = System.Drawing.Color.SkyBlue
        Me.panel_side.LineLeft = 1
        Me.panel_side.LineRight = 1
        Me.panel_side.LineStyle = System.Windows.Forms.BorderStyle.None
        Me.panel_side.LineTop = 1
        Me.panel_side.Location = New System.Drawing.Point(1082, 78)
        Me.panel_side.Name = "panel_side"
        Me.panel_side.Size = New System.Drawing.Size(367, 610)
        Me.panel_side.TabIndex = 2
        Me.panel_side.Visible = False
        '
        'panel_side_inner
        '
        Me.panel_side_inner.Controls.Add(Me.GunaLinePanel1)
        Me.panel_side_inner.Controls.Add(Me.GunaLinePanel2)
        Me.panel_side_inner.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_side_inner.Location = New System.Drawing.Point(0, 0)
        Me.panel_side_inner.Name = "panel_side_inner"
        Me.panel_side_inner.Size = New System.Drawing.Size(367, 610)
        Me.panel_side_inner.TabIndex = 1
        '
        'GunaLinePanel1
        '
        Me.GunaLinePanel1.BackColor = System.Drawing.Color.GhostWhite
        Me.GunaLinePanel1.Controls.Add(Me.lbl_view_more)
        Me.GunaLinePanel1.Controls.Add(Me.txt_warranty)
        Me.GunaLinePanel1.Controls.Add(Me.LabelControl22)
        Me.GunaLinePanel1.Controls.Add(Me.txt_brand)
        Me.GunaLinePanel1.Controls.Add(Me.txt_sub_category)
        Me.GunaLinePanel1.Controls.Add(Me.txt_main_category)
        Me.GunaLinePanel1.Controls.Add(Me.txt_status)
        Me.GunaLinePanel1.Controls.Add(Me.LabelControl21)
        Me.GunaLinePanel1.Controls.Add(Me.txt_hazards)
        Me.GunaLinePanel1.Controls.Add(Me.LabelControl20)
        Me.GunaLinePanel1.Controls.Add(Me.txt_tags)
        Me.GunaLinePanel1.Controls.Add(Me.LabelControl19)
        Me.GunaLinePanel1.Controls.Add(Me.LabelControl17)
        Me.GunaLinePanel1.Controls.Add(Me.btn_update)
        Me.GunaLinePanel1.Controls.Add(Me.GunaGroupBox2)
        Me.GunaLinePanel1.Controls.Add(Me.txt_retail_price)
        Me.GunaLinePanel1.Controls.Add(Me.LabelControl6)
        Me.GunaLinePanel1.Controls.Add(Me.LabelControl2)
        Me.GunaLinePanel1.Controls.Add(Me.txt_description)
        Me.GunaLinePanel1.Controls.Add(Me.txt_winmodel)
        Me.GunaLinePanel1.Controls.Add(Me.txt_barcode)
        Me.GunaLinePanel1.Controls.Add(Me.LabelControl10)
        Me.GunaLinePanel1.Controls.Add(Me.LabelControl8)
        Me.GunaLinePanel1.Controls.Add(Me.lbl_pid)
        Me.GunaLinePanel1.Controls.Add(Me.LabelControl4)
        Me.GunaLinePanel1.Controls.Add(Me.LabelControl3)
        Me.GunaLinePanel1.Controls.Add(Me.LabelControl5)
        Me.GunaLinePanel1.Controls.Add(Me.pb_product)
        Me.GunaLinePanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaLinePanel1.LineColor = System.Drawing.Color.Black
        Me.GunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaLinePanel1.Location = New System.Drawing.Point(0, 30)
        Me.GunaLinePanel1.Name = "GunaLinePanel1"
        Me.GunaLinePanel1.Size = New System.Drawing.Size(350, 786)
        Me.GunaLinePanel1.TabIndex = 1
        '
        'lbl_view_more
        '
        Me.lbl_view_more.AutoSize = True
        Me.lbl_view_more.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lbl_view_more.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lbl_view_more.LinkColor = System.Drawing.Color.Purple
        Me.lbl_view_more.Location = New System.Drawing.Point(118, 300)
        Me.lbl_view_more.Name = "lbl_view_more"
        Me.lbl_view_more.Size = New System.Drawing.Size(60, 14)
        Me.lbl_view_more.TabIndex = 76
        Me.lbl_view_more.TabStop = True
        Me.lbl_view_more.Text = "View More"
        '
        'txt_warranty
        '
        Me.txt_warranty.EditValue = ""
        Me.txt_warranty.Location = New System.Drawing.Point(121, 483)
        Me.txt_warranty.Name = "txt_warranty"
        Me.txt_warranty.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.txt_warranty.Properties.Appearance.Options.UseFont = True
        Me.txt_warranty.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txt_warranty.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txt_warranty.Properties.ReadOnly = True
        Me.txt_warranty.Size = New System.Drawing.Size(192, 72)
        Me.txt_warranty.TabIndex = 75
        '
        'LabelControl22
        '
        Me.LabelControl22.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl22.Appearance.Options.UseFont = True
        Me.LabelControl22.Location = New System.Drawing.Point(10, 484)
        Me.LabelControl22.Name = "LabelControl22"
        Me.LabelControl22.Size = New System.Drawing.Size(57, 16)
        Me.LabelControl22.TabIndex = 74
        Me.LabelControl22.Text = "Warranty:"
        '
        'txt_brand
        '
        Me.txt_brand.EditValue = ""
        Me.txt_brand.Location = New System.Drawing.Point(121, 382)
        Me.txt_brand.Name = "txt_brand"
        Me.txt_brand.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.txt_brand.Properties.Appearance.Options.UseFont = True
        Me.txt_brand.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txt_brand.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txt_brand.Properties.ReadOnly = True
        Me.txt_brand.Size = New System.Drawing.Size(122, 22)
        Me.txt_brand.TabIndex = 73
        '
        'txt_sub_category
        '
        Me.txt_sub_category.EditValue = ""
        Me.txt_sub_category.Location = New System.Drawing.Point(121, 352)
        Me.txt_sub_category.Name = "txt_sub_category"
        Me.txt_sub_category.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.txt_sub_category.Properties.Appearance.Options.UseFont = True
        Me.txt_sub_category.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txt_sub_category.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txt_sub_category.Properties.ReadOnly = True
        Me.txt_sub_category.Size = New System.Drawing.Size(122, 22)
        Me.txt_sub_category.TabIndex = 72
        '
        'txt_main_category
        '
        Me.txt_main_category.EditValue = ""
        Me.txt_main_category.Location = New System.Drawing.Point(121, 322)
        Me.txt_main_category.Name = "txt_main_category"
        Me.txt_main_category.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.txt_main_category.Properties.Appearance.Options.UseFont = True
        Me.txt_main_category.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txt_main_category.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txt_main_category.Properties.ReadOnly = True
        Me.txt_main_category.Size = New System.Drawing.Size(122, 22)
        Me.txt_main_category.TabIndex = 71
        '
        'txt_status
        '
        Me.txt_status.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_status.Appearance.Options.UseFont = True
        Me.txt_status.Appearance.Options.UseTextOptions = True
        Me.txt_status.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_status.Location = New System.Drawing.Point(108, 17)
        Me.txt_status.Name = "txt_status"
        Me.txt_status.Size = New System.Drawing.Size(37, 16)
        Me.txt_status.TabIndex = 70
        Me.txt_status.Text = "Active"
        '
        'LabelControl21
        '
        Me.LabelControl21.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl21.Appearance.Options.UseFont = True
        Me.LabelControl21.Location = New System.Drawing.Point(14, 17)
        Me.LabelControl21.Name = "LabelControl21"
        Me.LabelControl21.Size = New System.Drawing.Size(66, 16)
        Me.LabelControl21.TabIndex = 69
        Me.LabelControl21.Text = "Unit Status:"
        '
        'txt_hazards
        '
        Me.txt_hazards.EditValue = ""
        Me.txt_hazards.Location = New System.Drawing.Point(121, 438)
        Me.txt_hazards.Name = "txt_hazards"
        Me.txt_hazards.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.txt_hazards.Properties.Appearance.Options.UseFont = True
        Me.txt_hazards.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txt_hazards.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txt_hazards.Properties.ReadOnly = True
        Me.txt_hazards.Size = New System.Drawing.Size(192, 22)
        Me.txt_hazards.TabIndex = 67
        '
        'LabelControl20
        '
        Me.LabelControl20.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl20.Appearance.Options.UseFont = True
        Me.LabelControl20.Location = New System.Drawing.Point(13, 441)
        Me.LabelControl20.Name = "LabelControl20"
        Me.LabelControl20.Size = New System.Drawing.Size(54, 16)
        Me.LabelControl20.TabIndex = 66
        Me.LabelControl20.Text = "Hazards:"
        '
        'txt_tags
        '
        Me.txt_tags.EditValue = ""
        Me.txt_tags.Location = New System.Drawing.Point(121, 410)
        Me.txt_tags.Name = "txt_tags"
        Me.txt_tags.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.txt_tags.Properties.Appearance.Options.UseFont = True
        Me.txt_tags.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txt_tags.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txt_tags.Properties.ReadOnly = True
        Me.txt_tags.Size = New System.Drawing.Size(122, 22)
        Me.txt_tags.TabIndex = 65
        '
        'LabelControl19
        '
        Me.LabelControl19.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl19.Appearance.Options.UseFont = True
        Me.LabelControl19.Location = New System.Drawing.Point(13, 413)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(35, 16)
        Me.LabelControl19.TabIndex = 64
        Me.LabelControl19.Text = "Tags:"
        '
        'LabelControl17
        '
        Me.LabelControl17.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl17.Appearance.Options.UseFont = True
        Me.LabelControl17.Location = New System.Drawing.Point(13, 385)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(39, 16)
        Me.LabelControl17.TabIndex = 62
        Me.LabelControl17.Text = "Brand:"
        '
        'btn_update
        '
        Me.btn_update.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.btn_update.Appearance.Options.UseFont = True
        Me.btn_update.Location = New System.Drawing.Point(206, 732)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(129, 32)
        Me.btn_update.TabIndex = 61
        Me.btn_update.Text = "Update Information"
        Me.btn_update.Visible = False
        '
        'GunaGroupBox2
        '
        Me.GunaGroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox2.BaseColor = System.Drawing.Color.Empty
        Me.GunaGroupBox2.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.GunaGroupBox2.BorderSize = 1
        Me.GunaGroupBox2.Controls.Add(Me.txt_weight)
        Me.GunaGroupBox2.Controls.Add(Me.LabelControl16)
        Me.GunaGroupBox2.Controls.Add(Me.txt_height)
        Me.GunaGroupBox2.Controls.Add(Me.txt_width)
        Me.GunaGroupBox2.Controls.Add(Me.txt_length)
        Me.GunaGroupBox2.Controls.Add(Me.LabelControl11)
        Me.GunaGroupBox2.Controls.Add(Me.LabelControl12)
        Me.GunaGroupBox2.Controls.Add(Me.LabelControl13)
        Me.GunaGroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaGroupBox2.LineColor = System.Drawing.SystemColors.ActiveCaption
        Me.GunaGroupBox2.Location = New System.Drawing.Point(14, 572)
        Me.GunaGroupBox2.Name = "GunaGroupBox2"
        Me.GunaGroupBox2.Size = New System.Drawing.Size(321, 148)
        Me.GunaGroupBox2.TabIndex = 60
        Me.GunaGroupBox2.Text = "Dimension"
        Me.GunaGroupBox2.TextLocation = New System.Drawing.Point(10, 8)
        '
        'txt_weight
        '
        Me.txt_weight.EditValue = ""
        Me.txt_weight.Location = New System.Drawing.Point(245, 50)
        Me.txt_weight.Name = "txt_weight"
        Me.txt_weight.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.txt_weight.Properties.Appearance.Options.UseFont = True
        Me.txt_weight.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txt_weight.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txt_weight.Properties.ReadOnly = True
        Me.txt_weight.Size = New System.Drawing.Size(48, 22)
        Me.txt_weight.TabIndex = 45
        '
        'LabelControl16
        '
        Me.LabelControl16.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl16.Appearance.Options.UseFont = True
        Me.LabelControl16.Location = New System.Drawing.Point(167, 51)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(71, 16)
        Me.LabelControl16.TabIndex = 44
        Me.LabelControl16.Text = "Weight (kg):"
        '
        'txt_height
        '
        Me.txt_height.EditValue = ""
        Me.txt_height.Location = New System.Drawing.Point(93, 104)
        Me.txt_height.Name = "txt_height"
        Me.txt_height.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.txt_height.Properties.Appearance.Options.UseFont = True
        Me.txt_height.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txt_height.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txt_height.Properties.ReadOnly = True
        Me.txt_height.Size = New System.Drawing.Size(48, 22)
        Me.txt_height.TabIndex = 43
        '
        'txt_width
        '
        Me.txt_width.EditValue = ""
        Me.txt_width.Location = New System.Drawing.Point(93, 76)
        Me.txt_width.Name = "txt_width"
        Me.txt_width.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.txt_width.Properties.Appearance.Options.UseFont = True
        Me.txt_width.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txt_width.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txt_width.Properties.ReadOnly = True
        Me.txt_width.Size = New System.Drawing.Size(48, 22)
        Me.txt_width.TabIndex = 42
        '
        'txt_length
        '
        Me.txt_length.EditValue = ""
        Me.txt_length.Location = New System.Drawing.Point(93, 48)
        Me.txt_length.Name = "txt_length"
        Me.txt_length.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.txt_length.Properties.Appearance.Options.UseFont = True
        Me.txt_length.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txt_length.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txt_length.Properties.ReadOnly = True
        Me.txt_length.Size = New System.Drawing.Size(48, 22)
        Me.txt_length.TabIndex = 41
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl11.Appearance.Options.UseFont = True
        Me.LabelControl11.Location = New System.Drawing.Point(13, 52)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(72, 16)
        Me.LabelControl11.TabIndex = 26
        Me.LabelControl11.Text = "Length (cm):"
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl12.Appearance.Options.UseFont = True
        Me.LabelControl12.Location = New System.Drawing.Point(13, 78)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(66, 16)
        Me.LabelControl12.TabIndex = 27
        Me.LabelControl12.Text = "Width (cm):"
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl13.Appearance.Options.UseFont = True
        Me.LabelControl13.Location = New System.Drawing.Point(13, 106)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(71, 16)
        Me.LabelControl13.TabIndex = 28
        Me.LabelControl13.Text = "Height (cm):"
        '
        'txt_retail_price
        '
        Me.txt_retail_price.EditValue = ""
        Me.txt_retail_price.Location = New System.Drawing.Point(121, 193)
        Me.txt_retail_price.Name = "txt_retail_price"
        Me.txt_retail_price.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.txt_retail_price.Properties.Appearance.Options.UseFont = True
        Me.txt_retail_price.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_retail_price.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_retail_price.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txt_retail_price.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txt_retail_price.Properties.ReadOnly = True
        Me.txt_retail_price.Size = New System.Drawing.Size(122, 22)
        Me.txt_retail_price.TabIndex = 58
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(11, 196)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(31, 16)
        Me.LabelControl6.TabIndex = 57
        Me.LabelControl6.Text = "SRP:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(13, 355)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(85, 16)
        Me.LabelControl2.TabIndex = 55
        Me.LabelControl2.Text = "Sub Category:"
        '
        'txt_description
        '
        Me.txt_description.EditValue = ""
        Me.txt_description.Location = New System.Drawing.Point(121, 225)
        Me.txt_description.Name = "txt_description"
        Me.txt_description.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.txt_description.Properties.Appearance.Options.UseFont = True
        Me.txt_description.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txt_description.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txt_description.Properties.ReadOnly = True
        Me.txt_description.Size = New System.Drawing.Size(192, 72)
        Me.txt_description.TabIndex = 53
        '
        'txt_winmodel
        '
        Me.txt_winmodel.EditValue = ""
        Me.txt_winmodel.Location = New System.Drawing.Point(121, 164)
        Me.txt_winmodel.Name = "txt_winmodel"
        Me.txt_winmodel.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.txt_winmodel.Properties.Appearance.Options.UseFont = True
        Me.txt_winmodel.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txt_winmodel.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txt_winmodel.Properties.ReadOnly = True
        Me.txt_winmodel.Size = New System.Drawing.Size(122, 22)
        Me.txt_winmodel.TabIndex = 52
        '
        'txt_barcode
        '
        Me.txt_barcode.EditValue = ""
        Me.txt_barcode.Location = New System.Drawing.Point(82, 85)
        Me.txt_barcode.Name = "txt_barcode"
        Me.txt_barcode.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.txt_barcode.Properties.Appearance.Options.UseFont = True
        Me.txt_barcode.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txt_barcode.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txt_barcode.Properties.ReadOnly = True
        Me.txt_barcode.Size = New System.Drawing.Size(110, 22)
        Me.txt_barcode.TabIndex = 51
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.Appearance.Options.UseFont = True
        Me.LabelControl10.Location = New System.Drawing.Point(13, 220)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(71, 16)
        Me.LabelControl10.TabIndex = 50
        Me.LabelControl10.Text = "Description:"
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Location = New System.Drawing.Point(13, 88)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(55, 16)
        Me.LabelControl8.TabIndex = 49
        Me.LabelControl8.Text = "Barcode:"
        '
        'lbl_pid
        '
        Me.lbl_pid.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pid.Appearance.Options.UseFont = True
        Me.lbl_pid.Location = New System.Drawing.Point(108, 50)
        Me.lbl_pid.Name = "lbl_pid"
        Me.lbl_pid.Size = New System.Drawing.Size(42, 16)
        Me.lbl_pid.TabIndex = 48
        Me.lbl_pid.Text = "000000"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(13, 50)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(79, 16)
        Me.LabelControl4.TabIndex = 47
        Me.LabelControl4.Text = "Product SKU:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(13, 325)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(90, 16)
        Me.LabelControl3.TabIndex = 46
        Me.LabelControl3.Text = "Main Category:"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(10, 167)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(93, 16)
        Me.LabelControl5.TabIndex = 45
        Me.LabelControl5.Text = "Winland Model:"
        '
        'pb_product
        '
        Me.pb_product.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pb_product.Location = New System.Drawing.Point(205, 17)
        Me.pb_product.Name = "pb_product"
        Me.pb_product.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.pb_product.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.pb_product.Size = New System.Drawing.Size(135, 135)
        Me.pb_product.TabIndex = 44
        '
        'GunaLinePanel2
        '
        Me.GunaLinePanel2.BackColor = System.Drawing.Color.SkyBlue
        Me.GunaLinePanel2.Controls.Add(Me.Label1)
        Me.GunaLinePanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaLinePanel2.ForeColor = System.Drawing.Color.White
        Me.GunaLinePanel2.LineColor = System.Drawing.Color.Black
        Me.GunaLinePanel2.LineStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaLinePanel2.Location = New System.Drawing.Point(0, 0)
        Me.GunaLinePanel2.Name = "GunaLinePanel2"
        Me.GunaLinePanel2.Size = New System.Drawing.Size(350, 30)
        Me.GunaLinePanel2.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(141, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Item Details"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.GunaLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.GunaLabel1.Location = New System.Drawing.Point(14, 10)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(138, 31)
        Me.GunaLabel1.TabIndex = 1
        Me.GunaLabel1.Text = "Catalogue"
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
        Me.panel_top.Size = New System.Drawing.Size(1449, 78)
        Me.panel_top.TabIndex = 6
        '
        'GunaPanel5
        '
        Me.GunaPanel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaPanel5.BackColor = System.Drawing.Color.Transparent
        Me.GunaPanel5.Controls.Add(Me.GunaPanel2)
        Me.GunaPanel5.Location = New System.Drawing.Point(19, 44)
        Me.GunaPanel5.Name = "GunaPanel5"
        Me.GunaPanel5.Size = New System.Drawing.Size(1269, 27)
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
        Me.link_po_list.Text = "Catalogue"
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
        'XtraTabPage1
        '
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(298, 284)
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(298, 271)
        '
        'bgw_load_catalogue
        '
        '
        'frm_product_catalogue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1449, 688)
        Me.Controls.Add(Me.panel_content)
        Me.Controls.Add(Me.panel_side)
        Me.Controls.Add(Me.panel_top)
        Me.Name = "frm_product_catalogue"
        Me.Text = "frm_inventory"
        Me.panel_content.ResumeLayout(False)
        Me.panel_content.PerformLayout()
        CType(Me.sw_view_stocks.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_catalogue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_catalogue_view, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_side.ResumeLayout(False)
        Me.panel_side_inner.ResumeLayout(False)
        Me.GunaLinePanel1.ResumeLayout(False)
        Me.GunaLinePanel1.PerformLayout()
        CType(Me.txt_warranty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_brand.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sub_category.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_main_category.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_hazards.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_tags.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaGroupBox2.ResumeLayout(False)
        Me.GunaGroupBox2.PerformLayout()
        CType(Me.txt_weight.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_height.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_width.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_length.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_retail_price.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_description.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_winmodel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_barcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_product.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaLinePanel2.ResumeLayout(False)
        Me.GunaLinePanel2.PerformLayout()
        Me.panel_top.ResumeLayout(False)
        Me.panel_top.PerformLayout()
        Me.GunaPanel5.ResumeLayout(False)
        Me.GunaPanel2.ResumeLayout(False)
        Me.GunaPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panel_content As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents panel_side As Guna.UI.WinForms.GunaLinePanel
    Friend WithEvents panel_top As Guna.UI.WinForms.GunaLinePanel
    Friend WithEvents GunaPanel5 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPanel2 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents link_po_list As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents link_home As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents panel_side_inner As DevExpress.XtraEditors.XtraScrollableControl
    Friend WithEvents GunaLinePanel1 As Guna.UI.WinForms.GunaLinePanel
    Friend WithEvents txt_hazards As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_tags As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_update As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GunaGroupBox2 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents txt_weight As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_height As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_width As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_length As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_retail_price As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_description As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txt_winmodel As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_barcode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_pid As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents pb_product As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents txt_status As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_main_category As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_brand As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_sub_category As DevExpress.XtraEditors.TextEdit
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents btn_print As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GunaLinePanel2 As Guna.UI.WinForms.GunaLinePanel
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_details As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_warranty As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl22 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grid_catalogue As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_catalogue_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_price As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bgw_load_catalogue As System.ComponentModel.BackgroundWorker
    Friend WithEvents SplashScreenManager1 As DevExpress.XtraSplashScreen.SplashScreenManager
    Friend WithEvents col_main_category As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_sub_category As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_brand As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_dealer_price As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_vip_price As DevExpress.XtraGrid.Columns.GridColumn
    'MY EDIT
    Friend WithEvents col_pid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sw_view_stocks As DevExpress.XtraEditors.ToggleSwitch
    Friend WithEvents col_my_qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_onhold_qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_other_qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lbl_view_more As LinkLabel

End Class
