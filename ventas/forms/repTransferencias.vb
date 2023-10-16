Imports MySql.Data.MySqlClient
Imports libreriaClases
Public Class repTransferencias
    Private dsAlmacenO As New DataSet
    Private dsAlmacenD As New DataSet
    Private dsProducto As New DataSet
    Private dsUsuario As New DataSet
    Private dsTransferencias As New DataSet
    '
    Private estaCargando As Boolean = True
    Private Sub repTransferencias_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        principal.mr_transferencia.Enabled = True
    End Sub
    Private Sub repTransferencias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Top = 0
        Me.Left = 0
        dtiDesde.MaxDate = pFechaActivaMax
        dtiDesde.MinDate = pFechaActivaMin
        dtiHasta.MaxDate = pFechaActivaMax
        dtiHasta.MinDate = pFechaActivaMin
        If Month(pFechaActivaMax) = Month(pFechaSystem) Then
            dtiDesde.Value = pFechaSystem
            dtiHasta.Value = pFechaSystem
        End If
        Dim mes, anno As Integer
        mes = Month(pFechaActivaMax)
        anno = Year(pFechaActivaMax)
        cboMes.SelectedIndex = mes - 1
        cboAnno.SelectedIndex = anno - 2010
        'dataset almacen origen
        Dim daAlmacen As New MySqlDataAdapter
        Dim comAlmacen As New MySqlCommand("select cod_alma,nom_alma from almacen where activo=1 and(origenTrans) order by nom_alma", dbConex)
        daAlmacen.SelectCommand = comAlmacen
        daAlmacen.Fill(dsAlmacenO, "almacen")
        cargaOrigen()
        'dataset almacen destino
        Dim daAlmacenD As New MySqlDataAdapter
        Dim comAlmacenD As New MySqlCommand("select distinct almacen.cod_alma,nom_alma" _
                                & " from almacen left join area on almacen.cod_alma = area.cod_alma" _
                                & " where ((almacen.destinoTrans) or (area.destinoTrans)) order by nom_alma", dbConex)
        daAlmacenD.SelectCommand = comAlmacenD
        daAlmacenD.Fill(dsAlmacenD, "almacen")
        'dataset usuario

        Dim daUsuario As New MySqlDataAdapter
        Dim comUsuario As New MySqlCommand("select cuenta,user from usuario where activo=1 and nivel=5 order by user", dbConex)
        daUsuario.SelectCommand = comUsuario
        daUsuario.Fill(dsUsuario, "usuario")
        With cboUsuario
            .DataSource = dsUsuario.Tables("usuario")
            .DisplayMember = dsUsuario.Tables("usuario").Columns("user").ToString
            .ValueMember = dsUsuario.Tables("usuario").Columns("cuenta").ToString
            '.SelectedIndex = 0
        End With

  
        estaCargando = False
        muestraTransferencias()
    End Sub
    Sub cargaOrigen()
        With cboAlmacen
            .DataSource = dsAlmacenO.Tables("almacen")
            .DisplayMember = dsAlmacenO.Tables("almacen").Columns("nom_alma").ToString
            .ValueMember = dsAlmacenO.Tables("almacen").Columns("cod_alma").ToString
            If dsAlmacenO.Tables("almacen").Rows.Count > 0 Then
                .SelectedIndex = 0
            End If
        End With
    End Sub
    Sub cargadestino()
        With cboAlmacen
            .DataSource = dsAlmacenD.Tables("almacen")
            .DisplayMember = dsAlmacenD.Tables("almacen").Columns("nom_alma").ToString
            .ValueMember = dsAlmacenD.Tables("almacen").Columns("cod_alma").ToString
            If dsAlmacenD.Tables("almacen").Rows.Count > 0 Then
                .SelectedIndex = 0
            End If
        End With
    End Sub
    Private Sub cboMes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMes.SelectedIndexChanged
        If Not estaCargando Then
            estableceFechas()
            chkDia.Checked = False
            'muestraTransferencias()
        End If
    End Sub
    Private Sub cboAnno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAnno.SelectedIndexChanged
        If Not estaCargando Then
            estableceFechas()
            chkDia.Checked = False
            '    muestraTransferencias()
        End If
    End Sub
    Private Sub chkDia_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDia.CheckedChanged
        'If Not estaCargando Then
        '    muestraTransferencias()
        'End If
    End Sub
    Private Sub dtiDesde_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtiDesde.ValueChanged
        'If Not estaCargando Then
        '    muestraTransferencias()
        'End If
    End Sub
    Private Sub dtiHasta_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtiHasta.ValueChanged
        'If Not estaCargando Then
        '    muestraTransferencias()
        'End If
    End Sub
    Private Sub optIntegrado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optIntegrado.CheckedChanged
        If Not estaCargando And optIntegrado.Checked = True Then
            grupoAlmacen.Text = "Almacén"
            cboAlmacen.SelectedIndex = -1
            cboAlmacen.Enabled = False
            cboUsuario.SelectedIndex = -1
            cboUsuario.Enabled = False
            muestraTransferencias()
        End If
    End Sub
    Private Sub optAlmacenO_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optAlmacenO.CheckedChanged
        If Not estaCargando And optAlmacenO.Checked = True Then
            grupoAlmacen.Text = "Almacén Origen"
            cboUsuario.SelectedIndex = -1
            cboAlmacen.Enabled = True
            cargaOrigen()
            cboAlmacen.Focus()
        End If
    End Sub
    Private Sub optAlmacenD_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optAlmacenD.CheckedChanged
        If Not estaCargando And optAlmacenD.Checked = True Then
            grupoAlmacen.Text = "Almacén Destino"
            cboUsuario.SelectedIndex = -1
            cboAlmacen.Enabled = True
            cargadestino()
            cboAlmacen.Focus()
        End If
    End Sub

    Private Sub cboAlmacen_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboAlmacen.SelectedIndexChanged
        'If Not estaCargando Then
        '    muestraTransferencias()
        'End If
    End Sub
    Private Sub cboProducto_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboUsuario.SelectedIndexChanged
        'If Not estaCargando Then
        '    muestraTransferencias()
        'End If
    End Sub

    Function fechaI() As Date
        If Not estaCargando Then
            Dim mfecha As Date
            'mfecha = general.convierteTexto_enFecha(1, cboMes.SelectedIndex + 1, Val(cboAnno.Text))
            mfecha = general.convierteTexto_enFecha(1, 1, Val(cboAnno.Text))
            Return mfecha
        End If
    End Function
    Function fechaF() As Date
        If Not estaCargando Then
            Dim mFecha As Date
            If cboMes.SelectedIndex = 11 Then 'cuando es diciembre
                mFecha = Microsoft.VisualBasic.DateAndTime.DateAdd(DateInterval.Day, -1, _
                        general.convierteTexto_enFecha(1, 1, Val(cboAnno.Text) + 1))
            Else
                mFecha = Microsoft.VisualBasic.DateAndTime.DateAdd(DateInterval.Day, -1, _
                        general.convierteTexto_enFecha(1, cboMes.SelectedIndex + 2, Val(cboAnno.Text)))
            End If
            Return mFecha
        End If
    End Function
    Sub estableceFechas()
        Dim periodo As String = periodoSeleccionado()
        If periodo <> general.periodoActivo Then
            dtiDesde.ResetMinDate()
            dtiDesde.MinDate = fechaI()
            dtiDesde.ResetMaxDate()
            dtiDesde.MaxDate = fechaF()
            dtiDesde.Value = fechaI()
            dtiHasta.ResetMinDate()
            dtiHasta.MinDate = fechaI()
            dtiHasta.ResetMaxDate()
            dtiHasta.MaxDate = fechaF()
            dtiHasta.Value = fechaF()
        Else
            If chkDia.Checked = True Then
                dtiDesde.Enabled = True
                dtiHasta.Enabled = True
            End If
            dtiDesde.ResetMinDate()
            dtiDesde.MinDate = pFechaActivaMin
            dtiDesde.ResetMaxDate()
            dtiDesde.MaxDate = pFechaActivaMax
            dtiDesde.Value = pFechaActivaMin
            dtiHasta.ResetMaxDate()
            dtiHasta.MinDate = pFechaActivaMin
            dtiHasta.ResetMaxDate()
            dtiHasta.MaxDate = pFechaActivaMax
            dtiHasta.Value = pFechaActivaMax
        End If
    End Sub
    Function periodoSeleccionado()
        Dim periodo As String = Trim(Str(cboAnno.SelectedIndex + 2010)) _
                & Microsoft.VisualBasic.Right("00" & Trim(Str(cboMes.SelectedIndex + 1)), 2)
        Return periodo
    End Function
    Sub muestraTransferencias()
        Dim mTransferencia As New Transferencia
        Dim periodo As String = periodoSeleccionado()
        Dim esHistorial As Boolean = IIf(periodo = periodoActivo(), False, True)
        Dim esMensual As Boolean = IIf(chkDia.Checked = True, True, False)
        Dim es_xAlmacenO As Boolean = IIf(optAlmacenO.Checked = True, True, False)
        Dim es_xAlmacenD As Boolean = IIf(optAlmacenD.Checked = True, True, False)
        Dim es_xusuario As Boolean = IIf(chkUsuario.Checked = True, True, False)
        Dim es_xnroTransferencia As Boolean = IIf(Microsoft.VisualBasic.Len(txtBuscar.Text) > 0, True, False)
        dsTransferencias.Clear()
        dsTransferencias = mTransferencia.recuperaTransferencias(esHistorial, periodo, esMensual,
                            dtiDesde.Value, dtiHasta.Value, pDecimales, es_xAlmacenO, es_xAlmacenD,
                            cboAlmacen.SelectedValue, es_xusuario, cboUsuario.SelectedValue, es_xnroTransferencia, txtBuscar.Text, False)
        ' dataDetalle.DataSource = ""
        dataDetalle.DataSource = dsTransferencias.Tables("transferencia").DefaultView
        estructuraTransferencia()
        lblRegistros.Text = "Nº de Registros..." & dataDetalle.RowCount
    End Sub
    Sub estructuraTransferencia()
        With dataDetalle
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("fec_doc").HeaderText = "Fecha"
            .Columns("fec_doc").Width = 70
            .Columns("fec_doc").DisplayIndex = 0
            .Columns("fec_doc").ReadOnly = True
            .Columns("fec_doc").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("origen").HeaderText = "Almacén Origen"
            .Columns("origen").Width = 90
            .Columns("origen").DisplayIndex = 0
            .Columns("origen").ReadOnly = True
            .Columns("origen").DefaultCellStyle.BackColor = Color.AliceBlue
            .Columns("doc").HeaderText = "Nro Transferencia"
            .Columns("doc").Width = 80
            .Columns("doc").DisplayIndex = 1
            .Columns("doc").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("doc").ReadOnly = True
            .Columns("cod_art").HeaderText = "Código"
            .Columns("cod_art").Width = 48
            .Columns("cod_art").DisplayIndex = 2
            .Columns("cod_art").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_art").ReadOnly = True
            .Columns("nom_art").HeaderText = "Descripción"
            .Columns("nom_art").Width = 210
            .Columns("nom_art").DisplayIndex = 3
            .Columns("nom_art").ReadOnly = True
            .Columns("nom_uni").HeaderText = "Unidad"
            .Columns("nom_uni").Width = 52
            .Columns("nom_uni").DisplayIndex = 4
            .Columns("nom_uni").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("nom_uni").ReadOnly = True
            .Columns("cant").HeaderText = "Cantidad"
            .Columns("cant").Width = 65
            .Columns("cant").DisplayIndex = 5
            .Columns("cant").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("cant").DefaultCellStyle.BackColor = Color.AliceBlue
            .Columns("cant").ReadOnly = True
            .Columns("precio").HeaderText = "Precio Costo"
            .Columns("precio").Width = 55
            .Columns("precio").DisplayIndex = 6
            .Columns("precio").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("precio").ReadOnly = True

            .Columns("total").HeaderText = "Total Costo"
            .Columns("total").Width = 55
            .Columns("total").DisplayIndex = 7
            .Columns("total").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("total").ReadOnly = True

            .Columns("destino").HeaderText = "Almacén Destino"
            .Columns("destino").Width = 80
            .Columns("destino").DisplayIndex = 8
            .Columns("destino").DefaultCellStyle.BackColor = Color.AliceBlue
            .Columns("destino").ReadOnly = True
            .Columns("area").HeaderText = "Area"
            .Columns("area").Width = 75
            .Columns("area").DisplayIndex = 9
            .Columns("area").DefaultCellStyle.BackColor = Color.AliceBlue
            .Columns("area").ReadOnly = True
            .Columns("fec_prod").HeaderText = "Fecha Prod"
            .Columns("fec_prod").Width = 70
            .Columns("fec_prod").DisplayIndex = 10
            .Columns("fec_prod").ReadOnly = True

            .Columns("fec_ent").HeaderText = "Fecha Entrega"
            .Columns("fec_ent").Width = 70
            .Columns("fec_ent").DisplayIndex = 11
            .Columns("fec_ent").ReadOnly = True

            .Columns("obs").HeaderText = "Observacion"
            .Columns("obs").Width = 80
            .Columns("obs").DisplayIndex = 12
            .Columns("obs").ReadOnly = True
            .Columns("cant1").Visible = False
            .Columns("ser_doc").Visible = False
            .Columns("nro_doc").Visible = False
            .Columns("operacion").Visible = False
            .Columns("ingreso").Visible = False
            .Columns("salida").Visible = False
            .Columns("nAux").Visible = False


        End With
    End Sub
    Private Sub txtBuscar_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscar.GotFocus
        txtBuscar.SelectAll()
    End Sub
    Private Sub txtBuscar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBuscar.KeyDown
        If e.KeyCode = Keys.Enter Then
            dataDetalle.Focus()
        End If
    End Sub
    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged
        If Microsoft.VisualBasic.Len(txtBuscar.Text) > 0 Then
            Dim valor As String = txtBuscar.Text
            dsTransferencias.Tables("transferencia").DefaultView.RowFilter = "nro_doc LIKE '%" & valor & "%'"
            If dataDetalle.RowCount > 0 Then
                dataDetalle.CurrentCell = dataDetalle("cod_art", dataDetalle.CurrentRow.Index)
            End If
        Else
            If Not (estaCargando) Then
                muestraTransferencias()
            End If
        End If
    End Sub
    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        Dim periodo As String = periodoSeleccionado()
        Dim periodoReporte As String = "Periodo: " & general.periodo_mesAnnoLetras(periodo)
        Dim fechaReporte As String
        Dim frm As New rptForm
        'capturamos la fecha  o rango de fechas del reporte
        If chkDia.Checked = False Then
            If dtiHasta.Value > pFechaSystem Then
                fechaReporte = general.devuelveFechaImpresionSistema
            Else
                fechaReporte = "Al: " & general.devuelveFechaImpresionEspecificado(dtiHasta.Value)
            End If
        Else
            If dtiHasta.Value > pFechaSystem Then
                If Microsoft.VisualBasic.DateAndTime.Day(dtiDesde.Value) = 1 Then
                    fechaReporte = "Al: " & general.devuelveFechaImpresionEspecificado(pFechaSystem)
                Else
                    fechaReporte = general.devuelveFechaImpresionEspecificado(dtiDesde.Value) _
                            & " al " & general.devuelveFechaImpresionEspecificado(pFechaSystem)
                End If
            Else
                If Microsoft.VisualBasic.DateAndTime.Day(dtiDesde.Value) = 1 Then
                    fechaReporte = "Al: " & general.devuelveFechaImpresionEspecificado(dtiHasta.Value)
                Else
                    fechaReporte = general.devuelveFechaImpresionEspecificado(dtiDesde.Value) _
                            & " al " & general.devuelveFechaImpresionEspecificado(dtiHasta.Value)
                End If
            End If
        End If
        muestraTransferencias()
        Dim usuario As String = IIf(chkUsuario.Checked = True, " Usuario :" & cboUsuario.Text, "")
        Dim tiporeporte As Integer = IIf(ChkResumen.Checked = True, 2, 1)
        If optAlmacenO.Checked = True Then
            frm.cargarTransferencias(dsTransferencias, "Almacén Origen: " & cboAlmacen.Text & " - " & usuario, "Transferencias", fechaReporte, periodoReporte, tiporeporte)
        Else
            If optAlmacenD.Checked = True Then
                frm.cargarTransferencias(dsTransferencias, "Almacén Destino: " & cboAlmacen.Text & " - " & usuario, "Transferencias", fechaReporte, periodoReporte, tiporeporte)
            Else

                frm.cargarTransferencias(dsTransferencias, "INTEGRADO", "Transferencias", fechaReporte, periodoReporte, tiporeporte)
            End If

        End If
        frm.MdiParent = principal
        frm.Show()
    End Sub
    Private Sub cmdCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCerrar.Click
        Me.Close()
    End Sub
    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If dsTransferencias.Tables("transferencia").Rows.Count > 0 Then
        '    Dim I As Integer = 0
        '    Dim trans As New Transferencia
        '    Dim cNumero, cSerie, cAlma, cArea As String
        '    For I = 0 To dsTransferencias.Tables("transferencia").Rows.Count - 1
        '        cNumero = dsTransferencias.Tables("transferencia").Rows(I).Item("nro_doc").ToString
        '        cSerie = dsTransferencias.Tables("transferencia").Rows(I).Item("ser_doc").ToString
        '        cAlma = trans.recuperaAlmacenTrans_dest(True, cserie, cNumero)
        '        cArea = trans.recuperaAreaTrans_dest(True, cSerie, cNumero)
        '        Dim com As New MySqlCommand
        '        com.Connection = dbConex
        '        com.CommandText = "update h_salida set cAux='" & cAlma & "',cAux2='" & cArea & "' where cod_doc='90' and ser_doc='" & cSerie & "' and nro_doc='" & cNumero & "'"
        '        com.ExecuteNonQuery()
        '    Next
        'End If
    End Sub

    Private Sub dataDetalle_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataDetalle.CellContentClick

    End Sub

    Private Sub dataDetalle_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataDetalle.CellEndEdit
        'If dataDetalle.CurrentCell.ColumnIndex = dataDetalle.Columns("cant").Index Then
        '    Dim lcantidad As Decimal, cod_art As String, nrosalida, nroingreso, nroAux As Integer
        '    If IsDBNull(dataDetalle("cant", dataDetalle.CurrentRow.Index).Value) Then
        '        lcantidad = 0
        '        dataDetalle("cant", dataDetalle.CurrentRow.Index).Value = 0
        '    Else
        '        lcantidad = dataDetalle("cant", dataDetalle.CurrentRow.Index).Value
        '    End If
        '    Dim msalida As New Salida, mingreso As New Ingreso
        '    cod_art = dataDetalle("cod_Art", dataDetalle.CurrentRow.Index).Value
        '    nrosalida = dataDetalle("salida", dataDetalle.CurrentRow.Index).Value
        '    nroingreso = dataDetalle("ingreso", dataDetalle.CurrentRow.Index).Value
        '    nroAux = dataDetalle("nAux", dataDetalle.CurrentRow.Index).Value
        '    If nroAux = 0 Then
        '        nroingreso = nroingreso
        '    Else
        '        nroingreso = nroAux
        '    End If
        '    msalida.actualizaDetalleTransf(nrosalida, cod_art, lcantidad)
        '    mingreso.actualizaDetalleTransf(nroingreso, lcantidad)
        'End If
        'If dataDetalle.CurrentCell.ColumnIndex = dataDetalle.Columns("fec_doc").Index Then
        '    Dim nroOperacion As Integer, fecha As Date
        '    If IsDBNull(dataDetalle("fec_doc", dataDetalle.CurrentRow.Index).Value) Then
        '        fecha = dataDetalle("fec_doc", dataDetalle.CurrentRow.Index).Value
        '    End If
        '    'Dim msalida As New Salida
        '    'nroOperacion = dataDetalle("operacion", dataDetalle.CurrentRow.Index).Value
        '    'fecha = dataDetalle("fec_doc", dataDetalle.CurrentRow.Index).Value
        '    ''msalida.actualizaCabeceraTransf(nroOperacion, fecha)
        'End If
    End Sub

    Private Sub dataDetalle_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dataDetalle.KeyDown
        If (e.Control And e.KeyCode = Keys.E) Then
            If dataDetalle.RowCount > 0 Then
                EnviaraExcel(dataDetalle)
            End If
        End If
    End Sub



    Private Sub ButtonX1_Click_1(sender As Object, e As EventArgs) Handles ButtonX1.Click
        muestraTransferencias()
    End Sub

  

    Private Sub chkUsuario_CheckedChanged(sender As Object, e As EventArgs) Handles chkUsuario.CheckedChanged
        If Not estaCargando Then
            If chkUsuario.Checked = True Then
                cboUsuario.Enabled = True
                cboUsuario.SelectedIndex = 0
            Else
                cboUsuario.Enabled = False
                cboUsuario.SelectedIndex = -1
            End If
        End If
    End Sub

    Private Sub dtiDesde_Click(sender As Object, e As EventArgs) Handles dtiDesde.Click

    End Sub

    Private Sub dtiHasta_Click(sender As Object, e As EventArgs) Handles dtiHasta.Click

    End Sub
End Class
