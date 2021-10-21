Imports System.IO
Imports System.Net
Imports System.Reflection
Imports System.Text
Imports DevExpress.XtraSplashScreen
Imports MySql.Data.MySqlClient
Imports Renci.SshNet

Public Class frm_main

    ReadOnly conn As New MySqlConnection(str)

    'On Load
    Private Sub frm_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Initialize_zerp()
        Dim version As Version = Assembly.GetExecutingAssembly().GetName().Version
        Dim lbl_version = " " & version.Major.ToString & "." & version.Minor.ToString & "." & version.Build.ToString
        Me.Text = "ZERP Business Solution" & lbl_version
    End Sub



    '--- FUNCTIONS ----

    'Init
    Public Sub Initialize_zerp()

        Try

            'Show SplashScreen
            SplashScreenManager.ShowForm(Me, GetType(frm_splash_screen), True, True, False)

            'Display 'Connecting to server...'
            SplashScreenManager.Default.SendCommand(frm_splash_screen.SplashScreenCommand.set_status, "Connecting to server...")

            'Testing Server Connection
            If TestConnection() Then Exit Sub

            'Display 'Retreiving data...'
            SplashScreenManager.Default.SendCommand(frm_splash_screen.SplashScreenCommand.set_status, "Retreiving data...")

            Select Case My.Settings.login


            'If NOT login, Show Login form
                Case False

                    'Close SplashScreen
                    SplashScreenManager.CloseForm()

                    'Me.Hide()
                    frm_login.ShowDialog()


              'If login, load details
                Case True

                    'Display 'Logging in...'
                    SplashScreenManager.Default.SendCommand(frm_splash_screen.SplashScreenCommand.set_status, "Logging in...")
                    LogIn(My.Settings.login_user)

                    'Show Dialog
                    Me.Show()

                    'Display 'Setting access roles...'
                    SplashScreenManager.Default.SendCommand(frm_splash_screen.SplashScreenCommand.set_status, "Setting access roles...")
                    role_access(user_id.Text)

                    'Display 'Loading...'
                    SplashScreenManager.Default.SendCommand(frm_splash_screen.SplashScreenCommand.set_status, "Loading...")
                    LoadFrm(New frm_homepage)

                    'Close SplashScreen
                    SplashScreenManager.CloseForm()

            End Select

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            conn.Close()
        End Try

    End Sub

    'Log In
    Public Sub LogIn(username As String)

        Try
            conn.Open()
            Dim cmd = New MySqlCommand("SELECT first_name, role, ims_users.role_id, store_name, usr_id, usr_photo FROM ims_users
                                    INNER JOIN ims_stores ON ims_users.assigned_loc=ims_stores.store_id
                                    INNER JOIN ims_user_acc_types ON ims_users.role_id=ims_user_acc_types.role_id WHERE username='" & username & "'", conn)
            Dim rdr As MySqlDataReader = cmd.ExecuteReader

            While rdr.Read
                user_name.Text = rdr("first_name")
                user_role.Text = rdr("role")
                user_role_id.Text = rdr("role_id")
                user_store.Text = rdr("store_name")
                user_id.Text = rdr("usr_id")
                setUserPhoto(rdr("usr_photo"))
            End While

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            conn.Close()
        End Try

    End Sub

    'Load Form on Panel
    Public Sub LoadFrm(form As Form)
        If panel_content.Controls.Count > 0 Then
            panel_content.Controls.RemoveAt(0)
        End If

        form.TopLevel = False
        form.Dock = DockStyle.Fill
        form.FormBorderStyle = FormBorderStyle.None
        panel_content.Controls.Add(form)
        panel_content.Tag = form
        form.Show()

    End Sub

    'Set User Photo on Login
    Private Sub setUserPhoto(FileName As String)

        Using client As New SftpClient(My.Settings.FTPserver, My.Settings.FTPusername, My.Settings.FTPpass)
            Try
                client.Connect()
                Dim ms As New MemoryStream
                client.DownloadFile("./" & My.Settings.UserFolder & "/" & FileName, ms)

                If Not ms.Length = 0 Then
                    user_photo.Image = Image.FromStream(ms)
                End If
            Catch ex As Exception
            End Try
        End Using

    End Sub

    'Set User Photo on Login (Depreciated)
    Private Sub ssetUserPhoto(FileName As String)
        Dim DownloadURi = "ftp://" & My.Settings.FTPserver & ":" & My.Settings.FTPport & "/" & My.Settings.UserFolder & "/" & FileName

        'Creating Client request to download
        Dim DLReq As New WebClient With {
            .Credentials = New NetworkCredential(My.Settings.FTPusername, My.Settings.FTPpass)
        }

        Dim imgbytes() As Byte = DLReq.DownloadData(DownloadURi)

        'Setting Image bytes to PictureBox
        Dim ms As New MemoryStream(imgbytes)
        user_photo.Image = Image.FromStream(ms)

        'Memory cleaning
        DLReq.Dispose()
        'ms.Dispose()
    End Sub

    'Export Datbase
    Private Sub ExportDatabase()

        Try
            Dim saveFileDialog = New SaveFileDialog
            saveFileDialog.Filter = "CSV File (*.csv*)|*.csv"

            If saveFileDialog.ShowDialog = DialogResult.OK Then
                conn.Open()
                Dim cmd = New MySqlCommand("SELECT * FROM ims_inventory", conn)
                cmd.ExecuteNonQuery()

                Dim dt = New DataTable
                Dim da = New MySqlDataAdapter(cmd)
                da.Fill(dt)

                Dim fileContent = New StringBuilder

                For Each col As DataColumn In dt.Columns
                    fileContent.Append(col.ColumnName & ",")
                Next

                fileContent.Replace(",", System.Environment.NewLine, fileContent.Length - 1, 1)

                For Each row As DataRow In dt.Rows

                    For Each cell As Object In row.ItemArray
                        fileContent.Append(cell.ToString.Trim & ",")
                    Next

                    fileContent.Replace(",", System.Environment.NewLine, fileContent.Length - 1, 1)

                Next

                File.WriteAllText(saveFileDialog.FileName, fileContent.ToString)

            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            conn.Close()
        End Try

    End Sub







    '---- Controls -----

    'Shortcut Key to Connection
    Private Sub frm_main_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F1 And e.Modifiers = Keys.Control Then


            'Discount Approcal
            Dim pass As String = ""
            Dim frm_pass = New frm_sales_password_required
            frm_pass.Label1.Text = "Enter Admin Password to continue:"
            Dim result = frm_pass.ShowDialog()

            If Not String.IsNullOrEmpty(frm_pass.Password) Then
                pass = frm_pass.Password
                frm_pass.Dispose()
            End If


            If result = DialogResult.OK Then
                If Not pass.Equals("zerp") Or String.IsNullOrWhiteSpace(pass) Then
                    MsgBox("Password is Incorrect!", vbCritical, "Incorrect Password")
                    Exit Sub
                End If

                frm_connection_panel.ShowDialog()

            End If

        End If
    End Sub



    '-------> My Account

    'Log Out
    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        My.Settings.login = False
        My.Settings.login_user = ""
        frm_login.Show()
        Me.Hide()
    End Sub



    '--------> Catalogue
    Private Sub CatalogueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles submenu_catalogue.Click
        LoadFrm(New frm_product_catalogue)
    End Sub



    '--------> SALES 

    'Create Order
    Private Sub CreateOrderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles submenu_create_order.Click
        frm_sales_create_order.Show()
    End Sub

    'Sales Orders
    Private Sub OrdersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles submenu_orders.Click
        LoadFrm(New frm_sales_orders)
    End Sub

    'Quotations
    Private Sub submenu_quotations_Click(sender As Object, e As EventArgs) Handles submenu_quotations.Click
        LoadFrm(New frm_sales_quotation_order_list)
    End Sub

    'New Customer
    Private Sub NewCustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewCustomerToolStripMenuItem.Click
        frm_sales_customers_new.ShowDialog()
    End Sub

    'Registered Customers
    Private Sub RegisteredCustomersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegisteredCustomersToolStripMenuItem.Click
        LoadFrm(New frm_sales_customers)
    End Sub

    'Packing List
    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles submenu_packing_list.Click
        LoadFrm(New frm_sales_packing_list)
    End Sub

    'Invoice List
    Private Sub submenu_invoices_Click(sender As Object, e As EventArgs) Handles submenu_invoices.Click
        frm_sales_transaction_invoice.Show()
    End Sub

    'Sales Logistics
    Private Sub submenu_logistics_Click(sender As Object, e As EventArgs) Handles submenu_logistics.Click
        frm_sales_logistics.Show()
    End Sub




    '---------> PRODUCTS 

    'Stock Management
    Private Sub StockManagementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles submenu_stock_management.Click
        LoadFrm(New frm_warehouse_stock_transfer)
    End Sub

    'Inventory
    Private Sub InventoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles submenu_inventory.Click
        LoadFrm(New frm_product_inventory)
    End Sub

    'New Product
    Private Sub NewItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles submenu_new_item.Click
        LoadFrm(New frm_product_new)
    End Sub

    'Import
    Private Sub ImportDatabaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles submenu_import_catalogue.Click
        frm_product_import.Show()
    End Sub

    'Export Database
    Private Sub ExportDatabaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles submenu_export_catalogue.Click
        ExportDatabase()
    End Sub




    '---------> PURCHASING

    'New Purchase Order
    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles submenu_purchasing_new.Click
        LoadFrm(New frm_purchaseorder_new)
    End Sub

    'Purchase Orders
    Private Sub PurchaseOrdersToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles submenu_purchasing_orders.Click
        LoadFrm(New frm_purchaseorder_list)
    End Sub

    'Purchase Returns
    Private Sub submenu_po_returns_Click(sender As Object, e As EventArgs) Handles submenu_po_returns.Click
        LoadFrm(New frm_purchaseorder_return_list)
    End Sub




    '---------> ADMINISTRATION

    'User Accounts
    Private Sub UserAccountsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles submenu_user_accounts.Click
        LoadFrm(New frm_admin_users)
    End Sub

    'Approval
    Private Sub ApprovalsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles submenu_approvals.Click
        LoadFrm(New frm_admin_approval)
    End Sub

    'Reports
    Private Sub submenu_reports_Click(sender As Object, e As EventArgs) Handles submenu_reports.Click
        LoadFrm(New frm_admin_reports)
    End Sub

    'Banks
    Private Sub submenu_banks_Click(sender As Object, e As EventArgs) Handles submenu_banks.Click
        LoadFrm(New frm_admin_banks)
    End Sub

    'New Warehouse
    Private Sub submenu2_new_warehouse_Click(sender As Object, e As EventArgs) Handles submenu2_new_warehouse.Click
        frm_admin_store_add.ShowDialog()
    End Sub

    'Warehouse
    Private Sub submenu2_registered_warehouse_Click(sender As Object, e As EventArgs) Handles submenu2_registered_warehouse.Click
        LoadFrm(New frm_admin_stores)
    End Sub

    'New Supplier
    Private Sub NewSupplierToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles NewSupplierToolStripMenuItem.Click
        frm_admin_supplier_add.ShowDialog()
        frm_admin_supplier.Load_Supppliers()
    End Sub

    'Registered Supplier
    Private Sub RegisteredSupplierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegisteredSupplierToolStripMenuItem.Click
        LoadFrm(New frm_admin_supplier)
    End Sub

    'Price Book
    Private Sub PriceBookToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles submenu_price_books.Click
        LoadFrm(New frm_admin_price_book)
    End Sub

    'Settings
    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles submenu_settings.Click
        LoadFrm(New frm_admin_settings)
    End Sub





    '---------> Warehouse

    'Stock Inventory
    Private Sub StockLocationsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles submenu_stocks_inventory.Click
        LoadFrm(New frm_warehouse_inventory)
    End Sub

    'Daily Deliveries
    Private Sub DeliveriesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles submenu_daily_delivery.Click
        LoadFrm(New frm_warehouse_deliveries)
    End Sub

    'Delivery Logs
    Private Sub DeliveryLogsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles submenu_delivery_logs.Click
        LoadFrm(New frm_warehouse_delivery_logs)
    End Sub





    '----------> Collections

    'Payments
    Private Sub UnpaidOrdersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles submenu_payments.Click
        LoadFrm(New frm_collection_payments)
    End Sub

    'Cheque Payment
    Private Sub ChequePaymentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles submenu_payment_new.Click
        frm_collection_cheque.Show()
    End Sub

    'Cheque Book
    Private Sub ChequeBookToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles submenu_cheque_book.Click
        LoadFrm(New frm_collection_cheque_books)
    End Sub

    'Statement of Account
    Private Sub submenu_soa_Click(sender As Object, e As EventArgs) Handles submenu_soa.Click
        LoadFrm(New frm_collection_soa)
    End Sub




    '----------> Logistics

    'Pickup and Deliveries
    Private Sub PickupDeliveriesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles submenu_pick_deliveries.Click
        LoadFrm(New frm_logistics_deliveries)
    End Sub




    '----------> Accounting

    'Generate Cheque
    Private Sub ChequeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PaymentToolStripMenuItem.Click
        LoadFrm(New frm_accounting_generate_payment)
    End Sub

    'Generate Voucher
    Private Sub VoucherToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VoucherToolStripMenuItem.Click
        LoadFrm(New frm_accounting_generate_voucher)
    End Sub

    'Account Payables
    Private Sub PayablesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles submenu_account_payables.Click
        LoadFrm(New frm_accounting_payables)
    End Sub

    'Payment Vouchers
    Private Sub PaymentVouchersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles submenu_payment_vouchers.Click
        LoadFrm(New frm_accounting_payment_vouchers)
    End Sub

    'Payment Cheques
    Private Sub PaymentChequesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles submenu_payment_cheques.Click
        LoadFrm(New frm_accounting_payment_cheques)
    End Sub

    'Payment Cash
    Private Sub submenu_payment_cash_Click(sender As Object, e As EventArgs) Handles submenu_payment_cash.Click
        LoadFrm(New frm_accounting_payment_cash)
    End Sub

    'Forecast and Payables
    Private Sub submenu_ForecastAndPayablesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles submenu_ForecastAndPayablesToolStripMenuItem.Click
        LoadFrm(New frm_accounting_forecast_payables)
    End Sub

End Class
