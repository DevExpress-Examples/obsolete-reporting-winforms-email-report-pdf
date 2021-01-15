using System;
using System.IO;
using System.Net.Mail;
// ...

using System.Windows.Forms;


namespace SendReportAsEMailCS
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
                // Create a new report.                
                XtraReport1 report = new XtraReport1();

                // Create a new memory stream and export the report into it as PDF.
                MemoryStream mem = new MemoryStream();
                report.ExportToPdf(mem);

                // Create a new attachment and put the PDF report into it.
                mem.Seek(0, System.IO.SeekOrigin.Begin);
                Attachment att = new Attachment(mem, "TestReport.pdf", "application/pdf");

                // Create a new message and attach the PDF report to it.
                MailMessage mail = new MailMessage();
                mail.Attachments.Add(att);

                // Specify sender and recipient options for the e-mail message.
                mail.From = new MailAddress("someone@somewhere.com", "Someone");
                mail.To.Add(new MailAddress(report.ExportOptions.Email.RecipientAddress,
                    report.ExportOptions.Email.RecipientName));

                // Specify other e-mail options.
                mail.Subject = report.ExportOptions.Email.Subject;
                mail.Body = "This is a test e-mail message sent by an application.";

                // Send the e-mail message via the specified SMTP server.
                SmtpClient smtp = new SmtpClient("smtp.somewhere.com");
                smtp.Send(mail);

                // Close the memory stream.
                mem.Close();
                mem.Flush();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Error sending a report.\n" + ex.ToString());
            }
        }
    }
}
