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
using System.IO;

namespace Beclean
{
    public partial class FotografiiAdmin : Form
    {
        public FotografiiAdmin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sq = new SqlConnection(Properties.Settings.Default.PozeDBConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sq;

            byte[] imgData;
            imgData = File.ReadAllBytes(pictureBox1.ImageLocation);

            cmd.Parameters.AddWithValue("imagine", imgData);
            cmd.Parameters.AddWithValue("nume", textBox1.Text);
            cmd.Parameters.AddWithValue("descriere", richTextBox1.Text);

            cmd.CommandText = "INSERT INTO [Table] (Imagine, Nume, Descriere) VALUES(@imagine, @nume, @descriere)";

            sq.Open();
            cmd.ExecuteNonQuery();
            sq.Close();
            this.tableTableAdapter.Fill(this.dataSetPoze.Table);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.InitialDirectory = "C:\\Users\\Ungur\\Desktop\\Imgur Images";
            fd.Filter = "All files(*.png)|All images(*.*)";

            if (fd.ShowDialog() == DialogResult.OK) pictureBox1.ImageLocation = fd.FileName;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FotografiiAdmin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetPoze.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.dataSetPoze.Table);

        }
    }
}
