Imports System
Imports System.IO
Imports System.Net.Mail
' ...

Imports System.Windows.Forms


Namespace SendReportAsEMailCS
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
            Try
                ' Create a new report.                
                Dim report As New XtraReport1()

                ' Create a new memory stream and export the report into it as PDF.
                Dim mem As New MemoryStream()
                report.ExportToPdf(mem)
                ' Export report to PDF file
                report.ExportToPdf("exportedFile.pdf")

                ' Create a new attachment and put the PDF report into it.
                mem.Seek(0, System.IO.SeekOrigin.Begin)
                Dim att As New Attachment(mem, "TestReport.pdf", "application/pdf")

                ' Create second attachment and put the exported PDF report into it.
                Dim currentFolder = Path.GetDirectoryName(Me.GetType().Assembly.Location)
                Dim att2 As New Attachment(Path.Combine(currentFolder, "exportedFile.pdf"), "application/pdf")

                ' Create a new message and attach the PDF reports to it.
                Dim mail As New MailMessage()
                mail.Attachments.Add(att)
                mail.Attachments.Add(att2)

                ' Specify sender and recipient options for the e-mail message.
                mail.From = New MailAddress("someone@somewhere.com", "Someone")
                mail.To.Add(New MailAddress(report.ExportOptions.Email.RecipientAddress, report.ExportOptions.Email.RecipientName))

                ' Specify other e-mail options.
                mail.Subject = report.ExportOptions.Email.Subject
                mail.Body = "This is a test e-mail message sent by an application."

                ' Send the e-mail message via the specified SMTP server.
                Dim smtp As New SmtpClient("smtp.somewhere.com")
                smtp.Send(mail)

                ' Close the memory stream.
                mem.Close()
                mem.Flush()
            Catch ex As Exception
                MessageBox.Show(Me, "Error sending a report." & vbLf & ex.ToString())
            End Try
        End Sub
    End Class
End Namespace
