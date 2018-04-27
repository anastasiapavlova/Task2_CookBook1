using System;
using System.Collections.Generic;
using BusinessLogic.Enums;
using BusinessLogic.Models;
using BusinessLogic.Services;

namespace ConsolePresentation
{
    class Program
    {
        static void Main(string[] args)
        {
            //read recipes from xml
            var recipeService = new MainService<Recipe>();
            var recipesList = recipeService.GetList();
            foreach (var r in recipesList)
            {
                Console.WriteLine("Рецепт: " + r.Name + "\n Категория: "+ r.Category + "\n Пользователь: " + r.UserId);
            }
            Console.Read();

            //add users to xml
            List<User> users = new List<User>();
            users.Add(new User { Id = 1, Login = "Nastya", Password = "111", Type = AccountType.Admin});
            users.Add(new User { Id = 2, Login = "Meow1", Password = "222", Type = AccountType.User });
            users.Add(new User { Id = 3, Login = "Meow2", Password = "333", Type = AccountType.User });
            var userService = new MainService<User>();
            userService.AddItems(users);

            //check adding users
            var usersList = userService.GetList();
            foreach (var r in usersList)
            {
                Console.WriteLine("User id: " + r.Id + "\n Login: " + r.Login + "\n Type: " + r.Type);
            }
            Console.Read();
            
        }
    }
}
