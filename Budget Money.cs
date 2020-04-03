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
    public partial class Budget_Money : Form
    {
        public Budget_Money()
        {
            InitializeComponent();
        }

        private void Budget_Money_FormClosing(object sender, FormClosingEventArgs e)
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
            Change_budjet change = new Change_budjet();
            change.ShowDialog(); 
        }
    }
}
