using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNP_Valid
{
    public partial class Form1 : Form
    {
        private string cnp;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ok = false;
        }
        bool ok = false;
        private void button1_Click(object sender, EventArgs e)
        {
            string eroare = "";
            string prefixan = "";
            string resedinta = "";
            string luna = "";
            int an;
            int pan = 0;
            int s = 0;

            cnp = textBox1.Text;
            if (cnp.Count() == 13)
            {
                int aux = Int16.Parse(cnp[0].ToString());
                if (aux > 0 && aux <= 9)
                {
                    s=s + 2 * aux;
                    if (aux == 1 || aux == 3 || aux == 5 || aux == 7) { textBox3.Text = "Masculin"; }
                    if (aux == 2 || aux == 4 || aux == 6 || aux == 8) { textBox3.Text = "Feminin"; }
                    if (aux == 7 || aux == 8) { textBox5.Text = "Da";}
                    else textBox5.Text = "Nu";
                    if (aux == 9) { textBox3.Text = "Necunoscut"; textBox6.Text = "Da"; }
                    else textBox6.Text = "Nu";
                    if (aux == 1 || aux == 2) { prefixan = "19"; pan = 19; }
                    if (aux == 3 || aux == 4) { prefixan = "18"; pan = 18; }
                    if (aux == 5 || aux == 6) { prefixan = "20"; pan = 20; }
                    
                    int ll = Int16.Parse(cnp[1].ToString());
                    s = s + 7 * ll;
                    int ll2 = Int16.Parse(cnp[2].ToString());
                    ll = ll * 10 + ll2;
                    if (ll >= 0 && ll < 100)
                    {
s = s + 9 * ll2;
                        an = pan*100 + ll;
                        ll = Int16.Parse(cnp[3].ToString());
                        s = s + 1 * ll;
                        ll2 = Int16.Parse(cnp[4].ToString());
                        ll = ll * 10 + ll2;
                        if (ll >= 0 && ll < 13)
                        {
s = s + 4 * ll2;
                            if (ll == 01) { luna = "ianuarie"; }
                            if (ll == 02) { luna = "februarie"; }
                            if (ll == 03) { luna = "martie"; }
                            if (ll == 04) { luna = "aprilie"; }
                            if (ll == 05) { luna = "mai"; }
                            if (ll == 06) { luna = "iunie"; }
                            if (ll == 07) { luna = "iulie"; }
                            if (ll == 08) { luna = "august"; }
                            if (ll == 09) { luna = "septembrie"; }
                            if (ll == 10) { luna = "octombrie"; }
                            if (ll == 11) { luna = "noiembrie"; }
                            if (ll == 12) { luna = "decembrie"; }
    
                            ll = Int16.Parse(cnp[5].ToString());
                            s = s + 6 * ll;
                            ll2 = Int16.Parse(cnp[6].ToString());
                            ll = ll * 10 + ll2;
                            if (ll >= 0 && ll < 31)
                            {
s = s + 3 * ll2;
                                ll = Int16.Parse(cnp[7].ToString());
                                s = s + 5 * ll;
                                ll2 = Int16.Parse(cnp[8].ToString());
                                ll = ll * 10 + ll2;
                                if (ll > 0 && ll < 53)
                                {

s = s + 8 * ll2;
                                    if (ll == 01) { resedinta = "Alba"; }
                                    if (ll == 02) { resedinta = "Arad"; }
                                    if (ll == 03) { resedinta = "Arges"; }
                                    if (ll == 04) { resedinta = "Bacau"; }
                                    if (ll == 05) { resedinta = "Bihor"; }
                                    if (ll == 06) { resedinta = "Bistrita-Nasaud"; }
                                    if (ll == 07) { resedinta = "Botosani"; }
                                    if (ll == 08) { resedinta = "Brasov"; }
                                    if (ll == 09) { resedinta = "Braila"; }
                                    if (ll == 10) { resedinta = "Buzau"; }
                                    if (ll == 11) { resedinta = "Caras-Severin"; }
                                    if (ll == 12) { resedinta = "Cluj"; }
                                    if (ll == 13) { resedinta = "Constanta"; }
                                    if (ll == 14) { resedinta = "Covasna"; }
                                    if (ll == 15) { resedinta = "Dambovita"; }
                                    if (ll == 16) { resedinta = "Dolj"; }
                                    if (ll == 17) { resedinta = "Galati"; }
                                    if (ll == 18) { resedinta = "Gorj"; }
                                    if (ll == 19) { resedinta = "Harghita"; }
                                    if (ll == 20) { resedinta = "Hunedoara"; }
                                    if (ll == 21) { resedinta = "Ialomita"; }
                                    if (ll == 22) { resedinta = "Iasi"; }
                                    if (ll == 23) { resedinta = "Ilfov"; }
                                    if (ll == 24) { resedinta = "Maramures"; }
                                    if (ll == 25) { resedinta = "Mehedinti"; }
                                    if (ll == 26) { resedinta = "Mures"; }
                                    if (ll == 27) { resedinta = "Neamt"; }
                                    if (ll == 28) { resedinta = "Olt"; }
                                    if (ll == 29) { resedinta = "Prahova"; }
                                    if (ll == 30) { resedinta = "Satu Mare"; }
                                    if (ll == 31) { resedinta = "Salaj"; }
                                    if (ll == 32) { resedinta = "Sibiu"; }
                                    if (ll == 33) { resedinta = "Suceava"; }
                                    if (ll == 34) { resedinta = "Teleorman"; }
                                    if (ll == 35) { resedinta = "Timis"; }
                                    if (ll == 36) { resedinta = "Tulcea"; }
                                    if (ll == 37) { resedinta = "Vaslui"; }
                                    if (ll == 38) { resedinta = "Valcea"; }
                                    if (ll == 39) { resedinta = "Vrancea"; }
                                    if (ll == 40) { resedinta = "Bucuresti"; }
                                    if (ll == 41) { resedinta = "Bucuresti - Sector 1"; }
                                    if (ll == 42) { resedinta = "Bucuresti - Sector 2"; }
                                    if (ll == 43) { resedinta = "Bucuresti - Sector 3"; }
                                    if (ll == 44) { resedinta = "Bucuresti - Sector 4"; }
                                    if (ll == 45) { resedinta = "Bucuresti - Sector 5"; }
                                    if (ll == 46) { resedinta = "Bucuresti - Sector 6"; }
                                    if (ll == 51) { resedinta = "Calarasi"; }
                                    if (ll == 52) { resedinta = "Giurgiu"; }

                                    ll = Int16.Parse(cnp[9].ToString());
                                    s = s + 2 * ll;
                                    ll2 = Int16.Parse(cnp[10].ToString());
                                    int ll3 = Int16.Parse(cnp[11].ToString());
                                    ll = ll * 100 + ll2 * 10 + ll3;
                                    if (ll > 0 && ll < 1000)
                                    {

s = s + 7 * ll2;
s = s + 9 * ll3;
                                        int c = Int16.Parse(cnp[12].ToString());
                                        if (s%11==c || s%10==c)
                                        {
                                            ok = true;
                                        }
                                        textBox2.Text = cnp[5].ToString() + cnp[6].ToString() + " " + luna + " " + prefixan + cnp[1].ToString() + cnp[2].ToString();
                                        textBox4.Text = resedinta;
                                        textBox7.Text = (2015-an).ToString();
                                        textBox8.Text = cnp[9].ToString() + cnp[10].ToString() + cnp[11].ToString();
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (cnp.Length < 13) eroare = ": prea scurt";
            if (cnp.Length > 13) eroare = ": prea lung";
            if (ok == true)
            {
                MessageBox.Show("CNP-ul este valid!");
            }
            else
            {
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                MessageBox.Show("CNP nevalid" + eroare);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) { e.Handled = true; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        }
    }