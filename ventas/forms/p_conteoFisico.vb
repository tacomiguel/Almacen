Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Math
Imports libreriaClases
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class p_conteoFisico
    Private dsConteo As New DataSet
    Private dsAlmacen As New DataSet
    Private dsArea As New DataSet
    Private dsGrupo As New DataSet
    'para validar el separador decimal
    Private sepDecimal As Char
    Private estaCargando As Boolean = True
    Private _dia As String
    Private _cantContada As Decimal = 0
    Private _recCantidad As Boolean = False
    Private Sub p_conteofisico_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        principal.mp_invDiario.Enabled = True
    End Sub
    Private Sub p_conteofisico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'capturamos el separador decimal
        sepDecimal = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        Dim mes, anno As Integer
        mes = Month(pFechaActivaMax)
        anno = Year(pFechaActivaMax)
        cboMes.SelectedIndex = mes - 1
        cboAnno.SelectedIndex = anno - 2010
        dtiDia.Value = Microsoft.VisualBasic.DateAdd(DateInterval.Day, -1, pFechaSystem)
        dtiDia.MaxDate = pFechaSystem
        dtiDia.MinDate = Microsoft.VisualBasic.DateAdd(DateInterval.Day, -1, pFechaSystem)
        'dataset almacen
        Dim cadAlma As String
        If pAlmaUser = "0000" Then
            cadAlma = "select cod_alma,nom_alma from almacen where (esProduccion) and activo=1"
        Else
            cadAlma = "select cod_alma,nom_alma from almacen where cod_alma='" & pAlmaUser & "'" _
                    & " and (esProduccion) and activo=1"
        End If
        Dim daAlmacen As New MySqlDataAdapter
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
        dsArea.Tables.Add("area")
        muestraArea(cboAlmacen.SelectedValue)
        Dim mInventario As New Inventario
        Dim cArea As String = "0000"
        If cboArea.SelectedIndex >= 0 Then
            cArea = cboArea.SelectedValue
        End If
        'dataset grupo
        Dim daGrupo As New MySqlDataAdapter
        Dim cadG As String = "select cod_sgrupo,nom_sgrupo from subgrupo where activo=1" _
                    & " and not(esProduccion) order by nom_sgrupo"
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
        _dia = Microsoft.VisualBasic.DateAndTime.Day(dtiDia.Value)
        estaCargando = False
        muestraConteo()
    End Sub
    Function periodoSeleccionado()
        Dim periodo As String = Trim(Str(cboAnno.SelectedIndex + 2005)) & Microsoft.VisualBasic.Right("00" & Trim(Str(cboMes.SelectedIndex + 1)), 2)
        Return periodo
    End Function
    Private Sub cboMes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMes.SelectedIndexChanged
        If Not estaCargando Then
            muestraConteo()
        End If
    End Sub
    Private Sub cboAnno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAnno.SelectedIndexChanged
        If Not estaCargando Then
            muestraConteo()
        End If
    End Sub
    Private Sub dtiDia_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtiDia.ValueChanged
        _dia = Microsoft.VisualBasic.DateAndTime.Day(dtiDia.Value)
        muestraConteo()
    End Sub
    Private Sub cboAlmacen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAlmacen.SelectedIndexChanged
        If Not estaCargando Then
            Dim mInventario As New Inventario
            Dim cArea As String = "0000"
            If chkArea.Checked = True Then
                muestraArea(cboAlmacen.SelectedValue)
            End If
            muestraConteo()
        End If
    End Sub
    Private Sub cboArea_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboArea.SelectedIndexChanged
        If Not estaCargando Then
            Dim mInventario As New Inventario
            'Dim cArea As String = "0000"
            muestraConteo()
        End If
    End Sub
    Private Sub chkArea_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkArea.CheckedChanged
        If Not estaCargando Then
            'If chkArea.Checked = True Then
            '    cboArea.Enabled = True
            '    cboArea.SelectedIndex = 0
            'Else
            '    cboArea.SelectedIndex = -1
            '    cboArea.Enabled = False
            'End If
            chkArea.Checked = True
            muestraConteo()
        End If
    End Sub
    Sub muestraArea(ByVal cod_alma As String)
        dsArea.Clear()
        Dim daArea As New MySqlDataAdapter
        Dim comArea As New MySqlCommand("select cod_area,nom_area from area where activo=1" _
                        & " and (es_invDiario) and cod_alma='" & cod_alma & "' order by nom_area", dbConex)
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
    Sub muestraConteo()
        dsConteo.Clear()
        Dim mInventario As New Inventario
        Dim xAlmacen As String = IIf(cboAlmacen.SelectedIndex <> -1, True, False)
        Dim xArea As String = IIf(cboArea.SelectedIndex <> -1, True, False)
        Dim xGrupo As String = IIf(cboGrupo.SelectedIndex <> -1, True, False)
        dsConteo = mInventario.recConteo(False, "", True, pFechaSystem, pFechaSystem, cboAlmacen.SelectedValue, _
            xArea, cboArea.SelectedValue, xGrupo, cboGrupo.SelectedValue)
        estructuraConteo()
    End Sub
    Sub estructuraConteo()
        Dim I As Integer = 1, col As String
        Dim inicio, final As Integer
        final = Microsoft.VisualBasic.DateAndTime.Day(dtiDia.Value)
        If final > 7 Then
            inicio = final - 6
        Else
            inicio = 1
        End If
        With datos
            .DataSource = dsConteo.Tables("conteo").DefaultView
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("operacion").Visible = False
            .Columns("conteo").Visible = False
            .Columns("cod_art").HeaderText = "Codigo"
            .Columns("cod_art").Width = 55
            .Columns("cod_art").ReadOnly = True
            .Columns("cod_art").DefaultCellStyle.BackColor = Color.AliceBlue
            .Columns("nom_art").HeaderText = "Articulo"
            .Columns("nom_art").Width = 250
            .Columns("nom_art").ReadOnly = True
            .Columns("nom_art").DefaultCellStyle.BackColor = Color.AliceBlue
            .Columns("nom_uni").HeaderText = "Unidad"
            .Columns("nom_uni").Width = 60
            .Columns("nom_uni").ReadOnly = True
            .Columns("nom_uni").DefaultCellStyle.BackColor = Color.AliceBlue
            .Columns("es_botella").Visible = False
            .Columns("peso_lleno").Visible = False
            .Columns("peso_vacio").Visible = False
            For I = 1 To 31
                col = "d" & I
                .Columns(col).Visible = False
                .Columns(col).ReadOnly = True
            Next
            For I = inicio To final
                'habilitamos el dia seleccionado
                col = "d" & I
                .Columns(col).HeaderText = col
                .Columns(col).Width = 70
                .Columns(col).Visible = True
                .Columns(col).DefaultCellStyle.BackColor = Color.White
                .Columns(col).DefaultCellStyle.ForeColor = Color.Black
                If I = final Then
                    .Columns(col).ReadOnly = False
                    .Columns(col).DefaultCellStyle.BackColor = Color.Blue
                    .Columns(col).DefaultCellStyle.ForeColor = Color.White
                End If
                .Columns(col).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Next
        End With
    End Sub
    Private Sub datos_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datos.CellEndEdit
        Dim mInventario As New Inventario
        If IsDBNull(datos("cod_art", datos.CurrentRow.Index).Value) Then
            MessageBox.Show("NO Existe Producto para Registrar Conteo Físico..", "CEFE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            datos("cod_art", datos.CurrentRow.Index).Value = ""
        Else
            Dim nCantidad As Decimal, nConteo As Integer, cDia As String
            cDia = datos.Columns(datos.CurrentCell.ColumnIndex).HeaderText
            nConteo = datos("conteo", datos.CurrentRow.Index).Value
            If IsDBNull(datos(datos.CurrentCell.ColumnIndex, datos.CurrentRow.Index).Value) Then
                nCantidad = 0
                datos(datos.CurrentCell.ColumnIndex, datos.CurrentRow.Index).Value = 0
            Else
                nCantidad = datos(datos.CurrentCell.ColumnIndex, datos.CurrentRow.Index).Value
            End If
            mInventario.actConteo(nConteo, nCantidad, cDia)
        End If
    End Sub
    Private Sub datos_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles datos.EditingControlShowing
        'referenciamos la celda
        Dim validar As TextBox = CType(e.Control, TextBox)
        'agregamos el controlador de eventos para el evento KeyPress
        AddHandler validar.KeyPress, AddressOf validar_KeyPress
    End Sub
    Private Sub datos_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles datos.KeyDown
        If datos.CurrentCell.ColumnIndex = datos.Columns("d" & _dia).Index  Then
            If e.KeyCode = Keys.Enter And chkRegistrarBotellas.Checked = True Then
                Dim mAlmacen As New Almacen, mUnidad As New Unidad, mCatalogo As New Catalogo
                Dim cod_artAlma As String = datos("cod_art", datos.CurrentRow.Index).Value
                Dim conteo As Integer = datos("conteo", datos.CurrentRow.Index).Value
                Dim codigo As String = mAlmacen.devuelveCodigoArtPrinRelacionado(cod_artAlma)
                Dim unidad As String = mUnidad.devuelveUnidad(codigo)
                Dim esBotella As Boolean = mUnidad.esBotella(unidad)
                If esBotella Then
                    e.SuppressKeyPress = True
                    If Len(codigo) = 0 Then
                        MessageBox.Show("NO esta definida la Capacidad de la Botella...", "CEFE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
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
                            p_botellas.lblProducto.Text = datos("nom_art", datos.CurrentRow.Index).Value
                            'p_botellas.datosBotellas(cant_uni, nBotCerrada, nBotAbierta)
                            p_botellas.txtBotCerrada.Focus()
                            p_botellas.Show()
                        Else
                            p_botellas.lblProducto.Text = datos("nom_art", datos.CurrentRow.Index).Value
                            p_botellas.Activate()
                        End If
                        p_botellas.txtBotCerrada.Focus()
                    End If
                End If
            Else
                If e.KeyCode = Keys.Enter Then
                    e.SuppressKeyPress = True
                    txtBuscar.Focus()
                End If
            End If
        Else
            If e.KeyCode = Keys.Enter Then
                e.SuppressKeyPress = True
                txtBuscar.Focus()
            End If
        End If
    End Sub
    Private Sub validar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles datos.KeyPress
        'obtenemos el indice de la columna
        If datos.RowCount > 0 Then
            Dim columna As Integer = datos.CurrentCell.ColumnIndex
            If Not (columna = datos.Columns("cod_art").Index Or columna = datos.Columns("nom_art").Index Or columna = datos.Columns("nom_uni").Index) Then
                If Not Char.IsNumber(e.KeyChar) And Not (e.KeyChar = ChrW(Keys.Back)) And Not (e.KeyChar.Equals(sepDecimal)) Then
                    e.KeyChar = "0"
                End If
            End If
        End If
    End Sub
    Private Sub cmdCargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim mCatalogo As New Catalogo, mInventario As New Inventario
        Dim cod_alma As String = cboAlmacen.SelectedValue
        Dim cod_area As String = cboArea.SelectedValue
        Dim periodo As String = periodoSeleccionado()
        Dim existe As Boolean
        existe = mInventario.existConteo(periodo, cod_alma, cod_area)
        If existe Then
            MessageBox.Show("Ya se Genero Conteo para el Almacén y Area seleccionada...", "CEFE", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim cod_art As String, I As Integer
            Dim nOperacion As Integer, graboCabecera As Boolean = False, nConteo As Integer
            Dim ds As New DataSet
            ds = mCatalogo.recuperaCatalogo(pCatalogoXalmacen, cod_alma, True, False, True, False, "", False, False, False)
            nOperacion = mInventario.maxOperacionConteo
            For I = 0 To ds.Tables("articulo").Rows.Count - 1
                If Not graboCabecera Then
                    mInventario.insertar_conteo(nOperacion, periodo, cod_alma, cod_area)
                    graboCabecera = True
                End If
                cod_art = ds.Tables("articulo").Rows(I).Item("cod_art").ToString
                nConteo = mInventario.maxConteo
                mInventario.insertar_conteo_det(nOperacion, nConteo, cod_art)
            Next
            MessageBox.Show("Proceso Finalizado...", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub txtBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscar.KeyPress
        If e.KeyChar = Chr(13) Then
            Dim cDia As String = "d" & Microsoft.VisualBasic.Day(dtiDia.Value)
            datos.CurrentCell = datos(datos.Columns(cDia).Index, datos.RowCount - 1)
            datos.Focus()
        End If
    End Sub
    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged
        If Not estaCargando Then
            Dim cTexto As String = txtBuscar.Text
            dsConteo.Tables("conteo").DefaultView.RowFilter = "nom_art LIKE '" & cTexto & "%'"
        End If
    End Sub
    Sub calculaCantidad()
        If datos.RowCount > 0 Then
            Dim mInventario As New Inventario
            If IsDBNull(datos("cod_art", datos.CurrentRow.Index).Value) Then
                MessageBox.Show("NO Existe Producto para Registrar Conteo Físico..", "CEFE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                datos("cod_art", datos.CurrentRow.Index).Value = ""
            Else
                Dim nConteo As Integer, cDia As String, nCantidad As Decimal
                cDia = datos.Columns(datos.CurrentCell.ColumnIndex).HeaderText
                nConteo = datos("conteo", datos.CurrentRow.Index).Value
                If IsDBNull(datos(datos.CurrentCell.ColumnIndex, datos.CurrentRow.Index).Value) Then
                    nCantidad = 0
                    datos(datos.CurrentCell.ColumnIndex, datos.CurrentRow.Index).Value = 0
                Else
                    nCantidad = datos(datos.CurrentCell.ColumnIndex, datos.CurrentRow.Index).Value
                End If
                mInventario.actConteo(nConteo, nCantidad, cDia)
            End If
        End If
    End Sub
    Sub recCantidadBotella(ByVal nCantidad As Decimal, ByVal recCantidad As Boolean)
        _cantContada = nCantidad
        _recCantidad = recCantidad
        datos(datos.CurrentCell.ColumnIndex, datos.CurrentRow.Index).Value = _cantContada
    End Sub

    Private Sub cboGrupo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboGrupo.SelectedIndexChanged
        If Not estaCargando Then
            muestraConteo()
        End If
    End Sub

    Private Sub chkGrupo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGrupo.CheckedChanged
        If Not estaCargando Then
            If chkGrupo.Checked = True Then
                cboGrupo.Enabled = True
                cboGrupo.SelectedIndex = 0
            Else
                cboGrupo.SelectedIndex = -1
                cboGrupo.Enabled = False
            End If
        End If
    End Sub

    Private Sub chkRegistrarBotellas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkRegistrarBotellas.CheckedChanged

    End Sub
End Class

