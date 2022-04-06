Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Math
Imports libreriaClases
Public Class p_ingresos
    Private dsDocumento As New DataSet
    Private dsFPago As New DataSet
    Private dsAlmacen As New DataSet
    Private dsAlmacenT As New DataSet
    Private dsProveedor As New DataSet
    Private dsArticulo As New DataSet
    Private dsIngreso As New DataSet
    Private dsArea As New DataSet
    Private dtDetalle As New DataTable("detalle")
    Private dtproveedor As New DataTable("proveedor")
    Private prTC As Decimal = pTC
    'variable que almacena la operacion en proceso
    Private nroOperacion As Integer = 0
    Private periodoIngreso As String = periodoActivo()
    Private eshistorial As Boolean
    'Variable donde indicamos el tipo de proceso - A=Añadir - E=Edicion
    Private tipoProceso As Char = "A"
    'para validar el separador decimal
    Private sepDecimal As Char
    Private estaCargando As Boolean = True
    '//VARIABLES PARA CUANDO SE RECUPERA DESDE OTRO LADO UN DOCUMENTO
    Private cProveedor As String = "", cDocumento As String = "", cSerDocumento As String = "", cNroDocumento As String = ""
    Private nroOperacionPedido As Integer = 0
    Private LDecimales = 4
    Private Sub p_ingresos_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        'mostramos el tipo de cambio actual
        muestraTCActual()
    End Sub
    Private Sub p_ingresos_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        principal.mp_ingreso.Enabled = True
    End Sub
    Private Sub p_ingresos_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        dataArticulo.Visible = False
    End Sub
    Private Sub p_ingresos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'establecemos la fecha de proceso
        estableceFechaProceso()
        'verificamos si los precios ya tienen el igv
        If pPreciosIncIGV Then
            chkIGV.CheckState = CheckState.Checked
        Else
            chkIGV.CheckState = CheckState.Unchecked
        End If
        'System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-ES")
        'capturamos el separador decimal
        sepDecimal = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        'dataset documento ingreso
        Dim daDocumento As New MySqlDataAdapter
        Dim comDoc As New MySqlCommand("select cod_doc,nom_doc,conIMP,esCompra from documento_i where activo=1", dbConex)
        daDocumento.SelectCommand = comDoc
        daDocumento.Fill(dsDocumento, "documento_i")
        With cboDocumento
            .DataSource = dsDocumento.Tables("documento_i")
            .DisplayMember = dsDocumento.Tables("documento_i").Columns("nom_doc").ToString
            .ValueMember = dsDocumento.Tables("documento_i").Columns("cod_doc").ToString
            .SelectedIndex = -1
        End With
        'dataset forma de pago
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
        'dataset almacen de transferencias
        Dim daAlmacenT As New MySqlDataAdapter
        Dim comAlmacenT As New MySqlCommand("select cod_alma,nom_alma from almacen where activo=1 and (destinoTrans) order by nom_alma", dbConex)
        daAlmacenT.SelectCommand = comAlmacenT
        daAlmacenT.Fill(dsAlmacenT, "almacen")
        With cboAlmaTransferencia
            .DataSource = dsAlmacenT.Tables("almacen")
            .DisplayMember = dsAlmacenT.Tables("almacen").Columns("nom_alma").ToString
            .ValueMember = dsAlmacenT.Tables("almacen").Columns("cod_alma").ToString
            .SelectedIndex = -1
        End With

        'combo proveedores
        cargarproveedor("%")

        'dataset detalle
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
            .Columns("nom_uni").Width = 65
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
            '.Columns("neto").DefaultCellStyle.Format = "c"
            .Columns("cod_uni").Visible = False
            .Columns("operacion").Visible = False
            .Columns("ingreso").Visible = False
            .Columns("estado").Visible = False
            .Columns("porcentaje").Visible = False
        End With
        'establecemos la moneda nacional
        optMoneda.Text = pMoneda
        txtSerPedido.Text = "OC1"
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
    Private Sub cboProveedor_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboProveedor.GotFocus
        dataArticulo.Visible = False
    End Sub
    Private Sub cboProveedor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboProveedor.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            cboDocumento.Focus()
        End If
    End Sub
    Private Sub cboProveedor_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboProveedor.Validating
        Try
            If Microsoft.VisualBasic.Len(cboProveedor.Text) > 0 Then
                Dim lproveedor As String = cboProveedor.SelectedValue.ToString
                Dim fila() As DataRow
                fila = dsProveedor.Tables("proveedor").Select("cod_prov ='" & lproveedor & "'")
                txtRUC.Text = fila(0).Item("cod_prov").ToString
                txtDireccion.Text = fila(0).Item("dir_prov").ToString
                If Not validaIngreso() Then
                    e.Cancel = True
                End If
            End If
        Catch err As Exception
            MessageBox.Show("Seleccione un Proveedor Registrado...", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cboProveedor.SelectedIndex = -1
            e.Cancel = True
        End Try
    End Sub
    Private Sub cboDocumento_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboDocumento.GotFocus
        dataArticulo.Visible = False
        If dsDocumento.Tables("documento_i").Rows.Count > 0 Then
            If cboDocumento.SelectedIndex = -1 Then
                cboDocumento.SelectedIndex = 0
            End If
        End If
    End Sub
    Private Sub cboDocumento_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboDocumento.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtSerDocumento.Focus()
        End If
    End Sub
    Private Sub cboDocumento_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboDocumento.Validating
        If Not validaIngreso() Then
            e.Cancel = True
        End If
    End Sub
    Private Sub cboDocumento_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDocumento.SelectedIndexChanged
        If Not estaCargando Then
            If cboDocumento.SelectedIndex >= 0 Then
                If dsDocumento.Tables("documento_i").Rows(cboDocumento.SelectedIndex).Item("conIMP").ToString() = False Then
                    chkIGV.Checked = False
                End If
                calculaTotal()
            End If
        End If
    End Sub
    Private Sub txtSerDocumento_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSerDocumento.GotFocus
        dataArticulo.Visible = False
    End Sub
    Private Sub txtSerDocumento_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSerDocumento.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtNroDocumento.Focus()
        End If
    End Sub
    Private Sub txtSerDocumento_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtSerDocumento.Validating
        If Not validaIngreso() Then
            e.Cancel = True
        End If
    End Sub
    Private Sub txtSerDocumento_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSerDocumento.KeyPress
        'If Not Char.IsNumber(e.KeyChar) And Not (e.KeyChar = ChrW(Keys.Back)) Then
        '    e.KeyChar = ""
        'End If
    End Sub
    Private Sub txtSerDocumento_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSerDocumento.LostFocus
        If Microsoft.VisualBasic.Len(txtSerDocumento.Text) > 0 Then
            txtSerDocumento.Text = Microsoft.VisualBasic.Right("000000" & txtSerDocumento.Text, 6)
        End If
    End Sub
    Private Sub txtNroDocumento_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNroDocumento.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtSerGuia.Focus()
        End If
    End Sub
    Private Sub txtNroDocumento_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNroDocumento.Validating
        If Not validaIngreso() Then
            e.Cancel = True
        End If
    End Sub
    Private Sub txtNroDocumento_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNroDocumento.GotFocus
        'verificamos si es una nota de ingreso
        'en ese caso generamos el numero de documento
        dataArticulo.Visible = False
        If cboDocumento.SelectedValue = "03" Then
            If Len(txtNroDocumento.Text) = 0 Then
                Dim mIngreso As New Ingreso
                txtNroDocumento.Text = Microsoft.VisualBasic.Right("00000000" & mIngreso.maxNotaIngreso("03", txtSerDocumento.Text), 8)
            End If
        End If
    End Sub
    Private Sub txtNroDocumento_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNroDocumento.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not (e.KeyChar = ChrW(Keys.Back)) Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub txtNroDocumento_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNroDocumento.LostFocus
        If Microsoft.VisualBasic.Len(txtNroDocumento.Text) > 0 Then
            txtNroDocumento.Text = Microsoft.VisualBasic.Right("00000000" & txtNroDocumento.Text, 8)
        End If
    End Sub
    Private Sub txtSerGuia_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSerGuia.GotFocus
        dataArticulo.Visible = False
    End Sub
    Private Sub txtSerGuia_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSerGuia.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtNroGuia.Focus()
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
        End If
    End Sub
    Private Sub txtNroGuia_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNroGuia.GotFocus
        dataArticulo.Visible = False
    End Sub
    Private Sub txtNroGuia_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNroGuia.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboAlmacen.Focus()
        End If
    End Sub
    Private Sub txtNroGuia_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNroGuia.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not (e.KeyChar = ChrW(Keys.Back)) Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub txtNroGuia_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNroGuia.LostFocus
        If txtNroGuia.ReadOnly = False Then
            If Microsoft.VisualBasic.Len(txtNroGuia.Text) > 0 Then
                txtNroGuia.Text = Microsoft.VisualBasic.Right("00000000" & txtNroGuia.Text, 8)
            End If
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
            txtObs.Focus()
        End If
    End Sub
    Private Sub txtObs_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtObs.GotFocus
        dataArticulo.Visible = False
    End Sub
    Private Sub txtObs_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtObs.KeyDown
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
            If cboDocumento.SelectedIndex >= 0 Then
                If dsDocumento.Tables("documento_i").Rows(cboDocumento.SelectedIndex).Item("conIMP").ToString() = False Then
                    chkIGV.Checked = False
                End If
            End If
            calculaTotal()
        End If
    End Sub
    Function validaIngreso() As Boolean
        Dim result As Boolean = True

        If tipoProceso = "E" Then
            If Not esDocumentoRecuperado() Then
                Dim existeIngreso As Boolean

                existeIngreso = existeDocumentoIngreso(cboProveedor.SelectedValue, cboDocumento.SelectedValue, txtSerDocumento.Text, txtNroDocumento.Text)

                If existeIngreso Then
                    MessageBox.Show(cboDocumento.Text & " " & txtSerDocumento.Text & "-" & txtNroDocumento.Text & Chr(13) & "Ya Esta Registrada...", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    modoDeshabilitado()
                    result = False
                Else
                    If Len(cboProveedor.SelectedValue) > 0 And Len(cboDocumento.SelectedValue) > 0 And Len(txtSerDocumento.Text) > 0 And Len(txtNroDocumento.Text) > 0 Then
                        If esEditable() Then
                            modoAñadir()
                        Else
                            modoDeshabilitado()
                        End If
                    Else
                        modoDeshabilitado()
                    End If
                End If
            Else
                If esEditable() Then
                    modoEdicion()
                Else
                    modoDeshabilitado()
                    cmdCancelar.Enabled = True
                    cmdImprimir.Enabled = True
                End If
            End If
        Else
            Dim existeIngreso As Boolean
            existeIngreso = existeDocumentoIngreso(cboProveedor.SelectedValue, cboDocumento.SelectedValue, txtSerDocumento.Text, txtNroDocumento.Text)
            If existeIngreso Then
                MessageBox.Show(cboDocumento.Text & " " & txtSerDocumento.Text & "-" & txtNroDocumento.Text & Chr(13) & "Ya Esta Registrada...", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Error)
                modoDeshabilitado()
                result = False
            Else
                If Len(cboProveedor.SelectedValue) > 0 And Len(cboDocumento.SelectedValue) > 0 And Len(txtSerDocumento.Text) > 0 And Len(txtNroDocumento.Text) > 0 Then
                    modoAñadir()
                Else
                    modoDeshabilitado()
                End If
            End If
        End If

        Return result
    End Function
    Function esDocumentoRecuperado() As Boolean
        Dim lproveedor As String, ldocumento As String, lserie As String, lnumero As String
        lproveedor = cboProveedor.SelectedValue
        ldocumento = cboDocumento.SelectedValue
        lserie = Microsoft.VisualBasic.Right("0000000" & txtSerDocumento.Text, 6)
        lnumero = Microsoft.VisualBasic.Right("00000000" & txtNroDocumento.Text, 8)
        If cProveedor = lproveedor And cDocumento = ldocumento And cSerDocumento = lserie And cNroDocumento = lnumero Then
            Return True
        Else
            Return False
        End If
    End Function
    Function existeDocumentoIngreso(ByVal cod_prov As String, ByVal tipo_doc As String, ByVal ser_doc As String, ByVal nro_doc As String) As Boolean
        Dim mIngreso As New Ingreso, lSerie, lNumero As String, operacion As Integer
        lSerie = Microsoft.VisualBasic.Right("000000" & ser_doc, 6)
        lNumero = Microsoft.VisualBasic.Right("00000000" & nro_doc, 8)
        'If cboDocumento.SelectedValue = "03" Then 'nota de ingreso
        '    operacion = mIngreso.existeNotaIngreso(lSerie, lNumero)
        'Else
        operacion = mIngreso.existe(tipo_doc, lSerie, lNumero, cod_prov)
        ' End If
        'como no esta en el periodo actual, verificamos el historial
        If operacion = 0 Then
            'If cboDocumento.SelectedValue = "03" Then 'nota de ingreso
            '    operacion = mIngreso.existeNotaIngreso_historialGeneral(lSerie, lNumero)
            'Else
            operacion = mIngreso.existe_historialGeneral(tipo_doc, lSerie, lNumero, cod_prov)
            'End If
        End If
        If operacion > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Function cargamosElIngreso() As Boolean
        Dim lrpta As Integer
        lrpta = MessageBox.Show("El Documento ya Existe?" & Chr(13) & "Desea Recuperarlo...", "SGA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        If lrpta = 6 Then
            Return True
        Else
            Return False
        End If
    End Function
    Sub estableceDatosEdicion()
        datosParaEdicion(cboProveedor.SelectedValue, cboDocumento.SelectedValue, txtSerDocumento.Text, txtNroDocumento.Text)
    End Sub
    Public Sub cargaIngreso(ByVal operacion As Integer, ByVal periodo As String)
        dsIngreso.Clear()
        dsArticulo.Clear()
        reiniciaDatos()
        reiniciaControles(False, False)
        'establecemos el valor de las variables de formulario
        eshistorial = IIf(periodo = periodoActivo(), False, True)
        periodoIngreso = periodo
        nroOperacion = operacion
        tipoProceso = "E"
        cargaCabecera()
        cargaDetalle()
        If esEditable() Or pNivelUser = 0 Then
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
        'cboAlmacen.Enabled = False
        'verificamos si el documento ya se transfirio
        'si ya se transfirio el documento completo
        Dim mIngreso As New Ingreso
        Dim mTransferencia As New Transferencia
        Dim cTransferencia As String, almaTransferencia As String
        Dim seTransfirio As Boolean = mIngreso.exisTransferencia_documento(nroOperacion)
        If seTransfirio Then
            cTransferencia = mTransferencia.recNroTransferencia(nroOperacion, eshistorial, periodo)
            lblTransferencia.Text = "Tr." & cTransferencia
            almaTransferencia = mTransferencia.recAlmaTransferencia(nroOperacion)
            cboAlmaTransferencia.SelectedValue = almaTransferencia
            chkAlmaTransferencia.Enabled = False
            cboAlmaTransferencia.Enabled = False
        Else
            'lblTransferencia.Text = ""
        End If
        txtBuscar.Focus()
    End Sub
    Sub cargaCabecera()
        Dim mIngreso As New Ingreso
        Dim dt As New DataTable
        eshistorial = IIf(periodoIngreso = periodoActivo(), False, True)
        dt = mIngreso.recuperaCabecera(eshistorial, periodoIngreso, nroOperacion)
        'mostramos los valores recuperados
        lblIndice.Text = nroOperacion
        mcFIngreso.SelectedDate = dt.Rows(0).Item("fec_doc")
        cboProveedor.SelectedValue = dt.Rows(0).Item("cod_prov").ToString
        txtRUC.Text = dt.Rows(0).Item("cod_prov").ToString
        txtDireccion.Text = dt.Rows(0).Item("dir_prov").ToString
        cboDocumento.SelectedValue = dt.Rows(0).Item("cod_doc").ToString
        txtSerDocumento.Text = dt.Rows(0).Item("ser_doc").ToString
        txtNroDocumento.Text = dt.Rows(0).Item("nro_doc").ToString
        txtSerGuia.Text = dt.Rows(0).Item("ser_guia").ToString
        txtNroGuia.Text = dt.Rows(0).Item("nro_guia").ToString
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
        eshistorial = IIf(periodoIngreso = periodoActivo(), False, True)
        Dim dt As New DataTable
        dt = mIngreso.recuperaDetalle(eshistorial, periodoIngreso, nroOperacion, LDecimales)
        For I = 0 To dt.Rows.Count - 1
            dsIngreso.Tables("detalle").ImportRow(dt.Rows(I))
        Next
        dataDetalle.DataSource = dsIngreso.Tables("detalle")
        calculaTotal()
        dataDetalle.Refresh()
    End Sub
    Function esEditable() As Boolean
        Dim mIngreso As New Ingreso
        Dim existe As Boolean, lTipodoc, lSerie, lNumero, lProveedor As String, lfechaIng As Date
        lSerie = Microsoft.VisualBasic.Right("000000" & txtSerDocumento.Text, 6)
        lNumero = Microsoft.VisualBasic.Right("00000000" & txtNroDocumento.Text, 8)
        lTipodoc = cboDocumento.SelectedValue
        lProveedor = cboProveedor.SelectedValue
        If periodoIngreso = periodoActivo() Then
            existe = mIngreso.existe(lTipodoc, lSerie, lNumero, lProveedor)
        Else
            existe = mIngreso.existe_historial(periodoIngreso, lTipodoc, lSerie, lNumero, lProveedor)
        End If
        If existe Then
            lfechaIng = mIngreso.devuelveFechaIngreso(eshistorial, periodoIngreso, lTipodoc, lSerie, lNumero)
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
            dsArticulo = mCatalogo.recuperaCatalogo(True, lAlmacen, True, False, False, False, "", False, True, False)
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
            .Columns("nom_art").Width = 265
            .Columns("nom_uni").HeaderText = "Unidad"
            .Columns("nom_uni").DisplayIndex = 1
            .Columns("nom_uni").Width = 75
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
                fila.Item("nom_uni") = dataArticulo.Item("nom_uni", dataArticulo.CurrentRow.Index).Value
                fila.Item("pre_ult") = dataArticulo.Item("pre_ult", dataArticulo.CurrentRow.Index).Value
                fila.Item("afecto_igv") = dataArticulo.Item("afecto_igv", dataArticulo.CurrentRow.Index).Value
                fila.Item("ingreso") = 0
                fila.Item("operacion") = 0
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
                fila.Item("precio") = dataArticulo.Item("pre_ult", dataArticulo.CurrentRow.Index).Value
                fila.Item("neto") = dataArticulo.Item("pre_ult", dataArticulo.CurrentRow.Index).Value * 1
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
                    lcantidad = 0
                    dataDetalle("cantidad", dataDetalle.CurrentRow.Index).Value = lcantidad
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
                    dataDetalle("neto", dataDetalle.CurrentRow.Index).Value = lneto
                Else
                    lneto = dataDetalle("neto", dataDetalle.CurrentRow.Index).Value
                    lcantidad = dataDetalle("cantidad", dataDetalle.CurrentRow.Index).Value
                    lprecio = Round(lneto / lcantidad, 10)
                    dataDetalle("precio", dataDetalle.CurrentRow.Index).Value = lprecio
                End If
            End If
            dataDetalle.Rows(e.RowIndex).ErrorText = String.Empty
            'lneto = Round(lcantidad * lprecio, LDecimales)
            'dataDetalle("neto", dataDetalle.CurrentRow.Index).Value = lneto
            calculaTotal()
            'If dataDetalle.CurrentCell.ColumnIndex = dataDetalle.Columns("cantidad").Index Then
            '    'validamos que la cantidad a registrar sea mayor a la cantidad ya despachada
            '    Dim cantSalida As Decimal = mIngreso.salidasDelIngreso(nroIngreso)
            '    Dim saldo As Decimal = lcantidad - cantSalida
            '    If lcantidad >= cantSalida Then
            '        mIngreso.actualizaDetalle(nroIngreso, lcantidad, lprecio, pIGV, saldo)
            '        nroOperacion = dataDetalle("Operacion", dataDetalle.CurrentRow.Index).Value
            '        If nroOperacion > 0 Then
            '            mSalida.actualizaDetalleAux(nroOperacion, cod_art, lcantidad, lprecio, pIGV)
            '            nroIngreso = mSalida.devuelveNroIngreso(nroOperacion, cod_art)
            '            If nroIngreso > 0 Then
            '                lcantidad = DevulveCantidadArtRel(cod_art, cboAlmaTransferencia.SelectedValue, lcantidad, lprecio)
            '                mIngreso.actualizaDetalle(nroIngreso, lcantidad, lprecio, pIGV, saldo)
            '            End If
            '        End If
            '    Else
            '        mIngreso.actualizaDetalle(nroIngreso, cantSalida, lprecio, pIGV, 0)
            '        dataDetalle("cantidad", dataDetalle.CurrentRow.Index).Value = cantSalida
            '        MessageBox.Show("La Cantidad Mínima es: " + Str(cantSalida), "CEFE", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            '    End If
            '    Try
            '        dataDetalle.CurrentCell = dataDetalle(dataDetalle.Columns("precio").Index, dataDetalle.CurrentRow.Index)
            '    Catch
            '    End Try
            '    dataDetalle.Focus()
            'End If
            mIngreso.actualizaPrecioIngreso(eshistorial, periodoIngreso, nroIngreso, lprecio, lcantidad)
        End If
    End Sub
    Private Sub dataDetalle_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dataDetalle.GotFocus
        dataArticulo.Visible = False
    End Sub
    Private Sub dataDetalle_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataDetalle.CellDoubleClick
        If esEditable() Then
            'si la columna donde hacemos doble click es distinta de la de IGV
            If dataDetalle.CurrentCell.ColumnIndex <> dataDetalle.Columns("afecto_igv").Index Then
                If dataDetalle.CurrentCell.ColumnIndex <> dataDetalle.Columns("precio").Index Then
                    eliminaITEM()
                End If
            End If
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
        Dim nom_uni As String = dataDetalle("nom_uni", dataDetalle.CurrentRow.Index).Value
        Dim cod_art As String = dataDetalle("cod_art", dataDetalle.CurrentRow.Index).Value
        Dim mprecio As New ePrecio
        If Not IsDBNull(dataDetalle("ingreso", dataDetalle.CurrentRow.Index).Value) Then
            Dim mIngreso As New Ingreso
            Dim nroIngreso As Integer = dataDetalle("ingreso", dataDetalle.CurrentRow.Index).Value
            'verificamos si ya tuvo salidas el producto
            Dim yaSalio As Integer = mIngreso.existeSalida(nroIngreso, False)
            If yaSalio Then
                Dim mCatalogo As New Catalogo
                Dim ingreso As Integer = dataDetalle("ingreso", dataDetalle.CurrentRow.Index).Value
                Dim operacion As Integer = dataDetalle("operacion", dataDetalle.CurrentRow.Index).Value
                Dim cod_alma As String = cboAlmacen.SelectedValue
                Dim stock As Decimal = mCatalogo.recuperaStockArticulo(False, "", False, True, cod_alma, cod_art, 0)
                If stock >= cantidad Then
                    rpta = MessageBox.Show("Esta Seguro de Eliminar el ITEM Seleccionado:?" & Chr(13) &
                                UCase(nom_art) & "  " & cantidad & " " & UCase(nom_uni) & Chr(13) & "Este Proceso es Irreversible...", "SGA",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2)
                    If rpta = 6 Then
                        mueveIngreso(ingreso, cod_art, cantidad, cod_alma, operacion)
                        mIngreso.eliminaDetalle(nroIngreso)
                        Dim mfila As DataRow = dsIngreso.Tables("detalle").Rows(dataDetalle.CurrentRow.Index)
                        dsIngreso.Tables("detalle").Rows.Remove(mfila)
                        mprecio.actualizaPrecioPromedio(cod_art)
                        calculaTotal()
                    End If
                Else
                    MessageBox.Show("El Registro Tiene Salidas, NO es Posible Eliminarlo..." _
                        & Chr(13) & "Porque Carece de Stock Suficiente para Procesar datos",
                        "SGA", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                End If
            Else
                rpta = MessageBox.Show("Esta Seguro de Eliminar el ITEM Seleccionado:?" & Chr(13) &
                        UCase(nom_art) & "  " & cantidad & " " & UCase(nom_uni) & Chr(13) & "Este Proceso es Irreversible...", "SGA",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2)
                If rpta = 6 Then
                    mIngreso.eliminaDetalle(nroIngreso)
                    Dim mfila As DataRow = dsIngreso.Tables("detalle").Rows(dataDetalle.CurrentRow.Index)
                    dsIngreso.Tables("detalle").Rows.Remove(mfila)
                    mprecio.actualizaPrecioPromedio(cod_art)
                    calculaTotal()
                End If
            End If
        Else
            rpta = MessageBox.Show("Esta Seguro de Eliminar el ITEM Seleccionado:?" & Chr(13) &
                    UCase(nom_art) & "  " & cantidad & " " & UCase(nom_uni) & Chr(13) & "Este Proceso es Irreversible...", "SGA",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2)
            If rpta = 6 Then
                Dim mfila As DataRow = dsIngreso.Tables("detalle").Rows(dataDetalle.CurrentRow.Index)
                dsIngreso.Tables("detalle").Rows.Remove(mfila)
                mprecio.actualizaPrecioPromedio(cod_art)
                calculaTotal()
            End If
        End If
    End Sub
    Sub mueveIngreso(ByVal ingreso As Integer, ByVal cod_art As String, ByVal cantidad As Decimal,
                    ByVal cod_alma As String, ByVal operacion As Integer)
        Dim I As Integer = 0, X As Integer = 0
        Dim dsIngresos, dsSalidas As New DataSet
        Dim com As New MySqlCommand
        Dim mCatalogo As New Catalogo, mSalida As New Salida
        Dim nsCant, nsPrecio, nsIGV, nsAux, nsAux2, niStock As Decimal
        Dim nsOperacion, nsSalida, newSalida, niIngreso As Integer
        com.Connection = dbConex
        dsIngresos = mCatalogo.recLotesArticulo(True, cod_alma, cod_art, True, " fec_doc,ingreso_det.saldo desc")
        For I = 0 To dsIngresos.Tables("articulo").Rows.Count - 1
            dsSalidas.Clear()
            dsSalidas = mSalida.recLotesArticulo(ingreso, " salida.fec_doc,cant desc")
            niStock = dsIngresos.Tables("articulo").Rows(I).Item("saldo").ToString
            niIngreso = dsIngresos.Tables("articulo").Rows(I).Item("ingreso").ToString
            If niStock >= cantidad Then
                com.CommandText = "update salida_det set ingreso=" & niIngreso & " where ingreso= " & ingreso
                com.ExecuteNonQuery()
                'actualizamos el stock
                com.CommandText = "update salida_det set cant=cant+1 where ingreso= " & niIngreso
                com.ExecuteNonQuery()
                com.CommandText = "update salida_det set cant=cant-1 where ingreso= " & niIngreso
                com.ExecuteNonQuery()
                Exit For
            Else
                For X = 0 To dsSalidas.Tables("articulo").Rows.Count - 1
                    nsCant = dsSalidas.Tables("articulo").Rows(X).Item("cant").ToString
                    nsSalida = dsSalidas.Tables("articulo").Rows(X).Item("salida").ToString
                    nsOperacion = dsSalidas.Tables("articulo").Rows(X).Item("operacion").ToString
                    nsPrecio = dsSalidas.Tables("articulo").Rows(X).Item("precio").ToString
                    nsAux = dsSalidas.Tables("articulo").Rows(X).Item("nAux").ToString
                    nsAux2 = dsSalidas.Tables("articulo").Rows(X).Item("nAux2").ToString
                    If niStock >= nsCant Then
                        com.CommandText = "update salida_det set ingreso=" & niIngreso & " where salida= " & nsSalida
                        com.ExecuteNonQuery()
                        'actualizamos el stock
                        com.CommandText = "update salida_det set cant=cant+1 where salida= " & nsSalida
                        com.ExecuteNonQuery()
                        com.CommandText = "update salida_det set cant=cant-1 where salida= " & nsSalida
                        com.ExecuteNonQuery()
                        niStock = niStock - nsCant
                    Else
                        com.CommandText = "update salida_det set ingreso=" & niIngreso & ",cant=" & niStock & " where salida= " & nsSalida
                        com.ExecuteNonQuery()
                        'actualizamos el stock
                        com.CommandText = "update salida_det set cant=cant+1 where salida= " & nsSalida
                        com.ExecuteNonQuery()
                        com.CommandText = "update salida_det set cant=cant-1 where salida= " & nsSalida
                        com.ExecuteNonQuery()
                        newSalida = mSalida.maxSalida
                        nsCant = nsCant - niStock
                        mSalida.insertar_detAux(nsOperacion, newSalida, ingreso, cod_art, nsCant, nsCant, nsPrecio, nsIGV, 0, 0, "", nsAux, nsAux2)
                        niStock = 0
                    End If
                    If niStock = 0 Then
                        Exit For
                    End If
                Next
            End If
        Next
    End Sub
    Private Sub dataDetalle_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dataDetalle.EditingControlShowing
        'referenciamos la celda
        Dim validar As TextBox = CType(e.Control, TextBox)
        'agregamos el controlador de eventos para el evento KeyPress
        AddHandler validar.KeyPress, AddressOf validar_KeyPress
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
        Dim docConIMP As Boolean
        If cboDocumento.SelectedIndex >= 0 Then
            docConIMP = dsDocumento.Tables("documento_i").Rows(cboDocumento.SelectedIndex).Item("conIMP").ToString()
        Else
            docConIMP = False
        End If
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
        If chkAlmaTransferencia.Checked = True Then
            transferencia = validatransferencia()
        End If
        Dim tCom, Tprov As New MySqlCommand
        tCom.Connection = dbConex
        Tprov.Connection = dbConex
        If continuar Then
            Dim tipoDocumento, serDocumento, nroDocumento, serGuia, nroGuia As String, fec_ing As Date
            Dim cod_prov, cod_fpago, cod_alma, obs, nro_orden As String, nroIngreso, inc_igv As Integer, impuesto As Decimal, tm As String
            Dim actProveedor As Boolean = False
            tipoDocumento = cboDocumento.SelectedValue.ToString
            serDocumento = txtSerDocumento.Text
            nroDocumento = txtNroDocumento.Text
            nro_Orden = txtNroPedido.Text
            serGuia = txtSerGuia.Text
            nroGuia = txtNroGuia.Text
            fec_ing = mcFIngreso.SelectedDate
            cod_prov = cboProveedor.SelectedValue.ToString
            cod_fpago = cboFPago.SelectedValue.ToString
            cod_alma = cboAlmacen.SelectedValue.ToString
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
            If dsDocumento.Tables("documento_i").Rows(cboDocumento.SelectedIndex).Item("conIMP").ToString() Then
                impuesto = pIGV
            Else
                impuesto = 0
            End If
            If dsDocumento.Tables("documento_i").Rows(cboDocumento.SelectedIndex).Item("esCompra").ToString() Then
                actProveedor = True
            End If
            cReg = dataDetalle.RowCount
            Dim mIngreso As New Ingreso, mprecio As New ePrecio
            Dim mCatalogo As New Catalogo
            Dim mTransferencia As New Transferencia
            Dim nroTransferencia As String = "", tOperacionS, tOperacionI As Integer
            Dim mUnidad As New Unidad
            If tipoProceso = "A" Then 'añadir
                If cReg > 0 Then
                    Try
                        If chkAlmaTransferencia.Checked = True And transferencia Then
                            nroTransferencia = mTransferencia.transfiereProducto_c(mcFIngreso.SelectedDate, cboAlmacen.SelectedValue, "0000",
                                    cboAlmaTransferencia.SelectedValue, cboArea.SelectedValue, tm, prTC, pEmpresa, pCuentaUser, LDecimales)
                            tOperacionS = mTransferencia.devOperacionS(nroTransferencia)
                            tOperacionI = mTransferencia.devOperacionI(nroTransferencia)
                        End If
                        nroOperacion = mIngreso.maxOperacion
                        'registramos la cabecera
                        mIngreso.insertar(nroOperacion, tipoDocumento, serDocumento, nroDocumento, serGuia, nroGuia, nro_Orden,
                            fec_ing, cod_prov, cod_fpago, cod_alma, "0000", lcancelado, inc_igv, LDecimales, obs, tm, prTC, pCuentaUser, pmaquina)



                        'registramos el detalle
                        Dim cod_art As String, cant, precio, igv As Decimal, I As Integer
                        For I = 0 To cReg - 1
                            cod_art = dataDetalle("cod_art", I).Value
                            cant = dataDetalle("cantidad", I).Value
                            precio = dataDetalle("precio", I).Value
                            If dataDetalle("afecto_igv", I).Value = False Then
                                igv = 0
                            Else
                                igv = impuesto
                            End If
                            If actProveedor Then
                                Tprov.CommandText = "Update articulo set cod_prov='" & cod_prov & "' where cod_art='" & cod_art & "'"
                                Tprov.ExecuteNonQuery()
                            End If
                            nroIngreso = mIngreso.maxIngreso
                            mIngreso.insertar_det(nroOperacion, nroIngreso, cod_art, cant, precio, pCuentaUser, igv)
                            If chkAlmaTransferencia.Checked = True And transferencia Then
                                Dim tCant_uni As Decimal = mUnidad.devCantUnidad(cod_art)
                                mTransferencia.transfiereProducto_d(tOperacionS, tOperacionI, cod_art, tCant_uni,
                                                        nroOperacion, nroIngreso, cant, precio, igv, pCatalogoXalmacen,
                                                        cboAlmacen.SelectedValue, cboAlmaTransferencia.SelectedValue)
                            End If
                            If precio > 0 Then
                                'como los costos en el catalogo se almacenan sin impuesto
                                If chkIGV.Checked = True Then
                                    If dataDetalle("afecto_igv", I).Value = True Then
                                        If tm = "D" Then
                                            tCom.CommandText = "Update articulo set pre_ult=" & (precio * prTC) / (1 + pIGV) & " where cod_art='" & cod_art & "'"
                                        Else
                                            tCom.CommandText = "Update articulo set pre_ult=" & precio / (1 + pIGV) & " where cod_art='" & cod_art & "'"
                                        End If
                                    Else
                                        If tm = "D" Then
                                            tCom.CommandText = "Update articulo set pre_ult=" & precio * prTC & " where cod_art='" & cod_art & "'"
                                        Else
                                            tCom.CommandText = "Update articulo set pre_ult=" & precio & " where cod_art='" & cod_art & "'"
                                        End If
                                    End If
                                Else
                                    If tm = "D" Then
                                        tCom.CommandText = "Update articulo set pre_ult=" & precio * prTC & " where cod_art='" & cod_art & "'"
                                    Else
                                        tCom.CommandText = "Update articulo set pre_ult=" & precio & " where cod_art='" & cod_art & "'"
                                    End If
                                End If
                                tCom.ExecuteNonQuery()
                                mprecio.actualizaPrecioPromedio(cod_art, fec_ing)
                            End If
                        Next

                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try
                    tipoProceso = "E"
                Else
                    Try
                        MessageBox.Show("Falta Registrar Artículos...", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        txtBuscar.Focus()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try
                End If
                actualizaOrdenC(txtNroPedido.Text)
                lblTransferencia.Text = "Tr." + nroTransferencia
                lblIndice.Text = nroOperacion
            Else 'edicion
                Dim cod_art As String, cant, precio, igv As Decimal
                Dim cProv As String = cboProveedor.SelectedValue
                Dim I As Integer

                mIngreso.actualizaCabecera(eshistorial, periodoIngreso, nroOperacion, fec_ing, cod_prov, tipoDocumento, serDocumento, nroDocumento, serGuia, nroGuia,
                                           nroTransferencia, cod_fpago, cod_alma, lcancelado, inc_igv, LDecimales, obs, tm, pCuentaUser, pmaquina)
                For I = 0 To cReg - 1
                    cod_art = dataDetalle("cod_art", I).Value
                    cant = dataDetalle("cantidad", I).Value
                    precio = dataDetalle("precio", I).Value
                    nroIngreso = dataDetalle("ingreso", I).Value
                    If dataDetalle("afecto_igv", I).Value = False Then
                        igv = 0
                    Else
                        igv = impuesto
                    End If
                    Tprov.CommandText = "Update articulo set cod_prov='" & cProv & "' where cod_art='" & cod_art & "'"
                    Tprov.ExecuteNonQuery()
                    'como los recuperados ya se grabaron en la edicion, solo grabamos los nuevos
                    If dataDetalle("estado", I).Value = "New" Then
                        nroIngreso = mIngreso.maxIngreso
                        mIngreso.insertar_det(nroOperacion, nroIngreso, cod_art, cant, precio, pCuentaUser, igv)
                    Else
                        'la actualizacion se lleva cuando se modifica en la grilla
                        'aca solo actualizamos el impuesto

                        tCom.CommandText = "Update ingreso_det set cant=" & cant & ", igv=" & igv & " where ingreso=" & nroIngreso
                        tCom.ExecuteNonQuery()
                    End If
                    If precio > 0 Then
                        tCom.CommandText = "Update articulo set pre_ult=" & precio & " where cod_art='" & cod_art & "'"
                        tCom.ExecuteNonQuery()
                        mprecio.actualizaPrecioPromedio(cod_art, fec_ing)
                    End If


                Next

            End If

            datosParaEdicion(cod_prov, tipoDocumento, serDocumento, nroDocumento)
            cboProveedor.Focus()
            MessageBox.Show("Documento Registrado Correctamente!!...", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Sub actualizaOrdenC(ByVal nro_oc As String)
        Dim tOCom As New MySqlCommand
        tOCom.Connection = dbConex
        tOCom.CommandText = "Update orden_compra set fac=1  where nro_doc='" & nro_oc & "'"
        tOCom.ExecuteNonQuery()
    End Sub

    Function validatransferencia() As Boolean
        Dim creg, I As Integer, cod_Art, nom_art, cod_artrel, ccatalogoO, ccatalogoD As String
        Dim mAlmacen As New Almacen, mcatalogo As New Catalogo
        Dim cant As Decimal
        Dim resul As Boolean = True
        creg = dataDetalle.RowCount
        ccatalogoO = mAlmacen.devuelveAlmacenCatalogo(cboAlmacen.SelectedValue)
        ccatalogoD = mAlmacen.devuelveAlmacenCatalogo(cboAlmaTransferencia.SelectedValue)
        If ccatalogoO <> ccatalogoD Then
            For I = 0 To creg - 1
                cant = dataDetalle("cantidad", I).Value
                cod_Art = dataDetalle("cod_Art", I).Value
                nom_art = dataDetalle("nom_Art", I).Value
                cod_artrel = mAlmacen.devuelveCodigoArtRelacionado(cod_Art, ccatalogoD)
                If Len(cod_artrel) = 0 Then
                    MessageBox.Show("No es Posible transferir el Articulo: " & nom_art & ", No tiene codigo Relacionado...", "SGA",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information)
                    resul = False
                End If
            Next
        End If
        Return resul
    End Function
    Function validaGrabacion() As Boolean
        Dim valorRetorno As Boolean = False

        If cboDocumento.SelectedIndex >= 0 Then
            If Microsoft.VisualBasic.Len(txtSerDocumento.Text) > 0 Then
                If Microsoft.VisualBasic.Len(txtNroDocumento.Text) > 0 Then
                    If Microsoft.VisualBasic.Len(txtSerGuia.Text) > 0 Then
                        If Microsoft.VisualBasic.Len(txtNroGuia.Text) > 0 Then
                            If cboProveedor.SelectedIndex >= 0 Then
                                If cboFPago.SelectedIndex >= 0 Then
                                    If cboAlmacen.SelectedIndex >= 0 Then
                                        valorRetorno = True
                                        'If chkAlmaTransferencia.Checked = False Then
                                        '    If MessageBox.Show("Esta Seguro NO realizar la TRASFERECNIA AUTOMATICA ?", "Trasnferecnia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
                                        '        valorRetorno = True
                                        '    Else
                                        '        valorRetorno = False
                                        '    End If
                                        'End If
                                    Else
                                        cboAlmacen.Focus()
                                    End If
                                Else
                                    cboFPago.Focus()
                                End If
                            Else
                                cboProveedor.Focus()
                            End If
                        Else
                            txtNroGuia.Focus()
                        End If
                    Else
                        txtSerGuia.Focus()
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
        End If
    End Sub
    Private Sub cmdEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEliminar.Click
        Dim mIngreso As New Ingreso
        Dim rpta, doc, nrodoc As String
        doc = UCase(cboDocumento.Text)
        nrodoc = txtSerDocumento.Text + "-" + txtNroDocumento.Text
        rpta = MessageBox.Show("¿Esta Seguro de Eliminar la " + doc + ": " + nrodoc + "?", "SGA", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If rpta = 6 Then
            Dim I As Integer
            For I = 0 To dataDetalle.RowCount - 1
                'nroIngreso = dataDetalle("ingreso", I).Value
                eliminaITEM()
                'yaSalio = mIngreso.existeSalida(nroIngreso, False)
                'If yaSalio Then
                '    eliminaTodo = False
                'Else
                '    mIngreso.eliminaDetalle(nroIngreso)
                'End If
            Next
            If dataDetalle.RowCount = 0 Then
                pDatosAdt = doc + nrodoc + "," + txtRUC.Text + "," + mcFIngreso.SelectedDate.ToString + "," + pCuentaUser
                mIngreso.eliminaCabecera(nroOperacion, pDatosAdt)
            Else
                MessageBox.Show("NO se Eliminaron todos los ITEMs," + Chr(13) + "Algunos ya Tienen Salidas...", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
            reiniciaControles(True, True)
            reiniciaDatos()
            modoDeshabilitado()
            cboProveedor.Focus()
        End If
    End Sub
    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        Dim periodo As String = periodoIngreso
        Dim esHistorial As Boolean = IIf(periodo = periodoActivo(), False, True)
        Dim mIngreso As New Ingreso
        Dim frm As New rptForm
        Dim ds As New DataSet

        ds = mIngreso.recuperaDocumentoIngreso(esHistorial, periodo, cboDocumento.SelectedValue, txtSerDocumento.Text, txtNroDocumento.Text, nroOperacion)

        frm.cargarDocumentoIngreso(ds)
        frm.MdiParent = principal
        frm.Show()
    End Sub
    Sub reiniciaControles(ByVal incluirNroIngreso As Boolean, ByVal incluirCabecera As Boolean)
        'establecemos las fechas de proceso
        'estableceFechaProceso()
        If incluirNroIngreso Then
            cboDocumento.SelectedIndex = -1
            cboDocumento.SelectedIndex = -1
            cboDocumento.Refresh()
            txtSerDocumento.Text = ""
            txtNroDocumento.Text = ""
            txtSerGuia.Text = ""
            txtNroGuia.Text = ""
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
        chkAlmaTransferencia.Enabled = True
        cboAlmaTransferencia.Enabled = False
        chkAlmaTransferencia.Checked = True
        chkAlmaTransferencia.Checked = False
        cboAlmaTransferencia.SelectedIndex = -1
        lblTransferencia.Text = "Tr."
        lblIndice.Text = "0"
        txtObs.Text = ""
        txtBuscar.Text = ""
        lblItems.Text = "Nro de Items. 0"
        txtTotal.Text = "0.00"
        txtSubTotal.Text = "0.00"
        txtIGV.Text = "0.00"
        muestraTCActual()
    End Sub
    Sub reiniciaDatos()
        txtNroPedido.Text = ""
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
        cboDocumento.Enabled = False
        cboAlmacen.Enabled = False
        cboFPago.Enabled = False
        txtSerDocumento.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        txtSerDocumento.ReadOnly = True
        txtNroDocumento.ReadOnly = True
        txtSerGuia.ReadOnly = True
        txtNroGuia.ReadOnly = True
        txtObs.ReadOnly = True
        txtBuscar.ReadOnly = True
        txtSerDocumento.FocusHighlightEnabled = False
        txtNroDocumento.FocusHighlightEnabled = False
        txtSerGuia.FocusHighlightEnabled = False
        txtNroGuia.FocusHighlightEnabled = False
        txtObs.FocusHighlightEnabled = False
        txtBuscar.FocusHighlightEnabled = False
        mcFIngreso.Enabled = False
    End Sub
    Sub deshabilitaCabecera_oc()
        cboProveedor.Enabled = False
        cboDocumento.Enabled = True
        cboAlmacen.Enabled = False
        cboFPago.Enabled = False
        txtSerDocumento.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        txtSerDocumento.ReadOnly = False
        txtNroDocumento.ReadOnly = False
        txtSerGuia.ReadOnly = False
        txtNroGuia.ReadOnly = False
        txtObs.ReadOnly = False
        txtBuscar.ReadOnly = True
        txtSerDocumento.FocusHighlightEnabled = False
        txtNroDocumento.FocusHighlightEnabled = False
        txtSerGuia.FocusHighlightEnabled = False
        txtNroGuia.FocusHighlightEnabled = False
        txtObs.FocusHighlightEnabled = False
        txtBuscar.FocusHighlightEnabled = False
        mcFIngreso.Enabled = True
    End Sub
    Sub habilitaCabecera()
        cboProveedor.Enabled = True
        cboDocumento.Enabled = True
        cboAlmacen.Enabled = True
        cboFPago.Enabled = True
        txtSerDocumento.ReadOnly = False
        txtNroDocumento.ReadOnly = False
        txtSerGuia.ReadOnly = False
        txtNroGuia.ReadOnly = False
        txtObs.ReadOnly = False
        txtBuscar.ReadOnly = False
        txtSerDocumento.FocusHighlightEnabled = True
        txtNroDocumento.FocusHighlightEnabled = True
        txtSerGuia.FocusHighlightEnabled = True
        txtNroGuia.FocusHighlightEnabled = True
        txtObs.FocusHighlightEnabled = True
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
        'If pNivelUser = 0 Then
        '    mcFIngreso.MaxDate = pFechaActivaMax
        '    If pFechaActivaMin > Microsoft.VisualBasic.DateAndTime.DateAdd(DateInterval.Day, -pDiasModificarIngreso, pFechaSystem) Then
        '        mcFIngreso.MinDate = Microsoft.VisualBasic.DateAndTime.DateAdd(DateInterval.Day, -pDiasModificarIngreso, pFechaSystem)
        '    Else
        '        mcFIngreso.MinDate = pFechaActivaMin
        '    End If
        'Else
        '    mcFIngreso.MinDate = Microsoft.VisualBasic.DateAndTime.DateAdd(DateInterval.Day, -pDiasModificarIngreso, pFechaSystem)
        '    mcFIngreso.MaxDate = pFechaActivaMax
        'End If
        'If Month(pFechaActivaMax) = Month(pFechaSystem) Then
        '    mcFIngreso.DisplayMonth = pFechaSystem
        '    mcFIngreso.SelectedDate = pFechaSystem
        'Else
        '    mcFIngreso.DisplayMonth = pFechaActivaMax
        '    mcFIngreso.SelectedDate = pFechaActivaMax
        'End If
        mcFIngreso.MinDate = Microsoft.VisualBasic.DateAndTime.DateAdd(DateInterval.Day, -pDiasModificarIngreso, pFechaSystem)
        mcFIngreso.MaxDate = pFechaSystem
        mcFIngreso.DisplayMonth = pFechaSystem
        mcFIngreso.SelectedDate = pFechaSystem

    End Sub
    Function esPeriodoActivo() As Boolean
        Dim fSeleccionada As Date
        fSeleccionada = mcFIngreso.SelectedDate
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

    Private Sub mcFIngreso_DateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles mcFIngreso.DateChanged
        Dim mTcambio As New TipoCambio
        prTC = mTcambio.recupera(mcFIngreso.SelectedDate)
        muestraTCActual()
    End Sub

    Private Sub mcFIngreso_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles mcFIngreso.GotFocus
        dataArticulo.Visible = False
    End Sub

    Private Sub cmdHistorial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdHistorial.Click
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
    Private Sub chkAlmaTransferencia_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAlmaTransferencia.CheckedChanged
        If chkAlmaTransferencia.Checked = True Then
            cboAlmaTransferencia.Enabled = True
            cboAlmaTransferencia.SelectedIndex = 0
        Else
            cboAlmaTransferencia.SelectedIndex = -1
            cboAlmaTransferencia.Enabled = False
        End If
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MessageBox.Show(esPeriodoActivo)
    End Sub


    Private Sub cboProveedor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboProveedor.SelectedIndexChanged
        cboDocumento.Focus()
    End Sub


    Private Sub txtNroPedido_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNroPedido.GotFocus
        general.ingresaTextoProceso(txtNroPedido)
    End Sub

    Private Sub txtNroPedido_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNroPedido.KeyDown
        If e.KeyCode = Keys.Enter Then
            BuscarOrden()
            cboProveedor.Focus()
        End If
    End Sub

    Private Sub txtNroPedido_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNroPedido.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not (e.KeyChar = ChrW(Keys.Back)) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtNroPedido_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNroPedido.LostFocus
        If Microsoft.VisualBasic.Len(txtNroPedido.Text) > 0 Then
            txtNroPedido.Text = Microsoft.VisualBasic.Right("00000000" & txtNroPedido.Text, 8)
        End If
        general.saleTextoProceso(txtNroPedido)
    End Sub

    Private Sub txtSerPedido_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        general.ingresaTextoProceso(txtSerPedido)
    End Sub

    Private Sub txtSerPedido_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            txtNroPedido.Focus()
        End If
    End Sub

    Private Sub txtSerPedido_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Not Char.IsNumber(e.KeyChar) And Not (e.KeyChar = ChrW(Keys.Back)) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtSerPedido_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        If Microsoft.VisualBasic.Len(txtSerPedido.Text) > 0 Then
            txtSerPedido.Text = Microsoft.VisualBasic.Right("" & txtSerPedido.Text, 6)
        End If
        general.saleTextoProceso(txtSerPedido)
    End Sub
    Sub BuscarOrden()
        Dim lserie, lnumero As String, mpedido As New pedido, msalida As New Salida
        Dim esatendido As Boolean
        If Microsoft.VisualBasic.Len(txtSerPedido.Text) > 0 And Microsoft.VisualBasic.Len(txtNroPedido.Text) > 0 Then
            'limpiamos la tabla detalle
            dtDetalle.Clear()
            lserie = Microsoft.VisualBasic.Right("" & txtSerPedido.Text, 6)
            lnumero = Microsoft.VisualBasic.Right("00000000" & txtNroPedido.Text, 8)
            'verificamos la existencia del pedido y que no tenga facturas anuladas
            nroOperacionPedido = mpedido.existe_oc(lserie, lnumero)
            esatendido = mpedido.facturado_oc(nroOperacionPedido)
            If nroOperacionPedido > 0 Then 'como existe el pedido

                If mpedido.facturado_oc(nroOperacionPedido) Then
                    MessageBox.Show("ORDEM DE COMPRA CERRADA...", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    dataDetalle.Columns("cantidad").ReadOnly = True
                    modoDeshabilitado()
                    cmdImprimir.Enabled = True
                    cmdCancelar.Enabled = True
                Else
                    dataDetalle.Columns("cantidad").ReadOnly = False
                End If
                cboProveedor.Focus()

                tipoProceso = "A"
                modoEdicion()
                deshabilitaCabecera_oc()
                'cargamos los datos desde el pedido
                cargaCabecera_oc(nroOperacionPedido)
                cargaDetalle_oc(nroOperacionPedido)
                cboDocumento.Focus()
                dataDetalle.ClearSelection()
            Else

                reiniciaControles(False, True)
                reiniciaDatos()
                tipoProceso = "A"
                modoDeshabilitado()
                txtSerPedido.Focus()
            End If
        End If
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
    Sub cargaCabecera(ByVal nro_ope As Integer)
        Dim msalida As New Salida
        Dim dt As New DataTable
        dt = msalida.recuperaCabecera(nro_ope, True, False)
        mcFIngreso.SelectedDate = dt.Rows(0).Item("fec_doc")
        txtSerPedido.Text = dt.Rows(0).Item("ser_ped").ToString
        txtNroPedido.Text = dt.Rows(0).Item("nro_ped").ToString
        cboProveedor.SelectedValue = dt.Rows(0).Item("cod_clie").ToString
        txtRUC.Text = dt.Rows(0).Item("cod_clie").ToString
        cboFPago.SelectedValue = dt.Rows(0).Item("cod_fpago").ToString
        cboDocumento.SelectedValue = dt.Rows(0).Item("cod_doc").ToString
        'lblVendedor.Text = dt.Rows(0).Item("nom_vend").ToString
        txtSerDocumento.Text = dt.Rows(0).Item("ser_doc").ToString
        txtNroDocumento.Text = dt.Rows(0).Item("nro_doc").ToString
        If dt.Rows(0).Item("pre_inc_igv") = True Then
            chkIGV.CheckState = CheckState.Checked
        Else
            chkIGV.CheckState = CheckState.Unchecked
        End If
    End Sub

    Sub cargaDetalle(ByVal nro_ope As Integer, ByVal facturaAnulada As Boolean)
        Dim msalida As New Salida, I As Integer
        Dim dt As New DataTable
        If facturaAnulada Then
            dt = msalida.recuperaDetalle_anul(nro_ope, LDecimales)
        Else
            dt = msalida.recuperaDetalle_oc(nro_ope, LDecimales, False)
        End If
        For I = 0 To dt.Rows.Count - 1
            dtDetalle.ImportRow(dt.Rows(I))
        Next
        dataDetalle.DataSource = dsIngreso.Tables("detalle")
        calculaTotal()
        dataDetalle.Refresh()
    End Sub
    Sub cargaCabecera_oc(ByVal nroOperacion As Integer)
        Dim mIngreso As New Ingreso
        Dim dt As New DataTable
        Dim esHistorial As Boolean = False
        dt = mIngreso.recuperaCabecera_oc(esHistorial, periodoIngreso, nroOperacion)
        'mostramos los valores recuperados
        lblIndice.Text = nroOperacion
        mcFIngreso.SelectedDate = dt.Rows(0).Item("fec_doc")
        cboProveedor.SelectedValue = dt.Rows(0).Item("cod_prov").ToString
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
    Sub cargaDetalle_oc(ByVal nroOperacion As Integer)
        Dim mIngreso As New Ingreso, I As Integer
        Dim esHistorial As Boolean = False
        'Dim LDecimales As Integer = 4
        Dim dt As New DataTable
        dt = mIngreso.recuperaDetalle_oc1(esHistorial, periodoIngreso, nroOperacion, LDecimales)
        For I = 0 To dt.Rows.Count - 1
            dsIngreso.Tables("detalle").ImportRow(dt.Rows(I))
        Next
        dataDetalle.DataSource = dsIngreso.Tables("detalle")
        calculaTotal()
        dataDetalle.Refresh()
    End Sub



    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim buscar As String = cboProveedor.Text.Trim()
        cargarproveedor("%" & buscar & "%")
    End Sub

    Private Sub txtNroDocumento_TextChanged(sender As Object, e As EventArgs) Handles txtNroDocumento.TextChanged

    End Sub

    Private Sub txtNroPedido_TextChanged(sender As Object, e As EventArgs) Handles txtNroPedido.TextChanged

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        BuscarOrden()
    End Sub


    Private Sub cboAlmaTransferencia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAlmaTransferencia.SelectedIndexChanged
        If Not estaCargando Then

            If cboAlmaTransferencia.SelectedIndex <> -1 Then
                Dim mAlmacen As New Almacen
                muestraArea(cboAlmaTransferencia.SelectedValue)

            End If
        End If
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
                cboArea.Enabled = True
                .SelectedIndex = 0
            Else
                cboArea.Enabled = False
                .SelectedIndex = -1
            End If
        End With
    End Sub


End Class
