<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_accounting_inventory_count
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
        Dim SideBySideBarSeriesLabel1 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
        Me.panel_top = New Guna.UI.WinForms.GunaLinePanel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.grid_inventory = New DevExpress.XtraGrid.GridControl()
        Me.grid_inventory_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.chart_inventory = New DevExpress.XtraCharts.ChartControl()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_view = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.dt_start = New DevExpress.XtraEditors.DateEdit()
        Me.dt_end = New DevExpress.XtraEditors.DateEdit()
        Me.panel_top.SuspendLayout()
        CType(Me.grid_inventory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_inventory_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chart_inventory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.dt_start.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_start.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_end.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_end.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel_top
        '
        Me.panel_top.BackColor = System.Drawing.Color.GhostWhite
        Me.panel_top.Controls.Add(Me.GunaLabel1)
        Me.panel_top.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_top.LineColor = System.Drawing.SystemColors.ControlLight
        Me.panel_top.LineStyle = System.Windows.Forms.BorderStyle.None
        Me.panel_top.Location = New System.Drawing.Point(0, 0)
        Me.panel_top.Name = "panel_top"
        Me.panel_top.Size = New System.Drawing.Size(1109, 78)
        Me.panel_top.TabIndex = 10
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.GunaLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.GunaLabel1.Location = New System.Drawing.Point(24, 24)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(267, 31)
        Me.GunaLabel1.TabIndex = 1
        Me.GunaLabel1.Text = "Inventory Stock Cost"
        '
        'grid_inventory
        '
        Me.grid_inventory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_inventory.Location = New System.Drawing.Point(12, 452)
        Me.grid_inventory.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grid_inventory.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grid_inventory.MainView = Me.grid_inventory_view
        Me.grid_inventory.Name = "grid_inventory"
        Me.grid_inventory.Size = New System.Drawing.Size(1085, 331)
        Me.grid_inventory.TabIndex = 11
        Me.grid_inventory.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_inventory_view})
        '
        'grid_inventory_view
        '
        Me.grid_inventory_view.Appearance.HeaderPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.grid_inventory_view.Appearance.HeaderPanel.Options.UseFont = True
        Me.grid_inventory_view.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.grid_inventory_view.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grid_inventory_view.Appearance.Row.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.grid_inventory_view.Appearance.Row.Options.UseFont = True
        Me.grid_inventory_view.GridControl = Me.grid_inventory
        Me.grid_inventory_view.Name = "grid_inventory_view"
        '
        'chart_inventory
        '
        Me.chart_inventory.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chart_inventory.AppearanceNameSerializable = "Light"
        Me.chart_inventory.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
        Me.chart_inventory.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center
        Me.chart_inventory.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.TopOutside
        Me.chart_inventory.Location = New System.Drawing.Point(13, 134)
        Me.chart_inventory.Name = "chart_inventory"
        Me.chart_inventory.PaletteName = "Metro"
        Me.chart_inventory.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
        SideBySideBarSeriesLabel1.TextPattern = "{V:C2}"
        Me.chart_inventory.SeriesTemplate.Label = SideBySideBarSeriesLabel1
        Me.chart_inventory.SeriesTemplate.ToolTipEnabled = DevExpress.Utils.DefaultBoolean.[True]
        Me.chart_inventory.SeriesTemplate.ToolTipSeriesPattern = "{S:C2}"
        Me.chart_inventory.Size = New System.Drawing.Size(1085, 299)
        Me.chart_inventory.TabIndex = 12
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btn_view)
        Me.Panel1.Controls.Add(Me.LabelControl1)
        Me.Panel1.Controls.Add(Me.LabelControl2)
        Me.Panel1.Controls.Add(Me.dt_start)
        Me.Panel1.Controls.Add(Me.dt_end)
        Me.Panel1.Location = New System.Drawing.Point(12, 91)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(556, 37)
        Me.Panel1.TabIndex = 13
        '
        'btn_view
        '
        Me.btn_view.Appearance.BackColor = System.Drawing.Color.Blue
        Me.btn_view.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btn_view.Appearance.Options.UseBackColor = True
        Me.btn_view.Appearance.Options.UseFont = True
        Me.btn_view.Location = New System.Drawing.Point(435, 3)
        Me.btn_view.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_view.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_view.Name = "btn_view"
        Me.btn_view.Size = New System.Drawing.Size(101, 32)
        Me.btn_view.TabIndex = 7
        Me.btn_view.Text = "View"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(12, 10)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(74, 20)
        Me.LabelControl1.TabIndex = 3
        Me.LabelControl1.Text = "Start Date"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(226, 10)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(68, 20)
        Me.LabelControl2.TabIndex = 4
        Me.LabelControl2.Text = "End Date"
        '
        'dt_start
        '
        Me.dt_start.EditValue = New Date(2021, 8, 31, 0, 0, 0, 0)
        Me.dt_start.Location = New System.Drawing.Point(96, 7)
        Me.dt_start.Name = "dt_start"
        Me.dt_start.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt_start.Properties.Appearance.Options.UseFont = True
        Me.dt_start.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dt_start.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dt_start.Properties.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.dt_start.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dt_start.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.dt_start.Size = New System.Drawing.Size(109, 26)
        Me.dt_start.TabIndex = 1
        '
        'dt_end
        '
        Me.dt_end.EditValue = New Date(2021, 8, 31, 0, 0, 0, 0)
        Me.dt_end.Location = New System.Drawing.Point(305, 7)
        Me.dt_end.Name = "dt_end"
        Me.dt_end.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt_end.Properties.Appearance.Options.UseFont = True
        Me.dt_end.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dt_end.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dt_end.Properties.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.dt_end.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dt_end.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.dt_end.Size = New System.Drawing.Size(114, 26)
        Me.dt_end.TabIndex = 2
        '
        'frm_accounting_inventory_count
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1109, 795)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.chart_inventory)
        Me.Controls.Add(Me.grid_inventory)
        Me.Controls.Add(Me.panel_top)
        Me.Name = "frm_accounting_inventory_count"
        Me.Text = "_accounting_inventory_count"
        Me.panel_top.ResumeLayout(False)
        Me.panel_top.PerformLayout()
        CType(Me.grid_inventory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_inventory_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chart_inventory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dt_start.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_start.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_end.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_end.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panel_top As Guna.UI.WinForms.GunaLinePanel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents grid_inventory As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_inventory_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents chart_inventory As DevExpress.XtraCharts.ChartControl
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_view As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dt_start As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dt_end As DevExpress.XtraEditors.DateEdit
End Class
