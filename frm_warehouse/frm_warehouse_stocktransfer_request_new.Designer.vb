﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_warehouse_stocktransfer_request_new
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_warehouse_stocktransfer_request_new))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.lbl_created_by = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_status = New DevExpress.XtraEditors.TextEdit()
        Me.btn_save = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_stid = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_delete = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_create = New DevExpress.XtraEditors.SimpleButton()
        Me.cbb_src_warehouse = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.grid_request_stock = New System.Windows.Forms.DataGridView()
        Me.pid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.winmodel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_masterbox = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_innerBox = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_cbm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_kgs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_print = New DevExpress.XtraEditors.SimpleButton()
        Me.lbl_total_kgs = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_total_cbm = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_arrange = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_note = New System.Windows.Forms.TextBox()
        Me.btn_approved = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel1.SuspendLayout()
        CType(Me.lbl_status.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_stid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbb_src_warehouse.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_request_stock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.GhostWhite
        Me.Panel1.Controls.Add(Me.lbl_title)
        Me.Panel1.Controls.Add(Me.lbl_created_by)
        Me.Panel1.Controls.Add(Me.lbl_status)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1193, 75)
        Me.Panel1.TabIndex = 71
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lbl_title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.lbl_title.Location = New System.Drawing.Point(12, 25)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(379, 31)
        Me.lbl_title.TabIndex = 82
        Me.lbl_title.Text = "New Stock Transfer - Request"
        '
        'lbl_created_by
        '
        Me.lbl_created_by.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_created_by.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lbl_created_by.Appearance.ForeColor = System.Drawing.Color.DarkGray
        Me.lbl_created_by.Appearance.Options.UseFont = True
        Me.lbl_created_by.Appearance.Options.UseForeColor = True
        Me.lbl_created_by.Appearance.Options.UseTextOptions = True
        Me.lbl_created_by.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_created_by.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_created_by.Location = New System.Drawing.Point(780, 47)
        Me.lbl_created_by.Name = "lbl_created_by"
        Me.lbl_created_by.Size = New System.Drawing.Size(400, 20)
        Me.lbl_created_by.TabIndex = 79
        Me.lbl_created_by.Text = "Created by"
        Me.lbl_created_by.Visible = False
        '
        'lbl_status
        '
        Me.lbl_status.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_status.EditValue = "Status"
        Me.lbl_status.Location = New System.Drawing.Point(829, 12)
        Me.lbl_status.Name = "lbl_status"
        Me.lbl_status.Properties.AllowFocused = False
        Me.lbl_status.Properties.Appearance.BackColor = System.Drawing.Color.GhostWhite
        Me.lbl_status.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lbl_status.Properties.Appearance.ForeColor = System.Drawing.Color.Orange
        Me.lbl_status.Properties.Appearance.Options.UseBackColor = True
        Me.lbl_status.Properties.Appearance.Options.UseFont = True
        Me.lbl_status.Properties.Appearance.Options.UseForeColor = True
        Me.lbl_status.Properties.Appearance.Options.UseTextOptions = True
        Me.lbl_status.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_status.Properties.AutoHeight = False
        Me.lbl_status.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.lbl_status.Properties.ReadOnly = True
        Me.lbl_status.Properties.UseReadOnlyAppearance = False
        Me.lbl_status.Size = New System.Drawing.Size(351, 34)
        Me.lbl_status.TabIndex = 80
        Me.lbl_status.TabStop = False
        Me.lbl_status.Visible = False
        '
        'btn_save
        '
        Me.btn_save.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_save.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.btn_save.Appearance.Options.UseFont = True
        Me.btn_save.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.saveto_32x32
        Me.btn_save.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_save.Location = New System.Drawing.Point(1063, 104)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(118, 46)
        Me.btn_save.TabIndex = 85
        Me.btn_save.Text = "Save"
        Me.btn_save.Visible = False
        '
        'txt_stid
        '
        Me.txt_stid.Enabled = False
        Me.txt_stid.Location = New System.Drawing.Point(151, 91)
        Me.txt_stid.Name = "txt_stid"
        Me.txt_stid.Size = New System.Drawing.Size(100, 20)
        Me.txt_stid.TabIndex = 84
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(18, 92)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(103, 16)
        Me.LabelControl2.TabIndex = 83
        Me.LabelControl2.Text = "Stock Transfer ID"
        '
        'btn_delete
        '
        Me.btn_delete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_delete.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.btn_delete.Appearance.Options.UseFont = True
        Me.btn_delete.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.trash_32x32
        Me.btn_delete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_delete.Location = New System.Drawing.Point(690, 91)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(118, 46)
        Me.btn_delete.TabIndex = 82
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.Visible = False
        '
        'btn_create
        '
        Me.btn_create.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_create.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.btn_create.Appearance.Options.UseFont = True
        Me.btn_create.Enabled = False
        Me.btn_create.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.boorderitem_32x32
        Me.btn_create.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_create.Location = New System.Drawing.Point(1062, 91)
        Me.btn_create.Name = "btn_create"
        Me.btn_create.Size = New System.Drawing.Size(118, 46)
        Me.btn_create.TabIndex = 81
        Me.btn_create.Text = "Create"
        '
        'cbb_src_warehouse
        '
        Me.cbb_src_warehouse.Location = New System.Drawing.Point(151, 118)
        Me.cbb_src_warehouse.Name = "cbb_src_warehouse"
        Me.cbb_src_warehouse.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cbb_src_warehouse.Properties.Appearance.Options.UseFont = True
        Me.cbb_src_warehouse.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cbb_src_warehouse.Properties.AppearanceDropDown.Options.UseFont = True
        Me.cbb_src_warehouse.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_src_warehouse.Properties.LookAndFeel.SkinName = "Visual Studio 2013 Blue"
        Me.cbb_src_warehouse.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cbb_src_warehouse.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cbb_src_warehouse.Size = New System.Drawing.Size(280, 22)
        Me.cbb_src_warehouse.TabIndex = 80
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(18, 121)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(85, 16)
        Me.LabelControl1.TabIndex = 79
        Me.LabelControl1.Text = "Requested by"
        '
        'grid_request_stock
        '
        Me.grid_request_stock.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_request_stock.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.grid_request_stock.BackgroundColor = System.Drawing.Color.GhostWhite
        Me.grid_request_stock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_request_stock.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grid_request_stock.ColumnHeadersHeight = 40
        Me.grid_request_stock.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.pid, Me.winmodel, Me.description, Me.col_masterbox, Me.col_innerBox, Me.qty, Me.col_cbm, Me.col_kgs})
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grid_request_stock.DefaultCellStyle = DataGridViewCellStyle9
        Me.grid_request_stock.Enabled = False
        Me.grid_request_stock.EnableHeadersVisualStyles = False
        Me.grid_request_stock.Location = New System.Drawing.Point(17, 154)
        Me.grid_request_stock.Margin = New System.Windows.Forms.Padding(0)
        Me.grid_request_stock.Name = "grid_request_stock"
        Me.grid_request_stock.RowHeadersWidth = 40
        Me.grid_request_stock.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.grid_request_stock.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.grid_request_stock.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.grid_request_stock.RowTemplate.Height = 40
        Me.grid_request_stock.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grid_request_stock.Size = New System.Drawing.Size(1163, 556)
        Me.grid_request_stock.TabIndex = 78
        '
        'pid
        '
        Me.pid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.pid.DataPropertyName = "pid"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.pid.DefaultCellStyle = DataGridViewCellStyle2
        Me.pid.FillWeight = 80.0!
        Me.pid.HeaderText = "PID"
        Me.pid.MinimumWidth = 80
        Me.pid.Name = "pid"
        Me.pid.Width = 80
        '
        'winmodel
        '
        Me.winmodel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.winmodel.DataPropertyName = "winmodel"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.winmodel.DefaultCellStyle = DataGridViewCellStyle3
        Me.winmodel.FillWeight = 73.71088!
        Me.winmodel.HeaderText = "Model"
        Me.winmodel.MinimumWidth = 120
        Me.winmodel.Name = "winmodel"
        Me.winmodel.Width = 120
        '
        'description
        '
        Me.description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.description.DataPropertyName = "description"
        Me.description.FillWeight = 300.0!
        Me.description.HeaderText = "Description"
        Me.description.MinimumWidth = 300
        Me.description.Name = "description"
        Me.description.Width = 300
        '
        'col_masterbox
        '
        Me.col_masterbox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.col_masterbox.DataPropertyName = "masterbox_qty"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.col_masterbox.DefaultCellStyle = DataGridViewCellStyle4
        Me.col_masterbox.FillWeight = 80.0!
        Me.col_masterbox.HeaderText = "MasterBox Qty."
        Me.col_masterbox.MinimumWidth = 80
        Me.col_masterbox.Name = "col_masterbox"
        Me.col_masterbox.Width = 80
        '
        'col_innerBox
        '
        Me.col_innerBox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.col_innerBox.DataPropertyName = "qty_per_box"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.col_innerBox.DefaultCellStyle = DataGridViewCellStyle5
        Me.col_innerBox.FillWeight = 80.0!
        Me.col_innerBox.HeaderText = "Inner Box Qty."
        Me.col_innerBox.MinimumWidth = 80
        Me.col_innerBox.Name = "col_innerBox"
        Me.col_innerBox.Width = 80
        '
        'qty
        '
        Me.qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.qty.DataPropertyName = "qty"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle6.NullValue = Nothing
        Me.qty.DefaultCellStyle = DataGridViewCellStyle6
        Me.qty.FillWeight = 80.0!
        Me.qty.HeaderText = "Requested Stock Qty."
        Me.qty.MinimumWidth = 80
        Me.qty.Name = "qty"
        Me.qty.Width = 80
        '
        'col_cbm
        '
        Me.col_cbm.DataPropertyName = "cbm"
        DataGridViewCellStyle7.Format = "N2"
        Me.col_cbm.DefaultCellStyle = DataGridViewCellStyle7
        Me.col_cbm.HeaderText = "CBM"
        Me.col_cbm.Name = "col_cbm"
        Me.col_cbm.ReadOnly = True
        Me.col_cbm.Width = 60
        '
        'col_kgs
        '
        Me.col_kgs.DataPropertyName = "kgs"
        DataGridViewCellStyle8.Format = "N2"
        Me.col_kgs.DefaultCellStyle = DataGridViewCellStyle8
        Me.col_kgs.HeaderText = "KGS"
        Me.col_kgs.Name = "col_kgs"
        Me.col_kgs.ReadOnly = True
        Me.col_kgs.Width = 60
        '
        'btn_print
        '
        Me.btn_print.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_print.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.btn_print.Appearance.Options.UseFont = True
        Me.btn_print.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.print_32x321
        Me.btn_print.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_print.ImageOptions.ImageToTextIndent = 5
        Me.btn_print.Location = New System.Drawing.Point(938, 91)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(118, 46)
        Me.btn_print.TabIndex = 86
        Me.btn_print.Text = "Print"
        Me.btn_print.Visible = False
        '
        'lbl_total_kgs
        '
        Me.lbl_total_kgs.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_total_kgs.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.lbl_total_kgs.Appearance.Options.UseFont = True
        Me.lbl_total_kgs.Location = New System.Drawing.Point(1116, 776)
        Me.lbl_total_kgs.Name = "lbl_total_kgs"
        Me.lbl_total_kgs.Size = New System.Drawing.Size(59, 13)
        Me.lbl_total_kgs.TabIndex = 90
        Me.lbl_total_kgs.Text = "lbl_total_kgs"
        '
        'lbl_total_cbm
        '
        Me.lbl_total_cbm.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_total_cbm.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.lbl_total_cbm.Appearance.Options.UseFont = True
        Me.lbl_total_cbm.Location = New System.Drawing.Point(1117, 757)
        Me.lbl_total_cbm.Name = "lbl_total_cbm"
        Me.lbl_total_cbm.Size = New System.Drawing.Size(62, 13)
        Me.lbl_total_cbm.TabIndex = 89
        Me.lbl_total_cbm.Text = "lbl_total_cbm"
        '
        'LabelControl4
        '
        Me.LabelControl4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(1018, 776)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl4.TabIndex = 88
        Me.LabelControl4.Text = "Total Weight:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(1018, 757)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(87, 13)
        Me.LabelControl3.TabIndex = 87
        Me.LabelControl3.Text = "Total Cubic Meter:"
        '
        'btn_arrange
        '
        Me.btn_arrange.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_arrange.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.btn_arrange.Appearance.Options.UseFont = True
        Me.btn_arrange.Enabled = False
        Me.btn_arrange.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.packing1
        Me.btn_arrange.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_arrange.ImageOptions.ImageToTextIndent = 5
        Me.btn_arrange.Location = New System.Drawing.Point(814, 91)
        Me.btn_arrange.Name = "btn_arrange"
        Me.btn_arrange.Size = New System.Drawing.Size(118, 46)
        Me.btn_arrange.TabIndex = 92
        Me.btn_arrange.Text = "Arrange"
        Me.btn_arrange.Visible = False
        '
        'LabelControl5
        '
        Me.LabelControl5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(18, 716)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(60, 13)
        Me.LabelControl5.TabIndex = 94
        Me.LabelControl5.Text = "Public Notes"
        '
        'txt_note
        '
        Me.txt_note.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_note.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_note.Location = New System.Drawing.Point(18, 735)
        Me.txt_note.Multiline = True
        Me.txt_note.Name = "txt_note"
        Me.txt_note.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_note.Size = New System.Drawing.Size(565, 55)
        Me.txt_note.TabIndex = 93
        '
        'btn_approved
        '
        Me.btn_approved.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_approved.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_approved.Appearance.Options.UseFont = True
        Me.btn_approved.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.knowledgebasearticle_32x32
        Me.btn_approved.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_approved.Location = New System.Drawing.Point(566, 91)
        Me.btn_approved.Name = "btn_approved"
        Me.btn_approved.Size = New System.Drawing.Size(118, 46)
        Me.btn_approved.TabIndex = 95
        Me.btn_approved.Text = "Response"
        Me.btn_approved.Visible = False
        '
        'frm_warehouse_stocktransfer_request_new
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1193, 802)
        Me.Controls.Add(Me.btn_approved)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.txt_note)
        Me.Controls.Add(Me.btn_arrange)
        Me.Controls.Add(Me.lbl_total_kgs)
        Me.Controls.Add(Me.lbl_total_cbm)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.btn_print)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.txt_stid)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_create)
        Me.Controls.Add(Me.cbb_src_warehouse)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.grid_request_stock)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_warehouse_stocktransfer_request_new"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Stock Transfer - Request"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.lbl_status.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_stid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbb_src_warehouse.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_request_stock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_created_by As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_status As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btn_save As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_stid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_delete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_create As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cbb_src_warehouse As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grid_request_stock As DataGridView
    Friend WithEvents btn_print As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lbl_total_kgs As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_total_cbm As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents pid As DataGridViewTextBoxColumn
    Friend WithEvents winmodel As DataGridViewTextBoxColumn
    Friend WithEvents description As DataGridViewTextBoxColumn
    Friend WithEvents col_masterbox As DataGridViewTextBoxColumn
    Friend WithEvents col_innerBox As DataGridViewTextBoxColumn
    Friend WithEvents qty As DataGridViewTextBoxColumn
    Friend WithEvents col_cbm As DataGridViewTextBoxColumn
    Friend WithEvents col_kgs As DataGridViewTextBoxColumn
    Friend WithEvents lbl_title As Label
    Friend WithEvents btn_arrange As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_note As TextBox
    Friend WithEvents btn_approved As DevExpress.XtraEditors.SimpleButton
End Class
