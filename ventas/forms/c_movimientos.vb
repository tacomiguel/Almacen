Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Math
Imports libreriaClases
Public Class c_movimientos
    Private dsMovimientos As New DataSet
    Private dsAlmacen As New DataSet
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
    Private Sub c_movimientos_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        principal.mr_movimientos.Enabled = True
    End Sub
    Private Sub c_movimientos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        Dim comAlmacen As New MySqlCommand("select cod_alma,nom_alma from almacen where activo=1", dbConex)
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
        dsMovimientos = Movimientos.dsMovimientos
        With dataDetalle
            .ReadOnly = True
            .DataSource = dsMovimientos.Tables("movimientos").DefaultView
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_art").HeaderText = "Código"
            .Columns("cod_art").Width = 60
            .Columns("cod_art").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("nom_art").HeaderText = "Descripción"
            .Columns("nom_art").Width = 270
            .Columns("nom_uni").HeaderText = "Unidad"
            .Columns("nom_uni").Width = 70
            .Columns("nom_uni").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("inicial").HeaderText = "Inicial"
            .Columns("inicial").Width = 65
            .Columns("inicial").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("ingresos").HeaderText = "Ingresos"
            .Columns("ingresos").Width = 65
            .Columns("ingresos").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("mermas").HeaderText = "Mermas"
            .Columns("mermas").Width = 65
            .Columns("mermas").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("salidas").HeaderText = "Salidas"
            .Columns("salidas").Width = 65
            .Columns("salidas").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("saldo").HeaderText = "Stock"
            .Columns("saldo").Width = 65
            .Columns("saldo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("cod_alma").Visible = False
            .Columns("cod_sgrupo").Visible = False
        End With
        estaCargando = False
        estableceFechas()
        muestraMovimientos()
    End Sub
    Private Sub cboMes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMes.SelectedIndexChanged
        If Not estaCargando Then
            estableceFechas()
            chkDia.CheckState = CheckState.Unchecked
            If Not estaCargando Then
                muestraMovimientos()
            End If
        End If
    End Sub
    Private Sub cboAnno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAnno.SelectedIndexChanged
        If Not estaCargando Then
            estableceFechas()
            chkDia.CheckState = CheckState.Unchecked
            If Not estaCargando Then
                muestraMovimientos()
            End If
        End If
    End Sub
    Private Sub chkDia_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDia.CheckedChanged
        If Not estaCargando Then
            estableceFechas()
            If chkDia.CheckState = CheckState.Checked Then
                dtiDesde.Enabled = True
                dtiHasta.Enabled = True
                muestraMovimientos()
            Else
                dtiDesde.Enabled = False
                dtiHasta.Enabled = False
            End If
            If Not estaCargando Then
                muestraMovimientos()
            End If
        End If
    End Sub
    Private Sub dtiDesde_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtiDesde.ValueChanged
        If Not estaCargando Then
            muestraMovimientos()
        End If
    End Sub
    Private Sub dtiHasta_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtiHasta.ValueChanged
        If Not estaCargando Then
            muestraMovimientos()
        End If
    End Sub
    Private Sub optIntegrado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optIntegrado.CheckedChanged
        If Not estaCargando Then
            If optIntegrado.Checked = True Then
                cboAlmacen.SelectedIndex = -1
                cboAlmacen.Enabled = False
            End If
            If Not estaCargando Then
                muestraMovimientos()
            End If
        End If
    End Sub
    Private Sub optAlmacen_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optAlmacen.CheckedChanged
        If Not estaCargando Then
            If optAlmacen.Checked = True Then
                cboAlmacen.Enabled = True
                cboAlmacen.Focus()
            End If
            If Not estaCargando Then
                muestraMovimientos()
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
            muestraMovimientos()
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
    Sub muestraMovimientos()
        dsMovimientos.Clear()
        Dim mcatalogo As New Catalogo, mInventario As New Inventario, mIngreso As New Ingreso, mMerma As New Bajas, mSalida As New Salida
        Dim dsArticulos, dsInicial, dsIngresos, dsBajas, dsSalidas As New DataSet
        Dim codigo As String, cant As Decimal, recuperadoDeInventario As Boolean = False
        'variables para recuperar la informacion
        Dim periodo As String = periodoSeleccionado()
        Dim esHistorial As Boolean = IIf(periodo = periodoActivo(), False, True)
        Dim esMensual As Boolean = IIf(chkDia.CheckState = True, False, True)
        Dim xAlmacen As Boolean = IIf(cboAlmacen.SelectedIndex >= 0, True, False)
        Dim cAlmacen As String = cboAlmacen.SelectedValue
        'recuperamos los articulos
        If periodoActivo() = periodoSeleccionado() Then
            dsArticulos = mIngreso.recuperaDescripcionArticulosIngresados(xAlmacen, cAlmacen, False, "")
            If esMensual Or Microsoft.VisualBasic.DateAndTime.Day(dtiDesde.Value) = 1 Then
                recuperadoDeInventario = True
                dsInicial = mInventario.recInicial(pEmpresa, esHistorial, periodo, xAlmacen, cAlmacen, False, "", False, "", True, "h.cod_art")
            Else
                recuperadoDeInventario = False
                dsInicial = mcatalogo.recuperaSaldoAlmacen_xdia(dtiDesde.Value.AddDays(-1), cAlmacen, True)
            End If
            dsIngresos = mIngreso.recuperaArticulosIngresados(esHistorial, periodo, True, "articulo.cod_art", False, True, esMensual, _
                        dtiDesde.Value, dtiHasta.Value, pDecimales, xAlmacen, cAlmacen, False, "", False, "", False, _
                        "", False, False, "", True, False, "", cPrecioCI, chPrecioCI, cPrecioSI, chPrecioSI, _
                        cPrecioCIs, chPrecioCIs, cPrecioSIs, chPrecioSIs, "cod_art", False, "", False)
            dsBajas = mMerma.recuperaBajas(esHistorial, periodo, True, esMensual, dtiDesde.Value, dtiHasta.Value, pDecimales, xAlmacen, cAlmacen, False, False, "", False, "", "92")
            dsSalidas = mSalida.recuperaCantArticulosSalientes(False, "", True, False, False, esMensual, dtiDesde.Value, dtiHasta.Value, pDecimales, False, "", xAlmacen, cAlmacen, False)
        Else

        End If
        Dim I As Integer = 0, X As Integer = 0
        If dsArticulos.Tables("articulos").Rows.Count > 0 Then
            'cargamos los articulos del almacen seleccionado
            For I = 0 To dsArticulos.Tables("articulos").Rows.Count - 1
                Dim fila As DataRow = dsMovimientos.Tables("movimientos").NewRow
                fila.Item("cod_art") = dsArticulos.Tables("articulos").Rows(I).Item("cod_art").ToString
                fila.Item("nom_art") = dsArticulos.Tables("articulos").Rows(I).Item("nom_art").ToString
                fila.Item("nom_uni") = dsArticulos.Tables("articulos").Rows(I).Item("nom_uni").ToString
                fila.Item("cod_alma") = dsArticulos.Tables("articulos").Rows(I).Item("cod_alma").ToString
                fila.Item("cod_sgrupo") = dsArticulos.Tables("articulos").Rows(I).Item("cod_sgrupo").ToString
                dsMovimientos.Tables("movimientos").Rows.Add(fila)
            Next
            'cargamos el stock inicial
            I = 0
            If recuperadoDeInventario Then
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
                For I = 0 To dsInicial.Tables("saldo").Rows.Count - 1
                    codigo = dsInicial.Tables("saldo").Rows(I).Item("cod_art").ToString
                    cant = dsInicial.Tables("saldo").Rows(I).Item("saldo").ToString
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
                        dataDetalle.Item("mermas", X).Value = cant
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
            'cargamos los totales
            X = 0
            For X = 0 To dataDetalle.RowCount - 1
                Dim linicial As Decimal = IIf(IsDBNull(dataDetalle.Item("inicial", X).Value), 0, dataDetalle.Item("inicial", X).Value)
                Dim lingresos As Decimal = IIf(IsDBNull(dataDetalle.Item("ingresos", X).Value), 0, dataDetalle.Item("ingresos", X).Value)
                Dim lbajas As Decimal = IIf(IsDBNull(dataDetalle.Item("mermas", X).Value), 0, dataDetalle.Item("mermas", X).Value)
                Dim lsalidas As Decimal = IIf(IsDBNull(dataDetalle.Item("salidas", X).Value), 0, dataDetalle.Item("salidas", X).Value)
                dataDetalle.Item("saldo", X).Value = linicial + lingresos - lbajas - lsalidas
            Next
        End If
        lblRegistros.Text = "Nº de Registros... " & dataDetalle.RowCount.ToString
    End Sub
    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged
        Dim valor As String = txtBuscar.Text
        If optCodigo.Checked = True Then
            dsMovimientos.Tables("movimientos").DefaultView.RowFilter = "cod_art LIKE '" & valor & "%'"
            If dataDetalle.RowCount > 0 Then
                dataDetalle.CurrentCell = dataDetalle("cod_art", dataDetalle.CurrentRow.Index)
            End If
        Else
            dsMovimientos.Tables("movimientos").DefaultView.RowFilter = "nom_art LIKE '" & valor & "%'"
            If dataDetalle.RowCount > 0 Then
                dataDetalle.CurrentCell = dataDetalle("nom_art", dataDetalle.CurrentRow.Index)
            End If
        End If
    End Sub
    Private Sub cmdCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCerrar.Click
        Me.Close()
    End Sub

    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click

    End Sub
End Class

