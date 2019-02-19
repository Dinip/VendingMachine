Imports System.ComponentModel

Public Class Coins_Insert
    Dim saldo As Single
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
    End Sub

    Private Sub btn1c_Click(sender As Object, e As EventArgs) Handles btn1c.Click
        saldo = saldo + 0.01
        saldo_lbl.Text = "+0,01 €" & vbNewLine & "Saldo: " & saldo & "€"
    End Sub

    Private Sub btn2c_Click(sender As Object, e As EventArgs) Handles btn2c.Click
        saldo = saldo + 0.02
        saldo_lbl.Text = "+0,02 €" & vbNewLine & "Saldo: " & saldo & "€"
    End Sub

    Private Sub btn5c_Click(sender As Object, e As EventArgs) Handles btn5c.Click
        saldo = saldo + 0.05
        saldo_lbl.Text = "+0,05 €" & vbNewLine & "Saldo: " & saldo & "€"
    End Sub

    Private Sub btn10c_Click(sender As Object, e As EventArgs) Handles btn10c.Click
        saldo = saldo + 0.1
        saldo_lbl.Text = "+0,10 €" & vbNewLine & "Saldo: " & saldo & "€"
    End Sub

    Private Sub btn20c_Click(sender As Object, e As EventArgs) Handles btn20c.Click
        saldo = saldo + 0.2
        saldo_lbl.Text = "+0,20 €" & vbNewLine & "Saldo: " & saldo & "€"
    End Sub

    Private Sub btn50c_Click(sender As Object, e As EventArgs) Handles btn50c.Click
        saldo = saldo + 0.5
        saldo_lbl.Text = "+0,50 €" & vbNewLine & "Saldo: " & saldo & "€"
    End Sub

    Private Sub btn1e_Click(sender As Object, e As EventArgs) Handles btn1e.Click
        saldo = saldo + 1
        saldo_lbl.Text = "+1,00 €" & vbNewLine & "Saldo: " & saldo & "€"
    End Sub

    Private Sub btn2e_Click(sender As Object, e As EventArgs) Handles btn2e.Click
        saldo = saldo + 2
        saldo_lbl.Text = "+2,00 €" & vbNewLine & "Saldo: " & saldo & "€"
    End Sub

    Private Sub btn_clear_saldo_Click(sender As Object, e As EventArgs) Handles btn_clear_saldo.Click
        saldo = 0
        saldo_lbl.Text = "0,00 €" & vbNewLine & "Saldo: " & saldo & "€"
    End Sub

    Private Sub Coins_Insert_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        MainInterface.Controls("saldo_lbl").Text = saldo
    End Sub
End Class