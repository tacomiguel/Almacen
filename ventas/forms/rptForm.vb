Imports MySql.Data.MySqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports System.IO
Imports System.Drawing
Imports CrystalDecisions.Shared
Imports libreriaClases

Public Class rptForm

    Public Sub cargarCatalogo(ByVal cod_alma As String, ByVal soloActivos As Boolean, ByVal soloventas As Boolean, ByVal soloInventarioDiario As Boolean, ByVal titulo As String)
        Dim ds As New DataSet
        Dim mCatalogo As New Catalogo
        ds = mCatalogo.recuperaCatalogo(pCatalogoXalmacen, cod_alma, soloActivos, soloventas, soloInventarioDiario, False, "", False, False, False)
        Dim rpt As New rptCatalogo
        Try
            Dim pf0, pf As New ParameterField
            Dim pdv0, pdv As New ParameterDiscreteValue
            Dim pfs As New ParameterFields
            pf0.Name = "ruta"
            pdv0.Value = pruta
            pf0.CurrentValues.Add(pdv0)
            pfs.Add(pf0)
            pf.Name = "tipoReporte"
            pdv.Value = titulo
            pf.CurrentValues.Add(pdv)
            pfs.Add(pf)
            rpt.SetDataSource(ds)
            crv.ParameterFieldInfo = pfs
            crv.ReportSource = rpt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub cargarCatalogo_x_Tipo(ByVal cod_alma As String, ByVal sa As Boolean, ByVal tipo As String, ByVal codigo As String, ByVal nombreTipo As String)
        Dim ds As New DataSet
        Dim mCatalogo As New Catalogo
        ds = mCatalogo.recuperaCatalogo_x_tipo(cod_alma, sa, tipo, codigo)
        Dim rpt As New rptCatalogo
        Dim pf0, pf As New ParameterField
        Dim pdv0, pdv As New ParameterDiscreteValue
        Dim pfs As New ParameterFields
        pf0.Name = "ruta"
        pdv0.Value = pruta
        pf0.CurrentValues.Add(pdv0)
        pfs.Add(pf0)
        pf.Name = "tipoReporte"
        pdv.Value = nombreTipo
        pf.CurrentValues.Add(pdv)
        pfs.Add(pf)
        rpt.SetDataSource(ds)
        crv.ParameterFieldInfo = pfs
        crv.ReportSource = rpt
    End Sub
    Public Sub cargarCatalogo_Precio()
        Dim ds As New DataSet
        Dim dt As New DataTable("articuloPrecio")
        ds = Catalogo.dsCatalogo
        Dim da As New MySqlDataAdapter
        Dim com As New MySqlCommand("Select distinct articulo.cod_art,nom_art,nom_uni,concat(nom_art,' ',nom_uni) as articulo,articulo.activo,cod_tart,cod_sgrupo,art_tipoCliente.cod_tipo,precio,comi_v,nom_tipo from articulo inner join unidad on articulo.cod_uni=unidad.cod_uni left join art_tipoCliente on articulo.cod_art=art_tipoCliente.cod_art inner join tipo_cliente on art_tipoCliente.cod_tipo =tipo_cliente.cod_tipo order by nom_art", dbConex)
        da.SelectCommand = com
        da.Fill(ds, "articuloPrecio")
        Dim rpt As New rptCatalogoPrecio
        rpt.SetDataSource(ds)
        crv.ReportSource = rpt
        crv.RefreshReport()
    End Sub
    Public Sub cargarClientes()
        Dim ds As New DataSet
        Dim dt As New DataTable("cliente")
        ds = Cliente.dsCliente
        Dim da As New MySqlDataAdapter
        Dim com As New MySqlCommand("Select cod_clie,nom_clie,raz_soc,dir_clie,fono_clie,cod_tipo,dir_ent,hora_ent,nom_rep,fono_rep,activo from cliente", dbConex)
        da.SelectCommand = com
        da.Fill(ds, "cliente")
        Dim rpt As New rptCliente
        Dim pf0 As New ParameterField
        Dim pdv0 As New ParameterDiscreteValue
        Dim pfs As New ParameterFields
        pf0.Name = "ruta"
        pdv0.Value = pruta
        pf0.CurrentValues.Add(pdv0)
        pfs.Add(pf0)
        rpt.SetDataSource(ds)
        crv.ParameterFieldInfo = pfs
        crv.ReportSource = rpt
        'crv.RefreshReport()
    End Sub

    Private Function logoEmpresa() As DataSet
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim ds As New DataSet

        dt.Columns.Add(New DataColumn("cod_empresa", GetType(Short)))
        dt.Columns.Add(New DataColumn("dsc_empresa", GetType(String)))
        dt.Columns.Add(New DataColumn("logo_empresa", GetType(Byte())))

        dr = dt.NewRow()
        dr("cod_empresa") = 1
        dr("dsc_empresa") = "Empresa XXXXX"
        dr("logo_empresa") = ImageToByte(Image.FromFile("E:\sga\logo.jpg"))
        dt.Rows.Add(dr)

        ds.Tables.Add(dt)
        ds.Tables(0).TableName = "Empresa"

        Dim iDS As New dsEmpresa
        iDS.Merge(ds, False, System.Data.MissingSchemaAction.Ignore)
        Return iDS
    End Function
    Public Function ImageToByte(ByVal pImagen As Image) As Byte()
        Dim mImage() As Byte = Nothing
        Try
            If Not IsNothing(pImagen) Then
                Dim ms As New System.IO.MemoryStream
                pImagen.Save(ms, pImagen.RawFormat)
                mImage = ms.GetBuffer
                ms.Close()
                'Return mImage
            End If
        Catch
        End Try
        Return mImage
    End Function
    Public Sub cargarNotaPedido(ByVal operacion As Integer)
        Dim ds As New DataSet
        Dim dt As New DataTable
        ds = pedido.dsPedido
        Dim da As New MySqlDataAdapter
        Dim sql, sql1, sql2, sql3, sql4, sql5, sql6, sql7, sql8, sql9, sql10, sql11 As String
        sql1 = " Select ser_ped,nro_ped,fecha,fec_ped,fec_ent,hor_ent,p.cod_clie,p.dir_ent,nom_clie as nom_clie,pd.obs as obsdet,"
        sql2 = " raz_soc,dir_clie,nom_cont, fono_clie,nom_vend,nom_fpago,nom_art,sum(cant) as cant,precio,cant*precio as monto,p.fec_ins,p.fec_mod, "
        sql3 = " p.monto as monto_doc,p.monto_igv,pre_inc_igv,p.obs,nom_uni,tm ,a.nom_alma,ar.nom_area,u.user as usuario,r.dsc_recurso as tip_pedido"
        sql4 = " from pedido p inner join Cliente on p.cod_clie=cliente.cod_clie "
        sql5 = " inner join vendedor on p.cod_vend=vendedor.cod_vend "
        sql6 = " inner join forma_pago on p.cod_fpago=forma_pago.cod_fpago "
        sql7 = " inner join pedido_det pd on p.operacion=pd.operacion"
        sql8 = " inner join articulo on pd.cod_art=articulo.cod_art inner join unidad on unidad.cod_uni=articulo.cod_uni "
        sql9 = " inner Join almacen a on p.cod_alma=a.cod_alma inner join usuario u on u.cuenta=p.cuenta  "
        sql10 = " Left Join area ar on p.cod_area=ar.cod_area left join tipo_recurso r on r.cod_recurso=p.cod_pedido "
        sql11 = " where r.cod_tabla='tip_pedido' and p.operacion=" & operacion & " group by articulo.cod_art order by nom_art"
        sql = sql1 + sql2 + sql3 + sql4 + sql5 + sql6 + sql7 + sql8 + sql9 + sql10 + sql11
        Dim com As New MySqlCommand(sql, dbConex)
        da.SelectCommand = com
        da.Fill(ds, "pedido")
        Dim rpt As New rptPedido
        Dim pf0 As New ParameterField
        Dim pdv0 As New ParameterDiscreteValue
        Dim pfs As New ParameterFields
        pf0.Name = "ruta"
        pdv0.Value = pruta
        pf0.CurrentValues.Add(pdv0)
        pfs.Add(pf0)
        rpt.SetDataSource(ds)
        crv.ParameterFieldInfo = pfs
        crv.ReportSource = rpt
    End Sub
    Public Sub cargarNotasPedido()
        Dim ds As New DataSet
        Dim dt As New DataTable
        ds = pedido.dsPedido
        Dim da As New MySqlDataAdapter
        Dim sql, sql1, sql2, sql3, sql4, sql5, sql6, sql7, sql8 As String
        sql1 = "Select ser_ped,nro_ped,fec_ped,fec_ent,pedido.cod_clie,pedido.dir_ent,nom_clie,raz_soc,dir_clie,nom_cont,"
        sql2 = "fono_clie,nom_vend,nom_fpago,nom_art,cant,precio,cant*precio as monto,"
        sql3 = " pedido.monto as monto_doc,pedido.monto_igv,pre_inc_igv,obs"
        sql4 = " from pedido inner join cliente on pedido.cod_clie=cliente.cod_clie"
        sql5 = " inner join vendedor on pedido.cod_vend=vendedor.cod_vend"
        sql6 = " inner join forma_pago on pedido.cod_fpago=forma_pago.cod_fpago"
        sql7 = " inner join pedido_det on pedido.operacion=pedido_det.operacion"
        sql8 = " inner join articulo on pedido_det.cod_art=articulo.cod_art"
        sql = sql1 + sql2 + sql3 + sql4 + sql5 + sql6 + sql7 + sql8
        Dim com As New MySqlCommand(sql, dbConex)
        da.SelectCommand = com
        da.Fill(ds, "pedido")
        Dim rpt As New rptPedido
        rpt.SetDataSource(ds)
        crv.ReportSource = rpt
        crv.RefreshReport()
    End Sub
    Public Sub cargarRegistroPedidos(ByVal anno As Integer, ByVal mes As Integer, ByVal fechaPedido As Date, ByVal fechaPedidohasta As Date,
                                      ByVal xDia As Boolean, ByVal cliente As Boolean,
                                      ByVal xestado As Boolean, ByVal tipo_pedido As String, ByVal estado As String, ByVal nom_Estado As String,
                                      ByVal cod_clie As String, ByVal nom_clie As String,
                                      ByVal xResp As Boolean, ByVal cod_resp As String, ByVal nom_resp As String)
        Dim da As New MySqlDataAdapter
        Dim ds As New DataSet
        Dim dt As New DataTable("pedido")
        ds.Tables.Add(dt)
        Dim mFecha, mfechahasta As String
        If xDia Then
            mFecha = fechaPedido.ToString("yyyy-MM-dd")
            mfechahasta = fechaPedidohasta.ToString("yyyy-MM-dd")
        Else
            mFecha = pTituloRep1
            mfechahasta = pTituloRep1
        End If

        Dim cad, sql1 As String
        sql1 = " Select ser_ped,nro_ped,fec_ped,fec_ent,hor_ent,p.cod_clie,p.dir_ent,nom_clie as nom_clie," &
         " raz_soc,dir_clie,nom_cont, fono_clie,nom_vend,nom_fpago " &
         " tm ,a.nom_alma,ar.nom_area,u.user as usuario,r.dsc_recurso as tip_pedido" &
         " from pedido p inner join Cliente on p.cod_clie=cliente.cod_clie " &
         " inner join vendedor on p.cod_vend=vendedor.cod_vend " &
         " inner join forma_pago on p.cod_fpago=forma_pago.cod_fpago " &
         " inner Join almacen a on p.cod_alma=a.cod_alma inner join usuario u on u.cuenta=p.cuenta  " &
         " Left Join area ar on p.cod_area=ar.cod_area left join tipo_recurso r on r.cod_recurso=p.cod_pedido " &
        "  Left join tipo_recurso r1 On r1.cod_recurso=p.cod_estado " &
        "  where r.cod_tabla ='tip_pedido' and r1.cod_tabla ='tip_epedido' " &
          IIf(xestado, "and p.cod_pedido='" & tipo_pedido & "'  and p.cod_estado ='" & estado & "'", "") &
           IIf(xDia, " and p.fec_ped>='" & mFecha & "' and p.fec_ped<='" & mfechahasta & "'", "") &
          IIf(xResp, "and p.cuenta='" & cod_resp & "'", "") &
        "  order by fec_ent"
        cad = sql1

        Dim com As New MySqlCommand(cad, dbConex)
        da.SelectCommand = com
        da.Fill(ds, "pedido")
        Dim rpt As New rptPedidosRegistro
        Dim pf0, pf, pfTit As New ParameterField
        Dim pdv0, pdv, pdvTit As New ParameterDiscreteValue
        Dim pfs As New ParameterFields
        pf0.Name = "ruta"
        pdv0.Value = pruta
        pf0.CurrentValues.Add(pdv0)
        pfs.Add(pf0)
        pf.Name = "mesAnno"
        pdv.Value = mFecha
        'pdnemp.Value = pNempresa
        pf.CurrentValues.Add(pdv)
        pfs.Add(pf)
        pfTit.Name = "titulo"
        If cliente Then
            pdvTit.Value = "Reg.Pedidos x Cliente: " & StrConv(nom_clie, VbStrConv.ProperCase)
        Else
            If xResp Then
                pdvTit.Value = "Reg.Pedidos x Responsable: " & StrConv(nom_resp, VbStrConv.ProperCase)
            Else
                pdvTit.Value = "Registro de Pedidos: " & StrConv(nom_Estado, VbStrConv.ProperCase)
            End If
        End If
        pfTit.CurrentValues.Add(pdvTit)
        pfs.Add(pfTit)
        rpt.SetDataSource(ds)
        crv.ParameterFieldInfo = pfs
        crv.ReportSource = rpt

    End Sub


    Public Sub cargarPedidosFormato(ByVal anno As Integer, ByVal mes As Integer, ByVal fechaPedido As Date, ByVal fechaPedidohasta As Date,
                                      ByVal xDia As Boolean, ByVal cliente As Boolean,
                                      ByVal xestado As Boolean, ByVal tipo_pedido As String, ByVal estado As String, ByVal nom_Estado As String,
                                      ByVal cod_clie As String, ByVal nom_clie As String,
                                      ByVal xResp As Boolean, ByVal cod_resp As String, ByVal nom_resp As String)
        Dim da As New MySqlDataAdapter
        Dim ds As New DataSet
        Dim dt As New DataTable("pedido")
        ds.Tables.Add(dt)
        Dim mFecha, mfechahasta As String
        If xDia Then
            mFecha = fechaPedido.ToString("yyyy-MM-dd")
            mfechahasta = fechaPedidohasta.ToString("yyyy-MM-dd")
        Else
            mFecha = pTituloRep1
            mfechahasta = pTituloRep1
        End If
        '" Select ser_ped,nro_ped,fec_ped,fec_ent,hor_ent,p.cod_clie,p.dir_ent,nom_clie as nom_clie," &
        '" raz_soc,dir_clie,nom_cont, fono_clie,nom_vend,nom_fpago " &
        '" tm ,a.nom_alma,ar.nom_area,u.user as usuario,r.dsc_recurso as tip_pedido" &
        Dim cad, sql1 As String
        sql1 =
         " Select ser_ped,nro_ped,fecha,fec_ped,fec_ent,hor_ent,p.cod_clie,p.dir_ent,nom_clie as nom_clie,pd.obs as obsdet," &
         " raz_soc,dir_clie,nom_cont, fono_clie,nom_vend,nom_fpago,nom_art,sum(cant) as cant,precio,cant*precio as monto,p.fec_ins,p.fec_mod, " &
         " p.monto as monto_doc,p.monto_igv,pre_inc_igv,p.obs,nom_uni,tm ,a.nom_alma,ar.nom_area,u.user as usuario,r.dsc_recurso as tip_pedido" &
         " from pedido p inner join Cliente on p.cod_clie=cliente.cod_clie " &
         " inner join pedido_det pd on p.operacion=pd.operacion" &
         " inner join vendedor on p.cod_vend=vendedor.cod_vend " &
         " inner join forma_pago on p.cod_fpago=forma_pago.cod_fpago " &
         " inner join articulo on pd.cod_art=articulo.cod_art inner join unidad on unidad.cod_uni=articulo.cod_uni " &
         " inner Join almacen a on p.cod_alma=a.cod_alma inner join usuario u on u.cuenta=p.cuenta  " &
         " Left Join area ar on p.cod_area=ar.cod_area left join tipo_recurso r on r.cod_recurso=p.cod_pedido " &
        "  Left join tipo_recurso r1 On r1.cod_recurso=p.cod_estado " &
        "  where r.cod_tabla ='tip_pedido' and r1.cod_tabla ='tip_epedido' " &
          IIf(xestado, "and p.cod_pedido='" & tipo_pedido & "'  and p.cod_estado ='" & estado & "'", "") &
          IIf(xDia, " and p.fec_ped>='" & mFecha & "' and p.fec_ped<='" & mfechahasta & "'", "") &
          IIf(xResp, "and p.cuenta='" & cod_resp & "'", "") &
        "  group by ser_ped,nro_ped,fec_ent,articulo.nom_art order by nro_ped,fec_ent,articulo.nom_art"
        cad = sql1
        Dim com As New MySqlCommand(cad, dbConex)
        da.SelectCommand = com
        da.Fill(ds, "pedido")
        Dim rpt As New rptPedido
        Dim pf0, pf, pfTit As New ParameterField
        Dim pdv0, pdv, pdvTit As New ParameterDiscreteValue
        Dim pfs As New ParameterFields
        pf0.Name = "ruta"
        pdv0.Value = pruta
        pf0.CurrentValues.Add(pdv0)
        pfs.Add(pf0)
        pf.Name = "mesAnno"
        pdv.Value = mFecha
        'pdnemp.Value = pNempresa
        pf.CurrentValues.Add(pdv)
        pfs.Add(pf)
        pfTit.Name = "titulo"
        If cliente Then
            pdvTit.Value = "Reg.Pedidos x Cliente: " & StrConv(nom_clie, VbStrConv.ProperCase)
        Else
            If xResp Then
                pdvTit.Value = "Reg.Pedidos x Responsable: " & StrConv(nom_resp, VbStrConv.ProperCase)
            Else
                pdvTit.Value = "Registro de Pedidos: " & StrConv(nom_Estado, VbStrConv.ProperCase)
            End If
        End If
        pfTit.CurrentValues.Add(pdvTit)
        pfs.Add(pfTit)
        rpt.SetDataSource(ds)
        crv.ParameterFieldInfo = pfs
        crv.ReportSource = rpt





    End Sub
    Public Sub cargarRegistroPedidosPendientes(ByVal anno As Integer, ByVal mes As Integer, ByVal fechaPedido As Date,
                                      ByVal xDia As Boolean, ByVal cliente As Boolean,
                                      ByVal xestado As Boolean, ByVal estado As String, ByVal nom_Estado As String,
                                      ByVal cod_clie As String, ByVal nom_clie As String,
                                      ByVal xResp As Boolean, ByVal cod_resp As String, ByVal nom_resp As String)
        Dim da As New MySqlDataAdapter
        Dim ds As New DataSet
        Dim dt As New DataTable("pedido")
        ds.Tables.Add(dt)
        Dim mFecha As String
        If xDia Then
            mFecha = fechaPedido.ToString("yyyy-MM-dd")
        Else
            mFecha = pTituloRep1
        End If

        Dim cad, sql1 As String
        sql1 = " Select ser_ped,nro_ped,fec_ped,fec_ent,hor_ent,p.cod_clie,p.dir_ent,nom_clie as nom_clie," &
         " raz_soc,dir_clie,nom_cont, fono_clie,nom_vend,nom_fpago " &
         " tm ,a.nom_alma,ar.nom_area,u.user as usuario,r.dsc_recurso as tip_pedido" &
         " from pedido p inner join Cliente on p.cod_clie=cliente.cod_clie " &
         " inner join vendedor on p.cod_vend=vendedor.cod_vend " &
         " inner join forma_pago on p.cod_fpago=forma_pago.cod_fpago " &
         " inner Join almacen a on p.cod_alma=a.cod_alma inner join usuario u on u.cuenta=p.cuenta  " &
         " Left Join area ar on p.cod_area=ar.cod_area left join tipo_recurso r on r.cod_recurso=p.cod_pedido " &
        "  Left join tipo_recurso r1 On r1.cod_recurso=p.cod_estado " &
        "  where r.cod_tabla ='tip_pedido' and r1.cod_tabla ='tip_epedido' " &
          IIf(xDia, " and p.fec_ent>='" & mFecha & "' and p.fec_ent<='" & mFecha & "'", "") &
          IIf(xResp, "and p.cuenta='" & cod_resp & "'", "") &
        "  order by fec_ent"

        cad = sql1


        Dim com As New MySqlCommand(cad, dbConex)
        da.SelectCommand = com
        da.Fill(ds, "pedido")
        Dim rpt As New rptPedidosRegistro
        Dim pf0, pf, pfTit As New ParameterField
        Dim pdv0, pdv, pdvTit As New ParameterDiscreteValue
        Dim pfs As New ParameterFields
        pf0.Name = "ruta"
        pdv0.Value = pruta
        pf0.CurrentValues.Add(pdv0)
        pfs.Add(pf0)
        pf.Name = "mesAnno"
        pdv.Value = mFecha
        'pdnemp.Value = pNempresa
        pf.CurrentValues.Add(pdv)
        pfs.Add(pf)
        pfTit.Name = "titulo"
        If cliente Then
            pdvTit.Value = "Reg.Pedidos x Cliente: " & StrConv(nom_clie, VbStrConv.ProperCase)
        Else
            If xResp Then
                pdvTit.Value = "Reg.Pedidos x Responsable: " & StrConv(nom_resp, VbStrConv.ProperCase)
            Else
                pdvTit.Value = "Registro de Pedidos: " & StrConv(nom_Estado, VbStrConv.ProperCase)
            End If
        End If
        pfTit.CurrentValues.Add(pdvTit)
        pfs.Add(pfTit)
        rpt.SetDataSource(ds)
        crv.ParameterFieldInfo = pfs
        crv.ReportSource = rpt
    End Sub


    Public Sub cargarProductosPedidos(ByVal anno As Integer, ByVal mes As Integer, ByVal fechaPedido As Date, ByVal fechaPedidohasta As Date,
                                      ByVal xestado As Boolean, ByVal tipo_pedido As String, ByVal estado As String, ByVal nom_Estado As String,
                                      ByVal xdia As Boolean)
        Dim da As New MySqlDataAdapter
        Dim ds As New DataSet
        Dim dt As New DataTable("pedido")
        Dim com As New MySqlCommand
        Dim mFecha, mfechahasta As String
        If xdia Then
            mFecha = fechaPedido.ToString("yyyy-MM-dd")
            mfechahasta = fechaPedidohasta.ToString("yyyy-MM-dd")
        Else
            mFecha = pTituloRep1
            mfechahasta = pTituloRep1
        End If

        Dim cad, sql1 As String
        sql1 = " Select ser_ped,nro_ped,fec_ped,fec_ent,hor_ent,p.cod_clie,p.dir_ent,nom_clie as nom_clie," &
        " raz_soc,dir_clie,nom_cont, fono_clie,nom_vend,nom_fpago,a.nom_art, " &
        " tm ,m.nom_alma,ar.nom_area,u.user as usuario,r.dsc_recurso as tip_pedido,s.nom_sgrupo" &
        " From pedido p inner Join pedido_det pd on p.operacion=pd.operacion" &
        " inner Join articulo a On pd.cod_art=a.cod_art left join subgrupo s on a.cod_sgrupo=s.cod_sgrupo " &
        " inner join Cliente On p.cod_clie=cliente.cod_clie " &
        " inner join vendedor On p.cod_vend=vendedor.cod_vend " &
        " inner join forma_pago On p.cod_fpago=forma_pago.cod_fpago " &
        " inner Join almacen m On p.cod_alma=m.cod_alma inner join usuario u On u.cuenta=p.cuenta  " &
        " Left Join area ar On p.cod_area=ar.cod_area left join tipo_recurso r On r.cod_recurso=p.cod_pedido " &
        " Left join tipo_recurso r1 On r1.cod_recurso=p.cod_estado " &
        " where r.cod_tabla ='tip_pedido' and r1.cod_tabla ='tip_epedido' " &
         IIf(xestado, "and p.cod_pedido='" & tipo_pedido & "'  and p.cod_estado ='" & estado & "'", "") &
         IIf(xdia, " and p.fec_ped>='" & mFecha & "' and p.fec_ped<='" & mfechahasta & "'", "") &
        " order by nro_ped,nom_art "
        cad = sql1
        com.CommandText = cad
        com.Connection = dbConex
        da.SelectCommand = com
        da.Fill(ds, "pedido")
        Dim rpt As New rptProductosPedidos
        Dim pf0, pf, pftit As New ParameterField
        Dim pfs As New ParameterFields
        Dim pdv0, pdv, pdvTit As New ParameterDiscreteValue
        pf0.Name = "ruta"
        pdv0.Value = pruta
        pf0.CurrentValues.Add(pdv0)
        pfs.Add(pf0)

        pf.Name = "mesAnno"
        pdv.Value = mFecha
        pf.CurrentValues.Add(pdv)
        pfs.Add(pf)

        pftit.Name = "titulo"
        pdvTit.Value = "Reg.Pedidos x Articulo"
        pftit.CurrentValues.Add(pdvTit)
        pfs.Add(pftit)

        rpt.SetDataSource(ds)
        crv.ParameterFieldInfo = pfs
        crv.ReportSource = rpt
    End Sub
    Public Sub cargarRegistroSalidas(ByVal dsSalida As DataSet, ByVal tituloReporte As String, ByVal fechaReporte As String, ByVal periodoReporte As String, ByVal moneda As String, ByVal xProducto As Boolean)
        Dim rpt As New rptSalidas_Pedidos
        Dim rpt_p As New rptSalidasRegistro
        'Dim rpt_p As New rptSalidas_x_producto
        Dim pf0, pf, pf2, pf3, pf4 As New ParameterField
        Dim pdv0, pdv, pdv2, pdv3, pdv4 As New ParameterDiscreteValue
        Dim pfs As New ParameterFields
        pf0.Name = "ruta"
        pdv0.Value = pruta
        pf0.CurrentValues.Add(pdv0)
        pfs.Add(pf0)
        pf.Name = "titulo"
        pdv.Value = tituloReporte
        pf.CurrentValues.Add(pdv)
        pf2.Name = "fechaReporte"
        pdv2.Value = fechaReporte
        pf2.CurrentValues.Add(pdv2)
        pf3.Name = "periodoReporte"
        pdv3.Value = periodoReporte
        pf3.CurrentValues.Add(pdv3)
        pf4.Name = "moneda"
        pdv4.Value = moneda
        pf4.CurrentValues.Add(pdv4)
        pfs.Add(pf)
        pfs.Add(pf2)
        pfs.Add(pf3)
        pfs.Add(pf4)
        If (xProducto) Then
            rpt_p.SetDataSource(dsSalida)
            crv.ParameterFieldInfo = pfs
            crv.ReportSource = rpt_p
        Else
            rpt.SetDataSource(dsSalida)
            crv.ParameterFieldInfo = pfs
            crv.ReportSource = rpt
        End If
    End Sub
    Public Sub cargarRegistroSalidaCliente(ByVal dsSalida As DataSet, ByVal tituloReporte As String, ByVal fechaReporte As String, ByVal periodoReporte As String, ByVal moneda As String, ByVal xProducto As Boolean)
        Dim rpt As New rptsalidas_xcliente
        'Dim rpt_p As New rptSalidas_x_producto
        Dim pf0, pf, pf2, pf3 As New ParameterField
        Dim pdv0, pdv, pdv2, pdv3 As New ParameterDiscreteValue
        Dim pfs As New ParameterFields
        pf0.Name = "ruta"
        pdv0.Value = pruta
        pf0.CurrentValues.Add(pdv0)
        pfs.Add(pf0)
        pf.Name = "titulo"
        pdv.Value = tituloReporte
        pf.CurrentValues.Add(pdv)
        pf2.Name = "fechaReporte"
        pdv2.Value = fechaReporte
        pf2.CurrentValues.Add(pdv2)
        pf3.Name = "periodoReporte"
        pdv3.Value = periodoReporte
        pf3.CurrentValues.Add(pdv3)

        pfs.Add(pf)
        pfs.Add(pf2)
        pfs.Add(pf3)

        rpt.SetDataSource(dsSalida)
        crv.ParameterFieldInfo = pfs
        crv.ReportSource = rpt
    End Sub

    Public Sub cargarDocumentoIngreso(ByVal ds As DataSet)
        Dim rpt As New rptDocumentoIng

        Dim pf0 As New ParameterField
        Dim pdv0 As New ParameterDiscreteValue
        Dim pfs As New ParameterFields
        pf0.Name = "ruta"
        pdv0.Value = pruta
        pf0.CurrentValues.Add(pdv0)
        pfs.Add(pf0)

        rpt.SetDataSource(ds)
        crv.ParameterFieldInfo = pfs
        crv.ReportSource = rpt
        'crv.RefreshReport()
    End Sub

    Public Sub cargarDocumentoIngreso_OC(ByVal ds As DataSet)
        Dim rpt As New rptDocumentoIng

        Dim pf0 As New ParameterField
        Dim pdv0 As New ParameterDiscreteValue
        Dim pfs As New ParameterFields
        pf0.Name = "ruta"
        pdv0.Value = pruta
        pf0.CurrentValues.Add(pdv0)
        pfs.Add(pf0)

        rpt.SetDataSource(ds)
        crv.ParameterFieldInfo = pfs
        crv.ReportSource = rpt
        'crv.RefreshReport()
    End Sub
    Public Sub cargarFactura(ByVal cod_doc As String, ByVal ser_doc As String, ByVal nro_doc As String, ByVal nomformato As String, ByVal vprevia As Boolean)
        Try
            Dim da As New MySqlDataAdapter
            Dim ds As New DataSet
            Dim dt As New DataTable("factura")
            Dim com As New MySqlCommand
            Dim cad, cad1, cad11, cad2, cad3, cad4, cad5, cad6, cad7, cad8, cad9, cad10 As String
            cad1 = "select fec_doc,ser_doc,nro_doc,raz_soc,cliente.cod_clie,salida.monto as monto_doc,salida.tm,"
            cad11 = " case cAux2 when '' or '-' then dir_clie else (select dir_sucursal from cliente_sucursal where cod_clie=cliente.cod_clie and cod_sucursal=cAux2  ) end as dir_clie,"
            cad2 = " salida.monto_igv, salida.pre_inc_igv,nom_art,cant as cantidad,precio,cant*precio as monto,igv,nom_fpago,"
            cad3 = " concat(ser_guia,'-',nro_guia)as nro_guia,salida_det.obs,cAux4"
            cad4 = " from salida inner join salida_det on salida.operacion=salida_det.operacion"
            cad5 = " inner join guia_remision on salida.operacion=guia_remision.operacion"
            cad6 = " left join cliente on salida.cod_clie=cliente.cod_clie"
            cad7 = " inner join articulo on salida_det.cod_art=articulo.cod_art"
            cad8 = " inner join forma_pago on salida.cod_fpago=forma_pago.cod_fpago"
            cad9 = " where salida.cod_doc='" & cod_doc & "'" & "and ser_doc='" & ser_doc & "'" & " and nro_doc='" & nro_doc & "'"
            cad10 = " order by articulo.cod_art"
            cad = cad1 + cad11 + cad2 + cad3 + cad4 + cad5 + cad6 + cad7 + cad8 + cad9 + cad10
            com.CommandText = cad
            com.Connection = dbConex
            da.SelectCommand = com
            da.Fill(ds, "factura")
            'Dim rpt As New rptFactura2
            Dim mirpt As New ReportDocument
            mirpt.Load(nomformato)
            mirpt.SetDataSource(ds)
            If vprevia Then
                crv.ReportSource = mirpt
                crv.RefreshReport()
            Else
                mirpt.PrintToPrinter(1, True, 1, 1)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub cargarGuiaRemision(ByVal nro_ope As Integer, ByVal vprevia As Boolean, ByVal nomformato As String)
        Dim da As New MySqlDataAdapter
        Dim ds As New DataSet
        Dim dt As New DataTable("guia_remision")
        Dim com As New MySqlCommand
        Dim cad, cad1, cad2, cad3, cad4, cad5, cad6, cad7, cad8, cad9, cad10, cad11 As String
        cad1 = "select salida.operacion,fec_doc,ser_guia,nro_guia,raz_soc,cliente.cod_clie,"
        cad11 = " case cod_sucursal when '00' then dir_ent else (select dir_sucursal from cliente_sucursal where cod_clie=cliente.cod_clie and cod_sucursal=g.cod_sucursal  ) end as dir_clie,"
        cad2 = " articulo.cod_art,nom_art,nom_uni,cant,precio,monto as monto_doc,cant*precio as monto,fec_tras,fec_ent,cod_mot,"
        cad3 = " concat(nom_doc,': ',ser_doc,'-',nro_doc)as documento,concat(ch.nom_chof,' / ',ch.lic_chof) as nom_chof,concat(ch.marca_auto,' / ',ch.placa_auto) as marca_auto"
        cad4 = " from salida inner join salida_det on salida.operacion=salida_det.operacion"
        cad5 = " inner join guia_remision g on salida.operacion=g.operacion inner join chofer ch on ch.cod_chof=g.cod_cond"
        cad6 = " left join cliente on salida.cod_clie=cliente.cod_clie"
        cad7 = " inner join articulo on salida_det.cod_art=articulo.cod_art"
        cad8 = " inner join documento_s on salida.cod_doc=documento_s.cod_doc"
        cad9 = " inner join unidad on articulo.cod_uni=unidad.cod_uni"
        cad10 = " where salida.operacion=" & nro_ope & " order by articulo.cod_art"
        cad = cad1 + cad11 + cad2 + cad3 + cad4 + cad5 + cad6 + cad7 + cad8 + cad9 + cad10
        com.CommandText = cad
        com.Connection = dbConex
        da.SelectCommand = com
        da.Fill(ds, "guia_remision")
        'Dim rpt As New rptGuia
        Dim mirpt As New ReportDocument
        mirpt.Load(nomformato)
        Dim pf0 As New ParameterField
        Dim pdv0 As New ParameterDiscreteValue
        Dim pfs As New ParameterFields
        pf0.Name = "DirEmpresa"
        pdv0.Value = pDirEmpresa
        pf0.CurrentValues.Add(pdv0)
        pfs.Add(pf0)
        mirpt.SetDataSource(ds)
        crv.ParameterFieldInfo = pfs
        crv.ReportSource = mirpt
        If Not vprevia Then
            mirpt.SetParameterValue(0, pDirEmpresa)
            mirpt.PrintToPrinter(1, True, 1, 1)
        End If
    End Sub
    Public Sub cargarCuentaCobrar(ByVal xcancelado As Boolean)
        Dim ds As New DataSet
        ds = Cuenta.recuperaCuentaCobrar(periodoActivo(), xcancelado)
        Dim rpt As New rptCuentaCobrar
        Dim pf0, pf As New ParameterField
        Dim pdv0, pdv As New ParameterDiscreteValue
        Dim pfs As New ParameterFields
        crv.RefreshReport()
        pf0.Name = "ruta"
        pdv0.Value = pruta
        pf0.CurrentValues.Add(pdv0)
        pfs.Add(pf0)
        rpt.SetDataSource(ds)
        crv.ParameterFieldInfo = pfs
        crv.ReportSource = rpt
        'crv.RefreshReport()
    End Sub
    Public Sub cargarInventarioInicial(ByVal ds As DataSet, ByVal almacen As String, ByVal fechaReporte As String,
                            ByVal periodoReporte As String, ByVal soloAlmacen As Boolean, ByVal cod_alma As String, ByVal agrupado As Boolean)
        Dim rpt As New rptInventarioInicial
        Dim rpt_grp As New rptInventarioInicial_grp
        Dim pf0, pf, pf2, pf3 As New ParameterField
        Dim pdv0, pdv, pdv2, pdv3 As New ParameterDiscreteValue
        Dim pfs As New ParameterFields
        pf0.Name = "ruta"
        pdv0.Value = pruta
        pf0.CurrentValues.Add(pdv0)
        pfs.Add(pf0)
        pf.Name = "almacen"
        pdv.Value = almacen
        pf.CurrentValues.Add(pdv)
        pf2.Name = "fechaReporte"
        pdv2.Value = fechaReporte
        pf2.CurrentValues.Add(pdv2)
        pf3.Name = "periodo"
        pdv3.Value = periodoReporte
        pf3.CurrentValues.Add(pdv3)
        pfs.Add(pf)
        pfs.Add(pf2)
        pfs.Add(pf3)
        If agrupado Then
            rpt_grp.SetDataSource(ds)
        Else
            rpt.SetDataSource(ds)
        End If
        crv.ParameterFieldInfo = pfs
        If agrupado Then
            crv.ReportSource = rpt_grp
        Else
            crv.ReportSource = rpt
        End If
    End Sub
    Public Sub cargarInventarioDiario(ByVal soloDiferencias As Boolean, ByVal ds As DataSet, ByVal fechaProceso As String)
        Dim rpt As New rptInvDiario
        Dim rpt2 As New rptInvDiarioDifAcumulada
        Dim pf0, pf As New ParameterField
        Dim pdv0, pdv As New ParameterDiscreteValue
        Dim pfs As New ParameterFields
        crv.RefreshReport()
        pf0.Name = "ruta"
        pdv0.Value = pruta
        pf0.CurrentValues.Add(pdv0)
        pfs.Add(pf0)
        pf.Name = "fechaProceso"
        pdv.Value = fechaProceso
        pf.CurrentValues.Add(pdv)
        pfs.Add(pf)
        If soloDiferencias Then
            rpt2.SetDataSource(ds)
            crv.ParameterFieldInfo = pfs
            crv.ReportSource = rpt2
        Else
            rpt.SetDataSource(ds)
            crv.ParameterFieldInfo = pfs
            crv.ReportSource = rpt
        End If
    End Sub
    Public Sub cargarInventarioMensualMovimientos(ByVal ds As DataSet, ByVal fechaReporte As String, ByVal periodoReporte As String, ByVal almacen As String, ByVal numrpt As Integer)
        'Dim rpt1 As New rptInvMensualMovimientos
        Dim rpt1 As New rptInvResumenMensual
        Dim rpt2 As New rptInvMensualMovimientosDif
        Dim pf0, pf, pf2, pf3 As New ParameterField
        Dim pdv0, pdv, pdv2, pdv3 As New ParameterDiscreteValue
        Dim pfs As New ParameterFields
        pf0.Name = "ruta"
        pdv0.Value = pruta
        pf0.CurrentValues.Add(pdv0)
        pfs.Add(pf0)
        pf.Name = "periodo"
        pdv.Value = periodoReporte
        pf.CurrentValues.Add(pdv)
        pf2.Name = "almacen"
        pdv2.Value = almacen
        pf2.CurrentValues.Add(pdv2)
        pf3.Name = "NEmpresa"
        pdv3.Value = pNempresa
        pf3.CurrentValues.Add(pdv3)
        pfs.Add(pf)
        pfs.Add(pf2)
        pfs.Add(pf3)
        If numrpt = 1 Then
            rpt1.SetDataSource(ds)
            crv.ParameterFieldInfo = pfs
            crv.ReportSource = rpt1
        Else
            rpt2.SetDataSource(ds)
            crv.ParameterFieldInfo = pfs
            crv.ReportSource = rpt2
        End If

    End Sub
    Public Sub cargarInventarioMensualValorizado(ByVal ds As DataSet, ByVal fechaReporte As String, ByVal periodoReporte As String, ByVal almacen As String)
        Dim rpt As New rptInvMensualValorizado
        Dim pf0, pf, pf2, pf3 As New ParameterField
        Dim pdv0, pdv, pdv2, pdv3 As New ParameterDiscreteValue
        Dim pfs As New ParameterFields
        pf0.Name = "ruta"
        pdv0.Value = pruta
        pf0.CurrentValues.Add(pdv0)
        pfs.Add(pf0)
        pf.Name = "periodo"
        pdv.Value = periodoReporte
        pf.CurrentValues.Add(pdv)
        pf2.Name = "almacen"
        pdv2.Value = almacen
        pf2.CurrentValues.Add(pdv2)
        pfs.Add(pf)
        pfs.Add(pf2)
        rpt.SetDataSource(ds)
        crv.ParameterFieldInfo = pfs
        crv.ReportSource = rpt
    End Sub
    Public Sub cargarInventarioMensualExistencias(ByVal ds As DataSet, ByVal periodo As String, ByVal xAlmacen As Boolean,
                ByVal cod_alma As String, ByVal fechaProceso As Date, ByVal periodoReporte As String,
                ByVal titulo As String, ByVal esResumen As Boolean)
        Dim rpt As New rptInvExistenciasValorizadas_res
        Dim pf0, pf, pf2, pf3 As New ParameterField
        Dim pdv0, pdv, pdv2, pdv3 As New ParameterDiscreteValue
        Dim pfs As New ParameterFields
        pf0.Name = "ruta"
        pdv0.Value = pruta
        pf0.CurrentValues.Add(pdv0)
        pfs.Add(pf0)
        pf.Name = "periodo"
        pdv.Value = periodoReporte
        pf.CurrentValues.Add(pdv)
        pf2.Name = "titulo"
        pdv2.Value = titulo
        pf2.CurrentValues.Add(pdv2)
        pfs.Add(pf)
        pfs.Add(pf2)
        crv.ParameterFieldInfo = pfs
        rpt.SetDataSource(ds)
        crv.ReportSource = rpt
    End Sub
    Public Sub cargarReporteCrostab(ByVal ds As DataSet, ByVal periodoReporte As String, ByVal titulo As String)
        Dim rpt As New rptCrosstab
        Dim pf0, pf, pf2, pf3 As New ParameterField
        Dim pdv0, pdv, pdv2, pdv3 As New ParameterDiscreteValue
        Dim pfs As New ParameterFields
        pf0.Name = "ruta"
        pdv0.Value = pruta
        pf0.CurrentValues.Add(pdv0)
        pfs.Add(pf0)
        pf.Name = "periodo"
        pdv.Value = periodoReporte
        pf.CurrentValues.Add(pdv)
        pf2.Name = "titulo"
        pdv2.Value = titulo
        pf2.CurrentValues.Add(pdv2)
        pfs.Add(pf)
        pfs.Add(pf2)
        crv.ParameterFieldInfo = pfs
        rpt.SetDataSource(ds)
        crv.ReportSource = rpt
    End Sub
    Public Sub cargarReporteInventario(ByVal ds As DataSet, ByVal periodoReporte As String, ByVal titulo As String)
        Dim rpt As New rptInventario
        Dim pf0, pf, pf2, pf3 As New ParameterField
        Dim pdv0, pdv, pdv2, pdv3 As New ParameterDiscreteValue
        Dim pfs As New ParameterFields
        pf0.Name = "ruta"
        pdv0.Value = pruta
        pf0.CurrentValues.Add(pdv0)
        pfs.Add(pf0)
        pf.Name = "periodo"
        pdv.Value = periodoReporte
        pf.CurrentValues.Add(pdv)
        pf2.Name = "titulo"
        pdv2.Value = titulo
        pf2.CurrentValues.Add(pdv2)
        pfs.Add(pf)
        pfs.Add(pf2)
        crv.ParameterFieldInfo = pfs
        rpt.SetDataSource(ds)
        crv.ReportSource = rpt
    End Sub
    Public Sub cargarInventarioMensualDiferencias(ByVal ds As DataSet, ByVal fechaProceso As Date, ByVal periodoReporte As String, ByVal almacen As String)
        Dim rpt As New rptInvMensualDiferencias
        Dim pf0, pf, pf2, pf3 As New ParameterField
        Dim pdv0, pdv, pdv2, pdv3 As New ParameterDiscreteValue
        Dim pfs As New ParameterFields
        pf0.Name = "ruta"
        pdv0.Value = pruta
        pf0.CurrentValues.Add(pdv0)
        pfs.Add(pf0)
        pf.Name = "periodo"
        pdv.Value = periodoReporte
        pf.CurrentValues.Add(pdv)
        pfs.Add(pf)
        pf2.Name = "almacen"
        pdv2.Value = almacen
        pf2.CurrentValues.Add(pdv2)
        pfs.Add(pf2)
        rpt.SetDataSource(ds)
        crv.ParameterFieldInfo = pfs
        crv.ReportSource = rpt
    End Sub
    Public Sub cargarInventarioFormatos(ByVal ds As DataSet, ByVal almacen As String, ByVal periodo As String)
        Dim rpt As New rptInvFormato
        Dim pf0, pf, pf2 As New ParameterField
        Dim pdv0, pdv, pdv2 As New ParameterDiscreteValue
        Dim pfs As New ParameterFields
        pf0.Name = "ruta"
        pdv0.Value = pruta
        pf0.CurrentValues.Add(pdv0)
        pfs.Add(pf0)
        pf.Name = "almacen"
        pdv.Value = almacen
        pf.CurrentValues.Add(pdv)
        pf2.Name = "periodo"
        pdv2.Value = periodo
        pf2.CurrentValues.Add(pdv2)
        pfs.Add(pf)
        pfs.Add(pf2)
        rpt.SetDataSource(ds)
        crv.ParameterFieldInfo = pfs
        crv.ReportSource = rpt
    End Sub
    Public Sub cargarSaldos(ByVal dsSaldo As DataSet, ByVal almacen As String, ByVal fechaReporte As String, ByVal periodoReporte As String, ByVal preciosConIMP As String, ByVal esValorizado As Boolean, ByVal moneda As String, ByVal tCambio As Decimal)
        Dim rptSV As New rptSaldoValorizado
        Dim rpt As New rptSaldo
        Dim pf0, pf, pf2, pf3, pf4, pf5, pf6 As New ParameterField
        Dim pdv0, pdv, pdv2, pdv3, pdv4, pdv5, pdv6 As New ParameterDiscreteValue
        Dim pfs As New ParameterFields
        pf0.Name = "ruta"
        pdv0.Value = pruta
        pf0.CurrentValues.Add(pdv0)
        pfs.Add(pf0)
        pf.Name = "almacen"
        pdv.Value = almacen
        pf.CurrentValues.Add(pdv)
        pf2.Name = "fechaReporte"
        pdv2.Value = fechaReporte
        pf2.CurrentValues.Add(pdv2)
        pf3.Name = "periodoReporte"
        pdv3.Value = periodoReporte
        pf3.CurrentValues.Add(pdv3)
        pf4.Name = "preciosConIMP"
        pdv4.Value = preciosConIMP
        pf4.CurrentValues.Add(pdv4)
        pf5.Name = "moneda"
        pdv5.Value = moneda
        pf5.CurrentValues.Add(pdv5)
        pf6.Name = "tc"
        pdv6.Value = tCambio
        pf6.CurrentValues.Add(pdv6)
        pfs.Add(pf)
        pfs.Add(pf2)
        pfs.Add(pf3)
        pfs.Add(pf4)
        pfs.Add(pf5)
        pfs.Add(pf6)
        crv.ParameterFieldInfo = pfs
        If esValorizado Then
            rptSV.SetDataSource(dsSaldo)
            crv.ReportSource = rptSV
        Else
            rpt.SetDataSource(dsSaldo)
            crv.ReportSource = rpt
        End If
    End Sub
    Public Sub cargarKardex(ByVal ds As DataSet, ByVal nom_art As String, ByVal nom_alma As String, ByVal fechaReporte As String, ByVal periodoReporte As String, ByVal preciosConIGV As String, ByVal vprevia As Boolean)
        Dim rpt As New rptKardex
        Dim pf0, pf, pf1, pf2, pf3, pf4 As New ParameterField
        Dim pdv0, pdv, pdv1, pdv2, pdv3, pdv4 As New ParameterDiscreteValue
        Dim pfs As New ParameterFields
        pf0.Name = "ruta"
        pdv0.Value = pruta
        pf0.CurrentValues.Add(pdv0)
        pfs.Add(pf0)
        pf.Name = "almacen"
        pdv.Value = nom_alma
        pf.CurrentValues.Add(pdv)
        pf1.Name = "articulo"
        pdv1.Value = nom_art
        pf1.CurrentValues.Add(pdv1)
        pf2.Name = "fechaReporte"
        pdv2.Value = fechaReporte
        pf2.CurrentValues.Add(pdv2)
        pf3.Name = "periodoReporte"
        pdv3.Value = periodoReporte
        pf3.CurrentValues.Add(pdv3)
        pf4.Name = "preciosConIGV"
        pdv4.Value = preciosConIGV
        pf4.CurrentValues.Add(pdv4)
        pfs.Add(pf)
        pfs.Add(pf1)
        pfs.Add(pf2)
        pfs.Add(pf3)
        pfs.Add(pf4)
        rpt.SetDataSource(ds)
        If vprevia Then
            crv.ParameterFieldInfo = pfs
            crv.ReportSource = rpt
            'crv.RefreshReport()
        Else
            rpt.SetParameterValue("ruta", pruta)
            rpt.SetParameterValue("almacen", nom_alma)
            rpt.SetParameterValue("articulo", nom_art)
            rpt.SetParameterValue("fechareporte", fechaReporte)
            rpt.SetParameterValue("periodoreporte", periodoReporte)
            rpt.SetParameterValue("preciosconigv", preciosConIGV)
            rpt.PrintToPrinter(1, True, 1, 1)
        End If



    End Sub
    Public Sub ResumenKardex_SUNAT(ByVal ds As DataSet, ByVal nom_art As String, ByVal nom_alma As String, ByVal fechaReporte As String, ByVal periodoReporte As String, ByVal preciosConIGV As String, ByVal vprevia As Boolean)
        Dim rpt As New rptKardex_resumen
        Dim pf0, pf, pf1, pf2, pf3, pf4, pf5, pf6, pf7 As New ParameterField
        Dim pdv0, pdv, pdv1, pdv2, pdv3, pdv4, pdv5, pdv6, pdv7 As New ParameterDiscreteValue
        Dim pfs As New ParameterFields
        pf0.Name = "ruta"
        pdv0.Value = pruta
        pf0.CurrentValues.Add(pdv0)
        pfs.Add(pf0)
        pf.Name = "almacen"
        pdv.Value = nom_alma
        pf.CurrentValues.Add(pdv)
        pf1.Name = "articulo"
        pdv1.Value = nom_art
        pf1.CurrentValues.Add(pdv1)
        pf2.Name = "fechaReporte"
        pdv2.Value = fechaReporte
        pf2.CurrentValues.Add(pdv2)
        pf3.Name = "periodoReporte"
        pdv3.Value = periodoReporte
        pf3.CurrentValues.Add(pdv3)
        pf4.Name = "preciosConIGV"
        pdv4.Value = preciosConIGV
        pf4.CurrentValues.Add(pdv4)
        pf5.Name = "ruc"
        pdv5.Value = pEmpresa
        pf5.CurrentValues.Add(pdv5)
        pf6.Name = "Nempresa"
        pdv6.Value = pNempresa
        pf6.CurrentValues.Add(pdv6)
        pf7.Name = "Dirempresa"
        pdv7.Value = pDirEmpresa
        pf7.CurrentValues.Add(pdv7)

        pfs.Add(pf)
        pfs.Add(pf1)
        pfs.Add(pf2)
        pfs.Add(pf3)
        pfs.Add(pf4)
        pfs.Add(pf5)
        pfs.Add(pf6)
        pfs.Add(pf7)
        rpt.SetDataSource(ds)
        If vprevia Then
            crv.ParameterFieldInfo = pfs
            crv.ReportSource = rpt
            'crv.RefreshReport()
        Else
            rpt.SetParameterValue("ruta", pruta)
            rpt.SetParameterValue("almacen", nom_alma)
            rpt.SetParameterValue("articulo", nom_art)
            rpt.SetParameterValue("fechareporte", fechaReporte)
            rpt.SetParameterValue("periodoreporte", periodoReporte)
            rpt.SetParameterValue("preciosconigv", preciosConIGV)
            rpt.PrintToPrinter(1, True, 1, 1)
        End If



    End Sub
    Public Sub cargarKardex_SUNAT(ByVal ds As DataSet, ByVal nom_art As String, ByVal nom_alma As String, ByVal fechaReporte As String, ByVal periodoReporte As String, ByVal preciosConIGV As String, ByVal vprevia As Boolean)
        Dim rpt As New rptKardex_sunat
        Dim pf0, pf, pf1, pf2, pf3, pf4, pf5, pf6, pf7 As New ParameterField
        Dim pdv0, pdv, pdv1, pdv2, pdv3, pdv4, pdv5, pdv6, pdv7 As New ParameterDiscreteValue
        Dim pfs As New ParameterFields
        pf0.Name = "ruta"
        pdv0.Value = pruta
        pf0.CurrentValues.Add(pdv0)
        pfs.Add(pf0)
        pf.Name = "almacen"
        pdv.Value = nom_alma
        pf.CurrentValues.Add(pdv)
        pf1.Name = "articulo"
        pdv1.Value = nom_art
        pf1.CurrentValues.Add(pdv1)
        pf2.Name = "fechaReporte"
        pdv2.Value = fechaReporte
        pf2.CurrentValues.Add(pdv2)
        pf3.Name = "periodoReporte"
        pdv3.Value = periodoReporte
        pf3.CurrentValues.Add(pdv3)
        pf4.Name = "preciosConIGV"
        pdv4.Value = preciosConIGV
        pf4.CurrentValues.Add(pdv4)
        pf5.Name = "ruc"
        pdv5.Value = pEmpresa
        pf5.CurrentValues.Add(pdv5)
        pf6.Name = "Nempresa"
        pdv6.Value = pNempresa
        pf6.CurrentValues.Add(pdv6)
        pf7.Name = "Dirempresa"
        pdv7.Value = pDirEmpresa
        pf7.CurrentValues.Add(pdv7)

        pfs.Add(pf)
        pfs.Add(pf1)
        pfs.Add(pf2)
        pfs.Add(pf3)
        pfs.Add(pf4)
        pfs.Add(pf5)
        pfs.Add(pf6)
        pfs.Add(pf7)
        rpt.SetDataSource(ds)
        If vprevia Then
            crv.ParameterFieldInfo = pfs
            crv.ReportSource = rpt
            'crv.RefreshReport()
        Else
            rpt.SetParameterValue("ruta", pruta)
            rpt.SetParameterValue("almacen", nom_alma)
            rpt.SetParameterValue("articulo", nom_art)
            rpt.SetParameterValue("fechareporte", fechaReporte)
            rpt.SetParameterValue("periodoreporte", periodoReporte)
            rpt.SetParameterValue("preciosconigv", preciosConIGV)
            rpt.PrintToPrinter(1, True, 1, 1)
        End If



    End Sub

    Public Sub cargarKardexImp(ByVal ds As DataSet, ByVal nom_art As String, ByVal nom_alma As String, ByVal fechaReporte As String, ByVal periodoReporte As String, ByVal preciosConIGV As String)
        Dim rpt As New rptKardex
        Dim pf0, pf, pf1, pf2, pf3, pf4 As New ParameterField
        Dim pdv0, pdv, pdv1, pdv2, pdv3, pdv4 As New ParameterDiscreteValue
        Dim pfs As New ParameterFields
        pf0.Name = "ruta"
        pdv0.Value = pruta
        pf0.CurrentValues.Add(pdv0)
        pfs.Add(pf0)
        pf.Name = "almacen"
        pdv.Value = nom_alma
        pf.CurrentValues.Add(pdv)
        pf1.Name = "articulo"
        pdv1.Value = nom_art
        pf1.CurrentValues.Add(pdv1)
        pf2.Name = "fechaReporte"
        pdv2.Value = fechaReporte
        pf2.CurrentValues.Add(pdv2)
        pf3.Name = "periodoReporte"
        pdv3.Value = periodoReporte
        pf3.CurrentValues.Add(pdv3)
        pf4.Name = "preciosConIGV"
        pdv4.Value = preciosConIGV
        pf4.CurrentValues.Add(pdv4)
        pfs.Add(pf)
        pfs.Add(pf1)
        pfs.Add(pf2)
        pfs.Add(pf3)
        pfs.Add(pf4)
        rpt.SetDataSource(ds)
        crv.ParameterFieldInfo = pfs
        crv.ReportSource = rpt
    End Sub

    Public Sub cargarNiveles(ByVal ds As DataSet, ByVal fechaReporte As String, ByVal periodo As String, ByVal almacen As String,
                              ByVal preciosConIMP As String, ByVal numrpt As Integer)
        Dim rpt1 As New rptNiveles
        Dim rpt2 As New rptNivelesVenta
        Dim pf0, pf, pf2, pf3, pf4 As New ParameterField
        Dim pdv0, pdv, pdv2, pdv3, pdv4 As New ParameterDiscreteValue
        Dim pfs As New ParameterFields
        pf0.Name = "ruta"
        pdv0.Value = pruta
        pf0.CurrentValues.Add(pdv0)
        pf.Name = "almacen"
        pdv.Value = almacen
        pf.CurrentValues.Add(pdv)
        pf2.Name = "fechaReporte"
        pdv2.Value = fechaReporte
        pf2.CurrentValues.Add(pdv2)
        pf3.Name = "periodoReporte"
        pdv3.Value = periodo
        pf3.CurrentValues.Add(pdv3)
        pf4.Name = "preciosConIMP"
        pdv4.Value = preciosConIMP
        pf4.CurrentValues.Add(pdv4)
        pfs.Add(pf0)
        pfs.Add(pf)
        pfs.Add(pf2)
        pfs.Add(pf3)
        pfs.Add(pf4)


        If numrpt = 1 Then
            rpt1.SetDataSource(ds)
            crv.ParameterFieldInfo = pfs
            crv.ReportSource = rpt1
        Else
            rpt2.SetDataSource(ds)
            crv.ParameterFieldInfo = pfs
            crv.ReportSource = rpt2
        End If
        'rpt.PrintToPrinter(1, False, 1, 1)
        'rpt.Close()
        'crv.PrintReport()
    End Sub
    Public Sub cargarTransferencia(ByVal ds As DataSet, ByVal fechaReporte As String,
                                    ByVal periodoReporte As String, ByVal usuario As String, ByVal chkvalorizado As Boolean)
        Dim rpt As New rptTransferencia
        Dim pf0, pf, pf2, pf3, pf4 As New ParameterField
        Dim pdv0, pdv, pdv2, pdv3, pdv4 As New ParameterDiscreteValue
        Dim pfs As New ParameterFields
        pf0.Name = "ruta"
        pdv0.Value = pruta
        pf0.CurrentValues.Add(pdv0)
        pf.Name = "usuario"
        pdv.Value = usuario
        pf.CurrentValues.Add(pdv)
        pf2.Name = "fechaReporte"
        pdv2.Value = fechaReporte
        pf2.CurrentValues.Add(pdv2)
        pf3.Name = "periodo"
        pdv3.Value = periodoReporte
        pf3.CurrentValues.Add(pdv3)
        pf4.Name = "flgvalorizado"
        pdv4.Value = chkvalorizado
        pf4.CurrentValues.Add(pdv4)


        pfs.Add(pf0)
        pfs.Add(pf)
        pfs.Add(pf2)
        pfs.Add(pf3)
        pfs.Add(pf4)

        rpt.SetDataSource(ds)
        crv.ParameterFieldInfo = pfs
        crv.ReportSource = rpt
    End Sub
    Public Sub cargarDocSalida(ByVal ds As DataSet, ByVal fechaReporte As String,
                                ByVal periodoReporte As String, ByVal usuario As String)
        Dim rpt As New rptNotaSalida
        Dim pf0, pf, pf2, pf3 As New ParameterField
        Dim pdv0, pdv, pdv2, pdv3 As New ParameterDiscreteValue
        Dim pfs As New ParameterFields
        pf0.Name = "ruta"
        pdv0.Value = pruta
        pf0.CurrentValues.Add(pdv0)
        pf.Name = "usuario"
        pdv.Value = usuario
        pf.CurrentValues.Add(pdv)
        pf2.Name = "fechaReporte"
        pdv2.Value = fechaReporte
        pf2.CurrentValues.Add(pdv2)
        pf3.Name = "periodo"
        pdv3.Value = periodoReporte
        pf3.CurrentValues.Add(pdv3)
        pfs.Add(pf0)
        pfs.Add(pf)
        pfs.Add(pf2)
        pfs.Add(pf3)
        rpt.SetDataSource(ds)
        crv.ParameterFieldInfo = pfs
        crv.ReportSource = rpt
    End Sub
    Public Sub cargarTransferencias(ByVal ds As DataSet, ByVal almacen As String, ByVal tituloreporte As String,
                                    ByVal fechaReporte As String, ByVal periodoReporte As String, ByVal numrpt As Integer)
        Dim rpt1 As New rptTransferencias
        Dim rpt2 As New rptTransferenciasxUsuario
        Dim pf0, pf, pf2, pf3, pf4 As New ParameterField
        Dim pdv0, pdv, pdv2, pdv3, pdv4 As New ParameterDiscreteValue
        Dim pfs As New ParameterFields
        pf0.Name = "ruta"
        pdv0.Value = pruta
        pf0.CurrentValues.Add(pdv0)
        pf.Name = "almacen"
        pdv.Value = almacen
        pf.CurrentValues.Add(pdv)
        pf2.Name = "fechaReporte"
        pdv2.Value = fechaReporte
        pf2.CurrentValues.Add(pdv2)
        pf3.Name = "periodo"
        pdv3.Value = periodoReporte
        pf3.CurrentValues.Add(pdv3)

        pf4.Name = "titulo"
        pdv4.Value = tituloreporte
        pf4.CurrentValues.Add(pdv4)

        pfs.Add(pf0)
        pfs.Add(pf)
        pfs.Add(pf2)
        pfs.Add(pf3)
        pfs.Add(pf4)

        If numrpt = 1 Then
            rpt1.SetDataSource(ds)
            crv.ParameterFieldInfo = pfs
            crv.ReportSource = rpt1
        Else
            rpt2.SetDataSource(ds)
            crv.ParameterFieldInfo = pfs
            crv.ReportSource = rpt2
        End If

    End Sub
    Public Sub cargarMermas(ByVal ds As DataSet, ByVal almacen As String, ByVal fechaReporte As String, ByVal periodoReporte As String, ByVal xR As Boolean)
        Dim rpt As New rptMermas
        Dim rptagp As New rptMermasResum
        Dim pf0, pf, pf2, pf3 As New ParameterField
        Dim pdv0, pdv, pdv2, pdv3 As New ParameterDiscreteValue
        Dim pfs As New ParameterFields
        pf0.Name = "ruta"
        pdv0.Value = pruta
        pf0.CurrentValues.Add(pdv0)
        pf.Name = "almacen"
        pdv.Value = almacen
        pf.CurrentValues.Add(pdv)
        pf2.Name = "fechaReporte"
        pdv2.Value = fechaReporte
        pf2.CurrentValues.Add(pdv2)
        pf3.Name = "periodoReporte"
        pdv3.Value = periodoReporte
        pf3.CurrentValues.Add(pdv3)
        pfs.Add(pf0)
        pfs.Add(pf)
        pfs.Add(pf2)
        pfs.Add(pf3)
        If xR Then
            rptagp.SetDataSource(ds)
            crv.ParameterFieldInfo = pfs
            crv.ReportSource = rptagp
        Else
            rpt.SetDataSource(ds)
            crv.ParameterFieldInfo = pfs
            crv.ReportSource = rpt
        End If
    End Sub
    Public Sub cargarProducciones(ByVal ds As DataSet, ByVal periodoReporte As String)
        Dim rpt As New rptProducciones
        Dim pf0, pf, pf2, pf3 As New ParameterField
        Dim pdv0, pdv, pdv2, pdv3 As New ParameterDiscreteValue
        Dim pfs As New ParameterFields
        pf0.Name = "ruta"
        pdv0.Value = pruta
        pf0.CurrentValues.Add(pdv0)
        pf.Name = "tipoReporte"
        pdv.Value = periodoReporte
        pf.CurrentValues.Add(pdv)
        pfs.Add(pf0)
        pfs.Add(pf)
        rpt.SetDataSource(ds)
        crv.ParameterFieldInfo = pfs
        crv.ReportSource = rpt
    End Sub
    Public Sub cargarRecetasPorcentaje(ByVal ds As DataSet)
        Dim rpt As New rptPorcentajeRecetas
        'Dim pf, pf2, pf3 As New ParameterField
        'Dim pdv, pdv2, pdv3 As New ParameterDiscreteValue
        'Dim pfs As New ParameterFields
        'pf.Name = "tipoReporte"
        'pdv.Value = periodoReporte
        'pf.CurrentValues.Add(pdv)
        'pfs.Add(pf)
        rpt.SetDataSource(ds)
        'crv.ParameterFieldInfo = pfs
        crv.ReportSource = rpt
    End Sub
    Public Sub cargarComisiones(ByVal anno As Integer, ByVal mes As Integer, ByVal xVendedor As Boolean, ByVal cod_vend As String, ByVal fechaComision As String)
        Dim da As New MySqlDataAdapter
        Dim ds As New DataSet
        Dim dt As New DataTable("comision")
        ds.Tables.Add(dt)
        Dim cad, cad1, cad2, cad3, cad4, cad5, cad6, cad7, cad8 As String
        cad1 = "select salida.cod_vend,nom_vend,fec_doc,concat(abr,ser_doc,'-',nro_doc)as doc,"
        cad2 = " salida.monto as monto_doc,pre_inc_igv,fec_pago,monto_pago,sum(cant*comi_v) as monto_comi"
        cad3 = " from salida inner join vendedor on salida.cod_vend=vendedor.cod_vend"
        cad4 = " inner join documento_s on salida.cod_doc=documento_s.cod_doc"
        cad5 = " inner join salida_det on salida.operacion=salida_det.operacion"
        cad6 = " where cancelado= 1 and anul=0 and year(fec_pago)=" & anno & " and month(fec_pago)=" & mes
        cad7 = " and salida.cod_vend='" & cod_vend & "'"
        cad8 = " group by salida.operacion"
        If xVendedor Then
            cad = cad1 + cad2 + cad3 + cad4 + cad5 + cad6 + cad7 + cad8
        Else
            cad = cad1 + cad2 + cad3 + cad4 + cad5 + cad6 + cad8
        End If
        Dim com As New MySqlCommand(cad, dbConex)
        da.SelectCommand = com
        da.Fill(ds, "comision")
        Dim rpt As New rptComisiones
        'Dim oRpt As New ReportDocument
        Dim pf0, pf As New ParameterField
        Dim pfs As New ParameterFields
        Dim pdv0, pdv As New ParameterDiscreteValue
        pf0.Name = "ruta"
        pdv0.Value = pruta
        pf0.CurrentValues.Add(pdv0)
        pf.Name = "mesAnno"
        pdv.Value = fechaComision
        pf.CurrentValues.Add(pdv)
        pfs.Add(pf0)
        pfs.Add(pf)
        rpt.SetDataSource(ds)
        crv.ParameterFieldInfo = pfs
        crv.ReportSource = rpt
    End Sub
    Public Sub cargarRegistroIngresos(ByVal dsIngreso As DataSet, ByVal tituloReporte As String, ByVal fechaReporte As String,
                ByVal periodoReporte As String, ByVal moneda As String, ByVal preciosConImp As String, ByVal repAgrupado As Boolean)
        Dim rpt As New rptIngresos
        Dim rptgp As New rptIngresos_gp
        Dim pf0, pf, pf2, pf3, pf4, pf5 As New ParameterField
        Dim pdv0, pdv, pdv1, pdv2, pdv3, pdv4, pdv5 As New ParameterDiscreteValue
        Dim pfs As New ParameterFields
        pf0.Name = "ruta"
        pdv0.Value = pruta
        pf0.CurrentValues.Add(pdv0)
        pf.Name = "titulo"
        pdv.Value = tituloReporte
        pf.CurrentValues.Add(pdv)
        pf2.Name = "fechaReporte"
        pdv2.Value = fechaReporte
        pf2.CurrentValues.Add(pdv2)
        pf3.Name = "periodoReporte"
        pdv3.Value = periodoReporte
        pf3.CurrentValues.Add(pdv3)
        pf4.Name = "moneda"
        pdv4.Value = moneda
        pf4.CurrentValues.Add(pdv4)
        pf5.Name = "preciosConImp"
        pdv5.Value = preciosConImp
        pf5.CurrentValues.Add(pdv5)
        pfs.Add(pf0)
        pfs.Add(pf)
        pfs.Add(pf2)
        pfs.Add(pf3)
        pfs.Add(pf4)
        pfs.Add(pf5)
        If repAgrupado Then
            rptgp.SetDataSource(dsIngreso)
            crv.ParameterFieldInfo = pfs
            crv.ReportSource = rptgp
        Else
            rpt.SetDataSource(dsIngreso)
            crv.ParameterFieldInfo = pfs
            crv.ReportSource = rpt
        End If
    End Sub
    Public Sub cargarRegistroIngresosProducto(ByVal dsIngreso As DataSet, ByVal tituloReporte As String, ByVal fechaReporte As String, ByVal periodoReporte As String, ByVal moneda As String, ByVal preciosConImp As String, ByVal xArticulo As Boolean, ByVal repAgrupado As Boolean)
        Dim rpt As New rptIngresos_xProd_det
        Dim rptgp As New rptIngresos_xProd_gp
        Dim pf0, pf, pf2, pf3, pf4, pf5 As New ParameterField
        Dim pdv0, pdv, pdv1, pdv2, pdv3, pdv4, pdv5 As New ParameterDiscreteValue
        Dim pfs As New ParameterFields
        pf0.Name = "ruta"
        pdv0.Value = pruta
        pf0.CurrentValues.Add(pdv0)
        pf.Name = "titulo"
        pdv.Value = tituloReporte
        pf.CurrentValues.Add(pdv)
        pf2.Name = "fechaReporte"
        pdv2.Value = fechaReporte
        pf2.CurrentValues.Add(pdv2)
        pf3.Name = "periodoReporte"
        pdv3.Value = periodoReporte
        pf3.CurrentValues.Add(pdv3)
        pf4.Name = "preciosConImp"
        pdv4.Value = preciosConImp
        pf4.CurrentValues.Add(pdv4)
        pf5.Name = "moneda"
        pdv5.Value = moneda
        pf5.CurrentValues.Add(pdv5)
        pfs.Add(pf0)
        pfs.Add(pf)
        pfs.Add(pf2)
        pfs.Add(pf3)
        pfs.Add(pf4)
        pfs.Add(pf5)
        If repAgrupado Then
            rptgp.SetDataSource(dsIngreso)
            crv.ParameterFieldInfo = pfs
            crv.ReportSource = rptgp
        Else
            rpt.SetDataSource(dsIngreso)
            crv.ParameterFieldInfo = pfs
            crv.ReportSource = rpt
        End If
    End Sub
    Public Sub cargarRegistroIngresosProveedor(ByVal ds As DataSet, ByVal tituloReporte As String,
             ByVal fechaReporte As String, ByVal periodoReporte As String, ByVal moneda As String,
             ByVal preciosConImp As String, ByVal xArticulo As Boolean, ByVal detallado As Boolean,
             ByVal repAgrupado As Boolean)
        Dim rpt As New rptIngresos_xProv
        Dim rptDet As New rptIngresos_xProv_det
        Dim rptDetgp As New rptIngresos_xProv_detgp
        Dim pf0, pf, pf2, pf3, pf4, pf5 As New ParameterField
        Dim pdv0, pdv, pdv1, pdv2, pdv3, pdv4, pdv5 As New ParameterDiscreteValue
        Dim pfs As New ParameterFields
        pf0.Name = "ruta"
        pdv0.Value = pruta
        pf0.CurrentValues.Add(pdv0)
        pf.Name = "titulo"
        pdv.Value = tituloReporte
        pf.CurrentValues.Add(pdv)
        pf2.Name = "fechaReporte"
        pdv2.Value = fechaReporte
        pf2.CurrentValues.Add(pdv2)
        pf3.Name = "periodoReporte"
        pdv3.Value = periodoReporte
        pf3.CurrentValues.Add(pdv3)
        pf4.Name = "preciosConImp"
        pdv4.Value = preciosConImp
        pf4.CurrentValues.Add(pdv4)
        pf5.Name = "moneda"
        pdv5.Value = moneda
        pf5.CurrentValues.Add(pdv5)
        pfs.Add(pf0)
        pfs.Add(pf)
        pfs.Add(pf2)
        pfs.Add(pf3)
        pfs.Add(pf4)
        pfs.Add(pf5)
        If detallado Then
            If repAgrupado Then
                rptDetgp.SetDataSource(ds)
                crv.ParameterFieldInfo = pfs
                crv.ReportSource = rptDetgp
            Else
                rptDet.SetDataSource(ds)
                crv.ParameterFieldInfo = pfs
                crv.ReportSource = rptDet
            End If
        Else
            rpt.SetDataSource(ds)
            crv.ParameterFieldInfo = pfs
            crv.ReportSource = rpt
        End If
    End Sub
    Public Sub cargarProductosIngresados(ByVal fechaProceso As String)
        Dim da As New MySqlDataAdapter
        Dim ds As New DataSet
        Dim dt As New DataTable("productos_ingresados")
        Dim com As New MySqlCommand
        Dim cad, cad1, cad2, cad3, cad4, cad5 As String
        cad1 = "select ingreso_det.cod_art,nom_art,nom_uni,sum(cant)as cantidad"
        cad2 = " from ingreso inner join ingreso_det on ingreso.operacion=ingreso_det.operacion"
        cad3 = " inner join articulo on ingreso_det.cod_art=articulo.cod_art"
        cad4 = " inner join unidad on articulo.cod_uni=unidad.cod_uni"
        cad5 = " group by cod_art order by nom_art"
        cad = cad1 + cad2 + cad3 + cad4 + cad5
        com.CommandText = cad
        com.Connection = dbConex
        da.SelectCommand = com
        da.Fill(ds, "productos_ingresados")
        Dim rpt As New rptProductosIngresados
        Dim pf0, pf As New ParameterField
        Dim pdv0, pdv As New ParameterDiscreteValue
        Dim pfs As New ParameterFields
        pf0.Name = "ruta"
        pdv0.Value = pruta
        pf0.CurrentValues.Add(pdv0)
        pf.Name = "mesAnno"
        pdv.Value = fechaProceso
        pf.CurrentValues.Add(pdv)
        pfs.Add(pf0)
        pfs.Add(pf)
        rpt.SetDataSource(ds)
        crv.ParameterFieldInfo = pfs
        crv.ReportSource = rpt
    End Sub
    Public Sub cargarRegistroSalidaProducto(ByVal ds As DataSet, ByVal tituloReporte As String, ByVal fechaReporte As String,
                    ByVal periodoReporte As String, ByVal moneda As String, ByVal preciosConImp As String,
                    ByVal xArticulo As Boolean, ByVal repAgrupado As Boolean)
        Dim rpt As New rptSalidas_xProd
        Dim rptgp As New rptIngresos_xProd_gp
        Dim pf0, pf, pf2, pf3, pf4, pf5 As New ParameterField
        Dim pdv0, pdv, pdv1, pdv2, pdv3, pdv4, pdv5 As New ParameterDiscreteValue
        Dim pfs As New ParameterFields
        pf0.Name = "ruta"
        pdv0.Value = pruta
        pf0.CurrentValues.Add(pdv0)
        pf.Name = "titulo"
        pdv.Value = tituloReporte
        pf.CurrentValues.Add(pdv)
        pf2.Name = "fechaReporte"
        pdv2.Value = fechaReporte
        pf2.CurrentValues.Add(pdv2)
        pf3.Name = "periodoReporte"
        pdv3.Value = periodoReporte
        pf3.CurrentValues.Add(pdv3)
        pf4.Name = "preciosConImp"
        pdv4.Value = preciosConImp
        pf4.CurrentValues.Add(pdv4)
        pf5.Name = "moneda"
        pdv5.Value = moneda
        pf5.CurrentValues.Add(pdv5)
        pfs.Add(pf0)
        pfs.Add(pf)
        pfs.Add(pf2)
        pfs.Add(pf3)
        pfs.Add(pf4)
        pfs.Add(pf5)
        If repAgrupado Then
            rptgp.SetDataSource(ds)
            crv.ParameterFieldInfo = pfs
            crv.ReportSource = rptgp
        Else
            rpt.SetDataSource(ds)
            crv.ParameterFieldInfo = pfs
            crv.ReportSource = rpt
        End If
    End Sub
    Public Sub cargarPlanCuentas(ByVal ds As DataSet, ByVal periodoReporte As String)
        Dim rpt As New rptPlanCuentas
        Dim pf0, pf As New ParameterField
        Dim pdv0, pdv As New ParameterDiscreteValue
        Dim pfs As New ParameterFields
        pf0.Name = "ruta"
        pdv0.Value = pruta
        pf0.CurrentValues.Add(pdv0)
        pf.Name = "periodoReporte"
        pdv.Value = periodoReporte
        pf.CurrentValues.Add(pdv)
        pfs.Add(pf0)
        pfs.Add(pf)
        rpt.SetDataSource(ds)
        crv.ParameterFieldInfo = pfs
        crv.ReportSource = rpt
    End Sub
    Public Sub cargarMaximos(ByVal ds As DataSet, ByVal cod_alma As String, ByVal almacen As String)
        Dim mAlmacen As New Almacen
        Dim rpt As New rptMaximos
        Dim pf0, pf As New ParameterField
        Dim pdv0, pdv As New ParameterDiscreteValue
        Dim pfs As New ParameterFields
        pf0.Name = "ruta"
        pdv0.Value = pruta
        pf0.CurrentValues.Add(pdv0)
        pf.Name = "almacen"
        pdv.Value = almacen
        pf.CurrentValues.Add(pdv)
        pfs.Add(pf0)
        pfs.Add(pf)
        rpt.SetDataSource(ds)
        crv.ParameterFieldInfo = pfs
        crv.ReportSource = rpt
    End Sub
    Public Sub cargarReceta(ByVal ds As DataSet, ByVal receta As String, ByVal almacen As String, ByVal unidad As String, ByVal vprevia As Boolean)
        Dim rpt As New rptReceta
        Dim pf0, pf, pf1, pf2 As New ParameterField
        Dim pdv0, pdv, pdv1, pdv2 As New ParameterDiscreteValue
        Dim pfs As New ParameterFields
        pf0.Name = "ruta"
        pdv0.Value = pruta
        pf0.CurrentValues.Add(pdv0)
        pf.Name = "titulo"
        pdv.Value = receta
        pf.CurrentValues.Add(pdv)
        pf1.Name = "Almacen"
        pdv1.Value = almacen
        pf1.CurrentValues.Add(pdv1)
        pf2.Name = "Unidad"
        pdv2.Value = unidad
        pf2.CurrentValues.Add(pdv2)
        pfs.Add(pf0)
        pfs.Add(pf)
        pfs.Add(pf1)
        pfs.Add(pf2)
        rpt.SetDataSource(ds)

        If vprevia Then
            crv.ParameterFieldInfo = pfs
            crv.ReportSource = rpt

        Else
            rpt.SetParameterValue("ruta", pruta)
            rpt.SetParameterValue("titulo", receta)
            rpt.SetParameterValue("Almacen", almacen)
            rpt.SetParameterValue("Unidad", unidad)
            rpt.PrintToPrinter(1, True, 1, 1)
        End If
        'exportar a PDF
        'rpt.SetParameterValue("ruta", pruta)
        'rpt.SetParameterValue("titulo", receta)
        'rpt.SetParameterValue("Almacen", almacen)
        'rpt.SetParameterValue("Unidad", unidad)
        'ExportToPDF(rpt, "miReporte.pdf")

    End Sub

    Public Function ExportToPDF(ByVal rpt As ReportDocument, ByVal NombreArchivo As String) As String
        Dim vFileName As String
        Dim diskOpts As New DiskFileDestinationOptions
        Try
            With rpt.ExportOptions
                .ExportDestinationType = ExportDestinationType.DiskFile
                .ExportFormatType = ExportFormatType.PortableDocFormat
            End With

            vFileName = “c:\” & NombreArchivo
            If File.Exists(vFileName) Then File.Delete(vFileName)
            diskOpts.DiskFileName = vFileName
            rpt.ExportOptions.DestinationOptions = diskOpts
            rpt.Export()
        Catch ex As Exception
            Throw ex
        End Try

        Return vFileName
    End Function

    Public Sub cargarRecetas(ByVal ds As DataSet, ByVal insumo As String)
        Dim rpt As New rptRecetas_insumo
        Dim pf0, pf As New ParameterField
        Dim pdv0, pdv As New ParameterDiscreteValue
        Dim pfs As New ParameterFields
        pf0.Name = "ruta"
        pdv0.Value = pruta
        pf0.CurrentValues.Add(pdv0)
        pf.Name = "titulo"
        pdv.Value = insumo
        pf.CurrentValues.Add(pdv)
        pfs.Add(pf0)
        pfs.Add(pf)
        rpt.SetDataSource(ds)
        crv.ParameterFieldInfo = pfs
        crv.ReportSource = rpt
    End Sub
    Public Sub cargarRecetasListado(ByVal ds As DataSet, ByVal titulo As String, ByVal sgrupo As String)
        Dim rpt As New rptRecetas_listado
        Dim pf0, pf, pf1 As New ParameterField
        Dim pdv0, pdv, pdv1 As New ParameterDiscreteValue
        Dim pfs As New ParameterFields
        pf0.Name = "ruta"
        pdv0.Value = pruta
        pf0.CurrentValues.Add(pdv0)
        pf.Name = "titulo"
        pdv.Value = titulo
        pf1.Name = "Grupo"
        pdv1.Value = sgrupo
        pf.CurrentValues.Add(pdv)
        pf1.CurrentValues.Add(pdv1)
        pfs.Add(pf0)
        pfs.Add(pf)
        pfs.Add(pf1)
        rpt.SetDataSource(ds)
        crv.ParameterFieldInfo = pfs
        crv.ReportSource = rpt
    End Sub
    Public Sub EP_fluctuacionPrecios(ByVal dsPrecio As DataSet, ByVal fechaReporte As String, ByVal periodo As String)
        Dim rpt As New rptEP_fluctuacion
        Dim pf0, pf, pf2 As New ParameterField
        Dim pdv0, pdv, pdv2 As New ParameterDiscreteValue
        Dim pfs As New ParameterFields
        pf0.Name = "ruta"
        pdv0.Value = pruta
        pf0.CurrentValues.Add(pdv0)
        pf.Name = "fechaReporte"
        pdv.Value = fechaReporte
        pf.CurrentValues.Add(pdv)
        pf2.Name = "periodo"
        pdv2.Value = periodo
        pf2.CurrentValues.Add(pdv2)
        pfs.Add(pf0)
        pfs.Add(pf)
        pfs.Add(pf2)
        rpt.SetDataSource(dsPrecio)
        crv.ParameterFieldInfo = pfs
        crv.ReportSource = rpt
    End Sub
    Public Sub EP_margenesOperacion(ByVal dsMargenes As DataSet, ByVal fechaReporte As String, ByVal periodo As String)
        Dim rpt As New rptEP_margenesOperacion
        Dim pf0, pf, pf2 As New ParameterField
        Dim pdv0, pdv, pdv2 As New ParameterDiscreteValue
        Dim pfs As New ParameterFields
        pf0.Name = "ruta"
        pdv0.Value = pruta
        pf0.CurrentValues.Add(pdv0)
        pf.Name = "fechaReporte"
        pdv.Value = fechaReporte
        pf.CurrentValues.Add(pdv)
        pf2.Name = "periodo"
        pdv2.Value = periodo
        pf2.CurrentValues.Add(pdv2)
        pfs.Add(pf0)
        pfs.Add(pf)
        pfs.Add(pf2)
        rpt.SetDataSource(dsMargenes)
        crv.ParameterFieldInfo = pfs
        crv.ReportSource = rpt
    End Sub
    Public Sub cargarCatalogo_codExt(ByVal ds As DataSet, ByVal titulo As String)
        Dim rpt As New rptCatalogo_codExt
        Dim pf0, pf As New ParameterField
        Dim pdv0, pdv As New ParameterDiscreteValue
        Dim pfs As New ParameterFields
        pf0.Name = "ruta"
        pdv0.Value = pruta
        pf0.CurrentValues.Add(pdv0)
        pf.Name = "titulo"
        pdv.Value = titulo
        pf.CurrentValues.Add(pdv)
        pfs.Add(pf0)
        pfs.Add(pf)
        rpt.SetDataSource(ds)
        crv.ParameterFieldInfo = pfs
        crv.ReportSource = rpt
    End Sub

    Private Sub crv_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles crv.Load

    End Sub

    Private Sub rptForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
