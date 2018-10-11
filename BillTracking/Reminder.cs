using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillTracking
{
    public partial class Reminder : Form
    {
        BindingList<Bill> myList = new BindingList<Bill>();
        List<Bill> reminderList = new List<Bill>();
        String reminder = "";
        String myEmail;
        public Reminder()
        {
            InitializeComponent();
        }


        public Reminder(String email,BindingList<Bill> billList)
        {
            InitializeComponent();
            //pass value into global varible
            myList = billList;
            FindDueDate();
            myEmail = email;


        }

        public void FindDueDate()
        {
            double todayDay = DateTime.Today.Day;
            double billDay;
            foreach (Bill b in myList)
            {
                int loopTime=0 ;
                //The date format is "Thursday, October 11, 2018" using substring to slice the string.
                foreach (Char e in b.Date)
                {
                    int counter = 0;
                    if (e == ',' && counter != 1)
                    {
                        counter++;
                        
                    }
                    loopTime++;

                }

                 billDay = double.Parse(b.Date.Substring(loopTime-3, 2));

                double dayDiff=Math.Abs(billDay - todayDay);

                if (dayDiff <= 3)
                {
                    reminderList.Add(b);

                }

              
            }

            //no bill is coming up
            if (reminderList.Count() == 0)
            {
                reminder = "There are no coming up bills in these 3 days.";
            }

            else

            {
                reminder = $"There are {reminderList.Count()} bills coming up. Please track these bills: ";
                foreach (Bill b in myList)
                {
                    reminder += b.Name + ", ";
                }
                reminder += ".";
            }
            reminderTextBox.Text = reminder;

        }

        //send email to user email Address
        public void sendEmail()
        {
            String officialEmail = "devilsdeveloperonline@gmail.com";
            String officialPassword = "Devils123";

            MailMessage mail = new MailMessage();
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential(officialEmail, officialPassword);
            MailMessage messageObj = new MailMessage();
            messageObj.From = new MailAddress(officialEmail, "Devil's Developers Team");
            messageObj.Subject = "Your Today's Reminder from Devil's Develpers Team";
            messageObj.To.Add(myEmail);
            messageObj.Priority = MailPriority.High;
            messageObj.IsBodyHtml = true;
            messageObj.Body = $"<html><header>Your Latest Reminder</header><body> {reminder} </body></html> <br><br><p>Devils' Developers Team</p> ";
            try
            {
                client.Send(messageObj);

                MessageBox.Show("Message has been sent successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
                MessageBox.Show("Please fix the problem and resend it", "Error");
            }
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            sendEmail();
        }
    }
}
