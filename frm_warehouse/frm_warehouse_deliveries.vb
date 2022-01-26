Imports DevExpress.XtraGrid.Views.Grid
Imports MySql.Data.MySqlClient

Public Class frm_warehouse_deliveries

    'ReadOnly conn As New MySqlConnection(str)

    '--- ON LOAD ----
    Private Sub frm_deliveries_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDeliveries()
    End Sub



    '--- FUCNCTIONS ---

    'Load all Deliveries
    Private Sub LoadDeliveries()

        Try
            Using conn As New MySqlConnection(str)
                conn.Open()

                Dim selection_query As String

                If frm_main.user_role_id.Text = "1" Or frm_main.user_role_id.Text = "6" Or frm_main.user_role_id.Text = "3" Then
                    selection_query = String.Empty
                Else
                    selection_query = "AND deliver_to=(SELECT store_id FROM ims_stores WHERE store_name=@deliver_to)"
                End If

                Dim cmd = New MySqlCommand("SELECT DATE_ADD(CONVERT(date_sent, DATE), INTERVAL ims_purchase.lead_time DAY) AS lead_time, CONCAT('PO',LPAD(purchase_id,5,0)) AS poid, ims_suppliers.supplier,
					(CASE
					     WHEN CURDATE() < DATE_ADD(date_sent, INTERVAL ims_purchase.lead_time DAY) THEN 'On-going'
					     WHEN CURDATE() = DATE_ADD(date_sent, INTERVAL ims_purchase.lead_time DAY) THEN 'Due Date'
					     WHEN CURDATE() > DATE_ADD(date_sent, INTERVAL ims_purchase.lead_time DAY) AND CURDATE() <= DATE_ADD(date_sent, INTERVAL ims_purchase.lead_time + 7 DAY) THEN 'Overdue'
					     WHEN CURDATE() > DATE_ADD(date_sent, INTERVAL ims_purchase.lead_time + 7 DAY) THEN 'Obsolete'
					  END) AS lead_time_status
					FROM `ims_purchase`
                    LEFT JOIN ims_suppliers ON ims_purchase.supplier=ims_suppliers.id
                    WHERE (STATUS='Sent' OR STATUS='Partial') " & selection_query & "
                    ORDER BY lead_time ASC", conn)
                cmd.Parameters.AddWithValue("@deliver_to", frm_main.user_store.Text.Trim)
                cmd.ExecuteNonQuery()

                Dim dt = New DataTable
                Dim da = New MySqlDataAdapter(cmd)
                da.Fill(dt)
                grid_delivery.DataSource = dt

            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub


    'Load Form on Panel
    Public Sub LoadFrm(form As Form)
        If panel_view.Controls.Count > 0 Then
            panel_view.Controls.RemoveAt(0)
        End If

        form.TopLevel = False
        form.Dock = DockStyle.Fill
        form.FormBorderStyle = FormBorderStyle.None
        panel_view.Controls.Add(form)
        panel_view.Tag = form
        form.Show()

    End Sub




    '--- CONTROLS ----

    'Grid Delivery
    Private Sub btn_view_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btn_view.ButtonClick
        Dim poid As Integer = grid_delivery_view.GetFocusedRowCellValue(col_purchase_id).Replace("PO", "")
        Dim frm = New frm_warehouse_delivery_receive
        LoadFrm(frm)
        frm.Load_Orders(poid)
    End Sub

    'btn_open_receipts
    Private Sub btn_open_receipt_Click(sender As Object, e As EventArgs) Handles btn_open_receipt.Click

        Try
            Dim frm = New frm_warehouse_delivery_receipts

            Using conn As New MySqlConnection(str)
                conn.Open()
                Dim cmd = New MySqlCommand("SELECT supplier FROM ims_suppliers", conn)
                Dim rdr As MySqlDataReader = cmd.ExecuteReader

                While rdr.Read
                    frm.cbb_suppliers.Properties.Items.Add(rdr("supplier").ToString)
                End While

            End Using

            frm.ShowDialog()

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    Private Sub grid_delivery_view_RowStyle(sender As Object, e As RowStyleEventArgs) Handles grid_delivery_view.RowStyle
        Dim status As String = grid_delivery_view.GetRowCellValue(e.RowHandle, "lead_time_status")

        Select Case status
            Case "Obsolete"
                e.Appearance.BackColor = Color.IndianRed
                e.Appearance.ForeColor = Color.White
            Case "Overdue" : e.Appearance.BackColor = Color.DarkOrange
            Case "On-going", "Due Date" : e.Appearance.BackColor = Color.Lime
        End Select
    End Sub

End Class