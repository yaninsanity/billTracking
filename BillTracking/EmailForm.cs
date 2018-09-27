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
    public partial class EmailForm : Form
    {
        public EmailForm()
        {
            InitializeComponent();
        }


        private void sendButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Email Sent Successfully");
            emailTextbox.Text =null;
        }

        private void emailTextbox_TextChanged(object sender, EventArgs e)
        {
            emailTextbox.Text = null;
        }
    }
}
