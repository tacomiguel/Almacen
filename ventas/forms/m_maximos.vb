Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Math
Imports libreriaClases
Public Class m_maximos
    Private dsMaximos As New DataSet
    Private dsAlmacen As New DataSet
    Private dsArea As New DataSet
    Private estaCargando As Boolean = True
    'para validar el separador decimal
    Private sepDecimal As Char
    Private Sub m_maximos_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        principal.ma_maximos.Enabled = True
    End Sub
    Private Sub m_maximos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Top = 0
        Me.Left = 0
        'capturamos el separador decimal
        sepDecimal = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        Dim daAlmacen As New MySqlDataAdapter
        Dim cad As String
        If pAlmaUser = "0000" Then 'todos los almacenes
            cad = "select cod_alma,nom_alma from almacen where (esCatalogo) and activo=1 order by nom_alma"
        Else
            cad = "select cod_alma,nom_alma from almacen " _
                & " where almaCatalogo='" & pAlmaUser & "'" _
                & " and(esCatalogo) and activo=1 order by nom_alma"
        End If
        Dim comAlmacen As New MySqlCommand(cad, dbConex)
        daAlmacen.SelectCommand = comAlmacen
        daAlmacen.Fill(dsAlmacen, "almacen")
        With cboAlmacen
            .DataSource = dsAlmacen.Tables("almacen")
            .DisplayMember = dsAlmacen.Tables("almacen").Columns("nom_alma").ToString
            .ValueMember = dsAlmacen.Tables("almacen").Columns("cod_alma").ToString
            If dsAlmacen.Tables("almacen").Rows.Count > 0 Then
                .SelectedIndex = 0
            End If
        End With
        muestraAreas()
        If cboArea.SelectedIndex = -1 Then
            cboArea.Enabled = False
        Else
            cboArea.Enabled = True
        End If
        muestraMaximos()
        estaCargando = False
    End Sub
    Sub muestraAreas()
        dsArea.Clear()
        Dim daArea As New MySqlDataAdapter
        Dim cad As String = "Select cod_area,nom_area from area where cod_alma='" _
                        & cboAlmacen.SelectedValue & "' and (tieneIdeales) and activo=1 order by nom_area"
        Dim comArea As New MySqlCommand(cad, dbConex)
        daArea.SelectCommand = comArea
        daArea.Fill(dsArea, "area")
        With cboArea
            .DataSource = dsArea.Tables("area")
            .DisplayMember = dsArea.Tables("area").Columns("nom_area").ToString
            .ValueMember = dsArea.Tables("area").Columns("cod_area").ToString
            If dsArea.Tables("area").Rows.Count > 0 Then
                .SelectedIndex = 0
            Else
                .SelectedIndex = -1
            End If
        End With
    End Sub
    Sub muestraMaximos()
        Dim mAlmacen As New Almacen
        dsMaximos.Clear()
        Dim cAlmacen As String
        Dim cProduc As Boolean = IIf(chkProduccion.Checked = True, False, True)
        Dim xArea As Boolean = IIf(chkarea.Checked = True, True, False)
        If xArea = True Then
            cAlmacen = cboAlmacen.SelectedValue
        Else
            cAlmacen = mAlmacen.devuelveAlmacenCatalogo(cboAlmacen.SelectedValue)
        End If
        dsMaximos = mAlmacen.recuperaMaximos_xAlmacen(pCatalogoXalmacen, cAlmacen, xArea, cProduc, cboArea.SelectedValue)
        dataDetalle.DataSource = dsMaximos.Tables("maximos").DefaultView
        estructuraMaximos()
    End Sub
    Sub estructuraMaximos()
        With dataDetalle
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_art").HeaderText = "Código"
            .Columns("cod_art").Width = 55
            .Columns("cod_art").ReadOnly = True
            .Columns("cod_art").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("nom_art").HeaderText = "Descripción"
            .Columns("nom_art").Width = 269
            .Columns("nom_art").ReadOnly = True
            .Columns("nom_uni").HeaderText = "Unidad"
            .Columns("nom_uni").Width = 60
            .Columns("nom_uni").ReadOnly = True
            .Columns("nom_uni").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("maximo").HeaderText = "Cantidad Maximo"
            .Columns("maximo").Width = 55
            .Columns("maximo").ReadOnly = False
            .Columns("maximo").DefaultCellStyle.BackColor = Color.AliceBlue
            .Columns("maximo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("minimo").HeaderText = "Cantidad Minimo"
            .Columns("minimo").Width = 55
            .Columns("minimo").ReadOnly = False
            .Columns("minimo").DefaultCellStyle.BackColor = Color.AliceBlue
            .Columns("minimo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("pre_costomax").HeaderText = "Costo Maximo"
            .Columns("pre_costomax").Width = 55
            .Columns("pre_costomax").ReadOnly = False
            .Columns("pre_costomax").DefaultCellStyle.BackColor = Color.AliceBlue
            .Columns("pre_costomax").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("pre_costomin").HeaderText = "Costo Minimo"
            .Columns("pre_costomin").Width = 55
            .Columns("pre_costomin").ReadOnly = False
            .Columns("pre_costomin").DefaultCellStyle.BackColor = Color.AliceBlue
            .Columns("pre_costomin").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        End With
    End Sub
    Private Sub cmdActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdActualizar.Click
        Dim dsCatalogo As New DataSet
        Dim mCatalogo As New Catalogo, mAlmacen As New Almacen, ordenArea, ordenAlma As Integer, porcent As Integer
        Dim lArea, lArticulo As String, I As Integer = 0, lExiste As Boolean
        If dsArea.Tables("area").Rows.Count > 0 Then
            If cboArea.SelectedIndex >= 0 Then
                barraProgreso.Visible = True
                barraProgreso.Value = 1
                ordenAlma = cboAlmacen.SelectedIndex
                ordenArea = cboArea.SelectedIndex
                'capturamos el almacen seleccionado
                lArea = cboArea.SelectedValue
                Dim cod_catalogo As String = mAlmacen.devuelveAlmacenCatalogo(cboAlmacen.SelectedValue)
                dsCatalogo = mCatalogo.recuperaCatalogo(pCatalogoXalmacen, cod_catalogo, True, False, False, False, "", False, False, False)
                porcent = Int(dsCatalogo.Tables("articulo").Rows.Count / 100)
                If dsCatalogo.Tables("articulo").Rows.Count > 0 Then
                    For I = 0 To dsCatalogo.Tables("articulo").Rows.Count - 1
                        lArticulo = dsCatalogo.Tables("articulo").Rows(I).Item("cod_art").ToString
                        lExiste = mAlmacen.existeMaximos(lArticulo, lArea)
                        If Not lExiste Then
                            mAlmacen.insertaMaximos(lArticulo, lArea, 0, 0)
                        End If
                        If barraProgreso.Value < 100 Then
                            If I > barraProgreso.Value * porcent Then
                                barraProgreso.Value = barraProgreso.Value + 1
                                barraProgreso.Refresh()
                            End If
                        End If
                    Next
                End If
                cboAlmacen.SelectedIndex = -1
                cboAlmacen.SelectedIndex = ordenAlma
                cboArea.SelectedIndex = ordenArea
                barraProgreso.Visible = False
                MessageBox.Show("Actualización Finalizada...", "CEFE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Seleccione Area...", "CEFE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("No Hay Areas Registradas...", "CEFE", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged
        Dim valor As String = txtBuscar.Text
        If optCodigo.Checked = True Then
            dsMaximos.Tables("maximos").DefaultView.RowFilter = "cod_art LIKE '" & valor & "%'"
            If dataDetalle.RowCount > 0 Then
                dataDetalle.CurrentCell = dataDetalle("cod_art", dataDetalle.CurrentRow.Index)
            End If
        Else
            dsMaximos.Tables("maximos").DefaultView.RowFilter = "nom_art LIKE '" & valor & "%'"
            If dataDetalle.RowCount > 0 Then
                dataDetalle.CurrentCell = dataDetalle("nom_art", dataDetalle.CurrentRow.Index)
            End If
        End If
    End Sub
    Private Sub dataDetalle_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataDetalle.CellEndEdit
        Dim codigo, cAlmacen, carea As String
        Dim cmaximo, cminimo, pmaximo, pminimo As Decimal
        If dataDetalle.CurrentCell.ColumnIndex = dataDetalle.Columns("pre_costomax").Index Or dataDetalle.CurrentCell.ColumnIndex = dataDetalle.Columns("pre_costomin").Index Or _
                 dataDetalle.CurrentCell.ColumnIndex = dataDetalle.Columns("maximo").Index Or dataDetalle.CurrentCell.ColumnIndex = dataDetalle.Columns("minimo").Index Then
            If IsDBNull(dataDetalle("maximo", dataDetalle.CurrentRow.Index).Value) Then
                cmaximo = 0
                dataDetalle("maximo", dataDetalle.CurrentRow.Index).Value = 0
            Else
                cmaximo = dataDetalle("maximo", dataDetalle.CurrentRow.Index).Value
            End If
            If IsDBNull(dataDetalle("minimo", dataDetalle.CurrentRow.Index).Value) Then
                cminimo = 0
                dataDetalle("minimo", dataDetalle.CurrentRow.Index).Value = 0
            Else
                cminimo = dataDetalle("minimo", dataDetalle.CurrentRow.Index).Value
            End If
            If IsDBNull(dataDetalle("pre_costomax", dataDetalle.CurrentRow.Index).Value) Then
                pmaximo = 0
                dataDetalle("pre_costomax", dataDetalle.CurrentRow.Index).Value = 0
            Else
                pmaximo = dataDetalle("pre_costomax", dataDetalle.CurrentRow.Index).Value
            End If
            If IsDBNull(dataDetalle("pre_costomin", dataDetalle.CurrentRow.Index).Value) Then
                pminimo = 0
                dataDetalle("pre_costomin", dataDetalle.CurrentRow.Index).Value = 0
            Else
                pminimo = dataDetalle("pre_costomin", dataDetalle.CurrentRow.Index).Value
            End If
            Dim mAlmacen As New Almacen
            codigo = dataDetalle("cod_art", dataDetalle.CurrentRow.Index).Value
            cAlmacen = cboAlmacen.SelectedValue
            carea = cboArea.SelectedValue
            'If carea = "" Then
            '    mAlmacen.actualizaMaximos(codigo, cAlmacen, cmaximo, cminimo, pmaximo, pminimo)
            'Else
            If mAlmacen.existeMaximosxAlma(cAlmacen, carea, codigo) Then
                mAlmacen.actualizaMaximosxAlma(codigo, cAlmacen, carea, cmaximo, cminimo)
            Else
                mAlmacen.insertaMaximosxAlma(codigo, cAlmacen, carea, cmaximo, cminimo)
            End If
            'If mAlmacen.existeMaximos(codigo, cAlmacen) Then
            'mAlmacen.actualizaMaximos(codigo, cAlmacen, cmaximo, cminimo, pmaximo, pminimo)
            'Else

            'mMaximo.insertaMaximos(codigo, cAlmacen, maximo, minimo)
            'End If
        End If
    End Sub
    Private Sub dataDetalle_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dataDetalle.EditingControlShowing
        'referenciamos la celda
        Dim validar As TextBox = CType(e.Control, TextBox)
        'agregamos el controlador de eventos para el evento KeyPress
        AddHandler validar.KeyPress, AddressOf validar_KeyPress
    End Sub
    Private Sub validar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dataDetalle.KeyPress
        'obtenemos el indice de la columna
        Dim columna As Integer = dataDetalle.CurrentCell.ColumnIndex
        If columna = dataDetalle.Columns("pre_costomax").Index Or columna = dataDetalle.Columns("pre_costomin").Index Then
            If Not Char.IsNumber(e.KeyChar) And Not (e.KeyChar = ChrW(Keys.Back)) And Not (e.KeyChar.Equals(sepDecimal)) Then
                e.KeyChar = ""
            End If
        End If
  

    End Sub
    Private Sub cboAlmacen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAlmacen.SelectedIndexChanged
        If Not estaCargando Then
            muestraAreas()
            If chkarea.Checked = True Then
                cboArea.Enabled = True
                If dsArea.Tables("area").Rows.Count > 0 Then
                    cboArea.SelectedIndex = 0
                End If
                cboArea.Focus()
            Else
                cboArea.SelectedIndex = -1
                cboArea.Enabled = False
            End If
            muestraMaximos()
        End If

    End Sub
    Private Sub cboArea_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboArea.SelectedIndexChanged
        If Not estaCargando Then
            muestraMaximos()
        End If
    End Sub
    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        Dim frm As New rptForm, mAlmacen As New Almacen
        Dim cAlmacen As String = cboAlmacen.SelectedValue
        Dim cArea As String = cboArea.SelectedValue
        Dim almacen As String = cboAlmacen.Text
        Dim cProduc As Boolean = IIf(chkProduccion.Checked = True, False, True)
        dsMaximos = mAlmacen.recuperaMaximos_xArea(cAlmacen, True, cProduc, cArea)
        dataDetalle.DataSource = dsMaximos.Tables("maximos").DefaultView
        frm.cargarMaximos(dsMaximos, cAlmacen, almacen)
        frm.MdiParent = principal
        frm.Show()
    End Sub

    Private Sub chkarea_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles chkarea.CheckedChanged
        If Not estaCargando Then
            If chkarea.Checked = True Then
                cboArea.Enabled = True
                If dsArea.Tables("area").Rows.Count > 0 Then
                    cboArea.SelectedIndex = 0
                End If
                cboArea.Focus()
            Else
                cboArea.SelectedIndex = -1
                cboArea.Enabled = False

            End If
        End If
        muestraMaximos()
    End Sub



    Private Sub chkProduccion_CheckedChanged(sender As Object, e As EventArgs) Handles chkProduccion.CheckedChanged
        If Not estaCargando Then
            If chkProduccion.CheckState = CheckState.Checked Then
                chkProduccion.Text = "Insumos"
            Else
                chkProduccion.Text = "Producciones"
            End If
            muestraMaximos()
            txtBuscar.Focus()
        End If
    End Sub



    Private Sub dataDetalle_KeyDown(sender As Object, e As KeyEventArgs) Handles dataDetalle.KeyDown
        If (e.Control And e.KeyCode = Keys.E) Then
            If dataDetalle.RowCount > 0 Then
                EnviaraExcel(dataDetalle)
            End If
        End If
    End Sub
End Class
