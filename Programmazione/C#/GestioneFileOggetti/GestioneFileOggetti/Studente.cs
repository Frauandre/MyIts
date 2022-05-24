using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneFileOggetti
{
    [Serializable]
    class Studente
    {
        public string Matricola { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Corso { get; set; }

        public override string ToString()
        {
            return $"{{{nameof(Matricola)}={Matricola}," +
                $" {nameof(Nome)}={Nome}," +
                $" {nameof(Cognome)}={Cognome}," +
                $" {nameof(Corso)}={Corso}}}";
        }
    }
}
