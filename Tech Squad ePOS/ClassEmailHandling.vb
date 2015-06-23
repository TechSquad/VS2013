Imports System.Net.Mail
Public Class ClassEmailHandling

    Public Property subject As String
    Public Property body As String
    Public Property receiver As String

    Public Sub send_email()
        Try
            Dim smtpServer As New SmtpClient()
            Dim mail As New MailMessage()
            smtpServer.UseDefaultCredentials = False
            smtpServer.Credentials = New Net.NetworkCredential("roger@iapbb.net", "h00ters")
            smtpServer.Port = 25
            smtpServer.EnableSsl = False
            smtpServer.Host = "nortechcomputers.co.uk"

            mail = New MailMessage()
            mail.From = New MailAddress("roger@iapbb.net")
            mail.To.Add(receiver)
            mail.Subject = subject
            mail.Body = body
            smtpServer.Send(mail)
        Catch ex As Exception
            MsgBox(ex.Message & vbNewLine & ex.StackTrace)
        End Try

    End Sub
End Class

