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
        BindingList<Bill>myBillList = new BindingList<Bill>();
        AddBillForm addBillForm;
        UpdateBillForm updateBillForm;

        public BillForm(BindingList<Bill> e)
        {
            InitializeComponent();
            //billListBox.Items.Add(e);                       ----(zy)
            myBillList = e;
            billListBox.DataSource = e;
        }
        
        private void logoutLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

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
            //billListBox.Items.Add(e.Name);                --zy
            myBillList.Add(e);
            billListBox.Refresh();
            //if (NewBillSaved != null)
            //    NewBillSaved(this, e);
        }

        private void updateButton_Click(object sender, EventArgs e)
        {

            if (billListBox.SelectedItem == null)
            { MessageBox.Show("Please select a bill", "Error"); }
            else
            {
                updateBillForm = new UpdateBillForm((Bill)billListBox.SelectedItem);
                updateBillForm.Show();
            }
            
            
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (billListBox.SelectedItem == null)
            {
                MessageBox.Show("Please select the item to delte", "Failed");
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this item?", "Warning", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    myBillList.Remove((Bill)billListBox.SelectedItem); 
                }
                else
                {

                }
            }
        }
    }
}
