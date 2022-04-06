Imports libreriaClases
Imports MySql.Data.MySqlClient
Imports System.Data
Public Class m_grupo
    Private dbconex As MySqlConnection = Conexion.obtenerConexion
    Private daGrupo As New MySqlDataAdapter
    Private cbGrupo As MySqlCommandBuilder = New MySqlCommandBuilder(daGrupo)
    Private dsGrupo As DataSet
    Private dtGrupo As DataTable
    Private bsGrupo As New BindingSource
    Private Sub m_grupo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'cargamos el dataset
        dsGrupo = grupo.dsGrupo()
        'cargamos el datatable
        dtGrupo = dsGrupo.Tables("grupo")
        'creamos y trabajamos con el comando a ejecutar
        Dim com As New MySqlCommand("Select cod_grupo,nom_grupo,activo from grupo", dbconex)
        daGrupo.SelectCommand = com
        'cargamos los registros en la tabla grupo
        daGrupo.Fill(dsGrupo, "grupo")
        'configuramos el bindingSource
        bsGrupo.DataSource = dsGrupo
        bsGrupo.DataMember = "grupo"
        'configuramos el datagridview
        With data
            .DataSource = bsGrupo
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns.Item(0).HeaderText = "Código"
            .Columns.Item(0).Resizable = DataGridViewTriState.False
            .Columns.Item(0).Width = "50"
            .Columns.Item(1).HeaderText = "Nombre del Grupo"
            .Columns.Item(1).Resizable = DataGridViewTriState.False
            .Columns.Item(1).Width = "285"
            .Columns.Item(2).HeaderText = "Activo"
            .Columns.Item(2).Resizable = DataGridViewTriState.False
            .Columns.Item(2).Width = "50"
        End With
        'relacionamos los cuadros de texto con el bindingSource
        txtCodigo.DataBindings.Add("text", bsGrupo, "cod_grupo")
        txtGrupo.DataBindings.Add("text", bsGrupo, "nom_grupo")
        chkActivo.DataBindings.Add("checked", bsGrupo, "activo")
    End Sub
    Private Sub cmdAñadir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAñadir.Click
        habilitaDetalle()
        dsGrupo.Tables("grupo").Columns("activo").DefaultValue = False
        bsGrupo.AddNew()
        data.DataSource = bsGrupo
        modoGrabar()
        txtCodigo.Refresh()
        txtGrupo.Refresh()
        chkActivo.Refresh()
        txtCodigo.Focus()
    End Sub
    Private Sub cmdGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGrabar.Click
        Try
            bsGrupo.EndEdit()
            daGrupo.Update(dsGrupo, "grupo")
            data.Refresh()
            deshabilitaDetalle()
            modoAñadir()
            data.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        bsGrupo.CancelEdit()
        data.Refresh()
        deshabilitaDetalle()
        modoAñadir()
        data.Focus()
    End Sub
    Private Sub cmdEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEditar.Click
        habilitaDetalle()
        modoGrabar()
        txtCodigo.Focus()
    End Sub
    Private Sub cmdEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEliminar.Click
        If bsGrupo.Count > 0 Then
            bsGrupo.RemoveCurrent()
            daGrupo.Update(dsGrupo, "grupo")
        End If
    End Sub
    Private Sub txtCodigo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.GotFocus
        general.ingresaTexto(txtCodigo)
    End Sub
    Private Sub txtCodigo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.LostFocus
        general.saleTexto(txtCodigo)
    End Sub
    Private Sub txtGrupo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtGrupo.GotFocus
        general.ingresaTexto(txtGrupo)
    End Sub
    Private Sub txtGrupo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtGrupo.LostFocus
        general.saleTexto(txtGrupo)
    End Sub
    Sub habilitaDetalle()
        grupoDetalle.Enabled = True
    End Sub
    Sub deshabilitaDetalle()
        grupoDetalle.Enabled = False
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

    Private Sub data_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles data.CellContentClick

    End Sub
End Class
