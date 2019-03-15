Public Class admin
    Private Sub admin_Load(sender As Object, e As EventArgs) Handles Me.Load
        'stock_lbl.Text = "Stocks:" & vbNewLine & "1 => " & stock(1) & vbNewLine & "2 => " & stock(2) & vbNewLine & "3 => " & stock(3) & vbNewLine & "4 => " & stock(4) & vbNewLine & "5 => " & stock(5) & vbNewLine & "6 => " & stock(6) & vbNewLine & "7 => " & stock(7) & vbNewLine & "8 => " & stock(8) & vbNewLine & "9 => " & stock(9) & vbNewLine & "10 => " & stock(10) & vbNewLine & "11 => " & stock(11) & vbNewLine & "12 => " & stock(12) & vbNewLine & "13 => " & stock(13)
        price_lbl.Text = "Prices:" & vbNewLine & "1 => " & price(1) & vbNewLine & "2 => " & price(2) & vbNewLine & "3 => " & price(3) & vbNewLine & "4 => " & price(4) & vbNewLine & "5 => " & price(5) & vbNewLine & "6 => " & price(6) & vbNewLine & "7 => " & price(7) & vbNewLine & "8 => " & price(8) & vbNewLine & "9 => " & price(9) & vbNewLine & "10 => " & price(10) & vbNewLine & "11 => " & price(11) & vbNewLine & "12 => " & price(12) & vbNewLine & "13 => " & price(13)
        For num As Integer = 1 To 13
            stock_lbl.Text = stock_lbl.Text & vbNewLine & num & " => " & stock(num)
        Next
    End Sub

    Private Sub restock_btn_Click(sender As Object, e As EventArgs) Handles restock_btn.Click

        ' Stock manager
        MainInterface.stocks(10)
        stock_lbl.Text = "Stocks:" & vbNewLine & "1 => " & stock(1) & vbNewLine & "2 => " & stock(2) & vbNewLine & "3 => " & stock(3) & vbNewLine & "4 => " & stock(4) & vbNewLine & "5 => " & stock(5) & vbNewLine & "6 => " & stock(6) & vbNewLine & "7 => " & stock(7) & vbNewLine & "8 => " & stock(8) & vbNewLine & "9 => " & stock(9) & vbNewLine & "10 => " & stock(10) & vbNewLine & "11 => " & stock(11) & vbNewLine & "12 => " & stock(12) & vbNewLine & "13 => " & stock(13)
    End Sub
End Class