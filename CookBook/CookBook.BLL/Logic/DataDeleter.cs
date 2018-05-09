using System;
using CookBook.BLL.Logging;
using CookBook.BLL.Services;
using System.Linq;

namespace CookBook.BLL.Logic
{
    public static class DataDeleter
    {
        public static void DeleteRecipes(Guid id)
        {
            //var compositions = DataReader.ReadCompositions().Where(x => x.RecipeId == id).ToList();
            //compositions.ForEach(x => DeleteComposition(x.Id));

            //var reviews = DataReader.ReadReviews().Where(x => x.RecipeId == id).ToList();
            //reviews.ForEach(x => DeleteReview(x.Id));

            //var recipeService = new RecipeService();
            //recipeService.DeleteItem(id);

            //Logger.InitLogger();
            //Logger.Log.Info("Delete recipe " + id);
        }

        public static void DeleteIngredient(Guid id)
        {
            //var ingredientService = new IngredientService();
            //ingredientService.DeleteItem(id);

            //Logger.InitLogger();
            //Logger.Log.Info("Delete ingredient " + id);
        }

        public static void DeleteReview(Guid id)
        {
            //var reviewService = new ReviewService();
            //reviewService.DeleteItem(id);

            //Logger.InitLogger();
            //Logger.Log.Info("Delete review " + id);
        }

        public static void DeleteUser(Guid id)
        {
            //var userService = new UserService();
            //userService.DeleteItem(id);

            //Logger.InitLogger();
            //Logger.Log.Info("Delete user " + id);
        }

        public static void DeleteComposition(Guid id)
        {
            //var compositionService = new CompositionService();
            //compositionService.DeleteItem(id);

            //Logger.InitLogger();
            //Logger.Log.Info("Delete composition " + id);
        }
    }
}
