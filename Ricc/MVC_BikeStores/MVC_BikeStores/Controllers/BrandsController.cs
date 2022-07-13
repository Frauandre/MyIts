using MVC_BikeStores.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_BikeStores.Controllers
{
    public class BrandsController : Controller
    {

        private BikeStoresContext db = new BikeStoresContext();

        // GET: Brands
        public ActionResult Index()
        {
            var brands = db.Brands.OrderBy(x => x.Brand_Name).ToList();
            return View(brands);
        }
    }
}