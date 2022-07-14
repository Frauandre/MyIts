using MVC_BikeStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_BikeStore.Controllers
{
    public class StaffsController : Controller
    {
        // GET: Staffs
        private BikeStoresContext db = new BikeStoresContext();
        // vista utilizzata per l'elenco dei dipendenti dello store all'interno del dettaglio dello store
        public ActionResult Index()
        {
            var staffs = db.Staffs.OrderBy(x => x.Last_Name).ToList();
            return View(staffs);
        }

        public ActionResult StaffDetails(int id)
        {
            var dettaglioDipendenti = db.Staffs.Find(id);
            return View(dettaglioDipendenti);
        }
    }
}