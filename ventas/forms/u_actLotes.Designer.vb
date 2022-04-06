<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class u_actLotes
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(u_actLotes))
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX
        Me.txtBuscar = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.cmdBuscar = New DevExpress.DXCore.Controls.XtraEditors.SimpleButton
        Me.dataProducto = New DevComponents.DotNetBar.Controls.DataGridViewX
        Me.dataSalidas = New DevComponents.DotNetBar.Controls.DataGridViewX
        Me.cmdSalidas = New DevExpress.DXCore.Controls.XtraEditors.SimpleButton
        Me.cmdActualiza = New DevExpress.DXCore.Controls.XtraEditors.SimpleButton
        Me.txtIngreso = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.dataCoherencia = New DevComponents.DotNetBar.Controls.DataGridViewX
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.cmdCoherencia = New DevExpress.DXCore.Controls.XtraEditors.SimpleButton
        CType(Me.dataProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataSalidas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataCoherencia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelX4
        '
        Me.LabelX4.AutoSize = True
        '
        '
        '
        Me.LabelX4.BackgroundStyle.Class = ""
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.ForeColor = System.Drawing.Color.Maroon
        Me.LabelX4.Location = New System.Drawing.Point(12, 15)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(145, 15)
        Me.LabelX4.TabIndex = 2
        Me.LabelX4.Text = "Ingrese Código de Producto"
        Me.LabelX4.WordWrap = True
        '
        'txtBuscar
        '
        '
        '
        '
        Me.txtBuscar.Border.Class = "TextBoxBorder"
        Me.txtBuscar.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtBuscar.FocusHighlightEnabled = True
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(163, 12)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(93, 21)
        Me.txtBuscar.TabIndex = 3
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBuscar.Appearance.Options.UseFont = True
        Me.cmdBuscar.Image = Global.cefe.My.Resources.Resources.folder_find18
        Me.cmdBuscar.ImageLocation = DevExpress.DXCore.Controls.XtraEditors.ImageLocation.MiddleRight
        Me.cmdBuscar.Location = New System.Drawing.Point(262, 5)
        Me.cmdBuscar.LookAndFeel.SkinName = "iMaginary"
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(78, 30)
        Me.cmdBuscar.TabIndex = 130
        Me.cmdBuscar.Text = "Buscar"
        '
        'dataProducto
        '
        Me.dataProducto.AllowUserToAddRows = False
        Me.dataProducto.AllowUserToDeleteRows = False
        Me.dataProducto.AllowUserToResizeColumns = False
        Me.dataProducto.AllowUserToResizeRows = False
        Me.dataProducto.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dataProducto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dataProducto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataProducto.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dataProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataProducto.DefaultCellStyle = DataGridViewCellStyle2
        Me.dataProducto.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dataProducto.Location = New System.Drawing.Point(2, 39)
        Me.dataProducto.MultiSelect = False
        Me.dataProducto.Name = "dataProducto"
        Me.dataProducto.RowHeadersVisible = False
        Me.dataProducto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dataProducto.SelectAllSignVisible = False
        Me.dataProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataProducto.ShowEditingIcon = False
        Me.dataProducto.Size = New System.Drawing.Size(878, 196)
        Me.dataProducto.TabIndex = 131
        '
        'dataSalidas
        '
        Me.dataSalidas.AllowUserToAddRows = False
        Me.dataSalidas.AllowUserToDeleteRows = False
        Me.dataSalidas.AllowUserToResizeColumns = False
        Me.dataSalidas.AllowUserToResizeRows = False
        Me.dataSalidas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dataSalidas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dataSalidas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataSalidas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dataSalidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataSalidas.DefaultCellStyle = DataGridViewCellStyle4
        Me.dataSalidas.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dataSalidas.Location = New System.Drawing.Point(2, 282)
        Me.dataSalidas.MultiSelect = False
        Me.dataSalidas.Name = "dataSalidas"
        Me.dataSalidas.RowHeadersVisible = False
        Me.dataSalidas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dataSalidas.SelectAllSignVisible = False
        Me.dataSalidas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataSalidas.ShowEditingIcon = False
        Me.dataSalidas.Size = New System.Drawing.Size(353, 265)
        Me.dataSalidas.TabIndex = 132
        '
        'cmdSalidas
        '
        Me.cmdSalidas.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSalidas.Appearance.Options.UseFont = True
        Me.cmdSalidas.Image = Global.cefe.My.Resources.Resources.nfs_mount22
        Me.cmdSalidas.ImageLocation = DevExpress.DXCore.Controls.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdSalidas.Location = New System.Drawing.Point(443, 5)
        Me.cmdSalidas.LookAndFeel.SkinName = "iMaginary"
        Me.cmdSalidas.Name = "cmdSalidas"
        Me.cmdSalidas.Size = New System.Drawing.Size(126, 30)
        Me.cmdSalidas.TabIndex = 133
        Me.cmdSalidas.Text = "Mostrar Salidas"
        '
        'cmdActualiza
        '
        Me.cmdActualiza.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdActualiza.Appearance.Options.UseFont = True
        Me.cmdActualiza.Image = Global.cefe.My.Resources.Resources.ok20
        Me.cmdActualiza.ImageLocation = DevExpress.DXCore.Controls.XtraEditors.ImageLocation.MiddleRight
        Me.cmdActualiza.Location = New System.Drawing.Point(244, 246)
        Me.cmdActualiza.LookAndFeel.SkinName = "iMaginary"
        Me.cmdActualiza.Name = "cmdActualiza"
        Me.cmdActualiza.Size = New System.Drawing.Size(131, 30)
        Me.cmdActualiza.TabIndex = 134
        Me.cmdActualiza.Text = "Actualizar Salidas"
        '
        'txtIngreso
        '
        '
        '
        '
        Me.txtIngreso.Border.Class = "TextBoxBorder"
        Me.txtIngreso.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtIngreso.FocusHighlightEnabled = True
        Me.txtIngreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIngreso.Location = New System.Drawing.Point(181, 252)
        Me.txtIngreso.Name = "txtIngreso"
        Me.txtIngreso.Size = New System.Drawing.Size(57, 21)
        Me.txtIngreso.TabIndex = 135
        '
        'dataCoherencia
        '
        Me.dataCoherencia.AllowUserToAddRows = False
        Me.dataCoherencia.AllowUserToDeleteRows = False
        Me.dataCoherencia.AllowUserToResizeColumns = False
        Me.dataCoherencia.AllowUserToResizeRows = False
        Me.dataCoherencia.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dataCoherencia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dataCoherencia.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataCoherencia.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dataCoherencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataCoherencia.DefaultCellStyle = DataGridViewCellStyle6
        Me.dataCoherencia.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dataCoherencia.Location = New System.Drawing.Point(361, 307)
        Me.dataCoherencia.MultiSelect = False
        Me.dataCoherencia.Name = "dataCoherencia"
        Me.dataCoherencia.RowHeadersVisible = False
        Me.dataCoherencia.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dataCoherencia.SelectAllSignVisible = False
        Me.dataCoherencia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataCoherencia.ShowEditingIcon = False
        Me.dataCoherencia.Size = New System.Drawing.Size(519, 234)
        Me.dataCoherencia.TabIndex = 136
        '
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        '
        '
        '
        Me.LabelX1.BackgroundStyle.Class = ""
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.ForeColor = System.Drawing.Color.Maroon
        Me.LabelX1.Location = New System.Drawing.Point(2, 253)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(173, 15)
        Me.LabelX1.TabIndex = 137
        Me.LabelX1.Text = "Ingreso a donde Transferir Salida"
        Me.LabelX1.WordWrap = True
        '
        'cmdCoherencia
        '
        Me.cmdCoherencia.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCoherencia.Appearance.Options.UseFont = True
        Me.cmdCoherencia.Image = Global.cefe.My.Resources.Resources.ok20
        Me.cmdCoherencia.ImageLocation = DevExpress.DXCore.Controls.XtraEditors.ImageLocation.MiddleRight
        Me.cmdCoherencia.Location = New System.Drawing.Point(666, 271)
        Me.cmdCoherencia.LookAndFeel.SkinName = "iMaginary"
        Me.cmdCoherencia.Name = "cmdCoherencia"
        Me.cmdCoherencia.Size = New System.Drawing.Size(214, 30)
        Me.cmdCoherencia.TabIndex = 138
        Me.cmdCoherencia.Text = "Verificar Coherencia de Datos"
        '
        'u_actLotes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(885, 553)
        Me.Controls.Add(Me.cmdCoherencia)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.dataCoherencia)
        Me.Controls.Add(Me.txtIngreso)
        Me.Controls.Add(Me.cmdActualiza)
        Me.Controls.Add(Me.cmdSalidas)
        Me.Controls.Add(Me.dataSalidas)
        Me.Controls.Add(Me.dataProducto)
        Me.Controls.Add(Me.cmdBuscar)
        Me.Controls.Add(Me.LabelX4)
        Me.Controls.Add(Me.txtBuscar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "u_actLotes"
        Me.Text = "Utilidades: ACTUALIZACION DE LOTES"
        CType(Me.dataProducto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataSalidas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataCoherencia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtBuscar As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents cmdBuscar As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents dataProducto As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents dataSalidas As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents cmdSalidas As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents cmdActualiza As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents txtIngreso As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents dataCoherencia As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmdCoherencia As DevExpress.DXCore.Controls.XtraEditors.SimpleButton

End Class
