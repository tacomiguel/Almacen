Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Math
Imports libreriaClases
Public Class c_recetas
    Private dsAlmacenR As New DataSet
    Private dsRecetasR As New DataSet
    Private dsRecetaRa As New DataSet
    Private dsRecetaRb As New DataSet
    Private dsRecetaRc As New DataSet
    Private dsRecetaRd As New DataSet
    Private dsCatalogo As New DataSet
    Private dsCatalogo1 As New DataSet
    Private dsProduccion As New DataSet
    Private dsAlmacen As New DataSet
    Private dsRecetas As New DataSet
    Private estaCargando As Boolean = True
    'para validar el separador decimal
    Private sepDecimal As Char
    Private Sub c_recetas_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        principal.mr_recetas.Enabled = True
    End Sub
    Private Sub c_recetas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Top = 0
        Me.Left = 0
        'capturamos el separador decimal
        sepDecimal = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        'dataset almacen R
        Dim daAlmacenR As New MySqlDataAdapter
        Dim cadAlmaR As String
        If pCatalogoXalmacen Then
            If pAlmaUser = "0000" Then
                cadAlmaR = "select cod_alma,nom_alma from almacen where (esProduccion) and activo=1"
            Else
                cadAlmaR = "select cod_alma,nom_alma from almacen where cod_alma='" & pAlmaUser & "' and (esProduccion) and activo=1"
            End If
        Else
            cadAlmaR = "select cod_alma,nom_alma from almacen where (esProduccion) and activo=1"
        End If
        Dim comAlmacenR As New MySqlCommand(cadAlmaR, dbConex)
        daAlmacenR.SelectCommand = comAlmacenR
        daAlmacenR.Fill(dsAlmacenR, "almacen")
        With cboAlmacenR
            .DataSource = dsAlmacenR.Tables("almacen")
            .DisplayMember = dsAlmacenR.Tables("almacen").Columns("nom_alma").ToString
            .ValueMember = dsAlmacenR.Tables("almacen").Columns("cod_alma").ToString
            If dsAlmacenR.Tables("almacen").Rows.Count > 0 Then
                .SelectedIndex = 0
            End If
        End With
        'dataset sub grupo
        Dim cCampo As String = "nom_sgrupo"
        'dtSGrupo = dsProduccion.Tables("subgrupo")
        Dim daSGrupo As New MySqlDataAdapter
        Dim comSGrupo As New MySqlCommand("select cod_sgrupo," & general.convierte_enTitulo(cCampo) _
            & " as nom_sgrupo from subgrupo where activo=1 and (esProduccion) order by nom_sgrupo", dbConex)
        daSGrupo.SelectCommand = comSGrupo
        daSGrupo.Fill(dsProduccion, "subgrupo")
        With cboGrupo
            .DataSource = dsProduccion.Tables("subgrupo")
            .DisplayMember = dsProduccion.Tables("subgrupo").Columns("nom_sgrupo").ToString
            .ValueMember = dsProduccion.Tables("subgrupo").Columns("cod_sgrupo").ToString
            If dsProduccion.Tables("subgrupo").Rows.Count > 0 Then
                .SelectedIndex = -1
            End If
        End With

        muestraRecetasR()
        'cargamos el catalogo en funcion al modo de trabajo
        'catalogo x almacen de produccion o unico catalogo
        'si se trabaja en modo catalogo x almacen
        Dim cadAlma As String
        If pCatalogoXalmacen Then
            lblAlmacen.Visible = True
            cboAlmacen.Visible = True
            If pAlmaUser = "0000" Then
                cadAlma = "select cod_alma,nom_alma from almacen where (esProduccion) and activo=1"
            Else
                cadAlma = "select cod_alma,nom_alma from almacen where cod_alma='" & pAlmaUser & "' and (esProduccion) and activo=1"
            End If
        Else
            cadAlma = "select cod_alma,nom_alma from almacen where cod_alma='" & pAlmaUser & "'"
        End If
        Dim comAlmacen As New MySqlCommand(cadAlma, dbConex)
        Dim daAlmacen As New MySqlDataAdapter
        daAlmacen.SelectCommand = comAlmacen
        daAlmacen.Fill(dsAlmacen, "almacen")
        With cboAlmacen
            .DataSource = dsAlmacen.Tables("almacen")
            .DisplayMember = dsAlmacen.Tables("almacen").Columns("nom_alma").ToString
            .ValueMember = dsAlmacen.Tables("almacen").Columns("cod_alma").ToString
            If dsAlmacen.Tables("almacen").Rows.Count > 0 Then
                .SelectedIndex = 0
            Else
                .SelectedIndex = -1
            End If
        End With
        cargaCatalogo(cboAlmacen.SelectedValue)
        estructuraCatalogo()
        cargaMaestro(cboAlmacen.SelectedValue)
        estructuraMaestroRecetas()
        If tabRecetas.IsSelected Then
            txtBuscarR.Focus()
        End If
        estaCargando = False
    End Sub
    Sub cargaMaestro(ByVal cod_alma As String)
        Dim mCatalogo As New Catalogo
        Dim mAlmacen As New Almacen

        Dim esproduccion As Boolean = IIf(optInsumos.Checked, False, True)
        'verificamos el modo de trabajo
        'Catalogo x Almacen de Produccion o Catalogo General
        Dim cAlmaCatalogo As String = mAlmacen.devuelveAlmacenCatalogo(cod_alma)

        dsCatalogo1 = mCatalogo.recuperaMaestroRecetas(pCatalogoXalmacen, cAlmaCatalogo, True, False, False, False, "", False, esproduccion, False)
        estructuraMaestroRecetas()
    End Sub
    Private Sub tabRecetas_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tabRecetas.Click
        txtBuscarR.Focus()
    End Sub
    Private Sub cboAlmacenR_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAlmacenR.SelectedIndexChanged
        If Not estaCargando Then
            muestraRecetasR()
        End If
    End Sub
    Sub muestraRecetasR()
        Dim cAlmacen As String = cboAlmacenR.SelectedValue
        Dim xGrupo As Boolean = IIf(cboGrupo.SelectedIndex = -1, False, True)
        Dim csgrupo As String = cboGrupo.SelectedValue
        dsRecetasR.Clear()
        Dim mRecetas As New Receta
        dsRecetasR = mRecetas.recuperaRecetas(True, cAlmacen, xGrupo, csgrupo, True)
        dataRecetasR.DataSource = dsRecetasR.Tables("receta").DefaultView
        estructuraRecetas()
        'lblRegistros.Text = "Nº de Registros..." & dataProduccion.RowCount
    End Sub
    Sub calcularcostoreceta(ByVal cod_art As String)
        Dim table As DataTable, sumObject As Object, mPrecio As New ePrecio, total As Decimal
        table = dsRecetaRa.Tables("receta")
        sumObject = table.Compute("Sum(total)", "")
        total = CType(IIf(IsDBNull(sumObject), 0, sumObject), Double)
        total = CStr(Round(CDbl(total), 3, MidpointRounding.ToEven))
        mPrecio.actualizaCostoArticulo(False, "", cod_art, total)
    End Sub
    Sub estructuraMaestroRecetas()
        With DatosMaestro
            .DataSource = dsCatalogo1.Tables("recetas").DefaultView
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_art").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_art").DisplayIndex = 0
            .Columns("cod_art").HeaderText = "Codigo"
            .Columns("cod_art").Width = 50
            .Columns("nom_art").DisplayIndex = 1
            .Columns("nom_art").HeaderText = "Receta"
            .Columns("nom_art").Width = 150
            .Columns("nom_tart").DisplayIndex = 2
            .Columns("nom_tart").HeaderText = "Tipo"
            .Columns("nom_tart").Width = 50

            .Columns("nom_alma").DisplayIndex = 3
            .Columns("nom_alma").HeaderText = "Almacen"
            .Columns("nom_alma").Width = 100

            .Columns("nom_area").DisplayIndex = 4
            .Columns("nom_area").HeaderText = "Area"
            .Columns("nom_area").Width = 100

            .Columns("nom_uni").DisplayIndex = 5
            .Columns("nom_uni").HeaderText = "Unidad"
            .Columns("nom_uni").Width = 50

            .Columns("nom_art1").DisplayIndex = 6
            .Columns("nom_art1").HeaderText = "Insumo"
            .Columns("nom_art1").Width = 200
            .Columns("nom_uni1").DisplayIndex = 7
            .Columns("nom_uni1").HeaderText = "Unidad"
            .Columns("nom_uni1").Width = 50

            .Columns("cantidad").DisplayIndex = 8
            .Columns("cantidad").HeaderText = "Cantidad"
            .Columns("cantidad").Width = 70
            .Columns("cantidad").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            .Columns("pre_costo").DisplayIndex = 9
            .Columns("pre_costo").HeaderText = "Costo"
            .Columns("pre_costo").Width = 70
            .Columns("pre_costo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            .Columns("monto").DisplayIndex = 10
            .Columns("monto").HeaderText = "Monto"
            .Columns("monto").Width = 70
            .Columns("monto").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight


            .Columns("activo").DisplayIndex = 11
            .Columns("activo").HeaderText = "Act."
            .Columns("activo").Width = 20
            .Columns("factor_prod").Visible = False

        End With
    End Sub
    Sub estructuraRecetas()
        With dataRecetasR
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_art").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_art").DisplayIndex = 0
            .Columns("cod_art").HeaderText = "Codigo"
            .Columns("cod_art").Width = 50
            .Columns("nom_art").DisplayIndex = 1
            .Columns("nom_art").HeaderText = "Receta"
            .Columns("nom_art").Width = 260
            .Columns("nom_uni").DisplayIndex = 2
            .Columns("nom_uni").HeaderText = "Unidad"
            .Columns("nom_uni").Width = 75
            .Columns("pre_costo").DisplayIndex = 3
            .Columns("pre_costo").HeaderText = "Costo"
            .Columns("pre_costo").Width = 70
            .Columns("pre_costo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("activo").DisplayIndex = 4
            .Columns("activo").HeaderText = "Act."
            .Columns("activo").Width = 40
            .Columns("nom_tart").DisplayIndex = 5
            .Columns("nom_tart").HeaderText = "Tipo"
            .Columns("nom_tart").Width = 150
            .Columns("cod_uni").Visible = False
            .Columns("pre_costoMax").Visible = False
            .Columns("pre_venta").Visible = False
            .Columns("pre_inc_imp").Visible = False
            .Columns("cod_sgrupo").Visible = False
            .Columns("cod_tart").Visible = False
            .Columns("costo").Visible = False
        End With
    End Sub
    Sub muestraReceta(ByVal cod_rec As String, ByVal nro As Integer)
        Dim mReceta As New Receta
        If nro = 0 Then
            dsRecetaRa = mReceta.recuperaReceta(cod_rec)
        End If
        If nro = 1 Then
            dsRecetaRb = mReceta.recuperaReceta(cod_rec)
        End If
        If nro = 2 Then
            dsRecetaRc = mReceta.recuperaReceta(cod_rec)
        End If
        If nro = 3 Then
            dsRecetaRd = mReceta.recuperaReceta(cod_rec)
        End If
    End Sub

    Private Sub dataRecetasR_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataRecetasR.CellDoubleClick
        If dataRecetasR.RowCount > 0 Then
            Dim frm As New rptForm
            frm.cargarReceta(dsRecetaRa, dataRecetasR("nom_art", dataRecetasR.CurrentRow.Index).Value, cboAlmacenR.Text, dataRecetasR("nom_uni", dataRecetasR.CurrentRow.Index).Value, True)
            frm.MdiParent = principal
            frm.Show()
        End If
    End Sub
    Private Sub dataRecetasR_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dataRecetasR.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            dataRecetaRa.Focus()
        End If
    End Sub
    Private Sub dataRecetasR_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dataRecetasR.SelectionChanged
        If Not estaCargando Then
            dsRecetaRa.Clear()
            dsRecetaRb.Clear()
            dsRecetaRc.Clear()
            dsRecetaRd.Clear()
            If dataRecetasR.RowCount > 0 Then
                muestraReceta(IIf(IsDBNull(dataRecetasR("cod_art", dataRecetasR.CurrentRow.Index).Value), _
                                    "", dataRecetasR("cod_art", dataRecetasR.CurrentRow.Index).Value), 0)
                dataRecetaRa.DataSource = dsRecetaRa.Tables("receta").DefaultView
                cargaEstructuraRecetaRa()
            End If
        End If
    End Sub


    Private Sub dataRecetaRa_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataRecetaRa.CellDoubleClick
        If dataRecetaRb.RowCount > 0 Then
            Dim frm As New rptForm
            frm.cargarReceta(dsRecetaRb, dataRecetaRa("nom_art", dataRecetaRa.CurrentRow.Index).Value, cboAlmacen.Text, dataRecetaRa("nom_uni", dataRecetaRa.CurrentRow.Index).Value, True)
            frm.MdiParent = principal
            frm.Show()
        End If
    End Sub
    Private Sub dataRecetaRa_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dataRecetaRa.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            dataRecetaRb.Focus()
        End If
    End Sub
    Private Sub dataRecetaRa_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dataRecetaRa.SelectionChanged
        If Not estaCargando Then
            dsRecetaRb.Clear()
            dsRecetaRc.Clear()
            dsRecetaRd.Clear()
            If dataRecetaRa.RowCount > 0 Then
                muestraReceta(IIf(IsDBNull(dataRecetaRa("cod_art", dataRecetaRa.CurrentRow.Index).Value), _
                                    "", dataRecetaRa("cod_art", dataRecetaRa.CurrentRow.Index).Value), 1)
                dataRecetaRb.DataSource = dsRecetaRb.Tables("receta").DefaultView
                cargaEstructuraRecetaRb()
            End If
        End If
    End Sub

    Private Sub dataRecetaRb_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataRecetaRb.CellDoubleClick
        If dataRecetaRc.RowCount > 0 Then
            Dim frm As New rptForm
            frm.cargarReceta(dsRecetaRc, dataRecetaRb("nom_art", dataRecetaRb.CurrentRow.Index).Value, cboAlmacen.Text, dataRecetaRb("nom_uni", dataRecetaRb.CurrentRow.Index).Value, True)
            frm.MdiParent = principal
            frm.Show()
        End If
    End Sub
    Private Sub dataRecetaRb_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dataRecetaRb.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            dataRecetaRc.Focus()
        End If
    End Sub
    Private Sub dataRecetaRb_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dataRecetaRb.SelectionChanged
        If Not estaCargando Then
            dsRecetaRc.Clear()
            dsRecetaRd.Clear()
            If dataRecetaRb.RowCount > 0 Then
                muestraReceta(IIf(IsDBNull(dataRecetaRb("cod_art", dataRecetaRb.CurrentRow.Index).Value), _
                                    "", dataRecetaRb("cod_art", dataRecetaRb.CurrentRow.Index).Value), 2)
                dataRecetaRc.DataSource = dsRecetaRc.Tables("receta").DefaultView
                cargaEstructuraRecetaRc()
            End If
        End If
    End Sub

    Private Sub dataRecetaRc_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataRecetaRc.CellContentDoubleClick
        If dataRecetaRd.RowCount > 0 Then
            Dim frm As New rptForm
            frm.cargarReceta(dsRecetaRd, dataRecetaRc("nom_art", dataRecetaRc.CurrentRow.Index).Value, cboAlmacen.Text, dataRecetaRc("nom_uni", dataRecetaRc.CurrentRow.Index).Value, True)
            frm.MdiParent = principal
            frm.Show()
        End If
    End Sub
    Private Sub dataRecetaRc_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dataRecetaRc.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            dataRecetaRd.Focus()
        End If
    End Sub
    Private Sub dataRecetaRc_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dataRecetaRc.SelectionChanged
        If Not estaCargando Then
            dsRecetaRd.Clear()
            If dataRecetaRc.RowCount > 0 Then
                muestraReceta(IIf(IsDBNull(dataRecetaRc("cod_art", dataRecetaRc.CurrentRow.Index).Value), _
                                    "", dataRecetaRc("cod_art", dataRecetaRc.CurrentRow.Index).Value), 3)
                dataRecetaRd.DataSource = dsRecetaRd.Tables("receta").DefaultView
                cargaEstructuraRecetaRd()
            End If
        End If
    End Sub
    Sub cargaEstructuraRecetaRa()
        With dataRecetaRa
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_art").HeaderText = "Codigo"
            .Columns("cod_art").Width = 50
            .Columns("cod_art").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("nom_art").HeaderText = "Descripcion"
            .Columns("nom_art").Width = 210
            .Columns("nom_uni").HeaderText = "Unidad"
            .Columns("nom_uni").Width = 55
            .Columns("cant").HeaderText = "Cant."
            .Columns("cant").Width = 55
            .Columns("cant").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("pre_costo").HeaderText = "Costo"
            .Columns("pre_costo").Width = 60
            .Columns("pre_costo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("cod_rec").Visible = False
            .Columns("cant_uni").Visible = False
            .Columns("costo").Visible = False
            .Columns("total").Visible = False
        End With
    End Sub
    Sub cargaEstructuraRecetaRb()
        With dataRecetaRb
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_art").HeaderText = "Codigo"
            .Columns("cod_art").Width = 50
            .Columns("cod_art").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("nom_art").HeaderText = "Descripcion"
            .Columns("nom_art").Width = 210
            .Columns("nom_uni").HeaderText = "Unidad"
            .Columns("nom_uni").Width = 55
            .Columns("cant").HeaderText = "Cant."
            .Columns("cant").Width = 55
            .Columns("cant").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("pre_costo").HeaderText = "Costo"
            .Columns("pre_costo").Width = 60
            .Columns("pre_costo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("cod_rec").Visible = False
            .Columns("cant_uni").Visible = False
            .Columns("costo").Visible = False
        End With
    End Sub
    Sub cargaEstructuraRecetaRc()
        With dataRecetaRc
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_art").HeaderText = "Codigo"
            .Columns("cod_art").Width = 50
            .Columns("cod_art").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("nom_art").HeaderText = "Descripcion"
            .Columns("nom_art").Width = 210
            .Columns("nom_uni").HeaderText = "Unidad"
            .Columns("nom_uni").Width = 55
            .Columns("cant").HeaderText = "Cant."
            .Columns("cant").Width = 55
            .Columns("cant").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("pre_costo").HeaderText = "Costo"
            .Columns("pre_costo").Width = 60
            .Columns("pre_costo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("cod_rec").Visible = False
            .Columns("cant_uni").Visible = False
            .Columns("costo").Visible = False
        End With
    End Sub
    Sub cargaEstructuraRecetaRd()
        With dataRecetaRd
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_art").HeaderText = "Codigo"
            .Columns("cod_art").Width = 50
            .Columns("cod_art").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("nom_art").HeaderText = "Descripcion"
            .Columns("nom_art").Width = 210
            .Columns("nom_uni").HeaderText = "Unidad"
            .Columns("nom_uni").Width = 55
            .Columns("cant").HeaderText = "Cant."
            .Columns("cant").Width = 55
            .Columns("cant").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("pre_costo").HeaderText = "Costo"
            .Columns("pre_costo").Width = 60
            .Columns("pre_costo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("cod_rec").Visible = False
            .Columns("cant_uni").Visible = False
            .Columns("costo").Visible = False
        End With
    End Sub
    Private Sub txtBuscarR_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscarR.GotFocus
        If Not estaCargando Then
            txtBuscarR.SelectAll()
        End If
    End Sub
    Private Sub txtBuscarR_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscarR.KeyPress
        If e.KeyChar = ChrW(13) Then
            dataRecetasR.Focus()
        End If
    End Sub
    Private Sub txtBuscarR_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscarR.TextChanged
        If Not estaCargando Then
            If optDescripR.Checked = True Then
                dsRecetasR.Tables("receta").DefaultView.RowFilter = "nom_art LIKE '" & txtBuscarR.Text & "%'"
            Else
                dsRecetasR.Tables("receta").DefaultView.RowFilter = "cod_art LIKE '" & txtBuscarR.Text & "%'"
            End If
            If dataRecetasR.RowCount > 0 Then
                dataRecetasR.CurrentCell = dataRecetasR("cod_art", dataRecetasR.CurrentRow.Index)
            End If
        End If
    End Sub
    Private Sub cboAlmacen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAlmacen.SelectedIndexChanged
        If Not estaCargando Then
            cargaCatalogo(cboAlmacen.SelectedValue)
        End If
    End Sub
    Sub cargaCatalogo(ByVal cod_alma As String)
        Dim mCatalogo As New Catalogo
        Dim mAlmacen As New Almacen

        Dim esproduccion As Boolean = IIf(optInsumos.Checked, False, True)
        'verificamos el modo de trabajo
        'Catalogo x Almacen de Produccion o Catalogo General
        Dim cAlmaCatalogo As String = mAlmacen.devuelveAlmacenCatalogo(cod_alma)

        dsCatalogo = mCatalogo.recuperaCatalogo(pCatalogoXalmacen, cAlmaCatalogo, True, False, False, False, "", False, esproduccion, False)
        estructuraCatalogo()
    End Sub
    Sub estructuraCatalogo()
        With datos
            .DataSource = dsCatalogo.Tables("articulo").DefaultView
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_art").HeaderText = "Código"
            .Columns("cod_art").Width = 50
            .Columns("cod_art").ReadOnly = True
            .Columns("cod_art").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("nom_art").HeaderText = "Descripción"
            .Columns("nom_art").Width = 210
            .Columns("nom_art").ReadOnly = True
            .Columns("nom_uni").HeaderText = "Unidad"
            .Columns("nom_uni").Width = 50
            .Columns("nom_uni").ReadOnly = True
            .Columns("nom_uni").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("pre_costo").HeaderText = "Costo"
            .Columns("pre_costo").Width = 50
            .Columns("pre_costo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("pre_costoMax").Visible = False
            .Columns("pre_costoMin").Visible = False
            .Columns("pre_venta").Visible = False
            .Columns("pre_prom").Visible = False
            .Columns("pre_inc_imp").Visible = False
            .Columns("imp").Visible = False
            .Columns("cant_uni").Visible = False
            .Columns("nom_tart").Visible = False
            .Columns("cod_artExt").Visible = False
            .Columns("cuenta_v").Visible = False
            .Columns("cuenta_v_c").Visible = False
            .Columns("cuenta_c").Visible = False
            .Columns("cuenta_c_p").Visible = False
            .Columns("cuenta_c_a1").Visible = False
            .Columns("cuenta_c_a2").Visible = False
            .Columns("cod_uni").Visible = False
            .Columns("pre_ult").Visible = False
            .Columns("afecto_igv").Visible = False
            .Columns("maximo").Visible = False
            .Columns("minimo").Visible = False
            .Columns("cod_alma").Visible = False
            .Columns("nom_sgrupo").Visible = False
            .Columns("cod_sgrupo").Visible = False
            .Columns("esProduccion").Visible = False
            .Columns("activo").Visible = False
        End With
    End Sub
    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged
        If Not estaCargando Then
            Dim valor As String = txtBuscar.Text

            dsCatalogo.Tables("articulo").DefaultView.RowFilter = "nom_art LIKE '%" & valor & "%'"
            'dsCatalogo.Tables("recetas").DefaultView.RowFilter = "nom_art LIKE '%" & valor & "%'"
            'dsRecetasR.Tables("receta").DefaultView.RowFilter = "nom_art LIKE '" & valor & "%'"

            'If datos.RowCount > 0 Then
            '    datos.CurrentCell = datos("cod_art", datos.CurrentRow.Index)
            'End If
        End If
    End Sub
    Sub buscarRecetas()
        Dim mReceta As New Receta
        Dim cod_art As String = ""
        Dim esActivo As Boolean = IIf(chkActivo.Checked = True, True, False)
        If datos.RowCount > 0 Then
            cod_art = datos.Item("cod_art", datos.CurrentRow.Index).Value
        End If
        dsRecetas.Clear()
        dsRecetas = mReceta.recuperaRecetas_deInsumo(cod_art, esActivo)
        With dataRecetas
            .DataSource = dsRecetas.Tables("receta").DefaultView
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_rec").HeaderText = "Código"
            .Columns("cod_rec").Width = 55
            .Columns("cod_rec").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("nom_art").HeaderText = "Descripción"
            .Columns("nom_art").Width = 230
            .Columns("nom_uni").HeaderText = "Unidad"
            .Columns("nom_uni").Width = 60
            .Columns("nom_uni").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("pre_costo").HeaderText = "Costo"
            .Columns("pre_costo").Width = 70
            .Columns("pre_costo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("cant").HeaderText = "Cant."
            .Columns("cant").Width = 55
            .Columns("cant").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("cant").DefaultCellStyle.BackColor = Color.Wheat
            .Columns("cod_artext").Visible = False
        End With
        lblRegistros.Text = "Nro de Recetas Encontradas... " & dataRecetas.RowCount
    End Sub
    Private Sub datos_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles datos.SelectionChanged
        If datos.RowCount > 0 Then
            lblInsumo.Text = datos.Item("nom_art", datos.CurrentRow.Index).Value _
                            & "  [" & datos.Item("nom_uni", datos.CurrentRow.Index).Value & "]"
        Else
            lblInsumo.Text = ""
        End If
        dsRecetas.Clear()
        buscarRecetas()
    End Sub
    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        If dataRecetas.RowCount > 0 Then
            Dim frm As New rptForm
            frm.cargarRecetas(dsRecetas, datos("nom_art", datos.CurrentRow.Index).Value)
            frm.MdiParent = principal
            frm.Show()
        Else
            MessageBox.Show(general.str_textoNoImpresion, "sga", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If
    End Sub

    Private Sub cmdImprimirLista_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimirLista.Click

        Dim rpta As Integer
        rpta = MessageBox.Show("Desea Enviar en Vista Previa ?", "CEFE", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)
        Dim vprevia As Boolean = IIf(rpta = 6, True, False)
        For x As Integer = 0 To dataRecetasR.RowCount - 1
            dataRecetasR.Rows(x).Selected = True
            Dim codigo As String = dataRecetasR.Item("cod_art", x).Value
            muestraReceta(codigo, 0)
            If dataRecetasR.RowCount > 0 Then
                Dim frm As New rptForm
                'frm.cargarReceta(dsRecetaRa, dataRecetasR("nom_art", dataRecetasR.CurrentRow.Index).Value, cboAlmacenR.Text, dataRecetasR("nom_uni", dataRecetasR.CurrentRow.Index).Value)
                frm.cargarReceta(dsRecetaRa, dataRecetasR.Item("nom_art", x).Value, cboAlmacenR.Text, dataRecetasR.Item("nom_uni", x).Value, vprevia)

                If vprevia Then
                    frm.MdiParent = principal
                    frm.Show()
                End If
            End If
            dataRecetasR.Refresh()
        Next


        'If dataRecetasR.RowCount > 0 Then
        '    Dim frm As New rptForm
        '    frm.cargarRecetasListado(dsRecetasR, "Almacen: " & cboAlmacen.Text, cboGrupo.Text)
        '    frm.MdiParent = principal
        '    frm.Show()
        'Else
        '    MessageBox.Show(general.str_textoNoImpresion, "CEFE", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        'End If
    End Sub



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim cod_art As String, i As Integer
        If dataRecetasR.RowCount > 0 Then
            For i = 0 To dataRecetasR.RowCount - 1
                cod_art = dataRecetasR("cod_art", i).Value
                muestraReceta(IIf(IsDBNull(cod_art), "", cod_art), 0)
                dataRecetaRa.DataSource = dsRecetaRa.Tables("receta").DefaultView
                cargaEstructuraRecetaRa()
                calcularcostoreceta(cod_art)
                lblreceta.Text = dataRecetasR("nom_art", i).Value
                lblreceta.Refresh()
            Next
        End If
        lblreceta.Text = ""
        muestraRecetasR()
    End Sub


    Private Sub cboGrupo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboGrupo.SelectedIndexChanged
        If Not estaCargando Then
            muestraRecetasR()
        End If
    End Sub

    Private Sub chkGrupo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGrupo.CheckedChanged
        If Not estaCargando Then
            If chkGrupo.Checked = True Then
                cboGrupo.Enabled = True
                cboGrupo.SelectedIndex = 0
            Else
                cboGrupo.Enabled = False
                cboGrupo.SelectedIndex = -1
            End If
        End If
    End Sub

 
    Private Sub optInsumos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optInsumos.CheckedChanged
        If Not estaCargando Then
            cargaCatalogo(cboAlmacen.SelectedValue)
        End If
    End Sub

    Private Sub optproducciones_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optproducciones.CheckedChanged
        If Not estaCargando Then
            cargaCatalogo(cboAlmacen.SelectedValue)
        End If
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Dim rpta As Integer
        rpta = MessageBox.Show("Esta seguro de cambiar Recetas por el Insumo..." + Chr(13) + "Este proceso es Irreversible...", "Cefe", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        If rpta = 6 Then
            cambiarinsumo()
            dsRecetas.Clear()
            buscarRecetas()
        End If
    End Sub

    Sub cambiarinsumo()
        If datos.RowCount > 0 Then
            Dim cad As String
            Dim cod_art = datos.Item("cod_art", datos.CurrentRow.Index).Value
            Dim cod_artnew As String = txtcodinsumo.Text
            For Each row As DataGridViewRow In dataRecetas.Rows
                If row.Selected = True Then
                    Dim codrec As String = row.Cells("cod_rec").Value
                    cad = "update receta set cod_art='" & cod_artnew & "' where cod_rec='" & codrec & "' and  cod_art='" & cod_art & "'"
                    Dim com As New MySqlCommand(cad, dbConex)
                    com.ExecuteNonQuery()
                End If
            Next
        End If
    End Sub

    Sub cambiarCantidades()
        If datos.RowCount > 0 Then
            Dim cad As String
            Dim cod_art = datos.Item("cod_art", datos.CurrentRow.Index).Value
            ' Dim cod_artnew As String = txtcodinsumo.Text
            For Each row As DataGridViewRow In dataRecetas.Rows
                'If row.Selected = True Then
                Dim codrec As String = row.Cells("cod_rec").Value
                Dim cantidad As Decimal = row.Cells("cant").Value
                cad = "update receta set cant=" & cantidad & " where cod_rec='" & codrec & "' and  cod_art='" & cod_art & "'"
                Dim com As New MySqlCommand(cad, dbConex)
                    com.ExecuteNonQuery()
                'End If
            Next
        End If
    End Sub


    Private Sub datos_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datos.CellContentClick

    End Sub

    Private Sub chkActivo_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkActivo.CheckedChanged
        If Not estaCargando Then
            If chkActivo.CheckState = CheckState.Checked Then

                chkActivo.Text = "Activos"
            Else

                chkActivo.Text = "Desactivados"
            End If
            dsRecetas.Clear()
            buscarRecetas()
        End If
        
    End Sub



    Private Sub DatosMaestro_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DatosMaestro.KeyDown
        If (e.Control And e.KeyCode = Keys.E) Then
            If DatosMaestro.RowCount > 0 Then
                EnviaraExcel(DatosMaestro)
            End If
        End If
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Dim rpta As Integer
        rpta = MessageBox.Show("Esta seguro de cambiar las Cantidades..." + Chr(13) + "Este proceso es Irreversible...", "Cefe", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        If rpta = 6 Then
            cambiarCantidades()
            dsRecetas.Clear()
            buscarRecetas()
        End If
    End Sub
End Class
