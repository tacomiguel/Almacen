Imports MySql.Data.MySqlClient
Imports libreriaClases
Public Class u_variables

    Private Sub u_variables_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        principal.mu_configuracion.Enabled = True
    End Sub

    Private Sub u_variables_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim com As New MySqlCommand("select * from configuracion where activo='1'", dbConex)
        Dim dr As MySqlDataReader
        dr = com.ExecuteReader
        If dr.HasRows = True Then
            While dr.Read
                'pIGV = dr("igv")
                txtRuc.Text = dr("cod_emp")
                txtEmpresa.Text = dr("nom_emp")
                txtdireccion.Text = dr("dir_emp")
                txtpais.Text = dr("pais_emp")
                'pDecimales = dr("nros_decimales")
                'pDiasModificarIngreso = dr("dias_modificar_ingreso")
                'pDiasModificarPedido = dr("dias_modificar_pedido")
                'pDiasModificarSalida = dr("dias_modificar_salida")
                'pPreciosIncIGV = dr("precios_inc_igv")
                'pDespachoXprecioVenta = dr("despacho_x_pre_venta")
                'pDespachoXtipoCliente = dr("despacho_x_tipo_cliente")
                'pModoPedidos = dr("modo_pedidos")
                'pDiasModificarInventario = dr("dias_modificar_inventario")
                'pMoneda = dr("moneda")
                'pMonedaAbr = dr("monedaAbr")
                'pCatalogoXalmacen = dr("catalogo_x_almacen")
                'pLogo = dr("Logo")
                'pImpuestoXarticulo = dr("impuesto_x_articulo")
                'pDiasModificarTrans = dr("dias_modificar_trans")
                'pDespachoStock0 = dr("despacho_stock0")
                'pDiasModificarBaja = dr("dias_modificar_baja")
            End While
        End If
        dr.Close()
    End Sub

    Private Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click
        Dim mutilidades As New Utilidades
        mutilidades.actualiza_empresa(txtRuc.Text, txtEmpresa.Text, txtdireccion.Text, txtpais.Text)
    End Sub
End Class
