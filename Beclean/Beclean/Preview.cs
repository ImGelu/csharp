using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beclean
{
    public partial class Preview : Form
    {
        public Preview()
        {
            InitializeComponent();
        }

        int ki = 0;

        void update()
        {
            if (ki + 1 <= dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[0].RowIndex)
            {
                label8.Text = dataGridView1.Rows[ki].Cells[2].Value.ToString();
                label12.Text = dataGridView1.Rows[ki].Cells[7].Value.ToString();
                label1.Text = dataGridView1.Rows[ki].Cells[3].Value.ToString();
                label9.Text = dataGridView1.Rows[ki].Cells[4].Value.ToString();
                label10.Text = dataGridView1.Rows[ki].Cells[5].Value.ToString();
                label11.Text = dataGridView1.Rows[ki].Cells[6].Value.ToString();

                byte[] img = (byte[])dataGridView1.Rows[ki].Cells[1].Value;
                MemoryStream ms = new MemoryStream(img);
                pictureBox1.Image = Image.FromStream(ms);
            }
            else MessageBox.Show("Nu mai sunt spatii libere!");
        }

        private void Preview_Load(object sender, EventArgs e)
        {
            this.tableTableAdapter.Fill(this.dataSet1.Table);
            update();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
                ki++;
                update();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PreviewList pl = new PreviewList();
            pl.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ki--;
            update();
        }
    }
}
