<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class p_pedido
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(p_pedido))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Bgw = New System.ComponentModel.BackgroundWorker()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.tabcontrol = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.dataDetalle = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.gbp = New System.Windows.Forms.GroupBox()
        Me.bp = New System.Windows.Forms.ProgressBar()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.lblarticulo = New DevComponents.DotNetBar.LabelX()
        Me.SimpleButton2 = New DevExpress.DXCore.Controls.XtraEditors.SimpleButton()
        Me.cmdExaminar = New DevExpress.DXCore.Controls.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.DXCore.Controls.XtraEditors.SimpleButton()
        Me.pb_foto = New System.Windows.Forms.PictureBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dt_pedido = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.dt_horaEntrega = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.dt_entrega = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cboTipoCliente = New System.Windows.Forms.ComboBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.lblTC = New DevComponents.DotNetBar.LabelX()
        Me.optDolares = New System.Windows.Forms.RadioButton()
        Me.optMoneda = New System.Windows.Forms.RadioButton()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.chkIGV = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.lblItems = New DevComponents.DotNetBar.LabelX()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtIGV = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtSubTotal = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmdBuscar = New DevExpress.DXCore.Controls.XtraEditors.SimpleButton()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.dataArticulo = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.CboEstado = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ChkResppn = New System.Windows.Forms.CheckBox()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.CboResponsable = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblArea = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.cboArea = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.cboOrigen = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.cboDestino = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.cboPedido = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txtObs = New System.Windows.Forms.RichTextBox()
        Me.cboVendedor = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDirEntrega = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cboCliente = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtRuc = New System.Windows.Forms.TextBox()
        Me.txtContacto = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboFPago = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNroPedido = New System.Windows.Forms.TextBox()
        Me.txtSerPedido = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmdCopiar = New DevExpress.DXCore.Controls.XtraEditors.SimpleButton()
        Me.cmdImprimir = New DevExpress.DXCore.Controls.XtraEditors.SimpleButton()
        Me.cmdEliminar = New DevExpress.DXCore.Controls.XtraEditors.SimpleButton()
        Me.cmdCancelar = New DevExpress.DXCore.Controls.XtraEditors.SimpleButton()
        Me.cmdGrabar = New DevExpress.DXCore.Controls.XtraEditors.SimpleButton()
        Me.ep = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.lblUsuario = New DevComponents.DotNetBar.LabelX()
        Me.tabcontrol.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.dataDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbp.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.pb_foto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        CType(Me.dt_pedido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_horaEntrega, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_entrega, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataArticulo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.ep, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Bgw
        '
        Me.Bgw.WorkerReportsProgress = True
        '
        'Timer
        '
        '
        'tabcontrol
        '
        Me.tabcontrol.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.tabcontrol.Controls.Add(Me.TabPage3)
        Me.tabcontrol.Controls.Add(Me.TabPage4)
        Me.tabcontrol.Font = New System.Drawing.Font("Verdana", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabcontrol.Location = New System.Drawing.Point(417, 279)
        Me.tabcontrol.Margin = New System.Windows.Forms.Padding(4)
        Me.tabcontrol.Name = "tabcontrol"
        Me.tabcontrol.SelectedIndex = 0
        Me.tabcontrol.Size = New System.Drawing.Size(923, 342)
        Me.tabcontrol.TabIndex = 2
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.Transparent
        Me.TabPage3.Controls.Add(Me.dataDetalle)
        Me.TabPage3.Controls.Add(Me.gbp)
        Me.TabPage3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TabPage3.Location = New System.Drawing.Point(4, 30)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage3.Size = New System.Drawing.Size(915, 308)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "Detalle"
        '
        'dataDetalle
        '
        Me.dataDetalle.AllowUserToAddRows = False
        Me.dataDetalle.AllowUserToDeleteRows = False
        Me.dataDetalle.AllowUserToResizeColumns = False
        Me.dataDetalle.AllowUserToResizeRows = False
        Me.dataDetalle.BackgroundColor = System.Drawing.Color.White
        Me.dataDetalle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dataDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataDetalle.DefaultCellStyle = DataGridViewCellStyle1
        Me.dataDetalle.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dataDetalle.Location = New System.Drawing.Point(0, 0)
        Me.dataDetalle.Margin = New System.Windows.Forms.Padding(4)
        Me.dataDetalle.Name = "dataDetalle"
        Me.dataDetalle.RowHeadersVisible = False
        Me.dataDetalle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dataDetalle.SelectAllSignVisible = False
        Me.dataDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataDetalle.ShowEditingIcon = False
        Me.dataDetalle.Size = New System.Drawing.Size(917, 310)
        Me.dataDetalle.TabIndex = 0
        '
        'gbp
        '
        Me.gbp.Controls.Add(Me.bp)
        Me.gbp.Location = New System.Drawing.Point(241, 135)
        Me.gbp.Margin = New System.Windows.Forms.Padding(4)
        Me.gbp.Name = "gbp"
        Me.gbp.Padding = New System.Windows.Forms.Padding(4)
        Me.gbp.Size = New System.Drawing.Size(428, 58)
        Me.gbp.TabIndex = 32
        Me.gbp.TabStop = False
        Me.gbp.Visible = False
        '
        'bp
        '
        Me.bp.BackColor = System.Drawing.Color.White
        Me.bp.Location = New System.Drawing.Point(12, 18)
        Me.bp.Margin = New System.Windows.Forms.Padding(4)
        Me.bp.Maximum = 200
        Me.bp.Name = "bp"
        Me.bp.Size = New System.Drawing.Size(404, 28)
        Me.bp.TabIndex = 31
        Me.bp.Value = 5
        Me.bp.Visible = False
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.lblarticulo)
        Me.TabPage4.Controls.Add(Me.SimpleButton2)
        Me.TabPage4.Controls.Add(Me.cmdExaminar)
        Me.TabPage4.Controls.Add(Me.SimpleButton1)
        Me.TabPage4.Controls.Add(Me.pb_foto)
        Me.TabPage4.Location = New System.Drawing.Point(4, 30)
        Me.TabPage4.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage4.Size = New System.Drawing.Size(915, 308)
        Me.TabPage4.TabIndex = 1
        Me.TabPage4.Text = "Foto"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'lblarticulo
        '
        Me.lblarticulo.AutoSize = True
        '
        '
        '
        Me.lblarticulo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblarticulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblarticulo.ForeColor = System.Drawing.Color.Maroon
        Me.lblarticulo.Location = New System.Drawing.Point(193, 4)
        Me.lblarticulo.Margin = New System.Windows.Forms.Padding(4)
        Me.lblarticulo.Name = "lblarticulo"
        Me.lblarticulo.Size = New System.Drawing.Size(133, 21)
        Me.lblarticulo.TabIndex = 155
        Me.lblarticulo.Text = "..........................."
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.SimpleButton2.Appearance.Options.UseFont = True
        Me.SimpleButton2.Image = Global.cefe.My.Resources.Resources.m_grabar
        Me.SimpleButton2.ImageLocation = DevExpress.DXCore.Controls.XtraEditors.ImageLocation.TopCenter
        Me.SimpleButton2.Location = New System.Drawing.Point(125, 255)
        Me.SimpleButton2.LookAndFeel.SkinName = "iMaginary"
        Me.SimpleButton2.Margin = New System.Windows.Forms.Padding(4)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(41, 39)
        Me.SimpleButton2.TabIndex = 154
        Me.SimpleButton2.Text = "Examinar"
        '
        'cmdExaminar
        '
        Me.cmdExaminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmdExaminar.Appearance.Options.UseFont = True
        Me.cmdExaminar.Image = Global.cefe.My.Resources.Resources.c_buscarD
        Me.cmdExaminar.ImageLocation = DevExpress.DXCore.Controls.XtraEditors.ImageLocation.TopCenter
        Me.cmdExaminar.Location = New System.Drawing.Point(32, 255)
        Me.cmdExaminar.LookAndFeel.SkinName = "iMaginary"
        Me.cmdExaminar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdExaminar.Name = "cmdExaminar"
        Me.cmdExaminar.Size = New System.Drawing.Size(41, 39)
        Me.cmdExaminar.TabIndex = 153
        Me.cmdExaminar.Text = "Examinar"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.ImageLocation = DevExpress.DXCore.Controls.XtraEditors.ImageLocation.TopCenter
        Me.SimpleButton1.Location = New System.Drawing.Point(79, 255)
        Me.SimpleButton1.LookAndFeel.SkinName = "iMaginary"
        Me.SimpleButton1.Margin = New System.Windows.Forms.Padding(4)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(41, 39)
        Me.SimpleButton1.TabIndex = 152
        '
        'pb_foto
        '
        Me.pb_foto.Location = New System.Drawing.Point(177, 32)
        Me.pb_foto.Margin = New System.Windows.Forms.Padding(4)
        Me.pb_foto.Name = "pb_foto"
        Me.pb_foto.Size = New System.Drawing.Size(727, 262)
        Me.pb_foto.TabIndex = 1
        Me.pb_foto.TabStop = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label16)
        Me.GroupBox6.Controls.Add(Me.Label2)
        Me.GroupBox6.Controls.Add(Me.dt_pedido)
        Me.GroupBox6.Controls.Add(Me.dt_horaEntrega)
        Me.GroupBox6.Controls.Add(Me.dt_entrega)
        Me.GroupBox6.Controls.Add(Me.Label10)
        Me.GroupBox6.Location = New System.Drawing.Point(28, 2)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox6.Size = New System.Drawing.Size(336, 251)
        Me.GroupBox6.TabIndex = 12
        Me.GroupBox6.TabStop = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Maroon
        Me.Label16.Location = New System.Drawing.Point(36, 164)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(208, 22)
        Me.Label16.TabIndex = 1037
        Me.Label16.Text = "Fecha de Produccion"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(36, 97)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 22)
        Me.Label2.TabIndex = 1040
        Me.Label2.Text = "Hora de Entrega"
        '
        'dt_pedido
        '
        '
        '
        '
        Me.dt_pedido.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dt_pedido.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dt_pedido.ButtonDropDown.Visible = True
        Me.dt_pedido.FocusHighlightEnabled = True
        Me.dt_pedido.IsPopupCalendarOpen = False
        Me.dt_pedido.Location = New System.Drawing.Point(36, 190)
        Me.dt_pedido.Margin = New System.Windows.Forms.Padding(4)
        '
        '
        '
        Me.dt_pedido.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dt_pedido.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.dt_pedido.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dt_pedido.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.dt_pedido.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dt_pedido.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dt_pedido.MonthCalendar.DisplayMonth = New Date(2007, 10, 1, 0, 0, 0, 0)
        Me.dt_pedido.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.dt_pedido.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dt_pedido.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dt_pedido.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dt_pedido.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dt_pedido.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dt_pedido.MonthCalendar.TodayButtonVisible = True
        Me.dt_pedido.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.dt_pedido.Name = "dt_pedido"
        Me.dt_pedido.Size = New System.Drawing.Size(203, 22)
        Me.dt_pedido.TabIndex = 1035
        '
        'dt_horaEntrega
        '
        '
        '
        '
        Me.dt_horaEntrega.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dt_horaEntrega.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dt_horaEntrega.ButtonClear.Visible = True
        Me.dt_horaEntrega.ButtonDropDown.Visible = True
        Me.dt_horaEntrega.FocusHighlightEnabled = True
        Me.dt_horaEntrega.Format = DevComponents.Editors.eDateTimePickerFormat.ShortTime
        Me.dt_horaEntrega.IsPopupCalendarOpen = False
        Me.dt_horaEntrega.Location = New System.Drawing.Point(36, 127)
        Me.dt_horaEntrega.Margin = New System.Windows.Forms.Padding(4)
        '
        '
        '
        Me.dt_horaEntrega.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dt_horaEntrega.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.dt_horaEntrega.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dt_horaEntrega.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.dt_horaEntrega.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dt_horaEntrega.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dt_horaEntrega.MonthCalendar.DisplayMonth = New Date(2007, 10, 1, 0, 0, 0, 0)
        Me.dt_horaEntrega.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.dt_horaEntrega.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dt_horaEntrega.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dt_horaEntrega.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dt_horaEntrega.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dt_horaEntrega.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dt_horaEntrega.MonthCalendar.TodayButtonVisible = True
        Me.dt_horaEntrega.MonthCalendar.Visible = False
        Me.dt_horaEntrega.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.dt_horaEntrega.Name = "dt_horaEntrega"
        Me.dt_horaEntrega.Size = New System.Drawing.Size(201, 22)
        Me.dt_horaEntrega.TabIndex = 1039
        '
        'dt_entrega
        '
        '
        '
        '
        Me.dt_entrega.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dt_entrega.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dt_entrega.ButtonDropDown.Visible = True
        Me.dt_entrega.FocusHighlightEnabled = True
        Me.dt_entrega.IsPopupCalendarOpen = False
        Me.dt_entrega.Location = New System.Drawing.Point(36, 64)
        Me.dt_entrega.Margin = New System.Windows.Forms.Padding(4)
        '
        '
        '
        Me.dt_entrega.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dt_entrega.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.dt_entrega.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dt_entrega.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.dt_entrega.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dt_entrega.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dt_entrega.MonthCalendar.DisplayMonth = New Date(2007, 10, 1, 0, 0, 0, 0)
        Me.dt_entrega.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.dt_entrega.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dt_entrega.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dt_entrega.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dt_entrega.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dt_entrega.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dt_entrega.MonthCalendar.TodayButtonVisible = True
        Me.dt_entrega.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.dt_entrega.Name = "dt_entrega"
        Me.dt_entrega.Size = New System.Drawing.Size(203, 22)
        Me.dt_entrega.TabIndex = 1036
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Maroon
        Me.Label10.Location = New System.Drawing.Point(36, 38)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(173, 22)
        Me.Label10.TabIndex = 1038
        Me.Label10.Text = "Fecha de Entrega"
        '
        'cboTipoCliente
        '
        Me.cboTipoCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoCliente.FormattingEnabled = True
        Me.cboTipoCliente.Location = New System.Drawing.Point(9, 731)
        Me.cboTipoCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.cboTipoCliente.Name = "cboTipoCliente"
        Me.cboTipoCliente.Size = New System.Drawing.Size(361, 26)
        Me.cboTipoCliente.TabIndex = 1002
        Me.cboTipoCliente.Visible = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.lblTC)
        Me.GroupBox5.Controls.Add(Me.optDolares)
        Me.GroupBox5.Controls.Add(Me.optMoneda)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox5.Location = New System.Drawing.Point(100, 663)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Size = New System.Drawing.Size(209, 69)
        Me.GroupBox5.TabIndex = 101
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
        Me.lblTC.Location = New System.Drawing.Point(44, 58)
        Me.lblTC.Margin = New System.Windows.Forms.Padding(4)
        Me.lblTC.Name = "lblTC"
        Me.lblTC.Size = New System.Drawing.Size(123, 18)
        Me.lblTC.TabIndex = 63
        Me.lblTC.Text = "Tipo Cambio 0.000"
        '
        'optDolares
        '
        Me.optDolares.AutoSize = True
        Me.optDolares.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optDolares.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.optDolares.Location = New System.Drawing.Point(112, 27)
        Me.optDolares.Margin = New System.Windows.Forms.Padding(4)
        Me.optDolares.Name = "optDolares"
        Me.optDolares.Size = New System.Drawing.Size(85, 21)
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
        Me.optMoneda.Location = New System.Drawing.Point(16, 27)
        Me.optMoneda.Margin = New System.Windows.Forms.Padding(4)
        Me.optMoneda.Name = "optMoneda"
        Me.optMoneda.Size = New System.Drawing.Size(86, 21)
        Me.optMoneda.TabIndex = 0
        Me.optMoneda.TabStop = True
        Me.optMoneda.Text = "Moneda"
        Me.optMoneda.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.cefe.My.Resources.Resources.buscar20
        Me.PictureBox2.Location = New System.Drawing.Point(375, 279)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 97
        Me.PictureBox2.TabStop = False
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
        Me.chkIGV.Enabled = False
        Me.chkIGV.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkIGV.Location = New System.Drawing.Point(971, 663)
        Me.chkIGV.Margin = New System.Windows.Forms.Padding(4)
        Me.chkIGV.Name = "chkIGV"
        Me.chkIGV.Size = New System.Drawing.Size(156, 18)
        Me.chkIGV.TabIndex = 61
        Me.chkIGV.Text = "Precios Incluyen IGV"
        '
        'lblItems
        '
        Me.lblItems.AutoSize = True
        '
        '
        '
        Me.lblItems.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblItems.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItems.Location = New System.Drawing.Point(421, 622)
        Me.lblItems.Margin = New System.Windows.Forms.Padding(4)
        Me.lblItems.Name = "lblItems"
        Me.lblItems.Size = New System.Drawing.Size(99, 18)
        Me.lblItems.TabIndex = 60
        Me.lblItems.Text = "Nro de Items. 0"
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTotal.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.ForeColor = System.Drawing.Color.ForestGreen
        Me.txtTotal.Location = New System.Drawing.Point(1187, 690)
        Me.txtTotal.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(152, 29)
        Me.txtTotal.TabIndex = 51
        Me.txtTotal.TabStop = False
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label13.Location = New System.Drawing.Point(1115, 697)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(62, 19)
        Me.Label13.TabIndex = 50
        Me.Label13.Text = "TOTAL"
        '
        'txtIGV
        '
        Me.txtIGV.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtIGV.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIGV.ForeColor = System.Drawing.Color.ForestGreen
        Me.txtIGV.Location = New System.Drawing.Point(1187, 657)
        Me.txtIGV.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIGV.Name = "txtIGV"
        Me.txtIGV.ReadOnly = True
        Me.txtIGV.Size = New System.Drawing.Size(152, 29)
        Me.txtIGV.TabIndex = 49
        Me.txtIGV.TabStop = False
        Me.txtIGV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label14.Location = New System.Drawing.Point(1141, 662)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(37, 19)
        Me.Label14.TabIndex = 48
        Me.Label14.Text = "IGV"
        '
        'txtSubTotal
        '
        Me.txtSubTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSubTotal.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubTotal.ForeColor = System.Drawing.Color.ForestGreen
        Me.txtSubTotal.Location = New System.Drawing.Point(1187, 624)
        Me.txtSubTotal.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.ReadOnly = True
        Me.txtSubTotal.Size = New System.Drawing.Size(152, 29)
        Me.txtSubTotal.TabIndex = 47
        Me.txtSubTotal.TabStop = False
        Me.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Green
        Me.Label15.Location = New System.Drawing.Point(1075, 629)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(102, 19)
        Me.Label15.TabIndex = 46
        Me.Label15.Text = "SUB TOTAL"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(5, 257)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(89, 22)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Artículo:"
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmdBuscar.Appearance.Options.UseFont = True
        Me.cmdBuscar.Image = Global.cefe.My.Resources.Resources.filtrar
        Me.cmdBuscar.ImageLocation = DevExpress.DXCore.Controls.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdBuscar.Location = New System.Drawing.Point(421, 281)
        Me.cmdBuscar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(40, 31)
        Me.cmdBuscar.TabIndex = 63
        Me.cmdBuscar.Visible = False
        '
        'txtBuscar
        '
        Me.txtBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBuscar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(7, 279)
        Me.txtBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(364, 26)
        Me.txtBuscar.TabIndex = 0
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
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataArticulo.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dataArticulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataArticulo.DefaultCellStyle = DataGridViewCellStyle3
        Me.dataArticulo.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dataArticulo.Location = New System.Drawing.Point(7, 313)
        Me.dataArticulo.Margin = New System.Windows.Forms.Padding(4)
        Me.dataArticulo.MultiSelect = False
        Me.dataArticulo.Name = "dataArticulo"
        Me.dataArticulo.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataArticulo.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dataArticulo.RowHeadersVisible = False
        Me.dataArticulo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dataArticulo.SelectAllSignVisible = False
        Me.dataArticulo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dataArticulo.ShowEditingIcon = False
        Me.dataArticulo.Size = New System.Drawing.Size(407, 409)
        Me.dataArticulo.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.LabelX5)
        Me.GroupBox1.Controls.Add(Me.CboEstado)
        Me.GroupBox1.Controls.Add(Me.TabControl1)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtNroPedido)
        Me.GroupBox1.Controls.Add(Me.txtSerPedido)
        Me.GroupBox1.Location = New System.Drawing.Point(421, 2)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(919, 251)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(800, 181)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 59)
        Me.Button1.TabIndex = 1042
        Me.Button1.Text = "Generar Pedido de Produccion"
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'LabelX5
        '
        Me.LabelX5.AutoSize = True
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Enabled = False
        Me.LabelX5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LabelX5.Location = New System.Drawing.Point(475, 23)
        Me.LabelX5.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(47, 18)
        Me.LabelX5.TabIndex = 1005
        Me.LabelX5.Text = "Estado"
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
        Me.CboEstado.Location = New System.Drawing.Point(536, 18)
        Me.CboEstado.Margin = New System.Windows.Forms.Padding(4)
        Me.CboEstado.Name = "CboEstado"
        Me.CboEstado.Size = New System.Drawing.Size(213, 21)
        Me.CboEstado.TabIndex = 1004
        Me.CboEstado.WatermarkColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(11, 68)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(781, 177)
        Me.TabControl1.TabIndex = 1003
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ChkResppn)
        Me.TabPage1.Controls.Add(Me.LabelX4)
        Me.TabPage1.Controls.Add(Me.CboResponsable)
        Me.TabPage1.Controls.Add(Me.LabelX3)
        Me.TabPage1.Controls.Add(Me.GroupBox4)
        Me.TabPage1.Controls.Add(Me.cboPedido)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Size = New System.Drawing.Size(773, 144)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Datos"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ChkResppn
        '
        Me.ChkResppn.AutoSize = True
        Me.ChkResppn.Location = New System.Drawing.Point(333, 68)
        Me.ChkResppn.Margin = New System.Windows.Forms.Padding(4)
        Me.ChkResppn.Name = "ChkResppn"
        Me.ChkResppn.Size = New System.Drawing.Size(18, 17)
        Me.ChkResppn.TabIndex = 24
        Me.ChkResppn.UseVisualStyleBackColor = True
        Me.ChkResppn.Visible = False
        '
        'LabelX4
        '
        Me.LabelX4.AutoSize = True
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LabelX4.Location = New System.Drawing.Point(15, 64)
        Me.LabelX4.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(86, 18)
        Me.LabelX4.TabIndex = 23
        Me.LabelX4.Text = "Responsable"
        '
        'CboResponsable
        '
        Me.CboResponsable.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CboResponsable.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CboResponsable.DisplayMember = "Text"
        Me.CboResponsable.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CboResponsable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboResponsable.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboResponsable.ForeColor = System.Drawing.Color.Black
        Me.CboResponsable.FormattingEnabled = True
        Me.CboResponsable.ItemHeight = 15
        Me.CboResponsable.Location = New System.Drawing.Point(116, 62)
        Me.CboResponsable.Margin = New System.Windows.Forms.Padding(4)
        Me.CboResponsable.Name = "CboResponsable"
        Me.CboResponsable.Size = New System.Drawing.Size(213, 21)
        Me.CboResponsable.TabIndex = 1
        Me.CboResponsable.WatermarkColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'LabelX3
        '
        Me.LabelX3.AutoSize = True
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LabelX3.Location = New System.Drawing.Point(15, 30)
        Me.LabelX3.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(47, 18)
        Me.LabelX3.TabIndex = 21
        Me.LabelX3.Text = "Pedido"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblArea)
        Me.GroupBox4.Controls.Add(Me.LabelX1)
        Me.GroupBox4.Controls.Add(Me.cboArea)
        Me.GroupBox4.Controls.Add(Me.cboOrigen)
        Me.GroupBox4.Controls.Add(Me.cboDestino)
        Me.GroupBox4.Controls.Add(Me.LabelX2)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox4.Location = New System.Drawing.Point(360, 7)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(393, 117)
        Me.GroupBox4.TabIndex = 20
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Almacenes"
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
        Me.lblArea.Location = New System.Drawing.Point(12, 85)
        Me.lblArea.Margin = New System.Windows.Forms.Padding(4)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(33, 18)
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
        Me.LabelX1.Location = New System.Drawing.Point(11, 54)
        Me.LabelX1.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(51, 18)
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
        Me.cboArea.Location = New System.Drawing.Point(71, 80)
        Me.cboArea.Margin = New System.Windows.Forms.Padding(4)
        Me.cboArea.Name = "cboArea"
        Me.cboArea.Size = New System.Drawing.Size(303, 21)
        Me.cboArea.TabIndex = 2
        Me.cboArea.WatermarkColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'cboOrigen
        '
        Me.cboOrigen.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboOrigen.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cboOrigen.DisplayMember = "Text"
        Me.cboOrigen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOrigen.Enabled = False
        Me.cboOrigen.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboOrigen.ForeColor = System.Drawing.Color.Black
        Me.cboOrigen.FormattingEnabled = True
        Me.cboOrigen.ItemHeight = 15
        Me.cboOrigen.Location = New System.Drawing.Point(71, 20)
        Me.cboOrigen.Margin = New System.Windows.Forms.Padding(4)
        Me.cboOrigen.Name = "cboOrigen"
        Me.cboOrigen.Size = New System.Drawing.Size(303, 21)
        Me.cboOrigen.TabIndex = 0
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
        Me.cboDestino.Location = New System.Drawing.Point(71, 50)
        Me.cboDestino.Margin = New System.Windows.Forms.Padding(4)
        Me.cboDestino.Name = "cboDestino"
        Me.cboDestino.Size = New System.Drawing.Size(303, 21)
        Me.cboDestino.TabIndex = 1
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
        Me.LabelX2.Location = New System.Drawing.Point(12, 22)
        Me.LabelX2.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(46, 18)
        Me.LabelX2.TabIndex = 0
        Me.LabelX2.Text = "Origen"
        '
        'cboPedido
        '
        Me.cboPedido.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboPedido.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cboPedido.DisplayMember = "Text"
        Me.cboPedido.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboPedido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPedido.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPedido.ForeColor = System.Drawing.Color.Black
        Me.cboPedido.FormattingEnabled = True
        Me.cboPedido.ItemHeight = 15
        Me.cboPedido.Location = New System.Drawing.Point(116, 27)
        Me.cboPedido.Margin = New System.Windows.Forms.Padding(4)
        Me.cboPedido.Name = "cboPedido"
        Me.cboPedido.Size = New System.Drawing.Size(213, 21)
        Me.cboPedido.TabIndex = 0
        Me.cboPedido.WatermarkColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txtObs)
        Me.TabPage2.Controls.Add(Me.cboVendedor)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.txtDirEntrega)
        Me.TabPage2.Controls.Add(Me.txtTelefono)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.cboCliente)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.txtRuc)
        Me.TabPage2.Controls.Add(Me.txtContacto)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.cboFPago)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Size = New System.Drawing.Size(773, 144)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Observacion"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'txtObs
        '
        Me.txtObs.Location = New System.Drawing.Point(0, -1)
        Me.txtObs.Margin = New System.Windows.Forms.Padding(4)
        Me.txtObs.Name = "txtObs"
        Me.txtObs.Size = New System.Drawing.Size(775, 148)
        Me.txtObs.TabIndex = 1042
        Me.txtObs.Text = ""
        '
        'cboVendedor
        '
        Me.cboVendedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboVendedor.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboVendedor.ForeColor = System.Drawing.Color.SteelBlue
        Me.cboVendedor.FormattingEnabled = True
        Me.cboVendedor.Location = New System.Drawing.Point(443, 272)
        Me.cboVendedor.Margin = New System.Windows.Forms.Padding(4)
        Me.cboVendedor.Name = "cboVendedor"
        Me.cboVendedor.Size = New System.Drawing.Size(345, 27)
        Me.cboVendedor.TabIndex = 4
        Me.cboVendedor.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(327, 276)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 22)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Vendedor"
        Me.Label1.Visible = False
        '
        'txtDirEntrega
        '
        Me.txtDirEntrega.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDirEntrega.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDirEntrega.ForeColor = System.Drawing.Color.SteelBlue
        Me.txtDirEntrega.Location = New System.Drawing.Point(139, 63)
        Me.txtDirEntrega.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDirEntrega.Name = "txtDirEntrega"
        Me.txtDirEntrega.Size = New System.Drawing.Size(416, 26)
        Me.txtDirEntrega.TabIndex = 11
        Me.txtDirEntrega.Visible = False
        '
        'txtTelefono
        '
        Me.txtTelefono.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTelefono.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.Location = New System.Drawing.Point(679, 62)
        Me.txtTelefono.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTelefono.MaxLength = 9
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.ReadOnly = True
        Me.txtTelefono.Size = New System.Drawing.Size(120, 26)
        Me.txtTelefono.TabIndex = 15
        Me.txtTelefono.TabStop = False
        Me.txtTelefono.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 30)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 22)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Cliente"
        Me.Label3.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(573, 64)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(91, 22)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Teléfono"
        Me.Label11.Visible = False
        '
        'cboCliente
        '
        Me.cboCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboCliente.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCliente.ForeColor = System.Drawing.Color.SteelBlue
        Me.cboCliente.FormattingEnabled = True
        Me.cboCliente.Location = New System.Drawing.Point(139, 26)
        Me.cboCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.cboCliente.Name = "cboCliente"
        Me.cboCliente.Size = New System.Drawing.Size(416, 27)
        Me.cboCliente.TabIndex = 3
        Me.cboCliente.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(571, 30)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 22)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "RUC"
        Me.Label6.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(525, 101)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 22)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "F.Pago"
        Me.Label9.Visible = False
        '
        'txtRuc
        '
        Me.txtRuc.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRuc.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRuc.Location = New System.Drawing.Point(628, 27)
        Me.txtRuc.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRuc.MaxLength = 11
        Me.txtRuc.Name = "txtRuc"
        Me.txtRuc.ReadOnly = True
        Me.txtRuc.Size = New System.Drawing.Size(171, 26)
        Me.txtRuc.TabIndex = 9
        Me.txtRuc.TabStop = False
        Me.txtRuc.Visible = False
        '
        'txtContacto
        '
        Me.txtContacto.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtContacto.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContacto.Location = New System.Drawing.Point(117, 98)
        Me.txtContacto.Margin = New System.Windows.Forms.Padding(4)
        Me.txtContacto.Name = "txtContacto"
        Me.txtContacto.ReadOnly = True
        Me.txtContacto.Size = New System.Drawing.Size(379, 26)
        Me.txtContacto.TabIndex = 13
        Me.txtContacto.TabStop = False
        Me.txtContacto.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 64)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 22)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Dir.Fiscal"
        Me.Label7.Visible = False
        '
        'cboFPago
        '
        Me.cboFPago.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboFPago.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFPago.ForeColor = System.Drawing.Color.SteelBlue
        Me.cboFPago.FormattingEnabled = True
        Me.cboFPago.Location = New System.Drawing.Point(603, 97)
        Me.cboFPago.Margin = New System.Windows.Forms.Padding(4)
        Me.cboFPago.Name = "cboFPago"
        Me.cboFPago.Size = New System.Drawing.Size(196, 27)
        Me.cboFPago.TabIndex = 17
        Me.cboFPago.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 101)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 22)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Contacto"
        Me.Label8.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(0, 48)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(919, 12)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 22)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 22)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Nº Ord"
        '
        'txtNroPedido
        '
        Me.txtNroPedido.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNroPedido.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroPedido.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtNroPedido.Location = New System.Drawing.Point(187, 18)
        Me.txtNroPedido.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNroPedido.MaxLength = 8
        Me.txtNroPedido.Name = "txtNroPedido"
        Me.txtNroPedido.Size = New System.Drawing.Size(140, 26)
        Me.txtNroPedido.TabIndex = 1
        '
        'txtSerPedido
        '
        Me.txtSerPedido.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSerPedido.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSerPedido.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerPedido.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtSerPedido.Location = New System.Drawing.Point(88, 20)
        Me.txtSerPedido.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSerPedido.MaxLength = 3
        Me.txtSerPedido.Name = "txtSerPedido"
        Me.txtSerPedido.Size = New System.Drawing.Size(91, 23)
        Me.txtSerPedido.TabIndex = 4
        Me.txtSerPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmdCopiar)
        Me.GroupBox3.Controls.Add(Me.cmdImprimir)
        Me.GroupBox3.Controls.Add(Me.cmdEliminar)
        Me.GroupBox3.Controls.Add(Me.cmdCancelar)
        Me.GroupBox3.Controls.Add(Me.cmdGrabar)
        Me.GroupBox3.Location = New System.Drawing.Point(417, 636)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(545, 96)
        Me.GroupBox3.TabIndex = 16
        Me.GroupBox3.TabStop = False
        '
        'cmdCopiar
        '
        Me.cmdCopiar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmdCopiar.Appearance.Options.UseFont = True
        Me.cmdCopiar.Image = CType(resources.GetObject("cmdCopiar.Image"), System.Drawing.Image)
        Me.cmdCopiar.ImageLocation = DevExpress.DXCore.Controls.XtraEditors.ImageLocation.TopCenter
        Me.cmdCopiar.Location = New System.Drawing.Point(437, 16)
        Me.cmdCopiar.LookAndFeel.SkinName = "iMaginary"
        Me.cmdCopiar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdCopiar.Name = "cmdCopiar"
        Me.cmdCopiar.Size = New System.Drawing.Size(100, 69)
        Me.cmdCopiar.TabIndex = 35
        Me.cmdCopiar.Text = "COPIAR"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmdImprimir.Appearance.Options.UseFont = True
        Me.cmdImprimir.Enabled = False
        Me.cmdImprimir.Image = Global.cefe.My.Resources.Resources.print_preview
        Me.cmdImprimir.ImageLocation = DevExpress.DXCore.Controls.XtraEditors.ImageLocation.TopCenter
        Me.cmdImprimir.Location = New System.Drawing.Point(331, 15)
        Me.cmdImprimir.LookAndFeel.SkinName = "iMaginary"
        Me.cmdImprimir.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(100, 70)
        Me.cmdImprimir.TabIndex = 34
        Me.cmdImprimir.Text = "IMPRIMIR"
        '
        'cmdEliminar
        '
        Me.cmdEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmdEliminar.Appearance.Options.UseFont = True
        Me.cmdEliminar.Enabled = False
        Me.cmdEliminar.Image = Global.cefe.My.Resources.Resources.m_borrar
        Me.cmdEliminar.ImageLocation = DevExpress.DXCore.Controls.XtraEditors.ImageLocation.TopCenter
        Me.cmdEliminar.Location = New System.Drawing.Point(224, 15)
        Me.cmdEliminar.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdEliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(100, 70)
        Me.cmdEliminar.TabIndex = 34
        Me.cmdEliminar.Text = "ELIMINAR"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.Enabled = False
        Me.cmdCancelar.Image = Global.cefe.My.Resources.Resources.m_cancelar
        Me.cmdCancelar.ImageLocation = DevExpress.DXCore.Controls.XtraEditors.ImageLocation.TopCenter
        Me.cmdCancelar.Location = New System.Drawing.Point(117, 15)
        Me.cmdCancelar.LookAndFeel.SkinName = "Black"
        Me.cmdCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(100, 70)
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
        Me.cmdGrabar.Location = New System.Drawing.Point(12, 15)
        Me.cmdGrabar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdGrabar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdGrabar.Name = "cmdGrabar"
        Me.cmdGrabar.Size = New System.Drawing.Size(100, 70)
        Me.cmdGrabar.TabIndex = 33
        Me.cmdGrabar.Text = "GRABAR"
        '
        'ep
        '
        Me.ep.ContainerControl = Me
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        '
        '
        '
        Me.lblUsuario.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.Location = New System.Drawing.Point(389, 736)
        Me.lblUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(10, 18)
        Me.lblUsuario.TabIndex = 1003
        Me.lblUsuario.Text = "u"
        '
        'p_pedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(1360, 725)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.tabcontrol)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.cboTipoCliente)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.chkIGV)
        Me.Controls.Add(Me.lblItems)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtIGV)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtSubTotal)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cmdBuscar)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.dataArticulo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "p_pedido"
        Me.Text = ""
        Me.tabcontrol.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        CType(Me.dataDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbp.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.pb_foto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.dt_pedido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_horaEntrega, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_entrega, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataArticulo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.ep, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtSerPedido As System.Windows.Forms.TextBox
    Friend WithEvents txtNroPedido As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cboCliente As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtRuc As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtDirEntrega As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtContacto As System.Windows.Forms.TextBox
    Friend WithEvents cboFPago As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ep As System.Windows.Forms.ErrorProvider
    Friend WithEvents cboVendedor As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bp As System.Windows.Forms.ProgressBar
    Friend WithEvents Bgw As System.ComponentModel.BackgroundWorker
    Friend WithEvents Timer As System.Windows.Forms.Timer
    Friend WithEvents gbp As System.Windows.Forms.GroupBox
    Friend WithEvents cmdGrabar As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents cmdEliminar As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents cmdCancelar As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents cmdImprimir As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents dataArticulo As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cmdBuscar As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtIGV As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtSubTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lblItems As DevComponents.DotNetBar.LabelX
    Friend WithEvents chkIGV As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents lblTC As DevComponents.DotNetBar.LabelX
    Friend WithEvents optDolares As System.Windows.Forms.RadioButton
    Friend WithEvents optMoneda As System.Windows.Forms.RadioButton
    Friend WithEvents cboTipoCliente As System.Windows.Forms.ComboBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents lblArea As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cboArea As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cboOrigen As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cboDestino As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtObs As RichTextBox
    Friend WithEvents cboPedido As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents CboEstado As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Label10 As Label
    Friend WithEvents Label16 As Label
    Private WithEvents dt_entrega As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Private WithEvents dt_pedido As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Label2 As Label
    Private WithEvents dt_horaEntrega As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents CboResponsable As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cmdCopiar As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents Button1 As Button
    Friend WithEvents tabcontrol As TabControl
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents dataDetalle As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents pb_foto As PictureBox
    Friend WithEvents SimpleButton1 As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents cmdExaminar As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents lblarticulo As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblUsuario As DevComponents.DotNetBar.LabelX
    Friend WithEvents ChkResppn As CheckBox
End Class
