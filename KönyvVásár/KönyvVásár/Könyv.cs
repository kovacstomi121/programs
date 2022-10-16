using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KönyvVásár
{
    public class Könyv
    {
        static int szam = 0;
        protected string azonosito, cim, szerzo;
        protected int ev, erdeklodok, ar;
        protected bool eladva;
       



        public Könyv(string azonosito, string cim, string szerzo, int ev, int erdeklodok, int ar, bool eladva)
        {
            this.azonosito = azonosito;
            this.cim = cim;
            this.szerzo = szerzo;
            this.ev = ev;
            this.erdeklodok = erdeklodok;
            this.ar = ar;
            this.eladva = eladva;
            
           
        }
        public Könyv(string cim, string szerzo, int ev, int ar)
        {
            this.azonosito = (++Szam).ToString();
            this.cim = cim;
            this.szerzo = szerzo;
            this.ev = ev;
            this.ar = ar;

        }
        public Könyv()
        {

        }

        public string Azonosito { get => azonosito; set => azonosito = value; }
        public string Cim { get => cim; set => cim = value; }
        public string Szerzo { get => szerzo; set => szerzo = value; }
        public int Ev { get => ev; set => ev = value; }
        public int Erdeklodok { get => erdeklodok; set => erdeklodok = value; }
        public int Ar { get => ar; set => ar = value; }

        public bool Eladva { get => eladva; set => eladva = value; }

        public static int Szam { get => szam; set => szam = value; }
       

        public override string ToString()
        {
            return azonosito + ";" + cim + ";" + szerzo + ";" + ev+ ";" +erdeklodok + ";" + ar+";"+eladva ;
        }
    }
}

