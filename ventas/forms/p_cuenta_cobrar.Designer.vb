<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class p_cuenta_cobrar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(p_cuenta_cobrar))
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.datacuenta = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtProgramar = New System.Windows.Forms.TextBox()
        Me.dtpProgramar = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdProgramar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtOperacion = New System.Windows.Forms.TextBox()
        Me.txtAmortizar = New System.Windows.Forms.TextBox()
        Me.dtpAmortizar = New System.Windows.Forms.DateTimePicker()
        Me.cmdAmortizar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmdImprimir = New DevComponents.DotNetBar.ButtonX()
        Me.optctacobrada = New System.Windows.Forms.RadioButton()
        Me.optctaxcobrar = New System.Windows.Forms.RadioButton()
        Me.GroupBox5.SuspendLayout()
        CType(Me.datacuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Maroon
        Me.Label12.Location = New System.Drawing.Point(7, 10)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(175, 19)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "CUENTAS x COBRAR"
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox5.Controls.Add(Me.datacuenta)
        Me.GroupBox5.Controls.Add(Me.PictureBox1)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Location = New System.Drawing.Point(16, 12)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(900, 396)
        Me.GroupBox5.TabIndex = 19
        Me.GroupBox5.TabStop = False
        '
        'datacuenta
        '
        Me.datacuenta.AllowUserToAddRows = False
        Me.datacuenta.AllowUserToDeleteRows = False
        Me.datacuenta.AllowUserToResizeColumns = False
        Me.datacuenta.AllowUserToResizeRows = False
        Me.datacuenta.BackgroundColor = System.Drawing.Color.White
        Me.datacuenta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datacuenta.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.datacuenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datacuenta.DefaultCellStyle = DataGridViewCellStyle2
        Me.datacuenta.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.datacuenta.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.datacuenta.Location = New System.Drawing.Point(3, 32)
        Me.datacuenta.Name = "datacuenta"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datacuenta.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.datacuenta.RowHeadersVisible = False
        Me.datacuenta.SelectAllSignVisible = False
        Me.datacuenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datacuenta.ShowEditingIcon = False
        Me.datacuenta.Size = New System.Drawing.Size(894, 361)
        Me.datacuenta.TabIndex = 12
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.cefe.My.Resources.Resources.dollar22
        Me.PictureBox1.Location = New System.Drawing.Point(878, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 22)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtProgramar)
        Me.GroupBox1.Controls.Add(Me.dtpProgramar)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cmdProgramar)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 414)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(269, 70)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        '
        'txtProgramar
        '
        Me.txtProgramar.Enabled = False
        Me.txtProgramar.Location = New System.Drawing.Point(158, 42)
        Me.txtProgramar.Name = "txtProgramar"
        Me.txtProgramar.ReadOnly = True
        Me.txtProgramar.Size = New System.Drawing.Size(100, 20)
        Me.txtProgramar.TabIndex = 28
        '
        'dtpProgramar
        '
        Me.dtpProgramar.Checked = False
        Me.dtpProgramar.CustomFormat = "dd-MMMM-yyyy"
        Me.dtpProgramar.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpProgramar.Location = New System.Drawing.Point(158, 15)
        Me.dtpProgramar.MinDate = New Date(2010, 1, 1, 0, 0, 0, 0)
        Me.dtpProgramar.Name = "dtpProgramar"
        Me.dtpProgramar.ShowCheckBox = True
        Me.dtpProgramar.Size = New System.Drawing.Size(100, 20)
        Me.dtpProgramar.TabIndex = 27
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(110, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Monto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(110, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Fecha"
        '
        'cmdProgramar
        '
        Me.cmdProgramar.Enabled = False
        Me.cmdProgramar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdProgramar.Image = Global.cefe.My.Resources.Resources.applications22
        Me.cmdProgramar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdProgramar.Location = New System.Drawing.Point(9, 13)
        Me.cmdProgramar.Name = "cmdProgramar"
        Me.cmdProgramar.Size = New System.Drawing.Size(95, 49)
        Me.cmdProgramar.TabIndex = 24
        Me.cmdProgramar.Text = "     Programar     Cobro"
        Me.cmdProgramar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TxtOperacion)
        Me.GroupBox2.Controls.Add(Me.txtAmortizar)
        Me.GroupBox2.Controls.Add(Me.dtpAmortizar)
        Me.GroupBox2.Controls.Add(Me.cmdAmortizar)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(282, 414)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(425, 70)
        Me.GroupBox2.TabIndex = 27
        Me.GroupBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(261, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 13)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Operacion Bancaria:"
        '
        'TxtOperacion
        '
        Me.TxtOperacion.BackColor = System.Drawing.SystemColors.Control
        Me.TxtOperacion.Location = New System.Drawing.Point(264, 42)
        Me.TxtOperacion.Name = "TxtOperacion"
        Me.TxtOperacion.Size = New System.Drawing.Size(155, 20)
        Me.TxtOperacion.TabIndex = 29
        '
        'txtAmortizar
        '
        Me.txtAmortizar.Enabled = False
        Me.txtAmortizar.Location = New System.Drawing.Point(158, 42)
        Me.txtAmortizar.Name = "txtAmortizar"
        Me.txtAmortizar.ReadOnly = True
        Me.txtAmortizar.Size = New System.Drawing.Size(100, 20)
        Me.txtAmortizar.TabIndex = 28
        '
        'dtpAmortizar
        '
        Me.dtpAmortizar.Checked = False
        Me.dtpAmortizar.CustomFormat = "dd-MMMM-yyyy"
        Me.dtpAmortizar.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpAmortizar.Location = New System.Drawing.Point(158, 15)
        Me.dtpAmortizar.Name = "dtpAmortizar"
        Me.dtpAmortizar.ShowCheckBox = True
        Me.dtpAmortizar.Size = New System.Drawing.Size(100, 20)
        Me.dtpAmortizar.TabIndex = 27
        '
        'cmdAmortizar
        '
        Me.cmdAmortizar.Enabled = False
        Me.cmdAmortizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAmortizar.Image = Global.cefe.My.Resources.Resources.ok22
        Me.cmdAmortizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAmortizar.Location = New System.Drawing.Point(10, 13)
        Me.cmdAmortizar.Name = "cmdAmortizar"
        Me.cmdAmortizar.Size = New System.Drawing.Size(95, 49)
        Me.cmdAmortizar.TabIndex = 25
        Me.cmdAmortizar.Text = "      Amortizar      Cuenta"
        Me.cmdAmortizar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(110, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Monto"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(110, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Fecha"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.optctacobrada)
        Me.GroupBox3.Controls.Add(Me.cmdImprimir)
        Me.GroupBox3.Controls.Add(Me.optctaxcobrar)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(713, 414)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(214, 70)
        Me.GroupBox3.TabIndex = 32
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Imprimir"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdImprimir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdImprimir.Image = Global.cefe.My.Resources.Resources.print_preview
        Me.cmdImprimir.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.cmdImprimir.Location = New System.Drawing.Point(140, 18)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(63, 47)
        Me.cmdImprimir.TabIndex = 34
        Me.cmdImprimir.Text = "Imprimir"
        '
        'optctacobrada
        '
        Me.optctacobrada.AutoSize = True
        Me.optctacobrada.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optctacobrada.ForeColor = System.Drawing.Color.Black
        Me.optctacobrada.Location = New System.Drawing.Point(6, 41)
        Me.optctacobrada.Name = "optctacobrada"
        Me.optctacobrada.Size = New System.Drawing.Size(127, 18)
        Me.optctacobrada.TabIndex = 34
        Me.optctacobrada.TabStop = True
        Me.optctacobrada.Text = "Cuentas Cobradas"
        Me.optctacobrada.UseVisualStyleBackColor = True
        '
        'optctaxcobrar
        '
        Me.optctaxcobrar.AutoSize = True
        Me.optctaxcobrar.Checked = True
        Me.optctaxcobrar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optctaxcobrar.ForeColor = System.Drawing.Color.Black
        Me.optctaxcobrar.Location = New System.Drawing.Point(6, 21)
        Me.optctaxcobrar.Name = "optctaxcobrar"
        Me.optctaxcobrar.Size = New System.Drawing.Size(121, 18)
        Me.optctaxcobrar.TabIndex = 33
        Me.optctaxcobrar.TabStop = True
        Me.optctaxcobrar.Text = "Cuentas x Cobrar"
        Me.optctaxcobrar.UseVisualStyleBackColor = True
        '
        'p_cuenta_cobrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(934, 491)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "p_cuenta_cobrar"
        Me.Text = "Proceso: CUENTAS X COBRAR"
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.datacuenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdProgramar As System.Windows.Forms.Button
    Friend WithEvents cmdAmortizar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtProgramar As System.Windows.Forms.TextBox
    Friend WithEvents dtpProgramar As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtAmortizar As System.Windows.Forms.TextBox
    Friend WithEvents dtpAmortizar As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cmdImprimir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents datacuenta As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtOperacion As System.Windows.Forms.TextBox
    Friend WithEvents optctacobrada As System.Windows.Forms.RadioButton
    Friend WithEvents optctaxcobrar As System.Windows.Forms.RadioButton

End Class
