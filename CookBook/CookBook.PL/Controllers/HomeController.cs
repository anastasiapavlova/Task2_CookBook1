using System;
using System.Linq;
using System.Web.Mvc;
using CookBook.BLL.Models;
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

        public ActionResult Index()
        {
            return View(_recipeService.GetList());
        }

        public ActionResult AddRecipe(RecipeModel recipe)
        {
            recipe.User = _userService.GetList().FirstOrDefault();
            _recipeService.AddItem(recipe);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteRecipe(Guid id)
        {
            _recipeService.DeleteItem(id);
            return RedirectToAction("Index");
        }
    }
}