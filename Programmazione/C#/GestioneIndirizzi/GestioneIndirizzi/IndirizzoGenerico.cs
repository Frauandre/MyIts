using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneIndirizzi
{
    abstract class IndirizzoGenerico
    {
        public abstract string getIndirizzo();

        public override string ToString()
        {
            return getIndirizzo();
        }
    }
}
