using CookBook.BLL.Logging;
using CookBook.BLL.Logic;
using System;

namespace CookBook.Presentation
{
    class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                //add user list
                DataAdder.AddUsers();

                //add list recipes
                DataAdder.AddRecipes();

                //add list ingredients
                DataAdder.AddIngredients();

                //add review list
                DataAdder.AddReviews();

                //add list compositions
                DataAdder.AddCompositions();

                //read existing recipes
                var recipes = DataReader.ReadRecipes();
                foreach (var recipe in recipes)
                {
                    Console.WriteLine("Id: " + recipe.Id + " Name: " + recipe.Name);
                }
                Console.Read();

                //read existing users
                var users = DataReader.ReadUsers();
                foreach (var user in users)
                {
                    Console.WriteLine("Логин: " + user.Login + "\n Тип: " + user.Type + "\n Id: " + user.Id);
                }
                Console.Read();

                //read existing ingredients
                var ingredients = DataReader.ReadIngredients();
                foreach (var ingredient in ingredients)
                {
                    Console.WriteLine("Id: " + ingredient.Id + "\n Имя: " + ingredient.Name);
                }
                Console.Read();

                //read existing review
                var reviews = DataReader.ReadReviews();
                foreach (var review in reviews)
                {
                    Console.WriteLine("Id: " + review.Id + "\n User id" + review.UserId + "\n Описание: " + review.Description + "\n Дата коммента: " + review.CreationDate);
                }
                Console.Read();

                //delete user
                DataDeleter.DeleteUser();

                //delete ingredients
                DataDeleter.DeleteIngredient();

                //delete compositions
                DataDeleter.DeleteComposition();

                //delete recipe
                DataDeleter.DeleteReview();

                //delete recipe
                DataDeleter.DeleteRecipes();

                //update ingredients
                DataUpdater.UpdateIngredient();

                //update review
                DataUpdater.UpdateReview();

                //update user
                DataUpdater.UpdateUser();

                //update recipes
                DataUpdater.UpdateRecipe();
                
            }
            catch (Exception e)
            {
                Logger.InitLogger();
                Logger.Log.Error("Error: " + e);
            }
            finally
            {
                Console.WriteLine("Error occurred.");
                Console.Read();
            }
        }
    }
}
