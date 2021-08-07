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
    public partial class ticket_details_report : Form
    {
        public ticket_details_report()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin gg = new Admin();
            gg.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string type, price;

            type = comboBox1.SelectedItem.ToString();
            price = textBox1.Text;

            MySqlConnection sqlCon = null;
            string connection;
            connection = "server=127.0.0.1;database=esoftdb;user=root;SslMode=none";

            sqlCon = new MySqlConnection(connection);

            sqlCon.Open();
            MySqlCommand command;

            if (type == "Gold")
            {
                MySqlDataReader reader;
                command = new MySqlCommand(@"SELECT * FROM tickets WHERE dbtype='" + type + "'", sqlCon);
                reader = command.ExecuteReader();
                reader.Read();

                if (reader.HasRows)
                {
                    string dbprice;
                    dbprice = reader.GetString(1);
                    textBox1.Text =dbprice;
                    
                }
            }

            else if (type == "Premium")
            {
                MySqlDataReader reader;
                command = new MySqlCommand(@"SELECT * FROM tickets WHERE  dbtype='" + type + "'", sqlCon);
                reader = command.ExecuteReader();
                reader.Read();

                if (reader.HasRows)
                {
                    string dbprice;
                    dbprice = reader.GetString(1);
                    textBox1.Text = dbprice;

                }
            }
            else if (type == "Normal")
            {
                MySqlDataReader reader;
                command = new MySqlCommand(@"SELECT * FROM tickets WHERE  dbtype='" + type + "'", sqlCon);
                reader = command.ExecuteReader();
                reader.Read();

                if (reader.HasRows)
                {
                    string dbprice;
                    dbprice = reader.GetString(1);
                    textBox1.Text = dbprice;
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin hh = new Admin();
            hh.Show();
        }
    }
}
