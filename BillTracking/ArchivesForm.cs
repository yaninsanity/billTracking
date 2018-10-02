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
    public partial class ArchivesForm : Form
    {
        BindingList<Bill> myArchivesBillList = new BindingList<Bill>();
        public event BillDelegate TransferBill;

        public ArchivesForm(BindingList<Bill> e)
        {
            InitializeComponent();
            myArchivesBillList = e;
            archivesListBox.DataSource = e;
        }

        public ArchivesForm(Bill tmpArchiveBill)
        {
            myArchivesBillList.Add(tmpArchiveBill);
                      
            InitializeComponent();
            archivesListBox.DataSource = myArchivesBillList;
            archivesListBox.Refresh();
        }

        private void restoreButton_Click(object sender, EventArgs e)
        {
            if (archivesListBox.SelectedItem == null)
            {
                MessageBox.Show("Please select the item to restore", "Failed");
            }

            else

            {
                Bill tmpBill = (Bill)archivesListBox.SelectedItem;

                if (TransferBill != null)
                    TransferBill(this, tmpBill);

                myArchivesBillList.Remove(tmpBill);
                this.Close();
            }
        }

        private void homeLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
