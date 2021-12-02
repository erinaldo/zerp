Imports DevExpress.LookAndFeel
Imports DevExpress.XtraEditors
Imports Guna.UI.WinForms
Imports System.ComponentModel
Imports System.Drawing.Drawing2D


<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_warehouse_deliveries
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
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.panel_view = New Guna.UI.WinForms.GunaLinePanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_open_receipt = New DevExpress.XtraEditors.SimpleButton()
        Me.grid_delivery = New DevExpress.XtraGrid.GridControl()
        Me.grid_delivery_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_lead_time = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_purchase_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_supplier = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_status = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_action = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btn_view = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.panel_top.SuspendLayout()
        Me.GunaPanel5.SuspendLayout()
        Me.GunaPanel1.SuspendLayout()
        Me.panel_view.SuspendLayout()
        CType(Me.grid_delivery, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_delivery_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_view, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.panel_top.Size = New System.Drawing.Size(1206, 78)
        Me.panel_top.TabIndex = 8
        '
        'GunaPanel5
        '
        Me.GunaPanel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaPanel5.BackColor = System.Drawing.Color.Transparent
        Me.GunaPanel5.Controls.Add(Me.GunaPanel1)
        Me.GunaPanel5.Location = New System.Drawing.Point(19, 44)
        Me.GunaPanel5.Name = "GunaPanel5"
        Me.GunaPanel5.Size = New System.Drawing.Size(1166, 27)
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
        Me.link_po_list.Size = New System.Drawing.Size(63, 18)
        Me.link_po_list.TabIndex = 7
        Me.link_po_list.Text = "Deliveries"
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
        Me.GunaLabel2.Size = New System.Drawing.Size(181, 31)
        Me.GunaLabel2.TabIndex = 1
        Me.GunaLabel2.Text = "Daily Delivery"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Tahoma", 16.0!)
        Me.GunaLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.GunaLabel1.Location = New System.Drawing.Point(14, 93)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(202, 27)
        Me.GunaLabel1.TabIndex = 6
        Me.GunaLabel1.Text = "Expected Deliveries"
        '
        'panel_view
        '
        Me.panel_view.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panel_view.BackColor = System.Drawing.Color.White
        Me.panel_view.Controls.Add(Me.Label1)
        Me.panel_view.LineBottom = 1
        Me.panel_view.LineColor = System.Drawing.Color.LightGray
        Me.panel_view.LineLeft = 1
        Me.panel_view.LineRight = 1
        Me.panel_view.LineStyle = System.Windows.Forms.BorderStyle.None
        Me.panel_view.LineTop = 1
        Me.panel_view.Location = New System.Drawing.Point(436, 84)
        Me.panel_view.Name = "panel_view"
        Me.panel_view.Size = New System.Drawing.Size(758, 566)
        Me.panel_view.TabIndex = 60
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(267, 256)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(264, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Double Click Deliveries to View"
        '
        'btn_open_receipt
        '
        Me.btn_open_receipt.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success
        Me.btn_open_receipt.Appearance.Options.UseBackColor = True
        Me.btn_open_receipt.Location = New System.Drawing.Point(320, 93)
        Me.btn_open_receipt.Name = "btn_open_receipt"
        Me.btn_open_receipt.Size = New System.Drawing.Size(89, 28)
        Me.btn_open_receipt.TabIndex = 61
        Me.btn_open_receipt.Text = "Open Receipt"
        '
        'grid_delivery
        '
        Me.grid_delivery.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grid_delivery.Location = New System.Drawing.Point(9, 127)
        Me.grid_delivery.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grid_delivery.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grid_delivery.MainView = Me.grid_delivery_view
        Me.grid_delivery.Name = "grid_delivery"
        Me.grid_delivery.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.btn_view})
        Me.grid_delivery.Size = New System.Drawing.Size(421, 509)
        Me.grid_delivery.TabIndex = 1
        Me.grid_delivery.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_delivery_view})
        '
        'grid_delivery_view
        '
        Me.grid_delivery_view.Appearance.HeaderPanel.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.grid_delivery_view.Appearance.HeaderPanel.Options.UseFont = True
        Me.grid_delivery_view.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.grid_delivery_view.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grid_delivery_view.Appearance.Row.Font = New System.Drawing.Font("Arial", 9.5!)
        Me.grid_delivery_view.Appearance.Row.Options.UseFont = True
        Me.grid_delivery_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_lead_time, Me.col_purchase_id, Me.col_supplier, Me.col_status, Me.col_action})
        Me.grid_delivery_view.GridControl = Me.grid_delivery
        Me.grid_delivery_view.Name = "grid_delivery_view"
        Me.grid_delivery_view.OptionsBehavior.ReadOnly = True
        Me.grid_delivery_view.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.[False]
        '
        'col_lead_time
        '
        Me.col_lead_time.Caption = "EDD"
        Me.col_lead_time.DisplayFormat.FormatString = "dd MMM"
        Me.col_lead_time.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col_lead_time.FieldName = "lead_time"
        Me.col_lead_time.MaxWidth = 70
        Me.col_lead_time.Name = "col_lead_time"
        Me.col_lead_time.OptionsColumn.AllowEdit = False
        Me.col_lead_time.Visible = True
        Me.col_lead_time.VisibleIndex = 1
        Me.col_lead_time.Width = 62
        '
        'col_purchase_id
        '
        Me.col_purchase_id.Caption = "Purchase ID"
        Me.col_purchase_id.FieldName = "poid"
        Me.col_purchase_id.MaxWidth = 90
        Me.col_purchase_id.Name = "col_purchase_id"
        Me.col_purchase_id.Visible = True
        Me.col_purchase_id.VisibleIndex = 2
        Me.col_purchase_id.Width = 79
        '
        'col_supplier
        '
        Me.col_supplier.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col_supplier.AppearanceCell.Options.UseFont = True
        Me.col_supplier.Caption = "Supplier"
        Me.col_supplier.FieldName = "supplier"
        Me.col_supplier.Name = "col_supplier"
        Me.col_supplier.Visible = True
        Me.col_supplier.VisibleIndex = 3
        Me.col_supplier.Width = 222
        '
        'col_status
        '
        Me.col_status.Caption = "Status"
        Me.col_status.FieldName = "lead_time_status"
        Me.col_status.Name = "col_status"
        '
        'col_action
        '
        Me.col_action.ColumnEdit = Me.btn_view
        Me.col_action.Name = "col_action"
        Me.col_action.Visible = True
        Me.col_action.VisibleIndex = 0
        Me.col_action.Width = 40
        '
        'btn_view
        '
        Me.btn_view.AutoHeight = False
        EditorButtonImageOptions1.Image = Global.Inventory_Management.My.Resources.Resources.up_16x16
        Me.btn_view.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.btn_view.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_view.Name = "btn_view"
        Me.btn_view.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'frm_warehouse_deliveries
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1206, 648)
        Me.Controls.Add(Me.grid_delivery)
        Me.Controls.Add(Me.btn_open_receipt)
        Me.Controls.Add(Me.panel_view)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.panel_top)
        Me.Name = "frm_warehouse_deliveries"
        Me.Text = "frm_deliveries"
        Me.panel_top.ResumeLayout(False)
        Me.panel_top.PerformLayout()
        Me.GunaPanel5.ResumeLayout(False)
        Me.GunaPanel1.ResumeLayout(False)
        Me.GunaPanel1.PerformLayout()
        Me.panel_view.ResumeLayout(False)
        Me.panel_view.PerformLayout()
        CType(Me.grid_delivery, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_delivery_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_view, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents panel_top As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPanel5 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents link_po_list As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents link_home As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents panel_view As Guna.UI.WinForms.GunaLinePanel
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_open_receipt As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grid_delivery As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_delivery_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_lead_time As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_purchase_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_supplier As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_action As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_view As Repository.RepositoryItemButtonEdit
End Class
