Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Math
Imports libreriaClases
Public Class m_precios
    Private dsCatalogo As New DataSet
    Private dsCatalogoCliente As New DataSet
    Private dsTipoCliente As New DataSet
    Private dsTipoPrecio As New DataSet
    Private dsUnidad As New DataSet
    Private dsAlmacen As New DataSet
    Private dsPrecios As New DataSet
    Private dtPrecios As DataTable
    Private estaCargando As Boolean = True
    Private daPrecios As New MySqlDataAdapter
    Private cbPrecios As MySqlCommandBuilder = New MySqlCommandBuilder(daPrecios)
    Private bsprecios As New BindingSource
    'para validar el separador decimal
    Private sepDecimal As Char
    Private Sub m_precios_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        principal.ma_precios.Enabled = True
    End Sub
    Private Sub m_precios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Top = 0
        Me.Left = 0
        'capturamos el separador decimal
        sepDecimal = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        'dataset almacen origen
        Dim daAlmacen As New MySqlDataAdapter
        Dim comAlmacen As New MySqlCommand("select cod_alma,nom_alma from almacen " _
                    & "where activo=1 and ((esCompras) or (esProduccion)) order by nom_alma", dbConex)
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

        'dataset Unidades
        Dim daUnidad As New MySqlDataAdapter
        Dim comUnidad As New MySqlCommand("select cod_uni,nom_uni from unidad where activo order by nom_uni", dbConex)
        daUnidad.SelectCommand = comUnidad
        daUnidad.Fill(dsUnidad, "unidad")
        With cbounidad
            .DataSource = dsUnidad.Tables("unidad")
            .DisplayMember = dsUnidad.Tables("unidad").Columns("nom_uni").ToString
            .ValueMember = dsUnidad.Tables("unidad").Columns("cod_uni").ToString
            If dsUnidad.Tables("unidad").Rows.Count > 0 Then
                .SelectedIndex = 0
            Else
                .SelectedIndex = -1
            End If
        End With

        'dataset tipo de Precio
        Dim daTipoPrecio As New MySqlDataAdapter
        Dim comTipoPrecio As New MySqlCommand("select cod_precio,nom_precio from tipo_precio WHERE esventa=0 and activo", dbConex)
        daTipoPrecio.SelectCommand = comTipoPrecio
        daTipoPrecio.Fill(dsTipoPrecio, "tipo_Precio")
        With cbotip_precio
            .DataSource = dsTipoPrecio.Tables("tipo_Precio")
            .DisplayMember = dsTipoPrecio.Tables("tipo_Precio").Columns("nom_precio").ToString
            .ValueMember = dsTipoPrecio.Tables("tipo_Precio").Columns("cod_precio").ToString
            If dsTipoPrecio.Tables("tipo_Precio").Rows.Count > 0 Then
                .SelectedIndex = 0
            Else
                .SelectedIndex = -1
            End If
        End With

        'dataset tipo de cliente
        Dim daTipoCliente As New MySqlDataAdapter
        Dim comTipoCliente As New MySqlCommand("select cod_tipo,nom_tipo from tipo_cliente where activo=1", dbConex)
        daTipoCliente.SelectCommand = comTipoCliente
        daTipoCliente.Fill(dsTipoCliente, "tipo_cliente")
        With cboTipoCliente
            .DataSource = dsTipoCliente.Tables("tipo_cliente")
            .DisplayMember = dsTipoCliente.Tables("tipo_cliente").Columns("nom_tipo").ToString
            .ValueMember = dsTipoCliente.Tables("tipo_cliente").Columns("cod_tipo").ToString
            If dsTipoCliente.Tables("tipo_cliente").Rows.Count > 0 Then
                .SelectedIndex = 0
            Else
                .SelectedIndex = -1
            End If
        End With
        'cargamos el catalogo en funcion al modo de trabajo
        'catalogo x almacen de produccion o unico catalogo
        'Peridodos
        Dim mes, anno As Integer
        mes = Month(pFechaActivaMax)
        anno = Year(pFechaActivaMax)
        cboMes.SelectedIndex = mes - 1
        cboAnno.SelectedIndex = anno - 2010
        '--------------------------------------------------------

        cargaCatalogo()
        txtPrecio.Text = 0.00000
        'dsArtTipoCliente = cargaCatalogo()
        'estructuraTipoCliente()
        estaCargando = False
    End Sub
    Private Sub cboAlmacen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAlmacen.SelectedIndexChanged
        If Not estaCargando Then
            cargaCatalogo()
        End If
    End Sub
    Private Sub chkProducciones_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkProducciones.CheckedChanged
        If Not estaCargando Then
            cargaCatalogo()
        End If
    End Sub
    Sub cargaCatalogo()
        Dim mCatalogo As New Catalogo
        Dim mAlmacen As New Almacen
        'verificamos el modo de trabajo
        'Catalogo x Almacen de Produccion o Catalogo General
        dsCatalogo.Clear()
        cboAlmacen.Enabled = True
        'If pCatalogoXalmacen Then
        Dim esProd As Boolean = mAlmacen.esDeProduccion(cboAlmacen.SelectedValue)
        If esProd Then
            If chkProducciones.Checked = True Then
                dsCatalogo = mCatalogo.recuperaRecetas(cboAlmacen.SelectedValue, False, "", False, "", True, "nom_art")
                estructuraRecetas()
            Else
                dsCatalogo = mCatalogo.recuperaCatalogo(pCatalogoXalmacen, cboAlmacen.SelectedValue, True, False, False, False, "", False, False, False)
                estructuraCatalogo()
            End If
        Else
            dsCatalogo = mCatalogo.recuperaCatalogo(pCatalogoXalmacen, cboAlmacen.SelectedValue, True, False, False, False, "", False, False, False)
            estructuraCatalogo()
        End If
        'Else
        '    cboAlmacen.SelectedIndex = -1
        '    '  cboAlmacen.Enabled = False
        '    dsCatalogo = mCatalogo.recuperaCatalogo(cboAlmacen.SelectedValue, True, False, False, "", False, False, False)
        'End If
    End Sub
    Sub estructuraCatalogo()
        With datosGeneral
            .DataSource = dsCatalogo.Tables("articulo").DefaultView
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
            .Columns("pre_costo").HeaderText = "Precio Costo"
            .Columns("pre_costo").Width = 70
            .Columns("pre_costo").ReadOnly = False
            .Columns("pre_costo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("pre_costo").DefaultCellStyle.BackColor = Color.AliceBlue
            .Columns("pre_costo").DefaultCellStyle.ForeColor = Color.MidnightBlue
            .Columns("pre_costoMin").HeaderText = "Precio CostoMin."
            .Columns("pre_costoMin").Width = 70
            .Columns("pre_costoMin").ReadOnly = False
            .Columns("pre_costoMin").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("pre_costoMax").HeaderText = "Precio CostoMax."
            .Columns("pre_costoMax").Width = 70
            .Columns("pre_costoMax").ReadOnly = False
            .Columns("pre_costoMax").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("pre_venta").HeaderText = "Precio Venta"
            .Columns("pre_venta").Width = 70
            .Columns("pre_venta").ReadOnly = False
            .Columns("pre_venta").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("pre_venta").DefaultCellStyle.BackColor = Color.AliceBlue
            .Columns("pre_venta").DefaultCellStyle.ForeColor = Color.MidnightBlue
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
            .Columns("nom_sgrupo").Visible = False
            .Columns("cod_sgrupo").Visible = False
            .Columns("esProduccion").Visible = False
            .Columns("activo").Visible = False
        End With
    End Sub
    Sub estructuraRecetas()
        With datosGeneral
            .DataSource = dsCatalogo.Tables("articulo").DefaultView
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_art").HeaderText = "Código"
            .Columns("cod_art").Width = 55
            .Columns("cod_art").ReadOnly = True
            .Columns("cod_art").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("nom_art").HeaderText = "Descripción"
            .Columns("nom_art").Width = 270
            .Columns("nom_art").ReadOnly = True
            .Columns("nom_uni").HeaderText = "Unidad"
            .Columns("nom_uni").Width = 60
            .Columns("nom_uni").ReadOnly = True
            .Columns("nom_uni").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("pre_costo").HeaderText = "Precio Costo"
            .Columns("pre_costo").Width = 70
            .Columns("pre_costo").ReadOnly = False
            .Columns("pre_costo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("pre_costo").DefaultCellStyle.BackColor = Color.AliceBlue
            .Columns("pre_costo").DefaultCellStyle.ForeColor = Color.MidnightBlue
            .Columns("pre_costoMin").HeaderText = "Precio CostoMin."
            .Columns("pre_costoMin").Width = 70
            .Columns("pre_costoMin").ReadOnly = False
            .Columns("pre_costoMin").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("pre_costoMax").HeaderText = "Precio CostoMax."
            .Columns("pre_costoMax").Width = 70
            .Columns("pre_costoMax").ReadOnly = False
            .Columns("pre_costoMax").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("pre_venta").HeaderText = "Precio Venta"
            .Columns("pre_venta").Width = 70
            .Columns("pre_venta").ReadOnly = False
            .Columns("pre_venta").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("pre_venta").DefaultCellStyle.BackColor = Color.AliceBlue
            .Columns("pre_venta").DefaultCellStyle.ForeColor = Color.MidnightBlue
            .Columns("pre_inc_imp").Visible = False
            .Columns("cod_artExt").Visible = False
            .Columns("cod_uni").Visible = False
            .Columns("inv_diario").Visible = False
            .Columns("afecto_igv").Visible = False
            .Columns("maximo").Visible = False
            .Columns("minimo").Visible = False
            .Columns("nom_sgrupo").Visible = False
            .Columns("cod_sgrupo").Visible = False
            .Columns("activo").Visible = False
        End With
    End Sub
    Sub estructuraTipoCliente()
        With datosTipoCliente
            .DataSource = dsCatalogoCliente.Tables("articulo").DefaultView
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_art").HeaderText = "Código"
            .Columns("cod_art").Width = 55
            .Columns("cod_art").ReadOnly = True
            .Columns("cod_art").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("nom_art").HeaderText = "Descripción"
            .Columns("nom_art").Width = 270
            .Columns("nom_art").ReadOnly = True
            .Columns("nom_uni").HeaderText = "Unidad"
            .Columns("nom_uni").Width = 60
            .Columns("nom_uni").ReadOnly = True
            .Columns("nom_uni").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("pre_costo").HeaderText = "Precio Costo"
            .Columns("pre_costo").Width = 80
            .Columns("pre_costo").ReadOnly = False
            .Columns("pre_costo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("pre_prom").HeaderText = "Precio Promedio"
            .Columns("pre_prom").Width = 80
            .Columns("pre_prom").ReadOnly = False
            .Columns("pre_prom").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("pre_venta").HeaderText = "Precio Venta"
            .Columns("pre_venta").Width = 80
            .Columns("pre_venta").ReadOnly = False
            .Columns("pre_venta").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("pre_inc_imp").Visible = False
            .Columns("imp").Visible = False
            .Columns("cod_artExt").Visible = False
            .Columns("cuenta_v").Visible = False
            .Columns("cuenta_v_c").Visible = False
            .Columns("cuenta_c").Visible = False
            .Columns("cuenta_c_p").Visible = False
            .Columns("cuenta_c_a1").Visible = False
            .Columns("cuenta_c_a2").Visible = False
            .Columns("cod_uni").Visible = False
            .Columns("pre_costoMin").Visible = False
            .Columns("pre_costoMax").Visible = False
            .Columns("pre_ult").Visible = False
            .Columns("afecto_igv").Visible = False
            .Columns("cod_sgrupo").Visible = False
            .Columns("nom_sgrupo").Visible = False
            .Columns("maximo").Visible = False
            .Columns("minimo").Visible = False
            .Columns("activo").Visible = False
        End With
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
            dsCatalogo.Tables("articulo").DefaultView.RowFilter = "cod_art LIKE '" & valor & "%'"
            If datosGeneral.RowCount > 0 Then
                datosGeneral.CurrentCell = datosGeneral("cod_art", datosGeneral.CurrentRow.Index)
            End If
        Else
            dsCatalogo.Tables("articulo").DefaultView.RowFilter = "nom_art LIKE '" & valor & "%'"
            If datosGeneral.RowCount > 0 Then
                datosGeneral.CurrentCell = datosGeneral("nom_art", datosGeneral.CurrentRow.Index)
            End If
        End If
    End Sub
    Function periodoSeleccionado()
        Dim periodo As String = Trim(Str(cboAnno.SelectedIndex + 2010)) _
                & Microsoft.VisualBasic.Right("00" & Trim(Str(cboMes.SelectedIndex + 1)), 2)
        Return periodo
    End Function
    Private Sub cmdPromedio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPromedio.Click
        Dim mCatalogo As New Catalogo, mPrecio As New ePrecio, I As Integer = 0
        Dim mAlmacen As New Almacen, mArticulo As New Catalogo, mUnidad As New Unidad
        Dim cPrecioProm As String = general.strPrecioCostoPromedio, cod_art As String = ""
        Dim nPrecioProm As Decimal
        Dim cant_uni, costo As Decimal
        'Dim cUniDivisible1, cUniDivisible2 As Boolean
        Dim periodo As String = periodoSeleccionado()
        Dim esHistorial As Boolean = IIf(periodo = periodoActivo(), False, True)
        If datosGeneral.RowCount > 0 Then
            lblProcesados.Visible = True
            For I = 0 To datosGeneral.RowCount - 1
                cod_art = datosGeneral.Item("cod_art", I).Value
                cant_uni = datosGeneral.Item("cant_uni", I).Value
                costo = datosGeneral.Item("pre_costo", I).Value
                'nPrecioProm = mPrecio.calculaPrecioPromedio(esHistorial, periodo, cod_art, cPrecioProm)
                nPrecioProm = mPrecio.calculaPrecioUltimo(esHistorial, periodo, cod_art, cPrecioProm)

                If nPrecioProm > 0 Then
                    mPrecio.actualizaCostoArticulo(esHistorial, periodo, cod_art, nPrecioProm)
                Else
                    nPrecioProm = costo
                End If
                If Not esHistorial Then
                    mPrecio.actualizaPrecioPromedio(cod_art)
                End If
                ''actualizamos el costo de los productos relacionados -1
                'cod_artRel1 = mAlmacen.devuelveCodigoArtRelacionado(cod_art, "0002")
                'cCod_uni1 = mUnidad.devuelveUnidad(cod_artRel1)
                'cant_uniRel1 = mUnidad.devuelveCantUnidad(cCod_uni1)
                'cUniDivisible1 = mUnidad.esDivisible(cCod_uni1)
                'If cUniDivisible1 Then
                '    nPrecioProm1 = (nPrecioProm / cant_uni) * cant_uniRel1
                'Else
                '    nPrecioProm1 = nPrecioProm
                'End If
                'mPrecio.actualizaCostoArticulo(cod_artRel1, nPrecioProm1)
                ''actualizamos el costo de los productos relacionados -2
                'cod_artRel2 = mAlmacen.devuelveCodigoArtRelacionado(cod_art, "0003")
                'cCod_uni2 = mUnidad.devuelveUnidad(cod_artRel2)
                'cant_unirel2 = mUnidad.devuelveCantUnidad(cCod_uni2)
                'cUniDivisible2 = mUnidad.esDivisible(cCod_uni2)
                'If cUniDivisible2 Then
                '    nPrecioProm2 = (nPrecioProm / cant_uni) * cant_unirel2
                'Else
                '    nPrecioProm2 = nPrecioProm
                'End If
                'mPrecio.actualizaCostoArticulo(cod_artRel2, nPrecioProm2)
                ''actualizamos el costo de los productos limpios -1
                'If mCatalogo.existeEnLimpios(cod_artRel1) Then
                '    cod_artLimpio = mCatalogo.devuelveCodigoLimpio(cod_artRel1)
                '    cant_limpio = mCatalogo.devuelveCantCodigoLimpio(cod_artLimpio)
                '    If cant_limpio > 0 Then
                '        mPrecio.actualizaPrecioPromedio(cod_artLimpio)
                '    End If
                'End If
                ''actualizamos el costo de los productos limpios -2
                'If mCatalogo.existeEnLimpios(cod_artRel2) Then
                '    cod_artLimpio = mCatalogo.devuelveCodigoLimpio(cod_artRel2)
                '    cant_limpio = mCatalogo.devuelveCantCodigoLimpio(cod_artLimpio)
                '    If cant_limpio > 0 Then
                '        mPrecio.actualizaPrecioPromedio(cod_artLimpio)
                '    End If
                'End If
                lblProcesados.Text = I + 1 & " de " & datosGeneral.RowCount
                lblProcesados.Refresh()
            Next
            dsCatalogo.Clear()
            cargaCatalogo()
            MessageBox.Show("Proceso Terminado...", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            lblProcesados.Visible = False
        End If
    End Sub
    Private Sub optMin10_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optMin10.CheckedChanged
        If optMin10.Checked = True Then
            txtPorcentMin.Text = ""
        End If
    End Sub
    Private Sub optDefMin_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optDefMin.CheckedChanged
        If optDefMin.Checked = True Then
            txtPorcentMin.Focus()
        End If
    End Sub
    Private Sub txtPorcentMin_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPorcentMin.GotFocus
        optDefMin.Checked = True
    End Sub
    Private Sub txtPorcentmin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPorcentMin.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not (e.KeyChar = ChrW(Keys.Back)) And Not (e.KeyChar.Equals(sepDecimal)) Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub cmdGenerarMin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdlGenerarMin.Click
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim cad As String, cant As Decimal
        cant = IIf(Val(txtPorcentMin.Text) > 0, Val(txtPorcentMin.Text) / 100, 0)
        If optMin10.Checked = True Then
            cad = "Update articulo set pre_costoMin=pre_costo - pre_costo * 0.1"
        Else
            cad = "Update articulo set pre_costoMin=pre_costo - pre_costo *" & cant
        End If
        com.CommandText = cad
        com.ExecuteNonQuery()
        clConex.Close()
        dsCatalogo.Clear()
        cargaCatalogo()
        datosGeneral.DataSource = dsCatalogo.Tables("articulo").DefaultView
        MessageBox.Show("Proceso Finalizado...", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        txtBuscarGeneral.Focus()
    End Sub
    Private Sub optMax10_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optMax10.CheckedChanged
        If optMax10.Checked = True Then
            txtPorcentMax.Text = ""
        End If
    End Sub
    Private Sub optDefMax_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optDefMax.CheckedChanged
        If optDefMax.Checked = True Then
            txtPorcentMax.Focus()
        End If
    End Sub
    Private Sub txtPorcentMax_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPorcentMax.GotFocus
        optDefMax.Checked = True
    End Sub
    Private Sub txtPorcentMax_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPorcentMax.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not (e.KeyChar = ChrW(Keys.Back)) And Not (e.KeyChar.Equals(sepDecimal)) Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub cmdGenerarMax_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGenerarMax.Click
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim cad As String, cant As Decimal
        cant = IIf(Val(txtPorcentMax.Text) > 0, Val(txtPorcentMax.Text) / 100, 0)
        If optMax10.Checked = True Then
            cad = "Update articulo set pre_costoMax=pre_costo + pre_costo * 0.1"
        Else
            cad = "Update articulo set pre_costoMax=pre_costo + pre_costo *" & cant
        End If
        com.CommandText = cad
        com.ExecuteNonQuery()
        clConex.Close()
        dsCatalogo.Clear()
        cargaCatalogo()
        datosGeneral.DataSource = dsCatalogo.Tables("articulo").DefaultView
        MessageBox.Show("Proceso Finalizado...", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        txtBuscarGeneral.Focus()
    End Sub
    Private Sub optVenta10_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optVenta10.CheckedChanged
        If optMax10.Checked = True Then
            txtPorcentVenta.Text = ""
        End If
    End Sub
    Private Sub optDefVenta_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optDefVenta.CheckedChanged
        If optDefMax.Checked = True Then
            txtPorcentVenta.Focus()
        End If
    End Sub
    Private Sub txtPorcentVenta_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPorcentVenta.GotFocus
        optDefVenta.Checked = True
    End Sub
    Private Sub txtPorcentVenta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPorcentVenta.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not (e.KeyChar = ChrW(Keys.Back)) And Not (e.KeyChar.Equals(sepDecimal)) Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub cmdGenerarPreVenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGenerarPreVenta.Click
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim cad As String, cant As Decimal
        cant = IIf(Val(txtPorcentVenta.Text) > 0, Val(txtPorcentVenta.Text) / 100, 0)
        If optCosto.Checked = True Then
            If optVenta10.Checked = True Then
                cad = "Update articulo set pre_venta=pre_costo + pre_costo * 0.1"
            Else
                cad = "Update articulo set pre_venta=pre_costo + pre_costo *" & cant
            End If
        Else
            If optVenta10.Checked = True Then
                cad = "Update articulo set pre_venta=pre_prom + pre_prom * 0.1"
            Else
                cad = "Update articulo set pre_venta=pre_prom + pre_prom *" & cant
            End If
        End If
        com.CommandText = cad
        com.ExecuteNonQuery()
        clConex.Close()
        dsCatalogo.Clear()
        cargaCatalogo()
        datosGeneral.DataSource = dsCatalogo.Tables("articulo").DefaultView
        MessageBox.Show("Proceso Finalizado...", "CEFE", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        txtBuscarGeneral.Focus()
    End Sub
    Private Sub datosGeneral_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datosGeneral.CellEndEdit
        Dim codigo As String, lpreCosto, lpreCostoMax, lpreVenta As Decimal
        If datosGeneral.CurrentCell.ColumnIndex = datosGeneral.Columns("pre_costo").Index Then
            If IsDBNull(datosGeneral("pre_costo", datosGeneral.CurrentRow.Index).Value) Then
                lpreCosto = 0
                datosGeneral("pre_costo", datosGeneral.CurrentRow.Index).Value = 0
            Else
                lpreCosto = datosGeneral("pre_costo", datosGeneral.CurrentRow.Index).Value
            End If
            Dim mCatalogo As New Catalogo
            codigo = datosGeneral("cod_art", datosGeneral.CurrentRow.Index).Value
            mCatalogo.actualizaPrecioCompra(codigo, lpreCosto)
        End If
        If datosGeneral.CurrentCell.ColumnIndex = datosGeneral.Columns("pre_costoMax").Index Then
            If IsDBNull(datosGeneral("pre_costoMax", datosGeneral.CurrentRow.Index).Value) Then
                lpreCostoMax = 0
                datosGeneral("pre_costoMax", datosGeneral.CurrentRow.Index).Value = 0
            Else
                lpreCostoMax = datosGeneral("pre_costoMax", datosGeneral.CurrentRow.Index).Value
            End If
            Dim mCatalogo As New Catalogo
            codigo = datosGeneral("cod_art", datosGeneral.CurrentRow.Index).Value
            mCatalogo.actualizaPrecioCompraMax(codigo, lpreCostoMax)
        End If
        If datosGeneral.CurrentCell.ColumnIndex = datosGeneral.Columns("pre_venta").Index Then
            If IsDBNull(datosGeneral("pre_venta", datosGeneral.CurrentRow.Index).Value) Then
                lpreVenta = 0
                datosGeneral("pre_venta", datosGeneral.CurrentRow.Index).Value = 0
            Else
                lpreVenta = datosGeneral("pre_venta", datosGeneral.CurrentRow.Index).Value
            End If
            Dim mCatalogo As New Catalogo
            codigo = datosGeneral("cod_art", datosGeneral.CurrentRow.Index).Value
            mCatalogo.actualizaPrecioVenta(codigo, lpreVenta)
        End If
    End Sub
    Private Sub datosGeneral_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles datosGeneral.EditingControlShowing
        'referenciamos la celda
        Dim validar As TextBox = CType(e.Control, TextBox)
        'agregamos el controlador de eventos para el evento KeyPress
        AddHandler validar.KeyPress, AddressOf validar_KeyPress
    End Sub
    Private Sub validar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        'obtenemos el indice de la columna
        Dim columna As Integer = datosGeneral.CurrentCell.ColumnIndex
        If columna = datosGeneral.Columns("pre_venta").Index Or columna = datosGeneral.Columns("pre_costoMax").Index Then
            If Not Char.IsNumber(e.KeyChar) And Not (e.KeyChar = ChrW(Keys.Back)) And Not (e.KeyChar.Equals(sepDecimal)) Then
                e.KeyChar = ""
            End If
        End If
    End Sub
    Private Sub optCodigoTipoCliente_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optCodigoTipoCliente.CheckedChanged
        txtBuscarTipoCliente.Focus()
    End Sub
    Private Sub optDescripcionTipoCliente_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optDescripcionTipoCliente.CheckedChanged
        txtBuscarTipoCliente.Focus()
    End Sub
    Private Sub txtBuscarTipoCliente_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscarTipoCliente.TextChanged
        Dim valor As String = txtBuscarTipoCliente.Text
        If optCodigoTipoCliente.Checked = True Then
            dsCatalogoCliente.Tables("articulo").DefaultView.RowFilter = "cod_art LIKE '" & valor & "%'"
            If datosTipoCliente.RowCount > 0 Then
                datosTipoCliente.CurrentCell = datosTipoCliente("cod_art", datosGeneral.CurrentRow.Index)
            End If
        Else
            'dsCatalogoCliente.Tables("articulo").DefaultView.RowFilter = "nom_art LIKE '" & valor & "%'"
            'If datosTipoCliente.RowCount > 0 Then
            '    datosTipoCliente.CurrentCell = datosTipoCliente("nom_art", datosTipoCliente.CurrentRow.Index)
            'End If
        End If
    End Sub
    Private Sub optPVenta10_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optPVenta10.CheckedChanged
        If optPVenta10.Checked = True Then
            txtTipoClientePorcentaje.Text = ""
            grpPorcentaje.Text = "10% sobre el Costo"
        End If
    End Sub
    Private Sub optPVentaDef_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optPVentaDef.CheckedChanged
        If optPVentaDef.Checked = True Then
            grpPorcentaje.Text = "0% sobre el Costo"
            txtTipoClientePorcentaje.Focus()
        End If
    End Sub
    Private Sub txtTipoClientePorcentaje_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTipoClientePorcentaje.GotFocus
        optPVentaDef.Checked = True
    End Sub
    Private Sub txtTipoClientePorcentaje_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTipoClientePorcentaje.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not (e.KeyChar = ChrW(Keys.Back)) And Not (e.KeyChar.Equals(sepDecimal)) Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub txtTipoClientePorcentaje_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTipoClientePorcentaje.TextChanged
        If Microsoft.VisualBasic.Len(txtTipoClientePorcentaje.Text) > 0 Then
            grpPorcentaje.Text = txtTipoClientePorcentaje.Text & "% sobre el Costo"
        Else
            grpPorcentaje.Text = "0% sobre el Costo"
        End If
    End Sub

    Private Sub TabControl1_Click(sender As Object, e As EventArgs) Handles TabControl1.Click

    End Sub

    Private Sub datosGeneral_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datosGeneral.CellContentClick

    End Sub

    Private Sub datosGeneral_SelectionChanged(sender As Object, e As EventArgs) Handles datosGeneral.SelectionChanged
        Dim cod_art As String
        If Not estaCargando Then
            lblproducto.Text = "PRODUCTO : "
            If datosGeneral.RowCount > 0 Then
                lblproducto.Text = "PRODUCTO : " & datosGeneral("nom_art", datosGeneral.CurrentRow.Index).Value
                cod_art = datosGeneral("cod_art", datosGeneral.CurrentRow.Index).Value
                muestraprecio(cod_art)

                'calcularcostoreceta(cod_art)
            End If
        End If
    End Sub
    Sub muestraprecio(ByVal cod_art As String)

        'Dim mPrecio As New ePrecio
        'dsPrecios.Clear()
        'cargamos el dataset
        txtcod_art.Text = cod_art
        dsPrecios = ePrecio.dsprecios
        'cargamos el datatable
        dtPrecios = dsPrecios.Tables("precios")

        Dim cad As String
        cad = "select a.* from art_precio a where cod_precio='000' and cod_art= '" & cod_art & "'"
        '" inner join unidad u on a.cod_uni = u.cod_uni" &
        'creamos y trabajamos con el comando a ejecutar
        Dim com As New MySqlCommand(cad, dbConex)
        daPrecios.SelectCommand = com

        'Dim comTrans As New MySqlCommand(cad)
        'comTrans.Connection = dbConex
        'daPrecios.SelectCommand = comTrans
        daPrecios.Fill(dsPrecios, "precios")


        'dsPrecios = mPrecio.RecuperaPreciosCompra(cod_art)
        bsprecios.DataSource = dsPrecios
        bsprecios.DataMember = "precios"

        estructuraPrecios()

    End Sub

    Sub estructuraPrecios()
        With DataPrecios
            .DataSource = bsprecios
            '.DataSource = dsPrecios.Tables("precio").DefaultView
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_precio").HeaderText = "TIPO"
            .Columns("cod_precio").Width = 70
            .Columns("cod_precio").ReadOnly = True
            .Columns("cod_precio").DisplayIndex = 0
            .Columns("cod_precio").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_uni").HeaderText = "Unidad"
            .Columns("cod_uni").Width = 70
            .Columns("cod_uni").ReadOnly = True
            .Columns("cod_uni").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_uni").DisplayIndex = 1
            .Columns("precio").HeaderText = "Precio"
            .Columns("precio").Width = 70
            .Columns("precio").ReadOnly = False
            .Columns("precio").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("precio").DefaultCellStyle.BackColor = Color.AliceBlue
            .Columns("precio").DefaultCellStyle.ForeColor = Color.MidnightBlue
            .Columns("precio").DisplayIndex = 2
            .Columns("cod_art").Visible = False
            .Columns("nom_uni").Visible = False
            .Columns("tip_precio").Visible = False

            txtcod_art.DataBindings.Clear()
            txtPrecio.DataBindings.Clear()
            cbotip_precio.DataBindings.Clear()
            cboUnidad.DataBindings.Clear()


            txtcod_art.DataBindings.Add("text", bsprecios, "cod_art")
            txtPrecio.DataBindings.Add("text", bsprecios, "precio")
            cbotip_precio.DataBindings.Add("selectedValue", bsprecios, "cod_precio")
            cboUnidad.DataBindings.Add("selectedValue", bsprecios, "cod_uni")


        End With
    End Sub

    Private Sub cmdAñadir_Click(sender As Object, e As EventArgs) Handles cmdAñadir.Click

        habilitaDetalle()
        deshabilitaCabecera()
        bsprecios.AddNew()
        DataPrecios.DataSource = bsprecios
        modoGrabar()
        cbotip_precio.Refresh()
        cboUnidad.Refresh()
        cbotip_precio.Focus()
        'txtPrecio.Text = 0.00000

    End Sub
    Sub habilitaDetalle()
        lblCodigo.ForeColor = Color.Maroon
        lblUnidad.ForeColor = Color.Maroon
        lblCantUnidad.ForeColor = Color.Maroon
        cbotip_precio.BackColor = Color.White
        cbotip_precio.Enabled = True
        cboUnidad.BackColor = Color.White
        cboUnidad.Enabled = True
        txtPrecio.BackColor = Color.White
        txtPrecio.ReadOnly = False

    End Sub

    Sub habilitaCabecera()
        DataPrecios.Enabled = True
    End Sub
    Sub deshabilitaCabecera()
        DataPrecios.Enabled = False
    End Sub
    Sub modoAñadir()
        cmdAñadir.Enabled = True
        cmdGrabar.Enabled = False
        cmdCancelar.Enabled = False
        cmdEditar.Enabled = True
        cmdEliminar.Enabled = True
    End Sub
    Sub modoGrabar()
        cmdAñadir.Enabled = False
        cmdGrabar.Enabled = True
        cmdCancelar.Enabled = True
        cmdEditar.Enabled = False
        cmdEliminar.Enabled = False
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        bsprecios.CancelEdit()
        DataPrecios.Refresh()
        deshabilitaDetalle()
        habilitaCabecera()
        modoAñadir()
        DataPrecios.Focus()
        If DataPrecios.Rows.Count > 0 Then
            DataPrecios.CurrentCell = DataPrecios(1, 0)
        End If
    End Sub

    Sub deshabilitaDetalle()
        lblCodigo.ForeColor = Color.Black
        lblUnidad.ForeColor = Color.Black
        lblCantUnidad.ForeColor = Color.Black
        cbotip_precio.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        cbotip_precio.Enabled = False
        cboUnidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        cboUnidad.Enabled = False
        txtPrecio.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        txtPrecio.ReadOnly = True

    End Sub

    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles cmdGrabar.Click

        Try
            If validaIngreso() Then
                txtcod_art.Text = datosGeneral.Item("cod_art", datosGeneral.CurrentRow.Index).Value
                bsprecios.EndEdit()
                daPrecios.Update(dsPrecios, "precios")
                DataPrecios.Refresh()
                deshabilitaDetalle()
                habilitaCabecera()
                modoAñadir()
                DataPrecios.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            bsprecios.CancelEdit()
            DataPrecios.Refresh()
            deshabilitaDetalle()
            habilitaCabecera()
            modoAñadir()
            DataPrecios.Focus()
        End Try
    End Sub

    Function validaIngreso()
        Dim validado As Boolean = False
        validado = True

        Return validado
    End Function

    Private Sub cmdEliminar_Click(sender As Object, e As EventArgs) Handles cmdEliminar.Click
        If bsprecios.Count > 0 Then
            Dim mUnidad As New Unidad, exist As Boolean, rpta As Integer
            'exist = mUnidad.existeEnCatalogo(Trim(txtCodigo.Text))
            If Not exist Then
                rpta = MessageBox.Show("¿Esta seguro de Eliminar el ITEM Seleccionado...", "SGA", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                If rpta = 6 Then
                    If bsprecios.Count > 0 Then
                        bsprecios.RemoveCurrent()
                        daPrecios.Update(dsPrecios, "precios")
                        DataPrecios.Refresh()
                    End If
                End If
            Else
                MessageBox.Show("El Registro Tiene Datos Relacionados..." + Chr(13) + "!NO Es posible eliminarlo¡", "CEFE", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button2)
            End If
        End If
    End Sub

    Private Sub cmdEditar_Click(sender As Object, e As EventArgs) Handles cmdEditar.Click
        If bsprecios.Count > 0 Then
            habilitaDetalle()
            deshabilitaCabecera()
            modoGrabar()
            cbotip_precio.Focus()
        End If
    End Sub

    Private Sub DataPrecios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataPrecios.CellContentClick

    End Sub
End Class
