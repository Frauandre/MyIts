using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ereditarieta
{
    class Quadrilatero
    {
        //quattro lati diversi
        public double Lato1 { get; set; }
        public double Lato2 { get; set; }
        public double Lato3 { get; set; }
        public double Lato4 { get; set; }

        public Quadrilatero(double lato1, double lato2, double lato3, double lato4)
        {
            Lato1 = lato1;
            Lato2 = lato2;
            Lato3 = lato3;
            Lato4 = lato4;
        }

        public double Perimetro() {
            return Lato1 + Lato2 + Lato3 + Lato4;
        }

        public override string ToString()
        {
            return $"{{" +
                $"{nameof(Lato1)}={Lato1.ToString()}" +
                $", {nameof(Lato2)}={Lato2.ToString()}" +
                $", {nameof(Lato3)}={Lato3.ToString()}" +
                $", {nameof(Lato4)}={Lato4.ToString()}" +
                $", {nameof(Perimetro)}={Perimetro()}" +
                $"}}";
        }
    }

}
