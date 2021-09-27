﻿Imports MySql.Data.MySqlClient

Public Class frm_collection_terms

    ReadOnly conn As New MySqlConnection(str)


    '--- ON LOAD ----
    Private Sub frm_collection_terms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_terms_orders()
    End Sub




    '--- FUNCTIONS ----


    'Load Unpaid (TERMS)
    Public Sub load_terms_orders()

        Try

            Using conn
                conn.Open()
                Dim query = "SELECT status, order_id, date_ordered, shipping_method, ims_customers.first_name as customer, ims_users.first_name as agent, ims_customers.terms, amount_due, IFNULL(payment_status, 'UNPAID') as payment_status FROM ims_orders
                        INNER JOIN ims_customers ON ims_orders.customer=ims_customers.customer_id
                        INNER JOIN ims_users ON ims_orders.agent=ims_users.usr_id
                        WHERE payment_type='terms' AND (payment_status IS NULL OR NOT payment_status = 'PAID') AND NOT status='Cancelled' AND ims_orders.deleted='0'
                        ORDER BY order_id DESC"
                Dim cmd = New MySqlCommand(query, conn)
                Dim rdr As MySqlDataReader = cmd.ExecuteReader()

                Dim dt = New DataTable
                dt.Columns.Add("order_id")
                dt.Columns.Add("shipping_method")
                dt.Columns.Add("status")
                dt.Columns.Add("payment_status")
                dt.Columns.Add("customer")
                dt.Columns.Add("agent")
                dt.Columns.Add("date_ordered")
                dt.Columns.Add("terms")
                dt.Columns.Add("remaining")
                dt.Columns.Add("classification")
                dt.Columns.Add("amount_due", System.Type.GetType("System.Decimal"))


                While rdr.Read
                    Dim terms = DateAdd("d", rdr("terms"), rdr("date_ordered"))
                    Dim days As Long = DateDiff(DateInterval.Day, Date.Today, terms)

                    Dim classification = String.Empty

                    If days < 0 Then classification = "OVERDUE" Else classification = "PENDING"

                    dt.Rows.Add(rdr("order_id"), rdr("shipping_method"), rdr("status"), rdr("payment_status"), rdr("customer"), rdr("agent"), rdr("date_ordered"), rdr("terms"), days.ToString, classification, rdr("amount_due"))
                End While

                grid_terms.DataSource = dt

            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
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
        load_terms_orders()
    End Sub

    'Timer Selection
    Private Sub cbb_timer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbb_timer.SelectedIndexChanged
        start_timer()
    End Sub


End Class