Imports DevExpress.LookAndFeel
Imports DevExpress.XtraEditors
Imports Guna.UI.WinForms
Imports System.ComponentModel
Imports System.Drawing.Drawing2D


<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_warehouse_deliveries
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
		Dim dataGridViewCellStyle As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim window As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim dataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Me.panel_top = New GunaPanel()
		Me.GunaPanel5 = New GunaPanel()
		Me.GunaPanel1 = New GunaPanel()
		Me.link_po_list = New HyperlinkLabelControl()
		Me.LabelControl7 = New LabelControl()
		Me.link_home = New HyperlinkLabelControl()
		Me.GunaLabel2 = New GunaLabel()
		Me.grid_delivery = New DataGridView()
		Me.col_model = New DataGridViewTextBoxColumn()
		Me.col_poid = New DataGridViewTextBoxColumn()
		Me.col_description = New DataGridViewTextBoxColumn()
		Me.col_lead_time_status = New DataGridViewTextBoxColumn()
		Me.GunaLabel1 = New GunaLabel()
		Me.panel_view = New GunaLinePanel()
		Me.Label1 = New Label()
		Me.btn_open_receipt = New SimpleButton()
		Me.panel_top.SuspendLayout()
		Me.GunaPanel5.SuspendLayout()
		Me.GunaPanel1.SuspendLayout()
		DirectCast(Me.grid_delivery, ISupportInitialize).BeginInit()
		Me.panel_view.SuspendLayout()
		Me.SuspendLayout()
		Me.panel_top.BackColor = Color.GhostWhite
		Me.panel_top.Controls.Add(Me.GunaPanel5)
		Me.panel_top.Controls.Add(Me.GunaLabel2)
		Me.panel_top.Dock = DockStyle.Top
		Me.panel_top.Location = New Point(0, 0)
		Me.panel_top.Name = "panel_top"
		Me.panel_top.Size = New System.Drawing.Size(1206, 78)
		Me.panel_top.TabIndex = 8
		Me.GunaPanel5.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
		Me.GunaPanel5.BackColor = Color.Transparent
		Me.GunaPanel5.Controls.Add(Me.GunaPanel1)
		Me.GunaPanel5.Location = New Point(19, 44)
		Me.GunaPanel5.Name = "GunaPanel5"
		Me.GunaPanel5.Size = New System.Drawing.Size(1166, 27)
		Me.GunaPanel5.TabIndex = 5
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
		Me.link_po_list.Size = New System.Drawing.Size(63, 18)
		Me.link_po_list.TabIndex = 7
		Me.link_po_list.Text = "Deliveries"
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
		Me.GunaLabel2.AutoSize = True
		Me.GunaLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
		Me.GunaLabel2.ForeColor = Color.FromArgb(213, 115, 45)
		Me.GunaLabel2.Location = New Point(14, 10)
		Me.GunaLabel2.Name = "GunaLabel2"
		Me.GunaLabel2.Size = New System.Drawing.Size(181, 31)
		Me.GunaLabel2.TabIndex = 1
		Me.GunaLabel2.Text = "Daily Delivery"
		Me.grid_delivery.AllowUserToAddRows = False
		Me.grid_delivery.AllowUserToDeleteRows = False
		Me.grid_delivery.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
		Me.grid_delivery.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader
		Me.grid_delivery.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells
		Me.grid_delivery.BackgroundColor = Color.GhostWhite
		Me.grid_delivery.BorderStyle = BorderStyle.Fixed3D
		Me.grid_delivery.CellBorderStyle = DataGridViewCellBorderStyle.None
		dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
		dataGridViewCellStyle.BackColor = Color.FromArgb(207, 221, 238)
		dataGridViewCellStyle.Font = New System.Drawing.Font("Tahoma", 9.0!)
		dataGridViewCellStyle.ForeColor = SystemColors.WindowText
		dataGridViewCellStyle.SelectionBackColor = SystemColors.GradientInactiveCaption
		dataGridViewCellStyle.SelectionForeColor = SystemColors.WindowText
		dataGridViewCellStyle.WrapMode = DataGridViewTriState.[True]
		Me.grid_delivery.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle
		Me.grid_delivery.ColumnHeadersHeight = 28
		Me.grid_delivery.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
		Me.grid_delivery.Columns.AddRange(New DataGridViewColumn() {Me.col_model, Me.col_poid, Me.col_description, Me.col_lead_time_status})
		window.Alignment = DataGridViewContentAlignment.MiddleLeft
		window.BackColor = SystemColors.Window
		window.Font = New System.Drawing.Font("Tahoma", 9.0!, FontStyle.Regular, GraphicsUnit.Point, 0)
		window.ForeColor = SystemColors.ControlText
		window.SelectionBackColor = SystemColors.GradientActiveCaption
		window.SelectionForeColor = SystemColors.ControlText
		window.WrapMode = DataGridViewTriState.[False]
		Me.grid_delivery.DefaultCellStyle = window
		Me.grid_delivery.EnableHeadersVisualStyles = False
		Me.grid_delivery.Location = New Point(20, 127)
		Me.grid_delivery.MultiSelect = False
		Me.grid_delivery.Name = "grid_delivery"
		Me.grid_delivery.[ReadOnly] = True
		Me.grid_delivery.RowHeadersVisible = False
		Me.grid_delivery.SelectionMode = DataGridViewSelectionMode.FullRowSelect
		Me.grid_delivery.Size = New System.Drawing.Size(389, 509)
		Me.grid_delivery.TabIndex = 59
		Me.col_model.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
		Me.col_model.DataPropertyName = "lead_time"
		dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
		dataGridViewCellStyle1.Format = "M"
		dataGridViewCellStyle1.NullValue = Nothing
		Me.col_model.DefaultCellStyle = dataGridViewCellStyle1
		Me.col_model.FillWeight = 60.0!
		Me.col_model.HeaderText = "EDD"
		Me.col_model.Name = "col_model"
		Me.col_model.[ReadOnly] = True
		Me.col_model.ToolTipText = "Expected Date of Delivery"
		Me.col_model.Width = 60
		Me.col_poid.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
		Me.col_poid.DataPropertyName = "poid"
		Me.col_poid.FillWeight = 80.0!
		Me.col_poid.HeaderText = "Purchase ID"
		Me.col_poid.Name = "col_poid"
		Me.col_poid.[ReadOnly] = True
		Me.col_poid.Width = 80
		Me.col_description.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
		Me.col_description.DataPropertyName = "supplier"
		Me.col_description.FillWeight = 137.4594!
		Me.col_description.HeaderText = "Supplier"
		Me.col_description.Name = "col_description"
		Me.col_description.[ReadOnly] = True
		Me.col_lead_time_status.DataPropertyName = "lead_time_status"
		Me.col_lead_time_status.HeaderText = "Lead Time Status"
		Me.col_lead_time_status.Name = "col_lead_time_status"
		Me.col_lead_time_status.[ReadOnly] = True
		Me.col_lead_time_status.Visible = False
		Me.col_lead_time_status.Width = 128
		Me.GunaLabel1.AutoSize = True
		Me.GunaLabel1.Font = New System.Drawing.Font("Tahoma", 16.0!)
		Me.GunaLabel1.ForeColor = Color.FromArgb(213, 115, 45)
		Me.GunaLabel1.Location = New Point(14, 93)
		Me.GunaLabel1.Name = "GunaLabel1"
		Me.GunaLabel1.Size = New System.Drawing.Size(202, 27)
		Me.GunaLabel1.TabIndex = 6
		Me.GunaLabel1.Text = "Expected Deliveries"
		Me.panel_view.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
		Me.panel_view.BackColor = Color.GhostWhite
		Me.panel_view.Controls.Add(Me.Label1)
		Me.panel_view.LineBottom = 1
		Me.panel_view.LineColor = Color.LightGray
		Me.panel_view.LineLeft = 1
		Me.panel_view.LineRight = 1
		Me.panel_view.LineStyle = BorderStyle.None
		Me.panel_view.LineTop = 1
		Me.panel_view.Location = New Point(415, 84)
		Me.panel_view.Name = "panel_view"
		Me.panel_view.Size = New System.Drawing.Size(779, 566)
		Me.panel_view.TabIndex = 60
		Me.Label1.Anchor = AnchorStyles.None
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.0!)
		Me.Label1.ForeColor = SystemColors.ControlDarkDark
		Me.Label1.Location = New Point(277, 256)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(264, 23)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Double Click Deliveries to View"
		Me.btn_open_receipt.Appearance.BackColor = DXSkinColors.FillColors.Success
		Me.btn_open_receipt.Appearance.Options.UseBackColor = True
		Me.btn_open_receipt.Location = New Point(320, 93)
		Me.btn_open_receipt.Name = "btn_open_receipt"
		Me.btn_open_receipt.Size = New System.Drawing.Size(89, 28)
		Me.btn_open_receipt.TabIndex = 61
		Me.btn_open_receipt.Text = "Open Receipt"
		Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = Color.White
		Me.ClientSize = New System.Drawing.Size(1206, 648)
		Me.Controls.Add(Me.btn_open_receipt)
		Me.Controls.Add(Me.grid_delivery)
		Me.Controls.Add(Me.panel_view)
		Me.Controls.Add(Me.GunaLabel1)
		Me.Controls.Add(Me.panel_top)
		Me.Name = "frm_warehouse_deliveries"
		Me.Text = "frm_deliveries"
		Me.panel_top.ResumeLayout(False)
		Me.panel_top.PerformLayout()
		Me.GunaPanel5.ResumeLayout(False)
		Me.GunaPanel1.ResumeLayout(False)
		Me.GunaPanel1.PerformLayout()
		DirectCast(Me.grid_delivery, ISupportInitialize).EndInit()
		Me.panel_view.ResumeLayout(False)
		Me.panel_view.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

    Friend WithEvents panel_top As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPanel5 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents link_po_list As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents link_home As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents grid_delivery As DataGridView
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents panel_view As Guna.UI.WinForms.GunaLinePanel
    Friend WithEvents Label1 As Label
    Friend WithEvents col_model As DataGridViewTextBoxColumn
    Friend WithEvents col_poid As DataGridViewTextBoxColumn
    Friend WithEvents col_description As DataGridViewTextBoxColumn
    Friend WithEvents col_lead_time_status As DataGridViewTextBoxColumn
    Friend WithEvents btn_open_receipt As DevExpress.XtraEditors.SimpleButton
End Class
