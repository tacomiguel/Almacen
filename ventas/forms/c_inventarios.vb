Imports MySql.Data.MySqlClient
Imports libreriaClases
Public Class c_inventarios
    Private dsInventario As New DataSet
    Private dsInventarioD As New DataSet
    Private dsAlmacen As New DataSet
    '
    Private cPrecioCI As String = general.str_PrecioCompraCI
    Private chPrecioCI As String = general.str_hPrecioCompraCI
    Private cPrecioSI As String = general.str_PrecioCompraSI
    Private chPrecioSI As String = general.str_hPrecioCompraSI
    Private cPrecioCIs As String = general.str_PrecioCompraCIs
    Private chPrecioCIs As String = general.str_hPrecioCompraCIs
    Private cPrecioSIs As String = general.str_PrecioCompraSIs
    Private chPrecioSIs As String = general.str_hPrecioCompraSIs
    '
    Private pFechaInventario As Date
    Private estaCargando As Boolean = True
    Private Sub c_inventarios_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If Not estaCargando Then
            muestraInventario()
        End If
    End Sub
    Private Sub c_inventarios_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        principal.mr_inventarios.Enabled = True
    End Sub
    Private Sub c_inventarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Top = 0
        Me.Left = 0
        Dim mes, anno As Integer
        mes = Month(pFechaActivaMax)
        anno = Year(pFechaActivaMax)
        cboMes.SelectedIndex = mes - 1
        cboAnno.SelectedIndex = anno - 2010
        'dataset almacen
        dsAlmacen.Tables.Add("almacen")
        Dim daAlmacen As New MySqlDataAdapter
        Dim comAlmacen As New MySqlCommand("select cod_alma,nom_alma from almacen where activo=1" _
                        & " and ((esCompras) or (destinoTrans)) order by nom_alma", dbConex)
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
        dtiDiario.Value = pFechaSystem
        estaCargando = False
        muestraInventario()
    End Sub
    Private Sub cboMes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMes.SelectedIndexChanged
        If Not estaCargando Then
            muestraInventario()
        End If
    End Sub
    Private Sub cboAnno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAnno.SelectedIndexChanged
        If Not estaCargando Then
            muestraInventario()
        End If
    End Sub
    Private Sub optInicial_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optInicial.CheckedChanged
        If Not estaCargando Then
            If optInicial.Checked = True Then
                chkAlmacen.Enabled = True
                dtiDiario.Enabled = False
                chkVs.Checked = True
            End If
            muestraInventario()
        End If
    End Sub
    Private Sub optMensual_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optMensual.CheckedChanged
        If Not estaCargando Then
            If optMensual.Checked = True Then
                chkAlmacen.Enabled = True
                dtiDiario.Enabled = False
                chkVs.Checked = True
            End If
            muestraInventario()
        End If
    End Sub
    Private Sub optDiario_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optDiario.CheckedChanged
        If Not estaCargando Then
            If optDiario.Checked = True Then
                chkAlmacen.Enabled = False
                dtiDiario.Enabled = False
                chkVs.Checked = True
            End If
            muestraInventario()
        End If
    End Sub
    Private Sub chkAlmacen_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAlmacen.CheckedChanged
        If Not estaCargando Then
            If chkAlmacen.CheckState = CheckState.Checked Then
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
    Private Sub cboAlmacen_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        If dsAlmacen.Tables("almacen").Rows.Count > 0 Then
            cboAlmacen.SelectedIndex = 0
        End If
    End Sub
    Private Sub cboAlmacen_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        If Not estaCargando Then
            muestraInventario()
        End If
    End Sub
    Private Sub dtiDiario_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtiDiario.TextChanged
        If Not estaCargando Then
            muestraInventario()
        End If
    End Sub
    Private Sub chkVs_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkVs.CheckedChanged
        If Not estaCargando Then
            If optDiario.Checked = True Then
                If chkVs.Checked = True Then
                    dtiDiario.Enabled = False
                Else
                    dtiDiario.Enabled = True
                End If
                muestraInventario()
            Else
                chkVs.Checked = True
            End If
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
    Sub estableceFechaInventario()
        Dim periodo As String = periodoSeleccionado()
        If periodo <> general.periodoActivo Then
            pFechaInventario = fechaF()
        Else
            pFechaInventario = pFechaActivaMax
        End If
    End Sub
    Function periodoSeleccionado()
        Dim periodo As String = Trim(Str(cboAnno.SelectedIndex + 2010)) & Microsoft.VisualBasic.Right("00" & Trim(Str(cboMes.SelectedIndex + 1)), 2)
        Return periodo
    End Function
    Sub muestraInventario()
        Dim mInventario As New Inventario
        Dim I As Integer = 0
        Dim periodo As String = periodoSeleccionado()
        Dim esHistorial As Boolean = IIf(periodo = periodoActivo(), False, True)
        Dim xAlmacen As Boolean = IIf(cboAlmacen.SelectedIndex >= 0, True, False)
        Dim cAlmacen As String = cboAlmacen.SelectedValue
        estableceFechaInventario()
        dsInventario.Clear()
        dataDetalle.DataSource = ""
        If optInicial.Checked = True Then
            dsInventario = mInventario.recInicial(pEmpresa, esHistorial, periodo, xAlmacen, cAlmacen, False, "", False, "", True, "h.cod_alma")
            dataDetalle.DataSource = dsInventario.Tables("inventario").DefaultView
            estructuraInventario()
        End If
        If optMensual.Checked = True Then
            If cboAlmacen.SelectedIndex >= 0 Then
                'dsInventario = mInventario.recInvMensual(pFechaInventario, True, cboAlmacen.SelectedValue, False)
            Else
                'dsInventario = mInventario.recInvMensual(pFechaInventario, False, "", False)
            End If
            dataDetalle.DataSource = dsInventario.Tables("inventario").DefaultView
            estructuraInventario()
            'cargaDatosInvMensual()
        End If

        If optDiario.Checked = True Then
            dsInventarioD = Inventario.dsInventarioDiario
            dataDetalle.DataSource = dsInventarioD.Tables("inventario").DefaultView
            estructuraInventarioD()
            cargaDatosInvDiario(dtiDiario.Value)
        End If

        lblRegistros.Text = "Nº de Registros... " & dataDetalle.RowCount.ToString
    End Sub
    Sub estructuraInventario()
        With dataDetalle
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_art").HeaderText = "Código"
            .Columns("cod_art").Width = 60
            .Columns("cod_art").ReadOnly = True
            .Columns("cod_art").DisplayIndex = 1
            .Columns("cod_art").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("nom_art").HeaderText = "Descripción"
            .Columns("nom_art").Width = 300
            .Columns("nom_art").ReadOnly = True
            .Columns("nom_art").DisplayIndex = 2
            .Columns("nom_uni").HeaderText = "Unidad"
            .Columns("nom_uni").Width = 70
            .Columns("nom_uni").ReadOnly = True
            .Columns("nom_uni").DisplayIndex = 3
            '.Columns("pre_costo").HeaderText = "Costo"
            '.Columns("pre_costo").Width = 80
            '.Columns("pre_costo").ReadOnly = True
            '.Columns("pre_costo").DisplayIndex = 4
            '.Columns("pre_costo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            If optMensual.Checked = True Then
                .Columns("cant_sis").HeaderText = "Sistema"
                .Columns("cant_sis").Width = 70
                .Columns("cant_sis").ReadOnly = True
                .Columns("cant_sis").DefaultCellStyle.BackColor = Color.AliceBlue
                .Columns("cant_sis").DefaultCellStyle.ForeColor = Color.MidnightBlue
                .Columns("cant_sis").DisplayIndex = 5
                .Columns("cant_fis").DisplayIndex = 6
                .Columns("nom_alma").DisplayIndex = 7
                .Columns("cant_sis").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns("fec_inv").Visible = False
                .Columns("inventario").Visible = False
            Else
                If optInicial.Checked = True Then
                    .Columns("cant_fis").DisplayIndex = 4
                    .Columns("nom_alma").DisplayIndex = 5
                End If
            End If
            .Columns("cant_fis").HeaderText = "Fisico"
            .Columns("cant_fis").Width = 70
            .Columns("cant_fis").ReadOnly = True
            .Columns("cant_fis").DefaultCellStyle.BackColor = Color.AliceBlue
            .Columns("cant_fis").DefaultCellStyle.ForeColor = Color.MidnightBlue
            .Columns("cant_fis").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("nom_alma").HeaderText = "Almacén"
            .Columns("nom_alma").Width = 150
            .Columns("nom_alma").ReadOnly = True
        End With
    End Sub
    Sub estrcturaInventarioM()

    End Sub
    Sub cargaDatosInvMensual()
        Dim periodo As String = periodoSeleccionado()
        estableceFechaInventario()
        Dim mcatalogo As New Catalogo, mInventario As New Inventario, mIngreso As New Ingreso, mMerma As New Bajas, mSalida As New Salida
        Dim dsArticulos, dsInicial, dsIngresos, dsBajas, dsSalidas As New DataSet
        Dim codigo As String, cant As Decimal
        'recuperamos los articulos
        'dsInicial = mInventario.recInicial(pFechaInventario, False, "")
        dsIngresos = mIngreso.recuperaArticulosIngresados(False, "", True, "", False, True, True, pFechaInventario, pFechaInventario, _
                    pDecimales, False, "", False, "", False, "", False, "", False, False, "", False, False, "", _
                    cPrecioCI, chPrecioCI, cPrecioSI, chPrecioSI, cPrecioCIs, chPrecioCIs, cPrecioSIs, chPrecioSIs, "nom_art", False, "", False)
        dsBajas = mMerma.recuperaBajas(False, "", True, True, pFechaInventario, pFechaInventario, pDecimales, False, "", False, False, "", False, "", "92")
        dsSalidas = mSalida.recuperaCantArticulosSalientes(False, "", True, False, False, True, pFechaInventario, pFechaInventario, pDecimales, False, "", False, "", False)
        Dim I As Integer = 0, X As Integer = 0
        If dsInventario.Tables("inventario").Rows.Count > 0 Then
            'cargamos el stock inicial
            I = 0
            For I = 0 To dsInicial.Tables("inventario").Rows.Count - 1
                codigo = dsInicial.Tables("inventario").Rows(I).Item("cod_art").ToString
                cant = dsInicial.Tables("inventario").Rows(I).Item("cant_fis").ToString
                X = 0
                For X = 0 To dataDetalle.RowCount - 1
                    If dataDetalle.Item("cod_art", X).Value = codigo Then
                        dataDetalle.Item("inicial", X).Value = cant
                        Exit For
                    End If
                Next
            Next
            'cargamos los ingresos
            I = 0
            For I = 0 To dsIngresos.Tables("ingreso").Rows.Count - 1
                codigo = dsIngresos.Tables("ingreso").Rows(I).Item("cod_art").ToString
                cant = dsIngresos.Tables("ingreso").Rows(I).Item("cant").ToString
                X = 0
                For X = 0 To dataDetalle.RowCount - 1
                    If dataDetalle.Item("cod_art", X).Value = codigo Then
                        dataDetalle.Item("ingresos", X).Value = cant
                        Exit For
                    End If
                Next
            Next
            'cargamos las bajas
            I = 0
            For I = 0 To dsBajas.Tables("mermas").Rows.Count - 1
                codigo = dsBajas.Tables("mermas").Rows(I).Item("cod_art").ToString
                cant = dsBajas.Tables("mermas").Rows(I).Item("cant").ToString
                X = 0
                For X = 0 To dataDetalle.RowCount - 1
                    If dataDetalle.Item("cod_art", X).Value = codigo Then
                        dataDetalle.Item("bajas", X).Value = cant
                        Exit For
                    End If
                Next
            Next
            'cargamos las salidas
            I = 0
            For I = 0 To dsSalidas.Tables("salida").Rows.Count - 1
                codigo = dsSalidas.Tables("salida").Rows(I).Item("cod_art").ToString
                cant = dsSalidas.Tables("salida").Rows(I).Item("cant").ToString
                X = 0
                For X = 0 To dataDetalle.RowCount - 1
                    If dataDetalle.Item("cod_art", X).Value = codigo Then
                        dataDetalle.Item("salidas", X).Value = cant
                        Exit For
                    End If
                Next
            Next
            ''cargamos los totales
            'X = 0
            'For X = 0 To dataDetalle.RowCount - 1
            '    Dim linicial As Decimal = IIf(IsDBNull(dataDetalle.Item("inicial", X).Value), 0, dataDetalle.Item("inicial", X).Value)
            '    Dim lingresos As Decimal = IIf(IsDBNull(dataDetalle.Item("ingresos", X).Value), 0, dataDetalle.Item("ingresos", X).Value)
            '    Dim lbajas As Decimal = IIf(IsDBNull(dataDetalle.Item("mermas", X).Value), 0, dataDetalle.Item("mermas", X).Value)
            '    Dim lsalidas As Decimal = IIf(IsDBNull(dataDetalle.Item("salidas", X).Value), 0, dataDetalle.Item("salidas", X).Value)
            '    dataDetalle.Item("saldo", X).Value = linicial + lingresos - lbajas - lsalidas
            'Next
        End If
        lblRegistros.Text = "Nº de Registros... " & dataDetalle.RowCount.ToString
    End Sub
    Sub estructuraInventarioD()
        With dataDetalle
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            'orden de las columnas
            .Columns("cod_art").DisplayIndex = 0
            .Columns("nom_art").DisplayIndex = 1
            .Columns("nom_uni").DisplayIndex = 2
            .Columns("inicial").DisplayIndex = 3
            .Columns("ingresos").DisplayIndex = 4
            .Columns("bajas").DisplayIndex = 5
            .Columns("Salidas").DisplayIndex = 6
            .Columns("total").DisplayIndex = 7
            .Columns("fisico").DisplayIndex = 8
            .Columns("diferencia").DisplayIndex = 9
            .Columns("otros").DisplayIndex = 10
            .Columns("nro_inv").DisplayIndex = 11
            .Columns("cod_inv").DisplayIndex = 12
            .Columns("fec_inv").DisplayIndex = 13
            .Columns("inventario").DisplayIndex = 14
            .Columns("pre_costo").DisplayIndex = 15
            .Columns("afecto_igv").DisplayIndex = 16
            'que columnas se muestran
            .Columns("cod_art").Visible = True
            .Columns("nom_art").Visible = True
            .Columns("nom_uni").Visible = True
            If chkVs.Checked = True Then
                .Columns("inicial").Visible = False
                .Columns("ingresos").Visible = False
                .Columns("bajas").Visible = False
                .Columns("salidas").Visible = False
                .Columns("total").Visible = False
                .Columns("fisico").Visible = False
            Else
                .Columns("inicial").Visible = True
                .Columns("ingresos").Visible = True
                .Columns("bajas").Visible = True
                .Columns("salidas").Visible = True
                .Columns("total").Visible = True
                .Columns("fisico").Visible = True
            End If
            .Columns("diferencia").Visible = True
            .Columns("otros").Visible = False
            .Columns("nro_inv").Visible = False
            .Columns("cod_inv").Visible = False
            .Columns("fec_inv").Visible = False
            .Columns("inventario").Visible = False
            .Columns("pre_costo").Visible = False
            .Columns("afecto_igv").Visible = False
            'estado de lectura de las columnas
            .Columns("cod_art").ReadOnly = True
            .Columns("nom_art").ReadOnly = True
            .Columns("nom_uni").ReadOnly = True
            .Columns("inicial").ReadOnly = True
            .Columns("ingresos").ReadOnly = True
            .Columns("bajas").ReadOnly = True
            .Columns("salidas").ReadOnly = True
            .Columns("total").ReadOnly = True
            .Columns("fisico").ReadOnly = True
            .Columns("diferencia").ReadOnly = True
            'ancho de las columnas
            .Columns("cod_art").Width = 60
            .Columns("nom_art").Width = 280
            .Columns("nom_uni").Width = 70
            .Columns("inicial").Width = 70
            .Columns("ingresos").Width = 70
            .Columns("bajas").Width = 70
            .Columns("salidas").Width = 70
            .Columns("total").Width = 70
            .Columns("fisico").Width = 70
            .Columns("diferencia").Width = 70
            'encabezado de las columnas
            .Columns("cod_art").HeaderText = "Código"
            .Columns("nom_art").HeaderText = "Descripción"
            .Columns("nom_uni").HeaderText = "Unidad"
            .Columns("inicial").HeaderText = "Inicial"
            .Columns("ingresos").HeaderText = "Ingresos"
            .Columns("bajas").HeaderText = "Bajas"
            .Columns("salidas").HeaderText = "salidas"
            .Columns("otros").HeaderText = "Otros"
            .Columns("total").HeaderText = "Total"
            .Columns("fisico").HeaderText = "Físico"
            .Columns("diferencia").HeaderText = "Dif."
            'alineacion de las celdas de cada columna
            .Columns("cod_art").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("nom_art").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns("nom_uni").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns("inicial").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("ingresos").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("bajas").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("salidas").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("total").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("fisico").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("diferencia").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            'alineacion del encabezado de cada columna
            '.Columns("inicial").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            'formato de las columnas numericas
            .Columns("fisico").DefaultCellStyle.Format = "##,##0.00"
            'colores
            .Columns("inicial").DefaultCellStyle.BackColor = Color.AliceBlue
            .Columns("total").DefaultCellStyle.BackColor = Color.AliceBlue
            .Columns("total").DefaultCellStyle.ForeColor = Color.MidnightBlue
            .Columns("diferencia").DefaultCellStyle.BackColor = Color.AliceBlue
            .Columns("diferencia").DefaultCellStyle.ForeColor = Color.MidnightBlue
        End With
    End Sub
    Sub cargaDatosInvDiario(ByVal fechaInventario As Date)
        Dim mCatalogo As New Catalogo, mMerma As New Bajas, mIngreso As New Ingreso
        Dim mSalida As New Salida, mInventario As New Inventario
        Dim dsArticulos As New DataSet
        Dim dsInicial, dsBajas, dsIngresos, dsSalidas, dsInvDiario As New DataSet
        Dim mfechaInicial As Date = fechaInventario.AddDays(-1)
        Dim mfecha As Date = fechaInventario
        Dim I As Integer = 0, X As Integer = 0, codigo As String = "", cant As Decimal
        'recuperamos el saldo inicial
        If chkVs.Checked = True Then
            'dsInicial = mInventario.recuperaInventarioInicial(mfecha, False, "")
            dsIngresos = mIngreso.recuperaArticulosIngresados(False, "", True, "", True, False, True, mfecha, mfecha, pDecimales, _
                        False, "", False, "", False, "", False, "", True, False, "", True, False, "", _
                        cPrecioCI, chPrecioSI, cPrecioSI, chPrecioSI, cPrecioCIs, chPrecioCIs, cPrecioSIs, chPrecioSIs, "nom_art", False, "", False)
            dsBajas = mMerma.recuperaBajas(False, "", True, True, mfecha, mfecha, pDecimales, False, "", True, False, "", False, "", "92")
            dsSalidas = mSalida.recuperaCantArticulosSalientes(False, "", True, False, False, True, mfecha, mfecha, pDecimales, False, "", False, "", True)
        Else
            If Microsoft.VisualBasic.DateAndTime.Day(mfecha) = 1 Then
                'si es el primer dia, mostramos el inventario inicial
                'dsInicial = mInventario.recuperaInventarioInicial(mfecha, False, "")
            Else
                'para dias mayores al 1ero, mostramos el conteo fisico del dia anterior
                'dsInicial = mInventario.recuperaInvDiario(False, mfechaInicial, "0000")
            End If
            dsIngresos = mIngreso.recuperaArticulosIngresados(False, "", True, "articulo.cod_art", True, False, False, mfecha, mfecha, pDecimales, _
                            False, "", False, "", False, "", False, "", True, False, "", True, False, "", _
                            cPrecioCI, chPrecioCI, cPrecioSI, chPrecioSI, cPrecioCIs, chPrecioCIs, cPrecioSIs, chPrecioSIs, "nom_art", False, "", False)
            dsBajas = mMerma.recuperaBajas(False, "", True, False, mfecha, mfecha, pDecimales, False, "", True, False, "", False, "", "92")
            dsSalidas = mSalida.recuperaCantArticulosSalientes(False, "", True, False, False, False, mfecha, mfecha, pDecimales, False, "", False, "", True)
        End If
        dsInventarioD.Clear()
        'cargamos articulos del inventario diario
        dsArticulos = mInventario.recuperaArticulosParaInventarioDiario()
        If dsArticulos.Tables("inv_diario").Rows.Count > 0 Then
            I = 0
            For I = 0 To dsArticulos.Tables("inv_diario").Rows.Count - 1
                Dim fila As DataRow = dsInventarioD.Tables("inventario").NewRow
                fila.Item("cod_art") = dsArticulos.Tables("inv_diario").Rows(I).Item("cod_art").ToString
                fila.Item("nom_art") = dsArticulos.Tables("inv_diario").Rows(I).Item("nom_art").ToString
                fila.Item("nom_uni") = dsArticulos.Tables("inv_diario").Rows(I).Item("nom_uni").ToString
                fila.Item("pre_costo") = dsArticulos.Tables("inv_diario").Rows(I).Item("pre_costo").ToString
                fila.Item("afecto_igv") = dsArticulos.Tables("inv_diario").Rows(I).Item("afecto_igv").ToString
                dsInventarioD.Tables("inventario").Rows.Add(fila)
            Next
            'cargamos el inventario inicial
            I = 0
            If chkVs.Checked = True Then
                For I = 0 To dsInicial.Tables("inventario").Rows.Count - 1
                    codigo = dsInicial.Tables("inventario").Rows(I).Item("cod_art").ToString
                    cant = dsInicial.Tables("inventario").Rows(I).Item("cant_fis").ToString
                    X = 0
                    For X = 0 To dataDetalle.RowCount - 1
                        If dataDetalle.Item("cod_art", X).Value = codigo Then
                            dataDetalle.Item("inicial", X).Value = cant
                            Exit For
                        End If
                    Next
                Next
            Else
                If Microsoft.VisualBasic.DateAndTime.Day(mfecha) = 1 Then
                    For I = 0 To dsInicial.Tables("inventario").Rows.Count - 1
                        codigo = dsInicial.Tables("inventario").Rows(I).Item("cod_art").ToString
                        cant = dsInicial.Tables("inventario").Rows(I).Item("cant_fis").ToString
                        X = 0
                        For X = 0 To dataDetalle.RowCount - 1
                            If dataDetalle.Item("cod_art", X).Value = codigo Then
                                dataDetalle.Item("inicial", X).Value = cant
                                Exit For
                            End If
                        Next
                    Next
                Else
                    'si el dia es 2 o mayor, cargamos el conteo fisico del dia anterior como inicial
                    For I = 0 To dsInicial.Tables("inv_diario").Rows.Count - 1
                        codigo = dsInicial.Tables("inv_diario").Rows(I).Item("cod_art").ToString
                        cant = dsInicial.Tables("inv_diario").Rows(I).Item("cant_fis").ToString
                        X = 0
                        For X = 0 To dataDetalle.RowCount - 1
                            If dataDetalle.Item("cod_art", X).Value = codigo Then
                                dataDetalle.Item("inicial", X).Value = cant
                                Exit For
                            End If
                        Next
                    Next
                End If
            End If
            'cargamos los ingresos
            I = 0
            For I = 0 To dsIngresos.Tables("ingreso").Rows.Count - 1
                codigo = dsIngresos.Tables("ingreso").Rows(I).Item("cod_art").ToString
                cant = dsIngresos.Tables("ingreso").Rows(I).Item("cant").ToString
                X = 0
                For X = 0 To dataDetalle.RowCount - 1
                    If dataDetalle.Item("cod_art", X).Value = codigo Then
                        dataDetalle.Item("ingresos", X).Value = cant
                        Exit For
                    End If
                Next
            Next
            'cargamos las bajas
            I = 0
            For I = 0 To dsBajas.Tables("mermas").Rows.Count - 1
                codigo = dsBajas.Tables("mermas").Rows(I).Item("cod_art").ToString
                cant = dsBajas.Tables("mermas").Rows(I).Item("cant").ToString
                X = 0
                For X = 0 To dataDetalle.RowCount - 1
                    If dataDetalle.Item("cod_art", X).Value = codigo Then
                        dataDetalle.Item("bajas", X).Value = cant
                        Exit For
                    End If
                Next
            Next
            'cargamos las salidas
            I = 0
            For I = 0 To dsSalidas.Tables("salida").Rows.Count - 1
                codigo = dsSalidas.Tables("salida").Rows(I).Item("cod_art").ToString
                cant = dsSalidas.Tables("salida").Rows(I).Item("cant").ToString
                X = 0
                For X = 0 To dataDetalle.RowCount - 1
                    If dataDetalle.Item("cod_art", X).Value = codigo Then
                        dataDetalle.Item("salidas", X).Value = cant
                        Exit For
                    End If
                Next
            Next
            'cargamos las cantidades contadas
            Dim existe As Boolean = verificaExistenciaInventarioDiario()
            If chkVs.Checked = True Then
                If existe Then
                    'dsInvDiario = mInventario.recuperaInvDiario(True, dtiDiario.Value, "0000")
                    I = 0
                    For I = 0 To dsInvDiario.Tables("inv_diario").Rows.Count - 1
                        codigo = dsInvDiario.Tables("inv_diario").Rows(I).Item("cod_art").ToString
                        cant = dsInvDiario.Tables("inv_diario").Rows(I).Item("cant_fis").ToString
                        Dim nro_inv As Integer = dsInvDiario.Tables("inv_diario").Rows(I).Item("inventario").ToString
                        X = 0
                        For X = 0 To dataDetalle.RowCount - 1
                            If dataDetalle.Item("cod_art", X).Value = codigo Then
                                dataDetalle.Item("fisico", X).Value = cant
                                dataDetalle.Item("nro_inv", X).Value = nro_inv
                                Exit For
                            End If
                        Next
                    Next
                End If
            Else
                If existe Then
                    'dsInvDiario = mInventario.recuperaInvDiario(False, dtiDiario.Value, "0000")
                    I = 0
                    For I = 0 To dsInvDiario.Tables("inv_diario").Rows.Count - 1
                        codigo = dsInvDiario.Tables("inv_diario").Rows(I).Item("cod_art").ToString
                        cant = dsInvDiario.Tables("inv_diario").Rows(I).Item("cant_fis").ToString
                        Dim nro_inv As Integer = dsInvDiario.Tables("inv_diario").Rows(I).Item("inventario").ToString
                        X = 0
                        For X = 0 To dataDetalle.RowCount - 1
                            If dataDetalle.Item("cod_art", X).Value = codigo Then
                                dataDetalle.Item("fisico", X).Value = cant
                                dataDetalle.Item("nro_inv", X).Value = nro_inv
                                Exit For
                            End If
                        Next
                    Next
                End If
            End If
            'cargamos los totales
            X = 0
            For X = 0 To dataDetalle.RowCount - 1
                Dim linicial As Decimal = IIf(IsDBNull(dataDetalle.Item("inicial", X).Value), 0, dataDetalle.Item("inicial", X).Value)
                Dim lingresos As Decimal = IIf(IsDBNull(dataDetalle.Item("ingresos", X).Value), 0, dataDetalle.Item("ingresos", X).Value)
                Dim lbajas As Decimal = IIf(IsDBNull(dataDetalle.Item("bajas", X).Value), 0, dataDetalle.Item("bajas", X).Value)
                Dim lsalidas As Decimal = IIf(IsDBNull(dataDetalle.Item("salidas", X).Value), 0, dataDetalle.Item("salidas", X).Value)
                If existe Then
                    dataDetalle.Item("total", X).Value = linicial + lingresos - lbajas - lsalidas
                Else
                    dataDetalle.Item("total", X).Value = linicial + lingresos - lbajas - lsalidas
                End If
            Next
            'cargamos las diferencias
            If chkVs.Checked = True Then
                'dsInvDiario = mInventario.recuperaInvDiario(True, dtiDiario.Value, "0000")
                I = 0
                For I = 0 To dsInvDiario.Tables("inv_diario").Rows.Count - 1
                    codigo = dsInvDiario.Tables("inv_diario").Rows(I).Item("cod_art").ToString
                    cant = dsInvDiario.Tables("inv_diario").Rows(I).Item("dif").ToString
                    Dim nro_inv As Integer = dsInvDiario.Tables("inv_diario").Rows(I).Item("inventario").ToString
                    X = 0
                    For X = 0 To dataDetalle.RowCount - 1
                        If dataDetalle.Item("cod_art", X).Value = codigo Then
                            dataDetalle.Item("diferencia", X).Value = cant
                            dataDetalle.Item("nro_inv", X).Value = nro_inv
                            Exit For
                        End If
                    Next
                Next
            Else
                If existe Then
                    'dsInvDiario = mInventario.recuperaInvDiario(False, dtiDiario.Value, "0000")
                    I = 0
                    For I = 0 To dsInvDiario.Tables("inv_diario").Rows.Count - 1
                        codigo = dsInvDiario.Tables("inv_diario").Rows(I).Item("cod_art").ToString
                        cant = dsInvDiario.Tables("inv_diario").Rows(I).Item("dif").ToString
                        Dim nro_inv As Integer = dsInvDiario.Tables("inv_diario").Rows(I).Item("inventario").ToString
                        X = 0
                        For X = 0 To dataDetalle.RowCount - 1
                            If dataDetalle.Item("cod_art", X).Value = codigo Then
                                dataDetalle.Item("diferencia", X).Value = cant
                                dataDetalle.Item("nro_inv", X).Value = nro_inv
                                Dim dife As Decimal = dataDetalle.Item("fisico", X).Value - dataDetalle.Item("total", X).Value
                                If dife <> cant Then
                                    mInventario.actualizaDiferenciaDiario(nro_inv, dife)
                                End If
                                Exit For
                            End If
                        Next
                    Next
                End If
            End If
        End If
    End Sub
    Function verificaExistenciaInventarioDiario() As Boolean
        Dim mInventario As New Inventario
        Dim existeInventario As Boolean
        If chkVs.Checked = True Then
            'existeInventario = mInventario.existeInventarioDiario(True, dtiDiario.Value, "0000")
        Else
            'existeInventario = mInventario.existeInventarioDiario(False, dtiDiario.Value, "0000")
        End If
        If existeInventario Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub optCodigo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optCodigo.CheckedChanged
        txtBuscar.Focus()
    End Sub
    Private Sub optDescripcion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optDescripcion.CheckedChanged
        txtBuscar.Focus()
    End Sub
    Private Sub txtBuscar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBuscar.KeyDown
        If e.KeyCode = Keys.Enter Then
            dataDetalle.Focus()
        End If
    End Sub
    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged
        Dim valor As String = txtBuscar.Text
        If optDiario.Checked = False Then
            If optCodigo.Checked = True Then
                dsInventario.Tables("inventario").DefaultView.RowFilter = "cod_art LIKE '" & valor & "%'"
                If dataDetalle.RowCount > 0 Then
                    dataDetalle.CurrentCell = dataDetalle("cod_art", dataDetalle.CurrentRow.Index)
                End If
            Else
                dsInventario.Tables("inventario").DefaultView.RowFilter = "nom_art LIKE '" & valor & "%'"
                If dataDetalle.RowCount > 0 Then
                    dataDetalle.CurrentCell = dataDetalle("nom_art", dataDetalle.CurrentRow.Index)
                End If
            End If
        Else
            If optCodigo.Checked = True Then
                dsInventarioD.Tables("inventario").DefaultView.RowFilter = "cod_art LIKE '" & valor & "%'"
                If dataDetalle.RowCount > 0 Then
                    dataDetalle.CurrentCell = dataDetalle("cod_art", dataDetalle.CurrentRow.Index)
                End If
            Else
                dsInventarioD.Tables("inventario").DefaultView.RowFilter = "nom_art LIKE '" & valor & "%'"
                If dataDetalle.RowCount > 0 Then
                    dataDetalle.CurrentCell = dataDetalle("nom_art", dataDetalle.CurrentRow.Index)
                End If
            End If
        End If
    End Sub
    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        Dim periodo As String = periodoSeleccionado()
        Dim periodoReporte As String = "Periodo: " & general.periodo_mesAnnoLetras(periodo)
        Dim fechaReporte As String
        Dim frm As New rptForm
        If optInicial.Checked = True Then
            fechaReporte = "Al: " & general.devuelveFechaImpresionEspecificado(fechaI)
            If cboAlmacen.SelectedIndex >= 0 Then
                frm.cargarInventarioInicial(dsInventario, cboAlmacen.Text, fechaReporte, periodoReporte, False, "", False)
            Else
                frm.cargarInventarioInicial(dsInventario, "", fechaReporte, periodoReporte, False, "", False)
            End If
        End If
        If optMensual.Checked = True Then
            fechaReporte = "Al: " & general.devuelveFechaImpresionEspecificado(pFechaInventario)
            'If cboAlmacen.SelectedIndex >= 0 Then
            '    frm.cargarInventarioMensual(dsInventario, cboAlmacen.Text, fechaReporte, periodoReporte)
            'Else
            '    frm.cargarInventarioMensual(dsInventario, "", fechaReporte, periodoReporte)
            'End If
        End If
        If optDiario.Checked = True Then
            Dim fechaProceso As String
            If chkVs.Checked = True Then
                fechaProceso = "Al: " & general.devuelveFechaImpresionEspecificado(pFechaSystem)
                frm.cargarInventarioDiario(True, dsInventarioD, fechaProceso)
            Else
                fechaProceso = general.devuelveFechaImpresionEspecificado(dtiDiario.Value)
                frm.cargarInventarioDiario(False, dsInventarioD, fechaProceso)
            End If
        End If
        frm.MdiParent = principal
        frm.Show()
    End Sub
    Private Sub cmdCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCerrar.Click
        Me.Close()
    End Sub

    Private Sub dtiDiario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtiDiario.Click

    End Sub
End Class
