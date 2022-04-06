Imports MySql.Data.MySqlClient
Imports System.Configuration
Imports System.Data.SqlClient

Public Class Conexion
    Public Shared Function obtenerConexion() As MySqlConnection
        Try

            Dim conex As String = "User Id=custom;password=P4nt3r4--;server=" & ConfigurationManager.AppSettings("Servidor").ToString & ";database=" & ConfigurationManager.AppSettings("BaseDatos").ToString &
                ";Convert Zero Datetime=True;persist security info=True;use procedure bodies=False;Connection Timeout=300 ; pooling=true; Max Pool Size=300"
            'Convert Zero Datetime=True
            '; Allow Zero Datetime=True
            Dim ConexBD As New MySqlConnection(conex)
            If ConexBD.State = ConnectionState.Open Then
                ConexBD.Close()
            End If
            ConexBD.Open()
            Return ConexBD
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Shared Function obtenerConexionSQL() As SqlConnection

        Try
            Dim servidor As String = "192.168.1.200\LUCET"
            Dim bd As String = "ZG_OPERLUCET"
            Dim usuario As String = "lucetzigma"
            Dim pass As String = "lucet001"
            'Crear un objeto Connection.
            Dim conex As String = "data source =" & servidor & "; initial catalog = " & bd & "; user id = " & usuario & "; password = " & pass
            'Convert Zero Datetime=True
            '; Allow Zero Datetime=True
            Dim ConexBD As New SqlConnection(conex)
            If ConexBD.State = ConnectionState.Open Then
                ConexBD.Close()
            End If
            ConexBD.Open()
            Return ConexBD
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Shared Function obtenerConexionODBC() As Odbc.OdbcConnection
        Const conex As String = "Dsn=micros;uid=dba;pwd=micros3700;"
        Dim conexBD As New Odbc.OdbcConnection(conex)
        Try
            conexBD.Open()
            Return conexBD
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Shared Function insertar_Auditoria(ByVal cadena As String, ByVal datos As String) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim sql As String, result As Integer
        sql = "Insert Into log_auditoria(proceso,datos) values('" & cadena & "', '" & datos & "')"
        com.CommandText = sql
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function

End Class



''Dim Encontro As Boolean = False
'Dim DireccionRelativa, DireccionCompleta As String
'' obtiene el path relativo de la aplicación. 
'DireccionRelativa = System.IO.Directory.GetCurrentDirectory()
'DireccionCompleta = DireccionRelativa + "\configuracion.ini"
'Dim objReader As New IO.StreamReader(DireccionCompleta)
'Dim sLine As String = ""
'Dim arrText As New ArrayList()
'Do
'    sLine = objReader.ReadLine()
'    If Not sLine Is Nothing Then
'        arrText.Add(sLine)
'    End If
'Loop Until sLine Is Nothing
'objReader.Close()
'Servidor = arrText(1)
'BaseDatos = arrText(2)