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
    public partial class Check_Balance : Form
    {
        public Check_Balance()
        {
            InitializeComponent();
        }

        private void Check_Balance_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
