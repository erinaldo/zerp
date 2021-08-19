<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_accounting_view_transaction
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_accounting_view_transaction))
        Me.grid_transaction = New DevExpress.XtraGrid.GridControl()
        Me.grid_transaction_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_qty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_winmodel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_supmodel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_description = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_cost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_total_cost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btn_close = New DevExpress.XtraEditors.SimpleButton()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.txt_counted_by = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_encoded_by = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_received_date = New DevExpress.XtraEditors.TextEdit()
        Me.txt_purchaseID = New DevExpress.XtraEditors.TextEdit()
        Me.txt_supplier = New DevExpress.XtraEditors.TextEdit()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.lbl_type = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_ref = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_total = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_discount = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_returned_credit = New DevExpress.XtraEditors.LabelControl()
        Me.txt_sub_total = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_ewt = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.grid_transaction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_transaction_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txt_counted_by.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_encoded_by.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_received_date.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_purchaseID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_supplier.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.txt_total.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grid_transaction
        '
        Me.grid_transaction.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_transaction.Location = New System.Drawing.Point(12, 147)
        Me.grid_transaction.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grid_transaction.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grid_transaction.MainView = Me.grid_transaction_view
        Me.grid_transaction.Name = "grid_transaction"
        Me.grid_transaction.Size = New System.Drawing.Size(1020, 422)
        Me.grid_transaction.TabIndex = 13
        Me.grid_transaction.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_transaction_view})
        '
        'grid_transaction_view
        '
        Me.grid_transaction_view.Appearance.HeaderPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.grid_transaction_view.Appearance.HeaderPanel.Options.UseFont = True
        Me.grid_transaction_view.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.grid_transaction_view.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grid_transaction_view.Appearance.Row.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_transaction_view.Appearance.Row.Options.UseFont = True
        Me.grid_transaction_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_qty, Me.col_winmodel, Me.col_supmodel, Me.col_description, Me.col_cost, Me.col_total_cost})
        Me.grid_transaction_view.GridControl = Me.grid_transaction
        Me.grid_transaction_view.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.grid_transaction_view.Name = "grid_transaction_view"
        Me.grid_transaction_view.OptionsBehavior.ReadOnly = True
        Me.grid_transaction_view.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.grid_transaction_view.OptionsView.AutoCalcPreviewLineCount = True
        Me.grid_transaction_view.OptionsView.ColumnAutoWidth = False
        Me.grid_transaction_view.OptionsView.RowAutoHeight = True
        '
        'col_qty
        '
        Me.col_qty.AppearanceCell.Options.UseTextOptions = True
        Me.col_qty.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_qty.Caption = "Qty"
        Me.col_qty.FieldName = "qty"
        Me.col_qty.Name = "col_qty"
        Me.col_qty.Visible = True
        Me.col_qty.VisibleIndex = 0
        Me.col_qty.Width = 64
        '
        'col_winmodel
        '
        Me.col_winmodel.Caption = "Win. Model"
        Me.col_winmodel.FieldName = "winmodel"
        Me.col_winmodel.Name = "col_winmodel"
        Me.col_winmodel.Visible = True
        Me.col_winmodel.VisibleIndex = 1
        Me.col_winmodel.Width = 148
        '
        'col_supmodel
        '
        Me.col_supmodel.Caption = "Sup. Model"
        Me.col_supmodel.FieldName = "supmodel"
        Me.col_supmodel.Name = "col_supmodel"
        Me.col_supmodel.Visible = True
        Me.col_supmodel.VisibleIndex = 2
        Me.col_supmodel.Width = 162
        '
        'col_description
        '
        Me.col_description.Caption = "Description"
        Me.col_description.FieldName = "description"
        Me.col_description.Name = "col_description"
        Me.col_description.Visible = True
        Me.col_description.VisibleIndex = 3
        Me.col_description.Width = 444
        '
        'col_cost
        '
        Me.col_cost.Caption = "Item Cost"
        Me.col_cost.DisplayFormat.FormatString = "c2"
        Me.col_cost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_cost.FieldName = "cost"
        Me.col_cost.Name = "col_cost"
        Me.col_cost.Visible = True
        Me.col_cost.VisibleIndex = 4
        '
        'col_total_cost
        '
        Me.col_total_cost.Caption = "Total Cost"
        Me.col_total_cost.DisplayFormat.FormatString = "c2"
        Me.col_total_cost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_total_cost.FieldName = "total_cost"
        Me.col_total_cost.Name = "col_total_cost"
        Me.col_total_cost.Visible = True
        Me.col_total_cost.VisibleIndex = 5
        Me.col_total_cost.Width = 109
        '
        'btn_close
        '
        Me.btn_close.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_close.Location = New System.Drawing.Point(12, 701)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(99, 33)
        Me.btn_close.TabIndex = 14
        Me.btn_close.Text = "Close"
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Cheque No."
        Me.GridColumn1.FieldName = "payment_cheque"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 1
        Me.GridColumn1.Width = 148
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(16, 46)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(42, 13)
        Me.LabelControl1.TabIndex = 15
        Me.LabelControl1.Text = "Supplier:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(23, 16)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(99, 18)
        Me.LabelControl2.TabIndex = 16
        Me.LabelControl2.Text = "Receipt Ref.#:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(24, 40)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(96, 18)
        Me.LabelControl3.TabIndex = 17
        Me.LabelControl3.Text = "Receipt Type:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(220, 20)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(74, 13)
        Me.LabelControl4.TabIndex = 18
        Me.LabelControl4.Text = "Received Date:"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(16, 20)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(62, 13)
        Me.LabelControl5.TabIndex = 19
        Me.LabelControl5.Text = "Purchase ID:"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.txt_counted_by)
        Me.PanelControl1.Controls.Add(Me.LabelControl9)
        Me.PanelControl1.Controls.Add(Me.txt_encoded_by)
        Me.PanelControl1.Controls.Add(Me.LabelControl8)
        Me.PanelControl1.Controls.Add(Me.txt_received_date)
        Me.PanelControl1.Controls.Add(Me.txt_purchaseID)
        Me.PanelControl1.Controls.Add(Me.txt_supplier)
        Me.PanelControl1.Controls.Add(Me.LabelControl5)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.LabelControl4)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 66)
        Me.PanelControl1.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.PanelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(733, 75)
        Me.PanelControl1.TabIndex = 20
        '
        'txt_counted_by
        '
        Me.txt_counted_by.Location = New System.Drawing.Point(547, 41)
        Me.txt_counted_by.Name = "txt_counted_by"
        Me.txt_counted_by.Properties.ReadOnly = True
        Me.txt_counted_by.Properties.UseReadOnlyAppearance = False
        Me.txt_counted_by.Size = New System.Drawing.Size(158, 20)
        Me.txt_counted_by.TabIndex = 28
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(461, 44)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(60, 13)
        Me.LabelControl9.TabIndex = 27
        Me.LabelControl9.Text = "Counted by:"
        '
        'txt_encoded_by
        '
        Me.txt_encoded_by.Location = New System.Drawing.Point(547, 15)
        Me.txt_encoded_by.Name = "txt_encoded_by"
        Me.txt_encoded_by.Properties.ReadOnly = True
        Me.txt_encoded_by.Properties.UseReadOnlyAppearance = False
        Me.txt_encoded_by.Size = New System.Drawing.Size(158, 20)
        Me.txt_encoded_by.TabIndex = 26
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(461, 18)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(60, 13)
        Me.LabelControl8.TabIndex = 25
        Me.LabelControl8.Text = "Encoded by:"
        '
        'txt_received_date
        '
        Me.txt_received_date.Location = New System.Drawing.Point(305, 17)
        Me.txt_received_date.Name = "txt_received_date"
        Me.txt_received_date.Properties.ReadOnly = True
        Me.txt_received_date.Properties.UseReadOnlyAppearance = False
        Me.txt_received_date.Size = New System.Drawing.Size(96, 20)
        Me.txt_received_date.TabIndex = 22
        '
        'txt_purchaseID
        '
        Me.txt_purchaseID.Location = New System.Drawing.Point(101, 17)
        Me.txt_purchaseID.Name = "txt_purchaseID"
        Me.txt_purchaseID.Properties.ReadOnly = True
        Me.txt_purchaseID.Properties.UseReadOnlyAppearance = False
        Me.txt_purchaseID.Size = New System.Drawing.Size(96, 20)
        Me.txt_purchaseID.TabIndex = 21
        '
        'txt_supplier
        '
        Me.txt_supplier.Location = New System.Drawing.Point(101, 43)
        Me.txt_supplier.Name = "txt_supplier"
        Me.txt_supplier.Properties.ReadOnly = True
        Me.txt_supplier.Properties.UseReadOnlyAppearance = False
        Me.txt_supplier.Size = New System.Drawing.Size(300, 20)
        Me.txt_supplier.TabIndex = 20
        '
        'PanelControl2
        '
        Me.PanelControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl2.Controls.Add(Me.LabelControl2)
        Me.PanelControl2.Controls.Add(Me.LabelControl3)
        Me.PanelControl2.Controls.Add(Me.lbl_type)
        Me.PanelControl2.Controls.Add(Me.lbl_ref)
        Me.PanelControl2.Location = New System.Drawing.Point(754, 66)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(278, 75)
        Me.PanelControl2.TabIndex = 29
        '
        'lbl_type
        '
        Me.lbl_type.Appearance.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_type.Appearance.Options.UseFont = True
        Me.lbl_type.Location = New System.Drawing.Point(143, 40)
        Me.lbl_type.Name = "lbl_type"
        Me.lbl_type.Size = New System.Drawing.Size(38, 19)
        Me.lbl_type.TabIndex = 24
        Me.lbl_type.Text = "Type"
        '
        'lbl_ref
        '
        Me.lbl_ref.Appearance.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_ref.Appearance.Options.UseFont = True
        Me.lbl_ref.Location = New System.Drawing.Point(143, 16)
        Me.lbl_ref.Name = "lbl_ref"
        Me.lbl_ref.Size = New System.Drawing.Size(54, 19)
        Me.lbl_ref.TabIndex = 23
        Me.lbl_ref.Text = "123456"
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!)
        Me.LabelControl10.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.LabelControl10.Appearance.Options.UseFont = True
        Me.LabelControl10.Appearance.Options.UseForeColor = True
        Me.LabelControl10.Location = New System.Drawing.Point(12, 19)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(197, 33)
        Me.LabelControl10.TabIndex = 21
        Me.LabelControl10.Text = "Receipt Details"
        '
        'LabelControl6
        '
        Me.LabelControl6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl6.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Appearance.Options.UseForeColor = True
        Me.LabelControl6.Location = New System.Drawing.Point(715, 712)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(131, 22)
        Me.LabelControl6.TabIndex = 24
        Me.LabelControl6.Text = "Total Amount:"
        '
        'txt_total
        '
        Me.txt_total.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_total.EditValue = ""
        Me.txt_total.Location = New System.Drawing.Point(852, 708)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Properties.Appearance.Font = New System.Drawing.Font("Consolas", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txt_total.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.txt_total.Properties.Appearance.Options.UseFont = True
        Me.txt_total.Properties.Appearance.Options.UseForeColor = True
        Me.txt_total.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_total.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_total.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.txt_total.Size = New System.Drawing.Size(180, 30)
        Me.txt_total.TabIndex = 26
        '
        'LabelControl7
        '
        Me.LabelControl7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Italic)
        Me.LabelControl7.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Appearance.Options.UseForeColor = True
        Me.LabelControl7.Location = New System.Drawing.Point(790, 683)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(90, 15)
        Me.LabelControl7.TabIndex = 27
        Me.LabelControl7.Text = "Returned Credit:"
        '
        'LabelControl11
        '
        Me.LabelControl11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Italic)
        Me.LabelControl11.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.LabelControl11.Appearance.Options.UseFont = True
        Me.LabelControl11.Appearance.Options.UseForeColor = True
        Me.LabelControl11.Location = New System.Drawing.Point(790, 621)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(96, 15)
        Me.LabelControl11.TabIndex = 28
        Me.LabelControl11.Text = "Discount Applied:"
        '
        'lbl_discount
        '
        Me.lbl_discount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_discount.Appearance.BackColor = System.Drawing.Color.White
        Me.lbl_discount.Appearance.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lbl_discount.Appearance.ForeColor = System.Drawing.Color.Crimson
        Me.lbl_discount.Appearance.Options.UseBackColor = True
        Me.lbl_discount.Appearance.Options.UseFont = True
        Me.lbl_discount.Appearance.Options.UseForeColor = True
        Me.lbl_discount.Appearance.Options.UseTextOptions = True
        Me.lbl_discount.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_discount.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_discount.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.lbl_discount.Location = New System.Drawing.Point(897, 615)
        Me.lbl_discount.Name = "lbl_discount"
        Me.lbl_discount.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.lbl_discount.Size = New System.Drawing.Size(135, 25)
        Me.lbl_discount.TabIndex = 29
        Me.lbl_discount.Text = "_discount"
        '
        'lbl_returned_credit
        '
        Me.lbl_returned_credit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_returned_credit.Appearance.BackColor = System.Drawing.Color.White
        Me.lbl_returned_credit.Appearance.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lbl_returned_credit.Appearance.ForeColor = System.Drawing.Color.Crimson
        Me.lbl_returned_credit.Appearance.Options.UseBackColor = True
        Me.lbl_returned_credit.Appearance.Options.UseFont = True
        Me.lbl_returned_credit.Appearance.Options.UseForeColor = True
        Me.lbl_returned_credit.Appearance.Options.UseTextOptions = True
        Me.lbl_returned_credit.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_returned_credit.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_returned_credit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.lbl_returned_credit.Location = New System.Drawing.Point(897, 677)
        Me.lbl_returned_credit.Name = "lbl_returned_credit"
        Me.lbl_returned_credit.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.lbl_returned_credit.Size = New System.Drawing.Size(135, 25)
        Me.lbl_returned_credit.TabIndex = 30
        Me.lbl_returned_credit.Text = "0.00"
        '
        'txt_sub_total
        '
        Me.txt_sub_total.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_sub_total.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_sub_total.Appearance.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txt_sub_total.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.txt_sub_total.Appearance.Options.UseBackColor = True
        Me.txt_sub_total.Appearance.Options.UseFont = True
        Me.txt_sub_total.Appearance.Options.UseForeColor = True
        Me.txt_sub_total.Appearance.Options.UseTextOptions = True
        Me.txt_sub_total.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_sub_total.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.txt_sub_total.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.txt_sub_total.Location = New System.Drawing.Point(852, 584)
        Me.txt_sub_total.Name = "txt_sub_total"
        Me.txt_sub_total.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.txt_sub_total.Size = New System.Drawing.Size(180, 25)
        Me.txt_sub_total.TabIndex = 32
        Me.txt_sub_total.Text = "P10,00,000.00"
        '
        'LabelControl13
        '
        Me.LabelControl13.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl13.Appearance.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl13.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.LabelControl13.Appearance.Options.UseFont = True
        Me.LabelControl13.Appearance.Options.UseForeColor = True
        Me.LabelControl13.Location = New System.Drawing.Point(764, 588)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(72, 18)
        Me.LabelControl13.TabIndex = 31
        Me.LabelControl13.Text = "Sub Total:"
        '
        'txt_ewt
        '
        Me.txt_ewt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_ewt.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_ewt.Appearance.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txt_ewt.Appearance.ForeColor = System.Drawing.Color.Crimson
        Me.txt_ewt.Appearance.Options.UseBackColor = True
        Me.txt_ewt.Appearance.Options.UseFont = True
        Me.txt_ewt.Appearance.Options.UseForeColor = True
        Me.txt_ewt.Appearance.Options.UseTextOptions = True
        Me.txt_ewt.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_ewt.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.txt_ewt.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.txt_ewt.Location = New System.Drawing.Point(897, 646)
        Me.txt_ewt.Name = "txt_ewt"
        Me.txt_ewt.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.txt_ewt.Size = New System.Drawing.Size(135, 25)
        Me.txt_ewt.TabIndex = 34
        Me.txt_ewt.Text = "_ewt"
        '
        'LabelControl14
        '
        Me.LabelControl14.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl14.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Italic)
        Me.LabelControl14.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.LabelControl14.Appearance.Options.UseFont = True
        Me.LabelControl14.Appearance.Options.UseForeColor = True
        Me.LabelControl14.Location = New System.Drawing.Point(862, 652)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(29, 15)
        Me.LabelControl14.TabIndex = 33
        Me.LabelControl14.Text = "EWT:"
        '
        'frm_accounting_view_transaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(1044, 750)
        Me.Controls.Add(Me.txt_ewt)
        Me.Controls.Add(Me.LabelControl14)
        Me.Controls.Add(Me.txt_sub_total)
        Me.Controls.Add(Me.LabelControl13)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.lbl_returned_credit)
        Me.Controls.Add(Me.lbl_discount)
        Me.Controls.Add(Me.LabelControl11)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.txt_total)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.LabelControl10)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.grid_transaction)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_accounting_view_transaction"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View Transaction Details"
        CType(Me.grid_transaction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_transaction_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.txt_counted_by.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_encoded_by.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_received_date.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_purchaseID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_supplier.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.txt_total.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grid_transaction As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_transaction_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_description As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_winmodel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_close As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents col_supmodel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txt_counted_by As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_encoded_by As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_ref As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_type As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_received_date As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_purchaseID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_supplier As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents col_cost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_total_cost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_total As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_discount As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_returned_credit As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_sub_total As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_ewt As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
End Class
