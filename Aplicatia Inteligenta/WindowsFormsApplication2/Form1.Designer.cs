namespace WindowsFormsApplication2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.formuleMatematiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lectiiGeografieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.culoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verdeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rozToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.albastruToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formuleMatematiceToolStripMenuItem,
            this.lectiiGeografieToolStripMenuItem,
            this.culoriToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(417, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // formuleMatematiceToolStripMenuItem
            // 
            this.formuleMatematiceToolStripMenuItem.Name = "formuleMatematiceToolStripMenuItem";
            this.formuleMatematiceToolStripMenuItem.Size = new System.Drawing.Size(129, 20);
            this.formuleMatematiceToolStripMenuItem.Text = "Formule Matematice";
            this.formuleMatematiceToolStripMenuItem.Click += new System.EventHandler(this.formuleMatematiceToolStripMenuItem_Click);
            // 
            // lectiiGeografieToolStripMenuItem
            // 
            this.lectiiGeografieToolStripMenuItem.Name = "lectiiGeografieToolStripMenuItem";
            this.lectiiGeografieToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.lectiiGeografieToolStripMenuItem.Text = "Lectii geografie";
            this.lectiiGeografieToolStripMenuItem.Click += new System.EventHandler(this.lectiiGeografieToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // culoriToolStripMenuItem
            // 
            this.culoriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verdeToolStripMenuItem,
            this.rozToolStripMenuItem,
            this.albastruToolStripMenuItem});
            this.culoriToolStripMenuItem.Name = "culoriToolStripMenuItem";
            this.culoriToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.culoriToolStripMenuItem.Text = "Culori";
            // 
            // verdeToolStripMenuItem
            // 
            this.verdeToolStripMenuItem.Name = "verdeToolStripMenuItem";
            this.verdeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.verdeToolStripMenuItem.Text = "Verde";
            this.verdeToolStripMenuItem.Click += new System.EventHandler(this.verdeToolStripMenuItem_Click);
            // 
            // rozToolStripMenuItem
            // 
            this.rozToolStripMenuItem.Name = "rozToolStripMenuItem";
            this.rozToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.rozToolStripMenuItem.Text = "Roz";
            this.rozToolStripMenuItem.Click += new System.EventHandler(this.rozToolStripMenuItem_Click);
            // 
            // albastruToolStripMenuItem
            // 
            this.albastruToolStripMenuItem.Name = "albastruToolStripMenuItem";
            this.albastruToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.albastruToolStripMenuItem.Text = "Albastru";
            this.albastruToolStripMenuItem.Click += new System.EventHandler(this.albastruToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(268, 165);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(149, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Aplicatie realizata de IX I";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(416, 132);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 183);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Aplicatia inteligenta";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem formuleMatematiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lectiiGeografieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem culoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verdeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rozToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem albastruToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

