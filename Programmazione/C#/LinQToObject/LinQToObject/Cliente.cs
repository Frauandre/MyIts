using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQToObject
{
    class Cliente
    {
        public string CodiceFiscale { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }

        public override string ToString()
        {
            return $"{{{nameof(CodiceFiscale)}={CodiceFiscale}," +
                $" {nameof(Nome)}={Nome}," +
                $" {nameof(Cognome)}={Cognome}}}";
        }
    }
}
