using System;
using System.Linq;
using System.Web.Mvc;
using CookBook.BLL.Models;
using CookBook.BLL.Logging;
using CookBook.BLL.Interfaces;

namespace CookBook.PL.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRecipeService _recipeService;
        private readonly IUserService _userService;

        public HomeController(IRecipeService recipeService, IUserService userService)
        {
            _recipeService = recipeService;
            _userService = userService;
        }

        [HandleError(View = "Error")]
        public ActionResult Index()
        {
            try
            {
                return View("Index", _recipeService.GetList());
            }
            catch (Exception e)
            {
                Logger.InitLogger();
                Logger.Log.Error("Error: " + e);
                return View("Error");
            }
        }

        public ActionResult ErrorAc()
        {
            return View("Error");
        }

        [HandleError(View = "Error")]
        public ActionResult AddRecipe(RecipeModel recipe)
        {
            try
            {
                recipe.User = _userService.GetList().FirstOrDefault();
                _recipeService.AddItem(recipe);
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                Logger.InitLogger();
                Logger.Log.Error("Error: " + e);
                return View("Error");
            }
        }

        [HandleError(View = "Error")]
        public ActionResult DeleteRecipe(Guid id)
        {
            try
            {
                _recipeService.DeleteItem(id);
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                Logger.InitLogger();
                Logger.Log.Error("Error: " + e);
                return View("Error");
            }
        }
    }
}