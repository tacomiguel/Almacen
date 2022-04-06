Imports MySql.Data.MySqlClient
Public Class Chofer
    Public Shared Function dsChofer() As DataSet
        Dim ds As New DataSet
        Dim dtChofer As New DataTable("chofer")
        dtChofer.Columns.Add(New DataColumn("cod_chof", GetType(String)))
        dtChofer.Columns.Add(New DataColumn("nom_chof", GetType(String)))
        dtChofer.Columns.Add(New DataColumn("activo", GetType(Boolean)))
        dtChofer.Constraints.Add("pkCod_chof", dtChofer.Columns("cod_chof"), True)
        ds.Tables.Add(dtChofer)
        Return ds
    End Function
    Public Function existeEnGuia(ByVal cod As String) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer, cad As String
        com.Connection = clConex
        cad = "Select count(cod_cond) from guia_remision where cod_cond='" & cod & "'"
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
    Public Function existeEnGuiaHistorial(ByVal cod As String) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer, cad As String
        com.Connection = clConex
        cad = "Select count(cod_cond) from h_guia_remision where cod_cond='" & cod & "'"
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
