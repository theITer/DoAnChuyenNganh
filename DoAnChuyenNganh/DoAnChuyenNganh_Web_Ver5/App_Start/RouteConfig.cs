﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace DoAnChuyenNganh_Web_Ver5
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
              name: "Add cart",
              url: "themgiohang",
              defaults: new { controller = "Cart", action = "AddItem", id = UrlParameter.Optional }
          );

            routes.MapRoute(
             name: "Cart",
             url: "gio-hang",
             defaults: new { controller = "Cart", action = "Index", id = UrlParameter.Optional }
         );
            routes.MapRoute(
              name: "Payment",
              url: "thanh-toan",
              defaults: new { controller = "Cart", action = "Payment", id = UrlParameter.Optional }
          );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );


        }
    }
}
