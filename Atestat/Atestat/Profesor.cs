using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Atestat
{
    public partial class Profesor : Form
    {
        public Profesor()
        {
            InitializeComponent();
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
        }

        private void Profesor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.database1DataSet.Table);

        }

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && comboBox1.Text != "" && comboBox2.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "")
            {
                double romNota = Convert.ToDouble(textBox4.Text);
                double mateNota = Convert.ToDouble(textBox5.Text);
                double alegereNota = Convert.ToDouble(textBox6.Text);
                if (romNota > 10 || mateNota > 10 || alegereNota > 10 || romNota<1 || mateNota<1 || alegereNota<1)
                {
                    MessageBox.Show("Nota trebuie să fie între 1.00 și 10.00.", "Eroare!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    SqlConnection sqlconnection = new SqlConnection();
                    sqlconnection.ConnectionString = Properties.Settings.Default.Database1ConnectionString;
                    SqlCommand sqlcommand = new SqlCommand();
                    sqlcommand.Connection = sqlconnection;
                    sqlcommand.Parameters.AddWithValue("nume", textBox1.Text);
                    sqlcommand.Parameters.AddWithValue("clasa", comboBox1.Text);
                    sqlcommand.Parameters.AddWithValue("profil", comboBox2.Text);
                    sqlcommand.Parameters.AddWithValue("romana", textBox4.Text);
                    sqlcommand.Parameters.AddWithValue("mate", textBox5.Text);
                    sqlcommand.Parameters.AddWithValue("alegere", textBox6.Text);
                    sqlcommand.Parameters.AddWithValue("medie", (romNota+mateNota+alegereNota)/3);

                    sqlcommand.CommandText = "insert into [dbo].[Table](Nume, Clasa, Profil, Romana, Matematica, Alegere, Media) values(@nume, @clasa, @profil, @romana, @mate, @alegere, @medie)";

                    sqlconnection.Open();
                    sqlcommand.ExecuteNonQuery();
                    sqlconnection.Close();

                    this.tableTableAdapter.Fill(this.database1DataSet.Table);
                    textBox1.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    comboBox1.SelectedIndex = -1;
                    comboBox2.SelectedIndex = -1;
                }
                    
            }

            else MessageBox.Show("Completați toate informațiile necesare", "Eroare!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void tableDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void idTextBox_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.tableAdapterManager.UpdateAll(this.database1DataSet);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }


        private void tableDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //MessageBox.Show("* Asigurați-vă că niciun câmp nu este gol.\n* Asigurați-vă că în câmpul pentru note aveți doar cifre.\n\nSemnul pentru virgulă este punctul (.)","Eroare!",MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void tableDataGridView_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void tableDataGridView_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
                this.Validate();
                this.tableBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.database1DataSet);
            
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
                e.Handled = true;
            else
                e.Handled = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
