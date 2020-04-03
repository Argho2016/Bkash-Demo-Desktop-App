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
    public partial class Request_Money : Form
    {
        public Request_Money()
        {
            InitializeComponent();
        }

        private void Request_Money_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("20 Taka has been added to your account");
            this.Hide();
            Homepage home = new Homepage();
            home.ShowDialog(); 
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage home = new Homepage();
            home.ShowDialog(); 
        }
    }
}
