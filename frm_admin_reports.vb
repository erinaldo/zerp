Imports DevExpress.XtraEditors
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraPrintingLinks
Imports MySql.Data.MySqlClient

Public Class frm_admin_reports


    '--- ONLOAD ---
    Private Sub frm_admin_reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim month_date As String = Date.Now.Month
        Dim year_date As String = Date.Now.Year

        dt_start.EditValue = Date.Parse("1/" & month_date & "/" & year_date)
        Dim end_of_month As String = Date.DaysInMonth(Date.Now.Year, Date.Now.Month) & "/" & month_date & "/" & year_date
        dt_end.EditValue = Date.Parse(end_of_month)

        Load_Selected_Tab()
    End Sub






    '--- FUNCTIONS ----


    'Loading Selected Tab
    Private Sub Load_Selected_Tab()
        Select Case TabControl.SelectedTabPage.Name
            Case tab_sales.Name : Load_Sales_Over_Time()
            Case tab_users.Name : Load_SalesCoordinatorAgent()
            Case tab_performance.Name
                Load_CoordinatorAgent_list()
                Load_SalesCoordinatorAgent_performance()
            Case tab_product.Name : Load_ProductPerformace()
        End Select
    End Sub



    '-->> SALES REPORTS

    'Load Sales Report
    Private Sub Load_Sales_Over_Time()
        Try
            Using conn = New MySqlConnection(str)
                conn.Open()
                Dim dt = New DataTable
                dt.Columns.Add("datee", GetType(Date))
                dt.Columns.Add("total_cost", GetType(Decimal))
                dt.Columns.Add("total_cash", GetType(Decimal))
                dt.Columns.Add("total_terms", GetType(Decimal))
                dt.Columns.Add("total_epay", GetType(Decimal))
                dt.Columns.Add("total_sales", GetType(Decimal))
                dt.Columns.Add("total_transactions", GetType(Integer))
                dt.Columns.Add("avg_transc_amount", GetType(Decimal))
                dt.Columns.Add("avg_sales_margin", GetType(String))

                'DISPLAY DATA WITH STORED PROCEDURE
                Dim query = "SELECT 
		                        DATE(ims.date_released) AS datee,
		                        (SELECT SUM(cost * qty) FROM ims_sales INNER JOIN ims_orders AS a ON a.order_id=ims_sales.order_id WHERE DATE(purchase_date) = datee AND a.payment_status='PAID') AS total_cost,
		                        (SELECT IFNULL(SUM(paid_amount), 0.00) FROM ims_orders WHERE (payment_type = 'Terms' OR payment_type = 'Cheque') AND payment_status='PAID' AND deleted='0' AND DATE(date_released) = datee) AS total_terms, 
		                        (SELECT IFNULL(SUM(paid_amount), 0.00) FROM ims_orders WHERE payment_type = 'E-Payment' AND payment_status='PAID' AND deleted='0' AND DATE(date_released) = datee) AS total_epay,
		                        (SELECT IFNULL(SUM(paid_amount), 0.00) FROM ims_orders WHERE payment_type = 'Cash' AND payment_status='PAID' AND deleted='0' AND DATE(date_released) = datee) AS total_cash,
		                        (ROUND(
			                        (SELECT IFNULL(SUM(paid_amount), 0.00) FROM ims_orders WHERE (payment_type = 'Terms' OR payment_type = 'Cheque') AND payment_status='PAID' AND deleted='0' AND DATE(date_released) = datee) + 
			                        (SELECT IFNULL(SUM(paid_amount), 0.00) FROM ims_orders WHERE payment_type = 'E-Payment' AND payment_status='PAID' AND deleted='0' AND DATE(date_released) = datee) +
			                        (SELECT IFNULL(SUM(paid_amount), 0.00) FROM ims_orders WHERE payment_type = 'Cash' AND payment_status='PAID' AND deleted='0' AND DATE(date_released) = datee), 2)
		                        ) AS gross_sale,
		                        (SELECT COUNT(order_id) FROM ims_orders WHERE DATE(date_released) = datee) AS total_transactions
	                        FROM ims_orders ims
	                        WHERE date_released IS NOT NULL AND NOT paid_amount = 0 AND DATE(date_released) BETWEEN @start_date AND @end_date
	                        GROUP BY datee
	                        ORDER BY datee DESC"
                Using cmd = New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@start_date", dt_start.EditValue)
                    cmd.Parameters.AddWithValue("@end_date", dt_end.EditValue)
                    Using rdr = cmd.ExecuteReader()
                        While rdr.Read()
                            dt.Rows.Add(rdr("datee"),
                                        rdr("total_cost"),
                                        rdr("total_cash"),
                                        rdr("total_terms"),
                                        rdr("total_epay"),
                                        rdr("gross_sale"),
                                        rdr("total_transactions"),
                                        rdr("gross_sale") / rdr("total_transactions"),
                                        Math.Round(((rdr("gross_sale") - rdr("total_cost")) / rdr("gross_sale")) * 100, 0) & "%")
                        End While
                    End Using

                    grid_sales_report.DataSource = dt
                    chart_SalesOverTime()

                End Using
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'Load Sales Coordinator / Agent
    Private Sub Load_SalesCoordinatorAgent()
        Try
            Using conn = New MySqlConnection(str)
                conn.Open()

                'LOAD SALES REPORT OF COORDINATORS
                Dim query_coordinator = "SELECT 
	                                        (SELECT first_name FROM ims_users WHERE usr_id=agent) AS sales_coordinator,
	                                        IFNULL((SELECT COUNT(*) FROM ims_orders WHERE agent=ims.agent AND payment_status='PAID' AND deleted='0' AND date_released BETWEEN @StartDate AND DATE_ADD(@EndDate, INTERVAL 1 DAY) GROUP BY agent),0) AS transactions,
	                                        (SELECT COUNT(DISTINCT customer) FROM ims_orders WHERE agent=ims.agent AND payment_status='PAID' AND deleted='0' AND date_released BETWEEN @StartDate AND DATE_ADD(@EndDate, INTERVAL 1 DAY)) AS unique_customer,
	                                        SUM(DISTINCT (SELECT SUM(cost * qty) FROM ims_sales INNER JOIN ims_orders AS a ON a.order_id=ims_sales.order_id WHERE DATE(purchase_date) = DATE(ims.date_released) AND a.payment_status='PAID' AND a.agent=ims.agent)) AS total_cost,
	                                        SUM(DISTINCT (SELECT IFNULL(SUM(paid_amount), 0.00) FROM ims_orders WHERE DATE(date_released) = DATE(ims.date_released) AND agent=ims.agent)) AS gross_sales
                                        FROM ims_orders ims
                                        WHERE date_released IS NOT NULL AND NOT paid_amount = 0 AND payment_status='PAID' AND deleted='0' AND DATE(date_released) BETWEEN @StartDate AND DATE_ADD(@EndDate, INTERVAL 1 DAY) 
                                        GROUP BY agent"
                Using cmd = New MySqlCommand(query_coordinator, conn)
                    cmd.Parameters.AddWithValue("@StartDate", dt_start.EditValue)
                    cmd.Parameters.AddWithValue("@EndDate", dt_end.EditValue)
                    cmd.ExecuteNonQuery()
                    Dim dt = New DataTable
                    Dim da = New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                    grid_coordinator.DataSource = dt
                End Using


                'LOAD SALES REPORT OF AGENTS
                Dim query_agents = "SELECT 
	                                    IFNULL((SELECT first_name FROM ims_users WHERE usr_id=sales_agent), 'Unassigned') AS sales_agents,
	                                    (SELECT COUNT(*) FROM ims_orders WHERE sales_agent=ims.sales_agent AND date_released BETWEEN @StartDate AND DATE_ADD(@EndDate, INTERVAL 1 DAY) AND payment_status='PAID' AND deleted='0' GROUP BY sales_agent) AS transactions,
	                                    (SELECT COUNT(DISTINCT customer) FROM ims_orders WHERE sales_agent=ims.sales_agent AND payment_status='PAID' AND deleted='0' AND date_released BETWEEN @StartDate AND DATE_ADD(@EndDate, INTERVAL 1 DAY)) AS unique_customer,
	                                    SUM(DISTINCT (SELECT SUM(cost * qty) FROM ims_sales INNER JOIN ims_orders AS a ON a.order_id=ims_sales.order_id WHERE DATE(purchase_date) = DATE(ims.date_released) AND a.payment_status='PAID' AND a.sales_agent=ims.sales_agent)) AS total_cost,
	                                    SUM(DISTINCT (SELECT IFNULL(SUM(paid_amount), 0.00) FROM ims_orders WHERE DATE(date_released) = DATE(ims.date_released) AND sales_agent=ims.sales_agent)) AS gross_sales
                                    FROM ims_orders ims
                                    WHERE date_released IS NOT NULL AND NOT paid_amount = 0 AND payment_status='PAID' AND deleted='0' AND date_released BETWEEN @StartDate AND DATE_ADD(@EndDate, INTERVAL 1 DAY)  
                                     GROUP BY sales_agent"
                Using cmd = New MySqlCommand(query_agents, conn)
                    cmd.Parameters.AddWithValue("@StartDate", dt_start.EditValue)
                    cmd.Parameters.AddWithValue("@EndDate", dt_end.EditValue)
                    cmd.ExecuteNonQuery()
                    Dim dt = New DataTable
                    Dim da = New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                    grid_agents.DataSource = dt
                End Using

                'Plot To Chart
                chart_SalesByUsers()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'Load Sales Coordinator / Agent Performance
    Private Sub Load_SalesCoordinatorAgent_performance()

        Try
            Using conn = New MySqlConnection(str)
                conn.Open()

                'LOAD SALES REPORT OF COORDINATORS
                Dim query_coordinator = "SELECT 
	                                        DATE(date_released) AS datee,
	                                        (SELECT COUNT(*) FROM ims_orders WHERE DATE(date_released)=datee AND payment_status='PAID' AND deleted='0' AND agent=ims.agent) AS transactions,
	                                        (SELECT COUNT(DISTINCT customer) FROM ims_orders WHERE DATE(date_released)=datee AND payment_status='PAID' AND deleted='0' AND agent=ims.agent) AS unique_customer,
	                                        (SELECT SUM(cost * qty) FROM ims_sales 
		                                        INNER JOIN ims_orders ON ims_orders.order_id=ims_sales.order_id 
		                                        WHERE DATE(purchase_date) = datee AND ims_orders.payment_status='PAID' AND agent=ims.agent) AS total_cost,	
	                                        (SELECT IFNULL(SUM(paid_amount), 0.00) FROM ims_orders 
		                                        WHERE DATE(date_released) = datee AND agent=ims.agent) AS gross_sale
                                        FROM ims_orders ims
                                        WHERE date_released IS NOT NULL AND NOT paid_amount = 0 AND payment_status='PAID' AND deleted='0' AND agent=@coordinator
                                        AND DATE(date_released) BETWEEN @StartDate AND @EndDate
                                        GROUP BY datee
                                        ORDER BY datee DESC"
                Using cmd = New MySqlCommand(query_coordinator, conn)
                    cmd.Parameters.AddWithValue("@StartDate", dt_start.EditValue)
                    cmd.Parameters.AddWithValue("@EndDate", dt_end.EditValue)
                    cmd.Parameters.AddWithValue("@coordinator", lbl_coordinator.Text)
                    cmd.ExecuteNonQuery()
                    Dim dt = New DataTable
                    Dim da = New MySqlDataAdapter(cmd)
                    da.Fill(dt)

                    grid_perf_coor.DataSource = dt

                End Using

                'LOAD SALES REPORT OF COORDINATORS
                Dim query_agent = "SELECT 
	                                    DATE(date_released) AS datee,
	                                    (SELECT COUNT(*) FROM ims_orders WHERE DATE(date_released)=datee AND payment_status='PAID' AND deleted='0' AND sales_agent=ims.sales_agent) AS transactions,
	                                    (SELECT COUNT(DISTINCT customer) FROM ims_orders WHERE DATE(date_released)=datee AND payment_status='PAID' AND deleted='0' AND sales_agent=ims.sales_agent) AS unique_customer,
	                                    (SELECT SUM(cost * qty) FROM ims_sales 
		                                    INNER JOIN ims_orders ON ims_orders.order_id=ims_sales.order_id 
		                                    WHERE DATE(purchase_date) = datee AND ims_orders.payment_status='PAID' AND sales_agent=ims.sales_agent) AS total_cost,	
	                                    (SELECT IFNULL(SUM(paid_amount), 0.00) FROM ims_orders 
		                                    WHERE DATE(date_released) = datee AND sales_agent=ims.sales_agent) AS gross_sale
                                    FROM ims_orders ims
                                    WHERE date_released IS NOT NULL AND NOT paid_amount = 0 AND payment_status='PAID' AND deleted='0' AND sales_agent=@agent
                                    AND DATE(date_released) BETWEEN @StartDate AND @EndDate 
                                    GROUP BY datee
                                    ORDER BY datee DESC"
                Using cmd = New MySqlCommand(query_agent, conn)
                    cmd.Parameters.AddWithValue("@StartDate", dt_start.EditValue)
                    cmd.Parameters.AddWithValue("@EndDate", dt_end.EditValue)
                    cmd.Parameters.AddWithValue("@agent", lbl_agent.Text)
                    Using rdr = cmd.ExecuteReader

                        Dim dt = New DataTable
                        dt.Columns.Add("datee", GetType(Date))
                        dt.Columns.Add("transactions", GetType(Integer))
                        dt.Columns.Add("unique_customer", GetType(Integer))
                        dt.Columns.Add("total_cost", GetType(Decimal))
                        dt.Columns.Add("gross_sale", GetType(Decimal))
                        dt.Columns.Add("avg_sales_margin", GetType(String))

                        While rdr.Read
                            dt.Rows.Add(
                                rdr("datee"), rdr("transactions"), rdr("unique_customer"), rdr("total_cost"), rdr("gross_sale"), Math.Round(((rdr("gross_sale") - rdr("total_cost")) / rdr("gross_sale")) * 100, 0) & "%")
                        End While

                        grid_perf_sa.DataSource = dt

                    End Using
                End Using

                'Show tp Chart
                chart_performance()

            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'Load Coordinator/Agent List
    Private Sub Load_CoordinatorAgent_list()
        Try
            Using conn = New MySqlConnection(str)
                conn.Open()
                Using cmd = New MySqlCommand("SELECT first_name, role_id FROM ims_users WHERE role_id=7 OR role_id=10", conn)
                    Using rdr = cmd.ExecuteReader
                        While rdr.Read
                            If rdr("role_id") = 7 Then
                                cbb_coordinator.Properties.Items.Add(rdr("first_name"))
                            ElseIf rdr("role_id") = 10 Then
                                cbb_agent.Properties.Items.Add(rdr("first_name"))
                            End If
                        End While
                        cbb_coordinator.SelectedIndex = 0
                        cbb_agent.SelectedIndex = 0
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'Load User ID Upon Selection
    Private Sub GetUserID(cbb_ As ComboBoxEdit, lbl_ As LabelControl)
        Try
            Using conn = New MySqlConnection(str)
                conn.Open()
                Using cmd = New MySqlCommand("SELECT usr_id FROM ims_users WHERE first_name=@name", conn)
                    cmd.Parameters.AddWithValue("@name", cbb_.Text)
                    Using rdr = cmd.ExecuteReader
                        While rdr.Read
                            lbl_.Text = rdr("usr_id")
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'Load Product Performance
    Private Sub Load_ProductPerformace()
        Try
            Using conn = New MySqlConnection(str)
                conn.Open()

                'LOAD SALES REPORT OF COORDINATORS
                Dim query = "SELECT 
	                             pid, winmodel, description, 
	                             SUM(s.qty) AS qty, 
	                             SUM(s.qty * s.cost) AS total_cost, 
	                             SUM(price) AS total_sales, 
	                             SUM(price - (s.qty * s.cost)) AS gross_income,
	                             (SUM(price) - SUM(s.qty * s.cost)) / SUM(price) AS margin
                            FROM ims_sales s
                            INNER JOIN ims_inventory ON ims_inventory.pid=s.item
                            WHERE DATE(purchase_date) BETWEEN @StartDate AND @EndDate
                            GROUP BY item
                            ORDER BY qty DESC"
                Using cmd = New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@StartDate", dt_start.EditValue)
                    cmd.Parameters.AddWithValue("@EndDate", dt_end.EditValue)
                    cmd.ExecuteNonQuery()
                    Dim dt = New DataTable
                    Dim da = New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                    grid_product_perf.DataSource = dt
                End Using

                'Show First Item to Chart
                lbl_prod_name.Text = grid_product_perf_view.GetRowCellValue(0, col_model)
                chart_Product(grid_product_perf_view.GetRowCellValue(0, col_item))

            End Using


        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub



    '--->> Charts

    'Sales Over Time 
    Private Sub chart_SalesOverTime()
        Try
            Dim dt = DirectCast(grid_sales_report.DataSource, DataTable)
            Dim SalesSeries = chart_sales.Series("sales")

            SalesSeries.Points.Clear()

            If rb_gross_sales.Checked Then 'Show Gross Sales in Chart
                For i = 0 To dt.Rows.Count - 1
                    SalesSeries.Points.Add(New DevExpress.XtraCharts.SeriesPoint(dt.Rows(i).Item(0).ToString, CDec(dt.Rows(i).Item(5))))
                Next
            ElseIf rb_margin.Checked Then 'Show Average Sales Margin in Chart
                For i = 0 To dt.Rows.Count - 1
                    SalesSeries.Points.Add(New DevExpress.XtraCharts.SeriesPoint(dt.Rows(i).Item(0).ToString, CInt(dt.Rows(i).Item(8).ToString.Replace("%", ""))))
                Next
            ElseIf rb_transactions.Checked Then 'Show Total Transactions in Chart
                For i = 0 To dt.Rows.Count - 1
                    SalesSeries.Points.Add(New DevExpress.XtraCharts.SeriesPoint(dt.Rows(i).Item(0).ToString, CInt(dt.Rows(i).Item(6))))
                Next
            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'Sales Agent/Coordinator Total Transactions, Gross, Net
    Private Sub chart_SalesByUsers()
        Try

            'Plot Coordinator's Data to Chart
            Using dt = DirectCast(grid_coordinator.DataSource, DataTable)
                Dim series_coordinators = chart_coordinator.Series("coordinators")

                series_coordinators.Points.Clear()

                For i = 0 To dt.Rows.Count - 1
                    series_coordinators.Points.Add(New DevExpress.XtraCharts.SeriesPoint(dt.Rows(i).Item(0).ToString, dt.Rows(i).Item(1)))
                Next
            End Using

            'Plot Agents's Data to Chart
            Using dt = DirectCast(grid_agents.DataSource, DataTable)
                Dim series_agents = chart_agents.Series("agents")

                series_agents.Points.Clear()

                For i = 0 To dt.Rows.Count - 1
                    series_agents.Points.Add(New DevExpress.XtraCharts.SeriesPoint(dt.Rows(i).Item(0).ToString, dt.Rows(i).Item(1)))
                Next
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'Performance
    Private Sub chart_performance()
        Try

            'Plot Coordinator's Performance to Chart
            Using dt = DirectCast(grid_perf_coor.DataSource, DataTable)
                Dim series_coordinators = chart_perf_coordinator.Series("coordinators")

                series_coordinators.Points.Clear()
                Dim selection As Integer = 0

                If rb_perf_coor_transaction.Checked = True Then
                    selection = 1
                ElseIf rb_perf_coor_sales.Checked = True Then
                    selection = 4
                End If

                For i = 0 To dt.Rows.Count - 1
                    series_coordinators.Points.Add(New DevExpress.XtraCharts.SeriesPoint(dt.Rows(i).Item(0).ToString, dt.Rows(i).Item(selection)))
                Next
            End Using

            'Plot Agents's Performace to Chart
            Using dt = DirectCast(grid_perf_sa.DataSource, DataTable)
                Dim series_agents = chart_perf_agent.Series("agents")

                series_agents.Points.Clear()
                Dim selection As Integer = 0

                If rb_perf_agent_transaction.Checked = True Then
                    selection = 1
                ElseIf rb_perf_agent_sales.Checked = True Then
                    selection = 4
                End If

                For i = 0 To dt.Rows.Count - 1
                    series_agents.Points.Add(New DevExpress.XtraCharts.SeriesPoint(dt.Rows(i).Item(0).ToString, dt.Rows(i).Item(selection)))
                Next
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'Product Performance
    Private Sub chart_Product(item As String)
        Try

            Using conn = New MySqlConnection(str)

                conn.Open()
                Dim series = chart_prod.Series("item")
                series.Points.Clear()

                'Getting Data to Chart
                Using cmd = New MySqlCommand("SELECT DATE(purchase_date) AS dt, SUM(qty) AS qty FROM ims_sales 
                                                        WHERE item=@item AND DATE(purchase_date) BETWEEN @StartDate AND @EndDate
                                                        GROUP BY dt", conn)
                    cmd.Parameters.AddWithValue("@item", item)
                    cmd.Parameters.AddWithValue("@StartDate", dt_start.EditValue)
                    cmd.Parameters.AddWithValue("@EndDate", dt_end.EditValue)
                    Using rdr = cmd.ExecuteReader
                        While rdr.Read
                            series.Points.Add(New DevExpress.XtraCharts.SeriesPoint(rdr("dt").ToString, CInt(rdr("qty"))))
                        End While
                    End Using
                End Using

            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub




    '---- CONTROLS ----

    '-->> General Controls
    Private Sub btn_view_Click(sender As Object, e As EventArgs) Handles btn_view.Click
        Load_Selected_Tab()
    End Sub

    Private Sub TabControl_SelectedPageChanged(sender As Object, e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles TabControl.SelectedPageChanged
        Load_Selected_Tab()
    End Sub


    '-->> Control For Sales Over Time

    Private Sub rb_gross_sales_Click(sender As Object, e As EventArgs) Handles rb_gross_sales.Click
        chart_SalesOverTime()
    End Sub

    Private Sub rb_margin_Click(sender As Object, e As EventArgs) Handles rb_margin.Click
        chart_SalesOverTime()
    End Sub

    Private Sub rb_transactions_Click(sender As Object, e As EventArgs) Handles rb_transactions.Click
        chart_SalesOverTime()
    End Sub



    '-->COMBOBOX FOR PERFORMANCE

    Private Sub cbb_coordinator_EditValueChanged(sender As Object, e As EventArgs) Handles cbb_coordinator.EditValueChanged
        GetUserID(cbb_coordinator, lbl_coordinator)
        Load_SalesCoordinatorAgent_performance()
    End Sub

    Private Sub cbb_agent_EditValueChanged(sender As Object, e As EventArgs) Handles cbb_agent.EditValueChanged
        GetUserID(cbb_agent, lbl_agent)
        Load_SalesCoordinatorAgent_performance()
    End Sub



    '--> RADIO BUTTONS FOR PERFORMANCE

    Private Sub rb_perf_coor_transaction_Click(sender As Object, e As EventArgs) Handles rb_perf_coor_transaction.Click
        chart_performance()
    End Sub

    Private Sub rb_perf_coor_sales_Click(sender As Object, e As EventArgs) Handles rb_perf_coor_sales.Click
        chart_performance()
    End Sub

    Private Sub rb_perf_agent_transaction_Click(sender As Object, e As EventArgs) Handles rb_perf_agent_transaction.Click
        chart_performance()
    End Sub

    Private Sub rb_perf_agent_sales_Click(sender As Object, e As EventArgs) Handles rb_perf_agent_sales.Click
        chart_performance()
    End Sub

    Private Sub grid_product_perf_view_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles grid_product_perf_view.RowCellClick
        If grid_product_perf_view.FocusedColumn.Name = col_item.Name Then
            lbl_prod_name.Text = grid_product_perf_view.GetFocusedRowCellValue(col_model)
            chart_Product(grid_product_perf_view.GetFocusedRowCellValue(col_item))
        End If
    End Sub

    Private Sub btn_export_Click(sender As Object, e As EventArgs)
        Try
            Dim fd = New SaveFileDialog
            fd.Filter = "Excel Files (*.xls*)|*.xls"
            If fd.ShowDialog = DialogResult.OK Then
                grid_sales_report.ExportToXls(fd.FileName)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click
        grid_sales_report_view.ShowRibbonPrintPreview()
    End Sub

    Private Sub btn_print_sales_coordinator_Click(sender As Object, e As EventArgs) Handles btn_print_sales_coordinator.Click
        grid_coordinator.ShowRibbonPrintPreview()
    End Sub

    Private Sub btn_print_sales_agent_Click(sender As Object, e As EventArgs) Handles btn_print_sales_agent.Click
        grid_agents.ShowRibbonPrintPreview()
    End Sub

    Private Sub btn_print_perf_coor_Click(sender As Object, e As EventArgs) Handles btn_print_perf_coor.Click
        grid_perf_coor.ShowRibbonPrintPreview()
    End Sub

    Private Sub btn_print_perf_agnet_Click(sender As Object, e As EventArgs) Handles btn_print_perf_agnet.Click
        grid_perf_sa.ShowRibbonPrintPreview()
    End Sub

    Private Sub btn_print_product_Click(sender As Object, e As EventArgs) Handles btn_print_product.Click
        grid_product_perf.ShowRibbonPrintPreview()
    End Sub
End Class