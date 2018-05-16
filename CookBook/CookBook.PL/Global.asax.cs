using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using CookBook.PL.App_Start;
using System.Web.Optimization;

namespace CookBook.PL
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            App_Start.ResolverConfig.Configure();
        }
        
    }
}