using System;

namespace ClasseQuadrato
{
    class Program
    {
        static void Main(string[] args)
        {
            //tipi classe
            Quadrato q = new Quadrato(); //istanza
            q.Lato = 1.25;
            Console.WriteLine(q.stampa());


            Quadrato q1 = new Quadrato();
            q1.Lato = 5.26;
            Console.WriteLine(q1.stampa());


            Quadrato q2 = new Quadrato();
            Console.Write("Inserisci il dato del quadrato: ");

            q2.Lato = (double.Parse(Console.ReadLine()));
            Console.WriteLine(q2.stampa());
        }
    }
}
