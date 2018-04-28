using System;
using System.Collections.Generic;
using System.Linq;
using BusinessLogic.Logging;
using BusinessLogic.Services;
using DataSource.Enums;
using DataSource.Models;

namespace BusinessLogic.Logic
{
    public static class DataDeleter
    {
        public static void DeleteRecipes()
        {
            var recipe = new RecipeDataModel { Id = 2, Category = "Салат", Name = "Оливье", UserId = 3, ReviewsId = new List<int>() { 3, 5 }, CompositionsId = new List<int>() { 5, 8, 1 }};
            
            var recipeService = new MainService<RecipeDataModel>();
            recipeService.DeleteItem(recipe);

            DeleteCompositions(recipe);
            
            Logger.InitLogger();
            Logger.Log.Info("Delete recipe " + recipe.Name);
        }

        public static void DeleteIngredient()
        {
            var ingredient = new IngredientDataModel { Id = 1, Name = "Помидор" };

            var ingredientService = new MainService<IngredientDataModel>();
            ingredientService.DeleteItem(ingredient);

            Logger.InitLogger();
            Logger.Log.Info("Delete ingredient " + ingredient.Name);
        }

        public static void DeleteReview()
        {
            var review = new ReviewDataModel { Id = 3, UserId = 2, Description = "Not bad.", ReviewDate = DateTime.Now };

            var reviewService = new MainService<ReviewDataModel>();
            reviewService.DeleteItem(review);

            Logger.InitLogger();
            Logger.Log.Info("Delete review " + review.Id);
        }

        public static void DeleteUser()
        {
            var user = new UserDataModel {Id = 1, Login = "Meow1", Type = AccountType.User, Password = "lala"};

            var userService = new MainService<UserDataModel>();
            userService.DeleteItem(user);

            Logger.InitLogger();
            Logger.Log.Info("Delete user " + user.Login);
        }

        private static void DeleteCompositions(RecipeDataModel recipe)
        {
            var compositionService = new MainService<CompositionDataModel>();
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
