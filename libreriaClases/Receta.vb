Imports MySql.Data.MySqlClient
Public Class Receta
    Public Function insertar(ByVal cod_rec As String, _
                                    ByVal cod_art As String, _
                                    ByVal cant As Decimal, _
                                    ByVal costo As Decimal) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim sql As String, result As Integer
        sql = "Insert Into receta(cod_rec,cod_art,cant,costo)" & _
            "values('" & _
            cod_rec & "','" & cod_art & "'," & cant & "," & costo & ")"
        com.CommandText = sql
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function
    Public Function insertarCombo(ByVal cod_combo As String, ByVal dsc_combo As String, ByVal max As Integer, _
                                ByVal cod_art As String) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim sql As String, result As Integer
        sql = "Insert Into art_combo(cod_combo,dsc_combo,max,cod_art)" & _
            "values('" & _
             cod_combo & "','" & dsc_combo & "'," & max & ",'" & cod_art & "')"
        com.CommandText = sql
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function
    Public Function insertarDetCombo(ByVal cod_combo As String, _
                            ByVal cod_art As String, ByVal cant As Decimal, ByVal precio As Decimal) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim sql As String, result As Integer
        sql = "Insert Into art_combodet(cod_combo,cod_art,cant,precio)" & _
            "values('" & _
             cod_combo & "','" & cod_art & "', " & cant & "," & precio & ")"
        com.CommandText = sql
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function
    Public Sub actualizaCostoReceta(ByVal cod_rec As String, ByVal costo As Decimal)
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, cad, cad1, cad2 As String
        com.Connection = clConex
        cad1 = "update articulo set pre_costo=" & costo
        cad2 = " where cod_art='" & cod_rec & "'"
        cad = cad1 + cad2
        com.CommandText = cad
        com.ExecuteNonQuery()
        clConex.Close()
    End Sub
    Public Function devuelveCostoReceta(ByVal cod_rec As String) As Decimal
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Decimal, cad, cad1, cad2 As String
        com.Connection = clConex
        cad1 = "select sum(costo) from receta"
        cad2 = " where cod_rec='" & cod_rec & "'"
        cad = cad1 + cad2
        com.CommandText = cad
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Decimal)
        clConex.Close()
        Return result
    End Function
    Public Sub actualizaCostoInsumo_enReceta(ByVal cod_rec As String, ByVal cod_art As String, ByVal costo As Decimal)
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, cad, cad1, cad2 As String
        com.Connection = clConex
        cad1 = "update receta set costo=" & costo & "* cant"
        cad2 = " where cod_art='" & cod_art & "' and cod_rec='" & cod_rec & "'"
        cad = cad1 + cad2
        com.CommandText = cad
        com.ExecuteNonQuery()
        clConex.Close()
    End Sub
    Public Function existeReceta(ByVal cod_rec As String) As Integer
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer, cad, cad1, cad2 As String
        com.Connection = clConex
        cad1 = "Select cod_rec from receta"
        cad2 = " where cod_rec='" & cod_rec & "'"
        cad = cad1 + cad2
        com.CommandText = cad
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Integer)
        clConex.Close()
        Return result
    End Function
    Public Function esSubReceta(ByVal cod_art As String) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer, cad, cad1, cad2 As String
        com.Connection = clConex
        cad1 = "Select count(cod_art) from receta"
        cad2 = " where cod_rec='" & cod_art & "'"
        cad = cad1 + cad2
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
    Public Function existeInsumoEnReceta(ByVal cod_rec As String, ByVal cod_art As String) As Integer
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer, cad, cad1, cad2 As String
        com.Connection = clConex
        cad1 = "Select count(cod_art) from receta"
        cad2 = " where cod_rec='" & cod_rec & "' and cod_art='" & cod_art & "'"
        cad = cad1 + cad2
        com.CommandText = cad
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Integer)
        clConex.Close()
        Return result
    End Function
    Public Sub eliminaInsumo(ByVal cod_rec As String, ByVal cod_art As String)
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, cad, cad1, cad2 As String
        com.Connection = clConex
        cad1 = "delete from receta"
        cad2 = " where cod_rec='" & cod_rec & "' and cod_art='" & cod_art & "'"
        cad = cad1 + cad2
        com.CommandText = cad
        com.ExecuteNonQuery()
        clConex.Close()
    End Sub
    Public Sub eliminaCombo(ByVal cod_combo As String)
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, cad, cad1, cad2 As String
        com.Connection = clConex
        cad1 = "delete from art_combo"
        cad2 = " where cod_combo='" & cod_combo & "'"
        cad = cad1 + cad2
        com.CommandText = cad
        com.ExecuteNonQuery()
        clConex.Close()
    End Sub
    Public Sub eliminaDetCombo(ByVal cod_combo As String, ByVal cod_art As String)
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, cad, cad1, cad2 As String
        com.Connection = clConex
        cad1 = "delete from art_combodet"
        cad2 = " where cod_combo='" & cod_combo & "' and cod_art='" & cod_art & "'"
        cad = cad1 + cad2
        com.CommandText = cad
        com.ExecuteNonQuery()
        clConex.Close()
    End Sub
    Public Function maxProduccion() As Integer
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer
        com.Connection = clConex
        com.CommandText = "select max(nro_doc) from salida where cod_doc=93"
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Integer)
        clConex.Close()
        Return result + 1
    End Function
    Public Function maxTransformacion() As Integer
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer
        com.Connection = clConex
        com.CommandText = "select max(nro_doc) from salida where cod_doc=91"
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Integer)
        clConex.Close()
        Return result + 1
    End Function
    Public Function maxCodCombo() As String
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer
        com.Connection = clConex
        com.CommandText = "select max(cod_combo) from art_combo "
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), "0000", obj), String)
        Dim resp As String = Right("0000" & Trim(Str(Microsoft.VisualBasic.Val(result) + 1)), 4)
        clConex.Close()
        Return resp
    End Function

    Public Function recetaYaUtilizada(ByVal cod_rec As String) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer, cad, cad1, cad2 As String
        com.Connection = clConex
        cad1 = "Select count(cod_art) from salida_det"
        cad2 = " where cod_art='" & cod_rec & "'"
        cad = cad1 + cad2
        com.CommandText = cad
        result = com.ExecuteScalar
        If result > 0 Then
            Return True
        Else
            Return False
        End If
        clConex.Close()
    End Function
    Public Function recuperaProducciones(ByVal xAlmacen As Boolean, ByVal cod_alma As String, _
                                        ByVal soloActivos As Boolean) As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim da As New MySqlDataAdapter
        Dim dsProduccion As New DataSet
        Dim cad, cad1, cad2, cad3, cad4 As String
        cad1 = "Select cod_art,nom_art,articulo.cod_uni,nom_uni,articulo.cod_sgrupo,cod_tart,cod_artExt,factor_prod,cod_area," _
                & "pre_costo,pre_costoMax,pre_venta,pre_inc_imp,round(pre_costo*100/pre_venta,2) as porcentaje,articulo.activo"
        cad2 = " from articulo inner join subgrupo on articulo.cod_sgrupo=subgrupo.cod_sgrupo"
        cad3 = " inner join unidad on articulo.cod_uni=unidad.cod_uni"
        cad4 = " where (subgrupo.esProduccion)" _
                    & IIf(xAlmacen, " and articulo.cod_alma='" & cod_alma & "'", "") _
                    & IIf(soloActivos, " and articulo.activo=1", "") _
                    & " order by porcentaje desc,nom_art"
        cad = cad1 + cad2 + cad3 + cad4
        Dim comProd As New MySqlCommand(cad)
        comProd.Connection = clConex
        da.SelectCommand = comProd
        da.Fill(dsProduccion, "articulo")
        clConex.Close()
        Return dsProduccion
    End Function
    Public Function recuperaRecetas(ByVal xAlmacen As Boolean, ByVal cod_alma As String, ByVal xSgrupo As Boolean, ByVal cod_sgrupo As String, _
                                    ByVal soloActivos As Boolean) As DataSet
        'igual a recupera producciones
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim da As New MySqlDataAdapter
        Dim dsProduccion As New DataSet
        Dim cad, cad1, cad2, cad3, cad4 As String
        cad1 = "Select cod_art,nom_art,articulo.cod_uni,nom_uni,articulo.cod_sgrupo,articulo.cod_tart," _
                & "pre_costo,pre_costo as costo,pre_costoMax,pre_venta,pre_inc_imp,articulo.activo,nom_tart"
        cad2 = " from articulo inner join subgrupo on articulo.cod_sgrupo=subgrupo.cod_sgrupo"
        cad3 = " inner join unidad on articulo.cod_uni=unidad.cod_uni inner join tipo_articulo on articulo.cod_tart=tipo_articulo.cod_tart"
        cad4 = " where (subgrupo.esProduccion)" _
                    & IIf(xAlmacen, " and articulo.cod_alma='" & cod_alma & "'", "") _
                    & IIf(xSgrupo, " and articulo.cod_sgrupo='" & cod_sgrupo & "'", "") _
                    & IIf(soloActivos, " and articulo.activo=1", "") _
                    & " order by nom_tart desc,nom_art"
        cad = cad1 + cad2 + cad3 + cad4
        Dim comProd As New MySqlCommand(cad)
        comProd.Connection = clConex
        da.SelectCommand = comProd
        da.Fill(dsProduccion, "receta")
        clConex.Close()
        Return dsProduccion
    End Function
    Public Function recuperaProduccion(ByVal xDescripArticulo As Boolean, ByVal nomArticulo As String, ByVal soloActivos As Boolean) As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim da As New MySqlDataAdapter
        Dim dsProduccion As New DataSet
        Dim cad, cad1, cad2, cad3, cad4, cad5, cad6, cad7 As String
        cad1 = "select cod_art,nom_art,articulo.cod_uni,nom_uni,pre_costo,"
        cad2 = " pre_venta,round(pre_costo*100/pre_venta,2) as porcentaje,"
        cad3 = " articulo.cod_sgrupo,cod_tart,pre_inc_imp,articulo.activo "
        cad4 = " from articulo inner join unidad on articulo.cod_uni=unidad.cod_uni"
        cad5 = " inner join subgrupo on articulo.cod_sgrupo=subgrupo.cod_sgrupo"
        cad6 = " where (subgrupo.esProduccion)" _
                & IIf(xDescripArticulo, " and nom_art like '" & nomArticulo & "%'", "") _
                & IIf(soloActivos, " and articulo.activo=1", "")
        cad7 = " order by nom_art"
        cad = cad1 + cad2 + cad3 + cad4 + cad5 + cad6 + cad7
        Dim comProd As New MySqlCommand(cad)
        comProd.Connection = clConex
        da.SelectCommand = comProd
        da.Fill(dsProduccion, "produccion")
        clConex.Close()
        Return dsProduccion
    End Function
    Public Function recuperaReceta(ByVal cod_rec As String) As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim da As New MySqlDataAdapter
        Dim ds As New DataSet
        Dim cad, cad1, cad2, cad3, cad4 As String
        cad1 = " select cod_rec,receta.cod_art,nom_art,nom_uni,cant,costo,pre_costo,cant_uni,(cant*pre_costo) as total "
        cad2 = " from receta inner join articulo on receta.cod_art=articulo.cod_art"
        cad3 = " inner join unidad on articulo.cod_uni=unidad.cod_uni"
        cad4 = " where cod_rec='" & cod_rec & "' order by nom_art"
        cad = cad1 + cad2 + cad3 + cad4
        Dim com As New MySqlCommand(cad)
        com.Connection = clConex
        da.SelectCommand = com
        da.Fill(ds, "receta")
        clConex.Close()
        Return ds
    End Function
    Public Function recuperaCombo(ByVal cod_rec As String) As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim da As New MySqlDataAdapter
        Dim ds As New DataSet
        Dim cad, cad1, cad2, cad3, cad4 As String
        cad1 = " Select	c.cod_combo,dsc_combo,a.cod_art,a.nom_art as Descripcion,cant,precio FROM art_combo c "
        cad2 = " left join art_combodet cd on c.cod_combo=cd.cod_combo "
        cad3 = " left join articulo a on a.cod_art=cd.cod_art  "
        cad4 = " where c.cod_art='" & cod_rec & "' order by dsc_combo"

        cad = cad1 + cad2 + cad3 + cad4
        Dim com As New MySqlCommand(cad)
        com.Connection = clConex
        da.SelectCommand = com
        da.Fill(ds, "Combo")
        clConex.Close()
        Return ds
    End Function


    Public Function recuperaRecetas_deInsumo(ByVal cod_art As String, ByVal esActivo As Boolean) As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim da As New MySqlDataAdapter
        Dim ds As New DataSet
        Dim cad, cad1, cad2, cad3, cad4 As String
        cad1 = "select cod_rec,nom_art,nom_uni,pre_costo,cant,cod_artext "
        cad2 = " from receta inner join articulo on receta.cod_rec=articulo.cod_art"
        cad3 = " inner join unidad on articulo.cod_uni=unidad.cod_uni"
        cad4 = " where receta.cod_art = '" & cod_art & "' and " & IIf(esActivo, "(articulo.activo)", "!(articulo.activo)") & " order by nom_art"
        cad = cad1 + cad2 + cad3 + cad4
        Dim com As New MySqlCommand(cad)
        com.Connection = clConex
        da.SelectCommand = com
        da.Fill(ds, "receta")
        clConex.Close()
        Return ds
    End Function
    Public Function recProducciones(ByVal xAlmacen As Boolean, ByVal cod_alma As String, ByVal soloInvFisico As Boolean) As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim da As New MySqlDataAdapter
        Dim ds As New DataSet
        Dim cad, cad1, cad2, cad3, cad4, cad5, cad6 As String
        cad1 = "select ingreso.operacion,ingreso,fec_doc,ingreso_det.cod_art,nom_art,nom_uni,cant,pre_costo,articulo.cod_sgrupo,nom_sgrupo "
        cad2 = " from ingreso inner join ingreso_det on ingreso.operacion=ingreso_det.operacion"
        cad3 = " inner join articulo on articulo.cod_art=ingreso_det.cod_art"
        cad4 = " inner join unidad on articulo.cod_uni=unidad.cod_uni"
        cad5 = " inner join subgrupo on articulo.cod_sgrupo=subgrupo.cod_sgrupo"
        cad6 = " where (subgrupo.esProduccion) " & IIf(soloInvFisico, " and cod_doc = '10'", " and cod_doc='93'") _
                & IIf(xAlmacen, " and ingreso.cod_alma='" & cod_alma & "'", "") _
                & " order by nom_art"
        cad = cad1 + cad2 + cad3 + cad4 + cad5 + cad6
        Dim com As New MySqlCommand(cad)
        com.Connection = clConex
        da.SelectCommand = com
        da.Fill(ds, "articulo")
        clConex.Close()
        Return ds
    End Function
    Public Function recProduccionesxdia(ByVal xAlmacen As Boolean, ByVal cod_alma As String, ByVal cod_area As String, ByVal cod_usu As String, ByVal soloInvFisico As Boolean, ByVal f As Date, ByVal acum As Boolean) As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim da As New MySqlDataAdapter
        Dim ds As New DataSet
        Dim cad, cad1, cad2, cad3, cad4, cad5, cad6 As String
        Dim mfecha As String = f.ToString("yyyy-MM-dd")
        cad1 = "select ingreso.operacion,ingreso,nro_doc,fec_doc,ingreso_det.cod_art,nom_art,nom_uni," _
              & IIf(acum, "sum(cant) as cant", "cant") & " ,pre_costo,articulo.cod_sgrupo,nom_sgrupo "
        cad2 = " from ingreso inner join ingreso_det on ingreso.operacion=ingreso_det.operacion"
        cad3 = " inner join articulo on articulo.cod_art=ingreso_det.cod_art"
        cad4 = " inner join unidad on articulo.cod_uni=unidad.cod_uni"
        cad5 = " inner join subgrupo on articulo.cod_sgrupo=subgrupo.cod_sgrupo"
        cad6 = " where (subgrupo.esProduccion) " & IIf(soloInvFisico, " and cod_doc = '10'", " and cod_doc='93'") _
                & IIf(xAlmacen, " and ingreso.cod_alma='" & cod_alma & "' and ingreso.cod_area='" & cod_area & "' and cuenta='" & cod_usu & "'", "") _
                & IIf(acum, " And fec_doc <='" & mfecha & "' group by ingreso_det.cod_art", " and fec_doc='" & mfecha & "'") _
                & " order by nom_art,fec_doc"
        cad = cad1 + cad2 + cad3 + cad4 + cad5 + cad6
        Dim com As New MySqlCommand(cad)
        com.Connection = clConex
        da.SelectCommand = com
        da.Fill(ds, "articulo")
        clConex.Close()
        Return ds
    End Function
End Class