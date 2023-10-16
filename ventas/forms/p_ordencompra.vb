Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Math
Imports libreriaClases
Imports System.ComponentModel

Public Class p_ordencompra
    Private dsDocumento As New DataSet
    Private dsFPago As New DataSet
    Private dsAlmacen As New DataSet
    Private dsAlmacenT As New DataSet
    Private dsProveedor As New DataSet
    Private dsArticulo As New DataSet
    Private dsIngreso As New DataSet
    Private dsEstados As New DataSet
    Private dsArea As New DataSet
    Private dsUnidad As New DataSet
    Private dtDetalle As New DataTable("detalle")
    Private prTC As Decimal = pTC
    'variable que almacena la operacion en proceso
    Private nroOperacion As Integer = 0
    Private periodoIngreso As String = periodoActivo()
    'Variable donde indicamos el tipo de proceso - A=Añadir - E=Edicion
    Private tipoProceso As Char = "A"
    'para validar el separador decimal
    Private sepDecimal As Char
    Private estaCargando As Boolean = True
    '//VARIABLES PARA CUANDO SE RECUPERA DESDE OTRO LADO UN DOCUMENTO
    Private cProveedor As String = "", cDocumento As String = "", cSerDocumento As String = "", cNroDocumento As String = ""
    Private nroOperacionPedido As Integer = 0
    Public _miobs As String
    Private LDecimales = 4
    Private esCopia As Boolean = False
    Private Sub p_ordencompra_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        'mostramos el tipo de cambio actual
        muestraTCActual()
    End Sub
    Private Sub p_ordencompra_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        principal.mp_ocompra.Enabled = True
    End Sub
    Private Sub p_ordencompra_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        dataArticulo.Visible = False
    End Sub
    Private Sub p_ordencompra_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'establecemos la fecha de proceso
        estableceFechaProceso()
        establececorrelativo()
        'verificamos si los precios ya tienen el igv
        If pPreciosIncIGV Then
            chkIGV.CheckState = CheckState.Checked
        Else
            chkIGV.CheckState = CheckState.Unchecked
        End If
        'dataset ESTADOS
        Dim daEstados As New MySqlDataAdapter
        Dim comEst As New MySqlCommand("SELECT cod_recurso,dsc_recurso FROM tipo_recurso where cod_tabla='tip_pedido'and activo=1", dbConex)
        daEstados.SelectCommand = comEst
        daEstados.Fill(dsEstados, "Estados")
        With CboEstado
            .DataSource = dsEstados.Tables("Estados")
            .DisplayMember = dsEstados.Tables("Estados").Columns("dsc_recurso").ToString
            .ValueMember = dsEstados.Tables("Estados").Columns("cod_recurso").ToString
            .SelectedIndex = 0
        End With
        'System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-ES")
        'capturamos el separador decimal
        sepDecimal = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator

        Dim daFormaPago As New MySqlDataAdapter
        Dim comFP As New MySqlCommand("select cod_fpago,nom_fpago from forma_pago where activo=1", dbConex)
        daFormaPago.SelectCommand = comFP
        daFormaPago.Fill(dsFPago, "forma_pago")
        With cboFPago
            .DataSource = dsFPago.Tables("forma_pago")
            .DisplayMember = dsFPago.Tables("forma_pago").Columns("nom_fpago").ToString
            .ValueMember = dsFPago.Tables("forma_pago").Columns("cod_fpago").ToString
            .SelectedIndex = -1
        End With
        'dataset almacen
        Dim daAlmacen As New MySqlDataAdapter
        Dim comAlmacen As New MySqlCommand("select cod_alma,nom_alma from almacen where activo=1 and (esCompras) order by nom_alma", dbConex)
        daAlmacen.SelectCommand = comAlmacen
        daAlmacen.Fill(dsAlmacen, "almacen")
        With cboAlmacen
            .DataSource = dsAlmacen.Tables("almacen")
            .DisplayMember = dsAlmacen.Tables("almacen").Columns("nom_alma").ToString
            .ValueMember = dsAlmacen.Tables("almacen").Columns("cod_alma").ToString
            .SelectedIndex = -1
        End With

        'dataset proveedor
        cargarproveedor("%")

        'dataset unidades
        Dim daUnidad As New MySqlDataAdapter
        Dim comUnd As New MySqlCommand("Select cod_uni,nom_uni from unidad where activo and esCompra", dbConex)
        daUnidad.SelectCommand = comUnd
        daUnidad.Fill(dsUnidad, "unidad")


        dsIngreso = Ingreso.dsIngreso
        dtDetalle = dsIngreso.Tables("detalle")
        With dataDetalle
            .DataSource = dsIngreso.Tables("detalle")
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_art").HeaderText = "Código"
            .Columns("cod_art").Width = 55
            .Columns("cod_art").ReadOnly = True
            .Columns("cod_art").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("nom_art").HeaderText = "Descripción"
            .Columns("nom_art").Width = 270
            .Columns("nom_art").ReadOnly = True
            .Columns("nom_uni").HeaderText = "Unidad"
            .Columns("nom_uni").Width = 85
            .Columns("nom_uni").ReadOnly = True
            .Columns("nom_uni").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            .Columns("cantidad").HeaderText = "Cant."
            .Columns("cantidad").Width = 60
            .Columns("cantidad").ReadOnly = False
            .Columns("cantidad").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("precio").HeaderText = "Precio"
            .Columns("precio").Width = 75
            .Columns("precio").ReadOnly = False
            .Columns("precio").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("precio").DefaultCellStyle.Format = "N" & LDecimales
            .Columns("pre_ult").HeaderText = "Ult.Precio"
            .Columns("pre_ult").Width = 75
            .Columns("pre_ult").ReadOnly = True
            .Columns("pre_ult").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("pre_ult").DefaultCellStyle.Format = "N" & LDecimales
            .Columns("igv").HeaderText = "IMP"
            .Columns("igv").Width = 45
            .Columns("igv").ReadOnly = True
            .Columns("igv").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("igv").DefaultCellStyle.BackColor = Color.AliceBlue
            .Columns("afecto_igv").HeaderText = "Afe"
            .Columns("afecto_igv").Width = 35
            .Columns("afecto_igv").ReadOnly = True
            .Columns("afecto_igv").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("neto").HeaderText = "Neto"
            .Columns("neto").Width = 85
            .Columns("neto").ReadOnly = False
            .Columns("neto").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("neto").DefaultCellStyle.Format = "N" & LDecimales

            .Columns("obs").HeaderText = "Obs"
            .Columns("obs").Width = 35
            .Columns("obs").ReadOnly = False
            .Columns("obs").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            '.Columns("neto").DefaultCellStyle.Format = "c"
            .Columns("operacion").Visible = False
            .Columns("ingreso").Visible = False
            .Columns("estado").Visible = False
            .Columns("porcentaje").Visible = False
            .Columns("cod_uni").Visible = False
        End With
        'establecemos la moneda nacional
        optMoneda.Text = pMoneda
        'dataset detalle
        'crear_campocombo()

        estaCargando = False
    End Sub
    Sub cargarproveedor(ByVal texto As String)
        'dataset proveedor
        'dataset contacto
        'Dim dsProveedor As New DataSet
        'dim dtproveedor As New DataTable("proveedor")
        dsProveedor = Proveedor.dsProveedor
        'dsProveedor.Tables.Add(dtproveedor)
        Dim daProvedor As New MySqlDataAdapter, c0, c1, c2 As String
        c1 = "Select cod_prov,nom_prov,raz_soc,dir_prov,fono_prov,nom_cont "
        c2 = "from proveedor where activo=1 and raz_soc like '" & texto & "'  order by raz_soc"
        c0 = c1 + c2
        Dim comProve As New MySqlCommand(c0, dbConex)
        daProvedor.SelectCommand = comProve
        daProvedor.Fill(dsProveedor, "proveedor")
        With cboProveedor
            .DataSource = dsProveedor.Tables("proveedor")
            .DisplayMember = dsProveedor.Tables("proveedor").Columns("raz_soc").ToString
            .ValueMember = dsProveedor.Tables("proveedor").Columns("cod_prov").ToString
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.ListItems
            .SelectedIndex = -1
        End With
    End Sub
    Sub crear_campocombo()
        If dataDetalle.Columns("unidad") Is Nothing Then ' si no existe
            Dim unidades() As String = {" Reproduccion ", " Produccion "}

            Dim dgvColumnCombo = New DataGridViewComboBoxColumn()
            With dgvColumnCombo

                .DataSource = dsUnidad.Tables(0).DefaultView
                .DisplayMember = dsUnidad.Tables(0).Columns("nom_uni").ToString
                .ValueMember = dsUnidad.Tables(0).Columns("cod_uni").ToString
                .Name = "nom_uni"
                .HeaderText = "UNIDAD"
                .Width = 80
                .ReadOnly = False
                .DisplayIndex = 3

            End With


            dataDetalle.Columns.Add(dgvColumnCombo) 'Agregamos




        End If
    End Sub

    Private Sub cboProveedor_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboProveedor.GotFocus
        dataArticulo.Visible = False
    End Sub

    Private Sub cboProveedor_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboProveedor.Validating
        Try
            If Microsoft.VisualBasic.Len(cboProveedor.Text) > 0 Then
                Dim lproveedor As String = cboProveedor.SelectedValue.ToString
                Dim fila() As DataRow
                fila = dsProveedor.Tables("proveedor").Select("cod_prov ='" & lproveedor & "'")
                txtRUC.Text = fila(0).Item("cod_prov").ToString
                txtDireccion.Text = fila(0).Item("dir_prov").ToString
                'If Not validaIngreso() Then
                '    e.Cancel = True
                'End If
            End If
        Catch err As Exception
            MessageBox.Show("Seleccione un Proveedor Registrado...", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cboProveedor.SelectedIndex = -1
            e.Cancel = True
        End Try
    End Sub



    Private Sub txtSerDocumento_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        dataArticulo.Visible = False
    End Sub


    Private Sub txtNroDocumento_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Not Char.IsNumber(e.KeyChar) And Not (e.KeyChar = ChrW(Keys.Back)) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtSerGuia_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        dataArticulo.Visible = False
    End Sub

    Private Sub txtSerGuia_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Not Char.IsNumber(e.KeyChar) And Not (e.KeyChar = ChrW(Keys.Back)) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtNroGuia_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        dataArticulo.Visible = False
    End Sub
    Private Sub txtNroGuia_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            cboAlmacen.Focus()
        End If
    End Sub
    Private Sub txtNroGuia_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Not Char.IsNumber(e.KeyChar) And Not (e.KeyChar = ChrW(Keys.Back)) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub cboAlmacen_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboAlmacen.GotFocus
        dataArticulo.Visible = False
        If dsAlmacen.Tables("almacen").Rows.Count > 0 Then
            If cboAlmacen.SelectedIndex = -1 Then
                cboAlmacen.SelectedIndex = 0
            End If
        End If
    End Sub
    Private Sub cboAlmacen_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboAlmacen.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboFPago.Focus()
        End If
    End Sub
    Private Sub cboFPago_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboFPago.GotFocus
        dataArticulo.Visible = False
        If dsFPago.Tables("forma_pago").Rows.Count > 0 Then
            If cboFPago.SelectedIndex = -1 Then
                cboFPago.SelectedIndex = 0
            End If
        End If
    End Sub
    Private Sub cboFPago_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboFPago.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtBuscar.Focus()

        End If
    End Sub
    Private Sub txtObs_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        dataArticulo.Visible = False
    End Sub
    Private Sub txtObs_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            txtBuscar.Focus()
        End If
    End Sub
    Private Sub optDolares_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optDolares.CheckedChanged
        If prTC > 0 Then
        Else
            optMoneda.Checked = True
            MessageBox.Show("Falta establecer el Tipo de Cambio", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub chkIGV_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkIGV.CheckedChanged
        If Not estaCargando Then

            calculaTotal()
        End If
    End Sub


    Function cargamosElIngreso() As Boolean
        Dim lrpta As Integer
        lrpta = MessageBox.Show("El Documento ya Existe?" & Chr(13) & "Desea Recuperarlo...", "SGA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        If lrpta = 6 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub cargaIngreso(ByVal operacion As Integer, ByVal periodo As String)
        dsIngreso.Clear()
        dsArticulo.Clear()
        reiniciaDatos()
        reiniciaControles(False, False)
        'establecemos el valor de las variables de formulario
        Dim esHistorial As Boolean = IIf(periodo = periodoActivo(), False, True)
        periodoIngreso = periodo
        nroOperacion = operacion
        tipoProceso = "E"
        cargaCabecera()
        cargaDetalle()
        If esEditable() Then
            habilitaCabecera()
            modoEdicion()
            dataDetalle.Columns("cantidad").ReadOnly = False
            dataDetalle.Columns("precio").ReadOnly = False
        Else
            deshabilitaCabecera()
            modoDeshabilitado()
            cmdCancelar.Enabled = True
            cmdImprimir.Enabled = True
            dataDetalle.Columns("cantidad").ReadOnly = True
            dataDetalle.Columns("precio").ReadOnly = True
        End If

        Dim mIngreso As New Ingreso
        Dim mTransferencia As New Transferencia



        txtBuscar.Focus()
    End Sub
    Sub cargaCabecera()
        Dim mIngreso As New Ingreso
        Dim dt As New DataTable
        Dim esHistorial As Boolean = False
        dt = mIngreso.recuperaCabecera_oc(esHistorial, periodoIngreso, nroOperacion)
        'mostramos los valores recuperados
        'lblIndice.Text = nroOperacion
        txtNroPedido.Text = dt.Rows(0).Item("nro_doc")
        mcFIngreso.Value = dt.Rows(0).Item("fec_doc")
        cboProveedor.SelectedValue = dt.Rows(0).Item("cod_prov").ToString
        CboEstado.SelectedValue = dt.Rows(0).Item("cod_estado").ToString

        txtRUC.Text = dt.Rows(0).Item("cod_prov").ToString
        txtDireccion.Text = dt.Rows(0).Item("dir_prov").ToString

        cboAlmacen.SelectedValue = dt.Rows(0).Item("cod_alma").ToString
        cboFPago.SelectedValue = dt.Rows(0).Item("cod_fpago").ToString
        txtObs.Text = dt.Rows(0).Item("obs").ToString
        If dt.Rows(0).Item("pre_inc_igv") Then
            chkIGV.CheckState = CheckState.Checked
        Else
            chkIGV.CheckState = CheckState.Unchecked
        End If
        If dt.Rows(0).Item("tm") = "D" Then
            optDolares.Checked = True
        Else
            optMoneda.Checked = True
        End If
        lblTC.Text = "Tipo Cambio: " & dt.Rows(0).Item("tc").ToString
    End Sub
    Sub cargaDetalle()
        Dim mIngreso As New Ingreso, I As Integer
        Dim esHistorial As Boolean = False
        Dim dt As New DataTable
        dt = mIngreso.recuperaDetalle_oc(esHistorial, periodoIngreso, nroOperacion, LDecimales)
        For I = 0 To dt.Rows.Count - 1
            dsIngreso.Tables("detalle").ImportRow(dt.Rows(I))
        Next
        dataDetalle.DataSource = dsIngreso.Tables("detalle")
        calculaTotal()
        dataDetalle.Refresh()
    End Sub
    Function esEditable() As Boolean
        Dim mIngreso As New Ingreso
        Dim existe As Boolean, lfechaIng As Date


        If existe Then
            'Dim lTipodoc, lSerie, lNumero As String
            lfechaIng = mIngreso.devuelveFechaIngreso(False, "", "", "", "")
            If lfechaIng.AddDays(pDiasModificarIngreso) > pFechaSystem Then
                Return True
            Else
                Return False
            End If
        Else
            Return True
        End If
    End Function
    Private Sub txtBuscar_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscar.GotFocus
        If Not estaCargando Then
            txtBuscar.SelectAll()
            dataArticulo.Visible = False
            dsArticulo.Clear()
            dataArticulo.DataSource = ""
            Dim mCatalogo As New Catalogo
            Dim mAlmacen As New Almacen
            Dim lAlmacen As String = mAlmacen.devuelveAlmacenCatalogo(cboAlmacen.SelectedValue)
            'dsArticulo = mCatalogo.recuperaCatalogoMaestro(lAlmacen, True, False, False, "", False, False, False)
            dsArticulo = mCatalogo.recuperaCatalogo_COMPRAS(True, lAlmacen, True, False, False, "", False, True, False)
            dataArticulo.DataSource = dsArticulo.Tables("articulo").DefaultView
            cargaEstructuraArticulos()
            filtraArticulos()
        End If
    End Sub
    Private Sub txtBuscar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBuscar.KeyDown
        If e.KeyCode = Keys.Enter Then
            dataArticulo.Focus()
        Else
            If e.KeyCode = Keys.Escape Then
                dataArticulo.Visible = False
                dataDetalle.Focus()
            End If
        End If
    End Sub
    Private Sub txtBuscar_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged
        If Not estaCargando Then
            filtraArticulos()
        End If
    End Sub
    Sub filtraArticulos()
        If Len(txtBuscar.Text) > 0 Then
            Dim valor As String = txtBuscar.Text
            dsArticulo.Tables("articulo").DefaultView.RowFilter = "nom_art LIKE '%" & valor & "%'"
            If dataArticulo.RowCount > 0 Then
                dataArticulo.Visible = True
                dataArticulo.CurrentCell = dataArticulo("nom_art", dataArticulo.CurrentRow.Index)
            Else
                dataArticulo.Visible = False
            End If
        Else
            dataArticulo.Visible = False
        End If
    End Sub
    Sub cargaEstructuraArticulos()
        With dataArticulo
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("nom_art").HeaderText = "Descripcion"
            .Columns("nom_art").DisplayIndex = 0
            .Columns("nom_art").Width = 280
            .Columns("uni_compra").HeaderText = "Unidad"
            .Columns("uni_compra").DisplayIndex = 1
            .Columns("uni_compra").Width = 80
            .Columns("pre_compra").Visible = False
            .Columns("nom_uni").Visible = False
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
        End With
    End Sub
    Private Sub dataArticulo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dataArticulo.KeyDown
        If e.KeyCode = Keys.Enter Then
            If dataArticulo.RowCount > 0 Then
                e.SuppressKeyPress = True
                insertaArticulo()
                dataArticulo.Visible = False
            Else
                MessageBox.Show("Seleccione el Producto a Registrar...", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                txtBuscar.Focus()
            End If
        Else
            If e.KeyCode = Keys.Escape Then
                dataArticulo.Visible = False
                dataDetalle.Focus()
            End If
        End If
    End Sub
    Private Sub dataArticulo_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dataArticulo.DoubleClick
        insertaArticulo()
    End Sub
    Private Sub dataArticulo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dataArticulo.LostFocus
        dataArticulo.Visible = False
    End Sub
    Sub insertaArticulo()
        If validaSeleccionArticulos() Then
            If esEditable() Then
                Dim fila As DataRow = dsIngreso.Tables("detalle").NewRow
                fila.Item("cod_art") = dataArticulo.Item("cod_art", dataArticulo.CurrentRow.Index).Value
                fila.Item("nom_art") = dataArticulo.Item("nom_art", dataArticulo.CurrentRow.Index).Value
                fila.Item("nom_uni") = dataArticulo.Item("uni_compra", dataArticulo.CurrentRow.Index).Value
                fila.Item("cod_uni") = dataArticulo.Item("cod_uni", dataArticulo.CurrentRow.Index).Value
                'fila.Item("pre_ult") = dataArticulo.Item("pre_ult", dataArticulo.CurrentRow.Index).Value
                fila.Item("pre_ult") = dataArticulo.Item("pre_compra", dataArticulo.CurrentRow.Index).Value
                fila.Item("afecto_igv") = dataArticulo.Item("afecto_igv", dataArticulo.CurrentRow.Index).Value
                fila.Item("ingreso") = 0
                fila.Item("operacion") = 0
                fila.Item("obs") = ""
                If dataArticulo.Item("afecto_igv", dataArticulo.CurrentRow.Index).Value = True Then
                    If pImpuestoXarticulo Then
                        fila.Item("igv") = dataArticulo.Item("imp", dataArticulo.CurrentRow.Index).Value
                    Else
                        fila.Item("igv") = pIGV
                    End If
                Else
                    fila.Item("igv") = 0
                End If
                fila.Item("cantidad") = 1
                fila.Item("precio") = dataArticulo.Item("pre_compra", dataArticulo.CurrentRow.Index).Value
                fila.Item("neto") = 0
                If tipoProceso = "E" Then
                    fila.Item("estado") = "New"
                Else
                    fila.Item("estado") = "Reg"
                End If
                dsIngreso.Tables("detalle").Rows.Add(fila)
                dataDetalle.CurrentCell = dataDetalle(dataDetalle.Columns("cantidad").Index, dataDetalle.RowCount - 1)
                dataDetalle.Focus()
            End If
        End If
    End Sub
    Function validaSeleccionArticulos() As Boolean
        Dim resul As Boolean = False
        If cboProveedor.SelectedIndex = -1 Then
            cboProveedor.Focus()
        Else
            If cboFPago.SelectedIndex = -1 Then
                cboFPago.Focus()
            Else

                resul = True

            End If
        End If
        Return resul
    End Function
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
    Private Sub dataDetalle_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataDetalle.CellEndEdit
        ' dataDetalle.Rows(e.RowIndex).Cells(2).Value = Convert.ToDecimal(dataDetalle.Rows(e.RowIndex).Cells(2).Value)
        If esEditable() Then
            Dim lcantidad, lprecio, lneto As Decimal, mIngreso As New Ingreso, mSalida As New Salida, nroIngreso As Integer
            Dim cod_art As String
            cod_art = dataDetalle("cod_Art", dataDetalle.CurrentRow.Index).Value
            nroIngreso = dataDetalle("ingreso", dataDetalle.CurrentRow.Index).Value
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
                    lneto = Round(lcantidad * lprecio, LDecimales)
                    dataDetalle("neto", dataDetalle.CurrentRow.Index).Value = lneto
                End If
                'txtBuscar.Focus()
                'dataDetalle.ClearSelection()
            End If
            If dataDetalle.CurrentCell.ColumnIndex = dataDetalle.Columns("precio").Index Then
                If IsDBNull(dataDetalle("precio", dataDetalle.CurrentRow.Index).Value) Or dataDetalle("precio", dataDetalle.CurrentRow.Index).Value = 0 Then

                    dataDetalle("precio", dataDetalle.CurrentRow.Index).Value = dataDetalle("pre_ult", dataDetalle.CurrentRow.Index).Value
                Else
                    lprecio = dataDetalle("precio", dataDetalle.CurrentRow.Index).Value
                    lcantidad = dataDetalle("cantidad", dataDetalle.CurrentRow.Index).Value
                    lneto = Round(lcantidad * lprecio, LDecimales)
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

            calculaTotal()

            mIngreso.actualizaPrecioIngreso(False, "", nroIngreso, lprecio, lcantidad)
        End If
    End Sub
    Private Sub dataDetalle_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dataDetalle.GotFocus
        dataArticulo.Visible = False
    End Sub
    Private Sub dataDetalle_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataDetalle.CellDoubleClick

        If esEditable() Then
            ingresaobs()
            'si la columna donde hacemos doble click es distinta de la de IGV
            If dataDetalle.CurrentCell.ColumnIndex <> dataDetalle.Columns("afecto_igv").Index Then
                If dataDetalle.CurrentCell.ColumnIndex <> dataDetalle.Columns("precio").Index Then
                    If dataDetalle.CurrentCell.ColumnIndex <> dataDetalle.Columns("obs").Index Then
                        eliminaITEM()
                    End If
                End If
            End If
        End If
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
                p_notas.datosNotas(obs, "orden")
                p_notas.txtnotas.Focus()
                p_notas.Show()
            Else
                p_notas.lblnotas.Text = p_notas.lblnotas.Text + " a :" + dataDetalle("nom_art", ifila).Value
                p_notas.Activate()
            End If
            p_notas.txtnotas.Focus()
        End If
    End Sub


    Private Sub dataDetalle_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dataDetalle.KeyDown
        If e.KeyCode = Keys.Delete Then
            If esEditable() Then
                eliminaITEM()
            End If
        Else
            If e.KeyCode = Keys.Enter Then
                dataDetalle.ClearSelection()
                txtBuscar.Focus()
            End If
        End If
    End Sub
    Sub eliminaITEM()
        Dim rpta As Integer
        Dim cantidad As Decimal = dataDetalle("cantidad", dataDetalle.CurrentRow.Index).Value
        Dim nom_art As String = dataDetalle("nom_art", dataDetalle.CurrentRow.Index).Value
        'Dim nom_uni As String = dataDetalle("nom_uni", dataDetalle.CurrentRow.Index).Value
        Dim cod_art As String = dataDetalle("cod_art", dataDetalle.CurrentRow.Index).Value
        Dim mprecio As New ePrecio
        Dim mIngreso As New Ingreso
        Dim nroIngreso As Integer = dataDetalle("ingreso", dataDetalle.CurrentRow.Index).Value

        If esCopia Then


            rpta = MessageBox.Show("Esta Seguro de Eliminar el ITEM Seleccionado:?" & Chr(13) &
                                UCase(nom_art) & "  " & cantidad & Chr(13) & "Este Proceso es Irreversible...", "SGA",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2)
            If rpta = 6 Then

                Dim mfila As DataRow = dsIngreso.Tables("detalle").Rows(dataDetalle.CurrentRow.Index)
                dsIngreso.Tables("detalle").Rows.Remove(mfila)
            End If


        Else
            If Not IsDBNull(dataDetalle("ingreso", dataDetalle.CurrentRow.Index).Value) Then

                Dim ingreso As Integer = dataDetalle("ingreso", dataDetalle.CurrentRow.Index).Value
                Dim operacion As Integer = dataDetalle("operacion", dataDetalle.CurrentRow.Index).Value
                Dim cod_alma As String = cboAlmacen.SelectedValue

                rpta = MessageBox.Show("Esta Seguro de Eliminar el ITEM Seleccionado:?" & Chr(13) &
                                UCase(nom_art) & "  " & cantidad & Chr(13) & "Este Proceso es Irreversible...", "SGA",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2)
                If rpta = 6 Then

                    mIngreso.eliminaDetalle_OC(nroIngreso)
                    Dim mfila As DataRow = dsIngreso.Tables("detalle").Rows(dataDetalle.CurrentRow.Index)
                    dsIngreso.Tables("detalle").Rows.Remove(mfila)
                End If

            End If
        End If
        calculaTotal()
    End Sub

    Private Sub dataDetalle_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dataDetalle.EditingControlShowing
        ''referenciamos la celda
        'Dim validar As TextBox = CType(e.Control, TextBox)
        ''agregamos el controlador de eventos para el evento KeyPress
        'AddHandler validar.KeyPress, AddressOf validar_KeyPress
    End Sub
    Private Sub validar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dataDetalle.KeyPress
        'obtenemos el indice de la columna
        If dataDetalle.RowCount > 0 Then
            Dim columna As Integer = dataDetalle.CurrentCell.ColumnIndex
            If columna = dataDetalle.Columns("cantidad").Index Or columna = dataDetalle.Columns("precio").Index Then
                If Not Char.IsNumber(e.KeyChar) And Not (e.KeyChar = ChrW(Keys.Back)) And Not (e.KeyChar.Equals(sepDecimal)) Then
                    e.KeyChar = ""
                End If
            End If
        End If
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
                txtTotal.Text = Round(nTotal, LDecimales)
                txtIGV.Text = Round(general.calculaIMPdelTotalAfecto_precioInc(nTotal_afecto), LDecimales)
                txtSubTotal.Text = Round(Round(nTotal, LDecimales) -
                                    Round(general.calculaIMPdelTotalAfecto_precioInc(nTotal_afecto), LDecimales), LDecimales)
            Else
                txtTotal.Text = Round(nTotal, LDecimales)
                txtSubTotal.Text = Round(nTotal, LDecimales)
                txtIGV.Text = 0
            End If
        Else
            If docConIMP Then ' cuando el documento esta sujeto a impuesto
                txtSubTotal.Text = Round(nTotal, LDecimales)
                txtIGV.Text = Round(general.calculaIMPdelTotalAfecto_precioNOInc(nTotal_afecto), LDecimales)
                txtTotal.Text = Round(Round(nTotal, LDecimales) +
                            Round(general.calculaIMPdelTotalAfecto_precioNOInc(nTotal_afecto), LDecimales), LDecimales)
            Else
                txtTotal.Text = Round(nTotal, LDecimales)
                txtSubTotal.Text = Round(nTotal, LDecimales)
                txtIGV.Text = 0
            End If
        End If
    End Sub
    Private Sub cmdGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGrabar.Click
        Dim cReg As Integer, continuar As Boolean = True, transferencia As Boolean = True
        continuar = validaGrabacion()

        Dim tCom, Tprov As New MySqlCommand
        tCom.Connection = dbConex
        Tprov.Connection = dbConex
        If continuar Then
            Dim tipoDocumento, serDocumento, nroDocumento, serGuia, nroGuia As String, fec_ing As Date
            Dim cod_prov, cod_fpago, cod_alma, cod_estado, obs As String, nroIngreso, inc_igv As Integer, tm As String
            Dim actProveedor As Boolean = False
            tipoDocumento = "40"
            serDocumento = txtSerPedido.Text
            nroDocumento = txtNroPedido.Text
            serGuia = "000"
            nroGuia = "00000000"
            fec_ing = mcFIngreso.Value
            cod_prov = cboProveedor.SelectedValue.ToString
            cod_fpago = cboFPago.SelectedValue.ToString
            cod_alma = cboAlmacen.SelectedValue.ToString
            cod_estado = CboEstado.SelectedValue.ToString
            'cod_area = cboArea.SelectedValue.ToString
            obs = txtObs.Text
            If chkIGV.CheckState = CheckState.Checked Then
                inc_igv = 1
            Else
                inc_igv = 0
            End If
            Dim lcancelado As Integer
            If cboFPago.SelectedValue = "01" Then
                lcancelado = 1
            Else
                lcancelado = 0
            End If
            If optMoneda.Checked Then
                tm = pMonedaAbr
            Else
                tm = "D"
            End If

            cReg = dataDetalle.RowCount
            Dim mIngreso As New Ingreso, mprecio As New ePrecio, mpedido As New pedido
            Dim mCatalogo As New Catalogo
            Dim mTransferencia As New Transferencia
            Dim nroTransferencia As String = ""
            Dim mUnidad As New Unidad
            If tipoProceso = "A" Then 'añadir
                If cReg > 0 Then
                    Try

                        establececorrelativo()
                        serDocumento = txtSerPedido.Text
                        nroDocumento = txtNroPedido.Text


                        mIngreso.insertar_oc(nroOperacion, tipoDocumento, serDocumento, nroDocumento, serGuia, nroGuia, cod_estado,
                            fec_ing, cod_prov, cod_fpago, cod_alma, "0000", lcancelado, inc_igv, LDecimales, obs, tm, prTC, pCuentaUser)

                        'registramos el detalle
                        Dim cod_art, unidad, observ As String, cant, precio, igv As Decimal, I As Integer

                        For I = 0 To cReg - 1
                            cod_art = dataDetalle("cod_art", I).Value
                            cant = dataDetalle("cantidad", I).Value
                            precio = dataDetalle("precio", I).Value
                            unidad = dataDetalle("cod_uni", I).Value
                            observ = dataDetalle("obs", I).Value
                            If dataDetalle("afecto_igv", I).Value = False Then
                                igv = 0
                            Else
                                igv = pIGV
                            End If
                            If actProveedor Then
                                Tprov.CommandText = "Update articulo set cod_prov='" & cod_prov & "' where cod_art='" & cod_art & "'"
                                Tprov.ExecuteNonQuery()
                            End If
                            nroIngreso = mIngreso.maxIngreso_oc
                            mIngreso.insertar_oc_det(nroOperacion, nroIngreso, cod_art, cant, precio, igv, unidad, observ, pCuentaUser)



                        Next

                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try
                    tipoProceso = "E"
                    esCopia = False
                Else
                    Try
                        MessageBox.Show("Falta Registrar Artículos...", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        txtBuscar.Focus()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try
                End If

                '  lblIndice.Text = nroOperacion
            Else 'edicion
                Dim cod_art, unidad, observ As String, cant, precio, igv As Decimal
                Dim cProv As String = cboProveedor.SelectedValue
                Dim I As Integer


                mIngreso.actualizaCabecera_oc(nroOperacion, fec_ing, cod_prov, tipoDocumento, serDocumento, nroDocumento, serGuia, nroGuia,
                                           nroTransferencia, cod_fpago, cod_alma, lcancelado, inc_igv, LDecimales, obs, tm)
                For I = 0 To cReg - 1
                    cod_art = dataDetalle("cod_art", I).Value
                    cant = dataDetalle("cantidad", I).Value
                    precio = dataDetalle("precio", I).Value
                    unidad = dataDetalle("cod_uni", I).Value
                    observ = dataDetalle("obs", I).Value
                    nroIngreso = dataDetalle("ingreso", I).Value
                    If dataDetalle("afecto_igv", I).Value = False Then
                        igv = 0
                    Else
                        igv = pIGV
                    End If
                    'como los recuperados ya se grabaron en la edicion, solo grabamos los nuevos
                    If dataDetalle("estado", I).Value = "New" Then
                        nroIngreso = mIngreso.maxIngreso_oc
                        mIngreso.insertar_oc_det(nroOperacion, nroIngreso, cod_art, cant, precio, igv, unidad, observ, pCuentaUser)
                    Else
                        'la actualizacion se lleva cuando se modifica en la grilla
                        'aca solo actualizamos el impuesto
                        tCom.CommandText = "Update orden_compra_det set precio=" & precio & ", cant=" & cant & ", igv=" & igv & ", obs='" & observ & "' where ingreso=" & nroIngreso
                        tCom.ExecuteNonQuery()
                    End If
                    'tCom.CommandText = "Update articulo set pre_ult=" & precio & " where cod_art='" & cod_art & "'"
                    'tCom.ExecuteNonQuery()

                    ' mprecio.actualizaPrecioPromedio(cod_art, fec_ing)
                    'ActualizaPreProm(cod_art, nroIngreso)
                Next
                cargaIngreso(nroOperacion, "-")

            End If

            datosParaEdicion(cod_prov, tipoDocumento, serDocumento, nroDocumento)
            cboProveedor.Focus()
            MessageBox.Show("Documento Registrado Correctamente!!...", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Function validaGrabacion() As Boolean
        Dim valorRetorno As Boolean = False


        If cboProveedor.SelectedIndex >= 0 Then
            If cboFPago.SelectedIndex >= 0 Then
                If cboAlmacen.SelectedIndex >= 0 Then
                    valorRetorno = True

                Else
                    cboAlmacen.Focus()
                End If
            Else
                cboFPago.Focus()
            End If
        Else
            cboProveedor.Focus()
        End If




        Return valorRetorno
    End Function
    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        dataArticulo.Visible = False
        Dim rpta As Integer
        rpta = MessageBox.Show("Esta seguro de Crear el Documento...", "SGA", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)
        If rpta = 6 Then
            reiniciaControles(True, True)
            reiniciaDatos()
            reiniciaDatosEdicion()
            habilitaCabecera()
            modoDeshabilitado()
            cboProveedor.Focus()
            establececorrelativo()
            esCopia = False
        End If

    End Sub
    Private Sub cmdEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEliminar.Click
        Dim mIngreso As New Ingreso
        Dim rpta, doc, nrodoc As String
        doc = "OC"
        nrodoc = txtSerPedido.Text + "-" + txtNroPedido.Text
        rpta = MessageBox.Show("¿Esta Seguro de Eliminar la " + doc + ": " + nrodoc + "?", "SGA", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If rpta = 6 Then

            Dim cad As String
            cad = "delete from orden_compra where operacion=" & nroOperacion
            Dim com As New MySqlCommand(cad, dbConex)
            com.ExecuteNonQuery()
            reiniciaControles(True, True)
            reiniciaDatos()
            reiniciaDatosEdicion()
            habilitaCabecera()
            modoDeshabilitado()
            cboProveedor.Focus()
            establececorrelativo()
        End If



    End Sub
    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        Dim periodo As String = periodoIngreso
        Dim esHistorial As Boolean = False
        Dim mIngreso As New Ingreso
        Dim frm As New rptForm
        Dim ds As New DataSet

        ds = mIngreso.recuperaDocumentoIngreso_OC(esHistorial, periodo, "40", txtSerPedido.Text, txtNroPedido.Text, nroOperacion)

        frm.cargarDocumentoIngreso_OC(ds)
        frm.MdiParent = principal
        frm.Show()
    End Sub
    Sub reiniciaControles(ByVal incluirNroIngreso As Boolean, ByVal incluirCabecera As Boolean)
        'establecemos las fechas de proceso
        'estableceFechaProceso()
        If incluirNroIngreso Then

        End If
        If incluirCabecera Then
            cboProveedor.SelectedIndex = -1
            cboProveedor.SelectedIndex = -1
            cboProveedor.Refresh()
            txtRUC.Text = ""
            txtDireccion.Text = ""
            cboFPago.SelectedIndex = -1
            cboFPago.SelectedIndex = -1
            cboFPago.Refresh()
            cboAlmacen.SelectedIndex = -1
            cboAlmacen.SelectedIndex = -1
            cboAlmacen.Refresh()
            optMoneda.Checked = True
        End If
        If pPreciosIncIGV Then
            chkIGV.CheckState = CheckState.Checked
        Else
            chkIGV.CheckState = CheckState.Unchecked
        End If
        dataArticulo.Visible = False
        dataDetalle.Columns("cantidad").ReadOnly = False
        dataDetalle.Columns("precio").ReadOnly = False

        ' lblIndice.Text = "0"
        txtObs.Text = ""
        txtBuscar.Text = ""
        lblItems.Text = "Nro de Items. 0"
        txtTotal.Text = "0.00"
        txtSubTotal.Text = "0.00"
        txtIGV.Text = "0.00"
        muestraTCActual()
    End Sub
    Sub reiniciaDatos()
        periodoIngreso = periodoActivo()
        nroOperacion = 0
        tipoProceso = "A"
        dsIngreso.Clear()
        dsArticulo.Clear()
    End Sub
    Sub reiniciaDatosEdicion()
        cProveedor = ""
        cDocumento = ""
        cSerDocumento = ""
        cNroDocumento = ""
    End Sub
    Sub deshabilitaCabecera()
        cboProveedor.Enabled = False

        cboAlmacen.Enabled = False
        cboFPago.Enabled = False

        txtObs.ReadOnly = True
        txtBuscar.ReadOnly = True

        'txtObs.FocusHighlightEnabled = False
        txtBuscar.FocusHighlightEnabled = False
        mcFIngreso.Enabled = False
    End Sub
    Sub habilitaCabecera()
        cboProveedor.Enabled = True

        cboAlmacen.Enabled = True
        cboFPago.Enabled = True

        txtObs.ReadOnly = False
        txtBuscar.ReadOnly = False

        'txtObs.FocusHighlightEnabled = True
        txtBuscar.FocusHighlightEnabled = True
        mcFIngreso.Enabled = True
    End Sub
    Sub modoEdicion()
        cmdGrabar.Enabled = True
        cmdCancelar.Enabled = True
        cmdEliminar.Enabled = True
        cmdImprimir.Enabled = True
    End Sub
    Sub modoAñadir()
        cmdGrabar.Enabled = True
        cmdCancelar.Enabled = True
        cmdEliminar.Enabled = True
        cmdImprimir.Enabled = True
    End Sub
    Sub modoDeshabilitado()
        cmdGrabar.Enabled = False
        cmdCancelar.Enabled = False
        cmdEliminar.Enabled = False
        cmdImprimir.Enabled = False
    End Sub
    Sub estableceFechaProceso()

        mcFIngreso.MinDate = Microsoft.VisualBasic.DateAndTime.DateAdd(DateInterval.Day, -pDiasModificarIngreso, pFechaSystem)
        mcFIngreso.MaxDate = Microsoft.VisualBasic.DateAndTime.DateAdd(DateInterval.Day, +pDiasModificarIngreso, pFechaSystem)
        mcFIngreso.Value = Microsoft.VisualBasic.DateAndTime.DateAdd(DateInterval.Day, +1, pFechaSystem)
    End Sub
    Function esPeriodoActivo() As Boolean
        Dim fSeleccionada As Date
        fSeleccionada = mcFIngreso.Value
        If fSeleccionada >= fechaActivaMin() And fSeleccionada <= pFechaActivaMax Then
            Return True
        Else
            Return False
        End If
    End Function
    Sub muestraTCActual()
        lblTC.Text = "Tipo Cambio: " & prTC
    End Sub
    Public Sub datosParaEdicion(ByVal proveedor As String, ByVal documento As String, ByVal serieDocumento As String, ByVal nroDocumento As String)
        cProveedor = proveedor
        cDocumento = documento
        cSerDocumento = serieDocumento
        cNroDocumento = nroDocumento
        tipoProceso = "E"
    End Sub

    Private Sub mcFIngreso_DateChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim mTcambio As New TipoCambio
        prTC = mTcambio.recupera(mcFIngreso.Value)
        muestraTCActual()
    End Sub

    Private Sub mcFIngreso_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        dataArticulo.Visible = False
    End Sub

    Private Sub cmdHistorial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If dataDetalle.RowCount > 0 Then
            If Not IsDBNull(dataDetalle("cod_art", dataDetalle.CurrentRow.Index).Value) Then
                Dim IsFormCargado As Boolean = False
                Dim mForm As Form
                For Each mForm In principal.MdiChildren
                    If mForm.Name = "c_historialCompras_x_articulo" Then
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
                    c_historialCompras_x_articulo.MdiParent = principal
                    c_historialCompras_x_articulo.datosConsulta(dataDetalle("cod_art", dataDetalle.CurrentRow.Index).Value)
                    c_historialCompras_x_articulo.muestraCompras()
                    c_historialCompras_x_articulo.Show()
                Else
                    c_historialCompras_x_articulo.datosConsulta(dataDetalle("cod_art", dataDetalle.CurrentRow.Index).Value)
                    c_historialCompras_x_articulo.Activate()
                    c_historialCompras_x_articulo.Focus()
                End If
            Else
                MessageBox.Show("Seleccione Artículo a Mostrar su Historial...", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("No Existen Artículos a Mostrar su Historial...", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub


    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MessageBox.Show(esPeriodoActivo)
    End Sub




    Sub buscarcliente()
        Try
            If Microsoft.VisualBasic.Len(cboProveedor.Text) > 0 Then
                Dim lproveedor As String = cboProveedor.SelectedValue.ToString
                Dim fila() As DataRow
                fila = dsProveedor.Tables("proveedor").Select("cod_prov ='" & lproveedor & "'")
                txtRUC.Text = fila(0).Item("cod_prov").ToString
                txtDireccion.Text = fila(0).Item("dir_prov").ToString
                'If Not validaIngreso() Then
                '    e. = True
                'End If
            End If
        Catch err As Exception
            MessageBox.Show("Seleccione un Proveedor Registrado...", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cboProveedor.SelectedIndex = -1
            'e.Cancel = True
        End Try

    End Sub

    Sub cargaDetalle(ByVal nro_ope As Integer, ByVal facturaAnulada As Boolean)
        Dim msalida As New Salida, I As Integer
        Dim dt As New DataTable
        If facturaAnulada Then
            dt = msalida.recuperaDetalle_anul(nro_ope, LDecimales)
        Else
            dt = msalida.recuperaDetalle(nro_ope, LDecimales, False)
        End If
        For I = 0 To dt.Rows.Count - 1
            dtDetalle.ImportRow(dt.Rows(I))
        Next
        dataDetalle.DataSource = dsIngreso.Tables("detalle")
        calculaTotal()
        dataDetalle.Refresh()
    End Sub

    Private Sub txtNroPedido_TextChanged(sender As Object, e As EventArgs) Handles txtNroPedido.TextChanged

    End Sub



    Sub establececorrelativo()
        Dim mpedido As New pedido
        nroOperacion = mpedido.maxOperacion_OC
        'txtSerPedido.Text = periodoActivo()
        txtSerPedido.Text = "OC1"
        txtNroPedido.Text = nroOperacion
        txtNroPedido.Text = Microsoft.VisualBasic.Right("00000000" & txtNroPedido.Text, 8)
        modoEdicion()
    End Sub


    Sub valida_orden()
        Dim ope As Integer, rpta As Integer, lserie As String, lnumero As String
        If Microsoft.VisualBasic.Len(txtSerPedido.Text) > 0 And Microsoft.VisualBasic.Len(txtNroPedido.Text) > 0 Then
            'lserie = Microsoft.VisualBasic.Right("000000" & txtSerPedido.Text, 6)
            lserie = txtSerPedido.Text
            lnumero = Microsoft.VisualBasic.Right("00000000" & txtNroPedido.Text, 8)
            ope = existePedido(lserie, lnumero)
            If ope > 0 Then
                rpta = MessageBox.Show("Nº Ordeb Compra " & lserie & "-" & lnumero &
                " Ya Existe, ¿DESEA MOSTRARLO?", "SGA", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)
                If rpta = 6 Then
                    cargaIngreso(ope, "-")
                    Dim mPedido As New pedido
                    If mPedido.facturado_oc(ope) Then
                        MessageBox.Show("ORDEM DE COMPRA CERRADA...", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        dataDetalle.Columns("cantidad").ReadOnly = True
                        modoDeshabilitado()
                        cmdImprimir.Enabled = True
                        cmdCancelar.Enabled = True
                    Else
                        dataDetalle.Columns("cantidad").ReadOnly = False
                    End If
                    cboProveedor.Focus()
                Else
                    'como aun no iniciamos el proceso, el nro de operacion es cero
                    reiniciaControles(True, True)
                    'reiniciaDatos()
                    tipoProceso = "A"
                    'txtSerPedido.Focus()
                End If
            Else
                reiniciaControles(True, False)
                'reiniciaDatos()
                modoAñadir()
                txtBuscar.Focus()
            End If
        Else
            modoDeshabilitado()
        End If
    End Sub

    Function existePedido(ByVal serie As String, ByVal numero As String) As Integer
        Dim mpedido As New pedido, lOperacion As Integer
        lOperacion = mpedido.existe_oc(serie, numero)
        Return lOperacion
    End Function

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtNroPedido_GotFocus(sender As Object, e As EventArgs) Handles txtNroPedido.GotFocus
        general.ingresaTextoProceso(txtNroPedido)
    End Sub

    Private Sub cboProveedor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProveedor.SelectedIndexChanged

    End Sub

    Private Sub txtNroPedido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNroPedido.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not (e.KeyChar = ChrW(Keys.Back)) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub dataDetalle_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataDetalle.CellContentClick

    End Sub

    Private Sub txtNroPedido_LostFocus(sender As Object, e As EventArgs) Handles txtNroPedido.LostFocus
        general.saleTextoProceso(txtNroPedido)
        If Val(txtNroPedido.Text) > 0 Then
            txtNroPedido.Text = Microsoft.VisualBasic.Right("00000000" & txtNroPedido.Text, 8)
        Else
            txtNroPedido.Text = ""
        End If
    End Sub

    Private Sub dataArticulo_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataArticulo.CellContentClick

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub cmdCopiar_Click(sender As Object, e As EventArgs) Handles cmdCopiar.Click
        reiniciaControles(True, False)
        'reiniciaDatos()
        tipoProceso = "A"
        esCopia = True
        'txtSerPedido.Focus()
        establececorrelativo()
        modoAñadir()
        'CboEstado.SelectedValue = "0001"
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim buscar As String = cboProveedor.Text.Trim()
        cargarproveedor("%" & buscar & "%")
    End Sub

    Private Sub txtNroPedido_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNroPedido.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            valida_orden()
            cboProveedor.Focus()
        End If
    End Sub

    Private Sub cboProveedor_KeyDown(sender As Object, e As KeyEventArgs) Handles cboProveedor.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            cboAlmacen.Focus()

        End If
    End Sub

    Sub AgregaObservacion(ByVal obs As String)
        dataDetalle(dataDetalle.CurrentCell.ColumnIndex, dataDetalle.CurrentRow.Index).Value = obs
        dataDetalle.Focus()
    End Sub
End Class
