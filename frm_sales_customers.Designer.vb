<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_sales_customers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_sales_customers))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.grid_customer = New DevExpress.XtraGrid.GridControl()
        Me.gridview_customer = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_fname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_contact_person = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_type = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_contact = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_addr = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_terms = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_shipping = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_trucking = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_credit_limit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_edit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btn_edit = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.panel_top = New Guna.UI.WinForms.GunaPanel()
        Me.GunaPanel3 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaPanel4 = New Guna.UI.WinForms.GunaPanel()
        Me.HyperlinkLabelControl1 = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.HyperlinkLabelControl2 = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.col_other_notes = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.grid_customer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridview_customer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_edit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_top.SuspendLayout()
        Me.GunaPanel3.SuspendLayout()
        Me.GunaPanel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'grid_customer
        '
        Me.grid_customer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_customer.Location = New System.Drawing.Point(12, 97)
        Me.grid_customer.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grid_customer.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grid_customer.MainView = Me.gridview_customer
        Me.grid_customer.Name = "grid_customer"
        Me.grid_customer.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.btn_edit})
        Me.grid_customer.Size = New System.Drawing.Size(1048, 442)
        Me.grid_customer.TabIndex = 53
        Me.grid_customer.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridview_customer})
        '
        'gridview_customer
        '
        Me.gridview_customer.Appearance.HeaderPanel.Font = New System.Drawing.Font("Nunito", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.gridview_customer.Appearance.HeaderPanel.Options.UseFont = True
        Me.gridview_customer.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.gridview_customer.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gridview_customer.Appearance.Row.Font = New System.Drawing.Font("Nunito", 9.749999!)
        Me.gridview_customer.Appearance.Row.Options.UseFont = True
        Me.gridview_customer.Appearance.Row.Options.UseTextOptions = True
        Me.gridview_customer.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gridview_customer.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_id, Me.col_fname, Me.col_contact_person, Me.col_type, Me.col_contact, Me.col_addr, Me.col_terms, Me.col_shipping, Me.col_trucking, Me.col_credit_limit, Me.col_edit, Me.col_other_notes})
        Me.gridview_customer.GridControl = Me.grid_customer
        Me.gridview_customer.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.gridview_customer.Name = "gridview_customer"
        Me.gridview_customer.OptionsBehavior.ReadOnly = True
        Me.gridview_customer.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.[False]
        '
        'col_id
        '
        Me.col_id.AppearanceHeader.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.col_id.AppearanceHeader.Options.UseFont = True
        Me.col_id.Caption = "ID"
        Me.col_id.FieldName = "customer_id"
        Me.col_id.Name = "col_id"
        Me.col_id.Visible = True
        Me.col_id.VisibleIndex = 0
        Me.col_id.Width = 49
        '
        'col_fname
        '
        Me.col_fname.AppearanceCell.Options.UseTextOptions = True
        Me.col_fname.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.col_fname.AppearanceHeader.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.col_fname.AppearanceHeader.Options.UseFont = True
        Me.col_fname.Caption = "Customer"
        Me.col_fname.FieldName = "first_name"
        Me.col_fname.Name = "col_fname"
        Me.col_fname.Visible = True
        Me.col_fname.VisibleIndex = 1
        Me.col_fname.Width = 99
        '
        'col_contact_person
        '
        Me.col_contact_person.AppearanceHeader.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.col_contact_person.AppearanceHeader.Options.UseFont = True
        Me.col_contact_person.Caption = "Contact Person"
        Me.col_contact_person.FieldName = "contact_person"
        Me.col_contact_person.Name = "col_contact_person"
        Me.col_contact_person.Visible = True
        Me.col_contact_person.VisibleIndex = 2
        Me.col_contact_person.Width = 139
        '
        'col_type
        '
        Me.col_type.AppearanceCell.Options.UseTextOptions = True
        Me.col_type.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.col_type.AppearanceHeader.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.col_type.AppearanceHeader.Options.UseFont = True
        Me.col_type.Caption = "Type"
        Me.col_type.FieldName = "account_type"
        Me.col_type.Name = "col_type"
        Me.col_type.Visible = True
        Me.col_type.VisibleIndex = 3
        Me.col_type.Width = 71
        '
        'col_contact
        '
        Me.col_contact.AppearanceCell.Options.UseTextOptions = True
        Me.col_contact.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_contact.AppearanceHeader.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.col_contact.AppearanceHeader.Options.UseFont = True
        Me.col_contact.Caption = "Contact No."
        Me.col_contact.FieldName = "contact"
        Me.col_contact.Name = "col_contact"
        Me.col_contact.Visible = True
        Me.col_contact.VisibleIndex = 4
        Me.col_contact.Width = 70
        '
        'col_addr
        '
        Me.col_addr.AppearanceCell.Options.UseTextOptions = True
        Me.col_addr.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.col_addr.AppearanceHeader.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.col_addr.AppearanceHeader.Options.UseFont = True
        Me.col_addr.Caption = "Address"
        Me.col_addr.FieldName = "address"
        Me.col_addr.Name = "col_addr"
        Me.col_addr.Visible = True
        Me.col_addr.VisibleIndex = 5
        Me.col_addr.Width = 153
        '
        'col_terms
        '
        Me.col_terms.AppearanceHeader.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.col_terms.AppearanceHeader.Options.UseFont = True
        Me.col_terms.Caption = "Terms (Days)"
        Me.col_terms.FieldName = "terms"
        Me.col_terms.Name = "col_terms"
        Me.col_terms.Visible = True
        Me.col_terms.VisibleIndex = 8
        Me.col_terms.Width = 69
        '
        'col_shipping
        '
        Me.col_shipping.AppearanceHeader.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.col_shipping.AppearanceHeader.Options.UseFont = True
        Me.col_shipping.Caption = "Shipping Option"
        Me.col_shipping.FieldName = "preferred_shipping"
        Me.col_shipping.Name = "col_shipping"
        Me.col_shipping.Visible = True
        Me.col_shipping.VisibleIndex = 6
        Me.col_shipping.Width = 80
        '
        'col_trucking
        '
        Me.col_trucking.AppearanceCell.Options.UseTextOptions = True
        Me.col_trucking.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.col_trucking.AppearanceHeader.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.col_trucking.AppearanceHeader.Options.UseFont = True
        Me.col_trucking.Caption = "Trucking"
        Me.col_trucking.FieldName = "trucking_note"
        Me.col_trucking.MinWidth = 120
        Me.col_trucking.Name = "col_trucking"
        Me.col_trucking.Visible = True
        Me.col_trucking.VisibleIndex = 7
        Me.col_trucking.Width = 120
        '
        'col_credit_limit
        '
        Me.col_credit_limit.AppearanceCell.Options.UseTextOptions = True
        Me.col_credit_limit.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_credit_limit.AppearanceHeader.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.col_credit_limit.AppearanceHeader.Options.UseFont = True
        Me.col_credit_limit.AppearanceHeader.Options.UseTextOptions = True
        Me.col_credit_limit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_credit_limit.Caption = "Credit Limit"
        Me.col_credit_limit.DisplayFormat.FormatString = "c2"
        Me.col_credit_limit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_credit_limit.FieldName = "credit_limit"
        Me.col_credit_limit.Name = "col_credit_limit"
        Me.col_credit_limit.Visible = True
        Me.col_credit_limit.VisibleIndex = 9
        Me.col_credit_limit.Width = 129
        '
        'col_edit
        '
        Me.col_edit.AppearanceHeader.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.col_edit.AppearanceHeader.Options.UseFont = True
        Me.col_edit.Caption = "Edit"
        Me.col_edit.ColumnEdit = Me.btn_edit
        Me.col_edit.Name = "col_edit"
        Me.col_edit.Visible = True
        Me.col_edit.VisibleIndex = 10
        Me.col_edit.Width = 51
        '
        'btn_edit
        '
        Me.btn_edit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        EditorButtonImageOptions1.Image = CType(resources.GetObject("EditorButtonImageOptions1.Image"), System.Drawing.Image)
        Me.btn_edit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.btn_edit.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'panel_top
        '
        Me.panel_top.BackColor = System.Drawing.Color.GhostWhite
        Me.panel_top.Controls.Add(Me.GunaPanel3)
        Me.panel_top.Controls.Add(Me.GunaLabel1)
        Me.panel_top.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_top.Location = New System.Drawing.Point(0, 0)
        Me.panel_top.Name = "panel_top"
        Me.panel_top.Size = New System.Drawing.Size(1072, 78)
        Me.panel_top.TabIndex = 54
        '
        'GunaPanel3
        '
        Me.GunaPanel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaPanel3.BackColor = System.Drawing.Color.Transparent
        Me.GunaPanel3.Controls.Add(Me.GunaPanel4)
        Me.GunaPanel3.Location = New System.Drawing.Point(19, 44)
        Me.GunaPanel3.Name = "GunaPanel3"
        Me.GunaPanel3.Size = New System.Drawing.Size(1032, 27)
        Me.GunaPanel3.TabIndex = 5
        '
        'GunaPanel4
        '
        Me.GunaPanel4.Controls.Add(Me.HyperlinkLabelControl1)
        Me.GunaPanel4.Controls.Add(Me.LabelControl1)
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
        Me.HyperlinkLabelControl1.Size = New System.Drawing.Size(66, 18)
        Me.HyperlinkLabelControl1.TabIndex = 7
        Me.HyperlinkLabelControl1.Text = "Customers"
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
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.GunaLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.GunaLabel1.Location = New System.Drawing.Point(14, 10)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(146, 31)
        Me.GunaLabel1.TabIndex = 1
        Me.GunaLabel1.Text = "Customers"
        '
        'col_other_notes
        '
        Me.col_other_notes.Caption = "Other Notes"
        Me.col_other_notes.FieldName = "other_notes"
        Me.col_other_notes.Name = "col_other_notes"
        '
        'frm_sales_customers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1072, 551)
        Me.Controls.Add(Me.panel_top)
        Me.Controls.Add(Me.grid_customer)
        Me.Name = "frm_sales_customers"
        Me.Text = "frm_customers"
        CType(Me.grid_customer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridview_customer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_edit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_top.ResumeLayout(False)
        Me.panel_top.PerformLayout()
        Me.GunaPanel3.ResumeLayout(False)
        Me.GunaPanel4.ResumeLayout(False)
        Me.GunaPanel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grid_customer As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridview_customer As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_fname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_contact As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_addr As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents panel_top As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPanel3 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPanel4 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents HyperlinkLabelControl1 As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents HyperlinkLabelControl2 As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents col_type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_shipping As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_trucking As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_terms As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_credit_limit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_edit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_edit As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents col_contact_person As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_other_notes As DevExpress.XtraGrid.Columns.GridColumn
End Class
