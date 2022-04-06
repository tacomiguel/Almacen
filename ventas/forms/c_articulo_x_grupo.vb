Imports libreriaClases
Imports MySql.Data.MySqlClient
Imports System.Data
Public Class c_articulo_x_grupo
    Private ds As DataSet = grupo.dsGrupo
    Private dtGrupo As DataTable
    Private Sub data_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgsubgrupo.CellContentClick

    End Sub
    Private Sub c_articulo_x_grupo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtBuscar_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscar.GotFocus
        general.ingresaTexto(txtBuscar)
    End Sub

    Private Sub txtBuscar_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscar.LostFocus
        general.saleTexto(txtBuscar)
    End Sub

    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged

    End Sub
End Class
