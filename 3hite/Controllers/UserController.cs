using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _3hite.Models.Siniflar;

namespace _3hite.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        Context c = new Context();
        public ActionResult Index()
        {
            var degerler = c.Users.ToList();
            return View(degerler);
        }

    }
}