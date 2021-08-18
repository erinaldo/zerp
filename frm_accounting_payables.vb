Imports DevExpress.XtraGrid.Columns
Imports MySql.Data.MySqlClient

Public Class frm_accounting_payables

    ReadOnly conn As New MySqlConnection(str)

    '--- ONLOAD ----
    Private Sub frm_accounting_payables_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_account_payables("")
    End Sub




    '---- FUNCTIONS ----

    'Load Account Payables
    Private Sub load_account_payables(status As String)

        Try
            conn.Open()
            Dim query = "SELECT payable_id, ims_suppliers.supplier, ims_suppliers.terms, receipt_ref, receipt_type, amount, status, received_date, ims_stores.store_name, 
                        CONCAT('PO',LPAD(purchase_id, 5, 0)) as purchase_id, payment_cheque, payment_dates, CONCAT('PR', LPAD(payment_ref, 5, 0)) as payment_ref, 
                        DATE_ADD(received_date, INTERVAL ims_suppliers.terms DAY) as due_date FROM ims_delivery_receipts
                        INNER JOIN ims_suppliers ON ims_suppliers.id=ims_delivery_receipts.supplier_id
                        LEFT JOIN ims_payment_vouchers ON ims_payment_vouchers.payment_id=ims_delivery_receipts.payment_ref
                        INNER JOIN ims_stores ON ims_stores.store_id=ims_delivery_receipts.store_id " & status
            Dim cmd = New MySqlCommand(query, conn)
            cmd.ExecuteNonQuery()

            Dim dt = New DataTable
            Dim da = New MySqlDataAdapter(cmd)
            da.Fill(dt)

            grid_payables.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

    End Sub




    '--- CONTROLS ----


    'btn_all
    Private Sub btn_all_Click(sender As Object, e As EventArgs) Handles btn_all.Click
        load_account_payables("")
    End Sub

    'btn_paid
    Private Sub btn_paid_Click(sender As Object, e As EventArgs) Handles btn_paid.Click
        load_account_payables("WHERE status='PAID'")
    End Sub

    'btn_unpaid
    Private Sub btn_unpaid_Click(sender As Object, e As EventArgs) Handles btn_unpaid.Click
        load_account_payables("WHERE status='UNPAID'")
    End Sub

    'btn_issued
    Private Sub btn_issued_Click(sender As Object, e As EventArgs) Handles btn_issued.Click
        load_account_payables("WHERE status='ISSUED'")
    End Sub

    'btn_open
    Private Sub btn_open_Click(sender As Object, e As EventArgs) Handles btn_open.Click
        Dim receipt_id As String = grid_payables_view.GetFocusedRowCellValue(col_id)
        Dim frm = frm_accounting_view_transaction

        Try
            conn.Open()
            Dim cmd = New MySqlCommand("SELECT qty, ims_inventory.winmodel, ims_inventory.supmodel, ims_inventory.description, ims_deliveries.cost, (qty * ims_deliveries.cost) as total_cost FROM ims_deliveries
                        INNER JOIN ims_inventory ON ims_inventory.pid=ims_deliveries.item
                        WHERE receipt_id=@receipt_id", conn)
            cmd.Parameters.AddWithValue("@receipt_id", receipt_id)
            cmd.ExecuteNonQuery()

            Dim dt = New DataTable
            Dim da = New MySqlDataAdapter(cmd)
            da.Fill(dt)


            Dim cmd_get_info = New MySqlCommand("SELECT (SELECT supplier FROM ims_suppliers WHERE id=supplier_id) as supplier,
                        CONCAT('PO', LPAD(ims_delivery_receipts.purchase_id,5,0)) as poid, received_date, receipt_type, receipt_ref,
                        withholding_tax_amount,
                        count_by, (SELECT first_name FROM ims_users WHERE usr_id=ims_deliveries.receiver) as encoder, ims_delivery_receipts.discount, return_credit, amount
                        FROM ims_delivery_receipts
                        INNER JOIN ims_deliveries ON ims_deliveries.receipt_id=ims_delivery_receipts.payable_id                        
                        INNER JOIN ims_inventory ON ims_inventory.pid=ims_deliveries.item  
                        INNER JOIN ims_purchase ON ims_purchase.purchase_id=ims_delivery_receipts.purchase_id    
                        WHERE payable_id=@receipt_id", conn)
            cmd_get_info.Parameters.AddWithValue("@receipt_id",receipt_id)
            Dim rdr As MySqlDataReader = cmd_get_info.ExecuteReader

            While rdr.Read
                frm.txt_purchaseID.Text = rdr("poid")
                frm.txt_supplier.Text = rdr("supplier")
                frm.txt_received_date.Text = rdr("received_date")
                frm.txt_encoded_by.Text = rdr("encoder")
                frm.txt_counted_by.Text = rdr("count_by")
                frm.lbl_ref.Text = rdr("receipt_ref")
                frm.lbl_type.Text = rdr("receipt_type")
                frm.lbl_discount.Text = IIf(IsDBNull(rdr("discount")), "", rdr("discount"))
                frm.lbl_returned_credit.Text = IIf(rdr("return_credit") <= 0, "", CDec(rdr("return_credit")))
                frm.txt_total.Text = FormatCurrency(rdr("amount"))
                frm.txt_ewt.Text = IIf(rdr("withholding_tax_amount") > 0, rdr("withholding_tax_amount"), "")
            End While

            frm.grid_transaction.DataSource = dt
            frm.ShowDialog()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

    End Sub

    'btn_new_payable
    Private Sub btn_new_payable_Click(sender As Object, e As EventArgs) Handles btn_new_payable.Click
        frm_accounting_new_payable.ShowDialog()
    End Sub

End Class