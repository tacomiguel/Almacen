Imports MySql.Data.MySqlClient
Public Class Catalogo
    'creamos el método dsCatalogo que nos devuelve un objeto DataSet
    Public Shared Function dsCatalogo() As DataSet
        'declaramos la variable local ds
        'de tipo DataSet con el nombre Catalogo
        Dim ds As New DataSet("catalogo")
        'añadimos el DataTable al DataSet
        ds.Tables.Add(dtArticulo())
        ds.Tables.Add(dtArticuloPrecio())
        ds.Tables.Add(dtUnidad())
        ds.Tables.Add(dtArea())
        ds.Tables.Add(dtTipo())
        ds.Tables.Add(dtSGrupo())
        ds.Tables.Add(dtGrupoV())
        'establecemos el Foreign Key
        'ds.Relations.Add("ArticuloUnidad", ds.Tables("unidad").Columns("cod_uni"), ds.Tables("articulo").Columns("cod_uni"))
        'hacemos que el metodo retorne el DataSet
        Return ds
    End Function
    Public Shared Function dtArticulo() As DataTable
        'declaramos la variable local dtArticulo
        'de tipo DataTable y nombre "articulo"
        Dim dt As New DataTable("articulo")
        'creamos las columnas del DataTable dtArticulo
        dt.Columns.Add(New DataColumn("cod_art", GetType(String)))
        dt.Columns.Add(New DataColumn("nom_art", GetType(String)))
        dt.Columns.Add(New DataColumn("cod_uni", GetType(String)))
        dt.Columns.Add(New DataColumn("nom_uni", GetType(String)))
        dt.Columns.Add(New DataColumn("pre_costo", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("pre_venta", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("afecto_igv", GetType(Boolean)))
        dt.Columns.Add(New DataColumn("cod_tart", GetType(String)))
        dt.Columns.Add(New DataColumn("nom_tart", GetType(String)))
        dt.Columns.Add(New DataColumn("cod_sgrupo", GetType(String)))
        dt.Columns.Add(New DataColumn("nom_sgrupo", GetType(String)))
        dt.Columns.Add(New DataColumn("maximo", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("minimo", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("activo", GetType(Boolean)))
        'establecemos el indice principal del DataTable
        dt.Constraints.Add("pkCod_art", dt.Columns("cod_art"), True)
        Return dt
    End Function
    Public Shared Function dtArticuloPrecio() As DataTable
        'declaramos la variable local dtArticulo
        'de tipo DataTable y nombre "articulo"
        Dim dt As New DataTable("articuloPrecio")
        'creamos las columnas del DataTable dtArticulo
        dt.Columns.Add(New DataColumn("cod_art", GetType(String)))
        dt.Columns.Add(New DataColumn("nom_art", GetType(String)))
        dt.Columns.Add(New DataColumn("cod_uni", GetType(String)))
        dt.Columns.Add(New DataColumn("nom_uni", GetType(String)))
        dt.Columns.Add(New DataColumn("cant_uni", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("pre_costo", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("pre_venta", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("afecto_igv", GetType(Boolean)))
        dt.Columns.Add(New DataColumn("cod_tart", GetType(String)))
        dt.Columns.Add(New DataColumn("nom_tart", GetType(String)))
        dt.Columns.Add(New DataColumn("cod_sgrupo", GetType(String)))
        dt.Columns.Add(New DataColumn("nom_sgrupo", GetType(String)))
        dt.Columns.Add(New DataColumn("cod_tipo", GetType(String)))
        dt.Columns.Add(New DataColumn("nom_tipo", GetType(String)))
        dt.Columns.Add(New DataColumn("precio", GetType(String)))
        dt.Columns.Add(New DataColumn("comi_v", GetType(String)))
        dt.Columns.Add(New DataColumn("comi_jv", GetType(String)))
        dt.Columns.Add(New DataColumn("activo", GetType(Boolean)))
        Return dt
    End Function
    Public Shared Function dtUnidad() As DataTable
        'declaramos la variable local dtArticulo
        'de tipo DataTable y nombre "articulo"
        Dim dt As New DataTable("unidad")
        'creamos las columnas del DataTable dtArticulo
        dt.Columns.Add(New DataColumn("cod_uni", GetType(String)))
        dt.Columns.Add(New DataColumn("cant_uni", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("nom_uni", GetType(String)))
        dt.Columns.Add(New DataColumn("activo", GetType(Boolean)))
        'establecemos el indice principal del DataTable
        dt.Constraints.Add("pkCod_uni", dt.Columns("cod_uni"), True)
        Return dt
    End Function
    Public Shared Function dtArea() As DataTable
        'declaramos la variable local dtArea
        'de tipo DataTable y nombre "Area"
        Dim dt As New DataTable("Area")
        'creamos las columnas del DataTable dtArea
        dt.Columns.Add(New DataColumn("cod_area", GetType(String)))
        dt.Columns.Add(New DataColumn("nom_area", GetType(String)))
        dt.Columns.Add(New DataColumn("activo", GetType(Boolean)))
        'establecemos el indice principal del DataTable
        dt.Constraints.Add("pkCod_area", dt.Columns("cod_area"), True)
        Return dt
    End Function
    Public Shared Function dtTipo() As DataTable
        'declaramos la variable local dtArticulo
        'de tipo DataTable y nombre "articulo"
        Dim dt As New DataTable("tipo_articulo")
        'creamos las columnas del DataTable dtArticulo
        dt.Columns.Add(New DataColumn("cod_tart", GetType(String)))
        dt.Columns.Add(New DataColumn("nom_tart", GetType(String)))
        dt.Columns.Add(New DataColumn("activo", GetType(Boolean)))
        'establecemos el indice principal del DataTable
        dt.Constraints.Add("pkCod_tart", dt.Columns("cod_tart"), True)
        Return dt
    End Function
    Public Shared Function dtSGrupo() As DataTable
        'declaramos la variable local dtArticulo
        'de tipo DataTable y nombre "articulo"
        Dim dt As New DataTable("subgrupo")
        'creamos las columnas del DataTable dtArticulo
        dt.Columns.Add(New DataColumn("cod_sgrupo", GetType(String)))
        dt.Columns.Add(New DataColumn("nom_sgrupo", GetType(String)))
        dt.Columns.Add(New DataColumn("cod_grupo", GetType(String)))
        dt.Columns.Add(New DataColumn("activo", GetType(Boolean)))
        'establecemos el indice principal del DataTable
        dt.Constraints.Add("pkCod_sgrupo", dt.Columns("cod_sgrupo"), True)
        Return dt
    End Function
    Public Shared Function dtGrupoV() As DataTable
        'declaramos la variable local dtArticulo
        'de tipo DataTable y nombre "articulo"
        Dim dt As New DataTable("GrupoV")
        'creamos las columnas del DataTable dtArticulo
        dt.Columns.Add(New DataColumn("cod_sgrupo", GetType(String)))
        dt.Columns.Add(New DataColumn("nom_sgrupo", GetType(String)))
        dt.Columns.Add(New DataColumn("cod_grupo", GetType(String)))
        dt.Columns.Add(New DataColumn("activo", GetType(Boolean)))
        'establecemos el indice principal del DataTable
        dt.Constraints.Add("pkCod_sgrupo", dt.Columns("cod_sgrupo"), True)
        Return dt
    End Function
    Public Function recuperaCatalogo_COMPRAS(ByVal xalma As Boolean, ByVal ca As String, ByVal sa As Boolean,
                                    ByVal sid As Boolean, ByVal xg As Boolean,
                                    ByVal csg As String, ByVal ip As Boolean,
                                    ByVal sp As Boolean, ByVal li As Boolean) As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion()
        Dim da As New MySqlDataAdapter
        Dim dsCatalogo As New DataSet
        Dim cad, cad1, cad2, cad3 As String
        'uc.cod_uni, uc.cant_uni, uc.nom_uni, ap.precio, pre_costo," &

        cad1 = "Select a.cod_art,nom_art," &
        " u.cant_uni, u.nom_uni," &
        "   Case when ap.cod_uni Is null then a.cod_uni else ap.cod_uni end cod_uni," &
        "   Case when uc.nom_uni Is null then u.nom_uni else uc.nom_uni end uni_compra," &
        "   Case when ap.precio Is null then a.pre_costo else ap.precio end pre_compra," &
        " pre_costoMin, pre_costoMax, pre_prom, pre_costo," &
        " pre_ult, afecto_igv, imp, pre_inc_imp, nom_tart, cuenta_v, cuenta_v_c, cuenta_c, cuenta_c_a1, cuenta_c_a2," &
        " cuenta_c_p, maximo, minimo, pre_venta, a.activo, a.cod_alma, a.cod_sgrupo, nom_sgrupo," &
        " cod_artExt, cod_artExt1, cod_artExt2, subgrupo.esProduccion " &
        " From articulo a" &
        " inner Join unidad u on a.cod_uni=u.cod_uni " &
        " Left Join art_precio ap ON ap.cod_art=a.cod_art and ap.cod_precio='000'" &
        " Left Join unidad uc on ap.cod_uni=uc.cod_uni " &
        " inner Join subgrupo on a.cod_sgrupo=subgrupo.cod_sgrupo " &
        " inner Join tipo_articulo on a.cod_tart=tipo_articulo.cod_tart" &
        " left join tipo_precio tp on tp.cod_precio=ap.cod_precio "
        cad2 = " where a.activo=" & sa & IIf(xalma, " and a.cod_alma='" & ca & "'", "") _
                & IIf(li, " and (es_limpio)", "") _
                & IIf(xg, " and a.cod_sgrupo='" & csg & "'", "") _
                & IIf(sid, " and inv_diario=1", "")
        cad3 = " order by nom_art"
        cad = cad1 + cad2 + cad3
        Dim comSaldo As New MySqlCommand(cad)
        comSaldo.Connection = clConex
        da.SelectCommand = comSaldo
        da.Fill(dsCatalogo, "articulo")
        clConex.Close()
        Return dsCatalogo

        '& IIf(sp, " and tipo_articulo.esProductoterminado", "and !tipo_articulo.esProductoterminado") _
    End Function
    Public Function recuperaMaestroRecetas(ByVal xalma As Boolean, ByVal ca As String, ByVal sa As Boolean,
                                    ByVal sv As Boolean, ByVal sid As Boolean, ByVal xg As Boolean,
                                    ByVal csg As String, ByVal ip As Boolean,
                                    ByVal xp As Boolean, ByVal li As Boolean) As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion()
        Dim da As New MySqlDataAdapter
        Dim dsCatalogo1 As New DataSet
        Dim cad, cad1, cad2, cad3, cad4, cad6 As String
        cad1 = "select a.cod_Art,a.nom_Art,t.nom_tart,u.nom_uni,a.factor_prod, " _
                & "al.nom_alma,ar.nom_area,a1.nom_art,u1.nom_uni,round(r.cant,3) as cantidad,a1.pre_costo, "
        cad2 = " round(r.cant*a1.pre_costo,4) as monto,a.activo "

        cad3 = " from articulo a " _
                & "inner join receta r on a.cod_art=r.cod_rec " _
                & "left join articulo a1 on r.cod_art=a1.cod_art " _
                & "left join unidad u1 on a1.cod_uni =u1.cod_uni " _
                & "left join tipo_articulo t on a.cod_tart=t.cod_tart " _
                & "left join unidad u on a.cod_uni =u.cod_uni " _
                & "left join usuario us on a.usu_ins=us.cuenta " _
                & "left join almacen al on a.cod_alma=al.cod_alma " _
                & "left join area ar on a.cod_area = ar.cod_area "
        cad4 = " where articulo.activo=" & sa _
                & IIf(xalma, " and articulo.cod_alma='" & ca & "'", "") _
                & IIf(sv, " and (subgrupo.esVenta)", "") _
                & IIf(li, " and (es_limpio)", "") _
                & IIf(xg, " and articulo.cod_sgrupo='" & csg & "'", "") _
                & IIf(sid, " and inv_diario=1", "")
        cad6 = " order by a.nom_art"
        cad = cad1 + cad2 + cad3 + cad6
        Dim comSaldo As New MySqlCommand(cad)
        comSaldo.Connection = clConex
        da.SelectCommand = comSaldo
        da.Fill(dsCatalogo1, "recetas")
        clConex.Close()
        Return dsCatalogo1

        '& IIf(sp, " and tipo_articulo.esProductoterminado", "and !tipo_articulo.esProductoterminado") _
    End Function

    Public Function recuperaCatalogo(ByVal xalma As Boolean, ByVal ca As String, ByVal sa As Boolean,
                                    ByVal sv As Boolean, ByVal sid As Boolean, ByVal xg As Boolean,
                                    ByVal csg As String, ByVal ip As Boolean,
                                    ByVal xp As Boolean, ByVal li As Boolean) As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion()
        Dim da As New MySqlDataAdapter
        Dim dsCatalogo As New DataSet
        Dim cad, cad1, cad2, cad3, cad4, cad6 As String
        cad1 = "select a.cod_art,nom_art,a.cod_uni,cant_uni,nom_uni,pre_costo,pre_costoMin," _
                & "pre_costoMax,pre_prom,pre_ult,afecto_igv,imp,pre_inc_imp,nom_tart,"
        cad2 = " cuenta_v,cuenta_v_c,cuenta_c,cuenta_c_a1,cuenta_c_a2,cuenta_c_p," _
                & "maximo,minimo,pre_venta,a.activo,a.cod_alma,a.cod_sgrupo,nom_sgrupo," _
                & "cod_artExt,cod_artExt1,cod_artExt2,subgrupo.esProduccion,aa.cant_stock "
        cad3 = " from articulo a inner join unidad on a.cod_uni=unidad.cod_uni" _
                & " left join subgrupo on a.cod_sgrupo=subgrupo.cod_sgrupo" _
                & " left join tipo_articulo on a.cod_tart=tipo_articulo.cod_tart" _
                & " left join art_almacen aa on aa.cod_alma=a.cod_alma and aa.cod_artAlma=a.cod_art"

        cad4 = " where a.activo=" & sa _
                & IIf(xalma, " and a.cod_alma='" & ca & "'", "") _
                & IIf(sv, " and (subgrupo.esVenta)", "") _
                & IIf(li, " and (es_limpio)", "") _
                & IIf(xg, " and a.cod_sgrupo='" & csg & "'", "") _
                & IIf(sid, " and inv_diario=1", "")
        cad6 = " order by nom_art"
        cad = cad1 + cad2 + cad3 + cad4 + cad6
        Dim comSaldo As New MySqlCommand(cad)
        comSaldo.Connection = clConex
        da.SelectCommand = comSaldo
        da.Fill(dsCatalogo, "articulo")
        clConex.Close()
        Return dsCatalogo

        '& IIf(sp, " and tipo_articulo.esProductoterminado", "and !tipo_articulo.esProductoterminado") _
    End Function
    Public Function recuperaCatalogoMaestro(ByVal ca As String, ByVal sa As Boolean,
                                    ByVal sid As Boolean, ByVal xg As Boolean,
                                    ByVal csg As String, ByVal ip As Boolean,
                                    ByVal sp As Boolean, ByVal li As Boolean) As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion()
        Dim da As New MySqlDataAdapter
        Dim dsCatalogo As New DataSet
        Dim cad, cad1, cad2, cad3, cad4, cad5, cad6 As String
        cad1 = "select cod_art,nom_art,articulo.cod_uni,cant_uni,nom_uni,pre_costo,pre_costoMin," _
                & "pre_costoMax,pre_prom,pre_ult,afecto_igv,imp,pre_inc_imp,nom_tart,"
        cad2 = " cuenta_v,cuenta_v_c,cuenta_c,cuenta_c_a1,cuenta_c_a2,cuenta_c_p," _
                & "maximo,minimo,pre_venta,articulo.activo,articulo.cod_alma,articulo.cod_sgrupo,nom_sgrupo," _
                & "cod_artExt,cod_artExt1,cod_artExt2,subgrupo.esProduccion "
        cad3 = " from articulo inner join unidad on articulo.cod_uni=unidad.cod_uni" _
                & " inner join subgrupo on articulo.cod_sgrupo=subgrupo.cod_sgrupo" _
                & " inner join tipo_articulo on articulo.cod_tart=tipo_articulo.cod_tart"
        cad4 = " where articulo.cod_alma='" & ca & "'" & IIf(li, " and (es_limpio)", "")
        cad5 = " and articulo.activo=1 " & IIf(xg, " and articulo.cod_sgrupo='" & csg & "'", "") _
                    & IIf(sid, " and inv_diario=1", "")
        cad6 = " order by nom_art"
        cad = cad1 + cad2 + cad3 + cad4 + cad5 + cad6
        Dim comSaldo As New MySqlCommand(cad)
        comSaldo.Connection = clConex
        da.SelectCommand = comSaldo
        da.Fill(dsCatalogo, "articulo")
        clConex.Close()
        Return dsCatalogo
    End Function
    Public Function recuperaCatalogoIngreso(ByVal h As Boolean, ByVal pr As String, ByVal xA As Boolean, ByVal ca As String, ByVal sa As Boolean,
                                    ByVal sid As Boolean, ByVal xg As Boolean,
                                    ByVal csg As String, ByVal ip As Boolean,
                                    ByVal sp As Boolean, ByVal li As Boolean) As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion()
        Dim da As New MySqlDataAdapter
        Dim dsCatalogo As New DataSet
        Dim cad, cad1, cad2, cad3 As String

        cad1 = "Select  a.cod_art,nom_art,a.cod_uni,nom_uni,pre_costo As precio,pre_costoMin," _
    & " pre_costoMax, pre_prom, pre_ult, hd.afecto_igv, imp, pre_inc_imp, nom_tart," _
    & " cuenta_v, cuenta_v_c, cuenta_c, cuenta_c_a1, cuenta_c_a2, cuenta_c_p," _
    & " maximo, minimo, pre_venta, a.activo, a.cod_alma, a.cod_sgrupo, nom_sgrupo, " _
    & " cod_artExt, cod_artExt1, cod_artExt2, subgrupo.esProduccion "
        If h Then
            cad2 = " from h_ingreso as h inner join h_ingreso_det as hd on h.operacion=hd.operacion and h.proceso=hd.proceso"
        Else
            cad2 = " from ingreso  as h inner join ingreso_det as hd on h.operacion=hd.operacion"
        End If
        cad3 = " inner Join articulo a On a.cod_art=hd.cod_art " _
    & " inner Join subgrupo on a.cod_sgrupo=subgrupo.cod_sgrupo " _
    & " inner Join unidad On a.cod_uni=unidad.cod_uni " _
    & " inner Join tipo_articulo on a.cod_tart=tipo_articulo.cod_tart " _
    & IIf(xA, " where h.cod_alma='" & ca & "'", "") & IIf(sa, " and a.activo=1 ", " ") _
    & IIf(h, " and h.proceso='" & pr & "'", "") _
    & " group by hd.cod_art "
        cad = cad1 + cad2 + cad3

        Dim comSaldo As New MySqlCommand(cad)
        comSaldo.Connection = clConex
        da.SelectCommand = comSaldo
        da.Fill(dsCatalogo, "articulo")
        clConex.Close()
        Return dsCatalogo
    End Function

    Public Function recuperaCatalogoMen(ByVal xA As Boolean, ByVal ca As String, ByVal sa As Boolean,
                                    ByVal sid As Boolean, ByVal xg As Boolean,
                                    ByVal csg As String, ByVal ip As Boolean,
                                    ByVal sp As Boolean, ByVal li As Boolean) As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion()
        Dim da As New MySqlDataAdapter
        Dim dsCatalogo As New DataSet
        Dim cad, cad1, cad2, cad3, cad4, cad5, cad6 As String
        cad1 = "select cod_art,nom_art,articulo.cod_uni,cant_uni,nom_uni,pre_costo as precio,pre_costoMin," _
                & "pre_costoMax,pre_prom,pre_ult,afecto_igv,imp,pre_inc_imp,nom_tart,"
        cad2 = " cuenta_v,cuenta_v_c,cuenta_c,cuenta_c_a1,cuenta_c_a2,cuenta_c_p," _
                & "maximo,minimo,pre_venta,articulo.activo,articulo.cod_alma,articulo.cod_sgrupo,nom_sgrupo," _
                & "cod_artExt,cod_artExt1,cod_artExt2,subgrupo.esProduccion "
        cad3 = " from articulo inner join unidad on articulo.cod_uni=unidad.cod_uni" _
                & " inner join subgrupo on articulo.cod_sgrupo=subgrupo.cod_sgrupo" _
                & " inner join tipo_articulo on articulo.cod_tart=tipo_articulo.cod_tart"
        'cad4 = " where articulo.cod_alma='" & ca & "'" & IIf(li, " and (es_limpio)", "") _
        cad4 = " where  articulo.activo=1 " & IIf(xA, "and articulo.cod_alma='" & ca & "'", "") & IIf(li, " and (es_limpio)", "") _
        & IIf(sp, " and subgrupo.esVenta", "and !subgrupo.esVenta")
        cad5 = IIf(xg, " and repGerencia ", " and repInventario ") _
            & IIf(sid, " and inv_diario=1", "")
        'cad5 = IIf(xg, " and articulo.cod_sgrupo='" & csg & "'", " and articulo.cod_sgrupo in ('0002','0008','0015','0003')") _
        cad6 = " order by nom_art"
        cad = cad1 + cad2 + cad3 + cad4 + cad5 + cad6
        Dim comSaldo As New MySqlCommand(cad)
        comSaldo.Connection = clConex
        da.SelectCommand = comSaldo
        da.Fill(dsCatalogo, "articulo")
        clConex.Close()
        Return dsCatalogo
    End Function
    Public Function recuperaCatalogoDB(ByVal ca As String, ByVal sa As Boolean,
                                    ByVal sid As Boolean, ByVal xg As Boolean,
                                    ByVal csg As String, ByVal ip As Boolean,
                                    ByVal sp As Boolean, ByVal li As Boolean, ByVal db As MySqlConnection) As DataSet
        'Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim clConex As MySqlConnection = db
        Dim da As New MySqlDataAdapter
        Dim dsCatalogo As New DataSet
        Dim cad, cad1, cad2, cad3, cad4, cad5, cad6 As String
        cad1 = "select cod_art,nom_art,articulo.cod_uni,cant_uni,nom_uni,pre_costo,pre_costoMin," _
                & "pre_costoMax,pre_prom,pre_ult,afecto_igv,imp,pre_inc_imp,nom_tart,"
        cad2 = " cuenta_v,cuenta_v_c,cuenta_c,cuenta_c_a1,cuenta_c_a2,cuenta_c_p," _
                & "maximo,minimo,pre_venta,articulo.activo,articulo.cod_alma,articulo.cod_sgrupo,nom_sgrupo," _
                & "cod_artExt,subgrupo.esProduccion "
        cad3 = " from articulo inner join unidad on articulo.cod_uni=unidad.cod_uni" _
                & " inner join subgrupo on articulo.cod_sgrupo=subgrupo.cod_sgrupo" _
                & " inner join tipo_articulo on articulo.cod_tart=tipo_articulo.cod_tart"
        cad4 = " where (repinventario) and articulo.cod_alma='" & ca & "'" & IIf(li, " and (es_limpio)", "") _
        & IIf(sp, " and subgrupo.esProduccion", "and !subgrupo.esProduccion")
        cad5 = " and articulo.activo=1 " & IIf(xg, " and articulo.cod_sgrupo='" & csg & "'", "") _
                    & IIf(sid, " and inv_diario=1", "")
        cad6 = " order by nom_art"
        cad = cad1 + cad2 + cad3 + cad4 + cad5 + cad6
        Dim comSaldo As New MySqlCommand(cad)
        comSaldo.Connection = clConex
        da.SelectCommand = comSaldo
        da.Fill(dsCatalogo, "articulo")
        clConex.Close()
        Return dsCatalogo
    End Function

    Public Function recuperaRecetas(ByVal ca As String, ByVal xg As Boolean,
                                    ByVal cg As String, ByVal xta As Boolean,
                                    ByVal cta As String, ByVal sa As Boolean,
                                    Optional ByVal x As String = "") As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim da As New MySqlDataAdapter
        Dim dsCatalogo As New DataSet
        Dim cad1, cad2, cad3, cad4, cad5, cad6, cad7, cad As String
        cad1 = "Select cod_art,nom_art,articulo.cod_uni,cant_uni,nom_uni,pre_costo,pre_venta,pre_costoMax,pre_costoMin,afecto_igv,inv_diario,"
        cad2 = " cod_artExt,cod_artExt1,cod_artExt2,articulo.cod_tart,nom_tart,articulo.cod_sgrupo,nom_sgrupo,articulo.activo,minimo,maximo,pre_inc_imp"
        cad3 = " from articulo inner join unidad on articulo.cod_uni=unidad.cod_uni"
        cad4 = " inner join tipo_articulo on articulo.cod_tart=tipo_articulo.cod_tart"
        cad5 = " inner join subgrupo on articulo.cod_sgrupo=subgrupo.cod_sgrupo"
        cad6 = " where articulo.cod_alma='" & ca & "' and (subgrupo.esProduccion)"
        cad7 = IIf(xg, " and articulo.cod_sgrupo='" & cg & "'", "") _
                & IIf(xta, " and articulo.cod_tart='" & cta & "'", "") _
                & " order by 2"
        cad = cad1 + cad2 + cad3 + cad4 + cad5 + cad6 + cad7
        Dim com As New MySqlCommand(cad)
        com.Connection = clConex
        da.SelectCommand = com
        da.Fill(dsCatalogo, "articulo")
        clConex.Close()
        Return dsCatalogo
    End Function
    Public Function recuperaLimpios(Optional ByVal ca As String = "")
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim da As New MySqlDataAdapter
        Dim ds As New DataSet
        Dim cad, cad1, cad2, cad3, cad4, cad5, cad6, cad7 As String
        cad1 = "select art_limpio.cod_art,articulo.nom_art,unidad.nom_uni,cant,limpios.cod_art as cod_artL,"
        cad2 = " limpios.nom_art as nom_artL,unidadL.nom_uni as nom_uniL,cantL"
        cad3 = " from articulo as limpios left join art_limpio on limpios.cod_art=art_limpio.cod_artL"
        cad4 = " left join articulo on articulo.cod_art=art_limpio.cod_art"
        cad5 = " inner join unidad as unidadL on limpios.cod_uni=unidadL.cod_uni"
        cad6 = " left join unidad on articulo.cod_uni=unidad.cod_uni"
        cad7 = " where(limpios.es_limpio) order by nom_artL"
        cad = cad1 + cad2 + cad3 + cad4 + cad5 + cad6 + cad7
        Dim com As New MySqlCommand(cad)
        com.Connection = clConex
        da.SelectCommand = com
        da.Fill(ds, "articulo")
        clConex.Close()
        Return ds
    End Function
    Public Function recBotellas(Optional ByVal ca As String = "") As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim da As New MySqlDataAdapter
        Dim ds As New DataSet
        Dim cad, cad1, cad2, cad3 As String
        cad1 = "select cod_art,nom_art,nom_uni,peso_lleno,peso_vacio"
        cad2 = " from articulo inner join unidad on articulo.cod_uni=unidad.cod_uni"
        cad3 = " where (es_botella) order by nom_art"
        cad = cad1 + cad2 + cad3
        Dim com As New MySqlCommand(cad)
        com.Connection = clConex
        da.SelectCommand = com
        da.Fill(ds, "articulo")
        clConex.Close()
        Return ds
    End Function
    Public Function recuperaCatalogo_x_tipo(ByVal ca As String, ByVal sa As Boolean, ByVal tipo As String, ByVal cta As String) As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim da As New MySqlDataAdapter
        Dim dsCatalogo As New DataSet
        Dim cad, cad1, cad2, cad3, cad3a, cad4 As String
        cad1 = "select cod_art,nom_art,articulo.cod_uni,nom_uni,pre_costo,pre_ult,afecto_igv,imp,pre_inc_imp,"
        cad2 = " cuenta_c,cuenta_v,maximo,minimo,pre_venta,articulo.activo,nom_sgrupo,cod_artExt "
        cad3 = " from articulo inner join unidad on articulo.cod_uni=unidad.cod_uni "
        cad3a = " inner join subgrupo on articulo.cod_sgrupo=subgrupo.cod_sgrupo "
        If tipo = "subgrupo" Then
            cad4 = " where articulo.activo=" & sa & " and articulo.cod_alma='" & ca & "' and articulo.cod_sgrupo='" & cta & "' order by nom_art"
        Else
            If tipo = "tipoArticulo" Then
                cad4 = " where articulo.activo=" & sa & " and articulo.cod_alma='" & ca & "' and cod_tart='" & cta & "'  order by nom_art"
            Else
                cad4 = " articulo.activo " & sa & " order by nom_art"
            End If
        End If
        cad = cad1 + cad2 + cad3 + cad3a + cad4
        Dim comSaldo As New MySqlCommand(cad)
        comSaldo.Connection = clConex
        da.SelectCommand = comSaldo
        da.Fill(dsCatalogo, "articulo")
        clConex.Close()
        Return dsCatalogo
    End Function
    Public Function recuperaProducto(ByVal xalma As Boolean, ByVal ca As String, ByVal na As String) As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim da As New MySqlDataAdapter
        Dim dsCatalogo As New DataSet
        Dim cad, cad1, cad2, cad3, cad4 As String
        cad1 = "select cod_art,nom_art,articulo.cod_uni,nom_uni,cant_uni,pre_costo,pre_prom,"
        cad2 = " pre_venta,pre_ult,afecto_igv,cuenta_c,cuenta_v,maximo,minimo,articulo.cod_sgrupo,subgrupo.esProduccion "
        cad3 = " from articulo inner join unidad on articulo.cod_uni=unidad.cod_uni " _
                & " inner join subgrupo on articulo.cod_sgrupo=subgrupo.cod_sgrupo"
        cad4 = " where articulo.activo=1 " & IIf(xalma, " and articulo.cod_alma='" & ca & "'", "") _
               & " and nom_art like '%" & na & "%'  order by nom_art "
        cad = cad1 + cad2 + cad3 + cad4
        Dim comSaldo As New MySqlCommand(cad)
        comSaldo.Connection = clConex
        da.SelectCommand = comSaldo
        da.Fill(dsCatalogo, "articulo")
        clConex.Close()
        Return dsCatalogo
    End Function
    Public Function recuperaProductoT(ByVal xAlma As Boolean, ByVal ca As String, ByVal na As String) As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim da As New MySqlDataAdapter
        Dim dsCatalogo As New DataSet
        Dim cad, cad1, cad2, cad3, cad4 As String
        cad1 = "select cod_art,nom_art,articulo.cod_uni,nom_uni,cant_uni,pre_costo,pre_prom,"
        cad2 = " pre_venta,pre_ult,afecto_igv,cuenta_c,cuenta_v,maximo,minimo,articulo.cod_sgrupo,subgrupo.esProduccion "
        cad3 = " from articulo inner join unidad on articulo.cod_uni=unidad.cod_uni " _
                & " inner join subgrupo on articulo.cod_sgrupo=subgrupo.cod_sgrupo"
        cad4 = " where articulo.activo=1 " & IIf(xAlma, " and articulo.cod_alma='" & ca & "'", "") _
                & " and nom_art like '" & na & "%'  order by nom_art "

        cad = cad1 + cad2 + cad3 + cad4
        Dim comSaldo As New MySqlCommand(cad)
        comSaldo.Connection = clConex
        da.SelectCommand = comSaldo
        da.Fill(dsCatalogo, "articulo")
        clConex.Close()
        Return dsCatalogo
    End Function
    Public Function recuperaProducto_xCodigo(ByVal ca As String) As String
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As String, cad As String
        com.Connection = clConex
        cad = "Select nom_art from articulo where cod_art='" & ca & "'"
        com.CommandText = cad
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), "", obj), String)
        clConex.Close()
        Return result
    End Function
    Public Function recuperaSaldos(ByVal h As Boolean, ByVal np As String,
                        ByVal ag As Boolean, ByVal xAlmacen As Boolean,
                        ByVal cod_alma As String, ByVal xsg As Boolean, ByVal csg As String,
                        ByVal imp As Boolean, ByVal xa As Boolean, ByVal ca As String,
                          Optional ByVal nd As Integer = 0, Optional ByVal xsaldo As Boolean = True) As DataSet

        Dim clConex As MySqlConnection = Conexion.obtenerConexion

        Dim da As New MySqlDataAdapter
        Dim dsSaldo As New DataSet

        Dim cad, cad1, cad1a, cad1b, cad1c, cad2, cad3, cad4, cad5, cad6, cad7, cad8 As String
        cad1 = " select ingreso,hd.cod_art,nom_art,nom_uni,cant_uni,es_divisible,pre_ult," & IIf(ag, "sum(hd.saldo) as saldo, 0 as cant_fis, ", "hd.saldo,")
        If h Then
            cad1a = " hd.precio_prom as precio,"
            cad1b = IIf(imp, " round(if(hd.afecto_igv,round(hd.precio_prom+hd.precio_prom*hd.igv,3),hd.precio_prom)*" _
                    & IIf(ag, " sum(hd.saldo)," & nd & ") as monto,", " hd.saldo," & nd & ") as monto,"),
                    " round(hd.precio_prom*" & IIf(ag, "sum(hd.saldo)," & nd & ") as monto,", "hd.saldo," & nd & ") as monto,"))
            cad1c = " hd.afecto_igv,articulo.cod_sgrupo,nom_sgrupo,h.cod_alma,nom_alma,maximo,minimo,tm,tc,h.pre_inc_igv,hd.igv"
            cad2 = " from ingreso as h inner join ingreso_det as hd on h.operacion=hd.operacion and h.proceso=hd.proceso "
        Else
            cad1a = " articulo.pre_costo as precio,"
            cad1b = IIf(imp, " round(if(articulo.afecto_igv,round(articulo.pre_costo+articulo.pre_costo*hd.igv," _
                    & nd & "),articulo.pre_costo)*" & IIf(ag, "sum(hd.saldo)," & nd _
                    & ") as monto,", "hd.saldo," & nd & ") as monto,"),
                    " round(articulo.pre_costo*" & IIf(ag, " sum(hd.saldo)," & nd & ") as monto,", " hd.saldo," _
                    & nd & ") as monto,"))
            cad1c = " articulo.afecto_igv,articulo.cod_sgrupo,nom_sgrupo,h.cod_alma,nom_alma,maximo,minimo,tm,tc,h.pre_inc_igv,hd.igv"
            cad2 = " from ingreso as h inner join ingreso_det as hd on h.operacion=hd.operacion "
        End If
        cad3 = " inner join articulo on articulo.cod_art=hd.cod_art inner join almacen on h.cod_alma=almacen.cod_alma "
        cad4 = " inner join unidad on articulo.cod_uni=unidad.cod_uni inner join subgrupo on articulo.cod_sgrupo=subgrupo.cod_sgrupo"
        cad5 = " where articulo.activo" & IIf(h, " and h.proceso='" & np & "'", "")
        cad6 = IIf(xAlmacen, " and h.cod_alma='" & cod_alma & "'", "")
        cad7 = IIf(xsg, " and articulo.cod_sgrupo='" & csg & "'", "") _
                & IIf(xa, " and hd.cod_art='" & ca & "'", "")
        cad8 = IIf(ag, " group by hd.cod_art having" & IIf(xsaldo, " sum(hd.saldo)>=0 or sum(hd.saldo)=0", " sum(hd.saldo)<=0"), "") & " order by nom_art,fec_doc"
        cad = cad1 + cad1a + cad1b + cad1c + cad2 + cad3 + cad4 + cad5 + cad6 + cad7 + cad8
        Dim comSaldo As New MySqlCommand(cad)
        comSaldo.Connection = clConex
        da.SelectCommand = comSaldo
        da.Fill(dsSaldo, "saldo")

        Return dsSaldo
    End Function
    Public Function IngresaSaldos(ByVal ope As Integer, ByVal h As Boolean, ByVal np As String,
                        ByVal ag As Boolean, ByVal xAlmacen As Boolean,
                        ByVal cod_alma As String, ByVal xsg As Boolean, ByVal csg As String,
                        ByVal imp As Boolean, ByVal xa As Boolean, ByVal ca As String,
                          Optional ByVal nd As Integer = 0, Optional ByVal usu As String = "", Optional ByVal xsaldo As Boolean = True) As Boolean

        Dim clConex As MySqlConnection = Conexion.obtenerConexion

        Dim com As New MySqlCommand
        Dim result As Integer
        com.Connection = clConex
        Dim cad, cad1, cad1a, cad1b, cad1c, cad2, cad3, cad4, cad5, cad6, cad7, cad8 As String
        cad1 = "insert into inventario_mdet select " & ope & ",ingreso,hd.cod_art," & IIf(ag, "sum(hd.saldo) as cant_fis,sum(hd.saldo) as cant_sis, ", "sum(hd.saldo) as cant_fis,sum(hd.saldo) as cant_sis,")
        If h Then
            cad1a = " pre_ult as precio,'" & usu & "' as cuenta"

            cad2 = " from h_ingreso as h inner join h_ingreso_det as hd on h.operacion=hd.operacion and h.proceso=hd.proceso "
        Else
            cad1a = " pre_ult as precio,'" & usu & "' as cuenta"

            cad2 = " from h_ingreso as h inner join h_ingreso_det as hd on h.operacion=hd.operacion "
        End If
        cad3 = " inner join articulo on articulo.cod_art=hd.cod_art inner join almacen on h.cod_alma=almacen.cod_alma "
        cad4 = " inner join unidad on articulo.cod_uni=unidad.cod_uni inner join subgrupo on articulo.cod_sgrupo=subgrupo.cod_sgrupo"
        cad5 = " where articulo.activo" & IIf(h, " and h.proceso='" & np & "'", "")
        cad6 = IIf(xAlmacen, " and h.cod_alma='" & cod_alma & "'", "")
        cad7 = IIf(xsg, " and articulo.cod_sgrupo='" & csg & "'", "") _
                & IIf(xa, " and hd.cod_art='" & ca & "'", "")
        cad8 = IIf(ag, " group by hd.cod_art having" & IIf(xsaldo, " sum(hd.saldo)>=0 or sum(hd.saldo)=0", " sum(hd.saldo)<=0"), "") & " order by nom_art,fec_doc"


        cad = cad1 + cad1a + cad2 + cad3 + cad4 + cad5 + cad6 + cad7 + cad8
        com.CommandText = cad
        result = com.ExecuteNonQuery
        clConex.Close()
        Return True

    End Function
    Public Function recuperaSaldos_Integrado(ByVal h As Boolean, ByVal np As String,
                    ByVal ag As Boolean, ByVal xAlmacen As Boolean, ByVal cod_alma As String,
                    ByVal xArea As Boolean, ByVal cod_area As String, ByVal xsg As Boolean, ByVal csg As String,
                    ByVal imp As Boolean, ByVal xa As Boolean, ByVal ca As String,
                    ByVal nd As Integer, Optional ByVal xsaldo As Boolean = True, Optional ByVal xhv As Boolean = True) As DataSet

        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim da As New MySqlDataAdapter
        Dim dsSaldo As New DataSet
        Dim cad, cad1, cad1a, cad1b, cad1c, cad2, cad3, cad4, cad5, cad6, cad7, cad8, cad9, cad10 As String
        cad1 = "select ingreso,hd.cod_art,nom_art,nom_uni,cant_uni,es_divisible,pre_ult, sum(hd.cant) - "

        If h Then
            cad1a = " ifnull((select sum(cant) from h_salida s inner join h_salida_det sd on s.operacion=sd.operacion and s.proceso=sd.proceso where cod_art=hd.cod_Art" & IIf(xAlmacen, " and s.cod_alma='" & cod_alma & "'", "") & IIf(xArea, " and s.cod_area='" & cod_area & "'", "") & "), 0) as saldo, "
            cad1b = IIf(imp, " round(if(hd.afecto_igv,round(hd.precio_prom+hd.precio_prom*hd.igv,3),hd.precio_prom)*" _
                    & IIf(ag, " sum(hd.saldo)," & nd & ") as monto,", " hd.saldo," & nd & ") as monto,"),
                    " round(hd.precio_prom*" & IIf(ag, "sum(hd.saldo)," & nd & ") as monto,", "hd.saldo," & nd & ") as monto,"))
            cad1c = " hd.precio_prom as precio,hd.afecto_igv,articulo.cod_sgrupo,nom_sgrupo,h.cod_alma,nom_alma,maximo,minimo,tm,tc,h.pre_inc_igv,hd.igv"
            cad2 = " from h_ingreso as h inner join h_ingreso_det as hd on h.operacion=hd.operacion and h.proceso=hd.proceso "
        Else
            cad1a = " ifnull((select sum(cant) from salida s inner join salida_det sd on s.operacion=sd.operacion where cod_art=hd.cod_Art" & IIf(xAlmacen, " and s.cod_alma='" & cod_alma & "'", "") & IIf(xArea, " and s.cod_area='" & cod_area & "'", "") & "), 0) as saldo, "
            cad1b = IIf(imp, " round(if(articulo.afecto_igv,round(articulo.pre_costo+articulo.pre_costo*hd.igv," _
                    & nd & "),articulo.pre_costo)*" & IIf(ag, "sum(hd.saldo)," & nd _
                    & ") as monto,", "hd.saldo," & nd & ") as monto,"),
                    " round(articulo.pre_costo*" & IIf(ag, " sum(hd.saldo)," & nd & ") as monto,", " hd.saldo," _
                    & nd & ") as monto,"))
            cad1c = " articulo.pre_costo as precio,articulo.afecto_igv,articulo.cod_sgrupo,nom_sgrupo,h.cod_alma,nom_alma,maximo,minimo,tm,tc,h.pre_inc_igv,hd.igv"
            cad2 = " from ingreso as h inner join ingreso_det as hd on h.operacion=hd.operacion "
        End If
        cad3 = " inner join articulo on articulo.cod_art=hd.cod_art inner join almacen on h.cod_alma=almacen.cod_alma "
        cad4 = " inner join unidad on articulo.cod_uni=unidad.cod_uni inner join subgrupo on articulo.cod_sgrupo=subgrupo.cod_sgrupo"
        cad5 = " where articulo.activo" & IIf(h, " and h.proceso='" & np & "'", "")
        cad6 = IIf(xAlmacen, " and h.cod_alma='" & cod_alma & "'", "")
        cad7 = IIf(xArea, " and h.cod_area='" & cod_area & "'", "")
        cad8 = IIf(xsg, " and articulo.cod_sgrupo='" & csg & "'", "") _
                & IIf(xa, " and hd.cod_art='" & ca & "'", "")
        cad9 = IIf(ag, " group by hd.cod_art ", "")
        cad10 = IIf(xhv, " having" & IIf(xsaldo, " saldo>0", " saldo<=0"), "") & " order by nom_art,fec_doc"
        cad = cad1 + cad1a + cad1b + cad1c + cad2 + cad3 + cad4 + cad5 + cad6 + cad7 + cad8 + cad9 + cad10
        Dim comSaldo As New MySqlCommand(cad)
        comSaldo.Connection = clConex
        da.SelectCommand = comSaldo
        da.Fill(dsSaldo, "saldo")
        clConex.Close()
        Return dsSaldo
    End Function
    Public Function recuperaSaldoAlmacen_paraDesp(ByVal stock0 As Boolean, ByVal ag As Boolean, ByVal ca As String, ByVal xa As Boolean,
                    ByVal na As String, ByVal xsg As Boolean, ByVal csg As String,
                    Optional ByVal x1 As Boolean = False, Optional ByVal x2 As Decimal = 0.0, Optional ByVal x3 As Integer = 0) As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim da As New MySqlDataAdapter
        Dim dsSaldo As New DataSet
        Dim cad, cad1, cad1b, cad1c, cad2, cad3, cad4, cad5, cad6, cad7 As String
        'es temporal
        '**************
        stock0 = False
        '**************
        If ag Then
            cad1 = "Select ingreso,articulo.cod_art,nom_art,nom_uni,pre_costo As precio,pre_costo, pre_venta,"
            cad1b = " pre_ult,sum(ingreso_det.saldo)As saldo, pre_costo * sum(ingreso_det.saldo) As monto,"
            cad1c = " articulo.afecto_igv,maximo,minimo,articulo.cod_sgrupo,nom_sgrupo,ingreso.cod_alma,nom_alma,tm,tc "
            cad7 = " group by ingreso_det.cod_art order by cod_art"
        Else
            cad1 = "Select ingreso,articulo.cod_art,nom_art,nom_uni, precio,pre_costo,pre_venta,"
            cad1b = " pre_ult,ingreso_det.saldo, precio *ingreso_det.saldo As monto,"
            cad1c = " articulo.afecto_igv,maximo,minimo,articulo.cod_sgrupo,nom_sgrupo,ingreso.cod_alma,nom_alma,tm,tc "
            cad7 = " order by nom_art,ingreso_det.ingreso"
        End If
        cad2 = " from ingreso inner join ingreso_det On ingreso.operacion=ingreso_det.operacion "
        cad3 = " inner join articulo On articulo.cod_art=ingreso_det.cod_art inner join almacen On ingreso.cod_alma=almacen.cod_alma "
        cad4 = " inner join unidad On articulo.cod_uni=unidad.cod_uni "
        cad5 = " inner join subgrupo On articulo.cod_sgrupo=subgrupo.cod_sgrupo"
        cad6 = " where ingreso.cod_alma='" & ca & "'" _
                        & IIf(xsg, " and articulo.cod_sgrupo='" & csg & "'", "") _
                        & IIf(xa, " and nom_art like '%" & na & "%'", "")
        cad = cad1 + cad1b + cad1c + cad2 + cad3 + cad4 + cad5 + cad6 + cad7
        Dim comSaldo As New MySqlCommand(cad)
        comSaldo.Connection = clConex
        da.SelectCommand = comSaldo
        da.Fill(dsSaldo, "saldo")
        clConex.Close()
        Return dsSaldo
    End Function
    Public Function recuperaSaldoIntegrado_xdia(ByVal f As Date, ByVal ag As Boolean)
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim cad, cad1, cad2, cad3, cad4, cad5, cad6, cad7, cad8 As String
        Dim com, com2, com_a, com_b As New MySqlCommand
        Dim mfecha = f.ToString("yyyy-MM-dd")
        '-------------------------------------------------
        cad = "DROP VIEW IF EXISTS vIngresos"
        com_a.Connection = clConex
        com_a.CommandText = cad
        com_a.ExecuteNonQuery()
        '
        cad1 = " CREATE VIEW vIngresos AS "
        cad2 = "select cod_art,sum(cant)AS cantI,cod_alma,fec_doc"
        cad3 = " from ingreso inner join ingreso_det on ingreso.operacion = ingreso_det.operacion"
        cad4 = " where fec_doc<='" & mfecha & "'"
        cad5 = " group by fec_doc,cod_art order by cod_art,fec_doc"
        cad = cad1 + cad2 + cad3 + cad4 + cad5
        com.Connection = clConex
        com.CommandText = cad
        com.ExecuteNonQuery()
        '
        cad = "DROP VIEW IF EXISTS vIngresosF"
        com_b.Connection = clConex
        com_b.CommandText = cad
        com_b.ExecuteNonQuery()
        '
        cad1 = " CREATE VIEW vIngresosF AS "
        cad2 = "select cod_art,sum(cantI)AS cantI"
        cad3 = " from vIngresos"
        cad4 = " where fec_doc<='" & mfecha & "'"
        cad5 = " group by cod_art order by cod_art"
        cad = cad1 + cad2 + cad3 + cad4 + cad5
        com2.Connection = clConex
        com2.CommandText = cad
        com2.ExecuteNonQuery()
        '-------------------------------------------------
        cad = "DROP VIEW IF EXISTS vSalidas"
        com_a.Connection = clConex
        com_a.CommandText = cad
        com_a.ExecuteNonQuery()
        '
        cad1 = " CREATE VIEW vSalidas AS "
        cad2 = "select cod_art,sum(cant)AS cantS,cod_alma,fec_doc"
        cad3 = " from salida inner join salida_det on salida.operacion = salida_det.operacion"
        cad4 = " where fec_doc<='" & mfecha & "'"
        cad5 = " group by fec_doc,cod_art order by cod_art,fec_doc"
        cad = cad1 + cad2 + cad3 + cad4 + cad5
        com.Connection = clConex
        com.CommandText = cad
        com.ExecuteNonQuery()
        '
        cad = "DROP VIEW IF EXISTS vSalidasF"
        com_b.Connection = clConex
        com_b.CommandText = cad
        com_b.ExecuteNonQuery()
        '
        cad1 = " CREATE VIEW vSalidasF AS "
        cad2 = "select cod_art,sum(cantS)AS cantS"
        cad3 = " from vSalidas"
        cad4 = " where fec_doc<='" & mfecha & "'"
        cad5 = " group by cod_art order by cod_art"
        cad = cad1 + cad2 + cad3 + cad4 + cad5
        com2.Connection = clConex
        com2.CommandText = cad
        com2.ExecuteNonQuery()
        '---------------------------------------------------
        Dim da As New MySqlDataAdapter
        Dim dsSaldo As New DataSet
        cad1 = "select vIngresosF.cod_art,nom_art,nom_uni,cantI,IFNULL(cantS,0)as cantS,"
        cad2 = " cantI-IFNULL(cantS,0) as saldo,pre_venta,pre_costo,pre_ult,maximo,minimo,afecto_igv,nom_sgrupo,subgrupo.cod_sgrupo "
        cad3 = " from vIngresosF left join vSalidasF on vIngresosF.cod_art=vSalidasF.cod_art"
        cad4 = " inner join articulo on vIngresosF.cod_art=articulo.cod_art"
        cad5 = " inner join unidad on articulo.cod_uni=unidad.cod_uni"
        cad6 = " inner join subgrupo on articulo.cod_sgrupo=subgrupo.cod_sgrupo"
        cad7 = " group by vIngresosF.cod_art"
        cad8 = " order by nom_art"
        cad = cad1 + cad2 + cad3 + cad4 + cad5 + cad6 + cad7 + cad8
        Dim comSaldo As New MySqlCommand(cad)
        comSaldo.Connection = clConex
        da.SelectCommand = comSaldo
        da.Fill(dsSaldo, "saldo")
        clConex.Close()
        Return dsSaldo
    End Function
    Public Function recuperaSaldoIntegrado_xdia_historial(ByVal pr As String, ByVal f As Date, ByVal ag As Boolean)
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim cad, cad1, cad2, cad3, cad4, cad5, cad6, cad7, cad8 As String
        Dim com, com2, com_a, com_b As New MySqlCommand
        Dim mfecha = f.ToString("yyyy-MM-dd")
        '-------------------------------------------------
        cad = "DROP VIEW IF EXISTS vIngresos"
        com_a.Connection = clConex
        com_a.CommandText = cad
        com_a.ExecuteNonQuery()
        '
        cad1 = " CREATE VIEW vIngresos AS "
        cad2 = "select cod_art,sum(cant)AS cantI,cod_alma,fec_doc"
        cad3 = " from h_ingreso inner join h_ingreso_det on h_ingreso.operacion = h_ingreso_det.operacion"
        cad4 = " where h_ingreso.proceso='" & pr & "' and fec_doc<='" & mfecha & "'"
        cad5 = " group by fec_doc,cod_art order by cod_art,fec_doc"
        cad = cad1 + cad2 + cad3 + cad4 + cad5
        com.Connection = clConex
        com.CommandText = cad
        com.ExecuteNonQuery()
        '
        cad = "DROP VIEW IF EXISTS vIngresosF"
        com_b.Connection = clConex
        com_b.CommandText = cad
        com_b.ExecuteNonQuery()
        '
        cad1 = " CREATE VIEW vIngresosF AS "
        cad2 = "select cod_art,sum(cantI)AS cantI"
        cad3 = " from vIngresos"
        cad4 = " group by cod_art order by cod_art"
        cad = cad1 + cad2 + cad3 + cad4
        com2.Connection = clConex
        com2.CommandText = cad
        com2.ExecuteNonQuery()
        '-------------------------------------------------
        cad = "DROP VIEW IF EXISTS vSalidas"
        com_a.Connection = clConex
        com_a.CommandText = cad
        com_a.ExecuteNonQuery()
        '
        cad1 = " CREATE VIEW vSalidas AS "
        cad2 = "select cod_art,sum(cant)AS cantS,cod_alma,fec_doc"
        cad3 = " from h_salida inner join h_salida_det on h_salida.operacion = h_salida_det.operacion"
        cad4 = " where h_salida.proceso='" & pr & "' and fec_doc<='" & mfecha & "'"
        cad5 = " group by fec_doc,cod_art order by cod_art,fec_doc"
        cad = cad1 + cad2 + cad3 + cad4 + cad5
        com.Connection = clConex
        com.CommandText = cad
        com.ExecuteNonQuery()
        '
        cad = "DROP VIEW IF EXISTS vSalidasF"
        com_b.Connection = clConex
        com_b.CommandText = cad
        com_b.ExecuteNonQuery()
        '
        cad1 = " CREATE VIEW vSalidasF AS "
        cad2 = "select cod_art,sum(cantS)AS cantS"
        cad3 = " from vSalidas"
        cad4 = " group by cod_art order by cod_art"
        cad = cad1 + cad2 + cad3 + cad4
        com2.Connection = clConex
        com2.CommandText = cad
        com2.ExecuteNonQuery()
        '---------------------------------------------------
        Dim da As New MySqlDataAdapter
        Dim dsSaldo As New DataSet
        cad1 = "select vIngresosF.cod_art,nom_art,nom_uni,cantI,IFNULL(cantS,0)as cantS,"
        cad2 = " cantI-IFNULL(cantS,0) as saldo,maximo,minimo,pre_venta,pre_costo,pre_ult,afecto_igv,nom_sgrupo,subgrupo.cod_sgrupo "
        cad3 = " from vIngresosF left join vSalidasF on vIngresosF.cod_art=vSalidasF.cod_art"
        cad4 = " inner join articulo on vIngresosF.cod_art=articulo.cod_art"
        cad5 = " inner join unidad on articulo.cod_uni=unidad.cod_uni"
        cad6 = " inner join subgrupo on articulo.cod_sgrupo=subgrupo.cod_sgrupo"
        cad7 = " group by vIngresosF.cod_art"
        cad8 = " order by nom_art"
        cad = cad1 + cad2 + cad3 + cad4 + cad5 + cad6 + cad7 + cad8
        Dim comSaldo As New MySqlCommand(cad)
        comSaldo.Connection = clConex
        da.SelectCommand = comSaldo
        da.Fill(dsSaldo, "saldo")
        clConex.Close()
        Return dsSaldo
    End Function
    Public Function recuperaSaldoAlmacen_xdia(ByVal f As Date, ByVal ca As String, ByVal ag As Boolean)
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim cad, cad1, cad2, cad3, cad4, cad5, cad6, cad7, cad8 As String
        Dim com, com2, com_a, com_b As New MySqlCommand
        Dim mfecha = f.ToString("yyyy-MM-dd")
        '-------------------------------------------------
        cad = "DROP VIEW IF EXISTS vIngresos"
        com_a.Connection = clConex
        com_a.CommandText = cad
        com_a.ExecuteNonQuery()
        '
        cad1 = " CREATE VIEW vIngresos AS "
        cad2 = "select cod_art,sum(cant)AS cantI,cod_alma,fec_doc"
        cad3 = " from ingreso inner join ingreso_det on ingreso.operacion = ingreso_det.operacion"
        cad4 = " where fec_doc<='" & mfecha & "'" & " and cod_alma='" & ca & "'"
        cad5 = " group by fec_doc,cod_art order by cod_art,fec_doc"
        cad = cad1 + cad2 + cad3 + cad4 + cad5
        com.Connection = clConex
        com.CommandText = cad
        com.ExecuteNonQuery()
        '
        cad = "DROP VIEW IF EXISTS vIngresosF"
        com_b.Connection = clConex
        com_b.CommandText = cad
        com_b.ExecuteNonQuery()
        '
        cad1 = " CREATE VIEW vIngresosF AS "
        cad2 = "select cod_art,sum(cantI)AS cantI"
        cad3 = " from vIngresos"
        cad4 = " where fec_doc<='" & mfecha & "'"
        cad5 = " group by cod_art order by cod_art"
        cad = cad1 + cad2 + cad3 + cad4 + cad5
        com2.Connection = clConex
        com2.CommandText = cad
        com2.ExecuteNonQuery()
        '-------------------------------------------------
        cad = "DROP VIEW IF EXISTS vSalidas"
        com_a.Connection = clConex
        com_a.CommandText = cad
        com_a.ExecuteNonQuery()
        '
        cad1 = " CREATE VIEW vSalidas AS "
        cad2 = "select cod_art,sum(cant)AS cantS,cod_alma,fec_doc"
        cad3 = " from salida inner join salida_det on salida.operacion = salida_det.operacion"
        cad4 = " where fec_doc<='" & mfecha & "'" & " and cod_alma='" & ca & "'"
        cad5 = " group by fec_doc,cod_art order by cod_art,fec_doc"
        cad = cad1 + cad2 + cad3 + cad4 + cad5
        com.Connection = clConex
        com.CommandText = cad
        com.ExecuteNonQuery()
        '
        cad = "DROP VIEW IF EXISTS vSalidasF"
        com_b.Connection = clConex
        com_b.CommandText = cad
        com_b.ExecuteNonQuery()
        '
        cad1 = " CREATE VIEW vSalidasF AS "
        cad2 = "select cod_art,sum(cantS)AS cantS"
        cad3 = " from vSalidas"
        cad4 = " where fec_doc<='" & mfecha & "'"
        cad5 = " group by cod_art order by cod_art"
        cad = cad1 + cad2 + cad3 + cad4 + cad5
        com2.Connection = clConex
        com2.CommandText = cad
        com2.ExecuteNonQuery()
        '---------------------------------------------------
        Dim da As New MySqlDataAdapter
        Dim dsSaldo As New DataSet
        cad1 = "select vIngresosF.cod_art,nom_art,nom_uni,cantI,IFNULL(cantS,0)as cantS,"
        cad2 = " cantI-IFNULL(cantS,0) as saldo,pre_venta,pre_costo,pre_ult,maximo,minimo,afecto_igv,nom_sgrupo,subgrupo.cod_sgrupo "
        cad3 = " from vIngresosF left join vSalidasF on vIngresosF.cod_art=vSalidasF.cod_art"
        cad4 = " inner join articulo on vIngresosF.cod_art=articulo.cod_art"
        cad5 = " inner join unidad on articulo.cod_uni=unidad.cod_uni"
        cad6 = " inner join subgrupo on articulo.cod_sgrupo=subgrupo.cod_sgrupo"
        cad7 = " group by vIngresosF.cod_art"
        cad8 = " order by nom_art"
        cad = cad1 + cad2 + cad3 + cad4 + cad5 + cad6 + cad7 + cad8
        Dim comSaldo As New MySqlCommand(cad)
        comSaldo.Connection = clConex
        da.SelectCommand = comSaldo
        da.Fill(dsSaldo, "saldo")
        clConex.Close()
        Return dsSaldo
    End Function
    Public Function recuperaSaldoAlmacen_xdia_historial(ByVal pr As String, ByVal f As Date, ByVal ca As String, ByVal ag As Boolean)
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim cad, cad1, cad2, cad3, cad4, cad5, cad6, cad7, cad8 As String
        Dim com, com2, com_a, com_b As New MySqlCommand
        Dim mfecha = f.ToString("yyyy-MM-dd")
        '-------------------------------------------------
        cad = "DROP VIEW IF EXISTS vIngresos"
        com_a.Connection = clConex
        com_a.CommandText = cad
        com_a.ExecuteNonQuery()
        '
        cad1 = " CREATE VIEW vIngresos AS "
        cad2 = "select cod_art,sum(cant)AS cantI,cod_alma,fec_doc"
        cad3 = " from h_ingreso inner join h_ingreso_det on h_ingreso.operacion = h_ingreso_det.operacion"
        cad4 = " where h_ingreso.proceso='" & pr & "' and fec_doc<='" & mfecha & "'" & " and cod_alma='" & ca & "'"
        cad5 = " group by fec_doc,cod_art order by cod_art,fec_doc"
        cad = cad1 + cad2 + cad3 + cad4 + cad5
        com.Connection = clConex
        com.CommandText = cad
        com.ExecuteNonQuery()
        '
        cad = "DROP VIEW IF EXISTS vIngresosF"
        com_b.Connection = clConex
        com_b.CommandText = cad
        com_b.ExecuteNonQuery()
        '
        cad1 = " CREATE VIEW vIngresosF AS "
        cad2 = "select cod_art,sum(cantI)AS cantI"
        cad3 = " from vIngresos"
        cad4 = " group by cod_art order by cod_art"
        cad = cad1 + cad2 + cad3 + cad4
        com2.Connection = clConex
        com2.CommandText = cad
        com2.ExecuteNonQuery()
        '-------------------------------------------------
        cad = "DROP VIEW IF EXISTS vSalidas"
        com_a.Connection = clConex
        com_a.CommandText = cad
        com_a.ExecuteNonQuery()
        '
        cad1 = " CREATE VIEW vSalidas AS "
        cad2 = "select cod_art,sum(cant)AS cantS,cod_alma,fec_doc"
        cad3 = " from h_salida inner join h_salida_det on h_salida.operacion = h_salida_det.operacion"
        cad4 = " where h_salida.proceso='" & pr & "' and h_salida_det.proceso='" & pr & "' and fec_doc<='" & mfecha & "'" & " and cod_alma='" & ca & "'"
        cad5 = " group by fec_doc,cod_art order by cod_art,fec_doc"
        cad = cad1 + cad2 + cad3 + cad4 + cad5
        com.Connection = clConex
        com.CommandText = cad
        com.ExecuteNonQuery()
        '
        cad = "DROP VIEW IF EXISTS vSalidasF"
        com_b.Connection = clConex
        com_b.CommandText = cad
        com_b.ExecuteNonQuery()
        '
        cad1 = " CREATE VIEW vSalidasF AS "
        cad2 = "select cod_art,sum(cantS)AS cantS"
        cad3 = " from vSalidas"
        cad4 = " group by cod_art order by cod_art"
        cad = cad1 + cad2 + cad3 + cad4
        com2.Connection = clConex
        com2.CommandText = cad
        com2.ExecuteNonQuery()
        '---------------------------------------------------
        Dim da As New MySqlDataAdapter
        Dim dsSaldo As New DataSet
        cad1 = "select vIngresosF.cod_art,nom_art,nom_uni,cantI,IFNULL(cantS,0)as cantS,"
        cad2 = " cantI-IFNULL(cantS,0) as saldo,pre_venta,pre_costo,pre_ult,maximo,minimo,afecto_igv,nom_sgrupo,subgrupo.cod_sgrupo "
        cad3 = " from vIngresosF left join vSalidasF on vIngresosF.cod_art=vSalidasF.cod_art"
        cad4 = " inner join articulo on vIngresosF.cod_art=articulo.cod_art"
        cad5 = " inner join unidad on articulo.cod_uni=unidad.cod_uni"
        cad6 = " inner join subgrupo on articulo.cod_sgrupo=subgrupo.cod_sgrupo"
        cad7 = " group by vIngresosF.cod_art"
        cad8 = " order by nom_art"
        cad = cad1 + cad2 + cad3 + cad4 + cad5 + cad6 + cad7 + cad8
        Dim comSaldo As New MySqlCommand(cad)
        comSaldo.Connection = clConex
        da.SelectCommand = comSaldo
        da.Fill(dsSaldo, "saldo")
        clConex.Close()
        Return dsSaldo
    End Function
    Public Function recuperaStockArticulo(ByVal h As Boolean, ByVal pr As String, _
                ByVal xi As Boolean, ByVal xa As Boolean, ByVal ca As String, _
                ByVal car As String, ByVal ni As Integer) As Decimal
        'usado en el ingreso o compras
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Decimal, cad As String
        com.Connection = clConex
        If h Then
            If xi Then
                cad = "Select saldo from h_ingreso_det where ingreso=" & ni
            Else
                If xa Then
                    cad = "Select sum(saldo)as saldo from h_ingreso as h inner join h_ingreso_det as hd on h.operacion=hd.operacion where h.proceso='" & pr & "' and cod_alma='" & ca & "' and cod_art='" & car & "' group by cod_art"
                Else
                    cad = "Select sum(saldo)as saldo from h_ingreso_det as hd where hd.proceso='" & pr & "' and cod_art='" & car & "' group by cod_art"
                End If
            End If
        Else
            If xi Then
                cad = "Select saldo from ingreso_det where ingreso=" & ni
            Else
                If xa Then
                    cad = "Select sum(saldo)as saldo from ingreso inner join ingreso_det on ingreso.operacion=ingreso_det.operacion where cod_alma='" & ca & "' and cod_art='" & car & "' group by cod_art"
                Else
                    cad = "Select sum(saldo)as saldo from ingreso_det where cod_art='" & car & "' group by cod_art"
                End If
            End If
        End If
        com.CommandText = cad
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Decimal)
        clConex.Close()
        Return result
    End Function
    Public Function recuperaSaldoIni_xArtxAlmacen(ByVal ca As String, ByVal car As String) As Decimal
        'usado en el ingreso o compras
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Decimal, cad As String
        com.Connection = clConex
        cad = "Select sum(cant) as cantidad" _
                & " from ingreso inner join ingreso_det on ingreso.operacion=ingreso_det.operacion" _
                & " where cod_alma='" & ca & "' and cod_art='" & car & "' and cod_doc='10' group by cod_art"
        com.CommandText = cad
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Decimal)
        clConex.Close()
        Return result
    End Function
    Public Function recuperaIngresos_xArtxAlmacen(ByVal ca As String, ByVal car As String) As Decimal
        'usado en el ingreso o compras
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Decimal, cad As String
        com.Connection = clConex
        cad = "Select sum(cant) as cantidad" _
                & " from ingreso inner join ingreso_det on ingreso.operacion=ingreso_det.operacion" _
                & " inner join documento_i on ingreso.cod_doc=documento_i.cod_doc" _
                & " where cod_alma='" & ca & "' and cod_art='" & car & "' and (esIngreso) group by cod_art"
        com.CommandText = cad
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Decimal)
        clConex.Close()
        Return result
    End Function
    Public Function recuperaSalidas_xArtxAlmacen(ByVal ca As String, ByVal car As String) As Decimal
        'usado en el ingreso o compras
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Decimal, cad As String
        com.Connection = clConex
        cad = "Select sum(cant) as cantidad" _
                & " from salida inner join salida_det on salida.operacion=salida_det.operacion" _
                & " inner join documento_s on salida.cod_doc=documento_s.cod_doc" _
                & " where cod_alma='" & ca & "' and cod_art='" & car & "' and (esSalidaAlma) group by cod_art"
        com.CommandText = cad
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Decimal)
        clConex.Close()
        Return result
    End Function

    Public Function recuperaSaldoArticulo_xAlmacen(ByVal ca As String, ByVal car As String) As Decimal
        'usado en el ingreso o compras
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Decimal, cad As String
        com.Connection = clConex
        cad = "Select sum(saldo)as saldo" _
                & " from ingreso inner join ingreso_det on ingreso.operacion=ingreso_det.operacion" _
                & " where cod_alma='" & ca & "' and cod_art='" & car & "' group by cod_art"
        com.CommandText = cad
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Decimal)
        clConex.Close()
        Return result
    End Function

    Public Function recLotesArticulo(ByVal xa As Boolean, ByVal ca As String, _
                        ByVal car As String, ByVal scs As Boolean, Optional ByVal x As String = "") As DataSet
        'usado en el ingreso o compras
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter
        Dim com As New MySqlCommand, cad As String
        com.Connection = clConex
        cad = "Select ingreso,cod_art,saldo" _
                & " from ingreso inner join ingreso_det on ingreso.operacion=ingreso_det.operacion" _
                & " where cod_art='" & car & "'" & IIf(xa, " and cod_alma='" & ca & "'", "") _
                & IIf(scs, " and saldo>0", "") & " order by 2"
        Dim comSaldo As New MySqlCommand(cad)
        comSaldo.Connection = clConex
        da.SelectCommand = comSaldo
        da.Fill(ds, "articulo")
        clConex.Close()
        Return ds
    End Function
    Public Function recuperaStockArticulo_xAlmacen(ByVal h As Boolean, ByVal pr As String, _
            ByVal agr As Boolean, ByVal ca As String, ByVal car As String) As DataSet
        'usado en las recetas
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, cad, cad1, cad2, cad3 As String
        com.Connection = clConex
        Dim da As New MySqlDataAdapter
        Dim dsSaldo As New DataSet
        If h Then
            If agr Then
                cad1 = "Select sum(hd.saldo) as saldo"
                cad2 = " from h_ingreso as h inner join h_ingreso_det as hd on h.operacion=hd.operacion"
                cad3 = "  where h.proceso='" & pr & "' and h.cod_alma='" & ca & "' and cod_art='" & car & "' group by h.cod_art"
            Else
                cad1 = "Select ingreso,hd.saldo,pre_costo"
                cad2 = " from h_ingreso as h inner join ingreso_det as hd on h.operacion=hd.operacion inner join articulo on hd.cod_art=articulo.cod_art"
                cad3 = " where h.proceso='" & pr & "' and h.cod_alma='" & ca & "' and hd.cod_art='" & car & "' order by h.cod_art, hd.saldo asc"
            End If
        Else
            If agr Then
                cad1 = "Select sum(hd.saldo) as saldo"
                cad2 = " from ingreso as h inner join ingreso_det as hd on h.operacion=hd.operacion"
                cad3 = "  where h.cod_alma='" & ca & "' and cod_art='" & car & "' group by hd.cod_art"
            Else
                cad1 = "Select ingreso,hd.saldo,pre_costo"
                cad2 = " from ingreso as h inner join ingreso_det as hd on h.operacion=hd.operacion inner join articulo on hd.cod_art=articulo.cod_art"
                cad3 = " where h.cod_alma='" & ca & "' and hd.cod_art='" & car & "' order by hd.cod_art,hd.saldo asc"
            End If
        End If
        cad = cad1 + cad2 + cad3
        Dim comSaldo As New MySqlCommand(cad)
        comSaldo.Connection = clConex
        da.SelectCommand = comSaldo
        da.Fill(dsSaldo, "saldo")
        clConex.Close()
        Return dsSaldo
    End Function
    Public Function insertaLimpios(Optional ByVal cod_artLim As String = "", _
                         Optional ByVal cantLim As Decimal = 0.0, _
                         Optional ByVal cod_art As String = "", _
                         Optional ByVal cant As Decimal = 0.0) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim sql As String, result As Integer
        'Dim mfecha As String = fec_inv.ToString("yy-MM-dd")
        'insertaLimpios(cod_artL, cantL, cCodigo, nCantidad)
        sql = "Insert Into art_limpio(cod_art,cant,cod_artL,cantL)" & _
            "values('" & _
            cod_art & "'," & cant & ",'" & cod_artLim & "'," & cantLim & ")"
        com.CommandText = sql
        result = com.ExecuteNonQuery
        clConex.Close()
        Return True
    End Function
    Public Function actualizaCantLimpios(Optional ByVal cod_artLim As String = "", _
                         Optional ByVal cantLim As Decimal = 0.0, _
                         Optional ByVal cod_art As String = "", _
                         Optional ByVal cant As Decimal = 0.0) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim sql As String, result As Integer
        'Dim mfecha As String = fec_inv.ToString("yy-MM-dd")
        'insertaLimpios(cod_artL, cantL, cCodigo, nCantidad)
        sql = "update art_limpio set cantL=" & cantLim & _
               " where cod_art='" & cod_art & "'"
        com.CommandText = sql
        result = com.ExecuteNonQuery
        clConex.Close()
        Return True
    End Function
    Public Function eliminaRelacionLimpios(Optional ByVal cod_artLim As String = "", Optional ByVal cod_Art As String = "") As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim sql As String, result As Integer
        sql = "delete from art_limpio where cod_artL='" & cod_artLim & "'"
        com.CommandText = sql
        result = com.ExecuteNonQuery
        clConex.Close()
        Return True
    End Function
    Public Function existeEnLimpios(ByVal cod_art As String) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer, cad As String
        com.Connection = clConex
        cad = "Select count(cod_art) from art_limpio where cod_art='" & cod_art & "'"
        com.CommandText = cad
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Integer)
        clConex.Close()
        If result = 0 Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Function devuelveCodigoAlmacen(ByVal cod_art As String) As String
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim cad, cad1, cad2, cad3, resp As String
        cad1 = "select cod_alma"
        cad2 = " from articulo"
        cad3 = " where cod_art='" & cod_art & "'"
        cad = cad1 + cad2 + cad3
        com.CommandText = cad
        resp = com.ExecuteScalar
        clConex.Close()
        Return resp
    End Function
    Public Function devuelveEsGasto(ByVal cod_art As String) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim cad, cad1, cad2, cad3 As String
        Dim resp As Boolean
        cad1 = "select es_gasto"
        cad2 = " from articulo"
        cad3 = " where cod_art='" & cod_art & "'"
        cad = cad1 + cad2 + cad3
        com.CommandText = cad
        resp = com.ExecuteScalar
        clConex.Close()
        Return resp
    End Function
    Public Function devuelveTipoArt(ByVal cod_art As String) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim cad, cad1, cad2, cad3 As String
        Dim resp As Boolean
        cad1 = "select esProductoTerminado"
        cad2 = " from articulo a inner join tipo_articulo t on a.cod_tart=t.cod_tart"
        cad3 = " where cod_art='" & cod_art & "'"
        cad = cad1 + cad2 + cad3
        com.CommandText = cad
        resp = com.ExecuteScalar
        clConex.Close()
        Return resp
    End Function
    Function devuelveStock(ByVal cod_art As String) As Decimal
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Decimal
        com.Connection = clConex
        Dim cad, cad1, cad2, cad3 As String
        'select sum(saldo) ,i.cod_alma,cod_art from ingreso i inner join ingreso_det d on i.operacion=d.operacion
        'inner join almacen a on i.cod_alma=a.cod_alma
        'where esProduccion and d.cod_art='000D38 group by i.cod_alma,cod_art having sum(saldo)>0
        cad1 = " select max(resultado.saldo) maximo from (select sum(saldo) saldo from ingreso i inner join ingreso_det d on i.operacion=d.operacion "
        cad2 = " inner join almacen a on i.cod_alma=a.cod_alma "
        cad3 = "where esProduccion and d.cod_art='" & cod_art & "' group by i.cod_alma,cod_art having sum(saldo)>0) resultado"
        cad = cad1 + cad2 + cad3
        com.CommandText = cad
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Decimal)
        clConex.Close()
        Return result
    End Function
    Function devuelveAlmacenStock(ByVal cod_art As String, ByVal nstock As Decimal) As String
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As String
        com.Connection = clConex
        Dim cad, cad1, cad2, cad3 As String
        'select sum(saldo) ,i.cod_alma,cod_art from ingreso i inner join ingreso_det d on i.operacion=d.operacion
        'inner join almacen a on i.cod_alma=a.cod_alma
        'where esProduccion and d.cod_art='000D38 group by i.cod_alma,cod_art having sum(saldo)>0
        cad1 = " select i.cod_alma saldo from ingreso i inner join ingreso_det d on i.operacion=d.operacion "
        cad2 = " inner join almacen a on i.cod_alma=a.cod_alma "
        cad3 = "where esProduccion and d.cod_art='" & cod_art & "' group by i.cod_alma,cod_art having sum(saldo)=" & nstock
        cad = cad1 + cad2 + cad3
        com.CommandText = cad
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), String)
        clConex.Close()
        Return result
    End Function
    Public Function devuelveCodigoNoLimpio(Optional ByVal car As String = "") As String
        Return ""
    End Function
    Public Function devuelveCodigoLimpio(Optional ByVal cod_art As String = "") As String
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As String
        com.Connection = clConex
        Dim cad, cad1, cad2 As String
        cad1 = " select cod_artL from art_limpio"
        cad2 = " where cod_art ='" & cod_art & "'"
        cad = cad1 + cad2
        com.CommandText = cad
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), String)
        clConex.Close()
        Return result
    End Function
    Public Function devuelveCantLimpio(ByVal cod_art As String) As Decimal
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim cad, cad1, cad2 As String, resp As Decimal
        cad1 = " select cantL from art_limpio"
        cad2 = " where cod_artL ='" & cod_art & "'"
        cad = cad1 + cad2
        com.CommandText = cad
        Dim obj As Object = com.ExecuteScalar
        resp = CType(IIf(IsDBNull(obj), 0, obj), Decimal)
        clConex.Close()
        Return resp
    End Function
    Public Function devPesoBotellaCerrada(ByVal car As String) As Decimal
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim cad, cad1, cad2, cad3 As String, resp As Decimal
        cad1 = "select peso_lleno"
        cad2 = " from articulo"
        cad3 = " where cod_art='" & car & "'"
        cad = cad1 + cad2 + cad3
        com.CommandText = cad
        Dim obj As Object = com.ExecuteScalar
        resp = CType(IIf(IsDBNull(obj), 0, obj), Decimal)
        clConex.Close()
        Return resp
    End Function
    Public Function devPesoBotellaAbierta(ByVal car As String) As Decimal
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim cad, cad1, cad2, cad3 As String, resp As Decimal
        cad1 = "select peso_vacio"
        cad2 = " from articulo"
        cad3 = " where cod_art='" & car & "'"
        cad = cad1 + cad2 + cad3
        com.CommandText = cad
        Dim obj As Object = com.ExecuteScalar
        resp = CType(IIf(IsDBNull(obj), 0, obj), Decimal)
        clConex.Close()
        Return resp
    End Function
    Public Function devuelveCantCodigoLimpio(ByVal car As String) As String
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim cad, cad1, cad2, cad3, resp As String
        cad1 = "select cantL"
        cad2 = " from art_limpio"
        cad3 = " where art_limpio.cod_artL='" & car & "'"
        cad = cad1 + cad2 + cad3
        com.CommandText = cad
        resp = com.ExecuteScalar
        clConex.Close()
        Return resp
    End Function
    Public Function existeEnIngresos(ByVal car As String) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer, cad As String
        com.Connection = clConex
        cad = "Select count(cod_art) from ingreso_det where cod_art='" & car & "'"
        com.CommandText = cad
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Integer)
        clConex.Close()
        If result = 0 Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Function existeCodigo(ByVal car As String) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer, cad As String
        com.Connection = clConex
        cad = "Select count(cod_art) from articulo where cod_art='" & car & "'"
        com.CommandText = cad
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Integer)
        clConex.Close()
        If result = 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function existeCodigoActivo(ByVal car As String) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer, cad As String
        com.Connection = clConex
        cad = "Select count(cod_art) from articulo where activo and cod_art='" & car & "'"
        com.CommandText = cad
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Integer)
        clConex.Close()
        If result = 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function existeCodigoCatalogo(ByVal car As String, ByVal calm As String) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer, cad As String
        com.Connection = clConex
        cad = "Select count(cod_art) from articulo where cod_art='" & car & "' and cod_alma='" & calm & "'"
        com.CommandText = cad
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Integer)
        clConex.Close()
        If result = 0 Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Function existeEnSalidas(ByVal car As String) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer, cad As String
        com.Connection = clConex
        cad = "Select count(cod_art) from salida_det where cod_art='" & car & "'"
        com.CommandText = cad
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Integer)
        clConex.Close()
        If result = 0 Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Function existeEnIngresosHistorial(ByVal car As String) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer, cad As String
        com.Connection = clConex
        cad = "Select count(cod_art) from h_ingreso_det where cod_art='" & car & "'"
        com.CommandText = cad
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Integer)
        clConex.Close()
        If result = 0 Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Function recetaTieneInsumos(ByVal cre As String) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer, cad As String
        com.Connection = clConex
        cad = "Select count(cod_rec) from receta where cod_rec='" & cre & "'"
        com.CommandText = cad
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Integer)
        clConex.Close()
        If result = 0 Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Function actualizaCuentaVentas(ByVal ca As String, _
                    ByVal cu As String, ByVal cc As String, _
                    Optional ByVal x As Boolean = True, Optional ByVal x2 As String = "") As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim result As Integer
        Dim cad, cad1, cad2 As String
        cad1 = "update articulo set cuenta_v='" & cu & "',cuenta_v_c='" & cc & "'"
        cad2 = " where " & IIf(x, "cod_sgrupo='" & x2 & "'", "cod_art='" & ca & "'")
        cad = cad1 + cad2
        com.CommandText = cad
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function
    Public Function actualizaCuentaCompras(ByVal ca As String,
                 ByVal cc As String, ByVal cc1 As String, ByVal cc2 As String,
                 ByVal ccp As String, ByVal x As Boolean, ByVal x2 As String) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim result As Integer
        Dim cad, cad1, cad2, cad3 As String
        cad1 = "update articulo set cuenta_c='" & cc & "',"
        cad2 = "cuenta_c_a1='" & cc1 & "',cuenta_c_a2='" & cc2 & "',cuenta_c_p='" & ccp & "'"
        cad3 = " where " & IIf(x, "cod_sgrupo='" & x2 & "'", "cod_art='" & ca & "'")
        cad = cad1 + cad2 + cad3
        com.CommandText = cad
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function
    Public Function actualizaPrecioCompra(ByVal ca As String, ByVal pc As Decimal) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim result As Integer
        Dim cad, cad1, cad2 As String
        cad1 = "update articulo set pre_costo=" & pc
        cad2 = " where cod_art='" & ca & "'"
        cad = cad1 + cad2
        com.CommandText = cad
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function
    Public Function actualizaPrecioCompraMax(ByVal ca As String, ByVal pc As Decimal) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim result As Integer
        Dim cad, cad1, cad2 As String
        cad1 = "update articulo set pre_costoMax=" & pc
        cad2 = " where cod_art='" & ca & "'"
        cad = cad1 + cad2
        com.CommandText = cad
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function

    Public Function actualizaCantidad_stock(ByVal ca As String, ByVal stock As Decimal) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim result As Integer
        Dim cad, cad1, cad2 As String
        cad1 = " update articulo set cant_stock=" & stock
        cad2 = " where cod_art='" & ca & "'"
        cad = cad1 + cad2
        com.CommandText = cad
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function

    Public Function actualizaCantidad_stockAlmacen(ByVal calma As String, ByVal ca As String, ByVal stock As Decimal) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim result As Integer
        Dim cad, cad1, cad2 As String
        cad1 = " update art_almacen set cant_stock=" & stock
        cad2 = " where cod_alma='" & calma & "' and  cod_art='" & ca & "'"
        cad = cad1 + cad2
        com.CommandText = cad
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function

    Public Function actualizaPrecioVenta(ByVal ca As String, ByVal pv As Decimal) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim result As Integer
        Dim cad, cad1, cad2 As String
        cad1 = "update articulo set pre_venta=" & pv
        cad2 = " where cod_art='" & ca & "'"
        cad = cad1 + cad2
        com.CommandText = cad
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function
    Public Function actualizaCodigoExterno(ByVal ca As String, ByVal cax As String) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim result As Integer
        Dim cad, cad1, cad2 As String
        cad1 = "update articulo set " & cax
        cad2 = " where cod_art='" & ca & "'"
        cad = cad1 + cad2
        com.CommandText = cad
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function
    Public Function existeCodigoExterno(ByVal cax As String, ByVal condicion As String) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer, cad As String
        Dim codDefault As String = "-"
        com.Connection = clConex
        cad = "Select count(" & cax & ") from articulo where" & condicion
        com.CommandText = cad
        result = com.ExecuteScalar
        clConex.Close()
        If result = 0 Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Function actPesoBotellas(ByVal ca As String, _
                     ByVal pL As Decimal, _
                     ByVal pV As Decimal) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim cad, cad1, cad2 As String, result As Integer
        cad1 = "update articulo set peso_lleno=" & pL & ",peso_vacio=" & pV
        cad2 = " where cod_art='" & ca & "'"
        cad = cad1 + cad2
        com.CommandText = cad
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function
    Public Function esBotella(ByVal ca As String) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim cad As String, result As Integer
        cad = "select es_botella from articulo where cod_art='" & ca & "'"
        com.CommandText = cad
        result = com.ExecuteScalar
        clConex.Close()
        If result = 0 Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Function recCatalogoPrincipal() As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter
        Dim com As New MySqlCommand("select * from vCatalogoPrincipal", clConex)
        com.Connection = clConex
        da.SelectCommand = com
        da.Fill(ds, "articulo")
        clConex.Close()
        Return ds
    End Function
    Public Function recCatalogoRelacionados(ByVal ca As String, ByVal sa As Boolean, _
                            ByVal xg As Boolean, ByVal cg As String) As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim da As New MySqlDataAdapter
        Dim ds As New DataSet
        Dim cad As String
        cad = "select * from vArticulosRel"
        Dim com As New MySqlCommand(cad)
        com.Connection = clConex
        da.SelectCommand = com
        da.Fill(ds, "articulo")
        clConex.Close()
        Return ds
    End Function
    Public Function maxCodigo() As String
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer
        com.Connection = clConex
        com.CommandText = "select max(cod_art) from articulo  WHERE cod_Art REGEXP ('^[0-9]+$')"
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), "000000", obj), String)
        Dim resp As String = Right("000000" & Trim(Str(Microsoft.VisualBasic.Val(result) + 1)), 6)
        clConex.Close()
        Return resp
    End Function

End Class
