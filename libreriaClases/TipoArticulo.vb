Imports libreriaClases
Imports MySql.Data.MySqlClient
Public Class TipoArticulo
    Public Shared Function dsTipoArticulo() As DataSet
        Dim ds As New DataSet
        Dim dtTipoArticulo As New DataTable("tipo_articulo")
        dtTipoArticulo.Columns.Add(New DataColumn("cod_tart", GetType(String)))
        dtTipoArticulo.Columns.Add(New DataColumn("nom_tart", GetType(String)))
        dtTipoArticulo.Columns.Add(New DataColumn("esProduccion", GetType(Boolean)))
        dtTipoArticulo.Columns.Add(New DataColumn("esCombo", GetType(Boolean)))
        dtTipoArticulo.Columns.Add(New DataColumn("activo", GetType(Boolean)))
        dtTipoArticulo.Constraints.Add("pkCod_tart", dtTipoArticulo.Columns("cod_tart"), True)
        ds.Tables.Add(dtTipoArticulo)
        Return ds
    End Function
    Public Function existeEnCatalogo(ByVal cod_tart As String) As Integer
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer, cad As String
        com.Connection = clConex
        cad = "Select cod_tart from articulo where cod_tart='" & cod_tart & "'"
        com.CommandText = cad
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), False, obj), Integer)
        clConex.Close()
        Return result
    End Function
End Class
