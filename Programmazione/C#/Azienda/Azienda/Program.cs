using System;

namespace Azienda
{
    class Program
    {
        static void Main(string[] args)
        {
            //creare una piccola base dati
            var a1 = new Amministrativo
            {
                Nome = "Piero",
                Cognome = "Del Piero",
                OreLavorate = 120,
                PagaOraria = 30.15,
                Mansione = Mansione.DIRETTORE
            };

            var a2 = new Amministrativo
            {
                Nome = "Daniela",
                Cognome = "Cossato",
                OreLavorate = 80,
                PagaOraria = 40.15,
                Mansione = Mansione.CONTABILE
            };

            var a3 = new Amministrativo
            {
                Nome = "Pino",
                Cognome = "Delillo",
                OreLavorate = 150,
                PagaOraria = 28.15,
                Mansione = Mansione.RISORSE_UMANE
            };

            var o1 = new Operaio
            {
                Nome = "Roberto",
                Cognome = "Del Pino",
                OreLavorate = 100,
                PagaOraria = 30.25,
                Settore = Settore.INSTALLATORE
            };

            var o2 = new Operaio
            {
                Nome = "Ugo",
                Cognome = "De Zan",
                OreLavorate = 180,
                PagaOraria = 38.25,
                Settore = Settore.MANUTENTORE
            };

            var os1 = new OperaioSpecializzato
            {
                Nome = "Carlo",
                Cognome = "Piano",
                OreLavorate = 110,
                PagaOraria = 31.25,
                Settore = Settore.INSTALLATORE,
                NumeroMissioni=2,
                IndennitaMissione=500.00
            };

            var os2 = new OperaioSpecializzato
            {
                Nome = "Bartolo",
                Cognome = "De Gan",
                OreLavorate = 120,
                PagaOraria = 32.25,
                Settore = Settore.MANUTENTORE,
                NumeroMissioni = 3,
                IndennitaMissione = 400.00
            };

            Dipendente[] elenco = {a1,a2,a3,o1,o2,os1,os2};

            //stampa dell'elenco dei dipendneti
            Console.WriteLine("Elenco dipendenti");
            foreach (var d in elenco)
                Console.WriteLine(d);

            Console.WriteLine();

            //stampa dell'elenco dei dipendneti
            Console.WriteLine("Elenco Amministrativi");
            foreach (var d in elenco)
                if(d is Amministrativo) //polimorfismo - una forma
                    Console.WriteLine(d);

            Console.WriteLine();

            //stampa dell'elenco dei dipendneti
            Console.WriteLine("Elenco Operai");
            foreach (var d in elenco)
                if (d is Operaio) //polimorfismo - una forma
                    Console.WriteLine(d);

            Console.WriteLine();

            //stampa dell'elenco dei dipendneti
            Console.WriteLine("Elenco Operai Specializzati");
            foreach (var d in elenco)
                if (d is OperaioSpecializzato) //polimorfismo - una forma
                    Console.WriteLine(d);

            Console.WriteLine();

            //stampa dell'elenco dei dipendneti
            Console.WriteLine("Elenco Operai ma non Specializzati");
            foreach (var d in elenco)
                if (d is Operaio && d is not OperaioSpecializzato) //polimorfismo - una forma
                    Console.WriteLine(d);

            Console.WriteLine();

            //stampa dell'elenco dei dipendneti con mansione Direttore
            Console.WriteLine("Elenco Operai Specializzati");
            foreach (var d in elenco)
            {
                Amministrativo a = null;
                if (d is Amministrativo)
                    a = (Amministrativo)d;
                if(a!=null && a.Mansione==Mansione.DIRETTORE)
                    Console.WriteLine(a);
            }
                 
                    
        }
    }
}
