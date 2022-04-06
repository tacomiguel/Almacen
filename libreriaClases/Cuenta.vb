Imports MySql.Data.MySqlClient
Imports System.data
Public Class Cuenta
    Public Shared Function dsCuenta() As DataSet
        Dim ds As New DataSet
        ds.Tables.Add(crearTablacuentacobrar())
        Return ds
    End Function
    Private Shared Function crearTablacuentacobrar() As DataTable
        Dim dt As New DataTable("cuenta_cobrar")
        dt.Columns.Add(New DataColumn("operacion", GetType(Integer)))
        dt.Columns.Add(New DataColumn("orden", GetType(Integer)))
        dt.Columns.Add(New DataColumn("fec_prog", GetType(Date)))
        dt.Columns.Add(New DataColumn("cant_prog", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("fec_pago", GetType(Date)))
        dt.Columns.Add(New DataColumn("cant_pago", GetType(Decimal)))
        Return dt
    End Function
    Public Shared Function recuperaCuentaCobrar(ByVal periodo As String, ByVal xcancelado As Boolean) As DataSet
        Dim mConex As MySqlConnection = Conexion.obtenerConexion
        Dim da As New MySqlDataAdapter
        Dim ds As New DataSet
        Dim dt As New DataTable("cuenta")
        ds.Tables.Add(dt)
        Dim sql, sql1, sql2, sql3, sql4, sql6, sql7, sql8, sql9 As String
        Dim sql01, sql11, sql21, sql31, sql41, sql61, sql71, sql81, sql91 As String
        sql1 = "select cc.proceso,s.operacion,fec_doc,raz_soc,concat(abr,ser_doc,'-',nro_doc)as doc,cliente.cod_clie,s.cod_vend,v.nom_vend,"
        sql2 = " monto,monto_pago,fec_prog,monto-monto_pago as cant_prog,s.fec_pago,cant_pago,nom_fpago,s.cod_doc,concat(ser_doc,'-',nro_doc)as nrodoc,cc.obs"
        sql3 = " from salida s inner join cliente on s.cod_clie=cliente.cod_clie"
        sql4 = " inner join documento_s on s.cod_doc=documento_s.cod_doc"
        sql6 = " inner join forma_pago on s.cod_fpago=forma_pago.cod_fpago"
        sql7 = " inner join vendedor v on s.cod_vend=v.cod_vend"
        sql8 = " left join cuenta_cobrar cc on s.operacion=cc.operacion "
        sql9 = " where " & IIf(xcancelado, " orden=0", " orden<>0") & " and anul= 0 "
        sql = sql1 + sql2 + sql3 + sql4 + sql6 + sql7 + sql8 + sql9
        sql11 = " union select s.proceso,s.operacion,fec_doc,raz_soc,concat(abr,ser_doc,'-',nro_doc)as doc,cliente.cod_clie,s.cod_vend,v.nom_vend,"
        sql21 = " monto,monto_pago,fec_prog,monto-monto_pago as cant_prog,s.fec_pago,cant_pago,nom_fpago,s.cod_doc,concat(ser_doc,'-',nro_doc)as nrodoc,cc.obs"
        sql31 = " from h_salida s inner join cliente on s.cod_clie=cliente.cod_clie"
        sql41 = " inner join documento_s on s.cod_doc=documento_s.cod_doc"
        sql61 = " inner join forma_pago on s.cod_fpago=forma_pago.cod_fpago"
        sql71 = " inner join vendedor v on s.cod_vend=v.cod_vend"
        sql81 = " left join cuenta_cobrar cc on s.operacion=cc.operacion and cc.proceso=s.proceso"
        sql91 = " where " & IIf(xcancelado, " orden=0", " orden<>0") & " and anul= 0 order by cod_clie,doc"
        sql01 = sql11 + sql21 + sql31 + sql41 + sql61 + sql71 + sql81 + sql91
        Dim com As New MySqlCommand
        com.CommandText = sql + sql01
        com.Connection = mConex
        da.SelectCommand = com
        da.Fill(ds, "cuenta")
        Return ds
    End Function
    Public Function insertarCC(ByVal periodo As String, _
                                ByVal nro_ope As Integer, _
                                ByVal orden As Integer, _
                                ByVal fec_prog As Date, _
                                ByVal cant_prog As Decimal, _
                                ByVal fec_pago As Date, _
                                ByVal cant_pago As Decimal, _
                                ByVal usuario As String) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim sql As String, result As Integer
        Dim mfecha1 As String = fec_prog.ToString("yy-MM-dd")
        If fec_pago = #9/4/1970# Then
            sql = "insert into cuenta_cobrar(proceso,operacion,orden,fec_prog,cant_prog,cant_pago,cuenta)" & _
                "values('" & periodo & "'," & nro_ope & "," & orden & ",'" & mfecha1 & "'," & cant_prog & "," & cant_pago & ",'" & usuario & "')"
        Else
            Dim mfecha2 As String = fec_pago.ToString("yy-MM-dd")
            sql = "insert into cuenta_cobrar(proceso,operacion,orden,fec_prog,cant_prog,fec_pago,cant_pago)" & _
            "values('" & periodo & "'," & nro_ope & "," & orden & ",'" & mfecha1 & "'," & cant_prog & ",'" & mfecha2 & "'," & cant_pago & ")"
        End If
        com.CommandText = sql
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function
    Public Function actualizarCC(ByVal periodo As String, _
                            ByVal nro_ope As Integer, _
                            ByVal nro_orden As Integer, _
                            ByVal fec_prog As Date, _
                            ByVal cant_prog As Decimal, _
                            ByVal fec_pago As Date, _
                            ByVal cant_pago As Decimal, _
                            ByVal coddoc As String, _
                            ByVal numdoc As String, _
                            ByVal codclie As String, _
                            Byval obs as string ) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim sql As String, result As Integer
        Dim mfecha1 As String = Microsoft.VisualBasic.Trim(fec_prog.ToString("yyyy-MM-dd"))
        If fec_pago = #9/4/1970# Then
            sql = "update cuenta_cobrar set fec_prog='" & mfecha1 & "'," & "orden=" & nro_orden & "," & "cant_prog=" & cant_prog & "," & "cant_pago=" & cant_pago & ",cod_doc='" & coddoc & "',num_doc='" & numdoc & "',cod_clie='" & codclie & "'" & _
                " where ordern=0 and proceso='" & periodo & "' and operacion=" & nro_ope

        Else
            Dim mfecha2 As String = Microsoft.VisualBasic.Trim(fec_pago.ToString("yyyy-MM-dd"))
            sql = "update cuenta_cobrar set fec_prog='" & mfecha1 & "'," & "fec_pago='" & mfecha2 & "'," & "orden=" & nro_orden & "," & "cant_prog=" & cant_prog & "," & "cant_pago=" & cant_pago & ",cod_doc='" & coddoc & "',num_doc='" & numdoc & "',cod_clie='" & codclie & "',obs='" & obs & "'" & _
            " where orden=0 and proceso='" & periodo & "' and operacion=" & nro_ope

        End If
        com.CommandText = sql
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function
    Public Function maxOrdenCC(ByVal nro_ope As Integer) As Integer
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer
        com.Connection = clConex
        com.CommandText = "select max(orden) from cuenta_cobrar where operacion=" & nro_ope
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Integer)
        clConex.Close()
        Return result + 1
    End Function
    Public Function recuperaPlanCuentas() As DataSet
        Dim ds As New DataSet, da As New MySqlDataAdapter
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim cad, cad1, cad2, cad3 As String
        cad1 = "select cod_art,nom_art,nom_uni,cuenta_v,cuenta_c,cuenta_c_a1,cuenta_c_a2 "
        cad2 = " from articulo inner join unidad on articulo.cod_uni=unidad.cod_uni"
        cad3 = " order by nom_art"
        cad = cad1 + cad2 + cad3
        Dim com As New MySqlCommand(cad)
        com.Connection = clConex
        da.SelectCommand = com
        da.Fill(ds, "planCuentas")
        clConex.Close()
        Return ds
    End Function
    Public Function recuperaPlanCuentas_grupo(ByVal xAlmacen As Boolean, ByVal cod_alma As String) As DataSet
        Dim ds As New DataSet, da As New MySqlDataAdapter
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim cad, cad1, cad2, cad3, cad4 As String
        cad1 = "select subgrupo.cod_sgrupo,concat(upper(Left(nom_sgrupo,1)), lower(substring(nom_sgrupo,2)))as nom_sgrupo," _
                & "plan_cuentas.cuenta_v,plan_cuentas.cuenta_v_c," _
                & "plan_cuentas.cuenta_c,plan_cuentas.cuenta_c_a1,plan_cuentas.cuenta_c_a2,plan_cuentas.cuenta_c_p "
        cad2 = " from subgrupo left join plan_cuentas on plan_cuentas.cod_sgrupo=subgrupo.cod_sgrupo"
        cad3 = " left join articulo on subgrupo.cod_sgrupo=articulo.cod_sgrupo"
        cad4 = IIf(xAlmacen, " where cod_alma='" & cod_alma & "'", "") & " group by articulo.cod_sgrupo order by nom_sgrupo"
        cad = cad1 + cad2 + cad3 + cad4
        Dim com As New MySqlCommand
        com.CommandText = cad
        com.Connection = clConex
        da.SelectCommand = com
        da.Fill(ds, "planCuentas")
        clConex.Close()
        Return ds
    End Function
    Public Function existeGrupo_enCuentas(ByVal cod_grupo As String) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer, cad As String
        com.Connection = clConex
        cad = "Select count(cod_sgrupo) from plan_cuentas where cod_sgrupo='" & cod_grupo & "'"
        com.CommandText = cad
        result = com.ExecuteScalar
        clConex.Close()
        If result = 0 Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Function insertaCuentaVentasGrupo(ByVal cod_grupo As String, _
             ByVal valorCuenta As String, _
             ByVal cuentaCobrar As String) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim result As Integer
        Dim cad, cad1, cad2 As String
        cad1 = "insert into plan_cuentas(cod_sgrupo,cuenta_v,cuenta_v_c)"
        cad2 = "values('" & cod_grupo & "','" & valorCuenta & "','" & cuentaCobrar & "')"
        cad = cad1 + cad2
        com.CommandText = cad
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function
    Public Function insertaCuentaComprasGrupo(ByVal cod_grupo As String, _
                 ByVal valorCuenta As String, ByVal valorAmarre1 As String, _
                 ByVal valorAmarre2 As String, ByVal valorCuentaPagar As String) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim result As Integer
        Dim cad, cad1, cad2 As String
        cad1 = "insert into plan_cuentas(cod_sgrupo,cuenta_c,cuenta_c_a1,cuenta_c_a2,cuenta_c_p)"
        cad2 = "values('" & cod_grupo & "','" & valorCuenta & "','" & valorAmarre1 & "','" _
                        & valorAmarre2 & "','" & valorCuentaPagar & "')"
        cad = cad1 + cad2
        com.CommandText = cad
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function
    Public Function actualizaCuentaVentasGrupo(ByVal cod_grupo As String, _
                 ByVal valorCuenta As String, _
                 ByVal cuentaCobrar As String) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim result As Integer
        Dim cad, cad1, cad2 As String
        cad1 = "update plan_cuentas set cuenta_v='" & valorCuenta & "',cuenta_v_c='" & cuentaCobrar & "'"
        cad2 = " where cod_sgrupo='" & cod_grupo & "'"
        cad = cad1 + cad2
        com.CommandText = cad
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function
    Public Function actualizaCuentaComprasGrupo(ByVal cod_grupo As String, _
                 ByVal valorCuenta As String, ByVal valorAmarre1 As String, _
                 ByVal valorAmarre2 As String, ByVal valorCuentaPagar As String) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim result As Integer
        Dim cad, cad1, cad2, cad3 As String
        cad1 = "update plan_cuentas set cuenta_c='" & valorCuenta & "',"
        cad2 = "cuenta_c_a1='" & valorAmarre1 & "',cuenta_c_a2='" & valorAmarre2 & "'," _
               & "cuenta_c_p='" & valorCuentaPagar & "'"
        cad3 = " where cod_sgrupo='" & cod_grupo & "'"
        cad = cad1 + cad2 + cad3
        com.CommandText = cad
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function
    Public Function maxOperacion() As Integer
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer
        com.Connection = clConex
        com.CommandText = "select max(orden) from cuenta_cobrar"
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Integer)
        clConex.Close()
        Return result + 1
    End Function
End Class
