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
        BindingList<Bill> archivesBillList = new BindingList<Bill>();
        public ArchivesForm()
        {
            InitializeComponent();
        }

        public ArchivesForm(Bill tmpArchiveBill)
        {
            archivesBillList.Add(tmpArchiveBill);
                      
            InitializeComponent();
            archivesListBox.DataSource = archivesBillList;
            archivesListBox.Refresh();
        }


    }
}
