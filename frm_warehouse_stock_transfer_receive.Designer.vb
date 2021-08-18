<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_warehouse_stock_transfer_receive
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_warehouse_stock_transfer_receive))
        Me.panel_top = New Guna.UI.WinForms.GunaLinePanel()
        Me.GunaPanel2 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaPanel3 = New Guna.UI.WinForms.GunaPanel()
        Me.HyperlinkLabelControl1 = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.HyperlinkLabelControl2 = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.lbl_title = New Guna.UI.WinForms.GunaLabel()
        Me.btn_save = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.grid_receiver = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descriptiom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_received = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lbl_transfer_id = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.cbb_source = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.cbb_destination = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btn_cancel = New DevExpress.XtraEditors.SimpleButton()
        Me.panel_top.SuspendLayout()
        Me.GunaPanel2.SuspendLayout()
        Me.GunaPanel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.grid_receiver, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.cbb_source.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbb_destination.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel_top
        '
        Me.panel_top.BackColor = System.Drawing.Color.GhostWhite
        Me.panel_top.Controls.Add(Me.GunaPanel2)
        Me.panel_top.Controls.Add(Me.lbl_title)
        Me.panel_top.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_top.LineColor = System.Drawing.SystemColors.ControlLight
        Me.panel_top.LineStyle = System.Windows.Forms.BorderStyle.None
        Me.panel_top.Location = New System.Drawing.Point(0, 0)
        Me.panel_top.Name = "panel_top"
        Me.panel_top.Size = New System.Drawing.Size(676, 78)
        Me.panel_top.TabIndex = 10
        '
        'GunaPanel2
        '
        Me.GunaPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaPanel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaPanel2.Controls.Add(Me.GunaPanel3)
        Me.GunaPanel2.Location = New System.Drawing.Point(19, 44)
        Me.GunaPanel2.Name = "GunaPanel2"
        Me.GunaPanel2.Size = New System.Drawing.Size(454, 27)
        Me.GunaPanel2.TabIndex = 6
        '
        'GunaPanel3
        '
        Me.GunaPanel3.Controls.Add(Me.HyperlinkLabelControl1)
        Me.GunaPanel3.Controls.Add(Me.LabelControl1)
        Me.GunaPanel3.Controls.Add(Me.HyperlinkLabelControl2)
        Me.GunaPanel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.GunaPanel3.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel3.Name = "GunaPanel3"
        Me.GunaPanel3.Size = New System.Drawing.Size(203, 27)
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
        Me.HyperlinkLabelControl1.Size = New System.Drawing.Size(85, 18)
        Me.HyperlinkLabelControl1.TabIndex = 7
        Me.HyperlinkLabelControl1.Text = "Stock Receive"
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
        Me.lbl_title.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lbl_title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.lbl_title.Location = New System.Drawing.Point(14, 10)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(189, 31)
        Me.lbl_title.TabIndex = 1
        Me.lbl_title.Text = "Stock Receive"
        '
        'btn_save
        '
        Me.btn_save.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_save.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary
        Me.btn_save.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.Appearance.Options.UseBackColor = True
        Me.btn_save.Appearance.Options.UseFont = True
        Me.btn_save.Appearance.Options.UseTextOptions = True
        Me.btn_save.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btn_save.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btn_save.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_save.ImageOptions.ImageToTextIndent = 8
        Me.btn_save.Location = New System.Drawing.Point(481, 8)
        Me.btn_save.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_save.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(168, 46)
        Me.btn_save.TabIndex = 80
        Me.btn_save.Text = "Save"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.grid_receiver)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Location = New System.Drawing.Point(15, 98)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(649, 586)
        Me.Panel1.TabIndex = 11
        '
        'grid_receiver
        '
        Me.grid_receiver.AllowUserToAddRows = False
        Me.grid_receiver.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.grid_receiver.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.grid_receiver.BackgroundColor = System.Drawing.Color.GhostWhite
        Me.grid_receiver.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_receiver.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grid_receiver.ColumnHeadersHeight = 28
        Me.grid_receiver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.grid_receiver.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.descriptiom, Me.DataGridViewTextBoxColumn2, Me.col_received})
        Me.grid_receiver.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid_receiver.EnableHeadersVisualStyles = False
        Me.grid_receiver.Location = New System.Drawing.Point(0, 80)
        Me.grid_receiver.Margin = New System.Windows.Forms.Padding(0)
        Me.grid_receiver.MultiSelect = False
        Me.grid_receiver.Name = "grid_receiver"
        Me.grid_receiver.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Nunito", 9.749999!)
        Me.grid_receiver.Size = New System.Drawing.Size(649, 440)
        Me.grid_receiver.TabIndex = 72
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn1.FillWeight = 80.0!
        Me.DataGridViewTextBoxColumn1.HeaderText = "PID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 80
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn3.FillWeight = 73.71088!
        Me.DataGridViewTextBoxColumn3.HeaderText = "Model"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 120
        '
        'descriptiom
        '
        Me.descriptiom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.descriptiom.HeaderText = "Description"
        Me.descriptiom.Name = "descriptiom"
        Me.descriptiom.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.NullValue = Nothing
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn2.FillWeight = 80.0!
        Me.DataGridViewTextBoxColumn2.HeaderText = "To Receive"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 80
        '
        'col_received
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.col_received.DefaultCellStyle = DataGridViewCellStyle5
        Me.col_received.HeaderText = "Received"
        Me.col_received.Name = "col_received"
        Me.col_received.Width = 76
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(649, 80)
        Me.Panel2.TabIndex = 12
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Lavender
        Me.Panel3.Controls.Add(Me.lbl_transfer_id)
        Me.Panel3.Controls.Add(Me.GunaLabel2)
        Me.Panel3.Controls.Add(Me.cbb_source)
        Me.Panel3.Controls.Add(Me.GunaLabel1)
        Me.Panel3.Controls.Add(Me.cbb_destination)
        Me.Panel3.Controls.Add(Me.GunaLabel3)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(649, 80)
        Me.Panel3.TabIndex = 74
        '
        'lbl_transfer_id
        '
        Me.lbl_transfer_id.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_transfer_id.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_transfer_id.Location = New System.Drawing.Point(561, 18)
        Me.lbl_transfer_id.Name = "lbl_transfer_id"
        Me.lbl_transfer_id.Size = New System.Drawing.Size(85, 16)
        Me.lbl_transfer_id.TabIndex = 83
        Me.lbl_transfer_id.Text = "ST00000"
        Me.lbl_transfer_id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GunaLabel2
        '
        Me.GunaLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.Location = New System.Drawing.Point(453, 18)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(112, 16)
        Me.GunaLabel2.TabIndex = 82
        Me.GunaLabel2.Text = "Stock Transfer ID:"
        '
        'cbb_source
        '
        Me.cbb_source.Enabled = False
        Me.cbb_source.Location = New System.Drawing.Point(99, 16)
        Me.cbb_source.Name = "cbb_source"
        Me.cbb_source.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.cbb_source.Properties.Appearance.Options.UseFont = True
        Me.cbb_source.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_source.Size = New System.Drawing.Size(293, 22)
        Me.cbb_source.TabIndex = 81
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.Location = New System.Drawing.Point(16, 18)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(53, 16)
        Me.GunaLabel1.TabIndex = 80
        Me.GunaLabel1.Text = "Source:"
        '
        'cbb_destination
        '
        Me.cbb_destination.Enabled = False
        Me.cbb_destination.Location = New System.Drawing.Point(99, 44)
        Me.cbb_destination.Name = "cbb_destination"
        Me.cbb_destination.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.cbb_destination.Properties.Appearance.Options.UseFont = True
        Me.cbb_destination.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_destination.Size = New System.Drawing.Size(293, 22)
        Me.cbb_destination.TabIndex = 76
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.Location = New System.Drawing.Point(16, 46)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(77, 16)
        Me.GunaLabel3.TabIndex = 75
        Me.GunaLabel3.Text = "Destination:"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btn_cancel)
        Me.Panel4.Controls.Add(Me.btn_save)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 520)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(649, 66)
        Me.Panel4.TabIndex = 73
        '
        'btn_cancel
        '
        Me.btn_cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_cancel.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.Appearance.Options.UseFont = True
        Me.btn_cancel.Appearance.Options.UseTextOptions = True
        Me.btn_cancel.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btn_cancel.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_cancel.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_cancel.ImageOptions.ImageToTextIndent = 8
        Me.btn_cancel.Location = New System.Drawing.Point(307, 8)
        Me.btn_cancel.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_cancel.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(168, 46)
        Me.btn_cancel.TabIndex = 83
        Me.btn_cancel.Text = "Cancel"
        '
        'frm_warehouse_receive_stocks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(676, 684)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.panel_top)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_warehouse_receive_stocks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stock Receive"
        Me.panel_top.ResumeLayout(False)
        Me.panel_top.PerformLayout()
        Me.GunaPanel2.ResumeLayout(False)
        Me.GunaPanel3.ResumeLayout(False)
        Me.GunaPanel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.grid_receiver, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.cbb_source.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbb_destination.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panel_top As Guna.UI.WinForms.GunaLinePanel
    Friend WithEvents btn_save As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GunaPanel2 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPanel3 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents HyperlinkLabelControl1 As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents HyperlinkLabelControl2 As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents lbl_title As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents cbb_destination As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents grid_receiver As DataGridView
    Friend WithEvents cbb_source As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btn_cancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents descriptiom As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents col_received As DataGridViewTextBoxColumn
    Friend WithEvents lbl_transfer_id As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
End Class
