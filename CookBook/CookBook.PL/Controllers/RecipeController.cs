using System;
using Ninject;
using System.Linq;
using System.Web.Mvc;
using CookBook.PL.Models;
using CookBook.BLL.Models;
using CookBook.PL.Mappers;
using CookBook.BLL.Logging;
using CookBook.BLL.Interfaces;

namespace CookBook.PL.Controllers
{
    public class RecipeController : Controller
    {
        [Inject]
        public IRecipeService RecipeService { get; set; }
        [Inject]
        public ICompositionService CompositionService { get; set; }
        [Inject]
        public IIngredientService IngredientService { get; set; }
        [Inject]
        public IUserService UserService { get; set; }

        [Route("recipes-list")]
        [HandleError(View = "_Error")]
        public ActionResult ViewRecipeList()
        {
            try
            {
                var recipeList = RecipeService.GetList().Select(RecipeViewMapper.ConvertRecipeModelToRecipeViewModel).ToList();
                recipeList.Select(x => x.User = UserViewMapper.ConvertUserModelToUserViewModel(UserService.GetList().FirstOrDefault(y => y.Id == x.UserId))).ToList();
                return View("ViewRecipeList", recipeList);
            }
            catch (Exception e)
            {
                Logger.InitLogger();
                Logger.Log.Error("Error: " + e);
                return View("_Error");
            }
        }

        [HttpGet]
        [Route("add-recipe")]
        [HandleError(View = "_Error")]
        public ActionResult AddRecipe()
        {
            try
            {
                return View("AddRecipe");
            }
            catch (Exception e)
            {
                Logger.InitLogger();
                Logger.Log.Error("Error: " + e);
                return View("_Error");
            }
        }

        [HttpPost]
        [Route("add-recipe")]
        [HandleError(View = "_Error")]
        public ActionResult AddRecipe(RecipeViewModel recipe)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    recipe.User = UserViewMapper.ConvertUserModelToUserViewModel(UserService.GetList().FirstOrDefault());
                    RecipeService.AddItem(RecipeViewMapper.ConvertRecipeViewModelToRecipeModel(recipe));
                    return RedirectToAction("ViewRecipeList");
                }
                return View("AddRecipe");
            }
            catch (Exception e)
            {
                Logger.InitLogger();
                Logger.Log.Error("Error: " + e);
                return View("_Error");
            }
        }

        [HandleError(View = "_Error")]
        public ActionResult DeleteRecipe(Guid id)
        {
            try
            {
                RecipeService.DeleteItem(id);
                return RedirectToAction("ViewRecipeList");
            }
            catch (Exception e)
            {
                Logger.InitLogger();
                Logger.Log.Error("Error: " + e);
                return View("_Error");
            }
        }

        [Route("edit-recipe")]
        [HandleError(View = "_Error")]
        public ActionResult EditRecipe(Guid id)
        {
            try
            {
                ViewBag.IngredientId = new SelectList(IngredientService.GetList().Select(IngredientViewMapper.ConvertIngredientModelToIngredientViewModel).ToList(), "Id", "Name");
                var modelRecipe = RecipeViewMapper.ConvertRecipeModelToRecipeViewModel(RecipeService.GetItem(id));
                return View("EditRecipe", modelRecipe);
            }
            catch (Exception e)
            {
                Logger.InitLogger();
                Logger.Log.Error("Error: " + e);
                return View("_Error");
            }
        }

        [HandleError(View = "_Error")]
        public ActionResult AddExistComposition(CompositionBaseViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    CompositionService.AddItem(CompositionViewMapper.ConvertCompositonViewModelToCompositionModel(model));
                    return RedirectToAction("EditRecipe", new { id = model.RecipeId });
                }
                return RedirectToAction("EditRecipe", new { id = model.RecipeId });
            }
            catch (Exception e)
            {
                Logger.InitLogger();
                Logger.Log.Error("Error: " + e);
                return View("_Error");
            }
        }

        [HandleError(View = "_Error")]
        public ActionResult AddNewComposition(CompositionViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    model.IngredientId = IngredientService.AddItem(new IngredientModel { Name = model.IngredientName });
                    CompositionService.AddItem(CompositionViewMapper.ConvertCompositonViewModelToCompositionModel(model));
                    return RedirectToAction("EditRecipe", new { id = model.RecipeId });
                }
                return RedirectToAction("EditRecipe", new { id = model.RecipeId });
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