<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class m_conductor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(m_conductor))
        Me.grupoDetalle = New System.Windows.Forms.GroupBox()
        Me.Etiqueta3 = New mControles.etiqueta()
        Me.txtConductor = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.chkActivo = New System.Windows.Forms.CheckBox()
        Me.lblConductor = New mControles.etiqueta()
        Me.lblCodigo = New mControles.etiqueta()
        Me.dataChofer = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmdEditar = New DevExpress.DXCore.Controls.XtraEditors.SimpleButton()
        Me.cmdAñadir = New DevExpress.DXCore.Controls.XtraEditors.SimpleButton()
        Me.cmdEliminar = New DevExpress.DXCore.Controls.XtraEditors.SimpleButton()
        Me.cmdGrabar = New DevExpress.DXCore.Controls.XtraEditors.SimpleButton()
        Me.cmdCancelar = New DevExpress.DXCore.Controls.XtraEditors.SimpleButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdCerrar = New DevExpress.DXCore.Controls.XtraEditors.SimpleButton()
        Me.txtLicencia = New System.Windows.Forms.TextBox()
        Me.Etiqueta1 = New mControles.etiqueta()
        Me.txtmarca = New System.Windows.Forms.TextBox()
        Me.Etiqueta2 = New mControles.etiqueta()
        Me.txtplaca = New System.Windows.Forms.TextBox()
        Me.Etiqueta4 = New mControles.etiqueta()
        Me.grupoDetalle.SuspendLayout()
        CType(Me.dataChofer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grupoDetalle
        '
        Me.grupoDetalle.Controls.Add(Me.txtplaca)
        Me.grupoDetalle.Controls.Add(Me.Etiqueta4)
        Me.grupoDetalle.Controls.Add(Me.txtmarca)
        Me.grupoDetalle.Controls.Add(Me.Etiqueta2)
        Me.grupoDetalle.Controls.Add(Me.txtLicencia)
        Me.grupoDetalle.Controls.Add(Me.Etiqueta1)
        Me.grupoDetalle.Controls.Add(Me.Etiqueta3)
        Me.grupoDetalle.Controls.Add(Me.txtConductor)
        Me.grupoDetalle.Controls.Add(Me.txtCodigo)
        Me.grupoDetalle.Controls.Add(Me.chkActivo)
        Me.grupoDetalle.Controls.Add(Me.lblConductor)
        Me.grupoDetalle.Controls.Add(Me.lblCodigo)
        Me.grupoDetalle.Location = New System.Drawing.Point(12, 256)
        Me.grupoDetalle.Name = "grupoDetalle"
        Me.grupoDetalle.Size = New System.Drawing.Size(429, 134)
        Me.grupoDetalle.TabIndex = 1
        Me.grupoDetalle.TabStop = False
        '
        'Etiqueta3
        '
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Etiqueta3.BackColor = System.Drawing.Color.White
        Me.Etiqueta3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Etiqueta3.Location = New System.Drawing.Point(168, 23)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(30, 16)
        Me.Etiqueta3.TabIndex = 10
        Me.Etiqueta3.TabStop = False
        Me.Etiqueta3.texto = "dni"
        '
        'txtConductor
        '
        Me.txtConductor.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtConductor.Location = New System.Drawing.Point(86, 45)
        Me.txtConductor.MaxLength = 50
        Me.txtConductor.Name = "txtConductor"
        Me.txtConductor.ReadOnly = True
        Me.txtConductor.Size = New System.Drawing.Size(332, 20)
        Me.txtConductor.TabIndex = 1
        '
        'txtCodigo
        '
        Me.txtCodigo.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(70, 19)
        Me.txtCodigo.MaxLength = 8
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(97, 20)
        Me.txtCodigo.TabIndex = 0
        '
        'chkActivo
        '
        Me.chkActivo.AutoSize = True
        Me.chkActivo.Enabled = False
        Me.chkActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkActivo.Location = New System.Drawing.Point(361, 21)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(62, 17)
        Me.chkActivo.TabIndex = 2
        Me.chkActivo.Text = "Activo"
        Me.chkActivo.UseVisualStyleBackColor = True
        '
        'lblConductor
        '
        Me.lblConductor.AutoSize = True
        Me.lblConductor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.lblConductor.BackColor = System.Drawing.Color.White
        Me.lblConductor.Location = New System.Drawing.Point(9, 45)
        Me.lblConductor.Name = "lblConductor"
        Me.lblConductor.Size = New System.Drawing.Size(75, 16)
        Me.lblConductor.TabIndex = 3
        Me.lblConductor.TabStop = False
        Me.lblConductor.texto = "Conductor"
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.lblCodigo.BackColor = System.Drawing.Color.White
        Me.lblCodigo.Location = New System.Drawing.Point(9, 19)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(55, 16)
        Me.lblCodigo.TabIndex = 0
        Me.lblCodigo.TabStop = False
        Me.lblCodigo.texto = "Código"
        '
        'dataChofer
        '
        Me.dataChofer.AllowUserToAddRows = False
        Me.dataChofer.AllowUserToDeleteRows = False
        Me.dataChofer.AllowUserToResizeColumns = False
        Me.dataChofer.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dataChofer.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dataChofer.BackgroundColor = System.Drawing.Color.White
        Me.dataChofer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataChofer.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dataChofer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataChofer.DefaultCellStyle = DataGridViewCellStyle3
        Me.dataChofer.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dataChofer.Location = New System.Drawing.Point(12, 12)
        Me.dataChofer.MultiSelect = False
        Me.dataChofer.Name = "dataChofer"
        Me.dataChofer.ReadOnly = True
        Me.dataChofer.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dataChofer.SelectAllSignVisible = False
        Me.dataChofer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataChofer.ShowEditingIcon = False
        Me.dataChofer.Size = New System.Drawing.Size(429, 243)
        Me.dataChofer.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmdEditar)
        Me.GroupBox2.Controls.Add(Me.cmdAñadir)
        Me.GroupBox2.Controls.Add(Me.cmdEliminar)
        Me.GroupBox2.Controls.Add(Me.cmdGrabar)
        Me.GroupBox2.Controls.Add(Me.cmdCancelar)
        Me.GroupBox2.Location = New System.Drawing.Point(447, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(74, 266)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
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
        Me.GroupBox1.Location = New System.Drawing.Point(447, 309)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(74, 64)
        Me.GroupBox1.TabIndex = 20
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
        Me.cmdCerrar.TabIndex = 41
        Me.cmdCerrar.Text = "Cerrar"
        '
        'txtLicencia
        '
        Me.txtLicencia.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLicencia.Location = New System.Drawing.Point(86, 71)
        Me.txtLicencia.MaxLength = 50
        Me.txtLicencia.Name = "txtLicencia"
        Me.txtLicencia.ReadOnly = True
        Me.txtLicencia.Size = New System.Drawing.Size(187, 20)
        Me.txtLicencia.TabIndex = 11
        '
        'Etiqueta1
        '
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Etiqueta1.BackColor = System.Drawing.Color.White
        Me.Etiqueta1.Location = New System.Drawing.Point(9, 71)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(64, 16)
        Me.Etiqueta1.TabIndex = 12
        Me.Etiqueta1.TabStop = False
        Me.Etiqueta1.texto = "Licencia"
        '
        'txtmarca
        '
        Me.txtmarca.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtmarca.Location = New System.Drawing.Point(86, 97)
        Me.txtmarca.MaxLength = 50
        Me.txtmarca.Name = "txtmarca"
        Me.txtmarca.ReadOnly = True
        Me.txtmarca.Size = New System.Drawing.Size(131, 20)
        Me.txtmarca.TabIndex = 13
        '
        'Etiqueta2
        '
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Etiqueta2.BackColor = System.Drawing.Color.White
        Me.Etiqueta2.Location = New System.Drawing.Point(9, 97)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(82, 16)
        Me.Etiqueta2.TabIndex = 14
        Me.Etiqueta2.TabStop = False
        Me.Etiqueta2.texto = "Auto Marca"
        '
        'txtplaca
        '
        Me.txtplaca.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtplaca.Location = New System.Drawing.Point(273, 97)
        Me.txtplaca.MaxLength = 50
        Me.txtplaca.Name = "txtplaca"
        Me.txtplaca.ReadOnly = True
        Me.txtplaca.Size = New System.Drawing.Size(145, 20)
        Me.txtplaca.TabIndex = 15
        '
        'Etiqueta4
        '
        Me.Etiqueta4.AutoSize = True
        Me.Etiqueta4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Etiqueta4.BackColor = System.Drawing.Color.White
        Me.Etiqueta4.Location = New System.Drawing.Point(227, 97)
        Me.Etiqueta4.Name = "Etiqueta4"
        Me.Etiqueta4.Size = New System.Drawing.Size(46, 16)
        Me.Etiqueta4.TabIndex = 16
        Me.Etiqueta4.TabStop = False
        Me.Etiqueta4.texto = "Placa"
        '
        'm_conductor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(530, 402)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dataChofer)
        Me.Controls.Add(Me.grupoDetalle)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "m_conductor"
        Me.Text = "Mantenimiento: CONDUCTORES"
        Me.grupoDetalle.ResumeLayout(False)
        Me.grupoDetalle.PerformLayout()
        CType(Me.dataChofer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grupoDetalle As System.Windows.Forms.GroupBox
    Friend WithEvents txtConductor As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents chkActivo As System.Windows.Forms.CheckBox
    Friend WithEvents lblConductor As mControles.etiqueta
    Friend WithEvents lblCodigo As mControles.etiqueta
    Friend WithEvents dataChofer As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdEditar As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents cmdAñadir As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents cmdEliminar As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents cmdGrabar As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents cmdCancelar As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Etiqueta3 As mControles.etiqueta
    Friend WithEvents cmdCerrar As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents txtplaca As System.Windows.Forms.TextBox
    Friend WithEvents Etiqueta4 As mControles.etiqueta
    Friend WithEvents txtmarca As System.Windows.Forms.TextBox
    Friend WithEvents Etiqueta2 As mControles.etiqueta
    Friend WithEvents txtLicencia As System.Windows.Forms.TextBox
    Friend WithEvents Etiqueta1 As mControles.etiqueta

End Class
