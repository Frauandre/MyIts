using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnagraficaStudenti
{
    class StudentiBiz
    {
        public List<Studente> Elenco { get; set; }

        private string path = @"C:\Files\Studenti.csv";

        public StudentiBiz()
        {
            Elenco = MyLibrary.LeggiFileStudenti(path);
        }
        public void Nuovo(Studente studente)
        {
            Elenco.Add(studente);
            MyLibrary.ScriviFileStudenti(path, Elenco);
        }

        public void SalvaTuttoeChiudi()
        {
            MyLibrary.ScriviFileStudenti(path, Elenco);
        }
    }
}
