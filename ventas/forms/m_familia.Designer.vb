<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class m_familia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(m_familia))
        Me.datos = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmdEditar = New DevExpress.DXCore.Controls.XtraEditors.SimpleButton()
        Me.cmdAñadir = New DevExpress.DXCore.Controls.XtraEditors.SimpleButton()
        Me.cmdEliminar = New DevExpress.DXCore.Controls.XtraEditors.SimpleButton()
        Me.cmdGrabar = New DevExpress.DXCore.Controls.XtraEditors.SimpleButton()
        Me.cmdCancelar = New DevExpress.DXCore.Controls.XtraEditors.SimpleButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdCerrar = New DevExpress.DXCore.Controls.XtraEditors.SimpleButton()
        Me.grupoDetalle = New System.Windows.Forms.GroupBox()
        Me.txtFamilia = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.chkActivo = New System.Windows.Forms.CheckBox()
        Me.lblFamilia = New mControles.etiqueta()
        Me.lblCodigo = New mControles.etiqueta()
        CType(Me.datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grupoDetalle.SuspendLayout()
        Me.SuspendLayout()
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
        Me.datos.Location = New System.Drawing.Point(16, 15)
        Me.datos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.datos.MultiSelect = False
        Me.datos.Name = "datos"
        Me.datos.ReadOnly = True
        Me.datos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.datos.SelectAllSignVisible = False
        Me.datos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datos.ShowEditingIcon = False
        Me.datos.Size = New System.Drawing.Size(532, 332)
        Me.datos.TabIndex = 20
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmdEditar)
        Me.GroupBox2.Controls.Add(Me.cmdAñadir)
        Me.GroupBox2.Controls.Add(Me.cmdEliminar)
        Me.GroupBox2.Controls.Add(Me.cmdGrabar)
        Me.GroupBox2.Controls.Add(Me.cmdCancelar)
        Me.GroupBox2.Location = New System.Drawing.Point(556, 6)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(99, 327)
        Me.GroupBox2.TabIndex = 22
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
        Me.GroupBox1.Location = New System.Drawing.Point(556, 332)
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
        Me.grupoDetalle.Controls.Add(Me.txtFamilia)
        Me.grupoDetalle.Controls.Add(Me.txtCodigo)
        Me.grupoDetalle.Controls.Add(Me.chkActivo)
        Me.grupoDetalle.Controls.Add(Me.lblFamilia)
        Me.grupoDetalle.Controls.Add(Me.lblCodigo)
        Me.grupoDetalle.Location = New System.Drawing.Point(16, 354)
        Me.grupoDetalle.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grupoDetalle.Name = "grupoDetalle"
        Me.grupoDetalle.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grupoDetalle.Size = New System.Drawing.Size(532, 57)
        Me.grupoDetalle.TabIndex = 21
        Me.grupoDetalle.TabStop = False
        '
        'txtFamilia
        '
        Me.txtFamilia.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFamilia.Location = New System.Drawing.Point(216, 20)
        Me.txtFamilia.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtFamilia.MaxLength = 30
        Me.txtFamilia.Name = "txtFamilia"
        Me.txtFamilia.ReadOnly = True
        Me.txtFamilia.Size = New System.Drawing.Size(219, 22)
        Me.txtFamilia.TabIndex = 1
        '
        'txtCodigo
        '
        Me.txtCodigo.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(81, 21)
        Me.txtCodigo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCodigo.MaxLength = 2
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(48, 23)
        Me.txtCodigo.TabIndex = 0
        '
        'chkActivo
        '
        Me.chkActivo.AutoSize = True
        Me.chkActivo.Enabled = False
        Me.chkActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkActivo.Location = New System.Drawing.Point(445, 21)
        Me.chkActivo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(74, 21)
        Me.chkActivo.TabIndex = 2
        Me.chkActivo.Text = "Activo"
        Me.chkActivo.UseVisualStyleBackColor = True
        '
        'lblFamilia
        '
        Me.lblFamilia.AutoSize = True
        Me.lblFamilia.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.lblFamilia.BackColor = System.Drawing.Color.White
        Me.lblFamilia.Location = New System.Drawing.Point(141, 21)
        Me.lblFamilia.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.lblFamilia.Name = "lblFamilia"
        Me.lblFamilia.Size = New System.Drawing.Size(66, 19)
        Me.lblFamilia.TabIndex = 2
        Me.lblFamilia.TabStop = False
        Me.lblFamilia.texto = "Familia"
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.lblCodigo.BackColor = System.Drawing.Color.White
        Me.lblCodigo.Location = New System.Drawing.Point(9, 22)
        Me.lblCodigo.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(66, 19)
        Me.lblCodigo.TabIndex = 0
        Me.lblCodigo.TabStop = False
        Me.lblCodigo.texto = "Código"
        '
        'm_familia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(667, 422)
        Me.Controls.Add(Me.datos)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grupoDetalle)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "m_familia"
        Me.Text = "Mantenimiento: FAMILIAS"
        CType(Me.datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.grupoDetalle.ResumeLayout(False)
        Me.grupoDetalle.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents datos As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdEditar As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents cmdAñadir As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents cmdEliminar As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents cmdGrabar As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents cmdCancelar As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdCerrar As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents grupoDetalle As System.Windows.Forms.GroupBox
    Friend WithEvents txtFamilia As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents chkActivo As System.Windows.Forms.CheckBox
    Friend WithEvents lblFamilia As mControles.etiqueta
    Friend WithEvents lblCodigo As mControles.etiqueta

End Class
