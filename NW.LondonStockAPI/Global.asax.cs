using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using AutoMapper;
using NW.LondonStockAPI.App_Start;

namespace NW.LondonStockAPI
{
    /// <inheritdoc />
    /// <summary>
    /// Used for application level events
    /// </summary>
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //Initialize Mapper
            Mapper.Initialize(c => c.AddProfile<MappingProfile>());
            

            //Register Web API config
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
