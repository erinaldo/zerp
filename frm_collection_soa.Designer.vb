<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_collection_soa
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
        Me.GunaPanel2 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaPanel3 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaPanel4 = New Guna.UI.WinForms.GunaPanel()
        Me.HyperlinkLabelControl1 = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.HyperlinkLabelControl2 = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.btn_print = New DevExpress.XtraEditors.SimpleButton()
        Me.grid_soa = New DevExpress.XtraGrid.GridControl()
        Me.grid_soa_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_soa_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_customer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_date_generated = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_amount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_prepared_by = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.RepositoryItemHyperLinkEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.btn_new = New DevExpress.XtraEditors.SimpleButton()
        Me.panel_content = New System.Windows.Forms.Panel()
        Me.GunaPanel2.SuspendLayout()
        Me.GunaPanel3.SuspendLayout()
        Me.GunaPanel4.SuspendLayout()
        Me.GunaPanel1.SuspendLayout()
        CType(Me.grid_soa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_soa_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_content.SuspendLayout()
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
        Me.GunaPanel2.Size = New System.Drawing.Size(1186, 78)
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
        Me.GunaPanel3.Size = New System.Drawing.Size(1168, 27)
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
        Me.HyperlinkLabelControl1.Size = New System.Drawing.Size(140, 18)
        Me.HyperlinkLabelControl1.TabIndex = 7
        Me.HyperlinkLabelControl1.Text = "Statement of Accounts"
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
        Me.GunaLabel1.Size = New System.Drawing.Size(288, 31)
        Me.GunaLabel1.TabIndex = 1
        Me.GunaLabel1.Text = "Statement of Accounts"
        '
        'GunaPanel1
        '
        Me.GunaPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaPanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaPanel1.Controls.Add(Me.btn_print)
        Me.GunaPanel1.Controls.Add(Me.grid_soa)
        Me.GunaPanel1.Controls.Add(Me.btn_new)
        Me.GunaPanel1.Location = New System.Drawing.Point(12, 20)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(1162, 481)
        Me.GunaPanel1.TabIndex = 15
        '
        'btn_print
        '
        Me.btn_print.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_print.ImageOptions.ImageToTextIndent = 8
        Me.btn_print.ImageOptions.SvgImage = Global.Inventory_Management.My.Resources.Resources.printarea
        Me.btn_print.ImageOptions.SvgImageSize = New System.Drawing.Size(20, 20)
        Me.btn_print.Location = New System.Drawing.Point(142, 3)
        Me.btn_print.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_print.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(129, 35)
        Me.btn_print.TabIndex = 10
        Me.btn_print.Text = "Print"
        '
        'grid_soa
        '
        Me.grid_soa.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_soa.Location = New System.Drawing.Point(8, 47)
        Me.grid_soa.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grid_soa.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grid_soa.MainView = Me.grid_soa_view
        Me.grid_soa.Name = "grid_soa"
        Me.grid_soa.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemHyperLinkEdit1, Me.RepositoryItemDateEdit1})
        Me.grid_soa.Size = New System.Drawing.Size(1145, 431)
        Me.grid_soa.TabIndex = 8
        Me.grid_soa.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_soa_view})
        '
        'grid_soa_view
        '
        Me.grid_soa_view.Appearance.HeaderPanel.BackColor = System.Drawing.Color.White
        Me.grid_soa_view.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grid_soa_view.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grid_soa_view.Appearance.HeaderPanel.Options.UseFont = True
        Me.grid_soa_view.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.grid_soa_view.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grid_soa_view.Appearance.Row.Font = New System.Drawing.Font("Nunito", 9.749999!)
        Me.grid_soa_view.Appearance.Row.Options.UseFont = True
        Me.grid_soa_view.Appearance.SelectedRow.BackColor = System.Drawing.Color.White
        Me.grid_soa_view.Appearance.SelectedRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.grid_soa_view.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grid_soa_view.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grid_soa_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_soa_id, Me.col_customer, Me.col_date_generated, Me.col_amount, Me.col_prepared_by})
        Me.grid_soa_view.GridControl = Me.grid_soa
        Me.grid_soa_view.Name = "grid_soa_view"
        Me.grid_soa_view.OptionsBehavior.Editable = False
        Me.grid_soa_view.OptionsBehavior.ReadOnly = True
        Me.grid_soa_view.OptionsSelection.ResetSelectionClickOutsideCheckboxSelector = True
        Me.grid_soa_view.OptionsView.ColumnAutoWidth = False
        Me.grid_soa_view.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.[False]
        '
        'col_soa_id
        '
        Me.col_soa_id.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.col_soa_id.AppearanceCell.Options.UseForeColor = True
        Me.col_soa_id.AppearanceCell.Options.UseTextOptions = True
        Me.col_soa_id.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_soa_id.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.col_soa_id.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.col_soa_id.AppearanceHeader.Options.UseFont = True
        Me.col_soa_id.AppearanceHeader.Options.UseForeColor = True
        Me.col_soa_id.AppearanceHeader.Options.UseTextOptions = True
        Me.col_soa_id.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_soa_id.Caption = "SOA ID"
        Me.col_soa_id.FieldName = "soa_id"
        Me.col_soa_id.MaxWidth = 100
        Me.col_soa_id.MinWidth = 50
        Me.col_soa_id.Name = "col_soa_id"
        Me.col_soa_id.Visible = True
        Me.col_soa_id.VisibleIndex = 0
        Me.col_soa_id.Width = 100
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
        Me.col_customer.VisibleIndex = 1
        Me.col_customer.Width = 266
        '
        'col_date_generated
        '
        Me.col_date_generated.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.col_date_generated.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.col_date_generated.AppearanceHeader.Options.UseFont = True
        Me.col_date_generated.AppearanceHeader.Options.UseForeColor = True
        Me.col_date_generated.AppearanceHeader.Options.UseTextOptions = True
        Me.col_date_generated.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_date_generated.Caption = "Date Generated"
        Me.col_date_generated.DisplayFormat.FormatString = "MM/dd/yyy"
        Me.col_date_generated.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col_date_generated.FieldName = "print_date"
        Me.col_date_generated.Name = "col_date_generated"
        Me.col_date_generated.Visible = True
        Me.col_date_generated.VisibleIndex = 2
        Me.col_date_generated.Width = 166
        '
        'col_amount
        '
        Me.col_amount.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.col_amount.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.col_amount.AppearanceHeader.Options.UseFont = True
        Me.col_amount.AppearanceHeader.Options.UseForeColor = True
        Me.col_amount.AppearanceHeader.Options.UseTextOptions = True
        Me.col_amount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_amount.Caption = "Amount "
        Me.col_amount.DisplayFormat.FormatString = "c2"
        Me.col_amount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.col_amount.FieldName = "total"
        Me.col_amount.Name = "col_amount"
        Me.col_amount.Visible = True
        Me.col_amount.VisibleIndex = 3
        Me.col_amount.Width = 158
        '
        'col_prepared_by
        '
        Me.col_prepared_by.AppearanceCell.Options.UseTextOptions = True
        Me.col_prepared_by.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_prepared_by.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.col_prepared_by.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.col_prepared_by.AppearanceHeader.Options.UseFont = True
        Me.col_prepared_by.AppearanceHeader.Options.UseForeColor = True
        Me.col_prepared_by.AppearanceHeader.Options.UseTextOptions = True
        Me.col_prepared_by.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_prepared_by.Caption = "Prepared By"
        Me.col_prepared_by.ColumnEdit = Me.RepositoryItemDateEdit1
        Me.col_prepared_by.FieldName = "prepared_by"
        Me.col_prepared_by.Name = "col_prepared_by"
        Me.col_prepared_by.Visible = True
        Me.col_prepared_by.VisibleIndex = 4
        Me.col_prepared_by.Width = 150
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'RepositoryItemHyperLinkEdit1
        '
        Me.RepositoryItemHyperLinkEdit1.AutoHeight = False
        Me.RepositoryItemHyperLinkEdit1.Name = "RepositoryItemHyperLinkEdit1"
        '
        'btn_new
        '
        Me.btn_new.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_new.ImageOptions.ImageToTextIndent = 8
        Me.btn_new.ImageOptions.SvgImage = Global.Inventory_Management.My.Resources.Resources.actions_addcircled
        Me.btn_new.ImageOptions.SvgImageSize = New System.Drawing.Size(20, 20)
        Me.btn_new.Location = New System.Drawing.Point(7, 3)
        Me.btn_new.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_new.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(129, 35)
        Me.btn_new.TabIndex = 9
        Me.btn_new.Text = "New SOA"
        '
        'panel_content
        '
        Me.panel_content.Controls.Add(Me.GunaPanel1)
        Me.panel_content.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_content.Location = New System.Drawing.Point(0, 78)
        Me.panel_content.Name = "panel_content"
        Me.panel_content.Size = New System.Drawing.Size(1186, 513)
        Me.panel_content.TabIndex = 16
        '
        'frm_collection_soa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1186, 591)
        Me.Controls.Add(Me.panel_content)
        Me.Controls.Add(Me.GunaPanel2)
        Me.Name = "frm_collection_soa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_collection_soa"
        Me.GunaPanel2.ResumeLayout(False)
        Me.GunaPanel2.PerformLayout()
        Me.GunaPanel3.ResumeLayout(False)
        Me.GunaPanel4.ResumeLayout(False)
        Me.GunaPanel4.PerformLayout()
        Me.GunaPanel1.ResumeLayout(False)
        CType(Me.grid_soa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_soa_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_content.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaPanel2 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPanel3 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPanel4 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents HyperlinkLabelControl1 As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents HyperlinkLabelControl2 As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents grid_soa As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_soa_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_soa_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_customer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_date_generated As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_amount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_prepared_by As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemHyperLinkEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents btn_new As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents panel_content As Panel
    Friend WithEvents btn_print As DevExpress.XtraEditors.SimpleButton
End Class
