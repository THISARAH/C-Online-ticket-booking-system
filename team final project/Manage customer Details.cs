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
    public partial class Manage_customer_Details : Form
    {
        public Manage_customer_Details()
        {
            InitializeComponent();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            string username, registerno, NIC, address, telno, password;

            username= txtname.Text;
            registerno=txtreg .Text;
            NIC= txtnic.Text;
            address = txtaddress.Text;
            telno =txttel.Text;
            password = txtpass.Text;

            MySqlConnection sqlCon = null;
            string connection;
            connection = "server=127.0.0.1;database=esoftdb;user=root;SslMode=none";

            sqlCon = new MySqlConnection(connection);

            sqlCon.Open();//Connection is open

            MySqlCommand command;

            command = new MySqlCommand(@"DELETE FROM customer WHERE customer_ID='" + registerno + "'", sqlCon);
            command.ExecuteNonQuery();
            MessageBox.Show("Delete Customer");
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string username, registerno, NIC, address, telno, password;

            username = txtname.Text;
            registerno = txtreg.Text;
            NIC = txtnic.Text;
            address = txtaddress.Text;
            telno = txttel.Text;
            password = txtpass.Text;



            MySqlConnection sqlCon = null;
            string connection;
            connection = "server=127.0.0.1;database=esoftdb;user=root;SslMode=none";

            sqlCon = new MySqlConnection(connection);

            sqlCon.Open();//Connection is open

            MySqlCommand command;
            command = new MySqlCommand(@"UPDATE customer SET customer_name='" + username + "',customer_Address='" + address + "',customer_Password='" + password + "'WHERE customer_ID='" + registerno + "'", sqlCon);
            command.ExecuteNonQuery();
            MessageBox.Show("Update Customer");
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            string username, regno, nic, address, telno, password;

            username = txtname.Text;
            regno = txtreg.Text;
            nic = txtnic.Text;
            address = txtaddress.Text;
            telno = txttel.Text;
            password = txtpass.Text;

            MySqlConnection sqlCon = null;
            string connection;
            connection = "server=127.0.0.1;database=esoftdb;user=root;SslMode=none";

            sqlCon = new MySqlConnection(connection);

            sqlCon.Open();

            MySqlCommand command;
            MySqlDataReader reader;
            command = new MySqlCommand(@"SELECT*FROM customer WHERE customer_ID='" + regno + "'", sqlCon);
            reader = command.ExecuteReader();
            reader.Read();

            if (reader.HasRows)
            {
                string customer_name, NIC, customer_TelNo, customer_Password, customer_Address;
                customer_name = reader.GetString(0);
                NIC = reader.GetString(2);
                customer_TelNo = reader.GetString(3);
                customer_Password = reader.GetString(4);
                customer_Address = reader.GetString(5);

                txtname.Text = customer_name;
                txtnic.Text = NIC;
                txtaddress.Text = customer_Address;
                txttel.Text = customer_TelNo;
                txtpass.Text = customer_Password;
            }
            else
            {
                MessageBox.Show("Invalied ID!");
            }
        }

        private void btnexite_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 aa = new Form1();
            aa.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer hh = new Customer();
            hh.Show();
        }


                




    }
}
