<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class repIngresos
    Inherits cefe.baseReporte

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(repIngresos))
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.grupo = New System.Windows.Forms.GroupBox()
        Me.chkCostosMonedaCompra = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.OptOCompra = New System.Windows.Forms.RadioButton()
        Me.optComprasProveedor = New System.Windows.Forms.RadioButton()
        Me.optComprasProducto = New System.Windows.Forms.RadioButton()
        Me.optRegistro = New System.Windows.Forms.RadioButton()
        Me.chkDetalle = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.dataDetalle = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.grupoAlmacen = New System.Windows.Forms.GroupBox()
        Me.cboGrupo = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.chkGrupo = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.chkAlmacen = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.cboAlmacen = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.cboEmpresa = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.chkDia = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.dtiHasta = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.dtiDesde = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.cboAnno = New System.Windows.Forms.ComboBox()
        Me.cboMes = New System.Windows.Forms.ComboBox()
        Me.lblRegistros = New DevComponents.DotNetBar.LabelX()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.chkDolares = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.chkMoneda = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.chkIMP = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.tabIngresos = New DevComponents.DotNetBar.TabControl()
        Me.TabControlPanel4 = New DevComponents.DotNetBar.TabControlPanel()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.lblMontoDS = New DevComponents.DotNetBar.LabelX()
        Me.lblMonedaDS = New DevComponents.DotNetBar.LabelX()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.lblMontoD = New DevComponents.DotNetBar.LabelX()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblMonto = New DevComponents.DotNetBar.LabelX()
        Me.lblMoneda = New DevComponents.DotNetBar.LabelX()
        Me.tabCompras = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel5 = New DevComponents.DotNetBar.TabControlPanel()
        Me.barraResumen = New DevComponents.DotNetBar.Controls.ProgressBarX()
        Me.chkAlmacenResumen = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.cboAlmacenResumen = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.lblMensaje = New DevComponents.DotNetBar.LabelX()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtBuscarResumenAnual = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.optDescripcion = New System.Windows.Forms.RadioButton()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.optValorizado = New System.Windows.Forms.RadioButton()
        Me.optCantidades = New System.Windows.Forms.RadioButton()
        Me.dataResumenAnual = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.tabResumen = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel2 = New DevComponents.DotNetBar.TabControlPanel()
        Me.dataResumenGrupo = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.tabGrupos = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel1 = New DevComponents.DotNetBar.TabControlPanel()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.chartCompras = New DevComponents.DotNetBar.MicroChart()
        Me.tabEstadisticas = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.chkSoloCompras = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.chkAgrupar = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.optOrdenMonto = New System.Windows.Forms.RadioButton()
        Me.optOrdenProveedor = New System.Windows.Forms.RadioButton()
        Me.optOrdenProducto = New System.Windows.Forms.RadioButton()
        Me.optOrdenDocumento = New System.Windows.Forms.RadioButton()
        Me.optOrdenFecha = New System.Windows.Forms.RadioButton()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.ordenAsc = New System.Windows.Forms.PictureBox()
        Me.chkResumen = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.optGuia = New System.Windows.Forms.RadioButton()
        Me.optProveedor = New System.Windows.Forms.RadioButton()
        Me.optDocumento = New System.Windows.Forms.RadioButton()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.txtBuscar = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lblBuscar = New DevComponents.DotNetBar.LabelX()
        Me.ordenDesc = New System.Windows.Forms.PictureBox()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.ComboBoxEx1 = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.cmdImprimir = New DevExpress.DXCore.Controls.XtraEditors.SimpleButton()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.grupo.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dataDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupoAlmacen.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.dtiHasta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtiDesde, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabIngresos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabIngresos.SuspendLayout()
        Me.TabControlPanel4.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlPanel5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        CType(Me.dataResumenAnual, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlPanel2.SuspendLayout()
        CType(Me.dataResumenGrupo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlPanel1.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.ordenAsc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox9.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ordenDesc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox8.SuspendLayout()
        Me.SuspendLayout()
        '
        'grupo
        '
        Me.grupo.Controls.Add(Me.chkCostosMonedaCompra)
        Me.grupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupo.ForeColor = System.Drawing.Color.Maroon
        Me.grupo.Location = New System.Drawing.Point(572, 43)
        Me.grupo.Name = "grupo"
        Me.grupo.Size = New System.Drawing.Size(302, 40)
        Me.grupo.TabIndex = 45
        Me.grupo.TabStop = False
        '
        'chkCostosMonedaCompra
        '
        Me.chkCostosMonedaCompra.AutoSize = True
        '
        '
        '
        Me.chkCostosMonedaCompra.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chkCostosMonedaCompra.Checked = True
        Me.chkCostosMonedaCompra.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCostosMonedaCompra.CheckValue = "Y"
        Me.chkCostosMonedaCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCostosMonedaCompra.Location = New System.Drawing.Point(5, 15)
        Me.chkCostosMonedaCompra.Name = "chkCostosMonedaCompra"
        Me.chkCostosMonedaCompra.Size = New System.Drawing.Size(307, 15)
        Me.chkCostosMonedaCompra.TabIndex = 138
        Me.chkCostosMonedaCompra.Text = "Mostrar Compras en Moneda de Adquisición de Productos"
        Me.chkCostosMonedaCompra.TextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.OptOCompra)
        Me.GroupBox2.Controls.Add(Me.optComprasProveedor)
        Me.GroupBox2.Controls.Add(Me.optComprasProducto)
        Me.GroupBox2.Controls.Add(Me.optRegistro)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(332, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(147, 107)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tipo de Reporte"
        '
        'OptOCompra
        '
        Me.OptOCompra.AutoSize = True
        Me.OptOCompra.Checked = True
        Me.OptOCompra.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptOCompra.ForeColor = System.Drawing.Color.Black
        Me.OptOCompra.Location = New System.Drawing.Point(8, 16)
        Me.OptOCompra.Name = "OptOCompra"
        Me.OptOCompra.Size = New System.Drawing.Size(134, 18)
        Me.OptOCompra.TabIndex = 5
        Me.OptOCompra.TabStop = True
        Me.OptOCompra.Text = "Registro de O. Compra"
        Me.OptOCompra.UseVisualStyleBackColor = True
        '
        'optComprasProveedor
        '
        Me.optComprasProveedor.AutoSize = True
        Me.optComprasProveedor.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optComprasProveedor.ForeColor = System.Drawing.Color.Black
        Me.optComprasProveedor.Location = New System.Drawing.Point(8, 76)
        Me.optComprasProveedor.Name = "optComprasProveedor"
        Me.optComprasProveedor.Size = New System.Drawing.Size(130, 18)
        Me.optComprasProveedor.TabIndex = 4
        Me.optComprasProveedor.Text = "Compras x Proveedor"
        Me.optComprasProveedor.UseVisualStyleBackColor = True
        '
        'optComprasProducto
        '
        Me.optComprasProducto.AutoSize = True
        Me.optComprasProducto.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optComprasProducto.ForeColor = System.Drawing.Color.Black
        Me.optComprasProducto.Location = New System.Drawing.Point(8, 56)
        Me.optComprasProducto.Name = "optComprasProducto"
        Me.optComprasProducto.Size = New System.Drawing.Size(123, 18)
        Me.optComprasProducto.TabIndex = 2
        Me.optComprasProducto.Text = "Compras x Producto"
        Me.optComprasProducto.UseVisualStyleBackColor = True
        '
        'optRegistro
        '
        Me.optRegistro.AutoSize = True
        Me.optRegistro.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optRegistro.ForeColor = System.Drawing.Color.Black
        Me.optRegistro.Location = New System.Drawing.Point(8, 36)
        Me.optRegistro.Name = "optRegistro"
        Me.optRegistro.Size = New System.Drawing.Size(126, 18)
        Me.optRegistro.TabIndex = 0
        Me.optRegistro.Text = "Registro de Compras"
        Me.optRegistro.UseVisualStyleBackColor = True
        '
        'chkDetalle
        '
        Me.chkDetalle.AutoSize = True
        '
        '
        '
        Me.chkDetalle.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chkDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDetalle.Location = New System.Drawing.Point(484, 38)
        Me.chkDetalle.Name = "chkDetalle"
        Me.chkDetalle.Size = New System.Drawing.Size(69, 15)
        Me.chkDetalle.TabIndex = 136
        Me.chkDetalle.Text = "Detallado"
        Me.chkDetalle.TextColor = System.Drawing.Color.Maroon
        '
        'dataDetalle
        '
        Me.dataDetalle.AllowUserToAddRows = False
        Me.dataDetalle.AllowUserToDeleteRows = False
        Me.dataDetalle.AllowUserToResizeColumns = False
        Me.dataDetalle.AllowUserToResizeRows = False
        Me.dataDetalle.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dataDetalle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataDetalle.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dataDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataDetalle.DefaultCellStyle = DataGridViewCellStyle9
        Me.dataDetalle.Dock = System.Windows.Forms.DockStyle.Top
        Me.dataDetalle.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dataDetalle.Location = New System.Drawing.Point(1, 1)
        Me.dataDetalle.Name = "dataDetalle"
        Me.dataDetalle.ReadOnly = True
        Me.dataDetalle.RowHeadersVisible = False
        Me.dataDetalle.SelectAllSignVisible = False
        Me.dataDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataDetalle.ShowEditingIcon = False
        Me.dataDetalle.Size = New System.Drawing.Size(1018, 386)
        Me.dataDetalle.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(-14, 158)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1089, 10)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        '
        'grupoAlmacen
        '
        Me.grupoAlmacen.Controls.Add(Me.cboGrupo)
        Me.grupoAlmacen.Controls.Add(Me.chkGrupo)
        Me.grupoAlmacen.Controls.Add(Me.chkAlmacen)
        Me.grupoAlmacen.Controls.Add(Me.cboAlmacen)
        Me.grupoAlmacen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupoAlmacen.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.grupoAlmacen.Location = New System.Drawing.Point(573, 4)
        Me.grupoAlmacen.Name = "grupoAlmacen"
        Me.grupoAlmacen.Size = New System.Drawing.Size(468, 40)
        Me.grupoAlmacen.TabIndex = 73
        Me.grupoAlmacen.TabStop = False
        '
        'cboGrupo
        '
        Me.cboGrupo.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboGrupo.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cboGrupo.DisplayMember = "Text"
        Me.cboGrupo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGrupo.Enabled = False
        Me.cboGrupo.FocusHighlightColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.cboGrupo.FocusHighlightEnabled = True
        Me.cboGrupo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGrupo.ItemHeight = 15
        Me.cboGrupo.Location = New System.Drawing.Point(297, 12)
        Me.cboGrupo.Name = "cboGrupo"
        Me.cboGrupo.Size = New System.Drawing.Size(151, 21)
        Me.cboGrupo.TabIndex = 139
        '
        'chkGrupo
        '
        Me.chkGrupo.AutoSize = True
        '
        '
        '
        Me.chkGrupo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chkGrupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkGrupo.Location = New System.Drawing.Point(242, 15)
        Me.chkGrupo.Name = "chkGrupo"
        Me.chkGrupo.Size = New System.Drawing.Size(53, 15)
        Me.chkGrupo.TabIndex = 138
        Me.chkGrupo.Text = "Grupo"
        Me.chkGrupo.TextColor = System.Drawing.Color.Black
        '
        'chkAlmacen
        '
        Me.chkAlmacen.AutoSize = True
        '
        '
        '
        Me.chkAlmacen.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chkAlmacen.Checked = True
        Me.chkAlmacen.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAlmacen.CheckValue = "Y"
        Me.chkAlmacen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAlmacen.Location = New System.Drawing.Point(6, 15)
        Me.chkAlmacen.Name = "chkAlmacen"
        Me.chkAlmacen.Size = New System.Drawing.Size(65, 15)
        Me.chkAlmacen.TabIndex = 137
        Me.chkAlmacen.Text = "Almacén"
        Me.chkAlmacen.TextColor = System.Drawing.Color.Black
        '
        'cboAlmacen
        '
        Me.cboAlmacen.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboAlmacen.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cboAlmacen.DisplayMember = "Text"
        Me.cboAlmacen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboAlmacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAlmacen.FocusHighlightColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.cboAlmacen.FocusHighlightEnabled = True
        Me.cboAlmacen.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAlmacen.ItemHeight = 15
        Me.cboAlmacen.Location = New System.Drawing.Point(74, 12)
        Me.cboAlmacen.Name = "cboAlmacen"
        Me.cboAlmacen.Size = New System.Drawing.Size(165, 21)
        Me.cboAlmacen.TabIndex = 133
        '
        'cboEmpresa
        '
        Me.cboEmpresa.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboEmpresa.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cboEmpresa.DisplayMember = "Text"
        Me.cboEmpresa.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEmpresa.FocusHighlightColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.cboEmpresa.FocusHighlightEnabled = True
        Me.cboEmpresa.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEmpresa.ItemHeight = 15
        Me.cboEmpresa.Location = New System.Drawing.Point(7, 60)
        Me.cboEmpresa.Name = "cboEmpresa"
        Me.cboEmpresa.Size = New System.Drawing.Size(184, 21)
        Me.cboEmpresa.TabIndex = 12
        '
        'chkDia
        '
        Me.chkDia.AutoSize = True
        '
        '
        '
        Me.chkDia.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chkDia.Checked = True
        Me.chkDia.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDia.CheckValue = "Y"
        Me.chkDia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDia.Location = New System.Drawing.Point(207, 4)
        Me.chkDia.Name = "chkDia"
        Me.chkDia.Size = New System.Drawing.Size(115, 15)
        Me.chkDia.TabIndex = 123
        Me.chkDia.TabStop = False
        Me.chkDia.Text = "x Rango de Fecha "
        Me.chkDia.TextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.chkDia.Visible = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.dtiHasta)
        Me.GroupBox5.Controls.Add(Me.dtiDesde)
        Me.GroupBox5.Controls.Add(Me.LabelX1)
        Me.GroupBox5.Controls.Add(Me.LabelX2)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.SystemColors.Desktop
        Me.GroupBox5.Location = New System.Drawing.Point(200, 5)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(132, 74)
        Me.GroupBox5.TabIndex = 124
        Me.GroupBox5.TabStop = False
        '
        'dtiHasta
        '
        '
        '
        '
        Me.dtiHasta.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dtiHasta.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtiHasta.ButtonDropDown.Visible = True
        Me.dtiHasta.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtiHasta.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dtiHasta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.dtiHasta.IsInputReadOnly = True
        Me.dtiHasta.IsPopupCalendarOpen = False
        Me.dtiHasta.Location = New System.Drawing.Point(42, 46)
        '
        '
        '
        Me.dtiHasta.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtiHasta.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.dtiHasta.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtiHasta.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        '
        '
        '
        Me.dtiHasta.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dtiHasta.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dtiHasta.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dtiHasta.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dtiHasta.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dtiHasta.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dtiHasta.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtiHasta.MonthCalendar.DisplayMonth = New Date(2011, 3, 1, 0, 0, 0, 0)
        Me.dtiHasta.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.dtiHasta.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtiHasta.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dtiHasta.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dtiHasta.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dtiHasta.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtiHasta.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.dtiHasta.Name = "dtiHasta"
        Me.dtiHasta.Size = New System.Drawing.Size(83, 20)
        Me.dtiHasta.TabIndex = 120
        '
        'dtiDesde
        '
        '
        '
        '
        Me.dtiDesde.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dtiDesde.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtiDesde.ButtonDropDown.Visible = True
        Me.dtiDesde.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtiDesde.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dtiDesde.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.dtiDesde.IsInputReadOnly = True
        Me.dtiDesde.IsPopupCalendarOpen = False
        Me.dtiDesde.Location = New System.Drawing.Point(42, 19)
        '
        '
        '
        Me.dtiDesde.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtiDesde.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.dtiDesde.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtiDesde.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        '
        '
        '
        Me.dtiDesde.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dtiDesde.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dtiDesde.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dtiDesde.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dtiDesde.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dtiDesde.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dtiDesde.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtiDesde.MonthCalendar.DisplayMonth = New Date(2011, 3, 1, 0, 0, 0, 0)
        Me.dtiDesde.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.dtiDesde.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtiDesde.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dtiDesde.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dtiDesde.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dtiDesde.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtiDesde.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.dtiDesde.Name = "dtiDesde"
        Me.dtiDesde.Size = New System.Drawing.Size(83, 20)
        Me.dtiDesde.TabIndex = 119
        '
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.ForeColor = System.Drawing.Color.Black
        Me.LabelX1.Location = New System.Drawing.Point(6, 22)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(34, 15)
        Me.LabelX1.TabIndex = 115
        Me.LabelX1.Text = "Desde"
        Me.LabelX1.WordWrap = True
        '
        'LabelX2
        '
        Me.LabelX2.AutoSize = True
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.ForeColor = System.Drawing.Color.Black
        Me.LabelX2.Location = New System.Drawing.Point(6, 49)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(31, 15)
        Me.LabelX2.TabIndex = 117
        Me.LabelX2.Text = "Hasta"
        Me.LabelX2.WordWrap = True
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.cboAnno)
        Me.GroupPanel1.Controls.Add(Me.cboMes)
        Me.GroupPanel1.Location = New System.Drawing.Point(7, 7)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(184, 50)
        '
        '
        '
        Me.GroupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel1.Style.BackColorGradientAngle = 90
        Me.GroupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderBottomWidth = 1
        Me.GroupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderLeftWidth = 1
        Me.GroupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderRightWidth = 1
        Me.GroupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderTopWidth = 1
        Me.GroupPanel1.Style.CornerDiameter = 4
        Me.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel1.TabIndex = 122
        Me.GroupPanel1.Text = "Periodo de Reporte"
        '
        'cboAnno
        '
        Me.cboAnno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAnno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAnno.FormattingEnabled = True
        Me.cboAnno.Items.AddRange(New Object() {"2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025"})
        Me.cboAnno.Location = New System.Drawing.Point(109, 5)
        Me.cboAnno.Name = "cboAnno"
        Me.cboAnno.Size = New System.Drawing.Size(60, 21)
        Me.cboAnno.TabIndex = 1
        '
        'cboMes
        '
        Me.cboMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMes.FormattingEnabled = True
        Me.cboMes.Items.AddRange(New Object() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Setiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.cboMes.Location = New System.Drawing.Point(5, 5)
        Me.cboMes.Name = "cboMes"
        Me.cboMes.Size = New System.Drawing.Size(94, 21)
        Me.cboMes.TabIndex = 0
        '
        'lblRegistros
        '
        '
        '
        '
        Me.lblRegistros.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblRegistros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistros.ForeColor = System.Drawing.Color.Green
        Me.lblRegistros.Location = New System.Drawing.Point(978, 116)
        Me.lblRegistros.Name = "lblRegistros"
        Me.lblRegistros.Size = New System.Drawing.Size(55, 19)
        Me.lblRegistros.TabIndex = 125
        Me.lblRegistros.Text = "Nº"
        Me.lblRegistros.TextAlignment = System.Drawing.StringAlignment.Center
        Me.lblRegistros.WordWrap = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.chkDolares)
        Me.GroupBox4.Controls.Add(Me.chkMoneda)
        Me.GroupBox4.Controls.Add(Me.LabelX4)
        Me.GroupBox4.Controls.Add(Me.PictureBox3)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox4.Location = New System.Drawing.Point(6, 106)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(193, 32)
        Me.GroupBox4.TabIndex = 130
        Me.GroupBox4.TabStop = False
        '
        'chkDolares
        '
        Me.chkDolares.AutoSize = True
        '
        '
        '
        Me.chkDolares.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chkDolares.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDolares.Location = New System.Drawing.Point(128, 11)
        Me.chkDolares.Name = "chkDolares"
        Me.chkDolares.Size = New System.Drawing.Size(60, 15)
        Me.chkDolares.TabIndex = 133
        Me.chkDolares.Text = "Dólares"
        Me.chkDolares.TextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        '
        'chkMoneda
        '
        Me.chkMoneda.AutoSize = True
        '
        '
        '
        Me.chkMoneda.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chkMoneda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMoneda.Location = New System.Drawing.Point(64, 11)
        Me.chkMoneda.Name = "chkMoneda"
        Me.chkMoneda.Size = New System.Drawing.Size(62, 15)
        Me.chkMoneda.TabIndex = 132
        Me.chkMoneda.Text = "Moneda"
        Me.chkMoneda.TextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        '
        'LabelX4
        '
        Me.LabelX4.AutoSize = True
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.ForeColor = System.Drawing.Color.Maroon
        Me.LabelX4.Location = New System.Drawing.Point(6, 11)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(32, 15)
        Me.LabelX4.TabIndex = 131
        Me.LabelX4.Text = "Filtrar"
        Me.LabelX4.TextAlignment = System.Drawing.StringAlignment.Center
        Me.LabelX4.WordWrap = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.cefe.My.Resources.Resources.filtrar
        Me.PictureBox3.Location = New System.Drawing.Point(44, 10)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 131
        Me.PictureBox3.TabStop = False
        '
        'chkIMP
        '
        Me.chkIMP.AutoSize = True
        Me.chkIMP.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.chkIMP.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chkIMP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkIMP.Location = New System.Drawing.Point(4, 393)
        Me.chkIMP.Name = "chkIMP"
        Me.chkIMP.Size = New System.Drawing.Size(139, 15)
        Me.chkIMP.TabIndex = 135
        Me.chkIMP.Text = "Precios CON Impuesto"
        Me.chkIMP.TextColor = System.Drawing.Color.Maroon
        '
        'tabIngresos
        '
        Me.tabIngresos.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tabIngresos.CanReorderTabs = True
        Me.tabIngresos.ColorScheme.TabBackground = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tabIngresos.ColorScheme.TabBackground2 = System.Drawing.Color.White
        Me.tabIngresos.ColorScheme.TabItemBackground = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.tabIngresos.ColorScheme.TabItemBackground2 = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tabIngresos.Controls.Add(Me.TabControlPanel5)
        Me.tabIngresos.Controls.Add(Me.TabControlPanel4)
        Me.tabIngresos.Controls.Add(Me.TabControlPanel2)
        Me.tabIngresos.Controls.Add(Me.TabControlPanel1)
        Me.tabIngresos.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tabIngresos.Location = New System.Drawing.Point(0, 173)
        Me.tabIngresos.Name = "tabIngresos"
        Me.tabIngresos.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.tabIngresos.SelectedTabIndex = 0
        Me.tabIngresos.Size = New System.Drawing.Size(1020, 417)
        Me.tabIngresos.Style = DevComponents.DotNetBar.eTabStripStyle.VS2005Document
        Me.tabIngresos.TabIndex = 142
        Me.tabIngresos.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
        Me.tabIngresos.Tabs.Add(Me.tabCompras)
        Me.tabIngresos.Tabs.Add(Me.tabGrupos)
        Me.tabIngresos.Tabs.Add(Me.tabResumen)
        Me.tabIngresos.Tabs.Add(Me.tabEstadisticas)
        Me.tabIngresos.Text = "Precio de Costo Vs. Precio de Venta"
        '
        'TabControlPanel4
        '
        Me.TabControlPanel4.Controls.Add(Me.PictureBox5)
        Me.TabControlPanel4.Controls.Add(Me.lblMontoDS)
        Me.TabControlPanel4.Controls.Add(Me.lblMonedaDS)
        Me.TabControlPanel4.Controls.Add(Me.PictureBox4)
        Me.TabControlPanel4.Controls.Add(Me.lblMontoD)
        Me.TabControlPanel4.Controls.Add(Me.LabelX8)
        Me.TabControlPanel4.Controls.Add(Me.PictureBox1)
        Me.TabControlPanel4.Controls.Add(Me.chkIMP)
        Me.TabControlPanel4.Controls.Add(Me.lblMonto)
        Me.TabControlPanel4.Controls.Add(Me.lblMoneda)
        Me.TabControlPanel4.Controls.Add(Me.dataDetalle)
        Me.TabControlPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel4.Location = New System.Drawing.Point(0, 26)
        Me.TabControlPanel4.Name = "TabControlPanel4"
        Me.TabControlPanel4.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel4.Size = New System.Drawing.Size(1020, 391)
        Me.TabControlPanel4.Style.BackColor1.Color = System.Drawing.Color.White
        Me.TabControlPanel4.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabControlPanel4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel4.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.TabControlPanel4.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel4.Style.GradientAngle = 90
        Me.TabControlPanel4.TabIndex = 1
        Me.TabControlPanel4.TabItem = Me.tabCompras
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.cefe.My.Resources.Resources.continuar16
        Me.PictureBox5.Location = New System.Drawing.Point(407, 393)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox5.TabIndex = 144
        Me.PictureBox5.TabStop = False
        '
        'lblMontoDS
        '
        Me.lblMontoDS.AutoSize = True
        Me.lblMontoDS.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.lblMontoDS.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblMontoDS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMontoDS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblMontoDS.Location = New System.Drawing.Point(427, 393)
        Me.lblMontoDS.Name = "lblMontoDS"
        Me.lblMontoDS.Size = New System.Drawing.Size(42, 15)
        Me.lblMontoDS.TabIndex = 143
        Me.lblMontoDS.Text = "Monto..."
        Me.lblMontoDS.WordWrap = True
        '
        'lblMonedaDS
        '
        Me.lblMonedaDS.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.lblMonedaDS.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblMonedaDS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonedaDS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblMonedaDS.Location = New System.Drawing.Point(220, 393)
        Me.lblMonedaDS.Name = "lblMonedaDS"
        Me.lblMonedaDS.Size = New System.Drawing.Size(182, 15)
        Me.lblMonedaDS.TabIndex = 142
        Me.lblMonedaDS.Text = "Moneda"
        Me.lblMonedaDS.TextAlignment = System.Drawing.StringAlignment.Far
        Me.lblMonedaDS.WordWrap = True
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.cefe.My.Resources.Resources.continuar16
        Me.PictureBox4.Location = New System.Drawing.Point(911, 393)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox4.TabIndex = 141
        Me.PictureBox4.TabStop = False
        '
        'lblMontoD
        '
        Me.lblMontoD.AutoSize = True
        Me.lblMontoD.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.lblMontoD.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblMontoD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMontoD.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblMontoD.Location = New System.Drawing.Point(931, 393)
        Me.lblMontoD.Name = "lblMontoD"
        Me.lblMontoD.Size = New System.Drawing.Size(42, 15)
        Me.lblMontoD.TabIndex = 138
        Me.lblMontoD.Text = "Monto..."
        Me.lblMontoD.WordWrap = True
        '
        'LabelX8
        '
        Me.LabelX8.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LabelX8.Location = New System.Drawing.Point(866, 393)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(42, 15)
        Me.LabelX8.TabIndex = 137
        Me.LabelX8.Text = "Dolares"
        Me.LabelX8.TextAlignment = System.Drawing.StringAlignment.Far
        Me.LabelX8.WordWrap = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.cefe.My.Resources.Resources.continuar16
        Me.PictureBox1.Location = New System.Drawing.Point(707, 393)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 136
        Me.PictureBox1.TabStop = False
        '
        'lblMonto
        '
        Me.lblMonto.AutoSize = True
        Me.lblMonto.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.lblMonto.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblMonto.Location = New System.Drawing.Point(727, 393)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Size = New System.Drawing.Size(42, 15)
        Me.lblMonto.TabIndex = 133
        Me.lblMonto.Text = "Monto..."
        Me.lblMonto.WordWrap = True
        '
        'lblMoneda
        '
        Me.lblMoneda.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.lblMoneda.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblMoneda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMoneda.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblMoneda.Location = New System.Drawing.Point(662, 393)
        Me.lblMoneda.Name = "lblMoneda"
        Me.lblMoneda.Size = New System.Drawing.Size(42, 15)
        Me.lblMoneda.TabIndex = 132
        Me.lblMoneda.Text = "Moneda"
        Me.lblMoneda.TextAlignment = System.Drawing.StringAlignment.Far
        Me.lblMoneda.WordWrap = True
        '
        'tabCompras
        '
        Me.tabCompras.AttachedControl = Me.TabControlPanel4
        Me.tabCompras.Icon = CType(resources.GetObject("tabCompras.Icon"), System.Drawing.Icon)
        Me.tabCompras.Name = "tabCompras"
        Me.tabCompras.Text = "Compras"
        '
        'TabControlPanel5
        '
        Me.TabControlPanel5.Controls.Add(Me.barraResumen)
        Me.TabControlPanel5.Controls.Add(Me.chkAlmacenResumen)
        Me.TabControlPanel5.Controls.Add(Me.cboAlmacenResumen)
        Me.TabControlPanel5.Controls.Add(Me.lblMensaje)
        Me.TabControlPanel5.Controls.Add(Me.GroupBox1)
        Me.TabControlPanel5.Controls.Add(Me.LabelX3)
        Me.TabControlPanel5.Controls.Add(Me.GroupBox6)
        Me.TabControlPanel5.Controls.Add(Me.dataResumenAnual)
        Me.TabControlPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel5.Location = New System.Drawing.Point(0, 26)
        Me.TabControlPanel5.Name = "TabControlPanel5"
        Me.TabControlPanel5.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel5.Size = New System.Drawing.Size(1020, 391)
        Me.TabControlPanel5.Style.BackColor1.Color = System.Drawing.Color.White
        Me.TabControlPanel5.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabControlPanel5.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel5.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.TabControlPanel5.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel5.Style.GradientAngle = 90
        Me.TabControlPanel5.TabIndex = 2
        Me.TabControlPanel5.TabItem = Me.tabResumen
        '
        'barraResumen
        '
        Me.barraResumen.BackColor = System.Drawing.Color.Silver
        '
        '
        '
        Me.barraResumen.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.barraResumen.Location = New System.Drawing.Point(793, 6)
        Me.barraResumen.Name = "barraResumen"
        Me.barraResumen.Size = New System.Drawing.Size(227, 23)
        Me.barraResumen.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7
        Me.barraResumen.TabIndex = 151
        Me.barraResumen.Text = "0%"
        Me.barraResumen.TextVisible = True
        Me.barraResumen.Visible = False
        '
        'chkAlmacenResumen
        '
        Me.chkAlmacenResumen.AutoSize = True
        Me.chkAlmacenResumen.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.chkAlmacenResumen.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chkAlmacenResumen.Checked = True
        Me.chkAlmacenResumen.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAlmacenResumen.CheckValue = "Y"
        Me.chkAlmacenResumen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAlmacenResumen.Location = New System.Drawing.Point(5, 8)
        Me.chkAlmacenResumen.Name = "chkAlmacenResumen"
        Me.chkAlmacenResumen.Size = New System.Drawing.Size(65, 15)
        Me.chkAlmacenResumen.TabIndex = 150
        Me.chkAlmacenResumen.Text = "Almacén"
        Me.chkAlmacenResumen.TextColor = System.Drawing.Color.Black
        '
        'cboAlmacenResumen
        '
        Me.cboAlmacenResumen.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboAlmacenResumen.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cboAlmacenResumen.DisplayMember = "Text"
        Me.cboAlmacenResumen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboAlmacenResumen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAlmacenResumen.FocusHighlightColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.cboAlmacenResumen.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAlmacenResumen.ItemHeight = 15
        Me.cboAlmacenResumen.Location = New System.Drawing.Point(73, 6)
        Me.cboAlmacenResumen.Name = "cboAlmacenResumen"
        Me.cboAlmacenResumen.Size = New System.Drawing.Size(152, 21)
        Me.cboAlmacenResumen.TabIndex = 149
        '
        'lblMensaje
        '
        Me.lblMensaje.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.lblMensaje.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblMensaje.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensaje.ForeColor = System.Drawing.Color.Maroon
        Me.lblMensaje.Location = New System.Drawing.Point(815, 5)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(220, 22)
        Me.lblMensaje.TabIndex = 148
        Me.lblMensaje.Text = "Mensaje"
        Me.lblMensaje.TextAlignment = System.Drawing.StringAlignment.Far
        Me.lblMensaje.Visible = False
        Me.lblMensaje.WordWrap = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.txtBuscarResumenAnual)
        Me.GroupBox1.Controls.Add(Me.optDescripcion)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(466, -5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(245, 36)
        Me.GroupBox1.TabIndex = 144
        Me.GroupBox1.TabStop = False
        '
        'txtBuscarResumenAnual
        '
        Me.txtBuscarResumenAnual.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtBuscarResumenAnual.Border.Class = "TextBoxBorder"
        Me.txtBuscarResumenAnual.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtBuscarResumenAnual.FocusHighlightEnabled = True
        Me.txtBuscarResumenAnual.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscarResumenAnual.Location = New System.Drawing.Point(99, 10)
        Me.txtBuscarResumenAnual.Name = "txtBuscarResumenAnual"
        Me.txtBuscarResumenAnual.Size = New System.Drawing.Size(120, 21)
        Me.txtBuscarResumenAnual.TabIndex = 150
        '
        'optDescripcion
        '
        Me.optDescripcion.AutoSize = True
        Me.optDescripcion.Checked = True
        Me.optDescripcion.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optDescripcion.ForeColor = System.Drawing.Color.Black
        Me.optDescripcion.Location = New System.Drawing.Point(7, 11)
        Me.optDescripcion.Name = "optDescripcion"
        Me.optDescripcion.Size = New System.Drawing.Size(90, 18)
        Me.optDescripcion.TabIndex = 1
        Me.optDescripcion.TabStop = True
        Me.optDescripcion.Text = "Descripción"
        Me.optDescripcion.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.Image = Global.cefe.My.Resources.Resources.buscar18
        Me.PictureBox2.Location = New System.Drawing.Point(221, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(18, 18)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 146
        Me.PictureBox2.TabStop = False
        '
        'LabelX3
        '
        Me.LabelX3.AutoSize = True
        Me.LabelX3.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.ForeColor = System.Drawing.Color.Maroon
        Me.LabelX3.Location = New System.Drawing.Point(421, 7)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(41, 16)
        Me.LabelX3.TabIndex = 147
        Me.LabelX3.Text = "Buscar"
        Me.LabelX3.TextAlignment = System.Drawing.StringAlignment.Center
        Me.LabelX3.WordWrap = True
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.White
        Me.GroupBox6.Controls.Add(Me.optValorizado)
        Me.GroupBox6.Controls.Add(Me.optCantidades)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.Color.Black
        Me.GroupBox6.Location = New System.Drawing.Point(230, -5)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(178, 36)
        Me.GroupBox6.TabIndex = 142
        Me.GroupBox6.TabStop = False
        '
        'optValorizado
        '
        Me.optValorizado.AutoSize = True
        Me.optValorizado.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optValorizado.ForeColor = System.Drawing.Color.Black
        Me.optValorizado.Location = New System.Drawing.Point(93, 12)
        Me.optValorizado.Name = "optValorizado"
        Me.optValorizado.Size = New System.Drawing.Size(82, 18)
        Me.optValorizado.TabIndex = 1
        Me.optValorizado.Text = "Valorizado"
        Me.optValorizado.UseVisualStyleBackColor = True
        '
        'optCantidades
        '
        Me.optCantidades.AutoSize = True
        Me.optCantidades.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optCantidades.ForeColor = System.Drawing.Color.Black
        Me.optCantidades.Location = New System.Drawing.Point(6, 12)
        Me.optCantidades.Name = "optCantidades"
        Me.optCantidades.Size = New System.Drawing.Size(87, 18)
        Me.optCantidades.TabIndex = 0
        Me.optCantidades.Text = "Cantidades"
        Me.optCantidades.UseVisualStyleBackColor = True
        '
        'dataResumenAnual
        '
        Me.dataResumenAnual.AllowUserToAddRows = False
        Me.dataResumenAnual.AllowUserToDeleteRows = False
        Me.dataResumenAnual.AllowUserToResizeColumns = False
        Me.dataResumenAnual.AllowUserToResizeRows = False
        Me.dataResumenAnual.BackgroundColor = System.Drawing.Color.White
        Me.dataResumenAnual.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataResumenAnual.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dataResumenAnual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataResumenAnual.DefaultCellStyle = DataGridViewCellStyle11
        Me.dataResumenAnual.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dataResumenAnual.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dataResumenAnual.Location = New System.Drawing.Point(1, 29)
        Me.dataResumenAnual.Name = "dataResumenAnual"
        Me.dataResumenAnual.ReadOnly = True
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataResumenAnual.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.dataResumenAnual.RowHeadersVisible = False
        Me.dataResumenAnual.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dataResumenAnual.SelectAllSignVisible = False
        Me.dataResumenAnual.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataResumenAnual.ShowEditingIcon = False
        Me.dataResumenAnual.Size = New System.Drawing.Size(1018, 361)
        Me.dataResumenAnual.TabIndex = 6
        '
        'tabResumen
        '
        Me.tabResumen.AttachedControl = Me.TabControlPanel5
        Me.tabResumen.Icon = CType(resources.GetObject("tabResumen.Icon"), System.Drawing.Icon)
        Me.tabResumen.Name = "tabResumen"
        Me.tabResumen.Text = "Resumen Anual de Compras"
        '
        'TabControlPanel2
        '
        Me.TabControlPanel2.Controls.Add(Me.dataResumenGrupo)
        Me.TabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel2.Location = New System.Drawing.Point(0, 26)
        Me.TabControlPanel2.Name = "TabControlPanel2"
        Me.TabControlPanel2.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel2.Size = New System.Drawing.Size(1020, 391)
        Me.TabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.White
        Me.TabControlPanel2.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.TabControlPanel2.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel2.Style.GradientAngle = 90
        Me.TabControlPanel2.TabIndex = 4
        Me.TabControlPanel2.TabItem = Me.tabGrupos
        '
        'dataResumenGrupo
        '
        Me.dataResumenGrupo.AllowUserToAddRows = False
        Me.dataResumenGrupo.AllowUserToDeleteRows = False
        Me.dataResumenGrupo.AllowUserToResizeColumns = False
        Me.dataResumenGrupo.AllowUserToResizeRows = False
        Me.dataResumenGrupo.BackgroundColor = System.Drawing.Color.White
        Me.dataResumenGrupo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataResumenGrupo.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.dataResumenGrupo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataResumenGrupo.DefaultCellStyle = DataGridViewCellStyle14
        Me.dataResumenGrupo.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dataResumenGrupo.Location = New System.Drawing.Point(1, -5)
        Me.dataResumenGrupo.Name = "dataResumenGrupo"
        Me.dataResumenGrupo.ReadOnly = True
        Me.dataResumenGrupo.RowHeadersVisible = False
        Me.dataResumenGrupo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dataResumenGrupo.SelectAllSignVisible = False
        Me.dataResumenGrupo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataResumenGrupo.ShowEditingIcon = False
        Me.dataResumenGrupo.Size = New System.Drawing.Size(360, 414)
        Me.dataResumenGrupo.TabIndex = 53
        '
        'tabGrupos
        '
        Me.tabGrupos.AttachedControl = Me.TabControlPanel2
        Me.tabGrupos.Name = "tabGrupos"
        Me.tabGrupos.Text = "Resumen de Compras x Grupo"
        '
        'TabControlPanel1
        '
        Me.TabControlPanel1.Controls.Add(Me.ButtonX1)
        Me.TabControlPanel1.Controls.Add(Me.chartCompras)
        Me.TabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel1.Location = New System.Drawing.Point(0, 26)
        Me.TabControlPanel1.Name = "TabControlPanel1"
        Me.TabControlPanel1.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel1.Size = New System.Drawing.Size(1020, 391)
        Me.TabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.White
        Me.TabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.TabControlPanel1.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel1.Style.GradientAngle = 90
        Me.TabControlPanel1.TabIndex = 3
        Me.TabControlPanel1.TabItem = Me.tabEstadisticas
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX1.Image = Global.cefe.My.Resources.Resources.print_preview
        Me.ButtonX1.Location = New System.Drawing.Point(162, 88)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.ButtonX1.Size = New System.Drawing.Size(80, 36)
        Me.ButtonX1.TabIndex = 47
        Me.ButtonX1.Text = "Imprimir"
        '
        'chartCompras
        '
        Me.chartCompras.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.chartCompras.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chartCompras.ChartType = DevComponents.DotNetBar.eMicroChartType.Column
        Me.chartCompras.Location = New System.Drawing.Point(423, 6)
        Me.chartCompras.Name = "chartCompras"
        Me.chartCompras.Size = New System.Drawing.Size(619, 395)
        Me.chartCompras.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
        Me.chartCompras.TabIndex = 0
        Me.chartCompras.Text = "MicroChart1"
        '
        'tabEstadisticas
        '
        Me.tabEstadisticas.AttachedControl = Me.TabControlPanel1
        Me.tabEstadisticas.Name = "tabEstadisticas"
        Me.tabEstadisticas.Text = "Estadísticas"
        '
        'chkSoloCompras
        '
        Me.chkSoloCompras.AutoSize = True
        '
        '
        '
        Me.chkSoloCompras.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chkSoloCompras.Checked = True
        Me.chkSoloCompras.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSoloCompras.CheckValue = "Y"
        Me.chkSoloCompras.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSoloCompras.Location = New System.Drawing.Point(484, 17)
        Me.chkSoloCompras.Name = "chkSoloCompras"
        Me.chkSoloCompras.Size = New System.Drawing.Size(92, 15)
        Me.chkSoloCompras.TabIndex = 143
        Me.chkSoloCompras.Text = "Solo Compras"
        Me.chkSoloCompras.TextColor = System.Drawing.Color.Maroon
        '
        'chkAgrupar
        '
        Me.chkAgrupar.AutoSize = True
        '
        '
        '
        Me.chkAgrupar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chkAgrupar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAgrupar.Location = New System.Drawing.Point(5, 15)
        Me.chkAgrupar.Name = "chkAgrupar"
        Me.chkAgrupar.Size = New System.Drawing.Size(70, 15)
        Me.chkAgrupar.TabIndex = 144
        Me.chkAgrupar.Text = "Agrupado"
        Me.chkAgrupar.TextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.optOrdenMonto)
        Me.GroupBox7.Controls.Add(Me.optOrdenProveedor)
        Me.GroupBox7.Controls.Add(Me.optOrdenProducto)
        Me.GroupBox7.Controls.Add(Me.optOrdenDocumento)
        Me.GroupBox7.Controls.Add(Me.optOrdenFecha)
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox7.Location = New System.Drawing.Point(636, 108)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(340, 58)
        Me.GroupBox7.TabIndex = 145
        Me.GroupBox7.TabStop = False
        '
        'optOrdenMonto
        '
        Me.optOrdenMonto.AutoSize = True
        Me.optOrdenMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optOrdenMonto.ForeColor = System.Drawing.Color.Black
        Me.optOrdenMonto.Location = New System.Drawing.Point(282, 10)
        Me.optOrdenMonto.Name = "optOrdenMonto"
        Me.optOrdenMonto.Size = New System.Drawing.Size(55, 17)
        Me.optOrdenMonto.TabIndex = 6
        Me.optOrdenMonto.Text = "Monto"
        Me.optOrdenMonto.UseVisualStyleBackColor = True
        '
        'optOrdenProveedor
        '
        Me.optOrdenProveedor.AutoSize = True
        Me.optOrdenProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optOrdenProveedor.ForeColor = System.Drawing.Color.Black
        Me.optOrdenProveedor.Location = New System.Drawing.Point(207, 10)
        Me.optOrdenProveedor.Name = "optOrdenProveedor"
        Me.optOrdenProveedor.Size = New System.Drawing.Size(74, 17)
        Me.optOrdenProveedor.TabIndex = 5
        Me.optOrdenProveedor.Text = "Proveedor"
        Me.optOrdenProveedor.UseVisualStyleBackColor = True
        '
        'optOrdenProducto
        '
        Me.optOrdenProducto.AutoSize = True
        Me.optOrdenProducto.Enabled = False
        Me.optOrdenProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optOrdenProducto.ForeColor = System.Drawing.Color.Black
        Me.optOrdenProducto.Location = New System.Drawing.Point(140, 10)
        Me.optOrdenProducto.Name = "optOrdenProducto"
        Me.optOrdenProducto.Size = New System.Drawing.Size(68, 17)
        Me.optOrdenProducto.TabIndex = 4
        Me.optOrdenProducto.Text = "Producto"
        Me.optOrdenProducto.UseVisualStyleBackColor = True
        '
        'optOrdenDocumento
        '
        Me.optOrdenDocumento.AutoSize = True
        Me.optOrdenDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optOrdenDocumento.ForeColor = System.Drawing.Color.Black
        Me.optOrdenDocumento.Location = New System.Drawing.Point(61, 10)
        Me.optOrdenDocumento.Name = "optOrdenDocumento"
        Me.optOrdenDocumento.Size = New System.Drawing.Size(80, 17)
        Me.optOrdenDocumento.TabIndex = 2
        Me.optOrdenDocumento.Text = "Documento"
        Me.optOrdenDocumento.UseVisualStyleBackColor = True
        '
        'optOrdenFecha
        '
        Me.optOrdenFecha.AutoSize = True
        Me.optOrdenFecha.Checked = True
        Me.optOrdenFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optOrdenFecha.ForeColor = System.Drawing.Color.Black
        Me.optOrdenFecha.Location = New System.Drawing.Point(7, 10)
        Me.optOrdenFecha.Name = "optOrdenFecha"
        Me.optOrdenFecha.Size = New System.Drawing.Size(55, 17)
        Me.optOrdenFecha.TabIndex = 0
        Me.optOrdenFecha.TabStop = True
        Me.optOrdenFecha.Text = "Fecha"
        Me.optOrdenFecha.UseVisualStyleBackColor = True
        '
        'LabelX5
        '
        Me.LabelX5.AutoSize = True
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX5.ForeColor = System.Drawing.Color.Maroon
        Me.LabelX5.Location = New System.Drawing.Point(566, 118)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(48, 16)
        Me.LabelX5.TabIndex = 146
        Me.LabelX5.Text = "Ordenar"
        Me.LabelX5.TextAlignment = System.Drawing.StringAlignment.Center
        Me.LabelX5.WordWrap = True
        '
        'ordenAsc
        '
        Me.ordenAsc.Image = CType(resources.GetObject("ordenAsc.Image"), System.Drawing.Image)
        Me.ordenAsc.Location = New System.Drawing.Point(618, 119)
        Me.ordenAsc.Name = "ordenAsc"
        Me.ordenAsc.Size = New System.Drawing.Size(16, 16)
        Me.ordenAsc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.ordenAsc.TabIndex = 147
        Me.ordenAsc.TabStop = False
        Me.ordenAsc.Visible = False
        '
        'chkResumen
        '
        Me.chkResumen.AutoSize = True
        '
        '
        '
        Me.chkResumen.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chkResumen.Checked = True
        Me.chkResumen.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkResumen.CheckValue = "Y"
        Me.chkResumen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkResumen.Location = New System.Drawing.Point(484, 58)
        Me.chkResumen.Name = "chkResumen"
        Me.chkResumen.Size = New System.Drawing.Size(70, 15)
        Me.chkResumen.TabIndex = 148
        Me.chkResumen.Text = "Resumen"
        Me.chkResumen.TextColor = System.Drawing.Color.Maroon
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.optGuia)
        Me.GroupBox9.Controls.Add(Me.optProveedor)
        Me.GroupBox9.Controls.Add(Me.optDocumento)
        Me.GroupBox9.Controls.Add(Me.PictureBox6)
        Me.GroupBox9.Controls.Add(Me.txtBuscar)
        Me.GroupBox9.Controls.Add(Me.lblBuscar)
        Me.GroupBox9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox9.Location = New System.Drawing.Point(208, 106)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(354, 60)
        Me.GroupBox9.TabIndex = 150
        Me.GroupBox9.TabStop = False
        '
        'optGuia
        '
        Me.optGuia.AutoSize = True
        Me.optGuia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optGuia.ForeColor = System.Drawing.Color.Black
        Me.optGuia.Location = New System.Drawing.Point(207, 12)
        Me.optGuia.Name = "optGuia"
        Me.optGuia.Size = New System.Drawing.Size(47, 17)
        Me.optGuia.TabIndex = 139
        Me.optGuia.Text = "Guia"
        Me.optGuia.UseVisualStyleBackColor = True
        '
        'optProveedor
        '
        Me.optProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optProveedor.ForeColor = System.Drawing.Color.Black
        Me.optProveedor.Location = New System.Drawing.Point(128, 12)
        Me.optProveedor.Name = "optProveedor"
        Me.optProveedor.Size = New System.Drawing.Size(75, 18)
        Me.optProveedor.TabIndex = 138
        Me.optProveedor.Text = "Proveedor"
        Me.optProveedor.UseVisualStyleBackColor = True
        '
        'optDocumento
        '
        Me.optDocumento.AutoSize = True
        Me.optDocumento.Checked = True
        Me.optDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optDocumento.ForeColor = System.Drawing.Color.Black
        Me.optDocumento.Location = New System.Drawing.Point(48, 12)
        Me.optDocumento.Name = "optDocumento"
        Me.optDocumento.Size = New System.Drawing.Size(80, 17)
        Me.optDocumento.TabIndex = 137
        Me.optDocumento.TabStop = True
        Me.optDocumento.Text = "Documento"
        Me.optDocumento.UseVisualStyleBackColor = True
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.cefe.My.Resources.Resources.buscar18
        Me.PictureBox6.Location = New System.Drawing.Point(272, 33)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(18, 18)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox6.TabIndex = 136
        Me.PictureBox6.TabStop = False
        '
        'txtBuscar
        '
        Me.txtBuscar.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtBuscar.Border.Class = "TextBoxBorder"
        Me.txtBuscar.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtBuscar.FocusHighlightEnabled = True
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(48, 31)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(225, 21)
        Me.txtBuscar.TabIndex = 135
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        '
        '
        '
        Me.lblBuscar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscar.ForeColor = System.Drawing.Color.Maroon
        Me.lblBuscar.Location = New System.Drawing.Point(3, 13)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(38, 15)
        Me.lblBuscar.TabIndex = 132
        Me.lblBuscar.Text = "Buscar"
        Me.lblBuscar.TextAlignment = System.Drawing.StringAlignment.Center
        Me.lblBuscar.WordWrap = True
        '
        'ordenDesc
        '
        Me.ordenDesc.Image = CType(resources.GetObject("ordenDesc.Image"), System.Drawing.Image)
        Me.ordenDesc.Location = New System.Drawing.Point(618, 119)
        Me.ordenDesc.Name = "ordenDesc"
        Me.ordenDesc.Size = New System.Drawing.Size(16, 16)
        Me.ordenDesc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.ordenDesc.TabIndex = 151
        Me.ordenDesc.TabStop = False
        '
        'LabelX6
        '
        Me.LabelX6.AutoSize = True
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX6.ForeColor = System.Drawing.Color.Black
        Me.LabelX6.Location = New System.Drawing.Point(6, 12)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(0, 0)
        Me.LabelX6.TabIndex = 132
        Me.LabelX6.Text = "Almacén"
        Me.LabelX6.TextAlignment = System.Drawing.StringAlignment.Center
        Me.LabelX6.WordWrap = True
        '
        'ComboBoxEx1
        '
        Me.ComboBoxEx1.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ComboBoxEx1.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ComboBoxEx1.DisplayMember = "Text"
        Me.ComboBoxEx1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBoxEx1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxEx1.FocusHighlightColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.ComboBoxEx1.FocusHighlightEnabled = True
        Me.ComboBoxEx1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxEx1.ItemHeight = 14
        Me.ComboBoxEx1.Location = New System.Drawing.Point(61, 11)
        Me.ComboBoxEx1.Name = "ComboBoxEx1"
        Me.ComboBoxEx1.Size = New System.Drawing.Size(208, 20)
        Me.ComboBoxEx1.TabIndex = 12
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdImprimir.Appearance.Options.UseFont = True
        Me.cmdImprimir.Image = CType(resources.GetObject("cmdImprimir.Image"), System.Drawing.Image)
        Me.cmdImprimir.ImageLocation = DevExpress.DXCore.Controls.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdImprimir.Location = New System.Drawing.Point(73, 9)
        Me.cmdImprimir.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(68, 28)
        Me.cmdImprimir.TabIndex = 152
        Me.cmdImprimir.Text = "Imprimir"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.cmdImprimir)
        Me.GroupBox8.Controls.Add(Me.chkAgrupar)
        Me.GroupBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox8.Location = New System.Drawing.Point(880, 43)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(152, 40)
        Me.GroupBox8.TabIndex = 153
        Me.GroupBox8.TabStop = False
        '
        'repIngresos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1020, 590)
        Me.Controls.Add(Me.lblRegistros)
        Me.Controls.Add(Me.grupoAlmacen)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.cboEmpresa)
        Me.Controls.Add(Me.ordenDesc)
        Me.Controls.Add(Me.grupo)
        Me.Controls.Add(Me.chkDia)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox9)
        Me.Controls.Add(Me.chkResumen)
        Me.Controls.Add(Me.chkDetalle)
        Me.Controls.Add(Me.ordenAsc)
        Me.Controls.Add(Me.LabelX5)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.chkSoloCompras)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.tabIngresos)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "repIngresos"
        Me.Text = "Consulta y Reporte: INGRESOS"
        Me.grupo.ResumeLayout(False)
        Me.grupo.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dataDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupoAlmacen.ResumeLayout(False)
        Me.grupoAlmacen.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.dtiHasta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtiDesde, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabIngresos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabIngresos.ResumeLayout(False)
        Me.TabControlPanel4.ResumeLayout(False)
        Me.TabControlPanel4.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlPanel5.ResumeLayout(False)
        Me.TabControlPanel5.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.dataResumenAnual, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlPanel2.ResumeLayout(False)
        CType(Me.dataResumenGrupo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlPanel1.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.ordenAsc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ordenDesc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grupo As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents optComprasProducto As System.Windows.Forms.RadioButton
    Friend WithEvents optRegistro As System.Windows.Forms.RadioButton
    Friend WithEvents dataDetalle As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents grupoAlmacen As System.Windows.Forms.GroupBox
    Friend WithEvents chkDia As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents dtiHasta As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents dtiDesde As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents cboAnno As System.Windows.Forms.ComboBox
    Friend WithEvents cboMes As System.Windows.Forms.ComboBox
    Friend WithEvents lblRegistros As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents chkDolares As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chkMoneda As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chkIMP As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents optComprasProveedor As System.Windows.Forms.RadioButton
    Friend WithEvents chkDetalle As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents tabIngresos As DevComponents.DotNetBar.TabControl
    Friend WithEvents TabControlPanel4 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents tabCompras As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabControlPanel5 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents optValorizado As System.Windows.Forms.RadioButton
    Friend WithEvents optCantidades As System.Windows.Forms.RadioButton
    Friend WithEvents dataResumenAnual As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents tabResumen As DevComponents.DotNetBar.TabItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents optDescripcion As System.Windows.Forms.RadioButton
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents chkSoloCompras As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents lblMoneda As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblMonto As DevComponents.DotNetBar.LabelX
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents lblMontoD As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents chkAgrupar As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents optOrdenProducto As System.Windows.Forms.RadioButton
    Friend WithEvents optOrdenDocumento As System.Windows.Forms.RadioButton
    Friend WithEvents optOrdenFecha As System.Windows.Forms.RadioButton
    Friend WithEvents optOrdenProveedor As System.Windows.Forms.RadioButton
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ordenAsc As System.Windows.Forms.PictureBox
    Friend WithEvents lblMensaje As DevComponents.DotNetBar.LabelX
    Friend WithEvents cboEmpresa As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents chkResumen As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents cboAlmacenResumen As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents lblBuscar As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtBuscar As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents ordenDesc As System.Windows.Forms.PictureBox
    Friend WithEvents optProveedor As System.Windows.Forms.RadioButton
    Friend WithEvents optDocumento As System.Windows.Forms.RadioButton
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ComboBoxEx1 As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents lblMontoDS As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblMonedaDS As DevComponents.DotNetBar.LabelX
    Friend WithEvents TabControlPanel1 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents tabEstadisticas As DevComponents.DotNetBar.TabItem
    Friend WithEvents chartCompras As DevComponents.DotNetBar.MicroChart
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TabControlPanel2 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents tabGrupos As DevComponents.DotNetBar.TabItem
    Friend WithEvents dataResumenGrupo As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents cboAlmacen As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents chkAlmacen As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents cmdImprimir As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents optOrdenMonto As System.Windows.Forms.RadioButton
    Friend WithEvents chkGrupo As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents cboGrupo As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents txtBuscarResumenAnual As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents chkAlmacenResumen As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents barraResumen As DevComponents.DotNetBar.Controls.ProgressBarX
    Friend WithEvents chkCostosMonedaCompra As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents optGuia As RadioButton
    Friend WithEvents OptOCompra As RadioButton
End Class
