using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _3hite.Models.Siniflar;

namespace _3hite.Controllers
{
    public class ServicesController : Controller
    {
        // GET: Services
        Context c = new Context();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Web()
        {
            var urn = c.Products.ToList();
            return View(urn);
        }

        public ActionResult Detay(int id)
        {
            var model = c.Products.Where(x=>x.ProductID==id).ToList();
            ViewBag.dgr = model;
            return View(model);
        }
        [HttpGet]
        public ActionResult Order(int id)
        {
            ViewBag.dgr = id;

            return View();
         
        }
        [HttpPost]
        public ActionResult Order(Order p)
        {
            c.Orders.Add(p);
            c.SaveChanges();  
            return View();
        }

        public ActionResult Otomasyon()
        {
            var urn = c.Otomasyons.ToList();
            return View(urn);
        }
        public ActionResult Logo()
        {
            var urn = c.Logos.ToList();
            return View(urn);
        }


    }
}