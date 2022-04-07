using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneIndirizzi
{
    class IndirizzoFisico : IndirizzoGenerico
    {
        public string Via { get; set; }
        public string Numero { get; set; }
        public string Cap { get; set; }
        public string Citta { get; set; }
        public string Provincia { get; set; }
        public string Regione { get; set; }
        public string RipartizioneGeografica { get; set; }

        public override string getIndirizzo()
        {
            return $"{Via}, " +
                $"{Numero}, " +
                $"{Cap}, " +
                $"{Citta}, " +
                $"{Provincia}, " +
                $"{Regione}, " +
                $"{RipartizioneGeografica}";
        }
    }
}
