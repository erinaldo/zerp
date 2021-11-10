<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_warehouse_returns_dialog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_warehouse_returns_dialog))
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_srid = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_winmodel = New DevExpress.XtraEditors.LabelControl()
        Me.SuspendLayout()
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Location = New System.Drawing.Point(26, 164)
        Me.SimpleButton2.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.SimpleButton2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(212, 42)
        Me.SimpleButton2.TabIndex = 1
        Me.SimpleButton2.Text = "Return to Supplier"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary
        Me.SimpleButton1.Appearance.Options.UseBackColor = True
        Me.SimpleButton1.Location = New System.Drawing.Point(26, 116)
        Me.SimpleButton1.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.SimpleButton1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(212, 42)
        Me.SimpleButton1.TabIndex = 2
        Me.SimpleButton1.Text = "Item(s) is in Good Condition"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(98, 94)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(73, 13)
        Me.LabelControl1.TabIndex = 3
        Me.LabelControl1.Text = "Choose Action:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(26, 57)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(39, 16)
        Me.LabelControl2.TabIndex = 4
        Me.LabelControl2.Text = "Model:"
        '
        'lbl_srid
        '
        Me.lbl_srid.Appearance.BackColor = System.Drawing.Color.White
        Me.lbl_srid.Appearance.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_srid.Appearance.Options.UseBackColor = True
        Me.lbl_srid.Appearance.Options.UseFont = True
        Me.lbl_srid.Appearance.Options.UseTextOptions = True
        Me.lbl_srid.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lbl_srid.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_srid.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.lbl_srid.Location = New System.Drawing.Point(26, 12)
        Me.lbl_srid.Name = "lbl_srid"
        Me.lbl_srid.Size = New System.Drawing.Size(212, 38)
        Me.lbl_srid.TabIndex = 5
        Me.lbl_srid.Text = "SRID"
        '
        'lbl_winmodel
        '
        Me.lbl_winmodel.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_winmodel.Appearance.Options.UseFont = True
        Me.lbl_winmodel.Location = New System.Drawing.Point(71, 57)
        Me.lbl_winmodel.Name = "lbl_winmodel"
        Me.lbl_winmodel.Size = New System.Drawing.Size(81, 16)
        Me.lbl_winmodel.TabIndex = 6
        Me.lbl_winmodel.Text = "Sample Model"
        '
        'frm_warehouse_returns_dialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(261, 220)
        Me.Controls.Add(Me.lbl_winmodel)
        Me.Controls.Add(Me.lbl_srid)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_warehouse_returns_dialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Action"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_srid As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_winmodel As DevExpress.XtraEditors.LabelControl
End Class
