using MVC_BikeStores.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_BikeStores.Controllers
{
    public class ProductsController : Controller
    {
        private BikeStoresContext db = new BikeStoresContext();

        // GET: Products
        public ActionResult Index()
        {
            var products = db.Products.OrderBy(x => x.Product_Name).ToList();
            return View(products);
        }

        public ActionResult ProductDetails(int id)
        {
            var product = db.Products.Find(id);
            return View(product);
        }

        public ActionResult ElencoProdottiPerMarca(int id)
        {
            var products = db.Products.Where(x => x.Brand_Id == id).OrderBy(x => x.Product_Name).ToList();
            return View("Index", products);
        }
    }
}