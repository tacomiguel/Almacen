Imports System.IO
Imports MySql.Data.MySqlClient
Public Class u_envioCompras
    Private dr As MySqlDataReader
    Private fec_regist, fec_movimi, mes_movimi, cdo_fuente, cdo_cuenta, cdo_auxili, cdo_refere, tip_docume, num_docume As String
    Private fec_vencim, tip_docref, num_docref, mov_carabo, des_movimi, cdo_usuari As String
    Private tCdo_auxili, tNum_docume, tMov_carabo As String, tMonto_debe As Decimal
    Private monto_debe, monto_habe, dolar_debe, dolar_habe As Decimal, I As Integer = 0, doc As String = ""
    Private Sub u_envioCompras_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        principal.mu_envioCompras.Enabled = True
    End Sub
    Private Sub u_envioCompras_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Top = 0
        Me.Left = 0
        If Month(pFechaActivaMax) = Month(pFechaSystem) Then
            mcDesde.DisplayMonth = pFechaSystem
            mcDesde.SelectedDate = pFechaSystem
            mcHasta.DisplayMonth = pFechaSystem
            mcHasta.SelectedDate = pFechaSystem
        Else
            mcDesde.DisplayMonth = pFechaActivaMax
            mcDesde.SelectedDate = pFechaActivaMin
            mcHasta.DisplayMonth = pFechaActivaMax
            mcHasta.SelectedDate = pFechaActivaMin
        End If
        tCdo_auxili = ""
        tNum_docume = ""
        tMov_carabo = ""
        tMonto_debe = 0
    End Sub
    Private Sub cmdEnvio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEnvio.Click
        Dim fdesde As String = general.devuelveFechaEspecificada(mcDesde.SelectedDate)
        Dim fhasta As String = general.devuelveFechaEspecificada(mcHasta.SelectedDate)
        Dim periodo As String = general.convierteFechaEspecificadaMes(mcHasta.SelectedDate)
        Dim esHistorial As Boolean = IIf(periodo >= periodoActivo(), False, True)
        'Dim esHistorial As Boolean = False
        Dim cadCompras As String = textoCompras(mcDesde.SelectedDate, mcHasta.SelectedDate, esHistorial)
        Dim com As New MySqlCommand(cadCompras, dbConex)
        Dim nomArchivo As String = "C:\C" & fdesde & "_" & fhasta
        If optDBF.Checked = True Then
            Dim cnDBF As New OleDb.OleDbConnection("Provider = VFPOLEDB.1; Data Source = C:\;")
            cnDBF.Open()
            'Abrirmos Caja Dialogo
            Dim MyDlg As New SaveFileDialog
            With MyDlg
                .Filter = "Archivos dbf  (*.dbf)|*.dbf|Todos los archivos (*.*)|*.*"
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    'creamos la tabla de compras
                    nomArchivo = .FileName
                End If
            End With
            Dim t, t1, t2, t3 As String
            t1 = "Create table " & nomArchivo & "(fec_regist D,fec_movimi D,mes_movimi C(2),cdo_fuente C(1),cdo_cuenta C(12),cdo_auxili C(12),cdo_refere C(8),"
            t2 = "tip_docume C(2),num_docume C(18),fec_vencim D(8),tip_docref C(2),num_docref C(18),mov_carabo C(1),"
            t3 = "monto_debe N(15,2),monto_habe N(15,2),dolar_debe N(15,2),dolar_habe N(15,2),des_movimi C(60),cdo_usuari C(8))"
            t = t1 & t2 & t3
            Dim cmdCrearTabla As New OleDb.OleDbCommand(t, cnDBF)
            cmdCrearTabla.ExecuteNonQuery()
            'registramos los datos en el archivo DBF
            com.CommandTimeout = 300
            dr = com.ExecuteReader
            If dr.HasRows = True Then
                While dr.Read
                    If recuperaCompras() Then
                        Dim linea, l1, l2, l3, l4, l5, l6, l7 As String
                        l1 = "INSERT INTO " & nomArchivo & "(fec_regist,fec_movimi,mes_movimi,cdo_fuente,cdo_cuenta,cdo_auxili,cdo_refere,"
                        l2 = "tip_docume,num_docume,fec_vencim,tip_docref,num_docref,mov_carabo,"
                        l3 = "monto_debe,monto_habe,dolar_debe,dolar_habe,des_movimi,cdo_usuari)"
                        l4 = "values"
                        l5 = "(ctod('" & fec_regist & "'),ctod('" & fec_movimi & "'),'" & mes_movimi & "','" & cdo_fuente & "','" & cdo_cuenta & "','" & cdo_auxili & "','" & cdo_refere & "','"
                        l6 = tip_docume & "','" & num_docume & "',ctod('" & fec_vencim & "'),'" & tip_docref & "','" & num_docref & "','" & mov_carabo & "',"
                        l7 = monto_debe & "," & monto_habe & "," & dolar_debe & "," & dolar_habe & ",'" & des_movimi & "','" & cdo_usuari & "')"
                        linea = l1 & l2 & l3 & l4 & l5 & l6 & l7
                        Dim comIns As New OleDb.OleDbCommand(linea, cnDBF)
                        comIns.ExecuteNonQuery()
                    End If
                End While
            End If
            cnDBF.Close()
        Else
            'creamos el archivo de compras
            nomArchivo = "C:\C" & fdesde & "_" & fhasta & ".txt"
            Dim oSW As New StreamWriter(nomArchivo)
            dr = com.ExecuteReader
            If dr.HasRows = True Then
                While dr.Read
                    recuperaCompras()
                    'registramos los datos en el archivo TXT
                    Dim linea, l1, l2, l3 As String
                    l1 = "'" & fec_regist & "','" & fec_movimi & "','" & mes_movimi & "','" & cdo_fuente & "','" & cdo_cuenta & "','" & cdo_auxili & "','" & cdo_refere & "','"
                    l2 = tip_docume & "','" & num_docume & "','" & fec_vencim & "','" & tip_docref & "','" & num_docref & "','" & mov_carabo & "',"
                    l3 = monto_debe & "," & monto_habe & "," & dolar_debe & "," & dolar_habe & ",'" & des_movimi & "','" & cdo_usuari & "'"
                    linea = l1 & l2 & l3
                    oSW.WriteLine(linea)
                    oSW.Flush()
                End While
            End If
            oSW.Close()
        End If
        dr.Close()
        MessageBox.Show("Archivo Generado... ¡" & I & " Documentos Procesados!" & Chr(13) & "Buscar en " & nomArchivo, "CEFE", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Function recuperaCompras() As Boolean
        Dim continuar As Boolean = True
        If Len(dr("cdo_auxili")) > 0 And tCdo_auxili = dr("cdo_auxili") And tNum_docume = dr("num_docume") And tMov_carabo = "A" And tMonto_debe = dr("monto_habe") Then
            'esto es cuando se toma solo un registro en el monto del documento
            tCdo_auxili = ""
            tNum_docume = ""
            tMov_carabo = ""
            tMonto_debe = 0
            continuar = False
        Else
            fec_regist = dr("fec_regist")
            fec_movimi = dr("fec_movimi")
            mes_movimi = Microsoft.VisualBasic.Right("00" & Trim(dr("mes_movimi")), 2)
            cdo_fuente = dr("cdo_fuente")
            cdo_cuenta = dr("cdo_cuenta")
            cdo_auxili = dr("cdo_auxili")
            If doc <> dr("num_docume") Then
                I = I + 1
            End If
            If dr("tm") = "D" Then
                cdo_refere = Microsoft.VisualBasic.Right("00000" & I, 5) & "C" & "$1"
            Else
                cdo_refere = Microsoft.VisualBasic.Right("00000" & I, 5) & "C" & "00"
            End If
            tip_docume = dr("tip_docume")
            num_docume = dr("num_docume")
            doc = dr("num_docume")
            fec_vencim = dr("fec_vencim")
            tip_docref = dr("tip_docref")
            num_docref = dr("num_docref")
            mov_carabo = dr("mov_carabo")
            monto_debe = dr("monto_debe")
            monto_habe = dr("monto_habe")
            dolar_debe = dr("dolar_debe")
            dolar_habe = dr("dolar_habe")
            des_movimi = dr("des_movimi")
            cdo_usuari = dr("cdo_usuari")
            '
            tCdo_auxili = dr("cdo_auxili")
            tNum_docume = dr("num_docume")
            tMov_carabo = dr("mov_carabo")
            tMonto_debe = IIf(dr("tm") = "D", dr("dolar_habe"), dr("monto_habe"))
        End If
        Return continuar
    End Function
    Function textoCompras(ByVal fecInicial As Date, ByVal fecFinal As Date, ByVal his As Boolean) As String
        Dim fInicial As String = fecInicial.ToString("yy-MM-dd")
        Dim fFinal As String = fecFinal.ToString("yy-MM-dd")
        Dim cad, cad1, cad2, cad3, cad4, cad5, cad6, cad7, cad8, cad9, cad10 As String
        Dim cad_1, cad_2, cad_3, cad_4, cad_5, cad_6, cad_7, cad_8, cad_9, cad_10 As String
        Dim cad1a, cad2a, cad3a, cad4a, cad5a, cad6a, cad7a, cad8a, cad9a, cad10a As String
        Dim cad_1a, cad_2a, cad_3a, cad_4a, cad_5a, cad_6a, cad_7a, cad_8a, cad_9a, cad_10a As String
        Dim cad1b, cad2b, cad3b, cad4b, cad5b, cad6b, cad7b, cad8b, cad9b, cad10b As String
        Dim cad_1b, cad_2b, cad_3b, cad_4b, cad_5b, cad_6b, cad_7b, cad_8b, cad_9b, cad_10b As String
        Dim cad11, cad12, cad13, cad14, cad15, cad16, cad17, cad18 As String
        Dim cad_11, cad_12, cad_13, cad_14, cad_15, cad_16, cad_17, cad_18 As String
        Dim cad19, cad20, cad21, cad22, cad23, cad24, cad25, cad26, cad27 As String
        Dim cad_19, cad_20, cad_21, cad_22, cad_23, cad_24, cad_25, cad_26 As String
        Dim cadOrden, cad100, cad100a, cad100b, cad101, cad102, cading, cading1 As String
        Dim cMonto_s_debe As String = " IF(pre_inc_igv=1,round(cant*precio/(1+igv),nro_dec),round(cant*precio,nro_dec))as monto_debe,0 as monto_habe,0 as dolar_debe,0 as dolar_habe"
        Dim cMonto_s_habe As String = " 0 as monto_debe,IF(pre_inc_igv=1,round(cant*precio/(1+igv),nro_dec),round(cant*precio,nro_dec))as monto_habe,0 as dolar_debe,0 as dolar_habe"
        Dim cMonto_d_debe As String = " 0 as monto_debe,0 as monto_habe,IF(pre_inc_igv=1,round(cant*precio/(1+igv),nro_dec),round(cant*precio,nro_dec))as dolar_debe,0 as dolar_habe"
        Dim cMonto_d_habe As String = " 0 as monto_debe,0 as monto_habe,0 as dolar_debe,IF(pre_inc_igv=1,round(cant*precio/(1+igv),nro_dec),round(cant*precio,nro_dec))as dolar_habe"
        Dim cMonto_s_imp As String = " monto_igv as monto_debe,0 as monto_habe,0 as dolar_debe,0 as dolar_habe"
        Dim cMonto_d_imp As String = " 0 as monto_debe,0 as monto_habe,monto_igv as dolar_debe,0 as dolar_habe"
        Dim cMonto_s As String = " 0 as monto_debe,monto as monto_habe,0 as dolar_debe,0 as dolar_habe"
        Dim cMonto_d As String = " 0 as monto_debe,0 as monto_habe,0 as dolar_debe,monto as dolar_habe"
        'RECUPERAMOS LOS INGRESOS
        'a la cuenta contable - soles
        If his Then
            cading = " from h_ingreso as ingreso inner join h_ingreso_det as ingreso_det on ingreso.operacion=ingreso_det.operacion and ingreso.proceso=ingreso_det.proceso"
            cading1 = " from h_ingreso as ingreso"
        Else
            cading = " from ingreso as ingreso inner join ingreso_det as ingreso_det on ingreso.operacion=ingreso_det.operacion"
            cading1 = " from ingreso as ingreso"
        End If
        If optDBF.Checked = True Then
            cad1 = " select date_format(curdate(),'%m-%d-%Y') as fec_regist,date_format(fec_doc,'%m-%d-%Y') as fec_movimi,"
            cad2 = " month(fec_doc) as mes_movimi,'C' as cdo_fuente,cuenta_c as cdo_cuenta,'' as cdo_auxili,'' as cdo_refere,"
            cad3 = " cod_fiscal as tip_docume,concat(right(ser_doc,3),'-',nro_doc) as num_docume,"
            cad4 = " date_format(addDate(fec_doc,dias),'%m-%d-%Y')  as fec_vencim,'' as tip_docref,'' as num_docref,'C' as mov_carabo,"
        Else
            cad1 = " select date_format(curdate(),'%d-%m-%Y') as fec_regist,date_format(fec_doc,'%d-%m-%Y') as fec_movimi,"
            cad2 = " month(fec_doc) as mes_movimi,'C' as cdo_fuente,cuenta_c as cdo_cuenta,'' as cdo_auxili,'' as cdo_refere,"
            cad3 = " cod_fiscal as tip_docume,concat(right(ser_doc,3),'-',nro_doc) as num_docume,"
            cad4 = " date_format(fec_doc,'%d-%m-%Y')  as fec_vencim,'' as tip_docref,'' as num_docref,'C' as mov_carabo,"
        End If
        cad5 = cMonto_s_debe
        cad6 = " ,concat(ingreso.cod_alma,'-',nom_art) as des_movimi,'ADMIN' as cdo_usuari,ingreso,tm,'a1' as orden"
        'cad7 = " from ingreso inner join ingreso_det on ingreso.operacion=ingreso_det.operacion" _
        cad7 = cading _
                & " inner join almacen on ingreso.cod_alma=almacen.cod_alma"
        cad8 = " inner join articulo on ingreso_det.cod_art=articulo.cod_art " _
                & " inner join documento_i on ingreso.cod_doc=documento_i.cod_doc" _
                & " inner join forma_pago on ingreso.cod_fpago=forma_pago.cod_fpago"
        cad9 = " where(esMigracion) and tm<>'D' and fec_doc>='" & fInicial & "'" _
                & " and fec_doc<='" & fFinal & "' and almacen.cod_emp='" & pEmpresa & "'"
        cad10 = " UNION"
        'a la cuenta contable - dolares
        If optDBF.Checked = True Then
            cad_1 = " select date_format(curdate(),'%m-%d-%Y') as fec_regist,date_format(fec_doc,'%m-%d-%Y') as fec_movimi,"
            cad_2 = " month(fec_doc) as mes_movimi,'C' as cdo_fuente,cuenta_c as cdo_cuenta,'' as cdo_auxili,'' as cdo_refere,"
            cad_3 = " cod_fiscal as tip_docume,concat(right(ser_doc,3),'-',nro_doc) as num_docume,"
            cad_4 = " date_format(addDate(fec_doc,dias),'%m-%d-%Y')  as fec_vencim,'' as tip_docref,'' as num_docref,'C' as mov_carabo,"
        Else
            cad_1 = " select date_format(curdate(),'%d-%m-%Y') as fec_regist,date_format(fec_doc,'%d-%m-%Y') as fec_movimi,"
            cad_2 = " month(fec_doc) as mes_movimi,'C' as cdo_fuente,cuenta_c as cdo_cuenta,'' as cdo_auxili,'' as cdo_refere,"
            cad_3 = " cod_fiscal as tip_docume,concat(right(ser_doc,3),'-',nro_doc) as num_docume,"
            cad_4 = " date_format(fec_doc,'%d-%m-%Y')  as fec_vencim,'' as tip_docref,'' as num_docref,'C' as mov_carabo,"
        End If
        cad_5 = cMonto_d_debe
        cad_6 = " ,concat(ingreso.cod_alma,'-',nom_art) as des_movimi,'ADMIN' as cdo_usuari,ingreso,tm,'a1' as orden"
        'cad_7 = " from ingreso inner join ingreso_det on ingreso.operacion=ingreso_det.operacion" _
        cad_7 = cading _
                & " inner join almacen on ingreso.cod_alma=almacen.cod_alma"
        cad_8 = " inner join articulo on ingreso_det.cod_art=articulo.cod_art" _
                & " inner join documento_i on ingreso.cod_doc=documento_i.cod_doc" _
                & " inner join forma_pago on ingreso.cod_fpago=forma_pago.cod_fpago"
        cad_9 = " where(esMigracion) and tm='D' and fec_doc>='" & fInicial & "'" _
                & " and fec_doc<='" & fFinal & "' and almacen.cod_emp='" & pEmpresa & "'"
        cad_10 = " UNION"
        '******************************
        'a la cuenta de destino - soles
        If optDBF.Checked = True Then
            cad1a = " select date_format(curdate(),'%m-%d-%Y') as fec_regist,date_format(fec_doc,'%m-%d-%Y') as fec_movimi,"
            cad2a = " month(fec_doc) as mes_movimi,'C' as cdo_fuente,cuenta_c_a1 as cdo_cuenta,'' as cdo_auxili,'' as cdo_refere,"
            cad3a = " cod_fiscal as tip_docume,concat(right(ser_doc,3),'-',nro_doc) as num_docume,"
            cad4a = " date_format(addDate(fec_doc,dias),'%m-%d-%Y')  as fec_vencim,'' as tip_docref,'' as num_docref,'A' as mov_carabo,"
        Else
            cad1a = " select date_format(curdate(),'%d-%m-%Y') as fec_regist,date_format(fec_doc,'%d-%m-%Y') as fec_movimi,"
            cad2a = " month(fec_doc) as mes_movimi,'C' as cdo_fuente,cuenta_c_a1 as cdo_cuenta,'' as cdo_auxili,'' as cdo_refere,"
            cad3a = " cod_fiscal as tip_docume,concat(right(ser_doc,3),'-',nro_doc) as num_docume,"
            cad4a = " date_format(fec_doc,'%d-%m-%Y')  as fec_vencim,'' as tip_docref,'' as num_docref,'A' as mov_carabo,"
        End If
        cad5a = cMonto_s_habe
        cad6a = " ,concat(ingreso.cod_alma,'-',nom_art),'ADMIN' as cdo_usuari,ingreso,tm,'a2' as orden"
        'cad7a = " from ingreso inner join ingreso_det on ingreso.operacion=ingreso_det.operacion" _
        cad7a = cading _
                & " inner join almacen on ingreso.cod_alma=almacen.cod_alma"
        cad8a = " inner join articulo on ingreso_det.cod_art=articulo.cod_art" _
                & " inner join documento_i on ingreso.cod_doc=documento_i.cod_doc" _
                & " inner join forma_pago on ingreso.cod_fpago=forma_pago.cod_fpago"
        cad9a = " where(esMigracion) and tm<>'D' and fec_doc>='" & fInicial & "'" _
                & " and fec_doc<='" & fFinal & "' and almacen.cod_emp='" & pEmpresa & "'"
        cad10a = " UNION"
        'a la cuenta de destino - dolares
        If optDBF.Checked = True Then
            cad_1a = " select date_format(curdate(),'%m-%d-%Y') as fec_regist,date_format(fec_doc,'%m-%d-%Y') as fec_movimi,"
            cad_2a = " month(fec_doc) as mes_movimi,'C' as cdo_fuente,cuenta_c_a1 as cdo_cuenta,'' as cdo_auxili,'' as cdo_refere,"
            cad_3a = " cod_fiscal as tip_docume,concat(right(ser_doc,3),'-',nro_doc) as num_docume,"
            cad_4a = " date_format(addDate(fec_doc,dias),'%m-%d-%Y')  as fec_vencim,'' as tip_docref,'' as num_docref,'A' as mov_carabo,"
        Else
            cad_1a = " select date_format(curdate(),'%d-%m-%Y') as fec_regist,date_format(fec_doc,'%d-%m-%Y') as fec_movimi,"
            cad_2a = " month(fec_doc) as mes_movimi,'C' as cdo_fuente,cuenta_c_a1 as cdo_cuenta,'' as cdo_auxili,'' as cdo_refere,"
            cad_3a = " cod_fiscal as tip_docume,concat(right(ser_doc,3),'-',nro_doc) as num_docume,"
            cad_4a = " date_format(fec_doc,'%d-%m-%Y')  as fec_vencim,'' as tip_docref,'' as num_docref,'A' as mov_carabo,"
        End If
        cad_5a = cMonto_d_habe
        cad_6a = " ,concat(ingreso.cod_alma,'-',nom_art),'ADMIN' as cdo_usuari,ingreso,tm,'a2' as orden"
        'cad_7a = " from ingreso inner join ingreso_det on ingreso.operacion=ingreso_det.operacion" _
        cad_7a = cading _
                & " inner join almacen on ingreso.cod_alma=almacen.cod_alma"
        cad_8a = " inner join articulo on ingreso_det.cod_art=articulo.cod_art" _
                & " inner join documento_i on ingreso.cod_doc=documento_i.cod_doc" _
                & " inner join forma_pago on ingreso.cod_fpago=forma_pago.cod_fpago"
        cad_9a = " where(esMigracion) and tm='D' and fec_doc>='" & fInicial & "'" _
                & " and fec_doc<='" & fFinal & "' and almacen.cod_emp='" & pEmpresa & "'"
        cad_10a = " UNION"
        '****************************
        'a la cuenta de stock - soles
        '****************************
        If optDBF.Checked = True Then
            cad1b = " select date_format(curdate(),'%m-%d-%Y') as fec_regist,date_format(fec_doc,'%m-%d-%Y') as fec_movimi,"
            cad2b = " month(fec_doc) as mes_movimi,'C' as cdo_fuente,cuenta_c_a2 as cdo_cuenta,'' as cdo_auxili,'' as cdo_refere,"
            cad3b = " cod_fiscal as tip_docume,concat(right(ser_doc,3),'-',nro_doc) as num_docume,"
            cad4b = " date_format(addDate(fec_doc,dias),'%m-%d-%Y')  as fec_vencim,'' as tip_docref,'' as num_docref,'C' as mov_carabo,"
        Else
            cad1b = " select date_format(curdate(),'%d-%m-%Y') as fec_regist,date_format(fec_doc,'%d-%m-%Y') as fec_movimi,"
            cad2b = " month(fec_doc) as mes_movimi,'C' as cdo_fuente,cuenta_c_a2 as cdo_cuenta,'' as cdo_auxili,'' as cdo_refere,"
            cad3b = " cod_fiscal as tip_docume,concat(right(ser_doc,3),'-',nro_doc) as num_docume,"
            cad4b = " date_format(fec_doc,'%d-%m-%Y')  as fec_vencim,'' as tip_docref,'' as num_docref,'C' as mov_carabo,"
        End If
        cad5b = cMonto_s_debe
        cad6b = " ,concat(ingreso.cod_alma,'-',nom_art),'ADMIN' as cdo_usuari,ingreso,tm,'a3' as orden"
        'cad7b = " from ingreso inner join ingreso_det on ingreso.operacion=ingreso_det.operacion" _
        cad7b = cading _
                & " inner join almacen on ingreso.cod_alma=almacen.cod_alma"
        cad8b = " inner join articulo on ingreso_det.cod_art=articulo.cod_art" _
                & " inner join documento_i on ingreso.cod_doc=documento_i.cod_doc" _
                & " inner join forma_pago on ingreso.cod_fpago=forma_pago.cod_fpago"
        cad9b = " where(esMigracion) and tm<>'D' and fec_doc>='" & fInicial & "'" _
                & " and fec_doc<='" & fFinal & "' and almacen.cod_emp='" & pEmpresa & "'"
        cad10b = " UNION"
        'a la cuenta de stock - dolares
        If optDBF.Checked = True Then
            cad_1b = " select date_format(curdate(),'%m-%d-%Y') as fec_regist,date_format(fec_doc,'%m-%d-%Y') as fec_movimi,"
            cad_2b = " month(fec_doc) as mes_movimi,'C' as cdo_fuente,cuenta_c_a2 as cdo_cuenta,'' as cdo_auxili,'' as cdo_refere,"
            cad_3b = " cod_fiscal as tip_docume,concat(right(ser_doc,3),'-',nro_doc) as num_docume,"
            cad_4b = " date_format(addDate(fec_doc,dias),'%m-%d-%Y')  as fec_vencim,'' as tip_docref,'' as num_docref,'C' as mov_carabo,"
        Else
            cad_1b = " select date_format(curdate(),'%d-%m-%Y') as fec_regist,date_format(fec_doc,'%d-%m-%Y') as fec_movimi,"
            cad_2b = " month(fec_doc) as mes_movimi,'C' as cdo_fuente,cuenta_c_a2 as cdo_cuenta,'' as cdo_auxili,'' as cdo_refere,"
            cad_3b = " cod_fiscal as tip_docume,concat(right(ser_doc,3),'-',nro_doc) as num_docume,"
            cad_4b = " date_format(fec_doc,'%d-%m-%Y')  as fec_vencim,'' as tip_docref,'' as num_docref,'C' as mov_carabo,"
        End If
        cad_5b = cMonto_d_debe
        cad_6b = " ,concat(ingreso.cod_alma,'-',nom_art),'ADMIN' as cdo_usuari,ingreso,tm,'a3' as orden"
        'cad_7b = " from ingreso inner join ingreso_det on ingreso.operacion=ingreso_det.operacion" _
        cad_7b = cading _
                & " inner join almacen on ingreso.cod_alma=almacen.cod_alma"
        cad_8b = " inner join articulo on ingreso_det.cod_art=articulo.cod_art" _
                & " inner join documento_i on ingreso.cod_doc=documento_i.cod_doc" _
                & " inner join forma_pago on ingreso.cod_fpago=forma_pago.cod_fpago"
        cad_9b = " where(esMigracion) and tm='D' and fec_doc>='" & fInicial & "'" _
                & " and fec_doc<='" & fFinal & "' and almacen.cod_emp='" & pEmpresa & "'"
        cad_10b = " UNION"
        '******************************
        'RECUERAMOS EL IMPUESTO - soles
        '******************************
        If optDBF.Checked = True Then
            cad11 = " select date_format(curdate(),'%m-%d-%Y') as fec_regist,date_format(fec_doc,'%m-%d-%Y') as fec_movimi,"
            cad12 = " month(fec_doc) as mes_movimi,'C' as cdo_fuente,'401111' as cdo_cuenta,cod_prov as cdo_auxili,'' as cdo_refere,cod_fiscal as tip_docume,"
            cad13 = " concat(right(ser_doc,3),'-',nro_doc) as num_docume,date_format(addDate(fec_doc,dias),'%m-%d-%Y')  as fec_vencim,'' as tip_docref,"
            cad14 = " '' as num_docref,'C' as mov_carabo,"
        Else
            cad11 = " select date_format(curdate(),'%d-%m-%Y') as fec_regist,date_format(fec_doc,'%d-%m-%Y') as fec_movimi,"
            cad12 = " month(fec_doc) as mes_movimi,'C' as cdo_fuente,'401111' as cdo_cuenta,cod_prov as cdo_auxili,'' as cdo_refere,cod_fiscal as tip_docume,"
            cad13 = " concat(right(ser_doc,3),'-',nro_doc) as num_docume,date_format(fec_doc,'%d-%m-%Y')  as fec_vencim,'' as tip_docref,"
            cad14 = " '' as num_docref,'C' as mov_carabo,"
        End If
        cad15 = cMonto_s_imp & ",concat(ingreso.cod_alma,'-','Por las Compras') as des_movimi,'ADMIN' as cdo_usuari,'999999' as ingreso,tm,'a4' as orden"
        'cad16 = " from ingreso " _
        cad16 = cading1 _
                & " inner join documento_i on ingreso.cod_doc=documento_i.cod_doc" _
                & " inner join forma_pago on ingreso.cod_fpago=forma_pago.cod_fpago" _
                & " inner join almacen on ingreso.cod_alma=almacen.cod_alma"
        cad17 = " where(esMigracion) and tm<>'D' and fec_doc>='" & fInicial & "'" _
                & " and fec_doc<='" & fFinal & "' and almacen.cod_emp='" & pEmpresa & "'"
        cad18 = " UNION"
        'RECUERAMOS EL IMPUESTO - dolares
        If optDBF.Checked = True Then
            cad_11 = " select date_format(curdate(),'%m-%d-%Y') as fec_regist,date_format(fec_doc,'%m-%d-%Y') as fec_movimi,"
            cad_12 = " month(fec_doc) as mes_movimi,'C' as cdo_fuente,'401111' as cdo_cuenta,cod_prov as cdo_auxili,'' as cdo_refere,cod_fiscal as tip_docume,"
            cad_13 = " concat(right(ser_doc,3),'-',nro_doc) as num_docume,date_format(addDate(fec_doc,dias),'%m-%d-%Y')  as fec_vencim,'' as tip_docref,"
            cad_14 = " '' as num_docref,'C' as mov_carabo,"
        Else
            cad_11 = " select date_format(curdate(),'%d-%m-%Y') as fec_regist,date_format(fec_doc,'%d-%m-%Y') as fec_movimi,"
            cad_12 = " month(fec_doc) as mes_movimi,'C' as cdo_fuente,'401111' as cdo_cuenta,cod_prov as cdo_auxili,'' as cdo_refere,cod_fiscal as tip_docume,"
            cad_13 = " concat(right(ser_doc,3),'-',nro_doc) as num_docume,date_format(fec_doc,'%d-%m-%Y')  as fec_vencim,'' as tip_docref,"
            cad_14 = " '' as num_docref,'C' as mov_carabo,"
        End If
        cad_15 = cMonto_d_imp & " ,concat(ingreso.cod_alma,'-','Por las Compras') as des_movimi,'ADMIN' as cdo_usuari,'999999' as ingreso,tm,'a4' as orden"
        cad_16 = cading1 _
                & " inner join documento_i on ingreso.cod_doc=documento_i.cod_doc" _
                & " inner join forma_pago on ingreso.cod_fpago=forma_pago.cod_fpago" _
                & " inner join almacen on ingreso.cod_alma=almacen.cod_alma"
        cad_17 = " where(esMigracion) and tm='D' and fec_doc>='" & fInicial & "'" _
                & " and fec_doc<='" & fFinal & "' and almacen.cod_emp='" & pEmpresa & "'"
        cad_18 = " UNION"
        '*******************************************
        'recuperamos el monto del documento - soles
        '*******************************************
        If optDBF.Checked = True Then
            cad19 = " select date_format(curdate(),'%m-%d-%Y') as fec_regist,date_format(fec_doc,'%m-%d-%Y') as fec_movimi,month(fec_doc) as mes_movimi,"
            cad20 = " 'C' as cdo_fuente,cuenta_c_p as cdo_cuenta,ingreso.cod_prov as cdo_auxili,'' as cdo_refere,cod_fiscal as tip_docume,"
            cad21 = " concat(right(ser_doc,3),'-',nro_doc) as num_docume,date_format(addDate(fec_doc,dias),'%m-%d-%Y')  as fec_vencim,'' as tip_docref,"
            cad22 = " '' as num_docref,'A' as mov_carabo,"
        Else
            cad19 = " select date_format(curdate(),'%d-%m-%Y') as fec_regist,date_format(fec_doc,'%d-%m-%Y') as fec_movimi,month(fec_doc) as mes_movimi,"
            cad20 = " 'C' as cdo_fuente,cuenta_c_p as cdo_cuenta,ingreso.cod_prov as cdo_auxili,'' as cdo_refere,cod_fiscal as tip_docume,"
            cad21 = " concat(rigt(ser_doc,3),'-',nro_doc) as num_docume,date_format(fec_doc,'%d-%m-%Y')  as fec_vencim,'' as tip_docref,"
            cad22 = " '' as num_docref,'A' as mov_carabo,"
        End If
        cad23 = cMonto_s & " ,concat(ingreso.cod_alma,'-',raz_soc) as des_movimi,'ADMIN' as cdo_usuari,'999999' as ingreso,tm,'a5' as orden"
        'cad24 = " from ingreso inner join ingreso_det on ingreso.operacion=ingreso_det.operacion" _
        cad24 = cading _
                & " inner join almacen on ingreso.cod_alma=almacen.cod_alma" _
                & " inner join articulo on ingreso_det.cod_art=articulo.cod_art" _
                & " inner join documento_i on ingreso.cod_doc=documento_i.cod_doc"
        cad25 = " inner join proveedor on ingreso.cod_prov=proveedor.cod_prov" _
                & " inner join forma_pago on ingreso.cod_fpago=forma_pago.cod_fpago"
        cad26 = " where(esMigracion) and tm<>'D' and fec_doc>='" & fInicial & "'" _
                & " and fec_doc<='" & fFinal & "' and almacen.cod_emp='" & pEmpresa & "'"
        cad27 = " UNION"
        'recuperamos el monto del documento - dolares
        If optDBF.Checked = True Then
            cad_19 = " select date_format(curdate(),'%m-%d-%Y') as fec_regist,date_format(fec_doc,'%m-%d-%Y') as fec_movimi,month(fec_doc) as mes_movimi,"
            cad_20 = " 'C' as cdo_fuente,cuenta_c_p as cdo_cuenta,ingreso.cod_prov as cdo_auxili,'' as cdo_refere,cod_fiscal as tip_docume,"
            cad_21 = " concat(right(ser_doc,3),'-',nro_doc) as num_docume,date_format(addDate(fec_doc,dias),'%m-%d-%Y')  as fec_vencim,'' as tip_docref,"
            cad_22 = " '' as num_docref,'A' as mov_carabo,"
        Else
            cad_19 = " select date_format(curdate(),'%d-%m-%Y') as fec_regist,date_format(fec_doc,'%d-%m-%Y') as fec_movimi,month(fec_doc) as mes_movimi,"
            cad_20 = " 'C' as cdo_fuente,cuenta_c_p as cdo_cuenta,ingreso.cod_prov as cdo_auxili,'' as cdo_refere,cod_fiscal as tip_docume,"
            cad_21 = " concat(rigt(ser_doc,3),'-',nro_doc) as num_docume,date_format(fec_doc,'%d-%m-%Y')  as fec_vencim,'' as tip_docref,"
            cad_22 = " '' as num_docref,'A' as mov_carabo,"
        End If
        cad_23 = cMonto_d & " ,concat(ingreso.cod_alma,'-',raz_soc) as des_movimi,'ADMIN' as cdo_usuari,'999999' as ingreso,tm,'a5' as orden"
        'cad_24 = " from ingreso inner join ingreso_det on ingreso.operacion=ingreso_det.operacion" _
        cad_24 = cading _
                & " inner join almacen on ingreso.cod_alma=almacen.cod_alma" _
                & " inner join articulo on ingreso_det.cod_art=articulo.cod_art" _
                & " inner join documento_i on ingreso.cod_doc=documento_i.cod_doc"
        cad_25 = " inner join proveedor on ingreso.cod_prov=proveedor.cod_prov" _
                & " inner join forma_pago on ingreso.cod_fpago=forma_pago.cod_fpago"
        cad_26 = " where(esMigracion) and tm='D' and fec_doc>='" & fInicial & "'" _
                & " and fec_doc<='" & fFinal & "' and almacen.cod_emp='" & pEmpresa & "'"

        cadOrden = " order by fec_movimi,num_docume,ingreso,orden"
        cad100 = cad1 + cad2 + cad3 + cad4 + cad5 + cad6 + cad7 + cad8 + cad9 + cad10 + cad_1 + cad_2 + cad_3 + cad_4 + cad_5 + cad_6 + cad_7 + cad_8 + cad_9 + cad_10
        cad100a = cad1a + cad2a + cad3a + cad4a + cad5a + cad6a + cad7a + cad8a + cad9a + cad10a + cad_1a + cad_2a + cad_3a + cad_4a + cad_5a + cad_6a + cad_7a + cad_8a + cad_9a + cad_10a
        cad100b = cad1b + cad2b + cad3b + cad4b + cad5b + cad6b + cad7b + cad8b + cad9b + cad10b + cad_1b + cad_2b + cad_3b + cad_4b + cad_5b + cad_6b + cad_7b + cad_8b + cad_9b + cad_10b
        cad101 = cad11 + cad12 + cad13 + cad14 + cad15 + cad16 + cad17 + cad18 + cad_11 + cad_12 + cad_13 + cad_14 + cad_15 + cad_16 + cad_17 + cad18
        cad102 = cad19 + cad20 + cad21 + cad22 + cad23 + cad24 + cad25 + cad26 + cad27 + cad_19 + cad_20 + cad_21 + cad_22 + cad_23 + cad_24 + cad_25 + cad_26 + cadOrden
        'cad = cad100 + cad100a + cad100b + cad101 + cad102
        cad = cad100 + cad100a + cad100b + cad101 + cad102
        Return cad
    End Function

    Private Sub optDBF_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optDBF.CheckedChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim MyDlg As New SaveFileDialog
        With MyDlg
            .Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                MessageBox.Show(.FileName)
            End If
        End With
    End Sub
End Class
