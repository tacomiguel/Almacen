Imports libreriaClases
Imports MySql.Data.MySqlClient
Public Class subgrupo
    Public Shared Function dssubgrupo() As DataSet
        Dim ds As New DataSet
        ds.Tables.Add(crearTablasubgrupo())
        Return ds
    End Function
    Private Shared Function crearTablasubgrupo() As DataTable
        Dim dt As New DataTable("subgrupo")
        'añadimos columnas al dataset
        dt.Columns.Add("cod_sgrupo", GetType(String))
        dt.Columns.Add("cod_grupo", GetType(String))
        dt.Columns.Add("nom_sgrupo", GetType(String))
        dt.Columns.Add("cod_familia", GetType(String))
        dt.Columns.Add("esProduccion", GetType(Boolean))
        dt.Columns.Add("esVenta", GetType(Boolean))
        dt.Columns.Add("repInventario", GetType(Boolean))
        dt.Columns.Add("repFiscal", GetType(Boolean))
        dt.Columns.Add("repGerencia", GetType(Boolean))
        dt.Columns.Add("activo", GetType(Boolean))
        dt.Columns.Add("f_color", GetType(String))
        dt.Columns.Add("f_tamano", GetType(Decimal))
        dt.Columns.Add("b_color", GetType(String))
        dt.Columns.Add("b_ancho", GetType(Decimal))
        dt.Columns.Add("b_alto", GetType(Decimal))
        dt.Columns.Add("impresora", GetType(String))
        'establecemos el indice principal
        dt.Constraints.Add("pksubgrupo", dt.Columns("cod_sgrupo"), True)
        Return dt
    End Function
    Public Shared Function dsxsubgrupo() As DataSet
        Dim ds As New DataSet
        Dim dtSG As New DataTable("sGrupo")
        Dim dtG As New DataTable("familia")
        'añadimos columnas al dataset
        dtSG.Columns.Add("cod_sgrupo", GetType(String))
        dtSG.Columns.Add("nom_sgrupo", GetType(String))
        dtSG.Columns.Add("cod_familia", GetType(String))
        dtSG.Columns.Add("esProduccion", GetType(Boolean))
        dtSG.Columns.Add("activo", GetType(Boolean))
        'establecemos el indice principal
        dtSG.Constraints.Add("pksubgrupo", dtSG.Columns("cod_sgrupo"), True)
        'establecemos el indice unique
        dtSG.Constraints.Add("uqsubgrupo", dtSG.Columns("nom_sgrupo"), False)
        'establecemos el Foreign Key
        ds.Tables("sGrupo").Constraints.Add("fkGrupoSubSgrupo", _
        ds.Tables("familia").Columns("cod_familia"), _
        ds.Tables("sGrupo").Columns("cod_grupo"))
        'hacemos los campos No Nulos
        dtSG.Columns("nom_sgrupo").AllowDBNull = False
        dtSG.Columns("cod_grupo").AllowDBNull = False
        dtSG.Columns("activo").AllowDBNull = False
        Return ds
    End Function
    Public Function existeEnCatalogo(ByVal cod_sgrupo As String) As Integer
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer, cad As String
        com.Connection = clConex
        cad = "Select cod_sgrupo from articulo where cod_sgrupo='" & cod_sgrupo & "'"
        com.CommandText = cad
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), False, obj), Integer)
        clConex.Close()
        Return result
    End Function

    Public Function devuelveGrupo(ByVal cod_subgrupo As String) As String
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim cad, resp As String
        cad = " select cod_grupo from subgrupo where cod_sgrupo='" & cod_subgrupo & "'"
        com.CommandText = cad
        Dim obj As Object = com.ExecuteScalar
        resp = CType(IIf(IsDBNull(obj), "", obj), String)
        clConex.Close()
        Return resp
    End Function
End Class
