Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Math
Imports libreriaClases
Imports System
Public Class e_precios
    Private dsPrecio, dsPrecio2 As New DataSet
    Private dsMargenAnual As New DataSet, dsMargenAnualTemp As New DataSet
    Private dsFluctuacion As New DataSet
    Private dsFluctuacion2 As New DataSet
    Private dsProducciones As New DataSet
    Private dsPrecioProm As New DataSet
    Private dsAlmacen As New DataSet
    Private dsGrupo As New DataSet
    Private dsCuenta As New DataSet
    Private dsCompras As New DataSet
    'dsProducciones = ePrecio.dsCostosProduccion
    Private dsMargenes As New DataSet
    '
    Private cPrecioSIs As String = general.str_PrecioCompraSIs
    Private chPrecioSIs As String = general.str_hPrecioCompraSIs
    Private estaCargando As Boolean = True
    Private Sub e_precios_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If tabFluctuacion.IsSelected Then
            colorearSobrePrecio()
        End If
        If tabFluctuacion2.IsSelected Then
            colorearSobrePrecio2()
        End If
    End Sub
    Private Sub e_precios_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        principal.me_precios.Enabled = True
    End Sub
    Private Sub e_precios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Top = 0
        Me.Left = 0
        dtiDesde.MaxDate = pFechaActivaMax
        dtiDesde.MinDate = pFechaActivaMin
        dtiHasta.MaxDate = pFechaActivaMax
        dtiHasta.MinDate = pFechaActivaMin
        estableceFechas()
        Dim mes, anno As Integer
        mes = Month(pFechaActivaMax)
        anno = Year(pFechaActivaMax)
        cboMes.SelectedIndex = mes - 1
        cboAnno.SelectedIndex = anno - 2010
        'dataset almacen
        Dim daAlmacen As New MySqlDataAdapter
        Dim cad As String
        Dim mAlmacen As New Almacen
        If pCatalogoXalmacen Then
            If pAlmaUser = "0000" Then
                cad = "select cod_alma,nom_alma from almacen where (esProduccion) and activo=1"
            Else
                cad = "select cod_alma,nom_alma from almacen where cod_alma='" & pAlmaUser & "' and (esProduccion) and activo=1"
            End If
        Else
            cad = "select cod_alma,nom_alma from almacen where cod_alma='" & pAlmaUser & "'"
        End If
        Dim comAlmacen As New MySqlCommand(cad, dbConex)
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
        '
        cad = "select cod_sgrupo,nom_sgrupo from subgrupo where activo=1 and not(esProduccion) order by nom_sgrupo"
        Dim comGrupo As New MySqlCommand(cad, dbConex)
        Dim daGrupo As New MySqlDataAdapter
        daGrupo.SelectCommand = comGrupo
        daGrupo.Fill(dsGrupo, "grupo")
        cad = "select cuenta_c from plan_cuentas group by cuenta_c"
        Dim comCuenta As New MySqlCommand(cad, dbConex)
        Dim daCuenta As New MySqlDataAdapter
        daCuenta.SelectCommand = comCuenta
        daCuenta.Fill(dsCuenta, "cuenta")
        estaCargando = False
        cargadatos()
    End Sub
    Private Sub cboMes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMes.SelectedIndexChanged
        estableceFechas()
        If Not estaCargando Then
            chkDia.CheckState = CheckState.Unchecked
            cargadatos()
        End If
    End Sub
    Private Sub cboAnno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAnno.SelectedIndexChanged
        estableceFechas()
        If Not estaCargando Then
            chkDia.CheckState = CheckState.Unchecked
            cargadatos()
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
            cargadatos()
        End If
    End Sub
    Private Sub dtiDesde_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtiDesde.ValueChanged
        If Not estaCargando Then
            cargadatos()
        End If
    End Sub
    Private Sub dtiHasta_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtiHasta.ValueChanged
        If Not estaCargando Then
            cargadatos()
        End If
    End Sub
    Private Sub chkFiltrar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFiltrar.CheckedChanged
        If Not estaCargando Then
            If chkFiltrar.Checked = True And optGrupo.Checked = True Then
                With cboGrupo
                    .Enabled = False
                    .DataSource = dsGrupo.Tables("grupo")
                    .DisplayMember = dsGrupo.Tables("grupo").Columns("nom_sgrupo").ToString
                    .ValueMember = dsGrupo.Tables("grupo").Columns("cod_sgrupo").ToString
                    If dsGrupo.Tables("grupo").Rows.Count > 0 Then
                        .SelectedIndex = 0
                    End If
                    .Enabled = True
                End With
            Else
                If chkFiltrar.Checked = True And optCuenta.Checked = True Then
                    With cboGrupo
                        .Enabled = False
                        .DataSource = dsCuenta.Tables("cuenta")
                        .DisplayMember = dsCuenta.Tables("cuenta").Columns("cuenta_c").ToString
                        .ValueMember = dsCuenta.Tables("cuenta").Columns("cuenta_c").ToString
                        If dsCuenta.Tables("cuenta").Rows.Count > 0 Then
                            .SelectedIndex = 0
                        End If
                        .Enabled = True
                    End With
                Else
                    cboGrupo.Enabled = False
                    cboGrupo.SelectedIndex = -1
                End If
            End If
            cargadatos()
        End If
    End Sub
    Private Sub optCuenta_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optCuenta.CheckedChanged
        If Not estaCargando Then
            If chkFiltrar.Checked = False Then
                chkFiltrar.Checked = True
            End If
            If chkFiltrar.Checked = True And optCuenta.Checked = True Then
                With cboGrupo
                    .Enabled = False
                    .DataSource = dsCuenta.Tables("cuenta")
                    .DisplayMember = dsCuenta.Tables("cuenta").Columns("cuenta_c").ToString
                    .ValueMember = dsCuenta.Tables("cuenta").Columns("cuenta_c").ToString
                    If dsCuenta.Tables("cuenta").Rows.Count > 0 Then
                        .SelectedIndex = 0
                    End If
                    .Enabled = True
                End With
                cargadatos()
            End If
        End If
    End Sub
    Private Sub optGrupo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optGrupo.CheckedChanged
        If Not estaCargando Then
            If chkFiltrar.Checked = False Then
                chkFiltrar.Checked = True
            End If
            If chkFiltrar.Checked = True And optGrupo.Checked = True Then
                With cboGrupo
                    .Enabled = False
                    .DataSource = dsGrupo.Tables("grupo")
                    .DisplayMember = dsGrupo.Tables("grupo").Columns("nom_sgrupo").ToString
                    .ValueMember = dsGrupo.Tables("grupo").Columns("cod_sgrupo").ToString
                    If dsGrupo.Tables("grupo").Rows.Count > 0 Then
                        .SelectedIndex = 0
                    End If
                    .Enabled = True
                End With
                cargadatos()
            End If
        End If
    End Sub
    Private Sub cboGrupo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboGrupo.SelectedIndexChanged
        If Not estaCargando And cboGrupo.Enabled = True Then
            cargadatos()
        End If
    End Sub
    Private Sub dataFluctua2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataFluctua2.CellContentClick
        Dim mIngreso As New Ingreso
        Dim periodo As String = periodoSeleccionado()
        Dim esHistorial As Boolean = IIf(periodo = periodoActivo(), False, True)
        Dim nOperacion As Integer = dataFluctua1("operacion", dataFluctua1.CurrentRow.Index).Value
        Dim cProveedor As String = mIngreso.recProveedor(nOperacion, esHistorial, periodo)
        Dim cDocumento As String = mIngreso.recDocumento(nOperacion, esHistorial, periodo)
        muestraTip(cDocumento, cProveedor)
    End Sub
    Sub cargadatos()
        If tabFluctuacion.IsSelected Then
            muestraPrecios()
            colorearSobrePrecio()
        End If
        If tabFluctuacion2.IsSelected Then
            muestraPrecios2()
            colorearSobrePrecio2()
        End If
        If tabRecetas.IsSelected Then
            muestraProducciones()
            colorearSobrePrecioProduccion()
        End If
        If tabRecetas.IsSelected Then
            muestraMargenes()
        End If
        If tabPrecioProm.IsSelected Then
            muestraPrecioProm()
        End If

    End Sub
    Private Sub tabFluctuacion_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tabFluctuacion.Click
        If Not estaCargando Then
            cargadatos()
        End If
    End Sub
    Private Sub tabFluctuacion2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tabFluctuacion2.Click
        If Not estaCargando Then
            cargadatos()
        End If
    End Sub
    Private Sub tabRecetas_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tabFluctuacion2.Click
        If Not estaCargando Then
            cargadatos()
        End If
    End Sub
    Private Sub tabMargenes_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tabRecetas.Click
        If Not estaCargando Then
            cargadatos()
        End If
    End Sub
    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged
        Dim valor As String = txtBuscar.Text
        dsPrecio.Tables("fluctuacionPrecios").DefaultView.RowFilter = "nom_art LIKE '%" & valor & "%'"
        If dataFluctua1.RowCount > 0 Then
            dataFluctua1.CurrentCell = dataFluctua1("nom_art", dataFluctua1.CurrentRow.Index)
            colorearSobrePrecio()
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
    Sub muestraPrecios()
        Dim mPrecio As New ePrecio
        Dim periodo As String = periodoSeleccionado()
        Dim esHistorial As Boolean = IIf(periodo = periodoActivo(), False, True)
        Dim esMensual As Boolean = IIf(chkDia.Checked = True, False, True)
        Dim xGrupo As Boolean = IIf(chkFiltrar.Checked = True And optGrupo.Checked = True, True, False)
        Dim xCuenta As Boolean = IIf(chkFiltrar.Checked = True And optCuenta.Checked = True, True, False)
        Dim cGrupo As String = cboGrupo.SelectedValue
        'fluctuacion de precios de costo
        dsFluctuacion.Clear()
        dsFluctuacion = mPrecio.recuperaArticulosFluctuacionPrecios(pEmpresa, esHistorial, periodo, esMensual, dtiDesde.Value, _
                            dtiHasta.Value, pDecimales, xGrupo, cGrupo, xCuenta, cGrupo, cPrecioSIs, chPrecioSIs)
        estructuraFluctuacionPrecios()
        cargaFluctuacionPrecios()
    End Sub
    Sub estructuraFluctuacionPrecios()
        Dim I As Integer = 1, col As String
        Dim inicio As Integer = 1, final As Integer = 1
        If chkDia.Checked = True Then
            inicio = Microsoft.VisualBasic.DateAndTime.Day(dtiDesde.Value)
            final = Microsoft.VisualBasic.DateAndTime.Day(dtiHasta.Value)
        End If
        dsPrecio.Clear()
        dsPrecio = ePrecio.dsPrecio
        With dataFluctua1
            .DataSource = dsPrecio.Tables("fluctuacionPrecios").DefaultView
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_art").HeaderText = "Código"
            .Columns("cod_art").Width = 50
            .Columns("cod_art").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("nom_art").HeaderText = "Descripción"
            .Columns("nom_art").Width = 220
            .Columns("nom_sgrupo").HeaderText = "Grupo"
            .Columns("nom_sgrupo").Width = 100
            .Columns("nom_uni").HeaderText = "Unidad"
            .Columns("nom_uni").Width = 60
            .Columns("pre_costo").HeaderText = "Costo"
            .Columns("pre_costo").Width = 60
            .Columns("pre_costo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            For I = 1 To 31
                col = "d" & I
                .Columns(col).Visible = False
            Next
            .Columns("colorear").Visible = False
            .Columns("pre_costoMin").Visible = False
            .Columns("pre_costoMax").Visible = False
            .Columns("promedio").Visible = False
            .Columns("fec_doc").Visible = False
            .Columns("ingreso").Visible = False
            .Columns("operacion").Visible = False
        End With
        With dataFluctua2
            .DataSource = dsPrecio.Tables("fluctuacionPrecios").DefaultView
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
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
                Next
            Else
                For I = inicio To 31
                    col = "d" & I
                    .Columns(col).HeaderText = col
                    .Columns(col).Width = 45
                    .Columns(col).Visible = True
                    .Columns(col).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                Next
            End If

            .Columns("cod_art").Visible = False
            .Columns("nom_art").Visible = False
            .Columns("nom_sgrupo").Visible = False
            .Columns("nom_uni").Visible = False
            .Columns("pre_costo").Visible = False
            .Columns("pre_costoMin").Visible = False
            .Columns("pre_costoMax").Visible = False
            .Columns("colorear").Visible = False
            .Columns("promedio").Visible = False
            .Columns("fec_doc").Visible = False
            .Columns("ingreso").Visible = False
            .Columns("operacion").Visible = False
        End With
    End Sub
    Sub cargaFluctuacionPrecios()
        Dim I As Integer = 0, X As Integer = 1, col As String, dia As Integer
        Dim codigo As String = ""
        For I = 0 To dsFluctuacion.Tables("articulos").Rows.Count - 1
            If codigo <> dsFluctuacion.Tables("articulos").Rows(I).Item("cod_art").ToString Then
                codigo = dsFluctuacion.Tables("articulos").Rows(I).Item("cod_art").ToString
                Dim fila As DataRow = dsPrecio.Tables("fluctuacionPrecios").NewRow
                fila.Item("cod_art") = dsFluctuacion.Tables("articulos").Rows(I).Item("cod_art").ToString
                fila.Item("nom_art") = dsFluctuacion.Tables("articulos").Rows(I).Item("nom_art").ToString
                fila.Item("nom_sgrupo") = dsFluctuacion.Tables("articulos").Rows(I).Item("nom_sgrupo").ToString
                fila.Item("nom_uni") = dsFluctuacion.Tables("articulos").Rows(I).Item("nom_uni").ToString
                fila.Item("pre_costo") = dsFluctuacion.Tables("articulos").Rows(I).Item("pre_costo").ToString
                fila.Item("pre_costoMax") = dsFluctuacion.Tables("articulos").Rows(I).Item("pre_costoMax").ToString
                fila.Item("operacion") = dsFluctuacion.Tables("articulos").Rows(I).Item("operacion").ToString
                For X = 1 To 31
                    If I <= dsFluctuacion.Tables("articulos").Rows.Count - 1 Then
                        If codigo <> dsFluctuacion.Tables("articulos").Rows(I).Item("cod_art").ToString Then
                            codigo = ""
                            I = I - 1
                            Exit For
                        End If
                        dia = Microsoft.VisualBasic.DateAndTime.Day(dsFluctuacion.Tables("articulos").Rows(I).Item("fec_doc").ToString)
                        col = "d" & dia
                        fila.Item(col) = Round(Val(dsFluctuacion.Tables("articulos").Rows(I).Item("precio").ToString), 3)
                        codigo = dsFluctuacion.Tables("articulos").Rows(I).Item("cod_art").ToString
                        I = I + 1
                    End If
                Next
                dsPrecio.Tables("fluctuacionPrecios").Rows.Add(fila)
            End If
        Next
    End Sub
    Sub colorearSobrePrecio()
        Dim I As Integer = 0, X As Integer = 1, col As String
        For I = 0 To dataFluctua2.RowCount - 1
            For X = 1 To 31
                col = "d" & X
                If Not IsDBNull(dataFluctua2(col, I).Value) Then
                    If Not IsDBNull(dataFluctua2("pre_costoMax", I).Value) Then
                        If dataFluctua2(col, I).Value > dataFluctua2("pre_costomax", I).Value Then
                            dataFluctua2(col, I).Style.BackColor = Color.Red
                            dataFluctua2(col, I).Style.ForeColor = Color.White
                        End If
                    End If
                End If
            Next
        Next
    End Sub
    Sub muestraPrecios2()
        Dim mPrecio As New ePrecio
        Dim periodo As String = periodoSeleccionado()
        Dim esHistorial As Boolean = IIf(periodo = periodoActivo(), False, True)
        Dim esMensual As Boolean = IIf(chkDia.Checked = True, False, True)
        Dim xGrupo As Boolean = IIf(chkFiltrar.Checked = True And optGrupo.Checked = True, True, False)
        Dim xCuenta As Boolean = IIf(chkFiltrar.Checked = True And optCuenta.Checked = True, True, False)
        'fluctuacion de precios de costo
        dsFluctuacion2.Clear()
        dsFluctuacion2 = mPrecio.recuperaArticulosFluctuacionPrecios(pEmpresa, esHistorial, periodo, esMensual, dtiDesde.Value, _
                            dtiHasta.Value, pDecimales, xGrupo, cboGrupo.SelectedValue, xCuenta, cboGrupo.SelectedValue, cPrecioSIs, chPrecioSIs)
        estructuraFluctuacionPrecios2()
        cargaFluctuacionPrecios2()
    End Sub
    Sub estructuraFluctuacionPrecios2()
        Dim I As Integer = 1, col As String
        Dim inicio As Integer = 1, final As Integer = 1
        If chkDia.Checked = True Then
            inicio = Microsoft.VisualBasic.DateAndTime.Day(dtiDesde.Value)
            final = Microsoft.VisualBasic.DateAndTime.Day(dtiHasta.Value)
        End If
        dsPrecio2.Clear()
        dsPrecio2 = ePrecio.dsPrecio
        With dataFluctuaA
            .DataSource = dsPrecio2.Tables("fluctuacionPrecios")
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_art").HeaderText = "Código"
            .Columns("cod_art").Width = 50
            .Columns("cod_art").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("nom_art").HeaderText = "Descripción"
            .Columns("nom_art").Width = 220
            .Columns("nom_uni").HeaderText = "Unidad"
            .Columns("nom_uni").Width = 60
            .Columns("pre_costo").HeaderText = "Costo"
            .Columns("pre_costo").Width = 60
            .Columns("pre_costo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            For I = 1 To 31
                col = "d" & I
                .Columns(col).Visible = False
            Next
            .Columns("colorear").Visible = False
            .Columns("pre_costoMax").Visible = False
            .Columns("pre_costoMin").Visible = False
            .Columns("promedio").Visible = False
            .Columns("fec_doc").Visible = False
            .Columns("ingreso").Visible = False
            .Columns("operacion").Visible = False
        End With
        With dataFluctuaB
            .DataSource = dsPrecio2.Tables("fluctuacionPrecios")
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
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
                Next
            Else
                For I = inicio To 31
                    col = "d" & I
                    .Columns(col).HeaderText = col
                    .Columns(col).Width = 45
                    .Columns(col).Visible = True
                    .Columns(col).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                Next
            End If
            .Columns("cod_art").Visible = False
            .Columns("nom_art").Visible = False
            .Columns("nom_sgrupo").Visible = False
            .Columns("nom_uni").Visible = False
            .Columns("pre_costo").Visible = False
            .Columns("pre_costoMin").Visible = False
            .Columns("pre_costoMax").Visible = False
            .Columns("colorear").Visible = False
            .Columns("promedio").Visible = False
            .Columns("fec_doc").Visible = False
            .Columns("ingreso").Visible = False
            .Columns("operacion").Visible = False
        End With
    End Sub
    Sub cargaFluctuacionPrecios2()
        Dim I As Integer = 0, X As Integer = 1, col As String, dia As Integer
        Dim codigo As String = ""
        For I = 0 To dsFluctuacion2.Tables("articulos").Rows.Count - 1
            If codigo <> dsFluctuacion2.Tables("articulos").Rows(I).Item("cod_art").ToString Then
                codigo = dsFluctuacion2.Tables("articulos").Rows(I).Item("cod_art").ToString
                Dim fila As DataRow = dsPrecio2.Tables("fluctuacionPrecios").NewRow
                fila.Item("cod_art") = dsFluctuacion2.Tables("articulos").Rows(I).Item("cod_art").ToString
                fila.Item("nom_art") = dsFluctuacion2.Tables("articulos").Rows(I).Item("nom_art").ToString
                fila.Item("nom_uni") = dsFluctuacion2.Tables("articulos").Rows(I).Item("nom_uni").ToString
                fila.Item("pre_costo") = dsFluctuacion2.Tables("articulos").Rows(I).Item("pre_costo").ToString
                fila.Item("pre_costoMin") = dsFluctuacion2.Tables("articulos").Rows(I).Item("pre_costoMin").ToString
                For X = 1 To 31
                    If I <= dsFluctuacion2.Tables("articulos").Rows.Count - 1 Then
                        If codigo <> dsFluctuacion2.Tables("articulos").Rows(I).Item("cod_art").ToString Then
                            codigo = ""
                            I = I - 1
                            Exit For
                        End If
                        dia = Microsoft.VisualBasic.DateAndTime.Day(dsFluctuacion2.Tables("articulos").Rows(I).Item("fec_doc").ToString)
                        col = "d" & dia
                        fila.Item(col) = Val(dsFluctuacion2.Tables("articulos").Rows(I).Item("precio").ToString)
                        codigo = dsFluctuacion2.Tables("articulos").Rows(I).Item("cod_art").ToString
                        I = I + 1
                    End If
                Next
                dsPrecio2.Tables("fluctuacionPrecios").Rows.Add(fila)
            End If
        Next
    End Sub
    Sub colorearSobrePrecio2()
        Dim I As Integer = 0, X As Integer = 1, col As String
        For I = 0 To dataFluctuaB.RowCount - 1
            For X = 1 To 31
                col = "d" & X
                If Not IsDBNull(dataFluctuaB(col, I).Value) Then
                    If Not IsDBNull(dataFluctuaB("pre_costoMin", I).Value) Then
                        If dataFluctuaB(col, I).Value < dataFluctuaB("pre_costoMin", I).Value Then
                            dataFluctuaB(col, I).Style.BackColor = Color.Green
                            dataFluctuaB(col, I).Style.ForeColor = Color.White
                        End If
                    End If
                End If
            Next
        Next
    End Sub
    Private Sub cboAlmacen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAlmacen.SelectedIndexChanged
        If Not estaCargando Then
            muestraProducciones()
            colorearSobrePrecioProduccion()
        End If
    End Sub
    Sub muestraProducciones()
        Dim mProduccion As New Receta
        dsProducciones.Clear()
        dsProducciones = mProduccion.recuperaProducciones(True, cboAlmacen.SelectedValue, True)
        estructuraProduccion()
    End Sub
    Sub muestraPrecioProm()
        Dim mPrecio As New ePrecio
        dsPrecioProm.Clear()
        dsPrecioProm = mPrecio.ResumenPrecioProm(Val(cboAnno.Text))
        DataPrecios.DataSource = dsPrecioProm.Tables("ResumenPrecioProm")
    End Sub

    Sub estructuraProduccion()
        With dataProducciones
            .DataSource = dsProducciones.Tables("articulo")
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_art").HeaderText = "Código"
            .Columns("cod_art").Width = 50
            .Columns("cod_art").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("nom_art").HeaderText = "Descripción"
            .Columns("nom_art").Width = 249
            .Columns("nom_uni").HeaderText = "Unidad"
            .Columns("nom_uni").Width = 75
            .Columns("pre_costo").HeaderText = "Costo"
            .Columns("pre_costo").Width = 70
            .Columns("pre_costo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("porcentaje").HeaderText = "%"
            .Columns("porcentaje").Width = 50
            .Columns("porcentaje").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("pre_venta").HeaderText = "Precio Venta"
            .Columns("pre_venta").Width = 70
            .Columns("pre_venta").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("cod_uni").Visible = False
            .Columns("cod_sgrupo").Visible = False
            .Columns("cod_artExt").Visible = False
            .Columns("cod_tart").Visible = False
            .Columns("pre_inc_imp").Visible = False
            .Columns("pre_costoMax").Visible = False
            .Columns("activo").Visible = False
        End With
    End Sub
    Private Sub dataProducciones_ColumnHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dataProducciones.ColumnHeaderMouseClick
        colorearSobrePrecioProduccion()
    End Sub
    Sub colorearSobrePrecioProduccion()
        Dim I As Integer = 0
        For I = 0 To dataProducciones.RowCount - 1
            If Not IsDBNull(dataProducciones("porcentaje", I).Value) Then
                If dataProducciones("porcentaje", I).Value >= 30 Then
                    dataProducciones("porcentaje", I).Style.BackColor = Color.Red
                    dataProducciones("porcentaje", I).Style.ForeColor = Color.White
                Else
                    If dataProducciones("porcentaje", I).Value > 25 Then
                        dataProducciones("porcentaje", I).Style.BackColor = Color.Orange
                        dataProducciones("porcentaje", I).Style.ForeColor = Color.White
                    End If
                End If
            End If
        Next
    End Sub
    Private Sub cmdActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdActualizar.Click
        Dim dstProducciones As New DataSet
        Dim dstReceta As New DataSet
        Dim cPrecioProm As String = general.strPrecioCostoPromedio
        Dim mReceta As New Receta, mPrecio As New ePrecio
        Dim I As Integer = 0, X As Integer = 0
        Dim cod_prod, cod_art As String, cant, cant_uni, pre_costo, newCostoReceta As Decimal
        dstProducciones = mReceta.recuperaProduccion(False, "", True)
        'cargamos las producciones activas
        If dstProducciones.Tables("produccion").Rows.Count > 0 Then
            For I = 0 To dstProducciones.Tables("produccion").Rows.Count - 1
                cod_prod = dstProducciones.Tables("produccion").Rows(I).Item("cod_art").ToString
                dstReceta.Clear()
                dstReceta = mReceta.recuperaReceta(cod_prod)
                If dstReceta.Tables("receta").Rows.Count > 0 Then
                    For X = 0 To dstReceta.Tables("receta").Rows.Count - 1
                        cod_art = dstReceta.Tables("receta").Rows(X).Item("cod_art").ToString
                        cant = dstReceta.Tables("receta").Rows(X).Item("cant").ToString
                        cant_uni = dstReceta.Tables("receta").Rows(X).Item("cant_uni").ToString
                        pre_costo = dstReceta.Tables("receta").Rows(X).Item("pre_costo").ToString
                        'mPrecio.actualizaPrecioPromedio(cod_art, cPrecioProm)
                        'actualizamos los costos de insumos en receta
                        'newCostoInsumo = Round(prom * cant, 3)
                        'mReceta.actualizaCostoInsumo_enReceta(cod_prod, cod_art, pre_costo)
                        'actualizamos los costos de recetas
                        newCostoReceta = mReceta.devuelveCostoReceta(cod_prod)
                        mReceta.actualizaCostoReceta(cod_prod, newCostoReceta)
                    Next
                End If
            Next
            'actualizamos la ventana
            cargadatos()
            MessageBox.Show("Costos Actualizados...", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            dataProducciones.Focus()
        End If
    End Sub
    Sub muestraMargenes()
        Dim mPrecio As New ePrecio
        Dim periodo As String = periodoSeleccionado()
        'margenes de operacion x producto
        dsMargenes.Clear()
        If periodo = periodoActivo() Then
            If chkDia.Checked = False Then 'cuando se trabaja x mes
                dsMargenes = mPrecio.margenesOperacion(True, dtiDesde.Value, dtiHasta.Value, pDecimales, False, False)
            Else
                dsMargenes = mPrecio.margenesOperacion(False, dtiDesde.Value, dtiHasta.Value, pDecimales, False, False)
            End If
        Else 'historial
            If chkDia.Checked = False Then 'cuando se trabaja x mes
                dsMargenes = mPrecio.margenesOperacion_historial(periodo, True, dtiDesde.Value, dtiHasta.Value, pDecimales, False, False)
            Else
                dsMargenes = mPrecio.margenesOperacion_historial(periodo, False, dtiDesde.Value, dtiHasta.Value, pDecimales, False, False)
            End If
        End If
        margenesOperacion()
    End Sub
    Sub muestraMargenes_sub()
        Dim mPrecio As New ePrecio
        Dim periodo As String = periodoSeleccionado()
        If optMargen2.Checked = True Then 'los 10 productos con mayor margen
            If periodo = periodoActivo() Then
                If chkDia.Checked = False Then 'cuando se trabaja x mes
                    dsMargenes = mPrecio.margenesOperacion(True, dtiDesde.Value, dtiHasta.Value, pDecimales, True, True)
                Else
                    dsMargenes = mPrecio.margenesOperacion(False, dtiDesde.Value, dtiHasta.Value, pDecimales, True, True)
                End If
            Else 'historial
                If chkDia.Checked = False Then 'cuando se trabaja x mes
                    dsMargenes = mPrecio.margenesOperacion_historial(periodo, True, dtiDesde.Value, dtiHasta.Value, pDecimales, True, True)
                Else
                    dsMargenes = mPrecio.margenesOperacion_historial(periodo, False, dtiDesde.Value, dtiHasta.Value, pDecimales, True, True)
                End If
            End If
        Else
            If optMargen3.Checked = True Then 'los 10 productos con menor margen
                If periodo = periodoActivo() Then
                    If chkDia.Checked = False Then 'cuando se trabaja x mes
                        dsMargenes = mPrecio.margenesOperacion(True, dtiDesde.Value, dtiHasta.Value, pDecimales, True, False)
                    Else
                        dsMargenes = mPrecio.margenesOperacion(False, dtiDesde.Value, dtiHasta.Value, pDecimales, True, False)
                    End If
                Else 'historial
                    If chkDia.Checked = False Then 'cuando se trabaja x mes
                        dsMargenes = mPrecio.margenesOperacion_historial(periodo, True, dtiDesde.Value, dtiHasta.Value, pDecimales, True, False)
                    Else
                        dsMargenes = mPrecio.margenesOperacion_historial(periodo, False, dtiDesde.Value, dtiHasta.Value, pDecimales, True, False)
                    End If
                End If
            End If
        End If
        margenesOperacion()
    End Sub
    Sub margenesOperacion()
        'With dataMargenes
        '    .DataSource = dsMargenes.Tables("margenesOperacion")
        '    .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        '    .Columns("cod_art").HeaderText = "Código"
        '    .Columns("cod_art").Width = 55
        '    .Columns("cod_art").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        '    .Columns("nom_art").HeaderText = "Descripción"
        '    .Columns("nom_art").Width = 320
        '    .Columns("nom_uni").HeaderText = "Unidad"
        '    .Columns("nom_uni").Width = 60
        '    .Columns("nom_uni").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        '    .Columns("cant").HeaderText = "Cantidad"
        '    .Columns("cant").Width = 70
        '    .Columns("cant").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        '    .Columns("pre_venta").HeaderText = "Precio Venta"
        '    .Columns("pre_venta").Width = 60
        '    .Columns("pre_venta").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        '    .Columns("pre_costo").HeaderText = "Precio Costo"
        '    .Columns("pre_costo").Width = 60
        '    .Columns("pre_costo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        '    .Columns("margen").HeaderText = "Margen Operación"
        '    .Columns("margen").Width = 80
        '    .Columns("margen").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        'End With
    End Sub
    Sub muestraMargenAnual()
        'Dim mPrecio As New ePrecio
        'Dim I As Integer = 1, anno As String = cboAnno.SelectedText
        'Dim periodo As String = ""
        ''margenes de operacion x producto
        'If optMargenAnual.Checked = True Then
        '    dsMargenAnual.Clear()
        '    For i = 1 To 12
        '        periodo = anno & Microsoft.VisualBasic.Right("0" & Trim(Microsoft.VisualBasic.Str(I)), 2)
        '    Next
        '    dsMargenAnualTemp = mPrecio.margenesOperacion_historial(periodo, True, dtiDesde.Value, dtiHasta.Value, pDecimales, False, False)
        'End If
        estructuraMargenAnual()
    End Sub
    Sub estructuraMargenAnual()
        dsMargenAnual.Clear()
        dsMargenAnual = ePrecio.dsMargenAnual
        'With dataMargenes
        '    .DataSource = dsMargenAnual.Tables("margenAnual")
        '    .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        '    .ReadOnly = True
        '    .Columns("cod_art").Visible = False
        '    .Columns("nom_art").HeaderText = "Descripción"
        '    .Columns("nom_art").Width = 260
        '    .Columns("nom_uni").HeaderText = "Unidad"
        '    .Columns("nom_uni").Width = 57
        '    .Columns("nom_uni").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        '    .Columns("m1").HeaderText = "Ene"
        '    .Columns("m1").Width = 43
        '    .Columns("m1").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        '    .Columns("m2").HeaderText = "Feb"
        '    .Columns("m2").Width = 43
        '    .Columns("m2").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        '    .Columns("m3").HeaderText = "Mar"
        '    .Columns("m3").Width = 43
        '    .Columns("m3").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        '    .Columns("m4").HeaderText = "Abr"
        '    .Columns("m4").Width = 43
        '    .Columns("m4").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        '    .Columns("m5").HeaderText = "May"
        '    .Columns("m5").Width = 43
        '    .Columns("m5").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        '    .Columns("m6").HeaderText = "Jun"
        '    .Columns("m6").Width = 43
        '    .Columns("m6").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        '    .Columns("m7").HeaderText = "Jul"
        '    .Columns("m7").Width = 43
        '    .Columns("m7").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        '    .Columns("m8").HeaderText = "Ago"
        '    .Columns("m8").Width = 43
        '    .Columns("m8").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        '    .Columns("m9").HeaderText = "Set"
        '    .Columns("m9").Width = 43
        '    .Columns("m9").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        '    .Columns("m10").HeaderText = "Oct"
        '    .Columns("m10").Width = 43
        '    .Columns("m10").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        '    .Columns("m11").HeaderText = "Nov"
        '    .Columns("m11").Width = 43
        '    .Columns("m11").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        '    .Columns("m12").HeaderText = "Dic"
        '    .Columns("m12").Width = 43
        '    .Columns("m12").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        'End With
    End Sub
    Sub cargaMargenAnual()
        Dim I As Integer = 0, X As Integer = 1
        Dim codigo As String = ""
        For I = 0 To dsFluctuacion.Tables("articulos").Rows.Count - 1
            If codigo <> dsFluctuacion.Tables("articulos").Rows(I).Item("cod_art").ToString Then
                codigo = dsFluctuacion.Tables("articulos").Rows(I).Item("cod_art").ToString
                Dim fila As DataRow = dsPrecio.Tables("fluctuacionPrecios").NewRow
                fila.Item("cod_art") = dsFluctuacion.Tables("articulos").Rows(I).Item("cod_art").ToString
                fila.Item("nom_art") = dsFluctuacion.Tables("articulos").Rows(I).Item("nom_art").ToString
                fila.Item("nom_uni") = dsFluctuacion.Tables("articulos").Rows(I).Item("nom_uni").ToString
                fila.Item("pre_costoMax") = dsFluctuacion.Tables("articulos").Rows(I).Item("pre_costoMax").ToString
                For X = 1 To 31
                    If I <= dsFluctuacion.Tables("articulos").Rows.Count - 1 Then
                        If codigo <> dsFluctuacion.Tables("articulos").Rows(I).Item("cod_art").ToString Then
                            codigo = ""
                            I = I - 1
                            Exit For
                        End If
                        Select Case Microsoft.VisualBasic.DateAndTime.Day(dsFluctuacion.Tables("articulos").Rows(I).Item("fec_doc").ToString)
                            Case 1
                                fila.Item("m1") = Val(dsFluctuacion.Tables("articulos").Rows(I).Item("precio").ToString)
                            Case 2
                                fila.Item("m2") = Val(dsFluctuacion.Tables("articulos").Rows(I).Item("precio").ToString)
                            Case 3

                        End Select
                    End If
                Next
            End If
        Next
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
        If tabFluctuacion.IsSelected Then
            frm.EP_fluctuacionPrecios(dsPrecio, fechaReporte, periodoReporte)
        Else
            If tabRecetas.IsSelected Then
                frm.EP_margenesOperacion(dsMargenes, fechaReporte, periodoReporte)
            End If
        End If
        frm.MdiParent = principal
        frm.Show()
    End Sub
    Private Sub optMargen1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not estaCargando Then
            If optMargen1.Checked = True Then
                muestraMargenes()
            End If
        End If
    End Sub
    Private Sub optMargen2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not estaCargando Then
            If optMargen2.Checked = True Then
                muestraMargenes_sub()
            End If
        End If
    End Sub
    Private Sub optMargen3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not estaCargando Then
            If optMargen3.Checked = True Then
                muestraMargenes_sub()
            End If
        End If
    End Sub
    Private Sub optMargenAnual_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not estaCargando Then
            If optMargenAnual.Checked = True Then
                muestraMargenAnual()
            End If
        End If
    End Sub
    Sub muestraTip(ByVal documento As String, ByVal titulo As String)
        Dim Prueba As New DevComponents.DotNetBar.Balloon()
        Prueba.Text = titulo
        Prueba.CaptionText = documento
        Prueba.ShowInTaskbar = True
        Prueba.Style = DevComponents.DotNetBar.eBallonStyle.Alert
        Prueba.AutoCloseTimeOut = 8
        Prueba.ForeColor = Color.Blue
        Prueba.ShowCloseButton = False
        Dim r As Object = Screen.GetWorkingArea(Me)
        Prueba.Location = New Point(r.Right - Prueba.Width, r.Bottom - Prueba.Height)
        Prueba.Show()
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Dim periodo As String = periodoSeleccionado()
        Dim periodoReporte As String = "Periodo: " & general.periodo_mesAnnoLetras(periodo)
        Dim frm As New rptForm
        frm.cargarRecetasPorcentaje(dsProducciones)
        frm.MdiParent = principal
        frm.Show()
    End Sub

    Private Sub dtiDesde_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtiDesde.Click

    End Sub

    Private Sub dataFluctua2_CellContextMenuStripNeeded(sender As Object, e As DataGridViewCellContextMenuStripNeededEventArgs) Handles dataFluctua2.CellContextMenuStripNeeded

    End Sub

    Private Sub dataFluctua2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dataFluctua2.KeyDown
        If (e.Control And e.KeyCode = Keys.E) Then
            If dataFluctua2.RowCount > 0 Then
                ' EnviaraExcel(dataFluctua2)
                GenerarPivotExcel()
            End If
        End If
    End Sub

    Sub GenerarPivotExcel()
        Dim dtDatos As New DataTable() 'Objeto de Tipo DataTable para almacenar los datos a enviar para generar el Excel.
        Dim mCompras As New Ingreso
        Dim mAlmacen As New Almacen
        Dim periodo As String = periodoSeleccionado()
        Dim eshistorial As Boolean = IIf(periodo >= periodoActivo(), False, True)
        Dim ventasxdia As Boolean = IIf(chkDia.Checked = False, True, False)
        Dim xAlmacen As Boolean = False
        Dim cAlmacen As String = mAlmacen.devuelveAlmacenPrincipal
        Dim anno As Integer = cboAnno.SelectedItem
        dsCompras = mCompras.recuperaCompras(eshistorial, False, xAlmacen, cAlmacen, ventasxdia, anno, dtiDesde.Value, dtiHasta.Value, cPrecioSIs)
        dtDatos = dsCompras.Tables("articulos")

        Dim genExcel As New clsGenerarExcel() 'Creamos el Objeto del tipo clsGenerarExcel.

        Dim nomArchivo As String = "" 'Definimos el nombre y la ubicación del archivo.
        Dim titCols As New ArrayList(New String() {"fec_doc", "hora", "mes", "documento", "tip_proveedor", "Proveedor", "Gcompra", "Gventa", "articulo", "precio", "costo", "sucursal", "cantidad", "imp_compra", "imp_costo", "unidad"}) 'Agregamos los títulos de las Columnas en la Hoja de Datos.
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

    Private Sub dataFluctua1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataFluctua1.CellContentClick

    End Sub

    Private Sub dataFluctua1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dataFluctua1.KeyDown
        If (e.Control And e.KeyCode = Keys.E) Then



            If dataFluctua1.RowCount > 0 Then
                    EnviaraExcel(dataFluctua1)
                End If





        End If
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click

        muestraPrecioProm()

    End Sub

    Private Sub dtiHasta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtiHasta.Click

    End Sub

    Private Sub TabControl2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl2.Click

    End Sub

    Private Sub DataPrecios_KeyDown(sender As Object, e As KeyEventArgs) Handles DataPrecios.KeyDown
        If (e.Control And e.KeyCode = Keys.E) Then
            If DataPrecios.RowCount > 0 Then
                EnviaraExcel(DataPrecios)
            End If
        End If
    End Sub
End Class
