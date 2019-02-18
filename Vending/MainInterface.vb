Public Class MainInterface
    Private Sub MainInterface_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        keypad_btn.FlatStyle = FlatStyle.Flat
        keypad_btn.BackColor = Color.Transparent
        keypad_btn.FlatAppearance.BorderSize = 0
        keypad_btn.FlatAppearance.MouseOverBackColor = Color.Transparent
        keypad_btn.FlatAppearance.MouseDownBackColor = Color.Transparent
    End Sub

    Private Sub keypad_btn_Click(sender As Object, e As EventArgs) Handles keypad_btn.Click
        Keypad.Show()
    End Sub
End Class