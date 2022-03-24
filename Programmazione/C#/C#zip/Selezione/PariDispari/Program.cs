using System;

namespace PariDispari
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Inserisci un numero intero");
            n = int.Parse(Console.ReadLine());

            if(n%2==0)
                Console.WriteLine($"{n} è un numero pari");
            else
                Console.WriteLine($"{n} non è un numero pari");
        }
    }
}
