using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseTriangolo
{
    class Triangolo
    {
        public double Lato1 { get; set; }
        public double Lato2 { get; set; }
        public double Lato3 { get; set; }

        //metodi
        public bool isCostruibile()
        {
            return Lato1 + Lato2 > Lato3 && Lato2 + Lato3 > Lato1 && Lato3 + Lato1 > Lato2;
        }
        public double Perimetro()
        {
            return Lato1 + Lato2 + Lato3;
        }

        public double Area()
        {
            if (!isCostruibile())
                return -1;

            //formula di Erone
            double sp = Perimetro() / 2; //semiperimetro

            return Math.Sqrt(sp*(sp-Lato1)*(sp-Lato2)*(sp-Lato3));
        }

        public string Tipo()
        {
            if (Lato1 == Lato2 && Lato1 == Lato3)
                return "Equilatero";
            else if (Lato1 == Lato2 || Lato1 == Lato3 || Lato2 == Lato3)
                return "Isoscele";
            return "Scaleno";
        }

        public override string ToString()
        {
            if (!isCostruibile())
                return "Con i dati inseriti non è possibile costruire un triangolo";

            return $"Lato1: {Lato1}"
              + $"\nLato2: {Lato2}"
              + $"\nLato3: {Lato3}"
              + $"\nPerimetro: {Perimetro()}"
              + $"\nArea: {Area()}"
              + $"\nTipo: {Tipo()}";

        }
    }
}
