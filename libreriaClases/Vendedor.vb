Imports MySql.Data.MySqlClient
Public Class Vendedor
    Public Shared Function dsVendedor() As DataSet
        Dim ds As New DataSet
        Dim dtVendedor As New DataTable("vendedor")
        dtVendedor.Columns.Add(New DataColumn("cod_vend", GetType(String)))
        dtVendedor.Columns.Add(New DataColumn("nom_vend", GetType(String)))
        dtVendedor.Columns.Add(New DataColumn("activo", GetType(Boolean)))
        dtVendedor.Columns.Add(New DataColumn("perfil", GetType(String)))
        dtVendedor.Constraints.Add("pkCod_Vend", dtVendedor.Columns("cod_vend"), True)
        ds.Tables.Add(dtVendedor)
        Return ds
    End Function
    Public Shared Function listado() As MySqlDataReader
        Dim clConex As New MySqlConnection
        Dim drVendedor As MySqlDataReader
        Try
            clConex = Conexion.obtenerConexion
            Dim com As New MySqlCommand("Select cod_vend,nom_vend from vendedor", clConex)
            drVendedor = com.ExecuteReader
            drVendedor.Close()
            drVendedor = Nothing
            clConex.Close()
        Catch e As Exception
            drVendedor = Nothing
        End Try
        Return drVendedor
    End Function
    Public Function existeEnSalidas(ByVal cod_vend As String) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer, cad As String
        com.Connection = clConex
        cad = "Select count(cod_vend) from salida where cod_vend='" & cod_vend & "'"
        com.CommandText = cad
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Integer)
        clConex.Close()
        If result = 0 Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Function existeEnSalidasHistorial(ByVal cod_vend As String) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer, cad As String
        com.Connection = clConex
        cad = "Select count(cod_vend) from h_salida where cod_vend='" & cod_vend & "'"
        com.CommandText = cad
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Integer)
        clConex.Close()
        If result = 0 Then
            Return False
        Else
            Return True
        End If
    End Function
End Class
