using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using NW.LondonStock.Core;
using NW.LondonStock.Core.Interfaces;
using NW.LondonStock.Infrastructure;
using SimpleInjector;
using SimpleInjector.Integration.WebApi;

namespace NW.LondonStockAPI
{
    public static class WebApiConfig
    {
        /// <summary>
        /// This method used to register all configs on application start
        /// </summary>
        /// <param name="config"></param>
        public static void Register(HttpConfiguration config)
        {
            // Dependency Registration for the project
            RegisterDependencies(config);

            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            //config.Routes.MapHttpRoute(
            //    name: "DefaultApi",
            //    routeTemplate: "api/{controller}/{id}",
            //    defaults: new { id = RouteParameter.Optional }
            //);
        }

        /// <summary>
        /// Register dependencies for the projects
        /// </summary>
        /// <param name="config"></param>
        private static void RegisterDependencies(HttpConfiguration config)
        {
            var container = new Container();
            container.Register<ILondonStockService, LondonStockService>();
            container.Register<ILondonStockRepository, LondonStockRepository>();
            container.Options.ResolveUnregisteredConcreteTypes = true;
            config.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(container);

        }
    }
}
