<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.txtUsuario = New System.Windows.Forms.TextBox
        Me.txtClave = New System.Windows.Forms.TextBox
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.txtTC = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX
        Me.cmdCancelar = New DevComponents.DotNetBar.ButtonX
        Me.cmdContinuar = New DevComponents.DotNetBar.ButtonX
        Me.LblPeriodo = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Lbltipcambio = New System.Windows.Forms.Label
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(11, 32)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(176, 20)
        Me.txtUsuario.TabIndex = 1
        '
        'txtClave
        '
        Me.txtClave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClave.Location = New System.Drawing.Point(7, 77)
        Me.txtClave.Name = "txtClave"
        Me.txtClave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtClave.Size = New System.Drawing.Size(180, 20)
        Me.txtClave.TabIndex = 3
        '
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        '
        '
        '
        Me.LabelX1.BackgroundStyle.Class = ""
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.ForeColor = System.Drawing.Color.Black
        Me.LabelX1.Location = New System.Drawing.Point(13, 13)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(49, 16)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "Usuario:"
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.Class = ""
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.Location = New System.Drawing.Point(9, 10)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(51, 33)
        Me.LabelX3.TabIndex = 0
        Me.LabelX3.Text = "Tipo de Cambio"
        Me.LabelX3.TextAlignment = System.Drawing.StringAlignment.Center
        Me.LabelX3.WordWrap = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.PapayaWhip
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(12, 93)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(180, 100)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'txtTC
        '
        Me.txtTC.BackColor = System.Drawing.Color.SteelBlue
        Me.txtTC.ForeColor = System.Drawing.Color.Transparent
        Me.txtTC.Location = New System.Drawing.Point(10, 46)
        Me.txtTC.Name = "txtTC"
        Me.txtTC.ReadOnly = True
        Me.txtTC.Size = New System.Drawing.Size(49, 20)
        Me.txtTC.TabIndex = 1
        Me.txtTC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LabelX3)
        Me.GroupBox2.Controls.Add(Me.txtTC)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox2.Location = New System.Drawing.Point(-4, 34)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(70, 70)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LabelX4)
        Me.GroupBox1.Controls.Add(Me.LabelX1)
        Me.GroupBox1.Controls.Add(Me.txtUsuario)
        Me.GroupBox1.Controls.Add(Me.txtClave)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkGreen
        Me.GroupBox1.Location = New System.Drawing.Point(201, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(203, 109)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'LabelX4
        '
        Me.LabelX4.AutoSize = True
        '
        '
        '
        Me.LabelX4.BackgroundStyle.Class = ""
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.ForeColor = System.Drawing.Color.Black
        Me.LabelX4.Location = New System.Drawing.Point(9, 58)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(70, 16)
        Me.LabelX4.TabIndex = 2
        Me.LabelX4.Text = "Contraseña:"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdCancelar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground
        Me.cmdCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancelar.Image = Global.cefe.My.Resources.Resources.Error22
        Me.cmdCancelar.Location = New System.Drawing.Point(309, 171)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.cmdCancelar.Size = New System.Drawing.Size(98, 49)
        Me.cmdCancelar.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
        Me.cmdCancelar.TabIndex = 152
        Me.cmdCancelar.Text = "Cancelar"
        '
        'cmdContinuar
        '
        Me.cmdContinuar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdContinuar.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground
        Me.cmdContinuar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdContinuar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdContinuar.Image = Global.cefe.My.Resources.Resources.proveedor
        Me.cmdContinuar.Location = New System.Drawing.Point(201, 171)
        Me.cmdContinuar.Name = "cmdContinuar"
        Me.cmdContinuar.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.cmdContinuar.Size = New System.Drawing.Size(98, 49)
        Me.cmdContinuar.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
        Me.cmdContinuar.TabIndex = 1
        Me.cmdContinuar.Text = "Continuar"
        '
        'LblPeriodo
        '
        Me.LblPeriodo.AutoSize = True
        Me.LblPeriodo.BackColor = System.Drawing.Color.SteelBlue
        Me.LblPeriodo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPeriodo.ForeColor = System.Drawing.SystemColors.Control
        Me.LblPeriodo.Location = New System.Drawing.Point(12, 235)
        Me.LblPeriodo.Name = "LblPeriodo"
        Me.LblPeriodo.Size = New System.Drawing.Size(13, 13)
        Me.LblPeriodo.TabIndex = 153
        Me.LblPeriodo.Text = "-"
        Me.LblPeriodo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.SteelBlue
        Me.PictureBox1.Location = New System.Drawing.Point(-4, 233)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(420, 26)
        Me.PictureBox1.TabIndex = 154
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.SteelBlue
        Me.PictureBox3.Location = New System.Drawing.Point(-4, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(420, 46)
        Me.PictureBox3.TabIndex = 155
        Me.PictureBox3.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Font = New System.Drawing.Font("Papyrus", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(23, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(381, 30)
        Me.Label1.TabIndex = 156
        Me.Label1.Text = "Por Favor Ingrese Usuario y Contraseña"
        '
        'Lbltipcambio
        '
        Me.Lbltipcambio.AutoSize = True
        Me.Lbltipcambio.BackColor = System.Drawing.Color.SteelBlue
        Me.Lbltipcambio.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbltipcambio.ForeColor = System.Drawing.SystemColors.Control
        Me.Lbltipcambio.Location = New System.Drawing.Point(276, 235)
        Me.Lbltipcambio.Name = "Lbltipcambio"
        Me.Lbltipcambio.Size = New System.Drawing.Size(13, 13)
        Me.Lbltipcambio.TabIndex = 157
        Me.Lbltipcambio.Text = "-"
        Me.Lbltipcambio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(416, 257)
        Me.Controls.Add(Me.Lbltipcambio)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.LblPeriodo)
        Me.Controls.Add(Me.cmdContinuar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.Text = "Login"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtClave As System.Windows.Forms.TextBox
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents txtTC As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdCancelar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmdContinuar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LblPeriodo As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Lbltipcambio As System.Windows.Forms.Label

End Class
