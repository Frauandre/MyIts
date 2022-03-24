using System;

namespace ClassePunto
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             punto P(2;3)
            toString()
            (,)
            P(2;3)

            distanza dall'origine degli assi
            distanza da un altro punto
            */

            Punto P = new Punto();
            Punto Q = new Punto { X = 2, Y = -3 };
            Punto R = new Punto { Etichetta = "R", X = -1.2, Y = -3.4 };

            Console.Write(P);
            Console.Write(Q);
            Console.Write(R);

            Console.WriteLine($"0P={Q.Distanza()}");
            Console.WriteLine($"0Q={R.Distanza()}");
            

            Console.WriteLine($"QR={P.Distanza(R)}");
            Console.WriteLine($"RQ={R.Distanza(Q)}");
            
        }
    }
}
