using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atestat
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "cnpr")
            {
                this.Close();
                Profesor p = new Profesor();
                p.Show();
            }
            else MessageBox.Show("Parolă incorectă", "Eroare de autentificare", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
