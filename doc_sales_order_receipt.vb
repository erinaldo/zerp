Imports System.Drawing.Printing

Public Class doc_sales_order_receipt

    Private Sub doc_invoice_receipt_BeforePrint(sender As Object, e As PrintEventArgs) Handles Me.BeforePrint
        If shipping_method.Value = "Pickup" Then
            lbl_shipping_addr.Visible = False
            lbl_trucking_addr.Visible = False
            XrLabel10.Visible = False
        End If

        If is_vatable.Value = False Then
            XrLabel7.Visible = True
        Else
            XrLabel7.Visible = False
        End If

    End Sub

End Class