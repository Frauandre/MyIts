using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frau_EsercitazioneIntermedia
{
    abstract class Persona
    {
        public string Nome { get; set; }
        public string Cognome { get; set;}
        public double Stipendio { get; set; }

        public double Tredicesima();

        public override string ToString()
        {
            return $"{nameof(Nome)}={Nome}" +
                $", {nameof(Cognome)}={Cognome}" +
                $", {nameof(Stipendio)}={Stipendio.ToString()}";
        }
        
    }
}
