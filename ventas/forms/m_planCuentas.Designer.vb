<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class m_planCuentas
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(m_planCuentas))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dataDetalle = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.optDescripcion = New System.Windows.Forms.RadioButton()
        Me.optCodigo = New System.Windows.Forms.RadioButton()
        Me.txtBuscar = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.cmdImprimir = New DevComponents.DotNetBar.ButtonX()
        Me.cmdCerrar = New DevComponents.DotNetBar.ButtonX()
        Me.cboGrupo = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.chkGrupo = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.cboAlmacen = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.chkAlmacen = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.lblRegistros = New DevComponents.DotNetBar.LabelX()
        Me.TabControl1 = New DevComponents.DotNetBar.TabControl()
        Me.TabControlPanel2 = New DevComponents.DotNetBar.TabControlPanel()
        Me.chkProduccion = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.TabItem2 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel3 = New DevComponents.DotNetBar.TabControlPanel()
        Me.cmdActualizar = New DevExpress.DXCore.Controls.XtraEditors.SimpleButton()
        Me.chkAlmacenGrupo = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.lblNroGrupos = New DevComponents.DotNetBar.LabelX()
        Me.cboAlmacenGrupo = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.dataDetalleGrupo = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.TabItem3 = New DevComponents.DotNetBar.TabItem(Me.components)
        CType(Me.dataDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabControlPanel2.SuspendLayout()
        Me.TabControlPanel3.SuspendLayout()
        CType(Me.dataDetalleGrupo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dataDetalle
        '
        Me.dataDetalle.AllowUserToAddRows = False
        Me.dataDetalle.AllowUserToDeleteRows = False
        Me.dataDetalle.AllowUserToResizeColumns = False
        Me.dataDetalle.AllowUserToResizeRows = False
        Me.dataDetalle.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dataDetalle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataDetalle.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dataDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataDetalle.DefaultCellStyle = DataGridViewCellStyle2
        Me.dataDetalle.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dataDetalle.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dataDetalle.Location = New System.Drawing.Point(1, 49)
        Me.dataDetalle.MultiSelect = False
        Me.dataDetalle.Name = "dataDetalle"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataDetalle.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dataDetalle.RowHeadersVisible = False
        Me.dataDetalle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dataDetalle.SelectAllSignVisible = False
        Me.dataDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dataDetalle.ShowEditingIcon = False
        Me.dataDetalle.Size = New System.Drawing.Size(883, 386)
        Me.dataDetalle.TabIndex = 102
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LabelX3)
        Me.GroupBox2.Controls.Add(Me.LabelX1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox2.Location = New System.Drawing.Point(6, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(470, 52)
        Me.GroupBox2.TabIndex = 110
        Me.GroupBox2.TabStop = False
        '
        'LabelX3
        '
        Me.LabelX3.AutoSize = True
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LabelX3.Location = New System.Drawing.Point(7, 28)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(284, 15)
        Me.LabelX3.TabIndex = 2
        Me.LabelX3.Text = "El Plan de Cuentas lo establece el Area de Contabilidad..."
        '
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LabelX1.Location = New System.Drawing.Point(7, 12)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(459, 15)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "El Plan de Cuentas es necesario para migrar información del Sistema a un Software" & _
            " Contable"
        '
        'LabelX4
        '
        Me.LabelX4.AutoSize = True
        Me.LabelX4.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.ForeColor = System.Drawing.Color.Maroon
        Me.LabelX4.Location = New System.Drawing.Point(7, 6)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(51, 16)
        Me.LabelX4.TabIndex = 115
        Me.LabelX4.Text = "Buscar x"
        Me.LabelX4.TextAlignment = System.Drawing.StringAlignment.Center
        Me.LabelX4.WordWrap = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(-26, 45)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1000, 10)
        Me.GroupBox3.TabIndex = 113
        Me.GroupBox3.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.White
        Me.GroupBox4.Controls.Add(Me.optDescripcion)
        Me.GroupBox4.Controls.Add(Me.optCodigo)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox4.Location = New System.Drawing.Point(61, -4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(160, 34)
        Me.GroupBox4.TabIndex = 111
        Me.GroupBox4.TabStop = False
        '
        'optDescripcion
        '
        Me.optDescripcion.AutoSize = True
        Me.optDescripcion.Checked = True
        Me.optDescripcion.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optDescripcion.ForeColor = System.Drawing.Color.Black
        Me.optDescripcion.Location = New System.Drawing.Point(68, 10)
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
        Me.optCodigo.Location = New System.Drawing.Point(7, 10)
        Me.optCodigo.Name = "optCodigo"
        Me.optCodigo.Size = New System.Drawing.Size(64, 18)
        Me.optCodigo.TabIndex = 0
        Me.optCodigo.Text = "Código"
        Me.optCodigo.UseVisualStyleBackColor = True
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
        Me.txtBuscar.Location = New System.Drawing.Point(223, 6)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(151, 21)
        Me.txtBuscar.TabIndex = 112
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.Image = Global.cefe.My.Resources.Resources.buscar20
        Me.PictureBox2.Location = New System.Drawing.Point(376, 6)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 114
        Me.PictureBox2.TabStop = False
        '
        'cmdImprimir
        '
        Me.cmdImprimir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdImprimir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdImprimir.Image = CType(resources.GetObject("cmdImprimir.Image"), System.Drawing.Image)
        Me.cmdImprimir.Location = New System.Drawing.Point(705, 10)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.cmdImprimir.Size = New System.Drawing.Size(80, 36)
        Me.cmdImprimir.TabIndex = 116
        Me.cmdImprimir.Text = "Imprimir"
        '
        'cmdCerrar
        '
        Me.cmdCerrar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdCerrar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCerrar.Image = Global.cefe.My.Resources.Resources.CLOSE22
        Me.cmdCerrar.Location = New System.Drawing.Point(793, 10)
        Me.cmdCerrar.Name = "cmdCerrar"
        Me.cmdCerrar.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.cmdCerrar.Size = New System.Drawing.Size(80, 36)
        Me.cmdCerrar.TabIndex = 117
        Me.cmdCerrar.Text = "Cerrar"
        '
        'cboGrupo
        '
        Me.cboGrupo.DisabledBackColor = System.Drawing.Color.White
        Me.cboGrupo.DisplayMember = "Text"
        Me.cboGrupo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGrupo.Enabled = False
        Me.cboGrupo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGrupo.ForeColor = System.Drawing.Color.Black
        Me.cboGrupo.FormattingEnabled = True
        Me.cboGrupo.ItemHeight = 15
        Me.cboGrupo.Location = New System.Drawing.Point(705, 6)
        Me.cboGrupo.Name = "cboGrupo"
        Me.cboGrupo.Size = New System.Drawing.Size(171, 21)
        Me.cboGrupo.TabIndex = 119
        Me.cboGrupo.WatermarkColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'chkGrupo
        '
        Me.chkGrupo.AutoSize = True
        Me.chkGrupo.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.chkGrupo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chkGrupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkGrupo.Location = New System.Drawing.Point(643, 8)
        Me.chkGrupo.Name = "chkGrupo"
        Me.chkGrupo.Size = New System.Drawing.Size(60, 15)
        Me.chkGrupo.TabIndex = 120
        Me.chkGrupo.Text = "xGrupo"
        Me.chkGrupo.TextColor = System.Drawing.Color.Maroon
        '
        'cboAlmacen
        '
        Me.cboAlmacen.DisabledBackColor = System.Drawing.Color.White
        Me.cboAlmacen.DisplayMember = "Text"
        Me.cboAlmacen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboAlmacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAlmacen.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAlmacen.ForeColor = System.Drawing.Color.Black
        Me.cboAlmacen.FormattingEnabled = True
        Me.cboAlmacen.ItemHeight = 15
        Me.cboAlmacen.Location = New System.Drawing.Point(485, 6)
        Me.cboAlmacen.Name = "cboAlmacen"
        Me.cboAlmacen.Size = New System.Drawing.Size(149, 21)
        Me.cboAlmacen.TabIndex = 121
        Me.cboAlmacen.WatermarkColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'chkAlmacen
        '
        Me.chkAlmacen.AutoSize = True
        Me.chkAlmacen.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.chkAlmacen.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chkAlmacen.Checked = True
        Me.chkAlmacen.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAlmacen.CheckValue = "Y"
        Me.chkAlmacen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAlmacen.Location = New System.Drawing.Point(410, 8)
        Me.chkAlmacen.Name = "chkAlmacen"
        Me.chkAlmacen.Size = New System.Drawing.Size(73, 15)
        Me.chkAlmacen.TabIndex = 122
        Me.chkAlmacen.Text = "xAlmacen"
        Me.chkAlmacen.TextColor = System.Drawing.Color.Maroon
        '
        'lblRegistros
        '
        '
        '
        '
        Me.lblRegistros.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblRegistros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistros.ForeColor = System.Drawing.Color.Green
        Me.lblRegistros.Location = New System.Drawing.Point(478, 20)
        Me.lblRegistros.Name = "lblRegistros"
        Me.lblRegistros.Size = New System.Drawing.Size(221, 19)
        Me.lblRegistros.TabIndex = 140
        Me.lblRegistros.Text = "Nº de Registros Procesados... "
        Me.lblRegistros.TextAlignment = System.Drawing.StringAlignment.Center
        Me.lblRegistros.WordWrap = True
        '
        'TabControl1
        '
        Me.TabControl1.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabControl1.CanReorderTabs = False
        Me.TabControl1.ColorScheme.TabBackground = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabControl1.ColorScheme.TabItemBackground = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.TabControl1.ColorScheme.TabItemBackground2 = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabControl1.ColorScheme.TabItemSelectedBackground = System.Drawing.Color.White
        Me.TabControl1.ColorScheme.TabPanelBackground2 = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabControl1.Controls.Add(Me.TabControlPanel2)
        Me.TabControl1.Controls.Add(Me.TabControlPanel3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TabControl1.Location = New System.Drawing.Point(0, 58)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TabControl1.SelectedTabIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(885, 462)
        Me.TabControl1.Style = DevComponents.DotNetBar.eTabStripStyle.VS2005Document
        Me.TabControl1.TabIndex = 141
        Me.TabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
        Me.TabControl1.Tabs.Add(Me.TabItem2)
        Me.TabControl1.Tabs.Add(Me.TabItem3)
        Me.TabControl1.Text = "TabControl1"
        '
        'TabControlPanel2
        '
        Me.TabControlPanel2.Controls.Add(Me.chkProduccion)
        Me.TabControlPanel2.Controls.Add(Me.dataDetalle)
        Me.TabControlPanel2.Controls.Add(Me.PictureBox2)
        Me.TabControlPanel2.Controls.Add(Me.cboGrupo)
        Me.TabControlPanel2.Controls.Add(Me.chkGrupo)
        Me.TabControlPanel2.Controls.Add(Me.chkAlmacen)
        Me.TabControlPanel2.Controls.Add(Me.txtBuscar)
        Me.TabControlPanel2.Controls.Add(Me.cboAlmacen)
        Me.TabControlPanel2.Controls.Add(Me.GroupBox4)
        Me.TabControlPanel2.Controls.Add(Me.LabelX4)
        Me.TabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel2.Location = New System.Drawing.Point(0, 26)
        Me.TabControlPanel2.Name = "TabControlPanel2"
        Me.TabControlPanel2.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel2.Size = New System.Drawing.Size(885, 436)
        Me.TabControlPanel2.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.TabControlPanel2.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel2.Style.GradientAngle = 90
        Me.TabControlPanel2.TabIndex = 0
        Me.TabControlPanel2.TabItem = Me.TabItem2
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
        Me.chkProduccion.Location = New System.Drawing.Point(410, 29)
        Me.chkProduccion.Name = "chkProduccion"
        Me.chkProduccion.Size = New System.Drawing.Size(66, 15)
        Me.chkProduccion.TabIndex = 123
        Me.chkProduccion.Text = "Insumos"
        '
        'TabItem2
        '
        Me.TabItem2.AttachedControl = Me.TabControlPanel2
        Me.TabItem2.Name = "TabItem2"
        Me.TabItem2.Text = "Plan de Cuentas x Producto"
        '
        'TabControlPanel3
        '
        Me.TabControlPanel3.Controls.Add(Me.cmdActualizar)
        Me.TabControlPanel3.Controls.Add(Me.chkAlmacenGrupo)
        Me.TabControlPanel3.Controls.Add(Me.lblNroGrupos)
        Me.TabControlPanel3.Controls.Add(Me.cboAlmacenGrupo)
        Me.TabControlPanel3.Controls.Add(Me.dataDetalleGrupo)
        Me.TabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel3.Location = New System.Drawing.Point(0, 26)
        Me.TabControlPanel3.Name = "TabControlPanel3"
        Me.TabControlPanel3.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel3.Size = New System.Drawing.Size(885, 436)
        Me.TabControlPanel3.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabControlPanel3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel3.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.TabControlPanel3.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel3.Style.GradientAngle = 90
        Me.TabControlPanel3.TabIndex = 3
        Me.TabControlPanel3.TabItem = Me.TabItem3
        '
        'cmdActualizar
        '
        Me.cmdActualizar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdActualizar.Appearance.Options.UseFont = True
        Me.cmdActualizar.Image = CType(resources.GetObject("cmdActualizar.Image"), System.Drawing.Image)
        Me.cmdActualizar.ImageLocation = DevExpress.DXCore.Controls.XtraEditors.ImageLocation.MiddleRight
        Me.cmdActualizar.Location = New System.Drawing.Point(313, 1)
        Me.cmdActualizar.Name = "cmdActualizar"
        Me.cmdActualizar.Size = New System.Drawing.Size(210, 27)
        Me.cmdActualizar.TabIndex = 143
        Me.cmdActualizar.Text = "Actualizar Cuentas en Productos"
        '
        'chkAlmacenGrupo
        '
        Me.chkAlmacenGrupo.AutoSize = True
        Me.chkAlmacenGrupo.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.chkAlmacenGrupo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chkAlmacenGrupo.Checked = True
        Me.chkAlmacenGrupo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAlmacenGrupo.CheckValue = "Y"
        Me.chkAlmacenGrupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAlmacenGrupo.Location = New System.Drawing.Point(12, 9)
        Me.chkAlmacenGrupo.Name = "chkAlmacenGrupo"
        Me.chkAlmacenGrupo.Size = New System.Drawing.Size(73, 15)
        Me.chkAlmacenGrupo.TabIndex = 142
        Me.chkAlmacenGrupo.Text = "xAlmacen"
        Me.chkAlmacenGrupo.TextColor = System.Drawing.Color.Maroon
        '
        'lblNroGrupos
        '
        Me.lblNroGrupos.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.lblNroGrupos.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblNroGrupos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNroGrupos.ForeColor = System.Drawing.Color.Green
        Me.lblNroGrupos.Location = New System.Drawing.Point(652, 6)
        Me.lblNroGrupos.Name = "lblNroGrupos"
        Me.lblNroGrupos.SingleLineColor = System.Drawing.Color.White
        Me.lblNroGrupos.Size = New System.Drawing.Size(221, 19)
        Me.lblNroGrupos.TabIndex = 141
        Me.lblNroGrupos.Text = "Nº de Grupos Procesados... "
        Me.lblNroGrupos.TextAlignment = System.Drawing.StringAlignment.Far
        Me.lblNroGrupos.WordWrap = True
        '
        'cboAlmacenGrupo
        '
        Me.cboAlmacenGrupo.DisabledBackColor = System.Drawing.Color.White
        Me.cboAlmacenGrupo.DisplayMember = "Text"
        Me.cboAlmacenGrupo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboAlmacenGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAlmacenGrupo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAlmacenGrupo.ForeColor = System.Drawing.Color.Black
        Me.cboAlmacenGrupo.FormattingEnabled = True
        Me.cboAlmacenGrupo.ItemHeight = 15
        Me.cboAlmacenGrupo.Location = New System.Drawing.Point(87, 6)
        Me.cboAlmacenGrupo.Name = "cboAlmacenGrupo"
        Me.cboAlmacenGrupo.Size = New System.Drawing.Size(177, 21)
        Me.cboAlmacenGrupo.TabIndex = 122
        Me.cboAlmacenGrupo.WatermarkColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'dataDetalleGrupo
        '
        Me.dataDetalleGrupo.AllowUserToAddRows = False
        Me.dataDetalleGrupo.AllowUserToDeleteRows = False
        Me.dataDetalleGrupo.AllowUserToResizeColumns = False
        Me.dataDetalleGrupo.AllowUserToResizeRows = False
        Me.dataDetalleGrupo.BackgroundColor = System.Drawing.Color.White
        Me.dataDetalleGrupo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataDetalleGrupo.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dataDetalleGrupo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataDetalleGrupo.DefaultCellStyle = DataGridViewCellStyle5
        Me.dataDetalleGrupo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dataDetalleGrupo.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dataDetalleGrupo.Location = New System.Drawing.Point(1, 33)
        Me.dataDetalleGrupo.MultiSelect = False
        Me.dataDetalleGrupo.Name = "dataDetalleGrupo"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataDetalleGrupo.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dataDetalleGrupo.RowHeadersVisible = False
        Me.dataDetalleGrupo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dataDetalleGrupo.SelectAllSignVisible = False
        Me.dataDetalleGrupo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dataDetalleGrupo.ShowEditingIcon = False
        Me.dataDetalleGrupo.Size = New System.Drawing.Size(883, 402)
        Me.dataDetalleGrupo.TabIndex = 103
        '
        'TabItem3
        '
        Me.TabItem3.AttachedControl = Me.TabControlPanel3
        Me.TabItem3.Name = "TabItem3"
        Me.TabItem3.Text = "Plan de Cuentas x Grupo"
        '
        'm_planCuentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(885, 520)
        Me.Controls.Add(Me.cmdImprimir)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.lblRegistros)
        Me.Controls.Add(Me.cmdCerrar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "m_planCuentas"
        Me.Text = "Mantenimiento: PLAN DE CUENTAS"
        CType(Me.dataDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabControlPanel2.ResumeLayout(False)
        Me.TabControlPanel2.PerformLayout()
        Me.TabControlPanel3.ResumeLayout(False)
        Me.TabControlPanel3.PerformLayout()
        CType(Me.dataDetalleGrupo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dataDetalle As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents optDescripcion As System.Windows.Forms.RadioButton
    Friend WithEvents optCodigo As System.Windows.Forms.RadioButton
    Friend WithEvents txtBuscar As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents cmdImprimir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmdCerrar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cboGrupo As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents chkGrupo As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents cboAlmacen As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents chkAlmacen As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents lblRegistros As DevComponents.DotNetBar.LabelX
    Friend WithEvents TabControl1 As DevComponents.DotNetBar.TabControl
    Friend WithEvents TabControlPanel2 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabItem2 As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabControlPanel3 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabItem3 As DevComponents.DotNetBar.TabItem
    Friend WithEvents dataDetalleGrupo As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents cboAlmacenGrupo As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents lblNroGrupos As DevComponents.DotNetBar.LabelX
    Friend WithEvents chkAlmacenGrupo As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents cmdActualizar As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents chkProduccion As DevComponents.DotNetBar.Controls.CheckBoxX

End Class
