using System.Web.Mvc;
using System.Web.Routing;

namespace CookBook.PL
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute("Default", "{controller}/{action}/{id}/{*catchall}", 
                new { controller = "Home", action = "Index", id = UrlParameter.Optional });
        }
    }
}
