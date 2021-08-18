Imports DevExpress.Utils
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.Parameters
Imports DevExpress.XtraReports.UI
Imports System.ComponentModel


<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class doc_delivery_list
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
		Me.TopMargin = New TopMarginBand()
		Me.BottomMargin = New BottomMarginBand()
		Me.Detail = New DetailBand()
		Me.XrTable2 = New XRTable()
		Me.XrTableRow2 = New XRTableRow()
		Me.XrTableCell6 = New XRTableCell()
		Me.XrTableCell5 = New XRTableCell()
		Me.XrTableCell7 = New XRTableCell()
		Me.XrTableCell8 = New XRTableCell()
		Me.XrTableCell10 = New XRTableCell()
		Me.ReportHeader = New ReportHeaderBand()
		Me.XrLabel1 = New XRLabel()
		Me.XrLabel14 = New XRLabel()
		Me.XrLabel13 = New XRLabel()
		Me.XrLabel12 = New XRLabel()
		Me.XrLabel9 = New XRLabel()
		Me.XrLabel6 = New XRLabel()
		Me.XrLabel5 = New XRLabel()
		Me.XrLabel4 = New XRLabel()
		Me.XrLabel3 = New XRLabel()
		Me.PageHeader = New PageHeaderBand()
		Me.XrTable1 = New XRTable()
		Me.XrTableRow1 = New XRTableRow()
		Me.XrTableCell1 = New XRTableCell()
		Me.XrTableCell3 = New XRTableCell()
		Me.XrTableCell2 = New XRTableCell()
		Me.XrTableCell4 = New XRTableCell()
		Me.XrTableCell9 = New XRTableCell()
		Me.ReportFooter = New ReportFooterBand()
		Me.XrLabel8 = New XRLabel()
		Me.XrLine1 = New XRLine()
		Me.XrLabel7 = New XRLabel()
		Me.XrLabel2 = New XRLabel()
		Me.sub_total = New CalculatedField()
		Me.supplier = New Parameter()
		Me.deliver_to = New Parameter()
		Me.pid = New Parameter()
		Me.PrintData1 = New PrintData()
		DirectCast(Me.XrTable2, ISupportInitialize).BeginInit()
		DirectCast(Me.XrTable1, ISupportInitialize).BeginInit()
		DirectCast(Me.PrintData1, ISupportInitialize).BeginInit()
		DirectCast(Me, ISupportInitialize).BeginInit()
		Me.TopMargin.HeightF = 50.0!
		Me.TopMargin.Name = "TopMargin"
		Me.BottomMargin.HeightF = 50.0!
		Me.BottomMargin.Name = "BottomMargin"
		Me.Detail.Controls.AddRange(New XRControl() {Me.XrTable2})
		Me.Detail.HeightF = 23.99998!
		Me.Detail.Name = "Detail"
		Me.XrTable2.Borders = BorderSide.Left Or BorderSide.Right Or BorderSide.Bottom
		Me.XrTable2.LocationFloat = New PointFloat(0!, 0!)
		Me.XrTable2.Name = "XrTable2"
		Me.XrTable2.Padding = New PaddingInfo(2, 2, 0, 0, 96.0!)
		Me.XrTable2.Rows.AddRange(New XRTableRow() {Me.XrTableRow2})
		Me.XrTable2.SizeF = New System.Drawing.SizeF(750.0!, 23.99998!)
		Me.XrTable2.StylePriority.UseBorders = False
		Me.XrTableRow2.Cells.AddRange(New XRTableCell() {Me.XrTableCell6, Me.XrTableCell5, Me.XrTableCell7, Me.XrTableCell8, Me.XrTableCell10})
		Me.XrTableRow2.Name = "XrTableRow2"
		Me.XrTableRow2.Weight = 1
		Me.XrTableCell6.Borders = BorderSide.None
		Me.XrTableCell6.ExpressionBindings.AddRange(New ExpressionBinding() {New ExpressionBinding("BeforePrint", "Text", "[qty]")})
		Me.XrTableCell6.Font = New System.Drawing.Font("Arial", 9.75!)
		Me.XrTableCell6.Multiline = True
		Me.XrTableCell6.Name = "XrTableCell6"
		Me.XrTableCell6.StylePriority.UseBorders = False
		Me.XrTableCell6.StylePriority.UseFont = False
		Me.XrTableCell6.StylePriority.UseTextAlignment = False
		Me.XrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
		Me.XrTableCell6.Weight = 0.467514884013185
		Me.XrTableCell5.Borders = BorderSide.None
		Me.XrTableCell5.ExpressionBindings.AddRange(New ExpressionBinding() {New ExpressionBinding("BeforePrint", "Text", "[supmodel]")})
		Me.XrTableCell5.Font = New System.Drawing.Font("Arial", 9.75!)
		Me.XrTableCell5.Multiline = True
		Me.XrTableCell5.Name = "XrTableCell5"
		Me.XrTableCell5.StylePriority.UseBorders = False
		Me.XrTableCell5.StylePriority.UseFont = False
		Me.XrTableCell5.StylePriority.UseTextAlignment = False
		Me.XrTableCell5.Text = "XrTableCell5"
		Me.XrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
		Me.XrTableCell5.Weight = 0.716492041191601
		Me.XrTableCell7.Borders = BorderSide.None
		Me.XrTableCell7.ExpressionBindings.AddRange(New ExpressionBinding() {New ExpressionBinding("BeforePrint", "Text", "[winmodel]")})
		Me.XrTableCell7.Font = New System.Drawing.Font("Arial", 9.75!)
		Me.XrTableCell7.Multiline = True
		Me.XrTableCell7.Name = "XrTableCell7"
		Me.XrTableCell7.StylePriority.UseBorders = False
		Me.XrTableCell7.StylePriority.UseFont = False
		Me.XrTableCell7.StylePriority.UseTextAlignment = False
		Me.XrTableCell7.Text = "[model]"
		Me.XrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
		Me.XrTableCell7.Weight = 0.907253435579921
		Me.XrTableCell8.Borders = BorderSide.None
		Me.XrTableCell8.Font = New System.Drawing.Font("Arial", 9.75!)
		Me.XrTableCell8.Multiline = True
		Me.XrTableCell8.Name = "XrTableCell8"
		Me.XrTableCell8.StylePriority.UseBorders = False
		Me.XrTableCell8.StylePriority.UseFont = False
		Me.XrTableCell8.StylePriority.UseTextAlignment = False
		Me.XrTableCell8.Text = "[description]"
		Me.XrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
		Me.XrTableCell8.Weight = 2.48345060292267
		Me.XrTableCell10.Borders = BorderSide.None
		Me.XrTableCell10.ExpressionBindings.AddRange(New ExpressionBinding() {New ExpressionBinding("BeforePrint", "Text", "[location]")})
		Me.XrTableCell10.Font = New System.Drawing.Font("Arial", 9.75!)
		Me.XrTableCell10.Multiline = True
		Me.XrTableCell10.Name = "XrTableCell10"
		Me.XrTableCell10.StylePriority.UseBorders = False
		Me.XrTableCell10.StylePriority.UseFont = False
		Me.XrTableCell10.StylePriority.UseTextAlignment = False
		Me.XrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
		Me.XrTableCell10.Weight = 0.919208578835135
		Me.ReportHeader.Controls.AddRange(New XRControl() {Me.XrLabel1, Me.XrLabel14, Me.XrLabel13, Me.XrLabel12, Me.XrLabel9, Me.XrLabel6, Me.XrLabel5, Me.XrLabel4, Me.XrLabel3})
		Me.ReportHeader.HeightF = 144.3333!
		Me.ReportHeader.Name = "ReportHeader"
		Me.XrLabel1.ExpressionBindings.AddRange(New ExpressionBinding() {New ExpressionBinding("BeforePrint", "Text", "Today()")})
		Me.XrLabel1.LocationFloat = New PointFloat(604.1666!, 82.20844!)
		Me.XrLabel1.Multiline = True
		Me.XrLabel1.Name = "XrLabel1"
		Me.XrLabel1.Padding = New PaddingInfo(2, 2, 0, 0, 100.0!)
		Me.XrLabel1.SizeF = New System.Drawing.SizeF(145.8334!, 17.79165!)
		Me.XrLabel1.StylePriority.UseTextAlignment = False
		Me.XrLabel1.Text = "XrLabel14"
		Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
		Me.XrLabel1.TextFormatString = "{0:MM/dd/yyyy}"
		Me.XrLabel14.ExpressionBindings.AddRange(New ExpressionBinding() {New ExpressionBinding("BeforePrint", "Text", "?pid")})
		Me.XrLabel14.LocationFloat = New PointFloat(604.1666!, 64.41669!)
		Me.XrLabel14.Multiline = True
		Me.XrLabel14.Name = "XrLabel14"
		Me.XrLabel14.Padding = New PaddingInfo(2, 2, 0, 0, 100.0!)
		Me.XrLabel14.SizeF = New System.Drawing.SizeF(145.8334!, 17.79165!)
		Me.XrLabel14.StylePriority.UseTextAlignment = False
		Me.XrLabel14.Text = "XrLabel14"
		Me.XrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
		Me.XrLabel13.ExpressionBindings.AddRange(New ExpressionBinding() {New ExpressionBinding("BeforePrint", "Text", "?deliver_to")})
		Me.XrLabel13.LocationFloat = New PointFloat(93.75009!, 82.20838!)
		Me.XrLabel13.Multiline = True
		Me.XrLabel13.Name = "XrLabel13"
		Me.XrLabel13.Padding = New PaddingInfo(2, 2, 0, 0, 100.0!)
		Me.XrLabel13.SizeF = New System.Drawing.SizeF(350.0!, 17.79169!)
		Me.XrLabel13.Text = "XrLabel13"
		Me.XrLabel12.ExpressionBindings.AddRange(New ExpressionBinding() {New ExpressionBinding("BeforePrint", "Text", "?supplier")})
		Me.XrLabel12.LocationFloat = New PointFloat(93.75009!, 64.41669!)
		Me.XrLabel12.Multiline = True
		Me.XrLabel12.Name = "XrLabel12"
		Me.XrLabel12.Padding = New PaddingInfo(2, 2, 0, 0, 100.0!)
		Me.XrLabel12.SizeF = New System.Drawing.SizeF(350.0!, 17.79166!)
		Me.XrLabel12.Text = "XrLabel12"
		Me.XrLabel9.Font = New System.Drawing.Font("Arial", 9.75!, FontStyle.Bold)
		Me.XrLabel9.LocationFloat = New PointFloat(0.00003178914!, 82.20838!)
		Me.XrLabel9.Multiline = True
		Me.XrLabel9.Name = "XrLabel9"
		Me.XrLabel9.Padding = New PaddingInfo(2, 2, 0, 0, 100.0!)
		Me.XrLabel9.SizeF = New System.Drawing.SizeF(82.70828!, 17.79164!)
		Me.XrLabel9.StylePriority.UseFont = False
		Me.XrLabel9.Text = "Deliver To:"
		Me.XrLabel6.Font = New System.Drawing.Font("Arial", 9.75!, FontStyle.Bold)
		Me.XrLabel6.LocationFloat = New PointFloat(0!, 64.41669!)
		Me.XrLabel6.Multiline = True
		Me.XrLabel6.Name = "XrLabel6"
		Me.XrLabel6.Padding = New PaddingInfo(2, 2, 0, 0, 100.0!)
		Me.XrLabel6.SizeF = New System.Drawing.SizeF(68.74997!, 17.79166!)
		Me.XrLabel6.StylePriority.UseFont = False
		Me.XrLabel6.Text = "Supplier:"
		Me.XrLabel5.Font = New System.Drawing.Font("Arial", 9.75!, FontStyle.Bold)
		Me.XrLabel5.LocationFloat = New PointFloat(504.1667!, 82.20841!)
		Me.XrLabel5.Multiline = True
		Me.XrLabel5.Name = "XrLabel5"
		Me.XrLabel5.Padding = New PaddingInfo(2, 2, 0, 0, 100.0!)
		Me.XrLabel5.SizeF = New System.Drawing.SizeF(99.99997!, 17.79165!)
		Me.XrLabel5.StylePriority.UseFont = False
		Me.XrLabel5.Text = "Date Printed:"
		Me.XrLabel4.Font = New System.Drawing.Font("Arial", 9.75!, FontStyle.Bold)
		Me.XrLabel4.LocationFloat = New PointFloat(504.1667!, 64.41669!)
		Me.XrLabel4.Multiline = True
		Me.XrLabel4.Name = "XrLabel4"
		Me.XrLabel4.Padding = New PaddingInfo(2, 2, 0, 0, 100.0!)
		Me.XrLabel4.SizeF = New System.Drawing.SizeF(99.99997!, 17.79165!)
		Me.XrLabel4.StylePriority.UseFont = False
		Me.XrLabel4.Text = "Purchase ID:"
		Me.XrLabel3.Font = New System.Drawing.Font("Arial", 22.0!, FontStyle.Bold)
		Me.XrLabel3.LocationFloat = New PointFloat(0!, 0!)
		Me.XrLabel3.Multiline = True
		Me.XrLabel3.Name = "XrLabel3"
		Me.XrLabel3.Padding = New PaddingInfo(2, 2, 0, 0, 100.0!)
		Me.XrLabel3.SizeF = New System.Drawing.SizeF(297.9167!, 54.25002!)
		Me.XrLabel3.StylePriority.UseFont = False
		Me.XrLabel3.StylePriority.UseTextAlignment = False
		Me.XrLabel3.Text = "DELIVERY LIST"
		Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
		Me.PageHeader.Controls.AddRange(New XRControl() {Me.XrTable1})
		Me.PageHeader.HeightF = 37.75002!
		Me.PageHeader.Name = "PageHeader"
		Me.XrTable1.Borders = BorderSide.All
		Me.XrTable1.LocationFloat = New PointFloat(0!, 0!)
		Me.XrTable1.Name = "XrTable1"
		Me.XrTable1.Padding = New PaddingInfo(2, 2, 0, 0, 96.0!)
		Me.XrTable1.Rows.AddRange(New XRTableRow() {Me.XrTableRow1})
		Me.XrTable1.SizeF = New System.Drawing.SizeF(750.0!, 29.99998!)
		Me.XrTable1.StylePriority.UseBorders = False
		Me.XrTableRow1.Cells.AddRange(New XRTableCell() {Me.XrTableCell1, Me.XrTableCell3, Me.XrTableCell2, Me.XrTableCell4, Me.XrTableCell9})
		Me.XrTableRow1.Name = "XrTableRow1"
		Me.XrTableRow1.Weight = 1
		Me.XrTableCell1.Font = New System.Drawing.Font("Arial", 9.75!, FontStyle.Bold)
		Me.XrTableCell1.Multiline = True
		Me.XrTableCell1.Name = "XrTableCell1"
		Me.XrTableCell1.StylePriority.UseFont = False
		Me.XrTableCell1.StylePriority.UseTextAlignment = False
		Me.XrTableCell1.Text = "QTY"
		Me.XrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
		Me.XrTableCell1.Weight = 0.419999956933858
		Me.XrTableCell3.Font = New System.Drawing.Font("Arial", 9.75!, FontStyle.Bold)
		Me.XrTableCell3.Multiline = True
		Me.XrTableCell3.Name = "XrTableCell3"
		Me.XrTableCell3.StylePriority.UseFont = False
		Me.XrTableCell3.StylePriority.UseTextAlignment = False
		Me.XrTableCell3.Text = "SUP. Model"
		Me.XrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
		Me.XrTableCell3.Weight = 0.64367291676839
		Me.XrTableCell2.Font = New System.Drawing.Font("Arial", 9.75!, FontStyle.Bold)
		Me.XrTableCell2.Multiline = True
		Me.XrTableCell2.Name = "XrTableCell2"
		Me.XrTableCell2.StylePriority.UseFont = False
		Me.XrTableCell2.StylePriority.UseTextAlignment = False
		Me.XrTableCell2.Text = "WIN. Model"
		Me.XrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
		Me.XrTableCell2.Weight = 0.815046311878709
		Me.XrTableCell4.Font = New System.Drawing.Font("Arial", 9.75!, FontStyle.Bold)
		Me.XrTableCell4.Multiline = True
		Me.XrTableCell4.Name = "XrTableCell4"
		Me.XrTableCell4.StylePriority.UseFont = False
		Me.XrTableCell4.StylePriority.UseTextAlignment = False
		Me.XrTableCell4.Text = "DESCRIPTION"
		Me.XrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
		Me.XrTableCell4.Weight = 2.23104962254836
		Me.XrTableCell9.Font = New System.Drawing.Font("Arial", 9.75!, FontStyle.Bold)
		Me.XrTableCell9.Multiline = True
		Me.XrTableCell9.Name = "XrTableCell9"
		Me.XrTableCell9.StylePriority.UseFont = False
		Me.XrTableCell9.StylePriority.UseTextAlignment = False
		Me.XrTableCell9.Text = "Filling Location"
		Me.XrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
		Me.XrTableCell9.Weight = 0.825786898999327
		Me.ReportFooter.Controls.AddRange(New XRControl() {Me.XrLabel8, Me.XrLine1, Me.XrLabel7, Me.XrLabel2})
		Me.ReportFooter.HeightF = 192.3752!
		Me.ReportFooter.Name = "ReportFooter"
		Me.ReportFooter.PrintAtBottom = True
		Me.XrLabel8.Font = New System.Drawing.Font("Arial", 9.75!, FontStyle.Bold)
		Me.XrLabel8.LocationFloat = New PointFloat(0!, 23.79169!)
		Me.XrLabel8.Multiline = True
		Me.XrLabel8.Name = "XrLabel8"
		Me.XrLabel8.Padding = New PaddingInfo(2, 2, 0, 0, 100.0!)
		Me.XrLabel8.SizeF = New System.Drawing.SizeF(68.74997!, 17.79166!)
		Me.XrLabel8.StylePriority.UseFont = False
		Me.XrLabel8.Text = "Notes:"
		Me.XrLine1.BorderWidth = 0!
		Me.XrLine1.LineWidth = 5.0!
		Me.XrLine1.LocationFloat = New PointFloat(0!, 0!)
		Me.XrLine1.Name = "XrLine1"
		Me.XrLine1.SizeF = New System.Drawing.SizeF(750.0!, 10.0!)
		Me.XrLine1.StylePriority.UseBorderWidth = False
		Me.XrLabel7.Borders = BorderSide.Left Or BorderSide.Right Or BorderSide.Bottom
		Me.XrLabel7.Font = New System.Drawing.Font("Arial", 9.75!, FontStyle.Bold, GraphicsUnit.Point, 0)
		Me.XrLabel7.LocationFloat = New PointFloat(550.6945!, 91.91679!)
		Me.XrLabel7.Multiline = True
		Me.XrLabel7.Name = "XrLabel7"
		Me.XrLabel7.Padding = New PaddingInfo(2, 2, 0, 0, 100.0!)
		Me.XrLabel7.SizeF = New System.Drawing.SizeF(199.3055!, 52.16668!)
		Me.XrLabel7.StylePriority.UseBorders = False
		Me.XrLabel7.StylePriority.UseFont = False
		Me.XrLabel7.StylePriority.UseTextAlignment = False
		Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
		Me.XrLabel2.Borders = BorderSide.All
		Me.XrLabel2.BorderWidth = 1.0!
		Me.XrLabel2.Font = New System.Drawing.Font("Arial", 9.75!, FontStyle.Bold, GraphicsUnit.Point, 0)
		Me.XrLabel2.LocationFloat = New PointFloat(550.6945!, 69.00011!)
		Me.XrLabel2.Multiline = True
		Me.XrLabel2.Name = "XrLabel2"
		Me.XrLabel2.Padding = New PaddingInfo(2, 2, 0, 0, 100.0!)
		Me.XrLabel2.SizeF = New System.Drawing.SizeF(199.3055!, 22.91667!)
		Me.XrLabel2.StylePriority.UseBorders = False
		Me.XrLabel2.StylePriority.UseBorderWidth = False
		Me.XrLabel2.StylePriority.UseFont = False
		Me.XrLabel2.StylePriority.UsePadding = False
		Me.XrLabel2.StylePriority.UseTextAlignment = False
		Me.XrLabel2.Text = "Counted By"
		Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
		Me.sub_total.DataMember = "purchase_order_slip"
		Me.sub_total.Expression = "Sum([total_cost])"
		Me.sub_total.FieldType = FieldType.[Decimal]
		Me.sub_total.Name = "sub_total"
		Me.supplier.Description = "supplier"
		Me.supplier.Name = "supplier"
		Me.supplier.Visible = False
		Me.deliver_to.Description = "deliver_to"
		Me.deliver_to.Name = "deliver_to"
		Me.deliver_to.Visible = False
		Me.pid.Description = "pid"
		Me.pid.Name = "pid"
		Me.pid.Visible = False
		Me.PrintData1.DataSetName = "PrintData"
		Me.PrintData1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema
		Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.TopMargin, Me.BottomMargin, Me.Detail, Me.ReportHeader, Me.PageHeader, Me.ReportFooter})
		Me.CalculatedFields.AddRange(New CalculatedField() {Me.sub_total})
		Me.ComponentStorage.AddRange(New IComponent() {Me.PrintData1})
		Me.DataMember = "delivery_list"
		Me.DataSource = Me.PrintData1
		Me.Font = New System.Drawing.Font("Arial", 9.75!)
		Me.Margins = New System.Drawing.Printing.Margins(50, 50, 50, 50)
		Me.Parameters.AddRange(New Parameter() {Me.supplier, Me.deliver_to, Me.pid})
		Me.RequestParameters = False
		Me.Version = "21.1"
		DirectCast(Me.XrTable2, ISupportInitialize).EndInit()
		DirectCast(Me.XrTable1, ISupportInitialize).EndInit()
		DirectCast(Me.PrintData1, ISupportInitialize).EndInit()
		DirectCast(Me, ISupportInitialize).EndInit()

	End Sub

    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents sub_total As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents supplier As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents deliver_to As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents pid As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents PrintData1 As PrintData
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
	Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
	Friend WithEvents XrTableCell10 As XRTableCell
	Friend WithEvents XrTableCell9 As XRTableCell
End Class
