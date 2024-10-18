using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Geowebapi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();


            //Route1:invoke point with spesefic id from list with controller and action name
            config.Routes.MapHttpRoute(
                name: "Api1",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            //Route2:invoke distance between interest point and point with specefic id with controller and action name
            config.Routes.MapHttpRoute(
                name: "Api2",
                routeTemplate: "api/{controller}/{action}/{x}/{y}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            //Route3:invoke closest id  with controller and action name
            config.Routes.MapHttpRoute(
                name: "Api3",
                routeTemplate: "api/{controller}/{x}/{y}",
                defaults: new { action = "GetClosestPoint", x = RouteParameter.Optional, y = RouteParameter.Optional }
            );

            var appXMLType = config.Formatters.XmlFormatter.SupportedMediaTypes.FirstOrDefault(t => t.MediaType == "application/xml");
            config.Formatters.XmlFormatter.SupportedMediaTypes.Remove(appXMLType);
        }
    }
}