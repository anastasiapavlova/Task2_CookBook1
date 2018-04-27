using System.Collections.Generic;
using BusinessLogic.Services;
using DataSource.Models;

namespace BusinessLogic.Logic
{
    public static class DataUpdater
    {
        public static void UpdateRecipe()
        {
            var recipe = new RecipeDataModel { Id = 2, Category = "Салат", Name = "Летний", UserId = 3, ReviewsId = new List<int>() { 3, 5 }, CompositionsId = new List<int>() { 5, 8, 1 } };

            var recipeService = new MainService<RecipeDataModel>();
            recipeService.UpdateItem(recipe);
        }

        public static void UpdateIngredient()
        {
            var ingredient = (new IngredientDataModel { Id = 3, Name = "Морковка" });

            var recipeService = new MainService<IngredientDataModel>();
            recipeService.UpdateItem(ingredient);
        }

    }
}
