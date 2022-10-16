using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace KönyvVásár
{
    public partial class UjKonyvForm : Form
    {
        Könyv v;

        internal Könyv V { get => v; set => v = value; }

        public UjKonyvForm()
        {
            InitializeComponent();
        }

        

        protected virtual void Felvesz()
        {
            if (Tbcim.Text != "")
            {
                if (rbKonyv.Checked)
                {
                    v = new Könyv(Tbcim.Text, tbSzerzo.Text, Convert.ToInt32(nudEv.Value), Convert.ToInt32(nudAr.Value));
                }
                else
                {
                    v = new KönyvSor(Tbcim.Text, tbSzerzo.Text, Convert.ToInt32(nudEv.Value), Convert.ToInt32(nudAr.Value), Convert.ToInt32(nudReszek.Value));
                }
                StreamWriter w = new StreamWriter("Konyvek.txt", true);
                w.WriteLine(V.ToString());
                w.Close();
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Hiányzó cím!");
            }
        }

       

        private void btnRogzites_Click_1(object sender, EventArgs e)
        {
            Felvesz();
        }

        private void rbKonyv_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = !groupBox2.Visible;
        }
    }

}
