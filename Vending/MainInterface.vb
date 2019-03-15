Public Class MainInterface
    Private Sub MainInterface_Load(sender As Object, e As EventArgs) Handles Me.Load
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
        admin_btn.FlatStyle = FlatStyle.Flat
        admin_btn.BackColor = Color.Transparent
        admin_btn.FlatAppearance.BorderSize = 0
        admin_btn.FlatAppearance.MouseOverBackColor = Color.Transparent
        admin_btn.FlatAppearance.MouseDownBackColor = Color.Transparent

        ' Sets default saldo (0€)
        saldo = 0
        saldo_lbl.Text = saldo & "€"

        ' Sets prices
        price(1) = 1.2
        price(2) = 1.35
        price(3) = 1.35
        price(4) = 1.35
        price(5) = 1.35
        price(6) = 1.15
        price(7) = 1.15
        price(8) = 1.25
        price(9) = 0.9
        price(10) = 0.9
        price(11) = 0.9
        price(12) = 1.05
        price(13) = 1.45

        ' Stock manager (just to set random default stocks, admin interface has a button to restock)
        stocks(10)
    End Sub

    Sub stocks(ByVal rand As Integer)
        Randomize()
        For num As Integer = 1 To 13
            stock(num) = Int((rand * Rnd()) + 1)
        Next
    End Sub

    Private Sub keys_btn_Click(sender As Object, e As EventArgs) Handles keys_btn.Click
        Keypad.Show()
    End Sub

    Private Sub coin_in_btn_Click(sender As Object, e As EventArgs) Handles coin_in_btn.Click
        Coins_Insert.Show()
    End Sub

    Private Sub coin_out_btn_Click(sender As Object, e As EventArgs) Handles coin_out_btn.Click
        My.Computer.Audio.Play(My.Resources.coin_drop, AudioPlayMode.WaitToComplete)
        MsgBox("Troco de " & saldo & "€ recebido.")
        saldo = 0
        saldo_lbl.Text = saldo & "€"
    End Sub

    Private Sub admin_btn_Click(sender As Object, e As EventArgs) Handles admin_btn.Click
        Dim password As String
        password = InputBox("Insira a password de administração:")
        If password = "ai" Then
            admin.Show()
        Else
            MsgBox("Password errada! Tente novamente.")
        End If
    End Sub
End Class