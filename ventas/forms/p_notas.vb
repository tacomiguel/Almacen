Public Class p_notas
    Private _form As String
    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub p_notas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Sub datosNotas(ByVal obs As String, ByVal form As String)
        Me._form = form
        txtnotas.Text = obs
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        If _form = "orden" Then
            p_ordencompra.AgregaObservacion(txtnotas.Text)

        End If
        If _form = "venta" Then
            p_ventas.AgregaObservacion(txtnotas.Text)
        End If

        If _form = "pedido" Then
            p_pedido.AgregaObservacion(txtnotas.Text)
        End If

        Me.Close()
    End Sub
End Class
