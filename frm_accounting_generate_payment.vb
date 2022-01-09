Imports System.Globalization
Imports DevExpress.XtraReports.UI
Imports MySql.Data.MySqlClient

Public Class frm_accounting_generate_payment

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
    Private Function get_payment_id(connection As MySqlConnection, payment_type As String)
        Dim query = String.Empty

        If payment_type = "cheque" Then
            query = "SELECT COUNT(*) FROM ims_generated_cheques"
        ElseIf payment_type = "cash" Then
            query = "SELECT COUNT(*) FROM ims_generated_cash"
        End If

        Return New MySqlCommand(query, connection).ExecuteScalar

    End Function

    'Get Count of Payment Vouchers
    Private Function get_count(connection As MySqlConnection)

        Dim get_cmd = New MySqlCommand("SELECT COUNT(*) FROM ims_payment_vouchers", connection)
        Return get_cmd.ExecuteScalar

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

    'Print Voucher
    Private Sub print_voucher(id As Integer, connection As MySqlConnection)
        Dim report = New doc_payment_voucher()
        Dim printTool = New ReportPrintTool(report)
        Dim table = New PrintData

        Dim supplier = "", collection_ref = "", generated_by = "", voucher_date = New Date, receipts() As String = {}, store_name = "", store_info = "", payment_type = String.Empty, contact_person = String.Empty

        Try
            'GET VOUCHER DETAILS
            Dim query = "SELECT payment_type, receipts, collection_ref, creation_date, receipts, ims_users.first_name, ims_suppliers.supplier, ims_suppliers.contact_person,
                        (SELECT VALUE FROM ims_settings WHERE NAME='store_name') AS store_name, (SELECT value FROM ims_settings WHERE name='store_info') as store_info 
                        FROM ims_payment_vouchers
                        INNER JOIN ims_suppliers ON ims_suppliers.id=ims_payment_vouchers.supplier
                        INNER JOIN ims_users ON ims_users.usr_id=ims_payment_vouchers.generated_by
                        WHERE payment_id=@payment_id"
            Using cmd = New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@payment_id", id)
                Using rdr_details = cmd.ExecuteReader
                    While rdr_details.Read
                        store_name = rdr_details("store_name")
                        contact_person = rdr_details("contact_person")
                        payment_type = rdr_details("payment_type")
                        voucher_date = rdr_details("creation_date")
                        collection_ref = rdr_details("collection_ref")
                        supplier = rdr_details("supplier")
                        collection_ref = rdr_details("collection_ref")
                        generated_by = rdr_details("first_name")
                        store_info = rdr_details("store_info")

                        receipts = rdr_details("receipts").ToString.Split(",")

                    End While
                End Using
            End Using


            'GET RECEIPTS DATA
            Using get_receipt = New MySqlCommand("SELECT CONCAT('PO', LPAD(ims_delivery_receipts.purchase_id, 5, 0)) as purchase_id, receipt_type, receipt_ref, received_date, ims_purchase.terms,
                                    payment_cheque, payment_dates, ims_delivery_receipts.amount, ims_generated_cheques.bank,
                                    DATE_ADD(received_date, INTERVAL ims_purchase.terms DAY) as due_date FROM ims_delivery_receipts 
                                    INNER JOIN ims_purchase ON ims_purchase.purchase_id=ims_delivery_receipts.purchase_id
                                    LEFT JOIN ims_generated_cheques ON ims_generated_cheques.id=ims_delivery_receipts.cheque_id 
                                    WHERE payment_ref=@ref ORDER BY receipt_ref ASC", connection)
                get_receipt.Parameters.AddWithValue("@ref", id)
                Using reader = get_receipt.ExecuteReader
                    While reader.Read
                        table.payment_voucher.Rows.Add(reader("purchase_id"),
                                                   reader("received_date"),
                                                   reader("terms"),
                                                   reader("payment_cheque"),
                                                   reader("payment_dates"),
                                                   reader("amount"),
                                                   reader("bank"),
                                                   reader("due_date"),
                                                   reader("receipt_type"),
                                                   reader("receipt_ref"))
                    End While
                End Using
            End Using

            Dim cheque_no As String = "0"

            Select Case payment_type
                Case "cheque"
                    'Get Cheque Total No. and Details
                    Using get_cheque = New MySqlCommand("SELECT bank, cheque_no, cheque_date, ims_generated_cheques.amount FROM ims_generated_cheques 
                            INNER JOIN ims_delivery_receipts ON ims_delivery_receipts.payment_cheque=cheque_no
                            WHERE payment_ref=@ref GROUP BY cheque_no, bank, ims_generated_cheques.amount, cheque_date", connection)
                        get_cheque.Parameters.AddWithValue("@ref", id)
                        Using rdr_cheque = get_cheque.ExecuteReader
                            While rdr_cheque.Read
                                table.payment_voucher_cheque.Rows.Add(rdr_cheque("bank"), rdr_cheque("cheque_date"), rdr_cheque("cheque_no"), rdr_cheque("amount"))
                                cheque_no = rdr_cheque("cheque_no")
                            End While
                        End Using
                    End Using

                Case "cash"
                    'Get Cash Details
                    Using get_cheque = New MySqlCommand("SELECT ims_generated_cash.id, ims_generated_cash.payment_date, ims_generated_cash.amount 
                                            FROM ims_delivery_receipts  
                                            INNER JOIN ims_generated_cash ON ims_generated_cash.id=cash_id
                                            WHERE payable_id=@pid GROUP BY id", connection)
                        get_cheque.Parameters.AddWithValue("@pid", receipts(0))
                        Using rdr_cheque = get_cheque.ExecuteReader
                            While rdr_cheque.Read
                                table.payment_voucher_cheque.Rows.Add(rdr_cheque("id"), rdr_cheque("payment_date"), Nothing, rdr_cheque("amount"))
                            End While
                        End Using
                        'get_cheque.Prepare()

                        'For i = 0 To receipts.Length - 1
                        '    get_cheque.Parameters(0).Value = receipts(i)
                        '    Using rdr_cheque = get_cheque.ExecuteReader
                        '        While rdr_cheque.Read
                        '            table.payment_voucher_cheque.Rows.Add(rdr_cheque("id"), rdr_cheque("payment_date"), Nothing, rdr_cheque("amount"))
                        '        End While
                        '    End Using
                        'Next
                    End Using

            End Select


            'GET PURCHASE RETURNS
            Using get_returns = New MySqlCommand("SELECT po_return_id, ims_suppliers.supplier, total_cost FROM ims_purchase_returns 
                                LEFT JOIN ims_suppliers ON ims_suppliers.id=ims_purchase_returns.supplier_id
                                WHERE cheque_no=" & cheque_no, connection)
                Using reader = get_returns.ExecuteReader
                    While reader.Read
                        table.purchase_returns.Rows.Add(reader("po_return_id"), reader("supplier"), reader("total_cost"))
                    End While
                End Using
            End Using

            report.Parameters("store_name").Value = store_name
            report.Parameters("store_info").Value = store_info
            report.Parameters("voucher_id").Value = "PV" & id.ToString.PadLeft(5, "0"c)
            report.Parameters("voucher_date").Value = voucher_date
            report.Parameters("supplier").Value = supplier
            report.Parameters("collection_ref").Value = collection_ref
            report.Parameters("generated_by").Value = generated_by
            report.Parameters("payment_type").Value = payment_type
            report.Parameters("contact_person").Value = contact_person
            report.RequestParameters = False


            report.DataSource = table
            report.ShowRibbonPreviewDialog()

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
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

    'Generate Cheque Payment
    Private Sub GenerateCheque()

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

        Dim ans = MsgBox("Press 'YES' to proceed.", vbQuestion + vbYesNo, "Confirmation")

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
                Using cmd = New MySqlCommand("INSERT INTO ims_generated_cheques (cheque_no, cheque_date, bank, payee, acc_no, acc_name, amount, receipts, supplier, status, is_crossed_check)
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
                End Using

                'GENERATE NEW VOUCHER | //MERGE
                Using cmd = New MySqlCommand("INSERT INTO ims_payment_vouchers (payment_type, receipts, creation_date, collection_ref, supplier, generated_by)
                                VALUES (@payment_type, @receipts, CURRENT_TIMESTAMP, @collection_ref, (SELECT id FROM ims_suppliers WHERE supplier=@supplier), @generated_by)", conn)
                    cmd.Parameters.AddWithValue("receipts", receipts)
                    cmd.Parameters.AddWithValue("payment_type", "cheque")
                    cmd.Parameters.AddWithValue("collection_ref", txt_collection_ref.Text.Trim)
                    cmd.Parameters.AddWithValue("supplier", cbb_suppliers.Text.Trim)
                    cmd.Parameters.AddWithValue("generated_by", frm_main.user_id.Text)
                    cmd.ExecuteNonQuery()
                End Using

                'GET LAST VOUCHER ID
                Dim voucher_id = get_count(conn)

                'GET CHEQUE COUNT
                Dim cheque_id = get_payment_id(conn, "cheque")

                'UPDATE RECEIPTS
                Using update_cmd = New MySqlCommand("UPDATE ims_delivery_receipts SET 
                                                            status='PAID',  
                                                            cheque_id=@cheque_id,  
                                                            payment_ref=@payment_ref,
                                                            payment_type='cheque',  
                                                            payment_cheque=@payment_cheque,  
                                                            payment_dates=@payment_date 
                                                    WHERE payable_id=@id", conn)
                    update_cmd.Parameters.AddWithValue("@id", 0)
                    update_cmd.Parameters.AddWithValue("@cheque_id", cheque_id)
                    update_cmd.Parameters.AddWithValue("@payment_ref", voucher_id)
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
                If MsgBox("Print Cheque?", vbInformation + vbYesNo, "Print") = vbYes Then
                    PrintCheque(cheque_id, conn)
                End If

                'PRINT VOUCHER
                If MsgBox("Print Payment Voucher?", vbInformation + vbYesNo, "Print") = vbYes Then
                    print_voucher(voucher_id, conn)
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
                txt_collection_ref.Text = ""
                grid_receipts.DataSource = Nothing
                grid_returns.DataSource = Nothing

            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            Finally
                conn.Close()
            End Try

        End If

    End Sub

    'Generate Cash Payment
    Private Sub GenerateCash()

        Dim receipts = ""
        Dim SelectedRows = grid_receipts_view.GetSelectedRows

        If SelectedRows.Length = 0 Then
            MsgBox("Select Receipts First!", vbCritical, "Required")
            Exit Sub
        End If

        If MsgBox("Generate Cash Payment? Press 'YES' to proceed.", vbQuestion + vbYesNo, "Confirmation") = vbYes Then

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

                'GENERATE CASH
                Using cmd = New MySqlCommand("INSERT INTO ims_generated_cash (payee, payment_date, amount)
                                VALUES (@payee, NOW(), @amount)", conn)
                    cmd.Parameters.AddWithValue("payee", cbb_suppliers.Text.Trim)
                    cmd.Parameters.AddWithValue("amount", CDec(txt_total_view.Text.Trim))
                    cmd.ExecuteNonQuery()
                End Using

                'GENERATE NEW VOUCHER | //MERGE
                Using cmd = New MySqlCommand("INSERT INTO ims_payment_vouchers (payment_type, receipts, creation_date, collection_ref, supplier, generated_by)
                                VALUES (@payment_type, @receipts, CURRENT_TIMESTAMP, @collection_ref, (SELECT id FROM ims_suppliers WHERE supplier=@supplier), @generated_by)", conn)
                    cmd.Parameters.AddWithValue("receipts", receipts)
                    cmd.Parameters.AddWithValue("payment_type", "cash")
                    cmd.Parameters.AddWithValue("collection_ref", txt_collection_ref.Text.Trim)
                    cmd.Parameters.AddWithValue("supplier", cbb_suppliers.Text.Trim)
                    cmd.Parameters.AddWithValue("generated_by", frm_main.user_id.Text)
                    cmd.ExecuteNonQuery()
                End Using

                'GET LAST VOUCHER ID
                Dim voucher_id = get_count(conn)

                'GET CHEQUE COUNT
                Dim payment_id = get_payment_id(conn, "cash")

                'UPDATE RECEIPTS
                Using update_cmd = New MySqlCommand("UPDATE ims_delivery_receipts SET 
                                                        status='PAID', 
                                                         payment_type='cash', 
                                                         cash_id=@cash_id,
                                                         payment_ref=@payment_ref
                                                     WHERE payable_id=@id", conn)
                    update_cmd.Parameters.AddWithValue("@id", 0)
                    update_cmd.Parameters.AddWithValue("@payment_ref", voucher_id)
                    update_cmd.Parameters.AddWithValue("@cash_id", payment_id)
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

                'PRINT VOUCHER
                If MsgBox("Print Payment Voucher?", vbInformation + vbYesNo, "Print") = vbYes Then
                    print_voucher(voucher_id, conn)
                End If

                MsgBox("Successfully Generated!", vbInformation, "Information")

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
                Using cmd_returns = New MySqlCommand("SELECT po_return_id, supplier,
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

        If rb_cheque.Checked = True Then
            GenerateCheque()
        ElseIf rb_cash.Checked = True Then
            GenerateCash()
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

    Private Sub rb_cash_Click(sender As Object, e As EventArgs) Handles rb_cash.Click
        panel_cheque.Enabled = False
    End Sub

    Private Sub rb_cheque_Click(sender As Object, e As EventArgs) Handles rb_cheque.Click
        panel_cheque.Enabled = True
    End Sub
End Class