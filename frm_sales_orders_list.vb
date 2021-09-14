Imports MySql.Data.MySqlClient

Public Class frm_sales_orders

    ReadOnly conn As New MySqlConnection(str)

    'ON LOAD
    Private Sub frm_sales_orders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_orders()
        load_quotes()
        start_timer()
    End Sub




    '---- FUNCTIONS ----

    'Load Orders
    Private Sub load_orders()

        Try
            conn.Open()
            Dim query = "SELECT concat('SO',LPAD(order_id,5,0)) as order_id, date_ordered, ims_users.first_name as agent, ims_customers.first_name, transaction_type, payment_status, date_packed, date_released,
                            CONCAT( UPPER( SUBSTRING( payment_type, 1, 1 ) ) , LOWER( SUBSTRING( payment_type FROM 2 ) ) ) as payment_type,
                            CONCAT( UPPER( SUBSTRING( shipping_method, 1, 1 ) ) , LOWER( SUBSTRING( shipping_method FROM 2 ) ) ) as shipping_method, status FROM ims_orders  
                            INNER JOIN ims_customers on ims_orders.customer=ims_customers.customer_id 
                            INNER JOIN ims_users on ims_orders.agent=ims_users.usr_id 
                            WHERE NOT (status='Cancelled') AND NOT payment_status='PAID' AND ims_orders.deleted='0'"
            Dim cmd = New MySqlCommand(query, conn)
            cmd.ExecuteNonQuery()

            Dim dt = New DataTable
            Dim da = New MySqlDataAdapter(cmd)
            da.Fill(dt)

            grid_orders.DataSource = dt
            grid_orders_view.FocusedRowHandle = -1

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            conn.Close()
        End Try

    End Sub

    'Load Quotations
    Private Sub load_quotes()

        Try
            conn.Open()
            Dim query = "SELECT concat('Q',LPAD(quotation_id,5,0)) as quotation_id, company, status FROM ims_quotations 
                        WHERE is_converted='0' AND is_deleted='0' AND NOW() BETWEEN created_at AND created_at + INTERVAL 30 DAY ORDER BY quotation_id DESC"
            Dim cmd = New MySqlCommand(query, conn)
            cmd.ExecuteNonQuery()

            Dim dt = New DataTable
            Dim da = New MySqlDataAdapter(cmd)
            da.Fill(dt)

            grid_quotes.DataSource = dt
            grid_quotes_view.FocusedRowHandle = -1

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
        load_orders()
        load_quotes()
    End Sub


    'View Quotation
    Private Sub grid_quotes_view_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles grid_quotes_view.RowCellClick

        If grid_quotes_view.FocusedColumn.Name = col_quotation_id.Name Then
            Dim quote_id = grid_quotes_view.GetFocusedRowCellValue(col_quotation_id)

            Dim view_quote = New frm_sales_view_quotation
            view_quote.load_data(quote_id.Replace("Q", ""))
            view_quote.cbb_customer.Enabled = False
            view_quote.Show()
        End If

    End Sub

    'Timer Selection
    Private Sub cbb_timer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbb_timer.SelectedIndexChanged
        start_timer()
    End Sub

    'CTRL + N | Show New Order
    Private Sub frm_sales_orders_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.N AndAlso e.Modifiers = Keys.Control Then
            Dim frm = New frm_sales_create_order
            frm.Show()
        End If
    End Sub

    'btn_order | Show New Order
    Private Sub btn_order_Click(sender As Object, e As EventArgs) Handles btn_order.Click
        Dim frm = New frm_sales_create_order
        frm.Show()
    End Sub

    'btn_quote | Show New Quote
    Private Sub btn_quote_Click(sender As Object, e As EventArgs) Handles btn_quote.Click
        Dim frm = New frm_sales_create_quotation
        frm.Show()
    End Sub

    'btn_customer | Show New Customer
    Private Sub btn_customer_Click(sender As Object, e As EventArgs) Handles btn_customer.Click
        frm_sales_customers_new.ShowDialog()
    End Sub

    'btn_refresh
    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        load_orders()
        load_quotes()
    End Sub

    'btn_order_history
    Private Sub btn_order_history_Click(sender As Object, e As EventArgs) Handles btn_order_history.Click
        frm_sales_order_history.Show()
    End Sub

    'btn_view_order | View Order
    Private Sub btn_view_order_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btn_view_order.ButtonClick
        Dim orderid As String = grid_orders_view.GetFocusedRowCellValue(col_order_id)

        Dim view_order = New frm_sales_view_order
        view_order.LoadData(orderid.Replace("SO", ""))
        view_order.Show()
    End Sub

End Class