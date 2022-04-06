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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(p_transferencia))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ChkSinStock = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.txtObservacion = New System.Windows.Forms.RichTextBox()
        Me.lblProducto = New DevComponents.DotNetBar.LabelX()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblRegistros = New DevComponents.DotNetBar.LabelX()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblArea = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.cboArea = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.cboOrigen = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.cboDestino = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.lblNroTransferencia = New DevComponents.DotNetBar.LabelX()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.ChKRptValorizado = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.cmdImprimir = New DevExpress.DXCore.Controls.XtraEditors.SimpleButton()
        Me.cmdNuevaT = New DevExpress.DXCore.Controls.XtraEditors.SimpleButton()
        Me.dataArticulos = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.SimpleButton1 = New DevExpress.DXCore.Controls.XtraEditors.SimpleButton()
        Me.cmdTransferir = New DevExpress.DXCore.Controls.XtraEditors.SimpleButton()
        Me.txtTransferir = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.txtBuscarTransferencia = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.dataNroTransferencias = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.txtBuscarOrigen = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.chkMostrarTransferencias = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.dataTransferencias = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.chkMostrarPedidos = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.mcFechatransferencia1 = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.mcFechaProd = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Chk_pedpendiente = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.chkmostrarOC = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.chkProduccion = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.dataArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataNroTransferencias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataTransferencias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcFechatransferencia1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcFechaProd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ChkSinStock
        '
        Me.ChkSinStock.AutoSize = True
        '
        '
        '
        Me.ChkSinStock.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ChkSinStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkSinStock.Location = New System.Drawing.Point(505, 197)
        Me.ChkSinStock.Name = "ChkSinStock"
        Me.ChkSinStock.Size = New System.Drawing.Size(157, 15)
        Me.ChkSinStock.TabIndex = 122
        Me.ChkSinStock.TabStop = False
        Me.ChkSinStock.Text = "Transferencia SIN STOCK"
        '
        'txtObservacion
        '
        Me.txtObservacion.Location = New System.Drawing.Point(691, 159)
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Size = New System.Drawing.Size(235, 53)
        Me.txtObservacion.TabIndex = 121
        Me.txtObservacion.Text = ""
        '
        'lblProducto
        '
        Me.lblProducto.AutoSize = True
        '
        '
        '
        Me.lblProducto.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProducto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblProducto.Location = New System.Drawing.Point(198, 11)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(100, 15)
        Me.lblProducto.TabIndex = 108
        Me.lblProducto.Text = "Descipcion Artículo"
        Me.lblProducto.WordWrap = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(6, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(175, 18)
        Me.Label2.TabIndex = 107
        Me.Label2.Text = "Fecha de Transferencia"
        '
        'lblRegistros
        '
        '
        '
        '
        Me.lblRegistros.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblRegistros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistros.ForeColor = System.Drawing.Color.Maroon
        Me.lblRegistros.Location = New System.Drawing.Point(413, 213)
        Me.lblRegistros.Name = "lblRegistros"
        Me.lblRegistros.Size = New System.Drawing.Size(184, 19)
        Me.lblRegistros.TabIndex = 120
        Me.lblRegistros.Text = "Nº de Registros Procesados... 0"
        Me.lblRegistros.TextAlignment = System.Drawing.StringAlignment.Far
        Me.lblRegistros.WordWrap = True
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
        Me.GroupBox1.Location = New System.Drawing.Point(688, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(235, 95)
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
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LabelX2.Location = New System.Drawing.Point(9, 18)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(37, 15)
        Me.LabelX2.TabIndex = 0
        Me.LabelX2.Text = "Origen"
        '
        'lblNroTransferencia
        '
        '
        '
        '
        Me.lblNroTransferencia.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblNroTransferencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNroTransferencia.ForeColor = System.Drawing.Color.Maroon
        Me.lblNroTransferencia.Location = New System.Drawing.Point(3, 131)
        Me.lblNroTransferencia.Name = "lblNroTransferencia"
        Me.lblNroTransferencia.Size = New System.Drawing.Size(185, 21)
        Me.lblNroTransferencia.TabIndex = 89
        Me.lblNroTransferencia.Text = "Nº"
        Me.lblNroTransferencia.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.ChKRptValorizado)
        Me.GroupBox6.Controls.Add(Me.cmdImprimir)
        Me.GroupBox6.Controls.Add(Me.cmdNuevaT)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox6.Location = New System.Drawing.Point(688, 90)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(230, 68)
        Me.GroupBox6.TabIndex = 4
        Me.GroupBox6.TabStop = False
        '
        'ChKRptValorizado
        '
        Me.ChKRptValorizado.AutoSize = True
        '
        '
        '
        Me.ChKRptValorizado.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ChKRptValorizado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChKRptValorizado.Location = New System.Drawing.Point(112, 45)
        Me.ChKRptValorizado.Name = "ChKRptValorizado"
        Me.ChKRptValorizado.Size = New System.Drawing.Size(120, 15)
        Me.ChKRptValorizado.TabIndex = 105
        Me.ChKRptValorizado.TabStop = False
        Me.ChKRptValorizado.Text = "Reporte Valorizado "
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmdImprimir.Appearance.Options.UseFont = True
        Me.cmdImprimir.Image = CType(resources.GetObject("cmdImprimir.Image"), System.Drawing.Image)
        Me.cmdImprimir.ImageLocation = DevExpress.DXCore.Controls.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdImprimir.Location = New System.Drawing.Point(144, 12)
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
        Me.cmdNuevaT.ImageLocation = DevExpress.DXCore.Controls.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdNuevaT.Location = New System.Drawing.Point(16, 12)
        Me.cmdNuevaT.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdNuevaT.Name = "cmdNuevaT"
        Me.cmdNuevaT.Size = New System.Drawing.Size(108, 32)
        Me.cmdNuevaT.TabIndex = 103
        Me.cmdNuevaT.Text = "Nueva Transf."
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
        Me.dataArticulos.Location = New System.Drawing.Point(187, 29)
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
        Me.dataArticulos.Size = New System.Drawing.Size(500, 133)
        Me.dataArticulos.StandardTab = True
        Me.dataArticulos.TabIndex = 2
        Me.dataArticulos.TabStop = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.SimpleButton1)
        Me.GroupBox5.Controls.Add(Me.cmdTransferir)
        Me.GroupBox5.Controls.Add(Me.txtTransferir)
        Me.GroupBox5.Controls.Add(Me.LabelX3)
        Me.GroupBox5.Controls.Add(Me.PictureBox1)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox5.Location = New System.Drawing.Point(219, 159)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(435, 38)
        Me.GroupBox5.TabIndex = 105
        Me.GroupBox5.TabStop = False
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Image = Global.cefe.My.Resources.Resources.m_grabar20
        Me.SimpleButton1.ImageLocation = DevExpress.DXCore.Controls.XtraEditors.ImageLocation.MiddleLeft
        Me.SimpleButton1.Location = New System.Drawing.Point(312, 9)
        Me.SimpleButton1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(113, 28)
        Me.SimpleButton1.TabIndex = 124
        Me.SimpleButton1.Text = "Grabar Transf."
        '
        'cmdTransferir
        '
        Me.cmdTransferir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmdTransferir.Appearance.Options.UseFont = True
        Me.cmdTransferir.Image = CType(resources.GetObject("cmdTransferir.Image"), System.Drawing.Image)
        Me.cmdTransferir.ImageLocation = DevExpress.DXCore.Controls.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdTransferir.Location = New System.Drawing.Point(195, 9)
        Me.cmdTransferir.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdTransferir.Name = "cmdTransferir"
        Me.cmdTransferir.Size = New System.Drawing.Size(113, 28)
        Me.cmdTransferir.TabIndex = 2
        Me.cmdTransferir.Text = "Transferir"
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
        Me.txtTransferir.Location = New System.Drawing.Point(138, 11)
        Me.txtTransferir.Name = "txtTransferir"
        Me.txtTransferir.Size = New System.Drawing.Size(51, 21)
        Me.txtTransferir.TabIndex = 1
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.Location = New System.Drawing.Point(35, 9)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(65, 26)
        Me.LabelX3.TabIndex = 0
        Me.LabelX3.Text = "Cantidad a Transferir"
        Me.LabelX3.TextAlignment = System.Drawing.StringAlignment.Center
        Me.LabelX3.WordWrap = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(104, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(22, 23)
        Me.PictureBox1.TabIndex = 81
        Me.PictureBox1.TabStop = False
        '
        'LabelX8
        '
        Me.LabelX8.AutoSize = True
        '
        '
        '
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX8.ForeColor = System.Drawing.Color.Green
        Me.LabelX8.Location = New System.Drawing.Point(609, 216)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(315, 15)
        Me.LabelX8.TabIndex = 99
        Me.LabelX8.Text = "*Las Transferencias se realizan a Precio de Costo, sin Impuesto"
        Me.LabelX8.TextAlignment = System.Drawing.StringAlignment.Center
        Me.LabelX8.WordWrap = True
        '
        'LabelX6
        '
        Me.LabelX6.AutoSize = True
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX6.ForeColor = System.Drawing.Color.Maroon
        Me.LabelX6.Location = New System.Drawing.Point(133, 217)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(288, 15)
        Me.LabelX6.TabIndex = 96
        Me.LabelX6.Text = "Activo mientras NO exista una Transferencia en Proceso..."
        Me.LabelX6.TextAlignment = System.Drawing.StringAlignment.Center
        Me.LabelX6.WordWrap = True
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
        Me.txtBuscarTransferencia.Location = New System.Drawing.Point(5, 236)
        Me.txtBuscarTransferencia.Name = "txtBuscarTransferencia"
        Me.txtBuscarTransferencia.ReadOnly = True
        Me.txtBuscarTransferencia.Size = New System.Drawing.Size(109, 21)
        Me.txtBuscarTransferencia.TabIndex = 91
        '
        'dataNroTransferencias
        '
        Me.dataNroTransferencias.AllowUserToAddRows = False
        Me.dataNroTransferencias.AllowUserToDeleteRows = False
        Me.dataNroTransferencias.AllowUserToResizeColumns = False
        Me.dataNroTransferencias.AllowUserToResizeRows = False
        Me.dataNroTransferencias.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dataNroTransferencias.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataNroTransferencias.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dataNroTransferencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataNroTransferencias.DefaultCellStyle = DataGridViewCellStyle6
        Me.dataNroTransferencias.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dataNroTransferencias.Location = New System.Drawing.Point(5, 261)
        Me.dataNroTransferencias.MultiSelect = False
        Me.dataNroTransferencias.Name = "dataNroTransferencias"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataNroTransferencias.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dataNroTransferencias.RowHeadersVisible = False
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dataNroTransferencias.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.dataNroTransferencias.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dataNroTransferencias.SelectAllSignVisible = False
        Me.dataNroTransferencias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dataNroTransferencias.ShowEditingIcon = False
        Me.dataNroTransferencias.Size = New System.Drawing.Size(109, 324)
        Me.dataNroTransferencias.TabIndex = 90
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
        Me.txtBuscarOrigen.Location = New System.Drawing.Point(304, 7)
        Me.txtBuscarOrigen.Name = "txtBuscarOrigen"
        Me.txtBuscarOrigen.Size = New System.Drawing.Size(223, 20)
        Me.txtBuscarOrigen.TabIndex = 1
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.cefe.My.Resources.Resources.buscar18
        Me.PictureBox2.Location = New System.Drawing.Point(529, 8)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(18, 18)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 85
        Me.PictureBox2.TabStop = False
        '
        'chkMostrarTransferencias
        '
        Me.chkMostrarTransferencias.AutoSize = True
        '
        '
        '
        Me.chkMostrarTransferencias.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chkMostrarTransferencias.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMostrarTransferencias.Location = New System.Drawing.Point(3, 183)
        Me.chkMostrarTransferencias.Name = "chkMostrarTransferencias"
        Me.chkMostrarTransferencias.Size = New System.Drawing.Size(98, 15)
        Me.chkMostrarTransferencias.TabIndex = 84
        Me.chkMostrarTransferencias.TabStop = False
        Me.chkMostrarTransferencias.Text = "Transferencias "
        '
        'dataTransferencias
        '
        Me.dataTransferencias.AllowUserToAddRows = False
        Me.dataTransferencias.AllowUserToDeleteRows = False
        Me.dataTransferencias.AllowUserToResizeColumns = False
        Me.dataTransferencias.AllowUserToResizeRows = False
        Me.dataTransferencias.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dataTransferencias.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataTransferencias.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dataTransferencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataTransferencias.DefaultCellStyle = DataGridViewCellStyle10
        Me.dataTransferencias.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dataTransferencias.Location = New System.Drawing.Point(118, 236)
        Me.dataTransferencias.MultiSelect = False
        Me.dataTransferencias.Name = "dataTransferencias"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataTransferencias.RowHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dataTransferencias.RowHeadersVisible = False
        Me.dataTransferencias.SelectAllSignVisible = False
        Me.dataTransferencias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dataTransferencias.ShowEditingIcon = False
        Me.dataTransferencias.Size = New System.Drawing.Size(849, 349)
        Me.dataTransferencias.TabIndex = 83
        '
        'chkMostrarPedidos
        '
        Me.chkMostrarPedidos.AutoSize = True
        '
        '
        '
        Me.chkMostrarPedidos.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chkMostrarPedidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMostrarPedidos.Location = New System.Drawing.Point(3, 201)
        Me.chkMostrarPedidos.Name = "chkMostrarPedidos"
        Me.chkMostrarPedidos.Size = New System.Drawing.Size(64, 15)
        Me.chkMostrarPedidos.TabIndex = 123
        Me.chkMostrarPedidos.TabStop = False
        Me.chkMostrarPedidos.Text = "Pedidos"
        '
        'mcFechatransferencia1
        '
        '
        '
        '
        Me.mcFechatransferencia1.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.mcFechatransferencia1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.mcFechatransferencia1.ButtonDropDown.Visible = True
        Me.mcFechatransferencia1.FocusHighlightEnabled = True
        Me.mcFechatransferencia1.IsPopupCalendarOpen = False
        Me.mcFechatransferencia1.Location = New System.Drawing.Point(18, 43)
        '
        '
        '
        Me.mcFechatransferencia1.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.mcFechatransferencia1.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.mcFechatransferencia1.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.mcFechatransferencia1.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.mcFechatransferencia1.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.mcFechatransferencia1.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.mcFechatransferencia1.MonthCalendar.DisplayMonth = New Date(2007, 10, 1, 0, 0, 0, 0)
        Me.mcFechatransferencia1.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.mcFechatransferencia1.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.mcFechatransferencia1.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.mcFechatransferencia1.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.mcFechatransferencia1.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.mcFechatransferencia1.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.mcFechatransferencia1.MonthCalendar.TodayButtonVisible = True
        Me.mcFechatransferencia1.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.mcFechatransferencia1.Name = "mcFechatransferencia1"
        Me.mcFechatransferencia1.Size = New System.Drawing.Size(152, 20)
        Me.mcFechatransferencia1.TabIndex = 1036
        '
        'mcFechaProd
        '
        '
        '
        '
        Me.mcFechaProd.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.mcFechaProd.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.mcFechaProd.ButtonDropDown.Visible = True
        Me.mcFechaProd.FocusHighlightEnabled = True
        Me.mcFechaProd.IsPopupCalendarOpen = False
        Me.mcFechaProd.Location = New System.Drawing.Point(18, 98)
        '
        '
        '
        Me.mcFechaProd.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.mcFechaProd.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.mcFechaProd.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.mcFechaProd.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.mcFechaProd.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.mcFechaProd.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.mcFechaProd.MonthCalendar.DisplayMonth = New Date(2007, 10, 1, 0, 0, 0, 0)
        Me.mcFechaProd.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.mcFechaProd.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.mcFechaProd.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.mcFechaProd.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.mcFechaProd.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.mcFechaProd.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.mcFechaProd.MonthCalendar.TodayButtonVisible = True
        Me.mcFechaProd.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.mcFechaProd.Name = "mcFechaProd"
        Me.mcFechaProd.Size = New System.Drawing.Size(152, 20)
        Me.mcFechaProd.TabIndex = 1037
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(6, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 18)
        Me.Label1.TabIndex = 1038
        Me.Label1.Text = "Fecha de Produccion"
        '
        'Chk_pedpendiente
        '
        Me.Chk_pedpendiente.AutoSize = True
        '
        '
        '
        Me.Chk_pedpendiente.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Chk_pedpendiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_pedpendiente.Location = New System.Drawing.Point(3, 219)
        Me.Chk_pedpendiente.Name = "Chk_pedpendiente"
        Me.Chk_pedpendiente.Size = New System.Drawing.Size(124, 15)
        Me.Chk_pedpendiente.TabIndex = 1039
        Me.Chk_pedpendiente.TabStop = False
        Me.Chk_pedpendiente.Text = "Pedidos Pendientes"
        '
        'chkmostrarOC
        '
        Me.chkmostrarOC.AutoSize = True
        '
        '
        '
        Me.chkmostrarOC.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chkmostrarOC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkmostrarOC.Location = New System.Drawing.Point(3, 164)
        Me.chkmostrarOC.Name = "chkmostrarOC"
        Me.chkmostrarOC.Size = New System.Drawing.Size(98, 15)
        Me.chkmostrarOC.TabIndex = 1040
        Me.chkmostrarOC.TabStop = False
        Me.chkmostrarOC.Text = "Orden Compra"
        Me.chkmostrarOC.Visible = False
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
        Me.chkProduccion.Location = New System.Drawing.Point(553, 8)
        Me.chkProduccion.Name = "chkProduccion"
        Me.chkProduccion.Size = New System.Drawing.Size(67, 15)
        Me.chkProduccion.TabIndex = 1041
        Me.chkProduccion.Text = "Articulos"
        '
        'p_transferencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(967, 598)
        Me.Controls.Add(Me.chkProduccion)
        Me.Controls.Add(Me.chkmostrarOC)
        Me.Controls.Add(Me.Chk_pedpendiente)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mcFechaProd)
        Me.Controls.Add(Me.mcFechatransferencia1)
        Me.Controls.Add(Me.chkMostrarPedidos)
        Me.Controls.Add(Me.ChkSinStock)
        Me.Controls.Add(Me.txtObservacion)
        Me.Controls.Add(Me.lblProducto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblRegistros)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblNroTransferencia)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.dataArticulos)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.LabelX8)
        Me.Controls.Add(Me.LabelX6)
        Me.Controls.Add(Me.txtBuscarTransferencia)
        Me.Controls.Add(Me.dataNroTransferencias)
        Me.Controls.Add(Me.txtBuscarOrigen)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.chkMostrarTransferencias)
        Me.Controls.Add(Me.dataTransferencias)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "p_transferencia"
        Me.Text = "Proceso: TRANSFERENCIAS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.dataArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataNroTransferencias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataTransferencias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcFechatransferencia1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcFechaProd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dataArticulos As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents cboOrigen As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cboDestino As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtBuscarOrigen As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents dataTransferencias As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents chkMostrarTransferencias As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblNroTransferencia As DevComponents.DotNetBar.LabelX
    Friend WithEvents dataNroTransferencias As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents txtBuscarTransferencia As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdImprimir As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents cmdNuevaT As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents lblRegistros As DevComponents.DotNetBar.LabelX
    Friend WithEvents cboArea As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents lblArea As DevComponents.DotNetBar.LabelX
    Friend WithEvents ChKRptValorizado As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblProducto As DevComponents.DotNetBar.LabelX
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtTransferir As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents cmdTransferir As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents txtObservacion As System.Windows.Forms.RichTextBox
    Friend WithEvents ChkSinStock As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chkMostrarPedidos As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents SimpleButton1 As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Private WithEvents mcFechatransferencia1 As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Private WithEvents mcFechaProd As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents Label1 As Label
    Friend WithEvents Chk_pedpendiente As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chkmostrarOC As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chkProduccion As DevComponents.DotNetBar.Controls.CheckBoxX
End Class
