using CookBook.BLL.Logging;
using CookBook.Domain.Models;

namespace CookBook.BLL.Logic
{
    public  class DataUpdater
    {
        public static void UpdateRecipe(Recipe recipe)
        {
            //var recipesService = new RecipeService();

            //recipesService.UpdateItem(recipe);

            //Logger.InitLogger();
            //Logger.Log.Info("Update recipe " + recipe.Name);
        }

        public static void UpdateIngredient(Ingredient ingredient)
        {
            //var ingredientsService = new IngredientService();
            //ingredientsService.UpdateItem(ingredient);

            //Logger.InitLogger();
            //Logger.Log.Info("Update ingredient " + ingredient.Name);
        }

        public static void UpdateReview(Review review)
        {
            //var reviewsService = new ReviewService();
            //reviewsService.UpdateItem(review);

            //Logger.InitLogger();
            //Logger.Log.Info("Update recipe " + review.Id);
        }

        public static void UpdateUser(User user)
        {
            //var userService = new UserService();
            //userService.UpdateItem(user);

            //Logger.InitLogger();
            //Logger.Log.Info("Update user " + user.Id);
        }
    }
}
