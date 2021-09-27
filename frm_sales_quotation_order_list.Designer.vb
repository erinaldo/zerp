<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_sales_quotation_order_list
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
        Me.panel_top = New Guna.UI.WinForms.GunaPanel()
        Me.GunaPanel5 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.link_po_list = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.link_home = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.lbl_title = New Guna.UI.WinForms.GunaLabel()
        Me.GunaPanel2 = New Guna.UI.WinForms.GunaPanel()
        Me.btn_refresh = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_quote = New DevExpress.XtraEditors.SimpleButton()
        Me.grid_quotes = New DevExpress.XtraGrid.GridControl()
        Me.grid_quotes_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_quotation_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_company = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_status = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.date_created = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_action = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btn_edit = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.panel_top.SuspendLayout()
        Me.GunaPanel5.SuspendLayout()
        Me.GunaPanel1.SuspendLayout()
        Me.GunaPanel2.SuspendLayout()
        CType(Me.grid_quotes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_quotes_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_edit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel_top
        '
        Me.panel_top.BackColor = System.Drawing.Color.GhostWhite
        Me.panel_top.Controls.Add(Me.GunaPanel5)
        Me.panel_top.Controls.Add(Me.lbl_title)
        Me.panel_top.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_top.Location = New System.Drawing.Point(0, 0)
        Me.panel_top.Name = "panel_top"
        Me.panel_top.Size = New System.Drawing.Size(1196, 78)
        Me.panel_top.TabIndex = 12
        '
        'GunaPanel5
        '
        Me.GunaPanel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaPanel5.BackColor = System.Drawing.Color.Transparent
        Me.GunaPanel5.Controls.Add(Me.GunaPanel1)
        Me.GunaPanel5.Location = New System.Drawing.Point(19, 44)
        Me.GunaPanel5.Name = "GunaPanel5"
        Me.GunaPanel5.Size = New System.Drawing.Size(1174, 27)
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
        Me.GunaPanel1.TabIndex = 1
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
        Me.link_po_list.Size = New System.Drawing.Size(69, 18)
        Me.link_po_list.TabIndex = 7
        Me.link_po_list.Text = "Quotations"
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
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lbl_title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.lbl_title.Location = New System.Drawing.Point(14, 10)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(146, 31)
        Me.lbl_title.TabIndex = 1
        Me.lbl_title.Text = "Quotations"
        '
        'GunaPanel2
        '
        Me.GunaPanel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaPanel2.Controls.Add(Me.btn_refresh)
        Me.GunaPanel2.Controls.Add(Me.btn_quote)
        Me.GunaPanel2.Controls.Add(Me.grid_quotes)
        Me.GunaPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GunaPanel2.Location = New System.Drawing.Point(0, 78)
        Me.GunaPanel2.Name = "GunaPanel2"
        Me.GunaPanel2.Size = New System.Drawing.Size(1196, 635)
        Me.GunaPanel2.TabIndex = 13
        '
        'btn_refresh
        '
        Me.btn_refresh.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_refresh.Appearance.Options.UseFont = True
        Me.btn_refresh.Appearance.Options.UseTextOptions = True
        Me.btn_refresh.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btn_refresh.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btn_refresh.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.refresh_32x32
        Me.btn_refresh.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_refresh.ImageOptions.ImageToTextIndent = 5
        Me.btn_refresh.Location = New System.Drawing.Point(186, 15)
        Me.btn_refresh.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_refresh.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(160, 46)
        Me.btn_refresh.TabIndex = 13
        Me.btn_refresh.Text = "Refresh"
        '
        'btn_quote
        '
        Me.btn_quote.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_quote.Appearance.Options.UseFont = True
        Me.btn_quote.Appearance.Options.UseTextOptions = True
        Me.btn_quote.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btn_quote.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btn_quote.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.newtask_32x32
        Me.btn_quote.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_quote.ImageOptions.ImageToTextIndent = 5
        Me.btn_quote.Location = New System.Drawing.Point(20, 15)
        Me.btn_quote.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_quote.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_quote.Name = "btn_quote"
        Me.btn_quote.Size = New System.Drawing.Size(160, 46)
        Me.btn_quote.TabIndex = 11
        Me.btn_quote.Text = "New Quotation"
        '
        'grid_quotes
        '
        Me.grid_quotes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_quotes.Location = New System.Drawing.Point(20, 72)
        Me.grid_quotes.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grid_quotes.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grid_quotes.MainView = Me.grid_quotes_view
        Me.grid_quotes.Name = "grid_quotes"
        Me.grid_quotes.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.btn_edit})
        Me.grid_quotes.Size = New System.Drawing.Size(1157, 546)
        Me.grid_quotes.TabIndex = 9
        Me.grid_quotes.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_quotes_view})
        '
        'grid_quotes_view
        '
        Me.grid_quotes_view.Appearance.HeaderPanel.BackColor = System.Drawing.Color.White
        Me.grid_quotes_view.Appearance.HeaderPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.grid_quotes_view.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grid_quotes_view.Appearance.HeaderPanel.Options.UseFont = True
        Me.grid_quotes_view.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.grid_quotes_view.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grid_quotes_view.Appearance.Row.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.grid_quotes_view.Appearance.Row.Options.UseFont = True
        Me.grid_quotes_view.Appearance.SelectedRow.BackColor = System.Drawing.Color.White
        Me.grid_quotes_view.Appearance.SelectedRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.grid_quotes_view.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grid_quotes_view.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grid_quotes_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_quotation_id, Me.col_company, Me.col_status, Me.date_created, Me.col_action})
        Me.grid_quotes_view.GridControl = Me.grid_quotes
        Me.grid_quotes_view.Name = "grid_quotes_view"
        Me.grid_quotes_view.OptionsBehavior.ReadOnly = True
        Me.grid_quotes_view.OptionsSelection.ResetSelectionClickOutsideCheckboxSelector = True
        Me.grid_quotes_view.OptionsView.ColumnAutoWidth = False
        Me.grid_quotes_view.OptionsView.ShowFooter = True
        '
        'col_quotation_id
        '
        Me.col_quotation_id.AppearanceCell.Options.UseTextOptions = True
        Me.col_quotation_id.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_quotation_id.AppearanceHeader.Options.UseTextOptions = True
        Me.col_quotation_id.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_quotation_id.Caption = "Quote ID"
        Me.col_quotation_id.FieldName = "quotation_id"
        Me.col_quotation_id.MaxWidth = 100
        Me.col_quotation_id.MinWidth = 50
        Me.col_quotation_id.Name = "col_quotation_id"
        Me.col_quotation_id.Visible = True
        Me.col_quotation_id.VisibleIndex = 1
        Me.col_quotation_id.Width = 80
        '
        'col_company
        '
        Me.col_company.AppearanceHeader.Options.UseTextOptions = True
        Me.col_company.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_company.Caption = "Customer"
        Me.col_company.FieldName = "company"
        Me.col_company.MinWidth = 150
        Me.col_company.Name = "col_company"
        Me.col_company.Visible = True
        Me.col_company.VisibleIndex = 2
        Me.col_company.Width = 250
        '
        'col_status
        '
        Me.col_status.AppearanceCell.Options.UseTextOptions = True
        Me.col_status.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_status.AppearanceHeader.Options.UseTextOptions = True
        Me.col_status.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_status.Caption = "Status"
        Me.col_status.FieldName = "status"
        Me.col_status.Name = "col_status"
        Me.col_status.Visible = True
        Me.col_status.VisibleIndex = 3
        Me.col_status.Width = 120
        '
        'date_created
        '
        Me.date_created.AppearanceCell.Options.UseTextOptions = True
        Me.date_created.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.date_created.Caption = "Created At"
        Me.date_created.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.date_created.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.date_created.FieldName = "created_at"
        Me.date_created.Name = "date_created"
        Me.date_created.Visible = True
        Me.date_created.VisibleIndex = 4
        Me.date_created.Width = 120
        '
        'col_action
        '
        Me.col_action.Caption = "Action"
        Me.col_action.ColumnEdit = Me.btn_edit
        Me.col_action.MaxWidth = 50
        Me.col_action.MinWidth = 50
        Me.col_action.Name = "col_action"
        Me.col_action.Visible = True
        Me.col_action.VisibleIndex = 0
        Me.col_action.Width = 50
        '
        'btn_edit
        '
        Me.btn_edit.AutoHeight = False
        EditorButtonImageOptions1.Image = Global.Inventory_Management.My.Resources.Resources.snapmodifytablecellstyle_16x16
        Me.btn_edit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.btn_edit.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'frm_sales_quotation_order_list
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1196, 713)
        Me.Controls.Add(Me.GunaPanel2)
        Me.Controls.Add(Me.panel_top)
        Me.Name = "frm_sales_quotation_order_list"
        Me.Text = "frm_quotation_order_list"
        Me.panel_top.ResumeLayout(False)
        Me.panel_top.PerformLayout()
        Me.GunaPanel5.ResumeLayout(False)
        Me.GunaPanel1.ResumeLayout(False)
        Me.GunaPanel1.PerformLayout()
        Me.GunaPanel2.ResumeLayout(False)
        CType(Me.grid_quotes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_quotes_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_edit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panel_top As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPanel5 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents link_po_list As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents link_home As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents lbl_title As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaPanel2 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents btn_refresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_quote As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grid_quotes As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_quotes_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_quotation_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_company As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents date_created As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_action As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_edit As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
End Class
