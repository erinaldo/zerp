<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_accounting_payment_vouchers
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
        Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim EditorButtonImageOptions2 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject5 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject6 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject7 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject8 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.GunaPanel4 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaPanel5 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.link_po_list = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.link_home = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.grid_payments = New DevExpress.XtraGrid.GridControl()
        Me.grid_payments_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_payment_type = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_supplier = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_date_created = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_print = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btn_print = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.col_voucher_amount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_void = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btn_void = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.col_status = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GunaPanel4.SuspendLayout()
        Me.GunaPanel5.SuspendLayout()
        Me.GunaPanel1.SuspendLayout()
        CType(Me.grid_payments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_payments_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_print, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_void, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaPanel4
        '
        Me.GunaPanel4.BackColor = System.Drawing.Color.GhostWhite
        Me.GunaPanel4.Controls.Add(Me.GunaPanel5)
        Me.GunaPanel4.Controls.Add(Me.GunaLabel2)
        Me.GunaPanel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel4.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel4.Name = "GunaPanel4"
        Me.GunaPanel4.Size = New System.Drawing.Size(1103, 78)
        Me.GunaPanel4.TabIndex = 12
        '
        'GunaPanel5
        '
        Me.GunaPanel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaPanel5.BackColor = System.Drawing.Color.Transparent
        Me.GunaPanel5.Controls.Add(Me.GunaPanel1)
        Me.GunaPanel5.Location = New System.Drawing.Point(19, 44)
        Me.GunaPanel5.Name = "GunaPanel5"
        Me.GunaPanel5.Size = New System.Drawing.Size(1068, 27)
        Me.GunaPanel5.TabIndex = 5
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
        Me.GunaPanel1.TabIndex = 0
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
        Me.link_po_list.Size = New System.Drawing.Size(116, 18)
        Me.link_po_list.TabIndex = 7
        Me.link_po_list.Text = "Payment Vouchers"
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
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.GunaLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.GunaLabel2.Location = New System.Drawing.Point(14, 10)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(243, 31)
        Me.GunaLabel2.TabIndex = 1
        Me.GunaLabel2.Text = "Payment Vouchers"
        '
        'grid_payments
        '
        Me.grid_payments.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_payments.Location = New System.Drawing.Point(24, 101)
        Me.grid_payments.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grid_payments.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grid_payments.MainView = Me.grid_payments_view
        Me.grid_payments.Name = "grid_payments"
        Me.grid_payments.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.btn_print, Me.btn_void})
        Me.grid_payments.Size = New System.Drawing.Size(1057, 395)
        Me.grid_payments.TabIndex = 13
        Me.grid_payments.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_payments_view})
        '
        'grid_payments_view
        '
        Me.grid_payments_view.Appearance.HeaderPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.grid_payments_view.Appearance.HeaderPanel.Options.UseFont = True
        Me.grid_payments_view.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.grid_payments_view.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grid_payments_view.Appearance.Row.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_payments_view.Appearance.Row.Options.UseFont = True
        Me.grid_payments_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_id, Me.col_payment_type, Me.col_supplier, Me.col_date_created, Me.col_print, Me.col_voucher_amount, Me.col_void, Me.col_status})
        Me.grid_payments_view.GridControl = Me.grid_payments
        Me.grid_payments_view.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.grid_payments_view.Name = "grid_payments_view"
        Me.grid_payments_view.OptionsBehavior.ReadOnly = True
        Me.grid_payments_view.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.grid_payments_view.OptionsView.AutoCalcPreviewLineCount = True
        Me.grid_payments_view.OptionsView.ColumnAutoWidth = False
        Me.grid_payments_view.OptionsView.RowAutoHeight = True
        '
        'col_id
        '
        Me.col_id.AppearanceCell.Options.UseTextOptions = True
        Me.col_id.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_id.Caption = "Payment No."
        Me.col_id.FieldName = "payment_id"
        Me.col_id.Name = "col_id"
        Me.col_id.Visible = True
        Me.col_id.VisibleIndex = 0
        Me.col_id.Width = 113
        '
        'col_payment_type
        '
        Me.col_payment_type.Caption = "Payment Type"
        Me.col_payment_type.FieldName = "payment_type"
        Me.col_payment_type.Name = "col_payment_type"
        Me.col_payment_type.Visible = True
        Me.col_payment_type.VisibleIndex = 1
        Me.col_payment_type.Width = 101
        '
        'col_supplier
        '
        Me.col_supplier.Caption = "Supplier"
        Me.col_supplier.FieldName = "supplier"
        Me.col_supplier.Name = "col_supplier"
        Me.col_supplier.Visible = True
        Me.col_supplier.VisibleIndex = 2
        Me.col_supplier.Width = 323
        '
        'col_date_created
        '
        Me.col_date_created.AppearanceCell.Options.UseTextOptions = True
        Me.col_date_created.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_date_created.Caption = "Date"
        Me.col_date_created.DisplayFormat.FormatString = "MMMM dd, yyyy"
        Me.col_date_created.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col_date_created.FieldName = "creation_date"
        Me.col_date_created.Name = "col_date_created"
        Me.col_date_created.Visible = True
        Me.col_date_created.VisibleIndex = 3
        Me.col_date_created.Width = 128
        '
        'col_print
        '
        Me.col_print.Caption = "Print"
        Me.col_print.ColumnEdit = Me.btn_print
        Me.col_print.Name = "col_print"
        Me.col_print.OptionsColumn.FixedWidth = True
        Me.col_print.Visible = True
        Me.col_print.VisibleIndex = 6
        '
        'btn_print
        '
        Me.btn_print.AutoHeight = False
        EditorButtonImageOptions1.Image = Global.Inventory_Management.My.Resources.Resources.print_16x16
        Me.btn_print.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.btn_print.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_print.Name = "btn_print"
        Me.btn_print.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'col_voucher_amount
        '
        Me.col_voucher_amount.Caption = "Amount"
        Me.col_voucher_amount.DisplayFormat.FormatString = "n2"
        Me.col_voucher_amount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_voucher_amount.FieldName = "voucher_amount"
        Me.col_voucher_amount.MaxWidth = 120
        Me.col_voucher_amount.MinWidth = 120
        Me.col_voucher_amount.Name = "col_voucher_amount"
        Me.col_voucher_amount.Visible = True
        Me.col_voucher_amount.VisibleIndex = 4
        Me.col_voucher_amount.Width = 120
        '
        'col_void
        '
        Me.col_void.Caption = "Void"
        Me.col_void.ColumnEdit = Me.btn_void
        Me.col_void.Name = "col_void"
        Me.col_void.Visible = True
        Me.col_void.VisibleIndex = 7
        '
        'btn_void
        '
        Me.btn_void.AutoHeight = False
        EditorButtonImageOptions2.SvgImage = Global.Inventory_Management.My.Resources.Resources.actions_forbid
        EditorButtonImageOptions2.SvgImageSize = New System.Drawing.Size(20, 20)
        Me.btn_void.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions2, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, SerializableAppearanceObject6, SerializableAppearanceObject7, SerializableAppearanceObject8, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.btn_void.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_void.Name = "btn_void"
        Me.btn_void.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'col_status
        '
        Me.col_status.AppearanceCell.Options.UseTextOptions = True
        Me.col_status.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_status.Caption = "Status"
        Me.col_status.FieldName = "voucher_status"
        Me.col_status.Name = "col_status"
        Me.col_status.Visible = True
        Me.col_status.VisibleIndex = 5
        Me.col_status.Width = 94
        '
        'frm_accounting_payment_vouchers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1103, 514)
        Me.Controls.Add(Me.grid_payments)
        Me.Controls.Add(Me.GunaPanel4)
        Me.Name = "frm_accounting_payment_vouchers"
        Me.Text = "frm_accounting_payment_vouchers"
        Me.GunaPanel4.ResumeLayout(False)
        Me.GunaPanel4.PerformLayout()
        Me.GunaPanel5.ResumeLayout(False)
        Me.GunaPanel1.ResumeLayout(False)
        Me.GunaPanel1.PerformLayout()
        CType(Me.grid_payments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_payments_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_print, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_void, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaPanel4 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPanel5 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents link_po_list As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents link_home As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents grid_payments As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_payments_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_supplier As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_date_created As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_print As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_print As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents col_payment_type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_voucher_amount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_void As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_void As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents col_status As DevExpress.XtraGrid.Columns.GridColumn
End Class
