using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transparency
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int inter;
        bool state = true;
        Random randomizer = new Random(); 

        private void Form1_Load(object sender, EventArgs e)
        {
            inter = 20;
            timer1.Start();
            state = true; 

        }

      

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (inter > 0 && state == true)
            {
                this.Opacity -= 0.1;
                inter--;
                 
            }


           if(inter== 0)
           {

               randomizer = new Random();
               this.BackColor = Color.FromArgb(randomizer.Next(0, 255), randomizer.Next(0, 255), randomizer.Next(0, 255));
               state = false;  
           }

        if(inter == 20)
        {
            randomizer = new Random();
            this.BackColor = Color.FromArgb(randomizer.Next(0, 255), randomizer.Next(0, 255), randomizer.Next(0, 255));
            state = true ;
           
        }
          
            if (inter < 20 && state == false)
           {
               this.Opacity += 0.1;
               inter++; 
           }


        }
    }
}
