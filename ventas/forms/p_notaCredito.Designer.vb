<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class p_notaCredito
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(p_notaCredito))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.grupoAlmacen = New System.Windows.Forms.GroupBox()
        Me.txtRUC = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.cmdBuscar = New DevExpress.DXCore.Controls.XtraEditors.SimpleButton()
        Me.TextBoxX1 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.cboDocumento = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.txtNroDocumento = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdNuevo = New DevExpress.DXCore.Controls.XtraEditors.SimpleButton()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.txtNroCredito = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtSerCredito = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtSerDocumento = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.cboProveedor = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.dataDetalle = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.dataCredito = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.mcCredito = New DevComponents.Editors.DateTimeAdv.MonthCalendarAdv()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtCant_credito = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.cmdInsertar = New DevExpress.DXCore.Controls.XtraEditors.SimpleButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.grupoAlmacen.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dataDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataCredito, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'grupoAlmacen
        '
        Me.grupoAlmacen.Controls.Add(Me.txtRUC)
        Me.grupoAlmacen.Controls.Add(Me.cmdBuscar)
        Me.grupoAlmacen.Controls.Add(Me.TextBoxX1)
        Me.grupoAlmacen.Controls.Add(Me.cboDocumento)
        Me.grupoAlmacen.Controls.Add(Me.txtNroDocumento)
        Me.grupoAlmacen.Controls.Add(Me.GroupBox1)
        Me.grupoAlmacen.Controls.Add(Me.txtSerDocumento)
        Me.grupoAlmacen.Controls.Add(Me.LabelX1)
        Me.grupoAlmacen.Controls.Add(Me.LabelX5)
        Me.grupoAlmacen.Controls.Add(Me.cboProveedor)
        Me.grupoAlmacen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupoAlmacen.ForeColor = System.Drawing.Color.Maroon
        Me.grupoAlmacen.Location = New System.Drawing.Point(181, 5)
        Me.grupoAlmacen.Name = "grupoAlmacen"
        Me.grupoAlmacen.Size = New System.Drawing.Size(353, 132)
        Me.grupoAlmacen.TabIndex = 0
        Me.grupoAlmacen.TabStop = False
        Me.grupoAlmacen.Text = "Seleccione Documento a Registrar Nota de Crédito"
        '
        'txtRUC
        '
        Me.txtRUC.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.txtRUC.Border.Class = "TextBoxBorder"
        Me.txtRUC.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtRUC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRUC.ForeColor = System.Drawing.Color.Black
        Me.txtRUC.Location = New System.Drawing.Point(9, 40)
        Me.txtRUC.Name = "txtRUC"
        Me.txtRUC.ReadOnly = True
        Me.txtRUC.Size = New System.Drawing.Size(97, 21)
        Me.txtRUC.TabIndex = 2
        Me.txtRUC.TabStop = False
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBuscar.Appearance.Options.UseFont = True
        Me.cmdBuscar.Image = CType(resources.GetObject("cmdBuscar.Image"), System.Drawing.Image)
        Me.cmdBuscar.ImageLocation = DevExpress.DXCore.Controls.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdBuscar.Location = New System.Drawing.Point(319, 102)
        Me.cmdBuscar.LookAndFeel.SkinName = "iMaginary"
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(26, 26)
        Me.cmdBuscar.TabIndex = 9
        '
        'TextBoxX1
        '
        Me.TextBoxX1.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.TextBoxX1.Border.Class = "TextBoxBorder"
        Me.TextBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxX1.ForeColor = System.Drawing.Color.Black
        Me.TextBoxX1.Location = New System.Drawing.Point(112, 40)
        Me.TextBoxX1.Name = "TextBoxX1"
        Me.TextBoxX1.ReadOnly = True
        Me.TextBoxX1.Size = New System.Drawing.Size(234, 21)
        Me.TextBoxX1.TabIndex = 3
        Me.TextBoxX1.TabStop = False
        '
        'cboDocumento
        '
        Me.cboDocumento.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboDocumento.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cboDocumento.DisplayMember = "Text"
        Me.cboDocumento.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDocumento.FocusHighlightColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.cboDocumento.FocusHighlightEnabled = True
        Me.cboDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDocumento.ForeColor = System.Drawing.Color.Black
        Me.cboDocumento.ItemHeight = 15
        Me.cboDocumento.Location = New System.Drawing.Point(75, 105)
        Me.cboDocumento.Name = "cboDocumento"
        Me.cboDocumento.Size = New System.Drawing.Size(113, 21)
        Me.cboDocumento.TabIndex = 6
        '
        'txtNroDocumento
        '
        Me.txtNroDocumento.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtNroDocumento.Border.Class = "TextBoxBorder"
        Me.txtNroDocumento.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNroDocumento.FocusHighlightEnabled = True
        Me.txtNroDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroDocumento.ForeColor = System.Drawing.Color.Black
        Me.txtNroDocumento.Location = New System.Drawing.Point(242, 105)
        Me.txtNroDocumento.Name = "txtNroDocumento"
        Me.txtNroDocumento.Size = New System.Drawing.Size(75, 21)
        Me.txtNroDocumento.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdNuevo)
        Me.GroupBox1.Controls.Add(Me.LabelX3)
        Me.GroupBox1.Controls.Add(Me.LabelX2)
        Me.GroupBox1.Controls.Add(Me.txtNroCredito)
        Me.GroupBox1.Controls.Add(Me.txtSerCredito)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(9, 58)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(337, 43)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmdNuevo.Appearance.Options.UseFont = True
        Me.cmdNuevo.Image = CType(resources.GetObject("cmdNuevo.Image"), System.Drawing.Image)
        Me.cmdNuevo.ImageLocation = DevExpress.DXCore.Controls.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdNuevo.Location = New System.Drawing.Point(261, 10)
        Me.cmdNuevo.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(69, 28)
        Me.cmdNuevo.TabIndex = 10
        Me.cmdNuevo.Text = "Nuevo"
        '
        'LabelX3
        '
        Me.LabelX3.AutoSize = True
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("Bauhaus 93", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LabelX3.Location = New System.Drawing.Point(124, 14)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(6, 17)
        Me.LabelX3.TabIndex = 2
        Me.LabelX3.Text = "-"
        Me.LabelX3.TextAlignment = System.Drawing.StringAlignment.Center
        Me.LabelX3.WordWrap = True
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
        Me.LabelX2.Location = New System.Drawing.Point(8, 15)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(70, 16)
        Me.LabelX2.TabIndex = 0
        Me.LabelX2.Text = "Nota Crédito"
        Me.LabelX2.TextAlignment = System.Drawing.StringAlignment.Center
        Me.LabelX2.WordWrap = True
        '
        'txtNroCredito
        '
        Me.txtNroCredito.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtNroCredito.Border.Class = "TextBoxBorder"
        Me.txtNroCredito.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNroCredito.FocusHighlightEnabled = True
        Me.txtNroCredito.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroCredito.ForeColor = System.Drawing.Color.Black
        Me.txtNroCredito.Location = New System.Drawing.Point(132, 13)
        Me.txtNroCredito.Name = "txtNroCredito"
        Me.txtNroCredito.Size = New System.Drawing.Size(75, 21)
        Me.txtNroCredito.TabIndex = 3
        '
        'txtSerCredito
        '
        Me.txtSerCredito.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtSerCredito.Border.Class = "TextBoxBorder"
        Me.txtSerCredito.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtSerCredito.FocusHighlightEnabled = True
        Me.txtSerCredito.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerCredito.ForeColor = System.Drawing.Color.Black
        Me.txtSerCredito.Location = New System.Drawing.Point(85, 13)
        Me.txtSerCredito.Name = "txtSerCredito"
        Me.txtSerCredito.Size = New System.Drawing.Size(37, 21)
        Me.txtSerCredito.TabIndex = 1
        '
        'txtSerDocumento
        '
        Me.txtSerDocumento.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtSerDocumento.Border.Class = "TextBoxBorder"
        Me.txtSerDocumento.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtSerDocumento.FocusHighlightEnabled = True
        Me.txtSerDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerDocumento.ForeColor = System.Drawing.Color.Black
        Me.txtSerDocumento.Location = New System.Drawing.Point(191, 105)
        Me.txtSerDocumento.Name = "txtSerDocumento"
        Me.txtSerDocumento.Size = New System.Drawing.Size(50, 21)
        Me.txtSerDocumento.TabIndex = 7
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
        Me.LabelX1.Location = New System.Drawing.Point(9, 20)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(58, 16)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "Proveedor"
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Center
        Me.LabelX1.WordWrap = True
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
        Me.LabelX5.Location = New System.Drawing.Point(9, 106)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(64, 16)
        Me.LabelX5.TabIndex = 5
        Me.LabelX5.Text = "Documento"
        Me.LabelX5.TextAlignment = System.Drawing.StringAlignment.Center
        Me.LabelX5.WordWrap = True
        '
        'cboProveedor
        '
        Me.cboProveedor.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboProveedor.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cboProveedor.DisplayMember = "Text"
        Me.cboProveedor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboProveedor.FocusHighlightColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.cboProveedor.FocusHighlightEnabled = True
        Me.cboProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProveedor.ForeColor = System.Drawing.Color.Black
        Me.cboProveedor.ItemHeight = 15
        Me.cboProveedor.Location = New System.Drawing.Point(75, 17)
        Me.cboProveedor.Name = "cboProveedor"
        Me.cboProveedor.Size = New System.Drawing.Size(271, 21)
        Me.cboProveedor.TabIndex = 1
        '
        'dataDetalle
        '
        Me.dataDetalle.AllowUserToAddRows = False
        Me.dataDetalle.AllowUserToDeleteRows = False
        Me.dataDetalle.AllowUserToResizeColumns = False
        Me.dataDetalle.AllowUserToResizeRows = False
        Me.dataDetalle.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dataDetalle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataDetalle.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dataDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataDetalle.DefaultCellStyle = DataGridViewCellStyle2
        Me.dataDetalle.EnableHeadersVisualStyles = False
        Me.dataDetalle.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dataDetalle.Location = New System.Drawing.Point(6, 143)
        Me.dataDetalle.MultiSelect = False
        Me.dataDetalle.Name = "dataDetalle"
        Me.dataDetalle.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataDetalle.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dataDetalle.RowHeadersVisible = False
        Me.dataDetalle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dataDetalle.SelectAllSignVisible = False
        Me.dataDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataDetalle.ShowEditingIcon = False
        Me.dataDetalle.Size = New System.Drawing.Size(478, 376)
        Me.dataDetalle.TabIndex = 1
        '
        'dataCredito
        '
        Me.dataCredito.AllowUserToAddRows = False
        Me.dataCredito.AllowUserToDeleteRows = False
        Me.dataCredito.AllowUserToResizeColumns = False
        Me.dataCredito.AllowUserToResizeRows = False
        Me.dataCredito.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dataCredito.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataCredito.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dataCredito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataCredito.DefaultCellStyle = DataGridViewCellStyle5
        Me.dataCredito.EnableHeadersVisualStyles = False
        Me.dataCredito.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dataCredito.Location = New System.Drawing.Point(540, 5)
        Me.dataCredito.MultiSelect = False
        Me.dataCredito.Name = "dataCredito"
        Me.dataCredito.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataCredito.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dataCredito.RowHeadersVisible = False
        Me.dataCredito.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dataCredito.SelectAllSignVisible = False
        Me.dataCredito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataCredito.ShowEditingIcon = False
        Me.dataCredito.Size = New System.Drawing.Size(384, 514)
        Me.dataCredito.TabIndex = 2
        '
        'mcCredito
        '
        Me.mcCredito.AnnuallyMarkedDates = New Date(-1) {}
        Me.mcCredito.AutoSize = True
        '
        '
        '
        Me.mcCredito.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.mcCredito.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.mcCredito.BackgroundStyle.BorderBottomWidth = 1
        Me.mcCredito.BackgroundStyle.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.mcCredito.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.mcCredito.BackgroundStyle.BorderLeftWidth = 1
        Me.mcCredito.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.mcCredito.BackgroundStyle.BorderRightWidth = 1
        Me.mcCredito.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.mcCredito.BackgroundStyle.BorderTopWidth = 1
        Me.mcCredito.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.mcCredito.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.mcCredito.ContainerControlProcessDialogKey = True
        Me.mcCredito.DisplayMonth = New Date(2010, 10, 1, 0, 0, 0, 0)
        Me.mcCredito.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.mcCredito.Location = New System.Drawing.Point(6, 9)
        Me.mcCredito.MarkedDates = New Date(-1) {}
        Me.mcCredito.MaxDate = New Date(2020, 12, 31, 0, 0, 0, 0)
        Me.mcCredito.MinDate = New Date(2010, 1, 1, 0, 0, 0, 0)
        Me.mcCredito.MonthlyMarkedDates = New Date(-1) {}
        Me.mcCredito.Name = "mcCredito"
        '
        '
        '
        Me.mcCredito.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.mcCredito.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.mcCredito.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.mcCredito.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.mcCredito.Size = New System.Drawing.Size(170, 131)
        Me.mcCredito.TabIndex = 53
        Me.mcCredito.TabStop = False
        Me.mcCredito.Text = "MonthCalendarAdv1"
        Me.mcCredito.TwoLetterDayName = False
        Me.mcCredito.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.cefe.My.Resources.Resources.forward18
        Me.PictureBox1.Location = New System.Drawing.Point(18, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(18, 18)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 88
        Me.PictureBox1.TabStop = False
        '
        'txtCant_credito
        '
        Me.txtCant_credito.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.txtCant_credito.Border.Class = "TextBoxBorder"
        Me.txtCant_credito.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtCant_credito.FocusHighlightEnabled = True
        Me.txtCant_credito.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCant_credito.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtCant_credito.Location = New System.Drawing.Point(0, 34)
        Me.txtCant_credito.Name = "txtCant_credito"
        Me.txtCant_credito.Size = New System.Drawing.Size(52, 21)
        Me.txtCant_credito.TabIndex = 0
        '
        'cmdInsertar
        '
        Me.cmdInsertar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmdInsertar.Appearance.Options.UseFont = True
        Me.cmdInsertar.Image = Global.cefe.My.Resources.Resources.ok20
        Me.cmdInsertar.ImageLocation = DevExpress.DXCore.Controls.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdInsertar.Location = New System.Drawing.Point(11, 60)
        Me.cmdInsertar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdInsertar.Name = "cmdInsertar"
        Me.cmdInsertar.Size = New System.Drawing.Size(30, 25)
        Me.cmdInsertar.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.cmdInsertar)
        Me.GroupBox2.Controls.Add(Me.txtCant_credito)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox2.Location = New System.Drawing.Point(485, 250)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(52, 94)
        Me.GroupBox2.TabIndex = 89
        Me.GroupBox2.TabStop = False
        '
        'p_notaCredito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(929, 525)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.dataCredito)
        Me.Controls.Add(Me.mcCredito)
        Me.Controls.Add(Me.dataDetalle)
        Me.Controls.Add(Me.grupoAlmacen)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "p_notaCredito"
        Me.Text = "Proceso: REGISTRO DE NOTA DE CREDITO"
        Me.grupoAlmacen.ResumeLayout(False)
        Me.grupoAlmacen.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dataDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataCredito, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grupoAlmacen As System.Windows.Forms.GroupBox
    Friend WithEvents dataDetalle As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents txtRUC As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents cboProveedor As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtNroDocumento As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtSerDocumento As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents cboDocumento As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cmdBuscar As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents dataCredito As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtNroCredito As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtSerCredito As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents mcCredito As DevComponents.Editors.DateTimeAdv.MonthCalendarAdv
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtCant_credito As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents cmdInsertar As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents cmdNuevo As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents TextBoxX1 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox

End Class
