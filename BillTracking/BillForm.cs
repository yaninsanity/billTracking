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

namespace BillTracking
{
    public delegate void BillDelegate(object sender, Bill e);

    public partial class BillForm : Form
    {
        //Public event for the creation of an bill
        BindingList<Bill>myBillList = new BindingList<Bill>();
        BindingList<Bill> archiveList = new BindingList<Bill>();
        AddBillForm addBillForm;
        UpdateBillForm updateBillForm;

        Bill tmpBill;

        public BillForm(BindingList<Bill> e)
        {
            InitializeComponent();
            myBillList = e;
            billListBox.DataSource = e;
        }

        public BillForm(Bill tmpBill)
        {
            myBillList.Add(tmpBill);

            InitializeComponent();
            billListBox.DataSource = myBillList;
            billListBox.Refresh();
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
            myBillList.Add(e);
            billListBox.Refresh();
        }

        private void UpdateBillForm_BillUpdated(object sender, Bill e)
        {
            tmpBill = e;
            foreach(Bill tmpBill in myBillList)
            {
                if (tmpBill == e)
                {
                    myBillList.Remove((Bill)billListBox.SelectedItem);
                    return;
                }                  
            }   
        }

        private void updateButton_Click(object sender, EventArgs e)
        {

            if (billListBox.SelectedItem == null)
            { MessageBox.Show("Please select a bill", "Error"); }
            else
            {
                updateBillForm = new UpdateBillForm((Bill)billListBox.SelectedItem);
                updateBillForm.Show();
                updateBillForm.BillUpdated += new BillDelegate(this.UpdateBillForm_BillUpdated);
                updateBillForm.NewBillCreated += new BillDelegate(this.AddBillForm_BillCreated);
            }            
            
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (billListBox.SelectedItem == null)
            {
                MessageBox.Show("Please select the item to delete", "Failed");
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

        private void archiveButton_Click(object sender, EventArgs e)
        {
            if (billListBox.SelectedItem == null)
            {
                MessageBox.Show("Please select the item to archive", "Failed");
            }

            else
            {
                Bill tmpArchiveBill = (Bill)billListBox.SelectedItem;
                archiveList.Add(tmpArchiveBill);
                ArchivesForm objArchivePage = new ArchivesForm(archiveList);
                objArchivePage.TransferBill += new BillDelegate(this.AddBillForm_BillCreated);

                myBillList.Remove(tmpArchiveBill);
                billListBox.Refresh();
            }
            
            
        }

        private void viewArchivesLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ArchivesForm objArchivePage = new ArchivesForm(archiveList);
            objArchivePage.TransferBill += new BillDelegate(this.AddBillForm_BillCreated);
            objArchivePage.Show();
        }

        private void billListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
