using CookBook.BLL.Logging;
using CookBook.BLL.Services;
using CookBook.Domain.Models;
using CookBook.Domain.Enums;
using System.Collections.Generic;

namespace CookBook.BLL.Logic
{
    public static class DataAdder
    {
        public static void AddRecipe(Recipe recipe)
        {
            //var recipeService = new RecipeService();
            //recipeService.AddItem(recipe);

            //Logger.InitLogger();
            //Logger.Log.Info("Add " + recipe.Name);
        }

        public static void AddIngredients()
        {
            //List<Ingredient> ingredients = new List<Ingredient>();
            //ingredients.Add(new Ingredient { Name = "Meat" });
            //ingredients.Add(new Ingredient { Name = "Milk" });
            //ingredients.Add(new Ingredient { Name = "Egg" });
            //ingredients.Add(new Ingredient { Name = "Spaghetti" });
            //ingredients.Add(new Ingredient { Name = "Flour" });
            //ingredients.Add(new Ingredient { Name = "Sugar" });

            //var recipeService = new IngredientService();
            //recipeService.AddItems(ingredients);

            //Logger.InitLogger();
            //Logger.Log.Info("Add " + ingredients.Count + " ingredient(-s) ");
        }

        public static void AddUsers()
        {
            //List<User> users = new List<User>();
            //users.Add(new User { Login = "Nastya", Type = AccountTypes.User, Password = "lala" });
            //users.Add(new User { Login = "Nastya1", Type = AccountTypes.User, Password = "1231" });
            //users.Add(new User { Login = "Lala", Type = AccountTypes.Admin, Password = "2231" });

            //var userService = new UserService();
            //userService.AddItems(users);

            //Logger.InitLogger();
            //Logger.Log.Info("Add " + users.Count + " ingredient(-s) ");
        }

        public static void AddReviews(Review review)
        {
            //var reviewService = new ReviewService();
            //reviewService.AddItem(review);

            //Logger.InitLogger();
            //Logger.Log.Info("Add " + review.Id);
        }

        public static void AddCompositions(List<Composition> compositions)
        {
            //var compositionService = new CompositionService();
            //compositionService.AddItems(compositions);

            //Logger.InitLogger();
            //Logger.Log.Info("Add " + compositions.Count + " composition(-s) ");
        }
    }
}
