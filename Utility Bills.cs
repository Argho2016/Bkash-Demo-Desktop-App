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
    public partial class Utility_Bills : Form
    {
        public Utility_Bills()
        {
            InitializeComponent();
        }

        private void Utility_Bills_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage home = new Homepage();
            home.ShowDialog(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            electric_bill elec = new electric_bill();
            elec.ShowDialog(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Water_bill water = new Water_bill();
            water.ShowDialog(); 
        }
    }
}
