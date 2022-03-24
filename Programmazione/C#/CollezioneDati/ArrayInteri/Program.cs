using System;

namespace ArrayInteri
{
    class Program
    {
        static void Main(string[] args)
        {
            //tipo[] identificatore=new tipo[dimensione]
            int[] numeri = new int[5];

            numeri[0] = 0;
            numeri[1] = 1;
            numeri[2] = 2;
            numeri[3] = 3;
            numeri[4] = 4;
            
            
            for(int i=0; i<numeri.Length; i++) 

            Console.WriteLine($"(i): {numeri[i]}");
        }
    }
}
