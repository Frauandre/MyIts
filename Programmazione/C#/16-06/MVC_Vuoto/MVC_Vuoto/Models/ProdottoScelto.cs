using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Vuoto.Models
{
    public class ProdottoScelto
    {
        public Prodotto Prodotto { get; set; }
        public int Quantita { get; set; }

        public double SubTotale() {
            return Prodotto.Prezzo * Quantita;
        }

        public override string ToString()
        {
            return $"{{{nameof(Prodotto)}={Prodotto}, {nameof(Quantita)}={Quantita.ToString()}, SubTotale={SubTotale().ToString()}}}";
        }
    }
}