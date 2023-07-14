Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Math
Imports libreriaClases
Public Class p_pedido
    Private dsAlmacen_o As New DataSet
    Private dsAlmacen_d As New DataSet
    Private dsOrigen As New DataSet
    Private dsArea As New DataSet
    Private dsVendedor As New DataSet
    Private dtVendedor As New DataTable("vendedor")
    Private dsTipoCliente As New DataSet
    Private dtTipoCliente As New DataTable("tipoCliente")
    Private dsCliente As New DataSet
    Private dtCliente As New DataTable("cliente")
    Private dsProveedor As New DataSet
    Private dtProveedor As New DataTable("Proveedor")
    Private dsFPago As New DataSet
    Private dtFPago As New DataTable("formaPago")
    Private dsAlmacen As New DataSet
    Private dtAlmacen As New DataTable("almacen")
    Private dsArticulo As New DataSet
    Private dtArticulo As New DataTable("articulo")
    Private dsPedido As New DataSet
    Private dtDetalle As New DataTable("detalle")
    Private dsSaldos As New DataSet
    Private dsTipoPedido As New DataSet
    Private dsTipoHorario As New DataSet
    Private dsResponsable As New DataSet
    Private dsEstados As New DataSet
    Private estaCargando As Boolean = True
    Private cCatalogoOrigen As String = "", cCatalogoDestino As String = ""
    'variable que almacena la operacion en proceso
    Private nroOperacion As Integer = 0
    'Variable donde indicamos el tipo de proceso - A=Añadir - E=Edicion
    Private tipoProceso As Char = "A"
    'para validar el separador decimal
    Private sepDecimal As Char
    'para determinar el tipo de cliente y en funcion a ello los precios
    Private tipoCliente, tipoFpago As String
    Private esCopia As Boolean = False

    Private Sub p_pedido_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        principal.mp_pedidos.Enabled = True
    End Sub
    Private Sub p_pedido_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        estableceFechaProceso()
        establececorrelativo()
        cargaAlmacenes()

        If dsAlmacen_o.Tables("almacen").Rows.Count > 0 Then
            cboOrigen.SelectedIndex = 0
        End If

        'verificamos si los precios ya tienen el igv
        'If pPreciosIncIGV Then
        '    chkIGV.CheckState = CheckState.Checked
        'Else
        chkIGV.CheckState = CheckState.Unchecked
        'End If
        'capturamos el separador decimal
        sepDecimal = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        'dataset articulo, la carga se realiza al seleccionar el cliente, ello por los precios
        dsArticulo.Tables.Add(dtArticulo)

        'Responsable
        cmbresponsable()



        'dataset TIPO PEDIDO
        Dim daTipPedido As New MySqlDataAdapter
        Dim comPed As New MySqlCommand("SELECT cod_recurso,dsc_recurso FROM tipo_recurso where cod_tabla='tip_pedido'and activo=1", dbConex)
        daTipPedido.SelectCommand = comPed
        daTipPedido.Fill(dsTipoPedido, "TipoPedido")
        With cboPedido
            .DataSource = dsTipoPedido.Tables("TipoPedido")
            .DisplayMember = dsTipoPedido.Tables("TipoPedido").Columns("dsc_recurso").ToString
            .ValueMember = dsTipoPedido.Tables("TipoPedido").Columns("cod_recurso").ToString
            .SelectedIndex = 0
        End With

        'dataset ESTADOS
        Dim daEstados As New MySqlDataAdapter
        Dim comEst As New MySqlCommand("SELECT cod_recurso,dsc_recurso FROM tipo_recurso where cod_tabla='tip_epedido'and activo=1", dbConex)
        daEstados.SelectCommand = comEst
        daEstados.Fill(dsEstados, "Estados")
        With CboEstado
            .DataSource = dsEstados.Tables("Estados")
            .DisplayMember = dsEstados.Tables("Estados").Columns("dsc_recurso").ToString
            .ValueMember = dsEstados.Tables("Estados").Columns("cod_recurso").ToString
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
        'dataset forma de pago
        dsFPago.Tables.Add(dtFPago)
        Dim daFPago As New MySqlDataAdapter
        Dim comFPago As New MySqlCommand("select cod_fpago,nom_fpago from forma_pago where activo=1", dbConex)
        daFPago.SelectCommand = comFPago
        daFPago.Fill(dsFPago, "forma_pago")
        With cboFPago
            .DataSource = dsFPago.Tables("forma_pago")
            .DisplayMember = dsFPago.Tables("forma_pago").Columns("nom_fpago").ToString
            .ValueMember = dsFPago.Tables("forma_pago").Columns("cod_fpago").ToString
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.ListItems
            .SelectedIndex = 0
        End With
        dt_horaEntrega.Value = "07:00:00"
        estructurapedido()

        muestraSaldos()
        estaCargando = False
        modoAñadir()
        txtNroPedido.Focus()

    End Sub

    Sub cmbresponsable()
        'dataset RESPONSABLE
        Dim daResponsable As New MySqlDataAdapter
        Dim chkresp As Boolean = If(ChkResppn.Checked = True, True, False)
        Dim query As String = "SELECT cuenta,user FROM usuario where activo " & IIf(chkresp = False, " order by user ", " and cuenta='" & pCuentaUser & "' ")
        Dim comRes As New MySqlCommand(query, dbConex)
        daResponsable.SelectCommand = comRes
        daResponsable.Fill(dsResponsable, "responsable")
        With CboResponsable
            .DataSource = dsResponsable.Tables("responsable")
            .DisplayMember = dsResponsable.Tables("responsable").Columns("user").ToString
            .ValueMember = dsResponsable.Tables("responsable").Columns("cuenta").ToString
            .SelectedIndex = 0
        End With
    End Sub

    Sub estructurapedido()
        dsPedido = pedido.dsPedido
        dtDetalle = dsPedido.Tables("detalle")
        With dataDetalle
            .DataSource = dsPedido.Tables("detalle")
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_art").HeaderText = "COD"
            .Columns("cod_art").Width = 50
            .Columns("cod_art").ReadOnly = True
            .Columns("cod_art").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("nom_art").HeaderText = "DESCRIPCION"
            .Columns("nom_art").Width = 320
            .Columns("nom_art").ReadOnly = True
            .Columns("nom_uni").HeaderText = "UND"
            .Columns("nom_uni").Width = 50
            .Columns("nom_uni").ReadOnly = True
            .Columns("nom_uni").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cantidad").HeaderText = "CANT."
            .Columns("cantidad").Width = 60
            .Columns("cantidad").ReadOnly = False
            .Columns("cantidad").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cantidad").DefaultCellStyle.Format = "N" & pDecimales
            .Columns("precio").HeaderText = "PRECIO"
            .Columns("precio").Width = 70
            .Columns("precio").ReadOnly = True
            .Columns("precio").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("precio").DefaultCellStyle.Format = "N" & pDecimales
            .Columns("afecto_igv").HeaderText = "IGV"
            .Columns("afecto_igv").Width = 30
            .Columns("afecto_igv").ReadOnly = True
            .Columns("afecto_igv").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("neto").HeaderText = "NETO"
            .Columns("neto").Width = 70
            .Columns("neto").ReadOnly = True
            .Columns("neto").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("neto").DefaultCellStyle.Format = "N" & pDecimales
            .Columns("obs").HeaderText = "OBS"
            .Columns("obs").Width = 40
            .Columns("obs").ReadOnly = False
            .Columns("obs").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("foto").Visible = False
            .Columns("saldo").Visible = False
            .Columns("estado").Visible = False
            .Columns("operacion").Visible = False
            .Columns("orden").Visible = False
            .Columns("comi_v").Visible = False
            .Columns("comi_jv").Visible = False
            .Columns("igv").Visible = False
        End With
    End Sub
    Sub cargaAlmacenes()
        'dataset almacen origen/destino
        Dim daAlmacen_o As New MySqlDataAdapter
        Dim daAlmacen_d As New MySqlDataAdapter
        Dim cadena, cadena_dest As String
        If pAlmaUser = "0000" Then
            cadena = "select cod_alma,nom_alma from almacen where activo=1" _
                                  & " and (origenTrans) order by nom_alma"
            cadena_dest = "select distinct almacen.cod_alma,nom_alma" _
                                & " from almacen left join area on almacen.cod_alma=area.cod_alma" _
                                & " where almacen.activo=1 and ((almacen.destinoTrans) or (area.destinoTrans))" _
                                & " order by nom_alma"
        Else
            cadena = "select distinct almacen.cod_alma,nom_alma" _
                                             & " from almacen left join area on almacen.cod_alma=area.cod_alma" _
                                             & " where almacen.activo=1 and ((almacen.destinoTrans) or (area.destinoTrans))" _
                                             & " order by nom_alma"
            cadena_dest = "select distinct almacen.cod_alma,nom_alma" _
                                & " from almacen left join area on almacen.cod_alma=area.cod_alma" _
                                & " left join usuario_almacen u on u.cod_alma=almacen.cod_alma " _
                                & " where almacen.activo=1 and ((almacen.destinoTrans) or (area.destinoTrans))" _
                                & " and u.cuenta= '" & pCuentaUser & "'" _
                                & " order by nom_alma"
        End If
        Dim comAlmacen_o As New MySqlCommand(cadena, dbConex)
        Dim comAlmacen_d As New MySqlCommand(cadena_dest, dbConex)
        daAlmacen_o.SelectCommand = comAlmacen_o
        daAlmacen_d.SelectCommand = comAlmacen_d
        daAlmacen_o.Fill(dsAlmacen_o, "almacen")
        daAlmacen_d.Fill(dsAlmacen_d, "almacen")

        With cboOrigen
            .DataSource = dsAlmacen_o.Tables("almacen")
            .DisplayMember = dsAlmacen_o.Tables("almacen").Columns("nom_alma").ToString
            .ValueMember = dsAlmacen_o.Tables("almacen").Columns("cod_alma").ToString
            .SelectedIndex = -1
        End With
        With cboDestino
            .DataSource = dsAlmacen_d.Tables("almacen")
            .DisplayMember = dsAlmacen_d.Tables("almacen").Columns("nom_alma").ToString
            .ValueMember = dsAlmacen_d.Tables("almacen").Columns("cod_alma").ToString
            .SelectedIndex = -1
        End With
        muestraArea(cboDestino.SelectedValue)
    End Sub
    Sub muestraArea(ByVal cod_alma As String)
        dsArea.Clear()
        Dim daArea As New MySqlDataAdapter
        Dim comArea As New MySqlCommand("select cod_area,nom_area from area where activo=1" _
                        & " and (destinoTrans) and cod_alma='" & cod_alma & "' order by nom_area", dbConex)
        daArea.SelectCommand = comArea
        daArea.Fill(dsArea, "area")
        With cboArea
            .DataSource = dsArea.Tables("area")
            .DisplayMember = dsArea.Tables("area").Columns("nom_area").ToString
            .ValueMember = dsArea.Tables("area").Columns("cod_area").ToString
            If dsArea.Tables("area").Rows.Count > 0 Then
                ' If _nroTransferencia = 0 Then
                lblArea.Enabled = True
                cboArea.Enabled = True
                    .SelectedIndex = 0
                'End If
            Else
                lblArea.Enabled = False
                cboArea.Enabled = False
                .SelectedIndex = -1
            End If
        End With
    End Sub



    Private Sub cboVendedor_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboVendedor.GotFocus
        general.ingresaComboProceso(cboVendedor)
    End Sub
    Private Sub cboVendedor_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboVendedor.LostFocus
        general.saleComboProceso(cboVendedor)
    End Sub
    Private Sub cboVendedor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboVendedor.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboCliente.Focus()
        End If
    End Sub
    Private Sub cboVendedor_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboVendedor.Validating
        Try
            If Microsoft.VisualBasic.Len(cboVendedor.Text) > 0 Then
                Dim lcod As String = cboVendedor.SelectedValue.ToString
            End If
        Catch err As Exception
            MessageBox.Show("Seleccione un Vendedor Registrado...", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cboVendedor.SelectedIndex = -1
            e.Cancel = True
        End Try
    End Sub
    Private Sub cboCliente_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCliente.GotFocus
        general.ingresaComboProceso(cboCliente)
    End Sub
    Private Sub cboCliente_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCliente.LostFocus
        general.saleComboProceso(cboCliente)
    End Sub
    Private Sub cboCliente_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboCliente.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboFPago.Focus()
        End If
    End Sub
    Private Sub cboCliente_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboCliente.Validating
        tipoCliente = ""
        Try
            If Microsoft.VisualBasic.Len(cboCliente.Text) > 0 Then
                Dim lcod As String = cboCliente.SelectedValue.ToString
                Dim fila() As DataRow
                fila = dsCliente.Tables("Cliente").Select("cod_clie ='" & lcod & "'")
                txtRuc.Text = fila(0).Item("cod_clie").ToString
                txtDirEntrega.Text = fila(0).Item("dir_clie").ToString
                txtTelefono.Text = fila(0).Item("fono_clie").ToString
                txtContacto.Text = fila(0).Item("nom_cont").ToString
                'almacenamos el tipo de cliente
                tipoCliente = fila(0).Item("cod_tipo").ToString
                tipoFpago = fila(0).Item("cod_fpago").ToString
                cboTipoCliente.SelectedValue = tipoCliente
                cboFPago.SelectedValue = tipoFpago
            End If
        Catch err As Exception
            MessageBox.Show("Seleccione un Cliente Registrado...", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cboCliente.SelectedIndex = -1
            dsArticulo.Clear()
            e.Cancel = True
        End Try
    End Sub
    Private Sub cboFPago_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboFPago.GotFocus
        general.ingresaComboProceso(cboFPago)
    End Sub
    Private Sub cboFPago_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboFPago.LostFocus
        general.saleComboProceso(cboFPago)
    End Sub
    Private Sub cboFPago_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboFPago.KeyDown
        If e.KeyCode = Keys.Enter Then

        End If
    End Sub
    Private Sub cboFPago_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboFPago.Validating
        Try
            If Microsoft.VisualBasic.Len(cboFPago.Text) > 0 Then
                Dim lcod As String = cboFPago.SelectedValue.ToString
            End If
        Catch err As Exception
            MessageBox.Show("Seleccione una Forma de Pago Registrada...", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cboFPago.SelectedIndex = -1
            e.Cancel = True
        End Try
    End Sub
    Private Sub cmdGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGrabar.Click
        Dim cReg As Integer, continuar As Boolean = True
        continuar = validaGrabacion()

        Try

            If continuar Then
                Dim serPedido, nroPedido, cod_vend, cod_usu, tm As String, fec_ped, fec_ent As Date
                Dim hor_ent As Date
                Dim cod_clie, cod_fpago, cod_almaO, cod_alma, cod_area, cod_estado, cod_pedido, dir_ent, obs As String, nroOrden, inc_igv As Integer

                fec_ped = dt_pedido.Value
                fec_ent = dt_entrega.Value
                hor_ent = dt_horaEntrega.Value
                cod_vend = "00000000"
                'cod_clie = cboCliente.SelectedValue.ToString
                cod_clie = "00000000000"
                'cod_fpago = cboFPago.SelectedValue.ToString
                cod_fpago = "01"
                cod_almaO = cboOrigen.SelectedValue.ToString
                cod_alma = cboDestino.SelectedValue.ToString
                cod_area = cboArea.SelectedValue.ToString
                cod_estado = CboEstado.SelectedValue.ToString
                cod_pedido = cboPedido.SelectedValue.ToString
                cod_usu = CboResponsable.SelectedValue.ToString

                'dir_ent = txtDirEntrega.Text
                dir_ent = "-"
                obs = txtObs.Text
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
                cReg = dataDetalle.RowCount

                Dim mPedido As New pedido
                Dim mcatalogo As New Catalogo

                If tipoProceso = "A" Then 'añadir
                    If cReg > 0 Then
                        Try
                            establececorrelativo()
                            serPedido = txtSerPedido.Text
                            nroPedido = txtNroPedido.Text
                            ' nroOperacion = mPedido.maxOperacion
                            'registramos la cabecera
                            mPedido.insertar(nroOperacion, serPedido, nroPedido, fec_ped, fec_ent, hor_ent, cod_estado, cod_pedido, cod_vend, cod_clie, cod_fpago, cod_almaO, cod_alma, cod_area, dir_ent, obs, inc_igv, tm, cod_usu, pCuentaUser)
                            'registramos el detalle
                            Dim cod_art, observ As String, cant, precio, igv, comi_v, comi_jv As Decimal, I As Integer
                            For I = 0 To cReg - 1
                                cod_art = dataDetalle("cod_art", I).Value
                                cant = dataDetalle("cantidad", I).Value
                                precio = dataDetalle("precio", I).Value
                                    If dataDetalle("afecto_igv", I).Value = False Then
                                        igv = 0
                                    Else
                                        igv = pIGV
                                    End If
                                    comi_v = dataDetalle("comi_v", I).Value
                                comi_jv = dataDetalle("comi_jv", I).Value
                                observ = dataDetalle("obs", I).Value
                                nroOrden = mPedido.maxOrden(nroOperacion)

                                mPedido.insertar_det(nroOperacion, nroOrden, cod_art, cant, precio, igv, comi_v, comi_jv, pCuentaUser, observ)

                            Next
                            'reiniciaControles(True)
                            'reiniciaDatos()
                            'establececorrelativo()
                            dtDetalle.Clear()
                            dataDetalle.ClearSelection()
                            cargaCabecera(nroOperacion)
                            cargaDetalle(nroOperacion, txtSerPedido.Text, txtNroPedido.Text)

                            modoEdicion()


                            'txtSerPedido.Focus()
                            'Catch ex As Exception
                            '     MessageBox.Show(ex.Message)
                            '      '   End Try
                            'Else
                            'Try
                            '  MessageBox.Show("Falta Registrar Artículos...", "Cefe", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            '   dataArticulo.CurrentCell = dataArticulo(1, 1)
                            '    dataArticulo.Focus()

                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                            MessageBox.Show("Revisar Pedido: " & vbCrLf & ex.StackTrace)
                        End Try
                    End If
                    tipoProceso = "E"
                    esCopia = False
                Else 'edicion
                    'mPedido.insertar(nroOperacion, serPedido, nroPedido, fec_ped, fec_ent, hor_ent, cod_estado, cod_pedido, cod_vend, cod_clie, cod_fpago, cod_alma, cod_area, dir_ent, obs, inc_igv, tm, pCuentaUser)
                    mPedido.actualizaCabecera(nroOperacion, fec_ped, fec_ent, hor_ent, cod_pedido, cod_vend, cod_clie, cod_fpago, cod_alma, cod_area, dir_ent, obs, tm, inc_igv, cod_usu)
                    Dim cod_art, observ As String, cant, precio, igv, comi_v, comi_jv As Decimal, I As Integer
                    cReg = dataDetalle.RowCount
                    For I = 0 To cReg - 1
                        cod_art = dataDetalle("cod_art", I).Value
                        cant = dataDetalle("cantidad", I).Value
                        precio = dataDetalle("precio", I).Value
                        If dataDetalle("afecto_igv", I).Value = False Then
                            igv = 0
                        Else
                            igv = pIGV
                        End If
                        comi_v = dataDetalle("comi_v", I).Value
                        comi_jv = dataDetalle("comi_jv", I).Value
                        observ = dataDetalle("obs", I).Value
                        If dataDetalle("estado", I).Value = "New" Then
                            nroOrden = mPedido.maxOrden(nroOperacion)
                            mPedido.insertar_det(nroOperacion, nroOrden, cod_art, cant, precio, igv, comi_v, comi_jv, pCuentaUser, observ)
                        Else
                            nroOrden = dataDetalle("orden", I).Value
                            mPedido.actualizaDetalle(nroOperacion, nroOrden, cant, precio, igv, comi_v, comi_jv, observ)
                        End If
                    Next
                    cargarpedidos()
                    'reiniciaControles(True)
                    ' reiniciaDatos()
                    modoEdicion()
                    'txtSerPedido.Focus()

                End If
                MessageBox.Show("Documento Registrado Correctamente!!...", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            ' Show the exception's message.
            MessageBox.Show(ex.Message)

            MessageBox.Show("Revisar Pedido: " & vbCrLf & ex.StackTrace)
        Finally
            ' This line executes whether or not the exception occurs.

        End Try


    End Sub

    Private Function Bytes_Imagen(ByVal Imagen As Byte()) As Image
        Try
            'si hay imagen
            If Not Imagen Is Nothing Then
                'caturar array con memorystream hacia Bin
                Dim Bin As New IO.MemoryStream(Imagen)
                'con el método FroStream de Image obtenemos imagen
                Dim Resultado As Image = Image.FromStream(Bin)
                'y la retornamos
                Return Resultado
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    'convertir imagen a binario
    Private Function Imagen_Bytes(ByVal Imagen As Image) As Byte()
        'si hay imagen
        If Not Imagen Is Nothing Then
            'variable de datos binarios en stream(flujo)
            Dim Bin As New IO.MemoryStream
            'convertir a bytes
            Imagen.Save(Bin, Imaging.ImageFormat.Jpeg)
            'retorna binario
            Return Bin.GetBuffer
        Else
            Return Nothing
        End If
    End Function
    Sub MuestraFoto(ByVal operacion As Integer, orden As Integer)
        Try
            Dim cad As String, dr As MySqlDataReader, resul As Integer
            cad = "select isnull(foto) as vnul,foto from pedido_det where operacion=" & operacion & " and orden=" & orden & ""
            Dim com As New MySqlCommand(cad, dbConex)
            dr = com.ExecuteReader
            Dim Imag As Byte() = Nothing
            While dr.Read
                resul = dr("vnul")
                If resul = 0 Then
                    Imag = dr("foto")
                    Me.pb_foto.Image = Bytes_Imagen(Imag)
                Else
                    Me.pb_foto.Image = Bytes_Imagen(Imag)
                End If


            End While
            dr.Close()
            dr = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        reiniciaControles(True)
        reiniciaDatos()
        ' modoDeshabilitado()
        establececorrelativo()
        txtNroPedido.Focus()
        esCopia = False
    End Sub
    Private Sub cmdEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEliminar.Click
        Dim mPedido As New pedido
        If mPedido.yaFacturado(nroOperacion) Then
            MessageBox.Show("El Pedido se encuentra Facturado...", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Else
            Dim cad As String
            Dim rpta As Integer
            rpta = MessageBox.Show("¿Esta Seguro de Eliminar el Pedido Seleccionado...?", "SGA", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            If rpta = 6 Then
                If DateDiff(DateInterval.Day, dt_entrega.Value, pFechaSystem) > pDiasModificarPedido Then
                    MessageBox.Show("El pedido exede dias a modificar se prcoedera Anular...", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    cad = "Update pedido set cod_estado='0004' , fac=1 where operacion=" & nroOperacion
                Else
                    cad = "Update pedido set cod_estado='0004' , fac=1 where operacion=" & nroOperacion
                End If


                Dim com As New MySqlCommand(cad, dbConex)
                    com.ExecuteNonQuery()
                    reiniciaControles(True)
                    reiniciaDatos()
                    txtSerPedido.Focus()
                    establececorrelativo()
                End If
            End If
    End Sub
    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        gbp.Visible = True
        bp.Visible = True
        Timer.Enabled = True
        Timer.Start()
        Dim frm As New rptForm
        frm.cargarNotaPedido(nroOperacion)
        frm.MdiParent = principal
        frm.Show()
        Timer.Stop()
        Timer.Enabled = False
        bp.Value = 5
        bp.Visible = False
        gbp.Visible = False
    End Sub

    Private Sub txtNroPedido_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNroPedido.Validating
        Dim ope As Integer, rpta As Integer, lserie As String, lnumero As String
        If Microsoft.VisualBasic.Len(txtSerPedido.Text) > 0 And Microsoft.VisualBasic.Len(txtNroPedido.Text) > 0 Then
            'lserie = Microsoft.VisualBasic.Right("000000" & txtSerPedido.Text, 6)
            lserie = txtSerPedido.Text
            lnumero = Microsoft.VisualBasic.Right("00000000" & txtNroPedido.Text, 8)
            ope = existePedido(lserie, lnumero)
            If ope > 0 Then
                rpta = MessageBox.Show("NºPedido " & lserie & "-" & lnumero &
                " Ya Existe, ¿DESEA MOSTRARLO?", "SGA", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)
                If rpta = 6 Then
                    cargarpedidos()
                    Dim mPedido As New pedido
                    If mPedido.yaFacturado(nroOperacion) Or CboResponsable.SelectedValue <> pCuentaUser Or CboEstado.SelectedValue = "0005" Then
                        If pNivelUser = 0 Then

                        Else
                            dataDetalle.Columns("cantidad").ReadOnly = True
                            modoDeshabilitado()
                            cmdImprimir.Enabled = True
                            cmdCancelar.Enabled = True
                        End If
                    Else
                            dataDetalle.Columns("cantidad").ReadOnly = False
                    End If
                    txtBuscar.Focus()
                Else
                    'como aun no iniciamos el proceso, el nro de operacion es cero
                    reiniciaControles(True)
                    'reiniciaDatos()
                    tipoProceso = "A"
                    'txtSerPedido.Focus()
                End If
            Else
                reiniciaControles(False)
                'reiniciaDatos()
                modoAñadir()
                txtBuscar.Focus()
            End If
        Else
            modoDeshabilitado()
        End If


    End Sub

    Sub cargarpedidos()
        Dim ope As Integer, lserie As String, lnumero As String
        lserie = txtSerPedido.Text
        lnumero = Microsoft.VisualBasic.Right("00000000" & txtNroPedido.Text, 8)
        ope = existePedido(lserie, lnumero)
        reiniciaControles(False)
        reiniciaDatos()
        'cargamos los datos
        cargaCabecera(ope)
        cargaDetalle(ope, txtSerPedido.Text, txtNroPedido.Text)
        dataDetalle.ClearSelection()
        modoEdicion()
        'almacenamos el nro de operacion recuperado
        nroOperacion = ope
        'indicamos el tipo de proceso
        tipoProceso = "E"
    End Sub
    Sub calculaTotal()
        Dim nroReg As Integer = 0, I As Integer = 0
        Dim nTotal As Decimal = 0, nSTotal As Decimal = 0
        Dim limp As Decimal = 0, nTotal_afecto As Decimal = 0
        Dim docConIMP As Boolean = True
        'If cboDocumento.SelectedIndex >= 0 Then
        '    docConIMP = dsDocumento.Tables("documento_i").Rows(cboDocumento.SelectedIndex).Item("conIMP").ToString()
        'Else
        '    docConIMP = False
        'End If
        nroReg = dataDetalle.RowCount
        For I = 0 To nroReg - 1
            'nTotal = nTotal + (dataDetalle("cantidad", I).Value * dataDetalle("precio", I).Value)
            nTotal = nTotal + dataDetalle("neto", I).Value
            If dataDetalle("afecto_igv", I).Value = True Then
                'nTotal_afecto = nTotal_afecto + (dataDetalle("cantidad", I).Value * dataDetalle("precio", I).Value)
                nTotal_afecto = nTotal_afecto + dataDetalle("neto", I).Value
            End If
        Next
        lblItems.Text = "Nro de Items. " & Str(I)
        If chkIGV.Checked = True Then
            If docConIMP Then ' cuando el documento esta sujeto a impuesto
                txtTotal.Text = Round(nTotal, pDecimales)
                txtIGV.Text = Round(general.calculaIMPdelTotalAfecto_precioInc(nTotal_afecto), pDecimales)
                txtSubTotal.Text = Round(Round(nTotal, pDecimales) -
                                    Round(general.calculaIMPdelTotalAfecto_precioInc(nTotal_afecto), pDecimales), pDecimales)
            Else
                txtTotal.Text = Round(nTotal, pDecimales)
                txtSubTotal.Text = Round(nTotal, pDecimales)
                txtIGV.Text = 0
            End If
        Else
            If docConIMP Then ' cuando el documento esta sujeto a impuesto
                txtSubTotal.Text = Round(nTotal, pDecimales)
                txtIGV.Text = Round(general.calculaIMPdelTotalAfecto_precioNOInc(nTotal_afecto), pDecimales)
                txtTotal.Text = Round(Round(nTotal, pDecimales) +
                            Round(general.calculaIMPdelTotalAfecto_precioNOInc(nTotal_afecto), pDecimales), pDecimales)
            Else
                txtTotal.Text = Round(nTotal, pDecimales)
                txtSubTotal.Text = Round(nTotal, pDecimales)
                txtIGV.Text = 0
            End If
        End If
    End Sub


    Sub reiniciaControles(ByVal incluirNroPedido As Boolean)
        If incluirNroPedido Then
            txtNroPedido.Text = ""
        End If
        dataDetalle.Columns("cantidad").ReadOnly = False
        cboVendedor.SelectedIndex = 0
        cboCliente.SelectedIndex = -1
        txtRuc.Text = ""
        txtDirEntrega.Text = ""
        txtTelefono.Text = ""
        txtContacto.Text = ""
        estableceFechaProceso()
        cboFPago.SelectedIndex = 0
        cboDestino.SelectedIndex = 0
        txtObs.Text = ""
        txtBuscar.Text = ""
        'If pPreciosIncIGV Then
        '    chkIGV.CheckState = CheckState.Checked
        'Else
        chkIGV.CheckState = CheckState.Unchecked
            'End If
            lblItems.Text = "Nro de Items. 0"
        txtSubTotal.Text = "0.00"
        txtIGV.Text = "0.00"
        txtTotal.Text = "0.00"
    End Sub
    Sub reiniciaDatos()
        nroOperacion = 0
        tipoProceso = "A"
        dtDetalle.Clear()
        dtArticulo.Clear()
    End Sub
    Sub estableceFechaProceso()

        dt_pedido.Value = pFechaSystem
        dt_entrega.Value = pFechaSystem

        dt_pedido.MinDate = pFechaSystem
        dt_entrega.MinDate = pFechaSystem

    End Sub
    Sub establececorrelativo()
        Dim mpedido As New pedido
        nroOperacion = mpedido.maxOperacion
        'txtSerPedido.Text = periodoActivo()
        txtSerPedido.Text = "P01"
        txtNroPedido.Text = nroOperacion
        txtNroPedido.Text = Microsoft.VisualBasic.Right("00000000" & txtNroPedido.Text, 8)
        'modoEdicion()
    End Sub
    Sub ingresaobs()
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
                p_notas.datosNotas(obs, "pedido")
                p_notas.txtnotas.Focus()
                p_notas.Show()
            Else
                p_notas.lblnotas.Text = p_notas.lblnotas.Text + " a :" + dataDetalle("nom_art", ifila).Value
                p_notas.Activate()
            End If
            p_notas.txtnotas.Focus()
        End If
    End Sub
    Sub AgregaObservacion(ByVal obs As String)
        dataDetalle(dataDetalle.CurrentCell.ColumnIndex, dataDetalle.CurrentRow.Index).Value = obs
        dataDetalle.Focus()
    End Sub
    Function validaGrabacion() As Boolean
        Dim valorRetorno As Boolean = True
        'If Microsoft.VisualBasic.Len(txtSerPedido.Text) > 0 Then
        '    If Microsoft.VisualBasic.Len(txtNroPedido.Text) > 0 Then
        '        'If cboVendedor.SelectedIndex >= 0 Then
        '        If cboCliente.SelectedIndex >= 0 Then
        '            If cboFPago.SelectedIndex >= 0 Then
        '                If cboDestino.SelectedIndex >= 0 Then
        '                    If Microsoft.VisualBasic.Len(txtDirEntrega.Text) > 0 Then
        '                        valorRetorno = True
        '                    Else
        '                        ep.SetError(txtDirEntrega, "FALTA DIRECCION DE ENTREGA")
        '                        txtDirEntrega.Focus()
        '                    End If
        '                Else
        '                    ep.SetError(cboFPago, "SELECCIONE ALMACEN")
        '                    cboDestino.Focus()
        '                End If
        '            Else
        '                ep.SetError(cboFPago, "SELECCIONE FORMA DE PAGO")
        '                cboFPago.Focus()
        '            End If
        '        Else
        '            ep.SetError(cboCliente, "SELECCIONE CLIENTE")
        '            cboCliente.Focus()
        '        End If
        '        'Else
        '        '    ep.SetError(cboVendedor, "SELECCIONE VENDEDOR")
        '        '    cboVendedor.Focus()
        '        'End If
        '    Else
        '        ep.SetError(txtNroPedido, "INGRESE NRO DE PEDIDO")
        '        txtNroPedido.Focus()
        '    End If
        'Else
        '    ep.SetError(txtSerPedido, "INGRESE NºSERIE DE PEDIDO")
        '    txtSerPedido.Focus()
        'End If
        Dim creg, I As Integer
        Dim cod_art, nom_art As String

        Dim mcatalogo As New Catalogo
        creg = dataDetalle.RowCount
        If creg > 0 Then
            For I = 0 To creg - 1
                cod_art = dataDetalle("cod_art", I).Value
                nom_art = dataDetalle("nom_art", I).Value
                If mcatalogo.existeCodigoActivo(cod_art) Then

                Else
                    ep.SetError(txtBuscar, "SELECCIONE OTRO ARTICULO")
                    MessageBox.Show("¡EL PRODUCTO " & nom_art & " ESTA DESACTIVADO!" & Chr(13) & "Por favor CAMBIARLO...", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    valorRetorno = False
                End If

            Next

        End If


        Return valorRetorno
    End Function
    Sub modoEdicion()
        cmdGrabar.Enabled = True
        cmdCancelar.Enabled = True
        cmdEliminar.Enabled = True
        cmdImprimir.Enabled = True
        tipoProceso = "E"

    End Sub
    Sub modoAñadir()
        cmdGrabar.Enabled = True
        cmdCancelar.Enabled = True
        cmdEliminar.Enabled = False
        cmdImprimir.Enabled = False
    End Sub
    Sub modoDeshabilitado()
        cmdGrabar.Enabled = False
        cmdCancelar.Enabled = False
        cmdEliminar.Enabled = False
        cmdImprimir.Enabled = False
    End Sub
    Function existePedido(ByVal serie As String, ByVal numero As String) As Integer
        Dim mpedido As New pedido, lOperacion As Integer
        lOperacion = mpedido.existe(serie, numero)
        Return lOperacion
    End Function
    Sub cargaCabecera(ByVal nro_ope As Integer)
        Dim mpedido As New pedido
        Dim dt As New DataTable

        dt = mpedido.recuperaCabecera(nro_ope)
        dt_pedido.Value = dt.Rows(0).Item("fec_ped")
        dt_entrega.Value = dt.Rows(0).Item("fec_ent")
        dt_horaEntrega.Value = dt.Rows(0).Item("hor_ent").ToString
        cboVendedor.SelectedValue = Microsoft.VisualBasic.Trim(dt.Rows(0).Item("cod_vend").ToString)
        tipoCliente = dt.Rows(0).Item("cod_tipo").ToString
        cboCliente.SelectedValue = dt.Rows(0).Item("cod_clie").ToString
        CboEstado.SelectedValue = dt.Rows(0).Item("cod_estado").ToString
        cboPedido.SelectedValue = dt.Rows(0).Item("cod_pedido").ToString
        CboResponsable.SelectedValue = dt.Rows(0).Item("cuenta").ToString
        txtRuc.Text = dt.Rows(0).Item("cod_clie").ToString
        txtTelefono.Text = dt.Rows(0).Item("fono_clie").ToString
        txtContacto.Text = dt.Rows(0).Item("nom_cont").ToString
        cboFPago.SelectedValue = dt.Rows(0).Item("cod_fpago").ToString
        cboDestino.SelectedValue = dt.Rows(0).Item("cod_alma").ToString
        cboArea.SelectedValue = dt.Rows(0).Item("cod_area").ToString
        txtDirEntrega.Text = dt.Rows(0).Item("dir_ent").ToString
        txtObs.Text = dt.Rows(0).Item("obs").ToString
        lblUsuario.Text = dt.Rows(0).Item("cuenta").ToString
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
    Sub cargaDetalle(ByVal nro_ope As Integer, ByVal ser_ped As String, ByVal nro_ped As String)
        Dim mpedido As New pedido, I As Integer
        Dim dt As New DataTable
        dt = mpedido.recuperaDetalle(nro_ope, ser_ped, nro_ped, pDecimales)
        For I = 0 To dt.Rows.Count - 1
            dtDetalle.ImportRow(dt.Rows(I))
        Next
        dataDetalle.DataSource = dsPedido.Tables("detalle")
        calculaTotal()
        dataDetalle.Refresh()
    End Sub
    Sub cargaProduccion(ByVal fecha_prod As Date, ByVal cod_alma As String, ByVal cod_area As String)
        Dim mpedido As New pedido, I As Integer
        Dim dt As New DataTable
        dt = mpedido.recuperaProduccion(fecha_prod, cod_alma, cod_area, pDecimales)
        For I = 0 To dt.Rows.Count - 1
            dtDetalle.ImportRow(dt.Rows(I))
        Next
        dataDetalle.DataSource = dsPedido.Tables("detalle")
        calculaTotal()
        dataDetalle.Refresh()
    End Sub


    Private Sub txtSerPedido_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSerPedido.GotFocus
        'general.ingresaTextoProceso(txtSerPedido)
    End Sub
    Private Sub txtSerPedido_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSerPedido.KeyPress
        'If Not Char.IsNumber(e.KeyChar) And Not (e.KeyChar = ChrW(Keys.Back)) Then
        '    e.KeyChar = ""
        'End If
    End Sub
    Private Sub txtSerPedido_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSerPedido.LostFocus
        'general.saleTextoProceso(txtSerPedido)
        'txtSerPedido.Text = Microsoft.VisualBasic.Right("000000" & txtSerPedido.Text, 6)
    End Sub
    Private Sub txtNroPedido_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNroPedido.GotFocus
        general.ingresaTextoProceso(txtNroPedido)
    End Sub
    Private Sub txtNroPedido_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNroPedido.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not (e.KeyChar = ChrW(Keys.Back)) Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub txtNroPedido_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNroPedido.LostFocus
        general.saleTextoProceso(txtNroPedido)
        If Val(txtNroPedido.Text) > 0 Then
            txtNroPedido.Text = Microsoft.VisualBasic.Right("00000000" & txtNroPedido.Text, 8)
        Else
            txtNroPedido.Text = ""
        End If
    End Sub
    Private Sub txtDirEntrega_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDirEntrega.GotFocus
        general.ingresaTextoProceso(txtDirEntrega)
    End Sub
    Private Sub txtDirEntrega_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDirEntrega.LostFocus
        general.saleTextoProceso(txtDirEntrega)
    End Sub
    Private Sub txtDirEntrega_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDirEntrega.TextChanged
        txtDirEntrega.Text = general.mayusculas(txtDirEntrega, txtDirEntrega.Text)
    End Sub

    Private Sub txtBuscar_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscar.GotFocus
        'general.ingresaTextoProceso(txtBuscar)
        'If Not estaCargando Then
        '    txtBuscar.SelectAll()
        '    dataArticulo.Visible = False
        '    dsArticulo.Clear()
        '    dataArticulo.DataSource = ""
        '    Dim mCatalogo As New Catalogo
        '    Dim mAlmacen As New Almacen
        '    Dim lAlmacen As String = mAlmacen.devuelveAlmacenCatalogo(cboAlmacen.SelectedValue)
        '    dsArticulo = mCatalogo.recuperaCatalogo(lAlmacen, True, False, False, "", False, False, False)
        '    dataArticulo.DataSource = dsArticulo.Tables("articulo").DefaultView
        '    cargaEstructuraArticulos()
        '    filtraArticulos()
        'End If
        general.ingresaTextoProceso(txtBuscar)
    End Sub
    Private Sub txtBuscar_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscar.LostFocus
        general.saleTextoProceso(txtBuscar)
    End Sub
    Private Sub Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer.Tick
        bp.Value = bp.Value + 5
    End Sub
    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
        If Len(txtBuscar.Text) > 0 Then

            cargaArticulos()
            If dataArticulo.RowCount > 0 Then
                dataArticulo.Focus()
                dataArticulo.CurrentCell = dataArticulo("nom_art", 0)
            Else
                txtBuscar.Focus()
            End If
        Else
            txtBuscar.Focus()
        End If
    End Sub

    Sub filtraArticulos(ByVal texto As String)

        dsSaldos.Tables("articulo").DefaultView.RowFilter = "nom_art LIKE '%" & texto & "%'"

        If dataArticulo.RowCount > 0 Then
            dataArticulo.CurrentCell = dataArticulo("nom_art", dataArticulo.CurrentRow.Index)
        End If

    End Sub
    Sub muestraSaldos()
        Dim mCatalogo As New Catalogo
        dsSaldos.Clear()
        'variables para llamar a los reportes
        Dim periodo As String = ""
        Dim es_historial As Boolean = False
        Dim es_xAlmacen As Boolean = IIf(cboOrigen.SelectedIndex >= 0, True, False)
        Dim es_xArea As Boolean = False
        Dim es_xsubgrupo As Boolean = False
        Dim es_xsaldo As Boolean = False
        Dim cAlmacen As String = cboOrigen.SelectedValue
        Dim cArea As String = False
        Dim csubgrupo As String = False
        Dim preciosConIMP As Boolean = False
        'dsSaldos = mCatalogo.recuperaSaldos_Integrado(es_historial, periodo, True, es_xAlmacen, cAlmacen, es_xArea, cArea, es_xsubgrupo, csubgrupo, preciosConIMP, False, "", pDecimales, es_xsaldo, False)

        dsSaldos = mCatalogo.recuperaCatalogoMaestro(cAlmacen, True, False, False, "", False, False, False)
        dataArticulo.DataSource = ""
        dataArticulo.DataSource = dsSaldos.Tables("articulo").DefaultView
        'lblRegistros.Text = "Nº de Registros... " & dataStock.RowCount.ToString
        estructuraSaldos()
    End Sub
    Sub cargaArticulos()

        '  dsArticulo.Clear()

        muestraSaldos()

        estructuraSaldos()


    End Sub
    Sub estructuraSaldos()
        With dataArticulo
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("nom_art").HeaderText = "Descripción"
            .Columns("nom_art").Width = 260
            '.Columns("saldo").HeaderText = "Stock"
            '.Columns("saldo").Width = 60
            '.Columns("saldo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            'Columns("saldo").Visible = False
            .Columns("cod_art").Visible = False
            .Columns("cod_uni").Visible = False
            '.Columns("nom_uni").Visible = False
            '.Columns("precio").Visible = False
            '.Columns("monto").Visible = False
            .Columns("afecto_igv").Visible = False
            .Columns("nom_sgrupo").Visible = False
            .Columns("cant_uni").Visible = False
            '.Columns("es_divisible").Visible = False
            .Columns("pre_ult").Visible = False
            .Columns("maximo").Visible = False
            .Columns("minimo").Visible = False
            .Columns("cod_sgrupo").Visible = False
            .Columns("cod_alma").Visible = False
            '   .Columns("nom_alma").Visible = False
            '.Columns("tm").Visible = False
            '.Columns("tc").Visible = False
            '  .Columns("pre_inc_igv").Visible = False
            ' .Columns("igv").Visible = False
            '.Columns("ingreso").Visible = False
        End With
    End Sub
    Sub cargaEstructuraArticulos()
        With dataArticulo
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("nom_art").HeaderText = "Descripcion"
            .Columns("nom_art").DisplayIndex = 0
            .Columns("nom_art").Width = 205
            .Columns("nom_uni").HeaderText = "Unidad"
            .Columns("nom_uni").DisplayIndex = 1
            .Columns("nom_uni").Width = 65
            .Columns("cod_uni").Visible = False
            .Columns("cod_art").Visible = False
            .Columns("pre_costo").Visible = False
            .Columns("pre_costoMax").Visible = False
            .Columns("pre_costoMin").Visible = False
            .Columns("pre_prom").Visible = False
            .Columns("pre_ult").Visible = False
            .Columns("pre_venta").Visible = False
            .Columns("pre_inc_imp").Visible = False
            .Columns("imp").Visible = False
            .Columns("cant_uni").Visible = False
            .Columns("nom_tart").Visible = False
            .Columns("cod_artExt").Visible = False
            .Columns("cod_artExt1").Visible = False
            .Columns("cod_artExt2").Visible = False
            .Columns("cuenta_v").Visible = False
            .Columns("cuenta_v_c").Visible = False
            .Columns("cuenta_c").Visible = False
            .Columns("cuenta_c_a1").Visible = False
            .Columns("cuenta_c_a2").Visible = False
            .Columns("cuenta_c_a2").Visible = False
            .Columns("cuenta_c_p").Visible = False
            .Columns("maximo").Visible = False
            .Columns("minimo").Visible = False
            .Columns("afecto_igv").Visible = False
            .Columns("nom_sgrupo").Visible = False
            .Columns("activo").Visible = False
            .Columns("cod_sgrupo").Visible = False
            .Columns("esProduccion").Visible = False
            .Columns("cod_alma").Visible = False
        End With
    End Sub

    Private Sub dataArticulo_DoubleClick(sender As Object, e As EventArgs) Handles dataArticulo.DoubleClick
        agregaitem()
    End Sub
    Private Sub dataArticulo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dataArticulo.KeyPress
        If e.KeyChar = Chr(13) Then
            dataDetalle.CurrentCell = dataDetalle("cantidad", dataDetalle.RowCount - 1)
            dataDetalle.Refresh()
            dataDetalle.Focus()
        End If
    End Sub
    Private Sub dataArticulo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dataArticulo.LostFocus
        dataArticulo.ClearSelection()
    End Sub
    Private Sub dataArticulo_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles dataArticulo.PreviewKeyDown
        If e.KeyCode = Keys.Enter Then
            agregaitem()

        End If

    End Sub

    Sub agregaitem()
        'Dim mPedido As New pedido
        'If mPedido.yaFacturado(nroOperacion) Then
        '    MessageBox.Show("¡El Pedido se encuentra Facturado!" & Chr(13) & "No Es Posible Modicarlo...", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        'Else
        If dataArticulo.RowCount() > 0 Then
            Dim fila_bus() As DataRow
            Dim fila As DataRow
            Dim codigo As String
            codigo = dataArticulo.Item("nom_art", dataArticulo.CurrentRow.Index).Value
            fila_bus = dtDetalle.Select("nom_art = '" & codigo & "'")

            If fila_bus.Length > 0 Then
                MessageBox.Show("¡EL PRODUCTO " & codigo & " YA EXISTE!" & Chr(13) & "Por favor Verifique...", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Else
                fila = dtDetalle.NewRow

                fila.Item("cod_art") = dataArticulo.Item("cod_art", dataArticulo.CurrentRow.Index).Value
                fila.Item("nom_art") = dataArticulo.Item("nom_art", dataArticulo.CurrentRow.Index).Value
                fila.Item("nom_uni") = dataArticulo.Item("nom_uni", dataArticulo.CurrentRow.Index).Value
                fila.Item("precio") = dataArticulo.Item("pre_ult", dataArticulo.CurrentRow.Index).Value
                fila.Item("cantidad") = 1
                fila.Item("neto") = fila.Item("cantidad") * fila.Item("precio")
                fila.Item("afecto_igv") = dataArticulo.Item("afecto_igv", dataArticulo.CurrentRow.Index).Value
                If dataArticulo.Item("afecto_igv", dataArticulo.CurrentRow.Index).Value = True Then
                    fila.Item("igv") = pIGV
                Else
                    fila.Item("igv") = 0
                End If
                'fila.Item("comi_v") = dataArticulo.Item("comi_v", dataArticulo.CurrentRow.Index).Value
                'fila.Item("comi_jv") = dataArticulo.Item("comi_jv", dataArticulo.CurrentRow.Index).Value
                fila.Item("comi_v") = 0
                fila.Item("comi_jv") = 0
                fila.Item("obs") = ""

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
        End If
    End Sub

    Sub eliminaitem()
        Dim rpta As Integer
        Dim mPedido As New pedido

        If esCopia Then


            rpta = MessageBox.Show("Esta Seguro de Eliminar el ITEM Seleccionado" + Chr(13) + "Este Proceso es Irreversible...", "SGA", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2)
            If rpta = 6 Then
                If Not IsDBNull(dataDetalle("orden", dataDetalle.CurrentRow.Index).Value) Then
                    Dim nroOrden As Integer = dataDetalle("orden", dataDetalle.CurrentRow.Index).Value
                    'mPedido.eliminaDetalle(nroOperacion, nroOrden)
                    Dim mfila As DataRow = dtDetalle.Rows(dataDetalle.CurrentRow.Index)
                    dtDetalle.Rows.Remove(mfila)
                End If


            End If


        Else

            'If mPedido.yaFacturado(nroOperacion) Or CboResponsable.SelectedValue <> pCuentaUser Then
            If mPedido.yaFacturado(nroOperacion) Then
                MessageBox.Show("DETALLE PEDIDOS" & Chr(13) & "No Es Posible Eliminarlo...", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Else
                rpta = MessageBox.Show("Esta Seguro de Eliminar el ITEM Seleccionado" + Chr(13) + "Este Proceso es Irreversible...", "SGA", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2)
                If rpta = 6 Then
                    If Not IsDBNull(dataDetalle("orden", dataDetalle.CurrentRow.Index).Value) Then
                        Dim nroOrden As Integer = dataDetalle("orden", dataDetalle.CurrentRow.Index).Value
                        mPedido.eliminaDetalle(nroOperacion, nroOrden)
                        Dim mfila As DataRow = dtDetalle.Rows(dataDetalle.CurrentRow.Index)
                        dtDetalle.Rows.Remove(mfila)
                    End If


                End If
            End If

        End If
        calculaTotal()



    End Sub


    Private Sub validar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        'obtenemos el indice de la columna
        If dataDetalle.RowCount > 0 Then
            Dim columna As Integer = dataDetalle.CurrentCell.ColumnIndex
            If columna = dataDetalle.Columns("cantidad").Index Or columna = dataDetalle.Columns("precio").Index Then
                If Not Char.IsNumber(e.KeyChar) And Not (e.KeyChar = ChrW(Keys.Back)) And Not (e.KeyChar.Equals(sepDecimal)) Then
                    e.KeyChar = ""
                End If
                txtBuscar.Focus()
            End If

        End If
    End Sub
    Function DevulveCantidadArtRel(ByVal cod_Art As String, ByVal cCatalogoD As String,
         ByVal cantidad As Decimal, ByVal costo As Decimal) As Decimal
        Dim mAlmacen As New Almacen, mUnidad As New Unidad, mcatalogo As New Catalogo
        Dim cod_artrel, cod_uniRel As String
        Dim ncantidad, ncosto, cant_uniRel As Decimal
        Dim cant_uni As Decimal = mUnidad.devCantUnidad(cod_Art)
        cod_artrel = mAlmacen.devuelveCodigoArtRelacionado(cod_Art, cCatalogoD)
        If Len(cod_artrel) > 0 Then
            cod_uniRel = mUnidad.devuelveUnidad(cod_artrel)
            cant_uniRel = mUnidad.devuelveCantUnidad(cod_uniRel)
            If mcatalogo.existeEnLimpios(cod_artrel) Then
                cod_artrel = mcatalogo.devuelveCodigoLimpio(cod_artrel)
                ncantidad = cantidad * mcatalogo.devuelveCantLimpio(cod_artrel)
                ncosto = cantidad * costo / ncantidad
            Else
                ncantidad = cantidad
                ncosto = costo
            End If
            If cant_uni = cant_uniRel Then
                ncantidad = ncantidad
                ncosto = ncosto
            Else
                ncantidad = (cantidad * cant_uni) / cant_uniRel
                ncosto = (costo / cant_uni) * cant_uniRel
            End If
        End If
        Return ncantidad
    End Function
    Function esEditable() As Boolean
        Dim lserie, lnumero As String, lfechaIng As Date
        Dim existe As Boolean
        'lserie = Microsoft.VisualBasic.Right("000" & txtSerPedido.Text, 3)
        lserie = txtSerPedido.Text
        lnumero = Microsoft.VisualBasic.Right("00000000" & txtNroPedido.Text, 8)
        Dim mPedido As New pedido

        If existe Then
            lfechaIng = mPedido.devuelveFechaIngreso(lserie, lnumero)
            If lfechaIng.AddDays(pDiasModificarIngreso) > pFechaSystem Then
                Return True
            Else
                Return False
            End If
        Else
            Return True
        End If



    End Function
    Private Sub chkIGV_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkIGV.CheckedChanged
        calculaTotal()
    End Sub


    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged
        If Not estaCargando Then
            filtraArticulos(txtBuscar.Text)
        End If
    End Sub

    Private Sub cboCliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCliente.SelectedIndexChanged
        If Not estaCargando Then
            filtraArticulos(txtBuscar.Text)
            'muestraDireccion(cboCliente.SelectedValue)
        End If
    End Sub

    Private Sub cboTipoCliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoCliente.SelectedIndexChanged
        If Not estaCargando Then
            filtraArticulos(txtBuscar.Text)
        End If
    End Sub

    Private Sub cboOrigen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboOrigen.SelectedIndexChanged
        If Not estaCargando Then
            cCatalogoOrigen = ""
            If cboOrigen.SelectedIndex <> -1 Then
                Dim mAlmacen As New Almacen
                cCatalogoOrigen = mAlmacen.devuelveAlmacenCatalogo(cboOrigen.SelectedValue)

            End If
        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        reiniciaDatos()
        cargaProduccion(dt_pedido.Value, cboDestino.SelectedValue, cboArea.SelectedValue)
    End Sub



    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles cmdCopiar.Click
        reiniciaControles(False)
        'reiniciaDatos()
        tipoProceso = "A"
        esCopia = True
        'txtSerPedido.Focus()
        establececorrelativo()
        modoAñadir()
        CboEstado.SelectedValue = "0001"

        'txtNroPedido.Focus()
    End Sub



    Private Sub SimpleButton1_Click_1(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim vImagen As System.Drawing.Image
        vImagen = Clipboard.GetImage
        pb_foto.Image = vImagen
    End Sub


    Private Sub cboDestino_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDestino.SelectedIndexChanged
        If Not estaCargando Then
            cCatalogoDestino = ""
            If cboDestino.SelectedIndex <> -1 Then
                Dim mAlmacen As New Almacen
                cCatalogoDestino = mAlmacen.devuelveAlmacenCatalogo(cboDestino.SelectedValue)
                muestraArea(cboDestino.SelectedValue)

            End If
        End If
    End Sub

    Private Sub cmdExaminar_Click(sender As Object, e As EventArgs) Handles cmdExaminar.Click
        Dim oFD As New OpenFileDialog, mFile As String
        With oFD
            .Title = "Seleccionar fichero"
            .Multiselect = False
            '.Filter = "Ficheros de texto (*.txt;*.ini)|*.txt;*.ini" & _
            '          "|Todos los ficheros (*.*)|*.*"
            .Filter = "Archivo de Imagen (*.jpg)|*.jpg"
            If .ShowDialog = System.Windows.Forms.DialogResult.OK Then
                mFile = .FileName
                Me.pb_foto.Image = Image.FromFile(mFile)
            Else
                mFile = ""
            End If

        End With
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Dim mPedido As New pedido
        Dim Imag As Byte() = Imagen_Bytes(Me.pb_foto.Image)
        Dim operacion As Integer = dataDetalle("operacion", dataDetalle.CurrentRow.Index).Value
        Dim orden As Integer = dataDetalle("orden", dataDetalle.CurrentRow.Index).Value

        mPedido.actualiza_detfoto(operacion, orden, Imag)
    End Sub



    Private Sub dt_entrega_Validated(sender As Object, e As EventArgs) Handles dt_entrega.Validated
        dt_pedido.MinDate = dt_entrega.Value
        dt_pedido.Value = dt_entrega.Value
        dt_pedido.Refresh()
    End Sub


    Private Sub tabcontrol_Click(sender As Object, e As EventArgs) Handles tabcontrol.Click

        If (dataDetalle.SelectedRows.Count > 0) Then
            Dim fila As Integer = dataDetalle.CurrentRow.Index
            Dim tab As Integer = tabcontrol.SelectedIndex
            If tab = 1 Then
                If dataDetalle("Estado", fila).Value = "New" Then
                    MessageBox.Show("Primero Debe guardar el Pedido...", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Else
                    Dim operacion As Integer = dataDetalle("operacion", fila).Value
                    Dim orden As Integer = dataDetalle("orden", fila).Value
                    Dim nom_articulo As String = dataDetalle("nom_art", fila).Value
                    lblarticulo.Text = nom_articulo
                    MuestraFoto(operacion, orden)
                End If
            End If
        End If

    End Sub

    Private Sub dataDetalle_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataDetalle.CellDoubleClick

        If esEditable() Then
            ingresaobs()
            'si la columna donde hacemos doble click es distinta de la de IGV
            If dataDetalle.CurrentCell.ColumnIndex <> dataDetalle.Columns("afecto_igv").Index Then
                If dataDetalle.CurrentCell.ColumnIndex <> dataDetalle.Columns("precio").Index Then
                    If dataDetalle.CurrentCell.ColumnIndex <> dataDetalle.Columns("obs").Index Then
                        eliminaitem()
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub dataDetalle_KeyDown(sender As Object, e As KeyEventArgs) Handles dataDetalle.KeyDown
        If (e.Control And e.KeyCode = Keys.E) Then
            If dataDetalle.RowCount > 0 Then
                EnviaraExcel(dataDetalle)
            End If
        End If
        If e.KeyCode = Keys.Delete Then
            eliminaitem()
        End If
        If e.KeyCode = Keys.Enter Then
            dataDetalle.ClearSelection()
            txtBuscar.Focus()
        End If

    End Sub

    Private Sub dataArticulo_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataArticulo.CellContentClick

    End Sub

    Private Sub dataDetalle_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataDetalle.CellContentClick

    End Sub

    Private Sub txtNroPedido_TextChanged(sender As Object, e As EventArgs) Handles txtNroPedido.TextChanged

    End Sub

    Private Sub txtSerPedido_TextChanged(sender As Object, e As EventArgs) Handles txtSerPedido.TextChanged

    End Sub

    Private Sub ChkResppn_CheckedChanged(sender As Object, e As EventArgs) Handles ChkResppn.CheckedChanged
        'cmbresponsable()
        'CboResponsable.Enabled = True
    End Sub


    Private Sub dataDetalle_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dataDetalle.CellEndEdit
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
                lcantidad = 0
                dataDetalle("cantidad", dataDetalle.CurrentRow.Index).Value = lcantidad
            Else
                lcantidad = dataDetalle("cantidad", dataDetalle.CurrentRow.Index).Value
                lprecio = dataDetalle("precio", dataDetalle.CurrentRow.Index).Value
                lneto = Round(lcantidad * lprecio, pDecimales)
                dataDetalle("neto", dataDetalle.CurrentRow.Index).Value = lneto
            End If
            txtBuscar.Focus()
            txtBuscar.Text = ""

            'dataDetalle.ClearSelection()
        End If
        If dataDetalle.CurrentCell.ColumnIndex = dataDetalle.Columns("precio").Index Then
            If IsDBNull(dataDetalle("precio", dataDetalle.CurrentRow.Index).Value) Then
                lprecio = 0
                dataDetalle("precio", dataDetalle.CurrentRow.Index).Value = lprecio
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
        dataDetalle.Rows(e.RowIndex).ErrorText = String.Empty
        'lneto = Round(lcantidad * lprecio, pDecimales)
        'dataDetalle("neto", dataDetalle.CurrentRow.Index).Value = lneto

        calculaTotal()
    End Sub

    Private Sub dataDetalle_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dataDetalle.EditingControlShowing
        ''referenciamos la celda
        'Dim validar As TextBox = CType(e.Control, TextBox)
        ''agregamos el controlador de eventos para el evento KeyPress
        'AddHandler validar.KeyPress, AddressOf validar_KeyPress
    End Sub
End Class
