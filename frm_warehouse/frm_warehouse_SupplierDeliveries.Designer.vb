Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports Guna.UI.WinForms
Imports Inventory_Management.My
Imports Inventory_Management.My.Resources
Imports System.ComponentModel

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_warehouse_SupplierDeliveries
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.dt_receipt = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.grid_order = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_sup_model = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_cost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_tota_received = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_received = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_remaining_qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_search = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.withholding_tax_percentage = New DevExpress.XtraEditors.LabelControl()
        Me.withholding_tax_amount = New DevExpress.XtraEditors.LabelControl()
        Me.is_withholding_tax_applied = New System.Windows.Forms.CheckBox()
        Me.cbb_discount = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_return_credit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_discount = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_count_by = New DevExpress.XtraEditors.TextEdit()
        Me.btn_print = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_supid = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_amount = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_ref = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.cbb_receipt = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.btn_mark = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_save = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_poid = New DevExpress.XtraEditors.TextEdit()
        Me.cbb_deliver = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cbb_supplier = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_head = New System.Windows.Forms.Label()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.dt_receipt.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_receipt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_order, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_search.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbb_discount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_return_credit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_discount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_count_by.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_amount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ref.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbb_receipt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_poid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbb_deliver.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbb_supplier.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.PanelControl1.Controls.Add(Me.dt_receipt)
        Me.PanelControl1.Controls.Add(Me.LabelControl11)
        Me.PanelControl1.Controls.Add(Me.grid_order)
        Me.PanelControl1.Controls.Add(Me.LabelControl16)
        Me.PanelControl1.Controls.Add(Me.txt_search)
        Me.PanelControl1.Controls.Add(Me.LabelControl10)
        Me.PanelControl1.Controls.Add(Me.withholding_tax_percentage)
        Me.PanelControl1.Controls.Add(Me.withholding_tax_amount)
        Me.PanelControl1.Controls.Add(Me.is_withholding_tax_applied)
        Me.PanelControl1.Controls.Add(Me.cbb_discount)
        Me.PanelControl1.Controls.Add(Me.LabelControl8)
        Me.PanelControl1.Controls.Add(Me.txt_return_credit)
        Me.PanelControl1.Controls.Add(Me.LabelControl9)
        Me.PanelControl1.Controls.Add(Me.txt_discount)
        Me.PanelControl1.Controls.Add(Me.LabelControl7)
        Me.PanelControl1.Controls.Add(Me.txt_count_by)
        Me.PanelControl1.Controls.Add(Me.btn_print)
        Me.PanelControl1.Controls.Add(Me.txt_supid)
        Me.PanelControl1.Controls.Add(Me.LabelControl4)
        Me.PanelControl1.Controls.Add(Me.txt_amount)
        Me.PanelControl1.Controls.Add(Me.LabelControl3)
        Me.PanelControl1.Controls.Add(Me.txt_ref)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.cbb_receipt)
        Me.PanelControl1.Controls.Add(Me.btn_mark)
        Me.PanelControl1.Controls.Add(Me.btn_save)
        Me.PanelControl1.Controls.Add(Me.LabelControl5)
        Me.PanelControl1.Controls.Add(Me.txt_poid)
        Me.PanelControl1.Controls.Add(Me.cbb_deliver)
        Me.PanelControl1.Controls.Add(Me.cbb_supplier)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.LabelControl6)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 63)
        Me.PanelControl1.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.PanelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1033, 570)
        Me.PanelControl1.TabIndex = 53
        '
        'dt_receipt
        '
        Me.dt_receipt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dt_receipt.EditValue = Nothing
        Me.dt_receipt.Location = New System.Drawing.Point(690, 50)
        Me.dt_receipt.Name = "dt_receipt"
        Me.dt_receipt.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dt_receipt.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dt_receipt.Properties.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.dt_receipt.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dt_receipt.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.dt_receipt.Size = New System.Drawing.Size(100, 20)
        Me.dt_receipt.TabIndex = 123
        '
        'LabelControl11
        '
        Me.LabelControl11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LabelControl11.Appearance.Options.UseFont = True
        Me.LabelControl11.Location = New System.Drawing.Point(690, 31)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(70, 14)
        Me.LabelControl11.TabIndex = 122
        Me.LabelControl11.Text = "Receipt date"
        '
        'grid_order
        '
        Me.grid_order.AllowUserToAddRows = False
        Me.grid_order.AllowUserToDeleteRows = False
        Me.grid_order.AllowUserToResizeRows = False
        Me.grid_order.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_order.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.grid_order.BackgroundColor = System.Drawing.Color.GhostWhite
        Me.grid_order.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.grid_order.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_order.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grid_order.ColumnHeadersHeight = 32
        Me.grid_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.grid_order.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.col_sup_model, Me.DataGridViewTextBoxColumn4, Me.col_cost, Me.col_total, Me.col_tota_received, Me.col_received, Me.col_remaining_qty})
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Tahoma", 8.25!)
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(78, Byte), Integer))
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grid_order.DefaultCellStyle = DataGridViewCellStyle10
        Me.grid_order.EnableHeadersVisualStyles = False
        Me.grid_order.Location = New System.Drawing.Point(22, 179)
        Me.grid_order.Name = "grid_order"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Tahoma", 8.25!)
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_order.RowHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.grid_order.RowHeadersWidth = 30
        Me.grid_order.RowTemplate.Height = 23
        Me.grid_order.Size = New System.Drawing.Size(987, 324)
        Me.grid_order.TabIndex = 121
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "pid"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn1.FillWeight = 80.0!
        Me.DataGridViewTextBoxColumn1.HeaderText = "PID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "qty"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn2.FillWeight = 80.0!
        Me.DataGridViewTextBoxColumn2.HeaderText = "Quantity"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "winmodel"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn3.FillWeight = 73.71088!
        Me.DataGridViewTextBoxColumn3.HeaderText = "Win. Model"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'col_sup_model
        '
        Me.col_sup_model.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.col_sup_model.DataPropertyName = "supmodel"
        Me.col_sup_model.HeaderText = "Sup. Model"
        Me.col_sup_model.Name = "col_sup_model"
        Me.col_sup_model.ReadOnly = True
        Me.col_sup_model.Visible = False
        Me.col_sup_model.Width = 150
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "description"
        Me.DataGridViewTextBoxColumn4.FillWeight = 137.4594!
        Me.DataGridViewTextBoxColumn4.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'col_cost
        '
        Me.col_cost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.col_cost.DataPropertyName = "cost"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "n2"
        Me.col_cost.DefaultCellStyle = DataGridViewCellStyle5
        Me.col_cost.FillWeight = 102.6804!
        Me.col_cost.HeaderText = "Cost"
        Me.col_cost.Name = "col_cost"
        Me.col_cost.ReadOnly = True
        Me.col_cost.Visible = False
        '
        'col_total
        '
        Me.col_total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.col_total.DataPropertyName = "total"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "n2"
        Me.col_total.DefaultCellStyle = DataGridViewCellStyle6
        Me.col_total.FillWeight = 125.5929!
        Me.col_total.HeaderText = "Total"
        Me.col_total.Name = "col_total"
        Me.col_total.ReadOnly = True
        Me.col_total.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.col_total.Visible = False
        '
        'col_tota_received
        '
        Me.col_tota_received.DataPropertyName = "total_received"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.col_tota_received.DefaultCellStyle = DataGridViewCellStyle7
        Me.col_tota_received.HeaderText = "Total Received"
        Me.col_tota_received.Name = "col_tota_received"
        Me.col_tota_received.ReadOnly = True
        Me.col_tota_received.Width = 95
        '
        'col_received
        '
        Me.col_received.DataPropertyName = "qty_received"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.col_received.DefaultCellStyle = DataGridViewCellStyle8
        Me.col_received.HeaderText = "QTY. Received"
        Me.col_received.Name = "col_received"
        Me.col_received.Width = 95
        '
        'col_remaining_qty
        '
        Me.col_remaining_qty.DataPropertyName = "remaining"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.col_remaining_qty.DefaultCellStyle = DataGridViewCellStyle9
        Me.col_remaining_qty.HeaderText = "Remaining"
        Me.col_remaining_qty.Name = "col_remaining_qty"
        Me.col_remaining_qty.ReadOnly = True
        Me.col_remaining_qty.Width = 81
        '
        'LabelControl16
        '
        Me.LabelControl16.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.LabelControl16.Appearance.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelControl16.Appearance.Options.UseFont = True
        Me.LabelControl16.Appearance.Options.UseForeColor = True
        Me.LabelControl16.Location = New System.Drawing.Point(22, 154)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(43, 16)
        Me.LabelControl16.TabIndex = 120
        Me.LabelControl16.Text = "Search"
        '
        'txt_search
        '
        Me.txt_search.Location = New System.Drawing.Point(82, 149)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txt_search.Properties.Appearance.Options.UseFont = True
        Me.txt_search.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_search.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txt_search.Size = New System.Drawing.Size(152, 24)
        Me.txt_search.TabIndex = 119
        Me.txt_search.TabStop = False
        '
        'LabelControl10
        '
        Me.LabelControl10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LabelControl10.Appearance.Options.UseFont = True
        Me.LabelControl10.Location = New System.Drawing.Point(986, 541)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(21, 14)
        Me.LabelControl10.TabIndex = 104
        Me.LabelControl10.Text = "Php"
        '
        'withholding_tax_percentage
        '
        Me.withholding_tax_percentage.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.withholding_tax_percentage.Appearance.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.withholding_tax_percentage.Appearance.Options.UseFont = True
        Me.withholding_tax_percentage.Location = New System.Drawing.Point(619, 548)
        Me.withholding_tax_percentage.Name = "withholding_tax_percentage"
        Me.withholding_tax_percentage.Size = New System.Drawing.Size(137, 13)
        Me.withholding_tax_percentage.TabIndex = 103
        Me.withholding_tax_percentage.Text = "withholding_tax_percentage"
        Me.withholding_tax_percentage.Visible = False
        '
        'withholding_tax_amount
        '
        Me.withholding_tax_amount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.withholding_tax_amount.Appearance.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.withholding_tax_amount.Appearance.Options.UseFont = True
        Me.withholding_tax_amount.Location = New System.Drawing.Point(619, 532)
        Me.withholding_tax_amount.Name = "withholding_tax_amount"
        Me.withholding_tax_amount.Size = New System.Drawing.Size(118, 13)
        Me.withholding_tax_amount.TabIndex = 102
        Me.withholding_tax_amount.Text = "withholding_tax_amount"
        Me.withholding_tax_amount.Visible = False
        '
        'is_withholding_tax_applied
        '
        Me.is_withholding_tax_applied.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.is_withholding_tax_applied.AutoSize = True
        Me.is_withholding_tax_applied.Location = New System.Drawing.Point(601, 514)
        Me.is_withholding_tax_applied.Name = "is_withholding_tax_applied"
        Me.is_withholding_tax_applied.Size = New System.Drawing.Size(155, 17)
        Me.is_withholding_tax_applied.TabIndex = 101
        Me.is_withholding_tax_applied.Text = "is_withholding_tax_applied"
        Me.is_withholding_tax_applied.UseVisualStyleBackColor = True
        Me.is_withholding_tax_applied.Visible = False
        '
        'cbb_discount
        '
        Me.cbb_discount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbb_discount.Location = New System.Drawing.Point(956, 509)
        Me.cbb_discount.Name = "cbb_discount"
        Me.cbb_discount.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.cbb_discount.Properties.Appearance.Options.UseFont = True
        Me.cbb_discount.Properties.Appearance.Options.UseTextOptions = True
        Me.cbb_discount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.cbb_discount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_discount.Properties.Items.AddRange(New Object() {"Php", "%"})
        Me.cbb_discount.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cbb_discount.Size = New System.Drawing.Size(51, 22)
        Me.cbb_discount.TabIndex = 100
        '
        'LabelControl8
        '
        Me.LabelControl8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Location = New System.Drawing.Point(799, 540)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(77, 14)
        Me.LabelControl8.TabIndex = 98
        Me.LabelControl8.Text = "Return Credit:"
        '
        'txt_return_credit
        '
        Me.txt_return_credit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_return_credit.EditValue = "0.00"
        Me.txt_return_credit.Location = New System.Drawing.Point(881, 538)
        Me.txt_return_credit.Name = "txt_return_credit"
        Me.txt_return_credit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_return_credit.Properties.Appearance.Options.UseFont = True
        Me.txt_return_credit.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_return_credit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txt_return_credit.Size = New System.Drawing.Size(101, 20)
        Me.txt_return_credit.TabIndex = 99
        '
        'LabelControl9
        '
        Me.LabelControl9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Location = New System.Drawing.Point(799, 513)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(51, 14)
        Me.LabelControl9.TabIndex = 97
        Me.LabelControl9.Text = "Discount:"
        '
        'txt_discount
        '
        Me.txt_discount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_discount.EditValue = "0.00"
        Me.txt_discount.Location = New System.Drawing.Point(881, 509)
        Me.txt_discount.Name = "txt_discount"
        Me.txt_discount.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_discount.Properties.Appearance.Options.UseFont = True
        Me.txt_discount.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_discount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txt_discount.Properties.AutoHeight = False
        Me.txt_discount.Size = New System.Drawing.Size(76, 22)
        Me.txt_discount.TabIndex = 96
        '
        'LabelControl7
        '
        Me.LabelControl7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Location = New System.Drawing.Point(786, 123)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(64, 14)
        Me.LabelControl7.TabIndex = 94
        Me.LabelControl7.Text = "Counted by"
        '
        'txt_count_by
        '
        Me.txt_count_by.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_count_by.Location = New System.Drawing.Point(786, 141)
        Me.txt_count_by.Name = "txt_count_by"
        Me.txt_count_by.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_count_by.Properties.Appearance.Options.UseFont = True
        Me.txt_count_by.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_count_by.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txt_count_by.Size = New System.Drawing.Size(86, 20)
        Me.txt_count_by.TabIndex = 93
        '
        'btn_print
        '
        Me.btn_print.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_print.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_print.Appearance.Options.UseFont = True
        Me.btn_print.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.print_32x321
        Me.btn_print.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter
        Me.btn_print.Location = New System.Drawing.Point(881, 18)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(60, 60)
        Me.btn_print.TabIndex = 95
        Me.btn_print.Text = "Print"
        '
        'txt_supid
        '
        Me.txt_supid.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_supid.Appearance.Options.UseFont = True
        Me.txt_supid.Location = New System.Drawing.Point(361, 56)
        Me.txt_supid.Name = "txt_supid"
        Me.txt_supid.Size = New System.Drawing.Size(28, 14)
        Me.txt_supid.TabIndex = 92
        Me.txt_supid.Text = "supid"
        Me.txt_supid.Visible = False
        '
        'LabelControl4
        '
        Me.LabelControl4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(690, 123)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(56, 14)
        Me.LabelControl4.TabIndex = 91
        Me.LabelControl4.Text = "Total Cost"
        '
        'txt_amount
        '
        Me.txt_amount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_amount.Location = New System.Drawing.Point(690, 141)
        Me.txt_amount.Name = "txt_amount"
        Me.txt_amount.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_amount.Properties.Appearance.Options.UseFont = True
        Me.txt_amount.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_amount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.txt_amount.Properties.AutoHeight = False
        Me.txt_amount.Size = New System.Drawing.Size(87, 21)
        Me.txt_amount.TabIndex = 90
        '
        'LabelControl3
        '
        Me.LabelControl3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(786, 76)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(69, 14)
        Me.LabelControl3.TabIndex = 89
        Me.LabelControl3.Text = "Reference #"
        '
        'txt_ref
        '
        Me.txt_ref.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_ref.Location = New System.Drawing.Point(786, 97)
        Me.txt_ref.Name = "txt_ref"
        Me.txt_ref.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_ref.Properties.Appearance.Options.UseFont = True
        Me.txt_ref.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_ref.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.txt_ref.Properties.AutoHeight = False
        Me.txt_ref.Size = New System.Drawing.Size(87, 21)
        Me.txt_ref.TabIndex = 88
        '
        'LabelControl2
        '
        Me.LabelControl2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(690, 76)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(73, 14)
        Me.LabelControl2.TabIndex = 87
        Me.LabelControl2.Text = "Receipt Type"
        '
        'cbb_receipt
        '
        Me.cbb_receipt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbb_receipt.Location = New System.Drawing.Point(690, 96)
        Me.cbb_receipt.Name = "cbb_receipt"
        Me.cbb_receipt.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cbb_receipt.Properties.Appearance.Options.UseFont = True
        Me.cbb_receipt.Properties.AutoHeight = False
        Me.cbb_receipt.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_receipt.Properties.Items.AddRange(New Object() {"DR", "SI-NV", "SI-VAT", "OR-NV", "OR-VAT"})
        Me.cbb_receipt.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cbb_receipt.Size = New System.Drawing.Size(87, 21)
        Me.cbb_receipt.TabIndex = 86
        '
        'btn_mark
        '
        Me.btn_mark.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_mark.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_mark.Appearance.Options.UseFont = True
        Me.btn_mark.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.checkbox_16x161
        Me.btn_mark.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_mark.Location = New System.Drawing.Point(20, 529)
        Me.btn_mark.Name = "btn_mark"
        Me.btn_mark.Size = New System.Drawing.Size(162, 32)
        Me.btn_mark.TabIndex = 85
        Me.btn_mark.Text = "Mark as Completed"
        '
        'btn_save
        '
        Me.btn_save.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_save.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.Appearance.Options.UseFont = True
        Me.btn_save.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.saveto_32x32
        Me.btn_save.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter
        Me.btn_save.Location = New System.Drawing.Point(947, 18)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(60, 60)
        Me.btn_save.TabIndex = 72
        Me.btn_save.Text = "Save"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(20, 30)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(69, 14)
        Me.LabelControl5.TabIndex = 69
        Me.LabelControl5.Text = "Purchase ID:"
        '
        'txt_poid
        '
        Me.txt_poid.Location = New System.Drawing.Point(96, 27)
        Me.txt_poid.Name = "txt_poid"
        Me.txt_poid.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_poid.Properties.Appearance.Options.UseFont = True
        Me.txt_poid.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_poid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txt_poid.Properties.ReadOnly = True
        Me.txt_poid.Size = New System.Drawing.Size(86, 20)
        Me.txt_poid.TabIndex = 70
        '
        'cbb_deliver
        '
        Me.cbb_deliver.Location = New System.Drawing.Point(96, 79)
        Me.cbb_deliver.Name = "cbb_deliver"
        Me.cbb_deliver.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cbb_deliver.Properties.Appearance.Options.UseFont = True
        Me.cbb_deliver.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_deliver.Properties.ReadOnly = True
        Me.cbb_deliver.Properties.UseReadOnlyAppearance = False
        Me.cbb_deliver.Size = New System.Drawing.Size(259, 20)
        Me.cbb_deliver.TabIndex = 65
        '
        'cbb_supplier
        '
        Me.cbb_supplier.Location = New System.Drawing.Point(96, 53)
        Me.cbb_supplier.Name = "cbb_supplier"
        Me.cbb_supplier.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cbb_supplier.Properties.Appearance.Options.UseFont = True
        Me.cbb_supplier.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_supplier.Properties.ReadOnly = True
        Me.cbb_supplier.Properties.UseReadOnlyAppearance = False
        Me.cbb_supplier.Size = New System.Drawing.Size(259, 20)
        Me.cbb_supplier.TabIndex = 43
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(22, 59)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(47, 14)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Supplier:"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(21, 85)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(56, 14)
        Me.LabelControl6.TabIndex = 49
        Me.LabelControl6.Text = "Deliver to:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Lavender
        Me.Panel1.Controls.Add(Me.lbl_head)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1073, 42)
        Me.Panel1.TabIndex = 54
        '
        'lbl_head
        '
        Me.lbl_head.AutoSize = True
        Me.lbl_head.Font = New System.Drawing.Font("Tahoma", 16.0!)
        Me.lbl_head.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lbl_head.Location = New System.Drawing.Point(12, 9)
        Me.lbl_head.Name = "lbl_head"
        Me.lbl_head.Size = New System.Drawing.Size(174, 27)
        Me.lbl_head.TabIndex = 0
        Me.lbl_head.Text = "Receive Delivery"
        '
        'frm_warehouse_SupplierDeliveries
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(1073, 644)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "frm_warehouse_SupplierDeliveries"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frm_warehouse_delivery_receive"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.dt_receipt.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_receipt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_order, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_search.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbb_discount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_return_credit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_discount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_count_by.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_amount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ref.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbb_receipt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_poid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbb_deliver.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbb_supplier.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_poid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cbb_deliver As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cbb_supplier As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_save As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_mark As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbb_receipt As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_ref As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_amount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_supid As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_print As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_count_by As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_return_credit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_discount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cbb_discount As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents withholding_tax_percentage As DevExpress.XtraEditors.LabelControl
    Friend WithEvents withholding_tax_amount As DevExpress.XtraEditors.LabelControl
    Friend WithEvents is_withholding_tax_applied As CheckBox
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl16 As LabelControl
    Friend WithEvents txt_search As TextEdit
    Friend WithEvents grid_order As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents col_sup_model As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents col_cost As DataGridViewTextBoxColumn
    Friend WithEvents col_total As DataGridViewTextBoxColumn
    Friend WithEvents col_tota_received As DataGridViewTextBoxColumn
    Friend WithEvents col_received As DataGridViewTextBoxColumn
    Friend WithEvents col_remaining_qty As DataGridViewTextBoxColumn
    Friend WithEvents dt_receipt As DateEdit
    Friend WithEvents LabelControl11 As LabelControl
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_head As Label
End Class
