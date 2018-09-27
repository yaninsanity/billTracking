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
    public partial class HomePage : Form
    {
        public BindingList<Bill> BillMasterList = new BindingList<Bill>();
        BillForm BillForm;

        public HomePage()
        {
            InitializeComponent();
        }

        private void logoutLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                //This is where saving needs to be implemented.
                LoginForm LoginForm = new LoginForm();
                LoginForm.Show();
                this.Close();
            }
            else
            {

            }
        }

        private void billMgtLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BillForm.Show();
        }

        private void SetEventHandlers_Load(object sender, EventArgs e)
        {
            BillForm = new BillForm(BillMasterList);
        }

        private void ManageBillForm_BillCreated(object sender, Bill e)
        {
            BillMasterList.Add(e);
        }
    }
}
