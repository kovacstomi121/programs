namespace KönyvVásár
{
    partial class UjKonyvForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudAr = new System.Windows.Forms.NumericUpDown();
            this.nudEv = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbSzerzo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Tbcim = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nudReszek = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRogzites = new System.Windows.Forms.Button();
            this.rbKonyv = new System.Windows.Forms.RadioButton();
            this.rbKonyvSor = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEv)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudReszek)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudAr);
            this.groupBox1.Controls.Add(this.nudEv);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbSzerzo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Tbcim);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(55, 36);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(354, 334);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Könyv";
            // 
            // nudAr
            // 
            this.nudAr.Location = new System.Drawing.Point(30, 259);
            this.nudAr.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.nudAr.Name = "nudAr";
            this.nudAr.Size = new System.Drawing.Size(156, 26);
            this.nudAr.TabIndex = 17;
            // 
            // nudEv
            // 
            this.nudEv.Location = new System.Drawing.Point(30, 189);
            this.nudEv.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudEv.Name = "nudEv";
            this.nudEv.Size = new System.Drawing.Size(156, 26);
            this.nudEv.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Ár";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Kiadási év";
            // 
            // tbSzerzo
            // 
            this.tbSzerzo.Location = new System.Drawing.Point(30, 135);
            this.tbSzerzo.Multiline = true;
            this.tbSzerzo.Name = "tbSzerzo";
            this.tbSzerzo.Size = new System.Drawing.Size(156, 28);
            this.tbSzerzo.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Szerző";
            // 
            // Tbcim
            // 
            this.Tbcim.Location = new System.Drawing.Point(30, 67);
            this.Tbcim.Multiline = true;
            this.Tbcim.Name = "Tbcim";
            this.Tbcim.Size = new System.Drawing.Size(156, 28);
            this.Tbcim.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cím";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nudReszek);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(441, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(311, 186);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Könyv sorozat";
            this.groupBox2.Visible = false;
            // 
            // nudReszek
            // 
            this.nudReszek.Location = new System.Drawing.Point(29, 65);
            this.nudReszek.Name = "nudReszek";
            this.nudReszek.Size = new System.Drawing.Size(156, 26);
            this.nudReszek.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Részek";
            // 
            // btnRogzites
            // 
            this.btnRogzites.Location = new System.Drawing.Point(497, 330);
            this.btnRogzites.Name = "btnRogzites";
            this.btnRogzites.Size = new System.Drawing.Size(221, 101);
            this.btnRogzites.TabIndex = 2;
            this.btnRogzites.Text = "Rögzítés";
            this.btnRogzites.UseVisualStyleBackColor = true;
            this.btnRogzites.Click += new System.EventHandler(this.btnRogzites_Click_1);
            // 
            // rbKonyv
            // 
            this.rbKonyv.AutoSize = true;
            this.rbKonyv.Checked = true;
            this.rbKonyv.Location = new System.Drawing.Point(72, 379);
            this.rbKonyv.Name = "rbKonyv";
            this.rbKonyv.Size = new System.Drawing.Size(74, 24);
            this.rbKonyv.TabIndex = 3;
            this.rbKonyv.TabStop = true;
            this.rbKonyv.Text = "Könyv";
            this.rbKonyv.UseVisualStyleBackColor = true;
            this.rbKonyv.CheckedChanged += new System.EventHandler(this.rbKonyv_CheckedChanged);
            // 
            // rbKonyvSor
            // 
            this.rbKonyvSor.AutoSize = true;
            this.rbKonyvSor.Location = new System.Drawing.Point(72, 410);
            this.rbKonyvSor.Name = "rbKonyvSor";
            this.rbKonyvSor.Size = new System.Drawing.Size(139, 24);
            this.rbKonyvSor.TabIndex = 4;
            this.rbKonyvSor.Text = "Könyv sorozat";
            this.rbKonyvSor.UseVisualStyleBackColor = true;
            // 
            // UjKonyvForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 459);
            this.Controls.Add(this.rbKonyvSor);
            this.Controls.Add(this.rbKonyv);
            this.Controls.Add(this.btnRogzites);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UjKonyvForm";
            this.Text = "UjKonyvForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEv)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudReszek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.GroupBox groupBox1;
        protected System.Windows.Forms.TextBox tbSzerzo;
        protected System.Windows.Forms.Label label4;
        protected System.Windows.Forms.TextBox Tbcim;
        protected System.Windows.Forms.Label label3;
        protected System.Windows.Forms.NumericUpDown nudAr;
        protected System.Windows.Forms.NumericUpDown nudEv;
        protected System.Windows.Forms.Label label7;
        protected System.Windows.Forms.Label label6;
        protected System.Windows.Forms.GroupBox groupBox2;
        protected System.Windows.Forms.NumericUpDown nudReszek;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Button btnRogzites;
        protected System.Windows.Forms.RadioButton rbKonyv;
        protected System.Windows.Forms.RadioButton rbKonyvSor;
    }
}