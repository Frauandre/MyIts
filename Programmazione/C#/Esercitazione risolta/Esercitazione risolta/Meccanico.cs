using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione_risolta
{
    class Meccanico:Persona
    {
        public Tipologia Tipologia { get; set; }

        public override double Tredicesima()
        {
           return Stipendio+93*Stipendio/100
        }
    }
}
