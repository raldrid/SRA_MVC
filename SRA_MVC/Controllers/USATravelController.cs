using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SRA_MVC.Controllers
{
    public class USATravelController : Controller
    {
        // GET: USATravel
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult WelcomeSigns()
        {
            return View();
        }
        public ActionResult Trips()
        {
            return View();
        }

    }
}