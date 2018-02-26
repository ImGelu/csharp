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

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random nr = new Random();
            int victima = nr.Next(27) + 1;
            textBox2.Text = victima.ToString();
            StreamReader sr = new StreamReader("victime.txt");
            for (int i = 1; i <= victima; i++)
                sr.ReadLine();
            textBox3.Text = sr.ReadLine();
        }
    }
}
