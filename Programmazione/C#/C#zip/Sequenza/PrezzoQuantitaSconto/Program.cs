using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrezzoQuantitaSconto
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
            int percentualeSconto = int.Parse(Console.ReadLine());

            double totale = prezzo * quantita;
            double sconto = totale * percentualeSconto / 100;
            double totaleScontato = totale - sconto;

            Console.WriteLine("Percentuale di sconto: {0:P}", (double)percentualeSconto/100);
            Console.WriteLine("Totale: {0:#.##}", totale);
            Console.WriteLine("Sconto effettuato: {0:C}", sconto);
            Console.WriteLine("Totale scontato: {0} €", totaleScontato);

            Console.ReadKey();




        }
    }
}
