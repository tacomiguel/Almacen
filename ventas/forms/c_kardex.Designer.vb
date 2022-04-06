<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class c_kardex
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(c_kardex))
        Me.dataArticulo = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.lblItems = New DevComponents.DotNetBar.LabelX()
        Me.dataKardex = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.txtBuscar = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.chkProduccion = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.cboAlmacen = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.chkDia = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.dtiHasta = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.dtiDesde = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.cboAnno = New System.Windows.Forms.ComboBox()
        Me.cboMes = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblRegistros = New DevComponents.DotNetBar.LabelX()
        Me.lblPrecioPromedio = New DevComponents.DotNetBar.LabelX()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkIncIGV = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.cmdImprimir = New DevExpress.DXCore.Controls.XtraEditors.SimpleButton()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.lblSalidas = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.lblStock = New DevComponents.DotNetBar.LabelX()
        Me.lblIngresos = New DevComponents.DotNetBar.LabelX()
        Me.lblInicial = New DevComponents.DotNetBar.LabelX()
        Me.cbogrupo = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.chkgrupo = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.rb_standar = New System.Windows.Forms.RadioButton()
        Me.rb_sunat = New System.Windows.Forms.RadioButton()
        CType(Me.dataArticulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataKardex, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.dtiHasta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtiDesde, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dataArticulo
        '
        Me.dataArticulo.AllowUserToAddRows = False
        Me.dataArticulo.AllowUserToDeleteRows = False
        Me.dataArticulo.AllowUserToResizeColumns = False
        Me.dataArticulo.AllowUserToResizeRows = False
        Me.dataArticulo.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dataArticulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataArticulo.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dataArticulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataArticulo.DefaultCellStyle = DataGridViewCellStyle2
        Me.dataArticulo.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dataArticulo.Location = New System.Drawing.Point(321, 47)
        Me.dataArticulo.Margin = New System.Windows.Forms.Padding(4)
        Me.dataArticulo.MultiSelect = False
        Me.dataArticulo.Name = "dataArticulo"
        Me.dataArticulo.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataArticulo.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dataArticulo.RowHeadersVisible = False
        Me.dataArticulo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dataArticulo.SelectAllSignVisible = False
        Me.dataArticulo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataArticulo.ShowEditingIcon = False
        Me.dataArticulo.Size = New System.Drawing.Size(703, 164)
        Me.dataArticulo.TabIndex = 2
        '
        'lblItems
        '
        Me.lblItems.AutoSize = True
        '
        '
        '
        Me.lblItems.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblItems.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItems.Location = New System.Drawing.Point(321, 15)
        Me.lblItems.Margin = New System.Windows.Forms.Padding(4)
        Me.lblItems.Name = "lblItems"
        Me.lblItems.Size = New System.Drawing.Size(60, 18)
        Me.lblItems.TabIndex = 60
        Me.lblItems.Text = "Producto"
        '
        'dataKardex
        '
        Me.dataKardex.AllowUserToAddRows = False
        Me.dataKardex.AllowUserToDeleteRows = False
        Me.dataKardex.AllowUserToResizeColumns = False
        Me.dataKardex.AllowUserToResizeRows = False
        Me.dataKardex.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dataKardex.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataKardex.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dataKardex.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataKardex.DefaultCellStyle = DataGridViewCellStyle5
        Me.dataKardex.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dataKardex.Location = New System.Drawing.Point(0, 214)
        Me.dataKardex.Margin = New System.Windows.Forms.Padding(4)
        Me.dataKardex.Name = "dataKardex"
        Me.dataKardex.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataKardex.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dataKardex.RowHeadersVisible = False
        Me.dataKardex.SelectAllSignVisible = False
        Me.dataKardex.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dataKardex.ShowEditingIcon = False
        Me.dataKardex.Size = New System.Drawing.Size(1293, 418)
        Me.dataKardex.TabIndex = 3
        '
        'txtBuscar
        '
        '
        '
        '
        Me.txtBuscar.Border.Class = "TextBoxBorder"
        Me.txtBuscar.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtBuscar.FocusHighlightEnabled = True
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(392, 11)
        Me.txtBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(208, 23)
        Me.txtBuscar.TabIndex = 0
        '
        'chkProduccion
        '
        Me.chkProduccion.AutoSize = True
        '
        '
        '
        Me.chkProduccion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chkProduccion.Checked = True
        Me.chkProduccion.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkProduccion.CheckValue = "Y"
        Me.chkProduccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkProduccion.Location = New System.Drawing.Point(636, 15)
        Me.chkProduccion.Margin = New System.Windows.Forms.Padding(4)
        Me.chkProduccion.Name = "chkProduccion"
        Me.chkProduccion.Size = New System.Drawing.Size(78, 18)
        Me.chkProduccion.TabIndex = 71
        Me.chkProduccion.Text = "Articulos"
        '
        'cboAlmacen
        '
        Me.cboAlmacen.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboAlmacen.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cboAlmacen.DisplayMember = "Text"
        Me.cboAlmacen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboAlmacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAlmacen.FocusHighlightEnabled = True
        Me.cboAlmacen.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAlmacen.ForeColor = System.Drawing.Color.Black
        Me.cboAlmacen.FormattingEnabled = True
        Me.cboAlmacen.ItemHeight = 15
        Me.cboAlmacen.Location = New System.Drawing.Point(739, 11)
        Me.cboAlmacen.Margin = New System.Windows.Forms.Padding(4)
        Me.cboAlmacen.Name = "cboAlmacen"
        Me.cboAlmacen.Size = New System.Drawing.Size(211, 21)
        Me.cboAlmacen.TabIndex = 87
        Me.cboAlmacen.WatermarkColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'chkDia
        '
        Me.chkDia.AutoSize = True
        '
        '
        '
        Me.chkDia.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chkDia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDia.Location = New System.Drawing.Point(31, 92)
        Me.chkDia.Margin = New System.Windows.Forms.Padding(4)
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
        Me.GroupBox5.Location = New System.Drawing.Point(16, 101)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Size = New System.Drawing.Size(297, 92)
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
        Me.dtiHasta.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dtiHasta.Enabled = False
        Me.dtiHasta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.dtiHasta.IsInputReadOnly = True
        Me.dtiHasta.IsPopupCalendarOpen = False
        Me.dtiHasta.Location = New System.Drawing.Point(68, 58)
        Me.dtiHasta.Margin = New System.Windows.Forms.Padding(4)
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
        Me.dtiDesde.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtiDesde.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dtiDesde.Enabled = False
        Me.dtiDesde.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.dtiDesde.IsInputReadOnly = True
        Me.dtiDesde.IsPopupCalendarOpen = False
        Me.dtiDesde.Location = New System.Drawing.Point(68, 26)
        Me.dtiDesde.Margin = New System.Windows.Forms.Padding(4)
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
        Me.LabelX1.Margin = New System.Windows.Forms.Padding(4)
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
        Me.LabelX2.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(41, 19)
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
        Me.GroupPanel1.Location = New System.Drawing.Point(16, 15)
        Me.GroupPanel1.Margin = New System.Windows.Forms.Padding(4)
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
        Me.GroupPanel1.TabIndex = 125
        Me.GroupPanel1.Text = "Periodo de Reporte"
        '
        'cboAnno
        '
        Me.cboAnno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAnno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAnno.FormattingEnabled = True
        Me.cboAnno.Items.AddRange(New Object() {"2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025"})
        Me.cboAnno.Location = New System.Drawing.Point(176, 7)
        Me.cboAnno.Margin = New System.Windows.Forms.Padding(4)
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
        Me.cboMes.Margin = New System.Windows.Forms.Padding(4)
        Me.cboMes.Name = "cboMes"
        Me.cboMes.Size = New System.Drawing.Size(151, 28)
        Me.cboMes.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(-88, 201)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(1412, 12)
        Me.GroupBox3.TabIndex = 128
        Me.GroupBox3.TabStop = False
        '
        'lblRegistros
        '
        '
        '
        '
        Me.lblRegistros.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblRegistros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistros.ForeColor = System.Drawing.Color.Green
        Me.lblRegistros.Location = New System.Drawing.Point(923, 9)
        Me.lblRegistros.Margin = New System.Windows.Forms.Padding(4)
        Me.lblRegistros.Name = "lblRegistros"
        Me.lblRegistros.Size = New System.Drawing.Size(297, 25)
        Me.lblRegistros.TabIndex = 135
        Me.lblRegistros.Text = "Nº de Registros Procesados... "
        Me.lblRegistros.TextAlignment = System.Drawing.StringAlignment.Far
        Me.lblRegistros.WordWrap = True
        '
        'lblPrecioPromedio
        '
        '
        '
        '
        Me.lblPrecioPromedio.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblPrecioPromedio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecioPromedio.ForeColor = System.Drawing.Color.Maroon
        Me.lblPrecioPromedio.Location = New System.Drawing.Point(477, 10)
        Me.lblPrecioPromedio.Margin = New System.Windows.Forms.Padding(4)
        Me.lblPrecioPromedio.Name = "lblPrecioPromedio"
        Me.lblPrecioPromedio.Size = New System.Drawing.Size(260, 23)
        Me.lblPrecioPromedio.TabIndex = 136
        Me.lblPrecioPromedio.Text = "Precio Costo Promedio. 0.000"
        Me.lblPrecioPromedio.TextAlignment = System.Drawing.StringAlignment.Center
        Me.lblPrecioPromedio.WordWrap = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkIncIGV)
        Me.GroupBox1.Controls.Add(Me.lblPrecioPromedio)
        Me.GroupBox1.Controls.Add(Me.lblRegistros)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.GroupBox1.Location = New System.Drawing.Point(3, 630)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(1229, 37)
        Me.GroupBox1.TabIndex = 137
        Me.GroupBox1.TabStop = False
        '
        'chkIncIGV
        '
        Me.chkIncIGV.AutoSize = True
        '
        '
        '
        Me.chkIncIGV.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chkIncIGV.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkIncIGV.Location = New System.Drawing.Point(11, 12)
        Me.chkIncIGV.Margin = New System.Windows.Forms.Padding(4)
        Me.chkIncIGV.Name = "chkIncIGV"
        Me.chkIncIGV.Size = New System.Drawing.Size(220, 18)
        Me.chkIncIGV.TabIndex = 137
        Me.chkIncIGV.TabStop = False
        Me.chkIncIGV.Text = "Mostrar Precios CON Impuesto"
        Me.chkIncIGV.TextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdImprimir.Appearance.Options.UseFont = True
        Me.cmdImprimir.Image = Global.cefe.My.Resources.Resources.print_preview
        Me.cmdImprimir.ImageLocation = DevExpress.DXCore.Controls.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdImprimir.Location = New System.Drawing.Point(1040, 44)
        Me.cmdImprimir.LookAndFeel.SkinName = "iMaginary"
        Me.cmdImprimir.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(107, 42)
        Me.cmdImprimir.TabIndex = 4
        Me.cmdImprimir.Text = "Imprimir"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.cefe.My.Resources.Resources.buscar20
        Me.PictureBox2.Location = New System.Drawing.Point(601, 11)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 86
        Me.PictureBox2.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LabelX7)
        Me.GroupBox2.Controls.Add(Me.LabelX5)
        Me.GroupBox2.Controls.Add(Me.LabelX4)
        Me.GroupBox2.Controls.Add(Me.lblSalidas)
        Me.GroupBox2.Controls.Add(Me.LabelX3)
        Me.GroupBox2.Controls.Add(Me.lblStock)
        Me.GroupBox2.Controls.Add(Me.lblIngresos)
        Me.GroupBox2.Controls.Add(Me.lblInicial)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.Desktop
        Me.GroupBox2.Location = New System.Drawing.Point(1036, 85)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(179, 122)
        Me.GroupBox2.TabIndex = 138
        Me.GroupBox2.TabStop = False
        '
        'LabelX7
        '
        Me.LabelX7.AutoSize = True
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX7.ForeColor = System.Drawing.Color.Maroon
        Me.LabelX7.Location = New System.Drawing.Point(15, 97)
        Me.LabelX7.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(48, 18)
        Me.LabelX7.TabIndex = 146
        Me.LabelX7.Text = "Stock..."
        Me.LabelX7.WordWrap = True
        '
        'LabelX5
        '
        Me.LabelX5.AutoSize = True
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX5.ForeColor = System.Drawing.Color.Maroon
        Me.LabelX5.Location = New System.Drawing.Point(15, 71)
        Me.LabelX5.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(59, 18)
        Me.LabelX5.TabIndex = 145
        Me.LabelX5.Text = "Salidas..."
        Me.LabelX5.WordWrap = True
        '
        'LabelX4
        '
        Me.LabelX4.AutoSize = True
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.ForeColor = System.Drawing.Color.Maroon
        Me.LabelX4.Location = New System.Drawing.Point(15, 43)
        Me.LabelX4.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(67, 18)
        Me.LabelX4.TabIndex = 143
        Me.LabelX4.Text = "Ingresos..."
        Me.LabelX4.WordWrap = True
        '
        'lblSalidas
        '
        '
        '
        '
        Me.lblSalidas.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblSalidas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalidas.ForeColor = System.Drawing.Color.Maroon
        Me.lblSalidas.Location = New System.Drawing.Point(79, 71)
        Me.lblSalidas.Margin = New System.Windows.Forms.Padding(4)
        Me.lblSalidas.Name = "lblSalidas"
        Me.lblSalidas.Size = New System.Drawing.Size(85, 18)
        Me.lblSalidas.TabIndex = 142
        Me.lblSalidas.Text = "0.00"
        Me.lblSalidas.TextAlignment = System.Drawing.StringAlignment.Far
        Me.lblSalidas.WordWrap = True
        '
        'LabelX3
        '
        Me.LabelX3.AutoSize = True
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.ForeColor = System.Drawing.Color.Maroon
        Me.LabelX3.Location = New System.Drawing.Point(15, 17)
        Me.LabelX3.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(49, 18)
        Me.LabelX3.TabIndex = 141
        Me.LabelX3.Text = "Inicial..."
        Me.LabelX3.WordWrap = True
        '
        'lblStock
        '
        '
        '
        '
        Me.lblStock.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStock.ForeColor = System.Drawing.Color.Maroon
        Me.lblStock.Location = New System.Drawing.Point(79, 98)
        Me.lblStock.Margin = New System.Windows.Forms.Padding(4)
        Me.lblStock.Name = "lblStock"
        Me.lblStock.Size = New System.Drawing.Size(85, 18)
        Me.lblStock.TabIndex = 140
        Me.lblStock.Text = "0.00"
        Me.lblStock.TextAlignment = System.Drawing.StringAlignment.Far
        Me.lblStock.WordWrap = True
        '
        'lblIngresos
        '
        '
        '
        '
        Me.lblIngresos.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblIngresos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIngresos.ForeColor = System.Drawing.Color.Maroon
        Me.lblIngresos.Location = New System.Drawing.Point(79, 43)
        Me.lblIngresos.Margin = New System.Windows.Forms.Padding(4)
        Me.lblIngresos.Name = "lblIngresos"
        Me.lblIngresos.Size = New System.Drawing.Size(85, 18)
        Me.lblIngresos.TabIndex = 138
        Me.lblIngresos.Text = "0.00"
        Me.lblIngresos.TextAlignment = System.Drawing.StringAlignment.Far
        Me.lblIngresos.WordWrap = True
        '
        'lblInicial
        '
        '
        '
        '
        Me.lblInicial.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblInicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInicial.ForeColor = System.Drawing.Color.Maroon
        Me.lblInicial.Location = New System.Drawing.Point(79, 16)
        Me.lblInicial.Margin = New System.Windows.Forms.Padding(4)
        Me.lblInicial.Name = "lblInicial"
        Me.lblInicial.Size = New System.Drawing.Size(85, 18)
        Me.lblInicial.TabIndex = 137
        Me.lblInicial.Text = "0.00"
        Me.lblInicial.TextAlignment = System.Drawing.StringAlignment.Far
        Me.lblInicial.WordWrap = True
        '
        'cbogrupo
        '
        Me.cbogrupo.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbogrupo.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbogrupo.DisplayMember = "Text"
        Me.cbogrupo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbogrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbogrupo.Enabled = False
        Me.cbogrupo.FocusHighlightEnabled = True
        Me.cbogrupo.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbogrupo.ForeColor = System.Drawing.Color.Black
        Me.cbogrupo.FormattingEnabled = True
        Me.cbogrupo.ItemHeight = 16
        Me.cbogrupo.Location = New System.Drawing.Point(1037, 11)
        Me.cbogrupo.Margin = New System.Windows.Forms.Padding(4)
        Me.cbogrupo.Name = "cbogrupo"
        Me.cbogrupo.Size = New System.Drawing.Size(256, 22)
        Me.cbogrupo.TabIndex = 140
        Me.cbogrupo.WatermarkColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'chkgrupo
        '
        Me.chkgrupo.AutoSize = True
        '
        '
        '
        Me.chkgrupo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chkgrupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkgrupo.Location = New System.Drawing.Point(961, 15)
        Me.chkgrupo.Margin = New System.Windows.Forms.Padding(4)
        Me.chkgrupo.Name = "chkgrupo"
        Me.chkgrupo.Size = New System.Drawing.Size(79, 18)
        Me.chkgrupo.TabIndex = 139
        Me.chkgrupo.Text = "CuentaC"
        '
        'rb_standar
        '
        Me.rb_standar.AutoSize = True
        Me.rb_standar.Checked = True
        Me.rb_standar.ForeColor = System.Drawing.Color.DarkBlue
        Me.rb_standar.Location = New System.Drawing.Point(1156, 44)
        Me.rb_standar.Margin = New System.Windows.Forms.Padding(4)
        Me.rb_standar.Name = "rb_standar"
        Me.rb_standar.Size = New System.Drawing.Size(141, 21)
        Me.rb_standar.TabIndex = 141
        Me.rb_standar.TabStop = True
        Me.rb_standar.Text = " Resumen Kardex"
        Me.rb_standar.UseVisualStyleBackColor = True
        '
        'rb_sunat
        '
        Me.rb_sunat.AutoSize = True
        Me.rb_sunat.ForeColor = System.Drawing.Color.DarkBlue
        Me.rb_sunat.Location = New System.Drawing.Point(1156, 69)
        Me.rb_sunat.Margin = New System.Windows.Forms.Padding(4)
        Me.rb_sunat.Name = "rb_sunat"
        Me.rb_sunat.Size = New System.Drawing.Size(132, 21)
        Me.rb_sunat.TabIndex = 142
        Me.rb_sunat.Text = "Formato SUNAT"
        Me.rb_sunat.UseVisualStyleBackColor = True
        '
        'c_kardex
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(1299, 671)
        Me.Controls.Add(Me.rb_sunat)
        Me.Controls.Add(Me.rb_standar)
        Me.Controls.Add(Me.cbogrupo)
        Me.Controls.Add(Me.cmdImprimir)
        Me.Controls.Add(Me.chkgrupo)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.dataKardex)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.chkDia)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.dataArticulo)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Controls.Add(Me.cboAlmacen)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.chkProduccion)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.lblItems)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "c_kardex"
        Me.Text = "Consulta y Reporte: KARDEX DE PRODUCTOS"
        CType(Me.dataArticulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataKardex, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.dtiHasta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtiDesde, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dataArticulo As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents lblItems As DevComponents.DotNetBar.LabelX
    Friend WithEvents dataKardex As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents txtBuscar As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents cmdImprimir As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents chkProduccion As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents cboAlmacen As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents chkDia As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents dtiHasta As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents dtiDesde As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents cboAnno As System.Windows.Forms.ComboBox
    Friend WithEvents cboMes As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblRegistros As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblPrecioPromedio As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkIncIGV As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblIngresos As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblInicial As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblStock As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblSalidas As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cbogrupo As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents chkgrupo As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents rb_standar As RadioButton
    Friend WithEvents rb_sunat As RadioButton
End Class
