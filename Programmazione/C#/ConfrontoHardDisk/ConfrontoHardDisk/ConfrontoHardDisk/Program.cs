using System;
using System.Collections.Generic;

namespace ConfrontoHardDisk
{
    class Program
    {
        static void Main(string[] args)
        {
            var hdz = new HardDiskBiz();

            hdz.Elenco = new List<HardDisk> {
                new HardDisk{Marca="marca 1",Velocita=5500,Tempo=234,Capacita=200},
                new HardDisk{Marca="marca 2",Velocita=6500,Tempo=741,Capacita=100},
                new HardDisk{Marca="marca 3",Velocita=6500,Tempo=1596,Capacita=40},
                new HardDisk{Marca="marca 4",Velocita=8500,Tempo=999,Capacita=20},
                new HardDisk{Marca="marca 5",Velocita=8500,Tempo=584,Capacita=2},
                new HardDisk{Marca="marca 6",Velocita=10500,Tempo=134,Capacita=400},
                new HardDisk{Marca="marca 7",Velocita=4500,Tempo=204,Capacita=600},
                new HardDisk{Marca="marca 8",Velocita=5000,Tempo=2340,Capacita=700},
                new HardDisk{Marca="marca 9",Velocita=8800,Tempo=734,Capacita=1200},
                new HardDisk{Marca="marca 10",Velocita=6600,Tempo=1234,Capacita=100}
            };

            string menu = "\nElenco operazioni ammesse"
                + "\n1 - visualizzare l'elenco degli hard disk"
                + "\n2 - ordinare gli hard disk in base alla capacità crescente"
                + "\n3 - mostrare i dati dell’hard disk con punteggio migliore"
                + "\n4 - mostrare i dati dell’hard disk con punteggio peggiore"
                + "\n5 - mostrare i dati di un certo hard disk individuato tramite la marca(considerato un dato che individua univocamente l'hard disk)"
                + "\n0 - esci";
            
            bool stop = false;
            do {
                Console.WriteLine(menu);
                Console.Write("\nScelta: ");
                switch (int.Parse(Console.ReadLine())) {
                    case 1: Console.WriteLine(hdz.StampaElenco());break;
                    case 2: Console.WriteLine(string.Join("\n",hdz.OrdinaElencoPerCapacitaCrescente())); break;
                    case 3: Console.WriteLine(hdz.PunteggioMigliore()); break;
                    case 4: Console.WriteLine(hdz.PunteggioPeggiore()); break;
                    case 5: Console.Write("Marca da cercare: ");
                        var hd = hdz.Cerca(Console.ReadLine());
                        if (hd != null)
                            Console.WriteLine(hd);
                        else
                            Console.WriteLine("Hard disk non trovato");
                        break;
                    case 0: stop = true; break;
                    default: Console.WriteLine("Valore inserito non valido");break;
                
                }
            
            }
            while (!stop);

            Console.WriteLine("Programma terminato!");



        }
    }
}
