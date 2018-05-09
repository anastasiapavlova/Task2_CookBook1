using System;
using CookBook.BLL.Models;
using CookBook.Domain.Models;
using System.Collections.Generic;

namespace CookBook.BLL.Interfaces
{
    public interface IUserService
    {
        List<UserModel> GetList();
        void AddItem(User item);
        void AddItems(List<User> items);
        void DeleteItem(Guid id);
        void UpdateItem(User item);
    }
}
