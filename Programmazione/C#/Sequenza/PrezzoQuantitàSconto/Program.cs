using System;

namespace PrezzoQuantitàSconto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Prezzo: ");
            double prezzo = double.Parse(Console.ReadLine());

            Console.Write("Quantità: ");
            int quantita = int.Parse(Console.ReadLine());

            Console.Write("Percentuale di sconto: ");
            double percentualeSconto = double.Parse(Console.ReadLine());

            double totale = prezzo * quantita;
            double sconto = totale * percentualeSconto / 100;
            double totaleSconto = totale - sconto;

            Console.WriteLine($"Totale : {(double)totale}");
            Console.WriteLine($"Sconto effettuato: {sconto}");
            Console.WriteLine($"Totale scontato: {totaleSconto}");

            Console.ReadKey();
        }
    }
}
