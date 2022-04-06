Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Math
Imports libreriaClases
Public Class p_transformaciones
    Private dsAlmacen As New DataSet
    Private dsSaldos As New DataSet
    Private dsCatalogo As New DataSet
    Private dsParaTransformar As New DataSet
    Private dsTransformacionS As New DataSet
    Private dsTransformacionI As New DataSet
    Private estaCargando As Boolean = True
    'para validar el separador decimal
    Private sepDecimal As Char
    Private Sub p_transformaciones_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        principal.mp_transformaciones.Enabled = True
    End Sub
    Private Sub p_transformaciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'dataset almacen origen/destino
        'dataset almacen
        Dim cadAlma As String = ""
        If pAlmaUser = "0000" Then
            cadAlma = "select cod_alma,nom_alma from almacen where activo=1 and (esCatalogo)"
        Else
            cadAlma = "select cod_alma,nom_alma from almacen where cod_alma='" _
                    & pAlmaUser & "' and (esCatalogo) and activo=1"
        End If
        Dim daAlmacen As New MySqlDataAdapter
        Dim comAlmacen As New MySqlCommand(cadAlma, dbConex)
        daAlmacen.SelectCommand = comAlmacen
        daAlmacen.Fill(dsAlmacen, "almacen")
        With cboAlmacen
            .DataSource = dsAlmacen.Tables("almacen")
            .DisplayMember = dsAlmacen.Tables("almacen").Columns("nom_alma").ToString
            .ValueMember = dsAlmacen.Tables("almacen").Columns("cod_alma").ToString
            If dsAlmacen.Tables("almacen").Rows.Count > 0 Then
                .SelectedIndex = 0
            End If
        End With
        dsParaTransformar = Ingreso.dsIngreso
        With dataParaTransformar
            .DataSource = dsParaTransformar.Tables("detalle")
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_art").HeaderText = "Código"
            .Columns("cod_art").Width = 50
            .Columns("cod_art").ReadOnly = True
            .Columns("cod_art").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("nom_art").HeaderText = "Descripción"
            .Columns("nom_art").Width = 260
            .Columns("nom_art").ReadOnly = True
            .Columns("nom_uni").HeaderText = "Unidad"
            .Columns("nom_uni").Width = 42
            .Columns("nom_uni").ReadOnly = True
            .Columns("nom_uni").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cantidad").HeaderText = "Cant."
            .Columns("cantidad").Width = 56
            .Columns("cantidad").ReadOnly = False
            .Columns("cantidad").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("porcentaje").HeaderText = "Porc."
            .Columns("porcentaje").Width = 56
            .Columns("porcentaje").ReadOnly = False
            .Columns("porcentaje").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("precio").Visible = False
            .Columns("pre_ult").Visible = False
            .Columns("igv").Visible = False
            .Columns("afecto_igv").Visible = False
            .Columns("neto").Visible = False
            .Columns("operacion").Visible = False
            .Columns("ingreso").Visible = False
            .Columns("estado").Visible = False
        End With
        estaCargando = False
        muestraSaldos()
        cargaTransformaciones()
        establecefechas()
        'capturamos el separador decimal
        sepDecimal = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
    End Sub
    Sub muestraSaldos()
        dsSaldos.Clear()
        Dim esPrecioConIMP As Boolean
        esPrecioConIMP = IIf(chkIMP.Checked = True, True, False)
        Dim mCatalogo As New Catalogo
        dsSaldos = mCatalogo.recuperaSaldos(False, "", True, True, cboAlmacen.SelectedValue, False, "", esPrecioConIMP, False, "", pDecimales)
        dataSaldos.DataSource = ""
        dataSaldos.DataSource = dsSaldos.Tables("saldo").DefaultView
        estructuraSaldos()
    End Sub
    Sub estructuraSaldos()
        With dataSaldos
            .DataSource = dsSaldos.Tables("saldo")
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_art").HeaderText = "Código"
            .Columns("cod_art").Width = 55
            .Columns("cod_art").ReadOnly = True
            .Columns("cod_art").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("nom_art").HeaderText = "Descripción"
            .Columns("nom_art").Width = 245
            .Columns("nom_art").ReadOnly = True
            .Columns("nom_uni").HeaderText = "Unidad"
            .Columns("nom_uni").Width = 70
            .Columns("nom_uni").ReadOnly = True
            .Columns("nom_uni").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("saldo").HeaderText = "Saldo"
            .Columns("saldo").Width = 55
            .Columns("saldo").ReadOnly = True
            .Columns("saldo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("saldo").DefaultCellStyle.BackColor = Color.AliceBlue
            .Columns("precio").HeaderText = "Precio Costo"
            .Columns("precio").Width = 70
            .Columns("precio").ReadOnly = True
            .Columns("precio").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("cant_uni").Visible = False
            .Columns("es_divisible").Visible = False
            .Columns("ingreso").Visible = False
            .Columns("maximo").Visible = False
            .Columns("minimo").Visible = False
            .Columns("pre_ult").Visible = False
            .Columns("afecto_igv").Visible = False
            .Columns("cod_sgrupo").Visible = False
            .Columns("nom_sgrupo").Visible = False
            .Columns("cod_alma").Visible = False
            .Columns("nom_alma").Visible = False
            .Columns("tm").Visible = False
            .Columns("tc").Visible = False
            .Columns("pre_inc_igv").Visible = False
            .Columns("igv").Visible = False
            .Columns("monto").Visible = False
        End With
    End Sub
    Private Sub cboAlmacen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAlmacen.SelectedIndexChanged
        If Not estaCargando Then
            If cboAlmacen.SelectedIndex <> -1 Then
                muestraSaldos()
                cargaTransformaciones()
                dataSaldos.Focus()
            End If
        End If
    End Sub
    Private Sub txtBuscarArticulo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscarArticulo.TextChanged
        If Not estaCargando Then
            Dim valor As String = txtBuscarArticulo.Text
            dsSaldos.Tables("saldo").DefaultView.RowFilter = "nom_art LIKE '" & valor & "%'"
            If dataSaldos.RowCount > 0 Then
                dataSaldos.CurrentCell = dataSaldos("cod_art", dataSaldos.CurrentRow.Index)
            End If
        End If
    End Sub
    Private Sub chkIMP_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkIMP.CheckedChanged
        If Not estaCargando Then
            If chkIMP.Checked = True Then
                chkIMP.Text = "Costos CON Impuesto"
            Else
                chkIMP.Text = "Costos SIN Impuesto"
            End If
            muestraSaldos()
        End If
    End Sub
    Private Sub dataSaldos_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dataSaldos.GotFocus
        muestraProducto()
    End Sub
    Private Sub dataSaldos_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dataSaldos.SelectionChanged
        muestraProducto()
    End Sub
    Private Sub datasaldos_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dataSaldos.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtTransformar.Focus()
        End If
    End Sub
    Sub muestraProducto()
        If Not estaCargando And dataSaldos.RowCount > 0 Then
            lblProducto.Text = Microsoft.VisualBasic.UCase(dataSaldos.Item("nom_art", dataSaldos.CurrentRow.Index).Value)
            lblUnidad.Text = dataSaldos.Item("nom_uni", dataSaldos.CurrentRow.Index).Value
        End If
    End Sub
    Private Sub txtTransformar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTransformar.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not (e.KeyChar = ChrW(Keys.Back)) And Not (e.KeyChar.Equals(sepDecimal)) Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub txtTransformar_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtTransformar.Validating
        If dataSaldos.RowCount > 0 Then
            If chkprocesar.Checked = False Then
                Dim nStock As Decimal = IIf(IsDBNull(dataSaldos("saldo", dataSaldos.CurrentRow.Index).Value), _
                                        0, dataSaldos("saldo", dataSaldos.CurrentRow.Index).Value)
                If Len(txtTransformar.Text) > 0 Then
                    If nStock < txtTransformar.Text Then
                        MessageBox.Show("La Cantidad a Transformar NO puede ser mayor al Stock Dsiponible...", _
                                    "CEFE", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        e.Cancel = True
                    End If
                End If
            End If
            
        End If
    End Sub
    Private Sub txtBuscar_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscar.GotFocus
        If Not estaCargando Then
            txtBuscar.SelectAll()
            dsCatalogo.Clear()
            If Len(txtBuscar.Text) > 0 Then
                muestraCatalogo()
            End If
        End If
    End Sub
    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged
        If Not estaCargando Then
            dsCatalogo.Clear()
            If Len(txtBuscar.Text) > 0 Then
                muestraCatalogo()
                If dataCatalogo.RowCount > 0 Then
                    dataCatalogo.CurrentCell = dataCatalogo("nom_art", dataCatalogo.CurrentRow.Index)
                End If
            End If
        End If
    End Sub
    Sub muestraCatalogo()
        Dim mCatalogo As New Catalogo, mAlmacen As New Almacen
        Dim articulo As String = txtBuscar.Text
        Dim cAlma As String = mAlmacen.devuelveAlmacenCatalogo(cboAlmacen.SelectedValue)

        dsCatalogo = mCatalogo.recuperaProducto(pCatalogoXalmacen, cAlma, articulo)
        
        If dsCatalogo.Tables("articulo").Rows.Count > 0 Then
            dataCatalogo.DataSource = dsCatalogo.Tables("articulo").DefaultView
            dsCatalogo.Tables("articulo").DefaultView.RowFilter = "nom_art LIKE '" & articulo & "%'"
            dataCatalogo.DataSource = ""
            dataCatalogo.DataSource = dsCatalogo.Tables("articulo")
            estructuraCatalogo()
        End If
    End Sub
    Sub estructuraCatalogo()
        With dataCatalogo
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_art").HeaderText = "Código"
            .Columns("cod_art").Width = 53
            .Columns("cod_art").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("nom_art").HeaderText = "Descripción"
            .Columns("nom_art").Width = 285
            .Columns("nom_uni").HeaderText = "Unidad"
            .Columns("nom_uni").Width = 65
            .Columns("nom_uni").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("pre_costo").HeaderText = "Costo"
            .Columns("pre_costo").Width = 65
            .Columns("pre_costo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("cod_uni").Visible = False
            .Columns("pre_ult").Visible = False
            .Columns("pre_venta").Visible = False
            .Columns("pre_prom").Visible = False
            .Columns("cant_uni").Visible = False
            .Columns("afecto_igv").Visible = False
            .Columns("maximo").Visible = False
            .Columns("minimo").Visible = False
            .Columns("cuenta_c").Visible = False
            .Columns("cuenta_v").Visible = False
            .Columns("cod_sgrupo").Visible = False
            .Columns("esProduccion").Visible = False
        End With
    End Sub
    Private Sub cmdinsertar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdInsertar.Click
        If dataCatalogo.RowCount > 0 Then
            If Len(txtNuevaCantidad.Text) > 0 And Len(TxtPorcentaje.Text) > 0 Then
                insertaProducto()
                txtBuscar.Focus()
            Else
                MessageBox.Show("Ingrese la Cantidad y Porcentaje a Transformar", "CEFE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtNuevaCantidad.Focus()
            End If
        Else
            MessageBox.Show("Seleccione un Producto...", "CEFE", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If
    End Sub
    Sub limpia()
        txtTransformar.Text = ""
        txtNuevaCantidad.Text = ""
        txtBuscar.Text = ""
        lblProducto.Text = ""
        lblUnidad.Text = ""
        dsCatalogo.Clear()
        dsParaTransformar.Clear()
    End Sub
    Private Sub dataCatalogo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dataCatalogo.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtNuevaCantidad.Focus()
        End If
    End Sub
    Private Sub txtNuevaCantidad_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNuevaCantidad.GotFocus
        txtNuevaCantidad.SelectAll()
    End Sub
    Private Sub txtNuevaCantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNuevaCantidad.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not (e.KeyChar = ChrW(Keys.Back)) And Not (e.KeyChar.Equals(sepDecimal)) Then
            e.KeyChar = ""
        End If
    End Sub
    Sub insertaProducto()
        Dim fila As DataRow = dsParaTransformar.Tables("detalle").NewRow
        fila.Item("cod_art") = dataCatalogo.Item("cod_art", dataCatalogo.CurrentRow.Index).Value
        fila.Item("nom_art") = dataCatalogo.Item("nom_art", dataCatalogo.CurrentRow.Index).Value
        fila.Item("nom_uni") = dataCatalogo.Item("nom_uni", dataCatalogo.CurrentRow.Index).Value
        fila.Item("afecto_igv") = dataCatalogo.Item("afecto_igv", dataCatalogo.CurrentRow.Index).Value
        fila.Item("cantidad") = txtNuevaCantidad.Text
        fila.Item("porcentaje") = TxtPorcentaje.Text
        dsParaTransformar.Tables("detalle").Rows.Add(fila)
        dataParaTransformar.CurrentCell = dataParaTransformar(dataParaTransformar.Columns("cantidad").Index, dataParaTransformar.RowCount - 1)
    End Sub
    Sub EliminaProducto()
        Dim rpta As Integer
        rpta = MessageBox.Show("Esta Seguro de Eliminar el ITEM Seleccionado" + Chr(13) + _
                                "Este Proceso es Irreversible...", "CEFE", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2)
        If rpta = 6 Then
            Dim mfila As DataRow = dsParaTransformar.Tables("detalle").Rows(dataParaTransformar.CurrentRow.Index)
            dataParaTransformar.Rows.Remove(dataParaTransformar.CurrentRow)
            dataParaTransformar.Refresh()
        End If
    End Sub
    Private Sub cmdTransformar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTransformar.Click
        If Not IsDBNull(dataSaldos("cod_art", dataSaldos.CurrentRow.Index).Value) Then
            If cboAlmacen.SelectedIndex <> -1 Then
                If dataParaTransformar.RowCount > 0 Then
                    If Microsoft.VisualBasic.Len(txtTransformar.Text) > 0 Then
                        If dataCatalogo.RowCount > 0 Then
                            Dim mSalida As New Salida, mIngreso As New Ingreso, mTransformacion As New Transformacion, mreceta As New Receta
                            Dim rpta As Integer, cantidad, newCantidad, newporc As Decimal, tm As String, tc As Decimal, I As Integer
                            Dim opeSalida, opeIngreso, nSalida, nIngreso, newIngreso, newSalida As Integer
                            Dim pre_incImp As Integer, imp, imptotal As Decimal
                            Dim cod_art, newCod_art As String, precio, newPrecio As Decimal
                            Dim mFecha = dtiTransf.Value
                            Dim cPrecioProm As String = general.strPrecioCostoPromedio, mPrecio As New ePrecio
                            Dim nPrecioProm As Decimal
                            Dim esProduccion As Boolean = IIf(chkprocesar.Checked, True, False)
                            Dim desOperacion As String = IIf(chkprocesar.Checked, "PRODUCCION", "TRANSFORMACION")
                            opeSalida = mSalida.maxOperacion
                            opeIngreso = mIngreso.maxOperacion
                            'nroTransformacion = mTransformacion.maxTransformacion
                            cod_art = dataSaldos("cod_art", dataSaldos.CurrentRow.Index).Value
                            precio = dataSaldos("precio", dataSaldos.CurrentRow.Index).Value
                            cantidad = txtTransformar.Text
                            imptotal = precio * cantidad
                            tm = dataSaldos("tm", dataSaldos.CurrentRow.Index).Value
                            tc = dataSaldos("tc", dataSaldos.CurrentRow.Index).Value
                            Dim cDocumento As String = Microsoft.VisualBasic.Right("00000000" & IIf(esProduccion, mreceta.maxProduccion, mTransformacion.maxTransformacion), 8)
                            rpta = MessageBox.Show("¿Esta Seguro de Realizar la " & desOperacion & "...?", "CEFE", _
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                            nIngreso = mIngreso.maxIngreso
                            If rpta = 6 Then
                                'grabamos la cabecera de la salida
                                If esProduccion = False Then
                                    mSalida.insertar(opeSalida, 0, "91", "T01", cDocumento, mFecha, "00000000", "00000000000", "00", 1, pre_incImp, pDecimales, cboAlmacen.SelectedValue, pMonedaAbr, "", "00", pCuentaUser)
                                    mSalida.insertar_det(opeSalida, nSalida, nIngreso, cod_art, cantidad, precio, imp, 0, 0)
                                Else
                                    mIngreso.insertar(opeIngreso, "93", "P01", cDocumento, "000", "00000000", 0, mFecha, "00000000000", "01", cboAlmacen.SelectedValue, "0000", 1, False, pDecimales, "Producción", "S", pTC, pCuentaUser, pmaquina)
                                    mIngreso.insertar_det(opeIngreso, nIngreso, cod_art, cantidad, precio, pCuentaUser, pIGV)
                                End If
                                

                                
                                'recuperamos los lotes del producto a transformar
                                'y descargamos las salidas correspondientes
                                'Dim dsLotes As New DataSet
                                'Dim mCatalogo As New Catalogo
                                'Dim nlStock, nlCantidad As Decimal
                                'nlCantidad = cantidad
                                'dsLotes = mCatalogo.recuperaSaldos(False, "", False, True, cboAlmacen.SelectedValue, False, "", False, True, cod_art, pDecimales)
                                'For I = 0 To dsLotes.Tables("saldo").Rows.Count - 1
                                '    nlStock = dsLotes.Tables("saldo").Rows(I).Item("saldo").ToString
                                '    nSalida = mSalida.maxSalida
                                '    nIngreso = dsLotes.Tables("saldo").Rows(I).Item("ingreso").ToString
                                '    If nlCantidad > nlStock Then
                                '        mSalida.insertar_det(opeSalida, nSalida, nIngreso, cod_art, nlStock, precio, imp, 0, 0)
                                '        nlCantidad = nlCantidad - nlStock
                                '    Else
                                '        mSalida.insertar_det(opeSalida, nSalida, nIngreso, cod_art, nlCantidad, precio, imp, 0, 0)
                                '        Exit For
                                '    End If
                                'Next
                                'para la transformacion los precios no incluyen impuesto
                                pre_incImp = 0
                                imp = IIf(IsDBNull(dataSaldos("igv", dataSaldos.CurrentRow.Index).Value), 0.0, _
                                                            dataSaldos("igv", dataSaldos.CurrentRow.Index).Value)


                                'grabamos la cabecera del ingreso
                                If esProduccion = False Then
                                    mIngreso.insertar(opeIngreso, "91", "T01", cDocumento, "000", "00000000", 0, mFecha, "00000000000", "01", cboAlmacen.SelectedValue, "0000", 1, pre_incImp, pDecimales, "Transformacion de Productos", tm, tc, pCuentaUser, pmaquina)
                                Else
                                    mSalida.insertar_aux(opeSalida, 0, "93", "P01", cDocumento, mFecha, "", "00000000", "00000000000", "01", 1, 0, pDecimales, cboAlmacen.SelectedValue, "0000", "", "00", pCuentaUser, pCuentaUser, 0, "", "")
                                End If
                                For I = 0 To dataParaTransformar.RowCount - 1
                                    newIngreso = mIngreso.maxIngreso
                                    newSalida = mSalida.maxSalida
                                    newCantidad = dataParaTransformar("cantidad", I).Value
                                    newCod_art = dataParaTransformar("cod_art", I).Value
                                    newporc = dataParaTransformar("porcentaje", I).Value / 100
                                    If newporc > 0 Then
                                        newPrecio = precioTransformacion(imptotal, newCantidad, newporc)
                                        nPrecioProm = mPrecio.calculaPrecioPromedioh(newCod_art, "esIngreso", cPrecioProm, False, "")
                                        mPrecio.actualizaPrecioPromedio(newCod_art)
                                    Else
                                        newPrecio = mPrecio.devuelvePrecioPromedio(newCod_art)
                                    End If
                                    Dim afecto As Boolean = dataParaTransformar("afecto_igv", I).Value
                                    If esProduccion = False Then
                                        mIngreso.insertar_det(opeIngreso, newIngreso, newCod_art, newCantidad, newPrecio, pCuentaUser, IIf(afecto, pIGV, imp))

                                    Else
                                        mSalida.insertar_det(opeSalida, newSalida, newIngreso, newCod_art, newCantidad, newPrecio, 0, 0, 0)
                                    End If

                                Next
                            End If


                                limpia()
                                muestraSaldos()
                                cargaTransformaciones()
                                dataSaldos.Focus()
                                txtBuscarArticulo.Focus()
                            Else
                                MessageBox.Show("Seleccione el Nuevo Producto...", "CEFE", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                                txtBuscar.Focus()
                            End If
                        Else
                            MessageBox.Show("Ingrese la Cantidad a Transformar...", "CEFE", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                            txtTransformar.Focus()
                        End If
                    Else
                        MessageBox.Show("Seleccione el Producto o Productos a Transformar...", "CEFE", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        dataSaldos.Focus()
                    End If
                Else
                    MessageBox.Show("Seleccione el Almacén...", "CEFE", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    cboAlmacen.Focus()
                End If
            Else
                MessageBox.Show("Seleccione el Producto a Transformar...", "CEFE", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                dataSaldos.Focus()
            End If
    End Sub
    Function precioTransformacion(ByVal imptotal As Decimal, ByVal cant As Decimal, ByVal nporc As Decimal) As Decimal
        Dim nPrecio As Decimal
        'For I = 0 To dataParaTransformar.RowCount - 1
        '    nTotal = nTotal + dataParaTransformar("cantidad", I).Value
        'Next
        'nPrecio = imptotal / nTotal
        nPrecio = Round((imptotal * nporc) / cant, 3)
        Return nPrecio
    End Function
    Sub establecefechas()
        'dtiTransf.ResetMinDate()
        'dtiTransf.MinDate = pFechaActivaMin
        'dtiTransf.ResetMaxDate()
        'dtiTransf.MaxDate = pFechaActivaMax
        'dtiTransf.Value = pFechaSystem

        dtiTransf.MinDate = pFechaActivaMin
        dtiTransf.MaxDate = pFechaSystem
        'dtiTransf.DisplayMonth = pFechaSystem
        dtiTransf.Value = pFechaSystem
    End Sub
    Sub cargaTransformaciones()
        Dim mTransformacion As New Transformacion
        dsTransformacionS = mTransformacion.recTransformacionS(True, dtiTransf.Value)
        dataTransformacion.DataSource = dsTransformacionS.Tables("transformacion")
        estructuraTransformaciones()
    End Sub
    Sub estructuraTransformaciones()
        With dataTransformacion
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("fec_doc").HeaderText = "Fecha"
            .Columns("fec_doc").Width = 70
            .Columns("fec_doc").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("nro_doc").HeaderText = "NºTrans."
            .Columns("nro_doc").Width = 60
            .Columns("nro_doc").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_art").HeaderText = "Código"
            .Columns("cod_art").Width = 50
            .Columns("cod_art").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("nom_art").HeaderText = "Descripción"
            .Columns("nom_art").Width = 220
            .Columns("nom_uni").HeaderText = "Unidad"
            .Columns("nom_uni").Width = 60
            .Columns("nom_uni").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cant").HeaderText = "Cant."
            .Columns("cant").Width = 70
            .Columns("cant").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("precio").Visible = False
            .Columns("operacion").Visible = False
            .Columns("ingreso").Visible = False
            .Columns("salida").Visible = False
            .Columns("cod_alma").Visible = False
        End With
    End Sub
    Private Sub dataTransformacion_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataTransformacion.CellDoubleClick
        If dataTransformacion.RowCount > 0 Then
            eliminaTRANS()
        End If
    End Sub
    Private Sub dataTransformacion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dataTransformacion.KeyDown
        If e.KeyCode = Keys.Delete Then
            'If esEditable() Then
            eliminaTRANS()
            'End If
        End If
    End Sub
    Private Sub dataTransformacion_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dataTransformacion.SelectionChanged
        dsTransformacionI.Clear()
        If dataTransformacion.RowCount > 0 Then
            Dim nro As String = dataTransformacion("nro_doc", dataTransformacion.CurrentRow.Index).Value
            cargaTransformacionesI(nro)
        End If
    End Sub
    Sub cargaTransformacionesI(ByVal nro_doc As String)
        Dim mTransformacion As New Transformacion
        dsTransformacionI = mTransformacion.recTransformacionI(nro_doc)
        dataTransformacionI.DataSource = dsTransformacionI.Tables("transformacion")
        estructuraTransformacionesI()
    End Sub
    Sub estructuraTransformacionesI()
        With dataTransformacionI
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cod_art").HeaderText = "Código"
            .Columns("cod_art").Width = 55
            .Columns("cod_art").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("nom_art").HeaderText = "Descripción"
            .Columns("nom_art").Width = 230
            .Columns("nom_uni").HeaderText = "Unidad"
            .Columns("nom_uni").Width = 60
            .Columns("nom_uni").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cant").HeaderText = "Cant."
            .Columns("cant").Width = 75
            .Columns("cant").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("fec_doc").Visible = False
            .Columns("nro_doc").Visible = False
            .Columns("precio").Visible = False
            .Columns("operacion").Visible = False
            .Columns("ingreso").Visible = False
            .Columns("cod_alma").Visible = False
        End With
    End Sub
    Sub eliminaTRANS()

        Dim mIngreso As New Ingreso
        Dim I As Integer = 0, eliminar As Boolean = True
        Dim cad As String, nOperacion As Integer
        'For I = 0 To dataTransformacionI.RowCount - 1
        '    Dim nIngreso As Integer = dataTransformacionI("ingreso", I).Value
        '    If mIngreso.existeSalida(nIngreso, False) Then
        '        eliminar = False
        '        MessageBox.Show("El Artículo: " & dataTransformacionI("nom_art", I).Value & Chr(13) & " Ya Tiene Salidas...", "CEFE", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    End If
        'Next
        If eliminar Then
            Dim rpta As Integer
            Dim nro As String = dataTransformacion("nro_doc", dataTransformacion.CurrentRow.Index).Value
            rpta = MessageBox.Show("Esta Seguro de Eliminar la Transformación: " & nro, "CEFE", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If rpta = 6 Then
                If dataTransformacionI.RowCount > 0 Then
                    nOperacion = dataTransformacionI("operacion", dataTransformacionI.CurrentRow.Index).Value
                    cad = "delete from ingreso where operacion=" & nOperacion
                    Dim com As New MySqlCommand(cad, dbConex)
                    com.ExecuteNonQuery()
                End If
                If dataTransformacion.RowCount > 0 Then
                    nOperacion = dataTransformacion("operacion", dataTransformacion.CurrentRow.Index).Value
                    cad = "update salida_det set cant=0 where operacion=" & nOperacion
                    Dim com2 As New MySqlCommand(cad, dbConex)
                    com2.ExecuteNonQuery()
                    cad = "delete from salida where operacion=" & nOperacion
                    Dim com3 As New MySqlCommand(cad, dbConex)
                    com3.ExecuteNonQuery()
                End If
            End If
        End If
        cargaTransformaciones()
    End Sub



    Private Sub dataParaTransformar_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dataParaTransformar.DoubleClick
        EliminaProducto()
    End Sub



    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub dtiTransf_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtiTransf.ValueChanged
        cargaTransformaciones()
    End Sub


    Private Sub dataTransformacionI_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dataTransformacionI.KeyDown
        If (e.Control And e.KeyCode = Keys.E) Then
            If dataTransformacionI.RowCount > 0 Then
                EnviaraExcel(dataTransformacionI)
            End If
        End If
    End Sub

    Private Sub dataCatalogo_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataCatalogo.CellContentClick

    End Sub

    Private Sub chkprocesar_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkprocesar.CheckedChanged
        If chkprocesar.Checked = True Then
            chkprocesar.Text = "Produccion"
        Else
            chkprocesar.Text = "Transformacion"
        End If
    End Sub


    Private Sub dtiTransf_Click(sender As Object, e As EventArgs) Handles dtiTransf.Click

    End Sub
End Class
