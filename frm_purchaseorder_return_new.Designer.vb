<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_purchaseorder_return_new
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
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_purchaseorder_return_new))
        Me.GunaPanel4 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaPanel5 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.HyperlinkLabelControl3 = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.link_po_list = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.link_home = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.lbl_title = New Guna.UI.WinForms.GunaLabel()
        Me.grid_return = New System.Windows.Forms.DataGridView()
        Me.col_batch = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_model = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_cost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_totalcost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_create = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_total = New DevExpress.XtraEditors.LabelControl()
        Me.cbb_supplier = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_supplier_id = New DevExpress.XtraEditors.TextEdit()
        Me.btn_clear = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_update = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_delete = New DevExpress.XtraEditors.SimpleButton()
        Me.lbl_rid = New DevExpress.XtraEditors.LabelControl()
        Me.txt_prid = New DevExpress.XtraEditors.TextEdit()
        Me.btn_print = New DevExpress.XtraEditors.SimpleButton()
        Me.GunaPanel4.SuspendLayout()
        Me.GunaPanel5.SuspendLayout()
        Me.GunaPanel1.SuspendLayout()
        CType(Me.grid_return, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbb_supplier.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_supplier_id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_prid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaPanel4
        '
        Me.GunaPanel4.BackColor = System.Drawing.Color.GhostWhite
        Me.GunaPanel4.Controls.Add(Me.GunaPanel5)
        Me.GunaPanel4.Controls.Add(Me.lbl_title)
        Me.GunaPanel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel4.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel4.Name = "GunaPanel4"
        Me.GunaPanel4.Size = New System.Drawing.Size(1065, 78)
        Me.GunaPanel4.TabIndex = 9
        '
        'GunaPanel5
        '
        Me.GunaPanel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaPanel5.BackColor = System.Drawing.Color.Transparent
        Me.GunaPanel5.Controls.Add(Me.GunaPanel1)
        Me.GunaPanel5.Location = New System.Drawing.Point(19, 44)
        Me.GunaPanel5.Name = "GunaPanel5"
        Me.GunaPanel5.Size = New System.Drawing.Size(1034, 27)
        Me.GunaPanel5.TabIndex = 5
        '
        'GunaPanel1
        '
        Me.GunaPanel1.Controls.Add(Me.HyperlinkLabelControl3)
        Me.GunaPanel1.Controls.Add(Me.LabelControl8)
        Me.GunaPanel1.Controls.Add(Me.link_po_list)
        Me.GunaPanel1.Controls.Add(Me.LabelControl7)
        Me.GunaPanel1.Controls.Add(Me.link_home)
        Me.GunaPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GunaPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(435, 27)
        Me.GunaPanel1.TabIndex = 1
        '
        'HyperlinkLabelControl3
        '
        Me.HyperlinkLabelControl3.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HyperlinkLabelControl3.Appearance.LinkColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.HyperlinkLabelControl3.Appearance.Options.UseFont = True
        Me.HyperlinkLabelControl3.Appearance.Options.UseLinkColor = True
        Me.HyperlinkLabelControl3.AppearancePressed.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.HyperlinkLabelControl3.AppearancePressed.Options.UseLinkColor = True
        Me.HyperlinkLabelControl3.Enabled = False
        Me.HyperlinkLabelControl3.LineStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.HyperlinkLabelControl3.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.HyperlinkLabelControl3.Location = New System.Drawing.Point(191, 5)
        Me.HyperlinkLabelControl3.Name = "HyperlinkLabelControl3"
        Me.HyperlinkLabelControl3.ShowLineShadow = False
        Me.HyperlinkLabelControl3.Size = New System.Drawing.Size(29, 18)
        Me.HyperlinkLabelControl3.TabIndex = 9
        Me.HyperlinkLabelControl3.Text = "New"
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Location = New System.Drawing.Point(176, 7)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(9, 14)
        Me.LabelControl8.TabIndex = 8
        Me.LabelControl8.Text = ">"
        '
        'link_po_list
        '
        Me.link_po_list.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.link_po_list.Appearance.LinkColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.link_po_list.Appearance.Options.UseFont = True
        Me.link_po_list.Appearance.Options.UseLinkColor = True
        Me.link_po_list.AppearanceHovered.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.link_po_list.AppearanceHovered.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.link_po_list.AppearanceHovered.Options.UseForeColor = True
        Me.link_po_list.AppearanceHovered.Options.UseLinkColor = True
        Me.link_po_list.AppearancePressed.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.link_po_list.AppearancePressed.Options.UseLinkColor = True
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
        Me.lbl_title.Size = New System.Drawing.Size(280, 31)
        Me.lbl_title.TabIndex = 1
        Me.lbl_title.Text = "New Purchase Return"
        '
        'grid_return
        '
        Me.grid_return.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_return.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.grid_return.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.grid_return.BackgroundColor = System.Drawing.Color.GhostWhite
        Me.grid_return.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.grid_return.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_return.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grid_return.ColumnHeadersHeight = 28
        Me.grid_return.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.grid_return.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_batch, Me.col_total, Me.col_qty, Me.col_model, Me.col_description, Me.col_cost, Me.col_totalcost})
        Me.grid_return.EnableHeadersVisualStyles = False
        Me.grid_return.Location = New System.Drawing.Point(20, 182)
        Me.grid_return.Name = "grid_return"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_return.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.grid_return.Size = New System.Drawing.Size(1029, 410)
        Me.grid_return.TabIndex = 59
        '
        'col_batch
        '
        Me.col_batch.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.col_batch.DefaultCellStyle = DataGridViewCellStyle2
        Me.col_batch.FillWeight = 125.0!
        Me.col_batch.HeaderText = "Batch No."
        Me.col_batch.Name = "col_batch"
        Me.col_batch.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.col_batch.Width = 80
        '
        'col_total
        '
        Me.col_total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.col_total.DefaultCellStyle = DataGridViewCellStyle3
        Me.col_total.FillWeight = 125.5929!
        Me.col_total.HeaderText = "RID"
        Me.col_total.Name = "col_total"
        Me.col_total.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'col_qty
        '
        Me.col_qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Format = "N0"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.col_qty.DefaultCellStyle = DataGridViewCellStyle4
        Me.col_qty.FillWeight = 80.0!
        Me.col_qty.HeaderText = "Qty"
        Me.col_qty.Name = "col_qty"
        Me.col_qty.Width = 80
        '
        'col_model
        '
        Me.col_model.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.col_model.DefaultCellStyle = DataGridViewCellStyle5
        Me.col_model.FillWeight = 73.71088!
        Me.col_model.HeaderText = "Model"
        Me.col_model.Name = "col_model"
        Me.col_model.Width = 150
        '
        'col_description
        '
        Me.col_description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.col_description.FillWeight = 137.4594!
        Me.col_description.HeaderText = "Description"
        Me.col_description.Name = "col_description"
        '
        'col_cost
        '
        Me.col_cost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.col_cost.DefaultCellStyle = DataGridViewCellStyle6
        Me.col_cost.FillWeight = 102.6804!
        Me.col_cost.HeaderText = "Cost"
        Me.col_cost.Name = "col_cost"
        Me.col_cost.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'col_totalcost
        '
        Me.col_totalcost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.Format = "n2"
        Me.col_totalcost.DefaultCellStyle = DataGridViewCellStyle7
        Me.col_totalcost.HeaderText = "Total Cost"
        Me.col_totalcost.Name = "col_totalcost"
        Me.col_totalcost.ReadOnly = True
        Me.col_totalcost.Width = 120
        '
        'btn_create
        '
        Me.btn_create.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_create.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.btn_create.Appearance.Options.UseFont = True
        Me.btn_create.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.boproductgroup_32x321
        Me.btn_create.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_create.Location = New System.Drawing.Point(931, 118)
        Me.btn_create.Name = "btn_create"
        Me.btn_create.Size = New System.Drawing.Size(118, 46)
        Me.btn_create.TabIndex = 60
        Me.btn_create.Text = "Create"
        '
        'LabelControl1
        '
        Me.LabelControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Consolas", 14.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(762, 613)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(100, 22)
        Me.LabelControl1.TabIndex = 112
        Me.LabelControl1.Text = "Total Cost"
        '
        'lbl_total
        '
        Me.lbl_total.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_total.Appearance.BackColor = System.Drawing.Color.White
        Me.lbl_total.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbl_total.Appearance.Font = New System.Drawing.Font("Consolas", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_total.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.lbl_total.Appearance.Options.UseBackColor = True
        Me.lbl_total.Appearance.Options.UseBorderColor = True
        Me.lbl_total.Appearance.Options.UseFont = True
        Me.lbl_total.Appearance.Options.UseForeColor = True
        Me.lbl_total.Appearance.Options.UseTextOptions = True
        Me.lbl_total.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_total.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_total.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.lbl_total.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.lbl_total.Location = New System.Drawing.Point(878, 609)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.lbl_total.Size = New System.Drawing.Size(171, 29)
        Me.lbl_total.TabIndex = 113
        Me.lbl_total.Text = "₱0.00"
        '
        'cbb_supplier
        '
        Me.cbb_supplier.Location = New System.Drawing.Point(89, 151)
        Me.cbb_supplier.Name = "cbb_supplier"
        Me.cbb_supplier.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbb_supplier.Properties.Appearance.Options.UseFont = True
        Me.cbb_supplier.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_supplier.Size = New System.Drawing.Size(277, 22)
        Me.cbb_supplier.TabIndex = 114
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Appearance.Options.UseForeColor = True
        Me.LabelControl3.Location = New System.Drawing.Point(20, 154)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(50, 16)
        Me.LabelControl3.TabIndex = 115
        Me.LabelControl3.Text = "Supplier"
        '
        'txt_supplier_id
        '
        Me.txt_supplier_id.Enabled = False
        Me.txt_supplier_id.Location = New System.Drawing.Point(372, 151)
        Me.txt_supplier_id.Name = "txt_supplier_id"
        Me.txt_supplier_id.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_supplier_id.Properties.Appearance.Options.UseFont = True
        Me.txt_supplier_id.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_supplier_id.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txt_supplier_id.Size = New System.Drawing.Size(19, 22)
        Me.txt_supplier_id.TabIndex = 116
        Me.txt_supplier_id.Visible = False
        '
        'btn_clear
        '
        Me.btn_clear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_clear.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.btn_clear.Appearance.Options.UseFont = True
        Me.btn_clear.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.clearall_32x32
        Me.btn_clear.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_clear.Location = New System.Drawing.Point(807, 118)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(118, 46)
        Me.btn_clear.TabIndex = 117
        Me.btn_clear.Text = "Clear"
        '
        'btn_update
        '
        Me.btn_update.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_update.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.btn_update.Appearance.Options.UseFont = True
        Me.btn_update.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.saveto_32x32
        Me.btn_update.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_update.Location = New System.Drawing.Point(683, 118)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(118, 46)
        Me.btn_update.TabIndex = 118
        Me.btn_update.Text = "Save"
        Me.btn_update.Visible = False
        '
        'btn_delete
        '
        Me.btn_delete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_delete.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.btn_delete.Appearance.Options.UseFont = True
        Me.btn_delete.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.trash_32x32
        Me.btn_delete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_delete.Location = New System.Drawing.Point(559, 118)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(118, 46)
        Me.btn_delete.TabIndex = 119
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.Visible = False
        '
        'lbl_rid
        '
        Me.lbl_rid.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_rid.Appearance.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_rid.Appearance.Options.UseFont = True
        Me.lbl_rid.Appearance.Options.UseForeColor = True
        Me.lbl_rid.Location = New System.Drawing.Point(20, 126)
        Me.lbl_rid.Name = "lbl_rid"
        Me.lbl_rid.Size = New System.Drawing.Size(32, 16)
        Me.lbl_rid.TabIndex = 121
        Me.lbl_rid.Text = "PRID"
        Me.lbl_rid.Visible = False
        '
        'txt_prid
        '
        Me.txt_prid.Location = New System.Drawing.Point(89, 123)
        Me.txt_prid.Name = "txt_prid"
        Me.txt_prid.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_prid.Properties.Appearance.Options.UseFont = True
        Me.txt_prid.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_prid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txt_prid.Size = New System.Drawing.Size(129, 22)
        Me.txt_prid.TabIndex = 120
        Me.txt_prid.Visible = False
        '
        'btn_print
        '
        Me.btn_print.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_print.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.btn_print.Appearance.Options.UseFont = True
        Me.btn_print.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.print_32x322
        Me.btn_print.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_print.ImageOptions.ImageToTextIndent = 5
        Me.btn_print.Location = New System.Drawing.Point(435, 118)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(118, 46)
        Me.btn_print.TabIndex = 122
        Me.btn_print.Text = "Print"
        Me.btn_print.Visible = False
        '
        'frm_purchaseorder_return_new
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1065, 659)
        Me.Controls.Add(Me.btn_print)
        Me.Controls.Add(Me.lbl_rid)
        Me.Controls.Add(Me.txt_prid)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.txt_supplier_id)
        Me.Controls.Add(Me.cbb_supplier)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.btn_create)
        Me.Controls.Add(Me.grid_return)
        Me.Controls.Add(Me.GunaPanel4)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_purchaseorder_return_new"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Purchase Return"
        Me.GunaPanel4.ResumeLayout(False)
        Me.GunaPanel4.PerformLayout()
        Me.GunaPanel5.ResumeLayout(False)
        Me.GunaPanel1.ResumeLayout(False)
        Me.GunaPanel1.PerformLayout()
        CType(Me.grid_return, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbb_supplier.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_supplier_id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_prid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaPanel4 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPanel5 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents HyperlinkLabelControl3 As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents link_po_list As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents link_home As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents lbl_title As Guna.UI.WinForms.GunaLabel
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grid_return As DataGridView
    Friend WithEvents btn_create As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_total As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbb_supplier As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_supplier_id As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btn_clear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_update As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_delete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lbl_rid As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_prid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btn_print As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents col_batch As DataGridViewTextBoxColumn
    Friend WithEvents col_total As DataGridViewTextBoxColumn
    Friend WithEvents col_qty As DataGridViewTextBoxColumn
    Friend WithEvents col_model As DataGridViewTextBoxColumn
    Friend WithEvents col_description As DataGridViewTextBoxColumn
    Friend WithEvents col_cost As DataGridViewTextBoxColumn
    Friend WithEvents col_totalcost As DataGridViewTextBoxColumn
End Class
