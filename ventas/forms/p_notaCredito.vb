Imports MySql.Data.MySqlClient
Imports libreriaClases
Public Class p_notaCredito
    Private dsIngreso As New DataSet
    Private dsDetalle As New DataSet
    Private dsProveedor As New DataSet
    Private dsCredito As New DataSet
    Private dsDocumento As New DataSet
    Private cPrecioCI As String = general.str_PrecioCompraCI
    Private chPrecioCI As String = general.str_hPrecioCompraCI
    Private cPrecioSI As String = general.str_PrecioCompraSI
    Private chPrecioSI As String = general.str_hPrecioCompraSI
    '
    Private bGrabado As Boolean = False, nOperacionS As Integer = 0
    'para validar el separador decimal
    Private sepDecimal As Char
    Private estaCargando As Boolean = True
    Private Sub p_notaCredito_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        principal.mp_notaCredito.Enabled = True
    End Sub
    Private Sub p_notaCredito_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'establecemos la fecha de proceso
        estableceFechaProceso()
        'capturamos el separador decimal
        sepDecimal = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        'dataset proveedor
        Dim daP As New MySqlDataAdapter, c0, c1, c2 As String
        c1 = "Select cod_prov,nom_prov,raz_soc,dir_prov,fono_prov,nom_cont "
        c2 = "from proveedor where activo=1 order by raz_soc"
        c0 = c1 + c2
        Dim comP As New MySqlCommand(c0, dbConex)
        daP.SelectCommand = comP
        daP.Fill(dsProveedor, "proveedor")
        With cboProveedor
            .DataSource = dsProveedor.Tables("proveedor")
            .DisplayMember = dsProveedor.Tables("proveedor").Columns("raz_soc").ToString
            .ValueMember = dsProveedor.Tables("proveedor").Columns("cod_prov").ToString
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.ListItems
            .SelectedIndex = -1
        End With
        'dataset documento ingreso
        Dim daDocumento As New MySqlDataAdapter
        Dim comDoc As New MySqlCommand("select cod_doc,nom_doc from documento_i where activo=1 and (esCompra)", dbConex)
        daDocumento.SelectCommand = comDoc
        daDocumento.Fill(dsDocumento, "documento_i")
        With cboDocumento
            .DataSource = dsDocumento.Tables("documento_i")
            .DisplayMember = dsDocumento.Tables("documento_i").Columns("nom_doc").ToString
            .ValueMember = dsDocumento.Tables("documento_i").Columns("cod_doc").ToString
            .SelectedIndex = -1
        End With
        dsCredito = Salida.dsSalida
        With dataCredito
            .DataSource = dsCredito.Tables("detalle")
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_art").HeaderText = "Código"
            .Columns("cod_art").Width = 50
            .Columns("cod_art").ReadOnly = True
            .Columns("cod_art").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("nom_art").HeaderText = "Descripción"
            .Columns("nom_art").Width = 210
            .Columns("nom_art").ReadOnly = True
            .Columns("nom_uni").HeaderText = "Unidad"
            .Columns("nom_uni").Width = 65
            .Columns("nom_uni").ReadOnly = True
            .Columns("nom_uni").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cantidad").HeaderText = "Cant."
            .Columns("cantidad").Width = 50
            .Columns("cantidad").ReadOnly = False
            .Columns("cantidad").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("igv").Visible = False
            .Columns("precio").Visible = False
            .Columns("afecto_igv").Visible = False
            .Columns("neto").Visible = False
            .Columns("operacion").Visible = False
            .Columns("ingreso").Visible = False
            .Columns("salida").Visible = False
            .Columns("orden").Visible = False
            .Columns("saldo").Visible = False
            .Columns("comi_v").Visible = False
            .Columns("comi_jv").Visible = False
            .Columns("estado").Visible = False
        End With
        estaCargando = False
    End Sub
    Sub estableceFechaProceso()
        'If pNivelUser = 0 Then
        '    mcCredito.MaxDate = pFechaActivaMax
        '    mcCredito.MinDate = pFechaActivaMin
        'Else
        '    mcCredito.MinDate = Microsoft.VisualBasic.DateAndTime.DateAdd(DateInterval.Day, -pDiasModificarIngreso, pFechaSystem)
        '    mcCredito.MaxDate = pFechaActivaMax
        'End If
        'If Month(pFechaActivaMax) = Month(pFechaSystem) Then
        '    mcCredito.DisplayMonth = pFechaSystem
        '    mcCredito.SelectedDate = pFechaSystem
        'Else
        '    mcCredito.DisplayMonth = pFechaActivaMax
        '    mcCredito.SelectedDate = pFechaActivaMax
        'End If
        mcCredito.MinDate = pFechaActivaMin
        mcCredito.MaxDate = pFechaSystem
        mcCredito.DisplayMonth = pFechaSystem
        mcCredito.SelectedDate = pFechaSystem
    End Sub
    Private Sub cboProveedor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboProveedor.KeyDown
        If e.KeyCode = Keys.Enter Then
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
                txtSerCredito.Focus()
            End If
        Catch err As Exception
            MessageBox.Show("Seleccione un Proveedor Registrado...", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cboProveedor.SelectedIndex = -1
            e.Cancel = True
        End Try
    End Sub
    Private Sub txtSerCredito_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSerCredito.LostFocus
        If Microsoft.VisualBasic.Len(txtSerCredito.Text) > 0 Then
            txtSerCredito.Text = Microsoft.VisualBasic.Right("000" & txtSerCredito.Text, 3)
        End If
    End Sub
    Private Sub txtSerCredito_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtSerCredito.Validating
        If txtSerCredito.ReadOnly = False Then
            nOperacionS = existeNC()
            recuperaNC()
        End If
    End Sub
    Private Sub txtNroCredito_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNroCredito.KeyPress
        If e.KeyChar = Chr(13) Then
            cboDocumento.Focus()
        End If
    End Sub
    Private Sub txtNroCredito_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNroCredito.LostFocus
        If Microsoft.VisualBasic.Len(txtNroCredito.Text) > 0 Then
            txtNroCredito.Text = Microsoft.VisualBasic.Right("00000000" & txtNroCredito.Text, 8)
        End If
    End Sub
    Private Sub txtNroCredito_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNroCredito.Validating
        If txtNroCredito.ReadOnly = False Then
            nOperacionS = existeNC()
            recuperaNC()
        End If
    End Sub
    Private Sub txtSerDocumento_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSerDocumento.GotFocus
        txtSerDocumento.SelectAll()
    End Sub
    Private Sub txtSerDocumento_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSerDocumento.KeyPress
        'If Not Char.IsNumber(e.KeyChar) And Not (e.KeyChar = ChrW(Keys.Back)) Then
        '    e.KeyChar = ""
        'End If
    End Sub
    Private Sub txtSerDocumento_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSerDocumento.LostFocus
        'If Microsoft.VisualBasic.Len(txtSerDocumento.Text) > 0 Then
        '    txtSerDocumento.Text = Microsoft.VisualBasic.Right("000000" & txtSerDocumento.Text, 6)
        'End If
    End Sub
    Private Sub txtNroDocumento_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNroDocumento.GotFocus
        txtNroDocumento.SelectAll()
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
    Sub muestraDocumento()
        Dim mIngreso As New Ingreso
        Dim cTipo As String = cboDocumento.SelectedValue
        'Dim cSerie As String = Microsoft.VisualBasic.Right("0000" & txtSerDocumento.Text, 4)
        Dim cSerie As String = txtSerDocumento.Text
        Dim cNumero As String = Microsoft.VisualBasic.Right("00000000" & txtNroDocumento.Text, 8)
        Dim cProveedor As String = cboProveedor.SelectedValue
        Dim nroOperacion As Integer = mIngreso.existe(cTipo, cSerie, cNumero, cProveedor)
        If nroOperacion > 0 Then
            dsIngreso.Clear()
            dsIngreso = mIngreso.recuperaCabecera_ds(False, "", nroOperacion)
            dsDetalle = mIngreso.recuperaDetalle_ds(False, "", nroOperacion, pDecimales)
            dataDetalle.DataSource = dsDetalle.Tables("detalle").DefaultView
            estructuraDetalle()
            dataDetalle.Focus()
        Else
            MessageBox.Show("Documento NO Existe...", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txtNroDocumento.Focus()
            dsDetalle.Clear()
        End If
    End Sub
    Sub estructuraDetalle()
        With dataDetalle
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_art").HeaderText = "Código"
            .Columns("cod_art").Width = 50
            .Columns("cod_art").ReadOnly = True
            .Columns("cod_art").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("nom_art").HeaderText = "Descripción"
            .Columns("nom_art").Width = 220
            .Columns("nom_art").ReadOnly = True
            .Columns("nom_uni").HeaderText = "Unidad"
            .Columns("nom_uni").Width = 65
            .Columns("nom_uni").ReadOnly = True
            .Columns("nom_uni").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cantidad").HeaderText = "Cant."
            .Columns("cantidad").Width = 55
            .Columns("cantidad").ReadOnly = False
            .Columns("cantidad").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("precio").HeaderText = "Precio"
            .Columns("precio").Width = 65
            .Columns("precio").ReadOnly = False
            .Columns("precio").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("precio").DefaultCellStyle.Format = "###,###.##"
            .Columns("neto").Visible = False
            .Columns("pre_ult").Visible = False
            .Columns("saldo").Visible = False
            .Columns("igv").Visible = False
            .Columns("afecto_igv").Visible = False
            .Columns("operacion").Visible = False
            .Columns("ingreso").Visible = False
            .Columns("estado").Visible = False
        End With
    End Sub
    Private Sub cmdBuscar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
        muestraDocumento()
    End Sub
    Private Sub dataDetalle_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dataDetalle.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Dim continua As Boolean = validaRegistroNC()
            If continua Then
                txtCant_credito.Focus()
            End If
        End If
    End Sub
    Private Sub dataDetalle_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dataDetalle.SelectionChanged
        If dataDetalle.RowCount >= 0 Then
            txtCant_credito.Text = ""
        End If
    End Sub
    Function validaRegistroNC() As Boolean
        Dim continua As Boolean = False
        If cboProveedor.SelectedIndex <> -1 Then
            If Len(txtSerCredito.Text) > 0 Then
                If Len(txtNroCredito.Text) > 0 Then
                    If cboDocumento.SelectedIndex <> -1 Then
                        If Len(txtSerDocumento.Text) > 0 Then
                            If Len(txtNroDocumento.Text) > 0 Then
                                continua = True
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
                    txtNroCredito.Focus()
                End If
            Else
                txtSerCredito.Focus()
            End If
        Else
            cboProveedor.Focus()
        End If
        Return continua
    End Function
    Private Sub cmdNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click
        habilitaCabecera()
        txtSerCredito.Text = ""
        txtNroCredito.Text = ""
        txtSerDocumento.Text = ""
        txtNroDocumento.Text = ""
        cboDocumento.SelectedIndex = -1
        cboProveedor.SelectedIndex = -1
        txtRUC.Text = ""
        dataDetalle.DataSource = ""
        dataDetalle.Refresh()
        dsDetalle.Clear()
        dsCredito.Clear()
        dataCredito.Refresh()
        bGrabado = False
        nOperacionS = 0
        cboProveedor.Focus()
    End Sub
    Private Sub txtCant_credito_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCant_credito.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not (e.KeyChar = ChrW(Keys.Back)) And Not (e.KeyChar.Equals(sepDecimal)) Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub cmdInsertar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdInsertar.Click
        If cboProveedor.SelectedIndex <> -1 Then
            If dsDetalle.Tables("detalle").Rows.Count > 0 Then
                If Len(txtCant_credito.Text) > 0 Then
                    Dim nCantidad As Decimal = txtCant_credito.Text
                    If nCantidad > 0 Then
                      
                        If nCantidad > dataDetalle.Item("cantidad", dataDetalle.CurrentRow.Index).Value Then
                            MessageBox.Show("La Cantidad NO Puede ser mayor a la que muestra la " _
                                        & cboDocumento.Text, "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            txtCant_credito.Focus()
                        Else
                            'antes de grabar verificamos el stock
                            Dim mIngreso As New Ingreso
                            Dim nIngreso As Integer = dataDetalle.Item("ingreso", dataDetalle.CurrentRow.Index).Value
                            Dim codigo As String = dataDetalle.Item("cod_Art", dataDetalle.CurrentRow.Index).Value
                            Dim nStock As Decimal = mIngreso.devuelveSaldoArticulo(codigo)
                            If nCantidad <= nStock Then
                                grabaNC()
                                dataDetalle.Focus()
                            Else
                                MessageBox.Show("Stock NO Disponible..." & Chr(13) & " Se dispone de... " & nStock, "SGA", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                                txtCant_credito.Focus()
                            End If
                        End If
                    Else
                        txtCant_credito.Focus()
                    End If
                Else
                    txtCant_credito.Focus()
                End If
            Else
                cboDocumento.Focus()
            End If
        Else
            cboProveedor.Focus()
        End If
    End Sub
    Function existeNC() As Integer
        Dim mSalida As New Salida, exist As Integer
        Dim cSerie As String = Microsoft.VisualBasic.Right("000" & txtSerCredito.Text, 3)
        Dim cNumero As String = Microsoft.VisualBasic.Right("00000000" & txtNroCredito.Text, 8)
        exist = mSalida.existeNC(cboProveedor.SelectedValue, "05", cSerie, cNumero)
        Return exist
    End Function
    Sub recuperaNC()
        If nOperacionS > 0 Then
            Dim rpta As Integer = MessageBox.Show("La Nota de Crédito ya Existe" & Chr(13) & "Desea Mostrarlo...?", "SGA", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If rpta = 6 Then
                Dim mSalida As New Salida
                dsCredito = mSalida.recuperaDetalle_ds(nOperacionS, pDecimales)
                dataCredito.DataSource = dsCredito.Tables("detalle").DefaultView
                Dim operacionI As Integer = mSalida.devuelve_operacionINC(nOperacionS)
                Dim mIngreso As New Ingreso
                dsIngreso.Clear()
                dsIngreso = mIngreso.recuperaCabecera_ds(False, "", operacionI)
                txtRUC.Text = dsIngreso.Tables("cabecera").Rows(0).Item("cod_prov")
                cboProveedor.SelectedValue = dsIngreso.Tables("cabecera").Rows(0).Item("cod_prov")
                cboDocumento.SelectedValue = dsIngreso.Tables("cabecera").Rows(0).Item("cod_doc")
                txtSerDocumento.Text = dsIngreso.Tables("cabecera").Rows(0).Item("ser_doc")
                txtNroDocumento.Text = dsIngreso.Tables("cabecera").Rows(0).Item("nro_doc")
                bGrabado = True
                deshabilitaCabecera()
            Else
                txtSerCredito.Text = ""
                txtNroCredito.Text = ""
                nOperacionS = 0
                bGrabado = False
                habilitaCabecera()
                txtSerCredito.Focus()
            End If
        Else
            nOperacionS = 0
            bGrabado = False
            habilitaCabecera()
        End If
    End Sub
    Sub grabaNC()
        Dim mCliente As New Cliente
        If Not bGrabado Then
            If Not mCliente.existe(cboProveedor.SelectedValue) Then
                mCliente.insertarAUX(cboProveedor.SelectedValue, cboProveedor.Text, cboProveedor.Text, "00", 0)
            End If
            insertaCabecera()
            bGrabado = True
        End If
        insertaProducto()
        deshabilitaCabecera()
    End Sub
    Sub insertaCabecera()
        Dim nc As String = "05"
        Dim mSalida As New Salida, mIngreso As New Ingreso
        nOperacionS = mSalida.maxOperacion
        Dim nIngreso As Integer = dataDetalle.Item("ingreso", dataDetalle.CurrentRow.Index).Value
        Dim nOperacion As Integer = dsIngreso.Tables("cabecera").Rows(0).Item("operacion").ToString
        Dim nPrecio_incImp As Boolean = dsIngreso.Tables("cabecera").Rows(0).Item("pre_inc_igv").ToString
        Dim cAlmacen As String = dsIngreso.Tables("cabecera").Rows(0).Item("cod_alma").ToString
        Dim fPago As String = dsIngreso.Tables("cabecera").Rows(0).Item("cod_fpago").ToString
        mSalida.insertar_aux(nOperacionS, 0, "05", txtSerCredito.Text, txtNroCredito.Text, mcCredito.SelectedDate, mcCredito.SelectedDate,
                        "00000000", cboProveedor.SelectedValue, fPago, 1, nPrecio_incImp, pDecimales,
                        cAlmacen, "0000", "Nota de Credito", "00", pCuentaUser, pCuentaUser, nOperacion, "-", "-")
    End Sub
    Sub insertaproducto()
        If dataDetalle.RowCount >= 0 Then
            Dim mSalida As New Salida
            Dim nSalida As Integer = mSalida.maxSalida
            Dim cod_art As String = dataDetalle.Item("cod_art", dataDetalle.CurrentRow.Index).Value
            Dim nCant As Decimal = txtCant_credito.Text
            Dim nPrecio As Decimal = dataDetalle.Item("precio", dataDetalle.CurrentRow.Index).Value
            Dim nIngreso As Integer = dataDetalle.Item("ingreso", dataDetalle.CurrentRow.Index).Value
            Dim nImp As Decimal = dataDetalle.Item("igv", dataDetalle.CurrentRow.Index).Value
            mSalida.insertar_detAux(nOperacionS, nSalida, nIngreso, cod_art, nCant, nCant, nPrecio, nImp, 0, 0, "", 0, 0)
            Dim fila As DataRow = dsCredito.Tables("detalle").NewRow
            fila.Item("cod_art") = dataDetalle.Item("cod_art", dataDetalle.CurrentRow.Index).Value
            fila.Item("nom_art") = dataDetalle.Item("nom_art", dataDetalle.CurrentRow.Index).Value
            fila.Item("nom_uni") = dataDetalle.Item("nom_uni", dataDetalle.CurrentRow.Index).Value
            fila.Item("precio") = dataDetalle.Item("precio", dataDetalle.CurrentRow.Index).Value
            'en la columna ingreso se almacena el nro de salida de la operacion
            fila.Item("ingreso") = nSalida
            fila.Item("operacion") = nOperacionS
            fila.Item("cantidad") = txtCant_credito.Text
            dsCredito.Tables("detalle").Rows.Add(fila)
            dataCredito.CurrentCell = dataCredito("cantidad", dataCredito.RowCount - 1)
        End If
    End Sub
    Sub deshabilitaCabecera()
        cboProveedor.Enabled = False
        cboDocumento.Enabled = False
        txtSerDocumento.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        txtNroDocumento.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        txtSerDocumento.FocusHighlightEnabled = False
        txtNroDocumento.FocusHighlightEnabled = False
        txtSerDocumento.ReadOnly = True
        txtNroDocumento.ReadOnly = True
        '
        txtSerCredito.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        txtNroCredito.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        txtSerCredito.FocusHighlightEnabled = False
        txtNroCredito.FocusHighlightEnabled = False
        txtSerCredito.ReadOnly = True
        txtNroCredito.ReadOnly = True
    End Sub
    Sub habilitaCabecera()
        cboProveedor.Enabled = True
        cboDocumento.Enabled = True
        txtSerDocumento.BackColor = Color.White
        txtNroDocumento.BackColor = Color.White
        txtSerDocumento.FocusHighlightEnabled = True
        txtNroDocumento.FocusHighlightEnabled = True
        txtSerDocumento.ReadOnly = False
        txtNroDocumento.ReadOnly = False
        '
        txtSerCredito.BackColor = Color.White
        txtNroCredito.BackColor = Color.White
        txtSerCredito.FocusHighlightEnabled = True
        txtNroCredito.FocusHighlightEnabled = True
        txtSerCredito.ReadOnly = False
        txtNroCredito.ReadOnly = False
    End Sub

    Private Sub txtNroCredito_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNroCredito.TextChanged

    End Sub

    Private Sub txtSerDocumento_TextChanged(sender As Object, e As EventArgs) Handles txtSerDocumento.TextChanged

    End Sub

    Private Sub dataDetalle_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataDetalle.CellContentClick

    End Sub
End Class
