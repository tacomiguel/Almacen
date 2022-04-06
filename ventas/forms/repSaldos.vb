Imports MySql.Data.MySqlClient
Imports libreriaClases
Public Class repSaldos
    Private dsAlmacen As New DataSet
    Private dssubgrupo As New DataSet
    Private dsSaldos As New DataSet
    Private dsStockG As New DataSet
    Private dsDocumentosIng As New DataSet
    Private dsResumen As New DataSet
    Private dsArea As New DataSet

    Private Shared WithEvents myTimer As New System.Windows.Forms.Timer()
    Private Shared alarmCounter As Integer = 1
    Private Shared exitFlag As Boolean = False


    Private estaCargando As Boolean = True


    Private Sub repSaldos_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        principal.mr_saldos.Enabled = True
    End Sub
    Private Sub repSaldos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Top = 0
        Me.Left = 0
        Dim mes, anno As Integer
        mes = Month(pFechaActivaMax)
        anno = Year(pFechaActivaMax)
        cboMes.SelectedIndex = mes - 1
        cboAnno.SelectedIndex = anno - 2010
        'dataset almacen
        Dim daAlmacen As New MySqlDataAdapter
        Dim comAlmacen As New MySqlCommand("select cod_alma,nom_alma from almacen where activo=1 order by nom_alma", dbConex)
        daAlmacen.SelectCommand = comAlmacen
        daAlmacen.Fill(dsAlmacen, "almacen")
        With cboAlmacen
            .DataSource = dsAlmacen.Tables("almacen")
            .DisplayMember = dsAlmacen.Tables("almacen").Columns("nom_alma").ToString
            .ValueMember = dsAlmacen.Tables("almacen").Columns("cod_alma").ToString
            .SelectedIndex = 0
        End With
        'dataset subgrupo
        Dim dasubgrupo As New MySqlDataAdapter
        Dim comsubgrupo As New MySqlCommand("select cod_sgrupo,nom_sgrupo from subgrupo where activo=1 order by nom_sgrupo", dbConex)
        dasubgrupo.SelectCommand = comsubgrupo
        dasubgrupo.Fill(dssubgrupo, "subgrupo")
        With cbosubgrupo
            .DataSource = dssubgrupo.Tables("subgrupo")
            .DisplayMember = dssubgrupo.Tables("subgrupo").Columns("nom_sgrupo").ToString
            .ValueMember = dssubgrupo.Tables("subgrupo").Columns("cod_sgrupo").ToString
            .SelectedIndex = -1
        End With
        estaCargando = False
        muestraArea("0001")

        muestraSaldos()
    End Sub
    Private Sub cboMes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMes.SelectedIndexChanged
        If Not estaCargando Then
            If Not estaCargando Then
                muestraSaldos()
            End If
        End If
    End Sub
    Private Sub cboAnno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAnno.SelectedIndexChanged
        If Not estaCargando Then
            If Not estaCargando Then
                muestraSaldos()
            End If
        End If
    End Sub
    Private Sub dtiDesde_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        If Not estaCargando Then
            muestraSaldos()
        End If
    End Sub
    Private Sub cboAlmacen_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboAlmacen.GotFocus
        If Not estaCargando Then
            If dsAlmacen.Tables("almacen").Rows.Count > 0 Then
                If cboAlmacen.SelectedIndex = -1 Then
                    cboAlmacen.SelectedIndex = 0
                End If
            End If
        End If
    End Sub
    Private Sub cboAlmacen_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboAlmacen.SelectedIndexChanged
        If Not estaCargando Then
            muestraSaldos()
            muestraArea(cboAlmacen.SelectedValue)
        End If
    End Sub
    Private Sub cbosubgrupo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbosubgrupo.GotFocus
        If Not estaCargando Then
            If dssubgrupo.Tables("subgrupo").Rows.Count > 0 Then
                If cbosubgrupo.SelectedIndex = -1 Then
                    cbosubgrupo.SelectedIndex = 0
                End If
            End If
        End If
    End Sub
    Private Sub cbosubgrupo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbosubgrupo.SelectedIndexChanged
        If Not estaCargando Then
            muestraSaldos()
        End If
    End Sub
    Private Sub chksubgrupo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chksubgrupo.CheckedChanged
        If Not estaCargando Then
            If chksubgrupo.Checked = True Then
                cbosubgrupo.SelectedIndex = 0
                cbosubgrupo.Enabled = True
            Else
                cbosubgrupo.SelectedIndex = -1
                cbosubgrupo.Enabled = False
            End If
            muestraSaldos()
            dataStock.Focus()
        End If
    End Sub
    Function fechaI() As Date
        If Not estaCargando Then
            Dim mfecha As Date
            mfecha = general.convierteTexto_enFecha(1, cboMes.SelectedIndex + 1, Val(cboAnno.Text))
            Return mfecha
        End If
    End Function
    Function fechaF() As Date
        If Not estaCargando Then
            Dim mFecha As Date
            If cboMes.SelectedIndex = 11 Then 'cuando es diciembre
                mFecha = Microsoft.VisualBasic.DateAndTime.DateAdd(DateInterval.Day, -1, general.convierteTexto_enFecha(1, 1, Val(cboAnno.Text) + 1))
            Else
                mFecha = Microsoft.VisualBasic.DateAndTime.DateAdd(DateInterval.Day, -1, general.convierteTexto_enFecha(1, cboMes.SelectedIndex + 2, Val(cboAnno.Text)))
            End If
            Return mFecha
        End If
    End Function
    Function periodoSeleccionado()
        Dim periodo As String = Trim(Str(cboAnno.SelectedIndex + 2010)) & Microsoft.VisualBasic.Right("00" & Trim(Str(cboMes.SelectedIndex + 1)), 2)
        Return periodo
    End Function

    Private Sub dataStock_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dataStock.KeyDown
        If (e.Control And e.KeyCode = Keys.E) Then
            If dataStock.RowCount > 0 Then
                EnviaraExcel(dataStock)
            End If
        End If
    End Sub
    Private Sub dataStock_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dataStock.SelectionChanged
        If Not estaCargando Then
            muestraDocumentosIngreso()
        End If
    End Sub
    Sub muestraSaldos()
        Dim mCatalogo As New Catalogo
        txtBuscar.Text = ""
        dsSaldos.Clear()
        'variables para llamar a los reportes
        Dim periodo As String = periodoSeleccionado()
        Dim es_historial As Boolean = IIf(periodo = periodoActivo(), False, True)
        Dim es_xAlmacen As Boolean = IIf(cboAlmacen.SelectedIndex >= 0, True, False)
        Dim es_xArea As Boolean = IIf(chkArea.Checked, True, False)
        Dim es_xsubgrupo As Boolean = IIf(chksubgrupo.Checked, True, False)
        Dim es_xsaldo As Boolean = IIf(chksaldo.Checked, True, False)
        Dim cAlmacen As String = cboAlmacen.SelectedValue
        Dim cArea As String = IIf(chkArea.Checked, cboArea.SelectedValue, False)
        Dim csubgrupo As String = IIf(chksubgrupo.Checked, cbosubgrupo.SelectedValue, False)
        Dim preciosConIMP As Boolean = False
        dsSaldos = mCatalogo.recuperaSaldos_Integrado(es_historial, periodo, True, es_xAlmacen, cAlmacen, es_xArea, cArea, es_xsubgrupo, csubgrupo, preciosConIMP, False, "", pDecimales, es_xsaldo, False)
        dataStock.DataSource = ""
        dataStock.DataSource = dsSaldos.Tables("saldo").DefaultView
        lblRegistros.Text = "Nº de Registros... " & dataStock.RowCount.ToString
        estructuraSaldos()
    End Sub
    Sub muestraStockG()
        Dim mCatalogo As New Catalogo
        txtBuscar.Text = ""
        dsStockG.Clear()
        'variables para llamar a los reportes
        Dim periodo As String = periodoSeleccionado()
        Dim es_historial As Boolean = IIf(periodo = periodoActivo(), False, True)
        Dim es_xAlmacen As Boolean = IIf(cboAlmacen.SelectedIndex >= 0, True, False)
        Dim cAlmacen As String = cboAlmacen.SelectedValue
        Dim preciosConIMP As Boolean = False
        dsStockG = mCatalogo.recuperaSaldos_Integrado(es_historial, periodo, True, es_xAlmacen, cAlmacen, False, "", False, "", preciosConIMP, False, "", pDecimales, True, False)
        dataStockG.DataSource = ""
        dataStockG.DataSource = dsStockG.Tables("saldo").DefaultView
        'estructuraSaldos()
    End Sub
    Sub estructuraSaldos()
        With dataStock
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_art").HeaderText = "Código"
            .Columns("cod_art").Width = 55
            .Columns("cod_art").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("nom_art").HeaderText = "Descripción"
            .Columns("nom_art").Width = 230
            .Columns("nom_uni").HeaderText = "Unidad"
            .Columns("nom_uni").Width = 60
            .Columns("precio").HeaderText = "Costo"
            .Columns("precio").Width = 70
            .Columns("precio").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("saldo").HeaderText = "Stock"
            .Columns("saldo").Width = 70
            .Columns("saldo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("monto").HeaderText = "Monto"
            .Columns("monto").Width = 70
            .Columns("monto").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
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
        End With
    End Sub
    Sub muestraDocumentosIngreso()
        dsDocumentosIng.Clear()
        If dataStock.Rows.Count > 0 Then
            Dim mIngreso As New Ingreso
            Dim cod_art As String = dataStock("cod_art", dataStock.CurrentRow.Index).Value
            If Len(cod_art) > 0 Then
                dsDocumentosIng = mIngreso.recDocumentos(cod_art, True)
                dataDocumentos.DataSource = dsDocumentosIng.Tables("ingreso").DefaultView
            End If
            estructuraDocumentosIng()
        End If
    End Sub
    Sub estructuraDocumentosIng()
        With dataDocumentos
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("doc").HeaderText = "Documento"
            .Columns("doc").Width = 100
            .Columns("doc").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("raz_soc").HeaderText = "Proveedor"
            .Columns("raz_soc").Width = 251
            .Columns("fec_doc").HeaderText = "Fecha"
            .Columns("fec_doc").Width = 70
            .Columns("operacion").Visible = False
            .Columns("documento").Visible = False
        End With
    End Sub
    Private Sub optCantidades_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optCantidades.CheckedChanged
        If optCantidades.Checked = True Then
            muestraResumen()
        End If
    End Sub
    Private Sub optValorizado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optValorizado.CheckedChanged
        If optValorizado.Checked Then
            muestraResumen()
        End If
    End Sub
    Sub muestraResumen()
        Dim mResumen As New Resumen, periodo As Integer, saldo As Decimal = 0.0
        Dim dsSaldos As New DataSet
        Dim mCatalogo As New Catalogo
        Dim valor As String = IIf(optValorizado.Checked = True, "cant*precio", "cant")
        dataResumen.DataSource = ""
        dataResumen.Refresh()
        'Dim es_historial As Boolean
        Dim es_xAlmacen As Boolean = IIf(cboAlmacen.SelectedIndex >= 0, True, False)
        Dim es_xsubgrupo As Boolean = IIf(cbosubgrupo.SelectedIndex >= 0, True, False)
        Dim cAlmacen As String = cboAlmacen.SelectedValue
        Dim csubgrupo As String = cbosubgrupo.SelectedValue
        Dim preciosConIMP As Boolean = False
        barraProgreso.Visible = True
        barraProgreso.Value = 0
        periodo = cboAnno.SelectedIndex + 2005
        dsResumen = mResumen.recuperaCatalogo_paraResumenAnual(True, "0000", periodo, valor, True)
        dataResumen.DataSource = dsResumen.Tables("articulo").DefaultView
        estructuraResumen()
        barraProgreso.Value = 7.5
        ''cargamos los saldos, mes x mes
        'For I = 1 To 12
        '    periodo = Trim(Str(cboAnno.SelectedIndex + 2005)) & Microsoft.VisualBasic.Right("00" & Trim(Str(I)), 2)
        '    es_historial = IIf(periodo = periodoActivo(), False, True)
        '    Dim codigo As String = "", mes As String = ""
        '    For X = 0 To dataResumen.RowCount - 1
        '        mes = "m" & I
        '        codigo = dataResumen("cod_art", X).Value
        '        saldo = mCatalogo.recuperaStockArticulo(es_historial, periodo, False, False, "", codigo, 0)
        '        dataResumen(mes, X).Value = saldo
        '    Next
        '    barraProgreso.Value = 7.5 * (I + 1)
        'Next
        barraProgreso.Value = 100
        dataResumen.Refresh()
        barraProgreso.Visible = False
    End Sub
    Sub estructuraResumen()
        With dataResumen
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_art").HeaderText = "Código"
            .Columns("cod_art").Width = 45
            .Columns("cod_art").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("nom_art").HeaderText = "Descripción"
            .Columns("nom_art").Width = 220
            .Columns("nom_uni").HeaderText = "Unidad"
            .Columns("nom_uni").Width = 50
            .Columns("m1").HeaderText = "Enero"
            .Columns("m1").Width = 55
            .Columns("m1").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("m2").HeaderText = "Febrero"
            .Columns("m2").Width = 55
            .Columns("m2").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("m3").HeaderText = "Marzo"
            .Columns("m3").Width = 55
            .Columns("m3").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("m4").HeaderText = "Abril"
            .Columns("m4").Width = 55
            .Columns("m4").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("m5").HeaderText = "Mayo"
            .Columns("m5").Width = 55
            .Columns("m5").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("m6").HeaderText = "Junio"
            .Columns("m6").Width = 55
            .Columns("m6").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("m7").HeaderText = "Julio"
            .Columns("m7").Width = 55
            .Columns("m7").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("m8").HeaderText = "Agosto"
            .Columns("m8").Width = 55
            .Columns("m8").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("m9").HeaderText = "Set."
            .Columns("m9").Width = 55
            .Columns("m9").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("m10").HeaderText = "Octubre"
            .Columns("m10").Width = 55
            .Columns("m10").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("m11").HeaderText = "Nov."
            .Columns("m11").Width = 55
            .Columns("m11").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("m12").HeaderText = "Dic."
            .Columns("m12").Width = 55
            .Columns("m12").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("total").Visible = False
        End With
    End Sub
    Private Sub optCodigo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optCodigo.CheckedChanged
        txtBuscar.Focus()
    End Sub
    Private Sub optDescripcion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optDescripcion.CheckedChanged
        txtBuscar.Focus()
    End Sub
    Private Sub txtBuscar_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscar.GotFocus
        txtBuscar.SelectAll()
    End Sub
    Private Sub txtBuscar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBuscar.KeyDown
        If e.KeyCode = Keys.Enter Then
            dataStock.Focus()
        End If
    End Sub
    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged
        Dim valor As String = txtBuscar.Text
        If tabStock.IsSelected Then
            If optCodigo.Checked = True Then
                dsSaldos.Tables("saldo").DefaultView.RowFilter = "cod_art LIKE '" & valor & "%'"
            Else
                dsSaldos.Tables("saldo").DefaultView.RowFilter = "nom_art LIKE '" & valor & "%'"
            End If
            If dataStock.RowCount > 0 Then
                dataStock.CurrentCell = dataStock("cod_art", dataStock.CurrentRow.Index)
            End If
        Else
            If tabResumen.IsSelected Then
                If optCantidades.Checked = True Or optValorizado.Checked = True Then
                    If optCodigo.Checked = True Then
                        dsResumen.Tables("articulo").DefaultView.RowFilter = "cod_art LIKE '" & valor & "%'"
                    Else
                        dsResumen.Tables("articulo").DefaultView.RowFilter = "nom_art LIKE '" & valor & "%'"
                    End If
                    If dataResumen.RowCount > 0 Then
                        dataResumen.CurrentCell = dataResumen("cod_art", dataResumen.CurrentRow.Index)
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        Dim periodo As String = periodoSeleccionado()
        Dim fechaReporte As String = ""
        Dim periodoReporte As String = "Periodo: " & general.periodo_mesAnnoLetras(periodo)
        Dim frm As New rptForm, lPreciosIMP As String
        Dim esValorizado As Boolean = IIf(chkResumen.Checked = True, True, False)
        lPreciosIMP = "*Costos NO Incluyen Impuesto"
        If cboAlmacen.SelectedIndex >= 0 Then
            frm.cargarSaldos(dsSaldos, cboAlmacen.Text & "-" & cbosubgrupo.Text, fechaReporte, periodoReporte, lPreciosIMP, esValorizado, pMoneda, pTC)
        Else
            frm.cargarSaldos(dsSaldos, "INTEGRADO" & "-" & cbosubgrupo.Text, fechaReporte, periodoReporte, lPreciosIMP, esValorizado, pMoneda, pTC)
        End If
        frm.MdiParent = principal
        frm.Show()
    End Sub
    Private Sub tabStock_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tabStock.Click
        txtBuscar.Text = ""
        optDescripcion.Checked = True
    End Sub
    Private Sub tabStockG_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tabStockG.Click
        muestraStockG()
    End Sub
    Private Sub tabResumen_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tabResumen.Click
        txtBuscar.Text = ""
        optDescripcion.Checked = True
    End Sub
    Private Sub cmdCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCerrar.Click
        Me.Close()
    End Sub

    Private Sub dataStock_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataStock.CellContentClick

    End Sub

    Private Sub btnprocesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprocesar.Click
        Dim cod_art As String, i As Integer
        Dim mprecio As New ePrecio
        If dataStock.RowCount > 0 Then
            For i = 0 To dataStock.RowCount - 1
                cod_art = dataStock("cod_art", i).Value
                mprecio.actualizaPrecioPromedio(cod_art)
                btnprocesar.Text = dataStock("nom_art", i).Value
                btnprocesar.Refresh()
            Next
        End If
        btnprocesar.Text = "Recalcular Costo de Insumos"
        btnprocesar.Refresh()
        muestraSaldos()
    End Sub

    Private Sub dataStockG_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataStockG.CellContentClick

    End Sub

    Private Sub dataStockG_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dataStockG.KeyDown
     
    End Sub

    Private Sub chksaldo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chksaldo.CheckedChanged
        If chksaldo.Checked Then
            chksaldo.Text = "Articulos con Saldo"
        Else
            chksaldo.Text = "Articulos sin Saldo"
        End If
        If Not estaCargando Then
            muestraSaldos()
        End If
    End Sub

    Private Sub chkArea_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkArea.CheckedChanged
        If Not estaCargando Then
            If chkArea.Checked = True Then
                cboArea.SelectedIndex = 0
                cboArea.Enabled = True
            Else
                cboArea.SelectedIndex = -1
                cboArea.Enabled = False
            End If
            muestraSaldos()
            dataStock.Focus()
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

        End With
    End Sub

    Private Sub cboArea_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboArea.SelectedIndexChanged
        If Not estaCargando Then
            muestraSaldos()
        End If
    End Sub

    Private Sub cmdPromedio_Click(sender As Object, e As EventArgs) Handles cmdPromedio.Click

        'iniciatimer()
        actualizastock()



    End Sub
    Sub iniciatimer()


        myTimer.Interval = 10000
        myTimer.Start()

        ' Runs the timer, and raises the event.
        While exitFlag = False
            ' Processes all the events in the queue.
            Application.DoEvents()
        End While

    End Sub
    Sub actualizastock()
        Dim mCatalogo As New Catalogo
        Dim I, X, nroReg As Integer

        Dim cod_art As String
        Dim stock As Decimal
        Dim cAlmacen As String = cboAlmacen.SelectedValue
        If dataStock.RowCount > 0 Then
            nroReg = dataStock.RowCount
            For I = 0 To nroReg - 1

                cod_art = dataStock.Item("cod_art", I).Value
                stock = dataStock.Item("saldo", I).Value

                mCatalogo.actualizaCantidad_stock(cod_art, stock)
                mCatalogo.actualizaCantidad_stockAlmacen(cAlmacen, cod_art, stock)

                cmdPromedio.Text = X & " de " & nroReg
                X = X + 1
                cmdPromedio.Refresh()

            Next
            cmdPromedio.Text = "Actualiza Stock"

            MessageBox.Show("Proceso Terminado...", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

    End Sub



End Class
