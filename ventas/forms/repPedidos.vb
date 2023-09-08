Imports MySql.Data.MySqlClient
Imports libreriaClases
Public Class repPedidos
    Private dsResponsable As New DataSet
    Private dtResponsable As New DataTable("responsable")
    Private dsVendedor As New DataSet
    Private dtVendedor As New DataTable("vendedor")
    Private dsCliente As New DataSet
    Private dtCliente As New DataTable("cliente")
    Private dsProducto As New DataSet
    Private dtProducto As New DataTable("producto")
    Private dsEstados As New DataSet
    Private dsTipoPedido As New DataSet

    Private dsTransferencias As New DataSet
    Private estaCargando As Boolean = True

    Private Sub repPedidos_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        principal.mr_pedidos.Enabled = True
    End Sub
    Private Sub repPedidos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Top = 0
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

        dsVendedor.Tables.Add(dtVendedor)
        dsCliente.Tables.Add(dtCliente)
        dsProducto.Tables.Add(dtProducto)

        'dataset TIPO PEDIDO
        Dim daTipPedido As New MySqlDataAdapter
        Dim comPed As New MySqlCommand("SELECT cod_recurso,dsc_recurso FROM tipo_recurso where cod_tabla='tip_pedido'and activo=1", dbConex)
        daTipPedido.SelectCommand = comPed
        daTipPedido.Fill(dsTipoPedido, "TipoPedido")
        With cboPedido
            .DataSource = dsTipoPedido.Tables("TipoPedido")
            .DisplayMember = dsTipoPedido.Tables("TipoPedido").Columns("dsc_recurso").ToString
            .ValueMember = dsTipoPedido.Tables("TipoPedido").Columns("cod_recurso").ToString
            .SelectedIndex = 0
        End With

        'dataset ESTADOS
        Dim daEstados As New MySqlDataAdapter
        Dim comEst As New MySqlCommand("SELECT cod_recurso,dsc_recurso FROM tipo_recurso where cod_tabla='tip_epedido'and activo=1", dbConex)
        daEstados.SelectCommand = comEst
        daEstados.Fill(dsEstados, "Estados")
        With CboEstado
            .DataSource = dsEstados.Tables("Estados")
            .DisplayMember = dsEstados.Tables("Estados").Columns("dsc_recurso").ToString
            .ValueMember = dsEstados.Tables("Estados").Columns("cod_recurso").ToString
            .SelectedIndex = 0
        End With

        estaCargando = False
    End Sub
    Private Sub optRegistro_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optRegistro.CheckedChanged
        grupo.Text = ""
        cboDatos.SelectedIndex = -1
        cboDatos.Enabled = False
    End Sub
    'Private Sub optCliente_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optPedFormato.CheckedChanged
    '    'dataset cliente
    '    dsCliente.Clear()
    '    Dim daCliente As New MySqlDataAdapter
    '    Dim comClie As New MySqlCommand("select cod_clie,raz_soc from cliente where activo=1", dbConex)
    '    daCliente.SelectCommand = comClie
    '    daCliente.Fill(dsCliente, "cliente")
    '    With cboDatos
    '        .DropDownStyle = ComboBoxStyle.DropDown
    '        .DataSource = dsCliente.Tables("cliente")
    '        .DisplayMember = dsCliente.Tables("cliente").Columns("raz_soc").ToString
    '        .ValueMember = dsCliente.Tables("cliente").Columns("cod_clie").ToString
    '        .AutoCompleteMode = AutoCompleteMode.SuggestAppend
    '        .AutoCompleteSource = AutoCompleteSource.ListItems
    '        .SelectedIndex = -1
    '    End With
    '    grupo.Text = "Cliente"
    '    cboDatos.Enabled = True
    '    cboDatos.SelectedIndex = 0
    '    cboDatos.Focus()
    'End Sub
    Private Sub optVendedor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optVendedor.CheckedChanged
        ''dataset vendedor
        'dsVendedor.Clear()
        'Dim daVendedor As New MySqlDataAdapter
        'Dim comVend As New MySqlCommand("select cod_vend,nom_vend from vendedor where activo=1", dbConex)
        'daVendedor.SelectCommand = comVend
        'daVendedor.Fill(dsVendedor, "vendedor")
        'With cboDatos
        '    .DropDownStyle = ComboBoxStyle.DropDownList
        '    .DataSource = dsVendedor.Tables("vendedor")
        '    .DisplayMember = dsVendedor.Tables("vendedor").Columns("nom_vend").ToString
        '    .ValueMember = dsVendedor.Tables("vendedor").Columns("cod_vend").ToString
        '    .SelectedIndex = -1
        'End With
        'grupo.Text = "Vendedor"
        'cboDatos.Enabled = True
        'cboDatos.SelectedIndex = 0
        'cboDatos.Focus()
        'dataset vendedor
        dsResponsable.Clear()
        Dim daResponsable As New MySqlDataAdapter
        Dim comResp As New MySqlCommand("select cuenta,user from usuario where activo=1", dbConex)
        daResponsable.SelectCommand = comResp
        daResponsable.Fill(dsResponsable, "responsable")
        With cboDatos
            .DropDownStyle = ComboBoxStyle.DropDownList
            .DataSource = dsResponsable.Tables("responsable")
            .DisplayMember = dsResponsable.Tables("responsable").Columns("user").ToString
            .ValueMember = dsResponsable.Tables("responsable").Columns("cuenta").ToString
            .SelectedIndex = -1
        End With
        grupo.Text = "Responsable"
        cboDatos.Enabled = True
        cboDatos.SelectedIndex = 0
        cboDatos.Focus()

    End Sub
    Private Sub optProducto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optProducto.CheckedChanged
        grupo.Text = ""
        cboDatos.SelectedIndex = -1
        cboDatos.Enabled = False
    End Sub

    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        Dim frm As New rptForm, anno As Integer, mes As Integer, fechaPedido As String, fechaPedidohasta As String, tipo_pedido, estado As String, nom_estado As String
        estado = CboEstado.SelectedValue
        tipo_pedido = cboPedido.SelectedValue
        nom_estado = CboEstado.Text
        Dim periodo As String = periodoSeleccionado()
        Dim periodoReporte As String = "Periodo: " & general.periodo_mesAnnoLetras(periodo)
        fechaPedido = dtiDesde.Value
        fechaPedidohasta = dtiHasta.Value
        If cboMes.SelectedIndex <> -1 Then
            If cboAnno.SelectedIndex <> -1 Then
                anno = cboAnno.SelectedIndex + 2010
                mes = cboMes.SelectedIndex + 1

                pTituloRep1 = cboMes.Text + " " + cboAnno.Text
                If optRegistro.Checked = True Then
                    If chkDia.Checked = True Then
                        frm.cargarRegistroPedidos(anno, mes, fechaPedido, fechaPedidohasta, True, False, True, tipo_pedido, estado, nom_estado, "", "", False, "", "")
                    Else
                        frm.cargarRegistroPedidos(anno, mes, fechaPedido, fechaPedidohasta, False, False, True, tipo_pedido, estado, nom_estado, "", "", False, "", "")
                    End If
                End If
                If optPedFormato.Checked = True Then

                    If chkDia.Checked = True Then
                        frm.cargarPedidosFormato(anno, mes, fechaPedido, fechaPedidohasta, True, False, True, tipo_pedido, estado, nom_estado, "", "", False, "", "")
                    Else
                        frm.cargarPedidosFormato(anno, mes, fechaPedido, fechaPedidohasta, False, False, True, tipo_pedido, estado, nom_estado, "", "", False, "", "")
                    End If
                End If
                If optVendedor.Checked = True Then
                    Dim lVendedor, nVendedor As String
                    lVendedor = cboDatos.SelectedValue
                    nVendedor = cboDatos.Text
                    If chkDia.Checked = True Then
                        frm.cargarRegistroPedidos(anno, mes, fechaPedido, fechaPedidohasta, True, False, False, tipo_pedido, estado, nom_estado, "", "", True, lVendedor, nVendedor)
                    Else
                        frm.cargarRegistroPedidos(anno, mes, fechaPedido, fechaPedidohasta, False, False, False, tipo_pedido, estado, nom_estado, "", "", True, lVendedor, nVendedor)
                    End If
                End If
                If optProducto.Checked = True Then
                    If chkDia.Checked = True Then
                        frm.cargarProductosPedidos(anno, mes, fechaPedido, fechaPedidohasta, True, tipo_pedido, estado, nom_estado, True)
                    Else
                        frm.cargarProductosPedidos(anno, mes, fechaPedido, fechaPedidohasta, True, tipo_pedido, estado, nom_estado, False)
                    End If
                End If

                If optConsolidado.Checked = True Then
                    If Chkdia.Checked = True Then
                        frm.cargarConsolidadoPedidos(anno, mes, fechaPedido, fechaPedidohasta, True, tipo_pedido, estado, nom_estado, True)
                    Else
                        frm.cargarConsolidadoPedidos(anno, mes, fechaPedido, fechaPedidohasta, True, tipo_pedido, estado, nom_estado, False)
                    End If
                End If
                frm.MdiParent = principal
                frm.Show()

                If optPedidoPed.checked = True Then
                    Dim mTransferencia As New Transferencia
                    dsTransferencias.Clear()
                    Dim fechaReporte As String
                    fechaReporte = "Al: " & general.devuelveFechaImpresionEspecificado(pFechaSystem)
                    dsTransferencias = mTransferencia.recuperaTransferencias_pend(False, "", True, dtiDesde.Value, dtiHasta.Value, pDecimales, False, False, "", False, "", False, "", True)
                    frm.cargarTransferencias(dsTransferencias, "Almacén Origen: Almacen Central", "Pedidos Pendientes", fechaReporte, periodoReporte, 1)

                End If

            Else
                MessageBox.Show("Seleccione el Año...", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                cboAnno.Focus()
            End If
        Else
            MessageBox.Show("Seleccione el Mes...", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            cboMes.Focus()
        End If
    End Sub
    Function periodoSeleccionado()
        Dim periodo As String = Trim(Str(cboAnno.SelectedIndex + 2010)) _
                & Microsoft.VisualBasic.Right("00" & Trim(Str(cboMes.SelectedIndex + 1)), 2)
        Return periodo
    End Function

    Private Sub cmdCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCerrar.Click
        Me.Close()
    End Sub

    Private Sub chkDia_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub cboDatos_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboDatos.Validating
        Try
            If Microsoft.VisualBasic.Len(cboDatos.Text) > 0 Then
                Dim lcod As String = cboDatos.SelectedValue.ToString
            End If
        Catch err As Exception
            MessageBox.Show("Seleccione un valor Registrado...", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cboDatos.SelectedIndex = -1
            e.Cancel = True
        End Try
    End Sub

    Private Sub mcDia_ItemClick(sender As Object, e As EventArgs)

    End Sub

    Private Sub cboMes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMes.SelectedIndexChanged
        If Not estaCargando Then
            estableceFechas()
            Chkdia.Checked = True
            'muestraTransferencias()
        End If
    End Sub

    Private Sub cboAnno_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAnno.SelectedIndexChanged
        If Not estaCargando Then
            estableceFechas()
            Chkdia.Checked = True
            '    muestraTransferencias()
        End If
    End Sub
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
                mFecha = Microsoft.VisualBasic.DateAndTime.DateAdd(DateInterval.Day, -1,
                        general.convierteTexto_enFecha(1, 1, Val(cboAnno.Text) + 1))
            Else
                mFecha = Microsoft.VisualBasic.DateAndTime.DateAdd(DateInterval.Day, -1,
                        general.convierteTexto_enFecha(1, cboMes.SelectedIndex + 2, Val(cboAnno.Text)))
            End If
            Return mFecha
        End If
    End Function

    Private Sub Chkdia_CheckedChanged_1(sender As Object, e As EventArgs) Handles Chkdia.CheckedChanged

    End Sub
End Class
