<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class c_movimientos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(c_movimientos))
        Me.chkDia = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.dtiHasta = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.dtiDesde = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.cboAnno = New System.Windows.Forms.ComboBox()
        Me.cboMes = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboAlmacen = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.dataDetalle = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.lblRegistros = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.optDescripcion = New System.Windows.Forms.RadioButton()
        Me.optCodigo = New System.Windows.Forms.RadioButton()
        Me.txtBuscar = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.cmdImprimir = New DevComponents.DotNetBar.ButtonX()
        Me.cmdCerrar = New DevComponents.DotNetBar.ButtonX()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.optAlmacen = New System.Windows.Forms.RadioButton()
        Me.optIntegrado = New System.Windows.Forms.RadioButton()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5.SuspendLayout()
        CType(Me.dtiHasta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtiDesde, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dataDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkDia
        '
        Me.chkDia.AutoSize = True
        '
        '
        '
        Me.chkDia.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chkDia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDia.Location = New System.Drawing.Point(271, 5)
        Me.chkDia.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkDia.Name = "chkDia"
        Me.chkDia.Size = New System.Drawing.Size(134, 18)
        Me.chkDia.TabIndex = 124
        Me.chkDia.TabStop = False
        Me.chkDia.Text = "x Rango de Fecha"
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
        Me.GroupBox5.Location = New System.Drawing.Point(263, 9)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox5.Size = New System.Drawing.Size(176, 95)
        Me.GroupBox5.TabIndex = 125
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
        Me.dtiHasta.Location = New System.Drawing.Point(59, 60)
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
        Me.dtiDesde.Enabled = False
        Me.dtiDesde.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.dtiDesde.IsInputReadOnly = True
        Me.dtiDesde.IsPopupCalendarOpen = False
        Me.dtiDesde.Location = New System.Drawing.Point(59, 26)
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
        Me.LabelX1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.ForeColor = System.Drawing.Color.Black
        Me.LabelX1.Location = New System.Drawing.Point(11, 28)
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
        Me.LabelX2.Location = New System.Drawing.Point(15, 63)
        Me.LabelX2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(38, 18)
        Me.LabelX2.TabIndex = 117
        Me.LabelX2.Text = "hasta"
        Me.LabelX2.TextAlignment = System.Drawing.StringAlignment.Center
        Me.LabelX2.WordWrap = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(-25, 100)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(1200, 12)
        Me.GroupBox3.TabIndex = 122
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
        Me.GroupPanel1.TabIndex = 123
        Me.GroupPanel1.Text = "Periodo de Reporte"
        '
        'cboAnno
        '
        Me.cboAnno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAnno.Enabled = False
        Me.cboAnno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAnno.FormattingEnabled = True
        Me.cboAnno.Items.AddRange(New Object() {"2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025"})
        Me.cboAnno.Location = New System.Drawing.Point(144, 6)
        Me.cboAnno.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboAnno.Name = "cboAnno"
        Me.cboAnno.Size = New System.Drawing.Size(79, 25)
        Me.cboAnno.TabIndex = 1
        '
        'cboMes
        '
        Me.cboMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMes.Enabled = False
        Me.cboMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMes.FormattingEnabled = True
        Me.cboMes.Items.AddRange(New Object() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Setiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.cboMes.Location = New System.Drawing.Point(8, 6)
        Me.cboMes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboMes.Name = "cboMes"
        Me.cboMes.Size = New System.Drawing.Size(124, 25)
        Me.cboMes.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboAlmacen)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(688, 6)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(255, 48)
        Me.GroupBox1.TabIndex = 126
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Almacén"
        '
        'cboAlmacen
        '
        Me.cboAlmacen.DisplayMember = "Text"
        Me.cboAlmacen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboAlmacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAlmacen.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAlmacen.ForeColor = System.Drawing.Color.Black
        Me.cboAlmacen.FormattingEnabled = True
        Me.cboAlmacen.ItemHeight = 14
        Me.cboAlmacen.Location = New System.Drawing.Point(7, 17)
        Me.cboAlmacen.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboAlmacen.Name = "cboAlmacen"
        Me.cboAlmacen.Size = New System.Drawing.Size(239, 20)
        Me.cboAlmacen.TabIndex = 0
        Me.cboAlmacen.WatermarkColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'dataDetalle
        '
        Me.dataDetalle.AllowUserToAddRows = False
        Me.dataDetalle.AllowUserToDeleteRows = False
        Me.dataDetalle.AllowUserToResizeColumns = False
        Me.dataDetalle.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dataDetalle.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dataDetalle.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dataDetalle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataDetalle.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dataDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataDetalle.DefaultCellStyle = DataGridViewCellStyle3
        Me.dataDetalle.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dataDetalle.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dataDetalle.Location = New System.Drawing.Point(0, 119)
        Me.dataDetalle.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dataDetalle.MultiSelect = False
        Me.dataDetalle.Name = "dataDetalle"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataDetalle.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dataDetalle.RowHeadersVisible = False
        Me.dataDetalle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dataDetalle.SelectAllSignVisible = False
        Me.dataDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dataDetalle.ShowEditingIcon = False
        Me.dataDetalle.Size = New System.Drawing.Size(1077, 489)
        Me.dataDetalle.TabIndex = 1
        '
        'lblRegistros
        '
        '
        '
        '
        Me.lblRegistros.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblRegistros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistros.ForeColor = System.Drawing.Color.Green
        Me.lblRegistros.Location = New System.Drawing.Point(11, 75)
        Me.lblRegistros.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblRegistros.Name = "lblRegistros"
        Me.lblRegistros.Size = New System.Drawing.Size(245, 23)
        Me.lblRegistros.TabIndex = 140
        Me.lblRegistros.Text = "Nº de Registros... "
        Me.lblRegistros.TextAlignment = System.Drawing.StringAlignment.Center
        Me.lblRegistros.WordWrap = True
        '
        'LabelX3
        '
        Me.LabelX3.AutoSize = True
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.ForeColor = System.Drawing.Color.Maroon
        Me.LabelX3.Location = New System.Drawing.Point(11, 20)
        Me.LabelX3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(63, 19)
        Me.LabelX3.TabIndex = 144
        Me.LabelX3.Text = "Buscar x"
        Me.LabelX3.TextAlignment = System.Drawing.StringAlignment.Center
        Me.LabelX3.WordWrap = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.optDescripcion)
        Me.GroupBox2.Controls.Add(Me.optCodigo)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox2.Location = New System.Drawing.Point(83, 9)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(229, 37)
        Me.GroupBox2.TabIndex = 141
        Me.GroupBox2.TabStop = False
        '
        'optDescripcion
        '
        Me.optDescripcion.AutoSize = True
        Me.optDescripcion.Checked = True
        Me.optDescripcion.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optDescripcion.ForeColor = System.Drawing.Color.Black
        Me.optDescripcion.Location = New System.Drawing.Point(104, 11)
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
        Me.optCodigo.Location = New System.Drawing.Point(12, 11)
        Me.optCodigo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.optCodigo.Name = "optCodigo"
        Me.optCodigo.Size = New System.Drawing.Size(79, 20)
        Me.optCodigo.TabIndex = 0
        Me.optCodigo.Text = "Código"
        Me.optCodigo.UseVisualStyleBackColor = True
        '
        'txtBuscar
        '
        '
        '
        '
        Me.txtBuscar.Border.Class = "TextBoxBorder"
        Me.txtBuscar.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtBuscar.FocusHighlightEnabled = True
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(313, 18)
        Me.txtBuscar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(144, 24)
        Me.txtBuscar.TabIndex = 0
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.cefe.My.Resources.Resources.buscar221
        Me.PictureBox2.Location = New System.Drawing.Point(460, 15)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(35, 32)
        Me.PictureBox2.TabIndex = 143
        Me.PictureBox2.TabStop = False
        '
        'cmdImprimir
        '
        Me.cmdImprimir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdImprimir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdImprimir.Image = Global.cefe.My.Resources.Resources.print_preview
        Me.cmdImprimir.Location = New System.Drawing.Point(955, 58)
        Me.cmdImprimir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.cmdImprimir.Size = New System.Drawing.Size(107, 44)
        Me.cmdImprimir.TabIndex = 73
        Me.cmdImprimir.Text = "Imprimir"
        '
        'cmdCerrar
        '
        Me.cmdCerrar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdCerrar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCerrar.Image = Global.cefe.My.Resources.Resources.CLOSE22
        Me.cmdCerrar.Location = New System.Drawing.Point(955, 9)
        Me.cmdCerrar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdCerrar.Name = "cmdCerrar"
        Me.cmdCerrar.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.cmdCerrar.Size = New System.Drawing.Size(107, 44)
        Me.cmdCerrar.TabIndex = 74
        Me.cmdCerrar.Text = "Cerrar"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.optAlmacen)
        Me.GroupBox4.Controls.Add(Me.optIntegrado)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox4.Location = New System.Drawing.Point(443, 6)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox4.Size = New System.Drawing.Size(240, 48)
        Me.GroupBox4.TabIndex = 145
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Tipo de Reporte"
        '
        'optAlmacen
        '
        Me.optAlmacen.AutoSize = True
        Me.optAlmacen.Checked = True
        Me.optAlmacen.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optAlmacen.ForeColor = System.Drawing.Color.Black
        Me.optAlmacen.Location = New System.Drawing.Point(128, 18)
        Me.optAlmacen.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.optAlmacen.Name = "optAlmacen"
        Me.optAlmacen.Size = New System.Drawing.Size(98, 20)
        Me.optAlmacen.TabIndex = 1
        Me.optAlmacen.TabStop = True
        Me.optAlmacen.Text = "x Almacén"
        Me.optAlmacen.UseVisualStyleBackColor = True
        '
        'optIntegrado
        '
        Me.optIntegrado.AutoSize = True
        Me.optIntegrado.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optIntegrado.ForeColor = System.Drawing.Color.Black
        Me.optIntegrado.Location = New System.Drawing.Point(16, 18)
        Me.optIntegrado.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.optIntegrado.Name = "optIntegrado"
        Me.optIntegrado.Size = New System.Drawing.Size(97, 20)
        Me.optIntegrado.TabIndex = 0
        Me.optIntegrado.Text = "Integrado"
        Me.optIntegrado.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.GroupBox2)
        Me.GroupBox6.Controls.Add(Me.PictureBox2)
        Me.GroupBox6.Controls.Add(Me.txtBuscar)
        Me.GroupBox6.Controls.Add(Me.LabelX3)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox6.Location = New System.Drawing.Point(443, 49)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox6.Size = New System.Drawing.Size(500, 54)
        Me.GroupBox6.TabIndex = 146
        Me.GroupBox6.TabStop = False
        '
        'c_movimientos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(1077, 608)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.cmdCerrar)
        Me.Controls.Add(Me.chkDia)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.cmdImprimir)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.lblRegistros)
        Me.Controls.Add(Me.dataDetalle)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "c_movimientos"
        Me.Text = "Consulta: MOVIMIENTOS"
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.dtiHasta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtiDesde, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dataDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkDia As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents dtiHasta As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents dtiDesde As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents cboAnno As System.Windows.Forms.ComboBox
    Friend WithEvents cboMes As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cboAlmacen As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents dataDetalle As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents lblRegistros As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents optDescripcion As System.Windows.Forms.RadioButton
    Friend WithEvents optCodigo As System.Windows.Forms.RadioButton
    Friend WithEvents txtBuscar As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents cmdImprimir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmdCerrar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents optAlmacen As System.Windows.Forms.RadioButton
    Friend WithEvents optIntegrado As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox

End Class
