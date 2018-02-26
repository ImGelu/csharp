using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserPass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {

                SqlConnection sqlconnection = new SqlConnection();
                SqlCommand sqlcommand = new SqlCommand();
                sqlcommand.Connection = sqlconnection;
                sqlconnection.ConnectionString = Properties.Settings.Default.BazaConnectionString;
                sqlcommand.Parameters.AddWithValue("user", textBox1.Text);
                sqlcommand.Parameters.AddWithValue("pass", textBox2.Text);

                sqlcommand.CommandText = "select Username from User where firstname='" + textBox1.Text + "' ";

                sqlconnection.Open();
                sqlcommand.ExecuteNonQuery();
                sqlconnection.Close();
            }
        }
    }
}
