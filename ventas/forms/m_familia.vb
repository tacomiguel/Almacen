Imports libreriaClases
Imports MySql.Data.MySqlClient
Imports System.Data
Public Class m_familia
    Private daFamilia As New MySqlDataAdapter
    Private cbFamilia As MySqlCommandBuilder = New MySqlCommandBuilder(daFamilia)
    Private dsFamilia As DataSet
    Private dtFamilia As DataTable
    Private bsFamilia As New BindingSource
    Private Sub m_familia_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        principal.ma_familia.Enabled = True
    End Sub
    Private Sub m_familia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Top = 0
        Me.Left = 0
        'cargamos el dataset
        dsFamilia = Familia.dsFamilia
        'cargamos el datatable
        dtFamilia = dsFamilia.Tables("familia")
        'creamos y trabajamos con el comando a ejecutar
        Dim com As New MySqlCommand("Select cod_familia,nom_familia,activo from familia", dbConex)
        daFamilia.SelectCommand = com
        'cargamos los registros en la tabla sub grupo
        daFamilia.Fill(dsFamilia, "familia")
        'configuramos el bindingSource
        bsFamilia.DataSource = dsFamilia
        bsFamilia.DataMember = "familia"
        'configuramos el datagridview
        With datos
            .DataSource = bsFamilia
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_familia").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns.Item("cod_familia").HeaderText = "Código"
            .Columns.Item("cod_familia").Resizable = DataGridViewTriState.False
            .Columns.Item("cod_familia").Width = "60"
            .Columns.Item("nom_familia").HeaderText = "Familia"
            .Columns.Item("nom_familia").Resizable = DataGridViewTriState.False
            .Columns.Item("nom_familia").Width = "245"
            .Columns.Item("activo").HeaderText = "Activo"
            .Columns.Item("activo").Resizable = DataGridViewTriState.False
            .Columns.Item("activo").Width = "50"
        End With
        'relacionamos los cuadros de texto con el bindingSource
        txtCodigo.DataBindings.Add("text", bsFamilia, "cod_familia")
        txtFamilia.DataBindings.Add("text", bsFamilia, "nom_familia")
        chkActivo.DataBindings.Add("checked", bsFamilia, "activo")
    End Sub
    Private Sub cmdAñadir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAñadir.Click
        habilitaDetalle()
        deshabilitaCabecera()
        dsFamilia.Tables("familia").Columns("activo").DefaultValue = True
        bsFamilia.AddNew()
        datos.DataSource = bsFamilia
        modoGrabar()
        txtCodigo.Refresh()
        txtFamilia.Refresh()
        chkActivo.Refresh()
        txtCodigo.Focus()
    End Sub
    Private Sub cmdGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGrabar.Click
        Try
            If validaIngreso() Then
                bsFamilia.EndEdit()
                daFamilia.Update(dsFamilia, "familia")
                datos.Refresh()
                deshabilitaDetalle()
                habilitaCabecera()
                modoAñadir()
                datos.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            bsFamilia.CancelEdit()
            datos.Refresh()
            deshabilitaDetalle()
            habilitaCabecera()
            modoAñadir()
            datos.Focus()
        End Try
    End Sub
    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        bsFamilia.CancelEdit()
        datos.Refresh()
        deshabilitaDetalle()
        habilitaCabecera()
        modoAñadir()
        datos.Focus()
        If datos.Rows.Count > 0 Then
            datos.CurrentCell = datos(1, 0)
        End If
    End Sub
    Private Sub cmdEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEliminar.Click
        If bsFamilia.Count > 0 Then
            Dim mFamilia As New Familia, exist As Boolean, rpta As Integer
            exist = mFamilia.existeEnGrupo(Trim(txtCodigo.Text))
            If Not exist Then
                rpta = MessageBox.Show("¿Esta seguro de Eliminar el ITEM Seleccionado...", "Almacen", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                If rpta = 6 Then
                    If bsFamilia.Count > 0 Then
                        bsFamilia.RemoveCurrent()
                        daFamilia.Update(dsFamilia, "familia")
                        datos.Refresh()
                    End If
                End If
            Else
                MessageBox.Show("El Registro Tiene Datos Relacionados..." + Chr(13) + "!NO Es posible eliminarlo¡", "Almacen", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button2)
            End If
        End If
    End Sub
    Function validaIngreso()
        Dim validado As Boolean = False
        If Len(txtCodigo.Text) > 0 Then
            If Len(txtFamilia.Text) > 0 Then
                validado = True
            Else
                MessageBox.Show("Ingrese la Familia de Productos...", "Almacen", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtFamilia.Focus()
            End If
        Else
            MessageBox.Show("Ingrese el Código...", "Almacen", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCodigo.Focus()
        End If
        Return validado
    End Function
    Private Sub cmdEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEditar.Click
        If bsFamilia.Count > 0 Then
            habilitaDetalle()
            deshabilitaCabecera()
            modoGrabar()
            txtCodigo.Focus()
        End If
    End Sub
    Private Sub txtCodigo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.GotFocus
        general.ingresaTexto(txtCodigo)
    End Sub
    Private Sub txtCodigo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.LostFocus
        If Len(txtCodigo.Text) > 0 Then
            txtCodigo.Text = Microsoft.VisualBasic.Right("000" + Trim(txtCodigo.Text), 3)
        End If
        general.saleTexto(txtCodigo)
    End Sub
    Private Sub txtfamilia_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFamilia.GotFocus
        general.ingresaTexto(txtFamilia)
    End Sub
    Private Sub txtfamilia_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFamilia.LostFocus
        general.saleTexto(txtFamilia)
    End Sub
    Sub habilitaDetalle()
        lblCodigo.ForeColor = Color.Maroon
        lblFamilia.ForeColor = Color.Maroon
        txtCodigo.BackColor = Color.White
        txtCodigo.ReadOnly = False
        txtFamilia.BackColor = Color.White
        txtFamilia.ReadOnly = False
        chkActivo.Enabled = True
    End Sub
    Sub deshabilitaDetalle()
        lblCodigo.ForeColor = Color.Black
        lblFamilia.ForeColor = Color.Black
        txtCodigo.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        txtCodigo.ReadOnly = True
        txtFamilia.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        txtFamilia.ReadOnly = True
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
End Class
