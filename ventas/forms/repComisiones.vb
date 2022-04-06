Imports MySql.Data.MySqlClient
Imports libreriaClases
Public Class repComisiones
    Private dsVendedor As New DataSet
    Private dtVendedor As New DataTable("vendedor")
    Private Sub repComisiones_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        principal.mr_comisiones.Enabled = True
    End Sub

    Private Sub repComisiones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Top = 0
        'dataset vendedor
        dsVendedor.Tables.Add(dtVendedor)
        Dim daVendedor As New MySqlDataAdapter
        Dim comVend As New MySqlCommand("select cod_vend,nom_vend from vendedor where activo=1", dbConex)
        daVendedor.SelectCommand = comVend
        daVendedor.Fill(dsVendedor, "vendedor")
        With cboVendedor
            .DataSource = dsVendedor.Tables("vendedor")
            .DisplayMember = dsVendedor.Tables("vendedor").Columns("nom_vend").ToString
            .ValueMember = dsVendedor.Tables("vendedor").Columns("cod_vend").ToString
            .SelectedIndex = -1
        End With
        Dim mes, anno As Integer
        mes = Month(pFechaActivaMax)
        anno = Year(pFechaActivaMax)
        cboMes.SelectedIndex = mes - 1
        cboAnno.SelectedIndex = anno - 2010
    End Sub
    Private Sub chkVendedor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkVendedor.CheckedChanged
        If chkVendedor.Checked = True Then
            cboVendedor.Enabled = True
            If dsVendedor.Tables("vendedor").Rows.Count > 0 Then
                cboVendedor.SelectedIndex = 0
            End If
            cboVendedor.Focus()
        Else
            cboVendedor.SelectedIndex = -1
            cboVendedor.Enabled = False
        End If
    End Sub

    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        Dim frm As New rptForm, anno As Integer, mes As Integer, xVendedor As Boolean, cod_vend As String, fechaComision As String
        If cboMes.SelectedIndex <> -1 Then
            If cboAnno.SelectedIndex <> -1 Then
                anno = cboAnno.SelectedIndex + 2010
                mes = cboMes.SelectedIndex + 1
                fechaComision = cboMes.Text + " " + cboAnno.Text
                If chkVendedor.Checked = True Then
                    xVendedor = True
                    cod_vend = cboVendedor.SelectedValue
                Else
                    xVendedor = False
                    cod_vend = ""
                End If
                frm.cargarComisiones(anno, mes, xVendedor, cod_vend, fechaComision)
                frm.MdiParent = principal
                frm.Show()
            Else
                MessageBox.Show("Seleccione el Año...", "CEFE", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                cboAnno.Focus()
            End If
        Else
            MessageBox.Show("Seleccione el Mes...", "CEFE", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            cboMes.Focus()
        End If
    End Sub

    Private Sub cmdCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCerrar.Click
        Me.Close()
    End Sub
End Class
