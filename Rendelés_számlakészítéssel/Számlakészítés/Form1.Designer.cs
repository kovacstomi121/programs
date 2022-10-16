namespace Számlakészítés
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
            this.dgvTermekek = new System.Windows.Forms.DataGridView();
            this.Azonosito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Megnevezes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Netto_ar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Afa_kulcs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Garancia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRendel = new System.Windows.Forms.Button();
            this.tbNev = new System.Windows.Forms.TextBox();
            this.nudMennyiseg = new System.Windows.Forms.NumericUpDown();
            this.tbNetto = new System.Windows.Forms.TextBox();
            this.tbBrutto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnHozzaad = new System.Windows.Forms.Button();
            this.dgvRendeles = new System.Windows.Forms.DataGridView();
            this.AruNev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nettó_ar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Afa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mennyiseg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Netto_ertek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brutto_ertek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.tbFizetendo = new System.Windows.Forms.TextBox();
            this.btnModosit = new System.Windows.Forms.Button();
            this.btnTorol = new System.Windows.Forms.Button();
            this.nudUjMennyiseg = new System.Windows.Forms.NumericUpDown();
            this.btnOk = new System.Windows.Forms.Button();
            this.tbAfa = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbAr = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.összesRendelésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTermekek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMennyiseg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRendeles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUjMennyiseg)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTermekek
            // 
            this.dgvTermekek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTermekek.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Azonosito,
            this.Megnevezes,
            this.Kategoria,
            this.Netto_ar,
            this.Afa_kulcs,
            this.Garancia});
            this.dgvTermekek.Location = new System.Drawing.Point(12, 61);
            this.dgvTermekek.MultiSelect = false;
            this.dgvTermekek.Name = "dgvTermekek";
            this.dgvTermekek.RowHeadersWidth = 51;
            this.dgvTermekek.RowTemplate.Height = 24;
            this.dgvTermekek.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTermekek.Size = new System.Drawing.Size(803, 306);
            this.dgvTermekek.TabIndex = 0;
            this.dgvTermekek.SelectionChanged += new System.EventHandler(this.dgvTermekek_SelectionChanged);
            // 
            // Azonosito
            // 
            this.Azonosito.HeaderText = "Azonositó";
            this.Azonosito.MinimumWidth = 6;
            this.Azonosito.Name = "Azonosito";
            this.Azonosito.Width = 125;
            // 
            // Megnevezes
            // 
            this.Megnevezes.HeaderText = "Megnevezés";
            this.Megnevezes.MinimumWidth = 6;
            this.Megnevezes.Name = "Megnevezes";
            this.Megnevezes.Width = 125;
            // 
            // Kategoria
            // 
            this.Kategoria.HeaderText = "Kategória";
            this.Kategoria.MinimumWidth = 6;
            this.Kategoria.Name = "Kategoria";
            this.Kategoria.Width = 125;
            // 
            // Netto_ar
            // 
            this.Netto_ar.HeaderText = "Nettó ár";
            this.Netto_ar.MinimumWidth = 6;
            this.Netto_ar.Name = "Netto_ar";
            this.Netto_ar.Width = 125;
            // 
            // Afa_kulcs
            // 
            this.Afa_kulcs.HeaderText = "Áfa kulcs";
            this.Afa_kulcs.MinimumWidth = 6;
            this.Afa_kulcs.Name = "Afa_kulcs";
            this.Afa_kulcs.Width = 125;
            // 
            // Garancia
            // 
            this.Garancia.HeaderText = "Garancia";
            this.Garancia.MinimumWidth = 6;
            this.Garancia.Name = "Garancia";
            this.Garancia.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(860, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kiválasztott áru neve";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(860, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mennyiség";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(860, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nettó érték";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(860, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Bruttó érték";
            // 
            // btnRendel
            // 
            this.btnRendel.Location = new System.Drawing.Point(335, 634);
            this.btnRendel.Name = "btnRendel";
            this.btnRendel.Size = new System.Drawing.Size(553, 61);
            this.btnRendel.TabIndex = 5;
            this.btnRendel.Text = "Rendelés és számlakészítés";
            this.btnRendel.UseVisualStyleBackColor = true;
            this.btnRendel.Click += new System.EventHandler(this.btnRendel_Click);
            // 
            // tbNev
            // 
            this.tbNev.Location = new System.Drawing.Point(864, 51);
            this.tbNev.Name = "tbNev";
            this.tbNev.ReadOnly = true;
            this.tbNev.Size = new System.Drawing.Size(314, 27);
            this.tbNev.TabIndex = 6;
            // 
            // nudMennyiseg
            // 
            this.nudMennyiseg.Location = new System.Drawing.Point(864, 105);
            this.nudMennyiseg.Name = "nudMennyiseg";
            this.nudMennyiseg.Size = new System.Drawing.Size(314, 27);
            this.nudMennyiseg.TabIndex = 7;
            this.nudMennyiseg.ValueChanged += new System.EventHandler(this.nudMennyiseg_ValueChanged);
            // 
            // tbNetto
            // 
            this.tbNetto.Location = new System.Drawing.Point(864, 243);
            this.tbNetto.Name = "tbNetto";
            this.tbNetto.ReadOnly = true;
            this.tbNetto.Size = new System.Drawing.Size(314, 27);
            this.tbNetto.TabIndex = 8;
            // 
            // tbBrutto
            // 
            this.tbBrutto.Location = new System.Drawing.Point(864, 303);
            this.tbBrutto.Name = "tbBrutto";
            this.tbBrutto.ReadOnly = true;
            this.tbBrutto.Size = new System.Drawing.Size(314, 27);
            this.tbBrutto.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Termékek";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(82, 394);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Rendelés";
            // 
            // btnHozzaad
            // 
            this.btnHozzaad.Location = new System.Drawing.Point(864, 333);
            this.btnHozzaad.Name = "btnHozzaad";
            this.btnHozzaad.Size = new System.Drawing.Size(314, 34);
            this.btnHozzaad.TabIndex = 13;
            this.btnHozzaad.Text = "Hozzáad";
            this.btnHozzaad.UseVisualStyleBackColor = true;
            this.btnHozzaad.Click += new System.EventHandler(this.btnHozzaad_Click);
            // 
            // dgvRendeles
            // 
            this.dgvRendeles.AllowUserToAddRows = false;
            this.dgvRendeles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRendeles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AruNev,
            this.Nettó_ar,
            this.Afa,
            this.Mennyiseg,
            this.Netto_ertek,
            this.Brutto_ertek});
            this.dgvRendeles.Location = new System.Drawing.Point(86, 417);
            this.dgvRendeles.Name = "dgvRendeles";
            this.dgvRendeles.ReadOnly = true;
            this.dgvRendeles.RowHeadersWidth = 51;
            this.dgvRendeles.RowTemplate.Height = 24;
            this.dgvRendeles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRendeles.Size = new System.Drawing.Size(802, 150);
            this.dgvRendeles.TabIndex = 14;
            // 
            // AruNev
            // 
            this.AruNev.HeaderText = "Áru neve";
            this.AruNev.MinimumWidth = 6;
            this.AruNev.Name = "AruNev";
            this.AruNev.ReadOnly = true;
            this.AruNev.Width = 125;
            // 
            // Nettó_ar
            // 
            this.Nettó_ar.HeaderText = "Nettó ár";
            this.Nettó_ar.MinimumWidth = 6;
            this.Nettó_ar.Name = "Nettó_ar";
            this.Nettó_ar.ReadOnly = true;
            this.Nettó_ar.Width = 125;
            // 
            // Afa
            // 
            this.Afa.HeaderText = "Áfa kulcs";
            this.Afa.MinimumWidth = 6;
            this.Afa.Name = "Afa";
            this.Afa.ReadOnly = true;
            this.Afa.Width = 125;
            // 
            // Mennyiseg
            // 
            this.Mennyiseg.HeaderText = "Mennyiség";
            this.Mennyiseg.MinimumWidth = 6;
            this.Mennyiseg.Name = "Mennyiseg";
            this.Mennyiseg.ReadOnly = true;
            this.Mennyiseg.Width = 125;
            // 
            // Netto_ertek
            // 
            this.Netto_ertek.HeaderText = "Nettó érték";
            this.Netto_ertek.MinimumWidth = 6;
            this.Netto_ertek.Name = "Netto_ertek";
            this.Netto_ertek.ReadOnly = true;
            this.Netto_ertek.Width = 125;
            // 
            // Brutto_ertek
            // 
            this.Brutto_ertek.HeaderText = "Bruttó érték";
            this.Brutto_ertek.MinimumWidth = 6;
            this.Brutto_ertek.Name = "Brutto_ertek";
            this.Brutto_ertek.ReadOnly = true;
            this.Brutto_ertek.Width = 125;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(477, 580);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "Fizetendő:";
            // 
            // tbFizetendo
            // 
            this.tbFizetendo.Location = new System.Drawing.Point(616, 580);
            this.tbFizetendo.Name = "tbFizetendo";
            this.tbFizetendo.ReadOnly = true;
            this.tbFizetendo.Size = new System.Drawing.Size(100, 27);
            this.tbFizetendo.TabIndex = 16;
            // 
            // btnModosit
            // 
            this.btnModosit.Location = new System.Drawing.Point(904, 417);
            this.btnModosit.Name = "btnModosit";
            this.btnModosit.Size = new System.Drawing.Size(274, 48);
            this.btnModosit.TabIndex = 17;
            this.btnModosit.Text = "Kijelölt tétel mennyiségének módosítása";
            this.btnModosit.UseVisualStyleBackColor = true;
            this.btnModosit.Click += new System.EventHandler(this.btnModosit_Click);
            // 
            // btnTorol
            // 
            this.btnTorol.Location = new System.Drawing.Point(904, 529);
            this.btnTorol.Name = "btnTorol";
            this.btnTorol.Size = new System.Drawing.Size(274, 38);
            this.btnTorol.TabIndex = 18;
            this.btnTorol.Text = "Kijelölt tétel törlése";
            this.btnTorol.UseVisualStyleBackColor = true;
            this.btnTorol.Click += new System.EventHandler(this.btnTorol_Click);
            // 
            // nudUjMennyiseg
            // 
            this.nudUjMennyiseg.Location = new System.Drawing.Point(953, 471);
            this.nudUjMennyiseg.Name = "nudUjMennyiseg";
            this.nudUjMennyiseg.Size = new System.Drawing.Size(120, 27);
            this.nudUjMennyiseg.TabIndex = 19;
            this.nudUjMennyiseg.Visible = false;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(1080, 471);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(46, 27);
            this.btnOk.TabIndex = 20;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Visible = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // tbAfa
            // 
            this.tbAfa.Location = new System.Drawing.Point(1028, 174);
            this.tbAfa.Name = "tbAfa";
            this.tbAfa.ReadOnly = true;
            this.tbAfa.Size = new System.Drawing.Size(108, 27);
            this.tbAfa.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1024, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Áfa kulcs";
            // 
            // tbAr
            // 
            this.tbAr.Location = new System.Drawing.Point(864, 174);
            this.tbAr.Name = "tbAr";
            this.tbAr.ReadOnly = true;
            this.tbAr.Size = new System.Drawing.Size(105, 27);
            this.tbAr.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(860, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = "Nettó ár";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(976, 183);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 20);
            this.label10.TabIndex = 25;
            this.label10.Text = "Ft";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1142, 183);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 20);
            this.label11.TabIndex = 26;
            this.label11.Text = "%";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(722, 587);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 20);
            this.label12.TabIndex = 27;
            this.label12.Text = "Ft";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.összesRendelésToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1192, 28);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // összesRendelésToolStripMenuItem
            // 
            this.összesRendelésToolStripMenuItem.Name = "összesRendelésToolStripMenuItem";
            this.összesRendelésToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.összesRendelésToolStripMenuItem.Text = "Összes rendelés";
            this.összesRendelésToolStripMenuItem.Click += new System.EventHandler(this.összesRendelésToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 707);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbAr);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbAfa);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.nudUjMennyiseg);
            this.Controls.Add(this.btnTorol);
            this.Controls.Add(this.btnModosit);
            this.Controls.Add(this.tbFizetendo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvRendeles);
            this.Controls.Add(this.btnHozzaad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbBrutto);
            this.Controls.Add(this.tbNetto);
            this.Controls.Add(this.nudMennyiseg);
            this.Controls.Add(this.tbNev);
            this.Controls.Add(this.btnRendel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTermekek);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTermekek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMennyiseg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRendeles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUjMennyiseg)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTermekek;
        private System.Windows.Forms.DataGridViewTextBoxColumn Azonosito;
        private System.Windows.Forms.DataGridViewTextBoxColumn Megnevezes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Netto_ar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Afa_kulcs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRendel;
        private System.Windows.Forms.TextBox tbNev;
        private System.Windows.Forms.NumericUpDown nudMennyiseg;
        private System.Windows.Forms.TextBox tbNetto;
        private System.Windows.Forms.TextBox tbBrutto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Garancia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnHozzaad;
        private System.Windows.Forms.DataGridView dgvRendeles;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbFizetendo;
        private System.Windows.Forms.Button btnModosit;
        private System.Windows.Forms.Button btnTorol;
        private System.Windows.Forms.NumericUpDown nudUjMennyiseg;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox tbAfa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbAr;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn AruNev;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nettó_ar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Afa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mennyiseg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Netto_ertek;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brutto_ertek;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem összesRendelésToolStripMenuItem;
    }
}

