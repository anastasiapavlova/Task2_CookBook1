using System.Collections.Generic;
using BusinessLogic.Logging;
using BusinessLogic.Services;
using DataSource.Models;

namespace BusinessLogic.Logic
{
    public static class DataDeleter
    {
        public static void DeleteRecipes()
        {
            var recipe = new RecipeDataModel { Id = 2, Category = "Салат", Name = "Оливье", UserId = 3, ReviewsId = new List<int>() { 3, 5 }, CompositionsId = new List<int>() { 5, 8, 1 }};
            
            var recipeService = new MainService<RecipeDataModel>();
            recipeService.DeleteItem(recipe);

            Logger.InitLogger();
            Logger.Log.Info("Delete recipe " + recipe.Name);
        }

        public static void DeleteIngredients()
        {
            var ingredient = (new IngredientDataModel { Id = 1, Name = "Помидор" });

            var ingredientService = new MainService<IngredientDataModel>();
            ingredientService.DeleteItem(ingredient);

            Logger.InitLogger();
            Logger.Log.Info("Delete ingredient " + ingredient.Name);
        }
    }
}
