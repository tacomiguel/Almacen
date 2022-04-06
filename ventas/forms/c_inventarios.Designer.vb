<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class c_inventarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(c_inventarios))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.cboAnno = New System.Windows.Forms.ComboBox()
        Me.cboMes = New System.Windows.Forms.ComboBox()
        Me.grupoAlmacen = New System.Windows.Forms.GroupBox()
        Me.cboAlmacen = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.chkAlmacen = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.cmdCerrar = New DevComponents.DotNetBar.ButtonX()
        Me.cmdImprimir = New DevComponents.DotNetBar.ButtonX()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.optMensual = New System.Windows.Forms.RadioButton()
        Me.optDiario = New System.Windows.Forms.RadioButton()
        Me.optInicial = New System.Windows.Forms.RadioButton()
        Me.lblRegistros = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.optDescripcion = New System.Windows.Forms.RadioButton()
        Me.optCodigo = New System.Windows.Forms.RadioButton()
        Me.txtBuscar = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.dataDetalle = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.dtiDiario = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.chkVs = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.GroupPanel1.SuspendLayout()
        Me.grupoAlmacen.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dtiDiario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(-16, 97)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(1412, 12)
        Me.GroupBox3.TabIndex = 127
        Me.GroupBox3.TabStop = False
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.cboAnno)
        Me.GroupPanel1.Controls.Add(Me.cboMes)
        Me.GroupPanel1.Location = New System.Drawing.Point(11, 9)
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
        Me.GroupPanel1.TabIndex = 0
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
        'grupoAlmacen
        '
        Me.grupoAlmacen.Controls.Add(Me.cboAlmacen)
        Me.grupoAlmacen.Controls.Add(Me.chkAlmacen)
        Me.grupoAlmacen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupoAlmacen.ForeColor = System.Drawing.Color.Maroon
        Me.grupoAlmacen.Location = New System.Drawing.Point(483, 9)
        Me.grupoAlmacen.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grupoAlmacen.Name = "grupoAlmacen"
        Me.grupoAlmacen.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grupoAlmacen.Size = New System.Drawing.Size(295, 50)
        Me.grupoAlmacen.TabIndex = 2
        Me.grupoAlmacen.TabStop = False
        '
        'cboAlmacen
        '
        Me.cboAlmacen.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboAlmacen.DisplayMember = "Text"
        Me.cboAlmacen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboAlmacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAlmacen.Enabled = False
        Me.cboAlmacen.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAlmacen.ForeColor = System.Drawing.Color.Black
        Me.cboAlmacen.FormattingEnabled = True
        Me.cboAlmacen.ItemHeight = 15
        Me.cboAlmacen.Location = New System.Drawing.Point(9, 18)
        Me.cboAlmacen.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboAlmacen.Name = "cboAlmacen"
        Me.cboAlmacen.Size = New System.Drawing.Size(275, 21)
        Me.cboAlmacen.TabIndex = 52
        Me.cboAlmacen.WatermarkColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
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
        Me.chkAlmacen.Location = New System.Drawing.Point(9, -1)
        Me.chkAlmacen.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkAlmacen.Name = "chkAlmacen"
        Me.chkAlmacen.Size = New System.Drawing.Size(78, 18)
        Me.chkAlmacen.TabIndex = 51
        Me.chkAlmacen.Text = "Almacén"
        '
        'cmdCerrar
        '
        Me.cmdCerrar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdCerrar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCerrar.Image = Global.cefe.My.Resources.Resources.CLOSE22
        Me.cmdCerrar.Location = New System.Drawing.Point(1108, 7)
        Me.cmdCerrar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdCerrar.Name = "cmdCerrar"
        Me.cmdCerrar.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.cmdCerrar.Size = New System.Drawing.Size(107, 44)
        Me.cmdCerrar.TabIndex = 125
        Me.cmdCerrar.Text = "Cerrar"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdImprimir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdImprimir.Image = Global.cefe.My.Resources.Resources.print_preview
        Me.cmdImprimir.Location = New System.Drawing.Point(1108, 57)
        Me.cmdImprimir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.cmdImprimir.Size = New System.Drawing.Size(107, 44)
        Me.cmdImprimir.TabIndex = 6
        Me.cmdImprimir.Text = "Imprimir"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.optMensual)
        Me.GroupBox2.Controls.Add(Me.optDiario)
        Me.GroupBox2.Controls.Add(Me.optInicial)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox2.Location = New System.Drawing.Point(265, 7)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(211, 94)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tipo de Reporte"
        '
        'optMensual
        '
        Me.optMensual.AutoSize = True
        Me.optMensual.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optMensual.ForeColor = System.Drawing.Color.Black
        Me.optMensual.Location = New System.Drawing.Point(13, 42)
        Me.optMensual.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.optMensual.Name = "optMensual"
        Me.optMensual.Size = New System.Drawing.Size(165, 20)
        Me.optMensual.TabIndex = 3
        Me.optMensual.Text = "Inventario Mensual"
        Me.optMensual.UseVisualStyleBackColor = True
        '
        'optDiario
        '
        Me.optDiario.AutoSize = True
        Me.optDiario.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optDiario.ForeColor = System.Drawing.Color.Black
        Me.optDiario.Location = New System.Drawing.Point(13, 65)
        Me.optDiario.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.optDiario.Name = "optDiario"
        Me.optDiario.Size = New System.Drawing.Size(146, 20)
        Me.optDiario.TabIndex = 1
        Me.optDiario.Text = "Inventario Diario"
        Me.optDiario.UseVisualStyleBackColor = True
        '
        'optInicial
        '
        Me.optInicial.AutoSize = True
        Me.optInicial.Checked = True
        Me.optInicial.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optInicial.ForeColor = System.Drawing.Color.Black
        Me.optInicial.Location = New System.Drawing.Point(13, 18)
        Me.optInicial.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.optInicial.Name = "optInicial"
        Me.optInicial.Size = New System.Drawing.Size(146, 20)
        Me.optInicial.TabIndex = 0
        Me.optInicial.TabStop = True
        Me.optInicial.Text = "Inventario Inicial"
        Me.optInicial.UseVisualStyleBackColor = True
        '
        'lblRegistros
        '
        '
        '
        '
        Me.lblRegistros.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblRegistros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistros.ForeColor = System.Drawing.Color.Green
        Me.lblRegistros.Location = New System.Drawing.Point(13, 73)
        Me.lblRegistros.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblRegistros.Name = "lblRegistros"
        Me.lblRegistros.Size = New System.Drawing.Size(245, 23)
        Me.lblRegistros.TabIndex = 134
        Me.lblRegistros.Text = "Nº de Registros..."
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
        Me.LabelX3.Location = New System.Drawing.Point(793, 28)
        Me.LabelX3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(63, 19)
        Me.LabelX3.TabIndex = 133
        Me.LabelX3.Text = "Buscar x"
        Me.LabelX3.TextAlignment = System.Drawing.StringAlignment.Center
        Me.LabelX3.WordWrap = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optDescripcion)
        Me.GroupBox1.Controls.Add(Me.optCodigo)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(861, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(224, 42)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'optDescripcion
        '
        Me.optDescripcion.AutoSize = True
        Me.optDescripcion.Checked = True
        Me.optDescripcion.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optDescripcion.ForeColor = System.Drawing.Color.Black
        Me.optDescripcion.Location = New System.Drawing.Point(99, 12)
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
        Me.optCodigo.Location = New System.Drawing.Point(12, 12)
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
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(796, 60)
        Me.txtBuscar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(257, 24)
        Me.txtBuscar.TabIndex = 4
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.cefe.My.Resources.Resources.buscar20
        Me.PictureBox2.Location = New System.Drawing.Point(1055, 60)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 132
        Me.PictureBox2.TabStop = False
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
        Me.dataDetalle.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dataDetalle.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dataDetalle.Location = New System.Drawing.Point(0, 116)
        Me.dataDetalle.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dataDetalle.MultiSelect = False
        Me.dataDetalle.Name = "dataDetalle"
        Me.dataDetalle.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataDetalle.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dataDetalle.RowHeadersVisible = False
        Me.dataDetalle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dataDetalle.SelectAllSignVisible = False
        Me.dataDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataDetalle.ShowEditingIcon = False
        Me.dataDetalle.Size = New System.Drawing.Size(1227, 544)
        Me.dataDetalle.TabIndex = 5
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.dtiDiario)
        Me.GroupBox4.Controls.Add(Me.chkVs)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox4.Location = New System.Drawing.Point(484, 54)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox4.Size = New System.Drawing.Size(293, 47)
        Me.GroupBox4.TabIndex = 135
        Me.GroupBox4.TabStop = False
        '
        'dtiDiario
        '
        '
        '
        '
        Me.dtiDiario.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dtiDiario.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtiDiario.ButtonDropDown.Visible = True
        Me.dtiDiario.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtiDiario.Enabled = False
        Me.dtiDiario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtiDiario.ForeColor = System.Drawing.Color.Black
        Me.dtiDiario.IsInputReadOnly = True
        Me.dtiDiario.IsPopupCalendarOpen = False
        Me.dtiDiario.Location = New System.Drawing.Point(171, 15)
        Me.dtiDiario.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        '
        '
        '
        Me.dtiDiario.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtiDiario.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.dtiDiario.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.dtiDiario.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dtiDiario.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dtiDiario.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dtiDiario.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dtiDiario.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dtiDiario.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dtiDiario.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtiDiario.MonthCalendar.DisplayMonth = New Date(2011, 3, 1, 0, 0, 0, 0)
        Me.dtiDiario.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.dtiDiario.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtiDiario.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dtiDiario.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dtiDiario.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dtiDiario.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtiDiario.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.dtiDiario.Name = "dtiDiario"
        Me.dtiDiario.Size = New System.Drawing.Size(113, 23)
        Me.dtiDiario.TabIndex = 120
        '
        'chkVs
        '
        Me.chkVs.AutoSize = True
        '
        '
        '
        Me.chkVs.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chkVs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkVs.Location = New System.Drawing.Point(8, 17)
        Me.chkVs.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkVs.Name = "chkVs"
        Me.chkVs.Size = New System.Drawing.Size(144, 18)
        Me.chkVs.TabIndex = 51
        Me.chkVs.Text = "Sistema Vs. Conteo"
        '
        'c_inventarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(1227, 660)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.grupoAlmacen)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.dataDetalle)
        Me.Controls.Add(Me.lblRegistros)
        Me.Controls.Add(Me.LabelX3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.cmdCerrar)
        Me.Controls.Add(Me.cmdImprimir)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "c_inventarios"
        Me.Text = "Consulta y Reportes: INVENTARIOS"
        Me.GroupPanel1.ResumeLayout(False)
        Me.grupoAlmacen.ResumeLayout(False)
        Me.grupoAlmacen.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.dtiDiario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents cboAnno As System.Windows.Forms.ComboBox
    Friend WithEvents cboMes As System.Windows.Forms.ComboBox
    Friend WithEvents grupoAlmacen As System.Windows.Forms.GroupBox
    Friend WithEvents chkAlmacen As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents cmdCerrar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmdImprimir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents optMensual As System.Windows.Forms.RadioButton
    Friend WithEvents optDiario As System.Windows.Forms.RadioButton
    Friend WithEvents optInicial As System.Windows.Forms.RadioButton
    Friend WithEvents lblRegistros As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents optDescripcion As System.Windows.Forms.RadioButton
    Friend WithEvents optCodigo As System.Windows.Forms.RadioButton
    Friend WithEvents txtBuscar As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents dataDetalle As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents cboAlmacen As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents chkVs As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents dtiDiario As DevComponents.Editors.DateTimeAdv.DateTimeInput

End Class
