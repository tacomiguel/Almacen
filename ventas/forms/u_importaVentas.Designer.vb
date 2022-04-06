<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class u_importaVentas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(u_importaVentas))
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX
        Me.txtArchivo = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.datos = New DevComponents.DotNetBar.Controls.DataGridViewX
        Me.cmdImportar = New DevComponents.DotNetBar.ButtonX
        Me.cmdCargar = New DevExpress.DXCore.Controls.XtraEditors.SimpleButton
        Me.cmdExaminar = New DevExpress.DXCore.Controls.XtraEditors.SimpleButton
        Me.lblProcesados = New DevComponents.DotNetBar.LabelX
        Me.cmdActualizarStock = New DevComponents.DotNetBar.ButtonX
        Me.lblProcesados2 = New DevComponents.DotNetBar.LabelX
        CType(Me.datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelX3
        '
        Me.LabelX3.AutoSize = True
        '
        '
        '
        Me.LabelX3.BackgroundStyle.Class = ""
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.ForeColor = System.Drawing.Color.Black
        Me.LabelX3.Location = New System.Drawing.Point(85, 7)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(105, 16)
        Me.LabelX3.TabIndex = 140
        Me.LabelX3.Text = "Archivo a Importar"
        Me.LabelX3.TextAlignment = System.Drawing.StringAlignment.Center
        Me.LabelX3.WordWrap = True
        '
        'txtArchivo
        '
        '
        '
        '
        Me.txtArchivo.Border.Class = "TextBoxBorder"
        Me.txtArchivo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtArchivo.FocusHighlightEnabled = True
        Me.txtArchivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArchivo.Location = New System.Drawing.Point(84, 26)
        Me.txtArchivo.Name = "txtArchivo"
        Me.txtArchivo.Size = New System.Drawing.Size(221, 21)
        Me.txtArchivo.TabIndex = 139
        '
        'datos
        '
        Me.datos.AllowUserToAddRows = False
        Me.datos.AllowUserToDeleteRows = False
        Me.datos.AllowUserToResizeColumns = False
        Me.datos.AllowUserToResizeRows = False
        Me.datos.BackgroundColor = System.Drawing.Color.White
        Me.datos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datos.DefaultCellStyle = DataGridViewCellStyle2
        Me.datos.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.datos.Location = New System.Drawing.Point(12, 53)
        Me.datos.MultiSelect = False
        Me.datos.Name = "datos"
        Me.datos.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datos.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.datos.RowHeadersVisible = False
        Me.datos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.datos.SelectAllSignVisible = False
        Me.datos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datos.ShowEditingIcon = False
        Me.datos.Size = New System.Drawing.Size(710, 344)
        Me.datos.TabIndex = 141
        '
        'cmdImportar
        '
        Me.cmdImportar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdImportar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdImportar.Enabled = False
        Me.cmdImportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdImportar.Location = New System.Drawing.Point(479, 6)
        Me.cmdImportar.Name = "cmdImportar"
        Me.cmdImportar.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(3)
        Me.cmdImportar.Size = New System.Drawing.Size(62, 41)
        Me.cmdImportar.TabIndex = 143
        Me.cmdImportar.Text = "Registrar Insumos"
        '
        'cmdCargar
        '
        Me.cmdCargar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmdCargar.Appearance.Options.UseFont = True
        Me.cmdCargar.Image = Global.cefe.My.Resources.Resources.ark22
        Me.cmdCargar.ImageLocation = DevExpress.DXCore.Controls.XtraEditors.ImageLocation.TopCenter
        Me.cmdCargar.Location = New System.Drawing.Point(311, 6)
        Me.cmdCargar.LookAndFeel.SkinName = "iMaginary"
        Me.cmdCargar.Name = "cmdCargar"
        Me.cmdCargar.Size = New System.Drawing.Size(83, 44)
        Me.cmdCargar.TabIndex = 142
        Me.cmdCargar.Text = "Cargar Datos"
        '
        'cmdExaminar
        '
        Me.cmdExaminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmdExaminar.Appearance.Options.UseFont = True
        Me.cmdExaminar.Image = Global.cefe.My.Resources.Resources.c_buscarD
        Me.cmdExaminar.ImageLocation = DevExpress.DXCore.Controls.XtraEditors.ImageLocation.TopCenter
        Me.cmdExaminar.Location = New System.Drawing.Point(12, 3)
        Me.cmdExaminar.LookAndFeel.SkinName = "iMaginary"
        Me.cmdExaminar.Name = "cmdExaminar"
        Me.cmdExaminar.Size = New System.Drawing.Size(66, 47)
        Me.cmdExaminar.TabIndex = 138
        Me.cmdExaminar.Text = "Examinar"
        '
        'lblProcesados
        '
        Me.lblProcesados.AutoSize = True
        '
        '
        '
        Me.lblProcesados.BackgroundStyle.Class = ""
        Me.lblProcesados.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblProcesados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProcesados.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblProcesados.Location = New System.Drawing.Point(407, 26)
        Me.lblProcesados.Name = "lblProcesados"
        Me.lblProcesados.Size = New System.Drawing.Size(67, 17)
        Me.lblProcesados.TabIndex = 147
        Me.lblProcesados.Text = "Porcentaje"
        Me.lblProcesados.TextAlignment = System.Drawing.StringAlignment.Center
        Me.lblProcesados.Visible = False
        Me.lblProcesados.WordWrap = True
        '
        'cmdActualizarStock
        '
        Me.cmdActualizarStock.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdActualizarStock.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdActualizarStock.Enabled = False
        Me.cmdActualizarStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdActualizarStock.Location = New System.Drawing.Point(660, 6)
        Me.cmdActualizarStock.Name = "cmdActualizarStock"
        Me.cmdActualizarStock.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(3)
        Me.cmdActualizarStock.Size = New System.Drawing.Size(62, 41)
        Me.cmdActualizarStock.TabIndex = 148
        Me.cmdActualizarStock.Text = "Actualizar Stock"
        '
        'lblProcesados2
        '
        Me.lblProcesados2.AutoSize = True
        '
        '
        '
        Me.lblProcesados2.BackgroundStyle.Class = ""
        Me.lblProcesados2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblProcesados2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProcesados2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblProcesados2.Location = New System.Drawing.Point(587, 28)
        Me.lblProcesados2.Name = "lblProcesados2"
        Me.lblProcesados2.Size = New System.Drawing.Size(67, 17)
        Me.lblProcesados2.TabIndex = 149
        Me.lblProcesados2.Text = "Porcentaje"
        Me.lblProcesados2.TextAlignment = System.Drawing.StringAlignment.Center
        Me.lblProcesados2.Visible = False
        Me.lblProcesados2.WordWrap = True
        '
        'u_importaVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(734, 408)
        Me.Controls.Add(Me.lblProcesados2)
        Me.Controls.Add(Me.cmdActualizarStock)
        Me.Controls.Add(Me.lblProcesados)
        Me.Controls.Add(Me.cmdImportar)
        Me.Controls.Add(Me.cmdCargar)
        Me.Controls.Add(Me.datos)
        Me.Controls.Add(Me.LabelX3)
        Me.Controls.Add(Me.txtArchivo)
        Me.Controls.Add(Me.cmdExaminar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "u_importaVentas"
        Me.Text = "Utilidad: IMPORTAR VENTAS DESDE PIXEL POINT"
        CType(Me.datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdExaminar As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtArchivo As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents datos As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents cmdCargar As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents cmdImportar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents lblProcesados As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmdActualizarStock As DevComponents.DotNetBar.ButtonX
    Friend WithEvents lblProcesados2 As DevComponents.DotNetBar.LabelX

End Class
