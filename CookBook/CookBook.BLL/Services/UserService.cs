using CookBook.BLL.Interfaces;
using CookBook.DAL.Repositories;
using CookBook.Domain.Models;
using System.Collections.Generic;

namespace CookBook.BLL.Services
{
    public class UserService : IUserService
    {
        private UserRepository repository;

        public UserService()
        {
            repository = new UserRepository();
        }

        public List<User> GetList()
        {
            return repository.GetList();
        }

        public void AddItem(User item)
        {
            repository.Add(item);
        }

        public void AddItems(List<User> items)
        {
            repository.AddRange(items);
        }

        public void DeleteItem(User item)
        {
            repository.Delete(item);
        }

        public void UpdateItem(User item)
        {
            repository.Update(item);
        }
    }
}
