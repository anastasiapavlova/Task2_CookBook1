using CookBook.BLL.Models;
using CookBook.BLL.Services;
using System.Collections.Generic;

namespace CookBook.BLL.Logic
{
    public class DataReader
    {
        public static List<RecipeModel> ReadRecipes()
        {
            var viewRecipeList = new List<RecipeModel>();
            //var recipeService = new RecipeService();
            //var recipesList = recipeService.GetList();

            //foreach (var recipe in recipesList)
            //{
            //    viewRecipeList.Add(new RecipeModel
            //    {
            //        Id = recipe.Id,
            //        Category = (Enums.CategoryTypes)recipe.Category,
            //        Name = recipe.Name
            //    });
            //}

            return viewRecipeList;
        }

        public static List<UserModel> ReadUsers()
        {
            var viewUserList = new List<UserModel>();
            //var userService = new UserService();
            //var usersList = userService.GetList();

            //foreach (var user in usersList)
            //{
            //    viewUserList.Add(new UserModel()
            //    {
            //        Id = user.Id,
            //        Login = user.Login,
            //        Type = (Enums.AccountTypes)user.Type
            //    });
            //}

            return viewUserList;
        }

        public static List<IngredientModel> ReadIngredients()
        {
            var viewIngredientList = new List<IngredientModel>();
            //var ingredientsService = new IngredientService();
            //var ingrediensList = ingredientsService.GetList();

            //foreach (var ingredient in ingrediensList)
            //{
            //    viewIngredientList.Add(new IngredientModel
            //    {
            //        Id = ingredient.Id,
            //        Name = ingredient.Name
            //    });
            //}

            return viewIngredientList;
        }

        public static List<ReviewModel> ReadReviews()
        {
            var viewReviewList = new List<ReviewModel>();
            //var reviewsService = new ReviewService();
            //var reviewsList = reviewsService.GetList();

            //foreach (var review in reviewsList)
            //{
            //    viewReviewList.Add(new ReviewModel
            //    {
            //        Id = review.Id,
            //        UserId = review.UserId,
            //        Description = review.Description,
            //        CreationDate = review.CreationDate,
            //        RecipeId = review.RecipeId
            //    });
            //}

            return viewReviewList;
        }

        public static List<CompositionModel> ReadCompositions()
        {
            var viewCompositionList = new List<CompositionModel>();
            //var compositionService = new CompositionService();
            //var compositionsList = compositionService.GetList();

            //foreach (var composition in compositionsList)
            //{
            //    viewCompositionList.Add(new CompositionModel
            //    {
            //        Id = composition.Id,
            //        IngredientId = composition.IngredientId,
            //        Quantity = composition.Quantity,
            //        RecipeId = composition.RecipeId
            //    });
            //}

            return viewCompositionList;
        }
    }
}
