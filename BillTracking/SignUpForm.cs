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

namespace BillTracking
{
    public delegate void AccountCreated(object sender, EventArgs e);
    public partial class SignUpForm : Form
    {
        //List to contain the created account
        public List<Account> accountList = new List<Account>();

        //List to contain personal bills
        public BindingList<Bill> BillMasterList = new BindingList<Bill>();


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
            //////////We should change this to a dialog on the bottom of the window.
            MessageBox.Show("Account Created Successfully");

            //Save the accounts into a data file
            FileStream file = new FileStream("userAccounts.dat", FileMode.Create, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(file, accountList);
            file.Close();

            //Save the account individual bill
            FileStream userFile = new FileStream(usernameTextBox.Text, FileMode.Create, FileAccess.Write);
            BinaryFormatter userBF = new BinaryFormatter();
            userBF.Serialize(userFile, BillMasterList);
            userFile.Close();

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
