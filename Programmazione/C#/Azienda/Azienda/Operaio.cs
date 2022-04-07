using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azienda
{
    class Operaio : Dipendente
    {
        public Settore Settore { get; set; }

        public override double Stipendio()
        {
            double bonus = 0;
            switch (Settore)
            {
                case Settore.INSTALLATORE:bonus = 150.00;break;
                case Settore.MANUTENTORE:bonus = 220.00;break;
            }

            return OreLavorate * PagaOraria + bonus;
        }

        public override string ToString()
        {
            return base.ToString()+$", Settore={Settore}";
        }
    }
}
