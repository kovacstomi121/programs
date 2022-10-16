namespace KönyvVásár
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.újKönyvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.érdekődőkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eladásokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lbKönyvek = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbAr = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbEv = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbErdeklodok = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSzerzo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCim = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAz = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbReszek = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.labEladva = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.újKönyvToolStripMenuItem,
            this.érdekődőkToolStripMenuItem,
            this.eladásokToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(793, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // újKönyvToolStripMenuItem
            // 
            this.újKönyvToolStripMenuItem.Name = "újKönyvToolStripMenuItem";
            this.újKönyvToolStripMenuItem.Size = new System.Drawing.Size(65, 19);
            this.újKönyvToolStripMenuItem.Text = "Új könyv";
            this.újKönyvToolStripMenuItem.Click += new System.EventHandler(this.újKönyvToolStripMenuItem_Click);
            // 
            // érdekődőkToolStripMenuItem
            // 
            this.érdekődőkToolStripMenuItem.Name = "érdekődőkToolStripMenuItem";
            this.érdekődőkToolStripMenuItem.Size = new System.Drawing.Size(75, 19);
            this.érdekődőkToolStripMenuItem.Text = "Érdekődők";
            this.érdekődőkToolStripMenuItem.Click += new System.EventHandler(this.érdekődőkToolStripMenuItem_Click);
            // 
            // eladásokToolStripMenuItem
            // 
            this.eladásokToolStripMenuItem.Name = "eladásokToolStripMenuItem";
            this.eladásokToolStripMenuItem.Size = new System.Drawing.Size(65, 19);
            this.eladásokToolStripMenuItem.Text = "Eladások";
            this.eladásokToolStripMenuItem.Click += new System.EventHandler(this.eladásokToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Könyvek";
            // 
            // lbKönyvek
            // 
            this.lbKönyvek.FormattingEnabled = true;
            this.lbKönyvek.ItemHeight = 20;
            this.lbKönyvek.Location = new System.Drawing.Point(36, 81);
            this.lbKönyvek.Name = "lbKönyvek";
            this.lbKönyvek.Size = new System.Drawing.Size(231, 264);
            this.lbKönyvek.TabIndex = 2;
            this.lbKönyvek.SelectedIndexChanged += new System.EventHandler(this.lbKönyvek_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbAr);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbEv);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbErdeklodok);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbSzerzo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbCim);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbAz);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(338, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 236);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Könyv adatok";
            // 
            // tbAr
            // 
            this.tbAr.Location = new System.Drawing.Point(246, 182);
            this.tbAr.Multiline = true;
            this.tbAr.Name = "tbAr";
            this.tbAr.ReadOnly = true;
            this.tbAr.Size = new System.Drawing.Size(156, 31);
            this.tbAr.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(242, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Ár";
            // 
            // tbEv
            // 
            this.tbEv.Location = new System.Drawing.Point(246, 114);
            this.tbEv.Multiline = true;
            this.tbEv.Name = "tbEv";
            this.tbEv.ReadOnly = true;
            this.tbEv.Size = new System.Drawing.Size(156, 31);
            this.tbEv.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(251, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Kiadási év";
            // 
            // tbErdeklodok
            // 
            this.tbErdeklodok.Location = new System.Drawing.Point(246, 57);
            this.tbErdeklodok.Multiline = true;
            this.tbErdeklodok.Name = "tbErdeklodok";
            this.tbErdeklodok.ReadOnly = true;
            this.tbErdeklodok.Size = new System.Drawing.Size(156, 31);
            this.tbErdeklodok.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(242, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Érdeklődők";
            // 
            // tbSzerzo
            // 
            this.tbSzerzo.Location = new System.Drawing.Point(23, 182);
            this.tbSzerzo.Multiline = true;
            this.tbSzerzo.Name = "tbSzerzo";
            this.tbSzerzo.ReadOnly = true;
            this.tbSzerzo.Size = new System.Drawing.Size(156, 31);
            this.tbSzerzo.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Szerző";
            // 
            // tbCim
            // 
            this.tbCim.Location = new System.Drawing.Point(23, 114);
            this.tbCim.Multiline = true;
            this.tbCim.Name = "tbCim";
            this.tbCim.ReadOnly = true;
            this.tbCim.Size = new System.Drawing.Size(156, 31);
            this.tbCim.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cím";
            // 
            // tbAz
            // 
            this.tbAz.Location = new System.Drawing.Point(23, 57);
            this.tbAz.Multiline = true;
            this.tbAz.Name = "tbAz";
            this.tbAz.ReadOnly = true;
            this.tbAz.Size = new System.Drawing.Size(156, 31);
            this.tbAz.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Azonosító";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.tbReszek);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(338, 324);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Könyv sorozat adatok";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(107, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "db";
            // 
            // tbReszek
            // 
            this.tbReszek.Location = new System.Drawing.Point(24, 46);
            this.tbReszek.Multiline = true;
            this.tbReszek.Name = "tbReszek";
            this.tbReszek.ReadOnly = true;
            this.tbReszek.Size = new System.Drawing.Size(77, 31);
            this.tbReszek.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Részek";
            // 
            // labEladva
            // 
            this.labEladva.AutoSize = true;
            this.labEladva.Location = new System.Drawing.Point(628, 347);
            this.labEladva.Name = "labEladva";
            this.labEladva.Size = new System.Drawing.Size(63, 20);
            this.labEladva.TabIndex = 5;
            this.labEladva.Text = "Eladva";
            this.labEladva.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 462);
            this.Controls.Add(this.labEladva);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbKönyvek);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem újKönyvToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem érdekődőkToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbKönyvek;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbAr;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbEv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbErdeklodok;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSzerzo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbReszek;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labEladva;
        private System.Windows.Forms.ToolStripMenuItem eladásokToolStripMenuItem;
    }
}

