﻿Imports MySql.Data.MySqlClient
Imports Newtonsoft.Json

Public Class frm_sales_return_new

    Dim model_AutoCompleteString As New AutoCompleteStringCollection
    Dim description_AutoCompleteString As New AutoCompleteStringCollection


    '--- ONLOAD ---

    Private Sub frm_sales_return_new_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_AutoCompleteString()
        LoadCustomers()
        cbb_customer.Select()
        If frm_main.user_role_id.Text = "1" Then grid_return.Columns(3).ReadOnly = False
    End Sub





    '--- FUNCTION ----

    'Load AutoComplete String
    Private Sub Load_AutoCompleteString()

        Dim STORE_TABLE = "ims_" & frm_main.user_store.Text.ToLower.Replace(" ", "_")

        Try
            Using conn = New MySqlConnection(str)
                conn.Open()
                Dim query = "SELECT ims_inventory.winmodel, ims_inventory.description FROM " & STORE_TABLE & " RIGHT JOIN ims_inventory ON " & STORE_TABLE & ".pid=ims_inventory.pid"
                Dim cmd = New MySqlCommand(query, conn)
                Dim rdr As MySqlDataReader = cmd.ExecuteReader

                model_AutoCompleteString.Clear()
                description_AutoCompleteString.Clear()

                While rdr.Read
                    model_AutoCompleteString.Add(rdr("winmodel"))
                    description_AutoCompleteString.Add(rdr("description"))
                End While
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'Load Customers
    Public Sub LoadCustomers()

        Try
            Using conn = New MySqlConnection(str)
                conn.Open()
                Dim cmd = New MySqlCommand("SELECT first_name FROM ims_customers WHERE is_deleted='0'", conn)
                Dim rdr As MySqlDataReader = cmd.ExecuteReader

                While rdr.Read
                    cbb_customer.Properties.Items.Add(rdr("first_name"))
                End While

                'Set to None
                cbb_customer.SelectedIndex = -1

            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    'Clear
    Private Sub ClearFields()
        cbb_customer.SelectedIndex = -1
        txt_customer_id.Text = String.Empty
        lbl_account_type.Text = String.Empty
        grid_return.Rows.Clear()
        lbl_total.Text = FormatCurrency(0)
    End Sub

    'Compute Total 
    Public Sub ComputeTotal()
        Try
            Dim sub_total As Decimal

            For Each row As DataGridViewRow In grid_return.Rows
                sub_total += row.Cells(4).Value
            Next

            lbl_total.Text = FormatCurrency(sub_total)

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'Digits Only
    Private Sub DigitsOnly_KeyPress(sender As Object, e As KeyPressEventArgs)

        If grid_return.CurrentCell.ColumnIndex = 0 Then

            If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = "." Then
                e.Handled = True
            End If

        End If
    End Sub

    'Edit Sales Return
    Public Sub LoadEdit(id As Integer)

        Try
            Using conn = New MySqlConnection(str)
                conn.Open()
                Dim status = String.Empty, orders = String.Empty

                Using rdr = New MySqlCommand("SELECT ims_customers.first_name AS customer, units, store_id, status  
                            FROM ims_sales_returns 
                            LEFT JOIN ims_customers ON ims_customers.customer_id=ims_sales_returns.customer_id
                            WHERE sales_return_id=" & id, conn).ExecuteReader
                    While rdr.Read
                        txt_srid.Text = id
                        cbb_customer.Text = rdr("customer")
                        lbl_store_id.Text = rdr("store_id")
                        status = rdr("status")
                        orders = rdr("units")
                    End While
                End Using

                'Set Items to Grid
                Dim itemsObject = JsonConvert.DeserializeObject(Of List(Of SalesReturnClass))(orders)
                For Each item In itemsObject
                    Using cmd = New MySqlCommand("SELECT purchase_date FROM ims_sales " &
                                                 "WHERE item=@item AND customer=@customer
                                                 ORDER BY purchase_date DESC
                                                 LIMIT 1", conn)
                        cmd.Parameters.AddWithValue("@item", item.pid)
                        cmd.Parameters.AddWithValue("@customer", txt_customer_id.Text)
                        Using rdr = cmd.ExecuteReader
                            If rdr.HasRows Then
                                rdr.Read()
                                grid_return.Rows.Add(item.qty, item.model, item.description, item.unit_price, item.total_amount, item.pid, rdr("purchase_date"))
                            Else
                                grid_return.Rows.Add(item.qty, item.model, item.description, item.unit_price, item.total_amount, item.pid, "-- NOT FOUND --")
                            End If
                        End Using
                    End Using
                Next

                'Get Total
                ComputeTotal()

                'Update GUI for EDITING
                Me.Text = "Edit Sales Return"
                lbl_title.Text = "Edit Sales Return"
                lbl_action.Text = "Edit"
                btn_create.Visible = False
                btn_clear.Visible = False
                btn_update.Visible = True
                btn_delete.Visible = True
                btn_update.Location = btn_create.Location
                btn_delete.Location = btn_clear.Location
                cbb_customer.ReadOnly = True

                If status.Equals("Approved") Then
                    grid_return.ReadOnly = True
                    grid_return.AllowUserToAddRows = False
                End If

            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'Get Account Type Table
    Private Function GetAccountTypeTable()
        Dim account_type = ""

        Select Case lbl_account_type.Text
            Case "Regular" : account_type = "regular_price"
            Case "Dealer" : account_type = "dealer_price"
            Case "VIP" : account_type = "vip_price"
            Case "Sister Company" : account_type = "cost"
        End Select

        Return account_type

    End Function




    '--- CONTROLS ----

    'Editing Grid
    Private Sub grid_return_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles grid_return.EditingControlShowing

        AddHandler DirectCast(e.Control, TextBox).KeyPress, New KeyPressEventHandler(AddressOf DigitsOnly_KeyPress)

        If Not (grid_return.CurrentCell.ColumnIndex = 1 Or grid_return.CurrentCell.ColumnIndex = 2) Then
            Dim control As TextBox = TryCast(e.Control, TextBox)
            If control IsNot Nothing Then
                control.AutoCompleteMode = AutoCompleteMode.None
            End If
        Else
            Dim txt As TextBox = DirectCast(e.Control, TextBox)
            If Not grid_return.CurrentCell.ColumnIndex = 1 Then
                If grid_return.CurrentCell.ColumnIndex = 2 Then
                    If txt IsNot Nothing Then
                        txt.AutoCompleteMode = AutoCompleteMode.SuggestAppend
                        txt.AutoCompleteSource = AutoCompleteSource.CustomSource
                        txt.AutoCompleteCustomSource = description_AutoCompleteString
                    End If
                End If
            ElseIf txt IsNot Nothing Then
                txt.AutoCompleteMode = AutoCompleteMode.SuggestAppend
                txt.AutoCompleteSource = AutoCompleteSource.CustomSource
                txt.AutoCompleteCustomSource = model_AutoCompleteString
                txt.CharacterCasing = CharacterCasing.Upper
            End If
        End If

    End Sub

    'Grid Cell End
    Private Sub grid_return_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles grid_return.CellEndEdit

        If e.ColumnIndex.Equals(1) Then

            'If No Value or Empty Cell Found
            If String.IsNullOrEmpty(grid_return.CurrentCell.Value) Then Exit Sub

            Try
                Using conn = New MySqlConnection(str)
                    conn.Open()

                    Dim cmd = New MySqlCommand("SELECT item, inv.winmodel, inv.description, purchase_date, inv." & GetAccountTypeTable() &
                                               " FROM ims_sales
                                                LEFT JOIN ims_inventory inv ON inv.pid=ims_sales.item
                                                WHERE inv.winmodel=@winmodel AND customer=@customer_id
                                                ORDER BY purchase_date DESC
                                                LIMIT 1", conn)
                    cmd.Parameters.AddWithValue("@winmodel", grid_return.CurrentCell.Value)
                    cmd.Parameters.AddWithValue("@customer_id", txt_customer_id.Text)
                    Dim rdr As MySqlDataReader = cmd.ExecuteReader

                    If rdr.HasRows Then
                        While rdr.Read
                            'grid_order.Rows(e.RowIndex).Cells(0).Value = 1
                            grid_return.Rows(e.RowIndex).Cells(1).Value = rdr("winmodel").ToString.ToUpper
                            grid_return.Rows(e.RowIndex).Cells(2).Value = rdr("description")
                            Dim cost As Decimal = rdr(GetAccountTypeTable())
                            grid_return.Rows(e.RowIndex).Cells(3).Value = cost.ToString("n2")
                            grid_return.Rows(e.RowIndex).Cells(5).Value = rdr("item")
                            grid_return.Rows(e.RowIndex).Cells(6).Value = rdr("purchase_date")
                        End While
                    Else
                        MsgBox("No last order found!", vbCritical, "Not found")
                    End If

                End Using
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try
        End If

        If e.ColumnIndex.Equals(2) Then

            'If No Value or Empty Cell Found
            If String.IsNullOrEmpty(grid_return.CurrentCell.Value) Then Exit Sub

            Try
                Using conn = New MySqlConnection(str)
                    conn.Open()

                    Dim cmd = New MySqlCommand("SELECT item, inv.winmodel, inv.description, purchase_date, inv." & GetAccountTypeTable() &
                                               " FROM ims_sales
                                                LEFT JOIN ims_inventory inv ON inv.pid=ims_sales.item
                                                WHERE inv.description=@description AND customer=@customer_id
                                                ORDER BY purchase_date DESC
                                                LIMIT 1", conn)
                    cmd.Parameters.AddWithValue("@description", grid_return.CurrentCell.Value)
                    cmd.Parameters.AddWithValue("@customer_id", txt_customer_id.Text)
                    Dim rdr As MySqlDataReader = cmd.ExecuteReader

                    While rdr.Read

                        'grid_order.Rows(e.RowIndex).Cells(0).Value = 1
                        grid_return.Rows(e.RowIndex).Cells(1).Value = rdr("winmodel").ToString.ToUpper
                        grid_return.Rows(e.RowIndex).Cells(2).Value = rdr("description")
                        Dim cost As Decimal = rdr(GetAccountTypeTable())
                        grid_return.Rows(e.RowIndex).Cells(3).Value = cost.ToString("n2")
                        grid_return.Rows(e.RowIndex).Cells(5).Value = rdr("item")
                        grid_return.Rows(e.RowIndex).Cells(6).Value = rdr("purchase_date")
                    End While
                End Using
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try
        End If

        If e.ColumnIndex.Equals(0) Or e.ColumnIndex.Equals(3) Or e.ColumnIndex.Equals(4) Then
            If String.IsNullOrEmpty(grid_return.Rows(e.RowIndex).Cells(1).Value) Then Return

            grid_return.Rows(e.RowIndex).Cells(3).Value = CDec(grid_return.Rows(e.RowIndex).Cells(3).Value)
            grid_return.Rows(e.RowIndex).Cells(4).Value = CDec(grid_return.Rows(e.RowIndex).Cells(0).Value * grid_return.Rows(e.RowIndex).Cells(3).Value)
        End If

        'Compute Total
        ComputeTotal()

    End Sub

    'Clear Button
    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        ClearFields()
    End Sub

    'Create Button
    Private Sub btn_create_Click(sender As Object, e As EventArgs) Handles btn_create.Click

        'VALIDATION
        If cbb_customer.SelectedIndex = -1 Or grid_return.Rows.Count < 0 Then
            MsgBox("Incomplete fields!", vbCritical, "Incomplete")
            Return
        End If

        If MsgBox("Press 'YES' to confirm.", vbYesNo + vbInformation, "Confirmation") = vbYes Then
                    Dim ListOfUnits = New List(Of SalesReturnClass)
            For i = 0 To grid_return.RowCount - 2
                ListOfUnits.Add(New SalesReturnClass With {
                .qty = grid_return.Rows(i).Cells(0).Value,
                .model = grid_return.Rows(i).Cells(1).Value,
                .description = grid_return.Rows(i).Cells(2).Value,
                .unit_price = grid_return.Rows(i).Cells(3).Value,
                .total_amount = grid_return.Rows(i).Cells(4).Value,
                .pid = grid_return.Rows(i).Cells(5).Value
            })
            Next

            Try
                Using connection = New MySqlConnection(str)
                    connection.Open()
                    Using cmd = New MySqlCommand("INSERT INTO ims_sales_returns (customer_id, units, amount, status, store_id, created_by, created_at) 
                                    VALUES ((SELECT customer_id FROM ims_customers WHERE first_name=@customer), @units, @amount, 'Pending', (SELECT store_id FROM ims_stores WHERE store_name=@store_id),  @created_by, NOW())", connection)
                        cmd.Parameters.AddWithValue("@customer", cbb_customer.Text)
                        cmd.Parameters.AddWithValue("@units", JsonConvert.SerializeObject(ListOfUnits))
                        cmd.Parameters.AddWithValue("@amount", CDec(lbl_total.Text))
                        cmd.Parameters.AddWithValue("@store_id", frm_main.user_store.Text)
                        cmd.Parameters.AddWithValue("@created_by", frm_main.user_id.Text)
                        If cmd.ExecuteNonQuery() = 1 Then
                            MsgBox("Successfully Added!", vbInformation, "Information")
                            ClearFields()
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try
        End If

    End Sub

    'Update/Save Button
    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click

        'VALIDATION
        If cbb_customer.SelectedIndex = -1 Or grid_return.Rows.Count < 0 Then
            MsgBox("Incomplete fields!", vbCritical, "Incomplete")
            Return
        End If

        If MsgBox("Press 'YES' to confirm.", vbYesNo + vbInformation, "Confirmation") = vbYes Then
            Dim ListOfUnits = New List(Of SalesReturnClass)
            For i = 0 To grid_return.RowCount - 2
                ListOfUnits.Add(New SalesReturnClass With {
                .qty = grid_return.Rows(i).Cells(0).Value,
                .model = grid_return.Rows(i).Cells(1).Value,
                .description = grid_return.Rows(i).Cells(2).Value,
                .unit_price = grid_return.Rows(i).Cells(3).Value,
                .total_amount = grid_return.Rows(i).Cells(4).Value,
                .pid = grid_return.Rows(i).Cells(5).Value
            })
            Next

            Try
                Using connection = New MySqlConnection(str)
                    connection.Open()
                    Using cmd = New MySqlCommand("UPDATE ims_sales_returns SET units=@units, amount=@amount WHERE sales_return_id=" & txt_srid.Text, connection)
                        cmd.Parameters.AddWithValue("@units", JsonConvert.SerializeObject(ListOfUnits))
                        cmd.Parameters.AddWithValue("@amount", CDec(lbl_total.Text))
                        If cmd.ExecuteNonQuery() = 1 Then
                            MsgBox("Saved!", vbInformation, "Information")
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try
        End If

    End Sub

    'Link to Sales Return List
    Private Sub link_sales_return_Click(sender As Object, e As EventArgs) Handles link_sales_return.Click
        frm_main.LoadFrm(New frm_sales_return)
    End Sub

    'Delete Button
    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If MsgBox("Delete this Sales Return?" & Environment.NewLine & Environment.NewLine & "Press 'YES' to Delete.", vbYesNo + vbQuestion, "Confirmation") = vbYes Then
            Try
                Using connection = New MySqlConnection(str)
                    connection.Open()
                    Using cmd = New MySqlCommand("UPDATE ims_sales_returns SET is_deleted=1 WHERE sales_return_id=" & txt_srid.Text, connection)
                        If cmd.ExecuteNonQuery() = 1 Then
                            MsgBox("Deleted!", vbInformation, "Information")
                            frm_main.LoadFrm(New frm_sales_return)
                            Me.Close()
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try
        End If
    End Sub

    'Customer List
    Private Sub cbb_customer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbb_customer.SelectedIndexChanged
        If cbb_customer.SelectedIndex = -1 Then Return
        Try
            Using conn = New MySqlConnection(str)
                conn.Open()
                Using cmd = New MySqlCommand("SELECT customer_id, account_type FROM ims_customers WHERE first_name=@customer", conn)
                    cmd.Parameters.AddWithValue("@customer", cbb_customer.Text)
                    Using rdr = cmd.ExecuteReader
                        rdr.Read()
                        txt_customer_id.Text = rdr("customer_id")
                        lbl_account_type.Text = rdr("account_type")
                    End Using
                End Using

                'RESTRICT OTHER USER FROM CREATING WITH SISTER COMPANY
                If lbl_account_type.Text.Equals("Sister Company") Then
                    Dim current_user As String = frm_main.user_role_id.Text
                    If Not (current_user = "1" Or current_user = "2" Or current_user = "3" Or current_user = "4" Or current_user = "6") Then
                        MsgBox("Insufficient priviledge!" & Environment.NewLine & "Kindly contact your administrator.", MsgBoxStyle.Critical, "Forbidden")
                        ClearFields()
                        Return
                    End If
                End If

            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub grid_return_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles grid_return.RowsRemoved
        ComputeTotal()
    End Sub

    Private Sub btn_approved_Click(sender As Object, e As EventArgs) Handles btn_approved.Click
        Try
            Using conn = New MySqlConnection(str)
                conn.Open()
                Using cmd = New MySqlCommand("UPDATE ims_sales_returns SET status='Approved' WHERE sales_return_id=" & txt_srid.Text, conn)
                    If cmd.ExecuteNonQuery = 1 Then

                        'INSERT TO ims_sales_approved_returns
                        Using cmd_returns = New MySqlCommand("INSERT ims_sales_approved_returns (pid, qty, store_id, sr_id, status) 
                                                VALUES (@pid, @qty, @store_id, @sr_id, 'Pending')", conn)
                            cmd_returns.Parameters.AddWithValue("@pid", Nothing)
                            cmd_returns.Parameters.AddWithValue("@qty", Nothing)
                            cmd_returns.Parameters.AddWithValue("@store_id", Nothing)
                            cmd_returns.Parameters.AddWithValue("@sr_id", Nothing)
                            cmd_returns.Prepare()

                            For i = 0 To grid_return.Rows.Count - 2
                                cmd_returns.Parameters(0).Value = grid_return.Rows(i).Cells(5).Value
                                cmd_returns.Parameters(1).Value = grid_return.Rows(i).Cells(0).Value
                                cmd_returns.Parameters(2).Value = lbl_store_id.Text
                                cmd_returns.Parameters(3).Value = txt_srid.Text
                                cmd_returns.ExecuteNonQuery()
                            Next

                        End Using

                        MsgBox("Approved!", vbInformation, "Information")
                        Me.Close()
                        frm_main.LoadFrm(New frm_admin_approval)

                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub
End Class