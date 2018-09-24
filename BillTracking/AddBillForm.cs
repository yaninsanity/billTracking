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

    //Need to create a link between main form list and this list to refresh when something is added to this form.

    public partial class AddBillForm : Form
    {
        List<Bill> BillList = new List<Bill>();

        double Amount;            

        public AddBillForm()
        {
            InitializeComponent();            
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            BillForm BillTracking = new BillForm();
            BillTracking.Show();
            this.Hide();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            try
            {
                Amount = Convert.ToDouble(AmountTextBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter only numbers & decimals into the Amount Text Box");
                return;
            }

            Bill NewBill = new Bill(NameTextBox.Text, BillDateTime.Text, Amount, recurrenceComboBox.Text);
            BillList.Add(NewBill);
            BillForm BillTracking = new BillForm();
            BillTracking.Show();
            this.Hide();
        }
    }
}
