using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione_risolta
{
    sealed class Ordine
    {
        public int IdOrdine { get; set; }
        public DateTime Data { get; set; }
        public Venditore Venditore { get; set; }
        public List<Prodotto> ElencoProdotti { get; set; }
        public int NoProdotti()
        {
            return ElencoProdotti.Count;
        }
        public double Totale()
        {
            double totale = 0;
            foreach (var p in ElencoProdotti)
                totale += p.Prezzo;
            return totale;
        }
        public string Scontrino()
        {
            string txt = "";
            txt += $"N. scontrino: {IdOrdine}" +
                $"\nData: {Data}" +
                $"\nVenditore: {Venditore.Cognome}";

        }
    }
}
