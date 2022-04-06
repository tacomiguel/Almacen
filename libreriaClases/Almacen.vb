Imports MySql.Data.MySqlClient
Public Class Almacen
    Public Shared Function dsAlmacen() As DataSet
        'declaramos la variable local ds
        'de tipo DataSet con el nombre Catalogo
        Dim ds As New DataSet("almacen")
        'añadimos el DataTable al DataSet
        ds.Tables.Add(dtAlmacen())
        Return ds
    End Function
    Public Shared Function dtAlmacen() As DataTable
        'declaramos la variable local dtArticulo
        'de tipo DataTable y nombre "articulo"
        Dim dt As New DataTable("almacen")
        'creamos las columnas del DataTable dtArticulo
        dt.Columns.Add(New DataColumn("cod_alma", GetType(String)))
        dt.Columns.Add(New DataColumn("nom_alma", GetType(String)))
        dt.Columns.Add(New DataColumn("cod_art", GetType(String)))
        dt.Columns.Add(New DataColumn("maximo", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("minimo", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("activo", GetType(Boolean)))
        Return dt
    End Function
    Public Function recuperaMaximos_xAlmacen(ByVal xalma As Boolean, ByVal cAlma As String, ByVal xarea As Boolean, _
                                             ByVal xProd As Boolean, ByVal cArea As String) As DataSet
        'no se incluyen las producciones
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim da As New MySqlDataAdapter
        Dim dsMaximos As New DataSet
        Dim cad, cad1, cad2, cad3, cad4 As String
        cad1 = " select a.cod_art,nom_art,nom_uni,pre_costomax,pre_costomin," & IIf(xarea, "max as maximo,min as minimo", "maximo,minimo")
        cad2 = " from articulo a inner join unidad on a.cod_uni=unidad.cod_uni " _
               & IIf(xarea, "inner join art_area arta on a.cod_art=arta.cod_Art", "")
        cad3 = " inner join tipo_articulo t on t.cod_tart=a.cod_tart "
        cad4 = " where " _
                & IIf(xProd, "(t.esProduccion)", "!(t.esProduccion)") _
                & IIf(xalma, " and s.cod_alma='" & cAlma & "'", "") _
                & " and a.activo=1 order by nom_art"
        cad = cad1 + cad2 + cad3 + cad4
        Dim comSaldo As New MySqlCommand(cad)
        comSaldo.Connection = clConex
        da.SelectCommand = comSaldo
        da.Fill(dsMaximos, "maximos")
        clConex.Close()
        Return dsMaximos

        '& " and " & IIf(xarea, "arta.cod_alma=  '" & c1 & "' and arta.cod_area='" & cArea & "'", "a.cod_alma='" & c1 & "'") _
    End Function

    Public Function recuperaMaximos_xArea(ByVal c1 As String, ByVal xarea As Boolean, ByVal xProd As Boolean, ByVal cArea As String) As DataSet
        'no se incluyen las producciones
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim da As New MySqlDataAdapter
        Dim dsMaximos As New DataSet
        Dim cad, cad1, cad2, cad3, cad4 As String
        cad1 = " select a.cod_art,nom_art,nom_uni,pre_costomax,pre_costomin," & IIf(xarea, "max as maximo,min as minimo", "maximo,minimo")
        cad2 = " from articulo a inner join unidad on a.cod_uni=unidad.cod_uni " _
               & IIf(xarea, "inner join art_area arta on a.cod_art=arta.cod_Art", "")
        cad3 = " inner join tipo_articulo t on t.cod_tart=a.cod_tart "
        cad4 = " where a.cod_alma='" & c1 & "' and " _
                & IIf(xProd, "(t.esProduccion)", "!(t.esProduccion)") _
                & IIf(xarea, "and arta.cod_area='" & cArea & "'", "") _
                & " and a.activo=1 order by nom_art"
        cad = cad1 + cad2 + cad3 + cad4
        Dim comSaldo As New MySqlCommand(cad)
        comSaldo.Connection = clConex
        da.SelectCommand = comSaldo
        da.Fill(dsMaximos, "maximos")
        clConex.Close()
        Return dsMaximos
    End Function
    Public Function existeEnIngreso(ByVal c1 As String) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer, cad As String
        com.Connection = clConex
        cad = "Select cod_alma from ingreso where c1='" & c1 & "'"
        com.CommandText = cad
        result = com.ExecuteScalar
        clConex.Close()
        If result = 0 Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Function existeEnIngresoHistorial(ByVal cod_alma As String) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer, cad As String
        com.Connection = clConex
        cad = "Select cod_alma from h_ingreso where cod_alma='" & cod_alma & "'"
        com.CommandText = cad
        result = com.ExecuteScalar
        clConex.Close()
        If result = 0 Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Function existeEnSalida(ByVal c1 As String) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer, cad As String
        com.Connection = clConex
        cad = "Select cod_alma from salida where cod_alma='" & c1 & "'"
        com.CommandText = cad
        result = com.ExecuteScalar
        clConex.Close()
        If result = 0 Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Function insertaMaximosxAlma(ByVal c1 As String, ByVal c2 As String, ByVal c3 As String, _
                        ByVal m1 As Decimal, ByVal m2 As Decimal) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim cad, cad1, cad2 As String, result As Integer
        cad1 = "Insert into art_area(cod_art,cod_alma,cod_area,max,min)"
        cad2 = " values('" & c1 & "','" & c2 & "','" & c3 & "'," & m1 & "," & m2 & ")"
        cad = cad1 + cad2
        com.CommandText = cad
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function

    Public Function insertaArea(ByVal c1 As String, ByVal c2 As String,
                            ByVal c3 As String, ByVal c4 As Boolean) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim cad, cad1, cad2 As String, result As Integer
        cad1 = "Insert into area(cod_area,nom_area,cod_alma,destinoTrans,activo)"
        cad2 = " values('" & c1 & "','" & c2 & "','" & c3 & "'," & c4 & "," & c4 & ")"
        cad = cad1 + cad2
        com.CommandText = cad
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function

    Public Function insertaMaximos(ByVal c1 As String, ByVal c2 As String,
                            ByVal m1 As Decimal, ByVal m2 As Decimal) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim cad, cad1, cad2 As String, result As Integer
        cad1 = "Insert into art_area(cod_art,cod_area,max,min)"
        cad2 = " values('" & c1 & "','" & c2 & "'," & m1 & "," & m2 & ")"
        cad = cad1 + cad2
        com.CommandText = cad
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function
    Public Function actualizaMaximos(ByVal c1 As String, ByVal c2 As String, _
                                ByVal cmaximo As Decimal, ByVal cminimo As Decimal, _
                                ByVal pmaximo As Decimal, ByVal pminimo As Decimal) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim cad, cad1, cad2 As String, result As Integer
        cad1 = "update articulo set maximo=" & cmaximo & ", minimo=" & cminimo & ", pre_costomax=" & pmaximo & ", pre_costomin=" & pminimo
        cad2 = " where cod_art='" & c1 & "' and cod_alma='" & c2 & "'"
        cad = cad1 + cad2
        com.CommandText = cad
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function
    Public Function actualizaMaximosxAlma(ByVal c1 As String, ByVal c2 As String, ByVal c3 As String, _
                        ByVal cmaximo As Decimal, ByVal cminimo As Decimal) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim cad, cad1, cad2 As String, result As Integer
        cad1 = "update art_area set max=" & cmaximo & ", min=" & cminimo
        cad2 = " where cod_art='" & c1 & "' and cod_alma='" & c2 & "' and cod_area='" & c3 & "'"
        cad = cad1 + cad2
        com.CommandText = cad
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function

    Public Function actualizaMaximosxArea(ByVal c1 As String, ByVal c2 As String, _
                            ByVal cmaximo As Decimal, ByVal cminimo As Decimal) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim cad, cad1, cad2 As String, result As Integer
        cad1 = "update art_area set max=" & cmaximo & ", min=" & cminimo
        cad2 = " where cod_art='" & c1 & "' and cod_area='" & c2 & "'"
        cad = cad1 + cad2
        com.CommandText = cad
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function
    Public Function existeMaximosxAlma(ByVal c1 As String, ByVal c2 As String, ByVal c3 As String) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer, cad As String
        com.Connection = clConex
        cad = "Select count(cod_art) from art_area where cod_alma='" & c1 & "' and cod_area='" & c2 & "'  and cod_art='" & c3 & "'"
        com.CommandText = cad
        result = com.ExecuteScalar
        clConex.Close()
        If result = 0 Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Function existeMaximos(ByVal c1 As String, ByVal c2 As String) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer, cad As String
        com.Connection = clConex
        cad = "Select count(cod_art) from art_area where cod_area='" & c2 & "' and cod_art='" & c1 & "'"
        com.CommandText = cad
        result = com.ExecuteScalar
        clConex.Close()
        If result = 0 Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Function esDeProduccion(Optional ByVal c As String = "") As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        Dim da As New MySqlDataAdapter
        Dim ds As New DataSet
        com.Connection = clConex
        Dim cad, result As String
        cad = "select count(cod_alma) from almacen where cod_alma='" & c & "' and (esProduccion)"
        com.CommandText = cad
        result = com.ExecuteScalar
        clConex.Close()
        If result = 0 Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Function tipoAlmacen(ByVal tipo As String, Optional ByVal c As String = "") As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        Dim da As New MySqlDataAdapter
        Dim ds As New DataSet
        com.Connection = clConex
        Dim cad, result As String
        cad = "select count(cod_alma) from almacen where cod_alma='" & c & "' and " & tipo & ""
        com.CommandText = cad
        result = com.ExecuteScalar
        clConex.Close()
        If result = 0 Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Function esDeCompras(Optional ByVal c As String = "") As Boolean
        Return True
    End Function
    Public Function devuelveAreaInvInicial(ByVal c As String) As String
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As String, cad As String
        com.Connection = clConex
        cad = "Select cod_area from area where cod_alma='" & c & "' and es_InvInicial"
        com.CommandText = cad
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(Len(obj) = 0, "0000", obj), String)
        clConex.Close()
        Return result
    End Function
    Public Function devuelveAlmacenCatalogo(ByVal c As String) As String
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As String, cad As String
        com.Connection = clConex
        cad = "Select almaCatalogo from almacen where cod_alma='" & c & "'"
        com.CommandText = cad
        result = com.ExecuteScalar
        clConex.Close()
        Return result
    End Function
    Public Function devuelveTipoProceso(ByVal c As String) As String
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As String, cad As String
        com.Connection = clConex
        cad = "Select tipProceso from almacen where cod_alma='" & c & "'"
        com.CommandText = cad
        result = com.ExecuteScalar
        clConex.Close()
        Return result
    End Function
    Public Function devuelveIdeales(ByVal c As String) As String
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As String, cad As String
        com.Connection = clConex
        cad = "Select tieneIdeales from almacen where cod_alma='" & c & "'"
        com.CommandText = cad
        result = com.ExecuteScalar
        clConex.Close()
        Return result
    End Function
    Public Function devuelveEsEvento(ByVal c As String) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Boolean, cad As String
        com.Connection = clConex
        cad = "Select esEvento from almacen where cod_alma='" & c & "'"
        com.CommandText = cad
        result = com.ExecuteScalar
        clConex.Close()
        Return result
    End Function

    Public Function devuelveAlmacenPrincipal() As String
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        Dim da As New MySqlDataAdapter
        Dim ds As New DataSet
        com.Connection = clConex
        Dim cad, result As String
        cad = "select cod_alma from almacen where (esPrincipal)"
        com.CommandText = cad
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), "", obj), String)
        clConex.Close()
        Return result
    End Function
    Public Function devAlmacenVentas() As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        Dim da As New MySqlDataAdapter
        Dim ds As New DataSet
        com.Connection = clConex
        Dim cad As String
        cad = "select cod_alma,nom_alma from almacen where (esVentas)"
        com.CommandText = cad
        da.SelectCommand = com
        da.Fill(ds, "almacen")
        clConex.Close()
        Return ds
    End Function

    Public Function EsAlmacenPrincipal(ByVal c As String) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer, cad As String
        com.Connection = clConex
        cad = "Select cod_alma from almacen where esPrincipal and cod_alma='" & c & "'"
        com.CommandText = cad
        result = com.ExecuteScalar
        clConex.Close()
        If result = 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function tieneArticulos(ByVal c As String) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer, cad As String
        com.Connection = clConex
        cad = "Select cod_alma from articulo where cod_alma='" & c & "'"
        com.CommandText = cad
        result = com.ExecuteScalar
        clConex.Close()
        If result = 0 Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Function existeArticulo_deAlmaGeneral(ByVal c1 As String, ByVal c2 As String) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer, cad As String
        com.Connection = clConex
        cad = "Select count(cod_art) from art_relaAlmacenes where cod_alma='" & c1 & "' and cod_art='" & c2 & "'"
        com.CommandText = cad
        result = com.ExecuteScalar
        clConex.Close()
        If result = 0 Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Function relacionaArticulos(ByVal c1 As String, ByVal c2 As String, ByVal c3 As String) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim cad, cad1, cad2 As String, result As Integer
        cad1 = "Insert into art_relaalmacenes(cod_alma,cod_artalma,cod_art,activo)"
        cad2 = " values('" & c1 & "','" & c2 & "','" & c3 & "'," & " 1)"
        cad = cad1 + cad2
        com.CommandText = cad
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function
    Public Function eliminaArea(ByVal c1 As String) As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim cad, cad1, cad2 As String, result As Integer
        cad1 = "delete from area "
        cad2 = " where cod_area='" & c1 & "'"
        cad = cad1 + cad2
        com.CommandText = cad
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function

    Public Function eliminaRelacionArticulos(Optional ByVal c1 As String = "", Optional ByVal c2 As String = "", Optional ByVal c3 As String = "") As Boolean
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand
        com.Connection = clConex
        Dim cad, cad1, cad2 As String, result As Integer
        cad1 = "delete from art_relaalmacenes "
        cad2 = " where cod_alma='" & c1 & "' and cod_artAlma='" & c2 & "'"
        cad = cad1 + cad2
        com.CommandText = cad
        result = com.ExecuteNonQuery
        clConex.Close()
        Return result
    End Function
    Public Function muestraArticulosRelacionados(ByVal c1 As String, ByVal c2 As String, ByVal v1 As Integer) As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim da As New MySqlDataAdapter
        Dim ds As New DataSet
        Dim cad, cad1, cad2, cad3 As String
        cad1 = "select a.cod_art,a.nom_art,u.nom_uni,ar.activo,ar.cod_alma,ar.cod_artAlma "
        cad2 = " from art_relaalmacenes ar inner join articulo a on " & IIf(v1 = 1, "ar.cod_art", "ar.cod_artalma") & "=a.cod_art " _
                & " inner join unidad u on u.cod_uni=a.cod_uni"
        cad3 = " where ar.cod_alma='" & c1 & IIf(v1 = 1, "' and ar.cod_artAlma='", "' and ar.cod_art='") & c2 & "'"
        cad = cad1 + cad2 + cad3
        Dim com As New MySqlCommand(cad)
        com.Connection = clConex
        da.SelectCommand = com
        da.Fill(ds, "articulo")
        clConex.Close()
        Return ds
    End Function
    Public Function muestraArticuloRelacionado(Optional ByVal c1 As String = "", Optional ByVal c2 As String = "") As String
        Return ""
    End Function
    Public Function devuelveCodigoArtRelacionado(ByVal c1 As String, ByVal c2 As String) As String
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As String, cad As String
        com.Connection = clConex
        cad = "select cod_artAlma from art_relaalmacenes where cod_art='" & c1 & "' and cod_alma='" & c2 & "'"
        com.CommandText = cad
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(Len(obj) = 0, c1, obj), String)
        clConex.Close()
        Return result
    End Function
    Public Function devuelveCodigoArtPrinRelacionado(Optional ByVal c1 As String = "") As String
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As String, cad As String
        com.Connection = clConex
        cad = "select cod_art from art_relaalmacenes where cod_artalma='" & c1 & "'"
        com.CommandText = cad
        result = com.ExecuteScalar
        clConex.Close()
        Return result
    End Function
    Public Function devuelveCodigoRelacionado(Optional ByVal c1 As String = "") As String
        Return ""
    End Function
    Public Function devNombreAlmacen(ByVal c1 As String) As String
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As String, cad As String
        com.Connection = clConex
        cad = "Select nom_alma from almacen where cod_alma='" & c1 & "'"
        com.CommandText = cad
        result = com.ExecuteScalar
        clConex.Close()
        Return result
    End Function
    Public Function maxOperacion_area() As String
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer
        com.Connection = clConex
        com.CommandText = "select max(cod_area) from area where cod_area REGEXP ('^[0-9]+$')"
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), "0000", obj), String)
        Dim resp As String = Right("0000" & Trim(Str(Microsoft.VisualBasic.Val(result) + 1)), 4)
        clConex.Close()
        Return resp

    End Function
    Public Function devArticuloPrincipalRelacionado(Optional ByVal c1 As String = "", Optional ByVal c2 As String = "") As String
        Return ""
    End Function
End Class
