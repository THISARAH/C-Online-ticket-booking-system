using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace team_final_project
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void bc1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manage_customer_Details aa = new Manage_customer_Details();
            aa.Show();
        }

        private void bc2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Select_Musical_Show qq = new Select_Musical_Show();
            qq.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 jj = new Form1();
            jj.Show();

        }
    }
}
