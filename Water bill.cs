using System;
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
    public partial class Water_bill : Form
    {
        public Water_bill()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Utility_Bills bills = new Utility_Bills();
            bills.ShowDialog(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Water Bill has been paid");
            this.Hide();
            Utility_Bills bills = new Utility_Bills();
            bills.ShowDialog(); 
        }

        private void Water_bill_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); 
        }
    }
}
