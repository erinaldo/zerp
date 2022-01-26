<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_admin_banks
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
        Me.grid_bank = New DevExpress.XtraGrid.GridControl()
        Me.grid_bank_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_edit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btn_edit = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.col_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_bank_name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_bank_acc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_status = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.toggle_status = New DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch()
        Me.btn_add = New DevExpress.XtraEditors.SimpleButton()
        Me.GunaPanel4.SuspendLayout()
        Me.GunaPanel5.SuspendLayout()
        Me.GunaPanel1.SuspendLayout()
        CType(Me.grid_bank, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_bank_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_edit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.toggle_status, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GunaPanel4.Size = New System.Drawing.Size(974, 78)
        Me.GunaPanel4.TabIndex = 9
        '
        'GunaPanel5
        '
        Me.GunaPanel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaPanel5.BackColor = System.Drawing.Color.Transparent
        Me.GunaPanel5.Controls.Add(Me.GunaPanel1)
        Me.GunaPanel5.Location = New System.Drawing.Point(19, 44)
        Me.GunaPanel5.Name = "GunaPanel5"
        Me.GunaPanel5.Size = New System.Drawing.Size(934, 27)
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
        Me.link_po_list.Size = New System.Drawing.Size(106, 18)
        Me.link_po_list.TabIndex = 7
        Me.link_po_list.Text = "Registered Banks"
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
        Me.GunaLabel2.Size = New System.Drawing.Size(229, 31)
        Me.GunaLabel2.TabIndex = 1
        Me.GunaLabel2.Text = "Registered Banks"
        '
        'grid_bank
        '
        Me.grid_bank.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_bank.Location = New System.Drawing.Point(19, 124)
        Me.grid_bank.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grid_bank.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grid_bank.MainView = Me.grid_bank_view
        Me.grid_bank.Name = "grid_bank"
        Me.grid_bank.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.toggle_status, Me.btn_edit})
        Me.grid_bank.Size = New System.Drawing.Size(937, 417)
        Me.grid_bank.TabIndex = 53
        Me.grid_bank.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_bank_view})
        '
        'grid_bank_view
        '
        Me.grid_bank_view.Appearance.HeaderPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.grid_bank_view.Appearance.HeaderPanel.Options.UseFont = True
        Me.grid_bank_view.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.grid_bank_view.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grid_bank_view.Appearance.Row.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.grid_bank_view.Appearance.Row.Options.UseFont = True
        Me.grid_bank_view.Appearance.Row.Options.UseTextOptions = True
        Me.grid_bank_view.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grid_bank_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_edit, Me.col_id, Me.col_bank_name, Me.col_bank_acc, Me.col_status})
        Me.grid_bank_view.GridControl = Me.grid_bank
        Me.grid_bank_view.Name = "grid_bank_view"
        Me.grid_bank_view.OptionsBehavior.ReadOnly = True
        '
        'col_edit
        '
        Me.col_edit.Caption = "Action"
        Me.col_edit.ColumnEdit = Me.btn_edit
        Me.col_edit.Name = "col_edit"
        Me.col_edit.Visible = True
        Me.col_edit.VisibleIndex = 0
        '
        'btn_edit
        '
        Me.btn_edit.AutoHeight = False
        EditorButtonImageOptions2.Image = Global.Inventory_Management.My.Resources.Resources.snapmodifytablecellstyle_16x16
        Me.btn_edit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions2, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, SerializableAppearanceObject6, SerializableAppearanceObject7, SerializableAppearanceObject8, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.btn_edit.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'col_id
        '
        Me.col_id.Caption = "Bank ID"
        Me.col_id.FieldName = "bank_id"
        Me.col_id.MaxWidth = 100
        Me.col_id.Name = "col_id"
        Me.col_id.Visible = True
        Me.col_id.VisibleIndex = 1
        Me.col_id.Width = 100
        '
        'col_bank_name
        '
        Me.col_bank_name.Caption = "Bank Name"
        Me.col_bank_name.FieldName = "bank_acc_name"
        Me.col_bank_name.Name = "col_bank_name"
        Me.col_bank_name.Visible = True
        Me.col_bank_name.VisibleIndex = 2
        Me.col_bank_name.Width = 407
        '
        'col_bank_acc
        '
        Me.col_bank_acc.Caption = "Bank Account No."
        Me.col_bank_acc.FieldName = "bank_acc_no"
        Me.col_bank_acc.Name = "col_bank_acc"
        Me.col_bank_acc.Visible = True
        Me.col_bank_acc.VisibleIndex = 3
        Me.col_bank_acc.Width = 301
        '
        'col_status
        '
        Me.col_status.Caption = "Status"
        Me.col_status.ColumnEdit = Me.toggle_status
        Me.col_status.FieldName = "is_enabled"
        Me.col_status.Name = "col_status"
        Me.col_status.Visible = True
        Me.col_status.VisibleIndex = 4
        Me.col_status.Width = 111
        '
        'toggle_status
        '
        Me.toggle_status.AutoHeight = False
        Me.toggle_status.LookAndFeel.SkinName = "VS2010"
        Me.toggle_status.LookAndFeel.UseDefaultLookAndFeel = False
        Me.toggle_status.Name = "toggle_status"
        Me.toggle_status.OffText = "Disabled"
        Me.toggle_status.OnText = "Enabled"
        '
        'btn_add
        '
        Me.btn_add.Appearance.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btn_add.Appearance.Options.UseBackColor = True
        Me.btn_add.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.add_16x162
        Me.btn_add.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_add.ImageOptions.ImageToTextIndent = 5
        Me.btn_add.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.CommonPalette
        Me.btn_add.ImageOptions.SvgImageSize = New System.Drawing.Size(10, 10)
        Me.btn_add.Location = New System.Drawing.Point(20, 91)
        Me.btn_add.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_add.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(135, 27)
        Me.btn_add.TabIndex = 54
        Me.btn_add.Text = "New Bank"
        '
        'frm_admin_banks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(974, 559)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.grid_bank)
        Me.Controls.Add(Me.GunaPanel4)
        Me.Name = "frm_admin_banks"
        Me.Text = "frm_admin_banks"
        Me.GunaPanel4.ResumeLayout(False)
        Me.GunaPanel4.PerformLayout()
        Me.GunaPanel5.ResumeLayout(False)
        Me.GunaPanel1.ResumeLayout(False)
        Me.GunaPanel1.PerformLayout()
        CType(Me.grid_bank, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_bank_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_edit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.toggle_status, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaPanel4 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPanel5 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents link_po_list As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents link_home As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents grid_bank As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_bank_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_bank_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_bank_acc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_add As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents toggle_status As DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch
    Friend WithEvents col_edit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_edit As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
End Class
