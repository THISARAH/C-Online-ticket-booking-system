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
    public partial class Manage_ticket_details : Form
    {
        public Manage_ticket_details()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string type, price;

            type = comboBox1.SelectedItem.ToString();
            price = textBox1.Text;

            MySqlConnection sqlCon = null;
            string connection;
            connection = "server=127.0.0.1;database=esoftdb;user=root;SslMode=none";

            sqlCon = new MySqlConnection(connection);

            sqlCon.Open();//Connection is open

            MySqlCommand command;

            command = new MySqlCommand(@"INSERT INTO tickets(dbtype,dbprice)value('" + type + "','" + price + "')", sqlCon);
            command.ExecuteNonQuery();
            MessageBox.Show("Add Succefull");
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string type, price;

            type = comboBox1.SelectedItem.ToString();
            price = textBox1.Text;

            MySqlConnection sqlCon = null;
            string connection;
            connection = "server=127.0.0.1;database=esoftdb;user=root;SslMode=none";

            sqlCon = new MySqlConnection(connection);

            sqlCon.Open();//Connection is open

            MySqlCommand command;
            command = new MySqlCommand(@"UPDATE tickets SET dbprice='" + price + "'WHERE dbtype='" + type + "'", sqlCon);
            command.ExecuteNonQuery();
            MessageBox.Show("Update Succefull");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string type, price;

            type = comboBox1.SelectedItem.ToString();
            price = textBox1.Text;

            MySqlConnection sqlCon = null;
            string connection;
            connection = "server=127.0.0.1;database=esoftdb;user=root;SslMode=none";

            sqlCon = new MySqlConnection(connection);

            sqlCon.Open();//Connection is open

            MySqlCommand command;
            MySqlDataReader reader;
            command = new MySqlCommand(@"SELECT * FROM tickets WHERE dbtype='" + type + "'", sqlCon);
            reader = command.ExecuteReader();
            reader.Read();

            if (reader.HasRows)
            {
                string dbprice;
                dbprice = reader.GetString(1);

                textBox1.Text = dbprice;
            }
            else
            {
                MessageBox.Show("Invalied Ticket!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string type, price;

            type = comboBox1.SelectedItem.ToString();
            price = textBox1.Text;

            MySqlConnection sqlCon = null;
            string connection;
            connection = "server=127.0.0.1;database=esoftdb;user=root;SslMode=none";

            sqlCon = new MySqlConnection(connection);

            sqlCon.Open();//Connection is open

            MySqlCommand command;

            command = new MySqlCommand(@"DELETE FROM tickets WHERE dbtype='" + type + "'", sqlCon);
            command.ExecuteNonQuery();
            MessageBox.Show("Delete Succefull");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 jj = new Form1();
            jj.Show();
        }
    }
}
