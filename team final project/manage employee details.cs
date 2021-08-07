using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace team_final_project
{
    public partial class manage_employee_details : Form
    {
        public manage_employee_details()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string username, regno, nic, address, telno, password;

            username = te1.Text;
            regno = te2.Text;
            nic = te3.Text;
            address = te4.Text;
            telno = te5.Text;
            password = te6.Text;

            MySqlConnection sqlCon = null;
            string connection;
            connection = "server=127.0.0.1;database=esoftdb;user=root;SslMode=none";

            sqlCon = new MySqlConnection(connection);

            sqlCon.Open();

            MySqlCommand command;
            command = new MySqlCommand(@"UPDATE employee SET employee_user_name='" + username + "',employee_Reg_No='" + regno + "',NIC='" 
                + nic + "',employee_Address='" + address + "',employee_Tel_No='" + telno + "',employee_Password='" + password + 
                "'WHERE employee_Reg_No='" + regno + "'", sqlCon);
                 command.ExecuteNonQuery();
            MessageBox.Show("Update Employee!");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string username, regno, nic, address, telno, password;

            username = te1.Text;
            regno = te2.Text;
            nic = te3.Text;
            address = te4.Text;
            telno = te5.Text;
            password = te6.Text;

            MySqlConnection sqlCon = null;
            string connection;
            connection = "server= 127.0.0.1 ;database=esoftdb;user=root;SslMode=none";

            sqlCon = new MySqlConnection(connection);

            sqlCon.Open();

            MySqlCommand command;
            command = new MySqlCommand(@"DELETE FROM employee WHERE employee_Reg_No='" + regno + "'", sqlCon);
            command.ExecuteNonQuery();
            MessageBox.Show("Delete Employee");        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username,regno,nic,address,telno, password;

            username = te1.Text;
            regno = te2.Text;
            nic = te3.Text;
            address = te4.Text;
            telno = te5.Text;
            password = te6.Text;

            MySqlConnection sqlCon = null;
            string connection;
            connection = "server=127.0.0.1;database=esoftdb;user=root;SslMode=none";

            sqlCon = new MySqlConnection(connection);

            sqlCon.Open();

            MySqlCommand command;
            MySqlDataReader reader;
            command = new MySqlCommand(@"SELECT * FROM employee WHERE employee_Reg_No='" + regno + "'", sqlCon);
            reader=command.ExecuteReader();
            reader.Read();

            if (reader.HasRows)
            {
                string employee_user_name, NIC, employee_Address, employee_Tel_No, employee_Password;
                employee_user_name = reader.GetString(0);
                NIC= reader.GetString(2);
                employee_Address = reader.GetString(3);
                employee_Tel_No = reader.GetString(4);
                employee_Password = reader.GetString(5);

                te1.Text = employee_user_name;
                te3.Text = NIC;
                te4.Text = employee_Address;
                te5.Text = employee_Tel_No;
                te6.Text = employee_Password;

            }
            else
            {
                MessageBox.Show("Invalied ID!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        
        {
            string username, regno, nic, address, telno, password;
            username = te1.Text;
            regno = te2.Text;
            nic = te3.Text;
            address = te4.Text;
            telno = te5.Text;
            password = te6.Text;

            MySqlConnection sqlCon = null;
            string connection;
            connection = "server=127.0.0.1;database= esoftdb;user=root;SslMode=none";

            sqlCon = new MySqlConnection(connection);

            sqlCon.Open();

            MySqlCommand command;

            command = new MySqlCommand(@"INSERT INTO employee(employee_user_name,employee_Reg_No,NIC,employee_Address,employee_Tel_No,employee_Password)value('" + username + "','" + regno + "','" + nic + "','" + address + "','" + telno + "','" + password + "')", sqlCon);
            command.ExecuteNonQuery();
            MessageBox.Show("add Employee");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            te1.Clear();
            te2.Clear();
            te3.Clear();
            te4.Clear();
            te5.Clear();
            te6.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin hh=new Admin();
            hh.Show();

        }

        private void manage_employee_details_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            /*
            this button use for click
                /*/
        }
    }
}
