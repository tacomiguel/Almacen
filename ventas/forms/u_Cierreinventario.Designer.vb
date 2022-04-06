<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class u_Cierreinventario
    Inherits cefe.base

    'Form invalida a Dispose para limpiar la lista de componentes.
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
        Me.GroupPanel3 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.CboAnnoA = New System.Windows.Forms.ComboBox()
        Me.cboMesA = New System.Windows.Forms.ComboBox()
        Me.cmdCerrarInventario = New DevComponents.DotNetBar.ButtonX()
        Me.chkAlmacenActualizar = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.cboAlmacenActualizar = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.cmdActualizaConteoFisico = New DevComponents.DotNetBar.ButtonX()
        Me.mcFInventario = New DevComponents.Editors.DateTimeAdv.MonthCalendarAdv()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cmdGenerarSaldo = New DevComponents.DotNetBar.ButtonX()
        Me.barraProgreso = New System.Windows.Forms.ProgressBar()
        Me.ChkEliminar_his = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.GroupPanel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupPanel3
        '
        Me.GroupPanel3.BackColor = System.Drawing.Color.Transparent
        Me.GroupPanel3.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel3.Controls.Add(Me.CboAnnoA)
        Me.GroupPanel3.Controls.Add(Me.cboMesA)
        Me.GroupPanel3.Location = New System.Drawing.Point(287, 14)
        Me.GroupPanel3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupPanel3.Name = "GroupPanel3"
        Me.GroupPanel3.Size = New System.Drawing.Size(245, 62)
        '
        '
        '
        Me.GroupPanel3.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel3.Style.BackColorGradientAngle = 90
        Me.GroupPanel3.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel3.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderBottomWidth = 1
        Me.GroupPanel3.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel3.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderLeftWidth = 1
        Me.GroupPanel3.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderRightWidth = 1
        Me.GroupPanel3.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderTopWidth = 1
        Me.GroupPanel3.Style.CornerDiameter = 4
        Me.GroupPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel3.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel3.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel3.TabIndex = 166
        Me.GroupPanel3.Text = "Periodo Actual"
        '
        'CboAnnoA
        '
        Me.CboAnnoA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboAnnoA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboAnnoA.FormattingEnabled = True
        Me.CboAnnoA.Items.AddRange(New Object() {"2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025"})
        Me.CboAnnoA.Location = New System.Drawing.Point(145, 6)
        Me.CboAnnoA.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CboAnnoA.Name = "CboAnnoA"
        Me.CboAnnoA.Size = New System.Drawing.Size(79, 25)
        Me.CboAnnoA.TabIndex = 1
        '
        'cboMesA
        '
        Me.cboMesA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMesA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMesA.FormattingEnabled = True
        Me.cboMesA.Items.AddRange(New Object() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Setiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.cboMesA.Location = New System.Drawing.Point(7, 6)
        Me.cboMesA.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboMesA.Name = "cboMesA"
        Me.cboMesA.Size = New System.Drawing.Size(124, 25)
        Me.cboMesA.TabIndex = 0
        '
        'cmdCerrarInventario
        '
        Me.cmdCerrarInventario.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdCerrarInventario.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.cmdCerrarInventario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCerrarInventario.Image = Global.cefe.My.Resources.Resources.ark22
        Me.cmdCerrarInventario.Location = New System.Drawing.Point(68, 220)
        Me.cmdCerrarInventario.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdCerrarInventario.Name = "cmdCerrarInventario"
        Me.cmdCerrarInventario.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.cmdCerrarInventario.Size = New System.Drawing.Size(224, 69)
        Me.cmdCerrarInventario.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
        Me.cmdCerrarInventario.TabIndex = 165
        Me.cmdCerrarInventario.Text = "Cerrar Inventario"
        '
        'chkAlmacenActualizar
        '
        Me.chkAlmacenActualizar.AutoSize = True
        Me.chkAlmacenActualizar.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.chkAlmacenActualizar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chkAlmacenActualizar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAlmacenActualizar.Location = New System.Drawing.Point(323, 382)
        Me.chkAlmacenActualizar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkAlmacenActualizar.Name = "chkAlmacenActualizar"
        Me.chkAlmacenActualizar.Size = New System.Drawing.Size(161, 18)
        Me.chkAlmacenActualizar.TabIndex = 164
        Me.chkAlmacenActualizar.Text = "Almacén a Actualizar"
        Me.chkAlmacenActualizar.TextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        '
        'cboAlmacenActualizar
        '
        Me.cboAlmacenActualizar.DisplayMember = "Text"
        Me.cboAlmacenActualizar.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboAlmacenActualizar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAlmacenActualizar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAlmacenActualizar.ForeColor = System.Drawing.Color.Black
        Me.cboAlmacenActualizar.FormattingEnabled = True
        Me.cboAlmacenActualizar.ItemHeight = 15
        Me.cboAlmacenActualizar.Location = New System.Drawing.Point(325, 405)
        Me.cboAlmacenActualizar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboAlmacenActualizar.Name = "cboAlmacenActualizar"
        Me.cboAlmacenActualizar.Size = New System.Drawing.Size(245, 21)
        Me.cboAlmacenActualizar.TabIndex = 163
        Me.cboAlmacenActualizar.WatermarkColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'cmdActualizaConteoFisico
        '
        Me.cmdActualizaConteoFisico.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdActualizaConteoFisico.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.cmdActualizaConteoFisico.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdActualizaConteoFisico.Image = Global.cefe.My.Resources.Resources.transforma
        Me.cmdActualizaConteoFisico.Location = New System.Drawing.Point(68, 370)
        Me.cmdActualizaConteoFisico.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdActualizaConteoFisico.Name = "cmdActualizaConteoFisico"
        Me.cmdActualizaConteoFisico.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.cmdActualizaConteoFisico.Size = New System.Drawing.Size(224, 69)
        Me.cmdActualizaConteoFisico.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
        Me.cmdActualizaConteoFisico.TabIndex = 162
        Me.cmdActualizaConteoFisico.Text = "Recupera Inventario Inicial y Actualiza Conteo Fisco"
        '
        'mcFInventario
        '
        Me.mcFInventario.AnnuallyMarkedDates = New Date(-1) {}
        Me.mcFInventario.AutoSize = True
        '
        '
        '
        Me.mcFInventario.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.mcFInventario.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.mcFInventario.BackgroundStyle.BorderBottomWidth = 1
        Me.mcFInventario.BackgroundStyle.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.mcFInventario.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.mcFInventario.BackgroundStyle.BorderLeftWidth = 1
        Me.mcFInventario.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.mcFInventario.BackgroundStyle.BorderRightWidth = 1
        Me.mcFInventario.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.mcFInventario.BackgroundStyle.BorderTopWidth = 1
        Me.mcFInventario.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.mcFInventario.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.mcFInventario.ContainerControlProcessDialogKey = True
        Me.mcFInventario.DisplayMonth = New Date(2010, 10, 1, 0, 0, 0, 0)
        Me.mcFInventario.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.mcFInventario.Location = New System.Drawing.Point(40, 14)
        Me.mcFInventario.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.mcFInventario.MarkedDates = New Date(-1) {}
        Me.mcFInventario.MaxDate = New Date(2020, 12, 31, 0, 0, 0, 0)
        Me.mcFInventario.MinDate = New Date(2010, 1, 1, 0, 0, 0, 0)
        Me.mcFInventario.MonthlyMarkedDates = New Date(-1) {}
        Me.mcFInventario.Name = "mcFInventario"
        '
        '
        '
        Me.mcFInventario.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.mcFInventario.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.mcFInventario.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.mcFInventario.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.mcFInventario.Size = New System.Drawing.Size(170, 131)
        Me.mcFInventario.TabIndex = 158
        Me.mcFInventario.Text = "MonthCalendarAdv1"
        Me.mcFInventario.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.cefe.My.Resources.Resources.forward22
        Me.PictureBox1.Location = New System.Drawing.Point(328, 187)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(29, 28)
        Me.PictureBox1.TabIndex = 160
        Me.PictureBox1.TabStop = False
        '
        'cmdGenerarSaldo
        '
        Me.cmdGenerarSaldo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdGenerarSaldo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdGenerarSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGenerarSaldo.Image = Global.cefe.My.Resources.Resources.ok22
        Me.cmdGenerarSaldo.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right
        Me.cmdGenerarSaldo.Location = New System.Drawing.Point(68, 297)
        Me.cmdGenerarSaldo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdGenerarSaldo.Name = "cmdGenerarSaldo"
        Me.cmdGenerarSaldo.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.cmdGenerarSaldo.Size = New System.Drawing.Size(224, 66)
        Me.cmdGenerarSaldo.TabIndex = 159
        Me.cmdGenerarSaldo.Text = "Generar Stock Provisional del Nuevo Periodo"
        '
        'barraProgreso
        '
        Me.barraProgreso.Location = New System.Drawing.Point(325, 187)
        Me.barraProgreso.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.barraProgreso.Name = "barraProgreso"
        Me.barraProgreso.Size = New System.Drawing.Size(399, 30)
        Me.barraProgreso.TabIndex = 161
        Me.barraProgreso.Visible = False
        '
        'ChkEliminar_his
        '
        Me.ChkEliminar_his.AutoSize = True
        Me.ChkEliminar_his.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.ChkEliminar_his.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ChkEliminar_his.Checked = True
        Me.ChkEliminar_his.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkEliminar_his.CheckValue = "Y"
        Me.ChkEliminar_his.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkEliminar_his.Location = New System.Drawing.Point(323, 345)
        Me.ChkEliminar_his.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkEliminar_his.Name = "ChkEliminar_his"
        Me.ChkEliminar_his.Size = New System.Drawing.Size(170, 18)
        Me.ChkEliminar_his.TabIndex = 167
        Me.ChkEliminar_his.Text = "Eliminr Datos Historial"
        Me.ChkEliminar_his.TextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        '
        'u_Cierreinventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(845, 459)
        Me.Controls.Add(Me.ChkEliminar_his)
        Me.Controls.Add(Me.GroupPanel3)
        Me.Controls.Add(Me.cmdCerrarInventario)
        Me.Controls.Add(Me.chkAlmacenActualizar)
        Me.Controls.Add(Me.cboAlmacenActualizar)
        Me.Controls.Add(Me.cmdActualizaConteoFisico)
        Me.Controls.Add(Me.mcFInventario)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cmdGenerarSaldo)
        Me.Controls.Add(Me.barraProgreso)
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "u_Cierreinventario"
        Me.GroupPanel3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupPanel3 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents CboAnnoA As ComboBox
    Friend WithEvents cboMesA As ComboBox
    Friend WithEvents cmdCerrarInventario As DevComponents.DotNetBar.ButtonX
    Friend WithEvents chkAlmacenActualizar As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents cboAlmacenActualizar As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cmdActualizaConteoFisico As DevComponents.DotNetBar.ButtonX
    Friend WithEvents mcFInventario As DevComponents.Editors.DateTimeAdv.MonthCalendarAdv
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cmdGenerarSaldo As DevComponents.DotNetBar.ButtonX
    Friend WithEvents barraProgreso As ProgressBar
    Friend WithEvents ChkEliminar_his As DevComponents.DotNetBar.Controls.CheckBoxX
End Class
