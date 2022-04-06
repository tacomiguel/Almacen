'***************************************************
'*  CODIGO DE EJEMPLO PARA ENVIAR E-MAIL           *
'*  CON ADJUNTOS DESE CUALQUIER SERVIDOR SMTP      *
'*  AUTOR: Ing. Ramiro Batallas Rivadeneira        *
'*  E-mail: ramiro.batallas@hotmail.com            *
'*  Quito - Ecuador                                *
'***************************************************
Imports System.Net
Imports System.Net.Mail
Imports System.IO
Public Class p_enviarEmail
    Private i As Integer
    Private correo As New MailMessage
    Private adjuntos As Attachment
    Private autenticar As New NetworkCredential
    Private envio As New SmtpClient
    Private adaux, adaux1, auxdir, auxdir2, auxdir3, auxcc, auxcc2, auxcco, auxcco2 As String
    Private dato As FileStream

    Private Sub btnAdjuntar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdjuntar.Click
        Try
            Me.opfArchivos.Filter = "Todos los Archivos (*.*)|*.*"
            Me.opfArchivos.Title = "Adjuntar Archivos"
            Me.opfArchivos.Multiselect = False
            Me.opfArchivos.InitialDirectory = "c:\"
            If Me.opfArchivos.ShowDialog = Windows.Forms.DialogResult.Cancel Then
                Exit Sub
            Else
                If Me.txtAdjunto.Text = "" Then
                    adaux = Me.opfArchivos.FileName + "; "
                    Me.txtAdjunto.Text = adaux
                Else
                    adaux1 = Me.opfArchivos.FileName + "; "
                    adaux += adaux1
                    Me.txtAdjunto.Text = adaux
                End If
                dato = New FileStream(Me.opfArchivos.FileName, FileMode.Open, FileAccess.Read)
                adjuntos = New Attachment(dato, Me.opfArchivos.FileName)
                correo.Attachments.Add(adjuntos)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Correo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEnviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviar.Click
        Try
            correo.Body = Me.txtBody.Text
            correo.Subject = Me.txtAsunto.Text
            correo.IsBodyHtml = True
            correo.To.Clear()
            correo.CC.Clear()
            correo.Bcc.Clear()
            auxdir = ""
            auxdir2 = ""
            auxcc = ""
            auxcc2 = ""
            auxcco = ""
            auxcco2 = ""
            auxdir = Trim(Me.txtPara.Text)
            auxcc = Trim(Me.txtCC.Text)
            auxcco = Trim(Me.txtCCO.Text)

            If auxdir(auxdir.Length - 1) <> ";" Then
                auxdir += ";"
            End If
            For i = 0 To auxdir.Length - 1
                If auxdir(i) = ";" Then
                    correo.To.Add(Trim(auxdir2))
                    auxdir2 = ""
                Else
                    auxdir2 += auxdir(i)
                End If
            Next

            If Me.txtCC.Text <> "" Then
                If auxcc(auxcc.Length - 1) <> ";" Then
                    auxcc += ";"
                End If
                For i = 0 To auxcc.Length - 1
                    If auxcc(i) = ";" Then
                        correo.CC.Add(Trim(auxcc2))
                        auxcc2 = ""
                    Else
                        auxcc2 += auxcc(i)
                    End If
                Next
            End If

            If Me.txtCCO.Text <> "" Then
                If auxcco(auxcco.Length - 1) <> ";" Then
                    auxcco += ";"
                End If
                For i = 0 To auxcco.Length - 1
                    If auxcco(i) = ";" Then
                        correo.Bcc.Add(Trim(auxcco2))
                        auxcco2 = ""
                    Else
                        auxcco2 += auxcco(i)
                    End If
                Next
            End If

            correo.From = New MailAddress("mtaco@larosanautica.com", "Miguel Taco")
            envio.Credentials = New NetworkCredential("mtaco@larosanautica.com", "09855425")
            envio.Host = "mail.larosanautica.com"
            envio.Port = 25 'Puerto del Servidor smtp"
            envio.EnableSsl = False
            envio.Send(correo)
            MessageBox.Show("El mensaje fue enviado correctamente a el/los destinatarios", "Agenda", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.txtPara.Text = ""
            Me.txtCC.Text = ""
            Me.txtCCO.Text = ""
            Me.txtAdjunto.Text = ""
            Me.txtAsunto.Text = ""
            Me.txtBody.Text = ""
            correo.Attachments.Clear()
            Me.txtPara.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Agenda", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnBorrarAdjuntos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrarAdjuntos.Click
        Try
            Me.txtAdjunto.Text = ""
            correo.Attachments.Clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Correo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class
