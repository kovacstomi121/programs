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
    public partial class ErdeklodoForm : UjKonyvForm
    {
        Könyv v;

        public ErdeklodoForm(Könyv könyv)
        {
            InitializeComponent();
            v = könyv;
            Tbcim.Text = v.Cim;
            tbSzerzo.Text = v.Szerzo;
            nudEv.Value = v.Ev;
            nudAr.Value = v.Ar;
            if (v is KönyvSor)
            {
                KönyvSor k = v as KönyvSor;
                rbKonyvSor.Checked = true;
                this.rbKonyvSor.Location = new System.Drawing.Point(38, 292);
                rbKonyv.Visible = false;
                nudReszek.Value = k.Reszek;

            }
            else
            {
                rbKonyvSor.Visible = false;
                rbKonyv.Checked = true;
                groupBox2.Visible = false;
            }
        }
        protected override void Felvesz()
        {

            if (tbErdeklodoNev.Text != "")
            {
                if (rbErdeklodes.Checked)
                {
                    v.Erdeklodok++;
                }
                else
                {
                    v.Eladva = true;
                    Eladas el = new Eladas(v, tbErdeklodoNev.Text, Convert.ToInt32(nudEladasiAr.Value));
                    StreamWriter w = new StreamWriter("Eladasok.txt", true);
                    w.WriteLine(el.ToString());
                    w.Close();
                }
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Nem adta meg az Érdeklődő/vevő nevét!");
            }

        }




        private void rbErdeklodes_CheckedChanged_1(object sender, EventArgs e)
        {
            label5.Visible = !label5.Visible;
            nudEladasiAr.Visible = !nudEladasiAr.Visible;
        }
    }

    
    }


