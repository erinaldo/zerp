﻿Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports Guna.UI.WinForms
Imports System.ComponentModel
Imports System.Runtime.CompilerServices

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_splash_screen
    Inherits DevExpress.XtraSplashScreen.SplashScreen

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_splash_screen))
        Me.panel_top = New Guna.UI.WinForms.GunaGradientPanel()
        Me.lbl_version = New DevExpress.XtraEditors.LabelControl()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.lbl_status = New DevExpress.XtraEditors.LabelControl()
        Me.labelCopyright = New DevExpress.XtraEditors.LabelControl()
        Me.panel_top.SuspendLayout()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel_top
        '
        Me.panel_top.BackgroundImage = CType(resources.GetObject("panel_top.BackgroundImage"), System.Drawing.Image)
        Me.panel_top.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panel_top.Controls.Add(Me.lbl_version)
        Me.panel_top.Controls.Add(Me.PictureEdit1)
        Me.panel_top.Controls.Add(Me.lbl_status)
        Me.panel_top.Controls.Add(Me.labelCopyright)
        Me.panel_top.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_top.GradientColor1 = System.Drawing.Color.GhostWhite
        Me.panel_top.GradientColor2 = System.Drawing.Color.LightSteelBlue
        Me.panel_top.GradientColor3 = System.Drawing.Color.White
        Me.panel_top.GradientColor4 = System.Drawing.Color.White
        Me.panel_top.Location = New System.Drawing.Point(1, 1)
        Me.panel_top.Name = "panel_top"
        Me.panel_top.Size = New System.Drawing.Size(448, 318)
        Me.panel_top.TabIndex = 15
        Me.panel_top.Text = "GunaGradientPanel1"
        '
        'lbl_version
        '
        Me.lbl_version.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lbl_version.Appearance.Options.UseFont = True
        Me.lbl_version.Appearance.Options.UseTextOptions = True
        Me.lbl_version.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_version.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.lbl_version.LineVisible = True
        Me.lbl_version.Location = New System.Drawing.Point(397, 299)
        Me.lbl_version.Name = "lbl_version"
        Me.lbl_version.Size = New System.Drawing.Size(45, 14)
        Me.lbl_version.TabIndex = 15
        Me.lbl_version.Text = "_version"
        '
        'PictureEdit1
        '
        Me.PictureEdit1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureEdit1.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureEdit1.EditValue = CType(resources.GetObject("PictureEdit1.EditValue"), Object)
        Me.PictureEdit1.Location = New System.Drawing.Point(29, 60)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.AllowFocused = False
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Properties.ShowMenu = False
        Me.PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
        Me.PictureEdit1.Size = New System.Drawing.Size(380, 155)
        Me.PictureEdit1.TabIndex = 14
        '
        'lbl_status
        '
        Me.lbl_status.Location = New System.Drawing.Point(16, 236)
        Me.lbl_status.Margin = New System.Windows.Forms.Padding(3, 3, 3, 1)
        Me.lbl_status.Name = "lbl_status"
        Me.lbl_status.Size = New System.Drawing.Size(36, 13)
        Me.lbl_status.TabIndex = 12
        Me.lbl_status.Text = "_status"
        '
        'labelCopyright
        '
        Me.labelCopyright.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.labelCopyright.LineVisible = True
        Me.labelCopyright.Location = New System.Drawing.Point(16, 266)
        Me.labelCopyright.Name = "labelCopyright"
        Me.labelCopyright.Size = New System.Drawing.Size(309, 26)
        Me.labelCopyright.TabIndex = 11
        Me.labelCopyright.Text = "Copyright © 2020 - Winlandene Electronics and Electrical Center" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "All Rights reser" &
    "ved."
        '
        'frm_splash_screen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 320)
        Me.Controls.Add(Me.panel_top)
        Me.Name = "frm_splash_screen"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.Text = "frm_splash_screen"
        Me.panel_top.ResumeLayout(False)
        Me.panel_top.PerformLayout()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panel_top As Guna.UI.WinForms.GunaGradientPanel
    Private WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents lbl_status As DevExpress.XtraEditors.LabelControl
	Private WithEvents labelCopyright As DevExpress.XtraEditors.LabelControl
	Private WithEvents lbl_version As LabelControl
End Class
