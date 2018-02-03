using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SRA_MVC.Controllers
{
    public class GenealogyController : Controller
    {
        // GET: Genealogy
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Ancestors()
        {
            return View();
        }


    }
}