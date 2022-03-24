using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Somma2Interi
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, somma;

            Console.Write("Inserisci un numero intero: ");
            string tmp = Console.ReadLine();
            a = int.Parse(tmp);

            Console.Write("Inserisci il secondo numero intero: ");
            tmp = Console.ReadLine();
            b = int.Parse(tmp);

            somma = a + b;

            Console.WriteLine("Somma: " + somma);
            Console.WriteLine(a + "+" + b + "=" + somma);
            Console.WriteLine("{0}+{1}={2}", a, b, somma);
            //printf("%d+%d=%d")

            Console.Read();


        }
    }
}
