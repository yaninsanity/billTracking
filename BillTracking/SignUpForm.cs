using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillTracking
{
    public partial class SignUpForm : Form
    {
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

            //intantiate an account after all the info are entered
            
        }
    }
}
