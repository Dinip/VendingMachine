Public Class admin
    Private Sub admin_Load(sender As Object, e As EventArgs) Handles Me.Load
        updateprices()
        updatestocks()
    End Sub

    Sub updateprices()
        price_lbl.Text = "Prices: "
        ' Loop to display prices on label
        For num As Integer = 1 To 13
            price_lbl.Text = price_lbl.Text & vbNewLine & num & " => " & price(num) & "€"
        Next
    End Sub

    Sub updatestocks()
        stock_lbl.Text = "Stocks: "
        ' Loop to display stocks on label
        For num As Integer = 1 To 13
            stock_lbl.Text = stock_lbl.Text & vbNewLine & num & " => " & stock(num)
        Next
    End Sub

    Private Sub restock_btn_Click(sender As Object, e As EventArgs) Handles restock_btn.Click
        ' Manual random stock manager
        MainInterface.stocks(10)
        updatestocks()
    End Sub
End Class