Public Class frm_accounting_view_transaction

    'btn_close
    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    'Onload
    Private Sub frm_accounting_view_transaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim sub_total As Decimal = 0.00
        For i = 0 To grid_transaction_view.RowCount - 1
            sub_total += grid_transaction_view.GetRowCellValue(i, col_total_cost)
        Next

        txt_sub_total.Text = FormatCurrency(sub_total)

    End Sub

End Class