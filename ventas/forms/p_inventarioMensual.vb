Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Math
Imports libreriaClases
Public Class p_inventarioMensual
    Private dsAlmacen As New DataSet
    Private dsAlma As New DataSet
    Private dsArea As New DataSet
    Private dsGrupo As New DataSet
    Private dsInventario As New DataSet
    Private dsInventarioR As New DataSet
    Private dsReportes As New DataSet
    Private dsInventarioI As New DataSet
    Private dsArticulos As New DataSet
    Private dsCatalogo As New DataSet
    Private dsAlmacenF As New DataSet
    Private dsAreaF As New DataSet
    '
    Private cPrecioCI As String = general.str_PrecioCompraCI
    Private chPrecioCI As String = general.str_hPrecioCompraCI
    Private cPrecioSI As String = general.str_PrecioCompraSI
    Private chPrecioSI As String = general.str_hPrecioCompraSI
    Private cPrecioCIs As String = general.str_PrecioCompraCIs
    Private chPrecioCIs As String = general.str_hPrecioCompraCIs
    Private cPrecioSIs As String = general.str_PrecioCompraSIs
    Private chPrecioSIs As String = general.str_hPrecioCompraSIs
    'para validar el separador decimal
    Private sepDecimal As Char
    Private estaCargando As Boolean = True
    Private periodoInventario As String, nOperacion As Integer
    Private fechaInventario As Date
    Private saldoProvisional As Boolean
    'para capturar el numero de almacenes
    'Private mAlmacen(100) As String
    Private nroAlmacenes As Integer
    Private Sub p_inventarioMensual_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        principal.mp_invMensual.Enabled = True
    End Sub
    Private Sub p_inventarioMensual_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim I As Integer
        'capturamos el separador decimal
        sepDecimal = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        'verificamos si ya existe datos cargados para el periodo actual
        'en funcion a ello determinamos la fecha de proceso para el inventario
        Dim mes, mesA, anno, annoA As Integer
        If Month(pFechaActivaMax) = 1 Then
            mes = 12
            mesA = 0
            anno = Year(pFechaActivaMax) - 1
            annoA = Year(pFechaActivaMax)
        Else
            mes = Month(pFechaActivaMax)
            mesA = Month(pFechaActivaMax)
            anno = Year(pFechaActivaMax)
            annoA = Year(pFechaActivaMax)
        End If
        'Dim mes As Integer = cboMesA.SelectedIndex
        'Dim anno As Integer = CboAnnoA.SelectedIndex
        'If mes = 0 Then
        '    mes = 12
        '    anno = anno - 1
        'End If
        cboMes.SelectedIndex = mes - 1
        cboAnno.SelectedIndex = anno - 2010
        cboMesR.SelectedIndex = mes - 1
        cboAnnoR.SelectedIndex = anno - 2010

        Dim mIngreso As New Ingreso
        Dim cmes As String = general.devuelveMes(Val(Microsoft.VisualBasic.Right(periodoInventario, 2)))
        Dim existeDatosPeriodoActivo As Boolean = general.periodoActivo_existeDatos
        If existeDatosPeriodoActivo Then

            periodoInventario = general.periodoActivo
            fechaInventario = general.fechaActivaMax
        Else
            periodoInventario = general.periodoCerrado
            fechaInventario = general.fechaInventario(periodoInventario)

        End If
        'data para los reportes - se mantiene oculto al usuario
        dsReportes = Inventario.dsInventarioMensualReportes
        dataReportes.DataSource = dsReportes.Tables("inventario").DefaultView
        estructuraMovimientos()
        'dataset almacen para cierre
        dsAlmacen.Tables.Add("almacen")
        Dim daAlmacen As New MySqlDataAdapter
        Dim comAlmacen As New MySqlCommand("select cod_alma,nom_alma from almacen where activo=1 and (es_invMensual) order by nom_alma", dbConex)
        daAlmacen.SelectCommand = comAlmacen
        daAlmacen.Fill(dsAlmacen, "almacen")

        'almacenes y areas para los inventarios
        dsAlmacenF.Tables.Add("almacen")
        Dim daAlmacenF As New MySqlDataAdapter
        Dim comAlmacenF As New MySqlCommand("select cod_alma,nom_alma from almacen where activo=1" _
                        & " and (es_invMensual) order by nom_alma", dbConex)
        daAlmacenF.SelectCommand = comAlmacenF
        daAlmacenF.Fill(dsAlmacenF, "almacen")
        With cboAlmacenRegistro
            .DataSource = dsAlmacenF.Tables("almacen")
            .DisplayMember = dsAlmacenF.Tables("almacen").Columns("nom_alma").ToString
            .ValueMember = dsAlmacenF.Tables("almacen").Columns("cod_alma").ToString
            If dsAlmacenF.Tables("almacen").Rows.Count > 0 Then
                .SelectedIndex = 0
            End If
        End With
        With CboAlmacenRpt
            .DataSource = dsAlmacenF.Tables("almacen")
            .DisplayMember = dsAlmacenF.Tables("almacen").Columns("nom_alma").ToString
            .ValueMember = dsAlmacenF.Tables("almacen").Columns("cod_alma").ToString
            If dsAlmacenF.Tables("almacen").Rows.Count > 0 Then
                .SelectedIndex = 0
            End If
        End With


        'dataset grupo
        Dim daGrupo As New MySqlDataAdapter
        Dim cadG As String = "select cod_sgrupo,nom_sgrupo from subgrupo where activo=1" _
                    & " and not(esProduccion) order by nom_sgrupo"
        Dim comGrupo As New MySqlCommand(cadG, dbConex)
        daGrupo.SelectCommand = comGrupo
        daGrupo.Fill(dsGrupo, "grupo")
        With cboGrupo
            .DataSource = dsGrupo.Tables("grupo")
            .DisplayMember = dsGrupo.Tables("grupo").Columns("nom_sgrupo").ToString
            .ValueMember = dsGrupo.Tables("grupo").Columns("cod_sgrupo").ToString
            If dsGrupo.Tables("grupo").Rows.Count > 0 Then
                .SelectedIndex = -1
            End If
        End With
        muestraCatalogo()

        ' ''capturamos el numero de almacenes


        estableceFechaProceso()
        estableceFechas()
        muestraInventario(False)
        estaCargando = False
    End Sub
    Sub estableceFechaProceso()


        dtiFecha.ResetMinDate()
        dtiFecha.MinDate = pFechaActivaMin
        dtiFecha.ResetMaxDate()
        dtiFecha.MaxDate = pFechaSystem
        dtiFecha.Value = pFechaSystem

    End Sub

    Sub estableceFechas()
        If Not estaCargando Then
            Dim periodo As String = periodoSeleccionado()
            If periodo <> general.periodoActivo Then
                dtiDesde.ResetMinDate()
                dtiDesde.MinDate = fechaI()
                dtiDesde.ResetMaxDate()
                dtiDesde.MaxDate = fechaF()
                dtiDesde.Value = fechaI()

                dtiHasta.ResetMinDate()
                dtiHasta.MinDate = fechaI()
                dtiHasta.ResetMaxDate()
                dtiHasta.MaxDate = fechaF()
                dtiHasta.Value = fechaF()
            Else
                dtiDesde.ResetMinDate()
                dtiDesde.MinDate = pFechaActivaMin
                dtiDesde.ResetMaxDate()
                dtiDesde.MaxDate = pFechaActivaMax
                DtiDesde.Value = pFechaActivaMin

                dtiHasta.ResetMaxDate()
                dtiHasta.MinDate = pFechaActivaMin
                dtiHasta.ResetMaxDate()
                dtiHasta.MaxDate = pFechaActivaMax
                dtiHasta.Value = pFechaActivaMax
            End If
        End If
    End Sub
    Function fechaI() As Date
        Dim mfecha As Date
        mfecha = general.convierteTexto_enFecha(1, cboMes.SelectedIndex + 1, Val(cboAnno.Text))
        Return mfecha
    End Function
    Function fechaF() As Date
        Dim mFecha As Date
        If cboMes.SelectedIndex = 11 Then 'cuando es diciembre
            mFecha = Microsoft.VisualBasic.DateAndTime.DateAdd(DateInterval.Day, -1,
                    general.convierteTexto_enFecha(1, 1, Val(cboAnno.Text) + 1))
        Else
            mFecha = Microsoft.VisualBasic.DateAndTime.DateAdd(DateInterval.Day, -1,
                    general.convierteTexto_enFecha(1, cboMes.SelectedIndex + 2, Val(cboAnno.Text)))
        End If
        Return mFecha
    End Function
    Private Sub cboMes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMes.SelectedIndexChanged
        'If Not estaCargando Then
        '    muestraInventario(True)
        'End If
    End Sub
    Private Sub cboAnno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAnno.SelectedIndexChanged
        'If Not estaCargando Then
        '    muestraInventario(True)
        'End If
    End Sub
    Function periodoSeleccionado()
        Dim mes As Integer = cboMesR.SelectedIndex
        Dim anno As Integer = cboAnnoR.SelectedIndex
        If mes = 0 Then
            mes = 12
            anno = anno - 1
        End If
        Dim periodo As String = Trim(Str(anno + 2010)) & Microsoft.VisualBasic.Right("00" & Trim(Str(mes + 1)), 2)
        Return periodo
    End Function


    Private Sub cboArearegistro_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If Not estaCargando Then
        '    muestraInventario(True)
        'End If
    End Sub
    
    Function inv_esHistorial() As Boolean
        Dim mInventario As New Inventario
        Dim existe As Boolean = mInventario.mensual_esHistorial(periodoSeleccionado)
        Return False
    End Function
    Sub muestraInventario(ByVal paraEdicion As Boolean)
        Dim mInventario As New Inventario, mcatalogo As New Catalogo
        Dim es_xsaldo As Boolean = IIf(chksaldo.Checked, True, False)
        dsInventario.Clear()
        Dim esHistorial As Boolean = periodoSeleccionado() <> general.periodoActivo

        Dim cAlmacen As String = cboAlmacenRegistro.SelectedValue
        'If paraEdicion Then
        If esHistorial Then
            cmdIniciarRegistro.Enabled = False
        Else
            cmdIniciarRegistro.Enabled = True
        End If
        'dsInventario = mInventario.recInvMensual(esHistorial, periodoSeleccionado, True, cAlmacen, xArea, cArea, False)
        dsInventario = mcatalogo.recuperaSaldos(esHistorial, periodoSeleccionado, True, True, cAlmacen, False, "", False, False, "", pDecimales, es_xsaldo)
        If esHistorial Then
            cmdIniciarRegistro.Enabled = False
        Else
            'Dim es_xArea As Boolean = mInventario.mensual_esArea(esHistorial, periodoSeleccionado, pEmpresa, cAlmacen)
            'If es_xArea Then
            '    chkArea.Checked = False
            'Else
            '    chkArea.Checked = True
            'End If
        End If
        'Else
        '    dsInventario = mInventario.recuperaInvMensual(fechaInventario, True, cboAlmacen.SelectedValue)
        'End If
        dataDetalle.DataSource = dsInventario.Tables("saldo")
        estructuraInventario()
    End Sub
    Sub estructuraInventario()
        With dataDetalle
            .DataSource = dsInventario.Tables("saldo")
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_art").HeaderText = "Código"
            .Columns("cod_art").Width = 60
            .Columns("cod_art").ReadOnly = True
            .Columns("cod_art").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("nom_art").HeaderText = "Descripción"
            .Columns("nom_art").Width = 240
            .Columns("nom_art").ReadOnly = True
            .Columns("nom_uni").HeaderText = "Unidad"
            .Columns("nom_uni").Width = 65
            .Columns("nom_uni").ReadOnly = True
            '.Columns("saldo").HeaderText = "Sistema"
            '.Columns("saldo").Width = 70
            '.Columns("saldo").ReadOnly = True
            '.Columns("saldo").DefaultCellStyle.BackColor = Color.AliceBlue
            '.Columns("saldo").DefaultCellStyle.ForeColor = Color.MidnightBlue
            '.Columns("saldo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            '.Columns("cant_fis").HeaderText = "Fisico"
            .Columns("cant_fis").Width = 70
            .Columns("cant_fis").ReadOnly = False
            .Columns("cant_fis").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("precio").HeaderText = "Precio Costo"
            .Columns("precio").Width = 70
            .Columns("precio").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("precio").ReadOnly = True
            .Columns("monto").Visible = False
            .Columns("afecto_igv").Visible = False
            .Columns("nom_sgrupo").Visible = False
            .Columns("cant_uni").Visible = False
            .Columns("es_divisible").Visible = False
            .Columns("pre_ult").Visible = False
            .Columns("maximo").Visible = False
            .Columns("minimo").Visible = False
            .Columns("cod_sgrupo").Visible = False
            .Columns("cod_alma").Visible = False
            .Columns("nom_alma").Visible = False
            .Columns("tm").Visible = False
            .Columns("tc").Visible = False
            .Columns("pre_inc_igv").Visible = False
            .Columns("igv").Visible = False
            .Columns("ingreso").Visible = False
            .Columns("saldo").Visible = False
        End With
    End Sub
    Sub muestraCatalogo()
        Dim mCatalogo As New Catalogo
        Dim mAlmacen As New Almacen
        Dim cod_alma As String = mAlmacen.devuelveAlmacenCatalogo(cboAlmacenRegistro.SelectedValue)
        dsCatalogo = mCatalogo.recuperaCatalogo(pCatalogoXalmacen, cod_alma, True, False, False, False, "", False, False, False)
        With dataCatalogo
            .DataSource = dsCatalogo.Tables("articulo").DefaultView
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_art").HeaderText = "Codigo"
            .Columns("cod_art").Width = 55
            .Columns("cod_art").ReadOnly = True
            .Columns("cod_art").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("nom_art").HeaderText = "Descripción"
            .Columns("nom_art").Width = 225
            .Columns("nom_art").ReadOnly = True
            .Columns("nom_uni").HeaderText = "Unidad"
            .Columns("nom_uni").Width = 65
            .Columns("nom_uni").ReadOnly = True
            .Columns("nom_uni").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cant_uni").Visible = False
            .Columns("nom_tart").Visible = False
            .Columns("pre_costo").Visible = False
            .Columns("pre_costoMax").Visible = False
            .Columns("pre_costoMin").Visible = False
            .Columns("pre_prom").Visible = False
            .Columns("cod_uni").Visible = False
            .Columns("pre_ult").Visible = False
            .Columns("pre_venta").Visible = False
            .Columns("pre_inc_imp").Visible = False
            .Columns("imp").Visible = False
            .Columns("cod_artExt").Visible = False
            .Columns("afecto_igv").Visible = False
            .Columns("maximo").Visible = False
            .Columns("minimo").Visible = False
            .Columns("cuenta_v").Visible = False
            .Columns("cuenta_v_C").Visible = False
            .Columns("cuenta_c").Visible = False
            .Columns("cuenta_c_P").Visible = False
            .Columns("cuenta_c_a1").Visible = False
            .Columns("cuenta_c_a2").Visible = False
            .Columns("cod_sgrupo").Visible = False
            .Columns("nom_sgrupo").Visible = False
            .Columns("esProduccion").Visible = False
            .Columns("activo").Visible = False
        End With
    End Sub
    Private Sub txtBuscararticulo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscarArticulo.GotFocus
        txtBuscarArticulo.SelectAll()
    End Sub
    Private Sub txtBuscararticulo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscarArticulo.TextChanged
        general.mayusculas(txtBuscarArticulo, txtBuscarArticulo.Text)
        Dim valor As String = txtBuscarArticulo.Text
        dsCatalogo.Tables("articulo").DefaultView.RowFilter = "nom_art LIKE '" & valor & "%'"
        If dataCatalogo.RowCount > 0 Then
            dataCatalogo.CurrentCell = dataCatalogo("nom_art", dataCatalogo.CurrentRow.Index)
        End If
    End Sub
    Private Sub dataCatalogo_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dataCatalogo.DoubleClick
        'If esEditable() Then
        '    If dataDetalle.RowCount > 0 Then
        '        txtBuscar.Text = ""
        '        insertaArticulo()
        '        dataDetalle.CurrentCell = dataDetalle(dataDetalle.Columns("cant_fis").Index, dataDetalle.RowCount - 1)
        '        dataDetalle.Focus()
        '    End If
        'End If
    End Sub
    Private Sub dataCatalogo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dataCatalogo.KeyDown
        'If e.KeyCode = Keys.Enter Then
        '    e.SuppressKeyPress = True
        '    If esEditable() Then
        '        If dataDetalle.RowCount > 0 Then
        '            txtBuscar.Text = ""
        '            insertaArticulo()
        '            dataDetalle.CurrentCell = dataDetalle(dataDetalle.Columns("cant_fis").Index, dataDetalle.RowCount - 1)
        '            dataDetalle.Focus()
        '        End If
        '    End If
        'End If
    End Sub
    'Sub insertaArticulo()
    '    If esEditable() Then
    '        Dim fila As DataRow = dsInventario.Tables("saldo").NewRow
    '        Dim cod_art As String = dataCatalogo.Item("cod_art", dataCatalogo.CurrentRow.Index).Value
    '        fila.Item("cod_art") = cod_art
    '        fila.Item("nom_art") = dataCatalogo.Item("nom_art", dataCatalogo.CurrentRow.Index).Value
    '        fila.Item("nom_uni") = dataCatalogo.Item("nom_uni", dataCatalogo.CurrentRow.Index).Value
    '        Dim pre_costo As Decimal = dataCatalogo.Item("pre_costo", dataCatalogo.CurrentRow.Index).Value
    '        fila.Item("pre_costo") = pre_costo
    '        fila.Item("cant_sis") = 0
    '        fila.Item("cant_fis") = 0
    '        Dim mInventario As New Inventario
    '        Dim nInventario As Integer = mInventario.maxInventarioMensual
    '        fila.Item("saldo") = nInventario
    '        dsInventario.Tables("saldo").Rows.Add(fila)
    '        mInventario.insertar_detInvMensual(nOperacion, nInventario, cod_art, 0, pre_costo, 0, pCuentaUser)
    '    End If
    'End Sub
    Function esEditable() As Boolean
        If dataDetalle.ReadOnly = True Then
            Return False
        Else
            Return True
        End If
        Return True
    End Function

    Private Sub dataDetalle_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataDetalle.CellDoubleClick
        If esEditable() Then
            'si la columna donde hacemos doble click es distinta de la de CANT_SIS
            If dataDetalle.CurrentCell.ColumnIndex <> dataDetalle.Columns("cant_fis").Index Then
                eliminaITEM()
            End If
        End If
    End Sub
    Private Sub dataDetalle_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataDetalle.CellEndEdit
        If dataDetalle.CurrentCell.ColumnIndex = dataDetalle.Columns("cant_fis").Index Then
            Dim lcantidad As Decimal, nroInventario As Integer
            If IsDBNull(dataDetalle("cant_fis", dataDetalle.CurrentRow.Index).Value) Then
                lcantidad = 0
                dataDetalle("cant_fis", dataDetalle.CurrentRow.Index).Value = 0
            Else
                lcantidad = dataDetalle("cant_fis", dataDetalle.CurrentRow.Index).Value
            End If
            Dim mInventario As New Inventario
            nroInventario = dataDetalle("saldo", dataDetalle.CurrentRow.Index).Value
            ' mInventario.actualizaFisicoMensual(nroInventario, lcantidad)
        End If
    End Sub
    Private Sub dataDetalle_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dataDetalle.EditingControlShowing
        'referenciamos la celda
        Dim validar As TextBox = CType(e.Control, TextBox)
        'agregamos el controlador de eventos para el evento KeyPress
        AddHandler validar.KeyPress, AddressOf validar_KeyPress
    End Sub
    Private Sub datadetalle_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dataDetalle.KeyDown
        If esEditable() Then
            If e.KeyCode = Keys.Delete Then
                e.SuppressKeyPress = True
                eliminaITEM()
            End If
            If e.KeyCode = Keys.Enter Then
                dataDetalle.ClearSelection()
                txtBuscarArticulo.Focus()
            End If
        End If
    End Sub
    Private Sub validar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim columna As Integer = dataDetalle.CurrentCell.ColumnIndex
        If columna = dataDetalle.Columns("cant_fis").Index Then
            If Not Char.IsNumber(e.KeyChar) And Not (e.KeyChar = ChrW(Keys.Back)) And Not (e.KeyChar.Equals(sepDecimal)) Then
                e.KeyChar = ""
            End If
        End If
    End Sub
    Sub eliminaITEM()
        Dim rpta As Integer
        Dim mInventario As New Inventario
        If Not IsDBNull(dataDetalle("saldo", dataDetalle.CurrentRow.Index).Value) Then
            If dataDetalle("cant_sis", dataDetalle.CurrentRow.Index).Value > 0 Then
                rpta = MessageBox.Show("El Producto tiene Stock generdo por el Sistema" & Chr(13) & "NO es posible eliminarlo...", "CEFE", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Else
                Dim nroInventario As Integer = dataDetalle("inventario", dataDetalle.CurrentRow.Index).Value
                rpta = MessageBox.Show("Esta Seguro de Eliminar el ITEM Seleccionado" + Chr(13) + "Este Proceso es Irreversible...", "CEFE", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2)
                If rpta = 6 Then
                    mInventario.eliminaDetalleMensual(nroInventario)
                    Dim mfila As DataRow = dsInventario.Tables("inventario").Rows(dataDetalle.CurrentRow.Index)
                    dsInventario.Tables("inventario").Rows.Remove(mfila)
                    dataDetalle.Rows.Remove(dataDetalle.CurrentRow)
                End If
            End If
        Else
            rpta = MessageBox.Show("Esta Seguro de Eliminar el ITEM Seleccionado" + Chr(13) + "Este Proceso es Irreversible...", "CEFE", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2)
            If rpta = 6 Then
                Dim mfila As DataRow = dsInventario.Tables("saldo").Rows(dataDetalle.CurrentRow.Index)
                dsInventario.Tables("saldo").Rows.Remove(mfila)
            End If
        End If
    End Sub

    Sub recuperaInventarioMensual(ByVal paraEdicion As Boolean)
        Dim mInventario As New Inventario
        dsInventario.Clear()
        'If paraEdicion Then
        'dsInventario = mInventario.recuperaInvMensual(periodoSeleccionado, True, cboAlmacenRegistro.SelectedValue, False)
        'Else
        '    dsInventario = mInventario.recuperaInvMensual(fechaInventario, True, cboAlmacen.SelectedValue)
        'End If
        dataDetalle.DataSource = dsInventario.Tables("saldo")
        estructuraInventario()
    End Sub
    Private Sub cmdCerrarPeriodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim rpta As Integer
        'If chkProvisional.Checked = True Then
        rpta = MessageBox.Show("Se va Proceder a Cerrar el Periodo... ¿Esta Seguro?", "SGA", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If rpta = 6 Then
            Me.Refresh()
            saldoProvisional = False
            '   cerrarPeriodo()
            'End If
            'Else
            'saldoProvisional = False
            'cerrarPeriodo()
        End If

    End Sub
    'Sub cerrarPeriodo()
    '    'BackgroundWorker1.RunWorkerAsync()
    '    barraProgreso.Visible = True
    '    Dim mInventario As New Inventario
    '    Dim newOperacionInventario As Integer
    '    Dim cad, cad1, cad2, cad3 As String, I As Integer = 0
    '    'Dim fec_cinv As Date = mcFInventario.SelectedDate.Date
    '    Dim mfechaI As String = mcFInventario.SelectedDate.Date.ToString("yyyy-MM-dd")
    '    barraProgreso.Value = 5
    '    'insertamos al historial los ingresos
    '    'cad1 = "insert into h_ingreso(select" & "'" & periodoInventario _
    '    cad1 = "insert into h_ingreso(select DATE_FORMAT(fec_doc, '%Y%m') as proceso, " _
    '            & "operacion,fecha,cod_doc,nro_orden,ser_doc,nro_doc,ser_guia,nro_guia,fec_doc,"
    '    cad2 = "cod_prov,cod_fpago,cancelado,monto,monto_igv,pre_inc_igv,monto_pago,nro_dec,anul," _
    '            & "fec_pago,obs,cod_alma,cod_area,tm,tc,cod_emp,cuenta,0,maquina,usu_mod,fec_mod from ingreso where fec_doc<='" & mfechaI & "')"
    '    cad = cad1 & cad2
    '    Dim comIng As New MySqlCommand(cad, dbConex)
    '    comIng.ExecuteNonQuery()
    '    barraProgreso.Value = 10
    '    'cad = "insert into h_ingreso_det(select " & "'" & periodoInventario _
    '    cad = "insert into h_ingreso_det(select DATE_FORMAT(fec_doc, '%Y%m') as proceso, " _
    '                & " i.operacion,ingreso,cod_art,cant,precio,precio_prom,igv," _
    '                & " if(igv>0,1,0) as afecto_igv,saldo,nAux,nAux2 from ingreso_det id inner join" _
    '                & " ingreso i on id.operacion=i.operacion where fec_doc<='" & mfechaI & "')"
    '    Dim comIngD As New MySqlCommand(cad, dbConex)
    '    comIngD.ExecuteNonQuery()
    '    barraProgreso.Value = 15
    '    'insertamos al historial las guias de remision
    '    cad1 = "insert into h_guia_remision(select" & "'" & periodoInventario & "' as proceso,g.operacion,ser_guia,nro_guia,fec_tras,fec_ent,cod_mot,"
    '    cad2 = "cod_cond,placa,cod_eTrans,cod_sucursal from guia_remision g inner join salida s on g.operacion=s.operacion where s.fec_doc<='" & mfechaI & "')"
    '    cad = cad1 & cad2
    '    Dim comGuia As New MySqlCommand(cad, dbConex)
    '    comGuia.ExecuteNonQuery()
    '    barraProgreso.Value = 21
    '    'insertamos al historial las salidas
    '    'cad1 = "insert into h_salida(select" & "'" & periodoInventario _
    '    cad1 = "insert into h_salida(select DATE_FORMAT(fec_doc, '%Y%m') as proceso, " _
    '            & "operacion,ope_ped,fecha,cod_doc,ser_doc,nro_doc,fec_doc,fec_prod,cod_vend,cod_clie,"
    '    cad2 = "cod_fpago,cancelado,monto,monto_igv,pre_inc_igv,monto_pago,nro_dec,anul,fec_pago,cod_alma,cod_area," _
    '            & "obs,tm,tc,cod_emp,cuenta,nAux,cAux,cAux2,maquina  from salida  where fec_doc<='" & mfechaI & "')"
    '    cad = cad1 & cad2
    '    Dim comSal As New MySqlCommand(cad, dbConex)
    '    comSal.CommandTimeout = 300
    '    comSal.ExecuteNonQuery()
    '    barraProgreso.Value = 23
    '    'cad = "insert into h_salida_det(select" & "'" & periodoInventario _
    '    cad = "insert into h_salida_det(select DATE_FORMAT(fec_doc, '%Y%m') as proceso, " _
    '        & "salida,id.operacion,ingreso,cod_art,cant,precio,igv,comi_v,comi_jv,id.nAux,id.nAux2,id.obs " _
    '        & " from salida_det id inner join salida i on id.operacion=i.operacion where fec_doc<='" & mfechaI & "')"
    '    Dim comSalD As New MySqlCommand(cad, dbConex)
    '    comSalD.CommandTimeout = 300
    '    comSalD.ExecuteNonQuery()
    '    barraProgreso.Value = 25

    '    'cad = "insert into h_salida_detpago(select" & "'" & periodoInventario _
    '    cad = "insert into h_salida_detpago(select DATE_FORMAT(fec_doc, '%Y%m') as proceso, " _
    '        & " id.operacion,id.cod_fpago,id.imp_pagado,id.imp_propina,id.imp_vuelto,id.obs_pago " _
    '        & " from salida_detpago id inner join salida i on id.operacion=i.operacion where fec_doc<='" & mfechaI & "')"
    '    Dim comSalp As New MySqlCommand(cad, dbConex)
    '    comSalp.CommandTimeout = 300
    '    comSalp.ExecuteNonQuery()
    '    barraProgreso.Value = 25

    '    '/********************************/
    '    'grabamos los saldos finales del mes en proceso x almacen
    '    Dim nro As Integer = Int(45 / (nroAlmacenes * 2))
    '    For I = 0 To nroAlmacenes - 1
    '        Dim operacion As Integer = mInventario.maxOperacionMensual
    '        mInventario.insertar_invMensual(operacion, fechaInventario, pDecimales, mAlmacen(I), "0000", pCuentaUser)
    '        barraProgreso.Value = barraProgreso.Value + nro
    '        grabaSaldoSistema(mAlmacen(I), operacion)
    '        barraProgreso.Value = barraProgreso.Value + nro
    '    Next
    '    '/********************************/
    '    '***ELIMINAMOS LOS DATOS DEL PERIODO ACTUAL***
    '    'eliminamos los Ingresos
    '    cad = "delete from ingreso where fec_doc<='" & mfechaI & "'"
    '    Dim comEI As New MySqlCommand(cad, dbConex)
    '    comEI.ExecuteNonQuery()
    '    barraProgreso.Value = 80

    '    cad = "delete g from guia_remision g inner join salida s on g.operacion=s.operacion where s.fec_doc<='" & mfechaI & "'"
    '    Dim comEG As New MySqlCommand(cad, dbConex)
    '    comEG.ExecuteNonQuery()
    '    barraProgreso.Value = 84

    '    'eliminamos las salidas
    '    cad = "delete from salida where fec_doc<='" & mfechaI & "'"
    '    Dim comES As New MySqlCommand(cad, dbConex)
    '    comES.CommandTimeout = 300
    '    comES.ExecuteNonQuery()
    '    barraProgreso.Value = 88

    '    'insertamos el inventario inicial en 0
    '    pFechaActivaMax = pFechaActivaMax.AddDays(1)
    '    Dim mfechadoc As String = pFechaActivaMax.ToString("yy-MM-dd")
    '    Dim mfechasys As String = pFechaHoraSystem.ToString("yy-MM-dd HH:mm:ss")
    '    cad1 = "insert into ingreso(select operacion,'" & mfechasys & "' as fecha,cod_doc,nro_orden,ser_doc,nro_doc,ser_guia,nro_guia,'" & mfechadoc & "' as fec_doc ,"
    '    cad2 = "cod_prov,cod_fpago,cancelado,monto,monto_igv,pre_inc_igv,monto_pago,nro_dec,anul," _
    '            & "fec_pago,obs,cod_alma,cod_area,tm,tc,cod_emp,cuenta,'','','','',maquina  from h_ingreso where proceso='" & periodoInventario & "' and cod_doc='10')"
    '    cad = cad1 & cad2
    '    Dim comIngI As New MySqlCommand(cad, dbConex)
    '    comIngI.CommandTimeout = 300
    '    comIngI.ExecuteNonQuery()
    '    barraProgreso.Value = 90
    '    cad1 = "insert into ingreso_det(select hd.operacion,hd.ingreso,hd.cod_art,0,a.pre_costo,a.pre_prom,hd.igv,0,hd.nAux,hd.nAux2,'','','',''  from h_ingreso h inner join h_ingreso_det hd on h.operacion=hd.operacion and h.proceso=hd.proceso inner join articulo a on a.cod_Art=hd.cod_art "
    '    cad2 = "where h.proceso='" & periodoInventario & "' and h.cod_doc='10' )"
    '    cad = cad1 & cad2
    '    Dim comIngDI As New MySqlCommand(cad, dbConex)
    '    comIngDI.CommandTimeout = 300
    '    comIngDI.ExecuteNonQuery()

    '    '/********************************/
    '    'activamos el nuevo periodo de trabajo
    '    'newPeriodoInventario = Microsoft.VisualBasic.Left(periodoInventario, 4) _
    '    '            & Microsoft.VisualBasic.Right("00" & Trim(Str(Val(Microsoft.VisualBasic.Right(periodoInventario, 2)) + 1)), 2)
    '    newOperacionInventario = general.ActOperacion() + 1
    '    cad1 = "update actual set activo=0"
    '    cad2 = "update actual set activo=1 where operacion='" & newOperacionInventario & "'"
    '    cad3 = "update configuracion set periodo_cerrado='" & periodoInventario & "'"
    '    Dim comPeriodo As New MySqlCommand(cad1, dbConex)
    '    barraProgreso.Value = 92
    '    comPeriodo.ExecuteNonQuery()
    '    Dim comPeriodoNew As New MySqlCommand(cad2, dbConex)
    '    comPeriodoNew.ExecuteNonQuery()
    '    barraProgreso.Value = 95
    '    Dim comPeriodoCerrado As New MySqlCommand(cad3, dbConex)
    '    comPeriodoCerrado.ExecuteNonQuery()
    '    barraProgreso.Value = 100
    '    'actualizamos las variables de entorno
    '    pFechaActivaMin = general.fechaActivaMin()
    '    pFechaActivaMax = general.fechaActivaMax()
    '    barraProgreso.Visible = False
    '    MessageBox.Show("Proceso Terminado... Se va a Cerrar la Ventana", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Stop)
    '    Me.Close()
    'End Sub
    Sub grabaSaldoSistema(ByVal cod_alma As String, ByVal nroOperacion As Integer)
        Dim mCatalogo As New Catalogo, mInventario As New Inventario
        Dim I As Integer = 0, X As Integer = 0, codigo As String = ""
        dsArticulos = mCatalogo.recuperaSaldos(False, "", True, True, cod_alma, False, "", False, False, "", pDecimales)
        dsInventario.Clear()
        'cargamos articulos del inventario
        Dim cod_art As String, cant_sis, cant_fis, precio As Decimal
        If dsArticulos.Tables("saldo").Rows.Count > 0 Then
            'cargamos saldo final del sistema
            I = 0
            For I = 0 To dsArticulos.Tables("saldo").Rows.Count - 1
                cod_art = dsArticulos.Tables("saldo").Rows(I).Item("cod_art").ToString
                precio = dsArticulos.Tables("saldo").Rows(I).Item("precio").ToString
                cant_sis = dsArticulos.Tables("saldo").Rows(I).Item("saldo").ToString
                If saldoProvisional Then
                    cant_fis = dsArticulos.Tables("saldo").Rows(I).Item("saldo").ToString
                Else
                    cant_fis = 0
                End If
                Dim nInventario As Integer = mInventario.maxInventarioMensual
                mInventario.insertar_detInvMensual(nroOperacion, nInventario, cod_art, cant_sis, cant_fis, precio, pCuentaUser)
            Next
        End If
    End Sub
    Function areasCierre(ByVal cod_alma As String) As DataSet
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter
        Dim com As New MySqlCommand("select cod_area,nom_area from area where activo=1" _
                        & " and cod_alma='" & cod_alma & "' order by nom_area", dbConex)
        da.SelectCommand = com
        da.Fill(ds, "area")
        Return ds
    End Function
    Private Sub cmdCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub





    Private Sub cboGrupo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboGrupo.SelectedIndexChanged
        If Not estaCargando Then
            dsInventario.Tables("Saldo").DefaultView.RowFilter = "cod_sgrupo = '" & cboGrupo.SelectedValue & "'"
        End If
    End Sub
    Private Sub cmdCostos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim com As New MySqlCommand
        com.Connection = dbConex
        Dim cad, cad1, cad2 As String
        cad1 = "Update inventario_mdet set pre_costo="
        cad2 = " (select pre_costo from articulo where articulo.cod_art=inventario_mdet.cod_art)"
        cad = cad1 + cad2
        com.CommandText = cad
        com.ExecuteNonQuery()
        MessageBox.Show("Se Actualizaron Los Costos...", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Function periodoSeleccionadoReportes()
        Dim periodo As String = Trim(Str(cboAnnoR.SelectedIndex + 2010)) & Microsoft.VisualBasic.Right("00" & Trim(Str(cboMesR.SelectedIndex + 1)), 2)
        Return periodo
    End Function

    Private Sub cmdProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdProcesar.Click
        procesarMovimientos()
    End Sub
    Sub procesarMovimientos()
        dsReportes.Clear()
        Dim mCatalogo As New Catalogo, mInventario As New Inventario, mIngreso As New Ingreso
        Dim mBajas As New Bajas, mSalida As New Salida, mAlmacen As New Almacen, mUnidad As New Unidad
        Dim ds, dsInicial, dsInicial_p, dsProduccion, dsCompras, dsPersonal, dsPersonal_p, dsEventos, dsEventos_p As New DataSet
        Dim dsSalidas, dsBajas, dsBajas_p, dsVentas, dsFinal, dsFinal_p, dsbar, dscocina, dsOtraSalida As New DataSet
        Dim codigo As String, cant_sis, cant_fis As Decimal
        'Dim es_div As Boolean
        Dim xfecha As Boolean
        Dim xAlmacen As Boolean = IIf(pCatalogoXalmacen, True, False)
        Dim cAlmacen As String = CboAlmacenRpt.SelectedValue
        Dim cCatalogo As String = mAlmacen.devuelveAlmacenCatalogo(CboAlmacenRpt.SelectedValue)
        'variables para recuperar la informacion
        Dim periodo As String = periodoSeleccionadoReportes()
        Dim esHistorial As Boolean = IIf(periodo = periodoActivo(), False, True)
        Dim esProduccion As Boolean = IIf(optProducciones.Checked = True, True, False)
        Dim cPrecioProm As String = general.strPrecioCostoPromedio, mPrecio As New ePrecio
        Dim xGrupo As Boolean = IIf(optMovimientos.Checked, True, False)
        Dim fecha_ini As Date = dtiDesde.Value
        Dim fecha_fin As Date = dtiHasta.Value

        cmdProcesar.Text = "Preparando Datos..."

        xAlmacen = IIf(chkIntegrado.Checked = True, False, True)
        xfecha = IIf(chkDia.Checked = True, True, False)
        'If pCatalogoXalmacen Then
        'ds = mCatalogo.recuperaCatalogoMen(pCatalogoXalmacen, cCatalogo, True, False, xGrupo, "", False, esProduccion, False)
        Dim xCatalogo_Activo As Boolean = False
        ds = mCatalogo.recuperaCatalogoIngreso(esHistorial, periodo, True, cAlmacen, xCatalogo_Activo, False, xGrupo, "", False, esProduccion, False)
        If xfecha Then
            dsInicial = mInventario.recInvdiarioInicialAlmaProduccion(pEmpresa, pCatalogoXalmacen, dtiDesde.Value, dtiHasta.Value, xAlmacen, cAlmacen)
            fecha_ini = fecha_ini.AddDays(-1)
        Else
            dsInicial = mIngreso.recInvInicial_prod(pEmpresa, pCatalogoXalmacen, esHistorial, periodo, xAlmacen, cAlmacen, True)
        End If
        dsCompras = mIngreso.recCompras(pEmpresa, pCatalogoXalmacen, xfecha, fecha_ini, dtiHasta.Value, esHistorial, periodo, xAlmacen, cAlmacen, True)
        dsProduccion = mIngreso.rec_producciones(pEmpresa, pCatalogoXalmacen, esHistorial, periodo, xAlmacen, cAlmacen, True)
        dsVentas = mSalida.recventas_fact(pEmpresa, pCatalogoXalmacen, xfecha, dtiDesde.Value, dtiHasta.Value, esHistorial, periodo, xAlmacen, cAlmacen, True)
        dsPersonal = mSalida.recTransPersonal("", pCatalogoXalmacen, esHistorial, periodo, xAlmacen, cAlmacen, True)
        dsEventos = mSalida.recTransEventos("", pCatalogoXalmacen, esHistorial, periodo, xAlmacen, cAlmacen, True)
        dscocina = mSalida.recTransCocina("", pCatalogoXalmacen, esHistorial, periodo, xAlmacen, cAlmacen, True)
        dsbar = mSalida.recTransBar("", pCatalogoXalmacen, esHistorial, periodo, xAlmacen, cAlmacen, True)
        dsSalidas = mSalida.recSalidas("", pCatalogoXalmacen, xfecha, dtiDesde.Value, dtiHasta.Value, esHistorial, periodo, xAlmacen, cAlmacen, True)
        ' dsOtraSalida = mSalida.recOtraSalidas("", pCatalogoXalmacen, esHistorial, periodo, xAlmacen, cAlmacen, True)
        dsBajas = mBajas.recBajas("", pCatalogoXalmacen, xfecha, dtiDesde.Value, dtiHasta.Value, esHistorial, periodo, xAlmacen, cAlmacen, True)
        If xfecha Then
            dsFinal_p = mInventario.recInvdiarioAlmaProduccion(pEmpresa, pCatalogoXalmacen, dtiDesde.Value, dtiHasta.Value, xAlmacen, cAlmacen)
        Else
            dsFinal_p = mInventario.recInvFinalAlmaProduccion(pEmpresa, pCatalogoXalmacen, periodo, xAlmacen, cAlmacen)
        End If

        'cargamos los articulos del almacen principal
        Dim I As Integer = 0, X As Integer = 0
        Dim nprecioprom As Decimal
        If ds.Tables("articulo").Rows.Count > 0 Then
            For I = 0 To ds.Tables("articulo").Rows.Count - 1
                cmdProcesar.Text = "Inciando Proceso..."
                cmdProcesar.Refresh()
                'cargamos los articulos del almacen seleccionado
                Dim fila As DataRow = dsReportes.Tables("inventario").NewRow
                codigo = ds.Tables("articulo").Rows(I).Item("cod_art").ToString
                fila.Item("cod_art") = ds.Tables("articulo").Rows(I).Item("cod_art").ToString
                fila.Item("nom_art") = ds.Tables("articulo").Rows(I).Item("nom_art").ToString
                fila.Item("nom_uni") = ds.Tables("articulo").Rows(I).Item("nom_uni").ToString
                fila.Item("cod_sgrupo") = ds.Tables("articulo").Rows(I).Item("cod_sgrupo").ToString
                fila.Item("nom_sgrupo") = ds.Tables("articulo").Rows(I).Item("nom_sgrupo").ToString
                fila.Item("cod_alma") = ds.Tables("articulo").Rows(I).Item("cod_alma").ToString
                fila.Item("precio") = ds.Tables("articulo").Rows(I).Item("precio").ToString
                dsReportes.Tables("inventario").Rows.Add(fila)
            Next
        End If
        For X = 0 To dataReportes.RowCount - 1
            dataReportes.Item("inicial", X).Value = 0.0
            dataReportes.Item("ingresos", X).Value = 0.0
            dataReportes.Item("salidas", X).Value = 0.0
            dataReportes.Item("ventas", X).Value = 0.0
            dataReportes.Item("bar", X).Value = 0.0
            dataReportes.Item("cocina", X).Value = 0.0
            dataReportes.Item("personal", X).Value = 0.0
            dataReportes.Item("eventos", X).Value = 0.0
            dataReportes.Item("otros", X).Value = 0.0
            dataReportes.Item("bajas", X).Value = 0.0
            dataReportes.Item("cant_sis", X).Value = 0.0
            dataReportes.Item("cant_fis", X).Value = 0.0
            dataReportes.Item("pre_costo", X).Value = 0.0
        Next
        If ds.Tables("articulo").Rows.Count > 0 Then
            ObtenerCantidad("Inicial", dsInicial)
            ObtenerCantidad("Ingresos", dsCompras)
            ObtenerCantidad("Personal", dsPersonal)
            ObtenerCantidad("ventas", dsVentas)
            ObtenerCantidad("Eventos", dsEventos)
            ObtenerCantidad("Cocina", dscocina)
            ObtenerCantidad("Bar", dsbar)
            ObtenerCantidad("salidas", dsSalidas)
            ' ObtenerCantidad("Otros", dsOtraSalida)
            ObtenerCantidad("Bajas", dsBajas)
            For I = 0 To dsFinal_p.Tables("final").Rows.Count - 1
                Dim sgrupo As String
                cmdProcesar.Text = "Generando... " & I & " de " & dsFinal_p.Tables("final").Rows.Count
                cmdProcesar.Refresh()
                codigo = dsFinal_p.Tables("final").Rows(I).Item("cod_art").ToString
                sgrupo = dsFinal_p.Tables("final").Rows(I).Item("cod_sgrupo").ToString
                cant_sis = dsFinal_p.Tables("final").Rows(I).Item("cant_sis").ToString
                cant_fis = dsFinal_p.Tables("final").Rows(I).Item("cant_fis").ToString
                nprecioprom = dsFinal_p.Tables("final").Rows(I).Item("pre_costo").ToString
                For X = 0 To dataReportes.RowCount - 1
                    If dataReportes.Item("cod_art", X).Value = codigo Then
                        'conversion = IIf(sgrupo = "0016" Or sgrupo = "0014" Or sgrupo = "0030" Or sgrupo = "0015", 0.75, 1)
                        dataReportes.Item("cant_sis", X).Value = dataReportes.Item("cant_sis", X).Value + cant_sis
                        dataReportes.Item("cant_fis", X).Value = dataReportes.Item("cant_fis", X).Value + cant_fis
                        dataReportes.Item("pre_costo", X).Value = nprecioprom

                        Exit For
                    End If
                Next
            Next



            cmdProcesar.Text = "Procesar Datos Para Reportes"
            estructuraMovimientos()
            MessageBox.Show("Proceso Terminado...", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cmdImprimir.Focus()
        End If
    End Sub
    Sub ObtenerCantidad(ByVal tipods As String, ByVal ds As DataSet)
        Dim I, X As Integer
        Dim codigo As String, cantidad As Decimal
        For I = 0 To ds.Tables(0).Rows.Count - 1
            cmdProcesar.Text = tipods & I & " de " & ds.Tables(0).Rows.Count
            cmdProcesar.Refresh()
            codigo = ds.Tables(0).Rows(I).Item("cod_art").ToString
            cantidad = ds.Tables(0).Rows(I).Item("cant").ToString
            For X = 0 To dataReportes.RowCount - 1
                If dataReportes.Item("cod_art", X).Value = codigo Then
                    dataReportes.Item(tipods, X).Value = cantidad + dataReportes.Item(tipods, X).Value
                    Exit For
                End If
            Next
        Next
    End Sub
    Sub ObtenerCosto(ByVal tipods As String, ByVal ds As DataSet, ByVal esHistorial As Boolean, ByVal periodo As String)
        Dim I, X As Integer
        Dim cPrecioProm As String = "round(sum(if(pre_inc_igv,if(tm='D',(precio*tc)/(1+igv),precio/(1+igv)),if(tm='D',precio*tc,precio))*cant)/sum(cant),3)"
        Dim nPrecioProm As Decimal
        Dim mprecio As New ePrecio
        Dim codigo As String
        For I = 0 To ds.Tables(0).Rows.Count - 1
            cmdProcesar.Text = tipods & I & " de " & ds.Tables(0).Rows.Count
            cmdProcesar.Refresh()
            codigo = ds.Tables(0).Rows(I).Item("cod_art").ToString
            For X = 0 To dataReportes.RowCount - 1
                If dataReportes.Item("cod_art", X).Value = codigo Then
                    nPrecioProm = mprecio.calculaPrecioPromedioh(codigo, "esIngresoAlma", cPrecioProm, esHistorial, periodo)
                    dataReportes.Item("pre_costo", X).Value = nPrecioProm
                    Exit For
                End If
            Next
        Next
    End Sub
    Sub estructuraMovimientos()
        With dataReportes
            .DataSource = dsReportes.Tables("inventario").DefaultView
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .ReadOnly = True
            .Columns("cod_art").HeaderText = "Codigo"
            .Columns("cod_art").Width = 55
            .Columns("cod_art").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("nom_art").HeaderText = "Descripción"
            .Columns("nom_art").Width = 225
            .Columns("nom_uni").HeaderText = "Unidad"
            .Columns("nom_uni").Width = 65
            .Columns("inicial").HeaderText = "Inicial"
            .Columns("inicial").Width = 65
            .Columns("inicial").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("ingresos").HeaderText = "Ingresos"
            .Columns("ingresos").Width = 65
            .Columns("ingresos").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("Ventas").HeaderText = "Ventas"
            .Columns("Ventas").Width = 65
            .Columns("Ventas").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("Salidas").HeaderText = "Salidas"
            .Columns("Salidas").Width = 65
            .Columns("Salidas").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("Bajas").HeaderText = "Bajas"
            .Columns("Bajas").Width = 65
            .Columns("Bajas").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("Cocina").HeaderText = "Cocina"
            .Columns("Cocina").Width = 65
            .Columns("Cocina").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("Bar").HeaderText = "Bar"
            .Columns("Bar").Width = 65
            .Columns("Bar").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("Personal").HeaderText = "Personal"
            .Columns("Personal").Width = 65
            .Columns("Personal").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("Eventos").HeaderText = "Eventos"
            .Columns("Eventos").Width = 65
            .Columns("Eventos").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("Otros").HeaderText = "Otros"
            .Columns("Otros").Width = 65
            .Columns("Otros").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("cant_fis").HeaderText = "Fisico"
            .Columns("cant_fis").Width = 65
            .Columns("cant_fis").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("cant_sis").HeaderText = "Sistema"
            .Columns("cant_sis").Width = 65
            .Columns("cant_sis").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("pre_costo").HeaderText = "Costo"
            .Columns("pre_costo").Width = 65
            .Columns("pre_costo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("sistema").Visible = False
            .Columns("fisico").Visible = False
            .Columns("costo_fis").Visible = False
            .Columns("diferencia").Visible = False
            .Columns("nro_inv").Visible = False
            .Columns("cod_inv").Visible = False
            .Columns("fec_inv").Visible = False
            .Columns("inventario").Visible = False
            .Columns("afecto_igv").Visible = False
            .Columns("cod_sgrupo").Visible = False
            .Columns("nom_sgrupo").Visible = False
            .Columns("cod_alma").Visible = False
            .Columns("nom_alma").Visible = False
        End With
    End Sub
    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click

        Dim mReceta As New Receta, minventario As New Inventario
        If dsAlmacen.Tables("almacen").Rows.Count > 0 Then
            Dim fechaReporte As String = general.fechaInventario(periodoInventario)
            Dim periodo As String = periodoSeleccionadoReportes()
            Dim periodoReporte As String = "Periodo: " & general.periodo_mesAnnoLetras(periodo)
            Dim frm As New rptForm
            Dim nomReporte = IIf(chkIntegrado.Checked = True, "Integrado", CboAlmacenRpt.Text)

            If optMovimientos.Checked = True Then
                frm.cargarInventarioMensualMovimientos(dsReportes, fechaReporte, periodoReporte, nomReporte, 1)
            Else
                If OptMovimientoDif.Checked = True Then
                    frm.cargarInventarioMensualMovimientos(dsReportes, fechaReporte, periodoReporte, nomReporte, 2)
                Else
                    If optValorizado.Checked = True Then
                        frm.cargarInventarioMensualValorizado(dsReportes, fechaReporte, periodoReporte, nomReporte)
                    Else
                        If optExistencias.Checked = True Then
                            Dim ds As New DataSet, titulo As String = "Inventario Existencias Valorizadas"
                            ds = minventario.recuperaInventarioCrostabResumen(general.fechaInventario(periodo))
                            frm.cargarReporteCrostab(ds, periodoReporte, titulo)
                        Else
                            If optInventario.Checked = True Then
                                Dim ds As New DataSet, titulo As String = "Listado de Inventarios Valorizado"
                                ds = minventario.recuperaInventarioPermanente(general.fechaInventario(periodo))
                                frm.cargarReporteInventario(ds, periodoReporte, titulo)

                            Else
                                If optProducciones.Checked = True Then
                                    Dim ds As New DataSet
                                    ds = mReceta.recProducciones(False, "", True)
                                    frm.cargarProducciones(ds, periodoReporte)
                                Else
                                    frm.cargarInventarioMensualDiferencias(dsReportes, fechaReporte, periodoReporte, nomReporte)
                                End If
                            End If
                        End If
                    End If
                End If
            End If
            'End If
            frm.MdiParent = principal
            frm.Show()
        End If
    End Sub


    Private Sub cmdUpdCostos_Click(sender As System.Object, e As System.EventArgs)
        AjusteInventario()

    End Sub

    Private Sub cmdIniciarRegistro_Click(sender As System.Object, e As System.EventArgs) Handles cmdIniciarRegistro.Click
        AjusteInventario()
    End Sub

    Private Sub AjusteInventario()
        Dim msalida As New Salida, mingreso As New Ingreso
        Dim operacionS, OperacionI As Integer
        Dim diferencia As Decimal
        Dim num_documento As String
        Dim cod_alma As String = cboAlmacenRegistro.SelectedValue
        Dim cfecha As Date = dtiDesde.Value
        operacionS = msalida.maxOperacion
        num_documento = msalida.maxNroSalida("13", "000")
        msalida.insertar_aux(operacionS, 0, "13", "000", num_documento, cfecha, "", "00000000", "00000000000", "00", 1, 0, pDecimales, cod_alma, "0000", "", "00", pCuentaUser, pCuentaUser, 0, 0, 0)
        OperacionI = mingreso.maxOperacion
        'num_documento = mIngreso.maxNotaIngreso(cod_doc, "000")
        mingreso.insertar(OperacionI, "13", "000", num_documento, "000", "00000000", 0, cfecha, "00000000000", "00", cod_alma, "0000", True, False, pDecimales, "", "S", pTC, pCuentaUser, pmaquina)
        Try
            For Each row As DataGridViewRow In dataDetalle.Rows
                Dim cod_art As String = row.Cells("cod_art").Value
                Dim cant_sis As Decimal = row.Cells("saldo").Value
                Dim cant_fis As Decimal = row.Cells("cant_fis").Value
                diferencia = cant_sis - cant_fis
                If diferencia <> 0 Then
                    insertaInsumo(cod_art, diferencia, operacionS, OperacionI)
                End If

            Next
            muestraInventario(True)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub insertaInsumo(ByVal cod_art As String, ByVal cantidad As Decimal, ByVal OpeSalida As Integer, ByVal OpeIngreso As Integer)
        Dim mSalida As New Salida, mIngreso As New Ingreso, mprecio As New ePrecio
        Dim nSalida, nIngreso As Integer
        Dim nCosto As Decimal
        nCosto = mprecio.devuelvePrecioCosto(cod_art)
        If cantidad > 0 Then
            nSalida = mSalida.maxSalida + 1
            mSalida.insertar_det(OpeSalida, nSalida, OpeIngreso, cod_art, cantidad, nCosto, 0, 0, 0)
        Else
            cantidad = Math.Abs(cantidad)
            nIngreso = mIngreso.maxIngreso + 1
            mIngreso.insertar_det(OpeIngreso, nIngreso, cod_art, cantidad, nCosto, pCuentaUser, pIGV)
        End If
    End Sub



    Private Sub cboAlmacenRegistro_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboAlmacenRegistro.SelectedIndexChanged
        'If Not estaCargando Then
        '    muestraInventario(True)
        'End If
    End Sub

    Private Sub dataDetalle_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataDetalle.CellContentClick

    End Sub

    Private Sub ButtonX1_Click_1(sender As Object, e As EventArgs) Handles ButtonX1.Click
        Dim mInventario As New Inventario
        Dim I As Integer, Inventario As Integer
        Dim cod_art As String
        Dim precio, cant_fisico As Decimal

        Dim cod_alma As String = cboAlmacenRegistro.SelectedValue
        Dim operacion As Integer = mInventario.maxOperacionDiario

        If mInventario.existDiario(dtiDesde.Value, True, cod_alma) Then
            mInventario.eliminainventarioDiario(dtiDesde.Value, cod_alma)
            mInventario.insertar_invDiario(operacion, dtiFecha.Value, pDecimales, cod_alma, "0000", pCuentaUser)
        Else
            mInventario.insertar_invDiario(operacion, dtiFecha.Value, pDecimales, cod_alma, "0000", pCuentaUser)
        End If



        For I = 0 To dataDetalle.RowCount - 1
            cod_art = dataDetalle("cod_art", I).Value
            precio = dataDetalle("precio", I).Value
            cant_fisico = dataDetalle("cant_fis", I).Value
            Inventario = Inventario + 1
            mInventario.insertar_detInvDiario(operacion, Inventario, cod_art, 0, cant_fisico, 0, precio, pCuentaUser)

        Next
        MessageBox.Show("Inventario Actualziado.")
        'cargaDatosInventario(mcFInventario.SelectedDate)

    End Sub

    Private Sub chkDia_CheckedChanged(sender As Object, e As EventArgs) Handles chkDia.CheckedChanged
        If Not estaCargando Then
            estableceFechas()
            If chkDia.CheckState = CheckState.Checked Then
                dtiDesde.Enabled = True
                dtiHasta.Enabled = True

            Else
                dtiDesde.Enabled = False
                dtiHasta.Enabled = False
            End If

        End If
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Dim valor As String = txtBuscar.Text
        dsInventario.Tables("Saldo").DefaultView.RowFilter = "nom_art LIKE '%" & valor & "%'"
    End Sub

    Private Sub cboMesA_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub cboMesR_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMesR.SelectedIndexChanged

    End Sub

    Private Sub dataReportes_KeyDown(sender As Object, e As KeyEventArgs) Handles dataReportes.KeyDown
        If (e.Control And e.KeyCode = Keys.E) Then
            If dataReportes.RowCount > 0 Then
                EnviaraExcel(dataReportes)
            End If
        End If
    End Sub
End Class
