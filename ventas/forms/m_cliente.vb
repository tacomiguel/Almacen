Imports MySql.Data.MySqlClient
Imports System.Data
Imports libreriaClases
Public Class m_cliente
    Private dsTipoCliente As New DataSet
    Private dtTipoCliente As New DataTable
    Private dstipofpago As New DataSet
    Private dttipofpago As New DataTable
    Private daCliente As New MySqlDataAdapter
    Private cbCliente As MySqlCommandBuilder = New MySqlCommandBuilder(daCliente)
    Private dsCliente As DataSet
    Private dtCliente As DataTable
    Private bsCliente As New BindingSource
    Private Sub m_cliente_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        principal.ma_cliente.Enabled = True
    End Sub
    Private Sub m_cliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Top = 0
        Me.Left = 0
        Dim cod As String = "00000000000"
        'dataset tipo de cliente
        dsTipoCliente.Tables.Add(dtTipoCliente)
        Dim daTipoCliente As New MySqlDataAdapter
        Dim comTipoCliente As New MySqlCommand("select cod_tipo,nom_tipo from tipo_cliente where activo=1", dbconex)
        daTipoCliente.SelectCommand = comTipoCliente
        daTipoCliente.Fill(dsTipoCliente, "tipo_cliente")
        With cboTipo
            .DataSource = dsTipoCliente.Tables("tipo_cliente")
            .DisplayMember = dsTipoCliente.Tables("tipo_cliente").Columns("nom_tipo").ToString
            .ValueMember = dsTipoCliente.Tables("tipo_cliente").Columns("cod_tipo").ToString
        End With

        'dataset tipo de fpago
        dstipofpago.Tables.Add(dttipofpago)
        Dim daTipofpago As New MySqlDataAdapter
        Dim comTipofpago As New MySqlCommand("select cod_fpago,nom_fpago from forma_pago where activo=1", dbConex)
        daTipofpago.SelectCommand = comTipofpago
        daTipofpago.Fill(dstipofpago, "tipo_fpago")
        With cboFpago
            .DataSource = dstipofpago.Tables("tipo_fpago")
            .DisplayMember = dstipofpago.Tables("tipo_fpago").Columns("nom_fpago").ToString
            .ValueMember = dstipofpago.Tables("tipo_fpago").Columns("cod_fpago").ToString
        End With

        'dataset cliente
        dsCliente = Cliente.dsCliente
        'cargamos el datatable
        dtCliente = dsCliente.Tables("cliente")
        'creamos y trabajamos con el comando a ejecutar
        Dim com As New MySqlCommand("Select cod_clie,nom_clie,raz_soc,dir_clie,fono_clie,fax_clie,cod_tipo,cod_fpago,dir_ent,hora_ent,nom_rep,fono_rep,cel_rep,nom_cont,fono_cont,cel_cont,activo from cliente where cod_clie<>'" & cod & "'", dbConex)
        daCliente.SelectCommand = com
        'cargamos los registros en la tabla sub grupo
        daCliente.Fill(dsCliente, "cliente")
        'configuramos el bindingSource
        bsCliente.DataSource = dsCliente
        bsCliente.DataMember = "cliente"
        'configuramos el datagridview
        With dataCliente
            .DataSource = bsCliente
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_clie").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns.Item("cod_clie").HeaderText = "Código"
            .Columns.Item("cod_clie").Resizable = DataGridViewTriState.False
            .Columns.Item("cod_clie").Width = "80"
            .Columns.Item("raz_soc").HeaderText = "Razón Social"
            .Columns.Item("raz_soc").Resizable = DataGridViewTriState.False
            .Columns.Item("raz_soc").Width = "270"
            .Columns.Item("fono_clie").HeaderText = "Teléfono"
            .Columns.Item("fono_clie").Resizable = DataGridViewTriState.False
            .Columns("fono_clie").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns.Item("fono_clie").Width = "60"
            .Columns.Item("nom_cont").HeaderText = "Contacto"
            .Columns.Item("nom_cont").Resizable = DataGridViewTriState.False
            .Columns.Item("nom_cont").Width = "180"
            .Columns.Item("cel_cont").HeaderText = "Celular"
            .Columns.Item("cel_cont").Resizable = DataGridViewTriState.False
            .Columns("cel_cont").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns.Item("cel_cont").Width = "70"
            .Columns.Item("activo").HeaderText = "Activo"
            .Columns.Item("activo").Resizable = DataGridViewTriState.False
            .Columns("activo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns.Item("activo").Width = "44"
            .Columns.Item("nom_clie").Visible = False
            .Columns.Item("fax_clie").Visible = False
            .Columns.Item("dir_clie").Visible = False
            .Columns.Item("cod_tipo").Visible = False
            .Columns.Item("dir_ent").Visible = False
            .Columns.Item("hora_ent").Visible = False
            .Columns.Item("nom_rep").Visible = False
            .Columns.Item("fono_rep").Visible = False
            .Columns.Item("cel_rep").Visible = False
            .Columns.Item("fono_cont").Visible = False
        End With
        'relacionamos los cuadros de texto con el bindingSource
        txtCodigo.DataBindings.Add("text", bsCliente, "cod_clie")
        txtRazonSocial.DataBindings.Add("text", bsCliente, "raz_soc")
        txtNombreComercial.DataBindings.Add("text", bsCliente, "nom_clie")
        txtFonoCliente.DataBindings.Add("text", bsCliente, "fono_clie")
        txtFaxCliente.DataBindings.Add("text", bsCliente, "fax_clie")
        txtDireccion.DataBindings.Add("text", bsCliente, "dir_clie")
        txtDirRecepcion.DataBindings.Add("text", bsCliente, "dir_ent")
        txtRepresentante.DataBindings.Add("text", bsCliente, "nom_rep")
        txtFonoRep.DataBindings.Add("text", bsCliente, "fono_rep")
        txtCelRep.DataBindings.Add("text", bsCliente, "cel_rep")
        txtContacto.DataBindings.Add("text", bsCliente, "nom_cont")
        txtFonoCont.DataBindings.Add("text", bsCliente, "fono_cont")
        txtCelCont.DataBindings.Add("text", bsCliente, "cel_cont")
        chkActivo.DataBindings.Add("checked", bsCliente, "activo")
        cboTipo.DataBindings.Add("selectedValue", bsCliente, "cod_tipo")
        cboFpago.DataBindings.Add("selectedValue", bsCliente, "cod_fpago")
    End Sub
    Private Sub cmdAñadir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAñadir.Click
        habilitaDetalle()
        deshabilitaCabecera()
        dsCliente.Tables("cliente").Columns("activo").DefaultValue = True
        bsCliente.AddNew()
        dataCliente.DataSource = bsCliente
        modoGrabar()
        txtCodigo.Refresh()
        chkActivo.Refresh()
        txtCodigo.Focus()
    End Sub
    Private Sub cmdGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGrabar.Click
        Try
            If validaIngreso() Then
                bsCliente.EndEdit()
                daCliente.Update(dsCliente, "cliente")
                dataCliente.Refresh()
                deshabilitaDetalle()
                habilitaCabecera()
                modoAñadir()
                dataCliente.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            bsCliente.CancelEdit()
            dataCliente.Refresh()
            deshabilitaDetalle()
            habilitaCabecera()
            modoAñadir()
            dataCliente.Focus()
        End Try
    End Sub
    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        bsCliente.CancelEdit()
        dataCliente.Refresh()
        deshabilitaDetalle()
        habilitaCabecera()
        modoAñadir()
        If dataCliente.Rows.Count > 0 Then
            dataCliente.CurrentCell = dataCliente(2, 0)
        End If
        dataCliente.Focus()
    End Sub
    Private Sub cmdEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEliminar.Click
        If bsCliente.Count > 0 Then
            Dim mCliente As New Cliente, exist, exist2 As Boolean, rpta As Integer
            exist = mCliente.existeEnSalida(Trim(txtCodigo.Text))
            If Not exist Then
                exist2 = mCliente.existeEnHistorial(Trim(txtCodigo.Text))
                If Not exist2 Then
                    rpta = MessageBox.Show("¿Esta Seguro de Eliminar el Item Seleccionado...?", "CEFE", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If rpta = 6 Then
                        If bsCliente.Count > 0 Then
                            bsCliente.RemoveCurrent()
                            daCliente.Update(dsCliente, "cliente")
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
        If bsCliente.Count > 0 Then
            habilitaDetalle()
            deshabilitaCabecera()
            modoGrabar()
            txtCodigo.Focus()
        End If
    End Sub
    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        Dim frm As New rptForm
        frm.cargarClientes()
        'frm.cargarLogo()
        frm.MdiParent = principal
        frm.Show()
    End Sub
    Function validaIngreso()
        Dim validado As Boolean = False
        If Len(txtCodigo.Text) > 0 Then
            If Len(txtRazonSocial.Text) > 0 Then
                If Len(txtNombreComercial.Text) > 0 Then
                    If cboTipo.SelectedIndex >= 0 Then
                        validado = True
                    Else
                        MessageBox.Show("Seleccione el Tipo de Cliente...", "CEFE", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        cboTipo.Focus()
                    End If
                Else
                    MessageBox.Show("Ingrese el Nombre Comercial...", "CEFE", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtNombreComercial.Focus()
                End If
            Else
                MessageBox.Show("Ingrese la Razón Social...", "CEFE", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtRazonSocial.Focus()
            End If
        Else
            MessageBox.Show("Ingrese el Código del Cliente...", "CEFE", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCodigo.Focus()
        End If
        Return validado
    End Function
    Sub habilitaDetalle()
        lblCodigo.ForeColor = Color.Maroon
        lblRazonSocial.ForeColor = Color.Maroon
        lblNombreComercial.ForeColor = Color.Maroon
        lblTipo.ForeColor = Color.Maroon
        cboTipo.BackColor = Color.White
        cboTipo.Enabled = True
        cboFpago.BackColor = Color.White
        cboFpago.Enabled = True
        txtCodigo.BackColor = Color.White
        txtCodigo.ReadOnly = False
        txtRazonSocial.BackColor = Color.White
        txtRazonSocial.ReadOnly = False
        txtNombreComercial.BackColor = Color.White
        txtNombreComercial.ReadOnly = False
        txtFonoCliente.BackColor = Color.White
        txtFonoCliente.ReadOnly = False
        txtFaxCliente.BackColor = Color.White
        txtFaxCliente.ReadOnly = False
        txtDireccion.BackColor = Color.White
        txtDireccion.ReadOnly = False
        txtDirRecepcion.BackColor = Color.White
        txtDirRecepcion.ReadOnly = False
        txtRepresentante.BackColor = Color.White
        txtRepresentante.ReadOnly = False
        txtFonoRep.BackColor = Color.White
        txtFonoRep.ReadOnly = False
        txtCelRep.BackColor = Color.White
        txtCelRep.ReadOnly = False
        txtContacto.BackColor = Color.White
        txtContacto.ReadOnly = False
        txtFonoCont.BackColor = Color.White
        txtFonoCont.ReadOnly = False
        txtCelCont.BackColor = Color.White
        txtCelCont.ReadOnly = False
        chkActivo.Enabled = True
    End Sub
    Sub deshabilitaDetalle()
        lblCodigo.ForeColor = Color.Black
        lblRazonSocial.ForeColor = Color.Black
        lblNombreComercial.ForeColor = Color.Black
        lblTipo.ForeColor = Color.Black
        cboTipo.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        cboTipo.Enabled = False
        cboFpago.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        cboFpago.Enabled = False
        txtCodigo.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        txtCodigo.ReadOnly = True
        txtRazonSocial.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        txtRazonSocial.ReadOnly = True
        txtNombreComercial.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        txtNombreComercial.ReadOnly = True
        txtFonoCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        txtFonoCliente.ReadOnly = True
        txtFaxCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        txtFaxCliente.ReadOnly = True
        txtDireccion.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        txtDireccion.ReadOnly = True
        txtDirRecepcion.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        txtDirRecepcion.ReadOnly = True
        txtRepresentante.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        txtRepresentante.ReadOnly = True
        txtFonoRep.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        txtFonoRep.ReadOnly = True
        txtCelRep.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        txtCelRep.ReadOnly = True
        txtContacto.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        txtContacto.ReadOnly = True
        txtFonoCont.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        txtFonoCont.ReadOnly = True
        txtCelCont.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        txtCelCont.ReadOnly = True
        chkActivo.Enabled = False
    End Sub
    Sub habilitaCabecera()
        dataCliente.Enabled = True
    End Sub
    Sub deshabilitaCabecera()
        dataCliente.Enabled = False
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
    Private Sub txtCodigo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.GotFocus
        general.ingresaTexto(txtCodigo)
    End Sub
    Private Sub txtCodigo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.LostFocus
        general.saleTexto(txtCodigo)
    End Sub
    Private Sub txtRazonSocial_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRazonSocial.GotFocus
        general.ingresaTexto(txtRazonSocial)
    End Sub

    Private Sub txtRazonSocial_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRazonSocial.LostFocus
        general.saleTexto(txtRazonSocial)
    End Sub

    Private Sub txtNombreComercial_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNombreComercial.GotFocus
        general.ingresaTexto(txtNombreComercial)
    End Sub

    Private Sub txtNombreComercial_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNombreComercial.LostFocus
        general.saleTexto(txtNombreComercial)
    End Sub
    Private Sub txtFonoCliente_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFonoCliente.GotFocus
        general.ingresaTexto(txtFonoCliente)
    End Sub
    Private Sub txtFonoCliente_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFonoCliente.LostFocus
        general.saleTexto(txtFonoCliente)
    End Sub
    Private Sub txtFaxCliente_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFaxCliente.GotFocus
        general.ingresaTexto(txtFaxCliente)
    End Sub
    Private Sub txtFaxCliente_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFaxCliente.LostFocus
        general.saleTexto(txtFaxCliente)
    End Sub
    Private Sub txtDireccion_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDireccion.GotFocus
        general.ingresaTexto(txtDireccion)
    End Sub
    Private Sub txtDireccion_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDireccion.LostFocus
        general.saleTexto(txtDireccion)
    End Sub
    Private Sub txtDirRecepcion_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDirRecepcion.GotFocus
        general.ingresaTexto(txtDirRecepcion)
    End Sub
    Private Sub txtDirRecepcion_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDirRecepcion.LostFocus
        general.saleTexto(txtDirRecepcion)
    End Sub
    Private Sub txtRepresentante_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRepresentante.GotFocus
        general.ingresaTexto(txtRepresentante)
    End Sub
    Private Sub txtRepresentante_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRepresentante.LostFocus
        general.saleTexto(txtRepresentante)
    End Sub
    Private Sub txtFonoRep_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFonoRep.GotFocus
        general.ingresaTexto(txtFonoRep)
    End Sub
    Private Sub txtFonoRep_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFonoRep.LostFocus
        general.saleTexto(txtFonoRep)
    End Sub
    Private Sub txtCelRep_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCelRep.GotFocus
        general.ingresaTexto(txtCelRep)
    End Sub
    Private Sub txtCelRep_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCelRep.LostFocus
        general.saleTexto(txtCelRep)
    End Sub
    Private Sub txtContacto_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtContacto.GotFocus
        general.ingresaTexto(txtContacto)
    End Sub
    Private Sub txtContacto_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtContacto.LostFocus
        general.saleTexto(txtContacto)
    End Sub
    Private Sub txtFonoCont_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFonoCont.GotFocus
        general.ingresaTexto(txtFonoCont)
    End Sub
    Private Sub txtFonoCont_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFonoCont.LostFocus
        general.saleTexto(txtFonoCont)
    End Sub

    Private Sub txtCelCont_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCelCont.GotFocus
        general.ingresaTexto(txtCelCont)
    End Sub
    Private Sub txtCelCont_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCelCont.LostFocus
        general.saleTexto(txtCelCont)
    End Sub
    Private Sub cmdCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCerrar.Click
        Me.Close()
    End Sub
End Class
