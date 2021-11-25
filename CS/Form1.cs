using System;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace SendReportAsEMail
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static MailMessage CreateMailMessage(MemoryStream stream)
        {
            // Instantiate a report. 
            // Email export options are already specified at design time.                
            XtraReport1 report = new XtraReport1();

            report.ExportToPdf(stream);

            // Create a new attachment and add the PDF document.
            stream.Seek(0, System.IO.SeekOrigin.Begin);
            Attachment attachedDoc = new Attachment(stream, "TestReport.pdf", "application/pdf");

            // Create a new message.
            MailMessage mail = new MailMessage();
            mail.Attachments.Add(attachedDoc);

            // Specify the sender and retrieve the recipient settings from the report export options.
            mail.From = new MailAddress("someone@somewhere.com", "Someone");
            mail.To.Add(new MailAddress(report.ExportOptions.Email.RecipientAddress,
                report.ExportOptions.Email.RecipientName));

            // Specify other e-mail options.
            mail.Subject = report.ExportOptions.Email.Subject;
            mail.Body = "This is a test e-mail message sent by an application.";

            return mail;
        }


        private async void btnSend_Click(object sender, EventArgs e)
        {
            string SmtpHost = edtHost.EditValue.ToString();
            int SmtpPort = Int32.Parse(edtPort.EditValue.ToString());
            string SmtpUserName = edtUsername.EditValue.ToString();
            string SmtpUserPassword = edtPassword.EditValue.ToString();
            NetworkCredential nameAndPassword = new NetworkCredential(SmtpUserName, SmtpUserPassword);
            lblProgress.Text = "Sending mail...";
            lblProgress.Text = await SendAsync(SmtpHost, SmtpPort, nameAndPassword);
        }

        private static async Task<string> SendAsync(string SmtpHost, int SmtpPort, NetworkCredential nameAndPassword)
        {
            string result = "OK";
            // Create a new memory stream and export the report in PDF.
            using (MemoryStream stream = new MemoryStream())
            {
                using (MailMessage mail = CreateMailMessage(stream))
                {
                    using (SmtpClient smtpClient = new SmtpClient(SmtpHost, SmtpPort))
                    {
                        smtpClient.Credentials = nameAndPassword;
                        smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                        smtpClient.EnableSsl = false;
                        try
                        {
                            await smtpClient.SendMailAsync(mail);
                        }
                        catch (Exception ex)
                        {
                            result = ex.Message;
                        }

                    }
                }
            }
            return result;
        }
    }
}
