Imports libreriaClases
Imports MySql.Data.MySqlClient
Imports System.Data
Public Class m_subgrupo
    Private dasubgrupo As New MySqlDataAdapter
    Private cbsubgrupo As MySqlCommandBuilder = New MySqlCommandBuilder(dasubgrupo)
    Private dssubgrupo As DataSet
    Private dtsubgrupo As DataTable
    Private bssubgrupo As New BindingSource
    Private dsFamilia As New DataSet
    Private dsGrupo As New DataSet
    Private lcodigo As String
    Private estacargando As Boolean = True
    Private Sub m_subgrupo_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        principal.ma_sgrupo.Enabled = True
    End Sub
    Private Sub m_grupo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Top = 0
        Me.Left = 0
        'dataset familias
        Dim daFamilia As New MySqlDataAdapter
        Dim comFamilia As New MySqlCommand("select cod_familia,nom_familia from familia where activo=1 order by nom_familia", dbConex)
        daFamilia.SelectCommand = comFamilia
        daFamilia.Fill(dsfamilia, "familia")
        With cboFamilia
            .DataSource = dsFamilia.Tables("familia")
            .DisplayMember = dsFamilia.Tables("familia").Columns("nom_familia").ToString
            .ValueMember = dsFamilia.Tables("familia").Columns("cod_familia").ToString
        End With

        'dataset Grupo
        Dim dagrupo As New MySqlDataAdapter
        Dim comGrupo As New MySqlCommand("select cod_grupo,nom_grupo from grupo where activo=1 and esVenta order by nom_grupo", dbConex)
        dagrupo.SelectCommand = comGrupo
        dagrupo.Fill(dsGrupo, "Grupo")
        With cboGrupo
            .DataSource = dsGrupo.Tables("Grupo")
            .DisplayMember = dsGrupo.Tables("Grupo").Columns("nom_grupo").ToString
            .ValueMember = dsGrupo.Tables("Grupo").Columns("cod_grupo").ToString
        End With
        'cargamos el dataset
        dssubgrupo = subgrupo.dssubgrupo
        dtsubgrupo = dssubgrupo.Tables("subgrupo")
        Dim com As New MySqlCommand("Select cod_sgrupo,nom_sgrupo,cod_familia,cod_grupo,esProduccion,esVenta,repInventario,repGerencia,f_tamano,b_ancho,b_alto,impresora,activo from subgrupo order by nom_sgrupo", dbConex)
        dasubgrupo.SelectCommand = com
        dasubgrupo.Fill(dssubgrupo, "subgrupo")
        bssubgrupo.DataSource = dssubgrupo
        bssubgrupo.DataMember = "subgrupo"
        With datos
            .DataSource = bssubgrupo
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_sgrupo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns.Item("cod_sgrupo").HeaderText = "Código"
            .Columns.Item("cod_sgrupo").Resizable = DataGridViewTriState.False
            .Columns.Item("cod_sgrupo").Width = "50"
            .Columns.Item("cod_sgrupo").DisplayIndex = 0
            .Columns.Item("nom_sgrupo").HeaderText = "Grupo"
            .Columns.Item("nom_sgrupo").Resizable = DataGridViewTriState.False
            .Columns.Item("nom_sgrupo").Width = "180"
            .Columns.Item("nom_sgrupo").DisplayIndex = 1
            .Columns.Item("esProduccion").HeaderText = "Para Producción"
            .Columns.Item("esProduccion").Resizable = DataGridViewTriState.False
            .Columns.Item("esProduccion").Width = "60"
            .Columns.Item("esProduccion").DisplayIndex = 2
            .Columns.Item("esVenta").HeaderText = "Para Venta"
            .Columns.Item("esVenta").Resizable = DataGridViewTriState.False
            .Columns.Item("esVenta").Width = "50"
            .Columns.Item("esVenta").DisplayIndex = 3
            .Columns.Item("repInventario").HeaderText = "Mostrar Rep. Inventarios"
            .Columns.Item("repInventario").Resizable = DataGridViewTriState.False
            .Columns.Item("repInventario").Width = "60"
            .Columns.Item("repInventario").DisplayIndex = 4
            .Columns.Item("repGerencia").HeaderText = "Mostrar Rep. Gerencia"
            .Columns.Item("repGerencia").Resizable = DataGridViewTriState.False
            .Columns.Item("repGerencia").Width = "60"
            .Columns.Item("repGerencia").DisplayIndex = 5
            .Columns.Item("activo").HeaderText = "Activo"
            .Columns.Item("activo").Resizable = DataGridViewTriState.False
            .Columns.Item("activo").Width = "40"
            .Columns.Item("activo").DisplayIndex = 6
            .Columns.Item("cod_familia").Visible = False
            .Columns.Item("cod_grupo").Visible = False
            .Columns.Item("impresora").Visible = False
            .Columns.Item("b_ancho").Visible = False
            .Columns.Item("b_alto").Visible = False
            .Columns.Item("f_tamano").Visible = False
        End With
        'relacionamos los cuadros de texto con el bindingSource
        txtCodigo.DataBindings.Add("text", bssubgrupo, "cod_sgrupo")
        txtGrupo.DataBindings.Add("text", bssubgrupo, "nom_sgrupo")
        cboFamilia.DataBindings.Add("selectedValue", bssubgrupo, "cod_familia")
        cboGrupo.DataBindings.Add("selectedValue", bssubgrupo, "cod_grupo")
        chkProduccion.DataBindings.Add("checked", bssubgrupo, "esProduccion")
        ChkVentas.DataBindings.Add("checked", bssubgrupo, "esVenta")
        chkInventario.DataBindings.Add("checked", bssubgrupo, "repInventario")
        ChkGerencia.DataBindings.Add("checked", bssubgrupo, "repGerencia")
        txttamfuente.DataBindings.Add("text", bssubgrupo, "f_tamano")
        txtancho.DataBindings.Add("text", bssubgrupo, "b_ancho")
        txtalto.DataBindings.Add("text", bssubgrupo, "b_alto")
        txtImpresora.DataBindings.Add("text", bssubgrupo, "impresora")
        chkActivo.DataBindings.Add("checked", bssubgrupo, "activo")
        estacargando = False
    End Sub
    Private Sub cmdAñadir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAñadir.Click
        habilitaDetalle()
        deshabilitaCabecera()
        dssubgrupo.Tables("subgrupo").Columns("esProduccion").DefaultValue = False
        dssubgrupo.Tables("subgrupo").Columns("esVenta").DefaultValue = False
        dssubgrupo.Tables("subgrupo").Columns("repInventario").DefaultValue = False
        dssubgrupo.Tables("subgrupo").Columns("repGerencia").DefaultValue = False
        dssubgrupo.Tables("subgrupo").Columns("activo").DefaultValue = True
        dssubgrupo.Tables("subgrupo").Columns("impresora").DefaultValue = ""
        'dssubgrupo.Tables("subgrupo").Columns("b_ancho").DefaultValue = 100
        'dssubgrupo.Tables("subgrupo").Columns("b_alto").DefaultValue = 80
        bssubgrupo.AddNew()
        datos.DataSource = bssubgrupo
        modoGrabar()
        txtCodigo.Refresh()
        txtGrupo.Refresh()
        chkActivo.Refresh()
        txtCodigo.Focus()
    End Sub
    Private Sub cmdGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGrabar.Click
        Dim result As Integer, cad, color, colorfuente As String
        Try
            If validaIngreso() = True Then
                Dim Imag As Byte() = Imagen_Bytes(Me.pb_foto.Image)

                bssubgrupo.EndEdit()
                dasubgrupo.Update(dssubgrupo, "subgrupo")
                datos.Refresh()
                deshabilitaDetalle()
                habilitaCabecera()
                modoAñadir()
                datos.Focus()
                color = txtColor.Text
                colorfuente = TxtColorfuente.Text
                If color.Length = 6 Then
                    color = "&H" & color.Substring(4, 2) & color.Substring(2, 2) & color.Substring(0, 2)
                Else
                    color = ""
                End If
                If colorfuente.Length = 6 Then
                    colorfuente = "&H" & colorfuente.Substring(4, 2) & colorfuente.Substring(2, 2) & colorfuente.Substring(0, 2)
                Else
                    colorfuente = ""
                End If

                cad = " update subgrupo set foto = ?imagen,b_color='" & color & "',f_color='" & colorfuente & "' where cod_sgrupo='" & lcodigo & "'"
                Dim com As New MySqlCommand(cad, dbConex)
                com.Parameters.AddWithValue("?imagen", Imag)
                result = com.ExecuteNonQuery()

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            bssubgrupo.CancelEdit()
            datos.Refresh()
            deshabilitaDetalle()
            habilitaCabecera()
            modoAñadir()
            datos.Focus()
        End Try
    End Sub
    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        bssubgrupo.CancelEdit()
        datos.Refresh()
        deshabilitaDetalle()
        habilitaCabecera()
        modoAñadir()
        datos.Focus()
        'If datos.Rows.Count > 0 Then
        '    datos.CurrentCell = datos(1, 0)
        'End If
    End Sub
    Private Sub cmdEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEliminar.Click
        If bssubgrupo.Count > 0 Then
            Dim mSGrupo As New subgrupo, exist, rpta As Integer
            exist = mSGrupo.existeEnCatalogo(Trim(txtCodigo.Text))
            If exist = 0 Then
                rpta = MessageBox.Show("¿Esta seguro de Eliminar el ITEM Seleccionado...", "SGA", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                If rpta = 6 Then
                    If bssubgrupo.Count > 0 Then
                        bssubgrupo.RemoveCurrent()
                        dasubgrupo.Update(dssubgrupo, "subgrupo")
                        datos.Refresh()
                    End If
                End If
            Else
                MessageBox.Show("El Registro Tiene Datos Relacionados..." + Chr(13) + "!NO Es posible eliminarlo¡", "Almcen", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button2)
            End If
        End If
    End Sub
    Private Sub cmdEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEditar.Click
        If bssubgrupo.Count > 0 Then
            habilitaDetalle()
            deshabilitaCabecera()
            modoGrabar()
            txtCodigo.Focus()
            lcodigo = txtCodigo.Text
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

    Function validaIngreso()
        Dim validado As Boolean = False
        If Len(txtCodigo.Text) > 0 Then
            If Len(txtGrupo.Text) > 0 Then
                If cboFamilia.SelectedIndex >= 0 Then
                    validado = True
                Else
                    MessageBox.Show("Seleccione la Familia a la Cual pertenece el Grupo...", "CEFE", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtGrupo.Focus()
                End If
            Else
                MessageBox.Show("Ingrese el Grupo...", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtGrupo.Focus()
            End If
        Else
            MessageBox.Show("Ingrese el Código...", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCodigo.Focus()
        End If
        Return validado
    End Function
    Private Sub txtCodigo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.GotFocus
        general.ingresaTexto(txtCodigo)
    End Sub
    Private Sub txtCodigo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.LostFocus
        If Len(txtCodigo.Text) > 0 Then
            txtCodigo.Text = Microsoft.VisualBasic.Right("0000" + Trim(txtCodigo.Text), 4)
        End If
        general.saleTexto(txtCodigo)
    End Sub
    Private Sub txtGrupo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtGrupo.GotFocus
        general.ingresaTexto(txtGrupo)
    End Sub
    Private Sub txtGrupo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtGrupo.LostFocus
        general.saleTexto(txtGrupo)
    End Sub
    Sub habilitaDetalle()
        lblCodigo.ForeColor = Color.Maroon
        lblGrupo.ForeColor = Color.Maroon
        lblFamilia.ForeColor = Color.Maroon
        txtCodigo.BackColor = Color.White
        txtCodigo.ReadOnly = False
        txtGrupo.BackColor = Color.White
        txtGrupo.ReadOnly = False
        cboFamilia.BackColor = Color.White
        cboFamilia.Enabled = True
        cboGrupo.BackColor = Color.White
        cboGrupo.Enabled = True
        chkProduccion.Enabled = True
        ChkVentas.Enabled = True
        chkInventario.Enabled = True
        ChkGerencia.Enabled = True
        chkActivo.Enabled = True
    End Sub
    Sub deshabilitaDetalle()
        lblCodigo.ForeColor = Color.Black
        lblGrupo.ForeColor = Color.Black
        lblFamilia.ForeColor = Color.Black
        txtCodigo.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        txtCodigo.ReadOnly = True
        txtGrupo.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        txtGrupo.ReadOnly = True
        cboFamilia.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        cboFamilia.Enabled = False
        cboGrupo.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        cboGrupo.Enabled = False
        chkProduccion.Enabled = False
        ChkVentas.Enabled = False
        chkInventario.Enabled = False
        ChkGerencia.Enabled = False
        chkActivo.Enabled = False
    End Sub
    Sub habilitaCabecera()
        datos.Enabled = True
    End Sub
    Sub deshabilitaCabecera()
        datos.Enabled = False
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
    Private Sub cmdCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCerrar.Click
        Me.Close()
    End Sub

    Private Sub SimpleButton1_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton1.Click
        Dim vImagen As System.Drawing.Image
        vImagen = Clipboard.GetImage
        pb_foto.Image = vImagen
    End Sub

    Private Sub cmdExaminar_Click(sender As System.Object, e As System.EventArgs) Handles cmdExaminar.Click
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

 


    Private Sub datos_SelectionChanged(sender As Object, e As System.EventArgs) Handles datos.SelectionChanged
        Dim codigo As String
        If Not estacargando Then
            If datos.RowCount > 0 Then
                If Not IsDBNull(datos("cod_sgrupo", datos.CurrentRow.Index).Value) Then
                    codigo = datos("cod_sgrupo", datos.CurrentRow.Index).Value
                    MuestraFoto(codigo)
                End If
            End If
        End If
    End Sub

    Sub MuestraFoto(ByVal codigo As String)
        Try
            Dim cad, color, colorfuente As String, dr As MySqlDataReader, resul As Integer
            cad = "select isnull(foto) as vnul,foto,b_color,f_color from subgrupo where cod_sgrupo='" & codigo & "'"
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
                color = dr("b_color")
                If color.Length > 0 Then
                    txtColor.Text = color.Substring(6, 2) & color.Substring(4, 2) & color.Substring(2, 2)
                Else
                    color = ""
                End If

                colorfuente = dr("f_color")
                If colorfuente.Length > 0 Then
                    TxtColorfuente.Text = colorfuente.Substring(6, 2) & colorfuente.Substring(4, 2) & colorfuente.Substring(2, 2)
                Else
                    colorfuente = ""
                End If

            End While
            dr.Close()
            dr = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Lnkcolor_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkColor.LinkClicked
        System.Diagnostics.Process.Start("http://html-color-codes.info/codigos-de-colores-hexadecimales/")
    End Sub


 

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("http://html-color-codes.info/codigos-de-colores-hexadecimales/")
    End Sub

    Private Sub datos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datos.CellContentClick

    End Sub

    Private Sub datos_KeyDown(sender As Object, e As KeyEventArgs) Handles datos.KeyDown
        If (e.Control And e.KeyCode = Keys.E) Then
            If datos.RowCount > 0 Then
                EnviaraExcel(datos)
            End If
        End If
    End Sub
End Class
