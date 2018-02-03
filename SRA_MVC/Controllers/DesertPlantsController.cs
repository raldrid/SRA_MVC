using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SRA_MVC.Controllers
{
    public class DesertPlantsController : Controller
    {
        // GET: DesertPlants
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Cacti()
        {
            return View();
        }

        public ActionResult Greenhouse()
        {
            return View();
        }


    }
}