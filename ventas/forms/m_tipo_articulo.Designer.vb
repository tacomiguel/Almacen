<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class m_tipo_articulo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(m_tipo_articulo))
        Me.tbCombo = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControl2 = New DevComponents.DotNetBar.TabControl()
        Me.TabControlPanel4 = New DevComponents.DotNetBar.TabControlPanel()
        Me.datos = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.tabreceta = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel2 = New DevComponents.DotNetBar.TabControlPanel()
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
        Me.chkCombo = New System.Windows.Forms.CheckBox()
        Me.chkProduccion = New System.Windows.Forms.CheckBox()
        Me.txtTipo = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.chkActivo = New System.Windows.Forms.CheckBox()
        Me.lblTipo = New mControles.etiqueta()
        Me.lblCodigo = New mControles.etiqueta()
        Me.chkProTerminado = New System.Windows.Forms.CheckBox()
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
        'tbCombo
        '
        Me.tbCombo.Name = "tbCombo"
        Me.tbCombo.Text = "T"
        Me.tbCombo.Visible = False
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
        Me.TabControl2.Location = New System.Drawing.Point(24, 15)
        Me.TabControl2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TabControl2.SelectedTabIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(621, 335)
        Me.TabControl2.Style = DevComponents.DotNetBar.eTabStripStyle.VS2005Document
        Me.TabControl2.TabIndex = 145
        Me.TabControl2.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
        Me.TabControl2.Tabs.Add(Me.tabreceta)
        Me.TabControl2.Tabs.Add(Me.TabItem1)
        '
        'TabControlPanel4
        '
        Me.TabControlPanel4.Controls.Add(Me.datos)
        Me.TabControlPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel4.Location = New System.Drawing.Point(0, 26)
        Me.TabControlPanel4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabControlPanel4.Name = "TabControlPanel4"
        Me.TabControlPanel4.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel4.Size = New System.Drawing.Size(621, 309)
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
        Me.datos.Location = New System.Drawing.Point(5, -4)
        Me.datos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.datos.MultiSelect = False
        Me.datos.Name = "datos"
        Me.datos.ReadOnly = True
        Me.datos.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.datos.SelectAllSignVisible = False
        Me.datos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datos.ShowEditingIcon = False
        Me.datos.Size = New System.Drawing.Size(612, 302)
        Me.datos.TabIndex = 1
        '
        'tabreceta
        '
        Me.tabreceta.AttachedControl = Me.TabControlPanel4
        Me.tabreceta.Icon = CType(resources.GetObject("tabreceta.Icon"), System.Drawing.Icon)
        Me.tabreceta.Name = "tabreceta"
        Me.tabreceta.Text = "Tipo Articulo"
        '
        'TabControlPanel2
        '
        Me.TabControlPanel2.Controls.Add(Me.SimpleButton1)
        Me.TabControlPanel2.Controls.Add(Me.cmdExaminar)
        Me.TabControlPanel2.Controls.Add(Me.pb_foto)
        Me.TabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel2.Location = New System.Drawing.Point(0, 26)
        Me.TabControlPanel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabControlPanel2.Name = "TabControlPanel2"
        Me.TabControlPanel2.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel2.Size = New System.Drawing.Size(621, 309)
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
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.ImageLocation = DevExpress.DXCore.Controls.XtraEditors.ImageLocation.TopCenter
        Me.SimpleButton1.Location = New System.Drawing.Point(520, 0)
        Me.SimpleButton1.LookAndFeel.SkinName = "iMaginary"
        Me.SimpleButton1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
        Me.cmdExaminar.Location = New System.Drawing.Point(569, 0)
        Me.cmdExaminar.LookAndFeel.SkinName = "iMaginary"
        Me.cmdExaminar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdExaminar.Name = "cmdExaminar"
        Me.cmdExaminar.Size = New System.Drawing.Size(41, 39)
        Me.cmdExaminar.TabIndex = 149
        Me.cmdExaminar.Text = "Examinar"
        '
        'pb_foto
        '
        Me.pb_foto.Location = New System.Drawing.Point(143, -1)
        Me.pb_foto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pb_foto.Name = "pb_foto"
        Me.pb_foto.Size = New System.Drawing.Size(355, 303)
        Me.pb_foto.TabIndex = 0
        Me.pb_foto.TabStop = False
        '
        'TabItem1
        '
        Me.TabItem1.AttachedControl = Me.TabControlPanel2
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
        Me.GroupBox2.Location = New System.Drawing.Point(660, 6)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(99, 327)
        Me.GroupBox2.TabIndex = 1
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
        Me.cmdEditar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
        Me.cmdAñadir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
        Me.cmdEliminar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
        Me.cmdGrabar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdGrabar.Name = "cmdGrabar"
        Me.cmdGrabar.Size = New System.Drawing.Size(83, 55)
        Me.cmdGrabar.TabIndex = 1
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
        Me.cmdCancelar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(83, 55)
        Me.cmdCancelar.TabIndex = 37
        Me.cmdCancelar.Text = "Cancelar"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdCerrar)
        Me.GroupBox1.Location = New System.Drawing.Point(660, 358)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(99, 79)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        '
        'cmdCerrar
        '
        Me.cmdCerrar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmdCerrar.Appearance.Options.UseFont = True
        Me.cmdCerrar.Image = Global.cefe.My.Resources.Resources.CLOSE22
        Me.cmdCerrar.ImageLocation = DevExpress.DXCore.Controls.XtraEditors.ImageLocation.TopCenter
        Me.cmdCerrar.Location = New System.Drawing.Point(8, 15)
        Me.cmdCerrar.LookAndFeel.SkinName = "iMaginary"
        Me.cmdCerrar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdCerrar.Name = "cmdCerrar"
        Me.cmdCerrar.Size = New System.Drawing.Size(83, 55)
        Me.cmdCerrar.TabIndex = 40
        Me.cmdCerrar.Text = "Cerrar"
        '
        'grupoDetalle
        '
        Me.grupoDetalle.Controls.Add(Me.chkProTerminado)
        Me.grupoDetalle.Controls.Add(Me.chkCombo)
        Me.grupoDetalle.Controls.Add(Me.chkProduccion)
        Me.grupoDetalle.Controls.Add(Me.txtTipo)
        Me.grupoDetalle.Controls.Add(Me.txtCodigo)
        Me.grupoDetalle.Controls.Add(Me.chkActivo)
        Me.grupoDetalle.Controls.Add(Me.lblTipo)
        Me.grupoDetalle.Controls.Add(Me.lblCodigo)
        Me.grupoDetalle.Location = New System.Drawing.Point(16, 354)
        Me.grupoDetalle.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grupoDetalle.Name = "grupoDetalle"
        Me.grupoDetalle.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grupoDetalle.Size = New System.Drawing.Size(636, 82)
        Me.grupoDetalle.TabIndex = 2
        Me.grupoDetalle.TabStop = False
        '
        'chkCombo
        '
        Me.chkCombo.AutoSize = True
        Me.chkCombo.Enabled = False
        Me.chkCombo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCombo.Location = New System.Drawing.Point(395, 54)
        Me.chkCombo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkCombo.Name = "chkCombo"
        Me.chkCombo.Size = New System.Drawing.Size(126, 21)
        Me.chkCombo.TabIndex = 4
        Me.chkCombo.Text = "para Combo?"
        Me.chkCombo.UseVisualStyleBackColor = True
        '
        'chkProduccion
        '
        Me.chkProduccion.AutoSize = True
        Me.chkProduccion.Enabled = False
        Me.chkProduccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkProduccion.Location = New System.Drawing.Point(212, 54)
        Me.chkProduccion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkProduccion.Name = "chkProduccion"
        Me.chkProduccion.Size = New System.Drawing.Size(158, 21)
        Me.chkProduccion.TabIndex = 3
        Me.chkProduccion.Text = "para Producción?"
        Me.chkProduccion.UseVisualStyleBackColor = True
        '
        'txtTipo
        '
        Me.txtTipo.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTipo.Location = New System.Drawing.Point(315, 18)
        Me.txtTipo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTipo.MaxLength = 30
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.ReadOnly = True
        Me.txtTipo.Size = New System.Drawing.Size(305, 22)
        Me.txtTipo.TabIndex = 1
        '
        'txtCodigo
        '
        Me.txtCodigo.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(85, 18)
        Me.txtCodigo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCodigo.MaxLength = 2
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(53, 23)
        Me.txtCodigo.TabIndex = 0
        '
        'chkActivo
        '
        Me.chkActivo.AutoSize = True
        Me.chkActivo.Enabled = False
        Me.chkActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkActivo.Location = New System.Drawing.Point(543, 54)
        Me.chkActivo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(74, 21)
        Me.chkActivo.TabIndex = 2
        Me.chkActivo.Text = "Activo"
        Me.chkActivo.UseVisualStyleBackColor = True
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.lblTipo.BackColor = System.Drawing.Color.White
        Me.lblTipo.Location = New System.Drawing.Point(167, 20)
        Me.lblTipo.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(130, 19)
        Me.lblTipo.TabIndex = 2
        Me.lblTipo.TabStop = False
        Me.lblTipo.texto = "Tipo de Artículo"
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.lblCodigo.BackColor = System.Drawing.Color.White
        Me.lblCodigo.Location = New System.Drawing.Point(12, 20)
        Me.lblCodigo.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(66, 19)
        Me.lblCodigo.TabIndex = 0
        Me.lblCodigo.TabStop = False
        Me.lblCodigo.texto = "Código"
        '
        'chkProTerminado
        '
        Me.chkProTerminado.AutoSize = True
        Me.chkProTerminado.Enabled = False
        Me.chkProTerminado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkProTerminado.Location = New System.Drawing.Point(13, 54)
        Me.chkProTerminado.Margin = New System.Windows.Forms.Padding(4)
        Me.chkProTerminado.Name = "chkProTerminado"
        Me.chkProTerminado.Size = New System.Drawing.Size(177, 21)
        Me.chkProTerminado.TabIndex = 5
        Me.chkProTerminado.Text = "Producto Terminado"
        Me.chkProTerminado.UseVisualStyleBackColor = True
        '
        'm_tipo_articulo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(769, 448)
        Me.Controls.Add(Me.TabControl2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grupoDetalle)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "m_tipo_articulo"
        Me.Text = "Mantenimiento: TIPO DE ARTICULO"
        CType(Me.TabControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl2.ResumeLayout(False)
        Me.TabControlPanel4.ResumeLayout(False)
        CType(Me.datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlPanel2.ResumeLayout(False)
        CType(Me.pb_foto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.grupoDetalle.ResumeLayout(False)
        Me.grupoDetalle.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdEditar As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents cmdAñadir As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents cmdEliminar As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents cmdGrabar As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents cmdCancelar As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdCerrar As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents grupoDetalle As System.Windows.Forms.GroupBox
    Friend WithEvents txtTipo As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents chkActivo As System.Windows.Forms.CheckBox
    Friend WithEvents lblTipo As mControles.etiqueta
    Friend WithEvents lblCodigo As mControles.etiqueta
    Friend WithEvents chkProduccion As System.Windows.Forms.CheckBox
    Friend WithEvents chkCombo As System.Windows.Forms.CheckBox
    Friend WithEvents TabControl2 As DevComponents.DotNetBar.TabControl
    Friend WithEvents TabControlPanel4 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents datos As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents tabreceta As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabControlPanel2 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents SimpleButton1 As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents cmdExaminar As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents pb_foto As System.Windows.Forms.PictureBox
    Friend WithEvents TabItem1 As DevComponents.DotNetBar.TabItem
    Friend WithEvents tbCombo As DevComponents.DotNetBar.TabItem
    Friend WithEvents chkProTerminado As System.Windows.Forms.CheckBox

End Class
