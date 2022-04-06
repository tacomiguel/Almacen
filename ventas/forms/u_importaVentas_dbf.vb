Imports System.IO
Imports System.Data
Imports System.Data.Odbc
Imports System.Data.OleDb
Imports libreriaClases
Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient

Public Class u_importaVentas_dbf
    Private dsImportacion As New DataSet
    Private dsAlmacen As New DataSet
    Private dview As New DataView
    Private estaCargando As Boolean = True
    Private dbConexSQl As SqlConnection = Conexion.obtenerConexionSQL()

    Private Sub u_importaVentas_dbf_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        principal.mu_importarventas.Enabled = True
    End Sub

    Private Sub u_importaVentas_dbf_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If (e.Control And e.KeyCode = Keys.V) Then
            Dim data As IDataObject = Clipboard.GetDataObject
            Dim i As Integer = 0
            Dim j As Integer = 0
            If Not data.GetDataPresent("CSV", False) Then Return

            Try
                'Dim da As New MySqlDataAdapter
                Dim ds As New DataSet
                Dim dt As New DataTable
                'dt.Columns.Add(New DataColumn("fecha", GetType(Date)))
                dt.Columns.Add(New DataColumn("numdoc", GetType(String)))
                dt.Columns.Add(New DataColumn("Codigo", GetType(String)))
                dt.Columns.Add(New DataColumn("Nombre", GetType(String)))
                dt.Columns.Add(New DataColumn("Cantidad", GetType(Decimal)))
                dt.Columns.Add(New DataColumn("Importe", GetType(Decimal)))
                dt.Columns.Add(New DataColumn("Descuento", GetType(Decimal)))
                dt.Columns.Add(New DataColumn("Almacen", GetType(String)))
                ds.Tables.Add(dt)
                'da.Fill(dt)
                datos.DataSource = dt

                'Obtenemos el texto almacenado en el portapapales 
                Dim s As String = Clipboard.GetText

                'hacemos un split para organizar la informacion por lineas 
                Dim lines As String() = s.Split(New Char(1) {ControlChars.Cr, ControlChars.Lf}, StringSplitOptions.RemoveEmptyEntries)
                Dim vdr(6) As Object
                'Ciclo para cada linea del copy 
                For Each line As String In lines
                    'Creamos una fila referenciando a la tabla datasource del DataGridView 
                    Dim dr As DataRow = dt.NewRow()

                    'Obtenemos las celdas que el usuario copia 
                    Dim cells As String() = line.Split(ControlChars.Tab)

                    'Burbuja para asignar cada uno de los datos de cada columna copia 

                    For Each cell As String In cells

                        'If j = 0 Then
                        '    dr.Item(j) = 0
                        'Else
                        'dr.Item(j) = cell
                        vdr(j) = cell
                        'End If
                        j = j + 1
                    Next
                    i = i + 1
                    j = 0
                    'Agregamos la fila a la tabla 
                    dt.Rows.Add(vdr)
                Next
                datos.Refresh()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
    Private Sub u_importaVentas_dbf_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Left = 0
        Me.Top = 0
        estructuradatos()
        'Dim daAlmacen As New MySqlDataAdapter
        'Dim cadAlma As String
        'If pAlmaUser = "0000" Then
        '    cadAlma = "select cod_alma,nom_alma from almacen where (esProduccion) and activo=1"
        'Else
        '    cadAlma = "select cod_alma,nom_alma from almacen where cod_alma='" & pAlmaUser & "' and (esProduccion) and activo=1"
        'End If
        'Dim comAlmacen As New MySqlCommand(cadAlma, dbConex)
        'daAlmacen.SelectCommand = comAlmacen
        'daAlmacen.Fill(dsAlmacen, "almacen")
        'With cboImportacion
        '    .DataSource = dsAlmacen.Tables("almacen")
        '    .DisplayMember = dsAlmacen.Tables("almacen").Columns("nom_alma").ToString
        '    .ValueMember = dsAlmacen.Tables("almacen").Columns("cod_alma").ToString
        '    If dsAlmacen.Tables("almacen").Rows.Count > 0 Then
        '        .SelectedIndex = 0
        '    End If
        'End With
        cboImportacion.SelectedIndex = 1
        estableceFechas()
        estaCargando = False
    End Sub
    Private Sub cmdExaminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExaminar.Click
        Dim oFD As New OpenFileDialog, mFile As String
        With oFD
            .Title = "Seleccionar fichero"
            .Multiselect = False
            '.Filter = "Ficheros de texto (*.txt;*.ini)|*.txt;*.ini" & _
            '          "|Todos los ficheros (*.*)|*.*"
            .Filter = "Archivo de Importacion (*.xls)|*.xls"
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

    Private Sub dtiFecha_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtiFecha.ValueChanged
        If Not estaCargando Then
            verificaImportacion()
        End If
    End Sub
    Private Function verificaImportacion()
        Dim mMicros As New micros
        Dim existe As Boolean = mMicros.existeMigracionMicros(dtiFecha.Value, cboImportacion.SelectedIndex)

        If existe Then
            cmdImportar.Enabled = False
        Else
            cmdImportar.Enabled = True
        End If
        Return existe
    End Function
    Private Sub CreateTextDelimiterFile(ByVal fileName As String,
                                        ByVal ds As DataSet,
                                        ByVal dataTableName As String,
                                        Optional ByVal separatorChar As Char = ";"c,
                                        Optional ByVal textDelimiter As Boolean = True)

        '*******************************************************************
        ' Nombre:        CreateTextDelimiterFile
        '                por Enrique Martínez Montejo - 18/05/2006
        '
        ' Versión:       1.0
        '
        ' Finalidad:     Crear un archivo de texto delimitado con el contenido
        '                de un objeto DataTable.
        '
        ' Entradas:
        '     fileName:  String. Ruta y nombre del archivo de texto.
        '
        '     ds:        DataSet. Un objeto DataSet válido.
        '
        '     dataTableName: String. El nombre de un objeto DataTable
        '                    incluido en el objeto DataSet
        '
        '     separatorChar: Char. El carácter delimitador de los campos. Por
        '                    defecto se utilizará el punto y coma.
        '
        '     textDelimiter: Boolean. Indica si los campos alfanuméricos deben
        '                    aparecer entre comillas dobles.
        '
        '*******************************************************************

        ' Si no se ha especificado un nombre de archivo,
        ' o el objeto DataSet no es válido, provocamos
        ' una excepción de argumentos no válidos.
        '
        If ((fileName.Length = 0) Or (dataTableName.Length = 0) Or (ds Is Nothing)) Then
            Throw New System.ArgumentException("Argumentos no válidos.")
        End If

        ' Si el archivo existe, solicitamos la confirmación
        ' para sobreescribirlo.
        '
        If (IO.File.Exists(fileName)) Then
            If (MessageBox.Show("¿Desea sobreescribir el archivo " & fileName & "?",
                            "Crear archivo de texto",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Information) = Windows.Forms.DialogResult.No) Then
                ' Abandonamos el procedimiento
                Return
            End If
        End If
        Dim sw As System.IO.StreamWriter
        Try
            Dim dc As DataColumn
            Dim dr As DataRow
            Dim col As Integer
            Dim value As String = ""
            ' Creamos el archivo de texto
            sw = New System.IO.StreamWriter(fileName)
            ' Recorremos todas las filas del objeto DataTable
            ' incluido en el conjunto de datos.
            For Each dr In ds.Tables(dataTableName).Rows
                For Each dc In ds.Tables(dataTableName).Columns
                    If (dc.DataType Is System.Type.GetType("System.String")) And
                       (textDelimiter = True And Not IsDBNull(dr.Item(col))) Then
                        ' Incluimos el dato alfanumérico entre el caracter
                        ' delimitador de texto especificado.
                        value &= "'" & dr.Item(col).ToString & "'" & separatorChar
                    Else
                        ' No se incluye caracter delimitador de texto alguno
                        value &= dr.Item(col).ToString & separatorChar
                    End If
                    ' Siguiente columna
                    col += 1
                Next
                ' Al escribir los datos en el archivo, elimino el
                ' último carácter delimitador de la fila.
                '
                sw.WriteLine(value.Remove(value.Length - 1, 1))
                value = ""
                col = 0
            Next ' Siguiente fila
            ' Nos aseguramos de cerrar el archivo
            sw.Close()
        Catch ex As Exception
            ' Devolvemos la excepción al procedimiento llamador
            MsgBox(ex.Message)
        Finally
            sw = Nothing
        End Try
    End Sub
    Function gridatxt(ByVal Grid As DataGridView) As Boolean
        Dim i, a, b As Integer
        Dim texto As StreamWriter
        Dim escribo As String
        Dim filas As Integer
        Dim columnas As Integer
        Dim titulo As String = ""
        Dim palabra As String
        Dim letras As Integer
        Dim nuevo As String
        filas = Grid.RowCount - 1
        columnas = Grid.ColumnCount - 1
        texto = New StreamWriter("C:\PRUEBA.txt")
        Dim tamaño(columnas) As Integer
        For i = 0 To columnas
            tamaño(i) = 0
        Next
        For a = 0 To filas
            Grid.CurrentCell = Grid.Rows(a).Cells(0)
            For b = 0 To columnas
                titulo = Grid.Columns(b).Name
                If IsDBNull(Grid.CurrentRow.Cells.Item(titulo).Value) Then
                    palabra = "NULL"
                Else
                    palabra = Grid.CurrentRow.Cells.Item(titulo).Value
                End If
                letras = palabra.Length
                If letras > tamaño(b) Then
                    tamaño(b) = letras
                End If
            Next
        Next
        For a = 0 To filas
            escribo = ""
            Grid.CurrentCell = Grid.Rows(a).Cells(0)
            For b = 0 To columnas
                titulo = Grid.Columns(b).Name
                If b = 0 Then
                    If IsDBNull(Grid.CurrentRow.Cells.Item(titulo).Value) Then
                        escribo = "NULL"
                    Else
                        escribo = Grid.CurrentRow.Cells.Item(titulo).Value
                        letras = escribo.Length
                    End If
                Else
                    If IsDBNull(Grid.CurrentRow.Cells.Item(titulo).Value) Then
                        escribo = "NULL"
                    Else
                        nuevo = Grid.CurrentRow.Cells.Item(titulo).Value
                        letras = nuevo.Length
                        Do While letras < tamaño(b)
                            nuevo = nuevo & " "
                            letras = letras + 1
                        Loop
                        escribo = escribo & "" & nuevo
                    End If
                End If
            Next
            texto.WriteLine(escribo)
        Next
        texto.Close()
    End Function
    Sub importarventas(ByVal fechaI As Date)
        Dim objconexionODBC As Odbc.OdbcConnection = Conexion.obtenerConexionODBC()
        Dim daArticulo As New Odbc.OdbcDataAdapter
        Dim dscatalogo As New DataSet
        Dim mfechaI As String = fechaI.ToString("yyyy-MM-dd")
        Dim strSQl As String = " SELECT '' as numdoc,menuitem_number as Codigo, menuitem_name2 as Nombre,p1_sales_qty as Cantidad,p1_sales_total as Importe,p1_discount_total as Descuento,'' as Almacen" &
    " FROM micros.v_r_sys_menuitem " &
    " WHERE business_date = '" & mfechaI & "' "
        Dim mycomand As New Odbc.OdbcCommand(strSQl, objconexionODBC)
        daArticulo.SelectCommand = mycomand
        daArticulo.Fill(dscatalogo, "items")
        datos.DataSource = dscatalogo.Tables("items").DefaultView

    End Sub

    Sub importarventasSQL(ByVal fechaI As Date, ByVal tipo As Integer)
        Dim mfechaI As String = fechaI.ToString("yyyy-MM-dd")
        Dim oComando = New SqlCommand()
        Dim oDataAdapter As SqlDataAdapter
        Dim dsDocumentos As New DataSet
        Dim strsql As String
        If tipo = 1 Then
            strsql = "Select cdtipodocu,TIPCREDLET,nrodocum,fecdocum,rucclient,nomclient,dirclient,subtotal,igv,total,nroptovta " &
            " FROM factura_h where fecproceso BETWEEN '" & fechaI & "' AND '" & fechaI & "'"

        Else
            strsql = "Select nrontacred,n.cdtipodocu,'07' as cod_doc,seriedocu ,n.nrodocum,n.fecdocum,n.rucclient,n.nomclient,n.dirclient,n.subtotal,n.igv,n.total,n.nroptovta,TIPCREDLET " &
            " From NCREDITO_h  n  inner Join factura_h f  on n.CDTIPODOCU=f.CDTIPODOCU And n.NRODOCUM=f.NRODOCUM " &
            " where n.fecproceso BETWEEN '" & fechaI & "' AND '" & fechaI & "'"

        End If



        oDataAdapter = New SqlDataAdapter(StrSQl, dbConexSQl)

        oDataAdapter.Fill(dsDocumentos, "items")
        'datos.DataSource = dsDocumentos.Tables("items").DefaultView
        'Dim dtab As DataTable = dsDocumentos.Tables("items")
        dview.Table = dsDocumentos.Tables("items")
        'Dim dview As DataView = dtab.DefaultView
        datos.DataSource = dview


    End Sub

    Sub importar_NCreditoSQL(ByVal fechaI As Date)
        Dim mfechaI As String = fechaI.ToString("yyyy-MM-dd")
        Dim oComando = New SqlCommand()
        Dim oDataAdapter As SqlDataAdapter
        Dim dsDocumentos As New DataSet
        Dim StrSQl As String = "Select nrontacred,cdtipodocu,'07' as cod_doc,seriedocu ,nrodocum,fecdocum,rucclient,nomclient,dirclient,subtotal,igv,total,nroptovta " &
            " FROM NCREDITO_h where fecproceso BETWEEN '" & fechaI & "' AND '" & fechaI & "'"

        oDataAdapter = New SqlDataAdapter(StrSQl, dbConexSQl)

        oDataAdapter.Fill(dsDocumentos, "items")
        'datos.DataSource = dsDocumentos.Tables("items").DefaultView
        'Dim dtab As DataTable = dsDocumentos.Tables("items")
        dview.Table = dsDocumentos.Tables("items")
        'Dim dview As DataView = dtab.DefaultView
        datos.DataSource = dview


    End Sub

    Sub importarventasSQL_det(ByVal operacion As Integer, ByVal tip_doc As String, ByVal num_doc As String, ByVal tipodoc As Integer)
        Dim oComando = New SqlCommand()
        Dim msalida As New Salida
        Dim dsDocumentos As New DataSet
        Dim strsql As String
        If tipodoc = 1 Then
            strsql = "Select * from factudet_h where CDTIPODOCU = '" & tip_doc & "' and NRODOCUM = '" & num_doc & "'"
        Else
            strsql = "Select * from NCREDDET_h where nrontacred = '" & num_doc & "'"
        End If

        Dim precio, cant As Decimal
        Dim cod_art, obs As String
        Dim imptotal, impsubtotal, impigv, impDescuento, porDescuento As Decimal
        Dim command As New SqlCommand(StrSQl, dbConexSQl)
        command.CommandTimeout = 900
        Dim dr As SqlDataReader = command.ExecuteReader()

        If dr.HasRows = True Then
            While dr.Read
                Dim nroSalida As Integer = msalida.maxfactura_det
                cod_art = dr("cdarticulo")
                precio = dr("mtoprecio")
                cant = dr("cantidad")
                obs = dr("dsarticulo")
                imptotal = dr("total")
                impsubtotal = dr("subtotal")
                impDescuento = dr("MTODSCTOI")
                porDescuento = dr("PORCDCTOI1")
                impigv = dr("igv")

                msalida.insertar_factura_det(operacion, nroSalida, 0, cod_art, cant, precio, pIGV, obs, "", imptotal, impsubtotal, impDescuento, porDescuento, impigv)
            End While
        End If
        dr.Close()

    End Sub

    Sub ActualizarPrecios(ByVal fechaI As Date)
        Dim objconexionODBC As Odbc.OdbcConnection = Conexion.obtenerConexionODBC()
        Dim daArticulo As New Odbc.OdbcDataAdapter
        Dim dscatalogo As New DataSet
        Dim mfechaI As String = fechaI.ToString("yyyy-MM-dd")
        Dim strSQl As String = " update micros.mi_price_def mp" &
        "inner join micros.mi_def md On mp.mi_seq=md.mi_seq" &
        "mp.preset_amt_1 = 12.0" &
        "where md.obj_num = 3003"
        Dim mycomand As New Odbc.OdbcCommand(strSQl, objconexionODBC)
        daArticulo.SelectCommand = mycomand
        daArticulo.Fill(dscatalogo, "items")
        datos.DataSource = dscatalogo.Tables("items").DefaultView
    End Sub
    Sub importarRegistroVentas(ByVal fechaI As Date)
        '" FROM (Select Distinct ' ' AS NRODOC,chk_dtl.chk_num,fcr.FCRInvNumber, CASE WHEN firma>0 THEN 219  ELSE emp.obj_num END AS obj_num,RTRIM(STRING(substring(chk_dtl.chk_clsd_date_time,9,2),'-',substring(chk_dtl.chk_clsd_date_time,6,2),'-',substring(chk_dtl.chk_clsd_date_time,1,4))) AS Fecha,RTRIM(substring(chk_dtl.chk_clsd_date_time,12,5)) AS Hora,'N/S ' + RTRIM(fcr.ExtraField7) AS NroSerie,(fcr.ExtraField3 + '-' + right(('00'+rtrim(fcr.ExtraField4)),7) ) AS NroBoleta,CASE WHEN fcr.InvoiceType = 2 THEN RTRIM(fcr.ExtraField1) ELSE NULL END AS Nombre, CASE WHEN fcr.InvoiceType = 2 THEN RTRIM(fcr.ExtraField6) ELSE NULL END AS Nombre2, '' AS Nombre3,CASE WHEN fcr.InvoiceType = 2 THEN CustomerId ELSE NULL END AS Ruc,' ' AS Blanco,' ' AS Blanco1, chk_dtl.sub_ttl AS Neto, chk_dtl.auto_svc_ttl AS Por10, chk_dtl.tax_ttl  AS Igv, chk_dtl.pymnt_ttl AS Total, chk_dtl.other_svc_ttl AS Propina, ' ' AS Dummy, " & _
        '" FROM (SELECT Distinct ' ' AS NRODOC,chk_dtl.chk_num,fcr.FCRInvNumber, CASE WHEN firma>0 THEN 219  ELSE emp.obj_num END AS obj_num,RTRIM(STRING(substring(chk_dtl.chk_clsd_date_time,9,2),'-',substring(chk_dtl.chk_clsd_date_time,6,2),'-',substring(chk_dtl.chk_clsd_date_time,1,4))) AS Fecha,RTRIM(substring(chk_dtl.chk_clsd_date_time,12,5)) AS Hora,'N/S ' + RTRIM(fcr.ExtraField7) AS NroSerie,(fcr.ExtraField3 + '-' + right(('00'+rtrim(fcr.ExtraField4)),7) ) AS NroBoleta,RTRIM(fcr.ExtraField1) AS Nombre,  RTRIM(fcr.ExtraField6)  AS Nombre2, '' AS Nombre3, CustomerId AS Ruc,' ' AS Blanco,' ' AS Blanco1, chk_dtl.sub_ttl AS Neto, chk_dtl.auto_svc_ttl AS Por10, chk_dtl.tax_ttl  AS Igv, chk_dtl.pymnt_ttl AS Total, chk_dtl.other_svc_ttl AS Propina, ' ' AS Dummy, " & _
        Dim objconexionODBC As Odbc.OdbcConnection = Conexion.obtenerConexionODBC()
        Dim daArticulo As New Odbc.OdbcDataAdapter
        Dim dscatalogo As New DataSet
        Dim mfechaI As String = fechaI.ToString("yyyy-MM-dd")
        Dim fdesde As String = general.convierteFechaEspecificadadia(fechaI)
        Dim strSQl As String = " Select DISTINCT RegVta.NRODOC,RegVta.chk_num,RegVta.obj_num,RegVta.Fecha,RegVta.Hora,RegVta.NroSerie,RegVta.NroBoleta," &
        " CASE WHEN (LENGTH(TRIM(RegVta.Nombre)) > 0) THEN RegVta.Nombre ELSE NULL END AS  Nombre,CASE WHEN (LENGTH(TRIM(RegVta.Nombre2)) > 0) THEN RegVta.Nombre2 ELSE NULL END AS  Nombre2,CASE WHEN (LENGTH(TRIM(RegVta.Nombre3)) > 0) THEN RegVta.Nombre3 ELSE NULL END AS  Nombre3,CASE WHEN (LENGTH(TRIM(RegVta.Ruc)) > 0) THEN RegVta.Ruc ELSE NULL END AS  Ruc," &
        " RegVta.Blanco,RegVta.Blanco1,RegVta.Neto,RegVta.Por10,RegVta.Igv,RegVta.Total,RegVta.Propina,RegVta.Dummy,SUM(RegVta.Efectivo) AS Efectivo,SUM(RegVta.Visa) AS  Visa,SUM(RegVta.Amex) AS Amex ,SUM(RegVta.Master) AS  Master,SUM(RegVta.Diners) AS Diners ,SUM(RegVta.Firma) AS Firma ,SUM(RegVta.Gratis) AS  Gratis" &
        " FROM (SELECT Distinct ' ' AS NRODOC,chk_dtl.chk_num,fcr.FCRInvNumber, CASE WHEN firma>0 THEN 219  ELSE emp.obj_num END AS obj_num,RTRIM(STRING(substring(chk_dtl.chk_clsd_date_time,9,2),'-',substring(chk_dtl.chk_clsd_date_time,6,2),'-',substring(chk_dtl.chk_clsd_date_time,1,4))) AS Fecha,RTRIM(substring(chk_dtl.chk_clsd_date_time,12,5)) AS Hora,'N/S ' + RTRIM(fcr.ExtraField7) AS NroSerie,(fcr.ExtraField3 + '-' + right(('00'+rtrim(fcr.ExtraField4)),7) ) AS NroBoleta,CASE WHEN fcr.InvoiceType = 2 THEN RTRIM(fcr.ExtraField1) ELSE NULL END AS Nombre, CASE WHEN fcr.InvoiceType = 2 THEN RTRIM(fcr.ExtraField6) ELSE NULL END AS Nombre2, '' AS Nombre3,CASE WHEN fcr.InvoiceType = 2 THEN CustomerId ELSE NULL END AS Ruc,' ' AS Blanco,' ' AS Blanco1, chk_dtl.sub_ttl AS Neto, chk_dtl.auto_svc_ttl AS Por10, chk_dtl.tax_ttl  AS Igv, chk_dtl.pymnt_ttl AS Total, chk_dtl.other_svc_ttl AS Propina, ' ' AS Dummy, " &
        " CASE WHEN ((SELECT tmed.obj_num FROM micros.tmed_def tmed WHERE UPPER(TRIM(tmed.Name)) = UPPER(TRIM(dt.dtl_name))) IN(1,2,210) )  THEN SUM(dt.chk_ttl) ELSE 0 END AS Efectivo,CASE WHEN ((SELECT tmed.obj_num FROM micros.tmed_def tmed WHERE UPPER(TRIM(tmed.Name)) = UPPER(TRIM(dt.dtl_name))) IN(3,211) )  THEN SUM(dt.chk_ttl) ELSE 0 END AS Visa,CASE WHEN ((SELECT tmed.obj_num FROM micros.tmed_def tmed WHERE UPPER(TRIM(tmed.Name)) = UPPER(TRIM(dt.dtl_name))) IN(8,213) )  THEN SUM(dt.chk_ttl) ELSE 0 END AS Amex,CASE WHEN ((SELECT tmed.obj_num FROM micros.tmed_def tmed WHERE UPPER(TRIM(tmed.Name)) = UPPER(TRIM(dt.dtl_name))) IN(5,110,212) )  THEN SUM(dt.chk_ttl) ELSE 0 END AS Master, CASE WHEN ((SELECT tmed.obj_num FROM micros.tmed_def tmed WHERE UPPER(TRIM(tmed.Name)) = UPPER(TRIM(dt.dtl_name))) IN(12,214) )  THEN SUM(dt.chk_ttl) ELSE 0 END AS Diners, CASE WHEN ((SELECT tmed.obj_num FROM micros.tmed_def tmed WHERE UPPER(TRIM(tmed.Name)) = UPPER(TRIM(dt.dtl_name))) IN(23,218) )  THEN SUM(dt.chk_ttl) ELSE 0 END AS Firma,CASE WHEN ((SELECT tmed.obj_num FROM micros.tmed_def tmed WHERE UPPER(TRIM(tmed.Name)) = UPPER(TRIM(dt.dtl_name))) IN(216,18) )  THEN SUM(dt.chk_ttl) ELSE 0 END AS Gratis " &
        " FROM micros.chk_dtl chk_dtl, micros.trans_dtl trans_dtl,micros.dtl dt,micros.rest_status,micros.emp_def emp,micros.fcr_invoice_data fcr " &
        " WHERE trans_dtl.business_date = '" & mfechaI & "'  AND emp.emp_seq = chk_dtl.emp_seq AND chk_dtl.fiscalkey = (fcr.ExtraField5 + fcr.ExtraField3 + fcr.FCRInvNumber + CAST(fcr.InvoiceType AS VARCHAR)) AND chk_dtl.chk_open = 'F' AND dt.dtl_type = 'T' AND chk_dtl.chk_seq  = trans_dtl.chk_seq AND dt.trans_seq  = trans_dtl.trans_seq " &
        " GROUP BY chk_dtl.chk_num,fcr.FCRInvNumber, emp.obj_num,RTRIM(STRING(substring(chk_dtl.chk_clsd_date_time,9,2),'-',substring(chk_dtl.chk_clsd_date_time,6,2),'-',substring(chk_dtl.chk_clsd_date_time,1,4))),RTRIM(substring(chk_dtl.chk_clsd_date_time,12,5)),'N/S ' + RTRIM(fcr.ExtraField7),(fcr.ExtraField3 + '-' +right(('00'+rtrim(fcr.ExtraField4)),7) ),fcr.ExtraField1 ,fcr.ExtraField6,fcr.InvoiceType,chk_dtl.sub_ttl ,chk_dtl.auto_svc_ttl ,chk_dtl.tax_ttl, chk_dtl.pymnt_ttl , chk_dtl.other_svc_ttl,dt.dtl_name,CustomerId) AS RegVta" &
        " GROUP BY RegVta.NRODOC,RegVta.chk_num,RegVta.FCRInvNumber,RegVta.obj_num,RegVta.Fecha,RegVta.Hora,RegVta.NroSerie,RegVta.NroBoleta,RegVta.Nombre,RegVta.Nombre2,RegVta.Nombre3,RegVta.Ruc,RegVta.Blanco,RegVta.Blanco1,RegVta.Neto,RegVta.Por10,RegVta.Igv,RegVta.Total,RegVta.Propina,RegVta.Dummy order by RegVta.NroBoleta"
        Dim mycomand As New Odbc.OdbcCommand(strSQl, objconexionODBC)
        daArticulo.SelectCommand = mycomand
        daArticulo.Fill(dscatalogo, "documentos")
        datosRegVentas.DataSource = dscatalogo.Tables("documentos").DefaultView
        CreateTextDelimiterFile("c:\regventas\" & fdesde & ".txt", dscatalogo, "documentos", ",", True)
    End Sub
    Sub estructuradatos()
        Dim ds As New DataSet
        Dim dt As New DataTable
        'dt.Columns.Add(New DataColumn("fecha", GetType(Date)))
        dt.Columns.Add(New DataColumn("numdoc", GetType(String)))
        dt.Columns.Add(New DataColumn("Codigo", GetType(String)))
        dt.Columns.Add(New DataColumn("Nombre", GetType(String)))
        dt.Columns.Add(New DataColumn("Cantidad", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("importe", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("descuento", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("Almacen", GetType(String)))
        ds.Tables.Add(dt)
        'da.Fill(dt)
        datos.DataSource = dt
        With datos
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("numdoc").HeaderText = "Documento"
            .Columns("numdoc").Width = 80
            .Columns("numdoc").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("codigo").HeaderText = "Código"
            .Columns("codigo").Width = 70
            .Columns("codigo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("Nombre").HeaderText = "Descripción"
            .Columns("Nombre").Width = 250
            .Columns("cantidad").HeaderText = "Cantidad"
            .Columns("cantidad").Width = 90
            .Columns("cantidad").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("importe").HeaderText = "Importe"
            .Columns("importe").Width = 70
            .Columns("importe").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("descuento").HeaderText = "Descuento"
            .Columns("descuento").Width = 70
            .Columns("descuento").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("Almacen").HeaderText = "Almacen"
            .Columns("Almacen").Width = 90
            .Columns("Almacen").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        End With
    End Sub
    Sub estableceFechas()
        dtiFecha.ResetMinDate()
        'dtiFecha.MinDate = pFechaActivaMin
        dtiFecha.ResetMaxDate()
        'dtiFecha.MaxDate = pFechaActivaMax
        dtiFecha.Value = pFechaSystem
    End Sub
    Private Sub cmdImportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImportar.Click
        Dim nroReg, I As Integer
        Dim mcliente As New Cliente
        Dim cod_clie, nom_clie, dir_clie As String
        grabarfactura()
        dview.RowFilter = String.Format("{0} like '%{1}%'", "cdtipodocu", "001")
        datos.DataSource = dview
        datos.Update()
        nroReg = datos.RowCount
        For I = 0 To nroReg - 1
            cod_clie = datos("rucclient", I).Value
            nom_clie = datos("nomclient", I).Value
            dir_clie = datos("dirclient", I).Value
            If Len(cod_clie) > 0 Then
                If Not mcliente.existe(cod_clie) Then
                    mcliente.insertar(cod_clie, nom_clie, nom_clie, dir_clie, "", "", "", "00", 1)
                End If
            End If

        Next

        importarventasSQL(dtiFecha.Value, 2)
        grabarNCREDITO()


        MessageBox.Show("Importación de Datos Finalizada...", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information)
        lblProcesados.Visible = False

    End Sub
    Sub grabarfactura()
        If datos.RowCount > 0 Then
            Dim cFecha As Date
            Dim cfecha1 As DateTime
            Dim cod_doc, ser_doc, num_doc, cod_clie, cNumdoc, cAlma, nro_ptovta As String
            Dim mSalida As New Salida
            Dim mUtil As New Utilidades

            Dim nroReg, operacionS, I, X As Integer
            Dim subtotal As Decimal
            nroReg = datos.RowCount
            X = 1
            lblProcesados.Visible = True
            mSalida.eliminaFacturas(dtiFecha.Value)

            For I = 0 To nroReg - 1
                'If dtiFecha.Value = datos("fecha", I).Value Then
                'cFecha = datos("fecha", I).Value
                operacionS = mSalida.maxOperacion_fac

                num_doc = datos("nrodocum", I).Value
                cod_doc = datos("cdtipodocu", I).Value
                nro_ptovta = datos("nroptovta", I).Value
                cNumdoc = Strings.Right(num_doc, 8)
                ser_doc = datos("TIPCREDLET", I).Value

                cFecha = datos("fecdocum", I).Value
                cfecha1 = datos("fecdocum", I).Value
                cod_clie = datos("rucclient", I).Value

                subtotal = datos("subtotal", I).Value

                cAlma = "0001"
                mSalida.insertar_factura(operacionS, 0, Strings.Right(cod_doc, 2), ser_doc, cNumdoc, cfecha1, cFecha, cFecha,
                                         "00000000", cod_clie, "01", 1, 1, pDecimales, cAlma, "0000", "", pEmpresa, pCuentaUser,
                                         nro_ptovta, subtotal, "", "", "", 3.352)
                importarventasSQL_det(operacionS, cod_doc, num_doc, 1)
                lblProcesados.Text = X & " de " & nroReg
                X = X + 1
                lblProcesados.Refresh()
                'End If
            Next
        End If

    End Sub

    Sub grabarNCREDITO()
        If datos.RowCount > 0 Then
            Dim cFecha As Date
            Dim cfecha1 As DateTime
            Dim cod_doc, ser_doc, num_doc, cNumdoc_ref, ctipdoc_ref, cserdoc_ref, cod_clie, cNumdoc, cAlma, nro_ptovta As String
            Dim mSalida As New Salida
            Dim mUtil As New Utilidades

            Dim nroReg, operacionS, I, X As Integer
            Dim subtotal As Decimal
            nroReg = datos.RowCount
            X = 1
            lblProcesados.Visible = True
            'mSalida.eliminaFacturas(dtiFecha.Value)

            For I = 0 To nroReg - 1
                'If dtiFecha.Value = datos("fecha", I).Value Then
                'cFecha = datos("fecha", I).Value
                operacionS = mSalida.maxOperacion_fac

                num_doc = datos("nrontacred", I).Value
                ctipdoc_ref = datos("cdtipodocu", I).Value
                nro_ptovta = datos("nroptovta", I).Value
                cNumdoc = Strings.Right(num_doc, 8)
                cod_doc = datos("cod_doc", I).Value
                ser_doc = datos("seriedocu", I).Value


                cNumdoc_ref = datos("nrodocum", I).Value
                cNumdoc_ref = Strings.Right(cNumdoc_ref, 8)

                cserdoc_ref = datos("TIPCREDLET", I).Value

                cFecha = datos("fecdocum", I).Value
                cfecha1 = datos("fecdocum", I).Value
                cod_clie = datos("rucclient", I).Value

                subtotal = datos("subtotal", I).Value

                cAlma = "0001"
                mSalida.insertar_factura(operacionS, 0, cod_doc, ser_doc, cNumdoc, cfecha1, cFecha, cFecha,
                                         "00000000", cod_clie, "01", 1, 1, pDecimales, cAlma, "0000", "", pEmpresa, pCuentaUser,
                                         nro_ptovta, subtotal, Strings.Right(ctipdoc_ref, 2), cserdoc_ref, cNumdoc_ref, 3.352)
                importarventasSQL_det(operacionS, cod_doc, num_doc, 2)
                lblProcesados.Text = X & " de " & nroReg
                X = X + 1
                lblProcesados.Refresh()
                'End If
            Next
        End If

    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MessageBox.Show(datos("fecha", 1).Value)
        MessageBox.Show(dtiFecha.Value)
        If datos("fecha", 1).Value = dtiFecha.Value Then
            MessageBox.Show("iguales")
        End If
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Try
            importarventasSQL(dtiFecha.Value, 1)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim data As IDataObject = Clipboard.GetDataObject
    '    Dim i As Integer = 0
    '    Dim j As Integer = 0
    '    If Not data.GetDataPresent("CSV", False) Then Return

    '    Try
    '        Dim da As New MySqlDataAdapter
    '        Dim ds As New DataSet
    '        Dim dt As New DataTable
    '        'dt.Columns.Add(New DataColumn("fecha", GetType(Date)))
    '        dt.Columns.Add(New DataColumn("numdoc", GetType(String)))
    '        dt.Columns.Add(New DataColumn("Codigo", GetType(String)))
    '        dt.Columns.Add(New DataColumn("Nombre", GetType(String)))
    '        dt.Columns.Add(New DataColumn("Cantidad", GetType(Decimal)))
    '        dt.Columns.Add(New DataColumn("Precio", GetType(Decimal)))
    '        dt.Columns.Add(New DataColumn("Descuento", GetType(Decimal)))
    '        ds.Tables.Add(dt)
    '        'da.Fill(dt)
    '        datos.DataSource = dt

    '        'Obtenemos el texto almacenado en el portapapales 
    '        Dim s As String = Clipboard.GetText

    '        'hacemos un split para organizar la informacion por lineas 
    '        Dim lines As String() = s.Split(New Char(1) {ControlChars.Cr, ControlChars.Lf}, StringSplitOptions.RemoveEmptyEntries)
    '        Dim vdr(5) As Object
    '        'Ciclo para cada linea del copy 
    '        For Each line As String In lines
    '            'Creamos una fila referenciando a la tabla datasource del DataGridView 
    '            Dim dr As DataRow = dt.NewRow()

    '            'Obtenemos las celdas que el usuario copia 
    '            Dim cells As String() = line.Split(ControlChars.Tab)

    '            'Burbuja para asignar cada uno de los datos de cada columna copia 

    '            For Each cell As String In cells

    '                'If j = 0 Then
    '                '    dr.Item(j) = 0
    '                'Else
    '                'dr.Item(j) = cell
    '                vdr(j) = cell
    '                'End If
    '                j = j + 1
    '            Next
    '            i = i + 1
    '            j = 0
    '            'Agregamos la fila a la tabla 
    '            dt.Rows.Add(vdr)
    '        Next
    '        datos.Refresh()
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    End Try
    'End Sub
    Private Sub datos_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles datos.KeyDown
        If (e.Control And e.KeyCode = Keys.E) Then
            If datos.RowCount > 0 Then
                EnviaraExcel(datos)
            End If
        End If
    End Sub

    Private Sub cboAlmacen_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboImportacion.SelectedValueChanged
        If Not estaCargando Then
            verificaImportacion()
        End If
    End Sub

    Private Sub datosRegVentas_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles datosRegVentas.KeyDown
        If (e.Control And e.KeyCode = Keys.E) Then
            If datosRegVentas.RowCount > 0 Then
                EnviaraExcel(datosRegVentas)
            End If
        End If

    End Sub


End Class
