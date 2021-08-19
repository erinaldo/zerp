Imports MySql.Data.MySqlClient

Public Class frm_sales_customers

    ReadOnly conn As New MySqlConnection(str)


    '--- ONLOAD ----
    Private Sub frm_customers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadGrid()
    End Sub


    '--- FUNCTION ----
    Private Sub LoadGrid()
        conn.Open()
        Dim cmd = New MySqlCommand("SELECT *, (credit_limit - used_credit) AS remaining_credit FROM ims_customers", conn)
        cmd.ExecuteNonQuery()

        Dim dt = New DataTable
        Dim da = New MySqlDataAdapter(cmd)
        da.Fill(dt)

        grid_customer.DataSource = dt
    End Sub



    '--- CONTROLS ----

    'btn_new
    Private Sub btn_new_Click(sender As Object, e As EventArgs)

        frm_sales_customers_new.ShowDialog()
        frm_main.LoadFrm(New frm_sales_customers)

    End Sub

    'btn_edit
    Private Sub btn_edit_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btn_edit.ButtonClick

        Dim frm = New frm_sales_customers_new

        With gridview_customer
            frm.lbl_title.Text = "Edit Customer Info"
            frm.lbl_customer_id.Text = .GetFocusedRowCellValue(col_id)
            frm.txt_fname.Text = .GetFocusedRowCellValue(col_fname)
            frm.txt_contact_person.Text = .GetFocusedRowCellValue(col_contact_person)
            frm.cbb_account_type.Text = .GetFocusedRowCellValue(col_type)
            frm.txt_contact.Text = .GetFocusedRowCellValue(col_contact)
            frm.txt_address.Text = .GetFocusedRowCellValue(col_addr)
            frm.cbb_shipping.Text = .GetFocusedRowCellValue(col_shipping)
            frm.txt_trucking.Text = .GetFocusedRowCellValue(col_trucking)
            frm.num_terms.Value = .GetFocusedRowCellValue(col_terms)
            frm.cbb_shipping.Text = .GetFocusedRowCellValue(col_shipping)
            frm.txt_credit_limit.Text = .GetFocusedRowCellValue(col_credit_limit)
            frm.LoadSheet(IIf(IsDBNull(.GetFocusedRowCellValue(col_other_notes)), "", .GetFocusedRowCellValue(col_other_notes)))
            frm.txt_fname.Enabled = False

            'Access for Admin
            If frm_main.user_role_id.Text = 1 Then
                frm.lbl_credit_limit.Visible = True
                frm.txt_credit_limit.Visible = True
                frm.LabelControl2.Visible = True
                frm.num_terms.Visible = True
                frm.cbb_account_type.Enabled = True
            End If

        End With

        Dim res = frm.ShowDialog()
        If res = DialogResult.OK Then
            frm_main.LoadFrm(New frm_sales_customers)
        End If

    End Sub

End Class