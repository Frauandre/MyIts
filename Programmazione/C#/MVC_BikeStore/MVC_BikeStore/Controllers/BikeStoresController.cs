using MVC_BikeStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_BikeStore.Controllers
{
    public class BikeStoresController : Controller
    {
        private BikeStoresContext db = new BikeStoresContext();
        // GET: BikeStores
        public ActionResult Index()
        {          
            var brands = db.Brands.OrderBy(x => x.Brand_Name.ToList());
            return View(db.Brands.ToList());
            
        }

        public ActionResult Details(int id)
        {
            return View(db.Brands.Find(id));
        }
        
    }
}