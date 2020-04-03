﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bkash
{
    public partial class electric_bill : Form
    {
        public electric_bill()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Utility_Bills bills = new Utility_Bills();
            bills.ShowDialog(); 
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Electric Bill has been paid");
            this.Hide();
            Utility_Bills bills = new Utility_Bills();
            bills.ShowDialog(); 
        }

        private void electric_bill_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); 
        }
    }
}
