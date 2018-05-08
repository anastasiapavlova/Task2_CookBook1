using CookBook.Domain.Models;
using System.Collections.Generic;

namespace CookBook.BLL.Interfaces
{
    public interface IRecipeService
    {
        List<Recipe> GetList();
        void AddItem(Recipe item);
        void AddItems(List<Recipe> items);
        void DeleteItem(int id);
        void UpdateItem(Recipe item);
    }
}
