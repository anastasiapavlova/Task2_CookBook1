using System;
using CookBook.Domain.Models;
using System.Collections.Generic;

namespace CookBook.DAL.Interfaces
{
    public interface IUserRepository
    {
        List<User> GetList();
        void AddRange(List<User> items);
        void Update(User item);
        void Delete(Guid id);
        void Add(User item);
    }
}
