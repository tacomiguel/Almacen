Imports MySql.Data.MySqlClient
Imports libreriaClases
Public Class c_historialCompras_x_articulo
    Private dsCompras As New DataSet
    Private estaCargando As Boolean = True
    Private codigoArticulo As String = ""
    Private cPrecioCI As String = general.str_PrecioCompraCI
    Private chPrecioCI As String = general.str_hPrecioCompraCI
    Private cPrecioSI As String = general.str_PrecioCompraSI
    Private chPrecioSI As String = general.str_hPrecioCompraSI
    Private cPrecioCIs As String = general.str_PrecioCompraCIs
    Private chPrecioCIs As String = general.str_hPrecioCompraCIs
    Private cPrecioSIs As String = general.str_PrecioCompraSIs
    Private chPrecioSIs As String = general.str_hPrecioCompraSIs
    Private Sub c_historialCompras_x_articulo_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If Not estaCargando Then
            muestraCompras()
        End If
    End Sub
    Private Sub c_historialCompras_x_articulo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        estaCargando = False
    End Sub
    Private Sub cboMes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMes.SelectedIndexChanged
        If Not estaCargando Then
            muestraCompras()
        End If
    End Sub
    Private Sub cboAnno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAnno.SelectedIndexChanged
        If Not estaCargando Then
            muestraCompras()
        End If
    End Sub
    Private Sub chkDia_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDia.CheckedChanged
        estableceFechas()
        If chkDia.CheckState = CheckState.Checked Then
            dtiDesde.Enabled = True
            dtiHasta.Enabled = True
            estableceFechas()
        Else
            dtiDesde.Enabled = False
            dtiHasta.Enabled = False
        End If
        If Not estaCargando Then
            muestraCompras()
        End If
    End Sub
    Private Sub dtiDesde_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtiDesde.ValueChanged
        If Not estaCargando Then
            muestraCompras()
        End If
    End Sub
    Private Sub dtiHasta_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtiHasta.ValueChanged
        If Not estaCargando Then
            muestraCompras()
        End If
    End Sub
    Private Sub chkIMP_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkIMP.CheckedChanged
        If Not estaCargando Then
            muestraCompras()
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
                mFecha = Microsoft.VisualBasic.DateAndTime.DateAdd(DateInterval.Day, -1, general.convierteTexto_enFecha(1, 1, Val(cboAnno.Text) + 1))
            Else
                mFecha = Microsoft.VisualBasic.DateAndTime.DateAdd(DateInterval.Day, -1, general.convierteTexto_enFecha(1, cboMes.SelectedIndex + 2, Val(cboAnno.Text)))
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
        Dim periodo As String = Trim(Str(cboAnno.SelectedIndex + 2010)) & Microsoft.VisualBasic.Right("00" & Trim(Str(cboMes.SelectedIndex + 1)), 2)
        Return periodo
    End Function
    Public Sub muestraCompras()
        Dim mIngresos As New Ingreso
        Dim periodo As String = periodoSeleccionado()
        Dim esHistorial As Boolean = IIf(periodo = periodoActivo(), False, True)
        Dim esMensual As Boolean = IIf(chkDia.Checked = True, False, True)
        Dim esConImpuesto As Boolean = IIf(chkIMP.Checked = True, True, False)
        'verificamos el tipo de moneda
        dsCompras.Clear()
        dsCompras = mIngresos.recuperaArticulosIngresados(esHistorial, periodo, False, "", True, False, esMensual, dtiDesde.Value, _
                    dtiHasta.Value, pDecimales, False, "", False, "", True, codigoArticulo, False, "", False, False, "", _
                    esConImpuesto, False, "", cPrecioCI, chPrecioCI, cPrecioSI, chPrecioSI, _
                    cPrecioCIs, chPrecioCIs, cPrecioSIs, chPrecioSIs, "fec_doc", False, "", False)
        dataDetalle.DataSource = dsCompras.Tables("ingreso").DefaultView
        lblRegistros.Text = "Nº de Documentos Procesados... " & dataDetalle.RowCount.ToString & "_"
        estructuraCompras()
    End Sub
    Sub estructuraCompras()
        With dataDetalle
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("fec_doc").HeaderText = "Fecha"
            .Columns("fec_doc").Width = 65
            .Columns("fec_doc").DisplayIndex = 0
            .Columns("fec_doc").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("raz_soc").HeaderText = "Proveedor"
            .Columns("raz_soc").Width = 220
            .Columns("raz_soc").DisplayIndex = 1
            .Columns("doc").HeaderText = "Documento"
            .Columns("doc").Width = 120
            .Columns("doc").DisplayIndex = 2
            .Columns("tm").HeaderText = "M"
            .Columns("tm").Width = 20
            .Columns("tm").DisplayIndex = 6
            .Columns("tm").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("tc").HeaderText = "TC"
            .Columns("tc").Width = 45
            .Columns("tc").DisplayIndex = 7
            .Columns("tc").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("cant").Visible = True
            .Columns("cant").HeaderText = "Cant."
            .Columns("cant").Width = 50
            .Columns("cant").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("precio").Visible = True
            .Columns("precio").HeaderText = "Precio Costo"
            .Columns("precio").Width = 60
            .Columns("precio").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("operacion").Visible = False
            .Columns("ingreso").Visible = False
            .Columns("nom_art").Visible = False
            .Columns("igv").Visible = False
            .Columns("afecto_igv").Visible = False
            .Columns("cod_art").Visible = False
            .Columns("nom_uni").Visible = False
            .Columns("neto").Visible = False
            .Columns("precioDS").Visible = False
            .Columns("netoDS").Visible = False

        End With
    End Sub
    Public Sub datosConsulta(ByVal cod_art As String)
        codigoArticulo = cod_art
        muestraCompras()
    End Sub
End Class
