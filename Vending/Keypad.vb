Imports System.ComponentModel

Public Class Keypad
    Dim instock As Boolean = True
    Dim hasmoney As Boolean = True
    Dim found As Boolean = True

    Private Sub Keypad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' WIP keypad_screen_lbl.Text = numero
        ' Label prop changing to default values
        keypad_screen_lbl.Font = New Font("Microsoft Sans Serif", 32, FontStyle.Bold)
        keypad_screen_lbl.TextAlign = ContentAlignment.MiddleCenter

        ' Button 1
        btn1.FlatStyle = FlatStyle.Flat
        btn1.BackColor = Color.Transparent
        btn1.FlatAppearance.BorderSize = 0
        btn1.FlatAppearance.MouseOverBackColor = Color.Transparent
        btn1.FlatAppearance.MouseDownBackColor = Color.Transparent

        ' Button 2
        btn2.FlatStyle = FlatStyle.Flat
        btn2.BackColor = Color.Transparent
        btn2.FlatAppearance.BorderSize = 0
        btn2.FlatAppearance.MouseOverBackColor = Color.Transparent
        btn2.FlatAppearance.MouseDownBackColor = Color.Transparent

        ' Button 3
        btn3.FlatStyle = FlatStyle.Flat
        btn3.BackColor = Color.Transparent
        btn3.FlatAppearance.BorderSize = 0
        btn3.FlatAppearance.MouseOverBackColor = Color.Transparent
        btn3.FlatAppearance.MouseDownBackColor = Color.Transparent

        ' Button 4
        btn4.FlatStyle = FlatStyle.Flat
        btn4.BackColor = Color.Transparent
        btn4.FlatAppearance.BorderSize = 0
        btn4.FlatAppearance.MouseOverBackColor = Color.Transparent
        btn4.FlatAppearance.MouseDownBackColor = Color.Transparent

        ' Button 5
        btn5.FlatStyle = FlatStyle.Flat
        btn5.BackColor = Color.Transparent
        btn5.FlatAppearance.BorderSize = 0
        btn5.FlatAppearance.MouseOverBackColor = Color.Transparent
        btn5.FlatAppearance.MouseDownBackColor = Color.Transparent

        ' Button 6
        btn6.FlatStyle = FlatStyle.Flat
        btn6.BackColor = Color.Transparent
        btn6.FlatAppearance.BorderSize = 0
        btn6.FlatAppearance.MouseOverBackColor = Color.Transparent
        btn6.FlatAppearance.MouseDownBackColor = Color.Transparent

        ' Button 7
        btn7.FlatStyle = FlatStyle.Flat
        btn7.BackColor = Color.Transparent
        btn7.FlatAppearance.BorderSize = 0
        btn7.FlatAppearance.MouseOverBackColor = Color.Transparent
        btn7.FlatAppearance.MouseDownBackColor = Color.Transparent

        ' Button 8
        btn8.FlatStyle = FlatStyle.Flat
        btn8.BackColor = Color.Transparent
        btn8.FlatAppearance.BorderSize = 0
        btn8.FlatAppearance.MouseOverBackColor = Color.Transparent
        btn8.FlatAppearance.MouseDownBackColor = Color.Transparent

        ' Button 9
        btn9.FlatStyle = FlatStyle.Flat
        btn9.BackColor = Color.Transparent
        btn9.FlatAppearance.BorderSize = 0
        btn9.FlatAppearance.MouseOverBackColor = Color.Transparent
        btn9.FlatAppearance.MouseDownBackColor = Color.Transparent

        ' Button 0
        btn0.FlatStyle = FlatStyle.Flat
        btn0.BackColor = Color.Transparent
        btn0.FlatAppearance.BorderSize = 0
        btn0.FlatAppearance.MouseOverBackColor = Color.Transparent
        btn0.FlatAppearance.MouseDownBackColor = Color.Transparent

        ' Button X
        btnX.FlatStyle = FlatStyle.Flat
        btnX.BackColor = Color.Transparent
        btnX.FlatAppearance.BorderSize = 0
        btnX.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnX.FlatAppearance.MouseDownBackColor = Color.Transparent

        ' Button C
        btnC.FlatStyle = FlatStyle.Flat
        btnC.BackColor = Color.Transparent
        btnC.FlatAppearance.BorderSize = 0
        btnC.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnC.FlatAppearance.MouseDownBackColor = Color.Transparent


        ' Button OK
        btnOK.FlatStyle = FlatStyle.Flat
        btnOK.BackColor = Color.Transparent
        btnOK.FlatAppearance.BorderSize = 0
        btnOK.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnOK.FlatAppearance.MouseDownBackColor = Color.Transparent

    End Sub

    Sub clear()
        If (found = False) Or (instock = False) Or (hasmoney = False) Then
            keypad_screen_lbl.Text = ""
            Me.Refresh()
            keypad_screen_lbl.Font = New Font("Microsoft Sans Serif", 32, FontStyle.Bold)
            keypad_screen_lbl.TextAlign = ContentAlignment.MiddleCenter
            found = True
            instock = True
            hasmoney = True
        End If
    End Sub

    Sub updatelbl()
        MainInterface.Controls("keypad_screen_lbl").Text = keypad_screen_lbl.Text
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        clear()
        keypad_screen_lbl.Text = keypad_screen_lbl.Text + "1"
        updatelbl()
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        clear()
        keypad_screen_lbl.Text = keypad_screen_lbl.Text + "2"
        updatelbl()
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        clear()
        keypad_screen_lbl.Text = keypad_screen_lbl.Text + "3"
        updatelbl()
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        clear()
        keypad_screen_lbl.Text = keypad_screen_lbl.Text + "4"
        updatelbl()
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        clear()
        keypad_screen_lbl.Text = keypad_screen_lbl.Text + "5"
        updatelbl()
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        clear()
        keypad_screen_lbl.Text = keypad_screen_lbl.Text + "6"
        updatelbl()
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        clear()
        keypad_screen_lbl.Text = keypad_screen_lbl.Text + "7"
        updatelbl()
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        clear()
        keypad_screen_lbl.Text = keypad_screen_lbl.Text + "8"
        updatelbl()
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        clear()
        keypad_screen_lbl.Text = keypad_screen_lbl.Text + "9"
        updatelbl()
    End Sub

    Private Sub btnX_Click(sender As Object, e As EventArgs) Handles btnX.Click
        Me.Close()
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        clear()
        keypad_screen_lbl.Text = keypad_screen_lbl.Text + "0"
        updatelbl()
    End Sub

    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        clear()
        keypad_screen_lbl.Text = ""
        updatelbl()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim counter As Integer = 1000
        clear()
        ' Sets var numero equals to label val
        numero = Val(keypad_screen_lbl.Text)

        'Text font and alignment ajusts 
        keypad_screen_lbl.Font = New Font("Microsoft Sans Serif", 16, FontStyle.Bold)
        keypad_screen_lbl.TextAlign = ContentAlignment.MiddleLeft

        ' Verifies if the number isn't outside of the allowed range.
        If (numero < 1) Or (numero > 13) Then
            keypad_screen_lbl.Text = "Item não" & vbNewLine & "encontrado!"
            found = False
            MainInterface.Controls("keypad_screen_lbl").Text = ""
        Else
            keypad_screen_lbl.Text = "Preço: " & price(numero) & " €"
            ' Verifies if the price isn't higher than the balance
            If price(numero) > saldo Then
                keypad_screen_lbl.Text = "Artigo: " & numero & vbNewLine & "Saldo insuficiente" & vbNewLine & "Insira " & price(numero) & "€"
                hasmoney = False
                ' If there is not enough money, open coins_insert
                'Coins_Insert.Show()
            Else
                ' Verifies if the stock ins't lower than 1
                If stock(numero) < 1 Then
                    keypad_screen_lbl.Text = "Stock insuficiente."
                    instock = False
                Else
                    keypad_screen_lbl.Text = keypad_screen_lbl.Text & vbNewLine & "Compra sucedida!"
                    Me.Refresh()
                    stock(numero) -= 1
                    saldo -= price(numero)
                    My.Computer.Audio.Play(My.Resources.mario, AudioPlayMode.WaitToComplete)
                    MainInterface.Controls("saldo_lbl").Text = FormatNumber(saldo, 2) & "€"

                    ' Counter just to delay form closing after buy complete
                    While counter > 0
                        counter = counter - 0.75
                    End While

                    Me.Close()
                End If
            End If
        End If
    End Sub

    'Needs fix. Change if to variables
    Private Sub Keypad_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If (keypad_screen_lbl.Text = ("Artigo: " & numero & vbNewLine & "Saldo insuficiente.")) Then
            MainInterface.Controls("keypad_screen_lbl").Text = numero
        ElseIf (keypad_screen_lbl.Text = ("Item não" & vbNewLine & "encontrado!")) Then
            MainInterface.Controls("keypad_screen_lbl").Text = ""
        Else
            MainInterface.Controls("keypad_screen_lbl").Text = ""
        End If
    End Sub
End Class