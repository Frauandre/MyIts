using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frau_EsercitazioneIntermedia
{
    class Prodotto
    {
        public double Codice { get; set; }
        public string Nominativo { get; set; }
        public string Descrizione { get; set; }
        public double Prezzo { get; set; }

        public override string ToString()
        {
            return $"{{{nameof(Codice)}={Codice.ToString()}," +
                $" {nameof(Nominativo)}={Nominativo}," +
                $" {nameof(Descrizione)}={Descrizione}," +
                $" {nameof(Prezzo)}={Prezzo.ToString()}}}";
        }
    }
}
