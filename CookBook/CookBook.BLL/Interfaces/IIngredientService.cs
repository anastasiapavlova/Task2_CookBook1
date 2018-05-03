using CookBook.Domain.Models;
using System.Collections.Generic;

namespace CookBook.BLL.Interfaces
{
    public interface IIngredientService
    {
        List<Ingredient> GetList();
        void AddItem(Ingredient item);
        void AddItems(List<Ingredient> items);
        void DeleteItem(Ingredient item);
        void UpdateItem(Ingredient item);
    }
}
