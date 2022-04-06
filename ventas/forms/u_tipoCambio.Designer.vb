<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class u_tipoCambio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(u_tipoCambio))
        Me.txtTC = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lblItems = New DevComponents.DotNetBar.LabelX()
        Me.lblFecha = New DevComponents.DotNetBar.LabelX()
        Me.cmdAceptar = New DevExpress.DXCore.Controls.XtraEditors.SimpleButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.mcFIngreso = New DevComponents.Editors.DateTimeAdv.MonthCalendarAdv()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtTC
        '
        '
        '
        '
        Me.txtTC.Border.Class = "TextBoxBorder"
        Me.txtTC.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtTC.Location = New System.Drawing.Point(170, 61)
        Me.txtTC.Name = "txtTC"
        Me.txtTC.Size = New System.Drawing.Size(82, 20)
        Me.txtTC.TabIndex = 0
        Me.txtTC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblItems
        '
        Me.lblItems.AutoSize = True
        '
        '
        '
        Me.lblItems.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblItems.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItems.Location = New System.Drawing.Point(68, 62)
        Me.lblItems.Name = "lblItems"
        Me.lblItems.Size = New System.Drawing.Size(98, 17)
        Me.lblItems.TabIndex = 62
        Me.lblItems.Text = "Tipo de Cambio"
        '
        'lblFecha
        '
        '
        '
        '
        Me.lblFecha.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.ForeColor = System.Drawing.Color.Maroon
        Me.lblFecha.Location = New System.Drawing.Point(67, 15)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(186, 28)
        Me.lblFecha.TabIndex = 63
        Me.lblFecha.Text = "Fecha del Sistema"
        Me.lblFecha.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmdAceptar.Appearance.Options.UseFont = True
        Me.cmdAceptar.Image = CType(resources.GetObject("cmdAceptar.Image"), System.Drawing.Image)
        Me.cmdAceptar.ImageLocation = DevExpress.DXCore.Controls.XtraEditors.ImageLocation.TopCenter
        Me.cmdAceptar.Location = New System.Drawing.Point(188, 165)
        Me.cmdAceptar.LookAndFeel.SkinName = "iMaginary"
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(64, 62)
        Me.cmdAceptar.TabIndex = 1
        Me.cmdAceptar.Text = "Aceptar"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(45, 74)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 72
        Me.PictureBox1.TabStop = False
        '
        'mcFIngreso
        '
        Me.mcFIngreso.AnnuallyMarkedDates = New Date(-1) {}
        Me.mcFIngreso.AutoSize = True
        '
        '
        '
        Me.mcFIngreso.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.mcFIngreso.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.mcFIngreso.BackgroundStyle.BorderBottomWidth = 1
        Me.mcFIngreso.BackgroundStyle.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.mcFIngreso.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.mcFIngreso.BackgroundStyle.BorderLeftWidth = 1
        Me.mcFIngreso.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.mcFIngreso.BackgroundStyle.BorderRightWidth = 1
        Me.mcFIngreso.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.mcFIngreso.BackgroundStyle.BorderTopWidth = 1
        Me.mcFIngreso.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.mcFIngreso.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.mcFIngreso.ContainerControlProcessDialogKey = True
        Me.mcFIngreso.DisplayMonth = New Date(2010, 10, 1, 0, 0, 0, 0)
        Me.mcFIngreso.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.mcFIngreso.Location = New System.Drawing.Point(12, 92)
        Me.mcFIngreso.MarkedDates = New Date(-1) {}
        Me.mcFIngreso.MaxDate = New Date(2020, 12, 31, 0, 0, 0, 0)
        Me.mcFIngreso.MinDate = New Date(2010, 1, 1, 0, 0, 0, 0)
        Me.mcFIngreso.MonthlyMarkedDates = New Date(-1) {}
        Me.mcFIngreso.Name = "mcFIngreso"
        '
        '
        '
        Me.mcFIngreso.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.mcFIngreso.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.mcFIngreso.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.mcFIngreso.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.mcFIngreso.Size = New System.Drawing.Size(170, 131)
        Me.mcFIngreso.TabIndex = 73
        Me.mcFIngreso.TabStop = False
        Me.mcFIngreso.Text = "MonthCalendarAdv1"
        Me.mcFIngreso.TwoLetterDayName = False
        Me.mcFIngreso.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        '
        'u_tipoCambio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(262, 239)
        Me.Controls.Add(Me.mcFIngreso)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.txtTC)
        Me.Controls.Add(Me.lblItems)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "u_tipoCambio"
        Me.Text = "Utilidad: TIPO DE CAMBIO - Dólares Americanos"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtTC As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lblItems As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblFecha As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmdAceptar As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents mcFIngreso As DevComponents.Editors.DateTimeAdv.MonthCalendarAdv

End Class
