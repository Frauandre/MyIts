using GAM_Collezioni.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GAM_Collezioni.Controllers
{
    public class AutoriController : Controller
    {
        private CollezioniContext db = new CollezioniContext();
        // GET: Autori
        public ActionResult Index()
        {
            return View(db.Autori.ToList());
        }

         public ActionResult Index(string CercaAutore)
        {
            var ricerca = db.Autori.ToList();

            if(!string.IsNullOrEmpty(CercaAutore))
                ricerca = db.Autori.Where(a => a.Nominativo.ToLower().Contains(CercaAutore)).ToList();
              return View(ricerca);
        }   

        public ActionResult ElencoMostrePerAutore(int id)
        {
            ViewBag.Autore = db.Autori.Find(id).Nominativo;
            var elenco = db.Mostre.Where(a => a.Autore.Id == id).ToList();
            return View(elenco);
        }
    }
}