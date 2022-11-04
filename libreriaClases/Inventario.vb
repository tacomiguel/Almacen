Imports libreriaClases
Imports MySql.Data.MySqlClient
Public Class Inventario
    Public Shared Function dsInventario() As DataSet
        Dim ds As New DataSet
        ds.Tables.Add(crearTablaInventario())
        Return ds
    End Function
    Public Shared Function dsInventarioDiario() As DataSet
        Dim ds As New DataSet
        ds.Tables.Add(crearTablaInventarioDiario())
        Return ds
    End Function
    Public Shared Function dsInventarioMensual() As DataSet
        Dim ds As New DataSet
        ds.Tables.Add(crearTablaInventarioMensual())
        Return ds
    End Function
    Public Shared Function dsInventarioMensualReportes() As DataSet
        Dim ds As New DataSet
        ds.Tables.Add(crearTablaInventarioMensualReportes())
        Return ds
    End Function
    Private Shared Function crearTablaInventario() As DataTable
        Dim dt As New DataTable("inventario")
        dt.Columns.Add(New DataColumn("nro_inv", GetType(Integer)))
        dt.Columns.Add(New DataColumn("cod_inv", GetType(String)))
        dt.Columns.Add(New DataColumn("fec_inv", GetType(String)))
        dt.Columns.Add(New DataColumn("ingreso", GetType(Integer)))
        dt.Columns.Add(New DataColumn("operacion", GetType(Integer)))
        dt.Columns.Add(New DataColumn("cod_art", GetType(String)))
        dt.Columns.Add(New DataColumn("nom_art", GetType(String)))
        dt.Columns.Add(New DataColumn("nom_uni", GetType(String)))
        dt.Columns.Add(New DataColumn("cant_sis", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("cant_fis", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("precio", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("cod_sgrupo", GetType(String)))
        dt.Columns.Add(New DataColumn("nom_sgrupo", GetType(String)))
        dt.Columns.Add(New DataColumn("cod_alma", GetType(String)))
        dt.Columns.Add(New DataColumn("nom_alma", GetType(String)))
        dt.Columns.Add(New DataColumn("esProduccion", GetType(Boolean)))
        Return dt
    End Function
    Private Shared Function crearTablaInventarioDiario() As DataTable
        Dim dt As New DataTable("inventario")
        dt.Columns.Add(New DataColumn("nro_inv", GetType(Integer)))
        dt.Columns.Add(New DataColumn("cod_inv", GetType(String)))
        dt.Columns.Add(New DataColumn("fec_inv", GetType(String)))
        dt.Columns.Add(New DataColumn("inventario", GetType(String)))
        dt.Columns.Add(New DataColumn("cod_art", GetType(String)))
        dt.Columns.Add(New DataColumn("nom_art", GetType(String)))
        dt.Columns.Add(New DataColumn("nom_uni", GetType(String)))
        dt.Columns.Add(New DataColumn("inicial", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("ingresos", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("bajas", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("salidas", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("otros", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("total", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("fisico", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("diferencia", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("pre_costo", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("afecto_igv", GetType(Boolean)))
        Return dt
    End Function
    Private Shared Function crearTablaInventarioMensual() As DataTable
        Dim dt As New DataTable("inventario")
        dt.Columns.Add(New DataColumn("nro_inv", GetType(Integer)))
        dt.Columns.Add(New DataColumn("cod_inv", GetType(String)))
        dt.Columns.Add(New DataColumn("fec_inv", GetType(String)))
        dt.Columns.Add(New DataColumn("inventario", GetType(String)))
        dt.Columns.Add(New DataColumn("cod_art", GetType(String)))
        dt.Columns.Add(New DataColumn("nom_art", GetType(String)))
        dt.Columns.Add(New DataColumn("nom_uni", GetType(String)))
        dt.Columns.Add(New DataColumn("cant_sis", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("cant_fis", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("pre_costo", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("cod_alma", GetType(String)))
        dt.Columns.Add(New DataColumn("nom_alma", GetType(String)))
        Return dt
    End Function
    Private Shared Function crearTablaInventarioMensualReportes() As DataTable
        Dim dt As New DataTable("inventario")
        dt.Columns.Add(New DataColumn("nro_inv", GetType(Integer)))
        dt.Columns.Add(New DataColumn("cod_inv", GetType(String)))
        dt.Columns.Add(New DataColumn("fec_inv", GetType(String)))
        dt.Columns.Add(New DataColumn("inventario", GetType(String)))
        dt.Columns.Add(New DataColumn("cod_art", GetType(String)))
        dt.Columns.Add(New DataColumn("nom_art", GetType(String)))
        dt.Columns.Add(New DataColumn("nom_uni", GetType(String)))
        dt.Columns.Add(New DataColumn("inicial", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("bajas", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("ingresos", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("ventas", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("salidas", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("Cocina", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("Bar", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("personal", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("eventos", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("otros", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("sistema", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("fisico", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("costo_fis", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("diferencia", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("cant_sis", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("cant_fis", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("precio", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("pre_costo", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("afecto_igv", GetType(Boolean)))
        dt.Columns.Add(New DataColumn("cod_sgrupo", GetType(String)))
        dt.Columns.Add(New DataColumn("nom_sgrupo", GetType(String)))
        dt.Columns.Add(New DataColumn("cod_alma", GetType(String)))
        dt.Columns.Add(New DataColumn("nom_alma", GetType(String)))
        Return dt
    End Function
    Public Function recuperaArticulosParaInventarioDiario() As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim da As New MySqlDataAdapter
        Dim dsInventarioDiario As New DataSet
        Dim cad, cad1, cad2, cad3 As String
        cad1 = "select cod_art,nom_art,nom_uni,pre_costo,afecto_igv"
        cad2 = " from articulo inner join unidad on articulo.cod_uni=unidad.cod_uni"
        cad3 = " where inv_diario=1 and articulo.activo=1 order by nom_art"
        cad = cad1 + cad2 + cad3
        Dim comArt As New MySqlCommand(cad)
        comArt.Connection = clConex
        da.SelectCommand = comArt
        da.Fill(dsInventarioDiario, "inv_diario")
        clConex.Close()
        Return dsInventarioDiario
    End Function
    Public Function recuperaFormatosInvMensual(ByVal cod_alma As String, ByVal cod_area As String, ByVal esAlmaPrincipal As Boolean) As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim da As New MySqlDataAdapter
        Dim ds As New DataSet
        Dim cad, cad1, cad2, cad3, cad4, cad5, cad6 As String
        cad1 = "select articulo.cod_sgrupo,articulo.cod_art,articulo.nom_art,nom_uni,nom_sgrupo"
        cad2 = " from (formato_inv inner join formato_inv_det on formato_inv.codigo=formato_inv_det.codigo"
        cad3 = " inner join articulo on articulo.cod_sgrupo=formato_inv_det.cod_sgrupo)"
        If esAlmaPrincipal Then
            cad4 = " inner join unidad on articulo.cod_uni=unidad.cod_uni inner join subgrupo on articulo.cod_sgrupo=subgrupo.cod_sgrupo"
        Else
            cad4 = " left join varticulosrel on articulo.cod_art=varticulosrel.cod_artR"
        End If
        cad5 = " where formato_inv.cod_alma ='" & cod_alma & "' And articulo.cod_alma = '" _
                & cod_alma & "' And formato_inv.cod_area = '" & cod_area & "' and articulo.activo=1"
        cad6 = " order by articulo.nom_art"
        cad = cad1 + cad2 + cad3 + cad4 + cad5 + cad6
        Dim com As New MySqlCommand(cad)
        com.Connection = clConex
        da.SelectCommand = com
        da.Fill(ds, "inventario")
        clConex.Close()
        Return ds
    End Function
    Public Function recuperaFormatosInvInicial(ByVal xAlma As Boolean, ByVal cod_alma As String, ByVal xArea As Boolean, ByVal cod_area As String, ByVal esAlmaPrincipal As Boolean) As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim da As New MySqlDataAdapter
        Dim ds As New DataSet
        Dim cad, cad1, cad2, cad3, cad4, cad5, cad6, cad7 As String
        cad1 = "select articulo.cod_sgrupo,articulo.cod_art,articulo.nom_art,nom_uni,nom_sgrupo"
        cad2 = " from ingreso inner join ingreso_det on ingreso.operacion=ingreso_det.operacion"
        cad3 = " inner join articulo on articulo.cod_art=ingreso_det.cod_art "
        cad4 = " inner join unidad on articulo.cod_uni=unidad.cod_uni inner join subgrupo on articulo.cod_sgrupo=subgrupo.cod_sgrupo"
        cad5 = " where ingreso.cod_doc='10' "
        cad6 = IIf(xAlma, " and ingreso.cod_alma ='" & cod_alma & "'", "") _
                 & IIf(xArea, " And ingreso.cod_area = '" & cod_area & "'", "") _
                 & " and articulo.activo=1"
        cad7 = " order by articulo.nom_art"
        cad = cad1 + cad2 + cad3 + cad4 + cad5 + cad6 + cad7
        Dim com As New MySqlCommand(cad)
        com.Connection = clConex
        da.SelectCommand = com
        da.Fill(ds, "inventario")
        clConex.Close()
        Return ds
    End Function
    Public Function recInvMensual(ByVal esHistorial As Boolean, ByVal periodo As String, ByVal xAlmacen As Boolean, ByVal cod_alma As String,
                    ByVal xArea As Boolean, ByVal cod_area As String, ByVal paraReporte As Boolean) As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim da As New MySqlDataAdapter
        Dim ds As New DataSet
        Dim nAnno As Integer = Left(periodo, 4)
        Dim nMes As Integer = Right(periodo, 2)
        Dim cad, cad1, cad2, cad3, cad4, cad5, cad6, cad7, cad8 As String
        cad1 = "select hd.cod_art,nom_art,nom_uni,hd.pre_costo," _
                & "cant_sis,cant_fis,inventario,fec_inv," _
                & "articulo.cod_sgrupo,nom_sgrupo,almacen.cod_alma,nom_alma"
        cad2 = IIf(esHistorial, " from h_inventario as h inner join h_inventario_det as hd on h.operacion=hd.operacion",
            " from inventario_m as h inner join inventario_mdet as hd on h.operacion=hd.operacion")
        cad3 = " inner join articulo on  hd.cod_art=articulo.cod_art"
        cad4 = " inner join unidad on articulo.cod_uni=unidad.cod_uni "
        cad5 = " inner join almacen on h.cod_alma=almacen.cod_alma"
        cad6 = IIf(xArea, " inner join area on almacen.cod_alma=area.cod_alma", "") _
                & " inner join subgrupo on articulo.cod_sgrupo=subgrupo.cod_sgrupo"
        cad7 = IIf(esHistorial, " where h.proceso='" & periodo & "' and hd.proceso='" & periodo & "'",
                " where year(fec_inv) =" & nAnno & " and month(fec_inv)=" & nMes) _
                & " and articulo.activo=1 " _
                & IIf(xAlmacen, " and h.cod_alma='" & cod_alma & "'", "") _
                & IIf(xArea, " and h.cod_area='" & cod_area & "'", "") _
                & IIf(paraReporte, " and subgrupo.repInventario=1", "")
        cad8 = " order by nom_art"
        cad = cad1 + cad2 + cad3 + cad4 + cad5 + cad6 + cad7 + cad8
        Dim com As New MySqlCommand(cad)
        com.Connection = clConex
        da.SelectCommand = com
        da.Fill(ds, "inventario")
        clConex.Close()
        Return ds
    End Function



    Public Function recuperaInventarioMensualResumen(ByVal fechaInv As Date) As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim da As New MySqlDataAdapter
        Dim ds As New DataSet
        Dim mfecha As String = fechaInv.ToString("yy-MM-dd")
        Dim cad, cad1, cad2, cad3, cad4, cad5, cad6 As String
        cad1 = "select inventario_mdet.cod_art,nom_art,nom_uni,inventario_mdet.pre_costo,cant_sis,cant_fis,inventario,fec_inv,articulo.cod_sgrupo,nom_sgrupo"
        cad2 = " from inventario_m inner join inventario_mdet on inventario_m.operacion=inventario_mdet.operacion"
        cad3 = " inner join articulo on  inventario_mdet.cod_art=articulo.cod_art"
        cad4 = " inner join unidad on articulo.cod_uni=unidad.cod_uni"
        cad5 = " inner join subgrupo on articulo.cod_sgrupo=subgrupo.cod_sgrupo"
        cad6 = " where cod_inv=12 and fec_inv='" & mfecha & "'" & " group by cod_art order by nom_art"
        cad = cad1 + cad2 + cad3 + cad4 + cad5 + cad6
        Dim comArt As New MySqlCommand(cad)
        comArt.Connection = clConex
        da.SelectCommand = comArt
        da.Fill(ds, "inventario")
        clConex.Close()
        Return ds
    End Function
    Public Function recuperaInventarioCrostabResumen(ByVal fechaInv As Date) As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim da As New MySqlDataAdapter
        Dim dsCrosstab As New DataSet
        Dim mfecha As String = fechaInv.ToString("yy-MM-dd")
        Dim cad, cad1, cad2, cad3, cad4, cad5, cad6, cad7 As String
        cad1 = "select am.nom_alma as columna,s.cod_sgrupo as codfila,s.nom_sgrupo as nomfila,sum(imd.cant_fis*imd.pre_costo) as totales "
        cad2 = "from inventario_m im inner join inventario_mdet imd on im.operacion=imd.operacion "
        cad3 = "inner join articulo a on imd.cod_art=a.cod_art "
        cad4 = "inner join almacen am on im.cod_alma=am.cod_alma "
        cad5 = "inner join subgrupo s on a.cod_sgrupo =s.cod_sgrupo "
        cad6 = "where fec_inv='" & mfecha & "' and s.activo and escatalogo "
        cad7 = "group by columna,codfila order by  columna,codfila "
        cad = cad1 + cad2 + cad3 + cad4 + cad5 + cad6 + cad7
        Dim comArt As New MySqlCommand(cad)
        comArt.Connection = clConex
        da.SelectCommand = comArt
        da.Fill(dsCrosstab, "tabla")
        clConex.Close()
        Return dsCrosstab
    End Function
    Public Function recuperaInventarioPermanente(ByVal cod_alma As String, ByVal fechaInv As Date) As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim da As New MySqlDataAdapter
        Dim ds As New DataSet
        Dim mfecha As String = fechaInv.ToString("yy-MM-dd")
        Dim cad, cad1, cad2, cad3, cad4, cad5, cad6, cad7, cad8, cadx As String
        cad1 = " select a.fec_inv,a.cod_alma,b.cod_art,ar.nom_art,u.nom_uni,b.pre_costo,sum(b.cant_fis*b.pre_costo) as valor, (sum(b.cant_fis*b.pre_costo)/b.pre_costo) as cant_fis, "
        cad2 = " nom_sgrupo"
        cadx = ",if(a.cod_alma='0001',b.cod_art, (select  max(cod_art) from art_relaalmacenes where cod_artAlma=b.cod_art and cod_alma=a.cod_alma) ) as codigo ,(select nom_sgrupo from subgrupo where cod_sgrupo=(select cod_sgrupo from articulo where cod_art=codigo)) as nom_sgrupo"
        cad3 = " from inventario_m a "
        cad4 = " inner join inventario_mdet b on a.operacion=b.operacion "
        cad5 = " inner join articulo ar on ar.cod_art=b.cod_art inner join subgrupo sg on sg.cod_sgrupo=ar.cod_sgrupo "
        cad6 = " inner join almacen al on a.cod_alma=al.cod_alma "
        cad7 = " inner join unidad u on u.cod_uni=ar.cod_uni "
        cad8 = " where a.cod_alma= '" & cod_alma & "' and fec_inv='" & mfecha & "' and escatalogo group by b.cod_art having valor >0 order by nom_sgrupo"
        cad = cad1 + cad2 + cad3 + cad4 + cad5 + cad6 + cad7 + cad8
        Dim comArt As New MySqlCommand(cad)
        comArt.Connection = clConex
        da.SelectCommand = comArt
        da.Fill(ds, "Inventario")
        clConex.Close()
        Return ds
    End Function

    Public Function insertar_invDiario(ByVal operacion As Integer,
                        ByVal fec_inv As Date,
                        ByVal nro_dec As Integer,
                        ByVal cod_alma As String,
                        ByVal cod_area As String,
                        ByVal usuario As String) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim cod_inv As String = "11"
        Dim sql As String, result As Integer
        Dim mfecha As String = fec_inv.ToString("yy-MM-dd")
        sql = "Insert Into inventario_d(operacion,cod_inv,fec_inv,nro_dec,cod_alma,cuenta)" &
            "values(" &
            operacion & ",'" & cod_inv & "','" & mfecha & "'," & nro_dec & ",'" & cod_alma & "','" & usuario & "')"
        com.CommandText = sql
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function
    Public Function insertar_invMensual(ByVal operacion As Integer,
                    ByVal fec_inv As Date,
                    ByVal nro_dec As Integer,
                    ByVal cod_alma As String,
                    ByVal cod_area As String,
                    ByVal usuario As String) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim cod_inv As String = "12"
        Dim sql As String, result As Integer
        Dim mfecha As String = fec_inv.ToString("yy-MM-dd")
        sql = "Insert Into inventario_m(operacion,cod_inv,fec_inv,nro_dec,cod_alma,cod_area,cuenta)" &
            "values(" &
            operacion & ",'" & cod_inv & "','" & mfecha & "'," & nro_dec & ",'" & cod_alma & "','" & cod_area & "','" & usuario & "')"
        com.CommandText = sql
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function
    Public Function insertar_conteo(ByVal operacion As Integer,
                ByVal proceso As String,
                ByVal cod_alma As String,
                ByVal cod_area As String) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim cad As String, result As Integer
        cad = "Insert Into conteo(operacion,proceso,cod_alma,cod_area)" &
            "values(" &
            operacion & ",'" & proceso & "','" & cod_alma & "','" & cod_area & "')"
        com.CommandText = cad
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function
    Public Function insertar_conteo_det(ByVal operacion As Integer,
            ByVal conteo As Integer,
            ByVal cod_art As String) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim cad As String, result As Integer
        cad = "Insert Into conteo_det(operacion,conteo,cod_art)" &
            "values(" &
            operacion & "," & conteo & ",'" & cod_art & "')"
        com.CommandText = cad
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function
    Public Function insertar_detInvDiario(ByVal operacion As Integer,
                                ByVal inventario As Integer,
                                ByVal cod_art As String,
                                ByVal cant_sis As Decimal,
                                ByVal cant_fis As Decimal,
                                ByVal diferencia As Decimal,
                                ByVal pre_costo As Decimal,
                                ByVal cuenta As String) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim sql As String, result As Integer
        sql = "Insert Into inventario_ddet(operacion,inventario,cod_art,cant_sis,cant_fis,dif,pre_costo,cuenta)" &
            "values(" &
            operacion & "," & inventario & ",'" & cod_art & "'," & cant_sis & "," & cant_fis & "," & diferencia & "," & pre_costo & ",'" & cuenta & "')"
        com.CommandText = sql
        com.CommandTimeout = 300
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function
    Public Function insertar_detInvMensual(ByVal operacion As Integer,
                            ByVal inventario As Integer,
                            ByVal cod_art As String,
                            ByVal cant_sis As Decimal,
                            ByVal cant_fis As Decimal,
                            ByVal pre_costo As Decimal,
                            ByVal cuenta As String) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim sql As String, result As Integer
        sql = "Insert Into inventario_mdet(operacion,inventario,cod_art,cant_sis,cant_fis,pre_costo,cuenta)" &
            "values(" &
            operacion & "," & inventario & ",'" & cod_art & "'," & cant_sis & "," & cant_fis & "," & pre_costo & ",'" & cuenta & "')"
        com.CommandText = sql
        com.CommandTimeout = 300
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function
    Public Function actualizaFisicoDiario(ByVal nroInventario As Integer,
                         ByVal cant As Decimal) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim result As Integer
        Dim cad, cad1, cad2 As String
        cad1 = "update inventario_ddet set cant_fis=" & cant
        cad2 = " where inventario=" & nroInventario
        cad = cad1 + cad2
        com.CommandText = cad
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function
    Public Function actualizaDiferenciaDiario(ByVal nroInventario As Integer,
                     ByVal dif As Decimal) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim result As Integer
        Dim cad, cad1, cad2 As String
        cad1 = "update inventario_ddet set dif=" & dif
        cad2 = " where inventario=" & nroInventario
        cad = cad1 + cad2
        com.CommandText = cad
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function
    Public Function actualizaFisicoMensual(ByVal nroInventario As Integer,
                     ByVal cant As Decimal) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim result As Integer
        Dim cad, cad1, cad2 As String
        cad1 = "update inventario_mdet set cant_fis=" & cant
        cad2 = " where inventario=" & nroInventario
        cad = cad1 + cad2
        com.CommandText = cad
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function
    Public Function eliminainventarioDiario(ByVal fec_inv As Date, ByVal cod_alma As String) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        Dim mfecha As String = fec_inv.ToString("yy-MM-dd")
        com.Connection = clConex
        Dim sql As String, result As Integer
        sql = "delete from inventario_d where fec_inv= '" & mfecha & "' and cod_alma='" & cod_alma & "'"
        com.CommandText = sql
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function

    Public Function eliminaDetalleMensual(ByVal nroInventario As Integer) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim sql As String, result As Integer
        sql = "delete from inventario_mdet where inventario=" & nroInventario
        com.CommandText = sql
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function
    Public Function maxOperacionDiario() As Integer
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer
        com.Connection = clConex
        com.CommandText = "select max(operacion) from inventario_d"
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Integer)
        clConex.Close()
        Return result + 1
    End Function
    Public Function maxOperacionMensual() As Integer
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer
        com.Connection = clConex
        com.CommandText = "select max(operacion) from inventario_m"
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Integer)
        clConex.Close()
        Return result + 1
    End Function
    Public Function maxInventarioDiario() As Integer
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer
        com.Connection = clConex
        com.CommandText = "select max(inventario) from inventario_ddet"
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Integer)
        clConex.Close()
        Return result + 1
    End Function
    Public Function maxInventarioMensual() As Integer
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer
        com.Connection = clConex
        com.CommandText = "select max(inventario) from inventario_mdet"
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Integer)
        clConex.Close()
        Return result + 1
    End Function
    Public Function devOperacionMensual(ByVal periodo As String, ByVal cod_alma As String,
                        ByVal xArea As Boolean, ByVal cod_area As String) As Integer
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer, cad As String
        com.Connection = clConex
        Dim nAnno As Integer = Left(periodo, 4)
        Dim nMes As Integer = Right(periodo, 2)
        cad = "Select operacion from inventario_m where cod_alma='" & cod_alma & "'" _
                & IIf(xArea, " and cod_area='" & cod_area & "'", "") _
                & " and year(fec_inv)=" & nAnno & " and month(fec_inv)=" & nMes
        com.CommandText = cad
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Integer)
        clConex.Close()
        Return result
    End Function
    Public Function maxOperacionConteo() As Integer
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer
        com.Connection = clConex
        com.CommandText = "select max(operacion) from conteo"
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Integer)
        clConex.Close()
        Return result + 1
    End Function
    Public Function mensual_esHistorial(ByVal periodo As String) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer, cad As String
        com.Connection = clConex
        Dim nAnno As Integer = Left(periodo, 4)
        Dim nMes As Integer = Right(periodo, 2)
        cad = "Select count(operacion) from inventario_m" _
                & " where year(fec_inv)=" & nAnno & " and month(fec_inv)=" & nMes
        com.CommandText = cad
        result = com.ExecuteScalar
        If result > 0 Then
            Return False
        Else
            Return True
        End If
        clConex.Close()
    End Function

    Public Function mensual_esArea(ByVal esHistorial As Boolean, ByVal periodo As String,
            ByVal empresa As String, ByVal cod_alma As String) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer, cad As String
        com.Connection = clConex
        cad = "Select count(operacion)" _
                & IIf(esHistorial, " from h_inventario as h inner join almacen on h.cod_alma=almacen.cod_alma",
                    " from inventario_m as h inner join almacen on h.cod_alma=almacen.cod_alma") _
                & " where almacen.cod_emp='" & empresa & "'" _
                & " and h.cod_alma='" & cod_alma & "'" _
                & " and h.cod_area<>'0000'"
        com.CommandText = cad
        result = com.ExecuteScalar
        If result > 0 Then
            Return True
        Else
            Return False
        End If
        clConex.Close()
    End Function
    Public Function existMensual(ByVal esHistorial As Boolean, ByVal periodo As String, ByVal empresa As String,
                ByVal cod_alma As String, ByVal xArea As Boolean, ByVal cod_area As String) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer, cad As String
        com.Connection = clConex
        cad = "Select count(operacion)" _
                & IIf(esHistorial, " from h_inventario as h inner join almacen on h.cod_alma=almacen.cod_alma",
                    " from inventario_m as h inner join almacen on h.cod_alma=almacen.cod_alma") _
                & " where almacen.cod_emp='" & empresa & "'" _
                & " and h.cod_alma='" & cod_alma & "'" _
                & IIf(xArea, " and h.cod_area='" & cod_area & "'", "")
        com.CommandText = cad
        result = com.ExecuteScalar
        If result > 0 Then
            Return True
        Else
            Return False
        End If
        clConex.Close()
    End Function
    Public Function actConteo(ByVal conteo As Integer,
                     ByVal cant As Decimal, ByVal dia As String) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim result As Integer
        Dim cad, cad1, cad2 As String
        cad1 = "update conteo_det set " & dia & "=" & cant
        cad2 = " where conteo=" & conteo
        cad = cad1 + cad2
        com.CommandText = cad
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function
    Public Function maxConteo() As Integer
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer
        com.Connection = clConex
        com.CommandText = "select max(conteo) from conteo_det"
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Integer)
        clConex.Close()
        Return result + 1
    End Function
    Public Function existConteo(ByVal proceso As String, ByVal cod_alma As String, ByVal cod_area As String) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer, cad As String
        com.Connection = clConex
        cad = "Select count(operacion) from conteo where proceso='" & proceso _
            & "' and cod_alma='" & cod_alma & "' and cod_area='" & cod_area & "'"
        com.CommandText = cad
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Integer)
        If result > 0 Then
            Return True
        Else
            Return False
        End If
        clConex.Close()
    End Function
    Public Function recConteo(ByVal esHistorial As Boolean, ByVal nroProceso As String, ByVal esMensual As Boolean,
                    ByVal fechaI As Date, ByVal fechaF As Date, ByVal cod_alma As String,
                    ByVal xArea As Boolean, ByVal cod_area As String, ByVal xGrupo As Boolean,
                    ByVal cod_sgrupo As String) As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim da As New MySqlDataAdapter
        Dim ds As New DataSet
        Dim mfechaI As String = fechaI.ToString("yy-MM-dd")
        Dim mfechaF As String = fechaF.ToString("yy-MM-dd")
        Dim cad, cad1, cad2, cad3, cad4, cad5 As String
        cad1 = "select h.operacion,conteo,hd.cod_art,nom_art,nom_uni,es_botella,peso_lleno,peso_vacio," _
                & "d1,d2,d3,d4,d5,d6,d7,d8,d9,d10," _
                & "d11,d12,d13,d14,d15,d16,d17,d18,d19,d20,d21,d22,d23,d24,d25,d26,d27,d28,d29,d30,d31"
        If esHistorial Then
            cad2 = " from h_conteo as h inner join h_conteo_det as hd on h.operacion=hd.operacion"
        Else
            cad2 = " from conteo as h inner join conteo_det as hd on h.operacion=hd.operacion"
        End If
        cad3 = " inner join articulo on  hd.cod_art=articulo.cod_art"
        cad4 = " inner join unidad on articulo.cod_uni=unidad.cod_uni"
        cad5 = " where h.cod_alma='" & cod_alma & "' and h.cod_area='" & cod_area & "'" _
                & IIf(esHistorial, " and h.proceso='" & nroProceso & "'", "") _
                & IIf(esMensual, "", " and fec_inv>='" & mfechaI & "' and fec_inv<='" & mfechaF & "'") _
                & IIf(xGrupo, " and articulo.cod_sgrupo='" & cod_sgrupo & "'", "") _
                & IIf(xArea, " and h.cod_area='" & cod_area & "'", "") _
                & " order by nom_art"
        cad = cad1 + cad2 + cad3 + cad4 + cad5
        Dim com As New MySqlCommand(cad)
        com.Connection = clConex
        da.SelectCommand = com
        da.Fill(ds, "conteo")
        clConex.Close()
        Return ds
    End Function
    Public Function recDiario(ByVal esHistorial As Boolean, ByVal nroProceso As String, ByVal esMensual As Boolean,
                        ByVal fechaI As Date, ByVal fechaF As Date, ByVal xAlmacen As Boolean, ByVal cod_alma As String,
                        ByVal xGrupo As Boolean, ByVal cod_sgrupo As String) As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim da As New MySqlDataAdapter
        Dim ds As New DataSet
        Dim mfechaI As String = fechaI.ToString("yy-MM-dd")
        Dim mfechaF As String = fechaF.ToString("yy-MM-dd")
        Dim cad, cad1, cad2, cad3, cad4, cad5, cad6 As String
        cad1 = "select hd.cod_art,nom_art,nom_uni,hd.pre_costo," _
                & "sum(cant_sis) as cant_sis,cant_fis,dif,inventario"
        If esHistorial Then
            cad2 = " from h_inventario_d as h inner join h_inventario_ddet as hd on h.operacion=hd.operacion"
        Else
            cad2 = " from inventario_d as h inner join inventario_ddet as hd on h.operacion=hd.operacion"
        End If
        cad3 = " inner join articulo on  hd.cod_art=articulo.cod_art"
        cad4 = " inner join unidad on articulo.cod_uni=unidad.cod_uni"
        cad5 = " inner join subgrupo on articulo.cod_sgrupo=subgrupo.cod_sgrupo"
        cad6 = " where inv_diario=1 " _
                & IIf(esHistorial, " and h.proceso='" & nroProceso & "'", "") _
                & IIf(esMensual, "", " and fec_inv>='" & mfechaI & "' and fec_inv<='" & mfechaF & "'") _
                & IIf(xAlmacen, " and h.cod_alma='" & cod_alma & "'", "") _
                & IIf(xGrupo, " and articulo.cod_sgrupo='" & cod_sgrupo & "'", "") _
                & " group by cod_art order by nom_art"
        cad = cad1 + cad2 + cad3 + cad4 + cad5 + cad6
        Dim comArt As New MySqlCommand(cad)
        comArt.Connection = clConex
        da.SelectCommand = comArt
        da.Fill(dsInventarioDiario, "inventario")
        clConex.Close()
        Return dsInventarioDiario()
    End Function
    Public Function existDiario(ByVal fecha As Date, ByVal xAlmacen As Boolean, ByVal cod_alma As String) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer, cad As String
        Dim mfecha As String = fecha.ToString("yy-MM-dd")
        com.Connection = clConex
        cad = "Select operacion from inventario_d where fec_inv='" & mfecha & "'" _
            & IIf(xAlmacen, " and cod_alma='" & cod_alma & "'", "")
        com.CommandText = cad
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Integer)
        clConex.Close()
        If result > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function existInicial(ByVal esHistorial As Boolean, ByVal proceso As String, ByVal cod_alma As String, ByVal xArea As Boolean, ByVal cod_area As String) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer, cad, cad1, cad2, cad3 As String
        com.Connection = clConex
        cad1 = "Select sum(cant) "
        If esHistorial Then
            cad2 = " from h_ingreso i inner join h_ingreso_det d on i.operacion=d.operacion and i.proceso=d.proceso where i.proceso= '" & proceso & "' and "
        Else
            cad2 = " from ingreso i inner join ingreso_det d on i.operacion=d.operacion where "
        End If
        cad3 = "  i.cod_alma='" & cod_alma & "'" & IIf(xArea, " and i.cod_area='" & cod_area & "'", " ") & " and i.cod_doc='10' "
        cad = cad1 + cad2 + cad3
        com.CommandText = cad
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Integer)
        clConex.Close()
        If result > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function devOperacionInicial(ByVal empresa As String, ByVal esHistorial As Boolean, ByVal periodo As String,
                    ByVal cod_alma As String, ByVal xArea As Boolean, ByVal cod_area As String) As Integer
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer
        Dim cad, cad1, cad2, cad3, cad4 As String
        com.Connection = clConex
        cad1 = " select operacion "
        cad2 = IIf(esHistorial, " from h_ingreso as h", " from ingreso as h")
        cad3 = " inner join almacen on h.cod_alma=almacen.cod_alma "
        cad4 = " where h.cod_alma='" & cod_alma & "'" _
            & IIf(esHistorial, " and proceso='" & periodo & "'", "") _
            & IIf(xArea, " and h.cod_area='" & cod_area & "'", " and h.cod_area='0000'") _
            & " and cod_doc='10'"
        cad = cad1 + cad2 + cad3 + cad4
        com.CommandText = cad
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Integer)
        clConex.Close()
        Return result
    End Function
    Public Function recInicial(ByVal empresa As String, ByVal esHistorial As Boolean, ByVal periodo As String,
            ByVal xAlmacen As Boolean, ByVal cod_alma As String, ByVal xArea As Boolean, ByVal cod_area As String,
            ByVal xGrupo As Boolean, ByVal cod_sgrupo As String, ByVal agrupado As Boolean, ByVal strAgrupado As String) As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim da As New MySqlDataAdapter
        Dim ds As New DataSet
        Dim cad, cad1, cad2, cad3, cad4, cad5 As String
        cad1 = "select h.operacion,ingreso,articulo.cod_art,nom_art,nom_uni,cant as cant_fis," _
                & "precio,h.cod_alma,nom_alma,articulo.cod_sgrupo,nom_sgrupo,subgrupo.esProduccion"
        If esHistorial Then
            cad2 = " from h_ingreso as h inner join h_ingreso_det as hd on h.operacion=hd.operacion and h.proceso=hd.proceso"
        Else
            cad2 = " from ingreso as h inner join ingreso_det as hd on h.operacion=hd.operacion"
        End If
        cad3 = " inner join articulo on articulo.cod_art=hd.cod_art" _
                & " inner join unidad on articulo.cod_uni=unidad.cod_uni" _
                & " inner join almacen on h.cod_alma=almacen.cod_alma" _
                & " inner join subgrupo on articulo.cod_sgrupo=subgrupo.cod_sgrupo" _
                & " inner join area on h.cod_area=area.cod_area"
        cad4 = " where h.cod_doc='10' " _
                & IIf(esHistorial, " and h.proceso='" & periodo & "'", "") _
                & IIf(xAlmacen, " and h.cod_alma='" & cod_alma & "'", "") _
                & IIf(xArea, " and h.cod_area='" & cod_area & "'", "") _
                & IIf(xGrupo, " and articulo.cod_sgrupo='" & cod_sgrupo & "'", "")
        cad5 = IIf(agrupado, " group by '" & strAgrupado & "'", "") & " order by nom_art"
        cad = cad1 + cad2 + cad3 + cad4 + cad5
        Dim com As New MySqlCommand(cad, clConex)
        da.SelectCommand = com
        da.Fill(ds, "inventario")
        clConex.Close()
        Return ds
    End Function
    Public Function recInvInicialAlmaPrincipal_ing(ByVal empresa As String, ByVal esHistorial As Boolean,
                                ByVal periodo As String, ByVal agrupado As Boolean) As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter
        Dim cad, cad1, cad2, cad3, cad4 As String
        cad1 = "select ingreso,cod_art,cant,precio"
        If esHistorial Then
            cad2 = " from h_ingreso as h inner join h_ingreso_det as hd on h.operacion=hd.operacion"
        Else
            cad2 = " from ingreso as h inner join ingreso_det as hd on h.operacion=hd.operacion"
        End If
        cad3 = " inner join almacen on h.cod_alma=almacen.cod_alma"
        cad4 = " where(cod_doc = '10') and (esPrincipal)" _
            & IIf(esHistorial, " and h.proceso='" & periodo & "'", "")
        cad = cad1 + cad2 + cad3 + cad4
        Dim com As New MySqlCommand(cad, clConex)
        da.SelectCommand = com
        da.Fill(ds, "inicial")
        clConex.Close()
        Return ds
    End Function
    Public Function recInvFinalAlmaPrincipal(ByVal empresa As String, ByVal catalogoXalmacen As Boolean,
                                    ByVal periodo As String, ByVal agrupado As Boolean, ByVal ca As String) As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter
        Dim nAnno As Integer = Left(periodo, 4)
        Dim nMes As Integer = Right(periodo, 2)
        Dim cad, cad1, cad2, cad3, cad4, cad5 As String
        cad1 = "select inventario,inventario_mdet.cod_art,nom_art,nom_uni,articulo.cod_sgrupo,nom_sgrupo,articulo.cod_alma,nom_alma," _
                & IIf(agrupado, "sum(cant_fis) as cant_fis,sum(cant_sis) as cant_sis", "cant_fis,cant_sis") & ",inventario_mdet.pre_costo"
        cad2 = " from inventario_m inner join inventario_mdet on inventario_m.operacion=inventario_mdet.operacion"
        cad3 = " inner join almacen on inventario_m.cod_alma=almacen.cod_alma" _
                & " inner join articulo on inventario_mdet.cod_art=articulo.cod_art" _
                & " inner join unidad on articulo.cod_uni=unidad.cod_uni" _
                & " inner join subgrupo on articulo.cod_sgrupo=subgrupo.cod_sgrupo"
        cad4 = " where not(almacen.esProduccion) and almacen.cod_emp='" & empresa & "'" _
                & " and year(fec_inv) =" & nAnno & " and month(fec_inv)=" & nMes
        cad5 = IIf(agrupado, " group by cod_art", "")
        cad = cad1 + cad2 + cad3 + cad4 + cad5
        Dim com As New MySqlCommand(cad, clConex)
        da.SelectCommand = com
        da.Fill(ds, "final")
        clConex.Close()
        Return ds
    End Function
    Public Function recInvFinalAlmaProduccion(ByVal empresa As String, ByVal catalogoXalmacen As Boolean,
                                    ByVal periodo As String, ByVal xA As Boolean, ByVal ca As String) As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter
        Dim nAnno As Integer = Left(periodo, 4)
        Dim nMes As Integer = Right(periodo, 2)
        Dim cad, cad1, cad2, cad3, cad4 As String
        cad1 = "select inventario,inventario_mdet.cod_art,nom_art,nom_uni,articulo.cod_sgrupo,nom_sgrupo,articulo.cod_alma,nom_alma," _
                & " cant_fis,cant_sis,inventario_mdet.pre_costo "
        cad2 = " from inventario_m inner join inventario_mdet on inventario_m.operacion=inventario_mdet.operacion"
        cad3 = " inner join almacen on inventario_m.cod_alma=almacen.cod_alma" _
                & " inner join articulo on inventario_mdet.cod_art=articulo.cod_art" _
                & " inner join unidad on articulo.cod_uni=unidad.cod_uni" _
                & " inner join subgrupo on articulo.cod_sgrupo=subgrupo.cod_sgrupo"
        cad4 = " where  (almacen.es_invMensual) and almacen.cod_emp='" & empresa & "'" _
            & IIf(xA, " and inventario_m.cod_alma='" & ca & "'", "") _
            & " and year(fec_inv) =" & nAnno & " and month(fec_inv)=" & nMes
        cad = cad1 + cad2 + cad3 + cad4
        Dim com As New MySqlCommand(cad, clConex)
        da.SelectCommand = com
        da.Fill(ds, "final")
        clConex.Close()
        Return ds
    End Function

    Public Function recInvdiarioInicialAlmaProduccion(ByVal empresa As String, ByVal catalogoXalmacen As Boolean,
                                ByVal fechaI As Date, ByVal fechaf As Date, ByVal xA As Boolean, ByVal ca As String) As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter
        Dim mfechaI As String = fechaI.ToString("yy-MM-dd")
        Dim mfechaF As String = fechaf.ToString("yy-MM-dd")
        Dim cad, cad1, cad2, cad3, cad4 As String
        cad1 = "select inventario,inventario_ddet.cod_art,nom_art,nom_uni,articulo.cod_sgrupo,nom_sgrupo,articulo.cod_alma,nom_alma," _
                & " cant_fis as cant,cant_sis,inventario_ddet.pre_costo "
        cad2 = " from inventario_d inner join inventario_ddet on inventario_d.operacion=inventario_ddet.operacion"
        cad3 = " inner join almacen on inventario_d.cod_alma=almacen.cod_alma" _
                & " inner join articulo on inventario_ddet.cod_art=articulo.cod_art" _
                & " inner join unidad on articulo.cod_uni=unidad.cod_uni" _
                & " inner join subgrupo on articulo.cod_sgrupo=subgrupo.cod_sgrupo"
        cad4 = " where  (almacen.es_invMensual) and almacen.cod_emp='" & empresa & "'" _
            & IIf(xA, " and inventario_d.cod_alma='" & ca & "'", "") _
            & " and (fec_inv) >='" & mfechaI & "' and (fec_inv)<='" & mfechaF & "'"
        cad = cad1 + cad2 + cad3 + cad4
        Dim com As New MySqlCommand(cad, clConex)
        da.SelectCommand = com
        da.Fill(ds, "inicial")
        clConex.Close()
        Return ds
    End Function


    Public Function recInvdiarioAlmaProduccion(ByVal empresa As String, ByVal catalogoXalmacen As Boolean,
                                    ByVal fechaI As Date, ByVal fechaf As Date, ByVal xA As Boolean, ByVal ca As String) As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter
        Dim mfechaI As String = fechaI.ToString("yy-MM-dd")
        Dim mfechaF As String = fechaf.ToString("yy-MM-dd")
        Dim cad, cad1, cad2, cad3, cad4 As String
        cad1 = "select inventario,inventario_ddet.cod_art,nom_art,nom_uni,articulo.cod_sgrupo,nom_sgrupo,articulo.cod_alma,nom_alma," _
                & " cant_fis,cant_sis,inventario_ddet.pre_costo "
        cad2 = " from inventario_d inner join inventario_ddet on inventario_d.operacion=inventario_ddet.operacion"
        cad3 = " inner join almacen on inventario_d.cod_alma=almacen.cod_alma" _
                & " inner join articulo on inventario_ddet.cod_art=articulo.cod_art" _
                & " inner join unidad on articulo.cod_uni=unidad.cod_uni" _
                & " inner join subgrupo on articulo.cod_sgrupo=subgrupo.cod_sgrupo"
        cad4 = " where  (almacen.es_invMensual) and almacen.cod_emp='" & empresa & "'" _
            & IIf(xA, " and inventario_d.cod_alma='" & ca & "'", "") _
            & " and (fec_inv) >='" & mfechaI & "' and (fec_inv)<='" & mfechaF & "'"
        cad = cad1 + cad2 + cad3 + cad4
        Dim com As New MySqlCommand(cad, clConex)
        da.SelectCommand = com
        da.Fill(ds, "final")
        clConex.Close()
        Return ds
    End Function
End Class
