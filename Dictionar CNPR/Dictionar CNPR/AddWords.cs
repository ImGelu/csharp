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

namespace Dictionar_CNPR
{
    public partial class AddWords : Form
    {
        public AddWords()
        {
            InitializeComponent();
        }

        private void AddWords_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wordsDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.wordsDataSet.Table);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                SqlConnection sqlc = new SqlConnection(Properties.Settings.Default.WordsConnectionString);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlc;

                cmd.Parameters.AddWithValue("romana", textBox1.Text);
                cmd.Parameters.AddWithValue("engleza", textBox2.Text);

                cmd.CommandText = "INSERT INTO [Table](Romana, Engleza) values(@romana, @engleza)";
                sqlc.Open();
                cmd.ExecuteNonQuery();
                sqlc.Close();
                textBox1.Text = "";
                textBox2.Text = "";
                this.tableTableAdapter.Fill(this.wordsDataSet.Table);
                MessageBox.Show("Cuvântul a fost adăugat cu succes!", "Succes!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
               
        }
    }
}
