Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Math
Imports libreriaClases
Public Class p_salidas
    Private dsDocumento As New DataSet
    Private dsAlmacen As New DataSet
    Private dsFormaPago As New DataSet
    Private dsProveedor As New DataSet
    Private dsArticulo As New DataSet
    Private dsSalida As New DataSet
    Private dtDetalle As New DataTable("detalle")
    Private dsAlmacen_o As New DataSet
    Private dsAlmacen_d As New DataSet
    Private dsOrigen As New DataSet
    Private dsArea As New DataSet
    Private nroOperacion As Integer = 0
    Private tipoProceso As String = "A"
    'para validar el separador decimal
    Private sepDecimal As Char
    'variable para determinar el periodo del documento recuperado
    Public gPeriodoSalida As String = periodoActivo()
    '
    Private vfCantidad As Decimal = 0
    Private estaCargando As Boolean = True
    Private esCopia As Boolean = False
    Private Sub p_salidas_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        principal.mp_salidas.Enabled = True
    End Sub
    Private Sub p_salidas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'establecemos la fecha de proceso
        estableceFechaProceso()
        establececorrelativo()
        cargaAlmacenes()
        modoHabilitado()
        'verificamos si los precios ya tienen el igv
        If pPreciosIncIGV Then
            chkIGV.CheckState = CheckState.Checked
        Else
            chkIGV.CheckState = CheckState.Unchecked
        End If
        'capturamos el separador decimal
        sepDecimal = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        'dataset documento salida
        Dim daDocumento As New MySqlDataAdapter
        Dim comDoc As New MySqlCommand("select cod_doc,nom_doc from documento_s where activo=1", dbConex)
        daDocumento.SelectCommand = comDoc
        daDocumento.Fill(dsDocumento, "documento")
        With cboDocumento
            .DataSource = dsDocumento.Tables("documento")
            .DisplayMember = dsDocumento.Tables("documento").Columns("nom_doc").ToString
            .ValueMember = dsDocumento.Tables("documento").Columns("cod_doc").ToString
            .SelectedIndex = 3
        End With




        'dataset forma de pago
        Dim daFormaPago As New MySqlDataAdapter
        Dim comFP As New MySqlCommand("select cod_fpago,nom_fpago from forma_pago where activo=1", dbConex)
        daFormaPago.SelectCommand = comFP
        daFormaPago.Fill(dsFormaPago, "formaPago")
        With cboFormaPago
            .DataSource = dsFormaPago.Tables("formaPago")
            .DisplayMember = dsFormaPago.Tables("formapago").Columns("nom_fpago").ToString
            .ValueMember = dsFormaPago.Tables("formapago").Columns("cod_fpago").ToString
            .SelectedIndex = 0
        End With



        Dim daProveedor As New MySqlDataAdapter
        Dim comProveedor As New MySqlCommand("select cod_prov,raz_soc,dir_prov,fono_prov from Proveedor where activo=1 order by raz_soc", dbConex)
        daProveedor.SelectCommand = comProveedor
        daProveedor.Fill(dsProveedor, "Proveedor")
        With cboCliente
            .DataSource = dsProveedor.Tables("Proveedor")
            .DisplayMember = dsProveedor.Tables("Proveedor").Columns("raz_soc").ToString
            .ValueMember = dsProveedor.Tables("Proveedor").Columns("cod_prov").ToString
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.ListItems
            .SelectedIndex = -1
        End With

        crearEstructuraData()

        estaCargando = False
    End Sub
    Sub crearEstructuraData()
        'DataSet(articulos)
        Dim mCatalogo As New Catalogo
        dsArticulo = mCatalogo.recuperaSaldoAlmacen_paraDesp(pDespachoStock0, True, "xy12z", False, "", False, "", True, pIGV, pDecimales)
        With dataArticulo
            .DataSource = dsArticulo.Tables("saldo").DefaultView
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("nom_art").HeaderText = "Descripción"
            .Columns("nom_art").Width = 250
            .Columns("saldo").Visible = False
            .Columns("cod_art").Visible = False
            .Columns("nom_uni").Visible = False
            .Columns("pre_ult").Visible = False
            .Columns("precio").Visible = False
            .Columns("pre_costo").Visible = False
            .Columns("pre_venta").Visible = False
            .Columns("maximo").Visible = False
            .Columns("minimo").Visible = False
            .Columns("afecto_igv").Visible = False
            .Columns("ingreso").Visible = False
            .Columns("cod_sgrupo").Visible = False
            .Columns("nom_sgrupo").Visible = False
            .Columns("monto").Visible = False
            .Columns("tm").Visible = False
            .Columns("tc").Visible = False
            .Columns("cod_alma").Visible = False
            .Columns("nom_alma").Visible = False
        End With
        'dataset detalle

        'dsPedido = pedido.dsPedido
        'dtDetalle = dsPedido.Tables("detalle")
        'With dataDetalle
        '    .DataSource = dsPedido.Tables("detalle")

        dsSalida = Salida.dsSalida
        dtDetalle = dsSalida.Tables("detalle")
        With dataDetalle
            .DataSource = dsSalida.Tables("detalle")
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_art").HeaderText = "Código"
            .Columns("cod_art").Width = 60
            .Columns("cod_art").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_art").ReadOnly = True
            .Columns("nom_art").HeaderText = "Descripción"
            .Columns("nom_art").Width = 300
            .Columns("nom_art").ReadOnly = True
            .Columns("nom_uni").HeaderText = "Unidad"
            .Columns("nom_uni").Width = 80
            .Columns("nom_uni").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("nom_uni").ReadOnly = True
            .Columns("cantidad").HeaderText = "Cant."
            .Columns("cantidad").Width = 50
            .Columns("cantidad").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("precio").HeaderText = "Precio"
            .Columns("precio").Width = 80
            .Columns("precio").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("afecto_igv").HeaderText = "Afec"
            .Columns("afecto_igv").Width = 30
            .Columns("afecto_igv").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("afecto_igv").ReadOnly = True
            .Columns("neto").HeaderText = "Neto"
            .Columns("neto").Width = 70
            .Columns("neto").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("neto").ReadOnly = True
            .Columns("saldo").Visible = False
            .Columns("estado").Visible = False
            .Columns("orden").Visible = False
            .Columns("operacion").Visible = False
            .Columns("ingreso").Visible = False
            .Columns("salida").Visible = False
            .Columns("estado").Visible = False
            .Columns("igv").Visible = False
            .Columns("comi_v").Visible = False
            .Columns("comi_jv").Visible = False
        End With
    End Sub

    Sub establececorrelativo()
        Dim msalida As New Salida
        nroOperacion = msalida.maxOperacion
        'txtSerPedido.Text = periodoActivo()
        txtSerDocumento.Text = "S01"
        txtNroDocumento.Text = nroOperacion
        txtNroDocumento.Text = Microsoft.VisualBasic.Right("00000000" & txtNroDocumento.Text, 8)
        'modoEdicion()
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
            .SelectedIndex = 0
        End With
        'muestraArea(cboDestino.SelectedValue)


    End Sub
    Private Sub txtSerDocumento_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSerDocumento.GotFocus
        ingresaTextoProceso(txtSerDocumento)
    End Sub
    Private Sub txtSerDocumento_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSerDocumento.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not (e.KeyChar = ChrW(Keys.Back)) Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub txtSerDocumento_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSerDocumento.LostFocus
        If Microsoft.VisualBasic.Len(txtSerDocumento.Text) > 0 Then
            txtSerDocumento.Text = Microsoft.VisualBasic.Right("000" & txtSerDocumento.Text, 3)
        End If
        general.saleTextoProceso(txtSerDocumento)
    End Sub
    Private Sub txtSerDocumento_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSerDocumento.Validated
        validaDocumento()
    End Sub
    Private Sub txtNroDocumento_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNroDocumento.GotFocus
        ingresaTextoProceso(txtNroDocumento)
        If cboDocumento.SelectedValue = "03" Then
            If Len(txtNroDocumento.Text) = 0 Then
                Dim mSalida As New Salida
                txtNroDocumento.Text = Microsoft.VisualBasic.Right("00000000" & mSalida.maxNotaSalida(txtSerDocumento.Text), 8)
            End If
        End If
    End Sub
    Private Sub txtNroDocumento_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNroDocumento.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not (e.KeyChar = ChrW(Keys.Back)) Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub txtNroDocumento_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNroDocumento.LostFocus
        If txtNroDocumento.ReadOnly = False Then
            If Microsoft.VisualBasic.Len(txtNroDocumento.Text) > 0 Then
                txtNroDocumento.Text = Microsoft.VisualBasic.Right("00000000" & txtNroDocumento.Text, 8)
            End If
            general.saleTextoProceso(txtNroDocumento)
        End If
    End Sub
    Private Sub txtNroDocumento_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNroDocumento.Validating
        validaDocumento()
    End Sub
    Private Sub txtSerGuia_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSerGuia.GotFocus
        ingresaTextoProceso(txtSerGuia)
    End Sub
    Private Sub txtSerGuia_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSerGuia.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not (e.KeyChar = ChrW(Keys.Back)) Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub txtSerGuia_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSerGuia.LostFocus
        If Microsoft.VisualBasic.Len(txtSerGuia.Text) > 0 Then
            txtSerGuia.Text = Microsoft.VisualBasic.Right("000" & txtSerGuia.Text, 3)
        End If
        saleTextoProceso(txtSerGuia)
    End Sub
    Private Sub txtNroGuia_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNroGuia.GotFocus
        ingresaTextoProceso(txtNroGuia)
    End Sub
    Private Sub txtNroGuia_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNroGuia.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not (e.KeyChar = ChrW(Keys.Back)) Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub txtNroGuia_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNroGuia.LostFocus
        If Microsoft.VisualBasic.Len(txtNroGuia.Text) > 0 Then
            txtNroGuia.Text = Microsoft.VisualBasic.Right("00000000" & txtNroGuia.Text, 8)
        End If
        saleTextoProceso(txtNroGuia)
    End Sub
    Private Sub txtObs_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtObs.GotFocus
        ingresaTextoProceso(txtObs)
    End Sub
    Private Sub txtObs_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtObs.LostFocus
        saleTextoProceso(txtObs)
    End Sub
    Private Sub cboDocumento_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboDocumento.GotFocus
        If cboDocumento.SelectedIndex = -1 Then
            cboDocumento.SelectedIndex = 0
        End If
    End Sub
    Private Sub cboAlmacen_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboAlmacen.GotFocus
        If cboAlmacen.SelectedIndex = -1 Then
            If dsAlmacen_d.Tables("almacen").Rows.Count > 0 Then
                cboAlmacen.SelectedIndex = 0
            End If
        End If
    End Sub
    Private Sub cboAlmacen_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboAlmacen.SelectedIndexChanged
        If Not estaCargando Then
            If cboAlmacen.SelectedIndex >= 0 Then
                dsArticulo.Clear()
                Dim mCatalogo As New Catalogo
                dsArticulo = mCatalogo.recuperaSaldoAlmacen_paraDesp(pDespachoStock0, True, cboAlmacen.SelectedValue, False, "", False, "", True, pIGV, pDecimales)
                dataArticulo.DataSource = dsArticulo.Tables("saldo").DefaultView
            End If
        End If
    End Sub
    Private Sub cboCliente_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCliente.GotFocus
        ingresaComboProceso(cboCliente)
    End Sub
    Private Sub cboCliente_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboCliente.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboFormaPago.Focus()
        End If
    End Sub
    Private Sub cboCliente_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCliente.LostFocus
        saleComboProceso(cboCliente)
    End Sub
    Private Sub cboCliente_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboCliente.Validating
        Try
            If Microsoft.VisualBasic.Len(cboCliente.Text) > 0 Then
                Dim lcod As String = cboCliente.SelectedValue.ToString
                Dim fila() As DataRow
                fila = dsProveedor.Tables("Proveedor").Select("cod_prov ='" & lcod & "'")
                txtRuc.Text = fila(0).Item("cod_prov").ToString
                txtDirEntrega.Text = fila(0).Item("dir_prov").ToString
                txtTelefono.Text = fila(0).Item("fono_prov").ToString
                cboFormaPago.Focus()
            End If
        Catch err As Exception
            MessageBox.Show("Seleccione un Cliente Registrado...", "Cefe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cboCliente.SelectedIndex = -1
            e.Cancel = True
        End Try
    End Sub
    Private Sub cboFormaPago_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboFormaPago.GotFocus
        If cboFormaPago.SelectedIndex = -1 Then
            If dsFormaPago.Tables("formaPago").Rows.Count > 0 Then
                cboFormaPago.SelectedIndex = 0
            End If
        End If
    End Sub
    Private Sub txtBuscar_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscar.GotFocus
        general.ingresaTextoProceso(txtBuscar)
        txtBuscar.SelectAll()
        dsArticulo.Clear()
        Dim mOrigen As New Catalogo
        dsArticulo = mOrigen.recuperaSaldoAlmacen_paraDesp(pDespachoStock0, True, cboAlmacen.SelectedValue, True, txtBuscar.Text, False, "", True, pIGV, pDecimales)
        dataArticulo.DataSource = dsArticulo.Tables("saldo").DefaultView
    End Sub
    Private Sub txtBuscar_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscar.LostFocus
        general.saleTextoProceso(txtBuscar)
    End Sub
    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged
        Dim mCatalogo As New Catalogo
        Dim valor As String = txtBuscar.Text
        dsArticulo = mCatalogo.recuperaSaldoAlmacen_paraDesp(pDespachoStock0, True, cboAlmacen.SelectedValue, True, valor, False, "", True, pIGV, pDecimales)
        dataArticulo.DataSource = dsArticulo.Tables("saldo").DefaultView
        dsArticulo.Tables("saldo").DefaultView.RowFilter = "nom_art LIKE '%" & valor & "%'"
        If dataArticulo.RowCount > 0 Then
            dataArticulo.CurrentCell = dataArticulo("nom_art", dataArticulo.CurrentRow.Index)
        End If
    End Sub
    Function validaSeleccionArticulos() As Boolean
        Dim resul As Boolean = False
        If esEditable() Then
            If cboAlmacen.SelectedIndex = -1 Then
                cboAlmacen.Focus()
            Else
                'If cboCliente.SelectedIndex = -1 Then
                '    cboCliente.Focus()
                'Else
                If cboDocumento.SelectedIndex = -1 Then
                    cboDocumento.Focus()
                Else
                    If Microsoft.VisualBasic.Len(txtSerDocumento.Text) = 0 Then
                        txtSerDocumento.Focus()
                    Else
                        If Microsoft.VisualBasic.Len(txtNroDocumento.Text) = 0 Then
                            txtNroDocumento.Focus()
                        Else
                            resul = True
                        End If
                    End If
                End If
                'End If
            End If
        End If
        Return resul
    End Function

    Private Sub dataArticulo_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataArticulo.CellContentDoubleClick
        If dataArticulo.RowCount > 0 Then
            insertaArticulo()

            'insertadetalle()
        End If
    End Sub
    Private Sub dataArticulo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dataArticulo.KeyDown
        If dataArticulo.RowCount > 0 Then
            If e.KeyCode = Keys.Enter Then
                e.SuppressKeyPress = True
                insertaArticulo()
                'insertadetalle()
            End If
        End If
    End Sub



    'Sub insertaArticulo()
    '    If dataArticulo.RowCount > 0 Then
    '        Dim fila As DataRow = dsSalida.Tables("detalle").NewRow
    '        fila.Item("cod_art") = dataArticulo.Item("cod_art", dataArticulo.CurrentRow.Index).Value
    '        fila.Item("nom_art") = dataArticulo.Item("nom_art", dataArticulo.CurrentRow.Index).Value
    '        fila.Item("nom_uni") = dataArticulo.Item("nom_uni", dataArticulo.CurrentRow.Index).Value
    '        fila.Item("cantidad") = 0
    '        fila.Item("precio") = dataArticulo.Item("precio", dataArticulo.CurrentRow.Index).Value
    '        fila.Item("ingreso") = dataArticulo.Item("ingreso", dataArticulo.CurrentRow.Index).Value
    '        fila.Item("saldo") = dataArticulo.Item("saldo", dataArticulo.CurrentRow.Index).Value
    '        fila.Item("afecto_igv") = dataArticulo.Item("afecto_igv", dataArticulo.CurrentRow.Index).Value
    '        If dataArticulo.Item("afecto_igv", dataArticulo.CurrentRow.Index).Value = True Then
    '            fila.Item("igv") = pIGV
    '        Else
    '            fila.Item("igv") = 0
    '        End If
    '        fila.Item("estado") = "New"
    '        Dim mSalida As New Salida
    '        Dim nroSalida As Integer = mSalida.maxSalida
    '        fila.Item("salida") = nroSalida
    '        dsSalida.Tables("detalle").Rows.Add(fila)
    '    End If
    'End Sub




    Private Sub dataDetalle_CellBeginEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles dataDetalle.CellBeginEdit
        If IsDBNull(dataDetalle("cantidad", dataDetalle.CurrentRow.Index).Value) Then
            vfCantidad = 0
        Else
            vfCantidad = dataDetalle("cantidad", dataDetalle.CurrentRow.Index).Value
        End If
    End Sub
    Private Sub dataDetalle_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dataDetalle.KeyDown
        'si la columna donde pulsamos DEL es distinta de la de IGV
        If e.KeyCode = Keys.Delete Then
            If esEditable() Then
                e.SuppressKeyPress = True
                If dataDetalle.CurrentCell.ColumnIndex <> dataDetalle.Columns("igv").Index Then
                    Dim rpta As Integer
                    rpta = MessageBox.Show("Esta Seguro de Eliminar el ITEM Seleccionado" + Chr(13) + "Este Proceso es Irreversible...", "CEFE", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2)
                    If rpta = 6 Then
                        eliminaItem()
                    End If
                End If
            End If
        Else
            If e.KeyCode = Keys.Enter Then
                e.SuppressKeyPress = True
                txtBuscar.Focus()
            End If
        End If
    End Sub
    Private Sub dataDetalle_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataDetalle.CellEndEdit
        'If dataDetalle.CurrentCell.ColumnIndex = dataDetalle.Columns("cantidad").Index Or dataDetalle.CurrentCell.ColumnIndex = dataDetalle.Columns("precio").Index Then
        '    If esEditable() Then
        '        Dim lcantidad, lprecio, lneto, lsaldo As Decimal, nroSalida, nroIngreso As Integer
        '        nroSalida = dataDetalle("salida", dataDetalle.CurrentRow.Index).Value
        '        If IsDBNull(dataDetalle("cantidad", dataDetalle.CurrentRow.Index).Value) Then
        '            lcantidad = 0
        '            dataDetalle("cantidad", dataDetalle.CurrentRow.Index).Value = 0
        '        Else
        '            lcantidad = dataDetalle("cantidad", dataDetalle.CurrentRow.Index).Value
        '        End If
        '        If dataDetalle("estado", dataDetalle.CurrentRow.Index).Value = "New" Then
        '            lsaldo = dataDetalle("saldo", dataDetalle.CurrentRow.Index).Value
        '        Else
        '            nroIngreso = dataDetalle("ingreso", dataDetalle.CurrentRow.Index).Value
        '            Dim mcatalogo As New Catalogo
        '            lsaldo = mcatalogo.recuperaStockArticulo(False, "", True, False, "", "", nroIngreso) + vfCantidad
        '        End If
        '        If lsaldo < lcantidad Then
        '            dataDetalle("cantidad", dataDetalle.CurrentRow.Index).Value = lsaldo
        '            lcantidad = lsaldo
        '        End If
        '        lprecio = dataDetalle("precio", dataDetalle.CurrentRow.Index).Value
        '        lneto = Round(lcantidad * lprecio, pDecimales)
        '        dataDetalle("neto", dataDetalle.CurrentRow.Index).Value = lneto
        '        calculaTotal()
        '        Dim mSalida As New Salida
        '        mSalida.actualizaDetalle(nroSalida, lcantidad, lprecio, pIGV)
        '        If dataDetalle.CurrentCell.ColumnIndex = dataDetalle.Columns("cantidad").Index Then
        '            dataDetalle.ClearSelection()
        '            txtBuscar.Focus()
        '        End If
        '    End If
        'End If
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
    Private Sub dataDetalle_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataDetalle.CellDoubleClick
        'si la columna donde hacemos doble click es distinta de la de IGV
        If dataDetalle.CurrentCell.ColumnIndex <> dataDetalle.Columns("igv").Index Then
            If esEditable() Then
                Dim rpta As Integer
                rpta = MessageBox.Show("Esta Seguro de Eliminar el ITEM Seleccionado" + Chr(13) + "Este Proceso es Irreversible...", "CEFE", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2)
                If rpta = 6 Then
                    eliminaItem()
                End If
            End If
        End If
    End Sub
    Sub eliminaItem()
        If esEditable() Then
            If (dataDetalle("salida", dataDetalle.CurrentRow.Index).Value) > 0 Then
                Dim nroSalida As Integer = dataDetalle("salida", dataDetalle.CurrentRow.Index).Value
                Dim mSalida As New Salida
                mSalida.actualizaDetalle(nroSalida, 0, 0, 0)
                mSalida.eliminaItem(nroSalida)
            End If
            Dim mfila As DataRow = dsSalida.Tables("detalle").Rows(dataDetalle.CurrentRow.Index)
            dsSalida.Tables("detalle").Rows.Remove(mfila)
            calculaTotal()
            txtBuscar.Focus()
        End If
    End Sub
    Private Sub dataDetalle_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dataDetalle.EditingControlShowing
        'referenciamos la celda
        Dim validar As TextBox = CType(e.Control, TextBox)
        'agregamos el controlador de eventos para el evento KeyPress
        AddHandler validar.KeyPress, AddressOf validar_KeyPress
    End Sub
    Private Sub validar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dataDetalle.KeyPress
        'obtenemos el indice de la columna
        Dim columna As Integer = dataDetalle.CurrentCell.ColumnIndex
        If columna = dataDetalle.Columns("cantidad").Index Then
            If Not Char.IsNumber(e.KeyChar) And Not (e.KeyChar = ChrW(Keys.Back)) And Not (e.KeyChar.Equals(sepDecimal)) Then
                e.KeyChar = ""
            End If
        End If
    End Sub
    Private Sub cmdGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGrabar.Click

        Dim cReg As Integer, continuar As Boolean = True
        continuar = validaGrabacion()

        Try

            If continuar Then
                Dim cod_doc, ser_doc, nro_doc, cod_vend, tm As String,  fec_doc As Date
                Dim cod_clie, cod_fpago, cod_alma, dir_ent, obs As String, nroSalida, inc_igv As Integer

                fec_doc = mcFSalida.SelectedDate
                cod_vend = "00000000"
                'cod_clie = "00000000000"
                'cod_clie = cboCliente.SelectedValue.ToString
                If cboCliente.SelectedValue Is Nothing Then
                    cod_clie = "00000000000"
                Else
                    cod_clie = cboCliente.SelectedValue.ToString
                End If

                cod_fpago = cboFormaPago.SelectedValue.ToString
                cod_alma = cboAlmacen.SelectedValue.ToString
                cod_doc = cboDocumento.SelectedValue.ToString

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
                Dim lcancelado As Integer
                If cboFormaPago.SelectedValue = "01" Then
                    lcancelado = 1
                Else
                    lcancelado = 0
                End If
                cReg = dataDetalle.RowCount

                Dim mSalida As New Salida
                Dim mcatalogo As New Catalogo
                If tipoProceso = "A" Then 'añadir
                    If cReg > 0 Then
                        Try
                            establececorrelativo()
                            ser_doc = txtSerDocumento.Text
                            nro_doc = txtNroDocumento.Text

                            'registramos la cabecera

                            mSalida.insertar_aux(nroOperacion, 0, cod_doc, ser_doc, nro_doc, fec_doc, fec_doc, "00000000", cod_clie, cod_fpago, lcancelado, inc_igv, pDecimales, cod_alma, "0000", obs, "00", pCuentaUser, pCuentaUser, 0, 0, 0)
                            'registramos el detalle
                            Dim cod_art As String, cant, precio, igv As Decimal, I As Integer
                            For I = 0 To cReg - 1
                                cod_art = dataDetalle("cod_art", I).Value
                                cant = dataDetalle("cantidad", I).Value
                                precio = dataDetalle("precio", I).Value
                                If dataDetalle("afecto_igv", I).Value = False Then
                                    igv = 0
                                Else
                                    igv = pIGV
                                End If
                                nroSalida = mSalida.maxSalida()
                                'registramos detalle
                                mSalida.insertar_det(nroOperacion, nroSalida, 0, cod_art, cant, precio, igv, 0, 0)
                                dataDetalle("salida", I).Value = nroSalida
                                dataDetalle("operacion", I).Value = nroOperacion
                            Next
                            'reiniciaControles(True)
                            'reiniciaDatos()
                            'establececorrelativo()
                            'dataDetalle.Clear()
                            'dataDetalle.ClearSelection()
                            'cargaCabecera(nroOperacion)
                            'cargaDetalle(nroOperacion, txtSerDocumento.Text, txtNroDocumento.Text)

                            modoEdicion()


                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                            MessageBox.Show("Revisar Salida: " & vbCrLf & ex.StackTrace)
                        End Try
                    End If
                    tipoProceso = "E"
                    esCopia = False
                Else 'edicion
                    'mPedido.insertar(nroOperacion, serPedido, nroPedido, fec_ped, fec_ent, hor_ent, cod_estado, cod_pedido, cod_vend, cod_clie, cod_fpago, cod_alma, cod_area, dir_ent, obs, inc_igv, tm, pCuentaUser)
                    'mSalida.actualizaCabecera(nroOperacion, fec_ped, fec_ent, hor_ent, cod_pedido, cod_vend, cod_clie, cod_fpago, cod_alma, cod_area, dir_ent, obs, tm, inc_igv)
                    Dim cod_art As String, cant, precio, igv As Decimal, I As Integer
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
                        'comi_v = dataDetalle("comi_v", I).Value
                        'comi_jv = dataDetalle("comi_jv", I).Value
                        'observ = dataDetalle("obs", I).Value
                        If dataDetalle("estado", I).Value = "New" Then
                            nroSalida = mSalida.maxSalida()
                            mSalida.insertar_det(nroOperacion, nroSalida, 0, cod_art, cant, precio, igv, 0, 0)
                        Else
                            nroSalida = dataDetalle("salida", I).Value
                            mSalida.actualizaDetalle(nroSalida, cant, precio, igv)
                        End If
                    Next
                    'cargarpedidos()
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

            MessageBox.Show("Revisar Salida: " & vbCrLf & ex.StackTrace)
        Finally
            ' This line executes whether or not the exception occurs.

        End Try



    End Sub
    Sub insertaArticulo()
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

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        reiniciaControles(True, True, True)
        reiniciaDatos()
        habilitaCabecera()
        estableceFechaProceso()
        establececorrelativo()
        modoHabilitado()
        estableceindexCOmbo()
        cboDocumento.Focus()

    End Sub

    Sub estableceindexCOmbo()
        cboDocumento.SelectedIndex = 3
        cboFormaPago.SelectedIndex = 0
        cboCliente.SelectedIndex = -1
        cboAlmacen.SelectedIndex = 0
    End Sub
    Private Sub cmdAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAnular.Click
        If esEditable() Then
            Dim rpta As Integer
            rpta = MessageBox.Show("¿Esta seguro de Eliminar el Documento...?" + Chr(13) + "Este Proceso es Irreversible", "CEFE", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)
            If rpta = 6 Then
                Dim objTransac As MySqlTransaction
                Dim dbConex As MySqlConnection = Conexion.obtenerConexion
                objTransac = dbConex.BeginTransaction
                Try
                    'actualizamos la salida
                    Dim com As New MySqlCommand("Delete from salida where operacion=" & nroOperacion)
                    com.Connection = dbConex
                    com.Transaction = objTransac
                    com.ExecuteNonQuery()
                    'actualizamos la Guia
                    Dim com3 As New MySqlCommand("Delete from guia_remision where operacion=" & nroOperacion)
                    com3.Connection = dbConex
                    com3.Transaction = objTransac
                    com3.ExecuteNonQuery()
                    objTransac.Commit()
                Catch ex As Exception
                    If Not objTransac Is Nothing Then
                        objTransac.Rollback()
                    End If
                    MessageBox.Show(ex.Message.ToString)
                Finally
                    reiniciaControles(True, True, True)
                    reiniciaDatos()
                    habilitaCabecera()
                    modoDeshabilitado()
                    cboDocumento.Focus()
                End Try
            End If
        End If
    End Sub
    Sub reiniciaControles(ByVal incluirNroSalida As Boolean, ByVal incluirCabecera As Boolean, ByVal incluirFechaProceso As Boolean)
        If incluirNroSalida Then
            cboDocumento.SelectedIndex = -1
            txtSerDocumento.Text = ""
            txtNroDocumento.Text = ""
            txtSerGuia.Text = ""
            txtNroGuia.Text = ""
        End If
        If incluirCabecera Then
            cboCliente.SelectedIndex = -1
            txtRuc.Text = ""
            txtDirEntrega.Text = ""
            txtTelefono.Text = ""
            cboFormaPago.SelectedIndex = -1
            cboAlmacen.Enabled = True
            cboAlmacen.SelectedIndex = -1
        End If
        If incluirFechaProceso Then
            estableceFechaProceso()
        End If
        If pPreciosIncIGV Then
            chkIGV.CheckState = CheckState.Checked
        Else
            chkIGV.CheckState = CheckState.Unchecked
        End If
        dataDetalle.Columns("cantidad").ReadOnly = False
        txtObs.Text = ""
        txtBuscar.Text = ""
        lblItems.Text = "Nro de Items. 0"
        txtTotal.Text = "0.00"
        txtSubTotal.Text = "0.00"
        txtIGV.Text = "0.00"
    End Sub
    Sub reiniciaDatos()
        'nroOperacion = 0
        tipoProceso = "A"
        gPeriodoSalida = periodoActivo()
        dsSalida.Clear()
        dsArticulo.Clear()
    End Sub
    Sub estableceFechaProceso()
        mcFSalida.MaxDate = pFechaActivaMax
        mcFSalida.MinDate = pFechaActivaMin
        If Month(pFechaActivaMax) = Month(pFechaSystem) Then
            mcFSalida.DisplayMonth = pFechaSystem
            mcFSalida.SelectedDate = pFechaSystem
        Else
            mcFSalida.DisplayMonth = pFechaActivaMax
            mcFSalida.SelectedDate = pFechaActivaMax
        End If
    End Sub
    Function esEditable() As Boolean
        Dim mSalida As New Salida
        Dim existe As Boolean, lTipodoc, lSerie, lNumero As String, lfechaSal As Date
        lSerie = Microsoft.VisualBasic.Right("000" & txtSerDocumento.Text, 3)
        lNumero = Microsoft.VisualBasic.Right("00000000" & txtNroDocumento.Text, 8)
        lTipodoc = cboDocumento.SelectedValue
        If gPeriodoSalida = periodoActivo() Then
            existe = mSalida.existe(lTipodoc, lSerie, lNumero)
        Else
            existe = mSalida.existe_historial(gPeriodoSalida, lTipodoc, lSerie, lNumero)
        End If
        If existe Then
            lfechaSal = mSalida.devuelveFechaSalida(lTipodoc, lSerie, lNumero)
            If lfechaSal.AddDays(pDiasModificarSalida) > pFechaSystem Then
                Return True
            Else
                Return False
            End If
        Else
            Return True
        End If
    End Function
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
        If I = 0 Then
            cboAlmacen.Enabled = True
        Else
            cboAlmacen.Enabled = False
        End If
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
    Sub validaDocumento()
        If tipoProceso <> "E" Then
            If cboDocumento.SelectedIndex = -1 Then
                txtSerDocumento.Text = ""
                txtNroDocumento.Text = ""
                cboDocumento.Focus()
            Else
                Dim lserie, lnumero, ldoc As String, rpta As Integer
                lserie = Microsoft.VisualBasic.Right("000" & txtSerDocumento.Text, 3)
                lnumero = Microsoft.VisualBasic.Right("00000000" & txtNroDocumento.Text, 8)
                If cboDocumento.SelectedIndex >= 0 Then
                    ldoc = cboDocumento.SelectedValue
                    Dim mSalida As New Salida
                    If gPeriodoSalida = periodoActivo() Then
                        If cboDocumento.SelectedValue = "03" Then 'nota de salida
                            nroOperacion = mSalida.existeNotaSalida(lserie, lnumero)
                        Else
                            nroOperacion = mSalida.existe(ldoc, lserie, lnumero)
                        End If
                    Else
                        'cuando recuperamos desde el historial
                        If cboDocumento.SelectedValue = "03" Then 'nota de salida
                            nroOperacion = mSalida.existeNotaSalida_historial(gPeriodoSalida, lserie, lnumero)
                        Else
                            nroOperacion = mSalida.existe_historial(gPeriodoSalida, ldoc, lserie, lnumero)
                        End If
                    End If
                    If nroOperacion > 0 Then 'si la factura ya esta registrada
                        'si la factura esta anulada
                        'If mSalida.estaAnulada(nroOperacion) Then
                        '    MessageBox.Show("La " + cboDocumento.Text + " " + lserie + "-" + lnumero + " esta Anulada" + Chr(13) + "Ingrese otro Número de documento...", "CEFE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        '    reiniciaControles(False, False, False)
                        '    'reiniciaDatos()
                        '    cboDocumento.Focus()
                        'Else
                        rpta = MessageBox.Show(cboDocumento.Text & ": " & lserie & "-" & lnumero &
                        " Ya Existe," & Chr(13) & "¿DESEA MOSTRARLO?", "cefe", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)
                        If rpta = 6 Then
                            modoHabilitado()
                            'limpiamos el dataset salida
                            dsSalida.Clear()
                            'verificamos si cuenta con permiso para anular la factura
                            If esEditable() Then
                                modoEdicion()
                                dataDetalle.Columns("cantidad").ReadOnly = False
                            Else
                                modoDeshabilitado()
                                dataDetalle.Columns("cantidad").ReadOnly = True
                                cmdCancelar.Enabled = True
                            End If
                            'cargamos los datos de la factura
                            cargaCabecera(nroOperacion, False)
                            cargaDetalle(nroOperacion)
                            deshabilitaCabecera()
                            'indicamos el tipo de proceso
                            tipoProceso = "E"
                            txtBuscar.Focus()
                        Else
                            reiniciaControles(True, True, True)
                            reiniciaDatos()
                            modoDeshabilitado()
                            cboDocumento.Focus()
                        End If
                        'End If
                    Else 'como la factura NO esta registrada
                        reiniciaControles(False, False, False)
                        reiniciaDatos()
                        modoAñadir()
                    End If
                Else
                    'falta seleccionar el tipo de documento
                    MessageBox.Show("Seleccione el Tipo de Documento...", "CEFE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    cboDocumento.Focus()
                End If
            End If
        End If
    End Sub
    Function validaGrabacion() As Boolean
        Dim valorRetorno As Boolean = False
        If mcFSalida.SelectedDate.Year >= 2010 Then
            If cboDocumento.SelectedIndex >= 0 Then
                If Microsoft.VisualBasic.Len(txtSerDocumento.Text) > 0 Then
                    If Microsoft.VisualBasic.Len(txtNroDocumento.Text) > 0 Then
                        If cboFormaPago.SelectedIndex >= 0 Then
                            If cboAlmacen.SelectedIndex >= 0 Then
                                valorRetorno = True
                            Else
                                cboAlmacen.Focus()
                            End If
                        Else
                            cboFormaPago.Focus()
                        End If
                    Else
                        txtNroDocumento.Focus()
                    End If
                Else
                    txtSerDocumento.Focus()
                End If
            Else
                cboDocumento.Focus()
            End If
        Else
            MessageBox.Show("Seleccione la Fecha de Salida...", "CEFE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            mcFSalida.Focus()
        End If
        Return valorRetorno
    End Function
    Function validaGuia() As Boolean
        Dim valorRetorno As Boolean = False
        If Microsoft.VisualBasic.Len(txtSerGuia.Text) > 0 Then
            If Microsoft.VisualBasic.Len(txtNroGuia.Text) > 0 Then
                valorRetorno = True
            Else
                txtNroGuia.Focus()
            End If
        Else
            txtSerGuia.Focus()
        End If
        Return True
    End Function
    Sub cargaCabecera(ByVal nro_ope As Integer, ByVal esPedido As Boolean)
        Dim msalida As New Salida
        Dim dt As New DataTable
        If gPeriodoSalida = periodoActivo() Then
            dt = msalida.recuperaCabecera(nro_ope, esPedido, False)
        Else
            dt = msalida.recuperaCabecera_historial(gPeriodoSalida, nro_ope, esPedido)
        End If
        mcFSalida.SelectedDate = (dt.Rows(0).Item("fec_doc"))
        txtSerDocumento.Text = dt.Rows(0).Item("ser_doc").ToString
        txtNroDocumento.Text = dt.Rows(0).Item("nro_doc").ToString
        cboCliente.SelectedValue = dt.Rows(0).Item("cod_clie").ToString
        txtRuc.Text = dt.Rows(0).Item("cod_clie").ToString
        txtTelefono.Text = dt.Rows(0).Item("fono_clie").ToString
        txtDirEntrega.Text = dt.Rows(0).Item("dir_clie").ToString
        cboFormaPago.SelectedValue = dt.Rows(0).Item("cod_fpago").ToString
        cboDocumento.SelectedValue = dt.Rows(0).Item("cod_doc").ToString
        cboAlmacen.SelectedValue = dt.Rows(0).Item("cod_alma").ToString
        txtObs.Text = dt.Rows(0).Item("obs").ToString
        If dt.Rows(0).Item("pre_inc_igv") = True Then
            chkIGV.CheckState = CheckState.Checked
        Else
            chkIGV.CheckState = CheckState.Unchecked
        End If
    End Sub
    Sub cargaDetalle(ByVal nro_ope As Integer)
        Dim mSalida As New Salida, I As Integer
        Dim dt As New DataTable

        If gPeriodoSalida = periodoActivo() Then
            dt = mSalida.recuperaDetalle(nro_ope, pDecimales, False)
        Else
            dt = mSalida.recuperaDetalle_historial(gPeriodoSalida, nro_ope, pDecimales)
        End If
        For I = 0 To dt.Rows.Count - 1
            dsSalida.Tables("detalle").ImportRow(dt.Rows(I))

        Next
        dataDetalle.DataSource = dsSalida.Tables("detalle")
        calculaTotal()
        dataDetalle.Refresh()
    End Sub
    Private Sub chkIGV_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkIGV.CheckedChanged
        calculaTotal()
    End Sub
    Sub modoEdicion()
        cmdGrabar.Enabled = True
        cmdCancelar.Enabled = True
        cmdAnular.Enabled = True
        cmdImprimir.Enabled = True
    End Sub
    Sub modoAñadir()
        cmdGrabar.Enabled = True
        cmdCancelar.Enabled = True
        cmdAnular.Enabled = False
        cmdImprimir.Enabled = False
    End Sub
    Sub modoDeshabilitado()
        cmdGrabar.Enabled = False
        cmdCancelar.Enabled = False
        cmdAnular.Enabled = False
        cmdImprimir.Enabled = False
    End Sub
    Sub modoHabilitado()
        cmdGrabar.Enabled = True
        cmdCancelar.Enabled = True
        cmdAnular.Enabled = True
        cmdImprimir.Enabled = True
    End Sub
    Sub deshabilitaCabecera()
        txtSerDocumento.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        txtSerDocumento.ReadOnly = True
        txtNroDocumento.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        txtNroDocumento.ReadOnly = True
        cboDocumento.Enabled = False
        cboAlmacen.Enabled = False
        'guia
        txtSerGuia.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        txtSerGuia.ReadOnly = True
        txtNroGuia.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        txtNroGuia.ReadOnly = True
    End Sub
    Sub habilitaCabecera()
        txtSerDocumento.BackColor = Color.White
        txtSerDocumento.ReadOnly = False
        txtNroDocumento.BackColor = Color.White
        txtNroDocumento.ReadOnly = False
        cboDocumento.Enabled = True
        cboFormaPago.Enabled = True
        cboAlmacen.Enabled = True
        'guia
        txtSerGuia.BackColor = Color.White
        txtSerGuia.ReadOnly = False
        txtNroGuia.BackColor = Color.White
        txtNroGuia.ReadOnly = False
    End Sub


    Private Sub dataArticulo_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataArticulo.CellContentClick

    End Sub

    Private Sub cmdImprimir_Click(sender As System.Object, e As System.EventArgs) Handles cmdImprimir.Click
        Dim msalida As New Salida
        Dim ds As DataSet
        If dataDetalle.RowCount > 0 Then
            Dim fechaProceso As String = general.devuelveFechaImpresionSistema
            Dim periodoReporte As String = "Periodo: " & general.periodo_mesAnnoLetras(periodoActivo())
            Dim cUsuario As String = pCuentaUser
            Dim frm As New rptForm
            Dim operacion As Integer = dataDetalle("operacion", 0).Value
            ds = msalida.recuperaDocSalida(operacion)
            frm.cargarDocSalida(ds, fechaProceso, periodoReporte, cUsuario)
            frm.MdiParent = principal
            frm.Show()
        Else
            MessageBox.Show(general.str_textoNoImpresion, "SGA", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If
    End Sub

    Private Sub dataDetalle_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataDetalle.CellContentClick

    End Sub

    Private Sub cboDocumento_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboDocumento.SelectedIndexChanged

    End Sub

    Private Sub txtNroDocumento_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtNroDocumento.TextChanged

    End Sub
End Class
