Imports System.IO
Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions
Public Class u_envioVentas
    Private dr As MySqlDataReader
    Private fec_regist, fec_movimi, mes_movimi, cdo_fuente, cdo_cuenta, cdo_auxili, cdo_refere, tip_docume, num_docume As String
    Private fec_vencim, tip_docref, num_docref, mov_carabo, des_movimi, cdo_usuari, tm As String
    Private monto_debe, monto_habe, dolar_debe, dolar_habe As Decimal, I As Integer = 0, doc_s As String, doc_i As Integer
    Private Sub u_envioVentas_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        principal.mu_envioVentas.Enabled = True
    End Sub
    Private Sub u_envioVentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
    End Sub
    Private Sub cmdEnvio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEnvio.Click
        Dim fdesde As String = general.devuelveFechaEspecificada(mcDesde.SelectedDate)
        Dim fhasta As String = general.devuelveFechaEspecificada(mcHasta.SelectedDate)
        Dim periodo As String = general.convierteFechaEspecificadaMes(mcHasta.SelectedDate)
        Dim esHistorial As Boolean = IIf(periodo >= periodoActivo(), False, True)
        I = 0
        Dim cadVentas, nomArchivo, cprefijo As String
        If opt_cxcobrar.Checked Then
            cadVentas = textoCCobrar(mcDesde.SelectedDate, mcHasta.SelectedDate)
            nomArchivo = "C:\CC" & fdesde & "_" & fhasta
            cprefijo = "I"

        ElseIf opt_cancela.Checked Then
            cadVentas = textoCancela(mcDesde.SelectedDate, mcHasta.SelectedDate, esHistorial)
            nomArchivo = "C:\VC" & fdesde & "_" & fhasta
            cprefijo = "I"
        Else
            cadVentas = textoVentas(mcDesde.SelectedDate, mcHasta.SelectedDate, esHistorial)
            nomArchivo = "C:\V" & fdesde & "_" & fhasta
            cprefijo = "V"
        End If

        Dim com As New MySqlCommand(cadVentas, dbConex)

        If optDBF.Checked = True Then
            Dim cnDBF As New OleDb.OleDbConnection("Provider = VFPOLEDB.1; Data Source = C:\;")
            cnDBF.Open()
            'creamos la tabla de compras
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
            dr = com.ExecuteReader
            If dr.HasRows = True Then
                While dr.Read
                    recuperaVentas(cprefijo)
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
                End While
            End If
            cnDBF.Close()
        Else
            'creamos el archivo de compras
            Dim oSW As New StreamWriter(nomArchivo)
            dr = com.ExecuteReader
            If dr.HasRows = True Then
                While dr.Read
                    recuperaVentas(cprefijo)
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
    Sub recuperaVentas(ByVal prefijo As String)
        fec_regist = dr("fec_regist")
        fec_movimi = dr("fec_movimi")
        mes_movimi = Microsoft.VisualBasic.Right("00" & dr("mes_movimi"), 2)
        cdo_fuente = dr("cdo_fuente")
        cdo_cuenta = dr("cdo_cuenta")
        cdo_auxili = dr("cdo_auxili")
        num_docume = dr("num_docume")
        If opt_rventas.Checked Or opt_cancela.Checked Then
            If doc_s <> dr("num_docume") Then
                I = I + 1
            End If
        Else
            If doc_i <> dr("cdo_refere") Then
                I = I + 1
            End If
        End If
        tip_docume = dr("tip_docume")
        num_docume = dr("num_docume")
        If opt_cxcobrar.Checked Then
            doc_i = dr("cdo_refere")
        Else
            doc_s = dr("num_docume")
        End If
        fec_vencim = dr("fec_vencim")
        tip_docref = dr("tip_docref")
        num_docref = dr("num_docref")
        mov_carabo = dr("mov_carabo")
        monto_debe = dr("monto_debe")
        monto_habe = dr("monto_habe")
        dolar_debe = dr("dolar_debe")
        dolar_habe = dr("dolar_habe")
        If dolar_debe > 0 Or dolar_habe > 0 Then
            tm = "$1"
        Else
            tm = "00"
        End If
        des_movimi = dr("des_movimi")
        cdo_usuari = dr("cdo_usuari")
        cdo_refere = Microsoft.VisualBasic.Right("00000" & I, 5) & cdo_fuente & tm
    End Sub
    Function textoVentas(ByVal fecInicial As Date, ByVal fecFinal As Date, ByVal eshis As Boolean) As String
        Dim fInicial As String = fecInicial.ToString("yy-MM-dd")
        Dim fFinal As String = fecFinal.ToString("yy-MM-dd")
        Dim cading, cading1, cad, cad1, cad2, cad3, cad4, cad5, cad6, cad7, cad8, cad9, cad10, cad11, cad12, cad13, cad14, cad15 As String
        '  Dim cad31, cad32, cad33, cad34, cad35, cad36, cad37, cad43, cad44, cad45, cad46, cad47, cad48, cad49,cad200 As String
        Dim cad16, cad17, cad18, cad19, cad100 As String
        If eshis Then
            cading = " from h_salida as salida inner join h_salida_det as salida_det on salida.operacion=salida_det.operacion and salida.proceso=salida_det.proceso"
            cading1 = " from h_salida as salida"
        Else
            cading = " from salida as salida inner join salida_det as salida_det on salida.operacion=salida_det.operacion"
            cading1 = " from salida as salida"
        End If

        If optDBF.Checked = True Then
            cad1 = " select date_format(curdate(),'%m-%d-%Y') as fec_regist,date_format(fec_doc,'%m-%d-%Y') as fec_movimi,month(fec_doc) as mes_movimi,'V' as cdo_fuente,cuenta_v as cdo_cuenta,IF(salida.cod_doc='01',cod_clie,'99999999999') as cdo_auxili,'' as cdo_refere,"
            cad2 = " IF(salida.cod_doc='01','01','03') as tip_docume,concat(ser_doc,'-',nro_doc) as num_docume,date_format(adddate(fec_doc,dias),'%m-%d-%Y')  as fec_vencim,'' as tip_docref,'' as num_docref,'A' as mov_carabo,"
        Else
            cad1 = " select date_format(curdate(),'%d-%m-%Y') as fec_regist,date_format(fec_doc,'%d-%m-%Y') as fec_movimi,month(fec_doc) as mes_movimi,'V' as cdo_fuente,cuenta_v as cdo_cuenta,IF(salida.cod_doc='01',cod_clie,'99999999999') as cdo_auxili,'' as cdo_refere,"
            cad2 = " IF(salida.cod_doc='01','01','03') as tip_docume, concat(ser_doc,'-',nro_doc) as num_docume,date_format(adddate(fec_doc,dias),'%d-%m-%Y')  as fec_vencim,'' as tip_docref,'' as num_docref,'A' as mov_carabo,"
        End If
        cad3 = " if(tip_cuenta='D', if(tm='S',abs(sum(IF(pre_inc_igv=1,(cant*precio/(1+igv)),(cant*precio)))),0),0) as monto_debe, " _
                & " if(tip_cuenta='D',0,if(tm='S',sum(IF(pre_inc_igv=1,(cant*precio/(1+igv)),(cant*precio))),0)) as monto_habe,0 as dolar_debe,if(tm='D',sum(IF(pre_inc_igv=1,(cant*precio/(1+igv)),(cant*precio))),0) as dolar_habe,nom_art as des_movimi,'ADMIN' as cdo_usuari"
        '        & " if(tip_cuenta='D',0,if(tm='S',sum(IF(pre_inc_igv=1,round(cant*precio/(1+igv),nro_dec),round(cant*precio,nro_dec))),0)) as monto_habe,0 as dolar_debe,if(tm='D',sum(IF(pre_inc_igv=1,round(cant*precio/(1+igv),nro_dec),round(cant*precio,nro_dec))),0) as dolar_habe,nom_art as des_movimi,'ADMIN' as cdo_usuari"
        cad4 = cading & " inner join articulo on salida_det.cod_art=articulo.cod_art inner join documento_s on salida.cod_doc=documento_s.cod_doc"
        cad5 = " inner join forma_pago on salida.cod_fpago=forma_pago.cod_fpago where precio>0 and (esMigracion) and fec_doc>='" & fInicial & "'" & " and fec_doc<='" & fFinal & "' group by num_docume,cdo_cuenta"
        cad6 = " UNION ALL"
        If optDBF.Checked = True Then
            cad7 = " select date_format(curdate(),'%m-%d-%Y') as fec_regist,date_format(fec_doc,'%m-%d-%Y') as fec_movimi,month(fec_doc) as mes_movimi,'V' as cdo_fuente,'401111' as cdo_cuenta,IF(salida.cod_doc='01',cod_clie,'99999999999') as cdo_auxili,'' as cdo_refere,"
            cad8 = " IF(salida.cod_doc='01','01','03') as tip_docume,concat(ser_doc,'-',nro_doc) as num_docume,date_format(adddate(fec_doc,dias),'%m-%d-%Y')  as fec_vencim,'' as tip_docref,'' as num_docref,'A' as mov_carabo,0 as monto_debe,"
        Else
            cad7 = " select date_format(curdate(),'%d-%m-%Y') as fec_regist,date_format(fec_doc,'%d-%m-%Y') as fec_movimi,month(fec_doc) as mes_movimi,'V' as cdo_fuente,'401111' as cdo_cuenta,IF(salida.cod_doc='01',cod_clie,'99999999999') as cdo_auxili,'' as cdo_refere,"
            cad8 = " IF(salida.cod_doc='01','01','03') as tip_docume,concat(ser_doc,'-',nro_doc) as num_docume,date_format(adddate(fec_doc,dias),'%d-%m-%Y')  as fec_vencim,'' as tip_docref,'' as num_docref,'A' as mov_carabo,0 as monto_debe,"
        End If
        cad9 = " if(tm='S',monto_igv,0) as monto_habe,0 as dolar_debe,if(tm='D',monto_igv,0) as dolar_habe,'IGV' as des_movimi,'ADMIN' as cdo_usuari"
        cad10 = cading1 & " inner join documento_s on salida.cod_doc=documento_s.cod_doc inner join forma_pago on salida.cod_fpago=forma_pago.cod_fpago"
        cad11 = " where  (esMigracion) and fec_doc>='" & fInicial & "'" & " and fec_doc<='" & fFinal & "'"
        cad12 = " UNION All"
        If optDBF.Checked = True Then
            cad13 = " select date_format(curdate(),'%m-%d-%Y') as fec_regist,date_format(fec_doc,'%m-%d-%Y') as fec_movimi,month(fec_doc) as mes_movimi,'V' as cdo_fuente,if(tm='D',cuenta_c2,cuenta_c2) as cdo_cuenta,IF(salida.cod_doc='01',salida.cod_clie,'99999999999') as cdo_auxili,'' as cdo_refere,"
            cad14 = " IF(salida.cod_doc='01','01','03') as tip_docume,concat(ser_doc,'-',nro_doc) as num_docume,date_format(adddate(fec_doc,dias),'%m-%d-%Y')  as fec_vencim,'' as tip_docref,'' as num_docref,'C' as mov_carabo,if(tm='S',monto,0) as monto_debe,"
        Else
            cad13 = " select date_format(curdate(),'%d-%m-%Y') as fec_regist,date_format(fec_doc,'%d-%m-%Y') as fec_movimi,month(fec_doc) as mes_movimi,'V' as cdo_fuente,if(tm='D',cuenta_c2,cuenta_c2) as cdo_cuenta,IF(salida.cod_doc='01',salida.cod_clie,'99999999999')as cdo_auxili,'' as cdo_refere,"
            cad14 = " IF(salida.cod_doc='01','01','03') as tip_docume,concat(ser_doc,'-',nro_doc) as num_docume,date_format(adddate(fec_doc,dias),'%d-%m-%Y')  as fec_vencim,'' as tip_docref,'' as num_docref,'C' as mov_carabo,if(tm='S',monto,0) as monto_debe,"
        End If
        cad15 = " 0 as monto_habe,if(tm='D',monto,0) as dolar_debe,0 as dolar_habe,if(anul=1,salida.obs,raz_soc) as des_movimi,'ADMIN' as cdo_usuari"
        cad16 = cading1 & " inner join documento_s on salida.cod_doc=documento_s.cod_doc"
        cad17 = " inner join cliente on salida.cod_clie=cliente.cod_clie inner join forma_pago on salida.cod_fpago=forma_pago.cod_fpago"
        cad18 = " where  (esMigracion) and fec_doc>='" & fInicial & "'" & " and fec_doc<='" & fFinal & "'"
        cad19 = " order by fec_movimi,num_docume,mov_carabo,cdo_fuente desc,cdo_cuenta desc"

        cad100 = cad1 + cad2 + cad3 + cad4 + cad5 + cad6 + cad7 + cad8 + cad9 + cad10 + cad11 + cad12 + cad13 + cad14 + cad15 + cad16 + cad17 + cad18 + cad19

        cad = cad100
        Return cad
    End Function
    Function textoCCobrar(ByVal fecInicial As Date, ByVal fecFinal As Date) As String
        Dim fInicial As String = fecInicial.ToString("yy-MM-dd")
        Dim fFinal As String = fecFinal.ToString("yy-MM-dd")
        Dim cad, cad5, cad6, cad7, cad8, cad9, cad10, cad11, cad12, cad13, cad14, cad15 As String
        Dim cad16, cad17, cad18, cad19 As String
        cad5 = " select date_format(curdate(),'%m-%d-%Y') as fec_regist,date_format(fec_pago,'%m-%d-%Y') as fec_movimi,month(fec_pago) as mes_movimi,'I' as cdo_fuente,'104101' as cdo_cuenta,IF(cc.cod_doc='01',cc.cod_clie,'99999999999') as cdo_auxili,orden as cdo_refere,"
        cad6 = " '' as tip_docume,cc.obs as num_docume,date_format(adddate(fec_pago,0),'%m-%d-%Y')  as fec_vencim,'' as tip_docref,'' as num_docref,'C' as mov_carabo,sum(cant_pago) as monto_debe,"
        cad7 = " 0 as monto_habe,0 as dolar_debe,0 as dolar_habe,raz_soc as des_movimi,'ADMIN' as cdo_usuari"
        cad8 = " from cuenta_cobrar cc"
        cad9 = " inner join cliente c on cc.cod_clie=c.cod_clie "
        cad10 = " where cant_pago>0 and fec_pago>='" & fInicial & "'" & " and fec_pago<='" & fFinal & "'"
        cad11 = " group by orden"
        cad12 = " UNION All"
        cad13 = " select date_format(curdate(),'%m-%d-%Y') as fec_regist,date_format(fec_pago,'%m-%d-%Y') as fec_movimi,month(fec_pago) as mes_movimi,'I' as cdo_fuente,'121101' as cdo_cuenta,IF(cc.cod_doc='01',cc.cod_clie,'99999999999') as cdo_auxili,orden as cdo_refere,"
        cad14 = " IF(cc.cod_doc='01','01','03') as tip_docume,num_doc as num_docume,date_format(adddate(fec_pago,0),'%m-%d-%Y')  as fec_vencim,'' as tip_docref,'' as num_docref,'A' as mov_carabo,0 as monto_debe,"
        cad15 = " cant_prog as monto_habe,0 as dolar_debe,0 as dolar_habe,raz_soc as des_movimi,'ADMIN' as cdo_usuari"
        cad16 = " from cuenta_cobrar cc"
        cad17 = " inner join cliente c on cc.cod_clie=c.cod_clie "
        cad18 = " where cant_pago>0 and fec_pago>='" & fInicial & "'" & " and fec_pago<='" & fFinal & "'"
        cad19 = " order by fec_movimi,cdo_refere,mov_carabo,cdo_fuente desc,cdo_cuenta desc"
        cad = cad5 + cad6 + cad7 + cad8 + cad9 + cad10 + cad11 + cad12 + cad13 + cad14 + cad15 + cad16 + cad17 + cad18 + cad19
        Return cad
    End Function
    Function textoCancela(ByVal fecInicial As Date, ByVal fecFinal As Date, ByVal eshis As Boolean) As String
        Dim fInicial As String = fecInicial.ToString("yy-MM-dd")
        Dim fFinal As String = fecFinal.ToString("yy-MM-dd")
        Dim cad, cad5, cad6, cad7, cad13, cad14, cad15, cading1 As String
        Dim cad1, cad2, cad3, cad4, cad16, cad17, cad18, cad19 As String
        If eshis Then
            'cading = " from h_salida as salida inner join h_salida_det as salida_det on salida.operacion=salida_det.operacion and salida.proceso=salida_det.proceso"
            cading1 = " from salida as salida"
        Else
            'cading = " from salida as salida inner join salida_det as salida_det on salida.operacion=salida_det.operacion"
            cading1 = " from salida as salida"
        End If

        If optDBF.Checked = True Then
            cad1 = " select date_format(curdate(),'%m-%d-%Y') as fec_regist,date_format(fec_doc,'%m-%d-%Y') as fec_movimi,month(fec_doc) as mes_movimi,'I' as cdo_fuente,if(tm='D',cuenta_c1,cuenta_c1) as cdo_cuenta,IF(salida.cod_doc='01',salida.cod_clie,'99999999999') as cdo_auxili,'' as cdo_refere,"
            cad2 = " IF(salida.cod_doc='01','01','03') as tip_docume,concat(ser_doc,'-',nro_doc) as num_docume,date_format(adddate(fec_doc,dias),'%m-%d-%Y')  as fec_vencim,'' as tip_docref,'' as num_docref,'C' as mov_carabo,if(tm='S',imp_pagado-imp_vuelto,0) as monto_debe,"
        Else
            cad1 = " select date_format(curdate(),'%d-%m-%Y') as fec_regist,date_format(fec_doc,'%d-%m-%Y') as fec_movimi,month(fec_doc) as mes_movimi,'I' as cdo_fuente,if(tm='D',cuenta_c1,cuenta_c1) as cdo_cuenta,IF(salida.cod_doc='01',salida.cod_clie,'99999999999')as cdo_auxili,'' as cdo_refere,"
            cad2 = " IF(salida.cod_doc='01','01','03') as tip_docume,concat(ser_doc,'-',nro_doc) as num_docume,date_format(adddate(fec_doc,dias),'%d-%m-%Y')  as fec_vencim,'' as tip_docref,'' as num_docref,'C' as mov_carabo,if(tm='S',imp_pagado-imp_vuelto,0) as monto_debe,"
        End If
        cad3 = " 0 as monto_habe,if(tm='D',monto,0) as dolar_debe,0 as dolar_habe,'Cancelacion' as des_movimi,'ADMIN' as cdo_usuari"
        cad4 = cading1 & " inner join salida_detpago on salida.operacion=salida_detpago.operacion inner join documento_s on salida.cod_doc=documento_s.cod_doc"
        cad5 = " inner join cliente on salida.cod_clie=cliente.cod_clie inner join forma_pago on salida_detpago.cod_fpago=forma_pago.cod_fpago"
        cad6 = " where (esMigracion) and fec_doc>='" & fInicial & "'" & " and fec_doc<='" & fFinal & "'"
        cad7 = " UNION ALL"
        If optDBF.Checked = True Then
            cad13 = " select date_format(curdate(),'%m-%d-%Y') as fec_regist,date_format(fec_doc,'%m-%d-%Y') as fec_movimi,month(fec_doc) as mes_movimi,'I' as cdo_fuente,if(tm='D',cuenta_c2,cuenta_c2) as cdo_cuenta,IF(salida.cod_doc='01',salida.cod_clie,'99999999999') as cdo_auxili,'' as cdo_refere,"
            cad14 = " IF(salida.cod_doc='01','01','03') as tip_docume,concat(ser_doc,'-',nro_doc) as num_docume,date_format(adddate(fec_doc,dias),'%m-%d-%Y')  as fec_vencim,'' as tip_docref,'' as num_docref,'C' as mov_carabo,0 as monto_debe,"
        Else
            cad13 = " select date_format(curdate(),'%d-%m-%Y') as fec_regist,date_format(fec_doc,'%d-%m-%Y') as fec_movimi,month(fec_doc) as mes_movimi,'I' as cdo_fuente,if(tm='D',cuenta_c2,cuenta_c2) as cdo_cuenta,IF(salida.cod_doc='01',salida.cod_clie,'99999999999')as cdo_auxili,'' as cdo_refere,"
            cad14 = " IF(salida.cod_doc='01','01','03') as tip_docume,concat(ser_doc,'-',nro_doc) as num_docume,date_format(adddate(fec_doc,dias),'%d-%m-%Y')  as fec_vencim,'' as tip_docref,'' as num_docref,'C' as mov_carabo,0 as monto_debe,"
        End If
        cad15 = " if(tm='S',monto,0) as monto_habe,if(tm='D',monto,0) as dolar_debe,0 as dolar_habe,'Cancelacion' as des_movimi,'ADMIN' as cdo_usuari"
        cad16 = cading1 & " inner join documento_s on salida.cod_doc=documento_s.cod_doc"
        cad17 = " inner join cliente on salida.cod_clie=cliente.cod_clie inner join forma_pago on salida.cod_fpago=forma_pago.cod_fpago"
        cad18 = " where (esMigracion) and fec_doc>='" & fInicial & "'" & " and fec_doc<='" & fFinal & "'"
        cad19 = " order by fec_movimi,num_docume,mov_carabo,cdo_fuente desc,cdo_cuenta desc"

        cad = cad1 + cad2 + cad3 + cad4 + cad5 + cad6 + cad7 + cad13 + cad14 + cad15 + cad16 + cad17 + cad18 + cad19

        Return cad
    End Function
    Function textoVentas_consolidado(ByVal fecInicial As Date, ByVal fecFinal As Date) As String
        Dim fInicial As String = fecInicial.ToString("yy-MM-dd")
        Dim fFinal As String = fecFinal.ToString("yy-MM-dd")
        Dim cad, cad1, cad2, cad3, cad4, cad5, cad6, cad7, cad8, cad9, cad10, cad11, cad12, cad13, cad14, cad15 As String
        Dim cad16, cad17, cad18, cad19 As String
        If optDBF.Checked = True Then
            cad1 = "select date_format(curdate(),'%m-%d-%Y') as fec_regist,date_format(fec_doc,'%m-%d-%Y') as fec_movimi,month(fec_doc) as mes_movimi,'V' as cdo_fuente,'70' as cdo_cuenta,'' as cdo_auxili,'' as cdo_refere,"
            cad2 = " IF(salida.cod_doc='01','01','03') as tip_docume,concat(ser_doc,'-',nro_doc) as num_docume,date_format(adddate(fec_doc,forma_pago.dias),'%m-%d-%Y')  as fec_vencim,'' as tip_docref,'' as num_docref,'A' as mov_carabo,0 as monto_debe,"
        Else
            cad1 = "select date_format(curdate(),'%d-%m-%Y') as fec_regist,date_format(fec_doc,'%d-%m-%Y') as fec_movimi,month(fec_doc) as mes_movimi,'V' as cdo_fuente,'70' as cdo_cuenta,'' as cdo_auxili,'' as cdo_refere,"
            cad2 = " IF(salida.cod_doc='01','01','03') as tip_docume,concat(ser_doc,'-',nro_doc) as num_docume,date_format(fec_doc,'%d-%m-%Y')  as fec_vencim,'' as tip_docref,'' as num_docref,'A' as mov_carabo,0 as monto_debe,"
        End If
        cad3 = " monto-monto_igv as monto_habe,0 as dolar_debe,0 as dolar_habe,'Por las Ventas' as des_movimi,'ADMIN' as cdo_usuari"
        cad4 = " from salida inner join documento_s on salida.cod_doc=documento_s.cod_doc inner join forma_pago on salida.cod_fpago=forma_pago=cod_fpago"
        cad5 = " where(esMigracion) and anul=0 and fec_doc>='" & fInicial & "'" & " and fec_doc<='" & fFinal & "'"
        cad6 = " UNION"
        If optDBF.Checked = True Then
            cad7 = " select date_format(curdate(),'%m-%d-%Y') as fec_regist,date_format(fec_doc,'%m-%d-%Y') as fec_movimi,month(fec_doc) as mes_movimi,'V' as cdo_fuente,'40' as cdo_cuenta,IF(salida.cod_doc='1',salida.cod_clie,'99999999999') as cdo_auxili,'' as cdo_refere,"
            cad8 = " IF(salida.cod_doc='01','01','03') as tip_docume,concat(ser_doc,'-',nro_doc) as num_docume,date_format(adddate(fec_doc,forma_pago.dias),'%m-%d-%Y')  as fec_vencim,'' as tip_docref,'' as num_docref,'A' as mov_carabo,0 as monto_debe,"
        Else
            cad7 = " select date_format(curdate(),'%d-%m-%Y') as fec_regist,date_format(fec_doc,'%d-%m-%Y') as fec_movimi,month(fec_doc) as mes_movimi,'V' as cdo_fuente,'40' as cdo_cuenta,IF(salida.cod_doc='1',salida.cod_clie,'99999999999') as cdo_auxili,'' as cdo_refere,"
            cad8 = " IF(salida.cod_doc='01','01','03') as tip_docume,concat(ser_doc,'-',nro_doc) as num_docume,date_format(fec_doc,'%d-%m-%Y')  as fec_vencim,'' as tip_docref,'' as num_docref,'A' as mov_carabo,0 as monto_debe,"
        End If
        cad9 = " monto_igv as monto_habe,0 as dolar_debe,0 as dolar_habe,'Por las Ventas' as des_movimi,'ADMIN' as cdo_usuari"
        cad10 = " from salida inner join documento_s on salida.cod_doc=documento_s.cod_doc inner join forma_pago on salida.cod_fpago=forma_pago=cod_fpago"
        cad11 = " where(esMigracion) and anul=0 and fec_doc>='" & fInicial & "'" & " and fec_doc<='" & fFinal & "'"
        cad12 = " UNION"
        If optDBF.Checked = True Then
            cad13 = " select date_format(curdate(),'%m-%d-%Y') as fec_regist,date_format(fec_doc,'%m-%d-%Y') as fec_movimi,month(fec_doc) as mes_movimi,'V' as cdo_fuente,'12' as cdo_cuenta,IF(salida.cod_doc='1',salida.cod_clie,'99999999999') as cdo_auxili,'' as cdo_refere,"
            cad14 = " IF(salida.cod_doc='01','01','03') as tip_docume,concat(ser_doc,'-',nro_doc) as num_docume,date_format(adddate(fec_doc,forma_pago.dias),'%m-%d-%Y')  as fec_vencim,'' as tip_docref,'' as num_docref,'C' as mov_carabo,monto as monto_debe,"
        Else
            cad13 = " select date_format(curdate(),'%d-%m-%Y') as fec_regist,date_format(fec_doc,'%d-%m-%Y') as fec_movimi,month(fec_doc) as mes_movimi,'V' as cdo_fuente,'12' as cdo_cuenta,IF(salida.cod_doc='1',salida.cod_clie,'99999999999') as cdo_auxili,'' as cdo_refere,"
            cad14 = " IF(salida.cod_doc='01','01','03') as tip_docume,concat(ser_doc,'-',nro_doc) as num_docume,date_format(fec_doc,'%d-%m-%Y')  as fec_vencim,'' as tip_docref,'' as num_docref,'C' as mov_carabo,monto as monto_debe,"
        End If
        cad15 = " 0 as monto_habe,0 as dolar_debe,0 as dolar_habe,raz_soc as des_movimi,'ADMIN' as cdo_usuari"
        cad16 = " from salida inner join documento_s on salida.cod_doc=documento_s.cod_doc"
        cad17 = " inner join cliente on salida.cod_clie=cliente.cod_clie inner join forma_pago on salida.cod_fpago=forma_pago=cod_fpago"
        cad18 = " where(esMigracion) and anul=0 and fec_doc>='" & fInicial & "'" & " and fec_doc<='" & fFinal & "'"
        cad19 = " order by fec_movimi,num_docume,cdo_fuente desc,cdo_cuenta desc"
        cad = cad1 + cad2 + cad3 + cad4 + cad5 + cad6 + cad7 + cad8 + cad9 + cad10 + cad11 + cad12 + cad13 + cad14 + cad15 + cad16 + cad17 + cad18 + cad19
        Return cad
    End Function
End Class
