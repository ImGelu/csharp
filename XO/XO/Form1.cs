using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Button[] buttons = new Button[10];
        int l = 0, t = 0, cb=0;
        bool p1 = true, p2 = false;

         void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 9; i++)
            {
                buttons[i] = new Button();
                buttons[i].Click += Form1_Click;
                buttons[i].Height = 64;
                buttons[i].Width = 64;
                buttons[i].Left = l;
                buttons[i].Top = t;

                l += 64;

                if (i % 3 == 0) { l = 0; t += 64; }

                groupBox1.Controls.Add(buttons[i]);
            }
        }

        void verify()
        {

            if (p1 == true) { p1 = false; p2 = true; }
            else if (p2 == true) { p1 = true; p2 = false; }

        }

        void Form1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
