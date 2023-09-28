Imports libreriaClases
Imports MySql.Data.MySqlClient
Public Class ePrecio
    Public Shared Function dsPrecio() As DataSet
        Dim ds As New DataSet
        ds.Tables.Add(crearTablaFluctuacionPrecios())
        Return ds
    End Function
    Public Shared Function dsCostosProduccion() As DataSet
        Dim ds As New DataSet
        ds.Tables.Add(crearTablaCostosProduccion())
        Return ds
    End Function
    Public Shared Function dsMargenAnual() As DataSet
        Dim ds As New DataSet
        ds.Tables.Add(crearTablaMargenAnual())
        Return ds
    End Function
    Private Shared Function crearTablaFluctuacionPrecios() As DataTable
        Dim dt As New DataTable("fluctuacionPrecios")
        dt.Columns.Add(New DataColumn("cod_art", GetType(String)))
        dt.Columns.Add(New DataColumn("nom_art", GetType(String)))
        dt.Columns.Add(New DataColumn("nom_uni", GetType(String)))
        dt.Columns.Add(New DataColumn("nom_sgrupo", GetType(String)))
        dt.Columns.Add(New DataColumn("d1", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("d2", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("d3", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("d4", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("d5", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("d6", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("d7", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("d8", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("d9", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("d10", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("d11", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("d12", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("d13", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("d14", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("d15", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("d16", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("d17", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("d18", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("d19", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("d20", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("d21", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("d22", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("d23", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("d24", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("d25", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("d26", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("d27", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("d28", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("d29", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("d30", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("d31", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("pre_costo", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("pre_costoMin", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("pre_costoMax", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("colorear", GetType(Integer)))
        dt.Columns.Add(New DataColumn("promedio", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("fec_doc", GetType(Date)))
        dt.Columns.Add(New DataColumn("operacion", GetType(Integer)))
        dt.Columns.Add(New DataColumn("ingreso", GetType(Integer)))
        Return dt
    End Function
    Private Shared Function crearTablaCostosProduccion() As DataTable
        Dim dt As New DataTable("produccion")
        dt.Columns.Add(New DataColumn("cod_art", GetType(String)))
        dt.Columns.Add(New DataColumn("nom_art", GetType(String)))
        dt.Columns.Add(New DataColumn("nom_uni", GetType(String)))
        dt.Columns.Add(New DataColumn("pre_costo", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("pre_costoMax", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("pre_prom", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("pre_venta", GetType(Decimal)))
        Return dt
    End Function
    Private Shared Function crearTablaMargenAnual() As DataTable
        Dim dt As New DataTable("margenAnual")
        dt.Columns.Add(New DataColumn("cod_art", GetType(String)))
        dt.Columns.Add(New DataColumn("nom_art", GetType(String)))
        dt.Columns.Add(New DataColumn("nom_uni", GetType(String)))
        dt.Columns.Add(New DataColumn("m1", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("m2", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("m3", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("m4", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("m5", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("m6", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("m7", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("m8", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("m9", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("m10", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("m11", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("m12", GetType(Decimal)))
        Return dt
    End Function
    Public Shared Function dsprecios() As DataSet
        Dim ds As New DataSet
        Dim dtPrecios As New DataTable("precios")
        dtPrecios.Columns.Add(New DataColumn("cod_art", GetType(String)))
        dtPrecios.Columns.Add(New DataColumn("cod_uni", GetType(String)))
        dtPrecios.Columns.Add(New DataColumn("nom_uni", GetType(String)))
        dtPrecios.Columns.Add(New DataColumn("tip_precio", GetType(String)))
        dtPrecios.Columns.Add(New DataColumn("precio", GetType(Decimal)))

        ds.Tables.Add(dtPrecios)
        Return ds
    End Function
    Public Function recuperaArticulosFluctuacionPrecios(ByVal empresa As String, ByVal esHistorial As Boolean, ByVal nroProceso As String, _
                ByVal esMensual As Boolean, ByVal fechaInicio As Date, ByVal fechaFinal As Date, ByVal nroDecimales As Integer, _
                ByVal xGrupo As Boolean, ByVal cod_sgrupo As String, ByVal xCuentaCont As Boolean, ByVal cod_cuenta As String, _
                ByVal precioSIs As String, ByVal hPrecioSIs As String) As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim da As New MySqlDataAdapter
        Dim ds As New DataSet
        Dim mfechaI As String = fechaInicio.ToString("yyyy-MM-dd")
        Dim mfechaF As String = fechaFinal.ToString("yyyy-MM-dd")
        Dim cad, cad1, cad2, cad3, cad4, cad5, cad6, cad7, cad8 As String
        cad1 = "select hd.cod_art,nom_art,nom_uni,cant," & IIf(esHistorial, hPrecioSIs, precioSIs) & " as precio," _
                & "round(pre_costo,3) as pre_costo,pre_costoMin,pre_costoMax,fec_doc,hd.operacion,ingreso," _
                & "articulo.cod_sgrupo,nom_sgrupo,articulo.cuenta_c"
        If esHistorial Then
            cad2 = " from h_ingreso as h inner join h_ingreso_det as hd on h.proceso=hd.proceso and h.operacion=hd.operacion "
        Else
            cad2 = " from ingreso as h inner join ingreso_det as hd on h.operacion=hd.operacion "
        End If
        cad3 = " inner join articulo on hd.cod_art=articulo.cod_art"
        cad4 = " inner join unidad on articulo.cod_uni=unidad.cod_uni"
        cad5 = " inner join documento_i on h.cod_doc=documento_i.cod_doc"
        cad6 = " inner join almacen on h.cod_alma=almacen.cod_alma" _
                & " inner join subgrupo on articulo.cod_sgrupo=subgrupo.cod_sgrupo"
        cad7 = " where almacen.cod_emp='" & empresa & "' and (esIngreso) and (esCompras)" _
                & IIf(esHistorial, " and h.proceso='" & nroProceso & "'", "") _
                & IIf(esMensual, "", " and fec_doc>='" & mfechaI & "'" & " and fec_doc<='" & mfechaF & "'") _
                & IIf(xGrupo, " and subgrupo.cod_sgrupo='" & cod_sgrupo & "'", "") _
                & IIf(xCuentaCont, " and articulo.cuenta_c='" & cod_cuenta & "'", "")
        cad8 = " group by hd.cod_art,fecha,precio order by nom_art,fec_doc,precio asc"
        cad = cad1 + cad2 + cad3 + cad4 + cad5 + cad6 + cad7 + cad8
        Dim comTrans As New MySqlCommand(cad)
        comTrans.Connection = clConex
        da.SelectCommand = comTrans
        da.Fill(ds, "articulos")
        clConex.Close()
        Return ds
    End Function
    Public Function RecuperaPreciosCompra(ByVal cod_art As String) As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim da As New MySqlDataAdapter
        Dim ds As New DataSet
        Dim cad, cad1 As String
        cad1 = "select a.*,nom_uni from art_precio a inner join " &
        " unidad u on a.cod_uni = u.cod_uni" &
        " where cod_art= '" & cod_art & "'"
        cad = cad1
        Dim comTrans As New MySqlCommand(cad)
        comTrans.Connection = clConex
        da.SelectCommand = comTrans
        da.Fill(ds, "Precios")
        clConex.Close()
        Return ds
    End Function
    Public Function preciosCompraVenta() As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim da As New MySqlDataAdapter
        Dim ds As New DataSet
        Dim cad, cad1, cad2, cad3, cad4, cad5, cad6, cad7, cad8 As String
        cad1 = "Select ingreso_det.cod_art,nom_art,nom_uni,cant,precio,fec_doc,ingreso_det.operacion,ingreso"
        cad2 = " from ingreso inner join ingreso_det"
        cad3 = " On ingreso.operacion=ingreso_det.operacion"
        cad4 = " inner join articulo On ingreso_det.cod_art=articulo.cod_art"
        cad5 = " inner join unidad On articulo.cod_uni=unidad.cod_uni"
        cad6 = " inner join documento_i On ingreso.cod_doc=documento_i.cod_doc"
        cad7 = " where esIngreso=1 group by cod_art,fec_doc,precio"
        cad8 = " order by nom_art,fec_doc"
        cad = cad1 + cad2 + cad3 + cad4 + cad5 + cad6 + cad7 + cad8
        Dim comTrans As New MySqlCommand(cad)
        comTrans.Connection = clConex
        da.SelectCommand = comTrans
        da.Fill(ds, "fluctuacion")
        clConex.Close()
        Return ds
    End Function
    Public Function margenesOperacion(ByVal esMensual As Boolean, ByVal fechaInicio As Date, ByVal fechaFinal As Date, ByVal nroDecimales As Integer, ByVal solo10 As Boolean, ByVal diezMayores As Boolean) As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim da As New MySqlDataAdapter
        Dim ds As New DataSet
        Dim mfechaI As String = fechaInicio.ToString("yyyy-MM-dd")
        Dim mfechaF As String = fechaFinal.ToString("yyyy-MM-dd")
        Dim cad, cad1, cad2, cad3, cad4, cad5, cad6, cad7, cad8, cad9 As String
        cad1 = "Select salida_det.cod_art,nom_art,nom_uni,sum(cant)As cant,precio As pre_venta,pre_costo,"
        If nroDecimales = 3 Then
            cad2 = " round(sum(cant)*precio-sum(cant)*pre_costo,3) As margen"
        Else
            cad2 = " round(sum(cant)*precio-sum(cant)*pre_costo,2) As margen"
        End If
        cad3 = " from salida inner join salida_det"
        cad4 = " On salida.operacion=salida_det.operacion"
        cad5 = " inner join articulo On salida_det.cod_art=articulo.cod_art"
        cad6 = " inner join unidad On articulo.cod_uni=unidad.cod_uni"
        cad7 = " inner join documento_s On salida.cod_doc=documento_s.cod_doc"
        If esMensual Then
            cad8 = " where esVenta=1 And precio>0 group by salida_det.cod_art,precio"
        Else
            cad8 = " where esVenta=1 And fec_doc>='" & mfechaI & "'" & " and fec_doc<='" & mfechaF & "'" & "  and precio>0 group by salida_det.cod_art,precio"
        End If
        If solo10 Then
            If diezMayores Then
                cad9 = " order by margen desc,nom_art limit 10"
            Else
                cad9 = " order by margen asc,nom_art limit 10"
            End If
        Else
            cad9 = " order by margen desc,nom_art"
        End If
        cad = cad1 + cad2 + cad3 + cad4 + cad5 + cad6 + cad7 + cad8 + cad9
        Dim comTrans As New MySqlCommand(cad)
        comTrans.Connection = clConex
        da.SelectCommand = comTrans
        da.Fill(ds, "margenesOperacion")
        clConex.Close()
        Return ds
    End Function
    Public Function margenesOperacion_historial(ByVal nroProceso As String, ByVal esMensual As Boolean, ByVal fechaInicio As Date, ByVal fechaFinal As Date, ByVal nroDecimales As Integer, ByVal solo10 As Boolean, ByVal diezMayores As Boolean) As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim da As New MySqlDataAdapter
        Dim ds As New DataSet
        Dim mfechaI As String = fechaInicio.ToString("yyyy-MM-dd")
        Dim mfechaF As String = fechaFinal.ToString("yyyy-MM-dd")
        Dim cad, cad1, cad2, cad3, cad4, cad5, cad6, cad7, cad8, cad9 As String
        cad1 = "select h_salida_det.cod_art,nom_art,nom_uni,sum(cant)as cant,precio as pre_venta,pre_costo,"
        If nroDecimales = 3 Then
            cad2 = " round(sum(cant)*precio-sum(cant)*pre_costo,3) as margen"
        Else
            cad2 = " round(sum(cant)*precio-sum(cant)*pre_costo,2) as margen"
        End If
        cad3 = " from h_salida inner join h_salida_det"
        cad4 = " on h_salida.operacion=h_salida_det.operacion"
        cad5 = " inner join articulo on h_salida_det.cod_art=articulo.cod_art"
        cad6 = " inner join unidad on articulo.cod_uni=unidad.cod_uni"
        cad7 = " inner join documento_s on h_salida.cod_doc=documento_s.cod_doc"
        If esMensual Then
            cad8 = " where h_salida.proceso='" & nroProceso & "' and h_salida_det.proceso='" & nroProceso & "' and esVenta=1 and precio>0 group by h_salida_det.cod_art,precio"
        Else
            cad8 = " where h_salida.proceso='" & nroProceso & "' and h_salida_det.proceso='" & nroProceso & "' and esVenta=1 and fec_doc>='" & mfechaI & "'" & " and fec_doc<='" & mfechaF & "'" & "  and precio>0 group by h_salida_det.cod_art,precio"
        End If
        If solo10 Then
            If diezMayores Then
                cad9 = " order by margen desc,nom_art limit 10"
            Else
                cad9 = " order by margen asc,nom_art limit 10"
            End If
        Else
            cad9 = " order by margen desc,nom_art"
        End If
        cad = cad1 + cad2 + cad3 + cad4 + cad5 + cad6 + cad7 + cad8 + cad9
        Dim comTrans As New MySqlCommand(cad)
        comTrans.Connection = clConex
        da.SelectCommand = comTrans
        da.Fill(ds, "margenesOperacion")
        clConex.Close()
        Return ds
    End Function
    Public Function fluctuacionPreciosGrafico(ByVal cod_art As String) As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim da As New MySqlDataAdapter
        Dim ds As New DataSet
        Dim cad, cad1, cad2, cad3, cad4, cad5, cad6 As String
        cad1 = "select day(fec_doc)as dia,precio"
        cad2 = " from ingreso inner join ingreso_det"
        cad3 = " on ingreso.operacion=ingreso_det.operacion"
        cad4 = " inner join documento_i on ingreso.cod_doc=documento_i.cod_doc"
        cad5 = " where esIngreso=1 and cod_art='" & cod_art & "'" & " group by cod_art,fec_doc,precio"
        cad6 = " order by fec_doc,precio asc"
        cad = cad1 + cad2 + cad3 + cad4 + cad5 + cad6
        Dim comTrans As New MySqlCommand(cad)
        comTrans.Connection = clConex
        da.SelectCommand = comTrans
        da.Fill(ds, "fluctuacionGrafico")
        clConex.Close()
        Return ds
    End Function
    Public Function ResumenPrecioProm(ByVal annio As Integer) As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim da As New MySqlDataAdapter
        Dim ds As New DataSet
        Dim cad As String
        cad = "Select c.cod_art as 'CODDIGO',c.nom_art as 'DESCRIPCION'," _
    & " round(avg(case when month(fec_doc) = 1 Then  b.precio End),3) As 'Enero'," _
    & " round(avg(Case When month(fec_doc) = 2 Then  b.precio End),3) As 'Febrero'," _
    & " round(avg(Case When month(fec_doc) = 3 Then  b.precio End),3) As 'Marzo'," _
    & " round(avg(Case When month(fec_doc) = 4 Then  b.precio End),3) As 'Abril'," _
    & " round(avg(Case When month(fec_doc) = 5 Then  b.precio End),3) As 'Mayo'," _
    & " round(avg(Case When month(fec_doc) = 6 Then  b.precio End),3) As 'Junio'," _
    & " round(avg(Case When month(fec_doc) = 7 Then  b.precio End),3) As 'Julio'," _
    & " round(avg(Case When month(fec_doc) = 8 Then  b.precio End),3) As 'Agosto'," _
    & " round(avg(Case When month(fec_doc) = 9 Then  b.precio End),3) As 'Setiembre'," _
    & " round(avg(case when month(fec_doc) = 10 Then  b.precio End),3) As 'Octubre'," _
    & " round(avg(Case When month(fec_doc) = 11 Then  b.precio End),3) As 'Noviembre'," _
    & " round(avg(Case When month(fec_doc) = 12 Then  b.precio End),3) As 'Diciembre'" _
    & " From h_ingreso a" _
    & " inner Join h_ingreso_det b on a.proceso=b.proceso And a.operacion=b.operacion " _
    & " inner Join articulo c on b.cod_art=c.cod_art" _
    & " where  Year(a.fec_doc) =" & annio & " and a.cod_doc In ('01','02')" _
    & " group by b.cod_art order by nom_art"

        Dim comTrans As New MySqlCommand(cad)
        comTrans.Connection = clConex
        da.SelectCommand = comTrans
        da.Fill(ds, "ResumenPrecioProm")
        clConex.Close()
        Return ds
    End Function

    Public Function calculaPrecioPromedioTrans(ByVal cod_art As String, ByVal cPrecioProm As String) As Decimal
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim cad, cad1, cad2, cad3, cad4, cad5 As String, result As Decimal
        cad1 = "select " & cPrecioProm & " as precio"
        cad2 = " from ingreso as h inner join ingreso_det as hd"
        cad3 = " on h.operacion=hd.operacion"
        cad4 = " inner join documento_i on h.cod_doc=documento_i.cod_doc"
        cad5 = " where anul = 0 And cod_art ='" & cod_art & "' And (esIngreso) and precio>0"
        cad = cad1 + cad2 + cad3 + cad4 + cad5
        com.CommandText = cad
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Decimal)
        clConex.Close()
        Return result
    End Function
    Public Function calculaPrecioPromedio(ByVal esh As Boolean, ByVal periodo As String, ByVal cod_art As String, ByVal cPrecioProm As String) As Decimal
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim cad, cad1, cad2, cad3, cad4, cad5 As String, result As Decimal
        cad1 = "select " & cPrecioProm & " as precio"
        If esh Then
            cad2 = " from h_ingreso as h inner join h_ingreso_det as hd on h.proceso=hd.proceso and h.operacion=hd.operacion "
        Else
            cad2 = " from ingreso as h inner join ingreso_det as hd on h.operacion=hd.operacion "
        End If
        cad3 = " inner join documento_i on h.cod_doc=documento_i.cod_doc"
        cad4 = " where anul = 0 And cod_art ='" & cod_art & "' And (esCompra) and precio>0"
        cad5 = IIf(esh, " and h.proceso='" & periodo & "'", "")
        cad = cad1 + cad2 + cad3 + cad4 + cad5
        com.CommandText = cad
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Decimal)
        clConex.Close()
        Return result
    End Function
    Public Function calculaPrecioUltimo(ByVal esh As Boolean, ByVal periodo As String, ByVal cod_art As String, ByVal cPrecioProm As String) As Decimal
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim cad, cad1, cad2, cad3, cad4, cad5, cad6 As String, result As Decimal
        cad1 = "select " & cPrecioProm & " as precio"
        cad5 = " where anul = 0 And cod_art ='" & cod_art & "' And (esCompra) and precio>0"
        If esh Then
            cad2 = " from h_ingreso as h inner join h_ingreso_det as hd on h.proceso=hd.proceso and h.operacion=hd.operacion "
        Else
            cad2 = " from ingreso as h inner join ingreso_det as hd on h.operacion=hd.operacion "
        End If
        cad3 = " inner join documento_i on h.cod_doc=documento_i.cod_doc"
        cad4 = " inner join (select max(hd.operacion) as ope " & cad2 + cad3 + cad5 & ") as s1 on s1.ope=hd.operacion"

        cad6 = IIf(esh, " and h.proceso='" & periodo & "'", "")
        cad = cad1 + cad2 + cad3 + cad4 + cad5
        com.CommandText = cad
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Decimal)
        clConex.Close()
        Return result
    End Function

    Public Function calculaPrecioPromedioh(ByVal cod_art As String, ByVal stringreso As String, ByVal cPrecioProm As String, ByVal eH As Boolean, ByVal pr As String) As Decimal
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim cad, cad1, cad2, cad3, cad4, cad5 As String, result As Decimal
        cad1 = "select " & cPrecioProm & " as precio"
        If eH Then
            cad2 = " from h_ingreso as h inner join h_ingreso_det as hd on h.operacion=hd.operacion and h.proceso=hd.proceso"
        Else
            cad2 = " from ingreso as h inner join ingreso_det as hd on h.operacion=hd.operacion"
        End If
        cad3 = IIf(eH, " and h.proceso='" & pr & "'", "")
        cad4 = " inner join documento_i on h.cod_doc=documento_i.cod_doc"
        cad5 = " where anul = 0 And cod_art ='" & cod_art & "' And (" & stringreso & ") and precio>0"
        cad = cad1 + cad2 + cad3 + cad4 + cad5
        com.CommandText = cad
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Decimal)
        clConex.Close()
        Return result
    End Function
    Public Sub actualizaPrecioPromedio(ByVal cod_art As String, Optional ByVal fec_compra As Date = #1/1/2010#)
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim mfechaI As String = fec_compra.ToString("yyyy-MM-dd")
        Dim nPrecioProm As Decimal
        Dim cPrecioProm As String = "round(sum(if(pre_inc_igv,if(tm='D',(precio*tc)/(1+igv),precio/(1+igv)),if(tm='D',precio*tc,precio))*cant)/sum(cant),3)"
        Dim cad, cad1, cad2 As String
        Dim tpre As New MySqlCommand
        nPrecioProm = calculaPrecioPromedio(False, "", cod_art, cPrecioProm)
        If nPrecioProm > 0 Then
            cad1 = " update articulo set pre_costo=" & nPrecioProm & ",pre_prom=" & nPrecioProm & ",fec_ultcom='" & mfechaI & "'"
            cad2 = " where cod_art ='" & cod_art & "'"
            cad = cad1 + cad2
            com.CommandText = cad
            com.ExecuteNonQuery()
        End If
        clConex.Close()
    End Sub
    Public Sub actualizaCostoArticulo(ByVal eshistorial As Boolean, ByVal periodo As String, ByVal cod_art As String, ByVal ncosto As Decimal)
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        com.CommandTimeout = 300
        Dim cad, cad1, cad2, cad3 As String
        Dim tpre As New MySqlCommand
        cad1 = " update articulo set pre_costo=" & ncosto & ",pre_prom=" & ncosto
        cad2 = " where cod_art ='" & cod_art & "'"
        cad = cad1 + cad2
        com.CommandText = cad
        com.ExecuteNonQuery()

        'cad1 = " update salida_det set cant=cant "
        'cad2 = " where cod_art ='" & cod_art & "' and operacion= (select valor from (select max(operacion) as valor from salida_det where cod_art='" & cod_art & "') as consulta)"
        'cad = cad1 + cad2
        'com.CommandText = cad
        'com.ExecuteNonQuery()

        If Not eshistorial Then
            cad1 = " update salida_det set precio=" & ncosto
            cad2 = " where cod_art ='" & cod_art & "'"
            cad = cad1 + cad2
            com.CommandText = cad
            com.ExecuteNonQuery()

            cad1 = " update ingreso_det set precio=" & ncosto
            cad2 = " where cod_art ='" & cod_art & "'"
            cad = cad1 + cad2
            com.CommandText = cad
            com.ExecuteNonQuery()




            cad3 = "  update  inventario_mdet b " &
                " inner Join inventario_m a on a.operacion=b.operacion " &
                " set b.pre_costo=" & ncosto &
                " where cod_alma= '0001' and concat(substring(fec_inv, 1, 4), substring(fec_inv, 6, 2)) ='" & periodo & "'" &
                " And cod_art ='" & cod_art & "'"

            com.CommandText = cad3
            com.ExecuteNonQuery()

        Else

            cad1 = " update h_salida_det Set precio=" & ncosto
            cad2 = " where cod_art ='" & cod_art & "'and proceso='" & periodo & "'"
            cad = cad1 + cad2
            com.CommandText = cad
            com.ExecuteNonQuery()


            cad1 = " update h_ingreso_det b inner join h_ingreso a on a.operacion=b.operacion and a.proceso=b.proceso inner join documento_i d on d.cod_doc=a.cod_doc "
            cad2 = " set b.precio=" & ncosto
            cad3 = " where !esCompra and b.cod_art ='" & cod_art & "'and b.proceso='" & periodo & "'"
            cad = cad1 + cad2 + cad3
            com.CommandText = cad
            com.ExecuteNonQuery()



        End If

        clConex.Close()
    End Sub
    Public Sub actualizaCosto_invInventario(ByVal cod_art As String, ByVal costo As Decimal, ByVal nroIngreso As Integer)
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim cad, cad1, cad2 As String
        cad1 = " update ingreso_det set precio=" & costo
        cad2 = " where cod_art ='" & cod_art & "' and ingreso=" & nroIngreso
        cad = cad1 + cad2
        com.CommandText = cad
        com.ExecuteNonQuery()
        clConex.Close()
    End Sub
    Function devuelvePrecioCosto(ByVal cod_art As String) As Decimal
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, nPrecio As Decimal
        com.Connection = clConex
        Dim cad, cad1, cad2 As String
        cad1 = " select pre_ult from articulo"
        cad2 = " where cod_art ='" & cod_art & "'"
        cad = cad1 + cad2
        com.CommandText = cad
        nPrecio = com.ExecuteScalar()
        clConex.Close()
        Return nPrecio
    End Function
    Function devuelvePrecioPromedio(ByVal cod_art As String) As Decimal
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, nPrecio As Decimal
        com.Connection = clConex
        Dim cad, cad1, cad2 As String
        cad1 = " select pre_prom from articulo"
        cad2 = " where cod_art ='" & cod_art & "'"
        cad = cad1 + cad2
        com.CommandText = cad
        nPrecio = com.ExecuteScalar()
        clConex.Close()
        Return nPrecio
    End Function
End Class
