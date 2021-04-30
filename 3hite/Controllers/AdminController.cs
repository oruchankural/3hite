using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _3hite.Models.Siniflar;

namespace _3hite.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();
        public ActionResult Index()
        {
            var model = c.Orders.ToList();
            return View(model);
        }
    }
}