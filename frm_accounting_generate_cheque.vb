Imports System.Globalization
Imports DevExpress.XtraReports.UI
Imports MySql.Data.MySqlClient

Public Class frm_accounting_generate_cheque

    ReadOnly conn As New MySqlConnection(str)

    '--- ONLOAD ---
    Private Sub frm_accounting_payment_cheques_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_banks()
        load_suppliers()
        load_AutoSuggest()
    End Sub





    '--- FUNCTIONS ----

    'Load Banks List
    Private Sub load_banks()

        Try
            conn.Open()
            Dim cmd = New MySqlCommand("SELECT value FROM ims_settings WHERE name='banks'", conn)
            Dim result = cmd.ExecuteScalar.ToString.Split(New String() {Environment.NewLine}, StringSplitOptions.None)

            For i = 0 To result.Length - 1
                cbb_banks.Properties.Items.Add(result(i))
            Next

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            conn.Close()
        End Try

    End Sub

    'Load Supplier List
    Private Sub load_suppliers()

        Try
            conn.Open()
            Dim cmd = New MySqlCommand("SELECT supplier FROM ims_suppliers", conn)
            Dim rdr = cmd.ExecuteReader

            While rdr.Read
                cbb_suppliers.Properties.Items.Add(rdr("supplier"))
            End While

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            conn.Close()
        End Try

    End Sub

    'Load Auto Suggest
    Private Sub load_AutoSuggest()

        Dim Collection = New AutoCompleteStringCollection

        Try
            conn.Open()
            Dim cmd = New MySqlCommand("SELECT payee FROM `ims_generated_cheques` GROUP BY payee", conn)
            Dim rdr As MySqlDataReader = cmd.ExecuteReader

            While rdr.Read
                Collection.Add(rdr("payee"))
            End While

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            conn.Close()
        End Try

        txt_payee.MaskBox.AutoCompleteSource = AutoCompleteSource.CustomSource
        txt_payee.MaskBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        txt_payee.MaskBox.AutoCompleteCustomSource = Collection

    End Sub

    'Get Generated Cheque Count / Get Total Count
    Private Function get_cheque_count(connection As MySqlConnection)

        Dim cmd = New MySqlCommand("SELECT COUNT(*) FROM ims_generated_cheques", connection)
        Return cmd.ExecuteScalar

    End Function

    'Print Cheque
    Private Sub PrintCheque(id As Integer, connection As MySqlConnection)
        Dim report = New doc_cheque()
        Dim printTool = New ReportPrintTool(report)
        Dim amount As Decimal, dt As Date, payee As String = "", is_crossed_check As Boolean

        Dim cmd = New MySqlCommand("SELECT amount, payee, cheque_date, is_crossed_check FROM ims_generated_cheques WHERE id=@id", connection)
        cmd.Parameters.AddWithValue("@id", id)
        Dim rdr As MySqlDataReader = cmd.ExecuteReader

        While rdr.Read
            payee = rdr("payee")
            dt = rdr("cheque_date")
            amount = rdr("amount")
            is_crossed_check = rdr("is_crossed_check")
        End While

        report.Parameters("payee").Value = payee
        report.Parameters("cheque_date").Value = dt
        report.Parameters("amount").Value = amount
        report.Parameters("ac_payee").Value = is_crossed_check
        report.Parameters("AmountWords").Value = AmountInWords(amount)
        report.RequestParameters = False

        report.ShowRibbonPreviewDialog()

    End Sub

    'Amount In Words
    Public Function AmountInWords(ByVal nAmount As String, Optional ByVal wAmount _
                 As String = vbNullString, Optional ByVal nSet As Object = Nothing) As String
        'Let's make sure entered value is numeric
        If Not IsNumeric(nAmount) Then Return "Please enter numeric values only."

        Dim tempDecValue As String = String.Empty : If InStr(nAmount, ".") Then _
        tempDecValue = nAmount.Substring(nAmount.IndexOf("."))
        nAmount = Replace(nAmount, tempDecValue, String.Empty)

        Try
            Dim intAmount As Long = nAmount
            If intAmount > 0 Then
                nSet = IIf((intAmount.ToString.Trim.Length / 3) _
                > (CLng(intAmount.ToString.Trim.Length / 3)),
              CLng(intAmount.ToString.Trim.Length / 3) + 1,
                  CLng(intAmount.ToString.Trim.Length / 3))
                Dim eAmount As Long = Microsoft.VisualBasic.Left(intAmount.ToString.Trim,
              (intAmount.ToString.Trim.Length - ((nSet - 1) * 3)))
                Dim multiplier As Long = 10 ^ (((nSet - 1) * 3))

                Dim Ones() As String =
            {"", "One", "Two", "Three",
              "Four", "Five",
              "Six", "Seven", "Eight", "Nine"}
                Dim Teens() As String = {"",
            "Eleven", "Twelve", "Thirteen",
              "Fourteen", "Fifteen",
              "Sixteen", "Seventeen", "Eighteen", "Nineteen"}
                Dim Tens() As String = {"", "Ten",
            "Twenty", "Thirty",
              "Forty", "Fifty", "Sixty",
              "Seventy", "Eighty", "Ninety"}
                Dim HMBT() As String = {"", "",
            "Thousand", "Million",
              "Billion", "Trillion",
              "Quadrillion", "Quintillion"}

                intAmount = eAmount

                Dim nHundred As Integer = intAmount \ 100 : intAmount = intAmount Mod 100
                Dim nTen As Integer = intAmount \ 10 : intAmount = intAmount Mod 10
                Dim nOne As Integer = intAmount \ 1

                If nHundred > 0 Then wAmount = wAmount &
            Ones(nHundred) & " Hundred " 'This is for hundreds                
                If nTen > 0 Then 'This is for tens and teens
                    If nTen = 1 And nOne > 0 Then 'This is for teens 
                        wAmount = wAmount & Teens(nOne) & " "
                    Else 'This is for tens, 10 to 90
                        wAmount = wAmount & Tens(nTen) & IIf(nOne > 0, " ", " ")
                        If nOne > 0 Then wAmount = wAmount & Ones(nOne) & " "
                    End If
                Else 'This is for ones, 1 to 9
                    If nOne > 0 Then wAmount = wAmount & Ones(nOne) & " "
                End If
                wAmount = wAmount & HMBT(nSet) & " "
                wAmount = AmountInWords(CStr(CLng(nAmount) -
              (eAmount * multiplier)).Trim & tempDecValue, wAmount, nSet - 1)
            Else
                If Val(nAmount) = 0 Then nAmount = nAmount &
            tempDecValue : tempDecValue = String.Empty
                If (Math.Round(Val(nAmount), 2) * 100) > 0 Then wAmount =
              Trim(AmountInWords(CStr(Math.Round(Val(nAmount), 2) * 100),
              wAmount.Trim & " Pesos And ", 1)) & " Cents"
            End If

        Catch ex As Exception
            MessageBox.Show("Error Encountered: " & ex.Message, "Convert Numbers To Words", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return "!#ERROR_ENCOUNTERED"
        End Try

        'Trap null values
        If IsNothing(wAmount) = True Then wAmount = String.Empty Else wAmount =
        IIf(InStr(wAmount.Trim.ToLower, "pesos"), wAmount.Trim, wAmount.Trim & " Pesos Only")

        'Display the result
        Return wAmount
    End Function




    '--- CONTROLS ----

    'cbb_suppliers SELECTION CHANGED
    Private Sub cbb_suppliers_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbb_suppliers.Properties.SelectedValueChanged

        If Not String.IsNullOrWhiteSpace(cbb_suppliers.Text) Then
            Try
                conn.Open()

                'GET Payables
                Using cmd = New MySqlCommand("SELECT payable_id, receipt_type, receipt_ref, amount, received_date, CONCAT('PO',LPAD(ims_delivery_receipts.purchase_id, 5, 0)) as purchase_id,
                                ims_purchase.terms, DATE_ADD(received_date, INTERVAL ims_purchase.terms DAY) as due_date FROM `ims_delivery_receipts` 
                                INNER JOIN ims_purchase ON ims_purchase.purchase_id=ims_delivery_receipts.purchase_id
                                WHERE supplier_id=(SELECT id FROM ims_suppliers WHERE supplier=@supplier AND ims_delivery_receipts.status='UNPAID')", conn)
                    cmd.Parameters.AddWithValue("@supplier", cbb_suppliers.Text)
                    cmd.ExecuteNonQuery()

                    Dim dt = New DataTable
                    Dim da = New MySqlDataAdapter(cmd)
                    da.Fill(dt)

                    grid_receipts.DataSource = dt
                End Using

                'GET BANK DETAILS
                Using cmd_get = New MySqlCommand("SELECT acc_name, acc_no FROM ims_suppliers WHERE supplier=@supname", conn)
                    cmd_get.Parameters.AddWithValue("@supname", cbb_suppliers.Text)
                    Using rdr As MySqlDataReader = cmd_get.ExecuteReader
                        While rdr.Read
                            txt_payee.Text = cbb_suppliers.Text
                            txt_acc_name.Text = If(Not IsDBNull(rdr("acc_name")), rdr("acc_name"), "")
                            txt_acc_no.Text = If(Not IsDBNull(rdr("acc_no")), rdr("acc_no"), "")
                        End While
                    End Using
                End Using

                'GET PURCHASE RETURNS
                Using cmd_returns = New MySqlCommand("SELECT po_return_id, supplier, batch_no,
                                total_cost, created_at, status FROM ims_purchase_returns 
                                LEFT JOIN ims_suppliers ON ims_suppliers.id=ims_purchase_returns.supplier_id 
                                WHERE is_deleted=0 AND supplier=@supplier AND is_applied='0'
                                ORDER BY po_return_id DESC", conn)
                    cmd_returns.Parameters.AddWithValue("@supplier", cbb_suppliers.Text)
                    cmd_returns.ExecuteNonQuery()
                    Dim dt = New DataTable
                    Dim da = New MySqlDataAdapter(cmd_returns)
                    da.Fill(dt)
                    grid_returns.DataSource = dt
                End Using

            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            Finally
                conn.Close()
            End Try

        End If

    End Sub

    'grid_receipts_view_SelectionChanged
    Private Sub grid_receipts_view_SelectionChanged(sender As Object, e As DevExpress.Data.SelectionChangedEventArgs) Handles grid_receipts_view.SelectionChanged

        Dim SelectedRows = grid_receipts_view.GetSelectedRows

        If Not SelectedRows.Length = 0 Then

            Dim total As Decimal = 0.00
            Dim total_sum As Decimal = 0.00

            With grid_receipts_view
                For i = 0 To SelectedRows.Length - 1

                    If Not Month(.GetRowCellValue(SelectedRows(0), col_due_date)) = Month(.GetRowCellValue(SelectedRows(i), col_due_date)) Then
                        MsgBox("Warning! Month of due should Equal.", vbExclamation, "Not Equal")
                        'txt_cheque_date.Text = ""
                        'txt_total_view.Text = ""
                        'Exit Sub
                    End If

                    Dim due_date As Date = .GetRowCellValue(SelectedRows(i), col_due_date)
                    Dim amount As Decimal = .GetRowCellValue(SelectedRows(i), col_amount)

                    total_sum += CInt(due_date.ToString("dd")) * amount


                    total += .GetRowCellValue(SelectedRows(i), col_amount)
                Next

                txt_total_view.Text = FormatCurrency(total)
                Dim product_sum = total_sum / total

                Dim ddate As Date = .GetFocusedRowCellValue(col_due_date)
                txt_cheque_date.Text = ddate.ToString("MM") & "/" & Math.Round(product_sum).ToString.PadLeft(2, "0"c) & "/" & ddate.ToString("yyyy")

            End With

        End If
    End Sub

    'btn_generate
    Private Sub btn_generate_Click(sender As Object, e As EventArgs) Handles btn_generate.Click

        Dim receipts = ""
        Dim SelectedRows = grid_receipts_view.GetSelectedRows

        If SelectedRows.Length = 0 Then
            MsgBox("Select Receipts First!", vbCritical, "Required")
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(txt_cheque_no.Text) Or String.IsNullOrWhiteSpace(txt_cheque_date.Text) Or String.IsNullOrWhiteSpace(cbb_banks.Text) Then
            MsgBox("Fill up all required fields!", vbCritical, "Required")
            Exit Sub
        End If

        Dim ans = MsgBox("Generate Cheque? Press 'YES' to proceed.", vbQuestion + vbYesNo, "Confirmation")

        If ans = vbYes Then

            'Get ID of receipts
            For i = 0 To SelectedRows.Length - 1
                'If last
                If i = SelectedRows.Length - 1 Then
                    receipts += grid_receipts_view.GetRowCellValue(SelectedRows(i), col_id).ToString
                    Continue For
                End If
                receipts += grid_receipts_view.GetRowCellValue(SelectedRows(i), col_id) & ", "
            Next


            Try
                conn.Open()

                'GENERATE CHEQUE
                Dim cmd = New MySqlCommand("INSERT INTO ims_generated_cheques (cheque_no, cheque_date, bank, payee, acc_no, acc_name, amount, receipts, supplier, status, is_crossed_check)
                                VALUES (@cheque_no, @cheque_date, @bank, @payee, @acc_no, @acc_name, @amount, @receipts, (SELECT id FROM ims_suppliers WHERE supplier=@supplier), @status, @x_check)", conn)
                cmd.Parameters.AddWithValue("cheque_no", txt_cheque_no.Text.Trim)
                cmd.Parameters.AddWithValue("cheque_date", Date.ParseExact(txt_cheque_date.Text.Trim, "MM/dd/yyyy", CultureInfo.InvariantCulture))
                cmd.Parameters.AddWithValue("bank", cbb_banks.Text.Trim)
                cmd.Parameters.AddWithValue("payee", txt_payee.Text.Trim)
                cmd.Parameters.AddWithValue("acc_no", txt_acc_no.Text.Trim)
                cmd.Parameters.AddWithValue("acc_name", txt_acc_name.Text.Trim)
                cmd.Parameters.AddWithValue("amount", CDec(txt_total_view.Text.Trim))
                cmd.Parameters.AddWithValue("supplier", cbb_suppliers.Text.Trim)
                cmd.Parameters.AddWithValue("receipts", receipts)
                cmd.Parameters.AddWithValue("status", "OUTSTANDING")
                cmd.Parameters.AddWithValue("x_check", cb_crossed_check.Checked)
                cmd.ExecuteNonQuery()

                'GET CHEQUE COUNT
                Dim cheque_id = get_cheque_count(conn)

                'UPDATE RECEIPTS
                Using update_cmd = New MySqlCommand("UPDATE ims_delivery_receipts SET status='ISSUED', cheque_id=@cheque_id, payment_cheque=@payment_cheque, payment_dates=@payment_date WHERE payable_id=@id", conn)
                    update_cmd.Parameters.AddWithValue("@id", 0)
                    update_cmd.Parameters.AddWithValue("@cheque_id", cheque_id)
                    update_cmd.Parameters.AddWithValue("@payment_cheque", txt_cheque_no.Text.Trim)
                    update_cmd.Parameters.AddWithValue("@payment_date", Date.ParseExact(txt_cheque_date.Text.Trim, "MM/dd/yyyy", CultureInfo.InvariantCulture))
                    update_cmd.Prepare()

                    For i = 0 To SelectedRows.Length - 1
                        update_cmd.Parameters(0).Value = grid_receipts_view.GetRowCellValue(SelectedRows(i), col_id)
                        update_cmd.ExecuteNonQuery()
                    Next
                End Using

                'UPDATE PURCHASE ORDER RETURNS
                Using update_returns = New MySqlCommand("UPDATE ims_purchase_returns SET is_applied='1', status='Applied', cheque_no=@cheque WHERE po_return_id=@id", conn)
                    update_returns.Parameters.AddWithValue("@id", 0)
                    update_returns.Parameters.AddWithValue("@cheque", txt_cheque_no.Text)
                    update_returns.Prepare()

                    For i = 0 To grid_returns_view.GetSelectedRows.Length - 1
                        update_returns.Parameters(0).Value = grid_returns_view.GetRowCellValue(grid_returns_view.GetSelectedRows(i), col_rid)
                        update_returns.ExecuteNonQuery()
                    Next
                End Using

                'PRINT CHEQUE
                Dim ans2 = MsgBox("Successfully Generated!" & vbCrLf & vbCrLf & "Print on Cheque?", vbInformation + vbYesNo, "Print")
                If ans2 = vbYes Then
                    PrintCheque(cheque_id, conn)
                End If

                'CLEAR FIELDS
                txt_cheque_no.Text = ""
                txt_cheque_date.Text = ""
                cbb_banks.Text = ""
                txt_payee.Text = ""
                txt_acc_no.Text = ""
                txt_acc_name.Text = ""
                cbb_suppliers.Text = ""
                txt_total_view.Text = ""
                grid_receipts.DataSource = Nothing
                grid_returns.DataSource = Nothing

            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            Finally
                conn.Close()
            End Try

        End If

    End Sub

    'DateEdit
    Private Sub DateEdit1_Closed(sender As Object, e As DevExpress.XtraEditors.Controls.ClosedEventArgs) Handles DateEdit1.Closed
        txt_cheque_date.Text = Date.ParseExact(DateEdit1.EditValue, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("MM/dd/yyyy")
    End Sub

    'Purchase Returns Selection
    Private Sub grid_returns_view_SelectionChanged(sender As Object, e As DevExpress.Data.SelectionChangedEventArgs) Handles grid_returns_view.SelectionChanged

        Dim total_payables As Decimal = 0.00
        Dim total_returns As Decimal = 0.00

        'GET TOTAL PAYABLES
        Dim payables_rows = grid_receipts_view.GetSelectedRows
        For i = 0 To payables_rows.Length - 1
            total_payables += grid_receipts_view.GetRowCellValue(payables_rows(i), col_amount)
        Next
        'GET TOTAL RETURNS
        Dim returns_row = grid_returns_view.GetSelectedRows
        For i = 0 To returns_row.Length - 1
            total_returns += grid_returns_view.GetRowCellValue(returns_row(i), col_total_cost)
        Next

        'DISPLAY
        txt_total_view.Text = FormatCurrency(total_payables - total_returns, 2)

    End Sub

End Class