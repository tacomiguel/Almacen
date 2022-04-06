<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class u_envioCompras
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(u_envioCompras))
        Me.mcHasta = New DevComponents.Editors.DateTimeAdv.MonthCalendarAdv()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.optTXT = New System.Windows.Forms.RadioButton()
        Me.optDBF = New System.Windows.Forms.RadioButton()
        Me.cmdEnvio = New DevExpress.DXCore.Controls.XtraEditors.SimpleButton()
        Me.mcDesde = New DevComponents.Editors.DateTimeAdv.MonthCalendarAdv()
        Me.LabelControl1 = New DevExpress.DXCore.Controls.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.DXCore.Controls.XtraEditors.LabelControl()
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.GroupPanel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'mcHasta
        '
        Me.mcHasta.AnnuallyMarkedDates = New Date(-1) {}
        Me.mcHasta.AutoSize = True
        '
        '
        '
        Me.mcHasta.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.mcHasta.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.mcHasta.BackgroundStyle.BorderBottomWidth = 1
        Me.mcHasta.BackgroundStyle.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.mcHasta.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.mcHasta.BackgroundStyle.BorderLeftWidth = 1
        Me.mcHasta.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.mcHasta.BackgroundStyle.BorderRightWidth = 1
        Me.mcHasta.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.mcHasta.BackgroundStyle.BorderTopWidth = 1
        Me.mcHasta.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.mcHasta.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.mcHasta.ContainerControlProcessDialogKey = True
        Me.mcHasta.DisplayMonth = New Date(2010, 10, 1, 0, 0, 0, 0)
        Me.mcHasta.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.mcHasta.Location = New System.Drawing.Point(346, 21)
        Me.mcHasta.MarkedDates = New Date(-1) {}
        Me.mcHasta.MaxDate = New Date(2020, 12, 31, 0, 0, 0, 0)
        Me.mcHasta.MinDate = New Date(2010, 1, 1, 0, 0, 0, 0)
        Me.mcHasta.MonthlyMarkedDates = New Date(-1) {}
        Me.mcHasta.Name = "mcHasta"
        '
        '
        '
        Me.mcHasta.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.mcHasta.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.mcHasta.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.mcHasta.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.mcHasta.Size = New System.Drawing.Size(170, 131)
        Me.mcHasta.TabIndex = 64
        Me.mcHasta.Text = "MonthCalendarAdv1"
        Me.mcHasta.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.GroupBox3)
        Me.GroupPanel1.Controls.Add(Me.cmdEnvio)
        Me.GroupPanel1.Controls.Add(Me.mcDesde)
        Me.GroupPanel1.Controls.Add(Me.LabelControl1)
        Me.GroupPanel1.Controls.Add(Me.LabelControl3)
        Me.GroupPanel1.Controls.Add(Me.mcHasta)
        Me.GroupPanel1.Location = New System.Drawing.Point(12, 12)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(534, 183)
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
        Me.GroupPanel1.TabIndex = 67
        Me.GroupPanel1.Text = "Envio de Compras a Sistema Contable"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.optTXT)
        Me.GroupBox3.Controls.Add(Me.optDBF)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox3.Location = New System.Drawing.Point(197, 21)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(133, 39)
        Me.GroupBox3.TabIndex = 117
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Formato de Salida"
        '
        'optTXT
        '
        Me.optTXT.AutoSize = True
        Me.optTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optTXT.ForeColor = System.Drawing.Color.Black
        Me.optTXT.Location = New System.Drawing.Point(73, 17)
        Me.optTXT.Name = "optTXT"
        Me.optTXT.Size = New System.Drawing.Size(53, 17)
        Me.optTXT.TabIndex = 1
        Me.optTXT.TabStop = True
        Me.optTXT.Text = ".TXT"
        Me.optTXT.UseVisualStyleBackColor = True
        '
        'optDBF
        '
        Me.optDBF.AutoSize = True
        Me.optDBF.Checked = True
        Me.optDBF.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optDBF.ForeColor = System.Drawing.Color.Black
        Me.optDBF.Location = New System.Drawing.Point(12, 17)
        Me.optDBF.Name = "optDBF"
        Me.optDBF.Size = New System.Drawing.Size(53, 17)
        Me.optDBF.TabIndex = 0
        Me.optDBF.TabStop = True
        Me.optDBF.Text = ".DBF"
        Me.optDBF.UseVisualStyleBackColor = True
        '
        'cmdEnvio
        '
        Me.cmdEnvio.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmdEnvio.Appearance.Options.UseFont = True
        Me.cmdEnvio.Image = Global.cefe.My.Resources.Resources.Transformaciones
        Me.cmdEnvio.ImageLocation = DevExpress.DXCore.Controls.XtraEditors.ImageLocation.TopCenter
        Me.cmdEnvio.Location = New System.Drawing.Point(209, 94)
        Me.cmdEnvio.LookAndFeel.SkinName = "iMaginary"
        Me.cmdEnvio.Name = "cmdEnvio"
        Me.cmdEnvio.Size = New System.Drawing.Size(111, 55)
        Me.cmdEnvio.TabIndex = 70
        Me.cmdEnvio.Text = "Generar Compras"
        '
        'mcDesde
        '
        Me.mcDesde.AnnuallyMarkedDates = New Date(-1) {}
        Me.mcDesde.AutoSize = True
        '
        '
        '
        Me.mcDesde.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.mcDesde.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.mcDesde.BackgroundStyle.BorderBottomWidth = 1
        Me.mcDesde.BackgroundStyle.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.mcDesde.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.mcDesde.BackgroundStyle.BorderLeftWidth = 1
        Me.mcDesde.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.mcDesde.BackgroundStyle.BorderRightWidth = 1
        Me.mcDesde.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.mcDesde.BackgroundStyle.BorderTopWidth = 1
        Me.mcDesde.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.mcDesde.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.mcDesde.ContainerControlProcessDialogKey = True
        Me.mcDesde.DisplayMonth = New Date(2010, 10, 1, 0, 0, 0, 0)
        Me.mcDesde.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.mcDesde.Location = New System.Drawing.Point(12, 21)
        Me.mcDesde.MarkedDates = New Date(-1) {}
        Me.mcDesde.MaxDate = New Date(2020, 12, 31, 0, 0, 0, 0)
        Me.mcDesde.MinDate = New Date(2010, 1, 1, 0, 0, 0, 0)
        Me.mcDesde.MonthlyMarkedDates = New Date(-1) {}
        Me.mcDesde.Name = "mcDesde"
        '
        '
        '
        Me.mcDesde.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.mcDesde.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.mcDesde.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.mcDesde.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.mcDesde.Size = New System.Drawing.Size(170, 131)
        Me.mcDesde.TabIndex = 69
        Me.mcDesde.Text = "MonthCalendarAdv1"
        Me.mcDesde.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(412, 3)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(38, 16)
        Me.LabelControl1.TabIndex = 68
        Me.LabelControl1.Text = "Hasta"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(80, 3)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(40, 16)
        Me.LabelControl3.TabIndex = 67
        Me.LabelControl3.Text = "Desde"
        '
        'u_envioCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(558, 206)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "u_envioCompras"
        Me.Text = "Utilidad: ENVIO DE COMPRAS AL SISTEMA CONTABLE"
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents mcHasta As DevComponents.Editors.DateTimeAdv.MonthCalendarAdv
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents mcDesde As DevComponents.Editors.DateTimeAdv.MonthCalendarAdv
    Friend WithEvents cmdEnvio As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents optTXT As System.Windows.Forms.RadioButton
    Friend WithEvents optDBF As System.Windows.Forms.RadioButton
    Private WithEvents LabelControl1 As DevExpress.DXCore.Controls.XtraEditors.LabelControl
    Private WithEvents LabelControl3 As DevExpress.DXCore.Controls.XtraEditors.LabelControl
    Friend WithEvents SaveFileDialog As System.Windows.Forms.SaveFileDialog

End Class
