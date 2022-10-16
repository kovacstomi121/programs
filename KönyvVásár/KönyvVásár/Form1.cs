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
    public partial class Form1 : Form
    {
        List<Könyv> konyvek = new List<Könyv>();
        public Form1()
        {
            InitializeComponent();
            Beolvas();


        }
        
        private void Beolvas()
        {
            if (File.Exists("Konyvek.txt"))
            {
                Könyv v;
                StreamReader r = new StreamReader("Konyvek.txt");
                while (!r.EndOfStream)
                {
                    string[] s = r.ReadLine().Split(';');
                    if (s.Length == 7)
                    {
                        v = new Könyv(s[0], s[1], s[2], Convert.ToInt32(s[3]), Convert.ToInt32(s[4]), Convert.ToInt32(s[5]), Convert.ToBoolean(s[6]));

                    }
                    else
                    {
                        v = new KönyvSor(s[0], s[1], s[2], Convert.ToInt32(s[3]),
                             Convert.ToInt32(s[4]), Convert.ToInt32(s[5]),
                             Convert.ToBoolean(s[6]), Convert.ToInt32(s[7]));
                       
                    }

                    konyvek.Add(v);
                    lbKönyvek.Items.Add(v.Azonosito + "\t" + v.Cim);


                }
                r.Close();
                Könyv.Szam = konyvek.Count;
            }
        }




        private void Kiir()
        {
            if (lbKönyvek.SelectedIndex >= 0)
            {
                tbAz.Text = konyvek[lbKönyvek.SelectedIndex].Azonosito;
                tbCim.Text = konyvek[lbKönyvek.SelectedIndex].Cim;
                tbSzerzo.Text = konyvek[lbKönyvek.SelectedIndex].Szerzo;
                tbEv.Text = konyvek[lbKönyvek.SelectedIndex].Ev.ToString();
                tbErdeklodok.Text = konyvek[lbKönyvek.SelectedIndex].Erdeklodok.ToString();
                tbAr.Text = konyvek[lbKönyvek.SelectedIndex].Ar.ToString();
                if (konyvek[lbKönyvek.SelectedIndex] is KönyvSor)
                {
                    groupBox2.Visible = true;
                    KönyvSor k = konyvek[lbKönyvek.SelectedIndex] as KönyvSor;
                    tbReszek.Text = k.Reszek.ToString();

                }
                else
                {
                    groupBox2.Visible = false;
                }
                if (konyvek[lbKönyvek.SelectedIndex].Eladva)
                {
                    labEladva.Visible = true;
                }
                else
                {
                    labEladva.Visible = false;
                }
                

            }

        }

       

        private void újKönyvToolStripMenuItem_Click(object sender, EventArgs e)
        {

            UjKonyvForm uj = new UjKonyvForm();
            if (uj.ShowDialog() == DialogResult.OK)
            {
                konyvek.Add(uj.V);
                lbKönyvek.Items.Add(uj.V.Azonosito + "\t" + uj.V.Cim);
            }
        }

        private void lbKönyvek_SelectedIndexChanged(object sender, EventArgs e)
        {
            Kiir();
        }

        private void érdekődőkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lbKönyvek.SelectedIndex >= 0)
            {
                Könyv v = konyvek[lbKönyvek.SelectedIndex];
                if (!v.Eladva)
                {
                    ErdeklodoForm uj = new ErdeklodoForm(v);
                    if (uj.ShowDialog() == DialogResult.OK)
                    {
                        Kiir();
                        if (v.Eladva)
                        {
                            FilebaIras();
                        }
                       
                    }
                }
                else
                {
                    MessageBox.Show("A könyv elkelt!");
                }
            }
            else
            {
                MessageBox.Show("Nincs kiválasztva könyv!");
            }
        }

        private void eladásokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EladasForm uj = new EladasForm();
            uj.ShowDialog();
        }
        private void FilebaIras()
        {
            if(File.Exists("Konyvek.txt"))
            {
                StreamWriter w = new StreamWriter("Konyvek.txt");
                {
                    foreach(Könyv v in konyvek)
                    {
                        w.WriteLine(v.ToString());
                    }
                }
                w.Close();
            }
        }
       
            }
        }

    
