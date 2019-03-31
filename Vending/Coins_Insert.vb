Imports System.ComponentModel

Public Class Coins_Insert
    Private Sub Coins_Insert_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Button 1c
        btn1c.FlatStyle = FlatStyle.Flat
        btn1c.BackColor = Color.Transparent
        btn1c.FlatAppearance.BorderSize = 0
        btn1c.FlatAppearance.MouseOverBackColor = Color.Transparent
        btn1c.FlatAppearance.MouseDownBackColor = Color.Transparent

        ' Button 2c
        btn2c.FlatStyle = FlatStyle.Flat
        btn2c.BackColor = Color.Transparent
        btn2c.FlatAppearance.BorderSize = 0
        btn2c.FlatAppearance.MouseOverBackColor = Color.Transparent
        btn2c.FlatAppearance.MouseDownBackColor = Color.Transparent

        ' Button 5c
        btn5c.FlatStyle = FlatStyle.Flat
        btn5c.BackColor = Color.Transparent
        btn5c.FlatAppearance.BorderSize = 0
        btn5c.FlatAppearance.MouseOverBackColor = Color.Transparent
        btn5c.FlatAppearance.MouseDownBackColor = Color.Transparent

        ' Button 10c
        btn10c.FlatStyle = FlatStyle.Flat
        btn10c.BackColor = Color.Transparent
        btn10c.FlatAppearance.BorderSize = 0
        btn10c.FlatAppearance.MouseOverBackColor = Color.Transparent
        btn10c.FlatAppearance.MouseDownBackColor = Color.Transparent

        ' Button 20c
        btn20c.FlatStyle = FlatStyle.Flat
        btn20c.BackColor = Color.Transparent
        btn20c.FlatAppearance.BorderSize = 0
        btn20c.FlatAppearance.MouseOverBackColor = Color.Transparent
        btn20c.FlatAppearance.MouseDownBackColor = Color.Transparent

        ' Button 50c
        btn50c.FlatStyle = FlatStyle.Flat
        btn50c.BackColor = Color.Transparent
        btn50c.FlatAppearance.BorderSize = 0
        btn50c.FlatAppearance.MouseOverBackColor = Color.Transparent
        btn50c.FlatAppearance.MouseDownBackColor = Color.Transparent

        ' Button 1e
        btn1e.FlatStyle = FlatStyle.Flat
        btn1e.BackColor = Color.Transparent
        btn1e.FlatAppearance.BorderSize = 0
        btn1e.FlatAppearance.MouseOverBackColor = Color.Transparent
        btn1e.FlatAppearance.MouseDownBackColor = Color.Transparent

        ' Button 2e
        btn2e.FlatStyle = FlatStyle.Flat
        btn2e.BackColor = Color.Transparent
        btn2e.FlatAppearance.BorderSize = 0
        btn2e.FlatAppearance.MouseOverBackColor = Color.Transparent
        btn2e.FlatAppearance.MouseDownBackColor = Color.Transparent

        ' Button clear
        btn_clear_saldo.FlatStyle = FlatStyle.Flat
        btn_clear_saldo.BackColor = Color.Transparent
        btn_clear_saldo.FlatAppearance.BorderSize = 0
        btn_clear_saldo.FlatAppearance.MouseOverBackColor = Color.Transparent
        btn_clear_saldo.FlatAppearance.MouseDownBackColor = Color.Transparent

        ' Button exit
        exit_btn.FlatStyle = FlatStyle.Flat
        exit_btn.BackColor = Color.Transparent
        exit_btn.FlatAppearance.BorderSize = 0
        exit_btn.FlatAppearance.MouseOverBackColor = Color.Transparent
        exit_btn.FlatAppearance.MouseDownBackColor = Color.Transparent

        ' Sets balance label to the value on the variable
        saldo_lbl.Text = vbNewLine & "Saldo: " & FormatNumber(saldo, 2) & "€"
    End Sub

    Sub updatelbl(ByVal coin As Single)
        saldo += coin
        MainInterface.Controls("saldo_lbl").Text = FormatNumber(saldo, 2) & "€"
        saldo_lbl.Text = "+ " & FormatNumber(coin, 2) & " €" & vbNewLine & "Saldo: " & FormatNumber(saldo, 2) & "€"
    End Sub

    Private Sub btn1c_Click(sender As Object, e As EventArgs) Handles btn1c.Click
        updatelbl(0.01)
    End Sub

    Private Sub btn2c_Click(sender As Object, e As EventArgs) Handles btn2c.Click
        updatelbl(0.02)
    End Sub

    Private Sub btn5c_Click(sender As Object, e As EventArgs) Handles btn5c.Click
        updatelbl(0.05)
    End Sub

    Private Sub btn10c_Click(sender As Object, e As EventArgs) Handles btn10c.Click
        updatelbl(0.1)
    End Sub

    Private Sub btn20c_Click(sender As Object, e As EventArgs) Handles btn20c.Click
        updatelbl(0.2)
    End Sub

    Private Sub btn50c_Click(sender As Object, e As EventArgs) Handles btn50c.Click
        updatelbl(0.5)
    End Sub

    Private Sub btn1e_Click(sender As Object, e As EventArgs) Handles btn1e.Click
        updatelbl(1)
    End Sub

    Private Sub btn2e_Click(sender As Object, e As EventArgs) Handles btn2e.Click
        updatelbl(2)
    End Sub

    Private Sub btn_clear_saldo_Click(sender As Object, e As EventArgs) Handles btn_clear_saldo.Click
        saldo = 0
        updatelbl(0)
    End Sub

    Private Sub Coins_Insert_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        updatelbl(0)
    End Sub

    Private Sub exit_btn_Click(sender As Object, e As EventArgs) Handles exit_btn.Click
        updatelbl(0)
        Me.Close()
    End Sub
End Class