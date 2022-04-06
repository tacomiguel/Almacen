Imports MySql.Data.MySqlClient
Public Class Proveedor
    Public Shared Function dsProveedor() As DataSet
        Dim ds As New DataSet
        Dim dt As New DataTable("proveedor")
        dt.Columns.Add(New DataColumn("cod_prov", GetType(String)))
        dt.Columns.Add(New DataColumn("nom_prov", GetType(String)))
        dt.Columns.Add(New DataColumn("raz_soc", GetType(String)))
        dt.Columns.Add(New DataColumn("dir_prov", GetType(String)))
        dt.Columns.Add(New DataColumn("fono_prov", GetType(String)))
        dt.Columns.Add(New DataColumn("fax_prov", GetType(String)))
        dt.Columns.Add(New DataColumn("email_prov", GetType(String)))
        dt.Columns.Add(New DataColumn("cod_tipo", GetType(String)))
        dt.Columns.Add(New DataColumn("nom_rep", GetType(String)))
        dt.Columns.Add(New DataColumn("fono_rep", GetType(String)))
        dt.Columns.Add(New DataColumn("cel_rep", GetType(String)))
        dt.Columns.Add(New DataColumn("nom_cont", GetType(String)))
        dt.Columns.Add(New DataColumn("fono_cont", GetType(String)))
        dt.Columns.Add(New DataColumn("cel_cont", GetType(String)))
        dt.Columns.Add(New DataColumn("activo", GetType(Boolean)))
        dt.Constraints.Add("pkCod_prov", dt.Columns("cod_prov"), True)
        ds.Tables.Add(dt)
        Return ds
    End Function
    Public Function existeEnIngreso(ByVal cod_prov As String) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer, cad As String
        com.Connection = clConex
        cad = "Select count(cod_prov) from ingreso where cod_prov='" & cod_prov & "'"
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
    Public Function existeEnHistorial(ByVal cod_prov As String) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer, cad As String
        com.Connection = clConex
        cad = "Select count(cod_prov) from h_ingreso where cod_prov='" & cod_prov & "'"
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
