using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione_risolta
{
    class ResponabileVenditori:Venditore
    {
        public List<Venditore> Venditori { get; set; }

        public void AggiungiVenditore(Venditore venditore)
        {
            Venditori.Add(venditore);
        }

        public Venditore RestituisciVenditore(int index)
        {
            return Venditori[index];
        }

        public void CancellaVenditore(int index)
        {
            Venditori.RemoveAt(index);
        }

        public override double Tredicesima()
        {
            int giorni = 24;//giorni lavorativi considerati nel mese
            double bonus = 0;
            foreach (var v in Venditori) 
                bonus += v.Stipendio / giorni * 15 / 100;

            return 2*Stipendio+bonus;
        }

        public override string ToString()
        {
            return $"{{{nameof(Venditori)}={Venditori}," +
                $" {nameof(Settore)}={Settore.ToString()}," +
                $" {nameof(Nome)}={Nome}," +
                $" {nameof(Cognome)}={Cognome}," +
                $" {nameof(Stipendio)}={Stipendio.ToString()}}}";
        }
    }
}
