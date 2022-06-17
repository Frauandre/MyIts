using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Vuoto.Controllers
{
    public class ProvaController : Controller
    {
        // GET: Prova
        public ActionResult Index()
        {
            ViewBag.Info = "data di oggi: " + DateTime.Now;
            return View();
        }

        public ActionResult Verifica() { 
        
            ViewData["Info"]="Dati di verifica: "+ DateTime.Now;
            return View();
        }
    }
}