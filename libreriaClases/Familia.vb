Imports libreriaClases
Imports MySql.Data.MySqlClient
Public Class Familia
    Public Shared Function dsFamilia() As DataSet
        Dim ds As New DataSet
        Dim dtFamilia As New DataTable("Familia")
        dtFamilia.Columns.Add(New DataColumn("cod_familia", GetType(String)))
        'dtFamilia.Columns.Add(New DataColumn("nom_familia", GetType(String)))
        dtFamilia.Columns.Add(New DataColumn("activo", GetType(Boolean)))
        dtFamilia.Constraints.Add("pkCod_familia", dtFamilia.Columns("cod_familia"), True)
        ds.Tables.Add(dtFamilia)
        Return ds
    End Function
    Public Function existeEnGrupo(ByVal cod_familia As String) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer, cad As String
        com.Connection = clConex
        cad = "Select cod_familia from subgrupo where cod_familia='" & cod_familia & "'"
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
