Imports System.Net.Mail
Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Mail As New MailMessage
        Mail.Subject = "SMTP Relay prueba"
        Mail.To.Add("ncastaneda@basiscons.com")
        Mail.From = New MailAddress("info@sebastianmancilla.online")
        Mail.Body = "Hola Mundo :)"
        Mail.IsBodyHtml = False

        Dim SMTP As New SmtpClient("smtp.hostinger.com")
        SMTP.EnableSsl = True
        SMTP.Credentials = New System.Net.NetworkCredential("info@sebastianmancilla.online", "Taller123")
        SMTP.Port = 587
        SMTP.Send(Mail)
        MsgBox("Mensaje Enviado")
    End Sub
End Class
