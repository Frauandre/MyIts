using System;

namespace NomeMese
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Esercizio n. 5 – NomeMese

Stampare il nome del mese corrispondente al valore numerico [1-12] fornito in input.

Es. input: 7 output: Luglio
             * */

            Console.Write("Inserisci un numero intero [1-12]: ");
            int n = Convert.ToInt32(Console.ReadLine());

            string mese = "";
            switch (n) {
                case 1: mese = "Gennaio";break;
                case 2: mese = "Febbraio"; break;
                case 3: mese = "Marzo"; break;
                case 4: mese = "Aprile"; break;
                case 5: mese = "Maggio"; break;
                case 6: mese = "Giugno"; break;
                case 7: mese = "Luglio"; break;
                case 8: mese = "Agosto"; break;
                case 9: mese = "Settembre"; break;
                case 10: mese = "Ottobre"; break;
                case 11: mese = "Novembre"; break;
                case 12: mese = "Dicembre"; break;
                default: mese = "Valore inserito non corrisponde a nessun mese dell'anno!";break;
            }

            Console.WriteLine(mese);
        }
    }
}
