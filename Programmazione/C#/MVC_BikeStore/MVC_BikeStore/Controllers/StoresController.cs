using MVC_BikeStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_BikeStore.Controllers
{
    public class StoresController : Controller
    {
        private BikeStoresContext db = new BikeStoresContext();

        // GET: Stores
        public ActionResult Index()
        {
            var stores = db.Stores.OrderBy(x => x.Store_Name).ToList();
            return View(stores);
        }

        public ActionResult StoresDetails(int id)
        {
            var stores = db.Stores.Find(id);
            return View(stores);
        }
    }
}