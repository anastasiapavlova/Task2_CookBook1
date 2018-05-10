using System;
using System.Web.Mvc;
using CookBook.BLL.Models;
using CookBook.BLL.Logging;
using CookBook.BLL.Interfaces;

namespace CookBook.PL.Controllers
{
    public class EditRecipeController : Controller
    {
        private readonly IRecipeService _recipeService;
        private readonly ICompositionService _compositionService;
        private readonly IIngredientService _ingredientService;

        public EditRecipeController(IRecipeService recipeService, ICompositionService compositionService, IIngredientService ingredientService)
        {
            _recipeService = recipeService;
            _compositionService = compositionService;
            _ingredientService = ingredientService;
        }

        [HandleError(View = "Error")]
        public ActionResult EditRecipe(Guid id)
        {
            try
            {
                RecipeModel modelRecipe = _recipeService.GetItem(id);
                ViewBag.IngredientId = new SelectList(_ingredientService.GetList(), "Id", "Name");
                return View(modelRecipe);
            }
            catch (Exception e)
            {
                Logger.InitLogger();
                Logger.Log.Error("Error: " + e);
                return View("Error");
            }
        }

        [HandleError(View = "Error")]
        public ActionResult AddExistComposition(CompositionModel model)
        {
            try
            {
                _compositionService.AddItem(model);
                return RedirectToAction("EditRecipe", new { id = model.RecipeId });
            }
            catch (Exception e)
            {
                Logger.InitLogger();
                Logger.Log.Error("Error: " + e);
                return View("Error");
            }
        }

        [HandleError(View = "Error")]
        public ActionResult AddNewComposition(CompositionModel model)
        {
            try
            {
                model.IngredientId = _ingredientService.AddItem(new IngredientModel { Name = model.IngredientName });
                _compositionService.AddItem(model);
                return RedirectToAction("EditRecipe", new { id = model.RecipeId });
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