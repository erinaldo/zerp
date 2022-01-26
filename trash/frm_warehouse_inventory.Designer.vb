<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_warehouse_inventory
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
        Me.panel_top = New Guna.UI.WinForms.GunaLinePanel()
        Me.GunaPanel2 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaPanel3 = New Guna.UI.WinForms.GunaPanel()
        Me.HyperlinkLabelControl1 = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.HyperlinkLabelControl2 = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.GunaLabel11 = New Guna.UI.WinForms.GunaLabel()
        Me.ims_inventory = New DevExpress.XtraGrid.GridControl()
        Me.ims_InventoryView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_pid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_model = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_desc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_qty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_on_hold = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_location = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btn_print = New DevExpress.XtraEditors.SimpleButton()
        Me.panel_top.SuspendLayout()
        Me.GunaPanel2.SuspendLayout()
        Me.GunaPanel3.SuspendLayout()
        CType(Me.ims_inventory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ims_InventoryView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel_top
        '
        Me.panel_top.BackColor = System.Drawing.Color.GhostWhite
        Me.panel_top.Controls.Add(Me.GunaPanel2)
        Me.panel_top.Controls.Add(Me.GunaLabel11)
        Me.panel_top.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_top.LineColor = System.Drawing.SystemColors.ControlLight
        Me.panel_top.LineStyle = System.Windows.Forms.BorderStyle.None
        Me.panel_top.Location = New System.Drawing.Point(0, 0)
        Me.panel_top.Name = "panel_top"
        Me.panel_top.Size = New System.Drawing.Size(1026, 78)
        Me.panel_top.TabIndex = 8
        '
        'GunaPanel2
        '
        Me.GunaPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaPanel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaPanel2.Controls.Add(Me.GunaPanel3)
        Me.GunaPanel2.Location = New System.Drawing.Point(19, 44)
        Me.GunaPanel2.Name = "GunaPanel2"
        Me.GunaPanel2.Size = New System.Drawing.Size(1004, 27)
        Me.GunaPanel2.TabIndex = 6
        '
        'GunaPanel3
        '
        Me.GunaPanel3.Controls.Add(Me.HyperlinkLabelControl1)
        Me.GunaPanel3.Controls.Add(Me.LabelControl1)
        Me.GunaPanel3.Controls.Add(Me.HyperlinkLabelControl2)
        Me.GunaPanel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.GunaPanel3.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel3.Name = "GunaPanel3"
        Me.GunaPanel3.Size = New System.Drawing.Size(435, 27)
        Me.GunaPanel3.TabIndex = 1
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
        Me.HyperlinkLabelControl1.Size = New System.Drawing.Size(96, 18)
        Me.HyperlinkLabelControl1.TabIndex = 7
        Me.HyperlinkLabelControl1.Text = "Stock Inventory"
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
        'GunaLabel11
        '
        Me.GunaLabel11.AutoSize = True
        Me.GunaLabel11.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.GunaLabel11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.GunaLabel11.Location = New System.Drawing.Point(14, 10)
        Me.GunaLabel11.Name = "GunaLabel11"
        Me.GunaLabel11.Size = New System.Drawing.Size(203, 31)
        Me.GunaLabel11.TabIndex = 1
        Me.GunaLabel11.Text = "Stock Inventory"
        '
        'ims_inventory
        '
        Me.ims_inventory.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ims_inventory.Font = New System.Drawing.Font("Nunito", 8.25!)
        Me.ims_inventory.Location = New System.Drawing.Point(20, 126)
        Me.ims_inventory.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.ims_inventory.LookAndFeel.UseDefaultLookAndFeel = False
        Me.ims_inventory.MainView = Me.ims_InventoryView
        Me.ims_inventory.Name = "ims_inventory"
        Me.ims_inventory.Size = New System.Drawing.Size(984, 496)
        Me.ims_inventory.TabIndex = 9
        Me.ims_inventory.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.ims_InventoryView})
        '
        'ims_InventoryView
        '
        Me.ims_InventoryView.Appearance.HeaderPanel.Font = New System.Drawing.Font("Nunito", 9.749999!)
        Me.ims_InventoryView.Appearance.HeaderPanel.Options.UseFont = True
        Me.ims_InventoryView.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.ims_InventoryView.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ims_InventoryView.Appearance.Row.Font = New System.Drawing.Font("Nunito", 9.749999!)
        Me.ims_InventoryView.Appearance.Row.Options.UseFont = True
        Me.ims_InventoryView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_pid, Me.col_model, Me.col_desc, Me.col_qty, Me.col_on_hold, Me.col_location})
        Me.ims_InventoryView.GridControl = Me.ims_inventory
        Me.ims_InventoryView.Name = "ims_InventoryView"
        Me.ims_InventoryView.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm
        Me.ims_InventoryView.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.[True]
        Me.ims_InventoryView.OptionsEditForm.ShowUpdateCancelPanel = DevExpress.Utils.DefaultBoolean.[False]
        Me.ims_InventoryView.OptionsLayout.Columns.AddNewColumns = False
        Me.ims_InventoryView.OptionsLayout.Columns.RemoveOldColumns = False
        '
        'col_pid
        '
        Me.col_pid.AppearanceCell.Options.UseTextOptions = True
        Me.col_pid.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_pid.Caption = "Product ID"
        Me.col_pid.FieldName = "product_id"
        Me.col_pid.Name = "col_pid"
        Me.col_pid.Visible = True
        Me.col_pid.VisibleIndex = 0
        Me.col_pid.Width = 87
        '
        'col_model
        '
        Me.col_model.AppearanceCell.Options.UseTextOptions = True
        Me.col_model.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_model.Caption = "Model"
        Me.col_model.FieldName = "winmodel"
        Me.col_model.Name = "col_model"
        Me.col_model.Visible = True
        Me.col_model.VisibleIndex = 1
        Me.col_model.Width = 140
        '
        'col_desc
        '
        Me.col_desc.Caption = "Description"
        Me.col_desc.FieldName = "description"
        Me.col_desc.Name = "col_desc"
        Me.col_desc.Visible = True
        Me.col_desc.VisibleIndex = 2
        Me.col_desc.Width = 404
        '
        'col_qty
        '
        Me.col_qty.AppearanceCell.Options.UseTextOptions = True
        Me.col_qty.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_qty.Caption = "Qty"
        Me.col_qty.FieldName = "qty"
        Me.col_qty.Name = "col_qty"
        Me.col_qty.Visible = True
        Me.col_qty.VisibleIndex = 3
        Me.col_qty.Width = 57
        '
        'col_on_hold
        '
        Me.col_on_hold.AppearanceCell.Options.UseTextOptions = True
        Me.col_on_hold.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_on_hold.Caption = "On-Hold"
        Me.col_on_hold.FieldName = "on_hold"
        Me.col_on_hold.Name = "col_on_hold"
        Me.col_on_hold.Visible = True
        Me.col_on_hold.VisibleIndex = 4
        '
        'col_location
        '
        Me.col_location.AppearanceCell.Options.UseTextOptions = True
        Me.col_location.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_location.Caption = "Location"
        Me.col_location.DisplayFormat.FormatString = "c2"
        Me.col_location.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.col_location.FieldName = "location"
        Me.col_location.Name = "col_location"
        Me.col_location.Visible = True
        Me.col_location.VisibleIndex = 5
        Me.col_location.Width = 108
        '
        'btn_print
        '
        Me.btn_print.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btn_print.Appearance.Options.UseFont = True
        Me.btn_print.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.print_16x16
        Me.btn_print.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_print.ImageOptions.ImageToTextIndent = 7
        Me.btn_print.Location = New System.Drawing.Point(20, 95)
        Me.btn_print.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_print.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(85, 25)
        Me.btn_print.TabIndex = 10
        Me.btn_print.Text = "Print"
        '
        'frm_warehouse_stock_inventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1026, 644)
        Me.Controls.Add(Me.btn_print)
        Me.Controls.Add(Me.ims_inventory)
        Me.Controls.Add(Me.panel_top)
        Me.Name = "frm_warehouse_stock_inventory"
        Me.Text = "frm_stock_location"
        Me.panel_top.ResumeLayout(False)
        Me.panel_top.PerformLayout()
        Me.GunaPanel2.ResumeLayout(False)
        Me.GunaPanel3.ResumeLayout(False)
        Me.GunaPanel3.PerformLayout()
        CType(Me.ims_inventory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ims_InventoryView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panel_top As Guna.UI.WinForms.GunaLinePanel
    Friend WithEvents GunaPanel2 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPanel3 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents HyperlinkLabelControl1 As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents HyperlinkLabelControl2 As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents GunaLabel11 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents ims_inventory As DevExpress.XtraGrid.GridControl
    Friend WithEvents ims_InventoryView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_pid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_model As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_desc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_location As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_print As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents col_on_hold As DevExpress.XtraGrid.Columns.GridColumn
End Class
