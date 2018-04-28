using System;
using System.Collections.Generic;
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
            var recipe = new Recipe { Id = 2, Category = "Салат", Name = "Оливье", UserId = 3, ReviewsId = new List<int>() { 3, 5 }, CompositionsId = new List<int>() { 5, 8, 1 }};
            
            var recipeService = new MainService<Recipe>();
            recipeService.DeleteItem(recipe);

            DeleteCompositions(recipe);
            
            Logger.InitLogger();
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
            var review = new Review { Id = 3, UserId = 2, Description = "Not bad.", CreationDate = DateTime.Now };

            var reviewService = new MainService<Review>();
            reviewService.DeleteItem(review);

            Logger.InitLogger();
            Logger.Log.Info("Delete review " + review.Id);
        }

        public static void DeleteUser()
        {
            var user = new User {Id = 1, Login = "Meow1", Type = AccountTypes.User, Password = "lala"};

            var userService = new MainService<User>();
            userService.DeleteItem(user);

            Logger.InitLogger();
            Logger.Log.Info("Delete user " + user.Login);
        }

        private static void DeleteCompositions(Recipe recipe)
        {
            var compositionService = new MainService<Composition>();
            var compositionList = compositionService.GetList();
            foreach (var composition in recipe.CompositionsId)
            {
                var item = compositionList.FirstOrDefault(s => s.Id == composition);
                compositionService.DeleteItem(item);
            }
            
            Logger.InitLogger();
            Logger.Log.Info("Delete compositions for recipe" + recipe.Name);
        }
    }
}
