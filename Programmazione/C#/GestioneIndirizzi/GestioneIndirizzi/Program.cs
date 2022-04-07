using System;

namespace GestioneIndirizzi
{
    class Program
    {

            /*Definire la classe IndirizzoGenerico con il metodo getIndirizzo() che è privo di implementazione.

            Definire la classe IndirizzoEmail come classe derivata da IndirizzoGenerico con l'attributo account. 
            Ridefinire il metodo getIndirizzo() per restituire il valore dell'account.

            Definire la classe IndirizzoWeb come classe derivata da IndirizzoGenerico e che possiede l'attributo URL. 
            Ridefinire il metodo getIndirizzo() per restituire il valore l'URL.

            Definire la classe IndirizzoFisico come classe derivata da IndirizzoGenerico. 
            IndirizzoFisico possiede i seguenti attributi: via, numero, cap, città, provincia, regione, ripartizione geografica. 
            Ridefinire il metodo getIndirizzo per far restituire in un'unica stringa  via, numero cap - città (provincia), regione, ripartizione geografica.

            */
        static void Main(string[] args)
        {
            IndirizzoGenerico[] Elenco =

                {
                new IndirizzoEmail { Account="info@its-ictpiemonte.it"},
                new IndirizzoWeb { Url="https://www.its-ictpiemonte.it"},
                new IndirizzoFisico
                {
                    Via="via J.Durandi", Numero="10A", Cap="10143",
                    Citta="Torino", Provincia="TO", Regione="Piemonte",
                    RipartizioneGeografica="Nord-Ovest"
                }
                };

                foreach (var i in Elenco)
                Console.WriteLine(i);
             
            
        }
    }
}
