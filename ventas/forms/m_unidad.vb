Imports libreriaClases
Imports MySql.Data.MySqlClient
Imports System.Data
Public Class m_unidad
    Private daUnidad As New MySqlDataAdapter
    Private cbUnidad As MySqlCommandBuilder = New MySqlCommandBuilder(daUnidad)
    Private dsUnidad As DataSet
    Private dtUnidad As DataTable
    Private bsUnidad As New BindingSource
    'para validar el separador decimal
    Private sepDecimal As Char
    Private Sub m_subgrupo_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        principal.ma_unidades.Enabled = True
    End Sub
    Private Sub m_unidad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Top = 0
        Me.Left = 0
        'capturamos el separador decimal
        sepDecimal = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        'cargamos el dataset
        dsUnidad = Unidad.dsUnidad
        'cargamos el datatable
        dtUnidad = dsUnidad.Tables("unidad")
        'creamos y trabajamos con el comando a ejecutar
        Dim com As New MySqlCommand("Select * from unidad where activo=1 order by nom_uni", dbConex)
        daUnidad.SelectCommand = com
        'cargamos los registros en la tabla sub grupo
        daUnidad.Fill(dsUnidad, "unidad")
        'configuramos el bindingSource
        bsUnidad.DataSource = dsUnidad
        bsUnidad.DataMember = "unidad"
        'configuramos el datagridview
        With datos
            .DataSource = bsUnidad
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_uni").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns.Item("cod_uni").HeaderText = "Código"
            .Columns.Item("cod_uni").DisplayIndex = 0
            .Columns.Item("cod_uni").Resizable = DataGridViewTriState.False
            .Columns.Item("cod_uni").Width = "50"
            .Columns.Item("nom_uni").HeaderText = "Unidad"
            .Columns.Item("nom_uni").DisplayIndex = 1
            .Columns.Item("nom_uni").Resizable = DataGridViewTriState.False
            .Columns.Item("nom_uni").Width = "80"
            .Columns.Item("cant_uni").HeaderText = "Cant. x Unidad"
            .Columns.Item("cant_uni").DisplayIndex = 2
            .Columns.Item("cant_uni").Resizable = DataGridViewTriState.False
            .Columns.Item("cant_uni").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns.Item("cant_uni").Width = "60"
            .Columns.Item("esProduccion").HeaderText = "Para Producción"
            .Columns.Item("esProduccion").DisplayIndex = 3
            .Columns.Item("esProduccion").Resizable = DataGridViewTriState.False
            .Columns.Item("esProduccion").Width = "80"
            .Columns.Item("esCompra").HeaderText = "Para Compra"
            .Columns.Item("esCompra").DisplayIndex = 4
            .Columns.Item("esCompra").Resizable = DataGridViewTriState.False
            .Columns.Item("esCompra").Width = "80"

            .Columns.Item("activo").HeaderText = "Act."
            .Columns.Item("activo").DisplayIndex = 5
            .Columns.Item("activo").Resizable = DataGridViewTriState.False
            .Columns.Item("activo").Width = "40"
        End With
        'relacionamos los cuadros de texto con el bindingSource
        txtCodigo.DataBindings.Add("text", bsUnidad, "cod_uni")
        txtUnidad.DataBindings.Add("text", bsUnidad, "nom_uni")
        txtCantUnidad.DataBindings.Add("text", bsUnidad, "cant_uni")
        chkParaProduccion.DataBindings.Add("checked", bsUnidad, "esProduccion")
        chkParaCompra.DataBindings.Add("checked", bsUnidad, "esCompra")
        chkActivo.DataBindings.Add("checked", bsUnidad, "activo")
    End Sub
    Private Sub cmdAñadir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAñadir.Click
        habilitaDetalle()
        deshabilitaCabecera()
        dsUnidad.Tables("unidad").Columns("esProduccion").DefaultValue = False
        dsUnidad.Tables("unidad").Columns("esCompra").DefaultValue = False
        dsUnidad.Tables("unidad").Columns("activo").DefaultValue = True
        bsUnidad.AddNew()
        datos.DataSource = bsUnidad
        modoGrabar()
        txtCodigo.Refresh()
        txtUnidad.Refresh()
        chkActivo.Refresh()
        txtCodigo.Focus()
    End Sub
    Private Sub cmdGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGrabar.Click
        Try
            If validaIngreso() Then
                bsUnidad.EndEdit()
                daUnidad.Update(dsUnidad, "unidad")
                datos.Refresh()
                deshabilitaDetalle()
                habilitaCabecera()
                modoAñadir()
                datos.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            bsUnidad.CancelEdit()
            datos.Refresh()
            deshabilitaDetalle()
            habilitaCabecera()
            modoAñadir()
            datos.Focus()
        End Try
    End Sub
    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        bsUnidad.CancelEdit()
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
        If bsUnidad.Count > 0 Then
            Dim mUnidad As New Unidad, exist As Boolean, rpta As Integer
            exist = mUnidad.existeEnCatalogo(Trim(txtCodigo.Text))
            If Not exist Then
                rpta = MessageBox.Show("¿Esta seguro de Eliminar el ITEM Seleccionado...", "SGA", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                If rpta = 6 Then
                    If bsUnidad.Count > 0 Then
                        bsUnidad.RemoveCurrent()
                        daUnidad.Update(dsUnidad, "unidad")
                        datos.Refresh()
                    End If
                End If
            Else
                MessageBox.Show("El Registro Tiene Datos Relacionados..." + Chr(13) + "!NO Es posible eliminarlo¡", "CEFE", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button2)
            End If
        End If
    End Sub
    Function validaIngreso()
        Dim validado As Boolean = False
        If Len(txtCodigo.Text) > 0 Then
            If Len(txtUnidad.Text) > 0 Then
                validado = True
            Else
                MessageBox.Show("Ingrese la Unidad de Medida...", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtUnidad.Focus()
            End If
        Else
            MessageBox.Show("Ingrese el Código...", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCodigo.Focus()
        End If
        Return validado
    End Function
    Private Sub cmdEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEditar.Click
        If bsUnidad.Count > 0 Then
            habilitaDetalle()
            deshabilitaCabecera()
            modoGrabar()
            txtCodigo.Focus()
        End If
    End Sub
    Private Sub txtCodigo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.GotFocus
        general.ingresaTexto(txtCodigo)
    End Sub
    Private Sub txtCodigo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.LostFocus
        If Len(txtCodigo.Text) > 0 Then
            txtCodigo.Text = Microsoft.VisualBasic.Right("000" + Trim(txtCodigo.Text), 3)
        End If
        general.saleTexto(txtCodigo)
    End Sub
    Private Sub txtunidad_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUnidad.GotFocus
        general.ingresaTexto(txtUnidad)
    End Sub
    Private Sub txtunidad_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUnidad.LostFocus
        general.saleTexto(txtUnidad)
    End Sub
    Private Sub txtCantUnidad_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCantUnidad.GotFocus
        general.ingresaTexto(txtCantUnidad)
    End Sub
    Private Sub txtCantUnidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantUnidad.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not (e.KeyChar = ChrW(Keys.Back)) And Not (e.KeyChar.Equals(sepDecimal)) Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub txtCantUnidad_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCantUnidad.LostFocus
        general.saleTexto(txtCantUnidad)
    End Sub
    Sub habilitaDetalle()

        lblUnidad.ForeColor = Color.Maroon
        lblCantUnidad.ForeColor = Color.Maroon
        txtCodigo.BackColor = Color.White
        txtCodigo.ReadOnly = False
        txtUnidad.BackColor = Color.White
        txtUnidad.ReadOnly = False
        txtCantUnidad.BackColor = Color.White
        txtCantUnidad.ReadOnly = False
        chkParaProduccion.Enabled = True
        chkParaCompra.Enabled = True
        chkActivo.Enabled = True
    End Sub
    Sub deshabilitaDetalle()

        lblUnidad.ForeColor = Color.Black
        lblCantUnidad.ForeColor = Color.Black
        txtCodigo.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        txtCodigo.ReadOnly = True
        txtUnidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        txtUnidad.ReadOnly = True
        txtCantUnidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        txtCantUnidad.ReadOnly = True
        chkParaProduccion.Enabled = False
        chkParaCompra.Enabled = False
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

    Private Sub txtCodigo_TextChanged(sender As Object, e As EventArgs) Handles txtCodigo.TextChanged

    End Sub

    Private Sub lblCodigo_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim munidad As New Unidad
        txtCodigo.Text = munidad.maxCodigo()
    End Sub
End Class
