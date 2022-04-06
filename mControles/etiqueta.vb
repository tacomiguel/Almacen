Public Class etiqueta
    Public Property texto() As String
        Get
            Return mEtiqueta.Text
        End Get
        Set(ByVal value As String)
            mEtiqueta.Text = value
        End Set
    End Property

    Private Sub mEtiqueta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mEtiqueta.Click

    End Sub
End Class
