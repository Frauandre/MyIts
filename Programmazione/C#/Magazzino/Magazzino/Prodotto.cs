using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazzino
{
    class Prodotto
    {
        public int Codice { get; set; }
        public string Nome { get; set; }
        public string Descrizione { get; set; }
        public double Prezzo { get; set; }
        public int Giacenza { get; set; }

        public bool InScorta()
        {
            return giacenza >=
        }
        public override string ToString()
        {
            return $"{{{nameof(codice)}={codice.ToString()}," +
                $" {nameof(nome)}={nome}, " +
                $"{nameof(descrizione)}={descrizione}," +
                $" {nameof(prezzo)}={prezzo.ToString()}," +
                $" {nameof(giacenza)}={giacenza.ToString()}}}";
        }
    }
}
