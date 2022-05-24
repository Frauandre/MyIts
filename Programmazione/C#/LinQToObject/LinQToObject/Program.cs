using System;
using System.Collections.Generic;
using System.Linq;

namespace LinQToObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tinq To Object");

            var elenco = new List<Cliente> {
                new Cliente {CodiceFiscale = "VRDFGJHL946R4", Nome = "Fabio", Cognome = "Verdi"},
                new Cliente {CodiceFiscale = "MMDMTDGGC435H6", Nome = "Mario", Cognome = "Bianco"},
                new Cliente {CodiceFiscale = "LPVBNMJJHLFRS77", Nome = "Ilaria", Cognome = "Manina"},
            };

            var q1 = from tutti in elenco select tutti;  
            Console.WriteLine("Tutti gli oggetti");
            Console.WriteLine(string.Join("\n", q1));

        }
    }
}
