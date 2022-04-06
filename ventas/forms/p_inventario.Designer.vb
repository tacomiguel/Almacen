<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class p_inventario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(p_inventario))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cmdIniciar = New DevComponents.DotNetBar.ButtonX()
        Me.dataCatalogo = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.txtBuscar = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.dataInventario = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.cboArea = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.cboAlmacen = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmdEliminar = New DevComponents.DotNetBar.ButtonX()
        Me.cmdActualizaCostos = New DevComponents.DotNetBar.ButtonX()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.optDescripcion = New System.Windows.Forms.RadioButton()
        Me.optCodigo = New System.Windows.Forms.RadioButton()
        Me.txtBuscarInventario = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.lblRegistros = New DevComponents.DotNetBar.LabelX()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.chkGrupo = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.cboGrupo = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.chkModo = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.cmdImprimir = New DevExpress.DXCore.Controls.XtraEditors.SimpleButton()
        Me.cmdCerrar = New DevExpress.DXCore.Controls.XtraEditors.SimpleButton()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.optFormatos = New System.Windows.Forms.RadioButton()
        Me.chkResumenGrupo = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.optRepAlmacen_area = New System.Windows.Forms.RadioButton()
        Me.optRepAlmacen = New System.Windows.Forms.RadioButton()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.cboAnno = New System.Windows.Forms.ComboBox()
        Me.cboMes = New System.Windows.Forms.ComboBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.ChkModoImp = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.chkBuscar = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.lblinsertar = New DevComponents.DotNetBar.LabelX()
        Me.cmdInsertar = New System.Windows.Forms.Button()
        CType(Me.dataCatalogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox8.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdIniciar
        '
        Me.cmdIniciar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdIniciar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdIniciar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdIniciar.Image = CType(resources.GetObject("cmdIniciar.Image"), System.Drawing.Image)
        Me.cmdIniciar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.cmdIniciar.Location = New System.Drawing.Point(32, 12)
        Me.cmdIniciar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdIniciar.Name = "cmdIniciar"
        Me.cmdIniciar.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.cmdIniciar.Size = New System.Drawing.Size(85, 74)
        Me.cmdIniciar.TabIndex = 54
        Me.cmdIniciar.Text = "Iniciar Inventario"
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataCatalogo.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dataCatalogo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataCatalogo.DefaultCellStyle = DataGridViewCellStyle2
        Me.dataCatalogo.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dataCatalogo.Location = New System.Drawing.Point(9, 172)
        Me.dataCatalogo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dataCatalogo.MultiSelect = False
        Me.dataCatalogo.Name = "dataCatalogo"
        Me.dataCatalogo.RowHeadersVisible = False
        Me.dataCatalogo.SelectAllSignVisible = False
        Me.dataCatalogo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataCatalogo.ShowEditingIcon = False
        Me.dataCatalogo.Size = New System.Drawing.Size(529, 494)
        Me.dataCatalogo.TabIndex = 2
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
        Me.txtBuscar.Location = New System.Drawing.Point(121, 20)
        Me.txtBuscar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(207, 24)
        Me.txtBuscar.TabIndex = 1
        '
        'dataInventario
        '
        Me.dataInventario.AllowUserToAddRows = False
        Me.dataInventario.AllowUserToDeleteRows = False
        Me.dataInventario.AllowUserToResizeColumns = False
        Me.dataInventario.AllowUserToResizeRows = False
        Me.dataInventario.BackgroundColor = System.Drawing.Color.White
        Me.dataInventario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataInventario.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dataInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataInventario.DefaultCellStyle = DataGridViewCellStyle4
        Me.dataInventario.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dataInventario.Location = New System.Drawing.Point(536, 172)
        Me.dataInventario.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dataInventario.Name = "dataInventario"
        Me.dataInventario.RowHeadersVisible = False
        Me.dataInventario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dataInventario.SelectAllSignVisible = False
        Me.dataInventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataInventario.ShowEditingIcon = False
        Me.dataInventario.Size = New System.Drawing.Size(765, 494)
        Me.dataInventario.TabIndex = 4
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.cefe.My.Resources.Resources.buscar18
        Me.PictureBox2.Location = New System.Drawing.Point(336, 22)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(18, 18)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 88
        Me.PictureBox2.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LabelX1)
        Me.GroupBox1.Controls.Add(Me.cboArea)
        Me.GroupBox1.Controls.Add(Me.cboAlmacen)
        Me.GroupBox1.Controls.Add(Me.LabelX2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(267, 6)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(333, 92)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Parámetros de Registro"
        '
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LabelX1.Location = New System.Drawing.Point(15, 60)
        Me.LabelX1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(35, 19)
        Me.LabelX1.TabIndex = 4
        Me.LabelX1.Text = "Area"
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
        Me.cboArea.Location = New System.Drawing.Point(84, 59)
        Me.cboArea.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboArea.Name = "cboArea"
        Me.cboArea.Size = New System.Drawing.Size(237, 21)
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
        Me.cboAlmacen.Location = New System.Drawing.Point(84, 26)
        Me.cboAlmacen.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboAlmacen.Name = "cboAlmacen"
        Me.cboAlmacen.Size = New System.Drawing.Size(237, 21)
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
        Me.LabelX2.Location = New System.Drawing.Point(13, 27)
        Me.LabelX2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(63, 19)
        Me.LabelX2.TabIndex = 0
        Me.LabelX2.Text = "Almacén"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmdEliminar)
        Me.GroupBox2.Controls.Add(Me.cmdIniciar)
        Me.GroupBox2.Controls.Add(Me.cmdActualizaCostos)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox2.Location = New System.Drawing.Point(612, 6)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(357, 94)
        Me.GroupBox2.TabIndex = 111
        Me.GroupBox2.TabStop = False
        '
        'cmdEliminar
        '
        Me.cmdEliminar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdEliminar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEliminar.Image = Global.cefe.My.Resources.Resources.Error_22
        Me.cmdEliminar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.cmdEliminar.Location = New System.Drawing.Point(143, 12)
        Me.cmdEliminar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.cmdEliminar.Size = New System.Drawing.Size(85, 75)
        Me.cmdEliminar.TabIndex = 55
        Me.cmdEliminar.Text = "Elminar Inventario"
        '
        'cmdActualizaCostos
        '
        Me.cmdActualizaCostos.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdActualizaCostos.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdActualizaCostos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdActualizaCostos.Image = CType(resources.GetObject("cmdActualizaCostos.Image"), System.Drawing.Image)
        Me.cmdActualizaCostos.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.cmdActualizaCostos.Location = New System.Drawing.Point(252, 12)
        Me.cmdActualizaCostos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdActualizaCostos.Name = "cmdActualizaCostos"
        Me.cmdActualizaCostos.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.cmdActualizaCostos.Size = New System.Drawing.Size(85, 75)
        Me.cmdActualizaCostos.TabIndex = 161
        Me.cmdActualizaCostos.Text = "Actualizar Costos"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.optDescripcion)
        Me.GroupBox3.Controls.Add(Me.optCodigo)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox3.Location = New System.Drawing.Point(511, 9)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(213, 42)
        Me.GroupBox3.TabIndex = 134
        Me.GroupBox3.TabStop = False
        '
        'optDescripcion
        '
        Me.optDescripcion.AutoSize = True
        Me.optDescripcion.Checked = True
        Me.optDescripcion.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optDescripcion.ForeColor = System.Drawing.Color.Black
        Me.optDescripcion.Location = New System.Drawing.Point(89, 14)
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
        Me.optCodigo.Location = New System.Drawing.Point(9, 14)
        Me.optCodigo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.optCodigo.Name = "optCodigo"
        Me.optCodigo.Size = New System.Drawing.Size(79, 20)
        Me.optCodigo.TabIndex = 0
        Me.optCodigo.Text = "Código"
        Me.optCodigo.UseVisualStyleBackColor = True
        '
        'txtBuscarInventario
        '
        '
        '
        '
        Me.txtBuscarInventario.Border.Class = "TextBoxBorder"
        Me.txtBuscarInventario.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtBuscarInventario.FocusHighlightEnabled = True
        Me.txtBuscarInventario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscarInventario.Location = New System.Drawing.Point(729, 18)
        Me.txtBuscarInventario.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtBuscarInventario.Name = "txtBuscarInventario"
        Me.txtBuscarInventario.Size = New System.Drawing.Size(159, 24)
        Me.txtBuscarInventario.TabIndex = 2
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(893, 21)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(18, 18)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 136
        Me.PictureBox3.TabStop = False
        '
        'lblRegistros
        '
        '
        '
        '
        Me.lblRegistros.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblRegistros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistros.ForeColor = System.Drawing.Color.Green
        Me.lblRegistros.Location = New System.Drawing.Point(9, 78)
        Me.lblRegistros.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblRegistros.Name = "lblRegistros"
        Me.lblRegistros.Size = New System.Drawing.Size(245, 23)
        Me.lblRegistros.TabIndex = 141
        Me.lblRegistros.Text = "Nº de Registros..."
        Me.lblRegistros.TextAlignment = System.Drawing.StringAlignment.Center
        Me.lblRegistros.WordWrap = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1255, 21)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 139
        Me.PictureBox1.TabStop = False
        '
        'chkGrupo
        '
        Me.chkGrupo.AutoSize = True
        '
        '
        '
        Me.chkGrupo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chkGrupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkGrupo.Location = New System.Drawing.Point(925, 22)
        Me.chkGrupo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkGrupo.Name = "chkGrupo"
        Me.chkGrupo.Size = New System.Drawing.Size(71, 18)
        Me.chkGrupo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.chkGrupo.TabIndex = 138
        Me.chkGrupo.Text = "x Grupo"
        Me.chkGrupo.TextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
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
        Me.cboGrupo.Location = New System.Drawing.Point(1011, 18)
        Me.cboGrupo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboGrupo.Name = "cboGrupo"
        Me.cboGrupo.Size = New System.Drawing.Size(240, 21)
        Me.cboGrupo.TabIndex = 4
        Me.cboGrupo.WatermarkColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'chkModo
        '
        Me.chkModo.AutoSize = True
        '
        '
        '
        Me.chkModo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chkModo.Checked = True
        Me.chkModo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkModo.CheckValue = "Y"
        Me.chkModo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkModo.Location = New System.Drawing.Point(363, 15)
        Me.chkModo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkModo.Name = "chkModo"
        Me.chkModo.Size = New System.Drawing.Size(100, 18)
        Me.chkModo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.chkModo.TabIndex = 137
        Me.chkModo.Text = "Modo Añadir"
        Me.chkModo.TextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmdImprimir.Appearance.Options.UseFont = True
        Me.cmdImprimir.Image = CType(resources.GetObject("cmdImprimir.Image"), System.Drawing.Image)
        Me.cmdImprimir.ImageLocation = DevExpress.DXCore.Controls.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdImprimir.Location = New System.Drawing.Point(1189, 66)
        Me.cmdImprimir.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdImprimir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(103, 42)
        Me.cmdImprimir.TabIndex = 156
        Me.cmdImprimir.Text = "Imprimir"
        '
        'cmdCerrar
        '
        Me.cmdCerrar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmdCerrar.Appearance.Options.UseFont = True
        Me.cmdCerrar.Image = CType(resources.GetObject("cmdCerrar.Image"), System.Drawing.Image)
        Me.cmdCerrar.ImageLocation = DevExpress.DXCore.Controls.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdCerrar.Location = New System.Drawing.Point(1189, 14)
        Me.cmdCerrar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdCerrar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdCerrar.Name = "cmdCerrar"
        Me.cmdCerrar.Size = New System.Drawing.Size(103, 42)
        Me.cmdCerrar.TabIndex = 157
        Me.cmdCerrar.Text = "Cerrar"
        '
        'GroupBox8
        '
        Me.GroupBox8.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox8.Controls.Add(Me.optFormatos)
        Me.GroupBox8.Controls.Add(Me.chkResumenGrupo)
        Me.GroupBox8.Controls.Add(Me.optRepAlmacen_area)
        Me.GroupBox8.Controls.Add(Me.optRepAlmacen)
        Me.GroupBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox8.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox8.Location = New System.Drawing.Point(1001, 6)
        Me.GroupBox8.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox8.Size = New System.Drawing.Size(169, 102)
        Me.GroupBox8.TabIndex = 158
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Reportes"
        '
        'optFormatos
        '
        Me.optFormatos.AutoSize = True
        Me.optFormatos.Checked = True
        Me.optFormatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optFormatos.ForeColor = System.Drawing.Color.Black
        Me.optFormatos.Location = New System.Drawing.Point(11, 59)
        Me.optFormatos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.optFormatos.Name = "optFormatos"
        Me.optFormatos.Size = New System.Drawing.Size(88, 21)
        Me.optFormatos.TabIndex = 139
        Me.optFormatos.TabStop = True
        Me.optFormatos.Text = "Formatos"
        Me.optFormatos.UseVisualStyleBackColor = True
        '
        'chkResumenGrupo
        '
        Me.chkResumenGrupo.AutoSize = True
        '
        '
        '
        Me.chkResumenGrupo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chkResumenGrupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkResumenGrupo.Location = New System.Drawing.Point(9, 81)
        Me.chkResumenGrupo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkResumenGrupo.Name = "chkResumenGrupo"
        Me.chkResumenGrupo.Size = New System.Drawing.Size(134, 18)
        Me.chkResumenGrupo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.chkResumenGrupo.TabIndex = 138
        Me.chkResumenGrupo.Text = "Resumen x Grupo"
        Me.chkResumenGrupo.TextColor = System.Drawing.Color.Black
        '
        'optRepAlmacen_area
        '
        Me.optRepAlmacen_area.AutoSize = True
        Me.optRepAlmacen_area.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optRepAlmacen_area.ForeColor = System.Drawing.Color.Black
        Me.optRepAlmacen_area.Location = New System.Drawing.Point(11, 39)
        Me.optRepAlmacen_area.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.optRepAlmacen_area.Name = "optRepAlmacen_area"
        Me.optRepAlmacen_area.Size = New System.Drawing.Size(138, 21)
        Me.optRepAlmacen_area.TabIndex = 1
        Me.optRepAlmacen_area.Text = "x Almacén y Area"
        Me.optRepAlmacen_area.UseVisualStyleBackColor = True
        '
        'optRepAlmacen
        '
        Me.optRepAlmacen.AutoSize = True
        Me.optRepAlmacen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optRepAlmacen.ForeColor = System.Drawing.Color.Black
        Me.optRepAlmacen.Location = New System.Drawing.Point(11, 20)
        Me.optRepAlmacen.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.optRepAlmacen.Name = "optRepAlmacen"
        Me.optRepAlmacen.Size = New System.Drawing.Size(93, 21)
        Me.optRepAlmacen.TabIndex = 0
        Me.optRepAlmacen.Text = "x Almacén"
        Me.optRepAlmacen.UseVisualStyleBackColor = True
        '
        'GroupPanel1
        '
        Me.GroupPanel1.BackColor = System.Drawing.Color.White
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.cboAnno)
        Me.GroupPanel1.Controls.Add(Me.cboMes)
        Me.GroupPanel1.Location = New System.Drawing.Point(9, 12)
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
        Me.GroupPanel1.TabIndex = 162
        Me.GroupPanel1.Text = "Periodo de Inventario"
        '
        'cboAnno
        '
        Me.cboAnno.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
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
        Me.cboMes.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
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
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.ChkModoImp)
        Me.GroupBox4.Controls.Add(Me.chkBuscar)
        Me.GroupBox4.Controls.Add(Me.PictureBox1)
        Me.GroupBox4.Controls.Add(Me.cboGrupo)
        Me.GroupBox4.Controls.Add(Me.chkGrupo)
        Me.GroupBox4.Controls.Add(Me.PictureBox3)
        Me.GroupBox4.Controls.Add(Me.txtBuscarInventario)
        Me.GroupBox4.Controls.Add(Me.GroupBox3)
        Me.GroupBox4.Controls.Add(Me.chkModo)
        Me.GroupBox4.Controls.Add(Me.txtBuscar)
        Me.GroupBox4.Controls.Add(Me.PictureBox2)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox4.Location = New System.Drawing.Point(9, 107)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox4.Size = New System.Drawing.Size(1292, 59)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        '
        'ChkModoImp
        '
        Me.ChkModoImp.AutoSize = True
        '
        '
        '
        Me.ChkModoImp.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ChkModoImp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkModoImp.Location = New System.Drawing.Point(363, 37)
        Me.ChkModoImp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkModoImp.Name = "ChkModoImp"
        Me.ChkModoImp.Size = New System.Drawing.Size(132, 18)
        Me.ChkModoImp.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ChkModoImp.TabIndex = 141
        Me.ChkModoImp.Text = "Modo Importacion"
        Me.ChkModoImp.TextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        '
        'chkBuscar
        '
        Me.chkBuscar.AutoSize = True
        '
        '
        '
        Me.chkBuscar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chkBuscar.Checked = True
        Me.chkBuscar.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkBuscar.CheckValue = "Y"
        Me.chkBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBuscar.Location = New System.Drawing.Point(7, 23)
        Me.chkBuscar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkBuscar.Name = "chkBuscar"
        Me.chkBuscar.Size = New System.Drawing.Size(83, 19)
        Me.chkBuscar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.chkBuscar.TabIndex = 140
        Me.chkBuscar.Text = "Artículos"
        Me.chkBuscar.TextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        '
        'lblinsertar
        '
        Me.lblinsertar.AutoSize = True
        '
        '
        '
        Me.lblinsertar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblinsertar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinsertar.Location = New System.Drawing.Point(359, 671)
        Me.lblinsertar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblinsertar.Name = "lblinsertar"
        Me.lblinsertar.Size = New System.Drawing.Size(103, 21)
        Me.lblinsertar.TabIndex = 164
        Me.lblinsertar.Text = "Insertar Todo"
        Me.lblinsertar.TextAlignment = System.Drawing.StringAlignment.Center
        Me.lblinsertar.Visible = False
        Me.lblinsertar.WordWrap = True
        '
        'cmdInsertar
        '
        Me.cmdInsertar.BackColor = System.Drawing.Color.Transparent
        Me.cmdInsertar.Image = Global.cefe.My.Resources.Resources.forward18
        Me.cmdInsertar.Location = New System.Drawing.Point(477, 667)
        Me.cmdInsertar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdInsertar.Name = "cmdInsertar"
        Me.cmdInsertar.Size = New System.Drawing.Size(61, 32)
        Me.cmdInsertar.TabIndex = 165
        Me.cmdInsertar.UseVisualStyleBackColor = False
        '
        'p_inventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(1312, 698)
        Me.Controls.Add(Me.cmdInsertar)
        Me.Controls.Add(Me.lblinsertar)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.cmdImprimir)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Controls.Add(Me.cmdCerrar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lblRegistros)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dataInventario)
        Me.Controls.Add(Me.dataCatalogo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "p_inventario"
        Me.Text = "Proceso: REGISTRO DE INVENTARIO FISICO INICIAL"
        CType(Me.dataCatalogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataInventario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdIniciar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents dataCatalogo As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents txtBuscar As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents dataInventario As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cboAlmacen As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents optDescripcion As System.Windows.Forms.RadioButton
    Friend WithEvents optCodigo As System.Windows.Forms.RadioButton
    Friend WithEvents txtBuscarInventario As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents cboArea As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents lblRegistros As DevComponents.DotNetBar.LabelX
    Friend WithEvents cboGrupo As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents chkModo As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chkGrupo As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cmdImprimir As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents cmdCerrar As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents optRepAlmacen_area As System.Windows.Forms.RadioButton
    Friend WithEvents optRepAlmacen As System.Windows.Forms.RadioButton
    Friend WithEvents chkResumenGrupo As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents cmdActualizaCostos As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents cboAnno As System.Windows.Forms.ComboBox
    Friend WithEvents cboMes As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Private WithEvents chkBuscar As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ChkModoImp As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents optFormatos As System.Windows.Forms.RadioButton
    Friend WithEvents lblinsertar As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmdInsertar As System.Windows.Forms.Button
    Friend WithEvents cmdEliminar As DevComponents.DotNetBar.ButtonX

End Class
