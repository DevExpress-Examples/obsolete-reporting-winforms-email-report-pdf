Imports System
Imports System.IO
Imports System.Net
Imports System.Net.Mail
Imports System.Windows.Forms

Namespace SendReportAsEMail
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			Try
				' Instantiate a report. 
				' Email export options are already specified at design time.                
				Dim report As New XtraReport1()

				' Create a new memory stream and export the report in PDF.
				Dim stream As New MemoryStream()
				report.ExportToPdf(stream)

				' Create a new attachment and add the PDF document.
				stream.Seek(0, System.IO.SeekOrigin.Begin)
				Dim attachedDoc As New Attachment(stream, "TestReport.pdf", "application/pdf")

				' Create a new message and attach the PDF document.
				Dim mail As New MailMessage()
				mail.Attachments.Add(attachedDoc)

				' Specify the sender and get recipient settings from the report export options.
				mail.From = New MailAddress("someone@somewhere.com", "Someone")
				mail.To.Add(New MailAddress(report.ExportOptions.Email.RecipientAddress, report.ExportOptions.Email.RecipientName))

				' Specify other e-mail options.
				mail.Subject = report.ExportOptions.Email.Subject
				mail.Body = "This is a test e-mail message sent by an application."

				' Specify the SMTP server and send the message.
				Dim SmtpHost As String = Nothing
				Dim SmtpPort As Integer = -1
				If String.IsNullOrEmpty(SmtpHost) OrElse SmtpPort = -1 Then
					Throw New ArgumentException("Please configure the SMTP server settings.")
				End If

				Dim SmtpUserName As String = "Enter_Sender_User_Account"
				Dim SmtpUserPassword As String = "Enter_Sender_Password"
				Dim smtpClient As New SmtpClient(SmtpHost, SmtpPort)
				smtpClient.Credentials = New NetworkCredential(SmtpUserName, SmtpUserPassword)
				smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network
				smtpClient.EnableSsl = False
				smtpClient.Send(mail)

				' Close the memory stream.
				stream.Close()
				stream.Flush()
			Catch ex As Exception
				MessageBox.Show(Me, "Error sending a report." & ControlChars.Lf & ex.ToString())
			End Try
		End Sub
	End Class
End Namespace