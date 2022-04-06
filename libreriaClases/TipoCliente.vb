Imports MySql.Data.MySqlClient
Public Class TipoCliente
    Public Shared Function dsTipoCliente() As DataSet
        Dim ds As New DataSet
        Dim dtTipoCliente As New DataTable("tipo_cliente")
        dtTipoCliente.Columns.Add(New DataColumn("cod_tipo", GetType(String)))
        dtTipoCliente.Columns.Add(New DataColumn("nom_tipo", GetType(String)))
        dtTipoCliente.Columns.Add(New DataColumn("activo", GetType(Boolean)))
        dtTipoCliente.Constraints.Add("pkCod_tipo", dtTipoCliente.Columns("cod_tipo"), True)
        ds.Tables.Add(dtTipoCliente)
        Return ds
    End Function
    Public Function existeEnClientes(ByVal cod_tclie As String) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer, cad As String
        com.Connection = clConex
        cad = "Select cod_tipo from cliente where cod_tipo='" & cod_tclie & "'"
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
