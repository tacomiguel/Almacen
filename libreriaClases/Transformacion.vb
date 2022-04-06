Imports MySql.Data.MySqlClient
Public Class Transformacion
    Public Function maxTransformacion() As Integer
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer
        com.Connection = clConex
        com.CommandText = "select max(nro_doc) from salida where cod_doc=91"
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Integer)
        clConex.Close()
        Return result + 1
    End Function
    Public Function recTransformacionS(ByVal agr As Boolean, ByVal f As Date) As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim mfecha As String = f.ToString("yyyy-MM-dd")
        Dim da As New MySqlDataAdapter
        Dim ds As New DataSet
        Dim cad, cad1, cad2, cad3, cad4, cad5, cad6, cad7 As String
        cad1 = "select salida.operacion,salida,ingreso,fec_doc,nro_doc,salida.cod_alma,"
        cad2 = " salida_det.cod_art, nom_art, nom_uni, " & IIf(agr, "sum(cant) as cant", "cant") & ", precio"
        cad3 = " from salida inner join salida_det"
        cad4 = " on salida.operacion=salida_det.operacion"
        cad5 = " inner join articulo on salida_det.cod_art=articulo.cod_art"
        cad6 = " inner join unidad on articulo.cod_uni=unidad.cod_uni"
        cad7 = " where cod_doc='91' and fec_doc='" & mfecha & "'" & IIf(agr, " group by nro_doc", "") & " order by salida desc"
        cad = cad1 + cad2 + cad3 + cad4 + cad5 + cad6 + cad7
        Dim com As New MySqlCommand(cad)
        com.Connection = clConex
        da.SelectCommand = com
        da.Fill(ds, "transformacion")
        clConex.Close()
        Return ds
    End Function
    Public Function recTransformacionI(ByVal doc As String) As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim da As New MySqlDataAdapter
        Dim ds As New DataSet
        Dim cad, cad1, cad2, cad3, cad4, cad5, cad6, cad7 As String
        cad1 = "select ingreso.operacion,ingreso,fec_doc,nro_doc,ingreso.cod_alma,"
        cad2 = " ingreso_det.cod_art, nom_art, nom_uni, cant, precio"
        cad3 = " from ingreso inner join ingreso_det"
        cad4 = " on ingreso.operacion=ingreso_det.operacion"
        cad5 = " inner join articulo on ingreso_det.cod_art=articulo.cod_art"
        cad6 = " inner join unidad on articulo.cod_uni=unidad.cod_uni"
        cad7 = " where cod_doc='91' and nro_doc='" & doc & "' order by ingreso desc"
        cad = cad1 + cad2 + cad3 + cad4 + cad5 + cad6 + cad7
        Dim com As New MySqlCommand(cad)
        com.Connection = clConex
        da.SelectCommand = com
        da.Fill(ds, "transformacion")
        clConex.Close()
        Return ds
    End Function
    Public Function recProduccionS(ByVal doc As String) As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim da As New MySqlDataAdapter
        Dim ds As New DataSet
        Dim cad, cad1, cad2, cad3, cad4, cad5, cad6, cad7 As String
        cad1 = "select salida.operacion,salida,fec_doc,nro_doc,salida.cod_alma,"
        cad2 = " salida_det.cod_art, nom_art, nom_uni, cant, precio"
        cad3 = " from salida inner join salida_det"
        cad4 = " on salida.operacion=salida_det.operacion"
        cad5 = " inner join articulo on salida_det.cod_art=articulo.cod_art"
        cad6 = " inner join unidad on articulo.cod_uni=unidad.cod_uni"
        cad7 = " where cod_doc='93' and nro_doc='" & doc & "' order by salida desc"
        cad = cad1 + cad2 + cad3 + cad4 + cad5 + cad6 + cad7
        Dim com As New MySqlCommand(cad)
        com.Connection = clConex
        da.SelectCommand = com
        da.Fill(ds, "Produccion")
        clConex.Close()
        Return ds
    End Function
End Class
