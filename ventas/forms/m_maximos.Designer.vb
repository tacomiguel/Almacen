<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class m_maximos
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(m_maximos))
        Me.cboAlmacen = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.optDescripcion = New System.Windows.Forms.RadioButton()
        Me.optCodigo = New System.Windows.Forms.RadioButton()
        Me.txtBuscar = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.dataDetalle = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.barraProgreso = New System.Windows.Forms.ProgressBar()
        Me.cboArea = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.cmdActualizar = New DevExpress.DXCore.Controls.XtraEditors.SimpleButton()
        Me.cmdImprimir = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.chkarea = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.chkProduccion = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboAlmacen
        '
        Me.cboAlmacen.DisplayMember = "Text"
        Me.cboAlmacen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboAlmacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAlmacen.FocusHighlightColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.cboAlmacen.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAlmacen.ForeColor = System.Drawing.Color.Black
        Me.cboAlmacen.FormattingEnabled = True
        Me.cboAlmacen.ItemHeight = 16
        Me.cboAlmacen.Location = New System.Drawing.Point(393, 12)
        Me.cboAlmacen.Name = "cboAlmacen"
        Me.cboAlmacen.Size = New System.Drawing.Size(169, 22)
        Me.cboAlmacen.TabIndex = 2
        Me.cboAlmacen.WatermarkColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optDescripcion)
        Me.GroupBox1.Controls.Add(Me.optCodigo)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(9, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(187, 34)
        Me.GroupBox1.TabIndex = 131
        Me.GroupBox1.TabStop = False
        '
        'optDescripcion
        '
        Me.optDescripcion.AutoSize = True
        Me.optDescripcion.Checked = True
        Me.optDescripcion.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optDescripcion.ForeColor = System.Drawing.Color.Black
        Me.optDescripcion.Location = New System.Drawing.Point(70, 11)
        Me.optDescripcion.Name = "optDescripcion"
        Me.optDescripcion.Size = New System.Drawing.Size(90, 18)
        Me.optDescripcion.TabIndex = 1
        Me.optDescripcion.TabStop = True
        Me.optDescripcion.Text = "Descripción"
        Me.optDescripcion.UseVisualStyleBackColor = True
        '
        'optCodigo
        '
        Me.optCodigo.AutoSize = True
        Me.optCodigo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optCodigo.ForeColor = System.Drawing.Color.Black
        Me.optCodigo.Location = New System.Drawing.Point(7, 11)
        Me.optCodigo.Name = "optCodigo"
        Me.optCodigo.Size = New System.Drawing.Size(64, 18)
        Me.optCodigo.TabIndex = 0
        Me.optCodigo.Text = "Código"
        Me.optCodigo.UseVisualStyleBackColor = True
        '
        'txtBuscar
        '
        '
        '
        '
        Me.txtBuscar.Border.Class = "TextBoxBorder"
        Me.txtBuscar.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtBuscar.FocusHighlightColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.txtBuscar.FocusHighlightEnabled = True
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(9, 43)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(173, 21)
        Me.txtBuscar.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.cefe.My.Resources.Resources.buscar18
        Me.PictureBox1.Location = New System.Drawing.Point(178, 45)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(18, 18)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 132
        Me.PictureBox1.TabStop = False
        '
        'LabelX2
        '
        Me.LabelX2.AutoSize = True
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.ForeColor = System.Drawing.Color.Maroon
        Me.LabelX2.Location = New System.Drawing.Point(341, 14)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(51, 16)
        Me.LabelX2.TabIndex = 136
        Me.LabelX2.Text = "Almacén"
        Me.LabelX2.TextAlignment = System.Drawing.StringAlignment.Center
        Me.LabelX2.WordWrap = True
        '
        'dataDetalle
        '
        Me.dataDetalle.AllowUserToAddRows = False
        Me.dataDetalle.AllowUserToDeleteRows = False
        Me.dataDetalle.AllowUserToResizeColumns = False
        Me.dataDetalle.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dataDetalle.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dataDetalle.BackgroundColor = System.Drawing.Color.White
        Me.dataDetalle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataDetalle.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dataDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataDetalle.DefaultCellStyle = DataGridViewCellStyle3
        Me.dataDetalle.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dataDetalle.Location = New System.Drawing.Point(9, 90)
        Me.dataDetalle.Name = "dataDetalle"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataDetalle.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dataDetalle.RowHeadersVisible = False
        Me.dataDetalle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dataDetalle.SelectAllSignVisible = False
        Me.dataDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dataDetalle.ShowEditingIcon = False
        Me.dataDetalle.Size = New System.Drawing.Size(633, 398)
        Me.dataDetalle.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(2, 74)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(652, 10)
        Me.GroupBox3.TabIndex = 138
        Me.GroupBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.cefe.My.Resources.Resources.down22
        Me.PictureBox2.Location = New System.Drawing.Point(621, 68)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(21, 16)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'barraProgreso
        '
        Me.barraProgreso.Location = New System.Drawing.Point(119, 246)
        Me.barraProgreso.Name = "barraProgreso"
        Me.barraProgreso.Size = New System.Drawing.Size(406, 24)
        Me.barraProgreso.TabIndex = 139
        Me.barraProgreso.Visible = False
        '
        'cboArea
        '
        Me.cboArea.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboArea.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cboArea.DisplayMember = "Text"
        Me.cboArea.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboArea.Enabled = False
        Me.cboArea.FocusHighlightColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.cboArea.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboArea.ForeColor = System.Drawing.Color.Black
        Me.cboArea.FormattingEnabled = True
        Me.cboArea.ItemHeight = 16
        Me.cboArea.Location = New System.Drawing.Point(393, 39)
        Me.cboArea.Name = "cboArea"
        Me.cboArea.Size = New System.Drawing.Size(169, 22)
        Me.cboArea.TabIndex = 140
        Me.cboArea.WatermarkColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'cmdActualizar
        '
        Me.cmdActualizar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmdActualizar.Appearance.Options.UseFont = True
        Me.cmdActualizar.Image = CType(resources.GetObject("cmdActualizar.Image"), System.Drawing.Image)
        Me.cmdActualizar.ImageLocation = DevExpress.DXCore.Controls.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdActualizar.Location = New System.Drawing.Point(23, 109)
        Me.cmdActualizar.LookAndFeel.SkinName = "iMaginary"
        Me.cmdActualizar.Name = "cmdActualizar"
        Me.cmdActualizar.Size = New System.Drawing.Size(146, 33)
        Me.cmdActualizar.TabIndex = 137
        Me.cmdActualizar.Text = "Actualizar Artículos"
        Me.cmdActualizar.Visible = False
        '
        'cmdImprimir
        '
        Me.cmdImprimir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdImprimir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdImprimir.Image = Global.cefe.My.Resources.Resources.print_preview
        Me.cmdImprimir.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.cmdImprimir.Location = New System.Drawing.Point(577, 10)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(41, 35)
        Me.cmdImprimir.TabIndex = 134
        '
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.ForeColor = System.Drawing.Color.Maroon
        Me.LabelX1.Location = New System.Drawing.Point(341, 39)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(29, 16)
        Me.LabelX1.TabIndex = 141
        Me.LabelX1.Text = "Area"
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Center
        Me.LabelX1.WordWrap = True
        '
        'chkarea
        '
        Me.chkarea.AutoSize = True
        '
        '
        '
        Me.chkarea.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chkarea.Location = New System.Drawing.Point(319, 40)
        Me.chkarea.Name = "chkarea"
        Me.chkarea.Size = New System.Drawing.Size(26, 15)
        Me.chkarea.TabIndex = 154
        Me.chkarea.Text = "."
        '
        'chkProduccion
        '
        Me.chkProduccion.AutoSize = True
        '
        '
        '
        Me.chkProduccion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chkProduccion.Checked = True
        Me.chkProduccion.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkProduccion.CheckValue = "Y"
        Me.chkProduccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkProduccion.Location = New System.Drawing.Point(496, 66)
        Me.chkProduccion.Name = "chkProduccion"
        Me.chkProduccion.Size = New System.Drawing.Size(66, 15)
        Me.chkProduccion.TabIndex = 155
        Me.chkProduccion.Text = "Insumos"
        '
        'm_maximos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(654, 500)
        Me.Controls.Add(Me.chkProduccion)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.cmdImprimir)
        Me.Controls.Add(Me.cboArea)
        Me.Controls.Add(Me.cmdActualizar)
        Me.Controls.Add(Me.barraProgreso)
        Me.Controls.Add(Me.cboAlmacen)
        Me.Controls.Add(Me.dataDetalle)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.chkarea)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "m_maximos"
        Me.Text = "Mantenimiento: MAXIMOS Y MINIMOS x AREA"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboAlmacen As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents optDescripcion As System.Windows.Forms.RadioButton
    Friend WithEvents optCodigo As System.Windows.Forms.RadioButton
    Friend WithEvents txtBuscar As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dataDetalle As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents barraProgreso As System.Windows.Forms.ProgressBar
    Friend WithEvents cboArea As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cmdActualizar As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents cmdImprimir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents chkarea As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chkProduccion As DevComponents.DotNetBar.Controls.CheckBoxX

End Class
