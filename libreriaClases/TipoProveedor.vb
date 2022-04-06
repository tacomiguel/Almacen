Imports MySql.Data.MySqlClient
Public Class TipoProveedor
    Public Shared Function dsTipoProveedor() As DataSet
        Dim ds As New DataSet
        Dim dtTipoProveedor As New DataTable("tipo_proveedor")
        dtTipoProveedor.Columns.Add(New DataColumn("cod_tipo", GetType(String)))
        dtTipoProveedor.Columns.Add(New DataColumn("nom_tipo", GetType(String)))
        dtTipoProveedor.Columns.Add(New DataColumn("activo", GetType(Boolean)))
        dtTipoProveedor.Constraints.Add("pkCod_tipo", dtTipoProveedor.Columns("cod_tipo"), True)
        ds.Tables.Add(dtTipoProveedor)
        Return ds
    End Function
    Public Function existeEnProveedores(ByVal cod_tprov As String) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer, cad As String
        com.Connection = clConex
        cad = "Select cod_tipo from proveedor where cod_tipo='" & cod_tprov & "'"
        com.CommandText = cad
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), False, obj), Integer)
        clConex.Close()
        If result = 0 Then
            Return False
        Else
            Return True
        End If
    End Function
End Class
