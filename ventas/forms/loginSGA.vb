Imports libreriaClases
Imports MySql.Data.MySqlClient
Public Class Login
    'para validar el separador decimal
    Private sepDecimal As Char
    Private Sub login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'capturamos el separador decimal
        Dim mes, anno As Integer
        Dim NomMes As String
        mes = Month(pFechaActivaMax)
        NomMes = UCase(MonthName(mes, True))
        anno = Year(pFechaActivaMax)
        LblPeriodo.Text = "Periodo Activo :" & NomMes & "-" & CType(anno, String)
        sepDecimal = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        Dim mTC As New TipoCambio
        'txtTC.Text = mTC.recupera(pFechaSystem)
        pTC = mTC.recupera(pFechaSystem)
        Lbltipcambio.Text = "Tipo de Cambio :" & mTC.recupera(pFechaSystem)
        
    End Sub
    Private Sub cmdContinuar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdContinuar.Click
        ingresaSystem()
    End Sub
    Sub ingresaSystem()
        If usuario.ingresoSistema(txtUsuario.Text, txtClave.Text) = True Then
            pNombreUser = txtUsuario.Text
            pCuentaUser = txtUsuario.Text
            pNivelUser = usuario.recuperaNivelUsuario(txtUsuario.Text)
            pAlmaUser = usuario.recuperaAlmacenUsuario(txtUsuario.Text)
            pDatosUser = usuario.recuperaDatosUsuario(txtUsuario.Text)
            Dim com As New MySqlCommand("select * from configuracion where activo='1'", dbConex)
            Dim dr As MySqlDataReader
            dr = com.ExecuteReader
            If dr.HasRows = True Then
                While dr.Read
                    pIGV = dr("igv")
                    pEmpresa = dr("cod_emp")
                    pNempresa = dr("nom_emp")
                    pDecimales = dr("nros_decimales")
                    pDiasModificarIngreso = dr("dias_modificar_ingreso")
                    pDiasModificarPedido = dr("dias_modificar_pedido")
                    pDiasModificarSalida = dr("dias_modificar_salida")
                    pPreciosIncIGV = dr("precios_inc_igv")
                    pDespachoXprecioVenta = dr("despacho_x_pre_venta")
                    pDespachoXtipoCliente = dr("despacho_x_tipo_cliente")
                    pModoPedidos = dr("modo_pedidos")
                    pDiasModificarInventario = dr("dias_modificar_inventario")
                    pMoneda = dr("moneda")
                    pMonedaAbr = dr("monedaAbr")
                    pCatalogoXalmacen = dr("catalogo_x_almacen")
                    pLogo = dr("Logo")
                    pImpuestoXarticulo = dr("impuesto_x_articulo")
                    pDiasModificarTrans = dr("dias_modificar_trans")
                    pDespachoStock0 = dr("despacho_stock0")
                    pDiasModificarBaja = dr("dias_modificar_baja")
                End While
                If pModoPedidos Then
                    principal.mp_salidas.Enabled = False
                    principal.mp_transferencia.Enabled = False
                    principal.mp_ventas.Enabled = True
                    principal.mp_pedidos.Enabled = True
                Else
                    principal.mp_salidas.Enabled = True
                    principal.mp_transferencia.Enabled = True
                    principal.mp_ventas.Enabled = False
                    principal.mp_pedidos.Enabled = False
                End If
                If pCatalogoXalmacen Then
                    principal.ma_catalogo2.Enabled = True
                Else
                    principal.ma_catalogo2.Enabled = False
                End If
                'establecemos permisos de usuario
                Dim ds As New DataSet, I As Integer, cod_smenu As String
                Dim musuario As New usuario, activo As Boolean
                ds = musuario.permisos(pCuentaUser)
                If ds.Tables("permisos").Rows.Count > 0 Then
                    For I = 0 To ds.Tables("permisos").Rows.Count - 1
                        cod_smenu = ds.Tables("permisos").Rows(I).Item("cod_smenu").ToString()
                        activo = ds.Tables("permisos").Rows(I).Item("activo").ToString()
                        asignaPermisos(cod_smenu, activo)
                    Next
                End If
            Else
                MessageBox.Show("NO es Posible Cargar la Configuración del Sistema...")
                End
            End If
            dr.Close()
            principal.Show()
            Me.Hide()
        Else
            pNombreUser = ""
            pCuentaUser = ""
            MessageBox.Show("Acceso Denegado...", "Cefe", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub txtTC_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTC.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not (e.KeyChar = ChrW(Keys.Back)) And Not (e.KeyChar.Equals(sepDecimal)) Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub txtUsuario_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUsuario.GotFocus
        general.ingresaTexto(txtUsuario)
    End Sub
    Private Sub txtUsuario_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUsuario.LostFocus
        general.saleTexto(txtUsuario)
    End Sub
    Private Sub txtClave_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtClave.GotFocus
        general.ingresaTexto(txtClave)
    End Sub
    Private Sub txtClave_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtClave.LostFocus
        general.saleTexto(txtClave)
    End Sub
    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        End
    End Sub

    Private Sub txtTC_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTC.TextChanged

    End Sub

    Private Sub txtClave_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtClave.TextChanged

    End Sub
End Class

