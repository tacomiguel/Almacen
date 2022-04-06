<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class u_importaVentas_dbf
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(u_importaVentas_dbf))
        Me.TabControl1 = New DevComponents.DotNetBar.TabControl()
        Me.TabControlPanel1 = New DevComponents.DotNetBar.TabControlPanel()
        Me.datos = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.Tab_impventa = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel2 = New DevComponents.DotNetBar.TabControlPanel()
        Me.datosRegVentas = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.tab_regventas = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel3 = New DevComponents.DotNetBar.TabControlPanel()
        Me.datositems = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.tipocambio = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboImportacion = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.cbproduccion = New DevComponents.Editors.ComboItem()
        Me.cbventa = New DevComponents.Editors.ComboItem()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.dtiFecha = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.lblProcesados = New DevComponents.DotNetBar.LabelX()
        Me.cmdImportar = New DevComponents.DotNetBar.ButtonX()
        Me.cmdCargar = New DevExpress.DXCore.Controls.XtraEditors.SimpleButton()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.txtArchivo = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.cmdExaminar = New DevExpress.DXCore.Controls.XtraEditors.SimpleButton()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabControlPanel1.SuspendLayout()
        CType(Me.datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlPanel2.SuspendLayout()
        CType(Me.datosRegVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlPanel3.SuspendLayout()
        CType(Me.datositems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.dtiFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabControl1.CanReorderTabs = True
        Me.TabControl1.ColorScheme.TabItemHotBackground2 = System.Drawing.Color.White
        Me.TabControl1.ColorScheme.TabItemSelectedBackground2 = System.Drawing.Color.White
        Me.TabControl1.Controls.Add(Me.TabControlPanel1)
        Me.TabControl1.Controls.Add(Me.TabControlPanel2)
        Me.TabControl1.Controls.Add(Me.TabControlPanel3)
        Me.TabControl1.Location = New System.Drawing.Point(-6, 60)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TabControl1.SelectedTabIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1021, 382)
        Me.TabControl1.TabIndex = 163
        Me.TabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
        Me.TabControl1.Tabs.Add(Me.Tab_impventa)
        Me.TabControl1.Tabs.Add(Me.tab_regventas)
        Me.TabControl1.Tabs.Add(Me.tipocambio)
        Me.TabControl1.Text = "TabControl1"
        '
        'TabControlPanel1
        '
        Me.TabControlPanel1.Controls.Add(Me.datos)
        Me.TabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel1.Location = New System.Drawing.Point(0, 26)
        Me.TabControlPanel1.Name = "TabControlPanel1"
        Me.TabControlPanel1.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel1.Size = New System.Drawing.Size(1021, 356)
        Me.TabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.White
        Me.TabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.TabControlPanel1.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel1.Style.GradientAngle = 90
        Me.TabControlPanel1.TabIndex = 1
        Me.TabControlPanel1.TabItem = Me.Tab_impventa
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
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datos.DefaultCellStyle = DataGridViewCellStyle2
        Me.datos.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.datos.Location = New System.Drawing.Point(4, -1)
        Me.datos.Name = "datos"
        Me.datos.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datos.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.datos.RowHeadersVisible = False
        Me.datos.SelectAllSignVisible = False
        Me.datos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datos.ShowEditingIcon = False
        Me.datos.Size = New System.Drawing.Size(861, 321)
        Me.datos.TabIndex = 150
        '
        'Tab_impventa
        '
        Me.Tab_impventa.AttachedControl = Me.TabControlPanel1
        Me.Tab_impventa.BackColor2 = System.Drawing.Color.White
        Me.Tab_impventa.Name = "Tab_impventa"
        Me.Tab_impventa.Text = "Importar Ventas"
        '
        'TabControlPanel2
        '
        Me.TabControlPanel2.Controls.Add(Me.datosRegVentas)
        Me.TabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel2.Location = New System.Drawing.Point(0, 26)
        Me.TabControlPanel2.Name = "TabControlPanel2"
        Me.TabControlPanel2.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel2.Size = New System.Drawing.Size(1021, 356)
        Me.TabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.White
        Me.TabControlPanel2.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.TabControlPanel2.Style.BorderDashStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.TabControlPanel2.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel2.Style.GradientAngle = 90
        Me.TabControlPanel2.TabIndex = 2
        Me.TabControlPanel2.TabItem = Me.tab_regventas
        '
        'datosRegVentas
        '
        Me.datosRegVentas.BackgroundColor = System.Drawing.Color.White
        Me.datosRegVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datosRegVentas.DefaultCellStyle = DataGridViewCellStyle4
        Me.datosRegVentas.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.datosRegVentas.Location = New System.Drawing.Point(4, -3)
        Me.datosRegVentas.Name = "datosRegVentas"
        Me.datosRegVentas.Size = New System.Drawing.Size(722, 354)
        Me.datosRegVentas.TabIndex = 0
        '
        'tab_regventas
        '
        Me.tab_regventas.AttachedControl = Me.TabControlPanel2
        Me.tab_regventas.Name = "tab_regventas"
        Me.tab_regventas.Text = "Registro de Ventas"
        '
        'TabControlPanel3
        '
        Me.TabControlPanel3.Controls.Add(Me.datositems)
        Me.TabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel3.Location = New System.Drawing.Point(0, 26)
        Me.TabControlPanel3.Name = "TabControlPanel3"
        Me.TabControlPanel3.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel3.Size = New System.Drawing.Size(1021, 356)
        Me.TabControlPanel3.Style.BackColor1.Color = System.Drawing.Color.White
        Me.TabControlPanel3.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel3.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.TabControlPanel3.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel3.Style.GradientAngle = 90
        Me.TabControlPanel3.TabIndex = 3
        Me.TabControlPanel3.TabItem = Me.tipocambio
        '
        'datositems
        '
        Me.datositems.BackgroundColor = System.Drawing.Color.White
        Me.datositems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datositems.DefaultCellStyle = DataGridViewCellStyle5
        Me.datositems.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.datositems.Location = New System.Drawing.Point(4, 36)
        Me.datositems.Name = "datositems"
        Me.datositems.Size = New System.Drawing.Size(725, 315)
        Me.datositems.TabIndex = 2
        '
        'tipocambio
        '
        Me.tipocambio.AttachedControl = Me.TabControlPanel3
        Me.tipocambio.Name = "tipocambio"
        Me.tipocambio.Text = "Tipo de Cambio"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboImportacion)
        Me.GroupBox1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GroupBox1.Location = New System.Drawing.Point(97, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(175, 51)
        Me.GroupBox1.TabIndex = 162
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo Importacion"
        '
        'cboImportacion
        '
        Me.cboImportacion.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboImportacion.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cboImportacion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboImportacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboImportacion.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboImportacion.ForeColor = System.Drawing.Color.Black
        Me.cboImportacion.FormattingEnabled = True
        Me.cboImportacion.ItemHeight = 15
        Me.cboImportacion.Items.AddRange(New Object() {Me.cbproduccion, Me.cbventa})
        Me.cboImportacion.Location = New System.Drawing.Point(6, 19)
        Me.cboImportacion.Name = "cboImportacion"
        Me.cboImportacion.Size = New System.Drawing.Size(164, 21)
        Me.cboImportacion.TabIndex = 161
        Me.cboImportacion.WatermarkColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'cbproduccion
        '
        Me.cbproduccion.Text = "Produccion"
        '
        'cbventa
        '
        Me.cbventa.Text = "Ventas"
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX1.Image = Global.cefe.My.Resources.Resources.Transformaciones
        Me.ButtonX1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonX1.Location = New System.Drawing.Point(540, 2)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.ButtonX1.Size = New System.Drawing.Size(68, 48)
        Me.ButtonX1.TabIndex = 159
        Me.ButtonX1.Text = "Importar"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.dtiFecha)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GroupBox5.Location = New System.Drawing.Point(342, 2)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(107, 48)
        Me.GroupBox5.TabIndex = 158
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Fecha a Registrar"
        '
        'dtiFecha
        '
        '
        '
        '
        Me.dtiFecha.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dtiFecha.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtiFecha.ButtonDropDown.Visible = True
        Me.dtiFecha.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtiFecha.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dtiFecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.dtiFecha.IsInputReadOnly = True
        Me.dtiFecha.IsPopupCalendarOpen = False
        Me.dtiFecha.Location = New System.Drawing.Point(8, 19)
        Me.dtiFecha.MaxDate = New Date(2020, 12, 31, 0, 0, 0, 0)
        Me.dtiFecha.MinDate = New Date(2010, 1, 1, 0, 0, 0, 0)
        '
        '
        '
        Me.dtiFecha.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtiFecha.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.dtiFecha.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtiFecha.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        '
        '
        '
        Me.dtiFecha.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dtiFecha.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dtiFecha.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dtiFecha.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dtiFecha.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dtiFecha.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dtiFecha.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtiFecha.MonthCalendar.DisplayMonth = New Date(2011, 3, 1, 0, 0, 0, 0)
        Me.dtiFecha.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.dtiFecha.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtiFecha.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dtiFecha.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dtiFecha.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dtiFecha.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtiFecha.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.dtiFecha.Name = "dtiFecha"
        Me.dtiFecha.Size = New System.Drawing.Size(92, 20)
        Me.dtiFecha.TabIndex = 119
        '
        'lblProcesados
        '
        Me.lblProcesados.AutoSize = True
        '
        '
        '
        Me.lblProcesados.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblProcesados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProcesados.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblProcesados.Location = New System.Drawing.Point(716, 12)
        Me.lblProcesados.Name = "lblProcesados"
        Me.lblProcesados.Size = New System.Drawing.Size(67, 17)
        Me.lblProcesados.TabIndex = 157
        Me.lblProcesados.Text = "Porcentaje"
        Me.lblProcesados.TextAlignment = System.Drawing.StringAlignment.Center
        Me.lblProcesados.Visible = False
        Me.lblProcesados.WordWrap = True
        '
        'cmdImportar
        '
        Me.cmdImportar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdImportar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdImportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdImportar.Image = Global.cefe.My.Resources.Resources.m_grabar
        Me.cmdImportar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.cmdImportar.Location = New System.Drawing.Point(631, 2)
        Me.cmdImportar.Name = "cmdImportar"
        Me.cmdImportar.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.cmdImportar.Size = New System.Drawing.Size(68, 48)
        Me.cmdImportar.TabIndex = 152
        Me.cmdImportar.Text = "Grabar"
        '
        'cmdCargar
        '
        Me.cmdCargar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmdCargar.Appearance.Options.UseFont = True
        Me.cmdCargar.Image = Global.cefe.My.Resources.Resources.ark22
        Me.cmdCargar.ImageLocation = DevExpress.DXCore.Controls.XtraEditors.ImageLocation.TopCenter
        Me.cmdCargar.Location = New System.Drawing.Point(10, 5)
        Me.cmdCargar.LookAndFeel.SkinName = "iMaginary"
        Me.cmdCargar.Name = "cmdCargar"
        Me.cmdCargar.Size = New System.Drawing.Size(87, 46)
        Me.cmdCargar.TabIndex = 151
        Me.cmdCargar.Text = "Cargar Datos"
        Me.cmdCargar.Visible = False
        '
        'LabelX3
        '
        Me.LabelX3.AutoSize = True
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.ForeColor = System.Drawing.Color.Black
        Me.LabelX3.Location = New System.Drawing.Point(81, 8)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(104, 16)
        Me.LabelX3.TabIndex = 149
        Me.LabelX3.Text = "Archivo a Importar"
        Me.LabelX3.TextAlignment = System.Drawing.StringAlignment.Center
        Me.LabelX3.Visible = False
        Me.LabelX3.WordWrap = True
        '
        'txtArchivo
        '
        '
        '
        '
        Me.txtArchivo.Border.Class = "TextBoxBorder"
        Me.txtArchivo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtArchivo.FocusHighlightEnabled = True
        Me.txtArchivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArchivo.Location = New System.Drawing.Point(10, 30)
        Me.txtArchivo.Name = "txtArchivo"
        Me.txtArchivo.Size = New System.Drawing.Size(235, 21)
        Me.txtArchivo.TabIndex = 148
        Me.txtArchivo.Visible = False
        '
        'cmdExaminar
        '
        Me.cmdExaminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmdExaminar.Appearance.Options.UseFont = True
        Me.cmdExaminar.Image = Global.cefe.My.Resources.Resources.c_buscarD
        Me.cmdExaminar.ImageLocation = DevExpress.DXCore.Controls.XtraEditors.ImageLocation.TopCenter
        Me.cmdExaminar.Location = New System.Drawing.Point(4, 8)
        Me.cmdExaminar.LookAndFeel.SkinName = "iMaginary"
        Me.cmdExaminar.Name = "cmdExaminar"
        Me.cmdExaminar.Size = New System.Drawing.Size(71, 46)
        Me.cmdExaminar.TabIndex = 147
        Me.cmdExaminar.Text = "Examinar"
        Me.cmdExaminar.Visible = False
        '
        'u_importaVentas_dbf
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(858, 429)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ButtonX1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.lblProcesados)
        Me.Controls.Add(Me.cmdImportar)
        Me.Controls.Add(Me.cmdCargar)
        Me.Controls.Add(Me.LabelX3)
        Me.Controls.Add(Me.txtArchivo)
        Me.Controls.Add(Me.cmdExaminar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "u_importaVentas_dbf"
        Me.Text = "Utilidad: IMPORTAR VENTAS"
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabControlPanel1.ResumeLayout(False)
        CType(Me.datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlPanel2.ResumeLayout(False)
        CType(Me.datosRegVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlPanel3.ResumeLayout(False)
        CType(Me.datositems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.dtiFecha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdImportar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmdCargar As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents datos As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtArchivo As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents cmdExaminar As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents lblProcesados As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents dtiFecha As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cboImportacion As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TabControl1 As DevComponents.DotNetBar.TabControl
    Friend WithEvents TabControlPanel1 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents Tab_impventa As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabControlPanel2 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents tab_regventas As DevComponents.DotNetBar.TabItem
    Friend WithEvents datosRegVentas As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents TabControlPanel3 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents datositems As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents tipocambio As DevComponents.DotNetBar.TabItem
    Friend WithEvents cbproduccion As DevComponents.Editors.ComboItem
    Friend WithEvents cbventa As DevComponents.Editors.ComboItem

End Class
