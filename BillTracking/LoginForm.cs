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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            // creates an asterisk in the password textbox
            pinTextBox.PasswordChar = '*';

            // if we want to have a max length for password, uncomment bottom line
            //pinTextBox.MaxLength = 4;
        }

        private void signUpLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpForm objSignUpForm = new SignUpForm();
            objSignUpForm.Show();
            this.Hide();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            HomePage objHomePage = new HomePage();
            objHomePage.Show();
            this.Hide();
        }

    }
}
