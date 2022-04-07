using System;

namespace Solidi
{
    //bozza
    public enum ElencoMateriali
    {
        ACCIAIO, ALLUMINIO, ARGENTO, DIAMANTE, FERRO, ORO, PIOMBO, PLATINO, STAGNO
    }

    class Program
    {
        //si vuole definire un solido cubo e un solido sfera
        //si vuole calcolare il peso di un cubo e di una sfera
        //di un certo materiale di cui si conosce il peso specifico

        static void Main(string[] args)
        {
            //tabella dei materiali per i peso specifici
            //https://www.oppo.it/tabelle/pesi_specifici.html
            Solido s;// = new Solido(7.85);

            //quale materiale vuoi utilizzare?
            //oro - peso specifico 19.3 kg/dm^3

            var cubo = new Cubo(1, 19.3);
            var sfera = new Sfera(1, 19.3);

            Console.WriteLine(cubo);
            Console.WriteLine(sfera);

        }
    }
}
