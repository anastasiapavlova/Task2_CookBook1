using CookBook.Domain.Models;
using System.Collections.Generic;

namespace CookBook.BLL.Interfaces
{
    public interface IRecipeService
    {
        List<Recipe> GetList();
        void AddItem(Recipe item);
        void AddItems(List<Recipe> items);
        void DeleteItem(Recipe item);
        void UpdateItem(Recipe item);
    }
}
