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
    //Need to link this form to the main form to grab the list info synced from AddBillForm when a bill is changed.

    public partial class BillForm : Form
    {
        public BillForm()
        {
            InitializeComponent();
        }

        private void logoutLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Dialog Title", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                LoginForm objLoginForm = new LoginForm();
                objLoginForm.Show();
                this.Hide();
            }
            else
            {

            }
        }

        private void homeLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HomePage objHomePage = new HomePage();
            objHomePage.Show();
            this.Hide();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddBillForm addBillForm = new AddBillForm();
            addBillForm.Show();
            this.Hide();
        }
    }
}
