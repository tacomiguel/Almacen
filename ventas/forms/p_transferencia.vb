Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Math
Imports libreriaClases
Public Class p_transferencia
    Private dsAlmacen_o As New DataSet
    Private dsAlmacen_d As New DataSet
    Private dsOrigen As New DataSet
    Private dsArea As New DataSet
    Private dsNrosTransferencia As New DataSet
    Private dsTransferencias As New DataSet

    Private dsNrospedidos As New DataSet
    Private dspedidos As New DataSet
    Private dtTransferencia As New DataTable
    '
    Private cCatalogoOrigen As String = "", cCatalogoDestino As String = ""
    Private estaCargando As Boolean = True
    Private _nroTransferencia, _nroOperacion, vfOpeSalida, vfOpeIngreso As Integer
    'para validar el separador decimal
    Private sepDecimal As Char

    Private Sub p_transferencia_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        principal.mp_transferencia.Enabled = True
    End Sub

    Private Sub p_transferencia_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Dim rpta As Integer
        If (e.Control And e.KeyCode = Keys.D) Then
            rpta = MessageBox.Show(" ¿Esta Seguro...en Desbloquear el Documento?", "SGA", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If rpta = 6 Then
                Dim msalida As New Salida
                msalida.actualizaEstadoTransf(dataTransferencias("operacion", dataTransferencias.CurrentRow.Index).Value, 0)
            End If
        End If
    End Sub
    Private Sub p_transferencia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        estableceFechaProceso()
        _nroTransferencia = 0
        'cargamos los almacenes a mostrar
        cargaAlmacenes()
        estaCargando = False
        If dsAlmacen_o.Tables("almacen").Rows.Count > 0 Then
            cboOrigen.SelectedIndex = 0
        End If
        cargaSaldos()
        'capturamos el separador decimal
        sepDecimal = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
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
        Dim comAlmacen_o As New MySqlCommand(cadena_dest, dbConex)
        Dim comAlmacen_d As New MySqlCommand(cadena, dbConex)
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
    Sub estableceFechaProceso()

        mcFechatransferencia1.MinDate = pFechaActivaMin
        mcFechatransferencia1.MaxDate = pFechaSystem
        mcFechatransferencia1.Value = pFechaSystem

        mcFechaProd.MinDate = pFechaActivaMin
        mcFechaProd.MaxDate = DateAdd(DateInterval.Day, pDiasModificarTrans, pFechaSystem)
        mcFechaProd.Value = pFechaSystem


    End Sub
    Sub cargaSaldos()
        If cboOrigen.SelectedIndex >= 0 Then
            dsOrigen.Clear()
            Dim mOrigen As New Catalogo
            Dim mAlmacen As New Almacen
            Dim cAlma As String = cboOrigen.SelectedValue
            Dim cAlmaCatalogo As String = mAlmacen.devuelveAlmacenCatalogo(cAlma)
            Dim xProduccion As Boolean = IIf(chkProduccion.Checked = True, True, False)
            Dim xAlma As Boolean = IIf(chkProduccion.Checked = True, True, False)
            cCatalogoOrigen = IIf(xProduccion = False, cAlma, cAlmaCatalogo)

            dsOrigen = mOrigen.recuperaCatalogo(xAlma, cCatalogoOrigen, True, False, False, False, "", False, xProduccion, False)
            dataArticulos.DataSource = dsOrigen.Tables("articulo").DefaultView
            estructuraSaldos()
        End If
    End Sub
    Sub estructuraSaldos()
        With dataArticulos
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_art").HeaderText = "Código"
            .Columns("cod_art").Width = 50
            .Columns("cod_art").ReadOnly = True
            .Columns("cod_art").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("nom_art").HeaderText = "Descripción"
            .Columns("nom_art").Width = 360
            .Columns("nom_art").ReadOnly = True
            .Columns("nom_uni").HeaderText = "Unidad"
            .Columns("nom_uni").Width = 70
            .Columns("nom_uni").ReadOnly = True
            .Columns("nom_uni").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_uni").Visible = False
            .Columns("cant_uni").Visible = False
            .Columns("pre_costo").Visible = False
            .Columns("pre_costomin").Visible = False
            .Columns("pre_costomax").Visible = False
            .Columns("pre_prom").Visible = False
            .Columns("pre_ult").Visible = False
            .Columns("afecto_igv").Visible = False
            .Columns("imp").Visible = False
            .Columns("pre_inc_imp").Visible = False
            .Columns("cuenta_c").Visible = False
            .Columns("nom_tart").Visible = False
            .Columns("cuenta_v").Visible = False
            .Columns("cuenta_v_c").Visible = False
            .Columns("cuenta_c_a1").Visible = False
            .Columns("cuenta_c_a2").Visible = False
            .Columns("cuenta_c_p").Visible = False
            .Columns("maximo").Visible = False
            .Columns("minimo").Visible = False
            .Columns("pre_venta").Visible = False
            .Columns("activo").Visible = False
            .Columns("cod_alma").Visible = False
            .Columns("cod_sgrupo").Visible = False
            .Columns("nom_sgrupo").Visible = False
            .Columns("cod_artExt").Visible = False
            .Columns("cod_artExt1").Visible = False
            .Columns("cod_artExt2").Visible = False
            .Columns("esProduccion").Visible = False



        End With
    End Sub
    Sub generaNumeroTransferencia()
        Dim mTransfer As New Transferencia
        _nroTransferencia = mTransfer.maxTransferencia()
        lblNroTransferencia.Text = "Nº " + Microsoft.VisualBasic.Right("00000000" + Trim(Str(_nroTransferencia)), 8)
        Dim mSalida As New Salida, mIngreso As New Ingreso
        vfOpeSalida = mSalida.maxOperacion
        vfOpeIngreso = mIngreso.maxOperacion
    End Sub
    Private Sub cboOrigen_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboOrigen.SelectedIndexChanged
        If Not estaCargando Then
            cCatalogoOrigen = ""
            If cboOrigen.SelectedIndex <> -1 Then
                Dim mAlmacen As New Almacen
                cCatalogoOrigen = mAlmacen.devuelveAlmacenCatalogo(cboOrigen.SelectedValue)
                cargaSaldos()
            End If
        End If
    End Sub
    Private Sub cboDestino_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboDestino.SelectedIndexChanged
        If Not estaCargando Then
            cCatalogoDestino = ""
            If cboDestino.SelectedIndex <> -1 Then
                Dim mAlmacen As New Almacen
                cCatalogoDestino = mAlmacen.devuelveAlmacenCatalogo(cboDestino.SelectedValue)
                muestraArea(cboDestino.SelectedValue)
                muestraProductoRelacionado()
            End If
        End If
    End Sub
    Private Sub cboDestino_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboDestino.KeyPress
        If e.KeyChar = Chr(13) Then
            txtBuscarOrigen.Focus()
        End If
    End Sub
    Private Sub txtBuscarOrigen_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscarOrigen.KeyPress
        If e.KeyChar = ChrW(13) Then
            dataArticulos.Focus()
        End If
    End Sub
    Private Sub txtBuscarOrigen_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscarOrigen.TextChanged
        Dim valor As String = txtBuscarOrigen.Text
        If Not estaCargando Then
            dsOrigen.Tables("articulo").DefaultView.RowFilter = "nom_art LIKE '%" & valor & "%'"
            If dataArticulos.RowCount > 0 Then
                dataArticulos.CurrentCell = dataArticulos("cod_art", dataArticulos.CurrentRow.Index)
            End If
        End If
    End Sub
    Private Sub txtBuscarOrigen_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscarOrigen.GotFocus
        txtBuscarOrigen.SelectAll()

    End Sub
    Sub muestraProductoRelacionado()
        lblProducto.Text = ""
        If dataArticulos.RowCount > 0 Then
            Dim lCodigo As String = dataArticulos("cod_art", dataArticulos.CurrentRow.Index).Value
            If cCatalogoOrigen <> cCatalogoDestino Then
                Dim mAlmacen As New Almacen
                lblProducto.Text = mAlmacen.muestraArticuloRelacionado(lCodigo, cCatalogoDestino)
            End If
        End If
    End Sub
    Private Sub dataArticulos_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dataArticulos.SelectionChanged
        muestraProductoRelacionado()
    End Sub
    Private Sub dataArticulos_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dataArticulos.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtTransferir.Focus()
        End If
    End Sub
    Private Sub cmdTransferir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTransferir.Click
        If chkMostrarPedidos.Checked Then
            ingresapedido()
        Else
            ingresatransferencia()
        End If
    End Sub
    Sub ingresapedido()
        Dim fila As DataRow = dtTransferencia.NewRow

        fila.Item("cod_art") = dataArticulos("cod_art", dataArticulos.CurrentRow.Index).Value
        fila.Item("nom_art") = dataArticulos.Item("nom_art", dataArticulos.CurrentRow.Index).Value
        fila.Item("nom_uni") = dataArticulos.Item("nom_uni", dataArticulos.CurrentRow.Index).Value
        fila.Item("precio") = dataArticulos("pre_prom", dataArticulos.CurrentRow.Index).Value
        fila.Item("fec_doc") = mcFechatransferencia1.Value
        fila.Item("origen") = cboOrigen.Text
        fila.Item("salida") = 0
        fila.Item("doc") = dataNroTransferencias("ser_doc", dataNroTransferencias.CurrentRow.Index).Value + "-" +
                            dataNroTransferencias("nro_doc", dataNroTransferencias.CurrentRow.Index).Value
        fila.Item("destino") = cboDestino.Text + "-" + cboArea.Text
        fila.Item("cant") = txtTransferir.Text
        fila.Item("cant_ped") = txtTransferir.Text

        dtTransferencia.Rows.Add(fila)
        dataTransferencias.CurrentCell = dataTransferencias(dataTransferencias.Columns("cant").Index, dataTransferencias.RowCount - 1)
        dataTransferencias.Focus()
    End Sub
    Sub ingresatransferencia()
        If validaRelacion() And esEditable() Then
            If validaTransferencia() Then
                Dim mSalida As New Salida, mIngreso As New Ingreso, mTransferencia As New Transferencia, mprecio As New ePrecio, rpta As Integer
                Dim nroSalida, nroIngreso, nIngreso As Integer, tm As String, tc As Decimal, esAfecto As Boolean
                Dim mUnidad As New Unidad
                Dim cod_art, nom_art As String, cantidad, precio, cant_uni As Decimal, es_div As Boolean
                Dim mFecha As Date = mcFechatransferencia1.Value
                Dim mFechaProd As Date = mcFechaProd.Value
                'datos para la salida del producto
                nroSalida = mSalida.maxSalida
                nIngreso = mIngreso.maxIngreso
                'nroIngreso = dataArticulos("ingreso", dataArticulos.CurrentRow.Index).Value
                nroIngreso = 1
                cod_art = dataArticulos("cod_art", dataArticulos.CurrentRow.Index).Value
                nom_art = dataArticulos("nom_art", dataArticulos.CurrentRow.Index).Value
                cant_uni = dataArticulos("cant_uni", dataArticulos.CurrentRow.Index).Value
                cantidad = txtTransferir.Text
                precio = dataArticulos("pre_prom", dataArticulos.CurrentRow.Index).Value
                'tm = dataArticulos("tm", dataArticulos.CurrentRow.Index).Value
                tm = "S"
                'tc = dataArticulos("tc", dataArticulos.CurrentRow.Index).Value
                tc = 0.00
                esAfecto = dataArticulos("afecto_igv", dataArticulos.CurrentRow.Index).Value
                rpta = MessageBox.Show("Va a Transferir " + nom_art + Chr(13) + "¿Esta Seguro...?", "SGA", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If rpta = 6 Then
                    If nroIngreso > 0 Then
                        If _nroTransferencia = 0 Then
                            'al generar el nro de transferencia, se generan los numeros de
                            'operacion, tanto de salida como de ingreso
                            generaNumeroTransferencia()
                            mSalida.insertar_aux(vfOpeSalida, 0, "90",
                                        IIf(pCatalogoXalmacen = True And cCatalogoOrigen <> cCatalogoDestino, "T01", "T00"),
                                        Microsoft.VisualBasic.Right("00000000" & _nroTransferencia, 8), mFecha, mFechaProd,
                                        "00000000", "00000000000", "00", 1, 0, pDecimales,
                                            cboOrigen.SelectedValue, IIf(cboArea.SelectedIndex <> -1, cboArea.SelectedValue, "0000"), txtObservacion.Text, "00", pCuentaUser, pCuentaUser, 0, cboDestino.SelectedValue,
                                            IIf(cboArea.SelectedIndex <> -1, cboArea.SelectedValue, "0000"))
                            mIngreso.insertar(vfOpeIngreso, "90",
                                        IIf(pCatalogoXalmacen = True And cCatalogoOrigen <> cCatalogoDestino, "T01", "T00"),
                                        Microsoft.VisualBasic.Right("00000000" & _nroTransferencia, 8), "000", "00000000", 0,
                                        mFecha, "00000000000", "01", cboDestino.SelectedValue, IIf(cboArea.SelectedIndex <> -1,
                                        cboArea.SelectedValue, "0000"), 1, 0, pDecimales,
                                        cboArea.Text, tm, tc, pCuentaUser, pmaquina)
                            cboOrigen.Enabled = False
                            cboDestino.Enabled = False
                        End If
                        'en el detalle de la salida grabamos el nro de ingreso del almacen destino
                        'para poder determinar el registro relacionado
                        'cuando se transfiere el documento completo, se graba en nAux2 la operacion del ingreso
                        mSalida.insertar_detAux(vfOpeSalida, nroSalida, nroIngreso,
                                                cod_art, cantidad, cantidad, precio, IIf(esAfecto, pIGV, 0), 0, 0, pCuentaUser, nIngreso, 0)
                        If pCatalogoXalmacen And cCatalogoOrigen <> cCatalogoDestino Then
                            Dim mAlmacen As New Almacen, cod_uniRel As String, cant_uniRel As Decimal
                            cod_art = mAlmacen.devuelveCodigoArtRelacionado(cod_art, cCatalogoDestino)
                            cod_uniRel = mUnidad.devuelveUnidad(cod_art)
                            cant_uniRel = mUnidad.devuelveCantUnidad(cod_uniRel)
                            es_div = mUnidad.esDivisible(cod_uniRel)
                            If es_div Then
                                cantidad = cantidad * cant_uni
                                precio = (precio / cant_uni) * cant_uniRel
                            End If
                        End If
                        mIngreso.insertar_det(vfOpeIngreso, nIngreso, cod_art, cantidad, precio, pCuentaUser, IIf(esAfecto, pIGV, 0))
                        'mprecio.actualizaPrecioPromedio(cod_art)

                        muestraTransferencias(vfOpeSalida)

                        txtBuscarOrigen.Focus()
                        lblRegistros.Text = "Nro de Registros Procesados..." & dataTransferencias.RowCount
                    Else
                        MessageBox.Show("Seleccione el Producto a Transferir...", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        cboOrigen.Focus()
                    End If
                End If
            End If
        End If

    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim I As Integer
        Dim mTransferencia As New Transferencia
        Dim com As New MySqlCommand
        com.Connection = dbConex
        Dim cad, cSerie, cNumero, cAlma, cArea As String, nOperacion As Integer
        For I = 0 To dataNroTransferencias.RowCount - 1
            cSerie = dataNroTransferencias("ser_doc", I).Value
            cNumero = dataNroTransferencias("nro_doc", I).Value
            nOperacion = dataNroTransferencias("operacion", I).Value
            cAlma = mTransferencia.recuperaAlmacenTrans_dest(False, cSerie, cNumero)
            cArea = mTransferencia.recuperaAreaTrans_dest(False, cSerie, cNumero)
            cad = "Update salida set cAux='" & cAlma & "'," & "cAux2='" & cArea & "' where operacion=" & nOperacion
            com.CommandText = cad
            com.ExecuteNonQuery()
        Next
        MessageBox.Show("Finalizado")
    End Sub
    Function validaRelacion()
        Dim resp As Boolean = True
        Dim mAlmacen As New Almacen
        Dim msalida As New Salida
        Dim cod_art = dataArticulos("cod_art", dataArticulos.CurrentRow.Index).Value

        If cCatalogoDestino = "" Then
            MessageBox.Show("Seleccione el Almacén Destino...", "ALMACEN", _
                                             MessageBoxButtons.OK, MessageBoxIcon.Stop)
            cboDestino.Focus()
            resp = False
        ElseIf Len(lblProducto.Text) > 0 Then
            MessageBox.Show("Ingrese la cantidad a Trasferir...", "ALMACEN", _
                                             MessageBoxButtons.OK, MessageBoxIcon.Stop)
            resp = False
        ElseIf dataArticulos.RowCount > 0 Then
            If pCatalogoXalmacen And mAlmacen.tipoAlmacen("esCatalogo", cboOrigen.SelectedValue) Then
                If Not mAlmacen.existeArticulo_deAlmaGeneral(cCatalogoDestino, cod_art) And cCatalogoDestino <> mAlmacen.devuelveAlmacenPrincipal() Then
                    MessageBox.Show("NO Existe Producto Relacionado para" & Chr(13) _
                                    & Microsoft.VisualBasic.UCase(dataArticulos("nom_art", _
                                    dataArticulos.CurrentRow.Index).Value) _
                                    & " en " & cboDestino.Text, _
                                    "ALMACEN", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    resp = False
                End If
            End If
        End If
        'End If
        Return resp
    End Function

    Function validaTransferencia()
        Dim resul As Boolean = False
        If Microsoft.VisualBasic.Len(txtObservacion.Text) > 0 Then
            If cboOrigen.SelectedIndex >= 0 Then
                If cboDestino.SelectedIndex >= 0 Then
                    If cboOrigen.SelectedValue <> cboDestino.SelectedValue Then
                        'If dataArticulos("saldo", dataArticulos.CurrentRow.Index).Value > 0 Then
                        If Microsoft.VisualBasic.Len(txtTransferir.Text) > 0 And Val(txtTransferir.Text) > 0 Then
                            'If dataArticulos("saldo", dataArticulos.CurrentRow.Index).Value >= Val(txtTransferir.Text) Then
                            '    resul = True
                            'Else
                            '    MessageBox.Show("La Cantidad a Transferir NO puede ser Mayor que el Saldo Disponible", "ALMACEN", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            '    If ChkSinStock.Checked = True Then
                            '        resul = True
                            '    Else
                            '        txtTransferir.Focus()
                            '    End If
                            'End If
                            resul = True
                        Else
                            MessageBox.Show("Ingrese la Cantidad a Transferir...", "ALMACEN", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            txtTransferir.Focus()
                        End If
                        'Else
                        '    MessageBox.Show("Seleccione el Producto a Transferir...", "ALMACEN", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        '    dataArticulos.Focus()
                        'End If
                    Else
                        MessageBox.Show("Los Almacenes de Origen y Destino deben ser Distintos...", "ALMACEN", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    End If
                Else
                    MessageBox.Show("Seleccione el Almacén Destino...", "ALMACEN", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    cboDestino.Focus()
                End If
            Else
                MessageBox.Show("Seleccione el Almacén Origen...", "ALMACEN", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                cboOrigen.Focus()
            End If
        Else
            MessageBox.Show("Ingrese una Observacion...", "ALMACEN", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtObservacion.Focus()
        End If
        Return resul
    End Function
    Private Sub txtTransferir_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTransferir.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not (e.KeyChar = ChrW(Keys.Back)) And Not (e.KeyChar.Equals(sepDecimal)) Then
            e.KeyChar = ""
        Else
            If e.KeyChar = ChrW(13) Then
                cmdTransferir.Focus()
            End If
        End If
    End Sub

    Private Sub dataNroTransferencias_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles dataNroTransferencias.PreviewKeyDown
        'If seEliminaTransf() Then
        '    If e.KeyCode = Keys.Delete Then
        '        eliminaTransferencia()
        '    End If
        'End If
    End Sub
    Private Sub dataNroTransferencias_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dataNroTransferencias.SelectionChanged


        If dataNroTransferencias.RowCount Then
            _nroOperacion = dataNroTransferencias("operacion", dataNroTransferencias.CurrentRow.Index).Value
            If chkmostrarOC.Checked Then
                muestraOrdenC(_nroOperacion)
                'Dim mTransferencia As New Transferencia
                Dim cSerie As String = dataNroTransferencias("ser_doc", dataNroTransferencias.CurrentRow.Index).Value
                Dim cNumero As String = dataNroTransferencias("nro_doc", dataNroTransferencias.CurrentRow.Index).Value
                _nroTransferencia = CInt(cNumero)
                lblNroTransferencia.Text = "Nº " & cSerie & "-" & Microsoft.VisualBasic.Right("00000000" + Trim(Str(cNumero)), 8)
                cboOrigen.SelectedValue = "0008"
                cboDestino.SelectedValue = "0001"
                cboArea.SelectedValue = "0000"
                'txtObservacion.Text = mPedidos.recuperaObservacion(cSerie, cNumero)
                cboOrigen.Enabled = False
                cboDestino.Enabled = False
                cboArea.Enabled = False
            End If

            If chkMostrarTransferencias.Checked Then
                muestraTransferencias(_nroOperacion)
                Dim mTransferencia As New Transferencia
                Dim cSerie As String = dataNroTransferencias("ser_doc", dataNroTransferencias.CurrentRow.Index).Value
                Dim cNumero As String = dataNroTransferencias("nro_doc", dataNroTransferencias.CurrentRow.Index).Value
                _nroTransferencia = CInt(cNumero)
                lblNroTransferencia.Text = "Nº " & cSerie & "-" & Microsoft.VisualBasic.Right("00000000" + Trim(Str(cNumero)), 8)
                vfOpeIngreso = mTransferencia.recuperaOperacionTrans_i(cSerie, cNumero)
                vfOpeSalida = mTransferencia.recuperaOperacionTrans_s(cSerie, cNumero)
                cboOrigen.SelectedValue = mTransferencia.recuperaAlmacenTrans_Orig(False, cSerie, cNumero)
                cboDestino.SelectedValue = mTransferencia.recuperaAlmacenTrans_dest(False, cSerie, cNumero)
                cboArea.SelectedValue = mTransferencia.recuperaAreaTrans_dest(False, cSerie, cNumero)
                txtObservacion.Text = mTransferencia.recuperaObservacion(cSerie, cNumero)
                cboOrigen.Enabled = False
                cboDestino.Enabled = True
                cboArea.Enabled = True
            End If

            If chkMostrarPedidos.Checked Then
                muestraPedidos(_nroOperacion)
                Dim mPedidos As New pedido
                Dim cSerie As String = dataNroTransferencias("ser_doc", dataNroTransferencias.CurrentRow.Index).Value
                Dim cNumero As String = dataNroTransferencias("nro_doc", dataNroTransferencias.CurrentRow.Index).Value
                lblNroTransferencia.Text = "Nº " & cSerie & "-" & Microsoft.VisualBasic.Right("00000000" + Trim(Str(cNumero)), 8)
                cboOrigen.SelectedValue = "0001"
                cboDestino.SelectedValue = mPedidos.recuperaAlmacenTrans_dest(False, cSerie, cNumero)
                cboArea.SelectedValue = mPedidos.recuperaAreaTrans_dest(False, cSerie, cNumero)
                txtObservacion.Text = mPedidos.recuperaObservacion(cSerie, cNumero)
                cboOrigen.Enabled = True
                cboDestino.Enabled = True
                cboArea.Enabled = True
            End If

            If Chk_pedpendiente.Checked Then
                muestraPedidosPend(_nroOperacion)
                Dim mPedidos As New pedido
                Dim cSerie As String = dataNroTransferencias("ser_doc", dataNroTransferencias.CurrentRow.Index).Value
                Dim cNumero As String = dataNroTransferencias("nro_doc", dataNroTransferencias.CurrentRow.Index).Value
                lblNroTransferencia.Text = "Nº " & cSerie & "-" & Microsoft.VisualBasic.Right("00000000" + Trim(Str(cNumero)), 8)
                cboOrigen.SelectedValue = "0001"
                cboDestino.SelectedValue = mPedidos.recuperaAlmacenTrans_dest(False, cSerie, cNumero)
                cboArea.SelectedValue = mPedidos.recuperaAreaTrans_dest(False, cSerie, cNumero)
                txtObservacion.Text = mPedidos.recuperaObservacion(cSerie, cNumero)
                cboOrigen.Enabled = True
                cboDestino.Enabled = True
                cboArea.Enabled = True
            End If
        Else
            _nroTransferencia = 0
            lblNroTransferencia.Text = "Nº "
            vfOpeSalida = 0
            vfOpeIngreso = 0
            cboDestino.SelectedIndex = -1
            txtObservacion.Text = ""
            cboOrigen.Enabled = True
            cboDestino.Enabled = True
            cboArea.Enabled = True
        End If


    End Sub
    Private Sub txtBuscarTransferencia_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscarTransferencia.Enter
        'If chkMostrarTransferencias.Checked = False Then
        '    chkMostrarTransferencias.Focus()
        'End If
    End Sub


    Private Sub txtBuscarTransferencia_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscarTransferencia.TextChanged
        Dim valor As String = txtBuscarTransferencia.Text
        dsNrosTransferencia.Tables("nrosTransferencia").DefaultView.RowFilter = "nro_doc LIKE '%" & valor & "%'"
        If dataNroTransferencias.RowCount > 0 Then
            dataNroTransferencias.CurrentCell = dataNroTransferencias("doc", dataNroTransferencias.CurrentRow.Index)
        End If
    End Sub
    Sub muestraTransferencias(ByVal nroOperacion As Integer)
        Dim mTransferencia As New Transferencia
        'crear_campocheck()
        dsTransferencias = mTransferencia.recuperaTransferencia(nroOperacion)
        With dataTransferencias
            .DataSource = dsTransferencias.Tables("transferencia")
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("fec_doc").HeaderText = "Fecha"
            .Columns("fec_doc").Width = 70
            .Columns("fec_doc").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("fec_doc").ReadOnly = True
            .Columns("origen").HeaderText = "Almacén Origen"
            .Columns("origen").Width = 120
            .Columns("origen").DefaultCellStyle.BackColor = Color.AliceBlue
            .Columns("origen").ReadOnly = True
            .Columns("doc").HeaderText = "Nro Transferencia"
            .Columns("doc").Width = 90
            .Columns("doc").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("doc").ReadOnly = True
            .Columns("cod_art").HeaderText = "Código"
            .Columns("cod_art").Width = 54
            .Columns("cod_art").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_art").ReadOnly = True
            .Columns("nom_art").HeaderText = "Descripción"
            .Columns("nom_art").Width = 230
            .Columns("nom_art").ReadOnly = True
            .Columns("nom_uni").HeaderText = "UND"
            .Columns("nom_uni").Width = 60
            .Columns("nom_uni").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("nom_uni").ReadOnly = True
            .Columns("cant_ped").HeaderText = "Cant. Pedido"
            .Columns("cant_ped").Width = 54
            .Columns("cant_ped").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cant_ped").DefaultCellStyle.BackColor = Color.AliceBlue
            .Columns("cant_ped").ReadOnly = True
            .Columns("cant").HeaderText = "Cant. Entrega"
            .Columns("cant").Width = 54
            .Columns("cant").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cant").DefaultCellStyle.BackColor = Color.AliceBlue
            .Columns("cant").ReadOnly = True
            .Columns("cant_stock").HeaderText = "Cant. Stock"
            .Columns("cant_stock").Width = 54
            .Columns("cant_stock").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cant_stock").DefaultCellStyle.BackColor = Color.AliceBlue
            .Columns("cant_stock").ReadOnly = True
            .Columns("precio").HeaderText = "Precio Costo"
            .Columns("precio").Width = 60
            .Columns("precio").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("precio").ReadOnly = True
            .Columns("destino").HeaderText = "Almacén Destino"
            .Columns("destino").Width = 120
            .Columns("destino").DefaultCellStyle.BackColor = Color.AliceBlue
            .Columns("destino").ReadOnly = True
            .Columns("doc").Visible = False
            .Columns("salida").Visible = False
            .Columns("operacion").Visible = False
            .Columns("ingreso").Visible = False
            .Columns("ser_doc").Visible = False
            .Columns("nro_doc").Visible = False
            .Columns("operacionI").Visible = False
            .Columns("nAux").Visible = False
            .Columns("fecha").Visible = False
            .Columns("fec_prod").Visible = False
            .Columns("cuenta").Visible = False
            '.Columns("esPendiente").Visible = False
        End With
        ' borrar_campocheck()

        lblRegistros.Text = "Nro de Registros Procesados..." & dataTransferencias.RowCount
    End Sub
    Sub muestraOrdenC(ByVal nroOperacion As Integer)
        Dim mpedido As New pedido

        crear_campocheck()

        dsTransferencias = mpedido.recuperaOrdenC(nroOperacion)
        dtTransferencia = dsTransferencias.Tables("transferencia")
        With dataTransferencias
            .DataSource = dsTransferencias.Tables("transferencia")
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("fec_doc").HeaderText = "Fecha"
            .Columns("fec_doc").Width = 70
            .Columns("fec_doc").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("fec_doc").ReadOnly = True
            .Columns("origen").HeaderText = "Almacén Origen"
            .Columns("origen").Width = 120
            .Columns("origen").DefaultCellStyle.BackColor = Color.AliceBlue
            .Columns("origen").ReadOnly = True
            .Columns("doc").HeaderText = "Nro Transferencia"
            .Columns("doc").Width = 90
            .Columns("doc").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("doc").ReadOnly = True
            .Columns("cod_art").HeaderText = "Código"
            .Columns("cod_art").Width = 54
            .Columns("cod_art").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_art").ReadOnly = True
            .Columns("nom_art").HeaderText = "Descripción"
            .Columns("nom_art").Width = 230
            .Columns("nom_art").ReadOnly = True
            .Columns("nom_uni").HeaderText = "UND"
            .Columns("nom_uni").Width = 60
            .Columns("nom_uni").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("nom_uni").ReadOnly = True
            .Columns("cant_ped").HeaderText = "Cant Pedida"
            .Columns("cant_ped").Width = 50
            .Columns("cant_ped").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cant_ped").DefaultCellStyle.BackColor = Color.AliceBlue
            .Columns("cant_ped").ReadOnly = True
            .Columns("cant").HeaderText = "Cant."
            .Columns("cant").Width = 50
            .Columns("cant").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cant").DefaultCellStyle.BackColor = Color.LightYellow
            .Columns("cant").ReadOnly = False
            .Columns("precio").HeaderText = "Precio Costo"
            .Columns("precio").Width = 60
            .Columns("precio").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("precio").ReadOnly = True
            .Columns("destino").HeaderText = "Almacén Destino"
            .Columns("destino").Width = 120
            .Columns("destino").DefaultCellStyle.BackColor = Color.AliceBlue
            .Columns("destino").ReadOnly = True
            .Columns("operacion").Visible = False
            .Columns("orden").Visible = False
            .Columns("ser_doc").Visible = False
            .Columns("nro_doc").Visible = False
            .Columns("fec_ent").Visible = False
            .Columns("salida").Visible = False
            '.Columns("esPendiente").Visible = True
        End With

        'borrar_campocheck()



        lblRegistros.Text = "Nro de Registros Procesados..." & dataTransferencias.RowCount
    End Sub

    Sub muestraPedidos(ByVal nroOperacion As Integer)
        Dim mpedido As New pedido

        crear_campocheck()

        dsTransferencias = mpedido.recuperaPedido(nroOperacion)
        dtTransferencia = dsTransferencias.Tables("transferencia")
        With dataTransferencias
            .DataSource = dsTransferencias.Tables("transferencia")
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("fec_doc").HeaderText = "Fecha"
            .Columns("fec_doc").Width = 70
            .Columns("fec_doc").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("fec_doc").ReadOnly = True
            .Columns("origen").HeaderText = "Almacén Origen"
            .Columns("origen").Width = 120
            .Columns("origen").DefaultCellStyle.BackColor = Color.AliceBlue
            .Columns("origen").ReadOnly = True
            .Columns("doc").HeaderText = "Nro Transferencia"
            .Columns("doc").Width = 90
            .Columns("doc").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("doc").ReadOnly = True
            .Columns("cod_art").HeaderText = "Código"
            .Columns("cod_art").Width = 54
            .Columns("cod_art").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_art").ReadOnly = True
            .Columns("nom_art").HeaderText = "Descripción"
            .Columns("nom_art").Width = 230
            .Columns("nom_art").ReadOnly = True
            .Columns("nom_uni").HeaderText = "UND"
            .Columns("nom_uni").Width = 60
            .Columns("nom_uni").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("nom_uni").ReadOnly = True
            .Columns("cant_ped").HeaderText = "Cant. Pedido"
            .Columns("cant_ped").Width = 54
            .Columns("cant_ped").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cant_ped").DefaultCellStyle.BackColor = Color.AliceBlue
            .Columns("cant_ped").ReadOnly = True
            .Columns("cant").HeaderText = "Cant. Entrega"
            .Columns("cant").Width = 54
            .Columns("cant").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cant").DefaultCellStyle.BackColor = Color.LightYellow
            .Columns("cant").ReadOnly = False
            .Columns("cant_stock").HeaderText = "Cant. Stock"
            .Columns("cant_stock").Width = 54
            .Columns("cant_stock").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cant_stock").DefaultCellStyle.BackColor = Color.LightYellow
            .Columns("cant_stock").ReadOnly = False
            .Columns("precio").HeaderText = "Precio Costo"
            .Columns("precio").Width = 60
            .Columns("precio").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("precio").ReadOnly = True
            .Columns("destino").HeaderText = "Almacén Destino"
            .Columns("destino").Width = 120
            .Columns("destino").DefaultCellStyle.BackColor = Color.AliceBlue
            .Columns("destino").ReadOnly = True
            .Columns("operacion").Visible = False
            .Columns("orden").Visible = False
            .Columns("ser_doc").Visible = False
            .Columns("nro_doc").Visible = False
            .Columns("fec_ent").Visible = False
            .Columns("salida").Visible = False
            .Columns("cuenta").Visible = False
            '.Columns("esPendiente").Visible = True
        End With

        'borrar_campocheck()



        lblRegistros.Text = "Nro de Registros Procesados..." & dataTransferencias.RowCount
    End Sub
    Sub muestraPedidosPend(ByVal nroOperacion As Integer)
        Dim mpedido As New pedido

        crear_campocheck()

        dsTransferencias = mpedido.recuperaPedidoPend(nroOperacion)
        dtTransferencia = dsTransferencias.Tables("transferencia")
        With dataTransferencias
            .DataSource = dsTransferencias.Tables("transferencia")
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("fec_doc").HeaderText = "Fecha"
            .Columns("fec_doc").Width = 70
            .Columns("fec_doc").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("fec_doc").ReadOnly = True
            .Columns("origen").HeaderText = "Almacén Origen"
            .Columns("origen").Width = 120
            .Columns("origen").DefaultCellStyle.BackColor = Color.AliceBlue
            .Columns("origen").ReadOnly = True
            .Columns("doc").HeaderText = "Nro Transferencia"
            .Columns("doc").Width = 90
            .Columns("doc").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("doc").ReadOnly = True
            .Columns("cod_art").HeaderText = "Código"
            .Columns("cod_art").Width = 54
            .Columns("cod_art").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_art").ReadOnly = True
            .Columns("nom_art").HeaderText = "Descripción"
            .Columns("nom_art").Width = 230
            .Columns("nom_art").ReadOnly = True
            .Columns("nom_uni").HeaderText = "UND"
            .Columns("nom_uni").Width = 60
            .Columns("nom_uni").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("nom_uni").ReadOnly = True
            .Columns("cant_ped").HeaderText = "Cant Pedida"
            .Columns("cant_ped").Width = 50
            .Columns("cant_ped").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cant_ped").DefaultCellStyle.BackColor = Color.AliceBlue
            .Columns("cant_ped").ReadOnly = True
            .Columns("cant").HeaderText = "Cant."
            .Columns("cant").Width = 50
            .Columns("cant").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cant").DefaultCellStyle.BackColor = Color.LightYellow
            .Columns("cant").ReadOnly = False
            .Columns("precio").HeaderText = "Precio Costo"
            .Columns("precio").Width = 60
            .Columns("precio").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("precio").ReadOnly = True
            .Columns("cuenta").Visible = False
            '.Columns("destino").HeaderText = "Almacén Destino"
            '.Columns("destino").Width = 120
            '.Columns("destino").DefaultCellStyle.BackColor = Color.AliceBlue
            '.Columns("destino").ReadOnly = True
            .Columns("operacion").Visible = False
            '.Columns("orden").Visible = False
            .Columns("ser_doc").Visible = False
            .Columns("nro_doc").Visible = False
            '.Columns("fec_ent").Visible = False
            .Columns("salida").Visible = False
            '.Columns("esPendiente").Visible = True
        End With
        lblRegistros.Text = "Nro de Registros Procesados..." & dataTransferencias.RowCount
    End Sub
    Sub crear_campocheck()
        If dataTransferencias.Columns("esPendiente") Is Nothing Then ' si no existe
            Dim dgvColumnCheck As DataGridViewCheckBoxColumn
            dgvColumnCheck = New DataGridViewCheckBoxColumn()
            dataTransferencias.Columns.Add(dgvColumnCheck) 'Agregamos
            dgvColumnCheck.Name = "esPendiente"
            dgvColumnCheck.HeaderText = "PEND"
            dgvColumnCheck.Width = 40
            dgvColumnCheck.ReadOnly = False
        End If
    End Sub
    Sub borrar_campocheck()
        If Not (dataTransferencias.Columns("esPendiente") Is Nothing) Then ' si existe
            'Dim dgvColumnCheck As DataGridViewCheckBoxColumn
            'dgvColumnCheck = New DataGridViewCheckBoxColumn()
            dataTransferencias.Columns.Remove("esPendiente") 'Borramos
            'dgvColumnCheck.Name = "esPendiente"
            'dgvColumnCheck.HeaderText = "PEND"
            'dgvColumnCheck.Width = 40
            'dgvColumnCheck.ReadOnly = False
        End If
    End Sub

    Private Sub datatransferencias_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataTransferencias.CellDoubleClick
        If dataTransferencias.RowCount > 0 Then
            If esEditable() Then
                eliminaITEM()
            End If
        End If
    End Sub
    Private Sub datatransferencias_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles dataTransferencias.PreviewKeyDown
        If dataTransferencias.RowCount > 0 Then
            If esEditable() Then
                If e.KeyCode = Keys.Delete Then
                    eliminaITEM()
                End If
            End If
        End If
    End Sub
    Sub eliminaITEM()
        If chkMostrarPedidos.Checked Or Chk_pedpendiente.Checked Then
            Dim rpta As Integer
            rpta = MessageBox.Show("Esta Seguro de Eliminar el ITEM Seleccionado" + Chr(13) + "Este Proceso es Irreversible...", "ALMACEN", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2)
            If rpta = 6 Then
                dataTransferencias.Rows.Remove(dataTransferencias.CurrentRow)
            End If
        Else
            Dim mIngreso As New Ingreso, mSalida As New Salida, mTransferencia As New Transferencia
            Dim nroSalida As Integer = dataTransferencias("salida", dataTransferencias.CurrentRow.Index).Value
            'Dim nroOperacionS As Integer = dataTransferencias("operacion", dataTransferencias.CurrentRow.Index).Value
            'Dim nroOperacionI As Integer = dataTransferencias("operacionI", dataTransferencias.CurrentRow.Index).Value
            Dim nroIngreso As Integer = dataTransferencias("nAux", dataTransferencias.CurrentRow.Index).Value
            'Dim yaSalio As Integer = mIngreso.existeSalida(nroIngreso, False)
            'If yaSalio Then
            '    MessageBox.Show("El Registro Tiene Salidas, NO es Posible Eliminarlo...", "ALMACEN", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            'Else
            Dim rpta As Integer
                rpta = MessageBox.Show("Esta Seguro de Eliminar el ITEM Seleccionado" + Chr(13) + "Este Proceso es Irreversible...", "ALMACEN", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2)
                If rpta = 6 Then
                    mIngreso.eliminaDetalle(nroIngreso)
                    mSalida.actualizaDetalle(nroSalida, 0, 0, 0)
                    mSalida.eliminaItem(nroSalida)
                    dataTransferencias.Rows.Remove(dataTransferencias.CurrentRow)
                    If chkMostrarTransferencias.Checked = False Then
                        txtBuscarOrigen.Focus()
                    End If
                End If
            'End If
        End If
        lblRegistros.Text = "Nro de Registros Procesados..." & dataTransferencias.RowCount
        cargaSaldos()
    End Sub
    Function esEditable() As Boolean
        'Dim mSalida As New Salida
        Dim lfechaTrans As Date = mcFechatransferencia1.Value
        Dim mfecha = lfechaTrans.ToString("dd/MM/yyyy")
        Dim mfecha1 As Date = Date.Parse(mfecha)
        'Dim mfecha As Date = lfechaTrans.AddDays(pDiasModificarTrans)
        Dim resp As Boolean = False

        'lfechaTrans = dataTransferencias("fec_doc", dataTransferencias.CurrentRow.Index).Value
        If mfecha1 <= pFechaSystem Then
            'If mSalida.devuelve_operacionINC(dataTransferencias("operacion", dataTransferencias.CurrentRow.Index).Value) = 1 Then
            '    If mSalida.devuelve_operacionINC(vfOpeSalida) = 1 Then
            ' MessageBox.Show("Documento Cerrado...", "ALMACEN",
            'MessageBoxButtons.OK, MessageBoxIcon.Stop)
            '    Else
            resp = True
            '    End If
            'End If
        End If
        'resp = True
        Return resp
    End Function
    Function seEliminaTransf() As Boolean
        Dim mSalida As New Salida
        Dim lfechaTrans As Date
        lfechaTrans = dataNroTransferencias("fec_doc", dataNroTransferencias.CurrentRow.Index).Value
        If lfechaTrans.AddDays(pDiasModificarTrans) <= pFechaSystem Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub SimpleButton1_Click_1(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim mSalida As New Salida, mIngreso As New Ingreso, mTransferencia As New Transferencia, mprecio As New ePrecio, rpta As Integer
        Dim nroSalida, nroIngreso, nIngreso As Integer, tm As String, tc As Decimal, esAfecto As Boolean
        Dim mUnidad As New Unidad, mPedido As New pedido
        Dim cod_art As String, cantidad, cant_ped, precio As Decimal
        Dim mFecha As Date = mcFechatransferencia1.Value
        Dim mFechaProd As Date = mcFechaProd.Value
        Dim nro_salida As Integer
        Dim esPendiente As Boolean
        tm = "S"


        If chkMostrarTransferencias.Checked Then
            rpta = MessageBox.Show(" Se va Actualizar la Transferencia " + Chr(13) + "¿Esta Seguro...?", "SGA", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If rpta = 6 Then
                mSalida.actualizaCabeceraTransf(vfOpeSalida, mFecha, mFechaProd, txtObservacion.Text, cboDestino.SelectedValue, cboArea.SelectedValue)
                mIngreso.actualizaCabeceraTransf(vfOpeIngreso, mFecha, cboDestino.SelectedValue, cboArea.SelectedValue)
            End If
        End If
        If chkMostrarPedidos.Checked Or Chk_pedpendiente.Checked Then

            rpta = MessageBox.Show("Se Va realizar la Transferencia " + Chr(13) + "¿Esta Seguro...?", "SGA", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If rpta = 6 Then
                'al generar el nro de transferencia, se generan los numeros de
                'operacion, tanto de salida como de ingreso
                generaNumeroTransferencia()
                Dim lser_doc As String = dataNroTransferencias("ser_doc", dataNroTransferencias.CurrentRow.Index).Value
                Dim lnro_doc As String = dataNroTransferencias("nro_doc", dataNroTransferencias.CurrentRow.Index).Value
                Dim ope_pedido As Integer = dataNroTransferencias("operacion", dataNroTransferencias.CurrentRow.Index).Value
                Dim cuenta As String = dataTransferencias("cuenta", 0).Value
                mPedido.actualizafacturado(ope_pedido, 1)

                mSalida.insertar_aux(vfOpeSalida, ope_pedido, "90",
                                            lser_doc,
                                            lnro_doc, mFecha, mFechaProd,
                                            "00000000", "00000000000", "00", 1, 0, pDecimales,
                                                cboOrigen.SelectedValue, IIf(cboArea.SelectedIndex <> -1, cboArea.SelectedValue, "0000"), txtObservacion.Text, "00", cuenta, pCuentaUser, 0, cboDestino.SelectedValue,
                                                IIf(cboArea.SelectedIndex <> -1, cboArea.SelectedValue, "0000"))
                mIngreso.insertar(vfOpeIngreso, "90",
                                            lser_doc, lnro_doc,
                                            "000", "00000000", 0,
                                            mFecha, "00000000000", "01", cboDestino.SelectedValue, IIf(cboArea.SelectedIndex <> -1,
                                            cboArea.SelectedValue, "0000"), 1, 0, pDecimales,
                                            cboArea.Text, tm, tc, pCuentaUser, pmaquina)
                cboOrigen.Enabled = False
                cboDestino.Enabled = False
                'en el detalle de la salida grabamos el nro de ingreso del almacen destino
                'para poder determinar el registro relacionado
                'cuando se transfiere el documento completo, se graba en nAux2 la operacion del ingreso
                mSalida.actualizaPendientes(dataTransferencias("operacion", 0).Value, 0, True)
                Dim I As Integer
                For I = 0 To dataTransferencias.RowCount - 1

                    cod_art = dataTransferencias("cod_art", I).Value
                    cantidad = dataTransferencias("cant", I).Value
                    cant_ped = dataTransferencias("cant_ped", I).Value
                    precio = dataTransferencias("precio", I).Value
                    esPendiente = dataTransferencias("esPendiente", I).Value

                    nroSalida = mSalida.maxSalida
                    nIngreso = mIngreso.maxIngreso
                    nroIngreso = nIngreso

                    mSalida.insertar_detsalida(vfOpeSalida, nroSalida, nroIngreso,
                                            cod_art, cantidad, cant_ped, precio, IIf(esAfecto, pIGV, 0), 0, 0, pCuentaUser, nIngreso, 0, esPendiente)
                    mIngreso.insertar_det(vfOpeIngreso, nIngreso, cod_art, cantidad, precio, pCuentaUser, IIf(esAfecto, pIGV, 0))
                    mSalida.actualizaPendientes(vfOpeSalida, nro_salida, False)

                    'mprecio.actualizaPrecioPromedio(cod_art)
                Next


                'limpiamos los numeros de transferencia
                If _nroTransferencia > 0 Then
                    dsNrosTransferencia.Clear()
                    chkMostrarTransferencias.Checked = False
                End If
                'cargamos los saldos del almacen seleccionado
                cargaSaldos()
                'mostramos las transferencias en la grilla
                muestraTransferencias(vfOpeSalida)
                txtTransferir.Text = ""
                txtBuscarOrigen.Focus()
                lblRegistros.Text = "Nro de Registros Procesados..." & dataTransferencias.RowCount

            End If
        End If
        If chkmostrarOC.Checked Then

                rpta = MessageBox.Show("Se Va realizar la Transferencia " + Chr(13) + "¿Esta Seguro...?", "SGA", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If rpta = 6 Then
                    'al generar el nro de transferencia, se generan los numeros de
                    'operacion, tanto de salida como de ingreso
                    generaNumeroTransferencia()
                    Dim lser_doc As String = dataNroTransferencias("ser_doc", dataNroTransferencias.CurrentRow.Index).Value
                    Dim lnro_doc As String = dataNroTransferencias("nro_doc", dataNroTransferencias.CurrentRow.Index).Value
                Dim ope_oc As Integer = dataNroTransferencias("operacion", dataNroTransferencias.CurrentRow.Index).Value

                Dim rucprovee As String = mPedido.recupera_rucProveedor(ope_oc)

                mIngreso.insertar(vfOpeIngreso, "40",
                                                lser_doc, lnro_doc,
                                                "000", "00000000", ope_oc,
                                                mFecha, rucprovee, "01", cboDestino.SelectedValue, IIf(cboArea.SelectedIndex <> -1,
                                                cboArea.SelectedValue, "0000"), 1, 0, pDecimales,
                                                cboArea.Text, tm, tc, pCuentaUser, pmaquina)
                cboOrigen.Enabled = False
                cboDestino.Enabled = False

                'mSalida.actualizaPendientes(dataTransferencias("operacion", 0).Value, 0, True)
                Dim I As Integer
                    For I = 0 To dataTransferencias.RowCount - 1

                        cod_art = dataTransferencias("cod_art", I).Value
                        cantidad = dataTransferencias("cant", I).Value
                        cant_ped = dataTransferencias("cant_ped", I).Value
                        precio = dataTransferencias("precio", I).Value
                        esPendiente = dataTransferencias("esPendiente", I).Value


                    nIngreso = mIngreso.maxIngreso
                    nroIngreso = nIngreso

                    mIngreso.insertar_det(vfOpeIngreso, nIngreso, cod_art, cantidad, precio, pCuentaUser, IIf(esAfecto, pIGV, 0))
                    'mSalida.actualizaPendientes(vfOpeSalida, nro_salida, False)

                    'mprecio.actualizaPrecioPromedio(cod_art)
                Next
                mPedido.actualiza_EstadoOrden(ope_oc)

                'limpiamos los numeros de transferencia
                If _nroTransferencia > 0 Then
                        dsNrosTransferencia.Clear()
                        chkMostrarTransferencias.Checked = False
                    End If
                    'cargamos los saldos del almacen seleccionado
                    cargaSaldos()
                    'mostramos las transferencias en la grilla
                    muestraTransferencias(vfOpeSalida)
                    txtTransferir.Text = ""
                    txtBuscarOrigen.Focus()
                    lblRegistros.Text = "Nro de Registros Procesados..." & dataTransferencias.RowCount

                End If

        End If

        MessageBox.Show("Documento Registrado Correctamente!!...", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub cmdNuevaT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevaT.Click
        _nroTransferencia = 0
        vfOpeSalida = 0
        vfOpeIngreso = 0
        lblNroTransferencia.Text = "Nº"

        dsTransferencias.Clear()
        cboOrigen.Enabled = True
        cboDestino.Enabled = True
        txtObservacion.Text = ""
        If cboArea.SelectedIndex >= 0 Then
            cboArea.Enabled = True
        End If
        chkmostrarOC.Enabled = True
        chkMostrarPedidos.Enabled = True
        chkMostrarTransferencias.Enabled = True
        Chk_pedpendiente.Enabled = True

        chkmostrarOC.Checked = False
        chkMostrarPedidos.Checked = False
        chkMostrarTransferencias.Checked = False
        Chk_pedpendiente.Checked = False



        cboOrigen.Focus()
        lblRegistros.Text = "Nro de Registros Procesados..." & dataTransferencias.RowCount
    End Sub

    Private Sub chkMostrarPedidos_CheckedChanged(sender As Object, e As EventArgs) Handles chkMostrarPedidos.CheckedChanged
        If _nroTransferencia = 0 Then
            If chkMostrarPedidos.Checked = True Then
                If Not estaCargando Then
                    Dim mpedido As New pedido
                    dsNrosTransferencia = mpedido.recuperaNrosPedido(pAlmaUser)
                    With dataNroTransferencias
                        .DataSource = dsNrosTransferencia.Tables("nrosTransferencia")
                        .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        .Columns("doc").HeaderText = "Nro Pedido"
                        .Columns("doc").Width = 120
                        .Columns("doc").ReadOnly = True
                        .Columns("doc").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        .Columns("ser_doc").Visible = False
                        .Columns("nro_doc").Visible = False
                        .Columns("fec_doc").Visible = False
                        .Columns("operacion").Visible = False
                    End With
                End If
            Else
                dsNrosTransferencia.Clear()
            End If
        Else
            chkmostrarOC.Checked = False
            chkMostrarPedidos.Checked = False
            Chk_pedpendiente.Checked = False
        End If


        If chkMostrarPedidos.Checked = True Then
            txtBuscarTransferencia.ReadOnly = False
            txtBuscarTransferencia.Focus()
            chkmostrarOC.Enabled = False
            chkMostrarPedidos.Enabled = False
            chkMostrarTransferencias.Enabled = False
            Chk_pedpendiente.Enabled = False
        Else
            txtBuscarTransferencia.ReadOnly = True
        End If
    End Sub
    Private Sub chkMostrarTransferencias_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMostrarTransferencias.CheckedChanged
        Dim esModifacado = False
        If _nroTransferencia = 0 Then
            If chkMostrarTransferencias.Checked = True Then
                If Not estaCargando Then
                    Dim mTransferencia As New Transferencia
                    dsNrosTransferencia = mTransferencia.recuperaNrosTransferencia(pAlmaUser)
                    With dataNroTransferencias
                        .DataSource = dsNrosTransferencia.Tables("nrosTransferencia")
                        .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        .Columns("doc").HeaderText = "Nro Transferencia"
                        .Columns("doc").Width = 90
                        .Columns("doc").ReadOnly = True
                        .Columns("doc").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        .Columns("ser_doc").Visible = False
                        .Columns("nro_doc").Visible = False
                        .Columns("fec_doc").Visible = False
                        .Columns("fec_prod").Visible = False
                        .Columns("operacion").Visible = False
                    End With
                End If
            Else
                dsNrosTransferencia.Clear()
            End If
        Else
            chkmostrarOC.Checked = False
            chkMostrarTransferencias.Checked = False
            Chk_pedpendiente.Checked = False
        End If
        If chkMostrarTransferencias.Checked = True Then
            txtBuscarTransferencia.ReadOnly = False
            txtBuscarTransferencia.Focus()
            chkmostrarOC.Enabled = False
            chkMostrarPedidos.Enabled = False
            chkMostrarTransferencias.Enabled = False
            Chk_pedpendiente.Enabled = False
        Else
            txtBuscarTransferencia.ReadOnly = True
        End If

    End Sub



    Private Sub Chk_pedpendiente_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_pedpendiente.CheckedChanged

        If _nroTransferencia = 0 Then
            If Chk_pedpendiente.Checked = True Then
                If Not estaCargando Then
                    Dim mpedido As New pedido
                    dsNrosTransferencia = mpedido.recuperaNrosPedido_pendientes(pAlmaUser)

                    With dataNroTransferencias
                        .DataSource = dsNrosTransferencia.Tables("nrosTransferencia")
                        .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        .Columns("doc").HeaderText = "Nro Pedido"
                        .Columns("doc").Width = 90
                        .Columns("doc").ReadOnly = True
                        .Columns("doc").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        .Columns("ser_doc").Visible = False
                        .Columns("nro_doc").Visible = False
                        .Columns("operacion").Visible = False

                    End With
                End If
            Else
                dsNrosTransferencia.Clear()
            End If
        Else
            chkmostrarOC.Checked = False
            chkMostrarTransferencias.Checked = False
            chkMostrarPedidos.Checked = False
        End If


        If Chk_pedpendiente.Checked = True Then
            txtBuscarTransferencia.ReadOnly = False
            txtBuscarTransferencia.Focus()
            chkmostrarOC.Enabled = False
            chkMostrarPedidos.Enabled = False
            chkMostrarTransferencias.Enabled = False
            Chk_pedpendiente.Enabled = False
        Else
            txtBuscarTransferencia.ReadOnly = True
        End If
    End Sub

    Private Sub chkmostrarOC_CheckedChanged(sender As Object, e As EventArgs) Handles chkmostrarOC.CheckedChanged

        If _nroTransferencia = 0 Then
            If chkmostrarOC.Checked = True Then
                If Not estaCargando Then
                    Dim mOrdenCompra As New Ingreso
                    dsNrosTransferencia = mOrdenCompra.recuperaNrosOC(pAlmaUser)

                    With dataNroTransferencias
                        .DataSource = dsNrosTransferencia.Tables("nrosTransferencia")
                        .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        .Columns("doc").HeaderText = "Nro OrdenCompra"
                        .Columns("doc").Width = 90
                        .Columns("doc").ReadOnly = True
                        .Columns("doc").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        .Columns("ser_doc").Visible = False
                        .Columns("nro_doc").Visible = False
                        .Columns("fec_doc").Visible = False
                        .Columns("operacion").Visible = False
                    End With
                End If
            Else
                dsNrosTransferencia.Clear()
            End If
        Else
            chkmostrarOC.Checked = False
            chkMostrarTransferencias.Checked = False
            Chk_pedpendiente.Checked = False
        End If

        If chkmostrarOC.Checked = True Then
            txtBuscarTransferencia.ReadOnly = False
            txtBuscarTransferencia.Focus()
            chkmostrarOC.Enabled = False
            chkMostrarPedidos.Enabled = False
            chkMostrarTransferencias.Enabled = False
            Chk_pedpendiente.Enabled = False
        Else
            txtBuscarTransferencia.ReadOnly = True
        End If


    End Sub

    Private Sub chkProduccion_CheckedChanged(sender As Object, e As EventArgs) Handles chkProduccion.CheckedChanged
        If Not estaCargando Then
            If chkProduccion.CheckState = CheckState.Checked Then
                chkProduccion.Text = "Articulos"
            Else
                chkProduccion.Text = "Producciones"
            End If
            'muestraArticulos(txtBuscarOrigen.Text)
            cargaSaldos()
            txtBuscarOrigen.Focus()

        End If
    End Sub

    Private Sub dataTransferencias_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataTransferencias.CellContentClick

    End Sub

    Private Sub dataNroTransferencias_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataNroTransferencias.CellContentClick
        If chkMostrarTransferencias.Checked Then
            If dataTransferencias.RowCount > 0 Then
                mcFechatransferencia1.Value = dataTransferencias("fec_doc", dataTransferencias.CurrentRow.Index).Value
                mcFechaProd.Value = dataTransferencias("fec_prod", dataTransferencias.CurrentRow.Index).Value
            End If
        End If
    End Sub

    Sub eliminaTransferencia()
        If dataTransferencias.RowCount > 0 Then
            MessageBox.Show("Primero debe Eliminar Los Items de la Transferencia Seleccionada...", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Else
            Dim lser_doc As String = dataNroTransferencias("ser_doc", dataNroTransferencias.CurrentRow.Index).Value
            Dim lnro_doc As String = dataNroTransferencias("nro_doc", dataNroTransferencias.CurrentRow.Index).Value
            Dim mIngreso As New Ingreso, mSalida As New Salida, mTransferencia As New Transferencia
            Dim nroOperacionS As Integer = dataNroTransferencias("operacion", dataNroTransferencias.CurrentRow.Index).Value
            Dim nroOperacionI As Integer = mTransferencia.recuperaOperacionTrans_i(lser_doc, lnro_doc)
            Dim rpta As Integer
            rpta = MessageBox.Show("Esta Seguro de Eliminar el Nro de Transferencia..." _
                    + Chr(13) + "Este Proceso es Irreversible...", "SGA",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2)
            If rpta = 6 Then
                If Not IsDBNull(dataNroTransferencias("operacion", dataNroTransferencias.CurrentRow.Index).Value) Then
                    mIngreso.eliminaCabecera(nroOperacionI, lnro_doc)
                    mSalida.eliminaCabecera(nroOperacionS)
                    dataNroTransferencias.Rows.Remove(dataNroTransferencias.CurrentRow)
                    txtBuscarTransferencia.Focus()
                End If
            End If
        End If
    End Sub
    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        If dataTransferencias.RowCount > 0 Then
            Dim chkValorizado As Boolean = ChKRptValorizado.Checked
            Dim fechaProceso As String = general.devuelveFechaImpresionSistema
            Dim periodoReporte As String = "Periodo: " & general.periodo_mesAnnoLetras(periodoActivo())
            Dim cUsuario As String = usuario.recuperaDatosUsuario(dataTransferencias("cuenta", dataTransferencias.CurrentRow.Index).Value)
            Dim frm As New rptForm
            Dim msalida As New Salida
            msalida.actualizaEstadoTransf(dataTransferencias("operacion", dataTransferencias.CurrentRow.Index).Value, 1)
            frm.cargarTransferencia(dsTransferencias, fechaProceso, periodoReporte, cUsuario, chkValorizado)
            frm.MdiParent = principal
            frm.Show()
        Else
            MessageBox.Show(general.str_textoNoImpresion, "ALMACEN", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If
    End Sub
    Private Sub txtBuscarTransferencia_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscarTransferencia.GotFocus
        If chkMostrarTransferencias.Checked = True Or chkMostrarPedidos.Checked = True Then
            Dim valor As String = txtBuscarTransferencia.Text
            dsNrosTransferencia.Tables("nrosTransferencia").DefaultView.RowFilter = "nro_doc LIKE '%" & valor & "%'"
            If dataNroTransferencias.RowCount > 0 Then
                dataNroTransferencias.CurrentCell = dataNroTransferencias("doc", dataNroTransferencias.CurrentRow.Index)
            End If
        End If
    End Sub


End Class
