using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KönyvVásár
{
    internal class Eladas
    {
        Könyv könyv;
        string vevo;
        int eladasiAr;

        public Eladas(Könyv könyv, string vevo, int eladasiAr)
        {
            this.Könyv = könyv;
            this.Vevo = vevo;
            this.EladasiAr = eladasiAr;
        }

        public Könyv Könyv { get => könyv; set => könyv = value; }
        public string Vevo { get => vevo; set => vevo = value; }
        public int EladasiAr { get => eladasiAr; set => eladasiAr = value; }
        public override string ToString()
        {
            return könyv.ToString() + ";" + vevo + ";" + eladasiAr;
        }
    }
}

