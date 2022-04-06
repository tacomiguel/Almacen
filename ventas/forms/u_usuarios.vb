Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Math
Imports libreriaClases
Public Class u_usuarios
    Private daUsuario As New MySqlDataAdapter
    Private cbUsuario As MySqlCommandBuilder = New MySqlCommandBuilder(daUsuario)
    Private dsUsuario As DataSet
    Private dtUsuario As DataTable
    Private bsUsuario As New BindingSource
    Private dsMenu As New DataSet
    Private dsSubMenu As New DataSet
    '
    Private estaCargando As Boolean = True
    Private lcodigo As String
    Private Sub u_usuarios_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        principal.mu_usuarios.Enabled = True
    End Sub
    Private Sub u_usuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Top = 0
        Me.Left = 0
        'cargamos el dataset
        dsUsuario = usuario.dsUsuario
        'cargamos el datatable
        dtUsuario = dsUsuario.Tables("usuario")
        'creamos y trabajamos con el comando a ejecutar
        Dim com As New MySqlCommand("Select user,cuenta,clave,nivel,activo from usuario", dbConex)
        daUsuario.SelectCommand = com
        'cargamos los registros en la tabla
        daUsuario.Fill(dsUsuario, "usuario")
        'configuramos el bindingSource
        bsUsuario.DataSource = dsUsuario
        bsUsuario.DataMember = "usuario"
        'configuramos el datagridview
        With dataUsuario
            .DataSource = bsUsuario
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("user").HeaderText = "Usuario del Sistema"
            .Columns("user").Width = "200"
            .Columns("cuenta").Visible = False
            .Columns("clave").Visible = False
            .Columns("nivel").Visible = False
            .Columns("activo").Visible = False
        End With
        'relacionamos los cuadros de texto con el bindingSource
        txtUsuario.DataBindings.Add("text", bsUsuario, "user")
        txtCuenta.DataBindings.Add("text", bsUsuario, "cuenta")
        txtClave.DataBindings.Add("text", bsUsuario, "clave")
        chkActivo.DataBindings.Add("checked", bsUsuario, "activo")
        'dataset menus
        Dim daMenu As New MySqlDataAdapter
        Dim comMenu As New MySqlCommand("select cod_menu,nom_menu from menu where activo=1 order by cod_menu", dbConex)
        daMenu.SelectCommand = comMenu
        daMenu.Fill(dsMenu, "menu")
        With cboMenu
            .DataSource = dsMenu.Tables("menu")
            .DisplayMember = dsMenu.Tables("menu").Columns("nom_menu").ToString
            .ValueMember = dsMenu.Tables("menu").Columns("cod_menu").ToString
            If dsMenu.Tables("menu").Rows.Count > 0 Then
                .SelectedIndex = 0
            Else
                .SelectedIndex = -1
            End If
        End With
        estaCargando = False
    End Sub
    Private Sub txtUsuario_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUsuario.GotFocus
        general.ingresaTexto(txtUsuario)
    End Sub
    Private Sub txtUsuario_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUsuario.LostFocus
        general.saleTexto(txtUsuario)
    End Sub
    Private Sub txtCuenta_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCuenta.GotFocus
        general.ingresaTexto(txtCuenta)
    End Sub
    Private Sub txtCuenta_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCuenta.LostFocus
        general.saleTexto(txtCuenta)
    End Sub
 
    Sub habilitaDetalle()
        txtUsuario.BackColor = Color.White
        txtUsuario.ReadOnly = False
        txtCuenta.BackColor = Color.White
        txtCuenta.ReadOnly = False
        txtClave.BackColor = Color.White
        txtClave.ReadOnly = False
        chkActivo.Enabled = True
    End Sub
    Sub deshabilitaDetalle()
        txtUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        txtUsuario.ReadOnly = True
        txtCuenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        txtCuenta.ReadOnly = True
        txtClave.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        txtClave.ReadOnly = True
        chkActivo.Enabled = False
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
    Private Sub cmdAñadir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAñadir.Click
        habilitaDetalle()
        dsUsuario.Tables("usuario").Columns("activo").DefaultValue = True
        bsUsuario.AddNew()
        dataUsuario.DataSource = bsUsuario
        modoGrabar()
        txtUsuario.Refresh()
        txtCuenta.Refresh()
        txtClave.Refresh()
        chkActivo.Refresh()
        txtUsuario.Focus()
    End Sub
    Private Sub cmdGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGrabar.Click
        Dim Imag As Byte() = Imagen_Bytes(Me.pb_foto.Image)
        Dim result As Integer
        Dim cad As String
        'Try
        bsUsuario.EndEdit()
        daUsuario.Update(dsUsuario, "usuario")
        dataUsuario.Refresh()
        deshabilitaDetalle()
        modoAñadir()
        dataUsuario.Focus()

        cad = " update usuario set foto = ?imagen  where cuenta='" & lcodigo & "'"
        Dim com As New MySqlCommand(cad, dbConex)
        com.Parameters.AddWithValue("?imagen", Imag)
        result = com.ExecuteNonQuery()

        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        '    bsUsuario.CancelEdit()
        '    dataUsuario.Refresh()
        '    deshabilitaDetalle()
        '    modoAñadir()
        '    dataUsuario.Focus()
        'End Try
    End Sub
    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        bsUsuario.CancelEdit()
        dataUsuario.Refresh()
        deshabilitaDetalle()
        modoAñadir()
        dataUsuario.Focus()
        If dataUsuario.Rows.Count > 0 Then
            dataUsuario.CurrentCell = dataUsuario("user", 0)
        End If
    End Sub
    Private Sub cmdEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEliminar.Click
        If bsUsuario.Count > 0 Then
            Dim rpta As Integer
            rpta = MessageBox.Show("Esta Seguro de Eliminar el ITEM Seleccionado...", "SGA", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            If rpta = 6 Then
                If bsUsuario.Count > 0 Then
                    bsUsuario.RemoveCurrent()
                    daUsuario.Update(dsUsuario, "usuario")
                End If
            End If
        End If
    End Sub
    Private Sub cmdEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEditar.Click
        If bsUsuario.Count > 0 Then
            habilitaDetalle()
            modoGrabar()
            lcodigo = txtCuenta.Text
            txtUsuario.Focus()
        End If
    End Sub
    Private Sub cmdActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdActualizar.Click
        Dim dsPermisos, dsMenus As New DataSet, lcuenta, lmenu As String
        If Not IsDBNull(dataUsuario("cuenta", dataUsuario.CurrentRow.Index).Value) Then
            Dim mUsuario As New usuario
            'capturamos la cuenta seleccionada
            lcuenta = dataUsuario("cuenta", dataUsuario.CurrentRow.Index).Value
            'capturamos los sub menus
            Dim daMenus As New MySqlDataAdapter
            'recuperamos los sub menus del sistema
            Dim comMenus As New MySqlCommand("select cod_smenu,nom_smenu,activo from menu_sub where activo=1 order by cod_smenu", dbConex)
            daMenus.SelectCommand = comMenus
            daMenus.Fill(dsMenus, "menus")
            'identificamos los sub menus que tiene asignado el usuario
            Dim com As New MySqlCommand, cad As String
            cad = "select count(cuenta) from usuario_smenu where cuenta='" & lcuenta & "'"
            com.Connection = dbConex
            com.CommandText = cad
            Dim resp As Integer = com.ExecuteScalar
            If resp = 0 Then
                'como aun no se asigna permisos al usuario
                Dim com1 As New MySqlCommand
                cad = "insert into usuario_smenu(select '" & lcuenta & "'," & " cod_smenu,0 from menu_sub)"
                com1.Connection = dbConex
                com1.CommandText = cad
                Dim resp1 As Integer = com1.ExecuteNonQuery
            Else
                'verificamos la existencia de una nueva opción de menu
                If resp <> dsMenus.Tables("menus").Rows.Count Then
                    Dim I As Integer = 1
                    For I = 1 To dsMenus.Tables("menus").Rows.Count - 1
                        lmenu = dsMenus.Tables("menus").Rows(I).Item("cod_smenu").ToString
                        If Not mUsuario.existeMenu(lcuenta, lmenu) Then
                            insertaSubMenu(lcuenta, lmenu)
                        End If
                    Next
                End If
            End If
            If cboMenu.SelectedIndex >= 0 Then
                cboMenu.SelectedIndex = -1
                cboMenu.SelectedIndex = 0
                cboMenu.Focus()
            End If
        End If
    End Sub
    Private Sub dataUsuario_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dataUsuario.SelectionChanged
        If Not estaCargando Then
            Dim codigo As String
            If Not IsDBNull(dataUsuario("cuenta", dataUsuario.CurrentRow.Index).Value) Then
                recuperaSubMenus(cboMenu.SelectedValue, dataUsuario("cuenta", dataUsuario.CurrentRow.Index).Value)
                codigo = dataUsuario("cuenta", dataUsuario.CurrentRow.Index).Value
                MuestraFoto(codigo)
            End If
            
        End If
    End Sub
    Private Sub cboMenu_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not estaCargando Then
            recuperaSubMenus(cboMenu.SelectedValue, dataUsuario("cuenta", dataUsuario.CurrentRow.Index).Value)
        End If
    End Sub
    Sub recuperaSubMenus(ByVal cod_menu As String, ByVal cuenta As String)
        dsSubMenu.Clear()
        Dim da As New MySqlDataAdapter
        Dim cad, cad1, cad2, cad3 As String
        cad1 = "select menu_sub.cod_smenu,nom_smenu,usuario_smenu.activo"
        cad2 = " from menu_sub left join usuario_smenu on menu_sub.cod_smenu=usuario_smenu.cod_smenu"
        cad3 = " where cod_menu='" & cod_menu & "'" & " and cuenta='" & cuenta & "'"
        cad = cad1 + cad2 + cad3
        Dim com As New MySqlCommand(cad, dbConex)
        da.SelectCommand = com
        da.Fill(dsSubMenu, "subMenu")
        estructuraSubMenus()
    End Sub
    Sub estructuraSubMenus()
        With dataSubMenu
            .DataSource = dsSubMenu.Tables("subMenu")
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns.Item("cod_smenu").Width = 80
            .Columns.Item("cod_smenu").ReadOnly = True
            .Columns.Item("cod_smenu").HeaderText = "Código SubMenu"
            .Columns.Item("cod_smenu").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns.Item("nom_smenu").Width = 232
            .Columns.Item("nom_smenu").ReadOnly = True
            .Columns.Item("nom_smenu").HeaderText = "Opción de Menú"
            .Columns.Item("activo").Width = 60
            .Columns.Item("activo").ReadOnly = False
            .Columns.Item("activo").HeaderText = "Permiso"
            .Columns.Item("activo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With
    End Sub
    Private Sub dataSubMenu_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        If dataSubMenu.CurrentCell.ColumnIndex = dataSubMenu.Columns("activo").Index Then
            'capturamos el menu y usuario seleccionado
            Dim codigo As String = dataSubMenu("cod_smenu", dataSubMenu.CurrentRow.Index).Value
            Dim estado As Integer = dataSubMenu("activo", dataSubMenu.CurrentRow.Index).Value
            Dim cuenta As String = dataUsuario("cuenta", dataUsuario.CurrentRow.Index).Value
            Dim existe As Boolean = existeSubMenu(cuenta, codigo)
            If existe Then
                actualizaSubMenu(cuenta, codigo, estado)
            Else
                'cuando se inserta, por defecto esta desactivado / 0
                insertaSubMenu(cuenta, codigo)
            End If
        End If
    End Sub
    Function existeSubMenu(ByVal cuenta As String, ByVal smenu As String) As Boolean
        Dim com As New MySqlCommand, result As Integer
        Dim cad, cad1, cad2 As String
        cad1 = "select count(cuenta) from usuario_smenu"
        cad2 = " where cuenta='" & cuenta & "'" & " and cod_smenu='" & smenu & "'"
        cad = cad1 + cad2
        com.Connection = dbConex
        com.CommandText = cad
        result = com.ExecuteScalar
        If result > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Sub insertaSubMenu(ByVal cuenta As String, ByVal smenu As String)
        Dim com As New MySqlCommand
        Dim cad, cad1, cad2 As String
        cad1 = "insert into usuario_smenu(cuenta,cod_smenu,activo)"
        cad2 = "values('" & cuenta & "','" & smenu & "'," & 1 & ")"
        cad = cad1 + cad2
        com.Connection = dbConex
        com.CommandText = cad
        com.ExecuteNonQuery()
    End Sub
    Sub actualizaSubMenu(ByVal cuenta As String, ByVal smenu As String, ByVal activo As Integer)
        Dim com As New MySqlCommand
        Dim cad, cad1, cad2 As String
        cad1 = "update usuario_smenu set activo=" & activo
        cad2 = " where cuenta='" & cuenta & "' and cod_smenu='" & smenu & "'"
        cad = cad1 + cad2
        com.Connection = dbConex
        com.CommandText = cad
        com.ExecuteNonQuery()
    End Sub

    Private Sub dataSubMenu_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub cboMenu_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMenu.SelectedIndexChanged
        If Not estaCargando Then
            recuperaSubMenus(cboMenu.SelectedValue, dataUsuario("cuenta", dataUsuario.CurrentRow.Index).Value)
        End If
    End Sub

    Private Sub dataSubMenu_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataSubMenu.CellContentClick

    End Sub

    Private Sub dataSubMenu_CellEndEdit1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataSubMenu.CellEndEdit
        If dataSubMenu.CurrentCell.ColumnIndex = dataSubMenu.Columns("activo").Index Then
            'capturamos el menu y usuario seleccionado
            Dim codigo As String = dataSubMenu("cod_smenu", dataSubMenu.CurrentRow.Index).Value
            Dim estado As Integer = dataSubMenu("activo", dataSubMenu.CurrentRow.Index).Value
            Dim cuenta As String = dataUsuario("cuenta", dataUsuario.CurrentRow.Index).Value
            Dim existe As Boolean = existeSubMenu(cuenta, codigo)
            If existe Then
                actualizaSubMenu(cuenta, codigo, estado)
            Else
                'cuando se inserta, por defecto esta desactivado / 0
                insertaSubMenu(cuenta, codigo)
            End If
        End If
    End Sub
    Sub MuestraFoto(ByVal codigo As String)
        Try
            Dim cad As String, dr As MySqlDataReader, resul As Integer
            cad = "select isnull(foto) as vnul,foto,b_color from usuario where cuenta='" & codigo & "'"
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
                'color = dr("color")
                'If color.Length > 0 Then
                '    txtColor.Text = color.Substring(6, 2) & color.Substring(4, 2) & color.Substring(2, 2)
                'Else
                '    color = ""
                'End If

            End While
            dr.Close()
            dr = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
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

    Private Sub txtClave_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtClave.TextChanged

    End Sub

    Private Sub txtCuenta_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCuenta.TextChanged

    End Sub

    Private Sub dataUsuario_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataUsuario.CellContentClick

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim vImagen As System.Drawing.Image
        vImagen = Clipboard.GetImage
        pb_foto.Image = vImagen
    End Sub

    Private Sub cmdExaminar_Click(sender As Object, e As EventArgs) Handles cmdExaminar.Click
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
End Class
