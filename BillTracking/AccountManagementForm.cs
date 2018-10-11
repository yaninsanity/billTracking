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

namespace BillTracking
{
    public partial class AccountManagementForm : Form
    {
        Account myAccountInfo;
        public AccountManagementForm()
        {
            InitializeComponent();

            pinTextBox.PasswordChar = '*';                        
        }

        public AccountManagementForm(Account myAcc)

        {
            myAccountInfo = myAcc;
            InitializeComponent();
            usernameTextBox.Text = myAcc.Username;
            pinTextBox.Text = myAcc.Pin;
            emailTextBox.Text = myAcc.Email;
            monthlyIncomeTextbox.Text=myAcc.MonthlyIncome.ToString();
        }

        private void homeLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
        }

        public void saveValidation()
        {
            //condition to test the username, pin and email not null
            if (usernameTextBox.Text == String.Empty ||
                pinTextBox.Text == String.Empty ||
                emailTextBox.Text == String.Empty ||
                monthlyIncomeTextbox.Text==string.Empty)
            {
                MessageBox.Show("Please enter all required fields");
                return;
            }

            //condition to test username to not have space or special characters
            Regex rgex = new Regex("[^a-zA-Z0-9]");

            if (rgex.IsMatch(usernameTextBox.Text))
            {
                MessageBox.Show("Please do not have a space or special character in the username");
                return;
            }

            //condition to test the pin to be only number

            Regex rgexPin = new Regex("[^0-9]");

            if (rgexPin.IsMatch(pinTextBox.Text))
            {
                MessageBox.Show("Please only enter numbers for your pin");
                return;
            }


         

            //condition to test the email to include the @ sign
            Regex rgexEmail = new Regex(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");

            if (!rgexEmail.IsMatch(emailTextBox.Text))
            {
                MessageBox.Show("Please enter a valid email");
                return;
            }

            //monthlyIncome
            Regex rgexMI= new Regex("[^0-9]");

            if (rgexMI.IsMatch(monthlyIncomeTextbox.Text))
            {
                MessageBox.Show("Please only enter numbers for your Income");
                return;
            }


        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            saveValidation();

            myAccountInfo.Username = usernameTextBox.Text;
            myAccountInfo.Pin = pinTextBox.Text;
            myAccountInfo.Email = emailTextBox.Text;
            myAccountInfo.MonthlyIncome = double.Parse(monthlyIncomeTextbox.Text);




        }
    }
}
