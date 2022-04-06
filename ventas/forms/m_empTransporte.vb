Imports MySql.Data.MySqlClient
Imports System.Data
Imports libreriaClases
Public Class m_empTransporte
    Private daTransporte As New MySqlDataAdapter
    Private cbTransporte As MySqlCommandBuilder = New MySqlCommandBuilder(daTransporte)
    Private dsTransporte As DataSet
    Private dtTransporte As DataTable
    Private bsTransporte As New BindingSource

    Private Sub m_emptransporte_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        principal.ma_transporte.Enabled = True
    End Sub
    Private Sub m_emptransporte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Top = 0
        Me.Left = 0
        'cargamos el dataset
        dsTransporte = EmpTransporte.dsEmpTransporte
        'cargamos el datatable
        dtTransporte = dsTransporte.Tables("emp_transporte")
        'creamos y trabajamos con el comando a ejecutar
        Dim com As New MySqlCommand("Select cod_etrans,nom_etrans,activo from emp_transporte", dbconex)
        daTransporte.SelectCommand = com
        'cargamos los registros en la tabla sub grupo
        daTransporte.Fill(dsTransporte, "emp_transporte")
        'configuramos el bindingSource
        bsTransporte.DataSource = dsTransporte
        bsTransporte.DataMember = "emp_transporte"
        'configuramos el datagridview
        With datos
            .DataSource = bsTransporte
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_etrans").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns.Item("cod_etrans").HeaderText = "Código"
            .Columns.Item("cod_etrans").Resizable = DataGridViewTriState.False
            .Columns.Item("cod_etrans").Width = "80"
            .Columns.Item("nom_etrans").HeaderText = "Empresa de Transporte"
            .Columns.Item("nom_etrans").Resizable = DataGridViewTriState.False
            .Columns.Item("nom_etrans").Width = "270"
            .Columns.Item("activo").HeaderText = "Activo"
            .Columns.Item("activo").Resizable = DataGridViewTriState.False
            .Columns.Item("activo").Width = "43"
        End With
        'relacionamos los cuadros de texto con el bindingSource
        txtCodigo.DataBindings.Add("text", bsTransporte, "cod_etrans")
        txtEmpresa.DataBindings.Add("text", bsTransporte, "nom_etrans")
        chkActivo.DataBindings.Add("checked", bsTransporte, "activo")
    End Sub
    Private Sub cmdAñadir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAñadir.Click
        habilitaDetalle()
        deshabilitaCabecera()
        dsTransporte.Tables("emp_transporte").Columns("activo").DefaultValue = True
        bsTransporte.AddNew()
        datos.DataSource = bsTransporte
        modoGrabar()
        txtCodigo.Refresh()
        txtEmpresa.Refresh()
        chkActivo.Refresh()
        txtCodigo.Focus()
    End Sub
    Private Sub cmdGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGrabar.Click
        Try
            If validaIngreso() Then
                bsTransporte.EndEdit()
                daTransporte.Update(dsTransporte, "emp_transporte")
                datos.Refresh()
                deshabilitaDetalle()
                habilitaCabecera()
                modoAñadir()
                datos.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            bsTransporte.CancelEdit()
            datos.Refresh()
            deshabilitaDetalle()
            habilitaCabecera()
            modoAñadir()
            datos.Focus()
        End Try
    End Sub
    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        bsTransporte.CancelEdit()
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
        If bsTransporte.Count > 0 Then
            Dim mEmpresa As New EmpTransporte
            Dim existe As Boolean = mEmpresa.existeEnEmpTransporte(txtCodigo.Text)
            If Not existe Then
                Dim rpta As Integer
                rpta = MessageBox.Show("¿Esta seguro de Eliminar el ITEM Seleccionado...", "CEFE", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                If rpta = 6 Then
                    If bsTransporte.Count > 0 Then
                        bsTransporte.RemoveCurrent()
                        daTransporte.Update(dsTransporte, "emp_transporte")
                        datos.Refresh()
                    End If
                End If
            Else
                MessageBox.Show("El Registro Tiene Datos Relacionados..." + Chr(13) + "!NO Es posible eliminarlo¡", "CEFE", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button2)
            End If
        End If
    End Sub
    Private Sub cmdEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEditar.Click
        If bsTransporte.Count > 0 Then
            habilitaDetalle()
            deshabilitaCabecera()
            modoGrabar()
            txtCodigo.Focus()
        End If
    End Sub
    Function validaIngreso()
        Dim validado As Boolean = False
        If Len(txtCodigo.Text) > 0 Then
            If Len(txtEmpresa.Text) > 0 Then
                validado = True
            Else
                MessageBox.Show("Ingrese la Empresa de Transporte...", "CEFE", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtEmpresa.Focus()
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
        general.saleTexto(txtCodigo)
    End Sub
    Private Sub txtempresa_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEmpresa.GotFocus
        general.ingresaTexto(txtEmpresa)
    End Sub
    Private Sub txtempresa_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEmpresa.LostFocus
        general.saleTexto(txtEmpresa)
    End Sub
    Sub habilitaDetalle()
        lblCodigo.ForeColor = Color.Maroon
        lblEmpresa.ForeColor = Color.Maroon
        txtCodigo.BackColor = Color.White
        txtCodigo.ReadOnly = False
        txtEmpresa.BackColor = Color.White
        txtEmpresa.ReadOnly = False
        chkActivo.Enabled = True
    End Sub
    Sub deshabilitaDetalle()
        lblCodigo.ForeColor = Color.Black
        lblEmpresa.ForeColor = Color.Black
        txtCodigo.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        txtCodigo.ReadOnly = True
        txtEmpresa.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        txtEmpresa.ReadOnly = True
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
