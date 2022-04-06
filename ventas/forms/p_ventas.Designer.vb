<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class p_ventas
    Inherits cefe.base

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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(p_ventas))
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.cboArticulo = New System.Windows.Forms.ComboBox()
        Me.cboTipoCliente = New System.Windows.Forms.ComboBox()
        Me.NudCantidad = New System.Windows.Forms.NumericUpDown()
        Me.panelgrupo = New System.Windows.Forms.FlowLayoutPanel()
        Me.panelarticulos = New System.Windows.Forms.FlowLayoutPanel()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.cboAlmacen = New System.Windows.Forms.ComboBox()
        Me.mcFechaVenta = New DevComponents.Editors.DateTimeAdv.MonthCalendarAdv()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtContacto = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtDirFiscal = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtRuc = New System.Windows.Forms.TextBox()
        Me.cboCliente = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cboDocumento = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtSerDocumento = New System.Windows.Forms.TextBox()
        Me.txtNroDocumento = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.chkMostrarPedidos = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.lblVendedor = New System.Windows.Forms.Label()
        Me.txtSerPedido = New System.Windows.Forms.TextBox()
        Me.txtNroPedido = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.chkRecuperarPedido = New System.Windows.Forms.CheckBox()
        Me.dataPedidos = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboEmpTransporte = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.cboConductor = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.txtNroPlaca = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cboDirEntrega = New System.Windows.Forms.ComboBox()
        Me.dtpTraslado = New System.Windows.Forms.DateTimePicker()
        Me.cboMotivo = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.dtpEntrega = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNroGuia = New System.Windows.Forms.TextBox()
        Me.txtSerGuia = New System.Windows.Forms.TextBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.lblTC = New DevComponents.DotNetBar.LabelX()
        Me.optDolares = New System.Windows.Forms.RadioButton()
        Me.optMoneda = New System.Windows.Forms.RadioButton()
        Me.cboVendedor = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cboFormaPago = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.chkIGV = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.lblItems = New DevComponents.DotNetBar.LabelX()
        Me.dataDetalle = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.lblMensaje = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtIGV = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtSubTotal = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmdImprimir = New DevExpress.DXCore.Controls.XtraEditors.SimpleButton()
        Me.cmdAnular = New DevExpress.DXCore.Controls.XtraEditors.SimpleButton()
        Me.cmdCancelar = New DevExpress.DXCore.Controls.XtraEditors.SimpleButton()
        Me.cmdGrabar = New DevExpress.DXCore.Controls.XtraEditors.SimpleButton()
        Me.chkGuiaRemision = New System.Windows.Forms.CheckBox()
        Me.chkFactura = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.ep = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ChkDetraccion = New System.Windows.Forms.CheckBox()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NudCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.dataPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.dataDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.ep, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.cefe.My.Resources.Resources.buscar18
        Me.PictureBox6.Location = New System.Drawing.Point(256, 6)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(18, 18)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox6.TabIndex = 1003
        Me.PictureBox6.TabStop = False
        '
        'cboArticulo
        '
        Me.cboArticulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboArticulo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboArticulo.ForeColor = System.Drawing.Color.SteelBlue
        Me.cboArticulo.FormattingEnabled = True
        Me.cboArticulo.ItemHeight = 16
        Me.cboArticulo.Location = New System.Drawing.Point(4, 27)
        Me.cboArticulo.Name = "cboArticulo"
        Me.cboArticulo.Size = New System.Drawing.Size(274, 24)
        Me.cboArticulo.Sorted = True
        Me.cboArticulo.TabIndex = 37
        '
        'cboTipoCliente
        '
        Me.cboTipoCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoCliente.FormattingEnabled = True
        Me.cboTipoCliente.Location = New System.Drawing.Point(-1, 467)
        Me.cboTipoCliente.Name = "cboTipoCliente"
        Me.cboTipoCliente.Size = New System.Drawing.Size(282, 23)
        Me.cboTipoCliente.TabIndex = 1001
        '
        'NudCantidad
        '
        Me.NudCantidad.BackColor = System.Drawing.SystemColors.Info
        Me.NudCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NudCantidad.ForeColor = System.Drawing.Color.DarkBlue
        Me.NudCantidad.Location = New System.Drawing.Point(213, 36)
        Me.NudCantidad.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.NudCantidad.Name = "NudCantidad"
        Me.NudCantidad.Size = New System.Drawing.Size(65, 23)
        Me.NudCantidad.TabIndex = 38
        Me.NudCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NudCantidad.Value = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NudCantidad.Visible = False
        '
        'panelgrupo
        '
        Me.panelgrupo.AutoScroll = True
        Me.panelgrupo.AutoScrollMargin = New System.Drawing.Size(40, 20)
        Me.panelgrupo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.panelgrupo.BackColor = System.Drawing.Color.Transparent
        Me.panelgrupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panelgrupo.ForeColor = System.Drawing.Color.Black
        Me.panelgrupo.Location = New System.Drawing.Point(3, 52)
        Me.panelgrupo.Name = "panelgrupo"
        Me.panelgrupo.Size = New System.Drawing.Size(275, 147)
        Me.panelgrupo.TabIndex = 68
        '
        'panelarticulos
        '
        Me.panelarticulos.AutoScroll = True
        Me.panelarticulos.AutoScrollMargin = New System.Drawing.Size(40, 20)
        Me.panelarticulos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.panelarticulos.BackColor = System.Drawing.Color.Transparent
        Me.panelarticulos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panelarticulos.Location = New System.Drawing.Point(4, 200)
        Me.panelarticulos.Name = "panelarticulos"
        Me.panelarticulos.Size = New System.Drawing.Size(274, 267)
        Me.panelarticulos.TabIndex = 39
        '
        'txtBuscar
        '
        Me.txtBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBuscar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(5, 6)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(248, 20)
        Me.txtBuscar.TabIndex = 307
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(280, 5)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(709, 198)
        Me.TabControl1.TabIndex = 5
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.cboAlmacen)
        Me.TabPage1.Controls.Add(Me.mcFechaVenta)
        Me.TabPage1.Controls.Add(Me.GroupBox7)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(701, 172)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Facturacion"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'cboAlmacen
        '
        Me.cboAlmacen.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboAlmacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAlmacen.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAlmacen.ForeColor = System.Drawing.Color.SteelBlue
        Me.cboAlmacen.FormattingEnabled = True
        Me.cboAlmacen.Location = New System.Drawing.Point(522, 6)
        Me.cboAlmacen.Name = "cboAlmacen"
        Me.cboAlmacen.Size = New System.Drawing.Size(172, 24)
        Me.cboAlmacen.TabIndex = 1
        '
        'mcFechaVenta
        '
        Me.mcFechaVenta.AnnuallyMarkedDates = New Date(-1) {}
        Me.mcFechaVenta.AutoSize = True
        '
        '
        '
        Me.mcFechaVenta.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.mcFechaVenta.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.mcFechaVenta.BackgroundStyle.BorderBottomWidth = 1
        Me.mcFechaVenta.BackgroundStyle.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.mcFechaVenta.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.mcFechaVenta.BackgroundStyle.BorderLeftWidth = 1
        Me.mcFechaVenta.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.mcFechaVenta.BackgroundStyle.BorderRightWidth = 1
        Me.mcFechaVenta.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.mcFechaVenta.BackgroundStyle.BorderTopWidth = 1
        Me.mcFechaVenta.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.mcFechaVenta.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.mcFechaVenta.ContainerControlProcessDialogKey = True
        Me.mcFechaVenta.DisplayMonth = New Date(2010, 10, 1, 0, 0, 0, 0)
        Me.mcFechaVenta.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.mcFechaVenta.Location = New System.Drawing.Point(524, 36)
        Me.mcFechaVenta.MarkedDates = New Date(-1) {}
        Me.mcFechaVenta.MaxDate = New Date(2020, 12, 31, 0, 0, 0, 0)
        Me.mcFechaVenta.MinDate = New Date(2010, 1, 1, 0, 0, 0, 0)
        Me.mcFechaVenta.MonthlyMarkedDates = New Date(-1) {}
        Me.mcFechaVenta.Name = "mcFechaVenta"
        '
        '
        '
        Me.mcFechaVenta.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.mcFechaVenta.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.mcFechaVenta.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.mcFechaVenta.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.mcFechaVenta.Size = New System.Drawing.Size(170, 131)
        Me.mcFechaVenta.TabIndex = 0
        Me.mcFechaVenta.Text = "MonthCalendarAdv1"
        Me.mcFechaVenta.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.txtTelefono)
        Me.GroupBox7.Controls.Add(Me.Label2)
        Me.GroupBox7.Controls.Add(Me.txtContacto)
        Me.GroupBox7.Controls.Add(Me.Label8)
        Me.GroupBox7.Controls.Add(Me.txtDirFiscal)
        Me.GroupBox7.Controls.Add(Me.Label7)
        Me.GroupBox7.Controls.Add(Me.txtRuc)
        Me.GroupBox7.Controls.Add(Me.cboCliente)
        Me.GroupBox7.Controls.Add(Me.Label17)
        Me.GroupBox7.Controls.Add(Me.Label18)
        Me.GroupBox7.Controls.Add(Me.cboDocumento)
        Me.GroupBox7.Controls.Add(Me.Label5)
        Me.GroupBox7.Controls.Add(Me.Label16)
        Me.GroupBox7.Controls.Add(Me.txtSerDocumento)
        Me.GroupBox7.Controls.Add(Me.txtNroDocumento)
        Me.GroupBox7.Location = New System.Drawing.Point(7, 6)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(507, 163)
        Me.GroupBox7.TabIndex = 4
        Me.GroupBox7.TabStop = False
        '
        'txtTelefono
        '
        Me.txtTelefono.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTelefono.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.Location = New System.Drawing.Point(419, 108)
        Me.txtTelefono.MaxLength = 9
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(80, 22)
        Me.txtTelefono.TabIndex = 36
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(349, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 18)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Teléfono"
        '
        'txtContacto
        '
        Me.txtContacto.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtContacto.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContacto.Location = New System.Drawing.Point(91, 110)
        Me.txtContacto.Name = "txtContacto"
        Me.txtContacto.Size = New System.Drawing.Size(252, 22)
        Me.txtContacto.TabIndex = 35
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(0, 110)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 18)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "Contacto"
        '
        'txtDirFiscal
        '
        Me.txtDirFiscal.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDirFiscal.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDirFiscal.ForeColor = System.Drawing.Color.SteelBlue
        Me.txtDirFiscal.Location = New System.Drawing.Point(91, 79)
        Me.txtDirFiscal.Name = "txtDirFiscal"
        Me.txtDirFiscal.Size = New System.Drawing.Size(408, 22)
        Me.txtDirFiscal.TabIndex = 31
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(1, 81)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 18)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "DirFiscal"
        '
        'txtRuc
        '
        Me.txtRuc.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRuc.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRuc.Location = New System.Drawing.Point(382, 47)
        Me.txtRuc.MaxLength = 11
        Me.txtRuc.Name = "txtRuc"
        Me.txtRuc.Size = New System.Drawing.Size(117, 22)
        Me.txtRuc.TabIndex = 29
        Me.txtRuc.TabStop = False
        '
        'cboCliente
        '
        Me.cboCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboCliente.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCliente.ForeColor = System.Drawing.Color.SteelBlue
        Me.cboCliente.FormattingEnabled = True
        Me.cboCliente.ItemHeight = 16
        Me.cboCliente.Location = New System.Drawing.Point(91, 49)
        Me.cboCliente.Name = "cboCliente"
        Me.cboCliente.Size = New System.Drawing.Size(241, 24)
        Me.cboCliente.TabIndex = 27
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(335, 51)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(41, 18)
        Me.Label17.TabIndex = 30
        Me.Label17.Text = "RUC"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(1, 51)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(59, 18)
        Me.Label18.TabIndex = 28
        Me.Label18.Text = "Cliente"
        '
        'cboDocumento
        '
        Me.cboDocumento.DisplayMember = "Text"
        Me.cboDocumento.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDocumento.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDocumento.ForeColor = System.Drawing.Color.SteelBlue
        Me.cboDocumento.FormattingEnabled = True
        Me.cboDocumento.ItemHeight = 16
        Me.cboDocumento.Location = New System.Drawing.Point(91, 19)
        Me.cboDocumento.Name = "cboDocumento"
        Me.cboDocumento.Size = New System.Drawing.Size(159, 22)
        Me.cboDocumento.TabIndex = 0
        Me.cboDocumento.WatermarkColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(0, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 18)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Documento"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(347, 19)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(16, 22)
        Me.Label16.TabIndex = 7
        Me.Label16.Text = "-"
        '
        'txtSerDocumento
        '
        Me.txtSerDocumento.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSerDocumento.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerDocumento.ForeColor = System.Drawing.Color.SteelBlue
        Me.txtSerDocumento.Location = New System.Drawing.Point(256, 19)
        Me.txtSerDocumento.Name = "txtSerDocumento"
        Me.txtSerDocumento.Size = New System.Drawing.Size(87, 22)
        Me.txtSerDocumento.TabIndex = 11
        '
        'txtNroDocumento
        '
        Me.txtNroDocumento.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNroDocumento.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroDocumento.ForeColor = System.Drawing.Color.SteelBlue
        Me.txtNroDocumento.Location = New System.Drawing.Point(363, 17)
        Me.txtNroDocumento.Name = "txtNroDocumento"
        Me.txtNroDocumento.Size = New System.Drawing.Size(136, 22)
        Me.txtNroDocumento.TabIndex = 12
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.chkMostrarPedidos)
        Me.TabPage2.Controls.Add(Me.GroupBox6)
        Me.TabPage2.Controls.Add(Me.dataPedidos)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(701, 172)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Pedido"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'chkMostrarPedidos
        '
        Me.chkMostrarPedidos.AutoSize = True
        '
        '
        '
        Me.chkMostrarPedidos.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chkMostrarPedidos.Location = New System.Drawing.Point(62, 142)
        Me.chkMostrarPedidos.Name = "chkMostrarPedidos"
        Me.chkMostrarPedidos.Size = New System.Drawing.Size(166, 15)
        Me.chkMostrarPedidos.TabIndex = 41
        Me.chkMostrarPedidos.TabStop = False
        Me.chkMostrarPedidos.Text = "Mostrar Pedidos Pendientes"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.lblVendedor)
        Me.GroupBox6.Controls.Add(Me.txtSerPedido)
        Me.GroupBox6.Controls.Add(Me.txtNroPedido)
        Me.GroupBox6.Controls.Add(Me.Label15)
        Me.GroupBox6.Controls.Add(Me.chkRecuperarPedido)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(10, 6)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(218, 130)
        Me.GroupBox6.TabIndex = 0
        Me.GroupBox6.TabStop = False
        '
        'lblVendedor
        '
        Me.lblVendedor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblVendedor.Location = New System.Drawing.Point(1, 112)
        Me.lblVendedor.Name = "lblVendedor"
        Me.lblVendedor.Size = New System.Drawing.Size(240, 15)
        Me.lblVendedor.TabIndex = 3
        Me.lblVendedor.Text = "VENDEDOR"
        Me.lblVendedor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSerPedido
        '
        Me.txtSerPedido.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSerPedido.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerPedido.ForeColor = System.Drawing.Color.SteelBlue
        Me.txtSerPedido.Location = New System.Drawing.Point(16, 68)
        Me.txtSerPedido.MaxLength = 6
        Me.txtSerPedido.Name = "txtSerPedido"
        Me.txtSerPedido.Size = New System.Drawing.Size(63, 22)
        Me.txtSerPedido.TabIndex = 0
        '
        'txtNroPedido
        '
        Me.txtNroPedido.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNroPedido.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroPedido.ForeColor = System.Drawing.Color.SteelBlue
        Me.txtNroPedido.Location = New System.Drawing.Point(95, 68)
        Me.txtNroPedido.MaxLength = 8
        Me.txtNroPedido.Name = "txtNroPedido"
        Me.txtNroPedido.Size = New System.Drawing.Size(102, 22)
        Me.txtNroPedido.TabIndex = 1
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(79, 66)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(16, 22)
        Me.Label15.TabIndex = 37
        Me.Label15.Text = "-"
        '
        'chkRecuperarPedido
        '
        Me.chkRecuperarPedido.Checked = True
        Me.chkRecuperarPedido.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkRecuperarPedido.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRecuperarPedido.Location = New System.Drawing.Point(33, 19)
        Me.chkRecuperarPedido.Name = "chkRecuperarPedido"
        Me.chkRecuperarPedido.Size = New System.Drawing.Size(157, 43)
        Me.chkRecuperarPedido.TabIndex = 0
        Me.chkRecuperarPedido.TabStop = False
        Me.chkRecuperarPedido.Text = "Recuperar Nro de Pedido"
        Me.chkRecuperarPedido.UseVisualStyleBackColor = True
        '
        'dataPedidos
        '
        Me.dataPedidos.AllowUserToAddRows = False
        Me.dataPedidos.AllowUserToDeleteRows = False
        Me.dataPedidos.AllowUserToResizeColumns = False
        Me.dataPedidos.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dataPedidos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dataPedidos.BackgroundColor = System.Drawing.Color.White
        Me.dataPedidos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dataPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataPedidos.DefaultCellStyle = DataGridViewCellStyle2
        Me.dataPedidos.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dataPedidos.Location = New System.Drawing.Point(234, 0)
        Me.dataPedidos.MultiSelect = False
        Me.dataPedidos.Name = "dataPedidos"
        Me.dataPedidos.ReadOnly = True
        Me.dataPedidos.RowHeadersVisible = False
        Me.dataPedidos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dataPedidos.SelectAllSignVisible = False
        Me.dataPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataPedidos.ShowEditingIcon = False
        Me.dataPedidos.Size = New System.Drawing.Size(354, 172)
        Me.dataPedidos.TabIndex = 2
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GroupBox2)
        Me.TabPage3.Controls.Add(Me.GroupBox1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(701, 172)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Transporte"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.cboEmpTransporte)
        Me.GroupBox2.Controls.Add(Me.cboConductor)
        Me.GroupBox2.Controls.Add(Me.txtNroPlaca)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(37, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(502, 68)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Conductor y Unidad de Transporte"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 19)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Emp. Transporte"
        '
        'cboEmpTransporte
        '
        Me.cboEmpTransporte.DisplayMember = "Text"
        Me.cboEmpTransporte.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboEmpTransporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEmpTransporte.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEmpTransporte.ForeColor = System.Drawing.Color.SteelBlue
        Me.cboEmpTransporte.FormattingEnabled = True
        Me.cboEmpTransporte.ItemHeight = 16
        Me.cboEmpTransporte.Location = New System.Drawing.Point(168, 40)
        Me.cboEmpTransporte.Name = "cboEmpTransporte"
        Me.cboEmpTransporte.Size = New System.Drawing.Size(326, 22)
        Me.cboEmpTransporte.TabIndex = 0
        Me.cboEmpTransporte.WatermarkColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'cboConductor
        '
        Me.cboConductor.DisplayMember = "Text"
        Me.cboConductor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboConductor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboConductor.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboConductor.ForeColor = System.Drawing.Color.SteelBlue
        Me.cboConductor.FormattingEnabled = True
        Me.cboConductor.ItemHeight = 16
        Me.cboConductor.Location = New System.Drawing.Point(12, 14)
        Me.cboConductor.Name = "cboConductor"
        Me.cboConductor.Size = New System.Drawing.Size(297, 22)
        Me.cboConductor.TabIndex = 0
        Me.cboConductor.WatermarkColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'txtNroPlaca
        '
        Me.txtNroPlaca.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNroPlaca.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroPlaca.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNroPlaca.Location = New System.Drawing.Point(378, 13)
        Me.txtNroPlaca.Name = "txtNroPlaca"
        Me.txtNroPlaca.Size = New System.Drawing.Size(112, 22)
        Me.txtNroPlaca.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(316, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Placa"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.cboDirEntrega)
        Me.GroupBox1.Controls.Add(Me.dtpTraslado)
        Me.GroupBox1.Controls.Add(Me.cboMotivo)
        Me.GroupBox1.Controls.Add(Me.dtpEntrega)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtNroGuia)
        Me.GroupBox1.Controls.Add(Me.txtSerGuia)
        Me.GroupBox1.Location = New System.Drawing.Point(37, 71)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(502, 96)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(4, 70)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(88, 18)
        Me.Label20.TabIndex = 41
        Me.Label20.Text = "Dir.Entrega"
        '
        'cboDirEntrega
        '
        Me.cboDirEntrega.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboDirEntrega.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDirEntrega.ForeColor = System.Drawing.Color.SteelBlue
        Me.cboDirEntrega.FormattingEnabled = True
        Me.cboDirEntrega.ItemHeight = 16
        Me.cboDirEntrega.Location = New System.Drawing.Point(89, 68)
        Me.cboDirEntrega.Name = "cboDirEntrega"
        Me.cboDirEntrega.Size = New System.Drawing.Size(401, 24)
        Me.cboDirEntrega.TabIndex = 40
        '
        'dtpTraslado
        '
        Me.dtpTraslado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTraslado.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTraslado.Location = New System.Drawing.Point(136, 43)
        Me.dtpTraslado.Name = "dtpTraslado"
        Me.dtpTraslado.Size = New System.Drawing.Size(116, 22)
        Me.dtpTraslado.TabIndex = 3
        '
        'cboMotivo
        '
        Me.cboMotivo.DisplayMember = "Text"
        Me.cboMotivo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboMotivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMotivo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMotivo.ForeColor = System.Drawing.Color.SteelBlue
        Me.cboMotivo.FormattingEnabled = True
        Me.cboMotivo.ItemHeight = 16
        Me.cboMotivo.Location = New System.Drawing.Point(290, 14)
        Me.cboMotivo.Name = "cboMotivo"
        Me.cboMotivo.Size = New System.Drawing.Size(200, 22)
        Me.cboMotivo.TabIndex = 2
        Me.cboMotivo.WatermarkColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'dtpEntrega
        '
        Me.dtpEntrega.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEntrega.Location = New System.Drawing.Point(372, 41)
        Me.dtpEntrega.Name = "dtpEntrega"
        Me.dtpEntrega.Size = New System.Drawing.Size(118, 22)
        Me.dtpEntrega.TabIndex = 4
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(260, 45)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(111, 18)
        Me.Label13.TabIndex = 7
        Me.Label13.Text = "Fecha Entrega"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(220, 18)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 18)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Motivo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 18)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Fecha:  Traslado"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 18)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Guía"
        '
        'txtNroGuia
        '
        Me.txtNroGuia.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNroGuia.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroGuia.ForeColor = System.Drawing.Color.Black
        Me.txtNroGuia.Location = New System.Drawing.Point(111, 14)
        Me.txtNroGuia.MaxLength = 8
        Me.txtNroGuia.Name = "txtNroGuia"
        Me.txtNroGuia.Size = New System.Drawing.Size(102, 22)
        Me.txtNroGuia.TabIndex = 1
        Me.txtNroGuia.Text = "00000000"
        '
        'txtSerGuia
        '
        Me.txtSerGuia.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSerGuia.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerGuia.ForeColor = System.Drawing.Color.Black
        Me.txtSerGuia.Location = New System.Drawing.Point(63, 14)
        Me.txtSerGuia.MaxLength = 3
        Me.txtSerGuia.Name = "txtSerGuia"
        Me.txtSerGuia.Size = New System.Drawing.Size(44, 22)
        Me.txtSerGuia.TabIndex = 0
        Me.txtSerGuia.Text = "000"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.GroupBox5)
        Me.TabPage4.Controls.Add(Me.cboVendedor)
        Me.TabPage4.Controls.Add(Me.Label19)
        Me.TabPage4.Controls.Add(Me.Label14)
        Me.TabPage4.Controls.Add(Me.cboFormaPago)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(701, 172)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Pago"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.lblTC)
        Me.GroupBox5.Controls.Add(Me.optDolares)
        Me.GroupBox5.Controls.Add(Me.optMoneda)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox5.Location = New System.Drawing.Point(518, 37)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(157, 66)
        Me.GroupBox5.TabIndex = 1003
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Tipo de Moneda"
        '
        'lblTC
        '
        Me.lblTC.AutoSize = True
        '
        '
        '
        Me.lblTC.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblTC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblTC.Location = New System.Drawing.Point(33, 47)
        Me.lblTC.Name = "lblTC"
        Me.lblTC.Size = New System.Drawing.Size(99, 15)
        Me.lblTC.TabIndex = 63
        Me.lblTC.Text = "Tipo Cambio 0.000"
        '
        'optDolares
        '
        Me.optDolares.AutoSize = True
        Me.optDolares.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optDolares.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.optDolares.Location = New System.Drawing.Point(84, 22)
        Me.optDolares.Name = "optDolares"
        Me.optDolares.Size = New System.Drawing.Size(68, 17)
        Me.optDolares.TabIndex = 3
        Me.optDolares.TabStop = True
        Me.optDolares.Text = "Dolares"
        Me.optDolares.UseVisualStyleBackColor = True
        '
        'optMoneda
        '
        Me.optMoneda.AutoSize = True
        Me.optMoneda.Checked = True
        Me.optMoneda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optMoneda.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.optMoneda.Location = New System.Drawing.Point(12, 22)
        Me.optMoneda.Name = "optMoneda"
        Me.optMoneda.Size = New System.Drawing.Size(70, 17)
        Me.optMoneda.TabIndex = 0
        Me.optMoneda.TabStop = True
        Me.optMoneda.Text = "Moneda"
        Me.optMoneda.UseVisualStyleBackColor = True
        '
        'cboVendedor
        '
        Me.cboVendedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboVendedor.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboVendedor.ForeColor = System.Drawing.Color.SteelBlue
        Me.cboVendedor.FormattingEnabled = True
        Me.cboVendedor.Location = New System.Drawing.Point(167, 21)
        Me.cboVendedor.Name = "cboVendedor"
        Me.cboVendedor.Size = New System.Drawing.Size(260, 24)
        Me.cboVendedor.TabIndex = 6
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(80, 24)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(76, 18)
        Me.Label19.TabIndex = 5
        Me.Label19.Text = "Vendedor"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label14.Location = New System.Drawing.Point(43, 51)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(114, 18)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "Forma de Pago"
        '
        'cboFormaPago
        '
        Me.cboFormaPago.DisplayMember = "Text"
        Me.cboFormaPago.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFormaPago.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFormaPago.ForeColor = System.Drawing.Color.SteelBlue
        Me.cboFormaPago.FormattingEnabled = True
        Me.cboFormaPago.ItemHeight = 16
        Me.cboFormaPago.Location = New System.Drawing.Point(167, 51)
        Me.cboFormaPago.Name = "cboFormaPago"
        Me.cboFormaPago.Size = New System.Drawing.Size(191, 22)
        Me.cboFormaPago.TabIndex = 2
        Me.cboFormaPago.WatermarkColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'chkIGV
        '
        Me.chkIGV.AutoSize = True
        Me.chkIGV.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.chkIGV.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chkIGV.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkIGV.Location = New System.Drawing.Point(601, 511)
        Me.chkIGV.Name = "chkIGV"
        Me.chkIGV.Size = New System.Drawing.Size(129, 15)
        Me.chkIGV.TabIndex = 62
        Me.chkIGV.Text = "Precios Incluyen IGV"
        Me.chkIGV.TextColor = System.Drawing.Color.MidnightBlue
        '
        'lblItems
        '
        Me.lblItems.AutoSize = True
        '
        '
        '
        Me.lblItems.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblItems.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItems.Location = New System.Drawing.Point(288, 472)
        Me.lblItems.Name = "lblItems"
        Me.lblItems.Size = New System.Drawing.Size(80, 15)
        Me.lblItems.TabIndex = 60
        Me.lblItems.Text = "Nro de Items. 0"
        '
        'dataDetalle
        '
        Me.dataDetalle.AllowUserToAddRows = False
        Me.dataDetalle.AllowUserToDeleteRows = False
        Me.dataDetalle.AllowUserToResizeColumns = False
        Me.dataDetalle.AllowUserToResizeRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        Me.dataDetalle.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dataDetalle.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dataDetalle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dataDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataDetalle.DefaultCellStyle = DataGridViewCellStyle4
        Me.dataDetalle.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dataDetalle.Location = New System.Drawing.Point(278, 200)
        Me.dataDetalle.MultiSelect = False
        Me.dataDetalle.Name = "dataDetalle"
        Me.dataDetalle.ReadOnly = True
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataDetalle.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dataDetalle.RowHeadersVisible = False
        Me.dataDetalle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dataDetalle.SelectAllSignVisible = False
        Me.dataDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dataDetalle.ShowEditingIcon = False
        Me.dataDetalle.Size = New System.Drawing.Size(711, 267)
        Me.dataDetalle.TabIndex = 3
        '
        'lblMensaje
        '
        Me.lblMensaje.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensaje.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblMensaje.Location = New System.Drawing.Point(204, 561)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(337, 20)
        Me.lblMensaje.TabIndex = 35
        Me.lblMensaje.Text = "Mensaje"
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTotal.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.ForeColor = System.Drawing.Color.DarkGreen
        Me.txtTotal.Location = New System.Drawing.Point(838, 533)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(133, 22)
        Me.txtTotal.TabIndex = 34
        Me.txtTotal.TabStop = False
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label12.Location = New System.Drawing.Point(757, 539)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(50, 16)
        Me.Label12.TabIndex = 33
        Me.Label12.Text = "TOTAL"
        '
        'txtIGV
        '
        Me.txtIGV.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtIGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtIGV.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIGV.ForeColor = System.Drawing.Color.DarkGreen
        Me.txtIGV.Location = New System.Drawing.Point(838, 508)
        Me.txtIGV.Name = "txtIGV"
        Me.txtIGV.ReadOnly = True
        Me.txtIGV.Size = New System.Drawing.Size(133, 22)
        Me.txtIGV.TabIndex = 32
        Me.txtIGV.TabStop = False
        Me.txtIGV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label11.Location = New System.Drawing.Point(776, 510)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(31, 16)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "IGV"
        '
        'txtSubTotal
        '
        Me.txtSubTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSubTotal.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubTotal.ForeColor = System.Drawing.Color.DarkGreen
        Me.txtSubTotal.Location = New System.Drawing.Point(838, 483)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.ReadOnly = True
        Me.txtSubTotal.Size = New System.Drawing.Size(133, 22)
        Me.txtSubTotal.TabIndex = 30
        Me.txtSubTotal.TabStop = False
        Me.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label10.Location = New System.Drawing.Point(726, 484)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 16)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "SUB TOTAL"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmdImprimir)
        Me.GroupBox3.Controls.Add(Me.cmdAnular)
        Me.GroupBox3.Controls.Add(Me.cmdCancelar)
        Me.GroupBox3.Controls.Add(Me.cmdGrabar)
        Me.GroupBox3.Controls.Add(Me.chkGuiaRemision)
        Me.GroupBox3.Controls.Add(Me.chkFactura)
        Me.GroupBox3.Location = New System.Drawing.Point(1, 488)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(540, 70)
        Me.GroupBox3.TabIndex = 999
        Me.GroupBox3.TabStop = False
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmdImprimir.Appearance.Options.UseFont = True
        Me.cmdImprimir.Enabled = False
        Me.cmdImprimir.Image = Global.cefe.My.Resources.Resources.print_preview
        Me.cmdImprimir.ImageLocation = DevExpress.DXCore.Controls.XtraEditors.ImageLocation.TopCenter
        Me.cmdImprimir.Location = New System.Drawing.Point(308, 13)
        Me.cmdImprimir.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(87, 50)
        Me.cmdImprimir.TabIndex = 3
        Me.cmdImprimir.Text = "IMPRIMIR"
        '
        'cmdAnular
        '
        Me.cmdAnular.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmdAnular.Appearance.Options.UseFont = True
        Me.cmdAnular.Enabled = False
        Me.cmdAnular.Image = Global.cefe.My.Resources.Resources.m_borrar
        Me.cmdAnular.ImageLocation = DevExpress.DXCore.Controls.XtraEditors.ImageLocation.TopCenter
        Me.cmdAnular.Location = New System.Drawing.Point(209, 13)
        Me.cmdAnular.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdAnular.Name = "cmdAnular"
        Me.cmdAnular.Size = New System.Drawing.Size(87, 50)
        Me.cmdAnular.TabIndex = 2
        Me.cmdAnular.Text = "ANULAR"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.Enabled = False
        Me.cmdCancelar.Image = Global.cefe.My.Resources.Resources.m_cancelar
        Me.cmdCancelar.ImageLocation = DevExpress.DXCore.Controls.XtraEditors.ImageLocation.TopCenter
        Me.cmdCancelar.Location = New System.Drawing.Point(110, 13)
        Me.cmdCancelar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(87, 50)
        Me.cmdCancelar.TabIndex = 1
        Me.cmdCancelar.Text = "CANCELAR"
        '
        'cmdGrabar
        '
        Me.cmdGrabar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmdGrabar.Appearance.Options.UseFont = True
        Me.cmdGrabar.Enabled = False
        Me.cmdGrabar.Image = Global.cefe.My.Resources.Resources.m_grabar
        Me.cmdGrabar.ImageLocation = DevExpress.DXCore.Controls.XtraEditors.ImageLocation.TopCenter
        Me.cmdGrabar.Location = New System.Drawing.Point(10, 13)
        Me.cmdGrabar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdGrabar.Name = "cmdGrabar"
        Me.cmdGrabar.Size = New System.Drawing.Size(87, 50)
        Me.cmdGrabar.TabIndex = 0
        Me.cmdGrabar.Text = "GRABAR"
        '
        'chkGuiaRemision
        '
        Me.chkGuiaRemision.AutoSize = True
        Me.chkGuiaRemision.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkGuiaRemision.Location = New System.Drawing.Point(409, 44)
        Me.chkGuiaRemision.Name = "chkGuiaRemision"
        Me.chkGuiaRemision.Size = New System.Drawing.Size(107, 17)
        Me.chkGuiaRemision.TabIndex = 19
        Me.chkGuiaRemision.Text = "Guia Remisión"
        Me.chkGuiaRemision.UseVisualStyleBackColor = True
        '
        'chkFactura
        '
        Me.chkFactura.AutoSize = True
        Me.chkFactura.Checked = True
        Me.chkFactura.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFactura.Location = New System.Drawing.Point(409, 19)
        Me.chkFactura.Name = "chkFactura"
        Me.chkFactura.Size = New System.Drawing.Size(69, 17)
        Me.chkFactura.TabIndex = 18
        Me.chkFactura.Text = "Factura"
        Me.chkFactura.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox4.Location = New System.Drawing.Point(594, 470)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(395, 117)
        Me.GroupBox4.TabIndex = 1002
        Me.GroupBox4.TabStop = False
        '
        'ep
        '
        Me.ep.ContainerControl = Me
        '
        'ChkDetraccion
        '
        Me.ChkDetraccion.AutoSize = True
        Me.ChkDetraccion.Checked = True
        Me.ChkDetraccion.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkDetraccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkDetraccion.Location = New System.Drawing.Point(410, 473)
        Me.ChkDetraccion.Name = "ChkDetraccion"
        Me.ChkDetraccion.Size = New System.Drawing.Size(111, 17)
        Me.ChkDetraccion.TabIndex = 1004
        Me.ChkDetraccion.Text = "imp Detraccion"
        Me.ChkDetraccion.UseVisualStyleBackColor = True
        '
        'p_ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(985, 581)
        Me.Controls.Add(Me.ChkDetraccion)
        Me.Controls.Add(Me.panelgrupo)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.cboArticulo)
        Me.Controls.Add(Me.cboTipoCliente)
        Me.Controls.Add(Me.NudCantidad)
        Me.Controls.Add(Me.panelarticulos)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.chkIGV)
        Me.Controls.Add(Me.lblItems)
        Me.Controls.Add(Me.dataDetalle)
        Me.Controls.Add(Me.lblMensaje)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtIGV)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtSubTotal)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "p_ventas"
        Me.Text = "Proceso: REGISTRO DE VENTAS"
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NudCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.dataPedidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.dataDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.ep, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNroPlaca As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtNroGuia As System.Windows.Forms.TextBox
    Friend WithEvents txtSerGuia As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtSubTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtIGV As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents dtpEntrega As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents ep As System.Windows.Forms.ErrorProvider
    Friend WithEvents chkGuiaRemision As System.Windows.Forms.CheckBox
    Friend WithEvents chkFactura As System.Windows.Forms.CheckBox
    Friend WithEvents lblMensaje As System.Windows.Forms.Label
    Friend WithEvents cmdGrabar As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents cmdImprimir As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents cmdAnular As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents cmdCancelar As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents dataDetalle As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents cboConductor As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cboEmpTransporte As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cboMotivo As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents dtpTraslado As System.Windows.Forms.DateTimePicker
    Friend WithEvents dataPedidos As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents chkMostrarPedidos As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents mcFechaVenta As DevComponents.Editors.DateTimeAdv.MonthCalendarAdv
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents cboDocumento As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents txtNroDocumento As System.Windows.Forms.TextBox
    Friend WithEvents txtSerDocumento As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents lblVendedor As System.Windows.Forms.Label
    Friend WithEvents txtSerPedido As System.Windows.Forms.TextBox
    Friend WithEvents txtNroPedido As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents chkRecuperarPedido As System.Windows.Forms.CheckBox
    Friend WithEvents lblItems As DevComponents.DotNetBar.LabelX
    Friend WithEvents chkIGV As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboAlmacen As System.Windows.Forms.ComboBox
    Friend WithEvents panelarticulos As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents panelgrupo As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents NudCantidad As System.Windows.Forms.NumericUpDown
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cboFormaPago As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cboVendedor As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtRuc As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents cboCliente As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtContacto As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtDirFiscal As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboTipoCliente As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents lblTC As DevComponents.DotNetBar.LabelX
    Friend WithEvents optDolares As System.Windows.Forms.RadioButton
    Friend WithEvents optMoneda As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents cboArticulo As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents cboDirEntrega As System.Windows.Forms.ComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents ChkDetraccion As CheckBox
End Class
