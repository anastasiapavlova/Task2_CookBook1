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
            recipes.Add(new Recipe { Category = CategoryTypes.Lunch, Name = "Beef", UserId = 1 });
            recipes.Add(new Recipe { Category = CategoryTypes.Lunch, Name = "Pasta", UserId = 2 });
            recipes.Add(new Recipe { Category = CategoryTypes.Dinner, Name = "Cake", UserId = 3 });
            recipes.Add(new Recipe { Category = CategoryTypes.Breakfast, Name = "Pancakes", UserId = 1 });

            var recipeService = new RecipeService();
            recipeService.AddItems(recipes);

            Logger.InitLogger();
            Logger.Log.Info("Add " + recipes.Count + " recipe(-s) ");
        }

        public static void AddIngredients()
        {
            List<Ingredient> ingredients = new List<Ingredient>();
            ingredients.Add(new Ingredient { Name = "Meat" });
            ingredients.Add(new Ingredient { Name = "Milk" });
            ingredients.Add(new Ingredient { Name = "Egg" });
            ingredients.Add(new Ingredient { Name = "Spaghetti" });
            ingredients.Add(new Ingredient { Name = "Flour" });
            ingredients.Add(new Ingredient { Name = "Sugar" });

            var recipeService = new IngredientService();
            recipeService.AddItems(ingredients);

            Logger.InitLogger();
            Logger.Log.Info("Add " + ingredients.Count + " ingredient(-s) ");
        }

        public static void AddUsers()
        {
            List<User> users = new List<User>();
            users.Add(new User { Login = "Nastya", Type = AccountTypes.User, Password = "lala" });
            users.Add(new User { Login = "Nastya1", Type = AccountTypes.User, Password = "1231" });
            users.Add(new User { Login = "Lala", Type = AccountTypes.Admin, Password = "2231" });
            users.Add(new User { Id = 4, Login = "Meow", Type = AccountTypes.User, Password = "miu" });

            var userService = new UserService();
            userService.AddItems(users);

            Logger.InitLogger();
            Logger.Log.Info("Add " + users.Count + " ingredient(-s) ");
        }

        public static void AddReviews()
        {
            List<Review> users = new List<Review>();
            users.Add(new Review { UserId = 1, Description = "Perfect", CreationDate = DateTime.Now, RecipeId = 1 });
            users.Add(new Review { UserId = 3, Description = "Not bad", CreationDate = DateTime.Now, RecipeId = 2 });
            users.Add(new Review { UserId = 3, Description = "Like it", CreationDate = DateTime.Now, RecipeId = 3 });
            users.Add(new Review { UserId = 2, Description = "Tasty", CreationDate = DateTime.Now, RecipeId = 4 });

            var userService = new ReviewService();
            userService.AddItems(users);

            Logger.InitLogger();
            Logger.Log.Info("Add " + users.Count + " review(-s) ");
        }

        public static void AddCompositions()
        {
            List<Composition> compositions = new List<Composition>();
            compositions.Add(new Composition { IngredientId = 1, Quantity = 5, RecipeId = 1 });
            compositions.Add(new Composition { IngredientId = 2, Quantity = 1, RecipeId = 2 });
            compositions.Add(new Composition { IngredientId = 3, Quantity = 2, RecipeId = 2 });
            compositions.Add(new Composition { IngredientId = 5, Quantity = 1, RecipeId = 2 });
            compositions.Add(new Composition { IngredientId = 3, Quantity = 4, RecipeId = 3 });
            compositions.Add(new Composition { IngredientId = 5, Quantity = 3, RecipeId = 3 });
            compositions.Add(new Composition { IngredientId = 6, Quantity = 1, RecipeId = 3 });
            compositions.Add(new Composition { IngredientId = 4, Quantity = 3, RecipeId = 4 });

            var compositionService = new CompositionService();
            compositionService.AddItems(compositions);

            Logger.InitLogger();
            Logger.Log.Info("Add " + compositions.Count + " composition(-s) ");
        }
    }
}
