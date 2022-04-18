Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Math
Imports libreriaClases
Public Class p_ventas
    Private dsDocumento As New DataSet
    Private dtDocumento_s As New DataTable("documento_s")
    Private dsFormaPago As New DataSet
    Private dtForma_pago As New DataTable("forma_pago")
    Private dsMotivo As New DataSet
    Private dtMotivo As New DataTable("motivo_tras")
    Private dsChofer As New DataSet
    Private dtChofer As New DataTable("chofer")
    Private dsEmpresa As New DataSet
    Private dtEmpresa As New DataTable("emp_transporte")
    Private dsSalida As New DataSet
    Private dtDetalle As New DataTable("detalle")
    Private dsArticulo As New DataSet
    Private dtArticulo As New DataTable("articulo")
    Private dsAlmacen As New DataSet
    Private dtAlmacen As New DataTable("almacen")
    Private dsCliente As New DataSet
    Private dtCliente As New DataTable("cliente")
    Private dsDireccion As New DataSet
    Private dtDireecion As New DataTable("direccion")
    Private dsVendedor As New DataSet
    Private dtVendedor As New DataTable("vendedor")
    Private dsTipoCliente As New DataSet
    Private dtTipoCliente As New DataTable
    Private prTC As Decimal = pTC
    'variable que almacena la operacion en proceso
    Private nroOperacion As Integer = 0
    Private estacargando As Boolean = True
    Private nroOperacionPedido As Integer = 0, fcod_clie As String = "", fcod_vend As String = "", cod_alma As String = ""
    Private TipoCliente, Tipofpago As String
    Private peridoactivo As String = general.periodoActivo
    'Variable donde indicamos el tipo de proceso - A=Añadir - E=Edicion
    Private tipoProceso As Char = "A"
    Private numOrden As String



    Private Sub p_ventas_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        principal.mp_ventas.Enabled = True
    End Sub
    Private Sub p_ventas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        estableceFechaProceso()
        modoHabilitado()
        'verificamos si los precios ya tienen el igv
        If pPreciosIncIGV Then
            chkIGV.CheckState = CheckState.Checked
        Else
            chkIGV.CheckState = CheckState.Unchecked
        End If
        lblMensaje.Text = ""
        dtpTraslado.Value = pFechaSystem
        'dataset documento salida
        dsDocumento.Tables.Add(dtDocumento_s)
        Dim daDocumento As New MySqlDataAdapter
        Dim comDoc As New MySqlCommand("select cod_doc,nom_doc from documento_s where activo=1", dbConex)
        daDocumento.SelectCommand = comDoc
        daDocumento.Fill(dsDocumento, "documento_s")
        With cboDocumento
            .DataSource = dsDocumento.Tables("documento_s")
            .DisplayMember = dsDocumento.Tables("documento_s").Columns("nom_doc").ToString
            .ValueMember = dsDocumento.Tables("documento_s").Columns("cod_doc").ToString
            .SelectedIndex = 0
        End With
        'dataset almacen
        dsAlmacen.Tables.Add(dtAlmacen)
        Dim daAlmacen As New MySqlDataAdapter
        Dim comAlmacen As New MySqlCommand("select cod_alma,nom_alma from almacen where activo=1 and esProduccion", dbConex)
        daAlmacen.SelectCommand = comAlmacen
        daAlmacen.Fill(dsAlmacen, "almacen")
        With cboAlmacen
            .DataSource = dsAlmacen.Tables("almacen")
            .DisplayMember = dsAlmacen.Tables("almacen").Columns("nom_alma").ToString
            .ValueMember = dsAlmacen.Tables("almacen").Columns("cod_alma").ToString
            .SelectedIndex = 0
        End With
        'dataset forma de pago
        dsFormaPago.Tables.Add(dtForma_pago)
        Dim daFormaPago As New MySqlDataAdapter
        Dim comFP As New MySqlCommand("select cod_fpago,nom_fpago from forma_pago where activo=1", dbConex)
        daFormaPago.SelectCommand = comFP
        daFormaPago.Fill(dsFormaPago, "forma_pago")
        With cboFormaPago
            .DataSource = dsFormaPago.Tables("forma_pago")
            .DisplayMember = dsFormaPago.Tables("forma_pago").Columns("nom_fpago").ToString
            .ValueMember = dsFormaPago.Tables("forma_pago").Columns("cod_fpago").ToString
            .SelectedIndex = 0
        End With
        'dataset motivo de traslado
        dsMotivo.Tables.Add(dtMotivo)
        Dim daMotivo As New MySqlDataAdapter
        Dim comMotivo As New MySqlCommand("select cod_mot,nom_mot from motivo_tras where activo=1", dbConex)
        daMotivo.SelectCommand = comMotivo
        daMotivo.Fill(dsMotivo, "motivo_tras")
        With cboMotivo
            .DataSource = dsMotivo.Tables("motivo_tras")
            .DisplayMember = dsMotivo.Tables("motivo_tras").Columns("nom_mot").ToString
            .ValueMember = dsMotivo.Tables("motivo_tras").Columns("cod_mot").ToString
            .SelectedIndex = 0
        End With
        'dataset conductor-chofer
        dsChofer.Tables.Add(dtChofer)
        Dim daChofer As New MySqlDataAdapter
        Dim comChofer As New MySqlCommand("select cod_chof,nom_chof from chofer where activo=1", dbConex)
        daChofer.SelectCommand = comChofer
        daChofer.Fill(dsChofer, "chofer")
        With cboConductor
            .DataSource = dsChofer.Tables("chofer")
            .DisplayMember = dsChofer.Tables("chofer").Columns("nom_chof").ToString
            .ValueMember = dsChofer.Tables("chofer").Columns("cod_chof").ToString
            .SelectedIndex = 0
        End With
        'dataset empresa de transporte
        dsEmpresa.Tables.Add(dtEmpresa)
        Dim daEmpresa As New MySqlDataAdapter
        Dim comEmpresa As New MySqlCommand("select cod_etrans,nom_etrans from emp_transporte where activo=1", dbConex)
        daEmpresa.SelectCommand = comEmpresa
        daEmpresa.Fill(dsEmpresa, "emp_transporte")
        With cboEmpTransporte
            .DataSource = dsEmpresa.Tables("emp_transporte")
            .DisplayMember = dsEmpresa.Tables("emp_transporte").Columns("nom_eTrans").ToString
            .ValueMember = dsEmpresa.Tables("emp_transporte").Columns("cod_eTrans").ToString
            .SelectedIndex = 0
        End With
        'dataset vendedor
        dsVendedor.Tables.Add(dtVendedor)
        Dim daVendedor As New MySqlDataAdapter
        Dim comVend As New MySqlCommand("select cod_vend,nom_vend from vendedor where activo=1", dbConex)
        daVendedor.SelectCommand = comVend
        daVendedor.Fill(dsVendedor, "vendedor")
        With cboVendedor
            .DataSource = dsVendedor.Tables("vendedor")
            .DisplayMember = dsVendedor.Tables("vendedor").Columns("nom_vend").ToString
            .ValueMember = dsVendedor.Tables("vendedor").Columns("cod_vend").ToString
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.ListItems
            .SelectedIndex = 0
        End With
        'dataset cliente
        dsCliente.Tables.Add(dtCliente)
        Dim daCliente As New MySqlDataAdapter, c0, c1, c2 As String
        c1 = "Select cod_clie,nom_clie,raz_soc,dir_clie,fono_clie,dir_ent,nom_cont,nom_rep,cod_tipo,cod_fpago "
        c2 = "from cliente where activo=1 order by raz_soc"
        c0 = c1 + c2
        Dim comClie As New MySqlCommand(c0, dbConex)
        daCliente.SelectCommand = comClie
        daCliente.Fill(dsCliente, "cliente")
        With cboCliente
            .DataSource = dsCliente.Tables("cliente")
            .DisplayMember = dsCliente.Tables("cliente").Columns("raz_soc").ToString
            .ValueMember = dsCliente.Tables("cliente").Columns("cod_clie").ToString
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.ListItems
            .SelectedIndex = -1
        End With
        'dataset tipo de cliente
        dsTipoCliente.Tables.Add(dtTipoCliente)
        Dim daTipoCliente As New MySqlDataAdapter
        Dim comTipoCliente As New MySqlCommand("select cod_tipo,nom_tipo from tipo_cliente where activo=1 order by nom_tipo", dbConex)
        daTipoCliente.SelectCommand = comTipoCliente
        daTipoCliente.Fill(dsTipoCliente, "tipo_cliente")
        With cboTipoCliente
            .DataSource = dsTipoCliente.Tables("tipo_cliente")
            .DisplayMember = dsTipoCliente.Tables("tipo_cliente").Columns("nom_tipo").ToString
            .ValueMember = dsTipoCliente.Tables("tipo_cliente").Columns("cod_tipo").ToString
            If dsTipoCliente.Tables("tipo_cliente").Rows.Count > 0 Then
                .SelectedIndex = 0
            Else
                .SelectedIndex = -1
            End If
        End With
        'dataset detalle
        dsSalida = Salida.dsSalida
        dtDetalle = dsSalida.Tables("detalle")
        With dataDetalle
            .DataSource = dsSalida.Tables("detalle")
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_art").HeaderText = "CODIGO"
            .Columns("cod_art").Width = 54
            .Columns("cod_art").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_art").ReadOnly = True
            .Columns("nom_uni").HeaderText = "UNIDAD"
            .Columns("nom_uni").Width = 54
            .Columns("nom_uni").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("nom_uni").ReadOnly = True
            .Columns("nom_art").HeaderText = "DESCRIPCION"
            .Columns("nom_art").Width = 340
            .Columns("nom_art").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns("nom_art").ReadOnly = True
            .Columns("cantidad").HeaderText = "CANT."
            .Columns("cantidad").Width = 60
            .Columns("cantidad").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cantidad").ReadOnly = False
            .Columns("precio").HeaderText = "PRECIO"
            .Columns("precio").Width = 60
            .Columns("precio").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("precio").ReadOnly = False
            .Columns("precio").DefaultCellStyle.Format = "N" & pDecimales
            .Columns("afecto_igv").HeaderText = "IGV"
            .Columns("afecto_igv").Width = 40
            .Columns("afecto_igv").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("afecto_igv").ReadOnly = True
            .Columns("neto").HeaderText = "NETO"
            .Columns("neto").Width = 80
            .Columns("neto").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("neto").ReadOnly = False
            .Columns("neto").DefaultCellStyle.Format = "N" & pDecimales
            .Columns("obs").HeaderText = "O"
            .Columns("obs").Width = 20
            .Columns("obs").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns("obs").ReadOnly = True
            .Columns("obs").DefaultCellStyle.BackColor = Color.Azure
            .Columns("orden").Visible = False
            .Columns("operacion").Visible = False
            .Columns("ingreso").Visible = False
            .Columns("salida").Visible = False
            .Columns("saldo").Visible = False
            .Columns("igv").Visible = False
            .Columns("comi_v").Visible = False
            .Columns("comi_jv").Visible = False
            .Columns("estado").Visible = False
        End With

        mostrargrupo()
        optMoneda.Text = pMoneda
        estacargando = False
        GeneraNumDocumento()
    End Sub
    Private Sub cmdGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGrabar.Click
        Dim cReg As Integer, continuar As Boolean = True, grabaGuia As Boolean = True
        Dim mGuia As New Guia, mutilidades As New Utilidades, mcuenta As New Cuenta, mcliente As New Cliente
        Dim mSalida As New Salida
        'validamos el documento
        ' Try
        continuar = validaGrabacion()
            If continuar Then
                'validamos la guia de remision
                grabaGuia = validaGuia()
                If grabaGuia Then
                    Dim cod_doc, ser_doc, nro_doc, cod_fpago, tm, cAux4 As String, fec_doc As Date, inc_igv As Integer
                    'el cliente y vendedor lo recuperamos al cargar el pedido
                    cod_doc = cboDocumento.SelectedValue
                    ser_doc = txtSerDocumento.Text
                    nro_doc = txtNroDocumento.Text
                    fec_doc = mcFechaVenta.SelectedDate.Date
                    fcod_clie = txtRuc.Text
                    cod_fpago = cboFormaPago.SelectedValue.ToString
                    Dim ndias As Integer = mutilidades.devuelvediasFormaPago(cboFormaPago.SelectedValue)
                    Dim lcancelado As Integer = IIf(ndias > 0, 0, 1)
                    cod_alma = cboAlmacen.SelectedValue
                    cReg = dataDetalle.RowCount
                    If chkIGV.CheckState = CheckState.Checked Then
                        inc_igv = 1
                    Else
                        inc_igv = 0
                    End If
                    If optMoneda.Checked Then
                        tm = pMonedaAbr
                    Else
                        tm = "D"
                    End If
                    If ChkDetraccion.Checked Then
                        cAux4 = "1"
                    Else
                        cAux4 = "0"
                    End If
                    If tipoProceso = "A" Then 'añadir
                        If cReg > 0 Then
                            'Try
                            nroOperacion = mSalida.maxOperacion
                            'registramos la cabecera

                            If Not mcliente.existe(txtRuc.Text) Then
                                mcliente.insertar(txtRuc.Text, cboCliente.Text, cboCliente.Text, txtDirFiscal.Text, cboDirEntrega.SelectedText, txtContacto.Text, txtTelefono.Text, "00", 1)
                            End If
                            fcod_vend = cboVendedor.SelectedValue

                        mSalida.insertar_aux2(nroOperacion, nroOperacionPedido, cod_doc, ser_doc, nro_doc, fec_doc, fcod_vend, fcod_clie, cod_fpago, lcancelado, inc_igv, pDecimales, cod_alma, tm, "", pEmpresa, "", cAux4, pCuentaUser)

                        'registramos el detalle
                        Dim cod_art, obs As String, I, nroSalida, nroIngreso As Integer, cant, precio, comi_v, comi_jv, igv As Decimal
                            Dim mpedido As New pedido
                        For I = 0 To cReg - 1
                            cod_art = dataDetalle("cod_art", I).Value
                            cant = dataDetalle("cantidad", I).Value
                            precio = dataDetalle("precio", I).Value
                            comi_v = dataDetalle("comi_v", I).Value
                            comi_jv = dataDetalle("comi_jv", I).Value
                            obs = IIf(IsDBNull(dataDetalle("obs", I).Value), "", dataDetalle("obs", I).Value)
                            If dataDetalle("afecto_igv", I).Value = False Then
                                igv = 0
                            Else
                                igv = pIGV
                            End If
                            nroIngreso = -1
                            nroSalida = mSalida.maxSalida
                            mSalida.insertar_detObs(nroOperacion, nroSalida, nroIngreso, cod_art, cant, precio, igv, comi_v, comi_jv, obs)
                            If Not IsDBNull(dataDetalle("orden", I).Value) Then
                                numOrden = dataDetalle("orden", I).Value
                                mpedido.actualizarnumFactura(numOrden, ser_doc + "-" + nro_doc)

                            End If
                        Next
                        'registramos la Guia de Remisión
                        Dim ser_guia, nro_guia, cod_mot, cod_cond, nro_pla, cod_eTrans As String, fec_tras, fec_ent As Date
                            ser_guia = txtSerGuia.Text
                            nro_guia = txtNroGuia.Text
                            cod_mot = cboMotivo.SelectedValue.ToString
                            cod_cond = cboConductor.SelectedValue.ToString
                            nro_pla = txtNroPlaca.Text
                            cod_eTrans = cboEmpTransporte.SelectedValue.ToString
                            fec_tras = dtpTraslado.Value
                            fec_ent = dtpEntrega.Value
                            mGuia.insertar(nroOperacion, ser_guia, nro_guia, fec_tras, fec_ent, cod_mot, cod_cond, nro_pla, cboDirEntrega.SelectedValue, cod_eTrans)

                            'Actualizamos pedido ancelado
                            Dim lserie, lnumero As String

                            lserie = Microsoft.VisualBasic.Right("000000" & txtSerPedido.Text, 6)
                            lnumero = Microsoft.VisualBasic.Right("00000000" & txtNroPedido.Text, 8)
                            'verificamos la existencia del pedido y que no tenga facturas anuladas
                            'nroOperacionPedido = mpedido.existe(lserie, lnumero)
                            'If nroOperacionPedido > 0 Then 'como existe el pedido
                            '    mpedido.actualizarnumFactura(nroOperacionPedido, ser_doc + "-" + nro_doc)
                            'End If



                        Else
                            MessageBox.Show("Falta Registrar Artículos...", "VENTAS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    Else 'edicion
                        mSalida.actualizaCabecera(nroOperacion, fec_doc, fcod_clie, cod_fpago, lcancelado, inc_igv, "", cAux4, pDecimales)

                    End If
                    MessageBox.Show("Documento Registrado Correctamente!!...", "VENTAS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    If lcancelado = 0 Then
                        mcuenta.insertarCC(convierteFechaEspecificadaMes(fec_doc), nroOperacion, 0, fec_doc.AddDays(ndias), 0, #9/4/1970#, 0, pCuentaUser)
                    End If
                    cmdGrabar.Enabled = False
                    tipoProceso = "E"
                    modoHabilitado()
                    'reiniciaControles(True, True)
                    'reiniciaDatos()
                    'modoDeshabilitado()
                    'txtNroDocumento.Focus()
                End If 'grabaGuia

            Else
                'reiniciaControles(True, True)
                'reiniciaDatos()
                'modoDeshabilitado()
                'txtSerPedido.Focus()
            End If
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
    End Sub
    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        reiniciaControles(True, True)
        reiniciaDatos()
        reiniciaCliente()
        habilitaCabecera()
        txtRuc.Text = ""
        'modoDeshabilitado()
        txtSerPedido.Focus()
    End Sub
    Private Sub cmdAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAnular.Click
        Dim rpta As Integer, cero As Integer = 0.0
        rpta = MessageBox.Show("¿Esta seguro de Anular el Documento...?" + Chr(13) + "Este Proceso es Irreversible", "CEFE", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)
        If rpta = 6 Then
            Dim objTransac As MySqlTransaction
            Dim dbConex As MySqlConnection = Conexion.obtenerConexion
            objTransac = dbConex.BeginTransaction
            Try
                'actualizamos la salida
                Dim com As New MySqlCommand("Update salida set anul=1,obs='ANULADO' where operacion=" & nroOperacion)
                com.Connection = dbConex
                com.Transaction = objTransac
                com.ExecuteNonQuery()
                'actualizamos el pedido
                Dim com2 As New MySqlCommand("Update salida_det set cant=0 where operacion=" & nroOperacion)
                com2.Connection = dbConex
                com2.Transaction = objTransac
                com2.ExecuteNonQuery()
                'Dim com3 As New MySqlCommand("Delete from salida_det where operacion=" & nroOperacion)
                'com3.Connection = dbConex
                'com3.Transaction = objTransac
                'com3.ExecuteNonQuery()
                objTransac.Commit()
                txtSerPedido.Focus()
            Catch ex As Exception
                If Not objTransac Is Nothing Then
                    objTransac.Rollback()
                End If
                MessageBox.Show(ex.Message.ToString)
            Finally
                reiniciaControles(True, True)
                reiniciaDatos()
                reiniciaCliente()
                habilitaCabecera()
                txtRuc.Text = ""
                'modoDeshabilitado()
            End Try
        End If
    End Sub
    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        Dim frm As New rptForm
        Dim nomformato As String
        Dim rpta As Integer
        rpta = MessageBox.Show("Desea Enviar en Vista Previa ?", "VENTAS", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)
        Dim vprevia As Boolean = IIf(rpta = 6, True, False)

        If dataDetalle.RowCount() > 0 Then
            If chkFactura.CheckState = CheckState.Checked Then
                nomformato = general.NombreFormato(cboDocumento.SelectedValue)
                frm.cargarFactura(cboDocumento.SelectedValue, txtSerDocumento.Text, txtNroDocumento.Text, nomformato, vprevia)
            End If
            If chkGuiaRemision.CheckState = CheckState.Checked Then
                nomformato = general.NombreFormato("94")
                frm.cargarGuiaRemision(nroOperacion, vprevia, nomformato)
            End If
            If vprevia Then
                frm.MdiParent = principal
                frm.Show()
            End If

        End If
    End Sub
    Private Sub txtNroPedido_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNroPedido.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not (e.KeyChar = ChrW(Keys.Back)) Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub txtNroPedido_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNroPedido.Validating
        Dim lserie, lnumero As String, mpedido As New pedido, msalida As New Salida
        If Microsoft.VisualBasic.Len(txtSerPedido.Text) > 0 And Microsoft.VisualBasic.Len(txtNroPedido.Text) > 0 Then
            'limpiamos la tabla detalle
            dtDetalle.Clear()
            lserie = Microsoft.VisualBasic.Right("000000" & txtSerPedido.Text, 6)
            lnumero = Microsoft.VisualBasic.Right("00000000" & txtNroPedido.Text, 8)
            'verificamos la existencia del pedido y que no tenga facturas anuladas
            nroOperacionPedido = mpedido.existe(lserie, lnumero)
            If nroOperacionPedido > 0 Then 'como existe el pedido
                modoHabilitado()
                nroOperacion = msalida.existePedido(nroOperacionPedido, False)
                If nroOperacion > 0 Then 'como ya existe una factura asociada al pedido y no esta anulada
                    tipoProceso = "E"
                    cmdGrabar.Enabled = False
                    'limpiamos el dataset
                    dsSalida.Clear()
                    'cargamos los datos desde la factura
                    cargaCabecera(nroOperacion, False)
                    cargaCabeceraGuia(nroOperacion)
                    deshabilitaCabecera()
                    'lblDocumento.Text = StrConv(cboDocumento.Text, VbStrConv.ProperCase)
                    cargaDetalle(nroOperacion, False, False)
                    'verificamos si cuenta con permiso para anular la factura
                    If Not esEditable() Then
                        cmdAnular.Enabled = False
                    Else
                        cmdAnular.Enabled = True
                    End If
                    cmdImprimir.Focus()
                Else
                    tipoProceso = "A"
                    cmdImprimir.Enabled = False
                    cmdAnular.Enabled = False
                    habilitaCabecera()
                    'cargamos los datos desde el pedido
                    cargaCabeceraPedido(nroOperacionPedido)
                    cargaDetallePedido(nroOperacionPedido, txtSerPedido.Text, txtNroPedido.Text)
                    cboDocumento.Focus()
                    GeneraNumDocumento()
                End If
                dataDetalle.ClearSelection()
            Else
                MessageBox.Show("Pedido NO Existe...", "VENTAS", MessageBoxButtons.OK, MessageBoxIcon.Error)
                reiniciaControles(False, True)
                reiniciaDatos()
                tipoProceso = "A"
                modoDeshabilitado()
                txtSerPedido.Focus()
            End If
        End If
    End Sub
    Private Sub txtNroDocumento_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNroDocumento.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not (e.KeyChar = ChrW(Keys.Back)) Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub txtNrodocumento_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNroDocumento.Validating
        'If txtNroDocumento.ReadOnly = False Then
        If cboDocumento.SelectedIndex = -1 Then
            txtSerDocumento.Text = ""
            txtNroDocumento.Text = ""
            cboDocumento.Focus()
        Else
            Dim eshistorial As Boolean
            Dim lserie As String, lnumero As String, ldoc As String
            lserie = Microsoft.VisualBasic.Right("0000" & txtSerDocumento.Text, 4)
            lnumero = Microsoft.VisualBasic.Right("00000000" & txtNroDocumento.Text, 8)
            If cboDocumento.SelectedIndex >= 0 Then
                ldoc = cboDocumento.SelectedValue
                Dim msalida As New Salida
                nroOperacion = msalida.existe(ldoc, lserie, lnumero)
                eshistorial = msalida.eshistorial(ldoc, lserie, lnumero)
                If nroOperacion > 0 Then 'si la factura ya esta registrada
                    'si la factura no esta anulada
                    If Not msalida.estaAnulada(nroOperacion) Then
                        modoHabilitado()
                        tipoProceso = "E"
                        cmdGrabar.Enabled = True
                        'limpiamos el dataset salida
                        dsSalida.Clear()
                        'cargamos los datos desde la factura
                        cargaCabecera(nroOperacion, eshistorial)
                        cargaCabeceraGuia(nroOperacion)
                        'deshabilitaCabecera()
                        cargaDetalle(nroOperacion, False, eshistorial)
                        'recuperamos el nro de pedido
                        Dim mPedido As New pedido
                        nroOperacionPedido = mPedido.existe(txtSerPedido.Text, txtNroPedido.Text)
                    Else
                        MessageBox.Show("La " + cboDocumento.Text + " " + lserie + "-" + lnumero + " esta Anulada" + Chr(13) + "Ingrese otro Número de documento...", "CEFE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        reiniciaControles(False, True)
                        reiniciaDatos()
                        If Microsoft.VisualBasic.Len(txtSerPedido.Text) > 0 Then
                            txtNroPedido.Focus()
                        Else
                            txtSerPedido.Focus()
                        End If
                    End If
                    'verificamos si cuenta con permiso para anular la factura
                    If Not esEditable() Then
                        cmdAnular.Enabled = False
                    Else
                        cmdAnular.Enabled = True

                    End If
                    'cmdImprimir.Focus()
                    dataDetalle.ReadOnly = True
                    dataDetalle.Focus()
                Else
                    reiniciaDatos()
                    reiniciaCliente()
                    reiniciaControles(False, False)
                    'txtRuc.Text = ""
                    dataDetalle.ReadOnly = False
                    '    'como aun no esta registrada la factura, verificamos si ya se recupero el pedido
                    '    If nroOperacionPedido = 0 Then
                    '        MessageBox.Show("Documento aun NO Registrado" + Chr(13) + "Debe recuperar un pedido...", "CEFE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    '        txtSerPedido.Focus()
                    '    Else
                    '        txtSerGuia.Focus()
                    'End If
                End If
            Else
                'falta seleccionar el tipo de documento
                MessageBox.Show("Seleccione el Tipo de Documento...", "VENTAS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cboDocumento.Focus()
            End If
        End If
        'End If
    End Sub
    Sub calculaTotal()
        Dim nroReg As Integer = 0, I As Integer = 0
        Dim lTotal As Decimal = 0, lsubTotal As Decimal = 0, ligv As Decimal = 0, lmTotal As Decimal = 0
        nroReg = dataDetalle.RowCount
        For I = 0 To nroReg - 1
            lsubTotal = lsubTotal + (dataDetalle("cantidad", I).Value * dataDetalle("precio", I).Value)
            If dataDetalle("afecto_igv", I).Value = True Then
                lmTotal = lmTotal + (dataDetalle("cantidad", I).Value * dataDetalle("precio", I).Value)
                ligv = dataDetalle("igv", I).Value
            End If
        Next
        lblItems.Text = "Nro de Items. " & Str(I)
        If chkIGV.Checked = True Then
            'como los precios incluyen el igv
            txtTotal.Text = Round(lsubTotal, pDecimales)
            txtSubTotal.Text = Round(general.calculaSubTotaldelTotal_afectoIMP(Round(lsubTotal, pDecimales)), pDecimales)
            txtIGV.Text = Round(lsubTotal, pDecimales) - Round(general.calculaSubTotaldelTotal_afectoIMP(Round(lsubTotal, pDecimales)), pDecimales)
        Else
            'como los precios no incluyen el igv
            ligv = ligv * lmTotal
            txtSubTotal.Text = Round(lsubTotal, pDecimales)
            txtIGV.Text = Round(ligv, pDecimales)
            txtTotal.Text = Round(lsubTotal, pDecimales) + Round(ligv, pDecimales)
        End If

    End Sub
    Function validaGrabacion() As Boolean
        Dim valorRetorno As Boolean = False
        If mcFechaVenta.SelectedDate.Year >= 2010 Then
            'If Microsoft.VisualBasic.Len(txtSerPedido.Text) > 0 Then
            'If Microsoft.VisualBasic.Len(txtNroPedido.Text) > 0 Then
            If cboDocumento.SelectedIndex >= 0 Then
                If Microsoft.VisualBasic.Len(txtSerDocumento.Text) > 0 Then
                    If Microsoft.VisualBasic.Len(txtNroDocumento.Text) > 0 Then
                        If cboFormaPago.SelectedIndex >= 0 Then
                            If Microsoft.VisualBasic.Len(txtRuc.Text) > 0 Then
                                valorRetorno = True
                            Else
                                MessageBox.Show("Ingrese Ruc de Cliente...", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                ep.SetError(txtRuc, "Ingrese Ruc de Cliente...")
                                txtRuc.Focus()
                            End If

                        Else
                            ep.SetError(cboFormaPago, "SELECCIONE FORMA DE PAGO")
                            cboFormaPago.Focus()
                        End If
                    Else
                        ep.SetError(txtNroDocumento, "INGRESE NRO DOCUMENTO")
                        txtNroDocumento.Focus()
                    End If
                Else
                    ep.SetError(txtSerDocumento, "INGRESE SERIE DOCUMENTO")
                    txtSerDocumento.Focus()
                End If
            Else
                ep.SetError(cboDocumento, "SELECCIONE TIPO DE DOCUMENTO")
                cboDocumento.Focus()
            End If
            'Else
            '    ep.SetError(txtSerPedido, "INGRESE NUMERO DE PEDIDO")
            '    txtNroPedido.Focus()
            'End If
            'Else
            'ep.SetError(txtSerPedido, "INGRESE SERIE DE PEDIDO")
            'txtSerPedido.Focus()
            'End If
        Else
            MessageBox.Show("Seleccione la Fecha de Venta...", "CEFE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            mcFechaVenta.Focus()
        End If
        Return valorRetorno
    End Function

    Sub cargaCabeceraPedido(ByVal nro_ope As Integer)
        Dim mpedido As New pedido
        Dim dt As New DataTable
        dt = mpedido.recuperaCabecera(nro_ope)
        'mcFPedido.SelectedDate = dt.Rows(0).Item("fec_ped")
        mcFechaVenta.SelectedDate = dt.Rows(0).Item("fec_ent")
        cboVendedor.SelectedValue = Microsoft.VisualBasic.Trim(dt.Rows(0).Item("cod_vend").ToString)
        TipoCliente = dt.Rows(0).Item("cod_tipo").ToString
        cboCliente.SelectedValue = dt.Rows(0).Item("cod_clie").ToString
        txtRuc.Text = dt.Rows(0).Item("cod_clie").ToString
        fcod_clie = txtRuc.Text
        If Microsoft.VisualBasic.Len(fcod_clie) > 0 Then
            UbicarCliente(fcod_clie)
        End If
        'txtTelefono.Text = dt.Rows(0).Item("fono_clie").ToString
        'txtContacto.Text = dt.Rows(0).Item("nom_cont").ToString
        cboFormaPago.SelectedValue = dt.Rows(0).Item("cod_fpago").ToString
        cboAlmacen.SelectedValue = dt.Rows(0).Item("cod_alma").ToString
        cboDirEntrega.Text = dt.Rows(0).Item("dir_ent").ToString
        'txtObs.Text = dt.Rows(0).Item("obs").ToString
        If dt.Rows(0).Item("tm") = "S" Then
            optMoneda.Checked = True
        Else
            optDolares.Checked = True
        End If

        If dt.Rows(0).Item("pre_inc_igv") = True Then
            chkIGV.CheckState = CheckState.Checked
        Else
            chkIGV.CheckState = CheckState.Unchecked
        End If
    End Sub

    Sub cargaDetallePedido(ByVal nro_ope As Integer, ByVal ser_ped As String, ByVal nro_ped As String)
        Dim mpedido As New pedido, I As Integer
        Dim dt As New DataTable
        dt = mpedido.recuperaDetalle(nro_ope, ser_ped, nro_ped, pDecimales)
        For I = 0 To dt.Rows.Count - 1
            dtDetalle.ImportRow(dt.Rows(I))
        Next
        dataDetalle.DataSource = dsSalida.Tables("detalle")
        calculaTotal()
        dataDetalle.Refresh()
    End Sub
    Sub cargaCabecera(ByVal nro_ope As Integer, ByVal eshistorial As Boolean)
        Dim msalida As New Salida
        Dim dt As New DataTable
        dt = msalida.recuperaCabecera(nro_ope, True, eshistorial)
        mcFechaVenta.SelectedDate = (dt.Rows(0).Item("fec_doc"))
        txtSerPedido.Text = dt.Rows(0).Item("ser_ped").ToString
        txtNroPedido.Text = dt.Rows(0).Item("nro_ped").ToString
        cboCliente.SelectedValue = dt.Rows(0).Item("cod_clie").ToString
        txtRuc.Text = dt.Rows(0).Item("cod_clie").ToString
        txtDirFiscal.Text = dt.Rows(0).Item("dir_clie").ToString
        cboFormaPago.SelectedValue = dt.Rows(0).Item("cod_fpago").ToString
        cboDocumento.SelectedValue = dt.Rows(0).Item("cod_doc").ToString
        lblVendedor.Text = dt.Rows(0).Item("nom_vend").ToString
        txtSerDocumento.Text = dt.Rows(0).Item("ser_doc").ToString
        txtNroDocumento.Text = dt.Rows(0).Item("nro_doc").ToString
        If dt.Rows(0).Item("pre_inc_igv") = True Then
            chkIGV.CheckState = CheckState.Checked
        Else
            chkIGV.CheckState = CheckState.Unchecked
        End If
        If dt.Rows(0).Item("tm") = "D" Then
            optDolares.Checked = True
        Else
            optMoneda.Checked = True
        End If
        muestraTCActual()
    End Sub
    Sub cargaDetalle(ByVal nro_ope As Integer, ByVal facturaAnulada As Boolean, ByVal eshistorial As Boolean)
        Dim msalida As New Salida, I As Integer
        Dim dt As New DataTable
        If facturaAnulada Then
            dt = msalida.recuperaDetalle_anul(nro_ope, pDecimales)
        Else
            dt = msalida.recuperaDetalle(nro_ope, pDecimales, eshistorial)
        End If
        For I = 0 To dt.Rows.Count - 1
            dtDetalle.ImportRow(dt.Rows(I))
        Next
        dataDetalle.DataSource = dsSalida.Tables("detalle")
        calculaTotal()
        dataDetalle.Refresh()
    End Sub
    Sub deshabilitaCabecera()
        txtSerPedido.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        txtSerPedido.ReadOnly = True
        txtNroPedido.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        txtNroPedido.ReadOnly = True
        txtSerDocumento.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        txtSerDocumento.ReadOnly = True
        txtNroDocumento.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        txtNroDocumento.ReadOnly = True
        cboDocumento.Enabled = False
        cboFormaPago.Enabled = False
        'guia
        txtSerGuia.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        txtSerGuia.ReadOnly = True
        txtNroGuia.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        txtNroGuia.ReadOnly = True
        cboMotivo.Enabled = False
        dtpTraslado.Enabled = False
        dtpEntrega.Enabled = False
        cboConductor.Enabled = False
        txtNroPlaca.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        txtNroPlaca.ReadOnly = True
        cboEmpTransporte.Enabled = False
    End Sub
    Sub habilitaCabecera()
        txtSerPedido.BackColor = Color.White
        txtSerPedido.ReadOnly = False
        txtNroPedido.BackColor = Color.White
        txtNroPedido.ReadOnly = False
        txtSerDocumento.BackColor = Color.White
        txtSerDocumento.ReadOnly = False
        txtNroDocumento.BackColor = Color.White
        txtNroDocumento.ReadOnly = False
        cboDocumento.Enabled = True
        cboFormaPago.Enabled = True
        'guia
        txtSerGuia.BackColor = Color.White
        txtSerGuia.ReadOnly = False
        txtNroGuia.BackColor = Color.White
        txtNroGuia.ReadOnly = False
        cboMotivo.Enabled = True
        dtpTraslado.Enabled = True
        dtpEntrega.Enabled = True
        cboConductor.Enabled = True
        txtNroPlaca.BackColor = Color.White
        txtNroPlaca.ReadOnly = False
        cboEmpTransporte.Enabled = True
    End Sub
    Sub reiniciaControles(ByVal incluirNroPedido As Boolean, ByVal incluirNroDocumento As Boolean)
        If incluirNroDocumento Then
            GeneraNumDocumento()
        End If
        dataPedidos.DataSource = ""
        dataPedidos.Refresh()
        lblVendedor.Text = "VENDEDOR"
        lblMensaje.Text = ""
        lblItems.Text = "Nro de Items. 0"
        cboDocumento.SelectedIndex = 0
        cboFormaPago.SelectedIndex = 0
        txtSubTotal.Text = 0
        txtTotal.Text = 0
        txtIGV.Text = 0
        'controles de la guia
        cboMotivo.SelectedIndex = 0
        cboConductor.SelectedIndex = 0
        txtNroPlaca.Text = ""
        cboEmpTransporte.SelectedIndex = 0
        ep.Clear()
        estableceFechaProceso()
        If pPreciosIncIGV Then
            chkIGV.CheckState = CheckState.Checked
        Else
            chkIGV.CheckState = CheckState.Unchecked
        End If
        chkMostrarPedidos.Checked = False
    End Sub
    Sub reiniciaDatos()
        dtDetalle.Clear()
        nroOperacion = 0
        nroOperacionPedido = 0
        fcod_vend = ""
        fcod_clie = ""
        tipoProceso = "A"
        cmdGrabar.Enabled = True
        optMoneda.Checked = True
        muestraTCActual()

    End Sub
    Sub reiniciaCliente()
        cboCliente.SelectedIndex = -1
        txtDirFiscal.Text = ""
        txtTelefono.Text = ""
        txtContacto.Text = ""
    End Sub
    Sub estableceFechaProceso()
        mcFechaVenta.MinDate = pFechaActivaMin
        mcFechaVenta.MaxDate = Microsoft.VisualBasic.DateAndTime.DateAdd(DateInterval.Day, pDiasModificarSalida, pFechaSystem)
        mcFechaVenta.DisplayMonth = pFechaSystem
        mcFechaVenta.SelectedDate = pFechaSystem

    End Sub
    Sub modoHabilitado()
        cmdGrabar.Enabled = True
        cmdCancelar.Enabled = True
        cmdAnular.Enabled = True
        cmdImprimir.Enabled = True
    End Sub


    Sub modoDeshabilitado()
        cmdGrabar.Enabled = False
        cmdCancelar.Enabled = False
        cmdAnular.Enabled = False
        cmdImprimir.Enabled = False
    End Sub
    Private Sub txtSerPedido_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSerPedido.GotFocus
        general.ingresaTextoProceso(txtSerPedido)
    End Sub
    Private Sub txtSerPedido_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSerPedido.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not (e.KeyChar = ChrW(Keys.Back)) Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub txtSerPedido_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSerPedido.LostFocus
        If Microsoft.VisualBasic.Len(txtSerPedido.Text) > 0 Then
            txtSerPedido.Text = Microsoft.VisualBasic.Right("000000" & txtSerPedido.Text, 6)
        End If
        general.saleTextoProceso(txtSerPedido)
    End Sub
    Private Sub txtNroPedido_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNroPedido.GotFocus
        general.ingresaTextoProceso(txtNroPedido)
    End Sub
    Private Sub txtNroPedido_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNroPedido.LostFocus
        If Microsoft.VisualBasic.Len(txtNroPedido.Text) > 0 Then
            txtNroPedido.Text = Microsoft.VisualBasic.Right("00000000" & txtNroPedido.Text, 8)
        End If
        general.saleTextoProceso(txtNroPedido)
    End Sub
    Private Sub txtSerDocumento_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSerDocumento.GotFocus
        general.ingresaTextoProceso(txtSerDocumento)
    End Sub
    Private Sub txtSerDocumento_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSerDocumento.KeyPress
        'If Not Char.IsNumber(e.KeyChar) And Not (e.KeyChar = ChrW(Keys.Back)) Then
        '    e.KeyChar = ""
        'End If
    End Sub
    Private Sub txtSerDocumento_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSerDocumento.LostFocus
        If Microsoft.VisualBasic.Len(txtSerDocumento.Text) > 0 Then
            txtSerDocumento.Text = UCase(Microsoft.VisualBasic.Right("0000" & txtSerDocumento.Text, 4))
            txtSerGuia.Text = Microsoft.VisualBasic.Right("0000" & txtSerDocumento.Text, 4)
        End If
        general.saleTextoProceso(txtSerDocumento)
    End Sub
    Private Sub txtNroDocumento_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNroDocumento.GotFocus
        general.ingresaTextoProceso(txtNroDocumento)
    End Sub
    Private Sub txtNroDocumento_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNroDocumento.LostFocus
        If Microsoft.VisualBasic.Len(txtNroDocumento.Text) > 0 Then
            txtNroDocumento.Text = UCase(Microsoft.VisualBasic.Right("00000000" & txtNroDocumento.Text, 8))
        End If
        general.saleTextoProceso(txtNroDocumento)
    End Sub

    Private Sub cboDocumento_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboDocumento.KeyPress
        If e.KeyChar = Chr(13) Then
            txtSerDocumento.Focus()
        End If
    End Sub
    Private Sub cboDocumento_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboDocumento.LostFocus
        ' lblDocumento.Text = StrConv("Nro " + cboDocumento.Text, VbStrConv.ProperCase)
    End Sub
    Function validaGuia() As Boolean
        Dim valorRetorno As Boolean = True
        If Microsoft.VisualBasic.Len(txtSerGuia.Text) > 0 Then
            If Microsoft.VisualBasic.Len(txtNroGuia.Text) > 0 Then
                If cboMotivo.SelectedIndex >= 0 Then
                    If cboConductor.SelectedIndex >= 0 Then
                        'If Microsoft.VisualBasic.Len(txtNroPlaca.Text) > 0 Then
                        If cboEmpTransporte.SelectedIndex >= 0 Then
                            valorRetorno = True
                        Else
                            ep.SetError(cboEmpTransporte, "SELECCIONE ENPRESA DE TRANSPORTE")
                            cboEmpTransporte.Focus()
                        End If
                        'Else
                        '    ep.SetError(txtNroPlaca, "INGRESE NRO DE PLACA")
                        '    txtNroPlaca.Focus()
                        'End If
                    Else
                        ep.SetError(cboConductor, "INGRESE NOMBRE DEL CHOFER")
                        cboConductor.Focus()
                    End If
                Else
                    ep.SetError(cboMotivo, "SELECCIONE MOTIVO DE TRANSPORTE")
                    cboMotivo.Focus()
                End If
            Else
                ep.SetError(txtNroGuia, "INGRESE NUMERO DE GUIA")
                txtNroGuia.Focus()
            End If
        Else
            ep.SetError(txtSerGuia, "INGRESE SERIE DE GUIA")
            txtSerGuia.Focus()
        End If
        Return valorRetorno
    End Function
    Sub cargaCabeceraGuia(ByVal nro_ope As Integer)
        Dim mGuia As New Guia
        Dim dt As New DataTable
        dt = mGuia.recupera(nro_ope)
        If dt.Rows.Count > 0 Then
            txtSerGuia.Text = dt.Rows(0).Item("ser_guia").ToString
            txtNroGuia.Text = dt.Rows(0).Item("nro_guia").ToString
            cboMotivo.SelectedValue = dt.Rows(0).Item("cod_mot").ToString
            dtpTraslado.Text = dt.Rows(0).Item("fec_tras").ToString
            dtpEntrega.Value = dt.Rows(0).Item("fec_ent").ToString
            cboConductor.SelectedValue = dt.Rows(0).Item("cod_cond").ToString
            txtNroPlaca.Text = dt.Rows(0).Item("placa").ToString
            cboDirEntrega.SelectedValue = dt.Rows(0).Item("cod_sucursal").ToString
            cboEmpTransporte.SelectedValue = dt.Rows(0).Item("cod_etrans").ToString
        End If

    End Sub
    Private Sub txtSerGuia_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSerGuia.GotFocus
        If txtSerGuia.ReadOnly = False Then
            general.ingresaTextoProceso(txtSerGuia)
        End If
    End Sub
    Private Sub txtSerGuia_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSerGuia.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not (e.KeyChar = ChrW(Keys.Back)) Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub txtSerGuia_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSerGuia.LostFocus
        If txtSerGuia.ReadOnly = False Then
            If Microsoft.VisualBasic.Len(txtSerGuia.Text) > 0 Then
                txtSerGuia.Text = Microsoft.VisualBasic.Right("000" & txtSerGuia.Text, 3)
            End If
            general.saleTextoProceso(txtSerGuia)
        End If
    End Sub
    Private Sub txtNroGuia_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNroGuia.GotFocus
        If txtNroGuia.ReadOnly = False Then
            general.ingresaTextoProceso(txtNroGuia)
        End If
    End Sub
    Private Sub txtNroGuia_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNroGuia.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not (e.KeyChar = ChrW(Keys.Back)) Then
            e.KeyChar = ""
        End If
        If e.KeyChar = Chr(13) Then
            cboMotivo.Focus()
        End If
    End Sub
    Private Sub txtNroGuia_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNroGuia.LostFocus
        If txtNroGuia.ReadOnly = False Then
            If Microsoft.VisualBasic.Len(txtNroGuia.Text) > 0 Then
                txtNroGuia.Text = Microsoft.VisualBasic.Right("00000000" & txtNroGuia.Text, 8)
            End If
            general.saleTextoProceso(txtNroGuia)
        End If
    End Sub
    Private Sub txtNroPlaca_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNroPlaca.GotFocus
        If txtNroPlaca.ReadOnly = False Then
            general.ingresaTextoProceso(txtNroPlaca)
        End If
    End Sub

    Private Sub txtNroPlaca_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNroPlaca.KeyPress
        If e.KeyChar = Chr(13) Then
            cboEmpTransporte.Focus()
        End If
    End Sub
    Private Sub txtNroPlaca_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNroPlaca.LostFocus
        If txtNroPlaca.ReadOnly = False Then
            general.saleTextoProceso(txtNroPlaca)
        End If
    End Sub
    Private Sub chkFactura_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFactura.CheckedChanged
        If chkFactura.CheckState = CheckState.Checked Then
            chkGuiaRemision.CheckState = CheckState.Unchecked
        Else
            chkGuiaRemision.CheckState = CheckState.Checked
        End If
    End Sub
    Private Sub chkGuiaRemision_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGuiaRemision.CheckedChanged
        If chkGuiaRemision.CheckState = CheckState.Checked Then
            chkFactura.CheckState = CheckState.Unchecked
        Else
            chkFactura.CheckState = CheckState.Checked
        End If
    End Sub

    Private Sub chkMostrarPedidos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMostrarPedidos.CheckedChanged
        Dim mPedido As New pedido, dtPedidos As New DataTable, I As Integer
        If chkMostrarPedidos.Checked = True Then
            dtPedidos = mPedido.recupera_ordenCompra()
            dataPedidos.DataSource = dtPedidos
            For I = 0 To dataPedidos.Columns.Count - 1
                dataPedidos.Columns(I).Visible = False
            Next

            With dataPedidos
                .Columns("num_orden").Visible = True
                .Columns("num_orden").Width = 78
                .Columns("num_orden").HeaderText = "Orden"
                .Columns("num_orden").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Columns("importe").Visible = True
                .Columns("importe").Width = 100
                .Columns("importe").HeaderText = "Importe"
                .Columns("importe").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns("importe").DefaultCellStyle.Format = "C2"
            End With

            dataPedidos.Focus()
        Else
            dtPedidos.Clear()
            dataPedidos.DataSource = ""
            dataPedidos.Refresh()
        End If
    End Sub
    Private Sub dataPedidos_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles dataPedidos.PreviewKeyDown
        If e.KeyCode = Keys.Enter Then
            txtSerPedido.Text = dataPedidos.Item("ser_ped", dataPedidos.CurrentRow.Index).Value
            txtNroPedido.Text = dataPedidos.Item("nro_ped", dataPedidos.CurrentRow.Index).Value
            txtNroPedido.Focus()
        End If
    End Sub
    Function esEditable() As Boolean
        Dim lTipoDoc, lserie, lnumero As String, lfechaSal As Date
        lserie = Microsoft.VisualBasic.Right("000" & txtSerDocumento.Text, 3)
        lnumero = Microsoft.VisualBasic.Right("00000000" & txtNroDocumento.Text, 8)
        lTipoDoc = cboDocumento.SelectedValue
        Dim mSalida As New Salida
        lfechaSal = msalida.devuelveFechasalida(lTipoDoc, lserie, lnumero)
        If lfechaSal.AddDays(pDiasModificarSalida) > pFechaSystem Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub chkIGV_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkIGV.CheckedChanged
        calculaTotal()
    End Sub
    Private Sub cboFormaPago_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            cboDocumento.Focus()
        End If
    End Sub
    Private Sub cboMotivo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboMotivo.KeyPress
        If e.KeyChar = Chr(13) Then
            dtpTraslado.Focus()
        End If
    End Sub
    Private Sub dtpEntrega_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpEntrega.KeyPress
        If e.KeyChar = Chr(13) Then
            cboConductor.SelectedIndex = -1
            cboConductor.Focus()
        End If
    End Sub

    Private Sub cboConductor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboConductor.KeyPress
        If e.KeyChar = Chr(13) Then
            txtNroPlaca.Focus()
        End If
    End Sub
    Private Sub txtBuscar_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscar.GotFocus
        general.ingresaTextoProceso(txtBuscar)
    End Sub

    Private Sub txtBuscar_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscar.LostFocus
        general.saleTextoProceso(txtBuscar)
    End Sub

    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged
        If Not estaCargando Then
            filtraArticulos()
        End If
    End Sub
    Sub filtraArticulos()
        If Len(txtBuscar.Text) > 3 Or Len(cboCliente.Text) > 3 Then
            Dim valor As String = txtBuscar.Text
            Dim cod_alma As String = cboAlmacen.SelectedValue.ToString
            If (cboTipoCliente.SelectedIndex.Equals(-1)) Then
                TipoCliente = ""
            Else
                TipoCliente = cboTipoCliente.SelectedValue.ToString
            End If
            cargaArticulos(cod_alma, "", TipoCliente, valor)
        End If
    End Sub

    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Len(txtBuscar.Text) > 0 Then
            Dim cod_alma As String = cboAlmacen.SelectedValue.ToString
            If (cboTipoCliente.SelectedIndex.Equals(-1)) Then
                TipoCliente = ""
            Else
                TipoCliente = cboTipoCliente.SelectedValue.ToString
            End If
            cargaArticulos(cod_alma, "", TipoCliente, txtBuscar.Text)
            txtBuscar.Text = ""
        Else
            txtBuscar.Focus()
        End If
    End Sub
    Sub cargaArticulos(ByVal cod_alma As String, ByVal cod_sgrupo As String, ByVal cod_tipoCliente As String, ByVal articulo As String)
        'dataset articulo
        dsArticulo.Clear()
        Dim daArticulo As New MySqlDataAdapter, lCadena, c1, c2, c3, c4, c5, c6, c7, c11, c12 As String
        c1 = " Select a.cod_art,nom_art,nom_uni,afecto_igv,0 as comi_v,0 as comi_jv,sg.b_ancho,sg.b_alto"
        c2 = " from articulo as a inner join almacen on a.cod_alma=almacen.cod_alma "
        c3 = " inner join tipo_articulo as t on a.cod_tart=t.cod_tart"
        c4 = " inner join unidad on a.cod_uni=unidad.cod_uni inner join subgrupo sg on a.cod_sgrupo=sg.cod_sgrupo"
        If Not (pDespachoXprecioVenta) Or cod_tipoCliente = "00" Then
            c11 = ",pre_venta"
            c5 = ""
            c6 = " where a.cod_alma='" & cod_alma & "' and (a.nom_art like'%" & articulo & "%' or a.cod_art like'%" & articulo & "%')"
            c12 = IIf(cod_sgrupo.Length > 0, " and a.cod_sgrupo='" & cod_sgrupo & "'", " ")
        Else
            c11 = ",art_tipocliente.precio as pre_venta"
            c5 = " left join art_tipocliente on a.cod_art=art_tipocliente.cod_Art"
            c6 = " where a.cod_alma='" & cod_alma & "' and art_tipocliente.cod_tipo ='" & cod_tipoCliente & "'" & " and (a.nom_art like'%" & articulo & "%' or a.cod_art like'%" & articulo & "%')"
            c12 = IIf(cod_sgrupo.Length > 0, " and a.cod_sgrupo='" & cod_sgrupo & "'", " ")
        End If
        c7 = " and a.activo=1 group by a.cod_art order by nom_art"
        lCadena = c1 + c11 + c2 + c3 + c4 + c5 + c6 + c12 + c7

        Dim comArt As New MySqlCommand(lCadena, dbConex)
        daArticulo.SelectCommand = comArt
        daArticulo.Fill(dsArticulo, "articulo")
        mostrararticulos(lCadena)

    End Sub
    Private Sub agregaitem(ByVal codigo As String)
        Dim fila As DataRow = dtDetalle.NewRow
        Dim buscafila() As DataRow
        buscafila = dsArticulo.Tables("Articulo").Select("cod_art='" & codigo & "'")
        If buscafila.Length > 0 Then
            fila.Item("cod_art") = buscafila(0).Item("cod_art").ToString
            fila.Item("nom_art") = buscafila(0).Item("nom_art").ToString
            fila.Item("nom_uni") = buscafila(0).Item("nom_uni").ToString
            fila.Item("precio") = buscafila(0).Item("pre_venta").ToString
            fila.Item("cantidad") = NudCantidad.Value
            fila.Item("neto") = fila.Item("cantidad") * fila.Item("precio")
            fila.Item("afecto_igv") = buscafila(0).Item("afecto_igv").ToString
            If buscafila(0).Item("afecto_igv").ToString = True Then
                fila.Item("igv") = pIGV
            Else
                fila.Item("igv") = 0
            End If
            fila.Item("comi_v") = buscafila(0).Item("comi_v").ToString
            fila.Item("comi_jv") = buscafila(0).Item("comi_jv").ToString
            If tipoProceso = "E" Then
                fila.Item("estado") = "New"
            Else
                fila.Item("estado") = "Reg"
            End If
            dtDetalle.Rows.Add(fila)
            dataDetalle.CurrentCell = dataDetalle(dataDetalle.Columns("cantidad").Index, dataDetalle.RowCount - 1)
            dataDetalle.Focus()
            calculaTotal()
        End If


    End Sub
    Private Sub mostrargrupo()
        'Dim objconexion As MySqlConnection
        'objconexion = Conexion.obtenerConexion()
        Dim strSQl As String = "select cod_sgrupo,nom_sgrupo from subgrupo where activo=1 and esVenta"
        Dim mycomand As New MySqlCommand(strSQl, dbConex)
        Dim myreader As MySqlDataReader
        Try
            myreader = mycomand.ExecuteReader()
            While myreader.Read
                Dim botong As New Button
                With botong
                    .Width = 80
                    .Height = 50
                    .Visible = True
                    .TextAlign = ContentAlignment.MiddleCenter
                    .BackColor = Color.BurlyWood
                    .ForeColor = Color.White
                    .Text = myreader("nom_sgrupo")
                    .Name = myreader("cod_sgrupo")
                End With
                panelgrupo.Controls.Add(botong)
                AddHandler botong.Click, AddressOf Me.botong_Click
                'ListBox1.Items.Add(myreader(0).ToString + Space(5) + myreader(1).ToString)
            End While
            myreader.Close()
        Catch ex As Exception
        Finally
            'objconexion.Close()
        End Try
    End Sub
    Private Sub mostrararticulos(ByVal strSQL As String)
        Dim objconexion As MySqlConnection
        objconexion = Conexion.obtenerConexion()
        'Dim strSQl As String = "select * from articulo where cod_sgrupo ='" & codgrupo & "'"
        Dim mycomand As New MySqlCommand(strSQL, dbConex)
        Dim myreader As MySqlDataReader
        panelarticulos.Controls.Clear()
        Try
            myreader = mycomand.ExecuteReader()
            While myreader.Read
                Dim botona As New Button
                With botona
                    .Width = myreader("b_ancho")
                    .Height = myreader("b_alto")
                    .Visible = True
                    .TextAlign = ContentAlignment.MiddleCenter
                    .BackColor = Color.LightCoral
                    .ForeColor = Color.GhostWhite
                    .Text = myreader("nom_art")
                    .Name = myreader("cod_art")
                End With
                panelarticulos.Controls.Add(botona)
                AddHandler botona.Click, AddressOf Me.botona_Click
                AddHandler botona.GotFocus, AddressOf Me.botona_GotFocus
                AddHandler botona.LostFocus, AddressOf Me.botona_LostFocus
                AddHandler botona.MouseMove, AddressOf Me.botona_MouseMove
                AddHandler botona.MouseLeave, AddressOf Me.botona_MouseLeave
                'ListBox1.Items.Add(myreader(0).ToString + Space(5) + myreader(1).ToString)
            End While
            myreader.Close()
        Catch ex As Exception
        Finally
            ' objconexion.Close()
        End Try

        With cboArticulo
            .DataSource = dsArticulo.Tables("articulo")
            .DisplayMember = dsArticulo.Tables("articulo").Columns("nom_art").ToString
            .ValueMember = dsArticulo.Tables("articulo").Columns("cod_art").ToString
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.ListItems
            If dsArticulo.Tables("articulo").Rows.Count > 0 Then
                cboArticulo.Enabled = True
                .SelectedIndex = 0
            Else
                cboArticulo.Enabled = False
                .SelectedIndex = -1
            End If
        End With

    End Sub

    Private Sub botona_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim btn As Button = DirectCast(sender, Button)
        btn.BackColor = Color.CadetBlue
    End Sub


    Private Sub botona_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim btn As Button = DirectCast(sender, Button)
        'Volviendo al color inicial
        btn.BackColor = Color.LightCoral
    End Sub

    Private Sub botona_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Dim btn As Button = DirectCast(sender, Button)
        btn.BackColor = Color.CadetBlue
    End Sub
    Private Sub botona_MouseLeave(sender As Object, e As System.EventArgs)
        Dim btn As Button = DirectCast(sender, Button)
        btn.BackColor = Color.LightCoral
    End Sub


    Private Sub botong_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Obtenemos el botón pulsado
        Dim btn As Button = DirectCast(sender, Button)
        ' Lo deshabilitamos
        'btn.Enabled = False
        ' Mostramos el formulario pasándole la referencia del botón pulsado.
        '       Dim frm As New FormNuevaFactura(btn)
        '     frm.Show()
        Dim cod_alma As String = cboAlmacen.SelectedValue.ToString
        If (cboTipoCliente.SelectedIndex.Equals(-1)) Then
            TipoCliente = ""
        Else
            TipoCliente = cboTipoCliente.SelectedValue.ToString
        End If
        cargaArticulos(cod_alma, btn.Name, "00", txtBuscar.Text)
        txtBuscar.Text = ""

    End Sub
    Private Sub botona_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Obtenemos el botón pulsado
        If tipoProceso = "A" Then
            Dim btn As Button = DirectCast(sender, Button)
            agregaitem(btn.Name)

        End If
    End Sub

    Private Sub UbicarCliente(ByVal cod_cliente As String)
        Try
            'Dim fila As DataRow = dsCliente.Tables("cliente").Rows.Find(lcod)
            Dim fila() As DataRow
            fila = dsCliente.Tables("cliente").Select("cod_clie ='" & cod_cliente & "'")
            txtRuc.Text = fila(0).Item("cod_clie").ToString
            txtDirFiscal.Text = fila(0).Item("dir_clie").ToString
            txtTelefono.Text = fila(0).Item("fono_clie").ToString
            txtContacto.Text = fila(0).Item("nom_cont").ToString
            'almacenamos el tipo de cliente
            TipoCliente = fila(0).Item("cod_tipo").ToString
            TipoFpago = fila(0).Item("cod_fpago").ToString
            cboCliente.SelectedValue = cod_cliente
            cboTipoCliente.SelectedValue = TipoCliente
            cboFormaPago.SelectedValue = Tipofpago

        Catch err As Exception
            MessageBox.Show("Seleccione un Cliente Registrado...", "Cefe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            reiniciaCliente()
            'dsArticulo.Clear()
        End Try
    End Sub

    Private Sub dataDetalle_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataDetalle.CellEndEdit

        Dim lcantidad, lprecio, lneto As Decimal, mIngreso As New Ingreso, mSalida As New Salida
        Dim cod_art As String
        cod_art = dataDetalle("cod_Art", dataDetalle.CurrentRow.Index).Value

        'validamos el ingreso de cantidades no nulas
        If IsDBNull(dataDetalle("cantidad", dataDetalle.CurrentRow.Index).Value) Or IsDBNull(dataDetalle("precio", dataDetalle.CurrentRow.Index).Value) Or IsDBNull(dataDetalle("neto", dataDetalle.CurrentRow.Index).Value) Then
            dataDetalle("precio", dataDetalle.CurrentRow.Index).Value = 0
            lprecio = 0
            dataDetalle("neto", dataDetalle.CurrentRow.Index).Value = 0
            lneto = 0
        End If
        If dataDetalle.CurrentCell.ColumnIndex = dataDetalle.Columns("cantidad").Index Then
            If IsDBNull(dataDetalle("cantidad", dataDetalle.CurrentRow.Index).Value) Or dataDetalle("cantidad", dataDetalle.CurrentRow.Index).Value = 0 Then
                lcantidad = 1
                dataDetalle("cantidad", dataDetalle.CurrentRow.Index).Value = 1
            Else
                lcantidad = dataDetalle("cantidad", dataDetalle.CurrentRow.Index).Value
                lprecio = dataDetalle("precio", dataDetalle.CurrentRow.Index).Value
                lneto = Round(lcantidad * lprecio, pDecimales)
                dataDetalle("neto", dataDetalle.CurrentRow.Index).Value = lneto
            End If
            'txtBuscar.Focus()
            'dataDetalle.ClearSelection()
        End If
        If dataDetalle.CurrentCell.ColumnIndex = dataDetalle.Columns("precio").Index Then
            If IsDBNull(dataDetalle("precio", dataDetalle.CurrentRow.Index).Value) Then
                lprecio = 0
                dataDetalle("precio", dataDetalle.CurrentRow.Index).Value = 0
            Else
                lprecio = dataDetalle("precio", dataDetalle.CurrentRow.Index).Value
                lcantidad = dataDetalle("cantidad", dataDetalle.CurrentRow.Index).Value
                lneto = Round(lcantidad * lprecio, pDecimales)
                dataDetalle("neto", dataDetalle.CurrentRow.Index).Value = lneto
            End If
            'txtBuscar.Focus()
            'dataDetalle.ClearSelection()
        End If
        If dataDetalle.CurrentCell.ColumnIndex = dataDetalle.Columns("neto").Index Then
            If IsDBNull(dataDetalle("neto", dataDetalle.CurrentRow.Index).Value) Then
                lneto = 0
                dataDetalle("neto", dataDetalle.CurrentRow.Index).Value = 0
            Else
                lneto = dataDetalle("neto", dataDetalle.CurrentRow.Index).Value
                lcantidad = dataDetalle("cantidad", dataDetalle.CurrentRow.Index).Value
                lprecio = Round(lneto / lcantidad, 10)
                dataDetalle("precio", dataDetalle.CurrentRow.Index).Value = lprecio
            End If
        End If
        'lneto = Round(lcantidad * lprecio, pDecimales)
        'dataDetalle("neto", dataDetalle.CurrentRow.Index).Value = lneto
        calculaTotal()


    End Sub

    Private Sub txtRuc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRuc.KeyPress
        If (Not Char.IsNumber(e.KeyChar) And e.KeyChar <> vbBack) Then
            e.Handled = True
        End If

    End Sub


    Private Sub txtRuc_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtRuc.Validating
        fcod_clie = txtRuc.Text
        If Microsoft.VisualBasic.Len(fcod_clie) > 0 Then
            UbicarCliente(fcod_clie)
        End If
    End Sub

    Private Sub cboCliente_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboCliente.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtRuc.Focus()
        End If
    End Sub

    Private Sub cboCliente_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboCliente.Validating
        If cboCliente.SelectedValue <> "" Then
            Dim fcod_clie As String = cboCliente.SelectedValue.ToString
            UbicarCliente(fcod_clie)
        End If

    End Sub

    Private Sub cboTipoCliente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoCliente.SelectedIndexChanged
        If Not estacargando Then
            filtraArticulos()
        End If
    End Sub

    Sub coloreafilas()
        If dataDetalle.RowCount() > 0 Then
            For Each row As DataGridViewRow In dataDetalle.Rows

                Dim cadena As String = IIf(IsDBNull(row.Cells("obs").Value), "", row.Cells("obs").Value)
                If cadena.Length > 0 Then
                    row.Cells("obs").Style.BackColor = Color.Red
                    row.Cells("obs").Style.ForeColor = Color.Red
                Else
                    row.Cells("obs").Style.BackColor = Color.Green
                End If
            Next
        End If

    End Sub
    Private Sub dataDetalle_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dataDetalle.DoubleClick
        If dataDetalle.CurrentCell.ColumnIndex = dataDetalle.Columns("obs").Index Then
            Dim ifila As Integer = dataDetalle.CurrentRow.Index
            Dim IsFormCargado As Boolean = False
            Dim obs As String
            Dim mForm As Form
            For Each mForm In principal.MdiChildren
                If mForm.Name = "p_notas" Then
                    If mForm.WindowState = FormWindowState.Minimized Then
                        mForm.WindowState = FormWindowState.Normal
                    Else
                        mForm.BringToFront()
                    End If
                    IsFormCargado = True
                    Exit For
                End If
            Next
            mForm = Nothing

            If IsFormCargado = False Then
                p_notas.MdiParent = principal
                p_notas.lblnotas.Text = p_notas.lblnotas.Text + " a :" + dataDetalle("nom_art", ifila).Value
                If IsDBNull(dataDetalle("obs", ifila).Value) Then
                    obs = ""
                Else
                    obs = dataDetalle("obs", ifila).Value
                End If
                p_notas.datosNotas(obs, "venta")
                p_notas.txtnotas.Focus()
                p_notas.Show()
            Else
                p_notas.lblnotas.Text = p_notas.lblnotas.Text + " a :" + dataDetalle("nom_art", ifila).Value
                p_notas.Activate()
            End If
            p_notas.txtnotas.Focus()
        Else
            If dataDetalle.CurrentCell.ColumnIndex <> dataDetalle.Columns("igv").Index Then
                If tipoProceso = "A" Then
                    Dim mPedido As New pedido, rpta As Integer
                    If mPedido.yaFacturado(nroOperacion) Then
                        MessageBox.Show("¡El Pedido se encuentra Facturado!" & Chr(13) & "No Es Posible Eliminarlo...", "VENTAS", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Else
                        rpta = MessageBox.Show("Esta Seguro de Eliminar el ITEM Seleccionado" + Chr(13) + "Este Proceso es Irreversible...", "VENTAS", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2)
                        If rpta = 6 Then
                            If Not IsDBNull(dataDetalle("orden", dataDetalle.CurrentRow.Index).Value) Then
                                Dim nroOrden As Integer = dataDetalle("orden", dataDetalle.CurrentRow.Index).Value
                                mPedido.eliminaDetalle(nroOperacion, nroOrden)
                            End If
                            Dim mfila As DataRow = dtDetalle.Rows(dataDetalle.CurrentRow.Index)
                            dtDetalle.Rows.Remove(mfila)
                            calculaTotal()
                        End If
                    End If
                Else
                    MessageBox.Show("¡EL Documento se encuentra Facturado!" & Chr(13) & "No Es Posible Eliminarlo...", "VENTAS", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                End If
            End If
        End If
    End Sub
    Sub AgregaObservacion(ByVal obs As String)
        dataDetalle(dataDetalle.CurrentCell.ColumnIndex, dataDetalle.CurrentRow.Index).Value = obs
        dataDetalle.Focus()
    End Sub

    Private Sub optDolares_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optDolares.CheckedChanged
        muestraTCActual()
    End Sub
    Sub muestraTCActual()
        If optDolares.Checked = True And prTC = 0 Then
            MessageBox.Show("Falta establecer el Tipo de Cambio", "VENTAS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            optMoneda.Checked = True
        End If
        lblTC.Text = "Tipo Cambio: " & prTC
        If optMoneda.Checked = True Then
            lblMensaje.Text = "Moneda SOLES - Tipo Cambio: " & prTC
        Else
            lblMensaje.Text = "Moneda DOLARES - Tipo Cambio: " & prTC
        End If


    End Sub
    Private Sub mcFechaVenta_DateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles mcFechaVenta.DateChanged
        Dim mTcambio As New TipoCambio
        prTC = mTcambio.recupera(mcFechaVenta.SelectedDate)
        muestraTCActual()
    End Sub

    Sub GeneraNumDocumento()
        Dim msalida As New Salida, mguia As New Guia
        txtNroDocumento.Text = msalida.maxNroSalida(cboDocumento.SelectedValue, txtSerDocumento.Text)
        txtNroGuia.Text = mguia.maxNroGuia(txtSerGuia.Text)
    End Sub


    Private Sub txtSerDocumento_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSerDocumento.TextChanged
        If Not estacargando Then
            GeneraNumDocumento()
        End If
    End Sub


    Private Sub cboDocumento_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDocumento.SelectedIndexChanged
        If Not estacargando Then
            GeneraNumDocumento()
        End If
    End Sub

    Private Sub dataDetalle_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles dataDetalle.KeyDown
        If e.KeyCode = Keys.Enter Then
            dataDetalle.ClearSelection()
            txtTelefono.Focus()
        End If
    End Sub



    Private Sub cboCliente_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboCliente.SelectedIndexChanged
        If Not estacargando Then
            filtraArticulos()
            muestraDireccion(cboCliente.SelectedValue)
        End If

    End Sub

    Private Sub dataDetalle_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataDetalle.CellContentClick

    End Sub

    Private Sub txtNroDocumento_TextChanged(sender As Object, e As EventArgs) Handles txtNroDocumento.TextChanged

    End Sub

    Sub muestraDireccion(ByVal cod_cliente As String)
        dsDireccion.Clear()
        Dim daDireccion As New MySqlDataAdapter
        Dim comDireccion As New MySqlCommand("select '00' as cod_sucursal,dir_clie from cliente where activo=1 and cod_clie='" & cod_cliente & "'" _
                        & " union select cod_sucursal,dir_sucursal from cliente_sucursal where cod_clie='" & cod_cliente & "'", dbConex)
        daDireccion.SelectCommand = comDireccion
        daDireccion.Fill(dsDireccion, "direccion")
        With cboDirEntrega
            .DataSource = dsDireccion.Tables("direccion")
            .DisplayMember = dsDireccion.Tables("direccion").Columns("dir_clie").ToString
            .ValueMember = dsDireccion.Tables("direccion").Columns("cod_sucursal").ToString
            If dsDireccion.Tables("direccion").Rows.Count > 0 Then
                cboDirEntrega.Enabled = True
                .SelectedIndex = 0
            Else
                cboDirEntrega.Enabled = False
                .SelectedIndex = -1
            End If
        End With
    End Sub

    Private Sub dataPedidos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataPedidos.CellContentClick

    End Sub

    Private Sub cboArticulo_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles cboArticulo.KeyDown
        If e.KeyCode = Keys.Enter Then
            agregaitem(cboArticulo.SelectedValue)
        End If
    End Sub


    Private Sub txtSerGuia_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtSerGuia.TextChanged
        If Not estacargando Then
            GeneraNumDocumento()
        End If
    End Sub

    Private Sub dataPedidos_DoubleClick(sender As Object, e As EventArgs) Handles dataPedidos.DoubleClick
        Dim importe As Decimal = 0

        Dim cod_alma As String = cboAlmacen.SelectedValue.ToString
        Dim ifila As Integer = dataPedidos.CurrentRow.Index
        cargaArticulos(cod_alma, "", "00", "000000")
        numOrden = dataPedidos("num_orden", ifila).Value
        importe = dataPedidos("importe", ifila).Value
        agregaitem("000000")
        If dataDetalle.RowCount > 0 Then
            Dim row As DataGridViewRow = dataDetalle.CurrentRow
            row.Cells(7).Value = importe
            row.Cells(9).Value = importe
            row.Cells(10).Value = numOrden
            calculaTotal()
        Else
            MessageBox.Show("Almacen no tiene Catalogo...", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ep.SetError(cboAlmacen, "Seleccione Almacen")
            cboAlmacen.Focus()
        End If


    End Sub

    Private Sub txtNroDocumento_ModifiedChanged(sender As Object, e As EventArgs) Handles txtNroDocumento.ModifiedChanged

    End Sub
End Class
