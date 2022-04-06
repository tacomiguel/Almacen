Public Class texto
    Private Sub mTexto_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles mTexto.GotFocus
        mTexto.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        mTexto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    End Sub

    Private Sub mTexto_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles mTexto.LostFocus
        mTexto.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        mTexto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    End Sub

    Private Sub mTexto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mTexto.TextChanged

    End Sub
    Public Property text() As String
        Get
            Return texto.text
        End Get
        Set(ByVal value As String)
            texto.text = value
        End Set
    End Property
End Class
