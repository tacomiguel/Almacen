<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class p_transferencia
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(p_transferencia))
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.dataArticulos = New DevComponents.DotNetBar.Controls.DataGridViewX
        Me.cboOrigen = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.cboDestino = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX
        Me.txtBuscarOrigen = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.dataTransferencias = New DevComponents.DotNetBar.Controls.DataGridViewX
        Me.chkMostrarTransferencias = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.cmdTransferir = New DevExpress.XtraEditors.SimpleButton
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblArea = New DevComponents.DotNetBar.LabelX
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.cboArea = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX
        Me.lblNroTransferencia = New DevComponents.DotNetBar.LabelX
        Me.dataNroTransferencias = New DevComponents.DotNetBar.Controls.DataGridViewX
        Me.txtBuscarTransferencia = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txtTransferir = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.lblProducto = New DevComponents.DotNetBar.LabelX
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.ChKRptValorizado = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.cmdImprimir = New DevExpress.XtraEditors.SimpleButton
        Me.cmdNuevaT = New DevExpress.XtraEditors.SimpleButton
        Me.lblRegistros = New DevComponents.DotNetBar.LabelX
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.lblCantMaxima = New DevComponents.DotNetBar.LabelX
        CType(Me.dataArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataTransferencias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dataNroTransferencias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.SuspendLayout()
        '
        'dataArticulos
        '
        Me.dataArticulos.AllowUserToAddRows = False
        Me.dataArticulos.AllowUserToDeleteRows = False
        Me.dataArticulos.AllowUserToResizeColumns = False
        Me.dataArticulos.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dataArticulos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dataArticulos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dataArticulos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataArticulos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dataArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataArticulos.DefaultCellStyle = DataGridViewCellStyle3
        Me.dataArticulos.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dataArticulos.Location = New System.Drawing.Point(234, 29)
        Me.dataArticulos.MultiSelect = False
        Me.dataArticulos.Name = "dataArticulos"
        Me.dataArticulos.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataArticulos.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dataArticulos.RowHeadersVisible = False
        Me.dataArticulos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dataArticulos.SelectAllSignVisible = False
        Me.dataArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataArticulos.ShowEditingIcon = False
        Me.dataArticulos.Size = New System.Drawing.Size(435, 133)
        Me.dataArticulos.StandardTab = True
        Me.dataArticulos.TabIndex = 2
        Me.dataArticulos.TabStop = False
        '
        'cboOrigen
        '
        Me.cboOrigen.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboOrigen.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cboOrigen.DisplayMember = "Text"
        Me.cboOrigen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOrigen.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboOrigen.ForeColor = System.Drawing.Color.Black
        Me.cboOrigen.FormattingEnabled = True
        Me.cboOrigen.ItemHeight = 15
        Me.cboOrigen.Location = New System.Drawing.Point(53, 16)
        Me.cboOrigen.Name = "cboOrigen"
        Me.cboOrigen.Size = New System.Drawing.Size(161, 21)
        Me.cboOrigen.TabIndex = 1
        Me.cboOrigen.WatermarkColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'cboDestino
        '
        Me.cboDestino.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboDestino.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cboDestino.DisplayMember = "Text"
        Me.cboDestino.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDestino.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDestino.ForeColor = System.Drawing.Color.Black
        Me.cboDestino.FormattingEnabled = True
        Me.cboDestino.ItemHeight = 15
        Me.cboDestino.Location = New System.Drawing.Point(53, 41)
        Me.cboDestino.Name = "cboDestino"
        Me.cboDestino.Size = New System.Drawing.Size(161, 21)
        Me.cboDestino.TabIndex = 3
        Me.cboDestino.WatermarkColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'LabelX2
        '
        Me.LabelX2.AutoSize = True
        '
        '
        '
        Me.LabelX2.BackgroundStyle.Class = ""
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LabelX2.Location = New System.Drawing.Point(9, 18)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(37, 15)
        Me.LabelX2.TabIndex = 0
        Me.LabelX2.Text = "Origen"
        '
        'txtBuscarOrigen
        '
        '
        '
        '
        Me.txtBuscarOrigen.Border.Class = "TextBoxBorder"
        Me.txtBuscarOrigen.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtBuscarOrigen.FocusHighlightEnabled = True
        Me.txtBuscarOrigen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscarOrigen.Location = New System.Drawing.Point(323, 7)
        Me.txtBuscarOrigen.Name = "txtBuscarOrigen"
        Me.txtBuscarOrigen.Size = New System.Drawing.Size(223, 20)
        Me.txtBuscarOrigen.TabIndex = 1
        '
        'dataTransferencias
        '
        Me.dataTransferencias.AllowUserToAddRows = False
        Me.dataTransferencias.AllowUserToDeleteRows = False
        Me.dataTransferencias.AllowUserToResizeColumns = False
        Me.dataTransferencias.AllowUserToResizeRows = False
        Me.dataTransferencias.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dataTransferencias.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataTransferencias.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dataTransferencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataTransferencias.DefaultCellStyle = DataGridViewCellStyle6
        Me.dataTransferencias.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dataTransferencias.Location = New System.Drawing.Point(115, 217)
        Me.dataTransferencias.MultiSelect = False
        Me.dataTransferencias.Name = "dataTransferencias"
        Me.dataTransferencias.ReadOnly = True
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataTransferencias.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dataTransferencias.RowHeadersVisible = False
        Me.dataTransferencias.SelectAllSignVisible = False
        Me.dataTransferencias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dataTransferencias.ShowEditingIcon = False
        Me.dataTransferencias.Size = New System.Drawing.Size(816, 322)
        Me.dataTransferencias.TabIndex = 83
        '
        'chkMostrarTransferencias
        '
        Me.chkMostrarTransferencias.AutoSize = True
        '
        '
        '
        Me.chkMostrarTransferencias.BackgroundStyle.Class = ""
        Me.chkMostrarTransferencias.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chkMostrarTransferencias.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMostrarTransferencias.Location = New System.Drawing.Point(3, 197)
        Me.chkMostrarTransferencias.Name = "chkMostrarTransferencias"
        Me.chkMostrarTransferencias.Size = New System.Drawing.Size(98, 15)
        Me.chkMostrarTransferencias.TabIndex = 84
        Me.chkMostrarTransferencias.TabStop = False
        Me.chkMostrarTransferencias.Text = "Transferencias "
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.cefe.My.Resources.Resources.buscar18
        Me.PictureBox2.Location = New System.Drawing.Point(548, 8)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(18, 18)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 85
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(69, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(22, 23)
        Me.PictureBox1.TabIndex = 81
        Me.PictureBox1.TabStop = False
        '
        'cmdTransferir
        '
        Me.cmdTransferir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmdTransferir.Appearance.Options.UseFont = True
        Me.cmdTransferir.Image = CType(resources.GetObject("cmdTransferir.Image"), System.Drawing.Image)
        Me.cmdTransferir.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdTransferir.Location = New System.Drawing.Point(154, 14)
        Me.cmdTransferir.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdTransferir.Name = "cmdTransferir"
        Me.cmdTransferir.Size = New System.Drawing.Size(85, 32)
        Me.cmdTransferir.TabIndex = 2
        Me.cmdTransferir.Text = "Transferir"
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.Class = ""
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.Location = New System.Drawing.Point(4, 11)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(65, 36)
        Me.LabelX3.TabIndex = 0
        Me.LabelX3.Text = "Cantidad a Transferir"
        Me.LabelX3.TextAlignment = System.Drawing.StringAlignment.Center
        Me.LabelX3.WordWrap = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblArea)
        Me.GroupBox1.Controls.Add(Me.LabelX1)
        Me.GroupBox1.Controls.Add(Me.cboArea)
        Me.GroupBox1.Controls.Add(Me.cboOrigen)
        Me.GroupBox1.Controls.Add(Me.cboDestino)
        Me.GroupBox1.Controls.Add(Me.LabelX2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(7, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(221, 95)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Almacenes"
        '
        'lblArea
        '
        Me.lblArea.AutoSize = True
        '
        '
        '
        Me.lblArea.BackgroundStyle.Class = ""
        Me.lblArea.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblArea.Enabled = False
        Me.lblArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArea.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblArea.Location = New System.Drawing.Point(9, 69)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(27, 15)
        Me.lblArea.TabIndex = 4
        Me.lblArea.Text = "Area"
        '
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        '
        '
        '
        Me.LabelX1.BackgroundStyle.Class = ""
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LabelX1.Location = New System.Drawing.Point(8, 44)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(41, 15)
        Me.LabelX1.TabIndex = 2
        Me.LabelX1.Text = "Destino"
        '
        'cboArea
        '
        Me.cboArea.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboArea.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cboArea.DisplayMember = "Text"
        Me.cboArea.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboArea.Enabled = False
        Me.cboArea.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboArea.ForeColor = System.Drawing.Color.Black
        Me.cboArea.FormattingEnabled = True
        Me.cboArea.ItemHeight = 15
        Me.cboArea.Location = New System.Drawing.Point(53, 65)
        Me.cboArea.Name = "cboArea"
        Me.cboArea.Size = New System.Drawing.Size(161, 21)
        Me.cboArea.TabIndex = 5
        Me.cboArea.WatermarkColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'LabelX4
        '
        Me.LabelX4.AutoSize = True
        '
        '
        '
        Me.LabelX4.BackgroundStyle.Class = ""
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LabelX4.Location = New System.Drawing.Point(237, 10)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(82, 15)
        Me.LabelX4.TabIndex = 86
        Me.LabelX4.Text = "Ingrese Artículo"
        Me.LabelX4.WordWrap = True
        '
        'LabelX5
        '
        Me.LabelX5.AutoSize = True
        '
        '
        '
        Me.LabelX5.BackgroundStyle.Class = ""
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX5.ForeColor = System.Drawing.Color.Maroon
        Me.LabelX5.Location = New System.Drawing.Point(44, 35)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(136, 28)
        Me.LabelX5.TabIndex = 88
        Me.LabelX5.Text = "Transferencia"
        Me.LabelX5.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'lblNroTransferencia
        '
        '
        '
        '
        Me.lblNroTransferencia.BackgroundStyle.Class = ""
        Me.lblNroTransferencia.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblNroTransferencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNroTransferencia.ForeColor = System.Drawing.Color.Maroon
        Me.lblNroTransferencia.Location = New System.Drawing.Point(45, 58)
        Me.lblNroTransferencia.Name = "lblNroTransferencia"
        Me.lblNroTransferencia.Size = New System.Drawing.Size(133, 21)
        Me.lblNroTransferencia.TabIndex = 89
        Me.lblNroTransferencia.Text = "Nº"
        Me.lblNroTransferencia.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'dataNroTransferencias
        '
        Me.dataNroTransferencias.AllowUserToAddRows = False
        Me.dataNroTransferencias.AllowUserToDeleteRows = False
        Me.dataNroTransferencias.AllowUserToResizeColumns = False
        Me.dataNroTransferencias.AllowUserToResizeRows = False
        Me.dataNroTransferencias.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dataNroTransferencias.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataNroTransferencias.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dataNroTransferencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataNroTransferencias.DefaultCellStyle = DataGridViewCellStyle9
        Me.dataNroTransferencias.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dataNroTransferencias.Location = New System.Drawing.Point(2, 239)
        Me.dataNroTransferencias.MultiSelect = False
        Me.dataNroTransferencias.Name = "dataNroTransferencias"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataNroTransferencias.RowHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dataNroTransferencias.RowHeadersVisible = False
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dataNroTransferencias.RowsDefaultCellStyle = DataGridViewCellStyle11
        Me.dataNroTransferencias.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dataNroTransferencias.SelectAllSignVisible = False
        Me.dataNroTransferencias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dataNroTransferencias.ShowEditingIcon = False
        Me.dataNroTransferencias.Size = New System.Drawing.Size(109, 300)
        Me.dataNroTransferencias.TabIndex = 90
        '
        'txtBuscarTransferencia
        '
        Me.txtBuscarTransferencia.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.txtBuscarTransferencia.Border.Class = "TextBoxBorder"
        Me.txtBuscarTransferencia.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtBuscarTransferencia.FocusHighlightEnabled = True
        Me.txtBuscarTransferencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscarTransferencia.Location = New System.Drawing.Point(2, 216)
        Me.txtBuscarTransferencia.Name = "txtBuscarTransferencia"
        Me.txtBuscarTransferencia.ReadOnly = True
        Me.txtBuscarTransferencia.Size = New System.Drawing.Size(109, 21)
        Me.txtBuscarTransferencia.TabIndex = 91
        '
        'LabelX6
        '
        Me.LabelX6.AutoSize = True
        '
        '
        '
        Me.LabelX6.BackgroundStyle.Class = ""
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX6.ForeColor = System.Drawing.Color.Maroon
        Me.LabelX6.Location = New System.Drawing.Point(111, 198)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(288, 15)
        Me.LabelX6.TabIndex = 96
        Me.LabelX6.Text = "Activo mientras NO exista una Transferencia en Proceso..."
        Me.LabelX6.TextAlignment = System.Drawing.StringAlignment.Center
        Me.LabelX6.WordWrap = True
        '
        'LabelX7
        '
        '
        '
        '
        Me.LabelX7.BackgroundStyle.Class = ""
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelX7.Location = New System.Drawing.Point(18, 9)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(186, 30)
        Me.LabelX7.TabIndex = 97
        Me.LabelX7.Text = "Al realizar la Transferencia se Generá el Nro correspondiente"
        Me.LabelX7.TextAlignment = System.Drawing.StringAlignment.Center
        Me.LabelX7.WordWrap = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.SimpleButton1)
        Me.GroupBox2.Controls.Add(Me.lblNroTransferencia)
        Me.GroupBox2.Controls.Add(Me.LabelX7)
        Me.GroupBox2.Controls.Add(Me.LabelX5)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox2.Location = New System.Drawing.Point(7, 101)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(221, 85)
        Me.GroupBox2.TabIndex = 98
        Me.GroupBox2.TabStop = False
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.SimpleButton1.Location = New System.Drawing.Point(7, 45)
        Me.SimpleButton1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(39, 32)
        Me.SimpleButton1.TabIndex = 82
        Me.SimpleButton1.Text = "Transferir"
        Me.SimpleButton1.Visible = False
        '
        'LabelX8
        '
        Me.LabelX8.AutoSize = True
        '
        '
        '
        Me.LabelX8.BackgroundStyle.Class = ""
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX8.ForeColor = System.Drawing.Color.Green
        Me.LabelX8.Location = New System.Drawing.Point(609, 198)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(315, 15)
        Me.LabelX8.TabIndex = 99
        Me.LabelX8.Text = "*Las Transferencias se realizan a Precio de Costo, sin Impuesto"
        Me.LabelX8.TextAlignment = System.Drawing.StringAlignment.Center
        Me.LabelX8.WordWrap = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtTransferir)
        Me.GroupBox3.Controls.Add(Me.PictureBox1)
        Me.GroupBox3.Controls.Add(Me.LabelX3)
        Me.GroupBox3.Controls.Add(Me.cmdTransferir)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox3.Location = New System.Drawing.Point(679, 109)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(245, 54)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        '
        'txtTransferir
        '
        '
        '
        '
        Me.txtTransferir.Border.Class = "TextBoxBorder"
        Me.txtTransferir.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtTransferir.FocusHighlightEnabled = True
        Me.txtTransferir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTransferir.Location = New System.Drawing.Point(95, 20)
        Me.txtTransferir.Name = "txtTransferir"
        Me.txtTransferir.Size = New System.Drawing.Size(51, 21)
        Me.txtTransferir.TabIndex = 1
        '
        'GroupBox4
        '
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(-37, 182)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1059, 10)
        Me.GroupBox4.TabIndex = 104
        Me.GroupBox4.TabStop = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.lblProducto)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox5.Location = New System.Drawing.Point(234, 156)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(435, 30)
        Me.GroupBox5.TabIndex = 105
        Me.GroupBox5.TabStop = False
        '
        'lblProducto
        '
        '
        '
        '
        Me.lblProducto.BackgroundStyle.Class = ""
        Me.lblProducto.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProducto.ForeColor = System.Drawing.Color.Green
        Me.lblProducto.Location = New System.Drawing.Point(10, 11)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(415, 15)
        Me.lblProducto.TabIndex = 88
        Me.lblProducto.Text = "PRODUCTO"
        Me.lblProducto.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.ChKRptValorizado)
        Me.GroupBox6.Controls.Add(Me.cmdImprimir)
        Me.GroupBox6.Controls.Add(Me.cmdNuevaT)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox6.Location = New System.Drawing.Point(679, 12)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(245, 68)
        Me.GroupBox6.TabIndex = 4
        Me.GroupBox6.TabStop = False
        '
        'ChKRptValorizado
        '
        Me.ChKRptValorizado.AutoSize = True
        '
        '
        '
        Me.ChKRptValorizado.BackgroundStyle.Class = ""
        Me.ChKRptValorizado.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ChKRptValorizado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChKRptValorizado.Location = New System.Drawing.Point(18, 51)
        Me.ChKRptValorizado.Name = "ChKRptValorizado"
        Me.ChKRptValorizado.Size = New System.Drawing.Size(121, 15)
        Me.ChKRptValorizado.TabIndex = 105
        Me.ChKRptValorizado.TabStop = False
        Me.ChKRptValorizado.Text = "Reporte Valorizado "
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmdImprimir.Appearance.Options.UseFont = True
        Me.cmdImprimir.Image = CType(resources.GetObject("cmdImprimir.Image"), System.Drawing.Image)
        Me.cmdImprimir.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdImprimir.Location = New System.Drawing.Point(18, 13)
        Me.cmdImprimir.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(80, 32)
        Me.cmdImprimir.TabIndex = 104
        Me.cmdImprimir.Text = "Imprimir"
        '
        'cmdNuevaT
        '
        Me.cmdNuevaT.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmdNuevaT.Appearance.Options.UseFont = True
        Me.cmdNuevaT.Image = CType(resources.GetObject("cmdNuevaT.Image"), System.Drawing.Image)
        Me.cmdNuevaT.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdNuevaT.Location = New System.Drawing.Point(112, 13)
        Me.cmdNuevaT.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdNuevaT.Name = "cmdNuevaT"
        Me.cmdNuevaT.Size = New System.Drawing.Size(127, 32)
        Me.cmdNuevaT.TabIndex = 103
        Me.cmdNuevaT.Text = "Nueva Transf."
        '
        'lblRegistros
        '
        '
        '
        '
        Me.lblRegistros.BackgroundStyle.Class = ""
        Me.lblRegistros.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblRegistros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistros.ForeColor = System.Drawing.Color.Maroon
        Me.lblRegistros.Location = New System.Drawing.Point(679, 166)
        Me.lblRegistros.Name = "lblRegistros"
        Me.lblRegistros.Size = New System.Drawing.Size(245, 19)
        Me.lblRegistros.TabIndex = 120
        Me.lblRegistros.Text = "Nº de Registros Procesados... 0"
        Me.lblRegistros.TextAlignment = System.Drawing.StringAlignment.Far
        Me.lblRegistros.WordWrap = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.lblCantMaxima)
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox7.Location = New System.Drawing.Point(679, 77)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(245, 34)
        Me.GroupBox7.TabIndex = 5
        Me.GroupBox7.TabStop = False
        '
        'lblCantMaxima
        '
        '
        '
        '
        Me.lblCantMaxima.BackgroundStyle.Class = ""
        Me.lblCantMaxima.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblCantMaxima.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantMaxima.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblCantMaxima.Location = New System.Drawing.Point(18, 9)
        Me.lblCantMaxima.Name = "lblCantMaxima"
        Me.lblCantMaxima.Size = New System.Drawing.Size(205, 22)
        Me.lblCantMaxima.TabIndex = 121
        Me.lblCantMaxima.Text = "Cantidad Máxima a Transferir"
        Me.lblCantMaxima.TextAlignment = System.Drawing.StringAlignment.Center
        Me.lblCantMaxima.WordWrap = True
        '
        'p_transferencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(932, 540)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.lblRegistros)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.dataArticulos)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.LabelX8)
        Me.Controls.Add(Me.LabelX6)
        Me.Controls.Add(Me.txtBuscarTransferencia)
        Me.Controls.Add(Me.dataNroTransferencias)
        Me.Controls.Add(Me.txtBuscarOrigen)
        Me.Controls.Add(Me.LabelX4)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.chkMostrarTransferencias)
        Me.Controls.Add(Me.dataTransferencias)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "p_transferencia"
        Me.Text = "Proceso: TRANSFERENCIAS"
        CType(Me.dataArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataTransferencias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dataNroTransferencias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dataArticulos As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents cmdTransferir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboOrigen As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cboDestino As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtBuscarOrigen As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents dataTransferencias As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents chkMostrarTransferencias As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblNroTransferencia As DevComponents.DotNetBar.LabelX
    Friend WithEvents dataNroTransferencias As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents txtBuscarTransferencia As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents lblProducto As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdNuevaT As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblRegistros As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents lblCantMaxima As DevComponents.DotNetBar.LabelX
    Friend WithEvents cboArea As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents lblArea As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtTransferir As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ChKRptValorizado As DevComponents.DotNetBar.Controls.CheckBoxX

End Class
