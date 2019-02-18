Public Class MainInterface
    Dim selection As Integer
    Private Sub MainInterface_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        keys_btn.FlatStyle = FlatStyle.Flat
        keys_btn.BackColor = Color.Transparent
        keys_btn.FlatAppearance.BorderSize = 0
        keys_btn.FlatAppearance.MouseOverBackColor = Color.Transparent
        keys_btn.FlatAppearance.MouseDownBackColor = Color.Transparent
    End Sub

    Private Sub keys_btn_Click(sender As Object, e As EventArgs) Handles keys_btn.Click
        Keypad.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        selection = keypad_screen_lbl.Text
    End Sub
End Class

'extra stuff
'Dim obj As New Keypad
'keypad_screen_lbl.Text = obj.numero