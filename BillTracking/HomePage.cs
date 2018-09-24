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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void logoutLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Dialog Title", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                LoginForm objLoginForm = new LoginForm();
                objLoginForm.Show();
                this.Hide();
            }
            else
            {

            }
        }

        private void billMgtLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BillForm objBillForm = new BillForm();
            objBillForm.Show();
            this.Hide();
        }
    }
}