Imports MySql.Data.MySqlClient
Imports System.Data
Imports libreriaClases
Public Class m_vendedor
    Private daVendedor As New MySqlDataAdapter
    Private cbVendedor As MySqlCommandBuilder = New MySqlCommandBuilder(daVendedor)
    Private dsVendedor As DataSet
    Private dtVendedor As DataTable
    Private bsVendedor As New BindingSource
    Private dstipPerfil As New DataSet
    Private dttipPerfil As New DataTable("tipPerfil")

    Private Sub m_vendedor_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        principal.ma_vendedor.Enabled = True
    End Sub
    Private Sub m_vendedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Top = 0
        Me.Left = 0
        Dim cod As String = "00000000"
        'cargamos el dataset
        dsVendedor = Vendedor.dsVendedor
        'cargamos el datatable
        dtVendedor = dsVendedor.Tables("vendedor")
        'creamos y trabajamos con el comando a ejecutar
        Dim com As New MySqlCommand("Select cod_vend,nom_vend,activo,perfil from vendedor where cod_vend <>'" & cod & "'" & " order by nom_vend", dbConex)
        daVendedor.SelectCommand = com
        'cargamos los registros en la tabla sub grupo
        daVendedor.Fill(dsVendedor, "vendedor")
        'configuramos el bindingSource
        bsVendedor.DataSource = dsVendedor
        bsVendedor.DataMember = "vendedor"
        'dataset tipVendedor
        dstipPerfil.Tables.Add(dttipPerfil)
        Dim datipPerfil As New MySqlDataAdapter
        Dim cadena As String = "Select cod_recurso,dsc_recurso from tipo_recurso where activo and cod_tabla='tip_perfil'"
        Dim comTipsalon As New MySqlCommand(cadena, dbConex)
        datipPerfil.SelectCommand = comTipsalon
        datipPerfil.Fill(dstipPerfil, "tipPerfil")
        With cboPerfil
            .DataSource = dstipPerfil.Tables("tipPerfil")
            .DisplayMember = dstipPerfil.Tables("tipPerfil").Columns("dsc_recurso").ToString
            .ValueMember = dstipPerfil.Tables("tipPerfil").Columns("cod_recurso").ToString
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.ListItems
            .SelectedIndex = -1
        End With

        'configuramos el datagridview
        With datos
            .DataSource = bsVendedor
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_vend").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns.Item("cod_vend").HeaderText = "Código"
            .Columns.Item("cod_vend").Resizable = DataGridViewTriState.False
            .Columns.Item("cod_vend").Width = "80"
            .Columns.Item("nom_vend").HeaderText = "Nombres del Vendedor"
            .Columns.Item("nom_vend").Resizable = DataGridViewTriState.False
            .Columns.Item("nom_vend").Width = "255"
            .Columns.Item("activo").HeaderText = "Activo"
            .Columns.Item("activo").Resizable = DataGridViewTriState.False
            .Columns.Item("activo").Width = "50"
        End With
        'relacionamos los cuadros de texto con el bindingSource
        txtCodigo.DataBindings.Add("text", bsVendedor, "cod_vend")
        txtVendedor.DataBindings.Add("text", bsVendedor, "nom_vend")
        chkActivo.DataBindings.Add("checked", bsVendedor, "activo")
        cboPerfil.DataBindings.Add("selectedValue", bsVendedor, "perfil")
    End Sub
    Private Sub cmdAñadir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAñadir.Click
        habilitaDetalle()
        dsVendedor.Tables("vendedor").Columns("activo").DefaultValue = True
        bsVendedor.AddNew()
        datos.DataSource = bsVendedor
        modoGrabar()
        txtCodigo.Refresh()
        txtVendedor.Refresh()
        chkActivo.Refresh()
        txtCodigo.Focus()
    End Sub
    Private Sub cmdGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGrabar.Click
        Try
            If validaIngreso() Then
                bsVendedor.EndEdit()
                daVendedor.Update(dsVendedor, "vendedor")
                datos.Refresh()
                deshabilitaDetalle()
                modoAñadir()
                datos.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            bsVendedor.CancelEdit()
            datos.Refresh()
            deshabilitaDetalle()
            modoAñadir()
            datos.Focus()
        End Try
    End Sub
    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        bsVendedor.CancelEdit()
        datos.Refresh()
        deshabilitaDetalle()
        modoAñadir()
        If datos.Rows.Count > 0 Then
            datos.CurrentCell = datos(1, 0)
        End If
        datos.Focus()
    End Sub
    Private Sub cmdEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEliminar.Click
        If bsVendedor.Count > 0 Then
            Dim mVendedor As New Vendedor
            Dim existe As Boolean = mVendedor.existeEnSalidas(txtCodigo.Text)
            If Not existe Then
                Dim existe2 As Boolean = mVendedor.existeEnSalidasHistorial(txtCodigo.Text)
                If Not existe2 Then
                    Dim rpta As Integer
                    rpta = MessageBox.Show("Esta Seguro de Eliminar el ITEM Seleccionado...", "CEFE", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                    If rpta = 6 Then
                        If bsVendedor.Count > 0 Then
                            bsVendedor.RemoveCurrent()
                            daVendedor.Update(dsVendedor, "vendedor")
                        End If
                    End If
                Else
                    MessageBox.Show("El Registro Tiene Datos Relacionados en el Historial..." + Chr(13) + "!NO Es posible eliminarlo¡", "CEFE", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button2)
                End If
            Else
                MessageBox.Show("El Registro Tiene Datos Relacionados..." + Chr(13) + "!NO Es posible eliminarlo¡", "CEFE", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button2)
            End If
        End If
    End Sub
    Private Sub cmdEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEditar.Click
        If bsVendedor.Count > 0 Then
            habilitaDetalle()
            modoGrabar()
            txtCodigo.Focus()
        End If
    End Sub
    Function validaIngreso()
        Dim validado As Boolean = False
        If Len(txtCodigo.Text) > 0 Then
            If Len(txtVendedor.Text) > 0 Then
                validado = True
            Else
                MessageBox.Show("Ingrese el vendedor...", "ALMACEN", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtVendedor.Focus()
            End If
        Else
            MessageBox.Show("Ingrese el Código...", "ALMACEN", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCodigo.Focus()
        End If
        Return validado
    End Function
    Private Sub txtCodigo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.GotFocus
        general.ingresaTexto(txtCodigo)
    End Sub
    Private Sub txtCodigo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.LostFocus
        general.saleTexto(txtCodigo)
        'If Len(txtCodigo.Text) > 0 Then
        '    txtCodigo.Text = Microsoft.VisualBasic.Right("00000000" & txtCodigo.Text, 8)
        'End If
    End Sub
    Private Sub txtVendedor_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtVendedor.GotFocus
        general.ingresaTexto(txtVendedor)
    End Sub
    Private Sub txtVendedor_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtVendedor.LostFocus
        general.saleTexto(txtVendedor)
    End Sub
    Sub habilitaDetalle()
        lblCodigo.ForeColor = Color.Maroon
        lblVendedor.ForeColor = Color.Maroon
        txtCodigo.BackColor = Color.White
        txtCodigo.ReadOnly = False
        txtVendedor.BackColor = Color.White
        txtVendedor.ReadOnly = False
        chkActivo.Enabled = True
        cboPerfil.Enabled = True
    End Sub
    Sub deshabilitaDetalle()
        lblCodigo.ForeColor = Color.Black
        lblVendedor.ForeColor = Color.Black
        txtCodigo.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        txtCodigo.ReadOnly = True
        txtVendedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        txtVendedor.ReadOnly = True
        chkActivo.Enabled = False
        cboPerfil.Enabled = False
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

    Private Sub txtCodigo_TextChanged(sender As Object, e As EventArgs) Handles txtCodigo.TextChanged

    End Sub
End Class
