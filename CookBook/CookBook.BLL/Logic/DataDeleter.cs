using System;
using CookBook.BLL.Logging;
using CookBook.BLL.Services;
using CookBook.Domain.Models;
using CookBook.Domain.Enums;

namespace CookBook.BLL.Logic
{
    public static class DataDeleter
    {
        public static void DeleteRecipes(int id)
        {
            var recipeService = new RecipeService();
            recipeService.DeleteItem(id);

            Logger.InitLogger();
            Logger.Log.Info("Delete recipe " + id);
        }

        public static void DeleteIngredient()
        {
            var ingredient = new Ingredient { Id = 6, Name = "Sugar" };

            var ingredientService = new IngredientService();
            ingredientService.DeleteItem(ingredient);

            Logger.InitLogger();
            Logger.Log.Info("Delete ingredient " + ingredient.Name);
        }

        public static void DeleteReview()
        {
            var review = new Review { Id = 4, UserId = 2, Description = "Tasty", CreationDate = DateTime.Now, RecipeId = 4 };

            var reviewService = new ReviewService();
            reviewService.DeleteItem(review);

            Logger.InitLogger();
            Logger.Log.Info("Delete review " + review.Id);
        }

        public static void DeleteUser()
        {
            var user = new User { Id = 3, Login = "Lala", Type = AccountTypes.User, Password = "topolya" };

            var userService = new UserService();
            userService.DeleteItem(user);

            Logger.InitLogger();
            Logger.Log.Info("Delete user " + user.Login);
        }

        public static void DeleteComposition()
        {
            var composition = new Composition {Id = 8, IngredientId = 4, Quantity = 3, RecipeId = 4 };

            var compositionService = new CompositionService();
            compositionService.DeleteItem(composition);

            Logger.InitLogger();
            Logger.Log.Info("Delete composition " + composition.Id);
        }
    }
}
