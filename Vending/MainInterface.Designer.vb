<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainInterface
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
        Me.keypad_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'keypad_btn
        '
        Me.keypad_btn.BackColor = System.Drawing.Color.Transparent
        Me.keypad_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.keypad_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.keypad_btn.FlatAppearance.BorderSize = 0
        Me.keypad_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.keypad_btn.Location = New System.Drawing.Point(588, 290)
        Me.keypad_btn.Name = "keypad_btn"
        Me.keypad_btn.Size = New System.Drawing.Size(66, 148)
        Me.keypad_btn.TabIndex = 0
        Me.keypad_btn.UseVisualStyleBackColor = False
        '
        'MainInterface
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Vending.My.Resources.Resources.vending_ps_render_low_res
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(684, 888)
        Me.Controls.Add(Me.keypad_btn)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Name = "MainInterface"
        Me.Text = "MainInterface"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents keypad_btn As Button
End Class
