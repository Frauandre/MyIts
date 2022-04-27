using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frau_EsercitazioneIntermedia
{
    class ResponsabileVenditori:Venditore
    {
        public List<Venditore> Venditori { get; set; }
        public void AggVenditore(Venditore venditore)
        {
            Venditori.Add(venditore);
        }
        public Venditore RexVenditore(int index)
        {
            Venditore x = null;
            int i = 0;
            foreach (var Venditore in Venditori)
            {
                if (i == index) x = Venditore;
                else i++;
            }
        }

    }
}
