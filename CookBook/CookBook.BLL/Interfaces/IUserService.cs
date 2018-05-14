using System;
using CookBook.BLL.Models;
using System.Collections.Generic;

namespace CookBook.BLL.Interfaces
{
    public interface IUserService
    {
        List<UserModel> GetList();
        void AddItem(UserModel item);
        void AddItems(List<UserModel> items);
        void DeleteItem(Guid id);
        void UpdateItem(UserModel item);
    }
}
