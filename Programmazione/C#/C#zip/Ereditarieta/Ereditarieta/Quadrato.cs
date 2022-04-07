using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ereditarieta
{
    class Quadrato:Rettangolo
    {
        public Quadrato(double lato) : base(lato, lato) { }

        public override string ToString()
        {
            return $"{{" +
                $"Lato={Lato1.ToString()}" +
                $", Perimetro={Perimetro().ToString()}" +
                $", Area={Area().ToString()}" +
                $", Diagonale={Diagonale().ToString()}" +
                $"}}";
        }
    }
}
