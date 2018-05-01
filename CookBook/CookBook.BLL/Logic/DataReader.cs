﻿using System.Collections.Generic;
using System.Linq;
using CookBook.BLL.Services;

namespace CookBook.BLL.Logic
{
    public class DataReader
    {
        public static List<Models.Recipe> ReadRecipes()
        {
            var viewRecipeList = new List<Models.Recipe>();
            var recipeService = new MainService<Domain.Models.Recipe>();
            var userService = new MainService<Domain.Models.User>();
            var reviewService = new MainService<Domain.Models.Review>();
            var compositionService = new MainService<Domain.Models.Composition>();

            var recipesList = recipeService.GetList();
            var usersList = userService.GetList();
            var reviewsList = reviewService.GetList();
            var compositionsList = compositionService.GetList();

            foreach (var recipe in recipesList)
            {
                var usersInfo = usersList.FirstOrDefault(s => s.Id == recipe.UserId);
             
                viewRecipeList.Add(new Models.Recipe
                {
                    Id = recipe.Id,
                    Category = (Enums.CategoryTypes)recipe.Category,
                    Name = recipe.Name,
                    UserId = recipe.Id,
                    UserName = usersInfo?.Login,
                });
            }

            return viewRecipeList;
        }

        public static List<Models.User> ReadUsers()
        {
            var viewUserList = new List<Models.User>();
            var userService = new MainService<Domain.Models.User>();
            var usersList = userService.GetList();

            foreach (var user in usersList)
            {
                viewUserList.Add(new Models.User()
                {
                    Id = user.Id,
                    Login = user.Login,
                    Type = (Enums.AccountTypes)user.Type
                });
            }

            return viewUserList;
        }

        public static List<Models.Ingredient> ReadIngredients()
        {
            var viewIngredientList = new List<Models.Ingredient>();
            var ingredientsService = new MainService<Domain.Models.Ingredient>();
            var ingrediensList = ingredientsService.GetList();

            foreach (var ingredient in ingrediensList)
            {
                viewIngredientList.Add(new Models.Ingredient
                {
                    Id = ingredient.Id,
                    Name = ingredient.Name
                });
            }

            return viewIngredientList;
        }

        public static List<Models.Review> ReadReviews()
        {
            var viewReviewList = new List<Models.Review>();
            var reviewsService = new MainService<Domain.Models.Review>();
            var reviewsList = reviewsService.GetList();

            foreach (var review in reviewsList)
            {
                viewReviewList.Add(new Models.Review
                {
                    Id = review.Id,
                    UserId = review.UserId,
                    Description = review.Description,
                    CreationDate = review.CreationDate,
                    RecipeId = review.RecipeId
                });
            }

            return viewReviewList;
        }

        public static List<Models.Composition> ReadComposition()
        {
            var viewCompositionList = new List<Models.Composition>();
            var compositionService = new MainService<Domain.Models.Composition>();
            var compositionsList = compositionService.GetList();

            foreach (var composition in compositionsList)
            {
                viewCompositionList.Add(new Models.Composition
                {
                    Id = composition.Id,
                    IngredientId = composition.IngredientId,
                    Quantity = composition.Quantity,
                    RecipeId = composition.RecipeId
                });
            }

            return viewCompositionList;
        }
    }
}
