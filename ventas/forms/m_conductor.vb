Imports MySql.Data.MySqlClient
Imports System.Data
Imports libreriaClases
Public Class m_conductor
    Private daChofer As New MySqlDataAdapter
    Private cbChofer As MySqlCommandBuilder = New MySqlCommandBuilder(daChofer)
    Private dsChofer As DataSet
    Private dtChofer As DataTable
    Private bsChofer As New BindingSource
    Private Sub m_conductor_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        principal.ma_conductor.Enabled = True
    End Sub
    Private Sub m_conductor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Top = 0
        Me.Left = 0
        'cargamos el dataset
        dsChofer = Chofer.dsChofer
        'cargamos el datatable
        dtChofer = dsChofer.Tables("chofer")
        'creamos y trabajamos con el comando a ejecutar
        Dim com As New MySqlCommand("Select cod_chof,nom_chof,lic_chof,marca_auto,placa_auto,activo from chofer order by nom_chof", dbConex)
        daChofer.SelectCommand = com
        'cargamos los registros en la tabla chofer
        daChofer.Fill(dsChofer, "chofer")
        'configuramos el bindingSource
        bsChofer.DataSource = dsChofer
        bsChofer.DataMember = "chofer"
        'configuramos el datagridview
        With dataChofer
            .DataSource = bsChofer
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_chof").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns.Item("cod_chof").HeaderText = "Código"
            .Columns.Item("cod_chof").Resizable = DataGridViewTriState.False
            .Columns.Item("cod_chof").Width = "85"
            .Columns.Item("nom_chof").HeaderText = "Nombres del Conductor"
            .Columns.Item("nom_chof").Resizable = DataGridViewTriState.False
            .Columns.Item("nom_chof").Width = "250"
            .Columns.Item("activo").HeaderText = "Activo"
            .Columns.Item("activo").Resizable = DataGridViewTriState.False
            .Columns.Item("activo").Width = "50"
        End With
        'relacionamos los cuadros de texto con el bindingSource
        txtCodigo.DataBindings.Add("text", bsChofer, "cod_chof")
        txtConductor.DataBindings.Add("text", bsChofer, "nom_chof")
        txtLicencia.DataBindings.Add("text", bsChofer, "lic_chof")
        txtmarca.DataBindings.Add("text", bsChofer, "marca_auto")
        txtplaca.DataBindings.Add("text", bsChofer, "placa_auto")
        chkActivo.DataBindings.Add("checked", bsChofer, "activo")
    End Sub
    Private Sub txtCodigo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.GotFocus
        general.ingresaTexto(txtCodigo)
    End Sub
    Private Sub txtCodigo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.LostFocus
        general.saleTexto(txtCodigo)
        If Len(txtCodigo.Text) > 0 Then
            txtCodigo.Text = Microsoft.VisualBasic.Right("00000000" & txtCodigo.Text, 8)
        End If
    End Sub
    Private Sub txtConductor_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtConductor.GotFocus
        general.ingresaTexto(txtConductor)
    End Sub
    Private Sub txtConductor_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtConductor.LostFocus
        general.saleTexto(txtConductor)
    End Sub
    Private Sub cmdAñadir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAñadir.Click
        habilitaDetalle()
        dsChofer.Tables("chofer").Columns("activo").DefaultValue = True
        bsChofer.AddNew()
        dataChofer.DataSource = bsChofer
        modoGrabar()
        txtCodigo.Refresh()
        txtConductor.Refresh()
        chkActivo.Refresh()
        txtCodigo.Focus()
    End Sub
    Private Sub cmdGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGrabar.Click
        Try
            If validaIngreso() Then
                bsChofer.EndEdit()
                daChofer.Update(dsChofer, "chofer")
                dataChofer.Refresh()
                deshabilitaDetalle()
                modoAñadir()
                dataChofer.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            bsChofer.CancelEdit()
            dataChofer.Refresh()
            deshabilitaDetalle()
            modoAñadir()
            dataChofer.Focus()
        End Try
    End Sub
    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        bsChofer.CancelEdit()
        dataChofer.Refresh()
        deshabilitaDetalle()
        modoAñadir()
        dataChofer.Focus()
        If dataChofer.Rows.Count > 0 Then
            dataChofer.CurrentCell = dataChofer(1, 0)
        End If
    End Sub
    Private Sub cmdEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEliminar.Click
        If bsChofer.Count > 0 Then
            Dim mConductor As New Chofer
            Dim existe As Boolean = mConductor.existeEnGuia(txtCodigo.Text)
            If Not existe Then
                Dim existe2 As Boolean = mConductor.existeEnGuiaHistorial(txtCodigo.Text)
                If Not existe2 Then
                    Dim rpta As Integer
                    rpta = MessageBox.Show("Esta Seguro de Eliminar el ITEM Seleccionado...", "CEFE", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                    If rpta = 6 Then
                        If bsChofer.Count > 0 Then
                            bsChofer.RemoveCurrent()
                            daChofer.Update(dsChofer, "chofer")
                        End If
                    End If
                Else
                    MessageBox.Show("El Registro Tiene Datos Relacionados..." + Chr(13) + "!NO Es posible eliminarlo¡", "CEFE", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button2)
                End If
            Else
                MessageBox.Show("El Registro Tiene Datos Relacionados..." + Chr(13) + "!NO Es posible eliminarlo¡", "CEFE", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button2)
            End If
        End If
    End Sub
    Private Sub cmdEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEditar.Click
        If bsChofer.Count > 0 Then
            habilitaDetalle()
            modoGrabar()
            txtCodigo.Focus()
        End If
    End Sub
    Function validaIngreso()
        Dim validado As Boolean = False
        If Len(txtCodigo.Text) > 0 Then
            If Len(txtConductor.Text) > 0 Then
                validado = True
            Else
                MessageBox.Show("Ingrese el Conductor...", "ALMACEN", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtConductor.Focus()
            End If
        Else
            MessageBox.Show("Ingrese el Código...", "ALMACEN", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCodigo.Focus()
        End If
        Return validado
    End Function
    Sub habilitaDetalle()
        lblCodigo.ForeColor = Color.Maroon
        lblConductor.ForeColor = Color.Maroon
        txtCodigo.BackColor = Color.White
        txtCodigo.ReadOnly = False
        txtConductor.BackColor = Color.White
        txtConductor.ReadOnly = False
        txtLicencia.BackColor = Color.White
        txtLicencia.ReadOnly = False
        txtmarca.BackColor = Color.White
        txtmarca.ReadOnly = False
        txtplaca.BackColor = Color.White
        txtplaca.ReadOnly = False
        chkActivo.Enabled = True
    End Sub
    Sub deshabilitaDetalle()
        lblCodigo.ForeColor = Color.Black
        lblConductor.ForeColor = Color.Black
        txtCodigo.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        txtCodigo.ReadOnly = True
        txtConductor.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        txtConductor.ReadOnly = True
        txtLicencia.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        txtLicencia.ReadOnly = True
        txtmarca.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        txtmarca.ReadOnly = True
        txtplaca.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        txtplaca.ReadOnly = True
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
    Private Sub cmdCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCerrar.Click
        Me.Close()
    End Sub
End Class
