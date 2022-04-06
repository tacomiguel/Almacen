Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Math
Imports libreriaClases
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class p_inventarioFisico
    Private dsInventario As New DataSet
    Private dsAlmacen As New DataSet
    Private dsArticulos As New DataSet
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
    Private Sub p_inventarioDiario_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        verificaExistenciaInventarioDiario()
    End Sub
    Private Sub p_inventarioDiario_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        principal.mp_invDiario.Enabled = True
    End Sub
    Private Sub p_inventariofisico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'establecemos fecha de proceso
        estableceFechaProceso()
        'capturamos el separador decimal
        sepDecimal = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        'dataset almacen
        Dim daAlmacen As New MySqlDataAdapter
        Dim cadAlma As String
        If pAlmaUser = "0000" Then
            cadAlma = "select cod_alma,nom_alma from almacen where (esProduccion) and activo=1"
        Else
            cadAlma = "select cod_alma,nom_alma from almacen where cod_alma='" & pAlmaUser & "'" _
                    & " and (esProduccion) and activo=1"
        End If
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
        Dim cAlmacen As String = cboAlmacen.SelectedValue
        dsInventario = Inventario.dsInventarioDiario
        With dataDetalle
            .DataSource = dsInventario.Tables("inventario")
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
            .Columns("inicial").Visible = True
            .Columns("ingresos").Visible = True
            .Columns("bajas").Visible = True
            .Columns("salidas").Visible = True
            .Columns("total").Visible = True
            .Columns("fisico").Visible = True
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
            .Columns("fisico").ReadOnly = False
            .Columns("diferencia").ReadOnly = True
            'ancho de las columnas
            .Columns("cod_art").Width = 60
            .Columns("nom_art").Width = 300
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
            .Columns("fisico").DefaultCellStyle.BackColor = Color.AliceBlue
            .Columns("fisico").DefaultCellStyle.ForeColor = Color.MidnightBlue
        End With
        'If pNivelUser <> 0 Then
        '    If pFechaSystem <> mcFInventario.SelectedDate Then
        '        dataDetalle.Columns("fisico").ReadOnly = True
        '    End If
        'End If
        estaCargando = False
    End Sub
    Private Sub cmdConteofisico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim rpta As Integer
        rpta = MessageBox.Show("¿Esta seguro de Inciar el Registro del Conteo Físico...?", "CEFE", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If rpta = 6 Then
            Dim mInventario As New Inventario, I As Integer = 0, cod_art As String, precio, cantSistema As Decimal
            dataDetalle.Columns("fisico").ReadOnly = False
            Dim operacion As Integer = mInventario.maxOperacionDiario
            Dim inventario As Integer = mInventario.maxInventarioDiario
            Dim fecha_inv As Date
            Dim cod_alma As String
            If pCatalogoXalmacen Then
                cod_alma = cboAlmacen.SelectedValue
            Else
                cod_alma = "0000"
            End If
            mInventario.insertar_invDiario(operacion, fecha_inv, pDecimales, cod_alma, pCuentaUser)
            For I = 0 To dataDetalle.RowCount - 1
                cod_art = dataDetalle("cod_art", I).Value
                precio = dataDetalle("pre_costo", I).Value
                cantSistema = dataDetalle("total", I).Value
                mInventario.insertar_detInvDiario(operacion, inventario, cod_art, cantSistema, 0, -cantSistema, precio, pCuentaUser)
                inventario = inventario + 1
            Next
        End If
    End Sub
    Sub cargaDatosInventario(ByVal fechaInventario As Date)
        dsInventario.Clear()
        Dim mCatalogo As New Catalogo, mMerma As New Bajas, mIngreso As New Ingreso
        Dim mSalida As New Salida, mInventario As New Inventario
        Dim dsInicial, dsBajas, dsIngresos, dsSalidas, dsInvDiario As New DataSet
        Dim mfechaInicial As Date = fechaInventario.AddDays(-1)
        Dim mfecha As Date = fechaInventario
        Dim xAlmacen As Boolean = IIf(chkAlmacen.Checked = True, True, False)
        Dim cAlmacen As String = cboAlmacen.SelectedValue
        Dim xGrupo As Boolean = IIf(chkGrupo.Checked = True, True, False)
        Dim cGrupo As String = cboGrupo.SelectedValue
        Dim I As Integer = 0, X As Integer = 0, codigo As String = "", cant As Decimal
        'recuperamos el saldo inicial
        If Microsoft.VisualBasic.DateAndTime.Day(mfecha) = 1 Then
            'si es el primer dia, mostramos el inventario inicial
            dsInicial = mInventario.recInicial(pEmpresa, False, "", True, cAlmacen, False, "", False, "", True, "")
        Else
            'para dias mayores al 1ero, mostramos el conteo fisico del dia anterior
            dsInicial = mInventario.recDiario(False, "", False, mfechaInicial, mfechaInicial, xAlmacen, cAlmacen, xGrupo, cGrupo)
        End If
        dsIngresos = mIngreso.recuperaArticulosIngresados(False, "", True, True, False, False, mfecha, mfecha, pDecimales, _
                    False, "", False, "", False, "", False, "", True, False, "", True, False, "", _
                    cPrecioCI, chPrecioCI, cPrecioSI, chPrecioSI, cPrecioCIs, chPrecioCIs, cPrecioSIs, chPrecioSIs, "nom_art")
        dsBajas = mMerma.recuperaBajas(False, "", True, False, mfecha, mfecha, pDecimales, False, "", True, False, "")
        dsSalidas = mSalida.recuperaCantidad_de_ArticulosSalientes(False, "", True, False, False, False, mfecha, mfecha, pDecimales, False, "", True)
        'cargamos articulos del inventario diario
        dsArticulos = mInventario.recuperaArticulosParaInventarioDiario()
        If dsArticulos.Tables("inv_diario").Rows.Count > 0 Then
            I = 0
            For I = 0 To dsArticulos.Tables("inv_diario").Rows.Count - 1
                Dim fila As DataRow = dsInventario.Tables("inventario").NewRow
                fila.Item("cod_art") = dsArticulos.Tables("inv_diario").Rows(I).Item("cod_art").ToString
                fila.Item("nom_art") = dsArticulos.Tables("inv_diario").Rows(I).Item("nom_art").ToString
                fila.Item("nom_uni") = dsArticulos.Tables("inv_diario").Rows(I).Item("nom_uni").ToString
                fila.Item("pre_costo") = dsArticulos.Tables("inv_diario").Rows(I).Item("pre_costo").ToString
                fila.Item("afecto_igv") = dsArticulos.Tables("inv_diario").Rows(I).Item("afecto_igv").ToString
                dsInventario.Tables("inventario").Rows.Add(fila)
            Next
            'cargamos el inventario inicial
            I = 0
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
                For I = 0 To dsInicial.Tables("inventario").Rows.Count - 1
                    codigo = dsInicial.Tables("inventaio").Rows(I).Item("cod_art").ToString
                    cant = dsInicial.Tables("inventario").Rows(I).Item("cant_fis").ToString
                    X = 0
                    For X = 0 To dataDetalle.RowCount - 1
                        If dataDetalle.Item("cod_art", X).Value = codigo Then
                            dataDetalle.Item("inicial", X).Value = cant
                            Exit For
                        End If
                    Next
                Next
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
            'Dim existe As Boolean = verificaExistenciaInventarioDiario()
            'If existe Then
            '    dsInicial = mInventario.recDiario(False, "", False, mfechaInicial, mfechaInicial, xAlmacen, cAlmacen, xGrupo, cGrupo)
            '    I = 0
            '    For I = 0 To dsInvDiario.Tables("inv_diario").Rows.Count - 1
            '        codigo = dsInvDiario.Tables("inv_diario").Rows(I).Item("cod_art").ToString
            '        cant = dsInvDiario.Tables("inv_diario").Rows(I).Item("cant_fis").ToString
            '        Dim nro_inv As Integer = dsInvDiario.Tables("inv_diario").Rows(I).Item("inventario").ToString
            '        X = 0
            '        For X = 0 To dataDetalle.RowCount - 1
            '            If dataDetalle.Item("cod_art", X).Value = codigo Then
            '                dataDetalle.Item("fisico", X).Value = cant
            '                dataDetalle.Item("nro_inv", X).Value = nro_inv
            '                Exit For
            '            End If
            '        Next
            '    Next
            'End If
            'cargamos el total
            X = 0
            For X = 0 To dataDetalle.RowCount - 1
                Dim linicial As Decimal = IIf(IsDBNull(dataDetalle.Item("inicial", X).Value), 0, dataDetalle.Item("inicial", X).Value)
                Dim lingresos As Decimal = IIf(IsDBNull(dataDetalle.Item("ingresos", X).Value), 0, dataDetalle.Item("ingresos", X).Value)
                Dim lbajas As Decimal = IIf(IsDBNull(dataDetalle.Item("bajas", X).Value), 0, dataDetalle.Item("bajas", X).Value)
                Dim lsalidas As Decimal = IIf(IsDBNull(dataDetalle.Item("salidas", X).Value), 0, dataDetalle.Item("salidas", X).Value)
                'If existe Then
                '    dataDetalle.Item("total", X).Value = linicial + lingresos - lbajas - lsalidas
                'Else
                '    dataDetalle.Item("total", X).Value = linicial + lingresos - lbajas - lsalidas
                'End If
            Next
            'cargamos las diferencias
            'If existe Then
            '    'dsInvDiario = mInventario.recuperaInvDiario(False, mcFInventario.SelectedDate, "0000")
            '    I = 0
            '    For I = 0 To dsInvDiario.Tables("inv_diario").Rows.Count - 1
            '        codigo = dsInvDiario.Tables("inv_diario").Rows(I).Item("cod_art").ToString
            '        cant = dsInvDiario.Tables("inv_diario").Rows(I).Item("dif").ToString
            '        Dim nro_inv As Integer = dsInvDiario.Tables("inv_diario").Rows(I).Item("inventario").ToString
            '        X = 0
            '        For X = 0 To dataDetalle.RowCount - 1
            '            If dataDetalle.Item("cod_art", X).Value = codigo Then
            '                dataDetalle.Item("diferencia", X).Value = cant
            '                dataDetalle.Item("nro_inv", X).Value = nro_inv
            '                Dim dife As Decimal = dataDetalle.Item("fisico", X).Value - dataDetalle.Item("total", X).Value
            '                If dife <> cant Then
            '                    mInventario.actualizaDiferenciaDiario(nro_inv, dife)
            '                End If
            '                Exit For
            '            End If
            '        Next
            '    Next
            'End If
        End If
    End Sub
    Function verificaExistenciaInventarioDiario() As Boolean
        Dim mInventario As New Inventario
        Dim mFecha As Date = mcFInventario.SelectedDate
        Dim cAlmacen As String = cboAlmacen.SelectedValue
        Dim existe As Boolean = mInventario.existDiario(mFecha, True, cAlmacen)
        If existe Then
            cmdConteoFisico.Enabled = False
            dataDetalle.Columns("fisico").ReadOnly = False
            Return True
        Else
            cmdConteoFisico.Enabled = True
            dataDetalle.Columns("fisico").ReadOnly = True
            Return False
        End If
    End Function
    Sub recalculaDiferencias()
        Dim existe As Boolean = verificaExistenciaInventarioDiario()
        If existe Then
            dataDetalle("diferencia", dataDetalle.CurrentRow.Index).Value = dataDetalle("fisico", dataDetalle.CurrentRow.Index).Value - dataDetalle("total", dataDetalle.CurrentRow.Index).Value
        End If
    End Sub
    Private Sub dataDetalle_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataDetalle.CellEndEdit
        If dataDetalle.CurrentCell.ColumnIndex = dataDetalle.Columns("fisico").Index Then
            If IsDBNull(dataDetalle("nro_inv", dataDetalle.CurrentRow.Index).Value) Then
                MessageBox.Show("Para la Fecha Seleccionada NO era Inventariable este Producto...", "CEFE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                dataDetalle("fisico", dataDetalle.CurrentRow.Index).Value = 0
            Else
                Dim lcantidad As Decimal, nroInventario As Integer
                If IsDBNull(dataDetalle("fisico", dataDetalle.CurrentRow.Index).Value) Then
                    lcantidad = 0
                    dataDetalle("fisico", dataDetalle.CurrentRow.Index).Value = 0
                Else
                    lcantidad = dataDetalle("fisico", dataDetalle.CurrentRow.Index).Value
                End If
                Dim mInventario As New Inventario, ldif As Decimal
                nroInventario = dataDetalle("nro_inv", dataDetalle.CurrentRow.Index).Value
                ldif = dataDetalle("total", dataDetalle.CurrentRow.Index).Value - dataDetalle("fisico", dataDetalle.CurrentRow.Index).Value
                mInventario.actualizaFisicoDiario(nroInventario, lcantidad)
                mInventario.actualizaDiferenciaDiario(nroInventario, ldif)
                recalculaDiferencias()
            End If
        End If
    End Sub
    Sub estableceFechaProceso()
        mcFInventario.MaxDate = pFechaActivaMax
        mcFInventario.MinDate = pFechaActivaMin
        If Month(pFechaActivaMax) = Month(pFechaSystem) Then
            mcFInventario.DisplayMonth = pFechaSystem
            mcFInventario.SelectedDate = pFechaSystem
        Else
            mcFInventario.DisplayMonth = pFechaActivaMax
            mcFInventario.SelectedDate = pFechaActivaMax
        End If
    End Sub
    Private Sub cmdCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCerrar.Click
        Me.Close()
    End Sub
    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        Dim fechaProceso As String = general.devuelveFechaImpresionEspecificado(mcFInventario.SelectedDate)
        Dim frm As New rptForm
        frm.cargarInventarioDiario(False, dsInventario, fechaProceso)
        frm.MdiParent = principal
        frm.Show()
    End Sub

    Private Sub chkGrupo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class

