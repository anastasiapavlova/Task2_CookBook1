using System;
using BusinessLogic.Logic;

namespace ConsolePresentation
{
    class Program
    {
        static void Main(string[] args)
        {
            //add list recipes
            DataAdder.AddRecipes();

            //add list ingredients
            DataAdder.AddIngredients();

            //add user list
            DataAdder.AddUsers();

            //add review list
            DataAdder.AddReviews();

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

            //delete recipe
            DataDeleter.DeleteRecipes();

            //delete ingredients
            DataDeleter.DeleteIngredients();

        }
    }
}
