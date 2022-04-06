<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class u_usuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(u_usuarios))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.grupo = New System.Windows.Forms.GroupBox()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.dataUsuario = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.grupoDetalle = New System.Windows.Forms.GroupBox()
        Me.txtClave = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.cmdActualizar = New DevComponents.DotNetBar.ButtonX()
        Me.cmdEditar = New DevExpress.DXCore.Controls.XtraEditors.SimpleButton()
        Me.cmdAñadir = New DevExpress.DXCore.Controls.XtraEditors.SimpleButton()
        Me.cmdEliminar = New DevExpress.DXCore.Controls.XtraEditors.SimpleButton()
        Me.cmdGrabar = New DevExpress.DXCore.Controls.XtraEditors.SimpleButton()
        Me.cmdCancelar = New DevExpress.DXCore.Controls.XtraEditors.SimpleButton()
        Me.txtCuenta = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtUsuario = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.chkActivo = New System.Windows.Forms.CheckBox()
        Me.TabControl1 = New DevComponents.DotNetBar.TabControl()
        Me.TabControlPanel3 = New DevComponents.DotNetBar.TabControlPanel()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.txtalto = New System.Windows.Forms.TextBox()
        Me.txtancho = New System.Windows.Forms.TextBox()
        Me.SimpleButton1 = New DevExpress.DXCore.Controls.XtraEditors.SimpleButton()
        Me.cmdExaminar = New DevExpress.DXCore.Controls.XtraEditors.SimpleButton()
        Me.pb_foto = New System.Windows.Forms.PictureBox()
        Me.TabItem2 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel1 = New DevComponents.DotNetBar.TabControlPanel()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.cboMenu = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.dataSubMenu = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.Permisos = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel2 = New DevComponents.DotNetBar.TabControlPanel()
        Me.dataAlmacen = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.TabItem1 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.grupo.SuspendLayout()
        CType(Me.dataUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupoDetalle.SuspendLayout()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabControlPanel3.SuspendLayout()
        CType(Me.pb_foto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlPanel1.SuspendLayout()
        CType(Me.dataSubMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlPanel2.SuspendLayout()
        CType(Me.dataAlmacen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grupo
        '
        Me.grupo.Controls.Add(Me.LabelX4)
        Me.grupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupo.ForeColor = System.Drawing.Color.Maroon
        Me.grupo.Location = New System.Drawing.Point(12, 2)
        Me.grupo.Name = "grupo"
        Me.grupo.Size = New System.Drawing.Size(201, 38)
        Me.grupo.TabIndex = 96
        Me.grupo.TabStop = False
        '
        'LabelX4
        '
        Me.LabelX4.AutoSize = True
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.ForeColor = System.Drawing.Color.Maroon
        Me.LabelX4.Location = New System.Drawing.Point(34, 13)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(130, 17)
        Me.LabelX4.TabIndex = 9
        Me.LabelX4.Text = "Usuarios del Sistema"
        '
        'dataUsuario
        '
        Me.dataUsuario.AllowUserToAddRows = False
        Me.dataUsuario.AllowUserToDeleteRows = False
        Me.dataUsuario.AllowUserToResizeColumns = False
        Me.dataUsuario.AllowUserToResizeRows = False
        Me.dataUsuario.BackgroundColor = System.Drawing.Color.White
        Me.dataUsuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataUsuario.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dataUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataUsuario.DefaultCellStyle = DataGridViewCellStyle2
        Me.dataUsuario.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dataUsuario.Location = New System.Drawing.Point(12, 46)
        Me.dataUsuario.MultiSelect = False
        Me.dataUsuario.Name = "dataUsuario"
        Me.dataUsuario.ReadOnly = True
        Me.dataUsuario.RowHeadersVisible = False
        Me.dataUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dataUsuario.SelectAllSignVisible = False
        Me.dataUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataUsuario.ShowEditingIcon = False
        Me.dataUsuario.Size = New System.Drawing.Size(201, 414)
        Me.dataUsuario.TabIndex = 97
        '
        'grupoDetalle
        '
        Me.grupoDetalle.Controls.Add(Me.txtClave)
        Me.grupoDetalle.Controls.Add(Me.cmdActualizar)
        Me.grupoDetalle.Controls.Add(Me.cmdEditar)
        Me.grupoDetalle.Controls.Add(Me.cmdAñadir)
        Me.grupoDetalle.Controls.Add(Me.cmdEliminar)
        Me.grupoDetalle.Controls.Add(Me.cmdGrabar)
        Me.grupoDetalle.Controls.Add(Me.cmdCancelar)
        Me.grupoDetalle.Controls.Add(Me.txtCuenta)
        Me.grupoDetalle.Controls.Add(Me.txtUsuario)
        Me.grupoDetalle.Controls.Add(Me.LabelX3)
        Me.grupoDetalle.Controls.Add(Me.LabelX1)
        Me.grupoDetalle.Controls.Add(Me.LabelX2)
        Me.grupoDetalle.Controls.Add(Me.chkActivo)
        Me.grupoDetalle.Location = New System.Drawing.Point(234, 2)
        Me.grupoDetalle.Name = "grupoDetalle"
        Me.grupoDetalle.Size = New System.Drawing.Size(437, 153)
        Me.grupoDetalle.TabIndex = 98
        Me.grupoDetalle.TabStop = False
        '
        'txtClave
        '
        Me.txtClave.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.txtClave.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtClave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClave.Location = New System.Drawing.Point(92, 76)
        Me.txtClave.Name = "txtClave"
        Me.txtClave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtClave.ReadOnly = True
        Me.txtClave.Size = New System.Drawing.Size(171, 14)
        Me.txtClave.TabIndex = 45
        '
        'cmdActualizar
        '
        Me.cmdActualizar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdActualizar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdActualizar.Image = Global.cefe.My.Resources.Resources.ok22
        Me.cmdActualizar.Location = New System.Drawing.Point(14, 112)
        Me.cmdActualizar.Name = "cmdActualizar"
        Me.cmdActualizar.Size = New System.Drawing.Size(88, 34)
        Me.cmdActualizar.TabIndex = 44
        Me.cmdActualizar.Text = "Actualizar Permisos"
        '
        'cmdEditar
        '
        Me.cmdEditar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmdEditar.Appearance.Options.UseFont = True
        Me.cmdEditar.Image = Global.cefe.My.Resources.Resources.m_editar
        Me.cmdEditar.ImageLocation = DevExpress.DXCore.Controls.XtraEditors.ImageLocation.TopCenter
        Me.cmdEditar.Location = New System.Drawing.Point(374, 102)
        Me.cmdEditar.LookAndFeel.SkinName = "iMaginary"
        Me.cmdEditar.Name = "cmdEditar"
        Me.cmdEditar.Size = New System.Drawing.Size(56, 44)
        Me.cmdEditar.TabIndex = 41
        Me.cmdEditar.Text = "Editar"
        '
        'cmdAñadir
        '
        Me.cmdAñadir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmdAñadir.Appearance.Options.UseFont = True
        Me.cmdAñadir.Image = Global.cefe.My.Resources.Resources.m_añadir
        Me.cmdAñadir.ImageLocation = DevExpress.DXCore.Controls.XtraEditors.ImageLocation.TopCenter
        Me.cmdAñadir.Location = New System.Drawing.Point(128, 102)
        Me.cmdAñadir.LookAndFeel.SkinName = "iMaginary"
        Me.cmdAñadir.Name = "cmdAñadir"
        Me.cmdAñadir.Size = New System.Drawing.Size(56, 44)
        Me.cmdAñadir.TabIndex = 40
        Me.cmdAñadir.Text = "Añadir"
        '
        'cmdEliminar
        '
        Me.cmdEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmdEliminar.Appearance.Options.UseFont = True
        Me.cmdEliminar.Image = Global.cefe.My.Resources.Resources.m_borrar
        Me.cmdEliminar.ImageLocation = DevExpress.DXCore.Controls.XtraEditors.ImageLocation.TopCenter
        Me.cmdEliminar.Location = New System.Drawing.Point(312, 102)
        Me.cmdEliminar.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(56, 44)
        Me.cmdEliminar.TabIndex = 43
        Me.cmdEliminar.Text = "Eliminar"
        '
        'cmdGrabar
        '
        Me.cmdGrabar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmdGrabar.Appearance.Options.UseFont = True
        Me.cmdGrabar.Enabled = False
        Me.cmdGrabar.Image = Global.cefe.My.Resources.Resources.m_grabar
        Me.cmdGrabar.ImageLocation = DevExpress.DXCore.Controls.XtraEditors.ImageLocation.TopCenter
        Me.cmdGrabar.Location = New System.Drawing.Point(190, 102)
        Me.cmdGrabar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdGrabar.Name = "cmdGrabar"
        Me.cmdGrabar.Size = New System.Drawing.Size(56, 44)
        Me.cmdGrabar.TabIndex = 39
        Me.cmdGrabar.Text = "Grabar"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.Enabled = False
        Me.cmdCancelar.Image = Global.cefe.My.Resources.Resources.m_cancelar
        Me.cmdCancelar.ImageLocation = DevExpress.DXCore.Controls.XtraEditors.ImageLocation.TopCenter
        Me.cmdCancelar.Location = New System.Drawing.Point(250, 102)
        Me.cmdCancelar.LookAndFeel.SkinName = "Black"
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(56, 44)
        Me.cmdCancelar.TabIndex = 42
        Me.cmdCancelar.Text = "Cancelar"
        '
        'txtCuenta
        '
        Me.txtCuenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.txtCuenta.Border.Class = "TextBoxBorder"
        Me.txtCuenta.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuenta.Location = New System.Drawing.Point(92, 44)
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.ReadOnly = True
        Me.txtCuenta.Size = New System.Drawing.Size(171, 21)
        Me.txtCuenta.TabIndex = 10
        '
        'txtUsuario
        '
        Me.txtUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.txtUsuario.Border.Class = "TextBoxBorder"
        Me.txtUsuario.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.Location = New System.Drawing.Point(146, 19)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.ReadOnly = True
        Me.txtUsuario.Size = New System.Drawing.Size(275, 21)
        Me.txtUsuario.TabIndex = 9
        '
        'LabelX3
        '
        Me.LabelX3.AutoSize = True
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LabelX3.Location = New System.Drawing.Point(14, 76)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(72, 17)
        Me.LabelX3.TabIndex = 8
        Me.LabelX3.Text = "Contraseña"
        '
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LabelX1.Location = New System.Drawing.Point(14, 48)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(46, 17)
        Me.LabelX1.TabIndex = 7
        Me.LabelX1.Text = "Cuenta"
        '
        'LabelX2
        '
        Me.LabelX2.AutoSize = True
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LabelX2.Location = New System.Drawing.Point(14, 21)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(126, 17)
        Me.LabelX2.TabIndex = 6
        Me.LabelX2.Text = "Apellidos y Nombres"
        '
        'chkActivo
        '
        Me.chkActivo.AutoSize = True
        Me.chkActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkActivo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.chkActivo.Location = New System.Drawing.Point(370, 76)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(63, 19)
        Me.chkActivo.TabIndex = 2
        Me.chkActivo.Text = "Activo"
        Me.chkActivo.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.BackColor = System.Drawing.Color.Transparent
        Me.TabControl1.CanReorderTabs = True
        Me.TabControl1.Controls.Add(Me.TabControlPanel1)
        Me.TabControl1.Controls.Add(Me.TabControlPanel3)
        Me.TabControl1.Controls.Add(Me.TabControlPanel2)
        Me.TabControl1.ForeColor = System.Drawing.Color.Transparent
        Me.TabControl1.Location = New System.Drawing.Point(233, 161)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TabControl1.SelectedTabIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(445, 296)
        Me.TabControl1.TabIndex = 102
        Me.TabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
        Me.TabControl1.Tabs.Add(Me.Permisos)
        Me.TabControl1.Tabs.Add(Me.TabItem1)
        Me.TabControl1.Tabs.Add(Me.TabItem2)
        Me.TabControl1.Text = "TabControl1"
        '
        'TabControlPanel3
        '
        Me.TabControlPanel3.Controls.Add(Me.LabelX7)
        Me.TabControlPanel3.Controls.Add(Me.LabelX6)
        Me.TabControlPanel3.Controls.Add(Me.txtalto)
        Me.TabControlPanel3.Controls.Add(Me.txtancho)
        Me.TabControlPanel3.Controls.Add(Me.SimpleButton1)
        Me.TabControlPanel3.Controls.Add(Me.cmdExaminar)
        Me.TabControlPanel3.Controls.Add(Me.pb_foto)
        Me.TabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel3.Location = New System.Drawing.Point(0, 26)
        Me.TabControlPanel3.Name = "TabControlPanel3"
        Me.TabControlPanel3.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel3.Size = New System.Drawing.Size(445, 270)
        Me.TabControlPanel3.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.TabControlPanel3.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel3.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.TabControlPanel3.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel3.Style.GradientAngle = 90
        Me.TabControlPanel3.TabIndex = 3
        Me.TabControlPanel3.TabItem = Me.TabItem2
        '
        'LabelX7
        '
        Me.LabelX7.AutoSize = True
        Me.LabelX7.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LabelX7.Location = New System.Drawing.Point(337, 214)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(26, 17)
        Me.LabelX7.TabIndex = 159
        Me.LabelX7.Text = "Alto"
        '
        'LabelX6
        '
        Me.LabelX6.AutoSize = True
        Me.LabelX6.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LabelX6.Location = New System.Drawing.Point(337, 188)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(41, 17)
        Me.LabelX6.TabIndex = 158
        Me.LabelX6.Text = "Ancho"
        '
        'txtalto
        '
        Me.txtalto.Location = New System.Drawing.Point(379, 213)
        Me.txtalto.Name = "txtalto"
        Me.txtalto.Size = New System.Drawing.Size(63, 20)
        Me.txtalto.TabIndex = 157
        '
        'txtancho
        '
        Me.txtancho.Location = New System.Drawing.Point(378, 187)
        Me.txtancho.Name = "txtancho"
        Me.txtancho.Size = New System.Drawing.Size(63, 20)
        Me.txtancho.TabIndex = 156
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.ImageLocation = DevExpress.DXCore.Controls.XtraEditors.ImageLocation.TopCenter
        Me.SimpleButton1.Location = New System.Drawing.Point(4, 13)
        Me.SimpleButton1.LookAndFeel.SkinName = "iMaginary"
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(31, 32)
        Me.SimpleButton1.TabIndex = 153
        '
        'cmdExaminar
        '
        Me.cmdExaminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmdExaminar.Appearance.Options.UseFont = True
        Me.cmdExaminar.Image = Global.cefe.My.Resources.Resources.c_buscarD
        Me.cmdExaminar.ImageLocation = DevExpress.DXCore.Controls.XtraEditors.ImageLocation.TopCenter
        Me.cmdExaminar.Location = New System.Drawing.Point(35, 13)
        Me.cmdExaminar.LookAndFeel.SkinName = "iMaginary"
        Me.cmdExaminar.Name = "cmdExaminar"
        Me.cmdExaminar.Size = New System.Drawing.Size(31, 32)
        Me.cmdExaminar.TabIndex = 152
        Me.cmdExaminar.Text = "Examinar"
        '
        'pb_foto
        '
        Me.pb_foto.Location = New System.Drawing.Point(69, 9)
        Me.pb_foto.Name = "pb_foto"
        Me.pb_foto.Size = New System.Drawing.Size(266, 245)
        Me.pb_foto.TabIndex = 1
        Me.pb_foto.TabStop = False
        '
        'TabItem2
        '
        Me.TabItem2.AttachedControl = Me.TabControlPanel3
        Me.TabItem2.Name = "TabItem2"
        Me.TabItem2.Text = "Imagen"
        '
        'TabControlPanel1
        '
        Me.TabControlPanel1.Controls.Add(Me.LabelX5)
        Me.TabControlPanel1.Controls.Add(Me.cboMenu)
        Me.TabControlPanel1.Controls.Add(Me.dataSubMenu)
        Me.TabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel1.Location = New System.Drawing.Point(0, 26)
        Me.TabControlPanel1.Name = "TabControlPanel1"
        Me.TabControlPanel1.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel1.Size = New System.Drawing.Size(445, 270)
        Me.TabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.Transparent
        Me.TabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.Transparent
        Me.TabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel1.Style.BorderColor.Color = System.Drawing.SystemColors.ControlDark
        Me.TabControlPanel1.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel1.Style.GradientAngle = -90
        Me.TabControlPanel1.TabIndex = 1
        Me.TabControlPanel1.TabItem = Me.Permisos
        '
        'LabelX5
        '
        Me.LabelX5.AutoSize = True
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LabelX5.Location = New System.Drawing.Point(15, 4)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(125, 17)
        Me.LabelX5.TabIndex = 104
        Me.LabelX5.Text = "Permisos de Acceso"
        '
        'cboMenu
        '
        Me.cboMenu.DisplayMember = "Text"
        Me.cboMenu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMenu.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMenu.ForeColor = System.Drawing.Color.Black
        Me.cboMenu.FormattingEnabled = True
        Me.cboMenu.ItemHeight = 16
        Me.cboMenu.Location = New System.Drawing.Point(145, 2)
        Me.cboMenu.Name = "cboMenu"
        Me.cboMenu.Size = New System.Drawing.Size(285, 22)
        Me.cboMenu.TabIndex = 103
        Me.cboMenu.WatermarkColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'dataSubMenu
        '
        Me.dataSubMenu.AllowUserToAddRows = False
        Me.dataSubMenu.AllowUserToDeleteRows = False
        Me.dataSubMenu.AllowUserToResizeColumns = False
        Me.dataSubMenu.AllowUserToResizeRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Bisque
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.dataSubMenu.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dataSubMenu.BackgroundColor = System.Drawing.Color.Snow
        Me.dataSubMenu.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dataSubMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataSubMenu.Cursor = System.Windows.Forms.Cursors.Arrow
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataSubMenu.DefaultCellStyle = DataGridViewCellStyle4
        Me.dataSubMenu.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dataSubMenu.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dataSubMenu.Location = New System.Drawing.Point(1, 27)
        Me.dataSubMenu.MultiSelect = False
        Me.dataSubMenu.Name = "dataSubMenu"
        Me.dataSubMenu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dataSubMenu.SelectAllSignVisible = False
        Me.dataSubMenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dataSubMenu.ShowEditingIcon = False
        Me.dataSubMenu.Size = New System.Drawing.Size(443, 242)
        Me.dataSubMenu.TabIndex = 102
        '
        'Permisos
        '
        Me.Permisos.AttachedControl = Me.TabControlPanel1
        Me.Permisos.BackColor = System.Drawing.Color.Transparent
        Me.Permisos.BackColor2 = System.Drawing.Color.Transparent
        Me.Permisos.Name = "Permisos"
        Me.Permisos.Text = "Permisos"
        '
        'TabControlPanel2
        '
        Me.TabControlPanel2.Controls.Add(Me.dataAlmacen)
        Me.TabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel2.Location = New System.Drawing.Point(0, 26)
        Me.TabControlPanel2.Name = "TabControlPanel2"
        Me.TabControlPanel2.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel2.Size = New System.Drawing.Size(445, 270)
        Me.TabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.TabControlPanel2.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.TabControlPanel2.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel2.Style.GradientAngle = 90
        Me.TabControlPanel2.TabIndex = 2
        Me.TabControlPanel2.TabItem = Me.TabItem1
        '
        'dataAlmacen
        '
        Me.dataAlmacen.AllowUserToAddRows = False
        Me.dataAlmacen.AllowUserToDeleteRows = False
        Me.dataAlmacen.AllowUserToResizeColumns = False
        Me.dataAlmacen.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.dataAlmacen.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dataAlmacen.BackgroundColor = System.Drawing.Color.White
        Me.dataAlmacen.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dataAlmacen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataAlmacen.Cursor = System.Windows.Forms.Cursors.Arrow
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataAlmacen.DefaultCellStyle = DataGridViewCellStyle6
        Me.dataAlmacen.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dataAlmacen.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dataAlmacen.Location = New System.Drawing.Point(1, 0)
        Me.dataAlmacen.MultiSelect = False
        Me.dataAlmacen.Name = "dataAlmacen"
        Me.dataAlmacen.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dataAlmacen.SelectAllSignVisible = False
        Me.dataAlmacen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dataAlmacen.ShowEditingIcon = False
        Me.dataAlmacen.Size = New System.Drawing.Size(443, 269)
        Me.dataAlmacen.TabIndex = 103
        '
        'TabItem1
        '
        Me.TabItem1.Name = "TabItem1"
        Me.TabItem1.Text = "Almacenes"
        '
        'u_usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(691, 472)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.grupoDetalle)
        Me.Controls.Add(Me.dataUsuario)
        Me.Controls.Add(Me.grupo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "u_usuarios"
        Me.Text = "Utilidades - USUARIOS DEL SISTEMA"
        Me.grupo.ResumeLayout(False)
        Me.grupo.PerformLayout()
        CType(Me.dataUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupoDetalle.ResumeLayout(False)
        Me.grupoDetalle.PerformLayout()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabControlPanel3.ResumeLayout(False)
        Me.TabControlPanel3.PerformLayout()
        CType(Me.pb_foto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlPanel1.ResumeLayout(False)
        Me.TabControlPanel1.PerformLayout()
        CType(Me.dataSubMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlPanel2.ResumeLayout(False)
        CType(Me.dataAlmacen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grupo As System.Windows.Forms.GroupBox
    Friend WithEvents dataUsuario As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents grupoDetalle As System.Windows.Forms.GroupBox
    Friend WithEvents chkActivo As System.Windows.Forms.CheckBox
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtUsuario As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtCuenta As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtClave As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents cmdEditar As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents cmdAñadir As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents cmdEliminar As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents cmdGrabar As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents cmdCancelar As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents cmdActualizar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TabControl1 As DevComponents.DotNetBar.TabControl
    Friend WithEvents TabControlPanel1 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cboMenu As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents dataSubMenu As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents Permisos As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabControlPanel2 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabItem1 As DevComponents.DotNetBar.TabItem
    Friend WithEvents dataAlmacen As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents TabControlPanel3 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabItem2 As DevComponents.DotNetBar.TabItem
    Friend WithEvents pb_foto As System.Windows.Forms.PictureBox
    Friend WithEvents SimpleButton1 As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents cmdExaminar As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents txtalto As System.Windows.Forms.TextBox
    Friend WithEvents txtancho As System.Windows.Forms.TextBox
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX

End Class
