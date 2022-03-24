using System;

namespace QuadratoSommaNDispari
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            1 = 1
            4 = 1+3
            9 = 1+3+5
            16 = 1+3+5+7
            25 = 1+3+5+7+9

            Se da input inserisco 11 cosa ottengo in output?
              
             */
            int n;
            do
            {
                Console.Write("inserisci un numero intero positivo: ");
                n = int.Parse(Console.ReadLine());

                if (n <= 0)
                    Console.WriteLine("Errore");

            } while (n <= 0);

            int somma = 0;
            string msg = "";
            for (int i = 0; i < n; i++)
            {
                somma += i * 2 + 1;

                msg += (i!=0 ? "+":"") + (i * 2 + 1);
            }
               
            Console.WriteLine($"{somma}={msg}");
        }
    }
}
