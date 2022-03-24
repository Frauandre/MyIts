using System;

namespace ArrayReali
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numeri = new double[5];

            numeri[0] = 1.5;
            numeri[1] = 1.8;
            numeri[2] = 2.5;
            numeri[3] = 3.6;
            numeri[4] = 4.7;


            for(int i = 0; i < numeri.Length; i++)
                Console.WriteLine("Hello World!");
        }
    }
}
