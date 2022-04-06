<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class p_ordencompra
    Inherits cefe.base

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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(p_ordencompra))
        Me.txtObs = New System.Windows.Forms.RichTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNroPedido = New System.Windows.Forms.TextBox()
        Me.txtSerPedido = New System.Windows.Forms.TextBox()
        Me.LabelX14 = New DevComponents.DotNetBar.LabelX()
        Me.mcFIngreso = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.chkIGV = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.lblTC = New DevComponents.DotNetBar.LabelX()
        Me.optDolares = New System.Windows.Forms.RadioButton()
        Me.optMoneda = New System.Windows.Forms.RadioButton()
        Me.dataArticulo = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.dataDetalle = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtSubTotal = New System.Windows.Forms.TextBox()
        Me.txtIGV = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX10 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX11 = New DevComponents.DotNetBar.LabelX()
        Me.txtBuscar = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.grpProveedor = New System.Windows.Forms.GroupBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.txtDireccion = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtRUC = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.cboProveedor = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.lblObs = New DevComponents.DotNetBar.LabelX()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.grpAlmacen = New System.Windows.Forms.GroupBox()
        Me.cboFPago = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.cboAlmacen = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.lblFormaPago = New DevComponents.DotNetBar.LabelX()
        Me.lblItems = New DevComponents.DotNetBar.LabelX()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmdCopiar = New DevExpress.DXCore.Controls.XtraEditors.SimpleButton()
        Me.cmdImprimir = New DevExpress.DXCore.Controls.XtraEditors.SimpleButton()
        Me.cmdEliminar = New DevExpress.DXCore.Controls.XtraEditors.SimpleButton()
        Me.cmdCancelar = New DevExpress.DXCore.Controls.XtraEditors.SimpleButton()
        Me.cmdGrabar = New DevExpress.DXCore.Controls.XtraEditors.SimpleButton()
        Me.CboEstado = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        CType(Me.mcFIngreso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.dataArticulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpProveedor.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpAlmacen.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtObs
        '
        Me.txtObs.Location = New System.Drawing.Point(73, 115)
        Me.txtObs.Name = "txtObs"
        Me.txtObs.Size = New System.Drawing.Size(425, 40)
        Me.txtObs.TabIndex = 123
        Me.txtObs.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(510, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 18)
        Me.Label4.TabIndex = 1039
        Me.Label4.Text = "Nº Ord Compra"
        '
        'txtNroPedido
        '
        Me.txtNroPedido.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNroPedido.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroPedido.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtNroPedido.Location = New System.Drawing.Point(680, 6)
        Me.txtNroPedido.MaxLength = 8
        Me.txtNroPedido.Name = "txtNroPedido"
        Me.txtNroPedido.Size = New System.Drawing.Size(106, 22)
        Me.txtNroPedido.TabIndex = 0
        '
        'txtSerPedido
        '
        Me.txtSerPedido.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtSerPedido.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSerPedido.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerPedido.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtSerPedido.Location = New System.Drawing.Point(610, 6)
        Me.txtSerPedido.MaxLength = 3
        Me.txtSerPedido.Name = "txtSerPedido"
        Me.txtSerPedido.ReadOnly = True
        Me.txtSerPedido.Size = New System.Drawing.Size(68, 19)
        Me.txtSerPedido.TabIndex = 1041
        Me.txtSerPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabelX14
        '
        Me.LabelX14.AutoSize = True
        '
        '
        '
        Me.LabelX14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX14.ForeColor = System.Drawing.Color.Black
        Me.LabelX14.Location = New System.Drawing.Point(17, 9)
        Me.LabelX14.Name = "LabelX14"
        Me.LabelX14.Size = New System.Drawing.Size(86, 17)
        Me.LabelX14.TabIndex = 1038
        Me.LabelX14.Text = "fecha Entrega"
        '
        'mcFIngreso
        '
        '
        '
        '
        Me.mcFIngreso.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.mcFIngreso.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.mcFIngreso.ButtonDropDown.Visible = True
        Me.mcFIngreso.FocusHighlightEnabled = True
        Me.mcFIngreso.IsPopupCalendarOpen = False
        Me.mcFIngreso.Location = New System.Drawing.Point(114, 7)
        '
        '
        '
        Me.mcFIngreso.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.mcFIngreso.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.mcFIngreso.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.mcFIngreso.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.mcFIngreso.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.mcFIngreso.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.mcFIngreso.MonthCalendar.DisplayMonth = New Date(2007, 10, 1, 0, 0, 0, 0)
        Me.mcFIngreso.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.mcFIngreso.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.mcFIngreso.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.mcFIngreso.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.mcFIngreso.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.mcFIngreso.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.mcFIngreso.MonthCalendar.TodayButtonVisible = True
        Me.mcFIngreso.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.mcFIngreso.Name = "mcFIngreso"
        Me.mcFIngreso.Size = New System.Drawing.Size(110, 20)
        Me.mcFIngreso.TabIndex = 1037
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
        Me.chkIGV.Location = New System.Drawing.Point(662, 484)
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
        Me.GroupBox5.Location = New System.Drawing.Point(426, 500)
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
        Me.dataDetalle.Size = New System.Drawing.Size(833, 319)
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
        Me.GroupBox2.Location = New System.Drawing.Point(598, 495)
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
        Me.txtBuscar.TabIndex = 1
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
        Me.grpProveedor.Size = New System.Drawing.Size(585, 81)
        Me.grpProveedor.TabIndex = 0
        Me.grpProveedor.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.cefe.My.Resources.Resources.buscar20
        Me.PictureBox3.Location = New System.Drawing.Point(404, 21)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 98
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
        Me.txtDireccion.TabIndex = 1
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
        Me.cboProveedor.Size = New System.Drawing.Size(322, 21)
        Me.cboProveedor.TabIndex = 0
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
        Me.lblObs.Location = New System.Drawing.Point(17, 116)
        Me.lblObs.Name = "lblObs"
        Me.lblObs.Size = New System.Drawing.Size(31, 17)
        Me.lblObs.TabIndex = 3
        Me.lblObs.Text = "Obs."
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
        Me.cboFPago.TabIndex = 1
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
        Me.cboAlmacen.TabIndex = 0
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
        Me.GroupBox3.Controls.Add(Me.cmdCopiar)
        Me.GroupBox3.Controls.Add(Me.cmdImprimir)
        Me.GroupBox3.Controls.Add(Me.cmdEliminar)
        Me.GroupBox3.Controls.Add(Me.cmdCancelar)
        Me.GroupBox3.Controls.Add(Me.cmdGrabar)
        Me.GroupBox3.Location = New System.Drawing.Point(7, 495)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(416, 71)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        '
        'cmdCopiar
        '
        Me.cmdCopiar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmdCopiar.Appearance.Options.UseFont = True
        Me.cmdCopiar.Image = CType(resources.GetObject("cmdCopiar.Image"), System.Drawing.Image)
        Me.cmdCopiar.ImageLocation = DevExpress.DXCore.Controls.XtraEditors.ImageLocation.TopCenter
        Me.cmdCopiar.Location = New System.Drawing.Point(331, 18)
        Me.cmdCopiar.LookAndFeel.SkinName = "iMaginary"
        Me.cmdCopiar.Name = "cmdCopiar"
        Me.cmdCopiar.Size = New System.Drawing.Size(71, 50)
        Me.cmdCopiar.TabIndex = 36
        Me.cmdCopiar.Text = "COPIAR"
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
        'CboEstado
        '
        Me.CboEstado.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CboEstado.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CboEstado.DisplayMember = "Text"
        Me.CboEstado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboEstado.Enabled = False
        Me.CboEstado.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboEstado.ForeColor = System.Drawing.Color.Black
        Me.CboEstado.FormattingEnabled = True
        Me.CboEstado.ItemHeight = 15
        Me.CboEstado.Location = New System.Drawing.Point(335, 6)
        Me.CboEstado.Name = "CboEstado"
        Me.CboEstado.Size = New System.Drawing.Size(143, 21)
        Me.CboEstado.TabIndex = 1042
        Me.CboEstado.WatermarkColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'LabelX6
        '
        Me.LabelX6.AutoSize = True
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX6.ForeColor = System.Drawing.Color.Black
        Me.LabelX6.Location = New System.Drawing.Point(284, 8)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(45, 17)
        Me.LabelX6.TabIndex = 1043
        Me.LabelX6.Text = "Estado"
        '
        'p_ordencompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(842, 595)
        Me.Controls.Add(Me.LabelX6)
        Me.Controls.Add(Me.CboEstado)
        Me.Controls.Add(Me.txtObs)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtNroPedido)
        Me.Controls.Add(Me.txtSerPedido)
        Me.Controls.Add(Me.LabelX14)
        Me.Controls.Add(Me.mcFIngreso)
        Me.Controls.Add(Me.chkIGV)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.dataArticulo)
        Me.Controls.Add(Me.dataDetalle)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.LabelX5)
        Me.Controls.Add(Me.grpProveedor)
        Me.Controls.Add(Me.lblObs)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.grpAlmacen)
        Me.Controls.Add(Me.lblItems)
        Me.Controls.Add(Me.GroupBox3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = False
        Me.Name = "p_ordencompra"
        Me.Text = "Proceso: REGISTRO  ORDEN DE COMPRA"
        CType(Me.mcFIngreso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.dataArticulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpProveedor.ResumeLayout(False)
        Me.grpProveedor.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpAlmacen.ResumeLayout(False)
        Me.grpAlmacen.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpProveedor As System.Windows.Forms.GroupBox
    Friend WithEvents grpAlmacen As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdImprimir As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents cmdEliminar As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents cmdCancelar As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents cmdGrabar As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents dataDetalle As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents dataArticulo As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtIGV As System.Windows.Forms.TextBox
    Friend WithEvents txtSubTotal As System.Windows.Forms.TextBox
    Friend WithEvents lblItems As DevComponents.DotNetBar.LabelX
    Friend WithEvents chkIGV As DevComponents.DotNetBar.Controls.CheckBoxX
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
    Friend WithEvents lblObs As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX10 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX11 As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblTC As DevComponents.DotNetBar.LabelX
    Friend WithEvents cboProveedor As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cboFPago As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cboAlmacen As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents txtDireccion As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtRUC As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents mcFIngreso As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents LabelX14 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNroPedido As TextBox
    Friend WithEvents txtSerPedido As TextBox
    Friend WithEvents txtObs As RichTextBox
    Friend WithEvents cmdCopiar As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents CboEstado As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
End Class
