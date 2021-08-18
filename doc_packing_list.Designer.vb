Imports DevExpress.Utils
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.Parameters
Imports DevExpress.XtraReports.UI
Imports System.ComponentModel

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class doc_packing_list
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(doc_packing_list))
		Me.TopMargin = New TopMarginBand()
		Me.BottomMargin = New BottomMarginBand()
		Me.Detail = New DetailBand()
		Me.XrTable2 = New XRTable()
		Me.XrTableRow2 = New XRTableRow()
		Me.XrTableCell6 = New XRTableCell()
		Me.XrTableCell7 = New XRTableCell()
		Me.XrTableCell8 = New XRTableCell()
		Me.XrTableCell5 = New XRTableCell()
		Me.ReportHeader = New ReportHeaderBand()
		Me.XrLabel18 = New XRLabel()
		Me.XrLabel16 = New XRLabel()
		Me.XrLabel15 = New XRLabel()
		Me.XrLabel14 = New XRLabel()
		Me.XrLabel11 = New XRLabel()
		Me.XrLabel10 = New XRLabel()
		Me.XrLabel9 = New XRLabel()
		Me.XrLabel6 = New XRLabel()
		Me.XrLabel2 = New XRLabel()
		Me.XrLabel1 = New XRLabel()
		Me.XrLabel8 = New XRLabel()
		Me.XrLabel7 = New XRLabel()
		Me.XrLabel5 = New XRLabel()
		Me.XrLabel4 = New XRLabel()
		Me.XrLabel3 = New XRLabel()
		Me.PageHeader = New PageHeaderBand()
		Me.XrTable1 = New XRTable()
		Me.XrTableRow1 = New XRTableRow()
		Me.XrTableCell1 = New XRTableCell()
		Me.XrTableCell2 = New XRTableCell()
		Me.XrTableCell4 = New XRTableCell()
		Me.XrTableCell3 = New XRTableCell()
		Me.ReportFooter = New ReportFooterBand()
		Me.XrLine2 = New XRLine()
		Me.XrLabel12 = New XRLabel()
		Me.XrLabel17 = New XRLabel()
		Me.XrRichText1 = New XRRichText()
		Me.sub_total = New CalculatedField()
		Me.order_id = New Parameter()
		Me.customer = New Parameter()
		Me.address = New Parameter()
		Me.ordered_date = New Parameter()
		Me.priv_notes = New Parameter()
		Me.agent = New Parameter()
		Me.PrintData1 = New PrintData()
		Me.XrCrossBandBox2 = New XRCrossBandBox()
		Me.trucking = New Parameter()
		Me.shipping_method = New Parameter()
		Me.XrCrossBandBox1 = New XRCrossBandBox()
		Me.XrLabel13 = New XRLabel()
		Me.XrCrossBandBox3 = New XRCrossBandBox()
		Me.XrLabel19 = New XRLabel()
		DirectCast(Me.XrTable2, ISupportInitialize).BeginInit()
		DirectCast(Me.XrTable1, ISupportInitialize).BeginInit()
		DirectCast(Me.XrRichText1, ISupportInitialize).BeginInit()
		DirectCast(Me.PrintData1, ISupportInitialize).BeginInit()
		DirectCast(Me, ISupportInitialize).BeginInit()
		Me.TopMargin.HeightF = 50.0!
		Me.TopMargin.Name = "TopMargin"
		Me.BottomMargin.HeightF = 50.0!
		Me.BottomMargin.Name = "BottomMargin"
		Me.Detail.Controls.AddRange(New XRControl() {Me.XrTable2})
		Me.Detail.HeightF = 24.0!
		Me.Detail.Name = "Detail"
		Me.XrTable2.Borders = BorderSide.Left Or BorderSide.Right Or BorderSide.Bottom
		Me.XrTable2.LocationFloat = New PointFloat(0.00003178914!, 0!)
		Me.XrTable2.Name = "XrTable2"
		Me.XrTable2.Padding = New PaddingInfo(2, 2, 0, 0, 96.0!)
		Me.XrTable2.Rows.AddRange(New XRTableRow() {Me.XrTableRow2})
		Me.XrTable2.SizeF = New System.Drawing.SizeF(750.0!, 24.0!)
		Me.XrTable2.StylePriority.UseBorders = False
		Me.XrTableRow2.Cells.AddRange(New XRTableCell() {Me.XrTableCell6, Me.XrTableCell7, Me.XrTableCell8, Me.XrTableCell5})
		Me.XrTableRow2.Name = "XrTableRow2"
		Me.XrTableRow2.Weight = 1
		Me.XrTableCell6.Borders = BorderSide.Left
		Me.XrTableCell6.Font = New System.Drawing.Font("Arial", 9.75!)
		Me.XrTableCell6.Multiline = True
		Me.XrTableCell6.Name = "XrTableCell6"
		Me.XrTableCell6.StylePriority.UseBorders = False
		Me.XrTableCell6.StylePriority.UseFont = False
		Me.XrTableCell6.StylePriority.UseTextAlignment = False
		Me.XrTableCell6.Text = "[qty]"
		Me.XrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
		Me.XrTableCell6.Weight = 0.573629226516525
		Me.XrTableCell7.Borders = BorderSide.None
		Me.XrTableCell7.Font = New System.Drawing.Font("Arial", 9.75!)
		Me.XrTableCell7.Multiline = True
		Me.XrTableCell7.Name = "XrTableCell7"
		Me.XrTableCell7.StylePriority.UseBorders = False
		Me.XrTableCell7.StylePriority.UseFont = False
		Me.XrTableCell7.StylePriority.UseTextAlignment = False
		Me.XrTableCell7.Text = "[model]"
		Me.XrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
		Me.XrTableCell7.Weight = 1.30449272055636
		Me.XrTableCell8.Borders = BorderSide.None
		Me.XrTableCell8.Font = New System.Drawing.Font("Arial", 9.75!)
		Me.XrTableCell8.Multiline = True
		Me.XrTableCell8.Name = "XrTableCell8"
		Me.XrTableCell8.Padding = New PaddingInfo(5, 2, 0, 0, 100.0!)
		Me.XrTableCell8.StylePriority.UseBorders = False
		Me.XrTableCell8.StylePriority.UseFont = False
		Me.XrTableCell8.StylePriority.UsePadding = False
		Me.XrTableCell8.StylePriority.UseTextAlignment = False
		Me.XrTableCell8.Text = "[description]"
		Me.XrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
		Me.XrTableCell8.Weight = 3.9270263373419
		Me.XrTableCell5.Borders = BorderSide.Right
		Me.XrTableCell5.ExpressionBindings.AddRange(New ExpressionBinding() {New ExpressionBinding("BeforePrint", "Text", "[location]")})
		Me.XrTableCell5.Font = New System.Drawing.Font("Arial", 9.75!)
		Me.XrTableCell5.Multiline = True
		Me.XrTableCell5.Name = "XrTableCell5"
		Me.XrTableCell5.Padding = New PaddingInfo(5, 2, 0, 0, 100.0!)
		Me.XrTableCell5.StylePriority.UseBorders = False
		Me.XrTableCell5.StylePriority.UseFont = False
		Me.XrTableCell5.StylePriority.UsePadding = False
		Me.XrTableCell5.StylePriority.UseTextAlignment = False
		Me.XrTableCell5.Text = "XrTableCell5"
		Me.XrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
		Me.XrTableCell5.Weight = 1.10818521167896
		Me.ReportHeader.Controls.AddRange(New XRControl() {Me.XrLabel18, Me.XrLabel16, Me.XrLabel15, Me.XrLabel14, Me.XrLabel11, Me.XrLabel10, Me.XrLabel9, Me.XrLabel6, Me.XrLabel2, Me.XrLabel1, Me.XrLabel8, Me.XrLabel7, Me.XrLabel5, Me.XrLabel4, Me.XrLabel3})
		Me.ReportHeader.HeightF = 180.9371!
		Me.ReportHeader.Name = "ReportHeader"
		Me.XrLabel18.ExpressionBindings.AddRange(New ExpressionBinding() {New ExpressionBinding("BeforePrint", "Text", "?shipping_method")})
		Me.XrLabel18.LocationFloat = New PointFloat(600.6251!, 147.5205!)
		Me.XrLabel18.Multiline = True
		Me.XrLabel18.Name = "XrLabel18"
		Me.XrLabel18.Padding = New PaddingInfo(2, 2, 0, 0, 100.0!)
		Me.XrLabel18.SizeF = New System.Drawing.SizeF(147.9167!, 17.79165!)
		Me.XrLabel18.Text = "XrLabel18"
		Me.XrLabel16.ExpressionBindings.AddRange(New ExpressionBinding() {New ExpressionBinding("BeforePrint", "Text", "?trucking")})
		Me.XrLabel16.LocationFloat = New PointFloat(110.4167!, 147.5205!)
		Me.XrLabel16.Multiline = True
		Me.XrLabel16.Name = "XrLabel16"
		Me.XrLabel16.Padding = New PaddingInfo(2, 2, 0, 0, 100.0!)
		Me.XrLabel16.SizeF = New System.Drawing.SizeF(276.6667!, 33.41663!)
		Me.XrLabel16.Text = "XrLabel16"
		Me.XrLabel15.Font = New System.Drawing.Font("Arial", 9.75!, FontStyle.Bold)
		Me.XrLabel15.LocationFloat = New PointFloat(471.0419!, 147.5205!)
		Me.XrLabel15.Multiline = True
		Me.XrLabel15.Name = "XrLabel15"
		Me.XrLabel15.Padding = New PaddingInfo(2, 2, 0, 0, 100.0!)
		Me.XrLabel15.SizeF = New System.Drawing.SizeF(129.5833!, 17.79164!)
		Me.XrLabel15.StylePriority.UseFont = False
		Me.XrLabel15.Text = "Shipping Method:"
		Me.XrLabel14.Font = New System.Drawing.Font("Arial", 9.75!, FontStyle.Bold)
		Me.XrLabel14.LocationFloat = New PointFloat(10.00007!, 147.5205!)
		Me.XrLabel14.Multiline = True
		Me.XrLabel14.Name = "XrLabel14"
		Me.XrLabel14.Padding = New PaddingInfo(2, 2, 0, 0, 100.0!)
		Me.XrLabel14.SizeF = New System.Drawing.SizeF(100.4166!, 17.79164!)
		Me.XrLabel14.StylePriority.UseFont = False
		Me.XrLabel14.Text = "Trucking:"
		Me.XrLabel11.ExpressionBindings.AddRange(New ExpressionBinding() {New ExpressionBinding("BeforePrint", "Text", "?agent")})
		Me.XrLabel11.LocationFloat = New PointFloat(614.5833!, 86.37502!)
		Me.XrLabel11.Multiline = True
		Me.XrLabel11.Name = "XrLabel11"
		Me.XrLabel11.Padding = New PaddingInfo(2, 2, 0, 0, 100.0!)
		Me.XrLabel11.SizeF = New System.Drawing.SizeF(135.4167!, 17.79165!)
		Me.XrLabel11.StylePriority.UseTextAlignment = False
		Me.XrLabel11.Text = "XrLabel11"
		Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
		Me.XrLabel10.Font = New System.Drawing.Font("Arial", 9.75!, FontStyle.Bold)
		Me.XrLabel10.LocationFloat = New PointFloat(502.0833!, 86.37502!)
		Me.XrLabel10.Multiline = True
		Me.XrLabel10.Name = "XrLabel10"
		Me.XrLabel10.Padding = New PaddingInfo(2, 2, 0, 0, 100.0!)
		Me.XrLabel10.SizeF = New System.Drawing.SizeF(112.5!, 17.79165!)
		Me.XrLabel10.StylePriority.UseFont = False
		Me.XrLabel10.Text = "Representative:"
		Me.XrLabel9.ExpressionBindings.AddRange(New ExpressionBinding() {New ExpressionBinding("BeforePrint", "Text", "?address")})
		Me.XrLabel9.LocationFloat = New PointFloat(110.4167!, 104.1667!)
		Me.XrLabel9.Multiline = True
		Me.XrLabel9.Name = "XrLabel9"
		Me.XrLabel9.Padding = New PaddingInfo(2, 2, 0, 0, 100.0!)
		Me.XrLabel9.SizeF = New System.Drawing.SizeF(277.0833!, 43.3538!)
		Me.XrLabel9.Text = "XrLabel9"
		Me.XrLabel6.ExpressionBindings.AddRange(New ExpressionBinding() {New ExpressionBinding("BeforePrint", "Text", "?customer")})
		Me.XrLabel6.LocationFloat = New PointFloat(110.4167!, 86.37502!)
		Me.XrLabel6.Multiline = True
		Me.XrLabel6.Name = "XrLabel6"
		Me.XrLabel6.Padding = New PaddingInfo(2, 2, 0, 0, 100.0!)
		Me.XrLabel6.SizeF = New System.Drawing.SizeF(227.7085!, 17.79164!)
		Me.XrLabel6.Text = "XrLabel6"
		Me.XrLabel2.ExpressionBindings.AddRange(New ExpressionBinding() {New ExpressionBinding("BeforePrint", "Text", "?order_id")})
		Me.XrLabel2.LocationFloat = New PointFloat(110.4166!, 68.58336!)
		Me.XrLabel2.Multiline = True
		Me.XrLabel2.Name = "XrLabel2"
		Me.XrLabel2.Padding = New PaddingInfo(2, 2, 0, 0, 100.0!)
		Me.XrLabel2.SizeF = New System.Drawing.SizeF(93.33337!, 17.79165!)
		Me.XrLabel2.StylePriority.UseTextAlignment = False
		Me.XrLabel2.Text = "XrLabel2"
		Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
		Me.XrLabel1.ExpressionBindings.AddRange(New ExpressionBinding() {New ExpressionBinding("BeforePrint", "Text", "?ordered_date")})
		Me.XrLabel1.Font = New System.Drawing.Font("Arial", 9.75!)
		Me.XrLabel1.LocationFloat = New PointFloat(602.0833!, 68.58336!)
		Me.XrLabel1.Multiline = True
		Me.XrLabel1.Name = "XrLabel1"
		Me.XrLabel1.Padding = New PaddingInfo(2, 2, 0, 0, 100.0!)
		Me.XrLabel1.SizeF = New System.Drawing.SizeF(147.9167!, 17.79165!)
		Me.XrLabel1.StylePriority.UseFont = False
		Me.XrLabel1.StylePriority.UseTextAlignment = False
		Me.XrLabel1.Text = "XrLabel1"
		Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
		Me.XrLabel1.TextFormatString = "{0:MMMM dd, yyyy}"
		Me.XrLabel8.Font = New System.Drawing.Font("Arial", 9.75!, FontStyle.Bold)
		Me.XrLabel8.LocationFloat = New PointFloat(10.00001!, 104.1666!)
		Me.XrLabel8.Multiline = True
		Me.XrLabel8.Name = "XrLabel8"
		Me.XrLabel8.Padding = New PaddingInfo(2, 2, 0, 0, 100.0!)
		Me.XrLabel8.SizeF = New System.Drawing.SizeF(100.4166!, 17.79164!)
		Me.XrLabel8.StylePriority.UseFont = False
		Me.XrLabel8.Text = "Address:"
		Me.XrLabel7.Font = New System.Drawing.Font("Arial", 9.75!, FontStyle.Bold)
		Me.XrLabel7.LocationFloat = New PointFloat(10.00001!, 86.37502!)
		Me.XrLabel7.Multiline = True
		Me.XrLabel7.Name = "XrLabel7"
		Me.XrLabel7.Padding = New PaddingInfo(2, 2, 0, 0, 100.0!)
		Me.XrLabel7.SizeF = New System.Drawing.SizeF(100.4166!, 17.79164!)
		Me.XrLabel7.StylePriority.UseFont = False
		Me.XrLabel7.Text = "Customer:"
		Me.XrLabel5.Font = New System.Drawing.Font("Arial", 9.75!, FontStyle.Bold)
		Me.XrLabel5.LocationFloat = New PointFloat(502.0833!, 68.58336!)
		Me.XrLabel5.Multiline = True
		Me.XrLabel5.Name = "XrLabel5"
		Me.XrLabel5.Padding = New PaddingInfo(2, 2, 0, 0, 100.0!)
		Me.XrLabel5.SizeF = New System.Drawing.SizeF(99.99997!, 17.79165!)
		Me.XrLabel5.StylePriority.UseFont = False
		Me.XrLabel5.Text = "Order Date:"
		Me.XrLabel4.Font = New System.Drawing.Font("Arial", 9.75!, FontStyle.Bold)
		Me.XrLabel4.LocationFloat = New PointFloat(10.41667!, 68.58336!)
		Me.XrLabel4.Multiline = True
		Me.XrLabel4.Name = "XrLabel4"
		Me.XrLabel4.Padding = New PaddingInfo(2, 2, 0, 0, 100.0!)
		Me.XrLabel4.SizeF = New System.Drawing.SizeF(99.99997!, 17.79165!)
		Me.XrLabel4.StylePriority.UseFont = False
		Me.XrLabel4.Text = "Order ID:"
		Me.XrLabel3.Font = New System.Drawing.Font("Arial", 22.0!, FontStyle.Bold)
		Me.XrLabel3.LocationFloat = New PointFloat(0!, 0!)
		Me.XrLabel3.Multiline = True
		Me.XrLabel3.Name = "XrLabel3"
		Me.XrLabel3.Padding = New PaddingInfo(2, 2, 0, 0, 100.0!)
		Me.XrLabel3.SizeF = New System.Drawing.SizeF(297.9167!, 54.25002!)
		Me.XrLabel3.StylePriority.UseFont = False
		Me.XrLabel3.StylePriority.UseTextAlignment = False
		Me.XrLabel3.Text = "PACKING LIST"
		Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
		Me.PageHeader.Controls.AddRange(New XRControl() {Me.XrTable1})
		Me.PageHeader.HeightF = 37.0629!
		Me.PageHeader.Name = "PageHeader"
		Me.XrTable1.Borders = BorderSide.All
		Me.XrTable1.LocationFloat = New PointFloat(0!, 0!)
		Me.XrTable1.Name = "XrTable1"
		Me.XrTable1.Padding = New PaddingInfo(2, 2, 0, 0, 96.0!)
		Me.XrTable1.Rows.AddRange(New XRTableRow() {Me.XrTableRow1})
		Me.XrTable1.SizeF = New System.Drawing.SizeF(750.0!, 37.0629!)
		Me.XrTable1.StylePriority.UseBorders = False
		Me.XrTableRow1.Cells.AddRange(New XRTableCell() {Me.XrTableCell1, Me.XrTableCell2, Me.XrTableCell4, Me.XrTableCell3})
		Me.XrTableRow1.Name = "XrTableRow1"
		Me.XrTableRow1.Weight = 1
		Me.XrTableCell1.Borders = BorderSide.Left Or BorderSide.Top Or BorderSide.Bottom
		Me.XrTableCell1.Font = New System.Drawing.Font("Arial", 9.75!, FontStyle.Bold)
		Me.XrTableCell1.Multiline = True
		Me.XrTableCell1.Name = "XrTableCell1"
		Me.XrTableCell1.StylePriority.UseBorders = False
		Me.XrTableCell1.StylePriority.UseFont = False
		Me.XrTableCell1.StylePriority.UseTextAlignment = False
		Me.XrTableCell1.Text = "QTY"
		Me.XrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
		Me.XrTableCell1.Weight = 0.573629506933383
		Me.XrTableCell2.Borders = BorderSide.All
		Me.XrTableCell2.Font = New System.Drawing.Font("Arial", 9.75!, FontStyle.Bold)
		Me.XrTableCell2.Multiline = True
		Me.XrTableCell2.Name = "XrTableCell2"
		Me.XrTableCell2.StylePriority.UseBorders = False
		Me.XrTableCell2.StylePriority.UseFont = False
		Me.XrTableCell2.StylePriority.UseTextAlignment = False
		Me.XrTableCell2.Text = "MODEL"
		Me.XrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
		Me.XrTableCell2.Weight = 1.30449251046557
		Me.XrTableCell4.Borders = BorderSide.Top Or BorderSide.Right Or BorderSide.Bottom
		Me.XrTableCell4.Font = New System.Drawing.Font("Arial", 9.75!, FontStyle.Bold)
		Me.XrTableCell4.Multiline = True
		Me.XrTableCell4.Name = "XrTableCell4"
		Me.XrTableCell4.StylePriority.UseBorders = False
		Me.XrTableCell4.StylePriority.UseFont = False
		Me.XrTableCell4.StylePriority.UseTextAlignment = False
		Me.XrTableCell4.Text = "DESCRIPTION"
		Me.XrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
		Me.XrTableCell4.Weight = 3.92702626701584
		Me.XrTableCell3.Borders = BorderSide.Top Or BorderSide.Right Or BorderSide.Bottom
		Me.XrTableCell3.Font = New System.Drawing.Font("Arial", 9.75!, FontStyle.Bold)
		Me.XrTableCell3.Multiline = True
		Me.XrTableCell3.Name = "XrTableCell3"
		Me.XrTableCell3.StylePriority.UseBorders = False
		Me.XrTableCell3.StylePriority.UseFont = False
		Me.XrTableCell3.StylePriority.UseTextAlignment = False
		Me.XrTableCell3.Text = "LOCATION"
		Me.XrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
		Me.XrTableCell3.Weight = 1.10818521167896
		Me.ReportFooter.Controls.AddRange(New XRControl() {Me.XrLabel19, Me.XrLine2, Me.XrLabel13, Me.XrLabel12, Me.XrLabel17, Me.XrRichText1})
		Me.ReportFooter.HeightF = 136.5474!
		Me.ReportFooter.KeepTogether = True
		Me.ReportFooter.Name = "ReportFooter"
		Me.ReportFooter.PrintAtBottom = True
		Me.XrLine2.LineWidth = 5.0!
		Me.XrLine2.LocationFloat = New PointFloat(0!, 0!)
		Me.XrLine2.Name = "XrLine2"
		Me.XrLine2.SizeF = New System.Drawing.SizeF(750.0!, 5.208333!)
		Me.XrLabel12.Borders = BorderSide.Left Or BorderSide.Top Or BorderSide.Right
		Me.XrLabel12.Font = New System.Drawing.Font("Arial", 9.0!, FontStyle.Bold)
		Me.XrLabel12.LocationFloat = New PointFloat(451.0!, 53.37512!)
		Me.XrLabel12.Multiline = True
		Me.XrLabel12.Name = "XrLabel12"
		Me.XrLabel12.Padding = New PaddingInfo(2, 2, 0, 0, 100.0!)
		Me.XrLabel12.SizeF = New System.Drawing.SizeF(115.0417!, 28.20829!)
		Me.XrLabel12.StylePriority.UseBorders = False
		Me.XrLabel12.StylePriority.UseFont = False
		Me.XrLabel12.StylePriority.UseTextAlignment = False
		Me.XrLabel12.Text = "Checked By"
		Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
		Me.XrLabel17.Font = New System.Drawing.Font("Arial", 11.0!, FontStyle.Bold)
		Me.XrLabel17.LocationFloat = New PointFloat(0.00003178914!, 52.33345!)
		Me.XrLabel17.Multiline = True
		Me.XrLabel17.Name = "XrLabel17"
		Me.XrLabel17.Padding = New PaddingInfo(2, 2, 0, 0, 100.0!)
		Me.XrLabel17.SizeF = New System.Drawing.SizeF(99.99997!, 17.79164!)
		Me.XrLabel17.StylePriority.UseFont = False
		Me.XrLabel17.StylePriority.UseTextAlignment = False
		Me.XrLabel17.Text = "Notes:"
		Me.XrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
		Me.XrRichText1.Font = New System.Drawing.Font("Arial", 9.75!)
		Me.XrRichText1.LocationFloat = New PointFloat(10.41667!, 70.12507!)
		Me.XrRichText1.Name = "XrRichText1"
		Me.XrRichText1.Padding = New PaddingInfo(2, 2, 0, 0, 100.0!)
		Me.XrRichText1.SerializableRtfString = resources.GetString("XrRichText1.SerializableRtfString")
		Me.XrRichText1.SizeF = New System.Drawing.SizeF(307.7083!, 58.33334!)
		Me.sub_total.DataMember = "purchase_order_slip"
		Me.sub_total.Expression = "Sum([total_cost])"
		Me.sub_total.FieldType = FieldType.[Decimal]
		Me.sub_total.Name = "sub_total"
		Me.order_id.Description = "order_id"
		Me.order_id.Name = "order_id"
		Me.order_id.Type = GetType(Integer)
		Me.order_id.ValueInfo = "0"
		Me.order_id.Visible = False
		Me.customer.Description = "customer"
		Me.customer.Name = "customer"
		Me.customer.Visible = False
		Me.address.Description = "address"
		Me.address.Name = "address"
		Me.address.Visible = False
		Me.ordered_date.Description = "ordered_date"
		Me.ordered_date.Name = "ordered_date"
		Me.ordered_date.Type = GetType(DateTime)
		Me.ordered_date.ValueInfo = "2001-01-01"
		Me.ordered_date.Visible = False
		Me.priv_notes.Description = "priv_notes"
		Me.priv_notes.Name = "priv_notes"
		Me.priv_notes.Visible = False
		Me.agent.Description = "agent"
		Me.agent.Name = "agent"
		Me.agent.Visible = False
		Me.PrintData1.DataSetName = "PrintData"
		Me.PrintData1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema
		Me.XrCrossBandBox2.AnchorVertical = VerticalAnchorStyles.Both
		Me.XrCrossBandBox2.Borders = BorderSide.Left Or BorderSide.Top Or BorderSide.Bottom
		Me.XrCrossBandBox2.BorderWidth = 1.0!
		Me.XrCrossBandBox2.EndBand = Me.ReportFooter
		Me.XrCrossBandBox2.EndPointFloat = New PointFloat(451.0!, 120.0!)
		Me.XrCrossBandBox2.Name = "XrCrossBandBox2"
		Me.XrCrossBandBox2.StartBand = Me.ReportFooter
		Me.XrCrossBandBox2.StartPointFloat = New PointFloat(451.0!, 81.5834!)
		Me.XrCrossBandBox2.WidthF = 114.5833!
		Me.trucking.Description = "trucking"
		Me.trucking.Name = "trucking"
		Me.trucking.Visible = False
		Me.shipping_method.Description = "shipping_method"
		Me.shipping_method.Name = "shipping_method"
		Me.shipping_method.Visible = False
		Me.XrCrossBandBox1.AnchorVertical = VerticalAnchorStyles.Both
		Me.XrCrossBandBox1.BorderWidth = 1.0!
		Me.XrCrossBandBox1.EndBand = Me.ReportFooter
		Me.XrCrossBandBox1.EndPointFloat = New PointFloat(564.9999!, 120.0!)
		Me.XrCrossBandBox1.Name = "XrCrossBandBox1"
		Me.XrCrossBandBox1.StartBand = Me.ReportFooter
		Me.XrCrossBandBox1.StartPointFloat = New PointFloat(564.9999!, 81.5834!)
		Me.XrCrossBandBox1.WidthF = 185.0001!
		Me.XrLabel13.Borders = BorderSide.Top Or BorderSide.Right
		Me.XrLabel13.Font = New System.Drawing.Font("Arial", 9.0!, FontStyle.Bold)
		Me.XrLabel13.LocationFloat = New PointFloat(566.0416!, 53.37512!)
		Me.XrLabel13.Multiline = True
		Me.XrLabel13.Name = "XrLabel13"
		Me.XrLabel13.Padding = New PaddingInfo(2, 2, 0, 0, 100.0!)
		Me.XrLabel13.SizeF = New System.Drawing.SizeF(183.9584!, 28.20829!)
		Me.XrLabel13.StylePriority.UseBorders = False
		Me.XrLabel13.StylePriority.UseFont = False
		Me.XrLabel13.StylePriority.UseTextAlignment = False
		Me.XrLabel13.Text = "Remarks"
		Me.XrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
		Me.XrCrossBandBox3.AnchorVertical = VerticalAnchorStyles.Both
		Me.XrCrossBandBox3.Borders = BorderSide.Left Or BorderSide.Top Or BorderSide.Bottom
		Me.XrCrossBandBox3.BorderWidth = 1.0!
		Me.XrCrossBandBox3.EndBand = Me.ReportFooter
		Me.XrCrossBandBox3.EndPointFloat = New PointFloat(335.9583!, 120.0!)
		Me.XrCrossBandBox3.Name = "XrCrossBandBox3"
		Me.XrCrossBandBox3.StartBand = Me.ReportFooter
		Me.XrCrossBandBox3.StartPointFloat = New PointFloat(335.9583!, 81.58339!)
		Me.XrCrossBandBox3.WidthF = 116.0834!
		Me.XrLabel19.Borders = BorderSide.Left Or BorderSide.Top
		Me.XrLabel19.Font = New System.Drawing.Font("Arial", 9.0!, FontStyle.Bold)
		Me.XrLabel19.LocationFloat = New PointFloat(335.9583!, 53.33345!)
		Me.XrLabel19.Multiline = True
		Me.XrLabel19.Name = "XrLabel19"
		Me.XrLabel19.Padding = New PaddingInfo(2, 2, 0, 0, 100.0!)
		Me.XrLabel19.SizeF = New System.Drawing.SizeF(115.0417!, 28.20829!)
		Me.XrLabel19.StylePriority.UseBorders = False
		Me.XrLabel19.StylePriority.UseFont = False
		Me.XrLabel19.StylePriority.UseTextAlignment = False
		Me.XrLabel19.Text = "Prepared By"
		Me.XrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
		Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.TopMargin, Me.BottomMargin, Me.Detail, Me.ReportHeader, Me.PageHeader, Me.ReportFooter})
		Me.CalculatedFields.AddRange(New CalculatedField() {Me.sub_total})
		Me.ComponentStorage.AddRange(New IComponent() {Me.PrintData1})
		Me.CrossBandControls.AddRange(New XRCrossBandControl() {Me.XrCrossBandBox3, Me.XrCrossBandBox2, Me.XrCrossBandBox1})
		Me.DataMember = "packing_list"
		Me.DataSource = Me.PrintData1
		Me.Font = New System.Drawing.Font("Arial", 9.75!)
		Me.Margins = New System.Drawing.Printing.Margins(50, 50, 50, 50)
		Me.Parameters.AddRange(New Parameter() {Me.order_id, Me.customer, Me.address, Me.ordered_date, Me.priv_notes, Me.agent, Me.trucking, Me.shipping_method})
		Me.RequestParameters = False
		Me.Version = "21.1"
		DirectCast(Me.XrTable2, ISupportInitialize).EndInit()
		DirectCast(Me.XrTable1, ISupportInitialize).EndInit()
		DirectCast(Me.XrRichText1, ISupportInitialize).EndInit()
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
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
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
    Friend WithEvents XrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrRichText1 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents sub_total As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents order_id As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents customer As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents address As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents ordered_date As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents priv_notes As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents agent As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents PrintData1 As PrintData
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrCrossBandBox1 As DevExpress.XtraReports.UI.XRCrossBandBox
    Friend WithEvents XrCrossBandBox2 As DevExpress.XtraReports.UI.XRCrossBandBox
    Friend WithEvents XrLabel18 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
	Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
	Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents trucking As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents shipping_method As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
	Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
	Friend WithEvents XrCrossBandBox3 As XRCrossBandBox
	Friend WithEvents XrLabel19 As XRLabel
End Class
