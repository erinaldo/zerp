﻿Imports MySql.Data.MySqlClient

Public Class frm_collection_payments

    ReadOnly conn As New MySqlConnection(str)


    '--- ON LOAD ----
    Private Sub frm_accounting_payments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_cash_orders()
        load_cheque_orders()
        load_epay_orders()
        start_timer()
    End Sub





    '--- FUNCTIONS ----

    'Load Unpaid (CASH)
    Public Sub load_cash_orders()

        Try
            conn.Open()
            Dim query = "SELECT status, order_id, date_ordered, ims_customers.first_name as customer, ims_users.first_name as agent, shipping_method, (amount_due - IFNULL(paid_amount,0)) as amount_due, IFNULL(payment_status, 'UNPAID') as payment_status FROM ims_orders
                        INNER JOIN ims_customers ON ims_orders.customer=ims_customers.customer_id
                        INNER JOIN ims_users ON ims_orders.agent=ims_users.usr_id
                        WHERE payment_type='cash' AND (payment_status IS NULL OR NOT payment_status = 'PAID') AND NOT status='Cancelled' AND ims_orders.deleted='0'"
            Dim cmd = New MySqlCommand(query, conn)
            cmd.ExecuteNonQuery()

            Dim dt = New DataTable
            Dim da = New MySqlDataAdapter(cmd)
            da.Fill(dt)

            grid_cash.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            conn.Close()
        End Try

    End Sub

    'Load Unpaid (CHEQUE)
    Public Sub load_cheque_orders()

        Try
            conn.Open()
            Dim query = "SELECT status, order_id, date_ordered, ims_customers.first_name as customer, ims_users.first_name as agent, shipping_method, amount_due, IFNULL(payment_status, 'UNPAID') as payment_status FROM ims_orders
                        INNER JOIN ims_customers ON ims_orders.customer=ims_customers.customer_id
                        INNER JOIN ims_users ON ims_orders.agent=ims_users.usr_id
                        WHERE payment_type='cheque' AND (payment_status IS NULL OR NOT payment_status = 'PAID') AND NOT status='Cancelled' AND ims_orders.deleted='0'"
            Dim cmd = New MySqlCommand(query, conn)
            cmd.ExecuteNonQuery()

            Dim dt = New DataTable
            Dim da = New MySqlDataAdapter(cmd)
            da.Fill(dt)

            grid_cheque.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            conn.Close()
        End Try

    End Sub

    'Load Unpaid (TERMS)
    Public Sub load_epay_orders()

        Try
            conn.Open()
            Dim query = "SELECT status, order_id, date_ordered, ims_customers.first_name as customer, ims_users.first_name as agent,
                        shipping_method, (amount_due - IFNULL(paid_amount,0)) as amount_due, IFNULL(payment_status, 'UNPAID') as payment_status,
                        payment_type, payment_option, payment_details FROM ims_orders
                        INNER JOIN ims_customers ON ims_orders.customer=ims_customers.customer_id
                        INNER JOIN ims_users ON ims_orders.agent=ims_users.usr_id
                        WHERE payment_type='E-Payment' AND NOT payment_status = 'PAID' AND NOT status='Cancelled' AND ims_orders.deleted='0'"
            Dim cmd = New MySqlCommand(query, conn)
            cmd.ExecuteNonQuery()

            Dim dt = New DataTable
            Dim da = New MySqlDataAdapter(cmd)
            da.Fill(dt)

            grid_epay.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            conn.Close()
        End Try

    End Sub

    'Start Timer
    Private Sub start_timer()

        Select Case cbb_timer.SelectedIndex
            Case 0 : timer.Interval = 60000
            Case 1 : timer.Interval = 300000
            Case 2 : timer.Interval = 600000
            Case 3 : timer.Interval = 1800000
        End Select

        timer.Stop()
        timer.Start()

    End Sub

    'Timer
    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        load_cash_orders()
        load_cheque_orders()
        load_epay_orders()
    End Sub

    'Timer Selection
    Private Sub cbb_timer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbb_timer.SelectedIndexChanged
        start_timer()
    End Sub




    '--- CONTROLS -----

    'CASH Double Cell Click
    Private Sub grid_cash_view_DoubleClick(sender As Object, e As EventArgs) Handles grid_cash_view.DoubleClick

        Dim status = grid_cash_view.GetFocusedRowCellValue(col_payment_status)
        Dim id = grid_cash_view.GetFocusedRowCellValue(col_order_id)
        Dim cus = grid_cash_view.GetFocusedRowCellValue(col_customer)
        Dim ad = Math.Abs(CDec(grid_cash_view.GetFocusedRowCellValue(col_amount_due)))

        If status.Equals("OVERPAID") Then
            Dim frm = New frm_collection_refund
            frm.LoadData(id, cus, ad)
            frm.ShowDialog()
        Else
            Dim frm = New frm_collection_cash
            frm.LoadData(id, cus, ad)
            frm.ShowDialog()
        End If

    End Sub

    'EPAY Double Click
    Private Sub grid_epay_view_DoubleClick(sender As Object, e As EventArgs) Handles grid_epay_view.DoubleClick

        Dim id = grid_epay_view.GetFocusedRowCellValue(col_order_id)
        Dim cus = grid_epay_view.GetFocusedRowCellValue(col_customer)
        Dim ad = grid_epay_view.GetFocusedRowCellValue(col_amount_due)

        If Not grid_epay_view.GetFocusedRowCellValue(col_payment_status).Equals("OVERPAID") Then
            Dim frm = New frm_collection_epayment()
            frm.LoadData(id, cus, ad)
            frm.ShowDialog()
        Else
            Dim frm = New frm_collection_refund
            frm.LoadData(id, cus, ad)
            frm.ShowDialog()
        End If

    End Sub

    'btn_payment_history
    Private Sub btn_payment_history_Click(sender As Object, e As EventArgs) Handles btn_payment_history.Click
        frm_collection_order_history.Show()
    End Sub

    'btn_refresh
    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        load_cash_orders()
        load_cheque_orders()
        load_epay_orders()
    End Sub

    'btn_terms
    Private Sub btn_terms_collection_Click(sender As Object, e As EventArgs) Handles btn_terms_collection.Click
        frm_collection_terms.Show()
    End Sub

End Class