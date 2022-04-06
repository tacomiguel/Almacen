<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class etiqueta
    Inherits System.Windows.Forms.UserControl

    'UserControl1 reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.mEtiqueta = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'mEtiqueta
        '
        Me.mEtiqueta.AutoSize = True
        Me.mEtiqueta.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mEtiqueta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mEtiqueta.Location = New System.Drawing.Point(1, 1)
        Me.mEtiqueta.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.mEtiqueta.Name = "mEtiqueta"
        Me.mEtiqueta.Size = New System.Drawing.Size(72, 15)
        Me.mEtiqueta.TabIndex = 0
        Me.mEtiqueta.Text = "mEtiqueta"
        '
        'etiqueta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.mEtiqueta)
        Me.Name = "etiqueta"
        Me.Size = New System.Drawing.Size(75, 16)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mEtiqueta As System.Windows.Forms.Label

End Class
