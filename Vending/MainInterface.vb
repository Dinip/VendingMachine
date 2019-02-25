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
End Class

'extra stuff
'Dim obj As New Keypad
'keypad_screen_lbl.Text = obj.numero