using System;
using Ninject;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CookBook.PL.Models;
using CookBook.BLL.Enums;
using CookBook.BLL.Models;
using System.Web.Security;
using System.Security.Claims;
using CookBook.BLL.Interfaces;
using Microsoft.Owin.Security;

namespace CookBook.PL.Controllers
{
    public class AuthorizationController : Controller
    {
        [Inject]
        public IUserService UserService { get; set; }

        [HttpGet]
        public ActionResult Login()
        {
            var user = Initialize();
            if (user != null)
            {
                ViewBag.Login = true;
            }
            return View("Authorization");
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = UserService.GetList()?.Where(x => x.Login == model.Name && x.Password == model.Password).FirstOrDefault();

                if (user != null)
                {
                    //ClaimsIdentity claim = new ClaimsIdentity("ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
                   
                    var claim = new ClaimsIdentity(new[] {
                            new Claim(ClaimTypes.NameIdentifier, String.Empty),
                            new Claim(ClaimTypes.Name, String.Empty),
                            new Claim(ClaimTypes.Role, "User"),
                            new Claim(ClaimTypes.Role, "Admin")
                        },
                        "ApplicationCookie");
                    claim.AddClaim(new Claim(ClaimTypes.NameIdentifier, user.Id.ToString(), ClaimValueTypes.String));
                    claim.AddClaim(new Claim(ClaimTypes.Name, user.Login, ClaimValueTypes.String));
                    claim.AddClaim(new Claim(ClaimTypes.Role, user.Type.ToString(), ClaimValueTypes.String));

                    HttpContext.GetOwinContext().Authentication.SignOut();
                    HttpContext.GetOwinContext().Authentication.SignIn(new AuthenticationProperties
                    {
                        IsPersistent = true
                    }, claim);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    return View("_Error");
                }
            }

            return View("Register");
        }

        [HttpGet]
        [AllowAnonymous]
        public ActionResult Register()
        {
            return View("Register");
        }

        [HttpPost]
        [AllowAnonymous]
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

        [HttpPost]
        public ActionResult Logoff()
        {
            HttpContext.GetOwinContext().Authentication.SignOut();
            return RedirectToAction("Index", "Home");
        }

        private UserViewModel Initialize()
        {
            var claimsIdentity = User.Identity as ClaimsIdentity;
            if (!String.IsNullOrEmpty(claimsIdentity.Name))
            {
                var user = new UserViewModel
                {
                    Id = new Guid(claimsIdentity.FindFirst(ClaimTypes.NameIdentifier).Value),
                    Login = claimsIdentity.FindFirst(ClaimTypes.Name).Value,
                    Type = (AccountTypes)Enum.Parse(typeof(AccountTypes), claimsIdentity.FindFirst(ClaimTypes.Role).Value)
                };
                return user;
            }

            return null;
        }
    }
}