using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe100
{
    class Cerchio
    {
        // private double _raggio;

        public double Raggio {get;set;}

        //metodi
        public double Diametro()
        {
            return 2 * Raggio;
        }

        public double Circonferenza()
        {
            return Math.PI * Diametro();
        }

        public double Area()
        {
            return Math.PI * Math.Pow(Raggio, 2);
        }

        public override string ToString()
        {
            return $"Raggio: {Raggio}"
                + $"\nDiametro: {Diametro()}"
                + $"\nCirconferenza: {Circonferenza()}"
                + $"\nArea: {Area()}";


        }
    }
}
