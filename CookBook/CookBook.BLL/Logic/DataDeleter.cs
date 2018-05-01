using System;
using System.Linq;
using CookBook.BLL.Logging;
using CookBook.BLL.Services;
using CookBook.Domain.Models;
using CookBook.Domain.Enums;

namespace CookBook.BLL.Logic
{
    public static class DataDeleter
    {
        public static void DeleteRecipes()
        {
            var recipe = new Recipe { Id = 2, Category = CategoryTypes.Dinner, Name = "Оливье", UserId = 3};
            Logger.InitLogger();

            var reviewService = new MainService<Review>();
            var reviews = reviewService.GetList().Where(x => x.RecipeId == recipe.Id).ToList();
            reviews.ForEach(x => 
            {
                reviewService.DeleteItem(x);
                Logger.Log.Info("Delete review " + x.Id);
            });

            var compositionService = new MainService<Composition>();
            var compositions = compositionService.GetList().Where(x => x.RecipeId == recipe.Id).ToList();
            compositions.ForEach(x => { compositionService.DeleteItem(x); });

            Logger.Log.Info("Delete compositions for recipe" + recipe.Name);

            var recipeService = new MainService<Recipe>();
            recipeService.DeleteItem(recipe);

            Logger.Log.Info("Delete recipe " + recipe.Name);
        }

        public static void DeleteIngredient()
        {
            var ingredient = new Ingredient { Id = 1, Name = "Помидор" };

            var ingredientService = new MainService<Ingredient>();
            ingredientService.DeleteItem(ingredient);

            Logger.InitLogger();
            Logger.Log.Info("Delete ingredient " + ingredient.Name);
        }

        public static void DeleteReview()
        {
            var review = new Review { Id = 3, UserId = 2, Description = "Not bad.", CreationDate = DateTime.Now, RecipeId = 3 };

            var reviewService = new MainService<Review>();
            reviewService.DeleteItem(review);

        }

        public static void DeleteUser()
        {
            var user = new User {Id = 1, Login = "Meow1", Type = AccountTypes.User, Password = "lala"};

            var userService = new MainService<User>();
            userService.DeleteItem(user);

            Logger.InitLogger();
            Logger.Log.Info("Delete user " + user.Login);
        }
    }
}
