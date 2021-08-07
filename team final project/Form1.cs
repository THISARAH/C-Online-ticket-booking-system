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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void blogin_Click(object sender, EventArgs e)
        {
            string usertype;
            string username;
            string userpassword;

            usertype = comboBox1.SelectedItem.ToString();
            username = t1.Text;
            userpassword = t2.Text;

            MySqlConnection sqlCon = null;
            string connection;
            connection = "server=127.0.0.1;database=esoftdb;user=root;SslMode=none";

            sqlCon = new MySqlConnection(connection);

            sqlCon.Open();

            MySqlCommand command;
            MySqlDataReader reader;

            if(usertype=="Admin")
            {
                command=new MySqlCommand(@"SELECT*FROM admin WHERE admin_name='"+username+"'",sqlCon);

                reader=command.ExecuteReader();
                reader.Read();

                if(reader.HasRows)
                {
                    string databaseUserName;
                    string databasePassword;

                    databaseUserName=reader.GetString(1);
                    databasePassword=reader.GetString(3);

                    if(userpassword==databasePassword)
                    {
                        this.Hide();
                        Admin ss = new Admin();
                        ss.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalied Passsword !");
                    }
                }
                else
                {
                    MessageBox.Show("Invalied User Name !");
                }
            }
            if (usertype == "Employee")
            {
                command = new MySqlCommand(@"SELECT * FROM employee WHERE employee_user_name ='" +username +"'", sqlCon);

                reader = command.ExecuteReader();
                reader.Read();

                if (reader.HasRows)
                {
                    string databaseUserName;
                    string databasePassword;

                    databaseUserName = reader.GetString(0);
                    databasePassword = reader.GetString(5);

                    if (userpassword == databasePassword)
                    {
                        this.Hide();
                        Employee ss = new Employee();
                        ss.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalied Password !");
                    }
                }
                else
                {
                    MessageBox.Show("Invalied User Name !");
                }
            }
            if (usertype == "Customer")
            {
                command = new MySqlCommand(@"SELECT * FROM customer WHERE customer_name='" + username + "'", sqlCon);

                reader = command.ExecuteReader();
                reader.Read();

                if (reader.HasRows)
                {
                    string databaseUserName;
                    string databasePassword;

                    databaseUserName = reader.GetString(0);
                    databasePassword = reader.GetString(4);

                    if (userpassword == databasePassword)
                    {
                        this.Hide();
                        Customer ss = new Customer();
                        ss.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalied Password !");
                    }
                }
                else
                {
                    MessageBox.Show("Invalied User Name !");
                }
            }

                    
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            t2.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }

        private void bexit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
