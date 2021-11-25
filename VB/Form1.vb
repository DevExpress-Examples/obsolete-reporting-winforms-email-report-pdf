Imports System
Imports System.IO
Imports System.Net
Imports System.Net.Mail
Imports System.Threading.Tasks

Namespace SendReportAsEMail
	Partial Public Class Form1
		Inherits DevExpress.XtraEditors.XtraForm

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Shared Function CreateMailMessage(ByVal stream As MemoryStream) As MailMessage
			' Instantiate a report. 
			' Email export options are already specified at design time.                
			Dim report As New XtraReport1()

			report.ExportToPdf(stream)

			' Create a new attachment and add the PDF document.
			stream.Seek(0, System.IO.SeekOrigin.Begin)
			Dim attachedDoc As New Attachment(stream, "TestReport.pdf", "application/pdf")

			' Create a new message.
			Dim mail As New MailMessage()
			mail.Attachments.Add(attachedDoc)

			' Specify the sender and retrieve the recipient settings from the report export options.
			mail.From = New MailAddress("someone@somewhere.com", "Someone")
			mail.To.Add(New MailAddress(report.ExportOptions.Email.RecipientAddress, report.ExportOptions.Email.RecipientName))

			' Specify other e-mail options.
			mail.Subject = report.ExportOptions.Email.Subject
			mail.Body = "This is a test e-mail message sent by an application."

			Return mail
		End Function


		Private Async Sub btnSend_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSend.Click
			Dim SmtpHost As String = edtHost.EditValue.ToString()
			Dim SmtpPort As Integer = Int32.Parse(edtPort.EditValue.ToString())
			Dim SmtpUserName As String = edtUsername.EditValue.ToString()
			Dim SmtpUserPassword As String = edtPassword.EditValue.ToString()
			Dim nameAndPassword As New NetworkCredential(SmtpUserName, SmtpUserPassword)
			lblProgress.Text = "Sending mail..."
			lblProgress.Text = Await SendAsync(SmtpHost, SmtpPort, nameAndPassword)
		End Sub

		Private Shared Async Function SendAsync(ByVal SmtpHost As String, ByVal SmtpPort As Integer, ByVal nameAndPassword As NetworkCredential) As Task(Of String)
			Dim result As String = "OK"
			' Create a new memory stream and export the report in PDF.
			Using stream As New MemoryStream()
				Using mail As MailMessage = CreateMailMessage(stream)
					Using smtpClient As New SmtpClient(SmtpHost, SmtpPort)
						smtpClient.Credentials = nameAndPassword
						smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network
						smtpClient.EnableSsl = False
						Try
							Await smtpClient.SendMailAsync(mail)
						Catch ex As Exception
							result = ex.Message
						End Try

					End Using
				End Using
			End Using
			Return result
		End Function
	End Class
End Namespace
