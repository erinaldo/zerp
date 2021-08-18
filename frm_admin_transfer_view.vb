﻿Imports DevExpress.XtraReports.UI
Imports MySql.Data.MySqlClient

Public Class frm_admin_transfer_view

    ReadOnly conn As New MySqlConnection(str)



    'btn_view | Print Units to be Transferred
    Private Sub btn_view_Click(sender As Object, e As EventArgs) Handles btn_view.Click
        Dim id = CInt(txt_transfer_id.Text.Replace("ST", ""))

        Try
            conn.Open()
            Dim query = "SELECT id, src_store.store_name as src_store, receiver_store.store_name as receiver_store, 
                 units, date, transfer_by.first_name as transfer_by, approved_by.first_name as approved_by, status,
                (SELECT value FROM ims_settings WHERE name='store_info') as store_info FROM `ims_transferred_stocks`
                LEFT JOIN ims_stores As src_store ON src_store.store_id=ims_transferred_stocks.src_store
                LEFT JOIN ims_stores As receiver_store ON receiver_store.store_id=ims_transferred_stocks.src_store
                LEFT JOIN ims_users AS transfer_by ON transfer_by.usr_id=ims_transferred_stocks.transfer_by
                LEFT JOIN ims_users AS approved_by ON approved_by.usr_id=ims_transferred_stocks.approved_by WHERE id=" & id

            Dim cmd = New MySqlCommand(query, conn)
            Dim rdr As MySqlDataReader = cmd.ExecuteReader

            Dim table = New PrintData
            table.transferred_units.Rows.Clear()
            Dim transfer_id = 1, transfer_date = Date.Today, transfer_from = "", transfer_to = "", transfer_by = "", units = "", store_info = "", approved_by = "", status = ""

            While rdr.Read
                status = rdr("status")
                transfer_id = rdr("id")
                transfer_date = rdr("date")
                transfer_from = rdr("src_store")
                transfer_to = rdr("receiver_store")
                transfer_by = rdr("transfer_by")
                units = rdr("units")
                store_info = rdr("store_info")
                approved_by = IIf(IsDBNull(rdr("approved_by")), "", rdr("approved_by"))
            End While
            rdr.Close()

            Dim per_unit = units.Split(";")
            For i = 0 To per_unit.Length - 1

                Dim arr = per_unit(i).Split("=")

                Dim cmd_desc = New MySqlCommand("SELECT winmodel, description FROM ims_inventory WHERE pid=@pid", conn)
                cmd_desc.Parameters.AddWithValue("@pid", arr(0))
                Dim rd As MySqlDataReader = cmd_desc.ExecuteReader

                While rd.Read
                    table.transferred_units.Rows.Add(arr(1), rd("winmodel"), rd("description"))
                End While
                rd.Close()
            Next

            Dim report = New doc_transfer_request()
            Dim printTool = New ReportPrintTool(report)

            report.Parameters("store_info").Value = store_info
            report.Parameters("transfer_id").Value = "ST" & id.ToString.PadLeft(5, "0"c)
            report.Parameters("transfer_date").Value = transfer_date
            report.Parameters("transfer_from").Value = transfer_from
            report.Parameters("transfer_to").Value = transfer_to
            report.Parameters("transfer_by").Value = transfer_by
            report.Parameters("approved_by").Value = approved_by
            report.Watermark.Text = status.ToUpper
            report.RequestParameters = False

            report.DataSource = table
            report.ShowRibbonPreviewDialog

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            conn.Close()
        End Try

    End Sub

    'btn_approved | Approve Transfer Request
    Private Sub btn_approved_Click(sender As Object, e As EventArgs) Handles btn_approved.Click

        Dim ans = MsgBox("Do you want Approve this Transfer Request?.", vbYesNo + vbQuestion, "Confirmation")

        If ans = vbYes Then
            Dim id = CInt(txt_transfer_id.Text.Replace("ST", ""))

            Try
                conn.Open()
                Dim cmd = New MySqlCommand("UPDATE ims_transferred_stocks SET approved_by=@approved_by, status=@status WHERE id = " & id, conn)
                cmd.Parameters.AddWithValue("approved_by", frm_main.user_id.Text)
                cmd.Parameters.AddWithValue("status", "Approved")
                cmd.ExecuteNonQuery()

                Me.Close()
                frm_main.LoadFrm(New frm_admin_approval)

            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            Finally
                conn.Close()
            End Try

        End If

    End Sub

    'btn_declined | Decline Transfer Request
    Private Sub btn_declined_Click(sender As Object, e As EventArgs) Handles btn_declined.Click

        Dim ans = MsgBox("Do you want Decline this Transfer Request?.", vbYesNo + vbQuestion, "Confirmation")

        If ans = vbYes Then
            Dim id = CInt(txt_transfer_id.Text.Replace("ST", ""))

            Try
                conn.Open()
                Dim cmd = New MySqlCommand("UPDATE ims_transferred_stocks SET approved_by=@approved_by, status='Declined' WHERE id = " & id, conn)
                cmd.Parameters.AddWithValue("approved_by", frm_main.user_id.Text)
                cmd.ExecuteNonQuery()

                MsgBox("Transfer Request has been Declined! ", vbExclamation, "Declined")

                Me.Close()
                frm_main.LoadFrm(New frm_admin_approval)

            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            Finally
                conn.Close()
            End Try

        End If

    End Sub







End Class