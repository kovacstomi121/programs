using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Számlakészítés
{
    class gTermek:Termek
    {
        int tartam;

        public gTermek(string azonosito, string megnevezes, Kategoria kat, double netto, 
            Afa afa, int tartam)
            :base (azonosito, megnevezes, kat, netto, afa)
        {
            this.tartam = tartam;
        }

        public int Tartam { get => tartam; set => tartam = value; }

        public override string ToString()
        {
            return base.ToString()+"\t"+tartam;
        }
    }
}
