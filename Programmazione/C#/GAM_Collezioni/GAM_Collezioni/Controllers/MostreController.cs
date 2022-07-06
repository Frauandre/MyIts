using GAM_Collezioni.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GAM_Collezioni.Controllers
{
    public class MostreController : Controller
    {
        private CollezioniContext db = new CollezioniContext();

        // GET: Mostre
        public ActionResult Index(string CercaTitolo, string CercaTecnica, string CercaAutore)
        {

            var mostre = db.Mostre.Include("Autore").Take(10).ToList();

            var ElencoTecniche = db.Mostre.Include("Autore").Select(x => x.Tecnica).Distinct().ToList();
            ViewBag.CercaTecnica = new SelectList(ElencoTecniche);

            var ElencoAutori = db.Mostre.Include("Autore").Select(x => x.Autore).Distinct().ToList();
            ViewBag.CercaAutore = new SelectList(ElencoAutori);


            //Cerca per titolo
            if(!string.IsNullOrEmpty(CercaTitolo))
                mostre=db.Mostre.Include("Autore").Where(t => t.Titolo.ToLower().Contains(CercaTitolo.ToLower()).ToList(); 

            //Cerca per tecnica
            if(!string.IsNullOrEmpty(CercaTecnica))
                mostre=db.Mostre.Include("Autore").Where(t => t.Tecnica.ToLower().Equals(CercaTecnica, StringComparison.OrdinalIgnoreCase)).ToList();
            
             //Cerca per autore
            if(!string.IsNullOrEmpty(CercaAutore))
                mostre=db.Mostre.Include("Autore").Where(t => t.Autore.Nominativo.ToLower().Equals(CercaAutore, StringComparison.OrdinalIgnoreCase)).ToList();

            return View(mostre);
        }

        public ActionResult Dettaglio(int id)
        {
            var mostra = db.Mostre.Find(id);
            return View(mostra);
        }
    }
}