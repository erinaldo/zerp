Imports DevExpress.LookAndFeel
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports Guna.UI.WinForms
Imports System.ComponentModel
Imports System.Drawing.Drawing2D


<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_warehouse_delivery_logs
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
        Me.GunaPanel4 = New GunaPanel()
        Me.GunaPanel5 = New GunaPanel()
        Me.GunaPanel1 = New GunaPanel()
        Me.link_po_list = New HyperlinkLabelControl()
        Me.LabelControl7 = New LabelControl()
        Me.link_home = New HyperlinkLabelControl()
        Me.GunaLabel2 = New GunaLabel()
        Me.grid_delivered = New GridControl()
        Me.DeliveryView = New GridView()
        Me.GridColumn2 = New GridColumn()
        Me.GridColumn3 = New GridColumn()
        Me.col_action = New GridColumn()
        Me.GridColumn4 = New GridColumn()
        Me.GridColumn6 = New GridColumn()
        Me.RepositoryItemTextEdit1 = New RepositoryItemTextEdit()
        Me.GridColumn5 = New GridColumn()
        Me.col_supplier = New GridColumn()
        Me.col_description = New GridColumn()
        Me.col_cost = New GridColumn()
        Me.GridColumn7 = New GridColumn()
        Me.dt_end = New GunaDateTimePicker()
        Me.LabelControl2 = New LabelControl()
        Me.LabelControl1 = New LabelControl()
        Me.btn_view = New GunaButton()
        Me.dt_start = New GunaDateTimePicker()
        Me.GunaPanel4.SuspendLayout()
        Me.GunaPanel5.SuspendLayout()
        Me.GunaPanel1.SuspendLayout()
        DirectCast(Me.grid_delivered, ISupportInitialize).BeginInit()
        DirectCast(Me.DeliveryView, ISupportInitialize).BeginInit()
        DirectCast(Me.RepositoryItemTextEdit1, ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        Me.GunaPanel4.BackColor = Color.GhostWhite
        Me.GunaPanel4.Controls.Add(Me.GunaPanel5)
        Me.GunaPanel4.Controls.Add(Me.GunaLabel2)
        Me.GunaPanel4.Dock = DockStyle.Top
        Me.GunaPanel4.Location = New Point(0, 0)
        Me.GunaPanel4.Name = "GunaPanel4"
        Me.GunaPanel4.Size = New System.Drawing.Size(1299, 78)
        Me.GunaPanel4.TabIndex = 10
        Me.GunaPanel5.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Me.GunaPanel5.BackColor = Color.Transparent
        Me.GunaPanel5.Controls.Add(Me.GunaPanel1)
        Me.GunaPanel5.Location = New Point(19, 44)
        Me.GunaPanel5.Name = "GunaPanel5"
        Me.GunaPanel5.Size = New System.Drawing.Size(1268, 27)
        Me.GunaPanel5.TabIndex = 5
        Me.GunaPanel1.Controls.Add(Me.link_po_list)
        Me.GunaPanel1.Controls.Add(Me.LabelControl7)
        Me.GunaPanel1.Controls.Add(Me.link_home)
        Me.GunaPanel1.Dock = DockStyle.Left
        Me.GunaPanel1.Location = New Point(0, 0)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(435, 27)
        Me.GunaPanel1.TabIndex = 0
        Me.link_po_list.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, FontStyle.Regular, GraphicsUnit.Point, 0)
        Me.link_po_list.Appearance.LinkColor = DXSkinColors.ForeColors.ControlText
        Me.link_po_list.Appearance.Options.UseFont = True
        Me.link_po_list.Appearance.Options.UseLinkColor = True
        Me.link_po_list.AppearanceHovered.ForeColor = Color.FromArgb(0, 122, 204)
        Me.link_po_list.AppearanceHovered.LinkColor = Color.FromArgb(0, 122, 204)
        Me.link_po_list.AppearanceHovered.Options.UseForeColor = True
        Me.link_po_list.AppearanceHovered.Options.UseLinkColor = True
        Me.link_po_list.AppearancePressed.LinkColor = Color.FromArgb(0, 122, 204)
        Me.link_po_list.AppearancePressed.Options.UseLinkColor = True
        Me.link_po_list.LineStyle = DashStyle.Custom
        Me.link_po_list.LinkBehavior = LinkBehavior.NeverUnderline
        Me.link_po_list.Location = New Point(70, 5)
        Me.link_po_list.Name = "link_po_list"
        Me.link_po_list.ShowLineShadow = False
        Me.link_po_list.Size = New System.Drawing.Size(82, 18)
        Me.link_po_list.TabIndex = 7
        Me.link_po_list.Text = "Delivery Logs"
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Location = New Point(55, 7)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(9, 14)
        Me.LabelControl7.TabIndex = 6
        Me.LabelControl7.Text = ">"
        Me.link_home.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, FontStyle.Regular, GraphicsUnit.Point, 0)
        Me.link_home.Appearance.LinkColor = DXSkinColors.ForeColors.ControlText
        Me.link_home.Appearance.Options.UseFont = True
        Me.link_home.Appearance.Options.UseLinkColor = True
        Me.link_home.AppearanceDisabled.LinkColor = Color.FromArgb(0, 122, 204)
        Me.link_home.AppearanceDisabled.Options.UseLinkColor = True
        Me.link_home.AppearanceHovered.ForeColor = Color.FromArgb(0, 122, 204)
        Me.link_home.AppearanceHovered.LinkColor = Color.FromArgb(0, 122, 204)
        Me.link_home.AppearanceHovered.Options.UseForeColor = True
        Me.link_home.AppearanceHovered.Options.UseLinkColor = True
        Me.link_home.AppearancePressed.LinkColor = Color.FromArgb(0, 122, 204)
        Me.link_home.AppearancePressed.Options.UseLinkColor = True
        Me.link_home.LineStyle = DashStyle.Custom
        Me.link_home.LinkBehavior = LinkBehavior.NeverUnderline
        Me.link_home.Location = New Point(13, 5)
        Me.link_home.Name = "link_home"
        Me.link_home.ShowLineShadow = False
        Me.link_home.Size = New System.Drawing.Size(37, 18)
        Me.link_home.TabIndex = 5
        Me.link_home.Text = "Home"
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.GunaLabel2.ForeColor = Color.FromArgb(213, 115, 45)
        Me.GunaLabel2.Location = New Point(14, 10)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(179, 31)
        Me.GunaLabel2.TabIndex = 1
        Me.GunaLabel2.Text = "Delivery Logs"
        Me.grid_delivered.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Me.grid_delivered.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.grid_delivered.Location = New Point(12, 148)
        Me.grid_delivered.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grid_delivered.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grid_delivered.MainView = Me.DeliveryView
        Me.grid_delivered.Name = "grid_delivered"
        Me.grid_delivered.RepositoryItems.AddRange(New RepositoryItem() {Me.RepositoryItemTextEdit1})
        Me.grid_delivered.Size = New System.Drawing.Size(1275, 476)
        Me.grid_delivered.TabIndex = 11
        Me.grid_delivered.ViewCollection.AddRange(New BaseView() {Me.DeliveryView})
        Me.DeliveryView.Appearance.HeaderPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.DeliveryView.Appearance.HeaderPanel.Options.UseFont = True
        Me.DeliveryView.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.DeliveryView.Appearance.HeaderPanel.TextOptions.HAlignment = HorzAlignment.Center
        Me.DeliveryView.Appearance.Row.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, FontStyle.Regular, GraphicsUnit.Point, 0)
        Me.DeliveryView.Appearance.Row.Options.UseFont = True
        Me.DeliveryView.Columns.AddRange(New GridColumn() {Me.GridColumn2, Me.GridColumn3, Me.col_action, Me.GridColumn4, Me.GridColumn6, Me.GridColumn5, Me.col_supplier, Me.col_description, Me.col_cost})
        Me.DeliveryView.GridControl = Me.grid_delivered
        Me.DeliveryView.HorzScrollVisibility = ScrollVisibility.Always
        Me.DeliveryView.Name = "DeliveryView"
        Me.DeliveryView.OptionsBehavior.Editable = False
        Me.DeliveryView.OptionsBehavior.[ReadOnly] = True
        Me.DeliveryView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.DeliveryView.OptionsView.AutoCalcPreviewLineCount = True
        Me.GridColumn2.Caption = "Model"
        Me.GridColumn2.FieldName = "winmodel"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 2
        Me.GridColumn2.Width = 80
        Me.GridColumn3.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Far
        Me.GridColumn3.Caption = "Qty"
        Me.GridColumn3.FieldName = "qty"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 1
        Me.GridColumn3.Width = 72
        Me.col_action.Caption = "Warehouse"
        Me.col_action.FieldName = "store_name"
        Me.col_action.MaxWidth = 250
        Me.col_action.MinWidth = 150
        Me.col_action.Name = "col_action"
        Me.col_action.Visible = True
        Me.col_action.VisibleIndex = 5
        Me.col_action.Width = 180
        Me.GridColumn4.Caption = "Purchase ID"
        Me.GridColumn4.FieldName = "poid"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 7
        Me.GridColumn4.Width = 78
        Me.GridColumn6.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn6.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center
        Me.GridColumn6.Caption = "Timestamp"
        Me.GridColumn6.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.GridColumn6.DisplayFormat.FormatString = "0:h:mm tt MM/dd/yyyy"
        Me.GridColumn6.DisplayFormat.FormatType = FormatType.DateTime
        Me.GridColumn6.FieldName = "date_received"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 0
        Me.GridColumn6.Width = 129
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        Me.GridColumn5.Caption = "Receiver"
        Me.GridColumn5.FieldName = "first_name"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 8
        Me.GridColumn5.Width = 99
        Me.col_supplier.Caption = "Supplier"
        Me.col_supplier.FieldName = "supplier"
        Me.col_supplier.MinWidth = 250
        Me.col_supplier.Name = "col_supplier"
        Me.col_supplier.Visible = True
        Me.col_supplier.VisibleIndex = 6
        Me.col_supplier.Width = 262
        Me.col_description.Caption = "Description"
        Me.col_description.FieldName = "description"
        Me.col_description.MinWidth = 250
        Me.col_description.Name = "col_description"
        Me.col_description.Visible = True
        Me.col_description.VisibleIndex = 3
        Me.col_description.Width = 268
        Me.col_cost.Caption = "Cost"
        Me.col_cost.DisplayFormat.FormatString = "n2"
        Me.col_cost.DisplayFormat.FormatType = FormatType.Numeric
        Me.col_cost.FieldName = "cost"
        Me.col_cost.Name = "col_cost"
        Me.col_cost.Visible = True
        Me.col_cost.VisibleIndex = 4
        Me.col_cost.Width = 89
        Me.GridColumn7.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn7.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center
        Me.GridColumn7.Caption = "Purchase ID"
        Me.GridColumn7.FieldName = "poid"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 3
        Me.GridColumn7.Width = 109
        Me.dt_end.BackColor = Color.Transparent
        Me.dt_end.BaseColor = Color.White
        Me.dt_end.BorderColor = Color.Silver
        Me.dt_end.BorderSize = 1
        Me.dt_end.CustomFormat = "MMMM dd, yyyy"
        Me.dt_end.DropDownAlign = LeftRightAlignment.Right
        Me.dt_end.FocusedColor = Color.FromArgb(100, 88, 255)
        Me.dt_end.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dt_end.ForeColor = Color.Black
        Me.dt_end.Format = DateTimePickerFormat.Custom
        Me.dt_end.Location = New Point(259, 106)
        Me.dt_end.MaxDate = New DateTime(9998, 12, 31, 0, 0, 0, 0)
        Me.dt_end.MinDate = New DateTime(1753, 1, 1, 0, 0, 0, 0)
        Me.dt_end.Name = "dt_end"
        Me.dt_end.OnHoverBaseColor = Color.White
        Me.dt_end.OnHoverBorderColor = Color.FromArgb(100, 88, 255)
        Me.dt_end.OnHoverForeColor = Color.FromArgb(100, 88, 255)
        Me.dt_end.OnPressedColor = Color.Black
        Me.dt_end.Size = New System.Drawing.Size(152, 30)
        Me.dt_end.TabIndex = 23
        Me.dt_end.Text = "October 20, 2020"
        Me.dt_end.Value = New DateTime(2020, 10, 20, 10, 38, 39, 28)
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, FontStyle.Regular, GraphicsUnit.Point, 0)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New Point(242, 113)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(11, 16)
        Me.LabelControl2.TabIndex = 22
        Me.LabelControl2.Text = "to"
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, FontStyle.Regular, GraphicsUnit.Point, 0)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New Point(12, 113)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(63, 16)
        Me.LabelControl1.TabIndex = 21
        Me.LabelControl1.Text = "Coverage:"
        Me.btn_view.AnimationHoverSpeed = 0.07!
        Me.btn_view.AnimationSpeed = 0.03!
        Me.btn_view.BackColor = Color.Transparent
        Me.btn_view.BaseColor = Color.Gray
        Me.btn_view.BorderColor = Color.Gray
        Me.btn_view.BorderSize = 1
        Me.btn_view.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_view.FocusedColor = Color.Empty
        Me.btn_view.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_view.ForeColor = Color.White
        Me.btn_view.Image = Nothing
        Me.btn_view.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_view.Location = New Point(417, 107)
        Me.btn_view.Name = "btn_view"
        Me.btn_view.OnHoverBaseColor = Color.FromArgb(213, 115, 45)
        Me.btn_view.OnHoverBorderColor = Color.FromArgb(213, 115, 45)
        Me.btn_view.OnHoverForeColor = Color.White
        Me.btn_view.OnHoverImage = Nothing
        Me.btn_view.OnPressedColor = Color.Black
        Me.btn_view.Radius = 2
        Me.btn_view.Size = New System.Drawing.Size(103, 28)
        Me.btn_view.TabIndex = 20
        Me.btn_view.Text = "View"
        Me.btn_view.TextAlign = HorizontalAlignment.Center
        Me.dt_start.BackColor = Color.Transparent
        Me.dt_start.BaseColor = Color.White
        Me.dt_start.BorderColor = Color.Silver
        Me.dt_start.BorderSize = 1
        Me.dt_start.CustomFormat = "MMMM dd, yyyy"
        Me.dt_start.DropDownAlign = LeftRightAlignment.Right
        Me.dt_start.FocusedColor = Color.FromArgb(100, 88, 255)
        Me.dt_start.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dt_start.ForeColor = Color.Black
        Me.dt_start.Format = DateTimePickerFormat.Custom
        Me.dt_start.Location = New Point(79, 106)
        Me.dt_start.MaxDate = New DateTime(9998, 12, 31, 0, 0, 0, 0)
        Me.dt_start.MinDate = New DateTime(1753, 1, 1, 0, 0, 0, 0)
        Me.dt_start.Name = "dt_start"
        Me.dt_start.OnHoverBaseColor = Color.White
        Me.dt_start.OnHoverBorderColor = Color.FromArgb(100, 88, 255)
        Me.dt_start.OnHoverForeColor = Color.FromArgb(100, 88, 255)
        Me.dt_start.OnPressedColor = Color.Black
        Me.dt_start.Size = New System.Drawing.Size(157, 30)
        Me.dt_start.TabIndex = 19
        Me.dt_start.Text = "October 20, 2020"
        Me.dt_start.Value = New DateTime(2020, 10, 20, 11, 17, 55, 279)
        Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = Color.White
        Me.ClientSize = New System.Drawing.Size(1299, 636)
        Me.Controls.Add(Me.dt_end)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.btn_view)
        Me.Controls.Add(Me.dt_start)
        Me.Controls.Add(Me.grid_delivered)
        Me.Controls.Add(Me.GunaPanel4)
        Me.Name = "frm_warehouse_delivery_logs"
        Me.Text = "frm_delivery_logs"
        Me.GunaPanel4.ResumeLayout(False)
        Me.GunaPanel4.PerformLayout()
        Me.GunaPanel5.ResumeLayout(False)
        Me.GunaPanel1.ResumeLayout(False)
        Me.GunaPanel1.PerformLayout()
        DirectCast(Me.grid_delivered, ISupportInitialize).EndInit()
        DirectCast(Me.DeliveryView, ISupportInitialize).EndInit()
        DirectCast(Me.RepositoryItemTextEdit1, ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaPanel4 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPanel5 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents link_po_list As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents link_home As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents grid_delivered As DevExpress.XtraGrid.GridControl
    Friend WithEvents DeliveryView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_action As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dt_end As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_view As Guna.UI.WinForms.GunaButton
    Friend WithEvents dt_start As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents col_supplier As GridColumn
    Friend WithEvents col_description As GridColumn
    Friend WithEvents col_cost As GridColumn
End Class
