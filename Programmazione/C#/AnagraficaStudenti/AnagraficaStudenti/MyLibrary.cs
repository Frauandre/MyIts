using System;
using System.Collections.Generic;
using System.IO
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnagraficaStudenti
{
    class MyLibrary
    {
        public static List<Studente> LeggiFileStudenti(string path)
        {
            var elenco = new List<Studente>();
            StreamReader file = new StreamReader(path);
            while (!file.EndOfStream)
            {
                string row = file.ReadLine();
                string[] words = row.Split(';');
                elenco.Add(new Studente
                {
                    Matricola = Convert.ToInt32(words[0]),
                    Nome = words[1],
                    Cognome = words[2],
                    Email = words[3],
                    Classe = words[4]
                });

                file.Close();
                return elenco;
            }

        public static bool ScriviFileStudenti(string path,List<Studente> studenti)
        {
                string txt = "Matricola;Nome;Cognome;Email;Classe\n";

                foreach (var s in studenti)
                    txt += "\n" + s.StampaCSV();

                    StreamWriter file = new StreamWriter(path);
                
                file.Write(txt);

                file.Close();

                return true;
        }
        }
    }
}
