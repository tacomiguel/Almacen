Imports MySql.Data.MySqlClient
Imports libreriaClases
Public Class repNivelesAbastecimiento
    Private dsAlmacen As New DataSet
    Private dsMermas As New DataSet
    Private dsGrupo As New DataSet
    Private dsTarticulo As New DataSet
    Private dsMotivoBaja As New DataSet

    '
    Private estaCargando As Boolean = True
    Private Sub repMermas_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        principal.mc_mermas.Enabled = True
    End Sub
    Private Sub repMermas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Top = 0
        Me.Left = 0
        dtiDesde.MaxDate = pFechaActivaMax
        dtiDesde.MinDate = pFechaActivaMin
        dtiHasta.MaxDate = pFechaActivaMax
        dtiHasta.MinDate = pFechaActivaMin
        If Month(pFechaActivaMax) = Month(pFechaSystem) Then
            dtiDesde.Value = pFechaSystem
            dtiHasta.Value = pFechaSystem
        End If
        Dim mes, anno As Integer
        mes = Month(pFechaActivaMax)
        anno = Year(pFechaActivaMax)
        cboMes.SelectedIndex = mes - 1
        cboAnno.SelectedIndex = anno - 2010
        'dataset almacen
        Dim daAlmacen As New MySqlDataAdapter
        Dim comAlmacen As New MySqlCommand("select cod_alma,nom_alma from almacen where activo=1" _
                                            & " and ((esCompras) or (destinoTrans))", dbConex)
        daAlmacen.SelectCommand = comAlmacen
        daAlmacen.Fill(dsAlmacen, "almacen")
        With cboAlmacen
            .DataSource = dsAlmacen.Tables("almacen")
            .DisplayMember = dsAlmacen.Tables("almacen").Columns("nom_alma").ToString
            .ValueMember = dsAlmacen.Tables("almacen").Columns("cod_alma").ToString
            .SelectedIndex = -1
        End With
        'dataset grupos
        Dim daGrupo As New MySqlDataAdapter
        Dim comGrupo As New MySqlCommand("select cod_sgrupo,nom_sgrupo from subgrupo where activo=1 order by nom_sgrupo", dbConex)
        daGrupo.SelectCommand = comGrupo
        daGrupo.Fill(dsGrupo, "grupo")
        With cboGrupo
            .DataSource = dsGrupo.Tables("grupo")
            .DisplayMember = dsGrupo.Tables("grupo").Columns("nom_sgrupo").ToString
            .ValueMember = dsGrupo.Tables("grupo").Columns("cod_sgrupo").ToString
            .SelectedIndex = -1
        End With
        'dataset TipoArticulo
        Dim daTarticulo As New MySqlDataAdapter
        Dim comTarticulo As New MySqlCommand("select cod_tart,nom_tart from tipo_articulo where activo", dbConex)
        daTarticulo.SelectCommand = comTarticulo
        daTarticulo.Fill(dsTarticulo, "tarticulo")
        With CboTipArt
            .DataSource = dsTarticulo.Tables("tarticulo")
            .DisplayMember = dsTarticulo.Tables("tarticulo").Columns("nom_tart").ToString
            .ValueMember = dsTarticulo.Tables("tarticulo").Columns("cod_tart").ToString
            .SelectedIndex = -1
        End With
        'dataset mermas
        Dim daMotivoBaja As New MySqlDataAdapter
        Dim comMotivoBaja As New MySqlCommand("select cod_baja,nom_baja from motivo_baja where activo=1 order by nom_baja", dbConex)
        daMotivoBaja.SelectCommand = comMotivoBaja
        daMotivoBaja.Fill(dsMotivoBaja, "motivoBaja")
        With cboMotivo
            .DataSource = dsMotivoBaja.Tables("motivoBaja")
            .DisplayMember = dsMotivoBaja.Tables("motivoBaja").Columns("nom_baja").ToString
            .ValueMember = dsMotivoBaja.Tables("motivoBaja").Columns("cod_baja").ToString
            .SelectedIndex = -1
        End With
        estaCargando = False
        muestraMermas()
    End Sub
    Private Sub cboMes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMes.SelectedIndexChanged
        estableceFechas()
        chkDia.CheckState = CheckState.Unchecked
        If Not estaCargando Then
            muestraMermas()
        End If
    End Sub
    Private Sub cboAnno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAnno.SelectedIndexChanged
        estableceFechas()
        chkDia.CheckState = CheckState.Unchecked
        If Not estaCargando Then
            muestraMermas()
        End If
    End Sub
    Private Sub chkDia_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDia.CheckedChanged
        estableceFechas()
        If chkDia.CheckState = CheckState.Checked Then
            dtiDesde.Enabled = True
            dtiHasta.Enabled = True
            estableceFechas()
        Else
            dtiDesde.Enabled = False
            dtiHasta.Enabled = False
        End If
        If Not estaCargando Then
            muestraMermas()
        End If
    End Sub
    Private Sub dtiDesde_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtiDesde.ValueChanged
        If Not estaCargando Then
            muestraMermas()
        End If
    End Sub
    Private Sub dtiHasta_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtiHasta.ValueChanged
        If Not estaCargando Then
            muestraMermas()
        End If
    End Sub
    Private Sub optIntegrado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optIntegrado.CheckedChanged
        If optIntegrado.Checked = True Then
            cboAlmacen.SelectedIndex = -1
            cboAlmacen.Enabled = False
            cboMotivo.SelectedIndex = -1
            cboMotivo.Enabled = False
        End If
        If Not estaCargando Then
            muestraMermas()
        End If
    End Sub
    Private Sub optAlmacen_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optAlmacen.CheckedChanged
        If optAlmacen.Checked = True Then
            cboAlmacen.Enabled = True
            cboAlmacen.SelectedIndex = 0
            cboAlmacen.Focus()
        End If
    End Sub
    Private Sub chkGrupo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGrupo.CheckedChanged
        If Not estaCargando Then
            If chkGrupo.Checked = True Then
                cboGrupo.Enabled = True
                cboGrupo.SelectedIndex = 0
                cboGrupo.Focus()
            Else
                cboGrupo.SelectedIndex = -1
                cboGrupo.Enabled = False
            End If
        End If
    End Sub
    Private Sub chkMotivo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMotivo.CheckedChanged
        If Not estaCargando Then
            If chkMotivo.Checked = True Then
                cboMotivo.Enabled = True
                cboMotivo.SelectedIndex = 0
                cboMotivo.Focus()
            Else
                cboMotivo.SelectedIndex = -1
                cboMotivo.Enabled = False
            End If
        End If
    End Sub
    Private Sub cboAlmacen_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboAlmacen.SelectedIndexChanged
        If Not estaCargando Then
            muestraMermas()
        End If
    End Sub
    Private Sub cboGrupo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboGrupo.SelectedIndexChanged
        If Not estaCargando Then
            muestraMermas()
        End If
    End Sub
    Private Sub cboMotivo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMotivo.SelectedIndexChanged
        If Not estaCargando Then
            muestraMermas()
        End If
    End Sub
    Private Sub chkAgrupar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAgrupar.CheckedChanged
        If Not estaCargando Then
            muestraMermas()
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
    Sub estableceFechas()
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
            dtiDesde.Value = pFechaActivaMin
            dtiHasta.ResetMaxDate()
            dtiHasta.MinDate = pFechaActivaMin
            dtiHasta.ResetMaxDate()
            dtiHasta.MaxDate = pFechaActivaMax
            dtiHasta.Value = pFechaActivaMax
        End If
    End Sub
    Function periodoSeleccionado()
        Dim periodo As String = Trim(Str(cboAnno.SelectedIndex + 2010)) & Microsoft.VisualBasic.Right("00" & Trim(Str(cboMes.SelectedIndex + 1)), 2)
        Return periodo
    End Function
    Sub muestraMermas()
        Dim mBajas As New Bajas, mAlmacen As New Almacen
        dsMermas.Clear()
        Dim periodo As String = periodoSeleccionado()
        Dim esHistorial As Boolean = IIf(periodo = general.periodoActivo(), False, True)
        Dim esMensual As Boolean = IIf(chkDia.Checked = False, True, False)
        Dim xAlmacen As Boolean = IIf(cboAlmacen.SelectedIndex >= 0, True, False)
        Dim cod_alma As String = mAlmacen.devuelveAlmacenCatalogo(cboAlmacen.SelectedValue)
        Dim xMotivo As Boolean = IIf(chkMotivo.Checked = True, True, False)
        Dim cMotivo As String = cboMotivo.SelectedValue
        Dim xGrupo As Boolean = IIf(chkGrupo.Checked = True, True, False)
        Dim cod_sgrupo As String = cboGrupo.SelectedValue
        Dim xtarticulo As Boolean = IIf(ChkTipArt.Checked = True, True, False)
        Dim cod_tarticulo As String = CboTipArt.SelectedValue
        Dim agrupar As Boolean = IIf(chkAgrupar.Checked = True, True, False)
        dsMermas = mBajas.recuperaBajasT(esHistorial, periodo, agrupar, esMensual, _
                    dtiDesde.Value, dtiHasta.Value, pDecimales, xAlmacen, _
                    cod_alma, False, xMotivo, cMotivo, xGrupo, cod_sgrupo, xtarticulo, cod_tarticulo)
        datadetall.DataSource = dsMermas.Tables("mermas").DefaultView
        lblRegistros.Text = "Nº de Registros... " & datadetall.RowCount.ToString
        estructuraBajas()
    End Sub
    Sub estructuraBajas()
        With datadetall
            .ReadOnly = True
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            If chkAgrupar.Checked = True Then
                .Columns("fec_doc").Visible = False
            Else
                .Columns("fec_doc").Visible = True
                .Columns("fec_doc").HeaderText = "Fecha"
                .Columns("fec_doc").Width = 70
                .Columns("fec_doc").DisplayIndex = 0
                .Columns("fec_doc").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            End If
            .Columns("cod_art").HeaderText = "Código"
            .Columns("cod_art").Width = 60
            .Columns("cod_art").DisplayIndex = 1
            .Columns("cod_art").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("nom_art").HeaderText = "Descripción"
            .Columns("nom_art").Width = 250
            .Columns("nom_art").DisplayIndex = 2
            .Columns("nom_uni").HeaderText = "Unidad"
            .Columns("nom_uni").Width = 60
            .Columns("nom_uni").DisplayIndex = 3
            .Columns("nom_uni").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cant").HeaderText = "Cantidad"
            .Columns("cant").Width = 60
            .Columns("cant").DisplayIndex = 4
            .Columns("cant").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("pre_costo").HeaderText = "Costo"
            .Columns("pre_costo").Width = 80
            .Columns("pre_costo").DisplayIndex = 5
            .Columns("pre_costo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("monto").HeaderText = "Monto"
            .Columns("monto").Width = 70
            .Columns("monto").DisplayIndex = 6
            .Columns("monto").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("nom_alma").HeaderText = "Almacen"
            .Columns("nom_alma").Width = 100
            .Columns("nom_alma").DisplayIndex = 7
            .Columns("nom_baja").HeaderText = "Motivo de Baja"
            .Columns("nom_baja").Width = 130
            .Columns("nom_baja").DisplayIndex = 8
            .Columns("nom_sgrupo").HeaderText = "Grupo"
            .Columns("nom_sgrupo").Width = 100
            .Columns("nom_sgrupo").DisplayIndex = 9
            .Columns("operacion").Visible = False
            .Columns("salida").Visible = False
            .Columns("doc").Visible = False
            .Columns("ser_doc").Visible = False
            .Columns("nro_doc").Visible = False
            .Columns("cod_sgrupo").Visible = False

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
            datadetall.Focus()
        End If
    End Sub
    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged
        Dim valor As String = txtBuscar.Text
        If optCodigo.Checked = True Then
            dsMermas.Tables("mermas").DefaultView.RowFilter = "cod_art LIKE '" & valor & "%'"
            If datadetall.RowCount > 0 Then
                datadetall.CurrentCell = datadetall("cod_art", datadetall.CurrentRow.Index)
            End If
        Else
            dsMermas.Tables("mermas").DefaultView.RowFilter = "nom_art LIKE '" & valor & "%'"
            If datadetall.RowCount > 0 Then
                datadetall.CurrentCell = datadetall("nom_art", datadetall.CurrentRow.Index)
            End If
        End If
    End Sub
    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        Dim frm As New rptForm
        Dim fechaReporte As String
        Dim xResum As Boolean = IIf(ChkResumen.Checked = True, True, False)
        'capturamos la fecha  o rango de fechas del reporte
        If chkDia.Checked = False Then
            If dtiHasta.Value > pFechaSystem Then
                fechaReporte = general.devuelveFechaImpresionSistema
            Else
                fechaReporte = "Al: " & general.devuelveFechaImpresionEspecificado(dtiHasta.Value)
            End If
        Else
            If dtiHasta.Value > pFechaSystem Then
                If Microsoft.VisualBasic.DateAndTime.Day(dtiDesde.Value) = 1 Then
                    fechaReporte = "Al: " & general.devuelveFechaImpresionEspecificado(pFechaSystem)
                Else
                    fechaReporte = general.devuelveFechaImpresionEspecificado(dtiDesde.Value) & " al " & general.devuelveFechaImpresionEspecificado(pFechaSystem)
                End If
            Else
                If Microsoft.VisualBasic.DateAndTime.Day(dtiDesde.Value) = 1 Then
                    fechaReporte = "Al: " & general.devuelveFechaImpresionEspecificado(dtiHasta.Value)
                Else
                    fechaReporte = general.devuelveFechaImpresionEspecificado(dtiDesde.Value) & " al " & general.devuelveFechaImpresionEspecificado(dtiHasta.Value)
                End If
            End If
        End If
        Dim periodo As String = periodoSeleccionado()
        Dim periodoReporte As String = "Periodo: " & general.periodo_mesAnnoLetras(periodo)
        Dim cAlmacen As String = IIf(cboAlmacen.SelectedIndex >= 0, cboAlmacen.Text, "Integrado")
        Dim cTitulo As String = cAlmacen & IIf(cboMotivo.SelectedIndex >= 0, ", Motivo: " & cboMotivo.Text, "")
        frm.cargarMermas(dsMermas, cTitulo, fechaReporte, periodoReporte, xResum)
        frm.MdiParent = principal
        frm.Show()
    End Sub

    Private Sub ChkTipArt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkTipArt.CheckedChanged
        If Not estaCargando Then
            If ChkTipArt.Checked = True Then
                CboTipArt.Enabled = True
                CboTipArt.SelectedIndex = 0
                CboTipArt.Focus()
            Else
                CboTipArt.SelectedIndex = -1
                CboTipArt.Enabled = False
            End If
        End If
    End Sub

    Private Sub CboTipArt_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboTipArt.SelectedIndexChanged
        If Not estaCargando Then
            muestraMermas()
        End If
    End Sub

    Private Sub ChkResumen_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkResumen.CheckedChanged

    End Sub

    Private Sub datadetall_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datadetall.CellContentClick

    End Sub

    Private Sub datadetall_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles datadetall.KeyDown
        If (e.Control And e.KeyCode = Keys.E) Then
            If datadetall.RowCount > 0 Then
                EnviaraExcel(datadetall)
            End If
        End If
    End Sub


End Class
