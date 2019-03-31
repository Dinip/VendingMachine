Public Class admin
    Private Sub admin_Load(sender As Object, e As EventArgs) Handles Me.Load
        updateprices()
        updatestocks()
    End Sub

    Sub updateprices()
        price_lbl.Text = "Prices: "
        ' Loop to display prices on label
        For num As Integer = 1 To 30
            If num < 10 Then
                price_lbl.Text = price_lbl.Text & vbNewLine & "0" & num & " => " & FormatNumber(price(num), 2) & "€"
            Else
                price_lbl.Text = price_lbl.Text & vbNewLine & num & " => " & FormatNumber(price(num), 2) & "€"
            End If
        Next
    End Sub

    Sub updatestocks()
        stock_lbl.Text = "Stocks: "
        ' Loop to display stocks on label
        For num As Integer = 1 To 30
            If num < 10 Then
                If stock(num) < 10 Then
                    stock_lbl.Text = stock_lbl.Text & vbNewLine & "0" & num & " => " & "0" & stock(num) & " artigos"
                Else
                    stock_lbl.Text = stock_lbl.Text & vbNewLine & "0" & num & " => " & stock(num) & " artigos"
                End If
            Else
                If stock(num) < 10 Then
                    stock_lbl.Text = stock_lbl.Text & vbNewLine & num & " => " & "0" & stock(num) & " artigos"
                Else
                    stock_lbl.Text = stock_lbl.Text & vbNewLine & num & " => " & stock(num) & " artigos"
                End If
            End If
        Next
    End Sub

    Private Sub restock_btn_Click(sender As Object, e As EventArgs) Handles restock_btn.Click
        ' Manual random stock manager
        MainInterface.stocks(10)
        updatestocks()
    End Sub
End Class