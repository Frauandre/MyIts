using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassePunto
{
    class Punto
    {
        public string Etichetta { get; set; }
        public double? X { get; set; }
        public double? Y { get; set; }

        //metodi
        public double Distanza() //distanza frau 2 punti
        {
            Punto o = new Punto() { X = 0, Y = 0 };
            return Distanza(o);
        }

        public double Distanza(Punto punto)
        {
            return Math.Sqrt(Math.Pow((double)(X - punto.X), 2) + Math.Pow((double)(Y - punto.Y), 2));

        }

        public override string ToString()
        {
            //condizione ? Risposta true, : Risposta False--->operatore ternario
            //se è vero          //se è falso
            return (!string.IsNullOrEmpty(Etichetta) ? Etichetta : "")
               + "(" +
                    (X!= null ? X : "")
               + "," +
                    (Y!= null ? Y : "") +
                 ")";
        }
    }
}
