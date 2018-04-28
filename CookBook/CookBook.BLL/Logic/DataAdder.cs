using System;
using System.Collections.Generic;
using CookBook.BLL.Logging;
using CookBook.BLL.Services;
using CookBook.Domain.Models;
using CookBook.Domain.Enums;

namespace CookBook.BLL.Logic
{
    public static class DataAdder
    {
        public static void AddRecipes()
        {
            List<Recipe> recipes = new List<Recipe>();
            recipes.Add(new Recipe { Id = 1, Category = "Cуп", Name = "Куриный бульон", UserId = 1, ReviewsId = new List<int>() { 1, 4, 5 }, CompositionsId = new List<int>() { 1, 3, 2 } });
            recipes.Add(new Recipe { Id = 2, Category = "Салат", Name = "Оливье", UserId = 3, ReviewsId = new List<int>() { 3, 5 }, CompositionsId = new List<int>() { 5, 8, 1 } });
            recipes.Add(new Recipe { Id = 3, Category = "Горячее", Name = "Котлеты", UserId = 2, ReviewsId = new List<int>() { 4, 5, 4 }, CompositionsId = new List<int>() { 6, 4, 1 } });

            var recipeService = new MainService<Recipe>();
            recipeService.AddItems(recipes);

            Logger.InitLogger();
            Logger.Log.Info("Add " + recipes.Count + " recipe(-s) ");
        }

        public static void AddIngredients()
        {
            List<Ingredient> ingredients = new List<Ingredient>();
            ingredients.Add(new Ingredient { Id = 1, Name = "Помидор"});
            ingredients.Add(new Ingredient { Id = 2, Name = "Фарш"});
            ingredients.Add(new Ingredient { Id = 3, Name = "Горошек"});

            var recipeService = new MainService<Ingredient>();
            recipeService.AddItems(ingredients);

            Logger.InitLogger();
            Logger.Log.Info("Add " + ingredients.Count + " ingredient(-s) ");
        }

        public static void AddUsers()
        {
            List<User> users = new List<User>();
            users.Add(new User { Id = 1, Login = "Meow1", Type = AccountTypes.User, Password = "lala"});
            users.Add(new User { Id = 2, Login = "Nastya", Type = AccountTypes.User, Password = "1231" });
            users.Add(new User { Id = 3, Login = "Lala", Type = AccountTypes.Admin, Password = "2231" });

            var userService = new MainService<User>();
            userService.AddItems(users);

            Logger.InitLogger();
            Logger.Log.Info("Add " + users.Count + " ingredient(-s) ");
        }

        public static void AddReviews()
        {
            List<Review> users = new List<Review>();
            users.Add(new Review { Id = 1, UserId = 3, Description = "Like it.", CreationDate = DateTime.Now });
            users.Add(new Review { Id = 2, UserId = 1, Description = "Perfect.", CreationDate = DateTime.Now });
            users.Add(new Review { Id = 3, UserId = 2, Description = "Not bad.", CreationDate = DateTime.Now });

            var userService = new MainService<Review>();
            userService.AddItems(users);

            Logger.InitLogger();
            Logger.Log.Info("Add " + users.Count + " review(-s) ");
        }

        public static void AddCompositions()
        {
            List<Composition> compositions = new List<Composition>();
            compositions.Add(new Composition { Id = 1, IngredientId = 3, Quantity = 2});
            compositions.Add(new Composition { Id = 2, IngredientId = 2, Quantity = 3 });
            compositions.Add(new Composition { Id = 3, IngredientId = 1, Quantity = 4 });

            var userService = new MainService<Composition>();
            userService.AddItems(compositions);

            Logger.InitLogger();
            Logger.Log.Info("Add " + compositions.Count + " composition(-s) ");
        }
    }
}
