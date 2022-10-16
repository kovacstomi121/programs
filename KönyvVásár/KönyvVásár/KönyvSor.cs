using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KönyvVásár
{
    public class KönyvSor:Könyv
    {
        int reszek;

        public KönyvSor(string azonosito, string cim, string szerzo, int ev, int erdeklodok, int ar,bool eladva, int reszek) 
            :base(azonosito, cim, szerzo, ev, erdeklodok, ar, eladva)
        {
            this.reszek = reszek;
        }
        public KönyvSor(string cim, string szerzo, int ev, int ar, int reszek) 
            :base(cim, szerzo, ev, ar)
        {
            this.reszek = reszek;
        }

       public KönyvSor() { }

        public int Reszek { get => reszek; set => reszek = value; }

        public override string ToString()
        {
            return azonosito + ";" + cim + ";" + szerzo + ";" + ev + ";" + erdeklodok + ";" + ar + ";" + eladva + ";"+reszek;
        }
    }
}

