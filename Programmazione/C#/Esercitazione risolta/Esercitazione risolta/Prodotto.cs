using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione_risolta
{
    class Prodotto
    {
        public int Codice { get; set; }
        public string Denominazione { get; set; }
        public string Descrizione { get; set; }
        public double Prezzo { get; set; }

        public override string ToString()
        {
            return $"{{{nameof(Codice)}={Codice.ToString()}," +
                $" {nameof(Denominazione)}={Denominazione}," +
                $" {nameof(Descrizione)}={Descrizione}," +
                $" {nameof(Prezzo)}={Prezzo.ToString()}}}";
        }
    }
}
