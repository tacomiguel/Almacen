<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class p_conteoFisico
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(p_conteoFisico))
        Me.datos = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.cboAnno = New System.Windows.Forms.ComboBox()
        Me.cboMes = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkArea = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.cboArea = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.cboAlmacen = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.chkRegistrarBotellas = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.dtiDia = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cboGrupo = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.chkGrupo = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.txtBuscar = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.ReflectionLabel1 = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        CType(Me.datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dtiDia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'datos
        '
        Me.datos.AllowUserToAddRows = False
        Me.datos.AllowUserToDeleteRows = False
        Me.datos.AllowUserToResizeColumns = False
        Me.datos.AllowUserToResizeRows = False
        Me.datos.BackgroundColor = System.Drawing.Color.White
        Me.datos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datos.DefaultCellStyle = DataGridViewCellStyle2
        Me.datos.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.datos.Location = New System.Drawing.Point(0, 127)
        Me.datos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.datos.MultiSelect = False
        Me.datos.Name = "datos"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datos.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.datos.RowHeadersVisible = False
        Me.datos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.datos.SelectAllSignVisible = False
        Me.datos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.datos.ShowEditingIcon = False
        Me.datos.Size = New System.Drawing.Size(1169, 544)
        Me.datos.TabIndex = 2
        '
        'GroupPanel1
        '
        Me.GroupPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.cboAnno)
        Me.GroupPanel1.Controls.Add(Me.cboMes)
        Me.GroupPanel1.Location = New System.Drawing.Point(12, 12)
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
        Me.GroupPanel1.TabIndex = 165
        Me.GroupPanel1.Text = "Periodo de Inventario"
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkArea)
        Me.GroupBox1.Controls.Add(Me.cboArea)
        Me.GroupBox1.Controls.Add(Me.cboAlmacen)
        Me.GroupBox1.Controls.Add(Me.LabelX2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(269, 9)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(603, 68)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Parámetros de Registro"
        '
        'chkArea
        '
        Me.chkArea.AutoSize = True
        '
        '
        '
        Me.chkArea.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chkArea.Checked = True
        Me.chkArea.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkArea.CheckValue = "Y"
        Me.chkArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkArea.Location = New System.Drawing.Point(299, 31)
        Me.chkArea.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkArea.Name = "chkArea"
        Me.chkArea.Size = New System.Drawing.Size(55, 19)
        Me.chkArea.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.chkArea.TabIndex = 2
        Me.chkArea.Text = "Area"
        Me.chkArea.TextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        '
        'cboArea
        '
        Me.cboArea.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboArea.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cboArea.DisplayMember = "Text"
        Me.cboArea.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboArea.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboArea.ForeColor = System.Drawing.Color.Black
        Me.cboArea.FormattingEnabled = True
        Me.cboArea.ItemHeight = 15
        Me.cboArea.Location = New System.Drawing.Point(368, 27)
        Me.cboArea.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboArea.Name = "cboArea"
        Me.cboArea.Size = New System.Drawing.Size(217, 21)
        Me.cboArea.TabIndex = 3
        Me.cboArea.WatermarkColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'cboAlmacen
        '
        Me.cboAlmacen.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboAlmacen.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cboAlmacen.DisplayMember = "Text"
        Me.cboAlmacen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboAlmacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAlmacen.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAlmacen.ForeColor = System.Drawing.Color.Black
        Me.cboAlmacen.FormattingEnabled = True
        Me.cboAlmacen.ItemHeight = 15
        Me.cboAlmacen.Location = New System.Drawing.Point(84, 28)
        Me.cboAlmacen.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboAlmacen.Name = "cboAlmacen"
        Me.cboAlmacen.Size = New System.Drawing.Size(193, 21)
        Me.cboAlmacen.TabIndex = 1
        Me.cboAlmacen.WatermarkColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'LabelX2
        '
        Me.LabelX2.AutoSize = True
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LabelX2.Location = New System.Drawing.Point(13, 30)
        Me.LabelX2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(63, 19)
        Me.LabelX2.TabIndex = 0
        Me.LabelX2.Text = "Almacén"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.LabelX1)
        Me.GroupBox4.Controls.Add(Me.chkRegistrarBotellas)
        Me.GroupBox4.Controls.Add(Me.dtiDia)
        Me.GroupBox4.Controls.Add(Me.PictureBox1)
        Me.GroupBox4.Controls.Add(Me.cboGrupo)
        Me.GroupBox4.Controls.Add(Me.chkGrupo)
        Me.GroupBox4.Controls.Add(Me.PictureBox3)
        Me.GroupBox4.Controls.Add(Me.txtBuscar)
        Me.GroupBox4.Controls.Add(Me.LabelX4)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox4.Location = New System.Drawing.Point(3, 73)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox4.Size = New System.Drawing.Size(1165, 49)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        '
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.ForeColor = System.Drawing.Color.Maroon
        Me.LabelX1.Location = New System.Drawing.Point(660, 20)
        Me.LabelX1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(101, 18)
        Me.LabelX1.TabIndex = 141
        Me.LabelX1.Text = "Dia de Registro"
        Me.LabelX1.WordWrap = True
        '
        'chkRegistrarBotellas
        '
        Me.chkRegistrarBotellas.AutoSize = True
        '
        '
        '
        Me.chkRegistrarBotellas.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chkRegistrarBotellas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRegistrarBotellas.Location = New System.Drawing.Point(916, 20)
        Me.chkRegistrarBotellas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkRegistrarBotellas.Name = "chkRegistrarBotellas"
        Me.chkRegistrarBotellas.Size = New System.Drawing.Size(222, 21)
        Me.chkRegistrarBotellas.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.chkRegistrarBotellas.TabIndex = 140
        Me.chkRegistrarBotellas.Text = "Registrar Peso de Botellas"
        Me.chkRegistrarBotellas.TextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        'dtiDia
        '
        '
        '
        '
        Me.dtiDia.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dtiDia.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtiDia.ButtonDropDown.Visible = True
        Me.dtiDia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtiDia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.dtiDia.IsInputReadOnly = True
        Me.dtiDia.IsPopupCalendarOpen = False
        Me.dtiDia.Location = New System.Drawing.Point(772, 16)
        Me.dtiDia.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        '
        '
        '
        Me.dtiDia.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtiDia.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.dtiDia.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.dtiDia.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dtiDia.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dtiDia.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dtiDia.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dtiDia.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dtiDia.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dtiDia.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtiDia.MonthCalendar.DisplayMonth = New Date(2011, 3, 1, 0, 0, 0, 0)
        Me.dtiDia.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.dtiDia.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtiDia.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dtiDia.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dtiDia.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dtiDia.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtiDia.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.dtiDia.Name = "dtiDia"
        Me.dtiDia.Size = New System.Drawing.Size(123, 24)
        Me.dtiDia.TabIndex = 5
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(617, 18)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 139
        Me.PictureBox1.TabStop = False
        '
        'cboGrupo
        '
        Me.cboGrupo.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboGrupo.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cboGrupo.DisplayMember = "Text"
        Me.cboGrupo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGrupo.Enabled = False
        Me.cboGrupo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGrupo.ForeColor = System.Drawing.Color.Black
        Me.cboGrupo.FormattingEnabled = True
        Me.cboGrupo.ItemHeight = 15
        Me.cboGrupo.Location = New System.Drawing.Point(387, 15)
        Me.cboGrupo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboGrupo.Name = "cboGrupo"
        Me.cboGrupo.Size = New System.Drawing.Size(227, 21)
        Me.cboGrupo.TabIndex = 3
        Me.cboGrupo.WatermarkColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'chkGrupo
        '
        Me.chkGrupo.AutoSize = True
        '
        '
        '
        Me.chkGrupo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chkGrupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkGrupo.Location = New System.Drawing.Point(300, 18)
        Me.chkGrupo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkGrupo.Name = "chkGrupo"
        Me.chkGrupo.Size = New System.Drawing.Size(73, 18)
        Me.chkGrupo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.chkGrupo.TabIndex = 2
        Me.chkGrupo.Text = "x Grupo"
        Me.chkGrupo.TextColor = System.Drawing.Color.Maroon
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(256, 20)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(18, 18)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 136
        Me.PictureBox3.TabStop = False
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
        Me.txtBuscar.Location = New System.Drawing.Point(68, 15)
        Me.txtBuscar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(184, 24)
        Me.txtBuscar.TabIndex = 1
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
        Me.LabelX4.Location = New System.Drawing.Point(13, 18)
        Me.LabelX4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(47, 18)
        Me.LabelX4.TabIndex = 0
        Me.LabelX4.Text = "Buscar"
        Me.LabelX4.WordWrap = True
        '
        'ReflectionLabel1
        '
        '
        '
        '
        Me.ReflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ReflectionLabel1.Location = New System.Drawing.Point(904, 10)
        Me.ReflectionLabel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ReflectionLabel1.Name = "ReflectionLabel1"
        Me.ReflectionLabel1.Size = New System.Drawing.Size(249, 64)
        Me.ReflectionLabel1.TabIndex = 167
        Me.ReflectionLabel1.Text = "<b><font size=""+6""><i>Conteo Físico</i><font color=""#B02B2C""> Diario</font></font" &
    "></b>"
        '
        'p_conteoFisico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(1169, 671)
        Me.Controls.Add(Me.ReflectionLabel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.datos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "p_conteoFisico"
        Me.Text = "Proceso: REGISTRO DE CONTEO FISICO DIARIO"
        CType(Me.datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.dtiDia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents datos As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents cboAnno As System.Windows.Forms.ComboBox
    Friend WithEvents cboMes As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents chkArea As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents cboArea As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cboAlmacen As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cboGrupo As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents chkGrupo As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents txtBuscar As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dtiDia As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents ReflectionLabel1 As DevComponents.DotNetBar.Controls.ReflectionLabel
    Private WithEvents chkRegistrarBotellas As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX

End Class
