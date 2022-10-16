using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Számlakészítés
{
    class Tetel
    {
        Termek t;
        double mennyiseg;

        public Tetel(Termek t, double mennyiseg)
        {
            this.T = t;
            this.Mennyiseg = mennyiseg;
        }

        public Tetel()
        {
            
        }

        public double Mennyiseg { get => mennyiseg; set => mennyiseg = value; }
        internal Termek T { get => t; set => t = value; }

        public override string ToString()
        {
            return t.ToString()+ "\t"+mennyiseg;
        }

        public double NE()
        {
            return t.Netto* mennyiseg;
        }

        public double BE()
        {
            return NE() * (1 +Convert.ToDouble(t.Afa) / 100);
        }
    }
}
