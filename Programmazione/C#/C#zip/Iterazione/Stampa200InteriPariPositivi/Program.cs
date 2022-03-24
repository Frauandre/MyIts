using System;

namespace Stampa200InteriPariPositivi
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            while(count<200)
                Console.WriteLine($"{2*count++}");

            for(int i=0;i<200;i++)
                Console.WriteLine($"{2 * i}");

        }
    }
}
