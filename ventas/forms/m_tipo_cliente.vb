Imports libreriaClases
Imports MySql.Data.MySqlClient
Imports System.Data
Public Class m_tipo_cliente
    Private daTipoCliente As New MySqlDataAdapter
    Private cbTipoCliente As MySqlCommandBuilder = New MySqlCommandBuilder(daTipoCliente)
    Private dsTipoCliente As DataSet
    Private dtTipoCliente As DataTable
    Private bsTipoCliente As New BindingSource
    Private Sub m_subgrupo_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        principal.ma_tcliente.Enabled = True
    End Sub
    Private Sub m_tipo_cliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Top = 0
        Me.Left = 0
        'cargamos el dataset
        dsTipoCliente = TipoCliente.dsTipoCliente
        'cargamos el datatable
        dtTipoCliente = dsTipoCliente.Tables("tipo_cliente")
        'creamos y trabajamos con el comando a ejecutar
        Dim com As New MySqlCommand("Select cod_tipo,nom_tipo,activo from tipo_cliente", dbconex)
        daTipoCliente.SelectCommand = com
        'cargamos los registros en la tabla sub grupo
        daTipoCliente.Fill(dsTipoCliente, "tipo_cliente")
        'configuramos el bindingSource
        bsTipoCliente.DataSource = dsTipoCliente
        bsTipoCliente.DataMember = "tipo_cliente"
        'configuramos el datagridview
        With datos
            .DataSource = bsTipoCliente
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_tipo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns.Item("cod_tipo").HeaderText = "Código"
            .Columns.Item("cod_tipo").Resizable = DataGridViewTriState.False
            .Columns.Item("cod_tipo").Width = "60"
            .Columns.Item("nom_tipo").HeaderText = "Tipo de Cliente"
            .Columns.Item("nom_tipo").Resizable = DataGridViewTriState.False
            .Columns.Item("nom_tipo").Width = "245"
            .Columns.Item("activo").HeaderText = "Activo"
            .Columns.Item("activo").Resizable = DataGridViewTriState.False
            .Columns.Item("activo").Width = "50"
        End With
        'relacionamos los cuadros de texto con el bindingSource
        txtCodigo.DataBindings.Add("text", bsTipoCliente, "cod_tipo")
        txtTipo.DataBindings.Add("text", bsTipoCliente, "nom_tipo")
        chkActivo.DataBindings.Add("checked", bsTipoCliente, "activo")
    End Sub
    Private Sub cmdAñadir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAñadir.Click
        habilitaDetalle()
        deshabilitaCabecera()
        dsTipoCliente.Tables("tipo_cliente").Columns("activo").DefaultValue = True
        bsTipoCliente.AddNew()
        datos.DataSource = bsTipoCliente
        modoGrabar()
        txtCodigo.Refresh()
        txtTipo.Refresh()
        chkActivo.Refresh()
        txtCodigo.Focus()
    End Sub
    Private Sub cmdGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGrabar.Click
        Try
            If validaIngreso() Then
                bsTipoCliente.EndEdit()
                daTipoCliente.Update(dsTipoCliente, "tipo_cliente")
                datos.Refresh()
                deshabilitaDetalle()
                habilitaCabecera()
                modoAñadir()
                datos.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            bsTipoCliente.CancelEdit()
            datos.Refresh()
            deshabilitaDetalle()
            habilitaCabecera()
            modoAñadir()
            datos.Focus()
        End Try
    End Sub
    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        bsTipoCliente.CancelEdit()
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
        If bsTipoCliente.Count > 0 Then
            Dim mTipoCliente As New TipoCliente, exist As Boolean, rpta As Integer
            exist = mTipoCliente.existeEnClientes(Trim(txtCodigo.Text))
            If Not exist Then
                rpta = MessageBox.Show("¿Esta seguro de Eliminar el ITEM Seleccionado...", "CEFE", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                If rpta = 6 Then
                    If bsTipoCliente.Count > 0 Then
                        bsTipoCliente.RemoveCurrent()
                        daTipoCliente.Update(dsTipoCliente, "tipo_cliente")
                        datos.Refresh()
                    End If
                End If
            Else
                MessageBox.Show("El Registro tiene Información Relacionada" + Chr(13) + "!NO es posible eliminarlo...¡", "CEFE", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        End If
    End Sub
    Private Sub cmdEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEditar.Click
        If bsTipoCliente.Count > 0 Then
            habilitaDetalle()
            deshabilitaCabecera()
            modoGrabar()
            txtCodigo.Focus()
        End If
    End Sub
    Function validaIngreso()
        Dim validado As Boolean = False
        If Len(txtCodigo.Text) > 0 Then
            If Len(txtTipo.Text) > 0 Then
                validado = True
            Else
                MessageBox.Show("Ingrese el Tipo de Cliente...", "CEFE", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtTipo.Focus()
            End If
        Else
            MessageBox.Show("Ingrese el Código...", "CEFE", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCodigo.Focus()
        End If
        Return validado
    End Function
    Private Sub txtCodigo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.GotFocus
        general.ingresaTexto(txtCodigo)
    End Sub
    Private Sub txtCodigo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.LostFocus
        If Len(txtCodigo.Text) > 0 Then
            txtCodigo.Text = Microsoft.VisualBasic.Right("00" + Trim(txtCodigo.Text), 2)
        End If
        general.saleTexto(txtCodigo)
    End Sub
    Private Sub txtTipo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTipo.GotFocus
        general.ingresaTexto(txtTipo)
    End Sub
    Private Sub txtTipo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTipo.LostFocus
        general.saleTexto(txtTipo)
    End Sub
    Sub habilitaDetalle()
        lblCodigo.ForeColor = Color.Maroon
        lblTipo.ForeColor = Color.Maroon
        txtCodigo.BackColor = Color.White
        txtCodigo.ReadOnly = False
        txtTipo.BackColor = Color.White
        txtTipo.ReadOnly = False
        chkActivo.Enabled = True
    End Sub
    Sub deshabilitaDetalle()
        lblCodigo.ForeColor = Color.Black
        lblTipo.ForeColor = Color.Black
        txtCodigo.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        txtCodigo.ReadOnly = True
        txtTipo.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        txtTipo.ReadOnly = True
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
