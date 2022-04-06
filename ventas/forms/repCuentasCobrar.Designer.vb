<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class repCuentasCobrar
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(repCuentasCobrar))
        Me.grupoAlmacen = New System.Windows.Forms.GroupBox()
        Me.cboAlmacen = New System.Windows.Forms.ComboBox()
        Me.chkAlmacen = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dataDetalle = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.cboAnno = New System.Windows.Forms.ComboBox()
        Me.cboMes = New System.Windows.Forms.ComboBox()
        Me.chkDia = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.mcDia = New DevComponents.Editors.DateTimeAdv.MonthCalendarAdv()
        Me.grupo = New System.Windows.Forms.GroupBox()
        Me.cboGrupo = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.optProveedor = New System.Windows.Forms.RadioButton()
        Me.optProducto = New System.Windows.Forms.RadioButton()
        Me.optDocumento = New System.Windows.Forms.RadioButton()
        Me.optRegistro = New System.Windows.Forms.RadioButton()
        Me.cmdCerrar = New DevComponents.DotNetBar.ButtonX()
        Me.cmdImprimir = New DevComponents.DotNetBar.ButtonX()
        Me.grupoAlmacen.SuspendLayout()
        CType(Me.dataDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel1.SuspendLayout()
        Me.grupo.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'grupoAlmacen
        '
        Me.grupoAlmacen.Controls.Add(Me.cboAlmacen)
        Me.grupoAlmacen.Controls.Add(Me.chkAlmacen)
        Me.grupoAlmacen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupoAlmacen.ForeColor = System.Drawing.Color.Maroon
        Me.grupoAlmacen.Location = New System.Drawing.Point(297, 27)
        Me.grupoAlmacen.Name = "grupoAlmacen"
        Me.grupoAlmacen.Size = New System.Drawing.Size(272, 52)
        Me.grupoAlmacen.TabIndex = 84
        Me.grupoAlmacen.TabStop = False
        Me.grupoAlmacen.Text = "Almacén"
        '
        'cboAlmacen
        '
        Me.cboAlmacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAlmacen.Enabled = False
        Me.cboAlmacen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAlmacen.FormattingEnabled = True
        Me.cboAlmacen.Location = New System.Drawing.Point(29, 19)
        Me.cboAlmacen.Name = "cboAlmacen"
        Me.cboAlmacen.Size = New System.Drawing.Size(233, 24)
        Me.cboAlmacen.TabIndex = 1
        '
        'chkAlmacen
        '
        '
        '
        '
        Me.chkAlmacen.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chkAlmacen.Location = New System.Drawing.Point(7, 19)
        Me.chkAlmacen.Name = "chkAlmacen"
        Me.chkAlmacen.Size = New System.Drawing.Size(24, 23)
        Me.chkAlmacen.TabIndex = 51
        '
        'GroupBox3
        '
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(-14, 142)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1059, 10)
        Me.GroupBox3.TabIndex = 83
        Me.GroupBox3.TabStop = False
        '
        'dataDetalle
        '
        Me.dataDetalle.AllowUserToAddRows = False
        Me.dataDetalle.AllowUserToDeleteRows = False
        Me.dataDetalle.AllowUserToResizeColumns = False
        Me.dataDetalle.AllowUserToResizeRows = False
        Me.dataDetalle.BackgroundColor = System.Drawing.Color.White
        Me.dataDetalle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataDetalle.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dataDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataDetalle.DefaultCellStyle = DataGridViewCellStyle2
        Me.dataDetalle.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dataDetalle.Location = New System.Drawing.Point(1, 157)
        Me.dataDetalle.MultiSelect = False
        Me.dataDetalle.Name = "dataDetalle"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataDetalle.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dataDetalle.RowHeadersVisible = False
        Me.dataDetalle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dataDetalle.SelectAllSignVisible = False
        Me.dataDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dataDetalle.ShowEditingIcon = False
        Me.dataDetalle.Size = New System.Drawing.Size(980, 388)
        Me.dataDetalle.TabIndex = 80
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.cboAnno)
        Me.GroupPanel1.Controls.Add(Me.cboMes)
        Me.GroupPanel1.Location = New System.Drawing.Point(12, 12)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(272, 54)
        '
        '
        '
        Me.GroupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel1.Style.BackColorGradientAngle = 90
        Me.GroupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderBottomWidth = 1
        Me.GroupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderLeftWidth = 1
        Me.GroupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderRightWidth = 1
        Me.GroupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderTopWidth = 1
        Me.GroupPanel1.Style.CornerDiameter = 4
        Me.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel1.TabIndex = 81
        Me.GroupPanel1.Text = "Fecha de Reporte"
        '
        'cboAnno
        '
        Me.cboAnno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAnno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAnno.FormattingEnabled = True
        Me.cboAnno.Items.AddRange(New Object() {"2010", "2011", "2012", "2013", "2014", "2015"})
        Me.cboAnno.Location = New System.Drawing.Point(167, 5)
        Me.cboAnno.Name = "cboAnno"
        Me.cboAnno.Size = New System.Drawing.Size(90, 24)
        Me.cboAnno.TabIndex = 1
        '
        'cboMes
        '
        Me.cboMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMes.FormattingEnabled = True
        Me.cboMes.Items.AddRange(New Object() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Setiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.cboMes.Location = New System.Drawing.Point(6, 5)
        Me.cboMes.Name = "cboMes"
        Me.cboMes.Size = New System.Drawing.Size(153, 24)
        Me.cboMes.TabIndex = 0
        '
        'chkDia
        '
        Me.chkDia.AutoSize = True
        '
        '
        '
        Me.chkDia.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chkDia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDia.Location = New System.Drawing.Point(451, 12)
        Me.chkDia.Name = "chkDia"
        Me.chkDia.Size = New System.Drawing.Size(118, 15)
        Me.chkDia.TabIndex = 79
        Me.chkDia.TabStop = False
        Me.chkDia.Text = "x día Seleccionado"
        '
        'mcDia
        '
        Me.mcDia.AnnuallyMarkedDates = New Date(-1) {}
        Me.mcDia.AutoSize = True
        '
        '
        '
        Me.mcDia.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.mcDia.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.mcDia.BackgroundStyle.BorderBottomWidth = 1
        Me.mcDia.BackgroundStyle.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.mcDia.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.mcDia.BackgroundStyle.BorderLeftWidth = 1
        Me.mcDia.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.mcDia.BackgroundStyle.BorderRightWidth = 1
        Me.mcDia.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.mcDia.BackgroundStyle.BorderTopWidth = 1
        Me.mcDia.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.mcDia.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.mcDia.ContainerControlProcessDialogKey = True
        Me.mcDia.DisplayMonth = New Date(2010, 10, 1, 0, 0, 0, 0)
        Me.mcDia.Enabled = False
        Me.mcDia.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.mcDia.Location = New System.Drawing.Point(586, 12)
        Me.mcDia.MarkedDates = New Date(-1) {}
        Me.mcDia.MaxDate = New Date(2020, 12, 31, 0, 0, 0, 0)
        Me.mcDia.MinDate = New Date(2010, 1, 1, 0, 0, 0, 0)
        Me.mcDia.MonthlyMarkedDates = New Date(-1) {}
        Me.mcDia.Name = "mcDia"
        '
        '
        '
        Me.mcDia.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.mcDia.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.mcDia.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.mcDia.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.mcDia.Size = New System.Drawing.Size(170, 131)
        Me.mcDia.TabIndex = 78
        Me.mcDia.Text = "MonthCalendarAdv1"
        Me.mcDia.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        '
        'grupo
        '
        Me.grupo.Controls.Add(Me.cboGrupo)
        Me.grupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupo.ForeColor = System.Drawing.Color.Maroon
        Me.grupo.Location = New System.Drawing.Point(297, 88)
        Me.grupo.Name = "grupo"
        Me.grupo.Size = New System.Drawing.Size(272, 52)
        Me.grupo.TabIndex = 75
        Me.grupo.TabStop = False
        '
        'cboGrupo
        '
        Me.cboGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGrupo.Enabled = False
        Me.cboGrupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGrupo.FormattingEnabled = True
        Me.cboGrupo.Location = New System.Drawing.Point(8, 18)
        Me.cboGrupo.Name = "cboGrupo"
        Me.cboGrupo.Size = New System.Drawing.Size(255, 24)
        Me.cboGrupo.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.optProveedor)
        Me.GroupBox2.Controls.Add(Me.optProducto)
        Me.GroupBox2.Controls.Add(Me.optDocumento)
        Me.GroupBox2.Controls.Add(Me.optRegistro)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox2.Location = New System.Drawing.Point(12, 70)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(272, 70)
        Me.GroupBox2.TabIndex = 74
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tipo de Reporte"
        '
        'optProveedor
        '
        Me.optProveedor.AutoSize = True
        Me.optProveedor.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optProveedor.ForeColor = System.Drawing.Color.Black
        Me.optProveedor.Location = New System.Drawing.Point(160, 21)
        Me.optProveedor.Name = "optProveedor"
        Me.optProveedor.Size = New System.Drawing.Size(89, 19)
        Me.optProveedor.TabIndex = 3
        Me.optProveedor.TabStop = True
        Me.optProveedor.Text = "x Proveedor"
        Me.optProveedor.UseVisualStyleBackColor = True
        '
        'optProducto
        '
        Me.optProducto.AutoSize = True
        Me.optProducto.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optProducto.ForeColor = System.Drawing.Color.Black
        Me.optProducto.Location = New System.Drawing.Point(160, 43)
        Me.optProducto.Name = "optProducto"
        Me.optProducto.Size = New System.Drawing.Size(82, 19)
        Me.optProducto.TabIndex = 2
        Me.optProducto.TabStop = True
        Me.optProducto.Text = "x Producto"
        Me.optProducto.UseVisualStyleBackColor = True
        '
        'optDocumento
        '
        Me.optDocumento.AutoSize = True
        Me.optDocumento.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optDocumento.ForeColor = System.Drawing.Color.Black
        Me.optDocumento.Location = New System.Drawing.Point(6, 43)
        Me.optDocumento.Name = "optDocumento"
        Me.optDocumento.Size = New System.Drawing.Size(75, 19)
        Me.optDocumento.TabIndex = 1
        Me.optDocumento.TabStop = True
        Me.optDocumento.Text = "Vencidas"
        Me.optDocumento.UseVisualStyleBackColor = True
        '
        'optRegistro
        '
        Me.optRegistro.AutoSize = True
        Me.optRegistro.Checked = True
        Me.optRegistro.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optRegistro.ForeColor = System.Drawing.Color.Black
        Me.optRegistro.Location = New System.Drawing.Point(6, 21)
        Me.optRegistro.Name = "optRegistro"
        Me.optRegistro.Size = New System.Drawing.Size(121, 19)
        Me.optRegistro.TabIndex = 0
        Me.optRegistro.TabStop = True
        Me.optRegistro.Text = "Cuentas x Cobrar"
        Me.optRegistro.UseVisualStyleBackColor = True
        '
        'cmdCerrar
        '
        Me.cmdCerrar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdCerrar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCerrar.Image = Global.cefe.My.Resources.Resources.CLOSE22
        Me.cmdCerrar.Location = New System.Drawing.Point(880, 107)
        Me.cmdCerrar.Name = "cmdCerrar"
        Me.cmdCerrar.Size = New System.Drawing.Size(84, 34)
        Me.cmdCerrar.TabIndex = 77
        Me.cmdCerrar.Text = "Cerrar"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdImprimir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdImprimir.Image = Global.cefe.My.Resources.Resources.print_preview
        Me.cmdImprimir.Location = New System.Drawing.Point(774, 107)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(84, 34)
        Me.cmdImprimir.TabIndex = 76
        Me.cmdImprimir.Text = "Imprimir"
        '
        'repCuentasCobrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(982, 546)
        Me.Controls.Add(Me.grupoAlmacen)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.dataDetalle)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Controls.Add(Me.chkDia)
        Me.Controls.Add(Me.mcDia)
        Me.Controls.Add(Me.cmdCerrar)
        Me.Controls.Add(Me.cmdImprimir)
        Me.Controls.Add(Me.grupo)
        Me.Controls.Add(Me.GroupBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "repCuentasCobrar"
        Me.Text = "Consulta y Reporte: CUENTAS x COBRAR"
        Me.grupoAlmacen.ResumeLayout(False)
        CType(Me.dataDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel1.ResumeLayout(False)
        Me.grupo.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grupoAlmacen As System.Windows.Forms.GroupBox
    Friend WithEvents cboAlmacen As System.Windows.Forms.ComboBox
    Friend WithEvents chkAlmacen As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dataDetalle As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents cboAnno As System.Windows.Forms.ComboBox
    Friend WithEvents cboMes As System.Windows.Forms.ComboBox
    Friend WithEvents chkDia As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents mcDia As DevComponents.Editors.DateTimeAdv.MonthCalendarAdv
    Friend WithEvents cmdCerrar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmdImprimir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents grupo As System.Windows.Forms.GroupBox
    Friend WithEvents cboGrupo As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents optProveedor As System.Windows.Forms.RadioButton
    Friend WithEvents optProducto As System.Windows.Forms.RadioButton
    Friend WithEvents optDocumento As System.Windows.Forms.RadioButton
    Friend WithEvents optRegistro As System.Windows.Forms.RadioButton

End Class
