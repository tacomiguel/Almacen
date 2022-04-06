Imports MySql.Data.MySqlClient
Imports System.Data
Imports libreriaClases
Public Class m_motivo
    Private daMotivo As New MySqlDataAdapter
    Private cbMotivo As MySqlCommandBuilder = New MySqlCommandBuilder(daMotivo)
    Private dsMotivo As DataSet
    Private dtMotivo As DataTable
    Private bsMotivo As New BindingSource

    Private Sub m_motivo_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        principal.ma_motivo.Enabled = True
    End Sub
    Private Sub m_motivo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Top = 0
        Me.Left = 0
        'cargamos el dataset
        dsMotivo = MotivoTraslado.dsMotivo
        'cargamos el datatable
        dtMotivo = dsMotivo.Tables("motivo")
        'creamos y trabajamos con el comando a ejecutar
        Dim com As New MySqlCommand("Select cod_mot,nom_mot,activo from motivo_tras order by nom_mot", dbconex)
        daMotivo.SelectCommand = com
        'cargamos los registros en la tabla sub grupo
        daMotivo.Fill(dsMotivo, "motivo")
        'configuramos el bindingSource
        bsMotivo.DataSource = dsMotivo
        bsMotivo.DataMember = "motivo"
        'configuramos el datagridview
        With datos
            .DataSource = bsMotivo
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_mot").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns.Item("cod_mot").HeaderText = "Código"
            .Columns.Item("cod_mot").Resizable = DataGridViewTriState.False
            .Columns.Item("cod_mot").Width = "50"
            .Columns.Item("nom_mot").HeaderText = "Motivo del Traslado"
            .Columns.Item("nom_mot").Resizable = DataGridViewTriState.False
            .Columns.Item("nom_mot").Width = "285"
            .Columns.Item("activo").HeaderText = "Activo"
            .Columns.Item("activo").Resizable = DataGridViewTriState.False
            .Columns.Item("activo").Width = "50"
        End With
        'relacionamos los cuadros de texto con el bindingSource
        txtCodigo.DataBindings.Add("text", bsMotivo, "cod_mot")
        txtMotivo.DataBindings.Add("text", bsMotivo, "nom_mot")
        chkActivo.DataBindings.Add("checked", bsMotivo, "activo")
    End Sub
    Private Sub txtCodigo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.GotFocus
        general.ingresaTexto(txtCodigo)
    End Sub
    Private Sub txtCodigo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.LostFocus
        general.saleTexto(txtCodigo)
    End Sub
    Private Sub txtConductor_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMotivo.GotFocus
        general.ingresaTexto(txtMotivo)
    End Sub
    Private Sub txtConductor_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMotivo.LostFocus
        general.saleTexto(txtMotivo)
    End Sub
    Sub habilitaDetalle()
        txtCodigo.BackColor = Color.White
        txtCodigo.ReadOnly = False
        txtMotivo.BackColor = Color.White
        txtMotivo.ReadOnly = False
        chkActivo.Enabled = True
    End Sub
    Sub deshabilitaDetalle()
        txtCodigo.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        txtCodigo.ReadOnly = True
        txtMotivo.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        txtMotivo.ReadOnly = True
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
        dsMotivo.Tables("motivo").Columns("activo").DefaultValue = False
        bsMotivo.AddNew()
        datos.DataSource = bsMotivo
        modoGrabar()
        txtCodigo.Refresh()
        txtMotivo.Refresh()
        chkActivo.Refresh()
        txtCodigo.Focus()
    End Sub
    Private Sub cmdGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGrabar.Click
        Try
            bsMotivo.EndEdit()
            daMotivo.Update(dsMotivo, "motivo")
            datos.Refresh()
            deshabilitaDetalle()
            modoAñadir()
            datos.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            bsMotivo.CancelEdit()
            datos.Refresh()
            deshabilitaDetalle()
            modoAñadir()
            datos.Focus()
        End Try
    End Sub
    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        bsMotivo.CancelEdit()
        datos.Refresh()
        deshabilitaDetalle()
        modoAñadir()
        datos.Focus()
        If datos.Rows.Count > 0 Then
            datos.CurrentCell = datos(1, 0)
        End If
    End Sub
    Private Sub cmdEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEliminar.Click
        If bsMotivo.Count > 0 Then
            Dim rpta As Integer
            rpta = MessageBox.Show("Esta Seguro de Eliminar el ITEM Seleccionado...", "CEFE", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            If rpta = 6 Then
                If bsMotivo.Count > 0 Then
                    bsMotivo.RemoveCurrent()
                    daMotivo.Update(dsMotivo, "motivo")
                End If
            End If
        End If
    End Sub
    Private Sub cmdEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEditar.Click
        If bsMotivo.Count > 0 Then
            habilitaDetalle()
            modoGrabar()
            txtCodigo.Focus()
        End If
    End Sub
    Private Sub cmdCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCerrar.Click
        Me.Close()
    End Sub
End Class
