Imports System.IO
Imports MySql.Data.MySqlClient

Public Class frm_product_import

    ReadOnly conn As New MySqlConnection(str)
    Dim rows_count = Nothing
    Private Property one_percent = 0
    Private Property counter = 0
    Private Property uploading = False
    Private Property error_lines = ""



    '--- ON LOAD -----
    Private Sub frm_import_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_status.Text = ""
        ProgressBar.Value = 0
    End Sub




    '--- Controls -----


    'btn_select
    Private Sub btn_select_Click(sender As Object, e As EventArgs) Handles btn_choose.Click

        Dim fd = New OpenFileDialog()

        fd.Title = "Open File Dialog"
        fd.Filter = "CSV file (*.csv)|*.csv"
        fd.RestoreDirectory = True
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            txt_path.Text = fd.FileName
        End If

    End Sub

    'btn_import
    Private Sub btn_upload_Click(sender As Object, e As EventArgs) Handles btn_upload.Click

        If Not String.IsNullOrWhiteSpace(txt_path.Text) Then
            Dim ans = MsgBox("Click 'Yes' to continue.", vbQuestion + vbYesNo, "Confirmation")

            If ans = vbYes Then

                Try
                    'Stream Data from CSV
                    Dim csvData As String = File.ReadAllText(txt_path.Text)
                    rows_count = csvData.Split(ControlChars.Lf)
                Catch ex As Exception
                    MsgBox(ex.Message, vbCritical, "Error")
                    Exit Sub
                End Try

                uploading = True
                ProgressBar.Maximum = rows_count.Length - 1
                txt_status.Text = ""
                error_lines = ""
                btn_upload.Enabled = False

                BackgroundWorker.RunWorkerAsync()

            End If
        End If

    End Sub

    'Do Work
    Private Sub BackgroundWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker.DoWork

        Dim path = ""
        If txt_path.InvokeRequired Then
            txt_path.Invoke(
                    Sub()
                        path = txt_path.Text
                    End Sub)
        Else
            path = txt_path.Text
        End If

        Try

            'Open Connection
            conn.Open()

            'Insert Command
            Dim query = "INSERT INTO ims_inventory (pid, barcode, winmodel, supmodel, description, technical_description, main_category, sub_category, brand, type, tags, base_price, cost, discount, regular_price, dealer_price, vip_price, length, width, height, weight, hazards, status, supplier, serialized, qty_per_box, ideal_stock, warning_stock, stock_duration, warranty_period, warranty_coverage, date_entry) 
                        VALUES (@pid, @barcode, @winmodel, @supmodel, @description, @technical_description, @main_category, @sub_category, @brand, @type, @tags, @base_price, @cost, @discount, @regular_price, @dealer_price, @vip_price, @length, @width, @height, @weight, @hazards, @status, @supplier, @serialized, @qty_per_box, @ideal_stock, @warning_stock, @stock_duration, @warranty_period, @warranty_coverage, @date_entry)
                        ON DUPLICATE KEY UPDATE barcode=@barcode, winmodel=@winmodel, supmodel=@supmodel, description=@description, technical_description=@technical_description, main_category=@main_category, sub_category=@sub_category, brand=@brand, type=@type, tags=@tags, base_price=@base_price, cost=@cost, discount=@discount, regular_price=@regular_price, dealer_price=@dealer_price, vip_price=@vip_price,
                        length=@length, width=@width, height=@height, weight=@weight, hazards=@hazards, status=@status, supplier=@supplier, serialized=@serialized, qty_per_box=@qty_per_box, ideal_stock=@ideal_stock, warning_stock=@warning_stock, stock_duration=@stock_duration, warranty_period=@warranty_period, warranty_coverage=@warranty_coverage, date_entry=@date_entry"

            Dim insert_cmd As New MySqlCommand(query, conn)

            insert_cmd.Parameters.AddWithValue("@pid", "")
            insert_cmd.Parameters.AddWithValue("@barcode", "")
            insert_cmd.Parameters.AddWithValue("@winmodel", "model")
            insert_cmd.Parameters.AddWithValue("@supmodel", "supmodel")
            insert_cmd.Parameters.AddWithValue("@supplier", "")
            insert_cmd.Parameters.AddWithValue("@description", "")
            insert_cmd.Parameters.AddWithValue("@technical_description", String.Empty)
            insert_cmd.Parameters.AddWithValue("@main_category", "")
            insert_cmd.Parameters.AddWithValue("@sub_category", "")
            insert_cmd.Parameters.AddWithValue("@brand", "")
            insert_cmd.Parameters.AddWithValue("@type", "")
            insert_cmd.Parameters.AddWithValue("@tags", "")
            insert_cmd.Parameters.AddWithValue("@status", "Inactive")
            insert_cmd.Parameters.AddWithValue("@base_price", "")
            insert_cmd.Parameters.AddWithValue("@cost", "")
            insert_cmd.Parameters.AddWithValue("@discount", DBNull.Value)
            insert_cmd.Parameters.AddWithValue("@regular_price", "")
            insert_cmd.Parameters.AddWithValue("@dealer_price", "")
            insert_cmd.Parameters.AddWithValue("@vip_price", "")
            insert_cmd.Parameters.AddWithValue("@length", DBNull.Value)
            insert_cmd.Parameters.AddWithValue("@width", DBNull.Value)
            insert_cmd.Parameters.AddWithValue("@height", DBNull.Value)
            insert_cmd.Parameters.AddWithValue("@weight", DBNull.Value)
            insert_cmd.Parameters.AddWithValue("@hazards", "")
            insert_cmd.Parameters.AddWithValue("@serialized", DBNull.Value)
            insert_cmd.Parameters.AddWithValue("@qty_per_box", Nothing)
            insert_cmd.Parameters.AddWithValue("@ideal_stock", DBNull.Value)
            insert_cmd.Parameters.AddWithValue("@warning_stock", DBNull.Value)
            insert_cmd.Parameters.AddWithValue("@stock_duration", DBNull.Value)
            insert_cmd.Parameters.AddWithValue("@warranty_period", DBNull.Value)
            insert_cmd.Parameters.AddWithValue("@warranty_coverage", DBNull.Value)
            insert_cmd.Parameters.AddWithValue("@date_entry", "")

            insert_cmd.Prepare()

            'Stream Data from CSV
            Dim csvData As String = File.ReadAllText(txt_path.Text)

            rows_count = csvData.Split(ControlChars.Lf)

            Dim i = 0
            Dim counts = 0

            'Processing
            For Each row As String In csvData.Split(ControlChars.Lf)

                If Not String.IsNullOrEmpty(row) Then
                    Dim values As String() = {}
                    values = row.Split(","c)

                    'Skip First Row (Header)
                    If counts = 0 Then
                        counts = 1
                        Continue For
                    End If

                    'Skip and Log Greater than 3 columns
                    'If values.Length > 5 Then
                    '    counts += 1
                    '    error_lines += "Line " & counts & vbCrLf
                    '    Continue For
                    'End If

                    'Skip If incomplete details
                    If String.IsNullOrWhiteSpace(values(0).ToString) _  'PID
                    Or String.IsNullOrWhiteSpace(values(2).ToString) _  'winmodel
                    Or String.IsNullOrWhiteSpace(values(3).ToString) _  'supmodel
                    Or String.IsNullOrWhiteSpace(values(4).ToString) _  'supid
                    Or String.IsNullOrWhiteSpace(values(5).ToString) _  'description
                    Or String.IsNullOrWhiteSpace(values(7).ToString) _  'main_category
                    Or String.IsNullOrWhiteSpace(values(8).ToString) _  'sub_category
                    Or String.IsNullOrWhiteSpace(values(9).ToString) _  'brand
                    Or String.IsNullOrWhiteSpace(values(12).ToString) _ 'status
                    Or String.IsNullOrWhiteSpace(values(13).ToString) _ 'base Price
                    Or String.IsNullOrWhiteSpace(values(14).ToString) _ 'cost
                    Or String.IsNullOrWhiteSpace(values(16).ToString) _ 'regular_price
                    Or String.IsNullOrWhiteSpace(values(17).ToString) _ 'dealer_price 
                    Or String.IsNullOrWhiteSpace(values(18).ToString) Then 'vip_price 
                        counts += 1
                        error_lines += "Line " & counts & vbCrLf
                        Continue For
                    End If

                    insert_cmd.Parameters(0).Value = values(0) 'PID
                    insert_cmd.Parameters(1).Value = values(1) 'Barcode
                    insert_cmd.Parameters(2).Value = values(2) 'WinModel
                    insert_cmd.Parameters(3).Value = values(3) 'SupModel
                    insert_cmd.Parameters(4).Value = values(4) 'Supplier ID
                    insert_cmd.Parameters(5).Value = values(5) 'Description
                    insert_cmd.Parameters(6).Value = values(6) 'Technical Description
                    insert_cmd.Parameters(7).Value = values(7) 'Main Category
                    insert_cmd.Parameters(8).Value = values(8) 'Sub Category
                    insert_cmd.Parameters(9).Value = values(9) 'Brand
                    insert_cmd.Parameters(10).Value = values(10) 'Type
                    insert_cmd.Parameters(11).Value = values(11) 'Tags
                    insert_cmd.Parameters(12).Value = values(12) 'Status
                    insert_cmd.Parameters(13).Value = values(13) 'Base Price    
                    insert_cmd.Parameters(14).Value = values(14) 'Cost
                    If Not String.IsNullOrWhiteSpace(values(15)) Then insert_cmd.Parameters(15).Value = values(15) 'Discount
                    insert_cmd.Parameters(16).Value = values(16) 'Regular Price
                    insert_cmd.Parameters(17).Value = values(17) 'Dealer Price
                    insert_cmd.Parameters(18).Value = values(18) 'VIP Price
                    If Not String.IsNullOrWhiteSpace(values(19)) Then insert_cmd.Parameters(19).Value = values(19) 'Length
                    If Not String.IsNullOrWhiteSpace(values(20)) Then insert_cmd.Parameters(20).Value = values(20) 'Width
                    If Not String.IsNullOrWhiteSpace(values(21)) Then insert_cmd.Parameters(21).Value = values(21) 'Height
                    If Not String.IsNullOrWhiteSpace(values(22)) Then insert_cmd.Parameters(22).Value = values(22) 'Weight
                    insert_cmd.Parameters(23).Value = values(23) 'Hazards
                    If Not String.IsNullOrWhiteSpace(values(24)) Then insert_cmd.Parameters(24).Value = values(24) 'Serialized
                    insert_cmd.Parameters(25).Value = values(25) 'Qty per Box
                    If Not String.IsNullOrWhiteSpace(values(26)) Then insert_cmd.Parameters(26).Value = values(26) 'Ideal Stock
                    If Not String.IsNullOrWhiteSpace(values(27)) Then insert_cmd.Parameters(27).Value = values(27) 'Warning Stock
                    If Not String.IsNullOrWhiteSpace(values(28)) Then insert_cmd.Parameters(28).Value = values(28) 'Stock Duration
                    If Not String.IsNullOrWhiteSpace(values(29)) Then insert_cmd.Parameters(29).Value = values(29) 'Warranty Period
                    insert_cmd.Parameters(30).Value = values(30) 'Warranty Coverage
                    insert_cmd.Parameters(31).Value = values(31) 'Entry Date

                    insert_cmd.ExecuteNonQuery()

                    'EMPTY THE PARAMETERS VALUES

                    For Each parameter As MySqlParameter In insert_cmd.Parameters
                        parameter.Value = Nothing
                    Next

                    counts += 1
                    BackgroundWorker.ReportProgress(counts)

                    If BackgroundWorker.CancellationPending = True Then
                            e.Cancel = True
                            Exit For
                        End If

                    End If
            Next

        Catch ex As Exception
            MsgBox("Failed to Upload." & vbCrLf & vbCrLf & ex.Message, vbCritical, "Error")
            Exit Sub
        Finally
            conn.Close()
        End Try

    End Sub

    'ProgressChanged
    Private Sub BackgroundWorker_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker.ProgressChanged

        txt_status.Text += "Processing row " & e.ProgressPercentage & " out of " & rows_count.Length - 1 & " rows" & vbCrLf
            txt_status.SelectionStart = txt_status.Text.Length
            txt_status.ScrollToCaret()
            ProgressBar.Value = e.ProgressPercentage

    End Sub

    'Background Completed
    Private Sub BackgroundWorker_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker.RunWorkerCompleted
        If e.Cancelled = True Then
            MsgBox("Operation has been cancelled!", vbInformation, "Operation")
            uploading = False

        ElseIf e.Error IsNot Nothing Then
            MsgBox(e.Error.Message, vbCritical, "Operation")
            uploading = False

        Else
            uploading = False

            If Not String.IsNullOrEmpty(error_lines) Then
                txt_status.AppendText(vbCrLf & "Lines didn't processed:" & vbCrLf & error_lines & vbCrLf & vbCrLf)
            End If


            MsgBox("Upload Complete!", vbInformation, "Success")
        End If

        btn_upload.Enabled = True

    End Sub

    'Form Closing
    Private Sub frm_import_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        If uploading = True Then
            Dim ans = MsgBox("Importing is still in progress. Proceed? " & vbCrLf & vbCrLf & "Proceed?", vbQuestion + vbYesNo, "Confirmation")

            If ans = vbYes Then
                If BackgroundWorker.WorkerSupportsCancellation = True Then
                    BackgroundWorker.CancelAsync()
                End If
                e.Cancel = False
            Else
                e.Cancel = True
            End If

        End If
    End Sub

    Private Sub btn_details_Click(sender As Object, e As EventArgs) Handles btn_details.Click

        Select Case btn_details.Text
            Case "Show Details"
                btn_details.Text = "Hide Details"
                Me.Height = 355
                txt_status.Visible = True
                btn_details.Top = 285
                btn_upload.Top = 285
            Case "Hide Details"
                btn_details.Text = "Show Details"
                Me.Height = 195
                txt_status.Visible = False
                btn_details.Top = 124
                btn_upload.Top = 124
        End Select
    End Sub

    'btn_download
    Private Sub btn_download_Click(sender As Object, e As EventArgs) Handles btn_download.Click

        Using sfd As New SaveFileDialog
            With sfd
                .AddExtension = True
                .DefaultExt = ".csv"
                .Filter = "Comma Separated File (*.csv)|*.csv"
                .FilterIndex = 1
                .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
                .Title = "Select The Location To Save This PDF File"
                .ValidateNames = True
            End With

            If sfd.ShowDialog = DialogResult.OK Then
                My.Computer.FileSystem.WriteAllText(sfd.FileName, My.Resources.Masterlist_Format, False)
            End If
        End Using

    End Sub

End Class