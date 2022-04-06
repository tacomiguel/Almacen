<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class p_botellas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(p_botellas))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblProducto = New DevComponents.DotNetBar.LabelX()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtBotCerrada = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtBotAbierta = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.cmdAceptar = New DevExpress.DXCore.Controls.XtraEditors.SimpleButton()
        Me.cmdCancelar = New DevExpress.DXCore.Controls.XtraEditors.SimpleButton()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblProducto)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox3.Location = New System.Drawing.Point(7, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(339, 35)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        '
        'lblProducto
        '
        '
        '
        '
        Me.lblProducto.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProducto.ForeColor = System.Drawing.Color.Maroon
        Me.lblProducto.Location = New System.Drawing.Point(9, 11)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(324, 18)
        Me.lblProducto.TabIndex = 0
        Me.lblProducto.Text = "Ingrese Artículo"
        Me.lblProducto.TextAlignment = System.Drawing.StringAlignment.Center
        Me.lblProducto.WordWrap = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtBotCerrada)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(7, 42)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(84, 72)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Botellas Cerradas"
        '
        'txtBotCerrada
        '
        '
        '
        '
        Me.txtBotCerrada.Border.Class = "TextBoxBorder"
        Me.txtBotCerrada.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtBotCerrada.FocusHighlightEnabled = True
        Me.txtBotCerrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBotCerrada.Location = New System.Drawing.Point(12, 37)
        Me.txtBotCerrada.Name = "txtBotCerrada"
        Me.txtBotCerrada.Size = New System.Drawing.Size(62, 22)
        Me.txtBotCerrada.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtBotAbierta)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(99, 42)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(93, 72)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Peso Botella Abierta"
        '
        'txtBotAbierta
        '
        '
        '
        '
        Me.txtBotAbierta.Border.Class = "TextBoxBorder"
        Me.txtBotAbierta.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtBotAbierta.FocusHighlightEnabled = True
        Me.txtBotAbierta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBotAbierta.Location = New System.Drawing.Point(15, 37)
        Me.txtBotAbierta.Name = "txtBotAbierta"
        Me.txtBotAbierta.Size = New System.Drawing.Size(62, 22)
        Me.txtBotAbierta.TabIndex = 3
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.Appearance.Options.UseFont = True
        Me.cmdAceptar.Image = Global.cefe.My.Resources.Resources.ejecutar22
        Me.cmdAceptar.ImageLocation = DevExpress.DXCore.Controls.XtraEditors.ImageLocation.TopCenter
        Me.cmdAceptar.Location = New System.Drawing.Point(207, 64)
        Me.cmdAceptar.LookAndFeel.SkinName = "iMaginary"
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(64, 50)
        Me.cmdAceptar.TabIndex = 170
        Me.cmdAceptar.Text = "Aceptar"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.Image = Global.cefe.My.Resources.Resources.Error_22
        Me.cmdCancelar.ImageLocation = DevExpress.DXCore.Controls.XtraEditors.ImageLocation.TopCenter
        Me.cmdCancelar.Location = New System.Drawing.Point(282, 64)
        Me.cmdCancelar.LookAndFeel.SkinName = "iMaginary"
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(64, 50)
        Me.cmdCancelar.TabIndex = 171
        Me.cmdCancelar.Text = "Cancelar"
        '
        'p_botellas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(353, 125)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "p_botellas"
        Me.Text = "Peso de Botellas"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblProducto As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtBotCerrada As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtBotAbierta As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents cmdAceptar As DevExpress.DXCore.Controls.XtraEditors.SimpleButton
    Friend WithEvents cmdCancelar As DevExpress.DXCore.Controls.XtraEditors.SimpleButton

End Class
