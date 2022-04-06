Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Math
Imports libreriaClases
Public Class m_rendimiento
    Dim dsLimpios As New DataSet
    Private Sub m_rendimiento_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        principal.ma_rendimiento.Enabled = True
    End Sub
    Private Sub m_rendimiento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Left = 0
        Me.Top = 0
        muestraLimpios()
    End Sub
    Sub muestraLimpios()
        Dim da As New MySqlDataAdapter
        Dim cad, cad1, cad2, cad3, cad4 As String
        cad1 = " select articulo.cod_art,nom_art,nom_uni"
        cad2 = " from articulo inner join unidad on articulo.cod_uni=unidad.cod_uni"
        cad3 = " left join art_limpio on articulo.cod_uni=unidad.cod_uni"
        cad4 = " where(es_limpio)"
        cad = cad1 + cad2 + cad3 + cad4
        Dim com As New MySqlCommand(cad)
        com.Connection = dbConex
        da.SelectCommand = com
        da.Fill(dsLimpios, "articulo")
        dataLimpios.DataSource = dsLimpios.Tables("articulo")
        estructuraLimpios()
    End Sub
    Sub estructuraLimpios()
        With dataLimpios
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_art").HeaderText = "Código"
            .Columns("cod_art").Width = 55
            .Columns("cod_art").ReadOnly = True
            .Columns("cod_art").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("nom_art").HeaderText = "Descripción"
            .Columns("nom_art").Width = 270
            .Columns("nom_art").ReadOnly = True
            .Columns("nom_uni").HeaderText = "Unidad"
            .Columns("nom_uni").Width = 60
            .Columns("nom_uni").ReadOnly = True
            .Columns("nom_uni").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            '.Columns("rendimiento").HeaderText = "Rendimiento"
            '.Columns("rendimiento").Width = 75
            '.Columns("rendimiento").ReadOnly = True
            '.Columns("rendimiento").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        End With
    End Sub
End Class
