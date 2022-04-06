Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Math
Imports libreriaClases


Public Class p_inventario
    Private dsInventario As New DataSet
    Private dsAlmacen As New DataSet
    Private dsArea As New DataSet
    Private dsGrupo As New DataSet
    'Private dsAlmacenImp As New DataSet
    Private dsCatalogo As New DataSet
    'para validar el separador decimal
    Private sepDecimal As Char
    Private estaCargando As Boolean = True
    Private _operacion As Integer = 0
    Private _recCantidad As Boolean = False
    Private Sub p_inventario_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        principal.mp_invInicial.Enabled = True
    End Sub

    Private Sub p_inventario_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If (e.Control And e.KeyCode = Keys.V) Then
            Dim data As IDataObject = Clipboard.GetDataObject
            Dim i As Integer = 0
            Dim j As Integer = 0
            If Not data.GetDataPresent("CSV", False) Then Return
            ChkModoImp.Checked = True
            Try
                'Dim da As New MySqlDataAdapter
                Dim ds As New DataSet
                Dim dt As New DataTable
                dt.Columns.Add(New DataColumn("Cod_art", GetType(String)))
                dt.Columns.Add(New DataColumn("Nom_art", GetType(String)))
                dt.Columns.Add(New DataColumn("nom_Uni", GetType(String)))
                dt.Columns.Add(New DataColumn("Cantidad", GetType(Decimal)))
                dt.Columns.Add(New DataColumn("Pre_costo", GetType(Decimal)))
                ds.Tables.Add(dt)
                'da.Fill(dt)
                dataCatalogo.DataSource = dt

                'Obtenemos el texto almacenado en el portapapales 
                Dim s As String = Clipboard.GetText

                'hacemos un split para organizar la informacion por lineas 
                Dim lines As String() = s.Split(New Char(1) {ControlChars.Cr, ControlChars.Lf}, StringSplitOptions.RemoveEmptyEntries)
                Dim vdr(4) As Object
                'Ciclo para cada linea del copy 
                For Each line As String In lines
                    'Creamos una fila referenciando a la tabla datasource del DataGridView 
                    Dim dr As DataRow = dt.NewRow()

                    'Obtenemos las celdas que el usuario copia 
                    Dim cells As String() = line.Split(ControlChars.Tab)

                    'Burbuja para asignar cada uno de los datos de cada columna copia 

                    For Each cell As String In cells

                        'If j = 0 Then
                        '    dr.Item(j) = 0
                        'Else
                        'dr.Item(j) = cell
                        vdr(j) = cell
                        'End If
                        j = j + 1
                    Next
                    i = i + 1
                    j = 0
                    'Agregamos la fila a la tabla 
                    dt.Rows.Add(vdr)
                Next
                dataCatalogo.Refresh()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
    Private Sub p_inventario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'capturamos el separador decimal
        sepDecimal = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        Dim mes, anno As Integer
        mes = Month(pFechaActivaMax)
        anno = Year(pFechaActivaMax)
        cboMes.SelectedIndex = mes - 1
        cboAnno.SelectedIndex = anno - 2010
        'dataset almacen
        dsAlmacen.Tables.Add("almacen")
        Dim daAlmacen As New MySqlDataAdapter
        Dim comAlmacen As New MySqlCommand("select cod_alma,nom_alma from almacen where activo=1" _
                        & " and (es_invMensual) order by nom_alma", dbConex)
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
        muestraArea(cboAlmacen.SelectedValue)
        muestraCatalogo()
        estructuraInventario()
        muestraGrupo("not(esProduccion)")
        Dim mInventario As New Inventario
        muestraInventario()
        estaCargando = False
    End Sub
    Function periodoSeleccionado()
        Dim periodo As String = Trim(Str(cboAnno.SelectedIndex + 2010)) & Microsoft.VisualBasic.Right("00" & Trim(Str(cboMes.SelectedIndex + 1)), 2)
        Return periodo
    End Function
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
    Private Sub cboAlmacen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAlmacen.SelectedIndexChanged
        If Not estaCargando Then
            muestraArea(cboAlmacen.SelectedValue)
            muestraCatalogo()
            muestraInventario()
        End If
    End Sub
    Private Sub cboArea_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboArea.SelectedIndexChanged
        If Not estaCargando Then
            muestraInventario()
        End If
    End Sub
    Sub muestraInventario()
        dsInventario.Clear()
        Dim periodo As String = periodoSeleccionado()
        Dim esHistorial As Boolean = IIf(periodo = periodoActivo(), False, True)
        Dim xAlmacen As Boolean = IIf(cboAlmacen.SelectedIndex <> -1, True, False)
        Dim cAlmacen As String = cboAlmacen.SelectedValue
        Dim xArea As Boolean = IIf(cboArea.SelectedIndex <> -1, True, False)
        Dim cArea As String = cboArea.SelectedValue
        Dim xGrupo As Boolean = IIf(cboGrupo.SelectedIndex <> -1, True, False)
        Dim cGrupo As String = cboGrupo.SelectedValue
        Dim mInventario As New Inventario
        If mInventario.existInicial(esHistorial, periodo, cAlmacen, xArea, cArea) Then
            cmdIniciar.Enabled = False
        Else
            cmdIniciar.Enabled = True
        End If
        cmdIniciar.Enabled = True
        dsInventario = mInventario.recInicial(pEmpresa, esHistorial, periodo, xAlmacen, cAlmacen, xArea, cArea, xGrupo, cGrupo, False, "")
        dataInventario.DataSource = dsInventario.Tables("inventario").DefaultView
        _operacion = mInventario.devOperacionInicial(pEmpresa, esHistorial, periodo, cAlmacen, xArea, cArea)
        coloreaProducciones()
        dataInventario.Refresh()
        txtBuscar.Focus()
        lblRegistros.Text = "Nro de Registros..." & dataInventario.RowCount
    End Sub
    Private Sub cmdIniciar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdIniciar.Click
        Dim mInventario As New Inventario, cod_alma, tm As String
        Dim cArea As String = "0000"
        If cboArea.SelectedIndex >= 0 Then
            cArea = cboArea.SelectedValue
        End If
        Dim periodo As String = periodoSeleccionado()
        Dim esHistorial As Boolean = IIf(periodo = periodoActivo(), False, True)
        cod_alma = cboAlmacen.SelectedValue
        Dim xArea As Boolean = IIf(cboArea.SelectedIndex <> -1, True, False)
        If mInventario.existInicial(esHistorial, periodo, cod_alma, xArea, cboArea.SelectedValue) Then
            MessageBox.Show("Inventario ya Inicializado...", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim mIngreso As New Ingreso
            Dim cod_inv As String = "10"
            tm = "S"
            _operacion = mIngreso.maxOperacion
            'mIngreso.insertar                    (_operacion, cod_inv, "000", "00000001", "000", "00000000", 0, pFechaActivaMin, "00000000000", "00", cod_alma, cArea, True, False, pDecimales, "Inventario Inicial", tm, pTC, pCuentaUser, pmaquina)
            mIngreso.insertar_aux_his(esHistorial, periodo, _operacion, cod_inv, "000", "00000001",
              "000", "00000000", pFechaActivaMin, "00000000000", "00", cod_alma, cArea, True, False, pDecimales, "Inventario Inicial", tm, pTC, pCuentaUser)

            cmdIniciar.Enabled = False
            dsInventario.Clear()
            MessageBox.Show("Inventario Iniciado...", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtBuscar.Focus()
        End If
    End Sub
    Sub muestraArea(ByVal cod_alma As String)
        dsArea.Clear()
        Dim daArea As New MySqlDataAdapter
        Dim comArea As New MySqlCommand("select cod_area,nom_area from area where activo=1" _
                        & " and (es_invMensual) and cod_alma='" & cod_alma & "' order by nom_area", dbConex)
        daArea.SelectCommand = comArea
        daArea.Fill(dsArea, "area")
        With cboArea
            .DataSource = dsArea.Tables("area")
            .DisplayMember = dsArea.Tables("area").Columns("nom_area").ToString
            .ValueMember = dsArea.Tables("area").Columns("cod_area").ToString
            If dsArea.Tables("area").Rows.Count > 0 Then
                .SelectedIndex = 0
            Else
                .SelectedIndex = -1
            End If
        End With
    End Sub
    Sub muestraGrupo(ByVal Produccion As String)
        'dataset grupo
        dsGrupo.Clear()
        Dim daGrupo As New MySqlDataAdapter
        Dim cadG As String = "select cod_sgrupo,nom_sgrupo from subgrupo where activo=1" _
                    & " and " & Produccion & " order by nom_sgrupo"
        Dim comGrupo As New MySqlCommand(cadG, dbConex)
        daGrupo.SelectCommand = comGrupo
        daGrupo.Fill(dsGrupo, "grupo")
        With cboGrupo
            .DataSource = dsGrupo.Tables("grupo")
            .DisplayMember = dsGrupo.Tables("grupo").Columns("nom_sgrupo").ToString
            .ValueMember = dsGrupo.Tables("grupo").Columns("cod_sgrupo").ToString
            If dsGrupo.Tables("grupo").Rows.Count > 0 Then
                .SelectedIndex = -1
            End If
        End With
    End Sub
    Sub muestraCatalogo()
        Dim mCatalogo As New Catalogo
        Dim mAlmacen As New Almacen

        Dim cod_alma As String = mAlmacen.devuelveAlmacenCatalogo(cboAlmacen.SelectedValue)
        Dim xGrupo As Boolean = chkGrupo.Checked
        Dim cGrupo As String = cboGrupo.SelectedValue
        Dim soloProducciones As Boolean = Not chkBuscar.Checked
        ChkModoImp.Checked = False
        dsCatalogo.Clear()
        dsCatalogo = mCatalogo.recuperaCatalogo(pCatalogoXalmacen, cod_alma, True, False, False, xGrupo, cGrupo, False, soloProducciones, False)
        With dataCatalogo
            .DataSource = dsCatalogo.Tables("articulo").DefaultView
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_art").HeaderText = "Codigo"
            .Columns("cod_art").Width = 55
            .Columns("cod_art").ReadOnly = True
            .Columns("cod_art").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("nom_art").HeaderText = "Descripción"
            .Columns("nom_art").Width = 220
            .Columns("nom_art").ReadOnly = True
            .Columns("nom_uni").HeaderText = "Unidad"
            .Columns("nom_uni").Width = 70
            .Columns("nom_uni").ReadOnly = True
            .Columns("nom_uni").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cant_uni").Visible = False
            .Columns("nom_tart").Visible = False
            .Columns("pre_costo").Visible = False
            .Columns("pre_costoMax").Visible = False
            .Columns("pre_costoMin").Visible = False
            .Columns("pre_prom").Visible = False
            .Columns("cod_uni").Visible = False
            .Columns("pre_ult").Visible = False
            .Columns("pre_venta").Visible = False
            .Columns("pre_inc_imp").Visible = False
            .Columns("imp").Visible = False
            .Columns("cod_artExt").Visible = False
            .Columns("afecto_igv").Visible = False
            .Columns("maximo").Visible = False
            .Columns("minimo").Visible = False
            .Columns("cuenta_v").Visible = False
            .Columns("cuenta_v_C").Visible = False
            .Columns("cuenta_c").Visible = False
            .Columns("cuenta_c_P").Visible = False
            .Columns("cuenta_c_a1").Visible = False
            .Columns("cuenta_c_a2").Visible = False
            .Columns("cod_sgrupo").Visible = False
            .Columns("nom_sgrupo").Visible = False
            .Columns("esProduccion").Visible = False
            .Columns("activo").Visible = False
        End With
    End Sub
    Sub estructuraInventario()
        dsInventario = Inventario.dsInventario
        With dataInventario
            .DataSource = dsInventario.Tables("inventario").DefaultView
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_art").HeaderText = "Código"
            .Columns("cod_art").Width = 55
            .Columns("cod_art").ReadOnly = True
            .Columns("cod_art").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("nom_art").HeaderText = "Descripción"
            .Columns("nom_art").Width = 300
            .Columns("nom_art").ReadOnly = True
            .Columns("nom_uni").HeaderText = "Unidad"
            .Columns("nom_uni").Width = 65
            .Columns("nom_uni").ReadOnly = True
            .Columns("nom_uni").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cant_fis").HeaderText = "Físico"
            .Columns("cant_fis").Width = 70
            .Columns("cant_fis").ReadOnly = False
            .Columns("cant_fis").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("cant_fis").DefaultCellStyle.BackColor = Color.AliceBlue
            .Columns("precio").HeaderText = "Precio Costo"
            .Columns("precio").Width = 80
            .Columns("precio").ReadOnly = True
            .Columns("precio").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("nro_inv").Visible = False
            .Columns("ingreso").Visible = False
            .Columns("operacion").Visible = False
            .Columns("cod_sgrupo").Visible = False
            .Columns("nom_sgrupo").Visible = False
            .Columns("cod_alma").Visible = False
            .Columns("nom_alma").Visible = False
            .Columns("esProduccion").Visible = False
            .Columns("fec_inv").Visible = False
            .Columns("cod_inv").Visible = False
        End With
    End Sub
    Private Sub chkBuscar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBuscar.CheckedChanged
        If Not estaCargando Then
            If chkBuscar.Checked = True Then
                chkBuscar.Text = "Artículos"
            Else
                chkBuscar.Text = "Produccion"
            End If
            muestraCatalogo()
            txtBuscar.Focus()
        End If
    End Sub
    Private Sub txtBuscar_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscar.GotFocus
        If Not estaCargando Then
            txtBuscar.SelectAll()
        End If
    End Sub
    Private Sub txtBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscar.KeyPress
        If e.KeyChar = Chr(13) Then
            dataCatalogo.Focus()
        End If
    End Sub
    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged
        general.mayusculas(txtBuscar, txtBuscar.Text)
        Dim valor As String = txtBuscar.Text
        dsCatalogo.Tables("articulo").DefaultView.RowFilter = "nom_art LIKE '" & valor & "%'"
        If dataCatalogo.RowCount > 0 Then
            dataCatalogo.CurrentCell = dataCatalogo("nom_art", dataCatalogo.CurrentRow.Index)
        End If
    End Sub
    Private Sub chkModo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkModo.CheckedChanged
        If Not estaCargando Then
            If chkModo.Checked = True Then
                chkModo.Text = "Modo Añadir"
                txtBuscar.Focus()
            Else
                chkModo.Text = "Modo Edición"
                dataInventario.Focus()
            End If
        End If
    End Sub
    Private Sub optCodigo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optCodigo.CheckedChanged
        txtBuscarInventario.Focus()
    End Sub
    Private Sub optDescripcion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optDescripcion.CheckedChanged
        txtBuscarInventario.Focus()
    End Sub
    Private Sub txtBuscarinventario_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscarInventario.GotFocus
        txtBuscarInventario.SelectAll()
    End Sub
    Private Sub txtBuscarInventario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscarInventario.KeyPress
        If e.KeyChar = Chr(13) Then
            dataInventario.Focus()
        End If
    End Sub
    Private Sub txtBuscarinventario_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscarInventario.TextChanged
        Dim valor As String = txtBuscarInventario.Text
        If optCodigo.Checked = True Then
            dsInventario.Tables("inventario").DefaultView.RowFilter = "cod_art LIKE '" & valor & "%'"
            If dataInventario.RowCount > 0 Then
                dataInventario.CurrentCell = dataInventario("cod_art", dataInventario.CurrentRow.Index)
            End If
        Else
            dsInventario.Tables("inventario").DefaultView.RowFilter = "nom_art LIKE '" & valor & "%'"
            If dataInventario.RowCount > 0 Then
                dataInventario.CurrentCell = dataInventario("nom_art", dataInventario.CurrentRow.Index)
            End If
        End If
        coloreaProducciones()
    End Sub
    Private Sub chkGrupo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGrupo.CheckedChanged
        If Not estaCargando Then
            If chkGrupo.Checked = True Then
                If chkBuscar.Checked = True Then
                    muestraGrupo("not(esProduccion)")
                Else
                    muestraGrupo("(esProduccion)")
                End If
                cboGrupo.SelectedIndex = 0
                cboGrupo.Enabled = True
            Else
                cboGrupo.SelectedIndex = -1
                cboGrupo.Enabled = False
            End If
            End If
    End Sub
    Private Sub cboGrupo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboGrupo.SelectedIndexChanged
        If Not estaCargando Then
            muestraInventario()
            muestraCatalogo()
        End If
    End Sub

    Private Sub dataCatalogo_CellContextMenuStripNeeded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventArgs) Handles dataCatalogo.CellContextMenuStripNeeded

    End Sub
    Private Sub dataCatalogo_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dataCatalogo.DoubleClick
        If cmdIniciar.Enabled = False Then
            If dataCatalogo.RowCount > 0 Then
                If esEditable() Then
                    If ChkModoImp.Checked = False Then
                        txtBuscarInventario.Text = ""
                        insertaArticulo()
                        dataInventario.CurrentCell = dataInventario(dataInventario.Columns("cant_fis").Index, dataInventario.RowCount - 1)
                        dataInventario.Focus()
                    Else
                        Dim existe As Boolean, mCatalogo As New Catalogo, mAlmacen As New Almacen
                        Dim cod_art As String = dataCatalogo.Item("cod_art", dataCatalogo.CurrentRow.Index).Value
                        Dim cod_alma As String = cboAlmacen.SelectedValue
                        Dim cAlmaCatalogo As String = mAlmacen.devuelveAlmacenCatalogo(cod_alma)
                        existe = mCatalogo.existeCodigoCatalogo(cod_art, cAlmaCatalogo)
                        If existe Then
                            txtBuscarInventario.Text = ""
                            insertaArticuloImp()
                            dataInventario.Focus()
                        Else
                            MessageBox.Show("Código " & cod_art & " No Existe en Catalogo...", "ALMACEN", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        End If
                    End If
                End If
            End If
        Else
            MessageBox.Show("Por favor Inicilializar Inventario...", "ALMACEN", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If
    End Sub
    Private Sub dataCatalogo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dataCatalogo.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            If dataCatalogo.RowCount > 0 Then
                If esEditable() Then
                    txtBuscarInventario.Text = ""
                    insertaArticulo()
                    If dataInventario.RowCount > 0 Then
                        dataInventario.CurrentCell = dataInventario(dataInventario.Columns("cant_fis").Index, dataInventario.RowCount - 1)
                    End If
                    dataInventario.Focus()
                End If
            End If
        End If
    End Sub
    Sub insertaArticulo()
        If esEditable() Then
            If dataCatalogo.RowCount > 0 Then
                Dim periodo As String = periodoSeleccionado()
                Dim esHistorial As Boolean = IIf(periodo = periodoActivo(), False, True)
                Dim mIngreso As New Ingreso
                Dim nIngreso As Integer = mIngreso.maxIngresohis(esHistorial, periodo)
                Dim fila As DataRow = dsInventario.Tables("inventario").NewRow
                Dim cod_art As String = dataCatalogo.Item("cod_art", dataCatalogo.CurrentRow.Index).Value
                fila.Item("cod_art") = cod_art
                fila.Item("nom_art") = dataCatalogo.Item("nom_art", dataCatalogo.CurrentRow.Index).Value
                fila.Item("nom_uni") = dataCatalogo.Item("nom_uni", dataCatalogo.CurrentRow.Index).Value
                fila.Item("esProduccion") = dataCatalogo.Item("esProduccion", dataCatalogo.CurrentRow.Index).Value
                fila.Item("cod_sgrupo") = dataCatalogo.Item("cod_sgrupo", dataCatalogo.CurrentRow.Index).Value
                fila.Item("nom_sgrupo") = dataCatalogo.Item("nom_sgrupo", dataCatalogo.CurrentRow.Index).Value
                Dim pre_costo As Decimal = dataCatalogo.Item("pre_costo", dataCatalogo.CurrentRow.Index).Value
                fila.Item("precio") = pre_costo
                'fila.Item("cant_sis") = 0
                fila.Item("cant_fis") = 0
                fila.Item("operacion") = _operacion
                fila.Item("ingreso") = nIngreso
                dsInventario.Tables("inventario").Rows.Add(fila)
                mIngreso.insertar_det_his(esHistorial, periodo, _operacion, nIngreso, cod_art, 0, pre_costo, pIGV)
                'coloreaProducciones()
            End If
        End If
    End Sub
    Sub insertaArticuloImp()
        Dim periodo As String = periodoSeleccionado()
        Dim esHistorial As Boolean = IIf(periodo = periodoActivo(), False, True)
        If esEditable() Then
            If dataCatalogo.RowCount > 0 Then
                Dim mIngreso As New Ingreso
                Dim nIngreso As Integer = mIngreso.maxIngreso
                Dim mPrecio As New ePrecio
                Dim fila As DataRow = dsInventario.Tables("inventario").NewRow
                Dim cod_art As String = Trim(dataCatalogo.Item("cod_art", dataCatalogo.CurrentRow.Index).Value)
                fila.Item("cod_art") = cod_art
                fila.Item("nom_art") = dataCatalogo.Item("nom_art", dataCatalogo.CurrentRow.Index).Value
                fila.Item("nom_uni") = dataCatalogo.Item("nom_uni", dataCatalogo.CurrentRow.Index).Value
                Dim pre_costo As Decimal = mPrecio.devuelvePrecioCosto(cod_art)
                Dim cant As Decimal = dataCatalogo.Item("cantidad", dataCatalogo.CurrentRow.Index).Value
                fila.Item("precio") = pre_costo
                'fila.Item("cant_sis") = 0
                fila.Item("cant_fis") = cant
                fila.Item("operacion") = _operacion
                fila.Item("ingreso") = nIngreso

                If mIngreso.existeArticulo(_operacion, cod_art) Then
                    mIngreso.actualizaArticulo(_operacion, cod_art, cant, pre_costo)
                Else
                    dsInventario.Tables("inventario").Rows.Add(fila)
                    'mIngreso.insertar_det(_operacion, nIngreso, cod_art, cant, pre_costo, pCuentaUser, pIGV)
                    mIngreso.insertar_det_his(esHistorial, periodo, _operacion, nIngreso, cod_art, cant, pre_costo, pIGV)


                End If
            End If
        End If
    End Sub
    Sub recCantidadBotella(ByVal nCantidad As Decimal, ByVal recCantidad As Boolean)
        dataInventario(dataInventario.CurrentCell.ColumnIndex, dataInventario.CurrentRow.Index).Value = nCantidad
    End Sub
    Sub actualizaDetalle(ByVal afila As Integer, ByVal aingreso As Integer, ByVal acantidad As Decimal, ByVal acantsalida As Decimal, ByVal aprecio As Decimal, ByVal aigv As Decimal, ByVal asaldo As Decimal)
        Dim periodo As String = periodoSeleccionado()
        Dim esHistorial As Boolean = IIf(periodo = periodoActivo(), False, True)
        Dim mIngreso As New Ingreso
        'If asaldo >= 0 Then
        mIngreso.actualizaDetalleInv(esHistorial, periodo, aingreso, acantidad, aprecio, aigv, asaldo)
        'Else
        'mIngreso.actualizaDetalleInv(esHistorial, periodo, aingreso, acantidad, aprecio, aigv, 0)
        'dataInventario("cant_fis", afila).Value = acantsalida
        'MessageBox.Show("La Cantidad Mínima es: " + Str(acantsalida), "CEFE", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        'End If

    End Sub
    Sub coloreaProducciones()
        Dim I As Integer = 0
        For I = 0 To dataInventario.RowCount - 1
            If Not IsDBNull(dataInventario("cod_art", I).Value) Then
                If dataInventario("esProduccion", I).Value = True Then
                    dataInventario("cod_art", I).Style.ForeColor = Color.DarkBlue
                    dataInventario("nom_art", I).Style.ForeColor = Color.DarkBlue
                    dataInventario("nom_uni", I).Style.ForeColor = Color.DarkBlue
                    dataInventario("precio", I).Style.ForeColor = Color.DarkBlue
                    dataInventario("cant_fis", I).Style.ForeColor = Color.DarkBlue
                End If
            End If
        Next
    End Sub
    Function esEditable() As Boolean
        'Dim mIngreso As New Ingreso, fechaInv As Date
        'If periodoSeleccionado() = periodoActivo() Then
        'fechaInv = mIngreso.devuelveFechaInventario(_operacion)
        'If fechaInv.AddDays(pDiasModificarInventario) > pFechaSystem Then
        '    dataInventario.Columns("cant_fis").ReadOnly = False
        '    Return True
        'Else
        '    dataInventario.Columns("cant_fis").ReadOnly = True
        '    Return False
        'End If
        'Else
        '    dataInventario.Columns("cant_fis").ReadOnly = False
        '    Return False
        'End If
        dataInventario.Columns("cant_fis").ReadOnly = False
        Return True
    End Function
    Private Sub dataInventario_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataInventario.CellDoubleClick
        If esEditable() Then
            If dataInventario.CurrentCell.ColumnIndex <> dataInventario.Columns("cant_fis").Index Then
                eliminaITEM()
            End If
        End If
    End Sub
    Private Sub dataInventario_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataInventario.CellEndEdit
        ' If dataInventario.CurrentCell.ColumnIndex = (dataInventario.Columns("cant_fis").Index Or dataInventario.Columns("precio").Index) Then
        Dim mIngreso As New Ingreso, mCatalogo As New Catalogo, cantidad As Decimal
        Dim ifila As Integer = dataInventario.CurrentRow.Index
        Dim nIngreso As Integer = dataInventario("ingreso", ifila).Value
        'validamos el ingreso de cantidades no nulas
        If IsDBNull(dataInventario("cant_fis", ifila).Value) Then
            cantidad = 0
            dataInventario("cant_fis", ifila).Value = 0
        Else
            cantidad = dataInventario("cant_fis", ifila).Value
        End If
        Dim mAlmacen As New Almacen, mUnidad As New Unidad
        Dim cod_artAlma As String = dataInventario("cod_art", ifila).Value
        Dim codigo As String = mAlmacen.devuelveCodigoArtPrinRelacionado(cod_artAlma)
        Dim unidad As String = mUnidad.devuelveUnidad(codigo)
        Dim esBotella As Boolean = mUnidad.esBotella(unidad)
        Dim precio As Decimal = dataInventario("precio", ifila).Value
        'Dim cantSalida As Decimal = mIngreso.devSalidasDelIngreso(nIngreso)
        Dim saldo As Decimal = cantidad
        actualizaDetalle(ifila, nIngreso, cantidad, 0, precio, pIGV, saldo)
        dataInventario.ClearSelection()
        If chkModo.Checked = True Then
            txtBuscar.Focus()
        End If
        'End If
    End Sub
    Private Sub dataInventario_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dataInventario.EditingControlShowing
        'referenciamos la celda
        Dim validar As TextBox = CType(e.Control, TextBox)
        'agregamos el controlador de eventos para el evento KeyPress
        AddHandler validar.KeyPress, AddressOf validar_KeyPress
    End Sub
    Private Sub dataInventario_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dataInventario.KeyDown
        If esEditable() Then
            If e.KeyCode = Keys.Delete Then
                e.SuppressKeyPress = True
                eliminaITEM()
            End If
            If e.KeyCode = Keys.Enter Then
                dataInventario.ClearSelection()
                txtBuscar.Focus()
            End If
        End If
        If (e.Control And e.KeyCode = Keys.E) Then
            If dataInventario.RowCount > 0 Then
                EnviaraExcel(dataInventario)
            End If
        End If
    End Sub
    Private Sub validar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        'obtenemos el indice de la columna
        Dim columna As Integer = dataInventario.CurrentCell.ColumnIndex
        If columna = dataInventario.Columns("cant_fis").Index Then
            If Not Char.IsNumber(e.KeyChar) And Not (e.KeyChar = ChrW(Keys.Back)) And Not (e.KeyChar.Equals(sepDecimal)) Then
                e.KeyChar = ""
            End If
        End If
    End Sub
    Sub eliminaITEM()
        Dim rpta As Integer
        If Not IsDBNull(dataInventario("ingreso", dataInventario.CurrentRow.Index).Value) Then
            Dim mIngreso As New Ingreso
            Dim nIngreso As Integer = dataInventario("ingreso", dataInventario.CurrentRow.Index).Value
            Dim yaSalio As Integer = mIngreso.existeSalida(nIngreso, False)
            'If yaSalio Then
            '    MessageBox.Show("El Registro Tiene Salidas, NO es Posible Eliminarlo...", "CEFE", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            'Else
            rpta = MessageBox.Show("Esta Seguro de Eliminar el ITEM Seleccionado" + Chr(13) +
                    "Este Proceso es Irreversible...", "SGA", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2)
            If rpta = 6 Then
                mIngreso.eliminaDetalle(nIngreso)
                'Dim mfila As DataRow = dsInventario.Tables("inventario").Rows(dataInventario.CurrentRow.Index)
                'dsInventario.Tables("inventario").Rows.Remove(mfila)
                dataInventario.Rows.Remove(dataInventario.CurrentRow)
            End If
            'End If
        Else
            rpta = MessageBox.Show("Esta Seguro de Eliminar el ITEM Seleccionado" + Chr(13) + _
                    "Este Proceso es Irreversible...", "CEFE", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2)
            If rpta = 6 Then
                Dim mfila As DataRow = dsInventario.Tables("inventario").Rows(dataInventario.CurrentRow.Index)
                dsInventario.Tables("inventario").Rows.Remove(mfila)
            End If
        End If
    End Sub
    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        Dim periodoReporte As String = "Periodo: " & general.periodo_mesAnnoLetras(periodoSeleccionado)
        Dim fechaReporte As String = general.devuelveFechaImpresionEspecificado(pFechaActivaMin)
        Dim xAlmacen As Boolean = IIf(cboAlmacen.SelectedIndex >= 0, True, False)
        Dim xArea As Boolean = IIf(cboArea.SelectedIndex >= 0, True, False)
        Dim xGrupo As Boolean = IIf(chkResumenGrupo.Checked = True, True, False)
        'Dim rptxAlmacen As Boolean = IIf(pCatalogoXalmacen, True, False)
        Dim frm As New rptForm
        If optFormatos.Checked = True Then
            Dim ds As New DataSet
            Dim mInventario As New Inventario
            'Dim mAlmacen As New Almacen
            'Dim almaP As String = mAlmacen.devuelveAlmacenPrincipal()
            'If almaP = cboAlmacenRegistro.SelectedValue Then
            ds = mInventario.recuperaFormatosInvInicial(xAlmacen, cboAlmacen.SelectedValue, xArea, cboArea.SelectedValue, True)
            frm.cargarInventarioFormatos(ds, cboAlmacen.Text & " - " & cboArea.Text, periodoReporte)
        End If
        If optRepAlmacen.Checked = True Then
            Dim ds As New DataSet
            Dim mInventario As New Inventario
            ds = mInventario.recInicial(pEmpresa, False, periodoSeleccionado, xAlmacen, cboAlmacen.SelectedValue, False, "", False, "", False, "")
            frm.cargarInventarioInicial(ds, "Almacén: " & cboAlmacen.Text, fechaReporte, periodoReporte, True, cboAlmacen.SelectedValue, xGrupo)
        End If
        If optRepAlmacen_area.Checked = True Then
            frm.cargarInventarioInicial(dsInventario, cboAlmacen.Text & " - " & cboArea.Text, fechaReporte, periodoReporte, False, "", xGrupo)
        End If
        frm.MdiParent = principal
        frm.Show()
    End Sub
    Private Sub cmdCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCerrar.Click
        Me.Close()
    End Sub
    Private Sub cmdActualizaCostos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdActualizaCostos.Click
        'If dataInventario.RowCount > 0 Then
        '    Dim I, nIngreso As Integer, cod_art As String, nCosto As Decimal
        '    Dim mPrecio As New ePrecio
        '    Dim mInventario As New Inventario
        '    Dim ds As New DataSet
        '    For I = 0 To dataInventario.RowCount - 1
        '        cmdActualizaCostos.Text = I & " de " & dataInventario.RowCount
        '        cmdActualizaCostos.Refresh()
        '        cod_art = dataInventario("cod_art", I).Value
        '        nIngreso = dataInventario("ingreso", I).Value
        '        nCosto = mPrecio.devuelvePrecioCosto(cod_art)
        '        mPrecio.actualizaCosto_invInventario(cod_art, nCosto, nIngreso)
        '    Next
        '    cmdActualizaCostos.Text = "Actualiza Costos"
        'End If
        'MessageBox.Show("Finalizado")
        'dataInventario.Focus()
    End Sub



    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Private Sub dataInventario_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dataInventario.DoubleClick
        If dataInventario.CurrentCell.ColumnIndex = dataInventario.Columns("cant_fis").Index Then
            Dim mIngreso As New Ingreso, mCatalogo As New Catalogo, cantidad As Decimal
            Dim ifila As Integer = dataInventario.CurrentRow.Index
            Dim nIngreso As Integer = dataInventario("ingreso", ifila).Value
            'validamos el ingreso de cantidades no nulas
            If IsDBNull(dataInventario("cant_fis", ifila).Value) Then
                cantidad = 0
                dataInventario("cant_fis", ifila).Value = 0
            Else
                cantidad = dataInventario("cant_fis", ifila).Value
            End If
            Dim mAlmacen As New Almacen, mUnidad As New Unidad
            Dim cod_artAlma As String = dataInventario("cod_art", ifila).Value
            Dim codigo As String = mAlmacen.devuelveCodigoArtPrinRelacionado(cod_artAlma)
            Dim unidad As String = mUnidad.devuelveUnidad(codigo)
            Dim esBotella As Boolean = mUnidad.esBotella(unidad)
            Dim precio As Decimal = dataInventario("precio", ifila).Value
            Dim cantSalida As Decimal = mIngreso.devSalidasDelIngreso(nIngreso)
            Dim saldo As Decimal = cantidad - cantSalida
            'If esBotella Then
            Dim cant_uni As Decimal = mUnidad.devCantUnidad(codigo)
            Dim nBotCerrada As Decimal = mCatalogo.devPesoBotellaCerrada(codigo)
            Dim nBotAbierta As Decimal = mCatalogo.devPesoBotellaAbierta(codigo)
            Dim IsFormCargado As Boolean = False
            Dim mForm As Form
            For Each mForm In principal.MdiChildren
                If mForm.Name = "p_botellas" Then
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
            'para saber si recuperamos de la botella contada
            _recCantidad = False
            If IsFormCargado = False Then
                p_botellas.MdiParent = principal
                p_botellas.lblProducto.Text = dataInventario("nom_art", ifila).Value
                p_botellas.datosBotellas(cant_uni, nBotCerrada, nBotAbierta, nIngreso, precio, saldo)
                p_botellas.txtBotCerrada.Focus()
                p_botellas.Show()
            Else
                p_botellas.lblProducto.Text = dataInventario("nom_art", ifila).Value
                p_botellas.Activate()
            End If
            p_botellas.txtBotCerrada.Focus()
            'End If
            dataInventario.ClearSelection()
        End If
    End Sub


    Private Sub ChkModoImp_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkModoImp.CheckedChanged
        If ChkModoImp.Checked Then
            cmdInsertar.Visible = True
            lblinsertar.Visible = True
        Else
            cmdInsertar.Visible = False
            lblinsertar.Visible = False
        End If
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim M As Integer
        Dim existe As Boolean, mCatalogo As New Catalogo, mAlmacen As New Almacen
        Dim cod_alma As String = cboAlmacen.SelectedValue
        Dim cAlmaCatalogo As String = mAlmacen.devuelveAlmacenCatalogo(cod_alma)

        If dataCatalogo.RowCount > 0 Then
            For M = 0 To dataCatalogo.RowCount - 1
                'En tu boton para avanzar
                'If (dataCatalogo.CurrentRow + 1) < dataCatalogo.VisibleRowCount Then
                '    dataCatalogo.SelectAllSignVisible(dataCatalogo.CurrentRow + 1)
                'End If
                'Dim fila As Integer = dataCatalogo.CurrentRow.Index
                Dim cod_art As String = dataCatalogo.Item("cod_art", M).Value
                existe = mCatalogo.existeCodigoCatalogo(cod_art, cAlmaCatalogo)
                dataCatalogo.CurrentCell = dataCatalogo.Rows(M).Cells(0)
                If existe Then
                    txtBuscarInventario.Text = ""
                    insertaArticuloImp()
                    dataInventario.Focus()
                Else
                    MessageBox.Show("Código " & cod_art & " No Existe en Catalogo...", "ALMACEN", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                End If
            Next
        End If



    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdInsertar.Click
        Dim M As Integer
        Dim existe As Boolean, mCatalogo As New Catalogo, mAlmacen As New Almacen
        Dim cod_alma As String = cboAlmacen.SelectedValue
        Dim cAlmaCatalogo As String = mAlmacen.devuelveAlmacenCatalogo(cod_alma)

        If dataCatalogo.RowCount > 0 Then
            For M = 0 To dataCatalogo.RowCount - 1
                'En tu boton para avanzar
                'If (dataCatalogo.CurrentRow + 1) < dataCatalogo.VisibleRowCount Then
                '    dataCatalogo.SelectAllSignVisible(dataCatalogo.CurrentRow + 1)
                'End If
                'Dim fila As Integer = dataCatalogo.CurrentRow.Index
                Dim cod_art As String = dataCatalogo.Item("cod_art", M).Value
                existe = mCatalogo.existeCodigoCatalogo(Trim(cod_art), cAlmaCatalogo)
                dataCatalogo.CurrentCell = dataCatalogo.Rows(M).Cells(0)
                If existe Then
                    txtBuscarInventario.Text = ""
                    insertaArticuloImp()
                    dataInventario.Focus()
                Else
                    MessageBox.Show("Código " & cod_art & " No Existe en Catalogo...", "ALMACEN", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                End If


            Next
        End If
        muestraInventario()
    End Sub


    Private Sub cmdEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEliminar.Click
        Dim resp, result As Integer
        Dim sql As String
        Dim periodo As String = periodoSeleccionado()
        Dim esHistorial As Boolean = IIf(periodo = periodoActivo(), False, True)
        resp = MessageBox.Show("Esta Seguro de Eliminar el Inventario Seleccionado" + Chr(13) +
                    "Este Proceso es Irreversible...", "ALMACEN", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2)

        If Not (esHistorial) Then
            If resp = 6 Then
                Try
                    sql = "delete from ingreso where cod_doc='10' and operacion=" & _operacion
                    Dim com As New MySqlCommand(sql, dbConex)
                    result = com.ExecuteNonQuery()

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If

        Else
            If resp = 6 Then
                Try
                    sql = "delete from h_ingreso where operacion=" & _operacion & " and proceso='" & periodo & "'"
                    Dim com As New MySqlCommand(sql, dbConex)
                    result = com.ExecuteNonQuery()

                    sql = "delete from h_ingreso_det where operacion=" & _operacion & " and proceso='" & periodo & "'"
                    Dim com1 As New MySqlCommand(sql, dbConex)
                    result = com1.ExecuteNonQuery()


                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If


            'MessageBox.Show("No puede Eliminar Inventario Cerrado...", "ALMACEN", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If

        If Not estaCargando Then
            muestraInventario()
        End If
    End Sub

    Private Sub dataCatalogo_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataCatalogo.CellContentClick

    End Sub

    Private Sub dataInventario_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataInventario.CellContentClick

    End Sub
End Class
