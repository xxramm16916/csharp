using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using Bootstrap.App_Start;
using Bootstrap.Handlers;

namespace Bootstrap
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            //apiController date = new apiController();
            //var stringJ = date.Get();
            //System.Console.WriteLine(stringJ);
            //System.Console.WriteLine("-----------------------------------------------------------------------------------------------------");
        }
    }
}