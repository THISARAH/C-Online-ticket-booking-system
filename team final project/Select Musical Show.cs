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
    public partial class Select_Musical_Show : Form
    {
        public Select_Musical_Show()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string Showname,Venue,Date,Time;

            Showname = showtype.Text;
            Venue = textbox1.Text;
            Date = textbox2.Text;
            Time = textbox3.Text;

            MySqlConnection sqlCon = null;
            string connection;
            connection = "server=127.0.0.1;database=esoftdb;user=root;SslMode=none";

            sqlCon = new MySqlConnection(connection);

            sqlCon.Open();//Connection is open

            MySqlCommand command;
            MySqlDataReader reader;
            command = new MySqlCommand(@"SELECT * FROM musicalshow WHERE showname='" + Showname + "'", sqlCon);
            reader = command.ExecuteReader();
            reader.Read();

            if (reader.HasRows)
            {
                string venue, date, time;
                venue= reader.GetString(1);
                date= reader.GetString(2);
                time = reader.GetString(3);

                textbox1.Text = venue;
                textbox2.Text = date;
                textbox3.Text = time;
            }
            else
            {
                MessageBox.Show("Invalied SHOW!");
            }

        }

        private void showtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Showname, Venue, Date, Time;

            Showname = showtype.SelectedItem.ToString();
            Venue = textbox1.Text;
            Date = textbox2.Text;
            Time = textbox3.Text;

            MySqlConnection sqlCon = null;
            string connection;
            connection = "server=127.0.0.1;database=esoftdb;user=root;SslMode=none";

            sqlCon = new MySqlConnection(connection);

            sqlCon.Open();
            MySqlCommand command;

            if (Showname == "SAHARA FLASH")
            {
                MySqlDataReader reader;
                command = new MySqlCommand(@"SELECT * FROM musicalshow WHERE showname='" + Showname + "'", sqlCon);
                reader = command.ExecuteReader();
                reader.Read();

                if (reader.HasRows)
                {
                    string venue, date, time;
                    venue = reader.GetString(1);
                    date = reader.GetString(2);
                    time = reader.GetString(3);

                    textbox1.Text = venue;
                    textbox2.Text = date;
                    textbox3.Text = time;
                }
            }

            else if(Showname == "BnS")
            {
                 MySqlDataReader reader;
                command = new MySqlCommand(@"SELECT * FROM musicalshow WHERE showname='" + Showname + "'", sqlCon);
                reader = command.ExecuteReader();
                reader.Read();

                if (reader.HasRows)
                {
                    string venue, date, time;
                    venue = reader.GetString(1);
                    date = reader.GetString(2);
                    time = reader.GetString(3);

                    textbox1.Text = venue;
                    textbox2.Text = date;
                    textbox3.Text = time;
                }
            }
            else if(Showname=="WAYO")
            {
                MySqlDataReader reader;
                command = new MySqlCommand(@"SELECT * FROM musicalshow WHERE showname='" + Showname + "'", sqlCon);
                reader = command.ExecuteReader();
                reader.Read();

                if (reader.HasRows)
                {
                    string venue, date, time;
                    venue = reader.GetString(1);
                    date = reader.GetString(2);
                    time = reader.GetString(3);

                    textbox1.Text = venue;
                    textbox2.Text = date;
                    textbox3.Text = time;
                }
            }
            else if(Showname=="FLASHBACK")
            {
                MySqlDataReader reader;
                command = new MySqlCommand(@"SELECT * FROM musicalshow WHERE showname='" + Showname + "'", sqlCon);
                reader = command.ExecuteReader();
                reader.Read();




                if (reader.HasRows)
                {
                    string venue, date, time;
                    venue = reader.GetString(1);
                    date = reader.GetString(2);
                    time = reader.GetString(3);

                    textbox1.Text = venue;
                    textbox2.Text = date;
                    textbox3.Text = time;
                }
                else
                {
                    MessageBox.Show("Invalied Show");
                } 
            }
            else if (Showname == "LINEONE")
            {
                MySqlDataReader reader;
                command = new MySqlCommand(@"SELECT * FROM musicalshow WHERE showname='" + Showname + "'", sqlCon);
                reader = command.ExecuteReader();
                reader.Read();




                if (reader.HasRows)
                {
                    string venue, date, time;
                    venue = reader.GetString(1);
                    date = reader.GetString(2);
                    time = reader.GetString(3);

                    textbox1.Text = venue;
                    textbox2.Text = date;
                    textbox3.Text = time;
                }
                else
                {
                    MessageBox.Show("Invalied Show");
                }
            }
            else if (Showname == "NonStop")
            {
                MySqlDataReader reader;
                command = new MySqlCommand(@"SELECT * FROM musicalshow WHERE showname='" + Showname + "'", sqlCon);
                reader = command.ExecuteReader();
                reader.Read();




                if (reader.HasRows)
                {
                    string venue, date, time;
                    venue = reader.GetString(1);
                    date = reader.GetString(2);
                    time = reader.GetString(3);

                    textbox1.Text = venue;
                    textbox2.Text = date;
                    textbox3.Text = time;
                }
                else
                {
                    MessageBox.Show("Invalied Show");
                }
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Select_Ticket rr = new Select_Ticket();
            rr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer kk = new Customer();
            kk.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textbox1.Clear();
            textbox2.Clear();
            textbox3.Clear();
        }
    }
}
