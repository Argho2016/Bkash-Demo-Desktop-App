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
    public partial class Recharge : Form
    {
        public Recharge()
        {
            InitializeComponent();
        }

        private void Recharge_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Recharge has been done");
           // this.Hide();
           // Homepage home = new Homepage();
           // home.ShowDialog(); 
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage home = new Homepage();
            home.ShowDialog(); 
        }
    }
}
