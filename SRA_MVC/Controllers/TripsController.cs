using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml;
using SRA_MVC.Models;

namespace SRA_MVC.Controllers
{
    public class TripsController : Controller
    {
        // GET: Trips
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Photos(string year, string trip, int id = 1)
        {
            List<Photos> photos = new List<Photos>();
            XmlDocument doc = new XmlDocument();
            switch (year)
            {
                case "2001":
                    switch (trip)
                    {
                        case "santa-catalina-mountains-az":
                            doc.Load(Server.MapPath("~/App_Data/santa-catalina-mountains-az.xml"));
                            ViewBag.Title = "Santa Catalina Mountains, AZ";
                            break;
                        case "mount-whitney-ca":
                            doc.Load(Server.MapPath("~/App_Data/mount-whitney-ca.xml"));
                            ViewBag.Title = "Mount Whitney, CA";
                            break;

                    }
                    break;
                default:
                    break;
            }
            foreach (XmlNode node in doc.SelectNodes("/photos/photo"))
            {
                photos.Add(new Photos
                {
                    PhotoId = int.Parse(node["id"].InnerText),
                    File = node["file"].InnerText,
                    Caption = node["caption"].InnerText,
                    TCaption = node["tcaption"].InnerText,
                    Date = node["date"].InnerText,
                    TFile = node["tfile"].InnerText
                });
            }
            ViewBag.PhotoCount = photos.Count;
            return View(photos.Where(p => p.PhotoId == id));
        }

    }

}