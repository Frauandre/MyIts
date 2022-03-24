using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadrato
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inserisci il lato del quadrato");
            double lato = double.Parse(Console.ReadLine());

            double perimetro = lato * 4;
            double area = lato * lato;
            double diagonale = lato * Math.Sqrt(2);

            Console.WriteLine($"Perimetro : {perimetro}"); //$ sostituisce {0}
            Console.WriteLine($"Area : {area}");
            Console.WriteLine($"Diagonale : {diagonale}");

            Console.ReadLine();
        }
    }
}
