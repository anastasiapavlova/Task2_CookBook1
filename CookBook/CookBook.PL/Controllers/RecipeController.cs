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
    public partial class RecipeController : Controller
    {
        [Inject]
        public IRecipeService RecipeService { get; set; }
        [Inject]
        public ICompositionService CompositionService { get; set; }
        [Inject]
        public IIngredientService IngredientService { get; set; }
        [Inject]
        public IUserService UserService { get; set; }

        [HttpGet]
        [HandleError(View = "_Error")]
        public virtual ActionResult ViewRecipeList()
        {
            try
            {
                var recipeList = RecipeService.GetList().Select(RecipeViewMapper.ConvertRecipeModelToRecipeViewModel).ToList();
                recipeList.Select(x => x.User = UserViewMapper.ConvertUserModelToUserViewModel(UserService.GetList().FirstOrDefault(y => y.Id == x.UserId))).ToList();
                return View(Views.Listing, recipeList);
            }
            catch (Exception e)
            {
                Logger.InitLogger();
                Logger.Log.Error("Error: " + e);
                return RedirectToAction(MVC.Home.ErrorAc());
            }
        }

        [HttpGet]
        [HandleError(View = "_Error")]
        public virtual ActionResult AddRecipe()
        {
            try
            {
                return View(Views.AddRecipe);
            }
            catch (Exception e)
            {
                Logger.InitLogger();
                Logger.Log.Error("Error: " + e);
                return RedirectToAction(MVC.Home.ErrorAc());
            }
        }

        [HttpPost]
        [HandleError(View = "_Error")]
        public virtual ActionResult AddRecipe(RecipeViewModel recipe)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    recipe.User = UserViewMapper.ConvertUserModelToUserViewModel(UserService.GetList().FirstOrDefault());
                    RecipeService.AddItem(RecipeViewMapper.ConvertRecipeViewModelToRecipeModel(recipe));
                    return RedirectToAction(MVC.Recipe.ViewRecipeList());
                }
                return View(Views.AddRecipe);
            }
            catch (Exception e)
            {
                Logger.InitLogger();
                Logger.Log.Error("Error: " + e);
                return RedirectToAction(MVC.Home.ErrorAc());
            }
        }

        [HttpPost]
        [HandleError(View = "_Error")]
        public virtual ActionResult DeleteRecipe(Guid id)
        {
            try
            {
                RecipeService.DeleteItem(id);
                return RedirectToAction(MVC.Recipe.ViewRecipeList());
            }
            catch (Exception e)
            {
                Logger.InitLogger();
                Logger.Log.Error("Error: " + e);
                return RedirectToAction(MVC.Home.ErrorAc());
            }
        }

        [HttpGet]
        [HandleError(View = "_Error")]
        public virtual ActionResult EditRecipe(Guid id)
        {
            try
            {
                ViewBag.IngredientId = new SelectList(IngredientService.GetList().Select(IngredientViewMapper.ConvertIngredientModelToIngredientViewModel).ToList(), "Id", "Name");
                var modelRecipe = RecipeViewMapper.ConvertRecipeModelToRecipeViewModel(RecipeService.GetItem(id));
                return View(Views.Editing, modelRecipe);
            }
            catch (Exception e)
            {
                Logger.InitLogger();
                Logger.Log.Error("Error: " + e);
                return RedirectToAction(MVC.Home.ErrorAc());
            }
        }

        [HttpPost]
        [HandleError(View = "_Error")]
        public virtual ActionResult AddExistComposition(CompositionBaseViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    CompositionService.AddItem(CompositionViewMapper.ConvertCompositonViewModelToCompositionModel(model));
                    return RedirectToAction(MVC.Recipe.EditRecipe(model.RecipeId));
                }
                return RedirectToAction(MVC.Recipe.EditRecipe(model.RecipeId));
            }
            catch (Exception e)
            {
                Logger.InitLogger();
                Logger.Log.Error("Error: " + e);
                return RedirectToAction(MVC.Home.ErrorAc());
            }
        }

        [HttpPost]
        [HandleError(View = "_Error")]
        public virtual ActionResult AddNewComposition(CompositionViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    model.IngredientId = IngredientService.AddItem(new IngredientModel { Name = model.IngredientName });
                    CompositionService.AddItem(CompositionViewMapper.ConvertCompositonViewModelToCompositionModel(model));
                    return RedirectToAction(MVC.Recipe.EditRecipe(model.RecipeId));
                }
                return RedirectToAction(MVC.Recipe.EditRecipe(model.RecipeId));
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