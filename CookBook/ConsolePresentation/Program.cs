using System;
using BusinessLogic.Logging;
using BusinessLogic.Logic;

namespace ConsolePresentation
{
    class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                //add list recipes
                DataAdder.AddRecipes();

                //add list ingredients
                DataAdder.AddIngredients();

                //add user list
                DataAdder.AddUsers();

                //add review list
                DataAdder.AddReviews();

                //add list compositions
                DataAdder.AddCompositions();

                //read existing recipes
                var recipes = DataReader.ReadRecipes();
                foreach (var recipe in recipes)
                {
                    Console.WriteLine("Рецепт: " + recipe.Name + "\n Категория: " + recipe.Category + "\n Пользователь: " + recipe.UserName);
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
                    Console.WriteLine("Id: " + review.Id + "\n User id" + review.UserId + "\n Описание: " + review.Description + "\n Дата коммента: " + review.ReviewDate);
                }
                Console.Read();

                //delete user
                DataDeleter.DeleteUser();

                //delete recipe
                DataDeleter.DeleteRecipes();

                //delete ingredients
                DataDeleter.DeleteIngredient();

                //update ingredients
                DataUpdater.UpdateIngredient();

                //update recipes
                DataUpdater.UpdateRecipe();

                //update review
                DataUpdater.UpdateReview();
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
