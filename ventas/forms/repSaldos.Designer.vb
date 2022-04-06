<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class repSaldos
    Inherits cefe.baseReporte

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(repSaldos))
        Me.chkResumen = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.cboAnno = New System.Windows.Forms.ComboBox()
        Me.cboMes = New System.Windows.Forms.ComboBox()
        Me.dataStock = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.txtBuscar = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.optDescripcion = New System.Windows.Forms.RadioButton()
        Me.optCodigo = New System.Windows.Forms.RadioButton()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.cmdImprimir = New DevComponents.DotNetBar.ButtonX()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.cmdCerrar = New DevComponents.DotNetBar.ButtonX()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.chkArea = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.cboArea = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.chksubgrupo = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.cbosubgrupo = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.cboAlmacen = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.lblRegistros = New DevComponents.DotNetBar.LabelX()
        Me.TabControl2 = New DevComponents.DotNetBar.TabControl()
        Me.TabControlPanel4 = New DevComponents.DotNetBar.TabControlPanel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dataDocumentos = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.tabStock = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel1 = New DevComponents.DotNetBar.TabControlPanel()
        Me.dataStockG = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.tabStockG = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel5 = New DevComponents.DotNetBar.TabControlPanel()
        Me.barraProgreso = New System.Windows.Forms.ProgressBar()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.optValorizado = New System.Windows.Forms.RadioButton()
        Me.optCantidades = New System.Windows.Forms.RadioButton()
        Me.dataResumen = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.tabResumen = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.CircularProgress1 = New DevComponents.DotNetBar.Controls.CircularProgress()
        Me.tabRecetas = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.btnprocesar = New System.Windows.Forms.Button()
        Me.chksaldo = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.cmdPromedio = New DevComponents.DotNetBar.ButtonX()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupPanel1.SuspendLayout()
        CType(Me.dataStock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.TabControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl2.SuspendLayout()
        Me.TabControlPanel4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dataDocumentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlPanel1.SuspendLayout()
        CType(Me.dataStockG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlPanel5.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.dataResumen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkResumen
        '
        Me.chkResumen.AutoSize = True
        '
        '
        '
        Me.chkResumen.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chkResumen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkResumen.Location = New System.Drawing.Point(1032, 118)
        Me.chkResumen.Margin = New System.Windows.Forms.Padding(4)
        Me.chkResumen.Name = "chkResumen"
        Me.chkResumen.Size = New System.Drawing.Size(150, 18)
        Me.chkResumen.TabIndex = 139
        Me.chkResumen.TabStop = False
        Me.chkResumen.Text = "Resumen Valorizado"
        Me.chkResumen.TextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.cboAnno)
        Me.GroupPanel1.Controls.Add(Me.cboMes)
        Me.GroupPanel1.Location = New System.Drawing.Point(13, 11)
        Me.GroupPanel1.Margin = New System.Windows.Forms.Padding(4)
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
        Me.GroupPanel1.TabIndex = 0
        Me.GroupPanel1.Text = "Fecha de Reporte"
        '
        'cboAnno
        '
        Me.cboAnno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAnno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAnno.FormattingEnabled = True
        Me.cboAnno.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cboAnno.Items.AddRange(New Object() {"2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025"})
        Me.cboAnno.Location = New System.Drawing.Point(143, 6)
        Me.cboAnno.Margin = New System.Windows.Forms.Padding(4)
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
        Me.cboMes.Margin = New System.Windows.Forms.Padding(4)
        Me.cboMes.Name = "cboMes"
        Me.cboMes.Size = New System.Drawing.Size(124, 25)
        Me.cboMes.TabIndex = 0
        '
        'dataStock
        '
        Me.dataStock.AllowUserToAddRows = False
        Me.dataStock.AllowUserToDeleteRows = False
        Me.dataStock.AllowUserToResizeColumns = False
        Me.dataStock.AllowUserToResizeRows = False
        Me.dataStock.BackgroundColor = System.Drawing.Color.White
        Me.dataStock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataStock.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dataStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataStock.DefaultCellStyle = DataGridViewCellStyle2
        Me.dataStock.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dataStock.Location = New System.Drawing.Point(1, 10)
        Me.dataStock.Margin = New System.Windows.Forms.Padding(4)
        Me.dataStock.Name = "dataStock"
        Me.dataStock.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataStock.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dataStock.RowHeadersVisible = False
        Me.dataStock.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dataStock.SelectAllSignVisible = False
        Me.dataStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataStock.ShowEditingIcon = False
        Me.dataStock.Size = New System.Drawing.Size(767, 517)
        Me.dataStock.TabIndex = 5
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
        Me.txtBuscar.Location = New System.Drawing.Point(349, 107)
        Me.txtBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(299, 24)
        Me.txtBuscar.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optDescripcion)
        Me.GroupBox1.Controls.Add(Me.optCodigo)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(129, 95)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(549, 42)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'optDescripcion
        '
        Me.optDescripcion.AutoSize = True
        Me.optDescripcion.Checked = True
        Me.optDescripcion.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optDescripcion.ForeColor = System.Drawing.Color.Black
        Me.optDescripcion.Location = New System.Drawing.Point(97, 14)
        Me.optDescripcion.Margin = New System.Windows.Forms.Padding(4)
        Me.optDescripcion.Name = "optDescripcion"
        Me.optDescripcion.Size = New System.Drawing.Size(103, 20)
        Me.optDescripcion.TabIndex = 1
        Me.optDescripcion.TabStop = True
        Me.optDescripcion.Text = "Descripción"
        Me.optDescripcion.UseVisualStyleBackColor = True
        '
        'optCodigo
        '
        Me.optCodigo.AutoSize = True
        Me.optCodigo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optCodigo.ForeColor = System.Drawing.Color.Black
        Me.optCodigo.Location = New System.Drawing.Point(12, 14)
        Me.optCodigo.Margin = New System.Windows.Forms.Padding(4)
        Me.optCodigo.Name = "optCodigo"
        Me.optCodigo.Size = New System.Drawing.Size(74, 20)
        Me.optCodigo.TabIndex = 0
        Me.optCodigo.Text = "Código"
        Me.optCodigo.UseVisualStyleBackColor = True
        '
        'LabelX3
        '
        Me.LabelX3.AutoSize = True
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.ForeColor = System.Drawing.Color.Maroon
        Me.LabelX3.Location = New System.Drawing.Point(56, 110)
        Me.LabelX3.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(61, 19)
        Me.LabelX3.TabIndex = 97
        Me.LabelX3.Text = "Buscar x"
        Me.LabelX3.TextAlignment = System.Drawing.StringAlignment.Center
        Me.LabelX3.WordWrap = True
        '
        'cmdImprimir
        '
        Me.cmdImprimir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdImprimir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdImprimir.Image = Global.cefe.My.Resources.Resources.print_preview
        Me.cmdImprimir.Location = New System.Drawing.Point(1207, 15)
        Me.cmdImprimir.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.cmdImprimir.Size = New System.Drawing.Size(107, 44)
        Me.cmdImprimir.TabIndex = 6
        Me.cmdImprimir.Text = "Imprimir"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.cefe.My.Resources.Resources.buscar18
        Me.PictureBox2.Location = New System.Drawing.Point(648, 110)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(18, 18)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 95
        Me.PictureBox2.TabStop = False
        '
        'cmdCerrar
        '
        Me.cmdCerrar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdCerrar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCerrar.Image = Global.cefe.My.Resources.Resources.CLOSE22
        Me.cmdCerrar.Location = New System.Drawing.Point(1207, 85)
        Me.cmdCerrar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdCerrar.Name = "cmdCerrar"
        Me.cmdCerrar.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.cmdCerrar.Size = New System.Drawing.Size(107, 44)
        Me.cmdCerrar.TabIndex = 20
        Me.cmdCerrar.Text = "Cerrar"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.chkArea)
        Me.GroupBox4.Controls.Add(Me.cboArea)
        Me.GroupBox4.Controls.Add(Me.LabelX1)
        Me.GroupBox4.Controls.Add(Me.chksubgrupo)
        Me.GroupBox4.Controls.Add(Me.cbosubgrupo)
        Me.GroupBox4.Controls.Add(Me.cboAlmacen)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox4.Location = New System.Drawing.Point(265, 10)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(709, 87)
        Me.GroupBox4.TabIndex = 127
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Parámetros de Consulta"
        '
        'chkArea
        '
        Me.chkArea.AutoSize = True
        '
        '
        '
        Me.chkArea.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chkArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkArea.Location = New System.Drawing.Point(224, 22)
        Me.chkArea.Margin = New System.Windows.Forms.Padding(4)
        Me.chkArea.Name = "chkArea"
        Me.chkArea.Size = New System.Drawing.Size(62, 18)
        Me.chkArea.TabIndex = 144
        Me.chkArea.TabStop = False
        Me.chkArea.Text = "x Area"
        Me.chkArea.TextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        '
        'cboArea
        '
        Me.cboArea.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboArea.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cboArea.DisplayMember = "Text"
        Me.cboArea.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboArea.Enabled = False
        Me.cboArea.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboArea.ForeColor = System.Drawing.Color.Black
        Me.cboArea.FormattingEnabled = True
        Me.cboArea.ItemHeight = 14
        Me.cboArea.Location = New System.Drawing.Point(228, 44)
        Me.cboArea.Margin = New System.Windows.Forms.Padding(4)
        Me.cboArea.Name = "cboArea"
        Me.cboArea.Size = New System.Drawing.Size(212, 20)
        Me.cboArea.TabIndex = 143
        Me.cboArea.WatermarkColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
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
        Me.LabelX1.Location = New System.Drawing.Point(8, 21)
        Me.LabelX1.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(61, 19)
        Me.LabelX1.TabIndex = 142
        Me.LabelX1.Text = "Almacén"
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Center
        Me.LabelX1.WordWrap = True
        '
        'chksubgrupo
        '
        Me.chksubgrupo.AutoSize = True
        '
        '
        '
        Me.chksubgrupo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chksubgrupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chksubgrupo.Location = New System.Drawing.Point(451, 22)
        Me.chksubgrupo.Margin = New System.Windows.Forms.Padding(4)
        Me.chksubgrupo.Name = "chksubgrupo"
        Me.chksubgrupo.Size = New System.Drawing.Size(71, 18)
        Me.chksubgrupo.TabIndex = 129
        Me.chksubgrupo.TabStop = False
        Me.chksubgrupo.Text = "x Grupo"
        Me.chksubgrupo.TextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        '
        'cbosubgrupo
        '
        Me.cbosubgrupo.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbosubgrupo.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbosubgrupo.DisplayMember = "Text"
        Me.cbosubgrupo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbosubgrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbosubgrupo.Enabled = False
        Me.cbosubgrupo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbosubgrupo.ForeColor = System.Drawing.Color.Black
        Me.cbosubgrupo.FormattingEnabled = True
        Me.cbosubgrupo.ItemHeight = 14
        Me.cbosubgrupo.Location = New System.Drawing.Point(455, 44)
        Me.cbosubgrupo.Margin = New System.Windows.Forms.Padding(4)
        Me.cbosubgrupo.Name = "cbosubgrupo"
        Me.cbosubgrupo.Size = New System.Drawing.Size(212, 20)
        Me.cbosubgrupo.TabIndex = 0
        Me.cbosubgrupo.WatermarkColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'cboAlmacen
        '
        Me.cboAlmacen.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboAlmacen.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cboAlmacen.DisplayMember = "Text"
        Me.cboAlmacen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboAlmacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAlmacen.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAlmacen.ForeColor = System.Drawing.Color.Black
        Me.cboAlmacen.FormattingEnabled = True
        Me.cboAlmacen.ItemHeight = 14
        Me.cboAlmacen.Location = New System.Drawing.Point(8, 46)
        Me.cboAlmacen.Margin = New System.Windows.Forms.Padding(4)
        Me.cboAlmacen.Name = "cboAlmacen"
        Me.cboAlmacen.Size = New System.Drawing.Size(211, 20)
        Me.cboAlmacen.TabIndex = 0
        Me.cboAlmacen.WatermarkColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'lblRegistros
        '
        '
        '
        '
        Me.lblRegistros.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblRegistros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistros.ForeColor = System.Drawing.Color.Green
        Me.lblRegistros.Location = New System.Drawing.Point(13, 73)
        Me.lblRegistros.Margin = New System.Windows.Forms.Padding(4)
        Me.lblRegistros.Name = "lblRegistros"
        Me.lblRegistros.Size = New System.Drawing.Size(240, 25)
        Me.lblRegistros.TabIndex = 139
        Me.lblRegistros.Text = "Nº de Registros... "
        Me.lblRegistros.TextAlignment = System.Drawing.StringAlignment.Center
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
        Me.TabControl2.Controls.Add(Me.TabControlPanel5)
        Me.TabControl2.Controls.Add(Me.TabControlPanel1)
        Me.TabControl2.Controls.Add(Me.TabControlPanel4)
        Me.TabControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TabControl2.Location = New System.Drawing.Point(0, 138)
        Me.TabControl2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TabControl2.SelectedTabIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(1357, 535)
        Me.TabControl2.Style = DevComponents.DotNetBar.eTabStripStyle.VS2005Document
        Me.TabControl2.TabIndex = 141
        Me.TabControl2.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
        Me.TabControl2.Tabs.Add(Me.tabStock)
        Me.TabControl2.Tabs.Add(Me.tabStockG)
        Me.TabControl2.Tabs.Add(Me.tabResumen)
        Me.TabControl2.Text = "Precio de Costo Vs. Precio de Venta"
        '
        'TabControlPanel4
        '
        Me.TabControlPanel4.Controls.Add(Me.GroupBox3)
        Me.TabControlPanel4.Controls.Add(Me.dataStock)
        Me.TabControlPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel4.Location = New System.Drawing.Point(0, 26)
        Me.TabControlPanel4.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControlPanel4.Name = "TabControlPanel4"
        Me.TabControlPanel4.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel4.Size = New System.Drawing.Size(1357, 509)
        Me.TabControlPanel4.Style.BackColor1.Color = System.Drawing.Color.White
        Me.TabControlPanel4.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabControlPanel4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel4.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.TabControlPanel4.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel4.Style.GradientAngle = 90
        Me.TabControlPanel4.TabIndex = 1
        Me.TabControlPanel4.TabItem = Me.tabStock
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.dataDocumentos)
        Me.GroupBox3.Controls.Add(Me.GroupBox2)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(772, 2)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(580, 486)
        Me.GroupBox3.TabIndex = 129
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Documentos de Compra y/o Ingreso"
        '
        'dataDocumentos
        '
        Me.dataDocumentos.AllowUserToAddRows = False
        Me.dataDocumentos.AllowUserToDeleteRows = False
        Me.dataDocumentos.AllowUserToResizeColumns = False
        Me.dataDocumentos.AllowUserToResizeRows = False
        Me.dataDocumentos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dataDocumentos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dataDocumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataDocumentos.DefaultCellStyle = DataGridViewCellStyle10
        Me.dataDocumentos.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dataDocumentos.Location = New System.Drawing.Point(7, 20)
        Me.dataDocumentos.Margin = New System.Windows.Forms.Padding(4)
        Me.dataDocumentos.MultiSelect = False
        Me.dataDocumentos.Name = "dataDocumentos"
        Me.dataDocumentos.ReadOnly = True
        Me.dataDocumentos.RowHeadersVisible = False
        Me.dataDocumentos.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dataDocumentos.SelectAllSignVisible = False
        Me.dataDocumentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataDocumentos.ShowEditingIcon = False
        Me.dataDocumentos.Size = New System.Drawing.Size(567, 459)
        Me.dataDocumentos.TabIndex = 6
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox2.Location = New System.Drawing.Point(68, 71)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(261, 86)
        Me.GroupBox2.TabIndex = 128
        Me.GroupBox2.TabStop = False
        '
        'tabStock
        '
        Me.tabStock.AttachedControl = Me.TabControlPanel4
        Me.tabStock.Icon = CType(resources.GetObject("tabStock.Icon"), System.Drawing.Icon)
        Me.tabStock.Name = "tabStock"
        Me.tabStock.Text = "Stock de Productos"
        '
        'TabControlPanel1
        '
        Me.TabControlPanel1.Controls.Add(Me.dataStockG)
        Me.TabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel1.Location = New System.Drawing.Point(0, 26)
        Me.TabControlPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControlPanel1.Name = "TabControlPanel1"
        Me.TabControlPanel1.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel1.Size = New System.Drawing.Size(1357, 509)
        Me.TabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.White
        Me.TabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.TabControlPanel1.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel1.Style.GradientAngle = 90
        Me.TabControlPanel1.TabIndex = 3
        Me.TabControlPanel1.TabItem = Me.tabStockG
        '
        'dataStockG
        '
        Me.dataStockG.AllowUserToAddRows = False
        Me.dataStockG.AllowUserToDeleteRows = False
        Me.dataStockG.AllowUserToResizeColumns = False
        Me.dataStockG.AllowUserToResizeRows = False
        Me.dataStockG.BackgroundColor = System.Drawing.Color.White
        Me.dataStockG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataStockG.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dataStockG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataStockG.DefaultCellStyle = DataGridViewCellStyle8
        Me.dataStockG.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dataStockG.Location = New System.Drawing.Point(3, 10)
        Me.dataStockG.Margin = New System.Windows.Forms.Padding(4)
        Me.dataStockG.MultiSelect = False
        Me.dataStockG.Name = "dataStockG"
        Me.dataStockG.ReadOnly = True
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataStockG.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dataStockG.RowHeadersVisible = False
        Me.dataStockG.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dataStockG.SelectAllSignVisible = False
        Me.dataStockG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataStockG.ShowEditingIcon = False
        Me.dataStockG.Size = New System.Drawing.Size(767, 517)
        Me.dataStockG.TabIndex = 6
        '
        'tabStockG
        '
        Me.tabStockG.AttachedControl = Me.TabControlPanel1
        Me.tabStockG.Name = "tabStockG"
        Me.tabStockG.Text = "Resumen x Grupo"
        '
        'TabControlPanel5
        '
        Me.TabControlPanel5.Controls.Add(Me.barraProgreso)
        Me.TabControlPanel5.Controls.Add(Me.GroupBox5)
        Me.TabControlPanel5.Controls.Add(Me.dataResumen)
        Me.TabControlPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel5.Location = New System.Drawing.Point(0, 26)
        Me.TabControlPanel5.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControlPanel5.Name = "TabControlPanel5"
        Me.TabControlPanel5.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel5.Size = New System.Drawing.Size(1357, 509)
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
        'barraProgreso
        '
        Me.barraProgreso.Location = New System.Drawing.Point(273, 7)
        Me.barraProgreso.Margin = New System.Windows.Forms.Padding(4)
        Me.barraProgreso.Name = "barraProgreso"
        Me.barraProgreso.Size = New System.Drawing.Size(317, 26)
        Me.barraProgreso.TabIndex = 143
        Me.barraProgreso.Visible = False
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.White
        Me.GroupBox5.Controls.Add(Me.optValorizado)
        Me.GroupBox5.Controls.Add(Me.optCantidades)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.Black
        Me.GroupBox5.Location = New System.Drawing.Point(4, -6)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Size = New System.Drawing.Size(248, 44)
        Me.GroupBox5.TabIndex = 142
        Me.GroupBox5.TabStop = False
        '
        'optValorizado
        '
        Me.optValorizado.AutoSize = True
        Me.optValorizado.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optValorizado.ForeColor = System.Drawing.Color.Black
        Me.optValorizado.Location = New System.Drawing.Point(133, 15)
        Me.optValorizado.Margin = New System.Windows.Forms.Padding(4)
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
        Me.optCantidades.Margin = New System.Windows.Forms.Padding(4)
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
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataResumen.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dataResumen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataResumen.DefaultCellStyle = DataGridViewCellStyle5
        Me.dataResumen.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dataResumen.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dataResumen.Location = New System.Drawing.Point(1, 18)
        Me.dataResumen.Margin = New System.Windows.Forms.Padding(4)
        Me.dataResumen.MultiSelect = False
        Me.dataResumen.Name = "dataResumen"
        Me.dataResumen.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataResumen.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dataResumen.RowHeadersVisible = False
        Me.dataResumen.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dataResumen.SelectAllSignVisible = False
        Me.dataResumen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataResumen.ShowEditingIcon = False
        Me.dataResumen.Size = New System.Drawing.Size(1355, 490)
        Me.dataResumen.TabIndex = 6
        '
        'tabResumen
        '
        Me.tabResumen.AttachedControl = Me.TabControlPanel5
        Me.tabResumen.Icon = CType(resources.GetObject("tabResumen.Icon"), System.Drawing.Icon)
        Me.tabResumen.Name = "tabResumen"
        Me.tabResumen.Text = "Resumen Anual"
        '
        'CircularProgress1
        '
        '
        '
        '
        Me.CircularProgress1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.CircularProgress1.Location = New System.Drawing.Point(1100, 15)
        Me.CircularProgress1.Margin = New System.Windows.Forms.Padding(4)
        Me.CircularProgress1.Name = "CircularProgress1"
        Me.CircularProgress1.Size = New System.Drawing.Size(69, 47)
        Me.CircularProgress1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP
        Me.CircularProgress1.TabIndex = 164
        '
        'tabRecetas
        '
        Me.tabRecetas.Name = "tabRecetas"
        Me.tabRecetas.Text = "Fluctuación de Precios de Costo en Recetas"
        '
        'btnprocesar
        '
        Me.btnprocesar.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprocesar.ForeColor = System.Drawing.Color.DarkRed
        Me.btnprocesar.Image = Global.cefe.My.Resources.Resources.continuar22
        Me.btnprocesar.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnprocesar.Location = New System.Drawing.Point(1312, 54)
        Me.btnprocesar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnprocesar.Name = "btnprocesar"
        Me.btnprocesar.Size = New System.Drawing.Size(40, 43)
        Me.btnprocesar.TabIndex = 161
        Me.btnprocesar.Text = "Recalcular Costo de Insumos"
        Me.btnprocesar.UseVisualStyleBackColor = True
        Me.btnprocesar.Visible = False
        '
        'chksaldo
        '
        Me.chksaldo.AutoSize = True
        '
        '
        '
        Me.chksaldo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chksaldo.Checked = True
        Me.chksaldo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chksaldo.CheckValue = "Y"
        Me.chksaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chksaldo.Location = New System.Drawing.Point(1032, 92)
        Me.chksaldo.Margin = New System.Windows.Forms.Padding(4)
        Me.chksaldo.Name = "chksaldo"
        Me.chksaldo.Size = New System.Drawing.Size(140, 18)
        Me.chksaldo.TabIndex = 162
        Me.chksaldo.TabStop = False
        Me.chksaldo.Text = "Articulos con Saldo"
        Me.chksaldo.TextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        '
        'cmdPromedio
        '
        Me.cmdPromedio.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdPromedio.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdPromedio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPromedio.Image = Global.cefe.My.Resources.Resources.ok22
        Me.cmdPromedio.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right
        Me.cmdPromedio.Location = New System.Drawing.Point(840, 105)
        Me.cmdPromedio.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdPromedio.Name = "cmdPromedio"
        Me.cmdPromedio.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10)
        Me.cmdPromedio.Size = New System.Drawing.Size(135, 44)
        Me.cmdPromedio.TabIndex = 163
        Me.cmdPromedio.Text = "Actualiza Stock"
        Me.cmdPromedio.ThemeAware = True
        '
        'repSaldos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(1357, 673)
        Me.Controls.Add(Me.CircularProgress1)
        Me.Controls.Add(Me.cmdPromedio)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.chksaldo)
        Me.Controls.Add(Me.btnprocesar)
        Me.Controls.Add(Me.cmdImprimir)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Controls.Add(Me.chkResumen)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.TabControl2)
        Me.Controls.Add(Me.lblRegistros)
        Me.Controls.Add(Me.LabelX3)
        Me.Controls.Add(Me.cmdCerrar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "repSaldos"
        Me.Text = "Consulta y Reporte: STOCKS DEL SISTEMA"
        Me.GroupPanel1.ResumeLayout(False)
        CType(Me.dataStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.TabControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl2.ResumeLayout(False)
        Me.TabControlPanel4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dataDocumentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlPanel1.ResumeLayout(False)
        CType(Me.dataStockG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlPanel5.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.dataResumen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdImprimir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmdCerrar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents cboAnno As System.Windows.Forms.ComboBox
    Friend WithEvents cboMes As System.Windows.Forms.ComboBox
    Friend WithEvents dataStock As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents txtBuscar As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents optDescripcion As System.Windows.Forms.RadioButton
    Friend WithEvents optCodigo As System.Windows.Forms.RadioButton
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents cboAlmacen As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cbosubgrupo As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents chksubgrupo As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents lblRegistros As DevComponents.DotNetBar.LabelX
    Friend WithEvents chkResumen As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents TabControl2 As DevComponents.DotNetBar.TabControl
    Friend WithEvents TabControlPanel4 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents tabStock As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabControlPanel5 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents tabResumen As DevComponents.DotNetBar.TabItem
    Friend WithEvents tabRecetas As DevComponents.DotNetBar.TabItem
    Friend WithEvents dataResumen As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents optValorizado As System.Windows.Forms.RadioButton
    Friend WithEvents optCantidades As System.Windows.Forms.RadioButton
    Friend WithEvents barraProgreso As System.Windows.Forms.ProgressBar
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dataDocumentos As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents TabControlPanel1 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents tabStockG As DevComponents.DotNetBar.TabItem
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dataStockG As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents btnprocesar As System.Windows.Forms.Button
    Friend WithEvents chksaldo As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chkArea As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents cboArea As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cmdPromedio As DevComponents.DotNetBar.ButtonX
    Friend WithEvents CircularProgress1 As DevComponents.DotNetBar.Controls.CircularProgress
    Friend WithEvents Timer1 As Timer
End Class
