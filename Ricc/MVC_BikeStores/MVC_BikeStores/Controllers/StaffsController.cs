using MVC_BikeStores.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_BikeStores.Controllers
{
    public class StaffsController : Controller
    {
        private BikeStoresContext db = new BikeStoresContext();
        // GET: Staffs
        // vista utilizzata per l'elenco dei dipendenti dello store all'interno del dettaglio dello store
        public ActionResult Index()
        {
            var staffs = db.Staffs.OrderBy(x => x.Last_Name).ToList();
            return View(staffs);
        }

        public ActionResult DettaglioDipendente(int id)
        {
            var dettaglioDipendente = db.Staffs.Find(id);
            return View(dettaglioDipendente);
        }
    }
}