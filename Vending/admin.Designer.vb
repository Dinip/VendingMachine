<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class admin
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
        Me.stock_lbl = New System.Windows.Forms.Label()
        Me.restock_btn = New System.Windows.Forms.Button()
        Me.price_lbl = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'stock_lbl
        '
        Me.stock_lbl.BackColor = System.Drawing.Color.Transparent
        Me.stock_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stock_lbl.ForeColor = System.Drawing.SystemColors.Control
        Me.stock_lbl.Location = New System.Drawing.Point(220, 9)
        Me.stock_lbl.Name = "stock_lbl"
        Me.stock_lbl.Size = New System.Drawing.Size(125, 502)
        Me.stock_lbl.TabIndex = 0
        '
        'restock_btn
        '
        Me.restock_btn.BackColor = System.Drawing.Color.Gray
        Me.restock_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.restock_btn.ForeColor = System.Drawing.SystemColors.Control
        Me.restock_btn.Location = New System.Drawing.Point(109, 9)
        Me.restock_btn.Name = "restock_btn"
        Me.restock_btn.Size = New System.Drawing.Size(89, 69)
        Me.restock_btn.TabIndex = 1
        Me.restock_btn.Text = "Restock Machine"
        Me.restock_btn.UseVisualStyleBackColor = False
        '
        'price_lbl
        '
        Me.price_lbl.BackColor = System.Drawing.Color.Transparent
        Me.price_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.price_lbl.ForeColor = System.Drawing.SystemColors.Control
        Me.price_lbl.Location = New System.Drawing.Point(12, 9)
        Me.price_lbl.Name = "price_lbl"
        Me.price_lbl.Size = New System.Drawing.Size(81, 502)
        Me.price_lbl.TabIndex = 2
        '
        'admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.ClientSize = New System.Drawing.Size(338, 520)
        Me.Controls.Add(Me.price_lbl)
        Me.Controls.Add(Me.restock_btn)
        Me.Controls.Add(Me.stock_lbl)
        Me.Name = "admin"
        Me.Text = "Admin Interface"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents stock_lbl As Label
    Friend WithEvents restock_btn As Button
    Friend WithEvents price_lbl As Label
End Class
