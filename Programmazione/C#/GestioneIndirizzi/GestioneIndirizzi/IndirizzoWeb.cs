using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneIndirizzi
{
    class IndirizzoWeb : IndirizzoGenerico
    {
        public string Url { get; set; }

        public override string ToString()
        {
            return $"Url: {Url}";
        }
    }
}
