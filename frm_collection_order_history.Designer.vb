<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_collection_order_history
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_collection_order_history))
        Me.GunaPanel2 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaPanel3 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaPanel4 = New Guna.UI.WinForms.GunaPanel()
        Me.HyperlinkLabelControl1 = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.HyperlinkLabelControl2 = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grid_cash_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_order_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_customer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn23 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_amount_due = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_payment_type = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn24 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grid_cash = New DevExpress.XtraGrid.GridControl()
        Me.txt_total = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.GunaPanel2.SuspendLayout()
        Me.GunaPanel3.SuspendLayout()
        Me.GunaPanel4.SuspendLayout()
        CType(Me.grid_cash_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_cash, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_total.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaPanel2
        '
        Me.GunaPanel2.BackColor = System.Drawing.Color.GhostWhite
        Me.GunaPanel2.Controls.Add(Me.GunaPanel3)
        Me.GunaPanel2.Controls.Add(Me.GunaLabel1)
        Me.GunaPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel2.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel2.Name = "GunaPanel2"
        Me.GunaPanel2.Size = New System.Drawing.Size(862, 78)
        Me.GunaPanel2.TabIndex = 14
        '
        'GunaPanel3
        '
        Me.GunaPanel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaPanel3.BackColor = System.Drawing.Color.Transparent
        Me.GunaPanel3.Controls.Add(Me.GunaPanel4)
        Me.GunaPanel3.Location = New System.Drawing.Point(19, 44)
        Me.GunaPanel3.Name = "GunaPanel3"
        Me.GunaPanel3.Size = New System.Drawing.Size(844, 27)
        Me.GunaPanel3.TabIndex = 5
        '
        'GunaPanel4
        '
        Me.GunaPanel4.Controls.Add(Me.HyperlinkLabelControl1)
        Me.GunaPanel4.Controls.Add(Me.LabelControl6)
        Me.GunaPanel4.Controls.Add(Me.HyperlinkLabelControl2)
        Me.GunaPanel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.GunaPanel4.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel4.Name = "GunaPanel4"
        Me.GunaPanel4.Size = New System.Drawing.Size(435, 27)
        Me.GunaPanel4.TabIndex = 1
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
        Me.HyperlinkLabelControl1.Size = New System.Drawing.Size(141, 18)
        Me.HyperlinkLabelControl1.TabIndex = 7
        Me.HyperlinkLabelControl1.Text = "Payment Order History"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(55, 7)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(9, 14)
        Me.LabelControl6.TabIndex = 6
        Me.LabelControl6.Text = ">"
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
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.GunaLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.GunaLabel1.Location = New System.Drawing.Point(14, 10)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(290, 31)
        Me.GunaLabel1.TabIndex = 1
        Me.GunaLabel1.Text = "Payment Order History"
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "GridColumn1"
        Me.GridColumn1.FieldName = "payment_type"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 4
        Me.GridColumn1.Width = 145
        '
        'grid_cash_view
        '
        Me.grid_cash_view.Appearance.HeaderPanel.BackColor = System.Drawing.Color.White
        Me.grid_cash_view.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grid_cash_view.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grid_cash_view.Appearance.HeaderPanel.Options.UseFont = True
        Me.grid_cash_view.Appearance.Row.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.grid_cash_view.Appearance.Row.Options.UseFont = True
        Me.grid_cash_view.Appearance.SelectedRow.BackColor = System.Drawing.Color.White
        Me.grid_cash_view.Appearance.SelectedRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.grid_cash_view.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grid_cash_view.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grid_cash_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_order_id, Me.GridColumn3, Me.col_customer, Me.GridColumn4, Me.GridColumn23, Me.col_amount_due, Me.col_payment_type, Me.GridColumn24, Me.GridColumn18})
        Me.grid_cash_view.GridControl = Me.grid_cash
        Me.grid_cash_view.Name = "grid_cash_view"
        Me.grid_cash_view.OptionsBehavior.Editable = False
        Me.grid_cash_view.OptionsBehavior.ReadOnly = True
        Me.grid_cash_view.OptionsSelection.ResetSelectionClickOutsideCheckboxSelector = True
        Me.grid_cash_view.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.[False]
        '
        'col_order_id
        '
        Me.col_order_id.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.col_order_id.AppearanceCell.Options.UseForeColor = True
        Me.col_order_id.AppearanceCell.Options.UseTextOptions = True
        Me.col_order_id.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_order_id.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.col_order_id.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.col_order_id.AppearanceHeader.Options.UseFont = True
        Me.col_order_id.AppearanceHeader.Options.UseForeColor = True
        Me.col_order_id.AppearanceHeader.Options.UseTextOptions = True
        Me.col_order_id.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_order_id.Caption = "Order ID"
        Me.col_order_id.FieldName = "order_id"
        Me.col_order_id.MaxWidth = 100
        Me.col_order_id.MinWidth = 50
        Me.col_order_id.Name = "col_order_id"
        Me.col_order_id.Visible = True
        Me.col_order_id.VisibleIndex = 0
        Me.col_order_id.Width = 82
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn3.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.GridColumn3.AppearanceHeader.Options.UseFont = True
        Me.GridColumn3.AppearanceHeader.Options.UseForeColor = True
        Me.GridColumn3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.Caption = "Agent"
        Me.GridColumn3.FieldName = "agent"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 5
        Me.GridColumn3.Width = 140
        '
        'col_customer
        '
        Me.col_customer.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.col_customer.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.col_customer.AppearanceHeader.Options.UseFont = True
        Me.col_customer.AppearanceHeader.Options.UseForeColor = True
        Me.col_customer.AppearanceHeader.Options.UseTextOptions = True
        Me.col_customer.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_customer.Caption = "Customer"
        Me.col_customer.FieldName = "customer"
        Me.col_customer.MinWidth = 50
        Me.col_customer.Name = "col_customer"
        Me.col_customer.Visible = True
        Me.col_customer.VisibleIndex = 4
        Me.col_customer.Width = 143
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn4.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn4.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.GridColumn4.AppearanceHeader.Options.UseFont = True
        Me.GridColumn4.AppearanceHeader.Options.UseForeColor = True
        Me.GridColumn4.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn4.Caption = "Order Date"
        Me.GridColumn4.FieldName = "date_ordered"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 1
        Me.GridColumn4.Width = 128
        '
        'GridColumn23
        '
        Me.GridColumn23.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn23.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.GridColumn23.AppearanceHeader.Options.UseFont = True
        Me.GridColumn23.AppearanceHeader.Options.UseForeColor = True
        Me.GridColumn23.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn23.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn23.Caption = "Ship Type"
        Me.GridColumn23.FieldName = "shipping_method"
        Me.GridColumn23.Name = "GridColumn23"
        Me.GridColumn23.Visible = True
        Me.GridColumn23.VisibleIndex = 2
        Me.GridColumn23.Width = 132
        '
        'col_amount_due
        '
        Me.col_amount_due.AppearanceCell.Options.UseTextOptions = True
        Me.col_amount_due.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_amount_due.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.col_amount_due.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.col_amount_due.AppearanceHeader.Options.UseFont = True
        Me.col_amount_due.AppearanceHeader.Options.UseForeColor = True
        Me.col_amount_due.AppearanceHeader.Options.UseTextOptions = True
        Me.col_amount_due.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_amount_due.Caption = "Amount Due"
        Me.col_amount_due.DisplayFormat.FormatString = "c2"
        Me.col_amount_due.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_amount_due.FieldName = "amount_due"
        Me.col_amount_due.MaxWidth = 200
        Me.col_amount_due.Name = "col_amount_due"
        Me.col_amount_due.Visible = True
        Me.col_amount_due.VisibleIndex = 6
        Me.col_amount_due.Width = 191
        '
        'col_payment_type
        '
        Me.col_payment_type.Caption = "Payment Type"
        Me.col_payment_type.FieldName = "payment_type"
        Me.col_payment_type.Name = "col_payment_type"
        Me.col_payment_type.Visible = True
        Me.col_payment_type.VisibleIndex = 3
        Me.col_payment_type.Width = 145
        '
        'GridColumn24
        '
        Me.GridColumn24.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn24.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.GridColumn24.AppearanceHeader.Options.UseFont = True
        Me.GridColumn24.AppearanceHeader.Options.UseForeColor = True
        Me.GridColumn24.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn24.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn24.Caption = "Status"
        Me.GridColumn24.FieldName = "status"
        Me.GridColumn24.Name = "GridColumn24"
        Me.GridColumn24.Width = 119
        '
        'GridColumn18
        '
        Me.GridColumn18.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn18.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn18.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn18.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.GridColumn18.AppearanceHeader.Options.UseFont = True
        Me.GridColumn18.AppearanceHeader.Options.UseForeColor = True
        Me.GridColumn18.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn18.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn18.Caption = "Payment Status"
        Me.GridColumn18.FieldName = "payment_status"
        Me.GridColumn18.Name = "GridColumn18"
        Me.GridColumn18.Width = 136
        '
        'grid_cash
        '
        Me.grid_cash.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_cash.Location = New System.Drawing.Point(20, 98)
        Me.grid_cash.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grid_cash.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grid_cash.MainView = Me.grid_cash_view
        Me.grid_cash.Name = "grid_cash"
        Me.grid_cash.Size = New System.Drawing.Size(822, 438)
        Me.grid_cash.TabIndex = 15
        Me.grid_cash.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_cash_view})
        '
        'txt_total
        '
        Me.txt_total.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_total.EditValue = ""
        Me.txt_total.Location = New System.Drawing.Point(662, 543)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Properties.Appearance.Font = New System.Drawing.Font("Consolas", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txt_total.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.txt_total.Properties.Appearance.Options.UseFont = True
        Me.txt_total.Properties.Appearance.Options.UseForeColor = True
        Me.txt_total.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_total.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_total.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.txt_total.Size = New System.Drawing.Size(180, 30)
        Me.txt_total.TabIndex = 28
        '
        'LabelControl1
        '
        Me.LabelControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(600, 546)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(54, 22)
        Me.LabelControl1.TabIndex = 27
        Me.LabelControl1.Text = "Total:"
        '
        'frm_collection_order_history
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(862, 585)
        Me.Controls.Add(Me.txt_total)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.grid_cash)
        Me.Controls.Add(Me.GunaPanel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_collection_order_history"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payment Order History"
        Me.GunaPanel2.ResumeLayout(False)
        Me.GunaPanel2.PerformLayout()
        Me.GunaPanel3.ResumeLayout(False)
        Me.GunaPanel4.ResumeLayout(False)
        Me.GunaPanel4.PerformLayout()
        CType(Me.grid_cash_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_cash, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_total.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaPanel2 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPanel3 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPanel4 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents HyperlinkLabelControl1 As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents HyperlinkLabelControl2 As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grid_cash_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_order_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_customer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn23 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_amount_due As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn24 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_payment_type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grid_cash As DevExpress.XtraGrid.GridControl
    Friend WithEvents txt_total As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
End Class
