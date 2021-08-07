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
    public partial class View_Customer_Details : Form
    {
        public View_Customer_Details()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employee ll = new Employee();
            ll.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string regno,username,nic,address,telno;

            regno = textBox1.Text;
            username = textBox2.Text;
            nic = textBox3.Text;
            address = textBox4.Text;
            telno = textBox5.Text;

            MySqlConnection sqlCon = null;
            string connection;
            connection = "server=127.0.0.1;database=esoftdb;user=root;SslMode=none";

            sqlCon = new MySqlConnection(connection);

            sqlCon.Open();//Connection is open

            MySqlCommand command;

            command = new MySqlCommand(@"DELETE FROM customer WHERE customer_ID='" + regno+ "'", sqlCon);
            command.ExecuteNonQuery();
            MessageBox.Show("Delete Customer");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string regno, username, nic, address, telno;

            regno = textBox1.Text;
            username = textBox2.Text;
            nic = textBox3.Text;
            address = textBox4.Text;
            telno = textBox5.Text;

            MySqlConnection sqlCon = null;
            string connection;
            connection = "server=127.0.0.1;database=esoftdb;user=root;SslMode=none";

            sqlCon = new MySqlConnection(connection);

            sqlCon.Open();//Connection is open

            MySqlCommand command;

            command = new MySqlCommand(@"INSERT INTO customer(customer_name,customer_ID,NIC,customer_TelNo,customer_Address)value('" + username + "','" + regno + "','" + nic + "','" + telno + "','" + address + "')", sqlCon);
            command.ExecuteNonQuery();
            MessageBox.Show("ADD CUSTOMER");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string regno, username, nic, address, telno;

            regno = textBox1.Text;
            username = textBox2.Text;
            nic = textBox3.Text;
            address = textBox4.Text;
            telno = textBox5.Text;

            MySqlConnection sqlCon = null;
            string connection;
            connection = "server=127.0.0.1;database=esoftdb;user=root;SslMode=none";

            sqlCon = new MySqlConnection(connection);

            sqlCon.Open();//Connection is open

            MySqlCommand command;
            MySqlDataReader reader;
            command = new MySqlCommand(@"SELECT * FROM customer WHERE customer_ID='" + regno + "'", sqlCon);
            reader = command.ExecuteReader();
            reader.Read();

            if (reader.HasRows)
            {
                string customer_name, NIC, customer_TelNo, customer_Password, customer_Address;
                customer_name = reader.GetString(0);
                NIC= reader.GetString(2);
                customer_TelNo = reader.GetString(3);
                customer_Password = reader.GetString(4);
                customer_Address = reader.GetString(5);


                textBox2.Text = customer_name;
                textBox3.Text = NIC;
                textBox4.Text = customer_TelNo;
                textBox5.Text = customer_Address;

            }
            else
            {
                MessageBox.Show("Invalied ID!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
