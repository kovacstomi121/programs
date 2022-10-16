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
    public partial class EladasForm : Form
    {
        List<Eladas> eladasok = new List<Eladas>();
        public EladasForm()
        {
            InitializeComponent();
            Beolvas();
            TablabaIr();
        }

        private void TablabaIr()
        {
            foreach (Eladas el in eladasok)
            {
                DataGridViewRow row = (DataGridViewRow)dvgEladas.Rows[0].Clone();
                row.Cells[0].Value = el.Könyv.Cim;
                row.Cells[1].Value = el.Könyv.Szerzo;
                row.Cells[2].Value = el.Könyv.Ev;
                row.Cells[3].Value = el.EladasiAr;
                if (el.Könyv is KönyvSor)
                {
                    KönyvSor k = el.Könyv as KönyvSor;
                    row.Cells[4].Value = k.Reszek;
                }


                row.Cells[5].Value = el.Vevo;
               
                dvgEladas.Rows.Add(row);
            }
        }

        private void Beolvas()
        {
            if (File.Exists("Eladasok.txt"))
            {
                StreamReader r = new StreamReader("Eladasok.txt");
                while (!r.EndOfStream)
                {
                    Könyv v;
                    Eladas el;
                    string[] s = r.ReadLine().Split(';');
                    if (s.Length == 9)
                    {
                        v = new Könyv(s[0], s[1], s[2], Convert.ToInt32(s[3]), Convert.ToInt32(s[4]), Convert.ToInt32(s[5]), Convert.ToBoolean(s[6]));
                        el = new Eladas(v, s[7], Convert.ToInt32(s[8]));

                    }
                    else
                    {
                        v = new KönyvSor(s[0], s[1], s[2], Convert.ToInt32(s[3]), Convert.ToInt32(s[4]), Convert.ToInt32(s[5]), Convert.ToBoolean(s[6]), Convert.ToInt32(s[7]));
                        el = new Eladas(v, s[8], Convert.ToInt32(s[9]));
                    }
                    eladasok.Add(el);
                }
                r.Close();
            }
        }

        private void dvgEladas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
