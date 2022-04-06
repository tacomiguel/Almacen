Imports MySql.Data
Imports libreriaClases
Public Class u_tipoCambio
    'para validar el separador decimal
    Private sepDecimal As Char

    Private Sub u_tipoCambio_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Dim mTC As New Tipocambio
        Dim tcambio As Decimal = mTC.recupera(pFechaSystem)
        txtTC.Text = tcambio
    End Sub
    Private Sub u_tipoCambio_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        principal.mu_tipoCambio.Enabled = True
    End Sub
    Private Sub u_tipoCambio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Top = 0
        'capturamos el separador decimal
        sepDecimal = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        lblFecha.Text = general.devuelveFechaImpresionEspecificado(pFechaSystem)
        estableceFechaProceso()
    End Sub
    Private Sub txtTC_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTC.GotFocus
        general.ingresaTextoProceso(txtTC)
    End Sub
    Private Sub txtTC_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTC.LostFocus
        general.saleTextoProceso(txtTC)
    End Sub
    Private Sub txtTC_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTC.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not (e.KeyChar = ChrW(Keys.Back)) And Not (e.KeyChar.Equals(sepDecimal)) Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Dim mTC As New TipoCambio
        Dim tcambio As Decimal
        If Len(txtTC.Text) = 0 Then
            tcambio = 0
        Else
            tcambio = txtTC.Text
        End If
        If mTC.existe(mcFIngreso.SelectedDate) Then
            mTC.actualizar(mcFIngreso.SelectedDate, tcambio, pCuentaUser)
        Else
            mTC.insertar(mcFIngreso.SelectedDate, tcambio, pCuentaUser)
        End If
        pTC = tcambio
        Dim tit As String = general.tituloVentanaPrincipal()
        principal.Text = tit
        principal.Refresh()
        MessageBox.Show("Tipo de Cambio Actualizado...", "Almacen", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub
    Sub estableceFechaProceso()
        Dim fechfinal As Date = Date.Now.AddDays(30)
        If pNivelUser = 0 Then
            mcFIngreso.MaxDate = fechfinal
            If pFechaActivaMin > Microsoft.VisualBasic.DateAndTime.DateAdd(DateInterval.Day, -pDiasModificarIngreso, pFechaSystem) Then
                mcFIngreso.MinDate = Microsoft.VisualBasic.DateAndTime.DateAdd(DateInterval.Day, -pDiasModificarIngreso, pFechaSystem)
            Else
                mcFIngreso.MinDate = pFechaActivaMin
            End If
        Else
            mcFIngreso.MinDate = Microsoft.VisualBasic.DateAndTime.DateAdd(DateInterval.Day, -pDiasModificarIngreso, pFechaSystem)
            mcFIngreso.MaxDate = fechfinal
        End If
        If Month(pFechaActivaMax) = Month(pFechaSystem) Then
            mcFIngreso.DisplayMonth = pFechaSystem
            mcFIngreso.SelectedDate = pFechaSystem
        Else
            mcFIngreso.DisplayMonth = pFechaActivaMax
            mcFIngreso.SelectedDate = pFechaActivaMax
        End If
    End Sub

    Private Sub mcFIngreso_ItemClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mcFIngreso.ItemClick
        lblFecha.Text = general.devuelveFechaImpresionEspecificado(mcFIngreso.SelectedDate)
    End Sub
End Class
