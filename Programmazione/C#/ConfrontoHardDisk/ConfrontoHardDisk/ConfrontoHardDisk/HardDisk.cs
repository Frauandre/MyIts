using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfrontoHardDisk
{
    class HardDisk
    {
        public string Marca { get; set; }
        public int Velocita { get; set; }
        public int Tempo { get; set; }
        public int Capacita { get; set; }

        public int Punteggio(){
            return Velocita - (200 * Tempo) + (Capacita * 500);
        }

        public override string ToString()
        {
            return $"{{{nameof(Marca)}={Marca}" +
                $", {nameof(Velocita)}={Velocita.ToString()}" +
                $", {nameof(Tempo)}={Tempo.ToString()}" +
                $", {nameof(Capacita)}={Capacita.ToString()}" +
                $", Punteggio={Punteggio()}}}";
        }
    }
}
