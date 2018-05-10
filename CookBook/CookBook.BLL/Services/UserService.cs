using System;
using System.Linq;
using CookBook.BLL.Models;
using CookBook.Domain.Models;
using CookBook.BLL.Interfaces;
using System.Collections.Generic;
using CookBook.DAL.Interfaces;

namespace CookBook.BLL.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public List<UserModel> GetList()
        {
            var resultList = _userRepository.GetList();

            return resultList.Select(x => new UserModel
            {
                Id = x.Id,
                Login = x.Login,
                Type = (Enums.AccountTypes)x.Type
            }).ToList();
        }

        public void AddItem(User item)
        {
            _userRepository.Add(item);
        }

        public void AddItems(List<User> items)
        {
            _userRepository.AddRange(items);
        }

        public void DeleteItem(Guid id)
        {
            _userRepository.Delete(id);
        }

        public void UpdateItem(User item)
        {
            _userRepository.Update(item);
        }
    }
}
