using System;
using System.Collections.Generic;
using System.Linq;
using BusinessLogic.Logging;
using BusinessLogic.Services;
using DataSource.Models;

namespace BusinessLogic.Logic
{
    public static class DataUpdater
    {
        public static void UpdateRecipe()
        {
            var recipe = new RecipeDataModel { Id = 2, Category = "Салат", Name = "Летний", UserId = 3, ReviewsId = new List<int>() { 3, 5 }, CompositionsId = new List<int>() { 5, 8, 1 } };

            var recipesService = new MainService<RecipeDataModel>();
            var recipesList = recipesService.GetList();
            var updatingRecipe = recipesList.FirstOrDefault(s => s.Id == recipe.Id);

            recipesService.UpdateItem(updatingRecipe, recipe);

            Logger.InitLogger();
            Logger.Log.Info("Update recipe " + recipe.Name);
        }

        public static void UpdateIngredient()
        {
            var ingredient = (new IngredientDataModel { Id = 3, Name = "Морковка" });

            var ingredientsService = new MainService<IngredientDataModel>();
            var ingrediensList = ingredientsService.GetList();
            var updatingIngredient = ingrediensList.FirstOrDefault(s => s.Id == ingredient.Id);

            ingredientsService.UpdateItem(updatingIngredient, ingredient);

            Logger.InitLogger();
            Logger.Log.Info("Update ingredient " + ingredient.Name);
        }

        public static void UpdateReview()
        {
            var review = new ReviewDataModel {Id = 1, UserId = 3, Description = "Like it very much.", ReviewDate = DateTime.Now};

            var reviewsService = new MainService<ReviewDataModel>();
            var reviewsList = reviewsService.GetList();
            var updatingReview = reviewsList.FirstOrDefault(s => s.Id == review.Id);

            reviewsService.UpdateItem(updatingReview, review);

            Logger.InitLogger();
            Logger.Log.Info("Update recipe " + review.Id);
        }

    }
}
