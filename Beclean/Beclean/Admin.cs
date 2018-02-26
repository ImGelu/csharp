using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beclean
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.InitialDirectory = "C:\\Users\\Ungur\\Desktop\\Imgur Images";
       
            if(fd.ShowDialog()==DialogResult.OK) pictureBox1.ImageLocation=fd.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sq = new SqlConnection(Properties.Settings.Default.Database1ConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sq;

            byte[] imgData;
            imgData = File.ReadAllBytes(pictureBox1.ImageLocation);

            cmd.Parameters.AddWithValue("imagine", imgData);
            cmd.Parameters.AddWithValue("nume", textBox1.Text);
            cmd.Parameters.AddWithValue("adresa", textBox6.Text);
            cmd.Parameters.AddWithValue("telefon", textBox2.Text);
            cmd.Parameters.AddWithValue("site", textBox4.Text);
            cmd.Parameters.AddWithValue("facebook", textBox3.Text);
            cmd.Parameters.AddWithValue("program", textBox5.Text);
            
            cmd.CommandText="INSERT INTO [Table] (Imagine, Adresa, Nume, NrTelefon, Site, Facebook, Program) VALUES(@imagine, @adresa, @nume, @telefon, @site, @facebook, @program)";

            sq.Open();
            cmd.ExecuteNonQuery();
            sq.Close();
            this.tableTableAdapter1.Fill(this.dataSet1.Table);
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter1.Fill(this.dataSet1.Table);
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int x = dataGridView1.CurrentCell.RowIndex;
            int y = dataGridView1.CurrentCell.ColumnIndex;
            textBox1.Text = dataGridView1.Rows[x].Cells[y].Value.ToString();
        }

        private void fotografiiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FotografiiAdmin fa = new FotografiiAdmin();
            fa.Show();
        }
    }
}
