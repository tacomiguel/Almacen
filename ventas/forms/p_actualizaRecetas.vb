Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Math
Imports libreriaClases
Public Class p_actualizaRecetas
    Private dsInsumo As New DataSet
    'para validar el separador decimal
    Private sepDecimal As Char
    Private Sub p_actualizaRecetas_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        principal.mp_actualizaRecetas.Enabled = True
    End Sub
    Private Sub p_actualizaRecetas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Top = 0
        Me.Left = 0
        'capturamos el separador decimal
        sepDecimal = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        dataInsumo.DefaultCellStyle.ForeColor = Color.Black
        dataInsumo.DefaultCellStyle.SelectionForeColor = Color.Black
        dataInsumo.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Dim mCatalogo As New Catalogo
        dsInsumo = mCatalogo.recuperaProducto(pCatalogoXalmacen, cboAlmacen.SelectedValue, "ads-3f")
        dataInsumo.DataSource = dsInsumo.Tables("articulo").DefaultView
        cargaEstructuraInsumos()
    End Sub
    Sub cargaEstructuraInsumos()
        With dataInsumo
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_art").HeaderText = "Codigo"
            .Columns("cod_art").Width = 50
            .Columns("cod_art").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("nom_art").HeaderText = "Descripcion"
            .Columns("nom_art").Width = 260
            .Columns("nom_uni").HeaderText = "Unidad"
            .Columns("nom_uni").Width = 60
            .Columns("pre_prom").HeaderText = "Costo"
            .Columns("pre_prom").Width = 80
            .Columns("pre_prom").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("cod_uni").Visible = False
            .Columns("cant_uni").Visible = False
            .Columns("pre_costo").Visible = False
            .Columns("pre_ult").Visible = False
            .Columns("pre_venta").Visible = False
            .Columns("cuenta_v").Visible = False
            .Columns("cuenta_c").Visible = False
            .Columns("maximo").Visible = False
            .Columns("minimo").Visible = False
            .Columns("afecto_igv").Visible = False
            '.Columns("activo").Visible = False
        End With
    End Sub
    Private Sub txtBuscarInsumo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscarInsumo.GotFocus
        txtBuscarInsumo.SelectAll()
        dsInsumo.Clear()
        Dim mCatalogo As New Catalogo

        dsInsumo = mCatalogo.recuperaProducto(pCatalogoXalmacen, cboAlmacen.SelectedValue, txtBuscarInsumo.Text)
        

        dataInsumo.DataSource = dsInsumo.Tables("articulo").DefaultView
        cargaEstructuraInsumos()
    End Sub
    Private Sub txtBuscarInsumo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscarInsumo.TextChanged
        Dim valor As String = txtBuscarInsumo.Text
        dsInsumo.Tables("articulo").DefaultView.RowFilter = "nom_art LIKE '" & valor & "%'"
        If dataInsumo.RowCount > 0 Then
            dataInsumo.CurrentCell = dataInsumo("nom_art", dataInsumo.CurrentRow.Index)
        End If
    End Sub
End Class
