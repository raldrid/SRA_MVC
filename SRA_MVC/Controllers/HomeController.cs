using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SRA_MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Interests()
        {
            ViewBag.Message = "Your Interests page.";

            return View();
        }

        public ActionResult Biography()
        {
            ViewBag.Message = "Your Biography page.";

            return View();
        }

        public ActionResult Links()
        {
            ViewBag.Message = "Your Links page.";

            return View();
        }


    }
}