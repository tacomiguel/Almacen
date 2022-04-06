Imports MySql.Data.MySqlClient
Imports libreriaClases
Public Class repIngresos
    Private dsIngresos As New DataSet
    Private dsIngresosG As New DataSet
    Private dsEmpresa As New DataSet
    Private dsAlmacen As New DataSet
    Private dsAlmacenG As New DataSet
    Private dsAlmacenR As New DataSet
    Private dsProveedor As New DataSet
    Private dsProducto As New DataSet
    Private dsFamilia As New DataSet
    Private dsGrupo As New DataSet
    Private dsResumenAnual As New DataSet
    Private cPrecioCI As String = general.str_PrecioCompraCI
    Private chPrecioCI As String = general.str_hPrecioCompraCI
    Private cPrecioSI As String = general.str_PrecioCompraSI
    Private chPrecioSI As String = general.str_hPrecioCompraSI
    Private cPrecioCIs As String = general.str_PrecioCompraCIs
    Private chPrecioCIs As String = general.str_hPrecioCompraCIs
    Private cPrecioSIs As String = general.str_PrecioCompraSIs
    Private chPrecioSIs As String = general.str_hPrecioCompraSIs
    Private estaCargando As Boolean = True
    Private Sub repIngresos_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        'If Not estaCargando Then
        'muestraIngresos()
        'End If
    End Sub
    Private Sub repIngresos_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        principal.mr_ingresos.Enabled = True
    End Sub
    Private Sub repIngresos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Top = 0
        Me.Left = 0
        'dtiDesde.MaxDate = pFechaSystem
        'dtiDesde.MinDate = pFechaActivaMin
        'dtiHasta.MaxDate = pFechaSystem
        'dtiHasta.MinDate = pFechaActivaMin
        'If Month(pFechaActivaMax) = Month(pFechaSystem) Then
        '    dtiDesde.Value = pFechaSystem
        '    dtiHasta.Value = pFechaSystem
        'End If
        Dim mes, anno As Integer
        mes = Month(pFechaActivaMax)
        anno = Year(pFechaActivaMax)
        cboMes.SelectedIndex = mes - 1
        cboAnno.SelectedIndex = anno - 2010
        'dataset empresa
        Dim daE As New MySqlDataAdapter
        Dim cadE As String = "select cod_emp,raz_soc from empresa where activo=1" _
                    & " order by raz_soc"
        Dim comE As New MySqlCommand(cadE, dbConex)
        daE.SelectCommand = comE
        daE.Fill(dsEmpresa, "empresa")
        With cboEmpresa
            .DataSource = dsEmpresa.Tables("empresa")
            .DisplayMember = dsEmpresa.Tables("empresa").Columns("raz_soc").ToString
            .ValueMember = dsEmpresa.Tables("empresa").Columns("cod_emp").ToString
            If dsEmpresa.Tables("empresa").Rows.Count > 0 Then
                .SelectedIndex = 0
            Else
                .SelectedIndex = -1
            End If
        End With
        Dim codigoE As String = cboEmpresa.SelectedValue
        'dataset almacen
        muestraAlmacen(codigoE)
        'dataset familia
        Dim daFamilia As New MySqlDataAdapter
        Dim cadF As String = "select cod_familia,nom_familia from familia where activo=1" _
                    & " order by nom_familia"
        Dim comFamilia As New MySqlCommand(cadF, dbConex)
        dafamilia.SelectCommand = comFamilia
        daFamilia.Fill(dsFamilia, "familia")
        'dataset grupo
        Dim daGrupo As New MySqlDataAdapter
        Dim cadG As String = "select cod_sgrupo,nom_sgrupo from subgrupo where activo=1" _
                    & " and not(esProduccion) order by nom_sgrupo"
        Dim comGrupo As New MySqlCommand(cadG, dbConex)
        daGrupo.SelectCommand = comgrupo
        daGrupo.Fill(dsGrupo, "grupo")
        With cboGrupo
            .DataSource = dsGrupo.Tables("grupo")
            .DisplayMember = dsGrupo.Tables("grupo").Columns("nom_sgrupo").ToString
            .ValueMember = dsGrupo.Tables("grupo").Columns("cod_sgrupo").ToString
            .SelectedIndex = -1
        End With
        'dataset proveedor
        Dim daProveedor As New MySqlDataAdapter
        Dim comProv As New MySqlCommand("select cod_prov,raz_soc from proveedor where activo=1 order by raz_soc", dbConex)
        daProveedor.SelectCommand = comProv
        daProveedor.Fill(dsProveedor, "proveedor")
        'dataset producto
        Dim daProducto As New MySqlDataAdapter
        Dim cadProd As String
        If pCatalogoXalmacen Then
            cadProd = "select cod_art,nom_art from articulo where activo=1 and cod_alma='" _
                    & cboEmpresa.SelectedValue & "' order by nom_art"
        Else
            cadProd = "select cod_art,nom_art from articulo where activo=1 order by nom_art"
        End If
        Dim comProd As New MySqlCommand(cadProd, dbConex)
        daProducto.SelectCommand = comProd
        daProducto.Fill(dsProducto, "producto")
        'establecemos la moneda nacional
        chkMoneda.Text = pMoneda
        estableceFechas()
        estaCargando = False
        muestraIngresos()
    End Sub
    Sub muestraAlmacen(ByVal cod_emp As String)
        dsAlmacen.Clear()
        dsAlmacenG.Clear()
        dsAlmacenR.Clear()
        Dim cad As String = "select cod_alma,nom_alma from almacen where activo=1 and cod_emp='" & cod_emp & "'" _
                            & " and (esCompras) order by nom_alma"
        Dim daAlmacen As New MySqlDataAdapter
        Dim daAlmacenG As New MySqlDataAdapter
        Dim daAlmacenR As New MySqlDataAdapter
        Dim comAlma As New MySqlCommand(cad, dbConex)
        Dim comAlmaG As New MySqlCommand(cad, dbConex)
        Dim comAlmaR As New MySqlCommand(cad, dbConex)
        daAlmacen.SelectCommand = comAlma
        daAlmacenG.SelectCommand = comAlma
        daAlmacenR.SelectCommand = comAlma
        daAlmacen.Fill(dsAlmacen, "almacen")
        daAlmacenG.Fill(dsAlmacenG, "almacen")
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
        With cboAlmacenResumen
            .DataSource = dsAlmacenR.Tables("almacen")
            .DisplayMember = dsAlmacenR.Tables("almacen").Columns("nom_alma").ToString
            .ValueMember = dsAlmacenR.Tables("almacen").Columns("cod_alma").ToString
            If dsAlmacenR.Tables("almacen").Rows.Count > 0 Then
                .SelectedIndex = 0
            Else
                .SelectedIndex = -1
            End If
        End With
    End Sub
    Private Sub cboMes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMes.SelectedIndexChanged
        If Not estaCargando Then
            estableceFechas()
            'chkDia.Checked = False
            muestraIngresos()
        End If
    End Sub
    Private Sub cboAnno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAnno.SelectedIndexChanged
        If Not estaCargando Then
            estableceFechas()
            'chkDia.Checked = False
            muestraIngresos()
        End If
        If optCantidades.Checked = True Then
            lblMensaje.Visible = False
            lblMensaje.Refresh()
            muestraResumen(True)
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
            muestraIngresos()
        End If
    End Sub
    Private Sub dtiDesde_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtiDesde.ValueChanged
        If Not estaCargando Then
            muestraIngresos()
        End If
    End Sub
    Private Sub dtiHasta_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtiHasta.ValueChanged
        If Not estaCargando Then
            muestraIngresos()
        End If
    End Sub
    Private Sub cboEmpresa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboEmpresa.SelectedIndexChanged
        If Not estaCargando Then
            muestraAlmacen(cboEmpresa.SelectedValue)
            muestraIngresos()
        End If
    End Sub
    Private Sub cboAlmacen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAlmacen.SelectedIndexChanged
        If Not estaCargando Then
            muestraIngresos()
        End If
    End Sub
    Private Sub cboGrupo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboGrupo.SelectedIndexChanged
        If Not estaCargando Then
            muestraIngresos()
        End If
    End Sub
    Private Sub chkAlmacen_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAlmacen.CheckedChanged
        If Not estaCargando Then
            If chkAlmacen.Checked = False Then
                cboAlmacen.SelectedIndex = -1
                cboAlmacen.Enabled = False
            Else
                cboAlmacen.Enabled = True
                cboAlmacen.SelectedIndex = 0
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
    Private Sub chkCostosMonedaCompra_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCostosMonedaCompra.CheckedChanged
        If Not estaCargando Then
            If chkCostosMonedaCompra.Checked Then
                chkCostosMonedaCompra.Text = "Mostrar Compras en Moneda de Adquisición de Productos"
            Else
                chkCostosMonedaCompra.Text = "Mostrar Compras en Dolares en Moneda Nacional: " & pMoneda
            End If
            muestraIngresos()
        End If
    End Sub
    Private Sub optOrdenFecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optOrdenFecha.CheckedChanged
        If Not estaCargando And optOrdenFecha.Checked = True Then
            muestraIngresos()
        End If
    End Sub
    Private Sub optOrdenDocumento_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optOrdenDocumento.CheckedChanged
        If Not estaCargando And optOrdenDocumento.Checked = True Then
            muestraIngresos()
        End If
    End Sub
    Private Sub optOrdenProducto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optOrdenProducto.CheckedChanged
        If Not estaCargando And optOrdenProducto.Checked Then
            muestraIngresos()
        End If
    End Sub
    Private Sub optOrdenProveedor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optOrdenProveedor.CheckedChanged
        If Not estaCargando And optOrdenProveedor.Checked = True Then
            muestraIngresos()
        End If
    End Sub
    Private Sub optOrdenMonto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optOrdenMonto.CheckedChanged
        If Not estaCargando And optOrdenMonto.Checked = True Then
            muestraIngresos()
        End If
    End Sub
    Private Sub optRegistro_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optRegistro.CheckedChanged
        If Not estaCargando And optRegistro.Checked = True Then
            ordenIngresos()
            chkDetalle.Checked = False
            chkResumen.Checked = True
            txtBuscar.Text = ""
            optProveedor.Enabled = True
            optDocumento.Text = "Documento"
            optProveedor.Text = "Proveedor"
            optDocumento.Checked = True
            muestraIngresos()
        End If
    End Sub
    Private Sub optComprasProducto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optComprasProducto.CheckedChanged
        If Not estaCargando And optComprasProducto.Checked = True Then
            ordenIngresos()
            If Not chkResumen.Checked = True And Not chkDetalle.Checked = True Then
                chkResumen.Checked = True
            End If
            txtBuscar.Text = ""
            optProveedor.Enabled = False
            optDocumento.Text = "Producto"
            optProveedor.Enabled = False
            optDocumento.Checked = True
            muestraIngresos()
        End If
    End Sub
    Private Sub optComprasProveedor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optComprasProveedor.CheckedChanged
        If Not estaCargando And optComprasProveedor.Checked = True Then
            ordenIngresos()
            txtBuscar.Text = ""
            optProveedor.Enabled = False
            optDocumento.Text = "Proveedor"
            optProveedor.Enabled = False
            optDocumento.Checked = True
            muestraIngresos()
        End If
    End Sub
    Private Sub chkIMP_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkIMP.CheckedChanged
        If Not estaCargando Then
            muestraIngresos()
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
            dtiDesde.MaxDate = pFechaSystem
            dtiDesde.Value = fechaI()
            dtiHasta.ResetMinDate()
            dtiHasta.MinDate = fechaI()
            dtiHasta.ResetMaxDate()
            dtiHasta.MaxDate = DateAdd(DateInterval.Day, 15, pFechaSystem)
            dtiHasta.Value = fechaI()

        Else
            dtiDesde.ResetMinDate()
            dtiDesde.MinDate = pFechaActivaMin
            dtiDesde.ResetMaxDate()
            dtiDesde.MaxDate = pFechaSystem
            dtiDesde.Value = pFechaSystem
            dtiHasta.ResetMinDate()
            dtiHasta.MinDate = pFechaActivaMin
            dtiHasta.ResetMaxDate()
            dtiHasta.MaxDate = DateAdd(DateInterval.Day, 15, pFechaSystem)
            dtiHasta.Value = pFechaSystem
        End If

    End Sub
    Function periodoSeleccionado()
        Dim periodo As String = Trim(Str(cboAnno.SelectedIndex + 2010)) & Microsoft.VisualBasic.Right("00" & Trim(Str(cboMes.SelectedIndex + 1)), 2)
        Return periodo
    End Function
    Private Sub chkSoles_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMoneda.CheckedChanged
        If Not estaCargando Then
            muestraIngresos()
        End If
    End Sub
    Private Sub chkDolares_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDolares.CheckedChanged
        If Not estaCargando Then
            muestraIngresos()
        End If
    End Sub
    Private Sub chkSoloCompras_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSoloCompras.CheckedChanged
        If Not estaCargando Then
            If chkSoloCompras.Checked Then
                tabCompras.Text = "Compras"
                tabGrupos.Text = "Resumen de Compras x Grupo"
            Else
                tabCompras.Text = "Ingresos"
                tabGrupos.Text = "Resumen de Ingresos x Grupo"
            End If
            muestraIngresos()
            dataDetalle.Focus()
        End If
    End Sub
    Private Sub chkDetalle_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDetalle.CheckedChanged
        If Not estaCargando Then
            If optRegistro.Checked = True Then
                chkDetalle.Checked = False
                chkResumen.Checked = True
            Else
                If chkDetalle.Checked = True Then
                    chkResumen.Checked = False
                Else
                    chkResumen.Checked = True
                End If
            End If
            ordenIngresos()
            muestraIngresos()
            dataDetalle.Focus()
        End If
    End Sub
    Private Sub chkTotalizado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkResumen.CheckedChanged
        If Not estaCargando Then
            If chkResumen.Checked = True Then
                chkDetalle.Checked = False
            End If
            If optRegistro.Checked = True Then
                chkResumen.Checked = True
                chkDetalle.Checked = False
            End If
            ordenIngresos()
            muestraIngresos()
            dataDetalle.Focus()
        End If
    End Sub
    Sub cargaProductos()
        With cboGrupo
            .Enabled = False
            .DropDownStyle = ComboBoxStyle.DropDown
            .DataSource = dsProducto.Tables("producto")
            .DisplayMember = dsProducto.Tables("producto").Columns("nom_art").ToString
            .ValueMember = dsProducto.Tables("producto").Columns("cod_art").ToString
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.ListItems
            If dsProducto.Tables("producto").Rows.Count > 0 Then
                .SelectedIndex = 0
            End If
            .Enabled = True
            .Focus()
        End With
    End Sub
    Sub cargaProveedores()
        With cboGrupo
            .Enabled = False
            .DropDownStyle = ComboBoxStyle.DropDown
            .DataSource = dsProveedor.Tables("proveedor")
            .DisplayMember = dsProveedor.Tables("proveedor").Columns("raz_soc").ToString
            .ValueMember = dsProveedor.Tables("proveedor").Columns("cod_prov").ToString
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.ListItems
            If dsProveedor.Tables("Proveedor").Rows.Count > 0 Then
                .SelectedIndex = 0
            End If
            .Enabled = True
            .Focus()
        End With
    End Sub
    Private Sub optBuscar1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles optDocumento.Click
        txtBuscar.Focus()
    End Sub
    Private Sub optBuscar2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optProveedor.CheckedChanged
        txtBuscar.Focus()
    End Sub
    Private Sub txtBuscar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscar.Click
        txtBuscar.Focus()
    End Sub
    Private Sub txtBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscar.KeyPress
        If e.KeyChar = Chr(13) Then
            dataDetalle.Focus()
        End If
    End Sub
    Private Sub txtbuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged
        If Not estaCargando Then
            Dim cBuscar As String = txtBuscar.Text
            If optRegistro.Checked = True Or OptOCompra.Checked = True Then
                If optDocumento.Checked = True Then
                    dsIngresos.Tables("ingreso").DefaultView.RowFilter = "nro_doc LIKE '%" & cBuscar & "%'"
                End If
                If optProveedor.Checked = True Then
                    dsIngresos.Tables("ingreso").DefaultView.RowFilter = "raz_soc LIKE '%" & cBuscar & "%'"
                End If
                If optGuia.Checked = True Then
                    dsIngresos.Tables("ingreso").DefaultView.RowFilter = "nro_guia LIKE '%" & cBuscar & "%'"
                End If
            End If
            If optComprasProducto.Checked = True Then
                dsIngresos.Tables("ingreso").DefaultView.RowFilter = "nom_art LIKE '%" & cBuscar & "%'"
            End If
            If optComprasProveedor.Checked = True Then
                dsIngresos.Tables("ingreso").DefaultView.RowFilter = "raz_soc LIKE '%" & cBuscar & "%'"
            End If
        End If
    End Sub
    Private Sub ordenDesc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ordenDesc.Click
        ordenDesc.Visible = False
        ordenAsc.Visible = True
        muestraIngresos()
    End Sub
    Private Sub ordenAsc_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ordenAsc.Click
        ordenAsc.Visible = False
        ordenDesc.Visible = True
        muestraIngresos()
    End Sub
    Sub ordenIngresos()
        ''activamos/desactivamos loscontroles en funcion a la seleccion
        optOrdenFecha.Checked = False
        optOrdenDocumento.Checked = False
        optOrdenProducto.Checked = False
        optOrdenProveedor.Checked = False
        optOrdenMonto.Checked = False
        optOrdenFecha.Enabled = False
        optOrdenDocumento.Enabled = False
        optOrdenProducto.Enabled = False
        optOrdenProveedor.Enabled = False
        optOrdenMonto.Enabled = False
        If optRegistro.Checked = True Or OptOCompra.Checked Then
            ordenDesc.Visible = True
            ordenAsc.Visible = False
            optOrdenFecha.Enabled = True
            optOrdenDocumento.Enabled = True
            optOrdenProveedor.Enabled = True
            optOrdenMonto.Enabled = True
            optOrdenFecha.Checked = True
        Else
            If optComprasProducto.Checked = True Then
                ordenDesc.Visible = False
                ordenAsc.Visible = True
                If chkDetalle.Checked = True Then
                    optOrdenProveedor.Enabled = True
                    optOrdenFecha.Enabled = True
                    optOrdenDocumento.Enabled = True
                End If
                optOrdenMonto.Enabled = True
                optOrdenProducto.Enabled = True
                optOrdenProducto.Checked = True
            Else
                ordenDesc.Visible = False
                ordenAsc.Visible = True
                If chkResumen.Checked = True Then
                    optOrdenProveedor.Enabled = True
                    optOrdenMonto.Enabled = True
                Else
                    optOrdenFecha.Enabled = True
                    optOrdenDocumento.Enabled = True
                    optOrdenProducto.Enabled = True
                    optOrdenProveedor.Enabled = True
                    optOrdenMonto.Enabled = True
                End If
                optOrdenProveedor.Checked = True
            End If
        End If
    End Sub
    Sub muestraIngresos()
        Dim mIngresos As New Ingreso
        Dim periodo As String = periodoSeleccionado()
        Dim cOrden As String = ""
        Dim esMoneda As Boolean, mMoneda As String = ""
        Dim esHistorial As Boolean = IIf(periodo = periodoActivo(), False, True)
        Dim esMensual As Boolean = IIf(chkDia.Checked = False, True, False)
        Dim esSoloCompras As Boolean = IIf(chkSoloCompras.Checked = True, True, False)
        Dim cEmpresa As String = cboEmpresa.SelectedValue
        Dim xAlmacen As Boolean = IIf(chkAlmacen.Checked = True, True, False)
        Dim cAlmacen As String = cboAlmacen.SelectedValue
        Dim xGrupo As Boolean = IIf(chkGrupo.Checked = True And cboGrupo.SelectedIndex >= 0, True, False)
        Dim cGrupo As String = cboGrupo.SelectedValue
        Dim xMonedaCompra As Boolean = chkCostosMonedaCompra.Checked
        'Dim xArticulo As Boolean = IIf(optComprasProducto.Checked = True And cboGrupo.SelectedIndex >= 0, True, False)
        'Dim xProveedor As Boolean = IIf(optComprasProveedor.Checked = True And cboGrupo.SelectedIndex >= 0, True, False)
        Dim preciosConIMP As Boolean = IIf(chkIMP.Checked = True, True, False)
        Dim cTodos As String = ""
        Dim esAgrupado As Boolean = IIf(chkResumen.Checked = True, True, False)
        Dim cAgrupado As String = "articulo.cod_art"
        Dim xFamilia As Boolean = False, xArticulo As Boolean = False, xProveedor As Boolean = False
        txtBuscar.Text = ""
        Dim I As Integer = 0
        'verificamos el tipo de moneda
        If (chkMoneda.Checked = True And chkDolares.Checked = True) Or (chkMoneda.Checked = False And chkDolares.Checked = False) Then
            esMoneda = False
        Else
            esMoneda = True
            If chkMoneda.Checked = True Then
                mMoneda = pMonedaAbr
            Else
                mMoneda = "D"
            End If
        End If
        'establecemos el orden a mostrar los ingresos
        If optOrdenFecha.Checked = True Then
            cOrden = IIf(ordenDesc.Visible = True, "fec_doc desc", "fec_doc asc") & ",raz_soc,ser_doc,nro_doc"
        Else
            If optOrdenDocumento.Checked = True Then
                cOrden = IIf(ordenDesc.Visible = True, "ser_doc desc", "ser_doc asc") & ",nro_doc,raz_soc"
            Else
                If optOrdenProducto.Checked = True Then
                    cOrden = IIf(ordenDesc.Visible = True, "nom_art desc", "nom_art asc") & ",raz_soc,ser_doc,nro_doc"
                Else
                    If optOrdenProveedor.Checked = True Then
                        cOrden = IIf(ordenDesc.Visible = True, "raz_soc desc", "raz_soc asc") & ",fec_doc,ser_doc,nro_doc"
                    Else
                        If chkResumen.Checked = True Then
                            If optComprasProducto.Checked Then
                                cOrden = IIf(ordenDesc.Visible = True, "netoDS desc", "netoDS asc") & ",raz_soc"
                            Else
                                cOrden = IIf(ordenDesc.Visible = True, "monto_docDS desc", "monto_docDS asc") & ",raz_soc"
                            End If
                        Else
                            cOrden = IIf(ordenDesc.Visible = True, "netoDS desc", "netoDS asc") & ",raz_soc"
                        End If
                    End If
                End If
            End If
        End If
        dsIngresos.Clear()
        dataDetalle.DataSource = ""
        If OptOCompra.Checked = True Then
            dsIngresos = mIngresos.recuperaCabeceras_oc(esHistorial, periodo, esSoloCompras, esMensual, dtiDesde.Value, dtiHasta.Value,
                            pDecimales, False, True, cEmpresa, xAlmacen, cAlmacen, False, "", esMoneda, mMoneda, xMonedaCompra, cOrden)
            dataDetalle.DataSource = dsIngresos.Tables("ingreso").DefaultView
            estructuraIngresos()
            muestraTotales(False)
        Else
            If optRegistro.Checked = True Then
                dsIngresos = mIngresos.recuperaCabeceras(esHistorial, periodo, esSoloCompras, esMensual, dtiDesde.Value, dtiHasta.Value,
                            pDecimales, False, True, cEmpresa, xAlmacen, cAlmacen, False, "", esMoneda, mMoneda, xMonedaCompra, cOrden)
                dataDetalle.DataSource = dsIngresos.Tables("ingreso").DefaultView
                estructuraIngresos()
                muestraTotales(False)
            Else
                If optComprasProducto.Checked = True Then
                    dsIngresos = mIngresos.recuperaArticulosIngresados(esHistorial, periodo, esAgrupado, cAgrupado, esSoloCompras, False,
                        esMensual, dtiDesde.Value, dtiHasta.Value, pDecimales, xAlmacen, cAlmacen, xProveedor, cGrupo, xArticulo, cGrupo,
                        xFamilia, "", False, xGrupo, cGrupo, preciosConIMP, esMoneda, mMoneda, IIf(xMonedaCompra, cPrecioCI, cPrecioCIs),
                        IIf(xMonedaCompra, chPrecioCI, chPrecioCIs), IIf(xMonedaCompra, cPrecioSI, cPrecioSIs), IIf(xMonedaCompra, chPrecioSI, chPrecioSIs),
                        cPrecioCIs, chPrecioCIs, cPrecioSIs, chPrecioSIs, cOrden, False, "", xMonedaCompra)
                    dataDetalle.DataSource = dsIngresos.Tables("ingreso").DefaultView
                    estructuraComprasArticulo()
                    muestraTotales(True)
                Else
                    If optComprasProveedor.Checked = True Then
                        If chkResumen.Checked = True Then 'Resumen: acumulado de compras x proveedor
                            dsIngresos = mIngresos.recuperaCabeceras(esHistorial, periodo, esSoloCompras, esMensual, dtiDesde.Value, dtiHasta.Value,
                                        pDecimales, True, True, cEmpresa, xAlmacen, cAlmacen, False, "", esMoneda, mMoneda, xMonedaCompra, cOrden)
                            dataDetalle.DataSource = dsIngresos.Tables("ingreso").DefaultView
                            estructuraIngresos()
                            muestraTotales(False)
                        Else 'cuando es detallado
                            dsIngresos = mIngresos.recuperaArticulosIngresados(esHistorial, periodo, esAgrupado, cAgrupado, esSoloCompras, False,
                                esMensual, dtiDesde.Value, dtiHasta.Value, pDecimales, xAlmacen, cAlmacen, xProveedor, cGrupo, xArticulo, cGrupo,
                                False, "", False, xGrupo, cGrupo, preciosConIMP, esMoneda, mMoneda, cPrecioCI, chPrecioCI, cPrecioSI, chPrecioSI,
                                cPrecioCIs, chPrecioCIs, cPrecioSIs, chPrecioSIs, cOrden, True, cEmpresa, xMonedaCompra)
                            dataDetalle.DataSource = dsIngresos.Tables("ingreso").DefaultView
                            estructuraComprasArticulo()
                            muestraTotales(True)
                        End If
                    End If
                End If
            End If
        End If
        dataDetalle.Focus()
        lblRegistros.Text = dataDetalle.RowCount.ToString & " Reg."
    End Sub
    Sub muestraTotales(ByVal xProducto As Boolean)
        Dim cMonto As Decimal = 0
        Dim cMontoD As Decimal = 0
        Dim cMontoDS As Decimal = 0
        Dim I As Integer = 0
        If xProducto Then
            For I = 0 To dataDetalle.RowCount - 1
                If dataDetalle.Item("tm", I).Value = "D" Then
                    cMontoD = cMontoD + dataDetalle.Item("neto", I).Value
                Else
                    cMonto = cMonto + dataDetalle.Item("neto", I).Value
                End If
                cMontoDS = cMontoDS + dataDetalle.Item("netoDS", I).Value
            Next
        Else
            If chkIMP.Checked = True Then
                For I = 0 To dataDetalle.RowCount - 1
                    If dataDetalle.Item("tm", I).Value = "D" Then
                        cMontoD = cMontoD + dataDetalle.Item("monto_doc", I).Value
                    Else
                        cMonto = cMonto + dataDetalle.Item("monto_doc", I).Value
                    End If
                    cMontoDS = cMontoDS + dataDetalle.Item("monto_docDS", I).Value
                Next
            Else
                For I = 0 To dataDetalle.RowCount - 1
                    If dataDetalle.Item("tm", I).Value = "D" Then
                        cMontoD = cMontoD + dataDetalle.Item("subTotal", I).Value
                    Else
                        cMonto = cMonto + dataDetalle.Item("subTotal", I).Value
                    End If
                    cMontoDS = cMontoDS + dataDetalle.Item("subTotalDS", I).Value
                Next
            End If
        End If
        coloreaIngresoDolares()
        lblMoneda.Text = pMoneda
        lblMonedaDS.Text = "Total en " & pMoneda
        lblMonto.Text = "Monto..." & Format(cMonto, "####,###.##")
        lblMontoD.Text = "Monto..." & Format(cMontoD, "####,###.##")
        lblMontoDS.Text = "Monto..." & Format(cMontoDS, "####,###.##")
    End Sub
    Sub coloreaIngresoDolares()
        'Dim I As Integer = 0
        'If dsIngresos.Tables("ingreso").Rows.Count > 0 Then
        '    If optComprasProducto.Checked = True Then
        '        For I = 0 To dsIngresos.Tables("ingreso").Rows.Count - 1
        '            dataDetalle.CurrentCell = dataDetalle("cod_art", I)
        '            If Not IsDBNull(dataDetalle("cod_art", I).Value) Then
        '                If dataDetalle("tm", I).Value = "D" Then
        '                    dataDetalle.CurrentRow.DefaultCellStyle.BackColor = Color.LightGreen
        '                End If
        '            End If
        '        Next
        '        dataDetalle.CurrentCell = dataDetalle("cod_art", 0)
        '    Else
        '        For I = 0 To dsIngresos.Tables("ingreso").Rows.Count - 1
        '            dataDetalle.CurrentCell = dataDetalle("operacion", I)
        '            If Not IsDBNull(dataDetalle("operacion", I).Value) Then
        '                If dataDetalle("operacion", I).Value > 0 Then
        '                    If dataDetalle("tm", I).Value = "D" Then
        '                        dataDetalle.CurrentRow.DefaultCellStyle.BackColor = Color.LightGreen
        '                    End If
        '                End If
        '            End If
        '        Next
        '        dataDetalle.CurrentCell = dataDetalle("fec_doc", 0)
        '    End If
        'End If
    End Sub
    Sub estructuraIngresos()
        With dataDetalle
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("operacion").HeaderText = ""
            .Columns("operacion").Width = 40
            .Columns("operacion").DisplayIndex = 0
            .Columns("operacion").DefaultCellStyle.BackColor = Color.AliceBlue
            .Columns("operacion").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("fec_doc").HeaderText = "Fecha"
            .Columns("fec_doc").Width = 70
            .Columns("fec_doc").DisplayIndex = 1
            .Columns("fec_doc").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("raz_soc").HeaderText = "Proveedor"
            If optComprasProveedor.Checked = True Then
                .Columns("raz_soc").Width = 300
            Else
                .Columns("raz_soc").Width = 230
            End If
            .Columns("raz_soc").DisplayIndex = 2
            .Columns("doc").HeaderText = "Documento"
            .Columns("doc").Width = 120
            .Columns("doc").DisplayIndex = 6
            .Columns("monto_doc").HeaderText = "Total"
            .Columns("monto_doc").Width = 80
            .Columns("monto_doc").DisplayIndex = 7
            .Columns("monto_doc").DefaultCellStyle.BackColor = Color.AliceBlue
            .Columns("monto_doc").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("monto_igv").HeaderText = "IMP"
            .Columns("monto_igv").Width = 70
            .Columns("monto_igv").DisplayIndex = 8
            .Columns("monto_igv").DefaultCellStyle.BackColor = Color.AliceBlue
            .Columns("monto_igv").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("subTotal").HeaderText = "Sub Total"
            .Columns("subTotal").Width = 80
            .Columns("subTotal").DisplayIndex = 9
            .Columns("subTotal").DefaultCellStyle.BackColor = Color.AliceBlue
            .Columns("subTotal").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("tm").HeaderText = "M"
            .Columns("tm").Width = 30
            .Columns("tm").DisplayIndex = 10
            .Columns("tm").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("tc").HeaderText = "TC"
            .Columns("tc").Width = 40
            .Columns("tc").DisplayIndex = 11
            .Columns("tc").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("abr_fpago").HeaderText = "Forma Pago"
            .Columns("abr_fpago").Width = 80
            .Columns("abr_fpago").DisplayIndex = 12
            .Columns("fec_pago").Visible = True
            .Columns("nom_alma").Visible = True
            .Columns("fec_pago").HeaderText = "Fecha Pago"
            .Columns("fec_pago").Width = 70
            .Columns("fec_pago").DisplayIndex = 13
            .Columns("nom_alma").Visible = True
            .Columns("nom_alma").HeaderText = "Almacen"
            .Columns("nom_alma").Width = 120
            .Columns("nom_alma").DisplayIndex = 14

            .Columns("guia").HeaderText = "GUIA"
            .Columns("guia").Width = 120
            .Columns("guia").DisplayIndex = 15

            .Columns("nro_orden").HeaderText = "ORDEN"
            .Columns("nro_orden").Width = 120
            .Columns("nro_orden").DisplayIndex = 16

            If optComprasProveedor.Checked = True And chkResumen.Checked = True Then
                .Columns("fec_doc").Visible = False
                .Columns("cod_prov").Visible = True
                .Columns("cod_prov").HeaderText = "Codigo"
                .Columns("cod_prov").Width = 90
                .Columns("cod_prov").DisplayIndex = 1
                .Columns("cod_prov").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns("doc").Visible = False
                .Columns("abr_fpago").Visible = False
                .Columns("fec_pago").Visible = False
                .Columns("nom_alma").Visible = False
                .Columns("ser_guia1").Visible = False
                .Columns("nro_guia1").Visible = False
                .Columns("guia").Visible = False
                .Columns("nro_orden").Visible = False
            Else
                .Columns("cod_prov").Visible = False
            End If


            .Columns("cant").Visible = False
            .Columns("precio").Visible = False
            .Columns("ser_doc").Visible = False
            .Columns("nro_doc").Visible = False
            .Columns("cod_doc").Visible = False
            .Columns("ser_guia").Visible = False
            .Columns("nro_guia").Visible = False
            .Columns("nom_prov").Visible = False
            .Columns("dir_prov").Visible = False
            .Columns("nom_cont").Visible = False
            .Columns("cod_fpago").Visible = False
            .Columns("cod_alma").Visible = False
            .Columns("fono_prov").Visible = False
            .Columns("obs").Visible = False
            .Columns("anul").Visible = False
            .Columns("ingreso").Visible = False
            .Columns("cod_art").Visible = False
            .Columns("nom_art").Visible = False
            .Columns("nom_uni").Visible = False
            .Columns("igv").Visible = False
            .Columns("afecto_igv").Visible = False
            .Columns("pre_inc_igv").Visible = False
            .Columns("monto_pago").Visible = False
            .Columns("pre_ult").Visible = False
            .Columns("documento").Visible = False
            .Columns("nom_fpago").Visible = False
            .Columns("cancelado").Visible = False
            .Columns("monto_docDS").Visible = False
            .Columns("subTotalDS").Visible = False
        End With
    End Sub
    Sub estructuraComprasArticulo()
        With dataDetalle
            .Columns("fec_doc").Visible = True
            .Columns("fec_doc").HeaderText = "Fecha"
            .Columns("fec_doc").Width = 70
            .Columns("fec_doc").DisplayIndex = IIf(optComprasProducto.Checked = True, 6, 0)
            .Columns("raz_soc").Visible = True
            .Columns("raz_soc").HeaderText = "Proveedor"
            .Columns("raz_soc").Width = 220
            .Columns("raz_soc").DisplayIndex = IIf(optComprasProducto.Checked = True, 7, 1)
            .Columns("doc").Visible = True
            .Columns("doc").HeaderText = "Documento"
            .Columns("doc").Width = 120
            .Columns("doc").DisplayIndex = IIf(optComprasProducto.Checked = True, 8, 1)
            If chkResumen.Checked = True Then
                .Columns("fec_doc").Visible = False
                .Columns("raz_soc").Visible = False
                .Columns("doc").Visible = False
            End If
            .Columns("cod_art").Visible = True
            .Columns("cod_art").HeaderText = "Código"
            .Columns("cod_art").Width = 60
            .Columns("cod_art").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_art").DisplayIndex = IIf(optComprasProducto.Checked = True, 0, 3)
            .Columns("nom_sgrupo").Visible = True
            .Columns("nom_sgrupo").HeaderText = "Categoria"
            .Columns("nom_sgrupo").Width = 130
            .Columns("nom_sgrupo").DisplayIndex = IIf(optComprasProducto.Checked = True, 1, 4)

            .Columns("nom_art").Visible = True
            .Columns("nom_art").HeaderText = "Descripción"
            .Columns("nom_art").Width = 230
            .Columns("nom_art").DisplayIndex = IIf(optComprasProducto.Checked = True, 2, 5)
            .Columns("nom_uni").Visible = True
            .Columns("nom_uni").HeaderText = "Unidad"
            .Columns("nom_uni").Width = 60
            .Columns("nom_uni").DisplayIndex = IIf(optComprasProducto.Checked = True, 3, 6)
            .Columns("cant").HeaderText = "Cant"
            .Columns("cant").Width = 65
            .Columns("cant").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("cant").DisplayIndex = IIf(optComprasProducto.Checked = True, 4, 7)
            .Columns("precio").Visible = True
            .Columns("precio").HeaderText = "Precio Compra"
            .Columns("precio").Width = 65
            .Columns("precio").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("precio").DisplayIndex = IIf(optComprasProducto.Checked = True, 5, 8)
            .Columns("neto").HeaderText = "Monto"
            .Columns("neto").Width = 70
            .Columns("neto").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("neto").DisplayIndex = IIf(optComprasProducto.Checked = True, 6, 9)
            .Columns("tm").HeaderText = "M"
            .Columns("tm").Width = 30
            .Columns("tm").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("tm").DisplayIndex = IIf(optComprasProducto.Checked = True, 7, 10)
            .Columns("tc").HeaderText = "TC"
            .Columns("tc").Width = 40
            .Columns("tc").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("tc").DisplayIndex = IIf(optComprasProducto.Checked = True, 8, 11)
            .Columns("operacion").Visible = False
            .Columns("operacion").DisplayIndex = 9
            .Columns("ingreso").Visible = False
            .Columns("ingreso").DisplayIndex = 10
            .Columns("igv").Visible = False
            .Columns("igv").DisplayIndex = 13
            .Columns("afecto_igv").Visible = False
            .Columns("afecto_igv").DisplayIndex = 14
            .Columns("cod_sgrupo").Visible = False
            .Columns("precioDS").Visible = False
            .Columns("netoDS").Visible = False
            .Columns("cod_prov").Visible = False
        End With
    End Sub
    Sub estructuraComprasProveedor()
        With dataDetalle
            .Columns("cod_art").Visible = True
            .Columns("cod_art").HeaderText = "Código"
            .Columns("cod_art").Width = 60
            .Columns("nom_art").Visible = True
            .Columns("nom_art").HeaderText = "Descripción"
            .Columns("nom_art").Width = 300
            .Columns("nom_uni").Visible = True
            .Columns("nom_uni").HeaderText = "Unidad"
            .Columns("nom_uni").Width = 60
            .Columns("cant").Visible = True
            .Columns("cant").HeaderText = "Cantidad"
            .Columns("cant").Width = 70
            .Columns("cant").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("precio").Visible = True
            .Columns("precio").HeaderText = "Precio Compra"
            .Columns("precio").Width = 70
            .Columns("precio").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("neto").Visible = True
            .Columns("neto").HeaderText = "Monto"
            .Columns("neto").Width = 70
            .Columns("neto").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("operacion").Visible = False
            .Columns("ingreso").Visible = False
            .Columns("tm").Visible = False
            .Columns("tc").Visible = False
            .Columns("igv").Visible = False
            .Columns("afecto_igv").Visible = False
        End With
    End Sub

    Private Sub dataDetalle_CellContextMenuStripChanged(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataDetalle.CellContextMenuStripChanged

    End Sub


    Private Sub dataDetalle_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dataDetalle.DoubleClick
        cargaIngreso()
    End Sub
    Private Sub dataDetalle_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dataDetalle.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            cargaIngreso()
        End If
        If (e.Control And e.KeyCode = Keys.E) Then
            If dataDetalle.RowCount > 0 Then
                EnviaraExcel(dataDetalle)
            End If
        End If
    End Sub
    Sub cargaIngreso()
        If optRegistro.Checked = True Or OptOCompra.Checked = True Then
            Dim periodo As String = periodoSeleccionado()
            Dim IsFormCargado As Boolean = False
            Dim mForm As Form
            For Each mForm In principal.MdiChildren
                If mForm.Name = "p_ingresos" Or mForm.Name = "p_ordencompra" Then
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
                Dim lproveedor, ldocumento, lserdoc, lnrodoc As String, loperacion As Integer
                loperacion = dataDetalle.Item("operacion", dataDetalle.CurrentRow.Index).Value.ToString
                lproveedor = dataDetalle.Item("cod_prov", dataDetalle.CurrentRow.Index).Value.ToString
                ldocumento = dataDetalle.Item("cod_doc", dataDetalle.CurrentRow.Index).Value.ToString
                lserdoc = dataDetalle.Item("ser_doc", dataDetalle.CurrentRow.Index).Value
                lnrodoc = dataDetalle.Item("nro_doc", dataDetalle.CurrentRow.Index).Value
                If optRegistro.Checked = True Then
                    principal.mp_ingreso.Enabled = False
                    Dim mformIngresos As New p_ingresos
                    mformIngresos.MdiParent = principal
                    mformIngresos.datosParaEdicion(lproveedor, ldocumento, lserdoc, lnrodoc)
                    mformIngresos.Show()
                    mformIngresos.cargaIngreso(loperacion, periodoSeleccionado)
                    mformIngresos.Refresh()
                    mformIngresos.dataDetalle.Focus()
                End If

                If OptOCompra.Checked = True Then
                    principal.mp_ingreso.Enabled = False
                    Dim mformIngresos As New p_ordencompra
                    mformIngresos.MdiParent = principal
                    mformIngresos.datosParaEdicion(lproveedor, ldocumento, lserdoc, lnrodoc)
                    mformIngresos.Show()
                    mformIngresos.cargaIngreso(loperacion, periodoSeleccionado)
                    mformIngresos.Refresh()
                    mformIngresos.dataDetalle.Focus()
                End If

            End If
        End If
    End Sub
    Private Sub tabGrupos_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tabGrupos.Click
        If Not estaCargando Then
            muestraComprasGrupo()
            dataResumenGrupo.Focus()
        End If
    End Sub
    Private Sub cboAlmacenGrupo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not estaCargando Then
            muestraComprasGrupo()
        End If
    End Sub

    Sub muestraComprasGrupo()
        Dim mIngresos As New Ingreso
        Dim periodo As String = periodoSeleccionado()
        Dim cOrden As String = ""
        Dim esMoneda As Boolean, mMoneda As String = "D"
        Dim esHistorial As Boolean = IIf(periodo = periodoActivo(), False, True)
        Dim esMensual As Boolean = IIf(chkDia.Checked = False, True, False)
        Dim cEmpresa As String = cboEmpresa.SelectedValue
        Dim xAlmacen As Boolean = IIf(chkAlmacen.Checked = True, True, False)
        Dim cAlmacen As String = cboAlmacen.SelectedValue
        Dim preciosConIMP As Boolean = IIf(chkIMP.Checked = True, True, False)
        Dim xMonedaCompra As Boolean = chkCostosMonedaCompra.Checked
        Dim cAgrupado As String = "articulo.cod_sgrupo"
        'verificamos el tipo de moneda
        If (chkMoneda.Checked = True And chkDolares.Checked = True) Or (chkMoneda.Checked = False And chkDolares.Checked = False) Then
            esMoneda = False
        Else
            esMoneda = True
            If chkMoneda.Checked = True Then
                mMoneda = pMonedaAbr
            Else
                mMoneda = "D"
            End If
        End If
        dsIngresosG = mIngresos.recuperaArticulosIngresados(esHistorial, periodo, True, cAgrupado, True, False, _
                                False, dtiDesde.Value, dtiHasta.Value, pDecimales, xAlmacen, cAlmacen, False, "", False, "", _
                                False, "", False, False, "", preciosConIMP, esMoneda, mMoneda, cPrecioCI, chPrecioCI, cPrecioSI, chPrecioSI, _
                                cPrecioCIs, chPrecioCIs, cPrecioSIs, chPrecioSIs, "nom_sgrupo", False, pEmpresa, xMonedaCompra)
        dataResumenGrupo.DataSource = dsIngresosG.Tables("ingreso").DefaultView
        estructuraCompras_xGrupo()
    End Sub
    Sub estructuraCompras_xGrupo()
        With dataResumenGrupo
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_sgrupo").HeaderText = "Código"
            .Columns("cod_sgrupo").Width = 60
            .Columns("cod_sgrupo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_sgrupo").DisplayIndex = 0
            .Columns("nom_sgrupo").HeaderText = "Grupo"
            .Columns("nom_sgrupo").Width = 200
            .Columns("nom_sgrupo").DisplayIndex = 1
            .Columns("netoDS").HeaderText = "Monto"
            .Columns("netoDS").Width = 80
            .Columns("netoDS").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("netoDS").DisplayIndex = 2
            .Columns("operacion").Visible = False
            .Columns("ingreso").Visible = False
            .Columns("tm").Visible = False
            .Columns("tc").Visible = False
            .Columns("igv").Visible = False
            .Columns("afecto_igv").Visible = False
            .Columns("fec_doc").Visible = False
            .Columns("raz_soc").Visible = False
            .Columns("doc").Visible = False
            .Columns("cod_art").Visible = False
            .Columns("nom_art").Visible = False
            .Columns("nom_uni").Visible = False
            .Columns("cant").Visible = False
            .Columns("precio").Visible = False
            .Columns("precioDS").Visible = False
            .Columns("neto").Visible = False
            .Columns("netoDS").Visible = True
            .Columns("cod_prov").Visible = False
        End With
    End Sub
    Private Sub chkAlmacenResumen_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAlmacenResumen.CheckedChanged
        If Not estaCargando Then
            Dim mCantidades As Boolean
            If chkAlmacenResumen.Checked = False Then
                cboAlmacenResumen.SelectedIndex = -1
                cboAlmacenResumen.Enabled = False
            Else
                cboAlmacenResumen.Enabled = True
                cboAlmacenResumen.SelectedIndex = 0
            End If
            If optCantidades.Checked = True Then
                mCantidades = True
            Else
                mCantidades = False
            End If
            muestraResumen(mCantidades)
        End If
    End Sub
    Private Sub optCantidades_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optCantidades.CheckedChanged
        If optCantidades.Checked = True Then
            lblMensaje.Visible = False
            lblMensaje.Refresh()
            muestraResumen(True)
        End If
    End Sub
    Private Sub optValorizado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optValorizado.CheckedChanged
        If optValorizado.Checked Then
            lblMensaje.Visible = False
            lblMensaje.Refresh()
            muestraResumen(False)
        End If
    End Sub
    Private Sub txtBuscarResumenAnual_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscarResumenAnual.TextChanged
        Dim valor As String = txtBuscarResumenAnual.Text
        If optCantidades.Checked = True Or optValorizado.Checked = True Then
            dsResumenAnual.Tables("articulo").DefaultView.RowFilter = "nom_art LIKE '" & valor & "%'"
            If dataResumenAnual.RowCount > 0 Then
                dataResumenAnual.CurrentCell = dataResumenAnual("nom_art", dataResumenAnual.CurrentRow.Index)
            End If
        End If
    End Sub
    Sub muestraResumen(ByVal enCantidades As Boolean)
        Dim mResumen As New Resumen, periodo As Integer
        'dim    X As Integer,  nValor As Decimal = 0.0
        Dim mIngresos As New Ingreso
        dataResumenAnual.DataSource = ""
        dataResumenAnual.Refresh()
        'Dim esHistorial As Boolean
        Dim xAlmacen As Boolean = IIf(cboAlmacenResumen.SelectedIndex >= 0, True, False)
        Dim cAlmacen As String = cboAlmacenResumen.SelectedValue
        Dim preciosConIMP As Boolean = IIf(chkIMP.Checked = True, True, False)
        Dim valor As String = IIf(optValorizado.Checked = True, "cant*precio", "cant")
        lblMensaje.Visible = False
        barraResumen.Visible = True
        barraResumen.Value = 4
        barraResumen.Text = "4%"
        periodo = cboAnno.SelectedIndex + 2010
        dsResumenAnual = mResumen.recuperaCatalogo_paraResumenAnual(True, cAlmacen, periodo, valor, True)
        dataResumenAnual.DataSource = dsResumenAnual.Tables("articulo").DefaultView
        estructuraResumen()
        barraResumen.Value = 7.5
        barraResumen.Text = "7.5%"
        'cargamos las compras, mes x mes
        'For I = 1 To 12
        '    periodo = Trim(Str(cboAnno.SelectedIndex + 2010)) & Microsoft.VisualBasic.Right("00" & Trim(Str(I)), 2)
        '    esHistorial = IIf(periodo = periodoActivo(), False, True)
        '    Dim codigo As String = "", mes As String = ""
        '    For X = 0 To dataResumenAnual.RowCount - 1
        '        mes = "m" & I
        '        codigo = dataResumenAnual("cod_art", X).Value
        '        If enCantidades Then
        '            nValor = mIngresos.recCant_ingresoArticulo(esHistorial, periodo, True, dtiDesde.Value, xAlmacen, cAlmacen, codigo)
        '        Else
        '            nValor = mIngresos.recMonto_ingresoArticulo(esHistorial, periodo, True, dtiDesde.Value, xAlmacen, cAlmacen, _
        '                        codigo, preciosConIMP, pDecimales, cPrecioCI, chPrecioCI, cPrecioSI, chPrecioSI)
        '        End If
        '        dataResumenAnual(mes, X).Value = nValor
        '    Next
        '    barraResumen.Value = 7.5 * (I + 1)
        '    barraResumen.Text = 7.5 * (I + 1) & "%"
        'Next
        barraResumen.Value = 100
        barraResumen.Visible = False
        dataResumenAnual.Focus()
        dataResumenAnual.Refresh()
        lblMensaje.Visible = True
        If enCantidades Then
            lblMensaje.Text = "Resumen en Cantidades"
        Else
            lblMensaje.Text = "Resumen Valorizado en " & pMoneda
        End If
    End Sub
    Sub estructuraResumen()
        With dataResumenAnual
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("raz_soc").HeaderText = "Proveedor"
            .Columns("raz_soc").Width = 90
            .Columns("raz_soc").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns("nom_art").HeaderText = "Descripción"
            .Columns("nom_art").Width = 140
            .Columns("nom_sgrupo").HeaderText = "Grupo"
            .Columns("nom_sgrupo").Width = 50
            .Columns("nom_uni").HeaderText = "Unidad"
            .Columns("nom_uni").Width = 50
            .Columns("pre_ult").HeaderText = "Precio"
            .Columns("pre_ult").Width = 50
            .Columns("m1").HeaderText = "Enero"
            .Columns("m1").Width = 50
            .Columns("m1").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("m2").HeaderText = "Febrero"
            .Columns("m2").Width = 50
            .Columns("m2").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("m3").HeaderText = "Marzo"
            .Columns("m3").Width = 50
            .Columns("m3").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("m4").HeaderText = "Abril"
            .Columns("m4").Width = 50
            .Columns("m4").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("m5").HeaderText = "Mayo"
            .Columns("m5").Width = 50
            .Columns("m5").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("m6").HeaderText = "Junio"
            .Columns("m6").Width = 50
            .Columns("m6").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("m7").HeaderText = "Julio"
            .Columns("m7").Width = 50
            .Columns("m7").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("m8").HeaderText = "Agosto"
            .Columns("m8").Width = 50
            .Columns("m8").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("m9").HeaderText = "Set."
            .Columns("m9").Width = 50
            .Columns("m9").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("m10").HeaderText = "Oct."
            .Columns("m10").Width = 50
            .Columns("m10").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("m11").HeaderText = "Nov."
            .Columns("m11").Width = 50
            .Columns("m11").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("m12").HeaderText = "Dic."
            .Columns("m12").Width = 50
            .Columns("m12").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("total").HeaderText = "Total"
            .Columns("total").Width = 50
            .Columns("total").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        End With
    End Sub
    Private Sub chkAgrupar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAgrupar.CheckedChanged
        If optComprasProveedor.Checked And chkResumen.Checked Then
            chkAgrupar.Checked = False
        End If
    End Sub
    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        Dim periodo As String = periodoSeleccionado()
        Dim periodoReporte As String = "Periodo: " & general.periodo_mesAnnoLetras(periodo)
        Dim preciosConImp As String = IIf(chkIMP.Checked = True, "*Precios Incluyen Impuesto", "*Precios NO Incluyen Impuesto")
        Dim fechaReporte As String
        Dim frm As New rptForm
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
                    fechaReporte = general.devuelveFechaImpresionEspecificado(dtiDesde.Value) _
                        & " al " & general.devuelveFechaImpresionEspecificado(pFechaSystem)
                End If
            Else
                If Microsoft.VisualBasic.DateAndTime.Day(dtiDesde.Value) = 1 Then
                    fechaReporte = "Al: " & general.devuelveFechaImpresionEspecificado(dtiHasta.Value)
                Else
                    fechaReporte = general.devuelveFechaImpresionEspecificado(dtiDesde.Value) _
                        & " al " & general.devuelveFechaImpresionEspecificado(dtiHasta.Value)
                End If
            End If
        End If
        'verificamos el tipo de moneda del reporte
        Dim lMoneda As String = ""
        If chkMoneda.Checked = True And chkDolares.Checked = False Then
            lMoneda = "-" & pMoneda
        Else
            If chkMoneda.Checked = False And chkDolares.Checked = True Then
                lMoneda = "-Dolares"
            End If
        End If
        'llamamos a los reportes
        Dim repAgrupado As Boolean = IIf(chkAgrupar.Checked = True, True, False)
        Dim titulo As String = IIf(chkAlmacen.Checked = True, cboAlmacen.Text, "Empresa: " & cboEmpresa.Text)
        Dim titReporte As String = IIf(chkDetalle.Checked = True, ", Detallado", ", Resumen")
        If optRegistro.Checked = True Then
            frm.cargarRegistroIngresos(dsIngresos, titulo & lMoneda, fechaReporte, periodoReporte, pMoneda, preciosConImp, repAgrupado)
        End If
        If optComprasProducto.Checked = True Then
            If chkDetalle.Checked = True Then
                frm.cargarRegistroIngresosProducto(dsIngresos, titulo & titReporte, fechaReporte, periodoReporte, _
                                                    pMoneda, preciosConImp, False, repAgrupado)
            Else
                frm.cargarRegistroIngresosProducto(dsIngresos, titulo & titReporte, fechaReporte, periodoReporte, _
                                                    pMoneda, preciosConImp, False, repAgrupado)
            End If
        End If
        If optComprasProveedor.Checked = True Then
            If chkResumen.Checked = True Then
                frm.cargarRegistroIngresosProveedor(dsIngresos, titulo & titReporte, fechaReporte, periodoReporte, _
                                                    pMoneda, preciosConImp, False, False, repAgrupado)
            Else
                frm.cargarRegistroIngresosProveedor(dsIngresos, titulo & titReporte, fechaReporte, periodoReporte, _
                                                     pMoneda, preciosConImp, False, True, repAgrupado)
            End If
        End If
        frm.MdiParent = principal
        frm.Show()
    End Sub
    Private Sub cmdCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Dim ds As New DataSet
        Dim cad As String
        cad = " select nom_sgrupo,sum(cant) as cant from ingreso inner join ingreso_det on ingreso.operacion=ingreso_det.operacion" _
                & " inner join articulo on ingreso_det.cod_art=articulo.cod_art" _
                & " inner join subgrupo on articulo.cod_sgrupo=subgrupo.cod_sgrupo" _
                & " where cod_doc = '01' group by articulo.cod_sgrupo"
        Dim com As New MySqlCommand
        com.Connection = dbConex
        com.CommandText = cad
        Dim da As New MySqlDataAdapter
        da.SelectCommand = com
        da.Fill(ds, "compras")
        Dim a, b, c, d, f, g As Decimal, I As Integer
        For I = 0 To ds.Tables("compras").Rows.Count - 1
            If I = 0 Then
                a = ds.Tables("compras").Rows(I).Item("cant").ToString
            End If
            If I = 1 Then
                b = ds.Tables("compras").Rows(I).Item("cant").ToString
            End If
            If I = 2 Then
                c = ds.Tables("compras").Rows(I).Item("cant").ToString
            End If
            If I = 3 Then
                d = ds.Tables("compras").Rows(I).Item("cant").ToString
            End If
            If I = 4 Then
                f = ds.Tables("compras").Rows(I).Item("cant").ToString
            End If
            If I = 5 Then
                g = ds.Tables("compras").Rows(I).Item("cant").ToString
            End If
        Next
        chartCompras.DataPoints = New List(Of Double)(New Double() {a, b, c, d, f, g})
        chartCompras.BarChartStyle.HighPointBarColor = Color.AliceBlue
        chartCompras.Text = "Profit: "
        chartCompras.ChartType = DevComponents.DotNetBar.eMicroChartType.Column
        chartCompras.Text = "sssssss"
        'ontainer1.SubItems.Add(microChart)
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim mIngresos As New Ingreso
        Dim periodo As String = periodoSeleccionado()
        Dim cOrden As String = ""
        Dim esMoneda As Boolean, mMoneda As String = "D"
        Dim esHistorial As Boolean = IIf(periodo = periodoActivo(), False, True)
        Dim esMensual As Boolean = IIf(chkDia.Checked = False, True, False)
        Dim esSoloCompras As Boolean = IIf(chkSoloCompras.Checked = True, True, False)
        Dim cEmpresa As String = cboEmpresa.SelectedValue
        Dim xAlmacen As Boolean = IIf(chkAlmacen.Checked = True, True, False)
        Dim cAlmacen As String = cboAlmacen.SelectedValue
        Dim preciosConIMP As Boolean = IIf(chkIMP.Checked = True, True, False)
        Dim xMonedaCompra As Boolean = chkCostosMonedaCompra.Checked
        Dim cAgrupado As String = "articulo.cod_sgrupo"
        'verificamos el tipo de moneda
        If (chkMoneda.Checked = True And chkDolares.Checked = True) Or (chkMoneda.Checked = False And chkDolares.Checked = False) Then
            esMoneda = False
        Else
            esMoneda = True
            If chkMoneda.Checked = True Then
                mMoneda = pMonedaAbr
            Else
                mMoneda = "D"
            End If
        End If
        dsIngresosG = mIngresos.recuperaArticulosIngresados(esHistorial, periodo, True, cAgrupado, True, False, _
                                True, dtiDesde.Value, dtiHasta.Value, pDecimales, False, cAlmacen, False, "", False, "", _
                                False, "", False, False, "", preciosConIMP, esMoneda, mMoneda, cPrecioCI, chPrecioCI, cPrecioSI, chPrecioSI, _
                                cPrecioCIs, chPrecioCIs, cPrecioSIs, chPrecioSIs, "nom_sgrupo", False, pEmpresa, xMonedaCompra)
        dataResumenGrupo.DataSource = dsIngresosG.Tables("ingreso").DefaultView
        estructuraCompras_xGrupo()
    End Sub



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim appExcel As Microsoft.Office.Interop.Excel.Application
        Dim wbExcel As Microsoft.Office.Interop.Excel.Workbook

        System.Threading.Thread.CurrentThread.CurrentCulture = _
      System.Globalization.CultureInfo.CreateSpecificCulture("en-US")

        dataResumenGrupo.SelectAll()
        dataResumenGrupo.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Clipboard.SetDataObject(dataResumenGrupo.GetClipboardContent())

        appExcel = New Microsoft.Office.Interop.Excel.Application
        appExcel.SheetsInNewWorkbook = 1
        wbExcel = appExcel.Workbooks.Add
        appExcel.Visible = True

        wbExcel.Worksheets(1).range("A1").Select()
        wbExcel.Worksheets(1).Paste()
    End Sub



    Private Sub dataResumenGrupo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dataResumenGrupo.KeyDown
        If (e.Control And e.KeyCode = Keys.E) Then
            If dataResumenGrupo.RowCount > 0 Then
                EnviaraExcel(dataResumenGrupo)
            End If
        End If
    End Sub


    Private Sub dataResumenAnual_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dataResumenAnual.KeyDown
        If (e.Control And e.KeyCode = Keys.E) Then
            If dataResumenAnual.RowCount > 0 Then
                EnviaraExcel(dataResumenAnual)
            End If
        End If
    End Sub



    Private Sub OptOCompra_CheckedChanged(sender As Object, e As EventArgs) Handles OptOCompra.CheckedChanged
        If Not estaCargando And OptOCompra.Checked = True Then
            ordenIngresos()
            chkDetalle.Checked = False
            chkResumen.Checked = True
            txtBuscar.Text = ""
            optProveedor.Enabled = True
            optDocumento.Text = "Documento"
            optProveedor.Text = "Proveedor"
            optDocumento.Checked = True
            muestraIngresos()
        End If
    End Sub

    Private Sub dataDetalle_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataDetalle.CellContentClick

    End Sub

    Private Sub dtiHasta_Click(sender As Object, e As EventArgs) Handles dtiHasta.Click

    End Sub

    Private Sub dtiDesde_Click(sender As Object, e As EventArgs) Handles dtiDesde.Click

    End Sub
End Class
