<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class p_ingresos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(p_ingresos))
        Me.txtSerPedido = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblIndice = New DevComponents.DotNetBar.LabelX()
        Me.LabelX13 = New DevComponents.DotNetBar.LabelX()
        Me.txtNroPedido = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.dataArticulo = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.cmdHistorial = New DevExpress.DXCore.Controls.XtraEditors.SimpleButton()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.cboArea = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.lblTransferencia = New DevComponents.DotNetBar.LabelX()
        Me.chkAlmaTransferencia = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.cboAlmaTransferencia = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.dataDetalle = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtSubTotal = New System.Windows.Forms.TextBox()
        Me.txtIGV = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX10 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX11 = New DevComponents.DotNetBar.LabelX()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.chkIGV = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.lblTC = New DevComponents.DotNetBar.LabelX()
        Me.optDolares = New System.Windows.Forms.RadioButton()
        Me.optMoneda = New System.Windows.Forms.RadioButton()
        Me.txtBuscar = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txtObs = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.mcFIngreso = New DevComponents.Editors.DateTimeAdv.MonthCalendarAdv()
        Me.grpProveedor = New System.Windows.Forms.GroupBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.txtDireccion = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtRUC = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.cboProveedor = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.lblObs = New DevComponents.DotNetBar.LabelX()
        Me.grpDocumento = New System.Windows.Forms.GroupBox()
        Me.cboDocumento = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.txtNroGuia = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtSerGuia = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNroDocumento = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtSerDocumento = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX12 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.grpAlmacen = New System.Windows.Forms.GroupBox()
        Me.cboFPago = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.cboAlmacen = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.lblFormaPago = New DevComponents.DotNetBar.LabelX()
        Me.lblItems = New DevComponents.DotNetBar.LabelX()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmdImprimir = New DevExpress.DXCore.Controls.XtraEditors.SimpleButton()
        Me.cmdEliminar = New DevExpress.DXCore.Controls.XtraEditors.SimpleButton()
        Me.cmdCancelar = New DevExpress.DXCore.Controls.XtraEditors.SimpleButton()
        Me.cmdGrabar = New DevExpress.DXCore.Controls.XtraEditors.SimpleButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataArticulo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        CType(Me.dataDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpProveedor.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDocumento.SuspendLayout()
        Me.grpAlmacen.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtSerPedido
        '
        Me.txtSerPedido.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtSerPedido.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSerPedido.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerPedido.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtSerPedido.Location = New System.Drawing.Point(584, 9)
        Me.txtSerPedido.MaxLength = 3
        Me.txtSerPedido.Name = "txtSerPedido"
        Me.txtSerPedido.ReadOnly = True
        Me.txtSerPedido.Size = New System.Drawing.Size(68, 19)
        Me.txtSerPedido.TabIndex = 1042
        Me.txtSerPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.cefe.My.Resources.Resources.buscar20
        Me.PictureBox1.Location = New System.Drawing.Point(765, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 115
        Me.PictureBox1.TabStop = False
        '
        'lblIndice
        '
        '
        '
        '
        Me.lblIndice.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblIndice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIndice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblIndice.Location = New System.Drawing.Point(7, 9)
        Me.lblIndice.Name = "lblIndice"
        Me.lblIndice.Size = New System.Drawing.Size(151, 20)
        Me.lblIndice.TabIndex = 114
        Me.lblIndice.Text = "."
        Me.lblIndice.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'LabelX13
        '
        Me.LabelX13.AutoSize = True
        '
        '
        '
        Me.LabelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX13.ForeColor = System.Drawing.Color.Black
        Me.LabelX13.Location = New System.Drawing.Point(427, 9)
        Me.LabelX13.Name = "LabelX13"
        Me.LabelX13.Size = New System.Drawing.Size(135, 17)
        Me.LabelX13.TabIndex = 113
        Me.LabelX13.Text = "Nro Orden de Compra"
        Me.LabelX13.Visible = False
        '
        'txtNroPedido
        '
        Me.txtNroPedido.BackColor = System.Drawing.Color.Beige
        Me.txtNroPedido.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroPedido.ForeColor = System.Drawing.Color.SteelBlue
        Me.txtNroPedido.Location = New System.Drawing.Point(658, 6)
        Me.txtNroPedido.MaxLength = 8
        Me.txtNroPedido.Name = "txtNroPedido"
        Me.txtNroPedido.Size = New System.Drawing.Size(108, 22)
        Me.txtNroPedido.TabIndex = 0
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(636, 4)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(16, 22)
        Me.Label15.TabIndex = 112
        Me.Label15.Text = "-"
        '
        'dataArticulo
        '
        Me.dataArticulo.AllowUserToAddRows = False
        Me.dataArticulo.AllowUserToDeleteRows = False
        Me.dataArticulo.AllowUserToResizeColumns = False
        Me.dataArticulo.AllowUserToResizeRows = False
        Me.dataArticulo.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.dataArticulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dataArticulo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataArticulo.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dataArticulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataArticulo.DefaultCellStyle = DataGridViewCellStyle2
        Me.dataArticulo.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dataArticulo.Location = New System.Drawing.Point(426, 159)
        Me.dataArticulo.MultiSelect = False
        Me.dataArticulo.Name = "dataArticulo"
        Me.dataArticulo.ReadOnly = True
        Me.dataArticulo.RowHeadersVisible = False
        Me.dataArticulo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dataArticulo.SelectAllSignVisible = False
        Me.dataArticulo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataArticulo.ShowEditingIcon = False
        Me.dataArticulo.Size = New System.Drawing.Size(360, 274)
        Me.dataArticulo.TabIndex = 7
        Me.dataArticulo.Visible = False
        '
        'cmdHistorial
        '
        Me.cmdHistorial.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmdHistorial.Appearance.Options.UseFont = True
        Me.cmdHistorial.Image = Global.cefe.My.Resources.Resources.kardex
        Me.cmdHistorial.ImageLocation = DevExpress.DXCore.Controls.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdHistorial.Location = New System.Drawing.Point(809, 148)
        Me.cmdHistorial.LookAndFeel.SkinName = "Black"
        Me.cmdHistorial.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdHistorial.Name = "cmdHistorial"
        Me.cmdHistorial.Size = New System.Drawing.Size(158, 27)
        Me.cmdHistorial.TabIndex = 109
        Me.cmdHistorial.Text = "Historial de Compras"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.cboArea)
        Me.GroupBox7.Controls.Add(Me.lblTransferencia)
        Me.GroupBox7.Controls.Add(Me.chkAlmaTransferencia)
        Me.GroupBox7.Controls.Add(Me.cboAlmaTransferencia)
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox7.Location = New System.Drawing.Point(802, 440)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(170, 126)
        Me.GroupBox7.TabIndex = 108
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Grabar y Transferir a:"
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
        Me.cboArea.Location = New System.Drawing.Point(7, 70)
        Me.cboArea.Name = "cboArea"
        Me.cboArea.Size = New System.Drawing.Size(157, 21)
        Me.cboArea.TabIndex = 65
        Me.cboArea.WatermarkColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'lblTransferencia
        '
        '
        '
        '
        Me.lblTransferencia.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblTransferencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransferencia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblTransferencia.Location = New System.Drawing.Point(9, 100)
        Me.lblTransferencia.Name = "lblTransferencia"
        Me.lblTransferencia.Size = New System.Drawing.Size(151, 20)
        Me.lblTransferencia.TabIndex = 64
        Me.lblTransferencia.Text = "Tr."
        Me.lblTransferencia.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'chkAlmaTransferencia
        '
        Me.chkAlmaTransferencia.AutoSize = True
        '
        '
        '
        Me.chkAlmaTransferencia.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chkAlmaTransferencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAlmaTransferencia.Location = New System.Drawing.Point(5, 21)
        Me.chkAlmaTransferencia.Name = "chkAlmaTransferencia"
        Me.chkAlmaTransferencia.Size = New System.Drawing.Size(67, 15)
        Me.chkAlmaTransferencia.TabIndex = 63
        Me.chkAlmaTransferencia.Text = "Almacén"
        Me.chkAlmaTransferencia.TextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        '
        'cboAlmaTransferencia
        '
        Me.cboAlmaTransferencia.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboAlmaTransferencia.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cboAlmaTransferencia.DisplayMember = "Text"
        Me.cboAlmaTransferencia.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboAlmaTransferencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAlmaTransferencia.Enabled = False
        Me.cboAlmaTransferencia.FocusHighlightColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.cboAlmaTransferencia.FocusHighlightEnabled = True
        Me.cboAlmaTransferencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAlmaTransferencia.ForeColor = System.Drawing.Color.Black
        Me.cboAlmaTransferencia.ItemHeight = 16
        Me.cboAlmaTransferencia.Location = New System.Drawing.Point(6, 41)
        Me.cboAlmaTransferencia.Name = "cboAlmaTransferencia"
        Me.cboAlmaTransferencia.Size = New System.Drawing.Size(158, 22)
        Me.cboAlmaTransferencia.TabIndex = 1
        '
        'dataDetalle
        '
        Me.dataDetalle.AllowUserToAddRows = False
        Me.dataDetalle.AllowUserToDeleteRows = False
        Me.dataDetalle.AllowUserToResizeColumns = False
        Me.dataDetalle.AllowUserToResizeRows = False
        Me.dataDetalle.BackgroundColor = System.Drawing.Color.White
        Me.dataDetalle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataDetalle.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dataDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataDetalle.DefaultCellStyle = DataGridViewCellStyle4
        Me.dataDetalle.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dataDetalle.Location = New System.Drawing.Point(7, 159)
        Me.dataDetalle.MultiSelect = False
        Me.dataDetalle.Name = "dataDetalle"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataDetalle.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dataDetalle.RowHeadersVisible = False
        Me.dataDetalle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dataDetalle.SelectAllSignVisible = False
        Me.dataDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dataDetalle.ShowEditingIcon = False
        Me.dataDetalle.Size = New System.Drawing.Size(785, 319)
        Me.dataDetalle.TabIndex = 8
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtSubTotal)
        Me.GroupBox2.Controls.Add(Me.txtIGV)
        Me.GroupBox2.Controls.Add(Me.txtTotal)
        Me.GroupBox2.Controls.Add(Me.LabelX9)
        Me.GroupBox2.Controls.Add(Me.LabelX10)
        Me.GroupBox2.Controls.Add(Me.LabelX11)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(598, 474)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(194, 90)
        Me.GroupBox2.TabIndex = 107
        Me.GroupBox2.TabStop = False
        '
        'txtSubTotal
        '
        Me.txtSubTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubTotal.ForeColor = System.Drawing.Color.Green
        Me.txtSubTotal.Location = New System.Drawing.Point(73, 19)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.ReadOnly = True
        Me.txtSubTotal.Size = New System.Drawing.Size(115, 20)
        Me.txtSubTotal.TabIndex = 54
        Me.txtSubTotal.TabStop = False
        Me.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtIGV
        '
        Me.txtIGV.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtIGV.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIGV.ForeColor = System.Drawing.Color.Green
        Me.txtIGV.Location = New System.Drawing.Point(73, 43)
        Me.txtIGV.Name = "txtIGV"
        Me.txtIGV.ReadOnly = True
        Me.txtIGV.Size = New System.Drawing.Size(115, 21)
        Me.txtIGV.TabIndex = 56
        Me.txtIGV.TabStop = False
        Me.txtIGV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.ForeColor = System.Drawing.Color.Green
        Me.txtTotal.Location = New System.Drawing.Point(73, 68)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(115, 21)
        Me.txtTotal.TabIndex = 58
        Me.txtTotal.TabStop = False
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabelX9
        '
        Me.LabelX9.AutoSize = True
        '
        '
        '
        Me.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX9.ForeColor = System.Drawing.Color.Green
        Me.LabelX9.Location = New System.Drawing.Point(7, 21)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.Size = New System.Drawing.Size(60, 17)
        Me.LabelX9.TabIndex = 103
        Me.LabelX9.Text = "Sub Total"
        '
        'LabelX10
        '
        Me.LabelX10.AutoSize = True
        '
        '
        '
        Me.LabelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX10.ForeColor = System.Drawing.Color.Green
        Me.LabelX10.Location = New System.Drawing.Point(41, 46)
        Me.LabelX10.Name = "LabelX10"
        Me.LabelX10.Size = New System.Drawing.Size(25, 16)
        Me.LabelX10.TabIndex = 104
        Me.LabelX10.Text = "IMP"
        '
        'LabelX11
        '
        Me.LabelX11.AutoSize = True
        '
        '
        '
        Me.LabelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX11.ForeColor = System.Drawing.Color.Green
        Me.LabelX11.Location = New System.Drawing.Point(34, 70)
        Me.LabelX11.Name = "LabelX11"
        Me.LabelX11.Size = New System.Drawing.Size(33, 17)
        Me.LabelX11.TabIndex = 105
        Me.LabelX11.Text = "Total"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LabelX6)
        Me.GroupBox1.Controls.Add(Me.GroupBox6)
        Me.GroupBox1.Controls.Add(Me.LabelX7)
        Me.GroupBox1.Controls.Add(Me.chkIGV)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(802, 184)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(170, 247)
        Me.GroupBox1.TabIndex = 106
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Parámetros de Registro"
        '
        'LabelX6
        '
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LabelX6.Location = New System.Drawing.Point(19, 145)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(139, 48)
        Me.LabelX6.TabIndex = 101
        Me.LabelX6.Text = "El último Precio Registrado, se muestra sin Impuesto y en Moneda Nacional"
        Me.LabelX6.WordWrap = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(36, 187)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(100, 10)
        Me.GroupBox6.TabIndex = 98
        Me.GroupBox6.TabStop = False
        '
        'LabelX7
        '
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LabelX7.Location = New System.Drawing.Point(19, 199)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(139, 43)
        Me.LabelX7.TabIndex = 108
        Me.LabelX7.Text = "*Los Precios de Compra solo almacenan 5 dígitos decimales"
        Me.LabelX7.WordWrap = True
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
        Me.chkIGV.Location = New System.Drawing.Point(7, 42)
        Me.chkIGV.Name = "chkIGV"
        Me.chkIGV.Size = New System.Drawing.Size(130, 15)
        Me.chkIGV.TabIndex = 62
        Me.chkIGV.Text = "Precios Incluyen IMP"
        Me.chkIGV.TextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.lblTC)
        Me.GroupBox5.Controls.Add(Me.optDolares)
        Me.GroupBox5.Controls.Add(Me.optMoneda)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox5.Location = New System.Drawing.Point(7, 73)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(157, 66)
        Me.GroupBox5.TabIndex = 100
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Tipo de Moneda"
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
        'txtBuscar
        '
        '
        '
        '
        Me.txtBuscar.Border.Class = "TextBoxBorder"
        Me.txtBuscar.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtBuscar.FocusHighlightEnabled = True
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(555, 134)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(205, 21)
        Me.txtBuscar.TabIndex = 6
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.cefe.My.Resources.Resources.buscar20
        Me.PictureBox2.Location = New System.Drawing.Point(759, 134)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 96
        Me.PictureBox2.TabStop = False
        '
        'txtObs
        '
        '
        '
        '
        Me.txtObs.Border.Class = "TextBoxBorder"
        Me.txtObs.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtObs.FocusHighlightEnabled = True
        Me.txtObs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObs.Location = New System.Drawing.Point(49, 133)
        Me.txtObs.Name = "txtObs"
        Me.txtObs.Size = New System.Drawing.Size(439, 21)
        Me.txtObs.TabIndex = 4
        '
        'LabelX5
        '
        Me.LabelX5.AutoSize = True
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX5.ForeColor = System.Drawing.Color.Maroon
        Me.LabelX5.Location = New System.Drawing.Point(504, 136)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(48, 17)
        Me.LabelX5.TabIndex = 5
        Me.LabelX5.Text = "Artículo"
        '
        'mcFIngreso
        '
        Me.mcFIngreso.AnnuallyMarkedDates = New Date(-1) {}
        Me.mcFIngreso.AutoSize = True
        '
        '
        '
        Me.mcFIngreso.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.mcFIngreso.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.mcFIngreso.BackgroundStyle.BorderBottomWidth = 1
        Me.mcFIngreso.BackgroundStyle.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.mcFIngreso.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.mcFIngreso.BackgroundStyle.BorderLeftWidth = 1
        Me.mcFIngreso.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.mcFIngreso.BackgroundStyle.BorderRightWidth = 1
        Me.mcFIngreso.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.mcFIngreso.BackgroundStyle.BorderTopWidth = 1
        Me.mcFIngreso.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.mcFIngreso.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.mcFIngreso.ContainerControlProcessDialogKey = True
        Me.mcFIngreso.DisplayMonth = New Date(2010, 10, 1, 0, 0, 0, 0)
        Me.mcFIngreso.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.mcFIngreso.Location = New System.Drawing.Point(802, 14)
        Me.mcFIngreso.MarkedDates = New Date(-1) {}
        Me.mcFIngreso.MaxDate = New Date(2020, 12, 31, 0, 0, 0, 0)
        Me.mcFIngreso.MinDate = New Date(2010, 1, 1, 0, 0, 0, 0)
        Me.mcFIngreso.MonthlyMarkedDates = New Date(-1) {}
        Me.mcFIngreso.Name = "mcFIngreso"
        '
        '
        '
        Me.mcFIngreso.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.mcFIngreso.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.mcFIngreso.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.mcFIngreso.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.mcFIngreso.Size = New System.Drawing.Size(170, 131)
        Me.mcFIngreso.TabIndex = 48
        Me.mcFIngreso.TabStop = False
        Me.mcFIngreso.Text = "MonthCalendarAdv1"
        Me.mcFIngreso.TwoLetterDayName = False
        Me.mcFIngreso.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        '
        'grpProveedor
        '
        Me.grpProveedor.Controls.Add(Me.PictureBox3)
        Me.grpProveedor.Controls.Add(Me.txtDireccion)
        Me.grpProveedor.Controls.Add(Me.txtRUC)
        Me.grpProveedor.Controls.Add(Me.cboProveedor)
        Me.grpProveedor.Controls.Add(Me.LabelX4)
        Me.grpProveedor.Controls.Add(Me.LabelX2)
        Me.grpProveedor.Controls.Add(Me.LabelX1)
        Me.grpProveedor.Location = New System.Drawing.Point(7, 29)
        Me.grpProveedor.Name = "grpProveedor"
        Me.grpProveedor.Size = New System.Drawing.Size(585, 68)
        Me.grpProveedor.TabIndex = 0
        Me.grpProveedor.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.cefe.My.Resources.Resources.buscar20
        Me.PictureBox3.Location = New System.Drawing.Point(405, 21)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 97
        Me.PictureBox3.TabStop = False
        '
        'txtDireccion
        '
        Me.txtDireccion.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.txtDireccion.Border.Class = "TextBoxBorder"
        Me.txtDireccion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.ForeColor = System.Drawing.Color.Black
        Me.txtDireccion.Location = New System.Drawing.Point(80, 45)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.ReadOnly = True
        Me.txtDireccion.Size = New System.Drawing.Size(496, 21)
        Me.txtDireccion.TabIndex = 5
        Me.txtDireccion.TabStop = False
        '
        'txtRUC
        '
        Me.txtRUC.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.txtRUC.Border.Class = "TextBoxBorder"
        Me.txtRUC.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtRUC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRUC.ForeColor = System.Drawing.Color.Black
        Me.txtRUC.Location = New System.Drawing.Point(466, 19)
        Me.txtRUC.Name = "txtRUC"
        Me.txtRUC.ReadOnly = True
        Me.txtRUC.Size = New System.Drawing.Size(110, 21)
        Me.txtRUC.TabIndex = 3
        Me.txtRUC.TabStop = False
        '
        'cboProveedor
        '
        Me.cboProveedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboProveedor.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboProveedor.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cboProveedor.DisplayMember = "Text"
        Me.cboProveedor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboProveedor.FocusHighlightColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.cboProveedor.FocusHighlightEnabled = True
        Me.cboProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProveedor.ForeColor = System.Drawing.Color.Black
        Me.cboProveedor.ItemHeight = 15
        Me.cboProveedor.Location = New System.Drawing.Point(80, 19)
        Me.cboProveedor.Name = "cboProveedor"
        Me.cboProveedor.Size = New System.Drawing.Size(329, 21)
        Me.cboProveedor.TabIndex = 1
        '
        'LabelX4
        '
        Me.LabelX4.AutoSize = True
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.ForeColor = System.Drawing.Color.Black
        Me.LabelX4.Location = New System.Drawing.Point(431, 21)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(29, 16)
        Me.LabelX4.TabIndex = 2
        Me.LabelX4.Text = "RUC"
        '
        'LabelX2
        '
        Me.LabelX2.AutoSize = True
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.ForeColor = System.Drawing.Color.Black
        Me.LabelX2.Location = New System.Drawing.Point(10, 48)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(59, 17)
        Me.LabelX2.TabIndex = 4
        Me.LabelX2.Text = "Dirección"
        '
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.ForeColor = System.Drawing.Color.Black
        Me.LabelX1.Location = New System.Drawing.Point(10, 21)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(65, 17)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "Proveedor"
        '
        'lblObs
        '
        Me.lblObs.AutoSize = True
        '
        '
        '
        Me.lblObs.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblObs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblObs.ForeColor = System.Drawing.Color.Black
        Me.lblObs.Location = New System.Drawing.Point(12, 135)
        Me.lblObs.Name = "lblObs"
        Me.lblObs.Size = New System.Drawing.Size(31, 17)
        Me.lblObs.TabIndex = 3
        Me.lblObs.Text = "Obs."
        '
        'grpDocumento
        '
        Me.grpDocumento.Controls.Add(Me.cboDocumento)
        Me.grpDocumento.Controls.Add(Me.txtNroGuia)
        Me.grpDocumento.Controls.Add(Me.txtSerGuia)
        Me.grpDocumento.Controls.Add(Me.Label1)
        Me.grpDocumento.Controls.Add(Me.txtNroDocumento)
        Me.grpDocumento.Controls.Add(Me.txtSerDocumento)
        Me.grpDocumento.Controls.Add(Me.LabelX12)
        Me.grpDocumento.Controls.Add(Me.LabelX8)
        Me.grpDocumento.Controls.Add(Me.Label2)
        Me.grpDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDocumento.Location = New System.Drawing.Point(7, 87)
        Me.grpDocumento.Name = "grpDocumento"
        Me.grpDocumento.Size = New System.Drawing.Size(585, 40)
        Me.grpDocumento.TabIndex = 1
        Me.grpDocumento.TabStop = False
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
        Me.cboDocumento.Location = New System.Drawing.Point(84, 18)
        Me.cboDocumento.Name = "cboDocumento"
        Me.cboDocumento.Size = New System.Drawing.Size(162, 21)
        Me.cboDocumento.TabIndex = 9
        '
        'txtNroGuia
        '
        '
        '
        '
        Me.txtNroGuia.Border.Class = "TextBoxBorder"
        Me.txtNroGuia.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNroGuia.FocusHighlightEnabled = True
        Me.txtNroGuia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroGuia.Location = New System.Drawing.Point(493, 18)
        Me.txtNroGuia.Name = "txtNroGuia"
        Me.txtNroGuia.Size = New System.Drawing.Size(85, 21)
        Me.txtNroGuia.TabIndex = 8
        '
        'txtSerGuia
        '
        '
        '
        '
        Me.txtSerGuia.Border.Class = "TextBoxBorder"
        Me.txtSerGuia.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtSerGuia.FocusHighlightEnabled = True
        Me.txtSerGuia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerGuia.Location = New System.Drawing.Point(451, 18)
        Me.txtSerGuia.Name = "txtSerGuia"
        Me.txtSerGuia.Size = New System.Drawing.Size(30, 21)
        Me.txtSerGuia.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(480, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(14, 19)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "-"
        '
        'txtNroDocumento
        '
        '
        '
        '
        Me.txtNroDocumento.Border.Class = "TextBoxBorder"
        Me.txtNroDocumento.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNroDocumento.FocusHighlightEnabled = True
        Me.txtNroDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroDocumento.Location = New System.Drawing.Point(320, 18)
        Me.txtNroDocumento.Name = "txtNroDocumento"
        Me.txtNroDocumento.Size = New System.Drawing.Size(89, 21)
        Me.txtNroDocumento.TabIndex = 4
        '
        'txtSerDocumento
        '
        '
        '
        '
        Me.txtSerDocumento.Border.Class = "TextBoxBorder"
        Me.txtSerDocumento.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtSerDocumento.FocusHighlightEnabled = True
        Me.txtSerDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerDocumento.Location = New System.Drawing.Point(248, 18)
        Me.txtSerDocumento.Name = "txtSerDocumento"
        Me.txtSerDocumento.Size = New System.Drawing.Size(60, 21)
        Me.txtSerDocumento.TabIndex = 2
        '
        'LabelX12
        '
        Me.LabelX12.AutoSize = True
        '
        '
        '
        Me.LabelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX12.ForeColor = System.Drawing.Color.Black
        Me.LabelX12.Location = New System.Drawing.Point(10, 19)
        Me.LabelX12.Name = "LabelX12"
        Me.LabelX12.Size = New System.Drawing.Size(71, 17)
        Me.LabelX12.TabIndex = 0
        Me.LabelX12.Text = "Documento"
        '
        'LabelX8
        '
        Me.LabelX8.AutoSize = True
        '
        '
        '
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX8.ForeColor = System.Drawing.Color.Black
        Me.LabelX8.Location = New System.Drawing.Point(417, 20)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(31, 17)
        Me.LabelX8.TabIndex = 5
        Me.LabelX8.Text = "Guia"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(307, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(14, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "-"
        '
        'GroupBox4
        '
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(-39, 149)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(851, 10)
        Me.GroupBox4.TabIndex = 97
        Me.GroupBox4.TabStop = False
        '
        'grpAlmacen
        '
        Me.grpAlmacen.Controls.Add(Me.cboFPago)
        Me.grpAlmacen.Controls.Add(Me.cboAlmacen)
        Me.grpAlmacen.Controls.Add(Me.LabelX3)
        Me.grpAlmacen.Controls.Add(Me.lblFormaPago)
        Me.grpAlmacen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpAlmacen.Location = New System.Drawing.Point(597, 25)
        Me.grpAlmacen.Name = "grpAlmacen"
        Me.grpAlmacen.Size = New System.Drawing.Size(194, 105)
        Me.grpAlmacen.TabIndex = 2
        Me.grpAlmacen.TabStop = False
        '
        'cboFPago
        '
        Me.cboFPago.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboFPago.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cboFPago.DisplayMember = "Text"
        Me.cboFPago.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboFPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFPago.FocusHighlightColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.cboFPago.FocusHighlightEnabled = True
        Me.cboFPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFPago.ForeColor = System.Drawing.Color.Black
        Me.cboFPago.ItemHeight = 15
        Me.cboFPago.Location = New System.Drawing.Point(10, 81)
        Me.cboFPago.Name = "cboFPago"
        Me.cboFPago.Size = New System.Drawing.Size(173, 21)
        Me.cboFPago.TabIndex = 3
        '
        'cboAlmacen
        '
        Me.cboAlmacen.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboAlmacen.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cboAlmacen.DisplayMember = "Text"
        Me.cboAlmacen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboAlmacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAlmacen.FocusHighlightColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.cboAlmacen.FocusHighlightEnabled = True
        Me.cboAlmacen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAlmacen.ForeColor = System.Drawing.Color.Black
        Me.cboAlmacen.ItemHeight = 15
        Me.cboAlmacen.Location = New System.Drawing.Point(10, 35)
        Me.cboAlmacen.Name = "cboAlmacen"
        Me.cboAlmacen.Size = New System.Drawing.Size(173, 21)
        Me.cboAlmacen.TabIndex = 1
        '
        'LabelX3
        '
        Me.LabelX3.AutoSize = True
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.ForeColor = System.Drawing.Color.Black
        Me.LabelX3.Location = New System.Drawing.Point(10, 16)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(55, 17)
        Me.LabelX3.TabIndex = 0
        Me.LabelX3.Text = "Almacén"
        '
        'lblFormaPago
        '
        Me.lblFormaPago.AutoSize = True
        '
        '
        '
        Me.lblFormaPago.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblFormaPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormaPago.ForeColor = System.Drawing.Color.Black
        Me.lblFormaPago.Location = New System.Drawing.Point(10, 61)
        Me.lblFormaPago.Name = "lblFormaPago"
        Me.lblFormaPago.Size = New System.Drawing.Size(76, 17)
        Me.lblFormaPago.TabIndex = 2
        Me.lblFormaPago.Text = "Forma Pago"
        '
        'lblItems
        '
        Me.lblItems.AutoSize = True
        '
        '
        '
        Me.lblItems.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblItems.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItems.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblItems.Location = New System.Drawing.Point(9, 484)
        Me.lblItems.Name = "lblItems"
        Me.lblItems.Size = New System.Drawing.Size(80, 15)
        Me.lblItems.TabIndex = 59
        Me.lblItems.Text = "Nro de Items. 0"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmdImprimir)
        Me.GroupBox3.Controls.Add(Me.cmdEliminar)
        Me.GroupBox3.Controls.Add(Me.cmdCancelar)
        Me.GroupBox3.Controls.Add(Me.cmdGrabar)
        Me.GroupBox3.Location = New System.Drawing.Point(7, 495)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(335, 71)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmdImprimir.Appearance.Options.UseFont = True
        Me.cmdImprimir.Enabled = False
        Me.cmdImprimir.Image = Global.cefe.My.Resources.Resources.print_preview
        Me.cmdImprimir.ImageLocation = DevExpress.DXCore.Controls.XtraEditors.ImageLocation.TopCenter
        Me.cmdImprimir.Location = New System.Drawing.Point(250, 18)
        Me.cmdImprimir.LookAndFeel.SkinName = "iMaginary"
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(75, 50)
        Me.cmdImprimir.TabIndex = 34
        Me.cmdImprimir.Text = "Imprimir"
        '
        'cmdEliminar
        '
        Me.cmdEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmdEliminar.Appearance.Options.UseFont = True
        Me.cmdEliminar.Enabled = False
        Me.cmdEliminar.Image = Global.cefe.My.Resources.Resources.m_borrar
        Me.cmdEliminar.ImageLocation = DevExpress.DXCore.Controls.XtraEditors.ImageLocation.TopCenter
        Me.cmdEliminar.Location = New System.Drawing.Point(169, 18)
        Me.cmdEliminar.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(75, 50)
        Me.cmdEliminar.TabIndex = 34
        Me.cmdEliminar.Text = "Eliminar"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.Enabled = False
        Me.cmdCancelar.Image = Global.cefe.My.Resources.Resources.m_cancelar
        Me.cmdCancelar.ImageLocation = DevExpress.DXCore.Controls.XtraEditors.ImageLocation.TopCenter
        Me.cmdCancelar.Location = New System.Drawing.Point(89, 18)
        Me.cmdCancelar.LookAndFeel.SkinName = "Black"
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 50)
        Me.cmdCancelar.TabIndex = 34
        Me.cmdCancelar.Text = "Nuevo"
        '
        'cmdGrabar
        '
        Me.cmdGrabar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmdGrabar.Appearance.Options.UseFont = True
        Me.cmdGrabar.Enabled = False
        Me.cmdGrabar.Image = Global.cefe.My.Resources.Resources.m_grabar
        Me.cmdGrabar.ImageLocation = DevExpress.DXCore.Controls.XtraEditors.ImageLocation.TopCenter
        Me.cmdGrabar.Location = New System.Drawing.Point(8, 18)
        Me.cmdGrabar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdGrabar.Name = "cmdGrabar"
        Me.cmdGrabar.Size = New System.Drawing.Size(75, 50)
        Me.cmdGrabar.TabIndex = 0
        Me.cmdGrabar.Text = "Grabar"
        '
        'p_ingresos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(981, 577)
        Me.Controls.Add(Me.txtSerPedido)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblIndice)
        Me.Controls.Add(Me.LabelX13)
        Me.Controls.Add(Me.txtNroPedido)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.dataArticulo)
        Me.Controls.Add(Me.cmdHistorial)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.dataDetalle)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.txtObs)
        Me.Controls.Add(Me.LabelX5)
        Me.Controls.Add(Me.mcFIngreso)
        Me.Controls.Add(Me.grpProveedor)
        Me.Controls.Add(Me.lblObs)
        Me.Controls.Add(Me.grpDocumento)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.grpAlmacen)
        Me.Controls.Add(Me.lblItems)
        Me.Controls.Add(Me.GroupBox3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = False
        Me.Name = "p_ingresos"
        Me.Text = "Proceso: REGISTRO DE INGRESOS"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataArticulo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.dataDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpProveedor.ResumeLayout(False)
        Me.grpProveedor.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDocumento.ResumeLayout(False)
        Me.grpDocumento.PerformLayout()
        Me.grpAlmacen.ResumeLayout(False)
        Me.grpAlmacen.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpProveedor As System.Windows.Forms.GroupBox
    Friend WithEvents grpAlmacen As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdImprimir As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents cmdEliminar As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents cmdCancelar As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents cmdGrabar As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents dataDetalle As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents mcFIngreso As DevComponents.Editors.DateTimeAdv.MonthCalendarAdv
    Friend WithEvents dataArticulo As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtIGV As System.Windows.Forms.TextBox
    Friend WithEvents txtSubTotal As System.Windows.Forms.TextBox
    Friend WithEvents lblItems As DevComponents.DotNetBar.LabelX
    Friend WithEvents chkIGV As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents grpDocumento As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents txtBuscar As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents optDolares As System.Windows.Forms.RadioButton
    Friend WithEvents optMoneda As System.Windows.Forms.RadioButton
    Friend WithEvents lblFormaPago As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblObs As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX10 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX11 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX12 As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblTC As DevComponents.DotNetBar.LabelX
    Friend WithEvents cboProveedor As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cboFPago As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cboAlmacen As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents txtDireccion As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtRUC As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtNroGuia As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtSerGuia As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNroDocumento As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtSerDocumento As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtObs As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents cboDocumento As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents cboAlmaTransferencia As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cmdHistorial As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents chkAlmaTransferencia As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents lblTransferencia As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtNroPedido As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents LabelX13 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cboArea As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents lblIndice As DevComponents.DotNetBar.LabelX
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtSerPedido As TextBox
    Friend WithEvents PictureBox3 As PictureBox
End Class
