Imports DevExpress.Utils
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraPrinting.Drawing
Imports DevExpress.XtraReports.Parameters
Imports DevExpress.XtraReports.UI
Imports System.ComponentModel

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class doc_transfer_request
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(doc_transfer_request))
		Me.TopMargin = New TopMarginBand()
		Me.BottomMargin = New BottomMarginBand()
		Me.Detail = New DetailBand()
		Me.XrTable3 = New XRTable()
		Me.XrTableRow8 = New XRTableRow()
		Me.XrTableCell23 = New XRTableCell()
		Me.XrTableCell24 = New XRTableCell()
		Me.XrTableCell25 = New XRTableCell()
		Me.XrTableCell26 = New XRTableCell()
		Me.ReportHeader = New ReportHeaderBand()
		Me.XrLabel10 = New XRLabel()
		Me.XrLabel14 = New XRLabel()
		Me.XrLabel13 = New XRLabel()
		Me.XrLabel9 = New XRLabel()
		Me.XrLabel7 = New XRLabel()
		Me.XrLabel6 = New XRLabel()
		Me.XrLabel5 = New XRLabel()
		Me.XrLabel4 = New XRLabel()
		Me.XrLabel3 = New XRLabel()
		Me.XrLabel2 = New XRLabel()
		Me.XrLabel1 = New XRLabel()
		Me.XrPictureBox1 = New XRPictureBox()
		Me.PageHeader = New PageHeaderBand()
		Me.XrTable1 = New XRTable()
		Me.XrTableRow1 = New XRTableRow()
		Me.XrTableCell1 = New XRTableCell()
		Me.XrTableCell2 = New XRTableCell()
		Me.XrTableCell4 = New XRTableCell()
		Me.XrTableCell22 = New XRTableCell()
		Me.ReportFooter = New ReportFooterBand()
		Me.XrTable2 = New XRTable()
		Me.XrTableRow2 = New XRTableRow()
		Me.XrTableCell3 = New XRTableCell()
		Me.XrTableCell5 = New XRTableCell()
		Me.XrTableCell6 = New XRTableCell()
		Me.XrTableRow4 = New XRTableRow()
		Me.XrTableCell10 = New XRTableCell()
		Me.XrTableCell11 = New XRTableCell()
		Me.XrTableCell12 = New XRTableCell()
		Me.XrTableRow6 = New XRTableRow()
		Me.XrTableCell16 = New XRTableCell()
		Me.XrTableCell17 = New XRTableCell()
		Me.XrTableCell18 = New XRTableCell()
		Me.XrTableRow5 = New XRTableRow()
		Me.XrTableCell13 = New XRTableCell()
		Me.XrTableCell14 = New XRTableCell()
		Me.XrTableCell15 = New XRTableCell()
		Me.XrTableRow3 = New XRTableRow()
		Me.XrTableCell7 = New XRTableCell()
		Me.XrTableCell8 = New XRTableCell()
		Me.XrTableCell9 = New XRTableCell()
		Me.XrTableRow7 = New XRTableRow()
		Me.XrTableCell19 = New XRTableCell()
		Me.XrTableCell20 = New XRTableCell()
		Me.XrTableCell21 = New XRTableCell()
		Me.XrLabel23 = New XRLabel()
		Me.XrLabel20 = New XRLabel()
		Me.XrLine5 = New XRLine()
		Me.XrLine2 = New XRLine()
		Me.sub_total = New CalculatedField()
		Me.transfer_id = New Parameter()
		Me.transfer_date = New Parameter()
		Me.transfer_from = New Parameter()
		Me.transfer_to = New Parameter()
		Me.transfer_by = New Parameter()
		Me.PrintData1 = New PrintData()
		Me.store_info = New Parameter()
		Me.approved_by = New Parameter()
		Me.counted_by = New Parameter()
		Me.received_by = New Parameter()
		Me.prepared_by = New Parameter()
		Me.driver = New Parameter()
		Me.released_by = New Parameter()
		Me.XrTableCell27 = New XRTableCell()
		Me.XrTableCell28 = New XRTableCell()
		DirectCast(Me.XrTable3, ISupportInitialize).BeginInit()
		DirectCast(Me.XrTable1, ISupportInitialize).BeginInit()
		DirectCast(Me.XrTable2, ISupportInitialize).BeginInit()
		DirectCast(Me.PrintData1, ISupportInitialize).BeginInit()
		DirectCast(Me, ISupportInitialize).BeginInit()
		Me.TopMargin.HeightF = 50.0!
		Me.TopMargin.Name = "TopMargin"
		Me.BottomMargin.HeightF = 50.0!
		Me.BottomMargin.Name = "BottomMargin"
		Me.Detail.Controls.AddRange(New XRControl() {Me.XrTable3})
		Me.Detail.HeightF = 25.0!
		Me.Detail.Name = "Detail"
		Me.XrTable3.LocationFloat = New PointFloat(0!, 0!)
		Me.XrTable3.Name = "XrTable3"
		Me.XrTable3.Rows.AddRange(New XRTableRow() {Me.XrTableRow8})
		Me.XrTable3.SizeF = New System.Drawing.SizeF(759.0!, 25.0!)
		Me.XrTableRow8.Cells.AddRange(New XRTableCell() {Me.XrTableCell23, Me.XrTableCell28, Me.XrTableCell24, Me.XrTableCell25, Me.XrTableCell26})
		Me.XrTableRow8.Name = "XrTableRow8"
		Me.XrTableRow8.Weight = 11.5
		Me.XrTableCell23.ExpressionBindings.AddRange(New ExpressionBinding() {New ExpressionBinding("BeforePrint", "Text", "[qty]")})
		Me.XrTableCell23.Multiline = True
		Me.XrTableCell23.Name = "XrTableCell23"
		Me.XrTableCell23.Padding = New PaddingInfo(2, 2, 0, 0, 100.0!)
		Me.XrTableCell23.StylePriority.UseTextAlignment = False
		Me.XrTableCell23.Text = "XrLabel11"
		Me.XrTableCell23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
		Me.XrTableCell23.Weight = 130.956037741794
		Me.XrTableCell24.ExpressionBindings.AddRange(New ExpressionBinding() {New ExpressionBinding("BeforePrint", "Text", "[model]")})
		Me.XrTableCell24.Multiline = True
		Me.XrTableCell24.Name = "XrTableCell24"
		Me.XrTableCell24.Padding = New PaddingInfo(2, 2, 0, 0, 100.0!)
		Me.XrTableCell24.StylePriority.UseTextAlignment = False
		Me.XrTableCell24.Text = "XrLabel15"
		Me.XrTableCell24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
		Me.XrTableCell24.Weight = 294.472086378901
		Me.XrTableCell25.ExpressionBindings.AddRange(New ExpressionBinding() {New ExpressionBinding("BeforePrint", "Text", "[description]")})
		Me.XrTableCell25.Multiline = True
		Me.XrTableCell25.Name = "XrTableCell25"
		Me.XrTableCell25.Padding = New PaddingInfo(2, 2, 0, 0, 100.0!)
		Me.XrTableCell25.StylePriority.UseTextAlignment = False
		Me.XrTableCell25.Text = "XrLabel16"
		Me.XrTableCell25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
		Me.XrTableCell25.Weight = 631.514180824178
		Me.XrTableCell26.Multiline = True
		Me.XrTableCell26.Name = "XrTableCell26"
		Me.XrTableCell26.Padding = New PaddingInfo(2, 2, 0, 0, 100.0!)
		Me.XrTableCell26.StylePriority.UseTextAlignment = False
		Me.XrTableCell26.Text = "[location]"
		Me.XrTableCell26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
		Me.XrTableCell26.Weight = 205.224366808056
		Me.ReportHeader.Controls.AddRange(New XRControl() {Me.XrLabel10, Me.XrLabel14, Me.XrLabel13, Me.XrLabel9, Me.XrLabel7, Me.XrLabel6, Me.XrLabel5, Me.XrLabel4, Me.XrLabel3, Me.XrLabel2, Me.XrLabel1, Me.XrPictureBox1})
		Me.ReportHeader.HeightF = 179.7499!
		Me.ReportHeader.Name = "ReportHeader"
		Me.XrLabel10.ExpressionBindings.AddRange(New ExpressionBinding() {New ExpressionBinding("BeforePrint", "Text", "?transfer_to")})
		Me.XrLabel10.LocationFloat = New PointFloat(460.8332!, 137.5!)
		Me.XrLabel10.Multiline = True
		Me.XrLabel10.Name = "XrLabel10"
		Me.XrLabel10.Padding = New PaddingInfo(2, 2, 0, 0, 100.0!)
		Me.XrLabel10.SizeF = New System.Drawing.SizeF(287.0836!, 17.79166!)
		Me.XrLabel10.Text = "XrLabel10"
		Me.XrLabel14.ExpressionBindings.AddRange(New ExpressionBinding() {New ExpressionBinding("BeforePrint", "Text", "?transfer_from")})
		Me.XrLabel14.LocationFloat = New PointFloat(120.8333!, 137.5!)
		Me.XrLabel14.Multiline = True
		Me.XrLabel14.Name = "XrLabel14"
		Me.XrLabel14.Padding = New PaddingInfo(2, 2, 0, 0, 100.0!)
		Me.XrLabel14.SizeF = New System.Drawing.SizeF(252.0833!, 17.79166!)
		Me.XrLabel14.Text = "XrLabel14"
		Me.XrLabel13.ExpressionBindings.AddRange(New ExpressionBinding() {New ExpressionBinding("BeforePrint", "Text", "?transfer_date")})
		Me.XrLabel13.LocationFloat = New PointFloat(604.1667!, 82.20834!)
		Me.XrLabel13.Multiline = True
		Me.XrLabel13.Name = "XrLabel13"
		Me.XrLabel13.Padding = New PaddingInfo(2, 2, 0, 0, 100.0!)
		Me.XrLabel13.SizeF = New System.Drawing.SizeF(145.8334!, 17.79165!)
		Me.XrLabel13.StylePriority.UseTextAlignment = False
		Me.XrLabel13.Text = "XrLabel13"
		Me.XrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
		Me.XrLabel13.TextFormatString = "{0:MM/dd/yyyy}"
		Me.XrLabel9.ExpressionBindings.AddRange(New ExpressionBinding() {New ExpressionBinding("BeforePrint", "Text", "?transfer_id")})
		Me.XrLabel9.LocationFloat = New PointFloat(604.1667!, 64.41669!)
		Me.XrLabel9.Multiline = True
		Me.XrLabel9.Name = "XrLabel9"
		Me.XrLabel9.Padding = New PaddingInfo(2, 2, 0, 0, 100.0!)
		Me.XrLabel9.SizeF = New System.Drawing.SizeF(145.8334!, 17.79165!)
		Me.XrLabel9.StylePriority.UseTextAlignment = False
		Me.XrLabel9.Text = "XrLabel9"
		Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
		Me.XrLabel7.Font = New System.Drawing.Font("Arial", 9.75!, FontStyle.Bold)
		Me.XrLabel7.LocationFloat = New PointFloat(372.9166!, 137.5!)
		Me.XrLabel7.Multiline = True
		Me.XrLabel7.Name = "XrLabel7"
		Me.XrLabel7.Padding = New PaddingInfo(2, 2, 0, 0, 100.0!)
		Me.XrLabel7.SizeF = New System.Drawing.SizeF(87.9166!, 17.79164!)
		Me.XrLabel7.StylePriority.UseFont = False
		Me.XrLabel7.Text = "Transfer To:"
		Me.XrLabel6.Font = New System.Drawing.Font("Arial", 9.75!, FontStyle.Bold)
		Me.XrLabel6.LocationFloat = New PointFloat(10.00001!, 137.5!)
		Me.XrLabel6.Multiline = True
		Me.XrLabel6.Name = "XrLabel6"
		Me.XrLabel6.Padding = New PaddingInfo(2, 2, 0, 0, 100.0!)
		Me.XrLabel6.SizeF = New System.Drawing.SizeF(110.8333!, 17.79166!)
		Me.XrLabel6.StylePriority.UseFont = False
		Me.XrLabel6.Text = "Transfer From:"
		Me.XrLabel5.Font = New System.Drawing.Font("Arial", 9.75!, FontStyle.Bold)
		Me.XrLabel5.LocationFloat = New PointFloat(504.1667!, 82.20834!)
		Me.XrLabel5.Multiline = True
		Me.XrLabel5.Name = "XrLabel5"
		Me.XrLabel5.Padding = New PaddingInfo(2, 2, 0, 0, 100.0!)
		Me.XrLabel5.SizeF = New System.Drawing.SizeF(99.99997!, 17.79165!)
		Me.XrLabel5.StylePriority.UseFont = False
		Me.XrLabel5.Text = "Transfer Date:"
		Me.XrLabel4.Font = New System.Drawing.Font("Arial", 9.75!, FontStyle.Bold)
		Me.XrLabel4.LocationFloat = New PointFloat(504.1667!, 64.41669!)
		Me.XrLabel4.Multiline = True
		Me.XrLabel4.Name = "XrLabel4"
		Me.XrLabel4.Padding = New PaddingInfo(2, 2, 0, 0, 100.0!)
		Me.XrLabel4.SizeF = New System.Drawing.SizeF(99.99997!, 17.79165!)
		Me.XrLabel4.StylePriority.UseFont = False
		Me.XrLabel4.Text = "Transfer ID:"
		Me.XrLabel3.Font = New System.Drawing.Font("Arial", 22.0!, FontStyle.Bold)
		Me.XrLabel3.LocationFloat = New PointFloat(450.0002!, 0!)
		Me.XrLabel3.Multiline = True
		Me.XrLabel3.Name = "XrLabel3"
		Me.XrLabel3.Padding = New PaddingInfo(2, 2, 0, 0, 100.0!)
		Me.XrLabel3.SizeF = New System.Drawing.SizeF(297.9167!, 54.25002!)
		Me.XrLabel3.StylePriority.UseFont = False
		Me.XrLabel3.StylePriority.UseTextAlignment = False
		Me.XrLabel3.Text = "STOCK TRANSFER"
		Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
		Me.XrLabel2.ExpressionBindings.AddRange(New ExpressionBinding() {New ExpressionBinding("BeforePrint", "Text", "?store_info")})
		Me.XrLabel2.LocationFloat = New PointFloat(100.0!, 29.87499!)
		Me.XrLabel2.Multiline = True
		Me.XrLabel2.Name = "XrLabel2"
		Me.XrLabel2.Padding = New PaddingInfo(2, 2, 0, 0, 100.0!)
		Me.XrLabel2.SizeF = New System.Drawing.SizeF(333.3333!, 70.12501!)
		Me.XrLabel2.Text = "345 Unit D, J. Teodoro St., Grace Park, Caloocan City" & vbCrLf & "Globe: 09052862165 / 09272673759" & vbCrLf & "Tel/Fax: 7753-0278 / 83654851"
		Me.XrLabel1.Font = New System.Drawing.Font("Arial", 9.75!, FontStyle.Bold)
		Me.XrLabel1.LocationFloat = New PointFloat(100.0!, 9.99999!)
		Me.XrLabel1.Multiline = True
		Me.XrLabel1.Name = "XrLabel1"
		Me.XrLabel1.Padding = New PaddingInfo(2, 2, 0, 0, 100.0!)
		Me.XrLabel1.SizeF = New System.Drawing.SizeF(333.3333!, 19.875!)
		Me.XrLabel1.StylePriority.UseFont = False
		Me.XrLabel1.Text = "Winland Electronics and Electrical Center"
		Me.XrPictureBox1.ImageAlignment = ImageAlignment.MiddleCenter
		Me.XrPictureBox1.ImageSource = New ImageSource("img", resources.GetString("XrPictureBox1.ImageSource"))
		Me.XrPictureBox1.LocationFloat = New PointFloat(0!, 0!)
		Me.XrPictureBox1.Name = "XrPictureBox1"
		Me.XrPictureBox1.SizeF = New System.Drawing.SizeF(100.0!, 100.0!)
		Me.XrPictureBox1.Sizing = ImageSizeMode.ZoomImage
		Me.PageHeader.Controls.AddRange(New XRControl() {Me.XrTable1})
		Me.PageHeader.HeightF = 29.99998!
		Me.PageHeader.Name = "PageHeader"
		Me.XrTable1.Borders = BorderSide.All
		Me.XrTable1.LocationFloat = New PointFloat(0!, 0!)
		Me.XrTable1.Name = "XrTable1"
		Me.XrTable1.Padding = New PaddingInfo(2, 2, 0, 0, 96.0!)
		Me.XrTable1.Rows.AddRange(New XRTableRow() {Me.XrTableRow1})
		Me.XrTable1.SizeF = New System.Drawing.SizeF(759.0!, 29.99998!)
		Me.XrTable1.StylePriority.UseBorders = False
		Me.XrTableRow1.Cells.AddRange(New XRTableCell() {Me.XrTableCell1, Me.XrTableCell27, Me.XrTableCell2, Me.XrTableCell4, Me.XrTableCell22})
		Me.XrTableRow1.Name = "XrTableRow1"
		Me.XrTableRow1.Weight = 1
		Me.XrTableCell1.BackColor = Color.Black
		Me.XrTableCell1.Borders = BorderSide.None
		Me.XrTableCell1.Font = New System.Drawing.Font("Arial", 9.75!, FontStyle.Bold)
		Me.XrTableCell1.ForeColor = Color.White
		Me.XrTableCell1.Multiline = True
		Me.XrTableCell1.Name = "XrTableCell1"
		Me.XrTableCell1.StylePriority.UseBackColor = False
		Me.XrTableCell1.StylePriority.UseBorders = False
		Me.XrTableCell1.StylePriority.UseFont = False
		Me.XrTableCell1.StylePriority.UseForeColor = False
		Me.XrTableCell1.StylePriority.UseTextAlignment = False
		Me.XrTableCell1.Text = "Piece"
		Me.XrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
		Me.XrTableCell1.Weight = 0.69843215546451
		Me.XrTableCell2.BackColor = Color.Black
		Me.XrTableCell2.Borders = BorderSide.None
		Me.XrTableCell2.Font = New System.Drawing.Font("Arial", 9.75!, FontStyle.Bold)
		Me.XrTableCell2.ForeColor = Color.White
		Me.XrTableCell2.Multiline = True
		Me.XrTableCell2.Name = "XrTableCell2"
		Me.XrTableCell2.StylePriority.UseBackColor = False
		Me.XrTableCell2.StylePriority.UseBorders = False
		Me.XrTableCell2.StylePriority.UseFont = False
		Me.XrTableCell2.StylePriority.UseForeColor = False
		Me.XrTableCell2.StylePriority.UseTextAlignment = False
		Me.XrTableCell2.Text = "Model"
		Me.XrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
		Me.XrTableCell2.Weight = 1.57051787990445
		Me.XrTableCell4.BackColor = Color.Black
		Me.XrTableCell4.Borders = BorderSide.None
		Me.XrTableCell4.Font = New System.Drawing.Font("Arial", 9.75!, FontStyle.Bold)
		Me.XrTableCell4.ForeColor = Color.White
		Me.XrTableCell4.Multiline = True
		Me.XrTableCell4.Name = "XrTableCell4"
		Me.XrTableCell4.StylePriority.UseBackColor = False
		Me.XrTableCell4.StylePriority.UseBorders = False
		Me.XrTableCell4.StylePriority.UseFont = False
		Me.XrTableCell4.StylePriority.UseForeColor = False
		Me.XrTableCell4.StylePriority.UseTextAlignment = False
		Me.XrTableCell4.Text = "Description"
		Me.XrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
		Me.XrTableCell4.Weight = 3.36807520278578
		Me.XrTableCell22.BackColor = Color.Black
		Me.XrTableCell22.Borders = BorderSide.None
		Me.XrTableCell22.Font = New System.Drawing.Font("Arial", 9.75!, FontStyle.Bold)
		Me.XrTableCell22.ForeColor = Color.White
		Me.XrTableCell22.Multiline = True
		Me.XrTableCell22.Name = "XrTableCell22"
		Me.XrTableCell22.StylePriority.UseBackColor = False
		Me.XrTableCell22.StylePriority.UseBorders = False
		Me.XrTableCell22.StylePriority.UseFont = False
		Me.XrTableCell22.StylePriority.UseForeColor = False
		Me.XrTableCell22.StylePriority.UseTextAlignment = False
		Me.XrTableCell22.Text = "Location"
		Me.XrTableCell22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
		Me.XrTableCell22.Weight = 1.09452973417599
		Me.ReportFooter.Controls.AddRange(New XRControl() {Me.XrTable2, Me.XrLabel23, Me.XrLabel20, Me.XrLine5, Me.XrLine2})
		Me.ReportFooter.HeightF = 210.084!
		Me.ReportFooter.Name = "ReportFooter"
		Me.ReportFooter.PrintAtBottom = True
		Me.XrTable2.Borders = BorderSide.All
		Me.XrTable2.BorderWidth = 0.5!
		Me.XrTable2.Font = New System.Drawing.Font("Arial", 9.0!)
		Me.XrTable2.ForeColor = Color.Black
		Me.XrTable2.LocationFloat = New PointFloat(0!, 34.58348!)
		Me.XrTable2.Name = "XrTable2"
		Me.XrTable2.Padding = New PaddingInfo(2, 2, 0, 0, 96.0!)
		Me.XrTable2.Rows.AddRange(New XRTableRow() {Me.XrTableRow2, Me.XrTableRow4, Me.XrTableRow6, Me.XrTableRow5, Me.XrTableRow3, Me.XrTableRow7})
		Me.XrTable2.SizeF = New System.Drawing.SizeF(399.4318!, 145.9584!)
		Me.XrTable2.StylePriority.UseBorders = False
		Me.XrTable2.StylePriority.UseBorderWidth = False
		Me.XrTable2.StylePriority.UseFont = False
		Me.XrTable2.StylePriority.UseForeColor = False
		Me.XrTable2.StylePriority.UseTextAlignment = False
		Me.XrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
		Me.XrTableRow2.Cells.AddRange(New XRTableCell() {Me.XrTableCell3, Me.XrTableCell5, Me.XrTableCell6})
		Me.XrTableRow2.Name = "XrTableRow2"
		Me.XrTableRow2.Weight = 1
		Me.XrTableCell3.Multiline = True
		Me.XrTableCell3.Name = "XrTableCell3"
		Me.XrTableCell3.Text = "Generated By"
		Me.XrTableCell3.Weight = 1
		Me.XrTableCell5.Multiline = True
		Me.XrTableCell5.Name = "XrTableCell5"
		Me.XrTableCell5.Text = "Prepared By"
		Me.XrTableCell5.Weight = 1
		Me.XrTableCell6.Multiline = True
		Me.XrTableCell6.Name = "XrTableCell6"
		Me.XrTableCell6.Text = "Driver"
		Me.XrTableCell6.Weight = 1
		Me.XrTableRow4.Cells.AddRange(New XRTableCell() {Me.XrTableCell10, Me.XrTableCell11, Me.XrTableCell12})
		Me.XrTableRow4.Name = "XrTableRow4"
		Me.XrTableRow4.Weight = 1
		Me.XrTableCell10.ExpressionBindings.AddRange(New ExpressionBinding() {New ExpressionBinding("BeforePrint", "Text", "?transfer_by")})
		Me.XrTableCell10.Font = New System.Drawing.Font("Arial", 9.0!, FontStyle.Bold)
		Me.XrTableCell10.Multiline = True
		Me.XrTableCell10.Name = "XrTableCell10"
		Me.XrTableCell10.Padding = New PaddingInfo(2, 2, 0, 8, 100.0!)
		Me.XrTableCell10.RowSpan = 2
		Me.XrTableCell10.StylePriority.UseFont = False
		Me.XrTableCell10.StylePriority.UsePadding = False
		Me.XrTableCell10.StylePriority.UseTextAlignment = False
		Me.XrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
		Me.XrTableCell10.Weight = 1
		Me.XrTableCell11.ExpressionBindings.AddRange(New ExpressionBinding() {New ExpressionBinding("BeforePrint", "Text", "?prepared_by")})
		Me.XrTableCell11.Font = New System.Drawing.Font("Arial", 9.0!, FontStyle.Bold)
		Me.XrTableCell11.Multiline = True
		Me.XrTableCell11.Name = "XrTableCell11"
		Me.XrTableCell11.Padding = New PaddingInfo(2, 2, 0, 8, 100.0!)
		Me.XrTableCell11.RowSpan = 2
		Me.XrTableCell11.StylePriority.UseFont = False
		Me.XrTableCell11.StylePriority.UsePadding = False
		Me.XrTableCell11.StylePriority.UseTextAlignment = False
		Me.XrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
		Me.XrTableCell11.Weight = 1
		Me.XrTableCell12.ExpressionBindings.AddRange(New ExpressionBinding() {New ExpressionBinding("BeforePrint", "Text", "?driver")})
		Me.XrTableCell12.Font = New System.Drawing.Font("Arial", 9.0!, FontStyle.Bold)
		Me.XrTableCell12.Multiline = True
		Me.XrTableCell12.Name = "XrTableCell12"
		Me.XrTableCell12.Padding = New PaddingInfo(2, 2, 0, 8, 100.0!)
		Me.XrTableCell12.RowSpan = 2
		Me.XrTableCell12.StylePriority.UseFont = False
		Me.XrTableCell12.StylePriority.UsePadding = False
		Me.XrTableCell12.StylePriority.UseTextAlignment = False
		Me.XrTableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
		Me.XrTableCell12.Weight = 1
		Me.XrTableRow6.Cells.AddRange(New XRTableCell() {Me.XrTableCell16, Me.XrTableCell17, Me.XrTableCell18})
		Me.XrTableRow6.Name = "XrTableRow6"
		Me.XrTableRow6.Weight = 1
		Me.XrTableCell16.Multiline = True
		Me.XrTableCell16.Name = "XrTableCell16"
		Me.XrTableCell16.Text = "XrTableCell16"
		Me.XrTableCell16.Weight = 1
		Me.XrTableCell17.Multiline = True
		Me.XrTableCell17.Name = "XrTableCell17"
		Me.XrTableCell17.Text = "XrTableCell17"
		Me.XrTableCell17.Weight = 1
		Me.XrTableCell18.Multiline = True
		Me.XrTableCell18.Name = "XrTableCell18"
		Me.XrTableCell18.Text = "XrTableCell18"
		Me.XrTableCell18.Weight = 1
		Me.XrTableRow5.Cells.AddRange(New XRTableCell() {Me.XrTableCell13, Me.XrTableCell14, Me.XrTableCell15})
		Me.XrTableRow5.Name = "XrTableRow5"
		Me.XrTableRow5.Weight = 1
		Me.XrTableCell13.Multiline = True
		Me.XrTableCell13.Name = "XrTableCell13"
		Me.XrTableCell13.Text = "Approved By"
		Me.XrTableCell13.Weight = 1
		Me.XrTableCell14.Multiline = True
		Me.XrTableCell14.Name = "XrTableCell14"
		Me.XrTableCell14.Text = "Count By"
		Me.XrTableCell14.Weight = 1
		Me.XrTableCell15.Multiline = True
		Me.XrTableCell15.Name = "XrTableCell15"
		Me.XrTableCell15.Text = "Released By"
		Me.XrTableCell15.Weight = 1
		Me.XrTableRow3.Cells.AddRange(New XRTableCell() {Me.XrTableCell7, Me.XrTableCell8, Me.XrTableCell9})
		Me.XrTableRow3.Name = "XrTableRow3"
		Me.XrTableRow3.Weight = 1
		Me.XrTableCell7.ExpressionBindings.AddRange(New ExpressionBinding() {New ExpressionBinding("BeforePrint", "Text", "?approved_by")})
		Me.XrTableCell7.Font = New System.Drawing.Font("Arial", 9.0!, FontStyle.Bold)
		Me.XrTableCell7.Multiline = True
		Me.XrTableCell7.Name = "XrTableCell7"
		Me.XrTableCell7.Padding = New PaddingInfo(2, 2, 0, 8, 100.0!)
		Me.XrTableCell7.RowSpan = 2
		Me.XrTableCell7.StylePriority.UseFont = False
		Me.XrTableCell7.StylePriority.UsePadding = False
		Me.XrTableCell7.StylePriority.UseTextAlignment = False
		Me.XrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
		Me.XrTableCell7.Weight = 1
		Me.XrTableCell8.ExpressionBindings.AddRange(New ExpressionBinding() {New ExpressionBinding("BeforePrint", "Text", "?counted_by")})
		Me.XrTableCell8.Font = New System.Drawing.Font("Arial", 9.0!, FontStyle.Bold)
		Me.XrTableCell8.Multiline = True
		Me.XrTableCell8.Name = "XrTableCell8"
		Me.XrTableCell8.Padding = New PaddingInfo(2, 2, 0, 8, 100.0!)
		Me.XrTableCell8.RowSpan = 2
		Me.XrTableCell8.StylePriority.UseFont = False
		Me.XrTableCell8.StylePriority.UsePadding = False
		Me.XrTableCell8.StylePriority.UseTextAlignment = False
		Me.XrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
		Me.XrTableCell8.Weight = 1
		Me.XrTableCell9.ExpressionBindings.AddRange(New ExpressionBinding() {New ExpressionBinding("BeforePrint", "Text", "?released_by")})
		Me.XrTableCell9.Font = New System.Drawing.Font("Arial", 9.0!, FontStyle.Bold)
		Me.XrTableCell9.Multiline = True
		Me.XrTableCell9.Name = "XrTableCell9"
		Me.XrTableCell9.Padding = New PaddingInfo(2, 2, 0, 8, 100.0!)
		Me.XrTableCell9.RowSpan = 2
		Me.XrTableCell9.StylePriority.UseFont = False
		Me.XrTableCell9.StylePriority.UsePadding = False
		Me.XrTableCell9.StylePriority.UseTextAlignment = False
		Me.XrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
		Me.XrTableCell9.Weight = 1
		Me.XrTableRow7.Cells.AddRange(New XRTableCell() {Me.XrTableCell19, Me.XrTableCell20, Me.XrTableCell21})
		Me.XrTableRow7.Name = "XrTableRow7"
		Me.XrTableRow7.Weight = 1
		Me.XrTableCell19.Multiline = True
		Me.XrTableCell19.Name = "XrTableCell19"
		Me.XrTableCell19.Text = "XrTableCell19"
		Me.XrTableCell19.Weight = 1
		Me.XrTableCell20.Multiline = True
		Me.XrTableCell20.Name = "XrTableCell20"
		Me.XrTableCell20.Text = "XrTableCell20"
		Me.XrTableCell20.Weight = 1
		Me.XrTableCell21.Multiline = True
		Me.XrTableCell21.Name = "XrTableCell21"
		Me.XrTableCell21.Text = "XrTableCell21"
		Me.XrTableCell21.Weight = 1
		Me.XrLabel23.ExpressionBindings.AddRange(New ExpressionBinding() {New ExpressionBinding("BeforePrint", "Text", "?received_by")})
		Me.XrLabel23.Font = New System.Drawing.Font("Arial", 9.75!, FontStyle.Bold)
		Me.XrLabel23.LocationFloat = New PointFloat(570.8333!, 154.4168!)
		Me.XrLabel23.Multiline = True
		Me.XrLabel23.Name = "XrLabel23"
		Me.XrLabel23.Padding = New PaddingInfo(2, 2, 0, 0, 100.0!)
		Me.XrLabel23.SizeF = New System.Drawing.SizeF(166.6666!, 17.79166!)
		Me.XrLabel23.StylePriority.UseFont = False
		Me.XrLabel23.StylePriority.UseTextAlignment = False
		Me.XrLabel23.Text = "XrLabel12"
		Me.XrLabel23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
		Me.XrLabel20.Font = New System.Drawing.Font("Arial", 9.75!)
		Me.XrLabel20.LocationFloat = New PointFloat(570.8334!, 113.7085!)
		Me.XrLabel20.Multiline = True
		Me.XrLabel20.Name = "XrLabel20"
		Me.XrLabel20.Padding = New PaddingInfo(2, 2, 0, 0, 100.0!)
		Me.XrLabel20.SizeF = New System.Drawing.SizeF(166.6665!, 17.79164!)
		Me.XrLabel20.StylePriority.UseFont = False
		Me.XrLabel20.StylePriority.UseTextAlignment = False
		Me.XrLabel20.Text = "Received by:"
		Me.XrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
		Me.XrLine5.LocationFloat = New PointFloat(570.8336!, 172.2085!)
		Me.XrLine5.Name = "XrLine5"
		Me.XrLine5.SizeF = New System.Drawing.SizeF(166.6666!, 8.333344!)
		Me.XrLine2.LineWidth = 5.0!
		Me.XrLine2.LocationFloat = New PointFloat(0!, 0!)
		Me.XrLine2.Name = "XrLine2"
		Me.XrLine2.SizeF = New System.Drawing.SizeF(759.0!, 5.208333!)
		Me.sub_total.DataMember = "purchase_order_slip"
		Me.sub_total.Expression = "Sum([total_cost])"
		Me.sub_total.FieldType = FieldType.[Decimal]
		Me.sub_total.Name = "sub_total"
		Me.transfer_id.Description = "transfer_id"
		Me.transfer_id.Name = "transfer_id"
		Me.transfer_id.Visible = False
		Me.transfer_date.Description = "transfer_date"
		Me.transfer_date.Name = "transfer_date"
		Me.transfer_date.Type = GetType(DateTime)
		Me.transfer_date.ValueInfo = "2020-12-18"
		Me.transfer_date.Visible = False
		Me.transfer_from.Description = "transfer_from"
		Me.transfer_from.Name = "transfer_from"
		Me.transfer_from.Visible = False
		Me.transfer_to.Description = "transfer_to"
		Me.transfer_to.Name = "transfer_to"
		Me.transfer_to.Visible = False
		Me.transfer_by.Description = "transfer_by"
		Me.transfer_by.Name = "transfer_by"
		Me.transfer_by.Visible = False
		Me.PrintData1.DataSetName = "PrintData"
		Me.PrintData1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema
		Me.store_info.Description = "store_info"
		Me.store_info.Name = "store_info"
		Me.store_info.Visible = False
		Me.approved_by.Description = "approved_by"
		Me.approved_by.Name = "approved_by"
		Me.approved_by.Visible = False
		Me.counted_by.Description = "counted_by"
		Me.counted_by.Name = "counted_by"
		Me.counted_by.Visible = False
		Me.received_by.Description = "received_by"
		Me.received_by.Name = "received_by"
		Me.received_by.Visible = False
		Me.prepared_by.Description = "prepared_by"
		Me.prepared_by.Name = "prepared_by"
		Me.prepared_by.ValueInfo = "0"
		Me.prepared_by.Visible = False
		Me.driver.Description = "driver"
		Me.driver.Name = "driver"
		Me.driver.ValueInfo = "0"
		Me.driver.Visible = False
		Me.released_by.Description = "released_by"
		Me.released_by.Name = "released_by"
		Me.released_by.Visible = False
		Me.XrTableCell27.BackColor = Color.Black
		Me.XrTableCell27.Borders = BorderSide.None
		Me.XrTableCell27.Font = New System.Drawing.Font("Arial", 9.75!, FontStyle.Bold)
		Me.XrTableCell27.ForeColor = Color.White
		Me.XrTableCell27.Multiline = True
		Me.XrTableCell27.Name = "XrTableCell27"
		Me.XrTableCell27.StylePriority.UseBackColor = False
		Me.XrTableCell27.StylePriority.UseBorders = False
		Me.XrTableCell27.StylePriority.UseFont = False
		Me.XrTableCell27.StylePriority.UseForeColor = False
		Me.XrTableCell27.StylePriority.UseTextAlignment = False
		Me.XrTableCell27.Text = "Box Qty"
		Me.XrTableCell27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
		Me.XrTableCell27.Weight = 0.69843215546451
		Me.XrTableCell28.ExpressionBindings.AddRange(New ExpressionBinding() {New ExpressionBinding("BeforePrint", "Text", "[total_box]")})
		Me.XrTableCell28.Multiline = True
		Me.XrTableCell28.Name = "XrTableCell28"
		Me.XrTableCell28.Padding = New PaddingInfo(2, 2, 0, 0, 100.0!)
		Me.XrTableCell28.StylePriority.UseTextAlignment = False
		Me.XrTableCell28.Text = "XrTableCell28"
		Me.XrTableCell28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
		Me.XrTableCell28.Weight = 130.956037741794
		Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.TopMargin, Me.BottomMargin, Me.Detail, Me.ReportHeader, Me.PageHeader, Me.ReportFooter})
		Me.CalculatedFields.AddRange(New CalculatedField() {Me.sub_total})
		Me.ComponentStorage.AddRange(New IComponent() {Me.PrintData1})
		Me.DataMember = "transferred_units"
		Me.DataSource = Me.PrintData1
		Me.Font = New System.Drawing.Font("Arial", 9.75!)
		Me.Margins = New System.Drawing.Printing.Margins(50, 41, 50, 50)
		Me.Parameters.AddRange(New Parameter() {Me.transfer_id, Me.transfer_date, Me.transfer_from, Me.transfer_to, Me.transfer_by, Me.store_info, Me.approved_by, Me.counted_by, Me.received_by, Me.prepared_by, Me.driver, Me.released_by})
		Me.RequestParameters = False
		Me.Version = "21.1"
		Me.Watermark.Font = New System.Drawing.Font("Times New Roman", 150.0!, FontStyle.Bold, GraphicsUnit.Point, 0)
		Me.Watermark.ForeColor = Color.WhiteSmoke
		Me.Watermark.TextTransparency = 20
		DirectCast(Me.XrTable3, ISupportInitialize).EndInit()
		DirectCast(Me.XrTable1, ISupportInitialize).EndInit()
		DirectCast(Me.XrTable2, ISupportInitialize).EndInit()
		DirectCast(Me.PrintData1, ISupportInitialize).EndInit()
		DirectCast(Me, ISupportInitialize).EndInit()

	End Sub

	Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
	Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
	Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
	Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
	Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
	Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
	Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
	Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
	Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
	Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
	Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
	Friend WithEvents XrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
	Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
	Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
	Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
	Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
	Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
	Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
	Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
	Friend WithEvents sub_total As DevExpress.XtraReports.UI.CalculatedField
	Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
	Friend WithEvents transfer_id As DevExpress.XtraReports.Parameters.Parameter
	Friend WithEvents transfer_date As DevExpress.XtraReports.Parameters.Parameter
	Friend WithEvents transfer_from As DevExpress.XtraReports.Parameters.Parameter
	Friend WithEvents transfer_to As DevExpress.XtraReports.Parameters.Parameter
	Friend WithEvents transfer_by As DevExpress.XtraReports.Parameters.Parameter
	Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
	Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
	Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
	Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
	Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
	Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
	Friend WithEvents PrintData1 As PrintData
	Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
	Friend WithEvents store_info As DevExpress.XtraReports.Parameters.Parameter
	Friend WithEvents approved_by As DevExpress.XtraReports.Parameters.Parameter
	Friend WithEvents XrLabel20 As DevExpress.XtraReports.UI.XRLabel
	Friend WithEvents XrLine5 As DevExpress.XtraReports.UI.XRLine
	Friend WithEvents counted_by As DevExpress.XtraReports.Parameters.Parameter
	Friend WithEvents XrLabel23 As DevExpress.XtraReports.UI.XRLabel
	Friend WithEvents received_by As DevExpress.XtraReports.Parameters.Parameter
	Friend WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
	Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
	Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
	Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
	Friend WithEvents XrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
	Friend WithEvents XrTableRow4 As DevExpress.XtraReports.UI.XRTableRow
	Friend WithEvents XrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
	Friend WithEvents XrTableCell11 As DevExpress.XtraReports.UI.XRTableCell
	Friend WithEvents XrTableCell12 As DevExpress.XtraReports.UI.XRTableCell
	Friend WithEvents XrTableRow6 As DevExpress.XtraReports.UI.XRTableRow
	Friend WithEvents XrTableCell16 As DevExpress.XtraReports.UI.XRTableCell
	Friend WithEvents XrTableCell17 As DevExpress.XtraReports.UI.XRTableCell
	Friend WithEvents XrTableCell18 As DevExpress.XtraReports.UI.XRTableCell
	Friend WithEvents XrTableRow5 As DevExpress.XtraReports.UI.XRTableRow
	Friend WithEvents XrTableCell13 As DevExpress.XtraReports.UI.XRTableCell
	Friend WithEvents XrTableCell14 As DevExpress.XtraReports.UI.XRTableCell
	Friend WithEvents XrTableCell15 As DevExpress.XtraReports.UI.XRTableCell
	Friend WithEvents XrTableRow3 As DevExpress.XtraReports.UI.XRTableRow
	Friend WithEvents XrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
	Friend WithEvents XrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
	Friend WithEvents XrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
	Friend WithEvents XrTableRow7 As DevExpress.XtraReports.UI.XRTableRow
	Friend WithEvents XrTableCell19 As DevExpress.XtraReports.UI.XRTableCell
	Friend WithEvents XrTableCell20 As DevExpress.XtraReports.UI.XRTableCell
	Friend WithEvents XrTableCell21 As DevExpress.XtraReports.UI.XRTableCell
	Friend WithEvents prepared_by As DevExpress.XtraReports.Parameters.Parameter
	Friend WithEvents driver As DevExpress.XtraReports.Parameters.Parameter
	Friend WithEvents released_by As DevExpress.XtraReports.Parameters.Parameter
	Friend WithEvents XrTable3 As XRTable
	Friend WithEvents XrTableRow8 As XRTableRow
	Friend WithEvents XrTableCell23 As XRTableCell
	Friend WithEvents XrTableCell24 As XRTableCell
	Friend WithEvents XrTableCell25 As XRTableCell
	Friend WithEvents XrTableCell26 As XRTableCell
	Friend WithEvents XrTableCell22 As XRTableCell
	Friend WithEvents XrTableCell27 As XRTableCell
	Friend WithEvents XrTableCell28 As XRTableCell
End Class
