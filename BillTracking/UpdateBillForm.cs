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
    public partial class UpdateBillForm : Form
    {
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


    }
}
