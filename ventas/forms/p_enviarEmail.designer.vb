<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class p_enviarEmail
    Inherits System.Windows.Forms.Form

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
        Me.btnBorrarAdjuntos = New System.Windows.Forms.Button()
        Me.btnAdjuntar = New System.Windows.Forms.Button()
        Me.txtAdjunto = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtAsunto = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCCO = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCC = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPara = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBody = New System.Windows.Forms.TextBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.opfArchivos = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'btnBorrarAdjuntos
        '
        Me.btnBorrarAdjuntos.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrarAdjuntos.Location = New System.Drawing.Point(432, 170)
        Me.btnBorrarAdjuntos.Name = "btnBorrarAdjuntos"
        Me.btnBorrarAdjuntos.Size = New System.Drawing.Size(75, 26)
        Me.btnBorrarAdjuntos.TabIndex = 27
        Me.btnBorrarAdjuntos.Text = "Borrar"
        Me.btnBorrarAdjuntos.UseVisualStyleBackColor = True
        '
        'btnAdjuntar
        '
        Me.btnAdjuntar.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdjuntar.Location = New System.Drawing.Point(514, 170)
        Me.btnAdjuntar.Name = "btnAdjuntar"
        Me.btnAdjuntar.Size = New System.Drawing.Size(75, 26)
        Me.btnAdjuntar.TabIndex = 26
        Me.btnAdjuntar.Text = "Adjuntar"
        Me.btnAdjuntar.UseVisualStyleBackColor = True
        '
        'txtAdjunto
        '
        Me.txtAdjunto.BackColor = System.Drawing.Color.White
        Me.txtAdjunto.Enabled = False
        Me.txtAdjunto.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdjunto.ForeColor = System.Drawing.Color.Black
        Me.txtAdjunto.Location = New System.Drawing.Point(76, 170)
        Me.txtAdjunto.Name = "txtAdjunto"
        Me.txtAdjunto.Size = New System.Drawing.Size(354, 26)
        Me.txtAdjunto.TabIndex = 33
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(4, 178)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 18)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Adjuntos"
        '
        'txtAsunto
        '
        Me.txtAsunto.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAsunto.Location = New System.Drawing.Point(76, 129)
        Me.txtAsunto.Name = "txtAsunto"
        Me.txtAsunto.Size = New System.Drawing.Size(515, 26)
        Me.txtAsunto.TabIndex = 25
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(4, 137)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 18)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Asunto :"
        '
        'txtCCO
        '
        Me.txtCCO.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCCO.Location = New System.Drawing.Point(76, 88)
        Me.txtCCO.Name = "txtCCO"
        Me.txtCCO.Size = New System.Drawing.Size(515, 26)
        Me.txtCCO.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(4, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 18)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "CCO :"
        '
        'txtCC
        '
        Me.txtCC.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCC.Location = New System.Drawing.Point(76, 47)
        Me.txtCC.Name = "txtCC"
        Me.txtCC.Size = New System.Drawing.Size(515, 26)
        Me.txtCC.TabIndex = 23
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(4, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 18)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "CC :"
        '
        'txtPara
        '
        Me.txtPara.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPara.Location = New System.Drawing.Point(76, 5)
        Me.txtPara.Name = "txtPara"
        Me.txtPara.Size = New System.Drawing.Size(515, 26)
        Me.txtPara.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(4, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 18)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Para :"
        '
        'txtBody
        '
        Me.txtBody.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBody.Location = New System.Drawing.Point(8, 202)
        Me.txtBody.Multiline = True
        Me.txtBody.Name = "txtBody"
        Me.txtBody.Size = New System.Drawing.Size(587, 238)
        Me.txtBody.TabIndex = 34
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(597, 51)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(113, 26)
        Me.btnSalir.TabIndex = 36
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnEnviar
        '
        Me.btnEnviar.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnviar.Location = New System.Drawing.Point(597, 9)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(113, 26)
        Me.btnEnviar.TabIndex = 35
        Me.btnEnviar.Text = "Enviar"
        Me.btnEnviar.UseVisualStyleBackColor = True
        '
        'EnviarEmail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(719, 452)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnEnviar)
        Me.Controls.Add(Me.txtBody)
        Me.Controls.Add(Me.btnBorrarAdjuntos)
        Me.Controls.Add(Me.btnAdjuntar)
        Me.Controls.Add(Me.txtAdjunto)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtAsunto)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtCCO)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCC)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPara)
        Me.Controls.Add(Me.Label3)
        Me.Name = "EnviarEmail"
        Me.Text = "Enviar Email"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBorrarAdjuntos As System.Windows.Forms.Button
    Friend WithEvents btnAdjuntar As System.Windows.Forms.Button
    Friend WithEvents txtAdjunto As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtAsunto As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCCO As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCC As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPara As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtBody As System.Windows.Forms.TextBox
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnEnviar As System.Windows.Forms.Button
    Friend WithEvents opfArchivos As System.Windows.Forms.OpenFileDialog

End Class
