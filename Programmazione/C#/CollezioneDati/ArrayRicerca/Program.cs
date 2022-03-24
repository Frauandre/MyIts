using System;

namespace ArrayRicerca
{
    class Program
    {
        static void Main(string[] args)
        {
            //riempire un array di numeri casuali interi
            //cercare un elemento dato in input
            //risultato numero non trovato, oppure numero trovato in posizione ?

            int[] numeri = new int[20];

            Random Casuale = new Random();

            Casuale.Next(-100, 100);
            
                for(int i = 0; i < numeri.Length; i++)
                    numeri[i] = Casuale.Next(-100, 100);
            

            Console.Write($"Inserire un numero intero[-100,100]: ");
            int n = int.Parse(Console.ReadLine());

            int pos = -1;
                for(int i = 0; i < numeri.Length; i++)
                    if (numeri[i]==n)
                {
                    pos = i;break;
                }

            if(pos != -1)
            {
                Console.WriteLine($"Numero trovato in posizione {pos}");
            }
            else
                Console.WriteLine($"Numero non trovato in posizione");
        }
    }
}
