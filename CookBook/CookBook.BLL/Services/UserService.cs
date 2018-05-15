using System;
using Ninject;
using System.Linq;
using CookBook.BLL.Models;
using CookBook.BLL.Mappers;
using CookBook.BLL.Interfaces;
using CookBook.DAL.Interfaces;
using System.Collections.Generic;

namespace CookBook.BLL.Services
{
    public class UserService : IUserService
    {
        [Inject]
        public IUserRepository UserRepository { get; set; }
        [Inject]
        public IRecipeRepository RecipeRepository { get; set; }
        [Inject]
        public ICompositionRepository CompositionRepository { get; set; }
        [Inject]
        public IReviewRepository ReviewRepository { get; set; }

        public List<UserModel> GetList()
        {
            var resultList = UserRepository.GetList();

            return resultList.Select(UserMapper.ConvertUserToUserModel).ToList();
        }

        public void AddItem(UserModel item)
        {
            UserRepository.Add(UserMapper.ConvertUserModelToUser(item));
        }

        public void AddItems(List<UserModel> items)
        {
            UserRepository.AddRange(items.Select(UserMapper.ConvertUserModelToUser).ToList());
        }

        public void DeleteItem(Guid id)
        {
            var recipes = RecipeRepository.GetList().Where(x => x.UserId == id).ToList();
            foreach (var recipe in recipes)
            {
                var compositions = CompositionRepository.GetList().Where(x => x.RecipeId == recipe.Id).ToList();
                compositions.ForEach(x => CompositionRepository.Delete(x.Id));

                var reviews = ReviewRepository.GetList().Where(x => x.RecipeId == recipe.Id).ToList();
                reviews.ForEach(x => ReviewRepository.Delete(x.Id));

                RecipeRepository.Delete(recipe.Id);
            }
            
            UserRepository.Delete(id);
        }

        public void UpdateItem(UserModel item)
        {
            UserRepository.Update(UserMapper.ConvertUserModelToUser(item));
        }
    }
}
