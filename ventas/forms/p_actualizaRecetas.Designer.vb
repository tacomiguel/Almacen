<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class p_actualizaRecetas
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(p_actualizaRecetas))
        Me.grupoDetalle = New System.Windows.Forms.GroupBox
        Me.cmdAñadir = New DevExpress.DXCore.Controls.XtraEditors.SimpleButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.optProveedor = New System.Windows.Forms.RadioButton
        Me.optDocumento = New System.Windows.Forms.RadioButton
        Me.optRegistro = New System.Windows.Forms.RadioButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.SimpleButton1 = New DevExpress.DXCore.Controls.XtraEditors.SimpleButton
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.TextBoxX1 = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.DataGridViewX2 = New DevComponents.DotNetBar.Controls.DataGridViewX
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX
        Me.txtBuscarInsumo = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.dataInsumo = New DevComponents.DotNetBar.Controls.DataGridViewX
        Me.DataGridViewX1 = New DevComponents.DotNetBar.Controls.DataGridViewX
        Me.cboAlmacen = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.grupoDetalle.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridViewX2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataInsumo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grupoDetalle
        '
        Me.grupoDetalle.Controls.Add(Me.cmdAñadir)
        Me.grupoDetalle.Controls.Add(Me.GroupBox2)
        Me.grupoDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupoDetalle.ForeColor = System.Drawing.Color.Maroon
        Me.grupoDetalle.Location = New System.Drawing.Point(21, 27)
        Me.grupoDetalle.Name = "grupoDetalle"
        Me.grupoDetalle.Size = New System.Drawing.Size(187, 223)
        Me.grupoDetalle.TabIndex = 4
        Me.grupoDetalle.TabStop = False
        Me.grupoDetalle.Text = "Actualizar Costo de Recetas"
        '
        'cmdAñadir
        '
        Me.cmdAñadir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmdAñadir.Appearance.Options.UseFont = True
        Me.cmdAñadir.Image = Global.cefe.My.Resources.Resources.ok22
        Me.cmdAñadir.ImageLocation = DevExpress.DXCore.Controls.XtraEditors.ImageLocation.TopCenter
        Me.cmdAñadir.Location = New System.Drawing.Point(28, 145)
        Me.cmdAñadir.LookAndFeel.SkinName = "iMaginary"
        Me.cmdAñadir.Name = "cmdAñadir"
        Me.cmdAñadir.Size = New System.Drawing.Size(127, 56)
        Me.cmdAñadir.TabIndex = 137
        Me.cmdAñadir.Text = "Iniciar Actualización"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.optProveedor)
        Me.GroupBox2.Controls.Add(Me.optDocumento)
        Me.GroupBox2.Controls.Add(Me.optRegistro)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(25, 27)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(135, 97)
        Me.GroupBox2.TabIndex = 45
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "En Base a:"
        '
        'optProveedor
        '
        Me.optProveedor.AutoSize = True
        Me.optProveedor.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optProveedor.ForeColor = System.Drawing.Color.Black
        Me.optProveedor.Location = New System.Drawing.Point(10, 44)
        Me.optProveedor.Name = "optProveedor"
        Me.optProveedor.Size = New System.Drawing.Size(115, 18)
        Me.optProveedor.TabIndex = 3
        Me.optProveedor.Text = "Costo Promedio"
        Me.optProveedor.UseVisualStyleBackColor = True
        '
        'optDocumento
        '
        Me.optDocumento.AutoSize = True
        Me.optDocumento.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optDocumento.ForeColor = System.Drawing.Color.Black
        Me.optDocumento.Location = New System.Drawing.Point(10, 67)
        Me.optDocumento.Name = "optDocumento"
        Me.optDocumento.Size = New System.Drawing.Size(96, 18)
        Me.optDocumento.TabIndex = 1
        Me.optDocumento.Text = "Ultimo Costo"
        Me.optDocumento.UseVisualStyleBackColor = True
        '
        'optRegistro
        '
        Me.optRegistro.AutoSize = True
        Me.optRegistro.Checked = True
        Me.optRegistro.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optRegistro.ForeColor = System.Drawing.Color.Black
        Me.optRegistro.Location = New System.Drawing.Point(10, 21)
        Me.optRegistro.Name = "optRegistro"
        Me.optRegistro.Size = New System.Drawing.Size(120, 18)
        Me.optRegistro.TabIndex = 0
        Me.optRegistro.TabStop = True
        Me.optRegistro.Text = "Costo de Insumo"
        Me.optRegistro.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.SimpleButton1)
        Me.GroupBox1.Controls.Add(Me.LabelX1)
        Me.GroupBox1.Controls.Add(Me.TextBoxX1)
        Me.GroupBox1.Controls.Add(Me.DataGridViewX2)
        Me.GroupBox1.Controls.Add(Me.LabelX3)
        Me.GroupBox1.Controls.Add(Me.txtBuscarInsumo)
        Me.GroupBox1.Controls.Add(Me.dataInsumo)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(230, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(492, 262)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cambio de Insumo"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Image = Global.cefe.My.Resources.Resources.ok22
        Me.SimpleButton1.ImageLocation = DevExpress.DXCore.Controls.XtraEditors.ImageLocation.MiddleLeft
        Me.SimpleButton1.Location = New System.Drawing.Point(338, 132)
        Me.SimpleButton1.LookAndFeel.SkinName = "iMaginary"
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(143, 30)
        Me.SimpleButton1.TabIndex = 138
        Me.SimpleButton1.Text = "Iniciar Remplazo"
        '
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        Me.LabelX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.ForeColor = System.Drawing.Color.Black
        Me.LabelX1.Location = New System.Drawing.Point(11, 143)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(72, 16)
        Me.LabelX1.TabIndex = 134
        Me.LabelX1.Text = "Remplazar x"
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Center
        Me.LabelX1.WordWrap = True
        '
        'TextBoxX1
        '
        '
        '
        '
        Me.TextBoxX1.Border.Class = "TextBoxBorder"
        Me.TextBoxX1.FocusHighlightEnabled = True
        Me.TextBoxX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxX1.Location = New System.Drawing.Point(99, 141)
        Me.TextBoxX1.Name = "TextBoxX1"
        Me.TextBoxX1.Size = New System.Drawing.Size(227, 21)
        Me.TextBoxX1.TabIndex = 133
        '
        'DataGridViewX2
        '
        Me.DataGridViewX2.AllowUserToAddRows = False
        Me.DataGridViewX2.AllowUserToDeleteRows = False
        Me.DataGridViewX2.AllowUserToResizeColumns = False
        Me.DataGridViewX2.AllowUserToResizeRows = False
        Me.DataGridViewX2.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridViewX2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridViewX2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DataGridViewX2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewX2.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewX2.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.DataGridViewX2.Location = New System.Drawing.Point(11, 164)
        Me.DataGridViewX2.MultiSelect = False
        Me.DataGridViewX2.Name = "DataGridViewX2"
        Me.DataGridViewX2.RowHeadersVisible = False
        Me.DataGridViewX2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridViewX2.SelectAllSignVisible = False
        Me.DataGridViewX2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewX2.ShowEditingIcon = False
        Me.DataGridViewX2.Size = New System.Drawing.Size(470, 90)
        Me.DataGridViewX2.TabIndex = 132
        '
        'LabelX3
        '
        Me.LabelX3.AutoSize = True
        Me.LabelX3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.ForeColor = System.Drawing.Color.Black
        Me.LabelX3.Location = New System.Drawing.Point(11, 19)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(82, 16)
        Me.LabelX3.TabIndex = 131
        Me.LabelX3.Text = "Insumo Actual"
        Me.LabelX3.TextAlignment = System.Drawing.StringAlignment.Center
        Me.LabelX3.WordWrap = True
        '
        'txtBuscarInsumo
        '
        '
        '
        '
        Me.txtBuscarInsumo.Border.Class = "TextBoxBorder"
        Me.txtBuscarInsumo.FocusHighlightEnabled = True
        Me.txtBuscarInsumo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscarInsumo.Location = New System.Drawing.Point(99, 17)
        Me.txtBuscarInsumo.Name = "txtBuscarInsumo"
        Me.txtBuscarInsumo.Size = New System.Drawing.Size(227, 21)
        Me.txtBuscarInsumo.TabIndex = 130
        '
        'dataInsumo
        '
        Me.dataInsumo.AllowUserToAddRows = False
        Me.dataInsumo.AllowUserToDeleteRows = False
        Me.dataInsumo.AllowUserToResizeColumns = False
        Me.dataInsumo.AllowUserToResizeRows = False
        Me.dataInsumo.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dataInsumo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dataInsumo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.dataInsumo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataInsumo.DefaultCellStyle = DataGridViewCellStyle2
        Me.dataInsumo.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dataInsumo.Location = New System.Drawing.Point(11, 40)
        Me.dataInsumo.MultiSelect = False
        Me.dataInsumo.Name = "dataInsumo"
        Me.dataInsumo.RowHeadersVisible = False
        Me.dataInsumo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dataInsumo.SelectAllSignVisible = False
        Me.dataInsumo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataInsumo.ShowEditingIcon = False
        Me.dataInsumo.Size = New System.Drawing.Size(470, 90)
        Me.dataInsumo.TabIndex = 8
        '
        'DataGridViewX1
        '
        Me.DataGridViewX1.AllowUserToAddRows = False
        Me.DataGridViewX1.AllowUserToDeleteRows = False
        Me.DataGridViewX1.AllowUserToResizeColumns = False
        Me.DataGridViewX1.AllowUserToResizeRows = False
        Me.DataGridViewX1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridViewX1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewX1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewX1.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewX1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridViewX1.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.DataGridViewX1.Location = New System.Drawing.Point(0, 280)
        Me.DataGridViewX1.MultiSelect = False
        Me.DataGridViewX1.Name = "DataGridViewX1"
        Me.DataGridViewX1.ReadOnly = True
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewX1.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewX1.RowHeadersVisible = False
        Me.DataGridViewX1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridViewX1.SelectAllSignVisible = False
        Me.DataGridViewX1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewX1.ShowEditingIcon = False
        Me.DataGridViewX1.Size = New System.Drawing.Size(734, 151)
        Me.DataGridViewX1.StandardTab = True
        Me.DataGridViewX1.TabIndex = 6
        Me.DataGridViewX1.TabStop = False
        '
        'cboAlmacen
        '
        Me.cboAlmacen.DisplayMember = "Text"
        Me.cboAlmacen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboAlmacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAlmacen.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAlmacen.ForeColor = System.Drawing.Color.SteelBlue
        Me.cboAlmacen.FormattingEnabled = True
        Me.cboAlmacen.ItemHeight = 16
        Me.cboAlmacen.Location = New System.Drawing.Point(21, 12)
        Me.cboAlmacen.Name = "cboAlmacen"
        Me.cboAlmacen.Size = New System.Drawing.Size(195, 22)
        Me.cboAlmacen.TabIndex = 7
        Me.cboAlmacen.WatermarkColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'p_actualizaRecetas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(734, 431)
        Me.Controls.Add(Me.cboAlmacen)
        Me.Controls.Add(Me.DataGridViewX1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grupoDetalle)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "p_actualizaRecetas"
        Me.Text = "Proceso: ACTUALIZACION DE COSTO DE RECETAS y CAMBIO DE INSUMOS"
        Me.grupoDetalle.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridViewX2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataInsumo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grupoDetalle As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents optProveedor As System.Windows.Forms.RadioButton
    Friend WithEvents optDocumento As System.Windows.Forms.RadioButton
    Friend WithEvents optRegistro As System.Windows.Forms.RadioButton
    Friend WithEvents cmdAñadir As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dataInsumo As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtBuscarInsumo As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents DataGridViewX1 As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents SimpleButton1 As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TextBoxX1 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents DataGridViewX2 As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents cboAlmacen As DevComponents.DotNetBar.Controls.ComboBoxEx

End Class
