Imports DevExpress.XtraReports.UI
Imports MySql.Data.MySqlClient

Public Class frm_accounting_payment_vouchers

    ReadOnly conn As New MySqlConnection(str)


    '--- ONLOAD ----
    Private Sub frm_accounting_payment_vouchers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_payment_vouchers()
    End Sub




    '---- FUNCTIONS -----

    'Load Payment Vouchers
    Private Sub load_payment_vouchers()

        Try
            conn.Open()
            Dim cmd = New MySqlCommand("SELECT CONCAT('PV', LPAD(payment_id, 5, 0)) as payment_id, ims_suppliers.supplier, creation_date FROM ims_payment_vouchers
                                        INNER JOIN ims_suppliers ON ims_suppliers.id=ims_payment_vouchers.supplier ORDER BY payment_id DESC", conn)
            cmd.ExecuteNonQuery()

            Dim dt = New DataTable
            Dim da = New MySqlDataAdapter(cmd)
            da.Fill(dt)

            grid_payments.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            conn.Close()
        End Try

    End Sub

    'Print Voucher
    Private Sub print_voucher(id As Integer)
        Dim report = New doc_payment_voucher()
        Dim printTool = New ReportPrintTool(report)
        Dim rdr As MySqlDataReader
        Dim table = New PrintData

        Dim conn As New MySqlConnection(str)
        Dim supplier = "", collection_ref = "", generated_by = "", voucher_date = New Date, receipts() As String = {}, store_info = ""

        Try

            conn.Open()
            Dim query = "SELECT ims_suppliers.supplier, receipts, collection_ref, creation_date, receipts, ims_users.first_name, (SELECT value FROM ims_settings WHERE name='store_info') as store_info FROM ims_payment_vouchers
                        INNER JOIN ims_suppliers ON ims_suppliers.id=ims_payment_vouchers.supplier
                        INNER JOIN ims_users ON ims_users.usr_id=ims_payment_vouchers.generated_by
                        WHERE payment_id=@payment_id"
            Dim cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@payment_id", id)
            rdr = cmd.ExecuteReader

            While rdr.Read
                voucher_date = rdr("creation_date")
                collection_ref = rdr("collection_ref")
                supplier = rdr("supplier")
                collection_ref = rdr("collection_ref")
                generated_by = rdr("first_name")
                store_info = rdr("store_info")

                receipts = rdr("receipts").ToString.Split(",")

            End While
            rdr.Close()

            'Get Receipt Data
            Dim get_receipt = New MySqlCommand("SELECT CONCAT('PO', LPAD(ims_delivery_receipts.purchase_id, 5, 0)) as purchase_id, receipt_type, receipt_ref, received_date, ims_purchase.terms,
                                        payment_cheque, payment_dates, ims_delivery_receipts.amount, ims_generated_cheques.bank,
                                        DATE_ADD(received_date, INTERVAL ims_purchase.terms DAY) as due_date FROM ims_delivery_receipts 
                                        INNER JOIN ims_purchase ON ims_purchase.purchase_id=ims_delivery_receipts.purchase_id
                                        INNER JOIN ims_generated_cheques ON ims_generated_cheques.id=ims_delivery_receipts.cheque_id 
                                        WHERE payment_ref=@ref ORDER BY receipt_ref ASC", conn)
            get_receipt.Parameters.AddWithValue("@ref", id)
            Dim reader = get_receipt.ExecuteReader

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
            reader.Close()

            table.payment_voucher.DefaultView.Sort = "receipt_ref ASC"



            'Get Cheque Total No. and Details
            Dim get_cheque = New MySqlCommand("SELECT bank, cheque_no, cheque_date, ims_generated_cheques.amount FROM ims_generated_cheques 
                                INNER JOIN ims_delivery_receipts ON ims_delivery_receipts.payment_cheque=cheque_no
                                WHERE payment_ref=@ref GROUP BY cheque_no, bank, ims_generated_cheques.amount, cheque_date", conn)
            get_cheque.Parameters.AddWithValue("@ref", id)
            Dim rdr_cheque = get_cheque.ExecuteReader

            While rdr_cheque.Read
                table.payment_voucher_cheque.Rows.Add(rdr_cheque("bank"), rdr_cheque("cheque_no"), rdr_cheque("cheque_date"), rdr_cheque("amount"))
            End While


            report.Parameters("store_info").Value = store_info
            report.Parameters("voucher_id").Value = "PV" & id.ToString.PadLeft(5, "0"c)
            report.Parameters("voucher_date").Value = voucher_date
            report.Parameters("supplier").Value = supplier
            report.Parameters("collection_ref").Value = collection_ref
            report.Parameters("generated_by").Value = generated_by
            report.RequestParameters = False

            report.DataSource = table
            report.ShowRibbonPreviewDialog()

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            conn.Close()
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
            MessageBox.Show("Error Encountered: " & ex.Message,
          "Convert Numbers To Words",
          MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return "!#ERROR_ENCOUNTERED"
        End Try

        'Trap null values
        If IsNothing(wAmount) = True Then wAmount = String.Empty Else wAmount =
      IIf(InStr(wAmount.Trim.ToLower, "pesos"),
      wAmount.Trim, wAmount.Trim & " Pesos")

        'Display the result
        Return wAmount
    End Function







    '---- CONTROLS ----

    'btn_view
    Private Sub RepositoryItemButtonEdit1_Click(sender As Object, e As EventArgs) Handles RepositoryItemButtonEdit1.Click
        Dim id = grid_payments_view.GetFocusedRowCellValue(col_id)
        print_voucher(CInt(id.ToString.Replace("PV", "")))
    End Sub

End Class