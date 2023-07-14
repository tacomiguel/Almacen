Imports MySql.Data.MySqlClient
Public Class pedido
    Public Shared Function dsPedido() As DataSet
        Dim ds As New DataSet
        ds.Tables.Add(crearTablaDetalle())
        ds.Tables.Add(crearTablaCabecera())
        ds.Tables.Add(crearTablaPedido())
        Return ds
    End Function
    Private Shared Function crearTablaDetalle() As DataTable
        Dim dt As New DataTable("detalle")
        dt.Columns.Add(New DataColumn("cod_art", GetType(String)))
        dt.Columns.Add(New DataColumn("nom_art", GetType(String)))
        dt.Columns.Add(New DataColumn("nom_uni", GetType(String)))
        dt.Columns.Add(New DataColumn("saldo", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("cantidad", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("precio", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("igv", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("afecto_igv", GetType(Boolean)))
        'dt.Columns("IGV").DefaultValue = 1
        dt.Columns.Add(New DataColumn("neto", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("operacion", GetType(Integer)))
        dt.Columns.Add(New DataColumn("estado", GetType(String)))
        dt.Columns.Add(New DataColumn("foto", GetType(String)))
        dt.Columns.Add(New DataColumn("obs", GetType(String)))
        dt.Columns.Add(New DataColumn("orden", GetType(Integer)))
        dt.Columns.Add(New DataColumn("comi_v", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("comi_jv", GetType(Decimal)))
        Return dt
    End Function
    Private Shared Function crearTablaCabecera() As DataTable
        Dim dt As New DataTable("cabecera")
        dt.Columns.Add(New DataColumn("operacion", GetType(Integer)))
        dt.Columns.Add(New DataColumn("ser_ped", GetType(String)))
        dt.Columns.Add(New DataColumn("nro_ped", GetType(String)))
        dt.Columns.Add(New DataColumn("fec_ped", GetType(Date)))
        dt.Columns.Add(New DataColumn("fec_ent", GetType(Date)))
        dt.Columns.Add(New DataColumn("cod_vend", GetType(String)))
        dt.Columns.Add(New DataColumn("cod_clie", GetType(String)))
        dt.Columns.Add(New DataColumn("cod_fpago", GetType(String)))
        dt.Columns.Add(New DataColumn("cod_alma", GetType(String)))
        dt.Columns.Add(New DataColumn("dir_ent", GetType(String)))
        dt.Columns.Add(New DataColumn("obs", GetType(String)))
        dt.Columns.Add(New DataColumn("tm", GetType(String)))
        dt.Columns.Add(New DataColumn("pre_inc_igv", GetType(Boolean)))
        Return dt
    End Function
    Private Shared Function crearTablaPedido() As DataTable
        Dim dt As New DataTable("pedido")
        dt.Columns.Add(New DataColumn("operacion", GetType(Integer)))
        dt.Columns.Add(New DataColumn("ser_ped", GetType(String)))
        dt.Columns.Add(New DataColumn("nro_ped", GetType(String)))
        dt.Columns.Add(New DataColumn("pedido", GetType(String)))
        dt.Columns.Add(New DataColumn("fec_ped", GetType(Date)))
        dt.Columns.Add(New DataColumn("fec_ent", GetType(Date)))
        dt.Columns.Add(New DataColumn("nom_vend", GetType(String)))
        dt.Columns.Add(New DataColumn("cod_clie", GetType(String)))
        dt.Columns.Add(New DataColumn("nom_clie", GetType(String)))
        dt.Columns.Add(New DataColumn("raz_soc", GetType(String)))
        dt.Columns.Add(New DataColumn("dir_prov", GetType(String)))
        dt.Columns.Add(New DataColumn("dir_ent", GetType(String)))
        dt.Columns.Add(New DataColumn("nom_cont", GetType(String)))
        dt.Columns.Add(New DataColumn("nom_fpago", GetType(String)))
        dt.Columns.Add(New DataColumn("cod_alma", GetType(String)))
        dt.Columns.Add(New DataColumn("nom_alma", GetType(String)))
        dt.Columns.Add(New DataColumn("fono_clie", GetType(String)))
        dt.Columns.Add(New DataColumn("obs", GetType(String)))
        dt.Columns.Add(New DataColumn("cant", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("nom_art", GetType(String)))
        dt.Columns.Add(New DataColumn("saldo", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("precio", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("igv", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("afecto_igv", GetType(Boolean)))
        dt.Columns.Add(New DataColumn("pre_inc_igv", GetType(Boolean)))
        dt.Columns.Add(New DataColumn("comi_v", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("comi_jv", GetType(Decimal)))
        Return dt
    End Function
    Public Function recuperaCabecera(ByVal operacion As Integer) As DataTable
        Dim clConex As New MySqlConnection
        Dim da As New MySqlDataAdapter
        Dim ds As DataSet = pedido.dsPedido
        Dim dt As DataTable = ds.Tables("cabecera")
        clConex = Conexion.obtenerConexion
        Dim cad, cad1, cad2, cad3, cad4, cad5 As String
        cad1 = "select operacion,ser_ped,nro_ped,fec_ped,fec_ent,hor_ent,pedido.cod_vend,nom_vend,pedido.cod_clie,cod_alma,cod_area,cuenta,"
        cad2 = " cod_estado,cod_pedido,nom_clie,raz_soc,nom_cont,fono_clie,pedido.cod_fpago,pedido.dir_ent,obs,cod_tipo,tm,pre_inc_igv"
        cad3 = " from pedido inner join Cliente on pedido.cod_clie=cliente.cod_clie"
        cad4 = " inner join vendedor on pedido.cod_vend=vendedor.cod_vend"
        cad5 = " where operacion = " & operacion
        cad = cad1 + cad2 + cad3 + cad4 + cad5
        Dim com As New MySqlCommand(cad)
        com.Connection = clConex
        da.SelectCommand = com
        da.Fill(ds, "cabecera")
        clConex.Close()
        Return dt
    End Function
    Public Function recuperaDetalle(ByVal operacion As Integer, ByVal ser_ped As String, ByVal nro_ped As String, ByVal nroDecimales As Integer) As DataTable
        Dim clConex As New MySqlConnection
        Dim da As New MySqlDataAdapter
        Dim ds As DataSet = pedido.dsPedido
        Dim dt As DataTable = ds.Tables("detalle")
        clConex = Conexion.obtenerConexion
        Dim cad, cad1, cad2, cad3, cad4, cad5 As String
        cad1 = "select operacion,orden,pedido_det.cod_art,nom_art,nom_uni,saldo,cant as cantidad,pedido_det.obs,"
        If nroDecimales = 3 Then
            cad2 = "precio,round(cant*precio,3)as neto,igv,afecto_igv,comi_v,comi_jv,'Reg' as estado"
        Else
            cad2 = "precio,round(cant*precio,2)as neto,igv,afecto_igv,comi_v,comi_jv,'Reg' as estado"
        End If
        cad3 = " from pedido_det inner join articulo on pedido_det.cod_art=articulo.cod_art"
        cad4 = " inner join unidad on articulo.cod_uni=unidad.cod_uni"
        cad5 = " where operacion=" & operacion & " Order by nom_art"
        cad = cad1 + cad2 + cad3 + cad4 + cad5
        Dim com As New MySqlCommand(cad)
        com.Connection = clConex
        da.SelectCommand = com
        da.Fill(ds, "detalle")
        clConex.Close()
        Return dt
    End Function

    Public Function recuperaProduccion(fec_prod As Date, cod_alma As String, cod_area As String, nroDecimales As Integer) As DataTable
        Dim clConex As New MySqlConnection
        Dim da As New MySqlDataAdapter
        Dim ds As DataSet = pedido.dsPedido
        Dim dt As DataTable = ds.Tables("detalle")
        Dim mfecha1 As String = fec_prod.ToString("yyyy-MM-dd")
        clConex = Conexion.obtenerConexion
        Dim cad, cad1, cad2, cad3, cad4, cad5 As String
        cad1 = "select a.operacion,b.cod_art,nom_art,cod_uni as nom_uni,saldo,sum(cant) as cantidad,"
        If nroDecimales = 3 Then
            cad2 = "precio,round(cant*precio,3)as neto,igv,afecto_igv,comi_v,comi_jv,'Reg' as estado"
        Else
            cad2 = "precio,round(cant*precio,2)as neto,igv,afecto_igv,comi_v,comi_jv,'Reg' as estado"
        End If
        cad3 = " from salida a inner join salida_det b on a.operacion=b.operacion "
        cad4 = " inner join articulo on b.cod_art=articulo.cod_art"
        cad5 = " where a.cod_doc='93' and a.fec_doc='" & mfecha1 & "'" _
            & " and a.cod_alma='" & cod_alma & "'" _
            & " and a.cod_area='" & cod_area & "'" _
            & " group by cod_art Order by nom_art "
        cad = cad1 + cad2 + cad3 + cad4 + cad5
        Dim com As New MySqlCommand(cad)
        com.Connection = clConex
        da.SelectCommand = com
        da.Fill(ds, "detalle")
        clConex.Close()
        Return dt
    End Function

    Public Function recuperaPedidos(ByVal fec_inicio As Date, ByVal fec_final As Date) As DataTable
        Dim clConex As New MySqlConnection
        Dim da As New MySqlDataAdapter
        Dim ds As DataSet = pedido.dsPedido
        Dim dt As DataTable = ds.Tables("pedido")
        clConex = Conexion.obtenerConexion
        Dim cad, cad1, cad2, cad3, cad4, cad5, cad6 As String
        cad1 = "select operacion,ser_ped,nro_ped,fec_ped,fec_ent,pedido.cod_vend,nom_vend,pedido.cod_clie,"
        cad2 = " nom_clie,raz_soc,nom_cont,fono_clie,cod_fpago,pedido.dir_ent,obs,pre_inc_igv,pedido.cod_alma,nom_alma"
        cad3 = " from pedido inner join cliente on pedido.cod_clie=cliente.cod_clie"
        cad4 = " inner join vendedor on pedido.cod_vend=vendedor.cod_vend"
        cad5 = " inner join almacen on pedido.cod_alma=almacen.cod_alma"
        cad6 = " where fac=1"
        cad = cad1 + cad2 + cad3 + cad4 + cad5 + cad6
        Dim com As New MySqlCommand(cad)
        com.Connection = clConex
        da.SelectCommand = com
        da.Fill(ds, "pedido")
        clConex.Close()
        Return dt
    End Function
    Public Function recuperaPedidosFac(ByVal facturados As Boolean) As DataTable
        Dim clConex As New MySqlConnection
        Dim da As New MySqlDataAdapter
        Dim ds As DataSet = pedido.dsPedido
        Dim dt As DataTable = ds.Tables("pedido")
        clConex = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        Dim cad, cad1, cad2, cad3, cad4, cad5, cad6, cad7 As String
        cad1 = "select operacion,ser_ped,nro_ped,concat(ser_ped,'-',nro_ped)as pedido,fec_ped,fec_ent,"
        cad2 = " pedido.cod_vend,nom_vend,pedido.cod_clie,nom_clie,raz_soc,nom_cont,fono_clie,pedido.cod_fpago,pedido.cod_alma,nom_alma,"
        cad3 = " pedido.dir_ent,obs,pre_inc_igv"
        cad4 = " from pedido inner join cliente on pedido.cod_clie=cliente.cod_clie"
        cad5 = " inner join vendedor on pedido.cod_vend=vendedor.cod_vend"
        cad6 = " inner join almacen on pedido.cod_alma=almacen.cod_alma"
        If facturados Then
            cad7 = " where fac=1 order by ser_ped,nro_ped"
        Else
            cad7 = " where fac=0 order by ser_ped,nro_ped"
        End If
        cad = cad1 + cad2 + cad3 + cad4 + cad5 + cad6 + cad7
        com.CommandText = cad
        com.Connection = clConex
        da.SelectCommand = com
        da.Fill(dt)
        clConex.Close()
        Return dt
    End Function

    Public Function recupera_ordenCompra() As DataTable
        Dim clConex As New MySqlConnection
        Dim da As New MySqlDataAdapter
        Dim ds As DataSet = pedido.dsPedido
        Dim dt As DataTable = ds.Tables("pedido")
        clConex = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        Dim cad1, cad2, cad3, cad As String

        cad1 = "  select num_orden,sum(precio*cant) as importe from reservas r  " _
             & " inner join reservas_det rd on r.operacion=rd.operacion  "
        cad2 = " where LENGTH(num_orden)>0 and LENGTH(num_factura)=0 group by num_orden"
        cad3 = " order by  num_orden"
        cad = cad1 + cad2 + cad3
        com.CommandText = cad
        com.Connection = clConex
        da.SelectCommand = com
        da.Fill(dt)
        clConex.Close()
        Return dt
    End Function

    Public Function insertar(ByVal nro_ope As Integer,
                                ByVal ser_ped As String,
                                ByVal nro_ped As String,
                                ByVal fec_ped As Date,
                                ByVal fec_ent As Date,
                                ByVal hor_ent As Date,
                                ByVal cod_estado As String,
                                ByVal cod_pedido As String,
                                ByVal cod_vend As String,
                                ByVal cod_clie As String,
                                ByVal cod_fpago As String,
                                ByVal cod_almaO As String,
                                ByVal cod_alma As String,
                                ByVal cod_area As String,
                                ByVal dir_ent As String,
                                ByVal obs As String,
                                ByVal inc_igv As Integer,
                                ByVal tm As String,
                                ByVal usu_res As String,
                                 ByVal usu As String) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim sql As String, result As Integer
        Dim mfecha1 As String = fec_ped.ToString("yy-MM-dd")
        Dim mfecha2 As String = fec_ent.ToString("yy-MM-dd")
        Dim mfecha3 As String = hor_ent.ToString("HH:mm:ss")
        sql = "Insert Into pedido(operacion,ser_ped,nro_ped,fec_ped,fec_ent,hor_ent,cod_estado,cod_pedido,cod_vend,cod_clie,cod_fpago,cod_almaO,cod_alma,cod_area,dir_ent,obs,pre_inc_igv,tm,usu_ins,usu_mod,cuenta)" &
            "values(" &
            nro_ope & ",'" & ser_ped & "','" & nro_ped & "','" & mfecha1 & "','" & mfecha2 & "','" & mfecha3 & "','" & cod_estado & "','" & cod_pedido & "','" & cod_vend & "','" & cod_clie _
            & "','" & cod_fpago & "','" & cod_almaO & "','" & cod_alma & "','" & cod_area & "','" & dir_ent & "','" & obs & "'," & inc_igv & ",'" & tm & "','" & usu & "','" & usu & "','" & usu_res & "')"
        com.CommandText = sql
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function
    Public Function insertar_det(ByVal nro_ope As Integer,
                                    ByVal orden As Integer,
                                    ByVal cod_art As String,
                                    ByVal cant As Decimal,
                                    ByVal precio As Decimal,
                                    ByVal igv As Decimal,
                                    ByVal comi_v As Decimal,
                                    ByVal comi_jv As Decimal,
                                    ByVal usu As String,
                                    ByVal obs As String
                                    ) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim sql As String, result As Integer
        sql = "Insert Into pedido_det(operacion,orden,cod_art,cant,precio,igv,comi_v,comi_jv,usu_ins,usu_mod,obs)" &
            "values(" &
            nro_ope & "," & orden & ",'" & cod_art & "'," & cant & "," & precio & "," & igv & "," & comi_v & "," & comi_jv & ",'" & usu & "','" & usu & "','" & obs & "')"
        com.CommandText = sql
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function
    Public Function actualiza_detfoto(ByVal nro_ope As Integer,
                                    ByVal orden As Integer,
                                    ByVal imagen As Byte()) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim sql As String, result As Integer
        sql = "update pedido_det set foto = ?imagen where operacion= " & nro_ope & " and orden= " & orden
        com.CommandText = sql
        com.Parameters.AddWithValue("?imagen", imagen)
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function
    Public Function actualizafacturado(ByVal nro_ope As Integer, ByVal facturado As Boolean) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim result As Integer
        Dim cad, cad1, cad2 As String
        cad1 = "update pedido set fac=" & facturado & ", cod_estado='0002'"
        cad2 = " where operacion=" & nro_ope
        cad = cad1 + cad2
        com.CommandText = cad
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function
    Public Function actualiza_EstadoOrden(ByVal nro_ope As Integer) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim result As Integer
        Dim cad, cad1, cad2 As String
        cad1 = "update orden_compra set cod_estado='0002'"
        cad2 = " where operacion=" & nro_ope
        cad = cad1 + cad2
        com.CommandText = cad
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function

    Public Function actualizarnumFactura(ByVal num_orden As String, ByVal num_factura As String) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim cad, cad1, cad2 As String, result As Integer
        cad1 = "update reservas set num_factura = '" & num_factura & "'"
        cad2 = " where num_orden='" & num_orden & "'"

        cad = cad1 + cad2
        com.CommandText = cad
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function



    Public Function actualizaCabecera(ByVal nro_ope As Integer,
                            ByVal fec_ped As Date,
                            ByVal fec_ent As Date,
                            ByVal hor_ent As Date,
                            ByVal cod_pedido As String,
                            ByVal cod_vend As String,
                            ByVal cod_clie As String,
                            ByVal cod_fpago As String,
                            ByVal cod_alma As String,
                            ByVal cod_area As String,
                            ByVal dir_ent As String,
                            ByVal obs As String,
                            ByVal tm As String,
                            ByVal inc_igv As Integer,
                            ByVal usuario As String) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim result As Integer
        Dim mfecha1 As String = Microsoft.VisualBasic.Trim(fec_ped.ToString("yyyy-MM-dd"))
        Dim mfecha2 As String = Microsoft.VisualBasic.Trim(fec_ent.ToString("yyyy-MM-dd"))
        Dim mfecha3 As String = hor_ent.ToString("HH:mm:ss")
        Dim cad, cad1, cad2, cad3, cad4, cad5, cad6 As String
        cad1 = " update pedido set fec_ped='" & mfecha1 & "'," & "fec_ent='" & mfecha2 & "'," & "hor_ent='" & mfecha3 & "',"
        cad2 = " cod_vend='" & cod_vend & "'," & "cod_pedido='" & cod_pedido & "'," & "cod_clie='" & cod_clie & "',"
        cad3 = " cod_fpago='" & cod_fpago & "'," & "dir_ent='" & dir_ent & "',"
        cad4 = " cod_alma='" & cod_alma & "'," & "cod_area='" & cod_area & "'," & " usu_mod='" & usuario & "',"
        cad5 = " obs='" & obs & "'," & " tm='" & tm & "'," & "pre_inc_igv=" & inc_igv
        cad6 = " where operacion=" & nro_ope
        cad = cad1 + cad2 + cad3 + cad4 + cad5 + cad6
        com.CommandText = cad
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function
    Public Function actualizaDetalle(ByVal nro_ope As Integer,
                                 ByVal orden As Integer,
                                 ByVal cant As Decimal,
                                 ByVal precio As Decimal,
                                 ByVal igv As Decimal,
                                 ByVal comi_v As Decimal,
                                 ByVal comi_jv As Decimal,
                                 ByVal obs As String
                                 ) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim result As Integer
        Dim cad, cad1, cad2, cad3 As String
        cad1 = "update pedido_det set cant=" & cant & ",precio=" & precio & ",igv=" & igv
        cad2 = " ,comi_v=" & comi_v & ",comi_jv=" & comi_jv & ", obs='" & obs & "'"
        cad3 = " where operacion=" & nro_ope & " and orden=" & orden
        cad = cad1 + cad2 + cad3
        com.CommandText = cad
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function
    Public Function eliminaCabecera(ByVal ser_ped As String,
                                     ByVal doc_ped As String) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim sql As String, result As Integer
        sql = "delete from pedido where ser_ped='" & ser_ped & "' and nro_ped='" & doc_ped & "'"
        com.CommandText = sql
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function

    Public Function eliminaDetalle(ByVal nro_ope As Integer,
                                     ByVal orden As Integer) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim sql As String, result As Integer
        sql = "delete from pedido_det where operacion=" & nro_ope & " and orden=" & orden
        com.CommandText = sql
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function
    Public Function existe(ByVal ser_ped As String, ByVal nro_ped As String) As Integer
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer, sql As String
        com.Connection = clConex
        sql = "Select operacion from pedido where ser_ped='" & ser_ped & "'" & " and nro_ped='" & nro_ped & "'"
        com.CommandText = sql
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), False, obj), Integer)
        clConex.Close()
        Return result
    End Function

    Public Function existe_oc(ByVal ser_ped As String, ByVal nro_ped As String) As Integer
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer, sql As String
        com.Connection = clConex
        sql = "Select operacion from orden_compra where ser_doc='" & ser_ped & "'" & " and nro_doc='" & nro_ped & "'"
        com.CommandText = sql
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), False, obj), Integer)
        clConex.Close()
        Return result
    End Function
    Public Function facturado_oc(ByVal operacion As Integer) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer, sql As String
        com.Connection = clConex
        sql = "Select fac from orden_compra where operacion=" & operacion
        com.CommandText = sql
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Integer)
        clConex.Close()
        If result = 1 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function yaFacturado(ByVal operacion As Integer) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer, sql As String
        com.Connection = clConex
        sql = "Select fac from pedido where operacion=" & operacion
        com.CommandText = sql
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Integer)
        clConex.Close()
        If result > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function maxOperacion() As Integer
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer
        com.Connection = clConex
        com.CommandText = "select max(operacion) from pedido"
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Integer)
        clConex.Close()
        Return result + 1
    End Function
    Public Function maxOperacion_OC() As Integer
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer
        com.Connection = clConex
        com.CommandText = "select max(operacion) from orden_compra"
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Integer)
        clConex.Close()
        Return result + 1
    End Function

    Public Function maxOrden(ByVal nro_operacion As Integer) As Integer
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer
        com.Connection = clConex
        com.CommandText = "select max(orden) from pedido_det where operacion=" & nro_operacion
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Integer)
        clConex.Close()
        Return result + 1
    End Function
    Public Function devuelveFechaIngreso(ByVal ser_ped As String, ByVal nro_ped As String) As Date
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Date
        com.Connection = clConex
        Dim cad, cad1, cad2
        cad1 = "Select fecha from pedido"
        cad2 = " where ser_ped='" & ser_ped & "'" & " and nro_ped='" & nro_ped & "'"
        cad = cad1 + cad2
        com.CommandText = cad
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Date)
        clConex.Close()
        Return result
    End Function
    Public Function recuperaNrosPedido(ByVal cod_alma As String) As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim da As New MySqlDataAdapter
        Dim dsTrans As New DataSet
        Dim cad, cad1, cad2, cad3 As String
        cad1 = "select operacion,fec_ped as fec_doc,concat(ser_ped,'-',nro_ped) as doc,ser_ped as ser_doc,nro_ped as nro_doc"
        cad2 = " from pedido "
        cad3 = " where fac=0 " & IIf(cod_alma = "0000", "", " and cod_alma= '" & cod_alma & "'")
        cad = cad1 + cad2 + cad3
        Dim comTrans As New MySqlCommand(cad)
        comTrans.Connection = clConex
        da.SelectCommand = comTrans
        da.Fill(dsTrans, "nrosTransferencia")
        clConex.Close()
        Return dsTrans
    End Function

    Public Function recuperaNrosPedido_pendientes(ByVal cod_alma As String) As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim da As New MySqlDataAdapter
        Dim dsTrans As New DataSet
        Dim cad, cad1 As String
        'cad1 = " Select  ped2.operacion,ped2.ser_doc,ped2.nro_doc,concat(ped2.ser_doc,'-',ped2.nro_doc) as doc  from " _
        '& " (select ped.operacion,a.ser_doc,a.nro_doc,b.cod_art,sum(b.cant) as cant_rec,ped.cant as cant_ped" _
        '& " From salida a " _
        '& " inner Join salida_det b on a.operacion=b.operacion where espedido=1" _
        '& " inner Join " _
        '& " (select p1.operacion,p1.ser_ped,p1.nro_ped ,cod_art,cant" _
        '& " From pedido p1 inner Join pedido_det p2 on p1.operacion=p2.operacion ) ped" _
        '& " on ped.ser_ped = a.ser_doc And a.nro_doc=ped.nro_ped  And b.cod_art=ped.cod_art" _
        '& " group by a.ser_doc, a.nro_doc, b.cod_art" _
        '& " having ped.cant > sum(b.cant)) ped2" _
        '& " group by  ped2.ser_doc, ped2.nro_doc"

        cad1 = " Select a.operacion,a.ser_doc,a.nro_doc,concat(a.ser_doc,'-',a.nro_doc) as doc" _
        & " From salida a inner Join salida_det b on a.operacion=b.operacion " _
        & " Where esPendiente = 1 " _
        & " Group By a.ser_doc, a.nro_doc"

        cad = cad1
        Dim comTrans As New MySqlCommand(cad)
        comTrans.Connection = clConex
        da.SelectCommand = comTrans
        da.Fill(dsTrans, "nrosTransferencia")
        clConex.Close()
        Return dsTrans
    End Function

    Public Function recuperaOrdenC(ByVal nroOpe As Integer) As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim da As New MySqlDataAdapter
        Dim dsTrans As New DataSet
        Dim cad, cad1, cad2, cad3, cad4, cad5, cad6, cad7, cad10 As String

        cad1 = "select distinct a.operacion,b.ingreso as orden," _
                & "'Almacen Central' as origen,a.fec_doc," _
                & "concat(a.ser_doc,'-',a.nro_doc) as doc," _
                & "a.fec_doc as fec_ent,0 as salida "
        cad2 = " ,articulo.cod_art,nom_art,nom_uni,b.cant*cant_uni as cant,b.cant*cant_uni as cant_ped,b.precio/cant_uni as precio," _
                & "a.ser_doc,a.nro_doc,concat(almacenD.nom_alma,'-',nom_area) as destino "
        cad3 = " from orden_compra a inner join orden_compra_det b on a.operacion=b.operacion"
        cad4 = " inner join articulo on b.cod_art=articulo.cod_art"
        cad5 = " inner join unidad on b.cAux=unidad.cod_uni"
        cad6 = " inner join almacen as almacenD on a.cod_alma=almacenD.cod_alma"
        cad7 = " inner join area on area.cod_area=a.cod_area"
        cad10 = " where a.operacion=" & nroOpe _
                & " group by b.ingreso order by nom_art"
        cad = cad1 + cad2 + cad3 + cad4 + cad5 + cad6 + cad7 + cad10
        Dim comTrans As New MySqlCommand(cad)
        comTrans.Connection = clConex
        da.SelectCommand = comTrans
        da.Fill(dsTrans, "transferencia")
        clConex.Close()
        Return dsTrans
    End Function

    Public Function recuperaPedido(ByVal nroOpe As Integer) As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim da As New MySqlDataAdapter
        Dim dsTrans As New DataSet
        Dim cad, cad1, cad2, cad3, cad4, cad5, cad6, cad7, cad10 As String

        cad1 = "select distinct pedido.operacion,pedido_det.orden," _
                & "'Almacen Central' as origen,pedido.fec_ped as fec_doc," _
                & "concat(pedido.ser_ped,'-',pedido.nro_ped) as doc," _
                & "pedido.fec_ent,0 as salida,pedido.cuenta "
        cad2 = " ,articulo.cod_art,nom_art,nom_uni,pedido_det.cant,pedido_det.cant as cant_ped,aa.cant_stock,pedido_det.precio," _
                & "pedido.ser_ped as ser_doc,pedido.nro_ped as nro_doc,concat(almacenD.nom_alma,'-',nom_area) as destino "
        cad3 = " from pedido inner join pedido_det on pedido.operacion=pedido_det.operacion"
        cad4 = " inner join articulo on pedido_det.cod_art=articulo.cod_art"
        cad5 = " inner join unidad on articulo.cod_uni=unidad.cod_uni"
        cad6 = " inner join almacen as almacenD on pedido.cod_alma=almacenD.cod_alma" _
                & " left join art_almacen aa on aa.cod_alma=pedido.cod_almaO and pedido_det.cod_art=aa.cod_art "
        cad7 = " inner join area on area.cod_area=pedido.cod_area"
        cad10 = " where pedido.operacion=" & nroOpe _
                & " group by pedido_det.orden order by nom_art"
        cad = cad1 + cad2 + cad3 + cad4 + cad5 + cad6 + cad7 + cad10
        Dim comTrans As New MySqlCommand(cad)
        comTrans.Connection = clConex
        da.SelectCommand = comTrans
        da.Fill(dsTrans, "transferencia")
        clConex.Close()
        Return dsTrans
    End Function


    Public Function recuperaPedidoPend(ByVal nroOpe As Integer) As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim da As New MySqlDataAdapter
        Dim dsTrans As New DataSet
        Dim cad, cad1 As String

        cad1 = " Select s.operacion,b.salida,s.ser_doc,s.nro_doc,s.fec_doc,'Almacen Central' as origen ,cuenta " _
        & " ,concat(s.ser_doc,'-',s.nro_doc) as doc,a.cod_art, a.cod_uni As nom_uni, a.nom_art, b.precio, cant_ped-cant As cant,cant_ped-cant as cant_ped " _
        & " From salida s inner Join salida_det b on s.operacion=b.operacion " _
        & " inner Join articulo a on a.cod_art=b.cod_art " _
        & " where espendiente=1 and s.operacion =" & nroOpe

        cad = cad1
        Dim comTrans As New MySqlCommand(cad)
        comTrans.Connection = clConex
        da.SelectCommand = comTrans
        da.Fill(dsTrans, "transferencia")
        clConex.Close()
        Return dsTrans
    End Function

    Public Function recuperaAlmacenTrans_dest(ByVal esHistorial As Boolean, ByVal ser_doc As String, ByVal nro_doc As String) As String
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As String, cad, cad1, cad2, cad3 As String
        com.Connection = clConex

        cad1 = "Select cod_alma"
        cad2 = IIf(esHistorial, " from h_pedido", " from pedido ")
        cad3 = " where  ser_ped='" & ser_doc & "' and nro_ped='" & nro_doc & "'"
        cad = cad1 + cad2 + cad3
        com.CommandText = cad
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), "00A0", obj), String)
        clConex.Close()
        Return result
    End Function
    Public Function recuperaAreaTrans_dest(ByVal esHistorial As Boolean, ByVal ser_doc As String, ByVal nro_doc As String) As String
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As String, cad, cad1, cad2, cad3 As String
        com.Connection = clConex
        cad1 = "select cod_area"
        cad2 = IIf(esHistorial, " from h_pedido ", " from pedido")
        cad3 = " where ser_ped='" & ser_doc & "' and nro_ped='" & nro_doc & "'"
        cad = cad1 + cad2 + cad3
        com.CommandText = cad
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), "0000", obj), String)
        clConex.Close()
        Return result
    End Function

    Public Function recuperaObservacion(ByVal ser_doc As String, ByVal nro_doc As String) As String
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As String, cad, cad1, cad2, cad3 As String
        com.Connection = clConex

        cad1 = "select obs"
        cad2 = " from pedido "
        cad3 = " where ser_ped='" & ser_doc & "' and nro_ped='" & nro_doc & "'"
        cad = cad1 + cad2 + cad3
        com.CommandText = cad
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), "", obj), String)
        clConex.Close()
        Return result
    End Function



    Public Function recupera_rucProveedor(ByVal operacion As Integer) As String
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As String, cad, cad1, cad3 As String
        com.Connection = clConex

        cad1 = "select cod_prov from orden_compra "
        cad3 = " where operacion =" & operacion
        cad = cad1 + cad3
        com.CommandText = cad
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), "", obj), String)
        clConex.Close()
        Return result
    End Function


End Class
