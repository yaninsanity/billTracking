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
    public partial class EmailForm : Form
    {
        public EmailForm()
        {
            InitializeComponent();
        }


        private void sendButton_Click(object sender, EventArgs e)
        {
            if (emailTextbox.Text == String.Empty)
            {
                MessageBox.Show("Please enter the Email Address");
                return;
            }
            Regex rgexEmail = new Regex(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            if (!rgexEmail.IsMatch(emailTextbox.Text))
            {
                MessageBox.Show("Please enter a valid email");
                return;
            }
            MessageBox.Show("Email Sent Successfully");
            emailTextbox.Clear()    ;           
        }

        private void emailTextbox_Click(object sender, EventArgs e)
        {
            emailTextbox.Clear();
        }
    }
}
