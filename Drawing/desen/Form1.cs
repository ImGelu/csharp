using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Bitmap bitmap;
        Graphics g;

        private void Form1_Load(object sender, EventArgs e)
        {
            bitmap = new Bitmap(pictureBox1.Height, pictureBox1.Width);
            g = Graphics.FromImage(bitmap);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x1 = Int16.Parse(textBox1.Text);
            int y1 = Int16.Parse(textBox3.Text);
            int x2 = Int16.Parse(textBox5.Text);
            int y2 = Int16.Parse(textBox6.Text);

            Point p1 = new Point(x1, y1);
            Point p2 = new Point(x2, y2);
            Pen pen = new Pen(Color.Red);
            g.Clear(Color.White);
            g.DrawLine(pen, p1, p2);
            pictureBox1.Image = bitmap;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                int x1 = Int16.Parse(textBox2.Text);
                int y1 = Int16.Parse(textBox4.Text);

                Point p1 = new Point(x1, y1);
                Pen pen = new Pen(Color.Red);
                Size size = new Size(25, 25);
                Rectangle rectangle = new Rectangle(p1, size);
                g.DrawRectangle(pen, rectangle);
                pictureBox1.Image = bitmap;
            }
            else if(radioButton3.Checked) {
                int x1 = Int16.Parse(textBox2.Text);
                int y1 = Int16.Parse(textBox4.Text);

                Point p1 = new Point(x1, y1);
                Pen pen = new Pen(Color.Red);
                SolidBrush brush = new SolidBrush(Color.Red);
                Size size = new Size(25, 25);
                Rectangle rectangle = new Rectangle(p1, size);
                g.FillRectangle(brush, rectangle);
                pictureBox1.Image = bitmap;
            }
            else if (radioButton4.Checked)
            {
                int x1 = Int16.Parse(textBox2.Text);
                int y1 = Int16.Parse(textBox4.Text);

                Point p1 = new Point(x1, y1);
                Pen pen = new Pen(Color.Red);
                SolidBrush brush = new SolidBrush(Color.Red);
                Size size = new Size(25, 25);
                Rectangle rectangle = new Rectangle(p1, size);
                g.FillEllipse(brush, rectangle);
                pictureBox1.Image = bitmap;
            }
            else if (radioButton2.Checked)
            {
                int x1 = Int16.Parse(textBox2.Text);
                int y1 = Int16.Parse(textBox4.Text);

                Point p1 = new Point(x1, y1);
                Pen pen = new Pen(Color.Red);
                Size size = new Size(25, 25);
                Rectangle rectangle = new Rectangle(p1, size);
                g.DrawEllipse(pen, rectangle);
                pictureBox1.Image = bitmap;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
