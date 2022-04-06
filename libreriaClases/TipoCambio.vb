Imports MySql.Data.MySqlClient
Public Class TipoCambio
    Public Function insertar(ByVal fechaProceso As Date, _
                                ByVal tCambio As Decimal, _
                                ByVal usuario As String) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim sql As String, result As Integer
        Dim mfecha As String = fechaProceso.ToString("yy-MM-dd")
        sql = "Insert Into tipo_cambio(fecha,tc,cuenta)" & _
            "values('" & _
            mfecha & "'," & tCambio & ",'" & usuario & "')"
        com.CommandText = sql
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function
    Public Function actualizar(ByVal fechaProceso As Date, _
                                ByVal tCambio As Decimal, _
                                ByVal usuario As String) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim cad As String, result As Integer
        Dim mfecha As String = fechaProceso.ToString("yy-MM-dd")
        cad = "Update tipo_cambio set tc='" & tCambio & "', cuenta='" & usuario & "' where fecha='" & mfecha & "'"
        com.CommandText = cad
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function
    Public Function recupera(ByVal fechaProceso As Date) As Decimal
        Dim mfecha = fechaProceso.ToString("yyyy-MM-dd")
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Decimal, cad, cad1, cad2 As String
        com.Connection = clConex
        cad1 = "Select tc from tipo_cambio where"
        cad2 = " fecha='" & mfecha & "'"
        cad = cad1 + cad2
        com.CommandText = cad
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Decimal)
        clConex.Close()
        Return result
    End Function
    Public Function existe(ByVal fechaProceso As Date) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer, cad As String
        Dim mfecha As String = fechaProceso.ToString("yy-MM-dd")
        com.Connection = clConex
        cad = "Select count(tc) from tipo_cambio where fecha='" & mfecha & "'"
        com.CommandText = cad
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Integer)
        clConex.Close()
        If result > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
