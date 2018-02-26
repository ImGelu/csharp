using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beclean
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void adminToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Preview p = new Preview();
            p.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AboutBox1 ab = new AboutBox1();
            ab.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In curand");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Fotografii f = new Fotografii();
            f.Show();
        }
    }
}
