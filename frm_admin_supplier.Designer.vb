<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_admin_supplier
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
        Me.GunaPanel4 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaPanel5 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaPanel2 = New Guna.UI.WinForms.GunaPanel()
        Me.link_po_list = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.link_home = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.btn_new = New DevExpress.XtraEditors.SimpleButton()
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.grid_supplier = New DevExpress.XtraGrid.GridControl()
        Me.gridview_supplier = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_supid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_supplier_name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_office_addr = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_warehouse_addr = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_contact_person = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_tin_no = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_position = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_tel_no = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_mobile_no = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_fax_no = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_email = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_lead_time = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_terms = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_acc_name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_acc_nos = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_bank = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_zip_code = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_is_with_tax = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_atc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_tax_rate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemCheckedComboBoxEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GunaPanel4.SuspendLayout()
        Me.GunaPanel5.SuspendLayout()
        Me.GunaPanel2.SuspendLayout()
        Me.GunaPanel1.SuspendLayout()
        CType(Me.grid_supplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridview_supplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckedComboBoxEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GunaPanel4.Size = New System.Drawing.Size(1790, 78)
        Me.GunaPanel4.TabIndex = 7
        '
        'GunaPanel5
        '
        Me.GunaPanel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaPanel5.BackColor = System.Drawing.Color.Transparent
        Me.GunaPanel5.Controls.Add(Me.GunaPanel2)
        Me.GunaPanel5.Location = New System.Drawing.Point(19, 44)
        Me.GunaPanel5.Name = "GunaPanel5"
        Me.GunaPanel5.Size = New System.Drawing.Size(1750, 27)
        Me.GunaPanel5.TabIndex = 6
        '
        'GunaPanel2
        '
        Me.GunaPanel2.Controls.Add(Me.link_po_list)
        Me.GunaPanel2.Controls.Add(Me.LabelControl7)
        Me.GunaPanel2.Controls.Add(Me.link_home)
        Me.GunaPanel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.GunaPanel2.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel2.Name = "GunaPanel2"
        Me.GunaPanel2.Size = New System.Drawing.Size(435, 27)
        Me.GunaPanel2.TabIndex = 1
        '
        'link_po_list
        '
        Me.link_po_list.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.link_po_list.Appearance.LinkColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.link_po_list.Appearance.Options.UseFont = True
        Me.link_po_list.Appearance.Options.UseLinkColor = True
        Me.link_po_list.AppearanceHovered.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.link_po_list.AppearanceHovered.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.link_po_list.AppearanceHovered.Options.UseForeColor = True
        Me.link_po_list.AppearanceHovered.Options.UseLinkColor = True
        Me.link_po_list.AppearancePressed.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.link_po_list.AppearancePressed.Options.UseLinkColor = True
        Me.link_po_list.Enabled = False
        Me.link_po_list.LineStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.link_po_list.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.link_po_list.Location = New System.Drawing.Point(70, 5)
        Me.link_po_list.Name = "link_po_list"
        Me.link_po_list.ShowLineShadow = False
        Me.link_po_list.Size = New System.Drawing.Size(52, 18)
        Me.link_po_list.TabIndex = 7
        Me.link_po_list.Text = "Supplier"
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
        Me.GunaLabel2.Size = New System.Drawing.Size(127, 31)
        Me.GunaLabel2.TabIndex = 1
        Me.GunaLabel2.Text = "Suppliers"
        '
        'btn_new
        '
        Me.btn_new.Appearance.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btn_new.Appearance.Options.UseBackColor = True
        Me.btn_new.Appearance.Options.UseTextOptions = True
        Me.btn_new.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btn_new.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.add_16x161
        Me.btn_new.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_new.ImageOptions.SvgImageSize = New System.Drawing.Size(20, 20)
        Me.btn_new.Location = New System.Drawing.Point(26, 18)
        Me.btn_new.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_new.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(135, 27)
        Me.btn_new.TabIndex = 0
        Me.btn_new.Text = "Add New Supplier"
        '
        'GunaPanel1
        '
        Me.GunaPanel1.BackColor = System.Drawing.Color.White
        Me.GunaPanel1.Controls.Add(Me.grid_supplier)
        Me.GunaPanel1.Controls.Add(Me.btn_new)
        Me.GunaPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GunaPanel1.Location = New System.Drawing.Point(0, 78)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(1790, 547)
        Me.GunaPanel1.TabIndex = 8
        '
        'grid_supplier
        '
        Me.grid_supplier.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_supplier.Location = New System.Drawing.Point(26, 52)
        Me.grid_supplier.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grid_supplier.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grid_supplier.MainView = Me.gridview_supplier
        Me.grid_supplier.Name = "grid_supplier"
        Me.grid_supplier.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemCheckedComboBoxEdit1})
        Me.grid_supplier.Size = New System.Drawing.Size(1740, 480)
        Me.grid_supplier.TabIndex = 52
        Me.grid_supplier.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridview_supplier})
        '
        'gridview_supplier
        '
        Me.gridview_supplier.Appearance.HeaderPanel.Font = New System.Drawing.Font("Nunito", 9.749999!)
        Me.gridview_supplier.Appearance.HeaderPanel.Options.UseFont = True
        Me.gridview_supplier.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.gridview_supplier.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gridview_supplier.Appearance.Row.Font = New System.Drawing.Font("Nunito", 9.749999!)
        Me.gridview_supplier.Appearance.Row.Options.UseFont = True
        Me.gridview_supplier.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_supid, Me.col_supplier_name, Me.col_office_addr, Me.col_warehouse_addr, Me.col_contact_person, Me.col_tin_no, Me.col_position, Me.col_tel_no, Me.col_mobile_no, Me.col_fax_no, Me.col_email, Me.col_lead_time, Me.col_terms, Me.col_acc_name, Me.col_acc_nos, Me.col_bank, Me.col_zip_code, Me.col_is_with_tax, Me.col_atc, Me.col_tax_rate})
        Me.gridview_supplier.GridControl = Me.grid_supplier
        Me.gridview_supplier.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.gridview_supplier.Name = "gridview_supplier"
        Me.gridview_supplier.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm
        Me.gridview_supplier.OptionsView.ColumnAutoWidth = False
        '
        'col_supid
        '
        Me.col_supid.Caption = "Supplier ID"
        Me.col_supid.FieldName = "id"
        Me.col_supid.Name = "col_supid"
        Me.col_supid.Visible = True
        Me.col_supid.VisibleIndex = 0
        '
        'col_supplier_name
        '
        Me.col_supplier_name.AppearanceCell.Options.UseTextOptions = True
        Me.col_supplier_name.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.col_supplier_name.Caption = "Supplier Name"
        Me.col_supplier_name.FieldName = "supplier"
        Me.col_supplier_name.Name = "col_supplier_name"
        Me.col_supplier_name.Visible = True
        Me.col_supplier_name.VisibleIndex = 1
        Me.col_supplier_name.Width = 107
        '
        'col_office_addr
        '
        Me.col_office_addr.AppearanceCell.Options.UseTextOptions = True
        Me.col_office_addr.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.col_office_addr.Caption = "Office Address"
        Me.col_office_addr.FieldName = "office_addr"
        Me.col_office_addr.Name = "col_office_addr"
        Me.col_office_addr.Visible = True
        Me.col_office_addr.VisibleIndex = 2
        '
        'col_warehouse_addr
        '
        Me.col_warehouse_addr.AppearanceCell.Options.UseTextOptions = True
        Me.col_warehouse_addr.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.col_warehouse_addr.Caption = "Warehouse Address"
        Me.col_warehouse_addr.FieldName = "warehouse_addr"
        Me.col_warehouse_addr.Name = "col_warehouse_addr"
        Me.col_warehouse_addr.Visible = True
        Me.col_warehouse_addr.VisibleIndex = 3
        '
        'col_contact_person
        '
        Me.col_contact_person.Caption = "Contact Person"
        Me.col_contact_person.FieldName = "contact_person"
        Me.col_contact_person.Name = "col_contact_person"
        Me.col_contact_person.Visible = True
        Me.col_contact_person.VisibleIndex = 9
        '
        'col_tin_no
        '
        Me.col_tin_no.Caption = "TIN No."
        Me.col_tin_no.FieldName = "tin_no"
        Me.col_tin_no.Name = "col_tin_no"
        Me.col_tin_no.Visible = True
        Me.col_tin_no.VisibleIndex = 5
        Me.col_tin_no.Width = 115
        '
        'col_position
        '
        Me.col_position.Caption = "Position"
        Me.col_position.FieldName = "position"
        Me.col_position.Name = "col_position"
        Me.col_position.Visible = True
        Me.col_position.VisibleIndex = 10
        '
        'col_tel_no
        '
        Me.col_tel_no.AppearanceCell.Options.UseTextOptions = True
        Me.col_tel_no.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_tel_no.Caption = "Tel. No."
        Me.col_tel_no.FieldName = "tel_no"
        Me.col_tel_no.Name = "col_tel_no"
        Me.col_tel_no.Visible = True
        Me.col_tel_no.VisibleIndex = 11
        '
        'col_mobile_no
        '
        Me.col_mobile_no.AppearanceCell.Options.UseTextOptions = True
        Me.col_mobile_no.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_mobile_no.Caption = "Mobile No."
        Me.col_mobile_no.FieldName = "mobile_no"
        Me.col_mobile_no.Name = "col_mobile_no"
        Me.col_mobile_no.Visible = True
        Me.col_mobile_no.VisibleIndex = 12
        '
        'col_fax_no
        '
        Me.col_fax_no.AppearanceCell.Options.UseTextOptions = True
        Me.col_fax_no.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_fax_no.Caption = "Fax No."
        Me.col_fax_no.FieldName = "fax_no"
        Me.col_fax_no.Name = "col_fax_no"
        Me.col_fax_no.Visible = True
        Me.col_fax_no.VisibleIndex = 13
        '
        'col_email
        '
        Me.col_email.Caption = "Email"
        Me.col_email.FieldName = "email"
        Me.col_email.Name = "col_email"
        Me.col_email.Visible = True
        Me.col_email.VisibleIndex = 14
        '
        'col_lead_time
        '
        Me.col_lead_time.Caption = "Lead Time (Days)"
        Me.col_lead_time.FieldName = "lead_time"
        Me.col_lead_time.Name = "col_lead_time"
        Me.col_lead_time.Visible = True
        Me.col_lead_time.VisibleIndex = 15
        '
        'col_terms
        '
        Me.col_terms.Caption = "Terms (Days)"
        Me.col_terms.FieldName = "terms"
        Me.col_terms.Name = "col_terms"
        Me.col_terms.Visible = True
        Me.col_terms.VisibleIndex = 16
        '
        'col_acc_name
        '
        Me.col_acc_name.Caption = "Account Name"
        Me.col_acc_name.FieldName = "acc_name"
        Me.col_acc_name.Name = "col_acc_name"
        Me.col_acc_name.Visible = True
        Me.col_acc_name.VisibleIndex = 7
        '
        'col_acc_nos
        '
        Me.col_acc_nos.Caption = "Account No"
        Me.col_acc_nos.FieldName = "acc_no"
        Me.col_acc_nos.Name = "col_acc_nos"
        Me.col_acc_nos.Visible = True
        Me.col_acc_nos.VisibleIndex = 8
        '
        'col_bank
        '
        Me.col_bank.Caption = "Bank"
        Me.col_bank.FieldName = "bank"
        Me.col_bank.Name = "col_bank"
        Me.col_bank.Visible = True
        Me.col_bank.VisibleIndex = 6
        Me.col_bank.Width = 118
        '
        'col_zip_code
        '
        Me.col_zip_code.AppearanceCell.Options.UseTextOptions = True
        Me.col_zip_code.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_zip_code.Caption = "Zip Code"
        Me.col_zip_code.FieldName = "zip_code"
        Me.col_zip_code.Name = "col_zip_code"
        Me.col_zip_code.Visible = True
        Me.col_zip_code.VisibleIndex = 4
        '
        'col_is_with_tax
        '
        Me.col_is_with_tax.Caption = "Apply EWT"
        Me.col_is_with_tax.FieldName = "is_with_tax"
        Me.col_is_with_tax.Name = "col_is_with_tax"
        Me.col_is_with_tax.Visible = True
        Me.col_is_with_tax.VisibleIndex = 17
        '
        'col_atc
        '
        Me.col_atc.Caption = "ATC"
        Me.col_atc.FieldName = "tax_atc"
        Me.col_atc.Name = "col_atc"
        Me.col_atc.Visible = True
        Me.col_atc.VisibleIndex = 18
        Me.col_atc.Width = 100
        '
        'col_tax_rate
        '
        Me.col_tax_rate.Caption = "Tax Rate (%)"
        Me.col_tax_rate.FieldName = "tax_rate"
        Me.col_tax_rate.Name = "col_tax_rate"
        Me.col_tax_rate.Visible = True
        Me.col_tax_rate.VisibleIndex = 19
        Me.col_tax_rate.Width = 99
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'RepositoryItemCheckedComboBoxEdit1
        '
        Me.RepositoryItemCheckedComboBoxEdit1.AutoHeight = False
        Me.RepositoryItemCheckedComboBoxEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCheckedComboBoxEdit1.Name = "RepositoryItemCheckedComboBoxEdit1"
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "GridColumn2"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 13
        '
        'frm_admin_supplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1790, 625)
        Me.Controls.Add(Me.GunaPanel1)
        Me.Controls.Add(Me.GunaPanel4)
        Me.Name = "frm_admin_supplier"
        Me.Text = "frm_supplier"
        Me.GunaPanel4.ResumeLayout(False)
        Me.GunaPanel4.PerformLayout()
        Me.GunaPanel5.ResumeLayout(False)
        Me.GunaPanel2.ResumeLayout(False)
        Me.GunaPanel2.PerformLayout()
        Me.GunaPanel1.ResumeLayout(False)
        CType(Me.grid_supplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridview_supplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckedComboBoxEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaPanel4 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents grid_supplier As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridview_supplier As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GunaPanel5 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPanel2 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents link_po_list As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents link_home As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents btn_new As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents col_supid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_supplier_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_office_addr As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_warehouse_addr As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_contact_person As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_position As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_tel_no As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_mobile_no As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_fax_no As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_email As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_lead_time As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_terms As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_acc_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_acc_nos As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents col_bank As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_zip_code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_tin_no As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_is_with_tax As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_atc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_tax_rate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckedComboBoxEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit
End Class
