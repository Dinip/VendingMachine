Public Class MainInterface
    Dim selection As Integer
    Private Sub MainInterface_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' coins_in_btn
        coin_in_btn.FlatStyle = FlatStyle.Flat
        coin_in_btn.BackColor = Color.Transparent
        coin_in_btn.FlatAppearance.BorderSize = 0
        coin_in_btn.FlatAppearance.MouseOverBackColor = Color.Transparent
        coin_in_btn.FlatAppearance.MouseDownBackColor = Color.Transparent

        ' keys_btn
        keys_btn.FlatStyle = FlatStyle.Flat
        keys_btn.BackColor = Color.Transparent
        keys_btn.FlatAppearance.BorderSize = 0
        keys_btn.FlatAppearance.MouseOverBackColor = Color.Transparent
        keys_btn.FlatAppearance.MouseDownBackColor = Color.Transparent

        ' coins_out_btn
        coin_out_btn.FlatStyle = FlatStyle.Flat
        coin_out_btn.BackColor = Color.Transparent
        coin_out_btn.FlatAppearance.BorderSize = 0
        coin_out_btn.FlatAppearance.MouseOverBackColor = Color.Transparent
        coin_out_btn.FlatAppearance.MouseDownBackColor = Color.Transparent

        ' stock_btn
        stocks_btn.FlatStyle = FlatStyle.Flat
        stocks_btn.BackColor = Color.Transparent
        stocks_btn.FlatAppearance.BorderSize = 0
        stocks_btn.FlatAppearance.MouseOverBackColor = Color.Transparent
        stocks_btn.FlatAppearance.MouseDownBackColor = Color.Transparent

        ' Sets default saldo (0€)
        saldo_lbl.Text = "0€"

        ' Sets prices
        items(1) = 1.2
        items(2) = 1.35
        items(3) = 1.35
        items(4) = 1.35
        items(5) = 1.35
        items(6) = 1.15
        items(7) = 1.15
        items(8) = 1.25
        items(9) = 0.9
        items(10) = 0.9
        items(11) = 0.9
        items(12) = 1.05
        items(13) = 1.45

        ' Stock manager
        stock(1) = CInt(Int((15 * Rnd()) + 1))
        stock(2) = CInt(Int((15 * Rnd()) + 1))
        stock(3) = CInt(Int((15 * Rnd()) + 1))
        stock(4) = CInt(Int((15 * Rnd()) + 1))
        stock(5) = CInt(Int((15 * Rnd()) + 1))
        stock(6) = CInt(Int((15 * Rnd()) + 1))
        stock(7) = CInt(Int((15 * Rnd()) + 1))
        stock(8) = CInt(Int((15 * Rnd()) + 1))
        stock(9) = CInt(Int((15 * Rnd()) + 1))
        stock(10) = CInt(Int((15 * Rnd()) + 1))
        stock(11) = CInt(Int((15 * Rnd()) + 1))
        stock(12) = CInt(Int((15 * Rnd()) + 1))
        stock(13) = CInt(Int((15 * Rnd()) + 1))
    End Sub

    Private Sub keys_btn_Click(sender As Object, e As EventArgs) Handles keys_btn.Click
        Keypad.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        selection = keypad_screen_lbl.Text
    End Sub

    Private Sub coin_in_btn_Click(sender As Object, e As EventArgs) Handles coin_in_btn.Click
        Coins_Insert.Show()
    End Sub

    Private Sub coin_out_btn_Click(sender As Object, e As EventArgs) Handles coin_out_btn.Click
        Coins_Remove.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles stocks_btn.Click
        MsgBox("1 => " & stock(1) & vbNewLine & "2 => " & stock(2) & vbNewLine & "3 => " & stock(3) & vbNewLine & "4 => " & stock(4) & vbNewLine & "5 => " & stock(5) & vbNewLine & "6 => " & stock(6) & vbNewLine & "7 => " & stock(7) & vbNewLine & "8 => " & stock(8) & vbNewLine & "9 => " & stock(9) & vbNewLine & "10 => " & stock(10) & vbNewLine & "11 => " & stock(11) & vbNewLine & "12 => " & stock(12) & vbNewLine & "13 => " & stock(13))
    End Sub
End Class

'extra stuff
'Dim obj As New Keypad
'keypad_screen_lbl.Text = obj.numero