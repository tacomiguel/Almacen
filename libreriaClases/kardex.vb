Imports libreriaClases
Imports MySql.Data.MySqlClient
Public Class kardex
    Public Shared Function dsKardex() As DataSet
        Dim ds As New DataSet
        ds.Tables.Add(crearTablaKardex())
        Return ds
    End Function
    Private Shared Function crearTablaKardex() As DataTable
        Dim dt As New DataTable("kardex")
        dt.Columns.Add(New DataColumn("fec_doc", GetType(Date)))
        dt.Columns.Add(New DataColumn("clie_Prov", GetType(String)))
        dt.Columns.Add(New DataColumn("documento", GetType(String)))
        dt.Columns.Add(New DataColumn("nroDocumento", GetType(String)))
        dt.Columns.Add(New DataColumn("inicial", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("ingresos", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("salidas", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("saldo", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("precio", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("monto", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("operacion", GetType(Integer)))
        dt.Columns.Add(New DataColumn("igv", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("tm", GetType(String)))
        dt.Columns.Add(New DataColumn("tc", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("pre_costoMax", GetType(Decimal)))
        Return dt
    End Function
    Public Function recuperaKardex(ByVal esHistorial As Boolean, ByVal nroProceso As String, ByVal esMensual As Boolean, _
                                    ByVal fechaInicio As Date, ByVal fechaFinal As Date, ByVal nrodecimales As Integer, _
                                    ByVal xAlmacen As Boolean, ByVal cod_alma As String, ByVal xgrupo As Boolean, ByVal cod_sgrupo As String, ByVal cod_art As String, _
                                    ByVal pre_costoMax As Decimal, ByVal preciosConIGV As Boolean, ByVal monedaSalidas As String, _
                                    ByVal precioCI As String, ByVal hPrecioCI As String, ByVal precioSI As String, ByVal hPrecioSI As String) As DataSet
        Dim clConex As New MySqlConnection
        Dim da As New MySqlDataAdapter
        Dim ds As DataSet = kardex.dsKardex
        clConex = Conexion.obtenerConexion
        Dim mfechaI As String = fechaInicio.ToString("yyyy-MM-dd")
        Dim mfechaF As String = fechaFinal.ToString("yyyy-MM-dd")
        Dim monedaSalida As String = monedaSalidas
        Dim codInv As String = "10", cod_baja As String = "92", nom_baja As String = "Baja de Almacén"
        Dim tmpP As String = IIf(cod_art = "", " where articulo.activo ", " where hd.cod_art='" & cod_art & "' ") _
        & IIf(esHistorial, "and  h.proceso='" & nroProceso & "' and hd.proceso='" & nroProceso & "'", "")
        '  & IIf(esHistorial, "", "")

        Dim tmpF As String = " and fec_doc>='" & mfechaI & "' and fec_doc<='" & mfechaF & "' "
        Dim cad, cad1, cad2, cad3, cad4, cad5, cad5a, cad6, cad7, cad8, cad9, cad10, cad11 As String
        Dim cad12, cad13, cad14, cad15, cad16, cad17, cad18, cad19, cad20 As String
        If Microsoft.VisualBasic.DateAndTime.Day(fechaInicio) > 1 Then
            Dim mIngreso As New Ingreso, mSalida As New Salida
            Dim lingreso, lsalida As Decimal
            lingreso = mIngreso.recuperaTotalIngresosArticulo(esHistorial, nroProceso, _
                        Microsoft.VisualBasic.DateAndTime.DateAdd(DateInterval.Day, -1, fechaInicio), _
                        xAlmacen, cod_alma, False, "", cod_art)
            lsalida = mSalida.recuperaTotalSalidasArticulo(esHistorial, nroProceso, _
                        Microsoft.VisualBasic.DateAndTime.DateAdd(DateInterval.Day, -1, fechaInicio), _
                        xAlmacen, cod_alma, False, "", cod_art)
            cad1 = " Select str_to_date('" & mfechaI & "','%Y/%m/%d') as fec_doc, 'Saldo Inicial' as clie_prov,'' as documento," _
                    & lingreso - lsalida & " as inicial,hd.cod_art,nom_art,nom_sgrupo," & pre_costoMax & " as pre_costoMax,"
        Else
            cad1 = " Select fec_doc,'Inventario Inicial' as clie_prov,concat(abr,ser_doc,'-',nro_doc)as documento," _
                    & "sum(cant) as inicial,hd.cod_art,nom_art,nom_sgrupo," & pre_costoMax & " as pre_costoMax,"
        End If
        cad2 = " 0 as ingresos,0 as salidas,cant as saldo," & IIf(preciosConIGV, precioCI, precioSI) _
                & " as precio,round(cant*" & IIf(preciosConIGV, precioCI, precioSI) & "," & nrodecimales & ")" _
                & " as monto,h.operacion,igv,ingreso,0 as salida,tm,tc," _
                & " precio_prom as preciopro,round(cant*precio_prom ," & nrodecimales & ")" _
                & " as montopro , u.cod_sunat as cod_unisunat,g.cod_sunat as cod_sgruposunat,di.cod_docsunat,di.cod_opesunat " _
                & IIf(cod_art = "", ", nom_cuenta ", "")
        cad3 = IIf(esHistorial, " from h_ingreso as h inner join h_ingreso_det as hd on h.operacion=hd.operacion", _
                                " from ingreso as h inner join ingreso_det as hd on h.operacion=hd.operacion")
        cad4 = " inner join articulo on articulo.cod_art=hd.cod_art inner join documento_i di on h.cod_doc=di.cod_doc" _
                & " inner join unidad u on u.cod_uni=articulo.cod_uni left join subgrupo g on g.cod_sgrupo=articulo.cod_sgrupo " _
                & IIf(cod_art = "", " inner join cuenta on cod_cuenta=cuenta_c ", "")
        cad5 = tmpP & IIf(xAlmacen, " and h.cod_alma='" & cod_alma & "'", "") & " and h.cod_doc='" & codInv & "'" _
            & IIf(xgrupo, " and articulo.cuenta_c='" & cod_sgrupo & "'", "")
        cad5a = " group by hd.cod_art"
        cad6 = " union"
        cad7 = " Select fec_doc,if(di.esIngreso,if(raz_soc='-',h.obs,raz_soc),if(h.cod_doc='90',h.obs,if(raz_soc='-',h.obs,nom_doc))) as clie_prov," _
                & "concat(abr,ser_doc,'-',nro_doc)as documento, 0 as inicial,hd.cod_art,nom_art,nom_sgrupo," & pre_costoMax & " as pre_costoMax,"
        cad8 = " cant as ingresos,0 as salidas,0 as saldo," & IIf(preciosConIGV, precioCI, precioSI) _
                & " as precio,round(cant*" & IIf(preciosConIGV, precioCI, precioSI) & "," & nrodecimales & ")" _
                & " as monto,h.operacion,igv,ingreso,0 as salida,tm,tc," _
                & " precio_prom as preciopro,round(cant*precio_prom ," & nrodecimales & ")" _
                & " as montopro , u.cod_sunat as cod_unisunat,g.cod_sunat as cod_sgruposunat,di.cod_docsunat,di.cod_opesunat" _
                & IIf(cod_art = "", ", nom_cuenta ", "")
        cad9 = IIf(esHistorial, " from h_ingreso as h inner join h_ingreso_det as hd on h.operacion=hd.operacion", _
                        " from ingreso as h inner join ingreso_det as hd on h.operacion=hd.operacion")
        cad10 = " inner join documento_i di on h.cod_doc=di.cod_doc"
        cad11 = " left join proveedor on h.cod_prov=proveedor.cod_prov inner join articulo  on articulo.cod_art=hd.cod_art" _
            & " inner join unidad u on u.cod_uni=articulo.cod_uni left join subgrupo g on g.cod_sgrupo=articulo.cod_sgrupo " _
              & IIf(cod_art = "", " inner join cuenta on cod_cuenta=cuenta_c ", "")
        cad12 = tmpP & IIf(esMensual, "", tmpF) & IIf(xAlmacen, " and h.cod_alma ='" & cod_alma & "'", "") & " and h.cod_doc<>'" & codInv & "'" _
            & IIf(xgrupo, " and articulo.cuenta_c='" & cod_sgrupo & "'", "")
        cad13 = " union"
        cad14 = " Select fec_doc,if(ds.esSalida,if(raz_soc='-',h.obs,raz_soc),if(h.cod_doc='90',concat(nom_alma,'  ',nom_area),if(raz_soc='-',h.obs,nom_doc))) as clie_prov," _
                & "concat(abr,ser_doc,'-',nro_doc)as documento," _
                & "0 as inicial,hd.cod_art,nom_art,nom_sgrupo," & pre_costoMax & " as pre_costoMax,"
        cad15 = " 0 as ingresos,cant as salidas,0 as saldo," & IIf(preciosConIGV, precioCI, precioSI) _
                & " as precio,round(cant*" & IIf(preciosConIGV, precioCI, precioSI) & "," & nrodecimales & ")" _
                & " as monto,h.operacion,igv,ingreso,salida,'S',tc," & IIf(preciosConIGV, precioCI, precioSI) _
                & " as preciopro,round(cant*" & IIf(preciosConIGV, precioCI, precioSI) & "," & nrodecimales & ")" _
                & " as montopro , u.cod_sunat as cod_unisunat,g.cod_sunat as cod_sgruposunat,ds.cod_docsunat,ds.cod_opesunat" _
                & IIf(cod_art = "", ", nom_cuenta ", "")
        cad16 = IIf(esHistorial, " from h_salida as h inner join h_salida_det as hd on h.operacion=hd.operacion", _
                                " from salida as h inner join salida_det as hd on h.operacion=hd.operacion")
        cad17 = " inner join documento_s ds on h.cod_doc=ds.cod_doc " _
                & " left join almacen on h.cAux=almacen.cod_alma left join area on h.cAux2=area.cod_area"
        cad18 = " left join cliente on h.cod_clie=cliente.cod_clie inner join articulo on articulo.cod_art=hd.cod_art" _
            & " inner join unidad u on u.cod_uni=articulo.cod_uni left join subgrupo g on g.cod_sgrupo=articulo.cod_sgrupo " _
               & IIf(cod_art = "", " inner join cuenta on cod_cuenta=cuenta_c ", "")
        cad19 = tmpP & IIf(esMensual, "", tmpF) & IIf(xAlmacen, " and h.cod_alma='" & cod_alma & "'", "") _
            & IIf(xgrupo, " and articulo.cuenta_c='" & cod_sgrupo & "'", "")
        cad20 = " order by 6,1,3 asc,7 desc"
        cad = cad1 + cad2 + cad3 + cad4 + cad5 + cad5a + cad6 + cad7 + cad8 + cad9 + cad10 + cad11 + cad12 + cad13 + cad14 + cad15 + cad16 + cad17 + cad18 + cad19 + cad20
        Dim com As New MySqlCommand(cad, clConex)
        da.SelectCommand = com
        da.Fill(ds, "kardex")

        Dim mFinal As Decimal = 0
        Dim mSaldo As Decimal, yaInicio As Boolean = False
        Dim mInicial As Decimal = 0, mIngresos As Decimal = 0, mSalidas As Decimal = 0
        Dim codigo As String = ""
        Dim n As Integer = 0
        If ds.Tables(0).Rows.Count > 0 Then
            codigo = ds.Tables(0).Rows(n).Item("cod_art")
        End If



        For Each mFila As DataRow In ds.Tables("kardex").Rows


            If codigo <> mFila("cod_art") Then
                mSaldo = 0
                yaInicio = False
                mInicial = 0
                mIngresos = 0
                mSalidas = 0
                codigo = ds.Tables(0).Rows(n).Item("cod_art")
            End If


            If mFila("inicial") > 0 Then
                mSaldo = mSaldo + mFila("inicial")
                mInicial = mFila("inicial")
                mFila("saldo") = mSaldo
                yaInicio = True
            Else
                If mFila("ingresos") > 0 Then
                    If yaInicio Then
                        mSaldo = mSaldo + mFila("ingresos")
                    Else
                        mSaldo = mFila("ingresos")
                        yaInicio = True
                    End If
                    mIngresos = mIngresos + mFila("ingresos")
                    mFila("saldo") = mSaldo
                Else
                    If mFila("salidas") > 0 Then
                        mSaldo = mSaldo - mFila("salidas")
                    End If
                    mSalidas = mSalidas + mFila("salidas")
                    mFila("saldo") = mSaldo
                    yaInicio = True
                End If
            End If

            n = n + 1
            mFinal = mSaldo
        Next
        clConex.Close()
        Return ds
    End Function
End Class
