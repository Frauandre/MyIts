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
        private ProductsContext db = new ProductsContext();
        // GET: Products
        public ActionResult Index()
        {
            var products = db.Products.OrderBy(x => x.Product_Name.ToList());
            return View(db.Products.ToList());

        }

        public ActionResult Details(int id)
        {
            return View(db.Products.Find(id));
        }
    }
}