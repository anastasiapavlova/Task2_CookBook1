using System;
using System.Linq;
using CookBook.BLL.Logging;
using CookBook.BLL.Services;
using CookBook.Domain.Enums;
using CookBook.Domain.Models;

namespace CookBook.BLL.Logic
{
    public static class DataUpdater
    {
        public static void UpdateRecipe()
        {
            var recipe = new Recipe { Id = 2, Category = CategoryTypes.Dinner, Name = "Летний", UserId = 3};

            var recipesService = new MainService<Recipe>();
            var recipesList = recipesService.GetList();
            var updatingRecipe = recipesList.FirstOrDefault(s => s.Id == recipe.Id);

            recipesService.UpdateItem(updatingRecipe, recipe);

            Logger.InitLogger();
            Logger.Log.Info("Update recipe " + recipe.Name);
        }

        public static void UpdateIngredient()
        {
            var ingredient = (new Ingredient{ Id = 3, Name = "Морковка" });

            var ingredientsService = new MainService<Ingredient>();
            var ingrediensList = ingredientsService.GetList();
            var updatingIngredient = ingrediensList.FirstOrDefault(s => s.Id == ingredient.Id);

            ingredientsService.UpdateItem(updatingIngredient, ingredient);

            Logger.InitLogger();
            Logger.Log.Info("Update ingredient " + ingredient.Name);
        }

        public static void UpdateReview()
        {
            var review = new Review {Id = 1, UserId = 3, Description = "Like it very much.", CreationDate = DateTime.Now, RecipeId = 1 };

            var reviewsService = new MainService<Review>();
            var reviewsList = reviewsService.GetList();
            var updatingReview = reviewsList.FirstOrDefault(s => s.Id == review.Id);

            reviewsService.UpdateItem(updatingReview, review);

            Logger.InitLogger();
            Logger.Log.Info("Update recipe " + review.Id);
        }
    }
}
