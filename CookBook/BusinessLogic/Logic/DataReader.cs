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
            var ingredientsService = new MainService<ReviewDataModel>();

            var recipesList = recipeService.GetList();
            var usersList = userService.GetList();
            var reviewsList = reviewService.GetList();

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

                //глянуть логику выгрузки ингридиентов
                
                viewRecipeList.Add(new Recipe
                {
                    Id = recipe.Id,
                    Category = recipe.Category,
                    Name = recipe.Name,
                    UserId = recipe.Id,
                    UserName = usersInfo?.Login,
                    Reviews = reviewsInfo
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
    }
}
