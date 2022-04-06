Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Math
Imports libreriaClases
Imports System
Public Class e_ventas
    Private dsVentasDiarias As New DataSet
    Private dsVentas As New DataSet
    Private dsAlmacen As New DataSet
    Private dsCantidadVD As New DataSet
    Private dsCantidadVF As New DataSet
    Private dsCantidadRan As New DataSet
    Private dsFluctuacionVM As New DataSet
    Private estaCargando As Boolean = True
    Private Sub e_ventas_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        principal.me_ventas.Enabled = True
    End Sub
    Private Sub e_ventas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Top = 0
        Me.Left = 0
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
        dtiDesde.MaxDate = pFechaSystem
        dtiDesde.MinDate = pFechaActivaMin
        dtiHasta.MaxDate = pFechaSystem
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
        'Dim mVentas As New eVenta
        'dsCantidadVD = mVentas.recuperaVentas(True, True, dtiDesde.Value, dtiHasta.Value, pDecimales)
        estaCargando = False
        muestraVentas()
    End Sub
    Private Sub cboMes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMes.SelectedIndexChanged
        estableceFechas()
        chkDia.CheckState = CheckState.Checked
        If Not estaCargando Then
            muestraVentas()
        End If
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
    Private Sub optVentasDiarias_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optVentasDiarias.CheckedChanged
        'tab.SelectedTabPage = pagina1
        'If Not estaCargando Then
        '    muestraVentas()
        'End If
    End Sub
    Private Sub optVentasMensuales_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optVentasMensuales.CheckedChanged
        'tab.SelectedTabPage = pagina2
    End Sub
    Function fechaI() As Date
        If Not estaCargando Then
            Dim mfecha As Date
            'mfecha = general.convierteTexto_enFecha(1, cboMes.SelectedIndex + 1, Val(cboAnno.Text))
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
            dtiDesde.MinDate = fechaI()
            dtiDesde.ResetMaxDate()
            dtiDesde.MaxDate = pFechaSystem
            dtiDesde.Value = fechaI()
            dtiHasta.ResetMinDate()
            dtiHasta.MinDate = fechaI()
            dtiHasta.ResetMaxDate()
            dtiHasta.MaxDate = pFechaSystem
            dtiHasta.Value = fechaF()
        Else
            dtiDesde.ResetMinDate()
            dtiDesde.MinDate = pFechaActivaMin
            dtiDesde.ResetMaxDate()
            dtiDesde.MaxDate = pFechaSystem
            dtiDesde.Value = pFechaActivaMin
            dtiHasta.ResetMaxDate()
            dtiHasta.MinDate = pFechaActivaMin
            dtiHasta.ResetMaxDate()
            dtiHasta.MaxDate = pFechaSystem
            dtiHasta.Value = pFechaActivaMax
        End If
    End Sub
    Function periodoSeleccionado()
        Dim periodo As String = Trim(Str(cboAnno.SelectedIndex + 2010)) & Microsoft.VisualBasic.Right("00" & Trim(Str(cboMes.SelectedIndex + 1)), 2)
        Return periodo
    End Function
    Sub muestraVentas()
        Dim mVentas As New eVenta
        Dim periodo As String = periodoSeleccionado()
        Dim eshistorial As Boolean = IIf(periodo >= periodoActivo(), False, True)
        Dim ventasxdia As Boolean = IIf(chkDia.Checked = False, True, False)
        Dim xAlmacen As Boolean = IIf(chkAlmacen.Checked = True, True, False)
        Dim cAlmacen As String = cboAlmacen.SelectedValue
        If optVentasDiarias.Checked = True Then
            dsCantidadVD.Clear()
            dsCantidadVD = mVentas.recuperaVentas(eshistorial, True, xAlmacen, cAlmacen, ventasxdia, dtiDesde.Value, dtiHasta.Value)
            estructuraVentasDiarias()
            cargaVentasDiarias()
        End If
    End Sub
    Sub muestraVentasHoras()
        Dim mVentas As New eVenta
        Dim periodo As String = periodoSeleccionado()
        Dim eshistorial As Boolean = IIf(periodo >= periodoActivo(), False, True)
        Dim ventasxdia As Boolean = IIf(chkDia.Checked = False, True, False)
        Dim xAlmacen As Boolean = IIf(chkAlmacen.Checked = True, True, False)
        Dim flg_valor As Boolean = IIf(optcantidad.Checked = True, True, False)
        Dim cAlmacen As String = cboAlmacen.SelectedValue
        If optVentasDiarias.Checked = True Then
            dsCantidadVF.Clear()
            dsCantidadVF = mVentas.recuperaVentasxhoras(eshistorial, True, xAlmacen, cAlmacen, ventasxdia, dtiDesde.Value, dtiHasta.Value, flg_valor)
            DataDetalle3.DataSource = dsCantidadVF.Tables("articulos").DefaultView
            'estructuraVentasDiarias()
            'cargaVentasDiarias()
        End If

    End Sub
    Sub muestraRanking()
        Dim mVentas As New eVenta
        Dim periodo As String = periodoSeleccionado()
        Dim eshistorial As Boolean = IIf(periodo >= periodoActivo(), False, True)
        Dim ventasxdia As Boolean = IIf(chkDia.Checked = False, True, False)
        Dim xAlmacen As Boolean = IIf(chkAlmacen.Checked = True, True, False)
        Dim flg_ranking As Boolean = IIf(opt_mas.Checked = True, True, False)
        
        Dim cAlmacen As String = cboAlmacen.SelectedValue
        If optVentasDiarias.Checked = True Then
            dsCantidadRan.Clear()
            dsCantidadRan = mVentas.recuperaRanking(eshistorial, True, xAlmacen, cAlmacen, ventasxdia, dtiDesde.Value, dtiHasta.Value, flg_ranking)
            DataDetalle4.DataSource = dsCantidadRan.Tables("articulos").DefaultView
            estructuraRanking()
            'cargaVentasDiarias()
        End If
    End Sub
    Sub GenerarPivotExcel()
        Dim dtDatos As New DataTable() 'Objeto de Tipo DataTable para almacenar los datos a enviar para generar el Excel.
        Dim mventas As New eVenta
        Dim periodo As String = periodoSeleccionado()
        Dim eshistorial As Boolean = IIf(periodo >= periodoActivo(), False, True)
        Dim ventasxdia As Boolean = IIf(chkDia.Checked = False, True, False)
        Dim xAlmacen As Boolean = IIf(chkAlmacen.Checked = True, True, False)
        Dim cAlmacen As String = cboAlmacen.SelectedValue
        dsCantidadVD = mventas.recuperaVentas(eshistorial, False, xAlmacen, cAlmacen, ventasxdia, dtiDesde.Value, dtiHasta.Value)
        dtDatos = dsCantidadVD.Tables("articulos")

        Dim genExcel As New clsGenerarExcel() 'Creamos el Objeto del tipo clsGenerarExcel.

        Dim nomArchivo As String = "" 'Definimos el nombre y la ubicación del archivo.
        Dim titCols As New ArrayList(New String() {"fec_doc", "hora", "mes", "documento", "tip_cliente", "cliente", "Gcompra", "Gventa", "articulo", "precio", "costo", "sucursal", "cantidad", "imp_venta", "imp_costo", "unidad"}) 'Agregamos los títulos de las Columnas en la Hoja de Datos.
        Dim datFilas As New ArrayList(New String() {"cliente", "articulo"}) 'Agregamos los títulos de los datos que irán en la Columna de nuestra Pivot.
        Dim datCols As New ArrayList(New String() {"tip_cliente"}) 'Agregamos los títulos de los datos que irán en la Fila de nuestra Pivot.
        Dim datFiltros As New ArrayList() 'En este caso no definimos filtros, pero podríamos hacerlo según el tipo de Informe, por ejemplo: Fechas.
        Dim datCalc As New ArrayList(New String() {"cantidad", "imp_venta"}) 'Agregamos los títulos de los datos que se Sumarán en nuestra Pivot.

        '' Enviamos los datos para generar el archivo y recibimos la respuesta. ''
        Dim dict As Dictionary(Of clsGenerarExcel.datoResp, Object) = genExcel.GenerarExcel(nomArchivo, dtDatos, _
                                                                                            titCols, datFilas, _
                                                                                            datCols, datFiltros, _
                                                                                            datCalc, clsGenerarExcel.VersionExcel.v14)
        'MessageBox.Show(dict.Item(clsGenerarExcel.datoResp.MSG)) 'Mostramos el mensaje devuelto.
    End Sub
    Sub cargaVentasDiarias()
        Dim I As Integer = 0, X As Integer = 1
        Dim codigo As String = ""
        For I = 0 To dsCantidadVD.Tables("articulos").Rows.Count - 1
            If codigo <> dsCantidadVD.Tables("articulos").Rows(I).Item("cod_art").ToString Then
                codigo = dsCantidadVD.Tables("articulos").Rows(I).Item("cod_art").ToString
                Dim fila As DataRow = dsVentasDiarias.Tables("ventasDiarias").NewRow
                fila.Item("cod_art") = dsCantidadVD.Tables("articulos").Rows(I).Item("cod_art").ToString
                fila.Item("nom_art") = dsCantidadVD.Tables("articulos").Rows(I).Item("nom_art").ToString
                fila.Item("nom_uni") = dsCantidadVD.Tables("articulos").Rows(I).Item("nom_uni").ToString
                For X = 1 To 31
                    If I <= dsCantidadVD.Tables("articulos").Rows.Count - 1 Then
                        If codigo <> dsCantidadVD.Tables("articulos").Rows(I).Item("cod_art").ToString Then
                            codigo = ""
                            I = I - 1
                            Exit For
                        End If
                        Select Case Microsoft.VisualBasic.DateAndTime.Day(dsCantidadVD.Tables("articulos").Rows(I).Item("fec_doc").ToString)
                            Case 1
                                fila.Item("d1") = Val(dsCantidadVD.Tables("articulos").Rows(I).Item("cant").ToString)
                            Case 2
                                fila.Item("d2") = Val(dsCantidadVD.Tables("articulos").Rows(I).Item("cant").ToString)
                            Case 3
                                fila.Item("d3") = Val(dsCantidadVD.Tables("articulos").Rows(I).Item("cant").ToString)
                            Case 4
                                fila.Item("d4") = Val(dsCantidadVD.Tables("articulos").Rows(I).Item("cant").ToString)
                            Case 5
                                fila.Item("d5") = Val(dsCantidadVD.Tables("articulos").Rows(I).Item("cant").ToString)
                            Case 6
                                fila.Item("d6") = Val(dsCantidadVD.Tables("articulos").Rows(I).Item("cant").ToString)
                            Case 7
                                fila.Item("d7") = Val(dsCantidadVD.Tables("articulos").Rows(I).Item("cant").ToString)
                            Case 8
                                fila.Item("d8") = Val(dsCantidadVD.Tables("articulos").Rows(I).Item("cant").ToString)
                            Case 9
                                fila.Item("d9") = Val(dsCantidadVD.Tables("articulos").Rows(I).Item("cant").ToString)
                            Case 10
                                fila.Item("d10") = Val(dsCantidadVD.Tables("articulos").Rows(I).Item("cant").ToString)
                            Case 11
                                fila.Item("d11") = Val(dsCantidadVD.Tables("articulos").Rows(I).Item("cant").ToString)
                            Case 12
                                fila.Item("d12") = Val(dsCantidadVD.Tables("articulos").Rows(I).Item("cant").ToString)
                            Case 13
                                fila.Item("d13") = Val(dsCantidadVD.Tables("articulos").Rows(I).Item("cant").ToString)
                            Case 14
                                fila.Item("d14") = Val(dsCantidadVD.Tables("articulos").Rows(I).Item("cant").ToString)
                            Case 15
                                fila.Item("d15") = Val(dsCantidadVD.Tables("articulos").Rows(I).Item("cant").ToString)
                            Case 16
                                fila.Item("d16") = Val(dsCantidadVD.Tables("articulos").Rows(I).Item("cant").ToString)
                            Case 17
                                fila.Item("d17") = Val(dsCantidadVD.Tables("articulos").Rows(I).Item("cant").ToString)
                            Case 18
                                fila.Item("d18") = Val(dsCantidadVD.Tables("articulos").Rows(I).Item("cant").ToString)
                            Case 19
                                fila.Item("d19") = Val(dsCantidadVD.Tables("articulos").Rows(I).Item("cant").ToString)
                            Case 20
                                fila.Item("d20") = Val(dsCantidadVD.Tables("articulos").Rows(I).Item("cant").ToString)
                            Case 21
                                fila.Item("d21") = Val(dsCantidadVD.Tables("articulos").Rows(I).Item("cant").ToString)
                            Case 22
                                fila.Item("d22") = Val(dsCantidadVD.Tables("articulos").Rows(I).Item("cant").ToString)
                            Case 23
                                fila.Item("d23") = Val(dsCantidadVD.Tables("articulos").Rows(I).Item("cant").ToString)
                            Case 24
                                fila.Item("d24") = Val(dsCantidadVD.Tables("articulos").Rows(I).Item("cant").ToString)
                            Case 25
                                fila.Item("d25") = Val(dsCantidadVD.Tables("articulos").Rows(I).Item("cant").ToString)
                            Case 26
                                fila.Item("d26") = Val(dsCantidadVD.Tables("articulos").Rows(I).Item("cant").ToString)
                            Case 27
                                fila.Item("d27") = Val(dsCantidadVD.Tables("articulos").Rows(I).Item("cant").ToString)
                            Case 28
                                fila.Item("d28") = Val(dsCantidadVD.Tables("articulos").Rows(I).Item("cant").ToString)
                            Case 29
                                fila.Item("d29") = Val(dsCantidadVD.Tables("articulos").Rows(I).Item("cant").ToString)
                            Case 30
                                fila.Item("d30") = Val(dsCantidadVD.Tables("articulos").Rows(I).Item("cant").ToString)
                            Case 31
                                fila.Item("d31") = Val(dsCantidadVD.Tables("articulos").Rows(I).Item("cant").ToString)
                        End Select
                        codigo = dsCantidadVD.Tables("articulos").Rows(I).Item("cod_art").ToString
                        I = I + 1
                    End If
                Next
                dsVentasDiarias.Tables("ventasDiarias").Rows.Add(fila)
            End If
        Next
    End Sub
    Sub estructuraRanking()
        With DataDetalle4
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("articulo").HeaderText = "Descripción"
            .Columns("articulo").Width = 400
            .Columns("articulo").ReadOnly = True
            .Columns("cantidad").HeaderText = "Cantidad"
            .Columns("cantidad").Width = 90
            .Columns("cantidad").ReadOnly = True
        End With

    End Sub
    Sub estructuraVentasDiarias()
        dsVentasDiarias.Clear()
        dsVentasDiarias = eVenta.dsVentasDiarias
        With dataDetalle
            .DataSource = dsVentasDiarias.Tables("ventasDiarias")
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_art").HeaderText = "Código"
            .Columns("cod_art").Width = 55
            .Columns("cod_art").ReadOnly = True
            .Columns("cod_art").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("nom_art").HeaderText = "Descripción"
            .Columns("nom_art").Width = 245
            .Columns("nom_art").ReadOnly = True
            .Columns("nom_uni").HeaderText = "Unidad"
            .Columns("nom_uni").Width = 59
            .Columns("nom_uni").ReadOnly = True
            .Columns("nom_uni").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("d1").Visible = False
            .Columns("d2").Visible = False
            .Columns("d3").Visible = False
            .Columns("d4").Visible = False
            .Columns("d5").Visible = False
            .Columns("d6").Visible = False
            .Columns("d7").Visible = False
            .Columns("d8").Visible = False
            .Columns("d9").Visible = False
            .Columns("d10").Visible = False
            .Columns("d11").Visible = False
            .Columns("d12").Visible = False
            .Columns("d13").Visible = False
            .Columns("d14").Visible = False
            .Columns("d15").Visible = False
            .Columns("d16").Visible = False
            .Columns("d17").Visible = False
            .Columns("d18").Visible = False
            .Columns("d19").Visible = False
            .Columns("d20").Visible = False
            .Columns("d21").Visible = False
            .Columns("d22").Visible = False
            .Columns("d23").Visible = False
            .Columns("d24").Visible = False
            .Columns("d25").Visible = False
            .Columns("d26").Visible = False
            .Columns("d27").Visible = False
            .Columns("d28").Visible = False
            .Columns("d29").Visible = False
            .Columns("d30").Visible = False
            .Columns("d31").Visible = False
            .Columns("promedio").Visible = False
            .Columns("fec_doc").Visible = False
        End With
        With dataDetalle2
            .DataSource = dsVentasDiarias.Tables("ventasDiarias")
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("d1").HeaderText = "D1"
            .Columns("d1").Width = 30
            .Columns("d1").ReadOnly = False
            .Columns("d1").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("d2").HeaderText = "D2"
            .Columns("d2").Width = 30
            .Columns("d2").ReadOnly = False
            .Columns("d2").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("d3").HeaderText = "D3"
            .Columns("d3").Width = 30
            .Columns("d3").ReadOnly = False
            .Columns("d3").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("d4").HeaderText = "D4"
            .Columns("d4").Width = 30
            .Columns("d4").ReadOnly = False
            .Columns("d4").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("d5").HeaderText = "D5"
            .Columns("d5").Width = 30
            .Columns("d5").ReadOnly = False
            .Columns("d5").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("d6").HeaderText = "D6"
            .Columns("d6").Width = 30
            .Columns("d6").ReadOnly = False
            .Columns("d6").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("d7").HeaderText = "D7"
            .Columns("d7").Width = 30
            .Columns("d7").ReadOnly = False
            .Columns("d7").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("d8").HeaderText = "D8"
            .Columns("d8").Width = 30
            .Columns("d8").ReadOnly = False
            .Columns("d8").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("d9").HeaderText = "D9"
            .Columns("d9").Width = 30
            .Columns("d9").ReadOnly = False
            .Columns("d9").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("d10").HeaderText = "D10"
            .Columns("d10").Width = 30
            .Columns("d10").ReadOnly = False
            .Columns("d10").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("d11").HeaderText = "D11"
            .Columns("d11").Width = 30
            .Columns("d11").ReadOnly = False
            .Columns("d11").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("d12").HeaderText = "D12"
            .Columns("d12").Width = 30
            .Columns("d12").ReadOnly = False
            .Columns("d12").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("d13").HeaderText = "D13"
            .Columns("d13").Width = 30
            .Columns("d13").ReadOnly = False
            .Columns("d13").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("d14").HeaderText = "D14"
            .Columns("d14").Width = 30
            .Columns("d14").ReadOnly = False
            .Columns("d14").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("d15").HeaderText = "D15"
            .Columns("d15").Width = 30
            .Columns("d15").ReadOnly = False
            .Columns("d15").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("d16").HeaderText = "D16"
            .Columns("d16").Width = 30
            .Columns("d16").ReadOnly = False
            .Columns("d16").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("d17").HeaderText = "D17"
            .Columns("d17").Width = 30
            .Columns("d17").ReadOnly = False
            .Columns("d17").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("d18").HeaderText = "D18"
            .Columns("d18").Width = 30
            .Columns("d18").ReadOnly = False
            .Columns("d18").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("d19").HeaderText = "D19"
            .Columns("d19").Width = 30
            .Columns("d19").ReadOnly = False
            .Columns("d19").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("d20").HeaderText = "D20"
            .Columns("d20").Width = 30
            .Columns("d20").ReadOnly = False
            .Columns("d20").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("d21").HeaderText = "D21"
            .Columns("d21").Width = 30
            .Columns("d21").ReadOnly = False
            .Columns("d21").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("d22").HeaderText = "D22"
            .Columns("d22").Width = 30
            .Columns("d22").ReadOnly = False
            .Columns("d22").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("d23").HeaderText = "D23"
            .Columns("d23").Width = 30
            .Columns("d23").ReadOnly = False
            .Columns("d23").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("d24").HeaderText = "D24"
            .Columns("d24").Width = 30
            .Columns("d24").ReadOnly = False
            .Columns("d24").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("d25").HeaderText = "D25"
            .Columns("d25").Width = 30
            .Columns("d25").ReadOnly = False
            .Columns("d25").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("d26").HeaderText = "D26"
            .Columns("d26").Width = 30
            .Columns("d26").ReadOnly = False
            .Columns("d26").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("d27").HeaderText = "D27"
            .Columns("d27").Width = 30
            .Columns("d27").ReadOnly = False
            .Columns("d27").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("d28").HeaderText = "D28"
            .Columns("d28").Width = 30
            .Columns("d28").ReadOnly = False
            .Columns("d28").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("d29").HeaderText = "D29"
            .Columns("d29").Width = 30
            .Columns("d29").ReadOnly = False
            .Columns("d29").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("d30").HeaderText = "D30"
            .Columns("d30").Width = 30
            .Columns("d30").ReadOnly = False
            .Columns("d30").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("d31").HeaderText = "D31"
            .Columns("d31").Width = 30
            .Columns("d31").ReadOnly = False
            .Columns("d31").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("cod_art").Visible = False
            .Columns("nom_art").Visible = False
            .Columns("nom_uni").Visible = False
            .Columns("promedio").Visible = False
            .Columns("fec_doc").Visible = False
        End With
    End Sub
    Private Sub cmdCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCerrar.Click
        Me.Close()
    End Sub



    Private Sub dataDetalle2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If (e.Control And e.KeyCode = Keys.E) Then
            If dataDetalle2.RowCount > 0 Then
                GenerarPivotExcel()
            End If
        End If
    End Sub


    Private Sub dtiDesde_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtiDesde.Click

    End Sub

    Private Sub dataDetalle2_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub dtiHasta_Click(sender As System.Object, e As System.EventArgs) Handles dtiHasta.Click

    End Sub

    Private Sub chkAlmacen_CheckedChanged(sender As Object, e As EventArgs) Handles chkAlmacen.CheckedChanged
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

    Private Sub cboAlmacen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAlmacen.SelectedIndexChanged
        If Not estaCargando Then
            muestraVentas()
            muestraVentasHoras()
            muestraRanking()
        End If
    End Sub


    Private Sub dataDetalle2_KeyDown1(sender As Object, e As KeyEventArgs) Handles dataDetalle2.KeyDown
        If (e.Control And e.KeyCode = Keys.E) Then
            If dataDetalle2.RowCount > 0 Then
                GenerarPivotExcel()
            End If
        End If
    End Sub


    Private Sub cmdProcesar_Click(sender As Object, e As EventArgs) Handles cmdProcesar.Click
        If TabControl1.SelectedIndex = 0 Then
            muestraVentas()
        ElseIf TabControl1.SelectedIndex = 1 Then
            muestraVentasHoras()
        Else
            muestraRanking()
        End If
    End Sub

    Private Sub DataDetalle3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataDetalle3.CellContentClick

    End Sub

    Private Sub DataDetalle3_KeyDown(sender As Object, e As KeyEventArgs) Handles DataDetalle3.KeyDown
        If (e.Control And e.KeyCode = Keys.E) Then
            If DataDetalle3.RowCount > 0 Then
                EnviaraExcel(DataDetalle3)
            End If
        End If
    End Sub

    Private Sub DataDetalle4_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataDetalle4.CellContentClick

    End Sub

    Private Sub DataDetalle4_KeyDown(sender As Object, e As KeyEventArgs) Handles DataDetalle4.KeyDown
        If (e.Control And e.KeyCode = Keys.E) Then
            If DataDetalle4.RowCount > 0 Then
                EnviaraExcel(DataDetalle4)
            End If
        End If
    End Sub
End Class
