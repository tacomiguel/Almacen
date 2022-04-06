<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class c_ventas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(c_ventas))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.chkGrupo = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.chkAlmacen = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.grupoAlmacen = New System.Windows.Forms.GroupBox()
        Me.cboAlmacen = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.chkTotalizado = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.grupo = New System.Windows.Forms.GroupBox()
        Me.cboGrupo = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.chkDetalle = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.chkDia = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.dtiHasta = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.dtiDesde = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.optVentasInsumo = New System.Windows.Forms.RadioButton()
        Me.optVentasProducto = New System.Windows.Forms.RadioButton()
        Me.optRegistro = New System.Windows.Forms.RadioButton()
        Me.lblRegistros = New DevComponents.DotNetBar.LabelX()
        Me.chkSoloVentas = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.cboAnno = New System.Windows.Forms.ComboBox()
        Me.cboMes = New System.Windows.Forms.ComboBox()
        Me.cmdCerrar = New DevComponents.DotNetBar.ButtonX()
        Me.cmdImprimir = New DevComponents.DotNetBar.ButtonX()
        Me.TabControl2 = New DevComponents.DotNetBar.TabControl()
        Me.TabControlPanel4 = New DevComponents.DotNetBar.TabControlPanel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.lblMontoD = New DevComponents.DotNetBar.LabelX()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.chkIMP = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.lblMonto = New DevComponents.DotNetBar.LabelX()
        Me.lblMoneda = New DevComponents.DotNetBar.LabelX()
        Me.dataDetalle = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.tabSaldos = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel5 = New DevComponents.DotNetBar.TabControlPanel()
        Me.cboAlmacenR = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.lblMensaje = New DevComponents.DotNetBar.LabelX()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.optDescripcion = New System.Windows.Forms.RadioButton()
        Me.optCodigo = New System.Windows.Forms.RadioButton()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txtBuscar = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.barraProgreso = New System.Windows.Forms.ProgressBar()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.optValorizado = New System.Windows.Forms.RadioButton()
        Me.optCantidades = New System.Windows.Forms.RadioButton()
        Me.dataResumen = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.tabResumen = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.grupoAlmacen.SuspendLayout()
        Me.grupo.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.dtiHasta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtiDesde, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        CType(Me.TabControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl2.SuspendLayout()
        Me.TabControlPanel4.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlPanel5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        CType(Me.dataResumen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkGrupo
        '
        Me.chkGrupo.AutoSize = True
        '
        '
        '
        Me.chkGrupo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chkGrupo.Enabled = False
        Me.chkGrupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkGrupo.Location = New System.Drawing.Point(808, 57)
        Me.chkGrupo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkGrupo.Name = "chkGrupo"
        Me.chkGrupo.Size = New System.Drawing.Size(29, 18)
        Me.chkGrupo.TabIndex = 154
        Me.chkGrupo.Text = "x"
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
        Me.chkAlmacen.Location = New System.Drawing.Point(857, 9)
        Me.chkAlmacen.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkAlmacen.Name = "chkAlmacen"
        Me.chkAlmacen.Size = New System.Drawing.Size(87, 18)
        Me.chkAlmacen.TabIndex = 153
        Me.chkAlmacen.Text = "x Almacén"
        '
        'grupoAlmacen
        '
        Me.grupoAlmacen.Controls.Add(Me.cboAlmacen)
        Me.grupoAlmacen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupoAlmacen.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.grupoAlmacen.Location = New System.Drawing.Point(857, 12)
        Me.grupoAlmacen.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grupoAlmacen.Name = "grupoAlmacen"
        Me.grupoAlmacen.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grupoAlmacen.Size = New System.Drawing.Size(333, 52)
        Me.grupoAlmacen.TabIndex = 156
        Me.grupoAlmacen.TabStop = False
        '
        'cboAlmacen
        '
        Me.cboAlmacen.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboAlmacen.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cboAlmacen.DisplayMember = "Text"
        Me.cboAlmacen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboAlmacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAlmacen.FocusHighlightColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.cboAlmacen.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAlmacen.ItemHeight = 15
        Me.cboAlmacen.Location = New System.Drawing.Point(12, 18)
        Me.cboAlmacen.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboAlmacen.Name = "cboAlmacen"
        Me.cboAlmacen.Size = New System.Drawing.Size(312, 21)
        Me.cboAlmacen.TabIndex = 12
        '
        'chkTotalizado
        '
        Me.chkTotalizado.AutoSize = True
        '
        '
        '
        Me.chkTotalizado.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chkTotalizado.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTotalizado.Location = New System.Drawing.Point(667, 73)
        Me.chkTotalizado.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkTotalizado.Name = "chkTotalizado"
        Me.chkTotalizado.Size = New System.Drawing.Size(90, 18)
        Me.chkTotalizado.TabIndex = 168
        Me.chkTotalizado.Text = "Totalizado"
        Me.chkTotalizado.TextColor = System.Drawing.Color.Maroon
        '
        'grupo
        '
        Me.grupo.Controls.Add(Me.cboGrupo)
        Me.grupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupo.ForeColor = System.Drawing.Color.Maroon
        Me.grupo.Location = New System.Drawing.Point(808, 59)
        Me.grupo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grupo.Name = "grupo"
        Me.grupo.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grupo.Size = New System.Drawing.Size(384, 52)
        Me.grupo.TabIndex = 150
        Me.grupo.TabStop = False
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
        Me.cboGrupo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGrupo.ItemHeight = 15
        Me.cboGrupo.Location = New System.Drawing.Point(11, 17)
        Me.cboGrupo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboGrupo.Name = "cboGrupo"
        Me.cboGrupo.Size = New System.Drawing.Size(364, 21)
        Me.cboGrupo.TabIndex = 12
        '
        'chkDetalle
        '
        Me.chkDetalle.AutoSize = True
        '
        '
        '
        Me.chkDetalle.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chkDetalle.Checked = True
        Me.chkDetalle.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDetalle.CheckValue = "Y"
        Me.chkDetalle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDetalle.Location = New System.Drawing.Point(667, 48)
        Me.chkDetalle.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkDetalle.Name = "chkDetalle"
        Me.chkDetalle.Size = New System.Drawing.Size(84, 18)
        Me.chkDetalle.TabIndex = 162
        Me.chkDetalle.Text = "Detallado"
        Me.chkDetalle.TextColor = System.Drawing.Color.Maroon
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
        Me.chkDia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDia.Location = New System.Drawing.Point(273, 6)
        Me.chkDia.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkDia.Name = "chkDia"
        Me.chkDia.Size = New System.Drawing.Size(134, 18)
        Me.chkDia.TabIndex = 158
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
        Me.GroupBox5.Location = New System.Drawing.Point(264, 10)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox5.Size = New System.Drawing.Size(180, 91)
        Me.GroupBox5.TabIndex = 159
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
        Me.dtiHasta.Location = New System.Drawing.Point(59, 57)
        Me.dtiHasta.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
        Me.dtiHasta.Size = New System.Drawing.Size(111, 23)
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
        Me.dtiDesde.Location = New System.Drawing.Point(59, 23)
        Me.dtiDesde.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
        Me.dtiDesde.Size = New System.Drawing.Size(111, 23)
        Me.dtiDesde.TabIndex = 119
        '
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.ForeColor = System.Drawing.Color.Black
        Me.LabelX1.Location = New System.Drawing.Point(11, 26)
        Me.LabelX1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(42, 18)
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
        Me.LabelX2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.ForeColor = System.Drawing.Color.Black
        Me.LabelX2.Location = New System.Drawing.Point(13, 59)
        Me.LabelX2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(38, 18)
        Me.LabelX2.TabIndex = 117
        Me.LabelX2.Text = "hasta"
        Me.LabelX2.TextAlignment = System.Drawing.StringAlignment.Center
        Me.LabelX2.WordWrap = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.optVentasInsumo)
        Me.GroupBox2.Controls.Add(Me.optVentasProducto)
        Me.GroupBox2.Controls.Add(Me.optRegistro)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(448, 7)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(211, 94)
        Me.GroupBox2.TabIndex = 149
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tipo de Reporte"
        '
        'optVentasInsumo
        '
        Me.optVentasInsumo.AutoSize = True
        Me.optVentasInsumo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optVentasInsumo.ForeColor = System.Drawing.Color.Black
        Me.optVentasInsumo.Location = New System.Drawing.Point(11, 66)
        Me.optVentasInsumo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.optVentasInsumo.Name = "optVentasInsumo"
        Me.optVentasInsumo.Size = New System.Drawing.Size(143, 20)
        Me.optVentasInsumo.TabIndex = 4
        Me.optVentasInsumo.Text = "Ventas x Insumo"
        Me.optVentasInsumo.UseVisualStyleBackColor = True
        '
        'optVentasProducto
        '
        Me.optVentasProducto.AutoSize = True
        Me.optVentasProducto.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optVentasProducto.ForeColor = System.Drawing.Color.Black
        Me.optVentasProducto.Location = New System.Drawing.Point(11, 42)
        Me.optVentasProducto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.optVentasProducto.Name = "optVentasProducto"
        Me.optVentasProducto.Size = New System.Drawing.Size(156, 20)
        Me.optVentasProducto.TabIndex = 2
        Me.optVentasProducto.Text = "Ventas x Producto"
        Me.optVentasProducto.UseVisualStyleBackColor = True
        '
        'optRegistro
        '
        Me.optRegistro.AutoSize = True
        Me.optRegistro.Checked = True
        Me.optRegistro.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optRegistro.ForeColor = System.Drawing.Color.Black
        Me.optRegistro.Location = New System.Drawing.Point(11, 18)
        Me.optRegistro.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.optRegistro.Name = "optRegistro"
        Me.optRegistro.Size = New System.Drawing.Size(162, 20)
        Me.optRegistro.TabIndex = 0
        Me.optRegistro.TabStop = True
        Me.optRegistro.Text = "Registro de Ventas"
        Me.optRegistro.UseVisualStyleBackColor = True
        '
        'lblRegistros
        '
        '
        '
        '
        Me.lblRegistros.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblRegistros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistros.ForeColor = System.Drawing.Color.Green
        Me.lblRegistros.Location = New System.Drawing.Point(11, 75)
        Me.lblRegistros.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblRegistros.Name = "lblRegistros"
        Me.lblRegistros.Size = New System.Drawing.Size(241, 23)
        Me.lblRegistros.TabIndex = 160
        Me.lblRegistros.Text = "Nº de Registros... "
        Me.lblRegistros.TextAlignment = System.Drawing.StringAlignment.Center
        Me.lblRegistros.WordWrap = True
        '
        'chkSoloVentas
        '
        Me.chkSoloVentas.AutoSize = True
        '
        '
        '
        Me.chkSoloVentas.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chkSoloVentas.Checked = True
        Me.chkSoloVentas.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSoloVentas.CheckValue = "Y"
        Me.chkSoloVentas.Enabled = False
        Me.chkSoloVentas.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSoloVentas.Location = New System.Drawing.Point(667, 22)
        Me.chkSoloVentas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkSoloVentas.Name = "chkSoloVentas"
        Me.chkSoloVentas.Size = New System.Drawing.Size(155, 18)
        Me.chkSoloVentas.TabIndex = 163
        Me.chkSoloVentas.Text = "Mostrar Solo Ventas"
        Me.chkSoloVentas.TextColor = System.Drawing.Color.Maroon
        '
        'GroupBox3
        '
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(-21, 127)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(1412, 12)
        Me.GroupBox3.TabIndex = 155
        Me.GroupBox3.TabStop = False
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.cboAnno)
        Me.GroupPanel1.Controls.Add(Me.cboMes)
        Me.GroupPanel1.Location = New System.Drawing.Point(11, 10)
        Me.GroupPanel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(245, 62)
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
        Me.GroupPanel1.TabIndex = 157
        Me.GroupPanel1.Text = "Periodo de Reporte"
        '
        'cboAnno
        '
        Me.cboAnno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAnno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAnno.FormattingEnabled = True
        Me.cboAnno.Items.AddRange(New Object() {"2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025"})
        Me.cboAnno.Location = New System.Drawing.Point(145, 6)
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
        'cmdCerrar
        '
        Me.cmdCerrar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdCerrar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCerrar.Image = Global.cefe.My.Resources.Resources.CLOSE22
        Me.cmdCerrar.Location = New System.Drawing.Point(1209, 14)
        Me.cmdCerrar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdCerrar.Name = "cmdCerrar"
        Me.cmdCerrar.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.cmdCerrar.Size = New System.Drawing.Size(107, 44)
        Me.cmdCerrar.TabIndex = 152
        Me.cmdCerrar.Text = "Cerrar"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdImprimir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdImprimir.Image = Global.cefe.My.Resources.Resources.print_preview
        Me.cmdImprimir.Location = New System.Drawing.Point(1211, 66)
        Me.cmdImprimir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.cmdImprimir.Size = New System.Drawing.Size(107, 44)
        Me.cmdImprimir.TabIndex = 151
        Me.cmdImprimir.Text = "Imprimir"
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
        Me.TabControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TabControl2.Location = New System.Drawing.Point(0, 127)
        Me.TabControl2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TabControl2.SelectedTabIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(1329, 550)
        Me.TabControl2.Style = DevComponents.DotNetBar.eTabStripStyle.VS2005Document
        Me.TabControl2.TabIndex = 169
        Me.TabControl2.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
        Me.TabControl2.Tabs.Add(Me.tabSaldos)
        Me.TabControl2.Tabs.Add(Me.tabResumen)
        Me.TabControl2.Text = "Precio de Costo Vs. Precio de Venta"
        '
        'TabControlPanel4
        '
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
        Me.TabControlPanel4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabControlPanel4.Name = "TabControlPanel4"
        Me.TabControlPanel4.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel4.Size = New System.Drawing.Size(1329, 524)
        Me.TabControlPanel4.Style.BackColor1.Color = System.Drawing.Color.White
        Me.TabControlPanel4.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabControlPanel4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel4.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.TabControlPanel4.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel4.Style.GradientAngle = 90
        Me.TabControlPanel4.TabIndex = 1
        Me.TabControlPanel4.TabItem = Me.tabSaldos
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.cefe.My.Resources.Resources.continuar16
        Me.PictureBox4.Location = New System.Drawing.Point(904, 484)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
        Me.lblMontoD.Location = New System.Drawing.Point(931, 484)
        Me.lblMontoD.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblMontoD.Name = "lblMontoD"
        Me.lblMontoD.Size = New System.Drawing.Size(52, 18)
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
        Me.LabelX8.Location = New System.Drawing.Point(844, 484)
        Me.LabelX8.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(56, 18)
        Me.LabelX8.TabIndex = 137
        Me.LabelX8.Text = "Dolares"
        Me.LabelX8.TextAlignment = System.Drawing.StringAlignment.Far
        Me.LabelX8.WordWrap = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.cefe.My.Resources.Resources.continuar16
        Me.PictureBox1.Location = New System.Drawing.Point(285, 484)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 136
        Me.PictureBox1.TabStop = False
        '
        'chkIMP
        '
        Me.chkIMP.AutoSize = True
        '
        '
        '
        Me.chkIMP.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chkIMP.Checked = True
        Me.chkIMP.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkIMP.CheckValue = "Y"
        Me.chkIMP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkIMP.Location = New System.Drawing.Point(5, 484)
        Me.chkIMP.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkIMP.Name = "chkIMP"
        Me.chkIMP.Size = New System.Drawing.Size(163, 18)
        Me.chkIMP.TabIndex = 135
        Me.chkIMP.Text = "Precios CON Impuesto"
        Me.chkIMP.TextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
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
        Me.lblMonto.Location = New System.Drawing.Point(312, 484)
        Me.lblMonto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Size = New System.Drawing.Size(52, 18)
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
        Me.lblMoneda.Location = New System.Drawing.Point(225, 484)
        Me.lblMoneda.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblMoneda.Name = "lblMoneda"
        Me.lblMoneda.Size = New System.Drawing.Size(56, 18)
        Me.lblMoneda.TabIndex = 132
        Me.lblMoneda.Text = "Moneda"
        Me.lblMoneda.TextAlignment = System.Drawing.StringAlignment.Far
        Me.lblMoneda.WordWrap = True
        '
        'dataDetalle
        '
        Me.dataDetalle.AllowUserToAddRows = False
        Me.dataDetalle.AllowUserToDeleteRows = False
        Me.dataDetalle.AllowUserToResizeColumns = False
        Me.dataDetalle.AllowUserToResizeRows = False
        Me.dataDetalle.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dataDetalle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataDetalle.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dataDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataDetalle.DefaultCellStyle = DataGridViewCellStyle2
        Me.dataDetalle.Dock = System.Windows.Forms.DockStyle.Top
        Me.dataDetalle.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dataDetalle.Location = New System.Drawing.Point(1, 1)
        Me.dataDetalle.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dataDetalle.MultiSelect = False
        Me.dataDetalle.Name = "dataDetalle"
        Me.dataDetalle.ReadOnly = True
        Me.dataDetalle.RowHeadersVisible = False
        Me.dataDetalle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dataDetalle.SelectAllSignVisible = False
        Me.dataDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dataDetalle.ShowEditingIcon = False
        Me.dataDetalle.Size = New System.Drawing.Size(1327, 479)
        Me.dataDetalle.TabIndex = 52
        '
        'tabSaldos
        '
        Me.tabSaldos.AttachedControl = Me.TabControlPanel4
        Me.tabSaldos.Icon = CType(resources.GetObject("tabSaldos.Icon"), System.Drawing.Icon)
        Me.tabSaldos.Name = "tabSaldos"
        Me.tabSaldos.Text = "Ventas"
        '
        'TabControlPanel5
        '
        Me.TabControlPanel5.Controls.Add(Me.cboAlmacenR)
        Me.TabControlPanel5.Controls.Add(Me.lblMensaje)
        Me.TabControlPanel5.Controls.Add(Me.GroupBox1)
        Me.TabControlPanel5.Controls.Add(Me.PictureBox2)
        Me.TabControlPanel5.Controls.Add(Me.txtBuscar)
        Me.TabControlPanel5.Controls.Add(Me.LabelX3)
        Me.TabControlPanel5.Controls.Add(Me.barraProgreso)
        Me.TabControlPanel5.Controls.Add(Me.GroupBox6)
        Me.TabControlPanel5.Controls.Add(Me.dataResumen)
        Me.TabControlPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel5.Location = New System.Drawing.Point(0, 26)
        Me.TabControlPanel5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabControlPanel5.Name = "TabControlPanel5"
        Me.TabControlPanel5.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel5.Size = New System.Drawing.Size(1329, 524)
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
        'cboAlmacenR
        '
        Me.cboAlmacenR.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboAlmacenR.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cboAlmacenR.DisplayMember = "Text"
        Me.cboAlmacenR.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboAlmacenR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAlmacenR.Enabled = False
        Me.cboAlmacenR.FocusHighlightColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.cboAlmacenR.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAlmacenR.ItemHeight = 15
        Me.cboAlmacenR.Location = New System.Drawing.Point(8, 7)
        Me.cboAlmacenR.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboAlmacenR.Name = "cboAlmacenR"
        Me.cboAlmacenR.Size = New System.Drawing.Size(244, 21)
        Me.cboAlmacenR.TabIndex = 149
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
        Me.lblMensaje.Location = New System.Drawing.Point(1085, 6)
        Me.lblMensaje.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(293, 27)
        Me.lblMensaje.TabIndex = 148
        Me.lblMensaje.Text = "Mensaje"
        Me.lblMensaje.TextAlignment = System.Drawing.StringAlignment.Far
        Me.lblMensaje.Visible = False
        Me.lblMensaje.WordWrap = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.optDescripcion)
        Me.GroupBox1.Controls.Add(Me.optCodigo)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(615, -6)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(225, 44)
        Me.GroupBox1.TabIndex = 144
        Me.GroupBox1.TabStop = False
        '
        'optDescripcion
        '
        Me.optDescripcion.AutoSize = True
        Me.optDescripcion.Checked = True
        Me.optDescripcion.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optDescripcion.ForeColor = System.Drawing.Color.Black
        Me.optDescripcion.Location = New System.Drawing.Point(100, 14)
        Me.optDescripcion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.optDescripcion.Name = "optDescripcion"
        Me.optDescripcion.Size = New System.Drawing.Size(113, 20)
        Me.optDescripcion.TabIndex = 1
        Me.optDescripcion.TabStop = True
        Me.optDescripcion.Text = "Descripción"
        Me.optDescripcion.UseVisualStyleBackColor = True
        '
        'optCodigo
        '
        Me.optCodigo.AutoSize = True
        Me.optCodigo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optCodigo.ForeColor = System.Drawing.Color.Black
        Me.optCodigo.Location = New System.Drawing.Point(12, 14)
        Me.optCodigo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.optCodigo.Name = "optCodigo"
        Me.optCodigo.Size = New System.Drawing.Size(79, 20)
        Me.optCodigo.TabIndex = 0
        Me.optCodigo.Text = "Código"
        Me.optCodigo.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.Image = Global.cefe.My.Resources.Resources.buscar20
        Me.PictureBox2.Location = New System.Drawing.Point(1044, 6)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 146
        Me.PictureBox2.TabStop = False
        '
        'txtBuscar
        '
        '
        '
        '
        Me.txtBuscar.Border.Class = "TextBoxBorder"
        Me.txtBuscar.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtBuscar.FocusHighlightEnabled = True
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(844, 6)
        Me.txtBuscar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(196, 24)
        Me.txtBuscar.TabIndex = 145
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
        Me.LabelX3.Location = New System.Drawing.Point(543, 9)
        Me.LabelX3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(63, 19)
        Me.LabelX3.TabIndex = 147
        Me.LabelX3.Text = "Buscar x"
        Me.LabelX3.TextAlignment = System.Drawing.StringAlignment.Center
        Me.LabelX3.WordWrap = True
        '
        'barraProgreso
        '
        Me.barraProgreso.Location = New System.Drawing.Point(1107, 7)
        Me.barraProgreso.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.barraProgreso.Name = "barraProgreso"
        Me.barraProgreso.Size = New System.Drawing.Size(279, 26)
        Me.barraProgreso.TabIndex = 143
        Me.barraProgreso.Visible = False
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.White
        Me.GroupBox6.Controls.Add(Me.optValorizado)
        Me.GroupBox6.Controls.Add(Me.optCantidades)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.Color.Black
        Me.GroupBox6.Location = New System.Drawing.Point(261, -6)
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
        Me.optCantidades.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optCantidades.ForeColor = System.Drawing.Color.Black
        Me.optCantidades.Location = New System.Drawing.Point(13, 15)
        Me.optCantidades.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.optCantidades.Name = "optCantidades"
        Me.optCantidades.Size = New System.Drawing.Size(108, 20)
        Me.optCantidades.TabIndex = 0
        Me.optCantidades.Text = "Cantidades"
        Me.optCantidades.UseVisualStyleBackColor = True
        '
        'dataResumen
        '
        Me.dataResumen.AllowUserToAddRows = False
        Me.dataResumen.AllowUserToDeleteRows = False
        Me.dataResumen.AllowUserToResizeColumns = False
        Me.dataResumen.AllowUserToResizeRows = False
        Me.dataResumen.BackgroundColor = System.Drawing.Color.White
        Me.dataResumen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataResumen.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dataResumen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataResumen.DefaultCellStyle = DataGridViewCellStyle4
        Me.dataResumen.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dataResumen.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dataResumen.Location = New System.Drawing.Point(1, 61)
        Me.dataResumen.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dataResumen.MultiSelect = False
        Me.dataResumen.Name = "dataResumen"
        Me.dataResumen.ReadOnly = True
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataResumen.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dataResumen.RowHeadersVisible = False
        Me.dataResumen.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dataResumen.SelectAllSignVisible = False
        Me.dataResumen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataResumen.ShowEditingIcon = False
        Me.dataResumen.Size = New System.Drawing.Size(1327, 462)
        Me.dataResumen.TabIndex = 6
        '
        'tabResumen
        '
        Me.tabResumen.AttachedControl = Me.TabControlPanel5
        Me.tabResumen.Icon = CType(resources.GetObject("tabResumen.Icon"), System.Drawing.Icon)
        Me.tabResumen.Name = "tabResumen"
        Me.tabResumen.Text = "Resumen Anual de Ventas"
        '
        'c_ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(1329, 677)
        Me.Controls.Add(Me.TabControl2)
        Me.Controls.Add(Me.chkGrupo)
        Me.Controls.Add(Me.chkAlmacen)
        Me.Controls.Add(Me.grupoAlmacen)
        Me.Controls.Add(Me.chkTotalizado)
        Me.Controls.Add(Me.grupo)
        Me.Controls.Add(Me.chkDetalle)
        Me.Controls.Add(Me.chkDia)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lblRegistros)
        Me.Controls.Add(Me.chkSoloVentas)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Controls.Add(Me.cmdCerrar)
        Me.Controls.Add(Me.cmdImprimir)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "c_ventas"
        Me.Text = "Consulta y Reporte: VENTAS DEL RESTAURANTE"
        Me.grupoAlmacen.ResumeLayout(False)
        Me.grupo.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.dtiHasta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtiDesde, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupPanel1.ResumeLayout(False)
        CType(Me.TabControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl2.ResumeLayout(False)
        Me.TabControlPanel4.ResumeLayout(False)
        Me.TabControlPanel4.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlPanel5.ResumeLayout(False)
        Me.TabControlPanel5.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.dataResumen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkGrupo As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chkAlmacen As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents grupoAlmacen As System.Windows.Forms.GroupBox
    Friend WithEvents cboAlmacen As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents chkTotalizado As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents grupo As System.Windows.Forms.GroupBox
    Friend WithEvents cboGrupo As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents chkDetalle As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chkDia As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents dtiHasta As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents dtiDesde As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents optVentasInsumo As System.Windows.Forms.RadioButton
    Friend WithEvents optVentasProducto As System.Windows.Forms.RadioButton
    Friend WithEvents optRegistro As System.Windows.Forms.RadioButton
    Friend WithEvents lblRegistros As DevComponents.DotNetBar.LabelX
    Friend WithEvents chkSoloVentas As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents cboAnno As System.Windows.Forms.ComboBox
    Friend WithEvents cboMes As System.Windows.Forms.ComboBox
    Friend WithEvents cmdCerrar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmdImprimir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TabControl2 As DevComponents.DotNetBar.TabControl
    Friend WithEvents TabControlPanel4 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents lblMontoD As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents chkIMP As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents lblMonto As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblMoneda As DevComponents.DotNetBar.LabelX
    Friend WithEvents dataDetalle As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents tabSaldos As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabControlPanel5 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents cboAlmacenR As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents lblMensaje As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents optDescripcion As System.Windows.Forms.RadioButton
    Friend WithEvents optCodigo As System.Windows.Forms.RadioButton
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents txtBuscar As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents barraProgreso As System.Windows.Forms.ProgressBar
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents optValorizado As System.Windows.Forms.RadioButton
    Friend WithEvents optCantidades As System.Windows.Forms.RadioButton
    Friend WithEvents dataResumen As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents tabResumen As DevComponents.DotNetBar.TabItem

End Class
