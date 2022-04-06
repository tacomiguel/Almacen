<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class m_rendimiento
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
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.cboAlmacen = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.dataLimpios = New DevComponents.DotNetBar.Controls.DataGridViewX
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.txtBuscar = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.optDescripcion = New System.Windows.Forms.RadioButton
        Me.optCodigo = New System.Windows.Forms.RadioButton
        Me.txtNuevaCantidad = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX
        Me.TextBoxX1 = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.dataCatalogo = New DevComponents.DotNetBar.Controls.DataGridViewX
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.cmdInsertar = New DevExpress.DXCore.Controls.XtraEditors.SimpleButton
        Me.lblProducto = New DevComponents.DotNetBar.LabelX
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX
        CType(Me.dataLimpios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataCatalogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboAlmacen
        '
        Me.cboAlmacen.DisplayMember = "Text"
        Me.cboAlmacen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboAlmacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAlmacen.FocusHighlightColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.cboAlmacen.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAlmacen.ForeColor = System.Drawing.Color.Black
        Me.cboAlmacen.FormattingEnabled = True
        Me.cboAlmacen.ItemHeight = 16
        Me.cboAlmacen.Location = New System.Drawing.Point(61, 12)
        Me.cboAlmacen.Name = "cboAlmacen"
        Me.cboAlmacen.Size = New System.Drawing.Size(143, 22)
        Me.cboAlmacen.TabIndex = 139
        Me.cboAlmacen.WatermarkColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'dataLimpios
        '
        Me.dataLimpios.AllowUserToAddRows = False
        Me.dataLimpios.AllowUserToDeleteRows = False
        Me.dataLimpios.AllowUserToResizeColumns = False
        Me.dataLimpios.AllowUserToResizeRows = False
        Me.dataLimpios.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dataLimpios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataLimpios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dataLimpios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataLimpios.DefaultCellStyle = DataGridViewCellStyle9
        Me.dataLimpios.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dataLimpios.Location = New System.Drawing.Point(9, 41)
        Me.dataLimpios.MultiSelect = False
        Me.dataLimpios.Name = "dataLimpios"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataLimpios.RowHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dataLimpios.RowHeadersVisible = False
        Me.dataLimpios.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dataLimpios.SelectAllSignVisible = False
        Me.dataLimpios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dataLimpios.ShowEditingIcon = False
        Me.dataLimpios.Size = New System.Drawing.Size(480, 442)
        Me.dataLimpios.TabIndex = 138
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.cefe.My.Resources.Resources.buscar18
        Me.PictureBox1.Location = New System.Drawing.Point(467, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(18, 18)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 141
        Me.PictureBox1.TabStop = False
        '
        'txtBuscar
        '
        '
        '
        '
        Me.txtBuscar.Border.Class = "TextBoxBorder"
        Me.txtBuscar.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtBuscar.FocusHighlightColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.txtBuscar.FocusHighlightEnabled = True
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(371, 14)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(93, 21)
        Me.txtBuscar.TabIndex = 137
        '
        'LabelX2
        '
        Me.LabelX2.AutoSize = True
        '
        '
        '
        Me.LabelX2.BackgroundStyle.Class = ""
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.ForeColor = System.Drawing.Color.Maroon
        Me.LabelX2.Location = New System.Drawing.Point(9, 14)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(51, 16)
        Me.LabelX2.TabIndex = 142
        Me.LabelX2.Text = "Almacén"
        Me.LabelX2.TextAlignment = System.Drawing.StringAlignment.Center
        Me.LabelX2.WordWrap = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optDescripcion)
        Me.GroupBox1.Controls.Add(Me.optCodigo)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(208, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(162, 34)
        Me.GroupBox1.TabIndex = 140
        Me.GroupBox1.TabStop = False
        '
        'optDescripcion
        '
        Me.optDescripcion.AutoSize = True
        Me.optDescripcion.Checked = True
        Me.optDescripcion.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optDescripcion.ForeColor = System.Drawing.Color.Black
        Me.optDescripcion.Location = New System.Drawing.Point(70, 11)
        Me.optDescripcion.Name = "optDescripcion"
        Me.optDescripcion.Size = New System.Drawing.Size(90, 18)
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
        Me.optCodigo.Location = New System.Drawing.Point(7, 11)
        Me.optCodigo.Name = "optCodigo"
        Me.optCodigo.Size = New System.Drawing.Size(64, 18)
        Me.optCodigo.TabIndex = 0
        Me.optCodigo.Text = "Código"
        Me.optCodigo.UseVisualStyleBackColor = True
        '
        'txtNuevaCantidad
        '
        Me.txtNuevaCantidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.txtNuevaCantidad.Border.Class = "TextBoxBorder"
        Me.txtNuevaCantidad.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNuevaCantidad.FocusHighlightEnabled = True
        Me.txtNuevaCantidad.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNuevaCantidad.Location = New System.Drawing.Point(758, 405)
        Me.txtNuevaCantidad.Name = "txtNuevaCantidad"
        Me.txtNuevaCantidad.Size = New System.Drawing.Size(62, 21)
        Me.txtNuevaCantidad.TabIndex = 144
        '
        'LabelX4
        '
        Me.LabelX4.AutoSize = True
        '
        '
        '
        Me.LabelX4.BackgroundStyle.Class = ""
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.ForeColor = System.Drawing.Color.Green
        Me.LabelX4.Location = New System.Drawing.Point(571, 407)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(183, 16)
        Me.LabelX4.TabIndex = 143
        Me.LabelX4.Text = "Rendimiento del Producto limpio"
        '
        'TextBoxX1
        '
        Me.TextBoxX1.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.TextBoxX1.Border.Class = "TextBoxBorder"
        Me.TextBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxX1.FocusHighlightEnabled = True
        Me.TextBoxX1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxX1.Location = New System.Drawing.Point(635, 18)
        Me.TextBoxX1.Name = "TextBoxX1"
        Me.TextBoxX1.Size = New System.Drawing.Size(269, 21)
        Me.TextBoxX1.TabIndex = 147
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.cefe.My.Resources.Resources.buscar18
        Me.PictureBox3.Location = New System.Drawing.Point(908, 19)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(18, 18)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 150
        Me.PictureBox3.TabStop = False
        '
        'dataCatalogo
        '
        Me.dataCatalogo.AllowUserToAddRows = False
        Me.dataCatalogo.AllowUserToDeleteRows = False
        Me.dataCatalogo.AllowUserToResizeColumns = False
        Me.dataCatalogo.AllowUserToResizeRows = False
        Me.dataCatalogo.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dataCatalogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dataCatalogo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataCatalogo.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dataCatalogo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataCatalogo.DefaultCellStyle = DataGridViewCellStyle12
        Me.dataCatalogo.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dataCatalogo.Location = New System.Drawing.Point(497, 42)
        Me.dataCatalogo.MultiSelect = False
        Me.dataCatalogo.Name = "dataCatalogo"
        Me.dataCatalogo.ReadOnly = True
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataCatalogo.RowHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.dataCatalogo.RowHeadersVisible = False
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dataCatalogo.RowsDefaultCellStyle = DataGridViewCellStyle14
        Me.dataCatalogo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dataCatalogo.SelectAllSignVisible = False
        Me.dataCatalogo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataCatalogo.ShowEditingIcon = False
        Me.dataCatalogo.Size = New System.Drawing.Size(435, 229)
        Me.dataCatalogo.TabIndex = 148
        '
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        '
        '
        '
        Me.LabelX1.BackgroundStyle.Class = ""
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(510, 19)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(93, 17)
        Me.LabelX1.TabIndex = 146
        Me.LabelX1.Text = "Relacionar con"
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Center
        Me.LabelX1.WordWrap = True
        '
        'cmdInsertar
        '
        Me.cmdInsertar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmdInsertar.Appearance.Options.UseFont = True
        Me.cmdInsertar.Image = Global.cefe.My.Resources.Resources.ok20
        Me.cmdInsertar.ImageLocation = DevExpress.DXCore.Controls.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdInsertar.Location = New System.Drawing.Point(825, 403)
        Me.cmdInsertar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdInsertar.Name = "cmdInsertar"
        Me.cmdInsertar.Size = New System.Drawing.Size(30, 25)
        Me.cmdInsertar.TabIndex = 145
        '
        'lblProducto
        '
        '
        '
        '
        Me.lblProducto.BackgroundStyle.Class = ""
        Me.lblProducto.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProducto.ForeColor = System.Drawing.Color.Maroon
        Me.lblProducto.Location = New System.Drawing.Point(10, 49)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(415, 18)
        Me.lblProducto.TabIndex = 89
        Me.lblProducto.Text = "Producto Limpio"
        Me.lblProducto.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.LabelX5)
        Me.GroupBox4.Controls.Add(Me.LabelX3)
        Me.GroupBox4.Controls.Add(Me.lblProducto)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(497, 277)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(435, 78)
        Me.GroupBox4.TabIndex = 151
        Me.GroupBox4.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.cefe.My.Resources.Resources.forward18
        Me.PictureBox2.Location = New System.Drawing.Point(612, 20)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(18, 18)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 149
        Me.PictureBox2.TabStop = False
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.Class = ""
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.ForeColor = System.Drawing.Color.Maroon
        Me.LabelX3.Location = New System.Drawing.Point(10, 12)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(415, 18)
        Me.LabelX3.TabIndex = 90
        Me.LabelX3.Text = "Producto Crudo"
        Me.LabelX3.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.Class = ""
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LabelX5.Location = New System.Drawing.Point(10, 30)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(415, 18)
        Me.LabelX5.TabIndex = 91
        Me.LabelX5.Text = "EQUIVALE A"
        Me.LabelX5.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'm_rendimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(940, 502)
        Me.Controls.Add(Me.txtNuevaCantidad)
        Me.Controls.Add(Me.LabelX4)
        Me.Controls.Add(Me.TextBoxX1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.dataCatalogo)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.cmdInsertar)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.cboAlmacen)
        Me.Controls.Add(Me.dataLimpios)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "m_rendimiento"
        Me.Text = "Productos Limpios: RENDIMIENTO"
        CType(Me.dataLimpios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataCatalogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboAlmacen As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents dataLimpios As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtBuscar As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents optDescripcion As System.Windows.Forms.RadioButton
    Friend WithEvents optCodigo As System.Windows.Forms.RadioButton
    Friend WithEvents txtNuevaCantidad As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TextBoxX1 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents dataCatalogo As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmdInsertar As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents lblProducto As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX

End Class
