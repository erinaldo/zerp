Imports System.Text.RegularExpressions
Imports DevExpress.XtraReports.UI
Imports MySql.Data.MySqlClient

Public Class frm_sales_start_packing

    ReadOnly conn As New MySqlConnection(str)


    'btn_yes
    Private Sub btn_yes_Click(sender As Object, e As EventArgs) Handles btn_yes.Click
        Try
            Dim order_id = CInt(lbl_id.Text.Replace("SO", ""))

            Using conn
                conn.Open()

                Using cmd = New MySqlCommand("UPDATE ims_orders SET status='On-Going' WHERE order_id=" & order_id, conn)
                    Dim i = cmd.ExecuteNonQuery()

                    'Print Packing Slip IF SUCCESS
                    If i > 0 Then
                        conn.Close()
                        print_packing_list(order_id)
                        Me.Close()

                        frm_main.LoadFrm(New frm_sales_packing_list)

                    End If
                End Using

            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            conn.Close()
        End Try

    End Sub




    '--- FUNCTION ----

    'Print
    Private Sub print_packing_list(id As String)
        Dim report = New doc_packing_list()
        Dim printTool = New ReportPrintTool(report)
        Dim rdr As MySqlDataReader
        Dim table = New PrintData
        Dim order_id = String.Empty, customer = String.Empty, addr = String.Empty, order_date = String.Empty, orders = String.Empty, priv_notes = String.Empty, agent = String.Empty, trucking = String.Empty, shipping_method = String.Empty

        Try
            conn.Open()
            Dim query = "SELECT ims_orders.order_id, ims_customers.first_name as customer, ims_users.first_name as agent, ims_orders.order_item, ims_orders.ship_to, ims_orders.date_ordered, ims_orders.priv_note, trucking, shipping_method FROM `ims_orders` 
                            LEFT JOIN ims_customers on ims_orders.customer=ims_customers.customer_id
                            LEFT JOIN ims_users on ims_orders.agent=ims_users.usr_id WHERE order_id='" & id & "'
                            UNION
                         SELECT ims_orders.order_id, ims_customers.first_name as customer, ims_users.first_name as agent, ims_orders.order_item, ims_orders.ship_to, ims_orders.date_ordered, ims_orders.priv_note, trucking, shipping_method FROM `ims_orders` 
                            RIGHT JOIN ims_customers on ims_orders.customer=ims_customers.customer_id
                            RIGHT JOIN ims_users on ims_orders.agent=ims_users.usr_id WHERE order_id='" & id & "'"
            Dim cmd = New MySqlCommand(query, conn)
            rdr = cmd.ExecuteReader

            Using rdr
                rdr.Read()
                order_id = rdr("order_id")
                customer = rdr("customer")
                addr = rdr("ship_to")
                agent = rdr("agent")
                orders = rdr("order_item")
                order_date = rdr("date_ordered")
                priv_notes = rdr("priv_note")
                trucking = rdr("trucking")
                shipping_method = rdr("shipping_method")
            End Using

            data_to_grid(orders, table.packing_list)

            report.Parameters("order_id").Value = order_id
            report.Parameters("customer").Value = customer
            report.Parameters("address").Value = addr
            report.Parameters("agent").Value = agent
            report.Parameters("ordered_date").Value = order_date
            report.Parameters("priv_notes").Value = priv_notes
            report.Parameters("shipping_method").Value = shipping_method
            report.Parameters("trucking").Value = trucking
            report.RequestParameters = False
            report.DataSource = table

            printTool.AutoShowParametersPanel = False
            printTool.ShowRibbonPreviewDialog()

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            conn.Close()
        End Try

    End Sub

    'Set Grid Data
    Public Sub data_to_grid(units As String, GridOrTable As DataTable)

        Dim comma(), equal() As String
        Dim piece As String
        Dim i As Integer
        Dim colonseparator As New Regex("\b;\b")
        Dim equalseparator As New Regex("\b=\b")
        Dim location = String.Empty

        If GridOrTable.Rows.Count > 0 Then GridOrTable.Rows.Clear()

        If Not String.IsNullOrEmpty(units) Then

            comma = colonseparator.Split(units)

            For i = 0 To comma.Length - 1
                piece = comma(i).Trim
                equal = piece.Split("=")

                With conn
                    Dim my_store = "ims_" & frm_main.user_store.Text.Trim.Replace(" ", "_").ToLower
                    Dim cmd = New MySqlCommand("SELECT location FROM " & my_store & " INNER JOIN ims_inventory ON ims_inventory.pid=" & my_store & " .pid WHERE ims_inventory.winmodel=@model", conn)
                    cmd.Parameters.AddWithValue("@store", my_store)
                    cmd.Parameters.AddWithValue("@model", equal(1))
                    location = cmd.ExecuteScalar()
                End With

                GridOrTable.Rows.Add(equal(0), equal(1), equal(2), location)

            Next

            GridOrTable.DefaultView.Sort = "model ASC"

        End If

    End Sub

End Class