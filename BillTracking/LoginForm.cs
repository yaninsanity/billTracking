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
            List<Account> accList;
            string userName = usernameTextBox.Text;
            double monthlyIncome = 0;
            string userEmail="";
            string pin = "";
            try
            {
                FileStream file = new FileStream("userAccounts.dat", FileMode.Open, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();
                accList = (List<Account>)bf.Deserialize(file);
                file.Close();
            }
            catch (Exception  tmpE)
            {
                MessageBox.Show("Error Occured, Please check username");
                MessageBox.Show(tmpE.Message);
                return;
            }

           
            foreach (Account acc in accList)
            {
                if (acc.Username == usernameTextBox.Text)
                {
                    pin = acc.Pin;
                    userEmail = acc.Email;
                    monthlyIncome = acc.MonthlyIncome;
                }
            }

            if (pinTextBox.Text != pin)
            {
                MessageBox.Show("Wrong Password,Please retry your password");

            }
            else
            {
                try
                {
                    FileStream file = new FileStream(userName, FileMode.Open, FileAccess.Read);
                    BinaryFormatter bf = new BinaryFormatter();
                    
                    file.Close();
                }
                catch (Exception tmpE)
                {
                    MessageBox.Show("Error Occured, Please check username");
                    MessageBox.Show(tmpE.Message);
                    return;
                }


                HomePage objHomePage = new HomePage(userName, userEmail,pin,monthlyIncome);
                objHomePage.Show();
                this.Hide();
            }
           
        }

        private void pinTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


      