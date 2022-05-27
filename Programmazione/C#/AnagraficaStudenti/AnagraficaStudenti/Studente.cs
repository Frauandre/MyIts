using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnagraficaStudenti
{
    class Studente
    {
        public int Matricola { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Email { get; set; }
        public string Classe { get; set; }
        public string StampaCSV()
        {
            return $"{Matricola};{Nome};{Cognome};{Email};{Classe}";
        }

        public override string ToString()
        {
            return $"{{{nameof(Matricola)}={Matricola.ToString()}," +
                $" {nameof(Nome)}={Nome}," +
                $" {nameof(Cognome)}={Cognome}," +
                $" {nameof(Email)}={Email}," +
                $" {nameof(Classe)}={Classe}}}";
        }
    }
}
