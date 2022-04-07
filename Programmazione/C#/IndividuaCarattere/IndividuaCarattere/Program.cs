using System;

namespace IndividuaCarattere
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
             Esercizio n. 6 – IndividuaCarattere

Da tastiera digitare un tasto qualsiasi. 
            In output il programma deve restituire uno dei seguenti messaggi: 
            carattere alfabetico minuscolo, 
            carattere alfabetico maiuscolo, 
            carattere numerico, 
            carattere speciale.

Es. input: & output: carattere speciale
             */

            Console.Write("Digita un tasto della tastiera: ");
            int n = Console.Read();

            char c = (char)n;

            //Console.WriteLine($"hai digitato: {c}; posizione: {n}");

            if(n<=31)
                Console.WriteLine("carattere non rappresentabile");
            else if (c >= 'a' && c <= 'z')
                Console.WriteLine("carattere alfabetico minuscolo");
            else if(c>='A' && c <='Z')
                Console.WriteLine("carattere alfabetico maiuscolo");
            else if (c>='0' && c<='9')
                Console.WriteLine("carattere numerico");
            else 
                Console.WriteLine("carattere speciale");





        }
    }
}
