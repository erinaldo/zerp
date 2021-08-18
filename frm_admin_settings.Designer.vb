<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_admin_settings
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
        Me.GunaPanel4 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaPanel5 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.link_po_list = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.link_home = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.TileNavCategory1 = New DevExpress.XtraBars.Navigation.TileNavCategory()
        Me.nav_documents = New DevExpress.XtraBars.Navigation.NavigationPane()
        Me.NavigationPage1 = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.btn_save = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_storeinfo = New DevExpress.XtraEditors.MemoEdit()
        Me.NavigationPage2 = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.GunaPanel4.SuspendLayout()
        Me.GunaPanel5.SuspendLayout()
        Me.GunaPanel1.SuspendLayout()
        CType(Me.nav_documents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.nav_documents.SuspendLayout()
        Me.NavigationPage1.SuspendLayout()
        CType(Me.txt_storeinfo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GunaPanel4.Size = New System.Drawing.Size(956, 78)
        Me.GunaPanel4.TabIndex = 12
        '
        'GunaPanel5
        '
        Me.GunaPanel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaPanel5.BackColor = System.Drawing.Color.Transparent
        Me.GunaPanel5.Controls.Add(Me.GunaPanel1)
        Me.GunaPanel5.Location = New System.Drawing.Point(19, 44)
        Me.GunaPanel5.Name = "GunaPanel5"
        Me.GunaPanel5.Size = New System.Drawing.Size(921, 27)
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
        Me.GunaPanel1.TabIndex = 0
        '
        'link_po_list
        '
        Me.link_po_list.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.link_po_list.Appearance.LinkColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.link_po_list.Appearance.Options.UseFont = True
        Me.link_po_list.Appearance.Options.UseLinkColor = True
        Me.link_po_list.AppearanceHovered.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.link_po_list.AppearanceHovered.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.link_po_list.AppearanceHovered.Options.UseForeColor = True
        Me.link_po_list.AppearanceHovered.Options.UseLinkColor = True
        Me.link_po_list.AppearancePressed.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.link_po_list.AppearancePressed.Options.UseLinkColor = True
        Me.link_po_list.LineStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.link_po_list.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.link_po_list.Location = New System.Drawing.Point(70, 5)
        Me.link_po_list.Name = "link_po_list"
        Me.link_po_list.ShowLineShadow = False
        Me.link_po_list.Size = New System.Drawing.Size(50, 18)
        Me.link_po_list.TabIndex = 7
        Me.link_po_list.Text = "Settings"
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
        Me.GunaLabel2.Size = New System.Drawing.Size(113, 31)
        Me.GunaLabel2.TabIndex = 1
        Me.GunaLabel2.Text = "Settings"
        '
        'TileNavCategory1
        '
        Me.TileNavCategory1.Name = "TileNavCategory1"
        '
        '
        '
        Me.TileNavCategory1.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty
        '
        'nav_documents
        '
        Me.nav_documents.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nav_documents.Controls.Add(Me.NavigationPage1)
        Me.nav_documents.Controls.Add(Me.NavigationPage2)
        Me.nav_documents.Location = New System.Drawing.Point(0, 98)
        Me.nav_documents.LookAndFeel.SkinName = "Office 2013"
        Me.nav_documents.LookAndFeel.UseDefaultLookAndFeel = False
        Me.nav_documents.Name = "nav_documents"
        Me.nav_documents.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.NavigationPage1, Me.NavigationPage2})
        Me.nav_documents.RegularSize = New System.Drawing.Size(940, 504)
        Me.nav_documents.SelectedPage = Me.NavigationPage1
        Me.nav_documents.Size = New System.Drawing.Size(940, 504)
        Me.nav_documents.TabIndex = 13
        Me.nav_documents.Text = "Documents Informations"
        '
        'NavigationPage1
        '
        Me.NavigationPage1.Caption = "Documents Informations"
        Me.NavigationPage1.Controls.Add(Me.LabelControl2)
        Me.NavigationPage1.Controls.Add(Me.btn_save)
        Me.NavigationPage1.Controls.Add(Me.LabelControl1)
        Me.NavigationPage1.Controls.Add(Me.txt_storeinfo)
        Me.NavigationPage1.Name = "NavigationPage1"
        Me.NavigationPage1.Size = New System.Drawing.Size(784, 443)
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(115, 100)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(75, 23)
        Me.btn_save.TabIndex = 2
        Me.btn_save.Text = "Save"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(20, 33)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(89, 13)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Store Information:"
        '
        'txt_storeinfo
        '
        Me.txt_storeinfo.Location = New System.Drawing.Point(115, 32)
        Me.txt_storeinfo.Name = "txt_storeinfo"
        Me.txt_storeinfo.Size = New System.Drawing.Size(420, 62)
        Me.txt_storeinfo.TabIndex = 0
        '
        'NavigationPage2
        '
        Me.NavigationPage2.Caption = "Payments"
        Me.NavigationPage2.Name = "NavigationPage2"
        Me.NavigationPage2.Size = New System.Drawing.Size(784, 519)
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(20, 149)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(118, 13)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "Quotation Notes Presets"
        '
        'frm_admin_settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(956, 638)
        Me.Controls.Add(Me.nav_documents)
        Me.Controls.Add(Me.GunaPanel4)
        Me.Name = "frm_admin_settings"
        Me.Text = "frm_settings"
        Me.GunaPanel4.ResumeLayout(False)
        Me.GunaPanel4.PerformLayout()
        Me.GunaPanel5.ResumeLayout(False)
        Me.GunaPanel1.ResumeLayout(False)
        Me.GunaPanel1.PerformLayout()
        CType(Me.nav_documents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.nav_documents.ResumeLayout(False)
        Me.NavigationPage1.ResumeLayout(False)
        Me.NavigationPage1.PerformLayout()
        CType(Me.txt_storeinfo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaPanel4 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPanel5 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents link_po_list As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents link_home As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents TileNavCategory1 As DevExpress.XtraBars.Navigation.TileNavCategory
    Friend WithEvents nav_documents As DevExpress.XtraBars.Navigation.NavigationPane
    Friend WithEvents NavigationPage1 As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents NavigationPage2 As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_storeinfo As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents btn_save As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
End Class
