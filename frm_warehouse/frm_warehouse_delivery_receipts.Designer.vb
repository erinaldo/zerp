<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_warehouse_delivery_receipts
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_warehouse_delivery_receipts))
        Me.txt_ref = New DevExpress.XtraEditors.TextEdit()
        Me.cbb_type = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cbb_suppliers = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.btn_open = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.grid_receipt = New System.Windows.Forms.DataGridView()
        Me.col_add_qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_qty_received = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_model = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_cost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_reference = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_product_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_update = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        CType(Me.txt_ref.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbb_type.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbb_suppliers.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.grid_receipt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_ref
        '
        Me.txt_ref.Location = New System.Drawing.Point(120, 41)
        Me.txt_ref.Name = "txt_ref"
        Me.txt_ref.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.txt_ref.Properties.Appearance.Options.UseFont = True
        Me.txt_ref.Size = New System.Drawing.Size(152, 22)
        Me.txt_ref.TabIndex = 0
        '
        'cbb_type
        '
        Me.cbb_type.EditValue = "-- Type --"
        Me.cbb_type.Location = New System.Drawing.Point(120, 69)
        Me.cbb_type.Name = "cbb_type"
        Me.cbb_type.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.cbb_type.Properties.Appearance.Options.UseFont = True
        Me.cbb_type.Properties.Appearance.Options.UseTextOptions = True
        Me.cbb_type.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.cbb_type.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_type.Properties.Items.AddRange(New Object() {"-- Type --", "DR", "SI-NV", "SI-VAT", "OR-NV", "OR-VAT"})
        Me.cbb_type.Properties.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.cbb_type.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cbb_type.Size = New System.Drawing.Size(152, 22)
        Me.cbb_type.TabIndex = 1
        '
        'cbb_suppliers
        '
        Me.cbb_suppliers.EditValue = "-- Supplier --"
        Me.cbb_suppliers.Location = New System.Drawing.Point(120, 97)
        Me.cbb_suppliers.Name = "cbb_suppliers"
        Me.cbb_suppliers.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.cbb_suppliers.Properties.Appearance.Options.UseFont = True
        Me.cbb_suppliers.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_suppliers.Properties.Items.AddRange(New Object() {"-- Supplier --"})
        Me.cbb_suppliers.Properties.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.cbb_suppliers.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cbb_suppliers.Size = New System.Drawing.Size(273, 22)
        Me.cbb_suppliers.TabIndex = 2
        '
        'btn_open
        '
        Me.btn_open.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btn_open.Appearance.Options.UseFont = True
        Me.btn_open.Location = New System.Drawing.Point(455, 127)
        Me.btn_open.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_open.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_open.Name = "btn_open"
        Me.btn_open.Size = New System.Drawing.Size(102, 29)
        Me.btn_open.TabIndex = 3
        Me.btn_open.Text = "Pull Data"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Appearance.Options.UseTextOptions = True
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.LabelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl1.Location = New System.Drawing.Point(31, 23)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(272, 31)
        Me.LabelControl1.TabIndex = 4
        Me.LabelControl1.Text = "Open Delivery Receipt"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.LabelControl1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(626, 68)
        Me.Panel1.TabIndex = 5
        '
        'grid_receipt
        '
        Me.grid_receipt.AllowUserToAddRows = False
        Me.grid_receipt.AllowUserToDeleteRows = False
        Me.grid_receipt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_receipt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.grid_receipt.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.grid_receipt.BackgroundColor = System.Drawing.Color.GhostWhite
        Me.grid_receipt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_receipt.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grid_receipt.ColumnHeadersHeight = 28
        Me.grid_receipt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.grid_receipt.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_add_qty, Me.col_qty_received, Me.col_model, Me.col_description, Me.col_cost, Me.col_reference, Me.col_product_no})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Tahoma", 8.25!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(78, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grid_receipt.DefaultCellStyle = DataGridViewCellStyle6
        Me.grid_receipt.EnableHeadersVisualStyles = False
        Me.grid_receipt.Location = New System.Drawing.Point(31, 260)
        Me.grid_receipt.Name = "grid_receipt"
        Me.grid_receipt.RowHeadersVisible = False
        Me.grid_receipt.Size = New System.Drawing.Size(569, 290)
        Me.grid_receipt.TabIndex = 59
        '
        'col_add_qty
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.NullValue = "0"
        Me.col_add_qty.DefaultCellStyle = DataGridViewCellStyle2
        Me.col_add_qty.HeaderText = "Additional"
        Me.col_add_qty.Name = "col_add_qty"
        Me.col_add_qty.Width = 79
        '
        'col_qty_received
        '
        Me.col_qty_received.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.col_qty_received.DataPropertyName = "qty"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.col_qty_received.DefaultCellStyle = DataGridViewCellStyle3
        Me.col_qty_received.FillWeight = 125.0!
        Me.col_qty_received.HeaderText = "Qty"
        Me.col_qty_received.Name = "col_qty_received"
        Me.col_qty_received.ReadOnly = True
        Me.col_qty_received.Width = 80
        '
        'col_model
        '
        Me.col_model.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.col_model.DataPropertyName = "winmodel"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.col_model.DefaultCellStyle = DataGridViewCellStyle4
        Me.col_model.FillWeight = 73.71088!
        Me.col_model.HeaderText = "Model"
        Me.col_model.Name = "col_model"
        Me.col_model.ReadOnly = True
        Me.col_model.Width = 125
        '
        'col_description
        '
        Me.col_description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.col_description.DataPropertyName = "description"
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.col_description.DefaultCellStyle = DataGridViewCellStyle5
        Me.col_description.HeaderText = "Description"
        Me.col_description.Name = "col_description"
        Me.col_description.ReadOnly = True
        '
        'col_cost
        '
        Me.col_cost.DataPropertyName = "cost"
        Me.col_cost.HeaderText = "Cost"
        Me.col_cost.Name = "col_cost"
        Me.col_cost.Visible = False
        Me.col_cost.Width = 54
        '
        'col_reference
        '
        Me.col_reference.DataPropertyName = "reference"
        Me.col_reference.HeaderText = "reference"
        Me.col_reference.Name = "col_reference"
        Me.col_reference.Visible = False
        Me.col_reference.Width = 79
        '
        'col_product_no
        '
        Me.col_product_no.DataPropertyName = "item"
        Me.col_product_no.HeaderText = "Product No"
        Me.col_product_no.Name = "col_product_no"
        Me.col_product_no.Visible = False
        Me.col_product_no.Width = 85
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(29, 101)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(48, 13)
        Me.LabelControl4.TabIndex = 6
        Me.LabelControl4.Text = "*Supplier:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(29, 72)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(73, 13)
        Me.LabelControl3.TabIndex = 5
        Me.LabelControl3.Text = "*Receipt Type:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(25, 45)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(80, 13)
        Me.LabelControl2.TabIndex = 4
        Me.LabelControl2.Text = "*Reference No.:"
        '
        'btn_update
        '
        Me.btn_update.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_update.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btn_update.Appearance.Options.UseFont = True
        Me.btn_update.Location = New System.Drawing.Point(472, 559)
        Me.btn_update.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_update.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(128, 34)
        Me.btn_update.TabIndex = 61
        Me.btn_update.Text = "Update Receipt"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.txt_ref)
        Me.GroupControl1.Controls.Add(Me.btn_open)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.cbb_suppliers)
        Me.GroupControl1.Controls.Add(Me.cbb_type)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Location = New System.Drawing.Point(31, 84)
        Me.GroupControl1.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.GroupControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(569, 166)
        Me.GroupControl1.TabIndex = 64
        Me.GroupControl1.Text = "Receipt Details"
        '
        'frm_warehouse_delivery_receipts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(626, 605)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.grid_receipt)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(642, 620)
        Me.Name = "frm_warehouse_delivery_receipts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Open Delivery Receipt"
        CType(Me.txt_ref.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbb_type.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbb_suppliers.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.grid_receipt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txt_ref As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cbb_type As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cbb_suppliers As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents btn_open As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel1 As Panel
    Friend WithEvents grid_receipt As DataGridView
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_update As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents col_add_qty As DataGridViewTextBoxColumn
    Friend WithEvents col_qty_received As DataGridViewTextBoxColumn
    Friend WithEvents col_model As DataGridViewTextBoxColumn
    Friend WithEvents col_description As DataGridViewTextBoxColumn
    Friend WithEvents col_cost As DataGridViewTextBoxColumn
    Friend WithEvents col_reference As DataGridViewTextBoxColumn
    Friend WithEvents col_product_no As DataGridViewTextBoxColumn
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
End Class
