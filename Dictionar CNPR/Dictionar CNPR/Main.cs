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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                SqlConnection sqlc = new SqlConnection(Properties.Settings.Default.WordsConnectionString);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlc;

                cmd.Parameters.AddWithValue("romana", textBox1.Text);
                SqlDataReader reader;

                cmd.CommandText = "SELECT Engleza FROM [Table] WHERE (Romana = @romana)";



                sqlc.Open();
                reader = cmd.ExecuteReader();
                string s = "";
                while (reader.Read())
                {
                    s += reader.GetString(0) + "\n";
                }
                if (s == "") MessageBox.Show("Cuvântul nu a fost găsit în dicționar.", "Eroare!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else MessageBox.Show(s, "Definiția cuvântului „"+textBox1.Text+"”", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sqlc.Close();

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void adaugăCuvinteNoiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddWords aw = new AddWords();
            aw.Show();
        }
    }
}
