Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Math
Imports libreriaClases
Public Class u_importaMicros
    Private dsVentas As DataSet
    Private dsReceta, dsReceta1, dsReceta2, dsReceta3 As New DataSet
    Private dsAlmacen As New DataSet
    Private pcod_alma As String
    Private estaCargando As Boolean = True
    'para validar el separador decimal
    Private sepDecimal As Char

    Private Sub u_importaMicros_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        principal.mu_procventas.Enabled = True
    End Sub
    Private Sub u_importaMicros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'capturamos el separador decimal
        sepDecimal = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        Me.Left = 0
        Me.Top = 0
        dtiDesde.Value = pFechaSystem
        dtiHasta.Value = pFechaSystem
        'dataset almacen
        Dim daAlmacen As New MySqlDataAdapter
        Dim cadAlma As String
        If pAlmaUser = "0000" Then
            cadAlma = "select cod_alma,nom_alma from almacen where (esProduccion) and activo=1"
        Else
            cadAlma = "select cod_alma,nom_alma from almacen where cod_alma='" & pAlmaUser & "' and (esProduccion) and activo=1"
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
        muestraVentas()
        estableceFechas()
        estaCargando = False
    End Sub
    Sub estableceFechas()
        dtiDesde.ResetMinDate()
        'dtiDesde.MinDate = pFechaActivaMin
        dtiDesde.Value = pFechaSystem
        dtiDesde.ResetMaxDate()
        'dtiDesde.MaxDate = pFechaSystem
        dtiDesde.Value = pFechaSystem

        dtiHasta.ResetMinDate()
        'dtiHasta.MinDate = pFechaActivaMin
        dtiHasta.Value = pFechaSystem
        dtiHasta.ResetMaxDate()
        'dtiHasta.MaxDate = pFechaActivaMax
        dtiHasta.Value = pFechaSystem


    End Sub
    Sub verificaImportacion()
        Dim mMicros As New micros
        Dim existe As Boolean = mMicros.existeActualizacionStockMicros(dtiDesde.Value, cboAlmacen.SelectedValue)
        If existe Then
            cmdActualizarStock.Enabled = False
        Else
            cmdActualizarStock.Enabled = True
        End If
    End Sub
    Private Sub dtiFecha_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        If Not estaCargando Then
            muestraVentas()
            'verificaImportacion()
        End If
    End Sub
    Private Sub cboAlmacen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not estaCargando Then
            muestraVentas()
            'verificaImportacion()
            txtBuscarVenta.Focus()
        End If
    End Sub
    Sub muestraVentas()
        Dim cAlmacen As String = cboAlmacen.SelectedValue
        Dim xalmacen As Boolean = IIf(pCatalogoXalmacen, True, False)
        Dim periodo As String = general.convierteFechaEspecificadaMes(dtiDesde.Value)
        Dim esHistorial As Boolean = IIf(periodo >= periodoActivo(), False, True)
        Dim recalcular As Integer = IIf(chkRecalcular.Checked, 1, 0)
        Dim tiproc As String
        'establecemos las propiedades del BindingSource
        Dim mMicros As New micros
        Dim mAlmacen As New Almacen
        Select Case mAlmacen.devuelveTipoProceso(cAlmacen)
            Case "04"
                tiproc = "04"
                xalmacen = False
            Case "03"
                tiproc = "03"
                xalmacen = False
            Case "02"
                tiproc = "02"
                xalmacen = False
            Case Else
                tiproc = "01"
        End Select

        'Select Case cAlmacen
        '    Case "0099"
        '        tiproc = "04"
        '        xalmacen = False
        '    Case "0021"
        '        tiproc = "03"
        '        xalmacen = False
        '    Case "0012" 'eventos
        '        tiproc = "02"
        '        xalmacen = False
        '    Case Else
        '        tiproc = "01"
        'End Select
        'tiproc = "02"
        dsVentas = mMicros.recuperaVentas(esHistorial, tiproc, dtiDesde.Value, dtiHasta.Value, xalmacen, cAlmacen, recalcular, False)

        dataVentas.DataSource = dsVentas.Tables("ventas").DefaultView
        estructuraVentas()
        'lblRegistros.Text = "Nº de Registros..." & dataProduccion.RowCount
    End Sub
    Sub estructuraVentas()
        With dataVentas
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("fecha").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("fecha").DisplayIndex = 0
            .Columns("fecha").HeaderText = "Fecha"
            .Columns("fecha").Width = 72
            .Columns("fecha").ReadOnly = True
            .Columns("cod_micros").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_micros").DisplayIndex = 1
            .Columns("cod_micros").HeaderText = "Codigo Venta"
            .Columns("cod_micros").Width = 50
            .Columns("cod_micros").ReadOnly = True
            .Columns("nombre").DisplayIndex = 2
            .Columns("nombre").HeaderText = "Descripción "
            .Columns("nombre").Width = 200
            .Columns("nombre").ReadOnly = True
            .Columns("cod_art").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_art").DisplayIndex = 3
            .Columns("cod_art").HeaderText = "Código Receta"
            .Columns("cod_art").Width = 50
            .Columns("cod_art").ReadOnly = True
            .Columns("nom_art").DisplayIndex = 4
            .Columns("nom_art").HeaderText = "Descripción"
            .Columns("nom_art").Width = 222
            .Columns("nom_art").ReadOnly = True
            .Columns("nom_uni").DisplayIndex = 5
            .Columns("nom_uni").HeaderText = "Unidad"
            .Columns("nom_uni").Width = 70
            .Columns("nom_uni").ReadOnly = True
            .Columns("canti").DisplayIndex = 6
            .Columns("canti").HeaderText = "Cant."
            .Columns("canti").Width = 50
            .Columns("canti").ReadOnly = True
            .Columns("canti").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("pre_ven").DisplayIndex = 7
            .Columns("pre_ven").HeaderText = "Precio Venta"
            .Columns("pre_ven").Width = 70
            .Columns("pre_ven").ReadOnly = True
            .Columns("pre_ven").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("dcto").DisplayIndex = 8
            .Columns("cod_alma").HeaderText = "Almacen"
            .Columns("cod_alma").Width = 56
            .Columns("cod_alma").ReadOnly = True
            .Columns("cod_alma").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("factor_prod").HeaderText = "Factor Prod"
            .Columns("factor_prod").Width = 40
            .Columns("factor_prod").ReadOnly = False
            .Columns("factor_prod").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns("pre_inc_imp").Visible = False
            .Columns("dcto").Visible = False
            .Columns("operacion").Visible = False
            .Columns("tip_proceso").Visible = False
            .Columns("AreaProd").Visible = False

        End With
    End Sub
    Private Sub txtBuscarVenta_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscarVenta.GotFocus
        If Not estaCargando Then
            txtBuscarVenta.SelectAll()
        End If
    End Sub
    Private Sub txtBuscarventa_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscarVenta.KeyPress
        If e.KeyChar = ChrW(13) Then
            dataVentas.Focus()
        End If
    End Sub
    Private Sub txtBuscarventa_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscarVenta.TextChanged
        If Not estaCargando Then
            dsVentas.Tables("ventas").DefaultView.RowFilter = "nombre LIKE '" & txtBuscarVenta.Text & "%'"
            If dataVentas.RowCount > 0 Then
                dataVentas.CurrentCell = dataVentas("cod_art", dataVentas.CurrentRow.Index)
            End If
        End If
    End Sub
    Private Sub dataventas_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dataVentas.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If
        If (e.Control And e.KeyCode = Keys.E) Then
            EnviaraExcel(dataVentas)
        End If
    End Sub
    Sub muestraReceta(ByVal cod_rec As String, ByVal nro As Integer)
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim da As New MySqlDataAdapter
        Dim cad, cad1, cad2, cad3, cad4 As String
        cad1 = " select cod_rec,receta.cod_art,nom_art,nom_uni,cant_uni,cant"
        cad2 = " from receta inner join articulo on receta.cod_art=articulo.cod_art"
        cad3 = " inner join unidad on articulo.cod_uni=unidad.cod_uni"
        cad4 = " where cod_rec='" & cod_rec & "' order by nom_art"
        cad = cad1 + cad2 + cad3 + cad4
        Dim comReceta As New MySqlCommand(cad)
        comReceta.Connection = clConex
        da.SelectCommand = comReceta
        If nro = 0 Then
            da.Fill(dsReceta, "receta")
        End If
        If nro = 1 Then
            da.Fill(dsReceta1, "receta")
        End If
        If nro = 2 Then
            da.Fill(dsReceta2, "receta")
        End If
        If nro = 3 Then
            da.Fill(dsReceta3, "receta")
        End If
        clConex.Close()
    End Sub
    Private Sub dataVentas_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dataVentas.SelectionChanged
        If Not estaCargando Then
            If dataVentas.RowCount > 0 Then
                dsReceta.Clear()
                dsReceta1.Clear()
                dsReceta2.Clear()
                dsReceta3.Clear()
                muestraReceta(IIf(IsDBNull(dataVentas("cod_art", dataVentas.CurrentRow.Index).Value), "", dataVentas("cod_art", dataVentas.CurrentRow.Index).Value), 0)
                dataReceta.DataSource = dsReceta.Tables("receta").DefaultView
                cargaEstructuraReceta()
            End If
        End If
    End Sub
    Private Sub dataReceta_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dataReceta.SelectionChanged
        If Not estaCargando Then
            If dataReceta.RowCount > 0 Then
                dsReceta1.Clear()
                dsReceta2.Clear()
                dsReceta3.Clear()
                muestraReceta(IIf(IsDBNull(dataReceta("cod_art", dataReceta.CurrentRow.Index).Value), "", dataReceta("cod_art", dataReceta.CurrentRow.Index).Value), 1)
                dataReceta1.DataSource = dsReceta1.Tables("receta").DefaultView
                cargaEstructuraReceta1()
            End If
        End If
    End Sub
    Private Sub dataReceta1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dataReceta1.SelectionChanged
        If Not estaCargando Then
            If dataReceta1.RowCount > 0 Then
                dsReceta2.Clear()
                dsReceta3.Clear()
                muestraReceta(IIf(IsDBNull(dataReceta1("cod_art", dataReceta1.CurrentRow.Index).Value), "", dataReceta1("cod_art", dataReceta1.CurrentRow.Index).Value), 2)
                dataReceta2.DataSource = dsReceta2.Tables("receta").DefaultView
                cargaEstructuraReceta2()
            End If
        End If
    End Sub
    Private Sub dataReceta2_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dataReceta2.SelectionChanged
        If Not estaCargando Then
            If dataReceta2.RowCount > 0 Then
                dsReceta3.Clear()
                muestraReceta(IIf(IsDBNull(dataReceta2("cod_art", dataReceta2.CurrentRow.Index).Value), "", dataReceta2("cod_art", dataReceta2.CurrentRow.Index).Value), 3)
                dataReceta3.DataSource = dsReceta3.Tables("receta").DefaultView
                cargaEstructuraReceta3()
            End If
        End If
    End Sub
    Sub cargaEstructuraReceta()
        With dataReceta
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_art").HeaderText = "Codigo"
            .Columns("cod_art").Width = 50
            .Columns("cod_art").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("nom_art").HeaderText = "Descripcion"
            .Columns("nom_art").Width = 250
            .Columns("nom_uni").HeaderText = "Unidad"
            .Columns("nom_uni").Width = 65
            .Columns("cant").HeaderText = "Cant."
            .Columns("cant").Width = 45
            .Columns("cant").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("cod_rec").Visible = False
            .Columns("cant_uni").Visible = False
        End With
    End Sub
    Sub cargaEstructuraReceta1()
        With dataReceta1
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_art").HeaderText = "Codigo"
            .Columns("cod_art").Width = 50
            .Columns("cod_art").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("nom_art").HeaderText = "Descripcion"
            .Columns("nom_art").Width = 250
            .Columns("nom_uni").HeaderText = "Unidad"
            .Columns("nom_uni").Width = 65
            .Columns("cant").HeaderText = "Cant."
            .Columns("cant").Width = 45
            .Columns("cant").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("cod_rec").Visible = False
            .Columns("cant_uni").Visible = False
        End With
    End Sub
    Sub cargaEstructuraReceta2()
        With dataReceta2
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_art").HeaderText = "Codigo"
            .Columns("cod_art").Width = 50
            .Columns("cod_art").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("nom_art").HeaderText = "Descripcion"
            .Columns("nom_art").Width = 250
            .Columns("nom_uni").HeaderText = "Unidad"
            .Columns("nom_uni").Width = 65
            .Columns("cant").HeaderText = "Cant."
            .Columns("cant").Width = 45
            .Columns("cant").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("cod_rec").Visible = False
            .Columns("cant_uni").Visible = False
        End With
    End Sub
    Sub cargaEstructuraReceta3()
        With dataReceta3
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_art").HeaderText = "Codigo"
            .Columns("cod_art").Width = 50
            .Columns("cod_art").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("nom_art").HeaderText = "Descripcion"
            .Columns("nom_art").Width = 250
            .Columns("nom_uni").HeaderText = "Unidad"
            .Columns("nom_uni").Width = 65
            .Columns("cant").HeaderText = "Cant."
            .Columns("cant").Width = 45
            .Columns("cant").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("cod_rec").Visible = False
            .Columns("cant_uni").Visible = False
        End With
    End Sub
    Function recuperaStock(ByVal cod_art As String) As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim ds As New DataSet
        Dim cad As String
        cad = "select * from ingreso_det where cod_art='" & cod_art & "' order by ingreso"
        Dim da As New MySqlDataAdapter
        Dim com As New MySqlCommand(cad)
        com.Connection = clConex
        da.SelectCommand = com
        da.Fill(ds, "saldo")
        clConex.Close()
        Return ds
    End Function
    Sub actualizaCostoInsumos()
        Dim M, I, W, X, Y As Integer
        Dim mUtil As New Utilidades, mPrecio As New ePrecio, mReceta As New Receta
        Dim codR, codR1, codR2, codR3 As String
        Dim costoR, costoR1, costoR2, costoR3 As Decimal
        Dim codigo As String
        If dataVentas.RowCount > 0 Then

            For M = 0 To dsVentas.Tables("ventas").Rows.Count - 1
            
                If Len(dsVentas.Tables("ventas").Rows(M).Item("cod_art").ToString) = 0 Then
                Else
                    codigo = dsVentas.Tables("ventas").Rows(M).Item("cod_art").ToString
                    'costo = dsProducciones.Tables("articulo").Rows(M).Item("cod_art").ToString
                    dsReceta.Clear()
                    muestraReceta(codigo, 0)
                    If dsReceta.Tables("receta").Rows.Count > 0 Then '7
                        For I = 0 To dsReceta.Tables("receta").Rows.Count - 1
                            codR = dsReceta.Tables("receta").Rows(I).Item("cod_art").ToString
                            costoR = mPrecio.devuelvePrecioCosto(codR)
                            dsReceta1.Clear()
                            muestraReceta(codR, 1)
                            If dsReceta1.Tables("receta").Rows.Count > 0 Then
                                For W = 0 To dsReceta1.Tables("receta").Rows.Count - 1
                                    codR1 = dsReceta1.Tables("receta").Rows(W).Item("cod_art").ToString
                                    costoR1 = mPrecio.devuelvePrecioCosto(codR1)
                                    dsReceta2.Clear()
                                    muestraReceta(codR1, 2)
                                    If dsReceta2.Tables("receta").Rows.Count > 0 Then
                                        For X = 0 To dsReceta2.Tables("receta").Rows.Count - 1
                                            codR2 = dsReceta2.Tables("receta").Rows(X).Item("cod_art").ToString
                                            costoR2 = mPrecio.devuelvePrecioCosto(codR2)
                                            dsReceta3.Clear()
                                            muestraReceta(codR2, 3)
                                            If dsReceta3.Tables("receta").Rows.Count > 0 Then
                                                For Y = 0 To dsReceta3.Tables("receta").Rows.Count - 1
                                                    codR3 = dsReceta3.Tables("receta").Rows(Y).Item("cant_uni").ToString
                                                    costoR3 = mPrecio.devuelvePrecioCosto(codR3)
                                                    mReceta.actualizaCostoInsumo_enReceta(codR2, codR3, costoR3)
                                                Next
                                            Else
                                                mReceta.actualizaCostoInsumo_enReceta(codR1, codR2, costoR2)
                                            End If
                                        Next
                                    Else
                                        mReceta.actualizaCostoInsumo_enReceta(codR, codR1, costoR1)
                                    End If
                                Next
                            Else
                                mReceta.actualizaCostoInsumo_enReceta(codigo, codR, costoR)
                            End If
                        Next
                    End If
                End If
            Next
            MessageBox.Show("Proceso Finalizado")
        End If
    End Sub
    Private Sub cmdActualizarStock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdActualizarStock.Click
        Dim M, I, W, X, Y As Integer
        dim num As Integer = CInt(cboAlmacen.SelectedValue) 
        Dim mSalida As New Salida, mCatalogo As New Catalogo, mIngreso As New Ingreso, mUtil As New Utilidades, mMicros As New micros, mprecio As New ePrecio, cFecha As Date
        Dim codigo, nombre As String
        Dim operacion, operacionS, operacionI, nDia, ningreso As Integer
        Dim codR, codR1, codR2, codR3, cod_doc, cod_area As String
        Dim cantR, cantR1, cantR2, cantR3, cantImp As Decimal
        Dim cantRT, cantRT1, cantRT2, cantRT3, ncosto, factor_prod As Decimal
        Dim num_documento, tiproc As String
        Dim periodo As String = general.convierteFechaEspecificadaMes(dtiDesde.Value)
        Dim esHistorial As Boolean = IIf(periodo >= periodoActivo(), False, True)
        Dim procesar As Boolean = False
        Dim cod_alma As String = cboAlmacen.SelectedValue
        'Select Case cod_alma
        '    Case "0099"
        '        tiproc = "03"
        '    Case "0021"
        '        tiproc = "03"
        '    Case "0012"
        '        tiproc = "02"
        '    Case Else
        '        tiproc = "01"
        'End Select
        Dim mAlmacen As New Almacen
        Select Case mAlmacen.devuelveTipoProceso(cod_alma)
            Case "03"
                tiproc = "03"
            Case "02"
                tiproc = "02"
            Case Else
                tiproc = "01"
        End Select

        If chkprocesar.Checked = True Then
            Dim rpta As Integer = MessageBox.Show("Esta Seguro de Procesar sin Stock" + Chr(13) + "Este Proceso es Irreversible...", "SGA", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2)
            If rpta = 6 Then
                procesar = IIf(chkprocesar.Checked, True, False)
            End If
        End If
        'Try
        If dataVentas.RowCount > 0 Then
            nDia = Microsoft.VisualBasic.Day(cFecha)
            For M = 0 To dataVentas.RowCount - 1
                cmdActualizarStock.Text = M + 1 & " de " & dataVentas.RowCount
                cmdActualizarStock.Refresh()
                If Len(dataVentas.Item("cod_Art", M).Value.ToString) = 0 Then '8
                Else
                    operacion = dataVentas.Item("operacion", M).Value
                    If chkRecalcular.Checked = True Then
                        mSalida.eliminaProcesoVentas(operacion)
                    End If
                    codigo = dataVentas.Item("cod_art", M).Value
                    nombre = dataVentas.Item("nombre", M).Value
                    cFecha = dataVentas.Item("fecha", M).Value
                    cantImp = dataVentas.Item("canti", M).Value
                    pcod_alma = dataVentas.Item("cod_alma", M).Value
                    pcod_alma = IIf(pcod_alma = "", cboAlmacen.SelectedValue, pcod_alma)
                    cod_doc = IIf(dataVentas.Item("tip_proceso", M).Value = "0", "93", "04")
                    factor_prod = dataVentas("factor_prod", M).Value
                    cod_area = dataVentas.Item("areaprod", M).Value.ToString
                    cod_area = IIf(cod_area = "", "0000", cod_area)

                    dsReceta.Clear()
                    muestraReceta(codigo, 0)
                    If dsReceta.Tables("receta").Rows.Count > 0 And validarstock(cantImp, procesar, nombre) Then '7
                        operacionI = 0
                        operacionS = 0
                        If cantImp >= 0 Then
                            operacionS = IIf(esHistorial, mSalida.maxOperacion_his(periodo), mSalida.maxOperacion) + num
                            num_documento = mSalida.maxNroSalida(cod_doc, "000")
                            mSalida.insertar_aux_his(esHistorial, periodo, operacionS, 0, cod_doc, "000", num_documento, cFecha, "00000000", "00000000000", "00", 1, 0, pDecimales, pcod_alma, cod_area, nombre, "00", pCuentaUser, 0, "", operacion)
                        Else
                            operacionI = IIf(esHistorial, mIngreso.maxOperacion_his(periodo), mIngreso.maxOperacion) + num
                            num_documento = mIngreso.maxNotaIngreso(cod_doc, "000")
                            mIngreso.insertar_aux_his(esHistorial, periodo, operacionI, cod_doc, "000", num_documento, "000", "00000000", cFecha, "00000000000", "00", pcod_alma, cod_area, True, False, pDecimales, nombre, "S", pTC, pCuentaUser)
                        End If
                        For I = 0 To dsReceta.Tables("receta").Rows.Count - 1 '6
                            codR = dsReceta.Tables("receta").Rows(I).Item("cod_art").ToString
                            cantR = dsReceta.Tables("receta").Rows(I).Item("cant").ToString * factor_prod
                            cantRT = cantR * cantImp
                            Dim procesarD As Boolean = mCatalogo.devuelveTipoArt(codR)
                            dsReceta1.Clear()
                            muestraReceta(codR, 1)
                            If dsReceta1.Tables("receta").Rows.Count > 0 And procesarD Then '5
                                For W = 0 To dsReceta1.Tables("receta").Rows.Count - 1 '4
                                    codR1 = dsReceta1.Tables("receta").Rows(W).Item("cod_art").ToString
                                    cantR1 = dsReceta1.Tables("receta").Rows(W).Item("cant").ToString * factor_prod
                                    cantRT1 = cantR1 * cantRT
                                    procesarD = mCatalogo.devuelveTipoArt(codR1)
                                    dsReceta2.Clear()
                                    muestraReceta(codR1, 2)
                                    If dsReceta2.Tables("receta").Rows.Count > 0 And procesarD Then '3
                                        For X = 0 To dsReceta2.Tables("receta").Rows.Count - 1 '2
                                            codR2 = dsReceta2.Tables("receta").Rows(X).Item("cod_art").ToString
                                            cantR2 = dsReceta2.Tables("receta").Rows(X).Item("cant").ToString * factor_prod
                                            cantRT2 = cantR2 * cantRT1
                                            procesarD = mCatalogo.devuelveTipoArt(codR2)
                                            dsReceta3.Clear()
                                            muestraReceta(codR2, 3)
                                            If dsReceta3.Tables("receta").Rows.Count > 0 And procesarD Then '1
                                                For Y = 0 To dsReceta3.Tables("receta").Rows.Count - 1
                                                    codR3 = dsReceta3.Tables("receta").Rows(Y).Item("cod_art").ToString
                                                    cantR3 = dsReceta3.Tables("receta").Rows(Y).Item("cant").ToString * factor_prod
                                                    cantRT3 = cantR3 * cantRT2
                                                    insertaInsumo(esHistorial, periodo, codR3, cantRT3, operacionS, operacionI)
                                                Next

                                            Else '1
                                                insertaInsumo(esHistorial, periodo, codR2, cantRT2, operacionS, operacionI)
                                            End If '1
                                        Next '2
                                    Else '3
                                        insertaInsumo(esHistorial, periodo, codR1, cantRT1, operacionS, operacionI)
                                    End If '3
                                Next '4
                            Else
                                insertaInsumo(esHistorial, periodo, codR, cantRT, operacionS, operacionI)
                            End If '5
                        Next '6
                        If cod_doc = "93" Then
                            operacionI = IIf(esHistorial, mIngreso.maxOperacion_his(periodo), mIngreso.maxOperacion) + num
                            ningreso = IIf(esHistorial, mIngreso.maxIngreso_his(periodo), mIngreso.maxIngreso)
                            ncosto = mprecio.devuelvePrecioCosto(codigo)
                            mIngreso.insertar_aux_his(esHistorial, periodo, operacionI, cod_doc, "000001", num_documento, "000", "00000000", cFecha, "00000000000", "01", pcod_alma, cod_area, True, False, pDecimales, "Produccion", "S", pTC, pCuentaUser)
                            mIngreso.insertar_det_his(esHistorial, periodo, operacionI, ningreso, codigo, cantImp, ncosto, pIGV)
                        End If
                        mMicros.ActualizaProcesoVentas(tiproc, operacion, codigo)
                    End If '7
                End If '8
            Next
        End If
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
        muestraVentas()
        MessageBox.Show("Proceso Finalizado")
        cmdActualizarStock.Text = "Procesar Ventas"
    End Sub
    Sub insertaInsumo(ByVal eshistorial As Boolean, ByVal periodo As String, ByVal cod_art As String, ByVal cantidad As Decimal, ByVal OpeSalida As Integer, ByVal OpeIngreso As Integer)
        'recuperamos los lotes del producto a transformar
        'y descargamos las salidas correspondientes
        Dim mSalida As New Salida, mIngreso As New Ingreso, mprecio As New ePrecio
        Dim nSalida, nIngreso As Integer
        Dim nCosto As Decimal
        nCosto = mprecio.devuelvePrecioCosto(cod_art)
        If OpeSalida > 0 Then
            nSalida = IIf(eshistorial, mSalida.maxSalida_his(periodo), mSalida.maxSalida)
            mSalida.insertar_det_his(eshistorial, periodo, OpeSalida, nSalida, OpeIngreso, cod_art, cantidad, nCosto, 0, 0, 0)
        Else
            cantidad = Math.Abs(cantidad)
            nIngreso = IIf(eshistorial, mIngreso.maxIngreso_his(periodo), mIngreso.maxIngreso)
            mIngreso.insertar_det_his(eshistorial, periodo, OpeIngreso, nIngreso, cod_art, cantidad, nCosto, pIGV)
        End If
    End Sub

    Function validarstock(ByVal cantidad As Decimal, ByVal procesar As Boolean, ByVal nombre As String) As Boolean
        Dim i As Integer, cod_art, nom_art As String, nCantidad, nstock As Decimal
        Dim result As Boolean = True
        Dim mcatalogo As New Catalogo
        Dim cantProducir As Decimal = cantidad
        For i = 0 To dsReceta.Tables("receta").Rows.Count - 1
            cod_art = dsReceta.Tables("receta").Rows(i).Item("cod_art").ToString
            nom_art = dsReceta.Tables("receta").Rows(i).Item("nom_art").ToString
            nCantidad = dsReceta.Tables("receta").Rows(i).Item("cant").ToString
            nstock = mcatalogo.devuelveStock(cod_art)
            If Not (procesar) Then
                procesar = mcatalogo.devuelveTipoArt(cod_art) Or mcatalogo.devuelveEsGasto(cod_art)
                If Not (procesar) Then
                    If nstock < cantProducir * nCantidad Then
                        If chkAlerta.Checked Then
                            MessageBox.Show("Produccion no Realizada..." + Chr(13) + "Verifique su stock..." & nom_art & " de Receta..." & nombre, "CEFE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                        result = False
                    End If
                End If
            End If
        Next
        Return result
    End Function


    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        u_importaVentas_dbf.MdiParent = principal
        u_importaVentas_dbf.Show()
    End Sub


    Private Sub cboAlmacen_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboAlmacen.SelectedValueChanged
        If Not estaCargando Then
            muestraVentas()
        End If
    End Sub


    Private Sub dtiHasta_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtiHasta.ValueChanged
        If Not estaCargando And dtiDesde.Value <= dtiHasta.Value Then
            muestraVentas()
        End If
    End Sub

    Private Sub dtiDesde_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtiDesde.ValueChanged
        If Not estaCargando And dtiDesde.Value <= dtiHasta.Value Then
            muestraVentas()
        End If
    End Sub


    Private Sub cboAlmacen_SelectedIndexChanged_1(sender As System.Object, e As System.EventArgs) Handles cboAlmacen.SelectedIndexChanged

    End Sub

    Private Sub dtiDesde_Click(sender As System.Object, e As System.EventArgs) Handles dtiDesde.Click

    End Sub

    Private Sub dtiHasta_Click(sender As Object, e As EventArgs) Handles dtiHasta.Click

    End Sub
End Class
