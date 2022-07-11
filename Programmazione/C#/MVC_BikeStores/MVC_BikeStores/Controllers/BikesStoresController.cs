using MVC_BikeStores.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MVC_BikeStores.Controllers
{
    public class BikesStoresController : Controller
    {
        //Connessione al Database
        private BikeStoresEntities db = new BikeStoresEntities();

        // GET: BikesStores

        //Creo una view in modo tale da visualizzare l'elenco delle bici
        public ActionResult Index(string cercaBrand)
        {
            var products = db.products.ToList();

            var brands = db.brands.Select(x => x.brand_name == cercaBrand).ToList();
            ViewBag.cercaBrand = new SelectList(brands);
            
            //Cerca per Marca
            if (!string.IsNullOrEmpty(cercaBrand))
                products = db.products.Where(x => x.brands.brand_name==cercaBrand.ToLower()).ToList();
            return View(db.products.ToList());
        }

        //creo una view per vedere tutte le informazioni dei prodotti
        public ActionResult Details(int id)
        {
            return View(db.products.Find(id));
        }

    }
}