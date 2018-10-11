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
            string userName = usernameTextBox.Text;
            try
            {
                FileStream file = new FileStream(userName, FileMode.Open, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();
                file.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error Occured, Please check username");
                return;
            }

            HomePage objHomePage = new HomePage(userName);
            objHomePage.Show();
            this.Hide();
        }

        private void pinTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
