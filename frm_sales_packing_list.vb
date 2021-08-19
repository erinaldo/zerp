Imports DevExpress.XtraBars.Navigation
Imports MySql.Data.MySqlClient

Public Class frm_sales_packing_list

    ReadOnly conn As New MySqlConnection(str)


    Private Sub frm_packing_list_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_orders("Pending for Arrangement")
        start_timer()
    End Sub



    '---- FUNCTIONS ----

    'Load Orders
    Private Sub load_orders(classification As String)

        Try
            conn.Open()
            Dim query = String.Empty
            Select Case classification
                Case "Pending for Arrangement", "0"
                    query = "SELECT order_id, date_ordered,  ims_users.first_name as agent, ims_customers.first_name, transaction_type, status FROM ims_orders 
                            INNER JOIN ims_customers on ims_orders.customer=ims_customers.customer_id 
                            INNER JOIN ims_users on ims_orders.agent=ims_users.usr_id 
                            WHERE status='Pending for Arrangement' AND NOT ims_orders.deleted='1' ORDER BY date_ordered ASC"
                Case "On-Going", "1"
                    query = "SELECT order_id, date_ordered,  ims_users.first_name as agent, ims_customers.first_name, transaction_type, status FROM ims_orders 
                            INNER JOIN ims_customers on ims_orders.customer=ims_customers.customer_id 
                            INNER JOIN ims_users on ims_orders.agent=ims_users.usr_id 
                            WHERE status='On-Going' AND NOT ims_orders.deleted='1' ORDER BY date_ordered ASC"
                Case "Packed", "2"
                    query = "SELECT order_id, date_ordered,  ims_users.first_name as agent, ims_customers.first_name, transaction_type, status FROM ims_orders 
                            INNER JOIN ims_customers on ims_orders.customer=ims_customers.customer_id 
                            INNER JOIN ims_users on ims_orders.agent=ims_users.usr_id 
                            WHERE status='Packed' AND NOT ims_orders.deleted='1' ORDER BY date_ordered ASC"
            End Select
            Dim cmd = New MySqlCommand(query, conn)
            cmd.ExecuteNonQuery()

            Dim dt = New DataTable
            Dim da = New MySqlDataAdapter(cmd)
            da.Fill(dt)

            grid_orders.DataSource = dt
            grid_orders_view.FocusedRowHandle = -1
            grid_orders_view.ClearSelection()

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            conn.Close()
            SetCount()
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

    'Count Label
    Private Sub SetCount()
        Try
            Try
                conn.Open()

                'Label for Pending for Arrangement
                Using cmd = New MySqlCommand("SELECT COUNT(*) FROM ims_orders WHERE status='Pending for Arrangement' AND NOT ims_orders.deleted='1'", conn)
                    Dim count As Integer = cmd.ExecuteScalar()
                    tab_pending.Caption = "Pending Arrangements (" & count & ")"
                End Using

                'Label for On-Going
                Using cmd = New MySqlCommand("SELECT COUNT(*) FROM ims_orders WHERE status='On-Going' AND NOT ims_orders.deleted='1'", conn)
                    Dim count As Integer = cmd.ExecuteScalar()
                    tab_ongoing.Caption = "On-Going (" & count & ")"
                End Using

                'Label for Packed
                Using cmd = New MySqlCommand("SELECT COUNT(*) FROM ims_orders WHERE status='Packed' AND NOT ims_orders.deleted='1'", conn)
                    Dim count As Integer = cmd.ExecuteScalar()
                    tab_completed.Caption = "Completed (" & count & ")"
                End Using

            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try
        Finally
            conn.Close()
        End Try

    End Sub




    '--- CONTROLS /EVENTS ----

    Private Sub grid_orders_view_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles grid_orders_view.RowClick

        If tabpane.SelectedPage.Equals(tab_pending) Then
            If grid_orders_view.FocusedColumn.FieldName.Equals("order_id") Then
                Dim order_id = grid_orders_view.GetRowCellValue(e.RowHandle, "order_id")
                Dim frm = New frm_sales_start_packing()
                frm.lbl_id.Text = String.Concat("SO", order_id.ToString().PadLeft(5, "0"c))
                frm.ShowDialog()
                load_orders("Pending for Arrangement")
            End If

        ElseIf tabpane.SelectedPage.Equals(tab_ongoing) Then
            If grid_orders_view.FocusedColumn.FieldName.Equals("order_id") Then
                Dim order_id = grid_orders_view.GetRowCellValue(e.RowHandle, "order_id")
                Dim order_status As String = grid_orders_view.GetRowCellValue(e.RowHandle, "status")
                Dim frm As frm_sales_packing_list_view = New frm_sales_packing_list_view()
                frm.LoadData(order_id, order_status)
                load_orders("On-Going")
            End If
        End If

    End Sub

    'timer
    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        load_orders(tabpane.SelectedPageIndex)
    End Sub

    'Timer Selection
    Private Sub cbb_timer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbb_timer.SelectedIndexChanged
        start_timer()
    End Sub

    'Tab Selection
    Private Sub tabpane_SelectedPageChanged(sender As Object, e As SelectedPageChangedEventArgs) Handles tabpane.SelectedPageChanged
        If tabpane.SelectedPage.Equals(tab_pending) Then
            load_orders("Pending for Arrangement")
        ElseIf tabpane.SelectedPage.Equals(tab_ongoing) Then
            load_orders("On-Going")
        ElseIf tabpane.SelectedPage.Equals(tab_completed) Then
            load_orders("Packed")
        End If
    End Sub

End Class