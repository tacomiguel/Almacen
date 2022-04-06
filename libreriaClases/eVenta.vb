Imports libreriaClases
Imports MySql.Data.MySqlClient
Public Class eVenta
    Public Shared Function dsVentasDiarias() As DataSet
        Dim ds As New DataSet
        ds.Tables.Add(crearTablaVentasDiarias())
        Return ds
    End Function
    Public Shared Function dsVentasMensuales() As DataSet
        Dim ds As New DataSet
        ds.Tables.Add(crearTablaVentasMensuales())
        Return ds
    End Function
    Private Shared Function crearTablaVentasDiarias() As DataTable
        Dim dt As New DataTable("ventasDiarias")
        dt.Columns.Add(New DataColumn("cod_art", GetType(String)))
        dt.Columns.Add(New DataColumn("nom_art", GetType(String)))
        dt.Columns.Add(New DataColumn("nom_uni", GetType(String)))
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
        dt.Columns.Add(New DataColumn("promedio", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("fec_doc", GetType(Date)))
        dt.Columns.Add(New DataColumn("operacion", GetType(Integer)))
        dt.Columns.Add(New DataColumn("salida", GetType(Integer)))
        Return dt
    End Function
    Private Shared Function crearTablaVentasMensuales() As DataTable
        Dim dt As New DataTable("ventasMensuales")
        dt.Columns.Add(New DataColumn("cod_art", GetType(String)))
        dt.Columns.Add(New DataColumn("nom_art", GetType(String)))
        dt.Columns.Add(New DataColumn("nom_uni", GetType(String)))
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
        dt.Columns.Add(New DataColumn("promedio", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("fec_doc", GetType(Date)))
        dt.Columns.Add(New DataColumn("operacion", GetType(Integer)))
        dt.Columns.Add(New DataColumn("salida", GetType(Integer)))
        Return dt
    End Function
    Public Function recuperaVentasxMes(ByVal fechadesde As Date, ByVal fechahasta As Date, ByVal vAlmacen As Boolean, ByVal xAlmacen As Boolean, _
                                    ByVal xGventa As Boolean, ByVal cod_alma As String, ByVal anno As Integer, ByVal agrupado As Boolean, ByVal valor As String) As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim da As New MySqlDataAdapter
        Dim dsVentas As New DataSet
        Dim mfecha1 As String = fechadesde.ToString("yy-MM-dd")
        Dim mfecha2 As String = fechahasta.ToString("yy-MM-dd")
        Dim cad, cad0, cad1, cad2, cad3, cad4, cad5, cad6, cad7, cad8 As String
        cad0 = "select codigo,nombre,cod_Art,nom_Art,pre_venta, pre_costo,(pre_costo/pre_venta)*100 as porcentaje,s.nom_sgrupo, "
        cad1 = "sum(if(month(fecha)=1," & valor & ",0)) as m1,sum(if(month(fecha)=2," & valor & ",0)) as m2,sum(if(month(fecha)=3," & valor & ",0)) as m3,"
        cad2 = "sum(if(month(fecha)=4," & valor & ",0)) as m4,sum(if(month(fecha)=5," & valor & ",0)) as m5,sum(if(month(fecha)=6," & valor & ",0)) as m6,"
        cad3 = "sum(if(month(fecha)=7," & valor & ",0)) as m7,sum(if(month(fecha)=8," & valor & ",0)) as m8,sum(if(month(fecha)=9," & valor & ",0)) as m9,"
        cad4 = "sum(if(month(fecha)=10," & valor & ",0)) as m10,sum(if(month(fecha)=11," & valor & ",0)) as m11,sum(if(month(fecha)=12," & valor & ",0)) as m12"
        cad5 = " from micros_imp m left join articulo a on m.codigo=a.cod_artExt or m.codigo=a.cod_artExt1 or m.codigo=a.cod_artExt2 "
        cad6 = IIf(xGventa, " inner join subgrupo s on a.cod_grupov=s.cod_sgrupo", " left join subgrupo s on a.cod_sgrupo=s.cod_sgrupo")
        'cad7 = " Where year(fecha)=" & anno & " and  m.cod_area='1' and " & IIf(xAlmacen, " a.cod_alma='" & cod_alma & "'", "a.cod_art is null")
        cad7 = " Where year(fecha)=" & anno & " and  m.tip_proceso='1' " & IIf(xAlmacen, " and " & IIf(vAlmacen, " a.cod_alma='", " m.cod_alma='") & cod_alma & "'", "")
        cad8 = " group by codigo"
        cad = cad0 + cad1 + cad2 + cad3 + cad4 + cad5 + cad6 + cad7 + cad8
        Dim com As New MySqlCommand(cad)
        com.Connection = clConex
        com.CommandTimeout = 500
        da.SelectCommand = com
        da.Fill(dsVentas, "ventas")
        clConex.Close()
        Return dsVentas
    End Function

    Public Function recuperaVentas(ByVal eshistorial As Boolean, ByVal agrupado As Boolean, ByVal xAlmacen As Boolean, ByVal cAlmacen As String, ByVal esMensual As Boolean, ByVal fechaInicio As Date, ByVal fechaFinal As Date) As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim da As New MySqlDataAdapter
        Dim ds As New DataSet
        Dim cad, cad1, cad2, cad3, cad31, cad4, cad5, cad6, cad7, cad8, cad9, cad10 As String
        Dim mfechaI As String = fechaInicio.ToString("yyyy-MM-dd")
        Dim mfechaF As String = fechaFinal.ToString("yyyy-MM-dd")
        ',concat(MONTHNAME(fec_doc),year(fec_doc)) as mes
        cad1 = " select fec_doc,hour(fecha) as hora,concat(MONTHNAME(fec_doc),'-',year(fec_doc)) as mes,concat(ser_doc,'-',nro_doc)as documento,nom_tipo,nom_clie,gc.nom_sgrupo as gcompra,gv.nom_sgrupo as gventa,nom_art,precio,if(es_pcosto,0,pre_costo) as pre_costo,cod_sucursal as sucursal," _
            & IIf(agrupado, "sum(cant) as cant,sum(cant*precio) as imp_venta,sum(cant*if(es_pcosto,0,pre_costo)) as imp_costo", "cant,(cant*precio) as imp_venta,(cant*if(es_pcosto,0,pre_costo)) as imp_costo") & ",nom_uni,sd.cod_art "
        cad2 = IIf(eshistorial, " from h_salida s inner join h_salida_det sd", " from salida s inner join salida_det sd")
        cad3 = IIf(eshistorial, " on s.operacion=sd.operacion and s.proceso=sd.proceso", " on s.operacion=sd.operacion")
        cad31 = IIf(eshistorial, " left join h_guia_remision g on g.operacion=s.operacion and s.proceso=g.proceso ", " left join guia_remision g on g.operacion=s.operacion ")
        cad4 = " inner join articulo on sd.cod_art=articulo.cod_art inner join subgrupo gc on gc.cod_sgrupo=articulo.cod_sgrupo left join subgrupo gv on gv.cod_sgrupo=articulo.cod_grupov"
        cad5 = " inner join unidad on articulo.cod_uni=unidad.cod_uni inner join tipo_articulo ta on articulo.cod_tart=ta.cod_tart"
        cad6 = " inner join documento_s d on s.cod_doc=d.cod_doc"
        cad7 = " inner join cliente on s.cod_clie=cliente.cod_clie inner join tipo_cliente on tipo_cliente.cod_tipo=cliente.cod_tipo"
        cad8 = IIf(esMensual, " where d.esVenta=1 ", " where d.esVenta=1 and fec_doc>='" & mfechaI & "'" & " and fec_doc<='" & mfechaF & "'")
        cad9 = IIf(xAlmacen, " and s.cod_alma='" & cAlmacen & "'", "")
        cad10 = IIf(agrupado, " group by sd.cod_art,fec_doc", "") & " order by nom_art,fec_doc"
        cad = cad1 + cad2 + cad3 + cad31 + cad4 + cad5 + cad6 + cad7 + cad8 + cad9 + cad10
        Dim comTrans As New MySqlCommand(cad)
        comTrans.Connection = clConex
        da.SelectCommand = comTrans
        da.Fill(ds, "articulos")
        clConex.Close()
        Return ds
    End Function
    Public Function recuperaVentasxhoras(ByVal eshistorial As Boolean, ByVal agrupado As Boolean, ByVal xAlmacen As Boolean, ByVal cAlmacen As String, ByVal esMensual As Boolean, ByVal fechaInicio As Date, ByVal fechaFinal As Date, ByVal flg_valor As Boolean) As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim da As New MySqlDataAdapter
        Dim ds As New DataSet
        Dim cad, cad1, cad2, cad3, cad4, cad5, cad6, cad7, cad8, cad9, cad10 As String
        Dim mfechaI As String = fechaInicio.ToString("yyyy-MM-dd")
        Dim mfechaF As String = fechaFinal.ToString("yyyy-MM-dd")
        ',concat(MONTHNAME(fec_doc),year(fec_doc)) as mes
        cad1 = "select fec_doc as Fecha,round(sum(cant*precio),2) as VentaBruta,round(sum((cant*precio)/1.18),2) as VentaNeta," _
              & "(select " & IIf(flg_valor, "sum(sd1.cant)", "sum(sd1.cant*sd1.precio)") & " from salida s1 inner join salida_det sd1 on s1.operacion=sd1.operacion  where " & IIf(xAlmacen, "s1.cod_alma='" & cAlmacen & "'", "") & " and fec_doc=s.fec_doc and hour(fecha)=8 )  as  h08," _
              & "(select " & IIf(flg_valor, "sum(sd1.cant)", "sum(sd1.cant*sd1.precio)") & " from salida s1 inner join salida_det sd1 on s1.operacion=sd1.operacion  where " & IIf(xAlmacen, "s1.cod_alma='" & cAlmacen & "'", "") & " and fec_doc=s.fec_doc and hour(fecha)=9 ) as  h09," _
              & "(select " & IIf(flg_valor, "sum(sd1.cant)", "sum(sd1.cant*sd1.precio)") & " from salida s1 inner join salida_det sd1 on s1.operacion=sd1.operacion  where " & IIf(xAlmacen, "s1.cod_alma='" & cAlmacen & "'", "") & " and fec_doc=s.fec_doc and hour(fecha)=10 ) as  h10," _
              & "(select " & IIf(flg_valor, "sum(sd1.cant)", "sum(sd1.cant*sd1.precio)") & " from salida s1 inner join salida_det sd1 on s1.operacion=sd1.operacion  where " & IIf(xAlmacen, "s1.cod_alma='" & cAlmacen & "'", "") & " and fec_doc=s.fec_doc and hour(fecha)=11 ) as  h11," _
              & "(select " & IIf(flg_valor, "sum(sd1.cant)", "sum(sd1.cant*sd1.precio)") & " from salida s1 inner join salida_det sd1 on s1.operacion=sd1.operacion  where " & IIf(xAlmacen, "s1.cod_alma='" & cAlmacen & "'", "") & " and fec_doc=s.fec_doc and hour(fecha)=12 ) as  h12," _
              & "(select " & IIf(flg_valor, "sum(sd1.cant)", "sum(sd1.cant*sd1.precio)") & " from salida s1 inner join salida_det sd1 on s1.operacion=sd1.operacion  where " & IIf(xAlmacen, "s1.cod_alma='" & cAlmacen & "'", "") & " and fec_doc=s.fec_doc and hour(fecha)=13 ) as  h13," _
              & "(select " & IIf(flg_valor, "sum(sd1.cant)", "sum(sd1.cant*sd1.precio)") & " from salida s1 inner join salida_det sd1 on s1.operacion=sd1.operacion  where " & IIf(xAlmacen, "s1.cod_alma='" & cAlmacen & "'", "") & " and fec_doc=s.fec_doc and hour(fecha)=14 ) as  h14," _
              & "(select " & IIf(flg_valor, "sum(sd1.cant)", "sum(sd1.cant*sd1.precio)") & " from salida s1 inner join salida_det sd1 on s1.operacion=sd1.operacion  where " & IIf(xAlmacen, "s1.cod_alma='" & cAlmacen & "'", "") & " and fec_doc=s.fec_doc and hour(fecha)=15 ) as  h15," _
              & "(select " & IIf(flg_valor, "sum(sd1.cant)", "sum(sd1.cant*sd1.precio)") & " from salida s1 inner join salida_det sd1 on s1.operacion=sd1.operacion  where " & IIf(xAlmacen, "s1.cod_alma='" & cAlmacen & "'", "") & " and fec_doc=s.fec_doc and hour(fecha)=16 ) as  h16," _
              & "(select " & IIf(flg_valor, "sum(sd1.cant)", "sum(sd1.cant*sd1.precio)") & " from salida s1 inner join salida_det sd1 on s1.operacion=sd1.operacion  where " & IIf(xAlmacen, "s1.cod_alma='" & cAlmacen & "'", "") & " and fec_doc=s.fec_doc and hour(fecha)=17 ) as  h17," _
              & "(select " & IIf(flg_valor, "sum(sd1.cant)", "sum(sd1.cant*sd1.precio)") & " from salida s1 inner join salida_det sd1 on s1.operacion=sd1.operacion  where " & IIf(xAlmacen, "s1.cod_alma='" & cAlmacen & "'", "") & " and fec_doc=s.fec_doc and hour(fecha)=18 ) as  h18," _
              & "(select " & IIf(flg_valor, "sum(sd1.cant)", "sum(sd1.cant*sd1.precio)") & " from salida s1 inner join salida_det sd1 on s1.operacion=sd1.operacion  where " & IIf(xAlmacen, "s1.cod_alma='" & cAlmacen & "'", "") & " and fec_doc=s.fec_doc and hour(fecha)=19 ) as  h19," _
              & "(select " & IIf(flg_valor, "sum(sd1.cant)", "sum(sd1.cant*sd1.precio)") & " from salida s1 inner join salida_det sd1 on s1.operacion=sd1.operacion  where " & IIf(xAlmacen, "s1.cod_alma='" & cAlmacen & "'", "") & " and fec_doc=s.fec_doc and hour(fecha)=20 ) as  h20," _
              & "(select " & IIf(flg_valor, "sum(sd1.cant)", "sum(sd1.cant*sd1.precio)") & " from salida s1 inner join salida_det sd1 on s1.operacion=sd1.operacion  where " & IIf(xAlmacen, "s1.cod_alma='" & cAlmacen & "'", "") & " and fec_doc=s.fec_doc and hour(fecha)=21 ) as  h21," _
              & "(select " & IIf(flg_valor, "sum(sd1.cant)", "sum(sd1.cant*sd1.precio)") & " from salida s1 inner join salida_det sd1 on s1.operacion=sd1.operacion  where " & IIf(xAlmacen, "s1.cod_alma='" & cAlmacen & "'", "") & " and fec_doc=s.fec_doc and hour(fecha)=22 ) as  h22," _
              & "(select " & IIf(flg_valor, "sum(sd1.cant)", "sum(sd1.cant*sd1.precio)") & " from salida s1 inner join salida_det sd1 on s1.operacion=sd1.operacion  where " & IIf(xAlmacen, "s1.cod_alma='" & cAlmacen & "'", "") & " and fec_doc=s.fec_doc and hour(fecha)=23 ) as  h23"
        cad2 = IIf(eshistorial, " from h_salida s inner join h_salida_det sd", " from salida s inner join salida_det sd")
        cad3 = IIf(eshistorial, " on s.operacion=sd.operacion and s.proceso=sd.proceso", " on s.operacion=sd.operacion")
        cad4 = " inner join articulo on sd.cod_art=articulo.cod_art inner join subgrupo gc on gc.cod_sgrupo=articulo.cod_sgrupo left join subgrupo gv on gv.cod_sgrupo=articulo.cod_grupov"
        cad5 = " inner join unidad on articulo.cod_uni=unidad.cod_uni inner join tipo_articulo ta on articulo.cod_tart=ta.cod_tart"
        cad6 = " inner join documento_s d on s.cod_doc=d.cod_doc"
        cad7 = " inner join cliente on s.cod_clie=cliente.cod_clie inner join tipo_cliente on tipo_cliente.cod_tipo=cliente.cod_tipo"
        cad8 = IIf(esMensual, " where d.esVenta=1 ", " where d.esVenta=1 and fec_doc>='" & mfechaI & "'" & " and fec_doc<='" & mfechaF & "'")
        cad9 = IIf(xAlmacen, " and s.cod_alma='" & cAlmacen & "'", "")
        cad10 = IIf(agrupado, " group by s.fec_doc", "") & " order by fec_doc"
        cad = cad1 + cad2 + cad3 + cad4 + cad5 + cad6 + cad7 + cad8 + cad9 + cad10
        Dim comTrans As New MySqlCommand(cad)
        comTrans.Connection = clConex
        da.SelectCommand = comTrans
        da.Fill(ds, "articulos")
        clConex.Close()
        Return ds
    End Function
    Public Function recuperaRanking(ByVal eshistorial As Boolean, ByVal agrupado As Boolean, ByVal xAlmacen As Boolean, ByVal cAlmacen As String, ByVal esMensual As Boolean, ByVal fechaInicio As Date, ByVal fechaFinal As Date, ByVal flg_ranking As Boolean) As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim da As New MySqlDataAdapter
        Dim ds As New DataSet
        Dim cad, cad1, cad2, cad3, cad4, cad5, cad6, cad7, cad8, cad9, cad10 As String
        Dim mfechaI As String = fechaInicio.ToString("yyyy-MM-dd")
        Dim mfechaF As String = fechaFinal.ToString("yyyy-MM-dd")
        ',concat(MONTHNAME(fec_doc),year(fec_doc)) as mes
        cad1 = " select nom_art as Articulo, sum(cant) as Cantidad "
        cad2 = IIf(eshistorial, " from h_salida s inner join h_salida_det sd", " from salida s inner join salida_det sd")
        cad3 = IIf(eshistorial, " on s.operacion=sd.operacion and s.proceso=sd.proceso", " on s.operacion=sd.operacion")
        cad4 = " inner join articulo on sd.cod_art=articulo.cod_art inner join subgrupo gc on gc.cod_sgrupo=articulo.cod_sgrupo left join subgrupo gv on gv.cod_sgrupo=articulo.cod_grupov"
        cad5 = " inner join unidad on articulo.cod_uni=unidad.cod_uni inner join tipo_articulo ta on articulo.cod_tart=ta.cod_tart"
        cad6 = " inner join documento_s d on s.cod_doc=d.cod_doc"
        cad7 = " inner join cliente on s.cod_clie=cliente.cod_clie inner join tipo_cliente on tipo_cliente.cod_tipo=cliente.cod_tipo"
        cad8 = IIf(esMensual, " where d.esVenta=1 and sd.precio>0", " where d.esVenta=1 and sd.precio>0 and fec_doc>='" & mfechaI & "'" & " and fec_doc<='" & mfechaF & "'")
        cad9 = IIf(xAlmacen, " and s.cod_alma='" & cAlmacen & "'", "")
        cad10 = IIf(agrupado, " group by sd.cod_art", "") & " order by sum(cant) " & IIf(flg_ranking, "desc", "asc") & " limit 10"
        cad = cad1 + cad2 + cad3 + cad4 + cad5 + cad6 + cad7 + cad8 + cad9 + cad10
        Dim comTrans As New MySqlCommand(cad)
        comTrans.Connection = clConex
        da.SelectCommand = comTrans
        da.Fill(ds, "articulos")
        clConex.Close()
        Return ds
    End Function

    Public Function recuperaVentasDiarias(ByVal agrupado As Boolean, ByVal esMensual As Boolean, ByVal fechaInicio As Date, ByVal fechaFinal As Date, ByVal nroDecimales As Integer) As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim da As New MySqlDataAdapter
        Dim ds As New DataSet
        Dim cad, cad1, cad2, cad3, cad4, cad5, cad6, cad7, cad8 As String
        Dim mfechaI As String = fechaInicio.ToString("yyyy-MM-dd")
        Dim mfechaF As String = fechaFinal.ToString("yyyy-MM-dd")
        If agrupado Then
            If nroDecimales = 3 Then
                cad1 = "select salida_det.cod_art,nom_art,nom_uni,sum(cant) as cant,precio,fec_doc,salida_det.operacion,salida"
            Else
                cad1 = "select salida_det.cod_art,nom_art,nom_uni,sum(cant) as cant,precio,fec_doc,salida_det.operacion,salida"
            End If
            cad2 = " from salida inner join salida_det"
            cad3 = " on salida.operacion=salida_det.operacion"
            cad4 = " inner join articulo on salida_det.cod_art=articulo.cod_art"
            cad5 = " inner join unidad on articulo.cod_uni=unidad.cod_uni"
            cad6 = " inner join documento_s on salida.cod_doc=documento_s.cod_doc"
            If esMensual Then
                cad7 = " where esVenta=1 group by cod_art,fec_doc"
                cad8 = " order by nom_art,fec_doc"
            Else
                cad7 = " where esVenta=1 and fec_doc>='" & mfechaI & "'" & " and fec_doc<='" & mfechaF & "'" & " group by cod_art,fec_doc"
                cad8 = " order by nom_art,fec_doc"
            End If
        Else
            If nroDecimales = 3 Then
                cad1 = "select salida_det.cod_art,nom_art,nom_uni,cant,precio,fec_doc,salida_det.operacion,salida"
            Else
                cad1 = "select salida_det.cod_art,nom_art,nom_uni,cant,precio,fec_doc,salida_det.operacion,salida"
            End If
            cad2 = " from salida inner join salida_det"
            cad3 = " on salida.operacion=salida_det.operacion"
            cad4 = " inner join articulo on salida_det.cod_art=articulo.cod_art"
            cad5 = " inner join unidad on articulo.cod_uni=unidad.cod_uni"
            cad6 = " inner join documento_s on salida.cod_doc=documento_s.cod_doc"
            If esMensual Then
                cad7 = " where esVenta=1"
                cad8 = " order by nom_art,fec_doc"
            Else
                cad7 = " where esVenta=1 and fec_doc>='" & mfechaI & "'" & " and fec_doc<='" & mfechaF & "'"
                cad8 = " order by nom_art,fec_doc"
            End If
        End If
        cad = cad1 + cad2 + cad3 + cad4 + cad5 + cad6 + cad7 + cad8
        Dim comTrans As New MySqlCommand(cad)
        comTrans.Connection = clConex
        da.SelectCommand = comTrans
        da.Fill(ds, "articulos")
        clConex.Close()
        Return ds
    End Function
    Public Function recuperaVentasDiarias_historial(ByVal nroProceso As String, ByVal agrupado As Boolean, ByVal esMensual As Boolean, ByVal fechaInicio As Date, ByVal fechaFinal As Date, ByVal nroDecimales As Integer) As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim da As New MySqlDataAdapter
        Dim ds As New DataSet
        Dim cad, cad1, cad2, cad3, cad4, cad5, cad6, cad7, cad8 As String
        Dim mfechaI As String = fechaInicio.ToString("yyyy-MM-dd")
        Dim mfechaF As String = fechaFinal.ToString("yyyy-MM-dd")
        If agrupado Then
            If nroDecimales = 3 Then
                cad1 = "select h_salida_det.cod_art,nom_art,nom_uni,sum(cant) as cant,precio,fec_doc,h_salida_det.operacion,salida"
            Else
                cad1 = "select h_salida_det.cod_art,nom_art,nom_uni,sum(cant) as cant,precio,fec_doc,h_salida_det.operacion,salida"
            End If
            cad2 = " from h_salida inner join h_salida_det"
            cad3 = " on h_salida.operacion=h_salida_det.operacion"
            cad4 = " inner join articulo on h_salida_det.cod_art=articulo.cod_art"
            cad5 = " inner join unidad on articulo.cod_uni=unidad.cod_uni"
            cad6 = " inner join documento_s on h_salida.cod_doc=documento_s.cod_doc"
            If esMensual Then
                cad7 = " where h_salida.proceso='" & nroProceso & "' and h_salida_det.proceso='" & nroProceso & "' and esVenta=1 group by cod_art,fec_doc"
                cad8 = " order by nom_art,fec_doc"
            Else
                cad7 = " where h_salida.proceso='" & nroProceso & "' and h_salida_det.proceso='" & nroProceso & "' and esVenta=1 and fec_doc>='" & mfechaI & "'" & " and fec_doc<='" & mfechaF & "'" & " group by cod_art,fec_doc"
                cad8 = " order by nom_art,fec_doc"
            End If
        Else
            If nroDecimales = 3 Then
                cad1 = "select h_salida_det.cod_art,nom_art,nom_uni,cant,precio,fec_doc,h_salida_det.operacion,salida"
            Else
                cad1 = "select h_salida_det.cod_art,nom_art,nom_uni,cant,precio,fec_doc,h_salida_det.operacion,salida"
            End If
            cad2 = " from h_salida inner join h_salida_det"
            cad3 = " on h_salida.operacion=h_salida_det.operacion"
            cad4 = " inner join articulo on salida_det.cod_art=articulo.cod_art"
            cad5 = " inner join unidad on articulo.cod_uni=unidad.cod_uni"
            cad6 = " inner join documento_s on h_salida.cod_doc=documento_s.cod_doc"
            If esMensual Then
                cad7 = " where h_salida.proceso='" & nroProceso & "' and h_salida_det.proceso='" & nroProceso & "' and esVenta=1"
                cad8 = " order by nom_art,fec_doc"
            Else
                cad7 = " where h_salida.proceso='" & nroProceso & "' and h_salida_det.proceso='" & nroProceso & "' and esVenta=1 and fec_doc>='" & mfechaI & "'" & " and fec_doc<='" & mfechaF & "'"
                cad8 = " order by nom_art,fec_doc"
            End If
        End If
        cad = cad1 + cad2 + cad3 + cad4 + cad5 + cad6 + cad7 + cad8
        Dim comTrans As New MySqlCommand(cad)
        comTrans.Connection = clConex
        da.SelectCommand = comTrans
        da.Fill(ds, "articulos")
        clConex.Close()
        Return ds
    End Function
End Class
