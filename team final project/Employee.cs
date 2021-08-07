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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            View_Customer_Details zz = new View_Customer_Details();
            zz.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 yy = new Form1();
            yy.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manage_ticket_details ff = new Manage_ticket_details();
            ff.Show();
        }
    }
}
