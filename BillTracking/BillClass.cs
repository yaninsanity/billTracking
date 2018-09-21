using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillTracking
{
    class BillClass
    {
        string name;
        string date;
        double amount;
        string[] recurrence = new string[] {"Daily", "Weekly", "Monthly", "Yearly" };
        string[] day = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

        public BillClass(string name, string date, double amount, string[] recurrence, string[] day)
        {
            this.name = name;
            this.date = date;
            this.amount = amount;
            this.recurrence = recurrence;
            this.day = day;
        }

        public string Name { get => name; set => name = value; }
        public string Date { get => date; set => date = value; }
        public double Amount { get => amount; set => amount = value; }
        public string[] Recurrence { get => recurrence; }
        public string[] Day { get => day; }
    }  
}
