using CookBook.Domain.Models;
using System.Collections.Generic;

namespace CookBook.DAL.Interfaces
{
    public interface IUserRepository
    {
        List<User> GetList();
        void AddRange(List<User> items);
        void Update(User updateItem, User item);
        void Delete(User item);
        void Add(User item);
    }
}
