using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseQuadrato
{
    class Quadrato
    {
        //campi o attributi
        private double _lato; //attributo accessibile in lettura e scrittura

        public double GetLato()
        {
            return _lato;
        }
        
        //proprietà
        public double Lato
        {
            get { return _lato; }

            set { 
                if(value>0)
                    _lato = value; }
        }


        //azioni o metodi
        public double Perimetro()
        {
           double p = _lato * 4;
            return p;
        }

        public double Area(){
            double a = _lato * _lato;
            return a;
        }

        public double Diagonale()
        {
            double d = _lato * Math.Sqrt(2);
            return d;
        }

        public string stampa()
        {
            return $"\nLato: {_lato}"
            + $"\nPerimetro: {Perimetro()}"
            + $"\nArea: {Area()}"
            + $"\nDiagonale: {Diagonale()}";
        }

        public override string ToString()
        {
            return $"Lato: {_lato}"
             + $", Perimetro: {Perimetro()}"
             + $", Area: {Area()}"
             + $", Diagonale: {Diagonale()}";
        }
    }
}
