﻿Imports DevExpress.LookAndFeel
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Container
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Repository
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports Guna.UI.WinForms
Imports Inventory_Management.My
Imports Inventory_Management.My.Resources
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports MySql.Data.MySqlClient
Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Common
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_sales_orders
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
        Me.GunaPanel2 = New Guna.UI.WinForms.GunaPanel()
        Me.btn_sort_cancelled = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_sort_completed = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_sort_all = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_sort_onprocess = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_refresh = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_customer = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_order = New DevExpress.XtraEditors.SimpleButton()
        Me.grid_orders = New DevExpress.XtraGrid.GridControl()
        Me.grid_orders_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_view = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btn_view_order = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.col_order_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_date_ordered = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_date_packed = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_date_released = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_released_by = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_packed_by = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.timer = New System.Windows.Forms.Timer(Me.components)
        Me.panel_top.SuspendLayout()
        Me.GunaPanel5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbb_timer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaPanel1.SuspendLayout()
        Me.GunaPanel2.SuspendLayout()
        CType(Me.grid_orders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_orders_view, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.panel_top.Size = New System.Drawing.Size(1466, 78)
        Me.panel_top.TabIndex = 11
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
        Me.GunaPanel5.Size = New System.Drawing.Size(1444, 27)
        Me.GunaPanel5.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureEdit1)
        Me.Panel1.Controls.Add(Me.cbb_timer)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(1332, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(112, 27)
        Me.Panel1.TabIndex = 7
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
        Me.link_po_list.Size = New System.Drawing.Size(77, 18)
        Me.link_po_list.TabIndex = 7
        Me.link_po_list.Text = "Sales Orders"
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
        Me.lbl_title.Size = New System.Drawing.Size(172, 31)
        Me.lbl_title.TabIndex = 1
        Me.lbl_title.Text = "Sales Orders"
        '
        'GunaPanel2
        '
        Me.GunaPanel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaPanel2.Controls.Add(Me.btn_sort_cancelled)
        Me.GunaPanel2.Controls.Add(Me.btn_sort_completed)
        Me.GunaPanel2.Controls.Add(Me.btn_sort_all)
        Me.GunaPanel2.Controls.Add(Me.btn_sort_onprocess)
        Me.GunaPanel2.Controls.Add(Me.btn_refresh)
        Me.GunaPanel2.Controls.Add(Me.btn_customer)
        Me.GunaPanel2.Controls.Add(Me.btn_order)
        Me.GunaPanel2.Controls.Add(Me.grid_orders)
        Me.GunaPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GunaPanel2.Location = New System.Drawing.Point(0, 78)
        Me.GunaPanel2.Name = "GunaPanel2"
        Me.GunaPanel2.Size = New System.Drawing.Size(1466, 638)
        Me.GunaPanel2.TabIndex = 12
        '
        'btn_sort_cancelled
        '
        Me.btn_sort_cancelled.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_sort_cancelled.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_sort_cancelled.Appearance.Options.UseFont = True
        Me.btn_sort_cancelled.Appearance.Options.UseTextOptions = True
        Me.btn_sort_cancelled.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btn_sort_cancelled.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btn_sort_cancelled.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_sort_cancelled.ImageOptions.ImageToTextIndent = 5
        Me.btn_sort_cancelled.Location = New System.Drawing.Point(1131, 20)
        Me.btn_sort_cancelled.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_sort_cancelled.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_sort_cancelled.Name = "btn_sort_cancelled"
        Me.btn_sort_cancelled.Size = New System.Drawing.Size(102, 46)
        Me.btn_sort_cancelled.TabIndex = 18
        Me.btn_sort_cancelled.Text = "CANCELLED"
        '
        'btn_sort_completed
        '
        Me.btn_sort_completed.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_sort_completed.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_sort_completed.Appearance.Options.UseFont = True
        Me.btn_sort_completed.Appearance.Options.UseTextOptions = True
        Me.btn_sort_completed.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btn_sort_completed.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btn_sort_completed.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_sort_completed.ImageOptions.ImageToTextIndent = 5
        Me.btn_sort_completed.Location = New System.Drawing.Point(1239, 20)
        Me.btn_sort_completed.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_sort_completed.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_sort_completed.Name = "btn_sort_completed"
        Me.btn_sort_completed.Size = New System.Drawing.Size(102, 46)
        Me.btn_sort_completed.TabIndex = 17
        Me.btn_sort_completed.Text = "COMPLETED"
        '
        'btn_sort_all
        '
        Me.btn_sort_all.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_sort_all.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_sort_all.Appearance.Options.UseFont = True
        Me.btn_sort_all.Appearance.Options.UseTextOptions = True
        Me.btn_sort_all.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btn_sort_all.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btn_sort_all.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_sort_all.ImageOptions.ImageToTextIndent = 5
        Me.btn_sort_all.Location = New System.Drawing.Point(1347, 20)
        Me.btn_sort_all.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_sort_all.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_sort_all.Name = "btn_sort_all"
        Me.btn_sort_all.Size = New System.Drawing.Size(102, 46)
        Me.btn_sort_all.TabIndex = 15
        Me.btn_sort_all.Text = "ALL"
        '
        'btn_sort_onprocess
        '
        Me.btn_sort_onprocess.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_sort_onprocess.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary
        Me.btn_sort_onprocess.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_sort_onprocess.Appearance.Options.UseBackColor = True
        Me.btn_sort_onprocess.Appearance.Options.UseFont = True
        Me.btn_sort_onprocess.Appearance.Options.UseTextOptions = True
        Me.btn_sort_onprocess.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btn_sort_onprocess.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btn_sort_onprocess.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_sort_onprocess.ImageOptions.ImageToTextIndent = 5
        Me.btn_sort_onprocess.Location = New System.Drawing.Point(1023, 20)
        Me.btn_sort_onprocess.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_sort_onprocess.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_sort_onprocess.Name = "btn_sort_onprocess"
        Me.btn_sort_onprocess.Size = New System.Drawing.Size(102, 46)
        Me.btn_sort_onprocess.TabIndex = 16
        Me.btn_sort_onprocess.Text = "ON-PROCESS"
        '
        'btn_refresh
        '
        Me.btn_refresh.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_refresh.Appearance.Options.UseFont = True
        Me.btn_refresh.Appearance.Options.UseTextOptions = True
        Me.btn_refresh.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btn_refresh.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btn_refresh.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.refresh_32x32
        Me.btn_refresh.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_refresh.ImageOptions.ImageToTextIndent = 5
        Me.btn_refresh.Location = New System.Drawing.Point(352, 15)
        Me.btn_refresh.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_refresh.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(160, 46)
        Me.btn_refresh.TabIndex = 13
        Me.btn_refresh.Text = "Refresh"
        '
        'btn_customer
        '
        Me.btn_customer.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_customer.Appearance.Options.UseFont = True
        Me.btn_customer.Appearance.Options.UseTextOptions = True
        Me.btn_customer.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btn_customer.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btn_customer.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.employee_32x32
        Me.btn_customer.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_customer.ImageOptions.ImageToTextIndent = 5
        Me.btn_customer.Location = New System.Drawing.Point(186, 15)
        Me.btn_customer.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_customer.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_customer.Name = "btn_customer"
        Me.btn_customer.Size = New System.Drawing.Size(160, 46)
        Me.btn_customer.TabIndex = 12
        Me.btn_customer.Text = "New Customer"
        '
        'btn_order
        '
        Me.btn_order.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_order.Appearance.Options.UseFont = True
        Me.btn_order.Appearance.Options.UseTextOptions = True
        Me.btn_order.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btn_order.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btn_order.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.newsales_32x32
        Me.btn_order.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_order.ImageOptions.ImageToTextIndent = 5
        Me.btn_order.Location = New System.Drawing.Point(20, 15)
        Me.btn_order.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_order.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_order.Name = "btn_order"
        Me.btn_order.Size = New System.Drawing.Size(160, 46)
        Me.btn_order.TabIndex = 10
        Me.btn_order.Text = "New Order"
        '
        'grid_orders
        '
        Me.grid_orders.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_orders.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_orders.Location = New System.Drawing.Point(20, 72)
        Me.grid_orders.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grid_orders.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grid_orders.MainView = Me.grid_orders_view
        Me.grid_orders.Name = "grid_orders"
        Me.grid_orders.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.btn_view_order})
        Me.grid_orders.Size = New System.Drawing.Size(1429, 554)
        Me.grid_orders.TabIndex = 8
        Me.grid_orders.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_orders_view})
        '
        'grid_orders_view
        '
        Me.grid_orders_view.Appearance.HeaderPanel.BackColor = System.Drawing.Color.White
        Me.grid_orders_view.Appearance.HeaderPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.grid_orders_view.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grid_orders_view.Appearance.HeaderPanel.Options.UseFont = True
        Me.grid_orders_view.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.grid_orders_view.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grid_orders_view.Appearance.Row.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_orders_view.Appearance.Row.Options.UseFont = True
        Me.grid_orders_view.Appearance.SelectedRow.BackColor = System.Drawing.Color.White
        Me.grid_orders_view.Appearance.SelectedRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.grid_orders_view.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grid_orders_view.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grid_orders_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_view, Me.col_order_id, Me.GridColumn2, Me.GridColumn3, Me.GridColumn7, Me.GridColumn9, Me.GridColumn10, Me.GridColumn5, Me.col_date_ordered, Me.col_date_packed, Me.col_date_released, Me.col_released_by, Me.col_packed_by})
        Me.grid_orders_view.GridControl = Me.grid_orders
        Me.grid_orders_view.Name = "grid_orders_view"
        Me.grid_orders_view.OptionsBehavior.ReadOnly = True
        Me.grid_orders_view.OptionsSelection.ResetSelectionClickOutsideCheckboxSelector = True
        Me.grid_orders_view.OptionsView.ShowFooter = True
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
        EditorButtonImageOptions1.Image = Global.Inventory_Management.My.Resources.Resources.snapmodifytablecellstyle_16x16
        Me.btn_view_order.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.btn_view_order.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_view_order.Name = "btn_view_order"
        Me.btn_view_order.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'col_order_id
        '
        Me.col_order_id.AppearanceCell.Options.UseTextOptions = True
        Me.col_order_id.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_order_id.AppearanceHeader.Options.UseTextOptions = True
        Me.col_order_id.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_order_id.Caption = "Order ID"
        Me.col_order_id.FieldName = "order_id"
        Me.col_order_id.MaxWidth = 70
        Me.col_order_id.MinWidth = 70
        Me.col_order_id.Name = "col_order_id"
        Me.col_order_id.Visible = True
        Me.col_order_id.VisibleIndex = 1
        Me.col_order_id.Width = 70
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.Caption = "Customer"
        Me.GridColumn2.FieldName = "first_name"
        Me.GridColumn2.MinWidth = 150
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 2
        Me.GridColumn2.Width = 151
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.Caption = "Sales Coordinator"
        Me.GridColumn3.FieldName = "agent"
        Me.GridColumn3.MaxWidth = 130
        Me.GridColumn3.MinWidth = 130
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 3
        Me.GridColumn3.Width = 130
        '
        'GridColumn7
        '
        Me.GridColumn7.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn7.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn7.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn7.Caption = "Payment Type"
        Me.GridColumn7.FieldName = "payment_type"
        Me.GridColumn7.MaxWidth = 100
        Me.GridColumn7.MinWidth = 100
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 5
        Me.GridColumn7.Width = 100
        '
        'GridColumn9
        '
        Me.GridColumn9.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn9.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn9.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn9.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn9.Caption = "Shipping"
        Me.GridColumn9.FieldName = "shipping_method"
        Me.GridColumn9.MaxWidth = 100
        Me.GridColumn9.MinWidth = 100
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 4
        Me.GridColumn9.Width = 100
        '
        'GridColumn10
        '
        Me.GridColumn10.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn10.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn10.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn10.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn10.Caption = "Payment Status"
        Me.GridColumn10.FieldName = "payment_status"
        Me.GridColumn10.MaxWidth = 120
        Me.GridColumn10.MinWidth = 120
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 6
        Me.GridColumn10.Width = 120
        '
        'GridColumn5
        '
        Me.GridColumn5.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn5.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn5.Caption = "Package Status"
        Me.GridColumn5.FieldName = "status"
        Me.GridColumn5.MaxWidth = 150
        Me.GridColumn5.MinWidth = 100
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 7
        Me.GridColumn5.Width = 150
        '
        'col_date_ordered
        '
        Me.col_date_ordered.AppearanceCell.Options.UseTextOptions = True
        Me.col_date_ordered.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_date_ordered.AppearanceHeader.Options.UseTextOptions = True
        Me.col_date_ordered.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_date_ordered.Caption = "Date Ordered"
        Me.col_date_ordered.DisplayFormat.FormatString = "MM/dd, hh:mm tt"
        Me.col_date_ordered.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col_date_ordered.FieldName = "date_ordered"
        Me.col_date_ordered.MaxWidth = 100
        Me.col_date_ordered.MinWidth = 100
        Me.col_date_ordered.Name = "col_date_ordered"
        Me.col_date_ordered.OptionsColumn.AllowEdit = False
        Me.col_date_ordered.Visible = True
        Me.col_date_ordered.VisibleIndex = 8
        Me.col_date_ordered.Width = 100
        '
        'col_date_packed
        '
        Me.col_date_packed.AppearanceCell.Options.UseTextOptions = True
        Me.col_date_packed.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_date_packed.AppearanceHeader.Options.UseTextOptions = True
        Me.col_date_packed.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_date_packed.Caption = "Date Packed"
        Me.col_date_packed.DisplayFormat.FormatString = "MM/dd, hh:mm tt"
        Me.col_date_packed.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col_date_packed.FieldName = "date_packed"
        Me.col_date_packed.MaxWidth = 100
        Me.col_date_packed.MinWidth = 100
        Me.col_date_packed.Name = "col_date_packed"
        Me.col_date_packed.OptionsColumn.AllowEdit = False
        Me.col_date_packed.Visible = True
        Me.col_date_packed.VisibleIndex = 9
        Me.col_date_packed.Width = 100
        '
        'col_date_released
        '
        Me.col_date_released.AppearanceCell.Options.UseTextOptions = True
        Me.col_date_released.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_date_released.AppearanceHeader.Options.UseTextOptions = True
        Me.col_date_released.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_date_released.Caption = "Date Released"
        Me.col_date_released.DisplayFormat.FormatString = "MM/dd, hh:mm tt"
        Me.col_date_released.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col_date_released.FieldName = "date_released"
        Me.col_date_released.MaxWidth = 100
        Me.col_date_released.MinWidth = 100
        Me.col_date_released.Name = "col_date_released"
        Me.col_date_released.OptionsColumn.AllowEdit = False
        Me.col_date_released.Visible = True
        Me.col_date_released.VisibleIndex = 10
        Me.col_date_released.Width = 100
        '
        'col_released_by
        '
        Me.col_released_by.Caption = "Released By"
        Me.col_released_by.FieldName = "released_by"
        Me.col_released_by.MaxWidth = 130
        Me.col_released_by.MinWidth = 130
        Me.col_released_by.Name = "col_released_by"
        Me.col_released_by.Visible = True
        Me.col_released_by.VisibleIndex = 12
        Me.col_released_by.Width = 130
        '
        'col_packed_by
        '
        Me.col_packed_by.Caption = "Packed By"
        Me.col_packed_by.FieldName = "packed_by"
        Me.col_packed_by.MaxWidth = 130
        Me.col_packed_by.MinWidth = 130
        Me.col_packed_by.Name = "col_packed_by"
        Me.col_packed_by.Visible = True
        Me.col_packed_by.VisibleIndex = 11
        Me.col_packed_by.Width = 130
        '
        'timer
        '
        '
        'frm_sales_orders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1466, 716)
        Me.Controls.Add(Me.GunaPanel2)
        Me.Controls.Add(Me.panel_top)
        Me.KeyPreview = True
        Me.Name = "frm_sales_orders"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_sales_orders"
        Me.panel_top.ResumeLayout(False)
        Me.panel_top.PerformLayout()
        Me.GunaPanel5.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbb_timer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaPanel1.ResumeLayout(False)
        Me.GunaPanel1.PerformLayout()
        Me.GunaPanel2.ResumeLayout(False)
        CType(Me.grid_orders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_orders_view, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents GunaPanel2 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents grid_orders As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_orders_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_order_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cbb_timer As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents timer As Timer
    Friend WithEvents col_date_packed As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_order As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_customer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_refresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents col_date_ordered As GridColumn
    Friend WithEvents col_date_released As GridColumn
    Friend WithEvents col_view As GridColumn
    Friend WithEvents btn_view_order As RepositoryItemButtonEdit
    Friend WithEvents btn_sort_completed As SimpleButton
    Friend WithEvents btn_sort_onprocess As SimpleButton
    Friend WithEvents btn_sort_all As SimpleButton
    Friend WithEvents btn_sort_cancelled As SimpleButton
    Friend WithEvents col_released_by As GridColumn
    Friend WithEvents col_packed_by As GridColumn
End Class
