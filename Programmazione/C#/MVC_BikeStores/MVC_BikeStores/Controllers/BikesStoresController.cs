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
        public ActionResult Index(string CercaMarca)
        {

            //Cerca per Marca
            if (!string.IsNullOrEmpty(CercaMarca))
                CercaMarca = db.products.Include("").Where(t => t.brands.ToLower().Contains(CercaMarca.ToLower()).ToList();
            return View(db.products.ToList());
        }

        //creo una view per vedere tutte le informazioni dei prodotti
        public ActionResult Details(int id)
        {
            return View(db.products.Find(id));
        }

    }
}