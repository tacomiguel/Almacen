<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class c_articulo_x_grupo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(c_articulo_x_grupo))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.RadioButton6 = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.optArticulo = New System.Windows.Forms.RadioButton
        Me.optGrupo = New System.Windows.Forms.RadioButton
        Me.dgsubgrupo = New System.Windows.Forms.DataGridView
        Me.txtBuscar = New System.Windows.Forms.TextBox
        Me.dgArticulos = New System.Windows.Forms.DataGridView
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton3 = New System.Windows.Forms.RadioButton
        Me.RadioButton4 = New System.Windows.Forms.RadioButton
        Me.RadioButton5 = New System.Windows.Forms.RadioButton
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.optsubgrupo = New System.Windows.Forms.RadioButton
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgsubgrupo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton6)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.optArticulo)
        Me.GroupBox1.Controls.Add(Me.optsubgrupo)
        Me.GroupBox1.Controls.Add(Me.optGrupo)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(122, 138)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar x"
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.Location = New System.Drawing.Point(6, 111)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(99, 17)
        Me.RadioButton6.TabIndex = 7
        Me.RadioButton6.Text = "Tipo Artículo"
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(6, 88)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(113, 17)
        Me.RadioButton1.TabIndex = 6
        Me.RadioButton1.Text = "Código Artículo"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'optArticulo
        '
        Me.optArticulo.AutoSize = True
        Me.optArticulo.Checked = True
        Me.optArticulo.Location = New System.Drawing.Point(6, 65)
        Me.optArticulo.Name = "optArticulo"
        Me.optArticulo.Size = New System.Drawing.Size(70, 17)
        Me.optArticulo.TabIndex = 5
        Me.optArticulo.TabStop = True
        Me.optArticulo.Text = "Artículo"
        Me.optArticulo.UseVisualStyleBackColor = True
        '
        'optGrupo
        '
        Me.optGrupo.AutoSize = True
        Me.optGrupo.Location = New System.Drawing.Point(6, 19)
        Me.optGrupo.Name = "optGrupo"
        Me.optGrupo.Size = New System.Drawing.Size(59, 17)
        Me.optGrupo.TabIndex = 3
        Me.optGrupo.Text = "Grupo"
        Me.optGrupo.UseVisualStyleBackColor = True
        '
        'dgsubgrupo
        '
        Me.dgsubgrupo.AllowUserToAddRows = False
        Me.dgsubgrupo.AllowUserToDeleteRows = False
        Me.dgsubgrupo.AllowUserToResizeColumns = False
        Me.dgsubgrupo.AllowUserToResizeRows = False
        Me.dgsubgrupo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgsubgrupo.Location = New System.Drawing.Point(151, 39)
        Me.dgsubgrupo.Name = "dgsubgrupo"
        Me.dgsubgrupo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgsubgrupo.Size = New System.Drawing.Size(303, 163)
        Me.dgsubgrupo.TabIndex = 5
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(12, 166)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(70, 20)
        Me.txtBuscar.TabIndex = 6
        '
        'dgArticulos
        '
        Me.dgArticulos.AllowUserToAddRows = False
        Me.dgArticulos.AllowUserToDeleteRows = False
        Me.dgArticulos.AllowUserToResizeColumns = False
        Me.dgArticulos.AllowUserToResizeRows = False
        Me.dgArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgArticulos.Location = New System.Drawing.Point(12, 208)
        Me.dgArticulos.Name = "dgArticulos"
        Me.dgArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgArticulos.Size = New System.Drawing.Size(773, 233)
        Me.dgArticulos.TabIndex = 8
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(151, 12)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(303, 21)
        Me.ComboBox1.TabIndex = 7
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioButton2)
        Me.GroupBox2.Controls.Add(Me.RadioButton3)
        Me.GroupBox2.Controls.Add(Me.RadioButton4)
        Me.GroupBox2.Controls.Add(Me.RadioButton5)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(531, 39)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(129, 113)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Imprimir"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(6, 88)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(117, 17)
        Me.RadioButton2.TabIndex = 6
        Me.RadioButton2.Text = "Tipo de Artículo"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(6, 65)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(70, 17)
        Me.RadioButton3.TabIndex = 5
        Me.RadioButton3.Text = "Artículo"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Checked = True
        Me.RadioButton4.Location = New System.Drawing.Point(6, 42)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(85, 17)
        Me.RadioButton4.TabIndex = 4
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "Sub Grupo"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(6, 19)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(59, 17)
        Me.RadioButton5.TabIndex = 3
        Me.RadioButton5.Text = "Grupo"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Image = Global.cefe.My.Resources.Resources.rExcel
        Me.Button3.Location = New System.Drawing.Point(711, 100)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(46, 39)
        Me.Button3.TabIndex = 11
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(711, 55)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(46, 39)
        Me.Button2.TabIndex = 10
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(88, 156)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(46, 39)
        Me.Button1.TabIndex = 4
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'optsubgrupo
        '
        Me.optsubgrupo.AutoSize = True
        Me.optsubgrupo.Location = New System.Drawing.Point(6, 42)
        Me.optsubgrupo.Name = "optsubgrupo"
        Me.optsubgrupo.Size = New System.Drawing.Size(85, 17)
        Me.optsubgrupo.TabIndex = 4
        Me.optsubgrupo.Text = "Sub Grupo"
        Me.optsubgrupo.UseVisualStyleBackColor = True
        '
        'c_articulo_x_grupo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(797, 453)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.dgArticulos)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.dgsubgrupo)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "c_articulo_x_grupo"
        Me.Text = "Consulta: Artículos x [Grupo-Tipo]"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgsubgrupo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents optGrupo As System.Windows.Forms.RadioButton
    Friend WithEvents optArticulo As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dgsubgrupo As System.Windows.Forms.DataGridView
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents dgArticulos As System.Windows.Forms.DataGridView
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents RadioButton6 As System.Windows.Forms.RadioButton
    Friend WithEvents optsubgrupo As System.Windows.Forms.RadioButton

End Class
