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
    public partial class LoginSignupForm : Form
    {
        public LoginSignupForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            LoginForm objLoginForm = new LoginForm();
            objLoginForm.Show();
            this.Hide();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            SignUpForm objSignUpForm = new SignUpForm();
            objSignUpForm.Show();
            this.Hide();

        }
    }
}
