using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Vuoto.Models
{
    public class Prodotto
    {
        //codice, denominazione, descrizione, prezzo, giacenza
        public int Codice { get; set; }
        public string Denominazione { get; set; }
        public string Descrizione { get; set; }
        public double Prezzo { get; set; }
        public int Giacenza { get; set; }
    }
}