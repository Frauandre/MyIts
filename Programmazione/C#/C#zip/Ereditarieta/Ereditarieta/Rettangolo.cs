using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ereditarieta
{
    // HAS-A, IS-A
    class Rettangolo:Quadrilatero
    {
        public Rettangolo(double @base, double altezza)
            : base(@base, altezza, @base, altezza) { }
        
        public double Area() {
            return base.Lato1 * base.Lato2;
        }

        public double Diagonale() {
            return Math.Sqrt(Math.Pow(Lato1, 2) + Math.Pow(Lato2, 2));
        }

        public override string ToString()
        {
            return $"{{Base={Lato1.ToString()}" +
                $", Altezza={Lato2.ToString()}" +
                $", Perimetro={Perimetro().ToString()}" +
                $", Area={Area().ToString()}" +
                $", Diagonale={Diagonale().ToString()}" +
                $"}}";
        }
    }
}
