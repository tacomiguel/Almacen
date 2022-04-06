Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Math
Imports libreriaClases
Public Class u_actLotes
    Private dsProducto As New DataSet
    Private dsSalidas As New DataSet
    Private Sub u_actLotes_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        principal.mu_actLotes.Enabled = True
    End Sub
    Private Sub u_actLotes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Top = 0
        Me.Left = 0
    End Sub
    Function muestraIngresosProducto() As DataSet
        Dim com As New MySqlCommand
        Dim da As New MySqlDataAdapter
        Dim ds As New DataSet
        Dim codigo As String = txtBuscar.Text
        Dim cad, cad1, cad2, cad3, cad4, cad5, cad6, cad7 As String
        cad1 = "select nom_doc,ser_doc,nro_doc,fec_doc,ingreso_det.cod_art,nom_art,nom_uni,cant," _
                & " ingreso_det.saldo,ingreso"
        cad2 = " from ingreso inner join ingreso_det on ingreso.operacion=ingreso_det.operacion"
        cad3 = " inner join articulo on articulo.cod_art=ingreso_det.cod_art"
        cad4 = " inner join unidad on articulo.cod_uni=unidad.cod_uni"
        cad5 = " inner join documento_i on ingreso.cod_doc=documento_i.cod_doc"
        cad6 = " where ingreso_det.cod_art='" & codigo & "' and ((esingreso) or ingreso.cod_doc='10')"
        cad7 = " order by fec_doc"
        cad = cad1 + cad2 + cad3 + cad4 + cad5 + cad6 + cad7
        com.CommandText = cad
        com.Connection = dbConex
        da.SelectCommand = com
        da.Fill(ds, "articulo")
        Return ds
    End Function
    Sub estructuraProducto()
        With dataProducto
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("fec_doc").HeaderText = "Fecha"
            .Columns("fec_doc").Width = 70
            .Columns("fec_doc").ReadOnly = True
            .Columns("fec_doc").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("ingreso").HeaderText = "Ing."
            .Columns("ingreso").Width = 50
            .Columns("ingreso").ReadOnly = True
            .Columns("ingreso").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_art").HeaderText = "Código"
            .Columns("cod_art").Width = 50
            .Columns("cod_art").ReadOnly = True
            .Columns("cod_art").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("nom_art").HeaderText = "Descripción"
            .Columns("nom_art").Width = 250
            .Columns("nom_art").ReadOnly = True
            .Columns("nom_uni").HeaderText = "Unidad"
            .Columns("nom_uni").Width = 60
            .Columns("nom_uni").ReadOnly = True
            .Columns("nom_uni").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cant").HeaderText = "Cant."
            .Columns("cant").Width = 60
            .Columns("cant").ReadOnly = True
            .Columns("cant").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("saldo").DefaultCellStyle.BackColor = Color.AliceBlue
            .Columns("saldo").HeaderText = "Saldo"
            .Columns("saldo").Width = 60
            .Columns("saldo").ReadOnly = True
            .Columns("saldo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("saldo").DefaultCellStyle.BackColor = Color.AliceBlue
            .Columns("nom_doc").HeaderText = "Docmento"
            .Columns("nom_doc").Width = 100
            .Columns("nom_doc").ReadOnly = True
            .Columns("ser_doc").HeaderText = "Serie"
            .Columns("ser_doc").Width = 60
            .Columns("ser_doc").ReadOnly = True
            .Columns("nro_doc").HeaderText = "Numero"
            .Columns("nro_doc").Width = 100
            .Columns("nro_doc").ReadOnly = True
        End With
    End Sub
    Function muestraSalidas() As DataSet
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter
        Dim com As New MySqlCommand
        Dim cad As String
        Dim nIngreso As Integer = dataProducto("ingreso", dataProducto.CurrentRow.Index).Value
        cad = " select fec_doc,salida,salida_det.operacion,ingreso,cod_art,cant from salida inner join salida_det" _
                & " on salida.operacion=salida_det.operacion " _
                & " where ingreso=" & nIngreso & " order by salida"
        com.CommandText = cad
        com.Connection = dbConex
        da.SelectCommand = com
        da.Fill(ds, "salidas")
        Return ds
    End Function
    Sub estructuraSalidas()
        With dataSalidas
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("fec_doc").HeaderText = "fecha"
            .Columns("fec_doc").Width = 70
            .Columns("fec_doc").ReadOnly = True
            .Columns("salida").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("salida").HeaderText = "Sal."
            .Columns("salida").Width = 50
            .Columns("salida").ReadOnly = True
            .Columns("salida").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("operacion").HeaderText = "Ope."
            .Columns("operacion").Width = 50
            .Columns("operacion").ReadOnly = True
            .Columns("operacion").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("ingreso").HeaderText = "Ing."
            .Columns("ingreso").Width = 50
            .Columns("ingreso").ReadOnly = True
            .Columns("ingreso").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_art").HeaderText = "cod_art"
            .Columns("cod_art").Width = 60
            .Columns("cod_art").ReadOnly = True
            .Columns("cod_art").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cant").HeaderText = "Cant."
            .Columns("cant").Width = 60
            .Columns("cant").ReadOnly = True
            .Columns("cant").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        End With
    End Sub
    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
        dsProducto.Clear()
        dsProducto = muestraIngresosProducto()
        dataProducto.DataSource = dsProducto.Tables("articulo").DefaultView
        estructuraProducto()
    End Sub
    Private Sub cmdSalidas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalidas.Click
        dsSalidas.Clear()
        dsSalidas = muestraSalidas()
        dataSalidas.DataSource = dsSalidas.Tables("salidas").DefaultView
        estructuraSalidas()
    End Sub
    Private Sub cmdActualiza_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdActualiza.Click
        Dim com As New MySqlCommand
        Dim cad As String
        Dim nIngreso As Integer = txtIngreso.Text
        If Len(nIngreso) > 0 Then
            Dim nSalida As Integer = dataSalidas("salida", dataSalidas.CurrentRow.Index).Value
            cad = "update salida_det set ingreso=" & nIngreso & " where salida =" & nSalida
            com.CommandText = cad
            com.Connection = dbConex
            com.ExecuteNonQuery()
            cad = "update salida_det set cant=cant+1 where salida =" & nSalida
            com.CommandText = cad
            com.Connection = dbConex
            com.ExecuteNonQuery()
            cad = "update salida_det set cant=cant-1 where salida =" & nSalida
            com.CommandText = cad
            com.Connection = dbConex
            com.ExecuteNonQuery()
        Else
            txtIngreso.Focus()
        End If
    End Sub

    Private Sub cmdCoherencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCoherencia.Click
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter
        Dim com As New MySqlCommand
        com.Connection = dbConex
        Dim cad, cad1, cad2, cad3, cad4, cad5 As String
        cad1 = "select salida_det.ingreso,salida_det.cod_art,ingreso_det.cant,ingreso_det.saldo,sum(salida_det.cant) as salidas,"
        cad2 = " ingreso_det.cant-sum(salida_det.cant) as saldo2"
        cad3 = " from ingreso_det inner join salida_det on ingreso_det.ingreso=salida_det.ingreso"
        cad4 = " group by salida_det.ingreso,salida_det.cod_art"
        cad5 = " having(ingreso_det.saldo < ingreso_det.cant - sum(salida_det.cant) Or ingreso_det.cant - sum(salida_det.cant) < 0)"
        cad = cad1 + cad2 + cad3 + cad4 + cad5
        com.CommandText = cad
        da.SelectCommand = com
        da.Fill(ds, "coherencia")
        dataCoherencia.DataSource = ds.Tables("coherencia").DefaultView
    End Sub
End Class
