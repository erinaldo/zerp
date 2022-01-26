Imports MySql.Data.MySqlClient

Public Class frm_warehouse_delivery_receipts

    ReadOnly conn As New MySqlConnection(str)

    '--- FUNCTIONS ----
    Private Function validate_fields()

        If String.IsNullOrWhiteSpace(txt_ref.Text) Or
                cbb_suppliers.SelectedIndex <= 0 Or
                cbb_type.SelectedIndex <= 0 Then
            MsgBox("Complete All Field First!", vbCritical, "Incomplete Details")
            Return True
        End If

        Return False

    End Function




    Private Sub btn_open_Click(sender As Object, e As EventArgs) Handles btn_open.Click

        'Validate
        If validate_fields() Then Exit Sub

        Try
            conn.Open()
            Dim cmd = New MySqlCommand("select qty, ims_inventory.winmodel, ims_inventory.description, ims_deliveries.cost, reference, item FROM ims_deliveries
                                inner join ims_inventory ON ims_inventory.pid=item
                                inner join ims_delivery_receipts as dr ON dr.payable_id=receipt_id
                                WHERE dr.receipt_ref=@ref AND dr.supplier_id=(SELECT id FROM ims_suppliers WHERE supplier=@supplier) AND receipt_type=@type", conn)
            cmd.Parameters.AddWithValue("@ref", txt_ref.Text)
            cmd.Parameters.AddWithValue("@supplier", cbb_suppliers.Text)
            cmd.Parameters.AddWithValue("@type", cbb_type.Text)
            cmd.ExecuteNonQuery()

            Dim dt = New DataTable
            Dim da = New MySqlDataAdapter(cmd)
            da.Fill(dt)

            If dt.Rows.Count <= 0 Then MsgBox("No Receipt Details Found!", vbCritical, "No Details Found")

            grid_receipt.DataSource = dt


        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            conn.Close()
        End Try

    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click

        Dim ans = MsgBox("Confirmed changes? Press 'Yes' to continue.", vbInformation + vbYesNo, "Proceed")
        If ans = vbYes Then

            'Validation for Numbers Only

            Try
                For i = 0 To grid_receipt.Rows.Count - 1
                    Dim ifInt = CInt(grid_receipt.Rows(i).Cells(0).Value)
                Next
            Catch ex As Exception
                MsgBox("Additional Quantity MUST contain numbers only.", vbCritical, "Not Numeric")
                Exit Sub
            End Try


            Dim store = "ims_" & frm_main.user_store.Text.Replace(" ", "_").ToLower
            Dim total As Decimal = 0.00

            Try
                conn.Open()
                Dim cmd_update_deliveries = New MySqlCommand("UPDATE ims_deliveries SET qty=@qty WHERE reference=@ref", conn)
                cmd_update_deliveries.Parameters.AddWithValue("@ref", 0)
                cmd_update_deliveries.Parameters.AddWithValue("@qty", 0)
                cmd_update_deliveries.Prepare()

                Dim cmd_update_inventory = New MySqlCommand("UPDATE " & store & " SET qty=qty+@qty WHERE pid=@pid", conn)
                cmd_update_inventory.Parameters.AddWithValue("@pid", Nothing)
                cmd_update_inventory.Parameters.AddWithValue("@qty", Nothing)
                cmd_update_inventory.Prepare()


                'Get Total Amount and Update ims_deliveries
                For i = 0 To grid_receipt.Rows.Count - 1
                    With grid_receipt.Rows(i)

                        'Get Total Quantity
                        Dim total_qty = CInt(.Cells(0).Value) + CInt(.Cells(1).Value)
                        'Get Total Amonunt
                        total += total_qty * CDec(grid_receipt.Rows(i).Cells(4).Value)

                        'Update ims_deliveries | Update Qty
                        cmd_update_deliveries.Parameters(0).Value = CInt(.Cells(5).Value)
                        cmd_update_deliveries.Parameters(1).Value = total_qty
                        cmd_update_deliveries.ExecuteNonQuery()

                        'Update ims_store | Add to Stocks
                        cmd_update_inventory.Parameters(0).Value = .Cells(6).Value
                        cmd_update_inventory.Parameters(1).Value = CInt(.Cells(0).Value)
                        cmd_update_inventory.ExecuteNonQuery()

                    End With
                Next

                'Update ims_delivery_receipts
                Dim cmd_update_receipts = New MySqlCommand("UPDATE ims_delivery_receipts SET amount=@amount 
                        WHERE receipt_ref=@ref AND supplier_id=(SELECT id FROM ims_suppliers WHERE supplier=@supplier) AND receipt_type=@type", conn)
                cmd_update_receipts.Parameters.AddWithValue("@ref", txt_ref.Text)
                cmd_update_receipts.Parameters.AddWithValue("@supplier", cbb_suppliers.Text)
                cmd_update_receipts.Parameters.AddWithValue("@type", cbb_type.Text)
                cmd_update_receipts.Parameters.AddWithValue("@amount", total)
                cmd_update_receipts.ExecuteNonQuery()

                MsgBox("Successfully Updated and Added to Stocks!", vbInformation, "Status")

            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            Finally
                conn.Close()
                btn_open.PerformClick()
            End Try

        End If

    End Sub
End Class