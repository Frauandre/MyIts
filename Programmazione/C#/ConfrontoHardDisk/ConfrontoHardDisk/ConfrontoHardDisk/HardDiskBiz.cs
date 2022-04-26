using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfrontoHardDisk
{
    class HardDiskBiz
    {
        public List<HardDisk> Elenco { get; set; }

        public HardDiskBiz() {
            Elenco = new List<HardDisk>();
        }

        public string StampaElenco() {
            return string.Join("\n", Elenco); 
        }

        public List<HardDisk> OrdinaElencoPerCapacitaCrescente()
        {
            List<HardDisk> clone = new List<HardDisk>(Elenco);

            /*
            for (int i = 0; i < Elenco.Count; i++)
                clone.Add(Elenco[i]);
            */

            for (int i = 0; i < clone.Count - 1; i++)
                for (int j = i + 1; j < clone.Count; j++)
                    if (clone[i].Capacita > clone[j].Capacita)
                    {
                        var hd = clone.ElementAt(j);
                        clone.RemoveAt(j);
                        clone.Insert(i, hd);
                        
                    }

            return clone;                    
        }

        public HardDisk PunteggioMigliore() {

            HardDisk hd = Elenco[0];
            for (int i = 1; i < Elenco.Count; i++)
                if (hd.Punteggio() < Elenco[i].Punteggio())
                    hd = Elenco[i];
            return hd;
        }

        public HardDisk PunteggioPeggiore()
        {

            HardDisk hd = Elenco[0];
            for (int i = 1; i < Elenco.Count; i++)
                if (hd.Punteggio() > Elenco[i].Punteggio())
                    hd = Elenco[i];
            return hd;
        }

        public HardDisk Cerca(string marca)
        {            
            foreach (var hd in Elenco)
                if (hd.Marca.Equals(marca))
                    return hd;
            return null;
        }

        public override string ToString()
        {
            return $"{{{nameof(Elenco)}={Elenco}}}";
        }
    }
}
