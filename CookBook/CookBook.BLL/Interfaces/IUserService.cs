using CookBook.Domain.Models;
using System.Collections.Generic;

namespace CookBook.BLL.Interfaces
{
    public interface IUserService
    {
        List<User> GetList();
        void AddItem(User item);
        void AddItems(List<User> items);
        void DeleteItem(User item);
        void UpdateItem(User updateItem, User item);
    }
}
