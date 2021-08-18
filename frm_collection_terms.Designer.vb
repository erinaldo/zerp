<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_collection_terms
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_collection_terms))
        Me.GunaPanel2 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaPanel3 = New Guna.UI.WinForms.GunaPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.cbb_timer = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.GunaPanel4 = New Guna.UI.WinForms.GunaPanel()
        Me.HyperlinkLabelControl1 = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.HyperlinkLabelControl2 = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.grid_terms = New DevExpress.XtraGrid.GridControl()
        Me.grid_terms_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn21 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn20 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn26 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn27 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.timer = New System.Windows.Forms.Timer(Me.components)
        Me.GunaPanel2.SuspendLayout()
        Me.GunaPanel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbb_timer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaPanel4.SuspendLayout()
        CType(Me.grid_terms, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_terms_view, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GunaPanel2.Size = New System.Drawing.Size(1131, 78)
        Me.GunaPanel2.TabIndex = 14
        '
        'GunaPanel3
        '
        Me.GunaPanel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaPanel3.BackColor = System.Drawing.Color.Transparent
        Me.GunaPanel3.Controls.Add(Me.Panel2)
        Me.GunaPanel3.Controls.Add(Me.GunaPanel4)
        Me.GunaPanel3.Location = New System.Drawing.Point(19, 44)
        Me.GunaPanel3.Name = "GunaPanel3"
        Me.GunaPanel3.Size = New System.Drawing.Size(1113, 27)
        Me.GunaPanel3.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.PictureEdit1)
        Me.Panel2.Controls.Add(Me.cbb_timer)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(1001, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(112, 27)
        Me.Panel2.TabIndex = 8
        '
        'PictureEdit1
        '
        Me.PictureEdit1.EditValue = CType(resources.GetObject("PictureEdit1.EditValue"), Object)
        Me.PictureEdit1.Location = New System.Drawing.Point(13, 4)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.PictureEdit1.Size = New System.Drawing.Size(20, 20)
        Me.PictureEdit1.TabIndex = 6
        '
        'cbb_timer
        '
        Me.cbb_timer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbb_timer.EditValue = "1 min"
        Me.cbb_timer.Location = New System.Drawing.Point(37, 4)
        Me.cbb_timer.Name = "cbb_timer"
        Me.cbb_timer.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cbb_timer.Properties.Appearance.Options.UseFont = True
        Me.cbb_timer.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_timer.Properties.Items.AddRange(New Object() {"1 min", "5 min", "10 min", "30 min"})
        Me.cbb_timer.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cbb_timer.Size = New System.Drawing.Size(65, 20)
        Me.cbb_timer.TabIndex = 4
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
        Me.HyperlinkLabelControl1.Size = New System.Drawing.Size(104, 18)
        Me.HyperlinkLabelControl1.TabIndex = 7
        Me.HyperlinkLabelControl1.Text = "Terms Collection"
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
        Me.GunaLabel1.Size = New System.Drawing.Size(218, 31)
        Me.GunaLabel1.TabIndex = 1
        Me.GunaLabel1.Text = "Terms Collection"
        '
        'grid_terms
        '
        Me.grid_terms.Location = New System.Drawing.Point(19, 95)
        Me.grid_terms.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grid_terms.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grid_terms.MainView = Me.grid_terms_view
        Me.grid_terms.Name = "grid_terms"
        Me.grid_terms.Size = New System.Drawing.Size(1095, 548)
        Me.grid_terms.TabIndex = 18
        Me.grid_terms.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_terms_view})
        '
        'grid_terms_view
        '
        Me.grid_terms_view.Appearance.HeaderPanel.BackColor = System.Drawing.Color.White
        Me.grid_terms_view.Appearance.HeaderPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.grid_terms_view.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grid_terms_view.Appearance.HeaderPanel.Options.UseFont = True
        Me.grid_terms_view.Appearance.Row.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.grid_terms_view.Appearance.Row.Options.UseFont = True
        Me.grid_terms_view.Appearance.SelectedRow.BackColor = System.Drawing.Color.White
        Me.grid_terms_view.Appearance.SelectedRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.grid_terms_view.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grid_terms_view.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grid_terms_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn11, Me.GridColumn12, Me.GridColumn13, Me.GridColumn14, Me.GridColumn16, Me.GridColumn17, Me.GridColumn21, Me.GridColumn15, Me.GridColumn20, Me.GridColumn26, Me.GridColumn27})
        Me.grid_terms_view.GridControl = Me.grid_terms
        Me.grid_terms_view.Name = "grid_terms_view"
        Me.grid_terms_view.OptionsBehavior.Editable = False
        Me.grid_terms_view.OptionsBehavior.ReadOnly = True
        Me.grid_terms_view.OptionsSelection.ResetSelectionClickOutsideCheckboxSelector = True
        Me.grid_terms_view.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.[False]
        '
        'GridColumn11
        '
        Me.GridColumn11.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn11.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn11.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn11.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.GridColumn11.AppearanceHeader.Options.UseFont = True
        Me.GridColumn11.AppearanceHeader.Options.UseForeColor = True
        Me.GridColumn11.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn11.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn11.Caption = "Order ID"
        Me.GridColumn11.FieldName = "order_id"
        Me.GridColumn11.MaxWidth = 100
        Me.GridColumn11.MinWidth = 50
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 0
        Me.GridColumn11.Width = 68
        '
        'GridColumn12
        '
        Me.GridColumn12.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn12.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.GridColumn12.AppearanceHeader.Options.UseFont = True
        Me.GridColumn12.AppearanceHeader.Options.UseForeColor = True
        Me.GridColumn12.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn12.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn12.Caption = "Representative"
        Me.GridColumn12.FieldName = "agent"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 5
        Me.GridColumn12.Width = 126
        '
        'GridColumn13
        '
        Me.GridColumn13.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn13.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.GridColumn13.AppearanceHeader.Options.UseFont = True
        Me.GridColumn13.AppearanceHeader.Options.UseForeColor = True
        Me.GridColumn13.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn13.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn13.Caption = "Customer"
        Me.GridColumn13.FieldName = "customer"
        Me.GridColumn13.MinWidth = 50
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 4
        Me.GridColumn13.Width = 136
        '
        'GridColumn14
        '
        Me.GridColumn14.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn14.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn14.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn14.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.GridColumn14.AppearanceHeader.Options.UseFont = True
        Me.GridColumn14.AppearanceHeader.Options.UseForeColor = True
        Me.GridColumn14.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn14.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn14.Caption = "Order Date"
        Me.GridColumn14.FieldName = "date_ordered"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 6
        Me.GridColumn14.Width = 110
        '
        'GridColumn16
        '
        Me.GridColumn16.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn16.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn16.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn16.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.GridColumn16.AppearanceHeader.Options.UseFont = True
        Me.GridColumn16.AppearanceHeader.Options.UseForeColor = True
        Me.GridColumn16.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn16.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn16.Caption = "Terms (Days)"
        Me.GridColumn16.FieldName = "terms"
        Me.GridColumn16.Name = "GridColumn16"
        Me.GridColumn16.Visible = True
        Me.GridColumn16.VisibleIndex = 7
        Me.GridColumn16.Width = 95
        '
        'GridColumn17
        '
        Me.GridColumn17.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn17.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn17.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn17.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.GridColumn17.AppearanceHeader.Options.UseFont = True
        Me.GridColumn17.AppearanceHeader.Options.UseForeColor = True
        Me.GridColumn17.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn17.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn17.Caption = "Remaining (Days)"
        Me.GridColumn17.FieldName = "remaining"
        Me.GridColumn17.Name = "GridColumn17"
        Me.GridColumn17.Visible = True
        Me.GridColumn17.VisibleIndex = 8
        Me.GridColumn17.Width = 117
        '
        'GridColumn21
        '
        Me.GridColumn21.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn21.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn21.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn21.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.GridColumn21.AppearanceHeader.Options.UseFont = True
        Me.GridColumn21.AppearanceHeader.Options.UseForeColor = True
        Me.GridColumn21.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn21.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn21.Caption = "Classification"
        Me.GridColumn21.FieldName = "classification"
        Me.GridColumn21.Name = "GridColumn21"
        Me.GridColumn21.Visible = True
        Me.GridColumn21.VisibleIndex = 9
        Me.GridColumn21.Width = 108
        '
        'GridColumn15
        '
        Me.GridColumn15.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn15.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn15.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn15.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.GridColumn15.AppearanceHeader.Options.UseFont = True
        Me.GridColumn15.AppearanceHeader.Options.UseForeColor = True
        Me.GridColumn15.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn15.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn15.Caption = "Amount Due"
        Me.GridColumn15.DisplayFormat.FormatString = "c2"
        Me.GridColumn15.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn15.FieldName = "amount_due"
        Me.GridColumn15.MaxWidth = 200
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.Visible = True
        Me.GridColumn15.VisibleIndex = 10
        Me.GridColumn15.Width = 109
        '
        'GridColumn20
        '
        Me.GridColumn20.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn20.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn20.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn20.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.GridColumn20.AppearanceHeader.Options.UseFont = True
        Me.GridColumn20.AppearanceHeader.Options.UseForeColor = True
        Me.GridColumn20.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn20.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn20.Caption = "Payment"
        Me.GridColumn20.FieldName = "payment_status"
        Me.GridColumn20.Name = "GridColumn20"
        Me.GridColumn20.Visible = True
        Me.GridColumn20.VisibleIndex = 3
        Me.GridColumn20.Width = 109
        '
        'GridColumn26
        '
        Me.GridColumn26.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn26.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.GridColumn26.AppearanceHeader.Options.UseFont = True
        Me.GridColumn26.AppearanceHeader.Options.UseForeColor = True
        Me.GridColumn26.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn26.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn26.Caption = "Order Status"
        Me.GridColumn26.FieldName = "status"
        Me.GridColumn26.Name = "GridColumn26"
        Me.GridColumn26.Visible = True
        Me.GridColumn26.VisibleIndex = 2
        Me.GridColumn26.Width = 77
        '
        'GridColumn27
        '
        Me.GridColumn27.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn27.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.GridColumn27.AppearanceHeader.Options.UseFont = True
        Me.GridColumn27.AppearanceHeader.Options.UseForeColor = True
        Me.GridColumn27.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn27.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn27.Caption = "Ship Type"
        Me.GridColumn27.FieldName = "shipping_method"
        Me.GridColumn27.Name = "GridColumn27"
        Me.GridColumn27.Visible = True
        Me.GridColumn27.VisibleIndex = 1
        Me.GridColumn27.Width = 74
        '
        'timer
        '
        '
        'frm_collection_terms
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1131, 657)
        Me.Controls.Add(Me.grid_terms)
        Me.Controls.Add(Me.GunaPanel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_collection_terms"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Terms Collection"
        Me.GunaPanel2.ResumeLayout(False)
        Me.GunaPanel2.PerformLayout()
        Me.GunaPanel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbb_timer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaPanel4.ResumeLayout(False)
        Me.GunaPanel4.PerformLayout()
        CType(Me.grid_terms, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_terms_view, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaPanel2 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPanel3 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents cbb_timer As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents GunaPanel4 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents HyperlinkLabelControl1 As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents HyperlinkLabelControl2 As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents grid_terms As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_terms_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn21 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn20 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn26 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn27 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents timer As Timer
End Class
