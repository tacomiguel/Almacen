Imports MySql.Data.MySqlClient
Public Class EmpTransporte
    Public Shared Function dsEmpTransporte() As DataSet
        Dim ds As New DataSet
        Dim dtEmpTransporte As New DataTable("emp_transporte")
        dtEmpTransporte.Columns.Add(New DataColumn("cod_etrans", GetType(String)))
        dtEmpTransporte.Columns.Add(New DataColumn("nom_etrans", GetType(String)))
        dtEmpTransporte.Columns.Add(New DataColumn("activo", GetType(Boolean)))
        dtEmpTransporte.Constraints.Add("pkCod_etrans", dtEmpTransporte.Columns("cod_etrans"), True)
        ds.Tables.Add(dtEmpTransporte)
        Return ds
    End Function
    Public Function existeEnEmpTransporte(ByVal cod_eTrans As String) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer, cad As String
        com.Connection = clConex
        cad = "Select count(cod_eTrans) from guia_remision where cod_eTrans='" & cod_eTrans & "'"
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
    Public Function existeEnEmpTransporteHistorial(ByVal cod_eTrans As String) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer, cad As String
        com.Connection = clConex
        cad = "Select count(cod_eTrans) from h_guia_remision where cod_eTrans='" & cod_eTrans & "'"
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
