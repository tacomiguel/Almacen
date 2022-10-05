Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Math
Imports libreriaClases

Public Class u_Cierreinventario

    Private dsAlmacen As New DataSet
    Private dsAlma As New DataSet
    Private dsArea As New DataSet
    Private dsGrupo As New DataSet
    Private dsInventario As New DataSet
    Private dsInventarioR As New DataSet
    Private dsReportes As New DataSet
    Private dsInventarioI As New DataSet
    Private dsArticulos As New DataSet
    Private dsCatalogo As New DataSet
    Private dsAlmacenF As New DataSet
    Private dsAreaF As New DataSet
    '
    Private cPrecioCI As String = general.str_PrecioCompraCI
    Private chPrecioCI As String = general.str_hPrecioCompraCI
    Private cPrecioSI As String = general.str_PrecioCompraSI
    Private chPrecioSI As String = general.str_hPrecioCompraSI
    Private cPrecioCIs As String = general.str_PrecioCompraCIs
    Private chPrecioCIs As String = general.str_hPrecioCompraCIs
    Private cPrecioSIs As String = general.str_PrecioCompraSIs
    Private chPrecioSIs As String = general.str_hPrecioCompraSIs
    'para validar el separador decimal
    Private sepDecimal As Char
    Private estaCargando As Boolean = True
    Private periodoInventario As String, nOperacion As Integer = -1
    Private fechaInventario As Date
    Private saldoProvisional As Boolean
    'para capturar el numero de almacenes
    Private mAlmacen(40) As String
    Private nroAlmacenes As Integer

    Private Sub cmdCerrarInventario_Click(sender As Object, e As EventArgs) Handles cmdCerrarInventario.Click
        Dim rpta As Integer
        'If chkProvisional.Checked = True Then
        rpta = MessageBox.Show("Se va Proceder a Cerrar el Periodo... ¿Esta Seguro?", "SGA", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If rpta = 6 Then
            Me.Refresh()
            saldoProvisional = True
            cerrarPeriodo()
        End If
    End Sub

    Sub cerrarPeriodo()


        'BackgroundWorker1.RunWorkerAsync()
        barraProgreso.Visible = True
        Dim mInventario As New Inventario
        Dim newOperacionInventario As Integer
        Dim cad, cad1, cad2, cad3 As String, I As Integer = 0
        Dim mfechaI As String = mcFInventario.SelectedDate.Date.ToString("yyyy-MM-dd")
        barraProgreso.Value = 5

        If ChkEliminar_his.Checked Then
            '***ELIMINAMOS LOS DATOS DEL PERIODO ACTUAL***
            'eliminamos los Ingresos
            cad = "delete from h_ingreso where proceso='" & periodoInventario & "'"
            Dim comA As New MySqlCommand(cad, dbConex)
            comA.ExecuteNonQuery()
            comA.CommandTimeout = 300
            barraProgreso.Value = 15

            'eliminamos los Ingresos
            cad = "delete from h_ingreso_det where proceso='" & periodoInventario & "'"
            Dim comB As New MySqlCommand(cad, dbConex)
            comB.CommandTimeout = 800
            comB.ExecuteNonQuery()
            barraProgreso.Value = 16

            'eliminamos los Ingresos
            cad = "delete from h_salida where proceso='" & periodoInventario & "'"
            Dim comC As New MySqlCommand(cad, dbConex)
            comC.CommandTimeout = 300
            comC.ExecuteNonQuery()
            barraProgreso.Value = 17

            'eliminamos los Ingresos
            cad = "delete from h_salida_det where proceso='" & periodoInventario & "'"
            Dim comD As New MySqlCommand(cad, dbConex)
            comD.CommandTimeout = 800
            comD.ExecuteNonQuery()
            barraProgreso.Value = 18

            'eliminamos los Ingresos
            cad = "delete from h_salida_detpago where proceso='" & periodoInventario & "'"
            Dim comD1 As New MySqlCommand(cad, dbConex)
            comD1.CommandTimeout = 300
            comD1.ExecuteNonQuery()
            barraProgreso.Value = 19


            'eliminamos los Ingresos
            cad = "delete from h_factura where proceso='" & periodoInventario & "'"
            Dim comE As New MySqlCommand(cad, dbConex)
            comE.ExecuteNonQuery()
            barraProgreso.Value = 20

            'eliminamos los Ingresos
            cad = "delete from h_factura_det where proceso='" & periodoInventario & "'"
            Dim comF As New MySqlCommand(cad, dbConex)
            comF.ExecuteNonQuery()
            barraProgreso.Value = 25

        End If

        'insertamos al historial los ingresos

        cad1 = "insert into h_ingreso(select DATE_FORMAT(fec_doc, '%Y%m') as proceso, " _
                & "operacion,fecha,cod_doc,nro_orden,ser_doc,nro_doc,ser_guia,nro_guia,fec_doc,"
        cad2 = "cod_prov,cod_fpago,cancelado,monto,monto_igv,pre_inc_igv,monto_pago,nro_dec,anul," _
                & "fec_pago,obs,cod_alma,cod_area,tm,tc,cod_emp,cuenta,0,maquina,usu_mod,fec_mod from ingreso where fec_doc<='" & mfechaI & "')"
        cad = cad1 & cad2
        Dim comIng As New MySqlCommand(cad, dbConex)
        comIng.CommandTimeout = 300
        comIng.ExecuteNonQuery()
        barraProgreso.Value = 6
        'cad = "insert into h_ingreso_det(select " & "'" & periodoInventario _
        cad = "insert into h_ingreso_det(select DATE_FORMAT(fec_doc, '%Y%m') as proceso, " _
                    & " i.operacion,ingreso,cod_art,cant,precio,precio_prom,igv," _
                    & " if(igv>0,1,0) as afecto_igv,saldo,nAux,nAux2,id.usu_ins,id.fec_ins from ingreso_det id inner join" _
                    & " ingreso i on id.operacion=i.operacion where fec_doc<='" & mfechaI & "')"
        Dim comIngD As New MySqlCommand(cad, dbConex)
        comIngD.CommandTimeout = 300
        comIngD.ExecuteNonQuery()
        barraProgreso.Value = 7

        cad1 = "insert into h_salida(select DATE_FORMAT(fec_doc, '%Y%m') as proceso, " _
                & "operacion,ope_ped,fecha,cod_doc,ser_doc,nro_doc,fec_doc,fec_prod,cod_vend,cod_clie,"
        cad2 = "cod_fpago,cancelado,monto,monto_igv,pre_inc_igv,monto_pago,nro_dec,anul,fec_pago,cod_alma,cod_area," _
                & "obs,tm,tc,cod_emp,cuenta,nAux,cAux,cAux2,maquina  from salida  where fec_doc<='" & mfechaI & "')"
        cad = cad1 & cad2
        Dim comSal As New MySqlCommand(cad, dbConex)
        comSal.CommandTimeout = 300
        comSal.ExecuteNonQuery()
        barraProgreso.Value = 8

        'cad = "insert into h_salida_det(select" & "'" & periodoInventario _
        cad = "insert into h_salida_det(select DATE_FORMAT(fec_doc, '%Y%m') as proceso, " _
            & "salida,id.operacion,ingreso,cod_art,cant,precio,igv,comi_v,comi_jv,id.nAux,id.nAux2,id.obs,id.usu_ins,id.fec_ins " _
            & " from salida_det id inner join salida i on id.operacion=i.operacion where fec_doc<='" & mfechaI & "')"
        Dim comSalD As New MySqlCommand(cad, dbConex)
        comSalD.CommandTimeout = 300
        comSalD.ExecuteNonQuery()
        barraProgreso.Value = 9

        'cad = "insert into h_salida_detpago(select" & "'" & periodoInventario _
        cad = "insert into h_salida_detpago(select DATE_FORMAT(fec_doc, '%Y%m') as proceso, " _
            & " id.operacion,id.cod_fpago,id.imp_pagado,id.imp_propina,id.imp_vuelto,id.obs_pago " _
            & " from salida_detpago id inner join salida i on id.operacion=i.operacion where fec_doc<='" & mfechaI & "')"
        Dim comSalp As New MySqlCommand(cad, dbConex)
        comSalp.CommandTimeout = 300
        comSalp.ExecuteNonQuery()
        barraProgreso.Value = 10

        'cad = "insert into h_salida_det(select" & "'" & periodoInventario _
        cad = "insert into h_factura(select DATE_FORMAT(fec_doc, '%Y%m') as proceso, " _
        & "operacion, ope_ped, fecha, cod_doc, ser_doc, nro_doc, fec_doc, fec_prod, cod_vend, cod_clie, cod_fpago, cancelado," _
        & "monto, imp_subtotal, monto_igv, pre_inc_igv, monto_pago, nro_dec, anul, fec_pago, cod_alma, cod_area, obs, tm, tc, cod_emp," _
        & "Cuenta, nAux, cod_doc_ref, ser_doc_ref, nro_doc_ref, nro_ptovta, cod_mesa, contacto, cod_atencion, cierrez, usu_ins," _
        & "fec_ins, usu_mod, fec_mod, imp_descuento, por_descuento, imp_cargo From factura where fec_doc<='" & mfechaI & "')"

        Dim comfac As New MySqlCommand(cad, dbConex)
        comfac.CommandTimeout = 300
        comfac.ExecuteNonQuery()
        barraProgreso.Value = 11
        'cad = "insert into h_salida_det(select" & "'" & periodoInventario _
        cad = "insert into h_factura_det(select DATE_FORMAT(fec_doc, '%Y%m') as proceso, " _
            & " salida,id.operacion,ingreso,cod_art,cant_ped,cant,precio,id.igv,id.imp_subtotal,id.imp_total,id.imp_igv,id.nAux,id.nAux2,id.obs," _
            & " id.descripcion,id.grupo,id.usu_ins,id.esPendiente,id.fec_ins,id.usu_mod,id.fec_mod,id.imp_descuento,id.por_descuento " _
            & " from factura_det id inner join factura i On id.operacion=i.operacion where fec_doc<='" & mfechaI & "')"
        Dim comfacD As New MySqlCommand(cad, dbConex)
        comfacD.CommandTimeout = 300
        comfacD.ExecuteNonQuery()
        barraProgreso.Value = 12

        '***ELIMINAMOS LOS DATOS DEL PERIODO ACTUAL***
        'eliminamos los Ingresos
        cad = "delete from ingreso where fec_doc<='" & mfechaI & "'"
        Dim comEI As New MySqlCommand(cad, dbConex)
        comEI.ExecuteNonQuery()
        barraProgreso.Value = 13


        'eliminamos las salidas
        cad = "delete from salida where fec_doc<='" & mfechaI & "'"
        Dim comES As New MySqlCommand(cad, dbConex)
        comES.CommandTimeout = 300
        comES.ExecuteNonQuery()
        barraProgreso.Value = 14

        'eliminamos las ventas
        cad = "delete from factura where fec_doc<='" & mfechaI & "'"
        Dim comVen As New MySqlCommand(cad, dbConex)
        comVen.CommandTimeout = 300
        comVen.ExecuteNonQuery()
        barraProgreso.Value = 15



        '/********************************/
        'grabamos los saldos finales del mes en proceso x almacen
        Dim nro As Integer = Int(45 / (nroAlmacenes * 2))
            For I = 0 To nroAlmacenes - 1
                Dim operacion As Integer = mInventario.maxOperacionMensual
                mInventario.insertar_invMensual(operacion, fechaInventario, pDecimales, mAlmacen(I), "0000", pCuentaUser)
                barraProgreso.Value = barraProgreso.Value + nro
                grabaSaldoSistema(mAlmacen(I), operacion)
                barraProgreso.Value = barraProgreso.Value + nro
            Next
            '/********************************/


            'insertamos el inventario inicial en 0
            pFechaActivaMax = pFechaActivaMax.AddDays(1)
            Dim mfechadoc As String = pFechaActivaMax.ToString("yy-MM-dd")
            Dim mfechasys As String = pFechaHoraSystem.ToString("yy-MM-dd HH:mm:ss")
            cad1 = "insert into ingreso(select operacion,'" & mfechasys & "' as fecha,cod_doc,nro_orden,ser_doc,nro_doc,ser_guia,nro_guia,'" & mfechadoc & "' as fec_doc ,"
            cad2 = "cod_prov,cod_fpago,cancelado,monto,monto_igv,pre_inc_igv,monto_pago,nro_dec,anul," _
                    & "fec_pago,obs,cod_alma,cod_area,tm,tc,cod_emp,cuenta,'','','','',maquina  from h_ingreso where proceso='" & periodoInventario & "' and cod_doc='10')"
            cad = cad1 & cad2
            Dim comIngI As New MySqlCommand(cad, dbConex)
            comIngI.CommandTimeout = 300
            comIngI.ExecuteNonQuery()
            barraProgreso.Value = 90
            cad1 = "insert into ingreso_det(select hd.operacion,hd.ingreso,hd.cod_art,0,a.pre_costo,a.pre_prom,hd.igv,0,hd.nAux,hd.nAux2,'','','','',0  from h_ingreso h inner join h_ingreso_det hd on h.operacion=hd.operacion and h.proceso=hd.proceso inner join articulo a on a.cod_Art=hd.cod_art "
            cad2 = "where h.proceso='" & periodoInventario & "' and h.cod_doc='10' )"
            cad = cad1 & cad2
            Dim comIngDI As New MySqlCommand(cad, dbConex)
            comIngDI.CommandTimeout = 300
            comIngDI.ExecuteNonQuery()

            '/********************************/
            'activamos el nuevo periodo de trabajo
            'newPeriodoInventario = Microsoft.VisualBasic.Left(periodoInventario, 4) _
            '            & Microsoft.VisualBasic.Right("00" & Trim(Str(Val(Microsoft.VisualBasic.Right(periodoInventario, 2)) + 1)), 2)
            newOperacionInventario = general.ActOperacion() + 1
            cad1 = "update actual set activo=0"
            cad2 = "update actual set activo=1 where operacion='" & newOperacionInventario & "'"
            cad3 = "update configuracion set periodo_cerrado='" & periodoInventario & "'"
            Dim comPeriodo As New MySqlCommand(cad1, dbConex)
            barraProgreso.Value = 92
            comPeriodo.ExecuteNonQuery()
            Dim comPeriodoNew As New MySqlCommand(cad2, dbConex)
            comPeriodoNew.ExecuteNonQuery()
            barraProgreso.Value = 95
            Dim comPeriodoCerrado As New MySqlCommand(cad3, dbConex)
            comPeriodoCerrado.ExecuteNonQuery()
            barraProgreso.Value = 100
            'actualizamos las variables de entorno
            pFechaActivaMin = general.fechaActivaMin()
            pFechaActivaMax = general.fechaActivaMax()
            barraProgreso.Visible = False

            MessageBox.Show("Proceso Terminado... Se va a Cerrar la Ventana", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Me.Close()
    End Sub

    Private Sub u_Cierreinventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim I As Integer
        'capturamos el separador decimal
        sepDecimal = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        'verificamos si ya existe datos cargados para el periodo actual
        'en funcion a ello determinamos la fecha de proceso para el inventario
        Dim mes, mesA, anno, annoA As Integer
        If Month(pFechaActivaMax) = 1 Then
            mes = 12
            mesA = 0
            anno = Year(pFechaActivaMax) - 1
            annoA = Year(pFechaActivaMax)
        Else
            mes = Month(pFechaActivaMax) - 1
            mesA = Month(pFechaActivaMax) - 1
            anno = Year(pFechaActivaMax)
            annoA = Year(pFechaActivaMax)
        End If
        'Dim mes As Integer = cboMesA.SelectedIndex
        'Dim anno As Integer = CboAnnoA.SelectedIndex
        'If mes = 0 Then
        '    mes = 12
        '    anno = anno - 1
        'End If

        cboMesA.SelectedIndex = mesA
        CboAnnoA.SelectedIndex = annoA - 2010
        Dim mIngreso As New Ingreso
        Dim cmes As String = general.devuelveMes(Val(Microsoft.VisualBasic.Right(periodoInventario, 2)))
        Dim existeDatosPeriodoActivo As Boolean = general.periodoActivo_existeDatos
        If existeDatosPeriodoActivo Then

            cmdCerrarInventario.Text = "Cerrar Periodo: " + general.periodoActivo_mesAnnoLetras
            periodoInventario = general.periodoActivo
            fechaInventario = general.fechaActivaMax
        Else
            periodoInventario = general.periodoCerrado
            fechaInventario = general.fechaInventario(periodoInventario)
            'chkProvisional.Enabled = False
        End If
        'data para los reportes - se mantiene oculto al usuario
        dsReportes = Inventario.dsInventarioMensualReportes
        'almacenes y areas para los inventarios
        dsAlmacenF.Tables.Add("almacen")
        Dim daAlmacenF As New MySqlDataAdapter
        Dim comAlmacenF As New MySqlCommand("select cod_alma,nom_alma from almacen where activo=1" _
                        & " and (es_invMensual) order by nom_alma", dbConex)
        daAlmacenF.SelectCommand = comAlmacenF
        daAlmacenF.Fill(dsAlmacenF, "almacen")



        With cboAlmacenActualizar
            .DataSource = dsAlmacenF.Tables("almacen")
            .DisplayMember = dsAlmacenF.Tables("almacen").Columns("nom_alma").ToString
            .ValueMember = dsAlmacenF.Tables("almacen").Columns("cod_alma").ToString
            If dsAlmacenF.Tables("almacen").Rows.Count > 0 Then
                .SelectedIndex = 0
            End If
        End With

        nroAlmacenes = cboAlmacenActualizar.Items.Count
        If nroAlmacenes > 0 Then
            For I = 0 To nroAlmacenes - 1
                cboAlmacenActualizar.SelectedIndex = I
                mAlmacen(I) = cboAlmacenActualizar.SelectedValue
            Next
            cboAlmacenActualizar.SelectedIndex = 0
            'BackgroundWorker1.RunWorkerAsync()
            estaCargando = False
        End If

        estableceFechaProceso()
        estaCargando = False
        ' ''capturamos el numero de almacenes

    End Sub
    Sub estableceFechaProceso()
        mcFInventario.MinDate = pFechaActivaMin
        mcFInventario.MaxDate = pFechaActivaMax
        mcFInventario.DisplayMonth = pFechaSystem
        mcFInventario.SelectedDate = pFechaActivaMax


    End Sub

    Function periodoSeleccionadoActual()
        Dim periodo As String = Trim(Str(CboAnnoA.SelectedIndex + 2010)) & Microsoft.VisualBasic.Right("00" & Trim(Str(cboMesA.SelectedIndex + 1)), 2)
        Return periodo
    End Function
    Function periodoSeleccionado()
        Dim mes As Integer = cboMesA.SelectedIndex
        Dim anno As Integer = CboAnnoA.SelectedIndex
        If mes = 0 Then
            mes = 12
            anno = anno - 1
        End If
        Dim periodo As String = Trim(Str(anno + 2010)) & Microsoft.VisualBasic.Right("00" & Trim(Str(mes)), 2)
        Return periodo
    End Function
    Private Sub cmdActualizaConteoFisico_Click(sender As Object, e As EventArgs) Handles cmdActualizaConteoFisico.Click
        'dsInventario.Tables("inventario")
        Dim dsInicial As New DataSet
        'Dim periodo = "201202"
        Dim periodo As String = periodoSeleccionadoActual()
        Dim esHistorial As Boolean = IIf(periodo = periodoActivo(), False, True)
        Dim cod_alma As String = cboAlmacenActualizar.SelectedValue
        Dim I, existe As Integer, cCodigo, cCuenta As String, nCant, nCosto As Decimal
        Dim mInventario As New Inventario
        Dim nOperacion, nInventario As Integer
        barraProgreso.Visible = True
        nOperacion = mInventario.devOperacionMensual(periodoSeleccionado, cod_alma, False, "")
        'establecemos en cero 0, el conteo fisico del inventario mensual
        'For I = 0 To dataDetalle.RowCount - 1
        'nInventario = dataDetalle("inventario", I).Value& " and operacion='" & nOperacion & "'"
        Dim comUPD1 As New MySqlCommand("Update inventario_mdet set cant_fis=0 where operacion=" & nOperacion, dbConex)
        comUPD1.ExecuteNonQuery()
        'Next
        ''recuperamos el inventario fisico inicial registrado x almacen, NO por area
        Dim da As New MySqlDataAdapter
        Dim cad, cad1, cad2, cad3, cad4 As String
        cad1 = "select cod_art,sum(cant) as cant,precio,cuenta "
        If esHistorial = True Then
            cad2 = " from h_ingreso as i inner join h_ingreso_det as d on i.operacion=d.operacion and i.proceso=d.proceso"
            cad3 = " where i.cod_doc = '10' and i.proceso= '" & periodo & "'" _
                  & IIf(chkAlmacenActualizar.Checked = True, " and cod_alma='" & cod_alma & "'", "")
        Else
            cad2 = " from ingreso as i inner join ingreso_det as d on i.operacion=d.operacion "
            cad3 = " where i.cod_doc = '10' and cod_alma='" & cod_alma & "'"
        End If
        cad4 = " group by cod_art"
        cad = cad1 + cad2 + cad3 + cad4
        Dim com As New MySqlCommand(cad, dbConex)
        da.SelectCommand = com
        da.Fill(dsInicial, "fisico")
        barraProgreso.Minimum = 0
        barraProgreso.Maximum = 100
        If dsInicial.Tables("fisico").Rows.Count > 0 Then
            barraProgreso.Maximum = dsInicial.Tables("fisico").Rows.Count - 1

            For I = 0 To dsInicial.Tables("fisico").Rows.Count - 1
                cCodigo = dsInicial.Tables("fisico").Rows(I).Item("cod_art").ToString
                nCant = dsInicial.Tables("fisico").Rows(I).Item("cant").ToString
                nCosto = dsInicial.Tables("fisico").Rows(I).Item("precio").ToString
                cCuenta = dsInicial.Tables("fisico").Rows(I).Item("cuenta").ToString
                Dim comBusca As New MySqlCommand("Select count(cod_art) from inventario_mdet where cod_art='" & cCodigo & "' and operacion=" & nOperacion, dbConex)
                existe = comBusca.ExecuteScalar
                If existe Then
                    Dim comUPD As New MySqlCommand("Update inventario_mdet set cant_fis=" & nCant & " where cod_art='" & cCodigo & "' and operacion=" & nOperacion, dbConex)
                    comUPD.ExecuteNonQuery()
                Else
                    nInventario = mInventario.maxInventarioMensual
                    mInventario.insertar_detInvMensual(nOperacion, nInventario, cCodigo, nCant, nCant, nCosto, cCuenta)
                End If
                barraProgreso.Value = I
            Next
        End If
        barraProgreso.Visible = False
        MessageBox.Show("Proceso Finalizado...")
    End Sub

    Sub grabaSaldoSistema(ByVal cod_alma As String, ByVal nroOperacion As Integer)
        Dim mCatalogo As New Catalogo, mInventario As New Inventario
        Dim I As Integer = 0, X As Integer = 0, codigo As String = ""
        dsArticulos = mCatalogo.recuperaSaldos(False, "", True, True, cod_alma, False, "", False, False, "", pDecimales)
        dsInventario.Clear()
        'cargamos articulos del inventario
        Dim cod_art As String, cant_sis, cant_fis, precio As Decimal
        If dsArticulos.Tables("saldo").Rows.Count > 0 Then
            'cargamos saldo final del sistema
            I = 0
            For I = 0 To dsArticulos.Tables("saldo").Rows.Count - 1
                cod_art = dsArticulos.Tables("saldo").Rows(I).Item("cod_art").ToString
                precio = dsArticulos.Tables("saldo").Rows(I).Item("precio").ToString
                cant_sis = dsArticulos.Tables("saldo").Rows(I).Item("saldo").ToString
                If saldoProvisional Then
                    cant_fis = dsArticulos.Tables("saldo").Rows(I).Item("saldo").ToString
                Else
                    cant_fis = 0
                End If
                Dim nInventario As Integer = mInventario.maxInventarioMensual
                mInventario.insertar_detInvMensual(nroOperacion, nInventario, cod_art, cant_sis, cant_fis, precio, pCuentaUser)
            Next
        End If
    End Sub

    Private Sub u_Cierreinventario_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        principal.mu_cierreinv.Enabled = True
    End Sub
End Class
