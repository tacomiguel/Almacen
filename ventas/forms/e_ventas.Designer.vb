<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class e_ventas
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.chkAlmacen = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.cboAlmacen = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.cboAnno = New System.Windows.Forms.ComboBox()
        Me.cboMes = New System.Windows.Forms.ComboBox()
        Me.chkDia = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.dtiHasta = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.dtiDesde = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmdCerrar = New DevComponents.DotNetBar.ButtonX()
        Me.cmdImprimir = New DevComponents.DotNetBar.ButtonX()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.optVentasGrupo = New System.Windows.Forms.RadioButton()
        Me.optDemandaImporte = New System.Windows.Forms.RadioButton()
        Me.optVentasMensuales = New System.Windows.Forms.RadioButton()
        Me.optVentasDiarias = New System.Windows.Forms.RadioButton()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabProducto = New System.Windows.Forms.TabPage()
        Me.dataDetalle2 = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.dataDetalle = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.TabFecha = New System.Windows.Forms.TabPage()
        Me.optimporte = New System.Windows.Forms.RadioButton()
        Me.optcantidad = New System.Windows.Forms.RadioButton()
        Me.DataDetalle3 = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.TabRanking = New System.Windows.Forms.TabPage()
        Me.opt_menos = New System.Windows.Forms.RadioButton()
        Me.opt_mas = New System.Windows.Forms.RadioButton()
        Me.DataDetalle4 = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.cmdProcesar = New DevComponents.DotNetBar.ButtonX()
        Me.GroupPanel1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.dtiHasta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtiDesde, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabProducto.SuspendLayout()
        CType(Me.dataDetalle2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabFecha.SuspendLayout()
        CType(Me.DataDetalle3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabRanking.SuspendLayout()
        CType(Me.DataDetalle4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkAlmacen
        '
        Me.chkAlmacen.AutoSize = True
        '
        '
        '
        Me.chkAlmacen.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chkAlmacen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAlmacen.Location = New System.Drawing.Point(313, 156)
        Me.chkAlmacen.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkAlmacen.Name = "chkAlmacen"
        Me.chkAlmacen.Size = New System.Drawing.Size(76, 18)
        Me.chkAlmacen.TabIndex = 139
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
        Me.cboAlmacen.Location = New System.Drawing.Point(404, 153)
        Me.cboAlmacen.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboAlmacen.Name = "cboAlmacen"
        Me.cboAlmacen.Size = New System.Drawing.Size(219, 21)
        Me.cboAlmacen.TabIndex = 138
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.cboAnno)
        Me.GroupPanel1.Controls.Add(Me.cboMes)
        Me.GroupPanel1.Location = New System.Drawing.Point(13, 11)
        Me.GroupPanel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(297, 68)
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
        Me.GroupPanel1.TabIndex = 121
        Me.GroupPanel1.Text = "Periodo de Reporte"
        '
        'cboAnno
        '
        Me.cboAnno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAnno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAnno.FormattingEnabled = True
        Me.cboAnno.Items.AddRange(New Object() {"2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025"})
        Me.cboAnno.Location = New System.Drawing.Point(176, 7)
        Me.cboAnno.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboAnno.Name = "cboAnno"
        Me.cboAnno.Size = New System.Drawing.Size(101, 28)
        Me.cboAnno.TabIndex = 1
        '
        'cboMes
        '
        Me.cboMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMes.FormattingEnabled = True
        Me.cboMes.Items.AddRange(New Object() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Setiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.cboMes.Location = New System.Drawing.Point(7, 7)
        Me.cboMes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboMes.Name = "cboMes"
        Me.cboMes.Size = New System.Drawing.Size(151, 28)
        Me.cboMes.TabIndex = 0
        '
        'chkDia
        '
        Me.chkDia.AutoSize = True
        '
        '
        '
        Me.chkDia.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chkDia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDia.Location = New System.Drawing.Point(29, 90)
        Me.chkDia.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkDia.Name = "chkDia"
        Me.chkDia.Size = New System.Drawing.Size(138, 18)
        Me.chkDia.TabIndex = 119
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
        Me.GroupBox5.Location = New System.Drawing.Point(13, 96)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox5.Size = New System.Drawing.Size(297, 92)
        Me.GroupBox5.TabIndex = 120
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
        Me.dtiHasta.Enabled = False
        Me.dtiHasta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.dtiHasta.IsInputReadOnly = True
        Me.dtiHasta.IsPopupCalendarOpen = False
        Me.dtiHasta.Location = New System.Drawing.Point(68, 58)
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
        Me.dtiHasta.Size = New System.Drawing.Size(217, 23)
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
        Me.dtiDesde.Enabled = False
        Me.dtiDesde.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.dtiDesde.IsInputReadOnly = True
        Me.dtiDesde.IsPopupCalendarOpen = False
        Me.dtiDesde.Location = New System.Drawing.Point(68, 26)
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
        Me.dtiDesde.Size = New System.Drawing.Size(217, 23)
        Me.dtiDesde.TabIndex = 119
        '
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.ForeColor = System.Drawing.Color.Black
        Me.LabelX1.Location = New System.Drawing.Point(12, 27)
        Me.LabelX1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(45, 19)
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
        Me.LabelX2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.ForeColor = System.Drawing.Color.Black
        Me.LabelX2.Location = New System.Drawing.Point(16, 59)
        Me.LabelX2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(41, 19)
        Me.LabelX2.TabIndex = 117
        Me.LabelX2.Text = "hasta"
        Me.LabelX2.TextAlignment = System.Drawing.StringAlignment.Center
        Me.LabelX2.WordWrap = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(-19, 175)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(1412, 12)
        Me.GroupBox3.TabIndex = 90
        Me.GroupBox3.TabStop = False
        '
        'cmdCerrar
        '
        Me.cmdCerrar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdCerrar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCerrar.Image = Global.cefe.My.Resources.Resources.CLOSE22
        Me.cmdCerrar.Location = New System.Drawing.Point(1140, 11)
        Me.cmdCerrar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdCerrar.Name = "cmdCerrar"
        Me.cmdCerrar.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8)
        Me.cmdCerrar.Size = New System.Drawing.Size(123, 49)
        Me.cmdCerrar.TabIndex = 87
        Me.cmdCerrar.Text = "Cerrar"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdImprimir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdImprimir.Image = Global.cefe.My.Resources.Resources.print_preview
        Me.cmdImprimir.Location = New System.Drawing.Point(1140, 68)
        Me.cmdImprimir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8)
        Me.cmdImprimir.Size = New System.Drawing.Size(123, 49)
        Me.cmdImprimir.TabIndex = 86
        Me.cmdImprimir.Text = "Imprimir"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.optVentasGrupo)
        Me.GroupBox2.Controls.Add(Me.optDemandaImporte)
        Me.GroupBox2.Controls.Add(Me.optVentasMensuales)
        Me.GroupBox2.Controls.Add(Me.optVentasDiarias)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(319, 11)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(201, 135)
        Me.GroupBox2.TabIndex = 84
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Estadística de Ventas"
        Me.GroupBox2.Visible = False
        '
        'optVentasGrupo
        '
        Me.optVentasGrupo.AutoSize = True
        Me.optVentasGrupo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optVentasGrupo.ForeColor = System.Drawing.Color.Black
        Me.optVentasGrupo.Location = New System.Drawing.Point(16, 71)
        Me.optVentasGrupo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.optVentasGrupo.Name = "optVentasGrupo"
        Me.optVentasGrupo.Size = New System.Drawing.Size(136, 20)
        Me.optVentasGrupo.TabIndex = 3
        Me.optVentasGrupo.Text = "Ventas x Grupo"
        Me.optVentasGrupo.UseVisualStyleBackColor = True
        '
        'optDemandaImporte
        '
        Me.optDemandaImporte.AutoSize = True
        Me.optDemandaImporte.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optDemandaImporte.ForeColor = System.Drawing.Color.Black
        Me.optDemandaImporte.Location = New System.Drawing.Point(16, 97)
        Me.optDemandaImporte.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.optDemandaImporte.Name = "optDemandaImporte"
        Me.optDemandaImporte.Size = New System.Drawing.Size(141, 20)
        Me.optDemandaImporte.TabIndex = 2
        Me.optDemandaImporte.Text = "Mayor Demanda"
        Me.optDemandaImporte.UseVisualStyleBackColor = True
        '
        'optVentasMensuales
        '
        Me.optVentasMensuales.AutoSize = True
        Me.optVentasMensuales.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optVentasMensuales.ForeColor = System.Drawing.Color.Black
        Me.optVentasMensuales.Location = New System.Drawing.Point(16, 46)
        Me.optVentasMensuales.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.optVentasMensuales.Name = "optVentasMensuales"
        Me.optVentasMensuales.Size = New System.Drawing.Size(157, 20)
        Me.optVentasMensuales.TabIndex = 1
        Me.optVentasMensuales.Text = "Ventas Mensuales"
        Me.optVentasMensuales.UseVisualStyleBackColor = True
        '
        'optVentasDiarias
        '
        Me.optVentasDiarias.AutoSize = True
        Me.optVentasDiarias.Checked = True
        Me.optVentasDiarias.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optVentasDiarias.ForeColor = System.Drawing.Color.Black
        Me.optVentasDiarias.Location = New System.Drawing.Point(16, 21)
        Me.optVentasDiarias.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.optVentasDiarias.Name = "optVentasDiarias"
        Me.optVentasDiarias.Size = New System.Drawing.Size(128, 20)
        Me.optVentasDiarias.TabIndex = 0
        Me.optVentasDiarias.TabStop = True
        Me.optVentasDiarias.Text = "Ventas Diarias"
        Me.optVentasDiarias.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabProducto)
        Me.TabControl1.Controls.Add(Me.TabFecha)
        Me.TabControl1.Controls.Add(Me.TabRanking)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(13, 194)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1380, 479)
        Me.TabControl1.TabIndex = 140
        '
        'TabProducto
        '
        Me.TabProducto.Controls.Add(Me.dataDetalle2)
        Me.TabProducto.Controls.Add(Me.dataDetalle)
        Me.TabProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabProducto.ForeColor = System.Drawing.Color.DarkBlue
        Me.TabProducto.Location = New System.Drawing.Point(4, 26)
        Me.TabProducto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabProducto.Name = "TabProducto"
        Me.TabProducto.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabProducto.Size = New System.Drawing.Size(1372, 449)
        Me.TabProducto.TabIndex = 0
        Me.TabProducto.Text = "Ventas x Producto"
        Me.TabProducto.UseVisualStyleBackColor = True
        '
        'dataDetalle2
        '
        Me.dataDetalle2.AllowUserToAddRows = False
        Me.dataDetalle2.AllowUserToDeleteRows = False
        Me.dataDetalle2.AllowUserToResizeColumns = False
        Me.dataDetalle2.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dataDetalle2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dataDetalle2.BackgroundColor = System.Drawing.Color.White
        Me.dataDetalle2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dataDetalle2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkBlue
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DarkBlue
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataDetalle2.DefaultCellStyle = DataGridViewCellStyle2
        Me.dataDetalle2.Dock = System.Windows.Forms.DockStyle.Left
        Me.dataDetalle2.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dataDetalle2.Location = New System.Drawing.Point(401, 4)
        Me.dataDetalle2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dataDetalle2.Name = "dataDetalle2"
        Me.dataDetalle2.ReadOnly = True
        Me.dataDetalle2.RowHeadersVisible = False
        Me.dataDetalle2.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.dataDetalle2.SelectAllSignVisible = False
        Me.dataDetalle2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dataDetalle2.ShowEditingIcon = False
        Me.dataDetalle2.Size = New System.Drawing.Size(1221, 441)
        Me.dataDetalle2.TabIndex = 83
        '
        'dataDetalle
        '
        Me.dataDetalle.AllowUserToAddRows = False
        Me.dataDetalle.AllowUserToDeleteRows = False
        Me.dataDetalle.AllowUserToResizeColumns = False
        Me.dataDetalle.AllowUserToResizeRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dataDetalle.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dataDetalle.BackgroundColor = System.Drawing.Color.White
        Me.dataDetalle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dataDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.DarkBlue
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.DarkBlue
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataDetalle.DefaultCellStyle = DataGridViewCellStyle4
        Me.dataDetalle.Dock = System.Windows.Forms.DockStyle.Left
        Me.dataDetalle.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dataDetalle.Location = New System.Drawing.Point(4, 4)
        Me.dataDetalle.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dataDetalle.MultiSelect = False
        Me.dataDetalle.Name = "dataDetalle"
        Me.dataDetalle.ReadOnly = True
        Me.dataDetalle.RowHeadersVisible = False
        Me.dataDetalle.SelectAllSignVisible = False
        Me.dataDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataDetalle.ShowEditingIcon = False
        Me.dataDetalle.Size = New System.Drawing.Size(397, 441)
        Me.dataDetalle.TabIndex = 82
        '
        'TabFecha
        '
        Me.TabFecha.Controls.Add(Me.optimporte)
        Me.TabFecha.Controls.Add(Me.optcantidad)
        Me.TabFecha.Controls.Add(Me.DataDetalle3)
        Me.TabFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabFecha.ForeColor = System.Drawing.Color.Green
        Me.TabFecha.Location = New System.Drawing.Point(4, 26)
        Me.TabFecha.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabFecha.Name = "TabFecha"
        Me.TabFecha.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabFecha.Size = New System.Drawing.Size(1372, 449)
        Me.TabFecha.TabIndex = 1
        Me.TabFecha.Text = "Ventas x Hora"
        Me.TabFecha.UseVisualStyleBackColor = True
        '
        'optimporte
        '
        Me.optimporte.AutoSize = True
        Me.optimporte.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optimporte.ForeColor = System.Drawing.Color.Black
        Me.optimporte.Location = New System.Drawing.Point(1247, 37)
        Me.optimporte.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.optimporte.Name = "optimporte"
        Me.optimporte.Size = New System.Drawing.Size(87, 20)
        Me.optimporte.TabIndex = 89
        Me.optimporte.Text = " Importe"
        Me.optimporte.UseVisualStyleBackColor = True
        '
        'optcantidad
        '
        Me.optcantidad.AutoSize = True
        Me.optcantidad.Checked = True
        Me.optcantidad.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optcantidad.ForeColor = System.Drawing.Color.Black
        Me.optcantidad.Location = New System.Drawing.Point(1247, 7)
        Me.optcantidad.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.optcantidad.Name = "optcantidad"
        Me.optcantidad.Size = New System.Drawing.Size(91, 20)
        Me.optcantidad.TabIndex = 88
        Me.optcantidad.TabStop = True
        Me.optcantidad.Text = "Cantidad"
        Me.optcantidad.UseVisualStyleBackColor = True
        '
        'DataDetalle3
        '
        Me.DataDetalle3.AllowUserToAddRows = False
        Me.DataDetalle3.AllowUserToDeleteRows = False
        Me.DataDetalle3.AllowUserToResizeColumns = False
        Me.DataDetalle3.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataDetalle3.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DataDetalle3.BackgroundColor = System.Drawing.Color.White
        Me.DataDetalle3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataDetalle3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Green
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Green
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataDetalle3.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataDetalle3.Dock = System.Windows.Forms.DockStyle.Left
        Me.DataDetalle3.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.DataDetalle3.Location = New System.Drawing.Point(4, 4)
        Me.DataDetalle3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataDetalle3.Name = "DataDetalle3"
        Me.DataDetalle3.ReadOnly = True
        Me.DataDetalle3.RowHeadersVisible = False
        Me.DataDetalle3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataDetalle3.SelectAllSignVisible = False
        Me.DataDetalle3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataDetalle3.ShowEditingIcon = False
        Me.DataDetalle3.Size = New System.Drawing.Size(1240, 441)
        Me.DataDetalle3.TabIndex = 84
        '
        'TabRanking
        '
        Me.TabRanking.Controls.Add(Me.opt_menos)
        Me.TabRanking.Controls.Add(Me.opt_mas)
        Me.TabRanking.Controls.Add(Me.DataDetalle4)
        Me.TabRanking.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TabRanking.Location = New System.Drawing.Point(4, 26)
        Me.TabRanking.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabRanking.Name = "TabRanking"
        Me.TabRanking.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabRanking.Size = New System.Drawing.Size(1372, 449)
        Me.TabRanking.TabIndex = 2
        Me.TabRanking.Text = "Ranking Productos"
        Me.TabRanking.UseVisualStyleBackColor = True
        '
        'opt_menos
        '
        Me.opt_menos.AutoSize = True
        Me.opt_menos.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opt_menos.ForeColor = System.Drawing.Color.Black
        Me.opt_menos.Location = New System.Drawing.Point(1244, 37)
        Me.opt_menos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.opt_menos.Name = "opt_menos"
        Me.opt_menos.Size = New System.Drawing.Size(107, 20)
        Me.opt_menos.TabIndex = 87
        Me.opt_menos.Text = "-  Vendidos"
        Me.opt_menos.UseVisualStyleBackColor = True
        '
        'opt_mas
        '
        Me.opt_mas.AutoSize = True
        Me.opt_mas.Checked = True
        Me.opt_mas.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opt_mas.ForeColor = System.Drawing.Color.Black
        Me.opt_mas.Location = New System.Drawing.Point(1244, 7)
        Me.opt_mas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.opt_mas.Name = "opt_mas"
        Me.opt_mas.Size = New System.Drawing.Size(106, 20)
        Me.opt_mas.TabIndex = 86
        Me.opt_mas.TabStop = True
        Me.opt_mas.Text = "+ Vendidos"
        Me.opt_mas.UseVisualStyleBackColor = True
        '
        'DataDetalle4
        '
        Me.DataDetalle4.AllowUserToAddRows = False
        Me.DataDetalle4.AllowUserToDeleteRows = False
        Me.DataDetalle4.AllowUserToResizeColumns = False
        Me.DataDetalle4.AllowUserToResizeRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataDetalle4.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.DataDetalle4.BackgroundColor = System.Drawing.Color.White
        Me.DataDetalle4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataDetalle4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataDetalle4.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataDetalle4.Dock = System.Windows.Forms.DockStyle.Left
        Me.DataDetalle4.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.DataDetalle4.Location = New System.Drawing.Point(4, 4)
        Me.DataDetalle4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataDetalle4.Name = "DataDetalle4"
        Me.DataDetalle4.ReadOnly = True
        Me.DataDetalle4.RowHeadersVisible = False
        Me.DataDetalle4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataDetalle4.SelectAllSignVisible = False
        Me.DataDetalle4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataDetalle4.ShowEditingIcon = False
        Me.DataDetalle4.Size = New System.Drawing.Size(1232, 441)
        Me.DataDetalle4.TabIndex = 85
        '
        'cmdProcesar
        '
        Me.cmdProcesar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdProcesar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdProcesar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdProcesar.Image = Global.cefe.My.Resources.Resources.tr_024
        Me.cmdProcesar.Location = New System.Drawing.Point(1140, 122)
        Me.cmdProcesar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdProcesar.Name = "cmdProcesar"
        Me.cmdProcesar.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.cmdProcesar.Size = New System.Drawing.Size(123, 44)
        Me.cmdProcesar.TabIndex = 153
        Me.cmdProcesar.Text = "Procesar"
        '
        'e_ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(1360, 661)
        Me.Controls.Add(Me.cmdProcesar)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.chkAlmacen)
        Me.Controls.Add(Me.cboAlmacen)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Controls.Add(Me.chkDia)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.cmdCerrar)
        Me.Controls.Add(Me.cmdImprimir)
        Me.Controls.Add(Me.GroupBox2)
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "e_ventas"
        Me.Text = "Consulta: VENTAS"
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.dtiHasta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtiDesde, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabProducto.ResumeLayout(False)
        CType(Me.dataDetalle2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabFecha.ResumeLayout(False)
        Me.TabFecha.PerformLayout()
        CType(Me.DataDetalle3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabRanking.ResumeLayout(False)
        Me.TabRanking.PerformLayout()
        CType(Me.DataDetalle4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdCerrar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmdImprimir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents optDemandaImporte As System.Windows.Forms.RadioButton
    Friend WithEvents optVentasMensuales As System.Windows.Forms.RadioButton
    Friend WithEvents optVentasDiarias As System.Windows.Forms.RadioButton
    Friend WithEvents optVentasGrupo As System.Windows.Forms.RadioButton
    Friend WithEvents chkDia As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents dtiHasta As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents dtiDesde As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents cboAnno As System.Windows.Forms.ComboBox
    Friend WithEvents cboMes As System.Windows.Forms.ComboBox
    Friend WithEvents chkAlmacen As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents cboAlmacen As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabProducto As System.Windows.Forms.TabPage
    Friend WithEvents dataDetalle2 As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents dataDetalle As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents TabFecha As System.Windows.Forms.TabPage
    Friend WithEvents DataDetalle3 As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents cmdProcesar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TabRanking As System.Windows.Forms.TabPage
    Friend WithEvents DataDetalle4 As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents opt_menos As System.Windows.Forms.RadioButton
    Friend WithEvents opt_mas As System.Windows.Forms.RadioButton
    Friend WithEvents optimporte As System.Windows.Forms.RadioButton
    Friend WithEvents optcantidad As System.Windows.Forms.RadioButton

End Class
