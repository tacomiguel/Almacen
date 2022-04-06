Imports libreriaClases
Imports MySql.Data.MySqlClient
Imports System.Data
Public Class m_tipo_articulo
    Private daTArticulo As New MySqlDataAdapter
    Private cbTArticulo As MySqlCommandBuilder = New MySqlCommandBuilder(daTArticulo)
    Private dsTArticulo As DataSet
    Private dtTArticulo As DataTable
    Private bsTArticulo As New BindingSource

    Private Sub m_tipo_articulo_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        principal.ma_tarticulo.Enabled = True
    End Sub
    Private Sub m_tipo_articulo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Top = 0
        Me.Left = 0
        'cargamos el dataset
        dsTArticulo = TipoArticulo.dsTipoArticulo
        'cargamos el datatable
        dtTArticulo = dsTArticulo.Tables("tipo_articulo")
        'creamos y trabajamos con el comando a ejecutar
        Dim com As New MySqlCommand("Select cod_tart,nom_tart,esProductoTerminado,esProduccion,esCombo,activo from tipo_articulo", dbConex)
        daTArticulo.SelectCommand = com
        'cargamos los registros en la tabla sub grupo
        daTArticulo.Fill(dsTArticulo, "tipo_articulo")
        'configuramos el bindingSource
        bsTArticulo.DataSource = dsTArticulo
        bsTArticulo.DataMember = "tipo_articulo"
        'configuramos el datagridview
        With Datos
            .DataSource = bsTArticulo
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_tart").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns.Item("cod_tart").HeaderText = "Código"
            .Columns.Item("cod_tart").Resizable = DataGridViewTriState.False
            .Columns.Item("cod_tart").Width = "50"
            .Columns.Item("nom_tart").HeaderText = "Tipo de Artículo"
            .Columns.Item("nom_tart").Resizable = DataGridViewTriState.False
            .Columns.Item("nom_tart").Width = "180"
            .Columns.Item("esProduccion").HeaderText = "Para Producción"
            .Columns.Item("esProduccion").Resizable = DataGridViewTriState.False
            .Columns.Item("esProduccion").Width = "75"
            .Columns.Item("esCombo").HeaderText = "Para Combo"
            .Columns.Item("esCombo").Resizable = DataGridViewTriState.False
            .Columns.Item("esCombo").Width = "60"
            .Columns.Item("activo").HeaderText = "Activo"
            .Columns.Item("activo").Resizable = DataGridViewTriState.False
            .Columns.Item("activo").Width = "50"
        End With
        'relacionamos los cuadros de texto con el bindingSource
        txtCodigo.DataBindings.Add("text", bsTArticulo, "cod_tart")
        txtTipo.DataBindings.Add("text", bsTArticulo, "nom_tart")
        chkProduccion.DataBindings.Add("checked", bsTArticulo, "esProduccion")
        chkProTerminado.DataBindings.Add("checked", bsTArticulo, "esProductoTerminado")
        chkCombo.DataBindings.Add("checked", bsTArticulo, "esCombo")
        chkActivo.DataBindings.Add("checked", bsTArticulo, "activo")
    End Sub
    Private Sub cmdAñadir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAñadir.Click
        habilitaDetalle()
        deshabilitacabecera()
        dsTArticulo.Tables("tipo_articulo").Columns("esProductoTerminado").DefaultValue = False
        dsTArticulo.Tables("tipo_articulo").Columns("esProduccion").DefaultValue = False
        dsTArticulo.Tables("tipo_articulo").Columns("esCombo").DefaultValue = False
        dsTArticulo.Tables("tipo_articulo").Columns("activo").DefaultValue = True
        bsTArticulo.AddNew()
        datos.DataSource = bsTArticulo
        modoGrabar()
        txtCodigo.Refresh()
        txtTipo.Refresh()
        chkProduccion.Refresh()
        chkActivo.Refresh()
        txtCodigo.Focus()
    End Sub
    Private Sub cmdGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGrabar.Click
        Try
            If validaIngreso() Then
                bsTArticulo.EndEdit()
                daTArticulo.Update(dsTArticulo, "tipo_articulo")
                datos.Refresh()
                deshabilitaDetalle()
                habilitaCabecera()
                modoAñadir()
                datos.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            bsTArticulo.CancelEdit()
            datos.Refresh()
            deshabilitaDetalle()
            habilitaCabecera()
            modoAñadir()
            datos.Focus()
        End Try
    End Sub
    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        bsTArticulo.CancelEdit()
        datos.Refresh()
        deshabilitaDetalle()
        habilitaCabecera()
        modoAñadir()
        If datos.Rows.Count > 0 Then
            datos.CurrentCell = datos(1, 0)
        End If
        datos.Focus()
    End Sub
    Private Sub cmdEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEliminar.Click
        If bsTArticulo.Count > 0 Then
            Dim mTipoArticulo As New TipoArticulo, exist, rpta As Integer
            exist = mTipoArticulo.existeEnCatalogo(Trim(txtCodigo.Text))
            If exist = 0 Then
                rpta = MessageBox.Show("¿Esta seguro de Eliminar el ITEM Seleccionado...", "CEFE", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                If rpta = 6 Then
                    If bsTArticulo.Count > 0 Then
                        bsTArticulo.RemoveCurrent()
                        daTArticulo.Update(dsTArticulo, "tipo_articulo")
                        datos.Refresh()
                    End If
                End If
            Else
                MessageBox.Show("El Registro Tiene Datos Relacionados..." + Chr(13) + "!NO Es posible eliminarlo¡", "CEFE", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button2)
            End If
        End If
    End Sub
    Private Sub cmdEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEditar.Click
        If bsTArticulo.Count > 0 Then
            habilitaDetalle()
            deshabilitacabecera()
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
                MessageBox.Show("Ingrese el Tipo de Artículo...", "CEFE", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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
    Private Sub txtDescripcion_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTipo.GotFocus
        general.ingresaTexto(Me.txtTipo)
    End Sub
    Private Sub txtDescripcion_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTipo.LostFocus
        general.saleTexto(Me.txtTipo)
    End Sub
    Sub habilitaDetalle()
        lblCodigo.ForeColor = Color.Maroon
        lblTipo.ForeColor = Color.Maroon
        txtCodigo.BackColor = Color.White
        txtCodigo.ReadOnly = False
        txtTipo.BackColor = Color.White
        txtTipo.ReadOnly = False
        chkProTerminado.Enabled = True
        chkProduccion.Enabled = True
        chkCombo.Enabled = True
        chkActivo.Enabled = True
    End Sub
    Sub deshabilitaDetalle()
        lblCodigo.ForeColor = Color.Black
        lblTipo.ForeColor = Color.Black
        txtCodigo.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        txtCodigo.ReadOnly = True
        txtTipo.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        txtTipo.ReadOnly = True
        chkProduccion.Enabled = False
        chkProTerminado.Enabled = False
        chkCombo.Enabled = False
        chkActivo.Enabled = False
    End Sub
    Sub habilitaCabecera()
        datos.Enabled = True
    End Sub
    Sub deshabilitacabecera()
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

    End Sub
End Class
