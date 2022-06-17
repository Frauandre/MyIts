using MVC_Vuoto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Vuoto.Controllers
{
    public class ProdottiController : Controller
    {
        // GET: Prodotti
        public ActionResult Index()
        {
            var prodotto = new Prodotto { Codice=1, Denominazione="prodotto 1", Descrizione="Descrizione", Prezzo=12,Giacenza=100 };
            return View(prodotto);
        }

        public ActionResult VerificaProdotto()
        {

            var prodotto = new ProdottoScelto { Prodotto= new Prodotto { Codice = 1, Denominazione = "prodotto 1", Descrizione = "Descrizione", Prezzo = 12, Giacenza = 100 },Quantita=12 };
            return View(prodotto);
        }
    }
}