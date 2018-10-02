using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillTracking
{
    [Serializable]
    public partial class Bill
    {
        string name;
        string date;
        double amount;
        string recurrence;

        public Bill(string name, string date, double amount, string recurrence)
        {
            this.name = name;
            this.date = date;
            this.amount = amount;
            this.recurrence = recurrence;
        }

        public string Name { get => name; set => name = value; }
        public string Date { get => date; set => date = value; }
        public double Amount { get => amount; set => amount = value; }
        public string Recurrence { get => recurrence; set => recurrence = value; }




        public override string ToString()
        {
            return Name;
        }
    }  
}
