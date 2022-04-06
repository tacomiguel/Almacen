Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Math
Imports libreriaClases
Public Class u_codigosExt
    Private dsArticulos As New DataSet
    Private dsReceta As New DataSet
    Private dsAlmacen As New DataSet
    Private dsGrupo As New DataSet
    Private estaCargando As Boolean = True
    'para validar el separador decimal
    Private sepDecimal As Char
    Private Sub u_codigosExt_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        principal.mu_codigosExt.Enabled = True
    End Sub
    Private Sub u_codigosExt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Top = 0
        Me.Left = 0
        'capturamos el separador decimal
        sepDecimal = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        'dataset almacen
        Dim daAlmacen As New MySqlDataAdapter
        Dim cadAlma As String
        If pCatalogoXalmacen Then
            cadAlma = "select cod_alma,nom_alma from almacen where (esProduccion) and activo=1 order by nom_alma"
        Else
            cadAlma = "select cod_alma,nom_alma from almacen where ((esProduccion) or (esCompras)) and activo=1 order by nom_alma"
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
        'dataset grupo
        Dim daGrupo As New MySqlDataAdapter
        Dim cadGrupo As String
        Dim cCampo As String = "nom_sgrupo"
        cadGrupo = "select cod_sgrupo," & general.convierte_enTitulo(cCampo) _
                & " as nom_sgrupo from subgrupo where (esProduccion) and activo=1 order by nom_sgrupo"
        Dim comGrupo As New MySqlCommand(cadGrupo, dbConex)
        daGrupo.SelectCommand = comGrupo
        daGrupo.Fill(dsgrupo, "grupo")
        With cboGrupo
            .DataSource = dsGrupo.Tables("grupo")
            .DisplayMember = dsGrupo.Tables("grupo").Columns("nom_sgrupo").ToString
            .ValueMember = dsGrupo.Tables("grupo").Columns("cod_sgrupo").ToString
            If dsGrupo.Tables("grupo").Rows.Count > 0 Then
                .SelectedIndex = -1
            End If
        End With
        cargaRecetas()
        cargaEstructuraRecetas()
        estaCargando = False
    End Sub
    Function orden() As String
        Dim cOrden As String = ""
        If optOrdenCodigo.Checked = True Then
            cOrden = "articulo.cod_art,nom_art"
        End If
        If optOrdenExterno.Checked = True Then
            cOrden = "articulo.cod_artExt,nom_art"
        End If
        If optOrdenProducto.Checked = True Then
            cOrden = "nom_art"
        End If
        If optOrdenTipo.Checked = True Then
            cOrden = "articulo.cod_tart,nom_art"
        End If
        Return cOrden
    End Function
    Sub cargaRecetas()
        Dim mCatalogo As New Catalogo
        Dim xGrupo As Boolean = IIf(chkGrupo.Checked = True, True, False)
        Dim cAlma As String = "0000"
        Dim cGrupo As String = cboGrupo.SelectedValue
        Dim cOrden As String = orden()
        If pCatalogoXalmacen Then
            Dim mAlmacen As New Almacen
            If mAlmacen.esDeProduccion(cboAlmacen.SelectedValue) Then
                cAlma = cboAlmacen.SelectedValue
            End If
            dsArticulos = mCatalogo.recuperaRecetas(cAlma, xGrupo, cGrupo, False, "", False, cOrden)
        Else
            dsArticulos = mCatalogo.recuperaCatalogo(pCatalogoXalmacen, cAlma, True, False, False, xGrupo, cGrupo, False, True, False)
        End If
        cargaEstructuraRecetas()
    End Sub
    Sub cargaEstructuraRecetas()
        With datos
            .DataSource = dsArticulos.Tables("articulo").DefaultView
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_art").HeaderText = "Código"
            .Columns("cod_art").DisplayIndex = 0
            .Columns("cod_art").Width = 50
            .Columns("cod_art").ReadOnly = True
            .Columns("cod_art").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("nom_art").HeaderText = "Descripción"
            .Columns("nom_art").DisplayIndex = 1
            .Columns("nom_art").Width = 200
            .Columns("nom_art").ReadOnly = True
            .Columns("nom_uni").HeaderText = "Unidad"
            .Columns("nom_uni").DisplayIndex = 2
            .Columns("nom_uni").Width = 50
            .Columns("nom_uni").ReadOnly = True
            .Columns("nom_uni").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("nom_tart").HeaderText = "Tipo"
            .Columns("nom_tart").DisplayIndex = 3
            .Columns("nom_tart").Width = 100
            .Columns("nom_tart").ReadOnly = True
            If pCatalogoXalmacen Then
                .Columns("cod_tart").Visible = False
                .Columns("inv_diario").Visible = False
            Else
                .Columns("cuenta_v").Visible = False
                .Columns("cuenta_v_c").Visible = False
                .Columns("cuenta_c").Visible = False
                .Columns("cuenta_c_p").Visible = False
                .Columns("cuenta_c_a1").Visible = False
                .Columns("cuenta_c_a2").Visible = False
                .Columns("esProduccion").Visible = False
                .Columns("pre_prom").Visible = False
                .Columns("pre_ult").Visible = False
                .Columns("imp").Visible = False
                .Columns("cant_uni").Visible = False
            End If
            .Columns("cod_artExt").HeaderText = "Código Externo1"
            .Columns("cod_artExt").DisplayIndex = 4
            .Columns("cod_artExt").Width = 55
            .Columns("cod_artExt").ReadOnly = False
            .Columns("cod_artExt").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_artExt").DefaultCellStyle.BackColor = Color.AliceBlue
            .Columns("cod_artExt").DefaultCellStyle.ForeColor = Color.MidnightBlue
            .Columns("cod_artExt1").HeaderText = "Código Externo2"
            .Columns("cod_artExt1").DisplayIndex = 4
            .Columns("cod_artExt1").Width = 55
            .Columns("cod_artExt1").ReadOnly = False
            .Columns("cod_artExt1").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_artExt1").DefaultCellStyle.BackColor = Color.AliceBlue
            .Columns("cod_artExt1").DefaultCellStyle.ForeColor = Color.MidnightBlue
            .Columns("cod_artExt2").HeaderText = "Código Externo3"
            .Columns("cod_artExt2").DisplayIndex = 4
            .Columns("cod_artExt2").Width = 55
            .Columns("cod_artExt2").ReadOnly = False
            .Columns("cod_artExt2").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_artExt2").DefaultCellStyle.BackColor = Color.AliceBlue
            .Columns("cod_artExt2").DefaultCellStyle.ForeColor = Color.MidnightBlue
            .Columns("pre_venta").Visible = False
            .Columns("pre_inc_imp").Visible = False
            .Columns("pre_costo").Visible = False
            .Columns("pre_costoMin").Visible = False
            .Columns("pre_costoMax").Visible = False
            .Columns("cod_uni").Visible = False
            .Columns("afecto_igv").Visible = False
            .Columns("maximo").Visible = False
            .Columns("minimo").Visible = False
            .Columns("nom_sgrupo").Visible = False
            .Columns("cod_sgrupo").Visible = False
            .Columns("activo").Visible = False
        End With
        'mostramos el numero de registros procesados
        lblRegistros.Text = "Nº de Registros... " & datos.RowCount
    End Sub
    Private Sub optCodigoGeneral_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optCodigoGeneral.CheckedChanged
        txtBuscarGeneral.Focus()
    End Sub
    Private Sub optDescripcionGeneral_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optDescripcionGeneral.CheckedChanged
        txtBuscarGeneral.Focus()
    End Sub
    Private Sub txtBuscarGeneral_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscarGeneral.TextChanged
        Dim valor As String = txtBuscarGeneral.Text
        If optCodigoGeneral.Checked = True Then
            dsArticulos.Tables("articulo").DefaultView.RowFilter = "cod_art LIKE '" & valor & "%'"
            If datos.RowCount > 0 Then
                datos.CurrentCell = datos("cod_art", datos.CurrentRow.Index)
            End If
        Else
            If optCodigoExterno.Checked = True Then
                dsArticulos.Tables("articulo").DefaultView.RowFilter = "cod_artExt LIKE '" & valor & "%'"
                If datos.RowCount > 0 Then
                    datos.CurrentCell = datos("cod_artExt", datos.CurrentRow.Index)
                End If
            Else
                dsArticulos.Tables("articulo").DefaultView.RowFilter = "nom_art LIKE '" & valor & "%'"
                If datos.RowCount > 0 Then
                    datos.CurrentCell = datos("nom_art", datos.CurrentRow.Index)
                End If
            End If
        End If
    End Sub
    Private Sub datos_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datos.CellEndEdit
        Dim codigo, codigoExt, codigoExt1, codigoExt2 As String
        Dim mCatalogo As New Catalogo
        If datos.CurrentCell.ColumnIndex = datos.Columns("cod_artExt").Index Then
            If IsDBNull(datos("cod_artExt", datos.CurrentRow.Index).Value) Then
                codigoExt = "-"
                datos("cod_artExt", datos.CurrentRow.Index).Value = "-"
            Else
                codigoExt = datos("cod_artExt", datos.CurrentRow.Index).Value
            End If
            codigo = datos("cod_art", datos.CurrentRow.Index).Value
            If mCatalogo.existeCodigoExterno("cod_artExt", " cod_artExt='" & codigoExt & "' and cod_artExt<>'-'") Then
                MessageBox.Show("Ya Existe El Código Ingresado...", "CEFE", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                datos("cod_artExt", datos.CurrentRow.Index).Value = "-"
            Else
                mCatalogo.actualizaCodigoExterno(codigo, " cod_artExt='" & codigoExt & "'")
            End If
        End If
        If datos.CurrentCell.ColumnIndex = datos.Columns("cod_artExt1").Index Then
            If IsDBNull(datos("cod_artExt1", datos.CurrentRow.Index).Value) Then
                codigoExt1 = "-"
                datos("cod_artExt1", datos.CurrentRow.Index).Value = "-"
            Else
                codigoExt1 = datos("cod_artExt1", datos.CurrentRow.Index).Value
            End If
            codigo = datos("cod_art", datos.CurrentRow.Index).Value
            If mCatalogo.existeCodigoExterno("cod_artExt1", " cod_artExt1='" & codigoExt1 & "' and cod_artExt1<>'-'") Then
                MessageBox.Show("Ya Existe El Código Ingresado...", "CEFE", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                datos("cod_artExt1", datos.CurrentRow.Index).Value = "-"
            Else
                mCatalogo.actualizaCodigoExterno(codigo, " cod_artExt1='" & codigoExt1 & "'")
            End If
        End If
        If datos.CurrentCell.ColumnIndex = datos.Columns("cod_artExt2").Index Then
            If IsDBNull(datos("cod_artExt2", datos.CurrentRow.Index).Value) Then
                codigoExt2 = "-"
                datos("cod_artExt2", datos.CurrentRow.Index).Value = "-"
            Else
                codigoExt2 = datos("cod_artExt2", datos.CurrentRow.Index).Value
            End If
            codigo = datos("cod_art", datos.CurrentRow.Index).Value
            If mCatalogo.existeCodigoExterno("cod_artExt2", " cod_artExt2='" & codigoExt2 & "' and cod_artExt2<>'-'") Then
                MessageBox.Show("Ya Existe El Código Ingresado...", "CEFE", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                datos("cod_artExt2", datos.CurrentRow.Index).Value = "-"
            Else
                mCatalogo.actualizaCodigoExterno(codigo, " cod_artExt2='" & codigoExt2 & "'")
            End If
        End If
    End Sub
    Private Sub datos_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles datos.SelectionChanged
        If Not estaCargando Then
            lblReceta.Text = "RECETA:"
            If datos.RowCount > 0 Then
                lblReceta.Text = "RECETA: " & datos("nom_art", datos.CurrentRow.Index).Value
                muestraReceta(datos("cod_art", datos.CurrentRow.Index).Value)
            End If
        End If
    End Sub
    Sub muestraReceta(ByVal cod_rec As String)
        Dim mReceta As New Receta
        dsReceta.Clear()
        dsReceta = mReceta.recuperaReceta(cod_rec)
        dataReceta.DataSource = dsReceta.Tables("receta").DefaultView
        cargaEstructuraReceta()
    End Sub
    Sub cargaEstructuraReceta()
        With dataReceta
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_art").HeaderText = "Codigo"
            .Columns("cod_art").Width = 50
            .Columns("cod_art").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("nom_art").HeaderText = "Descripcion"
            .Columns("nom_art").Width = 180
            .Columns("nom_uni").HeaderText = "Unidad"
            .Columns("nom_uni").Width = 50
            .Columns("cant").HeaderText = "Cant."
            .Columns("cant").Width = 45
            .Columns("cant").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("costo").HeaderText = "Costo"
            .Columns("costo").Width = 52
            .Columns("costo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("cod_rec").Visible = False
            .Columns("cant_uni").Visible = False
            .Columns("pre_costo").Visible = False

        End With
    End Sub
    Private Sub cboAlmacen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAlmacen.SelectedIndexChanged
        If Not estaCargando Then
            cargaRecetas()
        End If
    End Sub
    Private Sub cboGrupo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboGrupo.SelectedIndexChanged
        If Not estaCargando Then
            cargaRecetas()
        End If
    End Sub
    Private Sub chkGrupo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGrupo.CheckedChanged
        If chkGrupo.Checked = True Then
            cboGrupo.Enabled = True
            If dsGrupo.Tables("grupo").Rows.Count > 0 Then
                cboGrupo.SelectedIndex = 0
            End If
            cboGrupo.Focus()
        Else
            cboGrupo.SelectedIndex = -1
            cboGrupo.Enabled = False
            datos.Focus()
        End If
        cargaRecetas()
    End Sub
    Private Sub optOrdenCodigo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optOrdenCodigo.CheckedChanged
        If Not estaCargando Then
            If optOrdenCodigo.Checked = True Then
                cargaRecetas()
            End If
        End If
    End Sub
    Private Sub optOrdenExterno_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optOrdenExterno.CheckedChanged
        If Not estaCargando Then
            If optOrdenExterno.Checked = True Then
                cargaRecetas()
            End If
        End If
    End Sub
    Private Sub optOrdenProducto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optOrdenProducto.CheckedChanged
        If Not estaCargando Then
            If optOrdenProducto.Checked = True Then
                cargaRecetas()
            End If
        End If
    End Sub
    Private Sub optOrdenTipo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optOrdenTipo.CheckedChanged
        If Not estaCargando Then
            If optOrdenTipo.Checked = True Then
                cargaRecetas()
            End If
        End If
    End Sub
    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        Dim frm As New rptForm
        Dim cAlmacen As String = cboAlmacen.Text
        Dim cTitulo As String = cAlmacen & "  " & IIf(chkGrupo.Checked = True, " - Grupo: " & cboGrupo.Text, "")
        frm.cargarCatalogo_codExt(dsArticulos, cTitulo)
        frm.MdiParent = principal
        frm.Show()
    End Sub

    Private Sub datos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datos.CellContentClick

    End Sub
End Class
