using System;

namespace GiornoSettimana
{
    class Program
    {
        static void Main(string[] args)
        {
            //dato in inpt un numero intero [1,7]
            //stampare il giorno della settimana oppure Errore
    
            Console.WriteLine("Inserisci un numero intero");
            int n = int.Parse(Console.ReadLine());


            string msg;
            switch (n)
            {
                case 1: msg = "Lunedì";break;
                case 2: msg = "Martedì"; break;
                case 3: msg = "Mercoledì"; break;
                case 4: msg = "Giovedì"; break;
                case 5: msg = "Venerdì"; break;
                case 6: msg = "Sabato"; break;
                case 7: msg = "Domenica"; break;
                default:msg = "Errore!";break;

            }

            Console.WriteLine(msg);
        }
    }
}
