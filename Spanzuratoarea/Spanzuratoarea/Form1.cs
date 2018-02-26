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

namespace Spanzuratoarea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> cuvinte = new List<string>();
        int l, n, par, re, num, lungime = 0, greseli = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            string dir = Application.StartupPath;
            string fisier = dir + "//cuv.txt";
            StreamReader sr = new StreamReader(fisier);

            while (!sr.EndOfStream) cuvinte.Add(sr.ReadLine());
            sr.Close();

            Random r = new Random();

            int nr_cuvant = r.Next(0, cuvinte.Count);
            string cuv_ales = cuvinte[nr_cuvant];
            lungime = cuv_ales.Length;

            while (n < lungime)
            {
                TextBox tb = new TextBox();
                tb.TextAlign = HorizontalAlignment.Center;
                tb.MaxLength = 1;
                tb.Width = 20;
                tb.Top = 100;
                tb.Left = 300 + l;
                l += 25;

                tb.Tag = cuv_ales[n].ToString();

                if (par % 2 == 0)
                {
                    tb.Text = cuv_ales[n].ToString();
                    tb.ReadOnly = true;
                    re++;
                }
                tb.TextChanged += Tb_TextChanged;
                tb.Parent = this;
                n++;
                par++;
            }
        }

        void Tb_TextChanged(object sender, EventArgs e)
        {
            TextBox t = sender as TextBox;
            if (t.Text != "" && t.Text != t.Tag.ToString()) greseli++;
            else if (t.Text == t.Tag.ToString()) { t.ReadOnly = true; num++; this.ActiveControl = t; }

            if (num == lungime - re)
            {
                DialogResult result = MessageBox.Show("Felicitari! Ai ghicit cuvantul!\n\nVrei sa primesti un cuvant nou?", "Joc terminat", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes) Application.Restart();
            }

            if (greseli == 1) pas1.Visible = true;
            if (greseli == 2) { pas1.Visible = false; pas2.Visible = true; }
            if (greseli == 3) { pas2.Visible = false; pas3.Visible = true; }
            if (greseli == 4) { pas3.Visible = false; pas4.Visible = true; }
            if (greseli == 5) { pas4.Visible = false; pas5.Visible = true; }
            if (greseli == 6)
            {
                pas5.Visible = false;
                pas6.Visible = true;
                DialogResult result = MessageBox.Show("Ai pierdut!\n\nVrei sa primesti un cuvant nou?", "Joc terminat", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes) Application.Restart();


            }
       
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
