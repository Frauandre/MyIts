using System;
using System.IO;

namespace GestioneFileTesto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gestione File di Testo");

            //file di testo
            string path = @"C:\files\testo.txt";

            //accesso su file di testo
            StreamWriter sw = new StreamWriter(path);

            string msg = DateTime.Now.ToString();

            //scrittura su file di testo
            sw.WriteLine(msg);

            sw.Flush(); //salva tutto

            sw.Close();

            Console.WriteLine("Operazione completata con successo");

            //lettura file di testo
            StreamReader sr = new StreamReader(path);

            string testo="";

            //legge tutte le righe fino alla fine
            while (!sr.EndOfStream)
                testo += sr.ReadLine();

            sr.Close();
            Console.WriteLine("Testo recuperato:" + testo);
        }
    }
}
