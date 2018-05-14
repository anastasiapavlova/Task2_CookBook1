using System;
using Ninject;
using System.Linq;
using CookBook.BLL.Models;
using CookBook.BLL.Mappers;
using CookBook.Domain.Models;
using CookBook.BLL.Interfaces;
using CookBook.DAL.Interfaces;
using System.Collections.Generic;

namespace CookBook.BLL.Services
{
    public class UserService : IUserService
    {
        [Inject]
        public IUserRepository UserRepository { get; set; }

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
            UserRepository.Delete(id);
        }

        public void UpdateItem(UserModel item)
        {
            UserRepository.Update(UserMapper.ConvertUserModelToUser(item));
        }
    }
}
