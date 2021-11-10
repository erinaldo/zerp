<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_accounting_forecast_payables
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
        Dim XyDiagram2 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim Series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SideBySideBarSeriesView2 As DevExpress.XtraCharts.SideBySideBarSeriesView = New DevExpress.XtraCharts.SideBySideBarSeriesView()
        Dim XyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SideBySideBarSeriesView1 As DevExpress.XtraCharts.SideBySideBarSeriesView = New DevExpress.XtraCharts.SideBySideBarSeriesView()
        Me.panel_top = New Guna.UI.WinForms.GunaLinePanel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.chart_forecasted_payables = New DevExpress.XtraCharts.ChartControl()
        Me.chart_actual_payables = New DevExpress.XtraCharts.ChartControl()
        Me.grid_actual_payables = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_mondays = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_total = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_src = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TablePanel1 = New DevExpress.Utils.Layout.TablePanel()
        Me.grid_forecasted_payables = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_view = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.dt_start = New DevExpress.XtraEditors.DateEdit()
        Me.dt_end = New DevExpress.XtraEditors.DateEdit()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbl_actual_total = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lbl_future_total = New System.Windows.Forms.Label()
        Me.panel_top.SuspendLayout()
        CType(Me.chart_forecasted_payables, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chart_actual_payables, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_actual_payables, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TablePanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TablePanel1.SuspendLayout()
        CType(Me.grid_forecasted_payables, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.dt_start.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_start.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_end.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_end.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
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
        Me.panel_top.TabIndex = 9
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.GunaLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.GunaLabel1.Location = New System.Drawing.Point(24, 24)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(405, 31)
        Me.GunaLabel1.TabIndex = 1
        Me.GunaLabel1.Text = "Forecasted and Actual Payables"
        '
        'chart_forecasted_payables
        '
        Me.chart_forecasted_payables.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.chart_forecasted_payables.AppearanceNameSerializable = "Light"
        Me.chart_forecasted_payables.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
        Me.TablePanel1.SetColumn(Me.chart_forecasted_payables, 0)
        XyDiagram2.AxisX.Interlaced = True
        XyDiagram2.AxisX.Title.Text = "Forecast Payables"
        XyDiagram2.AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.[True]
        XyDiagram2.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram2.AxisY.VisibleInPanesSerializable = "-1"
        Me.chart_forecasted_payables.Diagram = XyDiagram2
        Me.chart_forecasted_payables.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center
        Me.chart_forecasted_payables.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.TopOutside
        Me.chart_forecasted_payables.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight
        Me.chart_forecasted_payables.Legend.MarkerSize = New System.Drawing.Size(20, 11)
        Me.chart_forecasted_payables.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[False]
        Me.chart_forecasted_payables.Location = New System.Drawing.Point(3, 314)
        Me.chart_forecasted_payables.Name = "chart_forecasted_payables"
        Me.chart_forecasted_payables.PaletteBaseColorNumber = 5
        Me.chart_forecasted_payables.PaletteName = "Blue Warm"
        Me.TablePanel1.SetRow(Me.chart_forecasted_payables, 1)
        Series2.Name = "Forecasted Payables"
        SideBySideBarSeriesView2.BarWidth = 0.8R
        Series2.View = SideBySideBarSeriesView2
        Me.chart_forecasted_payables.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series2}
        Me.chart_forecasted_payables.Size = New System.Drawing.Size(843, 293)
        Me.chart_forecasted_payables.TabIndex = 8
        '
        'chart_actual_payables
        '
        Me.chart_actual_payables.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.chart_actual_payables.AppearanceNameSerializable = "Light"
        Me.chart_actual_payables.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
        Me.TablePanel1.SetColumn(Me.chart_actual_payables, 0)
        XyDiagram1.AxisX.Interlaced = True
        XyDiagram1.AxisX.MinorCount = 10
        XyDiagram1.AxisX.Tickmarks.MinorVisible = False
        XyDiagram1.AxisX.Title.Text = "Actual Payables"
        XyDiagram1.AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.[True]
        XyDiagram1.AxisX.Visibility = DevExpress.Utils.DefaultBoolean.[True]
        XyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram1.AxisY.MinorCount = 3
        XyDiagram1.AxisY.Title.Text = "TOTAL"
        XyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
        XyDiagram1.DefaultPane.EnableAxisXScrolling = DevExpress.Utils.DefaultBoolean.[True]
        Me.chart_actual_payables.Diagram = XyDiagram1
        Me.chart_actual_payables.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center
        Me.chart_actual_payables.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.TopOutside
        Me.chart_actual_payables.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight
        Me.chart_actual_payables.Legend.MarkerSize = New System.Drawing.Size(20, 11)
        Me.chart_actual_payables.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[False]
        Me.chart_actual_payables.Location = New System.Drawing.Point(3, 3)
        Me.chart_actual_payables.Name = "chart_actual_payables"
        Me.chart_actual_payables.PaletteBaseColorNumber = 5
        Me.chart_actual_payables.PaletteName = "Module"
        Me.TablePanel1.SetRow(Me.chart_actual_payables, 0)
        Series1.Name = "Actual Payables"
        Series1.SeriesPointsSorting = DevExpress.XtraCharts.SortingMode.Ascending
        SideBySideBarSeriesView1.BarWidth = 0.8R
        Series1.View = SideBySideBarSeriesView1
        Me.chart_actual_payables.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1}
        Me.chart_actual_payables.Size = New System.Drawing.Size(843, 297)
        Me.chart_actual_payables.TabIndex = 9
        '
        'grid_actual_payables
        '
        Me.grid_actual_payables.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid_actual_payables.Location = New System.Drawing.Point(0, 0)
        Me.grid_actual_payables.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grid_actual_payables.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grid_actual_payables.MainView = Me.GridView1
        Me.grid_actual_payables.Name = "grid_actual_payables"
        Me.grid_actual_payables.Size = New System.Drawing.Size(196, 263)
        Me.grid_actual_payables.TabIndex = 13
        Me.grid_actual_payables.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.GridView1.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView1.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridView1.Appearance.Row.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.GridView1.Appearance.Row.Options.UseFont = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_mondays, Me.col_total, Me.col_src})
        Me.GridView1.GridControl = Me.grid_actual_payables
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'col_mondays
        '
        Me.col_mondays.AppearanceCell.Options.UseTextOptions = True
        Me.col_mondays.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_mondays.Caption = "Mondays"
        Me.col_mondays.DisplayFormat.FormatString = "MM/dd/yy"
        Me.col_mondays.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col_mondays.FieldName = "mondays"
        Me.col_mondays.MaxWidth = 120
        Me.col_mondays.Name = "col_mondays"
        Me.col_mondays.Visible = True
        Me.col_mondays.VisibleIndex = 0
        Me.col_mondays.Width = 120
        '
        'col_total
        '
        Me.col_total.AppearanceCell.Options.UseTextOptions = True
        Me.col_total.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_total.Caption = "Total"
        Me.col_total.DisplayFormat.FormatString = "c2"
        Me.col_total.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_total.FieldName = "total"
        Me.col_total.MaxWidth = 120
        Me.col_total.Name = "col_total"
        Me.col_total.Visible = True
        Me.col_total.VisibleIndex = 1
        Me.col_total.Width = 120
        '
        'col_src
        '
        Me.col_src.Caption = "Source"
        Me.col_src.FieldName = "src"
        Me.col_src.Name = "col_src"
        '
        'TablePanel1
        '
        Me.TablePanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TablePanel1.Columns.AddRange(New DevExpress.Utils.Layout.TablePanelColumn() {New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 84.85!), New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 20.15!)})
        Me.TablePanel1.Controls.Add(Me.Panel3)
        Me.TablePanel1.Controls.Add(Me.Panel2)
        Me.TablePanel1.Controls.Add(Me.chart_forecasted_payables)
        Me.TablePanel1.Controls.Add(Me.chart_actual_payables)
        Me.TablePanel1.Location = New System.Drawing.Point(30, 147)
        Me.TablePanel1.Name = "TablePanel1"
        Me.TablePanel1.Rows.AddRange(New DevExpress.Utils.Layout.TablePanelRow() {New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 303.0!), New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26.0!)})
        Me.TablePanel1.Size = New System.Drawing.Size(1050, 618)
        Me.TablePanel1.TabIndex = 14
        '
        'grid_forecasted_payables
        '
        Me.grid_forecasted_payables.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid_forecasted_payables.Location = New System.Drawing.Point(0, 0)
        Me.grid_forecasted_payables.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grid_forecasted_payables.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grid_forecasted_payables.MainView = Me.GridView2
        Me.grid_forecasted_payables.Name = "grid_forecasted_payables"
        Me.grid_forecasted_payables.Size = New System.Drawing.Size(196, 275)
        Me.grid_forecasted_payables.TabIndex = 14
        Me.grid_forecasted_payables.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Appearance.HeaderPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.GridView2.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView2.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GridView2.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridView2.Appearance.Row.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.GridView2.Appearance.Row.Options.UseFont = True
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3})
        Me.GridView2.GridControl = Me.grid_forecasted_payables
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.Caption = "Mondays"
        Me.GridColumn1.DisplayFormat.FormatString = "MM/dd/yy"
        Me.GridColumn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn1.FieldName = "mondays"
        Me.GridColumn1.MaxWidth = 120
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 120
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn2.Caption = "Total"
        Me.GridColumn2.DisplayFormat.FormatString = "c2"
        Me.GridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn2.FieldName = "total"
        Me.GridColumn2.MaxWidth = 120
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 120
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Source"
        Me.GridColumn3.FieldName = "src"
        Me.GridColumn3.Name = "GridColumn3"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btn_view)
        Me.Panel1.Controls.Add(Me.LabelControl1)
        Me.Panel1.Controls.Add(Me.LabelControl2)
        Me.Panel1.Controls.Add(Me.dt_start)
        Me.Panel1.Controls.Add(Me.dt_end)
        Me.Panel1.Location = New System.Drawing.Point(30, 104)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(556, 37)
        Me.Panel1.TabIndex = 15
        '
        'btn_view
        '
        Me.btn_view.Appearance.BackColor = System.Drawing.Color.Blue
        Me.btn_view.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btn_view.Appearance.Options.UseBackColor = True
        Me.btn_view.Appearance.Options.UseFont = True
        Me.btn_view.Location = New System.Drawing.Point(436, 3)
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
        'Panel2
        '
        Me.TablePanel1.SetColumn(Me.Panel2, 1)
        Me.Panel2.Controls.Add(Me.grid_actual_payables)
        Me.Panel2.Controls.Add(Me.lbl_actual_total)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(852, 3)
        Me.Panel2.Name = "Panel2"
        Me.TablePanel1.SetRow(Me.Panel2, 0)
        Me.Panel2.Size = New System.Drawing.Size(196, 297)
        Me.Panel2.TabIndex = 15
        '
        'lbl_actual_total
        '
        Me.lbl_actual_total.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lbl_actual_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lbl_actual_total.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lbl_actual_total.Location = New System.Drawing.Point(0, 263)
        Me.lbl_actual_total.Name = "lbl_actual_total"
        Me.lbl_actual_total.Size = New System.Drawing.Size(196, 34)
        Me.lbl_actual_total.TabIndex = 14
        Me.lbl_actual_total.Text = "Total: 6,255.231.15"
        Me.lbl_actual_total.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel3
        '
        Me.TablePanel1.SetColumn(Me.Panel3, 1)
        Me.Panel3.Controls.Add(Me.grid_forecasted_payables)
        Me.Panel3.Controls.Add(Me.lbl_future_total)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(852, 306)
        Me.Panel3.Name = "Panel3"
        Me.TablePanel1.SetRow(Me.Panel3, 1)
        Me.Panel3.Size = New System.Drawing.Size(196, 309)
        Me.Panel3.TabIndex = 16
        '
        'lbl_future_total
        '
        Me.lbl_future_total.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lbl_future_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lbl_future_total.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lbl_future_total.Location = New System.Drawing.Point(0, 275)
        Me.lbl_future_total.Name = "lbl_future_total"
        Me.lbl_future_total.Size = New System.Drawing.Size(196, 34)
        Me.lbl_future_total.TabIndex = 15
        Me.lbl_future_total.Text = "Total: 6,255.231.15"
        Me.lbl_future_total.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frm_accounting_forecast_payables
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1109, 795)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TablePanel1)
        Me.Controls.Add(Me.panel_top)
        Me.Name = "frm_accounting_forecast_payables"
        Me.Text = "frm_accounting_forecast_payables"
        Me.panel_top.ResumeLayout(False)
        Me.panel_top.PerformLayout()
        CType(XyDiagram2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chart_forecasted_payables, System.ComponentModel.ISupportInitialize).EndInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chart_actual_payables, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_actual_payables, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TablePanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TablePanel1.ResumeLayout(False)
        CType(Me.grid_forecasted_payables, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dt_start.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_start.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_end.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_end.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panel_top As Guna.UI.WinForms.GunaLinePanel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents chart_forecasted_payables As DevExpress.XtraCharts.ChartControl
    Friend WithEvents chart_actual_payables As DevExpress.XtraCharts.ChartControl
    Friend WithEvents grid_actual_payables As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_mondays As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_total As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TablePanel1 As DevExpress.Utils.Layout.TablePanel
    Friend WithEvents col_src As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_view As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dt_start As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dt_end As DevExpress.XtraEditors.DateEdit
    Friend WithEvents grid_forecasted_payables As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lbl_future_total As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lbl_actual_total As Label
End Class
