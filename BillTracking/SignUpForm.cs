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
    public delegate void AccountCreated(object sender, EventArgs e);
    public partial class SignUpForm : Form
    {
        //List to contain the created account
        public List<Account> accountList = new List<Account>();


        public SignUpForm()
        {   
            InitializeComponent();
            // creates an asterisk in the password textbox
            pinTextBox.PasswordChar = '*';
            reEnterPinTextBox.PasswordChar = '*';
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm objLoginForm = new LoginForm();
            objLoginForm.Show();
            this.Hide();
        }

        //Public event for the creation of an account
        public event AccountCreated NewAccountCreated;

        //Actions for the click event
        private void signUpButton_Click(object sender, EventArgs e)
        {
            //condition to test the username, pin and email not null
            if (usernameTextBox.Text == String.Empty ||
                pinTextBox.Text == String.Empty ||
                emailTextBox.Text == String.Empty)
            {
                MessageBox.Show("Please enter all required fields");
                return;
            }

            //condition to test username to not have space or special characters
            Regex rgex = new Regex("[^a-zA-Z0-9]");

            if (rgex.IsMatch(usernameTextBox.Text))
            {
                MessageBox.Show("Please do not have space or special character in the username");
                return;
            }

            //condition to test the pin to be only number

            Regex rgexPin = new Regex("[^0-9]");

            if (rgexPin.IsMatch(pinTextBox.Text))
            {
                MessageBox.Show("Please only enter number for pin");
                return;
            }

            //condition to test the pin to be re-entered
            if (reEnterPinTextBox.Text == String.Empty)
            {
                MessageBox.Show("Please re-enter you pin");
                return;
            }

            //condition to test the matching of the pin and re-pin
            if (reEnterPinTextBox.Text != pinTextBox.Text)
            {
                MessageBox.Show("Please re-enter your pin");
                return;
            }

            //condition to test the email to include the @ sign
            Regex rgexEmail = new Regex(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");

            if (!rgexEmail.IsMatch(emailTextBox.Text))
            {
                MessageBox.Show("Please enter a valid email");
                return;
            }

            //intantiate an account after all the info are entered
            Account tmpAccount = new Account(usernameTextBox.Text, pinTextBox.Text, emailTextBox.Text);

            //Add the created account to a BindingList
            accountList.Add(tmpAccount);

            //Message Box to tell an account was created succesfully
            MessageBox.Show("Account Created Successfully");

            //Clear out all the fields for next account
            usernameTextBox.Clear();
            pinTextBox.Clear();
            reEnterPinTextBox.Clear();
            emailTextBox.Clear();
            //focus on the username textbox
            usernameTextBox.Focus();

        }
    }
}
