using System;
using System.Linq;

namespace LinQ_Esempio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LinQ");

            string[] nomi = {"Pietro", "Mario", "Antonello", "Francesca",
                "Vanessa", "Ilaria", "Antonio", "Vito", "Michela",
                "Giuseppe", "Ludovico", "Sara", "Giulio"};
            /*
            Console.WriteLine("Elenco nomi: ");
            Console.WriteLine(string.Join("\n", nomi));
            */
            var query = from tutti in nomi select tutti;
            Console.WriteLine("\nElenco di tutti i nomi: ");
            Console.WriteLine(string.Join("\n", query));

            var query2 = from iniziaA in nomi
                         where iniziaA.Substring(0, 1).Equals("A")
                         select iniziaA;
            Console.WriteLine("\nElenco di tutti i nomi che iniziano con la A: ");
            Console.WriteLine(string.Join("\n", query2));

            var query3 = from ordinaAsc in nomi
                         orderby ordinaAsc
                         select ordinaAsc;
            Console.WriteLine("\nElenco di tutti i nomi in ordine crescente: ");
            Console.WriteLine(string.Join("\n", query3));

            var query4 = from lunghezza7 in nomi
                         where lunghezza7.Length == 7
                         select lunghezza7;
            Console.WriteLine("\nElenco di tutti i nomi in ordine di lunghezza = 7: ");
            Console.WriteLine(string.Join("\n", query4));

            Console.WriteLine("\nOperazioni con i numeri:");
            int[] numeri = { 12, -1, 34, 4, 56, 63, -3, 21, 76, 45, -12, 29, 90, 60 };
            Console.WriteLine("Max: " + numeri.Max());
            Console.WriteLine("Min: " + numeri.Min());
            Console.WriteLine("Media: " + numeri.Average());
            Console.WriteLine("Somma: " + numeri.Sum());

            var q1 = from sommaPositivi in numeri
                     where sommaPositivi > 0
                     select sommaPositivi;
            Console.WriteLine("Somma: " + q1.Sum());

            var q2 = from maggiori50 in numeri
                     where maggiori50 > 50
                     select maggiori50;
            Console.WriteLine("\nMaggiori di 50: ");
            Console.WriteLine(string.Join("\n", q2));

            var q3 = from numeriPari in numeri
                     where numeriPari % 2 == 0
                     select numeriPari;
            Console.WriteLine("\nNumeri Pari: ");
            Console.WriteLine(string.Join("\n", q3));
        }
    }
}
