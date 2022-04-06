Imports MySql.Data.MySqlClient
Public Class Salida
    Public Shared Function dsSalida() As DataSet
        Dim ds As New DataSet
        ds.Tables.Add(crearTablaDetalle())
        ds.Tables.Add(crearTablaCabecera())
        ds.Tables.Add(crearTablaSalida())
        Return ds
    End Function
    Private Shared Function crearTablaCabecera() As DataTable
        Dim dt As New DataTable("cabecera")
        dt.Columns.Add(New DataColumn("operacion", GetType(Integer)))
        dt.Columns.Add(New DataColumn("nro_ped", GetType(Integer)))
        dt.Columns.Add(New DataColumn("cod_doc", GetType(String)))
        dt.Columns.Add(New DataColumn("ser_doc", GetType(String)))
        dt.Columns.Add(New DataColumn("nro_doc", GetType(String)))
        dt.Columns.Add(New DataColumn("fec_doc", GetType(Date)))
        dt.Columns.Add(New DataColumn("cod_alma", GetType(String)))
        dt.Columns.Add(New DataColumn("cod_vend", GetType(String)))
        dt.Columns.Add(New DataColumn("cod_clie", GetType(String)))
        dt.Columns.Add(New DataColumn("cod_fpago", GetType(String)))
        dt.Columns.Add(New DataColumn("tm", GetType(String)))
        dt.Columns.Add(New DataColumn("anul", GetType(Boolean)))
        dt.Columns.Add(New DataColumn("pre_inc_igv", GetType(Boolean)))
        Return dt
    End Function
    Private Shared Function crearTablaDetalle() As DataTable
        Dim dt As New DataTable("detalle")
        dt.Columns.Add(New DataColumn("operacion", GetType(Integer)))
        dt.Columns.Add(New DataColumn("salida", GetType(Integer)))
        dt.Columns.Add(New DataColumn("ingreso", GetType(Integer)))
        dt.Columns.Add(New DataColumn("cod_art", GetType(String)))
        dt.Columns.Add(New DataColumn("nom_uni", GetType(String)))
        dt.Columns.Add(New DataColumn("nom_art", GetType(String)))
        dt.Columns.Add(New DataColumn("cantidad", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("precio", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("afecto_igv", GetType(Boolean)))
        dt.Columns.Add(New DataColumn("neto", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("orden", GetType(String)))
        dt.Columns.Add(New DataColumn("saldo", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("igv", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("comi_v", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("comi_jv", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("estado", GetType(String)))
        dt.Columns.Add(New DataColumn("obs", GetType(String)))
        Return dt
    End Function
    Private Shared Function crearTablaSalida() As DataTable
        Dim dt As New DataTable("salida")
        dt.Columns.Add(New DataColumn("operacion", GetType(Integer)))
        dt.Columns.Add(New DataColumn("nro_ped", GetType(Integer)))
        dt.Columns.Add(New DataColumn("ingreso", GetType(Integer)))
        dt.Columns.Add(New DataColumn("salida", GetType(Integer)))
        dt.Columns.Add(New DataColumn("cod_doc", GetType(String)))
        dt.Columns.Add(New DataColumn("ser_doc", GetType(String)))
        dt.Columns.Add(New DataColumn("nro_doc", GetType(String)))
        dt.Columns.Add(New DataColumn("fec_doc", GetType(Date)))
        dt.Columns.Add(New DataColumn("cod_vend", GetType(String)))
        dt.Columns.Add(New DataColumn("nom_vend", GetType(String)))
        dt.Columns.Add(New DataColumn("cod_alma", GetType(String)))
        dt.Columns.Add(New DataColumn("nom_alma", GetType(String)))
        dt.Columns.Add(New DataColumn("nom_uni", GetType(String)))
        dt.Columns.Add(New DataColumn("cod_clie", GetType(String)))
        dt.Columns.Add(New DataColumn("nom_clie", GetType(String)))
        dt.Columns.Add(New DataColumn("raz_soc", GetType(String)))
        dt.Columns.Add(New DataColumn("dir_clie", GetType(String)))
        dt.Columns.Add(New DataColumn("dir_ent", GetType(String)))
        dt.Columns.Add(New DataColumn("nom_cont", GetType(String)))
        dt.Columns.Add(New DataColumn("cod_fpago", GetType(String)))
        dt.Columns.Add(New DataColumn("nom_fpago", GetType(String)))
        dt.Columns.Add(New DataColumn("fono_clie", GetType(String)))
        dt.Columns.Add(New DataColumn("tm", GetType(String)))
        dt.Columns.Add(New DataColumn("obs", GetType(String)))
        dt.Columns.Add(New DataColumn("cant", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("cod_art", GetType(String)))
        dt.Columns.Add(New DataColumn("nom_art", GetType(String)))
        dt.Columns.Add(New DataColumn("precio", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("saldo", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("pre_inc_igv", GetType(Boolean)))
        dt.Columns.Add(New DataColumn("comi_v", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("comi_jv", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("anul", GetType(Boolean)))
        dt.Columns.Add(New DataColumn("estado", GetType(String)))
        Return dt
    End Function
    Public Function recuperaCabecera(ByVal operacion As Integer, ByVal esPedido As Boolean, ByVal eshistorial As Boolean) As DataTable
        Dim clConex As New MySqlConnection
        Dim da As New MySqlDataAdapter
        Dim ds As DataSet = Salida.dsSalida
        Dim dt As DataTable = ds.Tables("cabecera")
        clConex = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        Dim cad, cad1, cad2, cad3, cad4 As String
        If esPedido Then
            cad1 = "select h.operacion,ope_ped,cod_doc,ser_doc,nro_doc,fec_doc,ser_ped,nro_ped,h.cod_vend,nom_vend,"
            cad2 = " h.cod_clie,raz_soc,dir_clie,h.cod_fpago,h.pre_inc_igv,h.anul,h.tm from"
            cad3 = IIf(eshistorial, " h_salida h ", " salida h ") & " left join pedido on h.ope_ped=pedido.operacion left join cliente on h.cod_clie=cliente.cod_clie"
            cad4 = " left join vendedor on h.cod_vend=vendedor.cod_vend where h.operacion=" & operacion
        Else
            cad1 = "select salida.operacion,cod_doc,ser_doc,nro_doc,'0' as ser_ped,'00000' as nro_ped,fec_doc,salida.cod_alma,nom_alma,obs,"
            cad2 = " salida.cod_clie,raz_soc,dir_clie,fono_clie,salida.cod_fpago,salida.pre_inc_igv,salida.tm"
            cad3 = " from salida inner join cliente on salida.cod_clie=cliente.cod_clie inner join almacen on salida.cod_alma=almacen.cod_alma"
            cad4 = " where Salida.operacion = " & operacion
        End If
        cad = cad1 + cad2 + cad3 + cad4
        com.Connection = clConex
        com.CommandText = cad
        da.SelectCommand = com
        da.Fill(ds, "cabecera")
        clConex.Close()
        Return dt
    End Function
    Public Function recuperaCabecera_historial(ByVal nroProceso As String, ByVal operacion As Integer, ByVal esPedido As Boolean) As DataTable
        Dim clConex As New MySqlConnection
        Dim da As New MySqlDataAdapter
        Dim ds As DataSet = Salida.dsSalida
        Dim dt As DataTable = ds.Tables("cabecera")
        clConex = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        Dim cad, cad1, cad2, cad3, cad4 As String
        If esPedido Then
            cad1 = "select h_salida.operacion,ope_ped,cod_doc,ser_doc,nro_doc,fec_doc,ser_ped,nro_ped,h_salida.cod_vend,nom_vend,"
            cad2 = " h_salida.cod_clie,raz_soc,h_salida.cod_fpago,h_salida.pre_inc_igv,h_salida.anul"
            cad3 = " from h_salida inner join h_pedido on h_salida.ope_ped=h_pedido.operacion inner join cliente on h_salida.cod_clie=cliente.cod_clie"
            cad4 = " inner join vendedor on h_salida.cod_vend=vendedor.cod_vend where h_salida.operacion=" & operacion
        Else
            cad1 = "select h_salida.operacion,cod_doc,ser_doc,nro_doc,fec_doc,h_salida.cod_alma,nom_alma,obs,"
            cad2 = " h_salida.cod_clie,raz_soc,dir_clie,fono_clie,h_salida.cod_fpago,h_salida.pre_inc_igv"
            cad3 = " from h_salida inner join cliente on h_salida.cod_clie=cliente.cod_clie inner join almacen on h_salida.cod_alma=almacen.cod_alma"
            cad4 = " where h_salida.proceso='" & nroProceso & "' and h_salida.operacion = " & operacion
        End If
        cad = cad1 + cad2 + cad3 + cad4
        com.Connection = clConex
        com.CommandText = cad
        da.SelectCommand = com
        da.Fill(ds, "cabecera")
        clConex.Close()
        Return dt
    End Function
    Public Function recuperaCabeceras(ByVal esHistorial As Boolean, ByVal Proceso As String, _
                    ByVal esMensual As Boolean, ByVal fechaInicio As Date, ByVal fechaFinal As Date, _
                    ByVal nroDecimales As Integer, ByVal xAlmacen As Boolean, ByVal cod_alma As String, _
                    ByVal xVenta As Boolean, ByVal xCliente As Boolean, ByVal cod_clie As String, ByVal xDocumento As Boolean, _
                    ByVal cod_doc As String, ByVal xVendedor As Boolean, ByVal cod_vend As String) As DataSet
        Dim clConex As New MySqlConnection
        Dim da As New MySqlDataAdapter
        Dim ds As DataSet = Salida.dsSalida
        clConex = Conexion.obtenerConexion
        Dim mfechaI As String = fechaInicio.ToString("yyyy-MM-dd")
        Dim mfechaF As String = fechaFinal.ToString("yyyy-MM-dd")
        Dim cad, cad1, cad2, cad21, cad3, cad4, cad5, cad6, cad7, cad8, cad71, cad72 As String
        cad1 = "select h.operacion,fec_doc,if(nom_clie='',raz_soc,nom_clie) as nom_clie,raz_soc as descripcion,concat(nom_doc,': ',ser_doc,'-',nro_doc)as documento," _
               & "concat(abr,': ',ser_doc,'-',nro_doc)as doc,concat(ser_guia,'-',nro_guia) as nro_guia,cod_sucursal,monto_igv,"
        cad2 = " monto-monto_igv as subTotal,0 as cant,0 as precio,0 as montoSal,nom_alma,fec_pago,ser_doc," _
                & "nro_doc,h.cod_doc,h.cod_clie,anul,cancelado,obs,if(isnull( fp.nom_fpago),forma_pago.nom_fpago,fp.nom_fpago) as nom_fpago,if( ISNULL(hp.imp_pagado),monto,hp.imp_pagado) as monto_doc "
        cad21 = IIf(xVenta, ",codigo,canti,pre_ven", ", '' as codigo,0 as canti,0 as pre_ven")
        cad3 = IIf(esHistorial, " from h_salida as h", " from salida as h")
        cad71 = IIf(xVenta, " inner join micros_imp on h.caux2=micros_imp.operacion", "")
        cad72 = " left join guia_remision g on h.operacion=g.operacion "
        cad4 = " inner join cliente on h.cod_clie=cliente.cod_clie"
        cad5 = " inner join documento_s on h.cod_doc=documento_s.cod_doc"
        cad6 = " inner join forma_pago on h.cod_fpago=forma_pago.cod_fpago"
        cad7 = " inner join almacen on h.cod_alma=almacen.cod_alma left join salida_detpago hp on h.operacion=hp.operacion left join forma_pago fp on hp.cod_fpago=fp.cod_fpago"
        cad8 = " where esventa=1 " & IIf(xAlmacen, " and h.cod_alma ='" & cod_alma & "'", "") _
                & IIf(esHistorial, " and year(h.fec_doc)='" & Proceso & "'", "") _
                & IIf(esMensual, " ", " and fec_doc>='" & mfechaI & "'" & " and fec_doc<='" & mfechaF & "'") _
                & IIf(xCliente, "  and h.cod_clie='" & cod_clie & "'", "") _
                & IIf(xDocumento, " and h.cod_doc='" & cod_doc & "'", "") _
                & IIf(xVendedor, " and h.cod_vend='" & cod_vend & "'", "") _
                & " order by fec_doc,documento "

        cad = cad1 + cad2 + cad21 + cad3 + cad4 + cad5 + cad6 + cad7 + cad71 + cad72 + cad8
        Dim com As New MySqlCommand(cad)
        com.Connection = clConex
        com.CommandTimeout = 500
        da.SelectCommand = com
        da.Fill(ds, "salida")
        clConex.Close()
        Return ds
    End Function
    Public Function recuperaDetalle(ByVal operacion As Integer, ByVal nroDecimales As Integer, ByVal eshistorial As Boolean) As DataTable
        Dim clConex As New MySqlConnection
        Dim da As New MySqlDataAdapter
        Dim ds As DataSet = Salida.dsSalida
        Dim dt As DataTable = ds.Tables("detalle")
        clConex = Conexion.obtenerConexion
        Dim cad, cad1, cad2, cad3, cad4, cad5 As String
        cad1 = "select salida,operacion,ingreso,hd.cod_art,nom_art,nom_uni,cant as cantidad,obs,"
        If nroDecimales = 3 Then
            cad2 = " precio,round(cant*precio,3) as neto,igv,afecto_igv,'reg' as estado"
        Else
            cad2 = " precio,round(cant*precio,2) as neto,igv,afecto_igv,'reg' as estado"
        End If
        cad3 = " from " & IIf(eshistorial, "h_salida_det hd ", "salida_det hd") & " join articulo on hd.cod_art=articulo.cod_art"
        cad4 = " inner join unidad on articulo.cod_uni=unidad.cod_uni"
        cad5 = " where operacion=" & operacion & " order by nom_art"
        cad = cad1 + cad2 + cad3 + cad4 + cad5
        Dim com As New MySqlCommand(cad)
        com.Connection = clConex
        da.SelectCommand = com
        da.Fill(ds, "detalle")
        clConex.Close()
        Return dt
    End Function

    Public Function recuperaDetalle_oc(ByVal operacion As Integer, ByVal nroDecimales As Integer, ByVal eshistorial As Boolean) As DataTable
        Dim clConex As New MySqlConnection
        Dim da As New MySqlDataAdapter
        Dim ds As DataSet = Salida.dsSalida
        Dim dt As DataTable = ds.Tables("detalle")
        clConex = Conexion.obtenerConexion
        Dim cad, cad1, cad2, cad3, cad4, cad5 As String
        cad1 = "select 0 as salida,operacion,ingreso,oc.cod_art,nom_art,nom_uni,oc.cant as cantidad,oc.obs,"
        If nroDecimales = 3 Then
            cad2 = " precio,round(cant*precio,3) as neto,igv,afecto_igv,'reg' as estado"
        Else
            cad2 = " precio,round(cant*precio,2) as neto,igv,afecto_igv,'reg' as estado"
        End If
        cad3 = " from orden_compra_det oc join articulo on oc.cod_art=articulo.cod_art"
        cad4 = " inner join unidad on oc.c_Aux=unidad.cod_uni"
        cad5 = " where operacion=" & operacion & " order by nom_art"
        cad = cad1 + cad2 + cad3 + cad4 + cad5
        Dim com As New MySqlCommand(cad)
        com.Connection = clConex
        da.SelectCommand = com
        da.Fill(ds, "detalle")
        clConex.Close()
        Return dt
    End Function

    Public Function recuperaDetalle_ds(ByVal operacion As Integer, ByVal nroDecimales As Integer) As DataSet
        Dim clConex As New MySqlConnection
        Dim da As New MySqlDataAdapter
        Dim ds As New DataSet
        clConex = Conexion.obtenerConexion
        Dim cad, cad1, cad2, cad3, cad4, cad5 As String
        cad1 = "select salida,operacion,ingreso,salida_det.cod_art,nom_art,nom_uni,cant as cantidad,"
        If nroDecimales = 3 Then
            cad2 = " precio,round(cant*precio,3) as neto,igv,afecto_igv,'reg' as estado"
        Else
            cad2 = " precio,round(cant*precio,2) as neto,igv,afecto_igv,'reg' as estado"
        End If
        cad3 = " from salida_det inner join articulo on salida_det.cod_art=articulo.cod_art"
        cad4 = " inner join unidad on articulo.cod_uni=unidad.cod_uni"
        cad5 = " where operacion=" & operacion & " order by nom_art"
        cad = cad1 + cad2 + cad3 + cad4 + cad5
        Dim com As New MySqlCommand(cad)
        com.Connection = clConex
        da.SelectCommand = com
        da.Fill(ds, "detalle")
        clConex.Close()
        Return ds
    End Function
    Public Function recuperaDetalle_historial(ByVal nroProceso As String, ByVal operacion As Integer, ByVal nroDecimales As Integer) As DataTable
        Dim clConex As New MySqlConnection
        Dim da As New MySqlDataAdapter
        Dim ds As DataSet = Salida.dsSalida
        Dim dt As DataTable = ds.Tables("detalle")
        clConex = Conexion.obtenerConexion
        Dim cad, cad1, cad2, cad3, cad4, cad5 As String
        cad1 = "select salida,operacion,ingreso,h_salida_det.cod_art,nom_art,nom_uni,cant as cantidad,"
        If nroDecimales = 3 Then
            cad2 = " precio,round(cant*precio,3) as neto,igv,afecto_igv,'reg' as estado"
        Else
            cad2 = " precio,round(cant*precio,2) as neto,igv,afecto_igv,'reg' as estado"
        End If
        cad3 = " from h_salida_det inner join articulo on h_salida_det.cod_art=articulo.cod_art"
        cad4 = " inner join unidad on articulo.cod_uni=unidad.cod_uni"
        cad5 = " where proceso='" & nroProceso & "' and operacion=" & operacion & " order by nom_art"
        cad = cad1 + cad2 + cad3 + cad4 + cad5
        Dim com As New MySqlCommand(cad)
        com.Connection = clConex
        da.SelectCommand = com
        da.Fill(ds, "detalle")
        clConex.Close()
        Return dt
    End Function
    Public Function recuperaDetalle_anul(ByVal operacion As Integer, ByVal nroDecimales As Integer) As DataTable
        Dim clConex As New MySqlConnection
        Dim da As New MySqlDataAdapter
        Dim ds As DataSet = Salida.dsSalida
        Dim dt As DataTable = ds.Tables("detalle")
        clConex = Conexion.obtenerConexion
        Dim cad, cad1, cad2, cad3, cad4, cad5 As String
        cad1 = "select salida,operacion,ingreso,salida_anul.cod_art,nom_art,nom_uni,cant as cantidad,precio,"
        If nroDecimales = 3 Then
            cad2 = "round(cant*precio,3) as neto,igv,afecto_igv,salida_anul,'reg' as estado"
        Else
            cad2 = "round(cant*precio,2) as neto,igv,afecto_igv,salida_anul,'reg' as estado"
        End If
        cad3 = " from salida_anul inner join articulo on salida_anul.cod_art=articulo.cod_art"
        cad4 = " inner join unidad on articulo.cod_uni=unidad.cod_uni"
        cad5 = " where operacion=" & operacion & " order by nom_art"
        cad = cad1 + cad2 + cad3 + cad4 + cad5
        Dim com As New MySqlCommand(cad)
        com.Connection = clConex
        da.SelectCommand = com
        da.Fill(ds, "detalle")
        clConex.Close()
        Return dt
    End Function
    Public Function recuperaDocSalida(ByVal operacion As Integer)
        Dim clConex As New MySqlConnection
        Dim da As New MySqlDataAdapter
        Dim ds As New DataSet
        Dim dt As New DataTable("factura")
        clConex = Conexion.obtenerConexion
        Dim cad, cad1, cad2, cad3, cad4, cad6, cad7, cad8, cad9, cad10 As String
        cad1 = "select articulo.cod_art,fec_doc,ser_doc,nro_doc,raz_soc,cliente.cod_clie,dir_clie,salida.monto as monto_doc,salida.tm,"
        cad2 = " salida.monto_igv, salida.pre_inc_igv,nom_art,cant as cantidad,precio,cant*precio as monto,igv,nom_fpago,"
        cad3 = " salida_det.obs"
        cad4 = " from salida inner join salida_det on salida.operacion=salida_det.operacion"
        cad6 = " left join cliente on salida.cod_clie=cliente.cod_clie"
        cad7 = " inner join articulo on salida_det.cod_art=articulo.cod_art"
        cad8 = " inner join forma_pago on salida.cod_fpago=forma_pago.cod_fpago"
        cad9 = " where salida.operacion=" & operacion
        cad10 = " order by articulo.cod_art"
        cad = cad1 + cad2 + cad3 + cad4 + cad6 + cad7 + cad8 + cad9 + cad10
        Dim com As New MySqlCommand(cad)
        com.Connection = clConex
        da.SelectCommand = com
        da.Fill(ds, "factura")
        clConex.Close()
        Return ds
    End Function

    Public Shared Function recuperaArticulosSalientes_xNS(ByVal agrupado As Boolean, ByVal xDia As Boolean, ByVal fechaProceso As Date, ByVal nroDecimales As Integer, ByVal xAlmacen As Boolean, ByVal cod_alma As String) As DataSet
        Dim clConex As New MySqlConnection
        Dim da As New MySqlDataAdapter
        Dim ds As New DataSet
        Dim cod_ns = "03"
        clConex = Conexion.obtenerConexion
        Dim mfecha = fechaProceso.ToString("yyyy-MM-dd")
        Dim cad, cad1, cad2, cad3, cad4, cad5, cad6, cad7 As String
        If nroDecimales = 3 Then
            cad2 = " round(cant*precio,3)as neto,igv,afecto_igv"
        Else
            cad2 = " round(cant*precio,2)as neto,igv,afecto_igv"
        End If
        cad3 = " from salida inner join salida_det on salida.operacion=salida_det.operacion"
        cad4 = " inner join articulo on salida_det.cod_art=articulo.cod_art"
        cad5 = " inner join unidad on articulo.cod_uni=unidad.cod_uni"
        cad6 = " inner join documento_s on salida.cod_doc=documento_s.cod_doc"
        If agrupado Then
            cad1 = "select salida.operacion,salida,ingreso,salida_det.cod_art,nom_art,nom_uni,sum(cant) as cant,precio,"
            If xDia Then
                If xAlmacen Then
                    cad7 = " where fec_doc='" & mfecha & "'" & " and cod_alma='" & cod_alma & "'" & " and salida.cod_doc='" & cod_ns & "'" & " group by salida_det.cod_art order by nom_art"
                Else
                    cad7 = " where fec_doc='" & mfecha & "'" & " and salida.cod_doc='" & cod_ns & "'" & " group by salida_det.cod_art order by nom_art"
                End If
            Else
                If xAlmacen Then
                    cad7 = " where month(fec_doc)=" & Month(fechaProceso) & " and year(fec_doc)=" & Year(fechaProceso) & " and cod_alma='" & cod_alma & "'" & " and salida.cod_doc='" & cod_ns & "'" & " group by salida_det.cod_art order by nom_art"
                Else
                    cad7 = " where month(fec_doc)=" & Month(fechaProceso) & " and year(fec_doc)=" & Year(fechaProceso) & " and salida.cod_doc='" & cod_ns & "'" & " group by salida_det.cod_art order by nom_art"
                End If
            End If
        Else
            cad1 = "select salida.operacion,salida,ingreso,salida_det.cod_art,nom_art,nom_uni,cant,precio,"
            If xDia Then
                If xAlmacen Then
                    cad7 = " where fec_doc='" & mfecha & "'" & " and cod_alma='" & cod_alma & "'" & " and salida.cod_doc='" & cod_ns & "'" & " order by nom_art"
                Else
                    cad7 = " where fec_doc='" & mfecha & "'" & " and salida.cod_doc='" & cod_ns & "'" & " order by nom_art"
                End If
            Else
                If xAlmacen Then
                    cad7 = " where month(fec_doc)=" & Month(fechaProceso) & " and year(fec_doc)=" & Year(fechaProceso) & " and cod_alma='" & cod_alma & "'" & " and salida.cod_doc='" & cod_ns & "'" & " order by nom_art"
                Else
                    cad7 = " where month(fec_doc)=" & Month(fechaProceso) & " and year(fec_doc)=" & Year(fechaProceso) & " and salida.cod_doc='" & cod_ns & "'" & " order by nom_art"
                End If
            End If
        End If
        cad = cad1 + cad2 + cad3 + cad4 + cad5 + cad6 + cad7
        Dim com As New MySqlCommand(cad)
        com.Connection = clConex
        da.SelectCommand = com
        da.Fill(ds, "artSalientes")
        clConex.Close()
        Return ds
    End Function
    Public Function recuperaCantArticulosSalientes(ByVal esHistorial As Boolean, ByVal Proceso As String,
                ByVal agrupado As Boolean, ByVal soloVendidos As Boolean, ByVal incTransferencias As Boolean, _
                ByVal esMensual As Boolean, ByVal fechaInicio As Date, ByVal fechaFinal As Date, ByVal nroDecimales As Integer, _
                ByVal xArticulo As Boolean, ByVal cod_art As String, ByVal xAlmacen As Boolean, ByVal cod_alma As String, ByVal para_invDiario As Boolean) As DataSet
        Dim clConex As New MySqlConnection
        Dim da As New MySqlDataAdapter
        Dim ds As New DataSet
        clConex = Conexion.obtenerConexion
        Dim mfechaI = fechaInicio.ToString("yyyy-MM-dd")
        Dim mfechaF = fechaFinal.ToString("yyyy-MM-dd")
        Dim cad, cad1, cad2, cad3, cad4, cad5, cad6, cad7, cad8, cad9, cad10 As String
        cad1 = "select h.fec_doc,if(nom_clie='-',h.obs,nom_clie) as nom_clie,h.operacion,concat(nom_doc,': ',ser_doc,'-',nro_doc)as documento,hd.cod_art as codigo,nom_art as Descripcion,nom_uni,precio," _
                & IIf(agrupado, "sum(cant) as canti,", "cant as canti,") & "concat(abr,': ',ser_doc,'-',nro_doc)as doc,"
        cad2 = IIf(agrupado, " round(sum(cant)*precio," & nroDecimales & ") as monto_doc", " round(cant*precio," & nroDecimales & ") as monto_doc") _
                & ",igv,afecto_igv,nom_fpago,fec_pago,nom_alma,nom_sgrupo,anul,cliente.cod_clie,h.cod_doc,ser_doc,nro_doc"
        cad3 = IIf(esHistorial, " from h_salida as h inner join h_salida_det as hd on h.operacion=hd.operacion and h.proceso=hd.proceso", _
                " from salida as h inner join salida_det as hd on h.operacion=hd.operacion")
        cad4 = " inner join almacen on h.cod_alma=almacen.cod_alma inner join articulo on hd.cod_art=articulo.cod_art inner join subgrupo on subgrupo.cod_sgrupo=articulo.cod_sgrupo"
        cad5 = " inner join unidad on articulo.cod_uni=unidad.cod_uni"
        cad6 = " inner join cliente on h.cod_clie=cliente.cod_clie"
        cad7 = " inner join forma_pago on h.cod_fpago=forma_pago.cod_fpago"
        cad8 = " inner join documento_s on h.cod_doc=documento_s.cod_doc"
        cad9 = " where " & IIf(soloVendidos, "(documento_s.esVenta)=1", IIf(incTransferencias, "(esSalidaAlma)", "(esSalida)=1")) _
                    & IIf(esHistorial, " and year(h.fec_doc)='" & Proceso & "'", "") _
                    & IIf(xAlmacen, "  and h.cod_alma='" & cod_alma & "'", "") _
                    & IIf(xArticulo, "  and hd.cod_art='" & cod_art & "'", "") _
                    & IIf(para_invDiario, "  and (es_invDiario)", "") _
                    & IIf(esMensual, "", " and fec_doc>='" & mfechaI & "' and fec_doc<='" & mfechaF & "'")
        cad10 = IIf(agrupado, "group by cod_clie,hd.cod_art order by cod_clie,nom_art ", " ")
        cad = cad1 + cad2 + cad3 + cad4 + cad5 + cad6 + cad7 + cad8 + cad9 + cad10
        Dim com As New MySqlCommand(cad)
        com.Connection = clConex
        com.CommandTimeout = 500
        da.SelectCommand = com
        da.Fill(ds, "salida")
        clConex.Close()
        Return ds
    End Function
    Public Function recuperaPedidoArticulosSalientes(ByVal esHistorial As Boolean, ByVal esProducion As Boolean, ByVal nroProceso As String, _
            ByVal agrupado As Boolean, ByVal soloVendidos As Boolean, ByVal incTransferencias As Boolean, _
            ByVal esMensual As Boolean, ByVal fechaInicio As Date, ByVal fechaFinal As Date, ByVal nroDecimales As Integer, _
            ByVal xAlmacen As Boolean, ByVal cod_alma As String, ByVal xGrupo As Boolean, ByVal cod_grupo As String, ByVal xUnidad As Boolean, ByVal cod_unidad As String, ByVal para_invDiario As Boolean) As DataSet
        Dim clConex As New MySqlConnection
        Dim da As New MySqlDataAdapter
        Dim ds As New DataSet
        clConex = Conexion.obtenerConexion
        Dim mfechaI = fechaInicio.ToString("yyyy-MM-dd")
        Dim mfechaF = fechaFinal.ToString("yyyy-MM-dd")
        Dim cad, cad1, cad2, cad3, cad4, cad5, cad6, cad7, cad8 As String
        cad1 = "select hd.cod_art,nom_art,nom_uni,precio,articulo.cod_sgrupo,nom_sgrupo,h.cod_area,if(h.cod_alma='0012',h.obs,nom_area ) as nom_area, " _
                & IIf(agrupado, "sum(cant) as salida", "cant as salida")
        cad2 = ",0.0000 as inicial,0.0000 as ingreso, 0.0000 as Pedido,0.0000 as stock,0.0000 as ReqAlma, '' as nom_unialma,alma.nom_alma"
        cad3 = IIf(esHistorial, " from h_salida as h inner join h_salida_det as hd on h.operacion=hd.operacion", _
                " from salida as h inner join salida_det as hd on h.operacion=hd.operacion")
        cad4 = " inner join almacen on h.cod_alma=almacen.cod_alma inner join articulo on hd.cod_art=articulo.cod_art inner join almacen as alma on articulo.cod_alma=alma.cod_alma "
        cad5 = " inner join unidad on articulo.cod_uni=unidad.cod_uni inner join subgrupo on subgrupo.cod_sgrupo=articulo.cod_sgrupo"
        cad6 = " inner join documento_s on h.cod_doc=documento_s.cod_doc inner join area on h.cod_area=area.cod_area"
        cad7 = " where !(articulo.es_Gasto) and " & IIf(esProducion, " (subgrupo.esProduccion) and ", "!(subgrupo.esProduccion) and") & IIf(soloVendidos, "(esVenta)=1", IIf(incTransferencias, "(esSalida)", "(esSalida)")) _
                    & IIf(esHistorial, " and h.proceso='" & nroProceso & "' and hd.proceso='" & nroProceso & "'", "") _
                    & IIf(xAlmacen, "  and h.cod_alma='" & cod_alma & "'", "") _
                    & IIf(para_invDiario, "  and (es_invDiario)", "") _
                    & IIf(xGrupo, "  and articulo.cod_sgrupo='" & cod_grupo & "'", "") _
                    & IIf(xUnidad, "  and articulo.cod_uni='" & cod_unidad & "'", "") _
                    & IIf(esMensual, "", " and fec_doc>='" & mfechaI & "' and fec_doc<='" & mfechaF & "'")
        cad8 = " group by if(h.cod_alma='0012',h.obs,nom_area ),hd.cod_art order by nom_area,nom_alma,nom_art"
        cad = cad1 + cad2 + cad3 + cad4 + cad5 + cad6 + cad7 + cad8
        Dim com As New MySqlCommand(cad)
        com.CommandTimeout = 500
        com.Connection = clConex
        da.SelectCommand = com
        da.Fill(ds, "salida")
        clConex.Close()
        Return ds
    End Function
    Function recuperaTotalSalidasArticulo(ByVal esHistorial As Boolean, ByVal nroProceso As String, ByVal fechaProceso As Date, _
                                          ByVal xAlmacen As Boolean, ByVal cod_alma As String, ByVal xArea As Boolean, ByVal cod_area As String, _
                                          ByVal cod_art As String) As Decimal
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim mfecha = fechaProceso.ToString("yyyy-MM-dd")
        Dim cad, cad1, cad2, cad3 As String, result As Decimal
        cad1 = "select sum(cant)"
        If esHistorial Then
            cad2 = " from h_salida as h inner join h_salida_det as hd on h.operacion=hd.operacion"
        Else
            cad2 = " from salida as h inner join salida_det as hd on h.operacion=hd.operacion"
        End If
        cad3 = " where fec_doc<='" & mfecha & "' and cod_art='" & cod_art & "'" _
                & IIf(xAlmacen, " and cod_alma='" & cod_alma & "'", "") _
                & IIf(xArea, " and cod_area='" & cod_area & "'", "") _
                & IIf(esHistorial, " and h.proceso='" & nroProceso & "' and hd.proceso='" & nroProceso & "'", "")
        cad = cad1 + cad2 + cad3
        com.CommandText = cad
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Decimal)
        clConex.Close()
        Return result
    End Function
    Function recuperaSaldoSalidasArticulo(ByVal esHistorial As Boolean, ByVal nroProceso As String, ByVal fechaProceso As Date, _
                                          ByVal xAlmacen As Boolean, ByVal cod_alma As String, ByVal xArea As Boolean, ByVal cArea As String, ByVal cod_art As String) As Decimal
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim mfecha = fechaProceso.ToString("yyyy-MM-dd")
        Dim cad, cad1, cad2, cad3 As String, result As Decimal
        cad1 = "select sum(cant)"
        If esHistorial Then
            cad2 = " from h_salida as h inner join h_salida_det as hd on h.operacion=hd.operacion"
        Else
            cad2 = " from salida as h inner join salida_det as hd on h.operacion=hd.operacion" _
                   & " inner join documento_s on h.cod_doc=documento_s.cod_doc"
        End If
        cad3 = " where (esSalida) and fec_doc='" & mfecha & "' and cod_art='" & cod_art & "'" _
                & IIf(xAlmacen, " and cod_alma='" & cod_alma & "'", "") _
                & IIf(xArea, " and cod_area='" & cArea & "'", "") _
                & IIf(esHistorial, " and h.proceso='" & nroProceso & "' and hd.proceso='" & nroProceso & "'", "")
        cad = cad1 + cad2 + cad3
        com.CommandText = cad
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Decimal)
        clConex.Close()
        Return result
    End Function
    Function recuperaSaldoSalidasArticulo_t1(ByVal esHistorial As Boolean, ByVal nroProceso As String, ByVal fechaProceso As Date, ByVal xAlmacen As Boolean, ByVal cod_alma As String, ByVal cod_art As String) As Decimal
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim mfecha = fechaProceso.ToString("yyyy-MM-dd")
        Dim cad, cad1, cad2, cad3 As String, result As Decimal
        cad1 = "select sum(cant)"
        If esHistorial Then
            cad2 = " from h_salida as h inner join h_salida_det as hd on h.operacion=hd.operacion and h.proceso=hd.proceso"
        Else
            cad2 = " from salida as h inner join salida_det as hd on h.operacion=hd.operacion"

        End If
        cad3 = "  inner join documento_s on h.cod_doc=documento_s.cod_doc where (esSalidaAlma) and fec_doc>='" & mfecha & "' and cod_art='" & cod_art & "'" _
                & IIf(xAlmacen, " and cod_alma='" & cod_alma & "'", "")
        cad = cad1 + cad2 + cad3
        com.CommandText = cad
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Decimal)
        clConex.Close()
        Return result
    End Function
    Public Function recuperaVentasxDia(ByVal eshistorial As Boolean, ByVal fechadesde As Date, ByVal fechahasta As Date, ByVal xAlmacen As Boolean, ByVal cod_alma As String, _
                                       ByVal xCliente As Boolean, ByVal cod_grupo As String, ByVal xUnidad As Boolean, ByVal cod_unidad As String, ByVal agrupado As Boolean, ByVal valor As String) As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim da As New MySqlDataAdapter
        Dim dsVentas As New DataSet
        Dim mfecha1 As String = fechadesde.ToString("yy-MM-dd")
        Dim mfecha2 As String = fechahasta.ToString("yy-MM-dd")
        Dim cad, cad0, cad1, cad2, cad3, cad4, cad5, cad6, cad7, cad8, cad9, cad10, cad11, cad12 As String
        cad0 = "select a.cod_art,a.nom_art,u.nom_uni, "
        cad1 = "sum(if(day(fec_doc)=1," & valor & ",0)) as d1,sum(if(day(fec_doc)=2, " & valor & " ,0)) as d2,sum(if(day(fec_doc)=3," & valor & ",0)) as d3,sum(if(day(fec_doc)=4," & valor & ",0)) as d4,"
        cad2 = "sum(if(day(fec_doc)=5," & valor & ",0)) as d5,sum(if(day(fec_doc)=6," & valor & ",0)) as d6,sum(if(day(fec_doc)=7," & valor & ",0)) as d7,sum(if(day(fec_doc)=8," & valor & ",0)) as d8,"
        cad3 = "sum(if(day(fec_doc)=9," & valor & ",0)) as d9,sum(if(day(fec_doc)=10," & valor & ",0)) as d10,sum(if(day(fec_doc)=11," & valor & ",0)) as d11,sum(if(day(fec_doc)=12," & valor & ",0)) as d12,"
        cad4 = "sum(if(day(fec_doc)=13," & valor & ",0)) as d13,sum(if(day(fec_doc)=14," & valor & ",0)) as d14,sum(if(day(fec_doc)=15," & valor & ",0)) as d15,sum(if(day(fec_doc)=16," & valor & ",0)) as d16,"
        cad5 = "sum(if(day(fec_doc)=17," & valor & ",0)) as d17,sum(if(day(fec_doc)=18," & valor & ",0)) as d18,sum(if(day(fec_doc)=19," & valor & ",0)) as d19,sum(if(day(fec_doc)=20," & valor & ",0)) as d20,"
        cad6 = "sum(if(day(fec_doc)=21," & valor & ",0)) as d21,sum(if(day(fec_doc)=22," & valor & ",0)) as d22,sum(if(day(fec_doc)=23," & valor & ",0)) as d23,sum(if(day(fec_doc)=24," & valor & ",0)) as d24,"
        cad7 = "sum(if(day(fec_doc)=25," & valor & ",0)) as d25,sum(if(day(fec_doc)=26," & valor & ",0)) as d26,sum(if(day(fec_doc)=27," & valor & ",0)) as d27,sum(if(day(fec_doc)=28," & valor & ",0)) as d28,"
        cad8 = "sum(if(day(fec_doc)=29," & valor & ",0)) as d29,sum(if(day(fec_doc)=30," & valor & ",0)) as d30,sum(if(day(fec_doc)=31," & valor & ",0)) as d31 "
        If eshistorial Then
            cad9 = " from h_salida s inner join h_salida_det sd on s.operacion=sd.operacion and s.proceso=sd.proceso "
        Else
            cad9 = " from salida s inner join salida_det sd on s.operacion=sd.operacion "
        End If
        cad10 = " inner join cliente c on s.cod_clie=c.cod_clie inner join articulo a on sd.cod_Art=a.cod_art inner join documento_s d on s.cod_doc=d.cod_doc inner join unidad u on a.cod_uni=u.cod_uni inner join subgrupo g on a.cod_sgrupo=g.cod_sgrupo"
        cad11 = " Where (d.esVenta)  and fec_doc>='" & mfecha1 & "' and fec_doc<='" & mfecha2 & "'" _
                    & IIf(xAlmacen, " and s.cod_alma='" & cod_alma & "'", " ") _
                    & IIf(xCliente, " and a.cod_sgrupo='" & cod_grupo & "'", " ") _
                    & IIf(xUnidad, " and a.cod_uni='" & cod_unidad & "'", " ")
        cad12 = " group by a.cod_Art"
        cad = cad0 + cad1 + cad2 + cad3 + cad4 + cad5 + cad6 + cad7 + cad8 + cad9 + cad10 + cad11 + cad12
        Dim com As New MySqlCommand(cad)
        com.Connection = clConex
        com.CommandTimeout = 500
        da.SelectCommand = com
        da.Fill(dsVentas, "ventas")
        clConex.Close()
        Return dsVentas
    End Function

    'Public Function recuperaVentasxMes(ByVal eshistorial As Boolean, ByVal fechadesde As Date, ByVal fechahasta As Date, ByVal xAlmacen As Boolean, ByVal cod_alma As String, _
    '                               ByVal xCliente As Boolean, ByVal cod_grupo As String, ByVal xUnidad As Boolean, ByVal cod_unidad As String, ByVal agrupado As Boolean, ByVal valor As String) As DataSet
    '    Dim clConex As MySqlConnection = Conexion.obtenerConexion
    '    Dim da As New MySqlDataAdapter
    '    Dim dsVentas As New DataSet
    '    Dim mfecha1 As String = fechadesde.ToString("yy-MM-dd")
    '    Dim mfecha2 As String = fechahasta.ToString("yy-MM-dd")
    '    Dim cad, cad0, cad1, cad2, cad3, cad4, cad5, cad6, cad7, cad8, cad9, cad10, cad11, cad12 As String
    '    cad0 = "select a.cod_art,a.nom_art,u.nom_uni, "
    '    cad1 = "sum(if(month(fec_doc)=1," & valor & ",0)) as m1,sum(if(month(fec_doc)=2, " & valor & " ,0)) as m2,sum(if(month(fec_doc)=3," & valor & ",0)) as m3,sum(if(month(fec_doc)=4," & valor & ",0)) as m4,"
    '    cad2 = "sum(if(month(fec_doc)=5," & valor & ",0)) as m5,sum(if(month(fec_doc)=6," & valor & ",0)) as m6,sum(if(month(fec_doc)=7," & valor & ",0)) as m7,sum(if(month(fec_doc)=8," & valor & ",0)) as m8,"
    '    cad3 = "sum(if(month(fec_doc)=9," & valor & ",0)) as m9,sum(if(month(fec_doc)=10," & valor & ",0)) as m10,sum(if(month(fec_doc)=11," & valor & ",0)) as m11,sum(if(month(fec_doc)=12," & valor & ",0)) as m12"
    '    If eshistorial Then
    '        cad9 = " from h_salida s inner join h_salida_det sd on s.operacion=sd.operacion and s.proceso=sd.proceso "
    '    Else
    '        cad9 = " from salida s inner join salida_det sd on s.operacion=sd.operacion "
    '    End If
    '    cad10 = " inner join cliente c on s.cod_clie=c.cod_clie inner join articulo a on sd.cod_Art=a.cod_art inner join documento_s d on s.cod_doc=d.cod_doc inner join unidad u on a.cod_uni=u.cod_uni inner join subgrupo g on a.cod_sgrupo=g.cod_sgrupo"
    '    cad11 = " Where (d.esVenta)  and fec_doc>='" & mfecha1 & "' and fec_doc<='" & mfecha2 & "'" _
    '                & IIf(xAlmacen, " and s.cod_alma='" & cod_alma & "'", " ") _
    '                & IIf(xCliente, " and a.cod_sgrupo='" & cod_grupo & "'", " ") _
    '                & IIf(xUnidad, " and a.cod_uni='" & cod_unidad & "'", " ")
    '    cad12 = " group by a.cod_Art"
    '    cad = cad0 + cad1 + cad2 + cad3 + cad4 + cad5 + cad6 + cad7 + cad8 + cad9 + cad10 + cad11 + cad12
    '    Dim com As New MySqlCommand(cad)
    '    com.Connection = clConex
    '    com.CommandTimeout = 300
    '    da.SelectCommand = com
    '    da.Fill(dsVentas, "ventas")
    '    clConex.Close()
    '    Return dsVentas
    'End Function


    Public Function recuperaIngresosxDia(ByVal eshistorial As Boolean, ByVal fechadesde As Date, ByVal fechahasta As Date, ByVal xAlmacen As Boolean, ByVal cod_alma As String, _
                                       ByVal xCliente As Boolean, ByVal cod_grupo As String, ByVal xUnidad As Boolean, ByVal cod_unidad As String, ByVal xdocumento As Boolean, ByVal agrupado As Boolean, ByVal valor As String) As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim da As New MySqlDataAdapter
        Dim dsIngresos As New DataSet
        Dim mfecha1 As String = fechadesde.ToString("yy-MM-dd")
        Dim mfecha2 As String = fechahasta.ToString("yy-MM-dd")
        Dim cad, cad0, cad1, cad2, cad3, cad4, cad5, cad6, cad7, cad8, cad9, cad10, cad11, cad12 As String
        cad0 = "select a.cod_art,a.nom_art,u.nom_uni, "
        cad1 = "sum(if(day(fec_doc)=1," & valor & ",0)) as d1,sum(if(day(fec_doc)=2, " & valor & " ,0)) as d2,sum(if(day(fec_doc)=3," & valor & ",0)) as d3,sum(if(day(fec_doc)=4," & valor & ",0)) as d4,"
        cad2 = "sum(if(day(fec_doc)=5," & valor & ",0)) as d5,sum(if(day(fec_doc)=6," & valor & ",0)) as d6,sum(if(day(fec_doc)=7," & valor & ",0)) as d7,sum(if(day(fec_doc)=8," & valor & ",0)) as d8,"
        cad3 = "sum(if(day(fec_doc)=9," & valor & ",0)) as d9,sum(if(day(fec_doc)=10," & valor & ",0)) as d10,sum(if(day(fec_doc)=11," & valor & ",0)) as d11,sum(if(day(fec_doc)=12," & valor & ",0)) as d12,"
        cad4 = "sum(if(day(fec_doc)=13," & valor & ",0)) as d13,sum(if(day(fec_doc)=14," & valor & ",0)) as d14,sum(if(day(fec_doc)=15," & valor & ",0)) as d15,sum(if(day(fec_doc)=16," & valor & ",0)) as d16,"
        cad5 = "sum(if(day(fec_doc)=17," & valor & ",0)) as d17,sum(if(day(fec_doc)=18," & valor & ",0)) as d18,sum(if(day(fec_doc)=19," & valor & ",0)) as d19,sum(if(day(fec_doc)=20," & valor & ",0)) as d20,"
        cad6 = "sum(if(day(fec_doc)=21," & valor & ",0)) as d21,sum(if(day(fec_doc)=22," & valor & ",0)) as d22,sum(if(day(fec_doc)=23," & valor & ",0)) as d23,sum(if(day(fec_doc)=24," & valor & ",0)) as d24,"
        cad7 = "sum(if(day(fec_doc)=25," & valor & ",0)) as d25,sum(if(day(fec_doc)=26," & valor & ",0)) as d26,sum(if(day(fec_doc)=27," & valor & ",0)) as d27,sum(if(day(fec_doc)=28," & valor & ",0)) as d28,"
        cad8 = "sum(if(day(fec_doc)=29," & valor & ",0)) as d29,sum(if(day(fec_doc)=30," & valor & ",0)) as d30,sum(if(day(fec_doc)=31," & valor & ",0)) as d31 "
        If eshistorial Then
            cad9 = " from h_ingreso s inner join h_ingreso_det sd on s.operacion=sd.operacion and s.proceso=sd.proceso "
        Else
            cad9 = " from ingreso s inner join ingreso_det sd on s.operacion=sd.operacion "
        End If
        cad10 = " inner join proveedor c on s.cod_prov=c.cod_prov inner join articulo a on sd.cod_Art=a.cod_art inner join documento_i d on s.cod_doc=d.cod_doc inner join unidad u on a.cod_uni=u.cod_uni inner join subgrupo g on a.cod_sgrupo=g.cod_sgrupo"
        cad11 = " Where (esIngresoAlma) and  fec_doc>='" & mfecha1 & "' and fec_doc<='" & mfecha2 & "'" _
                    & IIf(xAlmacen, " and a.cod_alma='" & cod_alma & "'", " ") _
                    & IIf(xCliente, " and a.cod_sgrupo='" & cod_grupo & "'", " ") _
                    & IIf(xdocumento, " and d.esProduccion ", " ") _
                    & IIf(xUnidad, " and a.cod_uni='" & cod_unidad & "'", " ")

        cad12 = " group by a.cod_Art"
        cad = cad0 + cad1 + cad2 + cad3 + cad4 + cad5 + cad6 + cad7 + cad8 + cad9 + cad10 + cad11 + cad12
        Dim com As New MySqlCommand(cad)
        com.Connection = clConex
        com.CommandTimeout = 500
        da.SelectCommand = com
        da.Fill(dsIngresos, "Ingresos")
        clConex.Close()
        Return dsIngresos
    End Function


    Public Function insertar(ByVal nro_ope As Integer, _
                                ByVal ope_ped As Integer, _
                                ByVal cod_doc As String, _
                                ByVal ser_doc As String, _
                                ByVal nro_doc As String, _
                                ByVal fec_doc As Date, _
                                ByVal cod_vend As String, _
                                ByVal cod_clie As String, _
                                ByVal cod_fpago As String, _
                                ByVal cancelado As Integer, _
                                ByVal pre_inc_igv As Integer, _
                                ByVal nro_dec As Integer, _
                                ByVal cod_alma As String, _
                                ByVal tm As String, _
                                ByVal obs As String, _
                                ByVal cod_emp As String, _
                                ByVal usuario As String) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim sql As String, result As Integer
        Dim mfecha As String = fec_doc.ToString("yy-MM-dd")
        sql = "Insert Into salida(operacion,ope_ped,cod_doc,ser_doc,nro_doc,fec_doc,cod_vend,cod_clie,cod_fpago,cancelado,pre_inc_igv,nro_dec,cod_alma,tm,obs,cod_emp,cuenta)" & _
            "values(" & _
            nro_ope & "," & ope_ped & ",'" & cod_doc & "','" & ser_doc & "','" & nro_doc & "','" & mfecha & "','" & cod_vend & "','" & cod_clie & "','" & cod_fpago & "'," & cancelado & "," & pre_inc_igv & "," & nro_dec & ",'" & cod_alma & "','" & tm & "','" & obs & "','" & cod_emp & "','" & usuario & "')"
        com.CommandText = sql
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function

    Public Function insertar_factura(ByVal nro_ope As Integer,
                            ByVal ope_ped As Integer,
                            ByVal cod_doc As String,
                            ByVal ser_doc As String,
                            ByVal nro_doc As String,
                            ByVal fecha As DateTime,
                            ByVal fec_doc As Date,
                            ByVal fec_prod As Date,
                            ByVal cod_vend As String,
                            ByVal cod_clie As String,
                            ByVal cod_fpago As String,
                            ByVal cancelado As Integer,
                            ByVal pre_inc_igv As Integer,
                            ByVal nro_dec As Integer,
                            ByVal cod_alma As String,
                            ByVal cod_area As String,
                            ByVal obs As String,
                            ByVal cod_emp As String,
                            ByVal usuario As String,
                            ByVal nro_ptovta As String,
                            ByVal subtotal As Decimal,
                            ByVal tip_doc_ref As String,
                            ByVal ser_doc_ref As String,
                            ByVal nro_doc_ref As String,
                            ByVal tc As Decimal
                            ) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim sql As String, result As Integer
        Dim mfecha1 As String = fecha.ToString("yyyy-MM-dd hh:mm:ss")
        Dim mfecha As String = fec_doc.ToString("yyyy-MM-dd")
        Dim mfechaProd As String = fec_prod.ToString("yyyy-MM-dd")
        sql = "Insert Into factura(operacion,ope_ped,cod_doc,ser_doc,nro_doc,fecha,fec_doc,fec_prod,imp_subtotal,tc,
                cod_vend,cod_clie,cod_fpago,cancelado,pre_inc_igv,nro_dec,cod_alma,cod_area,obs,cod_emp,cuenta,nro_ptovta,cod_doc_ref,ser_doc_ref,nro_doc_ref)" &
            "values(" &
            nro_ope & "," & ope_ped & ",'" & cod_doc & "','" & ser_doc & "','" & nro_doc & "','" & mfecha1 & "','" & mfecha & "','" & mfechaProd & "'," & subtotal & "," & tc &
            ",'" & cod_vend & "','" & cod_clie & "','" & cod_fpago & "'," & cancelado & "," & pre_inc_igv & "," & nro_dec & ",'" & cod_alma & "','" & cod_area & "','" & obs &
            "','" & cod_emp & "','" & usuario & "','" & nro_ptovta & "','" & tip_doc_ref & "','" & ser_doc_ref & "','" & nro_doc_ref & "')"
        com.CommandText = sql
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result

    End Function


    Public Function insertar_aux2(ByVal nro_ope As Integer,
                            ByVal ope_ped As Integer,
                            ByVal cod_doc As String,
                            ByVal ser_doc As String,
                            ByVal nro_doc As String,
                            ByVal fec_doc As Date,
                            ByVal cod_vend As String,
                            ByVal cod_clie As String,
                            ByVal cod_fpago As String,
                            ByVal cancelado As Integer,
                            ByVal pre_inc_igv As Integer,
                            ByVal nro_dec As Integer,
                            ByVal cod_alma As String,
                            ByVal tm As String,
                            ByVal obs As String,
                            ByVal cod_emp As String,
                            ByVal caux2 As String,
                            ByVal caux4 As String,
                            ByVal usuario As String) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim sql As String, result As Integer
        Dim mfecha As String = fec_doc.ToString("yy-MM-dd")
        sql = "Insert Into salida(operacion,ope_ped,cod_doc,ser_doc,nro_doc,fec_doc,cod_vend,cod_clie,cod_fpago,cancelado,pre_inc_igv,nro_dec,cod_alma,tm,obs,cod_emp,cAux2,cAux4,cuenta)" &
            "values(" &
            nro_ope & "," & ope_ped & ",'" & cod_doc & "','" & ser_doc & "','" & nro_doc & "','" & mfecha & "','" & cod_vend & "','" & cod_clie & "','" & cod_fpago & "'," & cancelado & "," & pre_inc_igv & "," & nro_dec & ",'" & cod_alma & "','" & tm & "','" & obs & "','" & cod_emp & "','" & caux2 & "','" & caux4 & "','" & usuario & "')"
        com.CommandText = sql
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function
    Public Function insertar_aux(ByVal nro_ope As Integer,
                            ByVal ope_ped As Integer,
                            ByVal cod_doc As String,
                            ByVal ser_doc As String,
                            ByVal nro_doc As String,
                            ByVal fec_doc As Date,
                            ByVal fec_prod As Date,
                            ByVal cod_vend As String,
                            ByVal cod_clie As String,
                            ByVal cod_fpago As String,
                            ByVal cancelado As Integer,
                            ByVal pre_inc_igv As Integer,
                            ByVal nro_dec As Integer,
                            ByVal cod_alma As String,
                            ByVal cod_area As String,
                            ByVal obs As String,
                            ByVal cod_emp As String,
                            ByVal usu_res As String,
                            ByVal usuario As String,
                            ByVal nAux As Integer,
                            ByVal cAux As String,
                            ByVal cAux2 As String) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim sql As String, result As Integer
        Dim mfecha As String = fec_doc.ToString("yyyy-MM-dd")
        Dim mfechaProd As String = fec_prod.ToString("yyyy-MM-dd")
        sql = "Insert Into salida(operacion,ope_ped,cod_doc,ser_doc,nro_doc,fec_doc,fec_prod,cod_vend,cod_clie,cod_fpago,cancelado,pre_inc_igv,nro_dec,cod_alma,cod_area,obs,cod_emp,cuenta,nAux,cAux,cAux2,usu_ins,usu_mod,maquina)" &
            "values(" &
            nro_ope & "," & ope_ped & ",'" & cod_doc & "','" & ser_doc & "','" & nro_doc & "','" & mfecha & "','" & mfechaProd & "','" & cod_vend & "','" & cod_clie & "','" & cod_fpago & "'," & cancelado & "," & pre_inc_igv & "," & nro_dec & ",'" & cod_alma & "','" & cod_area & "','" & obs & "','" & cod_emp & "','" & usu_res _
        & "'," & nAux & ",'" & cAux & "','" & cAux2 & "','" & usuario & "','" & usuario & "','" & "')"
        com.CommandText = sql
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function

    Public Function insertar_aux_his(ByVal esh As Boolean, _
                            ByVal periodo As String, _
                            ByVal nro_ope As Integer, _
                            ByVal ope_ped As Integer, _
                            ByVal cod_doc As String, _
                            ByVal ser_doc As String, _
                            ByVal nro_doc As String, _
                            ByVal fec_doc As Date, _
                            ByVal cod_vend As String, _
                            ByVal cod_clie As String, _
                            ByVal cod_fpago As String, _
                            ByVal cancelado As Integer, _
                            ByVal pre_inc_igv As Integer, _
                            ByVal nro_dec As Integer, _
                            ByVal cod_alma As String, _
                            ByVal cod_area As String, _
                            ByVal obs As String, _
                            ByVal cod_emp As String, _
                            ByVal usuario As String, _
                            ByVal nAux As Integer, _
                            ByVal cAux As String, _
                            ByVal cAux2 As String) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim sql As String, result As Integer
        Dim mfecha As String = fec_doc.ToString("yy-MM-dd")
        sql = "Insert Into " & IIf(esh, "h_salida(proceso,", "salida(") & " operacion,ope_ped,cod_doc,ser_doc,nro_doc,fec_doc,cod_vend,cod_clie,cod_fpago,cancelado,pre_inc_igv,nro_dec,cod_alma,cod_area,obs,cod_emp,cuenta,nAux,cAux,cAux2)" & _
            "values(" & _
            IIf(esh, periodo & ",", "") & nro_ope & "," & ope_ped & ",'" & cod_doc & "','" & ser_doc & "','" & nro_doc & "','" & mfecha & "','" & cod_vend & "','" & cod_clie & "','" & cod_fpago & "'," & cancelado & "," & pre_inc_igv & "," & nro_dec & ",'" & cod_alma & "','" & cod_area & "','" & obs & "','" & cod_emp & "','" & usuario & "'," & nAux & ",'" & cAux & "','" & cAux2 & "')"
        com.CommandText = sql
        com.CommandTimeout = 500
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function

    Public Function insertar_det(ByVal nro_ope As Integer, _
                                    ByVal salida As Integer, _
                                    ByVal ingreso As Integer, _
                                    ByVal cod_art As String, _
                                    ByVal cant As Decimal, _
                                    ByVal precio As Decimal, _
                                    ByVal igv As Decimal, _
                                    ByVal cv As Decimal, _
                                    ByVal cv1 As Decimal) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim sql As String, result As Integer
        sql = "Insert Into salida_det(operacion,salida,ingreso,cod_art,cant,precio,igv,comi_v,comi_jv)" & _
            "values(" & _
            nro_ope & "," & salida & "," & ingreso & ",'" & cod_art & "'," & cant & "," & precio & "," & igv & "," & cv & "," & cv1 & ")"
        com.CommandText = sql
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function
    Public Function insertar_det_his(ByVal esh As Boolean, _
                                ByVal periodo As String, _
                                ByVal nro_ope As Integer, _
                                ByVal salida As Integer, _
                                ByVal ingreso As Integer, _
                                ByVal cod_art As String, _
                                ByVal cant As Decimal, _
                                ByVal precio As Decimal, _
                                ByVal igv As Decimal, _
                                ByVal cv As Decimal, _
                                ByVal cv1 As Decimal) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim sql As String, result As Integer
        sql = "Insert Into " & IIf(esh, "h_salida_det(proceso,", "salida_Det(") & "operacion,salida,ingreso,cod_art,cant,precio,igv,comi_v,comi_jv)" & _
            "values(" & _
            IIf(esh, periodo & ",", "") & nro_ope & "," & salida & "," & ingreso & ",'" & cod_art & "'," & cant & "," & precio & "," & igv & "," & cv & "," & cv1 & ")"
        com.CommandText = sql
        com.CommandTimeout = 800
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function

    Public Function insertar_factura_det(ByVal nro_ope As Integer,
                                ByVal salida As Integer,
                                ByVal ingreso As Integer,
                                ByVal cod_art As String,
                                ByVal cant As Decimal,
                                ByVal precio As Decimal,
                                ByVal igv As Decimal,
                                ByVal obs As String,
                                ByVal grupo As String,
                                ByVal imptotal As Decimal,
                                ByVal impsubtotal As Decimal,
                                ByVal impDescuento As Decimal,
                                ByVal porDescuento As Decimal,
                                ByVal impigv As Decimal
                                ) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim sql As String, result As Integer
        sql = "Insert Into factura_det(operacion,salida,ingreso,cod_art,imp_subtotal,imp_total,imp_igv,cant,precio,imp_descuento,por_descuento,igv,descripcion,grupo)" &
            "values(" &
            nro_ope & "," & salida & "," & ingreso & ",'" & cod_art & "'," & impsubtotal & "," & imptotal & "," & impigv & "," & cant & "," & precio & "," & impDescuento & "," & porDescuento & "," & igv & ",'" & obs & "','" & grupo & "')"
        com.CommandText = sql
        com.CommandTimeout = 800
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function
    Public Function insertar_detObs(ByVal nro_ope As Integer,
                                ByVal salida As Integer,
                                ByVal ingreso As Integer,
                                ByVal cod_art As String,
                                ByVal cant As Decimal,
                                ByVal precio As Decimal,
                                ByVal igv As Decimal,
                                ByVal cv As Decimal,
                                ByVal cv1 As Decimal,
                                ByVal obs As String) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim sql As String, result As Integer
        sql = "Insert Into salida_det(operacion,salida,ingreso,cod_art,cant,precio,igv,comi_v,comi_jv,obs)" &
            "values(" &
            nro_ope & "," & salida & "," & ingreso & ",'" & cod_art & "'," & cant & "," & precio & "," & igv & "," & cv & "," & cv1 & ",'" & obs & "')"
        com.CommandText = sql
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function
    Public Function insertar_detAux(ByVal nro_ope As Integer,
                                ByVal salida As Integer,
                                ByVal ingreso As Integer,
                                ByVal cod_art As String,
                                ByVal cant As Decimal,
                                ByVal cant_ped As Decimal,
                                ByVal precio As Decimal,
                                ByVal igv As Decimal,
                                ByVal comi_v As Decimal,
                                ByVal comi_jv As Decimal,
                                ByVal usuario As String,
                                ByVal nAux As Integer,
                                ByVal nAux2 As Integer) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim sql As String, result As Integer
        sql = "Insert Into salida_det(operacion,salida,ingreso,cod_art,cant,cant_ped,precio,igv,comi_v,comi_jv,usu_ins,nAux,nAux2)" &
            "values(" &
            nro_ope & "," & salida & "," & ingreso & ",'" & cod_art & "'," & cant & "," & cant_ped & "," & precio & "," & igv & "," & comi_v & "," & comi_jv & ",'" & usuario & "'," & nAux & "," & nAux2 & ")"
        com.CommandText = sql
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function
    Public Function insertar_detsalida(ByVal nro_ope As Integer,
                                ByVal salida As Integer,
                                ByVal ingreso As Integer,
                                ByVal cod_art As String,
                                ByVal cant As Decimal,
                                ByVal cant_ped As Decimal,
                                ByVal precio As Decimal,
                                ByVal igv As Decimal,
                                ByVal comi_v As Decimal,
                                ByVal comi_jv As Decimal,
                                ByVal usuario As String,
                                ByVal nAux As Integer,
                                ByVal nAux2 As Integer,
                                ByVal esPendiente As Boolean) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim sql As String, result As Integer
        sql = "Insert Into salida_det(operacion,salida,ingreso,cod_art,cant,cant_ped,precio,igv,comi_v,comi_jv,usu_ins,nAux,nAux2,esPendiente)" &
            "values(" &
            nro_ope & "," & salida & "," & ingreso & ",'" & cod_art & "'," & cant & "," & cant_ped & "," & precio & "," & igv & "," & comi_v & "," & comi_jv & ",'" & usuario & "'," & nAux & "," & nAux2 & " ," & esPendiente & ")"
        com.CommandText = sql
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function

    Public Function actualizaPendientes(ByVal nro_ope As Integer,
                                        ByVal salida As Integer,
                                        ByVal estotal As Boolean
                                            ) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim sql As String, result As Integer
        sql = "update salida_det set espendiente=0  where  operacion =" & nro_ope & IIf(estotal, "", " and salida=" & salida)
        com.CommandText = sql
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function


    Public Function actualizaCabecera(ByVal nro_ope As Integer,
                            ByVal fec_doc As Date,
                            ByVal cod_clie As String,
                            ByVal cod_fpago As String,
                            ByVal cancelado As Integer,
                            ByVal pre_inc_igv As Integer,
                            ByVal obs As String,
                            ByVal cAux4 As String,
                            ByVal nro_dec As Integer) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim sql As String, result As Integer
        Dim mfecha As String = Microsoft.VisualBasic.Trim(fec_doc.ToString("yyyy-MM-dd"))
        sql = "update salida set fec_doc='" & mfecha & "'," & "cod_clie='" & cod_clie & "'," & "cod_fpago='" & cod_fpago & "'," & "cancelado=" & cancelado & "," & "pre_inc_igv=" & pre_inc_igv & "," & "obs='" & obs & "'," & "cAux4='" & cAux4 & "'," & "nro_dec=" & nro_dec & " where operacion=" & nro_ope
        com.CommandText = sql
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function
    Public Function actualizaDetalle(ByVal nroSalida As Integer, _
                         ByVal cant As Decimal, _
                         ByVal precio As Decimal, _
                         ByVal igv As Decimal) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim result As Integer
        Dim cad, cad1, cad2 As String
        cad1 = "update salida_det set cant=" & cant & ",precio=" & precio & ",igv=" & igv
        cad2 = " where  salida=" & nroSalida
        cad = cad1 + cad2
        com.CommandText = cad
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function

    Public Function actualizaDetalle_his(ByVal eshis As Boolean, _
                                     ByVal proceso As String, _
                                     ByVal nroOperacion As Integer, _
                             ByVal nroSalida As Integer, _
                             ByVal cant As Decimal, _
                             ByVal precio As Decimal, _
                             ByVal igv As Decimal) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim result As Integer
        Dim cad, cad1, cad2 As String
        cad1 = "update " & IIf(eshis, "h_salida_det", "salida_det") & " set cant=" & cant & ",precio=" & precio & ",igv=" & igv
        cad2 = " where " & IIf(eshis, "proceso='" & proceso & "' and ", "") & "operacion=" & nroOperacion & " and salida=" & nroSalida
        cad = cad1 + cad2
        com.CommandText = cad
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function
    Public Function actualizaDetalleAux(ByVal nroOperacion As Integer, ByVal cod_Art As String, _
                         ByVal cant As Decimal, _
                         ByVal precio As Decimal, _
                         ByVal igv As Decimal) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim result As Integer
        Dim cad, cad1, cad2 As String
        cad1 = "update salida_det set cant=" & cant & ",precio=" & precio & ",igv=" & igv
        cad2 = " where nAux2=" & nroOperacion & " and cod_Art='" & cod_Art & "' "
        cad = cad1 + cad2
        com.CommandText = cad
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function
    Public Function devuelveNroIngreso(ByVal nroOperacion As Integer, ByVal cod_Art As String) As Integer
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer
        com.Connection = clConex
        Dim cad, cad1, cad2
        cad1 = "Select ingreso from salida_det"
        cad2 = " where nAux2=" & nroOperacion & " and cod_Art='" & cod_Art & "' "
        cad = cad1 + cad2
        com.CommandText = cad
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Integer)
        clConex.Close()
        Return result
    End Function
    Public Function actualizaCabeceraTransf(ByVal nroOperacion As Integer,
                                    ByVal fec_doc As Date,
                                    ByVal fec_prod As Date,
                                    ByVal obs As String,
                                    ByVal cod_almadestino As String,
                                    ByVal cod_areadestino As String) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim sql As String, result As Integer
        Dim mfecha As String = Microsoft.VisualBasic.Trim(fec_doc.ToString("yyyy-MM-dd"))
        Dim mfecha1 As String = Microsoft.VisualBasic.Trim(fec_prod.ToString("yyyy-MM-dd"))
        sql = "update salida set fec_doc='" & mfecha & "',fec_prod='" & mfecha1 _
                      & "', obs='" & obs & "',cod_area='" & cod_areadestino & "', cAux='" & cod_almadestino & "',cAux2='" & cod_areadestino _
                      & "'   where operacion=" & nroOperacion
        com.CommandText = sql
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function
    Public Function actualizaEstadoTransf(ByVal nroOperacion As Integer, _
                                ByVal estado As Integer) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim sql As String, result As Integer
        sql = "update salida set nAux=" & estado & " where operacion=" & nroOperacion
        com.CommandText = sql
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function

    Public Function actualizaDetalleTransf(ByVal nroSalida As Integer, _
                                 ByVal cod_art As String, _
                                 ByVal cant As Decimal) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim result As Integer
        Dim cad, cad1, cad2 As String
        cad1 = "update salida_det set cant=" & cant
        cad2 = " where salida=" & nroSalida
        cad = cad1 + cad2
        com.CommandText = cad
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function

    Public Function actualizaIGVcero(ByVal nroSalida As Integer) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim cad, cad1, cad2 As String, result As Integer
        cad1 = "update salida_det set igv=0"
        cad2 = " where salida=" & nroSalida
        cad = cad1 + cad2
        com.CommandText = cad
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function
    Public Function eliminaFacturas(ByVal fecha As Date) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim mfecha As String = Microsoft.VisualBasic.Trim(fecha.ToString("yyyy-MM-dd"))
        Dim cad As String, result As Integer
        cad = "delete from factura where fec_doc='" & mfecha & "'"
        com.CommandText = cad
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function

    Public Function eliminaProcesoVentas(ByVal nroSalida As Integer) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim cad As String, result As Integer
        cad = "delete from salida where cod_doc='04' and Caux2=" & nroSalida
        com.CommandText = cad
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function

    Public Function eliminaItem(ByVal nroSalida As Integer) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim cad As String, result As Integer
        cad = "delete from salida_det where salida=" & nroSalida
        com.CommandText = cad
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function
    Public Function eliminaCabecera(ByVal nroOperacion As Integer) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim cad As String, result As Integer
        cad = "delete from salida where operacion=" & nroOperacion
        com.CommandText = cad
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function
    Public Function existe(ByVal cod_doc As String, ByVal ser_doc As String, ByVal nro_doc As String) As Integer
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer, sql1, sql2, sql As String
        com.Connection = clConex
        sql1 = "Select operacion from salida where cod_doc='" & cod_doc & "' and ser_doc='" & ser_doc & "'" & " and nro_doc='" & nro_doc & "'"
        sql2 = "union Select operacion from h_salida where cod_doc='" & cod_doc & "' and ser_doc='" & ser_doc & "'" & " and nro_doc='" & nro_doc & "'"
        sql = sql1 + sql2
        com.CommandText = sql
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Integer)
        clConex.Close()
        Return result
    End Function

    Public Function eshistorial(ByVal cod_doc As String, ByVal ser_doc As String, ByVal nro_doc As String) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Boolean, sql1, sql2, sql As String
        com.Connection = clConex
        sql1 = "Select false  from salida where cod_doc='" & cod_doc & "' and ser_doc='" & ser_doc & "'" & " and nro_doc='" & nro_doc & "'"
        sql2 = "union select true from h_salida where cod_doc='" & cod_doc & "' and ser_doc='" & ser_doc & "'" & " and nro_doc='" & nro_doc & "'"
        sql = sql1 + sql2
        com.CommandText = sql
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Boolean)
        clConex.Close()
        Return result
    End Function

    Public Function existe_historial(ByVal nroProceso As String, ByVal cod_doc As String, _
                    ByVal ser_doc As String, ByVal nro_doc As String) As Integer
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer, sql As String
        com.Connection = clConex
        sql = "Select operacion from h_salida where proceso='" & nroProceso _
                & "' and cod_doc='" & cod_doc & "' and ser_doc='" & ser_doc & "' and nro_doc='" & nro_doc & "'"
        com.CommandText = sql
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Integer)
        clConex.Close()
        Return result
    End Function
    Public Function existeNC(ByVal cod_prov As String, ByVal cod_doc As String, _
                    ByVal ser_doc As String, ByVal nro_doc As String) As Integer
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer, sql As String
        com.Connection = clConex
        sql = "Select operacion from salida where cod_doc='" & cod_doc & "' and ser_doc='" & ser_doc & "'" _
                & " and nro_doc='" & nro_doc & "' and cod_clie='" & cod_prov & "'"
        com.CommandText = sql
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Integer)
        clConex.Close()
        Return result
    End Function
    Public Function devuelve_operacionINC(ByVal operacionS As Integer) As Integer
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer, sql As String
        com.Connection = clConex
        sql = "Select nAux from salida where operacion=" & operacionS
        com.CommandText = sql
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Integer)
        clConex.Close()
        Return result
    End Function
    Public Function existePedido(ByVal nro_opePedido As Integer, ByVal incAnuladas As Boolean) As Integer
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer, sql As String
        com.Connection = clConex
        If incAnuladas Then
            sql = "Select operacion from salida where  ope_ped='" & nro_opePedido & "'"
        Else
            sql = "Select operacion from salida where  ope_ped='" & nro_opePedido & "'" + " and anul=0"
        End If
        com.CommandText = sql
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Integer)
        clConex.Close()
        Return result
    End Function
    Public Function estaAnulada(ByVal nro_ope As Integer) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer, cad, cad1, cad2 As String
        com.Connection = clConex
        cad1 = "Select anul from salida where operacion=" & nro_ope
        cad2 = " union Select anul from h_salida where operacion=" & nro_ope
        cad = cad1 + cad2
        com.CommandText = cad
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), False, obj), Integer)
        clConex.Close()
        Return result
    End Function
    Public Function maxOperacion_fac() As Integer
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer
        com.Connection = clConex
        com.CommandText = "select max(operacion) from factura"
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Integer)
        clConex.Close()
        Return result + 1
    End Function
    Public Function maxOperacion() As Integer
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer
        com.Connection = clConex
        com.CommandText = "select max(operacion) from salida"
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Integer)
        clConex.Close()
        Return result + 1
    End Function
    Public Function maxOperacion_his(ByVal periodo As String) As Integer
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer
        com.Connection = clConex
        com.CommandText = "select max(operacion) from h_salida where proceso ='" & periodo & "' "
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Integer)
        clConex.Close()
        Return result + 1
    End Function
    Public Function maxOperacionI() As Integer
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer
        com.Connection = clConex
        com.CommandText = "select max(operacion) from micros_imp"
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Integer)
        clConex.Close()
        Return result + 1
    End Function
    Public Function maxSalida() As Integer
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer
        com.Connection = clConex
        com.CommandText = "select max(salida) from salida_det"
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Integer)
        clConex.Close()
        Return result + 1
    End Function
    Public Function maxfactura_det() As Integer
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer
        com.Connection = clConex
        com.CommandText = "select max(salida) from factura_det"
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Integer)
        clConex.Close()
        Return result + 1
    End Function
    Public Function maxSalida_his(ByVal periodo As String) As Integer
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer
        com.Connection = clConex
        com.CommandText = "select max(salida) from h_salida_det where proceso='" & periodo & "'"
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Integer)
        clConex.Close()
        Return result + 1
    End Function

    Public Function devuelveFechaSalida(ByVal cod_doc As String, ByVal ser_doc As String, ByVal nro_doc As String) As Date
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Date
        com.Connection = clConex
        Dim cad, cad1, cad2
        cad1 = "Select fecha from salida"
        cad2 = " where cod_doc='" & cod_doc & "'" & "and ser_doc='" & ser_doc & "'" & " and nro_doc='" & nro_doc & "'"
        cad = cad1 + cad2
        com.CommandText = cad
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Date)
        clConex.Close()
        Return result
    End Function
    Public Function maxNotaSalida(ByVal ser_doc As String) As String
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer, cod_doc As String = "03"
        com.Connection = clConex
        com.CommandText = "select max(nro_doc) from salida where cod_doc='" & cod_doc & "'" & " and ser_doc='" & ser_doc & "'"
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), "000000000", obj), String)
        Dim resp As String = Right("00000000" & Trim(Str(Microsoft.VisualBasic.Val(result) + 1)), 8)
        clConex.Close()
        Return resp
    End Function
    Public Function maxNroSalida(ByVal cod_doc As String, ByVal ser_doc As String) As String
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As String
        com.Connection = clConex
        com.CommandText = "select max(nro_doc) from salida where cod_doc='" & cod_doc & "'" & " and ser_doc='" & ser_doc & "'"
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), "000000000", obj), String)
        Dim resp As String = Right("00000000" & Trim(Str(Microsoft.VisualBasic.Val(result) + 1)), 8)
        clConex.Close()
        Return resp
    End Function
    Public Function existeNotaSalida(ByVal ser_doc As String, ByVal nro_doc As String) As Integer
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer, cad, cad1, cad2 As String, cod_doc As String = "03"
        com.Connection = clConex
        cad1 = "Select operacion from salida where"
        cad2 = " cod_doc='" & cod_doc & "'" & " and ser_doc='" & ser_doc & "'" & " and nro_doc='" & nro_doc & "'"
        cad = cad1 + cad2
        com.CommandText = cad
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Integer)
        clConex.Close()
        Return result
    End Function
    Public Function existeNotaSalida_historial(ByVal nroProceso As String, ByVal ser_doc As String, ByVal nro_doc As String) As Integer
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer, cad, cad1, cad2 As String, cod_doc As String = "03"
        com.Connection = clConex
        cad1 = "Select operacion from h_salida where"
        cad2 = " proceso='" & nroProceso & "' and cod_doc='" & cod_doc & "'" & " and ser_doc='" & ser_doc & "'" & " and nro_doc='" & nro_doc & "'"
        cad = cad1 + cad2
        com.CommandText = cad
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Integer)
        clConex.Close()
        Return result
    End Function
    Public Function recLotesArticulo(ByVal ingreso As Integer, ByVal cOrden As String) As DataSet
        'usado en el ingreso o compras
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter
        Dim com As New MySqlCommand, cad As String
        com.Connection = clConex
        cad = "Select salida.operacion,salida,cant,precio,igv,salida_det.nAux,salida_det.nAux2" _
                & " from salida inner join salida_det on salida.operacion=salida_det.operacion" _
                & " where ingreso=" & ingreso & " order by " & cOrden
        Dim comSaldo As New MySqlCommand(cad)
        comSaldo.Connection = clConex
        da.SelectCommand = comSaldo
        da.Fill(ds, "articulo")
        clConex.Close()
        Return ds
    End Function
    Public Function recVentas(ByVal empresa As String, ByVal catalogoXalmacen As Boolean, ByVal xfecha As Boolean, ByVal fechaI As Date, ByVal fechaf As Date, ByVal esHistorial As Boolean,
                ByVal periodo As String, ByVal xAlmacen As Boolean, ByVal cod_alma As String, ByVal agrupado As Boolean) As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter
        Dim mfechaI As String = fechaI.ToString("yy-MM-dd")
        Dim mfechaF As String = fechaf.ToString("yy-MM-dd")
        Dim cad, cad1, cad2, cad3, cad4, cad5, cad6 As String
        cad1 = "select salida,hd.cod_art," & IIf(agrupado, "sum(cant) as cant", "cant") & ",precio"
        If esHistorial Then
            cad2 = " from h_salida as h inner join h_salida_det as hd on h.operacion=hd.operacion"
        Else
            cad2 = " from salida as h inner join salida_det as hd on h.operacion=hd.operacion"
        End If
        cad3 = " inner join documento_s on h.cod_doc=documento_s.cod_doc"
        cad4 = " inner join almacen on h.cod_alma=almacen.cod_alma"
        'cad4 = " where(esVenta) and (h.cod_alma='0002' or h.cod_alma='0003')" _
        cad5 = " where   (almacen.es_invMensual) and (documento_s.esVenta)" _
            & IIf(esHistorial, " and h.proceso='" & periodo & "' and hd.proceso='" & periodo & "'", "") _
            & IIf(xAlmacen, " and h.cod_alma='" & cod_alma & "'", "")
        cad6 = IIf(agrupado, " group by hd.cod_art", "") & " order by hd.cod_art"
        cad = cad1 + cad2 + cad3 + cad4 + cad5 + cad6
        Dim com As New MySqlCommand(cad, clConex)
        da.SelectCommand = com
        da.Fill(ds, "venta")
        clConex.Close()
        Return ds
    End Function
    Public Function recventas_fact(ByVal empresa As String, ByVal catalogoXalmacen As Boolean, ByVal xfecha As Boolean, ByVal fechaI As Date, ByVal fechaf As Date, ByVal esHistorial As Boolean,
                ByVal periodo As String, ByVal xAlmacen As Boolean, ByVal cod_alma As String, ByVal agrupado As Boolean) As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter
        Dim mfechaI As String = fechaI.ToString("yyyy-MM-dd")
        Dim mfechaF As String = fechaf.ToString("yyyy-MM-dd")
        Dim cad, cad1, cad2, cad3, cad4, cad5, cad6 As String
        cad1 = "select salida,a.cod_art,nom_art," & IIf(agrupado, "sum(case when h.cod_doc='07' then (cant*-1) else cant end) cant", "cant") & ",precio"
        If esHistorial Then
            cad2 = " from factura as h inner join factura_det as hd on h.operacion=hd.operacion"
            'cad2 = " from h_factura as h inner join h_factura_det hd on h.proceso=hd.proceso and h.operacion=hd.operacion"
        Else
            cad2 = " from factura as h inner join factura_det as hd on h.operacion=hd.operacion"
        End If
        cad3 = " inner join documento_s on h.cod_doc=documento_s.cod_doc"
        cad4 = " inner join ptovta v on v.nroptovta=h.nro_ptovta " _
            & " inner join articulo a on a.cod_artExt=hd.cod_art "
        cad5 = " where   (documento_s.esVenta)" _
            & IIf(xAlmacen, " and v.cod_alma='" & cod_alma & "'", "") _
            & IIf(xfecha, " and (fec_doc) >='" & mfechaI & "' and (fec_doc)<='" & mfechaF & "'", "")
        cad6 = IIf(agrupado, " group by a.cod_art", "") & " order by a.cod_art"
        cad = cad1 + cad2 + cad3 + cad4 + cad5 + cad6
        Dim com As New MySqlCommand(cad, clConex)
        da.SelectCommand = com
        da.Fill(ds, "venta")
        clConex.Close()
        Return ds
    End Function
    Public Function recOtraSalidas(ByVal empresa As String, ByVal catalogoXalmacen As Boolean, ByVal eH As Boolean, _
            ByVal pr As String, ByVal xA As Boolean, ByVal ca As String, ByVal agrupado As Boolean) As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter
        Dim cad, cad1, cad2, cad3, cad4, cad5 As String
        cad1 = "select salida,hd.cod_art," & IIf(agrupado, "sum(cant) as cant", "cant") & ",precio"
        If eH Then
            cad2 = " from h_salida as h inner join h_salida_det as hd on h.operacion=hd.operacion and h.proceso=hd.proceso"
        Else
            cad2 = " from salida as h inner join salida_det as hd on h.operacion=hd.operacion"
        End If
        cad3 = " inner join documento_s on h.cod_doc=documento_s.cod_doc"
        'cad4 = " where(esVenta) and (h.cod_alma='0002' or h.cod_alma='0003')" _
        'cad4 = " where not(documento_s.esVenta) and (documento_s.esSalida)" _
        '   & IIf(esHistorial, " and h.proceso='" & periodo & "' and hd.proceso='" & periodo & "'", "")
        'cad5 = IIf(agrupado, " group by hd.cod_art", "") & " order by hd.cod_art"
        'cad4 = " where (h.cod_doc='90' or h.cod_doc='04' or h.cod_doc='93') and h.cAux<>'0021' and h.cAux<>'0012'" _
        ' and h.cAux<>'0021' and h.cAux<>'0012'
        cad4 = " where (conIMP)  " _
            & IIf(eH, " and h.proceso='" & pr & "'", "") & IIf(xA, " and h.cod_alma='" & ca & "'", "")
        cad5 = IIf(agrupado, " group by cod_art", "") & " order by cod_art"
        cad = cad1 + cad2 + cad3 + cad4 + cad5
        Dim com As New MySqlCommand(cad, clConex)
        da.SelectCommand = com
        da.Fill(ds, "otros")
        clConex.Close()
        Return ds
    End Function
    Public Function recSalidas(ByVal empresa As String, ByVal catalogoXalmacen As Boolean, ByVal xfecha As Boolean, ByVal fechaI As Date, ByVal fechaf As Date, ByVal eH As Boolean,
            ByVal pr As String, ByVal xA As Boolean, ByVal ca As String, ByVal agrupado As Boolean) As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter
        Dim mfechaI As String = fechaI.ToString("yy-MM-dd")
        Dim mfechaF As String = fechaf.ToString("yy-MM-dd")
        Dim cad, cad1, cad2, cad3, cad4, cad5, cad6 As String
        cad1 = "select salida,hd.cod_art," & IIf(agrupado, "sum(cant) as cant", "cant") & ",precio"
        If eH Then
            cad2 = " from h_salida as h inner join h_salida_det as hd on h.operacion=hd.operacion and h.proceso=hd.proceso"
        Else
            cad2 = " from salida as h inner join salida_det as hd on h.operacion=hd.operacion"
        End If
        cad3 = " inner join documento_s on h.cod_doc=documento_s.cod_doc"
        cad4 = " inner join almacen on h.cod_alma=almacen.cod_alma"
        'cad4 = " where(esVenta) and (h.cod_alma='0002' or h.cod_alma='0003')" _
        'cad4 = " where not(documento_s.esVenta) and (documento_s.esSalida)" _
        '   & IIf(esHistorial, " and h.proceso='" & periodo & "' and hd.proceso='" & periodo & "'", "")
        'cad5 = IIf(agrupado, " group by hd.cod_art", "") & " order by hd.cod_art"
        'cad4 = " where (h.cod_doc='90' or h.cod_doc='04' or h.cod_doc='93') and h.cAux<>'0021' and h.cAux<>'0012'" _
        'And h.cAux<>'0021' and h.cAux<>'0006'" _
        cad5 = " where (almacen.es_invMensual) and (esSalidaAlma) " _
            & IIf(eH, " and h.proceso='" & pr & "'", "") & IIf(xA, " and h.cod_alma='" & ca & "'", "") _
            & IIf(xfecha, " and (fec_doc) >='" & mfechaI & "' and (fec_doc)<='" & mfechaF & "'", "")
        cad6 = IIf(agrupado, " group by cod_art", "") & " order by cod_art"
        cad = cad1 + cad2 + cad3 + cad4 + cad5 + cad6
        Dim com As New MySqlCommand(cad, clConex)
        da.SelectCommand = com
        da.Fill(ds, "otros")
        clConex.Close()
        Return ds
    End Function
    Public Function recTransPersonal(ByVal empresa As String, ByVal catalogoXalmacen As Boolean, ByVal eH As Boolean, _
            ByVal pr As String, ByVal xA As Boolean, ByVal ca As String, ByVal agrupado As Boolean) As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter
        Dim cad, cad1, cad2, cad3, cad4, cad5 As String
        cad1 = "select salida,cod_art," & IIf(agrupado, "sum(cant) as cant", "cant") & ",precio"
        If eH Then
            cad2 = " from h_salida as h inner join h_salida_det as hd on h.operacion=hd.operacion and h.proceso=hd.proceso"
        Else
            cad2 = " from salida as h inner join salida_det as hd on h.operacion=hd.operacion"
        End If
        cad3 = " inner join documento_s on h.cod_doc=documento_s.cod_doc"
        cad4 = " where h.cod_doc='90' and h.cAux='0999'" _
            & IIf(eH, " and h.proceso='" & pr & "'", "") & IIf(xA, " and h.cod_alma='" & ca & "'", "")
        cad5 = IIf(agrupado, " group by cod_art", "") & " order by cod_art"
        cad = cad1 + cad2 + cad3 + cad4 + cad5
        Dim com As New MySqlCommand(cad, clConex)
        da.SelectCommand = com
        da.Fill(ds, "personal")
        clConex.Close()
        Return ds
    End Function
    Public Function recTransEventos(ByVal empresa As String, ByVal catalogoXalmacen As Boolean, ByVal eH As Boolean, _
        ByVal pr As String, ByVal xA As Boolean, ByVal ca As String, ByVal agrupado As Boolean) As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter
        Dim cad, cad1, cad2, cad3, cad4, cad5 As String
        cad1 = "select salida,cod_art," & IIf(agrupado, "sum(cant) as cant", "cant") & ",precio"
        If eH Then
            cad2 = " from h_salida as h inner join h_salida_det as hd on h.operacion=hd.operacion and h.proceso=hd.proceso"
        Else
            cad2 = " from salida as h inner join salida_det as hd on h.operacion=hd.operacion"
        End If
        cad3 = " inner join documento_s on h.cod_doc=documento_s.cod_doc"
        cad4 = " where h.cod_doc='90' and h.cAux='0999'" _
            & IIf(eH, " and h.proceso='" & pr & "'", "") & IIf(xA, " and h.cod_alma='" & ca & "'", "")
        cad5 = IIf(agrupado, " group by cod_art", "") & " order by cod_art"
        cad = cad1 + cad2 + cad3 + cad4 + cad5
        Dim com As New MySqlCommand(cad, clConex)
        da.SelectCommand = com
        da.Fill(ds, "evento")
        clConex.Close()
        Return ds
    End Function
    Public Function recTransCocina(ByVal empresa As String, ByVal catalogoXalmacen As Boolean, ByVal eH As Boolean, _
        ByVal pr As String, ByVal xA As Boolean, ByVal ca As String, ByVal agrupado As Boolean) As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter
        Dim cad, cad1, cad2, cad3, cad4, cad5 As String
        cad1 = "select salida,cod_art," & IIf(agrupado, "sum(cant) as cant", "cant") & ",precio"
        If eH Then
            cad2 = " from h_salida as h inner join h_salida_det as hd on h.operacion=hd.operacion and h.proceso=hd.proceso"
        Else
            cad2 = " from salida as h inner join salida_det as hd on h.operacion=hd.operacion"
        End If
        cad3 = " inner join documento_s on h.cod_doc=documento_s.cod_doc"
        cad4 = " where h.cod_doc='90' and h.cAux='0003'" _
            & IIf(eH, " and h.proceso='" & pr & "'", "") & IIf(xA, " and h.cod_alma='" & ca & "'", "")
        cad5 = IIf(agrupado, " group by cod_art", "") & " order by cod_art"
        cad = cad1 + cad2 + cad3 + cad4 + cad5
        Dim com As New MySqlCommand(cad, clConex)
        da.SelectCommand = com
        da.Fill(ds, "cocina")
        clConex.Close()
        Return ds
    End Function
    Public Function recTransBar(ByVal empresa As String, ByVal catalogoXalmacen As Boolean, ByVal eH As Boolean, _
    ByVal pr As String, ByVal xA As Boolean, ByVal ca As String, ByVal agrupado As Boolean) As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter
        Dim cad, cad1, cad2, cad3, cad4, cad5 As String
        cad1 = "select salida,cod_art," & IIf(agrupado, "sum(cant) as cant", "cant") & ",precio"
        If eH Then
            cad2 = " from h_salida as h inner join h_salida_det as hd on h.operacion=hd.operacion and h.proceso=hd.proceso"
        Else
            cad2 = " from salida as h inner join salida_det as hd on h.operacion=hd.operacion"
        End If
        cad3 = " inner join documento_s on h.cod_doc=documento_s.cod_doc"
        cad4 = " where h.cod_doc='90' and h.cAux='0003'" _
            & IIf(eH, " and h.proceso='" & pr & "'", "") & IIf(xA, " and h.cod_alma='" & ca & "'", "")
        cad5 = IIf(agrupado, " group by cod_art", "") & " order by cod_art"
        cad = cad1 + cad2 + cad3 + cad4 + cad5
        Dim com As New MySqlCommand(cad, clConex)
        da.SelectCommand = com
        da.Fill(ds, "Bar")
        clConex.Close()
        Return ds
    End Function

    Public Function recTransOtros(ByVal empresa As String, ByVal catalogoXalmacen As Boolean, ByVal esHistorial As Boolean, _
    ByVal periodo As String, ByVal xAlmacen As Boolean, ByVal cod_alma As String, ByVal agrupado As Boolean) As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter
        Dim cad, cad1, cad2, cad3, cad4, cad5 As String
        cad1 = "select salida,cod_art," & IIf(agrupado, "sum(cant) as cant", "cant") & ",precio"
        If esHistorial Then
            cad2 = " from h_salida as h inner join h_salida_det as hd on h.operacion=hd.operacion"
        Else
            cad2 = " from salida as h inner join salida_det as hd on h.operacion=hd.operacion"
        End If
        cad3 = " inner join documento_s on h.cod_doc=documento_s.cod_doc"
        cad4 = " where h.cod_doc='90' and h.cod_alma<>'0001' and h.cod_alma<>'0002'" _
                & " and h.cod_alma<>'0003' and h.cod_alma<>'0012' and h.cod_alma<>'0021' and h.cod_alma<>'0024' and h.cod_alma<>'0025' " _
            & IIf(esHistorial, " and h.proceso='" & periodo & "' and hd.proceso='" & periodo & "'", "")
        cad5 = IIf(agrupado, " group by cod_art", "") & " order by cod_art"
        cad = cad1 + cad2 + cad3 + cad4 + cad5
        Dim com As New MySqlCommand(cad, clConex)
        da.SelectCommand = com
        da.Fill(ds, "otros")
        clConex.Close()
        Return ds
    End Function
End Class
