using System;
using System.Web.Mvc;
using CookBook.BLL.Models;
using CookBook.BLL.Interfaces;

namespace CookBook.PL.Controllers
{
    public class HomeController : Controller
    {
        private IRecipeService _recipeService;
        private ICompositionService _compositionService;
        private IIngredientService _ingredientService;

        public HomeController(IRecipeService recipeService, ICompositionService compositionService, IIngredientService ingredientService)
        {
            _recipeService = recipeService;
            _compositionService = compositionService;
            _ingredientService = ingredientService;
        }

        public ActionResult Index()
        {
            return View(_recipeService.GetList());
        }

        public ActionResult AddRecipe(RecipeModel recipe)
        {
            _recipeService.AddItem(recipe);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteRecipe(Guid id)
        {
            _recipeService.DeleteItem(id);
            return RedirectToAction("Index");
        }

        public ActionResult EditRecipe(Guid id)
        {
            ViewBag.IngredientId = new SelectList(_ingredientService.GetList(), "Id", "Name");
            return View(_recipeService.GetItem(id));
        }

        public ActionResult AddExistComposition(CompositionModel model)
        {
            _compositionService.AddItem(model);
            return RedirectToAction("EditRecipe", new { id = model.RecipeId });
        }

        public ActionResult AddNewComposition(CompositionModel model)
        {
            model.IngredientId = _ingredientService.AddItem(new IngredientModel { Name = model.IngredientName });
            _compositionService.AddItem(model);
            return RedirectToAction("EditRecipe", new { id = model.RecipeId });
        }
    }
}