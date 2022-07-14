using MVC_BikeStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_BikeStore.Controllers
{
    public class ProductsController : Controller
    {
        private BikeStoresContext db = new BikeStoresContext();
        // GET: Products
        public ActionResult Index()
        {
            var products = db.Products.OrderBy(x => x.Product_Name.ToList());
            return View(db.Products.ToList());
        }

        public ActionResult ProductsDetails(int id)
        {
            return View(db.Products.Find(id));
        }
        public ActionResult ElencoProdottiPerMarca(int id)
        {
            var products = db.Products.Where(x => x.Brand_Id == id).OrderBy(x => x.Product_Name).ToList();
            return View("Index", products);
        }
    }
}