Public Class frm_accounting_view_transaction


    Public Property is_vatable As Boolean = False
    Public Property amount As Decimal = 0.00


    'btn_close
    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    'Onload
    Private Sub frm_accounting_view_transaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim sub_total As Decimal = 0.00

        'Get Subtotal
        For i = 0 To grid_transaction_view.RowCount - 1
            sub_total += grid_transaction_view.GetRowCellValue(i, col_total_cost)
        Next

        If is_vatable Then
            lbl_vatables_sales.Text = FormatCurrency(amount / 1.12)
            lbl_12_vat.Text = FormatCurrency((amount / 1.12) * 0.12)
        Else
            lbl_vatables_sales.Text = String.Empty
            lbl_12_vat.Text = String.Empty
        End If

        txt_sub_total.Text = FormatCurrency(sub_total)

    End Sub

End Class