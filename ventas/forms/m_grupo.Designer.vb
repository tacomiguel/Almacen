<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class m_grupo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(m_grupo))
        Me.data = New System.Windows.Forms.DataGridView
        Me.grupoDetalle = New System.Windows.Forms.GroupBox
        Me.txtGrupo = New System.Windows.Forms.TextBox
        Me.txtCodigo = New System.Windows.Forms.TextBox
        Me.chkActivo = New System.Windows.Forms.CheckBox
        Me.Etiqueta2 = New mControles.etiqueta
        Me.Etiqueta1 = New mControles.etiqueta
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cmdEliminar = New System.Windows.Forms.Button
        Me.cmdEditar = New System.Windows.Forms.Button
        Me.cmdCancelar = New System.Windows.Forms.Button
        Me.cmdGrabar = New System.Windows.Forms.Button
        Me.cmdAñadir = New System.Windows.Forms.Button
        CType(Me.data, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupoDetalle.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'data
        '
        Me.data.AllowUserToAddRows = False
        Me.data.AllowUserToDeleteRows = False
        Me.data.AllowUserToResizeColumns = False
        Me.data.AllowUserToResizeRows = False
        Me.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.data.Location = New System.Drawing.Point(12, 12)
        Me.data.Name = "data"
        Me.data.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.data.Size = New System.Drawing.Size(429, 182)
        Me.data.TabIndex = 0
        '
        'grupoDetalle
        '
        Me.grupoDetalle.Controls.Add(Me.txtGrupo)
        Me.grupoDetalle.Controls.Add(Me.txtCodigo)
        Me.grupoDetalle.Controls.Add(Me.chkActivo)
        Me.grupoDetalle.Controls.Add(Me.Etiqueta2)
        Me.grupoDetalle.Controls.Add(Me.Etiqueta1)
        Me.grupoDetalle.Enabled = False
        Me.grupoDetalle.Location = New System.Drawing.Point(12, 193)
        Me.grupoDetalle.Name = "grupoDetalle"
        Me.grupoDetalle.Size = New System.Drawing.Size(429, 78)
        Me.grupoDetalle.TabIndex = 6
        Me.grupoDetalle.TabStop = False
        '
        'txtGrupo
        '
        Me.txtGrupo.BackColor = System.Drawing.SystemColors.Window
        Me.txtGrupo.Location = New System.Drawing.Point(75, 45)
        Me.txtGrupo.Name = "txtGrupo"
        Me.txtGrupo.Size = New System.Drawing.Size(348, 20)
        Me.txtGrupo.TabIndex = 10
        '
        'txtCodigo
        '
        Me.txtCodigo.BackColor = System.Drawing.SystemColors.Window
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(75, 19)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(48, 20)
        Me.txtCodigo.TabIndex = 9
        '
        'chkActivo
        '
        Me.chkActivo.AutoSize = True
        Me.chkActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkActivo.Location = New System.Drawing.Point(361, 21)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(62, 17)
        Me.chkActivo.TabIndex = 8
        Me.chkActivo.Text = "Activo"
        Me.chkActivo.UseVisualStyleBackColor = True
        '
        'Etiqueta2
        '
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Etiqueta2.BackColor = System.Drawing.Color.White
        Me.Etiqueta2.Location = New System.Drawing.Point(14, 45)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(49, 16)
        Me.Etiqueta2.TabIndex = 7
        Me.Etiqueta2.texto = "Grupo"
        '
        'Etiqueta1
        '
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Etiqueta1.BackColor = System.Drawing.Color.White
        Me.Etiqueta1.Location = New System.Drawing.Point(14, 19)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(55, 16)
        Me.Etiqueta1.TabIndex = 6
        Me.Etiqueta1.texto = "Código"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmdEliminar)
        Me.GroupBox2.Controls.Add(Me.cmdEditar)
        Me.GroupBox2.Controls.Add(Me.cmdCancelar)
        Me.GroupBox2.Controls.Add(Me.cmdGrabar)
        Me.GroupBox2.Controls.Add(Me.cmdAñadir)
        Me.GroupBox2.Location = New System.Drawing.Point(447, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(74, 266)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        '
        'cmdEliminar
        '
        Me.cmdEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEliminar.Image = Global.cefe.My.Resources.Resources.m_borrar
        Me.cmdEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdEliminar.Location = New System.Drawing.Point(6, 214)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(62, 45)
        Me.cmdEliminar.TabIndex = 4
        Me.cmdEliminar.Text = "Eliminar"
        Me.cmdEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdEliminar.UseVisualStyleBackColor = True
        '
        'cmdEditar
        '
        Me.cmdEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEditar.Image = Global.cefe.My.Resources.Resources.m_editar
        Me.cmdEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdEditar.Location = New System.Drawing.Point(6, 163)
        Me.cmdEditar.Name = "cmdEditar"
        Me.cmdEditar.Size = New System.Drawing.Size(62, 45)
        Me.cmdEditar.TabIndex = 3
        Me.cmdEditar.Text = "Editar"
        Me.cmdEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdEditar.UseVisualStyleBackColor = True
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Enabled = False
        Me.cmdCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Image = Global.cefe.My.Resources.Resources.m_cancelar
        Me.cmdCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdCancelar.Location = New System.Drawing.Point(6, 112)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(62, 45)
        Me.cmdCancelar.TabIndex = 2
        Me.cmdCancelar.Text = "Cancel"
        Me.cmdCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'cmdGrabar
        '
        Me.cmdGrabar.Enabled = False
        Me.cmdGrabar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGrabar.Image = Global.cefe.My.Resources.Resources.m_grabar
        Me.cmdGrabar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdGrabar.Location = New System.Drawing.Point(6, 61)
        Me.cmdGrabar.Name = "cmdGrabar"
        Me.cmdGrabar.Size = New System.Drawing.Size(62, 45)
        Me.cmdGrabar.TabIndex = 1
        Me.cmdGrabar.Text = "Grabar"
        Me.cmdGrabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdGrabar.UseVisualStyleBackColor = True
        '
        'cmdAñadir
        '
        Me.cmdAñadir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAñadir.Image = Global.cefe.My.Resources.Resources.m_añadir
        Me.cmdAñadir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdAñadir.Location = New System.Drawing.Point(6, 10)
        Me.cmdAñadir.Name = "cmdAñadir"
        Me.cmdAñadir.Size = New System.Drawing.Size(62, 45)
        Me.cmdAñadir.TabIndex = 0
        Me.cmdAñadir.Text = "Añadir"
        Me.cmdAñadir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdAñadir.UseVisualStyleBackColor = True
        '
        'm_grupo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(533, 283)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.grupoDetalle)
        Me.Controls.Add(Me.data)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "m_grupo"
        Me.Text = "Mantenimiento: GRUPO DE ARTICULOS"
        CType(Me.data, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupoDetalle.ResumeLayout(False)
        Me.grupoDetalle.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents data As System.Windows.Forms.DataGridView
    Friend WithEvents grupoDetalle As System.Windows.Forms.GroupBox
    Friend WithEvents txtGrupo As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents chkActivo As System.Windows.Forms.CheckBox
    Friend WithEvents Etiqueta2 As mControles.etiqueta
    Friend WithEvents Etiqueta1 As mControles.etiqueta
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdAñadir As System.Windows.Forms.Button
    Friend WithEvents cmdEliminar As System.Windows.Forms.Button
    Friend WithEvents cmdEditar As System.Windows.Forms.Button
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdGrabar As System.Windows.Forms.Button

End Class
