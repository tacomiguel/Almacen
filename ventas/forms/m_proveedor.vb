Imports MySql.Data.MySqlClient
Imports System.Data
Imports libreriaClases
Public Class m_proveedor
    Private dsTipoProveedor As New DataSet
    Private dtTipoProveedor As New DataTable
    Private daProveedor As New MySqlDataAdapter
    Private cbProveedor As MySqlCommandBuilder = New MySqlCommandBuilder(daProveedor)
    Private dsProveedor As DataSet
    Private dtProveedor As DataTable
    Private bsProveedor As New BindingSource
    Private Sub m_proveedor_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        principal.ma_proveedor.Enabled = True
    End Sub
    Private Sub m_proveedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Top = 0
        Me.Left = 0
        Dim cod As String = "00000000000"
        'dataset tipo de cliente
        dsTipoProveedor.Tables.Add(dtTipoProveedor)
        Dim daTipoCliente As New MySqlDataAdapter
        Dim comTipoCliente As New MySqlCommand("select cod_tipo,nom_tipo from tipo_proveedor where activo=1", dbconex)
        daTipoCliente.SelectCommand = comTipoCliente
        daTipoCliente.Fill(dsTipoProveedor, "tipo_proveedor")
        With cboTipo
            .DataSource = dsTipoProveedor.Tables("tipo_proveedor")
            .DisplayMember = dsTipoProveedor.Tables("tipo_proveedor").Columns("nom_tipo").ToString
            .ValueMember = dsTipoProveedor.Tables("tipo_proveedor").Columns("cod_tipo").ToString
            If dsTipoProveedor.Tables("tipo_proveedor").Rows.Count > 0 Then
                .SelectedIndex = 0
            Else
                .SelectedIndex = -1
            End If
        End With
        'dataset cliente
        dsProveedor = Proveedor.dsProveedor
        'cargamos el datatable
        dtProveedor = dsProveedor.Tables("proveedor")
        'creamos y trabajamos con el comando a ejecutar
        Dim cadProv As String = "Select cod_prov,nom_prov,raz_soc,dir_prov,fono_prov,fax_prov,cod_tipo," _
                                & "nom_rep,fono_rep,cel_rep,nom_cont,fono_cont,cel_cont,activo" _
                                & " from proveedor where cod_prov <>'" & cod & "' and activo=1" _
                                & " order by raz_soc"
        Dim com As New MySqlCommand(cadProv, dbConex)
        daProveedor.SelectCommand = com
        'cargamos los registros en la tabla sub grupo
        daProveedor.Fill(dsProveedor, "proveedor")
        'configuramos el bindingSource
        bsProveedor.DataSource = dsProveedor
        bsProveedor.DataMember = "proveedor"
        'configuramos el datagridview
        With dataProveedor
            .DataSource = bsProveedor
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_prov").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns.Item("cod_prov").HeaderText = "Código"
            .Columns.Item("cod_prov").Resizable = DataGridViewTriState.False
            .Columns.Item("cod_prov").Width = "80"
            .Columns.Item("raz_soc").HeaderText = "Razón Social"
            .Columns.Item("raz_soc").Resizable = DataGridViewTriState.False
            .Columns.Item("raz_soc").Width = "280"
            .Columns.Item("fono_prov").HeaderText = "Teléfono"
            .Columns.Item("fono_prov").Resizable = DataGridViewTriState.False
            .Columns("fono_prov").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns.Item("fono_prov").Width = "70"
            .Columns.Item("nom_cont").HeaderText = "Contacto"
            .Columns.Item("nom_cont").Resizable = DataGridViewTriState.False
            .Columns.Item("nom_cont").Width = "170"
            .Columns.Item("cel_cont").HeaderText = "Celular"
            .Columns.Item("cel_cont").Resizable = DataGridViewTriState.False
            .Columns("cel_cont").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns.Item("cel_cont").Width = "70"
            .Columns.Item("activo").HeaderText = "Act"
            .Columns.Item("activo").Resizable = DataGridViewTriState.False
            .Columns("activo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns.Item("activo").Width = "35"
            .Columns.Item("nom_prov").Visible = False
            .Columns.Item("fax_prov").Visible = False
            .Columns.Item("dir_prov").Visible = True
            .Columns.Item("email_prov").Visible = True
            .Columns.Item("cod_tipo").Visible = False
            .Columns.Item("nom_rep").Visible = False
            .Columns.Item("fono_rep").Visible = False
            .Columns.Item("cel_rep").Visible = False
            .Columns.Item("fono_cont").Visible = False
        End With
        'mostramos el numero de registros procesados
        lblRegistros.Text = "Nº de Registros Procesados... " & dataProveedor.RowCount

        'relacionamos los cuadros de texto con el bindingSource
        txtCodigo.DataBindings.Add("text", bsProveedor, "cod_prov")
        txtRazonSocial.DataBindings.Add("text", bsProveedor, "raz_soc")
        txtNombreComercial.DataBindings.Add("text", bsProveedor, "nom_prov")
        txtFonoCliente.DataBindings.Add("text", bsProveedor, "fono_prov")
        txtCelCliente.DataBindings.Add("text", bsProveedor, "fax_prov")
        TxtEmail.DataBindings.Add("text", bsProveedor, "email_prov")
        txtDireccion.DataBindings.Add("text", bsProveedor, "dir_prov")
        txtRepresentante.DataBindings.Add("text", bsProveedor, "nom_rep")
        txtFonoRep.DataBindings.Add("text", bsProveedor, "fono_rep")
        txtCelRep.DataBindings.Add("text", bsProveedor, "cel_rep")
        txtContacto.DataBindings.Add("text", bsProveedor, "nom_cont")
        txtFonoCont.DataBindings.Add("text", bsProveedor, "fono_cont")
        txtCelCont.DataBindings.Add("text", bsProveedor, "cel_cont")
        chkActivo.DataBindings.Add("checked", bsProveedor, "activo")
        cboTipo.DataBindings.Add("selectedValue", bsProveedor, "cod_tipo")
    End Sub
    Private Sub cmdAñadir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAñadir.Click
        habilitaDetalle()
        deshabilitaCabecera()
        dsProveedor.Tables("proveedor").Columns("activo").DefaultValue = True
        bsProveedor.AddNew()
        dataProveedor.DataSource = bsProveedor
        modoGrabar()
        txtCodigo.Refresh()
        chkActivo.Refresh()
        txtCodigo.Focus()
    End Sub
    Private Sub cmdGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGrabar.Click
        Try
            If validaIngreso() Then
                bsProveedor.EndEdit()
                daProveedor.Update(dsProveedor, "proveedor")
                dataProveedor.Refresh()
                deshabilitaDetalle()
                habilitaCabecera()
                modoAñadir()
                dataProveedor.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            bsProveedor.CancelEdit()
            dataProveedor.Refresh()
            deshabilitaDetalle()
            habilitaCabecera()
            modoAñadir()
            dataProveedor.Focus()
        End Try
    End Sub
    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        bsProveedor.CancelEdit()
        dataProveedor.Refresh()
        deshabilitaDetalle()
        habilitaCabecera()
        modoAñadir()
        If dataProveedor.Rows.Count > 0 Then
            dataProveedor.CurrentCell = dataProveedor(2, 0)
        End If
        dataProveedor.Focus()
    End Sub
    Private Sub cmdEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEliminar.Click
        If bsProveedor.Count > 0 Then
            Dim mProveedor As New Proveedor, exist, exist2 As Boolean, rpta As Integer
            exist = mProveedor.existeEnIngreso(Trim(txtCodigo.Text))
            If Not exist Then
                exist2 = mProveedor.existeEnHistorial(Trim(txtCodigo.Text))
                If Not exist2 Then
                    rpta = MessageBox.Show("¿Esta Seguro de Eliminar el Item Seleccionado...?", "CEFE", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If rpta = 6 Then
                        If bsProveedor.Count > 0 Then
                            bsProveedor.RemoveCurrent()
                            daProveedor.Update(dsProveedor, "proveedor")
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
        If bsProveedor.Count > 0 Then
            habilitaDetalle()
            deshabilitaCabecera()
            modoGrabar()
            txtCodigo.Focus()
        End If
    End Sub
    Function validaIngreso()
        Dim validado As Boolean = False
        'If Len(txtCelCliente.Text) >= 9 Then
        'If Len(txtFonoCliente.Text) >= 7 Then
        If Len(txtCodigo.Text) >= 11 Then
                    If Len(txtRazonSocial.Text) > 0 Then
                        If Len(txtNombreComercial.Text) > 0 Then
                            'If Len(txtDireccion.Text) >= 10 Then
                            If cboTipo.SelectedIndex >= 0 Then
                                    validado = True
                                Else
                                    MessageBox.Show("Seleccione el Tipo de Cliente...", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                    cboTipo.Focus()
                                End If
                                'Else
                                '    MessageBox.Show("Ingrese Dirección...", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                '    txtDireccion.Focus()
                                'End If
                            Else
                            MessageBox.Show("Ingrese el Nombre Comercial...", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            txtNombreComercial.Focus()
                        End If
                    Else
                        MessageBox.Show("Ingrese la Razón Social...", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        txtRazonSocial.Focus()
                    End If
                Else
                    MessageBox.Show("Ingrese el Código del Cliente...", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtCodigo.Focus()
                End If
        'Else
        '    MessageBox.Show("Ingrese el Telefono del Cliente...", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '    txtFonoCliente.Focus()
        'End If
        'Else
        'MessageBox.Show("Ingrese el Celular del Cliente...", "CEFE", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        'txtCelCliente.Focus()
        'End If
        Return validado
    End Function
    Sub habilitaDetalle()
        lblCodigo.ForeColor = Color.Maroon
        lblRazonSocial.ForeColor = Color.Maroon
        lblNombreComercial.ForeColor = Color.Maroon
        lblDireccion.ForeColor = Color.Maroon
        lblTipo.ForeColor = Color.Maroon
        cboTipo.BackColor = Color.White
        cboTipo.Enabled = True
        txtCodigo.BackColor = Color.White
        txtCodigo.ReadOnly = False
        txtRazonSocial.BackColor = Color.White
        txtRazonSocial.ReadOnly = False
        txtNombreComercial.BackColor = Color.White
        txtNombreComercial.ReadOnly = False
        txtFonoCliente.BackColor = Color.White
        txtFonoCliente.ReadOnly = False
        txtCelCliente.BackColor = Color.White
        txtCelCliente.ReadOnly = False
        TxtEmail.BackColor = Color.White
        TxtEmail.ReadOnly = False
        txtDireccion.BackColor = Color.White
        txtDireccion.ReadOnly = False
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
        lblDireccion.ForeColor = Color.Black
        lblTipo.ForeColor = Color.Black
        cboTipo.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        cboTipo.Enabled = False
        txtCodigo.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        txtCodigo.ReadOnly = True
        txtRazonSocial.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        txtRazonSocial.ReadOnly = True
        txtNombreComercial.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        txtNombreComercial.ReadOnly = True
        txtFonoCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        txtFonoCliente.ReadOnly = True
        txtCelCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        txtCelCliente.ReadOnly = True
        TxtEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        TxtEmail.ReadOnly = True
        txtDireccion.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        txtDireccion.ReadOnly = True
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
        dataProveedor.Enabled = True
    End Sub
    Sub deshabilitaCabecera()
        dataProveedor.Enabled = False
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
    Private Sub txtFaxCliente_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCelCliente.GotFocus
        general.ingresaTexto(txtCelCliente)
    End Sub
    Private Sub txtFaxCliente_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCelCliente.LostFocus
        general.saleTexto(txtCelCliente)
    End Sub
    Private Sub txtDireccion_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDireccion.GotFocus
        general.ingresaTexto(txtDireccion)
    End Sub
    Private Sub txtDireccion_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDireccion.LostFocus
        general.saleTexto(txtDireccion)
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
    Private Sub cmdCerrar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCerrar.Click
        Me.Close()
    End Sub

    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click

    End Sub

    Private Sub dataProveedor_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataProveedor.CellContentClick

    End Sub

    Private Sub dataProveedor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dataProveedor.KeyDown
        If (e.Control And e.KeyCode = Keys.E) Then
            If dataProveedor.RowCount > 0 Then
                EnviaraExcel(dataProveedor)
            End If
        End If
    End Sub

    Private Sub txtBuscar_GotFocus(sender As Object, e As EventArgs) Handles txtBuscar.GotFocus
        general.ingresaTextoProceso(txtBuscar)
        txtBuscar.SelectAll()
    End Sub

    Private Sub txtBuscar_LostFocus(sender As Object, e As EventArgs) Handles txtBuscar.LostFocus
        general.saleTextoProceso(txtBuscar)
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        If optDescripcion.Checked = True Then
            bsProveedor.Filter = "raz_soc like '" & txtBuscar.Text & "%'"
        Else
            bsProveedor.Filter = "cod_prov like '" & txtBuscar.Text & "%'"
        End If
    End Sub
End Class
