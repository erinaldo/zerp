Imports DevExpress.XtraPrinting
Imports MySql.Data.MySqlClient

Public Class frm_product_inventory

    ReadOnly conn As New MySqlConnection(str)

    '--- ON LOAD ---
    Private Sub frm_product_inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MyStore()
        LoadAllStore()
    End Sub



    '--- FUNCTIONS ----

    'MyStore Inventory
    Private Sub MyStore()
        Try
            conn.Open()
            Dim my_store = "ims_" & frm_main.user_store.Text.Trim.Replace(" ", "_").ToLower
            Dim query = "SELECT ims_inventory.pid, winmodel, description, " & my_store & ".qty, " & my_store & ".on_hold FROM ims_inventory INNER JOIN " & my_store & " ON ims_inventory.pid=" & my_store & ".pid"

            Dim cmd_grid = New MySqlCommand(query, conn)
            cmd_grid.ExecuteNonQuery()

            Dim dt = New DataTable
            Dim da = New MySqlDataAdapter(cmd_grid)
            da.Fill(dt)

            grid_mystore.DataSource = dt


        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            conn.Close()
        End Try
    End Sub


    'Load ALL Store's Inventory
    Private Sub LoadAllStore()
        Try
            Dim stores_qty = String.Empty
            Dim stores_onhold = "0"
            Dim left_join = String.Empty

            Using connection = New MySqlConnection(str)
                connection.Open()

                'GET ALL STORES tables
                Using cmd = New MySqlCommand("SELECT store_name FROM ims_stores", connection)
                    Using rdr = cmd.ExecuteReader
                        While rdr.Read
                            Dim STORE = rdr("store_name")
                            stores_qty += ", ims_" & STORE.ToLower.Replace(" ", "_") & ".qty as '" & STORE.Replace("Winland ", "") & "'"
                            stores_onhold = String.Concat(stores_onhold, " + ", "IFNULL(ims_" & STORE.ToLower.Replace(" ", "_") & ".on_hold, 0)")
                            left_join += " LEFT JOIN ims_" & STORE.ToLower.Replace(" ", "_") & " ON ims_inventory.pid=" & "ims_" & STORE.ToLower.Replace(" ", "_") & ".pid"
                        End While
                    End Using
                End Using

                'GET DATA FROM ALL STORES
                Dim query = "SELECT ims_inventory.pid AS 'PID', winmodel AS Model, description as Description, (" & stores_onhold & ") AS 'On-Hold'" & stores_qty & " FROM ims_inventory" & left_join
                Using cmd_grid = New MySqlCommand(query, connection)
                    Dim dt = New DataTable
                    Dim da = New MySqlDataAdapter(cmd_grid)
                    da.Fill(dt)
                    grid_all.DataSource = dt
                End Using

                'FORMAT DISPLAY
                grid_all_view.Columns(0).OptionsColumn.FixedWidth = True
                grid_all_view.Columns(0).Width = 100
                grid_all_view.Columns(0).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                grid_all_view.Columns(1).OptionsColumn.FixedWidth = True
                grid_all_view.Columns(1).Width = 200

                For i = 3 To grid_all_view.Columns.Count - 1
                    grid_all_view.Columns(i).OptionsColumn.FixedWidth = True
                    grid_all_view.Columns(i).Width = 120
                    grid_all_view.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                Next

            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'btn_print 
    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click

        If TabPane.SelectedPageIndex = 0 Then
            grid_mystore_view.ShowPrintPreview()
        Else TabPane.SelectedPageIndex = 1
            grid_all_view.ShowPrintPreview()
        End If

    End Sub

    'btn_export
    Private Sub btn_export_Click(sender As Object, e As EventArgs) Handles btn_export.Click

        If TabPane.SelectedPageIndex = 0 Then
            Try

                Dim saveFileDialog = New SaveFileDialog
                saveFileDialog.Filter = "Excel File (*.xlsx*)|*.xlsx"

                If saveFileDialog.ShowDialog = DialogResult.OK Then

                    grid_mystore_view.OptionsView.ShowHorizontalLines = False
                    grid_mystore_view.OptionsView.ShowVerticalLines = False
                    grid_mystore_view.ExportToXlsx(saveFileDialog.FileName)
                End If

            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error Occured")
            End Try


        Else TabPane.SelectedPageIndex = 1
            Try

                Dim saveFileDialog = New SaveFileDialog
                saveFileDialog.Filter = "Excel File (*.xlsx*)|*.xlsx"

                If saveFileDialog.ShowDialog = DialogResult.OK Then

                    grid_all_view.OptionsView.ShowHorizontalLines = False
                    grid_all_view.OptionsView.ShowVerticalLines = False
                    grid_all_view.ExportToXlsx(saveFileDialog.FileName)
                End If

            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error Occured")
            End Try
        End If

    End Sub

End Class