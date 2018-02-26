using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; 

namespace Dictionar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                SqlConnection sqlc = new SqlConnection(Properties.Settings.Default.DatabaseConnectionString);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlc;

                cmd.Parameters.AddWithValue("romana", textBox3.Text);
                SqlDataReader reader;

                cmd.CommandText = "SELECT franceza FROM tabel WHERE (Romana = @romana)";

                

                sqlc.Open();
                reader = cmd.ExecuteReader();
                string s = "";
                while(reader.Read())
                {
                    s+= reader.GetString(0)+"\n"; 
                }
                MessageBox.Show(s);
                sqlc.Close();
               
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "" && textBox4.Text != "")
            {
                SqlConnection sqlc = new SqlConnection(Properties.Settings.Default.DatabaseConnectionString);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlc;

                cmd.Parameters.AddWithValue("romana", textBox2.Text);
                cmd.Parameters.AddWithValue("franceza", textBox4.Text);

                cmd.CommandText = "INSERT INTO tabel(Romana, Franceza) values(@romana, @franceza)";
                sqlc.Open();
                cmd.ExecuteNonQuery();
                sqlc.Close();
                textBox4.Text = "";
                textBox2.Text = "";
            }
               

        }

        private void Form1_Load(object sender, EventArgs e)
        {
          

        }
    }
}
