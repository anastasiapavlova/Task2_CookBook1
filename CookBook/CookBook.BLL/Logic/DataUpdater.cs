using System;
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
            var recipe = new Recipe { Id = 2, Category = CategoryTypes.Breakfast, Name = "PastaNyam", UserId = 2 };

            var recipesService = new RecipeService();

            recipesService.UpdateItem(recipe);

            Logger.InitLogger();
            Logger.Log.Info("Update recipe " + recipe.Name);
        }

        public static void UpdateIngredient()
        {
            var ingredient = (new Ingredient{ Id = 3, Name = "Bread" });

            var ingredientsService = new IngredientService();
            ingredientsService.UpdateItem(ingredient);

            Logger.InitLogger();
            Logger.Log.Info("Update ingredient " + ingredient.Name);
        }

        public static void UpdateReview()
        {
            var review = new Review {Id = 3, UserId = 3, Description = "Like it very much.", CreationDate = DateTime.Now, RecipeId = 3 };

            var reviewsService = new ReviewService();
            reviewsService.UpdateItem(review);

            Logger.InitLogger();
            Logger.Log.Info("Update recipe " + review.Id);
        }

        public static void UpdateUser()
        {
            var user = new User { Id = 4, Login = "Meow14", Type = AccountTypes.User, Password = "miu" };

            var userService = new UserService();
            userService.UpdateItem(user);

            Logger.InitLogger();
            Logger.Log.Info("Update user " + user.Id);
        }
    }
}
