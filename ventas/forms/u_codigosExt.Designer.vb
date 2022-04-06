<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class u_codigosExt
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(u_codigosExt))
        Me.txtBuscarGeneral = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.cmdImprimir = New DevComponents.DotNetBar.ButtonX
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.datos = New DevComponents.DotNetBar.Controls.DataGridViewX
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.optCodigoExterno = New System.Windows.Forms.RadioButton
        Me.optDescripcionGeneral = New System.Windows.Forms.RadioButton
        Me.optCodigoGeneral = New System.Windows.Forms.RadioButton
        Me.cboAlmacen = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.lblAlmacen = New DevComponents.DotNetBar.LabelX
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.chkGrupo = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.cboGrupo = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.lblRegistros = New DevComponents.DotNetBar.LabelX
        Me.dataReceta = New DevComponents.DotNetBar.Controls.DataGridViewX
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lblReceta = New DevComponents.DotNetBar.LabelX
        Me.PictureBox5 = New System.Windows.Forms.PictureBox
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.optOrdenTipo = New System.Windows.Forms.RadioButton
        Me.optOrdenProducto = New System.Windows.Forms.RadioButton
        Me.optOrdenExterno = New System.Windows.Forms.RadioButton
        Me.optOrdenCodigo = New System.Windows.Forms.RadioButton
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dataReceta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtBuscarGeneral
        '
        '
        '
        '
        Me.txtBuscarGeneral.Border.Class = "TextBoxBorder"
        Me.txtBuscarGeneral.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtBuscarGeneral.FocusHighlightEnabled = True
        Me.txtBuscarGeneral.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscarGeneral.Location = New System.Drawing.Point(247, 50)
        Me.txtBuscarGeneral.Name = "txtBuscarGeneral"
        Me.txtBuscarGeneral.Size = New System.Drawing.Size(104, 21)
        Me.txtBuscarGeneral.TabIndex = 2
        '
        'cmdImprimir
        '
        Me.cmdImprimir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdImprimir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdImprimir.Image = Global.cefe.My.Resources.Resources.print_preview
        Me.cmdImprimir.Location = New System.Drawing.Point(881, 4)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.cmdImprimir.Size = New System.Drawing.Size(80, 34)
        Me.cmdImprimir.TabIndex = 131
        Me.cmdImprimir.Text = "Imprimir"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.cefe.My.Resources.Resources.buscar18
        Me.PictureBox2.Location = New System.Drawing.Point(352, 52)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(18, 18)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 130
        Me.PictureBox2.TabStop = False
        '
        'datos
        '
        Me.datos.AllowUserToAddRows = False
        Me.datos.AllowUserToDeleteRows = False
        Me.datos.AllowUserToResizeColumns = False
        Me.datos.AllowUserToResizeRows = False
        Me.datos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
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
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datos.DefaultCellStyle = DataGridViewCellStyle2
        Me.datos.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.datos.Location = New System.Drawing.Point(0, 76)
        Me.datos.MultiSelect = False
        Me.datos.Name = "datos"
        Me.datos.RowHeadersVisible = False
        Me.datos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.datos.SelectAllSignVisible = False
        Me.datos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.datos.ShowEditingIcon = False
        Me.datos.Size = New System.Drawing.Size(580, 454)
        Me.datos.TabIndex = 3
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox4.Controls.Add(Me.optCodigoExterno)
        Me.GroupBox4.Controls.Add(Me.optDescripcionGeneral)
        Me.GroupBox4.Controls.Add(Me.optCodigoGeneral)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox4.Location = New System.Drawing.Point(5, 40)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(242, 34)
        Me.GroupBox4.TabIndex = 127
        Me.GroupBox4.TabStop = False
        '
        'optCodigoExterno
        '
        Me.optCodigoExterno.AutoSize = True
        Me.optCodigoExterno.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optCodigoExterno.ForeColor = System.Drawing.Color.Black
        Me.optCodigoExterno.Location = New System.Drawing.Point(73, 12)
        Me.optCodigoExterno.Name = "optCodigoExterno"
        Me.optCodigoExterno.Size = New System.Drawing.Size(66, 18)
        Me.optCodigoExterno.TabIndex = 2
        Me.optCodigoExterno.Text = "Cód.Ext"
        Me.optCodigoExterno.UseVisualStyleBackColor = True
        '
        'optDescripcionGeneral
        '
        Me.optDescripcionGeneral.AutoSize = True
        Me.optDescripcionGeneral.Checked = True
        Me.optDescripcionGeneral.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optDescripcionGeneral.ForeColor = System.Drawing.Color.Black
        Me.optDescripcionGeneral.Location = New System.Drawing.Point(146, 12)
        Me.optDescripcionGeneral.Name = "optDescripcionGeneral"
        Me.optDescripcionGeneral.Size = New System.Drawing.Size(90, 18)
        Me.optDescripcionGeneral.TabIndex = 1
        Me.optDescripcionGeneral.TabStop = True
        Me.optDescripcionGeneral.Text = "Descripción"
        Me.optDescripcionGeneral.UseVisualStyleBackColor = True
        '
        'optCodigoGeneral
        '
        Me.optCodigoGeneral.AutoSize = True
        Me.optCodigoGeneral.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optCodigoGeneral.ForeColor = System.Drawing.Color.Black
        Me.optCodigoGeneral.Location = New System.Drawing.Point(7, 11)
        Me.optCodigoGeneral.Name = "optCodigoGeneral"
        Me.optCodigoGeneral.Size = New System.Drawing.Size(64, 18)
        Me.optCodigoGeneral.TabIndex = 0
        Me.optCodigoGeneral.Text = "Código"
        Me.optCodigoGeneral.UseVisualStyleBackColor = True
        '
        'cboAlmacen
        '
        Me.cboAlmacen.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboAlmacen.DisplayMember = "Text"
        Me.cboAlmacen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboAlmacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAlmacen.FocusHighlightColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.cboAlmacen.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAlmacen.ForeColor = System.Drawing.Color.Black
        Me.cboAlmacen.FormattingEnabled = True
        Me.cboAlmacen.ItemHeight = 16
        Me.cboAlmacen.Location = New System.Drawing.Point(55, 11)
        Me.cboAlmacen.Name = "cboAlmacen"
        Me.cboAlmacen.Size = New System.Drawing.Size(153, 22)
        Me.cboAlmacen.TabIndex = 137
        Me.cboAlmacen.WatermarkColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'lblAlmacen
        '
        Me.lblAlmacen.AutoSize = True
        '
        '
        '
        Me.lblAlmacen.BackgroundStyle.Class = ""
        Me.lblAlmacen.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblAlmacen.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlmacen.ForeColor = System.Drawing.Color.Maroon
        Me.lblAlmacen.Location = New System.Drawing.Point(6, 15)
        Me.lblAlmacen.Name = "lblAlmacen"
        Me.lblAlmacen.Size = New System.Drawing.Size(48, 15)
        Me.lblAlmacen.TabIndex = 138
        Me.lblAlmacen.Text = "Almacén"
        Me.lblAlmacen.TextAlignment = System.Drawing.StringAlignment.Center
        Me.lblAlmacen.WordWrap = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(-16, 34)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1050, 10)
        Me.GroupBox3.TabIndex = 139
        Me.GroupBox3.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.chkGrupo)
        Me.GroupBox1.Controls.Add(Me.cboGrupo)
        Me.GroupBox1.Controls.Add(Me.cboAlmacen)
        Me.GroupBox1.Controls.Add(Me.lblAlmacen)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(5, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(458, 38)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'chkGrupo
        '
        Me.chkGrupo.AutoSize = True
        '
        '
        '
        Me.chkGrupo.BackgroundStyle.Class = ""
        Me.chkGrupo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chkGrupo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkGrupo.Location = New System.Drawing.Point(214, 14)
        Me.chkGrupo.Name = "chkGrupo"
        Me.chkGrupo.Size = New System.Drawing.Size(65, 15)
        Me.chkGrupo.TabIndex = 144
        Me.chkGrupo.Text = "x Grupo"
        Me.chkGrupo.TextColor = System.Drawing.Color.Maroon
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
        Me.cboGrupo.ForeColor = System.Drawing.Color.Black
        Me.cboGrupo.FormattingEnabled = True
        Me.cboGrupo.ItemHeight = 15
        Me.cboGrupo.Location = New System.Drawing.Point(279, 11)
        Me.cboGrupo.Name = "cboGrupo"
        Me.cboGrupo.Size = New System.Drawing.Size(170, 21)
        Me.cboGrupo.TabIndex = 139
        Me.cboGrupo.WatermarkColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'lblRegistros
        '
        '
        '
        '
        Me.lblRegistros.BackgroundStyle.Class = ""
        Me.lblRegistros.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblRegistros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistros.ForeColor = System.Drawing.Color.Green
        Me.lblRegistros.Location = New System.Drawing.Point(378, 51)
        Me.lblRegistros.Name = "lblRegistros"
        Me.lblRegistros.Size = New System.Drawing.Size(156, 18)
        Me.lblRegistros.TabIndex = 141
        Me.lblRegistros.Text = "Nº de Registros... "
        Me.lblRegistros.TextAlignment = System.Drawing.StringAlignment.Far
        Me.lblRegistros.WordWrap = True
        '
        'dataReceta
        '
        Me.dataReceta.AllowUserToAddRows = False
        Me.dataReceta.AllowUserToDeleteRows = False
        Me.dataReceta.AllowUserToResizeColumns = False
        Me.dataReceta.AllowUserToResizeRows = False
        Me.dataReceta.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dataReceta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataReceta.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dataReceta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataReceta.DefaultCellStyle = DataGridViewCellStyle4
        Me.dataReceta.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dataReceta.Location = New System.Drawing.Point(580, 76)
        Me.dataReceta.MultiSelect = False
        Me.dataReceta.Name = "dataReceta"
        Me.dataReceta.ReadOnly = True
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataReceta.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dataReceta.RowHeadersVisible = False
        Me.dataReceta.SelectAllSignVisible = False
        Me.dataReceta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataReceta.ShowEditingIcon = False
        Me.dataReceta.Size = New System.Drawing.Size(387, 454)
        Me.dataReceta.StandardTab = True
        Me.dataReceta.TabIndex = 143
        Me.dataReceta.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblReceta)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox2.Location = New System.Drawing.Point(537, 42)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(429, 31)
        Me.GroupBox2.TabIndex = 144
        Me.GroupBox2.TabStop = False
        '
        'lblReceta
        '
        '
        '
        '
        Me.lblReceta.BackgroundStyle.Class = ""
        Me.lblReceta.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblReceta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReceta.Location = New System.Drawing.Point(8, 8)
        Me.lblReceta.Name = "lblReceta"
        Me.lblReceta.Size = New System.Drawing.Size(412, 18)
        Me.lblReceta.TabIndex = 0
        Me.lblReceta.Text = "RECETA: "
        Me.lblReceta.TextAlignment = System.Drawing.StringAlignment.Center
        Me.lblReceta.WordWrap = True
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(556, 15)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox5.TabIndex = 150
        Me.PictureBox5.TabStop = False
        '
        'LabelX5
        '
        Me.LabelX5.AutoSize = True
        '
        '
        '
        Me.LabelX5.BackgroundStyle.Class = ""
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX5.ForeColor = System.Drawing.Color.Maroon
        Me.LabelX5.Location = New System.Drawing.Point(508, 14)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(48, 16)
        Me.LabelX5.TabIndex = 149
        Me.LabelX5.Text = "Ordenar"
        Me.LabelX5.TextAlignment = System.Drawing.StringAlignment.Center
        Me.LabelX5.WordWrap = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.optOrdenTipo)
        Me.GroupBox7.Controls.Add(Me.optOrdenProducto)
        Me.GroupBox7.Controls.Add(Me.optOrdenExterno)
        Me.GroupBox7.Controls.Add(Me.optOrdenCodigo)
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox7.Location = New System.Drawing.Point(580, 4)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(295, 32)
        Me.GroupBox7.TabIndex = 148
        Me.GroupBox7.TabStop = False
        '
        'optOrdenTipo
        '
        Me.optOrdenTipo.AutoSize = True
        Me.optOrdenTipo.Checked = True
        Me.optOrdenTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optOrdenTipo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.optOrdenTipo.Location = New System.Drawing.Point(243, 10)
        Me.optOrdenTipo.Name = "optOrdenTipo"
        Me.optOrdenTipo.Size = New System.Drawing.Size(46, 17)
        Me.optOrdenTipo.TabIndex = 5
        Me.optOrdenTipo.TabStop = True
        Me.optOrdenTipo.Text = "Tipo"
        Me.optOrdenTipo.UseVisualStyleBackColor = True
        '
        'optOrdenProducto
        '
        Me.optOrdenProducto.AutoSize = True
        Me.optOrdenProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optOrdenProducto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.optOrdenProducto.Location = New System.Drawing.Point(173, 10)
        Me.optOrdenProducto.Name = "optOrdenProducto"
        Me.optOrdenProducto.Size = New System.Drawing.Size(68, 17)
        Me.optOrdenProducto.TabIndex = 4
        Me.optOrdenProducto.Text = "Producto"
        Me.optOrdenProducto.UseVisualStyleBackColor = True
        '
        'optOrdenExterno
        '
        Me.optOrdenExterno.AutoSize = True
        Me.optOrdenExterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optOrdenExterno.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.optOrdenExterno.Location = New System.Drawing.Point(70, 10)
        Me.optOrdenExterno.Name = "optOrdenExterno"
        Me.optOrdenExterno.Size = New System.Drawing.Size(97, 17)
        Me.optOrdenExterno.TabIndex = 2
        Me.optOrdenExterno.Text = "Código Externo"
        Me.optOrdenExterno.UseVisualStyleBackColor = True
        '
        'optOrdenCodigo
        '
        Me.optOrdenCodigo.AutoSize = True
        Me.optOrdenCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optOrdenCodigo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.optOrdenCodigo.Location = New System.Drawing.Point(8, 10)
        Me.optOrdenCodigo.Name = "optOrdenCodigo"
        Me.optOrdenCodigo.Size = New System.Drawing.Size(58, 17)
        Me.optOrdenCodigo.TabIndex = 0
        Me.optOrdenCodigo.Text = "Código"
        Me.optOrdenCodigo.UseVisualStyleBackColor = True
        '
        'u_codigosExt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(967, 530)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdImprimir)
        Me.Controls.Add(Me.lblRegistros)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.LabelX5)
        Me.Controls.Add(Me.datos)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.dataReceta)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.txtBuscarGeneral)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "u_codigosExt"
        Me.Text = "Utilidad: REGISTRO DE CODIGO EXTERNO DE ARTICULOS PARA IMPORTACION"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dataReceta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtBuscarGeneral As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents cmdImprimir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents datos As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents optDescripcionGeneral As System.Windows.Forms.RadioButton
    Friend WithEvents optCodigoGeneral As System.Windows.Forms.RadioButton
    Friend WithEvents cboAlmacen As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents lblAlmacen As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cboGrupo As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents lblRegistros As DevComponents.DotNetBar.LabelX
    Friend WithEvents chkGrupo As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents dataReceta As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblReceta As DevComponents.DotNetBar.LabelX
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents optOrdenProducto As System.Windows.Forms.RadioButton
    Friend WithEvents optOrdenExterno As System.Windows.Forms.RadioButton
    Friend WithEvents optOrdenCodigo As System.Windows.Forms.RadioButton
    Friend WithEvents optOrdenTipo As System.Windows.Forms.RadioButton
    Friend WithEvents optCodigoExterno As System.Windows.Forms.RadioButton

End Class
