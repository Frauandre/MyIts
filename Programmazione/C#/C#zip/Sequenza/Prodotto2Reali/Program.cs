using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prodotto2Reali
{
    class Program
    {
        static void Main(string[] args)
        {

            double a, b;            
            double p; //prodotto di due numeri reali

            Console.Write("Inserisci un numero reale: ");
            a = double.Parse(Console.ReadLine());

            Console.Write("Inserisci un altro numero reale: ");
            b = double.Parse(Console.ReadLine());
                        
            p = a*b;

            Console.WriteLine("Prodotto: {0}", p);
            
            Console.ReadKey();


        }
    }
}
