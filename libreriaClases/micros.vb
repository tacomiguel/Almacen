Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic
Public Class micros
    Public Shared Function dsReposicion() As DataSet
        Dim ds As New DataSet
        ds.Tables.Add(crearTablaReposicion())
        Return ds
    End Function
    Private Shared Function crearTablaReposicion() As DataTable
        Dim dt As New DataTable("ventas")
        dt.Columns.Add(New DataColumn("cod_rec", GetType(String)))
        dt.Columns.Add(New DataColumn("cod_art", GetType(String)))
        dt.Columns.Add(New DataColumn("nom_art", GetType(String)))
        dt.Columns.Add(New DataColumn("nom_uni", GetType(String)))
        dt.Columns.Add(New DataColumn("stock_sis", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("costo", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("cant_utilizada", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("costo_utilizado", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("cant_reponer", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("costo_repuesto", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("cant_recibida", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("costo_recibido", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("stock_fis", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("cod_alma", GetType(String)))
        dt.Columns.Add(New DataColumn("nom_alma", GetType(String)))
        Return dt
    End Function
    Public Function inserta(ByVal operacion As Integer, ByVal fecha As Date, _
                        ByVal cod_rec As String, ByVal cod_ext As String, ByVal cant_ven As Decimal, ByVal pre_venta As Decimal) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim sql As String, result As Integer
        Dim mfecha As String = fecha.ToString("yy-MM-dd")
        sql = "Insert Into micros(operacion,fecha,cod_rec,cod_ext,cant_ven,pre_ven)" & _
                "values(" & _
                operacion & ",'" & mfecha & "','" & cod_rec & "','" & cod_ext & "'," & cant_ven & "," & pre_venta & " )"
        com.CommandText = sql
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function
    Public Function inserta_d(ByVal operacion As Integer, ByVal ingreso As Integer, _
                        ByVal cod_art As String, ByVal cantidad As Decimal) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim sql As String, result As Integer
        sql = "Insert Into micros_det(operacion,ingreso,cod_art,cant)" & _
                "values(" & _
                operacion & "," & ingreso & ",'" & cod_art & "'," & cantidad & ")"
        com.CommandText = sql
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function
    Public Function existeReceta(ByVal fecha As Date, ByVal cod_rec As String) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer, cad, cad1, cad2 As String
        com.Connection = clConex
        Dim mfecha As String = fecha.ToString("yy-MM-dd")
        cad1 = "Select count(cod_art) from micros"
        cad2 = " where fecha='" & mfecha & "' and cod_rec='" & cod_rec & "'"
        cad = cad1 + cad2
        com.CommandText = cad
        result = com.ExecuteScalar
        clConex.Close()
        If result = 0 Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Function maxOperacion() As Integer
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer
        com.Connection = clConex
        com.CommandText = "select max(operacion) from micros"
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Integer)
        clConex.Close()
        Return result + 1
    End Function
    Public Function maxIngreso() As Integer
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer
        com.Connection = clConex
        com.CommandText = "select max(ingreso) from micros_det"
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Integer)
        clConex.Close()
        Return result + 1
    End Function
    Public Function recuperaVentas(ByVal eshistorial As Boolean, ByVal tiproc As String, ByVal fechadesde As Date, ByVal fechahasta As Date, ByVal xAlmacen As Boolean, _
                                   ByVal cod_alma As String, ByVal recalcular As Integer, ByVal agrupado As Boolean) As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim da As New MySqlDataAdapter
        Dim dsVentas As New DataSet
        Dim mfecha1 As String = fechadesde.ToString("yy-MM-dd")
        Dim mfecha2 As String = fechahasta.ToString("yy-MM-dd")
        Dim cad As String = ""
        Dim cad1, cad2, cad3, cad3a, cad3b, cad4, cad5, cad6, cad7 As String
        If tiproc = "01" Then
            cad1 = "select m.operacion,m.fecha,m.codigo as cod_micros,m.nombre,a.cod_art,a.nom_art,u.nom_uni,m.tip_proceso,a.cod_area as AreaProd, if(ISNULL(m.cod_alma) or m.cod_alma='', a.cod_alma, m.cod_alma) as cod_alma" & ", "
            cad2 = IIf(agrupado, "sum(canti) as canti,sum(pre_ven) as pre_ven", "canti,pre_ven") & ",dcto,pre_inc_imp,a.factor_prod"
            cad3 = " from micros_imp m left join articulo a on m.codigo=a.cod_artExt or m.codigo=a.cod_artExt1 or m.codigo=a.cod_artExt2 or m.codigo=a.cod_artExt3"
            cad4 = " left join unidad u on a.cod_uni=u.cod_uni"
            cad5 = " Where fecha>='" & mfecha1 & "' and fecha<='" & mfecha2 & "'" & IIf(xAlmacen, " and a.cod_alma='" & cod_alma & "'", "")
            cad6 = " and procesado= " & recalcular
            cad7 = IIf(agrupado, " group by codigo", "") & " order by nom_art"
            cad = cad1 + cad2 + cad3 + cad4 + cad5 + cad6 + cad7
        ElseIf tiproc = "02" Then
            xAlmacen = False
            cad1 = "select r.operacion,r.fec_ini as fecha,rd.cod_recurso as cod_micros,r.nom_evento as nombre,a.cod_art,a.nom_art,u.nom_uni,'1' as tip_proceso,a.cod_area as AreaProd,'" & cod_alma & "' as cod_alma,"
            cad2 = IIf(agrupado, "sum(rd.cant) as canti,sum(0) as pre_ven", "rd.cant as canti,0 as pre_ven") & ",0 as dcto,0 as pre_inc_imp,a.factor_prod"
            cad3 = " from reservas r inner join reservas_det rd on r.operacion=rd.operacion"
            cad4 = " inner join articulo a on rd.cod_recurso=a.cod_art inner join unidad u on a.cod_uni=u.cod_uni"
            cad5 = " Where fec_ini>='" & mfecha1 & "' and fec_ini<='" & mfecha2 & "'" & IIf(xAlmacen, " and a.cod_alma='" & cod_alma & "'", "")
            cad6 = " and procesado= " & recalcular
            cad7 = IIf(agrupado, " group by rd.cod_recurso", "") & " order by a.nom_art"
            cad = cad1 + cad2 + cad3 + cad4 + cad5 + cad6 + cad7
        ElseIf tiproc = "03" Then
            cad1 = "select s.operacion,s.fec_doc as fecha,sd.cod_art as cod_micros,a.nom_art as nombre,a.cod_art,a.nom_art,u.nom_uni,'1' as tip_proceso,a.cod_area as AreaProd,s.cod_alma,"
            cad2 = IIf(agrupado, "sum(sd.cant) as canti,sum(precio) as pre_ven", "sd.cant as canti,precio as pre_ven") & ",0 as dcto,0 as pre_inc_imp,a.factor_prod"
            'cad3 = " from salida s inner join salida_det sd on s.operacion=sd.operacion inner join documento_s d on s.cod_doc=d.cod_doc"

            cad3a = IIf(eshistorial, " from h_salida s inner join h_salida_det sd", " from salida s inner join salida_det sd")
            cad3b = IIf(eshistorial, " on s.operacion=sd.operacion and s.proceso=sd.proceso", " on s.operacion=sd.operacion")

            cad4 = " inner join documento_s d on s.cod_doc=d.cod_doc left join articulo a on sd.cod_art=a.cod_art inner join unidad u on a.cod_uni=u.cod_uni"
            cad5 = " Where (esVenta) and fec_doc>='" & mfecha1 & "' and fec_doc<='" & mfecha2 & "'" & IIf(xAlmacen, " and a.cod_alma='" & cod_alma & "'", "")
            cad6 = " and s.nAux= " & recalcular
            cad7 = IIf(agrupado, " group by rd.cod_recurso", "") & " order by a.nom_art"
            cad = cad1 + cad2 + cad3a + cad3b + cad4 + cad5 + cad6 + cad7
        ElseIf tiproc = "04" Then
            cad1 = "select s.operacion,s.fec_doc as fecha,sd.cod_art as cod_micros,a.nom_art as nombre,a.cod_art,a.nom_art,u.nom_uni,'1' as tip_proceso,a.cod_area as AreaProd,a.cod_alma,"
            cad2 = IIf(agrupado, "sum(sd.cant) as canti,sum(precio) as pre_ven", "sd.cant as canti,precio as pre_ven") & ",0 as dcto,0 as pre_inc_imp,a.factor_prod"

            cad3a = IIf(eshistorial, " from h_salida s inner join h_salida_det sd", " from salida s inner join salida_det sd")
            cad3b = IIf(eshistorial, " on s.operacion=sd.operacion and s.proceso=sd.proceso", " on s.operacion=sd.operacion")

            cad4 = " inner join documento_s d on s.cod_doc=d.cod_doc left join articulo a on sd.cod_art=a.cod_art inner join unidad u on a.cod_uni=u.cod_uni"
            cad5 = " Where (esVenta) and fec_doc>='" & mfecha1 & "' and fec_doc<='" & mfecha2 & "'" & IIf(xAlmacen, " and a.cod_alma='" & cod_alma & "'", "")
            cad6 = " and s.nAux= " & recalcular
            cad7 = IIf(agrupado, " group by rd.cod_recurso", "") & " order by a.nom_art"
            cad = cad1 + cad2 + cad3a + cad3b + cad4 + cad5 + cad6 + cad7

        End If
        Dim com As New MySqlCommand(cad)
        com.Connection = clConex
        com.CommandTimeout = 300
        da.SelectCommand = com
        da.Fill(dsVentas, "ventas")
        clConex.Close()
        Return dsVentas
    End Function

    Public Function recuperaEventos(ByVal fechadesde As Date, ByVal fechahasta As Date, ByVal xAlmacen As Boolean, ByVal cod_alma As String, ByVal agrupado As Boolean) As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim da As New MySqlDataAdapter
        Dim dsVentas As New DataSet
        Dim mfecha1 As String = fechadesde.ToString("yy-MM-dd")
        Dim mfecha2 As String = fechahasta.ToString("yy-MM-dd")
        Dim cad, cad1, cad2, cad3, cad4, cad5, cad6, cad7 As String
        cad1 = "select r.operacion,r.fec_ini as fecha,rd.cod_recurso as cod_micros,r.nom_evento as nombre,a.cod_art,a.nom_art,u.nom_uni,'1' as tip_proceso,a.cod_area as AreaProd,'" & cod_alma & "' as cod_alma,"
        cad2 = IIf(agrupado, "sum(rd.cant) as canti,sum(0) as pre_ven", "rd.cant as canti,0 as pre_ven") & ",0 as dcto,0 as pre_inc_imp,a.factor_prod"
        cad3 = " from reservas r inner join reservas_det rd on r.operacion=rd.operacion"
        cad4 = " inner join articulo a on rd.cod_recurso=a.cod_art inner join unidad u on a.cod_uni=u.cod_uni"
        cad5 = " Where fec_ini>='" & mfecha1 & "' and fec_ini<='" & mfecha2 & "'" & IIf(xAlmacen, " and a.cod_alma='" & cod_alma & "'", "")
        cad6 = " and !(procesado) "
        cad7 = IIf(agrupado, " group by rd.cod_recurso", "") & " order by a.nom_art"
        cad = cad1 + cad2 + cad3 + cad4 + cad5 + cad6 + cad7
        Dim com As New MySqlCommand(cad)
        com.Connection = clConex
        com.CommandTimeout = 300
        da.SelectCommand = com
        da.Fill(dsVentas, "ventas")
        clConex.Close()
        Return dsVentas
    End Function

    Public Function recuperaVentasxDia(ByVal eshistorial As Boolean, ByVal fechadesde As Date, ByVal fechahasta As Date, ByVal vAlmacen As Boolean, ByVal xAlmacen As Boolean, _
                                       ByVal cod_alma As String, ByVal xCliente As Boolean, ByVal xgventa As Boolean, ByVal cod_cli As String, _
                                       ByVal agrupado As Boolean, ByVal valor As String) As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim da As New MySqlDataAdapter
        Dim dsVentas As New DataSet
        Dim mfecha1 As String = fechadesde.ToString("yy-MM-dd")
        Dim mfecha2 As String = fechahasta.ToString("yy-MM-dd")
        Dim cad, cad0, cad1, cad2, cad3, cad4, cad5, cad6, cad7, cad8, cad9, cad10, cad11, cad12 As String
        cad0 = " select codigo,nombre,cod_Art,nom_Art,pre_venta/1.28 as pre_venta, pre_costo,(pre_costo/(pre_venta/1.28))*100 as porcentaje,s.nom_sgrupo,"
        cad1 = " sum(if(day(fecha)=1," & valor & ",0)) as d1,sum(if(day(fecha)=2, " & valor & " ,0)) as d2,sum(if(day(fecha)=3," & valor & ",0)) as d3,sum(if(day(fecha)=4," & valor & ",0)) as d4,"
        cad2 = " sum(if(day(fecha)=5," & valor & ",0)) as d5,sum(if(day(fecha)=6," & valor & ",0)) as d6,sum(if(day(fecha)=7," & valor & ",0)) as d7,sum(if(day(fecha)=8," & valor & ",0)) as d8,"
        cad3 = " sum(if(day(fecha)=9," & valor & ",0)) as d9,sum(if(day(fecha)=10," & valor & ",0)) as d10,sum(if(day(fecha)=11," & valor & ",0)) as d11,sum(if(day(fecha)=12," & valor & ",0)) as d12,"
        cad4 = " sum(if(day(fecha)=13," & valor & ",0)) as d13,sum(if(day(fecha)=14," & valor & ",0)) as d14,sum(if(day(fecha)=15," & valor & ",0)) as d15,sum(if(day(fecha)=16," & valor & ",0)) as d16,"
        cad5 = " sum(if(day(fecha)=17," & valor & ",0)) as d17,sum(if(day(fecha)=18," & valor & ",0)) as d18,sum(if(day(fecha)=19," & valor & ",0)) as d19,sum(if(day(fecha)=20," & valor & ",0)) as d20,"
        cad6 = " sum(if(day(fecha)=21," & valor & ",0)) as d21,sum(if(day(fecha)=22," & valor & ",0)) as d22,sum(if(day(fecha)=23," & valor & ",0)) as d23,sum(if(day(fecha)=24," & valor & ",0)) as d24,"
        cad7 = " sum(if(day(fecha)=25," & valor & ",0)) as d25,sum(if(day(fecha)=26," & valor & ",0)) as d26,sum(if(day(fecha)=27," & valor & ",0)) as d27,sum(if(day(fecha)=28," & valor & ",0)) as d28,"
        cad8 = " sum(if(day(fecha)=29," & valor & ",0)) as d29,sum(if(day(fecha)=30," & valor & ",0)) as d30,sum(if(day(fecha)=31," & valor & ",0)) as d31 "
        cad9 = " from micros_imp m left join articulo a on m.codigo=a.cod_artExt or m.codigo=a.cod_artExt1 or m.codigo=a.cod_artExt2 "
        cad10 = IIf(xgventa, " inner join subgrupo s on a.cod_grupov=s.cod_sgrupo", " left join subgrupo s on a.cod_sgrupo=s.cod_sgrupo")
        'cad11 = " Where fecha>='" & mfecha1 & "' and fecha<='" & mfecha2 & "' and  m.cod_area='1' and " & IIf(xAlmacen, " a.cod_alma='" & cod_alma & "'", "a.cod_art is null")
        cad11 = " Where fecha>='" & mfecha1 & "' and fecha<='" & mfecha2 & "' and  m.tip_proceso='1' " & IIf(xAlmacen, " and " & IIf(vAlmacen, " a.cod_alma='", " m.cod_alma='") & cod_alma & "'", "")
        cad12 = " and codigo not in (select codigo from noitems) group by codigo"
        cad = cad0 + cad1 + cad2 + cad3 + cad4 + cad5 + cad6 + cad7 + cad8 + cad9 + cad10 + cad11 + cad12
        Dim com As New MySqlCommand(cad)
        com.Connection = clConex
        com.CommandTimeout = 300
        da.SelectCommand = com
        da.Fill(dsVentas, "ventas")
        clConex.Close()
        Return dsVentas
    End Function


    Public Function recuperaVentasxMes(ByVal fechadesde As Date, ByVal fechahasta As Date, ByVal vAlmacen As Boolean, ByVal xAlmacen As Boolean, _
                                       ByVal xGventa As Boolean, ByVal cod_alma As String, ByVal anno As Integer, ByVal agrupado As Boolean, ByVal valor As String) As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim da As New MySqlDataAdapter
        Dim dsVentas As New DataSet
        Dim mfecha1 As String = fechadesde.ToString("yy-MM-dd")
        Dim mfecha2 As String = fechahasta.ToString("yy-MM-dd")
        Dim cad, cad0, cad1, cad2, cad3, cad4, cad5, cad6, cad7, cad8 As String
        cad0 = "select codigo,nombre,cod_Art,nom_Art,pre_venta/1.28 as pre_venta, pre_costo,(pre_costo/(pre_venta/1.28))*100 as porcentaje,s.nom_sgrupo, "
        cad1 = "sum(if(month(fecha)=1," & valor & ",0)) as m1,sum(if(month(fecha)=2," & valor & ",0)) as m2,sum(if(month(fecha)=3," & valor & ",0)) as m3,"
        cad2 = "sum(if(month(fecha)=4," & valor & ",0)) as m4,sum(if(month(fecha)=5," & valor & ",0)) as m5,sum(if(month(fecha)=6," & valor & ",0)) as m6,"
        cad3 = "sum(if(month(fecha)=7," & valor & ",0)) as m7,sum(if(month(fecha)=8," & valor & ",0)) as m8,sum(if(month(fecha)=9," & valor & ",0)) as m9,"
        cad4 = "sum(if(month(fecha)=10," & valor & ",0)) as m10,sum(if(month(fecha)=11," & valor & ",0)) as m11,sum(if(month(fecha)=12," & valor & ",0)) as m12"
        cad5 = " from micros_imp m left join articulo a on m.codigo=a.cod_artExt or m.codigo=a.cod_artExt1 or m.codigo=a.cod_artExt2 "
        cad6 = IIf(xGventa, " inner join subgrupo s on a.cod_grupov=s.cod_sgrupo", " left join subgrupo s on a.cod_sgrupo=s.cod_sgrupo")
        'cad7 = " Where year(fecha)=" & anno & " and  m.cod_area='1' and " & IIf(xAlmacen, " a.cod_alma='" & cod_alma & "'", "a.cod_art is null")
        cad7 = " Where year(fecha)=" & anno & " and  m.tip_proceso='1' " & IIf(xAlmacen, " and " & IIf(vAlmacen, " a.cod_alma='", " m.cod_alma='") & cod_alma & "'", "")
        cad8 = " and codigo not in (select codigo from noitems) group by codigo"
        cad = cad0 + cad1 + cad2 + cad3 + cad4 + cad5 + cad6 + cad7 + cad8
        Dim com As New MySqlCommand(cad)
        com.Connection = clConex
        com.CommandTimeout = 500
        da.SelectCommand = com
        da.Fill(dsVentas, "ventas")
        clConex.Close()
        Return dsVentas
    End Function

    Public Function recuperaVentasInsumos(ByVal fecha As Date, ByVal xAlmacen As Boolean, ByVal cod_alma As String, ByVal agrupado As Boolean) As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim da As New MySqlDataAdapter
        Dim dsVentas As New DataSet
        Dim mfecha As String = fecha.ToString("yy-MM-dd")
        Dim cad, cad1, cad2, cad3, cad4, cad5, cad6 As String
        cad1 = "select fecha,articulo.cod_art,nom_art,nom_uni," & IIf(agrupado, "sum(cant) as cant", "cant") & ",pre_costo,es_limpio,articulo.cod_alma"
        cad2 = " from micros inner join micros_det on micros.operacion=micros_det.operacion"
        cad3 = " inner join articulo on micros_det.cod_art=articulo.cod_art"
        cad4 = " inner join unidad on articulo.cod_uni=unidad.cod_uni"
        cad5 = " Where fecha='" & mfecha & "'" & IIf(xAlmacen, " and articulo.cod_alma='" & cod_alma & "'", "")
        cad6 = IIf(agrupado, " group by micros_det.cod_art", "") & " order by nom_art"
        cad = cad1 + cad2 + cad3 + cad4 + cad5 + cad6
        Dim com As New MySqlCommand(cad)
        com.Connection = clConex
        da.SelectCommand = com
        da.Fill(dsVentas, "ventas")
        clConex.Close()
        Return dsVentas
    End Function
    Public Function recuperaCabeceras(ByVal esHistorial As Boolean, ByVal nroProceso As String, ByVal soloCompras As Boolean, ByVal esMensual As Boolean, _
                                    ByVal fechaInicio As Date, ByVal fechaFinal As Date, ByVal nroDecimales As Integer, ByVal agrupado As Boolean, _
                                    ByVal xAlmacen As Boolean, ByVal cod_alma As String) As DataSet
        Dim clConex As New MySqlConnection
        Dim da As New MySqlDataAdapter
        Dim ds As DataSet = Ingreso.dsIngreso
        clConex = Conexion.obtenerConexion
        Dim mfechaI As String = fechaInicio.ToString("yyyy-MM-dd")
        Dim mfechaF As String = fechaFinal.ToString("yyyy-MM-dd")
        Dim cad, cad1, cad2, cad3, cad4, cad5, cad6 As String
        cad1 = "select fecha,micros.operacion,cod_rec,nom_art as nom_rec,nom_uni as uni_rec,"
        cad2 = "sum(cant_ven) as cant_ven,pre_costo as costo,round(pre_ven/cant_ven,3) as precio," _
                & " sum(pre_ven) as monto,round(sum(pre_ven)-(pre_costo*sum(cant_ven)),3) as ganancia"
        cad3 = " from micros inner join articulo on micros.cod_rec=articulo.cod_art" _
                & " inner join unidad on articulo.cod_uni=unidad.cod_uni"
        cad4 = IIf(esMensual, "", " where fecha>='" & mfechaI & "' and fecha<='" & mfechaF & "'")
        cad5 = IIf(agrupado, " group by cod_rec", " group by cod_rec,fecha")
        cad6 = " order by nom_rec"
        cad = cad1 + cad2 + cad3 + cad4 + cad5 + cad6
        Dim com As New MySqlCommand(cad)
        com.Connection = clConex
        da.SelectCommand = com
        da.Fill(ds, "ventas")
        clConex.Close()
        Return ds
    End Function
    Public Function recuperaInsumos(ByVal esHistorial As Boolean, ByVal nroProceso As String, ByVal soloCompras As Boolean, _
                                ByVal esMensual As Boolean, ByVal fechaInicio As Date, ByVal fechaFinal As Date, ByVal nroDecimales As Integer, _
                                ByVal agrupado As Boolean, ByVal xAlmacen As Boolean, ByVal cod_alma As String) As DataSet
        Dim clConex As New MySqlConnection
        Dim da As New MySqlDataAdapter
        Dim ds As DataSet = Ingreso.dsIngreso
        clConex = Conexion.obtenerConexion
        Dim mfechaI As String = fechaInicio.ToString("yyyy-MM-dd")
        Dim mfechaF As String = fechaFinal.ToString("yyyy-MM-dd")
        Dim cad, cad1, cad2, cad3, cad4, cad5, cad6, cad7, cad8, cad9, cad10, cad11, cad12, cad13 As String
        cad1 = "select fecha,cod_rec,receta.nom_art as nom_rec,uniReceta.nom_uni as uni_rec,sum(cant_ven) as cant_ven,"
        cad2 = " receta.pre_costo as costo_rec,round(pre_ven/cant_ven,3) as precio_uniRec,sum(pre_ven) as monto_ven,"
        cad3 = " micros_det.cod_art as cod_ins,articulo.nom_art as nom_ins,uniInsumo.nom_uni as uni_ins,"
        cad4 = " round(sum(cant),3) as cant_venIns,round(sum(articulo.pre_costo*cant),3) as costo_venIns,articulo.cod_alma"
        cad5 = " from micros inner join micros_det on micros.operacion=micros_det.operacion"
        cad6 = " inner join articulo as receta on micros.cod_rec=receta.cod_art"
        cad7 = " inner join unidad as uniReceta on receta.cod_uni=uniReceta.cod_uni"
        cad8 = " inner join articulo on micros_det.cod_art=articulo.cod_art"
        cad9 = " inner join unidad as uniInsumo on articulo.cod_uni=uniInsumo.cod_uni"
        cad10 = IIf(esMensual, "", " where fecha>='" & mfechaI & "' and fecha<='" & mfechaF & "'")
        cad11 = IIf(xAlmacen, " and articulo.cod_alma='" & cod_alma & "'", "")
        cad12 = IIf(agrupado, " group by cod_ins", " group by fecha,cod_ins")
        'cad11 = IIf(agrupado, " group by cod_rec,cod_ins", " group by fecha,cod_rec,cod_ins")
        cad13 = " order by nom_ins"
        cad = cad1 + cad2 + cad3 + cad4 + cad5 + cad6 + cad7 + cad8 + cad9 + cad10 + cad11 + cad12
        Dim com As New MySqlCommand(cad)
        com.Connection = clConex
        da.SelectCommand = com
        da.Fill(ds, "ventas")
        clConex.Close()
        Return ds
    End Function
    Function recuperaCodigoArticulo_almaPrincipal(ByVal esLimpio As Boolean, ByVal cod_artAlma As String) As String
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As String, cad As String
        com.Connection = clConex
        If Not esLimpio Then
            cad = "Select cod_art from art_relaAlmacenes where cod_artAlma='" & cod_artAlma & "'"
        Else
            cad = "Select cod_art from art_limpio where cod_artL='" & cod_artAlma & "'"
        End If
        com.CommandText = cad
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), "", obj), String)
        clConex.Close()
        Return result
    End Function
    Function recuperaArticulo_almaPrincipal(ByVal cod_art As String) As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim ds As New DataSet, cad, cad1, cad2 As String
        Dim da As New MySqlDataAdapter
        cad1 = "select cod_art,nom_art,pre_costo,articulo.cod_uni,cant_uni,nom_uni"
        cad2 = " from articulo inner join unidad on articulo.cod_uni=unidad.cod_uni where cod_art='" & cod_art & "'"
        cad = cad1 + cad2
        Dim com As New MySqlCommand(cad)
        com.Connection = clConex
        da.SelectCommand = com
        da.Fill(ds, "articulo")
        clConex.Close()
        Return ds
    End Function
    Public Function ActualizaProcesoVentas(ByVal tiproc As String, ByVal Ope As Integer, ByVal cod_art As String) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim cad As String = ""
        Dim result As Integer
        Select Case tiproc
            Case "03"
                cad = "update salida set nAux= 1 where operacion=" & Ope

            Case "02"
                cad = "update reservas_det set procesado= 1  where operacion=" & Ope

            Case Else
                cad = "update micros_imp set procesado= 1 where operacion=" & Ope
        End Select

        com.CommandText = cad
        com.CommandTimeout = 300
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function

    Function recuperaCantUnidad_articulo(ByVal cod_art As String) As Decimal
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer, cad As String
        com.Connection = clConex
        cad = "select cant_uni from articulo inner join unidad on articulo.cod_uni=unidad.cod_uni where cod_art='" & cod_art & "'"
        com.CommandText = cad
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0.0, obj), Decimal)
        clConex.Close()
        Return result
    End Function
    Public Function recuperaDespacho_alAlmacen(ByVal fecha As Date, ByVal cod_alma As String, ByVal cod_art As String) As Decimal
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim cad, cad1, cad2, cad3, cad4 As String
        Dim mfecha As String = fecha.ToString("yyyy-MM-dd")
        cad1 = "select sum(cant)as cant"
        cad2 = " from ingreso inner join ingreso_det on ingreso.operacion=ingreso_det.operacion"
        cad3 = " where fec_doc='" & mfecha & "' And cod_alma ='" & cod_alma & "' and cod_art='" & cod_art & "'"
        cad4 = " group by cod_art"
        cad = cad1 + cad2 + cad3 + cad4
        com.CommandText = cad
        Dim obj As Object = com.ExecuteScalar
        Dim result As Decimal = CType(IIf(IsDBNull(obj), 0, obj), Decimal)
        clConex.Close()
        Return result
    End Function
    Public Function existeRegistroDeInsumos(ByVal fecha As Date) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer, sql As String
        com.Connection = clConex
        Dim mfecha As String = fecha.ToString("yyyy-MM-dd")
        sql = "Select count(fecha) from micros where fecha='" & mfecha & "'"
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
    Public Function existeMigracionMicros(ByVal fecha As Date, ByVal timport As String) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer, sql As String
        com.Connection = clConex
        Dim mfecha As String = fecha.ToString("yyyy-MM-dd")
        sql = "Select count(fecha) from micros_imp where fecha='" & mfecha & "' and tip_proceso ='" & timport & "' "
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
    Public Function existeActualizacionStockMicros(ByVal fecha As Date, ByVal cod_alma As String) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer, sql As String
        com.Connection = clConex
        Dim cMicros = "04"
        Dim mfecha As String = fecha.ToString("yyyy-MM-dd")
        sql = "Select count(fecha) from salida where fec_doc='" & mfecha & "' and cod_doc='" & cMicros & "' and cod_alma='" & cod_alma & "'"
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
End Class
