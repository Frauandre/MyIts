using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solidi
{
   abstract class Solido
    {
        public double PesoSpecifico { get; set; }

        public Solido(double pesoSpecifico)
        {
            PesoSpecifico = pesoSpecifico;
        }

        public double Peso() {
            return PesoSpecifico * Volume();
        }

        public abstract double Volume();

        public override string ToString()
        {
            return $"{nameof(PesoSpecifico)}={PesoSpecifico.ToString()}" +
                $", Peso={Peso()}" +
                $", Volume={Volume()}";
        }
    }
}
