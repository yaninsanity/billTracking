﻿using System;
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
    public partial class UpdateBillForm : Form
    {
        public event BillDelegate BillUpdated;

        double Amount;

        public UpdateBillForm(object selectedItem)
        {
            InitializeComponent();

            if (selectedItem is Bill)
            {
                Bill tmpItem = (Bill)selectedItem;
                NameTextBox.Text = tmpItem.Name;
                BillDateTime.Text = tmpItem.Date;
                AmountTextBox.Text = tmpItem.Amount.ToString();
                recurrenceComboBox.Text = tmpItem.Recurrence;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
              double  Amount = Convert.ToDouble(AmountTextBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter only numbers & decimals into the Amount Textbox","Failed");
                return;
            }

            Bill tmpBill = new Bill(NameTextBox.Text, BillDateTime.Text, Amount, recurrenceComboBox.Text);

            if (BillUpdated != null)
                BillUpdated(this, tmpBill);

            //Message Box to tell an account was created succesfully
            MessageBox.Show("Bill Created Successfully");

            NameTextBox.Text = null;
            BillDateTime.Text = null;
            AmountTextBox.Text = null;
            recurrenceComboBox.Text = null;

            this.Close();                                 
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
