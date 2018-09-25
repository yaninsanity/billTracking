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
    public partial class BillForm : Form
    {
        //Public event for the creation of an bill
        public event BillDelegate NewBillSaved;

        AddBillForm addBillForm;

        public BillForm(List<Bill> e)
        {
            InitializeComponent();
            billListBox.Items.Add(e);
        }
        
        private void logoutLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Dialog Title", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {

            }
        }

        private void homeLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            addBillForm.Show();
        }

        private void SetEventHandlers_Load(object sender, EventArgs e)
        {
            addBillForm = new AddBillForm();
            addBillForm.NewBillCreated += new BillDelegate(this.AddBillForm_BillCreated);
        }

        private void AddBillForm_BillCreated(object sender, Bill e)
        {
            billListBox.Items.Add(e.Name);
            if (NewBillSaved != null)
                NewBillSaved(this, e);
        }
    }
}
