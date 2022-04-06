Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Math
Imports libreriaClases
Public Class p_cuenta_cobrar
    'Private periodoactivo As String = general.periodoActivo
    Private dsCuenta As New DataSet


    Private Sub p_cuenta_cobrar_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If dataCuenta.RowCount = 0 Then
            'dtpAmortizar.Enabled = False
            'dtpProgramar.Enabled = False
        End If
    End Sub
    Private Sub p_cuenta_cobrar_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        principal.mp_cuentaC.Enabled = True
    End Sub
    Private Sub p_cuentas_cobrar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '        dsCuenta = Cuenta.recuperaCuentaCobrar
        actualizadatagrid()
        With datacuenta
            .DataSource = dsCuenta.Tables("cuenta")
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("fec_doc").HeaderText = "Fecha"
            .Columns("fec_doc").Width = 70
            .Columns("fec_doc").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("fec_doc").ReadOnly = True
            .Columns("raz_soc").HeaderText = "Razón Social"
            .Columns("raz_soc").Width = 264
            .Columns("raz_soc").ReadOnly = True
            .Columns("doc").HeaderText = "Documento"
            .Columns("doc").Width = 104
            .Columns("doc").ReadOnly = True
            .Columns("monto").HeaderText = "Monto Facturado"
            .Columns("monto").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("monto").Width = 70
            .Columns("monto").ReadOnly = True
            .Columns("monto_pago").HeaderText = "Monto Amortizado"
            .Columns("monto_pago").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("monto_pago").Width = 70
            .Columns("monto_pago").ReadOnly = True
            .Columns("fec_prog").HeaderText = "Fecha Programada"
            .Columns("fec_prog").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("fec_prog").DefaultCellStyle.ForeColor = Color.White
            .Columns("fec_prog").ReadOnly = True
            '.Columns("fec_prog").DefaultCellStyle.BackColor = Color.SteelBlue
            .Columns("fec_prog").Width = 75
            .Columns("cant_prog").HeaderText = "Monto Programado"
            .Columns("cant_prog").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("cant_prog").DefaultCellStyle.ForeColor = Color.Cyan
            .Columns("cant_prog").ReadOnly = False
            .Columns("cant_prog").DefaultCellStyle.BackColor = Color.LightBlue
            .Columns("cant_prog").Width = 75
            .Columns("fec_pago").HeaderText = "Fecha de Pago"
            .Columns("fec_pago").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("fec_pago").DefaultCellStyle.ForeColor = Color.Blue
            '.Columns("fec_pago").DefaultCellStyle.BackColor = Color.SteelBlue
            .Columns("fec_pago").Width = 75
            .Columns("fec_pago").ReadOnly = True
            .Columns("cant_pago").HeaderText = "Monto Pagado"
            .Columns("cant_pago").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("cant_pago").DefaultCellStyle.ForeColor = Color.Blue
            .Columns("cant_pago").ReadOnly = True
            '.Columns("cant_pago").DefaultCellStyle.BackColor = Color.LightBlue
            .Columns("cant_pago").Width = 70
            .Columns("raz_soc").ReadOnly = True
            .Columns("cod_clie").Visible = False
            .Columns("cod_doc").Visible = False
            .Columns("nrodoc").Visible = False
            .Columns("proceso").Visible = False
            .Columns("cod_vend").Visible = False
            .Columns("nom_vend").Visible = False
            .Columns("operacion").Visible = False
        End With

    End Sub
    Private Sub cmdProgramar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdProgramar.Click
        Dim mCuenta As New Cuenta
        Dim montoFac As Decimal, cantProg As Decimal, fechaProg As Date
        Dim periodoactivo As String = datacuenta("proceso", datacuenta.CurrentRow.Index).Value
        Dim nroOpe As Integer = datacuenta("operacion", datacuenta.CurrentRow.Index).Value
        montoFac = dataCuenta("monto", dataCuenta.CurrentRow.Index).Value
        fechaProg = IIf(IsDBNull(dataCuenta("fec_prog", dataCuenta.CurrentRow.Index).Value), #9/4/1970#, dataCuenta("fec_prog", dataCuenta.CurrentRow.Index).Value)
        If Microsoft.VisualBasic.Len(txtProgramar.Text) > 0 Then
            cantProg = txtProgramar.Text
            If cantProg > montoFac Then
                MessageBox.Show("La Cantidad Programada NO puede ser Mayor al Monto Facturado...", "CEFE", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtProgramar.Focus()
                Exit Sub
            End If
        Else
            cantProg = montoFac
        End If
        If fechaProg = #9/4/1970# Then 'no hay programacion
            mCuenta.insertarCC(periodoactivo, nroOpe, 0, dtpProgramar.Value, cantProg, #9/4/1970#, 0, pCuentaUser)
        Else
            mCuenta.actualizarCC(periodoactivo, nroOpe, 0, dtpProgramar.Value, cantProg, #9/4/1970#, 0, "", "", "", "")
        End If
        actualizadatagrid()

    End Sub
    Private Sub dtpProgramar_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtpProgramar.MouseDown
        'determinamos desde cuando se puede seleccionar la fecha de programacion
        Dim fechaDoc, fechaProg As Date
        fechaDoc = dataCuenta("fec_doc", dataCuenta.CurrentRow.Index).Value
        fechaProg = IIf(IsDBNull(dataCuenta("fec_prog", dataCuenta.CurrentRow.Index).Value), #9/4/1970#, dataCuenta("fec_prog", dataCuenta.CurrentRow.Index).Value)
        If fechaProg = #9/4/1970# Then 'aun no se ha pagado
            Dim mes As Integer = Month(pFechaActivaMax), anno As Integer = Year(pFechaActivaMax)
            If Month(fechaDoc) = mes And Year(fechaDoc) = anno Then
                dtpProgramar.MinDate = fechaDoc
            Else
                dtpProgramar.Value = "#1/" & mes & "/" & anno & "#"
                dtpProgramar.MinDate = "#1/" & mes & "/" & anno & "#"
            End If
        Else
            limpia()
        End If
    End Sub
    Private Sub dtpProgramar_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpProgramar.ValueChanged
        If dtpProgramar.Checked = True Then
            cmdProgramar.Enabled = True
            txtProgramar.Enabled = True
            Dim montofac As Decimal
            montofac = dataCuenta("monto", dataCuenta.CurrentRow.Index).Value
            txtProgramar.Text = montofac
        Else
            cmdProgramar.Enabled = False
            txtProgramar.Text = ""
            txtProgramar.Enabled = False
        End If
    End Sub
    Private Sub cmdAmortizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAmortizar.Click
        Dim rpta As Integer
        rpta = MessageBox.Show("Esta seguro de Amortizar la Cuenta..." + Chr(13) + "Este proceso es Irreversible...", "Cefe", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        If rpta = 6 Then
            amotizardoc()
            actualizadatagrid()
        End If
    End Sub
    Private Sub dtpAmortizar_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtpAmortizar.MouseDown
        'verificamos q exista programacion
        Dim fechaProg As Date
        fechaProg = IIf(IsDBNull(dataCuenta("fec_prog", dataCuenta.CurrentRow.Index).Value), #9/4/1970#, dataCuenta("fec_prog", dataCuenta.CurrentRow.Index).Value)
        If fechaProg = #9/4/1970# Then
            limpia()
            dtpProgramar.Focus()
        Else
            'determinamos desde que fecha se puede amortizar
            Dim fechaDoc As Date, monto, montoPago As Decimal
            fechaDoc = dataCuenta("fec_doc", dataCuenta.CurrentRow.Index).Value
            montoPago = datacuenta("cant_pago", datacuenta.CurrentRow.Index).Value
            monto = datacuenta("monto", datacuenta.CurrentRow.Index).Value
            Dim mes As Integer = Month(pFechaActivaMax), anno As Integer = Year(pFechaActivaMax)
            If montoPago < monto Then
                If Month(fechaDoc) = mes And Year(fechaDoc) = anno Then
                    'solo se puede amortizar desde la fecha de facturacion hacia adelante
                    dtpAmortizar.MinDate = fechaDoc
                Else
                    'solo se puede amortizar desde el mes activo hacia adelante
                    'dtpAmortizar.MinDate = "#1/" & mes & "/" & anno & "#"
                    dtpAmortizar.MinDate = fechaDoc.AddDays(-pDiasModificarIngreso)
                    ' dtpAmortizar.MaxDate = pFechaActivaMax
                End If
            Else
                limpia()
            End If
        End If
    End Sub

    Private Sub dtpAmortizar_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles dtpAmortizar.Validating

    End Sub
    Private Sub dtpAmortizar_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpAmortizar.ValueChanged
        If dtpAmortizar.Checked = True Then
            cmdAmortizar.Enabled = True
            txtAmortizar.Enabled = True
            TxtOperacion.Enabled = True
            calculaTotal()

        Else
            cmdAmortizar.Enabled = False
            txtAmortizar.Text = ""
            txtAmortizar.Enabled = False
            TxtOperacion.Text = ""
            TxtOperacion.Enabled = False
        End If
    End Sub
    Sub limpia()
        cmdProgramar.Enabled = False
        txtProgramar.Text = ""
        txtProgramar.Enabled = False
        dtpProgramar.Checked = False
        cmdAmortizar.Enabled = False
        txtAmortizar.Text = ""
        txtAmortizar.Enabled = False
        TxtOperacion.Text = ""
        TxtOperacion.Enabled = False
        dtpAmortizar.Checked = False
        coloreafilas()
    End Sub
    Private Sub dataCuenta_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        limpia()
    End Sub

    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        Dim frm As New rptForm
        Dim xcancelado As Boolean = IIf(optctaxcobrar.Checked = True, True, False)
        frm.cargarCuentaCobrar(xcancelado)
        frm.MdiParent = principal
        frm.Show()
    End Sub

    Sub coloreafilas()
        For Each row As DataGridViewRow In dataCuenta.Rows
            If Not IsDBNull(row.Cells("fec_prog").Value) Then
                If row.Cells("fec_prog").Value < pFechaSystem Then
                    row.DefaultCellStyle.BackColor = Color.Red
                Else
                    row.DefaultCellStyle.BackColor = Color.Green
                End If
            End If
        Next
    End Sub
    Sub amotizardoc()
        Dim mCuenta As New Cuenta
        Dim cad As String
        'Dim cantPago As Decimal = txtAmortizar.Text
        Dim mfecha As String = dtpAmortizar.Value.ToString("yy-MM-dd")
        Dim norden As Integer = mCuenta.maxOperacion()
        Try
            For Each row As DataGridViewRow In datacuenta.Rows
                If row.Selected = True Then
                    Dim monto As Decimal = row.Cells("monto").Value
                    Dim monto_pago As Decimal = row.Cells("monto_pago").Value
                    Dim cant_prog As Decimal = row.Cells("cant_prog").Value
                    Dim nroOpe As Integer = row.Cells("operacion").Value
                    Dim periodo As String = row.Cells("proceso").Value
                    Dim coddoc As String = row.Cells("cod_doc").Value
                    Dim numdoc As String = row.Cells("nrodoc").Value
                    Dim codclie As String = row.Cells("cod_clie").Value
                    Dim obs As String = TxtOperacion.Text
                    Dim lcancelado As Integer = IIf((monto - monto_pago) = cant_prog, 1, 0)

                    mCuenta.actualizarCC(periodo, nroOpe, norden, row.Cells("fec_prog").Value, cant_prog, dtpAmortizar.Value, cant_prog, coddoc, numdoc, codclie, obs)

                    If lcancelado = 0 Then
                        mCuenta.insertarCC(periodo, nroOpe, 0, dtpAmortizar.Value.AddDays(10), 0, #9/4/1970#, 0, pCuentaUser)
                    End If


                    Dim esHistorial As Boolean = IIf(periodo < periodoActivo(), True, False)
                    If esHistorial Then
                        cad = "update h_salida set cancelado=" & lcancelado & ",fec_pago='" & mfecha & "'," & "monto_pago= monto_pago + " & cant_prog & " where proceso='" & periodo & "' and  operacion=" & nroOpe
                    Else
                        cad = "update salida set cancelado=" & lcancelado & ",fec_pago='" & mfecha & "'," & "monto_pago= monto_pago+" & cant_prog & " where operacion=" & nroOpe
                    End If

                    Dim com As New MySqlCommand(cad, dbConex)
                    com.ExecuteNonQuery()
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub calculaTotal()
        Dim lTotal As Decimal = 0
        For Each row As DataGridViewRow In datacuenta.Rows
            If row.Selected = True Then
                lTotal = lTotal + row.Cells("cant_prog").Value
            End If
        Next
        txtAmortizar.Text = Round(lTotal, pDecimales)
    End Sub

    Sub actualizadatagrid()
        dsCuenta = Cuenta.recuperaCuentaCobrar(periodoActivo, True)
        datacuenta.DataSource = dsCuenta.Tables("cuenta")
        datacuenta.Refresh()
        limpia()
        datacuenta.Focus()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        coloreafilas()
    End Sub


    Private Sub datacuenta_ColumnHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles datacuenta.ColumnHeaderMouseClick
        coloreafilas()
    End Sub

    Private Sub datacuenta_GotFocus1(ByVal sender As Object, ByVal e As System.EventArgs) Handles datacuenta.GotFocus
        limpia()
    End Sub


    Private Sub datacuenta_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datacuenta.CellContentClick

    End Sub

    Private Sub chkCuentaCobrar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub chkDetalle_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class
