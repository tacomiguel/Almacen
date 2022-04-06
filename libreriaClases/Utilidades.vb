Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic
Public Class Utilidades
    Public Shared Function dsImportacion() As DataSet
        Dim ds As New DataSet
        Dim dt As New DataTable("importacion")
        dt.Columns.Add(New DataColumn("fecha", GetType(Date)))
        dt.Columns.Add(New DataColumn("cod_doc", GetType(String)))
        dt.Columns.Add(New DataColumn("serie", GetType(String)))
        dt.Columns.Add(New DataColumn("documento", GetType(String)))
        dt.Columns.Add(New DataColumn("cod_art", GetType(String)))
        dt.Columns.Add(New DataColumn("nom_art", GetType(String)))
        dt.Columns.Add(New DataColumn("cant", GetType(String)))
        dt.Columns.Add(New DataColumn("precio", GetType(String)))
        dt.Columns.Add(New DataColumn("neto", GetType(String)))
        ds.Tables.Add(dt)
        Return ds
    End Function
    Public Function recVentasPixel(ByVal fecha As Date) As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter
        Dim mfecha As String = fecha.ToString("yyyy-MM-dd")
        Dim cad, cad1, cad2, cad3, cad4, cad5 As String
        cad1 = "select pixel.operacion,fecha,nro,ingreso,codigo,nom_art,nom_uni,sum(cant) as cant "
        cad2 = " from pixel inner join pixel_det on pixel.operacion=pixel_det.operacion"
        cad3 = " inner join articulo on pixel_det.codigo=articulo.cod_art"
        cad4 = " inner join unidad on unidad.cod_uni=articulo.cod_uni"
        cad5 = " where fecha='" & mfecha & "' group by cod_art order by nom_art"
        cad = cad1 + cad2 + cad3 + cad4 + cad5
        Dim com As New MySqlCommand(cad, clConex)
        da.SelectCommand = com
        da.Fill(ds, "venta")
        clConex.Close()
        Return ds
    End Function
    Public Function devuelveCodigoInterno(ByVal cod_ext As String, Optional ByVal x As String = "", _
                    Optional ByVal x2 As String = "", Optional ByVal x3 As String = "", Optional ByVal cod_ext4 As String = "") As String
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim result As String, cad As String = ""
        Dim existe As Boolean = False
        If Len(cod_ext) > 0 Then
            cad = "select cod_art from articulo where cod_artExt='" & cod_ext & "'"
        End If
        com.CommandText = cad
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), "", obj), String)
        clConex.Close()
        Return result
    End Function
    Public Function insertar_ventasDBF(ByVal Ope As Integer, _
                            ByVal fecha As Date, _
                            ByVal numdoc As String, _
                            ByVal codigo As String, _
                            ByVal nombre As String, _
                            ByVal cantidad As Decimal, _
                            ByVal precio As Decimal, _
                            ByVal descuento As Decimal, _
                            ByVal tproceso As String, _
                            ByVal cod_alma As String) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim sql As String, result As Integer
        Dim mfecha As String = fecha.ToString("yy-MM-dd")
        sql = "Insert Into micros_imp(operacion,fecha,numdoc,codigo,nombre,canti,pre_ven,dcto,tip_proceso,cod_alma)" & _
                "values(" & _
                Ope & ",'" & mfecha & "','" & numdoc & "','" & codigo & "','" & nombre & "'," & cantidad & "," & precio & "," & descuento & ",'" & tproceso & "','" & cod_alma & "')"
        com.CommandText = sql
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function
    Public Function insertar_ventasPixel(ByVal operacion As Integer, _
                        ByVal fecha As Date, _
                        ByVal tipo As String, _
                        ByVal serie As String, _
                        ByVal nro As Integer, _
                        ByVal nro_caja As Integer) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim sql As String, result As Integer
        Dim mfecha As String = fecha.ToString("yy-MM-dd")
        sql = "Insert Into pixel(operacion,fecha,tipo,serie,nro,nro_caja)" & _
                "values(" & _
                operacion & ",'" & mfecha & "','" & tipo & "','" & serie & "'," & nro & "," & nro_caja & ")"
        com.CommandText = sql
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function
    Public Function insertar_ventasPixel_det(ByVal operacion As Integer, _
                    ByVal ingreso As Integer, _
                    ByVal codigo As String, _
                    ByVal cant As Decimal, _
                    ByVal precio As Decimal) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim sql As String, result As Integer
        sql = "Insert Into pixel_det(operacion,ingreso,codigo,cant,precio)" & _
                "values(" & _
                operacion & "," & ingreso & ",'" & codigo & "'," & cant & "," & precio & ")"
        com.CommandText = sql
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function
    Public Function existeMigracionPixel(ByVal fecha As Date) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer, sql As String
        com.Connection = clConex
        Dim mfecha As String = fecha.ToString("yyyy-MM-dd")
        sql = "Select count(fecha) from pixel where fecha='" & mfecha & "'"
        com.CommandText = sql
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Integer)
        clConex.Close()
        If result > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function yaActualizoStockPixel(ByVal fecha As Date) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer, sql As String
        com.Connection = clConex
        Dim mfecha As String = fecha.ToString("yyyy-MM-dd")
        sql = "Select count(fecha) from salida where fec_doc='" & mfecha & "' and obs='Migración Pixel'"
        com.CommandText = sql
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Integer)
        clConex.Close()
        If result > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function maxOperacionPixel() As Integer
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer
        com.Connection = clConex
        com.CommandText = "select max(operacion) from pixel"
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Integer)
        clConex.Close()
        Return result + 1
    End Function
    Public Function maxIngresoPixel() As Integer
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer
        com.Connection = clConex
        com.CommandText = "select max(ingreso) from pixel_det"
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Integer)
        clConex.Close()
        Return result + 1
    End Function
    Public Function PVentasSinStock() As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Boolean, sql As String
        com.Connection = clConex
        sql = "Select procesarventa_sinstock from configuracion "
        com.CommandText = sql
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Boolean)
        clConex.Close()
        If result = True Then
            Return True
        Else
            Return False
        End If
    End Function
    Function devuelvediasFormaPago(ByVal cod_fpago As String) As Integer
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, ndias As Integer
        com.Connection = clConex
        Dim cad, cad1, cad2 As String
        cad1 = " select dias from forma_pago"
        cad2 = " where cod_fpago ='" & cod_fpago & "'"
        cad = cad1 + cad2
        com.CommandText = cad
        Dim obj As Object = com.ExecuteScalar
        ndias = CType(IIf(IsDBNull(obj), 0, obj), Integer)
        clConex.Close()
        Return ndias
    End Function
    Public Sub actualiza_empresa(ByVal cod_emp As String, ByVal nom_emp As String, ByVal dir_emp As String, _
                                 ByVal pais_emp As String)
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, cad, cad0, cad1, cad2 As String
        com.Connection = clConex
        cad0 = " cod_emp='" & cod_emp & "',nom_emp='" & nom_emp & "'"
        cad1 = " update configuracion set " & cad0 & ",dir_emp='" & dir_emp & "',pais_emp='" & pais_emp & "'"
        cad2 = " update empresa set " & cad0 & ",raz_soc='" & nom_emp & "'"
        cad = cad1
        com.CommandText = cad
        com.ExecuteNonQuery()
        cad = cad2
        com.CommandText = cad
        com.ExecuteNonQuery()
        clConex.Close()
    End Sub
End Class