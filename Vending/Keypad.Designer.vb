<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Keypad
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.keypad_screen_lbl = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'keypad_screen_lbl
        '
        Me.keypad_screen_lbl.BackColor = System.Drawing.Color.Transparent
        Me.keypad_screen_lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.keypad_screen_lbl.Cursor = System.Windows.Forms.Cursors.No
        Me.keypad_screen_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.keypad_screen_lbl.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.keypad_screen_lbl.Location = New System.Drawing.Point(80, 92)
        Me.keypad_screen_lbl.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.keypad_screen_lbl.Name = "keypad_screen_lbl"
        Me.keypad_screen_lbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.keypad_screen_lbl.Size = New System.Drawing.Size(186, 42)
        Me.keypad_screen_lbl.TabIndex = 0
        Me.keypad_screen_lbl.Text = "Label1"
        Me.keypad_screen_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Keypad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Vending.My.Resources.Resources.only_pad
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(342, 633)
        Me.Controls.Add(Me.keypad_screen_lbl)
        Me.Name = "Keypad"
        Me.Text = "Keypad"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents keypad_screen_lbl As Label
End Class
