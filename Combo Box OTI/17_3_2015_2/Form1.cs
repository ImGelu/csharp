using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17_3_2015_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                MessageBox.Show("Ati ales OTI (Olimpiada de Tehnologie a Informatiei)"); pictureBox1.Image = Image.FromFile("oti.png");       
            }
            if (comboBox1.SelectedIndex == 1) { MessageBox.Show("Ati ales OJI (Olimpiada Judeteana de Informatica)"); }
            if (comboBox1.SelectedIndex == 2) { MessageBox.Show("Ati ales IOI (International Olympic of Informatics)"); }
            if (comboBox1.SelectedIndex == 3) { MessageBox.Show("Ati ales OLI (Olimpiada Locala de Informatica)"); }
            if (comboBox1.SelectedIndex == 4) { MessageBox.Show("Ati ales ONI (Olimpiada Nationala de Informatica)"); }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
