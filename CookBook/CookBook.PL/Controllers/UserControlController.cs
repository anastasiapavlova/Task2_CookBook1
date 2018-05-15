using System;
using Ninject;
using System.Linq;
using System.Web.Mvc;
using CookBook.PL.Mappers;
using CookBook.BLL.Logging;
using CookBook.BLL.Interfaces;
using CookBook.PL.Util;

namespace CookBook.PL.Controllers
{
    public class UserControlController : Controller
    {
        [Inject]
        public IUserService UserService { get; set; }

        [HttpGet]
        [ClaimsAuthorize]
        [HandleError(View = "_Error")]
        public ActionResult UserControl()
        {
            try
            {
                var users = UserService.GetList().Select(UserViewMapper.ConvertUserModelToUserViewModel).ToList();
                return View("UserControl", users);
            }
            catch (Exception e)
            {
                Logger.InitLogger();
                Logger.Log.Error("Error: " + e);
                return View("_Error");
            }
        }
        
        [HttpPost]
        [ClaimsAuthorize]
        [HandleError(View = "_Error")]
        public ActionResult DeleteUser(Guid id)
        {
            try
            {
                UserService.DeleteItem(id);
                return RedirectToAction("UserControl");
            }
            catch (Exception e)
            {
                Logger.InitLogger();
                Logger.Log.Error("Error: " + e);
                return View("_Error");
            }
        }
    }
}