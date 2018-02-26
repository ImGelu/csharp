using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime d = DateTime.Now.AddDays(-Convert.ToInt16(numericUpDown1.Value));
            MessageBox.Show(d.DayOfWeek + "\n" + d.ToShortDateString());
        }
    }
}
