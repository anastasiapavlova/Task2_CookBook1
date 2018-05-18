using System;
using System.Collections.Generic;
using Ninject;
using System.Linq;
using System.Web.Mvc;
using CookBook.BLL.Enums;
using CookBook.PL.Models;
using CookBook.BLL.Models;
using CookBook.PL.Mappers;
using CookBook.BLL.Logging;
using CookBook.BLL.Interfaces;
using System.Security.Claims;

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
        public virtual ActionResult ViewRecipeList(int page = 1)
        {
            try
            {
                var pageSize = int.Parse(Resources.Constants.ObjectPerPage);
                UserViewModel user = Initialize();
                if (user != null)
                {
                    if (user.Type == AccountTypes.User)
                    {
                        var userRecipeList = RecipeService.GetList().Where(x => x.UserId == user.Id).Select(RecipeViewMapper.ConvertRecipeModelToRecipeViewModel).ToList();
                        userRecipeList.Select(x => x.User = UserViewMapper.ConvertUserModelToUserViewModel(UserService.GetList().FirstOrDefault(y => y.Id == x.UserId))).ToList();
                        IEnumerable<RecipeViewModel> usersRecipesPerPages = userRecipeList.Skip((page - 1) * pageSize).Take(pageSize);
                        PageInfo userPageInfo = new PageInfo { PageNumber = page, PageSize = pageSize, TotalItems = userRecipeList.Count };
                        IndexViewModel userIndexViewModel = new IndexViewModel { PageInfo = userPageInfo, Recipes = usersRecipesPerPages };
                        return View(Views.Listing, userIndexViewModel);
                    }
                }
                var recipeList = RecipeService.GetList().Select(RecipeViewMapper.ConvertRecipeModelToRecipeViewModel).ToList();
                recipeList.Select(x => x.User = UserViewMapper.ConvertUserModelToUserViewModel(UserService.GetList().FirstOrDefault(y => y.Id == x.UserId))).ToList();
                IEnumerable<RecipeViewModel> recipesPerPages = recipeList.Skip((page - 1) * pageSize).Take(pageSize);
                PageInfo pageInfo = new PageInfo { PageNumber = page, PageSize = pageSize, TotalItems = recipeList.Count };
                IndexViewModel indexViewModel = new IndexViewModel { PageInfo = pageInfo, Recipes = recipesPerPages };
                return View(Views.Listing, indexViewModel);
            }
            catch (Exception e)
            {
                Logger.InitLogger();
                Logger.Log.Error("Error: " + e);
                return RedirectToAction(MVC.Home.ErrorAc());
            }
        }

        [HttpGet]
        [Authorize(Roles = "User")]
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
        [Authorize(Roles = "User")]
        [HandleError(View = "_Error")]
        public virtual ActionResult AddRecipe(RecipeViewModel recipe)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    recipe.User = Initialize();
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

        [HttpGet]
        [Authorize]
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
        [Authorize]
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
        [Authorize(Roles = "User")]
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
        [Authorize(Roles = "User")]
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