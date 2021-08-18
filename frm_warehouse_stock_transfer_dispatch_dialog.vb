Imports MySql.Data.MySqlClient
Imports System.Globalization.CultureInfo

Public Class frm_warehouse_stock_transfer_dispatch_dialog

    ReadOnly conn As New MySqlConnection(str)


    '--- FUNCTIONS ---

    Private Function transfer_func(id As Integer)

        Dim source_store = ""
        Dim units = ""

        Try

            conn.Open()
            Dim select_cmd = New MySqlCommand("SELECT src_store.store_name as src_store, receiver_store.store_name as receiver_store, units FROM `ims_transferred_stocks`
                                INNER JOIN ims_stores AS src_store ON src_store.store_id=ims_transferred_stocks.src_store
                                INNER JOIN ims_stores AS receiver_store ON receiver_store.store_id=ims_transferred_stocks.receiver_store WHERE id=" & id, conn)

            Using rdr = select_cmd.ExecuteReader
                While rdr.Read
                    source_store = "ims_" & rdr("src_store").ToString.ToLower.Replace(" ", "_")
                    units = rdr("units").ToString.Trim
                End While
            End Using


            'Checking Stocks Availability
            If check_stocks(source_store, units) Then Return True

            'Deduct to Qty AND Put to on_hold
            Dim cmd_deduct = New MySqlCommand("UPDATE " & source_store & " SET qty=qty-@qty, on_hold=IFNULL(on_hold, 0)+@qty WHERE pid=@pid and qty>=@qty", conn)
            cmd_deduct.Parameters.AddWithValue("@pid", Nothing)
            cmd_deduct.Parameters.AddWithValue("@qty", Nothing)
            cmd_deduct.Prepare()

            Dim per_unit = units.Split(";")

            For i = 0 To per_unit.Length - 1

                'Split Rows to Array
                Dim arr = per_unit(i).Split("=")

                'Set Value to Parameters
                cmd_deduct.Parameters(0).Value = arr(0)
                cmd_deduct.Parameters(1).Value = arr(1)
                cmd_deduct.ExecuteNonQuery()
            Next

            Return False
            Exit Function

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            conn.Close()
        End Try

        Return True

    End Function

    'Check Stock's Availability
    Private Function check_stocks(source_store As String, units As String)

        Dim low_stocks_level = ""
        Dim cmd_check = New MySqlCommand("SELECT qty FROM " & source_store & " WHERE pid=@pid", conn)
        cmd_check.Parameters.AddWithValue("@pid", Nothing)
        cmd_check.Prepare()

        Dim per_unit = units.Split(";")

        For i = 0 To per_unit.Length - 1

            Dim arr = per_unit(i).Split("=")

            cmd_check.Parameters(0).Value = arr(0)
            Dim qty_result As Integer = cmd_check.ExecuteScalar

            If CInt(arr(1)) > qty_result Then
                If i = per_unit.Length - 1 Then
                    low_stocks_level += arr(0)
                Else
                    low_stocks_level += arr(0) & vbCrLf
                End If
            End If

        Next

        If Not String.IsNullOrEmpty(low_stocks_level) Then
            MsgBox("Couldn't proceed. Low level stocks detected!" & vbCrLf & vbCrLf & "Items with low stock level:" & vbCrLf & low_stocks_level, vbCritical, "Low Level Stocks")
            Return True
            Exit Function
        End If

        Return False

    End Function

    'btn_dispatch
    Private Sub btn_dispatch_Click(sender As Object, e As EventArgs) Handles btn_dispatch.Click

        'Validation
        If String.IsNullOrWhiteSpace(txt_prepared_by.Text) Or String.IsNullOrWhiteSpace(txt_count_by.Text) Or String.IsNullOrWhiteSpace(txt_driver.Text) Then
            MsgBox("Complete all required fields!", vbCritical, "Incomplete Fields")
            Exit Sub
        End If

        'Confirmation
        Dim res = MsgBox("Press 'YES' to confirm.", vbYesNo + vbInformation, "Confirmation")
        If Not res = vbYes Then Exit Sub

        Try
            'Get Stock Transder ID
            Dim id = CInt(txt_transfer_id.Text.Replace("ST", ""))

            'Transfer the Units
            If transfer_func(id) Then Exit Sub

            Using conn
                conn.Open()
                Dim query = "UPDATE ims_transferred_stocks SET 
                        prepared_by=@prepared_by,
                        counted_by=@counted_by,
                        driver=@driver,
                        released_by=@released_by,
                        status=@status
                        WHERE id=@id"
                Dim cmd = New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", CInt(txt_transfer_id.Text.Replace("ST", "")))
                cmd.Parameters.AddWithValue("@released_by", frm_main.user_role_id.Text)
                cmd.Parameters.AddWithValue("@prepared_by", CurrentCulture.TextInfo.ToTitleCase(txt_prepared_by.Text.Trim))
                cmd.Parameters.AddWithValue("@counted_by", CurrentCulture.TextInfo.ToTitleCase(txt_count_by.Text.Trim))
                cmd.Parameters.AddWithValue("@driver", CurrentCulture.TextInfo.ToTitleCase(txt_driver.Text.Trim))
                cmd.Parameters.AddWithValue("@status", "Dispatched")
                cmd.ExecuteNonQuery()

                MsgBox("Successfully Dispatched!", vbInformation, "Information")
                Me.Close()
                frm_main.LoadFrm(New frm_warehouse_stock_transfer)

            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            conn.Close()
        End Try

    End Sub

End Class