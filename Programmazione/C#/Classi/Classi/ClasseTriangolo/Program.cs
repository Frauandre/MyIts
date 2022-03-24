using System;

namespace ClasseTriangolo
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangolo t1 = new Triangolo() { Lato1 = 20, Lato2 = 15, Lato3 = 20 };
           
            Triangolo t2 = new Triangolo(
                new Punto { X = 2, Y = 3 },
                new Punto { X = 1, Y = -3 },
                new Punto { X = 2.5, Y = 1.75 }
                );
        }
        Console.WriteLine(t1);
        Console.WriteLine(t2);
    }
}
