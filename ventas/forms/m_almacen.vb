Imports libreriaClases
Imports MySql.Data.MySqlClient
Imports System.Data
Public Class m_almacen
    Private daAlmacen As New MySqlDataAdapter

    Private cbAlmacen As MySqlCommandBuilder = New MySqlCommandBuilder(daAlmacen)
    Private dsAlmacen As DataSet
    Private dtAlmacen As DataTable

    Private bsAlmacen As New BindingSource
    Private estacargando As Boolean = True
    Private cod_alma As String
    Dim indice As Integer
    'Dim menu As ContextMenuStrip
    Private Sub m_almacen_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        principal.ma_almacen.Enabled = True
    End Sub
    Private Sub m_almacen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Top = 0
        Me.Left = 0
        'cargamos el dataset
        dsAlmacen = subgrupo.dssubgrupo
        'cargamos el datatable
        dtAlmacen = dsAlmacen.Tables("almacen")
        'creamos y trabajamos con el comando a ejecutar
        Dim cad As String = "Select cod_alma,nom_alma,esPrincipal,esProduccion,es_invDiario,esCompras,esVentas," _
                            & "esCatalogo,origenTrans,destinoTrans,tieneIdeales,almaCatalogo,activo from almacen"
        Dim com As New MySqlCommand(cad, dbConex)
        daAlmacen.SelectCommand = com
        'cargamos los registros en la tabla sub grupo
        daAlmacen.Fill(dsAlmacen, "almacen")
        'configuramos el bindingSource
        bsAlmacen.DataSource = dsAlmacen
        bsAlmacen.DataMember = "almacen"
        'configuramos el datagridview
        With datos
            .DataSource = bsAlmacen
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_alma").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns.Item("cod_alma").HeaderText = "Código"
            .Columns.Item("cod_alma").Resizable = DataGridViewTriState.False
            .Columns.Item("cod_alma").Width = "50"
            .Columns.Item("nom_alma").HeaderText = "Almacén"
            .Columns.Item("nom_alma").Resizable = DataGridViewTriState.False
            .Columns.Item("nom_alma").Width = "150"
            .Columns.Item("esPrincipal").HeaderText = "Principal"
            .Columns.Item("esPrincipal").Resizable = DataGridViewTriState.False
            .Columns.Item("esPrincipal").Width = "50"
            .Columns.Item("esProduccion").HeaderText = "Producción"
            .Columns.Item("esProduccion").Resizable = DataGridViewTriState.False
            .Columns.Item("esProduccion").Width = "60"
            .Columns.Item("es_invDiario").HeaderText = "Inv. Diario"
            .Columns.Item("es_invDiario").Resizable = DataGridViewTriState.False
            .Columns.Item("es_invDiario").Width = "45"
            .Columns.Item("esCompras").HeaderText = "Compras"
            .Columns.Item("esCompras").Resizable = DataGridViewTriState.False
            .Columns.Item("esCompras").Width = "50"
            .Columns.Item("esVentas").HeaderText = "Ventas"
            .Columns.Item("esVentas").Resizable = DataGridViewTriState.False
            .Columns.Item("esVentas").Width = "50"
            .Columns.Item("esCatalogo").HeaderText = "Tiene Catalogo"
            .Columns.Item("esCatalogo").Resizable = DataGridViewTriState.False
            .Columns.Item("esCatalogo").Width = "55"
            .Columns.Item("tieneIdeales").HeaderText = "Tiene Ideales"
            .Columns.Item("tieneIdeales").Resizable = DataGridViewTriState.False
            .Columns.Item("tieneIdeales").Width = "50"
            .Columns.Item("origenTrans").HeaderText = "Origen Transf."
            .Columns.Item("origenTrans").Resizable = DataGridViewTriState.False
            .Columns.Item("origenTrans").Width = "50"
            .Columns.Item("destinoTrans").HeaderText = "Destino Transf."
            .Columns.Item("destinoTrans").Resizable = DataGridViewTriState.False
            .Columns.Item("destinoTrans").Width = "50"
            .Columns.Item("almaCatalogo").HeaderText = "Almacen Catálogo"
            .Columns.Item("almaCatalogo").Resizable = DataGridViewTriState.False
            .Columns.Item("almaCatalogo").Width = "55"
            .Columns.Item("activo").HeaderText = "Act."
            .Columns.Item("activo").Resizable = DataGridViewTriState.False
            .Columns.Item("activo").Width = "30"
            .Columns.Item("es_invDiario").Visible = False
        End With
        'relacionamos los cuadros de texto con el bindingSource
        txtCodigo.DataBindings.Add("text", bsAlmacen, "cod_alma")
        txtAlmacen.DataBindings.Add("text", bsAlmacen, "nom_alma")
        chkPrincipal.DataBindings.Add("checked", bsAlmacen, "esPrincipal")
        chkProduccion.DataBindings.Add("checked", bsAlmacen, "esProduccion")
        chkInvDiario.DataBindings.Add("checked", bsAlmacen, "es_InvDiario")
        chkCompras.DataBindings.Add("checked", bsAlmacen, "esCompras")
        chkVentas.DataBindings.Add("checked", bsAlmacen, "esVentas")
        chkCatalogo.DataBindings.Add("checked", bsAlmacen, "esCatalogo")
        chkIdeales.DataBindings.Add("checked", bsAlmacen, "tieneIdeales")
        chkOrigen.DataBindings.Add("checked", bsAlmacen, "origenTrans")
        chkDestino.DataBindings.Add("checked", bsAlmacen, "destinoTrans")
        txtCatalogo.DataBindings.Add("text", bsAlmacen, "almaCatalogo")
        chkActivo.DataBindings.Add("checked", bsAlmacen, "activo")

        estacargando = False

    End Sub
    Private Sub cmdAñadir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAñadir.Click
        estacargando = True
        habilitaDetalle()
        deshabilitaCabecera()
        dsAlmacen.Tables("almacen").Columns("activo").DefaultValue = True
        dsAlmacen.Tables("almacen").Columns("esPrincipal").DefaultValue = False
        dsAlmacen.Tables("almacen").Columns("esProduccion").DefaultValue = False
        dsAlmacen.Tables("almacen").Columns("es_invDiario").DefaultValue = False
        dsAlmacen.Tables("almacen").Columns("esCompras").DefaultValue = False
        dsAlmacen.Tables("almacen").Columns("esVentas").DefaultValue = False
        dsAlmacen.Tables("almacen").Columns("esCatalogo").DefaultValue = False
        dsAlmacen.Tables("almacen").Columns("tieneIdeales").DefaultValue = False
        dsAlmacen.Tables("almacen").Columns("origenTrans").DefaultValue = False
        dsAlmacen.Tables("almacen").Columns("destinoTrans").DefaultValue = False
        bsAlmacen.AddNew()
        datos.DataSource = bsAlmacen
        modoGrabar()
        txtCodigo.Refresh()
        txtAlmacen.Refresh()
        txtCatalogo.Refresh()
        chkActivo.Refresh()
        txtCodigo.Focus()
    End Sub
    Private Sub cmdGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGrabar.Click
        Try
            If validaIngreso() Then
                bsAlmacen.EndEdit()
                daAlmacen.Update(dsAlmacen, "almacen")
                datos.Refresh()
                deshabilitaDetalle()
                habilitaCabecera()
                modoAñadir()
                datos.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            bsAlmacen.CancelEdit()
            datos.Refresh()
            deshabilitaDetalle()
            habilitaCabecera()
            modoAñadir()
            datos.Focus()
        End Try
    End Sub
    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        bsAlmacen.CancelEdit()
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
        If bsAlmacen.Count > 0 Then
            Dim mAlmacen As New Almacen, exist, exist2 As Boolean, rpta As Integer
            If Trim(txtCodigo.Text) = "0000" Then
                MessageBox.Show("Este Almacén es de Sistema..." + Chr(13) + "NO es Posible eliminarlo...", "CEFE", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Else
                exist = mAlmacen.tieneArticulos(txtCodigo.Text)
                If Not exist Then
                    exist = mAlmacen.existeEnIngreso(Trim(txtCodigo.Text))
                    If Not exist Then
                        exist2 = mAlmacen.existeEnIngresoHistorial(Trim(txtCodigo.Text))
                        If Not exist2 Then
                            rpta = MessageBox.Show("¿Esta seguro de Eliminar el ITEM Seleccionado...", "CEFE", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                            If rpta = 6 Then
                                If bsAlmacen.Count > 0 Then
                                    bsAlmacen.RemoveCurrent()
                                    daAlmacen.Update(dsAlmacen, "almacen")
                                    datos.Refresh()
                                End If
                            End If
                        Else
                            MessageBox.Show("El Registro tiene Información Relacionada en el Historial" + Chr(13) + "!NO es posible Eliminarlo...¡", "CEFE", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        End If
                    Else
                        MessageBox.Show("El Registro tiene Información Relacionada" + Chr(13) + "!NO es posible Eliminarlo...¡", "CEFE", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    End If
                Else
                    MessageBox.Show("El Almacén tiene Productos Registrados" + Chr(13) + "!NO es posible Eliminarlo...¡", "CEFE", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                End If
            End If
        End If
    End Sub
    Private Sub cmdEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEditar.Click
        If bsAlmacen.Count > 0 Then
            If Trim(txtCodigo.Text) = "0000" Then
                MessageBox.Show("Este Almacén es de Sistema..." + Chr(13) + "NO es Posible Modificarlo...", "CEFE", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Else
                habilitaDetalle()
                deshabilitaCabecera()
                modoGrabar()
                txtCodigo.Focus()
            End If
        End If
    End Sub
    Function validaIngreso()
        Dim validado As Boolean = False
        If Len(txtCodigo.Text) > 0 Then
            If Len(txtAlmacen.Text) > 0 Then
                If Len(txtCatalogo.Text) > 0 Then
                    validado = True
                Else
                    MessageBox.Show("Ingrese el Almacén de donde se Recupera el Catálogo...", "CEFE", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtCatalogo.Focus()
                End If
            Else
                MessageBox.Show("Ingrese el Almacén...", "CEFE", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtAlmacen.Focus()
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
            txtCodigo.Text = Microsoft.VisualBasic.Right("0000" + Trim(txtCodigo.Text), 4)
        End If
        general.saleTexto(txtCodigo)
    End Sub
    Private Sub txtAlmacen_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAlmacen.GotFocus
        general.ingresaTexto(txtAlmacen)
    End Sub
    Private Sub txtAlmacen_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAlmacen.LostFocus
        general.saleTexto(txtAlmacen)
    End Sub
    Private Sub txtCatalogo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCatalogo.GotFocus
        general.ingresaTexto(txtCatalogo)
    End Sub
    Private Sub txtCatalogo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCatalogo.LostFocus
        general.saleTexto(txtCatalogo)
    End Sub
    Sub habilitaDetalle()
        lblCodigo.ForeColor = Color.Maroon
        lblAlmacen.ForeColor = Color.Maroon
        lblCatalogo.ForeColor = Color.Maroon
        txtCodigo.BackColor = Color.White
        txtCodigo.ReadOnly = False
        txtAlmacen.BackColor = Color.White
        txtAlmacen.ReadOnly = False
        chkPrincipal.Enabled = True
        chkProduccion.Enabled = True
        chkInvDiario.Enabled = True
        chkCompras.Enabled = True
        chkVentas.Enabled = True
        chkCatalogo.Enabled = True
        chkIdeales.Enabled = True
        chkOrigen.Enabled = True
        chkDestino.Enabled = True
        txtCatalogo.BackColor = Color.White
        txtCatalogo.ReadOnly = False
        chkActivo.Enabled = True
    End Sub
    Sub deshabilitaDetalle()
        lblCodigo.ForeColor = Color.Black
        lblAlmacen.ForeColor = Color.Black
        txtCodigo.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        txtCodigo.ReadOnly = True
        txtAlmacen.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        txtAlmacen.ReadOnly = True
        chkPrincipal.Enabled = False
        chkProduccion.Enabled = False
        chkInvDiario.Enabled = False
        chkCompras.Enabled = False
        chkVentas.Enabled = False
        chkCatalogo.Enabled = False
        chkIdeales.Enabled = False
        chkOrigen.Enabled = False
        chkDestino.Enabled = False
        txtCatalogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        txtCatalogo.ReadOnly = True
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

    Private Sub datos_SelectionChanged(sender As Object, e As EventArgs) Handles datos.SelectionChanged

        If Not estaCargando Then
            LblNomAlmacen.Text = "ALMACEN : "
            If datos.RowCount > 0 Then
                LblNomAlmacen.Text = "ALMACEN : " & datos("nom_alma", datos.CurrentRow.Index).Value
                cod_alma = datos("cod_alma", datos.CurrentRow.Index).Value
                muestraArea(cod_alma)

            End If
        End If
    End Sub


    Sub muestraArea(ByVal cod_alma As String)
        Try

            Dim tablaArea As New DataTable
            Dim Sql As String = "select a.* from area a where cod_alma= '" & cod_alma & "'"
            Dim daAreas As New MySqlDataAdapter(Sql, dbConex)

            daAreas.Fill(tablaArea)
            DataArea.DataSource = tablaArea
            estructuraArea()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try


    End Sub


    Sub estructuraArea()
        With DataArea
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_area").HeaderText = "codigo"
            .Columns("cod_area").Width = 70
            .Columns("cod_area").ReadOnly = True
            .Columns("cod_area").DisplayIndex = 0
            .Columns("cod_area").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("nom_area").HeaderText = "Descripcion"
            .Columns("nom_area").Width = 300
            .Columns("nom_area").ReadOnly = True
            .Columns("nom_area").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("nom_area").DisplayIndex = 1
            .Columns("cod_alma").Visible = False
            .Columns("es_invInicial").Visible = False
            .Columns("es_invDiario").Visible = False
            .Columns("es_invMensual").Visible = False
            .Columns("tieneideales").Visible = False
            .Columns("destinotrans").Visible = False
            .Columns("nom_entrega").Visible = False
        End With
    End Sub


    Private Sub DataArea_MouseDown(sender As Object, e As MouseEventArgs) Handles DataArea.MouseDown

        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            Dim Mi_Test As DataGridView.HitTestInfo = Me.DataArea.HitTest(e.X, e.Y)
            If Mi_Test.Type = DataGridViewHitTestType.Cell Then
                If Mi_Test.RowIndex >= 0 Then
                    indice = Mi_Test.RowIndex
                    Me.DataArea.CurrentCell = Me.DataArea.Rows(Mi_Test.RowIndex).Cells(Mi_Test.ColumnIndex)
                    Me.DataArea.Rows(Mi_Test.RowIndex).Selected = True

                    Dim _contextmenu As New ContextMenuStrip
                    _contextmenu.Items.Add("Ingresar")
                    _contextmenu.Items.Add("Eliminar")
                    '_contextmenu.Items.Add("Editar")
                    AddHandler _contextmenu.ItemClicked, AddressOf contextmenu_click
                    For Each rw As DataGridViewRow In DataArea.Rows
                        For Each c As DataGridViewCell In rw.Cells
                            c.ContextMenuStrip = _contextmenu
                        Next
                    Next

                End If
            End If
        End If
    End Sub

    Private Sub contextmenu_click(ByVal sender As System.Object,
                                  ByVal e As ToolStripItemClickedEventArgs)
        Dim clickCell As DataGridViewCell = DataArea.SelectedCells(0)
        Select Case e.ClickedItem.Text
            Case "Ingresar"
                ingresarea()

            Case "Eliminar"
                eliminaArea()

                ' Case "Editar"

        End Select
        muestraArea(cod_alma)
    End Sub

    Sub ingresarea()
        Dim mAlmacen As New Almacen
        Dim codigo As String = mAlmacen.maxOperacion_area
        Try
            mAlmacen.insertaArea(codigo, txtArea.Text, cod_alma, 1)
            txtArea.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub
    Sub eliminaArea()
        Dim mAlmacen As New Almacen
        Dim cod_area = DataArea("cod_area", DataArea.CurrentRow.Index).Value
        Try
            mAlmacen.eliminaArea(cod_area)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub DataArea_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataArea.CellContentClick

    End Sub
End Class
