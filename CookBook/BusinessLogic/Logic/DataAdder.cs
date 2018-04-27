using System;
using System.Collections.Generic;
using BusinessLogic.Logging;
using BusinessLogic.Services;
using DataSource.Enums;
using DataSource.Models;

namespace BusinessLogic.Logic
{
    public static class DataAdder
    {
        public static void AddRecipes()
        {
            List<RecipeDataModel> recipes = new List<RecipeDataModel>();
            recipes.Add(new RecipeDataModel { Id = 1, Category = "Cуп", Name = "Куриный бульон", UserId = 1, ReviewsId = new List<int>() { 1, 4, 5 }, CompositionsId = new List<int>() { 1, 3, 2 } });
            recipes.Add(new RecipeDataModel { Id = 2, Category = "Салат", Name = "Оливье", UserId = 3, ReviewsId = new List<int>() { 3, 5 }, CompositionsId = new List<int>() { 5, 8, 1 } });
            recipes.Add(new RecipeDataModel { Id = 3, Category = "Горячее", Name = "Котлеты", UserId = 2, ReviewsId = new List<int>() { 4, 5, 4 }, CompositionsId = new List<int>() { 6, 4, 1 } });

            var recipeService = new MainService<RecipeDataModel>();
            recipeService.AddItems(recipes);

            Logger.InitLogger();
            Logger.Log.Info("Add " + recipes.Count + " recipe(-s) ");
        }

        public static void AddIngredients()
        {
            List<IngredientDataModel> ingredients = new List<IngredientDataModel>();
            ingredients.Add(new IngredientDataModel { Id = 1, Name = "Помидор"});
            ingredients.Add(new IngredientDataModel { Id = 2, Name = "Фарш"});
            ingredients.Add(new IngredientDataModel { Id = 3, Name = "Горошек"});

            var recipeService = new MainService<IngredientDataModel>();
            recipeService.AddItems(ingredients);

            Logger.InitLogger();
            Logger.Log.Info("Add " + ingredients.Count + " ingredient(-s) ");
        }

        public static void AddUsers()
        {
            List<UserDataModel> users = new List<UserDataModel>();
            users.Add(new UserDataModel { Id = 1, Login = "Meow1", Type = AccountType.User, Password = "lala"});
            users.Add(new UserDataModel { Id = 2, Login = "Nastya", Type = AccountType.User, Password = "1231" });
            users.Add(new UserDataModel { Id = 3, Login = "Lala", Type = AccountType.Admin, Password = "2231" });

            var userService = new MainService<UserDataModel>();
            userService.AddItems(users);

            Logger.InitLogger();
            Logger.Log.Info("Add " + users.Count + " ingredient(-s) ");
        }

        public static void AddReviews()
        {
            List<ReviewDataModel> users = new List<ReviewDataModel>();
            users.Add(new ReviewDataModel { Id = 1, UserId = 3, Description = "Like it.", ReviewDate = DateTime.Now });
            users.Add(new ReviewDataModel { Id = 2, UserId = 1, Description = "Perfect.", ReviewDate = DateTime.Now });
            users.Add(new ReviewDataModel { Id = 3, UserId = 2, Description = "Not bad.", ReviewDate = DateTime.Now });

            var userService = new MainService<ReviewDataModel>();
            userService.AddItems(users);

            Logger.InitLogger();
            Logger.Log.Info("Add " + users.Count + " review(-s) ");
        }

        public static void AddCompositions()
        {
            List<CompositionDataModel> compositions = new List<CompositionDataModel>();
            compositions.Add(new CompositionDataModel { Id = 1, IngredientId = 3, Quantity = 2});
            compositions.Add(new CompositionDataModel { Id = 2, IngredientId = 2, Quantity = 3 });
            compositions.Add(new CompositionDataModel { Id = 3, IngredientId = 1, Quantity = 4 });

            var userService = new MainService<CompositionDataModel>();
            userService.AddItems(compositions);

            Logger.InitLogger();
            Logger.Log.Info("Add " + compositions.Count + " composition(-s) ");
        }
    }
}
