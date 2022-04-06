Imports MySql.Data.MySqlClient
Imports libreriaClases
Public Class c_nivelesAbastecimiento
    Private dsAlmacen As New DataSet
    Private dsNivelAba As New DataSet
    Private dsArea As New DataSet
    Private dsProductos As New DataSet
    Private dsproduccion As New DataSet
    Private dsNiveles As New DataSet
    Private dsUnidad As New DataSet

    Private estaCargando As Boolean = True
    Private Sub c_nivelesAbastecimiento_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        principal.mr_niveles.Enabled = True
    End Sub
    Private Sub c_nivelesAbastecimiento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Top = 0
        Me.Left = 0
        '
        dtiHasta.MaxDate = pFechaSystem
        dtiHasta.MinDate = pFechaActivaMin
        If Month(pFechaActivaMax) = Month(pFechaSystem) Then
            dtiHasta.Value = pFechaSystem
        Else
            dtiHasta.Value = pFechaActivaMax
        End If
        dsNiveles = nivAbastecimiento.dsNiveles
        estructuraNiveles()
        'dataset almacen
        Dim cadAlma As String = ""
        If pAlmaUser = "0000" Then
            cadAlma = "select cod_alma,nom_alma from almacen where activo=1 and (esCatalogo)"
        Else
            cadAlma = "select cod_alma,nom_alma from almacen where cod_alma='" _
                    & pAlmaUser & "' and (esCatalogo) and activo=1"
        End If
        Dim daAlmacen As New MySqlDataAdapter
        Dim comAlmacen As New MySqlCommand(cadAlma, dbConex)
        daAlmacen.SelectCommand = comAlmacen
        daAlmacen.Fill(dsAlmacen, "almacen")
        With cboAlmacen
            .DataSource = dsAlmacen.Tables("almacen")
            .DisplayMember = dsAlmacen.Tables("almacen").Columns("nom_alma").ToString
            .ValueMember = dsAlmacen.Tables("almacen").Columns("cod_alma").ToString
            If dsAlmacen.Tables("almacen").Rows.Count > 0 Then
                .SelectedIndex = 0
            End If
        End With
        'dataset sub grupo
        Dim cCampo As String = "nom_sgrupo"
        'dtSGrupo = dsProduccion.Tables("subgrupo")
        Dim daSGrupo As New MySqlDataAdapter
        Dim comSGrupo As New MySqlCommand("select cod_sgrupo," & general.convierte_enTitulo(cCampo) _
            & " as nom_sgrupo from subgrupo where activo=1 and (!esProduccion) order by nom_sgrupo", dbConex)
        daSGrupo.SelectCommand = comSGrupo
        daSGrupo.Fill(dsProduccion, "subgrupo")
        With cboGrupo
            .DataSource = dsProduccion.Tables("subgrupo")
            .DisplayMember = dsProduccion.Tables("subgrupo").Columns("nom_sgrupo").ToString
            .ValueMember = dsProduccion.Tables("subgrupo").Columns("cod_sgrupo").ToString
            If dsProduccion.Tables("subgrupo").Rows.Count > 0 Then
                .SelectedIndex = -1
            End If
        End With
        'dataset unidad
        Dim daUnidad As New MySqlDataAdapter
        Dim comUnidad As New MySqlCommand("select cod_uni,nom_uni from unidad  where activo=1 and esProduccion order by nom_uni", dbConex)
        daUnidad.SelectCommand = comUnidad
        daUnidad.Fill(dsUnidad, "unidad")
        With cboUnidad
            .DataSource = dsunidad.Tables("unidad")
            .DisplayMember = dsunidad.Tables("unidad").Columns("nom_uni").ToString
            .ValueMember = dsunidad.Tables("unidad").Columns("cod_uni").ToString
            .SelectedIndex = -1
        End With
        'dataset niveles de abastecimiento
        Dim daNiveles As New MySqlDataAdapter
        Dim comNiveles As New MySqlCommand("select cod_nivel,nom_nivel from niveles_aba where activo=1 order by cod_nivel", dbConex)
        daNiveles.SelectCommand = comNiveles
        daNiveles.Fill(dsNivelAba, "niveles")
        With cboNiveles
            .DataSource = dsNivelAba.Tables("niveles")
            .DisplayMember = dsNivelAba.Tables("niveles").Columns("nom_nivel").ToString
            .ValueMember = dsNivelAba.Tables("niveles").Columns("cod_nivel").ToString
            .SelectedIndex = 0
        End With

        muestraAreas()
        estaCargando = False

    End Sub

    Sub muestraAreas()
        dsArea.Clear()
        Dim daArea As New MySqlDataAdapter
        Dim cad As String = "Select cod_area,nom_area from area where cod_alma='" _
                        & cboAlmacen.SelectedValue & "' and (tieneIdeales) and activo=1 order by nom_area"
        Dim comArea As New MySqlCommand(cad, dbConex)
        daArea.SelectCommand = comArea
        daArea.Fill(dsArea, "area")
        With cboArea
            .DataSource = dsArea.Tables("area")
            .DisplayMember = dsArea.Tables("area").Columns("nom_area").ToString
            .ValueMember = dsArea.Tables("area").Columns("cod_area").ToString
            If dsArea.Tables("area").Rows.Count > 0 Then
                .SelectedIndex = 0
            Else
                .SelectedIndex = -1
            End If
        End With
    End Sub
    Private Sub optGeneral_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optGeneral.CheckedChanged
        lblMaximos.Visible = False
        If optGeneral.Checked = True Then
            cboAlmacen.SelectedIndex = -1
            cboAlmacen.Enabled = False
        End If
  
    End Sub
    Private Sub optAlmacen_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optAlmacen.CheckedChanged
        If optAlmacen.Checked = True Then
            cboAlmacen.Enabled = True
            cboAlmacen.Focus()
        End If
        If Not estaCargando Then
            Dim mNiveles As New nivAbastecimiento
            If mNiveles.existeNivAlmacen Then
                lblMaximos.Visible = False
            Else
                lblMaximos.Visible = True
            End If
        End If
    End Sub
    Private Sub cboAlmacen_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboAlmacen.GotFocus
        If dsAlmacen.Tables("almacen").Rows.Count > 0 Then
            If cboAlmacen.SelectedIndex = -1 Then
                cboAlmacen.SelectedIndex = 0
            End If
        End If
    End Sub
    Private Sub cboAlmacen_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboAlmacen.SelectedIndexChanged
        If Not estaCargando Then
            muestraAreas()
            If chkarea.Checked = True Then
                cboArea.Enabled = True
                If dsArea.Tables("area").Rows.Count > 0 Then
                    cboArea.SelectedIndex = 0
                End If
            Else
                cboArea.SelectedIndex = -1
                cboArea.Enabled = False
            End If
        End If
    End Sub
    Private Sub cboniveles_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboNiveles.GotFocus
        If dsNivelAba.Tables("niveles").Rows.Count > 0 Then
            If cboNiveles.SelectedIndex = -1 Then
                cboNiveles.SelectedIndex = 0
            End If
        End If
    End Sub
    Private Sub cboniveles_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboNiveles.SelectedIndexChanged

    End Sub
    Private Sub txtBuscar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBuscar.KeyDown
        If e.KeyCode = Keys.Enter Then
            'dataDetalle.Focus()
        End If
    End Sub
    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged
        Dim valor As String = txtBuscar.Text
        If optCodigo.Checked = True Then
            dsNiveles.Tables("niveles").DefaultView.RowFilter = "cod_art LIKE '" & valor & "%'"
            If dataDetalle.RowCount > 0 Then
                dataDetalle.CurrentCell = dataDetalle("cod_art", dataDetalle.CurrentRow.Index)
            End If
        Else
            dsNiveles.Tables("niveles").DefaultView.RowFilter = "nom_art LIKE '" & valor & "%'"
            If dataDetalle.RowCount > 0 Then
                dataDetalle.CurrentCell = dataDetalle("nom_art", dataDetalle.CurrentRow.Index)
            End If
        End If
    End Sub
    Sub muestraNiveles()
        Dim mNiveles As New nivAbastecimiento, mAlmacen As New Almacen, I As Integer, cod_art, nom_uni As String
        Dim mCatalogo As New Catalogo, nStock, nCompras, nIngresos, nSalidas, nStockIni, nMinimo, nMaximo, nReq As New Decimal
        Dim mIngreso As New Ingreso, mSalida As New Salida
        Dim cNivel As String = cboNiveles.SelectedValue
        Dim xGrupo As Boolean = IIf(cboGrupo.SelectedIndex = -1, False, True)
        Dim csgrupo As String = cboGrupo.SelectedValue
        Dim xUnidad As Boolean = IIf(chkUnidad.Checked = True, True, False)
        Dim cUnidad As String = cboUnidad.SelectedValue
        Dim cAlmacen As String
        Dim xArea As Boolean = IIf(chkarea.Checked = True, True, False)
        Dim cArea As String = cboArea.SelectedValue
        Dim cProduc As Boolean = IIf(chkProduccion.Checked = True, False, True)
        Dim linicial, lingreso, lsalida As Decimal
        Dim preciosConIMP As Boolean = False
        Dim fechaInicio As Date = dtiHasta.Value.AddDays(0)
        Dim fechaProceso, fec_ultcom As Date
        dsNiveles.Clear()
        dsProductos.Clear()

        cAlmacen = cboAlmacen.SelectedValue

        
        dsProductos = mNiveles.recuperaProductos_paraNiveles(pCatalogoXalmacen, cAlmacen, cProduc, xGrupo, csgrupo, IIf(cNivel = "04", True, False), _
                                                              xArea, cArea, xUnidad, cUnidad, preciosConIMP, general.str_PrecioCostoCI)

        If cboArea.SelectedValue = "" Then
            xArea = False
            cArea = ""
        Else
            cArea = cboArea.SelectedValue
        End If

        If dsProductos.Tables("articulo").Rows.Count > 0 Then
            For I = 0 To dsProductos.Tables("articulo").Rows.Count - 1
                cod_art = dsProductos.Tables("articulo").Rows(I).Item("cod_art").ToString
                nMinimo = dsProductos.Tables("articulo").Rows(I).Item("minimo").ToString
                nMaximo = dsProductos.Tables("articulo").Rows(I).Item("maximo").ToString
                nom_uni = dsProductos.Tables("articulo").Rows(I).Item("nom_uni").ToString

                Dim fila As DataRow = dsNiveles.Tables("niveles").NewRow
                fila.Item("cod_art") = cod_art
                fila.Item("nom_art") = dsProductos.Tables("articulo").Rows(I).Item("nom_art").ToString
                fila.Item("nom_uni") = nom_uni
                fila.Item("pre_costo") = dsProductos.Tables("articulo").Rows(I).Item("pre_costo").ToString
                fila.Item("minimo") = nMinimo
                fila.Item("maximo") = nMaximo
                fila.Item("nivel") = cboNiveles.Text
                fila.Item("nom_sgrupo") = dsProductos.Tables("articulo").Rows(I).Item("nom_sgrupo").ToString
                fila.Item("raz_soc") = dsProductos.Tables("articulo").Rows(I).Item("raz_soc").ToString


                'fechaProceso = IIf(Microsoft.VisualBasic.DateAndTime.Day(fechaInicio) = 1, fechaInicio, Microsoft.VisualBasic.DateAndTime.DateAdd(DateInterval.Day, -1, fechaInicio))
                fechaProceso = Microsoft.VisualBasic.DateAndTime.DateAdd(DateInterval.Day, -1, fechaInicio)
                lingreso = mIngreso.recuperaTotalIngresosArticulo(False, "", fechaProceso, True, cAlmacen, xArea, cArea, cod_art)
                lsalida = mSalida.recuperaTotalSalidasArticulo(False, "", IIf(cNivel = "04", fechaProceso.AddDays(-1), fechaProceso), True, cAlmacen, xArea, cArea, cod_art)
                linicial = mIngreso.recuperaInicialArticulo(False, "", fechaProceso, True, cAlmacen, xArea, cArea, cod_art)
                If Microsoft.VisualBasic.DateAndTime.Day(fechaInicio) = 1 Then
                    'nStockIni = linicial
                    nStockIni = lingreso - lsalida
                Else
                    nStockIni = lingreso - lsalida
                End If
                fechaProceso = fechaInicio

                nIngresos = mIngreso.recuperaSaldoIngresosArticulo(False, "", fechaProceso, True, cAlmacen, xArea, cArea, cod_art)
                nSalidas = mSalida.recuperaSaldoSalidasArticulo(False, "", IIf(cNivel = "04", fechaProceso.AddDays(-1), fechaProceso), True, cAlmacen, xArea, cArea, cod_art)
                nStock = nStockIni + nIngresos - nSalidas
                fila.Item("saldo") = nStock
                If cNivel = "01" And nStock < nMinimo Then

                    nReq = nMaximo - nStock
                    fila.Item("stockini") = nStockIni
                    fila.Item("Ingresos") = nIngresos
                    fila.Item("Salidas") = nSalidas
                    fila.Item("req") = nReq
                    fila.Item("reqAlmacen") = CalculaRequerimientoAlmacen(cod_art, nReq)
                    fila.Item("nom_uniAlma") = ObtieneUnidadAlmacen(cod_art, nom_uni)
                    dsNiveles.Tables("niveles").Rows.Add(fila)
                Else
                    If cNivel = "02" And nStock >= nMinimo And nStock < nMaximo Then

                        fila.Item("stockini") = nStockIni
                        fila.Item("Ingresos") = nIngresos
                        fila.Item("Salidas") = nSalidas
                        fila.Item("req") = 0
                        dsNiveles.Tables("niveles").Rows.Add(fila)
                    Else
                        If cNivel = "03" And nStock >= nMaximo Then

                            fila.Item("stockini") = nStockIni
                            fila.Item("Ingresos") = nIngresos
                            fila.Item("Salidas") = nSalidas
                            fila.Item("req") = 0
                            dsNiveles.Tables("niveles").Rows.Add(fila)
                        Else

                            If cNivel = "04" And (nIngresos > 0 Or nSalidas > 0) Then

                                fila.Item("stockini") = nStockIni
                                fila.Item("Ingresos") = nIngresos
                                fila.Item("Salidas") = nSalidas
                                fila.Item("req") = 0
                                dsNiveles.Tables("niveles").Rows.Add(fila)
                            Else
                                If cNivel = "05" Then
                                    fec_ultcom = IIf(IsDBNull(dsProductos.Tables("articulo").Rows(I).Item("fec_ultcom")), Nothing, dsProductos.Tables("articulo").Rows(I).Item("fec_ultcom"))
                                    nIngresos = mIngreso.recuperaSaldoIngresosArticulo_t1(False, "", fechaProceso, True, cAlmacen, cod_art)
                                    nCompras = mIngreso.recComp_ingresoArticulo(True, "", False, fec_ultcom, False, cAlmacen, cod_art)
                                    nCompras = nCompras + mIngreso.recComp_ingresoArticulo(False, "", False, fec_ultcom, False, cAlmacen, cod_art)
                                    nSalidas = mSalida.recuperaSaldoSalidasArticulo_t1(True, "", fec_ultcom, False, cAlmacen, cod_art)
                                    nSalidas = nSalidas + mSalida.recuperaSaldoSalidasArticulo_t1(False, "", fec_ultcom, False, cAlmacen, cod_art)
                                    fila.Item("stockini") = 0
                                    fila.Item("Ingresos") = nCompras
                                    fila.Item("Salidas") = nSalidas
                                    fila.Item("fec_ultcom") = dsProductos.Tables("articulo").Rows(I).Item("fec_ultcom")
                                    fila.Item("saldo") = nCompras - nSalidas
                                    fila.Item("req") = nSalidas
                                    fila.Item("reqAlmacen") = CalculaRequerimientoAlmacen(cod_art, nReq)
                                    fila.Item("nom_uniAlma") = ObtieneUnidadAlmacen(cod_art, nom_uni)
                                    dsNiveles.Tables("niveles").Rows.Add(fila)
                                End If
                            End If
                        End If
                    End If
                End If

            Next
        End If
        dataDetalle.DataSource = dsNiveles.Tables("niveles").DefaultView
        lblRegistros.Text = "Nº de Registros Procesados... " & dataDetalle.RowCount.ToString
        'estructuraNiveles()
    End Sub
    Sub estructuraNiveles()
        With dataDetalle
            .ReadOnly = True
            .DataSource = dsNiveles.Tables("niveles")
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_art").HeaderText = "Código"
            .Columns("cod_art").Width = 60
            .Columns("cod_art").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("nom_art").HeaderText = "Descripción"
            .Columns("nom_art").Width = 260
            .Columns("nom_uni").HeaderText = "Unidad"
            .Columns("nom_uni").Width = 60
            .Columns("pre_costo").HeaderText = "Costo"
            .Columns("pre_costo").Width = 60
            .Columns("pre_costo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("StockIni").HeaderText = "Stock Inicial"
            .Columns("StockIni").Width = 65
            .Columns("StockIni").DefaultCellStyle.BackColor = Color.AliceBlue
            .Columns("StockIni").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("Ingresos").HeaderText = "Ingresos"
            .Columns("Ingresos").Width = 65
            .Columns("Ingresos").DefaultCellStyle.BackColor = Color.AliceBlue
            .Columns("Ingresos").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("Salidas").HeaderText = "Salidas"
            .Columns("Salidas").Width = 65
            .Columns("Salidas").DefaultCellStyle.BackColor = Color.AliceBlue
            .Columns("Salidas").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("saldo").HeaderText = "Stock Final"
            .Columns("saldo").Width = 65
            .Columns("saldo").DefaultCellStyle.BackColor = Color.AliceBlue
            .Columns("saldo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("minimo").HeaderText = "Mínimo"
            .Columns("minimo").Width = 55
            .Columns("minimo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("maximo").HeaderText = "Máximo"
            .Columns("maximo").Width = 55
            .Columns("maximo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("nivel").HeaderText = "Nivel"
            .Columns("nivel").Width = 80
            .Columns("nivel").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns("req").HeaderText = "Req."
            .Columns("req").Width = 55
            .Columns("req").DefaultCellStyle.BackColor = Color.AliceBlue
            .Columns("req").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("reqAlmacen").HeaderText = "Req. Almacen"
            .Columns("reqAlmacen").Width = 55
            .Columns("reqAlmacen").DefaultCellStyle.BackColor = Color.Cornsilk
            .Columns("reqAlmacen").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("nom_uniAlma").HeaderText = "Unidad Almacen"
            .Columns("nom_uniAlma").Width = 60
            .Columns("nom_uniAlma").DefaultCellStyle.BackColor = Color.Cornsilk
            .Columns("nom_uniAlma").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns("raz_soc").Visible = False
            .Columns("pre_ult").Visible = False
            .Columns("cod_sgrupo").Visible = False
            .Columns("nom_sgrupo").Visible = False
            .Columns("raz_soc").Visible = False
        End With
    End Sub
    Sub coloreaSubStock()
        Dim I As Integer = 0
        If dsNiveles.Tables("niveles").Rows.Count > 0 Then
            For I = 0 To dsNiveles.Tables("niveles").Rows.Count - 1
                dataDetalle.CurrentCell = dataDetalle("nivel", I)
                If Not IsDBNull(dataDetalle("nivel", I).Value) Then
                    If dataDetalle("nivel", I).Value = "Sub Stock" Then
                        dataDetalle.CurrentRow.DefaultCellStyle.ForeColor = Color.Red
                    End If
                End If
            Next
            dataDetalle.CurrentCell = dataDetalle("cod_art", 0)
        End If
    End Sub
    Function CalculaRequerimientoAlmacen(ByVal cod_art As String, ByVal cantidad As Decimal)
        Dim mAlmacen As New Almacen, munidad As New Unidad
        Dim cod_artRel As String, cod_unirel As String, cod_unirelO As String, cant_unirel As Decimal, es_div As Boolean
        cod_artRel = mAlmacen.devuelveCodigoArtPrinRelacionado(cod_art)
        cod_unirel = munidad.devuelveUnidad(cod_artRel)
        cod_unirelO = munidad.devuelveUnidad(cod_art)
        cant_unirel = munidad.devuelveCantUnidad(cod_unirel)
        es_div = munidad.esDivisible(cod_unirelO)
        'If es_div And (cant_unirel > 0 And cant_unirel <> 1) Then
        If es_div And (cant_unirel > 0) Then
            cantidad = Math.Round((cantidad / cant_unirel), 0)
        End If
        Return cantidad
    End Function
    Function ObtieneUnidadAlmacen(ByVal cod_art As String, ByVal nom_uni As String)
        Dim mAlmacen As New Almacen, munidad As New Unidad
        Dim cod_artRel As String, nom_unirel As String
        cod_artRel = mAlmacen.devuelveCodigoArtPrinRelacionado(cod_art)
        nom_unirel = munidad.devuelveNombreUnidad(cod_artRel)
        If nom_unirel <> "" Then
            nom_uni = nom_unirel
        End If
        Return nom_uni
    End Function

    Private Sub cmdCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCerrar.Click
        Me.Close()
    End Sub
    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        Dim periodo As String = periodoActivo()
        Dim periodoReporte As String = "Periodo: " & general.periodo_mesAnnoLetras(periodo)
        Dim lAlmacen As String = IIf(cboAlmacen.SelectedIndex >= 0, cboAlmacen.Text, "Integrado")
        Dim lPreciosConIMP As String = "*Precios Incluyen Impuesto"
        Dim fechaReporte As String = general.devuelveFechaImpresionEspecificado(dtiHasta.Value)
        Dim frm As New rptForm
        frm.cargarNiveles(dsNiveles, fechaReporte, periodoReporte, _
                IIf(cboNiveles.SelectedIndex >= 0, cboNiveles.Text & " - ", "") & lAlmacen, lPreciosConIMP, IIf(cboNiveles.SelectedValue = "04", 2, 1))
        frm.MdiParent = principal
        frm.Show()
    End Sub

    Private Sub dtiHasta_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtiHasta.ValueChanged

    End Sub

    Private Sub dtiHasta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtiHasta.Click

    End Sub

    Private Sub dataDetalle_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataDetalle.CellContentClick

    End Sub

    Private Sub dataDetalle_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dataDetalle.KeyDown
        If (e.Control And e.KeyCode = Keys.E) Then
            If dataDetalle.RowCount > 0 Then
                EnviaraExcel(dataDetalle)
            End If
        End If
    End Sub

    Private Sub chkGrupo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGrupo.CheckedChanged
        If Not estaCargando Then
            If chkGrupo.Checked = True Then
                cboGrupo.Enabled = True
                cboGrupo.SelectedIndex = 0
            Else
                cboGrupo.Enabled = False
                cboGrupo.SelectedIndex = -1
            End If
        End If
    End Sub

    Private Sub cboGrupo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboGrupo.SelectedIndexChanged

    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        If Not estaCargando Then
            muestraNiveles()
        End If
    End Sub

    Private Sub chkarea_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkarea.CheckedChanged
        If Not estaCargando Then
            If chkarea.Checked = True Then
                cboArea.Enabled = True
                If dsArea.Tables("area").Rows.Count > 0 Then
                    cboArea.SelectedIndex = 0
                End If
                cboArea.Focus()
            Else
                cboArea.SelectedIndex = -1
                cboArea.Enabled = False

            End If
        End If
    End Sub

    Private Sub cboArea_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboArea.SelectedIndexChanged
     
    End Sub

    Private Sub chkProduccion_CheckedChanged(sender As Object, e As EventArgs) Handles chkProduccion.CheckedChanged
        If Not estaCargando Then
            If chkProduccion.CheckState = CheckState.Checked Then
                chkProduccion.Text = "Insumos"
            Else
                chkProduccion.Text = "Producciones"
            End If
            muestraNiveles()
            txtBuscar.Focus()
        End If
    End Sub

    Private Sub chkUnidad_CheckedChanged(sender As Object, e As EventArgs) Handles chkUnidad.CheckedChanged
        If Not estaCargando Then
            If chkUnidad.Checked = True Then
                cboUnidad.Enabled = True
                If dsUnidad.Tables("unidad").Rows.Count > 0 Then
                    cboUnidad.SelectedIndex = 0
                End If
                cboUnidad.Focus()
            Else
                cboUnidad.SelectedIndex = -1
                cboUnidad.Enabled = False
                dataDetalle.Focus()
            End If
        End If
    End Sub
End Class