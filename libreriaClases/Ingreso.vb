Imports MySql.Data.MySqlClient
Public Class Ingreso
    Public Shared Function dsIngreso() As DataSet
        Dim ds As New DataSet
        ds.Tables.Add(crearTablaDetalle())
        ds.Tables.Add(crearTablaCabecera())
        ds.Tables.Add(crearTablaIngreso())
        Return ds
    End Function
    Private Shared Function crearTablaCabecera() As DataTable
        Dim dt As New DataTable("cabecera")
        dt.Columns.Add(New DataColumn("operacion", GetType(Integer)))
        dt.Columns.Add(New DataColumn("cod_doc", GetType(String)))
        dt.Columns.Add(New DataColumn("ser_doc", GetType(String)))
        dt.Columns.Add(New DataColumn("nro_doc", GetType(String)))
        dt.Columns.Add(New DataColumn("ser_guia", GetType(String)))
        dt.Columns.Add(New DataColumn("nro_guia", GetType(String)))
        dt.Columns.Add(New DataColumn("fec_doc", GetType(Date)))
        dt.Columns.Add(New DataColumn("cod_prov", GetType(String)))
        dt.Columns.Add(New DataColumn("cod_fpago", GetType(String)))
        dt.Columns.Add(New DataColumn("cod_alma", GetType(String)))
        dt.Columns.Add(New DataColumn("cancelado", GetType(Boolean)))
        dt.Columns.Add(New DataColumn("monto", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("monto_igv", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("pre_inc_igv", GetType(Boolean)))
        dt.Columns.Add(New DataColumn("tm", GetType(Char)))
        dt.Columns.Add(New DataColumn("tc", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("monto_pago", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("fec_pago", GetType(Date)))
        dt.Columns.Add(New DataColumn("obs", GetType(String)))
        dt.Columns.Add(New DataColumn("anul", GetType(Boolean)))
        Return dt
    End Function
    Private Shared Function crearTablaDetalle() As DataTable
        Dim dt As New DataTable("detalle")
        dt.Columns.Add(New DataColumn("cod_art", GetType(String)))
        dt.Columns.Add(New DataColumn("nom_art", GetType(String)))
        dt.Columns.Add(New DataColumn("cod_uni", GetType(String)))
        dt.Columns.Add(New DataColumn("nom_uni", GetType(String)))
        dt.Columns.Add(New DataColumn("cantidad", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("Porcentaje", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("precio", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("pre_ult", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("igv", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("afecto_igv", GetType(Boolean)))
        dt.Columns.Add(New DataColumn("neto", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("operacion", GetType(Integer)))
        dt.Columns.Add(New DataColumn("ingreso", GetType(Integer)))
        dt.Columns.Add(New DataColumn("estado", GetType(String)))
        dt.Columns.Add(New DataColumn("obs", GetType(String)))
        Return dt
    End Function
    Private Shared Function crearTablaIngreso() As DataTable
        Dim dt As New DataTable("ingreso")
        dt.Columns.Add(New DataColumn("operacion", GetType(Integer)))
        dt.Columns.Add(New DataColumn("cod_doc", GetType(String)))
        dt.Columns.Add(New DataColumn("ser_doc", GetType(String)))
        dt.Columns.Add(New DataColumn("nro_doc", GetType(String)))
        dt.Columns.Add(New DataColumn("ser_guia", GetType(String)))
        dt.Columns.Add(New DataColumn("nro_guia", GetType(String)))
        dt.Columns.Add(New DataColumn("fec_doc", GetType(Date)))
        dt.Columns.Add(New DataColumn("cod_prov", GetType(String)))
        dt.Columns.Add(New DataColumn("nom_prov", GetType(String)))
        dt.Columns.Add(New DataColumn("raz_soc", GetType(String)))
        dt.Columns.Add(New DataColumn("dir_prov", GetType(String)))
        dt.Columns.Add(New DataColumn("nom_cont", GetType(String)))
        dt.Columns.Add(New DataColumn("cod_fpago", GetType(String)))
        dt.Columns.Add(New DataColumn("nom_fpago", GetType(String)))
        dt.Columns.Add(New DataColumn("cod_alma", GetType(String)))
        dt.Columns.Add(New DataColumn("nom_alma", GetType(String)))
        dt.Columns.Add(New DataColumn("fono_prov", GetType(String)))
        dt.Columns.Add(New DataColumn("obs", GetType(String)))
        dt.Columns.Add(New DataColumn("anul", GetType(Boolean)))
        dt.Columns.Add(New DataColumn("ingreso", GetType(Integer)))
        dt.Columns.Add(New DataColumn("cant", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("cod_art", GetType(String)))
        dt.Columns.Add(New DataColumn("nom_art", GetType(String)))
        dt.Columns.Add(New DataColumn("nom_uni", GetType(String)))
        dt.Columns.Add(New DataColumn("precio", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("igv", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("afecto_igv", GetType(Boolean)))
        dt.Columns.Add(New DataColumn("pre_inc_igv", GetType(Boolean)))
        dt.Columns.Add(New DataColumn("monto_igv", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("monto_pago", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("tm", GetType(Char)))
        dt.Columns.Add(New DataColumn("tc", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("fec_pago", GetType(Date)))
        dt.Columns.Add(New DataColumn("pre_ult", GetType(Decimal)))
        Return dt
    End Function
    Public Function recuperaDocumentoIngreso(ByVal h As Boolean, ByVal pr As String, ByVal cd As String,
                                ByVal sd As String, ByVal nd As String, ByVal noperacion As Integer)
        Dim clConex As New MySqlConnection
        Dim da As New MySqlDataAdapter
        Dim ds As New DataSet
        clConex = Conexion.obtenerConexion
        Dim cad, cad1, cad2, cad3, cad4, cad5, cad6, cad7, cad8, cad9, cad10 As String
        cad1 = "select fec_doc,ser_doc,nro_doc,raz_soc,proveedor.cod_prov,dir_prov,h.monto as monto_doc,"
        cad2 = " h.monto_igv,h.pre_inc_igv,nom_art,cant,precio,cant*precio as neto,igv,nom_fpago,nom_alma,tm,tc,obs,"
        cad3 = " concat(ser_guia,'-',nro_guia)as nro_guia,concat(ser_doc,'-',nro_doc)as documento,nom_doc,pre_inc_igv"
        If h Then
            cad4 = " from h_ingreso as h inner join h_ingreso_det as hd on h.operacion=hd.operacion and h.proceso=hd.proceso"
        Else
            cad4 = " from ingreso as h inner join ingreso_det as hd on h.operacion=hd.operacion"
        End If
        cad5 = " inner join articulo on hd.cod_art=articulo.cod_art"
        cad6 = " inner join proveedor on h.cod_prov=proveedor.cod_prov inner join almacen on h.cod_alma=almacen.cod_alma"
        cad7 = " inner join forma_pago on h.cod_fpago=forma_pago.cod_fpago inner join documento_i on h.cod_doc=documento_i.cod_doc"
        cad8 = " where h.cod_doc='" & cd & "'"
        cad9 = IIf(h, " and h.proceso='" & pr & "'", "") _
                    & "and h.operacion=" & noperacion
        '        & " and ser_doc='" & sd & "' and nro_doc='" & nd & "'"
        cad10 = " order by nom_art"
        cad = cad1 + cad2 + cad3 + cad4 + cad5 + cad6 + cad7 + cad8 + cad9 + cad10
        Dim com As New MySqlCommand(cad)
        com.Connection = clConex
        da.SelectCommand = com
        da.Fill(ds, "ingreso")
        clConex.Close()
        Return ds
    End Function
    Public Function recuperaDocumentoIngreso_OC(ByVal h As Boolean, ByVal pr As String, ByVal cd As String,
                                ByVal sd As String, ByVal nd As String, ByVal noperacion As Integer)
        Dim clConex As New MySqlConnection
        Dim da As New MySqlDataAdapter
        Dim ds As New DataSet
        clConex = Conexion.obtenerConexion
        Dim cad, cad1, cad2, cad3, cad4, cad5, cad6, cad7, cad8, cad9, cad10, cad11 As String
        cad1 = "select fec_doc,ser_doc,nro_doc,raz_soc,proveedor.cod_prov,dir_prov,h.monto as monto_doc,u.nom_uni,"
        cad2 = " h.monto_igv,h.pre_inc_igv,nom_art,cant,precio,cant*precio as neto,igv,nom_fpago,nom_alma,tm,tc,h.obs,hd.obs as obsdet,"
        cad3 = " concat(ser_guia,'-',nro_guia)as nro_guia,concat(ser_doc,'-',nro_doc)as documento,nom_doc,pre_inc_igv"
        If h Then
            cad4 = " from h_orden_compra as h inner join h_orden_compra_det as hd on h.operacion=hd.operacion and h.proceso=hd.proceso"
        Else
            cad4 = " from orden_compra as h inner join orden_compra_det as hd on h.operacion=hd.operacion"
        End If
        cad5 = " inner join articulo on hd.cod_art=articulo.cod_art left join unidad u on u.cod_uni=cAux"
        cad6 = " inner join proveedor on h.cod_prov=proveedor.cod_prov inner join almacen on h.cod_alma=almacen.cod_alma"
        cad7 = " inner join forma_pago on h.cod_fpago=forma_pago.cod_fpago inner join documento_i on h.cod_doc=documento_i.cod_doc"
        cad8 = " where h.cod_doc='" & cd & "'"
        cad9 = IIf(h, " and h.proceso='" & pr & "'", "") _
                    & "and h.operacion=" & noperacion
        '        & " and ser_doc='" & sd & "' and nro_doc='" & nd & "'"
        cad10 = " order by nom_art"
        cad = cad1 + cad2 + cad3 + cad4 + cad5 + cad6 + cad7 + cad8 + cad9 + cad10
        Dim com As New MySqlCommand(cad)
        com.Connection = clConex
        da.SelectCommand = com
        da.Fill(ds, "ingreso")


        cad11 = "select * from empresa"
        Dim com1 As New MySqlCommand(cad11)
        com1.Connection = clConex
        da.SelectCommand = com1
        da.Fill(ds, "empresa")

        clConex.Close()
        Return ds
    End Function

    Public Function recuperaCabecera(ByVal h As Boolean, ByVal pr As String, ByVal op As Integer) As DataTable
        Dim clConex As New MySqlConnection
        Dim da As New MySqlDataAdapter
        Dim ds As DataSet = Ingreso.dsIngreso
        Dim dt As DataTable = ds.Tables("cabecera")
        clConex = Conexion.obtenerConexion
        Dim cad, cad1, cad2, cad3, cad4 As String
        cad1 = "select operacion,cod_doc,ser_doc,nro_doc,ser_guia,nro_guia,fec_doc,h.cod_prov,fono_prov,tm,tc,"
        cad2 = " nom_cont,dir_prov,raz_soc,cod_fpago,cod_alma,obs,monto as monto_doc,monto_igv,monto_pago,fec_pago,pre_inc_igv"
        If h Then
            cad3 = " from h_ingreso as h inner join proveedor on h.cod_prov=proveedor.cod_prov"
            cad4 = " where operacion = " & op & " and h.proceso='" & pr & "'"
        Else
            cad3 = " from ingreso as h inner join proveedor on h.cod_prov=proveedor.cod_prov"
            cad4 = " where operacion = " & op
        End If
        cad = cad1 + cad2 + cad3 + cad4
        Dim com As New MySqlCommand(cad)
        com.Connection = clConex
        da.SelectCommand = com
        da.Fill(ds, "cabecera")
        clConex.Close()
        Return dt
    End Function

    Public Function recuperaCabecera_oc(ByVal h As Boolean, ByVal pr As String, ByVal op As Integer) As DataTable
        Dim clConex As New MySqlConnection
        Dim da As New MySqlDataAdapter
        Dim ds As DataSet = Ingreso.dsIngreso
        Dim dt As DataTable = ds.Tables("cabecera")
        clConex = Conexion.obtenerConexion
        Dim cad, cad1, cad2, cad3, cad4 As String
        cad1 = "select operacion,cod_doc,ser_doc,nro_doc,ser_guia,nro_guia,fec_doc,h.cod_prov,fono_prov,tm,tc,cod_estado,"
        cad2 = " nom_cont,dir_prov,raz_soc,cod_fpago,cod_alma,obs,monto as monto_doc,monto_igv,monto_pago,fec_pago,pre_inc_igv"
        If h Then
            cad3 = " from h_orden_compra as h inner join proveedor on h.cod_prov=proveedor.cod_prov"
            cad4 = " where operacion = " & op & " and h.proceso='" & pr & "'"
        Else
            cad3 = " from orden_compra as h inner join proveedor on h.cod_prov=proveedor.cod_prov"
            cad4 = " where operacion = " & op
        End If
        cad = cad1 + cad2 + cad3 + cad4
        Dim com As New MySqlCommand(cad)
        com.Connection = clConex
        da.SelectCommand = com
        da.Fill(ds, "cabecera")
        clConex.Close()
        Return dt
    End Function

    Public Function recuperaCabecera_ds(ByVal h As Boolean, ByVal pr As String, ByVal op As Integer) As DataSet
        Dim clConex As New MySqlConnection
        Dim da As New MySqlDataAdapter
        Dim ds As New DataSet
        clConex = Conexion.obtenerConexion
        Dim cad, cad1, cad2, cad3, cad4 As String
        cad1 = "select operacion,cod_doc,ser_doc,nro_doc,ser_guia,nro_guia,fec_doc,h.cod_prov,fono_prov,tm,tc,"
        cad2 = " nom_cont,dir_prov,raz_soc,cod_fpago,cod_alma,obs,monto as monto_doc,monto_igv,monto_pago,fec_pago,pre_inc_igv"
        If h Then
            cad3 = " from h_ingreso as h inner join proveedor on h.cod_prov=proveedor.cod_prov"
            cad4 = " where operacion = " & op & " and h.proceso='" & pr & "'"
        Else
            cad3 = " from ingreso as h inner join proveedor on h.cod_prov=proveedor.cod_prov"
            cad4 = " where operacion = " & op
        End If
        cad = cad1 + cad2 + cad3 + cad4
        Dim com As New MySqlCommand(cad)
        com.Connection = clConex
        da.SelectCommand = com
        'da.Fill(ds, "cabecera")
        da.Fill(ds, "cabecera")
        clConex.Close()
        Return ds
    End Function
    Public Function recuperaCabeceras(ByVal h As Boolean, ByVal pr As String, ByVal sc As Boolean, ByVal em As Boolean,
                                        ByVal f1 As Date, ByVal f2 As Date, ByVal nd As Integer, ByVal agp As Boolean,
                                        ByVal xE As Boolean, ByVal emp As String, ByVal xA As Boolean, ByVal ca As String,
                                        ByVal xP As Boolean, ByVal cp As String, ByVal xM As Boolean, ByVal mo As String,
                                        ByVal cmc As Boolean, ByVal orden As String)
        Dim clConex As New MySqlConnection
        Dim da As New MySqlDataAdapter
        Dim ds As DataSet = Ingreso.dsIngreso
        clConex = Conexion.obtenerConexion
        Dim mfechaI As String = f1.ToString("yyyy-MM-dd")
        Dim mfechaF As String = f2.ToString("yyyy-MM-dd")
        Dim cad, cad1, cad2, cad3, cad4, cad5, cad6, cad7, cad8, cad9, cad10, cad11, cad11a, cad12, cad12a, cad13, cad13a As String
        cad1 = "select h.operacion,fec_doc,raz_soc,concat(nom_doc,': ',ser_doc,'-',nro_doc)as documento,concat(ser_guia,'-',nro_guia)as guia,h.cod_doc,ser_guia,nro_guia,nro_orden,"
        If agp Then
            cad2 = " '-'as doc,ser_doc,nro_doc,ser_guia,nro_guia," _
                    & "round(if(" & cmc & ",sum(monto),if(tm='D',sum(monto*tc),sum(monto))),3)as monto_doc," _
                    & "round(if(tm='D',sum(monto*tc),sum(monto)),3) as monto_docDS,"
            cad3 = " round(if(" & cmc & ",sum(monto_igv),if(tm='D',sum(monto_igv*tc),sum(monto_igv))),3)" _
                    & " as monto_igv,if(" & cmc & ",tm,'S') as tm,tc,cancelado,"
            cad4 = " round(if(" & cmc & ",sum(monto),if(tm='D',sum(monto*tc),sum(monto))),3)" _
                    & "-round(if(" & cmc & ",sum(monto_igv),if(tm='D',sum(monto_igv*tc),sum(monto_igv))),3) as subTotal," _
                    & " round(if(tm='D',sum(monto*tc),sum(monto)),3)" _
                    & "-round(if(tm='D',sum(monto_igv*tc),sum(monto_igv)),3) as subTotalDS,"
            cad5 = " fec_pago,'-' as nom_alma,'-' as abr_fpago,h.cod_prov"
        Else
            cad2 = " concat(abr,ser_doc,'-',nro_doc)as doc,ser_doc,nro_doc," _
                    & "round(if(" & cmc & ",monto,if(tm='D',monto*tc,monto)),3)as monto_doc," _
                    & "round(if(tm='D',monto*tc,monto),3) as monto_docDS,"
            cad3 = " round(if(" & cmc & ",monto_igv,if(tm='D',monto_igv*tc,monto_igv))," _
                    & nd & ") as monto_igv,if(" & cmc & ",tm,'S') as tm,tc,cancelado,"
            cad4 = " round(if(" & cmc & ",monto,if(tm='D',monto*tc,monto)),3)" _
                    & "-round(if(" & cmc & ",monto_igv,if(tm='D',monto_igv*tc,monto_igv)),3) as subTotal," _
                    & " round(if(tm='D',monto*tc,monto),3)" _
                    & "-round(if(tm='D',monto_igv*tc,monto_igv),3) as subTotalDS,"
            cad5 = " fec_pago,nom_alma,abr_fpago,h.cod_prov"
        End If
        cad6 = IIf(h, " from h_ingreso as h", " from ingreso as h")
        cad7 = " inner join proveedor on h.cod_prov=proveedor.cod_prov"
        cad8 = " inner join documento_i on h.cod_doc=documento_i.cod_doc"
        cad9 = " inner join forma_pago on h.cod_fpago=forma_pago.cod_fpago"
        cad10 = " inner join almacen on h.cod_alma=almacen.cod_alma"
        If h Then
            cad11 = " where (esCompra) and h.proceso='" & pr & "'"
        Else
            cad11 = " where (esCompra)"
        End If
        cad11a = IIf(xE, " and almacen.cod_emp='" & emp & "'", "") _
                & IIf(xA, " and h.cod_alma='" & ca & "'", "") _
                & IIf(xM, " and tm='" & mo & "'", "")
        cad12 = IIf(em, "", " and h.fec_doc>='" & mfechaI & "' and h.fec_doc<='" & mfechaF & "'")
        cad12a = ""
        If xP Then
            cad12a = " and h.cod_prov='" & cp & "'"
        End If
        If agp Then
            cad13 = " group by h.cod_prov,tm"
        Else
            cad13 = ""
        End If
        cad13a = " order by " & orden & " asc"
        cad = cad1 + cad2 + cad3 + cad4 + cad5 + cad6 + cad7 + cad8 + cad9 + cad10 + cad11 + cad11a + cad12 + cad12a + cad13 + cad13a
        Dim com As New MySqlCommand(cad)
        com.Connection = clConex
        da.SelectCommand = com
        da.Fill(ds, "ingreso")
        clConex.Close()
        Return ds
    End Function
    Public Function recuperaCabeceras_oc(ByVal h As Boolean, ByVal pr As String, ByVal sc As Boolean, ByVal em As Boolean,
                                        ByVal f1 As Date, ByVal f2 As Date, ByVal nd As Integer, ByVal agp As Boolean,
                                        ByVal xE As Boolean, ByVal emp As String, ByVal xA As Boolean, ByVal ca As String,
                                        ByVal xP As Boolean, ByVal cp As String, ByVal xM As Boolean, ByVal mo As String,
                                        ByVal cmc As Boolean, ByVal orden As String)
        Dim clConex As New MySqlConnection
        Dim da As New MySqlDataAdapter
        Dim ds As DataSet = Ingreso.dsIngreso
        clConex = Conexion.obtenerConexion
        Dim mfechaI As String = f1.ToString("yyyy-MM-dd")
        Dim mfechaF As String = f2.ToString("yyyy-MM-dd")
        Dim cad, cad1, cad2, cad3, cad4, cad5, cad6, cad7, cad8, cad9, cad10, cad11, cad11a, cad12, cad12a, cad13, cad13a As String
        cad1 = "select h.operacion,fec_doc,raz_soc,concat(nom_doc,': ',ser_doc,'-',nro_doc)as documento,concat(ser_guia,'-',nro_guia)as guia,h.cod_doc,ser_guia,nro_guia,'' as nro_orden,"
        If agp Then
            cad2 = " '-'as doc,ser_doc,nro_doc,ser_guia,nro_guia," _
                    & "round(if(" & cmc & ",sum(monto),if(tm='D',sum(monto*tc),sum(monto))),3)as monto_doc," _
                    & "round(if(tm='D',sum(monto*tc),sum(monto)),3) as monto_docDS,"
            cad3 = " round(if(" & cmc & ",sum(monto_igv),if(tm='D',sum(monto_igv*tc),sum(monto_igv))),3)" _
                    & " as monto_igv,if(" & cmc & ",tm,'S') as tm,tc,cancelado,"
            cad4 = " round(if(" & cmc & ",sum(monto),if(tm='D',sum(monto*tc),sum(monto))),3)" _
                    & "-round(if(" & cmc & ",sum(monto_igv),if(tm='D',sum(monto_igv*tc),sum(monto_igv))),3) as subTotal," _
                    & " round(if(tm='D',sum(monto*tc),sum(monto)),3)" _
                    & "-round(if(tm='D',sum(monto_igv*tc),sum(monto_igv)),3) as subTotalDS,"
            cad5 = " fec_pago,'-' as nom_alma,'-' as abr_fpago,h.cod_prov"
        Else
            cad2 = " concat(abr,ser_doc,'-',nro_doc)as doc,ser_doc,nro_doc," _
                    & "round(if(" & cmc & ",monto,if(tm='D',monto*tc,monto)),3)as monto_doc," _
                    & "round(if(tm='D',monto*tc,monto),3) as monto_docDS,"
            cad3 = " round(if(" & cmc & ",monto_igv,if(tm='D',monto_igv*tc,monto_igv))," _
                    & nd & ") as monto_igv,if(" & cmc & ",tm,'S') as tm,tc,cancelado,"
            cad4 = " round(if(" & cmc & ",monto,if(tm='D',monto*tc,monto)),3)" _
                    & "-round(if(" & cmc & ",monto_igv,if(tm='D',monto_igv*tc,monto_igv)),3) as subTotal," _
                    & " round(if(tm='D',monto*tc,monto),3)" _
                    & "-round(if(tm='D',monto_igv*tc,monto_igv),3) as subTotalDS,"
            cad5 = " fec_pago,nom_alma,abr_fpago,h.cod_prov"
        End If
        cad6 = IIf(h, " from orden_compra as h", " from orden_compra as h")
        cad7 = " inner join proveedor on h.cod_prov=proveedor.cod_prov"
        cad8 = " inner join documento_i on h.cod_doc=documento_i.cod_doc"
        cad9 = " inner join forma_pago on h.cod_fpago=forma_pago.cod_fpago"
        cad10 = " inner join almacen on h.cod_alma=almacen.cod_alma"
        If h Then
            cad11 = " where (esCompra) "
        Else
            cad11 = " where (esCompra)"
        End If
        cad11a = IIf(xE, " and almacen.cod_emp='" & emp & "'", "") _
                & IIf(xA, " and h.cod_alma='" & ca & "'", "") _
                & IIf(xM, " and tm='" & mo & "'", "")
        cad12 = IIf(em, "", " and h.fec_doc>='" & mfechaI & "' and h.fec_doc<='" & mfechaF & "'")
        cad12a = ""
        If xP Then
            cad12a = " and h.cod_prov='" & cp & "'"
        End If
        If agp Then
            cad13 = " group by h.cod_prov,tm"
        Else
            cad13 = ""
        End If
        cad13a = " order by " & orden & " asc"
        cad = cad1 + cad2 + cad3 + cad4 + cad5 + cad6 + cad7 + cad8 + cad9 + cad10 + cad11 + cad11a + cad12 + cad12a + cad13 + cad13a
        Dim com As New MySqlCommand(cad)
        com.Connection = clConex
        da.SelectCommand = com
        da.Fill(ds, "ingreso")
        clConex.Close()
        Return ds
    End Function
    Public Function recuperaCabeceras_migracion(ByVal f1 As Date, ByVal f2 As Date, Optional ByVal dec As Integer = 0) As DataSet
        Dim clConex As New MySqlConnection
        Dim da As New MySqlDataAdapter
        Dim ds As DataSet = Ingreso.dsIngreso
        clConex = Conexion.obtenerConexion
        Dim mfechaI As String = f1.ToString("yyyy-MM-dd")
        Dim mfechaF As String = f2.ToString("yyyy-MM-dd")
        Dim cad As String = "select operacion from ingreso where fec_doc>='" & mfechaI & "' and fec_doc<='" & mfechaF & "'"
        Dim com As New MySqlCommand(cad)
        com.Connection = clConex
        da.SelectCommand = com
        da.Fill(ds, "ingreso")
        clConex.Close()
        Return ds
    End Function
    Public Function recuperaDetalle(ByVal h As Boolean, ByVal pr As String, ByVal op As Integer,
                                    Optional ByVal x As Integer = 0) As DataTable
        Dim clConex As New MySqlConnection
        Dim da As New MySqlDataAdapter
        Dim ds As DataSet = Ingreso.dsIngreso
        Dim dt As DataTable = ds.Tables("detalle")
        clConex = Conexion.obtenerConexion
        Dim cad, cad1, cad2, cad3, cad4, cad5 As String
        cad1 = "select operacion,ingreso,hd.cod_art,nom_art,nom_uni,cant as cantidad,precio,pre_ult,"
        cad2 = " round(cant*precio,3)as neto,igv," & IIf(h, "hd.afecto_igv", "articulo.afecto_igv") & ",'Reg' as estado"
        If h Then
            cad3 = " from h_ingreso_det as hd inner join articulo on hd.cod_art=articulo.cod_art"
        Else
            cad3 = " from ingreso_det as hd inner join articulo on hd.cod_art=articulo.cod_art"
        End If
        cad4 = " inner join unidad on articulo.cod_uni=unidad.cod_uni"
        cad5 = " where operacion=" & op & IIf(h, " and hd.proceso='" & pr & "'", "") & " order by nom_art"
        cad = cad1 + cad2 + cad3 + cad4 + cad5
        Dim com As New MySqlCommand(cad)
        com.Connection = clConex
        da.SelectCommand = com
        da.Fill(ds, "detalle")
        clConex.Close()
        Return dt
    End Function
    Public Function recuperaDetalle_oc(ByVal h As Boolean, ByVal pr As String, ByVal op As Integer,
                                    Optional ByVal x As Integer = 0) As DataTable
        Dim clConex As New MySqlConnection
        Dim da As New MySqlDataAdapter
        Dim ds As DataSet = Ingreso.dsIngreso
        Dim dt As DataTable = ds.Tables("detalle")
        clConex = Conexion.obtenerConexion
        Dim cad, cad1, cad2, cad3, cad4, cad5 As String
        cad1 = "select operacion,ingreso,hd.cod_art,nom_art,cant as cantidad,precio as precio,pre_ult,cAux as cod_uni,nom_uni as nom_uni,"
        cad2 = " round(cant*precio,3)as neto,igv," & IIf(h, "hd.afecto_igv", "afecto_igv") & ",'Reg' as estado,obs"
        If h Then
            cad3 = " from h_orden_compra_det as hd inner join articulo on hd.cod_art=articulo.cod_art"
        Else
            cad3 = " from orden_compra_det as hd inner join articulo on hd.cod_art=articulo.cod_art"
        End If
        cad4 = " left join unidad on unidad.cod_uni=cAux"
        cad5 = " where operacion=" & op & IIf(h, " and hd.proceso='" & pr & "'", "") & " order by nom_art"
        cad = cad1 + cad2 + cad3 + cad4 + cad5
        Dim com As New MySqlCommand(cad)
        com.Connection = clConex
        da.SelectCommand = com
        da.Fill(ds, "detalle")
        clConex.Close()
        Return dt
    End Function
    Public Function recuperaDetalle_oc1(ByVal h As Boolean, ByVal pr As String, ByVal op As Integer,
                                    Optional ByVal x As Integer = 0) As DataTable
        Dim clConex As New MySqlConnection
        Dim da As New MySqlDataAdapter
        Dim ds As DataSet = Ingreso.dsIngreso
        Dim dt As DataTable = ds.Tables("detalle")
        clConex = Conexion.obtenerConexion
        Dim cad, cad1, cad2, cad3, cad4, cad5 As String
        cad1 = "select operacion,ingreso,hd.cod_art,nom_art,cant*cant_uni as cantidad,precio/cant_uni as precio,pre_ult,cAux as cod_uni,nom_uni as nom_uni,"
        cad2 = " round(cant*precio,3)as neto,igv," & IIf(h, "hd.afecto_igv", "afecto_igv") & ",'Reg' as estado,obs"
        If h Then
            cad3 = " from h_orden_compra_det as hd inner join articulo on hd.cod_art=articulo.cod_art"
        Else
            cad3 = " from orden_compra_det as hd inner join articulo on hd.cod_art=articulo.cod_art"
        End If
        cad4 = " left join unidad on unidad.cod_uni=cAux"
        cad5 = " where operacion=" & op & IIf(h, " and hd.proceso='" & pr & "'", "") & " order by nom_art"
        cad = cad1 + cad2 + cad3 + cad4 + cad5
        Dim com As New MySqlCommand(cad)
        com.Connection = clConex
        da.SelectCommand = com
        da.Fill(ds, "detalle")
        clConex.Close()
        Return dt
    End Function

    Public Function recuperaDetalle_ds(ByVal h As Boolean, ByVal pr As String, ByVal op As Integer, _
                                Optional ByVal x As Integer = 0) As DataSet
        Dim clConex As New MySqlConnection
        Dim da As New MySqlDataAdapter
        Dim ds As New DataSet
        clConex = Conexion.obtenerConexion
        Dim cad, cad1, cad2, cad3, cad4, cad5 As String
        cad1 = "select operacion,ingreso,hd.cod_art,nom_art,nom_uni,cant as cantidad,precio,pre_ult,hd.saldo,"
        cad2 = " round(cant*precio,3)as neto,igv,articulo.afecto_igv,' ' as estado"
        If h Then
            cad3 = " from h_ingreso_det as hd inner join articulo on hd.cod_art=articulo.cod_art"
        Else
            cad3 = " from ingreso_det as hd inner join articulo on hd.cod_art=articulo.cod_art"
        End If
        cad4 = " inner join unidad on articulo.cod_uni=unidad.cod_uni"
        cad5 = " where operacion=" & op & IIf(h, " and hd.proceso='" & pr & "'", "") & " order by nom_art"
        cad = cad1 + cad2 + cad3 + cad4 + cad5
        Dim com As New MySqlCommand(cad)
        com.Connection = clConex
        da.SelectCommand = com
        da.Fill(ds, "detalle")
        clConex.Close()
        Return ds
    End Function
    Public Function recuperaDetalleInvInicial(ByVal op As Integer, Optional ByVal x As Integer = 0) As DataTable
        Dim clConex As New MySqlConnection
        Dim da As New MySqlDataAdapter
        Dim ds As DataSet = Ingreso.dsIngreso
        Dim dt As DataTable = ds.Tables("detalle")
        clConex = Conexion.obtenerConexion
        Dim cad, cad1, cad2, cad3, cad4, cad5 As String
        cad1 = "select operacion,ingreso,ingreso_det.cod_art,nom_art,nom_uni,0 as cant_sis," _
                & "cant as cant_fis,round(precio,3) as precio," _
                & " articulo.cod_sgrupo,nom_sgrupo,subgrupo.esProduccion,"
        cad2 = " round(cant*precio,3)as neto,igv,afecto_igv,'Reg' as estado"
        cad3 = " from ingreso_det inner join articulo on ingreso_det.cod_art=articulo.cod_art"
        cad4 = " inner join unidad on articulo.cod_uni=unidad.cod_uni " _
                & "inner join subgrupo on articulo.cod_sgrupo=subgrupo.cod_sgrupo"
        cad5 = " where operacion=" & op & " order by nom_art"
        cad = cad1 + cad2 + cad3 + cad4 + cad5
        Dim com As New MySqlCommand(cad)
        com.Connection = clConex
        da.SelectCommand = com
        da.Fill(ds, "detalle")
        clConex.Close()
        Return dt
    End Function
    Public Function recuperaArticulosIngresados(ByVal h As Boolean, ByVal pr As String, ByVal ag As Boolean, _
                    ByVal cAg As String, ByVal sc As Boolean, ByVal incT As Boolean, _
                    ByVal em As Boolean, ByVal f1 As Date, ByVal f2 As Date, ByVal nd As Integer, _
                    ByVal xA As Boolean, ByVal ca As String, ByVal xProveedor As Boolean, ByVal cod_prov As String, _
                    ByVal xArticulo As Boolean, ByVal car As String, ByVal xF As Boolean, ByVal cf As String, _
                    ByVal pID As Boolean, ByVal xG As Boolean, ByVal cg As String, _
                    ByVal pIMP As Boolean, ByVal xM As Boolean, ByVal mo As String, _
                    ByVal precioCI As String, ByVal hPrecioCI As String, ByVal precioSI As String, ByVal hPrecioSI As String, _
                    ByVal precioCIs As String, ByVal hPrecioCIs As String, ByVal precioSIs As String, ByVal hPrecioSIs As String, _
                    ByVal ord As String, ByVal xE As Boolean, ByVal ce As String, ByVal cmc As Boolean) As DataSet
        Dim clConex As New MySqlConnection
        Dim da As New MySqlDataAdapter
        Dim ds As New DataSet
        clConex = Conexion.obtenerConexion
        Dim mfechaI = f1.ToString("yyyy-MM-dd")
        Dim mfechaF = f2.ToString("yyyy-MM-dd")
        Dim cad, cad1, cad1a, cad2, cad2a, cad3, cad4, cad5, cad6 As String
        cad1 = "select h.operacion,fec_doc,ingreso,hd.cod_art,nom_art,nom_uni," _
                & IIf(ag, "sum(cant)", "cant") & " as cant,if(" & cmc & ",tm,'S') as tm,tc," _
                & "articulo.cod_sgrupo,nom_sgrupo,h.cod_prov,"
        cad1a = IIf(ag, " raz_soc,' -'as doc,", " raz_soc,concat(abr,ser_doc,'-',nro_doc)as doc,")
        If h Then
            cad2 = IIf(pIMP, hPrecioCI, hPrecioSI) & " as precio," _
                    & IIf(pIMP, hPrecioCIs, hPrecioSIs) & " as precioDS,"
            cad2a = IIf(ag, " sum(round(cant * " & IIf(pIMP, hPrecioCI, hPrecioSI) & "," & nd & "))", _
                    " round(cant *" & IIf(pIMP, hPrecioCI, hPrecioSI) & "," & nd & ")") & " as neto," _
                    & IIf(ag, " sum(round(cant * " & IIf(pIMP, hPrecioCIs, hPrecioSIs) & "," & nd & "))", _
                    " round(cant *" & IIf(pIMP, hPrecioCIs, hPrecioSIs) & "," & nd & ")") & " as netoDS," _
                    & " igv,hd.afecto_igv,articulo.cuenta_c"
            cad3 = " from h_ingreso as h inner join h_ingreso_det as hd on h.operacion=hd.operacion and h.proceso=hd.proceso"
        Else
            cad2 = IIf(pIMP, precioCI, precioSI) & " as precio," _
                    & IIf(pIMP, precioCIs, precioSIs) & " as precioDS,"
            cad2a = IIf(ag, " sum(round(cant * " & IIf(pIMP, precioCI, precioSI) & "," & nd & "))", _
                    " round(cant *" & IIf(pIMP, precioCI, precioSI) & "," & nd & ")") & " as neto," _
                    & IIf(ag, " sum(round(cant * " & IIf(pIMP, precioCIs, precioSIs) & "," & nd & "))", _
                    " round(cant *" & IIf(pIMP, precioCIs, precioSIs) & "," & nd & ")") & " as netoDS," _
                    & " igv,articulo.afecto_igv,articulo.cuenta_c"
            cad3 = " from ingreso as h inner join ingreso_det as hd on h.operacion=hd.operacion"
        End If
        cad4 = " inner join articulo on hd.cod_art=articulo.cod_art" _
                & " inner join unidad on articulo.cod_uni=unidad.cod_uni" _
                & " inner join documento_i on h.cod_doc=documento_i.cod_doc" _
                & " inner join almacen on almacen.cod_alma=h.cod_alma" _
                & " inner join proveedor on h.cod_prov=proveedor.cod_prov" _
                & " inner join subgrupo on articulo.cod_sgrupo=subgrupo.cod_sGrupo"

        Dim tHis As String = "", tFecha As String = ""
        tHis = " h.proceso='" & pr & "'"
        tFecha = " fec_doc>='" & mfechaI & "' and fec_doc<='" & mfechaF & "'"
        cad5 = " where " & IIf(sc, " (documento_i.esCompra) ", IIf(incT, " (esIngresoAlma)", " (esIngreso)")) _
                & IIf(xM, " and tm='" & mo & "'", "") _
                & IIf(h, " and " & tHis, "") & IIf(em, "", " and" & tFecha) _
                & IIf(xA, " and h.cod_alma='" & ca & "'", "") _
                & IIf(pID, " and (almacen.es_invDiario)", "") _
                & IIf(xProveedor, " and h.cod_prov='" & cod_prov & "'", "") _
                & IIf(xArticulo, " and hd.cod_art='" & car & "'", "") _
                & IIf(xF, " and subgrupo.cod_familia='" & cf & "'", "") _
                & IIf(xG, " and articulo.cod_sgrupo='" & cg & "'", "")
        'cad6 = IIf(ag, " group by tm" & IIf(Len(cAg) > 0, "," & cAg, "") _
        cad6 = IIf(ag, " group by " & IIf(Len(cAg) > 0, "" & cAg, "") _
                & IIf(xProveedor, ",h.cod_prov", ""), "") _
                & " order by nom_art"
        cad = cad1 + cad1a + cad2 + cad2a + cad3 + cad4 + cad5 + cad6
        Dim com As New MySqlCommand(cad)
        com.Connection = clConex
        da.SelectCommand = com
        da.Fill(ds, "ingreso")
        clConex.Close()
        Return ds
    End Function
    Function recuperaDescripcionArticulosIngresados(ByVal xA As Boolean, ByVal ca As String, ByVal xg As Boolean, _
                                                    ByVal cg As String) As DataSet
        'recupera los articulos ingresados, ya sea x almacen o integrado
        Dim clConex As New MySqlConnection
        Dim da As New MySqlDataAdapter
        Dim ds As New DataSet
        clConex = Conexion.obtenerConexion
        Dim cad, cad1, cad2, cad3, cad4, cad5, cad6, cad7 As String
        cad1 = "select hd.cod_art,nom_art,nom_uni,pre_costo,pre_venta,pre_costoMax,"
        cad2 = " maximo,minimo,h.cod_alma,articulo.cod_sgrupo,nom_sgrupo "
        cad3 = " from ingreso as h inner join ingreso_det  as hd on h.operacion=hd.operacion"
        cad4 = " inner join articulo on hd.cod_art =articulo.cod_art "
        cad5 = " inner join unidad on articulo.cod_uni=unidad.cod_uni inner join subgrupo on articulo.cod_sgrupo=subgrupo.cod_sgrupo"
        If xA Then
            cad6 = " where h.cod_alma='" & ca & "'" & IIf(xg, " and cod_sgrupo='" & cg & "'", "")
        Else
            cad6 = IIf(xg, " where cod_sgrupo='" & cg & "'", "")
        End If
        cad7 = " group by hd.cod_art order by nom_art"
        cad = cad1 + cad2 + cad3 + cad4 + cad5 + cad6 + cad7
        Dim com As New MySqlCommand(cad)
        com.Connection = clConex
        da.SelectCommand = com
        da.Fill(ds, "articulos")
        clConex.Close()
        Return ds
    End Function
    Function recuperaTotalIngresosArticulo(ByVal h As Boolean, ByVal pr As String, ByVal fec As Date, _
                                        ByVal xAlmacen As Boolean, ByVal ca As String, ByVal xArea As Boolean, _
                                        ByVal cArea As String, ByVal car As String) As Decimal
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim mfecha = fec.ToString("yyyy-MM-dd")
        Dim cad, cad1, cad2, cad3 As String, result As Decimal
        cad1 = "select sum(cant)"
        If h Then
            cad2 = " from h_ingreso as h inner join h_ingreso_det  as hd on h.operacion=hd.operacion"
        Else
            cad2 = " from ingreso as h inner join ingreso_det as hd on h.operacion=hd.operacion"
        End If
        cad3 = " where fec_doc<='" & mfecha & "' and cod_art='" & car & "'" _
                & IIf(xAlmacen, " and cod_alma='" & ca & "'", "") _
                & IIf(xArea, " and cod_area='" & cArea & "'", "") _
                & IIf(h, " and h.proceso='" & pr & "' and hd.proceso='" & pr & "'", "")
        cad = cad1 + cad2 + cad3
        com.CommandText = cad
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Decimal)
        clConex.Close()
        Return result
    End Function
    Function recuperaPedidoIngresosArticulo(ByVal h As Boolean, ByVal pr As String, ByVal esMensual As Boolean, ByVal fecD As Date, ByVal fecH As Date, _
                                            ByVal xA As Boolean, ByVal ca As String, ByVal car As String, ByVal cod_area As String) As Decimal
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim mfechaD = fecD.ToString("yyyy-MM-dd")
        Dim mfechaH = fecH.ToString("yyyy-MM-dd")
        Dim cad, cad1, cad2, cad3 As String, result As Decimal
        cad1 = "select sum(cant)"
        If h Then
            cad2 = " from h_ingreso as h inner join h_ingreso_det  as hd on h.operacion=hd.operacion"
        Else
            cad2 = " from ingreso as h inner join ingreso_det as hd on h.operacion=hd.operacion"
        End If
        cad3 = " inner join documento_i on h.cod_doc=documento_i.cod_doc" _
           & " where (esIngreso) and cod_art='" & car & "' and cod_area='" & cod_area & "'" _
           & IIf(esMensual, "", " and fec_doc>='" & mfechaD & "' and fec_doc<='" & mfechaH & "'") _
           & IIf(xA, " and cod_alma='" & ca & "'", "") _
           & IIf(h, " and h.proceso='" & pr & "' and hd.proceso='" & pr & "'", "")
        cad = cad1 + cad2 + cad3
        com.CommandText = cad
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Decimal)
        clConex.Close()
        Return result
    End Function
    Function recuperaSaldoIngresosArticulo(ByVal h As Boolean, ByVal pr As String, ByVal fec As Date, _
                                        ByVal xAlmacen As Boolean, ByVal ca As String, ByVal xArea As Boolean, ByVal cArea As String, ByVal car As String) As Decimal
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim mfecha = fec.ToString("yyyy-MM-dd")
        Dim cad, cad1, cad2, cad3 As String, result As Decimal
        cad1 = "select sum(cant)"
        If h Then
            cad2 = " from h_ingreso as h inner join h_ingreso_det  as hd on h.operacion=hd.operacion"
        Else
            cad2 = " from ingreso as h inner join ingreso_det as hd on h.operacion=hd.operacion"
        End If
        cad3 = " inner join documento_i on h.cod_doc=documento_i.cod_doc inner join area on h.cod_area=area.cod_area " _
                & " where  (esIngreso) and fec_doc='" & mfecha & "' and cod_art='" & car & "'" _
                & IIf(xAlmacen, " and h.cod_alma='" & ca & "'", "") _
                & IIf(xArea, " and h.cod_area='" & cArea & "'", "") _
                & IIf(h, " and h.proceso='" & pr & "' and hd.proceso='" & pr & "'", "")

        cad = cad1 + cad2 + cad3
        com.CommandText = cad
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Decimal)
        clConex.Close()
        Return result
    End Function
    Function recuperaSaldoIngresosArticulo_t1(ByVal h As Boolean, ByVal pr As String, ByVal fec As Date, _
                                    ByVal xA As Boolean, ByVal ca As String, ByVal car As String) As Decimal
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim mfecha = fec.ToString("yyyy-MM-dd")
        Dim cad, cad1, cad2, cad3 As String, result As Decimal
        cad1 = "select sum(cant)"
        If h Then
            cad2 = " from h_ingreso as h inner join h_ingreso_det  as hd on h.operacion=hd.operacion"
        Else
            cad2 = " from ingreso as h inner join ingreso_det as hd on h.operacion=hd.operacion" _
                   & " inner join documento_i on h.cod_doc=documento_i.cod_doc"
        End If
        cad3 = " where  (esIngreso) and fec_doc<='" & mfecha & "' and cod_art='" & car & "'" _
                & IIf(xA, " and cod_alma='" & ca & "'", "") _
                & IIf(h, " and h.proceso='" & pr & "' and hd.proceso='" & pr & "'", "")
        cad = cad1 + cad2 + cad3
        com.CommandText = cad
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Decimal)
        clConex.Close()
        Return result
    End Function
    Function recuperaInicialArticulo(ByVal h As Boolean, ByVal pr As String, ByVal fec As Date, _
                                        ByVal xA As Boolean, ByVal ca As String, _
                                        ByVal xArea As Boolean, ByVal cod_area As String, ByVal car As String) As Decimal
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim mfecha = fec.ToString("yyyy-MM-dd")
        Dim cad, cad1, cad2, cad3 As String, result As Decimal
        cad1 = "select sum(cant)"
        If h Then
            cad2 = " from h_ingreso as h inner join h_ingreso_det  as hd on h.operacion=hd.operacion"
        Else
            cad2 = " from ingreso as h inner join ingreso_det as hd on h.operacion=hd.operacion"
        End If
        cad3 = " where fec_doc<='" & mfecha & "' and cod_art='" & car & "'" _
                & IIf(xA, " and cod_alma='" & ca & "'", "") _
                & IIf(xArea, " and cod_area='" & cod_area & "'", "") _
                & IIf(h, " and h.proceso='" & pr & "' and hd.proceso='" & pr & "'", "") _
                & (" and cod_doc='10'")
        cad = cad1 + cad2 + cad3
        com.CommandText = cad
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Decimal)
        clConex.Close()
        Return result
    End Function
    Function recComp_ingresoArticulo(ByVal h As Boolean, ByVal pr As String, ByVal eM As Boolean, _
                                        ByVal fec As Date, ByVal xA As Boolean, ByVal ca As String, _
                                        ByVal car As String) As Decimal

        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim mfecha = fec.ToString("yyyy-MM-dd")
        Dim cad, cad1, cad2, cad3, cad4 As String, result As Decimal
        cad1 = "select sum(cant)"
        If h Then
            cad2 = " from h_ingreso as h inner join h_ingreso_det as hd on h.operacion=hd.operacion and h.proceso=hd.proceso"
        Else
            cad2 = " from ingreso as h inner join ingreso_det as hd on h.operacion=hd.operacion"
        End If
        cad3 = " inner join documento_i on h.cod_doc=documento_i.cod_doc"
        cad4 = " where (esCompra) and hd.cod_art='" & car & "'" _
                    & IIf(xA, " and h.cod_alma='" & ca & "'", "") _
                    & IIf(eM, "", " and h.fec_doc ='" & mfecha & "'")
        cad = cad1 + cad2 + cad3 + cad4
        com.CommandText = cad
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Decimal)
        clConex.Close()
        Return result
    End Function
    Function recCant_ingresoArticulo(ByVal h As Boolean, ByVal pr As String, ByVal eM As Boolean, _
                                        ByVal fec As Date, ByVal xA As Boolean, ByVal ca As String, _
                                        ByVal car As String) As Decimal
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim mfecha = fec.ToString("yyyy-MM-dd")
        Dim cad, cad1, cad2, cad3, cad4 As String, result As Decimal
        cad1 = "select sum(cant)"
        If h Then
            cad2 = " from h_ingreso as h inner join h_ingreso_det as hd on h.operacion=hd.operacion"
        Else
            cad2 = " from ingreso as h inner join ingreso_det as hd on h.operacion=hd.operacion"
        End If
        cad3 = " inner join documento_i on h.cod_doc=documento_i.cod_doc"
        cad4 = " where (esCompra) and hd.cod_art='" & car & "'" _
                    & IIf(h, " and h.proceso='" & pr & "' and hd.proceso='" & pr & "'", "") _
                    & IIf(xA, " and h.cod_alma='" & ca & "'", "") _
                    & IIf(eM, "", " and h.fec_doc<='" & mfecha & "'")
        cad = cad1 + cad2 + cad3 + cad4
        com.CommandText = cad
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Decimal)
        clConex.Close()
        Return result
    End Function
    Function recMonto_ingresoArticulo(ByVal h As Boolean, ByVal pr As String, ByVal esMensual As Boolean, _
                                    ByVal fec As Date, ByVal xA As Boolean, ByVal ca As String, _
                                    ByVal car As String, ByVal pIMP As Boolean, ByVal nd As Decimal, _
                                    ByVal pCI As String, ByVal hpCI As String, ByVal pSI As String, _
                                    ByVal hPSI As String) As Decimal
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim mfecha = fec.ToString("yyyy-MM-dd")
        Dim cad, cad1, cad2, cad3, cad4 As String, result As Decimal
        If h Then
            cad1 = " select round(sum(cant*" & IIf(pIMP, hpCI, hPSI) & "),3)as neto"
            cad2 = " from h_ingreso as h inner join h_ingreso_det as hd on h.operacion=hd.operacion"
        Else
            cad1 = " select round(sum(cant*" & IIf(pIMP, pCI, pSI) & "),3)as neto"
            cad2 = " from ingreso as h inner join ingreso_det as hd on h.operacion=hd.operacion"
        End If
        cad3 = " inner join documento_i on h.cod_doc=documento_i.cod_doc" _
            & " inner join articulo on articulo.cod_art=hd.cod_art"
        cad4 = " where (esCompra) and hd.cod_art='" & car & "'" _
            & IIf(h, " and h.proceso='" & pr & "'", "") _
            & IIf(esMensual, "", " and h.fec_doc<='" & mfecha & "'") _
            & IIf(xA, " and h.cod_alma='" & ca & "'", "")
        cad = cad1 + cad2 + cad3 + cad4
        com.CommandText = cad
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Decimal)
        clConex.Close()
        Return result
    End Function
    Public Function insertar(ByVal ope As Integer,
                                ByVal doc As String,
                                ByVal ser As String,
                                ByVal nro As String,
                                ByVal serg As String,
                                ByVal nrog As String,
                                ByVal nrooc As String,
                                ByVal fec As Date,
                                ByVal cp As String,
                                ByVal fp As String,
                                ByVal ca As String,
                                ByVal care As String,
                                ByVal canc As Boolean,
                                ByVal inc As Boolean,
                                ByVal dec As Integer,
                                ByVal obs As String,
                                ByVal mo As String,
                                ByVal tc As Decimal,
                                ByVal usu As String,
                                ByVal maquina As String
                                ) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim sql As String, result As Integer
        Dim mfecha As String = fec.ToString("yy-MM-dd")
        sql = "Insert Into ingreso(operacion,cod_doc,ser_doc,nro_doc,ser_guia,nro_guia,fec_doc,cod_prov,nro_Orden," _
                                & "cod_fpago,cod_alma,cod_area,cancelado,pre_inc_igv,nro_dec,obs,tm,tc,cuenta,maquina)" &
                "values(" &
                ope & ",'" & doc & "','" & ser & "','" & nro & "','" & serg & "','" _
                & nrog & "','" & mfecha & "','" & cp & "','" & nrooc & "','" & fp & "','" _
                & ca & "','" & care & "'," & canc & "," & inc & "," & dec & ",'" & obs & "','" _
                & mo & "'," & tc & ",'" & usu & "','" & maquina & "')"
        com.CommandText = sql
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function
    Public Function insertar_oc(ByVal ope As Integer,
                                ByVal doc As String,
                                ByVal ser As String,
                                ByVal nro As String,
                                ByVal serg As String,
                                ByVal nrog As String,
                                ByVal estado As String,
                                ByVal fec As Date,
                                ByVal cp As String,
                                ByVal fp As String,
                                ByVal ca As String,
                                ByVal care As String,
                                ByVal canc As Boolean,
                                ByVal inc As Boolean,
                                ByVal dec As Integer,
                                ByVal obs As String,
                                ByVal mo As String,
                                ByVal tc As Decimal,
                                ByVal usu As String) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim sql As String, result As Integer
        Dim mfecha As String = fec.ToString("yy-MM-dd")
        sql = "Insert Into orden_compra(operacion,cod_doc,ser_doc,nro_doc,ser_guia,nro_guia,cod_estado,fec_doc,cod_prov," _
                                & "cod_fpago,cod_alma,cod_area,cancelado,pre_inc_igv,nro_dec,obs,tm,tc,cuenta,usu_ins,usu_mod)" &
                "values(" &
                ope & ",'" & doc & "','" & ser & "','" & nro & "','" & serg & "','" _
                & nrog & "','" & estado & "','" & mfecha & "','" & cp & "','" & fp & "','" _
                & ca & "','" & care & "'," & canc & "," & inc & "," & dec & ",'" & obs & "','" _
                & mo & "'," & tc & ",'" & usu & "','" & usu & "','" & usu & "')"
        com.CommandText = sql
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function

    Public Function insertar_aux_his(ByVal esh As Boolean, _
                            ByVal periodo As String, _
                            ByVal ope As Integer, _
                            ByVal doc As String, _
                            ByVal ser As String, _
                            ByVal nro As String, _
                            ByVal serg As String, _
                            ByVal nrog As String, _
                            ByVal fec As Date, _
                            ByVal cp As String, _
                            ByVal fp As String, _
                            ByVal ca As String, _
                            ByVal care As String, _
                            ByVal canc As Boolean, _
                            ByVal inc As Boolean, _
                            ByVal dec As Integer, _
                            ByVal obs As String, _
                            ByVal mo As String, _
                            ByVal tc As Decimal, _
                            ByVal usu As String) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim sql As String, result As Integer
        Dim mfecha As String = fec.ToString("yy-MM-dd")
        sql = "Insert Into " & IIf(esh, "h_ingreso(proceso,", "ingreso (") & " operacion,cod_doc,ser_doc,nro_doc,ser_guia,nro_guia,fec_doc,cod_prov," _
                                & "cod_fpago,cod_alma,cod_area,cancelado,pre_inc_igv,nro_dec,obs,tm,tc,cuenta)" & _
                "values(" & _
                IIf(esh, periodo & ",", "") & ope & ",'" & doc & "','" & ser & "','" & nro & "','" & serg & "','" _
                & nrog & "','" & mfecha & "','" & cp & "','" & fp & "','" _
                & ca & "','" & care & "'," & canc & "," & inc & "," & dec & ",'" & obs & "','" _
                & mo & "'," & tc & ",'" & usu & "')"
        com.CommandText = sql
        com.CommandTimeout = 300
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function
    Public Function insertar_det(ByVal ope As Integer,
                                    ByVal ing As Integer,
                                    ByVal art As String,
                                    ByVal cant As Decimal,
                                    ByVal pre As Decimal,
                                    ByVal usuario As String,
                                    ByVal igv As Decimal) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim sql As String, result As Integer
        sql = "Insert Into ingreso_det(operacion,ingreso,cod_art,cant,precio,usu_ins,igv,saldo)" &
            "values(" &
            ope & "," & ing & ",'" & art & "'," & cant & "," & pre & ",'" & usuario & "'," & igv & "," & cant & ")"
        com.CommandText = sql
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function
    Public Function insertar_oc_det(ByVal ope As Integer,
                                    ByVal ing As Integer,
                                    ByVal art As String,
                                    ByVal cant As Decimal,
                                    ByVal pre As Decimal,
                                    ByVal igv As Decimal,
                                    ByVal unidad As String,
                                    ByVal obs As String,
                                    ByVal usu As String) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim sql As String, result As Integer
        sql = "Insert Into orden_compra_det(operacion,ingreso,cod_art,cant,precio,igv,saldo,cAux,obs,usu_ins,usu_mod)" &
            "values(" &
            ope & "," & ing & ",'" & art & "'," & cant & "," & pre & "," & igv & "," & cant & ",'" & unidad & "','" & obs & "','" & usu & "','" & usu & "')"
        com.CommandText = sql
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function

    Public Function insertar_det_his(ByVal esh As Boolean, _
                                    ByVal periodo As String, _
                                    ByVal ope As Integer, _
                                    ByVal ing As Integer, _
                                    ByVal art As String, _
                                    ByVal cant As Decimal, _
                                    ByVal pre As Decimal, _
                                    ByVal igv As Decimal) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim sql As String, result As Integer
        sql = "Insert Into " & IIf(esh, "h_ingreso_det(proceso, ", "ingreso_det(") & "operacion,ingreso,cod_art,cant,precio,igv,saldo)" & _
            "values(" & _
            IIf(esh, periodo & ",", "") & ope & "," & ing & ",'" & art & "'," & cant & "," & pre & "," & igv & "," & cant & ")"
        com.CommandText = sql
        com.CommandTimeout = 800
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function
    Public Function insertar_detAux2(ByVal ope As Integer, _
                                ByVal ing As Integer, _
                                ByVal art As String, _
                                ByVal cant As Decimal, _
                                ByVal pre As Decimal, _
                                ByVal igv As Decimal, _
                                ByVal nAux As Integer) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim sql As String, result As Integer
        sql = "Insert Into ingreso_det(operacion,ingreso,cod_art,cant,precio,igv,saldo,nAux)" & _
            "values(" & _
            ope & "," & ing & ",'" & art & "'," & cant & "," & pre & "," & igv & "," & cant & "," & nAux & ")"
        com.CommandText = sql
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function
    Public Function actualizaCabecera(ByVal h As Boolean, ByVal pr As String,
                                     ByVal ope As Integer,
                            ByVal fec As Date,
                            ByVal prov As String,
                            ByVal doc As String,
                            ByVal ser As String,
                            ByVal nro As String,
                            ByVal serg As String,
                            ByVal nrog As String,
                            ByVal nrotr As String,
                            ByVal fp As String,
                            ByVal ca As String,
                            ByVal canc As Boolean,
                            ByVal inc As Boolean,
                            ByVal dec As Integer,
                            ByVal obs As String,
                            ByVal mo As String,
                            ByVal cuenta As String,
                            ByVal maquina As String
                            ) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim cad, cad1, cad2, cad3, cad4 As String, result As Integer
        Dim mfecha As String = Microsoft.VisualBasic.Trim(fec.ToString("yyyy-MM-dd"))
        'cad1 = "update ingreso 
        If h Then
            cad1 = "update h_ingreso "
        Else
            cad1 = "update ingreso "
        End If
        cad2 = " set fec_doc='" & mfecha & "'," & "cod_prov='" & prov & "'," & "usu_mod='" & cuenta & "'," & "maquina='" & maquina & "',"
        cad3 = " cod_doc='" & doc & "', ser_doc='" & ser & "',nro_doc='" & nro & "', ser_guia='" & serg & "',nro_guia='" & nrog _
                & "',cod_fpago='" & fp & "',cod_alma='" & ca & "',cancelado=" & canc & ",pre_inc_igv=" & inc & ",nro_dec=" & dec & ",obs='" & obs & "',tm='" & mo & "'"
        cad4 = " where operacion=" & ope & IIf(h, " and proceso='" & pr & "'", "")

        cad = cad1 + cad2 + cad3 + cad4
        com.CommandText = cad
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function
    Public Function actualizaCabecera_oc(ByVal ope As Integer,
                            ByVal fec As Date,
                            ByVal prov As String,
                            ByVal doc As String,
                            ByVal ser As String,
                            ByVal nro As String,
                            ByVal serg As String,
                            ByVal nrog As String,
                            ByVal nrotr As String,
                            ByVal fp As String,
                            ByVal ca As String,
                            ByVal canc As Boolean,
                            ByVal inc As Boolean,
                            ByVal dec As Integer,
                            ByVal obs As String,
                            ByVal mo As String) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim cad, cad1, cad2, cad3 As String, result As Integer
        Dim mfecha As String = Microsoft.VisualBasic.Trim(fec.ToString("yyyy-MM-dd"))
        cad1 = "update orden_compra set fec_doc='" & mfecha & "'," & "cod_prov='" & prov & "',"
        cad2 = "cod_doc='" & doc & "', ser_doc='" & ser & "',nro_doc='" & nro & "', ser_guia='" & serg & "',nro_guia='" & nrog _
                & "',cod_fpago='" & fp & "',cod_alma='" & ca & "',cancelado=" & canc & ",pre_inc_igv=" & inc & ",nro_dec=" & dec & ",obs='" & obs & "',tm='" & mo & "'"
        cad3 = " where operacion=" & ope
        cad = cad1 + cad2 + cad3
        com.CommandText = cad
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function

    Public Function actualizaCabeceraTransf(ByVal nroOperacion As Integer,
                                    ByVal fec_doc As Date,
                                    ByVal cod_almadestino As String,
                                    ByVal cod_areadestino As String) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim sql As String, result As Integer
        Dim mfecha As String = Microsoft.VisualBasic.Trim(fec_doc.ToString("yyyy-MM-dd"))

        sql = "update ingreso set fec_doc='" & mfecha _
                      & "' ,cod_area='" & cod_areadestino & "', cod_alma='" & cod_almadestino _
                      & "'   where operacion=" & nroOperacion
        com.CommandText = sql
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function
    Public Function actualizaDetalle(ByVal ing As Integer, _
                             ByVal cant As Decimal, _
                             ByVal pre As Decimal, _
                             ByVal igv As Decimal, _
                             ByVal saldo As Decimal) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim cad, cad1, cad2 As String, result As Integer
        cad1 = "update ingreso_det set cant=" & cant & ",precio=" & pre & ",igv=" & igv & ",saldo=" & saldo
        cad2 = " where ingreso=" & ing
        cad = cad1 + cad2
        com.CommandText = cad
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function

    Public Function actualizaArticulo(ByVal operacion As Integer, ByVal cod_art As String, _
                         ByVal cant As Decimal, _
                         ByVal pre As Decimal) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim cad, cad1, cad2 As String, result As Integer
        cad1 = "update ingreso_det set cant= cant +" & cant & ",precio=" & pre & ",saldo= saldo+" & cant
        cad2 = " where operacion=" & operacion & " and cod_art='" & cod_art & "'"
        cad = cad1 + cad2
        com.CommandText = cad
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function

    Public Function actualizaDetalleTransf(ByVal ing As Integer, _
                                        ByVal cant As Decimal) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim cad, cad1, cad2 As String, result As Integer
        cad1 = "update ingreso_det set cant=" & cant & ",saldo=" & cant
        cad2 = " where ingreso=" & ing
        cad = cad1 + cad2
        com.CommandText = cad
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function
    Public Function actualizaDetalleInv(ByVal h As Boolean, _
                            ByVal pr As String, _
                            ByVal ing As Integer, _
                            ByVal cant As Decimal, _
                            ByVal pre As Decimal, _
                            ByVal igv As Decimal, _
                            ByVal saldo As Decimal) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim cad, cad1, cad2, cad3 As String, result As Integer
        If h Then
            cad1 = "update h_ingreso_det as hd "
        Else
            cad1 = "update ingreso_det as hd "
        End If
        cad2 = " set hd.cant=" & cant & ",hd.precio=" & pre & ",hd.igv=" & igv & ",hd.saldo=" & saldo
        cad3 = " where hd.ingreso=" & ing _
                & IIf(h, " and hd.proceso='" & pr & "'", "")
        cad = cad1 + cad2 + cad3
        com.CommandText = cad
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function
    Public Function actualizaDetalleInvInicial(ByVal calma As String, _
                            ByVal cart As String, ByVal cant As Decimal) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim cad, cad1, cad2, cad3 As String, result As Integer
        cad1 = " update ingreso_det id inner join ingreso i on i.operacion=id.operacion "
        cad2 = " set id.cant=" & cant
        cad3 = " where i.cod_doc='10' and i.cod_alma='" & calma & "' and id.cod_art='" & cart & "'"
        'update ingreso_det id 
        'inner join ingreso i on i.operacion=id.operacion 
        'inner join art_relaalmacenes ar on id.cod_art=ar.cod_art
        '        id.cod_art = ar.cod_Artalma
        'where i.cod_alma='0012' and ar.cod_alma='0002'
        cad = cad1 + cad2 + cad3
        com.CommandText = cad
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function
    Public Function actualizaPrecioIngreso(ByVal h As Boolean, ByVal pr As String, ByVal ing As Integer,
                         ByVal pre As Decimal, ByVal cant As Decimal) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim cad, cad1, cad2, cad3 As String, result As Integer
        If h Then
            cad1 = "update h_ingreso_det  "
        Else
            cad1 = "update ingreso_det  "
        End If
        cad2 = " set precio=" & pre & ",cant=" & cant
        cad3 = " where ingreso=" & ing & IIf(h, " and proceso='" & pr & "'", "")
        cad = cad1 + cad2 + cad3
        com.CommandText = cad
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function
    Public Function actualizaPrecioCosto(ByVal ca As String, _
                     ByVal pre As Decimal, ByVal pMax As Decimal, ByVal pMin As Decimal) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim cad, cad1, cad2 As String, result As Integer
        cad1 = "update articulo set pre_costo=" & pre & ",pre_costomax=" & pMax & ",pre_costomin=" & pMin
        cad2 = " where cod_art='" & ca & "' and pre_costo=0"
        cad = cad1 + cad2
        com.CommandText = cad
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function
    Public Function actualizaIGVcero(ByVal ing As Integer) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim cad, cad1, cad2 As String, result As Integer
        cad1 = "update ingreso_det set igv=0"
        cad2 = " where ingreso=" & ing
        cad = cad1 + cad2
        com.CommandText = cad
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function
    Public Function salidasDelIngreso(ByVal ing As Integer) As Decimal
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim cad, cad1, cad2 As String, result As Decimal
        cad1 = "select sum(cant) from salida_det"
        cad2 = " where ingreso=" & ing
        cad = cad1 + cad2
        com.CommandText = cad
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Decimal)
        clConex.Close()
        Return result
    End Function
    Public Function devOpeIngreso(ByVal calma As String, ByVal cart As String) As Integer
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim cad, cad1, cad2 As String, result As Integer
        cad1 = " select id.ingreso from ingreso_det id inner join ingreso i on i.operacion=id.operacion "
        cad2 = " where i.cod_doc='10' and i.cod_alma='" & calma & "' and id.cod_art='" & cart & "'"
        cad = cad1 + cad2
        com.CommandText = cad
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Integer)
        clConex.Close()
        Return result
    End Function

    Public Function devSalidasDelIngreso(ByVal ing As Integer) As Decimal
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim cad, cad1, cad2 As String, result As Decimal
        cad1 = "select sum(cant) from salida_det"
        cad2 = " where ingreso=" & ing
        cad = cad1 + cad2
        com.CommandText = cad
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Decimal)
        clConex.Close()
        Return result
    End Function
    Public Function eliminaDetalle(ByVal ing As Integer) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim sql As String, result As Integer
        sql = "delete from ingreso_det where ingreso=" & ing
        com.CommandText = sql
        result = com.ExecuteNonQuery
        ' Conexion.insertar_Auditoria(sql)
        clConex.Close()
        Return result
    End Function
    Public Function eliminaDetalle_OC(ByVal ing As Integer) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim sql As String, result As Integer
        sql = "delete from orden_compra_det where ingreso=" & ing
        com.CommandText = sql
        result = com.ExecuteNonQuery
        ' Conexion.insertar_Auditoria(sql)
        clConex.Close()
        Return result
    End Function
    Public Function eliminaCabecera(ByVal ope As Integer, ByVal datosAdt As String) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim sql As String, result As Integer
        sql = "delete from ingreso where operacion=" & ope
        com.CommandText = sql
        result = com.ExecuteNonQuery
        Conexion.insertar_Auditoria(sql, datosAdt)
        clConex.Close()
        Return result
    End Function
    Public Function existe(ByVal doc As String, ByVal ser As String, ByVal nro As String, ByVal cp As String) As Integer
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer, cad, cad1, cad2, cad3 As String
        com.Connection = clConex
        cad1 = "Select operacion from ingreso where"
        cad2 = " cod_doc='" & doc & "'" & "and ser_doc='" & ser & "'"
        cad3 = " and nro_doc='" & nro & "'" & " and cod_prov='" & cp & "'"
        cad = cad1 + cad2 + cad3
        com.CommandText = cad
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Integer)
        clConex.Close()
        Return result
    End Function
    Public Function existe_historial(ByVal pr As String, ByVal doc As String, ByVal ser As String, _
            ByVal nro As String, ByVal cp As String) As Integer
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer, cad, cad1, cad2, cad3 As String
        com.Connection = clConex
        cad1 = "Select operacion from h_ingreso where"
        cad2 = " proceso='" & pr & "' and cod_doc='" & doc & "'" & "and ser_doc='" & ser & "'"
        cad3 = " and nro_doc='" & nro & "'" & " and cod_prov='" & cp & "'"
        cad = cad1 + cad2 + cad3
        com.CommandText = cad
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Integer)
        clConex.Close()
        Return result
    End Function
    Public Function existe_historialGeneral(ByVal doc As String, ByVal ser As String, _
            ByVal nro As String, ByVal cp As String) As Integer
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer, cad, cad1, cad2, cad3 As String
        com.Connection = clConex
        cad1 = "Select operacion from h_ingreso where"
        cad2 = " cod_doc='" & doc & "'" & "and ser_doc='" & ser & "'"
        cad3 = " and nro_doc='" & nro & "'" & " and cod_prov='" & cp & "'"
        cad = cad1 + cad2 + cad3
        com.CommandText = cad
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Integer)
        clConex.Close()
        Return result
    End Function
    Public Function devuelveFechaIngreso(ByVal h As Boolean, ByVal pr As String, ByVal doc As String, ByVal ser As String, ByVal nro As String) As Date
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Date
        com.Connection = clConex
        Dim cad, cad1, cad2
        cad1 = "Select fecha from " & IIf(h, " h_ingreso", " ingreso")
        cad2 = " where cod_doc='" & doc & "'" & "and ser_doc='" & ser & "'" & " and nro_doc='" & nro & "'"
        cad = cad1 + cad2
        com.CommandText = cad
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Date)
        clConex.Close()
        Return result
    End Function
    Public Function devuelveFechaIngreso_historialGeneral(ByVal cp As String, ByVal cd As String, _
            ByVal ser As String, ByVal nro As String) As Date
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Date
        com.Connection = clConex
        Dim cad, cad1, cad2
        cad1 = "Select fecha from ingreso"
        cad2 = " where cod_prov='" & cp & "' and cod_doc='" & cd & "'" & "and ser_doc='" & ser & "'" & " and nro_doc='" & nro & "'"
        cad = cad1 + cad2
        com.CommandText = cad
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Date)
        clConex.Close()
        Return result
    End Function
    Public Function devuelveFechaInventario(ByVal ope As Integer) As Date
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Date
        com.Connection = clConex
        Dim cad, cad1, cad2
        cad1 = "Select fecha from ingreso"
        cad2 = " where operacion=" & ope
        cad = cad1 + cad2
        com.CommandText = cad
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Date)
        clConex.Close()
        Return result
    End Function
    Public Function devuelveSaldo(ByVal ing As Integer) As Decimal
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, cad, cad1, cad2 As String
        com.Connection = clConex
        cad1 = "Select saldo from ingreso_det"
        cad2 = " where ingreso=" & ing
        cad = cad1 + cad2
        com.CommandText = cad
        Dim saldo As Object = com.ExecuteScalar
        clConex.Close()
        Return saldo
    End Function
    Public Function devuelveSaldoArticulo(ByVal cod_Art As String) As Decimal
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, cad, cad1, cad2 As String
        com.Connection = clConex
        cad1 = "Select sum(saldo) from ingreso_det"
        cad2 = " where cod_Art='" & cod_Art & "' group by cod_Art"
        cad = cad1 + cad2
        com.CommandText = cad
        Dim saldo As Object = com.ExecuteScalar
        clConex.Close()
        Return saldo
    End Function
    Public Function existeSaldoParaEliminar(ByVal ope As Integer) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer, sql As String
        com.Connection = clConex
        sql = "Select operacion from ingreso where operacion=" & ope
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
    Public Function existeSalida(ByVal ing As Integer, ByVal anul As Boolean) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer, sql As String
        com.Connection = clConex
        If anul Then
            sql = "Select ingreso from salida_det where ingreso=" & ing & " and anul=0"
        Else
            sql = "Select ingreso from salida_det where ingreso=" & ing
        End If
        com.CommandText = sql
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Integer)
        clConex.Close()
        If result > 0 Then
            Return True
        Else
            Return False
        End If
        Return result
    End Function

    Public Function existeArticulo(ByVal operacion As Integer, ByVal cod_art As String) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer, sql As String
        com.Connection = clConex
        sql = "Select ingreso from ingreso_det where operacion=" & operacion & " and cod_art='" & cod_art & "'"
        com.CommandText = sql
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Integer)
        clConex.Close()
        If result > 0 Then
            Return True
        Else
            Return False
        End If
        Return result
    End Function

    Public Function estaAnulada(ByVal ope As Integer) As Integer
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer, cad As String
        com.Connection = clConex
        cad = "Select anul from ingreso where operacion='" & ope & "'"
        com.CommandText = cad
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Integer)
        clConex.Close()
        Return result
    End Function
    Public Function maxOperacion() As Integer
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer
        com.Connection = clConex
        com.CommandText = "select max(operacion) from ingreso"
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Integer)
        clConex.Close()
        Return result + 1
    End Function
    Public Function maxOperacion_oc() As Integer
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer
        com.Connection = clConex
        com.CommandText = "select max(operacion) from orden_compra"
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Integer)
        clConex.Close()
        Return result + 1
    End Function
    Public Function maxOperacion_his(ByVal periodo As String) As Integer
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer
        com.Connection = clConex
        com.CommandText = "select max(operacion) from h_ingreso where proceso='" & periodo & "'"
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Integer)
        clConex.Close()
        Return result + 1
    End Function

    Public Function maxIngreso() As Integer
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer
        com.Connection = clConex
        com.CommandText = "select max(ingreso) from ingreso_det"
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Integer)
        clConex.Close()
        Return result + 1
    End Function
    Public Function maxIngreso_oc() As Integer
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer
        com.Connection = clConex
        com.CommandText = "select max(ingreso) from orden_compra_det"
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Integer)
        clConex.Close()
        Return result + 1
    End Function
    Public Function maxIngreso_his(ByVal periodo As String) As Integer
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer
        com.Connection = clConex
        com.CommandText = "select max(ingreso) from h_ingreso_det where proceso='" & periodo & "'"
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Integer)
        clConex.Close()
        Return result + 1
    End Function

    Public Function maxIngresohis(ByVal his As Boolean, ByVal proc As String) As Integer
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer
        com.Connection = clConex
        If his = False Then
            com.CommandText = "select max(ingreso) from ingreso_det"
        Else
            com.CommandText = "select max(ingreso) from h_ingreso_det where proceso='" & proc & "'"
        End If
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Integer)
        clConex.Close()
        Return result + 1
    End Function
    Public Function maxNotaIngreso(ByVal cod_doc As String, ByVal ser As String) As String
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer
        com.Connection = clConex
        com.CommandText = "select max(nro_doc) from ingreso where cod_doc='" & cod_doc & "'" & " and ser_doc='" & ser & "'"
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), "00000000", obj), String)
        Dim resp As String = Right("00000000" & Trim(Str(Microsoft.VisualBasic.Val(result) + 1)), 8)
        clConex.Close()
        Return resp
    End Function
    Public Function existeNotaIngreso(ByVal ser As String, ByVal nro As String) As Integer
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer, cad, cad1, cad2 As String, cod_doc As String = "03"
        com.Connection = clConex
        cad1 = "Select operacion from ingreso where"
        cad2 = " cod_doc='" & cod_doc & "'" & " and ser_doc='" & ser & "'" & " and nro_doc='" & nro & "'"
        cad = cad1 + cad2
        com.CommandText = cad
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Integer)
        clConex.Close()
        Return result
    End Function
    Public Function existeNotaIngreso_historial(ByVal pr As String, ByVal ser As String, ByVal nro As String) As Integer
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer, cad, cad1, cad2 As String, cod As String = "03"
        com.Connection = clConex
        cad1 = "Select operacion from h_ingreso where"
        cad2 = " proceso='" & pr & "' and cod_doc='" & cod & "'" & " and ser_doc='" & ser & "'" & " and nro_doc='" & nro & "'"
        cad = cad1 + cad2
        com.CommandText = cad
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Integer)
        clConex.Close()
        Return result
    End Function
    Public Function existeNotaIngreso_historialGeneral(ByVal ser As String, ByVal nro As String) As Integer
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer, cad, cad1, cad2 As String, cod As String = "03"
        com.Connection = clConex
        cad1 = "Select operacion from h_ingreso where"
        cad2 = " cod_doc='" & cod & "'" & " and ser_doc='" & ser & "'" & " and nro_doc='" & nro & "'"
        cad = cad1 + cad2
        com.CommandText = cad
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Integer)
        clConex.Close()
        Return result
    End Function
    Public Function exisTransferencia_documento(ByVal op As Integer) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer, cad, cad1, cad2 As String
        com.Connection = clConex
        cad1 = "Select count(nAux2) from salida_det"
        cad2 = " where nAux2=" & op
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
    Public Function recProveedor(ByVal op As Integer, ByVal esHistorial As Boolean, ByVal nroProceso As String) As String
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim cad, cad1, cad2, result As String
        If esHistorial Then
            cad1 = "select raz_soc from h_ingreso as h inner join proveedor on h.cod_prov=proveedor.cod_prov"
        Else
            cad1 = "select raz_soc from ingreso as h inner join proveedor on h.cod_prov=proveedor.cod_prov"
        End If
        cad2 = " where h.operacion=" & op _
                & IIf(esHistorial, " and h.proceso='" & nroProceso & "'", "")
        cad = cad1 + cad2
        Dim comTrans As New MySqlCommand(cad)
        comTrans.Connection = clConex
        Dim obj As Object = comTrans.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), "", obj), String)
        clConex.Close()
        Return result
    End Function
    Public Function recDocumentos(ByVal car As String, Optional ByVal x As Boolean = True) As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter
        Dim cad, cad1, cad2, cad3, cad4, cad5, cad6 As String
        cad1 = "select ingreso.operacion,concat(abr,ser_doc,'-',nro_doc) as documento,concat(abr,right(ser_doc,3),'-',nro_doc) as doc,raz_soc,fec_doc"
        cad2 = " from ingreso inner join ingreso_det"
        cad3 = " on ingreso.operacion=ingreso_det.operacion"
        cad4 = " inner join proveedor on ingreso.cod_prov=proveedor.cod_prov"
        cad5 = " inner join documento_i on ingreso.cod_doc=documento_i.cod_doc"
        cad6 = " where cod_Art = '" & car & "' And (documento_i.esIngreso)"
        cad = cad1 + cad2 + cad3 + cad4 + cad5 + cad6
        Dim com As New MySqlCommand(cad, clConex)
        da.SelectCommand = com
        da.Fill(ds, "ingreso")
        clConex.Close()
        Return ds
    End Function
    Public Function recDocumento(ByVal op As Integer, ByVal eshistorial As Boolean, ByVal nroproceso As String) As String
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim cad, cad1, cad2, result As String
        If eshistorial Then
            cad1 = "select concat(nom_doc,': ',ser_doc,'-',nro_doc) as documento from h_ingreso as h inner join documento_i on h.cod_doc=documento_i.cod_doc"
        Else
            cad1 = "select concat(nom_doc,': ',ser_doc,'-',nro_doc) as documento from ingreso as h inner join documento_i on h.cod_doc=documento_i.cod_doc"
        End If
        cad2 = " where h.operacion=" & op _
                & IIf(eshistorial, " and h.proceso='" & nroproceso & "'", "")
        cad = cad1 + cad2
        Dim comTrans As New MySqlCommand(cad)
        comTrans.Connection = clConex
        Dim obj As Object = comTrans.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), "", obj), String)
        clConex.Close()
        Return result
    End Function
    Public Function recCompras(ByVal emp As String, ByVal xAC As Boolean, ByVal xfecha As Boolean, ByVal fechaI As Date, ByVal fechaf As Date, ByVal h As Boolean,
                    ByVal pr As String, ByVal xA As Boolean, ByVal ca As String, ByVal gr As Boolean) As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter
        Dim mfechaI As String = fechaI.ToString("yy-MM-dd")
        Dim mfechaF As String = fechaf.ToString("yy-MM-dd")
        Dim cad, cad1, cad2, cad3, cad4, cad5, cad6 As String
        cad1 = "select ingreso,cod_art," & IIf(gr, "sum(cant) as cant", "cant") & ",precio"
        If h Then
            cad2 = " from h_ingreso as h inner join h_ingreso_det as hd on h.operacion=hd.operacion and h.proceso=hd.proceso"
        Else
            cad2 = " from ingreso as h inner join ingreso_det as hd on h.operacion=hd.operacion"
        End If
        cad3 = " inner join documento_i on h.cod_doc=documento_i.cod_doc"
        cad4 = " inner join almacen on h.cod_alma=almacen.cod_alma"
        'cad5 = " where (esCompra) and almacen.cod_emp='" & emp & "'" _
        cad5 = " where (almacen.es_invMensual) and (esIngresoAlma)" & IIf(xA, " and h.cod_alma='" & ca & "'", "") _
            & IIf(h, " and h.proceso='" & pr & "'", "") _
            & IIf(xfecha, " and (fec_doc) >='" & mfechaI & "' and (fec_doc)<='" & mfechaF & "'", "")

        cad6 = IIf(gr, " group by cod_art", "") & " order by cod_art"
        cad = cad1 + cad2 + cad3 + cad4 + cad5 + cad6
        Dim com As New MySqlCommand(cad, clConex)
        da.SelectCommand = com
        da.Fill(ds, "compra")
        clConex.Close()
        Return ds
    End Function
    Public Function recIngresos_NOcompras(ByVal emp As String, ByVal cXA As Boolean, ByVal h As Boolean, _
                ByVal pr As String, ByVal xA As Boolean, ByVal ca As String, ByVal agr As Boolean) As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter
        Dim cad, cad1, cad2, cad3, cad4, cad5, cad6 As String
        cad1 = "select ingreso,cod_art," & IIf(agr, "sum(cant) as cant", "cant") & ",precio"
        If h Then
            cad2 = " from h_ingreso as h inner join h_ingreso_det as hd on h.operacion=hd.operacion and h.proceso=hd.proceso"
        Else
            cad2 = " from ingreso as h inner join ingreso_det as hd on h.operacion=hd.operacion"
        End If
        cad3 = " inner join documento_i on h.cod_doc=documento_i.cod_doc"
        cad4 = " inner join almacen on h.cod_alma=almacen.cod_alma"
        cad5 = " where not(esCompra) and almacen.cod_alma='" & emp & "'" _
            & IIf(h, " and h.proceso='" & pr & "' and hd.proceso='" & pr & "'", "")
        cad6 = IIf(agr, " group by cod_art", "") & " order by cod_art"
        cad = cad1 + cad2 + cad3 + cad4 + cad5 + cad6
        Dim com As New MySqlCommand(cad, clConex)
        da.SelectCommand = com
        da.Fill(ds, "ingreso")
        clConex.Close()
        Return ds
    End Function
    Public Function recInvInicial_prod(ByVal emp As String, ByVal cXA As Boolean, ByVal h As Boolean, _
                ByVal pr As String, ByVal xA As Boolean, ByVal ca As String, ByVal agr As Boolean) As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter
        Dim cad, cad1, cad2, cad3, cad4, cad5 As String
        cad1 = "select ingreso,cod_art," & IIf(agr, "sum(cant) as cant", "cant") & ",precio"
        If h Then
            cad2 = " from h_ingreso as h inner join h_ingreso_det as hd on h.operacion=hd.operacion and h.proceso=hd.proceso"
        Else
            cad2 = " from ingreso as h inner join ingreso_det as hd on h.operacion=hd.operacion"
        End If
        cad3 = " inner join almacen on h.cod_alma=almacen.cod_alma"
        'cad4 = " where h.proceso=hd.proceso and h.cod_doc='10' and almacen.cod_emp='" & emp & "'" _
        cad4 = " where h.cod_doc='10' and (almacen.es_InvMensual) and almacen.cod_emp='" & emp & "'" _
         & IIf(h, " and h.proceso='" & pr & "'", "") & IIf(xA, " and h.cod_alma='" & ca & "'", "")
        cad5 = IIf(agr, " group by cod_art", "") & " order by cod_art"
        cad = cad1 + cad2 + cad3 + cad4 + cad5
        Dim com As New MySqlCommand(cad, clConex)
        da.SelectCommand = com
        da.Fill(ds, "inicial")
        clConex.Close()
        Return ds
    End Function
    Public Function rec_producciones(ByVal emp As String, ByVal cXA As Boolean, ByVal h As Boolean, _
            ByVal pr As String, ByVal xA As Boolean, ByVal ca As String, ByVal agr As Boolean) As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter
        Dim cad, cad1, cad2, cad3, cad4, cad5 As String
        cad1 = "select ingreso,cod_art," & IIf(agr, "sum(cant) as cant", "cant") & ",precio"
        If h Then
            cad2 = " from h_ingreso as h inner join h_ingreso_det as hd on h.operacion=hd.operacion and h.proceso=hd.proceso"
        Else
            cad2 = " from ingreso as h inner join ingreso_det as hd on h.operacion=hd.operacion"
        End If
        cad3 = " inner join almacen on h.cod_alma=almacen.cod_alma"
        'cad4 = " where h.proceso=hd.proceso and h.cod_doc='10' and almacen.cod_emp='" & emp & "'" _
        cad4 = " where h.cod_doc='93' and (almacen.es_InvMensual) and almacen.cod_emp='" & emp & "'" _
         & IIf(h, " and h.proceso='" & pr & "'", "") & IIf(xA, " and h.cod_alma='" & ca & "'", "")
        cad5 = IIf(agr, " group by cod_art", "") & " order by cod_art"
        cad = cad1 + cad2 + cad3 + cad4 + cad5
        Dim com As New MySqlCommand(cad, clConex)
        da.SelectCommand = com
        da.Fill(ds, "inicial")
        clConex.Close()
        Return ds
    End Function
    Public Function recInvInicial_princ(ByVal emp As String, ByVal cXA As Boolean, ByVal h As Boolean, _
            ByVal pr As String, ByVal xA As Boolean, ByVal ca As String, ByVal agr As Boolean) As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter
        Dim cad, cad1, cad2, cad3, cad4, cad5 As String
        cad1 = "select ingreso,cod_art," & IIf(agr, "sum(cant) as cant", "cant") & ",precio"
        cad2 = " from h_ingreso as h inner join h_ingreso_det as hd on h.operacion=hd.operacion"
        cad3 = " inner join almacen on h.cod_alma=almacen.cod_alma"
        'cad4 = " where h.proceso=hd.proceso and h.cod_doc='10' and not(almacen.esProduccion) and almacen.cod_emp='" & emp & "'" _
        cad4 = " where h.proceso=hd.proceso and h.cod_doc='10' and not(almacen.esProduccion) and almacen.cod_emp='" & emp & "'" _
        & IIf(h, " and h.proceso='" & pr & "'", "")
        cad5 = IIf(agr, " group by cod_art", "") & " order by cod_art"
        cad = cad1 + cad2 + cad3 + cad4 + cad5
        Dim com As New MySqlCommand(cad, clConex)
        da.SelectCommand = com
        da.Fill(ds, "inicial")
        clConex.Close()
        Return ds
    End Function
    Public Function recuperaCompras(ByVal eshistorial As Boolean, ByVal agrupado As Boolean, ByVal xAlmacen As Boolean, ByVal cAlmacen As String, _
                                    ByVal esMensual As Boolean, ByVal anno As Integer, ByVal fechaInicio As Date, ByVal fechaFinal As Date, ByVal cPrecio As String) As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim da As New MySqlDataAdapter
        Dim ds As New DataSet
        Dim cad, cad1, cad2, cad3, cad4, cad5, cad6, cad7, cad8, cad9, cad10 As String
        Dim mfechaI As String = fechaInicio.ToString("yyyy-MM-dd")
        Dim mfechaF As String = fechaFinal.ToString("yyyy-MM-dd")
        ',concat(MONTHNAME(fec_doc),year(fec_doc)) as mes
        cad1 = " select fec_doc,hour(fecha) as hora,concat(MONTHNAME(fec_doc),'-',year(fec_doc)) as mes,concat(ser_doc,'-',nro_doc)as documento,nom_tipo,nom_prov,gc.nom_sgrupo as gcompra,gv.nom_sgrupo as gventa,nom_art," & cPrecio & "as precio,if(es_pcosto,0,pre_costo) as pre_costo,'000' as sucursal," _
            & IIf(agrupado, "sum(cant) as cant,sum(cant*precio) as imp_venta,sum(cant*if(es_pcosto,0,pre_costo)) as imp_costo", "cant,(cant*precio) as imp_venta,(cant*if(es_pcosto,0,pre_costo)) as imp_costo") & ",nom_uni,sd.cod_art "
        cad2 = IIf(eshistorial, " from h_ingreso s inner join h_ingreso_det sd", " from ingreso s inner join ingreso_det sd")
        cad3 = IIf(eshistorial, " on s.operacion=sd.operacion and s.proceso=sd.proceso", " on s.operacion=sd.operacion")
        cad4 = " inner join articulo on sd.cod_art=articulo.cod_art inner join subgrupo gc on gc.cod_sgrupo=articulo.cod_sgrupo left join subgrupo gv on gv.cod_sgrupo=articulo.cod_grupov"
        cad5 = " inner join unidad on articulo.cod_uni=unidad.cod_uni inner join tipo_articulo ta on articulo.cod_tart=ta.cod_tart"
        cad6 = " inner join documento_i d on s.cod_doc=d.cod_doc"
        cad7 = " inner join proveedor on s.cod_prov=proveedor.cod_prov inner join tipo_proveedor on tipo_proveedor.cod_tipo=proveedor.cod_tipo"
        cad8 = IIf(esMensual, " where d.esCompra=1 and year(fec_doc)=" & anno, " where d.esCompra=1 and fec_doc>='" & mfechaI & "'" & " and fec_doc<='" & mfechaF & "'")
        cad9 = IIf(xAlmacen, " and s.cod_alma='" & cAlmacen & "'", "")
        cad10 = IIf(agrupado, " group by sd.cod_art,fec_doc", "") & " order by nom_art,fec_doc"
        cad = cad1 + cad2 + cad3 + cad4 + cad5 + cad6 + cad7 + cad8 + cad9 + cad10
        Dim comTrans As New MySqlCommand(cad)
        comTrans.CommandTimeout = 300
        comTrans.Connection = clConex
        da.SelectCommand = comTrans
        da.Fill(ds, "articulos")
        clConex.Close()
        Return ds
    End Function

    Public Function recuperaNrosOC(ByVal cod_alma As String) As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim da As New MySqlDataAdapter
        Dim dsTrans As New DataSet
        Dim cad, cad1, cad2, cad3 As String
        cad1 = "select operacion, fec_doc,concat(ser_doc,'-',nro_doc) as doc, ser_doc, nro_doc"
        cad2 = " from orden_compra "
        cad3 = " where cod_estado='0001' " & IIf(cod_alma = "0000", "", " and cod_alma= '" & cod_alma & "'")
        cad = cad1 + cad2 + cad3
        Dim comTrans As New MySqlCommand(cad)
        comTrans.Connection = clConex
        da.SelectCommand = comTrans
        da.Fill(dsTrans, "nrosTransferencia")
        clConex.Close()
        Return dsTrans
    End Function
End Class
