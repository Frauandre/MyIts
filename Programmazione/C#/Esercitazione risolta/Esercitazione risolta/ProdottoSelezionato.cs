using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione_risolta
{
    class ProdottoSelezionato:Prodotto
    {
        public int Quantita { get; set; }
        public double SubTotale()
        {
            return Prezzo * Quantita;
        }
        public string Stampa()
        {
            return base.ToString()
                + $"{Codice} - {Denominazione} prezzo: {Prezzo} quantità: {Quantita} subtotale{SubTotale}";
        }
    }
}
