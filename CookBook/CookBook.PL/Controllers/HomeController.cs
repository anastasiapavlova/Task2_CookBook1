using System;
using System.Web.Mvc;
using CookBook.BLL.Logging;
using CookBook.PL.Util;

namespace CookBook.PL.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [HandleError(View = "_Error")]
        public ActionResult Index()
        {
            try
            {
                return View("Index");
            }
            catch (Exception e)
            {
                Logger.InitLogger();
                Logger.Log.Error("Error: " + e);
                return View("_Error");
            }
        }

        public ActionResult ErrorAc()
        {
            return View("_Error");
        }
    }
}