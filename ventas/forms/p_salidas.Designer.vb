<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class p_salidas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(p_salidas))
        Me.dataArticulo = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txtBuscar = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cboFormaPago = New System.Windows.Forms.ComboBox()
        Me.cboCliente = New System.Windows.Forms.ComboBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtDirEntrega = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtRuc = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtObs = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboAlmacen = New System.Windows.Forms.ComboBox()
        Me.gbDocumentos = New System.Windows.Forms.GroupBox()
        Me.cboDocumento = New System.Windows.Forms.ComboBox()
        Me.txtNroGuia = New System.Windows.Forms.TextBox()
        Me.txtSerGuia = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNroDocumento = New System.Windows.Forms.TextBox()
        Me.txtSerDocumento = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.chkIGV = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.lblItems = New DevComponents.DotNetBar.LabelX()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtIGV = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtSubTotal = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.mcFSalida = New DevComponents.Editors.DateTimeAdv.MonthCalendarAdv()
        Me.gbp = New System.Windows.Forms.GroupBox()
        Me.bp = New System.Windows.Forms.ProgressBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmdImprimir = New DevExpress.DXCore.Controls.XtraEditors.SimpleButton()
        Me.cmdAnular = New DevExpress.DXCore.Controls.XtraEditors.SimpleButton()
        Me.cmdCancelar = New DevExpress.DXCore.Controls.XtraEditors.SimpleButton()
        Me.cmdGrabar = New DevExpress.DXCore.Controls.XtraEditors.SimpleButton()
        Me.dataDetalle = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.lblTC = New DevComponents.DotNetBar.LabelX()
        Me.optDolares = New System.Windows.Forms.RadioButton()
        Me.optMoneda = New System.Windows.Forms.RadioButton()
        CType(Me.dataArticulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gbDocumentos.SuspendLayout()
        Me.gbp.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dataDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'dataArticulo
        '
        Me.dataArticulo.AllowUserToAddRows = False
        Me.dataArticulo.AllowUserToDeleteRows = False
        Me.dataArticulo.AllowUserToResizeColumns = False
        Me.dataArticulo.AllowUserToResizeRows = False
        Me.dataArticulo.BackgroundColor = System.Drawing.Color.White
        Me.dataArticulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dataArticulo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
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
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataArticulo.DefaultCellStyle = DataGridViewCellStyle2
        Me.dataArticulo.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dataArticulo.Location = New System.Drawing.Point(7, 214)
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
        Me.dataArticulo.ScrollBarAppearance = DevComponents.DotNetBar.eScrollBarAppearance.[Default]
        Me.dataArticulo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dataArticulo.SelectAllSignVisible = False
        Me.dataArticulo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dataArticulo.ShowEditingIcon = False
        Me.dataArticulo.Size = New System.Drawing.Size(272, 331)
        Me.dataArticulo.TabIndex = 6
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.cefe.My.Resources.Resources.buscar221
        Me.PictureBox2.Location = New System.Drawing.Point(252, 188)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(26, 22)
        Me.PictureBox2.TabIndex = 94
        Me.PictureBox2.TabStop = False
        '
        'txtBuscar
        '
        '
        '
        '
        Me.txtBuscar.Border.Class = "TextBoxBorder"
        Me.txtBuscar.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(9, 188)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(240, 21)
        Me.txtBuscar.TabIndex = 5
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cboFormaPago)
        Me.GroupBox4.Controls.Add(Me.cboCliente)
        Me.GroupBox4.Controls.Add(Me.txtTelefono)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.txtDirEntrega)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.txtRuc)
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Controls.Add(Me.Label21)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(383, 0)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(594, 110)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        '
        'cboFormaPago
        '
        Me.cboFormaPago.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFormaPago.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFormaPago.FormattingEnabled = True
        Me.cboFormaPago.Location = New System.Drawing.Point(311, 77)
        Me.cboFormaPago.Name = "cboFormaPago"
        Me.cboFormaPago.Size = New System.Drawing.Size(208, 24)
        Me.cboFormaPago.TabIndex = 9
        '
        'cboCliente
        '
        Me.cboCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboCliente.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCliente.ForeColor = System.Drawing.Color.SteelBlue
        Me.cboCliente.FormattingEnabled = True
        Me.cboCliente.Location = New System.Drawing.Point(75, 16)
        Me.cboCliente.Name = "cboCliente"
        Me.cboCliente.Size = New System.Drawing.Size(337, 24)
        Me.cboCliente.TabIndex = 1
        '
        'txtTelefono
        '
        Me.txtTelefono.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTelefono.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.ForeColor = System.Drawing.Color.SteelBlue
        Me.txtTelefono.Location = New System.Drawing.Point(86, 78)
        Me.txtTelefono.MaxLength = 9
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.ReadOnly = True
        Me.txtTelefono.Size = New System.Drawing.Size(91, 22)
        Me.txtTelefono.TabIndex = 7
        Me.txtTelefono.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 18)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Teléfono"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(194, 80)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 18)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Forma de Pago"
        '
        'txtDirEntrega
        '
        Me.txtDirEntrega.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDirEntrega.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDirEntrega.ForeColor = System.Drawing.Color.SteelBlue
        Me.txtDirEntrega.Location = New System.Drawing.Point(110, 48)
        Me.txtDirEntrega.Name = "txtDirEntrega"
        Me.txtDirEntrega.ReadOnly = True
        Me.txtDirEntrega.Size = New System.Drawing.Size(473, 22)
        Me.txtDirEntrega.TabIndex = 5
        Me.txtDirEntrega.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(15, 50)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 18)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Dir.Entrega"
        '
        'txtRuc
        '
        Me.txtRuc.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRuc.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRuc.ForeColor = System.Drawing.Color.SteelBlue
        Me.txtRuc.Location = New System.Drawing.Point(460, 17)
        Me.txtRuc.MaxLength = 11
        Me.txtRuc.Name = "txtRuc"
        Me.txtRuc.ReadOnly = True
        Me.txtRuc.Size = New System.Drawing.Size(123, 22)
        Me.txtRuc.TabIndex = 3
        Me.txtRuc.TabStop = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(421, 19)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(41, 18)
        Me.Label19.TabIndex = 2
        Me.Label19.Text = "RUC"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(15, 19)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(59, 18)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "Cliente"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtObs)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(435, 112)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(541, 50)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Observación"
        '
        'txtObs
        '
        Me.txtObs.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtObs.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObs.ForeColor = System.Drawing.Color.SteelBlue
        Me.txtObs.Location = New System.Drawing.Point(10, 19)
        Me.txtObs.Name = "txtObs"
        Me.txtObs.Size = New System.Drawing.Size(521, 22)
        Me.txtObs.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboAlmacen)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(189, 112)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(240, 50)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Almacén"
        '
        'cboAlmacen
        '
        Me.cboAlmacen.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboAlmacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAlmacen.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAlmacen.FormattingEnabled = True
        Me.cboAlmacen.Location = New System.Drawing.Point(8, 19)
        Me.cboAlmacen.Name = "cboAlmacen"
        Me.cboAlmacen.Size = New System.Drawing.Size(225, 24)
        Me.cboAlmacen.TabIndex = 0
        '
        'gbDocumentos
        '
        Me.gbDocumentos.Controls.Add(Me.cboDocumento)
        Me.gbDocumentos.Controls.Add(Me.txtNroGuia)
        Me.gbDocumentos.Controls.Add(Me.txtSerGuia)
        Me.gbDocumentos.Controls.Add(Me.Label1)
        Me.gbDocumentos.Controls.Add(Me.txtNroDocumento)
        Me.gbDocumentos.Controls.Add(Me.txtSerDocumento)
        Me.gbDocumentos.Controls.Add(Me.Label5)
        Me.gbDocumentos.Controls.Add(Me.Label17)
        Me.gbDocumentos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDocumentos.Location = New System.Drawing.Point(189, 0)
        Me.gbDocumentos.Name = "gbDocumentos"
        Me.gbDocumentos.Size = New System.Drawing.Size(187, 110)
        Me.gbDocumentos.TabIndex = 0
        Me.gbDocumentos.TabStop = False
        Me.gbDocumentos.Text = "Documentos"
        '
        'cboDocumento
        '
        Me.cboDocumento.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDocumento.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDocumento.FormattingEnabled = True
        Me.cboDocumento.Location = New System.Drawing.Point(10, 20)
        Me.cboDocumento.Name = "cboDocumento"
        Me.cboDocumento.Size = New System.Drawing.Size(167, 24)
        Me.cboDocumento.TabIndex = 0
        '
        'txtNroGuia
        '
        Me.txtNroGuia.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNroGuia.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroGuia.ForeColor = System.Drawing.Color.Black
        Me.txtNroGuia.Location = New System.Drawing.Point(96, 78)
        Me.txtNroGuia.MaxLength = 8
        Me.txtNroGuia.Name = "txtNroGuia"
        Me.txtNroGuia.Size = New System.Drawing.Size(82, 22)
        Me.txtNroGuia.TabIndex = 7
        '
        'txtSerGuia
        '
        Me.txtSerGuia.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSerGuia.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerGuia.ForeColor = System.Drawing.Color.Black
        Me.txtSerGuia.Location = New System.Drawing.Point(54, 78)
        Me.txtSerGuia.MaxLength = 3
        Me.txtSerGuia.Name = "txtSerGuia"
        Me.txtSerGuia.Size = New System.Drawing.Size(30, 22)
        Me.txtSerGuia.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(82, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(14, 19)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "-"
        '
        'txtNroDocumento
        '
        Me.txtNroDocumento.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNroDocumento.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroDocumento.ForeColor = System.Drawing.Color.Black
        Me.txtNroDocumento.Location = New System.Drawing.Point(67, 49)
        Me.txtNroDocumento.MaxLength = 8
        Me.txtNroDocumento.Name = "txtNroDocumento"
        Me.txtNroDocumento.Size = New System.Drawing.Size(110, 22)
        Me.txtNroDocumento.TabIndex = 3
        '
        'txtSerDocumento
        '
        Me.txtSerDocumento.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSerDocumento.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerDocumento.ForeColor = System.Drawing.Color.Black
        Me.txtSerDocumento.Location = New System.Drawing.Point(10, 49)
        Me.txtSerDocumento.MaxLength = 3
        Me.txtSerDocumento.Name = "txtSerDocumento"
        Me.txtSerDocumento.Size = New System.Drawing.Size(41, 22)
        Me.txtSerDocumento.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(52, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(14, 19)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "-"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(7, 80)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(41, 18)
        Me.Label17.TabIndex = 4
        Me.Label17.Text = "Guia"
        '
        'chkIGV
        '
        Me.chkIGV.AutoSize = True
        '
        '
        '
        Me.chkIGV.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chkIGV.Checked = True
        Me.chkIGV.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkIGV.CheckValue = "Y"
        Me.chkIGV.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkIGV.Location = New System.Drawing.Point(846, 162)
        Me.chkIGV.Name = "chkIGV"
        Me.chkIGV.Size = New System.Drawing.Size(130, 15)
        Me.chkIGV.TabIndex = 81
        Me.chkIGV.Text = "Precios Incluyen IMP"
        Me.chkIGV.TextColor = System.Drawing.Color.Maroon
        '
        'lblItems
        '
        Me.lblItems.AutoSize = True
        '
        '
        '
        Me.lblItems.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblItems.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItems.Location = New System.Drawing.Point(288, 465)
        Me.lblItems.Name = "lblItems"
        Me.lblItems.Size = New System.Drawing.Size(80, 15)
        Me.lblItems.TabIndex = 80
        Me.lblItems.Text = "Nro de Items. 0"
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTotal.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.ForeColor = System.Drawing.Color.ForestGreen
        Me.txtTotal.Location = New System.Drawing.Point(862, 521)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(115, 25)
        Me.txtTotal.TabIndex = 79
        Me.txtTotal.TabStop = False
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label13.Location = New System.Drawing.Point(808, 526)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(50, 16)
        Me.Label13.TabIndex = 78
        Me.Label13.Text = "TOTAL"
        '
        'txtIGV
        '
        Me.txtIGV.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtIGV.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIGV.ForeColor = System.Drawing.Color.ForestGreen
        Me.txtIGV.Location = New System.Drawing.Point(862, 494)
        Me.txtIGV.Name = "txtIGV"
        Me.txtIGV.ReadOnly = True
        Me.txtIGV.Size = New System.Drawing.Size(115, 25)
        Me.txtIGV.TabIndex = 77
        Me.txtIGV.TabStop = False
        Me.txtIGV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label14.Location = New System.Drawing.Point(828, 498)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(32, 16)
        Me.Label14.TabIndex = 76
        Me.Label14.Text = "IMP"
        '
        'txtSubTotal
        '
        Me.txtSubTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSubTotal.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubTotal.ForeColor = System.Drawing.Color.ForestGreen
        Me.txtSubTotal.Location = New System.Drawing.Point(862, 467)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.ReadOnly = True
        Me.txtSubTotal.Size = New System.Drawing.Size(115, 25)
        Me.txtSubTotal.TabIndex = 75
        Me.txtSubTotal.TabStop = False
        Me.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Green
        Me.Label15.Location = New System.Drawing.Point(778, 471)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(81, 16)
        Me.Label15.TabIndex = 74
        Me.Label15.Text = "SUB TOTAL"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(6, 169)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(66, 18)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Artículo:"
        '
        'mcFSalida
        '
        Me.mcFSalida.AnnuallyMarkedDates = New Date(-1) {}
        Me.mcFSalida.AutoSize = True
        '
        '
        '
        Me.mcFSalida.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.mcFSalida.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.mcFSalida.BackgroundStyle.BorderBottomWidth = 1
        Me.mcFSalida.BackgroundStyle.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.mcFSalida.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.mcFSalida.BackgroundStyle.BorderLeftWidth = 1
        Me.mcFSalida.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.mcFSalida.BackgroundStyle.BorderRightWidth = 1
        Me.mcFSalida.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.mcFSalida.BackgroundStyle.BorderTopWidth = 1
        Me.mcFSalida.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.mcFSalida.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.mcFSalida.ContainerControlProcessDialogKey = True
        Me.mcFSalida.DisplayMonth = New Date(2010, 10, 1, 0, 0, 0, 0)
        Me.mcFSalida.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.mcFSalida.Location = New System.Drawing.Point(7, 34)
        Me.mcFSalida.MarkedDates = New Date(-1) {}
        Me.mcFSalida.MaxDate = New Date(2020, 12, 31, 0, 0, 0, 0)
        Me.mcFSalida.MinDate = New Date(2010, 1, 1, 0, 0, 0, 0)
        Me.mcFSalida.MonthlyMarkedDates = New Date(-1) {}
        Me.mcFSalida.Name = "mcFSalida"
        '
        '
        '
        Me.mcFSalida.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.mcFSalida.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.mcFSalida.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.mcFSalida.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.mcFSalida.Size = New System.Drawing.Size(170, 131)
        Me.mcFSalida.TabIndex = 11
        Me.mcFSalida.Text = "MonthCalendarAdv1"
        Me.mcFSalida.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        '
        'gbp
        '
        Me.gbp.Controls.Add(Me.bp)
        Me.gbp.Location = New System.Drawing.Point(412, 268)
        Me.gbp.Name = "gbp"
        Me.gbp.Size = New System.Drawing.Size(321, 47)
        Me.gbp.TabIndex = 71
        Me.gbp.TabStop = False
        Me.gbp.Visible = False
        '
        'bp
        '
        Me.bp.BackColor = System.Drawing.Color.White
        Me.bp.Location = New System.Drawing.Point(9, 15)
        Me.bp.Maximum = 200
        Me.bp.Name = "bp"
        Me.bp.Size = New System.Drawing.Size(303, 23)
        Me.bp.TabIndex = 31
        Me.bp.Value = 5
        Me.bp.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(25, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Fecha de Salida"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmdImprimir)
        Me.GroupBox3.Controls.Add(Me.cmdAnular)
        Me.GroupBox3.Controls.Add(Me.cmdCancelar)
        Me.GroupBox3.Controls.Add(Me.cmdGrabar)
        Me.GroupBox3.Location = New System.Drawing.Point(285, 477)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(340, 69)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmdImprimir.Appearance.Options.UseFont = True
        Me.cmdImprimir.Enabled = False
        Me.cmdImprimir.Image = Global.cefe.My.Resources.Resources.print_preview
        Me.cmdImprimir.ImageLocation = DevExpress.DXCore.Controls.XtraEditors.ImageLocation.TopCenter
        Me.cmdImprimir.Location = New System.Drawing.Point(255, 12)
        Me.cmdImprimir.LookAndFeel.SkinName = "iMaginary"
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(75, 50)
        Me.cmdImprimir.TabIndex = 34
        Me.cmdImprimir.Text = "IMPRIMIR"
        '
        'cmdAnular
        '
        Me.cmdAnular.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmdAnular.Appearance.Options.UseFont = True
        Me.cmdAnular.Enabled = False
        Me.cmdAnular.Image = Global.cefe.My.Resources.Resources.m_borrar
        Me.cmdAnular.ImageLocation = DevExpress.DXCore.Controls.XtraEditors.ImageLocation.TopCenter
        Me.cmdAnular.Location = New System.Drawing.Point(173, 12)
        Me.cmdAnular.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdAnular.Name = "cmdAnular"
        Me.cmdAnular.Size = New System.Drawing.Size(75, 50)
        Me.cmdAnular.TabIndex = 34
        Me.cmdAnular.Text = "ELIMINAR"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.Enabled = False
        Me.cmdCancelar.Image = Global.cefe.My.Resources.Resources.m_cancelar
        Me.cmdCancelar.ImageLocation = DevExpress.DXCore.Controls.XtraEditors.ImageLocation.TopCenter
        Me.cmdCancelar.Location = New System.Drawing.Point(91, 12)
        Me.cmdCancelar.LookAndFeel.SkinName = "Black"
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 50)
        Me.cmdCancelar.TabIndex = 34
        Me.cmdCancelar.Text = "CANCELAR"
        '
        'cmdGrabar
        '
        Me.cmdGrabar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmdGrabar.Appearance.Options.UseFont = True
        Me.cmdGrabar.Enabled = False
        Me.cmdGrabar.Image = Global.cefe.My.Resources.Resources.m_grabar
        Me.cmdGrabar.ImageLocation = DevExpress.DXCore.Controls.XtraEditors.ImageLocation.TopCenter
        Me.cmdGrabar.Location = New System.Drawing.Point(9, 12)
        Me.cmdGrabar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdGrabar.Name = "cmdGrabar"
        Me.cmdGrabar.Size = New System.Drawing.Size(75, 50)
        Me.cmdGrabar.TabIndex = 0
        Me.cmdGrabar.Text = "GRABAR"
        '
        'dataDetalle
        '
        Me.dataDetalle.AllowUserToAddRows = False
        Me.dataDetalle.AllowUserToDeleteRows = False
        Me.dataDetalle.AllowUserToResizeColumns = False
        Me.dataDetalle.AllowUserToResizeRows = False
        Me.dataDetalle.BackgroundColor = System.Drawing.Color.White
        Me.dataDetalle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataDetalle.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dataDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataDetalle.DefaultCellStyle = DataGridViewCellStyle5
        Me.dataDetalle.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dataDetalle.Location = New System.Drawing.Point(285, 178)
        Me.dataDetalle.MultiSelect = False
        Me.dataDetalle.Name = "dataDetalle"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataDetalle.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dataDetalle.RowHeadersVisible = False
        Me.dataDetalle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dataDetalle.SelectAllSignVisible = False
        Me.dataDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dataDetalle.ShowEditingIcon = False
        Me.dataDetalle.Size = New System.Drawing.Size(692, 287)
        Me.dataDetalle.TabIndex = 7
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.lblTC)
        Me.GroupBox5.Controls.Add(Me.optDolares)
        Me.GroupBox5.Controls.Add(Me.optMoneda)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox5.Location = New System.Drawing.Point(625, 471)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(153, 70)
        Me.GroupBox5.TabIndex = 102
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Tipo de Moneda"
        Me.GroupBox5.Visible = False
        '
        'lblTC
        '
        Me.lblTC.AutoSize = True
        '
        '
        '
        Me.lblTC.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblTC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblTC.Location = New System.Drawing.Point(33, 47)
        Me.lblTC.Name = "lblTC"
        Me.lblTC.Size = New System.Drawing.Size(99, 15)
        Me.lblTC.TabIndex = 63
        Me.lblTC.Text = "Tipo Cambio 0.000"
        '
        'optDolares
        '
        Me.optDolares.AutoSize = True
        Me.optDolares.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optDolares.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.optDolares.Location = New System.Drawing.Point(84, 22)
        Me.optDolares.Name = "optDolares"
        Me.optDolares.Size = New System.Drawing.Size(68, 17)
        Me.optDolares.TabIndex = 3
        Me.optDolares.TabStop = True
        Me.optDolares.Text = "Dolares"
        Me.optDolares.UseVisualStyleBackColor = True
        '
        'optMoneda
        '
        Me.optMoneda.AutoSize = True
        Me.optMoneda.Checked = True
        Me.optMoneda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optMoneda.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.optMoneda.Location = New System.Drawing.Point(12, 22)
        Me.optMoneda.Name = "optMoneda"
        Me.optMoneda.Size = New System.Drawing.Size(70, 17)
        Me.optMoneda.TabIndex = 0
        Me.optMoneda.TabStop = True
        Me.optMoneda.Text = "Moneda"
        Me.optMoneda.UseVisualStyleBackColor = True
        '
        'p_salidas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(986, 553)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.dataArticulo)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbDocumentos)
        Me.Controls.Add(Me.chkIGV)
        Me.Controls.Add(Me.lblItems)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtIGV)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtSubTotal)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.mcFSalida)
        Me.Controls.Add(Me.gbp)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.dataDetalle)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "p_salidas"
        Me.Text = "Proceso: REGISTRO DE SALIDAS"
        CType(Me.dataArticulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.gbDocumentos.ResumeLayout(False)
        Me.gbDocumentos.PerformLayout()
        Me.gbp.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dataDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkIGV As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents lblItems As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtIGV As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtSubTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents dataArticulo As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents mcFSalida As DevComponents.Editors.DateTimeAdv.MonthCalendarAdv
    Friend WithEvents gbp As System.Windows.Forms.GroupBox
    Friend WithEvents bp As System.Windows.Forms.ProgressBar
    Friend WithEvents txtObs As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdImprimir As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents cmdAnular As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents cmdCancelar As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents cmdGrabar As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents dataDetalle As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents gbDocumentos As System.Windows.Forms.GroupBox
    Friend WithEvents txtNroGuia As System.Windows.Forms.TextBox
    Friend WithEvents txtSerGuia As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNroDocumento As System.Windows.Forms.TextBox
    Friend WithEvents txtSerDocumento As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtDirEntrega As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtRuc As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents cboAlmacen As System.Windows.Forms.ComboBox
    Friend WithEvents cboCliente As System.Windows.Forms.ComboBox
    Friend WithEvents cboFormaPago As System.Windows.Forms.ComboBox
    Friend WithEvents cboDocumento As System.Windows.Forms.ComboBox
    Friend WithEvents txtBuscar As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents lblTC As DevComponents.DotNetBar.LabelX
    Friend WithEvents optDolares As RadioButton
    Friend WithEvents optMoneda As RadioButton
End Class
