Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Math
Imports libreriaClases
Public Class p_produccion
    'creamos el BindingSource que relacionara los datos con los controles
    Private dsAlmacen_o As New DataSet
    Private dsAlmacen_d As New DataSet

    Private dsProduccion As New DataSet
    Private dsProducciones As New DataSet
    Private dsProduccionesS As New DataSet
    Private dsComponentes As New DataSet
    Private dsAlmacen As New DataSet
    Private dsArea As New DataSet
    Private dsResponsable As New DataSet
    Private estaCargando As Boolean = True
    '
    Private dsReceta, dsReceta1, dsReceta2, dsReceta3, dsReceta4, dsReceta5 As New DataSet
    Private codR, codR1, codR2, codR3, codR4, codR5 As String
    Private cantR, cantR1, cantR2, cantR3, cantR4, cantR5 As Decimal
    Private cantRD, cantR1D, cantR2D, cantR3D, cantR4D, cantR5D As Decimal
    Private _M, _I, _W, _X, _Y, _Z, _ZF As Integer
    'capturamos el boton pulsado
    Private lcBoton As String
    'capturamos el codigo del articulo-esto para la edicion
    Private lCodigo As String
    'para validar el separador decimal
    Private sepDecimal As Char
    Private ldecimales As Decimal = 4
    Private nroOperacion As Integer
    Private Sub p_produccion_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        principal.mp_producciones.Enabled = True
    End Sub
    Private Sub p_produccion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'capturamos el separador decimal
        sepDecimal = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        Me.Left = 0
        Me.Top = 0
        'dataset almacen
        cargaAlmacenes()
        establecefechas()
        muestraProduccion()
        muestraProducciones()
        cmbresponsable()

        estaCargando = False
        dt_horaEntrega.Value = "07:00:00"
    End Sub
    Sub cmbresponsable()
        'dataset RESPONSABLE
        Dim daResponsable As New MySqlDataAdapter
        Dim chkresp As Boolean = If(ChkResppn.Checked = True, True, False)
        Dim query As String = "SELECT cuenta,user FROM usuario where activo " & IIf(chkresp = False, "", " and cuenta='" & pCuentaUser & "'")
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

        'With cboOrigen
        '    .DataSource = dsAlmacen_o.Tables("almacen")
        '    .DisplayMember = dsAlmacen_o.Tables("almacen").Columns("nom_alma").ToString
        '    .ValueMember = dsAlmacen_o.Tables("almacen").Columns("cod_alma").ToString
        '    .SelectedIndex = -1
        'End With
        With cboAlmacen
            .DataSource = dsAlmacen_d.Tables("almacen")
            .DisplayMember = dsAlmacen_d.Tables("almacen").Columns("nom_alma").ToString
            .ValueMember = dsAlmacen_d.Tables("almacen").Columns("cod_alma").ToString
            .SelectedIndex = -1
        End With
        muestraArea(cboAlmacen.SelectedValue)
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
    Private Sub cboAlmacen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAlmacen.SelectedIndexChanged

        If Not estaCargando Then
            'cCatalogoDestino = ""
            If cboAlmacen.SelectedIndex <> -1 Then
                Dim mAlmacen As New Almacen
                'cCatalogoDestino = mAlmacen.devuelveAlmacenCatalogo(cboDestino.SelectedValue)
                muestraArea(cboAlmacen.SelectedValue)
                muestraProduccion()
                muestraProducciones()
            End If
        End If
    End Sub
    Sub muestraProduccion()
        Dim cAlmacen As String = cboAlmacen.SelectedValue
        'establecemos las propiedades del BindingSource
        Dim mProduccion As New Receta
        Dim xAlmacen As Boolean = IIf(pCatalogoXalmacen, True, False)
        dsProduccion = mProduccion.recuperaProducciones(xAlmacen, cAlmacen, True)
        dataProduccion.DataSource = dsProduccion.Tables("articulo").DefaultView
        estructuraProduccion()
        lblRegistros.Text = "Nº de Registros..." & dataProduccion.RowCount
    End Sub
    Sub establecefechas()
        'dtiProduccion.ResetMinDate()
        'dtiProduccion.MinDate = pFechaActivaMin
        'dtiProduccion.ResetMaxDate()
        'dtiProduccion.MaxDate = pFechaActivaMax
        'If pFechaSystem > pFechaActivaMax Then
        '    dtiProduccion.Value = pFechaActivaMax
        'Else
        '    dtiProduccion.Value = pFechaSystem
        'End If
        dtiProduccion.MinDate = pFechaActivaMin
        '  dtiProduccion.MaxDate = pFechaActivaMax
        dtiProduccion.Value = pFechaSystem
    End Sub
    Sub estructuraProduccion()
        With dataProduccion
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_art").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_art").DisplayIndex = 0
            .Columns("cod_art").HeaderText = "Código"
            .Columns("cod_art").Width = 49
            .Columns("cod_art").ReadOnly = True
            .Columns("nom_art").DisplayIndex = 1
            .Columns("nom_art").HeaderText = "Descripción"
            .Columns("nom_art").Width = 248
            .Columns("nom_art").ReadOnly = True
            .Columns("nom_uni").DisplayIndex = 3
            .Columns("nom_uni").HeaderText = "Unidad"
            .Columns("nom_uni").Width = 50
            .Columns("nom_uni").ReadOnly = True
            .Columns("pre_costo").DisplayIndex = 4
            .Columns("pre_costo").HeaderText = "Precio Costo"
            .Columns("pre_costo").Width = 60
            .Columns("pre_costo").ReadOnly = True
            .Columns("pre_costo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("factor_prod").HeaderText = "Factor Prod"
            .Columns("factor_prod").Width = 60
            .Columns("factor_prod").ReadOnly = False
            .Columns("factor_prod").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("factor_prod").DisplayIndex = 2
            .Columns("activo").Width = 30
            .Columns("activo").HeaderText = "Act."
            .Columns("activo").ReadOnly = True
            .Columns("pre_costoMax").Visible = False
            .Columns("cod_artExt").Visible = False
            .Columns("porcentaje").Visible = False
            .Columns("pre_inc_imp").Visible = False
            .Columns("pre_venta").Visible = False
            .Columns("cod_uni").Visible = False
            .Columns("cod_area").Visible = False
            .Columns("cod_sgrupo").Visible = False
            .Columns("cod_tart").Visible = False
        End With
    End Sub
    Private Sub txtBuscarProduccion_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscarProduccion.GotFocus
        If Not estaCargando Then
            txtBuscarProduccion.SelectAll()
        End If
    End Sub
    Private Sub txtBuscarProduccion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscarProduccion.KeyPress
        If e.KeyChar = ChrW(13) Then
            dataProduccion.Focus()
        End If
    End Sub
    Private Sub txtBuscarProduccion_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscarProduccion.TextChanged
        If Not estaCargando Then
            dsProduccion.Tables("articulo").DefaultView.RowFilter = "nom_art LIKE '%" & txtBuscarProduccion.Text & "%'"
            If dataProduccion.RowCount > 0 Then
                dataProduccion.CurrentCell = dataProduccion("cod_art", dataProduccion.CurrentRow.Index)
            End If
        End If
    End Sub
    Private Sub dataProduccion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dataProduccion.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtProduccion.Focus()
        End If
    End Sub
    Private Sub dataProduccion_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dataProduccion.SelectionChanged
        If Not estaCargando Then
            lblReceta.Text = "RECETA:"
            If dataProduccion.RowCount > 0 Then
                lblReceta.Text = "RECETA: " & dataProduccion("nom_art", dataProduccion.CurrentRow.Index).Value
                muestracomponentes(dataProduccion("cod_art", dataProduccion.CurrentRow.Index).Value)
            End If
        End If
    End Sub
    Sub muestraComponentes(ByVal cod_rec As String)
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim da As New MySqlDataAdapter
        Dim cad, cad1, cad2, cad3, cad4 As String
        dsComponentes.Clear()
        cad1 = " select cod_rec,receta.cod_art,nom_art,nom_uni,cant,costo,cod_area"
        cad2 = " from receta inner join articulo on receta.cod_art=articulo.cod_art"
        cad3 = " inner join unidad on articulo.cod_uni=unidad.cod_uni"
        cad4 = " where cod_rec='" & cod_rec & "' order by nom_art"
        cad = cad1 + cad2 + cad3 + cad4
        Dim com As New MySqlCommand(cad)
        com.Connection = clConex
        da.SelectCommand = com
        da.Fill(dsComponentes, "receta")
        dataReceta.DataSource = dsComponentes.Tables("receta").DefaultView
        clConex.Close()
        cargaEstructuraComponentes()
    End Sub
    Sub cargaEstructuraComponentes()
        With dataReceta
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_art").HeaderText = "Codigo"
            .Columns("cod_art").Width = 50
            .Columns("cod_art").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("nom_art").HeaderText = "Descripcion"
            .Columns("nom_art").Width = 250
            .Columns("nom_uni").HeaderText = "Unidad"
            .Columns("nom_uni").Width = 65
            .Columns("cant").HeaderText = "Cant."
            .Columns("cant").Width = 45
            .Columns("cant").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("cant").DefaultCellStyle.Format = "N" & ldecimales
            .Columns("costo").HeaderText = "Costo"
            .Columns("costo").Width = 70
            .Columns("costo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("cod_rec").Visible = False
            .Columns("cod_area").Visible = False
        End With
    End Sub
    Private Sub txtProduccion_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtProduccion.GotFocus
        txtProduccion.SelectAll()
    End Sub
    Private Sub txtProduccion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtProduccion.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not (e.KeyChar = ChrW(Keys.Back)) And Not (e.KeyChar.Equals(sepDecimal)) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub dataProduccion_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataProduccion.CellContentClick

    End Sub
    Function validaGrabacion() As Boolean
        Dim valorRetorno As Boolean = True

        Dim creg, I As Integer
        Dim cod_art, nom_art As String

        Dim mcatalogo As New Catalogo
        creg = dataProducionesS.RowCount
        If creg > 0 Then
            For I = 0 To creg - 1
                cod_art = dataProducionesS("cod_art", I).Value
                nom_art = dataProducionesS("nom_art", I).Value
                If mcatalogo.existeCodigoActivo(cod_art) Then

                Else

                    MessageBox.Show("¡EL PRODUCTO " & nom_art & " ESTA DESACTIVADO!" & Chr(13) & "Por favor CAMBIARLO...", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    valorRetorno = False
                End If

            Next

        End If


        Return valorRetorno
    End Function

    Private Sub dtiProduccion_Click(sender As Object, e As EventArgs) Handles dtiProduccion.Click

    End Sub

    Private Sub ChkResppn_CheckedChanged(sender As Object, e As EventArgs) Handles ChkResppn.CheckedChanged
        'cmbresponsable()
        'CboResponsable.Enabled = True
    End Sub

    Private Sub cboArea_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboArea.SelectedIndexChanged
        If Not estaCargando Then
            ' muestraProduccion()
            muestraProducciones()


        End If
    End Sub

    Private Sub CboResponsable_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboResponsable.SelectedIndexChanged
        If Not estaCargando Then
            ' muestraProduccion()
            muestraProducciones()


        End If
    End Sub

    Sub establececorrelativo()
        Dim mpedido As New pedido
        nroOperacion = mpedido.maxOperacion
        'txtSerPedido.Text = periodoActivo()
        'txtSerPedido.Text = "P01"
        'txtNroPedido.Text = nroOperacion
        'txtNroPedido.Text = Microsoft.VisualBasic.Right("00000000" & txtNroPedido.Text, 8)
        'modoEdicion()
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click

        Dim cReg As Integer, continuar As Boolean = True
        continuar = validaGrabacion()
        Dim tipoproceso As Char = "A"
        Try

            If continuar Then
                Dim serPedido, nroPedido, cod_vend, cod_usu, tm As String, fec_ped, fec_ent As Date
                Dim hor_ent As Date
                Dim cod_clie, cod_fpago, cod_almaO, cod_alma, cod_area, cod_estado, cod_pedido, dir_ent, obs As String, nroOrden, inc_igv As Integer
                nroPedido = ""
                serPedido = ""

                fec_ped = dtiProduccion.Value
                fec_ent = dtiProduccion.Value
                hor_ent = dt_horaEntrega.Value
                cod_vend = "00000000"
                'cod_clie = cboCliente.SelectedValue.ToString
                cod_clie = "00000000000"
                'cod_fpago = cboFPago.SelectedValue.ToString
                cod_fpago = "01"
                cod_alma = cboAlmacen.SelectedValue.ToString
                cod_area = cboArea.SelectedValue.ToString
                cod_usu = CboResponsable.SelectedValue.ToString
                cod_almaO = "0001"
                cod_estado = "0001"
                cod_pedido = "0001"

                'dir_ent = txtDirEntrega.Text
                dir_ent = "-"
                obs = dataProducciones("nom_art", dataProducciones.CurrentRow.Index).Value
                'If chkIGV.CheckState = CheckState.Checked Then
                inc_igv = 1
                ' Else
                'inc_igv = 0
                'End If
                '  If optMoneda.Checked Then
                tm = pMonedaAbr
                ' Else
                'tm = "D"
                'End If
                cReg = dataProducionesS.RowCount

                Dim mPedido As New pedido
                Dim mcatalogo As New Catalogo
                If tipoproceso = "A" Then 'añadir

                    If cReg > 0 Then
                        Try

                            serPedido = "R01"
                            establececorrelativo()
                            nroPedido = dataProducciones("nro_doc", dataProducciones.CurrentRow.Index).Value
                            ' nroOperacion = mPedido.maxOperacion
                            'registramos la cabecera
                            mPedido.eliminaCabecera(serPedido, nroPedido)
                            mPedido.insertar(nroOperacion, serPedido, nroPedido, fec_ped, fec_ent, hor_ent, cod_estado, cod_pedido, cod_vend, cod_clie, cod_fpago, cod_almaO, cod_alma, cod_area, dir_ent, obs, inc_igv, tm, cod_usu, pCuentaUser)
                            'registramos el detalle
                            Dim cod_art, observ As String, cant, precio, igv, comi_v, comi_jv As Decimal, I As Integer
                            For I = 0 To cReg - 1
                                cod_art = dataProducionesS("cod_art", I).Value
                                cant = dataProducionesS("cant", I).Value
                                precio = dataProducionesS("precio", I).Value

                                comi_v = 0
                                comi_jv = 0
                                observ = ""
                                nroOrden = mPedido.maxOrden(nroOperacion)

                                mPedido.insertar_det(nroOperacion, nroOrden, cod_art, cant, precio, igv, comi_v, comi_jv, pCuentaUser, observ)

                            Next


                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                            MessageBox.Show("Revisar Pedido: " & vbCrLf & ex.StackTrace)
                        End Try
                    End If


                End If
                MessageBox.Show("Pedido Registrado Correctamente..." & vbCrLf & " " & serPedido & " - " & nroPedido, "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            ' Show the exception's message.
            MessageBox.Show(ex.Message)

            MessageBox.Show("Revisar Pedido: " & vbCrLf & ex.StackTrace)
        Finally
            ' This line executes whether or not the exception occurs.

        End Try
    End Sub

    Private Sub cmdIniciar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdIniciar.Click
        If Len(txtProduccion.Text) > 0 Then
            registraProduccion()
            txtProduccion.Text = 1.0
            txtBuscarProduccion.Focus()
            muestraProducciones()
        Else
            txtProduccion.Focus()
            MessageBox.Show("Ingrese la Cantidad a Producir...", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Sub registraProduccion()
        inicializaVariables()
        Dim codigo, cAlma, cod_Area, cod_usu, cdocumento, descripcion As String, nOperacionS, nOperacionI As Integer, factor_prod, cantProducir, costoProduccion As Decimal
        Dim mSalida As New Salida, mIngreso As New Ingreso, mReceta As New Receta, mcatalogo As New Catalogo
        Dim nIngreso As Integer
        Dim continuar As Boolean = True
        If dataProduccion.RowCount > 0 Then
            codigo = dataProduccion("cod_art", dataProduccion.CurrentRow.Index).Value
            'cod_Area = dataProduccion("cod_area", dataProduccion.CurrentRow.Index).Value.ToString
            descripcion = dataProduccion("nom_art", dataProduccion.CurrentRow.Index).Value
            costoProduccion = dataProduccion("pre_costo", dataProduccion.CurrentRow.Index).Value
            factor_prod = dataProduccion("factor_prod", dataProduccion.CurrentRow.Index).Value
            cantProducir = txtProduccion.Text
            nOperacionS = mSalida.maxOperacion
            nOperacionI = mIngreso.maxOperacion
            nIngreso = mIngreso.maxIngreso
            Dim mFecha = dtiProduccion.Value
            cAlma = cboAlmacen.SelectedValue
            cod_Area = cboArea.SelectedValue
            cod_usu = CboResponsable.SelectedValue.ToString
            cdocumento = Microsoft.VisualBasic.Right("00000000" & mReceta.maxProduccion, 8)
            Dim procesar As Boolean = IIf(chkprocesar.Checked, True, False)
            dsReceta.Clear()
            muestraReceta(codigo, 0)
            Try
                If validarstock(procesar) Then
                    ' If dsReceta.Tables("receta").Rows.Count > 0 Then ten
                    'mSalida.insertar(OperacionS, 0, "93", "001", cDocumento, mFecha, "00000000", "00000000000", "01", 1, 0, LDecimales, cAlma, "S", descripcion, pEmpresa, pCuentaUser)
                    mSalida.insertar_aux(nOperacionS, 0, "93", "R01", cDocumento, mFecha, mFecha, "00000000", "00000000000", "01", 1, 0, ldecimales, cAlma, IIf(cod_Area = "", "0000", cod_Area), descripcion, "00", cod_usu, pCuentaUser, 0, "", "")
                    For _I = 0 To dsReceta.Tables("receta").Rows.Count - 1
                            almacenaDatos(cantProducir)
                            dsReceta1.Clear()
                            muestraReceta(codR, 1)
                            procesar = mcatalogo.devuelveTipoArt(codR)
                            If dsReceta1.Tables("receta").Rows.Count > 0 And procesar Then
                                For _W = 0 To dsReceta1.Tables("receta").Rows.Count - 1
                                    almacenaDatos1()
                                    dsReceta2.Clear()
                                    muestraReceta(codR1, 2)
                                    procesar = mcatalogo.devuelveTipoArt(codR1)
                                    If dsReceta2.Tables("receta").Rows.Count > 0 And procesar Then
                                        For _X = 0 To dsReceta2.Tables("receta").Rows.Count - 1
                                            almacenaDatos2()
                                            dsReceta3.Clear()
                                            muestraReceta(codR2, 3)
                                            procesar = mcatalogo.devuelveTipoArt(codR2)
                                            If dsReceta3.Tables("receta").Rows.Count > 0 And procesar Then
                                                For _Y = 0 To dsReceta3.Tables("receta").Rows.Count - 1
                                                    almacenaDatos3()
                                                    dsReceta4.Clear()
                                                    muestraReceta(codR3, 4)
                                                    procesar = mcatalogo.devuelveTipoArt(codR3)
                                                    If dsReceta4.Tables("receta").Rows.Count > 0 And procesar Then
                                                        For _Z = 0 To dsReceta4.Tables("receta").Rows.Count - 1
                                                            almacenaDatos4()
                                                            dsReceta5.Clear()
                                                            muestraReceta(codR4, 5)
                                                            procesar = mcatalogo.devuelveTipoArt(codR4)
                                                            If dsReceta5.Tables("receta").Rows.Count > 0 And procesar Then
                                                                For _ZF = 0 To dsReceta5.Tables("receta").Rows.Count - 1
                                                                    almacenaDatos5()
                                                                    insertaInsumo(codR5, cantR5D, nOperacionS, nIngreso)
                                                                Next
                                                            Else
                                                                insertaInsumo(codR4, cantR4D, nOperacionS, nIngreso)
                                                            End If
                                                        Next
                                                    Else
                                                        insertaInsumo(codR3, cantR3D, nOperacionS, nIngreso)
                                                    End If
                                                Next
                                            Else
                                                insertaInsumo(codR2, cantR2D, nOperacionS, nIngreso)
                                            End If
                                        Next
                                    Else
                                        insertaInsumo(codR1, cantR1D, nOperacionS, nIngreso)
                                    End If
                                Next
                            Else
                                insertaInsumo(codR, cantRD, nOperacionS, nIngreso)
                            End If
                        Next
                    mIngreso.insertar(nOperacionI, "93", "R01", cdocumento, "000", "00000000", 0, mFecha, "00000000000", "01", cAlma, IIf(cod_Area = "", "0000", cod_Area), 1, False, ldecimales, IIf(txtObservacion.Text = "", "Produccion", txtObservacion.Text), "S", pTC, cod_usu, pmaquina)
                    mIngreso.insertar_det(nOperacionI, nIngreso, codigo, cantProducir * factor_prod, costoProduccion, pCuentaUser, pIGV)
                    MessageBox.Show("Produccion Terminada..." + Chr(13) + "Verifique su stock...", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Sub insertaInsumo(ByVal cod_art As String, ByVal cantidad As Decimal, ByVal opeSalida As Integer, ByVal nIngreso As Integer)
        'recuperamos los lotes del producto a transformar
        'y descargamos las salidas correspondientes
        Dim dsLotes As New DataSet
        Dim mCatalogo As New Catalogo, mSalida As New Salida, mIngreso As New Ingreso, mprecio As New ePrecio
        Dim nSalida As Integer
        Dim nCosto As Decimal
        nSalida = mSalida.maxSalida
        nCosto = mprecio.devuelvePrecioCosto(cod_art)
        nSalida = mSalida.maxSalida
        mSalida.insertar_det(opeSalida, nSalida, ningreso, cod_art, cantidad, nCosto, 0, 0, 0)
    End Sub
    Function recuperaStock(ByVal cod_art As String) As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim ds As New DataSet
        Dim cad As String
        cad = "select * from ingreso_det where cod_art='" & cod_art & "' order by ingreso"
        Dim da As New MySqlDataAdapter
        Dim com As New MySqlCommand(cad)
        com.Connection = clConex
        da.SelectCommand = com
        da.Fill(ds, "saldo")
        clConex.Close()
        Return ds
    End Function
    Function validarstock(ByVal procesar As Boolean) As Boolean
        Dim i As Integer, cod_art, nom_art As String, nCantidad, nstock As Decimal
        Dim result As Boolean = True
        Dim esgasto As Boolean = True
        Dim mcatalogo As New Catalogo
        Dim cantProducir As Decimal = txtProduccion.Text
        For i = 0 To dsReceta.Tables("receta").Rows.Count - 1
            cod_art = dsReceta.Tables("receta").Rows(i).Item("cod_art").ToString
            nom_art = dsReceta.Tables("receta").Rows(i).Item("nom_art").ToString
            nCantidad = dsReceta.Tables("receta").Rows(i).Item("cant").ToString
            nstock = mcatalogo.devuelveStock(cod_art)
            esgasto = mcatalogo.devuelveEsGasto(cod_art)
            If Not (procesar) Then
                If Not (esgasto) Then
                    If nstock < cantProducir * nCantidad Then
                        MessageBox.Show("Produccion No Realizada..." + Chr(13) + "Verifique su stock..." & nom_art, "CEFE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        result = False
                    End If
                End If
            End If
        Next
        Return result
    End Function
    Sub muestraReceta(ByVal cod_rec As String, ByVal nro As Integer)
        Dim mReceta As New Receta
        If nro = 0 Then
            dsReceta = mReceta.recuperaReceta(cod_rec)
        End If
        If nro = 1 Then
            dsReceta1 = mReceta.recuperaReceta(cod_rec)
        End If
        If nro = 2 Then
            dsReceta2 = mReceta.recuperaReceta(cod_rec)
        End If
        If nro = 3 Then
            dsReceta3 = mReceta.recuperaReceta(cod_rec)
        End If
        If nro = 4 Then
            dsReceta4 = mReceta.recuperaReceta(cod_rec)
        End If
        If nro = 5 Then
            dsReceta5 = mReceta.recuperaReceta(cod_rec)
        End If
    End Sub
    Sub almacenaDatos(ByVal cantProducir As Decimal)
        codR = dsReceta.Tables("receta").Rows(_I).Item("cod_art").ToString
        cantR = dsReceta.Tables("receta").Rows(_I).Item("cant").ToString
        cantRD = cantProducir * cantR
    End Sub
    Sub almacenaDatos1()
        codR1 = dsReceta1.Tables("receta").Rows(_W).Item("cod_art").ToString
        cantR1 = dsReceta1.Tables("receta").Rows(_W).Item("cant").ToString
        cantR1D = cantRD * cantR1
    End Sub
    Sub almacenaDatos2()
        codR2 = dsReceta2.Tables("receta").Rows(_X).Item("cod_art").ToString
        cantR2 = dsReceta2.Tables("receta").Rows(_X).Item("cant").ToString
        cantR2D = cantR1D * cantR2
    End Sub
    Sub almacenaDatos3()
        codR3 = dsReceta3.Tables("receta").Rows(_Y).Item("cod_art").ToString
        cantR3 = dsReceta3.Tables("receta").Rows(_Y).Item("cant").ToString
        cantR3D = cantR2D * cantR3
    End Sub
    Sub almacenaDatos4()
        codR4 = dsReceta4.Tables("receta").Rows(_Z).Item("cod_art").ToString
        cantR4 = dsReceta4.Tables("receta").Rows(_Z).Item("cant").ToString
        cantR4D = cantR3D * cantR4
    End Sub
    Sub almacenaDatos5()
        codR5 = dsReceta5.Tables("receta").Rows(_ZF).Item("cod_art").ToString
        cantR5 = dsReceta5.Tables("receta").Rows(_ZF).Item("cant").ToString
        cantR5D = cantR4D * cantR5
    End Sub
    Sub inicializaVariables()
        codR = ""
        codR1 = ""
        codR2 = ""
        codR3 = ""
        codR4 = ""
        codR5 = ""
        cantR = 0.0
        cantR1 = 0.0
        cantR2 = 0.0
        cantR3 = 0.0
        cantR4 = 0.0
        cantR5 = 0.0
        cantRD = 0.0
        cantR1D = 0.0
        cantR2D = 0.0
        cantR3D = 0.0
        cantR4D = 0.0
        cantR5D = 0.0
        _M = 0
        _I = 0
        _W = 0
        _X = 0
        _Y = 0
        _Z = 0
        _ZF = 0
    End Sub
    Sub muestraProducciones()
        Dim mReceta As New Receta
        dsProducciones = mReceta.recProduccionesxdia(True, cboAlmacen.SelectedValue, cboArea.SelectedValue, CboResponsable.SelectedValue, False, dtiProduccion.Value, chkacumulado.Checked)
        dataProducciones.DataSource = dsProducciones.Tables("articulo").DefaultView
        estructuraProducciones()
    End Sub
    Sub cargaProducionesS(ByVal nro_doc As String)
        Dim mTransformacion As New Transformacion
        dsProduccionesS = mTransformacion.recProduccionS(nro_doc)
        dataProducionesS.DataSource = dsProduccionesS.Tables("Produccion")
        estructuraProduccionesS()
    End Sub
    Sub estructuraProducciones()
        With dataProducciones
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("fec_doc").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("fec_doc").DisplayIndex = 0
            .Columns("fec_doc").HeaderText = "Fecha"
            .Columns("fec_doc").Width = 70
            .Columns("nro_doc").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("nro_doc").DisplayIndex = 0
            .Columns("nro_doc").HeaderText = "Nro Produc."
            .Columns("nro_doc").Width = 70
            .Columns("cod_art").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_art").DisplayIndex = 1
            .Columns("cod_art").HeaderText = "Código"
            .Columns("cod_art").Width = 50
            .Columns("cod_art").ReadOnly = True
            .Columns("nom_art").DisplayIndex = 2
            .Columns("nom_art").HeaderText = "Descripción"
            .Columns("nom_art").Width = 215
            .Columns("nom_art").ReadOnly = True
            .Columns("nom_uni").DisplayIndex = 3
            .Columns("nom_uni").HeaderText = "Unidad"
            .Columns("nom_uni").Width = 50
            .Columns("nom_uni").ReadOnly = True
            .Columns("cant").DisplayIndex = 4
            .Columns("cant").HeaderText = "Cant."
            .Columns("cant").Width = 60
            .Columns("cant").ReadOnly = True
            .Columns("cant").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("pre_costo").DisplayIndex = 5
            .Columns("pre_costo").HeaderText = "Precio Costo"
            .Columns("pre_costo").Width = 65
            .Columns("pre_costo").ReadOnly = True
            .Columns("pre_costo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("nom_sgrupo").DisplayIndex = 6
            .Columns("nom_sgrupo").HeaderText = "Grupo"
            .Columns("nom_sgrupo").Width = 170
            .Columns("nom_sgrupo").ReadOnly = True
            .Columns("operacion").Visible = False
            .Columns("ingreso").Visible = False
            .Columns("cod_sgrupo").Visible = False
        End With
    End Sub
    Sub estructuraProduccionesS()
        With dataProducionesS
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_art").HeaderText = "Código"
            .Columns("cod_art").Width = 55
            .Columns("cod_art").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("nom_art").HeaderText = "Descripción"
            .Columns("nom_art").Width = 230
            .Columns("nom_uni").HeaderText = "Unidad"
            .Columns("nom_uni").Width = 60
            .Columns("nom_uni").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cant").HeaderText = "Cant."
            .Columns("cant").Width = 75
            .Columns("cant").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("precio").HeaderText = "Precio"
            .Columns("precio").Width = 75
            .Columns("precio").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            .Columns("fec_doc").Visible = False
            .Columns("nro_doc").Visible = False

            .Columns("operacion").Visible = False
            .Columns("salida").Visible = False
            .Columns("cod_alma").Visible = False
        End With
    End Sub

    Private Sub dtiProduccion_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtiProduccion.ValueChanged
        If Not estaCargando Then
            muestraProducciones()
        End If
    End Sub


    Private Sub dataProducciones_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataProducciones.CellDoubleClick
        If dataProducciones.RowCount > 0 Then
            eliminaPROD()
        End If
    End Sub
    Sub eliminaPROD()

        Dim mIngreso As New Ingreso
        Dim I As Integer = 0, eliminar As Boolean = True
        Dim cad As String, nOperacion As Integer

        If eliminar Then
            Dim rpta As Integer
            Dim nro As String = dataProducciones("nro_doc", dataProducciones.CurrentRow.Index).Value
            rpta = MessageBox.Show("Esta Seguro de Eliminar la Produccion: " & nro, "SGA", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

            If rpta = 6 Then
                If dataProducciones.RowCount > 0 Then
                    nOperacion = dataProducciones("operacion", dataProducciones.CurrentRow.Index).Value
                    cad = "delete from ingreso where operacion=" & nOperacion
                    Dim com As New MySqlCommand(cad, dbConex)
                    com.ExecuteNonQuery()
                End If
                If dataProducionesS.RowCount > 0 Then
                    nOperacion = dataProducionesS("operacion", dataProducionesS.CurrentRow.Index).Value
                    cad = "update salida_det set cant=0 where operacion=" & nOperacion
                    Dim com2 As New MySqlCommand(cad, dbConex)
                    com2.ExecuteNonQuery()
                    cad = "delete from salida where operacion=" & nOperacion
                    Dim com4 As New MySqlCommand(cad, dbConex)
                    com4.ExecuteNonQuery()
                End If
            End If
        End If
        muestraProducciones()
    End Sub

    Private Sub dataProducciones_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dataProducciones.KeyDown
        If (e.Control And e.KeyCode = Keys.E) Then
            If dataProducciones.RowCount > 0 Then
                EnviaraExcel(dataProducciones)
            End If
        End If
    End Sub

    Private Sub dataProducciones_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dataProducciones.SelectionChanged
        dsProduccionesS.Clear()
        If dataProducciones.RowCount > 0 Then
            Dim nro As String = dataProducciones("nro_doc", dataProducciones.CurrentRow.Index).Value
            cargaProducionesS(nro)
        End If
    End Sub


    Private Sub chkacumulado_CheckedChanged(sender As Object, e As EventArgs) Handles chkacumulado.CheckedChanged
        If Not estaCargando Then
            muestraProducciones()
        End If
    End Sub

    Private Sub chkdetalle_CheckedChanged(sender As Object, e As EventArgs)
        If Not estaCargando Then
            muestraProducciones()
        End If
    End Sub


End Class
