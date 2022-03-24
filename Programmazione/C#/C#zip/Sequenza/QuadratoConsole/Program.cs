using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadratoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inserisci il lato del quadrato: ");
            double lato = double.Parse(Console.ReadLine());

            double perimetro = lato * 4;
            double area = lato * lato;
            double diagonale = lato * Math.Sqrt(2);

            Console.WriteLine($"Perimetro: {perimetro}");
            Console.WriteLine($"Area: {area}");
            Console.WriteLine($"Diagonale: {diagonale:#.####}");
            Console.WriteLine("Diagonale: {0:#.####}",diagonale);

            Console.ReadLine();



        }
    }
}
