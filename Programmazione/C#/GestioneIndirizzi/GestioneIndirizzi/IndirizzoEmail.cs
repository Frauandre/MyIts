using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneIndirizzi
{
    class IndirizzoEmail : IndirizzoGenerico
    {
        public string Account { get; set; }

        public override string getIndirizzo()
        {
            return $"Account: {Account}";
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
