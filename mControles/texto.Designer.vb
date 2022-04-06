<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class texto
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.mTexto = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'mTexto
        '
        Me.mTexto.Location = New System.Drawing.Point(0, 0)
        Me.mTexto.Name = "mTexto"
        Me.mTexto.Size = New System.Drawing.Size(100, 20)
        Me.mTexto.TabIndex = 0
        '
        'texto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Controls.Add(Me.mTexto)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "texto"
        Me.Size = New System.Drawing.Size(100, 20)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mTexto As System.Windows.Forms.TextBox

End Class
