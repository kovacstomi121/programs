namespace KönyvVásár
{
    partial class ErdeklodoForm
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbEladas = new System.Windows.Forms.RadioButton();
            this.rbErdeklodes = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.tbErdeklodoNev = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nudEladasiAr = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEv)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudReszek)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEladasiAr)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(35, 17);
            this.groupBox1.Size = new System.Drawing.Size(302, 308);
            // 
            // tbSzerzo
            // 
            this.tbSzerzo.ReadOnly = true;
            // 
            // Tbcim
            // 
            this.Tbcim.ReadOnly = true;
            // 
            // nudAr
            // 
            this.nudAr.Location = new System.Drawing.Point(30, 248);
            this.nudAr.ReadOnly = true;
            // 
            // nudEv
            // 
            this.nudEv.ReadOnly = true;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(26, 225);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(407, 17);
            this.groupBox2.Size = new System.Drawing.Size(311, 129);
            // 
            // nudReszek
            // 
            this.nudReszek.ReadOnly = true;
            // 
            // btnRogzites
            // 
            this.btnRogzites.Location = new System.Drawing.Point(270, 388);
            // 
            // rbKonyv
            // 
            this.rbKonyv.Location = new System.Drawing.Point(52, 417);
            // 
            // rbKonyvSor
            // 
            this.rbKonyvSor.Location = new System.Drawing.Point(52, 447);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbEladas);
            this.groupBox3.Controls.Add(this.rbErdeklodes);
            this.groupBox3.Location = new System.Drawing.Point(407, 162);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(318, 100);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // rbEladas
            // 
            this.rbEladas.AutoSize = true;
            this.rbEladas.Location = new System.Drawing.Point(20, 62);
            this.rbEladas.Name = "rbEladas";
            this.rbEladas.Size = new System.Drawing.Size(82, 24);
            this.rbEladas.TabIndex = 1;
            this.rbEladas.Text = "Eladás";
            this.rbEladas.UseVisualStyleBackColor = true;
            // 
            // rbErdeklodes
            // 
            this.rbErdeklodes.AutoSize = true;
            this.rbErdeklodes.Checked = true;
            this.rbErdeklodes.Location = new System.Drawing.Point(20, 26);
            this.rbErdeklodes.Name = "rbErdeklodes";
            this.rbErdeklodes.Size = new System.Drawing.Size(117, 24);
            this.rbErdeklodes.TabIndex = 0;
            this.rbErdeklodes.TabStop = true;
            this.rbErdeklodes.Text = "Érdeklődés";
            this.rbErdeklodes.UseVisualStyleBackColor = true;
            this.rbErdeklodes.CheckedChanged += new System.EventHandler(this.rbErdeklodes_CheckedChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(482, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Érdeklődő/Vevő neve";
            // 
            // tbErdeklodoNev
            // 
            this.tbErdeklodoNev.Location = new System.Drawing.Point(486, 289);
            this.tbErdeklodoNev.Name = "tbErdeklodoNev";
            this.tbErdeklodoNev.Size = new System.Drawing.Size(185, 26);
            this.tbErdeklodoNev.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(482, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Eladási ár";
            this.label5.Visible = false;
            // 
            // nudEladasiAr
            // 
            this.nudEladasiAr.Location = new System.Drawing.Point(486, 341);
            this.nudEladasiAr.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudEladasiAr.Name = "nudEladasiAr";
            this.nudEladasiAr.Size = new System.Drawing.Size(185, 26);
            this.nudEladasiAr.TabIndex = 9;
            this.nudEladasiAr.Visible = false;
            // 
            // ErdeklodoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 501);
            this.Controls.Add(this.nudEladasiAr);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbErdeklodoNev);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox3);
            this.Name = "ErdeklodoForm";
            this.Text = "ErdeklodoForm";
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.btnRogzites, 0);
            this.Controls.SetChildIndex(this.rbKonyv, 0);
            this.Controls.SetChildIndex(this.rbKonyvSor, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.tbErdeklodoNev, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.nudEladasiAr, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEv)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudReszek)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEladasiAr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbEladas;
        private System.Windows.Forms.RadioButton rbErdeklodes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbErdeklodoNev;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudEladasiAr;
    }
}