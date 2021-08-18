Imports System.IO
Imports System.Net
Imports DevExpress.XtraGrid
Imports MySql.Data.MySqlClient
Imports Renci.SshNet

Public Class frm_product_catalogue

    ReadOnly conn As New MySqlConnection(str)
    Dim rdr As MySqlDataReader



    '--- On LOAD ----
    Private Sub frm_inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    'Shown
    Private Sub frm_product_masterlist_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        panel_side.Hide()
        Init()
    End Sub




    '--- FUNCTIONS ----

    'Initializes Data
    Private Sub Init()
        grid_catalogue_view.ShowLoadingPanel()
        bgw_load_catalogue.RunWorkerAsync(frm_main.user_store.Text)
    End Sub

    'bgw_load.DoWork 
    Private Sub bgw_load_catalogue_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgw_load_catalogue.DoWork
        LoadInventory(e.Argument.ToString)
    End Sub

    'bgw_load.RunWorkerCompleted
    Private Sub bgw_load_catalogue_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgw_load_catalogue.RunWorkerCompleted
        grid_catalogue_view.HideLoadingPanel()
        setPriceBooks()
        col_my_qty.Visible = False
        col_onhold_qty.Visible = False
        col_other_qty.Visible = False
    End Sub

    'Access for btn_update
    Private Sub access_update_button()
        Dim user_type_id = frm_main.user_role_id.Text
        If user_type_id = 6 Or user_type_id = 1 Then
            btn_update.Visible = True
        Else
            btn_update.Visible = False
        End If
    End Sub

    'Load Inventory
    Private Sub LoadInventory(store_name As String)

        Dim STORE = "ims_" & store_name.ToLower.Replace(" ", "_")
        Dim tables As String() = get_all_store_tables(STORE).ToString().Split(New Char() {","c})
        Dim query = String.Empty, left_join = String.Empty

        For i = 0 To tables.Length - 2
            query += "IFNULL(" & tables(i) & ".qty, 0)"
            left_join += "LEFT JOIN " & tables(i) & " ON ims_inventory.pid=" & tables(i) & ".pid "
            If Not i = tables.Length - 2 Then
                query += " + "
            End If
        Next

        Dim str = "SELECT ims_inventory.pid, barcode,
                    winmodel, description, technical_description,
                    base_price, cost, discount, regular_price, dealer_price, vip_price,
                    main_category, sub_category, brand, tags, hazards,
                    length, width, height, weight,
                    serialized, warranty_period, warranty_coverage,
                    status, (" & query & ") as other_qty, IFNULL(" & STORE & ".qty,0) as qty, IFNULL(" & STORE & ".on_hold,0) as onhold 
                    FROM `ims_inventory` 
                    LEFT JOIN " & STORE & " ON ims_inventory.pid=" & STORE & ".pid " & left_join & "
                    WHERE NOT status = 'For Approval'"

        Try
            conn.Open()
            Dim cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()

            Dim dt = New DataTable
            Dim da = New MySqlDataAdapter(cmd)
            da.Fill(dt)

            grid_catalogue.Invoke(Sub()
                                      grid_catalogue.DataSource = dt
                                  End Sub)


        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            conn.Close()
        End Try

    End Sub

    'Get All Tables
    Private Function get_all_store_tables(MyStore As String) As Object
        Dim table As String = String.Empty
        Try
            Try
                conn.Open()
                Using mySqlDataReader = New MySqlCommand("SELECT store_name FROM ims_stores", conn).ExecuteReader()
                    While mySqlDataReader.Read()
                        Dim str As String = String.Concat("ims_", mySqlDataReader("store_name").ToString().ToLower().Replace(" ", "_"))
                        If Not str.Equals(MyStore) Then
                            table = String.Concat(table, str, ",")
                        End If
                    End While
                End Using
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        Finally
            conn.Close()
        End Try

        Return table

    End Function

    'Set View for Dealer and VIP Price Books
    Private Sub setPriceBooks()
        Dim id As Integer = frm_main.user_role_id.Text

        If Not id = 7 And Not id = 1 Then
            col_dealer_price.Visible = False
            col_vip_price.Visible = False
        End If

    End Sub

    'Set Photo from server
    Private Sub setImage(FileName As String)

        Using client As New SftpClient(My.Settings.FTPserver, My.Settings.FTPusername, My.Settings.FTPpass)

            Try
                client.Connect()
                Dim ms As New MemoryStream
                client.DownloadFile("./" & My.Settings.folder_product & "/" & FileName & ".jpg", ms)

                If Not ms.Length = 0 Then
                    pb_product.Invoke(Sub()
                                          pb_product.Image = Image.FromStream(ms)
                                      End Sub)
                Else
                    pb_product.Invoke(Sub()
                                          pb_product.Image = Nothing
                                      End Sub)
                End If

            Catch ex As Exception
            End Try

        End Using

    End Sub





    '--- CONTROLS ----

    'btn_update
    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        rowHandle = grid_catalogue_view.FocusedRowHandle
        frm_product_new.UpdateInformation(lbl_pid.Text, "masterlist")
    End Sub

    'btn_print
    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click
        grid_catalogue.ShowPrintPreview()
    End Sub

    'View Details
    Private Sub ims_InventoryView_FocusedRowObjectChanged(sender As Object, e As Views.Base.FocusedRowObjectChangedEventArgs) Handles grid_catalogue_view.FocusedRowObjectChanged
        If panel_side.Visible = True Then
            If Not String.IsNullOrEmpty(grid_catalogue_view.GetRowCellValue(grid_catalogue_view.FocusedRowHandle, "pid")) Then

                If grid_catalogue_view.RowCount > 0 Then

                    With grid_catalogue_view
                        lbl_pid.Text = .GetRowCellValue(.FocusedRowHandle, "pid")
                        txt_status.Text = .GetRowCellValue(.FocusedRowHandle, "status")
                        txt_barcode.Text = .GetRowCellValue(.FocusedRowHandle, "barcode")
                        txt_winmodel.Text = .GetRowCellValue(.FocusedRowHandle, "winmodel")
                        txt_description.Text = .GetRowCellValue(.FocusedRowHandle, "description")
                        txt_retail_price.Text = .GetRowCellValue(.FocusedRowHandle, "regular_price")

                        txt_main_category.Text = .GetRowCellValue(.FocusedRowHandle, "main_category")
                        txt_sub_category.Text = .GetRowCellValue(.FocusedRowHandle, "sub_category")
                        txt_brand.Text = .GetRowCellValue(.FocusedRowHandle, "brand")

                        txt_tags.Text = .GetRowCellValue(.FocusedRowHandle, "tags")
                        txt_hazards.Text = .GetRowCellValue(.FocusedRowHandle, "hazards")

                        If Not IsDBNull(.GetRowCellValue(.FocusedRowHandle, "length")) Then txt_length.Text = .GetRowCellValue(.FocusedRowHandle, "length") Else txt_length.Text = ""
                        If Not IsDBNull(.GetRowCellValue(.FocusedRowHandle, "width")) Then txt_width.Text = .GetRowCellValue(.FocusedRowHandle, "width") Else txt_width.Text = ""
                        If Not IsDBNull(.GetRowCellValue(.FocusedRowHandle, "height")) Then txt_height.Text = .GetRowCellValue(.FocusedRowHandle, "height") Else txt_height.Text = ""
                        If Not IsDBNull(.GetRowCellValue(.FocusedRowHandle, "weight")) Then txt_weight.Text = .GetRowCellValue(.FocusedRowHandle, "weight") Else txt_weight.Text = ""
                        If Not IsDBNull(.GetRowCellValue(.FocusedRowHandle, "warranty_period")) Then txt_warranty.Text = .GetRowCellValue(.FocusedRowHandle, "warranty_period") & " Months - " & .GetRowCellValue(.FocusedRowHandle, "warranty_coverage") Else txt_warranty.Text = ""

                        'Set Image to Picture Box
                        pb_product.Image = Nothing
                        Dim thread = New Threading.Thread(Sub()
                                                              setImage(.GetFocusedRowCellValue(col_pid).ToString)
                                                          End Sub)
                        thread.Start()

                    End With



                End If
            End If
        End If

    End Sub

    'btn_details # Show Details Panel
    Private Sub btn_details_Click(sender As Object, e As EventArgs) Handles btn_details.Click

        If panel_side.Visible = False Then
            panel_side.Show()
            access_update_button()
        Else
            panel_side.Hide()
        End If

    End Sub

    'View More Details
    Private Sub lbl_view_more_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_view_more.LinkClicked
        Dim more_description As String = grid_catalogue_view.GetFocusedRowCellValue("technical_description")
        Dim frmProductDetail As New frm_product_details()
        frmProductDetail.txt_details.Text = more_description
        frmProductDetail.Show()
        frmProductDetail.txt_details.DeselectAll()
    End Sub

    'View Stocks
    Private Sub sw_view_stocks_Toggled(sender As Object, e As EventArgs) Handles sw_view_stocks.Toggled
        If sw_view_stocks.EditValue = True Then
            col_my_qty.Visible = True
            col_onhold_qty.Visible = True
            col_other_qty.Visible = True
        ElseIf sw_view_stocks.EditValue = False Then
            col_my_qty.Visible = False
            col_onhold_qty.Visible = False
            col_other_qty.Visible = False
        End If
    End Sub

End Class

