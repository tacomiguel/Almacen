Imports libreriaClases
Imports MySql.Data.MySqlClient
Imports System.Data
Public Class m_tipo_proveedor
    Private daTipoProveedor As New MySqlDataAdapter
    Private cbTipoProveedor As MySqlCommandBuilder = New MySqlCommandBuilder(daTipoProveedor)
    Private dsTipoProveedor As DataSet
    Private dtTipoProveedor As DataTable
    Private bsTipoProveedor As New BindingSource
    Private Sub m_subgrupo_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        principal.ma_tproveedor.Enabled = True
    End Sub
    Private Sub m_tipo_proveedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Top = 0
        Me.Left = 0
        'cargamos el dataset
        dsTipoProveedor = TipoProveedor.dsTipoProveedor
        'cargamos el datatable
        dtTipoProveedor = dsTipoProveedor.Tables("tipo_proveedor")
        'creamos y trabajamos con el comando a ejecutar
        Dim com As New MySqlCommand("Select cod_tipo,nom_tipo,activo from tipo_proveedor", dbconex)
        daTipoProveedor.SelectCommand = com
        'cargamos los registros en la tabla sub grupo
        daTipoProveedor.Fill(dsTipoProveedor, "tipo_proveedor")
        'configuramos el bindingSource
        bsTipoProveedor.DataSource = dsTipoProveedor
        bsTipoProveedor.DataMember = "tipo_proveedor"
        'configuramos el datagridview
        With datos
            .DataSource = bsTipoProveedor
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_tipo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns.Item("cod_tipo").HeaderText = "Código"
            .Columns.Item("cod_tipo").Resizable = DataGridViewTriState.False
            .Columns.Item("cod_tipo").Width = "60"
            .Columns.Item("nom_tipo").HeaderText = "Tipo de Proveedor"
            .Columns.Item("nom_tipo").Resizable = DataGridViewTriState.False
            .Columns.Item("nom_tipo").Width = "245"
            .Columns.Item("activo").HeaderText = "Activo"
            .Columns.Item("activo").Resizable = DataGridViewTriState.False
            .Columns.Item("activo").Width = "50"
        End With
        'relacionamos los cuadros de texto con el bindingSource
        txtCodigo.DataBindings.Add("text", bsTipoProveedor, "cod_tipo")
        txtTipo.DataBindings.Add("text", bsTipoProveedor, "nom_tipo")
        chkActivo.DataBindings.Add("checked", bsTipoProveedor, "activo")
    End Sub
    Private Sub cmdAñadir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAñadir.Click
        habilitaDetalle()
        deshabilitaCabecera()
        dsTipoProveedor.Tables("tipo_proveedor").Columns("activo").DefaultValue = True
        bsTipoProveedor.AddNew()
        datos.DataSource = bsTipoProveedor
        modoGrabar()
        txtCodigo.Refresh()
        txtTipo.Refresh()
        chkActivo.Refresh()
        txtCodigo.Focus()
    End Sub
    Private Sub cmdGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGrabar.Click
        Try
            If validaIngreso() Then
                bsTipoProveedor.EndEdit()
                daTipoProveedor.Update(dsTipoProveedor, "tipo_proveedor")
                datos.Refresh()
                deshabilitaDetalle()
                habilitaCabecera()
                modoAñadir()
                datos.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            bsTipoProveedor.CancelEdit()
            datos.Refresh()
            deshabilitaDetalle()
            habilitaCabecera()
            modoAñadir()
            datos.Focus()
        End Try
    End Sub
    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        bsTipoProveedor.CancelEdit()
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
        If bsTipoProveedor.Count > 0 Then
            Dim mTipoProveedor As New TipoProveedor, exist As Boolean
            exist = mTipoProveedor.existeEnProveedores(Trim(txtCodigo.Text))
            Dim rpta As Integer
            If Not exist Then
                rpta = MessageBox.Show("¿Esta seguro de Eliminar el ITEM Seleccionado...", "CEFE", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                If rpta = 6 Then
                    If bsTipoProveedor.Count > 0 Then
                        bsTipoProveedor.RemoveCurrent()
                        daTipoProveedor.Update(dsTipoProveedor, "tipo_proveedor")
                        datos.Refresh()
                    End If
                End If
            Else
                MessageBox.Show("El Registro tiene Información Relacionada" + Chr(13) + "!NO es posible eliminarlo...¡", "CEFE", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        End If
    End Sub
    Private Sub cmdEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEditar.Click
        If bsTipoProveedor.Count > 0 Then
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
                MessageBox.Show("Ingrese el Tipo de Proveedor...", "CEFE", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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
