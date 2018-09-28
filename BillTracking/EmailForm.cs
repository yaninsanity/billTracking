using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Net;
using System.Net.Mail;


namespace BillTracking
{
    public partial class EmailForm : Form
    {
        public EmailForm()
        {
            InitializeComponent();
        }


        private void sendButton_Click(object sender, EventArgs e)
        {
            if (emailTextbox.Text == String.Empty)
            {
                MessageBox.Show("Please enter the Email Address");
                return;
            }
            Regex rgexEmail = new Regex(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            if (!rgexEmail.IsMatch(emailTextbox.Text))
            {
                MessageBox.Show("Please enter a valid email");
                return;
            }
            SendEmailMessage();
            emailTextbox.Clear();
        }

        private void emailTextbox_Click(object sender, EventArgs e)
        {
            emailTextbox.Clear();
        }

        public void SendEmailMessage()
        {
           
             String officialEmail = "devilsdeveloperonline@gmail.com";
             String officialPassword = "Devils123";

             MailMessage mail = new MailMessage();
             SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
             client.EnableSsl = true;
             client.DeliveryMethod = SmtpDeliveryMethod.Network;
             client.UseDefaultCredentials = false;
             client.Credentials = new NetworkCredential(officialEmail,officialPassword);
             MailMessage messageObj = new MailMessage();
             messageObj.From = new MailAddress(officialEmail,"Devil's Developers Team");
             messageObj.Subject = "Your friend is inviting you to download this app";
             messageObj.To.Add(emailTextbox.Text);
             messageObj.Priority = MailPriority.High;
             messageObj.IsBodyHtml = true;
             messageObj.Body = "<html><header>Trouble managing your bills?</header><body>Click <a href='https://github.com/yaninsanity/billTracking'> here</a> to help you manage your bills</body></html> <br><br><p>Devils' Developers Team</p> ";
            try
            {
                client.Send(messageObj);
               
                MessageBox.Show("Message has been sent successfully");

            }
            catch (Exception ex)
            {
                 MessageBox.Show(ex.ToString(), "Error");
                MessageBox.Show("Please fix the problem and resend it","Error");
            }
        }
    }
}
