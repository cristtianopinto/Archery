﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Archery
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapMvcAttributeRoutes();//IMPORTANTE PRA USAR OS [ROUTE("<rota>")]
                                           ///*
                                           ///
            routes.MapRoute(
                 name: "DetailTournoiRoute",
                 url: "details-tournois{nom}",
                 defaults: new { controller = "Home", action = "Details" }
             );
            routes.MapRoute(
                name: "AboutRoute",
                url: "a-propos",
                defaults: new { controller = "Home", action = "About" }
            );
           
            routes.MapRoute(
               name: "Default",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
           );

            //*/



            /*
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );*/
        }
    }
}
