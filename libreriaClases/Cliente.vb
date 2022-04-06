Imports MySql.Data.MySqlClient
Public Class Cliente
    Public Shared Function dsCliente() As DataSet
        Dim ds As New DataSet
        Dim dt As New DataTable("cliente")
        dt.Columns.Add(New DataColumn("cod_clie", GetType(String)))
        dt.Columns.Add(New DataColumn("nom_clie", GetType(String)))
        dt.Columns.Add(New DataColumn("raz_soc", GetType(String)))
        dt.Columns.Add(New DataColumn("dir_clie", GetType(String)))
        dt.Columns.Add(New DataColumn("fono_clie", GetType(String)))
        dt.Columns.Add(New DataColumn("fax_clie", GetType(String)))
        dt.Columns.Add(New DataColumn("cod_tipo", GetType(String)))
        dt.Columns.Add(New DataColumn("dir_ent", GetType(String)))
        dt.Columns.Add(New DataColumn("hora_ent", GetType(String)))
        dt.Columns.Add(New DataColumn("nom_rep", GetType(String)))
        dt.Columns.Add(New DataColumn("fono_rep", GetType(String)))
        dt.Columns.Add(New DataColumn("cel_rep", GetType(String)))
        dt.Columns.Add(New DataColumn("nom_cont", GetType(String)))
        dt.Columns.Add(New DataColumn("fono_cont", GetType(String)))
        dt.Columns.Add(New DataColumn("cel_cont", GetType(String)))
        dt.Columns.Add(New DataColumn("activo", GetType(Boolean)))
        dt.Constraints.Add("pkCod_clie", dt.Columns("cod_clie"), True)
        ds.Tables.Add(dt)
        Return ds
    End Function
    Public Function insertar(ByVal cod_clie As String, _
                                ByVal nom_clie As String, _
                                ByVal raz_soc As String, _
                                ByVal dir_clie As String, _
                                ByVal dir_ent As String, _
                                ByVal nom_cont As String, _
                                ByVal fono_clie As String, _
                                ByVal cod_tipo As String, _
                                ByVal activo As Integer) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim sql As String, result As Integer
        sql = "Insert Into cliente(cod_clie,nom_clie,raz_soc,dir_clie,dir_ent,nom_cont,fono_clie,cod_tipo,activo)" & _
            "values('" & _
            cod_clie & "','" & nom_clie & "','" & raz_soc & "','" & dir_clie & "','" & dir_ent & "','" & nom_cont & "','" & fono_clie & "','" & cod_tipo & "'," & activo & ")"
        com.CommandText = sql
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function
    Public Function insertarAUX(ByVal cod_clie As String, _
                            ByVal nom_clie As String, _
                            ByVal raz_soc As String, _
                            ByVal cod_tipo As String, _
                            ByVal activo As Integer) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim sql As String, result As Integer
        sql = "Insert Into cliente(cod_clie,nom_clie,raz_soc,cod_tipo,activo)" & _
            "values('" & _
            cod_clie & "','" & nom_clie & "','" & raz_soc & "','" & cod_tipo & "'," & activo & ")"
        com.CommandText = sql
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function
    Public Function existe(ByVal cod_clie As String) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer, cad As String
        com.Connection = clConex
        cad = "Select count(cod_clie) from cliente where cod_clie='" & cod_clie & "'"
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
    Public Function existeEnSalida(ByVal cod_clie As String) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer, cad As String
        com.Connection = clConex
        cad = "Select count(cod_clie) from salida where cod_clie='" & cod_clie & "'"
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
    Public Function existeEnHistorial(ByVal cod_clie As String) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer, cad As String
        com.Connection = clConex
        cad = "Select count(cod_clie) from h_salida where cod_clie='" & cod_clie & "'"
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
