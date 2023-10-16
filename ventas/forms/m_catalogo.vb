Imports MySql.Data.MySqlClient
Imports System.Data
Imports libreriaClases
Public Class m_catalogo
    'creamos el BindingSource que relacionara los datos con los controles
    Private bsArticulo As New BindingSource
    Private daArticulo As New MySqlDataAdapter
    Private dsCatalogo As DataSet
    Private cbArticulo As MySqlCommandBuilder = New MySqlCommandBuilder(daArticulo)
    Private dtArticulo As DataTable
    Private dtUnidad As DataTable
    Private dtTipo As DataTable
    Private dtSGrupo As DataTable
    Private dsTipoCliente As New DataSet
    Private dtTipoCliente As New DataTable
    '
    Private mdssubgrupo As New DataSet
    Private mdsTipoArticulo As New DataSet
    'codigo del almacen principal
    Private cAlmaPrincipal As String
    'capturamos el boton pulsado
    Private lcBoton As String
    'capturamos el codigo del articulo-esto para la edicion
    Private lCodigo As String
    'para validar el separador decimal
    Private sepDecimal As Char
    Private estaCargando As Boolean = True
    Private Sub m_catalogo_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        principal.ma_catalogo.Enabled = True
    End Sub
    Private Sub m_catalogo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Top = 0
        Me.Left = 0
        estaCargando = False
        'capturamos el separador decimal
        sepDecimal = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        'hacemos q la etiqueta mensaje se muestre limpia
        lblMensaje.Text = ""
        If pDespachoXtipoCliente Then
            grpPrecioCliente.Enabled = True
            optPrecios.Enabled = True
        Else
            grpPrecioCliente.Enabled = False
            optPrecios.Enabled = False
        End If
        'dataset tipo de cliente
        dsTipoCliente.Tables.Add(dtTipoCliente)
        Dim daTipoCliente As New MySqlDataAdapter
        Dim comTipoCliente As New MySqlCommand("select cod_tipo,nom_tipo from tipo_cliente where activo=1 order by nom_tipo", dbConex)
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
        Dim mAlmacen As New Almacen
        cAlmaPrincipal = mAlmacen.devuelveAlmacenPrincipal
        'muestra catalogo
        muestracatalogo(False)
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
        Dim comSGrupo As New MySqlCommand("select * from subgrupo where activo=1  order by nom_sgrupo", dbConex)
        daSGrupo.SelectCommand = comSGrupo
        daSGrupo.Fill(dsCatalogo, "subgrupo")
        'relacionamos los cuadros de texto con los campos respectivos
        txtCodigo.DataBindings.Clear()
        txtCodigo.DataBindings.Add("text", bsArticulo, "cod_art", True)
        txtDescripcion.DataBindings.Add("text", bsArticulo, "nom_art")
        'pb_foto.DataBindings.Add("Image", bsArticulo, "foto")
        txtUnidad.DataBindings.Add("text", bsArticulo, "nom_uni")
        txtCosto.DataBindings.Add("text", bsArticulo, "pre_costo")
        txtBotLlena.DataBindings.Add("text", bsArticulo, "peso_lleno")
        txtBotVacia.DataBindings.Add("text", bsArticulo, "peso_vacio")
        txtPrecio.DataBindings.Add("text", bsArticulo, "pre_venta")
        chkPreIncImp.DataBindings.Add("checked", bsArticulo, "pre_inc_imp")
        chkAfecto.DataBindings.Add("checked", bsArticulo, "afecto_igv")
        txtMaximo.DataBindings.Add("text", bsArticulo, "maximo")
        txtMinimo.DataBindings.Add("text", bsArticulo, "minimo")
        txtTipo.DataBindings.Add("text", bsArticulo, "nom_tart")
        txtsubgrupo.DataBindings.Add("text", bsArticulo, "nom_sgrupo")
        TxtCodigoVta.DataBindings.Add("text", bsArticulo, "cod_artExt")
        chkInvDiario.DataBindings.Add("checked", bsArticulo, "inv_diario")
        chkBotella.DataBindings.Add("checked", bsArticulo, "es_botella")
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
        habilitabotones()
    End Sub
    Sub muestracatalogo(ByVal esProduccion As Boolean)
        'dataset catalogo
        dsCatalogo = Catalogo.dsCatalogo()
        dtArticulo = dsCatalogo.Tables("articulo")
        Dim cad1, cad2, cad3, cad4, cad5, cad6, cad As String
        cad1 = "Select cod_art,nom_art,articulo.cod_uni,nom_uni,pre_costo,pre_venta,pre_costoMax,pre_costoMin,afecto_igv,inv_diario,cod_artExt,"
        cad2 = " articulo.cod_tart,nom_tart,articulo.cod_sgrupo,nom_sgrupo,articulo.activo,minimo,maximo,pre_inc_imp,es_botella,peso_lleno,peso_vacio"
        cad3 = " from articulo inner join unidad on articulo.cod_uni=unidad.cod_uni"
        cad4 = " inner join tipo_articulo t on articulo.cod_tart=t.cod_tart"
        cad5 = " inner join subgrupo on articulo.cod_sgrupo=subgrupo.cod_sgrupo WHERE t.esProduccion=" & esProduccion
        cad6 = IIf(pCatalogoXalmacen, " and articulo.cod_alma='" & cAlmaPrincipal & "'", "") & " order by nom_art"
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
            .Columns("inv_diario").Visible = False
            .Columns("cod_artExt").Visible = False
            .Columns("minimo").Visible = False
            .Columns("maximo").Visible = False
            .Columns.Item("cod_art").Width = 55
            .Columns.Item("cod_art").HeaderText = "Código"
            .Columns.Item("nom_art").Width = 250
            .Columns.Item("nom_art").HeaderText = "Descripción"
            .Columns.Item("nom_uni").Width = 75
            .Columns.Item("nom_uni").HeaderText = "Unidad"
            .Columns.Item("pre_costo").Width = 80
            .Columns.Item("pre_costo").HeaderText = "Costo"
            '.Columns.Item("pre_venta").Width = 70
            '.Columns.Item("pre_venta").HeaderText = "Venta"
            .Columns.Item("nom_tart").Width = 140
            .Columns.Item("nom_tart").HeaderText = "Tipo"
            .Columns.Item("activo").Width = 40
            .Columns.Item("activo").HeaderText = "Act."
            .Columns.Item("pre_venta").Visible = False
            .Columns.Item("pre_costoMax").Visible = False
            .Columns.Item("pre_costoMin").Visible = False
            .Columns.Item("pre_inc_imp").Visible = False
            .Columns.Item("es_botella").Visible = False
            .Columns.Item("peso_lleno").Visible = False
            .Columns.Item("peso_vacio").Visible = False
            .ReadOnly = True
        End With
        'mostramos el numero de registros procesados
        lblRegistros.Text = "Nº de Registros Procesados... " & dataCatalogo.RowCount
    End Sub
    Sub cargasubgrupos()
        dtSGrupo = dsCatalogo.Tables("subgrupo")
        Dim daSGrupo As New MySqlDataAdapter
        Dim comSGrupo As New MySqlCommand("select * from subgrupo where not(esProduccion) and activo=1 order by nom_sgrupo", dbConex)
        daSGrupo.SelectCommand = comSGrupo
        daSGrupo.Fill(dsCatalogo, "subgrupo")
    End Sub
    Private Sub cmdAñadir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAñadir.Click
        Dim mcatalogo As New Catalogo
        lcBoton = "Añadir"
        lCodigo = ""
        dsCatalogo.Tables("articulo").Columns("activo").DefaultValue = True
        dsCatalogo.Tables("articulo").Columns("pre_inc_imp").DefaultValue = True
        dsCatalogo.Tables("articulo").Columns("inv_diario").DefaultValue = False
        dsCatalogo.Tables("articulo").Columns("afecto_igv").DefaultValue = True
        dsCatalogo.Tables("articulo").Columns("es_botella").DefaultValue = False
        dsCatalogo.Tables("articulo").Columns("pre_costo").DefaultValue = 0.0
        dsCatalogo.Tables("articulo").Columns("peso_lleno").DefaultValue = 0.0
        dsCatalogo.Tables("articulo").Columns("peso_vacio").DefaultValue = 0.0
        dsCatalogo.Tables("articulo").Columns("pre_venta").DefaultValue = 0.0
        dsCatalogo.Tables("articulo").Columns("minimo").DefaultValue = 0
        dsCatalogo.Tables("articulo").Columns("maximo").DefaultValue = 0
        bsArticulo.AddNew()
        dataCatalogo.DataSource = bsArticulo
        modoGrabar()
        habilitaDetalle()
        deshabilitaCabecera()
        txtCodigo.Focus()
        txtCodigo.Text = mcatalogo.maxCodigo()
    End Sub
    Private Sub cmdGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGrabar.Click
        Try
            If validaIngreso() Then
                Dim sql As String, result As Integer
                txtUnidad.Text = cboUnidad.Text
                txtTipo.Text = cboTipo.Text
                txtsubgrupo.Text = cbosubgrupo.Text
                Dim Imag As Byte() = Imagen_Bytes(Me.pb_foto.Image)
                If lcBoton = "Añadir" Then
                    sql = "Insert Into articulo(cod_art,nom_art,cod_uni,cod_artExt,pre_costo,pre_venta,peso_lleno,peso_vacio,pre_inc_imp,afecto_igv,minimo,maximo,cod_tart,cod_sgrupo,inv_diario,es_botella,cod_alma,usu_ins,activo,foto)" &
                    "values('" &
                    txtCodigo.Text & "','" & txtDescripcion.Text & "','" & cboUnidad.SelectedValue & "','" & TxtCodigoVta.Text & "', " &
                    txtCosto.Text & "," & txtPrecio.Text & "," & txtBotLlena.Text & "," & txtBotVacia.Text & "," & chkPreIncImp.CheckState & "," & chkAfecto.CheckState & "," & txtMinimo.Text & "," & txtMaximo.Text &
                    ",'" & cboTipo.SelectedValue & "','" & cbosubgrupo.SelectedValue + "'," & chkInvDiario.CheckState & "," & chkBotella.CheckState & ",'" & cAlmaPrincipal & "','" & pCuentaUser & "'," & chkActivo.CheckState & ",?imagen)"
                Else
                    sql = "update articulo set cod_art='" & txtCodigo.Text & "'," & "nom_art='" & txtDescripcion.Text & "'," &
                    " cod_uni='" & cboUnidad.SelectedValue & "',cod_artExt='" & TxtCodigoVta.Text & "'," &
                    " pre_costo=" & txtCosto.Text & ",pre_venta=" & txtPrecio.Text & ",peso_lleno=" & txtBotLlena.Text & ",peso_vacio=" & txtBotVacia.Text & "," &
                    " pre_inc_imp=" & chkPreIncImp.CheckState & ",afecto_igv=" & chkAfecto.CheckState & ",minimo=" & txtMinimo.Text & "," &
                    " maximo=" & txtMaximo.Text & "," &
                    " cod_tart='" & cboTipo.SelectedValue & "',cod_sgrupo='" & cbosubgrupo.SelectedValue & "'," &
                    " inv_diario=" & chkInvDiario.CheckState & ",es_botella=" & chkBotella.CheckState & ",activo=" & chkActivo.CheckState & ",foto = ?imagen" & "," &
                    " usu_mod='" & pCuentaUser & "'" &
                    " where cod_art='" & lCodigo & "'"
                End If
                Dim com As New MySqlCommand(sql, dbConex)
                com.Parameters.AddWithValue("?imagen", Imag)
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
        lblDescripcion.ForeColor = Color.Maroon
        lblUnidad.ForeColor = Color.Maroon
        lblTipo.ForeColor = Color.Maroon
        lblsubgrupo.ForeColor = Color.Maroon
        chkPreIncImp.TextColor = Color.Maroon
        chkAfecto.TextColor = Color.Maroon
        txtCodigo.BackColor = Color.White
        txtCodigo.ReadOnly = False

        txtDescripcion.BackColor = Color.White
        txtDescripcion.ReadOnly = False
        txtUnidad.BackColor = Color.White
        txtUnidad.Visible = False
        cboUnidad.Visible = True
        txtCosto.BackColor = Color.White
        txtCosto.ReadOnly = False
        TxtCodigoVta.BackColor = Color.White
        TxtCodigoVta.ReadOnly = False
        txtBotLlena.BackColor = Color.White
        txtBotLlena.ReadOnly = False
        txtBotVacia.BackColor = Color.White
        txtBotVacia.ReadOnly = False
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
        chkInvDiario.Enabled = True
        chkBotella.Enabled = True
        chkActivo.Enabled = True
    End Sub
    Sub deshabilitaDetalle()
        lblDescripcion.ForeColor = Color.Black
        lblUnidad.ForeColor = Color.Black
        lblTipo.ForeColor = Color.Black
        lblsubgrupo.ForeColor = Color.Black
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
        TxtCodigoVta.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        TxtCodigoVta.ReadOnly = True
        txtBotLlena.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        txtBotLlena.ReadOnly = True
        txtBotVacia.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        txtBotVacia.ReadOnly = True
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
        chkInvDiario.Enabled = False
        chkBotella.Enabled = False
        chkActivo.Enabled = False
    End Sub
    Sub habilitaCabecera()
        dataCatalogo.Enabled = True
        If pDespachoXtipoCliente Then
            grpPrecioCliente.Enabled = True
        Else
            grpPrecioCliente.Enabled = False
        End If
        txtBuscar.Enabled = True
    End Sub
    Sub deshabilitaCabecera()
        txtBuscar.Enabled = False
        dataCatalogo.Enabled = False
        grpPrecioCliente.Enabled = False
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

    Sub habilitabotones()
        If pNivelUser <> "0" Then
            cmdAñadir.Enabled = False
            cmdGrabar.Enabled = False
            cmdCancelar.Enabled = False
            cmdEditar.Enabled = False
            cmdEliminar.Enabled = False
        End If

    End Sub

    'convertir binario a imágen
    Private Function Bytes_Imagen(ByVal Imagen As Byte()) As Image
        Try
            'si hay imagen
            If Not Imagen Is Nothing Then
                'caturar array con memorystream hacia Bin
                Dim Bin As New IO.MemoryStream(Imagen)
                'con el método FroStream de Image obtenemos imagen
                Dim Resultado As Image = Image.FromStream(Bin)
                'y la retornamos
                Return Resultado
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    'convertir imagen a binario
    Private Function Imagen_Bytes(ByVal Imagen As Image) As Byte()
        'si hay imagen
        If Not Imagen Is Nothing Then
            'variable de datos binarios en stream(flujo)
            Dim Bin As New IO.MemoryStream
            'convertir a bytes
            Imagen.Save(Bin, Imaging.ImageFormat.Jpeg)
            'retorna binario
            Return Bin.GetBuffer
        Else
            Return Nothing
        End If
    End Function

    Private Sub txtCodigo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.GotFocus
        If lcBoton = "Editar" Then
            lCodigo = txtCodigo.Text
        End If
        general.ingresaTexto(txtCodigo)
    End Sub
    Private Sub txtCodigo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.LostFocus
        'If Len(txtCodigo.Text) > 0 Then
        '    txtCodigo.Text = Microsoft.VisualBasic.Right("000000" + Trim(txtCodigo.Text), 9)
        'End If
        'general.saleTexto(txtCodigo)
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
    Private Sub txtCostoMax_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBotLlena.GotFocus
        general.ingresaTexto(txtBotLlena)
    End Sub
    Private Sub txtCostoMax_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBotLlena.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not (e.KeyChar = ChrW(Keys.Back)) And Not (e.KeyChar.Equals(sepDecimal)) Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub txtCostoMax_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBotLlena.LostFocus
        general.saleTexto(txtBotLlena)
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
    Sub MuestraFoto(ByVal carticulo As String)
        Try
            Dim cad As String, dr As MySqlDataReader, resul As Integer
            cad = "select isnull(foto) as vnul,foto from articulo where cod_art='" & carticulo & "'"
            Dim com As New MySqlCommand(cad, dbConex)
            dr = com.ExecuteReader
            Dim Imag As Byte() = Nothing
            While dr.Read
                resul = dr("vnul")
                If resul = 0 Then
                    Imag = dr("foto")
                    Me.pb_foto.Image = Bytes_Imagen(Imag)
                Else
                    Me.pb_foto.Image = Bytes_Imagen(Imag)
                End If
            End While
            dr.Close()
            dr = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub muestraPrecios()
        If pDespachoXtipoCliente Then
            If dataCatalogo.RowCount > 0 Then
                Dim codigo, tipo, cad As String, dr As MySqlDataReader
                tipo = cboTipoCliente.SelectedValue
                If IsDBNull(dataCatalogo.Item("cod_art", dataCatalogo.CurrentRow.Index).Value) Then
                    codigo = ""
                Else
                    codigo = dataCatalogo.Item("cod_art", dataCatalogo.CurrentRow.Index).Value
                End If
                cad = "select precio,comi_v,comi_jv from art_tipoCliente where cod_art='" & codigo & "'" & " and cod_tipo='" & tipo & "'"
                Dim com As New MySqlCommand(cad, dbConex)
                dr = com.ExecuteReader
                If dr.HasRows = True Then
                    lblMensaje.Text = ""
                    While dr.Read
                        txtPrecioCliente.Text = dr(0)
                        txtComisionV.Text = dr(1)
                        txtComisionJV.Text = dr(2)
                    End While
                Else
                    txtPrecioCliente.Text = 0.0
                    txtComisionV.Text = 0.0
                    txtComisionJV.Text = 0.0
                    lblMensaje.Text = "Artículo sin Comisión Establecida"
                End If
                dr.Close()
                dr = Nothing
            End If
        End If
    End Sub
    Private Sub cboTipoCliente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoCliente.SelectedIndexChanged
        dataCatalogo.Focus()
    End Sub
    Private Sub txtPrecioCliente_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPrecioCliente.Click
        txtPrecioCliente.SelectAll()
    End Sub
    Private Sub txtPrecioCliente_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPrecioCliente.GotFocus
        general.ingresaTextoProceso(txtPrecioCliente)
        txtPrecioCliente.SelectAll()
    End Sub
    Private Sub txtPrecioCliente_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPrecioCliente.LostFocus
        general.saleTextoProceso(txtPrecioCliente)
    End Sub

    Private Sub txtComisionV_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtComisionV.GotFocus
        general.ingresaTextoProceso(txtComisionV)
        txtComisionV.SelectAll()
    End Sub
    Private Sub txtComisionV_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtComisionV.LostFocus
        general.saleTextoProceso(txtComisionV)
    End Sub

    Private Sub txtComisionJV_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtComisionJV.GotFocus
        general.ingresaTextoProceso(txtComisionJV)
        txtComisionJV.SelectAll()
    End Sub

    Private Sub txtComisionJV_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtComisionJV.LostFocus
        general.saleTextoProceso(txtComisionJV)
    End Sub
    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        Dim frm As New rptForm
        Dim soloactivos As Boolean = IIf(chkSoloActivos.Checked, True, False)
        Dim soloventas As Boolean = IIf(Chksoloventas.Checked, True, False)
        Try
            If optGeneral.Checked = True Then
                frm.cargarCatalogo(cAlmaPrincipal, soloactivos, soloventas, False, "Catalogo General")
                frm.MdiParent = principal
                frm.Show()
            Else
                If optPrecios.Checked = True Then
                    frm.cargarCatalogo_Precio()
                    frm.MdiParent = principal
                    frm.Show()
                Else
                    If optInventarioDiario.Checked = True Then
                        frm.cargarCatalogo(cAlmaPrincipal, False, False, True, "Catalogo General - Para Inv. Diario")
                        frm.MdiParent = principal
                        frm.Show()
                    Else
                        If cboImp_x_tipo.SelectedIndex >= 0 Then
                            Dim cod As String = cboImp_x_tipo.SelectedValue
                            Dim nom As String = cboImp_x_tipo.Text
                            If optsubgrupo.Checked = True Then
                                frm.cargarCatalogo_x_Tipo(cAlmaPrincipal, soloactivos, "subgrupo", cod, "Grupo: " + nom)
                            Else
                                frm.cargarCatalogo_x_Tipo(cAlmaPrincipal, soloactivos, "tipoArticulo", cod, "Tipo: " + nom)
                            End If
                            frm.MdiParent = principal
                            frm.Show()
                        Else
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub dataCatalogo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dataCatalogo.GotFocus
        Dim codigo, tipo As String
        tipo = cboTipoCliente.SelectedValue
        If dataCatalogo.RowCount > 0 Then
            If IsDBNull(dataCatalogo.Item("cod_art", dataCatalogo.CurrentRow.Index).Value) Then
                codigo = ""
            Else
                codigo = dataCatalogo.Item("cod_art", dataCatalogo.CurrentRow.Index).Value
                muestraPrecios()
                MuestraFoto(codigo)
            End If
        End If
    End Sub
    Private Sub dataCatalogo_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dataCatalogo.SelectionChanged
        Dim codigo As String
        If dataCatalogo.RowCount > 0 Then
            If IsDBNull(dataCatalogo.Item("cod_art", dataCatalogo.CurrentRow.Index).Value) Then
                codigo = ""
            Else
                codigo = dataCatalogo.Item("cod_art", dataCatalogo.CurrentRow.Index).Value
                muestraPrecios()
                MuestraFoto(codigo)
            End If
        End If
    End Sub
    Private Sub cmdPrecioCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrecioCliente.Click
        Dim sql1, sql2, sql As String, res As Decimal, codigo As String, precio As Decimal, tipo As String
        Dim comi_v, comi_jv As Decimal
        If dataCatalogo.RowCount > 0 Then
            codigo = dataCatalogo.Item("cod_art", dataCatalogo.CurrentRow.Index).Value
            tipo = cboTipoCliente.SelectedValue
            precio = txtPrecioCliente.Text
            comi_v = txtComisionV.Text
            comi_jv = txtComisionJV.Text
            sql1 = "select count(cod_art) from art_tipoCliente "
            sql2 = "where cod_art='" & codigo & "'" & " and cod_tipo='" & tipo & "'"
            sql = sql1 + sql2
            Dim com As New MySqlCommand
            com.CommandText = sql
            com.Connection = dbConex
            Dim obj As Object = com.ExecuteScalar
            res = CType(IIf(IsDBNull(obj), 0, obj), Integer)
            If res = 1 Then
                sql = "update art_tipoCliente set precio=" & precio & "," & "comi_v=" & comi_v & "," & "comi_jv=" & comi_jv & " where cod_art='" & codigo & "'" & " and cod_tipo='" & tipo & "'"
                Dim comUPD As New MySqlCommand(sql, dbConex)
                comUPD.ExecuteNonQuery()
            Else
                sql = "insert into art_tipoCliente(cod_art,cod_tipo,precio,comi_v,comi_jv)values('" & codigo & "','" & tipo & "'," & precio & "," & comi_v & "," & comi_jv & ")"
                Dim comINS As New MySqlCommand(sql, dbConex)
                comINS.ExecuteNonQuery()
            End If
            dataCatalogo.Focus()
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
            Dim comsubgrupo As New MySqlCommand("select cod_sgrupo,nom_sgrupo from subgrupo where not(esProduccion) and activo=1 order by nom_sgrupo", dbConex)
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
            Dim comTipoArticulo As New MySqlCommand("select cod_tart,nom_tart from tipo_articulo where activo=1 order by nom_tart", dbConex)
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
    Private Sub optDescripcion_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles optDescripcion.Click
        txtBuscar.Focus()
    End Sub
    Private Sub optCodigo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles optCodigo.Click
        txtBuscar.Focus()
    End Sub
    Private Sub txtBuscar_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscar.GotFocus
        general.ingresaTextoProceso(txtBuscar)
        txtBuscar.SelectAll()
    End Sub

    Private Sub txtBuscar_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscar.LostFocus
        general.saleTextoProceso(txtBuscar)
    End Sub
    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged
        If optDescripcion.Checked = True Then
            bsArticulo.Filter = "nom_art like '" & txtBuscar.Text & "%'"
        Else
            bsArticulo.Filter = "cod_art like '" & txtBuscar.Text & "%'"
        End If
    End Sub
    Private Sub cboTipo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboTipo.GotFocus
        dtTipo = dsCatalogo.Tables("tipo_articulo")
        Dim daTipo As New MySqlDataAdapter
        Dim comTipo As New MySqlCommand("select * from tipo_articulo where activo=1 order by nom_tart", dbConex)
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
    Private Sub cboUnidad_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboUnidad.GotFocus
        dtUnidad = dsCatalogo.Tables("unidad")
        Dim daUnidad As New MySqlDataAdapter
        Dim comUnidad As New MySqlCommand("select * from unidad where activo=1 order by nom_uni", dbConex)
        daUnidad.SelectCommand = comUnidad
        daUnidad.Fill(dsCatalogo, "unidad")
    End Sub

    Private Sub chkBotella_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBotella.CheckedChanged

    End Sub

    Private Sub cmdExaminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExaminar.Click
        Dim oFD As New OpenFileDialog, mFile As String
        With oFD
            .Title = "Seleccionar fichero"
            .Multiselect = False
            '.Filter = "Ficheros de texto (*.txt;*.ini)|*.txt;*.ini" & _
            '          "|Todos los ficheros (*.*)|*.*"
            .Filter = "Archivo de Imagen (*.jpg)|*.jpg"
            If .ShowDialog = System.Windows.Forms.DialogResult.OK Then
                mFile = .FileName
                Me.pb_foto.Image = Image.FromFile(mFile)
            Else
                mFile = ""
            End If

        End With
    End Sub



    Private Sub cboImp_x_tipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboImp_x_tipo.SelectedIndexChanged
        If Not estaCargando Then
            bsArticulo.Filter = "nom_sgrupo like '" & cboImp_x_tipo.Text & "%'"
        End If
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim mcatalogo As New Catalogo
        txtCodigo.Text = mcatalogo.maxCodigo()
    End Sub

    Private Sub dataCatalogo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dataCatalogo.KeyPress

    End Sub

    Private Sub dataCatalogo_KeyDown(sender As Object, e As KeyEventArgs) Handles dataCatalogo.KeyDown
        If (e.Control And e.KeyCode = Keys.E) Then
            If dataCatalogo.RowCount > 0 Then
                EnviaraExcel(dataCatalogo)
            End If
        End If
    End Sub

    Private Sub ChkMuestraVenta_CheckedChanged(sender As Object, e As EventArgs) Handles ChkMuestraVenta.CheckedChanged
        If Not estaCargando Then
            If ChkMuestraVenta.CheckState = CheckState.Checked Then
                ChkMuestraVenta.Text = "Muestra Articulo de Venta"
            Else
                ChkMuestraVenta.Text = "Muestra Articulo de Compra"
            End If
            muestracatalogo(ChkMuestraVenta.Checked)

        End If
    End Sub
End Class
