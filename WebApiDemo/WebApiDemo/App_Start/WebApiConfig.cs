using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace WebApiDemo
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Formatters.Remove(config.Formatters.XmlFormatter);
            // Web API configuration and services

            // Web API routes
            var cros = new EnableCorsAttribute("*", "*", "*");
            config.EnableCors(cros);

            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
