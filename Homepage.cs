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
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void Homepage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Check_Balance check = new Check_Balance();
            check.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Request_Money req = new Request_Money();
            req.ShowDialog(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Utility_Bills bills = new Utility_Bills();
            bills.ShowDialog(); 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bill_Sharing share = new Bill_Sharing();
            share.ShowDialog(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Send_Money send = new Send_Money();
            send.ShowDialog(); 
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Friend friend = new Add_Friend();
            friend.ShowDialog(); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Recharge recharge = new Recharge();
            recharge.ShowDialog(); 
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Budget_Money budjet = new Budget_Money();
            budjet.ShowDialog();  
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 log = new Form1();
            log.ShowDialog(); 
        }
    }
}
