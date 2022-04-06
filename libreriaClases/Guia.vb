Imports MySql.Data.MySqlClient
Public Class Guia
    Public Shared Function dsGuia() As DataSet
        Dim ds As New DataSet
        Dim dt As New DataTable("cabecera")
        dt.Columns.Add(New DataColumn("operacion", GetType(Integer)))
        dt.Columns.Add(New DataColumn("ser_guia", GetType(String)))
        dt.Columns.Add(New DataColumn("num_guia", GetType(String)))
        dt.Columns.Add(New DataColumn("fec_tras", GetType(Date)))
        dt.Columns.Add(New DataColumn("fec_ent", GetType(Date)))
        dt.Columns.Add(New DataColumn("cod_mot", GetType(String)))
        dt.Columns.Add(New DataColumn("cod_cond", GetType(String)))
        dt.Columns.Add(New DataColumn("placa", GetType(String)))
        dt.Columns.Add(New DataColumn("cod_eTrans", GetType(String)))
        ds.Tables.Add(dt)
        Return ds
    End Function
    Public Function insertar(ByVal nro_ope As Integer, _
                            ByVal ser_guia As String, _
                            ByVal nro_guia As String, _
                            ByVal fec_tras As Date, _
                            ByVal fec_ent As Date, _
                            ByVal cod_mot As String, _
                            ByVal cod_cond As String, _
                            ByVal placa As String, _
                            ByVal cod_sucursal As String, _
                            ByVal cod_eTrans As String) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim cad As String, result As Integer
        Dim mfecha1 As String = fec_tras.ToString("yy-MM-dd")
        Dim mfecha2 As String = fec_ent.ToString("yy-MM-dd")
        cad = "Insert Into guia_remision(operacion,ser_guia,nro_guia,fec_tras,fec_ent,cod_mot,cod_cond,placa,cod_sucursal,cod_eTrans)" & _
            "values(" & _
            nro_ope & ",'" & ser_guia & "','" & nro_guia & "','" & mfecha1 & "','" & mfecha2 & "','" & cod_mot & "','" & cod_cond & "','" & placa & "','" & cod_sucursal & "','" & cod_eTrans & "')"
        com.CommandText = cad
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function
    Public Function recupera(ByVal operacion As Integer) As DataTable
        Dim clConex As New MySqlConnection
        Dim da As New MySqlDataAdapter
        Dim ds As DataSet = Guia.dsGuia
        Dim dt As DataTable = ds.Tables("cabecera")
        clConex = Conexion.obtenerConexion
        Dim com As New MySqlCommand("select operacion,ser_guia,nro_guia,fec_tras,fec_ent,cod_mot,cod_cond,placa,cod_sucursal,cod_eTrans from guia_remision where operacion=" & operacion)
        com.Connection = clConex
        da.SelectCommand = com
        da.Fill(ds, "cabecera")
        clConex.Close()
        Return dt
    End Function
    Public Function existe(ByVal ser_guia As String, ByVal nro_guia As String) As Integer
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer, cad As String
        com.Connection = clConex
        cad = "Select operacion from guia_remision where ser_guia='" & ser_guia & "'" & " and nro_guia='" & nro_guia & "'"
        com.CommandText = cad
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), False, obj), Integer)
        clConex.Close()
        Return result
    End Function
    Public Function maxNroGuia(ByVal ser_doc As String) As String
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer
        com.Connection = clConex
        com.CommandText = "select max(nro_guia) from guia_remision where ser_guia='" & ser_doc & "'"
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), "000000000", obj), String)
        Dim resp As String = Right("00000000" & Trim(Str(Microsoft.VisualBasic.Val(result) + 1)), 8)
        clConex.Close()
        Return resp
    End Function
End Class

