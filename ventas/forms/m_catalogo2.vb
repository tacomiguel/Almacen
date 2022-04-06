Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic
Imports System.Data
Imports libreriaClases
Public Class m_catalogo2
    'creamos el BindingSource que relacionara los datos con los controles
    Private bsArticulo As New BindingSource
    Private daArticulo As New MySqlDataAdapter
    Private dsCatalogo As DataSet
    Private dsLimpios As New DataSet
    Private dsAlmacen As New DataSet
    Private cbArticulo As MySqlCommandBuilder = New MySqlCommandBuilder(daArticulo)
    Private dtArticulo As DataTable
    Private dtUnidad As DataTable
    Private dtTipo As DataTable
    Private dtSGrupo As DataTable
    '
    Private mdssubgrupo As New DataSet
    Private mdsTipoArticulo As New DataSet
    '
    Private dsCatalogoGeneral As New DataSet
    Private dsCatalogoAlmacen As New DataSet
    Private dsArticulosRelacionados As New DataSet
    Private dsListaRelacionados As New DataSet
    Private estaCargando As Boolean = True
    Private cAlmaPrincipal As String = "0001"
    'capturamos el boton pulsado
    Private lcBoton As String
    'capturamos el codigo del articulo-esto para la edicion
    Private lCodigo As String
    'para validar el separador decimal
    Private sepDecimal As Char
    Private Sub m_catalogo_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        principal.ma_catalogo2.Enabled = True
    End Sub
    Private Sub m_catalogo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Top = 0
        Me.Left = 0
        'capturamos el separador decimal
        sepDecimal = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        'dataset almacen
        Dim daAlmacen As New MySqlDataAdapter
        Dim cadAlma As String
        If pAlmaUser = "0000" Or pAlmaUser = cAlmaPrincipal Then
            cadAlma = "select cod_alma,nom_alma from almacen where (esProduccion) and activo=1"
        Else
            cadAlma = "select cod_alma,nom_alma from almacen where cod_alma='" & pAlmaUser & "'" _
                    & " and (esProduccion) and activo=1"
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
        Dim cAlmacen As String = cboAlmacen.SelectedValue
        'dataset catalogo
        cargaCatalogo(cAlmacen)
        'dataset unidad
        dtUnidad = dsCatalogo.Tables("unidad")
        Dim daUnidad As New MySqlDataAdapter
        Dim comUnidad As New MySqlCommand("select * from unidad where activo=1 order by nom_uni", dbConex)
        daUnidad.SelectCommand = comUnidad
        daUnidad.Fill(dsCatalogo, "unidad")
        'dataset tipo de articulo
        dtTipo = dsCatalogo.Tables("tipo_articulo")
        Dim daTipo As New MySqlDataAdapter
        Dim comTipo As New MySqlCommand("select * from tipo_articulo where activo=1 order by nom_tart", dbConex)
        daTipo.SelectCommand = comTipo
        daTipo.Fill(dsCatalogo, "tipo_articulo")
        'dataset sub grupo
        dtSGrupo = dsCatalogo.Tables("subgrupo")
        Dim daSGrupo As New MySqlDataAdapter
        Dim comSGrupo As New MySqlCommand("select * from subgrupo where activo=1 and not (esProduccion) order by nom_sgrupo", dbConex)
        daSGrupo.SelectCommand = comSGrupo
        daSGrupo.Fill(dsCatalogo, "subgrupo")
        'relacionamos los cuadros de texto con los campos respectivos
        txtCodigo.DataBindings.Clear()
        txtCodigo.DataBindings.Add("text", bsArticulo, "cod_art", True)
        TxtCodigoVta.DataBindings.Add("text", bsArticulo, "cod_artext")
        txtDescripcion.DataBindings.Add("text", bsArticulo, "nom_art")
        txtUnidad.DataBindings.Add("text", bsArticulo, "nom_uni")
        txtCosto.DataBindings.Add("text", bsArticulo, "pre_costo")
        txtCostoMax.DataBindings.Add("text", bsArticulo, "pre_costoMax")
        txtCostoMin.DataBindings.Add("text", bsArticulo, "pre_costoMin")
        txtPrecio.DataBindings.Add("text", bsArticulo, "pre_venta")
        chkPreIncImp.DataBindings.Add("checked", bsArticulo, "pre_inc_imp")
        chkAfecto.DataBindings.Add("checked", bsArticulo, "afecto_igv")
        txtMaximo.DataBindings.Add("text", bsArticulo, "maximo")
        txtMinimo.DataBindings.Add("text", bsArticulo, "minimo")
        txtTipo.DataBindings.Add("text", bsArticulo, "nom_tart")
        txtsubgrupo.DataBindings.Add("text", bsArticulo, "nom_sgrupo")
        chkLimpio.DataBindings.Add("checked", bsArticulo, "es_limpio")
        ChkGasto.DataBindings.Add("checked", bsArticulo, "es_Gasto")
        chkActivo.DataBindings.Add("checked", bsArticulo, "activo")
        cboUnidad.DataBindings.Add("selectedValue", bsArticulo, "cod_uni")
        cboUnidad.DataSource = dsCatalogo.Tables("unidad")
        cboUnidad.DisplayMember = dsCatalogo.Tables("unidad").Columns("nom_uni").ToString
        cboUnidad.ValueMember = dsCatalogo.Tables("unidad").Columns("cod_uni").ToString
        cboTipo.DataBindings.Add("selectedValue", bsArticulo, "cod_tart")
        cboTipo.DataSource = dsCatalogo.Tables("tipo_articulo")
        cboTipo.DisplayMember = dsCatalogo.Tables("tipo_articulo").Columns("nom_tart").ToString
        cboTipo.ValueMember = dsCatalogo.Tables("tipo_articulo").Columns("cod_tart").ToString
        cbosubgrupo.DataBindings.Add("selectedValue", bsArticulo, "cod_sgrupo")
        cbosubgrupo.DataSource = dsCatalogo.Tables("subgrupo")
        cbosubgrupo.DisplayMember = dsCatalogo.Tables("subgrupo").Columns("nom_sgrupo").ToString
        cbosubgrupo.ValueMember = dsCatalogo.Tables("subgrupo").Columns("cod_sgrupo").ToString
        '
        estaCargando = False
        If pAlmaUser = cAlmaPrincipal Then
            'cuando accede un suario del almacen principal
            TabControlPanel4.Enabled = False
            TabControl2.SelectedTabIndex = 1
            cargaCatalogoRelacionados(cboAlmacen.SelectedValue)
        End If
    End Sub
    Sub cargaCatalogo(ByVal cod_alma As String)
        dsCatalogo = Catalogo.dsCatalogo()
        dtArticulo = dsCatalogo.Tables("articulo")
        Dim cad1, cad2, cad3, cad4, cad5, cad6, cad As String
        cad1 = "Select cod_art,cod_artext as C,nom_art,articulo.cod_uni,nom_uni,pre_costo,pre_venta,pre_costoMax,pre_costoMin,afecto_igv,es_gasto,"
        cad2 = " articulo.cod_tart,nom_tart,articulo.cod_sgrupo,nom_sgrupo,articulo.activo,minimo,maximo,pre_inc_imp,es_limpio"
        cad3 = " from articulo inner join unidad on articulo.cod_uni=unidad.cod_uni"
        cad4 = " inner join tipo_articulo on articulo.cod_tart=tipo_articulo.cod_tart"
        cad5 = " inner join subgrupo on articulo.cod_sgrupo=subgrupo.cod_sgrupo"
        cad6 = " where articulo.cod_alma='" & cod_alma & "' and not(subgrupo.esProduccion) order by nom_art"
        'cad6 = " where articulo.cod_alma='" & cod_alma & "' order by nom_art"
        cad = cad1 + cad2 + cad3 + cad4 + cad5 + cad6
        Dim com As New MySqlCommand(cad, dbConex)
        daArticulo.SelectCommand = com
        daArticulo.Fill(dsCatalogo, "articulo")
        'establecemos las propiedades del BindingSource
        bsArticulo.DataSource = dsCatalogo
        bsArticulo.DataMember = "articulo"
        With dataCatalogo
            'volvemos a relacionar la grilla, ahora con el BindingSource
            'asi todos los controles estaran relacionados con el mismo objeto
            .DataSource = bsArticulo
            '.DataMember = "articulo"
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_art").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("pre_costo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("pre_venta").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("nom_tart").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns("cod_uni").Visible = False
            .Columns("cod_tart").Visible = False
            .Columns("cod_sgrupo").Visible = False
            .Columns("nom_sgrupo").Visible = False
            .Columns("afecto_igv").Visible = False
            .Columns("es_gasto").Visible = False
            .Columns("minimo").Visible = False
            .Columns("maximo").Visible = False
            .Columns.Item("cod_art").Width = 55
            .Columns.Item("cod_art").HeaderText = "Código"
            .Columns.Item("nom_art").Width = 240
            .Columns.Item("nom_art").HeaderText = "Descripción"
            .Columns.Item("nom_uni").Width = 50
            .Columns.Item("nom_uni").HeaderText = "Unidad"
            .Columns.Item("pre_costo").Width = 70
            .Columns.Item("pre_costo").HeaderText = "Costo"
            .Columns.Item("pre_venta").Width = 70
            .Columns.Item("pre_venta").HeaderText = "Venta"
            .Columns.Item("nom_tart").Width = 92
            .Columns.Item("nom_tart").HeaderText = "Tipo"
            .Columns.Item("activo").Width = 30
            .Columns.Item("activo").HeaderText = "Act."
            .Columns.Item("pre_costoMax").Visible = False
            .Columns.Item("pre_costoMin").Visible = False
            .Columns.Item("pre_inc_imp").Visible = False
            .Columns.Item("es_limpio").Visible = False
            .ReadOnly = True
        End With
        tabGeneral_almacen.Text = "Relacionar Productos de Almacén General Vs. " & cboAlmacen.Text
        tabCatalogo.Text = "Catálogo de : " & cboAlmacen.Text
        Me.Text = "Mantenimiento: CATALOGO DE PRODUCTOS - ALMACEN " & UCase(cboAlmacen.Text)
        'mostramos el numero de registros procesados
        lblRegistros.Text = "Nº de Registros Procesados... " & dataCatalogo.RowCount
    End Sub
    Private Sub cboAlmacen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAlmacen.SelectedIndexChanged
        If Not estaCargando Then
            If tabCatalogo.IsSelected Then
                cargaCatalogo(cboAlmacen.SelectedValue)
            Else
                cargaCatalogoRelacionados(cboAlmacen.SelectedValue)
            End If
        End If
    End Sub
    Private Sub tabCatalogo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tabCatalogo.Click
        cargaCatalogo(cboAlmacen.SelectedValue)
    End Sub
    Sub cargasubgrupos()
        dtSGrupo = dsCatalogo.Tables("subgrupo")
        Dim daSGrupo As New MySqlDataAdapter
        Dim comSGrupo As New MySqlCommand("select * from subgrupo where activo=1 and not(esProduccion) order by nom_sgrupo", dbConex)
        daSGrupo.SelectCommand = comSGrupo
        daSGrupo.Fill(dsCatalogo, "subgrupo")
    End Sub
    Private Sub cmdAñadir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAñadir.Click
        lcBoton = "Añadir"
        lCodigo = ""
        dsCatalogo.Tables("articulo").Columns("activo").DefaultValue = True
        dsCatalogo.Tables("articulo").Columns("pre_inc_imp").DefaultValue = True
        dsCatalogo.Tables("articulo").Columns("es_gasto").DefaultValue = False
        dsCatalogo.Tables("articulo").Columns("es_limpio").DefaultValue = False
        dsCatalogo.Tables("articulo").Columns("afecto_igv").DefaultValue = True
        dsCatalogo.Tables("articulo").Columns("pre_costo").DefaultValue = 0.0
        dsCatalogo.Tables("articulo").Columns("pre_costoMax").DefaultValue = 0.0
        dsCatalogo.Tables("articulo").Columns("pre_costoMin").DefaultValue = 0.0
        dsCatalogo.Tables("articulo").Columns("pre_venta").DefaultValue = 0.0
        dsCatalogo.Tables("articulo").Columns("minimo").DefaultValue = 0
        dsCatalogo.Tables("articulo").Columns("maximo").DefaultValue = 0
        bsArticulo.AddNew()
        dataCatalogo.DataSource = bsArticulo
        modoGrabar()
        habilitaDetalle()
        deshabilitaCabecera()
        txtCodigo.Focus()
    End Sub
    Private Sub cmdGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGrabar.Click
        Try
            If validaIngreso() Then
                Dim sql As String, result As Integer
                txtUnidad.Text = cboUnidad.Text
                txtTipo.Text = cboTipo.Text
                txtsubgrupo.Text = cbosubgrupo.Text
                If lcBoton = "Añadir" Then
                    sql = "Insert Into articulo(cod_art,cod_artext,nom_art,cod_uni,pre_costo,pre_costoMax,pre_costoMin,pre_venta,pre_inc_imp,afecto_igv,minimo,maximo,cod_tart,cod_sgrupo,cod_alma,es_gasto,es_limpio,activo)" & _
                    "values('" & _
                    txtCodigo.Text & "','" & TxtCodigoVta.Text & "','" & txtDescripcion.Text & "','" & cboUnidad.SelectedValue & "'," & _
                    txtCosto.Text & "," & txtCostoMax.Text & "," & txtCostoMin.Text & "," & txtPrecio.Text & "," & chkPreIncImp.CheckState & "," & chkAfecto.CheckState & "," & txtMinimo.Text & "," & txtMaximo.Text & _
                    ",'" & cboTipo.SelectedValue & "','" & cbosubgrupo.SelectedValue + "','" & cboAlmacen.SelectedValue & "'," & ChkGasto.CheckState & "," & chkLimpio.CheckState & "," & chkActivo.CheckState & ")"
                Else
                    sql = "update articulo set cod_art='" & txtCodigo.Text & "',cod_artext='" & TxtCodigoVta.Text & "',nom_art='" & txtDescripcion.Text & "'," & _
                    "cod_uni='" & cboUnidad.SelectedValue & "'," & _
                    "pre_costo=" & txtCosto.Text & ",pre_costoMax=" & txtCostoMax.Text & ",pre_costoMin=" & txtCostoMin.Text & ",pre_venta=" & txtPrecio.Text & "," & _
                    "pre_inc_imp=" & chkPreIncImp.CheckState & ",afecto_igv=" & chkAfecto.CheckState & ",minimo=" & txtMinimo.Text & "," & _
                    "maximo=" & txtMaximo.Text & "," & _
                    "cod_tart='" & cboTipo.SelectedValue & "',cod_sgrupo='" & cbosubgrupo.SelectedValue & "'," & _
                    "es_gasto=" & ChkGasto.CheckState & ",es_limpio=" & chkLimpio.CheckState & ",activo=" & chkActivo.CheckState & _
                    " where cod_art='" & lCodigo & "'"
                End If
                Dim com As New MySqlCommand(sql, dbConex)
                result = com.ExecuteNonQuery()
                If result > 0 Then
                    bsArticulo.EndEdit()
                Else
                    bsArticulo.CancelEdit()
                End If
                dataCatalogo.Refresh()
                deshabilitaDetalle()
                modoAñadir()
                habilitaCabecera()
                txtBuscar.Focus()
            End If
            'mostramos el numero de registros procesados
            lblRegistros.Text = "Nº de Registros Procesados... " & dataCatalogo.RowCount
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            bsArticulo.CancelEdit()
            modoAñadir()
            habilitaCabecera()
            deshabilitaDetalle()
            dataCatalogo.Focus()
            dataCatalogo.Refresh()
        End Try
    End Sub
    Function validaIngreso()
        Dim validado As Boolean = False
        If Len(txtDescripcion.Text) > 0 Then
            If Len(txtCodigo.Text) > 0 Then
                If cboUnidad.SelectedIndex >= 0 Then
                    If cboTipo.SelectedIndex >= 0 Then
                        If cbosubgrupo.SelectedIndex >= 0 Then
                            validado = True
                        Else
                            cbosubgrupo.Focus()
                        End If
                    Else
                        cboTipo.Focus()
                    End If
                Else
                    cboUnidad.Focus()
                End If
            Else
                txtCodigo.Focus()
            End If
        Else
            txtDescripcion.Focus()
        End If
        Return validado
    End Function
    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        lcBoton = ""
        bsArticulo.CancelEdit()
        dataCatalogo.Refresh()
        deshabilitaDetalle()
        habilitaCabecera()
        modoAñadir()
        If dataCatalogo.Rows.Count > 0 Then
            dataCatalogo.CurrentCell = dataCatalogo(1, 0)
        End If
        dataCatalogo.Focus()
    End Sub
    Private Sub cmdEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEliminar.Click
        If bsArticulo.Count > 0 Then
            Dim sql As String, result, resp As Integer, mCatalogo As New Catalogo, existe, existe2 As Boolean
            existe = mCatalogo.existeEnIngresos(txtCodigo.Text)
            If existe Then
                MessageBox.Show("El Producto Tiene Movimientos" + Chr(13) + "NO es posible eliminarlo...", "CEFE", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Else
                existe2 = mCatalogo.existeEnIngresosHistorial(txtCodigo.Text)
                If existe2 Then
                    MessageBox.Show("El Producto Tiene Movimientos en el Historial" + Chr(13) + "NO es posible eliminarlo...", "CEFE", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Else
                    resp = MessageBox.Show("¿Esta Seguro de Eliminar el Artículo...", "CEFE", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                    'verificar los articulos en las ablas art_area y art_relaalmacenes y recetas
                    If resp = 6 Then
                        Try
                            sql = "delete from articulo where cod_art='" & txtCodigo.Text & "'"
                            Dim com As New MySqlCommand(sql, dbConex)
                            result = com.ExecuteNonQuery()
                            If result > 0 Then
                                bsArticulo.RemoveCurrent()
                                dataCatalogo.Focus()
                            End If
                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                        End Try
                    End If
                End If
            End If
            'mostramos el numero de registros procesados
            lblRegistros.Text = "Nº de Registros Procesados... " & dataCatalogo.RowCount
        End If
    End Sub
    Private Sub cmdEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEditar.Click
        If bsArticulo.Count > 0 Then
            lcBoton = "Editar"
            lCodigo = txtCodigo.Text
            habilitaDetalle()
            deshabilitaCabecera()
            modoGrabar()
            txtCodigo.Focus()
        End If
    End Sub
    Sub habilitaDetalle()
        lblCodigo.ForeColor = Color.Maroon
        lblDescripcion.ForeColor = Color.Maroon
        lblUnidad.ForeColor = Color.Maroon
        lblTipo.ForeColor = Color.Maroon
        lblGrupo.ForeColor = Color.Maroon
        chkPreIncImp.TextColor = Color.Maroon
        chkAfecto.TextColor = Color.Maroon
        txtCodigo.BackColor = Color.White
        txtCodigo.ReadOnly = False
        TxtCodigoVta.BackColor = Color.White
        TxtCodigoVta.ReadOnly = False
        txtDescripcion.BackColor = Color.White
        txtDescripcion.ReadOnly = False
        txtUnidad.BackColor = Color.White
        txtUnidad.Visible = False
        cboUnidad.Visible = True
        txtCosto.BackColor = Color.White
        txtCosto.ReadOnly = False
        txtCostoMax.BackColor = Color.White
        txtCostoMax.ReadOnly = False
        txtCostoMin.BackColor = Color.White
        txtCostoMin.ReadOnly = False
        txtPrecio.BackColor = Color.White
        txtPrecio.ReadOnly = False
        txtMaximo.BackColor = Color.White
        txtMaximo.ReadOnly = False
        txtMinimo.BackColor = Color.White
        txtMinimo.ReadOnly = False
        txtTipo.BackColor = Color.White
        txtTipo.Visible = False
        cboTipo.Visible = True
        txtsubgrupo.BackColor = Color.White
        txtsubgrupo.Visible = False
        cbosubgrupo.Visible = True
        chkPreIncImp.Enabled = True
        chkAfecto.Enabled = True
        ChkGasto.Enabled = True
        chkLimpio.Enabled = True
        chkActivo.Enabled = True
    End Sub
    Sub deshabilitaDetalle()
        lblCodigo.ForeColor = Color.Black
        lblDescripcion.ForeColor = Color.Black
        lblUnidad.ForeColor = Color.Black
        lblTipo.ForeColor = Color.Black
        lblGrupo.ForeColor = Color.Black
        chkPreIncImp.TextColor = Color.Black
        chkAfecto.TextColor = Color.Black
        txtCodigo.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        txtCodigo.ReadOnly = True
        txtDescripcion.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        txtDescripcion.ReadOnly = True
        txtUnidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        txtUnidad.Visible = True
        cboUnidad.Visible = False
        txtCosto.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        txtCosto.ReadOnly = True
        txtCostoMax.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        txtCostoMax.ReadOnly = True
        txtCostoMin.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        txtCostoMin.ReadOnly = True
        txtPrecio.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        txtPrecio.ReadOnly = True
        txtMaximo.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        txtMaximo.ReadOnly = True
        txtMinimo.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        txtMinimo.ReadOnly = True
        txtTipo.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        txtTipo.Visible = True
        cboTipo.Visible = False
        txtsubgrupo.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        txtsubgrupo.Visible = True
        cbosubgrupo.Visible = False
        chkPreIncImp.Enabled = False
        chkAfecto.Enabled = False
        ChkGasto.Enabled = False
        chkLimpio.Enabled = False
        chkActivo.Enabled = False
    End Sub
    Sub habilitaCabecera()
        dataCatalogo.Enabled = True
        txtBuscar.Enabled = True
    End Sub
    Sub deshabilitaCabecera()
        txtBuscar.Enabled = False
        dataCatalogo.Enabled = False
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
    Private Sub txtCodigo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.GotFocus
        If lcBoton = "Editar" Then
            lCodigo = txtCodigo.Text
        End If
        general.ingresaTexto(txtCodigo)
    End Sub
    Private Sub txtCodigo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.LostFocus
        If Len(txtCodigo.Text) > 0 Then
            txtCodigo.Text = Microsoft.VisualBasic.Right("000000" + Trim(txtCodigo.Text), 6)
        End If
        general.saleTexto(txtCodigo)
    End Sub
    Private Sub txtCodigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigo.TextChanged
        txtCodigo.Text = general.mayusculas(txtCodigo, txtCodigo.Text)
    End Sub
    Private Sub txtCodigo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCodigo.Validating
        If txtCodigo.ReadOnly = False Then
            Dim mCatalogo As New Catalogo
            Dim existe As Boolean
            If txtCodigo.Text <> lCodigo Then
                existe = mCatalogo.existeCodigo(txtCodigo.Text)
                If existe Then
                    MessageBox.Show("Código " & txtCodigo.Text & " ya Existe...", "CEFE", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    If lcBoton = "Editar" Then
                        txtCodigo.Text = lCodigo
                    End If
                    e.Cancel = True
                Else
                    If txtCodigo.Text = "000000" Then
                        MessageBox.Show("Código Reservado para el Sistema...", "CEFE", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        e.Cancel = True
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub txtDescripcion_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDescripcion.GotFocus
        general.ingresaTexto(txtDescripcion)
    End Sub
    Private Sub txtDescripcion_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDescripcion.LostFocus
        general.saleTexto(txtDescripcion)
    End Sub
    Private Sub txtCosto_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCosto.GotFocus
        general.ingresaTexto(txtCosto)
    End Sub
    Private Sub txtCosto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCosto.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not (e.KeyChar = ChrW(Keys.Back)) And Not (e.KeyChar.Equals(sepDecimal)) Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub txtCosto_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCosto.LostFocus
        general.saleTexto(txtCosto)
    End Sub
    Private Sub txtCostoMax_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCostoMax.GotFocus
        general.ingresaTexto(txtCostoMax)
    End Sub
    Private Sub txtCostoMax_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCostoMax.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not (e.KeyChar = ChrW(Keys.Back)) And Not (e.KeyChar.Equals(sepDecimal)) Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub txtCostoMax_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCostoMax.LostFocus
        general.saleTexto(txtCostoMax)
    End Sub
    Private Sub txtPrecio_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPrecio.GotFocus
        general.ingresaTexto(txtPrecio)
    End Sub
    Private Sub txtPrecio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrecio.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not (e.KeyChar = ChrW(Keys.Back)) And Not (e.KeyChar.Equals(sepDecimal)) Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub txtPrecio_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPrecio.LostFocus
        general.saleTexto(txtPrecio)
    End Sub
    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        Dim frm As New rptForm
        If optGeneral.Checked = True Then
            frm.cargarCatalogo(cboAlmacen.SelectedValue, False, False, False, "Almacén: " & cboAlmacen.Text)
            frm.MdiParent = principal
            frm.Show()
        Else
            If optInventarioDiario.Checked = True Then
                frm.cargarCatalogo(cboAlmacen.SelectedValue, False, False, True, "Almacén: " & cboAlmacen.Text & " - Para Inv. Diario")
                frm.MdiParent = principal
                frm.Show()
            Else
                If cboImp_x_tipo.SelectedIndex >= 0 Then
                    Dim cod As String = cboImp_x_tipo.SelectedValue
                    Dim nom As String = cboImp_x_tipo.Text
                    If optsubgrupo.Checked = True Then
                        frm.cargarCatalogo_x_Tipo(cboAlmacen.SelectedValue, True, "subgrupo", cod, "Grupo: " + nom)
                    Else
                        frm.cargarCatalogo_x_Tipo(cboAlmacen.SelectedValue, True, "tipoArticulo", cod, "Tipo: " + nom)
                    End If
                    frm.MdiParent = principal
                    frm.Show()
                Else
                End If
            End If
        End If
    End Sub
    Private Sub dataCatalogo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dataCatalogo.GotFocus
        Dim codigo As String
        If dataCatalogo.RowCount > 0 Then
            If IsDBNull(dataCatalogo.Item("cod_art", dataCatalogo.CurrentRow.Index).Value) Then
                codigo = ""
            Else
                codigo = dataCatalogo.Item("cod_art", dataCatalogo.CurrentRow.Index).Value
            End If
        End If
    End Sub
    Private Sub dataCatalogo_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dataCatalogo.SelectionChanged
        If dataCatalogo.RowCount > 0 Then
            lblProductoEntero.Text = IIf(IsDBNull(dataCatalogo("nom_art", dataCatalogo.CurrentCell.RowIndex).Value), "", _
                    dataCatalogo("nom_art", dataCatalogo.CurrentCell.RowIndex).Value & " - " _
                    & dataCatalogo("nom_uni", dataCatalogo.CurrentCell.RowIndex).Value)
        Else
            lblProductoEntero.Text = ""
        End If
    End Sub
    Private Sub txtMinimo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMinimo.GotFocus
        ingresaTexto(txtMinimo)
    End Sub
    Private Sub txtMinimo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMinimo.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not (e.KeyChar = ChrW(Keys.Back)) And Not (e.KeyChar.Equals(sepDecimal)) Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub txtMinimo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMinimo.LostFocus
        saleTexto(txtMinimo)
    End Sub
    Private Sub txtMaximo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMaximo.GotFocus
        ingresaTexto(txtMaximo)
    End Sub
    Private Sub txtMaximo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMaximo.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not (e.KeyChar = ChrW(Keys.Back)) And Not (e.KeyChar.Equals(sepDecimal)) Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub txtMaximo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMaximo.LostFocus
        saleTexto(txtMaximo)
    End Sub
    Private Sub optGeneral_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optGeneral.CheckedChanged
        If optGeneral.Checked = True Then
            mdsTipoArticulo.Clear()
            mdssubgrupo.Clear()
        End If
    End Sub
    Private Sub optsubgrupo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optsubgrupo.CheckedChanged
        If optsubgrupo.Checked = True Then
            mdssubgrupo.Clear()
            Dim dasubgrupo As New MySqlDataAdapter
            Dim comsubgrupo As New MySqlCommand("select cod_sgrupo,nom_sgrupo from subgrupo where activo=1 and not (esProduccion) order by nom_sgrupo", dbConex)
            dasubgrupo.SelectCommand = comsubgrupo
            dasubgrupo.Fill(mdssubgrupo, "subgrupo")
            With cboImp_x_Tipo
                .DataSource = mdssubgrupo.Tables("subgrupo")
                .DisplayMember = mdssubgrupo.Tables("subgrupo").Columns("nom_sgrupo").ToString
                .ValueMember = mdssubgrupo.Tables("subgrupo").Columns("cod_sgrupo").ToString
                If mdssubgrupo.Tables("subgrupo").Rows.Count > 0 Then
                    .SelectedIndex = 0
                Else
                    .SelectedIndex = -1
                End If
            End With
            cboImp_x_Tipo.Focus()
        Else
            mdssubgrupo.Clear()
        End If
    End Sub
    Private Sub optTipoArticulo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optTipoArticulo.CheckedChanged
        If optTipoArticulo.Checked = True Then
            mdsTipoArticulo.Clear()
            Dim daTipoArticulo As New MySqlDataAdapter
            Dim comTipoArticulo As New MySqlCommand("select cod_tart,nom_tart from tipo_articulo where activo=1 and ((esProduccion) or (esCombo)) order by nom_tart", dbConex)
            daTipoArticulo.SelectCommand = comTipoArticulo
            daTipoArticulo.Fill(mdsTipoArticulo, "tipoArticulo")
            With cboImp_x_tipo
                .DataSource = mdsTipoArticulo.Tables("tipoArticulo")
                .DisplayMember = mdsTipoArticulo.Tables("tipoArticulo").Columns("nom_tart").ToString
                .ValueMember = mdsTipoArticulo.Tables("tipoArticulo").Columns("cod_tart").ToString
                If mdsTipoArticulo.Tables("tipoArticulo").Rows.Count > 0 Then
                    .SelectedIndex = 0
                Else
                    .SelectedIndex = -1
                End If
            End With
            cboImp_x_Tipo.Focus()
        Else
            mdssubgrupo.Clear()
        End If
    End Sub
    Private Sub txtBuscar_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscar.GotFocus
        txtBuscar.SelectAll()
    End Sub
    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged
        If Not estaCargando Then
            If optDescripcion.Checked = True Then
                bsArticulo.Filter = "nom_art like '" & txtBuscar.Text & "%'"
            Else
                bsArticulo.Filter = "cod_art like '" & txtBuscar.Text & "%'"
            End If
        End If
    End Sub
    Private Sub cboUnidad_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboUnidad.GotFocus
        dtUnidad = dsCatalogo.Tables("unidad")
        Dim daUnidad As New MySqlDataAdapter
        Dim comUnidad As New MySqlCommand("select * from unidad where activo=1 and (esProduccion) order by nom_uni", dbConex)
        daUnidad.SelectCommand = comUnidad
        daUnidad.Fill(dsCatalogo, "unidad")
    End Sub
    Private Sub cboTipo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboTipo.GotFocus
        dtTipo = dsCatalogo.Tables("tipo_articulo")
        Dim daTipo As New MySqlDataAdapter
        Dim comTipo As New MySqlCommand("select * from tipo_articulo where activo=1 and ((esProduccion) or (esCombo)) order by nom_tart", dbConex)
        daTipo.SelectCommand = comTipo
        daTipo.Fill(dsCatalogo, "tipo_articulo")
    End Sub
    Private Sub cbosubgrupo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbosubgrupo.GotFocus
        dtSGrupo = dsCatalogo.Tables("subgrupo")
        Dim daSGrupo As New MySqlDataAdapter
        Dim comSGrupo As New MySqlCommand("select * from subgrupo where activo=1 and not(esProduccion) order by nom_sgrupo", dbConex)
        daSGrupo.SelectCommand = comSGrupo
        daSGrupo.Fill(dsCatalogo, "subgrupo")
    End Sub
    Private Sub tabLimpios_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tabLimpios.Click
        muestraLimpios()
        dataLimpios.Focus()
    End Sub
    Sub muestraLimpios()
        Dim mCatalogo As New Catalogo
        dsLimpios = mCatalogo.recuperaLimpios(cboAlmacen.SelectedValue)
        dataLimpios.DataSource = dsLimpios.Tables("articulo").DefaultView
        estructuraLimpios()
    End Sub
    Sub estructuraLimpios()
        With dataLimpios
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_art").HeaderText = "Código"
            .Columns("cod_art").Width = 55
            .Columns("cod_art").ReadOnly = True
            .Columns("cod_art").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_art").DefaultCellStyle.BackColor = Color.AliceBlue
            .Columns("cod_art").DefaultCellStyle.ForeColor = Color.MidnightBlue
            .Columns("nom_art").HeaderText = "Descripción"
            .Columns("nom_art").Width = 280
            .Columns("nom_art").ReadOnly = True
            .Columns("nom_art").DefaultCellStyle.BackColor = Color.AliceBlue
            .Columns("nom_art").DefaultCellStyle.ForeColor = Color.MidnightBlue
            .Columns("nom_uni").HeaderText = "Unidad"
            .Columns("nom_uni").Width = 60
            .Columns("nom_uni").ReadOnly = True
            .Columns("nom_uni").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("nom_uni").DefaultCellStyle.BackColor = Color.AliceBlue
            .Columns("nom_uni").DefaultCellStyle.ForeColor = Color.MidnightBlue
            .Columns("cant").HeaderText = "Cant."
            .Columns("cant").Width = 50
            .Columns("cant").ReadOnly = False
            .Columns("cant").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("cant").DefaultCellStyle.BackColor = Color.AliceBlue
            .Columns("cant").DefaultCellStyle.ForeColor = Color.MidnightBlue
            .Columns("cod_artL").HeaderText = "Código"
            .Columns("cod_artL").Width = 55
            .Columns("cod_artL").ReadOnly = True
            .Columns("cod_artL").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("nom_artL").HeaderText = "Descripción"
            .Columns("nom_artL").Width = 280
            .Columns("nom_artL").ReadOnly = True
            .Columns("nom_uniL").HeaderText = "Unidad"
            .Columns("nom_uniL").Width = 60
            .Columns("nom_uniL").ReadOnly = True
            .Columns("nom_uniL").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cantL").HeaderText = "Rend."
            .Columns("cantL").Width = 50
            .Columns("cantL").ReadOnly = False
            .Columns("cantL").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        End With
    End Sub
    Private Sub dataLimpios_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataLimpios.CellEndEdit
        If dataLimpios.CurrentCell.ColumnIndex = dataLimpios.Columns("cant").Index Then
            Dim mCatalogo As New Catalogo
            Dim cod_art As String = dataLimpios("cod_art", dataLimpios.CurrentRow.Index).Value
            Dim cant As Decimal = dataLimpios("cant", dataLimpios.CurrentRow.Index).Value
            Dim cod_artL As String = dataLimpios("cod_artL", dataLimpios.CurrentRow.Index).Value
            Dim cantL As Decimal = dataLimpios("cantL", dataLimpios.CurrentRow.Index).Value
            'validamos el ingreso de cantidades no nulas
            If IsDBNull(dataLimpios("cant", dataLimpios.CurrentRow.Index).Value) Then
                cant = 0
                dataLimpios("cant", dataLimpios.CurrentRow.Index).Value = 0
            Else
                cant = dataLimpios("cant", dataLimpios.CurrentRow.Index).Value
            End If
            mCatalogo.actualizaCantLimpios(cod_artL, cantL, cod_art, cant)
        Else
            If dataLimpios.CurrentCell.ColumnIndex = dataLimpios.Columns("cantL").Index Then
                Dim mCatalogo As New Catalogo
                Dim cod_art As String = IIf(IsDBNull(dataLimpios("cod_art", dataLimpios.CurrentRow.Index).Value), "", dataLimpios("cod_art", dataLimpios.CurrentRow.Index).Value)
                Dim cant As Decimal = IIf(IsDBNull(dataLimpios("cant", dataLimpios.CurrentRow.Index).Value), 0, dataLimpios("cant", dataLimpios.CurrentRow.Index).Value)
                Dim cod_artL As String = dataLimpios("cod_artL", dataLimpios.CurrentRow.Index).Value
                Dim cantL As Decimal = dataLimpios("cantL", dataLimpios.CurrentRow.Index).Value
                'validamos el ingreso de cantidades no nulas
                If IsDBNull(dataLimpios("cantL", dataLimpios.CurrentRow.Index).Value) Then
                    cantL = 0
                    dataLimpios("cantL", dataLimpios.CurrentRow.Index).Value = 0
                Else
                    cantL = dataLimpios("cantL", dataLimpios.CurrentRow.Index).Value
                End If
                mCatalogo.actualizaCantLimpios(cod_artL, cantL, cod_art, cant)
            End If
        End If
    End Sub
    Private Sub dataLimpios_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dataLimpios.KeyDown
        If e.KeyCode = Keys.Delete Then
            e.SuppressKeyPress = True
            eliminaITEMLimpio()
        End If
        If (e.Control And e.KeyCode = Keys.E) Then
            If dataLimpios.RowCount > 0 Then
                EnviaraExcel(dataLimpios)
            End If
        End If

    End Sub
    Sub eliminaITEMLimpio()
        Dim mCatalogo As New Catalogo
        If Not IsDBNull(dataLimpios("cod_art", dataLimpios.CurrentRow.Index).Value) Then
            Dim cCodigo As String = dataLimpios("cod_art", dataLimpios.CurrentRow.Index).Value
            Dim cCodigoL As String = dataLimpios("cod_artL", dataLimpios.CurrentRow.Index).Value
            Dim rpta As Integer
            rpta = MessageBox.Show("Esta Seguro de Quitar la Relacion Seleccionada", "CEFE", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2)
            If rpta = 6 Then
                mCatalogo.eliminaRelacionLimpios(cCodigoL, cCodigo)
                dataLimpios.Rows.Remove(dataLimpios.CurrentRow)
                muestraLimpios()
            End If
        End If
    End Sub
    Private Sub dataLimpios_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dataLimpios.SelectionChanged
        lblLimpio.Text = ""
        lblLimpio.Text = dataLimpios("nom_artL", dataLimpios.CurrentCell.RowIndex).Value & "-" _
                        & dataLimpios("nom_uniL", dataLimpios.CurrentCell.RowIndex).Value
    End Sub
    Private Sub cmdRelacionarPLR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRelacionarPLR.Click
        If Len(lblProductoEntero.Text) > 0 Then
            Dim cod_artL As String = dataLimpios("cod_artL", dataLimpios.CurrentCell.RowIndex).Value
            Dim cantL As Decimal = dataLimpios("cantL", dataLimpios.CurrentRow.Index).Value
            Dim cCodigo As String = txtCodigo.Text
            Dim nCantidad As Decimal = 1
            Dim mCatalogo As New Catalogo
            Dim existe As Boolean = mCatalogo.existeEnLimpios(cCodigo)
            If existe Then
                MessageBox.Show("El Producto ya esta Relacionado...", "CEFE", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Else
                mCatalogo.insertaLimpios(cod_artL, cantL, cCodigo, nCantidad)
                muestraLimpios()
                dataLimpios.Focus()
                txtBuscar.Text = ""
                txtBuscar.Focus()
            End If
        Else
            MessageBox.Show("Seleccione el Producto a Relacionar...", "CEFE", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If
    End Sub
    Private Sub tabGeneral_almacen_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tabGeneral_almacen.Click
        cargaCatalogoRelacionados(cboAlmacen.SelectedValue)
        txtBuscarCatalogo.Focus()
    End Sub
    Sub cargaCatalogoRelacionados(ByVal cod_alma As String)
        catalogoGeneral(cAlmaPrincipal)
        catalogoAlmacen(cod_alma)
        lblCatalogoAlmacen.Text = "CATALOGO " & Microsoft.VisualBasic.UCase(cboAlmacen.Text)
        tabGeneral_almacen.Text = "Relacionar Productos de Almacén General Vs. " & cboAlmacen.Text
        tabCatalogo.Text = "Catálogo de: " & cboAlmacen.Text
        Me.Text = "Mantenimiento: CATALOGO DE PRODUCTOS - ALMACEN " & UCase(cboAlmacen.Text)
        'mostramos el numero de registros procesados
        lblRegistros.Text = "Nº de Registros Procesados... " & datosCatalogoAlmacen.RowCount
    End Sub
    Sub catalogoGeneral(ByVal cod_alma As String)
        Dim mCatalogo As New Catalogo
        dsCatalogoGeneral = mCatalogo.recuperaCatalogo(pCatalogoXalmacen, cAlmaPrincipal, True, False, False, False, "", False, False, False)
        With datosCatalogoGeneral
            .DataSource = dsCatalogoGeneral.Tables("articulo").DefaultView
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_art").HeaderText = "Código"
            .Columns("cod_art").Width = 55
            .Columns("cod_art").ReadOnly = True
            .Columns("cod_art").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("nom_art").HeaderText = "Descripción"
            .Columns("nom_art").Width = 300
            .Columns("nom_art").ReadOnly = True
            .Columns("nom_uni").HeaderText = "Unidad"
            .Columns("nom_uni").Width = 60
            .Columns("nom_uni").ReadOnly = True
            .Columns("nom_uni").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("pre_costo").Visible = False
            .Columns("pre_costoMin").Visible = False
            .Columns("pre_costoMax").Visible = False
            .Columns("pre_venta").Visible = False
            .Columns("pre_prom").Visible = False
            .Columns("pre_inc_imp").Visible = False
            .Columns("cant_uni").Visible = False
            .Columns("nom_tart").Visible = False
            .Columns("imp").Visible = False
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
    Sub catalogoAlmacen(ByVal cod_alma As String)
        Dim mCatalogo As New Catalogo
        Dim esProduccion As Boolean = IIf(chkProduccion.Checked = True, False, True)

        dsCatalogoAlmacen = mCatalogo.recuperaCatalogo(pCatalogoXalmacen, cod_alma, True, False, False, False, "", False, esProduccion, False)
        With datosCatalogoAlmacen
            .DataSource = dsCatalogoAlmacen.Tables("articulo").DefaultView
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_art").HeaderText = "Código"
            .Columns("cod_art").Width = 55
            .Columns("cod_art").ReadOnly = True
            .Columns("cod_art").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("nom_art").HeaderText = "Descripción"
            .Columns("nom_art").Width = 300
            .Columns("nom_art").ReadOnly = True
            .Columns("nom_uni").HeaderText = "Unidad"
            .Columns("nom_uni").Width = 60
            .Columns("nom_uni").ReadOnly = True
            .Columns("nom_uni").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("pre_costo").Visible = False
            .Columns("pre_costoMin").Visible = False
            .Columns("pre_costoMax").Visible = False
            .Columns("pre_venta").Visible = False
            .Columns("pre_prom").Visible = False
            .Columns("pre_inc_imp").Visible = False
            .Columns("cant_uni").Visible = False
            .Columns("nom_tart").Visible = False
            .Columns("imp").Visible = False
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
    Private Sub txtBuscarGeneral_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscarGeneral.TextChanged
        Dim valor As String = txtBuscarGeneral.Text
        If optDescripcionGeneral.Checked = True Then
            dsCatalogoGeneral.Tables("articulo").DefaultView.RowFilter = "nom_art LIKE '" & valor & "%'"
        Else
            dsCatalogoGeneral.Tables("articulo").DefaultView.RowFilter = "cod_art LIKE '" & valor & "%'"
        End If
        If datosCatalogoGeneral.RowCount > 0 Then
            datosCatalogoGeneral.CurrentCell = datosCatalogoGeneral("cod_art", datosCatalogoGeneral.CurrentRow.Index)
        End If
    End Sub
    Private Sub txtBuscarCatalogo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscarCatalogo.TextChanged
        Dim valor As String = txtBuscarCatalogo.Text
        If optDescripcionCatalogo.Checked = True Then
            dsCatalogoAlmacen.Tables("articulo").DefaultView.RowFilter = "nom_art LIKE '" & valor & "%'"
        Else
            dsCatalogoAlmacen.Tables("articulo").DefaultView.RowFilter = "cod_art LIKE '" & valor & "%'"
        End If
        If datosCatalogoAlmacen.RowCount > 0 Then
            datosCatalogoAlmacen.CurrentCell = datosCatalogoAlmacen("cod_art", datosCatalogoAlmacen.CurrentRow.Index)
        End If
    End Sub
    Private Sub optCodigoGeneral_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles optCodigoGeneral.Click
        txtBuscarGeneral.Focus()
    End Sub
    Private Sub optDescripcionGeneral_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles optDescripcionGeneral.Click
        txtBuscarGeneral.Focus()
    End Sub
    Private Sub cmdRelacionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRelacionar.Click
        Dim mAlmacen As New Almacen
        Dim cod_alma As String = cboAlmacen.SelectedValue
        Dim cod_artAlma As String = datosCatalogoAlmacen("cod_art", datosCatalogoAlmacen.CurrentRow.Index).Value
        Dim cod_art As String = datosCatalogoGeneral("cod_art", datosCatalogoGeneral.CurrentRow.Index).Value
        Dim existe As Boolean = mAlmacen.existeArticulo_deAlmaGeneral(cod_alma, cod_art)
        If Not existe Then
            mAlmacen.relacionaArticulos(cod_alma, cod_artAlma, cod_art)
            muestraArticulosRelacionados(cod_alma, cod_artAlma, 1)
        Else
            MessageBox.Show("Este Artículo ya se Encuentra Relacionado...", "CEFE", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub datosCatalogoAlmacen_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles datosCatalogoAlmacen.SelectionChanged
        If Not estaCargando Then
            If datosCatalogoAlmacen.RowCount > 0 Then
                muestraArticulosRelacionados(cboAlmacen.SelectedValue, datosCatalogoAlmacen("cod_art", datosCatalogoAlmacen.CurrentRow.Index).Value, 1)
            End If
        End If
    End Sub
    Sub muestraArticulosRelacionados(ByVal cod_alma As String, ByVal cod_artAlma As String, ByVal valor As Integer)
        Dim mAlmacen As New Almacen
        dsArticulosRelacionados.Clear()
        dsArticulosRelacionados = mAlmacen.muestraArticulosRelacionados(cod_alma, cod_artAlma, valor)
        dataArtRelacionados.DataSource = dsArticulosRelacionados.Tables("articulo").DefaultView
        lblRelacion.Text = datosCatalogoAlmacen("nom_art", datosCatalogoAlmacen.CurrentRow.Index).Value
        cargaEstructuraArtRelacionados()
    End Sub
    Sub cargaEstructuraArtRelacionados()
        With dataArtRelacionados
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_art").HeaderText = "Codigo"
            .Columns("cod_art").Width = 60
            .Columns("cod_art").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("nom_art").HeaderText = "Descripcion"
            .Columns("nom_art").Width = 260
            .Columns("nom_uni").HeaderText = "Unidad"
            .Columns("nom_uni").Width = 70
            .Columns("activo").HeaderText = "Act"
            .Columns("activo").Width = 40
            .Columns("cod_alma").Visible = False
            .Columns("cod_artAlma").Visible = False
        End With
    End Sub
    Private Sub dataArtRelacionados_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataArtRelacionados.CellDoubleClick
        eliminaITEM()
    End Sub
    Private Sub dataArtRelacionados_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles dataArtRelacionados.PreviewKeyDown
        If e.KeyCode = Keys.Delete Then
            eliminaITEM()
        End If
    End Sub
    Sub eliminaITEM()
        Dim mAlmacen As New Almacen
        Dim cAlma As String = dataArtRelacionados("cod_alma", dataArtRelacionados.CurrentRow.Index).Value
        Dim cCodigo As String = dataArtRelacionados("cod_art", dataArtRelacionados.CurrentRow.Index).Value
        Dim cCodigoAlma As String = dataArtRelacionados("cod_artAlma", dataArtRelacionados.CurrentRow.Index).Value
        Dim rpta As Integer
        rpta = MessageBox.Show("Esta Seguro de Eliminar el ITEM Seleccionado" + Chr(13) + "Este Proceso es Irreversible...", "CEFE", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2)
        If rpta = 6 Then
            mAlmacen.eliminaRelacionArticulos(cAlma, cCodigoAlma, cCodigo)
            dataArtRelacionados.Rows.Remove(dataArtRelacionados.CurrentRow)
        End If
    End Sub
    Private Sub tabListado_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tabListado.Click
        Dim mCatalogo As New Catalogo
        dsListaRelacionados = mCatalogo.recCatalogoRelacionados("", True, False, "")
        cargalistarelacionados()
    End Sub
    Sub cargaListaRelacionados()
        With dataListado
            .DataSource = dsListaRelacionados.Tables("articulo").DefaultView
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_art").HeaderText = "Código"
            .Columns("cod_art").Width = 55
            .Columns("cod_art").ReadOnly = True
            .Columns("cod_art").DefaultCellStyle.BackColor = Color.AliceBlue
            .Columns("cod_art").DefaultCellStyle.ForeColor = Color.MidnightBlue
            .Columns("cod_art").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("nom_art").HeaderText = "Descripción"
            .Columns("nom_art").Width = 240
            .Columns("nom_art").ReadOnly = True
            .Columns("nom_art").DefaultCellStyle.BackColor = Color.AliceBlue
            .Columns("nom_art").DefaultCellStyle.ForeColor = Color.MidnightBlue
            .Columns("nom_uni").HeaderText = "Unidad"
            .Columns("nom_uni").Width = 60
            .Columns("nom_uni").ReadOnly = True
            .Columns("nom_uni").DefaultCellStyle.BackColor = Color.AliceBlue
            .Columns("nom_uni").DefaultCellStyle.ForeColor = Color.MidnightBlue
            .Columns("nom_uni").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("nom_sgrupo").HeaderText = "Grupo"
            .Columns("nom_sgrupo").Width = 105
            .Columns("nom_sgrupo").ReadOnly = True
            .Columns("nom_sgrupo").DefaultCellStyle.BackColor = Color.AliceBlue
            .Columns("nom_sgrupo").DefaultCellStyle.ForeColor = Color.MidnightBlue
            .Columns("cod_artR").HeaderText = "Código"
            .Columns("cod_artR").Width = 55
            .Columns("cod_artR").ReadOnly = True
            .Columns("cod_artR").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("nom_artR").HeaderText = "Descripción"
            .Columns("nom_artR").Width = 240
            .Columns("nom_art").ReadOnly = True
            .Columns("nom_uniR").HeaderText = "Unidad"
            .Columns("nom_uniR").Width = 50
            .Columns("nom_uniR").ReadOnly = True
            .Columns("nom_uniR").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("nom_sgrupoR").HeaderText = "Grupo"
            .Columns("nom_sgrupoR").Width = 105
            .Columns("nom_sgrupoR").ReadOnly = True
            .Columns("cod_alma").Visible = False
            .Columns("cant_uni").Visible = False
            .Columns("cod_uni").Visible = False
            .Columns("cod_sgrupo").Visible = False
            .Columns("esProduccion").Visible = False
            .Columns("cod_almaR").Visible = False
            .Columns("cant_uniR").Visible = False
            .Columns("cod_uniR").Visible = False
            .Columns("cod_sgrupoR").Visible = False
            .Columns("esProduccionR").Visible = False
        End With
    End Sub

    Private Sub TabControl2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl2.Click

    End Sub

    Private Sub lblRegistros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblRegistros.Click

    End Sub

    Private Sub TabControlPanel4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControlPanel4.Click

    End Sub

    Private Sub dataCatalogo_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataCatalogo.CellContentClick

    End Sub

    Private Sub datosCatalogoAlmacen_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datosCatalogoAlmacen.CellContentClick

    End Sub

    Private Sub datosCatalogoGeneral_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datosCatalogoGeneral.CellContentClick

    End Sub

    Private Sub datosCatalogoGeneral_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles datosCatalogoGeneral.CellMouseDown

    End Sub

    Private Sub datosCatalogoGeneral_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles datosCatalogoGeneral.SelectionChanged
        If Not estaCargando Then
            If datosCatalogoAlmacen.RowCount > 0 And datosCatalogoGeneral.RowCount > 0 Then
                'If datosCatalogoGeneral.RowCount > 0 Then
                muestraArticulosRelacionados(cboAlmacen.SelectedValue, datosCatalogoGeneral("cod_art", datosCatalogoGeneral.CurrentRow.Index).Value, 0)
            End If
        End If
    End Sub

    Private Sub dataArtRelacionados_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataArtRelacionados.CellContentClick

    End Sub

    Private Sub dataLimpios_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataLimpios.CellContentClick

    End Sub

    Private Sub dataLimpios_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dataLimpios.DoubleClick
        eliminaITEMLimpio()
    End Sub

    Private Sub dataListado_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataListado.CellContentClick

    End Sub

    Private Sub dataListado_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dataListado.KeyDown
        If (e.Control And e.KeyCode = Keys.E) Then
            If dataListado.RowCount > 0 Then
                EnviaraExcel(dataListado)
            End If
        End If
    End Sub

    Private Sub chkProduccion_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkProduccion.CheckedChanged
        If Not estaCargando Then
            If chkProduccion.CheckState = CheckState.Checked Then
                chkProduccion.Text = "Articulos"
            Else
                
                chkProduccion.Text = "Producciones"
            End If
            If tabCatalogo.IsSelected Then
                cargaCatalogo(cboAlmacen.SelectedValue)
            Else
                cargaCatalogoRelacionados(cboAlmacen.SelectedValue)
            End If
        End If
    End Sub
End Class
