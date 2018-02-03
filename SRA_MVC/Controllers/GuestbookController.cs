using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SRA_MVC.Models;

namespace SRA_MVC.Controllers
{

    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.Entity;
    using System.Linq;
    using System.Net;
    using System.Net.Sockets;
    using System.Web;
    using System.Web.Mvc;

    namespace SRA_MVC.Controllers
    {
        public class GuestbookController : Controller
        {
            private SRAEntities db = new SRAEntities();

            // GET: Messages
            public ActionResult Index()
            {
                ViewData.Model = db.ra_GetAllMessages().ToList();
                ViewBag.Message = "Your messages page.";
                return View();
            }

            // GET: Messages/Details/5
            public ActionResult Details(int id)
            {

                ViewData.Model = db.ra_GetMessageThread(id).ToList();
                ViewBag.Message = "Your details page.";
                return View();
            }

            // GET: Messages/Create
            public ActionResult Create()
            {
                return View();
            }

            [AcceptVerbs(HttpVerbs.Post)]
            public ActionResult Create(FormCollection form)
            {
                return View();
            }


            protected override void Dispose(bool disposing)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                base.Dispose(disposing);
            }

            public static string GetLocalIPAddress()
            {
                var host = Dns.GetHostEntry(Dns.GetHostName());
                foreach (var ip in host.AddressList)
                {
                    if (ip.AddressFamily == AddressFamily.InterNetwork)
                    {
                        return ip.ToString();
                    }
                }
                throw new Exception("No network adapters with an IPv4 address in the system!");
            }

        }
    }

}