using System;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace SendReportAsEMail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Instantiate a report. 
                // Email export options are already specified at design time.                
                XtraReport1 report = new XtraReport1();

                // Create a new memory stream and export the report in PDF.
                MemoryStream stream = new MemoryStream();
                report.ExportToPdf(stream);

                // Create a new attachment and add the PDF document.
                stream.Seek(0, System.IO.SeekOrigin.Begin);
                Attachment attachedDoc = new Attachment(stream, "TestReport.pdf", "application/pdf");

                // Create a new message and attach the PDF document.
                MailMessage mail = new MailMessage();
                mail.Attachments.Add(attachedDoc);

                // Specify the sender and get recipient settings from the report export options.
                mail.From = new MailAddress("someone@somewhere.com", "Someone");
                mail.To.Add(new MailAddress(report.ExportOptions.Email.RecipientAddress,
                    report.ExportOptions.Email.RecipientName));

                // Specify other e-mail options.
                mail.Subject = report.ExportOptions.Email.Subject;
                mail.Body = "This is a test e-mail message sent by an application.";

                // Specify the SMTP server and send the message.
                string SmtpHost = null;
                int SmtpPort = -1;
                if (string.IsNullOrEmpty(SmtpHost) || SmtpPort == -1)
                {
                    throw new ArgumentException("Please configure the SMTP server settings.");
                }

                string SmtpUserName = "Enter_Sender_User_Account";
                string SmtpUserPassword = "Enter_Sender_Password";
                SmtpClient smtpClient = new SmtpClient(SmtpHost, SmtpPort);
                smtpClient.Credentials = new NetworkCredential(SmtpUserName, SmtpUserPassword);
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.EnableSsl = false;
                smtpClient.Send(mail);

                // Close the memory stream.
                stream.Close();
                stream.Flush();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Error sending a report.\n" + ex.ToString());
            }
        }
    }
}
