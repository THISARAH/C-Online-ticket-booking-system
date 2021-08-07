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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void ba1_Click(object sender, EventArgs e)
        {
            this.Hide();
            manage_employee_details aa = new manage_employee_details();
            aa.Show();
        }

        private void ba2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ticket_details_report vv = new ticket_details_report();
            vv.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 ee = new Form1();
            ee.Show();
        }
    }
}
