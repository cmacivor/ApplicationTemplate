using DataTier.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using DataTier;
using Unity;
using Unity.Lifetime;

namespace SailboatApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            //Unity Configuration
            var container = new UnityContainer();
            container.RegisterType<ISailboatDbRepository, DapperSailboatRepository>(new HierarchicalLifetimeManager());
            config.DependencyResolver = new UnityResolver(container);
        }
    }
}
