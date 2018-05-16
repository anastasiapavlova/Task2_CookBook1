﻿using System;
using Ninject;
using System.Linq;
using System.Web.Mvc;
using CookBook.PL.Mappers;
using CookBook.BLL.Logging;
using CookBook.BLL.Interfaces;
using CookBook.PL.Util;

namespace CookBook.PL.Controllers
{
    public partial class UserControlController : Controller
    {
        [Inject]
        public IUserService UserService { get; set; }

        [HttpGet]
        [ClaimsAuthorize]
        //[AllowAnonymous]
        [HandleError(View = "_Error")]
        public virtual ActionResult UserControl()
        {
            try
            {
                var users = UserService.GetList().Select(UserViewMapper.ConvertUserModelToUserViewModel).ToList();
                return View(Views.UserControl, users);
            }
            catch (Exception e)
            {
                Logger.InitLogger();
                Logger.Log.Error("Error: " + e);
                return RedirectToAction(MVC.Home.ErrorAc());
            }
        }

        [HttpPost]
        //[ClaimsAuthorize]
        [HandleError(View = "_Error")]
        public virtual ActionResult DeleteUser(Guid id)
        {
            try
            {
                UserService.DeleteItem(id);
                return RedirectToAction(MVC.UserControl.UserControl());
            }
            catch (Exception e)
            {
                Logger.InitLogger();
                Logger.Log.Error("Error: " + e);
                return RedirectToAction(MVC.Home.ErrorAc());
            }
        }
    }
}