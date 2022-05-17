using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione_risolta
{
    class CapoOfficina:Meccanico
    {
        public List<Ordine> Ordine { get; set; }

        public void AggiungeiOrdine(Ordine ordine, int index)
        {
            Ordini.Insert(index, ordine);
        }
        public int NoOrdini()
        {
            return Ordini.Count;
        }

        public override double Tredicesima()
        {
            double bonus = 0;
            foreach (var v in Ordini)
                bonus += o.Totale() * 5 / 100;

            return 2 * Stipendio + bonus;
        }
    }
}
