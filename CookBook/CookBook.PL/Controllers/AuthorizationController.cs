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
using CookBook.BLL.Logging;
using Microsoft.Owin.Security;

namespace CookBook.PL.Controllers
{
    public partial class AuthorizationController : Controller
    {
        [Inject]
        public IUserService UserService { get; set; }

        [HttpGet]
        public virtual ActionResult Login()
        {
            try
            {
                var user = Initialize();
                if (user != null)
                {
                    ViewBag.Login = true;
                }
                return View(Views.Authorization);
            }
            catch (Exception e)
            {
                Logger.InitLogger();
                Logger.Log.Error("Error: " + e);
                return RedirectToAction(MVC.Home.ErrorAc());
            }
        }

        [HttpPost]
        public virtual ActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = UserService.GetList()?.Where(x => x.Login == model.Name && x.Password == model.Password).FirstOrDefault();

                if (user != null)
                {
                    ClaimsIdentity claim = new ClaimsIdentity("ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);

                    claim.AddClaim(new Claim(ClaimTypes.NameIdentifier, user.Id.ToString(), ClaimValueTypes.String));
                    claim.AddClaim(new Claim(ClaimsIdentity.DefaultNameClaimType, user.Login, ClaimValueTypes.String));
                    claim.AddClaim(new Claim(ClaimsIdentity.DefaultRoleClaimType, user.Type.ToString(), ClaimValueTypes.String));
                    claim.AddClaim(new Claim("http://schemas.microsoft.com/accesscontrolservice/2010/07/claims/identityprovider",
                        "OWIN Provider", ClaimValueTypes.String));

                    HttpContext.GetOwinContext().Authentication.SignOut();
                    HttpContext.GetOwinContext().Authentication.SignIn(new AuthenticationProperties
                    {
                        IsPersistent = true
                    }, claim);
                    return RedirectToAction(MVC.Home.Index());
                }
                else
                {
                    return RedirectToAction(MVC.Home.ErrorAc());
                }
            }

            return View(Views.Register);
        }

        [HttpGet]
        [AllowAnonymous]
        public virtual ActionResult Register()
        {
            return View(Views.Register);
        }

        [HttpPost]
        [AllowAnonymous]
        public virtual ActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = UserService.GetList()?.Where(x => x.Login == model.Name).FirstOrDefault();

                if (user == null)
                {
                    UserService.AddItem(new UserModel { Login = model.Name, Password = model.Password, Type = AccountTypes.User });
                    FormsAuthentication.SetAuthCookie(model.Name, true);
                    return RedirectToAction(MVC.Authorization.Login());
                }
                else
                {
                    ModelState.AddModelError("", "Пользователь с таким логином уже существует");
                }
            }

            return View(Views.Register,model);
        }

        [HttpPost]
        public virtual ActionResult Logoff()
        {
            HttpContext.GetOwinContext().Authentication.SignOut();
            return RedirectToAction(MVC.Home.Index());
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