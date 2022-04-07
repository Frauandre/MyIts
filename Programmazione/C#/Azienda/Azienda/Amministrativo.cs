using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azienda
{   enum Mansione
    {
        DIRETTORE,CONTABILE,RISORSE_UMANE
    }

    class Amministrativo:Dipendente
    {
        public Mansione Mansione { get; set; }

        public override double Stipendio()
        {
            double bonus = 0;
            switch (Mansione) {
                case Mansione.DIRETTORE:bonus = 300.00;break;
                case Mansione.CONTABILE:bonus = 180.00;break;
                case Mansione.RISORSE_UMANE:bonus = 150.00;break;
            }

            return PagaOraria * OreLavorate + bonus;
        }

        public override string ToString()
        {
            return base.ToString()+$", Mansione: {Mansione}";
        }
    }

    
}
