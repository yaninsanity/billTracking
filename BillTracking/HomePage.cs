using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace BillTracking
{
    public partial class HomePage : Form
    {
        public BindingList<Bill> BillMasterList = new BindingList<Bill>();
        BillForm BillForm;
        string accountName;
        bool success = true;
        string email;
        double monthlyIncome;
        string pin;

        public HomePage()
        {
            InitializeComponent();
        }

        public HomePage(string userName,string tmpEmail,string pin, double monthlyIncome)
        {
            InitializeComponent();
            accountName = userName;
            email = tmpEmail;
            this.pin = pin;
            this.monthlyIncome = monthlyIncome;
        }

        private void logoutLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                //This is where saving needs to be implemented.
                FileStream file = new FileStream(accountName, FileMode.Create, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(file, BillMasterList);
                file.Close();


                //Open back the loggin form
                LoginForm LoginForm = new LoginForm();
                LoginForm.Show();
                this.Close();
            }
            else
            {

            }
        }

        private void billMgtLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BillForm.Show();
        }

        private void SetEventHandlers_Load(object sender, EventArgs e)
        {
            
            //load from dat file
                FileStream file = new FileStream(accountName, FileMode.Open, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();
                BillMasterList = (BindingList<Bill>)bf.Deserialize(file);
                file.Close();
 
            BillForm = new BillForm(BillMasterList);
        }

        private void ManageBillForm_BillCreated(object sender, Bill e)
        {
            BillMasterList.Add(e);
        }

        private void referLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EmailForm EmailForms = new EmailForm();
            EmailForms.Show();
        }

        private void accountMgtLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Account tmpAccount = new Account(accountName, pin, email, monthlyIncome);
            AccountManagementForm actMgtForm = new AccountManagementForm(tmpAccount);
            actMgtForm.Show();
            //this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Reminder myReminderForm = new Reminder(email,BillMasterList);
            myReminderForm.Show();
            
        }
    }
}
