Imports System.Data
Imports MySql.Data.MySqlClient
Imports libreriaClases
Public Class c_kardex
    Private dsArticulo As New DataSet
    Private dsKardex As New DataSet
    Private dsAlmacen As New DataSet
    Private dsAlmacen_d As New DataSet
    Private dsGrupo As New DataSet
    Private cPrecioCI As String = general.str_PrecioCompraCI
    Private chPrecioCI As String = general.str_hPrecioCompraCI
    Private cPrecioSI As String = general.str_PrecioCompraSIs
    Private chPrecioSI As String = general.str_hPrecioCompraSI
    Private estaCargando As Boolean = True
    Private Sub c_kardex_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If Not estaCargando Then
            muestraKardex()
        End If
    End Sub
    Private Sub c_kardex_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        principal.mr_kardex.Enabled = True
    End Sub
    Private Sub c_kardex_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        ''dataset almacen
        'Dim cadAlma As String = ""
        'If pAlmaUser = "0000" Then
        '    cadAlma = "select distinct almacen.cod_alma,nom_alma" _
        '            & " from almacen left join area on almacen.cod_alma=area.cod_alma" _
        '            & " where almacen.activo=1 and ((esCompras) or (almacen.destinoTrans)" _
        '            & " or (area.destinoTrans))" & " order by nom_alma"
        'Else
        '    cadAlma = "select cod_alma,nom_alma from almacen where cod_alma='" _
        '            & pAlmaUser & "' and activo=1"
        'End If
        'Dim daAlmacen As New MySqlDataAdapter
        'Dim comAlmacen As New MySqlCommand(cadAlma, dbConex)
        'daAlmacen.SelectCommand = comAlmacen
        'daAlmacen.Fill(dsAlmacen, "almacen")
        'With cboAlmacen
        '    .DataSource = dsAlmacen.Tables("almacen")
        '    .DisplayMember = dsAlmacen.Tables("almacen").Columns("nom_alma").ToString
        '    .ValueMember = dsAlmacen.Tables("almacen").Columns("cod_alma").ToString
        '    If dsAlmacen.Tables("almacen").Rows.Count > 0 Then
        '        .SelectedIndex = 0
        '    End If
        'End With

        Dim daGrupo As New MySqlDataAdapter
        'Dim comGrupo As New MySqlCommand("select cod_sgrupo,nom_sgrupo from subgrupo where (activo) ", dbConex)
        Dim comGrupo As New MySqlCommand("select cod_cuenta,nom_cuenta from cuenta where (activo) ", dbConex)
        daGrupo.SelectCommand = comGrupo
        daGrupo.Fill(dsGrupo, "grupo")
        With cbogrupo
            .DataSource = dsGrupo.Tables("grupo")
            '.DisplayMember = dsGrupo.Tables("grupo").Columns("nom_sgrupo").ToString
            '.ValueMember = dsGrupo.Tables("grupo").Columns("cod_sgrupo").ToString
            .DisplayMember = dsGrupo.Tables("grupo").Columns("nom_cuenta").ToString
            .ValueMember = dsGrupo.Tables("grupo").Columns("cod_cuenta").ToString
            If dsGrupo.Tables("grupo").Rows.Count > 0 Then
                .SelectedIndex = 0
            End If
        End With
        cargaAlmacenes()
        estaCargando = False
        muestraArticulos("*")
        estableceFechas()
        muestraKardex()
    End Sub
    Sub cargaAlmacenes()
        'dataset almacen origen/destino
        Dim daAlmacen_o As New MySqlDataAdapter
        Dim daAlmacen_d As New MySqlDataAdapter
        Dim cadena, cadena_dest As String
        If pAlmaUser = "0000" Then
            cadena = "select cod_alma,nom_alma from almacen where activo=1" _
                                  & " and (origenTrans) and (tieneideales) order by nom_alma"
            cadena_dest = "select distinct almacen.cod_alma,nom_alma" _
                                & " from almacen left join area on almacen.cod_alma=area.cod_alma" _
                                & " where almacen.activo=1 and (almacen.tieneideales) and ((almacen.destinoTrans) or (area.destinoTrans))" _
                                & " order by nom_alma"
        Else
            cadena = "select distinct almacen.cod_alma,nom_alma" _
                                             & " from almacen left join area on almacen.cod_alma=area.cod_alma" _
                                             & " where almacen.activo=1 and (tieneideales) and ((almacen.destinoTrans) or (area.destinoTrans))" _
                                             & " order by nom_alma"
            cadena_dest = "select distinct almacen.cod_alma,nom_alma" _
                                & " from almacen left join area on almacen.cod_alma=area.cod_alma" _
                                & " left join usuario_almacen u on u.cod_alma=almacen.cod_alma " _
                                & " where almacen.activo=1 and (almacen.tieneideales) and ((almacen.destinoTrans) or (area.destinoTrans))" _
                                & " and u.cuenta= '" & pCuentaUser & "'" _
                                & " order by nom_alma"
        End If
        'Dim comAlmacen_o As New MySqlCommand(cadena, dbConex)
        Dim comAlmacen_d As New MySqlCommand(cadena_dest, dbConex)
        'daAlmacen_o.SelectCommand = comAlmacen_o
        daAlmacen_d.SelectCommand = comAlmacen_d
        ' daAlmacen_o.Fill(dsAlmacen_o, "almacen")
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
            .SelectedIndex = -1
        End With
        'muestraArea(cboAlmacen.SelectedValue)
    End Sub
    'Sub muestraArea(ByVal cod_alma As String)
    '    dsArea.Clear()
    '    Dim daArea As New MySqlDataAdapter
    '    Dim comArea As New MySqlCommand("select cod_area,nom_area from area where activo=1" _
    '                    & " and (destinoTrans) and cod_alma='" & cod_alma & "' order by nom_area", dbConex)
    '    daArea.SelectCommand = comArea
    '    daArea.Fill(dsArea, "area")
    '    With cboArea
    '        .DataSource = dsArea.Tables("area")
    '        .DisplayMember = dsArea.Tables("area").Columns("nom_area").ToString
    '        .ValueMember = dsArea.Tables("area").Columns("cod_area").ToString
    '        If dsArea.Tables("area").Rows.Count > 0 Then
    '            ' If _nroTransferencia = 0 Then
    '            lblArea.Enabled = True
    '            cboArea.Enabled = True
    '            .SelectedIndex = 0
    '            'End If
    '        Else
    '            lblArea.Enabled = False
    '            cboArea.Enabled = False
    '            .SelectedIndex = -1
    '        End If
    '    End With
    'End Sub
    Sub muestraArticulos(ByVal cad As String)

        dsArticulo.Clear()
        Dim mAlmacen As New Almacen
        'Dim xAlmacen As Boolean = IIf(cboAlmacen.SelectedIndex = -1, False, True)
        Dim xgrupo As Boolean = IIf(chkgrupo.Checked = False, False, True)
        Dim cAlma As String = cboAlmacen.SelectedValue
        Dim cAlmaCatalogo As String = mAlmacen.devuelveAlmacenCatalogo(cAlma)
        Dim daArticulo As New MySqlDataAdapter, lCadena, c1, c2, c2a, c3 As String
        Dim xProduccion As Boolean = IIf(chkProduccion.Checked = True, True, False)
        Dim xAlmacen As Boolean = True
        cAlmaCatalogo = IIf(xProduccion = False, cAlma, cAlmaCatalogo)
        c1 = "Select articulo.cod_art,nom_art,nom_uni,pre_costo,pre_ult,afecto_igv,pre_costoMax"
        c2 = " from articulo inner join unidad on articulo.cod_uni=unidad.cod_uni"
        c2a = " inner join subgrupo on articulo.cod_sgrupo=subgrupo.cod_sgrupo"
        c3 = " where   " _
                        & IIf(xAlmacen, " articulo.cod_alma='" & cAlmaCatalogo & "'", "") _
                        & IIf(xgrupo, " and articulo.cod_sgrupo='" & cbogrupo.SelectedValue & "'", "") _
                        & IIf(cad = "*", " order by nom_art LIMIT 10000", "and nom_art like '" & cad & "%' order by nom_art")
        lCadena = c1 + c2 + c2a + c3
        Dim comArt As New MySqlCommand(lCadena, dbConex)
        daArticulo.SelectCommand = comArt
        daArticulo.Fill(dsArticulo, "articulo")
        If dsArticulo.Tables("articulo").Rows.Count > 0 Then
            With dataArticulo
                .DataSource = dsArticulo.Tables("articulo").DefaultView
                .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns("cod_art").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns("cod_art").HeaderText = "Código"
                .Columns("cod_art").Width = 60
                .Columns("nom_art").HeaderText = "Descripción"
                .Columns("nom_art").Width = 285
                .Columns("nom_uni").HeaderText = "Unidad"
                .Columns("nom_uni").Width = 73
                .Columns("pre_costo").HeaderText = "Pre.Costo"
                .Columns("pre_costo").Width = 75
                .Columns("pre_costo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns("pre_ult").Visible = False
                .Columns("afecto_igv").Visible = False
                .Columns("pre_costoMax").Visible = False
            End With
            If dataArticulo.RowCount > 0 Then
                dataArticulo.CurrentCell = dataArticulo(1, 0)
                dataArticulo.Refresh()
            End If
        End If
    End Sub
    Sub muestraKardex()
        If dataArticulo.RowCount > 0 Then
            Dim mkardex As New kardex
            Dim periodo As String = periodoSeleccionado()
            dsKardex.Clear()
            lblRegistros.Text = "Nº de Registros Procesados... 0"
            lblPrecioPromedio.Text = "Precio Costo Promedio. 0.000"
            lblInicial.Text = "0.00"
            lblIngresos.Text = "0.00"
            lblSalidas.Text = "0.00"
            lblStock.Text = "0.00"
            Dim codigo As String = dataArticulo.Item("cod_art", dataArticulo.CurrentRow.Index).Value
            Dim pre_costoMax As Decimal = dataArticulo.Item("pre_costoMax", dataArticulo.CurrentRow.Index).Value
            Dim esHistorial As String = IIf(periodo = periodoActivo(), False, True)
            Dim esMensual As Boolean = IIf(chkDia.Checked = True, False, True)
            Dim xAlmacen As Boolean = IIf(cboAlmacen.SelectedIndex >= 0, True, False)
            Dim xGrupo As Boolean = IIf(chkgrupo.Checked = True, True, False)
            Dim preciosConIGV As Boolean = IIf(chkIncIGV.Checked = True, True, False)

            dsKardex = mkardex.recuperaKardex(esHistorial, periodo, esMensual, dtiDesde.Value, dtiHasta.Value, pDecimales, _
                                    xAlmacen, cboAlmacen.SelectedValue, xGrupo, cbogrupo.SelectedValue, codigo, pre_costoMax, preciosConIGV, pMonedaAbr, _
                                    cPrecioCI, chPrecioCI, cPrecioSI, chPrecioSI)
            dataKardex.DataSource = dsKardex.Tables("kardex").DefaultView
            lblRegistros.Text = "Nº de Registros Procesados... " & dataKardex.RowCount.ToString
            estructuraKardex()
            coloreaIngresoDolares()
            coloreaSobrePrecio()
        Else
            dsKardex.Clear()
        End If
    End Sub
    Sub muestraKardexImp(ByVal codigo As String)
        ' If dataArticulo.RowCount > 0 Then
        Dim mkardex As New kardex
            Dim periodo As String = periodoSeleccionado()
            dsKardex.Clear()
            lblRegistros.Text = "Nº de Registros Procesados... 0"
            lblPrecioPromedio.Text = "Precio Costo Promedio. 0.000"
            lblInicial.Text = "0.00"
            lblIngresos.Text = "0.00"
            lblSalidas.Text = "0.00"
            lblStock.Text = "0.00"
        '    Dim pre_costoMax As Decimal = dataArticulo.Item("pre_costoMax", dataArticulo.CurrentRow.Index).Value
        Dim pre_costoMax As Decimal = 0.0
        Dim esHistorial As String = IIf(periodo = periodoActivo(), False, True)
        Dim esMensual As Boolean = IIf(chkDia.Checked = True, False, True)
            Dim xAlmacen As Boolean = IIf(cboAlmacen.SelectedIndex >= 0, True, False)
            Dim xgrupo As Boolean = IIf(chkgrupo.Checked = True, True, False)
            Dim preciosConIGV As Boolean = IIf(chkIncIGV.Checked = True, True, False)
            dsKardex = mkardex.recuperaKardex(esHistorial, periodo, esMensual, dtiDesde.Value, dtiHasta.Value, pDecimales, _
                                    xAlmacen, cboAlmacen.SelectedValue, xgrupo, cbogrupo.SelectedValue, codigo, pre_costoMax, preciosConIGV, pMonedaAbr, _
                                    cPrecioCI, chPrecioCI, cPrecioSI, chPrecioSI)
            dataKardex.DataSource = dsKardex.Tables("kardex").DefaultView
            lblRegistros.Text = "Nº de Registros Procesados... " & dataKardex.RowCount.ToString
            estructuraKardex()
            coloreaIngresoDolares()
            coloreaSobrePrecio()
        'Else
        '    dsKardex.Clear()
        'End If
    End Sub
    Sub estructuraKardex()
        With dataKardex
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("fec_doc").HeaderText = "Fecha"
            .Columns("fec_doc").Width = 70
            .Columns("fec_doc").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("clie_prov").HeaderText = "Cliente/Proveedor"
            .Columns("clie_prov").Width = 240
            .Columns("documento").HeaderText = "Documento"
            .Columns("documento").Width = 120
            .Columns("inicial").HeaderText = "Inicial"
            .Columns("inicial").Width = 70
            .Columns("inicial").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("ingresos").HeaderText = "Ingresos"
            .Columns("ingresos").Width = 60
            .Columns("ingresos").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("salidas").HeaderText = "Salidas"
            .Columns("salidas").Width = 60
            .Columns("salidas").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("saldo").HeaderText = "Stock"
            .Columns("saldo").Width = 70
            .Columns("saldo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("precio").HeaderText = "Valor Unitario"
            .Columns("precio").Width = 75
            .Columns("precio").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("monto").HeaderText = "Importe "
            .Columns("monto").Width = 75
            .Columns("monto").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("preciopro").HeaderText = "Precio Promedio"
            .Columns("preciopro").Width = 75
            .Columns("preciopro").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("montopro").HeaderText = "Monto Promedio"
            .Columns("montopro").Width = 75
            .Columns("montopro").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("tm").HeaderText = "TM"
            .Columns("tm").Width = 25
            .Columns("tm").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("tc").HeaderText = "T.C."
            .Columns("tc").Width = 55
            .Columns("tc").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("nom_sgrupo").HeaderText = "Grupo"
            .Columns("nom_sgrupo").Width = 100
            .Columns("nom_sgrupo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("nroDocumento").Visible = False
            .Columns("operacion").Visible = False
            .Columns("igv").Visible = False
            .Columns("cod_art").Visible = False
            .Columns("ingreso").Visible = False
            .Columns("salida").Visible = False
            .Columns("pre_costoMax").Visible = False
            .Columns("nom_art").Visible = False
            .Columns("cod_unisunat").Visible = False
            .Columns("cod_sgruposunat").Visible = False
            .Columns("cod_docsunat").Visible = False
            .Columns("cod_opesunat").Visible = False


        End With
    End Sub
    Private Sub cboMes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMes.SelectedIndexChanged
        If Not estaCargando Then
            estableceFechas()
            chkDia.CheckState = CheckState.Unchecked
            If Not estaCargando Then
                muestraKardex()
            End If
        End If
    End Sub
    Private Sub cboAnno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAnno.SelectedIndexChanged
        If Not estaCargando Then
            estableceFechas()
            chkDia.CheckState = CheckState.Unchecked
            If Not estaCargando Then
                muestraKardex()
            End If
        End If
    End Sub
    Private Sub chkDia_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDia.CheckedChanged
        If Not estaCargando Then
            estableceFechas()
            If chkDia.CheckState = CheckState.Checked Then
                dtiDesde.Enabled = True
                dtiHasta.Enabled = True
                muestraKardex()
            Else
                dtiDesde.Enabled = False
                dtiHasta.Enabled = False
            End If
            If Not estaCargando Then
                muestraKardex()
            End If
        End If
    End Sub
    Private Sub dtiDesde_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtiDesde.ValueChanged
        If Not estaCargando Then
            muestraKardex()
        End If
    End Sub
    Private Sub dtiHasta_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtiHasta.ValueChanged
        If Not estaCargando Then
            muestraKardex()
        End If
    End Sub
    Private Sub cboAlmacen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAlmacen.SelectedIndexChanged
        If Not estaCargando Then
            muestraKardex()
            muestraArticulos(txtBuscar.Text)
            txtBuscar.Focus()
        End If
    End Sub
    Private Sub chkMoneda_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not estaCargando Then
            muestraKardex()
        End If
    End Sub
    Private Sub chkDolares_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not estaCargando Then
            muestraKardex()
        End If
    End Sub
    Private Sub chkIncIGV_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkIncIGV.CheckedChanged
        If Not estaCargando Then
            muestraKardex()
            If chkIncIGV.CheckState = CheckState.Checked Then
                chkIncIGV.Text = "Mostrar Precios CON Impuesto"
            Else
                chkIncIGV.Text = "Mostrar Precios SIN Impuesto"
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
            mFecha = Microsoft.VisualBasic.DateAndTime.DateAdd(DateInterval.Day, -1, _
                    general.convierteTexto_enFecha(1, 1, Val(cboAnno.Text) + 1))
        Else
            mFecha = Microsoft.VisualBasic.DateAndTime.DateAdd(DateInterval.Day, -1, _
                    general.convierteTexto_enFecha(1, cboMes.SelectedIndex + 2, Val(cboAnno.Text)))
        End If
        Return mFecha
    End Function
    Sub estableceFechas()
        If Not estaCargando Then
            Dim periodo As String = periodoSeleccionado()
            If periodo <> general.periodoActivo Then
                dtiDesde.ResetMinDate()
                dtiDesde.MinDate = fechaI()
                dtiDesde.ResetMaxDate()
                dtiDesde.MaxDate = fechaF()
                dtiDesde.Value = fechaI()

                'dtiHasta.ResetMaxDate()
                'dtiHasta.MinDate = pFechaActivaMin
                'dtiHasta.ResetMaxDate()
                'dtiHasta.MaxDate = pFechaActivaMax
                'dtiHasta.Value = pFechaActivaMax
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
        End If
    End Sub
    Function periodoSeleccionado()
        Dim periodo As String = ""
        If Not estaCargando Then
            periodo = Trim(Str(cboAnno.SelectedIndex + 2010)) & Microsoft.VisualBasic.Right("00" & Trim(Str(cboMes.SelectedIndex + 1)), 2)
        End If
        Return periodo
    End Function
    Sub coloreaIngresoDolares()
        Dim I As Integer = 0, prom As Decimal = 0
        Dim cPrecioProm As String = general.strPrecioCostoPromedio
        Dim mPrecio As New ePrecio
        If dsKardex.Tables("kardex").Rows.Count > 0 Then
            For I = 0 To dsKardex.Tables("kardex").Rows.Count - 1
                dataKardex.CurrentCell = dataKardex("fec_doc", I)
                If Not IsDBNull(dataKardex("ingresos", I).Value) Then
                    If dataKardex("ingresos", I).Value > 0 Then
                        If dataKardex("tm", I).Value = "D" Then
                            dataKardex.CurrentRow.DefaultCellStyle.BackColor = Color.LightGreen
                        End If
                    End If
                End If
            Next
            dataKardex.CurrentCell = dataKardex("fec_doc", 0)
            prom = mPrecio.calculaPrecioPromedio(False, "", dataArticulo.Item("cod_art", dataArticulo.CurrentRow.Index).Value, cPrecioProm)
            lblPrecioPromedio.Text = "Precio Costo Promedio.  " & Math.Round(prom, 3)
        End If
    End Sub
    Sub coloreaSobrePrecio()
        Dim I As Integer = 0, inicial As Decimal = 0.0, ingresos As Decimal = 0.0, salidas As Decimal = 0.0, stock As Decimal = 0.0
        If dsKardex.Tables("kardex").Rows.Count > 0 Then
            For I = 0 To dsKardex.Tables("kardex").Rows.Count - 1
                dataKardex.CurrentCell = dataKardex("fec_doc", I)
                If Not IsDBNull(dataKardex("precio", I).Value) And Not IsDBNull(dataKardex("pre_costoMax", I).Value) Then
                    'cuando los precios incluyen impuesto
                    If chkIncIGV.Checked = True Then
                        If dataKardex("tm", I).Value = "D" Then
                            If dataKardex("ingresos", I).Value > 0 And (dataKardex("precio", I).Value * _
                                dataKardex("tc", I).Value) / (1 + dataKardex("igv", I).Value) > _
                                dataKardex("pre_costoMax", I).Value Then
                                dataKardex.CurrentRow.DefaultCellStyle.ForeColor = Color.Red
                            End If
                        Else
                            If dataKardex("ingresos", I).Value > 0 And (dataKardex("precio", I).Value) / _
                                (1 + dataKardex("igv", I).Value) > dataKardex("pre_costoMax", I).Value Then
                                dataKardex.CurrentRow.DefaultCellStyle.ForeColor = Color.Red
                            End If
                        End If
                    Else
                        If dataKardex("tm", I).Value = "D" Then
                            If dataKardex("ingresos", I).Value > 0 And (dataKardex("precio", I).Value) * _
                                (dataKardex("tc", I).Value) > dataKardex("pre_costoMax", I).Value Then
                                dataKardex.CurrentRow.DefaultCellStyle.ForeColor = Color.Red
                            End If
                        Else
                            If dataKardex("ingresos", I).Value > 0 And dataKardex("precio", I).Value > _
                                dataKardex("pre_costoMax", I).Value Then
                                dataKardex.CurrentRow.DefaultCellStyle.ForeColor = Color.Red
                            End If
                        End If
                    End If
                End If
                If dataKardex("inicial", I).Value > 0 Then
                    inicial = inicial + dataKardex("inicial", I).Value
                Else
                    If dataKardex("ingresos", I).Value > 0 Then
                        ingresos = ingresos + dataKardex("ingresos", I).Value
                    Else
                        If dataKardex("salidas", I).Value > 0 Then
                            salidas = salidas + dataKardex("salidas", I).Value
                        End If
                    End If
                End If
            Next
            stock = stock + inicial + ingresos - salidas
            lblInicial.Text = inicial
            lblIngresos.Text = ingresos
            lblSalidas.Text = salidas
            lblStock.Text = stock
            dataKardex.CurrentCell = dataKardex("fec_doc", 0)
        End If
    End Sub
    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged
        If Not estaCargando And Len(txtBuscar.Text) > 2 Then
            muestraArticulos(txtBuscar.Text)
            dsArticulo.Tables("articulo").DefaultView.RowFilter = "nom_art LIKE '" & txtBuscar.Text & "%'"
        End If
    End Sub

    Private Sub dataArticulo_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataArticulo.CellDoubleClick
        'Dim codigo As String = dataArticulo.Item("cod_art", dataArticulo.CurrentRow.Index).Value
        'imprimirkardex(codigo)

    End Sub

  
    Private Sub dataArticulo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dataArticulo.GotFocus
        ' muestraKardex()
        lblRegistros.Text = "Nº de Registros Procesados... 0"
        lblPrecioPromedio.Text = "Precio Costo Promedio. 0.000"
    End Sub
    Private Sub dataArticulo_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dataArticulo.SelectionChanged
        muestraKardex()
    End Sub
    Private Sub dataArticulo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dataArticulo.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True

            If dataKardex.RowCount > 0 Then
                dataKardex.Focus()
            End If
        End If
    End Sub
    Private Sub chkAlmacen_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkProduccion.CheckedChanged
        If Not estaCargando Then
            If chkProduccion.CheckState = CheckState.Checked Then
                chkProduccion.Text = "Articulos"
            Else
                chkProduccion.Text = "Producciones"
            End If
            muestraArticulos(txtBuscar.Text)
            txtBuscar.Focus()
            muestraKardex()
        End If
    End Sub
    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        ' Dim codigo As String = dataArticulo.Item("cod_art", dataArticulo.CurrentRow.Index).Value
        Dim codigo As String = ""
        imprimirkardex(codigo)

    End Sub

    Sub imprimirkardex(ByVal codigo As String)

        If dataKardex.RowCount > 0 Then
            Dim periodo As String = periodoSeleccionado()
            Dim periodoReporte As String = "Periodo: " & general.periodo_mesAnnoLetras(periodo)
            'Dim nom_art As String = dataArticulo.Item("nom_art", dataArticulo.CurrentRow.Index).Value
            Dim nom_art As String = ""
            Dim fechaReporte As String, preciosConIGV As String
            Dim frm As New rptForm
            'capturamos la fecha  o rango de fechas del reporte
            If chkDia.Checked = False Then
                fechaReporte = IIf(dtiHasta.Value > pFechaSystem, general.devuelveFechaImpresionSistema,
                                "Al: " & general.devuelveFechaImpresionEspecificado(dtiHasta.Value))
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
            'verificamos si los precios estan con IGV
            preciosConIGV = IIf(chkIncIGV.Checked = True, "*Los Precios Incluyen Impuesto", "*Los Precios NO Incluyen Impuesto")
            Dim cAlmacen As String = IIf(cboAlmacen.SelectedIndex >= 0, cboAlmacen.Text, "Integrado")

            'muestraKardexImp(codigo)
            If rb_standar.Checked Then
                frm.cargarKardex(dsKardex, nom_art, cAlmacen, fechaReporte, "Kardex, " & periodoReporte, preciosConIGV, True)
                ' frm.ResumenKardex_SUNAT(dsKardex, nom_art, cAlmacen, fechaReporte, "Kardex, " & periodoReporte, preciosConIGV, True)
            Else
                frm.cargarKardex_SUNAT(dsKardex, nom_art, cAlmacen, fechaReporte, periodoReporte, preciosConIGV, True)
            End If

            frm.MdiParent = principal
            frm.Show()
        Else
            MessageBox.Show(general.str_textoNoImpresion, "ALMACEN", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If

    End Sub

    Private Sub dataKardex_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dataKardex.KeyDown
        If (e.Control And e.KeyCode = Keys.E) Then
            If dataKardex.RowCount > 0 Then
                EnviaraExcel(dataKardex)
            End If
        End If
    End Sub

 



    Private Sub chkgrupo_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkgrupo.CheckedChanged
        If Not estaCargando Then
            If chkgrupo.CheckState = CheckState.Checked Then
                cbogrupo.Enabled = True
            Else
                cbogrupo.Enabled = False
            End If
        End If
    End Sub

    Private Sub cbogrupo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbogrupo.SelectedIndexChanged
        'If Not estaCargando Then
        '    muestraKardex()
        '    muestraArticulos(txtBuscar.Text)
        '    txtBuscar.Focus()
        'End If
    End Sub




End Class
