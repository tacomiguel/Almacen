<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class repVentas
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(repVentas))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.optPedido = New System.Windows.Forms.RadioButton()
        Me.optDocumento = New System.Windows.Forms.RadioButton()
        Me.optCliente = New System.Windows.Forms.RadioButton()
        Me.optProducciones = New System.Windows.Forms.RadioButton()
        Me.optProducto = New System.Windows.Forms.RadioButton()
        Me.optRegistro = New System.Windows.Forms.RadioButton()
        Me.cmdImprimir = New DevComponents.DotNetBar.ButtonX()
        Me.cmdCerrar = New DevComponents.DotNetBar.ButtonX()
        Me.dataDetalle = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkDia = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.dtiHasta = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.dtiDesde = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.cboAnno = New System.Windows.Forms.ComboBox()
        Me.cboMes = New System.Windows.Forms.ComboBox()
        Me.grupoAlmacen = New System.Windows.Forms.GroupBox()
        Me.cboUnidad = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.chkUnidad = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.chkfiltro = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.cboGrupo = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.cboAlmacen = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.chkAlmacen = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.lblRegistros = New DevComponents.DotNetBar.LabelX()
        Me.TabControl2 = New DevComponents.DotNetBar.TabControl()
        Me.TabControlPanel4 = New DevComponents.DotNetBar.TabControlPanel()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.lblMontoDS = New DevComponents.DotNetBar.LabelX()
        Me.lblMonedaDS = New DevComponents.DotNetBar.LabelX()
        Me.tabDetalle = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel5 = New DevComponents.DotNetBar.TabControlPanel()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.optValorizado = New System.Windows.Forms.RadioButton()
        Me.optCantidades = New System.Windows.Forms.RadioButton()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.optingresos = New System.Windows.Forms.RadioButton()
        Me.optsalidas = New System.Windows.Forms.RadioButton()
        Me.dataResumen = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.tabResumen = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel1 = New DevComponents.DotNetBar.TabControlPanel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.optmontoventa = New System.Windows.Forms.RadioButton()
        Me.optcantventa = New System.Windows.Forms.RadioButton()
        Me.chkVenta = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.optmes = New System.Windows.Forms.RadioButton()
        Me.optdia = New System.Windows.Forms.RadioButton()
        Me.dataIngMenu = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.TabIngMenu = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TxtBuscar2 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.chkProduccion = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dataDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.dtiHasta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtiDesde, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel1.SuspendLayout()
        Me.grupoAlmacen.SuspendLayout()
        CType(Me.TabControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl2.SuspendLayout()
        Me.TabControlPanel4.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlPanel5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.dataResumen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlPanel1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dataIngMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox9.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.optPedido)
        Me.GroupBox2.Controls.Add(Me.optDocumento)
        Me.GroupBox2.Controls.Add(Me.optCliente)
        Me.GroupBox2.Controls.Add(Me.optProducciones)
        Me.GroupBox2.Controls.Add(Me.optProducto)
        Me.GroupBox2.Controls.Add(Me.optRegistro)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox2.Location = New System.Drawing.Point(260, 4)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(487, 71)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tipo de Reporte"
        '
        'optPedido
        '
        Me.optPedido.AutoSize = True
        Me.optPedido.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optPedido.ForeColor = System.Drawing.Color.Black
        Me.optPedido.Location = New System.Drawing.Point(328, 44)
        Me.optPedido.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.optPedido.Name = "optPedido"
        Me.optPedido.Size = New System.Drawing.Size(135, 20)
        Me.optPedido.TabIndex = 5
        Me.optPedido.Text = "Hoja de Pedido"
        Me.optPedido.UseVisualStyleBackColor = True
        '
        'optDocumento
        '
        Me.optDocumento.AutoSize = True
        Me.optDocumento.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optDocumento.ForeColor = System.Drawing.Color.Black
        Me.optDocumento.Location = New System.Drawing.Point(11, 42)
        Me.optDocumento.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.optDocumento.Name = "optDocumento"
        Me.optDocumento.Size = New System.Drawing.Size(121, 20)
        Me.optDocumento.TabIndex = 4
        Me.optDocumento.Text = "x Documento"
        Me.optDocumento.UseVisualStyleBackColor = True
        '
        'optCliente
        '
        Me.optCliente.AutoSize = True
        Me.optCliente.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optCliente.ForeColor = System.Drawing.Color.Black
        Me.optCliente.Location = New System.Drawing.Point(193, 43)
        Me.optCliente.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.optCliente.Name = "optCliente"
        Me.optCliente.Size = New System.Drawing.Size(91, 20)
        Me.optCliente.TabIndex = 1
        Me.optCliente.Text = "x Cliente"
        Me.optCliente.UseVisualStyleBackColor = True
        '
        'optProducciones
        '
        Me.optProducciones.AutoSize = True
        Me.optProducciones.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optProducciones.ForeColor = System.Drawing.Color.Black
        Me.optProducciones.Location = New System.Drawing.Point(328, 20)
        Me.optProducciones.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.optProducciones.Name = "optProducciones"
        Me.optProducciones.Size = New System.Drawing.Size(126, 20)
        Me.optProducciones.TabIndex = 3
        Me.optProducciones.Text = "Producciones"
        Me.optProducciones.UseVisualStyleBackColor = True
        '
        'optProducto
        '
        Me.optProducto.AutoSize = True
        Me.optProducto.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optProducto.ForeColor = System.Drawing.Color.Black
        Me.optProducto.Location = New System.Drawing.Point(193, 20)
        Me.optProducto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.optProducto.Name = "optProducto"
        Me.optProducto.Size = New System.Drawing.Size(105, 20)
        Me.optProducto.TabIndex = 2
        Me.optProducto.Text = "x Producto"
        Me.optProducto.UseVisualStyleBackColor = True
        '
        'optRegistro
        '
        Me.optRegistro.AutoSize = True
        Me.optRegistro.Checked = True
        Me.optRegistro.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optRegistro.ForeColor = System.Drawing.Color.Black
        Me.optRegistro.Location = New System.Drawing.Point(11, 20)
        Me.optRegistro.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.optRegistro.Name = "optRegistro"
        Me.optRegistro.Size = New System.Drawing.Size(162, 20)
        Me.optRegistro.TabIndex = 0
        Me.optRegistro.TabStop = True
        Me.optRegistro.Text = "Registro de Ventas"
        Me.optRegistro.UseVisualStyleBackColor = True
        '
        'cmdImprimir
        '
        Me.cmdImprimir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdImprimir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdImprimir.Image = Global.cefe.My.Resources.Resources.print_preview
        Me.cmdImprimir.Location = New System.Drawing.Point(1171, 55)
        Me.cmdImprimir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.cmdImprimir.Size = New System.Drawing.Size(123, 44)
        Me.cmdImprimir.TabIndex = 4
        Me.cmdImprimir.Text = "Imprimir"
        '
        'cmdCerrar
        '
        Me.cmdCerrar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdCerrar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCerrar.Image = Global.cefe.My.Resources.Resources.CLOSE22
        Me.cmdCerrar.Location = New System.Drawing.Point(1171, 6)
        Me.cmdCerrar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdCerrar.Name = "cmdCerrar"
        Me.cmdCerrar.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.cmdCerrar.Size = New System.Drawing.Size(123, 44)
        Me.cmdCerrar.TabIndex = 5
        Me.cmdCerrar.Text = "Cerrar"
        '
        'dataDetalle
        '
        Me.dataDetalle.AllowUserToAddRows = False
        Me.dataDetalle.AllowUserToResizeColumns = False
        Me.dataDetalle.AllowUserToResizeRows = False
        Me.dataDetalle.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dataDetalle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataDetalle.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dataDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataDetalle.DefaultCellStyle = DataGridViewCellStyle2
        Me.dataDetalle.Dock = System.Windows.Forms.DockStyle.Top
        Me.dataDetalle.EnableHeadersVisualStyles = False
        Me.dataDetalle.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dataDetalle.Location = New System.Drawing.Point(1, 1)
        Me.dataDetalle.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dataDetalle.Name = "dataDetalle"
        Me.dataDetalle.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataDetalle.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dataDetalle.RowHeadersVisible = False
        Me.dataDetalle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dataDetalle.SelectAllSignVisible = False
        Me.dataDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dataDetalle.ShowEditingIcon = False
        Me.dataDetalle.Size = New System.Drawing.Size(1299, 496)
        Me.dataDetalle.TabIndex = 83
        '
        'GroupBox1
        '
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(-24, 146)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(1325, 12)
        Me.GroupBox1.TabIndex = 87
        Me.GroupBox1.TabStop = False
        '
        'chkDia
        '
        Me.chkDia.AutoSize = True
        '
        '
        '
        Me.chkDia.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chkDia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDia.Location = New System.Drawing.Point(27, 73)
        Me.chkDia.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkDia.Name = "chkDia"
        Me.chkDia.Size = New System.Drawing.Size(138, 18)
        Me.chkDia.TabIndex = 126
        Me.chkDia.TabStop = False
        Me.chkDia.Text = "x Rango de Fecha "
        Me.chkDia.TextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.dtiHasta)
        Me.GroupBox5.Controls.Add(Me.dtiDesde)
        Me.GroupBox5.Controls.Add(Me.LabelX1)
        Me.GroupBox5.Controls.Add(Me.LabelX2)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.SystemColors.Desktop
        Me.GroupBox5.Location = New System.Drawing.Point(13, 78)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox5.Size = New System.Drawing.Size(336, 55)
        Me.GroupBox5.TabIndex = 127
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
        Me.dtiHasta.Enabled = False
        Me.dtiHasta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.dtiHasta.IsInputReadOnly = True
        Me.dtiHasta.IsPopupCalendarOpen = False
        Me.dtiHasta.Location = New System.Drawing.Point(221, 21)
        Me.dtiHasta.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtiHasta.MaxDate = New Date(2020, 12, 31, 0, 0, 0, 0)
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
        Me.dtiHasta.Size = New System.Drawing.Size(107, 23)
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
        Me.dtiDesde.Enabled = False
        Me.dtiDesde.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.dtiDesde.IsInputReadOnly = True
        Me.dtiDesde.IsPopupCalendarOpen = False
        Me.dtiDesde.Location = New System.Drawing.Point(60, 21)
        Me.dtiDesde.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtiDesde.MaxDate = New Date(2020, 12, 31, 0, 0, 0, 0)
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
        Me.dtiDesde.Size = New System.Drawing.Size(107, 23)
        Me.dtiDesde.TabIndex = 119
        '
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.ForeColor = System.Drawing.Color.Black
        Me.LabelX1.Location = New System.Drawing.Point(11, 23)
        Me.LabelX1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(41, 18)
        Me.LabelX1.TabIndex = 115
        Me.LabelX1.Text = "desde"
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Center
        Me.LabelX1.WordWrap = True
        '
        'LabelX2
        '
        Me.LabelX2.AutoSize = True
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.ForeColor = System.Drawing.Color.Black
        Me.LabelX2.Location = New System.Drawing.Point(177, 23)
        Me.LabelX2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(38, 18)
        Me.LabelX2.TabIndex = 117
        Me.LabelX2.Text = "hasta"
        Me.LabelX2.TextAlignment = System.Drawing.StringAlignment.Center
        Me.LabelX2.WordWrap = True
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.cboAnno)
        Me.GroupPanel1.Controls.Add(Me.cboMes)
        Me.GroupPanel1.Location = New System.Drawing.Point(13, 9)
        Me.GroupPanel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(239, 62)
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
        Me.GroupPanel1.TabIndex = 125
        Me.GroupPanel1.Text = "Periodo de Reporte"
        '
        'cboAnno
        '
        Me.cboAnno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAnno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAnno.FormattingEnabled = True
        Me.cboAnno.Items.AddRange(New Object() {"2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025"})
        Me.cboAnno.Location = New System.Drawing.Point(143, 6)
        Me.cboAnno.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboAnno.Name = "cboAnno"
        Me.cboAnno.Size = New System.Drawing.Size(79, 25)
        Me.cboAnno.TabIndex = 1
        '
        'cboMes
        '
        Me.cboMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMes.FormattingEnabled = True
        Me.cboMes.Items.AddRange(New Object() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Setiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.cboMes.Location = New System.Drawing.Point(7, 6)
        Me.cboMes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboMes.Name = "cboMes"
        Me.cboMes.Size = New System.Drawing.Size(124, 25)
        Me.cboMes.TabIndex = 0
        '
        'grupoAlmacen
        '
        Me.grupoAlmacen.Controls.Add(Me.cboUnidad)
        Me.grupoAlmacen.Controls.Add(Me.chkUnidad)
        Me.grupoAlmacen.Controls.Add(Me.chkfiltro)
        Me.grupoAlmacen.Controls.Add(Me.cboGrupo)
        Me.grupoAlmacen.Controls.Add(Me.cboAlmacen)
        Me.grupoAlmacen.Controls.Add(Me.chkAlmacen)
        Me.grupoAlmacen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupoAlmacen.ForeColor = System.Drawing.Color.Maroon
        Me.grupoAlmacen.Location = New System.Drawing.Point(755, 4)
        Me.grupoAlmacen.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grupoAlmacen.Name = "grupoAlmacen"
        Me.grupoAlmacen.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grupoAlmacen.Size = New System.Drawing.Size(343, 145)
        Me.grupoAlmacen.TabIndex = 129
        Me.grupoAlmacen.TabStop = False
        '
        'cboUnidad
        '
        Me.cboUnidad.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboUnidad.DisplayMember = "Text"
        Me.cboUnidad.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboUnidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUnidad.Enabled = False
        Me.cboUnidad.FocusHighlightColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.cboUnidad.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboUnidad.ItemHeight = 15
        Me.cboUnidad.Location = New System.Drawing.Point(11, 118)
        Me.cboUnidad.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboUnidad.Name = "cboUnidad"
        Me.cboUnidad.Size = New System.Drawing.Size(317, 21)
        Me.cboUnidad.TabIndex = 155
        '
        'chkUnidad
        '
        Me.chkUnidad.AutoSize = True
        '
        '
        '
        Me.chkUnidad.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chkUnidad.Location = New System.Drawing.Point(11, 98)
        Me.chkUnidad.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkUnidad.Name = "chkUnidad"
        Me.chkUnidad.Size = New System.Drawing.Size(68, 18)
        Me.chkUnidad.TabIndex = 154
        Me.chkUnidad.Text = "Unidad"
        '
        'chkfiltro
        '
        Me.chkfiltro.AutoSize = True
        '
        '
        '
        Me.chkfiltro.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chkfiltro.Location = New System.Drawing.Point(11, 48)
        Me.chkfiltro.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkfiltro.Name = "chkfiltro"
        Me.chkfiltro.Size = New System.Drawing.Size(30, 18)
        Me.chkfiltro.TabIndex = 153
        Me.chkfiltro.Text = "_"
        '
        'cboGrupo
        '
        Me.cboGrupo.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboGrupo.DisplayMember = "Text"
        Me.cboGrupo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGrupo.Enabled = False
        Me.cboGrupo.FocusHighlightColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.cboGrupo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGrupo.ItemHeight = 15
        Me.cboGrupo.Location = New System.Drawing.Point(11, 66)
        Me.cboGrupo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboGrupo.Name = "cboGrupo"
        Me.cboGrupo.Size = New System.Drawing.Size(317, 21)
        Me.cboGrupo.TabIndex = 13
        '
        'cboAlmacen
        '
        Me.cboAlmacen.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboAlmacen.DisplayMember = "Text"
        Me.cboAlmacen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboAlmacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAlmacen.Enabled = False
        Me.cboAlmacen.FocusHighlightColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.cboAlmacen.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAlmacen.ItemHeight = 15
        Me.cboAlmacen.Location = New System.Drawing.Point(11, 18)
        Me.cboAlmacen.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboAlmacen.Name = "cboAlmacen"
        Me.cboAlmacen.Size = New System.Drawing.Size(317, 21)
        Me.cboAlmacen.TabIndex = 52
        '
        'chkAlmacen
        '
        Me.chkAlmacen.AutoSize = True
        '
        '
        '
        Me.chkAlmacen.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chkAlmacen.Location = New System.Drawing.Point(11, -1)
        Me.chkAlmacen.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkAlmacen.Name = "chkAlmacen"
        Me.chkAlmacen.Size = New System.Drawing.Size(78, 18)
        Me.chkAlmacen.TabIndex = 51
        Me.chkAlmacen.Text = "Almacén"
        '
        'lblRegistros
        '
        '
        '
        '
        Me.lblRegistros.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblRegistros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistros.ForeColor = System.Drawing.Color.Green
        Me.lblRegistros.Location = New System.Drawing.Point(11, 133)
        Me.lblRegistros.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblRegistros.Name = "lblRegistros"
        Me.lblRegistros.Size = New System.Drawing.Size(300, 23)
        Me.lblRegistros.TabIndex = 130
        Me.lblRegistros.Text = "Nº de Documentos Procesados... "
        Me.lblRegistros.TextAlignment = System.Drawing.StringAlignment.Far
        Me.lblRegistros.WordWrap = True
        '
        'TabControl2
        '
        Me.TabControl2.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabControl2.CanReorderTabs = False
        Me.TabControl2.ColorScheme.TabBackground = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabControl2.ColorScheme.TabBackground2 = System.Drawing.Color.White
        Me.TabControl2.ColorScheme.TabItemBackground = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.TabControl2.ColorScheme.TabItemBackground2 = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabControl2.Controls.Add(Me.TabControlPanel4)
        Me.TabControl2.Controls.Add(Me.TabControlPanel5)
        Me.TabControl2.Controls.Add(Me.TabControlPanel1)
        Me.TabControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TabControl2.Location = New System.Drawing.Point(0, 166)
        Me.TabControl2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TabControl2.SelectedTabIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(1301, 566)
        Me.TabControl2.Style = DevComponents.DotNetBar.eTabStripStyle.VS2005Document
        Me.TabControl2.TabIndex = 143
        Me.TabControl2.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
        Me.TabControl2.Tabs.Add(Me.tabDetalle)
        Me.TabControl2.Tabs.Add(Me.tabResumen)
        Me.TabControl2.Tabs.Add(Me.TabIngMenu)
        Me.TabControl2.Text = "Precio de Costo Vs. Precio de Venta"
        '
        'TabControlPanel4
        '
        Me.TabControlPanel4.Controls.Add(Me.PictureBox5)
        Me.TabControlPanel4.Controls.Add(Me.lblMontoDS)
        Me.TabControlPanel4.Controls.Add(Me.lblMonedaDS)
        Me.TabControlPanel4.Controls.Add(Me.dataDetalle)
        Me.TabControlPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel4.Location = New System.Drawing.Point(0, 26)
        Me.TabControlPanel4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabControlPanel4.Name = "TabControlPanel4"
        Me.TabControlPanel4.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel4.Size = New System.Drawing.Size(1301, 540)
        Me.TabControlPanel4.Style.BackColor1.Color = System.Drawing.Color.White
        Me.TabControlPanel4.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabControlPanel4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel4.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.TabControlPanel4.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel4.Style.GradientAngle = 90
        Me.TabControlPanel4.TabIndex = 1
        Me.TabControlPanel4.TabItem = Me.tabDetalle
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.cefe.My.Resources.Resources.continuar16
        Me.PictureBox5.Location = New System.Drawing.Point(1063, 505)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox5.TabIndex = 147
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
        Me.lblMontoDS.Location = New System.Drawing.Point(1089, 505)
        Me.lblMontoDS.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblMontoDS.Name = "lblMontoDS"
        Me.lblMontoDS.Size = New System.Drawing.Size(52, 18)
        Me.lblMontoDS.TabIndex = 146
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
        Me.lblMonedaDS.Location = New System.Drawing.Point(813, 505)
        Me.lblMonedaDS.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblMonedaDS.Name = "lblMonedaDS"
        Me.lblMonedaDS.Size = New System.Drawing.Size(243, 18)
        Me.lblMonedaDS.TabIndex = 145
        Me.lblMonedaDS.Text = "Moneda"
        Me.lblMonedaDS.TextAlignment = System.Drawing.StringAlignment.Far
        Me.lblMonedaDS.WordWrap = True
        '
        'tabDetalle
        '
        Me.tabDetalle.AttachedControl = Me.TabControlPanel4
        Me.tabDetalle.Icon = CType(resources.GetObject("tabDetalle.Icon"), System.Drawing.Icon)
        Me.tabDetalle.Name = "tabDetalle"
        Me.tabDetalle.Text = "Detalle de Salidas"
        '
        'TabControlPanel5
        '
        Me.TabControlPanel5.Controls.Add(Me.GroupBox6)
        Me.TabControlPanel5.Controls.Add(Me.GroupBox7)
        Me.TabControlPanel5.Controls.Add(Me.dataResumen)
        Me.TabControlPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel5.Location = New System.Drawing.Point(0, 26)
        Me.TabControlPanel5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabControlPanel5.Name = "TabControlPanel5"
        Me.TabControlPanel5.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel5.Size = New System.Drawing.Size(1301, 540)
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
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.White
        Me.GroupBox6.Controls.Add(Me.optValorizado)
        Me.GroupBox6.Controls.Add(Me.optCantidades)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.Color.Black
        Me.GroupBox6.Location = New System.Drawing.Point(8, -7)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox6.Size = New System.Drawing.Size(248, 44)
        Me.GroupBox6.TabIndex = 142
        Me.GroupBox6.TabStop = False
        '
        'optValorizado
        '
        Me.optValorizado.AutoSize = True
        Me.optValorizado.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optValorizado.ForeColor = System.Drawing.Color.Black
        Me.optValorizado.Location = New System.Drawing.Point(133, 15)
        Me.optValorizado.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.optValorizado.Name = "optValorizado"
        Me.optValorizado.Size = New System.Drawing.Size(101, 20)
        Me.optValorizado.TabIndex = 1
        Me.optValorizado.Text = "Valorizado"
        Me.optValorizado.UseVisualStyleBackColor = True
        '
        'optCantidades
        '
        Me.optCantidades.AutoSize = True
        Me.optCantidades.Checked = True
        Me.optCantidades.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optCantidades.ForeColor = System.Drawing.Color.Black
        Me.optCantidades.Location = New System.Drawing.Point(13, 15)
        Me.optCantidades.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.optCantidades.Name = "optCantidades"
        Me.optCantidades.Size = New System.Drawing.Size(108, 20)
        Me.optCantidades.TabIndex = 0
        Me.optCantidades.TabStop = True
        Me.optCantidades.Text = "Cantidades"
        Me.optCantidades.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.White
        Me.GroupBox7.Controls.Add(Me.optingresos)
        Me.GroupBox7.Controls.Add(Me.optsalidas)
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.ForeColor = System.Drawing.Color.Black
        Me.GroupBox7.Location = New System.Drawing.Point(1051, -9)
        Me.GroupBox7.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox7.Size = New System.Drawing.Size(219, 44)
        Me.GroupBox7.TabIndex = 143
        Me.GroupBox7.TabStop = False
        '
        'optingresos
        '
        Me.optingresos.AutoSize = True
        Me.optingresos.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optingresos.ForeColor = System.Drawing.Color.Black
        Me.optingresos.Location = New System.Drawing.Point(113, 15)
        Me.optingresos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.optingresos.Name = "optingresos"
        Me.optingresos.Size = New System.Drawing.Size(91, 20)
        Me.optingresos.TabIndex = 1
        Me.optingresos.Text = "Ingresos"
        Me.optingresos.UseVisualStyleBackColor = True
        '
        'optsalidas
        '
        Me.optsalidas.AutoSize = True
        Me.optsalidas.Checked = True
        Me.optsalidas.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optsalidas.ForeColor = System.Drawing.Color.Black
        Me.optsalidas.Location = New System.Drawing.Point(13, 15)
        Me.optsalidas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.optsalidas.Name = "optsalidas"
        Me.optsalidas.Size = New System.Drawing.Size(79, 20)
        Me.optsalidas.TabIndex = 0
        Me.optsalidas.TabStop = True
        Me.optsalidas.Text = "Salidas"
        Me.optsalidas.UseVisualStyleBackColor = True
        '
        'dataResumen
        '
        Me.dataResumen.AllowUserToAddRows = False
        Me.dataResumen.AllowUserToDeleteRows = False
        Me.dataResumen.AllowUserToResizeColumns = False
        Me.dataResumen.AllowUserToResizeRows = False
        Me.dataResumen.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dataResumen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataResumen.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dataResumen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataResumen.DefaultCellStyle = DataGridViewCellStyle5
        Me.dataResumen.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dataResumen.EnableHeadersVisualStyles = False
        Me.dataResumen.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dataResumen.Location = New System.Drawing.Point(1, 44)
        Me.dataResumen.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dataResumen.Name = "dataResumen"
        Me.dataResumen.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataResumen.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dataResumen.RowHeadersVisible = False
        Me.dataResumen.SelectAllSignVisible = False
        Me.dataResumen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataResumen.ShowEditingIcon = False
        Me.dataResumen.Size = New System.Drawing.Size(1299, 495)
        Me.dataResumen.TabIndex = 6
        '
        'tabResumen
        '
        Me.tabResumen.AttachedControl = Me.TabControlPanel5
        Me.tabResumen.Icon = CType(resources.GetObject("tabResumen.Icon"), System.Drawing.Icon)
        Me.tabResumen.Name = "tabResumen"
        Me.tabResumen.Text = "Resumen Mensual de Ventas"
        '
        'TabControlPanel1
        '
        Me.TabControlPanel1.Controls.Add(Me.GroupBox4)
        Me.TabControlPanel1.Controls.Add(Me.chkVenta)
        Me.TabControlPanel1.Controls.Add(Me.GroupBox3)
        Me.TabControlPanel1.Controls.Add(Me.dataIngMenu)
        Me.TabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel1.Location = New System.Drawing.Point(0, 26)
        Me.TabControlPanel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabControlPanel1.Name = "TabControlPanel1"
        Me.TabControlPanel1.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel1.Size = New System.Drawing.Size(1301, 540)
        Me.TabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.White
        Me.TabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.TabControlPanel1.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel1.Style.GradientAngle = 90
        Me.TabControlPanel1.TabIndex = 3
        Me.TabControlPanel1.TabItem = Me.TabIngMenu
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.White
        Me.GroupBox4.Controls.Add(Me.optmontoventa)
        Me.GroupBox4.Controls.Add(Me.optcantventa)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Black
        Me.GroupBox4.Location = New System.Drawing.Point(907, -7)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox4.Size = New System.Drawing.Size(225, 44)
        Me.GroupBox4.TabIndex = 145
        Me.GroupBox4.TabStop = False
        '
        'optmontoventa
        '
        Me.optmontoventa.AutoSize = True
        Me.optmontoventa.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optmontoventa.ForeColor = System.Drawing.Color.Black
        Me.optmontoventa.Location = New System.Drawing.Point(125, 15)
        Me.optmontoventa.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.optmontoventa.Name = "optmontoventa"
        Me.optmontoventa.Size = New System.Drawing.Size(82, 20)
        Me.optmontoventa.TabIndex = 1
        Me.optmontoventa.Text = "Montos"
        Me.optmontoventa.UseVisualStyleBackColor = True
        '
        'optcantventa
        '
        Me.optcantventa.AutoSize = True
        Me.optcantventa.Checked = True
        Me.optcantventa.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optcantventa.ForeColor = System.Drawing.Color.Black
        Me.optcantventa.Location = New System.Drawing.Point(13, 15)
        Me.optcantventa.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.optcantventa.Name = "optcantventa"
        Me.optcantventa.Size = New System.Drawing.Size(108, 20)
        Me.optcantventa.TabIndex = 0
        Me.optcantventa.TabStop = True
        Me.optcantventa.Text = "Cantidades"
        Me.optcantventa.UseVisualStyleBackColor = True
        '
        'chkVenta
        '
        Me.chkVenta.AutoSize = True
        '
        '
        '
        Me.chkVenta.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chkVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkVenta.Location = New System.Drawing.Point(1140, 7)
        Me.chkVenta.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkVenta.Name = "chkVenta"
        Me.chkVenta.Size = New System.Drawing.Size(133, 18)
        Me.chkVenta.TabIndex = 144
        Me.chkVenta.TabStop = False
        Me.chkVenta.Text = "x Grupo de Venta"
        Me.chkVenta.TextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.optmes)
        Me.GroupBox3.Controls.Add(Me.optdia)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(5, -7)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(225, 44)
        Me.GroupBox3.TabIndex = 143
        Me.GroupBox3.TabStop = False
        '
        'optmes
        '
        Me.optmes.AutoSize = True
        Me.optmes.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optmes.ForeColor = System.Drawing.Color.Black
        Me.optmes.Location = New System.Drawing.Point(103, 15)
        Me.optmes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.optmes.Name = "optmes"
        Me.optmes.Size = New System.Drawing.Size(89, 20)
        Me.optmes.TabIndex = 1
        Me.optmes.Text = "Mensual"
        Me.optmes.UseVisualStyleBackColor = True
        '
        'optdia
        '
        Me.optdia.AutoSize = True
        Me.optdia.Checked = True
        Me.optdia.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optdia.ForeColor = System.Drawing.Color.Black
        Me.optdia.Location = New System.Drawing.Point(13, 15)
        Me.optdia.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.optdia.Name = "optdia"
        Me.optdia.Size = New System.Drawing.Size(70, 20)
        Me.optdia.TabIndex = 0
        Me.optdia.TabStop = True
        Me.optdia.Text = "Diario"
        Me.optdia.UseVisualStyleBackColor = True
        '
        'dataIngMenu
        '
        Me.dataIngMenu.AllowUserToAddRows = False
        Me.dataIngMenu.AllowUserToDeleteRows = False
        Me.dataIngMenu.AllowUserToResizeColumns = False
        Me.dataIngMenu.AllowUserToResizeRows = False
        Me.dataIngMenu.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dataIngMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataIngMenu.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dataIngMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataIngMenu.DefaultCellStyle = DataGridViewCellStyle8
        Me.dataIngMenu.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dataIngMenu.EnableHeadersVisualStyles = False
        Me.dataIngMenu.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dataIngMenu.Location = New System.Drawing.Point(1, 44)
        Me.dataIngMenu.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dataIngMenu.Name = "dataIngMenu"
        Me.dataIngMenu.ReadOnly = True
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataIngMenu.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dataIngMenu.RowHeadersVisible = False
        Me.dataIngMenu.SelectAllSignVisible = False
        Me.dataIngMenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataIngMenu.ShowEditingIcon = False
        Me.dataIngMenu.Size = New System.Drawing.Size(1299, 495)
        Me.dataIngMenu.TabIndex = 7
        '
        'TabIngMenu
        '
        Me.TabIngMenu.AttachedControl = Me.TabControlPanel1
        Me.TabIngMenu.Icon = CType(resources.GetObject("TabIngMenu.Icon"), System.Drawing.Icon)
        Me.TabIngMenu.Name = "TabIngMenu"
        Me.TabIngMenu.Text = "Ingenieria del Menu"
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.PictureBox1)
        Me.GroupBox9.Controls.Add(Me.TxtBuscar2)
        Me.GroupBox9.Controls.Add(Me.LabelX4)
        Me.GroupBox9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox9.Location = New System.Drawing.Point(357, 114)
        Me.GroupBox9.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox9.Size = New System.Drawing.Size(352, 44)
        Me.GroupBox9.TabIndex = 151
        Me.GroupBox9.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.cefe.My.Resources.Resources.buscar18
        Me.PictureBox1.Location = New System.Drawing.Point(313, 15)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(18, 18)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 136
        Me.PictureBox1.TabStop = False
        '
        'TxtBuscar2
        '
        Me.TxtBuscar2.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.TxtBuscar2.Border.Class = "TextBoxBorder"
        Me.TxtBuscar2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtBuscar2.FocusHighlightEnabled = True
        Me.TxtBuscar2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBuscar2.Location = New System.Drawing.Point(84, 12)
        Me.TxtBuscar2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtBuscar2.Name = "TxtBuscar2"
        Me.TxtBuscar2.Size = New System.Drawing.Size(228, 24)
        Me.TxtBuscar2.TabIndex = 135
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
        Me.LabelX4.Location = New System.Drawing.Point(13, 16)
        Me.LabelX4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(47, 18)
        Me.LabelX4.TabIndex = 132
        Me.LabelX4.Text = "Buscar"
        Me.LabelX4.TextAlignment = System.Drawing.StringAlignment.Center
        Me.LabelX4.WordWrap = True
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX1.Image = Global.cefe.My.Resources.Resources.tr_024
        Me.ButtonX1.Location = New System.Drawing.Point(1171, 105)
        Me.ButtonX1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.ButtonX1.Size = New System.Drawing.Size(123, 44)
        Me.ButtonX1.TabIndex = 152
        Me.ButtonX1.Text = "Procesar"
        '
        'chkProduccion
        '
        Me.chkProduccion.AutoSize = True
        '
        '
        '
        Me.chkProduccion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chkProduccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkProduccion.Location = New System.Drawing.Point(641, 81)
        Me.chkProduccion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkProduccion.Name = "chkProduccion"
        Me.chkProduccion.Size = New System.Drawing.Size(76, 18)
        Me.chkProduccion.TabIndex = 153
        Me.chkProduccion.Text = "Insumos"
        '
        'repVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(1301, 732)
        Me.Controls.Add(Me.chkProduccion)
        Me.Controls.Add(Me.TabControl2)
        Me.Controls.Add(Me.ButtonX1)
        Me.Controls.Add(Me.lblRegistros)
        Me.Controls.Add(Me.GroupBox9)
        Me.Controls.Add(Me.chkDia)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.grupoAlmacen)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.cmdCerrar)
        Me.Controls.Add(Me.cmdImprimir)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "repVentas"
        Me.Text = "Consulta y Reporte: SALIDAS"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dataDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.dtiHasta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtiDesde, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel1.ResumeLayout(False)
        Me.grupoAlmacen.ResumeLayout(False)
        Me.grupoAlmacen.PerformLayout()
        CType(Me.TabControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl2.ResumeLayout(False)
        Me.TabControlPanel4.ResumeLayout(False)
        Me.TabControlPanel4.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlPanel5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.dataResumen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlPanel1.ResumeLayout(False)
        Me.TabControlPanel1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dataIngMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents optRegistro As System.Windows.Forms.RadioButton
    Friend WithEvents optProducto As System.Windows.Forms.RadioButton
    Friend WithEvents optCliente As System.Windows.Forms.RadioButton
    Friend WithEvents optProducciones As System.Windows.Forms.RadioButton
    Friend WithEvents cmdImprimir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmdCerrar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents dataDetalle As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkDia As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents dtiHasta As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents dtiDesde As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents cboAnno As System.Windows.Forms.ComboBox
    Friend WithEvents cboMes As System.Windows.Forms.ComboBox
    Friend WithEvents grupoAlmacen As System.Windows.Forms.GroupBox
    Friend WithEvents chkAlmacen As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents optDocumento As System.Windows.Forms.RadioButton
    Friend WithEvents lblRegistros As DevComponents.DotNetBar.LabelX
    Friend WithEvents TabControl2 As DevComponents.DotNetBar.TabControl
    Friend WithEvents TabControlPanel4 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents tabDetalle As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabControlPanel5 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents optValorizado As System.Windows.Forms.RadioButton
    Friend WithEvents optCantidades As System.Windows.Forms.RadioButton
    Friend WithEvents dataResumen As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents tabResumen As DevComponents.DotNetBar.TabItem
    Friend WithEvents cboAlmacen As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cboGrupo As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TxtBuscar2 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents optPedido As System.Windows.Forms.RadioButton
    Friend WithEvents chkfiltro As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TabControlPanel1 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents dataIngMenu As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents TabIngMenu As DevComponents.DotNetBar.TabItem
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents optmes As System.Windows.Forms.RadioButton
    Friend WithEvents optdia As System.Windows.Forms.RadioButton
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents lblMontoDS As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblMonedaDS As DevComponents.DotNetBar.LabelX
    Friend WithEvents chkVenta As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents optmontoventa As System.Windows.Forms.RadioButton
    Friend WithEvents optcantventa As System.Windows.Forms.RadioButton
    Friend WithEvents cboUnidad As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents chkUnidad As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents optingresos As System.Windows.Forms.RadioButton
    Friend WithEvents optsalidas As System.Windows.Forms.RadioButton
    Friend WithEvents chkProduccion As DevComponents.DotNetBar.Controls.CheckBoxX

End Class
