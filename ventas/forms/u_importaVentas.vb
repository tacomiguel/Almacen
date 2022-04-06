Imports System.io
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.DateAndTime
Imports libreriaClases
Imports MySql.Data.MySqlClient
Public Class u_importaVentas
    Private dsImportacion As New DataSet
    Private dsReceta, dsReceta1, dsReceta2 As New DataSet
    Private codR, codR1 As String
    Private cantR, cantR1 As Decimal
    Private cantRD, cantR1D As Decimal
    Private R, X, Y As Integer
    Private fic As String = "C:\logPixel.txt"
    Private sw As New System.IO.StreamWriter(fic, True)
    Private Sub u_importaVentas_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        principal.mu_importarventas.Enabled = True
        sw.Close()
    End Sub
    Private Sub u_importaVentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Left = 0
        Me.Top = 0
        With datos
            .ColumnCount = 9
            .Columns(0).Name = "colFecha"
            .Columns(1).Name = "colTipo"
            .Columns(2).Name = "colSerie"
            .Columns(3).Name = "colNro"
            .Columns(4).Name = "colCodigo"
            .Columns(5).Name = "colArticulo"
            .Columns(6).Name = "colCant"
            .Columns(7).Name = "colPrecio"
            .Columns(8).Name = "colCaja"
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(0).HeaderText = "Fecha"
            .Columns(1).HeaderText = "Tipo Doc."
            .Columns(2).HeaderText = "Serie Doc."
            .Columns(3).HeaderText = "Nro Doc."
            .Columns(4).HeaderText = "Código"
            .Columns(5).HeaderText = "Artículo"
            .Columns(6).HeaderText = "Cant."
            .Columns(7).HeaderText = "Precio"
            .Columns(8).HeaderText = "Nro Caja"
            .Columns(0).Width = 70
            .Columns(1).Width = 40
            .Columns(2).Width = 40
            .Columns(3).Width = 60
            .Columns(4).Width = 60
            .Columns(5).Width = 250
            .Columns(6).Width = 50
            .Columns(7).Width = 70
            .Columns(8).Width = 50
            .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        End With
    End Sub
    Private Sub cmdExaminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExaminar.Click
        Dim oFD As New OpenFileDialog, mFile As String
        With oFD
            .Title = "Seleccionar fichero"
            .Multiselect = False
            '.Filter = "Ficheros de texto (*.txt;*.ini)|*.txt;*.ini" & _
            '          "|Todos los ficheros (*.*)|*.*"
            .Filter = "Archivo de Texto (*.txt)|*.txt"
            If .ShowDialog = System.Windows.Forms.DialogResult.OK Then
                mFile = .FileName
            Else
                mFile = ""
            End If
            txtArchivo.Text = mFile
            If mFile <> "" Then
                Dim texto As String = "", cant As Integer = 9
            End If
        End With
    End Sub
    Private Sub cmdCargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCargar.Click
        Dim fName As String = Me.txtArchivo.Text
        Dim TextLine As String = ""
        Dim SplitLine() As String
        If System.IO.File.Exists(fName) = True Then
            'limpiamos el datagrid
            Dim I As Integer = 0
            For I = 0 To datos.RowCount - 1
                datos.Rows.Remove(datos.CurrentRow)
            Next
            datos.Refresh()
            Dim objReader As New System.IO.StreamReader(fName)
            Do While objReader.Peek() <> -1
                TextLine = objReader.ReadLine()
                SplitLine = Split(TextLine, ",")
                Me.datos.Rows.Add(SplitLine)
            Loop
        Else
            MessageBox.Show("NO Existe el archivo indicado...", "CEFE", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txtArchivo.Focus()
        End If
        verificaImportacion()
    End Sub
    Sub verificaImportacion()
        Dim mUtilidades As New Utilidades
        Dim existe, existe02 As Boolean
        If datos.RowCount > 0 Then
            existe = mUtilidades.existeMigracionPixel(datos("colFecha", 0).Value)
        Else
            existe = True
        End If
        If existe Then
            cmdImportar.Enabled = False
        Else
            cmdImportar.Enabled = True
        End If
        '
        If existe = True Then 'como ya se registraron los insumos
            If datos.RowCount > 0 Then
                existe02 = mUtilidades.yaActualizoStockPixel(datos("colFecha", 0).Value)
            Else
                existe02 = True
            End If
            If existe02 Then
                cmdActualizarStock.Enabled = False
            Else
                cmdActualizarStock.Enabled = True
            End If
        Else
            cmdActualizarStock.Enabled = False
        End If
        datos.Focus()
    End Sub
    Private Sub cmdImportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImportar.Click
        If datos.RowCount > 0 Then
            Dim dsStock As New DataSet
            Dim cFecha As Date, cTipoDoc, cSerie, cNro, cCodigoExt, cArticulo, cCaja As String
            Dim nOperacion As Integer, cod_rec As String
            Dim mCatalogo As New Catalogo
            Dim graboCabecera As Boolean = False, tcNro As String = ""
            Dim nCantidad, nPrecio As Decimal
            Dim nroReg, I As Integer
            Dim mUtil As New Utilidades
            nroReg = datos.RowCount
            lblProcesados.Visible = True
            For I = 0 To nroReg - 1
                lblProcesados.Refresh()
                cFecha = datos("colFecha", I).Value
                cTipoDoc = datos("colTipo", I).Value
                cSerie = datos("colSerie", I).Value
                cNro = datos("colNro", I).Value
                cCaja = datos("colCaja", I).Value
                cCodigoExt = datos("colCodigo", I).Value
                cArticulo = datos("colArticulo", I).Value
                nCantidad = datos("colCant", I).Value
                nPrecio = datos("colPrecio", I).Value
                If tcNro <> cNro Then
                    graboCabecera = False
                End If
                If Not graboCabecera Then
                    tcNro = cNro
                    nOperacion = mUtil.maxOperacionPixel
                    mUtil.insertar_ventasPixel(nOperacion, cFecha, cTipoDoc, cSerie, cNro, cCaja)
                    graboCabecera = True
                End If
                cod_rec = devuelveCodReceta(cCodigoExt)
                registraInsumos(cod_rec, nCantidad, nPrecio, nOperacion)
                lblProcesados.Text = I + 1 & " de " & nroReg
            Next
            MessageBox.Show("Importación de Datos Finalizada...", "CEFE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            lblProcesados.Visible = False
            verificaImportacion()
        Else
            MessageBox.Show("La Fecha de Importación NO Coincide con los Datos a Importar...")
        End If
    End Sub
    Function devuelveCodReceta(ByVal cCodigoExt As String) As String
        Dim mUtil As New Utilidades
        Dim I2 As Integer = 0
        Dim cod_rec As String = ""
        For I2 = 0 To 4
            Select Case I2
                Case 0
                    cod_rec = mUtil.devuelveCodigoInterno(cCodigoExt, "", "", "", "")
                Case 1
                    cod_rec = mUtil.devuelveCodigoInterno("", cCodigoExt, "", "", "")
                Case 2
                    cod_rec = mUtil.devuelveCodigoInterno("", "", cCodigoExt, "", "")
                Case 3
                    cod_rec = mUtil.devuelveCodigoInterno("", "", "", cCodigoExt, "")
                Case 4
                    cod_rec = mUtil.devuelveCodigoInterno("", "", "", "", cCodigoExt)
            End Select
            If Len(cod_rec) > 0 Then
                Exit For
            End If
        Next
        Return cod_rec
    End Function
    Sub registraInsumos(ByVal cod_rec As String, ByVal cantVendida As Decimal, _
                ByVal precio As Decimal, ByVal operacion As Integer)
        If Len(cod_rec) > 0 Then
            Dim mPixel As New Utilidades
            Dim nIngreso As Integer
            lblProcesados.Refresh()
            dsReceta.Clear()
            muestraReceta(cod_rec, 0)
            If dsReceta.Tables("receta").Rows.Count > 0 Then
                For X = 0 To dsReceta.Tables("receta").Rows.Count - 1
                    almacenaDatos(cantVendida)
                    dsReceta1.Clear()
                    muestraReceta(codR, 1)
                    If dsReceta1.Tables("receta").Rows.Count > 0 Then
                        For Y = 0 To dsReceta1.Tables("receta").Rows.Count - 1
                            almacenaDatos1()
                            nIngreso = mPixel.maxIngresoPixel
                            mPixel.insertar_ventasPixel_det(operacion, nIngreso, codR1, cantR1D, precio)
                        Next
                    Else
                        nIngreso = mPixel.maxIngresoPixel
                        mPixel.insertar_ventasPixel_det(operacion, nIngreso, codR, cantRD, precio)
                    End If
                Next
            Else
                nIngreso = mPixel.maxIngresoPixel
                mPixel.insertar_ventasPixel_det(operacion, nIngreso, cod_rec, cantVendida, precio)
            End If
        End If
    End Sub
    Sub muestraReceta(ByVal cod_rec As String, ByVal nro As Integer)
        Dim mReceta As New Receta
        If nro = 0 Then
            dsReceta = mReceta.recuperaReceta(cod_rec)
        End If
        If nro = 1 Then
            dsReceta1 = mReceta.recuperaReceta(cod_rec)
        End If
    End Sub
    Sub almacenaDatos(ByVal cantVendida As Decimal)
        codR = dsReceta.Tables("receta").Rows(X).Item("cod_art").ToString
        If dsReceta.Tables("receta").Rows(X).Item("cant_uni").ToString > 1 Then
            cantR = dsReceta.Tables("receta").Rows(X).Item("cant").ToString
        Else
            cantR = dsReceta.Tables("receta").Rows(X).Item("cant").ToString / dsReceta.Tables("receta").Rows(X).Item("cant_uni").ToString
        End If
        cantRD = cantVendida * cantR
    End Sub
    Sub almacenaDatos1()
        codR1 = dsReceta1.Tables("receta").Rows(Y).Item("cod_art").ToString
        If dsReceta.Tables("receta").Rows(Y).Item("cant_uni").ToString > 1 Then
            cantR1 = dsReceta1.Tables("receta").Rows(Y).Item("cant").ToString
        Else
            cantR1 = dsReceta1.Tables("receta").Rows(Y).Item("cant").ToString / dsReceta.Tables("receta").Rows(Y).Item("cant_uni").ToString
        End If
        cantR1D = cantRD * cantR1
    End Sub
    Sub inicializaVariables()
        codR = ""
        codR1 = ""
        cantR = 0.0
        cantR1 = 0.0
        cantRD = 0.0
        cantR1D = 0.0
        X = 0
        Y = 0
    End Sub
    Private Sub cmdActualizarStock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdActualizarStock.Click
        If datos.RowCount > 0 Then
            Dim cFecha As Date, I, I2, nOperacion01, nOperacion02 As Integer
            Dim mUtil As New Utilidades, dsVentas As New DataSet, dsLotes As New DataSet
            Dim mSalida As New Salida, mCatalogo As New Catalogo
            cFecha = datos("colFecha", 0).Value
            dsVentas = mUtil.recVentasPixel(cFecha)
            Dim cCodigo As String, nlCantidad, nlStock, ntStock As Decimal, nSalida, nIngreso As Integer
            Dim cDocumento As String = Microsoft.VisualBasic.Right("00000000" & Day(cFecha), 8)
            nOperacion01 = mSalida.maxOperacion
            mSalida.insertar(nOperacion01, 0, "04", "001", cDocumento, cFecha, "00000000", "00000000000", "01", 1, 1, pDecimales, "0001", pMonedaAbr, "Migración Pixel", "", pCuentaUser)
            nOperacion02 = mSalida.maxOperacion
            mSalida.insertar(nOperacion02, 0, "04", "002", cDocumento, cFecha, "00000000", "00000000000", "01", 1, 1, pDecimales, "0002", pMonedaAbr, "Migración Pixel", "", pCuentaUser)
            lblProcesados2.Visible = True
            For I = 0 To dsVentas.Tables("venta").Rows.Count - 1
                lblProcesados2.Refresh()
                cCodigo = dsVentas.Tables("venta").Rows(I).Item("codigo").ToString
                nlCantidad = dsVentas.Tables("venta").Rows(I).Item("cant").ToString
                ntStock = mCatalogo.recuperaStockArticulo(False, "", False, True, "0001", cCodigo, 0)
                If ntStock > 0 Then
                    dsLotes = mCatalogo.recuperaSaldos(False, "", False, True, "0001", False, "", False, True, cCodigo, pDecimales)
                    For I2 = 0 To dsLotes.Tables("saldo").Rows.Count - 1
                        nlStock = dsLotes.Tables("saldo").Rows(I2).Item("saldo").ToString
                        nSalida = mSalida.maxSalida
                        nIngreso = dsLotes.Tables("saldo").Rows(I2).Item("ingreso").ToString
                        If nlCantidad > nlStock Then
                            mSalida.insertar_det(nOperacion01, nSalida, nIngreso, cCodigo, nlStock, 0, pIGV, 0, 0)
                            nlCantidad = nlCantidad - nlStock
                        Else
                            mSalida.insertar_det(nOperacion01, nSalida, nIngreso, cCodigo, nlCantidad, 0, pIGV, 0, 0)
                            Exit For
                        End If
                        If nlCantidad = 0 Then
                            Exit For
                        End If
                    Next
                Else
                    ntStock = mCatalogo.recuperaStockArticulo(False, "", False, True, "0002", cCodigo, 0)
                    If ntStock > 0 Then
                        dsLotes = mCatalogo.recuperaSaldos(False, "", False, True, "0002", False, "", False, True, cCodigo, pDecimales)
                        For I2 = 0 To dsLotes.Tables("saldo").Rows.Count - 1
                            nlStock = dsLotes.Tables("saldo").Rows(I2).Item("saldo").ToString
                            nSalida = mSalida.maxSalida
                            nIngreso = dsLotes.Tables("saldo").Rows(I2).Item("ingreso").ToString
                            If nlCantidad > nlStock Then
                                mSalida.insertar_det(nOperacion02, nSalida, nIngreso, cCodigo, nlStock, 0, pIGV, 0, 0)
                                nlCantidad = nlCantidad - nlStock
                            Else
                                mSalida.insertar_det(nOperacion02, nSalida, nIngreso, cCodigo, nlCantidad, 0, pIGV, 0, 0)
                                Exit For
                            End If
                            If nlCantidad = 0 Then
                                Exit For
                            End If
                        Next
                    End If
                End If
                lblProcesados2.Text = I + 1 & " de " & dsVentas.Tables("venta").Rows.Count
            Next
            verificaImportacion()
            lblProcesados2.Visible = False
            MessageBox.Show("Proceso Finalizado...")
        Else
            MessageBox.Show("Seleccione los datos a Registrar...")
        End If
    End Sub
End Class
