using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace AppRoute66
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            
            routes.MapRoute(
                name: "Categori Noticia",
                url: "noticia/{categoria}/{titulo}--{NoticiaId}",
                defaults: new { controller = "Home", action = "MostrarNoticia", id = UrlParameter.Optional },
                namespaces: new[] { "AppRoute66.controllers" }
                );
            routes.MapRoute(
                name:"Categori Especifica",
                url:"noticia/{categoria}/",
                defaults: new {controller = "Home", action="MostrarCategoria" },
                namespaces: new[] { "AppRoute66.controllers" }
                );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] {"AppRoute66.controllers"}
            );
        }
    }
}
