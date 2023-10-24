Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic
Public Class Transferencia
    Public Function transfiereProducto_c(ByVal fecha As Date, ByVal cod_almaO As String, ByVal cod_areaO As String, ByVal cod_almaD As String, _
                    ByVal cod_areaD As String, ByVal tm As String, ByVal tc As Decimal, ByVal empresa As String, ByVal cuenta As String, _
                    ByVal nDecimales As Decimal) As String
        Dim mSalida As New Salida, mIngreso As New Ingreso
        Dim mAlmacen As New Almacen, mUnidad As New Unidad
        Dim nOperacionS As Integer = mSalida.maxOperacion
        Dim nOperacionI As Integer = mIngreso.maxOperacion
        Dim nTransferencia As String = maxTransferencia()
        Dim mfecha As String = fecha.ToString("yyyy-MM-dd")
        Dim nro_doc As String = Right("00000000" & nTransferencia, 8)
        If cod_areaO = "" Then
            cod_areaO = "0000"
        End If
        If cod_areaD = "" Then
            cod_areaD = "0000"
        End If
        mSalida.insertar_aux(nOperacionS, 0, "90", "001", nro_doc, mfecha, mfecha, "00000000", "00000000000", "01", 1, 0,
            nDecimales, cod_almaO, "0000", "", empresa, cuenta, cuenta, 0, cod_almaD, cod_areaD)

        mIngreso.insertar(nOperacionI, "90", "001", nro_doc, "000", "00000000", 0, mfecha, "00000000000", "01",
            cod_almaD, cod_areaD, 1, 0, nDecimales, "", tm, tc, cuenta, "")
        Return nro_doc
    End Function
    Public Sub transfiereProducto_d(ByVal operacionS As Integer, ByVal operacionI As Integer, ByVal cod_art As String, ByVal cant_uni As Decimal, _
                ByVal nOperacionDocumentoDeCompra As Integer, ByVal nIngresoArticulo As Integer, ByVal cantidad As Decimal, _
                ByVal costo As Decimal, ByVal impuesto As Decimal, ByVal xAlmacen As Boolean, ByVal cod_almaO As String, ByVal cod_almaD As String)
        Dim mSalida As New Salida, mIngreso As New Ingreso
        Dim mAlmacen As New Almacen, mUnidad As New Unidad
        Dim mCatalogo As New Catalogo
        Dim cCatalogoO, cCatalogoD As String, cod_artRel, cod_uniRel As String, cant_uniRel As Decimal, nCantidad, nCosto As Decimal
        cCatalogoO = mAlmacen.devuelveAlmacenCatalogo(cod_almaO)
        cCatalogoD = mAlmacen.devuelveAlmacenCatalogo(cod_almaD)
        Dim nSalida As Integer = mSalida.maxSalida
        Dim nIngreso As Integer = mIngreso.maxIngreso
        Dim mprecio As New ePrecio
        If cCatalogoO = cCatalogoD Then
            mIngreso.insertar_det(operacionI, nIngreso, cod_art, cantidad, costo, "", impuesto)
            mSalida.insertar_detAux(operacionS, nSalida, nIngreso, cod_art, cantidad, cantidad, costo, 0, 0, 0, "", 0, nOperacionDocumentoDeCompra)
            mprecio.actualizaPrecioPromedio(cod_art)
        Else
            cod_artRel = mAlmacen.devuelveCodigoArtRelacionado(cod_art, cCatalogoD)
            If Len(cod_artRel) > 0 Then
                cod_uniRel = mUnidad.devuelveUnidad(cod_artRel)
                cant_uniRel = mUnidad.devuelveCantUnidad(cod_uniRel)
                If mCatalogo.existeEnLimpios(cod_artRel) Then
                    cod_artRel = mCatalogo.devuelveCodigoLimpio(cod_artRel)
                    nCantidad = cantidad * mCatalogo.devuelveCantLimpio(cod_artRel)
                    nCosto = cantidad * costo / nCantidad
                Else
                    nCantidad = cantidad
                    nCosto = costo
                End If
                If cant_uni = cant_uniRel Then
                    mIngreso.insertar_det(operacionI, nIngreso, cod_artRel, nCantidad, nCosto, "", impuesto)
                    mSalida.insertar_detAux(operacionS, nSalida, nIngreso, cod_art, cantidad, cantidad, costo, 0, 0, 0, "", 0, nOperacionDocumentoDeCompra)
                Else
                    nCantidad = (cantidad * cant_uni) / cant_uniRel
                    nCosto = (costo / cant_uni) * cant_uniRel
                    mIngreso.insertar_det(operacionI, nIngreso, cod_artRel, nCantidad, nCosto, "", impuesto)
                    mSalida.insertar_detAux(operacionS, nSalida, nIngreso, cod_art, cantidad, cantidad, costo, 0, 0, 0, "", 0, nOperacionDocumentoDeCompra)
                End If
                mprecio.actualizaPrecioPromedio(cod_artRel)
            End If
        End If
    End Sub
    Public Function devOperacionS(ByVal nro_trans As String) As Integer
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer
        com.Connection = clConex
        com.CommandText = "select operacion from salida where cod_doc=90 and nro_doc='" & nro_trans & "'"
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Integer)
        clConex.Close()
        Return result
    End Function
    Public Function devOperacionI(ByVal nro_trans As String) As Integer
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer
        com.Connection = clConex
        com.CommandText = "select operacion from ingreso where cod_doc=90 and nro_doc='" & nro_trans & "'"
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Integer)
        clConex.Close()
        Return result
    End Function
    Public Function recNroTransferencia(ByVal operacionI As Integer, ByVal eHis As Boolean, ByVal nproceso As String) As String
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As String
        com.Connection = clConex
        If eHis Then
            com.CommandText = "select nro_doc from salida inner join salida_det on salida.operacion=salida_det.operacion  where nAux2=" & operacionI
        Else
            com.CommandText = "select nro_doc from h_salida h inner join h_salida_det hd on h.operacion=hd.operacion and h.proceso=hd.proceso where hd.proceso='" & nproceso & "'and hd.nAux2 = " & operacionI
        End If
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), "", obj), String)
        clConex.Close()
        Return result
    End Function
    Public Function recAlmaTransferencia(ByVal operacionI As Integer) As String
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As String
        com.Connection = clConex
        com.CommandText = "select cAux from salida inner join salida_det on salida.operacion=salida_det.operacion  where nAux2=" & operacionI
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), "", obj), String)
        clConex.Close()
        Return result
    End Function
    Public Function maxTransferencia() As Integer
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer
        com.Connection = clConex
        com.CommandText = "select max(nro_doc) from salida where cod_doc=90"
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Integer)
        clConex.Close()
        Return result + 1
    End Function
    Public Function recuperaNrosTransferencia(ByVal cod_alma As String) As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim da As New MySqlDataAdapter
        Dim dsTrans As New DataSet
        Dim cad, cad1, cad2, cad3, cod_trans As String
        cod_trans = "90"
        cad1 = "select operacion,fec_doc,fec_prod,concat(ser_doc,'-',nro_doc) as doc,ser_doc,nro_doc"
        cad2 = " from salida "
        cad3 = " where cod_doc='" & cod_trans & "'" & IIf(cod_alma = "0000", "", " and cod_alma= '" & cod_alma & "'")
        ' & " cod_doc='" & cod_trans & "' and cod_alma= '" & cod_alma & "' order by 1 desc,2"
        cad = cad1 + cad2 + cad3
        Dim comTrans As New MySqlCommand(cad)
        comTrans.Connection = clConex
        da.SelectCommand = comTrans
        da.Fill(dsTrans, "nrosTransferencia")
        clConex.Close()
        Return dsTrans
    End Function
    Public Function recuperaOperacionTrans_i(ByVal ser_doc As String, ByVal nro_doc As String) As Integer
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer, cad, cad1, cad2, cad3 As String
        com.Connection = clConex
        Dim cod_trans As String = "90"
        cad1 = "select operacion"
        cad2 = " from ingreso "
        cad3 = " where cod_doc='" & cod_trans & "' and ser_doc='" & ser_doc & "' and nro_doc='" & nro_doc & "'"
        cad = cad1 + cad2 + cad3
        com.CommandText = cad
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Integer)
        clConex.Close()
        Return result
    End Function
    Public Function recuperaObservacion(ByVal ser_doc As String, ByVal nro_doc As String) As String
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As String, cad, cad1, cad2, cad3 As String
        com.Connection = clConex
        Dim cod_trans As String = "90"
        cad1 = "select obs"
        cad2 = " from salida "
        cad3 = " where cod_doc='" & cod_trans & "' and ser_doc='" & ser_doc & "' and nro_doc='" & nro_doc & "'"
        cad = cad1 + cad2 + cad3
        com.CommandText = cad
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), "", obj), String)
        clConex.Close()
        Return result
    End Function
    Public Function recuperaNroIngresoTrans_i(ByVal ser_doc As String, ByVal nro_doc As String) As Integer
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer, cad, cad1, cad2, cad3 As String
        com.Connection = clConex
        Dim cod_trans As String = "90"
        cad1 = "select ingreso"
        cad2 = " from ingreso_det "
        cad3 = " where cod_doc='" & cod_trans & "' and ser_doc='" & ser_doc & "' and nro_doc='" & nro_doc & "'"
        cad = cad1 + cad2 + cad3
        com.CommandText = cad
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Integer)
        clConex.Close()
        Return result
    End Function
    Public Function recuperaOperacionTrans_s(ByVal ser_doc As String, ByVal nro_doc As String) As Integer
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As Integer, cad, cad1, cad2, cad3 As String
        com.Connection = clConex
        Dim cod_trans As String = "90"
        cad1 = "select operacion"
        cad2 = " from salida "
        cad3 = " where cod_doc='" & cod_trans & "' and ser_doc='" & ser_doc & "' and nro_doc='" & nro_doc & "'"
        cad = cad1 + cad2 + cad3
        com.CommandText = cad
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), 0, obj), Integer)
        clConex.Close()
        Return result
    End Function
    Public Function recuperaAlmacenTrans_dest(ByVal esHistorial As Boolean, ByVal ser_doc As String, ByVal nro_doc As String) As String
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As String, cad, cad1, cad2, cad3 As String
        com.Connection = clConex
        Dim cod_trans As String = "90"
        cad1 = "select cod_alma"
        cad2 = IIf(esHistorial, " from h_ingreso", " from ingreso ")
        cad3 = " where cod_doc='" & cod_trans & "' and ser_doc='" & ser_doc & "' and nro_doc='" & nro_doc & "'"
        cad = cad1 + cad2 + cad3
        com.CommandText = cad
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), "00A0", obj), String)
        clConex.Close()
        Return result
    End Function
    Public Function recuperaAlmacenTrans_Orig(ByVal esHistorial As Boolean, ByVal ser_doc As String, ByVal nro_doc As String) As String
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim com As New MySqlCommand, result As String, cad, cad1, cad2, cad3 As String
        com.Connection = clConex
        Dim cod_trans As String = "90"
        cad1 = "select cod_alma"
        cad2 = IIf(esHistorial, " from h_salida", " from salida ")
        cad3 = " where cod_doc='" & cod_trans & "' and ser_doc='" & ser_doc & "' and nro_doc='" & nro_doc & "'"
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
        Dim cod_trans As String = "90"
        cad1 = "select cod_area"
        cad2 = IIf(esHistorial, " from h_ingreso ", " from ingreso")
        cad3 = " where cod_doc='" & cod_trans & "' and ser_doc='" & ser_doc & "' and nro_doc='" & nro_doc & "'"
        cad = cad1 + cad2 + cad3
        com.CommandText = cad
        Dim obj As Object = com.ExecuteScalar
        result = CType(IIf(IsDBNull(obj), "0000", obj), String)
        clConex.Close()
        Return result
    End Function
    Public Function recuperaTransferencia(ByVal nroOpe As Integer) As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim da As New MySqlDataAdapter
        Dim dsTrans As New DataSet
        Dim cad, cad1, cad2, cad3, cad4, cad5, cad6, cad7, cad8, cad9, cad10, cod_trans As String
        cod_trans = "90"
        cad1 = "select distinct salida.operacion,salida_det.salida,salida_det.ingreso," _
                & "almacen.nom_alma as origen,salida.fec_doc,fec_prod," _
                & "concat(salida.ser_doc,'-',salida.nro_doc) as doc," _
                & "salida.fecha,ingreso.cuenta, "
        cad2 = " articulo.cod_art,nom_art,nom_uni,salida_det.cant,salida_det.cant_ped,aa.cant_stock,salida_det.precio," _
                & "salida.ser_doc,salida.nro_doc,concat(almacenD.nom_alma,'-',nom_area) as destino," _
                & "ingreso.operacion as operacionI,salida_det.nAux,salida.obs"
        cad3 = " from salida inner join salida_det on salida.operacion=salida_det.operacion"
        cad4 = " inner join articulo  on salida_det.cod_art=articulo.cod_art"
        cad5 = " inner join unidad on articulo.cod_uni=unidad.cod_uni"
        cad6 = " inner join almacen on salida.cod_alma=almacen.cod_alma" _
                & " left join art_almacen aa on salida.cod_alma=aa.cod_alma and articulo.cod_art=aa.cod_art "
        cad7 = " inner join ingreso on salida.cod_doc=ingreso.cod_doc and salida.ser_doc=ingreso.ser_doc and salida.nro_doc=ingreso.nro_doc"
        cad8 = " inner join almacen as almacenD on ingreso.cod_alma=almacenD.cod_alma"
        cad9 = " inner join area on area.cod_area=ingreso.cod_area"
        cad10 = " where salida.operacion=" & nroOpe & " and salida.cod_doc='" & cod_trans & "'" _
                & " group by salida_det.salida order by nom_art"
        cad = cad1 + cad2 + cad3 + cad4 + cad5 + cad6 + cad7 + cad8 + cad9 + cad10
        Dim comTrans As New MySqlCommand(cad)
        comTrans.Connection = clConex
        da.SelectCommand = comTrans
        da.Fill(dsTrans, "transferencia")
        clConex.Close()
        Return dsTrans
    End Function
    Public Function recuperaTransferencias(ByVal esHistorial As Boolean, ByVal nroProceso As String,
                        ByVal esMensual As Boolean, ByVal fechaInicio As Date, ByVal fechaFinal As Date,
                        ByVal nroDecimales As Integer, ByVal xAlmacenO As Boolean, ByVal xAlmacenD As Boolean,
                        ByVal cod_alma As String, ByVal xusuario As Boolean, ByVal cod_usuario As String, ByVal xnroTrans As Boolean, ByVal nro_trans As String, ByVal xPedPend As Boolean) As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim da As New MySqlDataAdapter
        Dim dsTrans As New DataSet
        Dim mfechaI As String = fechaInicio.ToString("yyyy-MM-dd")
        Dim mfechaF As String = fechaFinal.ToString("yyyy-MM-dd")
        Dim cad, cad1, cad2, cad3, cad4, cad5, cad6, cad7, cad8, cad9, cad10, cod_trans As String
        cod_trans = "90"
        cad1 = "select almacen.nom_alma as origen,hs.fec_doc,concat(hs.ser_doc,'-',hs.nro_doc) as doc, hs.fec_prod," & IIf(xPedPend, "cant_ped-cant as cant", "cant")
        cad2 = ",articulo.cod_art,nom_art,nom_uni,nom_sgrupo as Grupo,hsd.cant,hsd.precio,hsd.cant*hsd.precio as total,hs.ser_doc,hs.nro_doc,almacenD.nom_alma as destino, area.nom_area as area,hsd.operacion,hsd.salida,hsd.ingreso,hsd.nAux,hs.obs " _
             & ",u.user as cuenta,hsd.usu_ins,hsd.fec_ins,hs.fec_prod as fec_ent"
        If esHistorial Then
            cad3 = " from h_salida as hs inner join h_salida_det as hsd on hs.operacion= hsd.operacion and hs.proceso=hsd.proceso left join usuario u on hs.cuenta=u.cuenta"
        Else
            cad3 = " from salida as hs inner join salida_det as hsd on hs.operacion= hsd.operacion left join usuario u on hs.cuenta=u.cuenta"
        End If
        cad4 = " inner join articulo on hsd.cod_art=articulo.cod_art inner join subgrupo s on articulo.cod_sgrupo=s.cod_sgrupo"
        cad5 = " inner join unidad on articulo.cod_uni=unidad.cod_uni"
        cad6 = " inner join almacen on hs.cod_alma=almacen.cod_alma"
        cad7 = " inner join almacen as almacenD on hs.cAux=almacenD.cod_alma"
        cad8 = " inner join area on hs.cAux2=area.cod_area left join pedido p on p.ser_ped=hs.ser_doc and p.nro_ped=hs.nro_doc "
        cad9 = " where hs.cod_doc='" & cod_trans & "'" _
                    & IIf(esMensual, " and hs.fec_doc>='" & mfechaI & "' and hs.fec_doc<='" & mfechaF & "'", " and hs.proceso='" & nroProceso & "' and hsd.proceso='" & nroProceso & "'") _
                    & IIf(xusuario, " and hs.cuenta='" & cod_usuario & "'", "") _
                    & IIf(xAlmacenO, " and hs.cod_alma='" & cod_alma & "'", "") _
                    & IIf(xAlmacenD, " and hs.cAux='" & cod_alma & "'", "") _
                    & IIf(xnroTrans, " and hs.nro_doc='" & nro_trans & "'", "") _
                    & IIf(xPedPend, " and espendiente=1 ", "")
        '& IIf(esHistorial, " and hs.proceso='" & nroProceso & "' and hsd.proceso='" & nroProceso & "'", "") _
        cad10 = " order by hs.fec_doc desc,salida desc"
        cad = cad1 + cad2 + cad3 + cad4 + cad5 + cad6 + cad7 + cad8 + cad9 + cad10
        Dim comTrans As New MySqlCommand(cad)
        comTrans.Connection = clConex
        comTrans.CommandTimeout = 9000
        da.SelectCommand = comTrans
        da.Fill(dsTrans, "transferencia")
        clConex.Close()
        Return dsTrans
    End Function
    Public Function recuperaTransferencias_pend(ByVal esHistorial As Boolean, ByVal nroProceso As String,
                        ByVal esMensual As Boolean, ByVal fechaInicio As Date, ByVal fechaFinal As Date,
                        ByVal nroDecimales As Integer, ByVal xAlmacenO As Boolean, ByVal xAlmacenD As Boolean,
                        ByVal cod_alma As String, ByVal xusuario As Boolean, ByVal cod_usuario As String, ByVal xnroTrans As Boolean, ByVal nro_trans As String, ByVal xPedPend As Boolean) As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim da As New MySqlDataAdapter
        Dim dsTrans As New DataSet
        Dim mfechaI As String = fechaInicio.ToString("yyyy-MM-dd")
        Dim mfechaF As String = fechaFinal.ToString("yyyy-MM-dd")
        Dim cad, cad1, cad2, cad3, cad4, cad5, cad6, cad7, cad8, cad9, cad10, cod_trans As String
        cod_trans = "90"
        cad1 = "select almacen.nom_alma as origen,hs.fec_doc,concat(hs.ser_doc,'-',hs.nro_doc) as doc,hs.cuenta,pedido.fec_ped, hs.fec_prod," & IIf(xPedPend, "cant_ped-cant as cant", "cant")
        cad2 = ",articulo.cod_art,nom_art,nom_uni,nom_sgrupo as Grupo,hsd.cant,hsd.precio,hs.ser_doc,hs.nro_doc,almacenD.nom_alma as destino, area.nom_area as area,hsd.operacion,hsd.salida,hsd.ingreso,hsd.nAux,hs.obs " _
               & ",pedido.cuenta as responsable,pedido.cod_pedido,tr.dsc_recurso"
        If esHistorial Then
            cad3 = " from h_salida as hs inner join h_salida_det as hsd on hs.operacion= hsd.operacion and hs.proceso=hsd.proceso"
        Else
            cad3 = " from salida as hs inner join salida_det as hsd on hs.operacion= hsd.operacion"
        End If
        cad4 = " inner join articulo on hsd.cod_art=articulo.cod_art inner join subgrupo s on articulo.cod_sgrupo=s.cod_sgrupo"
        cad5 = " inner join unidad on articulo.cod_uni=unidad.cod_uni"
        cad6 = " inner join almacen on hs.cod_alma=almacen.cod_alma"
        cad7 = " inner join almacen as almacenD on hs.cAux=almacenD.cod_alma"
        cad8 = " inner join area on hs.cAux2=area.cod_area left join pedido on ser_ped=hs.ser_doc and nro_ped=hs.nro_doc " _
               & " left join tipo_recurso tr on cod_recurso = pedido.cod_pedido and cod_tabla='tip_pedido' "
        cad9 = " where hs.cod_doc='" & cod_trans & "'" _
                    & IIf(esHistorial, " and hs.proceso='" & nroProceso & "' and hsd.proceso='" & nroProceso & "'", "") _
                    & IIf(esMensual, "", " and hs.fec_doc>='" & mfechaI & "' and hs.fec_doc<='" & mfechaF & "'") _
                    & IIf(xusuario, " and hs.cuenta='" & cod_usuario & "'", "") _
                    & IIf(xAlmacenO, " and hs.cod_alma='" & cod_alma & "'", "") _
                    & IIf(xAlmacenD, " and hs.cAux='" & cod_alma & "'", "") _
                    & IIf(xnroTrans, " and hs.nro_doc='" & nro_trans & "'", "") _
                    & IIf(xPedPend, " and espendiente=1 ", "")
        cad10 = " order by hs.fec_doc desc,salida desc"
        cad = cad1 + cad2 + cad3 + cad4 + cad5 + cad6 + cad7 + cad8 + cad9 + cad10
        Dim comTrans As New MySqlCommand(cad)
        comTrans.Connection = clConex
        comTrans.CommandTimeout = 9000
        da.SelectCommand = comTrans
        da.Fill(dsTrans, "transferencia")
        clConex.Close()
        Return dsTrans
    End Function
    Public Function recuperaProducciones(ByVal esHistorial As Boolean, ByVal nroProceso As String, _
                            ByVal esMensual As Boolean, ByVal fechaInicio As Date, ByVal fechaFinal As Date, _
                            ByVal nroDecimales As Integer, ByVal xAlmacenO As Boolean, _
                             ByVal cod_alma As String, ByVal xArticulo As Boolean, ByVal cod_art As String) As DataSet
        Dim clConex As MySqlConnection = Conexion.obtenerConexion
        Dim da As New MySqlDataAdapter
        Dim dsTrans As New DataSet
        Dim mfechaI As String = fechaInicio.ToString("yyyy-MM-dd")
        Dim mfechaF As String = fechaFinal.ToString("yyyy-MM-dd")
        Dim cad, cad1, cad2, cad3, cad4, cad5, cad6, cad7, cad8, cad9, cod_trans As String
        cod_trans = "90"
        cad1 = "select almacen.nom_alma as origen,hs.fec_doc,concat(hs.ser_doc,'-',hs.nro_doc) as doc, "
        cad2 = " articulo.cod_art,nom_art,nom_uni,hsd.cant,hsd.precio,hs.ser_doc,hs.nro_doc"
        If esHistorial Then
            cad3 = " from h_salida as hs inner join h_salida_det as hsd on hs.operacion= hsd.operacion and hs.proceso=hsd.proceso"
        Else
            cad3 = " from salida as hs inner join salida_det as hsd on hs.operacion= hsd.operacion"
        End If
        cad4 = " inner join articulo on hsd.cod_art=articulo.cod_art"
        cad5 = " inner join unidad on articulo.cod_uni=unidad.cod_uni"
        cad6 = " inner join almacen on hs.cod_alma=almacen.cod_alma"
        cad7 = " inner join almacen as almacenD on hs.cAux=almacenD.cod_alma"
        cad8 = " where hs.cod_doc='" & cod_trans & "'" _
                    & IIf(esHistorial, " and hs.proceso='" & nroProceso & "' and hsd.proceso='" & nroProceso & "'", "") _
                    & IIf(esMensual, "", " and hs.fec_doc>='" & mfechaI & "' and hs.fec_doc<='" & mfechaF & "'") _
                    & IIf(xArticulo, " and hsd.cod_art='" & cod_art & "'", "") _
                    & IIf(xAlmacenO, " and hs.cod_alma='" & cod_alma & "'", "")
        cad9 = " order by hs.fec_doc desc,salida desc"
        cad = cad1 + cad2 + cad3 + cad4 + cad5 + cad6 + cad7 + cad8 + cad9
        Dim comTrans As New MySqlCommand(cad)
        comTrans.Connection = clConex
        da.SelectCommand = comTrans
        da.Fill(dsTrans, "transferencia")
        clConex.Close()
        Return dsTrans
    End Function

End Class
