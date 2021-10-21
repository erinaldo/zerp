Imports System.Text
Imports System.IO
Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography

Module functions

    ReadOnly conn As New MySqlConnection(str)
    Public Property rowHandle As Integer


    'TEST CONNECTION
    Public Function TestConnection()

        Try
            conn.Open()
            Return False

        Catch ex As Exception
            MsgBox("Couldn't connect to server!" & Environment.NewLine & "Please contact your Administrator." & vbCrLf & vbCrLf & "Error: " & ex.Message, vbCritical, "Connection Problem")
            Return True
        Finally
            conn.Close()
        End Try

    End Function

    'Role Access
    Public Sub role_access(role_id As Integer)

        Try
            Dim result = New StringBuilder

            conn.Open()
            Dim cmd = New MySqlCommand("SELECT access FROM ims_users WHERE usr_id=@id", conn)
            cmd.Parameters.AddWithValue("@id", role_id)
            Dim var As String = cmd.ExecuteScalar

            result.Append(var)

            'Hide All Menu
            With frm_main
                .menu_product.Visible = False
                .menu_sales.Visible = False
                .menu_warehouse.Visible = False
                .menu_collections.Visible = False
                .menu_logistics.Visible = False
                .menu_purchasing.Visible = False
                .menu_accounting.Visible = False
                .menu_administration.Visible = False

                If String.IsNullOrEmpty(result.ToString) Then Exit Sub
                Dim access = result.Replace(";", "", result.Length - 1, 1).ToString.Split(";")

                For i = 0 To access.Count - 1

                    Select Case access(i)

                        'Product
                        Case "catalogue"
                            .menu_product.Visible = True
                            .submenu_catalogue.Visible = True
                        Case "inventory"
                            .menu_product.Visible = True
                            .submenu_inventory.Visible = True
                        Case "new_item"
                            .menu_product.Visible = True
                            .submenu_new_item.Visible = True
                        Case "import_catalogue"
                            .menu_product.Visible = True
                            .submenu_import_catalogue.Visible = True
                        Case "export_catalogue"
                            .menu_product.Visible = True
                            .submenu_export_catalogue.Visible = True

                        'Sales
                        Case "orders"
                            .menu_sales.Visible = True
                            .submenu_orders.Visible = True
                        Case "quotations"
                            .menu_sales.Visible = True
                            .submenu_quotations.Visible = True
                        Case "create_order"
                            .menu_sales.Visible = True
                            .submenu_create_order.Visible = True
                        Case "customers"
                            .menu_sales.Visible = True
                            .submenu_customers.Visible = True
                        Case "packing_list"
                            .menu_sales.Visible = True
                            .submenu_packing_list.Visible = True
                        Case "transaction_invoice"
                            .menu_sales.Visible = True
                            .submenu_invoices.Visible = True
                        Case "logistics"
                            .menu_sales.Visible = True
                            .submenu_logistics.Visible = True

                        'Warehouse
                        Case "daily_delivery"
                            .menu_warehouse.Visible = True
                            .submenu_daily_delivery.Visible = True
                        Case "delivery_logs"
                            .menu_warehouse.Visible = True
                            .submenu_delivery_logs.Visible = True
                        Case "stock_management"
                            .menu_warehouse.Visible = True
                            .submenu_stock_management.Visible = True
                        Case "stock_inventory"
                            .menu_warehouse.Visible = True
                            .submenu_stocks_inventory.Visible = True

                        'Collections
                        Case "order_payments"
                            .menu_collections.Visible = True
                            .submenu_payments.Visible = True
                        Case "new_cheque_payment"
                            .menu_collections.Visible = True
                            .submenu_payment_new.Visible = True
                        Case "cheque_book"
                            .menu_collections.Visible = True
                            .submenu_cheque_book.Visible = True
                        Case "statement_of_account"
                            .menu_collections.Visible = True
                            .submenu_soa.Visible = True

                        'Logistics
                        Case "pickup_deliveries"
                            .menu_logistics.Visible = True
                            .submenu_pick_deliveries.Visible = True

                        'Purchasing
                        Case "new_purchase"
                            .menu_purchasing.Visible = True
                            .submenu_purchasing_new.Visible = True
                        Case "purchase_orders"
                            .menu_purchasing.Visible = True
                            .submenu_purchasing_orders.Visible = True

                        'Accounting
                        Case "account_payables"
                            .menu_accounting.Visible = True
                            .submenu_account_payables.Visible = True
                        Case "generate"
                            .menu_accounting.Visible = True
                            .submenu_generate.Visible = True
                        Case "payment_vouchers"
                            .menu_accounting.Visible = True
                            .submenu_payment_vouchers.Visible = True
                        Case "payment_cheques"
                            .menu_accounting.Visible = True
                            .submenu_payment_cheques.Visible = True

                        'Administration
                        Case "user_accounts"
                            .menu_administration.Visible = True
                            .submenu_user_accounts.Visible = True
                        Case "approvals"
                            .menu_administration.Visible = True
                            .submenu_approvals.Visible = True
                        Case "price_book"
                            .menu_administration.Visible = True
                            .submenu_price_books.Visible = True
                        Case "reports"
                            .menu_administration.Visible = True
                            .submenu_reports.Visible = True
                        Case "stores"
                            .menu_administration.Visible = True
                            .submenu_warehouse.Visible = True
                        Case "suppliers"
                            .menu_administration.Visible = True
                            .submenu_suppliers.Visible = True
                        Case "settings"
                            .menu_administration.Visible = True
                            .submenu_settings.Visible = True

                    End Select
                Next

            End With

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error Found")
        Finally
            conn.Close()
        End Try



    End Sub

    'Encrypt Password
    Public Function Encrypt(clearText As String) As String
        Dim EncryptionKey As String = "MAKV2SPBNI99212"
        Dim clearBytes As Byte() = Encoding.Unicode.GetBytes(clearText)
        Using encryptor As Aes = Aes.Create()
            Dim pdb As New Rfc2898DeriveBytes(EncryptionKey, New Byte() {&H49, &H76, &H61, &H6E, &H20, &H4D,
             &H65, &H64, &H76, &H65, &H64, &H65,
             &H76})
            encryptor.Key = pdb.GetBytes(32)
            encryptor.IV = pdb.GetBytes(16)
            Using ms As New MemoryStream()
                Using cs As New CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write)
                    cs.Write(clearBytes, 0, clearBytes.Length)
                    cs.Close()
                End Using
                clearText = Convert.ToBase64String(ms.ToArray())
            End Using
        End Using
        Return clearText
    End Function

    'Decrypt Password
    Public Function Decrypt(cipherText As String) As String
        Dim EncryptionKey As String = "MAKV2SPBNI99212"
        Dim cipherBytes As Byte() = Convert.FromBase64String(cipherText)
        Using encryptor As Aes = Aes.Create()
            Dim pdb As New Rfc2898DeriveBytes(EncryptionKey, New Byte() {&H49, &H76, &H61, &H6E, &H20, &H4D,
             &H65, &H64, &H76, &H65, &H64, &H65,
             &H76})
            encryptor.Key = pdb.GetBytes(32)
            encryptor.IV = pdb.GetBytes(16)
            Using ms As New MemoryStream()
                Using cs As New CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write)
                    cs.Write(cipherBytes, 0, cipherBytes.Length)
                    cs.Close()
                End Using
                cipherText = Encoding.Unicode.GetString(ms.ToArray())
            End Using
        End Using
        Return cipherText
    End Function

    'Payment Logs
    Public Sub Insert_PaymentLog(connection As MySqlConnection, payment_date As Date, order_id As Integer, customer As String,
                                  current_balance As Decimal, payment As Decimal, balance As Decimal, payment_gateway As String, payment_ref As String)
        'Try
        Using connection
            Using cmd = New MySqlCommand("INSERT INTO ims_payment_logs (payment_date, order_id, customer_id, current_balance, payment, balance, payment_gateway, payment_ref)
                                            VALUES (@payment_date, @order_id, (SELECT customer_id FROM ims_customers WHERE first_name=@customer), @current_balance, @payment, @balance, @payment_gateway, @payment_ref)", connection)
                cmd.Parameters.AddWithValue("@payment_date", payment_date)
                cmd.Parameters.AddWithValue("@order_id", order_id)
                cmd.Parameters.AddWithValue("@customer", customer)
                cmd.Parameters.AddWithValue("@current_balance", current_balance)
                cmd.Parameters.AddWithValue("@payment", payment)
                cmd.Parameters.AddWithValue("@balance", balance)
                cmd.Parameters.AddWithValue("@payment_gateway", payment_gateway)
                cmd.Parameters.AddWithValue("@payment_ref", payment_ref)
                cmd.ExecuteNonQuery()
            End Using
        End Using
        Try
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub
End Module

'Objects for Items
Public Class cheques
    Public Property bank As String
    Public Property cheque_date As Date
    Public Property cheque_no As String
    Public Property amount As Decimal
End Class
