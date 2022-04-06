Imports MySql.Data.MySqlClient
Imports libreriaClases
Public Class repVentas
    Private dsSalidas As New DataSet
    Private dssalidasD As New DataSet
    Private dsAlmacen As New DataSet
    Private dsCliente As New DataSet
    Private dsDocumento As New DataSet
    Private dsProducto As New DataSet
    Private dsGrupo As New DataSet
    Private dsunidad As New DataSet
    Private estaCargando As Boolean = True
    Private Sub repVentas_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        principal.mr_ventas.Enabled = True
    End Sub
    Private Sub repVentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Top = 0
        Me.Left = 0
        Dim mes, anno As Integer
        mes = Month(pFechaActivaMax)
        anno = Year(pFechaActivaMax)
        cboMes.SelectedIndex = mes - 1
        cboAnno.SelectedIndex = anno - 2010
        'dataset almacen
        Dim daAlmacen As New MySqlDataAdapter
        Dim comAlma As New MySqlCommand("select cod_alma,nom_alma from almacen a  where a.activo=1  order by nom_alma", dbConex)
        daAlmacen.SelectCommand = comAlma
        daAlmacen.Fill(dsAlmacen, "almacen")
        With cboAlmacen
            .DataSource = dsAlmacen.Tables("almacen")
            .DisplayMember = dsAlmacen.Tables("almacen").Columns("nom_alma").ToString
            .ValueMember = dsAlmacen.Tables("almacen").Columns("cod_alma").ToString
            .SelectedIndex = -1
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
        'dataset documento
        Dim daDocumento As New MySqlDataAdapter
        Dim comDoc As New MySqlCommand("select cod_doc,nom_doc from documento_s where activo=1 order by nom_doc", dbConex)
        daDocumento.SelectCommand = comDoc
        daDocumento.Fill(dsDocumento, "documento")
        'dataset cliente
        Dim daCliente As New MySqlDataAdapter
        Dim comClie As New MySqlCommand("select cod_clie,nom_clie from cliente where activo=1 order by nom_clie", dbConex)
        dacliente.SelectCommand = comClie
        daCliente.Fill(dsCliente, "cliente")
        'dataset vendedor
        'Dim daVendedor As New MySqlDataAdapter
        'Dim comVend As New MySqlCommand("select cod_vend,nom_vend from vendedor where activo=1 order by nom_vend", dbConex)
        'daVendedor.SelectCommand = comVend
        'daVendedor.Fill(dsVendedor, "vendedor")
        'dataset producto
        Dim daProducto As New MySqlDataAdapter
        Dim comProd As New MySqlCommand("select cod_art,nom_art from articulo a inner join subgrupo s on a.cod_sgrupo=s.cod_sgrupo where a.activo=1 and (esproduccion) order by nom_art", dbConex)
        daProducto.SelectCommand = comProd
        daProducto.Fill(dsProducto, "producto")
        'dataset Grupos
        Dim daGrupo As New MySqlDataAdapter
        Dim comGrupo As New MySqlCommand("select cod_sgrupo,nom_sgrupo from subgrupo where !esproduccion and activo order by nom_sgrupo", dbConex)
        daGrupo.SelectCommand = comGrupo
        daGrupo.Fill(dsGrupo, "Grupo")
        estaCargando = False
        estableceFechas()
        cargaDocumentos()
        'muestraVentas()
        'muestraventasxdia()
    End Sub
    Private Sub cboMes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMes.SelectedIndexChanged
        estableceFechas()
        chkDia.CheckState = CheckState.Checked
        'If Not estaCargando Then
        '    muestraVentas()
        'End If
    End Sub
    Private Sub cboAnno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAnno.SelectedIndexChanged
        estableceFechas()
        chkDia.CheckState = CheckState.Checked
        If Not estaCargando Then
            muestraVentas()
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
            estaCargando = True
            cboGrupo.Enabled = False
            cargaDocumentos()
            estaCargando = False
        End If
    End Sub
    Private Sub optCliente_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optCliente.CheckedChanged
        If Not estaCargando And optCliente.Checked = True Then
            estaCargando = True
            cboGrupo.Enabled = False
            cargaClientes()
            estaCargando = False
        End If
    End Sub
    Private Sub optDocumento_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optDocumento.CheckedChanged
        If Not estaCargando And optDocumento.Checked = True Then
            estaCargando = True
            cboGrupo.Enabled = False
            cargaDocumentos()
            estaCargando = False
        End If
    End Sub
    Private Sub optProducto_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optProducto.CheckedChanged
        If Not estaCargando And optProducto.Checked = True Then
            estaCargando = True
            cboGrupo.Enabled = False
            cargaArticulos()
            estaCargando = False
        End If
    End Sub
    Private Sub optProducto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optProducciones.CheckedChanged
        If Not estaCargando And optProducciones.Checked = True Then
            estaCargando = True
            cboGrupo.Enabled = False
            cargaProductos()
            estaCargando = False
        End If
    End Sub
    Private Sub cboAlmacen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAlmacen.SelectedIndexChanged
        'If Not estaCargando Then
        '    muestraVentas()
        'End If
    End Sub

    Private Sub cboGrupo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboGrupo.SelectedIndexChanged
        If Not estaCargando And chkfiltro.Checked = True Then
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
    Function fechaIa() As Date
        If Not estaCargando Then
            Dim mfecha As Date
            mfecha = general.convierteTexto_enFecha(1, 1, Val(cboAnno.Text))
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
            dtiDesde.MinDate = fechaIa()
            dtiDesde.ResetMaxDate()
            'dtiDesde.MaxDate = pFechaActivaMax
            dtiDesde.Value = fechaI()
            dtiHasta.ResetMinDate()
            dtiHasta.MinDate = fechaI()
            dtiHasta.ResetMaxDate()
            'dtiHasta.MaxDate = fechaF()
            dtiHasta.Value = fechaF()
        Else
            dtiDesde.ResetMinDate()
            dtiDesde.MinDate = pFechaActivaMin
            dtiDesde.ResetMaxDate()
            'dtiDesde.MaxDate = pFechaActivaMax
            dtiDesde.Value = pFechaSystem

            dtiHasta.ResetMinDate()
            dtiHasta.MinDate = pFechaActivaMin
            dtiHasta.ResetMaxDate()
            'dtiHasta.MaxDate = pFechaActivaMax
            dtiHasta.Value = fechaF()
        End If
    End Sub
    Function periodoSeleccionado()
        Dim periodo As String = Trim(Str(cboAnno.SelectedIndex + 2010)) & Microsoft.VisualBasic.Right("00" & Trim(Str(cboMes.SelectedIndex + 1)), 2)
        Return periodo
    End Function
    Sub muestraventasxdia()
        Dim mMicros As New micros, msalida As New Salida
        Dim periodo As String = periodoSeleccionado()
        Dim esHistorial As Boolean = IIf(periodo = periodoActivo(), False, True)
        Dim xAlmacen As Boolean = IIf(chkAlmacen.Checked = True, True, False)
        Dim cAlmacen As String = cboAlmacen.SelectedValue
        Dim vAlmacen As Boolean = IIf(pCatalogoXalmacen, True, False)
        Dim xCliente As Boolean = IIf(chkfiltro.Checked = True, True, False)
        Dim xGventa As Boolean = IIf(chkVenta.Checked = True, True, False)
        Dim cGrupo As String = cboGrupo.SelectedValue
        Dim xUnidad As Boolean = IIf(chkUnidad.Checked = True, True, False)
        Dim xdocumento As Boolean = IIf(optProducciones.Checked = True, True, False)
        Dim cUnidad As String = cboUnidad.SelectedValue
        Dim fechaDesde As Date = dtiDesde.Value
        Dim fechaHasta As Date = dtiHasta.Value
        dssalidasD.Clear()
        dataIngMenu.DataSource = ""
        If tabResumen.IsSelected Then
            Dim valor As String = IIf(optCantidades.Checked = True, "cant", "cant*precio")
            If optsalidas.Checked = True Then
                dssalidasD = msalida.recuperaVentasxDia(esHistorial, fechaDesde, fechaHasta, xAlmacen, cAlmacen, xCliente, cGrupo, xUnidad, cUnidad, True, valor)
                dataResumen.DataSource = dssalidasD.Tables("ventas").DefaultView
            Else
                dssalidasD = msalida.recuperaIngresosxDia(esHistorial, fechaDesde, fechaHasta, xAlmacen, cAlmacen, xCliente, cGrupo, xUnidad, cUnidad, xdocumento, True, valor)
                dataResumen.DataSource = dssalidasD.Tables("Ingresos").DefaultView
            End If
            estructuraResumenxDia()
        End If
        If TabIngMenu.IsSelected Then
            Dim valor As String = IIf(optcantventa.Checked = True, "canti", "pre_ven")
            If optmes.Checked Then
                dssalidasD = mMicros.recuperaVentasxMes(fechaDesde, fechaHasta, vAlmacen, xAlmacen, xGventa, cAlmacen, cboAnno.SelectedIndex + 2010, True, valor)
            Else
                dssalidasD = mMicros.recuperaVentasxDia(False, fechaDesde, fechaHasta, vAlmacen, xAlmacen, cAlmacen, xCliente, xGventa, cGrupo, True, valor)
            End If
            dataIngMenu.DataSource = dssalidasD.Tables("ventas").DefaultView
            estructuraResumenxMes()


        End If

    End Sub
    Sub muestraVentas()
        Dim mSalidas As New Salida, mIngreso As New Ingreso
        Dim periodo As String = periodoSeleccionado()
        Dim esHistorial As Boolean = IIf(periodo = periodoActivo(), False, True)
        Dim esProduciones As Boolean = IIf(chkProduccion.Checked = True, True, False)
        Dim esMensual As Boolean = IIf(chkDia.Checked = True, False, True)
        Dim xAlmacen As Boolean = IIf(chkAlmacen.Checked = True, True, False)
        Dim xGrupo As Boolean = IIf(chkfiltro.Checked = True, True, False)
        Dim xCliente As Boolean = IIf(optCliente.Checked = True And chkfiltro.Checked = True, True, False)
        Dim xArticulo As Boolean = IIf(optProducto.Checked = True, True, False)
        Dim xDocumento As Boolean = IIf(optDocumento.Checked = True, True, False)
        Dim xVendedor As Boolean = IIf(optProducto.Checked = True, True, False)
        Dim xUnidad As Boolean = IIf(chkUnidad.Checked = True, True, False)
        Dim cUnidad As String = cboUnidad.SelectedValue
        Dim cAlmacen As String = cboAlmacen.SelectedValue
        Dim cGrupo As String = cboGrupo.SelectedValue
        Dim I As Integer
        Dim fechaDesde As Date = dtiDesde.Value
        Dim fechaHasta As Date = dtiHasta.Value
        Dim linicial, lingreso, lsalida, lrequerimiento As Decimal
        Dim anno As String = Trim(Str(cboAnno.SelectedIndex + 2010))
        dataDetalle.DataSource = ""
        dsSalidas.Clear()
        If optProducto.Checked = True Then
            dsSalidas = mSalidas.recuperaCantArticulosSalientes(esHistorial, anno, True, True, False, esMensual, fechaDesde, fechaHasta, pDecimales, _
                                                                xGrupo, cGrupo, xAlmacen, cAlmacen, False)
        Else
            If optPedido.Checked Or optProducciones.Checked = True Then
                dsSalidas = mSalidas.recuperaPedidoArticulosSalientes(esHistorial, esProduciones, periodo, True, False, False, esMensual, fechaDesde, fechaHasta, pDecimales, xAlmacen, cAlmacen, xGrupo, cGrupo, xUnidad, cUnidad, False)
                If dsSalidas.Tables("salida").Rows.Count > 0 Then
                    For I = 0 To dsSalidas.Tables("salida").Rows.Count - 1
                        Dim mfila As DataRow = dsSalidas.Tables("salida").Rows(I)
                        Dim cod_art As String = mfila.Item("cod_art")
                        Dim nom_uni As String = mfila.Item("nom_uni")
                        Dim cod_area As String = mfila.Item("cod_area")
                        linicial = mIngreso.recuperaInicialArticulo(esHistorial, periodo, fechaHasta, xAlmacen, cAlmacen, True, cod_area, cod_art)
                        lingreso = mIngreso.recuperaPedidoIngresosArticulo(esHistorial, periodo, esMensual, fechaDesde, fechaHasta, xAlmacen, cAlmacen, cod_art, cod_area)
                        lsalida = mfila.Item("salida")
                        mfila.Item("inicial") = linicial
                        mfila.Item("ingreso") = lingreso
                        lrequerimiento = lsalida - (linicial + lingreso)
                        mfila.Item("pedido") = lrequerimiento
                        'mfila.Item("reqAlma") = CalculaRequerimientoAlmacen(cod_art, lrequerimiento)
                        'mfila.Item("reqAlma") = esEntero(lsalida)
                        mfila.Item("reqAlma") = lsalida
                        'mfila.Item("nom_uniAlma") = ObtieneUnidadAlmacen(cod_art, nom_uni)
                        mfila.Item("nom_uniAlma") = nom_uni
                        mfila.Item("stock") = mIngreso.devuelveSaldoArticulo(cod_art)
                    Next
                End If
            Else
                dsSalidas = mSalidas.recuperaCabeceras(esHistorial, anno, esMensual, dtiDesde.Value, dtiHasta.Value, pDecimales, _
                                    xAlmacen, cAlmacen, False, xCliente, cGrupo, xDocumento, cGrupo, xVendedor, cGrupo)
            End If
        End If
        dataDetalle.DataSource = dsSalidas.Tables("salida").DefaultView
        lblRegistros.Text = "Nº de Documentos Procesados... " & dataDetalle.RowCount.ToString
        If optPedido.Checked = True Or optProducciones.Checked = True Then
            estructuraPedidos()
        Else
            estructuraSalidas()
            muestraTotales()
        End If
        coloreafilas()
    End Sub

    Sub estructuraResumenxDia()
        Dim I As Integer = 1, col As String
        Dim inicio As Integer = 1, final As Integer = 1
        If chkDia.Checked = True Then
            inicio = Microsoft.VisualBasic.DateAndTime.Day(dtiDesde.Value)
            final = Microsoft.VisualBasic.DateAndTime.Day(dtiHasta.Value)
        End If
        With dataResumen
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            .Columns("cod_Art").Visible = True
            .Columns("cod_art").HeaderText = "Codigo"
            .Columns("cod_art").Width = 50
            .Columns("cod_art").DisplayIndex = 0
            .Columns("nom_art").Visible = True
            .Columns("nom_art").HeaderText = "Descripción"
            .Columns("nom_art").Width = 150
            .Columns("nom_art").DisplayIndex = 1
            .Columns("nom_uni").Visible = True
            .Columns("nom_uni").HeaderText = "Unidad"
            .Columns("nom_uni").Width = 50
            .Columns("nom_uni").DisplayIndex = 2

            For I = 1 To 31
                col = "d" & I
                .Columns(col).Visible = False
            Next
            If chkDia.Checked = True Then

                For I = inicio To final
                    col = "d" & I
                    .Columns(col).HeaderText = col
                    .Columns(col).Width = 45
                    .Columns(col).Visible = True
                    .Columns(col).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    .Columns(col).DefaultCellStyle.BackColor = Color.AliceBlue
                Next
            Else
                For I = inicio To 31
                    col = "d" & I
                    .Columns(col).HeaderText = col
                    .Columns(col).Width = 45
                    .Columns(col).Visible = True
                    .Columns(col).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    .Columns(col).DefaultCellStyle.BackColor = Color.AliceBlue
                Next
            End If

        End With
    End Sub
    Sub estructuraResumenxMes()
        Dim I As Integer = 1, col, nomcol As String
        Dim inicio As Integer = 1, final As Integer = 12
        If chkDia.Checked = True Then
            inicio = Microsoft.VisualBasic.DateAndTime.Day(dtiDesde.Value)
            final = Microsoft.VisualBasic.DateAndTime.Day(dtiHasta.Value)
        End If
        With dataIngMenu
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("codigo").Visible = True
            .Columns("codigo").HeaderText = "Codigo"
            .Columns("codigo").Width = 50
            .Columns("codigo").DisplayIndex = 0
            .Columns("nombre").Visible = True
            .Columns("nombre").HeaderText = "Descripción"
            .Columns("nombre").Width = 100
            .Columns("nombre").DisplayIndex = 1
            .Columns("cod_art").Visible = True
            .Columns("cod_art").HeaderText = "Codigo"
            .Columns("cod_art").Width = 50
            .Columns("cod_art").DisplayIndex = 2
            .Columns("nom_art").Visible = True
            .Columns("nom_art").HeaderText = "Receta"
            .Columns("nom_art").Width = 100
            .Columns("nom_art").DisplayIndex = 3

            .Columns("pre_costo").HeaderText = "Precio Costo"
            .Columns("pre_costo").Width = 45
            .Columns("pre_costo").DisplayIndex = 4
            .Columns("pre_costo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            .Columns("pre_venta").HeaderText = "Precio Venta"
            .Columns("pre_venta").Width = 45
            .Columns("pre_venta").DisplayIndex = 5
            .Columns("pre_venta").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            .Columns("porcentaje").HeaderText = " % "
            .Columns("porcentaje").Width = 40
            .Columns("porcentaje").DisplayIndex = 6
            .Columns("porcentaje").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            .Columns("nom_sgrupo").Visible = True
            .Columns("nom_sgrupo").HeaderText = "Grupo"
            .Columns("nom_sgrupo").Width = 0
            .Columns("nom_sgrupo").DisplayIndex = 7

            If optmes.Checked = True Then
                For I = 1 To 12
                    col = "m" & I
                    .Columns(col).Visible = False
                Next
                For I = 1 To 12
                    col = "m" & I
                    nomcol = devuelveNomMes("m" & I)
                    .Columns(col).HeaderText = nomcol
                    .Columns(col).Width = 60
                    .Columns(col).Visible = True
                    .Columns(col).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    .Columns(col).DefaultCellStyle.BackColor = Color.AliceBlue
                Next
            Else
                For I = 1 To 31
                    col = "d" & I
                    .Columns(col).Visible = False
                Next
                If chkDia.Checked = True Then
                    For I = inicio To final
                        col = "d" & I
                        .Columns(col).HeaderText = col
                        .Columns(col).Width = 45
                        .Columns(col).Visible = True
                        .Columns(col).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                        .Columns(col).DefaultCellStyle.BackColor = Color.AliceBlue
                    Next
                Else
                    For I = inicio To 31
                        col = "d" & I
                        .Columns(col).HeaderText = col
                        .Columns(col).Width = 45
                        .Columns(col).Visible = True
                        .Columns(col).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                        .Columns(col).DefaultCellStyle.BackColor = Color.AliceBlue
                    Next
                End If

            End If

        End With
    End Sub
    Sub estructuraSalidas()
        With dataDetalle
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("fec_doc").HeaderText = "Fecha"
            .Columns("fec_doc").Width = 70
            .Columns("fec_doc").DisplayIndex = 0
            .Columns("fec_doc").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("canti").HeaderText = "Cantidad"
            .Columns("canti").Width = 65
            .Columns("canti").DisplayIndex = 1
            .Columns("canti").DefaultCellStyle.BackColor = Color.AliceBlue
            .Columns("canti").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("descripcion").HeaderText = "Descripcion"
            .Columns("descripcion").Width = 250
            .Columns("descripcion").DisplayIndex = 2
            .Columns("nom_clie").HeaderText = "Cliente"
            .Columns("nom_clie").Width = 250
            .Columns("nom_clie").DisplayIndex = 3
            .Columns("doc").HeaderText = "Documento"
            .Columns("doc").Width = 120
            .Columns("doc").DisplayIndex = 4
            .Columns("monto_doc").HeaderText = "Importe"
            .Columns("monto_doc").Width = 65
            .Columns("monto_doc").DisplayIndex = 5
            .Columns("monto_doc").DefaultCellStyle.BackColor = Color.AliceBlue
            .Columns("monto_doc").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("nom_fpago").HeaderText = "Forma Pago"
            .Columns("nom_fpago").Width = 100
            .Columns("nom_fpago").DisplayIndex = 6
            .Columns("fec_pago").HeaderText = "Fecha Pago"
            .Columns("fec_pago").Width = 70
            .Columns("fec_pago").DisplayIndex = 7
            .Columns("fec_pago").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("nom_alma").Visible = True
            .Columns("nom_alma").HeaderText = "Almacen"
            .Columns("nom_alma").Width = 160
            .Columns("nom_alma").DisplayIndex = 8
            .Columns("codigo").HeaderText = "Codigo"
            .Columns("codigo").Width = 0
            .Columns("codigo").DisplayIndex = 9
            If optProducto.Checked = True Then
                .Columns("ser_doc").Visible = False
                .Columns("nro_doc").Visible = False
                .Columns("cod_doc").Visible = False
                .Columns("operacion").Visible = False
                .Columns("documento").Visible = False
                .Columns("nom_uni").Visible = False
                .Columns("precio").Visible = False
                .Columns("igv").Visible = False
                .Columns("afecto_igv").Visible = False
                .Columns("nom_fpago").Visible = False
                .Columns("fec_pago").Visible = False
                .Columns("anul").Visible = False
                .Columns("cod_clie").Visible = False
            Else

                .Columns("monto_igv").Visible = False
                .Columns("SubTotal").Visible = False
                .Columns("pre_ven").Visible = False
                .Columns("cant").Visible = False
                .Columns("precio").Visible = False
                .Columns("montoSal").Visible = False
                .Columns("operacion").Visible = False
                .Columns("descripcion").Visible = False
                .Columns("ser_doc").Visible = False
                .Columns("nro_doc").Visible = False
                .Columns("cod_doc").Visible = False
                .Columns("documento").Visible = False
                .Columns("nro_ped").Visible = False
                .Columns("cod_vend").Visible = False
                .Columns("nom_vend").Visible = False
                .Columns("cod_clie").Visible = False
                .Columns("raz_soc").Visible = False
                .Columns("dir_clie").Visible = False
                .Columns("dir_ent").Visible = False
                .Columns("fono_clie").Visible = False
                .Columns("nom_cont").Visible = False
                .Columns("cod_fpago").Visible = False
                .Columns("cod_alma").Visible = False
                .Columns("obs").Visible = False
                .Columns("anul").Visible = False
                .Columns("ingreso").Visible = False
                .Columns("salida").Visible = False
                .Columns("pre_inc_igv").Visible = False
                .Columns("comi_v").Visible = False
                .Columns("comi_jv").Visible = False
                .Columns("nom_art").Visible = False
                .Columns("saldo").Visible = False
                .Columns("estado").Visible = False
                .Columns("cancelado").Visible = False
            End If
        End With
    End Sub
    Sub estructuraProductos()
        With dataDetalle
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_art").Visible = True
            .Columns("cod_art").HeaderText = "Codigo"
            .Columns("cod_art").Width = 55
            .Columns("cod_art").DisplayIndex = 0
            .Columns("nom_art").Visible = True
            .Columns("nom_art").HeaderText = "Descripción"
            .Columns("nom_art").Width = 280
            .Columns("nom_art").DisplayIndex = 1
            .Columns("nom_uni").Visible = True
            .Columns("nom_uni").HeaderText = "Unidad"
            .Columns("nom_uni").Width = 70
            .Columns("nom_uni").DisplayIndex = 2
            .Columns("cant").Visible = True
            .Columns("cant").HeaderText = "Cant."
            .Columns("cant").Width = 65
            .Columns("cant").DisplayIndex = 3
            .Columns("cant").DefaultCellStyle.BackColor = Color.AliceBlue
            .Columns("cant").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("precio").Visible = True
            .Columns("precio").HeaderText = "Precio"
            .Columns("precio").Width = 75
            .Columns("precio").DisplayIndex = 4
            .Columns("precio").DefaultCellStyle.BackColor = Color.AliceBlue
            .Columns("precio").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("neto").Visible = True
            .Columns("neto").HeaderText = "Monto"
            .Columns("neto").Width = 80
            .Columns("neto").DisplayIndex = 5
            .Columns("neto").DefaultCellStyle.BackColor = Color.AliceBlue
            .Columns("neto").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("igv").Visible = False
            .Columns("afecto_igv").Visible = False
            .Columns("cod_sgrupo").Visible = False
        End With
    End Sub
    Sub estructuraPedidos()
        With dataDetalle
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_art").Visible = True
            .Columns("cod_art").HeaderText = "Codigo"
            .Columns("cod_art").Width = 55
            .Columns("cod_art").DisplayIndex = 0
            .Columns("nom_art").Visible = True
            .Columns("nom_art").HeaderText = "Descripción"
            .Columns("nom_art").Width = 280
            .Columns("nom_art").DisplayIndex = 1
            .Columns("nom_uni").Visible = True
            .Columns("nom_uni").HeaderText = "Unidad"
            .Columns("nom_uni").Width = 70
            .Columns("nom_uni").DisplayIndex = 2
            .Columns("precio").Visible = True
            .Columns("precio").HeaderText = "Costo"
            .Columns("precio").Width = 75
            .Columns("precio").DisplayIndex = 3
            .Columns("precio").DefaultCellStyle.BackColor = Color.AliceBlue
            .Columns("precio").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("inicial").Visible = True
            .Columns("inicial").HeaderText = "Inicial"
            .Columns("inicial").Width = 65
            .Columns("inicial").DisplayIndex = 4
            .Columns("inicial").DefaultCellStyle.BackColor = Color.AliceBlue
            .Columns("inicial").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("ingreso").Visible = True
            .Columns("Ingreso").HeaderText = "Ingreso"
            .Columns("Ingreso").Width = 65
            .Columns("Ingreso").DisplayIndex = 5
            .Columns("Ingreso").DefaultCellStyle.BackColor = Color.AliceBlue
            .Columns("Ingreso").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("salida").Visible = True
            .Columns("salida").HeaderText = "Salida"
            .Columns("salida").Width = 65
            .Columns("salida").DisplayIndex = 6
            .Columns("salida").DefaultCellStyle.BackColor = Color.AliceBlue
            .Columns("salida").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("Pedido").DefaultCellStyle.BackColor = Color.AliceBlue
            .Columns("Pedido").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("reqalma").Visible = True
            .Columns("reqalma").HeaderText = "Requeri miento"
            .Columns("reqalma").Width = 75
            .Columns("reqalma").DisplayIndex = 7
            .Columns("reqalma").DefaultCellStyle.BackColor = Color.AliceBlue
            .Columns("reqalma").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("nom_area").HeaderText = "Area"
            .Columns("nom_area").Width = 75
            .Columns("nom_area").DisplayIndex = 8
            .Columns("nom_area").DefaultCellStyle.BackColor = Color.AliceBlue
            .Columns("nom_area").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("nom_unialma").HeaderText = "Unidad Almacen"
            .Columns("nom_unialma").Width = 75
            .Columns("nom_unialma").DisplayIndex = 9
            .Columns("nom_unialma").DefaultCellStyle.BackColor = Color.AliceBlue
            .Columns("nom_unialma").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_sgrupo").Visible = False
            .Columns("nom_sgrupo").Visible = False
            .Columns("pedido").Visible = False
            .Columns("cod_area").Visible = False

        End With
    End Sub
    Function CalculaRequerimientoAlmacen(ByVal cod_art As String, ByVal cantidad As Decimal)
        Dim mAlmacen As New Almacen, munidad As New Unidad
        Dim cod_artRel As String, cod_unirel As String, cod_unirelO As String, cant_unirel As Decimal, es_div As Boolean
        cod_artRel = mAlmacen.devuelveCodigoArtPrinRelacionado(cod_art)
        cod_unirel = munidad.devuelveUnidad(cod_artRel)
        cod_unirelO = munidad.devuelveUnidad(cod_art)
        cant_unirel = munidad.devuelveCantUnidad(cod_unirel)
        es_div = munidad.esDivisible(cod_unirelO)
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
    Sub cargaClientes()
        chkfiltro.Text = "Clientes"
        With cboGrupo
            .DropDownStyle = ComboBoxStyle.DropDown
            .DataSource = dsCliente.Tables("cliente")
            .DisplayMember = dsCliente.Tables("cliente").Columns("nom_clie").ToString
            .ValueMember = dsCliente.Tables("cliente").Columns("cod_clie").ToString
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.ListItems
            If dsCliente.Tables("cliente").Rows.Count > 0 Then
                .SelectedIndex = 0
            End If
            .Enabled = True
            .Focus()
        End With
    End Sub
    Sub cargaDocumentos()
        chkfiltro.Text = "Documentos"
        With cboGrupo
            .DataSource = dsDocumento.Tables("documento")
            .DisplayMember = dsDocumento.Tables("documento").Columns("nom_doc").ToString
            .ValueMember = dsDocumento.Tables("documento").Columns("cod_doc").ToString
            If dsDocumento.Tables("documento").Rows.Count > 0 Then
                .SelectedIndex = 0
            End If
            .Enabled = True
            .Focus()
        End With
    End Sub
    Sub cargaArticulos()
        chkfiltro.Text = "Productos"
        With cboGrupo
            .DataSource = dsProducto.Tables("Producto")
            .DisplayMember = dsProducto.Tables("Producto").Columns("nom_art").ToString
            .ValueMember = dsProducto.Tables("Producto").Columns("cod_art").ToString
            If dsProducto.Tables("Producto").Rows.Count > 0 Then
                .SelectedIndex = 0
            End If
            .Enabled = True
            .Focus()
        End With
    End Sub
    Sub cargaProductos()
        chkfiltro.Text = "Grupos"
        With cboGrupo
            .DropDownStyle = ComboBoxStyle.DropDown
            .DataSource = dsGrupo.Tables("Grupo")
            .DisplayMember = dsGrupo.Tables("Grupo").Columns("nom_sgrupo").ToString
            .ValueMember = dsGrupo.Tables("Grupo").Columns("cod_sgrupo").ToString
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.ListItems
            If dsGrupo.Tables("Grupo").Rows.Count > 0 Then
                .SelectedIndex = 0
            End If
            .Enabled = True
            .Focus()
        End With
    End Sub

    Sub coloreafilas()
        If optPedido.Checked = True And dsSalidas.Tables("salida").Rows.Count > 0 Then
            For Each row As DataGridViewRow In dataDetalle.Rows
                If Not IsDBNull(row.Cells("pedido").Value) Then
                    If row.Cells("pedido").Value >= 0 Then
                        row.DefaultCellStyle.BackColor = Color.Green
                    End If
                End If
            Next
        End If
    End Sub
    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        Dim periodo As String = periodoSeleccionado()
        Dim periodoReporte As String = "Periodo: " & general.periodo_mesAnnoLetras(periodo)
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
        'llamamos a los reportes
        If optRegistro.Checked = True Then
            If cboAlmacen.SelectedIndex = -1 Then
                frm.cargarRegistroSalidas(dsSalidas, "INTEGRADO", fechaReporte, periodoReporte, "", True)
            Else
                frm.cargarRegistroSalidas(dsSalidas, cboAlmacen.Text, fechaReporte, periodoReporte, "", True)
            End If
        Else
            If optProducciones.Checked Or optProducto.Checked Then
                frm.cargarRegistroSalidaProducto(dsSalidas, cboAlmacen.Text, fechaReporte, periodoReporte, "", "", False, False)
            Else
                If optPedido.Checked Then
                    frm.cargarRegistroSalidas(dsSalidas, cboAlmacen.Text, fechaReporte, periodoReporte, "", False)
                Else
                    frm.cargarRegistroSalidaCliente(dsSalidas, cboAlmacen.Text, fechaReporte, periodoReporte, "", True)
                End If
            End If
        End If
        frm.MdiParent = principal
        frm.Show()
    End Sub
    Private Sub cmdCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCerrar.Click
        Me.Close()
    End Sub
    Private Sub chkAlmacen_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAlmacen.CheckedChanged
        If Not estaCargando Then
            If chkAlmacen.Checked = True Then
                cboAlmacen.Enabled = True
                If dsAlmacen.Tables("almacen").Rows.Count > 0 Then
                    cboAlmacen.SelectedIndex = 0
                End If
                cboAlmacen.Focus()
            Else
                cboAlmacen.SelectedIndex = -1
                cboAlmacen.Enabled = False
                dataDetalle.Focus()
            End If
        End If
    End Sub

    Private Sub dataDetalle_ColumnHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dataDetalle.ColumnHeaderMouseClick
        coloreafilas()
    End Sub
    Private Sub dataDetalle_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dataDetalle.DoubleClick
        If optRegistro.Checked = True Or optDocumento.Checked = True Or optProducto.Checked = True Or optCliente.Checked = True Then
            If dataDetalle.RowCount > 0 Then
                If dataDetalle("anul", dataDetalle.CurrentRow.Index).Value = True Then
                    MessageBox.Show("El Documento se Encuentra Anulado...", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                End If
                cargaSalida()
            End If
        End If
    End Sub
    Private Sub dataDetalle_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dataDetalle.KeyDown
        If e.KeyCode = Keys.Enter Then
            If dataDetalle.RowCount > 0 Then
                e.SuppressKeyPress = True
                If dataDetalle("anul", dataDetalle.CurrentRow.Index).Value = True Then
                    MessageBox.Show("El Documento se Encuentra Anulado...", "CEFE", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Else
                    cargaSalida()
                End If
            End If
        End If
        If (e.Control And e.KeyCode = Keys.E) Then
            If dataDetalle.RowCount > 0 Then
                EnviaraExcel(dataDetalle)
            End If
        End If
    End Sub
    Sub cargaSalida()
        Dim periodo As String = periodoSeleccionado()
        Dim IsFormCargado As Boolean = False
        Dim mForm As Form
        For Each mForm In principal.MdiChildren
            If pModoPedidos = True Then
                If mForm.Name = "p_ventas" Then
                    If mForm.WindowState = FormWindowState.Minimized Then
                        mForm.WindowState = FormWindowState.Normal
                    Else
                        mForm.BringToFront()
                    End If
                    IsFormCargado = True
                    Exit For
                End If
            Else
                If mForm.Name = "p_salidas" Then
                    If mForm.WindowState = FormWindowState.Minimized Then
                        mForm.WindowState = FormWindowState.Normal
                    Else
                        mForm.BringToFront()
                    End If
                    IsFormCargado = True
                    Exit For
                End If
            End If
        Next
        mForm = Nothing
        If IsFormCargado = False Then
            Dim mformSalidas As New p_salidas
            Dim mformVentas As New p_ventas
            If pModoPedidos = True Then
                principal.mp_ventas.Enabled = False
                mformVentas.MdiParent = principal
                'falta para cuando se recupere documentos de otro periodo
                mformVentas.Show()
                mformVentas.cboDocumento.SelectedValue = dataDetalle.Item("cod_doc", dataDetalle.CurrentRow.Index).Value.ToString
                mformVentas.cboDocumento.Focus()
                mformVentas.txtSerDocumento.Text = dataDetalle.Item("ser_doc", dataDetalle.CurrentRow.Index).Value
                mformVentas.txtNroDocumento.Text = dataDetalle.Item("nro_doc", dataDetalle.CurrentRow.Index).Value
                mformVentas.txtNroDocumento.Focus()
                mformVentas.txtSerGuia.Focus()
            Else
                principal.mp_salidas.Enabled = False
                mformSalidas.MdiParent = principal
                mformSalidas.gPeriodoSalida = periodo
                mformSalidas.Show()
                mformSalidas.cboCliente.SelectedValue = dataDetalle.Item("cod_clie", dataDetalle.CurrentRow.Index).Value.ToString
                mformSalidas.cboCliente.Focus()
                mformSalidas.cboDocumento.SelectedValue = dataDetalle.Item("cod_doc", dataDetalle.CurrentRow.Index).Value.ToString
                mformSalidas.cboDocumento.Focus()
                mformSalidas.txtSerDocumento.Text = dataDetalle.Item("ser_doc", dataDetalle.CurrentRow.Index).Value
                mformSalidas.txtNroDocumento.Text = dataDetalle.Item("nro_doc", dataDetalle.CurrentRow.Index).Value
                mformSalidas.txtNroDocumento.Focus()
                mformSalidas.txtBuscar.Focus()
            End If
        End If
    End Sub



    Private Sub TextBoxX2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtBuscar2.TextChanged
        If Not estaCargando Then
            Dim cBuscar As String = TxtBuscar2.Text
            FiltrarData("", cBuscar)
        End If
    End Sub
    Function FiltrarData(ByVal cbuscar1 As String, ByVal cbuscar2 As String)
        If tabDetalle.IsSelected Then
            If dataDetalle.RowCount() > 0 Then
                If optRegistro.Checked = True Or optProducto.Checked = True Then
                    dsSalidas.Tables("salida").DefaultView.RowFilter = "nom_clie LIKE '%" & cbuscar2 & "%'"
                End If
                If optPedido.Checked = True Or optProducciones.Checked = True Then
                    dsSalidas.Tables("salida").DefaultView.RowFilter = "nom_art LIKE '%" & cbuscar2 & "%'"
                End If
            End If
        End If
        If tabResumen.IsSelected Or TabIngMenu.IsSelected Then
            If dataIngMenu.RowCount() > 0 Or dataResumen.RowCount() > 0 Then
                dssalidasD.Tables("ventas").DefaultView.RowFilter = "nom_art LIKE '%" & cbuscar2 & "%'"
            End If
        End If
        Return True
    End Function

    Private Sub optPedido_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optPedido.CheckedChanged
        If Not estaCargando And optPedido.Checked = True Then
            estaCargando = True
            cargaProductos()
            estaCargando = False
        End If
    End Sub

    Private Sub CheckBoxX1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkfiltro.CheckedChanged
        If Not estaCargando Then
            If chkfiltro.Checked = True Then
                cboGrupo.Enabled = True
                If dsGrupo.Tables("grupo").Rows.Count > 0 Then
                    cboGrupo.SelectedIndex = 0
                End If
                cboGrupo.Focus()
            Else
                cboGrupo.SelectedIndex = -1
                cboGrupo.Enabled = False
                dataDetalle.Focus()
            End If
        End If
    End Sub

    Private Sub dataResumen_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dataResumen.KeyDown
        If (e.Control And e.KeyCode = Keys.E) Then
            If dataResumen.RowCount > 0 Then
                EnviaraExcel(dataResumen)
            End If
        End If
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        If tabResumen.IsSelected Or TabIngMenu.IsSelected Then
            muestraventasxdia()
        End If
        If tabDetalle.IsSelected Then
            muestraVentas()
        End If
    End Sub

    Private Sub dataIngMenu_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dataIngMenu.KeyDown
        If (e.Control And e.KeyCode = Keys.E) Then
            If dataIngMenu.RowCount > 0 Then
                EnviaraExcel(dataIngMenu)
            End If
        End If
    End Sub

    Sub muestraTotales()
        Dim cMontoDS As Decimal = 0
        Dim I As Integer = 0
        For I = 0 To dataDetalle.RowCount - 1
            If optRegistro.Checked Then
                cMontoDS = cMontoDS + dataDetalle.Item("subtotal", I).Value
            Else
                cMontoDS = cMontoDS + dataDetalle.Item("monto_doc", I).Value
            End If


        Next
        lblMonedaDS.Text = "Total en " & pMoneda
        lblMontoDS.Text = "Monto..." & Format(cMontoDS, "####,###.##")
    End Sub

    Private Sub chkUnidad_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkUnidad.CheckedChanged
        If Not estaCargando Then
            If chkUnidad.Checked = True Then
                cboUnidad.Enabled = True
                If dsunidad.Tables("unidad").Rows.Count > 0 Then
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

    Private Sub dataDetalle_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataDetalle.CellContentClick

    End Sub

    Private Sub chkProduccion_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkProduccion.CheckedChanged
        If Not estaCargando Then
            If chkProduccion.CheckState = CheckState.Checked Then
                chkProduccion.Text = "Producciones"
            Else
                chkProduccion.Text = "Insumos"
            End If
            muestraVentas()
        End If

    End Sub

    Private Sub dtiHasta_Click(sender As System.Object, e As System.EventArgs) Handles dtiHasta.Click

    End Sub

    Private Sub TabControl2_Click(sender As Object, e As EventArgs) Handles TabControl2.Click

    End Sub

    Private Sub dataResumen_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataResumen.CellContentClick

    End Sub
End Class

