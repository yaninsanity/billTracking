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
    public partial class Reminder : Form
    {
        BindingList<Bill> myList = new BindingList<Bill>();
        List<Bill> reminderList = new List<Bill>();
        String reminder = "";
        public Reminder()
        {
            InitializeComponent();
        }


        public Reminder(String email,BindingList<Bill> billList)
        {
            InitializeComponent();
            //pass value into global varible
            myList = billList;
            FindDueDate();



        }

        public void FindDueDate()
        {
            double todayDay = DateTime.Today.Day;

            foreach (Bill b in myList)
            {
                double billDay = double.Parse(b.Date.Substring(2, 2));
                double dayDiff=Math.Abs(billDay - todayDay);

                if (dayDiff <= 3)
                {
                    reminderList.Add(b);

                }

              
            }


            if (reminderList == null)
            {
                reminder = "There are no coming up bills.";
            }

            else

            {
                reminder = $"There are {reminderList.Count()} bills coming up. Please check track these bills: ";
                foreach (Bill b in myList)
                {
                    reminder += b.Name + ", ";
                }
                reminder += ".";
            }

        }
    }
}
