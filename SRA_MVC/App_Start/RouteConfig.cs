using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SRA_MVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                    name: "Trips",
                    url: "trips/{year}/{trip}/Photos/{*id}",
                    defaults: new {controller="Trips", action="Photos"}
            );


            routes.MapRoute(
                       name: "Links",
                        url: "Links",
                   defaults: new { controller = "Home", action = "Links" }
            );

            routes.MapRoute(
                        name: "Biography",
                         url: "Biography",
                    defaults: new { controller = "Home", action = "Biography" }
            );

            routes.MapRoute(
                        name: "Interests",
                         url: "Interests",
                    defaults: new { controller = "Home", action = "Interests" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
