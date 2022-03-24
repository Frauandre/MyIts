using System;

namespace MaxMinNInteri
{
    class Program
    {
        static void Main(string[] args)
        {

            int n;
            do
            {
                Console.Write("Quanti numeri vuoi acquisire: ");
                n = int.Parse(Console.ReadLine());

                if (n <= 0)
                    Console.WriteLine("Errore");

            } while (n <= 0);

            int max=int.MinValue, min=int.MaxValue, numero;
            for (int i = 0; i < n; i++)
            {
                Console.Write("Inserisci un numero intero positivo: ");
                numero = int.Parse(Console.ReadLine());
                if (max < numero)
                    max = numero;
                else if (min > numero)
                    min = numero;

            }

            Console.WriteLine($"Max: {max}, min: {min}");
        }
    }
}
