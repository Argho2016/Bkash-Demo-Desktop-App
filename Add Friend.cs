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
    public partial class Add_Friend : Form
    {
        public Add_Friend()
        {
            InitializeComponent();
        }

        private void Add_Friend_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Friend Added Succesully");
            textBox1.Text = string.Empty;
            textBox3.Text = string.Empty;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage home = new Homepage();
            home.ShowDialog(); 
        }
    }
}
