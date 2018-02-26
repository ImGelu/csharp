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

namespace Beclean
{
    public partial class PreviewList : Form
    {
        public PreviewList()
        {
            InitializeComponent();
        }

        int ki = 0, t = 38, tP = 0, lP = 0, l = 0;

        private void PreviewList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.dataSet1.Table);

            while (ki + 1 <= dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[0].RowIndex)
            {
                Label lb = new Label();
                PictureBox pb = new PictureBox();

                byte[] img = (byte[])dataGridView1.Rows[ki].Cells[1].Value;
                MemoryStream ms = new MemoryStream(img);
                pb.Image = Image.FromStream(ms);

                lb.Top = t;
                lb.Left = 80+l;
                lb.Width = 50;
                t += 80;
                lb.Text = dataGridView1.Rows[ki].Cells[3].Value.ToString();

                pb.Width = 77;
                pb.Height = 77;
                pb.Cursor = Cursors.Hand;
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.Left = 2+lP;
                pb.Top = tP;
                tP += 82;

                pb.Parent = this;
                lb.Parent = this;
                ki++;

                if (ki % 4 == 0) { l += 150; lP += 150; t = 38; tP = 0; }
            }
        }
    }
}
