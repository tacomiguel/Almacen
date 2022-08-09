Imports MySql.Data.MySqlClient
Imports libreriaClases
Public Class Resumen
    Public Shared Function dsResumen() As DataSet
        'declaramos la variable local ds
        'de tipo DataSet con el nombre Catalogo
        Dim ds As New DataSet("resumen")
        'añadimos el DataTable al DataSet
        ds.Tables.Add(dtResumen())
        Return ds
    End Function
    Public Shared Function dtResumen() As DataTable
        'declaramos la variable local dtArticulo
        'de tipo DataTable y nombre "articulo"
        Dim dt As New DataTable("resumen")
        'creamos las columnas del DataTable dtArticulo
        dt.Columns.Add(New DataColumn("cod_art", GetType(String)))
        dt.Columns.Add(New DataColumn("nom_art", GetType(String)))
        dt.Columns.Add(New DataColumn("nom_sgrupo", GetType(String)))
        dt.Columns.Add(New DataColumn("nom_uni", GetType(String)))
        dt.Columns.Add(New DataColumn("m1", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("m2", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("m3", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("m4", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("m5", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("m6", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("m7", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("m8", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("m9", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("m10", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("m11", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("m12", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("total", GetType(Decimal)))
        Return dt
    End Function
    Public Function recuperaCatalogo_paraResumenAnual(ByVal xAlmacen As Boolean, ByVal cod_alma As String, ByVal periodo As Integer, ByVal valor As String, ByVal soloActivos As Boolean) As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim da As New MySqlDataAdapter
        Dim dsResumen As New DataSet
        Dim cad, cad0, cad1, cad2, cad3, cad4, cad5, cad6, cad7, cad8, cad9, cad10, cad11, cad12, cad13, cad14, cad15, cad16, cad17, cad18, cad19, cad20, cad21, cad22 As String
        'cad1 = "select cod_art,nom_art,nom_uni,0.0 as m1,0.0 as m2,0.0 as m3,0.0 as m4,0.0 as m5, 0.0 as m6,0.0 as m7,0.0 as m8,0.0 as m9,0.0 as m10,0.0 as m11,0.0 as m12,0.0 as total"
        'cad2 = " from articulo inner join unidad on articulo.cod_uni=unidad.cod_uni"
        'If soloActivos Then
        '    cad3 = " where articulo.cod_alma='" & cod_alma & "' and articulo.activo=1 order by nom_art"
        'Else
        '    cad3 = " where articulo.cod_alma='" & cod_alma & "' order by nom_art"
        'End If
        cad0 = "select raz_soc,nom_art,nom_sgrupo,nom_uni,pre_ult,"
        cad1 = "round(sum(if(MONTH(fec_doc)=1," & valor & ",0)),2) as m1,"
        cad2 = "round(sum(if(MONTH(fec_doc)=2," & valor & ",0)),2) as m2,"
        cad3 = "round(sum(if(MONTH(fec_doc)=3," & valor & ",0)),2) as m3,"
        cad4 = "round(sum(if(MONTH(fec_doc)=4," & valor & ",0)),2) as m4,"
        cad5 = "round(sum(if(MONTH(fec_doc)=5," & valor & ",0)),2) as m5,"
        cad6 = "round(sum(if(MONTH(fec_doc)=6," & valor & ",0)),2) as m6,"
        cad7 = "round(sum(if(MONTH(fec_doc)=7," & valor & ",0)),2) as m7,"
        cad8 = "round(sum(if(MONTH(fec_doc)=8," & valor & ",0)),2) as m8,"
        cad9 = "round(sum(if(MONTH(fec_doc)=9," & valor & ",0)),2) as m9,"
        cad10 = "round(sum(if(MONTH(fec_doc)=10," & valor & ",0)),2) as m10,"
        cad11 = "round(sum(if(MONTH(fec_doc)=11," & valor & ",0)),2) as m11,"
        cad12 = "round(sum(if(MONTH(fec_doc)=12," & valor & ",0)),2) as m12,"
        cad13 = "round(sum(" & valor & "),2) as total"
        cad14 = " from (select h.fec_doc,h.cod_doc,h.cod_prov,hd.cod_art,hd.cant,hd.precio "
        cad15 = " from h_ingreso h inner join h_ingreso_det hd On h.operacion=hd.operacion And h.proceso=hd.proceso "
        cad16 = " union Select h.fec_doc,h.cod_doc,h.cod_prov,hd.cod_art,hd.cant,hd.precio"
        cad17 = " from ingreso h inner join ingreso_det hd On h.operacion=hd.operacion order by 1,2) as t"
        cad18 = " inner join articulo a on t.cod_Art=a.cod_art inner join documento_i d on t.cod_doc=d.cod_doc"
        cad19 = " inner join unidad u on a.cod_uni=u.cod_uni inner join subgrupo s on a.cod_sgrupo=s.cod_sgrupo"
        cad20 = " inner join proveedor p on p.cod_prov = t.cod_prov "
        cad21 = " where year(fec_doc)= " & periodo & " and (d.esCompra) and (a.activo)"
        cad22 = " group by raz_soc,nom_art order by 1,2"
        cad = cad0 + cad1 + cad2 + cad3 + cad4 + cad5 + cad6 + cad7 + cad8 + cad9 + cad10 + cad11 + cad12 + cad13 + cad14 + cad15 + cad16 + cad17 + cad18 + cad19 + cad20 + cad21 + cad22
        Dim comSaldo As New MySqlCommand(cad)
        comSaldo.Connection = clConex
        comSaldo.CommandTimeout = 300
        da.SelectCommand = comSaldo
        da.Fill(dsResumen, "articulo")
        clConex.Close()
        Return dsResumen
    End Function
End Class
