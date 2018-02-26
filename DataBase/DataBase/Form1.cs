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

namespace DataBase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDataSet.tabel' table. You can move, or remove it, as needed.
            this.tabelTableAdapter.Fill(this.dataDataSet.tabel);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                SqlConnection sqlc = new SqlConnection(Properties.Settings.Default.dataConnectionString);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlc;

                cmd.Parameters.AddWithValue("nume", textBox1.Text);
                cmd.Parameters.AddWithValue("numar", textBox2.Text);

                cmd.CommandText = "INSERT INTO tabel(Nume, NumarTelefon) values(@nume, @numar)";
                sqlc.Open();
                cmd.ExecuteNonQuery();
                sqlc.Close();
                textBox1.Text = "";
                textBox2.Text = "";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount-1; i++ )
                MessageBox.Show(dataGridView1.Rows[i].Cells[1].Value.ToString());

            //for(int i=0; i<=dataGridView1.Rows[dataGridView1.RowCount])
        }
    }
}
