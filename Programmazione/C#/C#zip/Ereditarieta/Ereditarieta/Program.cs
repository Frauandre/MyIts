using System;

namespace Ereditarieta
{
    class Program
    {
        static void Main(string[] args)
        {
            var q1 = new Quadrilatero(1.2,2.3,3.4,4.5);
            Console.WriteLine(q1);

            var r1 = new Rettangolo(1.2, 2.3);
            Console.WriteLine(r1);

            var q2 = new Quadrato(1.2);
            Console.WriteLine(q2);
        }
    }
}
