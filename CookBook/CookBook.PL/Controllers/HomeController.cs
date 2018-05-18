using System;
using System.Web.Mvc;
using CookBook.BLL.Logging;

namespace CookBook.PL.Controllers
{
    public partial class HomeController : Controller
    {
        [HttpGet]
        [HandleError(View = "_Error")]
        public virtual ActionResult Index()
        {
            try
            {
                return View(Views.Index);
            }
            catch (Exception e)
            {
                Logger.InitLogger();
                Logger.Log.Error("Error: " + e);
                return View(MVC.Home.ErrorAc());
            }
        }

        [HttpGet]
        public virtual ActionResult ErrorAc()
        {
            return View("_Error");
        }
    }
}