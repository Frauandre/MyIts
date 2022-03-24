using System;

namespace MatriciMultiDimensionali
{
    class Program
    {
        static void Main(string[] args)
        {
            Random casuale = new Random();

            const int inf = 1;
            const int sup = 10;

            int righe = casuale.Next(inf, sup);

            //dichiaro la matrice
            int[][] m = new int[righe][];

            //riempimento della matrice
            for(int i = 0; i < m.Length; i++)
            {
                m[i] = new int[casuale.Next(inf, sup)];
                for (int j = 0; j < m[i].Length; j++)
                    m[i][j] = casuale.Next(1, 100);
               
            }

            Console.WriteLine("Stampa della matrice: ");
            //lettura della matrice
            for (int i = 0; i < m.Length; i++)
            {
                for (int j = 0; j < m[i].Length; j++)
                    Console.Write($"{m[i][j]} ");
                Console.WriteLine();
            }

            
        }
    }
}
