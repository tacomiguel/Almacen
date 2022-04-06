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
    '
    Private cCatalogoOrigen As String = "", cCatalogoDestino As String = ""
    Private estaCargando As Boolean = True
    Private _nroTransferencia, vfOpeSalida, vfOpeIngreso As Integer
    'para validar el separador decimal
    Private sepDecimal As Char
    Private Sub p_transferencia_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        principal.mp_transferencia.Enabled = True
    End Sub
    Private Sub p_transferencia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        _nroTransferencia = 0
        'cargamos los almacenes a mostrar
        cargaAlmacenes()
        estaCargando = False
        If dsAlmacen_o.Tables("almacen").Rows.Count > 0 Then
            cboOrigen.SelectedIndex = 0
        End If
        'capturamos el separador decimal
        sepDecimal = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
    End Sub
    Sub cargaAlmacenes()
        'dataset almacen origen/destino
        Dim daAlmacen_o As New MySqlDataAdapter
        Dim daAlmacen_d As New MySqlDataAdapter
        Dim comAlmacen_o As New MySqlCommand("select cod_alma,nom_alma from almacen where activo=1" _
                                & " and (origenTrans) order by nom_alma", dbConex)
        Dim comAlmacen_d As New MySqlCommand("select distinct almacen.cod_alma,nom_alma" _
                                & " from almacen left join area on almacen.cod_alma=area.cod_alma" _
                                & " where almacen.activo=1 and ((almacen.destinoTrans) or (area.destinoTrans))" _
                                & " order by nom_alma", dbConex)
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
                If _nroTransferencia = 0 Then
                    lblArea.Enabled = True
                    cboArea.Enabled = True
                    .SelectedIndex = 0
                End If
            Else
                lblArea.Enabled = False
                cboArea.Enabled = False
                .SelectedIndex = -1
            End If
        End With
    End Sub
    Sub cargaSaldos()
        If cboOrigen.SelectedIndex >= 0 Then
            dsOrigen.Clear()
            Dim mOrigen As New Catalogo
            dsOrigen = mOrigen.recuperaSaldos(False, "", True, True, cboOrigen.SelectedValue, False, "", False, False, "", pDecimales)
            dataArticulos.DataSource = dsOrigen.Tables("saldo").DefaultView
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
            .Columns("nom_art").Width = 230
            .Columns("nom_art").ReadOnly = True
            .Columns("nom_uni").HeaderText = "Unidad"
            .Columns("nom_uni").Width = 75
            .Columns("nom_uni").ReadOnly = True
            .Columns("nom_uni").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("saldo").HeaderText = "Saldo"
            .Columns("saldo").Width = 60
            .Columns("saldo").ReadOnly = True
            .Columns("saldo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("saldo").DefaultCellStyle.BackColor = Color.AliceBlue
            .Columns("ingreso").Visible = False
            .Columns("precio").Visible = False
            .Columns("maximo").Visible = False
            .Columns("minimo").Visible = False
            .Columns("pre_ult").Visible = False
            .Columns("cant_uni").Visible = False
            .Columns("es_divisible").Visible = False
            .Columns("afecto_igv").Visible = False
            .Columns("tm").Visible = False
            .Columns("tc").Visible = False
            .Columns("cod_sgrupo").Visible = False
            .Columns("nom_sgrupo").Visible = False
            .Columns("monto").Visible = False
            .Columns("cod_alma").Visible = False
            .Columns("nom_alma").Visible = False
            .Columns("pre_inc_igv").Visible = False
            .Columns("igv").Visible = False
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
        dsOrigen.Tables("saldo").DefaultView.RowFilter = "nom_art LIKE '" & valor & "%'"
        If dataArticulos.RowCount > 0 Then
            dataArticulos.CurrentCell = dataArticulos("cod_art", dataArticulos.CurrentRow.Index)
        End If
    End Sub
    Private Sub txtBuscarOrigen_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscarOrigen.GotFocus
        txtBuscarOrigen.SelectAll()
        'limpiamos los nros de transferencia
        If _nroTransferencia > 0 Then
            dsNrosTransferencia.Clear()
            If chkMostrarTransferencias.Checked = True Then
                chkMostrarTransferencias.Checked = False
                muestraTransferencias(vfOpeSalida)
            End If
        End If
        Dim valor As String = txtBuscarOrigen.Text
        dsOrigen.Tables("saldo").DefaultView.RowFilter = "nom_art LIKE '" & valor & "%'"
        If dataArticulos.RowCount > 0 Then
            dataArticulos.CurrentCell = dataArticulos("cod_art", dataArticulos.CurrentRow.Index)
        End If
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
        If validaRelacion() Then
            If validaTransferencia() Then
                Dim mSalida As New Salida, mIngreso As New Ingreso, mTransferencia As New Transferencia, rpta As Integer
                Dim nroSalida, nroIngreso, nIngreso As Integer, tm As String, tc As Decimal, esAfecto As Boolean
                Dim mUnidad As New Unidad
                Dim cod_art, nom_art As String, cantidad, cant_trans, precio, cant_uni As Decimal, es_div As Boolean
                Dim mFecha As Date
                If Month(pFechaActivaMax) = Month(pFechaSystem) Then
                    mFecha = pFechaSystem
                Else
                    mFecha = pFechaActivaMax
                End If
                'datos para la salida del producto
                nroSalida = mSalida.maxSalida
                nIngreso = mIngreso.maxIngreso
                nroIngreso = dataArticulos("ingreso", dataArticulos.CurrentRow.Index).Value
                cod_art = dataArticulos("cod_art", dataArticulos.CurrentRow.Index).Value
                nom_art = dataArticulos("nom_art", dataArticulos.CurrentRow.Index).Value
                cant_uni = dataArticulos("cant_uni", dataArticulos.CurrentRow.Index).Value
                cantidad = txtTransferir.Text
                precio = dataArticulos("precio", dataArticulos.CurrentRow.Index).Value
                tm = dataArticulos("tm", dataArticulos.CurrentRow.Index).Value
                tc = dataArticulos("tc", dataArticulos.CurrentRow.Index).Value
                esAfecto = dataArticulos("afecto_igv", dataArticulos.CurrentRow.Index).Value
                rpta = MessageBox.Show("Va a Transferir " + nom_art + Chr(13) + "¿Esta Seguro...?", "CEFE", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If rpta = 6 Then
                    If nroIngreso > 0 Then
                        If _nroTransferencia = 0 Then
                            'al generar el nro de transferencia, se generan los numeros de
                            'operacion, tanto de salida como de ingreso
                            generaNumeroTransferencia()
                            mSalida.insertar_aux(vfOpeSalida, 0, "90", _
                                    IIf(pCatalogoXalmacen = True And cCatalogoOrigen <> cCatalogoDestino, "T01", "T00"), _
                                    Microsoft.VisualBasic.Right("00000000" & _nroTransferencia, 8), mFecha, _
                                    "00000000", "00000000000", "00", 1, 0, pDecimales, _
                                        cboOrigen.SelectedValue, "", "00", pCuentaUser, 0, cboDestino.SelectedValue, _
                                        IIf(cboArea.SelectedIndex <> -1, cboArea.SelectedValue, "0000"))
                            mIngreso.insertar(vfOpeIngreso, "90", _
                                    IIf(pCatalogoXalmacen = True And cCatalogoOrigen <> cCatalogoDestino, "T01", "T00"), _
                                    Microsoft.VisualBasic.Right("00000000" & _nroTransferencia, 8), "000", "00000000", _
                                    mFecha, "00000000000", "01", cboDestino.SelectedValue, IIf(cboArea.SelectedIndex <> -1, _
                                    cboArea.SelectedValue, "0000"), 1, 0, pDecimales, _
                                    "Transferencia de Almacenes", tm, tc, pCuentaUser)
                            cboOrigen.Enabled = False
                            cboDestino.Enabled = False
                        End If
                        'en el detalle de la salida grabamos el nro de ingreso del almacen destino
                        'para poder determinar el registro relacionado
                        'cuando se transfiere el documento completo, se graba en nAux2 la operacion del ingreso
                        mSalida.insertar_detAux(vfOpeSalida, nroSalida, nroIngreso, _
                                            cod_art, cantidad, precio, IIf(esAfecto, pIGV, 0), 0, 0, nIngreso, 0)
                        Dim cod_artRel As String = ""
                        cant_trans = 0
                        If pCatalogoXalmacen And cCatalogoOrigen <> cCatalogoDestino Then
                            Dim mAlmacen As New Almacen, cod_uniRel, cant_uniRel As Decimal
                            cod_artRel = mAlmacen.devuelveCodigoArtRelacionado(cod_art, cCatalogoDestino)
                            cod_uniRel = mUnidad.devuelveUnidad(cod_artRel)
                            cant_uniRel = mUnidad.devuelveCantUnidad(cod_uniRel)
                            es_div = mUnidad.esDivisible(cod_uniRel)
                            If es_div Then
                                cant_trans = cantidad * cant_uni
                                precio = (precio / cant_uni) * cant_uniRel
                            Else
                                cant_trans = cantidad
                            End If
                        End If
                        mIngreso.insertar_det(vfOpeIngreso, nIngreso, _
                                        IIf(pCatalogoXalmacen = True And cCatalogoOrigen <> cCatalogoDestino, cod_artRel, cod_art), _
                                        IIf(pCatalogoXalmacen = True And cCatalogoOrigen <> cCatalogoDestino, cant_trans, cantidad), _
                                        precio, IIf(esAfecto, pIGV, 0))
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
                    Else
                        MessageBox.Show("Seleccione el Producto a Transferir...", "CEFE", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        cboOrigen.Focus()
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Dim I As Integer
        Dim mTransferencia As New Transferencia
        Dim com As New MySqlCommand
        com.Connection = dbConex
        Dim cad, cSerie, cNumero, cAlma, cArea As String, nOperacion As Integer
        For I = 0 To dataNroTransferencias.RowCount - 1
            cSerie = dataNroTransferencias("ser_doc", I).Value
            cnumero = dataNroTransferencias("nro_doc", I).Value
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
        Dim cod_art = dataArticulos("cod_art", dataArticulos.CurrentRow.Index).Value
        If cCatalogoDestino = "" Then
            MessageBox.Show("Seleccione el Almacén Destino...", "CEFE", _
                                             MessageBoxButtons.OK, MessageBoxIcon.Stop)
            cboDestino.Focus()
            resp = False
        ElseIf Len(lblProducto.Text) > 0 Then
            MessageBox.Show("Ingrese la cantidad a Trasferir...", "CEFE", _
                                             MessageBoxButtons.OK, MessageBoxIcon.Stop)
            resp = False
        ElseIf dataArticulos.RowCount > 0 Then
            If Not mAlmacen.existeArticulo_deAlmaGeneral(cCatalogoDestino, cod_art) And cCatalogoDestino <> "0001" Then
                MessageBox.Show("NO Existe Producto Relacionado para" & Chr(13) _
                                & Microsoft.VisualBasic.UCase(dataArticulos("nom_art", _
                                dataArticulos.CurrentRow.Index).Value) _
                                & " en " & cboDestino.Text, _
                                "CEFE", MessageBoxButtons.OK, MessageBoxIcon.Error)
                resp = False
            End If
        End If
        Return resp
    End Function
    Function validaTransferencia()
        Dim resul As Boolean = False
        If cboOrigen.SelectedIndex >= 0 Then
            If cboDestino.SelectedIndex >= 0 Then
                If cboOrigen.SelectedValue <> cboDestino.SelectedValue Then
                    If dataArticulos("saldo", dataArticulos.CurrentRow.Index).Value > 0 Then
                        If Microsoft.VisualBasic.Len(txtTransferir.Text) > 0 And Val(txtTransferir.Text) > 0 Then
                            If dataArticulos("saldo", dataArticulos.CurrentRow.Index).Value >= Val(txtTransferir.Text) Then
                                resul = True
                            Else
                                MessageBox.Show("La Cantidad a Transferir NO puede ser Mayor que el Saldo Disponible", "CEFE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                txtTransferir.Focus()
                            End If
                        Else
                            MessageBox.Show("Ingrese la Cantidad a Transferir...", "CEFE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            txtTransferir.Focus()
                        End If
                    Else
                        MessageBox.Show("Seleccione el Producto a Transferir...", "CEFE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        dataArticulos.Focus()
                    End If
                Else
                    MessageBox.Show("Los Almacenes de Origen y Destino deben ser Distintos...", "CEFE", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                End If
            Else
                MessageBox.Show("Seleccione el Almacén Destino...", "CEFE", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                cboDestino.Focus()
            End If
        Else
            MessageBox.Show("Seleccione el Almacén Origen...", "CEFE", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            cboOrigen.Focus()
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
    Private Sub chkMostrarTransferencias_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMostrarTransferencias.CheckedChanged
        If _nroTransferencia = 0 Then
            If chkMostrarTransferencias.Checked = True Then
                If Not estaCargando Then
                    Dim mTransferencia As New Transferencia
                    dsNrosTransferencia = mTransferencia.recuperaNrosTransferencia
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
                        .Columns("operacion").Visible = False
                    End With
                End If
            Else
                dsNrosTransferencia.Clear()
            End If
        Else
            chkMostrarTransferencias.Checked = False
        End If
        If chkMostrarTransferencias.Checked = True Then
            txtBuscarTransferencia.ReadOnly = False
            txtBuscarTransferencia.Focus()
        Else
            txtBuscarTransferencia.ReadOnly = True
        End If
    End Sub
    Sub eliminaTransferencia()
        If dataTransferencias.RowCount > 0 Then
            MessageBox.Show("Primero debe Eliminar Los Items de la Transferencia Seleccionada...", "CEFE", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Else
            Dim lser_doc As String = dataNroTransferencias("ser_doc", dataNroTransferencias.CurrentRow.Index).Value
            Dim lnro_doc As String = dataNroTransferencias("nro_doc", dataNroTransferencias.CurrentRow.Index).Value
            Dim mIngreso As New Ingreso, mSalida As New Salida, mTransferencia As New Transferencia
            Dim nroOperacionS As Integer = dataNroTransferencias("operacion", dataNroTransferencias.CurrentRow.Index).Value
            Dim nroOperacionI As Integer = mTransferencia.recuperaOperacionTrans_i(lser_doc, lnro_doc)
            Dim rpta As Integer
            rpta = MessageBox.Show("Esta Seguro de Eliminar el Nro de Transferencia..." _
                    + Chr(13) + "Este Proceso es Irreversible...", "CEFE", _
                    MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2)
            If rpta = 6 Then
                If Not IsDBNull(dataNroTransferencias("operacion", dataNroTransferencias.CurrentRow.Index).Value) Then
                    mIngreso.eliminaCabecera(nroOperacionI)
                    mSalida.eliminaCabecera(nroOperacionS)
                    dataNroTransferencias.Rows.Remove(dataNroTransferencias.CurrentRow)
                    txtBuscarTransferencia.Focus()
                End If
            End If
        End If
    End Sub
    Private Sub dataNroTransferencias_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles dataNroTransferencias.PreviewKeyDown
        If seEliminaTransf() Then
            If e.KeyCode = Keys.Delete Then
                eliminaTransferencia()
            End If
        End If
    End Sub
    Private Sub dataNroTransferencias_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dataNroTransferencias.SelectionChanged
        dsTransferencias.Clear()
        If dataNroTransferencias.RowCount > 0 Then
            muestraTransferencias(dataNroTransferencias("operacion", dataNroTransferencias.CurrentRow.Index).Value)
            Dim mTransferencia As New Transferencia
            Dim cSerie As String = dataNroTransferencias("ser_doc", dataNroTransferencias.CurrentRow.Index).Value
            Dim cNumero As String = dataNroTransferencias("nro_doc", dataNroTransferencias.CurrentRow.Index).Value
            If dataNroTransferencias.RowCount > 0 Then
                _nroTransferencia = cNumero
                lblNroTransferencia.Text = "Nº " & Microsoft.VisualBasic.Right("00000000" + Trim(Str(_nroTransferencia)), 8)
                vfOpeIngreso = mTransferencia.recuperaOperacionTrans_i(cSerie, cNumero)
                vfOpeSalida = mTransferencia.recuperaOperacionTrans_s(cSerie, cNumero)
                cboDestino.SelectedValue = mTransferencia.recuperaAlmacenTrans_dest(False, cSerie, cNumero)
                cboArea.SelectedValue = mTransferencia.recuperaAreaTrans_dest(False, cSerie, cNumero)
                cboOrigen.Enabled = False
                cboDestino.Enabled = False
            Else
                _nroTransferencia = 0
                lblNroTransferencia.Text = "Nº "
                vfOpeSalida = 0
                vfOpeIngreso = 0
                cboDestino.SelectedIndex = -1
                cboOrigen.Enabled = True
                cboDestino.Enabled = True
            End If
        End If
    End Sub
    Private Sub txtBuscarTransferencia_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscarTransferencia.Enter
        If chkMostrarTransferencias.Checked = False Then
            chkMostrarTransferencias.Focus()
        End If
    End Sub

    Private Sub txtBuscarTransferencia_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscarTransferencia.GotFocus
        If chkMostrarTransferencias.Checked = True Then
            Dim valor As String = txtBuscarTransferencia.Text
            dsNrosTransferencia.Tables("nrosTransferencia").DefaultView.RowFilter = "nro_doc LIKE '%" & valor & "%'"
            If dataNroTransferencias.RowCount > 0 Then
                dataNroTransferencias.CurrentCell = dataNroTransferencias("doc", dataNroTransferencias.CurrentRow.Index)
            End If
        End If
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
        dsTransferencias = mTransferencia.recuperaTransferencia(nroOperacion)
        With dataTransferencias
            .DataSource = dsTransferencias.Tables("transferencia")
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("fec_doc").HeaderText = "Fecha"
            .Columns("fec_doc").Width = 70
            .Columns("fec_doc").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("origen").HeaderText = "Almacén Origen"
            .Columns("origen").Width = 120
            .Columns("origen").DefaultCellStyle.BackColor = Color.AliceBlue
            .Columns("doc").HeaderText = "Nro Transferencia"
            .Columns("doc").Width = 90
            .Columns("doc").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_art").HeaderText = "Código"
            .Columns("cod_art").Width = 54
            .Columns("cod_art").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("nom_art").HeaderText = "Descripción"
            .Columns("nom_art").Width = 230
            .Columns("nom_uni").HeaderText = "Unidad"
            .Columns("nom_uni").Width = 75
            .Columns("nom_uni").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cant").HeaderText = "Cantidad"
            .Columns("cant").Width = 60
            .Columns("cant").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cant").DefaultCellStyle.BackColor = Color.AliceBlue
            .Columns("precio").HeaderText = "Precio Costo"
            .Columns("precio").Width = 70
            .Columns("precio").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("destino").HeaderText = "Almacén Destino"
            .Columns("destino").Width = 120
            .Columns("destino").DefaultCellStyle.BackColor = Color.AliceBlue
            .Columns("doc").Visible = False
            .Columns("salida").Visible = False
            .Columns("operacion").Visible = False
            .Columns("ingreso").Visible = False
            .Columns("ser_doc").Visible = False
            .Columns("nro_doc").Visible = False
            .Columns("operacionI").Visible = False
            .Columns("nAux").Visible = False
            .Columns("fecha").Visible = False
            .Columns("cuenta").Visible = False
        End With
        lblRegistros.Text = "Nro de Registros Procesados..." & dataTransferencias.RowCount
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
        Dim mIngreso As New Ingreso, mSalida As New Salida, mTransferencia As New Transferencia
        Dim nroSalida As Integer = dataTransferencias("salida", dataTransferencias.CurrentRow.Index).Value
        Dim nroOperacionS As Integer = dataTransferencias("operacion", dataTransferencias.CurrentRow.Index).Value
        Dim nroOperacionI As Integer = dataTransferencias("operacionI", dataTransferencias.CurrentRow.Index).Value
        Dim nroIngreso As Integer = dataTransferencias("nAux", dataTransferencias.CurrentRow.Index).Value
        Dim yaSalio As Integer = mIngreso.existeSalida(nroIngreso, False)
        If yaSalio Then
            MessageBox.Show("El Registro Tiene Salidas, NO es Posible Eliminarlo...", "CEFE", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            Dim rpta As Integer
            rpta = MessageBox.Show("Esta Seguro de Eliminar el ITEM Seleccionado" + Chr(13) + "Este Proceso es Irreversible...", "CEFE", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2)
            If rpta = 6 Then
                mIngreso.eliminaDetalle(nroIngreso)
                mSalida.eliminaItem(nroSalida)
                dataTransferencias.Rows.Remove(dataTransferencias.CurrentRow)
                If chkMostrarTransferencias.Checked = False Then
                    txtBuscarOrigen.Focus()
                End If
            End If
            End If
            lblRegistros.Text = "Nro de Registros Procesados..." & dataTransferencias.RowCount
            cargaSaldos()
    End Sub
    Function esEditable() As Boolean
        Dim mSalida As New Salida
        Dim lfechaTrans As Date
        lfechaTrans = dataTransferencias("fec_doc", dataTransferencias.CurrentRow.Index).Value
        If lfechaTrans.AddDays(pDiasModificarTrans) <= pFechaSystem Then
            Return False
        Else
            Return True
        End If
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
    Private Sub cmdNuevaT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevaT.Click
        _NroTransferencia = 0
        lblNroTransferencia.Text = "Nº"
        chkMostrarTransferencias.Checked = False
        dsTransferencias.Clear()
        cboOrigen.Enabled = True
        cboDestino.Enabled = True
        If cboArea.SelectedIndex >= 0 Then
            cboArea.Enabled = True
        End If
        cboOrigen.Focus()
        lblRegistros.Text = "Nro de Registros Procesados..." & dataTransferencias.RowCount
    End Sub
    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        If dataTransferencias.RowCount > 0 Then
            Dim chkValorizado As Boolean = ChKRptValorizado.Checked
            Dim fechaProceso As String = general.devuelveFechaImpresionSistema
            Dim periodoReporte As String = "Periodo: " & general.periodo_mesAnnoLetras(periodoActivo())
            Dim cUsuario As String = usuario.recuperaDatosUsuario(dataTransferencias("cuenta", dataTransferencias.CurrentRow.Index).Value)
            Dim frm As New rptForm
            frm.cargarTransferencia(dsTransferencias, fechaProceso, periodoReporte, cUsuario, chkValorizado)
            frm.MdiParent = principal
            frm.Show()
        Else
            MessageBox.Show(general.str_textoNoImpresion, "CEFE", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If
    End Sub

    Private Sub dataArticulos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataArticulos.CellContentClick

    End Sub

    Private Sub dataNroTransferencias_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataNroTransferencias.CellContentClick

    End Sub

    Private Sub ChKRptValorizado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChKRptValorizado.CheckedChanged

    End Sub

    Private Sub txtTransferir_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTransferir.TextChanged

    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub
End Class
