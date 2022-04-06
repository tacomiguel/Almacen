Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Math
Imports libreriaClases
Public Class p_mermas
    Private dsOrigen As New DataSet
    Private dsAlmacen As New DataSet
    Private dsAlmacen_d As New DataSet
    Private dsMotivoBaja As New DataSet
    'Private dsSaldos As New DataSet
    Private dsBajas As New DataSet
    Private dsArea As New DataSet
    Private dsdocumento As New DataSet
    Private estaCargando As Boolean = True
    'para validar el separador decimal
    Private sepDecimal As Char
    Private Sub p_mermas_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        principal.mp_mermas.Enabled = True
    End Sub
    Private Sub p_mermas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'capturamos el separador     decimal
        sepDecimal = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        'fecha de proceso
        estableceFechaProceso()

        'dataset documento salida
        Dim daDocumento As New MySqlDataAdapter
        Dim comDoc As New MySqlCommand("select cod_doc,nom_doc from documento_s where activo=1 and cod_doc='92' or cod_doc='03' order by 2", dbConex)
        daDocumento.SelectCommand = comDoc
        daDocumento.Fill(dsDocumento, "documento")
        With cboDocumento
            .DataSource = dsDocumento.Tables("documento")
            .DisplayMember = dsDocumento.Tables("documento").Columns("nom_doc").ToString
            .ValueMember = dsDocumento.Tables("documento").Columns("cod_doc").ToString
            .SelectedIndex = 0
        End With
        ''dataset almacen
        'Dim daOrigen As New MySqlDataAdapter
        'Dim daAlmacen As New MySqlDataAdapter
        'Dim cadAlma As String
        'If pAlmaUser = "0000" Or pNivelUser = 0 Then
        '    cadAlma = "select cod_alma,nom_alma from almacen where activo=1 and ((esCompras) or (destinoTrans)) order by nom_alma"
        'Else
        '    mcFBaja.MaxDate = pFechaActivaMax
        '    mcFBaja.MinDate = pFechaActivaMin
        '    cadAlma = "select cod_alma,nom_alma from almacen where activo=1 and cod_alma='" & pAlmaUser & "' and ((esCompras) or (destinoTrans))"
        'End If
        'Dim comAlmacen As New MySqlCommand(cadAlma, dbConex)
        'daAlmacen.SelectCommand = comAlmacen
        'daAlmacen.Fill(dsAlmacen, "almacen")
        'With cboAlmacen
        '    .DataSource = dsAlmacen.Tables("almacen")
        '    .DisplayMember = dsAlmacen.Tables("almacen").Columns("nom_alma").ToString
        '    .ValueMember = dsAlmacen.Tables("almacen").Columns("cod_alma").ToString
        '    If dsAlmacen.Tables("almacen").Rows.Count > 0 Then
        '        .SelectedIndex = 0
        '    End If
        'End With

        'dataset motivo de baja
        Dim daMotivoBaja As New MySqlDataAdapter
        Dim comMotivoBaja As New MySqlCommand("select cod_baja,nom_baja from motivo_baja where activo=1 order by nom_baja", dbConex)
        daMotivoBaja.SelectCommand = comMotivoBaja
        daMotivoBaja.Fill(dsMotivoBaja, "motivoBaja")
        With cboBaja
            .DataSource = dsMotivoBaja.Tables("motivoBaja")
            .DisplayMember = dsMotivoBaja.Tables("motivoBaja").Columns("nom_baja").ToString
            .ValueMember = dsMotivoBaja.Tables("motivoBaja").Columns("cod_baja").ToString
            .SelectedIndex = -1
        End With
        cargaAlmacenes()
        estaCargando = False
        cargaSaldos()
        muestraBajas()
        muestraArea(cboAlmacen.SelectedValue)
    End Sub
    Sub estableceFechaProceso()

        mcFBaja.ResetMinDate()
        mcFBaja.MaxDate = pFechaSystem
        mcFBaja.DisplayMonth = pFechaSystem
        mcFBaja.SelectedDate = pFechaSystem
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
        'Dim comAlmacen_o As New MySqlCommand(cadena, dbConex)
        Dim comAlmacen_d As New MySqlCommand(cadena_dest, dbConex)
        'daAlmacen_o.SelectCommand = comAlmacen_o
        daAlmacen_d.SelectCommand = comAlmacen_d
        ' daAlmacen_o.Fill(dsAlmacen_o, "almacen")
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
    Sub cargaSaldos()
        If cboAlmacen.SelectedIndex >= 0 Then
            dsOrigen.Clear()
            Dim mOrigen As New Catalogo
            Dim mAlmacen As New Almacen
            Dim cAlma As String = cboAlmacen.SelectedValue
            Dim cAlmaCatalogo As String = mAlmacen.devuelveAlmacenCatalogo(cAlma)
            Dim xProduccion As Boolean = IIf(chkProduccion.Checked = True, True, False)
            Dim xAlma As Boolean = IIf(chkProduccion.Checked = True, True, False)
            Dim cCatalogoOrigen = IIf(xProduccion = False, cAlma, cAlmaCatalogo)

            dsOrigen = mOrigen.recuperaCatalogo(xAlma, cCatalogoOrigen, True, False, False, False, "", False, xProduccion, False)
            dataArticulos.DataSource = dsOrigen.Tables("articulo").DefaultView
            estructuraArticulos()
        End If
    End Sub
    Sub estructuraArticulos()
        With dataArticulos

            .DataSource = dsOrigen.Tables("articulo").DefaultView
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_art").HeaderText = "Código"
            .Columns("cod_art").Width = 60
            .Columns("cod_art").ReadOnly = True
            .Columns("cod_art").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("nom_art").HeaderText = "Descripción"
            .Columns("nom_art").Width = 300
            .Columns("nom_art").ReadOnly = True
            .Columns("nom_uni").HeaderText = "Unidad"
            .Columns("nom_uni").Width = 70
            .Columns("nom_uni").ReadOnly = True
            .Columns("nom_uni").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            .Columns("cod_uni").Visible = False
            .Columns("cant_uni").Visible = False

            .Columns("maximo").Visible = False
            .Columns("minimo").Visible = False
            .Columns("pre_ult").Visible = False
            .Columns("pre_costo").Visible = False
            .Columns("pre_costoMin").Visible = False
            .Columns("pre_costoMax").Visible = False
            .Columns("pre_prom").Visible = False
            .Columns("pre_ult").Visible = False

            .Columns("cod_sgrupo").Visible = False
            .Columns("nom_sgrupo").Visible = False

            .Columns("cod_alma").Visible = False

            .Columns("pre_venta").Visible = False
            .Columns("afecto_igv").Visible = False
            .Columns("pre_inc_imp").Visible = False
            .Columns("imp").Visible = False

            .Columns("activo").Visible = False
            .Columns("esProduccion").Visible = False
            .Columns("nom_tart").Visible = False
            .Columns("cuenta_v").Visible = False
            .Columns("cuenta_v_c").Visible = False
            .Columns("cuenta_c").Visible = False
            .Columns("cuenta_c_a1").Visible = False
            .Columns("cuenta_c_a2").Visible = False
            .Columns("cuenta_c_p").Visible = False

            .Columns("cod_artExt").Visible = False
            .Columns("cod_artExt1").Visible = False
            .Columns("cod_artExt2").Visible = False


        End With
    End Sub
    Sub muestraBajas()
        Dim mBajas As New Bajas
        Dim xAlmacen As Boolean = IIf(cboAlmacen.SelectedValue >= 0, True, False)
        Dim cAlmacen As String = IIf(xAlmacen, cboAlmacen.SelectedValue, "")
        Dim cfecha As Date = mcFBaja.SelectedDate
        Dim periodo As String = general.convierteFechaEspecificadaMes(cfecha)
        Dim esHistorial As Boolean = IIf(periodo >= periodoActivo(), False, True)
        dsBajas.Clear()
        dsBajas = mBajas.recuperaBajas(esHistorial, periodo, False, False, mcFBaja.SelectedDate, mcFBaja.SelectedDate, pDecimales, xAlmacen, cAlmacen, False, False, "", False, "", cboDocumento.SelectedValue.ToString)
        dataBajas.DataSource = dsBajas.Tables("mermas").DefaultView
        estructuraBajas()
        lblRegistros2.Text = "Nº de Registros..." & dataBajas.RowCount
    End Sub
    Sub estructuraBajas()
        With dataBajas
            .ReadOnly = True
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("fec_doc").HeaderText = "Fecha"
            .Columns("fec_doc").Width = 70
            .Columns("fec_doc").DisplayIndex = 0
            .Columns("fec_doc").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_art").HeaderText = "Código"
            .Columns("cod_art").Width = 60
            .Columns("cod_art").DisplayIndex = 1
            .Columns("cod_art").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("nom_art").HeaderText = "Descripción"
            .Columns("nom_art").Width = 240
            .Columns("nom_art").DisplayIndex = 2
            .Columns("nom_uni").HeaderText = "Unidad"
            .Columns("nom_uni").Width = 70
            .Columns("nom_uni").DisplayIndex = 3
            .Columns("nom_uni").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cant").HeaderText = "Cantidad"
            .Columns("cant").Width = 60
            .Columns("cant").DisplayIndex = 4
            .Columns("cant").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("pre_costo").HeaderText = "Costo"
            .Columns("pre_costo").Width = 60
            .Columns("pre_costo").DisplayIndex = 5
            .Columns("pre_costo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("monto").HeaderText = "Monto"
            .Columns("monto").Width = 73
            .Columns("monto").DisplayIndex = 6
            .Columns("monto").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("nom_alma").HeaderText = "Almacen"
            .Columns("nom_alma").Width = 120
            .Columns("nom_alma").DisplayIndex = 7
            .Columns("obs").HeaderText = "Observacion"
            .Columns("obs").Width = 200
            .Columns("obs").DisplayIndex = 8
            .Columns("operacion").Visible = False
            .Columns("operacion").DisplayIndex = 10
            .Columns("salida").Visible = False
            .Columns("salida").DisplayIndex = 10
            .Columns("doc").Visible = False
            .Columns("doc").DisplayIndex = 11
            .Columns("ser_doc").Visible = False
            .Columns("ser_doc").DisplayIndex = 12
            .Columns("nro_doc").Visible = False
            .Columns("nro_doc").DisplayIndex = 13
        End With
    End Sub
    Private Sub mcFBaja_ItemClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mcFBaja.ItemClick
        muestraBajas()
    End Sub
    Private Sub cboAlmacen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAlmacen.SelectedIndexChanged
        If Not estaCargando Then
            If cboAlmacen.SelectedIndex >= 0 Then
                cargaSaldos()
                muestraBajas()
                muestraArea(cboAlmacen.SelectedValue)
            End If
        End If
    End Sub
    Private Sub txtBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscar.KeyPress
        If e.KeyChar = ChrW(13) Then
            dataArticulos.Focus()
        End If
    End Sub
    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged
        Dim valor As String = txtBuscar.Text
        cargaSaldos()
        dsOrigen.Tables("articulo").DefaultView.RowFilter = "nom_art LIKE '" & valor & "%'"
        If dataArticulos.RowCount > 0 Then
            dataArticulos.CurrentCell = dataArticulos("cod_art", dataArticulos.CurrentRow.Index)
        End If
    End Sub
    Private Sub txtBuscar_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscar.GotFocus
        Dim valor As String = txtBuscar.Text
        txtBuscar.SelectAll()
        cargaSaldos()
        dsOrigen.Tables("articulo").DefaultView.RowFilter = "nom_art LIKE '" & valor & "%'"
        If dataArticulos.RowCount > 0 Then
            dataArticulos.CurrentCell = dataArticulos("cod_art", dataArticulos.CurrentRow.Index)
        End If
    End Sub
    Private Sub cboBaja_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboBaja.GotFocus
        If dsMotivoBaja.Tables("motivoBaja").Rows.Count > 0 And cboBaja.SelectedIndex = -1 Then
            cboBaja.SelectedIndex = 0
        End If
    End Sub
    Private Sub cboBaja_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboBaja.KeyPress
        If e.KeyChar = ChrW(13) Then
            txtBuscar.Focus()
        End If
    End Sub
    Private Sub dataArticulos_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dataArticulos.DoubleClick
        txtBaja.Focus()
    End Sub
    Private Sub dataArticulos_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dataArticulos.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtBaja.Focus()
        End If
    End Sub
    Private Sub txtBaja_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBaja.GotFocus
        general.ingresaTextoProceso(txtBaja)
    End Sub
    Private Sub txtBaja_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBaja.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not (e.KeyChar = ChrW(Keys.Back)) And Not (e.KeyChar.Equals(sepDecimal)) Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub txtBaja_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBaja.LostFocus
        general.saleTextoProceso(txtBaja)
    End Sub
    Private Sub cmdBaja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBaja.Click
        If mcFBaja.SelectedDate = pFechaSystem Or sePuedeMermar() Or pNivelUser = 0 Then
            If validaBaja() Then
                Dim mSalida As New Salida, mBajas As New Bajas, rpta, Operacions As Integer
                Dim cod_art, nom_art, num_documento, serBaja As String, cantidad, precio As Decimal, pre_incImp As Integer, Imp As Decimal
                Dim cfecha As Date = mcFBaja.SelectedDate
                Dim periodo As String = general.convierteFechaEspecificadaMes(cfecha)
                Dim esHistorial As Boolean = IIf(periodo >= periodoActivo(), False, True)
                dim cod_doc as string =cboDocumento.SelectedValue
                'nroSalida = mSalida.maxSalida
                'nroOperacion = mSalida.maxOperacion
                operacionS = IIf(esHistorial, mSalida.maxOperacion_his(periodo), mSalida.maxOperacion)
                num_documento = mSalida.maxNroSalida(cod_doc, "000")
                'cod_doc = Microsoft.VisualBasic.Right("00000000" & mBajas.maxBaja, 8)
                'nroIngreso = dataArticulos("ingreso", dataArticulos.CurrentRow.Index).Value
                cod_art = dataArticulos("cod_art", dataArticulos.CurrentRow.Index).Value
                nom_art = Microsoft.VisualBasic.UCase(dataArticulos("nom_art", dataArticulos.CurrentRow.Index).Value)
                pre_incImp = 0 'todas las bajas se dan con precio de costo. Sin incluir impuesto.
                'Imp = dataArticulos("igv", dataArticulos.CurrentRow.Index).Value
                serBaja = cboBaja.SelectedValue + "B"
                cantidad = txtBaja.Text
                precio = dataArticulos("pre_ult", dataArticulos.CurrentRow.Index).Value
                rpta = MessageBox.Show("Va a dar de Baja " & Chr(13) & nom_art & Chr(13) & "¿Esta Seguro...?", "SGA", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If rpta = 6 Then
                    'mSalida.insertar_aux(nroOperacion, 0, "92", serBaja, cod_doc, mcFBaja.SelectedDate, "00000000", "00000000000", "00", 1, pre_incImp, pDecimales, cboAlmacen.SelectedValue, IIf(cboArea.SelectedValue = "", "0000", cboArea.SelectedValue), txtObservacion.Text, "00", pCuentaUser, 0, "", "")
                    mSalida.insertar_aux(Operacions, 0, cod_doc, "000", num_documento, cfecha, cfecha, "00000000", "00000000000", "00", 1, 0, pDecimales, cboAlmacen.SelectedValue, IIf(cboArea.SelectedValue = "", "0000", cboArea.SelectedValue), txtObservacion.Text, "00", pCuentaUser, pCuentaUser, 0, 0, 0)

                    'como es baja, entonces el IGV es 0-cero
                    Dim nroSalida As Integer = IIf(esHistorial, mSalida.maxSalida_his(periodo), mSalida.maxSalida)
                    'mSalida.insertar_det(Operacions, nroSalida, nroIngreso, cod_art, cantidad, precio, Imp, 0, 0)


                    mSalida.insertar_detsalida(Operacions, nroSalida, 0,
                                            cod_art, cantidad, 0, precio, Imp, 0, 0, pCuentaUser, 0, 0, 0)
                    'mostramos las bajas en la grilla
                    muestraBajas()
                    txtBaja.Text = ""
                    txtBuscar.Focus()
                Else
                    txtBuscar.Focus()
                End If
            End If
        Else
            MessageBox.Show("Las Bajas solo se Realizan durante el día...", "CEFE", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If
    End Sub
    Function validaBaja()
        Dim result As Boolean = False
        If cboAlmacen.SelectedIndex >= 0 Then
            If cboDocumento.SelectedIndex >= 0 Then
                If dsOrigen.Tables("articulo").Rows.Count > 0 Then
                    If Microsoft.VisualBasic.Len(txtBaja.Text) > 0 And Val(txtBaja.Text) > 0 Then
                        'If dataArticulos("saldo", dataArticulos.CurrentRow.Index).Value >= Val(txtBaja.Text) Then
                        '    result = True
                        'Else
                        '    '    MessageBox.Show("La Cantidad a dar de Baja NO puede ser Mayor que el Saldo Disponible", "CEFE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        '    '    txtBaja.Focus()
                        result = True
                        'End If

                    Else
                        MessageBox.Show("Ingrese la Cantidad a dar de Baja...", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtBaja.Focus()
                    End If
                Else
                    MessageBox.Show("Seleccione el Producto a dar de Baja...", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtBuscar.Focus()
                End If
            Else
                MessageBox.Show("Seleccione el Documento de Salida..", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                cboBaja.Focus()
            End If
        Else
            MessageBox.Show("Seleccione el Almacén Origen...", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            cboAlmacen.Focus()
        End If
        Return result
    End Function
    Private Sub dataBajas_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataBajas.CellDoubleClick
        If esEditable() Then
            eliminaITEM()
            txtBuscar.Focus()
        End If
    End Sub

    Private Sub dataBajas_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles dataBajas.PreviewKeyDown
        If esEditable() Then
            If e.KeyCode = Keys.Delete Then
                eliminaITEM()
            End If
        End If
    End Sub
    Sub eliminaITEM()
        Dim mSalida As New Salida
        Dim cfecha As Date = mcFBaja.SelectedDate
        Dim periodo As String = general.convierteFechaEspecificadaMes(cfecha)
        Dim esHistorial As Boolean = IIf(periodo >= periodoActivo(), False, True)
        Dim nroOperacion As Integer = dataBajas("operacion", dataBajas.CurrentRow.Index).Value
        Dim nroSalida As Integer = dataBajas("salida", dataBajas.CurrentRow.Index).Value
        Dim rpta As Integer
        rpta = MessageBox.Show("Esta Seguro de Eliminar el ITEM Seleccionado" + Chr(13) + "Este Proceso es Irreversible...", "CEFE", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2)
        If rpta = 6 Then
            mSalida.actualizaDetalle_his(esHistorial, periodo, nroOperacion, nroSalida, 0, 0, 0)
            'mSalida.eliminaItem(nroSalida)
            'mSalida.eliminaCabecera(nroOperacion)
            'dataBajas.Rows.Remove(dataBajas.CurrentRow)
            muestraBajas()
        End If
    End Sub
    Function esEditable() As Boolean
        Dim mSalida As New Salida
        Dim lfechaBaja As Date
        lfechaBaja = dataBajas("fec_doc", dataBajas.CurrentRow.Index).Value
        If lfechaBaja.AddDays(pDiasModificarBaja) <= pFechaSystem Then
            Return False
        Else
            Return True
        End If
    End Function
    Function sePuedeMermar() As Boolean
        Dim mSalida As New Salida
        Dim lfechaBaja As Date = mcFBaja.SelectedDate
        If lfechaBaja.AddDays(pDiasModificarBaja) <= pFechaSystem Then
            Return False
        Else
            Return True
        End If
    End Function
    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        Dim frm As New rptForm
        Dim fechaReporte = general.devuelveFechaImpresionEspecificado(mcFBaja.SelectedDate)
        Dim periodoReporte = general.devuelvePeriodoImpresion(mcFBaja.SelectedDate)
        Dim cAlmacen As String = IIf(cboAlmacen.SelectedIndex >= 0, cboAlmacen.Text, "Integrado")
        frm.cargarMermas(dsBajas, cAlmacen, fechaReporte, periodoReporte, False)
        frm.MdiParent = principal
        frm.Show()
    End Sub



    Private Sub cboAlmacen_SelectedIndexChanged_1(sender As System.Object, e As System.EventArgs) Handles cboAlmacen.SelectedIndexChanged

    End Sub

    Private Sub cboBaja_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboBaja.SelectedIndexChanged
        txtObservacion.Text = cboBaja.Text
    End Sub

    Private Sub cboDocumento_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboDocumento.SelectedIndexChanged
        muestraBajas()
    End Sub

    Private Sub cboArea_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboArea.SelectedIndexChanged

    End Sub

    Private Sub dataBajas_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataBajas.CellContentClick

    End Sub

    Private Sub txtObservacion_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtObservacion.KeyPress
        

    End Sub

    Private Sub txtObservacion_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtObservacion.TextChanged

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
            txtBuscar.Focus()

        End If
    End Sub


End Class
