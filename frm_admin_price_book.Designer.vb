<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_admin_price_book
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
        Me.panel_top = New Guna.UI.WinForms.GunaPanel()
        Me.GunaPanel5 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.link_po_list = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.link_home = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.grid_pricebooks = New DevExpress.XtraGrid.GridControl()
        Me.DeliveryView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_pid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_model = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_action = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_base_price = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_cost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_discount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_regular_price = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_dealer_price = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_vip_price = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.panel_top.SuspendLayout()
        Me.GunaPanel5.SuspendLayout()
        Me.GunaPanel1.SuspendLayout()
        CType(Me.grid_pricebooks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeliveryView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel_top
        '
        Me.panel_top.BackColor = System.Drawing.Color.GhostWhite
        Me.panel_top.Controls.Add(Me.GunaPanel5)
        Me.panel_top.Controls.Add(Me.GunaLabel2)
        Me.panel_top.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_top.Location = New System.Drawing.Point(0, 0)
        Me.panel_top.Name = "panel_top"
        Me.panel_top.Size = New System.Drawing.Size(1068, 78)
        Me.panel_top.TabIndex = 10
        '
        'GunaPanel5
        '
        Me.GunaPanel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaPanel5.BackColor = System.Drawing.Color.Transparent
        Me.GunaPanel5.Controls.Add(Me.GunaPanel1)
        Me.GunaPanel5.Location = New System.Drawing.Point(19, 44)
        Me.GunaPanel5.Name = "GunaPanel5"
        Me.GunaPanel5.Size = New System.Drawing.Size(1028, 27)
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
        Me.link_po_list.Size = New System.Drawing.Size(65, 18)
        Me.link_po_list.TabIndex = 7
        Me.link_po_list.Text = "Price Book"
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
        Me.GunaLabel2.Size = New System.Drawing.Size(145, 31)
        Me.GunaLabel2.TabIndex = 1
        Me.GunaLabel2.Text = "Price Book"
        '
        'grid_pricebooks
        '
        Me.grid_pricebooks.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_pricebooks.Location = New System.Drawing.Point(12, 98)
        Me.grid_pricebooks.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grid_pricebooks.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grid_pricebooks.MainView = Me.DeliveryView
        Me.grid_pricebooks.Name = "grid_pricebooks"
        Me.grid_pricebooks.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1})
        Me.grid_pricebooks.Size = New System.Drawing.Size(1044, 518)
        Me.grid_pricebooks.TabIndex = 12
        Me.grid_pricebooks.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.DeliveryView})
        '
        'DeliveryView
        '
        Me.DeliveryView.Appearance.HeaderPanel.Font = New System.Drawing.Font("Nunito", 9.749999!)
        Me.DeliveryView.Appearance.HeaderPanel.Options.UseFont = True
        Me.DeliveryView.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.DeliveryView.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.DeliveryView.Appearance.Row.Font = New System.Drawing.Font("Nunito", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeliveryView.Appearance.Row.Options.UseFont = True
        Me.DeliveryView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_pid, Me.col_model, Me.col_action, Me.col_base_price, Me.col_cost, Me.col_discount, Me.col_regular_price, Me.col_dealer_price, Me.col_vip_price})
        Me.DeliveryView.GridControl = Me.grid_pricebooks
        Me.DeliveryView.Name = "DeliveryView"
        Me.DeliveryView.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.Inplace
        Me.DeliveryView.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
        Me.DeliveryView.OptionsView.AutoCalcPreviewLineCount = True
        '
        'col_pid
        '
        Me.col_pid.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.col_pid.AppearanceCell.Options.UseBackColor = True
        Me.col_pid.AppearanceCell.Options.UseTextOptions = True
        Me.col_pid.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_pid.Caption = "Product ID"
        Me.col_pid.FieldName = "pid"
        Me.col_pid.Name = "col_pid"
        Me.col_pid.OptionsColumn.AllowFocus = False
        Me.col_pid.OptionsColumn.ReadOnly = True
        Me.col_pid.Visible = True
        Me.col_pid.VisibleIndex = 0
        Me.col_pid.Width = 80
        '
        'col_model
        '
        Me.col_model.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.col_model.AppearanceCell.Options.UseBackColor = True
        Me.col_model.AppearanceCell.Options.UseTextOptions = True
        Me.col_model.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.col_model.Caption = "Model"
        Me.col_model.FieldName = "winmodel"
        Me.col_model.Name = "col_model"
        Me.col_model.OptionsColumn.AllowFocus = False
        Me.col_model.OptionsColumn.ReadOnly = True
        Me.col_model.Visible = True
        Me.col_model.VisibleIndex = 1
        Me.col_model.Width = 111
        '
        'col_action
        '
        Me.col_action.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.col_action.AppearanceCell.Options.UseBackColor = True
        Me.col_action.Caption = "Description"
        Me.col_action.FieldName = "description"
        Me.col_action.Name = "col_action"
        Me.col_action.OptionsColumn.AllowFocus = False
        Me.col_action.OptionsColumn.ReadOnly = True
        Me.col_action.Visible = True
        Me.col_action.VisibleIndex = 2
        Me.col_action.Width = 319
        '
        'col_base_price
        '
        Me.col_base_price.AppearanceCell.Options.UseTextOptions = True
        Me.col_base_price.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_base_price.Caption = "Base Price"
        Me.col_base_price.FieldName = "base_price"
        Me.col_base_price.Name = "col_base_price"
        Me.col_base_price.Visible = True
        Me.col_base_price.VisibleIndex = 3
        Me.col_base_price.Width = 80
        '
        'col_cost
        '
        Me.col_cost.AppearanceCell.Options.UseTextOptions = True
        Me.col_cost.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_cost.Caption = "Cost"
        Me.col_cost.FieldName = "cost"
        Me.col_cost.Name = "col_cost"
        Me.col_cost.Visible = True
        Me.col_cost.VisibleIndex = 4
        Me.col_cost.Width = 84
        '
        'col_discount
        '
        Me.col_discount.AppearanceCell.Options.UseTextOptions = True
        Me.col_discount.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_discount.Caption = "Discount(%)"
        Me.col_discount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_discount.FieldName = "discount"
        Me.col_discount.Name = "col_discount"
        Me.col_discount.Visible = True
        Me.col_discount.VisibleIndex = 5
        Me.col_discount.Width = 85
        '
        'col_regular_price
        '
        Me.col_regular_price.AppearanceCell.Options.UseTextOptions = True
        Me.col_regular_price.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_regular_price.Caption = "Regular"
        Me.col_regular_price.FieldName = "regular_price"
        Me.col_regular_price.Name = "col_regular_price"
        Me.col_regular_price.Visible = True
        Me.col_regular_price.VisibleIndex = 6
        Me.col_regular_price.Width = 79
        '
        'col_dealer_price
        '
        Me.col_dealer_price.AppearanceCell.Options.UseTextOptions = True
        Me.col_dealer_price.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_dealer_price.Caption = "Dealer"
        Me.col_dealer_price.FieldName = "dealer_price"
        Me.col_dealer_price.Name = "col_dealer_price"
        Me.col_dealer_price.Visible = True
        Me.col_dealer_price.VisibleIndex = 7
        Me.col_dealer_price.Width = 80
        '
        'col_vip_price
        '
        Me.col_vip_price.AppearanceCell.Options.UseTextOptions = True
        Me.col_vip_price.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_vip_price.Caption = "VIP"
        Me.col_vip_price.FieldName = "vip_price"
        Me.col_vip_price.Name = "col_vip_price"
        Me.col_vip_price.Visible = True
        Me.col_vip_price.VisibleIndex = 8
        Me.col_vip_price.Width = 83
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'frm_price_book
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(1068, 628)
        Me.Controls.Add(Me.grid_pricebooks)
        Me.Controls.Add(Me.panel_top)
        Me.Name = "frm_price_book"
        Me.Text = "frm_price_book"
        Me.panel_top.ResumeLayout(False)
        Me.panel_top.PerformLayout()
        Me.GunaPanel5.ResumeLayout(False)
        Me.GunaPanel1.ResumeLayout(False)
        Me.GunaPanel1.PerformLayout()
        CType(Me.grid_pricebooks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeliveryView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panel_top As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPanel5 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents link_po_list As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents link_home As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents grid_pricebooks As DevExpress.XtraGrid.GridControl
    Friend WithEvents DeliveryView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_pid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_model As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_action As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_base_price As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_cost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents col_discount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_regular_price As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_vip_price As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_dealer_price As DevExpress.XtraGrid.Columns.GridColumn
End Class
