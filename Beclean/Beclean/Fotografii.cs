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
    public partial class Fotografii : Form
    {
        public Fotografii()
        {
            InitializeComponent();
        }

        int ki = 0;

        void update()
        {
            if (ki + 1 <= dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[0].RowIndex)
            {
                label1.Text = dataGridView1.Rows[ki].Cells[2].Value.ToString();
                richTextBox1.Text = dataGridView1.Rows[ki].Cells[3].Value.ToString();

                byte[] img = (byte[])dataGridView1.Rows[ki].Cells[1].Value;
                MemoryStream ms = new MemoryStream(img);
                pictureBox1.Image = Image.FromStream(ms);
            }
        }

        private void Fotografii_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetPoze.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.dataSetPoze.Table);
            update();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            update();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
