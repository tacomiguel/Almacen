Imports libreriaClases
Imports MySql.Data.MySqlClient
Public Class Unidad
    Public Shared Function dsUnidad() As DataSet
        Dim ds As New DataSet
        Dim dtUnidad As New DataTable("unidad")
        dtUnidad.Columns.Add(New DataColumn("cod_uni", GetType(String)))
        dtUnidad.Columns.Add(New DataColumn("nom_uni", GetType(String)))
        dtUnidad.Columns.Add(New DataColumn("cant_uni", GetType(String)))
        dtUnidad.Columns.Add(New DataColumn("esProduccion", GetType(Boolean)))
        dtUnidad.Columns.Add(New DataColumn("activo", GetType(Boolean)))
        dtUnidad.Constraints.Add("pkCod_uni", dtUnidad.Columns("cod_uni"), True)
        ds.Tables.Add(dtUnidad)
        Return ds
    End Function
    Public Function existeEnCatalogo(ByVal cod_uni As String) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer, cad As String
        com.Connection = clConex
        cad = "Select cod_uni from articulo where cod_uni='" & cod_uni & "'"
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
    Public Function devuelveUnidad(ByVal cod_art As String) As String
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim cad, cad1, cad2, cad3, resp As String
        cad1 = "select articulo.cod_uni"
        cad2 = " from articulo inner join unidad on articulo.cod_uni=unidad.cod_uni"
        cad3 = " where cod_art='" & cod_art & "'"
        cad = cad1 + cad2 + cad3
        com.CommandText = cad
        Dim obj As Object = com.ExecuteScalar
        resp = CType(IIf(IsDBNull(obj), "", obj), String)
        clConex.Close()
        Return resp
    End Function
    Public Function devuelveNombreUnidad(ByVal cod_art As String) As String
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim cad, cad1, cad2, cad3, resp As String
        cad1 = "select nom_uni"
        cad2 = " from articulo inner join unidad on articulo.cod_uni=unidad.cod_uni"
        cad3 = " where cod_art='" & cod_art & "'"
        cad = cad1 + cad2 + cad3
        com.CommandText = cad
        Dim obj As Object = com.ExecuteScalar
        resp = CType(IIf(IsDBNull(obj), "", obj), String)
        clConex.Close()
        Return resp
    End Function
    Public Function devuelveCantUnidad(ByVal cod_uni As String) As Decimal
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim cad, cad1, cad2 As String, resp As Decimal
        cad1 = "select cant_uni"
        cad2 = " from unidad where cod_uni='" & cod_uni & "'"
        cad = cad1 + cad2
        com.CommandText = cad
        Dim obj As Object = com.ExecuteScalar
        resp = CType(IIf(IsDBNull(obj), 0, obj), Decimal)
        clConex.Close()
        Return resp
    End Function
    Public Function esDivisible(ByVal cod_uni As String) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim cad, cad1, cad2 As String, resp As Integer
        cad1 = "select es_divisible"
        cad2 = " from unidad where cod_uni='" & cod_uni & "'"
        cad = cad1 + cad2
        com.CommandText = cad
        Dim obj As Object = com.ExecuteScalar
        resp = CType(IIf(IsDBNull(obj), 0, obj), Integer)
        clConex.Close()
        If resp = 0 Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Function esBotella(ByVal cod_uni As String) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim cad, cad1, cad2 As String, resp As Integer
        cad1 = "select esBotella"
        cad2 = " from unidad where cod_uni='" & cod_uni & "'"
        cad = cad1 + cad2
        com.CommandText = cad
        Dim obj As Object = com.ExecuteScalar
        resp = CType(IIf(IsDBNull(obj), 0, obj), Integer)
        clConex.Close()
        If resp = 0 Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Function devCantUnidad(ByVal cod_art As String) As Decimal
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim cad, cad1, cad2, cad3 As String, resp As Decimal
        cad1 = "select cant_uni"
        cad2 = " from articulo inner join unidad on articulo.cod_uni=unidad.cod_uni"
        cad3 = " where articulo.cod_art='" & cod_art & "'"
        cad = cad1 + cad2 + cad3
        com.CommandText = cad
        resp = com.ExecuteScalar
        clConex.Close()
        Return resp
    End Function

    Public Function maxCodigo() As String
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer
        com.Connection = clConex
        com.CommandText = "select max(cod_uni) from unidad  WHERE cod_uni REGEXP ('^[0-9]+$')"
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), "000", obj), String)
        Dim resp As String = Right("000" & Trim(Str(Microsoft.VisualBasic.Val(result) + 1)), 3)
        clConex.Close()
        Return resp
    End Function
End Class
