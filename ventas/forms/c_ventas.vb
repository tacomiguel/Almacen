Imports MySql.Data.MySqlClient
Imports libreriaClases
Public Class c_ventas
    Private dsVentas As New DataSet
    Private dsAlmacen As New DataSet
    Private dsAlmacenR As New DataSet
    Private dsProducto As New DataSet
    Private dsResumen As New DataSet
    Private cPrecioCI As String = general.str_PrecioCompraCI
    Private chPrecioCI As String = general.str_hPrecioCompraCI
    Private cPrecioSI As String = general.str_PrecioCompraSI
    Private chPrecioSI As String = general.str_hPrecioCompraSI
    Private estaCargando As Boolean = True
    Private Sub c_ventas_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        principal.mr_ventaRest.Enabled = True
    End Sub
    Private Sub c_ventas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        Dim daAlmacenR As New MySqlDataAdapter
        Dim cad As String = "select cod_alma,nom_alma from almacen where activo=1" _
                    & " and (esVentas) order by nom_alma"
        Dim comAlma As New MySqlCommand(cad, dbConex)
        Dim comAlmaR As New MySqlCommand(cad, dbConex)
        daAlmacen.SelectCommand = comAlma
        daAlmacenR.SelectCommand = comAlma
        daAlmacen.Fill(dsAlmacen, "almacen")
        daAlmacenR.Fill(dsAlmacenR, "almacen")
        With cboAlmacen
            .DataSource = dsAlmacen.Tables("almacen")
            .DisplayMember = dsAlmacen.Tables("almacen").Columns("nom_alma").ToString
            .ValueMember = dsAlmacen.Tables("almacen").Columns("cod_alma").ToString
            If dsAlmacen.Tables("almacen").Rows.Count > 0 Then
                .SelectedIndex = 0
            Else
                .SelectedIndex = -1
            End If
        End With
        muestraVentas()
        estaCargando = False
    End Sub
    Private Sub cboMes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMes.SelectedIndexChanged
        If Not estaCargando Then
            estableceFechas()
            chkDia.CheckState = CheckState.Unchecked
            muestraVentas()
        End If
    End Sub
    Private Sub cboAnno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAnno.SelectedIndexChanged
        If Not estaCargando Then
            estableceFechas()
            chkDia.CheckState = CheckState.Unchecked
            muestraVentas()
        End If
    End Sub
    Private Sub chkDia_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDia.CheckedChanged
        If Not estaCargando Then
            estableceFechas()
            If chkDia.CheckState = CheckState.Checked Then
                dtiDesde.Enabled = True
                dtiHasta.Enabled = True
                estableceFechas()
            Else
                dtiDesde.Enabled = False
                dtiHasta.Enabled = False
            End If
            muestraVentas()
        End If
    End Sub
    Private Sub dtiDesde_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtiDesde.ValueChanged
        If Not estaCargando Then
            muestraVentas()
        End If
    End Sub
    Private Sub dtiHasta_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtiHasta.ValueChanged
        If Not estaCargando Then
            muestraVentas()
        End If
    End Sub
    Private Sub optRegistro_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optRegistro.CheckedChanged
        If Not estaCargando And optRegistro.Checked = True Then
            cboGrupo.SelectedIndex = -1
            chkGrupo.Checked = False
            chkGrupo.Enabled = False
            grupo.Text = ""
            cboGrupo.Enabled = False
            chkIMP.Checked = True
            muestraVentas()
        End If
    End Sub
    Private Sub optComprasProducto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optVentasProducto.CheckedChanged
        If Not estaCargando And optVentasProducto.Checked = True Then
            chkAlmacen.CheckState = CheckState.Unchecked
            chkGrupo.Enabled = True
            chkGrupo.Text = "x Producto"
            cboGrupo.SelectedIndex = -1
            cboGrupo.Enabled = False
            muestraVentas()
        End If
    End Sub
    Private Sub optComprasProveedor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optVentasInsumo.CheckedChanged
        If Not estaCargando And optVentasInsumo.Checked = True Then
            chkAlmacen.CheckState = CheckState.Unchecked
            chkGrupo.Enabled = True
            chkGrupo.Text = "x Proveedor"
            cboGrupo.SelectedIndex = -1
            cboGrupo.Enabled = False
            muestraVentas()
        End If
    End Sub
    Private Sub cboAlmacen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAlmacen.SelectedIndexChanged
        If Not estaCargando Then
            muestraVentas()
        End If
    End Sub
    Private Sub cboGrupo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboGrupo.GotFocus
        If Not estaCargando And cboGrupo.Enabled = True Then
            muestraVentas()
        End If
    End Sub
    Private Sub cboGrupo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboGrupo.SelectedIndexChanged
        If Not estaCargando And cboGrupo.Enabled = True Then
            muestraVentas()
        End If
    End Sub
    Private Sub chkIMP_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkIMP.CheckedChanged
        If Not estaCargando Then
            muestraVentas()
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
            dtiHasta.Value = fechaI()
        Else
            dtiDesde.ResetMinDate()
            dtiDesde.MinDate = pFechaActivaMin
            dtiDesde.ResetMaxDate()
            dtiDesde.MaxDate = pFechaActivaMax
            dtiDesde.Value = pFechaSystem
            dtiHasta.ResetMinDate()
            dtiHasta.MinDate = pFechaActivaMin
            dtiHasta.ResetMaxDate()
            dtiHasta.MaxDate = pFechaActivaMax
            dtiHasta.Value = pFechaSystem
        End If
    End Sub
    Function periodoSeleccionado()
        Dim periodo As String = Trim(Str(cboAnno.SelectedIndex + 2010)) & Microsoft.VisualBasic.Right("00" & Trim(Str(cboMes.SelectedIndex + 1)), 2)
        Return periodo
    End Function
    Private Sub chkAlmacen_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAlmacen.CheckedChanged
        If Not estaCargando Then
            If chkAlmacen.Checked = True Then
                cboAlmacen.Enabled = True
                If dsAlmacen.Tables("almacen").Rows.Count > 0 Then
                    cboAlmacen.SelectedIndex = 0
                End If
            Else
                cboAlmacen.SelectedIndex = -1
                cboAlmacen.Enabled = False
            End If
        End If
    End Sub
    Private Sub chkDetalle_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDetalle.CheckedChanged
        If Not estaCargando Then
            If optRegistro.Checked = False Then
                If chkDetalle.Checked = True Then
                    chkTotalizado.Checked = False
                Else
                    chkTotalizado.Checked = True
                End If
            Else
                chkDetalle.Checked = True
                chkTotalizado.Checked = False
            End If
            muestraVentas()
            dataDetalle.Focus()
        End If
    End Sub
    Private Sub chkAcumulado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTotalizado.CheckedChanged
        If Not estaCargando Then
            If optRegistro.Checked = False Then
                If chkTotalizado.Checked = True Then
                    chkDetalle.Checked = False
                Else
                    chkDetalle.Checked = True
                End If
            Else
                chkTotalizado.Checked = False
                chkDetalle.Checked = True
            End If
            muestraVentas()
            dataDetalle.Focus()
        End If
    End Sub
    Private Sub chkGrupo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGrupo.CheckedChanged
        If Not estaCargando Then
            If chkGrupo.Checked = True Then
                cboGrupo.Enabled = True
                If optVentasProducto.Checked = True Then
                    cargaProductos()
                    muestraVentas()
                Else
                    If optVentasInsumo.Checked = True Then
                        'cargaProveedores()
                        muestraVentas()
                    End If
                End If
            Else
                cboGrupo.SelectedIndex = -1
                cboGrupo.Enabled = False
            End If
        End If
    End Sub
    Sub muestraVentas()
        Dim mMicros As New micros
        Dim periodo As String = periodoSeleccionado()
        Dim esHistorial As Boolean = IIf(periodo = periodoActivo(), False, True)
        Dim esMensual As Boolean = IIf(chkDia.Checked = False, True, False)
        Dim esSoloVentas As Boolean = IIf(chkSoloVentas.Checked = True, True, False)
        Dim xAlmacen As Boolean = IIf(chkAlmacen.Checked = True, True, False)
        Dim grpReceta As Boolean = IIf(optRegistro.Checked = True, True, False)
        Dim xProducto As Boolean = IIf(optVentasProducto.Checked = True And cboGrupo.SelectedIndex >= 0, True, False)
        Dim xInsumo As Boolean = IIf(optVentasInsumo.Checked = True And cboGrupo.SelectedIndex >= 0, True, False)
        Dim preciosConIMP As Boolean = IIf(chkIMP.Checked = True, True, False)
        Dim cAlmacen As String = cboAlmacen.SelectedValue
        Dim cGrupo As String = cboGrupo.SelectedValue
        Dim esAcumulado As Boolean = IIf(chkTotalizado.Checked = True, True, False)
        dataDetalle.DataSource = ""
        If optRegistro.Checked = True Then
            dsVentas = mMicros.recuperaCabeceras(esHistorial, periodo, esSoloVentas, esMensual, dtiDesde.Value, dtiHasta.Value, pDecimales, grpReceta, xAlmacen, cAlmacen)
            dataDetalle.DataSource = dsVentas.Tables("ventas").DefaultView
            estructuraVentas()
        End If
        If optVentasInsumo.Checked = True Then
            If chkTotalizado.Checked = True Then
                'dsVentas = mMicros.recuperaInsumos_grp(esHistorial, periodo, esSoloVentas, esMensual, dtiDesde.Value, dtiHasta.Value, pDecimales, True, xAlmacen, cAlmacen)
            Else
                dsVentas = mMicros.recuperaInsumos(esHistorial, periodo, esSoloVentas, esMensual, dtiDesde.Value, dtiHasta.Value, pDecimales, False, xAlmacen, cAlmacen)
            End If
            dataDetalle.DataSource = dsVentas.Tables("ventas").DefaultView
            estructuraInsumos()
        End If

        lblRegistros.Text = "Nro de Registros..." & dataDetalle.RowCount
    End Sub
    Sub estructuraVentas()
        With dataDetalle
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("fecha").HeaderText = "Fecha"
            .Columns("fecha").Width = 70
            .Columns("fecha").DisplayIndex = 0
            .Columns("fecha").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_rec").HeaderText = "Codigo"
            .Columns("cod_rec").Width = 60
            .Columns("cod_rec").DisplayIndex = 1
            .Columns("cod_rec").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("receta").HeaderText = "Receta"
            .Columns("receta").Width = 320
            .Columns("receta").DisplayIndex = 2
            .Columns("cantReceta").HeaderText = "Cantidad"
            .Columns("cantReceta").Width = 70
            .Columns("cantReceta").DisplayIndex = 3
            .Columns("cantReceta").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            .Columns("pre_ven").HeaderText = "Precio Venta"
            .Columns("pre_ven").Width = 80
            .Columns("pre_ven").DisplayIndex = 4
            .Columns("pre_ven").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("monto").HeaderText = "Monto"
            .Columns("monto").Width = 80
            .Columns("monto").DisplayIndex = 5
            .Columns("monto").DefaultCellStyle.BackColor = Color.AliceBlue
            .Columns("monto").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("operacion").Visible = False
        End With
    End Sub
    Sub estructuraInsumos()
        With dataDetalle
            '.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            '.Columns("fecha").HeaderText = "Fecha"
            '.Columns("fecha").Width = 70
            '.Columns("fecha").DisplayIndex = 0
            '.Columns("fecha").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            '.Columns("cod_rec").HeaderText = "Codigo"
            '.Columns("cod_rec").Width = 60
            '.Columns("cod_rec").DisplayIndex = 1
            '.Columns("cod_rec").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            '.Columns("receta").HeaderText = "Receta"
            '.Columns("receta").Width = 320
            '.Columns("receta").DisplayIndex = 2
            '.Columns("cant").HeaderText = "Cantidad"
            '.Columns("cant").Width = 70
            '.Columns("cantReceta").DisplayIndex = 3
            '.Columns("cantReceta").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            '.Columns("pre_ven").HeaderText = "Precio Venta"
            '.Columns("pre_ven").Width = 80
            '.Columns("pre_ven").DisplayIndex = 4
            '.Columns("pre_ven").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            '.Columns("monto").HeaderText = "Monto"
            '.Columns("monto").Width = 80
            '.Columns("monto").DisplayIndex = 5
            '.Columns("monto").DefaultCellStyle.BackColor = Color.AliceBlue
            '.Columns("monto").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            '.Columns("operacion").Visible = False
        End With
    End Sub
    Sub cargaProductos()

    End Sub
    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        'Dim periodo As String = periodoSeleccionado()
        'Dim periodoReporte As String = "Periodo: " & general.periodo_mesAnnoLetras(periodo)
        'Dim preciosConImp As String = IIf(chkIMP.Checked = True, "*Precios Incluyen Impuesto", "*Precios NO Incluyen Impuesto")
        'Dim fechaReporte As String = general.devuelveFechaImpresionEspecificado(dtiDesde.Value)
        'Dim insAgrupados As Boolean
        'Dim frm As New rptForm
        'If chkTotalizado.Checked = True Then
        '    insAgrupados = True
        '    frm.cargarMicros_insumos(dsVentas, cboAlmacen.Text & ":  Cantidad de Insumos Utilizados en las Ventas Totalizado", fechaReporte, periodoReporte, insAgrupados)
        'Else
        '    insAgrupados = False
        '    frm.cargarMicros_insumos(dsVentas, cboAlmacen.Text & ":  Cantidad de Insumos Utilizados en las Ventas x Receta ", fechaReporte, periodoReporte, insAgrupados)
        'End If
        'frm.MdiParent = principal
        'frm.Show()
    End Sub

    Private Sub GroupBox5_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox5.Enter

    End Sub
End Class
