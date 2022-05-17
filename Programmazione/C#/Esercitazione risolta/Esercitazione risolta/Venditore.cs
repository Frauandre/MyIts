using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione_risolta
{
    class Venditore:Persona,ICloneable
    {
        public Settore Settore { get; set; }


        public override double Tredicesima()
        {
            return Stipendio + 91 * Stipendio / 100;
        }

        public override string ToString()
        {
            return base.ToString() + $", Settore: {Settore}"+
                $", Tredicesima: {Tredicesima()}";
        }

        public object Clone()
        {
            return new NotImplementedException();
        }
    }
}
