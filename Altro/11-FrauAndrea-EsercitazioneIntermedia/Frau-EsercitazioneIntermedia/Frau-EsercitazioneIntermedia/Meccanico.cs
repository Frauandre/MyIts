using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frau_EsercitazioneIntermedia
{
    class Meccanico : Persona
    {
        public string Tipologia { get; set; }

        public double Tredicesima()
        {
            double tredicesima;
            tredicesima = Stipendio * 93 / 100;
            return Stipendio + tredicesima;
        }
        public override string ToString()
        {
            return base.ToString()
                + $", Tipologia: {Tipologia}"
                + $",Tredicesima: {Tredicesima()}";
        }
    }
}
