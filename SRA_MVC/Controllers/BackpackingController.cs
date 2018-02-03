using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SRA_MVC.Controllers
{
    public class BackpackingController : Controller
    {
        // GET: Backpacking
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Checklist()
        {
            return View();
        }

        public ActionResult Trips()
        {
            return View();
        }

    }
}