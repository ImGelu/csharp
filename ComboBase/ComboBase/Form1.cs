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

namespace ComboBase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = ""; 
            SqlConnection sqlc = new SqlConnection(Properties.Settings.Default.BaseConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlc;

            cmd.Parameters.AddWithValue("Nume", comboBox1.SelectedItem.ToString());
            SqlDataReader read;
            cmd.CommandText = "SELECT TEXT FROM tabel WHERE (Name = @Nume)";

            sqlc.Open();
            read = cmd.ExecuteReader();
            while (read.Read())
            {
                
                label1.Text = read.GetString(0);
            }
            sqlc.Close(); 
          
            if(comboBox1.SelectedIndex == 0)
            {
                pictureBox1.Image = Image.FromFile(@"002.png", true);

            }
            else if (comboBox1.SelectedIndex == 1)
            {
                pictureBox1.Image = Image.FromFile(@"001.jpg", true);

            }
            else if (comboBox1.SelectedIndex == 2)
            {
                pictureBox1.Image = Image.FromFile(@"004.jpg", true);

            }
            else if (comboBox1.SelectedIndex == 3)
            {
                pictureBox1.Image = Image.FromFile(@"003.gif", true);

            }

            //MessageBox.Show(comboBox1.SelectedItem.ToString()); 
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
