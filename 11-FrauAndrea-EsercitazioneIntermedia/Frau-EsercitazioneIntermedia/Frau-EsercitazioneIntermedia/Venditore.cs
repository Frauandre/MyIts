using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frau_EsercitazioneIntermedia
{
    class Venditore : Persona
    {
        public string Settore {get;set;}
    
    public double Tredicesima()
    {
        double tredicesima;
        tredicesima = Stipendio * 91 / 100;
        return Stipendio + tredicesima;
    }
    public override string ToString()
    {
        return base.ToString()
            + $", Settore: {Settore}"
            + $",Tredicesima: {Tredicesima()}";
    }



}
