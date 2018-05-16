using Owin;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;

[assembly: OwinStartup(typeof(CookBook.PL.App_Start.Startup))]
namespace CookBook.PL.App_Start
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = "ApplicationCookie",
                LoginPath = new PathString("/Authorization/Login"),
            });
        }
    }
}