using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazzino
{
    class ProdottiBiz
    {
        //classe business Logic Layer
        //Serve per implementare servizi su collezioni di dati

        public List<Prodotto> Elenco { get; set; }
        public ProdottiBiz()
        {
            Elenco = new List<Prodotto>();
        }

        public Prodotto PrezzoMax()
        {
            int pos = 0; //posizione con prezzo massimo
            for (int i = 1; i < Elenco.Count; i++)
                if (Elenco[i].Prezzo > Elenco[pos].Prezzo)
                    pos = i;
            return Elenco[pos];

            /*
            Prodotto prodotto = Elenco[0];
            foreach (var p in Elenco)
                if (p.Prezzo > prodotto.Prezzo)   Con il foreach
                    prodotto = p;
            return prodotto;
            */
        }
    }
}
