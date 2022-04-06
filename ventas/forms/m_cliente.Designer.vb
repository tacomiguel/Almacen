<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class m_cliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(m_cliente))
        Me.grupoCatalogo = New System.Windows.Forms.GroupBox()
        Me.cboFpago = New System.Windows.Forms.ComboBox()
        Me.Etiqueta16 = New mControles.etiqueta()
        Me.txtCelCont = New System.Windows.Forms.TextBox()
        Me.Etiqueta10 = New mControles.etiqueta()
        Me.txtFonoCont = New System.Windows.Forms.TextBox()
        Me.Etiqueta14 = New mControles.etiqueta()
        Me.txtCelRep = New System.Windows.Forms.TextBox()
        Me.Etiqueta13 = New mControles.etiqueta()
        Me.txtFonoRep = New System.Windows.Forms.TextBox()
        Me.Etiqueta12 = New mControles.etiqueta()
        Me.txtContacto = New System.Windows.Forms.TextBox()
        Me.lblTipo = New mControles.etiqueta()
        Me.cboTipo = New System.Windows.Forms.ComboBox()
        Me.txtDirRecepcion = New System.Windows.Forms.TextBox()
        Me.Etiqueta9 = New mControles.etiqueta()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Etiqueta5 = New mControles.etiqueta()
        Me.txtRepresentante = New System.Windows.Forms.TextBox()
        Me.Etiqueta8 = New mControles.etiqueta()
        Me.txtNombreComercial = New System.Windows.Forms.TextBox()
        Me.lblNombreComercial = New mControles.etiqueta()
        Me.Etiqueta6 = New mControles.etiqueta()
        Me.chkActivo = New System.Windows.Forms.CheckBox()
        Me.txtFaxCliente = New System.Windows.Forms.TextBox()
        Me.txtFonoCliente = New System.Windows.Forms.TextBox()
        Me.txtRazonSocial = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Etiqueta4 = New mControles.etiqueta()
        Me.Etiqueta3 = New mControles.etiqueta()
        Me.lblRazonSocial = New mControles.etiqueta()
        Me.lblCodigo = New mControles.etiqueta()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmdImprimir = New DevExpress.DXCore.Controls.XtraEditors.SimpleButton()
        Me.cmdEditar = New DevExpress.DXCore.Controls.XtraEditors.SimpleButton()
        Me.cmdAñadir = New DevExpress.DXCore.Controls.XtraEditors.SimpleButton()
        Me.cmdEliminar = New DevExpress.DXCore.Controls.XtraEditors.SimpleButton()
        Me.cmdGrabar = New DevExpress.DXCore.Controls.XtraEditors.SimpleButton()
        Me.cmdCancelar = New DevExpress.DXCore.Controls.XtraEditors.SimpleButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdCerrar = New DevExpress.DXCore.Controls.XtraEditors.SimpleButton()
        Me.dataCliente = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.grupoCatalogo.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dataCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grupoCatalogo
        '
        Me.grupoCatalogo.Controls.Add(Me.cboFpago)
        Me.grupoCatalogo.Controls.Add(Me.Etiqueta16)
        Me.grupoCatalogo.Controls.Add(Me.txtCelCont)
        Me.grupoCatalogo.Controls.Add(Me.Etiqueta10)
        Me.grupoCatalogo.Controls.Add(Me.txtFonoCont)
        Me.grupoCatalogo.Controls.Add(Me.Etiqueta14)
        Me.grupoCatalogo.Controls.Add(Me.txtCelRep)
        Me.grupoCatalogo.Controls.Add(Me.Etiqueta13)
        Me.grupoCatalogo.Controls.Add(Me.txtFonoRep)
        Me.grupoCatalogo.Controls.Add(Me.Etiqueta12)
        Me.grupoCatalogo.Controls.Add(Me.txtContacto)
        Me.grupoCatalogo.Controls.Add(Me.lblTipo)
        Me.grupoCatalogo.Controls.Add(Me.cboTipo)
        Me.grupoCatalogo.Controls.Add(Me.txtDirRecepcion)
        Me.grupoCatalogo.Controls.Add(Me.Etiqueta9)
        Me.grupoCatalogo.Controls.Add(Me.txtDireccion)
        Me.grupoCatalogo.Controls.Add(Me.Etiqueta5)
        Me.grupoCatalogo.Controls.Add(Me.txtRepresentante)
        Me.grupoCatalogo.Controls.Add(Me.Etiqueta8)
        Me.grupoCatalogo.Controls.Add(Me.txtNombreComercial)
        Me.grupoCatalogo.Controls.Add(Me.lblNombreComercial)
        Me.grupoCatalogo.Controls.Add(Me.Etiqueta6)
        Me.grupoCatalogo.Controls.Add(Me.chkActivo)
        Me.grupoCatalogo.Controls.Add(Me.txtFaxCliente)
        Me.grupoCatalogo.Controls.Add(Me.txtFonoCliente)
        Me.grupoCatalogo.Controls.Add(Me.txtRazonSocial)
        Me.grupoCatalogo.Controls.Add(Me.txtCodigo)
        Me.grupoCatalogo.Controls.Add(Me.Etiqueta4)
        Me.grupoCatalogo.Controls.Add(Me.Etiqueta3)
        Me.grupoCatalogo.Controls.Add(Me.lblRazonSocial)
        Me.grupoCatalogo.Controls.Add(Me.lblCodigo)
        Me.grupoCatalogo.Location = New System.Drawing.Point(9, 273)
        Me.grupoCatalogo.Name = "grupoCatalogo"
        Me.grupoCatalogo.Size = New System.Drawing.Size(725, 197)
        Me.grupoCatalogo.TabIndex = 1
        Me.grupoCatalogo.TabStop = False
        '
        'cboFpago
        '
        Me.cboFpago.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboFpago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFpago.Enabled = False
        Me.cboFpago.FormattingEnabled = True
        Me.cboFpago.Location = New System.Drawing.Point(497, 108)
        Me.cboFpago.Name = "cboFpago"
        Me.cboFpago.Size = New System.Drawing.Size(217, 21)
        Me.cboFpago.TabIndex = 32
        '
        'Etiqueta16
        '
        Me.Etiqueta16.AutoSize = True
        Me.Etiqueta16.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Etiqueta16.BackColor = System.Drawing.Color.White
        Me.Etiqueta16.Location = New System.Drawing.Point(455, 109)
        Me.Etiqueta16.Name = "Etiqueta16"
        Me.Etiqueta16.Size = New System.Drawing.Size(43, 16)
        Me.Etiqueta16.TabIndex = 31
        Me.Etiqueta16.TabStop = False
        Me.Etiqueta16.texto = "Pago"
        '
        'txtCelCont
        '
        Me.txtCelCont.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCelCont.Location = New System.Drawing.Point(566, 167)
        Me.txtCelCont.MaxLength = 10
        Me.txtCelCont.Name = "txtCelCont"
        Me.txtCelCont.ReadOnly = True
        Me.txtCelCont.Size = New System.Drawing.Size(78, 20)
        Me.txtCelCont.TabIndex = 14
        '
        'Etiqueta10
        '
        Me.Etiqueta10.AutoSize = True
        Me.Etiqueta10.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Etiqueta10.BackColor = System.Drawing.Color.White
        Me.Etiqueta10.Location = New System.Drawing.Point(509, 168)
        Me.Etiqueta10.Name = "Etiqueta10"
        Me.Etiqueta10.Size = New System.Drawing.Size(56, 16)
        Me.Etiqueta10.TabIndex = 27
        Me.Etiqueta10.TabStop = False
        Me.Etiqueta10.texto = "Celular"
        '
        'txtFonoCont
        '
        Me.txtFonoCont.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFonoCont.Location = New System.Drawing.Point(423, 167)
        Me.txtFonoCont.MaxLength = 10
        Me.txtFonoCont.Name = "txtFonoCont"
        Me.txtFonoCont.ReadOnly = True
        Me.txtFonoCont.Size = New System.Drawing.Size(78, 20)
        Me.txtFonoCont.TabIndex = 13
        '
        'Etiqueta14
        '
        Me.Etiqueta14.AutoSize = True
        Me.Etiqueta14.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Etiqueta14.BackColor = System.Drawing.Color.White
        Me.Etiqueta14.Location = New System.Drawing.Point(380, 168)
        Me.Etiqueta14.Name = "Etiqueta14"
        Me.Etiqueta14.Size = New System.Drawing.Size(42, 16)
        Me.Etiqueta14.TabIndex = 25
        Me.Etiqueta14.TabStop = False
        Me.Etiqueta14.texto = "Fono"
        '
        'txtCelRep
        '
        Me.txtCelRep.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCelRep.Location = New System.Drawing.Point(636, 137)
        Me.txtCelRep.MaxLength = 10
        Me.txtCelRep.Name = "txtCelRep"
        Me.txtCelRep.ReadOnly = True
        Me.txtCelRep.Size = New System.Drawing.Size(78, 20)
        Me.txtCelRep.TabIndex = 11
        '
        'Etiqueta13
        '
        Me.Etiqueta13.AutoSize = True
        Me.Etiqueta13.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Etiqueta13.BackColor = System.Drawing.Color.White
        Me.Etiqueta13.Location = New System.Drawing.Point(579, 139)
        Me.Etiqueta13.Name = "Etiqueta13"
        Me.Etiqueta13.Size = New System.Drawing.Size(56, 16)
        Me.Etiqueta13.TabIndex = 21
        Me.Etiqueta13.TabStop = False
        Me.Etiqueta13.texto = "Celular"
        '
        'txtFonoRep
        '
        Me.txtFonoRep.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFonoRep.Location = New System.Drawing.Point(497, 137)
        Me.txtFonoRep.MaxLength = 10
        Me.txtFonoRep.Name = "txtFonoRep"
        Me.txtFonoRep.ReadOnly = True
        Me.txtFonoRep.Size = New System.Drawing.Size(78, 20)
        Me.txtFonoRep.TabIndex = 10
        '
        'Etiqueta12
        '
        Me.Etiqueta12.AutoSize = True
        Me.Etiqueta12.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Etiqueta12.BackColor = System.Drawing.Color.White
        Me.Etiqueta12.Location = New System.Drawing.Point(454, 138)
        Me.Etiqueta12.Name = "Etiqueta12"
        Me.Etiqueta12.Size = New System.Drawing.Size(42, 16)
        Me.Etiqueta12.TabIndex = 19
        Me.Etiqueta12.TabStop = False
        Me.Etiqueta12.texto = "Fono"
        '
        'txtContacto
        '
        Me.txtContacto.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtContacto.Location = New System.Drawing.Point(79, 167)
        Me.txtContacto.MaxLength = 80
        Me.txtContacto.Name = "txtContacto"
        Me.txtContacto.ReadOnly = True
        Me.txtContacto.Size = New System.Drawing.Size(292, 20)
        Me.txtContacto.TabIndex = 12
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.lblTipo.BackColor = System.Drawing.Color.White
        Me.lblTipo.Location = New System.Drawing.Point(455, 77)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(38, 16)
        Me.lblTipo.TabIndex = 13
        Me.lblTipo.TabStop = False
        Me.lblTipo.texto = "Tipo"
        '
        'cboTipo
        '
        Me.cboTipo.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipo.Enabled = False
        Me.cboTipo.FormattingEnabled = True
        Me.cboTipo.Location = New System.Drawing.Point(497, 75)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Size = New System.Drawing.Size(217, 21)
        Me.cboTipo.TabIndex = 6
        '
        'txtDirRecepcion
        '
        Me.txtDirRecepcion.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDirRecepcion.Location = New System.Drawing.Point(95, 108)
        Me.txtDirRecepcion.MaxLength = 200
        Me.txtDirRecepcion.Name = "txtDirRecepcion"
        Me.txtDirRecepcion.ReadOnly = True
        Me.txtDirRecepcion.Size = New System.Drawing.Size(357, 20)
        Me.txtDirRecepcion.TabIndex = 7
        '
        'Etiqueta9
        '
        Me.Etiqueta9.AutoSize = True
        Me.Etiqueta9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Etiqueta9.BackColor = System.Drawing.Color.White
        Me.Etiqueta9.Location = New System.Drawing.Point(12, 109)
        Me.Etiqueta9.Name = "Etiqueta9"
        Me.Etiqueta9.Size = New System.Drawing.Size(83, 16)
        Me.Etiqueta9.TabIndex = 15
        Me.Etiqueta9.TabStop = False
        Me.Etiqueta9.texto = "Dir.Entrega"
        '
        'txtDireccion
        '
        Me.txtDireccion.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDireccion.Location = New System.Drawing.Point(84, 76)
        Me.txtDireccion.MaxLength = 200
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.ReadOnly = True
        Me.txtDireccion.Size = New System.Drawing.Size(368, 20)
        Me.txtDireccion.TabIndex = 5
        '
        'Etiqueta5
        '
        Me.Etiqueta5.AutoSize = True
        Me.Etiqueta5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Etiqueta5.BackColor = System.Drawing.Color.White
        Me.Etiqueta5.Location = New System.Drawing.Point(12, 77)
        Me.Etiqueta5.Name = "Etiqueta5"
        Me.Etiqueta5.Size = New System.Drawing.Size(71, 16)
        Me.Etiqueta5.TabIndex = 11
        Me.Etiqueta5.TabStop = False
        Me.Etiqueta5.texto = "Dirección"
        '
        'txtRepresentante
        '
        Me.txtRepresentante.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRepresentante.Location = New System.Drawing.Point(117, 137)
        Me.txtRepresentante.MaxLength = 80
        Me.txtRepresentante.Name = "txtRepresentante"
        Me.txtRepresentante.ReadOnly = True
        Me.txtRepresentante.Size = New System.Drawing.Size(327, 20)
        Me.txtRepresentante.TabIndex = 9
        '
        'Etiqueta8
        '
        Me.Etiqueta8.AutoSize = True
        Me.Etiqueta8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Etiqueta8.BackColor = System.Drawing.Color.White
        Me.Etiqueta8.Location = New System.Drawing.Point(12, 137)
        Me.Etiqueta8.Name = "Etiqueta8"
        Me.Etiqueta8.Size = New System.Drawing.Size(104, 16)
        Me.Etiqueta8.TabIndex = 17
        Me.Etiqueta8.TabStop = False
        Me.Etiqueta8.texto = "Representante"
        '
        'txtNombreComercial
        '
        Me.txtNombreComercial.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNombreComercial.Location = New System.Drawing.Point(141, 44)
        Me.txtNombreComercial.MaxLength = 100
        Me.txtNombreComercial.Name = "txtNombreComercial"
        Me.txtNombreComercial.ReadOnly = True
        Me.txtNombreComercial.Size = New System.Drawing.Size(330, 20)
        Me.txtNombreComercial.TabIndex = 2
        '
        'lblNombreComercial
        '
        Me.lblNombreComercial.AutoSize = True
        Me.lblNombreComercial.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.lblNombreComercial.BackColor = System.Drawing.Color.White
        Me.lblNombreComercial.Location = New System.Drawing.Point(12, 45)
        Me.lblNombreComercial.Name = "lblNombreComercial"
        Me.lblNombreComercial.Size = New System.Drawing.Size(130, 16)
        Me.lblNombreComercial.TabIndex = 5
        Me.lblNombreComercial.TabStop = False
        Me.lblNombreComercial.texto = "Nombre Comercial"
        '
        'Etiqueta6
        '
        Me.Etiqueta6.AutoSize = True
        Me.Etiqueta6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Etiqueta6.BackColor = System.Drawing.Color.White
        Me.Etiqueta6.Location = New System.Drawing.Point(12, 168)
        Me.Etiqueta6.Name = "Etiqueta6"
        Me.Etiqueta6.Size = New System.Drawing.Size(66, 16)
        Me.Etiqueta6.TabIndex = 23
        Me.Etiqueta6.TabStop = False
        Me.Etiqueta6.texto = "Contacto"
        '
        'chkActivo
        '
        Me.chkActivo.AutoSize = True
        Me.chkActivo.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chkActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkActivo.Location = New System.Drawing.Point(657, 170)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(62, 17)
        Me.chkActivo.TabIndex = 15
        Me.chkActivo.Text = "Activo"
        Me.chkActivo.UseVisualStyleBackColor = False
        '
        'txtFaxCliente
        '
        Me.txtFaxCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFaxCliente.Location = New System.Drawing.Point(636, 44)
        Me.txtFaxCliente.MaxLength = 10
        Me.txtFaxCliente.Name = "txtFaxCliente"
        Me.txtFaxCliente.ReadOnly = True
        Me.txtFaxCliente.Size = New System.Drawing.Size(78, 20)
        Me.txtFaxCliente.TabIndex = 4
        '
        'txtFonoCliente
        '
        Me.txtFonoCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFonoCliente.Location = New System.Drawing.Point(518, 44)
        Me.txtFonoCliente.MaxLength = 10
        Me.txtFonoCliente.Name = "txtFonoCliente"
        Me.txtFonoCliente.ReadOnly = True
        Me.txtFonoCliente.Size = New System.Drawing.Size(78, 20)
        Me.txtFonoCliente.TabIndex = 3
        '
        'txtRazonSocial
        '
        Me.txtRazonSocial.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRazonSocial.Location = New System.Drawing.Point(305, 15)
        Me.txtRazonSocial.MaxLength = 100
        Me.txtRazonSocial.Name = "txtRazonSocial"
        Me.txtRazonSocial.ReadOnly = True
        Me.txtRazonSocial.Size = New System.Drawing.Size(409, 20)
        Me.txtRazonSocial.TabIndex = 1
        '
        'txtCodigo
        '
        Me.txtCodigo.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCodigo.Location = New System.Drawing.Point(68, 15)
        Me.txtCodigo.MaxLength = 20
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(144, 20)
        Me.txtCodigo.TabIndex = 0
        '
        'Etiqueta4
        '
        Me.Etiqueta4.AutoSize = True
        Me.Etiqueta4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Etiqueta4.BackColor = System.Drawing.Color.White
        Me.Etiqueta4.Location = New System.Drawing.Point(602, 44)
        Me.Etiqueta4.Name = "Etiqueta4"
        Me.Etiqueta4.Size = New System.Drawing.Size(33, 16)
        Me.Etiqueta4.TabIndex = 9
        Me.Etiqueta4.TabStop = False
        Me.Etiqueta4.texto = "Fax"
        '
        'Etiqueta3
        '
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Etiqueta3.BackColor = System.Drawing.Color.White
        Me.Etiqueta3.Location = New System.Drawing.Point(477, 44)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(42, 16)
        Me.Etiqueta3.TabIndex = 7
        Me.Etiqueta3.TabStop = False
        Me.Etiqueta3.texto = "Fono"
        '
        'lblRazonSocial
        '
        Me.lblRazonSocial.AutoSize = True
        Me.lblRazonSocial.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.lblRazonSocial.BackColor = System.Drawing.Color.White
        Me.lblRazonSocial.Location = New System.Drawing.Point(209, 16)
        Me.lblRazonSocial.Name = "lblRazonSocial"
        Me.lblRazonSocial.Size = New System.Drawing.Size(95, 16)
        Me.lblRazonSocial.TabIndex = 3
        Me.lblRazonSocial.TabStop = False
        Me.lblRazonSocial.texto = "Razon Social"
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.lblCodigo.BackColor = System.Drawing.Color.White
        Me.lblCodigo.Location = New System.Drawing.Point(12, 16)
        Me.lblCodigo.Margin = New System.Windows.Forms.Padding(0)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(55, 16)
        Me.lblCodigo.TabIndex = 0
        Me.lblCodigo.TabStop = False
        Me.lblCodigo.texto = "Código"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmdImprimir)
        Me.GroupBox2.Controls.Add(Me.cmdEditar)
        Me.GroupBox2.Controls.Add(Me.cmdAñadir)
        Me.GroupBox2.Controls.Add(Me.cmdEliminar)
        Me.GroupBox2.Controls.Add(Me.cmdGrabar)
        Me.GroupBox2.Controls.Add(Me.cmdCancelar)
        Me.GroupBox2.Location = New System.Drawing.Point(740, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(74, 319)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmdImprimir.Appearance.Options.UseFont = True
        Me.cmdImprimir.Image = Global.cefe.My.Resources.Resources.print_preview
        Me.cmdImprimir.ImageLocation = DevExpress.DXCore.Controls.XtraEditors.ImageLocation.TopCenter
        Me.cmdImprimir.Location = New System.Drawing.Point(6, 265)
        Me.cmdImprimir.LookAndFeel.SkinName = "iMaginary"
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(62, 45)
        Me.cmdImprimir.TabIndex = 40
        Me.cmdImprimir.Text = "Imprimir"
        '
        'cmdEditar
        '
        Me.cmdEditar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmdEditar.Appearance.Options.UseFont = True
        Me.cmdEditar.Image = Global.cefe.My.Resources.Resources.m_editar
        Me.cmdEditar.ImageLocation = DevExpress.DXCore.Controls.XtraEditors.ImageLocation.TopCenter
        Me.cmdEditar.Location = New System.Drawing.Point(6, 214)
        Me.cmdEditar.LookAndFeel.SkinName = "iMaginary"
        Me.cmdEditar.Name = "cmdEditar"
        Me.cmdEditar.Size = New System.Drawing.Size(62, 45)
        Me.cmdEditar.TabIndex = 39
        Me.cmdEditar.Text = "Editar"
        '
        'cmdAñadir
        '
        Me.cmdAñadir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmdAñadir.Appearance.Options.UseFont = True
        Me.cmdAñadir.Image = Global.cefe.My.Resources.Resources.m_añadir
        Me.cmdAñadir.ImageLocation = DevExpress.DXCore.Controls.XtraEditors.ImageLocation.TopCenter
        Me.cmdAñadir.Location = New System.Drawing.Point(6, 13)
        Me.cmdAñadir.LookAndFeel.SkinName = "iMaginary"
        Me.cmdAñadir.Name = "cmdAñadir"
        Me.cmdAñadir.Size = New System.Drawing.Size(62, 45)
        Me.cmdAñadir.TabIndex = 0
        Me.cmdAñadir.Text = "Añadir"
        '
        'cmdEliminar
        '
        Me.cmdEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmdEliminar.Appearance.Options.UseFont = True
        Me.cmdEliminar.Image = Global.cefe.My.Resources.Resources.m_borrar
        Me.cmdEliminar.ImageLocation = DevExpress.DXCore.Controls.XtraEditors.ImageLocation.TopCenter
        Me.cmdEliminar.Location = New System.Drawing.Point(6, 163)
        Me.cmdEliminar.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(62, 45)
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
        Me.cmdGrabar.Location = New System.Drawing.Point(6, 63)
        Me.cmdGrabar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdGrabar.Name = "cmdGrabar"
        Me.cmdGrabar.Size = New System.Drawing.Size(62, 45)
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
        Me.cmdCancelar.Location = New System.Drawing.Point(6, 112)
        Me.cmdCancelar.LookAndFeel.SkinName = "Black"
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(62, 45)
        Me.cmdCancelar.TabIndex = 37
        Me.cmdCancelar.Text = "Cancelar"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdCerrar)
        Me.GroupBox1.Location = New System.Drawing.Point(740, 406)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(74, 64)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        '
        'cmdCerrar
        '
        Me.cmdCerrar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmdCerrar.Appearance.Options.UseFont = True
        Me.cmdCerrar.Image = Global.cefe.My.Resources.Resources.CLOSE22
        Me.cmdCerrar.ImageLocation = DevExpress.DXCore.Controls.XtraEditors.ImageLocation.TopCenter
        Me.cmdCerrar.Location = New System.Drawing.Point(6, 12)
        Me.cmdCerrar.LookAndFeel.SkinName = "iMaginary"
        Me.cmdCerrar.Name = "cmdCerrar"
        Me.cmdCerrar.Size = New System.Drawing.Size(62, 45)
        Me.cmdCerrar.TabIndex = 40
        Me.cmdCerrar.Text = "Cerrar"
        '
        'dataCliente
        '
        Me.dataCliente.AllowUserToAddRows = False
        Me.dataCliente.AllowUserToDeleteRows = False
        Me.dataCliente.AllowUserToResizeColumns = False
        Me.dataCliente.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dataCliente.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dataCliente.BackgroundColor = System.Drawing.Color.White
        Me.dataCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataCliente.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dataCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataCliente.DefaultCellStyle = DataGridViewCellStyle3
        Me.dataCliente.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dataCliente.Location = New System.Drawing.Point(9, 10)
        Me.dataCliente.MultiSelect = False
        Me.dataCliente.Name = "dataCliente"
        Me.dataCliente.ReadOnly = True
        Me.dataCliente.RowHeadersVisible = False
        Me.dataCliente.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dataCliente.SelectAllSignVisible = False
        Me.dataCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataCliente.ShowEditingIcon = False
        Me.dataCliente.Size = New System.Drawing.Size(725, 265)
        Me.dataCliente.TabIndex = 0
        '
        'm_cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(823, 478)
        Me.Controls.Add(Me.dataCliente)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.grupoCatalogo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "m_cliente"
        Me.Text = "Mantenimiento: CLIENTES"
        Me.grupoCatalogo.ResumeLayout(False)
        Me.grupoCatalogo.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dataCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grupoCatalogo As System.Windows.Forms.GroupBox
    Friend WithEvents txtNombreComercial As System.Windows.Forms.TextBox
    Friend WithEvents lblNombreComercial As mControles.etiqueta
    Friend WithEvents Etiqueta6 As mControles.etiqueta
    Friend WithEvents chkActivo As System.Windows.Forms.CheckBox
    Friend WithEvents txtFaxCliente As System.Windows.Forms.TextBox
    Friend WithEvents txtFonoCliente As System.Windows.Forms.TextBox
    Friend WithEvents txtRazonSocial As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Etiqueta4 As mControles.etiqueta
    Friend WithEvents Etiqueta3 As mControles.etiqueta
    Friend WithEvents lblRazonSocial As mControles.etiqueta
    Friend WithEvents lblCodigo As mControles.etiqueta
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents Etiqueta5 As mControles.etiqueta
    Friend WithEvents txtCelRep As System.Windows.Forms.TextBox
    Friend WithEvents Etiqueta13 As mControles.etiqueta
    Friend WithEvents txtFonoRep As System.Windows.Forms.TextBox
    Friend WithEvents txtContacto As System.Windows.Forms.TextBox
    Friend WithEvents txtCelCont As System.Windows.Forms.TextBox
    Friend WithEvents Etiqueta10 As mControles.etiqueta
    Friend WithEvents txtFonoCont As System.Windows.Forms.TextBox
    Friend WithEvents Etiqueta14 As mControles.etiqueta
    Friend WithEvents Etiqueta12 As mControles.etiqueta
    Friend WithEvents lblTipo As mControles.etiqueta
    Friend WithEvents cboTipo As System.Windows.Forms.ComboBox
    Friend WithEvents txtDirRecepcion As System.Windows.Forms.TextBox
    Friend WithEvents Etiqueta9 As mControles.etiqueta
    Friend WithEvents txtRepresentante As System.Windows.Forms.TextBox
    Friend WithEvents Etiqueta8 As mControles.etiqueta
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdImprimir As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents cmdEditar As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents cmdAñadir As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents cmdEliminar As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents cmdGrabar As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents cmdCancelar As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdCerrar As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents dataCliente As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents Etiqueta16 As mControles.etiqueta
    Friend WithEvents cboFpago As System.Windows.Forms.ComboBox

End Class
