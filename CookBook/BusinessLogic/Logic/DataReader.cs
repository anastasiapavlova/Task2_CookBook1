using System.Collections.Generic;
using System.Linq;
using BusinessLogic.Enums;
using BusinessLogic.Models;
using BusinessLogic.Services;
using DataSource.Models;

namespace BusinessLogic.Logic
{
    public static class DataReader
    {
        public static List<Recipe> ReadRecipes()
        {
            var viewRecipeList = new List<Recipe>();
            var recipeService = new MainService<RecipeDataModel>();
            var userService = new MainService<UserDataModel>();
            var reviewService = new MainService<ReviewDataModel>();
            var compositionService = new MainService<CompositionDataModel>();
            
            var recipesList = recipeService.GetList();
            var usersList = userService.GetList();
            var reviewsList = reviewService.GetList();
            var compositionsList = compositionService.GetList();

            foreach (var recipe in recipesList)
            {
                var usersInfo = usersList.FirstOrDefault(s => s.Id == recipe.UserId);
                var reviewsInfo = (from a in recipe.ReviewsId
                    from b in reviewsList
                    where b.Id.Equals(a)
                    select
                        new Review()
                        {
                            Id = b.Id,
                            UserId = b.UserId,
                            Description = b.Description,
                            ReviewDate = b.ReviewDate
                        }).ToList();

                var compositionsInfo = (from a in recipe.CompositionsId
                    from b in compositionsList
                    where b.Id.Equals(a)
                    select
                        new Composition()
                        {
                            Id = b.Id,
                            IngredientId = b.IngredientId,
                            Quantity = b.Quantity
                        }).ToList();

                viewRecipeList.Add(new Recipe
                {
                    Id = recipe.Id,
                    Category = recipe.Category,
                    Name = recipe.Name,
                    UserId = recipe.Id,
                    UserName = usersInfo?.Login,
                    Reviews = reviewsInfo,
                    Compositions = compositionsInfo
                });
            }
            
            return viewRecipeList;
        }

        public static List<User> ReadUsers()
        {
            var viewUserList = new List<User>();
            var userService = new MainService<UserDataModel>();
            var usersList = userService.GetList();

            foreach (var user in usersList)
            {
                viewUserList.Add(new User
                {
                    Id = user.Id,
                    Login = user.Login,
                    Type = (AccountType) user.Type
                });
            }

            return viewUserList;
        }

        public static List<Ingredient> ReadIngredients()
        {
            var viewIngredientList = new List<Ingredient>();
            var ingredientsService = new MainService<IngredientDataModel>();
            var ingrediensList = ingredientsService.GetList();

            foreach (var ingredient in ingrediensList)
            {
                viewIngredientList.Add(new Ingredient
                {
                    Id = ingredient.Id,
                    Name = ingredient.Name
                });
            }

            return viewIngredientList;
        }

        public static List<Review> ReadReviews()
        {
            var viewReviewList = new List<Review>();
            var reviewsService = new MainService<ReviewDataModel>();
            var reviewsList = reviewsService.GetList();

            foreach (var review in reviewsList)
            {
                viewReviewList.Add(new Review
                {
                    Id = review.Id,
                    UserId = review.UserId,
                    Description = review.Description,
                    ReviewDate = review.ReviewDate
                });
            }

            return viewReviewList;
        }
    }
}
