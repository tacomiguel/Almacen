<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class repComisiones
    Inherits cefe.baseReporte

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(repComisiones))
        Me.cboMes = New System.Windows.Forms.ComboBox
        Me.cboAnno = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cboVendedor = New System.Windows.Forms.ComboBox
        Me.chkVendedor = New System.Windows.Forms.CheckBox
        Me.cmdCerrar = New DevComponents.DotNetBar.ButtonX
        Me.cmdImprimir = New DevComponents.DotNetBar.ButtonX
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboMes
        '
        Me.cboMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMes.FormattingEnabled = True
        Me.cboMes.Items.AddRange(New Object() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Setiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.cboMes.Location = New System.Drawing.Point(49, 21)
        Me.cboMes.Name = "cboMes"
        Me.cboMes.Size = New System.Drawing.Size(114, 24)
        Me.cboMes.TabIndex = 0
        '
        'cboAnno
        '
        Me.cboAnno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAnno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAnno.FormattingEnabled = True
        Me.cboAnno.Items.AddRange(New Object() {"2010", "2011", "2012", "2013", "2014", "2015"})
        Me.cboAnno.Location = New System.Drawing.Point(210, 21)
        Me.cboAnno.Name = "cboAnno"
        Me.cboAnno.Size = New System.Drawing.Size(74, 24)
        Me.cboAnno.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(10, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Mes"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(173, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Año"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cboAnno)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cboMes)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(8, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(292, 55)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccione Fecha del Reporte"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cboVendedor)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox2.Location = New System.Drawing.Point(8, 68)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(292, 52)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Vendedor"
        '
        'cboVendedor
        '
        Me.cboVendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboVendedor.Enabled = False
        Me.cboVendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboVendedor.FormattingEnabled = True
        Me.cboVendedor.Items.AddRange(New Object() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Setiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.cboVendedor.Location = New System.Drawing.Point(11, 19)
        Me.cboVendedor.Name = "cboVendedor"
        Me.cboVendedor.Size = New System.Drawing.Size(271, 24)
        Me.cboVendedor.TabIndex = 1
        '
        'chkVendedor
        '
        Me.chkVendedor.AutoSize = True
        Me.chkVendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkVendedor.Location = New System.Drawing.Point(8, 138)
        Me.chkVendedor.Name = "chkVendedor"
        Me.chkVendedor.Size = New System.Drawing.Size(106, 20)
        Me.chkVendedor.TabIndex = 8
        Me.chkVendedor.Text = "x Vendedor"
        Me.chkVendedor.UseVisualStyleBackColor = True
        '
        'cmdCerrar
        '
        Me.cmdCerrar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdCerrar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCerrar.Image = Global.cefe.My.Resources.Resources.CLOSE22
        Me.cmdCerrar.Location = New System.Drawing.Point(219, 126)
        Me.cmdCerrar.Name = "cmdCerrar"
        Me.cmdCerrar.Size = New System.Drawing.Size(81, 34)
        Me.cmdCerrar.TabIndex = 10
        Me.cmdCerrar.Text = "Cerrar"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdImprimir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdImprimir.Image = Global.cefe.My.Resources.Resources.print_preview
        Me.cmdImprimir.Location = New System.Drawing.Point(129, 126)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(84, 34)
        Me.cmdImprimir.TabIndex = 9
        Me.cmdImprimir.Text = "Imprimir"
        '
        'repComisiones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(308, 169)
        Me.Controls.Add(Me.cmdCerrar)
        Me.Controls.Add(Me.cmdImprimir)
        Me.Controls.Add(Me.chkVendedor)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "repComisiones"
        Me.Text = "Consulta y Reporte: COMISIONES"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboMes As System.Windows.Forms.ComboBox
    Friend WithEvents cboAnno As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cboVendedor As System.Windows.Forms.ComboBox
    Friend WithEvents chkVendedor As System.Windows.Forms.CheckBox
    Friend WithEvents cmdCerrar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmdImprimir As DevComponents.DotNetBar.ButtonX

End Class
