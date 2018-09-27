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
    public partial class AddBillForm : Form
    {
        //Public event for the creation of an bill
        public event BillDelegate NewBillCreated;

        double Amount;

        public AddBillForm()
        {
            InitializeComponent();            
        }              

        private void CancelButton_Click(object sender, EventArgs e)
        {
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

            Bill tmpBill = new Bill(NameTextBox.Text, BillDateTime.Text, Amount, recurrenceComboBox.Text);

            if (NewBillCreated != null)
                NewBillCreated(this, tmpBill);

            //Message Box to tell an account was created succesfully
            MessageBox.Show("Bill Created Successfully");

            NameTextBox.Text = null;
            BillDateTime.Text = null;
            AmountTextBox.Text = null;
            recurrenceComboBox.Text = null;

            this.Hide();
    
        }
    }
}
