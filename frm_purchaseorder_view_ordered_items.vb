Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient

Public Class frm_purchaseorder_view_ordered_items

    ReadOnly conn As New MySqlConnection(str)

    '--- ONLOAD ---
    Private Sub frm_purchaseorder_view_active_orders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_active_orders()
    End Sub
    Dim count As Integer = 0


    '-- FUNCTIONS ---

    'Load All active Orders
    Private Sub load_active_orders()

        Try
            Dim dt = New DataTable
            dt.Columns.Add("qty")
            dt.Columns.Add("qty_received")
            dt.Columns.Add("qty_to_receive")
            dt.Columns.Add("winmodel")
            dt.Columns.Add("supmodel")
            dt.Columns.Add("description")
            dt.Columns.Add("poid")
            dt.Columns.Add("po_status")
            dt.Columns.Add("supplier")

            conn.Open()
            Dim cmd = New MySqlCommand("SELECT orders, qty_received, concat('PO',LPAD(purchase_id,5,0)) as purchase_id, status,
                        (SELECT supplier FROM ims_suppliers WHERE id=ims_purchase.supplier) as supplier FROM ims_purchase
                        WHERE (STATUS='Sent' OR STATUS='Partial' OR STATUS='Rejected (Sent)') AND deleted='0'", conn)
            Dim rdr = cmd.ExecuteReader
            'WHERE (NOT status='Pending' AND NOT status='Completed' AND NOT status='Obsolete') AND deleted='0'
            count = 0
            While rdr.Read
                set_GridData(dt, rdr("orders"), rdr("qty_received"), rdr("purchase_id"), rdr("status"), rdr("supplier"), False)
                count += 1
            End While

            grid_po.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message & " " & count, vbCritical, "Error")
        Finally
            conn.Close()
        End Try

    End Sub

    'Load All Fulfilled PO But NOT Oders
    Private Sub load_unfulfilled_orders()

        Try
            Dim dt = New DataTable
            dt.Columns.Add("qty")
            dt.Columns.Add("qty_received")
            dt.Columns.Add("qty_to_receive")
            dt.Columns.Add("winmodel")
            dt.Columns.Add("supmodel")
            dt.Columns.Add("description")
            dt.Columns.Add("poid")
            dt.Columns.Add("po_status")
            dt.Columns.Add("supplier")

            conn.Open()
            Dim cmd = New MySqlCommand("SELECT orders, qty_received, concat('PO',LPAD(purchase_id,5,0)) as purchase_id, status,
                        (SELECT supplier FROM ims_suppliers WHERE id=ims_purchase.supplier) as supplier FROM ims_purchase
                        WHERE(status ='Completed' OR status='Obsolete') AND deleted='0'", conn)

            Dim rdr = cmd.ExecuteReader

            While rdr.Read
                set_GridData(dt, rdr("orders"), rdr("qty_received"), rdr("purchase_id"), rdr("status"), rdr("supplier"), True)
            End While

            grid_po.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            conn.Close()
        End Try

    End Sub




    '--- CONTROLS ----

    'Set Units to Grid
    Private Sub set_GridData(table As DataTable, units As String, qty_received As String, purchase_id As String, status As String, supplier As String, RemoveCompleted As Boolean)

        Dim comma(), equal() As String
        Dim received() As String = {}
        Dim piece As String
        Dim i As Integer
        Dim colonseparator As New Regex("\b;\b")
        Dim equalseparator As New Regex("\b=\b")

        If Not String.IsNullOrEmpty(units) Then

            comma = colonseparator.Split(units)
            If Not String.IsNullOrEmpty(qty_received) Then received = qty_received.Split(";")

            For i = 0 To comma.Length - 1
                piece = comma(i).Trim
                equal = piece.Split("=")
                Dim r = 0

                If Not String.IsNullOrEmpty(qty_received) Then r = received(i)

                If RemoveCompleted = True Then If equal(1) = r Then Continue For
                table.Rows.Add(equal(1), r, equal(1) - r, equal(2), equal(3), equal(4), purchase_id, status, supplier)

            Next

        End If

    End Sub

    Private Sub btn_export_Click(sender As Object, e As EventArgs) Handles btn_export.Click
        Dim saveFileDialog = New SaveFileDialog
        saveFileDialog.Filter = "PDF File (*.csv*)|*.csv"

        If saveFileDialog.ShowDialog = DialogResult.OK Then
            grid_po_view.ExportToCsv(saveFileDialog.FileName)
        End If

    End Sub

    'btn_unfulfilled_orders
    Private Sub btn_unfulfilled_orders_Click(sender As Object, e As EventArgs) Handles btn_unfulfilled_orders.Click
        load_unfulfilled_orders()
    End Sub

    'btn_active_orders
    Private Sub btn_active_orders_Click(sender As Object, e As EventArgs) Handles btn_active_orders.Click
        load_active_orders()
    End Sub

End Class