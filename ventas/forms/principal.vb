Imports System.Windows.Forms
'Imports System.Data
'Imports libreriaClases
Public Class principal
    Private Sub mnu_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_exit.Click
        Me.Close()
        End
    End Sub
    Private Sub ma_catalogo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ma_catalogo.Click
        ma_catalogo.Enabled = False
        m_catalogo.MdiParent = Me
        m_catalogo.Show()
    End Sub
    Private Sub ma_catalogo2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ma_catalogo2.Click
        ma_catalogo2.Enabled = False
        m_catalogo2.MdiParent = Me
        m_catalogo2.Show()
    End Sub
    Private Sub ma_familia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ma_familia.Click
        ma_familia.Enabled = False
        m_familia.MdiParent = Me
        m_familia.Show()
    End Sub
    Private Sub ma_sgrupo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ma_sgrupo.Click
        ma_sgrupo.Enabled = False
        m_subgrupo.MdiParent = Me
        m_subgrupo.Show()
    End Sub
    Private Sub ma_unidades_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ma_unidades.Click
        ma_unidades.Enabled = False
        m_unidad.MdiParent = Me
        m_unidad.Show()
    End Sub

    Private Sub ma_tarticulo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ma_tArticulo.Click
        ma_tArticulo.Enabled = False
        m_tipo_articulo.MdiParent = Me
        m_tipo_articulo.Show()
    End Sub
    Private Sub ma_rendimiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ma_rendimiento.Click
        ma_rendimiento.Enabled = False
        m_rendimiento.MdiParent = Me
        m_rendimiento.Show()
    End Sub
    Private Sub ma_plancuentas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ma_planCuentas.Click
        ma_planCuentas.Enabled = False
        m_planCuentas.MdiParent = Me
        m_planCuentas.Show()
    End Sub
    Private Sub ma_precios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ma_precios.Click
        ma_precios.Enabled = False
        m_precios.MdiParent = Me
        m_precios.Show()
    End Sub
    Private Sub ma_almacen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ma_almacen.Click
        ma_almacen.Enabled = False
        m_almacen.MdiParent = Me
        m_almacen.Show()
    End Sub
    Private Sub ma_maximos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ma_maximos.Click
        ma_maximos.Enabled = False
        m_maximos.MdiParent = Me
        m_maximos.Show()
    End Sub
    Private Sub ma_cliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ma_cliente.Click
        ma_cliente.Enabled = False
        m_cliente.MdiParent = Me
        m_cliente.Show()
    End Sub
    Private Sub ma_tcliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ma_tcliente.Click
        ma_tcliente.Enabled = False
        m_tipo_cliente.MdiParent = Me
        m_tipo_cliente.Show()
    End Sub
    Private Sub ma_proveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ma_proveedor.Click
        ma_proveedor.Enabled = False
        m_proveedor.MdiParent = Me
        m_proveedor.Show()
    End Sub
    Private Sub ma_tproveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ma_tproveedor.Click
        ma_tproveedor.Enabled = False
        m_tipo_proveedor.MdiParent = Me
        m_tipo_proveedor.Show()
    End Sub
    Private Sub ma_transporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ma_transporte.Click
        ma_transporte.Enabled = False
        m_empTransporte.MdiParent = Me
        m_empTransporte.Show()
    End Sub
    Private Sub ma_conductor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ma_conductor.Click
        ma_conductor.Enabled = False
        m_conductor.MdiParent = Me
        m_conductor.Show()
    End Sub
    Private Sub ma_motivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ma_motivo.Click
        ma_motivo.Enabled = False
        m_motivo.MdiParent = Me
        m_motivo.Show()
    End Sub
    Private Sub ma_vendedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ma_vendedor.Click
        ma_vendedor.Enabled = False
        m_vendedor.MdiParent = Me
        m_vendedor.Show()
    End Sub
    Private Sub mr_cuentaC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mr_cuentaC.Click
        Dim frm As New rptForm
        frm.cargarCuentaCobrar(True)
        frm.MdiParent = Me
        frm.Show()
    End Sub
    Private Sub mr_niveles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mr_niveles.Click
        mr_niveles.Enabled = False
        c_nivelesAbastecimiento.MdiParent = Me
        c_nivelesAbastecimiento.Show()
    End Sub
    Private Sub mr_saldos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mr_saldos.Click
        mr_saldos.Enabled = False
        repSaldos.MdiParent = Me
        repSaldos.Show()
    End Sub
    Private Sub mr_transferencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mr_transferencia.Click
        mr_transferencia.Enabled = False
        repTransferencias.MdiParent = Me
        repTransferencias.Show()
    End Sub
    Private Sub mr_recetas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mr_recetas.Click
        mr_recetas.Enabled = False
        c_recetas.MdiParent = Me
        c_recetas.Show()
    End Sub
    Private Sub mr_ventaRest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mr_ventaRest.Click
        mr_ventaRest.Enabled = False
        c_ventas.MdiParent = Me
        c_ventas.Show()
    End Sub
    Private Sub mr_comisiones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mr_comisiones.Click
        mr_comisiones.Enabled = False
        repComisiones.MdiParent = Me
        repComisiones.Show()
    End Sub
    Private Sub mr_ventas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mr_ventas.Click
        mr_ventas.Enabled = False
        repVentas.MdiParent = Me
        repVentas.Show()
    End Sub
    Private Sub mr_pedidos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mr_pedidos.Click
        mr_pedidos.Enabled = False
        repPedidos.MdiParent = Me
        repPedidos.Show()
    End Sub
    Private Sub mr_ingresos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mr_ingresos.Click
        mr_ingresos.Enabled = False
        repIngresos.MdiParent = Me
        repIngresos.Show()
    End Sub
    Private Sub mr_movimientos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mr_movimientos.Click
        mr_movimientos.Enabled = False
        c_movimientos.MdiParent = Me
        c_movimientos.Show()
    End Sub
    Private Sub mr_inventarios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mr_inventarios.Click
        mr_inventarios.Enabled = False
        c_inventarios.MdiParent = Me
        c_inventarios.Show()
    End Sub
    Private Sub principal_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'If MessageBox.Show("¿Desea Salir?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
        '    ' Con el if, mandamos el messagebox y si la respuesta es un No, entonces cancela el método closing
        '    Me.Show()
        'End If
        Application.ExitThread()
        End
    End Sub
    Private Sub mr_kardex_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mr_kardex.Click
        mr_kardex.Enabled = False
        c_kardex.MdiParent = Me
        c_kardex.Show()
    End Sub
    Private Sub mc_mermas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mc_mermas.Click
        mc_mermas.Enabled = False
        repNivelesAbastecimiento.MdiParent = Me
        repNivelesAbastecimiento.Show()
    End Sub
    Private Sub mp_transferencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mp_transferencia.Click
        mp_transferencia.Enabled = False
        p_transferencia.MdiParent = Me
        p_transferencia.Show()
    End Sub
    Private Sub mp_notaCredito_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mp_notaCredito.Click
        mp_notaCredito.Enabled = False
        p_notaCredito.MdiParent = Me
        p_notaCredito.Show()
    End Sub
    Private Sub mp_salidas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mp_salidas.Click
        mp_salidas.Enabled = False
        p_salidas.MdiParent = Me
        p_salidas.Show()
    End Sub
    Private Sub mp_pedidos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mp_pedidos.Click
        mp_pedidos.Enabled = False
        p_pedido.MdiParent = Me
        p_pedido.Show()
    End Sub
    Private Sub mp_ventas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mp_ventas.Click
        mp_ventas.Enabled = False
        p_ventas.MdiParent = Me
        p_ventas.Show()
    End Sub
    Private Sub mp_ingreso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mp_ingreso.Click
        mp_ingreso.Enabled = False
        p_ingresos.MdiParent = Me
        p_ingresos.Show()
    End Sub
    Private Sub mp_transformaciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mp_transformaciones.Click
        mp_transformaciones.Enabled = False
        p_transformaciones.MdiParent = Me
        p_transformaciones.Show()
    End Sub
    Private Sub mp_recetas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mp_recetas.Click
        mp_recetas.Enabled = False
        p_receta.MdiParent = Me
        p_receta.Show()
    End Sub
    Private Sub mp_actualizaRecetas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mp_actualizaRecetas.Click
        mp_actualizaRecetas.Enabled = False
        p_actualizaRecetas.MdiParent = Me
        p_actualizaRecetas.Show()
    End Sub
    Private Sub mp_producciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mp_producciones.Click
        mp_producciones.Enabled = False
        p_produccion.MdiParent = Me
        p_produccion.Show()
    End Sub
    Private Sub mp_cuentaC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mp_cuentaC.Click
        mp_cuentaC.Enabled = False
        p_cuenta_cobrar.MdiParent = Me
        p_cuenta_cobrar.Show()
    End Sub
    Private Sub mp_cuentaP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mp_cuentaP.Click

    End Sub
    Private Sub mp_mermas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mp_mermas.Click
        mp_mermas.Enabled = False
        p_mermas.MdiParent = Me
        p_mermas.Show()
    End Sub
    Private Sub mp_invInicial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mp_invInicial.Click
        mp_invInicial.Enabled = False
        p_inventario.MdiParent = Me
        p_inventario.Show()
    End Sub

    Private Sub mp_invDiario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mp_invDiario.Click
        mp_invDiario.Enabled = False
        'p_inventarioDiario.MdiParent = Me
        'p_inventarioDiario.Show()
        p_conteoFisico.MdiParent = Me
        p_conteoFisico.Show()
    End Sub
    Private Sub mp_invMensual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mp_invMensual.Click
        mp_invMensual.Enabled = False
        p_inventarioMensual.MdiParent = Me
        p_inventarioMensual.Show()
    End Sub

    Private Sub me_precios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles me_precios.Click
        me_precios.Enabled = False
        e_precios.MdiParent = Me
        e_precios.Show()
    End Sub
    Private Sub me_ventas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles me_ventas.Click
        me_ventas.Enabled = False
        e_ventas.MdiParent = Me
        e_ventas.Show()
    End Sub
    Private Sub mu_configuracion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mu_configuracion.Click
        mu_configuracion.Enabled = True
        u_variables.MdiParent = Me
        u_variables.Show()
    End Sub
    Private Sub mu_usuarios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mu_usuarios.Click
        mu_usuarios.Enabled = False
        u_usuarios.MdiParent = Me
        u_usuarios.Show()
    End Sub
    Private Sub mu_envioCompras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mu_envioCompras.Click
        mu_envioCompras.Enabled = False
        u_envioCompras.MdiParent = Me
        u_envioCompras.Show()
    End Sub
    Private Sub mu_envioVentas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mu_envioVentas.Click
        mu_envioVentas.Enabled = False
        u_envioVentas.MdiParent = Me
        u_envioVentas.Show()
    End Sub
    Private Sub mu_pixelPoint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mu_importarventas.Click
        mu_importarventas.Enabled = False
        u_importaVentas_dbf.MdiParent = Me
        u_importaVentas_dbf.Show()
    End Sub
    Private Sub mu_micros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mu_micros.Click
        'mu_micros.Enabled = False
        'u_importaMicros.MdiParent = Me
        'u_importaMicros.Show()
    End Sub
    Private Sub mu_codigosExt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mu_codigosExt.Click
        mu_codigosExt.Enabled = False
        u_codigosExt.MdiParent = Me
        u_codigosExt.Show()
    End Sub
    Private Sub mu_tipoCambio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mu_tipoCambio.Click
        mu_tipoCambio.Enabled = False
        u_tipoCambio.MdiParent = Me
        u_tipoCambio.Show()
    End Sub
    Private Sub principal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim tit As String = general.tituloVentanaPrincipal()
        Me.Text = tit
        lblUsuario.Text = "Usuario Activo: " & pDatosUser
    End Sub
    Private Sub mu_actLotes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mu_actLotes.Click
        mu_actLotes.Enabled = False
        u_actLotes.MdiParent = Me
        u_actLotes.Show()
    End Sub

    Private Sub RibbonControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RibbonControl1.Click

    End Sub

    Private Sub lblUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblUsuario.Click

    End Sub

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub


    Private Sub ButtonItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem16.Click
        ButtonItem16.Enabled = False
        'repProducciones.MdiParent = Me
        'repProducciones.Show()
    End Sub



    Private Sub mu_impventas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mu_impventas.Click
        mu_impventas.Enabled = False
        u_importaVentas_dbf.MdiParent = Me
        u_importaVentas_dbf.Show()
    End Sub

    Private Sub mu_procventas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mu_procventas.Click
        mu_procventas.Enabled = False
        u_importaMicros.MdiParent = Me
        u_importaMicros.Show()
    End Sub

    Private Sub mp_ocompra_Click(sender As Object, e As EventArgs) Handles mp_ocompra.Click
        mp_ocompra.Enabled = False
        p_ordencompra.MdiParent = Me
        p_ordencompra.Show()
    End Sub

    Private Sub ButtonItem14_Click(sender As Object, e As EventArgs) Handles mu_cierreinv.Click
        mu_cierreinv.Enabled = False
        u_Cierreinventario.MdiParent = Me
        u_Cierreinventario.Show()
    End Sub
End Class
