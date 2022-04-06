Imports MySql.Data.MySqlClient
Imports libreriaClases
Public Class repTransferencias
    Private dsAlmacenO As New DataSet
    Private dsAlmacenD As New DataSet
    Private dsProducto As New DataSet
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
                                & " where almacen.activo=1 and((almacen.destinoTrans) or (area.destinoTrans)) order by nom_alma", dbConex)
        daAlmacenD.SelectCommand = comAlmacenD
        daAlmacenD.Fill(dsAlmacenD, "almacen")
        'dataset producto
        Dim daProducto As New MySqlDataAdapter
        Dim cad As String, cAlma As String = cboAlmacen.SelectedValue
        If pCatalogoXalmacen Then
            cad = "select cod_art,nom_art from articulo where activo=1 and cod_alma='" & cAlma & "' order by nom_art"
        Else
            cad = "select cod_art,nom_art from articulo where activo=1 order by nom_art"
        End If
        Dim comProd As New MySqlCommand(cad, dbConex)
        daProducto.SelectCommand = comProd
        daProducto.Fill(dsProducto, "producto")
        With cboProducto
            .DropDownStyle = ComboBoxStyle.DropDown
            .DataSource = dsProducto.Tables("producto")
            .DisplayMember = dsProducto.Tables("producto").Columns("nom_art").ToString
            .ValueMember = dsProducto.Tables("producto").Columns("cod_art").ToString
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.ListItems
            .SelectedIndex = -1
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
            muestraTransferencias()
        End If
    End Sub
    Private Sub cboAnno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAnno.SelectedIndexChanged
        If Not estaCargando Then
            estableceFechas()
            chkDia.Checked = False
            muestraTransferencias()
        End If
    End Sub
    Private Sub chkDia_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDia.CheckedChanged
        If Not estaCargando Then
            muestraTransferencias()
        End If
    End Sub
    Private Sub dtiDesde_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtiDesde.ValueChanged
        If Not estaCargando Then
            muestraTransferencias()
        End If
    End Sub
    Private Sub dtiHasta_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtiHasta.ValueChanged
        If Not estaCargando Then
            muestraTransferencias()
        End If
    End Sub
    Private Sub optIntegrado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optIntegrado.CheckedChanged
        If Not estaCargando And optIntegrado.Checked = True Then
            grupoAlmacen.Text = "Almacén"
            cboAlmacen.SelectedIndex = -1
            cboAlmacen.Enabled = False
            cboProducto.SelectedIndex = -1
            cboProducto.Enabled = False
            muestraTransferencias()
        End If
    End Sub
    Private Sub optAlmacenO_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optAlmacenO.CheckedChanged
        If Not estaCargando And optAlmacenO.Checked = True Then
            grupoAlmacen.Text = "Almacén Origen"
            cboProducto.SelectedIndex = -1
            cboProducto.Enabled = False
            cboAlmacen.Enabled = True
            cargaOrigen()
            cboAlmacen.Focus()
        End If
    End Sub
    Private Sub optAlmacenD_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optAlmacenD.CheckedChanged
        If Not estaCargando And optAlmacenD.Checked = True Then
            grupoAlmacen.Text = "Almacén Destino"
            cboProducto.SelectedIndex = -1
            cboProducto.Enabled = False
            cboAlmacen.Enabled = True
            cargadestino()
            cboAlmacen.Focus()
        End If
    End Sub
    Private Sub optArticulo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optArticulo.CheckedChanged
        If Not estaCargando And optArticulo.Checked = True Then
            grupoAlmacen.Text = "Almacén"
            cboAlmacen.SelectedIndex = -1
            cboAlmacen.Enabled = False
            cboProducto.Enabled = True
            If dsProducto.Tables("producto").Rows.Count > 0 Then
                cboProducto.SelectedIndex = 0
            End If
            cboProducto.Focus()
        End If
    End Sub
    Private Sub cboAlmacen_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboAlmacen.SelectedIndexChanged
        If Not estaCargando Then
            muestraTransferencias()
        End If
    End Sub
    Private Sub cboProducto_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboProducto.SelectedIndexChanged
        If Not estaCargando Then
            muestraTransferencias()
        End If
    End Sub
    Private Sub cboProducto_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboProducto.Validating
        If Not estaCargando Then
            If optArticulo.Checked = True Then
                Try
                    If Microsoft.VisualBasic.Len(cboProducto.Text) > 0 Then
                        Dim lcod As String = cboProducto.SelectedValue.ToString
                        Dim fila() As DataRow
                        fila = dsProducto.Tables("producto").Select("cod_art ='" & lcod & "'")
                    End If
                Catch err As Exception
                    MessageBox.Show("Selección Incorrecta...", "Cefe", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    cboProducto.SelectedIndex = -1
                    e.Cancel = True
                End Try
            End If
        End If
    End Sub
    Function fechaI() As Date
        If Not estaCargando Then
            Dim mfecha As Date
            mfecha = general.convierteTexto_enFecha(1, cboMes.SelectedIndex + 1, Val(cboAnno.Text))
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
        Dim esMensual As Boolean = IIf(chkDia.Checked = False, True, False)
        Dim es_xAlmacenO As Boolean = IIf(optAlmacenO.Checked = True, True, False)
        Dim es_xAlmacenD As Boolean = IIf(optAlmacenD.Checked = True, True, False)
        Dim es_xarticulo As Boolean = IIf(optArticulo.Checked = True, True, False)
        dsTransferencias.Clear()
        dsTransferencias = mTransferencia.recuperaTransferencias(esHistorial, periodo, esMensual, _
                            dtiDesde.Value, dtiHasta.Value, pDecimales, es_xAlmacenO, es_xAlmacenD, _
                            cboAlmacen.SelectedValue, es_xarticulo, cboProducto.SelectedValue)
        dataDetalle.DataSource = ""
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
            .Columns("fec_doc").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("origen").HeaderText = "Almacén Origen"
            .Columns("origen").Width = 125
            .Columns("origen").ReadOnly = True
            .Columns("origen").DefaultCellStyle.BackColor = Color.AliceBlue
            .Columns("doc").HeaderText = "Nro Transferencia"
            .Columns("doc").Width = 90
            .Columns("doc").DisplayIndex = 1
            .Columns("doc").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_art").HeaderText = "Código"
            .Columns("cod_art").Width = 55
            .Columns("cod_art").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("nom_art").HeaderText = "Descripción"
            .Columns("nom_art").Width = 252
            .Columns("nom_uni").HeaderText = "Unidad"
            .Columns("nom_uni").Width = 75
            .Columns("nom_uni").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cant").HeaderText = "Cantidad"
            .Columns("cant").Width = 65
            .Columns("cant").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("cant").DefaultCellStyle.BackColor = Color.AliceBlue
            .Columns("precio").HeaderText = "Precio Costo"
            .Columns("precio").Width = 55
            .Columns("precio").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("destino").HeaderText = "Almacén Destino"
            .Columns("destino").Width = 125
            .Columns("destino").DefaultCellStyle.BackColor = Color.AliceBlue
            .Columns("ser_doc").Visible = False
            .Columns("nro_doc").Visible = False
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
        If optAlmacenO.Checked = True Then
            frm.cargarTransferencias(dsTransferencias, "Almacén Origen: " & cboAlmacen.Text, fechaReporte, periodoReporte)
        Else
            If optAlmacenD.Checked = True Then
                frm.cargarTransferencias(dsTransferencias, "Almacén Destino: " & cboAlmacen.Text, fechaReporte, periodoReporte)
            Else
                If optArticulo.Checked = True Then
                    frm.cargarTransferencias(dsTransferencias, "Producto: " & cboProducto.Text, fechaReporte, periodoReporte)
                Else
                    frm.cargarTransferencias(dsTransferencias, "INTEGRADO", fechaReporte, periodoReporte)
                End If
            End If
        End If
        frm.MdiParent = principal
        frm.Show()
    End Sub
    Private Sub cmdCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCerrar.Click
        Me.Close()
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
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
End Class
