Imports MySql.Data.MySqlClient
Public Class nivAbastecimiento
    Public Shared Function dsNiveles() As DataSet
        'declaramos la variable local ds
        'de tipo DataSet con el nombre Catalogo
        Dim ds As New DataSet
        'añadimos el DataTable al DataSet
        ds.Tables.Add(dtNiveles())
        Return ds
    End Function
    Public Shared Function dtNiveles() As DataTable
        'declaramos la variable local dtArticulo
        'de tipo DataTable y nombre "articulo"
        Dim dt As New DataTable("niveles")
        'creamos las columnas del DataTable dtArticulo
        dt.Columns.Add(New DataColumn("cod_art", GetType(String)))
        dt.Columns.Add(New DataColumn("nom_art", GetType(String)))
        dt.Columns.Add(New DataColumn("nom_uni", GetType(String)))
        dt.Columns.Add(New DataColumn("pre_costo", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("pre_ult", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("stockIni", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("Ingresos", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("Salidas", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("saldo", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("maximo", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("minimo", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("cod_sgrupo", GetType(String)))
        dt.Columns.Add(New DataColumn("nom_sgrupo", GetType(String)))
        dt.Columns.Add(New DataColumn("nivel", GetType(String)))
        dt.Columns.Add(New DataColumn("req", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("reqAlmacen", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("nom_uniAlma", GetType(String)))
        dt.Columns.Add(New DataColumn("raz_soc", GetType(String)))
        dt.Columns.Add(New DataColumn("fec_ultcom", GetType(Datetime)))
        dt.Columns.Add(New DataColumn("cantcomp", GetType(Decimal)))
        Return dt
    End Function
    Public Function recuperaNiveles(ByVal xAlmacen As Boolean, ByVal cod_alma As String, ByVal nivel As String, _
                                    ByVal preciosConIMP As Boolean, ByVal pCostoCI As String) As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim da As New MySqlDataAdapter
        Dim dsNiveles As New DataSet
        Dim nSaldo As String = "if(isnull(sum(ingreso_det.saldo)),0,sum(ingreso_det.saldo))"
        Dim cAlma As String = "0001"
        Dim lsub As String = "Sub Stock", lnormal As String = "Normal", lsobre As String = "Sobre Stock"
        Dim cad, cad1, cad2, cad3, cad4, cad5, cad6, cad7, cad8, cad9, cad10, cad11, cad12 As String
        cad1 = "select articulo.cod_art,nom_art,nom_uni," & IIf(preciosConIMP, pCostoCI, "articulo.pre_costo") & " as pre_costo,"
        cad2 = " pre_ult," & nSaldo & " as saldo,maximo,minimo,articulo.cod_sgrupo,nom_sgrupo,"
        cad3 = " IF(" & nSaldo & "<=minimo,'" & lsub & "',if(" & nSaldo & "<maximo,'" & lnormal & "','" & lsobre & "')) as nivel,"
        cad4 = " IF(" & nSaldo & "<=minimo,maximo-" & nSaldo & ",0.00) as req,raz_soc"
        cad5 = " from articulo inner join unidad on articulo.cod_uni=unidad.cod_uni "
        cad6 = " inner join subgrupo on articulo.cod_sgrupo=subgrupo.cod_sgrupo"
        cad7 = " left join proveedor on articulo.cod_prov=proveedor.cod_prov"
        cad8 = " left join ingreso_det on articulo.cod_art=ingreso_det.cod_art "
        cad9 = " where articulo.cod_alma='" & cod_alma & "' and (maximo>0 or minimo>0)"
        cad10 = " group by articulo.cod_art having(" & nSaldo
        cad11 = IIf(nivel = "Sub Stock", " <= minimo)", IIf(nivel = "Normal", " > minimo) and (" & nSaldo & "< maximo)", " >= maximo)"))
        cad12 = " order by nom_art"
        cad = cad1 + cad2 + cad3 + cad4 + cad5 + cad6 + cad7 + cad8 + cad9 + cad10 + cad11 + cad12
        Dim comSaldo As New MySqlCommand(cad)
        comSaldo.Connection = clConex
        da.SelectCommand = comSaldo
        da.Fill(dsNiveles, "niveles")
        clConex.Close()
        Return dsNiveles
    End Function
    Public Function recuperaProductos_paraNiveles(ByVal xAlmacen As Boolean, ByVal cod_alma As String, ByVal xProd As Boolean, ByVal xGrupo As Boolean, ByVal cod_sgrupo As String, _
                ByVal xgerencia As Boolean, ByVal xArea As Boolean, ByVal cod_area As String, ByVal xunidad As Boolean, ByVal cunidad As String, ByVal preciosConIMP As Boolean, Optional ByVal x As String = "") As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim da As New MySqlDataAdapter
        Dim ds As New DataSet
        Dim cad, cad1, cad2, cad3, cad4, cad5, cad6, cad7, cad8 As String
        cad1 = "select a.cod_art,nom_art,nom_uni,a.pre_costo,"
        cad2 = " pre_ult,fec_ultcom,a.cod_sgrupo,nom_sgrupo,raz_soc," & IIf(xArea, "max as maximo,min as minimo", "maximo,minimo ")
        cad3 = " from articulo a inner join unidad on a.cod_uni=unidad.cod_uni "
        cad4 = IIf(xArea, " inner join art_Area arta on a.cod_Art=arta.cod_art", "")
        cad5 = " inner join subgrupo on a.cod_sgrupo=subgrupo.cod_sgrupo inner join tipo_articulo t on t.cod_tart=a.cod_tart "
        cad6 = " left join proveedor on a.cod_prov=proveedor.cod_prov"
        cad7 = " where (a.activo)  and (maximo>0 or minimo>=0)  " & IIf(xAlmacen, " and a.cod_alma='" & cod_alma & "'", "") _
                     & IIf(xgerencia, " and (repGerencia)", "") _
                     & IIf(xProd, " and  (t.esProduccion)", " and !(t.esProduccion)") _
                     & IIf(xArea, " and arta.cod_alma=  '" & cod_alma & "' and arta.cod_area='" & cod_area & "'", IIf(xAlmacen, " and a.cod_alma='" & cod_alma & "'", ""))
        cad8 = IIf(xGrupo, " and a.cod_sgrupo= '" & cod_sgrupo & "'", "") & IIf(xArea, " and arta.cod_area= '" & cod_area & "'", "") & IIf(xunidad, " and a.cod_uni= '" & cunidad & "'", "") & "order by nom_art"
        cad = cad1 + cad2 + cad3 + cad4 + cad5 + cad6 + cad7 + cad8
        Dim comSaldo As New MySqlCommand(cad)
        comSaldo.Connection = clConex
        da.SelectCommand = comSaldo
        da.Fill(ds, "articulo")
        clConex.Close()
        Return ds
    End Function
    Public Function existeNivAlmacen() As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer, cad As String
        com.Connection = clConex
        cad = "Select count(cod_art) from art_area"
        com.CommandText = cad
        result = com.ExecuteScalar
        clConex.Close()
        If result > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
