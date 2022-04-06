Imports MySql.Data.MySqlClient
Public Class Bajas
    Public Function maxBaja() As Integer
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer
        com.Connection = clConex
        com.CommandText = "select max(nro_doc) from salida where cod_doc=92"
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Integer)
        clConex.Close()
        Return result + 1
    End Function
    Public Function recuperaBajas(ByVal hi As Boolean, ByVal pr As String, ByVal ag As Boolean, _
                                ByVal men As Boolean, ByVal f1 As Date, ByVal f2 As Date, _
                                ByVal nd As Decimal, ByVal xa As Boolean, ByVal ca As String, _
                                ByVal id As Boolean, ByVal xm As Boolean, ByVal cb As String, _
                                ByVal xg As Boolean, ByVal cg As String, ByVal cdoc As String) As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim da As New MySqlDataAdapter
        Dim dsMermas As New DataSet
        Dim mf1 As String = f1.ToString("yyyy-MM-dd")
        Dim mf2 As String = f2.ToString("yyyy-MM-dd")
        Dim cad, cad1, cad2, cad3, cad4, cad5, cad6, cad8, cad9 As String
        'cBaja = "92"
        cad1 = "select h.operacion,fec_doc,concat(ser_doc,'-',nro_doc) as doc,ser_doc,nro_doc," _
                & " hd.cod_art,nom_art,nom_uni,"
        cad2 = IIf(ag, "sum(cant) as cant,", "cant,") & "precio as pre_costo," _
                & IIf(ag, " round(sum(cant)*precio,", " round(cant*precio,") & nd & ") as monto," _
                & "nom_alma,salida,articulo.cod_sgrupo,nom_sgrupo,h.obs"
        If hi Then
            cad3 = " from h_salida as h inner join h_salida_det as hd on h.operacion=hd.operacion and h.proceso=hd.proceso"
        Else
            cad3 = " from salida as h inner join salida_det as hd on h.operacion=hd.operacion"
        End If
        cad4 = " inner join articulo on hd.cod_art=articulo.cod_art"
        cad5 = " inner join unidad on articulo.cod_uni=unidad.cod_uni"
        cad6 = " inner join almacen on h.cod_alma=almacen.cod_alma" _
                & " inner join subgrupo on articulo.cod_sgrupo=subgrupo.cod_sgrupo"
        cad8 = " where cod_doc='" & cdoc & "'" _
                & IIf(hi, " and h.proceso='" & pr & "'", "") _
                & IIf(men, "", " and fec_doc>='" & mf1 & "' and fec_doc<='" & mf2 & "'") _
                & IIf(xa, " and h.cod_alma='" & ca & "'", "") _
                & IIf(id, " and(es_invDiario)", "") _
                & IIf(xm, " and motivo_baja.cod_baja='" & cb & "'", "") _
                & IIf(xg, " and articulo.cod_sgrupo='" & cg & "'", "") _
                & IIf(ag, " group by hd.cod_art", "")
        cad9 = " order by nom_art"
        cad = cad1 + cad2 + cad3 + cad4 + cad5 + cad6 + cad8 + cad9
        Dim comTrans As New MySqlCommand(cad)
        comTrans.Connection = clConex
        da.SelectCommand = comTrans
        da.Fill(dsMermas, "mermas")
        clConex.Close()
        Return dsMermas
    End Function
    Public Function recuperaBajasT(ByVal hi As Boolean, ByVal pr As String, ByVal ag As Boolean, _
                                ByVal men As Boolean, ByVal f1 As Date, ByVal f2 As Date, _
                                ByVal nd As Decimal, ByVal xa As Boolean, ByVal ca As String, _
                                ByVal id As Boolean, ByVal xm As Boolean, ByVal cb As String, _
                                ByVal xg As Boolean, ByVal cg As String, ByVal xt As Boolean, ByVal ct As String) As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim da As New MySqlDataAdapter
        Dim dsMermas As New DataSet
        Dim mf1 As String = f1.ToString("yyyy-MM-dd")
        Dim mf2 As String = f2.ToString("yyyy-MM-dd")
        Dim cad, cad1, cad2, cad3, cad4, cad5, cad6, cad7, cad8, cad9, cBaja As String
        cBaja = "92"
        cad1 = "select h.operacion,fec_doc,concat(ser_doc,'-',nro_doc) as doc,ser_doc,nro_doc," _
                & " hd.cod_art,nom_art,nom_uni,"
        cad2 = IIf(ag, "sum(cant) as cant,", "cant,") & "precio as pre_costo," _
                & IIf(ag, " round(sum(cant)*precio,", " round(cant*precio,") & nd & ") as monto," _
                & "nom_alma,h.obs as nom_baja,salida,articulo.cod_sgrupo,nom_sgrupo"
        If hi Then
            cad3 = " from h_salida as h inner join h_salida_det as hd on h.operacion=hd.operacion and h.proceso=hd.proceso"
        Else
            cad3 = " from salida as h inner join salida_det as hd on h.operacion=hd.operacion"
        End If
        cad4 = " inner join articulo on hd.cod_art=articulo.cod_art"
        cad5 = " inner join unidad on articulo.cod_uni=unidad.cod_uni"
        cad6 = " inner join almacen on h.cod_alma=almacen.cod_alma" _
                & " inner join subgrupo on articulo.cod_sgrupo=subgrupo.cod_sgrupo"
        cad7 = " "
        cad8 = " where cod_doc='" & cBaja & "'" _
                & IIf(hi, " and h.proceso='" & pr & "'", "") _
                & IIf(men, "", " and fec_doc>='" & mf1 & "' and fec_doc<='" & mf2 & "'") _
                & IIf(xa, " and h.cod_alma='" & ca & "'", "") _
                & IIf(id, " and(es_invDiario)", "") _
                & IIf(xm, " and motivo_baja.cod_baja='" & cb & "'", "") _
                & IIf(xg, " and articulo.cod_sgrupo='" & cg & "'", "") _
                & IIf(xt, " and articulo.cod_tart='" & ct & "'", "") _
                & IIf(ag, " group by hd.cod_art", "")
        cad9 = " order by nom_art"
        cad = cad1 + cad2 + cad3 + cad4 + cad5 + cad6 + cad7 + cad8 + cad9
        Dim comTrans As New MySqlCommand(cad)
        comTrans.Connection = clConex
        da.SelectCommand = comTrans
        da.Fill(dsMermas, "mermas")
        clConex.Close()
        Return dsMermas
    End Function
    Public Function recBajas(ByVal em As String, ByVal cxa As Boolean, ByVal xfecha As Boolean, ByVal fechaI As Date, ByVal fechaf As Date, ByVal eh As Boolean,
            ByVal pe As String, ByVal xa As Boolean, ByVal ca As String, ByVal gr As Boolean) As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter
        Dim mfechaI As String = fechaI.ToString("yy-MM-dd")
        Dim mfechaF As String = fechaf.ToString("yy-MM-dd")
        Dim cad, cad1, cad2, cad3, cad4 As String
        cad1 = "select salida,cod_art," & IIf(gr, "sum(cant) as cant", "cant") & ",precio"
        If eh Then
            cad2 = " from h_salida as h inner join h_salida_det as hd on h.operacion=hd.operacion and h.proceso=hd.proceso"
        Else
            cad2 = " from salida as h inner join salida_det as hd on h.operacion=hd.operacion"
        End If
        'cad3 = " where cod_doc='92' and (h.cod_alma='0002' or h.cod_alma='0003')" _
        cad3 = " where cod_doc='92'" _
            & IIf(eh, " and h.proceso='" & pe & "'", "") & IIf(xa, " and h.cod_alma='" & ca & "'", "") _
            & IIf(xfecha, " and (fec_doc) >='" & mfechaI & "' and (fec_doc)<='" & mfechaF & "'", "")
        cad4 = IIf(gr, " group by cod_art", "") & " order by cod_art"
        cad = cad1 + cad2 + cad3 + cad4
        Dim com As New MySqlCommand(cad, clConex)
        da.SelectCommand = com
        da.Fill(ds, "baja")
        clConex.Close()
        Return ds
    End Function
End Class
