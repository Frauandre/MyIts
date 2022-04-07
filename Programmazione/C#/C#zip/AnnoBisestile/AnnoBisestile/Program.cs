using System;

namespace AnnoBisestile
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Esercizio n. 3 – AnnoBisestile
                Recuperato un anno da input, dire se si tratta di un anno bisestile.
                Es. input: 2003 output: 2003 non è un anno bisestile
             
            input: 2000 output: 2000 è un anno bisestile
            input: 1900 output: 1900 NON è un anno bisestile
             * 
             * * */

            int a = DateTime.Now.Year; //anno recuperato dal sistema operativo
            //int a = 2004;

            if(a%100==0 && a%400==0)
                Console.WriteLine($"{a} è bisestile");
            else if (a%100!=0 && a % 4 == 0)
                Console.WriteLine($"{a} è bisestile");
            else
                Console.WriteLine($"{a} NON è bisestile");
        }
    }
}
