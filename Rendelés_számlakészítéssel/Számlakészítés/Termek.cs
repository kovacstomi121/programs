using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Számlakészítés
{
    class Termek
    {
        string azonosito, megnevezes;
        double netto;
        Kategoria kat;
        Afa afa;

        public string Azonosito { get => azonosito; set => azonosito = value; }
        public string Megnevezes { get => megnevezes; set => megnevezes = value; }
        public double Netto { get => netto; set => netto = value; }
        public Kategoria Kat { get => kat; set => kat = value; }
        public Afa Afa { get => afa; set => afa = value; }

        public Termek(string azonosito, string megnevezes, Kategoria kat, double netto, Afa afa)
        {
            this.Azonosito = azonosito;
            this.Megnevezes = megnevezes;
            this.Kat = kat;
            this.Netto = netto;
            this.Afa = afa;
        }

        public Termek()
        {
            
        }

        public override string ToString()
        {
            return azonosito + "\t" + megnevezes + "\t" + Convert.ToInt32(kat) + "\t" + netto + "\t" + afa;
        }
    }

    public enum Afa { A=0, B=5, C=18, D=27 };

    public enum Kategoria { Hasznalt, Uj };
}
