<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class p_mermas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(p_mermas))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.mcFBaja = New DevComponents.Editors.DateTimeAdv.MonthCalendarAdv()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboAlmacen = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.lblArea = New DevComponents.DotNetBar.LabelX()
        Me.cboArea = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.cboBaja = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.cboDocumento = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.txtBuscar = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cmdBaja = New DevExpress.DXCore.Controls.XtraEditors.SimpleButton()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.txtBaja = New System.Windows.Forms.TextBox()
        Me.dataBajas = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.dataArticulos = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chkProduccion = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.lblRegistros = New DevComponents.DotNetBar.LabelX()
        Me.cmdImprimir = New DevExpress.DXCore.Controls.XtraEditors.SimpleButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblRegistros2 = New DevComponents.DotNetBar.LabelX()
        Me.txtObservacion = New System.Windows.Forms.RichTextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataBajas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'mcFBaja
        '
        Me.mcFBaja.AnnuallyMarkedDates = New Date(-1) {}
        Me.mcFBaja.AutoSize = True
        '
        '
        '
        Me.mcFBaja.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.mcFBaja.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.mcFBaja.BackgroundStyle.BorderBottomWidth = 1
        Me.mcFBaja.BackgroundStyle.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.mcFBaja.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.mcFBaja.BackgroundStyle.BorderLeftWidth = 1
        Me.mcFBaja.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.mcFBaja.BackgroundStyle.BorderRightWidth = 1
        Me.mcFBaja.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.mcFBaja.BackgroundStyle.BorderTopWidth = 1
        Me.mcFBaja.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.mcFBaja.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.mcFBaja.ContainerControlProcessDialogKey = True
        Me.mcFBaja.DisplayMonth = New Date(2010, 10, 1, 0, 0, 0, 0)
        Me.mcFBaja.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.mcFBaja.Location = New System.Drawing.Point(7, 9)
        Me.mcFBaja.MarkedDates = New Date(-1) {}
        Me.mcFBaja.MaxDate = New Date(2020, 12, 31, 0, 0, 0, 0)
        Me.mcFBaja.MinDate = New Date(2010, 1, 1, 0, 0, 0, 0)
        Me.mcFBaja.MonthlyMarkedDates = New Date(-1) {}
        Me.mcFBaja.Name = "mcFBaja"
        '
        '
        '
        Me.mcFBaja.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.mcFBaja.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.mcFBaja.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.mcFBaja.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.mcFBaja.Size = New System.Drawing.Size(170, 131)
        Me.mcFBaja.TabIndex = 13
        Me.mcFBaja.Text = "MonthCalendarAdv1"
        Me.mcFBaja.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboAlmacen)
        Me.GroupBox1.Controls.Add(Me.LabelX5)
        Me.GroupBox1.Controls.Add(Me.lblArea)
        Me.GroupBox1.Controls.Add(Me.cboArea)
        Me.GroupBox1.Controls.Add(Me.cboBaja)
        Me.GroupBox1.Controls.Add(Me.LabelX1)
        Me.GroupBox1.Controls.Add(Me.cboDocumento)
        Me.GroupBox1.Controls.Add(Me.LabelX2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(181, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(234, 136)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Parámetros de Registro"
        '
        'cboAlmacen
        '
        Me.cboAlmacen.DisplayMember = "Text"
        Me.cboAlmacen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboAlmacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAlmacen.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAlmacen.ForeColor = System.Drawing.Color.Black
        Me.cboAlmacen.FormattingEnabled = True
        Me.cboAlmacen.ItemHeight = 15
        Me.cboAlmacen.Location = New System.Drawing.Point(68, 54)
        Me.cboAlmacen.Name = "cboAlmacen"
        Me.cboAlmacen.Size = New System.Drawing.Size(163, 21)
        Me.cboAlmacen.TabIndex = 101
        Me.cboAlmacen.WatermarkColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'LabelX5
        '
        Me.LabelX5.AutoSize = True
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LabelX5.Location = New System.Drawing.Point(4, 56)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(49, 16)
        Me.LabelX5.TabIndex = 170
        Me.LabelX5.Text = "Almacén"
        '
        'lblArea
        '
        Me.lblArea.AutoSize = True
        '
        '
        '
        Me.lblArea.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArea.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblArea.Location = New System.Drawing.Point(4, 85)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(55, 15)
        Me.lblArea.TabIndex = 168
        Me.lblArea.Text = "Area Prod."
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
        Me.cboArea.Location = New System.Drawing.Point(68, 81)
        Me.cboArea.Name = "cboArea"
        Me.cboArea.Size = New System.Drawing.Size(163, 21)
        Me.cboArea.TabIndex = 102
        Me.cboArea.WatermarkColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'cboBaja
        '
        Me.cboBaja.DisplayMember = "Text"
        Me.cboBaja.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboBaja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBaja.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBaja.ForeColor = System.Drawing.Color.Black
        Me.cboBaja.FormattingEnabled = True
        Me.cboBaja.ItemHeight = 15
        Me.cboBaja.Location = New System.Drawing.Point(68, 108)
        Me.cboBaja.Name = "cboBaja"
        Me.cboBaja.Size = New System.Drawing.Size(163, 21)
        Me.cboBaja.TabIndex = 103
        Me.cboBaja.WatermarkColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LabelX1.Location = New System.Drawing.Point(4, 109)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(38, 16)
        Me.LabelX1.TabIndex = 2
        Me.LabelX1.Text = "Motivo"
        '
        'cboDocumento
        '
        Me.cboDocumento.DisplayMember = "Text"
        Me.cboDocumento.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDocumento.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDocumento.ForeColor = System.Drawing.Color.Black
        Me.cboDocumento.FormattingEnabled = True
        Me.cboDocumento.ItemHeight = 15
        Me.cboDocumento.Location = New System.Drawing.Point(68, 27)
        Me.cboDocumento.Name = "cboDocumento"
        Me.cboDocumento.Size = New System.Drawing.Size(163, 21)
        Me.cboDocumento.TabIndex = 100
        Me.cboDocumento.WatermarkColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'LabelX2
        '
        Me.LabelX2.AutoSize = True
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LabelX2.Location = New System.Drawing.Point(4, 29)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(64, 16)
        Me.LabelX2.TabIndex = 0
        Me.LabelX2.Text = "Documento"
        '
        'LabelX4
        '
        Me.LabelX4.AutoSize = True
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LabelX4.Location = New System.Drawing.Point(9, 11)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(86, 16)
        Me.LabelX4.TabIndex = 0
        Me.LabelX4.Text = "Ingrese Artículo"
        Me.LabelX4.WordWrap = True
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
        Me.txtBuscar.Location = New System.Drawing.Point(101, 10)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(158, 20)
        Me.txtBuscar.TabIndex = 1
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.cefe.My.Resources.Resources.buscar18
        Me.PictureBox2.Location = New System.Drawing.Point(261, 11)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(18, 18)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 93
        Me.PictureBox2.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.cmdBaja)
        Me.GroupBox2.Controls.Add(Me.LabelX3)
        Me.GroupBox2.Controls.Add(Me.txtBaja)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox2.Location = New System.Drawing.Point(875, -2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(74, 169)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(29, 55)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(18, 18)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 92
        Me.PictureBox1.TabStop = False
        '
        'cmdBaja
        '
        Me.cmdBaja.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmdBaja.Appearance.Options.UseFont = True
        Me.cmdBaja.Image = Global.cefe.My.Resources.Resources.Error22
        Me.cmdBaja.ImageLocation = DevExpress.DXCore.Controls.XtraEditors.ImageLocation.TopCenter
        Me.cmdBaja.Location = New System.Drawing.Point(7, 110)
        Me.cmdBaja.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdBaja.Name = "cmdBaja"
        Me.cmdBaja.Size = New System.Drawing.Size(60, 49)
        Me.cmdBaja.TabIndex = 2
        Me.cmdBaja.Text = "Baja"
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.Location = New System.Drawing.Point(3, 14)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(68, 36)
        Me.LabelX3.TabIndex = 0
        Me.LabelX3.Text = "Cantidad a dar de Baja"
        Me.LabelX3.TextAlignment = System.Drawing.StringAlignment.Center
        Me.LabelX3.WordWrap = True
        '
        'txtBaja
        '
        Me.txtBaja.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBaja.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBaja.ForeColor = System.Drawing.Color.Black
        Me.txtBaja.Location = New System.Drawing.Point(7, 77)
        Me.txtBaja.MaxLength = 0
        Me.txtBaja.Name = "txtBaja"
        Me.txtBaja.Size = New System.Drawing.Size(60, 22)
        Me.txtBaja.TabIndex = 1
        '
        'dataBajas
        '
        Me.dataBajas.AllowUserToAddRows = False
        Me.dataBajas.AllowUserToDeleteRows = False
        Me.dataBajas.AllowUserToResizeColumns = False
        Me.dataBajas.AllowUserToResizeRows = False
        Me.dataBajas.BackgroundColor = System.Drawing.Color.White
        Me.dataBajas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataBajas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dataBajas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataBajas.DefaultCellStyle = DataGridViewCellStyle2
        Me.dataBajas.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dataBajas.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dataBajas.Location = New System.Drawing.Point(0, 215)
        Me.dataBajas.MultiSelect = False
        Me.dataBajas.Name = "dataBajas"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataBajas.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dataBajas.RowHeadersVisible = False
        Me.dataBajas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dataBajas.SelectAllSignVisible = False
        Me.dataBajas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dataBajas.ShowEditingIcon = False
        Me.dataBajas.Size = New System.Drawing.Size(953, 315)
        Me.dataBajas.TabIndex = 84
        '
        'dataArticulos
        '
        Me.dataArticulos.AllowUserToAddRows = False
        Me.dataArticulos.AllowUserToDeleteRows = False
        Me.dataArticulos.AllowUserToResizeColumns = False
        Me.dataArticulos.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dataArticulos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dataArticulos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dataArticulos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataArticulos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dataArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataArticulos.DefaultCellStyle = DataGridViewCellStyle6
        Me.dataArticulos.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dataArticulos.Location = New System.Drawing.Point(419, 34)
        Me.dataArticulos.MultiSelect = False
        Me.dataArticulos.Name = "dataArticulos"
        Me.dataArticulos.ReadOnly = True
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataArticulos.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dataArticulos.RowHeadersVisible = False
        Me.dataArticulos.SelectAllSignVisible = False
        Me.dataArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataArticulos.ShowEditingIcon = False
        Me.dataArticulos.Size = New System.Drawing.Size(450, 171)
        Me.dataArticulos.StandardTab = True
        Me.dataArticulos.TabIndex = 2
        Me.dataArticulos.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chkProduccion)
        Me.GroupBox3.Controls.Add(Me.lblRegistros)
        Me.GroupBox3.Controls.Add(Me.LabelX4)
        Me.GroupBox3.Controls.Add(Me.txtBuscar)
        Me.GroupBox3.Controls.Add(Me.PictureBox2)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox3.Location = New System.Drawing.Point(419, -2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(450, 35)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
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
        Me.chkProduccion.Location = New System.Drawing.Point(285, 14)
        Me.chkProduccion.Name = "chkProduccion"
        Me.chkProduccion.Size = New System.Drawing.Size(67, 15)
        Me.chkProduccion.TabIndex = 1042
        Me.chkProduccion.Text = "Articulos"
        '
        'lblRegistros
        '
        '
        '
        '
        Me.lblRegistros.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblRegistros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistros.ForeColor = System.Drawing.Color.Green
        Me.lblRegistros.Location = New System.Drawing.Point(360, 11)
        Me.lblRegistros.Name = "lblRegistros"
        Me.lblRegistros.Size = New System.Drawing.Size(95, 19)
        Me.lblRegistros.TabIndex = 120
        Me.lblRegistros.Text = "Nº de Registros..."
        Me.lblRegistros.TextAlignment = System.Drawing.StringAlignment.Far
        Me.lblRegistros.WordWrap = True
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdImprimir.Appearance.Options.UseFont = True
        Me.cmdImprimir.Image = CType(resources.GetObject("cmdImprimir.Image"), System.Drawing.Image)
        Me.cmdImprimir.ImageLocation = DevExpress.DXCore.Controls.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdImprimir.Location = New System.Drawing.Point(23, 147)
        Me.cmdImprimir.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(140, 31)
        Me.cmdImprimir.TabIndex = 98
        Me.cmdImprimir.Text = "Imprimir Bajas del día"
        '
        'GroupBox4
        '
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(-53, 202)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1059, 10)
        Me.GroupBox4.TabIndex = 99
        Me.GroupBox4.TabStop = False
        '
        'lblRegistros2
        '
        '
        '
        '
        Me.lblRegistros2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblRegistros2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistros2.ForeColor = System.Drawing.Color.Green
        Me.lblRegistros2.Location = New System.Drawing.Point(7, 180)
        Me.lblRegistros2.Name = "lblRegistros2"
        Me.lblRegistros2.Size = New System.Drawing.Size(170, 19)
        Me.lblRegistros2.TabIndex = 121
        Me.lblRegistros2.Text = "Nº de Registros..."
        Me.lblRegistros2.TextAlignment = System.Drawing.StringAlignment.Center
        Me.lblRegistros2.WordWrap = True
        '
        'txtObservacion
        '
        Me.txtObservacion.Location = New System.Drawing.Point(185, 147)
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Size = New System.Drawing.Size(230, 37)
        Me.txtObservacion.TabIndex = 122
        Me.txtObservacion.Text = ""
        '
        'p_mermas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(953, 530)
        Me.Controls.Add(Me.txtObservacion)
        Me.Controls.Add(Me.lblRegistros2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.dataArticulos)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.cmdImprimir)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.mcFBaja)
        Me.Controls.Add(Me.dataBajas)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "p_mermas"
        Me.Text = "Proceso: REGISTRO DE MERMAS, BAJAS Y OTROS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataBajas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mcFBaja As DevComponents.Editors.DateTimeAdv.MonthCalendarAdv
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cboDocumento As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtBuscar As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents cmdBaja As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents txtBaja As System.Windows.Forms.TextBox
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dataBajas As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cboBaja As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dataArticulos As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cmdImprimir As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents lblRegistros As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblRegistros2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtObservacion As System.Windows.Forms.RichTextBox
    Friend WithEvents lblArea As DevComponents.DotNetBar.LabelX
    Friend WithEvents cboArea As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cboAlmacen As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents chkProduccion As DevComponents.DotNetBar.Controls.CheckBoxX
End Class
