<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class m_almacen
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(m_almacen))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdCerrar = New DevExpress.DXCore.Controls.XtraEditors.SimpleButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmdEditar = New DevExpress.DXCore.Controls.XtraEditors.SimpleButton()
        Me.cmdAñadir = New DevExpress.DXCore.Controls.XtraEditors.SimpleButton()
        Me.cmdEliminar = New DevExpress.DXCore.Controls.XtraEditors.SimpleButton()
        Me.cmdGrabar = New DevExpress.DXCore.Controls.XtraEditors.SimpleButton()
        Me.cmdCancelar = New DevExpress.DXCore.Controls.XtraEditors.SimpleButton()
        Me.grupoDetalle = New System.Windows.Forms.GroupBox()
        Me.txtCatalogo = New System.Windows.Forms.TextBox()
        Me.lblCatalogo = New DevComponents.DotNetBar.LabelX()
        Me.chkDestino = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.chkOrigen = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.chkIdeales = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.chkCatalogo = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.chkPrincipal = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.chkVentas = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.chkCompras = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.lblCodigo = New DevComponents.DotNetBar.LabelX()
        Me.lblAlmacen = New DevComponents.DotNetBar.LabelX()
        Me.chkInvDiario = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.chkActivo = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.chkProduccion = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.txtAlmacen = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.TabItem2 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.datos = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.txtArea = New System.Windows.Forms.TextBox()
        Me.LblNomAlmacen = New DevComponents.DotNetBar.LabelX()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataArea = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.grupoDetalle.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataArea, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdCerrar)
        Me.GroupBox1.Location = New System.Drawing.Point(984, 389)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(99, 79)
        Me.GroupBox1.TabIndex = 7
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmdEditar)
        Me.GroupBox2.Controls.Add(Me.cmdAñadir)
        Me.GroupBox2.Controls.Add(Me.cmdEliminar)
        Me.GroupBox2.Controls.Add(Me.cmdGrabar)
        Me.GroupBox2.Controls.Add(Me.cmdCancelar)
        Me.GroupBox2.Location = New System.Drawing.Point(984, 7)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(99, 327)
        Me.GroupBox2.TabIndex = 6
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
        Me.cmdCancelar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(83, 55)
        Me.cmdCancelar.TabIndex = 37
        Me.cmdCancelar.Text = "Cancelar"
        '
        'grupoDetalle
        '
        Me.grupoDetalle.Controls.Add(Me.txtCatalogo)
        Me.grupoDetalle.Controls.Add(Me.lblCatalogo)
        Me.grupoDetalle.Controls.Add(Me.chkDestino)
        Me.grupoDetalle.Controls.Add(Me.chkOrigen)
        Me.grupoDetalle.Controls.Add(Me.chkIdeales)
        Me.grupoDetalle.Controls.Add(Me.chkCatalogo)
        Me.grupoDetalle.Controls.Add(Me.chkPrincipal)
        Me.grupoDetalle.Controls.Add(Me.chkVentas)
        Me.grupoDetalle.Controls.Add(Me.chkCompras)
        Me.grupoDetalle.Controls.Add(Me.lblCodigo)
        Me.grupoDetalle.Controls.Add(Me.lblAlmacen)
        Me.grupoDetalle.Controls.Add(Me.chkInvDiario)
        Me.grupoDetalle.Controls.Add(Me.chkActivo)
        Me.grupoDetalle.Controls.Add(Me.chkProduccion)
        Me.grupoDetalle.Controls.Add(Me.txtAlmacen)
        Me.grupoDetalle.Controls.Add(Me.txtCodigo)
        Me.grupoDetalle.Location = New System.Drawing.Point(3, 417)
        Me.grupoDetalle.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grupoDetalle.Name = "grupoDetalle"
        Me.grupoDetalle.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grupoDetalle.Size = New System.Drawing.Size(960, 105)
        Me.grupoDetalle.TabIndex = 5
        Me.grupoDetalle.TabStop = False
        '
        'txtCatalogo
        '
        Me.txtCatalogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCatalogo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCatalogo.Location = New System.Drawing.Point(741, 74)
        Me.txtCatalogo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCatalogo.MaxLength = 4
        Me.txtCatalogo.Name = "txtCatalogo"
        Me.txtCatalogo.ReadOnly = True
        Me.txtCatalogo.Size = New System.Drawing.Size(67, 23)
        Me.txtCatalogo.TabIndex = 44
        '
        'lblCatalogo
        '
        Me.lblCatalogo.AutoSize = True
        '
        '
        '
        Me.lblCatalogo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblCatalogo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCatalogo.ForeColor = System.Drawing.Color.Black
        Me.lblCatalogo.Location = New System.Drawing.Point(509, 75)
        Me.lblCatalogo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblCatalogo.Name = "lblCatalogo"
        Me.lblCatalogo.Size = New System.Drawing.Size(215, 19)
        Me.lblCatalogo.TabIndex = 43
        Me.lblCatalogo.Text = "Recupera Catálogo de Almacén"
        '
        'chkDestino
        '
        Me.chkDestino.AutoSize = True
        '
        '
        '
        Me.chkDestino.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chkDestino.Checked = True
        Me.chkDestino.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDestino.CheckValue = "Y"
        Me.chkDestino.Enabled = False
        Me.chkDestino.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDestino.Location = New System.Drawing.Point(239, 75)
        Me.chkDestino.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkDestino.Name = "chkDestino"
        Me.chkDestino.Size = New System.Drawing.Size(183, 18)
        Me.chkDestino.TabIndex = 42
        Me.chkDestino.Text = "Destino de Transferencias"
        Me.chkDestino.TextColor = System.Drawing.Color.Black
        '
        'chkOrigen
        '
        Me.chkOrigen.AutoSize = True
        '
        '
        '
        Me.chkOrigen.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chkOrigen.Checked = True
        Me.chkOrigen.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkOrigen.CheckValue = "Y"
        Me.chkOrigen.Enabled = False
        Me.chkOrigen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkOrigen.Location = New System.Drawing.Point(13, 75)
        Me.chkOrigen.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkOrigen.Name = "chkOrigen"
        Me.chkOrigen.Size = New System.Drawing.Size(177, 18)
        Me.chkOrigen.TabIndex = 41
        Me.chkOrigen.Text = "Origen de Transferencias"
        Me.chkOrigen.TextColor = System.Drawing.Color.Black
        '
        'chkIdeales
        '
        Me.chkIdeales.AutoSize = True
        '
        '
        '
        Me.chkIdeales.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chkIdeales.Checked = True
        Me.chkIdeales.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkIdeales.CheckValue = "Y"
        Me.chkIdeales.Enabled = False
        Me.chkIdeales.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkIdeales.Location = New System.Drawing.Point(825, 49)
        Me.chkIdeales.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkIdeales.Name = "chkIdeales"
        Me.chkIdeales.Size = New System.Drawing.Size(113, 18)
        Me.chkIdeales.TabIndex = 40
        Me.chkIdeales.Text = "Tiene Ideales?"
        Me.chkIdeales.TextColor = System.Drawing.Color.Black
        '
        'chkCatalogo
        '
        Me.chkCatalogo.AutoSize = True
        '
        '
        '
        Me.chkCatalogo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chkCatalogo.Checked = True
        Me.chkCatalogo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCatalogo.CheckValue = "Y"
        Me.chkCatalogo.Enabled = False
        Me.chkCatalogo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCatalogo.Location = New System.Drawing.Point(567, 49)
        Me.chkCatalogo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkCatalogo.Name = "chkCatalogo"
        Me.chkCatalogo.Size = New System.Drawing.Size(208, 18)
        Me.chkCatalogo.TabIndex = 39
        Me.chkCatalogo.Text = "Tiene Catálogo de Productos?"
        Me.chkCatalogo.TextColor = System.Drawing.Color.Black
        '
        'chkPrincipal
        '
        Me.chkPrincipal.AutoSize = True
        '
        '
        '
        Me.chkPrincipal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chkPrincipal.Checked = True
        Me.chkPrincipal.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPrincipal.CheckValue = "Y"
        Me.chkPrincipal.Enabled = False
        Me.chkPrincipal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPrincipal.Location = New System.Drawing.Point(580, 20)
        Me.chkPrincipal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkPrincipal.Name = "chkPrincipal"
        Me.chkPrincipal.Size = New System.Drawing.Size(140, 18)
        Me.chkPrincipal.TabIndex = 38
        Me.chkPrincipal.Text = "Almacén Principal?"
        Me.chkPrincipal.TextColor = System.Drawing.Color.Black
        '
        'chkVentas
        '
        Me.chkVentas.AutoSize = True
        '
        '
        '
        Me.chkVentas.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chkVentas.Checked = True
        Me.chkVentas.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkVentas.CheckValue = "Y"
        Me.chkVentas.Enabled = False
        Me.chkVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkVentas.Location = New System.Drawing.Point(409, 49)
        Me.chkVentas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkVentas.Name = "chkVentas"
        Me.chkVentas.Size = New System.Drawing.Size(110, 18)
        Me.chkVentas.TabIndex = 37
        Me.chkVentas.Text = "es de Ventas?"
        Me.chkVentas.TextColor = System.Drawing.Color.Black
        '
        'chkCompras
        '
        Me.chkCompras.AutoSize = True
        '
        '
        '
        Me.chkCompras.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chkCompras.Checked = True
        Me.chkCompras.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCompras.CheckValue = "Y"
        Me.chkCompras.Enabled = False
        Me.chkCompras.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCompras.Location = New System.Drawing.Point(239, 49)
        Me.chkCompras.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkCompras.Name = "chkCompras"
        Me.chkCompras.Size = New System.Drawing.Size(123, 18)
        Me.chkCompras.TabIndex = 36
        Me.chkCompras.Text = "es de Compras?"
        Me.chkCompras.TextColor = System.Drawing.Color.Black
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        '
        '
        '
        Me.lblCodigo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo.ForeColor = System.Drawing.Color.Black
        Me.lblCodigo.Location = New System.Drawing.Point(13, 17)
        Me.lblCodigo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(50, 19)
        Me.lblCodigo.TabIndex = 35
        Me.lblCodigo.Text = "Código"
        '
        'lblAlmacen
        '
        Me.lblAlmacen.AutoSize = True
        '
        '
        '
        Me.lblAlmacen.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblAlmacen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlmacen.ForeColor = System.Drawing.Color.Black
        Me.lblAlmacen.Location = New System.Drawing.Point(151, 20)
        Me.lblAlmacen.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblAlmacen.Name = "lblAlmacen"
        Me.lblAlmacen.Size = New System.Drawing.Size(61, 19)
        Me.lblAlmacen.TabIndex = 34
        Me.lblAlmacen.Text = "Almacén"
        '
        'chkInvDiario
        '
        Me.chkInvDiario.AutoSize = True
        '
        '
        '
        Me.chkInvDiario.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chkInvDiario.Checked = True
        Me.chkInvDiario.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkInvDiario.CheckValue = "Y"
        Me.chkInvDiario.Enabled = False
        Me.chkInvDiario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkInvDiario.Location = New System.Drawing.Point(13, 49)
        Me.chkInvDiario.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkInvDiario.Name = "chkInvDiario"
        Me.chkInvDiario.Size = New System.Drawing.Size(173, 18)
        Me.chkInvDiario.TabIndex = 26
        Me.chkInvDiario.Text = "Inventariar Diariamente?"
        Me.chkInvDiario.TextColor = System.Drawing.Color.Black
        '
        'chkActivo
        '
        Me.chkActivo.AutoSize = True
        '
        '
        '
        Me.chkActivo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chkActivo.Checked = True
        Me.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkActivo.CheckValue = "Y"
        Me.chkActivo.Enabled = False
        Me.chkActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkActivo.Location = New System.Drawing.Point(881, 78)
        Me.chkActivo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(60, 18)
        Me.chkActivo.TabIndex = 25
        Me.chkActivo.Text = "Activo"
        Me.chkActivo.TextColor = System.Drawing.Color.Black
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
        Me.chkProduccion.Enabled = False
        Me.chkProduccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkProduccion.Location = New System.Drawing.Point(759, 20)
        Me.chkProduccion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkProduccion.Name = "chkProduccion"
        Me.chkProduccion.Size = New System.Drawing.Size(175, 18)
        Me.chkProduccion.TabIndex = 24
        Me.chkProduccion.Text = "Almacén de Producción?"
        Me.chkProduccion.TextColor = System.Drawing.Color.Black
        '
        'txtAlmacen
        '
        Me.txtAlmacen.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAlmacen.Location = New System.Drawing.Point(219, 17)
        Me.txtAlmacen.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtAlmacen.MaxLength = 100
        Me.txtAlmacen.Name = "txtAlmacen"
        Me.txtAlmacen.ReadOnly = True
        Me.txtAlmacen.Size = New System.Drawing.Size(327, 22)
        Me.txtAlmacen.TabIndex = 3
        '
        'txtCodigo
        '
        Me.txtCodigo.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(71, 17)
        Me.txtCodigo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCodigo.MaxLength = 4
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(67, 23)
        Me.txtCodigo.TabIndex = 1
        '
        'TabItem2
        '
        Me.TabItem2.Name = "TabItem2"
        Me.TabItem2.Text = "Precio de Venta General y Costos "
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(4, 7)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(964, 420)
        Me.TabControl1.TabIndex = 8
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.datos)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage1.Size = New System.Drawing.Size(956, 391)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Almacenes"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'datos
        '
        Me.datos.AllowUserToAddRows = False
        Me.datos.AllowUserToDeleteRows = False
        Me.datos.AllowUserToResizeColumns = False
        Me.datos.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.datos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.datos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.datos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.datos.Location = New System.Drawing.Point(-5, 0)
        Me.datos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.datos.MultiSelect = False
        Me.datos.Name = "datos"
        Me.datos.ReadOnly = True
        Me.datos.RowHeadersVisible = False
        Me.datos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.datos.SelectAllSignVisible = False
        Me.datos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datos.ShowEditingIcon = False
        Me.datos.Size = New System.Drawing.Size(959, 384)
        Me.datos.TabIndex = 5
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.LabelX1)
        Me.TabPage2.Controls.Add(Me.txtArea)
        Me.TabPage2.Controls.Add(Me.LblNomAlmacen)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.DataArea)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage2.Size = New System.Drawing.Size(956, 391)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Areas"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.ForeColor = System.Drawing.Color.Green
        Me.LabelX1.Location = New System.Drawing.Point(89, 357)
        Me.LabelX1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(38, 21)
        Me.LabelX1.TabIndex = 37
        Me.LabelX1.Text = "Area"
        '
        'txtArea
        '
        Me.txtArea.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtArea.Location = New System.Drawing.Point(139, 354)
        Me.txtArea.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtArea.MaxLength = 100
        Me.txtArea.Name = "txtArea"
        Me.txtArea.Size = New System.Drawing.Size(400, 22)
        Me.txtArea.TabIndex = 36
        '
        'LblNomAlmacen
        '
        Me.LblNomAlmacen.AutoSize = True
        Me.LblNomAlmacen.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LblNomAlmacen.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LblNomAlmacen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNomAlmacen.ForeColor = System.Drawing.Color.Green
        Me.LblNomAlmacen.Location = New System.Drawing.Point(8, 10)
        Me.LblNomAlmacen.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LblNomAlmacen.Name = "LblNomAlmacen"
        Me.LblNomAlmacen.Size = New System.Drawing.Size(63, 19)
        Me.LblNomAlmacen.TabIndex = 35
        Me.LblNomAlmacen.Text = "Almacén"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(157, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 17)
        Me.Label1.TabIndex = 7
        '
        'DataArea
        '
        Me.DataArea.AllowUserToAddRows = False
        Me.DataArea.AllowUserToDeleteRows = False
        Me.DataArea.AllowUserToResizeColumns = False
        Me.DataArea.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataArea.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataArea.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataArea.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataArea.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DataArea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataArea.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataArea.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.DataArea.Location = New System.Drawing.Point(-3, 37)
        Me.DataArea.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataArea.MultiSelect = False
        Me.DataArea.Name = "DataArea"
        Me.DataArea.ReadOnly = True
        Me.DataArea.RowHeadersVisible = False
        Me.DataArea.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataArea.SelectAllSignVisible = False
        Me.DataArea.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataArea.ShowEditingIcon = False
        Me.DataArea.Size = New System.Drawing.Size(959, 313)
        Me.DataArea.TabIndex = 6
        '
        'm_almacen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(1093, 580)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.grupoDetalle)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "m_almacen"
        Me.Text = "Mantenimiento: ALMACENES"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.grupoDetalle.ResumeLayout(False)
        Me.grupoDetalle.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DataArea, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdCerrar As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdEditar As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents cmdAñadir As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents cmdEliminar As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents cmdGrabar As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents cmdCancelar As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents grupoDetalle As System.Windows.Forms.GroupBox
    Friend WithEvents txtAlmacen As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents chkInvDiario As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chkActivo As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chkProduccion As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents lblCodigo As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblAlmacen As DevComponents.DotNetBar.LabelX
    Friend WithEvents chkVentas As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chkCompras As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chkPrincipal As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chkCatalogo As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chkIdeales As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chkOrigen As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chkDestino As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents txtCatalogo As System.Windows.Forms.TextBox
    Friend WithEvents lblCatalogo As DevComponents.DotNetBar.LabelX
    Friend WithEvents TabItem2 As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents datos As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents DataArea As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents Label1 As Label
    Friend WithEvents LblNomAlmacen As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtArea As TextBox
End Class
