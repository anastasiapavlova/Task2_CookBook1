using Ninject;
using System.Linq;
using System.Web.Mvc;
using CookBook.PL.Models;
using CookBook.BLL.Enums;
using CookBook.BLL.Models;
using System.Web.Security;
using CookBook.BLL.Interfaces;

namespace CookBook.PL.Controllers
{
    public class AuthorizationController : Controller
    {
        [Inject]
        public IUserService UserService { get; set; }

        public ActionResult Login()
        {
            return View("Authorization");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = UserService.GetList()?.Where(x => x.Login == model.Name && x.Password == model.Password).FirstOrDefault();

                if (user != null)
                {
                    FormsAuthentication.SetAuthCookie(model.Name, true);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("_Error", "Пользователя с таким логином и паролем нет");
                }
            }

            return View("Register");
        }

        public ActionResult Register()
        {
            return View("Register");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = UserService.GetList()?.Where(x => x.Login == model.Name).FirstOrDefault();

                if (user == null)
                {
                    UserService.AddItem(new UserModel { Login = model.Name, Password = model.Password, Type = AccountTypes.User });
                    FormsAuthentication.SetAuthCookie(model.Name, true);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Пользователь с таким логином уже существует");
                }
            }

            return View(model);
        }
        public ActionResult Logoff()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}