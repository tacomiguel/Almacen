<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class m_subgrupo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(m_subgrupo))
        Me.TabControl2 = New DevComponents.DotNetBar.TabControl()
        Me.TabControlPanel4 = New DevComponents.DotNetBar.TabControlPanel()
        Me.datos = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.tabreceta = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel2 = New DevComponents.DotNetBar.TabControlPanel()
        Me.Etiqueta10 = New mControles.etiqueta()
        Me.txtImpresora = New System.Windows.Forms.TextBox()
        Me.Etiqueta9 = New mControles.etiqueta()
        Me.txttamfuente = New System.Windows.Forms.TextBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Etiqueta3 = New mControles.etiqueta()
        Me.Etiqueta7 = New mControles.etiqueta()
        Me.Etiqueta8 = New mControles.etiqueta()
        Me.TxtColorfuente = New System.Windows.Forms.TextBox()
        Me.lnkColor = New System.Windows.Forms.LinkLabel()
        Me.Etiqueta6 = New mControles.etiqueta()
        Me.Etiqueta5 = New mControles.etiqueta()
        Me.Etiqueta4 = New mControles.etiqueta()
        Me.txtColor = New System.Windows.Forms.TextBox()
        Me.Etiqueta2 = New mControles.etiqueta()
        Me.Etiqueta1 = New mControles.etiqueta()
        Me.txtalto = New System.Windows.Forms.TextBox()
        Me.txtancho = New System.Windows.Forms.TextBox()
        Me.SimpleButton1 = New DevExpress.DXCore.Controls.XtraEditors.SimpleButton()
        Me.cmdExaminar = New DevExpress.DXCore.Controls.XtraEditors.SimpleButton()
        Me.pb_foto = New System.Windows.Forms.PictureBox()
        Me.TabItem1 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmdEditar = New DevExpress.DXCore.Controls.XtraEditors.SimpleButton()
        Me.cmdAñadir = New DevExpress.DXCore.Controls.XtraEditors.SimpleButton()
        Me.cmdEliminar = New DevExpress.DXCore.Controls.XtraEditors.SimpleButton()
        Me.cmdGrabar = New DevExpress.DXCore.Controls.XtraEditors.SimpleButton()
        Me.cmdCancelar = New DevExpress.DXCore.Controls.XtraEditors.SimpleButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdCerrar = New DevExpress.DXCore.Controls.XtraEditors.SimpleButton()
        Me.grupoDetalle = New System.Windows.Forms.GroupBox()
        Me.ChkGerencia = New System.Windows.Forms.CheckBox()
        Me.cboGrupo = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Etiqueta11 = New mControles.etiqueta()
        Me.ChkVentas = New System.Windows.Forms.CheckBox()
        Me.cboFamilia = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.chkInventario = New System.Windows.Forms.CheckBox()
        Me.chkActivo = New System.Windows.Forms.CheckBox()
        Me.chkProduccion = New System.Windows.Forms.CheckBox()
        Me.lblFamilia = New mControles.etiqueta()
        Me.txtGrupo = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.lblGrupo = New mControles.etiqueta()
        Me.lblCodigo = New mControles.etiqueta()
        CType(Me.TabControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl2.SuspendLayout()
        Me.TabControlPanel4.SuspendLayout()
        CType(Me.datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlPanel2.SuspendLayout()
        CType(Me.pb_foto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grupoDetalle.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl2
        '
        Me.TabControl2.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabControl2.CanReorderTabs = False
        Me.TabControl2.ColorScheme.TabBackground = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabControl2.ColorScheme.TabBackground2 = System.Drawing.Color.White
        Me.TabControl2.ColorScheme.TabItemBackground = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.TabControl2.ColorScheme.TabItemBackground2 = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabControl2.Controls.Add(Me.TabControlPanel4)
        Me.TabControl2.Controls.Add(Me.TabControlPanel2)
        Me.TabControl2.Location = New System.Drawing.Point(3, 5)
        Me.TabControl2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TabControl2.SelectedTabIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(737, 364)
        Me.TabControl2.Style = DevComponents.DotNetBar.eTabStripStyle.VS2005Document
        Me.TabControl2.TabIndex = 146
        Me.TabControl2.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
        Me.TabControl2.Tabs.Add(Me.tabreceta)
        Me.TabControl2.Tabs.Add(Me.TabItem1)
        '
        'TabControlPanel4
        '
        Me.TabControlPanel4.Controls.Add(Me.datos)
        Me.TabControlPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel4.Location = New System.Drawing.Point(0, 26)
        Me.TabControlPanel4.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControlPanel4.Name = "TabControlPanel4"
        Me.TabControlPanel4.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel4.Size = New System.Drawing.Size(737, 338)
        Me.TabControlPanel4.Style.BackColor1.Color = System.Drawing.Color.White
        Me.TabControlPanel4.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabControlPanel4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel4.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.TabControlPanel4.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel4.Style.GradientAngle = 90
        Me.TabControlPanel4.TabIndex = 1
        Me.TabControlPanel4.TabItem = Me.tabreceta
        '
        'datos
        '
        Me.datos.AllowUserToAddRows = False
        Me.datos.AllowUserToDeleteRows = False
        Me.datos.AllowUserToResizeColumns = False
        Me.datos.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.datos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.datos.BackgroundColor = System.Drawing.Color.White
        Me.datos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datos.DefaultCellStyle = DataGridViewCellStyle3
        Me.datos.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.datos.Location = New System.Drawing.Point(0, -1)
        Me.datos.Margin = New System.Windows.Forms.Padding(4)
        Me.datos.Name = "datos"
        Me.datos.ReadOnly = True
        Me.datos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.datos.SelectAllSignVisible = False
        Me.datos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datos.ShowEditingIcon = False
        Me.datos.Size = New System.Drawing.Size(737, 334)
        Me.datos.TabIndex = 1
        '
        'tabreceta
        '
        Me.tabreceta.AttachedControl = Me.TabControlPanel4
        Me.tabreceta.Icon = CType(resources.GetObject("tabreceta.Icon"), System.Drawing.Icon)
        Me.tabreceta.Name = "tabreceta"
        Me.tabreceta.Text = "Grupo Articulo"
        '
        'TabControlPanel2
        '
        Me.TabControlPanel2.Controls.Add(Me.Etiqueta10)
        Me.TabControlPanel2.Controls.Add(Me.txtImpresora)
        Me.TabControlPanel2.Controls.Add(Me.Etiqueta9)
        Me.TabControlPanel2.Controls.Add(Me.txttamfuente)
        Me.TabControlPanel2.Controls.Add(Me.LinkLabel1)
        Me.TabControlPanel2.Controls.Add(Me.Etiqueta3)
        Me.TabControlPanel2.Controls.Add(Me.Etiqueta7)
        Me.TabControlPanel2.Controls.Add(Me.Etiqueta8)
        Me.TabControlPanel2.Controls.Add(Me.TxtColorfuente)
        Me.TabControlPanel2.Controls.Add(Me.lnkColor)
        Me.TabControlPanel2.Controls.Add(Me.Etiqueta6)
        Me.TabControlPanel2.Controls.Add(Me.Etiqueta5)
        Me.TabControlPanel2.Controls.Add(Me.Etiqueta4)
        Me.TabControlPanel2.Controls.Add(Me.txtColor)
        Me.TabControlPanel2.Controls.Add(Me.Etiqueta2)
        Me.TabControlPanel2.Controls.Add(Me.Etiqueta1)
        Me.TabControlPanel2.Controls.Add(Me.txtalto)
        Me.TabControlPanel2.Controls.Add(Me.txtancho)
        Me.TabControlPanel2.Controls.Add(Me.SimpleButton1)
        Me.TabControlPanel2.Controls.Add(Me.cmdExaminar)
        Me.TabControlPanel2.Controls.Add(Me.pb_foto)
        Me.TabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel2.Location = New System.Drawing.Point(0, 26)
        Me.TabControlPanel2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControlPanel2.Name = "TabControlPanel2"
        Me.TabControlPanel2.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel2.Size = New System.Drawing.Size(737, 338)
        Me.TabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.White
        Me.TabControlPanel2.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.TabControlPanel2.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel2.Style.GradientAngle = 90
        Me.TabControlPanel2.TabIndex = 4
        Me.TabControlPanel2.TabItem = Me.TabItem1
        '
        'Etiqueta10
        '
        Me.Etiqueta10.AutoSize = True
        Me.Etiqueta10.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Etiqueta10.BackColor = System.Drawing.Color.White
        Me.Etiqueta10.Location = New System.Drawing.Point(501, 186)
        Me.Etiqueta10.Margin = New System.Windows.Forms.Padding(5)
        Me.Etiqueta10.Name = "Etiqueta10"
        Me.Etiqueta10.Size = New System.Drawing.Size(88, 19)
        Me.Etiqueta10.TabIndex = 170
        Me.Etiqueta10.TabStop = False
        Me.Etiqueta10.texto = "Impresora"
        '
        'txtImpresora
        '
        Me.txtImpresora.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImpresora.ForeColor = System.Drawing.Color.DarkRed
        Me.txtImpresora.Location = New System.Drawing.Point(501, 209)
        Me.txtImpresora.Margin = New System.Windows.Forms.Padding(4)
        Me.txtImpresora.Name = "txtImpresora"
        Me.txtImpresora.Size = New System.Drawing.Size(161, 26)
        Me.txtImpresora.TabIndex = 169
        '
        'Etiqueta9
        '
        Me.Etiqueta9.AutoSize = True
        Me.Etiqueta9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Etiqueta9.BackColor = System.Drawing.Color.White
        Me.Etiqueta9.Location = New System.Drawing.Point(499, 126)
        Me.Etiqueta9.Margin = New System.Windows.Forms.Padding(5)
        Me.Etiqueta9.Name = "Etiqueta9"
        Me.Etiqueta9.Size = New System.Drawing.Size(152, 19)
        Me.Etiqueta9.TabIndex = 168
        Me.Etiqueta9.TabStop = False
        Me.Etiqueta9.texto = "Tamaño de Fuente"
        '
        'txttamfuente
        '
        Me.txttamfuente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttamfuente.ForeColor = System.Drawing.Color.DarkRed
        Me.txttamfuente.Location = New System.Drawing.Point(501, 148)
        Me.txttamfuente.Margin = New System.Windows.Forms.Padding(4)
        Me.txttamfuente.Name = "txttamfuente"
        Me.txttamfuente.Size = New System.Drawing.Size(59, 26)
        Me.txttamfuente.TabIndex = 167
        Me.txttamfuente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(497, 64)
        Me.LinkLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(128, 20)
        Me.LinkLabel1.TabIndex = 166
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Color de Fuente"
        '
        'Etiqueta3
        '
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Etiqueta3.BackColor = System.Drawing.Color.White
        Me.Etiqueta3.ForeColor = System.Drawing.Color.Blue
        Me.Etiqueta3.Location = New System.Drawing.Point(624, 95)
        Me.Etiqueta3.Margin = New System.Windows.Forms.Padding(5)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(23, 19)
        Me.Etiqueta3.TabIndex = 165
        Me.Etiqueta3.TabStop = False
        Me.Etiqueta3.texto = "B"
        '
        'Etiqueta7
        '
        Me.Etiqueta7.AutoSize = True
        Me.Etiqueta7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Etiqueta7.BackColor = System.Drawing.Color.White
        Me.Etiqueta7.ForeColor = System.Drawing.Color.Lime
        Me.Etiqueta7.Location = New System.Drawing.Point(604, 95)
        Me.Etiqueta7.Margin = New System.Windows.Forms.Padding(5)
        Me.Etiqueta7.Name = "Etiqueta7"
        Me.Etiqueta7.Size = New System.Drawing.Size(25, 19)
        Me.Etiqueta7.TabIndex = 164
        Me.Etiqueta7.TabStop = False
        Me.Etiqueta7.texto = "G"
        '
        'Etiqueta8
        '
        Me.Etiqueta8.AutoSize = True
        Me.Etiqueta8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Etiqueta8.BackColor = System.Drawing.Color.White
        Me.Etiqueta8.ForeColor = System.Drawing.Color.Red
        Me.Etiqueta8.Location = New System.Drawing.Point(587, 95)
        Me.Etiqueta8.Margin = New System.Windows.Forms.Padding(5)
        Me.Etiqueta8.Name = "Etiqueta8"
        Me.Etiqueta8.Size = New System.Drawing.Size(24, 19)
        Me.Etiqueta8.TabIndex = 163
        Me.Etiqueta8.TabStop = False
        Me.Etiqueta8.texto = "R"
        '
        'TxtColorfuente
        '
        Me.TxtColorfuente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtColorfuente.ForeColor = System.Drawing.Color.DarkRed
        Me.TxtColorfuente.Location = New System.Drawing.Point(501, 87)
        Me.TxtColorfuente.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtColorfuente.Name = "TxtColorfuente"
        Me.TxtColorfuente.Size = New System.Drawing.Size(81, 26)
        Me.TxtColorfuente.TabIndex = 162
        Me.TxtColorfuente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lnkColor
        '
        Me.lnkColor.AutoSize = True
        Me.lnkColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkColor.Location = New System.Drawing.Point(497, 5)
        Me.lnkColor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lnkColor.Name = "lnkColor"
        Me.lnkColor.Size = New System.Drawing.Size(123, 20)
        Me.lnkColor.TabIndex = 161
        Me.lnkColor.TabStop = True
        Me.lnkColor.Text = "Color de Fondo"
        '
        'Etiqueta6
        '
        Me.Etiqueta6.AutoSize = True
        Me.Etiqueta6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Etiqueta6.BackColor = System.Drawing.Color.White
        Me.Etiqueta6.ForeColor = System.Drawing.Color.Blue
        Me.Etiqueta6.Location = New System.Drawing.Point(624, 33)
        Me.Etiqueta6.Margin = New System.Windows.Forms.Padding(5)
        Me.Etiqueta6.Name = "Etiqueta6"
        Me.Etiqueta6.Size = New System.Drawing.Size(23, 19)
        Me.Etiqueta6.TabIndex = 160
        Me.Etiqueta6.TabStop = False
        Me.Etiqueta6.texto = "B"
        '
        'Etiqueta5
        '
        Me.Etiqueta5.AutoSize = True
        Me.Etiqueta5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Etiqueta5.BackColor = System.Drawing.Color.White
        Me.Etiqueta5.ForeColor = System.Drawing.Color.Lime
        Me.Etiqueta5.Location = New System.Drawing.Point(604, 33)
        Me.Etiqueta5.Margin = New System.Windows.Forms.Padding(5)
        Me.Etiqueta5.Name = "Etiqueta5"
        Me.Etiqueta5.Size = New System.Drawing.Size(25, 19)
        Me.Etiqueta5.TabIndex = 159
        Me.Etiqueta5.TabStop = False
        Me.Etiqueta5.texto = "G"
        '
        'Etiqueta4
        '
        Me.Etiqueta4.AutoSize = True
        Me.Etiqueta4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Etiqueta4.BackColor = System.Drawing.Color.White
        Me.Etiqueta4.ForeColor = System.Drawing.Color.Red
        Me.Etiqueta4.Location = New System.Drawing.Point(587, 33)
        Me.Etiqueta4.Margin = New System.Windows.Forms.Padding(5)
        Me.Etiqueta4.Name = "Etiqueta4"
        Me.Etiqueta4.Size = New System.Drawing.Size(24, 19)
        Me.Etiqueta4.TabIndex = 158
        Me.Etiqueta4.TabStop = False
        Me.Etiqueta4.texto = "R"
        '
        'txtColor
        '
        Me.txtColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtColor.ForeColor = System.Drawing.Color.DarkRed
        Me.txtColor.Location = New System.Drawing.Point(501, 28)
        Me.txtColor.Margin = New System.Windows.Forms.Padding(4)
        Me.txtColor.Name = "txtColor"
        Me.txtColor.Size = New System.Drawing.Size(81, 26)
        Me.txtColor.TabIndex = 156
        Me.txtColor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Etiqueta2
        '
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Etiqueta2.BackColor = System.Drawing.Color.White
        Me.Etiqueta2.Location = New System.Drawing.Point(516, 282)
        Me.Etiqueta2.Margin = New System.Windows.Forms.Padding(5)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(41, 19)
        Me.Etiqueta2.TabIndex = 155
        Me.Etiqueta2.TabStop = False
        Me.Etiqueta2.texto = "Alto"
        '
        'Etiqueta1
        '
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Etiqueta1.BackColor = System.Drawing.Color.White
        Me.Etiqueta1.Location = New System.Drawing.Point(513, 252)
        Me.Etiqueta1.Margin = New System.Windows.Forms.Padding(5)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(59, 19)
        Me.Etiqueta1.TabIndex = 154
        Me.Etiqueta1.TabStop = False
        Me.Etiqueta1.texto = "Ancho"
        '
        'txtalto
        '
        Me.txtalto.Location = New System.Drawing.Point(580, 281)
        Me.txtalto.Margin = New System.Windows.Forms.Padding(4)
        Me.txtalto.Name = "txtalto"
        Me.txtalto.Size = New System.Drawing.Size(83, 22)
        Me.txtalto.TabIndex = 153
        '
        'txtancho
        '
        Me.txtancho.Location = New System.Drawing.Point(580, 249)
        Me.txtancho.Margin = New System.Windows.Forms.Padding(4)
        Me.txtancho.Name = "txtancho"
        Me.txtancho.Size = New System.Drawing.Size(83, 22)
        Me.txtancho.TabIndex = 152
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.ImageLocation = DevExpress.DXCore.Controls.XtraEditors.ImageLocation.TopCenter
        Me.SimpleButton1.Location = New System.Drawing.Point(21, 5)
        Me.SimpleButton1.LookAndFeel.SkinName = "iMaginary"
        Me.SimpleButton1.Margin = New System.Windows.Forms.Padding(4)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(41, 39)
        Me.SimpleButton1.TabIndex = 151
        '
        'cmdExaminar
        '
        Me.cmdExaminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmdExaminar.Appearance.Options.UseFont = True
        Me.cmdExaminar.Image = Global.cefe.My.Resources.Resources.c_buscarD
        Me.cmdExaminar.ImageLocation = DevExpress.DXCore.Controls.XtraEditors.ImageLocation.TopCenter
        Me.cmdExaminar.Location = New System.Drawing.Point(63, 5)
        Me.cmdExaminar.LookAndFeel.SkinName = "iMaginary"
        Me.cmdExaminar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdExaminar.Name = "cmdExaminar"
        Me.cmdExaminar.Size = New System.Drawing.Size(41, 39)
        Me.cmdExaminar.TabIndex = 149
        Me.cmdExaminar.Text = "Examinar"
        '
        'pb_foto
        '
        Me.pb_foto.Location = New System.Drawing.Point(135, 5)
        Me.pb_foto.Margin = New System.Windows.Forms.Padding(4)
        Me.pb_foto.Name = "pb_foto"
        Me.pb_foto.Size = New System.Drawing.Size(355, 302)
        Me.pb_foto.TabIndex = 0
        Me.pb_foto.TabStop = False
        '
        'TabItem1
        '
        Me.TabItem1.AttachedControl = Me.TabControlPanel2
        Me.TabItem1.Image = CType(resources.GetObject("TabItem1.Image"), System.Drawing.Image)
        Me.TabItem1.Name = "TabItem1"
        Me.TabItem1.Text = "Imagen"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmdEditar)
        Me.GroupBox2.Controls.Add(Me.cmdAñadir)
        Me.GroupBox2.Controls.Add(Me.cmdEliminar)
        Me.GroupBox2.Controls.Add(Me.cmdGrabar)
        Me.GroupBox2.Controls.Add(Me.cmdCancelar)
        Me.GroupBox2.Location = New System.Drawing.Point(761, 11)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(99, 327)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'cmdEditar
        '
        Me.cmdEditar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmdEditar.Appearance.Options.UseFont = True
        Me.cmdEditar.Image = Global.cefe.My.Resources.Resources.m_editar
        Me.cmdEditar.ImageLocation = DevExpress.DXCore.Controls.XtraEditors.ImageLocation.TopCenter
        Me.cmdEditar.Location = New System.Drawing.Point(8, 263)
        Me.cmdEditar.LookAndFeel.SkinName = "iMaginary"
        Me.cmdEditar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdEditar.Name = "cmdEditar"
        Me.cmdEditar.Size = New System.Drawing.Size(83, 55)
        Me.cmdEditar.TabIndex = 39
        Me.cmdEditar.Text = "Editar"
        '
        'cmdAñadir
        '
        Me.cmdAñadir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmdAñadir.Appearance.Options.UseFont = True
        Me.cmdAñadir.Image = Global.cefe.My.Resources.Resources.m_añadir
        Me.cmdAñadir.ImageLocation = DevExpress.DXCore.Controls.XtraEditors.ImageLocation.TopCenter
        Me.cmdAñadir.Location = New System.Drawing.Point(8, 16)
        Me.cmdAñadir.LookAndFeel.SkinName = "iMaginary"
        Me.cmdAñadir.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdAñadir.Name = "cmdAñadir"
        Me.cmdAñadir.Size = New System.Drawing.Size(83, 55)
        Me.cmdAñadir.TabIndex = 0
        Me.cmdAñadir.Text = "Añadir"
        '
        'cmdEliminar
        '
        Me.cmdEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmdEliminar.Appearance.Options.UseFont = True
        Me.cmdEliminar.Image = Global.cefe.My.Resources.Resources.m_borrar
        Me.cmdEliminar.ImageLocation = DevExpress.DXCore.Controls.XtraEditors.ImageLocation.TopCenter
        Me.cmdEliminar.Location = New System.Drawing.Point(8, 201)
        Me.cmdEliminar.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdEliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(83, 55)
        Me.cmdEliminar.TabIndex = 38
        Me.cmdEliminar.Text = "Eliminar"
        '
        'cmdGrabar
        '
        Me.cmdGrabar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmdGrabar.Appearance.Options.UseFont = True
        Me.cmdGrabar.Enabled = False
        Me.cmdGrabar.Image = Global.cefe.My.Resources.Resources.m_grabar
        Me.cmdGrabar.ImageLocation = DevExpress.DXCore.Controls.XtraEditors.ImageLocation.TopCenter
        Me.cmdGrabar.Location = New System.Drawing.Point(8, 78)
        Me.cmdGrabar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdGrabar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdGrabar.Name = "cmdGrabar"
        Me.cmdGrabar.Size = New System.Drawing.Size(83, 55)
        Me.cmdGrabar.TabIndex = 0
        Me.cmdGrabar.Text = "Grabar"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.Enabled = False
        Me.cmdCancelar.Image = Global.cefe.My.Resources.Resources.m_cancelar
        Me.cmdCancelar.ImageLocation = DevExpress.DXCore.Controls.XtraEditors.ImageLocation.TopCenter
        Me.cmdCancelar.Location = New System.Drawing.Point(8, 138)
        Me.cmdCancelar.LookAndFeel.SkinName = "Black"
        Me.cmdCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(83, 55)
        Me.cmdCancelar.TabIndex = 37
        Me.cmdCancelar.Text = "Cancelar"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdCerrar)
        Me.GroupBox1.Location = New System.Drawing.Point(761, 404)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(99, 79)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'cmdCerrar
        '
        Me.cmdCerrar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmdCerrar.Appearance.Options.UseFont = True
        Me.cmdCerrar.Image = Global.cefe.My.Resources.Resources.CLOSE22
        Me.cmdCerrar.ImageLocation = DevExpress.DXCore.Controls.XtraEditors.ImageLocation.TopCenter
        Me.cmdCerrar.Location = New System.Drawing.Point(8, 16)
        Me.cmdCerrar.LookAndFeel.SkinName = "iMaginary"
        Me.cmdCerrar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdCerrar.Name = "cmdCerrar"
        Me.cmdCerrar.Size = New System.Drawing.Size(83, 55)
        Me.cmdCerrar.TabIndex = 40
        Me.cmdCerrar.Text = "Cerrar"
        '
        'grupoDetalle
        '
        Me.grupoDetalle.Controls.Add(Me.ChkGerencia)
        Me.grupoDetalle.Controls.Add(Me.cboGrupo)
        Me.grupoDetalle.Controls.Add(Me.Etiqueta11)
        Me.grupoDetalle.Controls.Add(Me.ChkVentas)
        Me.grupoDetalle.Controls.Add(Me.cboFamilia)
        Me.grupoDetalle.Controls.Add(Me.chkInventario)
        Me.grupoDetalle.Controls.Add(Me.chkActivo)
        Me.grupoDetalle.Controls.Add(Me.chkProduccion)
        Me.grupoDetalle.Controls.Add(Me.lblFamilia)
        Me.grupoDetalle.Controls.Add(Me.txtGrupo)
        Me.grupoDetalle.Controls.Add(Me.txtCodigo)
        Me.grupoDetalle.Controls.Add(Me.lblGrupo)
        Me.grupoDetalle.Controls.Add(Me.lblCodigo)
        Me.grupoDetalle.Location = New System.Drawing.Point(16, 377)
        Me.grupoDetalle.Margin = New System.Windows.Forms.Padding(4)
        Me.grupoDetalle.Name = "grupoDetalle"
        Me.grupoDetalle.Padding = New System.Windows.Forms.Padding(4)
        Me.grupoDetalle.Size = New System.Drawing.Size(724, 165)
        Me.grupoDetalle.TabIndex = 1
        Me.grupoDetalle.TabStop = False
        '
        'ChkGerencia
        '
        Me.ChkGerencia.AutoSize = True
        Me.ChkGerencia.Enabled = False
        Me.ChkGerencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkGerencia.ForeColor = System.Drawing.Color.Black
        Me.ChkGerencia.Location = New System.Drawing.Point(319, 62)
        Me.ChkGerencia.Margin = New System.Windows.Forms.Padding(4)
        Me.ChkGerencia.Name = "ChkGerencia"
        Me.ChkGerencia.Size = New System.Drawing.Size(292, 21)
        Me.ChkGerencia.TabIndex = 153
        Me.ChkGerencia.Text = "Se muestra en Reporte de Gerencia"
        Me.ChkGerencia.UseVisualStyleBackColor = True
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
        Me.cboGrupo.Location = New System.Drawing.Point(8, 133)
        Me.cboGrupo.Margin = New System.Windows.Forms.Padding(4)
        Me.cboGrupo.Name = "cboGrupo"
        Me.cboGrupo.Size = New System.Drawing.Size(289, 21)
        Me.cboGrupo.TabIndex = 152
        Me.cboGrupo.WatermarkColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'Etiqueta11
        '
        Me.Etiqueta11.AutoSize = True
        Me.Etiqueta11.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Etiqueta11.BackColor = System.Drawing.Color.White
        Me.Etiqueta11.Location = New System.Drawing.Point(8, 110)
        Me.Etiqueta11.Margin = New System.Windows.Forms.Padding(5)
        Me.Etiqueta11.Name = "Etiqueta11"
        Me.Etiqueta11.Size = New System.Drawing.Size(59, 19)
        Me.Etiqueta11.TabIndex = 151
        Me.Etiqueta11.TabStop = False
        Me.Etiqueta11.texto = "Grupo"
        '
        'ChkVentas
        '
        Me.ChkVentas.AutoSize = True
        Me.ChkVentas.Enabled = False
        Me.ChkVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkVentas.ForeColor = System.Drawing.Color.Black
        Me.ChkVentas.Location = New System.Drawing.Point(319, 108)
        Me.ChkVentas.Margin = New System.Windows.Forms.Padding(4)
        Me.ChkVentas.Name = "ChkVentas"
        Me.ChkVentas.Size = New System.Drawing.Size(119, 21)
        Me.ChkVentas.TabIndex = 150
        Me.ChkVentas.Text = "Para Ventas"
        Me.ChkVentas.UseVisualStyleBackColor = True
        '
        'cboFamilia
        '
        Me.cboFamilia.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboFamilia.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cboFamilia.DisplayMember = "Text"
        Me.cboFamilia.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboFamilia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFamilia.Enabled = False
        Me.cboFamilia.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFamilia.ForeColor = System.Drawing.Color.Black
        Me.cboFamilia.FormattingEnabled = True
        Me.cboFamilia.ItemHeight = 15
        Me.cboFamilia.Location = New System.Drawing.Point(8, 82)
        Me.cboFamilia.Margin = New System.Windows.Forms.Padding(4)
        Me.cboFamilia.Name = "cboFamilia"
        Me.cboFamilia.Size = New System.Drawing.Size(289, 21)
        Me.cboFamilia.TabIndex = 149
        Me.cboFamilia.WatermarkColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'chkInventario
        '
        Me.chkInventario.AutoSize = True
        Me.chkInventario.Enabled = False
        Me.chkInventario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkInventario.ForeColor = System.Drawing.Color.Black
        Me.chkInventario.Location = New System.Drawing.Point(319, 85)
        Me.chkInventario.Margin = New System.Windows.Forms.Padding(4)
        Me.chkInventario.Name = "chkInventario"
        Me.chkInventario.Size = New System.Drawing.Size(306, 21)
        Me.chkInventario.TabIndex = 8
        Me.chkInventario.Text = "Se muestra en Reporte de Inventarios"
        Me.chkInventario.UseVisualStyleBackColor = True
        '
        'chkActivo
        '
        Me.chkActivo.AutoSize = True
        Me.chkActivo.Enabled = False
        Me.chkActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkActivo.ForeColor = System.Drawing.Color.Black
        Me.chkActivo.Location = New System.Drawing.Point(576, 126)
        Me.chkActivo.Margin = New System.Windows.Forms.Padding(4)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(74, 21)
        Me.chkActivo.TabIndex = 6
        Me.chkActivo.Text = "Activo"
        Me.chkActivo.UseVisualStyleBackColor = True
        '
        'chkProduccion
        '
        Me.chkProduccion.AutoSize = True
        Me.chkProduccion.Enabled = False
        Me.chkProduccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkProduccion.ForeColor = System.Drawing.Color.Black
        Me.chkProduccion.Location = New System.Drawing.Point(319, 132)
        Me.chkProduccion.Margin = New System.Windows.Forms.Padding(4)
        Me.chkProduccion.Name = "chkProduccion"
        Me.chkProduccion.Size = New System.Drawing.Size(167, 21)
        Me.chkProduccion.TabIndex = 7
        Me.chkProduccion.Text = "Para Producciones"
        Me.chkProduccion.UseVisualStyleBackColor = True
        '
        'lblFamilia
        '
        Me.lblFamilia.AutoSize = True
        Me.lblFamilia.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.lblFamilia.BackColor = System.Drawing.Color.White
        Me.lblFamilia.Location = New System.Drawing.Point(8, 58)
        Me.lblFamilia.Margin = New System.Windows.Forms.Padding(5)
        Me.lblFamilia.Name = "lblFamilia"
        Me.lblFamilia.Size = New System.Drawing.Size(66, 19)
        Me.lblFamilia.TabIndex = 4
        Me.lblFamilia.TabStop = False
        Me.lblFamilia.texto = "Familia"
        '
        'txtGrupo
        '
        Me.txtGrupo.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtGrupo.Location = New System.Drawing.Point(228, 20)
        Me.txtGrupo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtGrupo.MaxLength = 50
        Me.txtGrupo.Name = "txtGrupo"
        Me.txtGrupo.ReadOnly = True
        Me.txtGrupo.Size = New System.Drawing.Size(435, 22)
        Me.txtGrupo.TabIndex = 3
        '
        'txtCodigo
        '
        Me.txtCodigo.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(83, 21)
        Me.txtCodigo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCodigo.MaxLength = 4
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(68, 23)
        Me.txtCodigo.TabIndex = 1
        '
        'lblGrupo
        '
        Me.lblGrupo.AutoSize = True
        Me.lblGrupo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.lblGrupo.BackColor = System.Drawing.Color.White
        Me.lblGrupo.Location = New System.Drawing.Point(161, 21)
        Me.lblGrupo.Margin = New System.Windows.Forms.Padding(5)
        Me.lblGrupo.Name = "lblGrupo"
        Me.lblGrupo.Size = New System.Drawing.Size(59, 19)
        Me.lblGrupo.TabIndex = 2
        Me.lblGrupo.TabStop = False
        Me.lblGrupo.texto = "Grupo"
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.lblCodigo.BackColor = System.Drawing.Color.White
        Me.lblCodigo.Location = New System.Drawing.Point(8, 22)
        Me.lblCodigo.Margin = New System.Windows.Forms.Padding(5)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(66, 19)
        Me.lblCodigo.TabIndex = 0
        Me.lblCodigo.TabStop = False
        Me.lblCodigo.texto = "Código"
        '
        'm_subgrupo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(873, 545)
        Me.Controls.Add(Me.TabControl2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grupoDetalle)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "m_subgrupo"
        Me.Text = "Mantenimiento: GRUPOS"
        CType(Me.TabControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl2.ResumeLayout(False)
        Me.TabControlPanel4.ResumeLayout(False)
        CType(Me.datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlPanel2.ResumeLayout(False)
        Me.TabControlPanel2.PerformLayout()
        CType(Me.pb_foto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.grupoDetalle.ResumeLayout(False)
        Me.grupoDetalle.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grupoDetalle As System.Windows.Forms.GroupBox
    Friend WithEvents txtGrupo As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents chkActivo As System.Windows.Forms.CheckBox
    Friend WithEvents lblGrupo As mControles.etiqueta
    Friend WithEvents lblCodigo As mControles.etiqueta
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdEditar As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents cmdAñadir As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents cmdEliminar As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents cmdGrabar As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents cmdCancelar As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdCerrar As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents lblFamilia As mControles.etiqueta
    Friend WithEvents chkProduccion As System.Windows.Forms.CheckBox
    Friend WithEvents chkInventario As System.Windows.Forms.CheckBox
    Friend WithEvents cboFamilia As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ChkVentas As System.Windows.Forms.CheckBox
    Friend WithEvents TabControl2 As DevComponents.DotNetBar.TabControl
    Friend WithEvents TabControlPanel2 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents SimpleButton1 As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents cmdExaminar As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents pb_foto As System.Windows.Forms.PictureBox
    Friend WithEvents TabItem1 As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabControlPanel4 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents datos As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents tabreceta As DevComponents.DotNetBar.TabItem
    Friend WithEvents Etiqueta2 As mControles.etiqueta
    Friend WithEvents Etiqueta1 As mControles.etiqueta
    Friend WithEvents txtalto As System.Windows.Forms.TextBox
    Friend WithEvents txtancho As System.Windows.Forms.TextBox
    Friend WithEvents txtColor As System.Windows.Forms.TextBox
    Friend WithEvents Etiqueta6 As mControles.etiqueta
    Friend WithEvents Etiqueta5 As mControles.etiqueta
    Friend WithEvents Etiqueta4 As mControles.etiqueta
    Friend WithEvents lnkColor As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Etiqueta3 As mControles.etiqueta
    Friend WithEvents Etiqueta7 As mControles.etiqueta
    Friend WithEvents Etiqueta8 As mControles.etiqueta
    Friend WithEvents TxtColorfuente As System.Windows.Forms.TextBox
    Friend WithEvents Etiqueta9 As mControles.etiqueta
    Friend WithEvents txttamfuente As System.Windows.Forms.TextBox
    Friend WithEvents Etiqueta10 As mControles.etiqueta
    Friend WithEvents txtImpresora As System.Windows.Forms.TextBox
    Friend WithEvents cboGrupo As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Etiqueta11 As mControles.etiqueta
    Friend WithEvents ChkGerencia As System.Windows.Forms.CheckBox

End Class
