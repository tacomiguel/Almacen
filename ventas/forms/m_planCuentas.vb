Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Math
Imports libreriaClases
Public Class m_planCuentas
    Private dsArticulo As New DataSet
    Private dsAlmacen, dsAlmacenG As New DataSet
    Private dsGrupo As New DataSet
    Private dsPlanCuentasG As New DataSet
    Private cAlmaPrincipal As String
    Private estaCargando As Boolean = True
    Private Sub m_planCuentas_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        principal.ma_planCuentas.Enabled = True
    End Sub
    Private Sub m_planCuentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Top = 0
        Me.Left = 0
        Dim mAlmacen As New Almacen
        cAlmaPrincipal = mAlmacen.devuelveAlmacenPrincipal
        'If pCatalogoXalmacen Then
        'chkAlmacen.Visible = True
        'cboAlmacen.Visible = True
        Dim daAlmacen, daAlmacenG As New MySqlDataAdapter
        Dim cad As String = "select cod_alma,nom_alma from almacen " _
                            & " where activo=1 and ((esCompras) or (esProduccion)) order by nom_alma"
        Dim comAlmacen As New MySqlCommand(cad, dbConex)
        daAlmacen.SelectCommand = comAlmacen
        daAlmacenG.SelectCommand = comAlmacen
        daAlmacen.Fill(dsAlmacen, "almacen")
        daAlmacenG.Fill(dsAlmacenG, "almacen")
        With cboAlmacen
            .DataSource = dsAlmacen.Tables("almacen")
            .DisplayMember = dsAlmacen.Tables("almacen").Columns("nom_alma").ToString
            .ValueMember = dsAlmacen.Tables("almacen").Columns("cod_alma").ToString
            If dsAlmacen.Tables("almacen").Rows.Count > 0 Then
                .SelectedIndex = 0
            End If
        End With
        With cboAlmacenGrupo
            .DataSource = dsAlmacenG.Tables("almacen")
            .DisplayMember = dsAlmacenG.Tables("almacen").Columns("nom_alma").ToString
            .ValueMember = dsAlmacenG.Tables("almacen").Columns("cod_alma").ToString
            If dsAlmacenG.Tables("almacen").Rows.Count > 0 Then
                .SelectedIndex = 0
            End If
        End With
        'End If
        cargaGrupos()
        muestraCatalogo()
        estructuraCatalogo()
        muestraPlanCuentasG()
        estructuraPlanCuentasG()
        lblRegistros.Text = "Nº de Registros Procesados... " & dataDetalle.RowCount.ToString
        estaCargando = False
    End Sub
    Sub muestraCatalogo()
        Dim mCatalogo As New Catalogo, mAlmacen As New Almacen
        Dim xGrupo As Boolean = IIf(chkGrupo.Checked = True, True, False)
        Dim cProduc As Boolean = IIf(chkProduccion.Checked = True, False, True)
        Dim cod_alma As String = cAlmaPrincipal
        Dim valor As String = txtBuscar.Text
        dsArticulo.Clear()
        'If pCatalogoXalmacen Then
        If mAlmacen.esDeProduccion(cboAlmacen.SelectedValue) Then
            cod_alma = cboAlmacen.SelectedValue
        End If
        'End If
        dsArticulo = mCatalogo.recuperaCatalogo(pCatalogoXalmacen, cod_alma, True, False, False, xGrupo, cboGrupo.SelectedValue, False, cProduc, False)
        dataDetalle.DataSource = dsArticulo.Tables("articulo").DefaultView
        lblRegistros.Text = "Nº de Registros Procesados... " & dataDetalle.RowCount.ToString
    End Sub
    Sub estructuraCatalogo()
        With dataDetalle
            .DataSource = dsArticulo.Tables("articulo").DefaultView
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_art").HeaderText = "Código"
            .Columns("cod_art").Width = 55
            .Columns("cod_art").ReadOnly = True
            .Columns("cod_art").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("nom_art").HeaderText = "Descripción"
            .Columns("nom_art").Width = 260
            .Columns("nom_art").ReadOnly = True
            .Columns("nom_uni").HeaderText = "Unidad"
            .Columns("nom_uni").Width = 70
            .Columns("nom_uni").ReadOnly = True
            .Columns("nom_uni").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("pre_costo").HeaderText = "Precio"
            .Columns("pre_costo").Width = 68
            .Columns("pre_costo").ReadOnly = True
            .Columns("pre_costo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("cuenta_v").HeaderText = "Cuenta Ventas"
            .Columns("cuenta_v").Width = 65
            .Columns("cuenta_v").ReadOnly = False
            .Columns("cuenta_v").DefaultCellStyle.BackColor = Color.AliceBlue
            .Columns("cuenta_v").DefaultCellStyle.ForeColor = Color.MidnightBlue
            .Columns("cuenta_v").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cuenta_v_c").HeaderText = "Cuenta x Cobrar"
            .Columns("cuenta_v_c").Width = 65
            .Columns("cuenta_v_c").ReadOnly = False
            .Columns("cuenta_v_c").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cuenta_c").HeaderText = "Cuenta Compras"
            .Columns("cuenta_c").Width = 70
            .Columns("cuenta_c").ReadOnly = False
            .Columns("cuenta_c").DefaultCellStyle.BackColor = Color.AliceBlue
            .Columns("cuenta_c").DefaultCellStyle.ForeColor = Color.MidnightBlue
            .Columns("cuenta_c").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cuenta_c_a1").HeaderText = "Amarre01 Destino"
            .Columns("cuenta_c_a1").Width = 70
            .Columns("cuenta_c_a1").ReadOnly = False
            .Columns("cuenta_c_a1").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cuenta_c_a2").HeaderText = "Amarre02 Stock"
            .Columns("cuenta_c_a2").Width = 70
            .Columns("cuenta_c_a2").ReadOnly = False
            .Columns("cuenta_c_a2").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cuenta_c_p").HeaderText = "Cuenta x Pagar"
            .Columns("cuenta_c_p").Width = 70
            .Columns("cuenta_c_p").ReadOnly = False
            .Columns("cuenta_c_p").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_uni").Visible = False
            .Columns("cant_uni").Visible = False
            .Columns("nom_tart").Visible = False
            .Columns("pre_ult").Visible = False
            .Columns("pre_costoMin").Visible = False
            .Columns("pre_costoMax").Visible = False
            .Columns("pre_prom").Visible = False
            .Columns("pre_inc_imp").Visible = False
            .Columns("imp").Visible = False
            .Columns("cod_artExt").Visible = False
            .Columns("afecto_igv").Visible = False
            .Columns("maximo").Visible = False
            .Columns("minimo").Visible = False
            .Columns("pre_venta").Visible = False
            .Columns("cod_sgrupo").Visible = False
            .Columns("nom_sgrupo").Visible = False
            .Columns("esProduccion").Visible = False
            .Columns("activo").Visible = False
        End With
    End Sub
    Private Sub dataDetalle_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataDetalle.CellEndEdit
        Dim codigo, lcuenta, lcuenta_v_c, lcuenta_a1, lcuenta_a2, lcuenta_p As String
        If dataDetalle.CurrentCell.ColumnIndex = dataDetalle.Columns("cuenta_v").Index _
           Or dataDetalle.CurrentCell.ColumnIndex = dataDetalle.Columns("cuenta_v_c").Index Then
            If IsDBNull(dataDetalle("cuenta_v", dataDetalle.CurrentRow.Index).Value) Then
                lcuenta = "-"
                dataDetalle("cuenta_v", dataDetalle.CurrentRow.Index).Value = "-"
            Else
                lcuenta = dataDetalle("cuenta_v", dataDetalle.CurrentRow.Index).Value
            End If
            If IsDBNull(dataDetalle("cuenta_v_c", dataDetalle.CurrentRow.Index).Value) Then
                lcuenta_v_c = "-"
                dataDetalle("cuenta_v_c", dataDetalle.CurrentRow.Index).Value = "-"
            Else
                lcuenta_v_c = dataDetalle("cuenta_v_c", dataDetalle.CurrentRow.Index).Value
            End If
            Dim mCatalogo As New Catalogo
            codigo = dataDetalle("cod_art", dataDetalle.CurrentRow.Index).Value
            mCatalogo.actualizaCuentaVentas(codigo, lcuenta, lcuenta_v_c, False, "")
        End If
        If dataDetalle.CurrentCell.ColumnIndex = dataDetalle.Columns("cuenta_c").Index _
           Or dataDetalle.CurrentCell.ColumnIndex = dataDetalle.Columns("cuenta_c_a1").Index _
           Or dataDetalle.CurrentCell.ColumnIndex = dataDetalle.Columns("cuenta_c_a2").Index _
           Or dataDetalle.CurrentCell.ColumnIndex = dataDetalle.Columns("cuenta_c_p").Index Then
            If IsDBNull(dataDetalle("cuenta_c", dataDetalle.CurrentRow.Index).Value) Then
                lcuenta = "-"
                dataDetalle("cuenta_c", dataDetalle.CurrentRow.Index).Value = "-"
            Else
                lcuenta = dataDetalle("cuenta_c", dataDetalle.CurrentRow.Index).Value
            End If
            If IsDBNull(dataDetalle("cuenta_c_a1", dataDetalle.CurrentRow.Index).Value) Then
                lcuenta_a1 = "-"
                dataDetalle("cuenta_c_a1", dataDetalle.CurrentRow.Index).Value = "-"
            Else
                lcuenta_a1 = dataDetalle("cuenta_c_a1", dataDetalle.CurrentRow.Index).Value
            End If
            If IsDBNull(dataDetalle("cuenta_c_a2", dataDetalle.CurrentRow.Index).Value) Then
                lcuenta_a2 = "-"
                dataDetalle("cuenta_c_a2", dataDetalle.CurrentRow.Index).Value = "-"
            Else
                lcuenta_a2 = dataDetalle("cuenta_c_a2", dataDetalle.CurrentRow.Index).Value
            End If
            If IsDBNull(dataDetalle("cuenta_c_p", dataDetalle.CurrentRow.Index).Value) Then
                lcuenta_p = "-"
                dataDetalle("cuenta_c_p", dataDetalle.CurrentRow.Index).Value = "-"
            Else
                lcuenta_p = dataDetalle("cuenta_c_p", dataDetalle.CurrentRow.Index).Value
            End If
            Dim mCatalogo As New Catalogo
            codigo = dataDetalle("cod_art", dataDetalle.CurrentRow.Index).Value
            mCatalogo.actualizaCuentaCompras(codigo, lcuenta, lcuenta_a1, lcuenta_a2, lcuenta_p, False, "")
        End If
    End Sub
    Private Sub optCodigo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles optCodigo.Click
        txtBuscar.Focus()
    End Sub
    Private Sub optDescripcion_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles optDescripcion.Click
        txtBuscar.Focus()
    End Sub
    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged
        Dim valor As String = txtBuscar.Text
        If optCodigo.Checked = True Then
            dsArticulo.Tables("articulo").DefaultView.RowFilter = "cod_art LIKE '" & valor & "%'"
            If dataDetalle.RowCount > 0 Then
                dataDetalle.CurrentCell = dataDetalle("cod_art", dataDetalle.CurrentRow.Index)
            End If
        Else
            dsArticulo.Tables("articulo").DefaultView.RowFilter = "nom_art LIKE '" & valor & "%'"
            If dataDetalle.RowCount > 0 Then
                dataDetalle.CurrentCell = dataDetalle("nom_art", dataDetalle.CurrentRow.Index)
            End If
        End If
    End Sub
    Private Sub cboAlmacen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAlmacen.SelectedIndexChanged
        If Not estaCargando Then
            cargaGrupos()
            muestraCatalogo()
        End If
    End Sub
    Private Sub chkAlmacen_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAlmacen.CheckedChanged
        If Not estaCargando Then
            If chkAlmacen.Checked = True Then
                If dsAlmacen.Tables("almacen").Rows.Count > 0 Then
                    cboAlmacen.SelectedIndex = 0
                End If
                cboAlmacen.Enabled = True
            Else
                cboAlmacen.SelectedIndex = -1
                cboAlmacen.Enabled = False
            End If
        End If
    End Sub
    Private Sub cboGrupo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboGrupo.SelectedIndexChanged
        If Not estaCargando Then
            muestraCatalogo()
        End If
    End Sub
    Private Sub chkGrupo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGrupo.CheckedChanged
        If Not estaCargando Then
            If chkGrupo.Checked = True Then
                If dsGrupo.Tables("grupo").Rows.Count > 0 Then
                    cboGrupo.SelectedIndex = 0
                End If
                cboGrupo.Enabled = True
            Else
                cboGrupo.SelectedIndex = -1
                cboGrupo.Enabled = False
            End If
        End If
    End Sub
    Sub cargaGrupos()
        'dataset grupo
        dsGrupo.Clear()
        Dim daGrupo As New MySqlDataAdapter
        Dim cCampo As String = "nom_sgrupo"
        Dim cAlma As String = cAlmaPrincipal
        Dim cad, cad1, cad2, cad3, cad4 As String
        If pCatalogoXalmacen Then
            Dim malmacen As New Almacen
            If malmacen.esDeProduccion(cboAlmacen.SelectedValue) Then
                cAlma = cboAlmacen.SelectedValue
            End If
        End If
        cad1 = "select subgrupo.cod_sgrupo," & general.convierte_enTitulo(cCampo) & " as nom_sgrupo"
        cad2 = " from articulo inner join subgrupo on articulo.cod_sgrupo=subgrupo.cod_sgrupo"
        cad3 = " where cod_alma ='" & cAlma & "'"
        cad4 = " group by articulo.cod_sgrupo order by nom_sgrupo"
        cad = cad1 + cad2 + cad3 + cad4
        Dim comGrupo As New MySqlCommand(cad, dbConex)
        daGrupo.SelectCommand = comGrupo
        daGrupo.Fill(dsGrupo, "grupo")
        With cboGrupo
            .DataSource = dsGrupo.Tables("grupo")
            .DisplayMember = dsGrupo.Tables("grupo").Columns("nom_sgrupo").ToString
            .ValueMember = dsGrupo.Tables("grupo").Columns("cod_sgrupo").ToString
            cboGrupo.SelectedIndex = -1
        End With
    End Sub
    Private Sub cboAlmacenGrupo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAlmacenGrupo.SelectedIndexChanged
        If Not estaCargando Then
            muestraPlanCuentasG()
        End If
    End Sub
    Private Sub chkAlmacenGrupo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAlmacenGrupo.CheckedChanged
        If Not estaCargando Then
            If chkAlmacenGrupo.Checked = True Then
                cboAlmacenGrupo.Enabled = True
                cboAlmacenGrupo.SelectedIndex = 0
            Else
                cboAlmacenGrupo.SelectedIndex = -1
                cboAlmacenGrupo.Enabled = False
            End If
            muestraPlanCuentasG()
            dataDetalleGrupo.Focus()
        End If
    End Sub
    Sub muestraPlanCuentasG()
        Dim mCuenta As New Cuenta
        dsPlanCuentasG.Clear()
        Dim cAlma As String = cAlmaPrincipal
        If pCatalogoXalmacen Then
            Dim mAlmacen As New Almacen
            If malmacen.esDeProduccion(cboAlmacenGrupo.SelectedValue) Then
                cAlma = cboAlmacenGrupo.SelectedValue
            End If
        End If
        Dim xAlmacen As Boolean = IIf(cboAlmacenGrupo.SelectedIndex >= 0, True, False)
        dsPlanCuentasG = mCuenta.recuperaPlanCuentas_grupo(xAlmacen, cAlma)
        dataDetalleGrupo.DataSource = dsPlanCuentasG.Tables("planCuentas").DefaultView
        lblNroGrupos.Text = "Nº de Grupos Procesados... " & dataDetalleGrupo.RowCount.ToString
    End Sub
    Sub estructuraPlanCuentasG()
        With dataDetalleGrupo
            .DataSource = dsPlanCuentasG.Tables("planCuentas").DefaultView
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_sgrupo").HeaderText = "Código"
            .Columns("cod_sgrupo").Width = 55
            .Columns("cod_sgrupo").ReadOnly = True
            .Columns("cod_sgrupo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("nom_sgrupo").HeaderText = "Grupo"
            .Columns("nom_sgrupo").Width = 260
            .Columns("nom_sgrupo").ReadOnly = True
            .Columns("cuenta_v").HeaderText = "Cuenta Ventas"
            .Columns("cuenta_v").Width = 65
            .Columns("cuenta_v").ReadOnly = False
            .Columns("cuenta_v").DefaultCellStyle.BackColor = Color.AliceBlue
            .Columns("cuenta_v").DefaultCellStyle.ForeColor = Color.MidnightBlue
            .Columns("cuenta_v").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cuenta_v_c").HeaderText = "Cuenta x Cobrar"
            .Columns("cuenta_v_c").Width = 65
            .Columns("cuenta_v_c").ReadOnly = False
            .Columns("cuenta_v_c").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cuenta_c").HeaderText = "Cuenta Compras"
            .Columns("cuenta_c").Width = 70
            .Columns("cuenta_c").ReadOnly = False
            .Columns("cuenta_c").DefaultCellStyle.BackColor = Color.AliceBlue
            .Columns("cuenta_c").DefaultCellStyle.ForeColor = Color.MidnightBlue
            .Columns("cuenta_c").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cuenta_c_a1").HeaderText = "Amarre01 Destino"
            .Columns("cuenta_c_a1").Width = 70
            .Columns("cuenta_c_a1").ReadOnly = False
            .Columns("cuenta_c_a1").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cuenta_c_a2").HeaderText = "Amarre02 Stock"
            .Columns("cuenta_c_a2").Width = 70
            .Columns("cuenta_c_a2").ReadOnly = False
            .Columns("cuenta_c_a2").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cuenta_c_p").HeaderText = "Cuenta x Pagar"
            .Columns("cuenta_c_p").Width = 70
            .Columns("cuenta_c_p").ReadOnly = False
            .Columns("cuenta_c_p").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With
    End Sub
    Private Sub dataDetalleGrupo_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataDetalleGrupo.CellEndEdit
        Dim codigo, lcuenta, lcuenta_v_c, lcuenta_a1, lcuenta_a2, lcuenta_p As String
        If dataDetalleGrupo.CurrentCell.ColumnIndex = dataDetalleGrupo.Columns("cuenta_v").Index _
            Or dataDetalleGrupo.CurrentCell.ColumnIndex = dataDetalleGrupo.Columns("cuenta_v_c").Index Then
            If IsDBNull(dataDetalleGrupo("cuenta_v", dataDetalleGrupo.CurrentRow.Index).Value) Then
                lcuenta = "-"
                dataDetalleGrupo("cuenta_v", dataDetalleGrupo.CurrentRow.Index).Value = "-"
            Else
                lcuenta = dataDetalleGrupo("cuenta_v", dataDetalleGrupo.CurrentRow.Index).Value
            End If
            If IsDBNull(dataDetalleGrupo("cuenta_v_c", dataDetalleGrupo.CurrentRow.Index).Value) Then
                lcuenta_v_c = "-"
                dataDetalleGrupo("cuenta_v_c", dataDetalleGrupo.CurrentRow.Index).Value = "-"
            Else
                lcuenta_v_c = dataDetalleGrupo("cuenta_v_c", dataDetalleGrupo.CurrentRow.Index).Value
            End If
            Dim mCuenta As New Cuenta
            codigo = dataDetalleGrupo("cod_sgrupo", dataDetalleGrupo.CurrentRow.Index).Value
            If mCuenta.existeGrupo_enCuentas(codigo) Then
                mCuenta.actualizaCuentaVentasGrupo(codigo, lcuenta, lcuenta_v_c)
            Else
                mCuenta.insertaCuentaVentasGrupo(codigo, lcuenta, lcuenta_v_c)
            End If
        End If
        If dataDetalleGrupo.CurrentCell.ColumnIndex = dataDetalleGrupo.Columns("cuenta_c").Index _
            Or dataDetalleGrupo.CurrentCell.ColumnIndex = dataDetalleGrupo.Columns("cuenta_c_a1").Index _
            Or dataDetalleGrupo.CurrentCell.ColumnIndex = dataDetalleGrupo.Columns("cuenta_c_a2").Index _
            Or dataDetalleGrupo.CurrentCell.ColumnIndex = dataDetalleGrupo.Columns("cuenta_c_p").Index Then
            If IsDBNull(dataDetalleGrupo("cuenta_c", dataDetalleGrupo.CurrentRow.Index).Value) Then
                lcuenta = "-"
                dataDetalleGrupo("cuenta_c", dataDetalleGrupo.CurrentRow.Index).Value = "-"
            Else
                lcuenta = dataDetalleGrupo("cuenta_c", dataDetalleGrupo.CurrentRow.Index).Value
            End If
            If IsDBNull(dataDetalleGrupo("cuenta_c_a1", dataDetalleGrupo.CurrentRow.Index).Value) Then
                lcuenta_a1 = "-"
                dataDetalleGrupo("cuenta_c_a1", dataDetalleGrupo.CurrentRow.Index).Value = "-"
            Else
                lcuenta_a1 = dataDetalleGrupo("cuenta_c_a1", dataDetalleGrupo.CurrentRow.Index).Value
            End If
            If IsDBNull(dataDetalleGrupo("cuenta_c_a2", dataDetalleGrupo.CurrentRow.Index).Value) Then
                lcuenta_a2 = "-"
                dataDetalleGrupo("cuenta_c_a2", dataDetalleGrupo.CurrentRow.Index).Value = "-"
            Else
                lcuenta_a2 = dataDetalleGrupo("cuenta_c_a2", dataDetalleGrupo.CurrentRow.Index).Value
            End If
            If IsDBNull(dataDetalleGrupo("cuenta_c_p", dataDetalleGrupo.CurrentRow.Index).Value) Then
                lcuenta_p = "-"
                dataDetalleGrupo("cuenta_c_p", dataDetalleGrupo.CurrentRow.Index).Value = "-"
            Else
                lcuenta_p = dataDetalleGrupo("cuenta_c_p", dataDetalleGrupo.CurrentRow.Index).Value
            End If
            Dim mCuenta As New Cuenta
            codigo = dataDetalleGrupo("cod_sgrupo", dataDetalleGrupo.CurrentRow.Index).Value
            If mCuenta.existeGrupo_enCuentas(codigo) Then
                mCuenta.actualizaCuentaComprasGrupo(codigo, lcuenta, lcuenta_a1, lcuenta_a2, lcuenta_p)
            Else
                mCuenta.insertaCuentaComprasGrupo(codigo, lcuenta, lcuenta_a1, lcuenta_a2, lcuenta_p)
            End If
        End If
    End Sub
    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        Dim frm As New rptForm
        Dim periodoReporte As String = general.devuelvePeriodoImpresion(pFechaSystem)
        Dim xGrupo As Boolean = IIf(cboGrupo.SelectedIndex >= 0, True, False)
        If pCatalogoXalmacen Then
            Dim mAlmacen As New Almacen
            If cboAlmacen.SelectedIndex >= 0 Then
                frm.cargarPlanCuentas(dsArticulo, periodoReporte & " - " & cboAlmacen.Text & IIf(xGrupo, ", Grupo: " & cboGrupo.Text, ""))
            Else
                frm.cargarPlanCuentas(dsArticulo, periodoReporte & IIf(xGrupo, " - Grupo: " & cboGrupo.Text, ""))
            End If
        Else
            frm.cargarPlanCuentas(dsArticulo, periodoReporte & IIf(xGrupo, " - Grupo: " & cboGrupo.Text, ""))
        End If
        frm.MdiParent = principal
        frm.Show()
    End Sub
    Private Sub cmdCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCerrar.Click
        Me.Close()
    End Sub
    Private Sub cmdActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdActualizar.Click
        Dim I As Integer = 0, cGrupo, cCuenta_v, cCuenta_v_c, cCuenta_c, cCuenta_c_a1, cCuenta_c_a2, cCuenta_c_p As String
        Dim mCatalogo As New Catalogo
        If dataDetalleGrupo.RowCount > 0 Then
            For I = 0 To dataDetalleGrupo.RowCount - 1
                cGrupo = dataDetalleGrupo("cod_sgrupo", I).Value
                cCuenta_v = IIf(IsDBNull(dataDetalleGrupo("cuenta_v", I).Value), "-", dataDetalleGrupo("cuenta_v", I).Value)
                cCuenta_v_c = IIf(IsDBNull(dataDetalleGrupo("cuenta_v_c", I).Value), "-", dataDetalleGrupo("cuenta_v_c", I).Value)
                cCuenta_c = IIf(IsDBNull(dataDetalleGrupo("cuenta_c", I).Value), "-", dataDetalleGrupo("cuenta_c", I).Value)
                cCuenta_c_a1 = IIf(IsDBNull(dataDetalleGrupo("cuenta_c_a1", I).Value), "-", dataDetalleGrupo("cuenta_c_a1", I).Value)
                cCuenta_c_a2 = IIf(IsDBNull(dataDetalleGrupo("cuenta_c_a2", I).Value), "-", dataDetalleGrupo("cuenta_c_a2", I).Value)
                cCuenta_c_p = IIf(IsDBNull(dataDetalleGrupo("cuenta_c_p", I).Value), "-", dataDetalleGrupo("cuenta_c_p", I).Value)
                mCatalogo.actualizaCuentaVentas("ss", cCuenta_v, cCuenta_v_c, True, cGrupo)
                mCatalogo.actualizaCuentaCompras("dd", cCuenta_c, cCuenta_c_a1, cCuenta_c_a2, cCuenta_c_p, True, cGrupo)
            Next
            MessageBox.Show("Proceso Terminado...")
        End If
    End Sub
    Private Sub TabItem2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabItem2.Click
        muestraCatalogo()
    End Sub

    Private Sub chkProduccion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkProduccion.CheckedChanged
        If chkProduccion.CheckState = CheckState.Checked Then
            chkProduccion.Text = "Insumos"
        Else
            chkProduccion.Text = "Producciones"
        End If
        muestraCatalogo()
        muestraPlanCuentasG()
        txtBuscar.Focus()
    End Sub

    Private Sub dataDetalle_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataDetalle.CellContentClick

    End Sub
End Class
