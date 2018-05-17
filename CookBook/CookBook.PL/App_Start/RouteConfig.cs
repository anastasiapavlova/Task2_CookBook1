using System.Web.Mvc;
using System.Web.Routing;

namespace CookBook.PL
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapRoute("Home","{controller}/{action}/{id}",MVC.Home.Index(),new { id = UrlParameter.Optional });
        }
    }
}
