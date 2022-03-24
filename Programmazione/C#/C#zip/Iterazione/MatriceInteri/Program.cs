using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatriceInteri
{
    class Program
    {
        static void Main(string[] args)
        {
            //definizione di una matrice di dimensioni nxm di numeri interi, n=righe, m=colonne
            //tipo di dato[][] identificatore=new int=[n][m]

            int[,] m = new int[3, 2];
            Random casuale = new Random();

            for (int i = 0; i < 3; i++) //itera righe
                for (int j = 0; j < 2; j++)
                    m[i, j] = casuale.Next(1, 90);

            //lettura della matrice
            for(int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                    Console.Write($"{m[i, j]} ");
                Console.WriteLine();
            }
        }
    }
}
